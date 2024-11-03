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
using FinalProjectBaraclan.Models;
using  FinalProjectBaraclan.Repository;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinalProjectBaraclan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

           
        }

        

        //drag topbar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnIniLogin_Click(object sender, EventArgs e)
        {
            //show
            txtId.Visible = true;
            txtPassword.Visible = true;
            lblId.Visible = true;
            lblPassword.Visible = true;
            btnReturn.Visible = true;
            btnFinLogin.Visible = true;


            //hide
            btnIniLogin.Visible = false;
            btnSignup.Visible = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //show
            btnAsStaff.Visible = true;
            btnAsUser.Visible = true;
            btnReturn.Visible = true;
            lblId.Text = "Signup as:";
            lblId.Visible = true;

            //hide
            btnIniLogin.Visible = false;
            btnSignup.Visible = false;

        }

        private void btnFinLogin_Click(object sender, EventArgs e)
        {
            bool validated;
            UserAccount user = new UserAccount();
            user.finalId = txtId.Text;
            user.password = txtPassword.Text;
            user.CheckAuthority(user);

            UserAccount findUser = new UserAccount();
            var repo = new AccountRepository();


            findUser = repo.ReadAccount(user.initailId);
            validated = findUser.ValidateLogin(user.finalId,user.password);

            if (validated)
            {
                this.Hide();
                MainMenu mainmenu = new MainMenu(user.authority,findUser);
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Id or Password");
                this.Hide();
                Login login = new Login();
                login.Show();
            }

        }

        private void btnAsUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup("User");
            signup.ShowDialog();
            this.Close();
        }

        private void btnAsStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup("Employee");
            signup.ShowDialog();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //show
            btnIniLogin.Visible = true;
            btnSignup.Visible = true;

            //hide
            lblId.Text = "Enter Email:";
            lblId.Visible = false;
            lblPassword.Visible = false;
            btnAsStaff.Visible = false;
            btnAsUser.Visible = false;
            txtId.Visible = false;
            txtPassword.Visible = false;
            btnFinLogin.Visible = false;
            btnReturn.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        
    }
}
