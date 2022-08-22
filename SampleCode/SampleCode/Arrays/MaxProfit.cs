using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Arrays
{
    internal class MaxProfit
    {
        public static int MaxProfitCalc(int[] prices)
        {
            int prevPrice = 0;
            int profit = 0;
            bool firstTime = true;

            foreach (int price in prices)
            {
                if (!firstTime)
                {
                    if (prevPrice < price)
                    {
                        profit = profit + (price - prevPrice);
                    }
                }
                prevPrice = price;
                firstTime = false;
            }

            return profit;
        }
    }
}
