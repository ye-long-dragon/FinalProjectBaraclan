using FinalProjectBaraclan.MainMenuViews;
using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
using FinalProjectBaraclan.Ucrls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBaraclan
{
    public partial class dbAllItems : Form
    {
        DataTable temp = new DataTable();
        List<Product> items = new List<Product>();
        double grandTotal;
        int itemLength = 0;
        bool itemLengthPass = false;

        UserAccount userAccount;
        public dbAllItems(UserAccount user)
        {
            InitializeComponent();
            //flow layout size 1269, 616
            pnlInvoice.BringToFront();
<<<<<<< HEAD:FinalProjectBaraclan/MainMenuViews/dbAllItems.cs
            
=======

>>>>>>> ccb3649618f40194428c4667620a5b5c483bbe18:FinalProjectBaraclan/MainMenuViews/dbShop.cs

            TakeAndReturnUCData();

            userAccount = user;
        }

        List<Product> items = new List<Product>();
        double grandTotal;
        int itemLength = 0;
        bool itemLengthPass = false;



        private void dbAllItems_Load(object sender, EventArgs e)
        {
            var repo = new ItemRepository();

            LoadItems(repo.GetItemDataView());
            TakeandReturnUCData();


        }

        public void LoadItems(List<Product> products)
        {

            foreach (Product product in products)
            {
                if (product.itemQuantity > 0)
                {
                    urclItem urclItem = new urclItem(product);
                    urclItem.addClicked += urclItem_btnAdd_Clicked;
                    urclItem.droppedClicked += urclItem_btnDropped_Clicked;
                    flpItemView.Controls.Add(urclItem);
                }
            }


        }

        public void urclItem_btnAdd_Clicked(object sender, EventArgs e)
        {
            TakeAndReturnUCData();
            ReadandReturnTablePrices();
        }

        public void urclItem_btnDropped_Clicked(object sender, EventArgs e)
        {
            TakeAndReturnUCData();
            ReadandReturnTablePrices();
        }

        public void TakeAndReturnUCData()
        {
            DataTable dataTable = new DataTable();

            // Define columns for the DataTable
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("Total Price", typeof(double));

            // Iterate through each user control in the flow layout panel
            foreach (urclItem urclItem in flpItemView.Controls)
            {
                Product item = urclItem.ReturnItem();

                foreach (Product item in items)
                {

<<<<<<< HEAD:FinalProjectBaraclan/MainMenuViews/dbAllItems.cs
                    if (item.isAdded > 0 || item.isDropped > 0)
=======
                    DataRow row = dataTable.NewRow();
                    row["Name"] = item.itemName;
                    row["Quantity"] = item.quantitySubracted;
                    row["Price"] = item.itemPrice;
                    row["Total Price"] = item.itemPrice * item.quantitySubracted;
                    dataTable.Rows.Add(row);
                }
            }

            // Set the DataSource of the DataGridView after adding all rows
            dgvInvoicing.DataSource = dataTable;
            temp = dataTable.Copy();
        }

        

        public void ReadandReturnTablePrices()
        {
            // Reset grand total before calculation
            grandTotal = 0;

            if (dgvInvoicing.DataSource is DataTable dataSource)
            {
                int priceLength = dataSource.Rows.Count;

                // Iterate through each row in the DataTable
                for (int i = 0; i < priceLength; i++)
                {
                    DataRow row = dataSource.Rows[i];

                    // Check if the "Total Price" column is not DBNull
                    if (row["Total Price"] != DBNull.Value)
>>>>>>> ccb3649618f40194428c4667620a5b5c483bbe18:FinalProjectBaraclan/MainMenuViews/dbShop.cs
                    {
                        // Create a new DataRow for the DataTable
                        DataRow row = dataTable.NewRow();
                        row["Name"] = item.itemName;
                        row["Quantity"] = item.quantitySubracted;
                        row["Price"] = item.itemPrice;
                        row["Total Price"] = item.quantitySubracted * item.itemPrice;

                        // Add the row to the DataTable
                        dataTable.Rows.Add(row);

                        // Update grand total
                        grandTotal += item.quantitySubracted * item.itemPrice;
                    }


                    // Bind the DataTable to the table view (replace 'YourTableControl' with your control name)
                    dgvInvoicing.DataSource = dataTable;

                    // Update the Grand Total label
                    lblnoTotal.Text = $"Grand Total: {grandTotal.ToString()}";


                    

                

<<<<<<< HEAD:FinalProjectBaraclan/MainMenuViews/dbAllItems.cs
            }
=======
                // Update the label with the grand total
                lblnoTotal.Text = Convert.ToString(grandTotal);

                
            }

>>>>>>> ccb3649618f40194428c4667620a5b5c483bbe18:FinalProjectBaraclan/MainMenuViews/dbShop.cs
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            frmConfirmPurchaseShop frmConfirmPurchaseShop = new frmConfirmPurchaseShop(temp,userAccount);
            frmConfirmPurchaseShop.ShowDialog();

<<<<<<< HEAD:FinalProjectBaraclan/MainMenuViews/dbAllItems.cs
        private void refreshTable_Tick(object sender, EventArgs e)
        {
               TakeandReturnUCData();
        }
=======
        }


>>>>>>> ccb3649618f40194428c4667620a5b5c483bbe18:FinalProjectBaraclan/MainMenuViews/dbShop.cs
    }
}
