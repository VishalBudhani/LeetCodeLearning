using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem74_SearchA2DMatrix
{
    class LCP74_SearchA2DMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4] {
                { 1, 3, 5, 7 },
                { 10, 11, 16, 20 },
                { 23, 30, 34, 50} };
            new Solution().SearchMatrix(matrix, 16);
            new Solution().SearchMatrix(new int[0, 0], 16);
        }
    }
    public class Solution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            bool result = false;
            if (matrix == null)
            {
                return result;
            }
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int rowIndex = -1;
            for (int i = 0; i < rows; i++)
            {
                if (target == matrix[i, 0] || target > matrix[i, 0])
                {
                    rowIndex++;
                }
                else
                {
                    break;
                }
            }
            if (rowIndex > -1)
            {
                if (target <= matrix[rowIndex, columns - 1])
                {
                    int low = 0;
                    int high = columns - 1;

                    //Binary Search Block
                    while (true)
                    {
                        if (high >= low)
                        {
                            int mid = (low + high) / 2;
                            if (target == matrix[rowIndex, mid])
                            {
                                result = true;
                                break;
                            }
                            else if (target > matrix[rowIndex, mid])
                            {
                                low = mid + 1;
                            }
                            else
                            {
                                high = mid - 1;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    //Binary search block ends here
                }
            }
            return result;
        }
    }
}
