using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.PDFMaker;
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

        UserAccount user;
        DataTable finaldataTable;
        public frmConfirmPurchaseShop(DataTable datatable, UserAccount userAccount)
        {
            InitializeComponent();

            dgvFinalPurchase.DataSource = datatable;
            finaldataTable = datatable;
            user = userAccount;
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
            Receipt receipt = new Receipt();
            receipt.userAccountName = user.username;
            receipt.userAccountId = user.finalId;

            double payment = Convert.ToDouble(txtPayment.Text);
            var invoice = new ShopReceipt();
            var document = invoice.GetShopInvoice(finaldataTable, user, payment);

            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fileName = $"{user.username}_Invoice_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string fullPath = Path.Combine(downloadsPath, fileName);

            byte[] pdfBytes;
            using (MemoryStream stream = new MemoryStream())
            {
                document.Save(stream);
                pdfBytes = stream.ToArray();

                File.WriteAllBytes(fullPath, pdfBytes);
            }

            receipt.data = pdfBytes;

            MessageBox.Show($"PDF Receipt saved successfully to:\n{fullPath}", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            var repo = new ReceiptRepository();
            repo.StoreShopReceipt(receipt);
            MessageBox.Show("Receipt Successfully Stored");
            this.Close();
        }












    }
}
