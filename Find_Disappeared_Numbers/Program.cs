using System;
using System.Collections.Generic;
using System.Linq;
/*
 448. Find All Numbers Disappeared in an Array
Easy

7428

409

Add to List

Share
Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

 

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]
Example 2:

Input: nums = [1,1]
Output: [2]
 

Constraints:

n == nums.length
1 <= n <= 105
1 <= nums[i] <= n
 

Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
 
 */
namespace Find_Disappeared_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', Program.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
            Console.WriteLine(string.Join(',', Program.FindDisappearedNumbers(new int[] { 1, 1 })));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>nums Of Disapperared</returns>
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            // IList<int> numsOfDisappeared = new List<int>();
            // List<int> existedNumber = new List<int>();
            // int counter = 0;
            //int[] numsSort = nums.OrderBy(x => x).ToArray();
            // foreach (var num in numsSort)
            // {
            //     counter++;
            //     if (counter!=num || ) numsOfDisappeared.Add(counter);

            //     else 
            //        existedNumber.Add(num);
            // }
            // return numsOfDisappeared;

            var res = new HashSet<int>(Enumerable.Range(1, nums.Length));
            foreach (var item in nums)
                res.Remove(item);
            return res.ToArray();
        }
    }
}
