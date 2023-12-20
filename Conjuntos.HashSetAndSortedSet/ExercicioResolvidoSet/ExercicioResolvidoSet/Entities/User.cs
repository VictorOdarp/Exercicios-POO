

using System.Diagnostics;

namespace ExercicioResolvidoSet.Entities
{
    internal class User
    {
       public string Name { get; set; }
       public DateTime Instant { get; set; }

       public User(string name, DateTime instant)
        {
            Name = name;
            Instant = DateTime.Now;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
            {
                return false;
            }

            User other = obj as User;
            return Name.Equals(other.Name);

        }

    }
}
