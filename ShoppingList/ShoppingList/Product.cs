using System;

namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly decimal price;
        readonly Discount.DiscountType discounts;

        public Product(string name, decimal price, Discount.DiscountType discounts)
        {
            this.name = name;
            this.price = price;
            this.discounts = discounts;
        }

        public static decimal GetTotalPrice(Product[] list)
        {
            decimal result = 0;

            for (int i = 0; i < list.Length; i++)
                result += Discount.GetDiscounts(list[i].price, list[i].discounts);
            return result;
        }       
    }


}