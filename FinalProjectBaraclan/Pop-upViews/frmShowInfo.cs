using FinalProjectBaraclan.Models;
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
    public partial class frmShowInfo : Form
    {

        UserAccount Account = new UserAccount();
        public frmShowInfo(UserAccount user)
        {

            InitializeComponent();
          
            Account = user;
            email.Text = user.email;
            username.Text = user.username;
            password.Text = user.password;
            id.Text = user.finalId;
            address.Text = user.address;
            number.Text = Convert.ToString(user.contactNumber);
            birthdate.Text = Convert.ToString(user.birthDate);
            imgProfilePicture.Image = user.ReturnImage();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
