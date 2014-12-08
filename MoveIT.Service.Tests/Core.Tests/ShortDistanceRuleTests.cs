using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveIT.Service.Core;
using MoveIT.Service.Core.MoveIT;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class ShortDistanceRuleTests
    {
        [Fact]
        public void should_return_true_if_under_than_50_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 30 };
            var sut = new ShortDistanceRule();
            Assert.True(sut.IsApplicable(info));
        }

        [Fact]
        public void should_return_false_if_over_50_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 51 };
            var sut = new ShortDistanceRule();
            Assert.False(sut.IsApplicable(info));
        }
        [Fact]
        public void should_return_false_if_50_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 50 };
            var sut = new ShortDistanceRule();
            Assert.False(sut.IsApplicable(info));
        }


        [Fact]
        public void should_return_1100_if_10_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10 };
            var sut = new ShortDistanceRule();
            Assert.Equal(1100m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_1490_if_49_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 49 };
            var sut = new ShortDistanceRule();
            Assert.Equal(1490m, sut.CalculatePrice(info));
        }
    }
}
