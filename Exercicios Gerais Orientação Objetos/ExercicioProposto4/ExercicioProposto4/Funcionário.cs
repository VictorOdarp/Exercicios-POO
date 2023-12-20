

using System.Globalization;
namespace ExercicioProposto4
{
    internal class Funcionário
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double Quantidade)
        {
            SalarioBruto = (Quantidade / 100) * SalarioBruto + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome + ", " + "$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

       
        
    }
}
