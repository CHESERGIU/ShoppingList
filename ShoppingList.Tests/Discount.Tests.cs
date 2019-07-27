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
            var mouses = new Product("mouse", 50, 5);
            var discount = new Discount();
            Product[] list = { new Product("mouse", 50, 5) };
            var actual = discount.GetDiscount(mouses.GetPrices(list), mouses.GetQuantity(list));

            Assert.Equal(150, actual);
        }

        [Fact]
        public void WhenWeBuyProductsMoreThen100EuroMustReturn20ProcentageOff()
        {
            var product = new Product("0", 0, 0);
            var discount = new Discount();
            Product[] list =
            {
                new Product("mouse", 100, 1),
                new Product("laptop", 1000, 1),
                new Product("laptop bag", 100, 1)
            };

            var actual = discount.GetDiscount(product.GetPrices(list), product.GetQuantity(list));

            Assert.Equal((double)960, actual);
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