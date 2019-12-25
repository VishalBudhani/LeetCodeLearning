using System;

namespace LCP1143_LCSubsequenceMatrix
{
    class LCP1143LCSubsequenceMatrix
    {
        static void Main(string[] args)
        {
            string s1 = "abcde";
            string s2 = "ace";
            Solution s = new Solution();
            Console.WriteLine("Longest common subsequence is {0}", s.LongestCommonSubsequence(s1, s2));
            s1 = "abc";
            s2 = "abc";
            Console.WriteLine("Longest common subsequence is {0}", s.LongestCommonSubsequence(s1, s2));
            s1 = "abc";
            s2 = "def";
            Console.WriteLine("Longest common subsequence is {0}", s.LongestCommonSubsequence(s1, s2));
        }
    }

    /* The general idea for this solution is that if: 
     if s1[m] == s2[n] 
     then return 1 + LCS(s1, s2, m-1, n-1)
     else
     return Max[LCS(s1, s2, m-1, n), LCS(s1, s2, m, n-1)] */

    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            if(text1 == null || text2 == null || text1.Length == 0 || text2.Length == 0)
            {
                return 0;
            }
            int rows = text1.Length + 1;
            int columns = text2.Length + 1;

            int[,] matrix = new int[rows, columns];

            for(int i=1; i<rows; i++)
            {
                for(int j=1; j<columns; j++)
                {
                    if(text2[j-1] == text1[i-1])
                    {
                        matrix[i, j] = 1 + matrix[i - 1, j - 1];
                    }
                    else
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            return matrix[rows - 1, columns - 1];
        }
    }
}
