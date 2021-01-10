using System;
using System.Collections.Generic;


public class Program
{
	static int result = 0;
	public static void Main()
	{
		string a = "aabccba";
		Helper(a, a.Length, -1, "");
		Console.WriteLine(result);
	}

	public static void Helper(String str, int n, int index, String curr)
	{
		if (index == n)
		{
			return;
		}
		if (curr != null && curr.Length == 5 && IsPalid(curr.ToCharArray()))
		{
			result++;
		}
		for (int i = index + 1; i < n; i++)
		{
			curr += str[i];
			Helper(str, n, i, curr);
			curr = curr.Substring(0, curr.Length - 1);
		}
	}
	public static bool IsPalid(char[] chars)
	{
		int i = 0;
		int j = chars.Length - 1;
		while (i < j)
		{
			if (chars[i] != chars[j]) return false;
			i++;
			j--;
		}
		return true;
	}
}