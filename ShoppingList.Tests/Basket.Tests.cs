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
            var onion = new Product("onion", 100, 1);
            var cherry = new Product("cherry", 100, 1);
            var cocaCola = new Product("cocaCola", 100, 1);
            var beer = new Product("beer", 200, 1);
            var wine = new Product("wine", 100, 1);
            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            // When
            var actual = shopping.Pay();

            // Then
            Assert.Equal((double)360, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsOffer()
        {
            // Given
            var jhonny = new Basket();
            var onion = new Product("onion", 100, 1);
            var cherry = new Product("cherry", 100, 1);
            var cocaCola = new Product("cocaCola", 100, 1);
            Product[] list = { onion, cherry, cocaCola };

            // Offer
            jhonny.Buy(onion);
            jhonny.Buy(cherry);
            jhonny.Buy(cocaCola);

            // When
            var actual = jhonny.Pay();

            // Then
            Assert.Equal((double)240, actual);
        }
    }
}
