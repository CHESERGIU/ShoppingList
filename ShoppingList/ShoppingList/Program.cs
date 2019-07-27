using System;

namespace Shopping
{
    public static class Program
    {
        public static void Main()
        {
            var list = new Product[5];

            var onion = new Product("onion", 1, 0);
            var cherry = new Product("cherry", 1, 0);
            var cocaCola = new Product("cocaCola", 1, 0);
            var beer = new Product("beer", 1, 0);
            var wine = new Product("wine", 1, 1);

            var shopping = new Basket();

            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);
            Console.WriteLine(shopping.Pay());
            Console.Read();
        }
    }
}