using System;

namespace Shopping
{
    public class Discount
    {
        readonly double quantity;
        readonly decimal percentage;
        readonly Product product;
        readonly Discount discount;

        public Discount(DiscountType discountType, double quantity, decimal percentage)
        {
            this.quantity = quantity;
            this.percentage = percentage;
            this.discount = new Discount(discountType, 0, 0);
            this.product = new Product("", 0, discount);
        }

        public enum DiscountType
        {
            None,
            Quantity = 5,
            Price = 100
        }

        public double GetDiscount()
        {
            if (product.IsDiscount(product, discount))
            {
                return product.GetPrice(quantity) * Percentage();
            }

            return product.GetPrice(quantity);
        }

        private double Percentage()
        {
            var percent = percentage / 100;
            return Convert.ToDouble(percent);
        }
    }
}