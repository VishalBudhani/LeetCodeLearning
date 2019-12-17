/*A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
The robot can only move either down or right at any point in time. 
The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
How many possible unique paths are there? Note: m and n will be at most 100.

Example 1:

Input: m = 3, n = 2
Output: 3
Explanation:
From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Right -> Down
2. Right -> Down -> Right
3. Down -> Right -> Right
Example 2:

Input: m = 7, n = 3
Output: 28*/

using System;

namespace LCP62UniquePaths
{
    class LCP62UniquePaths
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("Total paths for rows {0} and columns {1} are: {2}", 3, 2, sol.UniquePaths(3, 2));
            Console.WriteLine("Total paths for rows {0} and columns {1} are: {2}", 7, 3, sol.UniquePaths(7, 3));
            Console.WriteLine("Total paths for rows {0} and columns {1} are: {2}", 0, 2, sol.UniquePaths(0, 2));
            Console.WriteLine("Total paths for rows {0} and columns {1} are: {2}", 3, 0, sol.UniquePaths(3, 0));
            Console.WriteLine("Total paths for rows {0} and columns {1} are: {2}", 1, 1, sol.UniquePaths(3, 2));
            Console.WriteLine("Total paths for rows {0} and columns {1} are: {2}", 1, 1, sol.UniquePaths(3, 3));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            if (m <= 0 || n <= 0)
            {
                return 0;
            }
            int[,] inputMatrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                inputMatrix[i, 0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                inputMatrix[0, j] = 1;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    inputMatrix[i, j] = inputMatrix[i - 1, j] + inputMatrix[i, j - 1];
                }
            }
            return inputMatrix[m - 1, n - 1];
        }
    }
}
