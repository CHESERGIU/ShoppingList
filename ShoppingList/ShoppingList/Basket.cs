using System;

namespace Shopping
{
    public class Basket
    {
        readonly Discount pay;
        Product[] list;

        public Basket(Product[] list)
        {
            this.list = list;
            pay = new Discount(list);
        }

        public void Buy(Product product)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = product;
        }

        public double Pay() => pay.TotalPrice();
    }
}
