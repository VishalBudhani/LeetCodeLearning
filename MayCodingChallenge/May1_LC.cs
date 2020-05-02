using System;

namespace May1_LC
{
    class May1_LC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            s.FirstBadVersion(2126753390);
        }
    }

    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int lowCount = 1;
            int highCount = n;

            if (lowCount == highCount)
                return lowCount;

            while (lowCount <= highCount)
            {
                int mid = lowCount + ((highCount - lowCount) / 2);
                if (IsBadVersion(mid))
                {
                    if ((mid - 1 > 0) && !IsBadVersion(mid - 1))
                        return mid;
                    highCount = mid - 1;
                }
                else
                {
                    lowCount = mid + 1;
                    if (lowCount > highCount)
                        return highCount;

                }
            }
            return lowCount;
        }
    }
    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            if (version == 1702766719)
                return true;
            return false;
        }
    }
}
