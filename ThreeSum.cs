using System;
using System.Collections.Generic;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		// Write your code here.
		Array.Sort(array);
		List<int[]> result = new List<int[]>();
		
		for(int i = 0; i < array.Length - 2; i++)
		{
			 int s = i + 1;
			 int e = array.Length - 1;
			 while(s < e)
			 {
				 int tsum = array[i] + array[s] + array[e];
				 if (tsum == targetSum)
				 {
					  result.Add(new int[] { array[i], array[s], array[e] });
				 }
				 if (tsum < targetSum)
				 {
					 s++;
				 }
				 else e--;
			 }
		}
		
		return result;
	}
}
