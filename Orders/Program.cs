using Orders.Entities;
using Orders.Entities.Enums;
using System;
using System.Globalization;

namespace Orders {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Clients clients = new Clients(clientName, clientEmail, birthDate);
            Order order = new Order(DateTime.Now, status, clients);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i <= n; i++) {
                
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Products products = new Products(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, products);
                order.AddItem(orderItem);
            }



        }
    }
}
