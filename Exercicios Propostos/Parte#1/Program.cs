using System;
using System.Globalization;

namespace Exercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);
            
            Console.WriteLine(area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
