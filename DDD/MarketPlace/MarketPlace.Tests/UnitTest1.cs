using MarketPlace.Domain;

namespace MarketPlace.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void money_objects_with_the_same_amount_should_be_equal()
        {
            var first = new Money(1);
            var second = new Money(1);

            Assert.Equal(first, second);

        }
    }
}