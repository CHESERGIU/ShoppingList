using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WhenWeBuyAMouseAndChoseCurierShipping()
        {
            var product = new Program.Product[2];         

            product[0].name = "mouse";
            product[0].price = 1 * 45;
            product[0].discounts = (Program.Discount)1;
            product[1].name = "laptop bag";
            product[1].price = 3 * 10;
            product[1].discounts = (Program.Discount)3;

            decimal actual = Program.GetTotalPrice(product);
            Assert.Equal((decimal) 55.5, actual);

        }
    }
}
