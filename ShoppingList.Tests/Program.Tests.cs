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
            var shoppingList = new Program.Product[1];
            shoppingList[0].name = "mouse";
            shoppingList[0].price = 45;
            var shippingMethod = (Program.ShippingType)1;
            decimal actual = Program.GetTotalPrice(shoppingList, shippingMethod);
            Assert.Equal(90, actual);

        }
    }
}
