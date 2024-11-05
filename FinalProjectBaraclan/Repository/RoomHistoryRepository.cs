using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectBaraclan.Models;
using Microsoft.Data.SqlClient;

namespace FinalProjectBaraclan.Repository
{
    public class RoomHistoryRepository
    {
        public readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=FinalProjectDatabase;Persist Security Info=True;User ID=sa;Password=vinice2004;Encrypt=True;Trust Server Certificate=True";


        public List<RoomHistory> ReadRoomsHistory()
        {
            List<RoomHistory> rooms = new List<RoomHistory>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboRoomsHistory]";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoomHistory room = new RoomHistory();
                            room.roomNumber = reader.GetInt32(0);
                            room.occupant = reader.GetString(1);
                            room.date = reader.GetDateTime(2);
                            room.occupantNumber = reader.GetString(3);
                            room.roomStyle = reader.GetString(4);

                            long imageSize = reader.GetBytes(reader.GetOrdinal("image"), 0, null, 0, 0);
                            byte[] imageData = new byte[imageSize];
                            reader.GetBytes(reader.GetOrdinal("image"), 0, imageData, 0, (int)imageSize);
                            room.image = imageData;

                            rooms.Add(room);

                        }
                                            

                    }

                }

            }
            return rooms;
        }



        public void ReserveRoom(RoomHistory room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string setIdentityInsertOn = "SET IDENTITY_INSERT [FinalProjectDatabase].[dbo].[dboRoomsHistory] ON";
                using (SqlCommand cmdIdentityInsertOn = new SqlCommand(setIdentityInsertOn, connection))
                {
                    cmdIdentityInsertOn.ExecuteNonQuery();
                }

                string query = "INSERT INTO [FinalProjectDatabase].[dbo].[dboRoomsHistory] " +
                               "(occupant, occupantNumber, dateOccupied, roomNumber, roomStyle, bedStyle, image) " +
                               "VALUES (@occupant, @occupantNumber, @dateOccupied, @roomNumber, @roomStyle, @bedStyle, @image)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@occupant", room.occupant);
                    command.Parameters.AddWithValue("@occupantNumber", room.occupantNumber);
                    command.Parameters.AddWithValue("@dateOccupied", room.date);
                    command.Parameters.AddWithValue("@roomNumber", room.roomNumber);
                    command.Parameters.AddWithValue("@roomStyle", room.roomStyle);
                    command.Parameters.AddWithValue("@bedStyle", room.bedStyle);
                    command.Parameters.AddWithValue("@image", room.image);

                    command.ExecuteNonQuery();
                }

                string setIdentityInsertOff = "SET IDENTITY_INSERT [FinalProjectDatabase].[dbo].[dboRoomsHistory] OFF";
                using (SqlCommand cmdIdentityInsertOff = new SqlCommand(setIdentityInsertOff, connection))
                {
                    cmdIdentityInsertOff.ExecuteNonQuery();
                }
            }
        }





    }
}
