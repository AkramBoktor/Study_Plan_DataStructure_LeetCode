using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading;

namespace ProblemTest_micro_prague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Program.MaximumTwoPoint(1,1,2,3));
            Console.WriteLine(Program.balanceCompany(new int[] { 10, -10, -1, -1, 10 }));
            Console.WriteLine(Program.balanceCompany(new int[] { -1, -1, -1, 1, 1, 1, 1 }));
            Console.WriteLine(Program.balanceCompany(new int[] { 5, -2, -3, 1 }));

            //TreeNode one = new TreeNode(5);
            //one.right = new TreeNode(10);
            //one.right.left = new TreeNode(1);

            //one.left = new TreeNode(3);
            //one.left.right = new TreeNode(21);
            //one.left.left = new TreeNode(20);


            TreeNode one = new TreeNode(8);
            one.right = new TreeNode(6);

            one.left = new TreeNode(2);
            one.left.right = new TreeNode(7);
            one.left.left = new TreeNode(8);

            Console.WriteLine(string.Join(",", Program.InorderTraversal(one)));

        }


        public static int MaximumTwoPoint(int A, int B, int C, int D)
        {
            if ((A == B) && (B == C) && (C == D))
            {
                return 0;
            }
            int [] MaxArr = new int[3];
            int x0 ,  y0 ;

            x0 = A - B;
            y0 = C - D;

            MaxArr[0] = x0*x0 + y0*y0;

            x0 = A - C;
            y0 = B - D;

            MaxArr[1] = x0 * x0 + y0 * y0;

            x0 = A - D;
            y0 = C - B;

            MaxArr[2] = x0 * x0 + y0 * y0;

            return MaxArr.Max();
        }


        public static int balanceCompany(int[] A)
        {
            int countMove = 0;
            if (A[0] < 0)
            {
                countMove++;
            }
            for (int i = 1; i < A.Length-2; i++)
            {
                if (A[0] + A[i] <= 0 && A[i] < 0)
                {
                    countMove++;
                }
                else
                {
                    break;
                }
            }

            return countMove;
        }


        // indoreorder left root right
        // preorder root left right
        // postorder left right root
        public static int InorderTraversal(TreeNode root)
        {
            int rootMax = root.val;
            List<int> _result = new List<int>();
            TraverseWithInorder(root, _result);
            return _result.Where(x=>x >= rootMax).Count();
        }

        private static void TraverseWithInorder(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                TraverseWithInorder(root.left, result);
                result.Add(root.val);
                TraverseWithInorder(root.right, result);
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
