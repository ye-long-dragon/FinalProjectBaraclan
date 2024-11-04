using FinalProjectBaraclan.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBaraclan.Repository
{
    public class RoomRepository
    {

        public readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=FinalProjectDatabase;Persist Security Info=True;User ID=sa;Password=vinice2004;Encrypt=True;Trust Server Certificate=True";


        public List<Room> ReadRooms() 
        {
            List<Room> list = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [FinalProjectdatabase].[dbo].[dboRooms]";

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = sqlCommand.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            Room room = new Room();
                            room.roomStyle = reader.GetString(0);
                            room.id = reader.GetInt32(1);
                            room.bedStyle = reader.GetString(2);

                            long imageSize = reader.GetBytes(reader.GetOrdinal("image"), 0, null, 0, 0);
                            byte[] imageData = new byte[imageSize];
                            reader.GetBytes(reader.GetOrdinal("image"), 0, imageData, 0, (int)imageSize);
                            room.imgRoom = imageData;

                            list.Add(room);

                        }
                    
                    }

                }

            }


            return list;

        }

        public void AddRoom(Room room)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboRooms] " +
                    "(roomNumber, bedStyle, roomStyle,image) VALUES (@roomNumber, @bedStyle, @roomStyle,@image)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@roomNumber",room.id);
                    cmd.Parameters.AddWithValue("@bedStyle",room.bedStyle);
                    cmd.Parameters.AddWithValue("@roomStyle",room.roomStyle);
                    cmd.Parameters.AddWithValue("@image", room.imgRoom);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
