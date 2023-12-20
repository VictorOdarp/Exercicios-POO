

namespace ExercicioProposto.Entities
{
    internal class Funcionary
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Funcionary()
        {

        }

        public Funcionary(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
