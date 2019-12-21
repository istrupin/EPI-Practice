using System;
using EPI_Practice.Implementation.Chapters.Primitives.SwapBits;
using FluentAssertions;
using Xunit;

namespace EPI_Practice.Test.Primitives.SwapBits
{
    public class SwapBitsTests
    {
        [Fact]
        public void SwapBitsSwapsBitsIfDifferent()
        {
            var res = EPI_Practice.Implementation.Chapters.Primitives.SwapBits.SwapBits.Swap(73, 1, 6);
            res.Should().Be(11);
        }

        [Fact]
        public void SwapBitsLeavesBitsIfSame()
        {
            var res = EPI_Practice.Implementation.Chapters.Primitives.SwapBits.SwapBits.Swap(73, 1, 2);
            res.Should().Be(73);
        }

    }

}