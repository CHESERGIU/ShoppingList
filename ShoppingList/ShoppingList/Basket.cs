using System;

namespace Shopping
{
    public class Basket
    {
        readonly Discount discounts;
        private Product[] list;

        public Basket()
        {
            this.list = new Product[] { };
            this.discounts = new Discount(new Product(new Product("", 0, 0)));
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
