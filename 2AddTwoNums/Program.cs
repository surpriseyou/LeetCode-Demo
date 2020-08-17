using System;
using System.Collections.Generic;
using System.IO;

namespace _2AddTwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 1

            ListNode node1 = new ListNode(9);
            // node1.next = new ListNode(4);
            // node1.next.next = new ListNode(3);

            ListNode node2 = new ListNode(1);
            node2.next = new ListNode(9);
            node2.next.next = new ListNode(9);
            node2.next.next.next = new ListNode(9);
            node2.next.next.next.next = new ListNode(9);
            node2.next.next.next.next.next = new ListNode(9);
            node2.next.next.next.next.next.next = new ListNode(9);
            node2.next.next.next.next.next.next.next = new ListNode(9);
            node2.next.next.next.next.next.next.next.next = new ListNode(9);
            node2.next.next.next.next.next.next.next.next.next = new ListNode(9);
            var node = AddTwoNumbers2(node1, node2);
            Print(node);


            #endregion



            #region 2

            //ListNode node1 = new ListNode(2);
            //node1.next = new ListNode(4);
            //node1.next.next = new ListNode(3);


            //ListNode node2 = new ListNode(5);
            //node2.next = new ListNode(6);
            //node2.next.next = new ListNode(4);

            //Print(AddTwoNumbers2(node1, node2));

            #endregion
        }

        [Obsolete("大数据不能使用，会丢失精度")]
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long num1 = 0, num2 = 0, idx = 0, sum = 0;

            while (l1 != null)
            {
                num1 += (long)Math.Pow(10, idx) * l1.val;
                l1 = l1.next;
                idx++;
            }

            idx = 0;
            while (l2 != null)
            {
                num2 += (long)Math.Pow(10, idx) * l2.val;
                l2 = l2.next;
                idx++;
            }

            sum = num1 + num2;
            //807
            ListNode result = new ListNode((int)(sum % 10)); //7
            while (sum / 10 > 0)
            {
                sum = sum / 10; //8
                ListNode temp = result;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = new ListNode((int)(sum % 10)); //0 8
            }

            return result;
        }


        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            // 243 + 564 = 708
            int ten = 0;
            ListNode temp = null;
            while (l1 != null || l2 != null || ten > 0)
            {
                int sum = ten;
                if (l1 != null)
                    sum += l1.val;
                if (l2 != null)
                    sum += l2.val;
                int val = sum % 10;
                if (result == null)
                {
                    result = new ListNode(val);
                    temp = result;
                }
                else
                {
                    temp.next = new ListNode(val);
                }
                while (temp.next != null)
                {
                    temp = temp.next;
                }
               
                // 下一个进位
                ten = sum / 10;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            return result;
        }

        static void Print(ListNode node)
        {
            List<int> values = new List<int>();
            while (node != null)
            {
                values.Add(node.val);
                node = node.next;
            }

            Console.WriteLine($"[{string.Join(",", values)}]");
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}