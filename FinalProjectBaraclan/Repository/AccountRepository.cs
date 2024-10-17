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

                                user.CheckAuthority(user);

                                Account.Add(user);

                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message) ; }

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
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open ();
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
                            }
                        }
                    }


                }    


            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }


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
                                "birthDate, contactNumber) VALUES (@finalId, @username" +
                                ",@password,@rePassword,@email,@address,@birthDate,@contactNumber)";

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

                                add.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message) ;
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
    }
}

/*
 INCREMENT INITIAL ID

using System; // Namespace for fundamental types and functions
using System.Data.SqlClient; // Namespace for SQL Server data access

// Class that manages database operations
public class DatabaseManager
{
    private readonly string _connectionString; // Field to hold the database connection string

    // Constructor that accepts a connection string
    public DatabaseManager(string connectionString)
    {
        _connectionString = connectionString; // Assign the connection string to the field
    }

    // Method to insert values into the database
    public void InsertValues(int?[] values)
    {
        // Open a new SQL connection using the provided connection string
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            conn.Open(); // Open the connection
            int lastNumber = 0; // Variable to track the last inserted number

            // Fetch the maximum SomeValue from the database to determine the last used number
            using (SqlCommand cmd = new SqlCommand("SELECT MAX(SomeValue) FROM MyTable", conn))
            {
                object result = cmd.ExecuteScalar(); // Execute the command and get the result
                if (result != DBNull.Value) // Check if the result is not null
                {
                    lastNumber = Convert.ToInt32(result); // Convert the result to an integer
                }
            }

            // Loop through each value in the input array
            foreach (var value in values)
            {
                // Determine the number to insert: use the value if it's not null, otherwise increment lastNumber
                int numberToInsert = value ?? lastNumber + 1;

                // Ensure the number is unique before inserting
                while (true) // Infinite loop to find a unique number
                {
                    // Check if the number to insert already exists in the database
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM MyTable WHERE SomeValue = @value", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@value", numberToInsert); // Set the parameter for the SQL command
                        int count = (int)checkCmd.ExecuteScalar(); // Execute the command to count occurrences of the number

                        // If no duplicates found, exit the loop
                        if (count == 0)
                        {
                            break;  // No duplicate found, proceed to insert
                        }
                        numberToInsert++;  // If duplicate found, increment the number to check the next value
                    }
                }

                // Insert the new value into MyTable
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO MyTable (SomeValue) VALUES (@value)", conn))
                {
                    insertCmd.Parameters.AddWithValue("@value", numberToInsert); // Set the parameter for the SQL command
                    insertCmd.ExecuteNonQuery(); // Execute the insert command
                }

                lastNumber = numberToInsert;  // Update lastNumber to the newly inserted number
                Console.WriteLine($"Inserted value: {numberToInsert}"); // Output the inserted value to the console
            }
        }
    }
}

 
 */
