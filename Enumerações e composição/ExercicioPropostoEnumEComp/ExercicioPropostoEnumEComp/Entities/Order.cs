using ExercicioPropostoEnumEComp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioPropostoEnumEComp.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
           Items.Remove(item);
        }

        public double total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }

            return sum;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            stringBuilder.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return stringBuilder.ToString();
            
        }

    }
}
