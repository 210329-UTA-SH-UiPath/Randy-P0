using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTests
    {
        [Fact]
        public void Tests_PizzaCrust()
        {
            // arrange
            var sut = new Crust();
            // act
            var actual = sut.Crust;
            // assert
            Assert.Null(actual);
        }
    }
}