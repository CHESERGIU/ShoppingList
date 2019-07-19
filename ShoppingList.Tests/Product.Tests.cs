using Shopping;
using System;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProductTests
    {
        [Fact]
        public void WhenWeTestProducts()
        {
            var product = new Product[2];

            product[0] = new Product("mouse", 45, 1);
            product[1] = new Product("laptop bag", 10, 1);

            var actual = product[0].Price() + product[1].Price();
            var quantity = product[0].Quantity() + product[1].Quantity();

            Assert.Equal((double)55, actual);
            Assert.Equal((double)2, quantity);
        }
    }
}