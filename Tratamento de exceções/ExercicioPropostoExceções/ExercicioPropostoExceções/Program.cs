using ExercicioPropostoExceções.Entities;
using ExercicioPropostoExceções.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioPropostoExceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.withdraw(withdraw);

                Console.WriteLine(account);
            }
            catch (DomainExceptions error)
            {
                Console.WriteLine("Withdraw error: " + error.Message);
            }
            catch (FormatException error)
            {
                Console.WriteLine("Format error: " + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unexpected error: " + error.Message);
            }
            
           
        }
    }
}
