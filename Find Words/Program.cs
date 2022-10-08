/*
 Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.

In the American keyboard:

the first row consists of the characters "qwertyuiop",
the second row consists of the characters "asdfghjkl", and
the third row consists of the characters "zxcvbnm".

Example 1:

Input: words = ["Hello","Alaska","Dad","Peace"]
Output: ["Alaska","Dad"]
Example 2:

Input: words = ["omk"]
Output: []
Example 3:

Input: words = ["adsdf","sfd"]
Output: ["adsdf","sfd"]
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Find_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(',', Program.FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" })));
            Console.WriteLine(String.Join(',', Program.FindWords(new string[] { "omk" })));
            Console.WriteLine(String.Join(',', Program.FindWords(new string[] { "adsdf", "sfd" })));
        }


        public static string[] FindWords(string[] words)
        {
            List<string> listFindWords = new List<string>();
            IDictionary<int, string> AmericanKeyboards = new Dictionary<int, string>();
            int key;
            int oldKey;
            AmericanKeyboards.Add(1, "qwertyuiop");
            AmericanKeyboards.Add(2, "asdfghjkl");
            AmericanKeyboards.Add(3, "zxcvbnm");
            for (int i = 0; i < words.Length; i++)
            {
                 key = 0;
                 oldKey = 0;
                bool theSameRow = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    oldKey = key;

                    key = AmericanKeyboards.Where(x => x.Value.Contains(words[i][j].ToString().ToLower())).Select(k=>k.Key).FirstOrDefault();

                    if( oldKey !=0 && oldKey != key)
                    {
                        theSameRow = false;
                        break;
                    }
                }

                if (theSameRow == true) listFindWords.Add(words[i]);
            }


            return listFindWords.ToArray();
        }
    }
}
