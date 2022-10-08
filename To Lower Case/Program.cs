using System;
using System.Text;

namespace To_Lower_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.ToLowerCase("AAcD"));
        }

        public static string ToLowerCase(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            StringBuilder lowercaseString = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] >= 65 && (int)s[i] <= 90)
                {
                    lowercaseString.Append((char) ((int)s[i]+32));
                }
                else
                {
                    lowercaseString.Append(s[i]);
                }
            }

            return lowercaseString.ToString();
        }
    }
}
