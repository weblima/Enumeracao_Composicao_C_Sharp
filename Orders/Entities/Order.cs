using System.Collections.Generic;
using Orders.Entities.Enums;
using System;
using System.Text;
using System.Globalization;

namespace Orders.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Clients Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order() { 
        
        }

        public Order(DateTime moment, OrderStatus status, Clients client) {
            Moment = moment;
            Status = status;
            Client = client;
        }


        public void AddItem(OrderItem item) {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Itens.Remove(item);
        }

        public double Total() {

            double sum = 0;

            foreach (OrderItem item in Itens) {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString() {
            StringBuilder strOrder = new StringBuilder();
            strOrder.AppendLine("ORDER SUMMARY:");
            strOrder.Append("Order moment: ");
            strOrder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm"));
            strOrder.Append("Order status: ");
            strOrder.AppendLine(Status.ToString());
            strOrder.Append("Client: ");
            strOrder.Append(Client.Name);
            strOrder.Append(" (");
            strOrder.Append(Client.BirthDate.ToString("dd/MM/yyy"));
            strOrder.Append(") - ");
            strOrder.AppendLine(Client.Email);
            strOrder.AppendLine("Order items: ");
            foreach (OrderItem i in Itens) {
                strOrder.Append(i.Product.Name);
                strOrder.Append(", $");
                strOrder.Append(i.Price.ToString("F2",CultureInfo.InvariantCulture));
                strOrder.Append(", Quantity: ");
                strOrder.Append(i.Quantity);
                strOrder.Append(", Subtotal: ");
                strOrder.AppendLine(i.SubTotal().ToString("F2", CultureInfo.InvariantCulture)); 
            }

            strOrder.Append("Total price: $");
            strOrder.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return strOrder.ToString();
        }
    }
}
