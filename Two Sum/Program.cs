/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/

using System.Collections;
using System;
namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",",Program.TwoSum(new int[] { 5, 4, -1, 7, 8 },9)));
            Console.WriteLine(String.Join(",", Program.TwoSum(new int[] { 4, -1, 2, 1 }, 6)));
            Console.WriteLine(String.Join(",", Program.TwoSum(new int[] { 3,2,4}, 6)));
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new int[] { i, dic[target - nums[i]] };
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }

            return new int[2];

            /* my solution */
            /* if (nums.Length == 1 || nums.Length == 0) return Array.Empty<int>();
             int [] result = new int[2];
             int subTargetNum = 0;
             for (int i = 0; i < nums.Length; i++)
             {
                 subTargetNum = target - nums[i];
                 //for this situation { 3,2,4}, 6))  6-3 = 3 when make check if exists will retieve first element
                 if (nums.Contains(subTargetNum) && Array.IndexOf(nums, subTargetNum)!=i )
                 {
                     result[0] = i;
                     result[1] =Array.IndexOf( nums, subTargetNum );
                     break;
                 }
                 subTargetNum = 0;
             }

             return result;
             */
        }
    }
}