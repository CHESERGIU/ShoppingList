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
            this.discounts = new Discount(0, 0);
        }

        public void Buy(Product product)
        {
            Array.Resize(ref list, list.Length + 1);
            this.list[list.Length - 1] = product;
        }

        public double Pay()
        {
            return GetTotalPrice();
        }

        public double GetTotalPrice()
        {
            double result = 0;
            if (list == null || list.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (discounts == null)
                {
                    return 0;
                }

                result += discounts.GetDiscounts();
            }

            return result;
        }
    }
}
