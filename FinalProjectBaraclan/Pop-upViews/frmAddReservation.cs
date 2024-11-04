using FinalProjectBaraclan.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FinalProjectBaraclan.Pop_upViews
{
    public partial class frmAddReservation : Form
    {
        public frmAddReservation(DataTable dataTable, UserAccount userAccount)
        {
            InitializeComponent();
            table = dataTable;
            roomNumber = new List<int>();
            listBedStyle = new List<string>();
            listRoomStyle = new List<string>();
            temproomStyle = new List<string>();
            tempbedStyle = new List<string>();
            LoadListStyles();
            SetupCMB();
        }

        public DataTable table;
        public List<int> roomNumber;
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
        public List<string> temproomStyle;
        public List<string> tempbedStyle;
        public List<string> listBedStyle;
        public List<string> listRoomStyle;

        public void LoadListStyles()
        {
            foreach (DataRow row in table.Rows)
            {
                roomNumber.Add(Convert.ToInt32(row["Room Number"]));
                listBedStyle.Add(Convert.ToString(row["Bed Style"]));
                listRoomStyle.Add(Convert.ToString(row["Room Style"]));
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

        public List<string> finalBeds = new List<string>();
        public List<string> finalRooms = new List<string>();

        public void ChangeBedStyleIndex(int index)
        {
            finalBeds.Clear();
            if (index >= 0 && index < temproomStyle.Count)
            {
                string selectedRoomStyle = temproomStyle[index];
                for (int i = 0; i < listRoomStyle.Count; i++)
                {
                    // Ensure we don't access out of range
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

        private void cmbRoomStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roomindex = cmbRoomStyle.SelectedIndex;

            // Check if Roomindex is valid
            if (Roomindex != -1 && Roomindex < temproomStyle.Count)
            {
                if (cmbBedStyle.SelectedIndex == -1)
                {
                    ChangeBedStyleIndex(Roomindex);
                }
                else
                {
                    string roomstyle = cmbRoomStyle.SelectedItem?.ToString();
                    string bedstyle = cmbBedStyle.SelectedItem?.ToString();

                    // Ensure both selected items are valid
                    if (!string.IsNullOrEmpty(roomstyle) && !string.IsNullOrEmpty(bedstyle))
                    {
                        for (int i = 0; i < listRoomStyle.Count; i++)
                        {
                            // Ensure we don't access out of range
                            if (i < listBedStyle.Count && i < roomNumber.Count &&
                                listRoomStyle[i] == roomstyle && listBedStyle[i] == bedstyle)
                            {
                                lblRoomNumber.Text = roomNumber[i].ToString();
                                break; // Exit the loop once we find a match
                            }
                        }
                    }
                }
            }
            else
            {
                // Clear the room number label if no valid selection
                lblRoomNumber.Text = "";
            }
        }



        private void cmbBedStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bedindex = cmbBedStyle.SelectedIndex;

            if (Bedindex != -1)
            {
                if (cmbRoomStyle.SelectedIndex == -1)
                {
                    ChangeRoomStyleIndex(Bedindex);
                }
                else
                {
                    // Get selected styles safely
                    string roomstyle = cmbRoomStyle.SelectedItem?.ToString();
                    string bedstyle = cmbBedStyle.SelectedItem?.ToString();

                    // Ensure roomstyle and bedstyle are not null or empty
                    if (!string.IsNullOrEmpty(roomstyle) && !string.IsNullOrEmpty(bedstyle))
                    {
                        for (int i = 0; i < listBedStyle.Count; i++)
                        {
                            // Check if we are within the bounds of roomNumber and listRoomStyle
                            if (i < listRoomStyle.Count && i < roomNumber.Count)
                            {
                                if (listBedStyle[i] == bedstyle && listRoomStyle[i] == roomstyle)
                                {
                                    lblRoomNumber.Text = Convert.ToString(roomNumber[i]);
                                    break; // Exit the loop once we find a match
                                }
                            }
                        }
                    }
                }
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}