using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class BasketTests
    {
        [Fact]
        public void BuyAndPayForMultipleProducts()
        {
            // Given
            var shopping = new Basket();
            var onion = new Product(new Product("onion", 100, 1));
            var cherry = new Product(new Product("cherry", 100, 1));
            var cocaCola = new Product(new Product("cocaCola", 100, 1));
            var beer = new Product(new Product("beer", 200, 1));
            var wine = new Product(new Product("wine", 100, 1));
            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            // When
            var actual = shopping.Pay();

            // Then
            Assert.Equal((double)560, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsOffer()
        {
            // Given
            var jhonny = new Basket();
            var onion = new Product("onion", 100, 5);
            var cherry = new Product("cherry", 100, 5);
            var cocaCola = new Product("cocaCola", 100, 5);
            Product[] list = { onion, cherry, cocaCola };
            var shopOnion = new Product(onion);
            var shopCherry = new Product(cherry);
            var shopCocaCola = new Product(cocaCola);

            // Offer
            var percentageOff = new Discount(new Product(new Product("", 0, 0)));

            jhonny.Buy(shopOnion);
            jhonny.Buy(shopCherry);
            jhonny.Buy(shopCocaCola);

            // When
            var actual = jhonny.Pay();

            // Then
            Assert.Equal((double)1200, actual);
        }
    }
}
