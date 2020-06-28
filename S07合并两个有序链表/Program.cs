using System;
using System.Diagnostics;
using System.Threading;

namespace S07合并两个有序链表
{
    class Program
    {
        const int MAX = 10000;
        private static ListNode res = null;

        private static void Main(string[] args)
        {
            Console.Title = "合并两个有序链表";

            //初始化链表
            ListNode l1 = InitListNode(ArryList(), 0);
            PrintListNode(l1);
            ListNode l2 = InitListNode(ArryList(), 0);
            PrintListNode(l2);
            Console.WriteLine("=======================");
            Solution solution = new Solution();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ListNode result = solution.MergeTwoLists(l1, l2);
            Thread.Sleep(1);
            sw.Stop();
            Console.WriteLine("链表合并结果: ");
            PrintListNode(result);
            Console.WriteLine("检查计算结果: " + CheckResult(result, out int count)+" "+ count);
            Console.WriteLine("运算时间: " + sw.ElapsedMilliseconds);

            Console.ReadKey();
        }

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
            int l = 1;
            while (list != null)
            {
                if (l > 15)
                {
                    Console.Write(".....");
                    break;
                }
                else
                {
                    Console.Write($"{list.val} ");
                    l++;
                    list = list.next;
                }
            }
            Console.WriteLine();
        }

        private static int[] ArryList()
        {
            int length = 0;
            Random rd = new Random();
            length = rd.Next(0, MAX/10);
            Console.WriteLine("正在生成数组数据....数组长度: " + length);

            int[] arry = new int[length];
            for (int i = 0; i < length; i++)
            {
                Thread.Sleep(10);
                arry[i] = rd.Next(-MAX, MAX);
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arry[j] > arry[j + 1])
                    {
                        arry[j] = arry[j] ^ arry[j + 1];
                        arry[j + 1] = arry[j] ^ arry[j + 1];
                        arry[j] = arry[j] ^ arry[j + 1];
                    }
                }
            }

            return arry;
        }

        private static bool CheckResult(ListNode list, out int count)
        {
            count = 0;
            if (list is null) return true;

            count = 1;
            int tem = list.val;
            while (list.next != null)
            {
                list = list.next; count++;
                if (tem > list.val) return false;
            }
            return true;
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

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) => val = x;
    }
}
