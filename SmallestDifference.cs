using System;
public class Program
{
	public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
	{
		int[] res = new int[2];
		Array.Sort(arrayOne);
		Array.Sort(arrayTwo);
		int i = 0;
		int j = 0;
		int cu = int.MaxValue;
		int sm = int.MaxValue;

		while (i < arrayOne.Length && j < arrayTwo.Length)
		{
			int _one = arrayOne[i];
			int _two = arrayTwo[j];
			if (_one < _two)
			{
				cu = _two - _one;
				i++;
			}
			else if (_two < _one)
			{
				cu = _one - _two;
				j++;
			}
			else
			{
				return new[] { _one, _two };
			}
			if (sm > cu)
			{
				sm = cu;
				res = new int[] { _one, _two };
			}
		}

		return res;
	}
}
