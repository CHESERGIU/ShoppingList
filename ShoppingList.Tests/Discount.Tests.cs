using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class DiscountTests
    {
        [Fact]
        public void WhenWeBuy5ProductMustReturn3Products()
        {
            const Discount.DiscountType discountType = (Discount.DiscountType)5;
            var discount = new Discount(discountType, 10, 40);

            var actual = discount.GetDiscount();

            Assert.Equal(4, actual); // quantity for discount = 4
        }

        [Fact]
        public void WhenWeHaveDiscountTypeQuantityAndReturnIsHalfQuantity()
        {
            const Discount.DiscountType discountType = (Discount.DiscountType)5;
            var discount = new Discount(discountType, 1000, 10);

            var actual = discount.GetDiscount();

            Assert.Equal(100, actual); // quantity for discount = 100
        }

        [Fact]
        public void WhenWeHaveDiscountTypePriceAndReturnIsLessQuantity()
        {
            const Discount.DiscountType discountType = (Discount.DiscountType)6;
            var discount = new Discount(discountType, 0, 0);

            var actual = discount.GetDiscount();

            Assert.Equal(2, actual); // quantity for discount == 2 bottle from a 6-pack
        }
    }
}