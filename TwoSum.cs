using System;
public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		 Array.Sort(array);
		 int[] result = new int[] {};
		 int i = 0; 
		 int e = array.Length - 1;
		  
		 while(i < e)
		 {
			  int sum = array[i] + array[e];
			  if (sum == targetSum)
					return new int[] {array[e], array[i]};
			  if (sum < targetSum)
				{
					i++;
				} else e--;
		 }
		
		 return result;
	}
}

// [3, 5, -4, 8, 11, 1, -1, 6], 10
//[11, -1]

