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
        public dbAllItems()
        {
            InitializeComponent();
            //flow layout size 1269, 616
            pnlInvoice.BringToFront();
            

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
                urclItem urclItem = new urclItem(product);
                flpItemView.Controls.Add(urclItem);
            }


        }

        public void TakeandReturnUCData()
        {
            

            // Create a DataTable to store the item information
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Price", typeof(double));
            dataTable.Columns.Add("Total Price", typeof(double));

            // Clear any existing data in the items list
            items.Clear();

            foreach (urclItem itemPanel in flpItemView.Controls)
            {
                if (itemPanel.colorSelected == true)
                {
                    items.Add(itemPanel.ReturnItem()); // Get selected item
                }
            }

                foreach (Product item in items)
                {

                    if (item.isAdded > 0 || item.isDropped > 0)
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


                    

                

            }
        }


        private void refreshTable_Tick(object sender, EventArgs e)
        {
               TakeandReturnUCData();
        }
    }
}
