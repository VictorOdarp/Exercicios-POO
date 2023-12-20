using System.Globalization;

namespace ExercicioPropostoListas
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id)
        {
            Id = id;
        }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentarSalario(double quantidade)
        {
            quantidade = (quantidade / 100.0) * Salario;
            Salario += quantidade;
            
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
