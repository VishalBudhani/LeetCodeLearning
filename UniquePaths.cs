using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP62UniquePaths
{
    class UniquePaths
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
            if(m == 0 || n == 0)
            {
                return 0;
            }
            int[,] inputMatrix = new int[m, n];
            for(int i=0; i<m; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(i==0 || j == 0)
                    {
                        inputMatrix[i, j] = 1;
                    }
                    else
                    {
                        inputMatrix[i, j] = inputMatrix[i - 1, j] + inputMatrix[i, j - 1];
                    }
                }
            }
            return inputMatrix[m - 1, n - 1];
        }
    }
}
