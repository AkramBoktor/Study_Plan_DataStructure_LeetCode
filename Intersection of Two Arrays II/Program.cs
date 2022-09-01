/*
 Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

 

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted.
*/

using System;
using System.Collections;

namespace Intersection_of_Two_ArraysII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', Program.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })));
            Console.WriteLine(string.Join(',', Program.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2 })));
            Console.WriteLine(string.Join(',', Program.Intersect(new int[] {3,1,2 }, new int[] { 1,1 })));
            Console.WriteLine(string.Join(',', Program.Intersect(new int[] { 1, 2 }, new int[] {1,1})));
            Console.WriteLine(string.Join(',',Program.Intersect(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })));
        }


        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> intersectArray = new List<int>();
            if (nums1.Length <= nums2.Length)
            {
                foreach (var item in nums1)
                {
                    if (nums2.Contains(item))
                    {
                        intersectArray.Add(item);
                        nums2 = nums2.Where((source, index) => index != Array.IndexOf(nums2, item)).ToArray();
                    }
                }

            }
            else
            {
                foreach (var item in nums2)
                {
                    if (nums1.Contains(item))
                    {
                        intersectArray.Add(item);
                        nums1 = nums1.Where((source, index) => index != Array.IndexOf(nums1, item)).ToArray();

                    }
                }
            }

            return intersectArray.ToArray();

            //var numAndCount1 = new Dictionary<int, int>();

            //foreach (var num in nums1)
            //{
            //    if (!numAndCount1.ContainsKey(num)) numAndCount1[num] = 0;

            //    numAndCount1[num]++;
            //}

            //var result = new List<int>();

            //foreach (var num in nums2)
            //{
            //    if (numAndCount1.ContainsKey(num) && numAndCount1[num] > 0)
            //    {
            //        result.Add(num);

            //        numAndCount1[num]--;
            //    }
            //}

            //return result.ToArray();
        }
    }
}