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
    public partial class EmployeeForm : Form
    {
        private string connectionString;
        private RoomDataManager roomDataManager;
        private ReservationDataManager reservationDataManager;
        private UserDataManager userDataManager;

        public EmployeeForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.roomDataManager = new RoomDataManager(connectionString);
            this.reservationDataManager = new ReservationDataManager(connectionString);
            this.userDataManager = new UserDataManager(connectionString);
            LoadRooms();
            LoadReservations();
        }

        private void LoadRooms()
        {
            listBoxRooms.Items.Clear();
            List<Room> rooms = roomDataManager.GetAllRooms();
            foreach (Room room in rooms)
            {
                listBoxRooms.Items.Add($"{room.RoomNumber} ({(room.IsAvailable ? "Available" : "Unavailable")})");
            }
        }

        private void LoadReservations()
        {
            listBoxReservations.Items.Clear();
            List<Reservation> reservations = reservationDataManager.GetAllReservations();
            foreach (Reservation reservation in reservations)
            {
                listBoxReservations.Items.Add($"{reservation.RoomNumber} - {reservation.Username} ({reservation.StartDate.ToShortDateString()} - {reservation.EndDate.ToShortDateString()})");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = NewUsername.Text;
            string password = NewPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            User newUser = new User(username, password, role);
            userDataManager.AddUser(newUser);

            MessageBox.Show("User added successfully.");
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (listBoxReservations.SelectedItem != null)
            {
                string[] parts = listBoxReservations.SelectedItem.ToString().Split('-');
                string roomNumber = parts[0].Trim();
                string username = parts[1].Split('(')[0].Trim();
                DateTime startDate = DateTime.Parse(parts[1].Split('(')[1].Split('-')[0].Trim());
                DateTime endDate = DateTime.Parse(parts[1].Split('-')[1].Split(')')[0].Trim());

                reservationDataManager.DeleteReservation(roomNumber, username, startDate, endDate);
                roomDataManager.UpdateRoomAvailability(roomNumber, true);

                LoadRooms();
                LoadReservations();
            }
        }

        private void btnToggleRoomAvailability_Click(object sender, EventArgs e)
        {
            if (listBoxRooms.SelectedItem != null)
            {
                string[] parts = listBoxRooms.SelectedItem.ToString().Split(' ');
                string roomNumber = parts[0];
                bool isAvailable = parts[1].Trim() == "(Available)";

                roomDataManager.UpdateRoomAvailability(roomNumber, !isAvailable);

                LoadRooms();
            }
        }
    }

}
