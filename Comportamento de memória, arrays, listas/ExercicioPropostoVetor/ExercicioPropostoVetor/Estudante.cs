

using System.Security.Cryptography.X509Certificates;

namespace ExercicioPropostoVetor
{
    internal class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public int Room; 

        public Estudante()
        {

        }

        public Estudante(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
