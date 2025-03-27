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
            // Acrescentando valores ao Horario
            DateTime d = DateTime.Now;

            DateTime d2 = d.AddHours(2); 
            
            DateTime d3 = d.AddMinutes(3);

            DateTime d4 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Subtraindo valores entre horarios
            DateTime d5 = new DateTime(2000, 10, 18);
            DateTime d6 = new DateTime(2000, 10, 10);

            TimeSpan t = d6.Subtract(d5);

            Console.WriteLine(t);
        }
    }
}
