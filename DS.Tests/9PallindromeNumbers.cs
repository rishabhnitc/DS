using NUnit.Framework;

using System.Collections.Generic;
using PallindromeNumber9;

namespace DS.Tests
{
    public class PallindromeNumberTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();

            var res = sol.IsPalindrome(121);
            Assert.IsTrue(res);

            res = sol.IsPalindrome(10);
            Assert.IsFalse(res);

            res = sol.IsPalindrome(100);
            Assert.IsFalse(res);

            res = sol.IsPalindrome(-121);
            Assert.IsFalse(res);
        }
    }
}