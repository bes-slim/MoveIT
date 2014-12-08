using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MoveIT.Service.Core;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Core.MoveIT;
using MoveIT.Service.Models;
using Xunit;

namespace MoveIT.Service.Tests.Core.Tests
{
    public class PianoRuleTests
    {
        [Fact]
        public void should_return_false_if_has_no_piano()
        {
            MoveInfo info = new MoveInfo() { HasPiano = false };
            var sut = new PianoRule();
            Assert.False(sut.HasFurniture(info));
        }

        [Fact]
        public void should_return_true_if_has_piano()
        {
            MoveInfo info = new MoveInfo() { HasPiano = true };
            var sut = new PianoRule();
            Assert.True(sut.HasFurniture(info));
        }

        [Fact]
        public void should_return_5000_if_has_a_piano()
        {
            MoveInfo info = new MoveInfo() { HasPiano = true };
            var sut = new PianoRule();
            Assert.Equal(5000m, sut.CalculatePrice());
        }
        
    }
}
