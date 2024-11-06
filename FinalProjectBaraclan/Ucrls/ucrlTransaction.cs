using FinalProjectBaraclan.Models;
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
    public partial class ucrlTransaction : UserControl
    {
        Receipt list;    

        public ucrlTransaction(Receipt receipt)
        {
            InitializeComponent();
            list = new Receipt();
            list = receipt;

            lblTransactionType.Text = list.type;
            lblTransactionDate.Text = list.date.ToString("yyyy-MM-dd");
        }



        private void btnDownload_Click(object sender, EventArgs e)
        {

            // Debug information
            MessageBox.Show($"Data length: {list.data.Length} bytes");

            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string fileName = $"Receipt_{list.date:yyyyMMdd}_{list.type}.pdf";
            string filePath = Path.Combine(downloadsPath, fileName);

            File.WriteAllBytes(filePath, list.data);
            MessageBox.Show($"PDF downloaded successfully!\nLocation: {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
