/*83. Remove Duplicates from Sorted List
Given a sorted linked list, delete all duplicates such that each element appear only once.
Example 1:
Input: 1->1->2
Output: 1->2
Example 2:
Input: 1->1->2->3->3
Output: 1->2->3 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblem83
{
    class LeetCodeProblem83
    {
        static void Main(string[] args)
        {
            ListNode temp = null;
            ListNode l1 = new ListNode(1);
            ListNode current = l1;
            ListNode l2 = new ListNode(1);
            ListNode current2 = l2;
            int i = 1;
            while (i <= 2)
            {
                temp = new ListNode(i);
                current.next = temp;
                current = temp;
                i += 1;
            }
            i = 1;
            while (i <= 4)
            {
                temp = new ListNode(i);
                current2.next = temp;
                current2 = temp;
                if (i == 2 || i == 3)
                {
                    temp = new ListNode(i);
                    current2.next = temp;
                    current2 = temp;
                }
                i += 1;
            }

            Solution s = new Solution();
            var result = s.DeleteDuplicates(l1);
            result = s.DeleteDuplicates(l2);
            
        }
    }
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            if (head == null)
                return head;
            while (current.next != null)
            {
                //if current node value is not equal to next node val
                if (current.next.val != current.val)
                {
                    current = current.next;
                }
                else 
                // if current node value is equal to the next node value
                // skip the node next to the current node and point the current node to the node after that
                {
                    current.next = current.next.next;
                }
            }
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
