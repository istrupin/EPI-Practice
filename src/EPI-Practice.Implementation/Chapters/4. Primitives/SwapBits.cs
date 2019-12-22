using System;

namespace EPI_Practice.Implementation.Chapters.Primitives
{
    public static class SwapBits
    {
        public static UInt64 Swap(UInt64 x, int i, int j)
        {
            var result = x;
            if (x.ExtractBit(i) != x.ExtractBit(j))
            {
                //invert bits, XOR operator ^
                //correct bitmask is 2 to the nth power
                //where n is the bit I want to flip
                //we could also make 1 combined bitmask by using a | operator
                var mask = ((uint)1<<i) | ((uint)1<<j);
                // result ^= ((uint)1<<i);
                // result ^= ((uint)1<<j);
                result ^= mask;
            }
            return result;
        }

        ///extracts with 0 as LSB
        private static ulong ExtractBit(this UInt64 x, int n)
        {
            //>>> operator does not exist in C#
            var shifted = x>>n;
            //extract
            return shifted&1;
        }
    }
}
