/*Given a sorted array nums, remove the duplicates in-place such that duplicates appeared at most twice and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example 1:

Given nums = [1,1,1,2,2,3],

Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.

It doesn't matter what you leave beyond the returned length.
Example 2:

Given nums = [0,0,1,1,1,1,2,3,3],

Your function should return length = 7, with the first seven elements of nums being modified to 0, 0, 1, 1, 2, 3 and 3 respectively.

It doesn't matter what values are set beyond the returned length.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem80
{
    class LeetCodeProblem80
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.RemoveDuplicates(new[] {1, 1, 1, 2, 2, 3});
            s.RemoveDuplicatesOptimized(new[] {1, 1, 1, 2, 2, 3});
            s.RemoveDuplicates(new[] {0, 0, 1, 1, 1, 1, 2, 3, 3});
            s.RemoveDuplicatesOptimized(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 });
        }
    }
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int count = 1;
            int dupCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    dupCount++;
                    if (dupCount <= 2)
                    {
                        nums[count++] = nums[i];
                    }
                }
                else
                {
                    dupCount = 1;
                    nums[count++] = nums[i];
                }
            }
            return count;
        }

        public int RemoveDuplicatesOptimized(int[] nums)
        {
            if (nums.Length <=2)
                return nums.Length;

            int count = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[count - 2])
                {
                    nums[count++] = nums[i];
                }
            }
            return count;
        }
    }

}
