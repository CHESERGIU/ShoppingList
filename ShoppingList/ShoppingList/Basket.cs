using System;

namespace Shopping
{
    public class Basket
    {
        Product[] list;

        public Basket()
        {
            this.list = new Product[] { };
        }

        public void Buy(Product product)
        {
            Array.Resize(ref list, list.Length + 1);
            this.list[list.Length - 1] = product;
        }

        public decimal Pay()
        {
            return Product.GetTotalPrice(this.list);
        }
    }
}
