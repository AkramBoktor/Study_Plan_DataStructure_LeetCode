using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { }, 0)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 1 }, 1)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 2, 2 }, 2)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 1, 3 }, 1)));
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            if(nums.Length==0) return new int[] { -1,-1 };

            int mid = (nums[0] + nums[nums.Length-1])/2;
            List<int> result = new List<int>();
            int position = 0;
            if(mid < target)
            {
                for (position = Array.IndexOf(nums,mid); position < nums.Length; position++)
                {
                    if(nums[position] == target) result.Add(position);

                }
            }
            else if(mid == target)
            {
                for (position = 0; position < nums.Length; position++)
                {
                    if (nums[position] == target) result.Add(position);

                }
            }
            else
            {
                for (position = 0; position <= Array.IndexOf(nums, mid); position++)
                {
                    if (nums[position] == target) result.Add(position);

                }
            }
           
            return result.Count == 0 ? new int[] { -1, -1 } : result.Count==1? new int[] { 0, 0 }: result.ToArray();
        }
    }
}
