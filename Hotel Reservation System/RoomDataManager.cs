using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    public class RoomDataManager
    {
        private string connectionString;

        public RoomDataManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomNumber, IsAvailable FROM Rooms";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rooms.Add(new Room(reader["RoomNumber"].ToString(), (bool)reader["IsAvailable"]));
                }

                reader.Close();
            }

            return rooms;
        }

        public void UpdateRoomAvailability(string roomNumber, bool isAvailable)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Rooms SET IsAvailable = @isAvailable WHERE RoomNumber = @roomNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@isAvailable", isAvailable);
                command.Parameters.AddWithValue("@roomNumber", roomNumber);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
