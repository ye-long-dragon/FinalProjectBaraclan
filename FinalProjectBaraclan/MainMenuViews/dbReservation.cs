using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Pop_upViews;
using FinalProjectBaraclan.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBaraclan
{
    public partial class dbReservation : Form
    {

        public DataTable tableRooms = new DataTable();
        public UserAccount userAccount;
        public dbReservation(UserAccount user)
        {
            InitializeComponent();

            userAccount = user;

            ReadRooms();

            ReadRoomsHistory();
        }


        public void ReadRooms()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Room Style", typeof(string));
            dataTable.Columns.Add("Bed Style", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));

            var repo = new RoomRepository();
            var rooms = repo.ReadRooms();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Image"] = room.ReturnImage();
                row["Room Number"] = room.id;
                row["Room Style"] = room.roomStyle;
                row["Bed Style"] = room.bedStyle;
                row["Price"] = room.price;


                dataTable.Rows.Add(row);
            }

            dgvRoomView.DataSource = dataTable;
            tableRooms = dataTable;

        }

        public void ReadRoomsHistory()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Room Style", typeof(string));
            dataTable.Columns.Add("Bed Style", typeof(string));
            dataTable.Columns.Add("Occupant", typeof(string));
            dataTable.Columns.Add("Occupant Number", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Price", typeof(double));

            var repo = new RoomHistoryRepository();
            var rooms = repo.ReadRoomsHistory();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Image"] = room.ReturnImage();
                row["Room Number"] = room.roomNumber;
                row["Room Style"] = room.roomStyle;
                row["Bed Style"] = room.bedStyle;
                row["Date"] = room.date;
                row["Occupant"] = room.occupant;
                row["Occupant Number"] = room.occupantNumber;
                row["Price"] = room.price;


                dataTable.Rows.Add(row);
            }

            this.dgvRoomHistoryView.DataSource = dataTable;

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {



            frmAddRooms frmAddRooms = new frmAddRooms();
            frmAddRooms.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

            //find rooms datasource
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Byte[]));
            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Room Style", typeof(string));
            dataTable.Columns.Add("Bed Style", typeof(string));
            dataTable.Columns.Add("Price", typeof(double));

            var repo = new RoomRepository();
            var rooms = repo.ReadRooms();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Image"] = room.imgRoom;
                row["Room Number"] = room.id;
                row["Room Style"] = room.roomStyle;
                row["Bed Style"] = room.bedStyle;
                row["Price"] = room.price;


                dataTable.Rows.Add(row);
            }

            tableRooms = dataTable;

            frmAddReservation frmAddReservation = new frmAddReservation(tableRooms, userAccount);
            frmAddReservation.ShowDialog();



        }

        private void dgvRoomView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                char authority = userAccount.AuthorityPass(userAccount);

                if (dgvRoomView.CurrentCell.OwningColumn.Name == "imgAdd")
                {
                    if (authority == 'A')
                    {
                        DataGridViewRow dataGridViewRow = dgvRoomView.Rows[e.RowIndex];
                        DataRow dataRow = ((DataRowView)dataGridViewRow.DataBoundItem).Row;

                        Room room = new Room
                        {
                            id = Convert.ToInt32(dataRow["Room Number"]),
                            roomStyle = Convert.ToString(dataRow["Room Style"]),
                            bedStyle = Convert.ToString(dataRow["Bed Style"]),
                            price = Convert.ToDouble(dataRow["Price"])
                        };

                        if (dataRow[0] is Image sourceImage)
                        {
                            using (var ms = new MemoryStream())
                            using (var bitmap = new Bitmap(sourceImage))
                            {
                                bitmap.Save(ms, ImageFormat.Jpeg);
                                room.imgRoom = ms.ToArray();
                            }
                        }

                        using (frmUpdateRoom frmUpdateRoom = new frmUpdateRoom(room))
                        {
                            frmUpdateRoom.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have the authority to add rooms.");
                    }
                }
                else if (dgvRoomView.CurrentCell.OwningColumn.Name == "imgDelete")
                {
                    if (authority == 'A')
                    {
                        int rowIndex = dgvRoomView.CurrentRow.Index;
                        string id = Convert.ToString(dgvRoomView.Rows[rowIndex].Cells["Room Number"].Value);

                        DialogResult result = MessageBox.Show("Are you sure you would like to delete this room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            var repo = new RoomRepository();
                            repo.DeleteRoom(Convert.ToInt32(id));
                            MessageBox.Show("Room deleted successfully.");

                            // Refresh the DataGridView
                            // Assuming you have a method to load the rooms data
                            ReadRooms();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have the authority to delete rooms.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRoomHistoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvRoomView.CurrentCell.OwningColumn.Name == "imgAdd")
            {
                MessageBox.Show("hi");

                DataGridViewRow dataGridViewRow = dgvRoomView.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)dataGridViewRow.DataBoundItem).Row;

            }
            else if (dgvRoomView.CurrentCell.OwningColumn.Name == "imgDelete"  )
            {
                int rowIndex = dgvRoomView.CurrentRow.Index;
                string id = Convert.ToString(dgvRoomView.Rows[rowIndex].Cells["Room Number"].Value);  // Replace "ID" with your actual ID column name
                DialogResult result = MessageBox.Show("Are you sure you would like to delete the Item?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show(id);
            }

        }



           
    }
}
