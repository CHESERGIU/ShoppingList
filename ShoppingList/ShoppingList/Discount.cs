using System;

namespace Shopping
{
    public class Discount
    {
        readonly double price;
        readonly int quantity;
        readonly Number offer;

        public Discount(double price, int quantity)
        {
            this.offer = new Number();
            this.price = price;
            this.quantity = quantity;
        }

        public double GetDiscounts()
        {
            switch (price)
            {
                case 0:
                    {
                        return GetPrices();
                    }

                case 1:
                    {
                        return GetQuantity();
                    }

                default:
                    {
                        return 0;
                    }
            }
        }

        public double GetPrices()
        {
            if (price >= offer.FivePiece && price < offer.HundredPiece)
            {
                return Price() - offer.TenPiece * Price();
            }
            else if (price >= offer.HundredPiece)
            {
                return Price() - offer.TwentyProcentOff * Price();
            }
            else
            {
                return price;
            }
        }

        public double GetQuantity()
        {
            if (quantity > offer.FivePiece && quantity < offer.TenPiece)
            {
                return Price() - offer.ThirdProcentOff * Price();
            }
            else if (quantity >= offer.TenPiece)
            {
                return Price() - offer.SixtyProcentOff * Price();
            }
            else
            {
                return price;
            }
        }

        public double Price()
        {
            if (quantity > 1)
            {
                return price * quantity;
            }

            return price;
        }
    }
}