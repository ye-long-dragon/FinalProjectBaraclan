using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Pop_upViews;
using FinalProjectBaraclan.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace FinalProjectBaraclan.MainMenuViews
{
    public partial class frmConfirmPurchaseShop : Form
    {
        double grandTotal;
        //drag topbar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        string username;
        string finalId;
        DataTable finaldataTable;
        public frmConfirmPurchaseShop(DataTable datatable, UserAccount userAccount)
        {
            InitializeComponent();

            dgvFinalPurchase.DataSource = datatable;
            finaldataTable = datatable;
            username = userAccount.username;
            finalId = userAccount.finalId;
            ReadandReturnTablePrices();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        public void ReadandReturnTablePrices()
        {
            // Reset grand total before calculation
            grandTotal = 0;

            if (dgvFinalPurchase.DataSource is DataTable dataSource)
            {
                int priceLength = dataSource.Rows.Count;

                // Iterate through each row in the DataTable
                for (int i = 0; i < priceLength; i++)
                {
                    DataRow row = dataSource.Rows[i];

                    // Check if the "Total Price" column is not DBNull
                    if (row["Total Price"] != DBNull.Value)
                    {
                        grandTotal += Convert.ToDouble(row["Total Price"]); // Accumulate grand total
                    }
                }

                // Update the label with the grand total
                lblnoTotal.Text = Convert.ToString(grandTotal);


            }

        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {


            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void btnConfirmTransaction_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();

            foreach(DataRow row in finaldataTable.Rows)
            {
                Product product = new Product();

                product.itemName = Convert.ToString(row["Name"]);
                product.itemPrice = Convert.ToDouble(row["Price"]);
                product.quantitySubracted = -Convert.ToInt32(row["Quantity"]);
                double totalPrice = Convert.ToDouble(row["Total Price"]);

                products.Add(product);

               
            }

            var Itemrepo = new ItemRepository();
            List<Receipt> receiptList = new List<Receipt>();
            
            
            foreach (Product product in products)
            {
                Itemrepo.ShopUpdateItemQuantity(product);

                Receipt receipt = new Receipt();
                receipt.itemName = product.itemName;
                receipt.itemPrice = product.itemPrice;
                receipt.itemQuantity = product.quantitySubracted;
                receipt.itemTotalPrice = product.quantitySubracted*product.itemPrice;
                receipt.userAccountName  = username;
                receipt.userAccountId = finalId;
                receipt.finalReceiptId = "";
                

                receiptList.Add(receipt);

                //create initialId
                //generate finalId
                //receipt repository
            }

            var ReceiptRepo = new ReceiptRepository();

            Receipt firstReceipt = receiptList[0];
            ReceiptRepo.ReturnFinalIdIndexZero(firstReceipt);
            receiptList.RemoveAt(0);

            if (Convert.ToDouble(txtPayment.Text) >= firstReceipt.itemTotalPrice)
            {
                ReceiptRepo.CreateReceiptIndexZero(firstReceipt);
                int initialId = ReceiptRepo.ReadIndexZeroId(firstReceipt);
                string finalId = firstReceipt.CreateFinalId();

                foreach (Receipt receipt in receiptList)
                {
                    
                    receipt.finalReceiptId = finalId;
                    ReceiptRepo.CreateReceiptNonZeroIndex(receipt);

                }

               
                MessageBox.Show("You have paid in full");
                this.Close();

            }
            else
            {
                MessageBox.Show("Insufficient Payment");
            }






        }






    }
}
