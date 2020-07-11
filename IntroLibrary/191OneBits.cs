using System.Collections.Generic;
using System;

namespace OneBits191
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum++;
                n &= (n - 1);
            }
            return sum;

        }

        //  public int HammingWeight(uint n)
        // {
        //     var weight = 0;
        //     var mask =1;


        //     for (int i = 0; i < 32; i++)
        //     {
        //         if((n & mask)!=0)
        //             weight++;
        //         mask <<= 1;

        //     }

        //     return weight;

        // }
    }
}