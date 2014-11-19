using System;
using Moq;
using MoveIT.Service.Core;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class DistancePriceCalculatorTests
    {
        private readonly Mock<IDistancePriceRule> _shortDistanceRule, _middleDistanceRule, _longDistance;

        public DistancePriceCalculatorTests()
        {
            _shortDistanceRule = new Mock<IDistancePriceRule>();
            _middleDistanceRule = new Mock<IDistancePriceRule>();
            _longDistance = new Mock<IDistancePriceRule>();
        }

        [Fact]
        public void should_return_1100_for_a_distance_of_10_km()
        {
            // Arrange 
            MoveInfo info = new MoveInfo() { Distance = 10 };

            _shortDistanceRule.Setup(x => x.CalculatePrice(info)).Returns(1100);
            _shortDistanceRule.Setup(x => x.IsApplicable(info)).Returns(true);
            _middleDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _longDistance.Setup(x => x.IsApplicable(info)).Returns(false);
            var sut = new DistancePriceCalculator(new[] { _shortDistanceRule.Object, _middleDistanceRule.Object, _longDistance.Object });

            // Act
            Decimal actualPrice = sut.CalculateDistancePrice(info);

            // Assert
            Assert.Equal(1100m, actualPrice);
        }

        [Fact]
        public void should_return_1490_for_a_distance_of_49_km()
        {
            // Arrange 
            MoveInfo info = new MoveInfo() { Distance =49 };

            _shortDistanceRule.Setup(x => x.CalculatePrice(info)).Returns(1490);
            _shortDistanceRule.Setup(x => x.IsApplicable(info)).Returns(true);
            _middleDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _longDistance.Setup(x => x.IsApplicable(info)).Returns(false);
            var sut = new DistancePriceCalculator(new[] { _shortDistanceRule.Object, _middleDistanceRule.Object, _longDistance.Object });

            // Act
            Decimal actualPrice = sut.CalculateDistancePrice(info);

            // Assert
            Assert.Equal(1490m, actualPrice);
        }

        [Fact]
        public void should_return_5400_for_a_distance_of_50_km()
        {
            // Arrange 
          
            MoveInfo info = new MoveInfo() { Distance = 50 };
            _middleDistanceRule.Setup(x => x.CalculatePrice(info)).Returns(5400);
            _shortDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _middleDistanceRule.Setup(x => x.IsApplicable(info)).Returns(true);
            _longDistance.Setup(x => x.IsApplicable(info)).Returns(false);
            var sut = new DistancePriceCalculator(new[] { _shortDistanceRule.Object, _middleDistanceRule.Object, _longDistance.Object });

            // Act
            Decimal actualPrice = sut.CalculateDistancePrice(info);

            // Assert
            Assert.Equal(5400m, actualPrice);
        }

        [Fact]
        public void should_return_5408_for_a_distance_of_51_km()
        {
            // Arrange 
            
            MoveInfo info = new MoveInfo() { Distance = 51 };
            _middleDistanceRule.Setup(x => x.CalculatePrice(info)).Returns(5408);
            _shortDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _middleDistanceRule.Setup(x => x.IsApplicable(info)).Returns(true);
            _longDistance.Setup(x => x.IsApplicable(info)).Returns(false);
            var sut = new DistancePriceCalculator(new[] { _shortDistanceRule.Object, _middleDistanceRule.Object, _longDistance.Object });

            // Act
            Decimal actualPrice = sut.CalculateDistancePrice(info);

            // Assert
            Assert.Equal(5408m, actualPrice);
        }

        [Fact]
        public void should_return_5792_for_a_distance_of_99_km()
        {
            // Arrange 
        
            MoveInfo info = new MoveInfo() { Distance = 99 };
            _longDistance.Setup(x => x.CalculatePrice(info)).Returns(5792);
            _shortDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _middleDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _longDistance.Setup(x => x.IsApplicable(info)).Returns(true);
            var sut = new DistancePriceCalculator(new[] { _shortDistanceRule.Object, _middleDistanceRule.Object, _longDistance.Object });
            // Act
            Decimal actualPrice = sut.CalculateDistancePrice(info);

            // Assert
            Assert.Equal(5792m, actualPrice);
        }

        [Fact]
        public void should_return_10700_for_a_distance_of_100_km()
        {
            // Arrange 
            
            MoveInfo info = new MoveInfo() { Distance = 100 };
            _longDistance.Setup(x => x.CalculatePrice(info)).Returns(10700);
            _shortDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _middleDistanceRule.Setup(x => x.IsApplicable(info)).Returns(false);
            _longDistance.Setup(x => x.IsApplicable(info)).Returns(true);
            var sut = new DistancePriceCalculator(new[] { _shortDistanceRule.Object, _middleDistanceRule.Object, _longDistance.Object });

            // Act
            Decimal actualPrice = sut.CalculateDistancePrice(info);

            // Assert
            Assert.Equal(10700m, actualPrice);
        }
    }
}
