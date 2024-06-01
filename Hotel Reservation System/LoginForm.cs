using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class LoginForm : Form
    {
        private string connectionString;
        public LoginForm()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Filip\\source\\repos\\Hotel Reservation System\\Hotel Reservation System\\HotelReservationDB.mdf\";Integrated Security=True;Connect Timeout=30"; ;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    if (role == "user")
                    {
                        UserForm userForm = new UserForm(username, connectionString);
                        userForm.Show();
                    }
                    else if (role == "employee")
                    {
                        EmployeeForm employeeForm = new EmployeeForm(connectionString);
                        employeeForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
            }
        }
    }

}
