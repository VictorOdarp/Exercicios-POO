

namespace LINQWithLambda
{
    class Program
    {
        static void Print<T>(string Message, IEnumerable<T> collection)
        {
            Console.WriteLine(Message);

            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 },

            };

            var r1 = products.Where(x => x.Price < 900.0 && x.Category.Tier == 1);
            Print("TIER 1 AND PRICE < 900.0:", r1);

            var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name});
            Print("NAMES OF PRODUCTS WITH A C", r3);

            var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 AND TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " +  r6);
            Console.WriteLine();

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default test1: " + r8);
            Console.WriteLine();

            var r9 = products.Where(x => x.Id > 30).SingleOrDefault();
            Console.WriteLine("Single or Default test1: " + r9);

            var r10 = products.Max(x => x.Price);
            Console.WriteLine();

            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(x => x.Price);
            Console.WriteLine();

            Console.WriteLine("Min Price: " + r11);
            Console.WriteLine();

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Sum of products Category 1: " + r12);
            Console.WriteLine();

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Avarage of products Category 1: " + r13);
            Console.WriteLine();

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Avarage of products Category 5: " + r14);
            Console.WriteLine();

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((X, Y) => X + Y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach (var group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }










        }
    }
}
