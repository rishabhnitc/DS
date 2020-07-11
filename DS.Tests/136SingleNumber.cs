using NUnit.Framework;

using System.Collections.Generic;
using SingleNumber136;

namespace DS.Tests
{
    public class SingleNumberTests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            var sol = new Solution();

            var res = sol.SingleNumber(new[]{2,2,1});
            Assert.AreEqual(1, res);           

             res = sol.SingleNumber(new[]{4,1,2,1,2});
            Assert.AreEqual(4, res);    
        }
    }
}
