using System;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("O numero é par");
            }
            else {
                Console.WriteLine("O numero é impar");
            }
        }
    }
}
