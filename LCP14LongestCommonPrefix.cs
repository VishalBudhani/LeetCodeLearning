using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP14_LongestCommonPrefix
{
    class LCP14LongestCommonPrefix
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] input = new string[] { "flower", "flow", "flight" };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { "dog", "racecar", "car" };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { "flower" };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { "" };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { "  " , "  "};
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { "flower", "flower ", "flower" };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));

            input = new string[] { "flower  ", "flower  ", "flower  " };
            Console.WriteLine("Longest common prefix is: {0}", s.LongestCommonPrefix(input));
        }
    }

    /// <summary>
    /// I have used the vertical approach to solve the problem
    /// </summary>
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;
            if(strs == null || strs.Length == 0)
            {
                return result;
            }
            if(strs.Length == 1)
            {
                return strs[0];
            }

            bool flag = true;
            int index = 0;
            while (flag)
            {                
                char t = '\0';
                for(int i=0; i<strs.Length; i++)
                {
                    if(strs[i].Length > index)
                    {
                        if (i == 0)
                        {
                            t = strs[i][index];
                        }
                        else if(strs[i][index] != t)
                        {
                            t = '\0';
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        t = '\0';
                        flag = false;
                        break;
                    }                    
                }
                if( t!= '\0')
                {
                    result += t;
                }                
                index++;
            }
            return result;
        }
    }
}
