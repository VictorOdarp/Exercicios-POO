
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioPropostoMétodosAbstratos.Entities
{
    abstract class Contribuintes
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuintes()
        {

        }

        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double totalImposto();

        public override string ToString()
        {
            return Nome + ": $ " + totalImposto().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
