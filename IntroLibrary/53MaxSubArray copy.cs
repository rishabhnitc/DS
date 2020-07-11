using System.Collections.Generic;
using System;
using System.Linq;

namespace MaxSubArray53
{
    //https://www.youtube.com/watch?time_continue=799&v=OexQs_cYgAQ&feature=emb_logo
    //https://leetcode.com/problems/maximum-subarray/submissions/

    public class Solution
    {
        // public int MaxSubArray(int[] nums)
        // {
        //     var n = nums.Length;
        //     int c = 0, j = 0;
        //     var max = int.MinValue;
        //     var sum = 0;

        //     while (c < n && j < n)
        //     {
        //         var newSum = sum + nums[j];
        //         max = Math.Max(max, newSum);
        //         max = Math.Max(max, nums[j]);
        //         if (newSum <= 0)
        //         {
        //             j++;
        //             c = j;
        //             newSum =0;
        //         }
        //         else
        //         {

        //             j++;
        //         }
        //         sum = newSum;
        //     }
        //     return max;
        // }

        public int MaxSubArraySum(int[] nums)
        {
            //var n = nums.Length;
            //int c = 0, j = 0;
            var max = nums[0];
            var sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], sum + nums[i]);
                max = Math.Max(sum, max);
            }

            return max;
        }

        public int[] MaxSubArray(int[] nums)
        {

            //var n = nums.Length;
            //int c = 0, j = 0;
            var start = 0;
            var end = 0;
            var max = nums[0];
            var sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i]>sum + nums[i])
                {
                    start =i;
                }
                sum = Math.Max(nums[i], sum + nums[i]);

                if(max <= sum)
                {
                    end =i;
                }
                max = Math.Max(sum, max);
            }

            return nums.Skip(start).Take(end-start +1).ToArray();
        }
    }
}