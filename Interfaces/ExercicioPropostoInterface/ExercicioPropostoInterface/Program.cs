using ExercicioPropostoInterface.Entities;
using ExercicioPropostoInterface.Services;
using System;
using System.Data;
using System.Globalization;
namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);
            PaymentService paymentService = new PaymentService(installments, new InterestAndFees());
            paymentService.installments(contract);

            foreach (var item in contract.Installment)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
