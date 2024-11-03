using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBaraclan.Ucrls
{
    public partial class ucrlDay : UserControl
    {
        public ucrlDay()
        {
            InitializeComponent();

            lblReservation.Visible = false;
        }


        public void days(int num)
        {
            lblNumber.Text = num.ToString() + "";
        }


        public event EventHandler reserved;
        private void btnReserve_Click(object sender, EventArgs e)
        {
            reserved?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler cancelled;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelled?.Invoke(this, EventArgs.Empty);
        }
    }
}
