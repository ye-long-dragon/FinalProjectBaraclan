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
