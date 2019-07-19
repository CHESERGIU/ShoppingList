using System;

namespace Shopping
{
    public class Discount
    {
        const int Five = 5;
        const int Hundred = 99;
        readonly Product[] list;
        double result;
        double sum;
        int quantity;

        public Discount(Product[] list)
        {
            this.list = list;
        }

        public double GetDiscount(Product[] list)
        {
            TotalPrice(list, ref sum, ref quantity);
            result = SpendXGetY(list, result, sum, quantity, Five, Hundred);
            return result;
        }

        public void TotalPrice(Product[] list, ref double sum, ref int quantity)
        {
            foreach (var product in list)
            {
                sum += product.Price() * product.Quantity();
                quantity += product.Quantity();
            }
        }

        public double BuyXPayLess(Product[] products, double result, int quantity, int f = 5) =>
            quantity >= f ? PayLessForMore(products, result) : GetPrice(products, result);

        public double SpendXGetY(Product[] products, double result, double sum, int quantity, int f, int h = 99)
        {
            return sum > h ? ProcentageOff(products, result) : quantity >= f ?
                BuyXPayLess(list, result, quantity, f) : GetPrice(products, result);
        }

        public double GetPrice(Product[] products, double result)
        {
            foreach (var product in products)
            {
                result += product.Price() * product.Quantity();
            }

            return result;
        }

        public double PayLessForMore(Product[] products, double result)
        {
            foreach (var product in products)
            {
                var twentyOff = product.Price() * product.Quantity() * 0.5;
                result += product.Price() * product.Quantity() - twentyOff;
            }

            return result;
        }

        public double ProcentageOff(Product[] products, double result)
        {
            foreach (var product in products)
            {
                var twentyOff = product.Price() * product.Quantity() * 0.2;
                result += product.Price() * product.Quantity() - twentyOff;
            }

            return result;
        }
    }
}