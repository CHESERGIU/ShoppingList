using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanCreateProductWithValuesToTest()
        {
            const Discount.DiscountType discountType1 = (Discount.DiscountType)5;
            var discount1 = new Discount(discountType1, 5, 5);
            var product = new Product("laptop", 3000, discount1);
            const int quantity = 5;
            product.GetPrice(quantity);
            Assert.Equal("laptop", product.ToString());
            Assert.Equal(15000, discount1.GetDiscount());
        }

        [Fact]
        public void CanCreateProductWithValuesToTestClass()
        {
            const Discount.DiscountType discountType2 = (Discount.DiscountType)100;
            var discount2 = new Discount(discountType2, 10, 10);
            var product = new Product("mouse", 25, discount2);
            const int quantity = 10;
            product.GetPrice(quantity);
            Assert.Equal("mouse", product.ToString());
            Assert.Equal(250, discount2.GetDiscount());
        }
    }
}