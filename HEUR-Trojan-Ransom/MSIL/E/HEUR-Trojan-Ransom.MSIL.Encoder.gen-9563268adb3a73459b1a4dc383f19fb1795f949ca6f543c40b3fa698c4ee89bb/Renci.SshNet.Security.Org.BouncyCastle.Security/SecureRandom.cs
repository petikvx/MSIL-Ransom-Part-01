using System;
using System.Threading;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Digests;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Prng;
using Renci.SshNet.Security.Org.BouncyCastle.Utilities;

namespace Renci.SshNet.Security.Org.BouncyCastle.Security;

internal class SecureRandom : Random
{
	private static long counter = Times.NanoTime();

	private static readonly SecureRandom master = new SecureRandom(new CryptoApiRandomGenerator());

	protected readonly IRandomGenerator generator;

	private static readonly double DoubleScale = System.Math.Pow(2.0, 64.0);

	private static SecureRandom Master => master;

	private static long NextCounterValue()
	{
		return Interlocked.Increment(ref counter);
	}

	private static DigestRandomGenerator CreatePrng(IDigest digest, bool autoSeed)
	{
		DigestRandomGenerator digestRandomGenerator = new DigestRandomGenerator(digest);
		if (autoSeed)
		{
			digestRandomGenerator.AddSeedMaterial(NextCounterValue());
			digestRandomGenerator.AddSeedMaterial(GetNextBytes(Master, digest.GetDigestSize()));
		}
		return digestRandomGenerator;
	}

	public static byte[] GetNextBytes(SecureRandom secureRandom, int length)
	{
		byte[] array = new byte[length];
		secureRandom.NextBytes(array);
		return array;
	}

	public SecureRandom()
		: this(CreatePrng(new Sha256Digest(), autoSeed: true))
	{
	}

	public SecureRandom(IRandomGenerator generator)
		: base(0)
	{
		this.generator = generator;
	}

	public virtual byte[] GenerateSeed(int length)
	{
		return GetNextBytes(Master, length);
	}

	public virtual void SetSeed(byte[] seed)
	{
		generator.AddSeedMaterial(seed);
	}

	public virtual void SetSeed(long seed)
	{
		generator.AddSeedMaterial(seed);
	}

	public override int Next()
	{
		return NextInt() & 0x7FFFFFFF;
	}

	public override int Next(int maxValue)
	{
		if (maxValue < 2)
		{
			if (maxValue < 0)
			{
				throw new ArgumentOutOfRangeException("maxValue", "cannot be negative");
			}
			return 0;
		}
		int num;
		if ((maxValue & (maxValue - 1)) == 0)
		{
			num = NextInt() & 0x7FFFFFFF;
			return (int)((long)num * (long)maxValue >> 31);
		}
		int num2;
		do
		{
			num = NextInt() & 0x7FFFFFFF;
			num2 = num % maxValue;
		}
		while (num - num2 + (maxValue - 1) < 0);
		return num2;
	}

	public override int Next(int minValue, int maxValue)
	{
		if (maxValue <= minValue)
		{
			if (maxValue == minValue)
			{
				return minValue;
			}
			throw new ArgumentException("maxValue cannot be less than minValue");
		}
		int num = maxValue - minValue;
		if (num > 0)
		{
			return minValue + Next(num);
		}
		int num2;
		do
		{
			num2 = NextInt();
		}
		while (num2 < minValue || num2 >= maxValue);
		return num2;
	}

	public override void NextBytes(byte[] buf)
	{
		generator.NextBytes(buf);
	}

	public virtual void NextBytes(byte[] buf, int off, int len)
	{
		generator.NextBytes(buf, off, len);
	}

	public override double NextDouble()
	{
		return Convert.ToDouble((ulong)NextLong()) / DoubleScale;
	}

	public virtual int NextInt()
	{
		byte[] array = new byte[4];
		NextBytes(array);
		return (((((array[0] << 8) | array[1]) << 8) | array[2]) << 8) | array[3];
	}

	public virtual long NextLong()
	{
		return (long)(((ulong)(uint)NextInt() << 32) | (uint)NextInt());
	}
}
