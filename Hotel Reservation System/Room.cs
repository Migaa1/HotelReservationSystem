using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string roomNumber, bool isAvailable)
        {
            RoomNumber = roomNumber;
            IsAvailable = isAvailable;
        }
    }

}
