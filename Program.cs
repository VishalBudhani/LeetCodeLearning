/*Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.*/


using System;
using System.Collections.Generic;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution os = new Solution();
            //Console.WriteLine(os.IsValid("()"));
            //Console.WriteLine(os.IsValid("([])"));
            //Console.WriteLine(os.IsValid("({[{}]})"));
            //Console.WriteLine(os.IsValid("()()"));
            //Console.WriteLine(os.IsValid("(){"));
            //Console.WriteLine(os.IsValid("(]][[)"));
            //Console.WriteLine(os.IsValid("([)"));
            Console.WriteLine(os.IsValid("()[]{}"));
            Console.WriteLine(os.IsValid("(]"));
            Console.WriteLine(os.IsValid("([)]"));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> keyDict = new Dictionary<char, char>();
            keyDict.Add(')','(');
            keyDict.Add(']', '[');
            keyDict.Add('}', '{');

            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            Stack<char> storageStack = new Stack<char>();
            foreach (char c in s)
            {
                if (!keyDict.ContainsKey(c))
                {
                    storageStack.Push(c);
                }
                else
                {
                    if (storageStack.Count == 0)
                    {
                        return false;
                    }
                    if (storageStack.Pop() != keyDict[c])
                    {
                        return false;
                    }
                }
            }
            return storageStack.Count == 0;
        }
    }
}
