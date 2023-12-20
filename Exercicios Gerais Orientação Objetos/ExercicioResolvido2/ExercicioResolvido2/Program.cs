using System;
using System.Globalization;

namespace ExercicioResolvido2
{
     class Program
    {
        static void Main(string[] args)
        {
            Produto P;

            P = new Produto();

            Console.Write("Adicione o produto: ");
            P.Nome = Console.ReadLine();
            Console.Write("Qual o valor do seu produto? ");
            P.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Adicione a quantidade do seu produto: ");
            P.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + P);
            Console.WriteLine();


            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int Quant = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            P.AdicionarProdutos(Quant);


            Console.WriteLine("Dados atualizados: " +  P);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            Quant = int.Parse(Console.ReadLine());

            P.RemoverProdutos(Quant);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + P);
            

        }
    }
}
