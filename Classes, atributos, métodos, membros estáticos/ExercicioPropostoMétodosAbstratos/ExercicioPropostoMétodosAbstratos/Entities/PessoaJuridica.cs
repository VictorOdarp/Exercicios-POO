

namespace ExercicioPropostoMétodosAbstratos.Entities
{
    internal class PessoaJuridica : Contribuintes
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome, rendaAnual) 
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double totalImposto()
        {
            double imposto = 0.0;

            if (NumeroDeFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else if (NumeroDeFuncionarios < 10)
            {
                imposto = RendaAnual * 0.16;
            }

            return imposto;
        }
    }
}
