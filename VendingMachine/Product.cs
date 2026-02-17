using System;

namespace VendingMachine
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public Product(int id, string name, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public void DecrementStock()
        {
            if (this.Stock > 0)
                this.Stock--;
        }
    }
}
