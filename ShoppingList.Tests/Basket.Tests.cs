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
            var onion = new Product("onion", 100);
            var cherry = new Product("cherry", 100);
            var cocaCola = new Product("cocaCola", 100);
            var beer = new Product("beer", 100);
            var wine = new Product("wine", 100);
            Product[] list = { onion, cherry, cocaCola, beer, wine };
            var shopping = new Basket();
            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);
            var discount1 = new Discount(onion, 1);
            var discount2 = new Discount(cherry, 1);
            var discount3 = new Discount(cocaCola, 1);
            var discount4 = new Discount(beer, 1);
            var discount5 = new Discount(wine, 1);
            discount1.Price();

            // When
            var actual = discount1.Price() +
                discount2.Price() +
                discount3.Price() +
                discount4.Price() +
                discount5.Price();

            // Then
            Assert.Equal((double)500, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsOffer()
        {
            // Given
            var onion = new Product("onion", 100);
            var cherry = new Product("cherry", 100);
            var cocaCola = new Product("cocaCola", 100);
            Product[] list = { onion, cherry, cocaCola };
            var jhonny = new Basket();

            // Offer
            jhonny.Buy(onion);
            jhonny.Buy(cherry);
            jhonny.Buy(cocaCola);
            var discount1 = new Discount(onion, 1);
            var discount2 = new Discount(cherry, 1);
            var discount3 = new Discount(cocaCola, 1);

            // When
            var actual = discount1.Price() +
                discount2.Price() +
                discount3.Price();

            // Then
            Assert.Equal((double)300, actual);
        }
    }
}
