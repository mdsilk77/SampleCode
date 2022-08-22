using SampleCode.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Arrays
{
    internal class ArrayRunner
    {
        public void RunArrayTests()
        {

            int romanNum = RomanNumerals.RomanToInt("III");
            Console.WriteLine(romanNum);
            Console.WriteLine("\n");

            int[] dupeNums = { 1, 1, 1, 2, 3, 3, 4, 5, 5 };
            Array noDupes = RemoveDupeArray.RemoveDupes(dupeNums);
            foreach (int num in noDupes)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");

            //int[] prices = { 7, 1, 5, 3, 6, 4 };
            //int[] prices = { 1, 2, 3, 4, 5 };
            //int[] prices = { 7, 6, 4, 3, 1 };
            int[] prices = { 2, 1, 2, 0, 1 };
            int maxProfit = MaxProfit.MaxProfitCalc(prices);
            Console.WriteLine("The max profit is $" + maxProfit);
            Console.WriteLine("\n");

            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] returnArray = RotateArray.Rotate(nums, 3);
            foreach (int value in returnArray)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("\n");

            int[] dupes = { 1 };
            int nonDupe = SingleNumber.NonDupeNumber(dupes);
            Console.WriteLine(nonDupe);
        }
    }
}
