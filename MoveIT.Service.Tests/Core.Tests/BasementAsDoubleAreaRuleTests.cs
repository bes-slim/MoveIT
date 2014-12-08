using MovePricer.Service.Core;
using MovePricer.Service.Core.MoveIT;
using MovePricer.Service.Models;
using Xunit;

namespace MovePricer.Service.Tests.Core.Tests
{
    public class BasementAsDoubleAreaRuleTests
    {
        [Fact]
        public void should_return_1_car_for_basement_area_of_25_square_meters()
        {
            // Arrange
            var sut = new BasementAsDoubleAreaRule();
            var moveInfo = new MoveInfo() { Area = 10, BasementArea = 25};
            int exptectedNbrOfCars = 1;

            // Act
            int actualNbrOfCars = sut.CarsNeededForArea(moveInfo);

            // Assert
            Assert.Equal(exptectedNbrOfCars, actualNbrOfCars);
        }
    }
}
