using System;

namespace Shopping
{
    public static class Program
    {
        public struct Product
        {
            public string name;
            public decimal price;

            public Product(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }
        }

        public enum ShippingType
        {
            warehouse,
            courier,
            priority
        }

        public static void Main()
        {
            Product[] shoppingList = ReadShoppingList();
            ShippingType shippingMethod = (ShippingType)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetTotalPrice(shoppingList, shippingMethod));
            Console.Read();
        }

        public static decimal GetTotalPrice(Product[] shoppingList, ShippingType shippingMethod)
        {
            decimal result = 0;
            for (int i = 0; i < shoppingList.Length; i++)
                result += shoppingList[i].price;

            result += GetShippingPrice(result, shippingMethod);
            return result;
        }

        public static decimal GetShippingPrice(decimal result, ShippingType shippingMethod)
        {
            if (shippingMethod == ShippingType.courier && result <= 150)
            {
                return 45;
            }
            if (shippingMethod == ShippingType.priority && result <= 450)
            {
                return 90;
            }

            return 0;
        }

        public static Product[] ReadShoppingList()
        {
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());
            Product[] result = new Product[numberOfProducts];
            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] item = Console.ReadLine().Split(':');
                result[i] = new Product(item[0], Convert.ToDecimal(item[1]));
            }
            return result;
        }
    }
}