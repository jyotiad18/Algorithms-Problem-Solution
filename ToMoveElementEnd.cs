using System;
using System.Collections.Generic;

public class Program
{
	public static List<int> MoveElementToEnd(List<int> array, int toMove)
	{
		int i = 0;
		int j = array.Count - 1;
		while (i < j)
		{
			if (array[j] == toMove)
			{
				j--;
			}
			if (array[i] == toMove)
			{
				array[i] = array[j];
				array[j] = toMove;
			}
			i++;
		}
		return array;
	}
}
