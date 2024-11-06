using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace FinalProjectBaraclan.Pop_upViews
{
    public partial class frmAddRooms : Form
    {
        public frmAddRooms()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        Byte[] imageByteArray;
        public string filePath = "";

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<string> roomStyle = new List<string>
            {
                "Standard Room",
                "Deluxe Room",
                "Joint Room",
                "Suite",
                "Cabana",
                "Villa",


                };
            List<string> bedStyle = new List<string>
            {
                "Twin Size (1)",
                "Twin Size (2)",
                "Queen Size",
                "King Size",
            };

            Room room = new Room();
            var repo = new RoomRepository();

            room.roomStyle = "";
            room.bedStyle = "";

            //if else roomstyle
            switch (cmbRoomStyle.SelectedIndex)
            {
                case 0:
                    room.roomStyle =Convert.ToString(roomStyle[0]);
                    break;
                case 1:
                    room.roomStyle = Convert.ToString(roomStyle[1]);
                    break;
                case 2:
                    room.roomStyle = Convert.ToString(roomStyle[2]);
                    break;
                case 3:
                    room.roomStyle = Convert.ToString(roomStyle[3]);
                    break;
                case 4:
                    room.roomStyle = Convert.ToString(roomStyle[4]);
                    break;
                case 5:
                    room.roomStyle = Convert.ToString(roomStyle[5]);
                    break;
            }


            //if else bed style
            switch (cmbBedStyle.SelectedIndex)
            {
                case 0:
                    room.bedStyle = Convert.ToString(bedStyle[0]);
                    break;
                case 1:
                    room.bedStyle = Convert.ToString(bedStyle[1]);
                    break;
                case 2:
                    room.bedStyle = Convert.ToString(bedStyle[2]);
                    break;
                case 3:
                    room.bedStyle = Convert.ToString(bedStyle[3]);
                    break;
                
            }


            room.id = Convert.ToInt32(txtRoomId.Text);
            room.imgRoom = imageByteArray;
            room.price = Convert.ToDouble(txtPrice.Text);
            repo.AddRoom(room);
            MessageBox.Show("Room Added");

            this.Close();





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
