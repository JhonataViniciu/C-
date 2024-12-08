using System;
using System.Globalization;

namespace Program16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removido: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
