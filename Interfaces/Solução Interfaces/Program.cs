using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Interfaces.Entities;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car Model");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}
