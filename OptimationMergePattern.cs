using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] a = new int[] { 2, 3, 4, 5, 6, 7 };
		Array.Sort(a);
		Queue<int> pq = new Queue<int>();

		for (int i = 0; i < a.Length; i++)
		{
			pq.Enqueue(a[i]);
		}
		int count = 0;
		while (pq.Count > 1)
		{
			int temp = pq.Dequeue() + pq.Dequeue();
			count += temp;
			pq.Enqueue(temp);
		}
		Console.WriteLine(count); // output 68
	}
}