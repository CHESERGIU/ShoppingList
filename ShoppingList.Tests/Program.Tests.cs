using Shopping;
using Xunit;

namespace ShoppingList.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void WhenWeBuyAMouseAndChoseCourierShipping()
        {
            var product = new Product[2];

            product[0] = new Product("mouse", 1 * 45, (Discount.DiscountType)1);
            product[1] = new Product("laptop bag", 3 * 10, (Discount.DiscountType)3);

            decimal actual = Product.GetTotalPrice(product);
            Assert.Equal((decimal)62, actual);
        }

        [Fact]
        public void BuyAndPayForMultipleProducts()
        {
            // Given
            Basket adele = new Basket();
            var onion = new Product("onion", 100, (Discount.DiscountType)2); // spend 100 lei and get 20% more product
            var cherry = new Product("cherry", 1, (Discount.DiscountType)1); //  product have 10% off
            var cocaCola = new Product("cocaCola", 5 * 10, (Discount.DiscountType)4); // buy 5 bottle at a lower price
            var beer = new Product("beer", 5 * 10, (Discount.DiscountType)3); // buy 3 product for a price of 2 product
            var wine = new Product("wine", 100, 0);

            adele.Buy(onion);
            adele.Buy(cherry);
            adele.Buy(cocaCola);
            adele.Buy(beer);
            adele.Buy(wine);

            // When
            var actual = adele.Pay();

            // Then
            Assert.Equal(132, actual);
        }
    }
}
