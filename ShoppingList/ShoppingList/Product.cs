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

        public decimal GetPrice(decimal quantity, Discount.DiscountType type)
        {
            if (type == Discount.DiscountType.Quantity)
            {
                return discount.GetDiscount(quantity, discount) * price;
            }

            if (type == Discount.DiscountType.TenPack)
            {
                return discount.GetDiscount(quantity, discount) * price;
            }

            if (type == Discount.DiscountType.PriceOff)
            {
                return discount.GetDiscount(price, discount) * quantity;
            }

            if (type == Discount.DiscountType.Free)
            {
                return price * discount.GetDiscount(quantity, discount);
            }

            return price * quantity;
        }

        public override string ToString()
        {
            return name;
        }
    }
}