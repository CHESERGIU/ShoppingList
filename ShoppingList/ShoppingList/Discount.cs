using System;

namespace Shopping
{
    public partial class Discount
    {
        readonly decimal discounted;
        readonly decimal quantity;
        readonly DiscountType type;

        public Discount(DiscountType type, decimal quantity, decimal discounted)
        {
            this.type = type;
            this.quantity = quantity;
            this.discounted = discounted;
        }

        public decimal Apply(decimal result, Discount discount)
        {
            decimal[] percent = { discounted / 100 };
            if (IsQuantity(discount) && result >= quantity)
            {
                return quantity * (1 - percent[0]) + (result - quantity);
            }

            if (IsTenPack(discount) && result >= discounted)
            {
                return result - quantity;
            }

            if (IsPriceOff(discount))
            {
                return result * (1 - percent[0]);
            }

            if (IsFree(discount) && result >= quantity)
            {
                return result - discounted;
            }

            return result;
        }
    }
}