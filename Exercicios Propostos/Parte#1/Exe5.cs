
using System;
using System.Globalization;


namespace Exercicios_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o codigo da peca? ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas pecas serao? ");
            int qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da peca? ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o codigo da peca? ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas pecas serao? ");
            int qnt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da peca? ");
            double valor2 = double.Parse(Console.ReadLine());

            double valor_total = qnt * valor;
            double valor_total2 = qnt2 * valor2;
            double res = valor_total + valor_total2;
            Console.WriteLine("VALOR TOTAL A PAGAR = " + res.ToString("F2"));
        }
    }
}
