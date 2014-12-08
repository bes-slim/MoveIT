using Moq;
using MovePricer.Service.Core;
using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Models;
using Xunit;

namespace MovePricer.Service.Tests.Core.Tests
{
    public class OffrePriceCalculatorTests
    {
        [Fact]
        public void shoudl_return_9000_excl_vat_5_km_distance_area_of_73_sm_basement_9_sm_and_has_piano()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 5, Area = 73, BasementArea = 9, HasPiano = true };
            var carsCostRule = new Mock<IOffreCostsRule>();
            var sepecialFurnitureCostRule = new Mock<IOffreCostsRule>();

            carsCostRule.Setup(x => x.CalculatePrice(info)).Returns(2200);
            sepecialFurnitureCostRule.Setup(x => x.CalculatePrice(info)).Returns(5000);

            var sut = new OffrePriceCalcualtor(new []{carsCostRule.Object, sepecialFurnitureCostRule.Object});

            // Assert
            Assert.Equal(9000, sut.CalculatePrice(info));
        }


    }
}
