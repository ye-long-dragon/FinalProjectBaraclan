using FinalProjectBaraclan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Models
{
    public class UserAccount
    {
        public Byte[] image {  get; set; }
        public int initailId { get; set; }
        public int contactNumber {  get; set; }
        public string finalId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string rePassword { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime birthDate { get; set; }
        public bool isAdmin { get; set; }
        public bool isEmployee { get; set; }
        public bool isUser { get; set; }
        public char authority { get; set; }



        public Image ReturnImage()
        {
            using (MemoryStream ms = new MemoryStream(this.image))
            {
                Image img = Image.FromStream(ms);
                return img;
            }

        }

        public void CheckAuthority(UserAccount user)
        {

            char[] chars = user.finalId.ToCharArray();
            
            if (chars[0] == 'A')
            {
                this.isAdmin = true;
                this.isEmployee = false;
                this.isUser = false;               
            }
            else if (chars[0] == 'E')
            {
                this.isEmployee = true;
                this.isAdmin = false;
                this.isUser = false;
            }
            else if (chars[0] == 'U')
            {
                this.isUser = true;
                this.isAdmin = false;
                this.isEmployee = false;
            }
            
            user.authority = chars[0];
            user.initailId = Convert.ToInt32(user.finalId.Remove(0, 1));
            MessageBox.Show(Convert.ToString(this.authority));
        }

        public char AuthorityPass(UserAccount user)
        {
            if (this.isAdmin)
            {
                return 'A';
            }
            else if(this.isEmployee)
            {
                return 'E';
            }
            else if(this.isUser)
            {
                return 'U';
            }
            return ' ';
        }

        public string GenerateId(int initialId)
        {
            try
            {
                string baseId = initialId.ToString();
                int zeroDigits = 9 - baseId.Length;

                // Pad with leading zeros
                baseId = baseId.PadLeft(9, '0');

                // Add the prefix character
                if (this.isAdmin)
                {
                    return "A" + baseId;
                }
                else if (this.isEmployee)
                {
                    return "E" + baseId;
                }
                else if (this.isUser)
                {
                    return "U" + baseId;
                }

                // Default to empty string if none of the above conditions are true
                return "";
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return "";
        }


        public bool ValidateLogin(string finalId, string password)
        {
            if (finalId == this.finalId && password == this.password && this.rePassword == password)
            {                
                return true;                    
            }
            return false;
        }

        public int ReturnInitialId()
        {
            int result;
            string temp;
            temp = this.finalId.Substring(1);
            temp = temp.TrimStart('0');
            result = Convert.ToInt32(temp);
            return result;
        }

        public class Admin : UserAccount
        {





        }

        public class Employee : UserAccount
        {

        }

        public class User : UserAccount
        {

        }
    }
}

