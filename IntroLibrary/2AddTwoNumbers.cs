
using System.Collections.Generic;

namespace AddTwoNumbers
{


    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;

            ListNode head = new ListNode(0, null);
            ListNode previous = head;

            while (l1 != null || l2 != null)
            {

                var x = l1?.val ?? 0;
                var y = l2?.val ?? 0;

                var sum = x + y + carry;
                var rem = sum % 10;
                carry = sum > 9 ? 1 : 0;

                
                previous.next =new ListNode(sum, null);

                 previous = previous.next;



                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }
            if (carry > 0)
            {
                previous.next = new ListNode(1, null);
            }
            return head.next;

        }


    }
}