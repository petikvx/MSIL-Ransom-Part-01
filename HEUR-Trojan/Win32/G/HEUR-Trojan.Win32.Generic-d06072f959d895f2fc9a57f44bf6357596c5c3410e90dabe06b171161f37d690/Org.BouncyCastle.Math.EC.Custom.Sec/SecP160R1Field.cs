using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160R1Field
{
	internal static readonly uint[] P = new uint[5] { 2147483647u, 4294967295u, 4294967295u, 4294967295u, 4294967295u };

	private static readonly uint[] PExt = new uint[10] { 1u, 1073741825u, 0u, 0u, 0u, 4294967294u, 4294967294u, 4294967295u, 4294967295u, 4294967295u };

	private static readonly uint[] PExtInv = new uint[7] { 4294967295u, 3221225470u, 4294967295u, 4294967295u, 4294967295u, 1u, 1u };

	private const uint P4 = uint.MaxValue;

	private const uint PExt9 = uint.MaxValue;

	private const uint PInv = 2147483649u;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		if (Nat160.Add(x, y, z) != 0 || (z[4] == uint.MaxValue && Nat160.Gte(z, P)))
		{
			Nat.AddWordTo(5, 2147483649u, z);
		}
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if ((Nat.Add(10, xx, yy, zz) != 0 || (zz[9] == uint.MaxValue && Nat.Gte(10, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(10, zz, PExtInv.Length);
		}
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		if (Nat.Inc(5, x, z) != 0 || (z[4] == uint.MaxValue && Nat160.Gte(z, P)))
		{
			Nat.AddWordTo(5, 2147483649u, z);
		}
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] array = Nat.FromBigInteger(160, x);
		if (array[4] == uint.MaxValue && Nat160.Gte(array, P))
		{
			Nat160.SubFrom(P, array);
		}
		return array;
	}

	public static void Half(uint[] x, uint[] z)
	{
		if ((x[0] & 1) == 0)
		{
			Nat.ShiftDownBit(5, x, 0u, z);
			return;
		}
		uint c = Nat160.Add(x, P, z);
		Nat.ShiftDownBit(5, z, c);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint num = 0u;
		for (int i = 0; i < 5; i++)
		{
			num |= x[i];
		}
		num = (num >> 1) | (num & 1u);
		return (int)(num - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] array = Nat160.CreateExt();
		Nat160.Mul(x, y, array);
		Reduce(array, z);
	}

	public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
	{
		if ((Nat160.MulAddTo(x, y, zz) != 0 || (zz[9] == uint.MaxValue && Nat.Gte(10, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(10, zz, PExtInv.Length);
		}
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat160.Sub(P, P, z);
		}
		else
		{
			Nat160.Sub(P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] array = new byte[20];
		do
		{
			r.NextBytes(array);
			Pack.LE_To_UInt32(array, 0, z, 0, 5);
		}
		while (Nat.LessThan(5, z, P) == 0);
	}

	public static void RandomMult(SecureRandom r, uint[] z)
	{
		do
		{
			Random(r, z);
		}
		while (IsZero(z) != 0);
	}

	public static void Reduce(uint[] xx, uint[] z)
	{
		ulong num = xx[5];
		ulong num2 = xx[6];
		ulong num3 = xx[7];
		ulong num4 = xx[8];
		ulong num5 = xx[9];
		ulong num6 = 0uL;
		num6 = 0L + (xx[0] + num + (num << 31));
		z[0] = (uint)num6;
		num6 >>= 32;
		num6 += xx[1] + num2 + (num2 << 31);
		z[1] = (uint)num6;
		num6 >>= 32;
		num6 += xx[2] + num3 + (num3 << 31);
		z[2] = (uint)num6;
		num6 >>= 32;
		num6 += xx[3] + num4 + (num4 << 31);
		z[3] = (uint)num6;
		num6 >>= 32;
		num6 += xx[4] + num5 + (num5 << 31);
		z[4] = (uint)num6;
		num6 >>= 32;
		Reduce32((uint)num6, z);
	}

	public static void Reduce32(uint x, uint[] z)
	{
		if ((x != 0 && Nat160.MulWordsAdd(2147483649u, x, z, 0) != 0) || (z[4] == uint.MaxValue && Nat160.Gte(z, P)))
		{
			Nat.AddWordTo(5, 2147483649u, z);
		}
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] array = Nat160.CreateExt();
		Nat160.Square(x, array);
		Reduce(array, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] array = Nat160.CreateExt();
		Nat160.Square(x, array);
		Reduce(array, z);
		while (--n > 0)
		{
			Nat160.Square(z, array);
			Reduce(array, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		if (Nat160.Sub(x, y, z) != 0)
		{
			Nat.SubWordFrom(5, 2147483649u, z);
		}
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Sub(10, xx, yy, zz) != 0 && Nat.SubFrom(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.DecAt(10, zz, PExtInv.Length);
		}
	}

	public static void Twice(uint[] x, uint[] z)
	{
		if (Nat.ShiftUpBit(5, x, 0u, z) != 0 || (z[4] == uint.MaxValue && Nat160.Gte(z, P)))
		{
			Nat.AddWordTo(5, 2147483649u, z);
		}
	}
}
