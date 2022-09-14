using System;
using System.Collections.Generic;
using System.Linq;
/*
 * 
 Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.

 

Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:

Input: n = 2
Output: false
 

Constraints:

1 <= n <= 231 - 1
 */
namespace Happy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsHappy(19));
            Console.WriteLine(Program.IsHappy(2));
        }


        public static  bool IsHappy(int n)
        {
            if(n<0)return false;
            List<int> numbersDigits = new List<int>();
            while (n > 0 && numbersDigits.Where(x=>x == n).Count() <= 1)
            {

                int number = 0;
                for (int i = 0; i < n.ToString().Length; i++)
                {
                    number +=(int) Math.Pow(int.Parse(n.ToString()[i].ToString()),2);

                }
                n = number;
                if (n == 1) return true;
                numbersDigits.Add(n);
            }
           
            return false;


            /***************** Solution 2 ***************/
           /* if (n < 0) return false;
            HashSet<int> seen = new HashSet<int>();
            while (n > 0)
            {
                if (seen.Contains(n)) return false;
                seen.Add(n);
                int number = 0;
                for (int i = 0; i < n.ToString().Length; i++)
                {
                    number += (int)Math.Pow(int.Parse(n.ToString()[i].ToString()), 2);

                }
                n = number;
                if (n == 1) return true;
            }

            return false;*/
        }
    }
}
