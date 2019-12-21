using System;

namespace EPI_Practice.Implementation.Chapters.Primitives.Parity
{
    public static class RightPropogate
    {
        public static uint RightPropogateBits(uint x)
        {
            //this is what we need to propogate
            var lowestOne = getLowestOne(x);
            var mask = lowestOne - 1;
            return x | mask;

        }
        private static uint getLowestOne(uint x) => x&~(x-1);
    }

    
}
