using System;
using FluentAssertions;
using Xunit;

namespace EPI_Practice.Test.Primitives
{
    public class ReverseBitsTests
    {
        [Theory]
        [InlineData(1,2147483648)]
        public void ReversesBits(uint input, uint expected)
        {
            var res = EPI_Practice.Implementation.Chapters.Primitives.ReverseBits.ReverseWithCache(input);
            res.Should().Be(expected);
        }
    }

}