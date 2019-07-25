using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;
        readonly int quantity;
        readonly Product product;

        public Product(string product, double prices, int quantity)
        {
            this.name = product;
            this.price = prices;
            this.quantity = quantity;
        }

        public Product(Product product)
        {
            this.product = product;
        }

        public double Price()
        {
            return product.price * product.quantity;
        }

        public int Quantity()
        {
            return product.quantity;
        }

        public override string ToString() => name;
    }
}