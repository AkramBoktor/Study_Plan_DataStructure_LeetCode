using System;
using System.Linq;

namespace Bitwice_Numbers
{
    internal class Program
    {
        //public static int[] sortedXor(int N, int K, int[] A)
        //{
        //    if (N == 0 || A.Length == 0) return Array.Empty<int>();
        //    int[] result = new int[N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        result[i] = A[i] ^ K;
        //    }
        //    //write your Logic here:

        //    Array.Sort(result);
        //    return  result;
        //}

        //public static void Main()
        //{
        //    // INPUT [uncomment & modify if required]
        //    string[] ip = Console.ReadLine().Split(' ');
        //    int N = int.Parse(ip[0]);
        //    int K = int.Parse(ip[1]);

        //    int[] A = new int[N];
        //    string[] tokens = Console.ReadLine().Split();
        //    int i;
        //    for (i = 0; i < N; i++)
        //    {
        //        A[i] = Convert.ToInt32(tokens[i]);
        //    }

        //    // OUTPUT [uncomment & modify if required]
        //    Console.WriteLine(String.Join(",", sortedXor(N, K, A)));
        //}




        public static int solveThePuzzle(int N, string S)
        {
            int count = 1;
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {

                    int subTwoDigit = j - i;
                    if (1 <= i && i < j && j <= N && (subTwoDigit == Math.Abs(Convert.ToInt32(S[j])- Convert.ToInt32(S[i]))))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static void Main()
        {
            // INPUT [uncomment & modify if required]
            int N = Convert.ToInt32(Console.ReadLine());

            string S = Console.ReadLine();

            // OUTPUT [uncomment & modify if required]
            Console.WriteLine(solveThePuzzle(N, S));
        }
    }
}

