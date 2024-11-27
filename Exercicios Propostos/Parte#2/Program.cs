using System;
using System.Globalization;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("CODIGO     ESPECIFICAÇÃO       PREÇO   ");
            Console.WriteLine(" 1        cachorro quente    R$:4,00   ");
            Console.WriteLine(" 2           X-Salada        R$:4,50   ");
            Console.WriteLine(" 3           X-Bacon         R$:5,00   ");
            Console.WriteLine(" 4        Torrada Simples    R$:2,00   ");
            Console.WriteLine(" 5         Refrigerante      R$:1,50   ");

            Console.WriteLine("Escolha seu produto pelo Codigo");
            double cod = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto");
            double qnt = double.Parse(Console.ReadLine());

            if (cod == 1)
            {
                cod = 4.00 * qnt;
                Console.WriteLine($"O total ficou R${cod.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 2)
            {
                cod = 4.50 * qnt;
                Console.WriteLine($"O total ficou R${cod.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 3)
            {
                cod = 5.00 * qnt;
                Console.WriteLine($"O total ficou R${cod.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 4)
            {
                cod = 2.00 * qnt;
                Console.WriteLine($"O total ficou R${cod.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 5)
            {
                cod = 1.50 * qnt;
                Console.WriteLine($"O total ficou R${cod.ToString("F2", CultureInfo.InvariantCulture)}");
            }


        }

    }
}
