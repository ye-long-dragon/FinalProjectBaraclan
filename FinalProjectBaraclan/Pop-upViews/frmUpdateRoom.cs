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
    public partial class frmUpdateRoom : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);

        Byte[] imageByteArray;
        public string filePath = "";
        Room Room1 { get; set; }
        Room Room2 { get; set; }

        public frmUpdateRoom(Room room)
        {
            InitializeComponent();
            Room1 = room;
            Room2 = room;
            txtPrice.Text = Convert.ToString(room.price);
            txtRoomId.Text = Convert.ToString(room.id);
            imgRoom.Image = room.ReturnImage();

            switch (room.roomStyle)
            {
                case "Standard Room":
                    cmbRoomStyle.SelectedIndex = 0;
                    break;
                case "Deluxe Room":
                    cmbRoomStyle.SelectedIndex = 1;
                    break;
                case "Joint Room":
                    cmbRoomStyle.SelectedIndex = 2;
                    break;
                case "Suite":
                    cmbRoomStyle.SelectedIndex = 3;
                    break;
                case "Cabana":
                    cmbRoomStyle.SelectedIndex = 4;
                    break;
                case "Villa":
                    cmbRoomStyle.SelectedIndex = 5;
                    break;
            }

            switch (room.bedStyle)
            {
                case "Twin Size(1)":
                    cmbBedStyle.SelectedIndex = 0; break;
                case "Twin Size(2)":
                    cmbBedStyle.SelectedIndex = 1; break;
                case "Queen Size":
                    cmbBedStyle.SelectedIndex = 2; break;
                case "King Size":
                    cmbBedStyle.SelectedIndex = 3; break;
            }
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (imageByteArray != null)
            {
                Room1.imgRoom = imageByteArray;
            }
            else { Room1.imgRoom = Room1.imgRoom;}

            Room1.price = Convert.ToDouble(txtPrice.Text);
            Room1.id = Convert.ToInt32(txtRoomId.Text);
            switch (cmbRoomStyle.SelectedIndex)
            {
                case 0:
                    Room1.roomStyle = "Standard Room";
                    break;
                case 1:
                     Room1.roomStyle = "Deluxe Room";
                    break;
                case 2:
                    Room1.roomStyle = "Joint Room";
                    break;
                case 3:
                    Room1.roomStyle = "Suite";
                    break;
                case 4:
                    Room1.roomStyle = "Cabana";
                    break;
                case 5:
                    Room1.roomStyle = "Villa";
                    break;
            }

            switch (cmbBedStyle.SelectedIndex)
            {
                case 0:
                    Room1.bedStyle = "Twin Size(1)"; break;
                case 1:
                    Room1.bedStyle = "Twin Size(2)"; break;
                case 2:
                    Room1.bedStyle = "Queen Size"; break;
                case 3 :
                    Room1.bedStyle = "King Size"; break;
            }

            var repo = new RoomRepository();
            repo.UpdateRoom(Room1, Room2);

            MessageBox.Show("Room Successfully Updated");


        }
    }
}
