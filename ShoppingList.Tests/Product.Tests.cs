using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanCreateProductWithValuesToTest()
        {
            var product = new Product("laptop", 2200);
            const int quantity = 5;
            Assert.Equal("laptop", product.ToString());
            Assert.Equal(11000, product.GetPrice(quantity));
        }

        [Fact]
        public void CanCreateProductWithValuesToTestClass()
        {
            var product = new Product("mouse", 25);
            const int quantity = 10;
            Assert.Equal("mouse", product.ToString());
            Assert.Equal(250, product.GetPrice(quantity));
        }
    }
}