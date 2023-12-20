using System.Globalization;

namespace ExercicioPropostoMétodosAbstratos.Entities
{
    internal class PessoaFisica : Contribuintes
    {
        public double GastoComSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double totalImposto()
        {
            double imposto = 0.0;

            if (RendaAnual < 20000.00)
            {
              imposto = (RendaAnual * 0.15) - GastoComSaude * 0.50;
            }
            else if (RendaAnual >= 20000.00)
            {
                imposto = (RendaAnual * 0.25) - GastoComSaude * 0.50;
            }

            return imposto;
        
        }
    }
}
