using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP17_PhoneNumberLetterCombination
{
    class LCP17PhoneNumberLetterCombination
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string input = "2";
            IList<string> result = s.LetterCombinations(input);
            PrintCombinations(input, result);

            input = "23";
            result = s.LetterCombinations(input);
            PrintCombinations(input, result);

            input = "234";
            result = s.LetterCombinations(input);
            PrintCombinations(input, result);

            input = "23456789";
            result = s.LetterCombinations(input);
            PrintCombinations(input, result);
        }

        private static void PrintCombinations(string input, IList<string> result)
        {
            Console.Write("For input {0} output combinations are as: ", input);
            foreach(var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> resultSet = new List<string>();
            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict.Add('2', "abc");
            dict.Add('3', "def");
            dict.Add('4', "ghi");
            dict.Add('5', "jkl");
            dict.Add('6', "mno");
            dict.Add('7', "pqrs");
            dict.Add('8', "tuv");
            dict.Add('9', "wxyz");
            return GenerateCombinations(resultSet, digits, 0, dict);
        }

        private IList<string> GenerateCombinations(IList<string> resultSet, string digits, int index, Dictionary<char, string> keyDict)
        {
            if(index > digits.Length - 1)
            {
                return resultSet;
            }
            IList<string> intermediateList = resultSet;
            resultSet = new List<string>();
            string availableString = keyDict[digits[index]];
            if (intermediateList.Count == 0)
            {                
                for(int i=0; i<availableString.Length; i++)
                {
                    resultSet.Add(availableString[i].ToString());
                }
            }
            else
            {
                for(int p=0; p<intermediateList.Count; p++)
                {
                    for (int i = 0; i < availableString.Length; i++)
                    {
                        resultSet.Add((intermediateList[p] + availableString[i]).ToString());
                    }
                }
            }
            intermediateList = null;            
            return GenerateCombinations(resultSet, digits, index + 1, keyDict);
        }
    }
}
