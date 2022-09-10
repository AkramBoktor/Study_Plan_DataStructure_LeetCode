using System;
using System.Collections.Generic;
using System.Linq;

namespace getMaxFreqDeviation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.getMaxFreqDeviation("bbacccabb"));
        }
        public static int getMaxFreqDeviation(string s)
        {
            #region solve 1
            //    if (s.Length == 1)
            //    {
            //        return 1;
            //    }
            //    List<int> maxMinValue = new List<int>();
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        int freq = 1;
            //        for (int j = 0; j < s.Length; j++)
            //        {
            //            if (s[i] == s[j] && i != j)
            //            {
            //                freq += 1;
            //            }
            //        }
            //        maxMinValue.Add(freq);
            //    }

            //    return maxMinValue.Max() - maxMinValue.Min();
            //}
            #endregion

            #region Solve 2
            IDictionary<char, int> maxDictionaries = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (maxDictionaries.ContainsKey(ch))
                {
                    maxDictionaries[ch]++;
                }
                else
                {
                    maxDictionaries.Add(ch, 1);
                }
            }

            return maxDictionaries.Max(x => x.Value) - maxDictionaries.Min(x => x.Value);

            #endregion
        }

    }
}