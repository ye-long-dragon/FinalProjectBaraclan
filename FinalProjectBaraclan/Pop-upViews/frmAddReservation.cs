using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace FinalProjectBaraclan.Pop_upViews
{
    public partial class frmAddReservation : Form
    {
       List<int> roomNumber = new List<int>();
        public frmAddReservation(DataTable dataTable, UserAccount userAccount)
        {
            InitializeComponent();

            table = dataTable;
            roomNumber = new List<int>();
            listBedStyle = new List<string>();
            listRoomStyle = new List<string>();
            temproomStyle = new List<string>();
            tempbedStyle = new List<string>();
            ImageData = new List<Image>();
            user = userAccount;

            //ChangeImageToBytes(table);
            SetupCMB();
            LoadListStyles();
            
        }



        public DataTable table;        
        public List<string> roomStyles = new List<string>
        {
            "Standard Room",
            "Deluxe Room",
            "Joint Room",
            "Suite",
            "Cabana",
            "Villa",
        };
        public List<string> bedStyles = new List<string>
        {
            "Twin Size (1)",
            "Twin Size (2)",
            "Queen Size",
            "King Size",
        };

        //Unchanged Data
        public UserAccount user;
        public List<string> listBedStyle;
        public List<string> listRoomStyle;
        public List<Image> ImageData = new List<Image>();
        public List<Byte[]> ImageBytes = new List<Byte[]>();

        //Changing Data
        public List<string> temproomStyle;
        public List<string> tempbedStyle;
        public List<string> finalBeds = new List<string>();
        public List<string> finalRooms = new List<string>();

        public void ChangeImageToBytes(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Image img = (Image)row["Image"];
                Byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Use the appropriate format
                    imageBytes = ms.ToArray();
                }

                ImageBytes.Add(imageBytes);

            }


        }

        public void LoadListStyles()
        {
            foreach (DataRow row in table.Rows)
            {
                roomNumber.Add(Convert.ToInt32(row["Room Number"]));
                listBedStyle.Add(Convert.ToString(row["Bed Style"]));
                listRoomStyle.Add(Convert.ToString(row["Room Style"]));
                
                var image = (Byte[])row["image"];
                
                ImageBytes.Add(image);
               
            }
        }

       

        public void CheckRoomStyles()
        {
            for (int i = 0; i < roomStyles.Count; i++)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToString(row["Room Style"]) == roomStyles[i])
                    {
                        temproomStyle.Add(Convert.ToString(row["Room Style"]));
                        break;
                    }
                }
            }

            
        }

        public void CheckBedStyles()
        {
            for (int i = 0; i < bedStyles.Count; i++)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToString(row["Bed Style"]) == bedStyles[i])
                    {
                        tempbedStyle.Add(Convert.ToString(row["Bed Style"]));
                        break;
                    }
                }
            }

            
        }

        public void SetupCMB()
        {
            roomNumber.Clear();
            temproomStyle.Clear();
            tempbedStyle.Clear();
            CheckBedStyles();
            CheckRoomStyles();
            cmbRoomStyle.Items.Clear();
            cmbBedStyle.Items.Clear();
            cmbRoomStyle.Items.AddRange(temproomStyle.ToArray());
            cmbBedStyle.Items.AddRange(tempbedStyle.ToArray());
        }
        

        public void ChangeBedStyleIndex(int index)
        {
            finalBeds.Clear();
            if (index >= 0 && index < temproomStyle.Count)
            {
                string selectedRoomStyle = temproomStyle[index];
                for (int i = 0; i < listRoomStyle.Count; i++)
                {
                    if (i < listBedStyle.Count && listRoomStyle[i] == selectedRoomStyle)
                    {
                        finalBeds.Add(listBedStyle[i]);
                    }
                   
                }
            }
            cmbBedStyle.Items.Clear();
            cmbBedStyle.Items.AddRange(finalBeds.ToArray());
        }

        public void ChangeRoomStyleIndex(int index)
        {
            finalRooms.Clear();
            for (int i = 0; i < listBedStyle.Count; i++)
            {
                if (tempbedStyle[index] == listBedStyle[i])
                {
                    finalRooms.Add(listRoomStyle[i]);
                }
                
            }
            cmbRoomStyle.Items.Clear();
            cmbRoomStyle.Items.AddRange(finalRooms.ToArray());
        }

        int Roomindex;
        int Bedindex;
        string roomStyle;
        string bedStyle;

        private void cmbRoomStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roomindex = cmbRoomStyle.SelectedIndex;
            string roomnumber = "";
            string roomstyle = "";
            string bedstyle = "";


            if (cmbBedStyle.SelectedIndex == -1)
            {
                ChangeBedStyleIndex(Roomindex);
                
            }
            else
            {
                 roomstyle = cmbRoomStyle.SelectedItem?.ToString();
                 bedstyle = cmbBedStyle.SelectedItem?.ToString();
                MessageBox.Show(roomstyle + " " + bedstyle);
                
                for (int i = 0; i < roomNumber.Count; i++)
                {
                    if(roomstyle == listRoomStyle[i]&&  bedstyle == listBedStyle[i])
                    {
                        lblId.Text = Convert.ToString(roomNumber[i]);

                        //display image
                        using (MemoryStream ms = new MemoryStream(ImageBytes[i]))
                        {
                            Image image = Image.FromStream(ms);
                            imgImage.Image = image;
                        }
                        break;

                    }
                }
                
            }

           
        }

        private void cmbBedStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bedindex = cmbBedStyle.SelectedIndex;
            string roomnumber = "";
            string roomstyle = "";
            string bedstyle = "";

            if (cmbRoomStyle.SelectedIndex == -1)
              {
                    ChangeRoomStyleIndex(Bedindex);
                    
              }
              else
              {
                     roomstyle = cmbRoomStyle.SelectedItem?.ToString();
                     bedstyle = cmbBedStyle.SelectedItem?.ToString();
                    
                   

                for (int i = 0; i < roomNumber.Count; i++)
                {
                    if (roomstyle == listRoomStyle[i] && bedstyle == listBedStyle[i])
                    {

                        
                            lblId.Text = Convert.ToString(roomNumber[i]);

                        //display image form List<Image> ImageData
                        using (MemoryStream ms = new MemoryStream(ImageBytes[i]))
                        {
                            Image image = Image.FromStream(ms);
                            imgImage.Image = image;
                        }
                        break;
                    }
                }
               

            }
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = 0;
            RoomHistory roomHistory = new RoomHistory();
            roomHistory.occupant = user.username;
            roomHistory.occupantNumber = user.finalId;
            roomHistory.date = Convert.ToDateTime(txtDate.Text);

            if (cmbBedStyle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bed style.");
                return;
            }

            if (cmbRoomStyle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room style.");
                return;
            }


            id = Convert.ToInt32(lblId.Text);

            for(int i = 0;i<roomNumber.Count;i++)
            {
                if (roomNumber[i] == id)
                {
                    roomHistory.roomNumber = id;
                    roomHistory.roomStyle = roomStyles[i];
                    roomHistory.bedStyle = bedStyles[i];
                    roomHistory.image = ImageBytes[i];
                    break;
                }

            }



            MessageBox.Show(roomHistory.occupant + "\n" +
                            roomHistory.occupantNumber + "\n" +
                            roomHistory.roomNumber + "\n" +
                            roomHistory.bedStyle + "\n" +
                            roomHistory.roomStyle + "\n" +
                            roomHistory.image + "\n" +
                            roomHistory.date + "\n");

            var repo = new RoomHistoryRepository();
            repo.ReserveRoom(roomHistory);
            MessageBox.Show("Room Reserved!");
        }
    }
}