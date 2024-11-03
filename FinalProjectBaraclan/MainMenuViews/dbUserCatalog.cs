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

namespace FinalProjectBaraclan.MainMenuViews
{
    public partial class dbUserCatalog : Form
    {
        UserAccount useraccount = new UserAccount();

        public dbUserCatalog(UserAccount user)
        {
            InitializeComponent();

            useraccount = user;
            

            Readusers();
        }

        public void Readusers()
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Image", typeof(Image));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("BirthDate", typeof(DateTime));
            dataTable.Columns.Add("Contact Number", typeof(int));

            var repo = new AccountRepository();
            var accounts = repo.ReadAccounts();

            foreach (var account in accounts)
            {

                DataRow row = dataTable.NewRow();
                // row["Image"] = item.ReturnImage();
                row["Category"] = Convert.ToString(account.AuthorityPass(account));
                row["ID"] = account.finalId;
                row["Name"] = account.username;
                row["Password"] = account.password;
                row["Email"] = account.email;
                row["Address"] = account.address;
                row["BirthDate"] = account.birthDate;
                row["Contact Number"] = account.contactNumber;


                dataTable.Rows.Add(row);
            }


            this.dgvUsersView.DataSource = dataTable;


            dgvUsersView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvUsersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update
            if ((dgvUsersView.CurrentCell.OwningColumn.Name == "imgAdd") && ('A'==useraccount.finalId[0]))
            {
                DataGridViewRow dataGridViewRow = dgvUsersView.Rows[e.RowIndex];

                DataRow dataRow = ((DataRowView)dataGridViewRow.DataBoundItem).Row;
                UserAccount user = new UserAccount();
                user.finalId =Convert.ToString( dataRow[2]);
                user.username = Convert.ToString(dataRow[3]);
                user.password = Convert.ToString(dataRow[4]);
                user.email = Convert.ToString(dataRow[5]);
                user.address = Convert.ToString(dataRow[6]);
                user.birthDate = Convert.ToDateTime(dataRow[7]);
                user.contactNumber = Convert.ToInt32(dataRow[8]);

                frmUpdateUser frmUpdateUser = new frmUpdateUser(user);
                frmUpdateUser.ShowDialog();

            }
            else
            {
                MessageBox.Show("You do not have the authority");
            }
            //delete
            if (dgvUsersView.CurrentCell.OwningColumn.Name == "imgDelete"&& ('A' == useraccount.finalId[0]))
            {
                int id = Convert.ToInt32(dgvUsersView.CurrentRow.Cells["imgDelete"].Value);

            }
            else
            {
                MessageBox.Show("You do not have the authority");
            }
        }
    }
}
