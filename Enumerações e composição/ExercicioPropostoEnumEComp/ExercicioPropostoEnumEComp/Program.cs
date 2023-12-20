using System;
using ExercicioPropostoEnumEComp.Entities;
using ExercicioPropostoEnumEComp.Entities.Enums;
using System.Globalization;


namespace ExercicioPropostoEnumEComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthdate);
            Order order = new Order(DateTime.Now, status, client);


            Console.Write("How many items to this order? ");
            int QuantItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= QuantItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product name: ");
                string item = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(item, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.addItem(orderItem);

            }

            Console.WriteLine();
            
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + client.Name + " (" + birthdate.ToString("dd/MM/yyyy") + ") - " + client.Email);
            Console.WriteLine("Order items: ");
            Console.WriteLine(order);
            
            
            

            



        }
    }
}