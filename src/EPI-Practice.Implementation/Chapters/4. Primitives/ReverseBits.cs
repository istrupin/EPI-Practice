using System;

namespace EPI_Practice.Implementation.Chapters.Primitives
{
    public static class ReverseBits
    {
        private readonly static uint[] RevCache;
        static ReverseBits()
        {
            RevCache = new uint[UInt16.MaxValue + 1];
            for (uint i = 0; i <= UInt16.MaxValue; i++)
            {
                RevCache[i] = ReverseIntWithoutCache(i);
            }
        }

        private static uint ReverseIntWithoutCache(uint x)
        {
            for (int i = 0; i < 32; i++)
            {
                var complement = 32 - i - 1;
                if(((x>>i)&1) != ((x>>complement)&1))
                {
                    var mask = (uint)1<<i | (uint)i<<complement;
                    x ^= mask;
                }
            }
            return x;
        }
    }
}
