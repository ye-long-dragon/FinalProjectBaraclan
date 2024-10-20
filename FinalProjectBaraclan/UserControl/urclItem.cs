using FinalProjectBaraclan.Models;
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
    public partial class urclItem : UserControl
    {
        int itemsNumber;
       public  bool colorSelected = false;

        Product product = new Product();

        public urclItem(Product item)
        {
            InitializeComponent();

            lblItemName.Text = item.itemName;
            lblQuantity.Text = Convert.ToString(item.itemQuantity);
            imgImage.Image = item.ReturnImage();
            imgImage.SizeMode = PictureBoxSizeMode.Zoom;
            

            product = item;
            
        }
        public event EventHandler addClicked;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemsNumber++;
            if (itemsNumber >0)
            {
                colorSelected = true;
            }
            product.quantitySubracted = itemsNumber;

            product.isAdded++;



        }
        public event EventHandler droppedClicked;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            itemsNumber = 0;
            if (itemsNumber <= 0)
            {
                colorSelected = false;
            }
            product.quantitySubracted = itemsNumber;
            product.isDropped++;

        }

        public Product ReturnItem()
        {
            return this.product;
        }
    }
}
