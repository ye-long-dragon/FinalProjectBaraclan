using FinalProjectBaraclan.Pop_upViews;
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
    public partial class dbInventory : Form
    {
        public dbInventory()
        {
            InitializeComponent();

            ReadItems();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            frmAddItem frmAddItem = new frmAddItem();
            frmAddItem.ShowDialog();
        }

        public void ReadItems()
        {
            // Create a DataTable to hold the items
            DataTable dataTable = new DataTable();

            // Assuming your DataGridView already has the correct columns set up,
            // we will define the columns in the DataTable to match those in the DataGridView.
            dataTable.Columns.Add("Image", typeof(Image)); // Assuming you have an Image column
            dataTable.Columns.Add("ID", typeof(string));      // Assuming you have an ID column
            dataTable.Columns.Add("Name", typeof(string));  // Assuming you have a Name column
            dataTable.Columns.Add("Quantity", typeof(int)); // Assuming you have a Quantity column
            dataTable.Columns.Add("Cost", typeof(decimal));  // Assuming you have a Cost column

            var repo = new ItemRepository();
            var items = repo.ReadItems();

            foreach (var item in items)
            {
                // Create a new DataRow for each item
                DataRow row = dataTable.NewRow();
                row["Image"] = item.ReturnImage(); // Assuming this returns an Image object
                row["ID"] = item.finalIdItem;
                row["Name"] = item.itemName;
                row["Quantity"] = item.itemQuantity;
                row["Cost"] = item.itemCost;

                // Add the row to the DataTable
                dataTable.Rows.Add(row);
            }

            // Set the DataSource of the Guna2DataGridView to the DataTable
            this.dgvInventoryView.DataSource = dataTable;

            // Optional: Configure DataGridView settings if needed
            dgvInventoryView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvInventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if(dgvInventoryView.CurrentCell.OwningColumn.Name == "imgAdd")
            { 
                
            }

            if(dgvInventoryView.CurrentCell.OwningColumn.Name == "imgDelete")
            {
                int id = Convert.ToInt32(dgvInventoryView.CurrentRow.Cells["imgDelete"].Value);

            }

        }
    }
}
