using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Linked_List
{
    internal class Program
    {
        public class ListNode
        {
             public int val;
             public ListNode next;
             public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static void Main(string[] args)
        {
            ListNode one = new ListNode(1);
            ListNode two = new ListNode(2);
            ListNode three = new ListNode(3);
            ListNode four = new ListNode(4);
            ListNode five = new ListNode(2);
            ListNode six = new ListNode(9);

            one.next = two;
            two.next = three;
            three.next = four;

            four.next = five;
            five.next = six;
            ListNode newNodeReversePrint = Program.ReverseList(one);
            while (newNodeReversePrint != null)
            {
                Console.WriteLine(newNodeReversePrint.val);
                newNodeReversePrint = newNodeReversePrint.next;
            }

            //ListNode test = Program.ReverseList(new ListNode());

        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;
            ListNode reverseListNode = null;

            while (head != null)
            {
                ListNode newNode = new ListNode(head.val);
                newNode.next = reverseListNode;
                reverseListNode = newNode;
                head = head.next;
            }
            //numbers.Reverse();
            //foreach (var item in head.Select((value, i) => new { value, i }))
            //{
            //    ListNode newNode = new ListNode(item.value);
            //    if (item.i != 0)
            //        newNode.next = reverseListNode;
            //    reverseListNode = newNode;
            //}

            return reverseListNode;
        }
    }
}
