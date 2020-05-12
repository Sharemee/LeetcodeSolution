using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08有效的括号
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{[[]{}]}()()";
            Solution solution = new Solution();
            bool result = solution.IsValid1(str);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        private Dictionary<char, char> map;

        public Solution()
        {
            map = new Dictionary<char, char>();
            map.Add(')', '(');
            map.Add('}', '{');
            map.Add(']', '[');
        }

        public bool IsValid1(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (map.ContainsKey(item))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char c = stack.Pop();
                        if (c != map[item])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValid2(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (map.ContainsKey(item))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char c = stack.Pop();
                        if (c != map[item])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
