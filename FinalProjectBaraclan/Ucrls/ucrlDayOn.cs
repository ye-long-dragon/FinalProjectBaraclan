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
        DataTable tableRooms;
        UserAccount user;
        public ucrlDay(UserAccount userAccount)
        {
            InitializeComponent();

            lblReservation.Visible = false;
        }

        public void SetUpDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Image", typeof(Byte[]));
            dataTable.Columns.Add("Room Number", typeof(int));
            dataTable.Columns.Add("Room Style", typeof(string));
            dataTable.Columns.Add("Bed Style", typeof(string));

            var repo = new RoomRepository();
            var rooms = repo.ReadRooms();

            foreach (var room in rooms)
            {
                DataRow row = dataTable.NewRow();
                row["Image"] = room.imgRoom;
                row["Room Number"] = room.id;
                row["Room Style"] = room.roomStyle;
                row["Bed Style"] = room.bedStyle;


                dataTable.Rows.Add(row);
            }

            tableRooms = dataTable;
        }

        public void days(int num)
        {
            lblNumber.Text = num.ToString() + "";
        }


        public event EventHandler reserved;
        private void btnReserve_Click(object sender, EventArgs e)
        {
            reserved?.Invoke(this, EventArgs.Empty);
            frmAddReservation frmAddReservation = new frmAddReservation(tableRooms,user);
            frmAddReservation.ShowDialog();
        }

        public event EventHandler cancelled;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelled?.Invoke(this, EventArgs.Empty);
        }
    }
}
