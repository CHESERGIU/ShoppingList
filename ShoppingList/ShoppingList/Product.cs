using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;
        readonly int quantity;

        public Product(string product, double prices, int quantity)
        {
            this.name = product;
            this.price = prices;
            this.quantity = quantity;
        }

        public double GetPrices(Product item) => item.price * item.quantity;

        public double GetQuantity(Product item) => item.quantity;

        public bool IsCostForDiscount(Product item)
        {
            const int discountCost = 100; // products price for discount
            return item.price >= discountCost;
        }

        public bool HasQuantityForDiscount(Product item)
        {
            int[] piecesForDiscount = { 5, 10 }; // products quantity for discount
            foreach (var piece in piecesForDiscount)
            {
                if (piece <= item.quantity)
                {
                    return true;
                }
            }

            return false;
        }

        public double ProcentageOff(Product item) => GetPrices(item) * (1 - ProcentageOff());

        public double ProcentageOff()
        {
            double[] procent = { 0.2 };
            return procent[0];
        }

        public double PayLessProducts(Product item) => GetPrices(item) * (1 - PayLessProducts());

        public double PayLessProducts()
        {
            double[] fractionalQuantity = { 0.4 };
            return fractionalQuantity[0];
        }

        public override string ToString() => name;
    }
}