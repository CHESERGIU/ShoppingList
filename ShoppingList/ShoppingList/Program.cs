using System;

namespace Shopping
{
    public static class Program
    {
        public static void Main()
        {
            Product[] list = ReadList();
            Discount listOfProducts = new Discount(list[0], 0, 0);
            Console.WriteLine(list[0].GetTotalPrice(list, listOfProducts));
            Console.Read();
        }

        public static Product[] ReadList()
        {
            Product[] result = new Product[2];
            for (int i = 0; i < result.Length; i++)
            {
                string[] item = Console.ReadLine().Split(',');
                result[i] = new Product(item[0], Convert.ToDecimal(item[1]));
            }

            return result;
        }
    }
}