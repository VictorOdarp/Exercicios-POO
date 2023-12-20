

using ExercicioPropostoInterface.Entities;
using System.ComponentModel;

namespace ExercicioPropostoInterface.Services
{
    internal class PaymentService
    {
        public int NumberOfInstallments { get; set; }
        private IinterestAndFees _IinterestAndFees;

        public PaymentService()
        {

        }

        public PaymentService(int numberOfInstallments, IinterestAndFees iinterestAndFees)
        {
            NumberOfInstallments = numberOfInstallments;
            _IinterestAndFees = iinterestAndFees;
        }

        public void installments(Contract contract)
        {
            double amount = contract.TotalValue / NumberOfInstallments;

            for (int i = 1;  i <= NumberOfInstallments; i++)
            {
                amount += _IinterestAndFees.simpleInterest(amount * i);
                amount += _IinterestAndFees.Paymentfee(amount);
                DateTime dateTime = contract.Date.AddMonths(i);
                contract.Installment.Add(new Installment(dateTime, amount));
                amount = contract.TotalValue / NumberOfInstallments;

            }



        }

    }
}
