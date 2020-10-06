using System;

public class Program
{
	public static void Main()
	{
		int[] nums = new int[] { 2, 3, 5, 11, 1, 4, 8, 9, 25 };
		//SelectionSort(nums);
		//BubbleSort(nums);
		InsertionSort(nums);
		foreach (int n in nums)
		{
			Console.Write(n + " - ");
		}
	}
	public static void InsertionSort(int[] nums)
	{
		int len = nums.Length;
		for (int i = 1; i < len; ++i)
		{
			int j = i - 1;
			int val = nums[i];
			while (j >= 0 && nums[j] > val)
			{
				nums[j + 1] = nums[j];
				j = j - 1;
			}
			nums[j + 1] = val;
		}
	}
	public static void BubbleSort(int[] nums)
	{
		int len = nums.Length;
		for (int i = 0; i < len - 1; i++)
		{
			for (int j = 0; j < len - i - 1; j++)
			{
				if (nums[j] > nums[j + 1])
				{
					//Swap
					int temp = nums[j];
					nums[j] = nums[j + 1];
					nums[j + 1] = temp;
				}
			}
		}
	}
	public static void SelectionSort(int[] nums)
	{
		int len = nums.Length;
		for (int i = 0; i < len - 1; i++)
		{
			int min_id = i;
			for (int j = i + 1; j < len; j++)
			{
				if (nums[j] < nums[min_id])
				{
					min_id = j;
				}
			}
			int temp = nums[min_id];
			nums[min_id] = nums[i];
			nums[i] = temp;
		}
	}
}
