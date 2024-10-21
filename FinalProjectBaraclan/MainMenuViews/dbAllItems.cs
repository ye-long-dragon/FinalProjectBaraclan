using FinalProjectBaraclan.MainMenuViews;
using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
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

        List<Product> items = new List<Product>();
        double grandTotal;
        int itemLength = 0;
        bool itemLengthPass = false;
        public dbAllItems()
        {
            InitializeComponent();
            //flow layout size 1269, 616
            pnlInvoice.BringToFront();

           
            TakeAndReturnUCData();
            

        }


        private void dbAllItems_Load(object sender, EventArgs e)
        {
            var repo = new ItemRepository();

            LoadItems(repo.GetItemDataView());


        }

        public void LoadItems(List<Product> products)
        {

            foreach (Product product in products)
            {
                urclItem urclItem = new urclItem(product);
                urclItem.addClicked += urclItem_btnAdd_Clicked;
                urclItem.droppedClicked += urclItem_btnDropped_Clicked;
                flpItemView.Controls.Add(urclItem);
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

                // Only process if the item is added or dropped
                if (item.isAdded > 0 && item.isDropped == 0)
                {
                    item.CheckStatus();

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
                    {
                        grandTotal += Convert.ToDouble(row["Total Price"]); // Accumulate grand total
                    }
                }

                // Update the label with the grand total
                lblnoTotal.Text = Convert.ToString(grandTotal);
            }
            
        }





    }
}
