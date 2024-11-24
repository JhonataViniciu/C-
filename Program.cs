using System;

namespace Exercicios_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca =  (A * B - C * D);

            Console.WriteLine(diferenca);
        }
    }
}
