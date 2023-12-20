using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome = "TV";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Valor);
            Console.WriteLine(produto.Quantidade);

        }
    }
}