using System;
using System.Linq;
using System.Text;
using EPI_Practice.Implementation.Chapters.Primitives.Parity.Variants;
using FluentAssertions;
using Xunit;

namespace EPI_Practice.Test.Primitives.Parity.Variants
{
    public class RightPropogateTests
    {
        [Theory]
        [InlineData(12, 15)]
        [InlineData(2, 3)]
        [InlineData(4, 7)]
        [InlineData(80, 95)]

        public void RightPropgateShouldPropogateLastSetBit(uint input, uint expected)
        {
            var res = RightPropogate.RightPropogateBits(input).Should().Be(expected);
        }

        [Fact]
        public void RightPropogateSetsLastBitOnRandomInputs(){
            Random rnd = new Random();
            var rands = Enumerable.Repeat(100000,50).Select(i => rnd.Next(i));

            foreach (var item in rands)
            {
                RightPropogate.RightPropogateBits(Convert.ToUInt32(item)).Should().Be(manualRightPropogate(Convert.ToUInt32(item)));
            }
            
        }

        private uint manualRightPropogate(uint x)
        {
            var binary = Convert.ToString(x, 2);
            var reversed = binary.Reverse();
            StringBuilder sb = new StringBuilder();
            bool set = false;
            foreach (var c in reversed)
            {
                if(set)
                {
                    sb.Append(c);
                }
                else
                {
                    if(c == '1'){
                        sb.Append(c);
                        set = true;
                        continue;
                    }
                    sb.Append(1);
                }
            }
            var str = new String(sb.ToString().Reverse().ToArray());
            return Convert.ToUInt32(str, fromBase: 2);
        }
    }

}
