using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
using Microsoft.VisualBasic.Logging;
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

namespace FinalProjectBaraclan
{
    public partial class Signup : Form
    {

        bool isAdmin = false, isEmployee = false, isUser;
        String s;
        public Signup(string s)
        {
            InitializeComponent();

            AccountRepository accountRepository = new AccountRepository();
            accountRepository.ReadAccount();
            UserAccount account = new UserAccount();
            isUser = true;

            if ("User" == s)
            {
                pnlStaff.Visible = false;
                account.isUser = true;


            }
            else if ("Employee" == s)
            {
                pnlStaff.Visible = true;


            }
        }

        //drag topbar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            UserAccount newUser = new UserAccount();
            var repo = new AccountRepository();

            if (isAdmin == true)
            {
                isUser = false;
                isEmployee = false;
                newUser.isAdmin = true;
            }
            else if (isEmployee == true)
            {
                isUser = false;
                isAdmin = false;
                newUser.isEmployee = true;
            }
            

            
            newUser.isAdmin = isAdmin;
            newUser.isEmployee = isEmployee;
            newUser.isUser = isUser;
            newUser.finalId = " ";
            newUser.email = txtEmail.Text;
            newUser.username = txtUsername.Text;
            newUser.password = txtPassword.Text;
            newUser.rePassword = txtRePassword.Text;
            newUser.birthDate = Convert.ToDateTime(txtBirthdate.Text);
            newUser.contactNumber = (int)Convert.ToInt64(txtCoNumber.Text);
            newUser.address = txtAddress.Text;
            
            repo.createAccount(newUser);
            newUser.initailId = repo.ReadAccountInitialId(newUser);
            newUser.finalId = newUser.GenerateId(newUser.initailId);
            MessageBox.Show(Convert.ToString(newUser.finalId));
            repo.UpdateAccountId(newUser);

                this.Hide();
                Login login = new Login();
                login.Show();
            
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void radbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = true;
        }

        private void radbtnEmployee_CheckedChanged_1(object sender, EventArgs e)
        {
            isEmployee = true;
        }
    }
}
