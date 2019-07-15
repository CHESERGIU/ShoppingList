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

            var mouse = new Discount(product[0], 45, 1);
            var laptopbag = new Discount(product[1], 10, 3);

            decimal actual = mouse.GetDiscounts(45, mouse) + laptopbag.GetDiscounts(30, laptopbag);
            Assert.Equal((decimal)75, actual);
        }
    }
}