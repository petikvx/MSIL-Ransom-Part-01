using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class GOST3411_2012_512Digest : GOST3411_2012Digest
{
	private static readonly byte[] IV;

	public override string AlgorithmName => "GOST3411-2012-512";

	public GOST3411_2012_512Digest()
		: base(IV)
	{
	}

	public GOST3411_2012_512Digest(GOST3411_2012_512Digest other)
		: base(IV)
	{
		Reset(other);
	}

	public override int GetDigestSize()
	{
		return 64;
	}

	public override IMemoable Copy()
	{
		return new GOST3411_2012_512Digest(this);
	}

	static GOST3411_2012_512Digest()
	{
		byte[] array = (IV = new byte[64]);
	}
}
