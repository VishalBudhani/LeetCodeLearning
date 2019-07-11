/*Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
If the last word does not exist, return 0.
Note: A word is defined as a character sequence consists of non-space characters only.
Example:
Input: "Hello World"
Output: 5 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem58
{
    class LeetCodeProblem58
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var t = s.LengthOfLastWord("m");
            t = s.LengthOfLastWord("m     mmmmm     ");
            t = s.LengthOfLastWord("Hello World");
            t = s.LengthOfLastWord("        H");

        }
    }
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int result = 0;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && result > 0)
                {
                    return result;
                }
                if(s[i] != ' ')
                {
                    result++;
                }
            }
            return result;
        }
    }
}
