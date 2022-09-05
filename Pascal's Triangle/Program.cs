

using System.Collections.Generic;

namespace Pascals_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(",", Program.Generate(1)));
            //Console.WriteLine(string.Join(",", Program.Generate(2)));
            IList<IList<int>> res = Program.Generate(5);
            foreach (var items in res)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }


        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();

         
            for (int i = 0; i < numRows; i++)
            {
                List<int> resevedList = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if( j== 0 || j == i)
                    {
                        resevedList.Add(1);
                    }
                    else
                    {
                        resevedList.Add(list[i - 1][j - 1] + list[i - 1][j]);

                    }
                }
                list.Add(resevedList);
            }

            return list;
        }
    }
}