namespace White.Core.SystemExtensions;

public static class DoubleX
{
	public static bool IsInvalid(this double @double)
	{
		if (@double != double.PositiveInfinity && @double != double.NegativeInfinity)
		{
			return double.IsNaN(@double);
		}
		return true;
	}
}
