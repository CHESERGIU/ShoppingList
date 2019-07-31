using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProductTests
    {
        [Fact]
        public void BuyAndPayOneItem()
        {
            var discount = new Discount(Discount.DiscountType.Quantity, 1, 10);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(1);
            Assert.Equal((decimal)90, actual); // 1 wine with discount
        }

        [Fact]
        public void BuyAndPayTwoItems()
        {
            var discount = new Discount(Discount.DiscountType.Quantity, 2, 20);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(2);
            Assert.Equal((decimal)160, actual); // 2 wines with discount
        }

        [Fact]
        public void BuyAndPay3Items()
        {
            var discount = new Discount(Discount.DiscountType.Quantity, 2, 30);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(3);
            Assert.Equal((decimal)240, actual); // 2 wines with discount, 1 without discount
        }

        [Fact]
        public void BuyAndPay3ItemsWithADiscountFor3()
        {
            var discount = new Discount(Discount.DiscountType.Quantity, 3, 40);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(3);
            Assert.Equal((decimal)180, actual); // 3 wines with discount
        }

        [Fact]
        public void BuyAndPay5ItemsWithADiscountFor3()
        {
            var discount = new Discount(Discount.DiscountType.Quantity, 3, 40);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(5);
            Assert.Equal((decimal)380, actual); // 3 wines with discount & 2 without discount
        }

        [Fact]
        public void BuyAndPayItemsWithADiscountForSixPack()
        {
            var discount = new Discount(Discount.DiscountType.SixPack, 0, 0);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(6);
            Assert.Equal((decimal)400, actual); // take a six-pack of wines and pay 4 wines
        }

        [Fact]
        public void BuyAndPay2ItemsWithADiscountForSixPack()
        {
            var discount = new Discount(Discount.DiscountType.SixPack, 0, 0);
            var wine = new Product("wine", 100, discount);
            var actual = wine.GetPrice(10);
            Assert.Equal((decimal)800, actual); // take a six-pack of wines, pay 4 wines and 4 wines without discount
        }
    }
}