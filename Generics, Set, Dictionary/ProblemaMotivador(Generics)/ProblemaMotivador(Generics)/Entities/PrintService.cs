

namespace ProblemaMotivador_Generics_.Entities
{
    internal class PrintService<T>

    {
        public List<T> PrintServices = new List<T>();
        private int _count = 0;


        public void addValue(T value)

        {
            PrintServices.Add(value);
            _count++;
        }

        public T first()
        {
            
            T first = PrintServices[0];
            return first;

        }

        public void print()
        {

            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(PrintServices[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(PrintServices[_count - 1]);
                Console.WriteLine("]");
            }
            Console.WriteLine("First: " + first().ToString());

        }

    }
}
