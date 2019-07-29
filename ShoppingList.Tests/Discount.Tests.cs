using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class DiscountTests
    {
        [Fact]
        public void WhenWeBuy5ProductMustReturnOfferTake5AndPay3()
        {
            Product[] list = { new Product("mouse", 50, 5) };
            var discount = new Discount(list);
            var actual = discount.TotalPrice();

            Assert.Equal(250, actual);
        }

        [Fact]
        public void WhenWeBuyProductsMoreThen100EuroMustReturn20ProcentageOff()
        {
            var product = new Product("", 0, 0);
            Product[] list =
            {
                new Product("mouse", 100, 1),
                new Product("laptop", 1000, 1),
                new Product("laptop bag", 100, 1)
            };
            var discount = new Discount(list);

            var actual = discount.TotalPrice();

            Assert.Equal(1200, actual);
        }

        [Fact]
        public void WhenWeTestOneProductReturnClass()
        {
            Product[] list = null;
            var discount1 = new Discount(list);

            var actual = discount1.ToString();

            Assert.Equal("Shopping.Discount", actual);
        }
    }
}