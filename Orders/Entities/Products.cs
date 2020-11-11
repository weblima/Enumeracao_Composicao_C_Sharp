namespace Orders.Entities {
    class Products {
        public string Name { get; set; }

        public double price { get; set; }

        public Products() { 
        
        }
        public Products(string name, double price) {
            Name = name;
            this.price = price;
        }
    }
}
