using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Arrays
{
    internal class RotateArray
    {
        public static int[] Rotate(int[] nums, int k)
        {
            int[] returnArray = new int[nums.Length];

            if (k <= nums.Length && k > 0)
            {
                for (int i = 0; nums.Length - k + i < nums.Length; i++)
                {
                    returnArray[i] = nums[nums.Length - k + i];
                }

                int j = 0;
                for (int i = k; i < nums.Length; i++)
                {
                    returnArray[i] = nums[j];
                    j++;
                }
            }
            else
            {
                Console.WriteLine($"The value to rotate {k} is larger the the array length of {nums.Length}");
            }
            nums = returnArray;
            return nums;
        }

    }
}
