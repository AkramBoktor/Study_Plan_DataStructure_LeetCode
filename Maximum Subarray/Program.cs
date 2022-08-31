/*
 *Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

A subarray is a contiguous part of an array.

 

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
Example 2:

Input: nums = [1]
Output: 1
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
*/

using System.Collections;

namespace Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));
            Console.WriteLine(Program.MaxSubArray(new int[] { 4, -1, 2, 1 }));
        }


        public static int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int sumMax = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <  sumMax + nums[i])
                {
                    sumMax = sumMax + nums[i];
                }
                else
                {
                    sumMax = nums[i];
                }
                max = max < sumMax ? sumMax : max;

            }
            return max;


        }
    }
}