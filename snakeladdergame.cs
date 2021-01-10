int shortestSnakesAndLadders(int boardSize, int[][] snakes, int[][] ladders)
{
	int[] moves = new int[boardSize + 1];
	// make snakes poition
	foreach (int[] snake in snakes)
	{
		moves[snake[0]] = snake[1];
	}
	// make Ladders poition
	foreach (int[] ladder in ladders)
	{
		moves[ladder[0]] = ladder[1];
	}

	return Helper(moves, boardSize + 1);
}
int Helper(int[] moves, int bs)
{
	bool[] visited = new bool[bs];
	Queue<int[]> q = new Queue<int[]>();
	int[] nt = new int[] { 1, 0 }; // v and dis   
	q.Enqueue(nt);

	while (q.Count != 0)
	{
		nt = q.Dequeue();
		int v = nt[0];
		if (v == bs - 1)
		{
			break;
		}
		for (int j = v + 1; j <= v + 6 && j < bs; j++)
		{
			if (!visited[j])
			{
				int[] cur = new int[] { 0, 0 };
				cur[1] = nt[1] + 1;
				visited[j] = true;

				if (moves[j] == 0)
				{
					cur[0] = j;
				}
				else cur[0] = moves[j];

				q.Enqueue(cur);
			}
		}
	}
	return nt[1];
}
