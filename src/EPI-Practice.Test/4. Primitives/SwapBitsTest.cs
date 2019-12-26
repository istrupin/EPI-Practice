using System;
using FluentAssertions;
using Xunit;

namespace EPI_Practice.Test.Primitives
{
    public class SwapBitsTests
    {
        [Fact]
        public void SwapBitsSwapsBitsIfDifferent()
        {
            var res = EPI_Practice.Implementation.Chapters.Primitives.SwapBits.Swap(73, 1, 6);
            res.Should().Be(11);
        }

        [Fact]
        public void SwapBitsLeavesBitsIfSame()
        {
            var res = EPI_Practice.Implementation.Chapters.Primitives.SwapBits.Swap(73, 1, 2);
            res.Should().Be(73);
        }

    }

}