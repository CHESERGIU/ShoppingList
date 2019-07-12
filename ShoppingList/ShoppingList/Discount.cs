using System;

namespace Shopping
{
    public class Discount
    {
        const int Discount10 = 10;
        const int Discount20 = 20;
        const int Discount33 = 33;
        const int Discount66 = 66;

        public enum DiscountType
        {
            None,
            PercentageOff,
            SpendXGetY,
            BuyXGetY,
            BuyXSpendY
        }

        public static decimal GetDiscounts(decimal price, DiscountType discounts)
        {
            switch (discounts)
            {
                case DiscountType.PercentageOff:
                    {
                        return price - (Discount10 % price);
                    }

                case DiscountType.SpendXGetY:
                    {
                        return price - (Discount20 % price);
                    }

                case DiscountType.BuyXGetY:
                    {
                        return price - (Discount33 % price);
                    }

                case DiscountType.BuyXSpendY:
                    {
                        return price - (Discount66 % price);
                    }

                default:
                    {
                        return 0;
                    }
            }
        }
    }
}