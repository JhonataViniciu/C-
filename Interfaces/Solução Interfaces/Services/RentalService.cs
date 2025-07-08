using System;
using Interfaces.Entities;
namespace Interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
