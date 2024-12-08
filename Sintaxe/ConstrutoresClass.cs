
using System.Globalization;


namespace Construtores
{
    internal class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorToatlEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorToatlEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
