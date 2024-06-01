using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    public class Reservation
    {
        public string RoomNumber { get; set; }
        public string Username { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        public Reservation(string roomNumber, string username, DateTime startDate, DateTime endDate, string status)
        {
            RoomNumber = roomNumber;
            Username = username;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
    }

}
