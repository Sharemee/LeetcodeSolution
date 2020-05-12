using System;
namespace SS01两数相加
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 7, 9, 9, 8 }, num2 = { 6, 5, 0, 0, 1 };
            ListNode l1 = InitListNode(num1);
            PointListNode(l1);
            ListNode l2 = InitListNode(num2);
            PointListNode(l2);

            Solution solution = new Solution();
            var res = solution.AddTwoNumbers(l1, l2);
            PointListNode(res);

            Console.ReadKey();
        }

        /// <summary>
        /// 用数组初始化链表
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        static ListNode InitListNode(int[] vals)
        {
            ListNode res = null;
            ListNode last = null;
            foreach (var val in vals)
            {
                if (res is null)
                {
                    res = new ListNode(val);
                    last = res;
                }
                else
                {
                    last.next = new ListNode(val);
                    last = last.next;
                }
            }
            return res;
        }

        /// <summary>
        /// 打印链表中的元素
        /// </summary>
        /// <param name="list"></param>
        static void PointListNode(ListNode list)
        {
            while (list != null)
            {
                Console.Write($"{list.val} ");
                list = list.next;
            }
            Console.WriteLine();
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            ListNode prenode = new ListNode(0);
            ListNode lastnode = prenode;
            while (l1 != null || l2 != null || val != 0)
            {
                val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                lastnode.next = new ListNode(val % 10);
                lastnode = lastnode.next;
                val /= 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return prenode.next;
        }
    }
}
