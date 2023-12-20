

using ExercicioPropostoInterface.Entities;

namespace ExercicioPropostoInterface.Services
{
    internal class InterestAndFees : IinterestAndFees
    {
        public double simpleInterest(double amount)
        {
            return amount *= 0.01;
            

        }
        public double Paymentfee(double amount)
        {
            return amount *= 0.02;
        }
    }
}
