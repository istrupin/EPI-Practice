using System;

namespace EPI_Practice.Implementation.Chapters.Primitives
{
    //originally this is for an int64, however I halbed this to
    //apply to int32 instead for ease of testing
    public static class ReverseBits
    {
        private readonly static byte[] RevCache;
        static ReverseBits()
        {
            RevCache = new byte[byte.MaxValue + 1];
            for (int i = 0; i <= byte.MaxValue; i++)
            {
                RevCache[i] = ReverseIntWithoutCache((byte)i);
            }
        }

        private static byte ReverseIntWithoutCache(byte x)
        {
            //4 because we only need to traverse half of the byte to reverse it
            for (int i = 0; i <= 4; i++)
            {
                var complement = 8 - i - 1;
                if(((x>>i)&1) != ((x>>complement)&1))
                {
                    var mask = (byte)1<<i | (byte)1<<complement;
                    x ^= (byte)mask;
                }
            }
            return x;
        }

        public static uint ReverseWithCache(uint x)
        {
            var maskSize = 8;
            var mask = byte.MaxValue; //1111 1111  bit mask it get a 8 bit int

            //uint32 has 4 8-bit chunks
            var chunk1 = x & mask; //least significant
            var chunk2 =  (x >> maskSize) & mask; 
            var chunk3 =  (x >> maskSize * 2) & mask; 
            var chunk4 =  (x >> maskSize * 3) & mask; 

            return (uint)(RevCache[chunk1] << (maskSize * 3))
                | (uint)(RevCache[chunk2] << (maskSize * 2))
                | (uint)(RevCache[chunk3] << maskSize)
                | (RevCache[chunk4]); 
        }
    }
}
