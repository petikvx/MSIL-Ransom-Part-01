namespace Org.BouncyCastle.Tls;

public abstract class MaxFragmentLength
{
	public const short pow2_9 = 1;

	public const short pow2_10 = 2;

	public const short pow2_11 = 3;

	public const short pow2_12 = 4;

	public static bool IsValid(short maxFragmentLength)
	{
		if (maxFragmentLength >= 1)
		{
			return maxFragmentLength <= 4;
		}
		return false;
	}
}
