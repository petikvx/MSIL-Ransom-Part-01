using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw;

internal abstract class Nat448
{
	public static void Copy64(ulong[] x, ulong[] z)
	{
		z[0] = x[0];
		z[1] = x[1];
		z[2] = x[2];
		z[3] = x[3];
		z[4] = x[4];
		z[5] = x[5];
		z[6] = x[6];
	}

	public static ulong[] Create64()
	{
		return new ulong[7];
	}

	public static ulong[] CreateExt64()
	{
		return new ulong[14];
	}

	public static bool Eq64(ulong[] x, ulong[] y)
	{
		int num = 6;
		while (true)
		{
			if (num >= 0)
			{
				if (x[num] != y[num])
				{
					break;
				}
				num--;
				continue;
			}
			return true;
		}
		return false;
	}

	public static ulong[] FromBigInteger64(BigInteger x)
	{
		if (x.SignValue >= 0 && x.BitLength <= 448)
		{
			ulong[] array = Create64();
			int num = 0;
			while (x.SignValue != 0)
			{
				array[num++] = (ulong)x.LongValue;
				x = x.ShiftRight(64);
			}
			return array;
		}
		throw new ArgumentException();
	}

	public static bool IsOne64(ulong[] x)
	{
		if (x[0] != 1L)
		{
			return false;
		}
		int num = 1;
		while (true)
		{
			if (num < 7)
			{
				if (x[num] != 0L)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool IsZero64(ulong[] x)
	{
		int num = 0;
		while (true)
		{
			if (num < 7)
			{
				if (x[num] != 0L)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static BigInteger ToBigInteger64(ulong[] x)
	{
		byte[] array = new byte[56];
		for (int i = 0; i < 7; i++)
		{
			ulong num = x[i];
			if (num != 0L)
			{
				Pack.UInt64_To_BE(num, array, 6 - i << 3);
			}
		}
		return new BigInteger(1, array);
	}
}
