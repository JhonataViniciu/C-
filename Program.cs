using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    internal class Program
    {

        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+ volume.ToString("F2",CultureInfo.InvariantCulture ));
            Console.WriteLine("Valor de Pi: "+ Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r,3);
        }

    }
}
