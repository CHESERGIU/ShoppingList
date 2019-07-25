using System;

namespace Shopping
{
    public class Discount
    {
        readonly Product product;

        public Discount(Product product)
        {
            this.product = product;
        }

        public double GetDiscount(Product[] list)
        {
            double result = 0;
            for (int i = 0; i < list.Length; i++)
            {
                result = GetSum(list[i].Price()) ?
                    ProcentageOff(result, list[i]) : GetQuantity() ?
                    TakeFivePayThree(result, list[i]) : TotalCost(result, list[i]);
            }

            return result;
        }

        double ProcentageOff(double result, Product item)
        {
            var twentyProcentageOff = item.Price() * 0.2;
            result += item.Price() - twentyProcentageOff;
            return result;
        }

        double TakeFivePayThree(double result, Product item)
        {
            var takeFivePayThree = item.Price() * 0.4;
            result += item.Price() - takeFivePayThree;
            return result;
        }

        double TotalCost(double result, Product item)
        {
            result += item.Price();
            return result;
        }

        bool GetQuantity()
        {
            const int Five = 5;
            return product.Quantity() == Five;
        }

        bool GetSum(double sum)
        {
            const int Hundred = 100;
            return sum > Hundred;
        }
    }
}