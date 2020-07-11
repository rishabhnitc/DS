using NUnit.Framework;
using TwoSum;

namespace DS.Tests
{
    public class TwoSumTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           var sol = new Solution();
            var res=sol.TwoSum(new []{2,7,9,11},9);
            Assert.NotNull(res);
            Assert.AreEqual(2, res.Length);
        }       

         [Test]
        public void TestThreeSum()
        {
           var sol = new Solution();
           // var res=sol.ThreeSum(new []{-1,0,1,2,-1,-4},0);
            var res=sol.ThreeSum(new []{-1,0,1,0},0);
            Assert.NotNull(res);
            
        }      
    }
}