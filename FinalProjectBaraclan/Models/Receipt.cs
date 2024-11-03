using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class Receipt
    {
        public int initialReceiptId { get; set; }
        public int itemQuantity { get; set; }
        public string finalReceiptId { get; set; }
        public string userAccountName { get; set; }
        public string userAccountId { get; set; }
        public string itemName { get; set; }
        public double itemPrice { get; set; }
        public double itemTotalPrice { get; set; }
        public double payment { get; set; }


        public string CreateFinalId()
        {
            return userAccountId[0] + userAccountName[0]+userAccountName[1]+Convert.ToString(initialReceiptId);

        }


    }
}
