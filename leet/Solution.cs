using System;
using System.Diagnostics;

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
        
        public static int[] RunningSum(int[] nums)
        {
	        int sum = 0;
	        int[] res = new int[nums.Length];
	        for (int i = 0; i < nums.Length; i++)
	        {
		        sum += nums[i];
		        res[i] = sum;
	        }

	        return res;
        }
        
        public static int PivotIndex(int[] nums)
        {
	        int l = 0;
	        int lSum = 0;
	        int rSum = 0;
	        for (int i = 1; i < nums.Length; i++)
		        rSum += nums[i];
	        int len = nums.Length;
	        while (l < len)
	        {
		        if (lSum == rSum)
			        break;
		        lSum += nums[l++];
		        if (l >= len)
			        break;
		        rSum -= nums[l];
	        }

	        return l < len ? l : -1;
        }

        public static bool IsIsomorphic(string s, string t)
        {
	        if (s.Length != t.Length)
		        return false;
	        if (s.Length == 0)
		        return true;
	        Dictionary<char, char> symbs = new Dictionary<char, char>();
	        for (int i = 0; i < s.Length; i++)
	        {
		        if (symbs.ContainsValue(s[i]) && !symbs.ContainsKey(t[i]))
			        return false;
		        if(!symbs.ContainsKey(t[i]))
			        symbs.Add(t[i],s[i]);
		        if (s[i] != symbs[t[i]])
			        return false;
	        }
	        return true;
        }
        
        public static bool IsSubsequence(string s, string t)
        {
	        if (s.Length > t.Length)
		        return false;
	        if (s.Length == 0)
		        return true;
	        int idx = 0;
	        for (int i = 0; i < t.Length; i++)
	        {
		        if (s[idx] == t[i])
		        {
			        if (++idx == s.Length)
				        return true;
		        }
	        }
	        return false;
        }
        
        public static string LongestPalindrome(string s)
        {
	        if (s == "")
		        return "";
	        int len = 1;
	        int start = 0;
	        int end = 0;
	        for (int i = 0; i < s.Length; i++)
	        {
		        int len1 = tmp(i, i);
		        int len2 = tmp(i, i + 1);
		        len = Math.Max(len1, len2);
		        if (len > end - start) {
			        start = i - (len - 1) / 2;
			        end = i + len / 2;
		        }
	        }
	        

	        int tmp(int mid, int mid2)
	        {
		        int l = mid;
			    int r = mid2;
			    while (l >= 0 && r < s.Length && s[l] == s[r]) 
			    { 
				    l--; 
				    r++;
		        }
			    return r - l - 1;
	        }

	        return s.Substring(start, end - start + 1);
        }
    }
}

