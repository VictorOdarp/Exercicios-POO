using ProblemaMotivador_Generics_.Entities;
using System;

namespace ProblemaMotivador
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> services = new PrintService<int>();

            Console.Write("How Many values? ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {
               int value = int.Parse(Console.ReadLine());
               services.addValue(value);
                
            }

            services.print();
            
           
           

        }
    }
}
