using System.Collections.Generic;

public class Program
{
	public static List<int> SpiralTraverse(int[,] array)
	{
		List<int> res = new List<int>();
		int r = 0;
		int re = array.GetLength(0) - 1;
		int c = 0;
		int ce = array.GetLength(1) - 1;

		while (r <= re && c <= ce)
		{
			for (int i = c; i <= ce; i++)
			{
				res.Add(array[r, i]);
			}
			for (int i = r + 1; i <= re; i++)
			{
				res.Add(array[i, ce]);
			}
			for (int i = ce - 1; i >= c; i--)
			{
				if (r == re) break;
				res.Add(array[re, i]);
			}
			for (int i = re - 1; i > r; i--)
			{
				if (c == ce) break;
				res.Add(array[i, c]);
			}
			r++; re--;
			c++; ce--;
		}
		return res;
	}
}
