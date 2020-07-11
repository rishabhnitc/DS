using System.Collections.Generic;
using System;
using System.Linq;

namespace HammingDistance461
{

    //https://leetcode.com/problems/palindrome-number/

    public class Solution
    {
    //      public int HammingDistance(int x, int y) {
    //         var result =0;
    //         var mask =1;
    //         while(x !=0 || y!= 0)
    //         {
    //             if((x&mask )!=( y&mask))
    //             {
    //                 result ++;
    //             }
    //             x >>=1;
    //             y >>=1;
    //         }
    //          return result;
        
    // }

    public int HammingDistance(int x, int y) {
            var result =0;
            var mask =x^y;
           
            while(mask !=0)
            {
                result += mask&1;
                mask >>=1;
            }
             return result;
        
    }
     




    }
}