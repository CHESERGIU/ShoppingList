using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProductTests
    {
        [Fact]
        public void TestClassForMethodsOfPriceAndQuantity()
        {
            var laptop = new Product("laptop", 2200, 1);
            var mouse = new Product("mouse", 200, 1);

            // Object reference
            var shoping1 = new Product(laptop);
            var shoping2 = new Product(mouse);

            var actual = shoping1.Price() + shoping2.Price();
            var pieces = shoping1.Quantity();

            Assert.Equal(1, pieces);
            Assert.Equal(2400, actual);
        }

        [Fact]
        public void TestClassForName()
        {
            var laptop = new Product("laptop", 2200, 1);
            const string actual = nameof(laptop);

            Assert.Equal(laptop.ToString(), actual);
        }

        [Fact]
        public void TestWhenHave5ProductReturnTotalPriceNoDiscount()
        {
            var laptop = new Product("laptop", 2200, 5);

            // Object reference
            var shoping1 = new Product(laptop);

            var price = shoping1.Price();
            var quantity = shoping1.Quantity();

            Assert.Equal(11000, price);
            Assert.Equal(5, quantity);
        }
    }
}