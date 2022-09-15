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

	public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		z[zOff] = x[xOff];
		z[zOff + 1] = x[xOff + 1];
		z[zOff + 2] = x[xOff + 2];
		z[zOff + 3] = x[xOff + 3];
		z[zOff + 4] = x[xOff + 4];
		z[zOff + 5] = x[xOff + 5];
		z[zOff + 6] = x[xOff + 6];
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

	public static void Mul(uint[] x, uint[] y, uint[] zz)
	{
		Nat224.Mul(x, y, zz);
		Nat224.Mul(x, 7, y, 7, zz, 14);
		uint num = Nat224.AddToEachOther(zz, 7, zz, 14);
		uint cIn = num + Nat224.AddTo(zz, 0, zz, 7, 0u);
		num += Nat224.AddTo(zz, 21, zz, 14, cIn);
		uint[] array = Nat224.Create();
		uint[] array2 = Nat224.Create();
		bool flag = Nat224.Diff(x, 7, x, 0, array, 0) != Nat224.Diff(y, 7, y, 0, array2, 0);
		uint[] array3 = Nat224.CreateExt();
		Nat224.Mul(array, array2, array3);
		num += (uint)(flag ? ((int)Nat.AddTo(14, array3, 0, zz, 7)) : Nat.SubFrom(14, array3, 0, zz, 7));
		Nat.AddWordAt(28, num, zz, 21);
	}

	public static void Square(uint[] x, uint[] zz)
	{
		Nat224.Square(x, zz);
		Nat224.Square(x, 7, zz, 14);
		uint num = Nat224.AddToEachOther(zz, 7, zz, 14);
		uint cIn = num + Nat224.AddTo(zz, 0, zz, 7, 0u);
		num += Nat224.AddTo(zz, 21, zz, 14, cIn);
		uint[] array = Nat224.Create();
		Nat224.Diff(x, 7, x, 0, array, 0);
		uint[] array2 = Nat224.CreateExt();
		Nat224.Square(array, array2);
		num += (uint)Nat.SubFrom(14, array2, 0, zz, 7);
		Nat.AddWordAt(28, num, zz, 21);
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
