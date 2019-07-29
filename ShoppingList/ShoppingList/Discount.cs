namespace Shopping
{
    public class Discount
    {
        readonly Product[] list;

        public Discount(Product[] list)
        {
            this.list = list;
        }

        public double TotalPrice()
        {
            var sum = 0.0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i].GetPrices(list[i]);
            }

            return sum;
        }
    }
}