/*
 Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
 */

using System;
using System.Linq;

namespace Ransom_Note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Program.CanConstruct("aa", "aab"));
            //Console.WriteLine(Program.CanConstruct("a", "b"));
            //Console.WriteLine(Program.CanConstruct("aa", "ab"));
            Console.WriteLine(Program.CanConstruct("aab", "baa"));
        }


        public static bool CanConstruct(string ransomNote, string magazine)
        {
            //if (ransomNote == null || magazine == null)
            //{
            //    return false;
            //}
            //    char[] ransomNoteReverse = ransomNote.ToCharArray();
            //    Array.Reverse(ransomNoteReverse);
            //   return magazine.Contains(ransomNote) || magazine.Contains(new string(ransomNoteReverse)) ? true : false;

            /////////////////////// Creative one ////////////////////
            //var charAndCount = new int[256];
            //foreach (var c in magazine)
            //{
            //    charAndCount[c]++;
            //}

            //foreach (var c in ransomNote)
            //{
            //    charAndCount[c]--;

            //    if (charAndCount[c] < 0)
            //    {
            //        return false;
            //    }
            //}

            //return true;


            if ((ransomNote.Length >= 1 && magazine.Length >= 1) && (ransomNote.Length < Math.Pow(10, 5) && magazine.Length < Math.Pow(10, 5)))

            {
                foreach (var ch in ransomNote)
                {
                    if (!magazine.Contains(ch))
                    {
                        return false;
                    }
                    else
                    {
                        magazine = magazine.Remove(magazine.IndexOf(ch), 1);
                    }

                }
                return true;

            }
            return false;
       
        }
    }
}