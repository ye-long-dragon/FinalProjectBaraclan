using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBaraclan.Repository;
using FinalProjectBaraclan.Models;

namespace FinalProjectBaraclan
{
    public partial class MainMenu : Form
    {

        public MainMenu(char s)
        {
            InitializeComponent();

            

            // Check user role
            if (s == 'A' || s == 'E')
            {
                // Hide btnInventory
                btnInventory.Enabled = true;
                btnInventory.Visible = true;


                // Move other buttons
                btnAccount.Location = new Point(0, 275);
                btnSettings.Location = new Point(0, 330);
                btnLogout.Location = new Point(0, 385);
                
            }
            else
            {
                // Show btnInventory
                btnInventory.Enabled = false;
                btnInventory.Visible = false;

                // Move other buttons
                btnAccount.Location = new Point(0, 220);
                btnSettings.Location = new Point(0, 275);
                btnLogout.Location = new Point(0, 330);
            }

            // Optionally, refresh the panel
            pnlTaskbarContainer.Refresh();
        }

        //drag topbar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr one, int two, int three, int four);


       
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }


        //animation

        bool taskBarExpand = true;
        bool shopExpand = false;
        bool servicesExpand = false;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    /*
        private void tmrTaskbarMenu_Tick(object sender, EventArgs e)
        {
            

            if (taskBarExpand)
            {
                pnlTaskbarContainer.Width -= 5;
                pnlMain.Width += 5;
                if (pnlTaskbarContainer.Width <= 55 && pnlMain.Width >= 1044)
                {
                    taskBarExpand = false;
                    tmrTaskbarMenu.Stop();
                }

            }
            else
            {
                pnlTaskbarContainer.Width += 5;
                pnlMain.Width -= 5;
                if (pnlTaskbarContainer.Width >= 300 && pnlMain.Width <= 799)
                {
                    taskBarExpand = true;
                    tmrTaskbarMenu.Stop();
                }
            }
        }
        */

        private void tmrServices_Tick(object sender, EventArgs e)
        {


            if (false == servicesExpand)
            {
                pnlServices.Height += 5;

                //below services
                btnShoppingCart.Top += 5;
                btnAccount.Top += 5;
                btnSettings.Top += 5;
                btnLogout.Top += 5;
                btnInventory.Top += 5;

                if (pnlServices.Height >= 165)
                {
                    tmrServices.Stop();
                    servicesExpand = true;
                }
            }
            else
            {
                //below services
                btnShoppingCart.Top -= 5;
                btnAccount.Top -= 5;
                btnSettings.Top -= 5;
                btnLogout.Top -= 5;
                btnInventory.Top -= 5;

                pnlServices.Height -= 5;
                if (pnlServices.Height <= 55)
                {
                    tmrServices.Stop();
                    servicesExpand = false;
                }
            }
        }

        private void tmrShopDrop_Tick(object sender, EventArgs e)
        {
            


            if (false == shopExpand)
            {
                pnlShopContainer.Height += 5;

                //below shop
                pnlServices.Top += 5;
                btnShoppingCart.Top += 5;
                btnAccount.Top += 5;
                btnSettings.Top += 5;
                btnLogout.Top += 5;
                btnInventory.Top += 5;

                if (pnlShopContainer.Height >= 210)
                {
                    tmrShopDrop.Stop();
                    shopExpand = true;
                }
            }
            else
            {
                pnlShopContainer.Height -= 5;

                //below shop
                pnlServices.Top -= 5;
                btnShoppingCart.Top -= 5;
                btnAccount.Top -= 5;
                btnSettings.Top -= 5;
                btnLogout.Top -= 5;
                btnInventory.Top -= 5;

                if (pnlShopContainer.Height <= 55)
                {
                    tmrShopDrop.Stop();
                    shopExpand = false;
                }
            }
        }


        //button clicks
        /*
        private void btnTaskbarMenu_Click(object sender, EventArgs e)
        {
            tmrTaskbarMenu.Start();
        }*/



        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }



        private void btnShopDrop_Click(object sender, EventArgs e)
        {
            dbAllItems allItems = new dbAllItems();
            allItems.TopLevel = false;
            pnlMain.Controls.Add(allItems);
            allItems.Dock = DockStyle.Fill;
            allItems.BringToFront();
            allItems.Show();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            
        }





        private void btnServices_Click(object sender, EventArgs e)
        {
            tmrServices.Start();
        }



        //load panels
        private void btnAllItems_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMerchandise_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGrocery_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            dbReservation dbReservation = new dbReservation();
            dbReservation.TopLevel = false;
            pnlMain.Controls.Add(dbReservation);
            dbReservation.Dock = DockStyle.Fill;
            dbReservation.BringToFront();
            dbReservation.Show();
        }

        private void btnHousekeeping_Click(object sender, EventArgs e)
        {
            dbHousekeeping dbHousekeeping = new dbHousekeeping();
            dbHousekeeping.TopLevel = false;
            pnlMain.Controls.Add(dbHousekeeping);
            dbHousekeeping.Dock = DockStyle.Fill;
            dbHousekeeping.BringToFront();
            dbHousekeeping.Show();
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            dbShoppingCart dbShoppingCart = new dbShoppingCart();
            dbShoppingCart.TopLevel = false;
            pnlMain.Controls.Add(dbShoppingCart);
            dbShoppingCart.Dock = DockStyle.Fill;
            dbShoppingCart.BringToFront();
            dbShoppingCart.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            dbAccount dbAccount = new dbAccount();
            dbAccount.TopLevel = false;
            pnlMain.Controls.Add(dbAccount);
            dbAccount.Dock = DockStyle.Fill;
            dbAccount.BringToFront();
            dbAccount.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            dbSettings dbSettings = new dbSettings();
            dbSettings.TopLevel = false;
            pnlMain.Controls.Add(dbSettings);
            dbSettings.Dock = DockStyle.Fill;
            dbSettings.BringToFront();
            dbSettings.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            dbInventory dbInventory = new dbInventory();
            dbInventory.TopLevel = false;
            pnlMain.Controls.Add(dbInventory);
            dbInventory.Dock = DockStyle.Fill;
            dbInventory.BringToFront();
            dbInventory.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            
        }
    }
}
