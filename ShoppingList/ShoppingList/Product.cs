using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;
        readonly double quantity;

        public Product(string name, double price, double quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double GetPrices(Product item)
        {
            return item.price * item.quantity;
        }

        public override string ToString()
        {
            return name;
        }
    }
}