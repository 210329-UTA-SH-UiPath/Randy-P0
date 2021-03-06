using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_StoreName()
        {//arrange
            var sut = new GinosPizzeria();

            //act
            var actual = sut.Name;

            // assert
            Assert.True(actual == "GinosPizzeria");
        }
    }
}