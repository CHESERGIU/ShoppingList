using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double GetPrice(double quantity)
        {
            return price * quantity;
        }

        public override string ToString()
        {
            return name;
        }
    }
}