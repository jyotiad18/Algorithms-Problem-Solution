public class Program
{
	public static bool IsMonotonic(int[] array)
	{
		int u = 0;
		int d = 0;
		if (array.Length <= 2) return true;
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i - 1] <= array[i])
			{
				d++;
			}
			if (array[i - 1] >= array[i])
			{
				u++;
			}
		}
		return u == array.Length - 1 || d == array.Length - 1;
	}
}
