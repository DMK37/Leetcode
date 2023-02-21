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
            // Console.WriteLine(Solution.MyAtoi("4193 with words"));
            Console.WriteLine(Solution.MyAtoi("2147483648"));
            Console.WriteLine(Solution.Reverse(-321));
            foreach (var num in Solution.TwoSum2(new int[] {2,7,11,15},0))
            {
                Console.WriteLine(num);
            }
            
            Console.WriteLine(Solution.PivotIndex(new int[] {1,2,3}));
            Console.WriteLine(Solution.IsIsomorphic("paper","title"));
            Console.WriteLine(Solution.IsSubsequence("abc","ahbgdd"));
            Console.WriteLine(Solution.LongestPalindrome("cbbd"));
        }
    }
}


