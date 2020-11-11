using System;

namespace Orders.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Products Product { get; set; }

        public OrderItem() {

        }
        public OrderItem(int quantity, double price, Products product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()  {

            return Quantity * Price;
        }
    }
}
