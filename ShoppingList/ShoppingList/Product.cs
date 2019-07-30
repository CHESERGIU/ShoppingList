namespace Shopping
{
    public class Product
    {
        readonly Discount discount;
        readonly string name;
        readonly double price;

        public Product(string name, double price, Discount discount)
        {
            this.name = name;
            this.price = price;
            this.discount = discount;
        }

        public double GetPrice(double quantity)
        {
            return price * quantity;
        }

        public bool IsDiscount(Product product, Discount discount)
        {
            return product.discount == discount;
        }

        public override string ToString()
        {
            return name;
        }
    }
}