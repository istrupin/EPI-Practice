using System;

namespace EPI_Practice.Implementation.Chapters.Primitives.Parity.Variants
{
    public static class ModPow2
    {
        public static uint RightPropogateBits(uint x)
        {
            //this is what we need to propogate
            var lowestOne = GetLowestOne(x);
            var mask = lowestOne - 1;
            return x | mask;

        }
        private static uint GetLowestOne(uint x) => x&~(x-1);
    }

    
}
