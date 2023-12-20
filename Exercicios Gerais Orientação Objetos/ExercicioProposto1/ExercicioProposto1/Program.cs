using ExercicioProposto1;
using System;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Pessoa1, Pessoa2; 

            Pessoa1 = new Pessoa();
            Pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            Pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            Pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + Pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + Pessoa2.nome);
            }
            


        }
    }
}