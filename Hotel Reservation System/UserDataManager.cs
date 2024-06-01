using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    
    public class UserDataManager
    {
        private string connectionString;

        public UserDataManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username, Password, Role FROM Users";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User(reader["Username"].ToString(), reader["Password"].ToString(), reader["Role"].ToString()));
                }

                reader.Close();
            }

            return users;
        }

        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@role", user.Role);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
