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

namespace FinalProjectBaraclan.Ucrls
{
    public partial class ucrlDay : UserControl
    {
        DataTable tableRooms = new DataTable();
        UserAccount user = new UserAccount();
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public ucrlDay(UserAccount userAccount)
        {
            InitializeComponent();
            user = userAccount;
            
            SetUpDataTable();
            lblReservation.Visible = false;
        }

        public void SetUpDataTable()
        {
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
        }

        public void date(int day,int month, int year)
        {
            lblNumber.Text = day.ToString() + "";
            Day = day;
            Month = month;
            Year = year;
        }


        public event EventHandler reserved;
        private void btnReserve_Click(object sender, EventArgs e)
        {
            reserved?.Invoke(this, EventArgs.Empty);
            frmAddReserveCalendar frmAddReserveCalendar = new frmAddReserveCalendar(tableRooms,user,Day,Month,Year);
            frmAddReserveCalendar.ShowDialog();
        }

        public event EventHandler cancelled;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelled?.Invoke(this, EventArgs.Empty);
        }
    }
}
