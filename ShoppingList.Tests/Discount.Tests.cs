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
            const Discount.DiscountType discountType = (Discount.DiscountType)1;
            var discount = new Discount(discountType, 10, 40); // 40% off from 10 products

            const decimal quantity = 10;
            var actual = discount.GetDiscount(quantity, discount);

            Assert.Equal(6, actual);
        }

        [Fact]
        public void WhenWeHaveDiscountTypeQuantityAndReturnIsHalfQuantity()
        {
            const Discount.DiscountType discountType = (Discount.DiscountType)1;
            var discount = new Discount(discountType, 1000, 10);

            const decimal quantity = 1000;
            var actual = discount.GetDiscount(quantity, discount);

            Assert.Equal(900, actual);
        }
    }
}