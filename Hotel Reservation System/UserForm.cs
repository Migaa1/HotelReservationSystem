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
   
    public partial class UserForm : Form
    {
        private string username;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Filip\\source\\repos\\Hotel Reservation System\\Hotel Reservation System\\HotelReservationDB.mdf\";Integrated Security=True;Connect Timeout=30"; 
        private RoomDataManager roomDataManager;
        private ReservationDataManager reservationDataManager;

        public UserForm(string username, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.connectionString = connectionString;
            this.roomDataManager = new RoomDataManager(connectionString);
            this.reservationDataManager = new ReservationDataManager(connectionString);
            LoadAvailableRooms();
            LoadUserReservations();
        }

        private void LoadAvailableRooms()
        {
            listBoxAvailableRooms.Items.Clear();
            List<Room> rooms = roomDataManager.GetAllRooms();
            foreach (Room room in rooms)
            {
                if (room.IsAvailable)
                {
                    listBoxAvailableRooms.Items.Add(room.RoomNumber);
                }
            }
        }

        private void LoadUserReservations()
        {
            listBoxReservations.Items.Clear();
            List<Reservation> reservations = reservationDataManager.GetAllReservations();
            foreach (Reservation reservation in reservations)
            {
                if (reservation.Username == username)
                {
                    listBoxReservations.Items.Add($"{reservation.RoomNumber} ({reservation.StartDate.ToShortDateString()} - {reservation.EndDate.ToShortDateString()})");
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableRooms.SelectedItem != null)
            {
                string roomNumber = listBoxAvailableRooms.SelectedItem.ToString();
                DateTime startDate = dateTimePickerStartDate.Value;
                DateTime endDate = dateTimePickerEndDate.Value;
                string status = "Reserved";

                Reservation reservation = new Reservation(roomNumber, username, startDate, endDate, status);
                reservationDataManager.AddReservation(reservation);
                roomDataManager.UpdateRoomAvailability(roomNumber, false);

                LoadAvailableRooms();
                LoadUserReservations();
            }
            else
            {
                MessageBox.Show("Please select a room.");
            }
        }
    }

}
