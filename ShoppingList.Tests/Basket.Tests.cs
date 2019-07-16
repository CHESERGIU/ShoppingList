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
            Basket shopping = new Basket();
            var onion = new Product("onion", 10);
            var cherry = new Product("cherry", 10);
            var cocaCola = new Product("cocaCola", 10);
            var beer = new Product("beer", 10);
            var wine = new Product("wine", 10);
            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            // When
            var actual = shopping.Pay();

            // Then
            Assert.Equal((double)50, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsOffer()
        {
            // Given
            Basket adele = new Basket();
            var onion = new Product("onion", 50);
            var cherry = new Product("cherry", 50);
            var cocaCola = new Product("cocaCola", 100);
            var beer = new Product("beer", 1000);
            var wine = new Product("wine", 100);

            // Offer
            var onionPercentageOff = new Discount(50, 10); // spend 50 lei and get 10% off price
            var cherryPercentageOff = new Discount(50, 5); // spend 50 lei and get 10% off price
            var buyXGetY = new Discount(100, 2); // buy 100 lei product and have 20% off price
            var buyXSpendY = new Discount(100, 100); // buy 100 bottle and spend less cash
            var spendXGetY = new Discount(100, 1000); // buy 1000 bottle and get best discount

            adele.Buy(onion);
            adele.Buy(cherry);
            adele.Buy(cocaCola);
            adele.Buy(beer);
            adele.Buy(wine);

            // When
            var actual = adele.Pay();

            // Then
            Assert.Equal((double)225, actual);
        }
    }
}
