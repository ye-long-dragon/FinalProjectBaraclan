using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
using Microsoft.IdentityModel.Tokens;
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

namespace FinalProjectBaraclan.Pop_upViews
{
    public partial class frmAddItem : Form
    {
        //drag topbar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string filePath = "";
        Byte[] imageByteArray;
        public bool isGrocery, isRestaurant, isMerchandise;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Images(.jpg,.png)|*.jpg;*.png ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filePath = ofd.FileName;
                imgProduct.Image = new Bitmap(filePath);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        imageByteArray = binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }
            }

            using (MemoryStream ms = new MemoryStream(imageByteArray))
            {
                Image img = Image.FromStream(ms);
                imgProduct.Image = img; // Assign the image to the PictureBox
            }


        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedIndex == -1 && string.IsNullOrEmpty(txtCost.Text)&&string.IsNullOrEmpty(txtName.Text)&&
                string.IsNullOrEmpty(txtPrice.Text)&&string.IsNullOrEmpty(txtQuantity.Text) && imageByteArray.IsNullOrEmpty()) {
                MessageBox.Show("Input all Items");
                return;

            }
            else{ 
            Product product = new Product();
            var repo = new ItemRepository();

            if (cmbProductType.SelectedIndex == 0)
            {
                isGrocery = true;
                isMerchandise = false;
                isRestaurant = false;
                product.isGrocery = isGrocery;
            }
            else if (cmbProductType.SelectedIndex == 1)
            {
                isMerchandise = true;
                isGrocery = false;
                isRestaurant = false;
                product.isMerchandise = isMerchandise;
            }
            else if (cmbProductType.SelectedIndex == 2)
            {
                isRestaurant = true;
                isGrocery = false;
                isMerchandise = false;
                product.isRestaurant = isRestaurant;
            }

            product.itemName = txtName.Text;
            product.finalIdItem = " ";
            product.itemCost = Convert.ToDouble(txtCost.Text);
            product.itemPrice = Convert.ToDouble(txtPrice.Text);
            product.itemQuantity = Convert.ToInt32(txtQuantity.Text);
            product.itemImageArray = imageByteArray;

            repo.createProduct(product);
            product.initialIdItem = repo.ReadProductInitialId(product);
            product.finalIdItem = product.GenerateId(product.initialIdItem);
            repo.UpdateProductId(product);

            MessageBox.Show("Item Successfully Added", "Item State");



            this.Close();

        }
        }

        private void frmAddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbInventory dbInventory = (dbInventory)Application.OpenForms["dbInventory"];

            dbInventory.ReadItems();

        }
    }
}
;