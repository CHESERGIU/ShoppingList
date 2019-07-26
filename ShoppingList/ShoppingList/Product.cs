using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;
        readonly int quantity;
        readonly Product product;

        public Product(string product, double prices, int quantity)
        {
            this.name = product;
            this.price = prices;
            this.quantity = quantity;
        }

        public Product(Product product)
        {
            this.product = product;
        }

        public double Price()
        {
            return product.price * product.quantity;
        }

        public int Quantity()
        {
            return product.quantity;
        }

        public double ProcentageOff(double result, Product item)
        {
            var twentyProcentageOff = item.Price() * 0.2;
            result += item.Price() - twentyProcentageOff;
            return result;
        }

        public double TakeFivePayThree(double result, Product item)
        {
            var takeFivePayThree = item.Price() * 0.4;
            result += item.Price() - takeFivePayThree;
            return result;
        }

        public double TotalCost(double result, Product item)
        {
            result += item.Price();
            return result;
        }

        public bool GetQuantity()
        {
            const int Five = 5;
            return product.Quantity() == Five;
        }

        public bool GetSum(double sum)
        {
            const int Hundred = 100;
            return sum > Hundred;
        }

        public override string ToString() => name;
    }
}