using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class BasketTests
    {
        [Fact]
        public void BuyAndPayForMultipleProductsDiscountPriceOff()
        {
            // Given
            var discount = new Discount(Discount.DiscountType.None, 0, 0);
            var discount1 = new Discount(Discount.DiscountType.PriceOff, 100, 10);
            var discount2 = new Discount(Discount.DiscountType.Quantity, 100, 20);
            var discount3 = new Discount(Discount.DiscountType.TenPack, 10, 50);
            var discount4 = new Discount(Discount.DiscountType.Free, 10, 10);
            var onion = new Product("onion", (decimal)1, discount4);
            Product[] list = { onion };

            // When
            var shopping = new Basket();
            shopping.Buy(onion, 100); // 100kg
            var actual = shopping.Pay(Discount.DiscountType.None);
            var actual1 = shopping.Pay(Discount.DiscountType.PriceOff);
            var actual2 = shopping.Pay(Discount.DiscountType.Quantity);
            var actual3 = shopping.Pay(Discount.DiscountType.TenPack);
            var actual4 = shopping.Pay(Discount.DiscountType.Free);
            Assert.Equal(90, actual4);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsWithoutDiscount()
        {
            // Given
            var discount = new Discount(Discount.DiscountType.None, 0, 0);
            var onion = new Product("onion", (decimal)10, discount);
            Product[] list = { onion };

            // When
            var shopping = new Basket();
            shopping.Buy(onion, 10);
            var actual = shopping.Pay(Discount.DiscountType.None);

            Assert.Equal(100, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsWithDiscountQuantity()
        {
            // Given
            var discount = new Discount(Discount.DiscountType.Quantity, 10, 20);

            var onion = new Product("onion", 1, discount);
            var cherry = new Product("cherry", 1, discount);
            var cocaCola = new Product("cocaCola", 1, discount);
            var beer = new Product("beer", 1, discount);
            var wine = new Product("wine", 1, discount);
            Product[] list = { onion };

            // When
            var shopping = new Basket();
            shopping.Buy(onion, 20);
            var actual = shopping.Pay(Discount.DiscountType.Quantity);
            Assert.Equal(18, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProductsWithTenPackQuantity()
        {
            // Given
            var discount = new Discount(Discount.DiscountType.TenPack, 0, 0);

            var onion = new Product("onion", 1, discount);
            var cherry = new Product("cherry", 2, discount);
            var cocaCola = new Product("cocaCola", 3, discount);
            var beer = new Product("beer", 4, discount);
            var wine = new Product("wine", 5, discount);
            Product[] list = { onion, cherry, cocaCola, beer, wine };

            // When
            var shopping = new Basket();

            shopping.Buy(onion, 1);
            shopping.Buy(cherry, 1);
            shopping.Buy(cocaCola, 1);
            shopping.Buy(beer, 1);
            shopping.Buy(wine, 1);

            var actual = shopping.Pay(Discount.DiscountType.TenPack);

            Assert.Equal(15, actual);
        }
    }
}
