using System.Collections.Generic;
using System;
using System.Linq;

namespace PowerSet78
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
         
            var res = new List<IList<int>>();
            if(nums.Length >1)
            {
                var r1 = Subsets( new[]{nums[0]});
                var r2 = Subsets( new[]{nums[0]});
            }
            return res;

          

        }


    }
}