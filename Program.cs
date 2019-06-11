using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution os = new Solution();
            Console.WriteLine(os.IsPalindrome(-11));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x == 0)
            {
                return true;
            }
            int originalNumber = x;
            int reverseNumber = 0;
            while (x > 0)
            {
                reverseNumber = (reverseNumber * 10) + x % 10;
                x = x / 10;
            }
            return reverseNumber == originalNumber;
        }
    }
}
