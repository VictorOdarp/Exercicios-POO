using System;
using System.Globalization;

namespace ExercicioProposto7
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine()); 

            Console.Write("Entre com o titular da conta: ");
            string titularConta = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char validação = char.Parse(Console.ReadLine());


            if (validação == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titularConta, DepositoInicial); 
                

                Console.WriteLine();

                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
                Console.WriteLine();

            }
            else if (validação == 'n')
            {
                conta = new Conta(numeroConta, titularConta);
                Console.WriteLine();

                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
                Console.WriteLine();
            }

            Console.Write("Entre um valor para depósito: ");
            double Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(Deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            
            
            
        }
    }
}
