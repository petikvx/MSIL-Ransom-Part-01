namespace a;

internal sealed class j
{
	internal static void J()
	{
		for (int k = 0; k < G.P.Length; k++)
		{
			B.X[r.Y] = (byte)(B.X[r.Y] ^ (((G.P[k] << r.k) ^ k) + r.Y));
		}
		B.X[r.Y] = (byte)(B.X[r.Y] ^ G.P[r.Y % G.P.Length]);
	}
}
