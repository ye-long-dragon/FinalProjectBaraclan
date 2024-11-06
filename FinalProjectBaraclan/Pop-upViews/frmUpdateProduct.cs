using FinalProjectBaraclan.Models;
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

namespace FinalProjectBaraclan.Pop_upViews
{
    public partial class frmUpdateProduct : Form
    {
        public string filePath = "";
        public Byte[] image;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        Product item = new Product();

        public frmUpdateProduct(Product product)
        {
            InitializeComponent();

            item = product;
            txtName.Text = item.itemName;
            txtQuantity.Text = Convert.ToString(item.itemQuantity);
            txtCost.Text = Convert.ToString(item.itemCost);
            txtPrice.Text = Convert.ToString(item.itemPrice);
            imgImage.Image = item.ReturnImage();

            if (item.finalIdItem[0] == 'R')
            {
                cmbCategory.SelectedIndex = 0;
            }
            else if (item.finalIdItem[0] == 'G')
            {
                cmbCategory.SelectedIndex = 1;
            }
            else if (item.finalIdItem[0] == 'U')
            {
                cmbCategory.SelectedIndex = 2;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == 0)
            {
                item.finalIdItem = "R" + item.finalIdItem.Substring(1);
            }
            else if (cmbCategory.SelectedIndex == 1)
            {
                item.finalIdItem = "G" + item.finalIdItem.Substring(1);
            }
            else if (cmbCategory.SelectedIndex == 2)
            {
                item.finalIdItem = "M" + item.finalIdItem.Substring(1);
            }

            lblInputId.Text = item.finalIdItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var repo = new ItemRepository();
            item.itemImageArray = image;
            item.itemName = txtName.Text;
            item.itemCost = Convert.ToDouble(txtCost.Text);
            item.itemPrice = Convert.ToDouble(txtPrice.Text);
            item.itemQuantity = Convert.ToInt32(txtQuantity.Text);
            item.finalIdItem = lblInputId.Text;
           
            repo.UpdateItem(item);
            MessageBox.Show("Item Successfully Updated");

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            txtCost.Enabled = false;
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
            cmbCategory.Enabled = false;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
            cmbCategory.Enabled = true;
            txtCost.Enabled = true;
            txtName.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Images(.jpg,.png)|*.jpg;*.png ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filePath = ofd.FileName;
                imgImage.Image = new Bitmap(filePath);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        image = binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }
            }


            using (MemoryStream ms = new MemoryStream(image))
            {
                Image img = Image.FromStream(ms);
                imgImage.Image = img; // Assign the image to the PictureBox
                imgImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            item.itemImageArray = image;
        }
    }
}
