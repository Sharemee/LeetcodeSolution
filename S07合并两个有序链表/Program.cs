using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S07合并两个有序链表
{
    class Program
    {
        private static ListNode res = null;

        private static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 4 };
            int[] array2 = new int[] { 1, 3, 4 };

            //初始化链表
            ListNode l1 = InitListNode(array1, 0);
            PrintListNode(l1);
            ListNode l2 = InitListNode(array2, 0);
            PrintListNode(l2);

            Solution solution = new Solution();
            ListNode result = solution.MergeTwoLists(l1, l2);
            PrintListNode(result);
            Console.ReadKey();
        }

        /// <summary>
        /// 数组初始化链表
        /// </summary>
        /// <param name="arry">数组</param>
        /// <param name="index">当前索引</param>
        /// <returns></returns>
        private static ListNode InitListNode(int[] arry, int index)
        {
            ListNode tem = null;
            if (arry.Length >= index + 1)
            {
                tem = new ListNode(arry[index]);
                if (res == null)
                {
                    res = tem;
                    index++;
                    res.next = InitListNode(arry, index);
                }
                else
                {
                    index++;
                    tem.next = InitListNode(arry, index);
                }
            }
            return tem;
        }

        private static void PrintListNode(ListNode list)
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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return (l1 == null) ? l2 : l1;
            }
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
    }

    /// <summary>
    /// 链表结构
    /// </summary>
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
