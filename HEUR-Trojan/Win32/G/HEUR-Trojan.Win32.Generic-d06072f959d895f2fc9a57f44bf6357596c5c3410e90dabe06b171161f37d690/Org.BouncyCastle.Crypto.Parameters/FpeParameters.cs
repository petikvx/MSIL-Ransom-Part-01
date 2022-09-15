using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters;

public sealed class FpeParameters : ICipherParameters
{
	private readonly KeyParameter key;

	private readonly int radix;

	private readonly byte[] tweak;

	private readonly bool useInverse;

	public KeyParameter Key => key;

	public int Radix => radix;

	public bool UseInverseFunction => useInverse;

	public FpeParameters(KeyParameter key, int radix, byte[] tweak)
		: this(key, radix, tweak, useInverse: false)
	{
	}

	public FpeParameters(KeyParameter key, int radix, byte[] tweak, bool useInverse)
	{
		this.key = key;
		this.radix = radix;
		this.tweak = Arrays.Clone(tweak);
		this.useInverse = useInverse;
	}

	public byte[] GetTweak()
	{
		return Arrays.Clone(tweak);
	}
}
