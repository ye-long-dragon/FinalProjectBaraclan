using FinalProjectBaraclan.Models;
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

        frmAddItem frmAddItem = new frmAddItem();
        public dbInventory()
        {
            InitializeComponent();

            ReadItems();

            
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {

            frmAddItem.ShowDialog();
        }

        public void ReadItems()
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Cost", typeof(decimal));

            var repo = new ItemRepository();
            var items = repo.ReadItems();

            foreach (var item in items)
            {

                DataRow row = dataTable.NewRow();
                row["Image"] = item.ReturnImage();
                row["Category"] = item.ReturnCategory();
                row["ID"] = item.finalIdItem;
                row["Name"] = item.itemName;
                row["Quantity"] = item.itemQuantity;
                row["Cost"] = item.itemCost;


                dataTable.Rows.Add(row);
            }


            this.dgvInventoryView.DataSource = dataTable;


            dgvInventoryView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void ReadSpecificItems(string category)
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Cost", typeof(decimal));

            var repo = new ItemRepository();
            var items = repo.ReadItems();

            foreach (var item in items)
            {
                if (category == item.ReturnCategory())
                {
                    DataRow row = dataTable.NewRow();
                    row["Image"] = item.ReturnImage();
                    row["Category"] = item.ReturnCategory();
                    row["ID"] = item.finalIdItem;
                    row["Name"] = item.itemName;
                    row["Quantity"] = item.itemQuantity;
                    row["Cost"] = item.itemCost;


                    dataTable.Rows.Add(row);
                }

            }


            this.dgvInventoryView.DataSource = dataTable;


            dgvInventoryView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void SearchSpecificItems(string searchString)
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Cost", typeof(decimal));

            var repo = new ItemRepository();
            var items = repo.ReadItems();
            

            foreach (var item in items)
            {
                if (searchString == item.ReturnStringIndexArray(searchString.Length))
                {
                    DataRow row = dataTable.NewRow();
                    row["Image"] = item.ReturnImage();
                    row["Category"] = item.ReturnCategory();
                    row["ID"] = item.finalIdItem;
                    row["Name"] = item.itemName;
                    row["Quantity"] = item.itemQuantity;
                    row["Cost"] = item.itemCost;


                    dataTable.Rows.Add(row);
                }

            }


            this.dgvInventoryView.DataSource = dataTable;


            dgvInventoryView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvInventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //update
            if (dgvInventoryView.CurrentCell.OwningColumn.Name == "imgAdd")
            {

            }
            //delete
            if (dgvInventoryView.CurrentCell.OwningColumn.Name == "imgDelete")
            {
                int id = Convert.ToInt32(dgvInventoryView.CurrentRow.Cells["imgDelete"].Value);

            }

        }

        private void cmbCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbCategoryType.SelectedIndex;


            if (index == 1)
            {

                ReadSpecificItems("Grocery");
            }
            else if (index == 2)
            {
                ReadSpecificItems("Merchandise");
            }
            else if (index == 3)
            {
                ReadSpecificItems("Restaurant");
            }
            else
            {
                ReadItems();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


           string searchText = txtSearch.Text;

            SearchSpecificItems(searchText);
        }
    }
}
