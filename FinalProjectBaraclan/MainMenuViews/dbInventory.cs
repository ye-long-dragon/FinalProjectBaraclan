using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Pop_upViews;
using FinalProjectBaraclan.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBaraclan
{
    public partial class dbInventory : Form
    {

        frmAddItem frmAddItem = new frmAddItem();
        UserAccount account;
        public dbInventory(UserAccount userAccount)
        {
            InitializeComponent();

            ReadItems();

            account = userAccount;
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
            dataTable.Columns.Add("Price",typeof(decimal));

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
                row["Price"] = item.itemPrice;


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
            dataTable.Columns.Add("Price", typeof(decimal));

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
                    row["Price"] = item.itemPrice;


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
            dataTable.Columns.Add("Price", typeof(decimal));


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
                    row["Price"] = item.itemPrice;


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
                DataGridViewRow dataGridViewRow = dgvInventoryView.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)dataGridViewRow.DataBoundItem).Row;

                Product item = new Product();
                item.finalIdItem = Convert.ToString(dataRow["ID"]);
                item.itemName = Convert.ToString(dataRow["Name"]);
                item.itemQuantity = Convert.ToInt32(dataRow["Quantity"]);
                item.itemCost = Convert.ToDouble(dataRow["Cost"]);
                item.itemPrice = Convert.ToDouble(dataRow["Price"]);

                // Handle image
                if (dataRow[0] is Image sourceImage)
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var bitmap = new Bitmap(sourceImage.Width, sourceImage.Height))
                        {
                            using (var graphics = Graphics.FromImage(bitmap))
                            {
                                graphics.DrawImage(sourceImage, 0, 0, sourceImage.Width, sourceImage.Height);
                            }
                            bitmap.Save(ms, ImageFormat.Jpeg);
                            item.itemImageArray = ms.ToArray();
                        }
                    }
                }

                frmUpdateProduct frmUpdateProduct = new frmUpdateProduct( item);
                frmUpdateProduct.ShowDialog();


            }
            //delete
            if (dgvInventoryView.CurrentCell.OwningColumn.Name == "imgDelete")
            {
                int rowIndex = dgvInventoryView.CurrentRow.Index;
                string id = Convert.ToString(dgvInventoryView.Rows[rowIndex].Cells["ID"].Value);  // Replace "ID" with your actual ID column name
                DialogResult result = MessageBox.Show("Are you sure you would like to delete the Item?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show(id);

                if (result == DialogResult.Yes)
                {
                    var repo = new ItemRepository();
                    repo.DeleteAccount(id);
                    MessageBox.Show("Account deleted successfully.");
                }
                else
                {
                    return;
                }


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
