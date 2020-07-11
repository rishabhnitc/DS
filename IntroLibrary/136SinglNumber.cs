using System.Collections.Generic;
using System;
using System.Linq;

namespace SingleNumber136
{

   //https://leetcode.com/problems/single-number/
    public class Solution
    {
    //   public int SingleNumber(int[] nums) {
    //       var set = new HashSet<int>();

    //       for(int i =0; i<nums.Length; i++)
    //       {
    //           var item = nums[i];

    //             if(set.Contains(item))
    //             {
    //                 set.Remove(item);
    //             }
    //             else{
    //                 set.Add(item);

    //             }
    //       }
    //       return set.First();
        
    // } 

     public int SingleNumber(int[] nums) {
         
         var num =nums[0];


          for(int i =1; i<nums.Length; i++)
          {
              num ^=nums[i];
          }
          return num;
        
    } 




    }
}