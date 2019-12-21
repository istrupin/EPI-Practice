using System;

namespace EPI_Practice.Implementation.Chapters.Primitives.SwapBits
{
    public static class SwapBits
    {
        public static UInt64 Swap(UInt64 x, int i, int j)
        {
            var ith = x.ExtractBit(i);
            var jth = x.ExtractBit(j);
            var result = x;

            if (ith != jth)
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

        private static ulong ExtractBit(this UInt64 x, int n)
        {
            //>>> operator does not exist in C#
            var shifted = x>>n;
            //extract
            return shifted&1;
        }
    }

    
}
