using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Arrays
{
    internal class SingleNumber
    {
        public static int NonDupeNumber(int[] nums)
        {
            int returnNum = -30001;

            int[] sortedAr = nums;

            Array.Sort(sortedAr);

            for (int i = 0; i < sortedAr.Length - 1; i++)
            {
                if (i == 0)
                {
                    if (!(sortedAr[i] == sortedAr[i + 1]))
                    {
                        returnNum = sortedAr[i];
                    }
                }
                else
                {
                    if (!(sortedAr[i] == sortedAr[i - 1]) && !(sortedAr[i] == sortedAr[i + 1]))
                    {
                        returnNum = sortedAr[i];
                    }
                }
            }

            if (returnNum == -30001)
            {
                returnNum = nums[nums.Length - 1];
            }
            return returnNum;
        }
    }
}
