using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    public class ReservationDataManager
    {
        private string connectionString;

        public ReservationDataManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Reservation> GetAllReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomId, UserId, StartDate, EndDate, Status FROM Reservations";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reservations.Add(new Reservation(
                        reader["RoomId"].ToString(),
                        reader["UserId"].ToString(),
                        (DateTime)reader["StartDate"],
                        (DateTime)reader["EndDate"],
                        reader["Status"].ToString()));
                }

                reader.Close();
            }

            return reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reservations (RoomId, UserId, StartDate, EndDate, Status) VALUES (@roomNumber, @username, @startDate, @endDate, @status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomNumber", reservation.RoomNumber);
                command.Parameters.AddWithValue("@username", reservation.Username);
                command.Parameters.AddWithValue("@startDate", reservation.StartDate);
                command.Parameters.AddWithValue("@endDate", reservation.EndDate);
                command.Parameters.AddWithValue("@status", reservation.Status);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteReservation(string roomNumber, string username, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Reservations WHERE RoomId = @roomNumber AND UserId = @username AND StartDate = @startDate AND EndDate = @endDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomNumber", roomNumber);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
