using System;

namespace EPI_Practice.Implementation.Chapters.Primitives.Parity.Variants
{
    public static class IsPow2
    {
        public static bool IsPowerOf2(uint x)
        {
            var firstSet = x & ~(x - 1);
            var unset = x & ~firstSet;
            return unset == 0;
        }
    }

    
}
