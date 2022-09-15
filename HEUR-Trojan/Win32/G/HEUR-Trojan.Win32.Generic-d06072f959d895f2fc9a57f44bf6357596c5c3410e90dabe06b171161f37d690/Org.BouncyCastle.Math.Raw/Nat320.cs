using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw;

internal abstract class Nat320
{
	public static void Copy64(ulong[] x, ulong[] z)
	{
		z[0] = x[0];
		z[1] = x[1];
		z[2] = x[2];
		z[3] = x[3];
		z[4] = x[4];
	}

	public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		z[zOff] = x[xOff];
		z[zOff + 1] = x[xOff + 1];
		z[zOff + 2] = x[xOff + 2];
		z[zOff + 3] = x[xOff + 3];
		z[zOff + 4] = x[xOff + 4];
	}

	public static ulong[] Create64()
	{
		return new ulong[5];
	}

	public static ulong[] CreateExt64()
	{
		return new ulong[10];
	}

	public static bool Eq64(ulong[] x, ulong[] y)
	{
		int num = 4;
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

	public static bool IsOne64(ulong[] x)
	{
		if (x[0] != 1L)
		{
			return false;
		}
		int num = 1;
		while (true)
		{
			if (num < 5)
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
			if (num < 5)
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
		byte[] array = new byte[40];
		for (int i = 0; i < 5; i++)
		{
			ulong num = x[i];
			if (num != 0L)
			{
				Pack.UInt64_To_BE(num, array, 4 - i << 3);
			}
		}
		return new BigInteger(1, array);
	}
}
