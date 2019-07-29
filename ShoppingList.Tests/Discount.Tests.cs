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
            var discount = new Discount();
            Product[] list = { new Product("mouse", 50, 5) };
            var actual = discount.TotalPrice(list);

            Assert.Equal(150, actual);
        }

        [Fact]
        public void WhenWeBuyProductsMoreThen100EuroMustReturn20ProcentageOff()
        {
            var product = new Product("", 0, 0);
            var discount = new Discount();
            Product[] list =
            {
                new Product("mouse", 100, 1),
                new Product("laptop", 1000, 1),
                new Product("laptop bag", 100, 1)
            };

            var actual = discount.TotalPrice(list);
            var actualPrice = discount.GetDiscountPerProduct(list[1]);

            Assert.Equal(960, actual);
            Assert.Equal(800, actualPrice);
        }

        [Fact]
        public void WhenWeTestOneProductReturnClass()
        {
            var discount1 = new Discount();

            var actual = discount1.ToString();

            Assert.Equal("Shopping.Discount", actual);
        }
    }
}