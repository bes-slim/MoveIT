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
    public class LongDistanceRuleTests
    {
        [Fact]
        public void should_return_true_if_more_than_100_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 120 };
            var sut = new LongDistanceRule();
            Assert.True(sut.IsApplicable(info));
        }

        [Fact]
        public void should_return_false_if_less_than_100_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 10};
            var sut = new LongDistanceRule();
            Assert.False(sut.IsApplicable(info));
        }
        

        [Fact]
        public void should_return_10700_if_100_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 100 };
            var sut = new LongDistanceRule();
            Assert.Equal(10700m, sut.CalculatePrice(info));
        }

        [Fact]
        public void should_return_5792_if_99_km()
        {
            // Arrange
            var info = new MoveInfo() { Distance = 100 };
            var sut = new LongDistanceRule();
            Assert.Equal(10700m, sut.CalculatePrice(info));
        }
    }
}
