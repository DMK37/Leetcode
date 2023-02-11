using System;

namespace leet
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 18;
            int[]? res = Solution.TwoSum(nums, target);
            foreach(int num in res)
            {
                Console.WriteLine(num);
            }

            string s = "abdnjksdskssfffsf";
            Console.WriteLine(Solution.LengthOfLongestSubstring(s));
            Console.WriteLine(Solution.MyAtoi("4193 with words"));
        }
    }
}


