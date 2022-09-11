namespace System.Numerics.Hashing;

internal static class HashHelpers
{
	public static int Combine(int h1, int h2)
	{
		uint num = (uint)(h1 << 5) | ((uint)h1 >> 27);
		return ((int)num + h1) ^ h2;
	}
}
