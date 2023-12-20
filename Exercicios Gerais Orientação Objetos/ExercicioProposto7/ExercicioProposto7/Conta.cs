using System.Globalization;

namespace ExercicioProposto7
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }

        public Conta()
        {

        }
        public Conta(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = 0.0;
        }

        public Conta(int numeroConta, string titularConta, double depositoInicial) : this(numeroConta, titularConta)
        {
            Deposito(depositoInicial);
        }


        public void Deposito(double valor)
        {
            SaldoConta = valor + SaldoConta;
        }

        public void Saque(double valor)
        {
            SaldoConta = SaldoConta - valor - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", " + "Titular: " + TitularConta + ", " + "Saldo: $ " + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
