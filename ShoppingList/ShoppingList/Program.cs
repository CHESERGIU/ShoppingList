using System;

namespace Shopping
{
    public static class Program
    {
        public struct Product
        {
            public string name;
            public decimal price;
            public Discount discounts;

            public Product(string name, decimal price, Discount discounts)
            {
                this.name = name;
                this.price = price;
                this.discounts = discounts;
            }
        }

        public enum Discount
        {
            none,
            percentageOff, // ("10% off all items", discount 0.10m);
            spendXgetY, // ("Spend less lei and get 3 of a kind", discount 20%);
            buyXGetY // ("Buy 2 get 1 free", discount 33%)
        }

        public static void Main()
        {
            Product[] list = ReadList();
            Console.WriteLine(GetTotalPrice(list));
            Console.Read();
        }

        public static decimal GetTotalPrice(Product[] list)
        {
            decimal result = 0;
            
            for (int i = 0; i < list.Length; i++)
                result += GetDiscounts(list[i].price, list[i].discounts);
            return result;
        }

        public static decimal GetDiscounts(decimal price, Discount discounts)
        {
            if (discounts == Discount.percentageOff)
            {
                return price * (decimal) 0.90;
            }
            if (discounts == Discount.spendXgetY)
            {
                return price * (decimal) 0.70;
            }
            if (discounts == Discount.buyXGetY)
            {
                return price * (decimal) 0.50;
            }

            return 0;
        }

        public static Product[] ReadList()
        {            
            Product[] result = new Product[2];
            for (int i = 0; i < result.Length; i++)
            {
                string[] item = Console.ReadLine().Split(',');
                result[i] = new Product(item[0], Convert.ToDecimal(item[1]), (Discount)Convert.ToInt32(item[2]));
            }
            return result;
        }
    }
}