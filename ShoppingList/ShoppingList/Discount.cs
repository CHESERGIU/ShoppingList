using System;

namespace Shopping
{
    public class Discount
    {
        readonly DiscountType discountType;
        readonly decimal quantity;
        readonly decimal percentage;

        public Discount(DiscountType discountType, decimal quantity, decimal percentage)
        {
            this.quantity = quantity;
            this.percentage = percentage;
            this.discountType = discountType;
        }

        public enum DiscountType
        {
            None,
            Quantity = 5,
            SixPack = 6
        }

        public decimal GetDiscount()
        {
            decimal[] discountQuantity = { quantity * percentage / 100, 2 };

            switch (discountType)
            {
                case DiscountType.Quantity:
                    return discountQuantity[0];
                case DiscountType.SixPack:
                    return discountQuantity[1];
                default:
                    return quantity;
            }
        }
    }
}