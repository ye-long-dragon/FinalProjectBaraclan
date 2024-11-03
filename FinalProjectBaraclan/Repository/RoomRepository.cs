using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectBaraclan.Models;
using Microsoft.Data.SqlClient;

namespace FinalProjectBaraclan.Repository
{
    public class RoomRepository
    {
        public readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=FinalProjectDatabase;Persist Security Info=True;User ID=sa;Password=vinice2004;Encrypt=True;Trust Server Certificate=True";


        public List<Room> ReadRooms()
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [FinalProjectDatabase].[dbo].[dboRooms]";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room();
                            room.roomNumber = reader.GetInt32(0);
                            room.occupant = reader.GetString(1);
                            room.date = reader.GetDateTime(2);
                            room.occupantNumber = reader.GetString(3);
                            room.roomStyle = reader.GetString(4);

                            rooms.Add(room);

                        }
                                            

                    }

                }

            }
            return rooms;
        } 
        









    }
}
