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
