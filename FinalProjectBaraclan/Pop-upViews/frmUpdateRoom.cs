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
    public partial class frmUpdateRoom : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        Byte[] imageByteArray;
        public string filePath = "";

        public frmUpdateRoom()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Images(.jpg,.png)|*.jpg;*.png ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filePath = ofd.FileName;
                imgRoom.Image = new Bitmap(filePath);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        imageByteArray = binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }
            }

            using (MemoryStream ms = new MemoryStream(imageByteArray))
            {
                Image img = Image.FromStream(ms);
                imgRoom.Image = img; // Assign the image to the PictureBox
            }
        }
    }
}
