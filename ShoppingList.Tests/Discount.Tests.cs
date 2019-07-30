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
            const Discount.DiscountType discountType = (Discount.DiscountType)5;
            var discount = new Discount(discountType, 5, 5);
            var product = new Product("mouse", 50, discount);
            Product[] list = { product };
            var actual = product.GetPrice(5);

            Assert.Equal(250, actual);
        }

        [Fact]
        public void WhenWeBuyProductsMoreThen100EuroMustReturn20ProcentageOff()
        {
            const Discount.DiscountType discountType = (Discount.DiscountType)5;
            var discount = new Discount(discountType, 5, 5);
            var product1 = new Product("mouse", 50, discount);
            var product2 = new Product("laptop", 1000, discount);
            var product3 = new Product("laptop bag", 125, discount);
            Product[] list =
            {
                product1,
                product2,
                product3
            };

            var actual = product1.GetPrice(5) + product2.GetPrice(5) + product3.GetPrice(5);

            Assert.Equal(1200, actual);
        }
    }
}