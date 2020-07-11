using System;
using System.Collections.Generic;
using System.Linq;
namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var gap = target - current;
                if (dict.TryGetValue(gap, out int index))
                {
                    return new int[] { i, index };
                }
                dict[nums[i]] = i;
            }
            return null;
        }

        public IList<IList<int>> ThreeSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                if (!dict.ContainsKey(current))
                {
                    dict[current] = 1;
                }
                else
                {
                    dict[current] = dict[current] + 1;
                }
            }

            var maxDepth = 3;
            var keys = dict.Keys.ToList();
            var res = NSum(dict, keys, target, maxDepth);
            return res;
        }

        private IList<IList<int>> NSum(Dictionary<int, int> dict, List<int> keys, int target, int depth)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (depth == 1 && dict.TryGetValue(target, out int index))
            {
                if (index > 0)
                {

                    var t = new List<int>() { target };
                    result.Add(t);
                    return result;
                }
                else
                {
                    return null;
                }
            }

            foreach (var k in keys)
            {
                var value = dict[k];
                if (value > 0)
                {
                    var current = k;
                    dict[k] = value - 1;
                    var nt = target - current;
                    var res = NSum(dict, keys, nt, depth - 1);

                    if (res == null)
                    {
                        dict[k] = value + 1;
                    }
                    else
                    {
                        foreach (var item in res)
                        {
                            item.Add(current);
                            result.Add(item);
                        }
                    }
                }
            }
            return result;
        }
    }
}