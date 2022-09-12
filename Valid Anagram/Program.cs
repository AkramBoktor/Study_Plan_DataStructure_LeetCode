using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsAnagram("anagram", "nagaram"));
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            IDictionary<char, int> firstString = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (firstString.ContainsKey(ch))
                    firstString[ch]++;
                else
                    firstString.Add(ch, 1);
            }

            foreach (var ch in t)
            {
                if (firstString.ContainsKey(ch) && firstString[ch]>=1)
                    firstString[ch]--;
                else
                    return false;
            }
                return true;


            ////////////////////// solution 2
            /*
             
                 if (s.Length != t.Length) return false;
            var stringOne = s.ToLower().ToCharArray();
            var stringTwo = t.ToLower().ToCharArray();
            Array.Sort(stringOne);
            Array.Sort(stringTwo);
            for (int i = 0; i < s.Length; i++)
            {
                if (stringOne[i] != stringTwo[i]) return false;
            }

            return true;
             
             */
        }
    }
}
