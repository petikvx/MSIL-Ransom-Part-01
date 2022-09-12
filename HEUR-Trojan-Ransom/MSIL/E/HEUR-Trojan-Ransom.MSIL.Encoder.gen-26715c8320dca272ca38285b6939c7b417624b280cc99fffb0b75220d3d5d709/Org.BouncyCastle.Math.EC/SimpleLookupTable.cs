namespace Org.BouncyCastle.Math.EC;

public class SimpleLookupTable : ECLookupTable
{
	private readonly ECPoint[] points;

	public virtual int Size => points.Length;

	private static ECPoint[] Copy(ECPoint[] points, int off, int len)
	{
		ECPoint[] array = new ECPoint[len];
		for (int i = 0; i < len; i++)
		{
			array[i] = points[off + i];
		}
		return array;
	}

	public SimpleLookupTable(ECPoint[] points, int off, int len)
	{
		this.points = Copy(points, off, len);
	}

	public virtual ECPoint Lookup(int index)
	{
		return points[index];
	}
}
