//Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//Example:
//Given nums = [2, 7, 11, 15], target = 9,
//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2, 7, 11, 15};
            int target = 9;
            var result = TwoSum(arr, target);
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (dict.ContainsKey(difference))
                {
                    var index = dict[difference];
                    if (index < i)
                    {
                        result[0] = index;
                        result[1] = i;
                    }
                    else
                    {
                        result[0] = i;
                        result[1] = index;
                    }
                    break;
                }
                dict[nums[i]] = i;
            }
            return result;
        }
    }
}
