using System.Globalization;

namespace ExercicioResolvido2
{
    internal class Produto
    {
        private string _nome;
        public double Valor { get; private set; }
        public  int Quantidade { get; private set; }

        public Produto()
        {

        }
        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public Produto(string nome, double valor)
        {
            _nome = nome;
            Valor = valor;
            Quantidade = 0;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEstoque()
        {
            return Quantidade * Valor;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int removerQuantidade)
        {
            Quantidade = Quantidade - removerQuantidade;
        }

        public override string ToString()
        {
            return _nome + ", R$ " + Valor.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
