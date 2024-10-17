using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class Product
    {
        public int initialIdItem, itemQuantity;
        public double itemCost, itemPrice;
        public string finalIdItem, itemName;
        public Byte[] itemImageArray;
        public bool isGrocery, isRestaurant, isMerchandise;


        public string GenerateId(int id)
        {
            string baseId = id.ToString();
            int zeroDigits = 9-baseId.Length;

            baseId = baseId.PadLeft(9, '0');

            if (this.isGrocery)
            {
                return "G" + baseId;
            }
            else if (this.isRestaurant)
            {
                return "R" + baseId;
            }
            else if (this.isMerchandise)
            {
                return "U" + baseId;
            }
            return "";
        }

        public Image ReturnImage()
        {
            using (MemoryStream ms = new MemoryStream(this.itemImageArray))
            {
                Image img = Image.FromStream(ms);
                return img;
            }           

        }



    }
}
