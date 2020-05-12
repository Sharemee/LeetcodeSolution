using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01字符串压缩
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaasssRQmmP";
             Solution solution = new Solution();
            Console.WriteLine(solution.CompressString(str));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string CompressString(string S)
        {
            if (S.Length == 0) return S;
            StringBuilder sb = new StringBuilder(S[0].ToString());
            int count = 1;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == S[i - 1])
                {
                    count++;
                }
                else
                {
                    sb.Append(count.ToString() + S[i]);
                    count = 1;
                }
            }
            sb.Append(count);
            if (S.Length <= sb.ToString().Length)
            {
                return S;
            }
            return sb.ToString();
        }
    }
}
