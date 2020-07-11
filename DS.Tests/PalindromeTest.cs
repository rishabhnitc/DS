using NUnit.Framework;
using LongestPallindrome;

namespace DS.Tests
{
    public class PallindromeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           var sol = new Solution();
           Assert.True(sol.IsPallin("abcba"));
           Assert.False(sol.IsPallin("ebcba"));
             Assert.True(sol.IsPallin("baab"));
          
        }       

        [Test]
        public void Test2()
        {
           
           var sol = new Solution();
           Assert.AreEqual("abcba",sol.LongestPalindrome("abcba"));
           var ip = "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffgggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg";
           var res = sol.LongestPalindrome(ip);

            
           Assert.AreEqual("bcb",sol.LongestPalindrome("abcbe"));
           Assert.AreEqual("bcb",sol.LongestPalindrome("abcbbe"));
           Assert.AreEqual("bab",sol.LongestPalindrome("babad"));
           Assert.AreEqual("a",sol.LongestPalindrome("a"));
           Assert.AreEqual("",sol.LongestPalindrome(""));
           Assert.AreEqual(" ",sol.LongestPalindrome(" "));
           
           Assert.AreEqual("bb",sol.LongestPalindrome("cbbd"));
          
          
        }    

         
    }
}