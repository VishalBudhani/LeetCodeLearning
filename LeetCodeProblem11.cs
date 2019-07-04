//Merge Two Sorted Lists
//Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

//Example:

//Input: 1->2->4, 1->3->4
//Output: 1->1->2->3->4->4

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoListNodes
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode returnList = new ListNode(0);
            var current = returnList;
            while (l1 != null && l2 != null)
            {
                ListNode temp;
                if (l1.val == l2.val)
                {
                    temp = new ListNode(l1.val);
                    current.next = temp;
                    current = temp;
                    temp = new ListNode(l2.val);
                    current.next = temp;
                    current = temp;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1.val > l2.val)
                {
                    temp = new ListNode(l2.val);
                    current.next = temp;
                    current = temp;
                    l2 = l2.next;
                }
                else
                {
                    temp = new ListNode(l1.val);
                    current.next = temp;
                    current = temp;
                    l1 = l1.next;
                }
            }

            l1 = l1 ?? l2;
            current.next = l1;
            return returnList.next;
        }
    }
}
