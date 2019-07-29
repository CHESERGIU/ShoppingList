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
            var product = new Product("laptop", 2200, 5);

            Assert.Equal("laptop", product.ToString());
            Assert.Equal(11000, product.GetPrices(product));
            Assert.True(product.IsCostForDiscount(product));
            Assert.Equal(6600, product.PayLessProducts(product));
            Assert.True(product.HasQuantityForDiscount(product));
            Assert.Equal(8800, product.ProcentageOff(product));
            Assert.Equal(5, product.GetQuantity(product));
        }

        [Fact]
        public void CanCreateProductWithValuesToTestClass()
        {
            var product = new Product("mouse", 25, 10);

            Assert.Equal("mouse", product.ToString());
            Assert.Equal(250, product.GetPrices(product));
            Assert.False(product.IsCostForDiscount(product));
            Assert.Equal(150, product.PayLessProducts(product));
            Assert.True(product.HasQuantityForDiscount(product));
            Assert.Equal(200, product.ProcentageOff(product));
            Assert.Equal(10, product.GetQuantity(product));
        }
    }
}