using FinalProjectBaraclan.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Repository
{
    public class ReceiptRepository
    {
        public readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=FinalProjectDatabase;Persist Security Info=True;User ID=sa;Password=vinice2004;Encrypt=True;Trust Server Certificate=True";

        public void CreateReceiptIndexZero(Receipt receipt)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                
                
                    
                        string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboReceipts] (finalReceiptId," +
                            "userAccountName, userAccountId, itemName, itemQuantity, itemPrice, itemTotal) VALUES " +
                            "(@finalReceiptId,@userAccountName, @userAccountId, @itemName, @itemQuantity, @itemPrice, @itemTotal)";

                        using (SqlCommand create = new SqlCommand(query, conn))
                        {
                            create.Parameters.AddWithValue("@finalReceiptId", receipt.finalReceiptId);
                            create.Parameters.AddWithValue("@userAccountName", receipt.itemName);
                            create.Parameters.AddWithValue("@userAccountId", receipt.userAccountId);
                            create.Parameters.AddWithValue("@itemName", receipt.itemName);
                            create.Parameters.AddWithValue("@itemQuantity", receipt.itemQuantity);
                            create.Parameters.AddWithValue("@itemPrice", receipt.itemPrice);
                            create.Parameters.AddWithValue("@itemTotal", receipt.itemTotalPrice);

                            create.ExecuteNonQuery();

                        }

                     
                    
                
            }
        }




        public int ReadIndexZeroId(Receipt receipt)
        {
            // Validate the receipt object
            if (receipt == null)
            {
                throw new ArgumentNullException(nameof(receipt), "Receipt cannot be null.");
            }            
           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboReceipts] WHERE userAccountName = @userAccountName AND finalReceiptId = @finalReceiptId";

                using (SqlCommand read = new SqlCommand(query, conn))
                {
                    read.Parameters.AddWithValue("@userAccountName", receipt.userAccountName);
                    read.Parameters.AddWithValue("@finalReceiptId", receipt.finalReceiptId);

                    using (SqlDataReader reader = read.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming the first column is the initialReceiptId
                           receipt.initialReceiptId = reader.GetInt32(0); // Return the initialReceiptId directly
                        }
                    }
                }
            }
            return receipt.initialReceiptId; // Or some other default value indicating not found
        }


        public void ReturnFinalIdIndexZero(Receipt receipt)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE [FinalProjectDatabase].[dbo].[dboReceipts] SET finalReceiptId  = @finalReceiptId " +
                    "WHERE initialReceiptId = @initialReceiptId";

                using (SqlCommand update = new SqlCommand(query, conn))
                {
                    update.Parameters.AddWithValue("@finalReceiptId", receipt.finalReceiptId);
                    update.Parameters.AddWithValue("@initialReceiptId", receipt.initialReceiptId);

                    update.ExecuteNonQuery();
                }

            }
        }



        public void CreateReceiptNonZeroIndex(Receipt receipt)
        {
           
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                string add = "INSERT INTO [FinalProjectDatabase].[dbo].[dboReceipts] " +
                "(initialReceiptId,finalReceiptId, userAccountName, userAccountId, itemName, itemQuantity, itemPrice, itemTotal) " +
                "VALUES (@initialReceiptId,@finalReceiptId, @userAccountName, @userAccountId, @itemName, @itemQuantity, @itemPrice, @itemTotal)";

                string turnOn = "SET IDENTITY_INSERT [FinalProjectDatabase].[dbo].[dboReceipts] ON";
                string turnOff = "SET IDENTITY_INSERT [FinalProjectDatabase].[dbo].[dboReceipts] OFF";

                
                    using(SqlCommand on = new SqlCommand(turnOn, conn))
                    {
                        on.ExecuteNonQuery();
                    }

                    using (SqlCommand create = new SqlCommand(add, conn))
                    {
                        create.Parameters.AddWithValue("@initialReceiptId", receipt.initialReceiptId);
                        create.Parameters.AddWithValue("@finalReceiptId",receipt.finalReceiptId);
                        create.Parameters.AddWithValue("@userAccountName", receipt.userAccountName);
                        create.Parameters.AddWithValue("@userAccountId", receipt.userAccountId);
                        create.Parameters.AddWithValue("@itemName", receipt.itemName);
                        create.Parameters.AddWithValue("@itemQuantity", receipt.itemQuantity);
                        create.Parameters.AddWithValue("@itemPrice", receipt.itemPrice);
                        create.Parameters.AddWithValue("@itemTotal", receipt.itemTotalPrice);
                        MessageBox.Show(receipt.userAccountId + " " + receipt.userAccountName);

                        create.ExecuteNonQuery();
                    }
                    using (SqlCommand off = new SqlCommand(turnOff, conn))
                    {
                        off.ExecuteNonQuery();
                    }
                    
                
            }
        

        }

    }
}
