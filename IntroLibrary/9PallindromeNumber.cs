using System.Collections.Generic;
using System;
using System.Linq;

namespace PallindromeNumber9
{

    //https://leetcode.com/problems/palindrome-number/

    public class Solution
    {
        // public bool IsPalindrome(int x)
        // {
        //     if(x<0)
        //     {
        //         return false;
        //     }

        //     if(x <10)
        //     {
        //         return true;
        //     }
        //     List<int> digits = new List<int>();

        //     while (x != 0)
        //     {
        //         var pop = x % 10;
        //         digits.Add(pop);
        //         x = x / 10;
        //     }
        //     var mid = digits.Count / 2;
        //     var count = digits.Count;
        //     for (int i = 0; i <= mid; i++)
        //     {
        //         if (digits[i] != digits[count - 1 - i])
        //         {
        //             return false;
        //         }
        //     }

        //     return true;

        // }

         public bool IsPalindrome(int x)
        {
            if(x<0 || x%10==0 )
            {
                return false;
            }

            if(x <10)
            {
                return true;
            }
            
            var num =0;
            

            while (num <x)
            {
                var pop = x % 10;
                x = x/10;
                num = num*10 + pop;
              
            }
            

            return num == x || num/10 == x;

        }




    }
}