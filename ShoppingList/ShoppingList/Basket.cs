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
            this.discounts = new Discount(new Product("", 0), 0, 0);
        }

        public void Buy(Product product)
        {
            Array.Resize(ref list, list.Length + 1);
            this.list[list.Length - 1] = product;
        }

        public decimal Pay()
        {
            return list[0].GetTotalPrice(this.list, discounts);
        }
    }
}
