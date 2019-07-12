using System;

namespace Shopping
{
    public class Discount
    {
        public enum DiscountType
        {
            none,
            percentageOff, // ("10% off all items", discount 0.10m);
            spendXGetY, // ("Spend less lei and get 3 of a kind", discount 20%);
            buyXGetY, // ("Buy 2 get 1 free", discount 33%)
            buyXSpendY // (Buy 5 at a price of 10 lei, or buy 10 at a price of 100 lei, discount 66%)
        }

        public static decimal GetDiscounts(decimal price, DiscountType discounts)
        {
            switch (discounts)
            {
                case DiscountType.percentageOff:
                    {
                        return price * (decimal)0.90;
                    }

                case DiscountType.spendXGetY:
                    {
                        return price * (decimal)0.80;
                    }

                case DiscountType.buyXGetY:
                    {
                        return price * (decimal)0.66;
                    }

                case DiscountType.buyXSpendY:
                    {
                        return price * (decimal)0.33;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

    }

}