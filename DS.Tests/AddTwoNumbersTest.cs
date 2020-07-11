using NUnit.Framework;
using AddTwoNumbers;
using System.Collections.Generic;

namespace DS.Tests
{
    public class TwoNumbersList
    {
        [SetUp]
        public void Setup()
        {
        }

        private ListNode createList1(int num)
        {
            if(num == 0)
            {
                return new ListNode(0, null);
            }
            var res = num;            
            ListNode node = null;
            ListNode last= null;
            while (res > 0)
            {
                
                num = res %10;
                var n = new ListNode(num, null);                             
                if(node == null)
                {
                    node = n;
                }
                if(last != null)
                {
                    last.next = n;
                }

                last =n;               
                
                res = res/10;
            }

            return node;
        }


        [Test]
        public void Test1()
        {
            var num1 = 342;
            var l1 = createList1(num1);

            var num2 = 465;
            var l2 = createList1(num2);


            var sol = new AddTwoNumbers.Solution();
            var res=sol.AddTwoNumbers(l1,l2);
            Assert.IsTrue(false);
            //     Assert.AreEqual(2, res.Length);
        }


    }
}