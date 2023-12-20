

using System.Globalization;

namespace ExercicioResolvido2
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

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
            return Nome + ", R$ " + Valor.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
