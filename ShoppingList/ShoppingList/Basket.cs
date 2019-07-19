using System;

namespace Shopping
{
    public class Basket
    {
        readonly Discount discounts;
        Product[] list;

        public Basket()
        {
            this.list = new Product[] { };
            this.discounts = new Discount(list);
        }

        public void Buy(Product product)
        {
            Array.Resize(ref list, list.Length + 1);
            this.list[list.Length - 1] = product;
        }

        public double Pay()
        {
            return discounts.GetDiscount(list);
        }
    }
}
