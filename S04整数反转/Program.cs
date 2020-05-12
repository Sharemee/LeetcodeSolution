using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04整数反转
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            Solution solution = new Solution();
            int result = solution.Reverse(x);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            int y = 0, tem = 0;
            while (x != 0)
            {
                //1.取个位, 第二次进来要进位
                int a = x % 10;
                y = y * 10 + a; //当x=int.MaxValue时, 且x降到个位时, y*10会溢出

                //y溢出后降位后不会等于上一次的结果(tem)
                int b = y / 10;
                if (tem != b) { return 0; }

                //保存本次的结果
                tem = y;

                //2.降位
                x /= 10;
            }
            return y;
        }
    }
}