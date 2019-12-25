using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP718_MaxLengthOfRepeatedSubarray
{
    class MaxLengthOfRepeatedSubarray
    {
        static void Main(string[] args)
        {
            string A = "12321";
            string B = "32147";
            Solution s = new Solution();
            Console.WriteLine("Longest repeated subarray is: {0}", s.FindLength(A, B));
            A = "GeeksforGeeks";
            B = "GeeksQuiz";
            Console.WriteLine("Longest repeated subarray is: {0}", s.FindLength(A, B));
            A = "abcdxyz";
            B = "xyzabcd";
            Console.WriteLine("Longest repeated subarray is: {0}", s.FindLength(A, B));
            A = "zxabcdezy";
            B = "yzabcdezx";
            Console.WriteLine("Longest repeated subarray is: {0}", s.FindLength(A, B));
        }
    }

    /* Simple idea behind the implementation is 
     if(s1[m] == s1[n] 
     return 1 + LCS(s1, s2, m-1, n-1)
     else return 0 */
    public class Solution
    {
        public int FindLength(string A, string B)
        {
            if (A == null || B == null || A.Length == 0 || B.Length == 0)
            {
                return 0;
            }

            int rows = B.Length + 1;
            int columns = A.Length + 1;
            int maxLength = 0;

            int[,] matrix = new int[rows, columns];
            for(int i=1; i<rows; i++)
            {
                for(int j=1; j<columns; j++)
                {
                    if(B[i-1] == A[j - 1])
                    {
                        matrix[i, j] = 1 + matrix[i - 1, j - 1];
                        maxLength = (matrix[i, j] > maxLength) ? matrix[i, j] : maxLength; 
                    }
                }
            }
            return maxLength;
        }
    }
}
