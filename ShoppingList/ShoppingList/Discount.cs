using System;

namespace Shopping
{
    public partial class Discount
    {
        readonly DiscountType type;
        readonly decimal quantity;
        readonly decimal discounted;

        public Discount(DiscountType type, decimal quantity, decimal discounted)
        {
            this.quantity = quantity;
            this.discounted = discounted;
            this.type = type;
        }

        public decimal GetDiscount(decimal result, Discount discount)
        {
            decimal[] percent = { discounted / 100 };
            if (discount.type == DiscountType.Quantity && result >= quantity)
            {
                return quantity * (1 - percent[0]) + (result - quantity);
            }

            if (discount.type == DiscountType.TenPack && result >= discounted)
            {
                return result - quantity;
            }

            if (discount.type == DiscountType.PriceOff)
            {
                return result * (1 - percent[0]);
            }

            if (discount.type == DiscountType.Free && result >= quantity)
            {
                return result - discounted;
            }

            return result;
        }
    }
}