
using System.Globalization;


namespace Construtores
{
    internal class Produtos
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produtos() { 
        }
        public Produtos(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }
        public Produtos(string nome, double preco, int quantidade) : this(nome, preco) {
            _quantidade = quantidade;
        }

        public string GetNome() { 
        return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }
        public double ValorToatlEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorToatlEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
