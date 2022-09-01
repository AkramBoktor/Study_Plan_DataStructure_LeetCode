/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
 

Constraints:

1 <= prices.length <= 105
0 <= prices[i] <= 104
*/

using System;
using System.Collections;

namespace Best_ime_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', Program.MaxProfit(new int[] { 7, 1, 6, 5 })));
            Console.WriteLine(string.Join(',', Program.MaxProfit(new int[] { 5, 2, 2, 1 })));
            Console.WriteLine(string.Join(',', Program.MaxProfit(new int[] { 3, 1, 2, 1 })));

        }


        public static int MaxProfit(int[] prices)
        { // Time executed Limited
            /*
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if(prices[j] > prices[i]&& maxProfit < prices[j] - prices[i])
                    {
                        maxProfit = prices[j] - prices[i];
                    }
                }
            }
            return maxProfit;
            */
            int maxProfit = 0;
            int minValue = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if(prices[i] < minValue)
                {
                    minValue = prices[i];
                }else if (prices[i] - minValue > maxProfit)
                {
                    maxProfit = prices[i]-minValue;
                }
            }

            return maxProfit;
        }

    }
}