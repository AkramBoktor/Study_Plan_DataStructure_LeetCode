/*
 Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
 */

using System.Collections;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.ContainsDuplicate(new int[] { 1, 2, 3, 4, 2 }));
            Console.WriteLine(Program.ContainsDuplicate(new int[] { 1, 2, 3, 4}));
        }

        
        public static bool ContainsDuplicate(int[] nums)
        {
            /* Solution Depended in LINQ
             var duplicatied = nums.GroupBy(number => number).Where(g => g.Count() > 1).ToList();
            return duplicatied.Count() != 0 ? true : false;
            
             */
            /* Hast set */
            HashSet<int> uniqueNumber = new HashSet<int>();
            foreach (var num in nums)
            {
                uniqueNumber.Add(num);
            }
            return uniqueNumber.Count() != nums.Count() ? true : false;

         
        }
    }
}

/********************* Solutions ********************/
/* another way for HastSet */
/*HashSet<int> hash = new HashSet<int>();
foreach (var item in nums)
{
    if (hash.Contains(item))
        return true;
    else
        hash.Add(item);
}

return false;*/

/* HashTable 
Hashtable hashT = new Hashtable();

foreach (var item in nums)
    if (hashT.Contains(item))
        return true;
    else
        hashT.Add(item, null);

return false;*/