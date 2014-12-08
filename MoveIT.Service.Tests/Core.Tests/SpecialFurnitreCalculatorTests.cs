using Moq;
using MoveIT.Service.Core;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Core.MoveIT;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class SpecialFurnitreCalculatorTests
    {
        [Fact]
        public void should_return_0_if_has_no_piano()
        {
            MoveInfo info = new MoveInfo() { HasPiano = false };
            var specialFurnitreRule = new Mock<ISpecialFurnitureRule>();
            specialFurnitreRule.Setup(x => x.HasFurniture(info)).Returns(false);
            specialFurnitreRule.Setup(x => x.CalculatePrice()).Returns(0);
            var sut = new SpecialFurnitreCalculator(new[] { specialFurnitreRule.Object });
            Assert.Equal(0m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_5000_if_has_a_piano()
        {
            MoveInfo info = new MoveInfo() { HasPiano = true };
            var specialFurnitreRule = new Mock<ISpecialFurnitureRule>();
            specialFurnitreRule.Setup(x => x.HasFurniture(info)).Returns(true);
            specialFurnitreRule.Setup(x => x.CalculatePrice()).Returns(5000);
            var sut = new SpecialFurnitreCalculator(new[] { specialFurnitreRule.Object });
            Assert.Equal(5000m, sut.CalculatePrice(info));
        }
    }
}
