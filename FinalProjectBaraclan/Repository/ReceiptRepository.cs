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

        public void StoreShopReceipt(Receipt receipt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboReceiptHistory] (username,userId,transactionType,receipt, date)" +
                    "VALUES (@username,@userId,@transactionType,@receipt,@date)";

                using (SqlCommand command = new SqlCommand(query,conn))
                {
                    command.Parameters.AddWithValue("@username",receipt.userAccountName);
                    command.Parameters.AddWithValue("@userId",receipt.userAccountId);
                    command.Parameters.AddWithValue("@transactionType","SHOP");
                    command.Parameters.AddWithValue("@receipt",receipt.data);
                    command.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Now.Month + " " + DateTime.Now.Day + " " + DateTime.Now.Year));

                    command.ExecuteNonQuery();

                }
            }
        }

        public List<Receipt> RetrieveReceipts(UserAccount user)
        {
            List<Receipt> receipts = new List<Receipt>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM [FinalProjectDatabase].[dbo].[dboReceiptHistory] 
                         WHERE username = @username AND userId = @userId";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@userId", user.finalId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Receipt receipt = new Receipt();

                            receipt.userAccountName = reader.GetString(0);
                            receipt.userAccountId = reader.GetString(1);
                            receipt.type = reader.GetString(2);
                            receipt.date = reader.GetDateTime(4);
                            receipt.data = (byte[])reader.GetValue(3);
                            

                            receipts.Add(receipt);
                        }
                    }
                }
            }

            return receipts;
        }


    }
}
