

using System.Collections.Generic;
using System;

namespace ReverseInteger
{
    public class Solution
    {
        // public int Reverse(int x)
        // {                 
        //     int res = 0;
        //     var intMaxb = int.MaxValue/10;
        //     var intMinb = int.MinValue/10;

        //     // The following line raises an exception because it is checked.

        //     while (x != 0)
        //     {
        //         var n = x % 10;
        //         x = x / 10;    
        //         if((res > intMaxb)||((res == intMaxb) && n>7))
        //             return 0;

        //         if((res < intMinb)||((res == intMinb) && n<-8))
        //             return 0;
        //         res = res * 10 + n;
               

        //     }

        //     return res;
        // }

         public int Reverse(int x)
        {                 
            long res = 0;
            

            // The following line raises an exception because it is checked.

            while (x != 0)
            {
                var n = x % 10;
                x = x / 10;                    
                res = res * 10 + n;                             

            }

            if(res > int.MaxValue || res <int.MinValue)
                return 0 ;

            return (int)res;
        }


    }
}