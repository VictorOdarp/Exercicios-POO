using System.Globalization;

namespace ExercicioProposto3
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            double Calculo = Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0);
            return Math.Sqrt(Calculo);

        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n" + "PERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n" + "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
