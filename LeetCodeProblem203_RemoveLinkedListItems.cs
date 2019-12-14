using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_203_RemoveLinkedListItems
{
    class RemoveLinkedListItems
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(2);
            node.next = new ListNode(2);
            ListNode detectedNode = new Solution().RemoveElements(node, 2);
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if(head == null)
            {
                return null;
            }
            ListNode current = head;
            ListNode prev = null;
            while(current != null)
            {
                if (current.val != val)
                {
                    if (prev == null)
                    {
                        head = current;
                    }
                    else
                    {
                        prev.next = current;                        
                    }
                    prev = current;
                }

                if (current.val == val && prev != null)
                {
                    prev.next = current.next;
                }

                current = current.next;

            }

            return (prev == null) ? null : head;
        }
    }
}
