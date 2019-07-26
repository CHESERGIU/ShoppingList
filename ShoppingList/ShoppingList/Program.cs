using System;

namespace Shopping
{
    public static class Program
    {
        public static void Main()
        {
            var list = new Product[5];

            var onion = new Product(new Product("onion", 100, 1));
            var cherry = new Product(new Product("cherry", 100, 1));
            var cocaCola = new Product(new Product("cocaCola", 100, 1));
            var beer = new Product(new Product("beer", 200, 1));
            var wine = new Product(new Product("wine", 100, 1));

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