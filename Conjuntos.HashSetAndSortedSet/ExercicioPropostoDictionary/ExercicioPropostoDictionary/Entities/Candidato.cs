

namespace ExercicioPropostoDictionary.Entities
{
    internal class Candidato
    {
        public string Name { get; set; }

        public Candidato()
        {

        }
        
        public Candidato(string name)
        {
            Name = name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Candidato))
            {
                return false;
            }

            Candidato other = obj as Candidato;
            return Name.Equals(other.Name);

        }
    }

}
