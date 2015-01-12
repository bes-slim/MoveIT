using Moq;
using MoveIT.Service.Core;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class OffrePriceCalculatorTests
    {
        private readonly Mock<IOffreCostsRule> _carsCostRule;
        private readonly Mock<IOffreCostsRule> _specialFurnitureCostRule;
        private readonly MoveInfo _info;
        private readonly OffrePriceCalcualtor _sut;
        private readonly decimal _price;

        public OffrePriceCalculatorTests()
        {
            _carsCostRule = new Mock<IOffreCostsRule>();
            _specialFurnitureCostRule = new Mock<IOffreCostsRule>();
            _carsCostRule.Setup(x => x.CalculatePrice(_info)).Returns(2200);
            _specialFurnitureCostRule.Setup(x => x.CalculatePrice(_info)).Returns(5000);
            _info = new MoveInfo() { Distance = 5, Area = 73, BasementArea = 9, HasPiano = true };
            _sut = new OffrePriceCalcualtor(new[] { _carsCostRule.Object, _specialFurnitureCostRule.Object });
            _price = _sut.CalculatePrice(_info);
        }


        [Fact]
        public void shoudl_return_9000_excl_vat_5_km_distance_area_of_73_sm_basement_9_sm_and_has_piano()
        {
            // Assert
            Assert.Equal(9000, _price);
        }

        [Fact]
        public void should_run_calculate_price_on_cars_rule()
        {
            _carsCostRule.Verify(x => x.CalculatePrice(It.IsAny<MoveInfo>()), Times.Once);
        }

        [Fact]
        public void should_run_calculate_price_on_special_furniture_rule()
        {
            _specialFurnitureCostRule.Verify(x => x.CalculatePrice(It.IsAny<MoveInfo>()), Times.Once);
        }
    }
}
