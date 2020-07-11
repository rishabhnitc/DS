using NUnit.Framework;
using LongestSubSeq;

namespace DS.Tests
{
    public class LongestSubSeqTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sol = new Solution();
            // var res = sol.LengthOfLongestSubstring("");
            // Assert.AreEqual(0, res);

             var res = sol.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(3, res);

            res = sol.LengthOfLongestSubstring(" ");
            Assert.AreEqual(1, res);

            res = sol.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, res);

              res = sol.LengthOfLongestSubstring("tmmzuxt");
            Assert.AreEqual(5, res);


            res = sol.LengthOfLongestSubstring("abba");
            Assert.AreEqual(2, res);


            res = sol.LengthOfLongestSubstring("dvdf");
            Assert.AreEqual(3, res);
          

            res = sol.LengthOfLongestSubstring("bbbbb");
            Assert.AreEqual(1, res);

           

        }
    }
}