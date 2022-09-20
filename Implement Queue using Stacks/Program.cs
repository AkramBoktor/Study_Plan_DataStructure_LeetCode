using System;
using System.Collections.Generic;
using System.Linq;

namespace Implement_Queue_using_Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);
            queue.Pop();
            Console.WriteLine(String.Join(",",queue.print()));
            queue.Peek();
            Console.WriteLine(String.Join(",", queue.print()));
            Console.WriteLine( queue.Empty() );
        }

        public class MyQueue
        {
            //List<int> queueList;
            //public MyQueue()
            //{
            //    queueList = new List<int>();
            //}

            //public void Push(int x)
            //{
            //    queueList.Add(x);
            //}

            //public int Pop()
            //{
            //    var item = queueList.FirstOrDefault();
            //    queueList.Remove(item);
            //    return item;
            //}

            //public int Peek()
            //{
            //    return queueList.FirstOrDefault();
            //}

            //public bool Empty()
            //{
            //   return queueList.Count == 0 ? true : false;
            //}

            //public List<int> print()
            //{
            //    return queueList.ToList();
            //}

            private Stack<int> s1 = null,
                    s2 = null;

            public MyQueue()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();
            }

            public void Push(int x)
            {
                s1.Push(x);
            }

            public int Pop()
            {
                if (Empty())
                    return Int32.MinValue;

                while (s1.Count > 0)
                    s2.Push(s1.Pop());

                int top = s2.Pop();

                while (s2.Count > 0)
                    s1.Push(s2.Pop());

                return top;
            }

            public int Peek()
            {
                if (Empty())
                    return Int32.MinValue;

                while (s1.Count > 0)
                    s2.Push(s1.Pop());

                int top = s2.Peek();

                while (s2.Count > 0)
                    s1.Push(s2.Pop());

                return top;
            }

            public bool Empty()
            {
                return s1.Count == 0;
            }


            public List<int> print()
            {
                return s1.ToList();
            }
        }
    }
}
