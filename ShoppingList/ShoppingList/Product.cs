using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;
        readonly int quantity;

        public Product(string product, double price, int quantity)
        {
            this.name = product;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString() => name;

        public double Price()
        {
            return price;
        }

        public int Quantity()
        {
            return quantity;
        }
    }
}