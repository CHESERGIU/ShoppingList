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

            var shopping = new Basket();

            product[0] = new Product("mouse", 100, 1);
            product[1] = new Product("laptop bag", 100, 1);

            Product[] list = { product[0], product[1] };

            var mouse = product[0];
            var laptop = product[1];

            shopping.Buy(mouse);
            shopping.Buy(laptop);
            var actual = shopping.Pay();
            Assert.Equal(160, actual);
        }
    }
}
