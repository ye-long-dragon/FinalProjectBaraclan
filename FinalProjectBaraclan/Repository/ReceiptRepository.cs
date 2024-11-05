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

                string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboReceipts] (username,userId,transactionType,receipt)" +
                    "VALUES (@username,@userId,@transactionType,@receipt)";

                using (SqlCommand command = new SqlCommand(query,conn))
                {
                    command.Parameters.AddWithValue("@username",receipt.userAccountName);
                    command.Parameters.AddWithValue("@userId",receipt.userAccountId);
                    command.Parameters.AddWithValue("@transactionType","SHOP");
                    command.Parameters.AddWithValue("@receipt",receipt.data);

                    command.ExecuteNonQuery();

                }
            }
        }



    }
}
