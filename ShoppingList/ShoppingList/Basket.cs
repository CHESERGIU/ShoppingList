using System;

namespace Shopping
{
    public class Basket
    {
        Product[] list;
        decimal[] amount;

        public Basket()
        {
            this.list = new Product[] { };
            this.amount = new decimal[] { };
        }

        public void Buy(Product product, decimal quantity)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = product;
            Array.Resize(ref amount, amount.Length + 1);
            amount[amount.Length - 1] = quantity;
        }

        public decimal Pay(Discount.DiscountType type)
        {
            decimal result = 0;
            for (int i = 0; i < list.Length; i++)
            {
                result += list[i].GetPrice(amount[i], type);
            }

            return result;
        }
    }
}
