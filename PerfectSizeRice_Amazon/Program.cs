using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfectSizeRice_Amazon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.getMaxFreqDeviation("bbacccabb"));
        }
        public static int getMaxFreqDeviation(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            List<int> maxMinValue = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                int freq = 1;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j] && i != j)
                    {
                        freq += 1;
                    }
                }
                maxMinValue.Add(freq);
            }

            return maxMinValue.Max() - maxMinValue.Min();
        }

    }

}