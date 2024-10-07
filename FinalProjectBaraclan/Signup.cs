using Microsoft.VisualBasic.Logging;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        String s;
        public Signup(String s)
        {
            InitializeComponent();

            if ("User" == s)
            {
                pnlStaff.Visible = false;
            }
            else if ("Employee" == s) { pnlStaff.Visible = true; }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
