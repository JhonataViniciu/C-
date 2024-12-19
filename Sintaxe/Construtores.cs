using System;
using System.Globalization;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produtos p = new Produtos("Tv", 500.00);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
