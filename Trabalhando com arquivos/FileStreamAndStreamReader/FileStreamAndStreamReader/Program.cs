using System;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Victo\Desktop\Projeto Cadastro\Formulario.txt";
            FileStream fs = null;
            StreamReader sr = null;
            
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException error)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(error.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}


