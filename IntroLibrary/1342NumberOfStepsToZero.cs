using System.Collections.Generic;
using System;
using System.Linq;

namespace StepsTopZero1342
{
    
    //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/

    public class Solution
    {
    //        public int NumberOfSteps (int num) {
    //            var steps =0;
    //            while(num!=0)
    //            {
    //                if(num%2 !=0)
    //                {
    //                    num -=1;
    //                }
    //                else{
    //                     num = num/2;
    //                }
                   
    //                steps++;
    //            }
    //            return steps;
        
    // }

    //  public int NumberOfSteps (int num) {
    //            var steps =0;
    //            var mask =1;
    //            while(num!=0)
    //            {
    //                if((num & 1) !=0)
    //                {
    //                    num -=1;
    //                }
    //                else{
    //                     num >>=1;
    //                }
                   
    //                steps++;
    //            }
    //            return steps;
        
    // }

     public int NumberOfSteps (int num) {
               var str = BitConverter.GetBytes(num);
               return 0;
        
    }

       
    }
}