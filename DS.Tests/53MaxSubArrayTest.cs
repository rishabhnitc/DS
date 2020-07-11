using NUnit.Framework;

using System.Collections.Generic;
using MaxSubArray53;

namespace DS.Tests
{
    public class MaxSubArrayTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();

            var res = sol.MaxSubArraySum(new[] { 8, -19, 5, -4, 20 });
            Assert.AreEqual(21, res);
            var res2 = sol.MaxSubArray(new[] { 8, -19, 5, -4, 20 });
            Assert.AreEqual(new[] { 5, -4, 20 }, res2);


            res = sol.MaxSubArraySum(new[] { 0 });
            Assert.AreEqual(0, res);
            res2 = sol.MaxSubArray(new[] {0 });
            Assert.AreEqual(new[] { 0 }, res2);

            res = sol.MaxSubArraySum(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.AreEqual(6, res);
            res2 = sol.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.AreEqual(new[] { 4, -1, 2, 1 }, res2);
        }
    }
}