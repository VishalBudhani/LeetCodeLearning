/*Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example 1:
Given nums = [1,1,2]
Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
It doesn't matter what you leave beyond the returned length.

Example 2:
Given nums = [0,0,1,1,1,2,2,3,3,4]
Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.
It doesn't matter what values are set beyond the returned length. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem26
{
    class LeetCodeProblem26
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            Solution s = new Solution();
            var r = s.RemoveDuplicates(ref nums);
            nums = new[] { 0,0,1,1,1,2,2,3,3,4 };
            r = s.RemoveDuplicates(ref nums);
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(ref int[] nums)
        {
            var length = 0;
            try
            {

                foreach (var item in nums)
                {
                    if (length == 0)
                    {
                        nums[length++] = item;
                    }
                    else if (nums[length - 1] != item)
                    {
                        nums[length++] = item;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return length;
        }
    }
}
