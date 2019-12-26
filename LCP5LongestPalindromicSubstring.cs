using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP5_LongestPalindromicSubstring
{
    class LCP5LongestPalindromicSubstring
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string s = "babad";
            Console.WriteLine("Longest palindromic substring is : " + sol.LongestPalindrome(s));

            s = "cbbd";
            Console.WriteLine("Longest palindromic substring is : " + sol.LongestPalindrome(s));
        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            int row = 0;
            int column = 0;
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            else
            {
                int stringLength = s.Length;
                int[,] matrix = new int[stringLength, stringLength];

                //Set the zero length strings as 1
                for(int i=0; i<stringLength; i++)
                {
                    matrix[i, i] = 1;
                }
                //Check for the one length strings
                for(int j =1; j<stringLength; j++)
                {
                    int i = j - 1;
                    if(s[i] == s[j])
                    {
                        matrix[i, j] = 1;
                        row = i;
                        column = j;
                    }
                }

                //Check for the remaining strings
                for(int p=2; p<stringLength; p++)
                {
                    int j = p;
                    int i = j - p;

                    while (j < stringLength)
                    {
                        if(s[i] == s[j] && matrix[i+1, j-1] == 1)
                        {
                            matrix[i, j] = 1;
                            if(j-i > column - row)
                            {
                                column = j;
                                row = i;
                            }
                        }
                        j++;
                        i++;
                    }
                }

            }

            return s.Substring(row, column - row + 1);
        }
    }
}
