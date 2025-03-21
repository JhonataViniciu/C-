using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Inferencia_de_Tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime com Construtores
            DateTime d1 = new DateTime(2025, 03, 21);
            DateTime d2 = new DateTime(2025, 03, 21, 16, 11, 03);
            DateTime d3 = new DateTime(2025, 03, 21, 16, 11, 03, 100);

            //Builders basicos
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2025-03-21");
            DateTime d8 = DateTime.Parse("2025-03-21 16:17:58");
            DateTime d9 = DateTime.Parse("21/03/2025");
            DateTime d10 = DateTime.Parse("21/03/2025 16:18:59");

            DateTime d11 = DateTime.ParseExact("2025-03-21", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("21/03/2025 16:22:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);

        }
    }
}
