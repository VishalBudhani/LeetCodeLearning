using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP746_MinCostClimbingStairs
{
    class LCP746MinCostClimbingStairs
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] cost = new int[] {10,15,20 };
            Console.WriteLine("Minimum cost is: {0}", s.MinCostClimbingStairs(cost));

            cost = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            Console.WriteLine("Minimum cost is: {0}", s.MinCostClimbingStairs(cost));

            cost = new int[] { 0, 0, 1, 1 };
            Console.WriteLine("Minimum cost is: {0}", s.MinCostClimbingStairs(cost));
        }
    }
    public class Solution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if(cost == null || cost.Length == 0)
            {
                return 0;
            }
            int length = cost.Length;
            if (cost.Length == 1)
            {
                return cost[0];
            }

            int[] finalCost = new int[length];
            finalCost[0] = cost[0];
            finalCost[1] = cost[1];

            for(int i=2; i<length; i++)
            {
                finalCost[i] = cost[i] + Math.Min(finalCost[i - 1], finalCost[i - 2]);
            }

            return Math.Min(finalCost[finalCost.Length - 1], finalCost[finalCost.Length - 2]);
        }
    }
}
