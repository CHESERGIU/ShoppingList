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

            product[0] = new Product("mouse", 1 * 45, (Discount.DiscountType)1);
            product[1] = new Product("laptop bag", 3 * 10, (Discount.DiscountType)3);

            decimal actual = Product.GetTotalPrice(product);
            Assert.Equal((decimal) 60.30, actual);

        }
    }
}
