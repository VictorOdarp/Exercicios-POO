﻿
using System.Runtime.Intrinsics.X86;

namespace ExercicioProposto.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }

    }
}
