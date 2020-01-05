using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP125_ValidPalindrome
{
    class LCP125ValidPalindrome
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string inputString = "A man, a plan, a canal: Panama";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));

            inputString = "race a car";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));

            inputString = "A man, a plan, a canal: Panama;";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));

            inputString = ";";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));

            inputString = "A man, a plan, 00 a canal: Panama;";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));

            inputString = "tttppttt";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));

            inputString = "tttpp;ttt";
            Console.WriteLine("Is the given string {0} a palindrome? - {1}", inputString, sol.IsPalindrome(inputString));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int length = s.Length;
            int i = 0, j = length - 1;

            while(i < j)
            {
                if(char.IsLetterOrDigit(s[i]) && 
                    char.IsLetterOrDigit(s[j]))
                {
                    if(char.ToLower(s[i]) != char.ToLower(s[j]))
                    {
                        return false;
                    }
                    i++;
                    j--;
                    continue;
                }
                i = char.IsLetterOrDigit(s[i]) ? i : ++i;
                j = char.IsLetterOrDigit(s[j]) ? j : --j;
            }

            return true;
        }
    }
}
