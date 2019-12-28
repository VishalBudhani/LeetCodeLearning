using System;

namespace LCP13_RomanToInteger
{
    class LCP13RomanToInteger
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string input = "III";
            Console.WriteLine("Integer value of {0} is {1}", input, sol.RomanToInt(input));

            input = "IV";
            Console.WriteLine("Integer value of {0} is {1}", input, sol.RomanToInt(input));

            input = "IX";
            Console.WriteLine("Integer value of {0} is {1}", input, sol.RomanToInt(input));

            input = "LVIII";
            Console.WriteLine("Integer value of {0} is {1}", input, sol.RomanToInt(input));

            input = "MCMXCIV";
            Console.WriteLine("Integer value of {0} is {1}", input, sol.RomanToInt(input));

            input = "MCMXCIV";
            Console.WriteLine("Integer value of {0} is {1}", input, sol.RomanToInt(input));
        }
    }
    /*I have used switch logic as I feel switch should be efficient compared to if loops*/
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int length = s.Length;
            int result = 0;
            for(int i=0; i<length;)
            {
                switch (s[i])
                {
                    case 'V':
                        result += 5;
                        i++;
                        break;
                    case 'L':
                        result += 50;
                        i++;
                        break;
                    case 'D':
                        result += 500;
                        i++;
                        break;
                    case 'M':
                        result += 1000;
                        i++;
                        break;
                    case 'I':
                        if (i < length - 1)
                        {
                            if(s[i+1] == 'V')
                            {
                                result += 4;
                                i += 2;
                                break;
                            }
                            else if(s[i+1] == 'X')
                            {
                                result += 9;
                                i += 2;
                                break;
                            }
                        }
                        result += 1;
                        i++;
                        break;
                    case 'X':
                        if (i < length - 1)
                        {
                            if (s[i + 1] == 'L')
                            {
                                result += 40;
                                i += 2;
                                break;
                            }
                            else if (s[i + 1] == 'C')
                            {
                                result += 90;
                                i += 2;
                                break;
                            }
                        }
                        result += 10;
                        i++;
                        break;
                    case 'C':
                        if (i < length - 1)
                        {
                            if (s[i + 1] == 'D')
                            {
                                result += 400;
                                i += 2;
                                break;
                            }
                            else if (s[i + 1] == 'M')
                            {
                                result += 900;
                                i += 2;
                                break;
                            }
                        }
                        result += 100;
                        i++;
                        break;
                }
            }
            return result;
        }
    }
}
