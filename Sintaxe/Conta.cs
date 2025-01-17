using System;
using System.Globalization;

namespace Conta_Bancaria
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            DadosBancario conta;
            
            Console.Write("Entre com o numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new DadosBancario(numero, titular, depositoInicial);
            }
            else
            {
                conta = new DadosBancario(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
        }
    }
}
