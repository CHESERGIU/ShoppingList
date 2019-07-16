using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WhenWeBuyAMouseAndChoseCourierShipping()
        {
            var product = new Product[2];
            Basket shopping = new Basket();
            product[0] = new Product("mouse", 1 * 45);
            product[1] = new Product("laptop bag", 3 * 10);
            var mouse = new Discount(45, 1);
            var laptopbag = new Discount(10, 3);

            double actual = shopping.GetTotalPrice();
            Assert.Equal((double)75, actual);
        }
    }
}
