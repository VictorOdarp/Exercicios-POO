using System.Globalization;

namespace ExercicioResolvido2
{
    internal class Produto
    {
        private string _nome;
        private double _valor;
        private int _quantidade;

        public Produto()
        {

        }
        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }

        public Produto(string nome, double valor)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = 0;
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

        public double Valor
        {
            get { return _valor; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEstoque()
        {
            return _quantidade * _valor;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade = _quantidade + quantidade;
        }

        public void RemoverProdutos(int removerQuantidade)
        {
            _quantidade = _quantidade - removerQuantidade;
        }

        public override string ToString()
        {
            return _nome + ", R$ " + _valor.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
