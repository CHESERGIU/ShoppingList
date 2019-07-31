using System;

namespace Shopping
{
    public class Product
    {
        readonly Discount discount;
        readonly string name;
        readonly decimal price;

        public Product(string name, decimal price, Discount discount)
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }

        public decimal GetPrice(decimal quantity)
        {
            return price * (quantity - discount.GetDiscount());
        }

        public override string ToString()
        {
            return name;
        }
    }
}