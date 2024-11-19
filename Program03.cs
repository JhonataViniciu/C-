using System;
using System.Globalization;

namespace program02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definindo as variaveis//
            char genero = 'F';
            int idade = 32;
            double saldo = 10.358768418;
            string nome = "maria";

            //aprendendo as diferencas de saidas
            Console.Write("Bom dia!"); 
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("---------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));//delimitando as casas decimais
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); 
        }
    }
}
