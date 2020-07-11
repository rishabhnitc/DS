
using System.Collections.Generic;
using System;
using System.Text;

namespace LongestPallindrome
{

    public class Solution
    {


        public String LongestPalindrome(String str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("$#");
            for (int i = 0; i < str.Length - 1; i++)
            {
                sb.Append($"{str[i]}#");
            }
            sb.Append('@');
            var s = sb.ToString();
            var C = 0;
            var R = 0;
            int[] P = new int[s.Length];


            for (int i = 1; i < s.Length - 1; i++)
            {
                var mirror = 2 * C - i;

                if (i < R)
                {
                    P[i] = Math.Min(R - i, P[mirror]);
                }

                while ((s[i + (1 + P[i])] == s[i - (1 + P[i])]))
                    P[i]++;

                if (1 + P[i] > R)
                {
                    C = i;
                    R = 1 + P[i];
                }

            }
            return null;


        }

        // public String LongestPalindrome(String s)
        // {

        //     int max = 0;
        //     string lPal = "";
        //     var maxJ =0;
        //     for (int i = 0; i < s.Length; i++)
        //     {
        //         foreach (var item in getOdd(s, i, maxJ))
        //         {
        //             if (IsPallin(item))
        //             {
        //                 if (max >= item.Length)
        //                     continue;
        //                 max = Math.Max(item.Length, max);
        //                 lPal = item;
        //                 maxJ =  Math.Max(maxJ, (max/2));

        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }

        //         foreach (var item in getEven(s, i, maxJ))
        //         {
        //             if (IsPallin(item))
        //             {
        //                  if (max >= item.Length)
        //                     continue;
        //                 max = Math.Max(item.Length, max);
        //                 lPal = item;
        //                 maxJ =  Math.Max(maxJ, (max/2));
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //     }
        //     return lPal;
        // }

        // private IEnumerable<string> getOdd(string s, int index, int j = 0)
        // {
        //     var n = s.Length;
        //     int i = index;
        //     while (i >= 0 && i - j >= 0 && i + j <= n - 1)
        //     {

        //         yield return s.Substring(i - j, 2 * j + 1);
        //         j++;
        //     }
        // }

        // private IEnumerable<string> getEven(string s, int index, int j = 0)
        // {
        //     var n = s.Length;
        //     int i = index;
        //     while (i >= 0 && i - j >= 0 && i + j + 1 <= n - 1)
        //     {

        //         yield return s.Substring(i - j, 2 * j + 2);
        //         j++;
        //     }
        // }

        public bool IsPallin(string s)
        {
            var res = true;
            int i = 0;
            var maxPalin = (s.Length + 1) / 2;
            while (i < maxPalin)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
                i++;
            }

            return res;
        }
    }
}