
using System;
using System.Collections.Generic;

namespace LongestSubSeq
{
    public class Solution
    {

        // public int LengthOfLongestSubstring(string s)
        // {        

        //     int max = 0;
        //     if (string.IsNullOrEmpty(s))
        //         return max;


        //     HashSet<char> set = new HashSet<char>();
        //     var n = s.Length;
        //     var i = 0;
        //     var j = 0;
        //     max = 1;

        //     while (i < n && j < n)
        //     {
        //         var item = s[j];
        //         if (!set.Contains(item))
        //         {
        //             set.Add(item);
        //             j++;
        //             max = Math.Max(max, j - i);
        //         }
        //         else
        //         {
        //             set.Remove(s[i]);
        //             i++;
        //         }
        //     }
        //     return max;
        // }

        // public int LengthOfLongestSubstring(string s)
        // {

        //     int max = 0;
        //     if (string.IsNullOrEmpty(s))
        //         return max;


        //     Dictionary<char, int> set = new Dictionary<char, int>();
        //     var n = s.Length;
        //     var i = 0;
        //     var j = 0;
        //     max = 1;

        //     for (i = 0, j = 0; j < n; j++)
        //     {
        //         if (set.ContainsKey(s[j]))
        //         {
        //             i = Math.Max(set[s[j]] + 1, i);
        //         }
        //         max = Math.Max(max, j - i + 1);
        //         set[s[j]] = j ;


        //     }
        //     return max;
        // }

        public int LengthOfLongestSubstring(string s)
        {

            int n = s.Length, ans = 0;
            int[] index = new int[128]; // current index of character
                                        // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }
    }

}