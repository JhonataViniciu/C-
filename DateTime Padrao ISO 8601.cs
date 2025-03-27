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

            //Horario Local
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58"); //Formato Utc
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");//Formato Instanciado

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
