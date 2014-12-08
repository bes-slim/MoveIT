using Moq;
using MoveIT.Service.Core;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Core.MoveIT;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class CarsNeededCalculatorTests
    {
        [Fact]
        public void should_return_1_car_for_an_area_of_49_square_meters_and_a_basement_area_0()
        {
            // Arrange
            var info = new MoveInfo() { Area = 49, BasementArea = 0 };
            var fiftySquareRule = new Mock<ICarsNeededForAreaRule>();
            var carForBasementRule = new Mock<ICarsNeededForAreaRule>();

            
            fiftySquareRule.Setup(x => x.CarsNeededForArea(info)).Returns(1);
            carForBasementRule.Setup(x => x.CarsNeededForArea(info)).Returns(0);
            
            var sut = new CarsNeededCalculator(new[] { fiftySquareRule.Object, carForBasementRule.Object });
            
            Assert.Equal(1, sut.CalculateNeededCars(info));
        }

        [Fact]
        public void should_return_2_cars_for_an_area_of_10_square_meters_and_a_basement_area_25()
        {
            // Arrange
            var info = new MoveInfo() { Area = 10, BasementArea = 25 };
            var fiftySquareRule = new Mock<ICarsNeededForAreaRule>();
            var carForBasementRule = new Mock<ICarsNeededForAreaRule>();
            
            fiftySquareRule.Setup(x => x.CarsNeededForArea(info)).Returns(1);
            carForBasementRule.Setup(x => x.CarsNeededForArea(info)).Returns(1);
            
            var sut = new CarsNeededCalculator(new[] { fiftySquareRule.Object, carForBasementRule.Object });
            
            Assert.Equal(2, sut.CalculateNeededCars(info));
        }

        [Fact]
        public void should_return_2_cars_for_an_area_of_50_square_meters_and_a_basement_area_0()
        {
            // Arrange
            var info = new MoveInfo() { Area = 50, BasementArea = 0 };
            var fiftySquareRule = new Mock<ICarsNeededForAreaRule>();
            var carForBasementRule = new Mock<ICarsNeededForAreaRule>();
            
            fiftySquareRule.Setup(x => x.CarsNeededForArea(info)).Returns(2);
            carForBasementRule.Setup(x => x.CarsNeededForArea(info)).Returns(0);
            
            var sut = new CarsNeededCalculator(new[] { fiftySquareRule.Object, carForBasementRule.Object });
            
            Assert.Equal(2, sut.CalculateNeededCars(info));
        }

        [Fact]
        public void should_return_3_cars_for_an_area_of_100_square_meters_and_a_basement_area_0()
        {
            // Arrange
            var info = new MoveInfo() { Area = 100, BasementArea = 0 };
            var fiftySquareRule = new Mock<ICarsNeededForAreaRule>();
            var carForBasementRule = new Mock<ICarsNeededForAreaRule>();
            
            fiftySquareRule.Setup(x => x.CarsNeededForArea(info)).Returns(3);
            carForBasementRule.Setup(x => x.CarsNeededForArea(info)).Returns(0);
            
            var sut = new CarsNeededCalculator(new[] { fiftySquareRule.Object, carForBasementRule.Object });
            
            Assert.Equal(3, sut.CalculateNeededCars(info));
        }

        [Fact]
        public void should_return_4_cars_for_an_area_of_150_square_meters_and_a_basement_area_0()
        {
            // Arrange
            var info = new MoveInfo() { Area = 150, BasementArea = 0 };
            var fiftySquareRule = new Mock<ICarsNeededForAreaRule>();
            var carForBasementRule = new Mock<ICarsNeededForAreaRule>();

            fiftySquareRule.Setup(x => x.CarsNeededForArea(info)).Returns(4);
            carForBasementRule.Setup(x => x.CarsNeededForArea(info)).Returns(0);

            var sut = new CarsNeededCalculator(new[] { fiftySquareRule.Object, carForBasementRule.Object });
            
            Assert.Equal(4, sut.CalculateNeededCars(info));
        }
    }
}
