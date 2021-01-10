using System;
public class Program
{
	public static void Main()
	{
		Node n = new Node();
		n.add("cat");
		n.add("copy");

		Console.WriteLine(n.findCount("cat", 0));
	}
}

public class Node
{
	public static int NUMBER_OF_CHARACTER = 26;
	public Node[] childern = new Node[NUMBER_OF_CHARACTER];
	public static int size = 0;

	public static int getCharIndex(char c)
	{
		return c - 'a';
	}
	public Node getNode(char c)
	{
		int index = getCharIndex(c);
		return childern[index];
	}

	public void setNode(char c, Node n)
	{
		int index = getCharIndex(c);
		childern[index] = n;
	}

	public void add(string s)
	{
		add(s, 0);
	}
	public void add(string s, int index)
	{
		size++;
		if (index == s.Length) return;
		char cur = s[index];
		int charIndex = getCharIndex(cur);
		Node node = getNode(cur);
		if (node == null)
		{
			node = new Node();
			setNode(cur, node);
		}
		node.add(s, index + 1);
	}

	public int findCount(string s, int index)
	{
		if (index == s.Length) return size;
		Node child = getNode(s[index]);
		if (child == null) return 0;
		return child.findCount(s, index + 1);
	}
}