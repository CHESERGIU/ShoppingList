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
            product[0] = new Product("mouse", 45, 1);
            product[1] = new Product("laptop bag", 10, 1);
            Product[] list = { product[0], product[1] };
            var discount = new Discount(list);

            var actual = discount.GetDiscount(list);
            Assert.Equal((double)55, actual);
        }
    }
}