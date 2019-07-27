using System;

namespace Shopping
{
    public class Discount
    {
        public double GetDiscount(double price, double quantity)
        {
            const int Hundred = 100;
            const int Five = 5;
            if (price >= Hundred && quantity < Five)
            {
                return ProcentageOff(price);
            }
            else if (quantity >= Five)
            {
                return TakeFivePayThree(price);
            }
            else
            {
                return price;
            }
        }

        double ProcentageOff(double price)
        {
            var twentyProcentageOff = price * 0.2;
            return price - twentyProcentageOff;
        }

        double TakeFivePayThree(double price)
        {
            var takeFivePayThree = price * 0.4;
            return price - takeFivePayThree;
        }
    }
}