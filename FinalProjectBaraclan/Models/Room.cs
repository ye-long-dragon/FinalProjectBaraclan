using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class Room
    {
        public int id { get; set; }
        public string roomStyle { get; set; }
        public string bedStyle { get; set; }
        public double price { get; set; }
        public Byte[] imgRoom { get; set; }

        public Image ReturnImage()
        {
            using (MemoryStream ms = new MemoryStream(this.imgRoom))
            {
                Image img = Image.FromStream(ms);
                return img;
            }


        }



       
    }
}
