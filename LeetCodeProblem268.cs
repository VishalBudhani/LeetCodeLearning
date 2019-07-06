/*Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

Example 1:

Input: [3,0,1]
Output: 2
Example 2:

Input: [9,6,4,2,3,5,7,0,1]
Output: 8 */
using System;

namespace LeetCodeProblem268.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var r = s.MissingNumber(new[] {3, 0, 1});
            Console.WriteLine(r);
            r = s.MissingNumber(new[] {9, 6, 4, 2, 3, 5, 7, 0, 1});
            Console.WriteLine(r);
        }
    }
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int indexSum = nums.Length;
            int valSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                indexSum += i;
                valSum += nums[i];
            }
            return indexSum - valSum;
        }
    }
}
