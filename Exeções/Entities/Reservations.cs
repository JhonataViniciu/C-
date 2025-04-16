using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch.Entities
{
    internal class Reservations
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservations() { }

        public Reservations(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime chackIn, DateTime chackOut)
        {
            CheckIn = chackIn;
            CheckOut = chackOut;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nigths";
        }
    }
}
