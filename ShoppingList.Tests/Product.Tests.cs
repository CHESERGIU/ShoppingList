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

            product[0] = new Product("mouse", 45);
            product[1] = new Product("laptop bag", 10);

            double actual = product[0].Price() + product[1].Price();

            Assert.Equal((double)55, actual);
        }
    }
}