using FinalProjectBaraclan.MainMenuViews;
using FinalProjectBaraclan.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Repository
{
    public class ItemRepository
    {
        private readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=FinalProjectDatabase;Persist Security Info=True;User ID=sa;Password=vinice2004;Encrypt=True;Trust Server Certificate=True";

        public void DeleteAccount(string accountId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from [FinalProjectDatabase].[dbo].[dboProducts] where finalIdItem = @finalIdItem";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@finalId", accountId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Product> ReadItems()
        {
            List<Product> items = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboProducts]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                product.initialIdItem = reader.GetInt32(0);
                                product.finalIdItem = reader.GetString(1);
                                product.itemName = reader.GetString(2);
                                product.itemQuantity = reader.GetInt32(3);
                                product.itemCost = reader.GetDouble(4);
                                product.itemPrice = reader.GetDouble(5);

                                long imageSize = reader.GetBytes(6, 0, null, 0, 0);
                                byte[] imageData = new byte[imageSize];
                                reader.GetBytes(6, 0, imageData, 0, (int)imageSize);
                                product.itemImageArray = imageData;

                                items.Add(product);
                            }

                        }
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return items;
        }

        public void createProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Open the connection first
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboProducts] "
                                     + "(finalIdItem, itemName, itemQuantity, itemCost, itemPrice, itemImage) "
                                     + "VALUES (@finalIdItem, @itemName, @itemQuantity, @itemCost, @itemPrice, @itemImage)";

                        using (SqlCommand create = new SqlCommand(query, connection, transaction))
                        {
                            create.Parameters.AddWithValue("@finalIdItem", product.finalIdItem);
                            create.Parameters.AddWithValue("@itemName", product.itemName);
                            create.Parameters.AddWithValue("@itemQuantity", product.itemQuantity);
                            create.Parameters.AddWithValue("@itemCost", product.itemCost);
                            create.Parameters.AddWithValue("@itemPrice", product.itemPrice); // Corrected parameter
                            create.Parameters.AddWithValue("@itemImage", product.itemImageArray);

                            create.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void UpdateItem(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE [FinalProjectDatabase].[dbo].[dboProducts] 
                         SET itemName = @itemName, 
                             itemImage = CAST(@itemImage AS image), 
                             itemQuantity = @itemQuantity, 
                             itemCost = @itemCost, 
                             itemPrice = @itemPrice 
                         WHERE finalIdItem = @finalIdItem";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@finalIdItem", SqlDbType.NVarChar).Value = product.finalIdItem;
                    cmd.Parameters.Add("@itemName", SqlDbType.NVarChar).Value = product.itemName;
                    cmd.Parameters.Add("@itemImage", SqlDbType.Image).Value = product.itemImageArray;
                    cmd.Parameters.Add("@itemQuantity", SqlDbType.Int).Value = product.itemQuantity;
                    cmd.Parameters.Add("@itemCost", SqlDbType.Decimal).Value = product.itemCost;
                    cmd.Parameters.Add("@itemPrice", SqlDbType.Decimal).Value = product.itemPrice;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No rows were updated. The item may not exist.");
                    }
                }
            }
        }

        public void UpdateProductId(Product product)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE [FinalProjectDatabase].[dbo].[dboProducts] SET finalIdItem = @finalIdItem WHERE itemName = @itemName";

                    using(SqlCommand update = new SqlCommand(query, connection))
                    {
                        update.Parameters.AddWithValue("@finalIdItem", product.finalIdItem);
                        update.Parameters.AddWithValue("@itemName", product.itemName);

                        update.ExecuteNonQuery ();
                    }

                }


            }

            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public int ReadProductInitialId(Product product)
        {
            int productInitialId = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection( connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboProducts] WHERE itemName = @itemName";

                    using(SqlCommand read = new SqlCommand(query, connection))
                    {
                        read.Parameters.AddWithValue("@itemName", product.itemName);

                        using(SqlDataReader reader = read.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productInitialId = reader.GetInt32(0);
                            }
                        }
                    }

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            return productInitialId;


        }


        public List<Product> GetItemDataView()
        {
            string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboProducts]";
            List<Product> products = new List<Product>();


            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                using(SqlCommand read = new SqlCommand(query,connection))
                {
                    using(SqlDataReader dataReader = read.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Product item = new Product();
                            item.itemName = dataReader.GetString(2);
                            item.itemQuantity = dataReader.GetInt32(3);
                            item.itemPrice = dataReader.GetDouble(4);

                            long imageSize = dataReader.GetBytes(6, 0, null, 0, 0);
                            byte[] imageData = new byte[imageSize];
                            dataReader.GetBytes(6, 0, imageData, 0, (int)imageSize);
                            item.itemImageArray = imageData;

                            products.Add(item);
                            


                        }
                    }

                }

                return products;

            }

        }

        public void ShopUpdateItemQuantity (Product product)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "UPDATE [FinalProjectDatabase].[dbo].[dboProducts] SET itemQuantity = @itemQuantity WHERE itemName = @itemName";

                using(SqlCommand update = new SqlCommand(query,sqlConnection))
                {
                    update.Parameters.AddWithValue("@itemQuantity", product.quantitySubracted);
                    update.Parameters.AddWithValue("@itemName", product.itemName);

                    update.ExecuteNonQuery();


                }              
            }    
        }











       

     }
            
            
            
}



