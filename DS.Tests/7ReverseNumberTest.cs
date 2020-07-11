using NUnit.Framework;
using ReverseInteger;
using System.Collections.Generic;

namespace DS.Tests
{
    public class ReverseNumberTest
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
              var sol = new Solution();

  var res = sol.Reverse(1534236469);
            Assert.AreEqual(0, res);

            var num1 = -123;
            var res1 = sol.Reverse(num1);
            Assert.AreEqual(-321, res1);
          
          
            res = sol.Reverse(342);
            Assert.AreEqual(243, res);
                            //2147483647
            

            res = sol.Reverse(-123);
            Assert.AreEqual(-321, res);

            res = sol.Reverse(120);
            Assert.AreEqual(21, res);
            //     Assert.AreEqual(2, res.Length);
        }


    }
}