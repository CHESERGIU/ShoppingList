namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly decimal price;

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public decimal GetTotalPrice(Product[] list, Discount listOfProducts)
        {
            decimal result = 0;
            if (list == null || list.Length == 0)
            {
                return 0m;
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (listOfProducts == null)
                {
                    return 0m;
                }

                result += listOfProducts.GetDiscounts(price, listOfProducts);
            }

            return result;
        }

        public override string ToString() => name;

        public decimal ToDecimal()
        {
            return price;
        }
    }
}