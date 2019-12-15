using System;
using EPI_Practice.Implementation.Chapters.Primitives.Parity.Variants;
using FluentAssertions;
using Xunit;

namespace EPI_Practice.Test.Primitives.Parity.Variants
{
    public class IsPow2Tests
    {
        [Theory]
        [InlineData(10, false)]
        [InlineData(8, true)]
        [InlineData(64, true)]
        [InlineData(65, false)]
        [InlineData(0, true)]
        public void ModPow2ShouldFindModulo(uint x, bool expected)
        {
            IsPow2.IsPowerOf2(x).Should().Be(expected);
        }

    }

}