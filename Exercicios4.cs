using System;
using System.Globalization;

namespace Exercicios_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = int.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            double horas = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            double res = salario * horas;

            Console.WriteLine("NUMBER = " + codigo);
            Console.WriteLine("SALARY =  U$ " + res.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
