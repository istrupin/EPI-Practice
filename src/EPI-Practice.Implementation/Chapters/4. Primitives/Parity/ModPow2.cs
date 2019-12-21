using System;

namespace EPI_Practice.Implementation.Chapters.Primitives.Parity
{
    public static class ModPow2
    {
        public static uint CalculateMod(uint x, uint d)
        {
            var res = x & (d -1);
            return res;
            

        }
    }

    
}
