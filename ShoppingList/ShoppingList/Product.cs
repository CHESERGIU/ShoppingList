using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly decimal price;
        readonly Discount discount;

        public Product(string name, decimal price, Discount discount)
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }

        public decimal GetPrice(decimal quantity)
        {
            if (discount.IsQuantity(discount))
            {
                return discount.Apply(quantity, discount) * price;
            }

            if (discount.IsTenPack(discount))
            {
                return discount.Apply(quantity, discount) * price;
            }

            if (discount.IsPriceOff(discount))
            {
                return discount.Apply(price, discount) * quantity;
            }

            if (discount.IsFree(discount))
            {
                return price * discount.Apply(quantity, discount);
            }

            return price * quantity;
        }

        public override string ToString()
        {
            return name;
        }
    }
}