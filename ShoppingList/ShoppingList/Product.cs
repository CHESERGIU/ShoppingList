namespace Shopping
{
    public class Product
    {
        readonly string name;
        readonly double price;

        public Product(string nameOfProduct, double priceOfProduct)
        {
            this.name = nameOfProduct;
            this.price = priceOfProduct;
        }

        public override string ToString() => name;

        public double Price()
        {
            return price;
        }
    }
}