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

namespace FinalProjectBaraclan.MainMenuViews
{
    public partial class dbUserCatalog : Form
    {
        UserAccount useraccount = new UserAccount();
        public Byte[] image { get; set; }

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
                row["Image"] = account.ReturnImage();
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
            if ((dgvUsersView.CurrentCell.OwningColumn.Name == "imgAdd") && ('A' == useraccount.finalId[0]))
            {
                DataGridViewRow dataGridViewRow = dgvUsersView.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)dataGridViewRow.DataBoundItem).Row;

                UserAccount user = new UserAccount();
                user.finalId = Convert.ToString(dataRow[2]);
                user.username = Convert.ToString(dataRow[3]);
                user.password = Convert.ToString(dataRow[4]);
                user.email = Convert.ToString(dataRow[5]);
                user.address = Convert.ToString(dataRow[6]);
                user.birthDate = Convert.ToDateTime(dataRow[7]);
                user.contactNumber = Convert.ToInt32(dataRow[8]);

                // Handle image
                if (dataRow[0] is Image sourceImage)
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var bitmap = new Bitmap(sourceImage.Width, sourceImage.Height))
                        {
                            using (var graphics = Graphics.FromImage(bitmap))
                            {
                                graphics.DrawImage(sourceImage, 0, 0, sourceImage.Width, sourceImage.Height);
                            }
                            bitmap.Save(ms, ImageFormat.Jpeg);
                            user.image = ms.ToArray();
                        }
                    }
                }

                frmUpdateUser frmUpdateUser = new frmUpdateUser(user);
                frmUpdateUser.ShowDialog();
            }
            else if(dgvUsersView.CurrentCell.OwningColumn.Name == "imgAdd")
            {
                MessageBox.Show("You do not have the authority");
            }


            //delete
            else if (dgvUsersView.CurrentCell.OwningColumn.Name == "imgDelete" && 'A' == useraccount.finalId[0])
            {
                int rowIndex = dgvUsersView.CurrentRow.Index;
                string id = Convert.ToString(dgvUsersView.Rows[rowIndex].Cells["ID"].Value);  // Replace "ID" with your actual ID column name
                DialogResult result = MessageBox.Show("Are you sure you would like to delete the Account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show(id);

                if (result == DialogResult.Yes)
                {
                    var repo = new AccountRepository();
                    repo.DeleteAccount(id);
                    MessageBox.Show("Account deleted successfully.");
                }
                else
                {
                    return;
                }
                
            }
            else if(dgvUsersView.CurrentCell.OwningColumn.Name == "imgDelete")
            {
                MessageBox.Show("You do not have the authority");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }
    }
}
