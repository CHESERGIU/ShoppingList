using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class BasketTests
    {
        [Fact]
        public void BuyAndPayForMultipleProductsWithoutDiscount()
        {
            // Given
            var discount0 = new Discount(Discount.DiscountType.None, 0, 0);

            var onion = new Product("onion", 1, discount0);
            var cherry = new Product("cherry", 2, discount0);
            var cocaCola = new Product("cocaCola", 3, discount0);
            var beer = new Product("beer", 4, discount0);
            var wine = new Product("wine", 5, discount0);
            Product[] list = { onion, cherry, cocaCola, beer, wine };

            // When
            var shopping = new Basket();

            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            var actual = shopping.Pay(5);
            Assert.Equal(75, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsWithDiscountQuantity()
        {
            // Given
            var discount1 = new Discount(Discount.DiscountType.Quantity, 5, 20);

            var onion = new Product("onion", 1, discount1);
            var cherry = new Product("cherry", 2, discount1);
            var cocaCola = new Product("cocaCola", 3, discount1);
            var beer = new Product("beer", 4, discount1);
            var wine = new Product("wine", 5, discount1);
            Product[] list = { onion, cherry, cocaCola, beer, wine };

            // When
            var shopping = new Basket();

            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            var actual = shopping.Pay(5);
            Assert.Equal(60, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsWithSixPackQuantity()
        {
            // Given
            var discount2 = new Discount(Discount.DiscountType.SixPack, 0, 0);

            var onion = new Product("onion", 1, discount2);
            var cherry = new Product("cherry", 2, discount2);
            var cocaCola = new Product("cocaCola", 3, discount2);
            var beer = new Product("beer", 4, discount2);
            var wine = new Product("wine", 5, discount2);
            Product[] list = { onion, cherry, cocaCola, beer, wine };

            // When
            var shopping = new Basket();

            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            var actual = shopping.Pay(6);
            Assert.Equal(60, actual);
        }
    }
}
