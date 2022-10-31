using System;
using System.Globalization;

namespace test
{
	public class Fibonacci
	{
		List<int> nums;
		public Fibonacci()
		{
			nums = new List<int>() { 1, 1 };
		}

		public int get(int f)
		{
			for (int i = 2; i < f; i++)
			{
				nums.Add(nums[i - 2] + nums[i - 1]);
			}
			return nums[f - 1];
		}
	}
}
