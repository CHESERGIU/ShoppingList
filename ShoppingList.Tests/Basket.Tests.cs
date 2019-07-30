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
            const Discount.DiscountType discountType1 = (Discount.DiscountType)5;
            const Discount.DiscountType discountType2 = (Discount.DiscountType)100;
            var discount1 = new Discount(discountType1, 5, 5);
            var discount2 = new Discount(discountType2, 10, 10);

            var onion = new Product("onion", 3, discount1);
            var cherry = new Product("cherry", 8, discount1);
            var cocaCola = new Product("cocaCola", 4, discount2);
            var beer = new Product("beer", 4, discount2);
            var wine = new Product("wine", 15, discount1);
            Product[] list = { onion, cherry, cocaCola, beer, wine };
            var shopping = new Basket();
            shopping.Buy(onion);
            shopping.Buy(cherry);
            shopping.Buy(cocaCola);
            shopping.Buy(beer);
            shopping.Buy(wine);

            // When
            var actual1 = onion.GetPrice(6); // 3*6=18
            var actual2 = cherry.GetPrice(6); // 8*6=48
            var actual3 = cocaCola.GetPrice(6); // 4*6=24
            var actual4 = beer.GetPrice(6); // 4*6=24
            var actual5 = wine.GetPrice(6); // 15*6=90
            var actual = actual1 + actual2 + actual3 + actual4 + actual5; // total=204

            // Then
            Assert.Equal((double)204, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsOffer()
        {
            // Given
            const Discount.DiscountType discountType1 = (Discount.DiscountType)5;
            const Discount.DiscountType discountType2 = (Discount.DiscountType)100;
            var discount1 = new Discount(discountType1, 5, 5);
            var discount2 = new Discount(discountType2, 10, 10);

            var onion = new Product("onion", 3, discount1);
            var cherry = new Product("cherry", 8, discount1);
            var cocaCola = new Product("cocaCola", 4, discount2);
            Product[] list = { onion, cherry, cocaCola };
            var jhonny = new Basket();

            // Offer
            jhonny.Buy(onion);
            jhonny.Buy(cherry);
            jhonny.Buy(cocaCola);

            // When
            var actual1 = onion.GetPrice(11); // 3*11=33
            var actual2 = cherry.GetPrice(11); // 8*11=88
            var actual3 = cocaCola.GetPrice(11); // 4*11=44
            var actual = actual1 + actual2 + actual3; // total=165

            // Then
            Assert.Equal((double)165, actual);
        }
    }
}
