using System;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor : ");
            int b = int.Parse(Console.ReadLine());

            int c = a % 3;
            int d = b % 3;

            if (c == 0 &&  d == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
