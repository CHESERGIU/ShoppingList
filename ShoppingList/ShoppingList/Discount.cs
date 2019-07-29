namespace Shopping
{
    public class Discount
    {
        private readonly double quantity;
        private readonly Product product;

        public Discount(Product product, double quantity)
        {
            this.quantity = quantity;
            this.product = product;
        }

        public double Price()
        {
            var sum = 0.0;
            sum += product.GetPrice(quantity);

            return sum;
        }
    }
}