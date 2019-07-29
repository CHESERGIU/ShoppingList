namespace Shopping
{
    public class Discount
    {
        public double TotalPrice(Product[] list)
        {
            double result = 0;
            foreach (var item in list)
            {
                result += GetDiscountPerProduct(item);
            }

            return result;
        }

        public double GetDiscountPerProduct(Product item)
        {
            if (item.IsCostForDiscount(item))
            {
                return item.ProcentageOff(item);
            }

            if (item.HasQuantityForDiscount(item))
            {
                return item.PayLessProducts(item);
            }

            return item.GetPrices(item);
        }
    }
}