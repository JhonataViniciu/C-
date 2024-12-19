
using System.Globalization;


namespace Construtores
{
    internal class Produtos
    {
        //Atributos;
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores
        public Produtos() { 
        }
        public Produtos(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }
        public Produtos(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        } 

        //Propriedades Customizadas
        public string Nome { 
            get { return _nome; }
            set {
                if ( value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Metodos
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorToatlEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
