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

            Product[] list = { mouse, laptop };
            var actual = mouse.GetPrices(list);
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
            Product[] list = { laptop };
            var price = laptop.GetPrices(list);

            Assert.Equal(11000, price);
        }
    }
}