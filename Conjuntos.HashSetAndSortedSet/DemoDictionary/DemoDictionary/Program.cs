using System; 

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookie = new Dictionary<string, string>();

            cookie["user"] = "maria";
            cookie["email"] = "maria@gmail.com";
            cookie["phone"] = "9977326";
            cookie["phone"] = "9933244";

            Console.WriteLine(cookie["email"]);
            Console.WriteLine(cookie["phone"]);

            cookie.Remove("email");
            if (cookie.ContainsKey("email") )
            {
                Console.WriteLine(cookie["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookie.Count);
            Console.WriteLine();

            Console.WriteLine("All cookies: ");

            // Pode usar o VAR
            foreach (KeyValuePair<string, string> item in cookie)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}