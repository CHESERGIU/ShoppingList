using System;

namespace Shopping
{
    public static class Program
    {
        public static void Main()
        {
            Product[] list = ReadList();
            Console.WriteLine(Product.GetTotalPrice(list));
            Console.Read();
        }

        public static Product[] ReadList()
        {            
            Product[] result = new Product[2];
            for (int i = 0; i < result.Length; i++)
            {
                string[] item = Console.ReadLine().Split(',');
                result[i] = new Product(item[0], Convert.ToDecimal(item[1]), (Discount.DiscountType)Convert.ToInt32(item[2]));
            }
            return result;
        }
    }
}