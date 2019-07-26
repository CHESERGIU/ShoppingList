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
                result = product.GetSum(list[i].Price()) ?
                    product.ProcentageOff(result, list[i]) : product.GetQuantity() ?
                    product.TakeFivePayThree(result, list[i]) : product.TotalCost(result, list[i]);
            }

            return result;
        }
    }
}