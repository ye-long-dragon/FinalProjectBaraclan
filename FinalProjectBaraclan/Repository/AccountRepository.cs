using FinalProjectBaraclan.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinalProjectBaraclan.Repository
{
    public class AccountRepository
    {

        private readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=FinalProjectDatabase;User ID=sa;Password=vinice2004;Trust Server Certificate=True";

        public void DeleteAccount(string accountId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from [FinalProjectDatabase].[dbo].[dboUserAccounts] where finalId = @finalId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@finalId", accountId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<UserAccount> ReadAccounts()
        {

            var Account = new List<UserAccount>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboUserAccounts]";

                    using (SqlCommand select = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = select.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                UserAccount user = new UserAccount();
                                user.initailId = reader.GetInt32(0);
                                user.finalId = reader.GetString(1);
                                user.username = reader.GetString(2);
                                user.password = reader.GetString(3);
                                user.rePassword = reader.GetString(4);
                                user.email = reader.GetString(5);
                                user.address = reader.GetString(6);
                                user.birthDate = reader.GetDateTime(7);
                                user.contactNumber = reader.GetInt32(8);
                                user.image = (Byte[])reader.GetValue(9);

                                user.CheckAuthority(user);


                                Account.Add(user);

                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return Account;
        }

        public int ReadAccountInitialId(UserAccount user)
        {
            int accountInitialId = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboUserAccounts] WHERE username = @username";

                    using (SqlCommand find = new SqlCommand(query, connection))
                    {
                        find.Parameters.AddWithValue("@username", user.username);

                        using (SqlDataReader reader = find.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                accountInitialId = reader.GetInt32(0);
                            }

                        }
                    }
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return accountInitialId;
        }


        public UserAccount ReadAccount(int initialId)
        {
            UserAccount account = new UserAccount();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboUserAccounts] WHERE initialId = @initialId";

                    using (SqlCommand find = new SqlCommand(query, connection))
                    {
                        find.Parameters.AddWithValue("@initialId", initialId);

                        using (SqlDataReader reader = find.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                account.initailId = reader.GetInt32(0);
                                account.finalId = reader.GetString(1);
                                account.username = reader.GetString(2);
                                account.password = reader.GetString(3);
                                account.rePassword = reader.GetString(4);
                                account.email = reader.GetString(5);
                                account.address = reader.GetString(6);
                                account.birthDate = reader.GetDateTime(7);
                                account.contactNumber = reader.GetInt32(8);
                                account.image = (Byte[])reader.GetValue(9);
                            }
                        }
                    }


                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            return account;
        }



        public void createAccount(UserAccount User)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboUserAccounts]"
                                + "(finalId, username, password, rePassword, email, address," +
                                "birthDate, contactNumber, image) VALUES (@finalId, @username" +
                                ",@password,@rePassword,@email,@address,@birthDate,@contactNumber,@image)";

                            using (SqlCommand add = new SqlCommand(query, connection, transaction))
                            {
                                add.Parameters.AddWithValue("@finalId", User.finalId);
                                add.Parameters.AddWithValue("@username", User.username);
                                add.Parameters.AddWithValue("@password", User.password);
                                add.Parameters.AddWithValue("@rePassword", User.rePassword);
                                add.Parameters.AddWithValue("@email", User.email);
                                add.Parameters.AddWithValue("@address", User.address);
                                add.Parameters.AddWithValue("@birthDate", User.birthDate);
                                add.Parameters.AddWithValue("@contactNumber", User.contactNumber);
                                add.Parameters.AddWithValue("@image", User.image);

                                add.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            transaction.Rollback();
                            throw; // Rethrow the exception to propagate the error
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or display the error message
                MessageBox.Show("Error creating account: " + ex.Message);
            }
        }

        public void UpdateAccountId(UserAccount User)
        {
            //increment Initial Id

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand update = new SqlCommand())
                    {
                        update.Connection = connection;
                        update.CommandText = "UPDATE [FinalProjectDatabase].[dbo].[dboUserAccounts] SET finalId = @finalId WHERE username = @username";

                        update.Parameters.AddWithValue("@finalId", User.finalId);
                        update.Parameters.AddWithValue("@username", User.username); // Corrected typo here

                        update.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void UpdateAccount(UserAccount User)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [FinalProjectDatabase].[dbo].[dboUserAccounts] SET finalId = @finalId, username" +
                    " = @username, password = @password,rePassword = @rePassword, email = @email, contactNumber = @contactNumber" +
                    ",address = @address,birthDate = @birthDate WHERE initialId = @initialId,image = @image";


                using (SqlCommand update = new SqlCommand(query, connection))
                {
                    update.Parameters.AddWithValue("@finalId", User.finalId);
                    update.Parameters.AddWithValue("@username", User.username);
                    update.Parameters.AddWithValue("@password", User.password);
                    update.Parameters.AddWithValue("@email", User.email);
                    update.Parameters.AddWithValue("@contactNumber", User.contactNumber);
                    update.Parameters.AddWithValue("@rePassword", User.password);
                    update.Parameters.AddWithValue("@address", User.address);
                    update.Parameters.AddWithValue("@birthDate", User.birthDate);
                    update.Parameters.AddWithValue("@initialId", User.ReturnInitialId());
                    update.Parameters.AddWithValue("@image", User.image);
                    update.ExecuteNonQuery();
                }
            }
        }








    }
}



