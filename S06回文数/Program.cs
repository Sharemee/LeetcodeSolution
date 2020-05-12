using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S06回文数
{
    class Program
    {
        static void Main(string[] args)
        {
            int arry = 348843;
            Solution solution = new Solution();
            bool result = solution.IsPalindrome1(arry);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsPalindrome1(int x)
        {
            bool res = true;
            string tem = x.ToString();
            string left = tem.Substring(0, tem.Length / 2);
            string right = (tem.Length % 2 != 0) ? tem.Substring(tem.Length / 2 + 1) : tem.Substring(tem.Length / 2);
            int i = 0;
            int ii = left.Length - 1;
            while (i < right.Length)
            {
                if (left[i] != right[ii])
                {
                    res = false;
                    break;
                }
                i++;
                ii--;
            }
            return res;
        }

        public bool IsPalindrome2(int x)
        {
            bool res = true;
            string tem = x.ToString();
            string left = tem.Substring(0, tem.Length / 2);
            string right = (tem.Length % 2 != 0) ? tem.Substring(tem.Length / 2 + 1) : tem.Substring(tem.Length / 2);
            int i = 0;
            int ii = left.Length - 1;
            while (i < right.Length)
            {
                if (left[i] != right[ii])
                {
                    res = false;
                    break;
                }
                i++;
                ii--;
            }
            return res;
        }

    }
}
