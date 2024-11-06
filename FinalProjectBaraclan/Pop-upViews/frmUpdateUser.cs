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
    public partial class frmUpdateUser : Form
    {
        string filePath = "";
        public Byte[] image { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        UserAccount UserAccount = new UserAccount();
        public frmUpdateUser(UserAccount User)
        {
            InitializeComponent();
            UserAccount = User;

            txtUsername.Text = UserAccount.username;
            txtPassword.Text = UserAccount.password;
            txtEmail.Text = UserAccount.email;
            txtAddress.Text = UserAccount.address;
            txtNumber.Text = Convert.ToString(UserAccount.contactNumber);
            lblIdFinal.Text = UserAccount.finalId;

            if (UserAccount.finalId[0] == 'A')
            {
                cmbAuthority.SelectedIndex = 0;
            }
            else if (UserAccount.finalId[0] == 'E')
            {
                cmbAuthority.SelectedIndex = 1;
            }
            else if (UserAccount.finalId[0] == 'U')
            {
                cmbAuthority.SelectedIndex = 2;
            }

            using (MemoryStream ms = new MemoryStream(User.image))
            {
                Image img = Image.FromStream(ms);
                imgImage.Image = img; // Assign the image to the PictureBox
                imgImage.SizeMode = PictureBoxSizeMode.Zoom;
            }


        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void cmbAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthority.SelectedIndex == 0)
            {
                UserAccount.finalId = "A" + UserAccount.finalId.Substring(1);
            }
            else if (cmbAuthority.SelectedIndex == 1)
            {
                UserAccount.finalId = "E" + UserAccount.finalId.Substring(1);
            }
            else if (cmbAuthority.SelectedIndex == 2)
            {
                UserAccount.finalId = "U" + UserAccount.finalId.Substring(1);
            }

            lblIdFinal.Text = UserAccount.finalId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = false;
            txtPassword.Enabled = false;
            txtNumber.Enabled = false;
            txtUsername.Enabled = false;
            txtEmail.Enabled = false;
            cmbAuthority.Enabled = false;

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
            if (txtAddress.Enabled == false)
            {
                var repo = new AccountRepository();
                repo.UpdateAccount(UserAccount);
                MessageBox.Show("Account Changed");
                this.Hide();
            }
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
    }
}
