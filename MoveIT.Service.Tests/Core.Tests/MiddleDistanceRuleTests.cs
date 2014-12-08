using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovePricer.Service.Core;
using MovePricer.Service.Core.MoveIT;
using MovePricer.Service.Models;
using Xunit;

namespace MovePricer.Service.Tests.Core.Tests
{
    public class MiddleDistanceRuleTests
    {

        [Fact]
        public void should_return_true_if_more_than_50_km_and_under_100km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 60 };
            var sut = new MiddleDistanceRule();
            Assert.True(sut.IsApplicable(info));
        }

        [Fact]
        public void should_return_true_if_50_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 50 };
            var sut = new MiddleDistanceRule();
            Assert.True(sut.IsApplicable(info));
        }
        [Fact]
        public void should_return_false_if_100_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 100 };
            var sut = new MiddleDistanceRule();
            Assert.False(sut.IsApplicable(info));
        }



        [Fact]
        public void should_return_5400_if_50_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 50 };
            var sut = new MiddleDistanceRule();
            Assert.Equal(5400m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_5408_if_51_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 51 };
            var sut = new MiddleDistanceRule();
            Assert.Equal(5408m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_5792_if_99_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 99 };
            var sut = new MiddleDistanceRule();
            Assert.Equal(5792m, sut.CalculatePrice(info));
        }
    }
}
