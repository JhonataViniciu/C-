using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            Console.Write("Digite sua senha (4 digitos): ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2020) {
                Console.Write("Senha invalida. \n  Digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            } 
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
