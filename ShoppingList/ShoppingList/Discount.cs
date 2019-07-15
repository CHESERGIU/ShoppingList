using System;

namespace Shopping
{
    public class Discount
    {
        const decimal Discount10 = 0.1m;
        const decimal Discount20 = 0.2m;
        const decimal Discount33 = 0.33m;
        const decimal Discount66 = 0.66m;
        const decimal PercentageOff = 50;
        readonly decimal buyXGetY = 100;
        readonly decimal buyXSpendY = 500;
        readonly decimal spendXGetY = 1000;
        readonly decimal pricePrice;
        readonly int quantity;
        readonly Product product;

        public Discount(Product product, decimal price, int quantity)
        {
            this.product = product;
            this.pricePrice = price;
            this.quantity = quantity;
        }

        public decimal GetDiscounts(decimal price, Discount listOfProducts)
        {
            if (listOfProducts == null)
            {
                return pricePrice;
            }

            if (price == PercentageOff)
            {
                return SubTotal(price) - (Discount10 * SubTotal(price));
            }
            else if (price == spendXGetY)
            {
                return SubTotal(price) - (Discount20 * SubTotal(price));
            }
            else if (price == buyXGetY)
            {
                return SubTotal(price) - (Discount33 * SubTotal(price));
            }
            else if (price == buyXSpendY)
            {
                return SubTotal(price) - (Discount66 * SubTotal(price));
            }
            else
            {
                return price;
            }
        }

        public decimal SubTotal(decimal price)
        {
            if (product == null)
            {
                return 0;
            }

            if (quantity > 1)
            {
                return price * quantity;
            }

            return price;
        }
    }
}