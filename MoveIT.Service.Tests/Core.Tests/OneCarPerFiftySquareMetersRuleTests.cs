using MoveIT.Service.Core;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class OneCarPerFiftySquareMetersRuleTests
    {
        [Fact]
        public void should_return_1_car_for_an_area_of_49_square_meters()
        {
            // Arrange
            var sut = new OneCarPerFiftySquareMetersRule();
            var moveInfo = new MoveInfo() { Area = 49 };
            int exptectedNbrOfCars = 1;

            // Act
            int actualNbrOfCars = sut.CarsNeededForArea(moveInfo);

            // Assert
            Assert.Equal(exptectedNbrOfCars, actualNbrOfCars);
        }

        [Fact]
        public void should_return_2_car_for_an_area_of_50_square_meters()
        {
            // Arrange
            OneCarPerFiftySquareMetersRule sut = new OneCarPerFiftySquareMetersRule();
            MoveInfo moveInfo = new MoveInfo() { Area = 50 };
            int exptectedNbrOfCars = 2;

            // Act
            int actualNbrOfCars = sut.CarsNeededForArea(moveInfo);

            // Assert
            Assert.Equal(exptectedNbrOfCars, actualNbrOfCars);
        }

        [Fact]
        public void should_return_3_car_for_an_area_of_100_square_meters()
        {
            // Arrange
            OneCarPerFiftySquareMetersRule sut = new OneCarPerFiftySquareMetersRule();
            MoveInfo moveInfo = new MoveInfo() { Area = 100 };
            int exptectedNbrOfCars = 3;

            // Act
            int actualNbrOfCars = sut.CarsNeededForArea(moveInfo);

            // Assert
            Assert.Equal(exptectedNbrOfCars, actualNbrOfCars);
        }

        [Fact]
        public void should_return_4_car_for_an_area_of_150_square_meters()
        {
            // Arrange
            OneCarPerFiftySquareMetersRule sut = new OneCarPerFiftySquareMetersRule();
            MoveInfo moveInfo = new MoveInfo() { Area = 150 };
            int exptectedNbrOfCars = 4;

            // Act
            int actualNbrOfCars = sut.CarsNeededForArea(moveInfo);

            // Assert
            Assert.Equal(exptectedNbrOfCars, actualNbrOfCars);
        }
    }
}
