using DemonstraçãoHerança.Entities;
using System;

namespace DemonstraçãoHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Account account = new Account(1001, "Victor", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Carlos", 0.0, 500.00);

            // UPCASTING

            Account account1 = bacc;
            Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account account3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.00);
            Console.WriteLine(account4.Balance);

            // BusinessAccount acc5 = (BusinessAccount)account3;

            if (account3 is BusinessAccount)
            {
                // BusinessAccount account5 = (BusinessAccount)account3;
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(200.00);
                Console.WriteLine("Loan");
            }

            if (account3 is SavingsAccount)
            {
                // SavingsAccount account5 = (SavingsAccount)account3;
                SavingsAccount account5 = account3 as SavingsAccount;
                account5.Deposit(10.0);
                account5.updateBalance();
                Console.WriteLine("Update!");
                Console.WriteLine(account5.Balance);
            }*/


            Account account1 = new Account(1001, "Alex", 500.00);
            Account account2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}
