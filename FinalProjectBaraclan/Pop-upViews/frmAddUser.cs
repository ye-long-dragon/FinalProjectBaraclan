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
    public partial class frmAddUser : Form
    {
        string filePath = "";
        public Byte[] image { get; set; }
        UserAccount userAccount = new UserAccount();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
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

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text) &&
                string.IsNullOrEmpty(txtPassword.Text) &&
                string.IsNullOrEmpty(txtNumber.Text) &&
                string.IsNullOrEmpty(txtUsername.Text) &&
                string.IsNullOrEmpty(txtEmail.Text) &&
                cmbAuthority.SelectedIndex == -1 &&
                string.IsNullOrEmpty(txtBirthDate.Text) &&
                image.IsNullOrEmpty())
            {
                MessageBox.Show("Input all Items");
                return; }
            else
            {
                txtAddress.Enabled = false;
                txtPassword.Enabled = false;
                txtNumber.Enabled = false;
                txtUsername.Enabled = false;
                txtEmail.Enabled = false;
                cmbAuthority.Enabled = false;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
            txtPassword.Enabled = true;
            txtNumber.Enabled = true;
            txtUsername.Enabled = true;
            txtEmail.Enabled = true;
            cmbAuthority.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Enabled)
            {
                userAccount.birthDate = Convert.ToDateTime(txtBirthDate.Text);
                userAccount.username = txtUsername.Text;
                userAccount.password = txtPassword.Text;
                userAccount.rePassword = txtPassword.Text;
                userAccount.email = txtEmail.Text;
                userAccount.address = txtAddress.Text;
                userAccount.contactNumber = Convert.ToInt32(txtNumber.Text);
                userAccount.image = image;
                userAccount.finalId = " ";

                var repo = new AccountRepository();
                repo.createAccount(userAccount);
                userAccount.initailId = repo.ReadAccountInitialId(userAccount);
                userAccount.finalId = userAccount.GenerateId(userAccount.initailId);
                repo.UpdateAccountId(userAccount);

                MessageBox.Show("Account Successfully Added");

                this.Hide();

            }

        }

        private void cmbAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthority.SelectedIndex == 0)
            {
                userAccount.isAdmin = true;
                
            }
            else if (cmbAuthority.SelectedIndex == 1)
            {
               userAccount.isEmployee = true;
               
            }
            else if (cmbAuthority.SelectedIndex == 2)
            {
                userAccount.isUser = true;
                
            }

            
        }
    }
}
