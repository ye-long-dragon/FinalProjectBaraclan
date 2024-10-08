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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniLogin_Click(object sender, EventArgs e)
        {
            //show
            txtEmail.Visible = true;
            txtPassword.Visible = true;
            lblEmail.Visible = true;
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
            lblEmail.Text = "Signup as:";
            lblEmail.Visible = true;

            //hide
            btnIniLogin.Visible = false;
            btnSignup.Visible = false;

        }

        private void btnFinLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu("Hi");
            mainMenu.ShowDialog();
            this.Close();
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
            lblEmail.Text = "Enter Email:";
            lblEmail.Visible = false;
            lblPassword.Visible = false;
            btnAsStaff.Visible = false;
            btnAsUser.Visible = false;
            txtEmail.Visible = false;
            txtPassword.Visible = false;
            btnFinLogin.Visible = false;
            btnReturn.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
