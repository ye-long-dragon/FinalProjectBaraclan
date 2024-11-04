using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class RoomHistory
    {
        public int roomNumber {  get; set; }
        public DateTime date { get; set; }
        public string occupant {  get; set; }
        public string occupantNumber {  get; set; }
        public string roomStyle { get; set; }
        public Byte [] image { get; set; }

        public Image ReturnImage()
        {
            using (MemoryStream ms = new MemoryStream(this.image))
            {
                Image img = Image.FromStream(ms);
                return img;
            }


        }


    }
}
