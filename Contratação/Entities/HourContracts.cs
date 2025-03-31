using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Entities
{
    internal class HourContracts
    {

        public DateTime  Date{ get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContracts(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hours;
        }

        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}
