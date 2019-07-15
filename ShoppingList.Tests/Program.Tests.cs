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

            product[0] = new Product("mouse", 1 * 45);
            product[1] = new Product("laptop bag", 3 * 10);
            var mouse = new Discount(product[0], 45, 1);
            var laptopbag = new Discount(product[1], 10, 3);

            decimal actual = (product[0].GetTotalPrice(product, mouse) + product[1].GetTotalPrice(product, laptopbag)) / 2;
            Assert.Equal((decimal)75, actual);
        }
    }
}
