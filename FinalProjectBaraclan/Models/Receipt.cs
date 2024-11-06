using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class Receipt
    {
        
        public string userAccountName { get; set; }
        public string userAccountId { get; set; }
        public DateTime date {  get; set; }
        public string type { get; set; }
        public byte[] data { get; set; }


        


    }
}
