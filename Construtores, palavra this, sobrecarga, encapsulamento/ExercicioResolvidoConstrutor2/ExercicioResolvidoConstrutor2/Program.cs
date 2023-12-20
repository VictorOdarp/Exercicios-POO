using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adicione o produto: ");
            string nome = Console.ReadLine();
            Console.Write("Qual o valor do seu produto? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto P;

            P = new Produto(nome, valor);

            Console.WriteLine("Dados do produto: " + P);
            Console.WriteLine();


            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int Quant = int.Parse(Console.ReadLine());

            Console.WriteLine();
            P.AdicionarProdutos(Quant);


            Console.WriteLine("Dados atualizados: " + P);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            Quant = int.Parse(Console.ReadLine());

            P.RemoverProdutos(Quant);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + P);



        }
    }
}
