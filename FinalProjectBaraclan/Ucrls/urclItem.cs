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

namespace FinalProjectBaraclan.Ucrls
{
    public partial class urclItem : UserControl
    {
        int itemsNumber;
        public bool colorSelected = false;

        Product product = new Product();

        public urclItem(Product item)
        {
            InitializeComponent();

            lblItemName.Text = item.itemName;
            lblQuantity.Text ="Quantity: "+ Convert.ToString(item.itemQuantity);
            lblPrice.Text = "Price: "+Convert.ToString(item.itemPrice);
            imgImage.Image = item.ReturnImage();
            imgImage.SizeMode = PictureBoxSizeMode.Zoom;


            product = item;

        }
        public event EventHandler addClicked;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemsNumber++;
            if (itemsNumber > 0)
            {
                colorSelected = true;
                pnlUserControl.FillColor = Color.Violet;
                pnlUserControl.FillColor2 = Color.Violet;
                pnlUserControl.FillColor3 = Color.Violet;
                pnlUserControl.FillColor4 = Color.Violet;
            }
           
                
            
            product.quantitySubracted = itemsNumber;

            product.isAdded++;
            addClicked?.Invoke(this, EventArgs.Empty);


        }
        public event EventHandler droppedClicked;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            itemsNumber = 0;
            if (itemsNumber <= 0)
            {
                colorSelected = false;
                pnlUserControl.FillColor = Color.White;
                pnlUserControl.FillColor2 = Color.White;
                pnlUserControl.FillColor3 = Color.White;
                pnlUserControl.FillColor4 = Color.White;
            }
            product.quantitySubracted = itemsNumber;
            product.isDropped++;
            droppedClicked?.Invoke(this, EventArgs.Empty);
        }

        public Product ReturnItem()
        {
            return this.product;
        }
    }
}
