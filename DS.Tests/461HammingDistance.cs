using NUnit.Framework;

using System.Collections.Generic;
using HammingDistance461;

namespace DS.Tests
{
    public class HammingDistanceTests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();

            var res = sol.HammingDistance(1,4);
            Assert.AreEqual(2, res);           

             res = sol.HammingDistance(5,10);
            Assert.AreEqual(4, res);    
        }
    }
}
