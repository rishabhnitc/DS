using NUnit.Framework;

using System.Collections.Generic;
using OneBits191;

namespace DS.Tests
{
    public class HammingWeightTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();
var res = sol.HammingWeight(11);                                        
            Assert.AreEqual(3, res);

            // var res = sol.HammingWeight(00000000000000000000000000001011);                                        
            // Assert.AreEqual(3, res);
        }


    }
}