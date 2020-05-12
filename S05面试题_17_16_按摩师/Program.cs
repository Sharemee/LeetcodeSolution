using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05面试题_17_16_按摩师
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 2, 1, 4, 5, 3, 1, 1, 3 };
            Solution solution = new Solution();
            int result = solution.Massage(arry);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Massage(int[] nums)
        {
            //排除特殊数据
            switch (nums.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return nums[0];
                default:
                    break;
            }

            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            }
            return dp[nums.Length - 1];
        }
    }
}
