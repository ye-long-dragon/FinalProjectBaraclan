using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Pop_upViews;
using FinalProjectBaraclan.Repository;
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

            var repo = new RoomRepository();
            var rooms = repo.ReadRooms();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Image"] = room.ReturnImage();
                row["Room Number"] = room.id;
                row["Room Style"] = room.roomStyle;
                row["Bed Style"] = room.bedStyle;


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

            var repo = new RoomHistoryRepository();
            var rooms = repo.ReadRoomsHistory();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Image"] = room.ReturnImage();
                row["Room Number"] = room.roomNumber;
                row["Room Style"] = room.roomStyle;
                row["Date"] = room.date;
                row["Occupant"] = room.occupant;
                row["Occupant Number"] = room.occupantNumber;


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
            
            
            frmAddReservation frmAddReservation = new frmAddReservation(tableRooms,userAccount);
            frmAddReservation.ShowDialog();



        }
    }
}
