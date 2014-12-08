using Moq;
using MovePricer.Service.Core;
using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Core.MoveIT;
using MovePricer.Service.Models;
using Xunit;

namespace MovePricer.Service.Tests.Core.Tests
{
    public class CarsCostsRuleTests
    {
        [Fact]
        public void should_return_1100_for_a_distance_of_10_km_area_49_sm_and_basement_0_sm()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10, Area = 49, BasementArea = 0 };
            
            var distancePrice = new Mock<IDistancePriceCalculator>();
            var carsNeeded = new Mock<ICarsNeededCalculator>();
            distancePrice.Setup(x => x.CalculateDistancePrice(info)).Returns(1100m);
            carsNeeded.Setup(x => x.CalculateNeededCars(info)).Returns(1);

            var sut = new CarsCostsRule(distancePrice.Object, carsNeeded.Object);
            
            // Assert
            Assert.Equal(1100m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_2200_for_a_distance_of_10_km_area_10_sm_and_basement_25_sm()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10, Area = 10, BasementArea = 25 };

            var distancePrice = new Mock<IDistancePriceCalculator>();
            var carsNeeded = new Mock<ICarsNeededCalculator>();
            distancePrice.Setup(x => x.CalculateDistancePrice(info)).Returns(1100m);
            carsNeeded.Setup(x => x.CalculateNeededCars(info)).Returns(2);

            var sut = new CarsCostsRule(distancePrice.Object, carsNeeded.Object);

            // Assert
            Assert.Equal(2200m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_2200_for_a_distance_of_10_km_area_50_sm_and_basement_0_sm()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10, Area = 50, BasementArea = 0 };

            var distancePrice = new Mock<IDistancePriceCalculator>();
            var carsNeeded = new Mock<ICarsNeededCalculator>();
            distancePrice.Setup(x => x.CalculateDistancePrice(info)).Returns(1100m);
            carsNeeded.Setup(x => x.CalculateNeededCars(info)).Returns(2);

            var sut = new CarsCostsRule(distancePrice.Object, carsNeeded.Object);

            // Assert
            Assert.Equal(2200m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_3300_for_a_distance_of_10_km_area_100_sm_and_basement_0_sm()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10, Area = 100, BasementArea = 0 };

            var distancePrice = new Mock<IDistancePriceCalculator>();
            var carsNeeded = new Mock<ICarsNeededCalculator>();
            distancePrice.Setup(x => x.CalculateDistancePrice(info)).Returns(1100m);
            carsNeeded.Setup(x => x.CalculateNeededCars(info)).Returns(3);

            var sut = new CarsCostsRule(distancePrice.Object, carsNeeded.Object);

            // Assert
            Assert.Equal(3300m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_4400_for_a_distance_of_10_km_area_150_sm_and_basement_0_sm()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10, Area = 150, BasementArea = 0 };

            var distancePrice = new Mock<IDistancePriceCalculator>();
            var carsNeeded = new Mock<ICarsNeededCalculator>();
            distancePrice.Setup(x => x.CalculateDistancePrice(info)).Returns(1100m);
            carsNeeded.Setup(x => x.CalculateNeededCars(info)).Returns(4);

            var sut = new CarsCostsRule(distancePrice.Object, carsNeeded.Object);

            // Assert
            Assert.Equal(4400m, sut.CalculatePrice(info));
        }
    }
}
