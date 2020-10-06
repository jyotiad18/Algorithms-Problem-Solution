using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[,] mat = new int[6, 5] {{0, 0, 1, 0, 1},
								   {1, 0, 1, 0, 1},
								   {0, 1, 1, 0, 1},
								   {0, 0, 1, 0, 1},
								   {1, 0, 1, 0, 1},
								   {0, 1, 1, 0, 1}
								  };
		bool[,] visited = new bool[mat.GetLength(0), mat.GetLength(1)];
		for (int i = 0; i < mat.GetLength(0); i++)
		{
			for (int j = 0; j < mat.GetLength(1); j++)
			{
				if (visited[i, j])
				{
					continue;
				}
				Helper(i, j, mat, visited);
			}

		}
		Display(visited);
	}

	static void Helper(int i, int j, int[,] mat, bool[,] visited)
	{
		Stack<int[]> s = new Stack<int[]>();
		s.Push(new int[] { i, j });

		while (s.Count != 0)
		{
			int[] _s = s.Pop();
			i = _s[0];
			j = _s[1];
			if (visited[i, j]) continue;
			visited[i, j] = true;
			if (mat[i, j] == 0) continue;
			List<int[]> l = new List<int[]>();
			l = GetNeg(i, j, mat, visited);
			foreach (int[] _l in l)
			{
				s.Push(new int[] { _l[0], _l[1] });
			}
		}
	}
	static List<int[]> GetNeg(int i, int j, int[,] mat, bool[,] visited)
	{
		List<int[]> l = new List<int[]>();
		if (i > 0 && !visited[i - 1, j])
		{
			l.Add(new int[] { i - 1, j });
		}
		if (i < mat.GetLength(0) - 1 && !visited[i + 1, j])
		{
			l.Add(new int[] { i + 1, j });
		}
		if (j > 0 && !visited[i, j - 1])
		{
			l.Add(new int[] { i, j - 1 });
		}
		if (j < mat.GetLength(1) - 1 && !visited[i, j + 1])
		{
			l.Add(new int[] { i, j + 1 });
		}
		return l;
	}

	static void Display(bool[,] visited)
	{
		Console.WriteLine("---------------------------");
		for (int i = 0; i < visited.GetLength(0); i++)
		{
			for (int j = 0; j < visited.GetLength(1); j++)
			{
				Console.Write(" | " + visited[i, j]);
			}
			Console.WriteLine("");
			Console.WriteLine("-----------------------");
		}
	}
}