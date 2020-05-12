using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03两数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;

            Solution solution = new Solution();
            var result = solution.TwoSum1(nums, target);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 查字典表方法(快些)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { i, dict[nums[i]] };
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement) && dict[complement] != i)
                {
                    return new int[] { i, dict[complement] };
                }
            }
            return new int[] { 0, 0 };
        }

        /// <summary>
        /// 暴力方法(慢些)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum2(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i; res[1] = j;
                        break;
                    }
                }
            }
            return res;
        }
    }
}
