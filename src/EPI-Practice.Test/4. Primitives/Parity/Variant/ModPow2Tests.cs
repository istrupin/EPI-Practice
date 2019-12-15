using System;
using EPI_Practice.Implementation.Chapters.Primitives.Parity.Variants;
using FluentAssertions;
using Xunit;

namespace EPI_Practice.Test.Primitives.Parity.Variants
{
    public class ModPow2Tests
    {
        [Theory]
        [InlineData(10, 4)]
        [InlineData(10, 2)]
        [InlineData(10, 1)]
        [InlineData(77, 64)]

        public void ModPow2ShouldFindModulo(uint x, uint d)
        {
            var res = ModPow2.CalculateMod(x,d);
            ModPow2.CalculateMod(x,d).Should().Be(Convert.ToUInt32(manualModPow2(x,d)));
        }

        private long manualModPow2(uint x, uint d) => x%d;
    }

}