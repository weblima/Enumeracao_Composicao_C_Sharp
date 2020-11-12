using System.Collections.Generic;
using Orders.Entities.Enums;
using System;

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
    }
}
