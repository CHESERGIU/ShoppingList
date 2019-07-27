using System;

namespace Shopping
{
    public class Basket
    {
        readonly Discount discounts;
        readonly Product product;
        Product[] list;

        public Basket()
        {
            product = new Product("", 0, 0);
            list = new Product[] { };
            discounts = new Discount();
        }

        public void Buy(Product product)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = product;
        }

        public double Pay()
        {
            return discounts.GetDiscount(product.GetPrices(list), product.GetQuantity(list));
        }
    }
}
