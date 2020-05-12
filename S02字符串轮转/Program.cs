using System;

namespace S02字符串轮转
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aba";
            string str2 = "ab";

            Solution solution = new Solution();
            Console.WriteLine(solution.IsFlipedString(str1, str2));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsFlipedString(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            if ((s2 + s2).Contains(s1))
            {
                return true;
            }
            return false;
        }
    }
}
