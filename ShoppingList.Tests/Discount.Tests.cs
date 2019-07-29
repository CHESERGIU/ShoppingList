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
            var product = new Product("mouse", 50);
            Product[] list = { product };
            var discount = new Discount(product, 5);
            var actual = discount.Price();

            Assert.Equal(250, actual);
        }

        [Fact]
        public void WhenWeBuyProductsMoreThen100EuroMustReturn20ProcentageOff()
        {
            var product1 = new Product("mouse", 100);
            var product2 = new Product("laptop", 100);
            var product3 = new Product("laptop bag", 100);
            Product[] list =
            {
                product1,
                product2,
                product3
            };

            var discount1 = new Discount(product1, 10);
            var discount2 = new Discount(product2, 1);
            var discount3 = new Discount(product3, 1);

            var actual = discount1.Price() + discount2.Price() + discount3.Price();

            Assert.Equal(1200, actual);
        }
    }
}