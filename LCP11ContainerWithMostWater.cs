/*Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). 
 * n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
 * Find two lines, which together with x-axis forms a container, such that the container contains the most water.
 *Note: You may not slant the container and n is at least 2. 
 *Two pointer approach has been utilized in solving this problem. */

using System;

namespace LCP11_ContainerWithMostWater
{
    class LCP11ContainerWithMostWater
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2 };
            Solution s = new Solution();
            Console.WriteLine(string.Format("Maximum computed area is: {0}", s.MaxArea(a)));
        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maximumArea = -1;
            int i = 0; //Lowest index
            int j = height.Length - 1; //highest index
            while (i < j)
            {
                if(maximumArea == -1)
                {
                    maximumArea = (j - i) * ((height[i] > height[j]) ? height[j] : height[i]);
                }
                else
                {
                    int computedArea;
                    if (height[i] == height[j])
                    {
                        j--;
                        computedArea = (j - i) * ((height[i] > height[j]) ? height[j] : height[i]);
                        maximumArea = (maximumArea > computedArea) ? maximumArea : computedArea;
                    }
                    else
                    {
                        if (height[i] > height[j])
                            j--;
                        else if (height[j] > height[i])
                            i++;
                        else
                        {
                            if (height[i + 1] < height[j - 1])
                                i++;
                            else
                                j--;
                        }
                        computedArea = (j - i) * ((height[i] > height[j]) ? height[j] : height[i]);
                        maximumArea = (maximumArea > computedArea) ? maximumArea : computedArea;
                    }
                }
            }
            return maximumArea;
        }
    }
}
