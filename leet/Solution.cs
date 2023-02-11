using System;
namespace leet
{
	public static class Solution
	{
		public static int[]? TwoSum(int[] nums, int target)
		{
			Dictionary<int, int> compelements = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (compelements.ContainsKey(target - nums[i]))
				{
					return new int[] { i, compelements[target - nums[i]] };
				}
				if (!compelements.ContainsKey(nums[i]))
					compelements.Add(nums[i], i);
			}
			return null;
		}

		public static int LengthOfLongestSubstring(string s)
		{
			if (s.Length == 0)
				return 0;
			Dictionary<int,int> sub_str = new Dictionary<int, int> { };
			int l = 0;
			int r = 0;
			int len = 1;
			while(r < s.Length)
			{
				if (sub_str.ContainsKey(s[r]))
				{					
					while (s[l] != s[r])
					{
						sub_str.Remove(s[l]);
						l++;
					}
                    sub_str.Remove(s[l]);
					l++;
                }
				sub_str.Add(s[r], r);
				len = int.Max(len, r - l + 1);
				r++;
			}
			return len;
		}

        public static int MyAtoi(string s)
        {
			if (s.Length == 0)
				return 0;
			int num = 0;
			int size = 0;
			bool IsPlus = true;
			double max = int.MaxValue;
			while(size < s.Length)
			{
				if (s[size] >= '0' && s[size] <= '9')
				{
					
                    num *= 10;
                    if (IsPlus)
						num += s[size] - 48;
					else
                        num -= s[size] - 48;
				}
				else
				{
					if (s[size] == '-')
						IsPlus = false;
					else
					if (s[size] == '+') { }
					else
					if (s[size] == ' ') { }
					else
						break;
                }
				size++;
				
			}
			return num;
        }
    }
}

