

namespace ExercicioProposto1.Entities
{
    internal class Aluno
    {
        public int ID { get; set; }

        public Aluno(int id)
        {
            ID = id;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aluno))
            {
                return false;
            }
            Aluno other = obj as Aluno;
            return ID.Equals(other.ID);
        }
    }
}
