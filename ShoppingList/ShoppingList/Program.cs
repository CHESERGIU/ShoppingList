using System;

namespace Shopping
{
    public static class Program
    {
        public static void Main()
        {
            var number = new Number();
            Product[] list = ReadList();
            Basket shopping = new Basket();
            shopping.Buy(new Product("beer", number.HundredPiece));
            Console.WriteLine(shopping.GetTotalPrice());
            Console.Read();
        }

        public static Product[] ReadList()
        {
            Product[] result = new Product[2];
            for (int i = 0; i < result.Length; i++)
            {
                string[] item = Console.ReadLine().Split(',');
                result[i] = new Product(item[0], Convert.ToDouble(item[1]));
            }

            return result;
        }
    }
}