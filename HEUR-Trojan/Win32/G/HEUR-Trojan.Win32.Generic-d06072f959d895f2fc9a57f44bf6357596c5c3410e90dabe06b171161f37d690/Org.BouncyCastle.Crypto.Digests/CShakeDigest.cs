using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class CShakeDigest : ShakeDigest
{
	private static readonly byte[] padding = new byte[100];

	private readonly byte[] diff;

	public override string AlgorithmName => "CSHAKE" + fixedOutputLength;

	private static byte[] EncodeString(byte[] str)
	{
		if (Arrays.IsNullOrEmpty(str))
		{
			return XofUtilities.LeftEncode(0L);
		}
		return Arrays.Concatenate(XofUtilities.LeftEncode(str.Length * 8L), str);
	}

	public CShakeDigest(int bitLength, byte[] N, byte[] S)
		: base(bitLength)
	{
		if ((N != null && N.Length != 0) || (S != null && S.Length != 0))
		{
			diff = Arrays.ConcatenateAll(XofUtilities.LeftEncode(rate / 8), EncodeString(N), EncodeString(S));
			DiffPadAndAbsorb();
		}
		else
		{
			diff = null;
		}
	}

	public CShakeDigest(CShakeDigest source)
		: base(source)
	{
		diff = Arrays.Clone(source.diff);
	}

	private void DiffPadAndAbsorb()
	{
		int num = rate / 8;
		Absorb(diff, 0, diff.Length);
		int num2 = diff.Length % num;
		if (num2 != 0)
		{
			int num3;
			for (num3 = num - num2; num3 > padding.Length; num3 -= padding.Length)
			{
				Absorb(padding, 0, padding.Length);
			}
			Absorb(padding, 0, num3);
		}
	}

	public override int DoOutput(byte[] output, int outOff, int outLen)
	{
		if (diff == null)
		{
			return base.DoOutput(output, outOff, outLen);
		}
		if (!squeezing)
		{
			AbsorbBits(0, 2);
		}
		Squeeze(output, outOff, (long)outLen << 3);
		return outLen;
	}

	public override void Reset()
	{
		base.Reset();
		if (diff != null)
		{
			DiffPadAndAbsorb();
		}
	}
}
