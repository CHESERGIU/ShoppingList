using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;
        readonly int quantity;

        public Product(string product, double prices, int quantity)
        {
            this.name = product;
            this.price = prices;
            this.quantity = quantity;
        }

        public double GetPrices(Product[] list)
        {
            double result = 0;
            foreach (var item in list)
            {
                result += item.price * item.quantity;
            }

            return result;
        }

        public double GetQuantity(Product[] list)
        {
            double result = 0;
            foreach (var item in list)
            {
                result += item.quantity;
            }

            return result;
        }

        public override string ToString() => name;
    }
}