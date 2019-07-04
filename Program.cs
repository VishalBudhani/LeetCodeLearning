using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoListNodes
{
    class Program
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
                i+=2;
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
            var result = s.MergeTwoLists(l1, l2);
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
            result = s.MergeTwoLists(l1, l2);
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
