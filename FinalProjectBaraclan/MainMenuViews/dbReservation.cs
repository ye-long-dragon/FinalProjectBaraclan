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
        public dbReservation()
        {
            InitializeComponent();

            ReadRooms();
        }


        public void ReadRooms()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Room Style",typeof(string));
            dataTable.Columns.Add("Occupant", typeof(string));
            dataTable.Columns.Add("Occupant Number", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));

            var repo = new RoomRepository();
            var rooms = repo.ReadRooms();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Room Number"] = room.roomNumber;
                row["Room Style"] = room.roomStyle;
                row["Date"] = room.date;
                row["Occupant"] = room.occupant;
                row["Occupant Number"] = room.occupantNumber;


                dataTable.Rows.Add(row);
            }

            this.dgvRoomView.DataSource = dataTable;

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
