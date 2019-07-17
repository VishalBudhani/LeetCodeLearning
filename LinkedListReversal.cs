using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReversal
{
    class LinkedListReversal
    {
        static void Main(string[] args)
        {
            ListNode temp = null;
            ListNode l1 = new ListNode(1);
            ListNode current = l1;
            ListNode l2 = new ListNode(1);
            ListNode current2 = l2;
            int i = 2;
            while (i <= 4)
            {
                temp = new ListNode(i);
                current.next = temp;
                current = temp;
                i += 2;
            }
            i = 3;
            while (i <= 4)
            {
                temp = new ListNode(i);
                current2.next = temp;
                current2 = temp;
                i += 1;
            }

            Solution s = new Solution();
            var result = s.ReverseLinkedList(l1);
            result = s.ReverseLinkedList(l2);
            l1 = new ListNode(5);
            l2 = new ListNode(1);
            current2 = l2;
            i = 2;
            while (i <= 4)
            {
                temp = new ListNode(i);
                current2.next = temp;
                current2 = temp;
                i += 1;
            }
            result = s.ReverseLinkedList(l1);
            result = s.ReverseLinkedList(l2);
        } 
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseLinkedList(ListNode l1)
        {
            ListNode current = l1;
            ListNode previous = null;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
    }
}
