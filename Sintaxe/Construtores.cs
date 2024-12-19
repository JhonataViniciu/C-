using System;
using System.Globalization;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produtos p = new Produtos("Tv", 500.00);

            p.SetNome("Tv 4k");

            Console.WriteLine(p.GetNome());
        }
    }
}
