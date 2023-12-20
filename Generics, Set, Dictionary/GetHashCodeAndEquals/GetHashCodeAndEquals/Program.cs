using GetHashCodeAndEquals.Entities;

Client client = new Client { Name = "Alex", Email = "Maria@gmail.com" };
Client client2 = new Client { Name = "Maria", Email = "Alex@gmail.com" };

Console.WriteLine(client.Equals(client2));
Console.WriteLine(client.GetHashCode());
Console.WriteLine(client2.GetHashCode());