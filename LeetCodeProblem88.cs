/*88. Merge Sorted Array

Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

Note:

The number of elements initialized in nums1 and nums2 are m and n respectively.
You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
Example:

Input:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

Output: [1,2,2,3,5,6]
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem88
{
    class LeetCodeProblem88
    {
        static void Main(string[] args)
        {

        }
    }
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, p = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[p--] = nums1[i--];
                }
                else
                {
                    nums1[p--] = nums2[j--];
                }
            }

            //If i is greater than zero, no need to check that as we are inserting in mums1 array
            //Only check for j gretaer than zero condition

            if (j >= 0)
            {
                while (j >= 0)
                {
                    nums1[p--] = nums2[j--];
                }
            }
        }
    }
}
