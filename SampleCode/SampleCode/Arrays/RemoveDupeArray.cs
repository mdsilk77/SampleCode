using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Arrays
{
    internal class RemoveDupeArray
    {
        public static int[] RemoveDupes(int[] nums)
        {
            //1, 1, 1, 2, 3, 3, 4, 5, 5
            int? prevNum = null;
            int writeIndex = 0;

            foreach (int num in nums)
            {
                if (num != prevNum)
                {
                    nums[writeIndex] = num;
                    writeIndex += 1;
                }

                prevNum = num;
            }

            for (int i = writeIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }
    }
}
