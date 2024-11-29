using System;

namespace Program14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce vai digitar? :");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++) {
                Console.Write("valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("soma = "+ soma);
        }
    }
}
