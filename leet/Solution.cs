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
			
			if (s[size] >= '0' && s[size] <= '9')
			{
				if((double)num*10 > int.MaxValue)
					return Int32.MaxValue;
				if ((double)num * 10 < int.MinValue) 
					return Int32.MinValue;
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
				else if (s[size] == ' ')
				{
				}
				else
					return num;
			}

			size++;

			while(size < s.Length)
			{
				if (s[size] >= '0' && s[size] <= '9')
				{
					if((double)num*10 + (s[size]-48) >= int.MaxValue)
						return Int32.MaxValue;
					if ((double)num*10 - (s[size]-48) <= int.MinValue) 
						return Int32.MinValue;
                    num *= 10;
                    if (IsPlus)
						num += s[size] - 48;
					else
                        num -= s[size] - 48;
				}
				else
				{
					if (s[size] == '-' && s[size-1] == ' ')
						IsPlus = false;
					else
					if (s[size] == '+' && s[size-1] == ' ') { }
					else
					if (s[size] == ' ' && s[size-1] == ' ') { }
					else
						break;
                }
				size++;
				
			}
			return num;
        }

        public static int Reverse(int x)
        {
	        int tmp;
	        long res = 0;
	        //bool IsPos = (x > 0) ? true : false;
	        while (x != 0)
	        {
		        tmp = x % 10;
		        res = res * 10 + tmp;
		        x /= 10;
		        if (res > int.MaxValue || res < int.MinValue)
			        return 0;
	        }
	        return (int)res;
        }
        
        public static int[] TwoSum2(int[] numbers, int target)
        {
	        int l = 0;
	        int r = numbers.Length - 1;
	        while (l < r)
	        {
		        if (numbers[l] + numbers[r] > target)
			        r--;
		        else if (numbers[l] + numbers[r] < target)
			        l++;
				else
			        break;
	        }

	        if (l < r)
		        return new int[] { l+1, r+1 };
	        return new int[] { };
        }
    }
}

