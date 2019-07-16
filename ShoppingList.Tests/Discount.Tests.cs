using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class DiscountTests
    {
        [Fact]
        public void WhenWeBuyWithAndWithoutDiscounts()
        {
            var product = new Product[2];

            var mouse = new Discount(45, 1);
            var laptopbag = new Discount(10, 3);

            double actual = mouse.GetDiscounts() + laptopbag.GetDiscounts();
            Assert.Equal((double)75, actual);
        }
    }
}