using NUnit.Framework;

using System.Collections.Generic;
using StepsTopZero1342;

namespace DS.Tests
{
    public class StepsToZeroTests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();

            var res = sol.NumberOfSteps(14);
            Assert.AreEqual(6, res);           
        }
    }
}