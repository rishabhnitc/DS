using NUnit.Framework;

using System.Collections.Generic;
using PowerSet78;

namespace DS.Tests
{
    public class PowerSetTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();

            var res = sol.Subsets(new[] { 1 });
            Assert.AreEqual(2, res.Count);

            res = sol.Subsets(new[] { 1, 2, 3 });
            Assert.AreEqual(3, res);

            // var res = sol.HammingWeight(00000000000000000000000000001011);                                        
            // Assert.AreEqual(3, res);
        }


    }
}