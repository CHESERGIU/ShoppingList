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
            var discount = new Discount(new Product(new Product("mouse", 20, 5)));
            Product[] list = { new Product(new Product("mouse", 20, 5)) };
            var actual = discount.GetDiscount(list);

            Assert.Equal((double)60, actual);
        }

        [Fact]
        public void WhenWeBuyProductsMoreThen100EuroMustReturn20ProcentageOff()
        {
            var discount1 = new Discount(new Product(new Product("mouse", 20, 1)));
            var discount2 = new Discount(new Product(new Product("laptop", 2200, 1)));
            var discount3 = new Discount(new Product(new Product("laptop bag", 80, 1)));

            Product[] list =
            {
                new Product(new Product("mouse", 20, 1)),
                new Product(new Product("laptop", 2200, 1)),
                new Product(new Product("laptop bag", 80, 1))
            };
            var actual = discount1.GetDiscount(list);

            Assert.Equal((double)1860, actual);
        }

        [Fact]
        public void WhenWeTestOneProductReturnClass()
        {
            var discount1 = new Discount(new Product(new Product("mouse", 20, 1)));

            var actual = discount1.ToString();

            Assert.Equal("Shopping.Discount", actual);
        }
    }
}