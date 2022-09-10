/*
 Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

 

Example 1:

Input: s = "leetcode"
Output: 0
Example 2:

Input: s = "loveleetcode"
Output: 2
Example 3:

Input: s = "aabb"
Output: -1
 

Constraints:

1 <= s.length <= 105
s consists of only lowercase English letters.

*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace First_Unique_Character_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.FirstUniqChar("leetcode"));
            Console.WriteLine(Program.FirstUniqChar("loveleetcode"));
            Console.WriteLine(Program.FirstUniqChar("aabb"));
        }


        public static int FirstUniqChar(string s)
        {
            //int flag = 0;
            //// TODO not working with unique index 0
            //for (int i = 0; i < s.Length; i++)
            //{
            //     flag = 0;
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if(s[i] == s[j] && i != j)
            //        {
            //            flag = 1;
            //            break;
            //        }

            //    }

            //    if(flag == 0)
            //    {
            //        return i;
            //    }
            //}

            //return -1;


            ///////////////// solution 2
            IDictionary<string, int> maxDictionaries = new Dictionary<string, int>();

            foreach (var ch in s)
            {
                if (maxDictionaries.ContainsKey(ch.ToString()))
                {
                    maxDictionaries[ch.ToString()]++;
                }
                else
                {
                    maxDictionaries.Add(ch.ToString(), 1);
                }
            }
            var UniqueValues = maxDictionaries.Select(m => m).Where(k => k.Value.Equals(1)).ToList().FirstOrDefault();
            var UniqueValuesLinQ = (from ch in maxDictionaries
                                    where ch.Value == 1
                                    select ch).ToList().FirstOrDefault();
                                   
            return UniqueValues.Value == 0 ? -1 : s.IndexOf(UniqueValues.Key);

        }
    }
}
