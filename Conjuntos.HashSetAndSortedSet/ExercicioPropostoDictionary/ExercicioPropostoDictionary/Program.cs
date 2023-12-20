using ExercicioPropostoDictionary.Entities;
using System; 

namespace ExercicioPropostoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string SourcePath = Console.ReadLine();

            Dictionary<string, int> Candidato = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(SourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(',');
                        string name = vet[0];
                        int votos = int.Parse(vet[1]);

                        if (Candidato.ContainsKey(name))
                        {
                            Candidato[name] += votos;
                        }
                        else
                        {
                            Candidato[name] = votos;
                        }

                    }

                    foreach (KeyValuePair<string, int> item in Candidato)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
