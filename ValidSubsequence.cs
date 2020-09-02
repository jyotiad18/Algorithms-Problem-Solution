using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		 int i = 0;
		 int c = 0;
		 foreach(int _s in sequence)
		 {
			   while(i < array.Count)
				 {
					  if (_s == array[i])
						{
							 c++;
							 i++;
							 break;
						}
					  i++;
				 }
		 }
		 return c == sequence.Count;
	}
}
