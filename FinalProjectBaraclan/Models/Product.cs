using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class Product
    {
        public int initialIdItem, itemQuantity, isAdded,isDropped, quantitySubracted;
        public double itemCost, itemPrice;
        public string finalIdItem, itemName;
        public Byte[] itemImageArray;
        public bool isGrocery, isRestaurant, isMerchandise;

        public void CheckStatus()
        {
            if(isAdded>0)
            {
               this. isDropped = 0;
            }
            else if (isDropped>0)
            {
                this.isAdded = 0;
                this.quantitySubracted = -this.quantitySubracted;
            }

        }

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
        public string ReturnCategory()
        {
            string categoryType = "";
            char[] categoryArray = new char[9];
            categoryArray = this.finalIdItem.ToCharArray();

            if (categoryArray[0]=='G')
            {
                categoryType = "Grocery";
            }
            else if(categoryArray[0]=='M')
            {
                categoryType = "Merchandise";
            }
            else if(categoryArray[0]=='R')
            {
                categoryType = "Restaurant";
            }
            
            return categoryType;
            
        }

        public string ReturnStringIndexArray(int arraySize)
        {
           
            string itemName = this.itemName; 
            int index = itemName.Length;

            
            int effectiveSize = Math.Min(arraySize, index);
            char[] searchArray = new char[effectiveSize];

           
            for (int i = 0; i < effectiveSize; i++)
            {
                searchArray[i] = itemName[i];
            }

            
            string search = new string(searchArray);

            return search;
        }




    }
}
