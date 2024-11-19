using System;
using System.Globalization;

namespace program03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.358768418;
            string nome = "maria";

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação 
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
