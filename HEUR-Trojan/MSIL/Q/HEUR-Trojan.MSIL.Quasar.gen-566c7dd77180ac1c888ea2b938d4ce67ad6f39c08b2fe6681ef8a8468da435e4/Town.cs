internal class Town
{
	private extern int minDistance(int[] dist, bool[] sptSet, int V);

	private extern void printSolution(int[] dist);

	public extern void dijkstra(int[,] graph, int src, int V);

	public extern Town();
}
