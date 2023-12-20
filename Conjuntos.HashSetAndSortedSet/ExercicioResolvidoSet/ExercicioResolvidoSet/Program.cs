using ExercicioResolvidoSet.Entities;
using System;
using System.IO;

Console.Write("Enter file full path: ");
string SourcePath = Console.ReadLine();

HashSet<User> set = new HashSet<User>();

int cont = 0;
try
{
    using (StreamReader sr = File.OpenText(SourcePath))
    {
        while (!sr.EndOfStream)
        {
            string[] vet = sr.ReadLine().Split(' ');
            string name = vet[0];  
            DateTime instant = DateTime.Parse(vet[1]);
            set.Add(new User (name, instant));

        }

        Console.WriteLine("Total User: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
