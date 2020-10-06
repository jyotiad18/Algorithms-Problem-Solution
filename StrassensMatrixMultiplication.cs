using System;

public class Program
{
	public static void Main()
	{
		//for 2 * 2 matrix
		int[,] n1 = new int[2, 2] { { 1, 2 }, { 1, 3 } };
		int[,] n2 = new int[2, 2] { { 1, 5 }, { 4, 3 } };

		//output must be {{9, 11}, {13, 14}}

		int row = n1.GetLength(0);
		int rCol = n1.GetLength(1);
		int col = n2.GetLength(1);

		int[,] n3 = new int[row, col];
		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < col; j++)
			{
				int sum = 0;
				for (int k = 0; k < rCol; k++)
				{
					sum += n1[i, k] * n2[k, j];
				}
				n3[i, j] = sum;
			}
		}

		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < col; j++)
			{
				Console.WriteLine(n3[i, j]);
			}
		}

	}
}