using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

public abstract class X25519Field
{
	public const int Size = 10;

	private const int M24 = 16777215;

	private const int M25 = 33554431;

	private const int M26 = 67108863;

	private static readonly uint[] P32 = new uint[8] { 4294967277u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 2147483647u };

	private static readonly int[] RootNegOne = new int[10] { 34513072, 59165138, 4688974, 3500415, 6194736, 33281959, 54535759, 32551604, 163342, 5703241 };

	public static void Add(int[] x, int[] y, int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = x[i] + y[i];
		}
	}

	public static void AddOne(int[] z)
	{
		z[0]++;
	}

	public static void AddOne(int[] z, int zOff)
	{
		z[zOff]++;
	}

	public static void Apm(int[] x, int[] y, int[] zp, int[] zm)
	{
		for (int i = 0; i < 10; i++)
		{
			int num = x[i];
			int num2 = y[i];
			zp[i] = num + num2;
			zm[i] = num - num2;
		}
	}

	public static int AreEqual(int[] x, int[] y)
	{
		int num = 0;
		for (int i = 0; i < 10; i++)
		{
			num |= x[i] ^ y[i];
		}
		num |= num >> 16;
		num &= 0xFFFF;
		return num - 1 >> 31;
	}

	public static bool AreEqualVar(int[] x, int[] y)
	{
		return AreEqual(x, y) != 0;
	}

	public static void Carry(int[] z)
	{
		int num = z[0];
		int num2 = z[1];
		int num3 = z[2];
		int num4 = z[3];
		int num5 = z[4];
		int num6 = z[5];
		int num7 = z[6];
		int num8 = z[7];
		int num9 = z[8];
		int num10 = z[9];
		num3 += num2 >> 26;
		num2 &= 0x3FFFFFF;
		num5 += num4 >> 26;
		num4 &= 0x3FFFFFF;
		num8 += num7 >> 26;
		num7 &= 0x3FFFFFF;
		num10 += num9 >> 26;
		num9 &= 0x3FFFFFF;
		num4 += num3 >> 25;
		num3 &= 0x1FFFFFF;
		num6 += num5 >> 25;
		num5 &= 0x1FFFFFF;
		num9 += num8 >> 25;
		num8 &= 0x1FFFFFF;
		num += (num10 >> 25) * 38;
		num10 &= 0x1FFFFFF;
		num2 += num >> 26;
		num &= 0x3FFFFFF;
		num7 += num6 >> 26;
		num6 &= 0x3FFFFFF;
		num3 += num2 >> 26;
		num2 &= 0x3FFFFFF;
		num5 += num4 >> 26;
		num4 &= 0x3FFFFFF;
		num8 += num7 >> 26;
		num7 &= 0x3FFFFFF;
		num10 += num9 >> 26;
		num9 &= 0x3FFFFFF;
		z[0] = num;
		z[1] = num2;
		z[2] = num3;
		z[3] = num4;
		z[4] = num5;
		z[5] = num6;
		z[6] = num7;
		z[7] = num8;
		z[8] = num9;
		z[9] = num10;
	}

	public static void CMov(int cond, int[] x, int xOff, int[] z, int zOff)
	{
		for (int i = 0; i < 10; i++)
		{
			int num = z[zOff + i];
			int num2 = num ^ x[xOff + i];
			num = (z[zOff + i] = num ^ (num2 & cond));
		}
	}

	public static void CNegate(int negate, int[] z)
	{
		int num = -negate;
		for (int i = 0; i < 10; i++)
		{
			z[i] = (z[i] ^ num) - num;
		}
	}

	public static void Copy(int[] x, int xOff, int[] z, int zOff)
	{
		for (int i = 0; i < 10; i++)
		{
			z[zOff + i] = x[xOff + i];
		}
	}

	public static int[] Create()
	{
		return new int[10];
	}

	public static int[] CreateTable(int n)
	{
		return new int[10 * n];
	}

	public static void CSwap(int swap, int[] a, int[] b)
	{
		int num = -swap;
		for (int i = 0; i < 10; i++)
		{
			int num2 = a[i];
			int num3 = b[i];
			int num4 = num & (num2 ^ num3);
			a[i] = num2 ^ num4;
			b[i] = num3 ^ num4;
		}
	}

	[CLSCompliant(false)]
	public static void Decode(uint[] x, int xOff, int[] z)
	{
		Decode128(x, xOff, z, 0);
		Decode128(x, xOff + 4, z, 5);
		z[9] &= 16777215;
	}

	public static void Decode(byte[] x, int xOff, int[] z)
	{
		Decode128(x, xOff, z, 0);
		Decode128(x, xOff + 16, z, 5);
		z[9] &= 16777215;
	}

	private static void Decode128(uint[] x, int xOff, int[] z, int zOff)
	{
		uint num = x[xOff];
		uint num2 = x[xOff + 1];
		uint num3 = x[xOff + 2];
		uint num4 = x[xOff + 3];
		z[zOff] = (int)(num & 0x3FFFFFF);
		z[zOff + 1] = (int)(((num2 << 6) | (num >> 26)) & 0x3FFFFFF);
		z[zOff + 2] = (int)(((num3 << 12) | (num2 >> 20)) & 0x1FFFFFF);
		z[zOff + 3] = (int)(((num4 << 19) | (num3 >> 13)) & 0x3FFFFFF);
		z[zOff + 4] = (int)(num4 >> 7);
	}

	private static void Decode128(byte[] bs, int off, int[] z, int zOff)
	{
		uint num = Decode32(bs, off);
		uint num2 = Decode32(bs, off + 4);
		uint num3 = Decode32(bs, off + 8);
		uint num4 = Decode32(bs, off + 12);
		z[zOff] = (int)(num & 0x3FFFFFF);
		z[zOff + 1] = (int)(((num2 << 6) | (num >> 26)) & 0x3FFFFFF);
		z[zOff + 2] = (int)(((num3 << 12) | (num2 >> 20)) & 0x1FFFFFF);
		z[zOff + 3] = (int)(((num4 << 19) | (num3 >> 13)) & 0x3FFFFFF);
		z[zOff + 4] = (int)(num4 >> 7);
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	[CLSCompliant(false)]
	public static void Encode(int[] x, uint[] z, int zOff)
	{
		Encode128(x, 0, z, zOff);
		Encode128(x, 5, z, zOff + 4);
	}

	public static void Encode(int[] x, byte[] z, int zOff)
	{
		Encode128(x, 0, z, zOff);
		Encode128(x, 5, z, zOff + 16);
	}

	private static void Encode128(int[] x, int xOff, uint[] z, int zOff)
	{
		uint num = (uint)x[xOff];
		uint num2 = (uint)x[xOff + 1];
		uint num3 = (uint)x[xOff + 2];
		uint num4 = (uint)x[xOff + 3];
		uint num5 = (uint)x[xOff + 4];
		z[zOff] = num | (num2 << 26);
		z[zOff + 1] = (num2 >> 6) | (num3 << 20);
		z[zOff + 2] = (num3 >> 12) | (num4 << 13);
		z[zOff + 3] = (num4 >> 19) | (num5 << 7);
	}

	private static void Encode128(int[] x, int xOff, byte[] bs, int off)
	{
		int num = x[xOff];
		uint num2 = (uint)x[xOff + 1];
		uint num3 = (uint)x[xOff + 2];
		uint num4 = (uint)x[xOff + 3];
		uint num5 = (uint)x[xOff + 4];
		Encode32((uint)num | (num2 << 26), bs, off);
		Encode32((num2 >> 6) | (num3 << 20), bs, off + 4);
		Encode32((num3 >> 12) | (num4 << 13), bs, off + 8);
		Encode32((num4 >> 19) | (num5 << 7), bs, off + 12);
	}

	private static void Encode32(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
		bs[++off] = (byte)(n >> 24);
	}

	public static void Inv(int[] x, int[] z)
	{
		int[] array = Create();
		uint[] array2 = new uint[8];
		Copy(x, 0, array, 0);
		Normalize(array);
		Encode(array, array2, 0);
		Mod.ModOddInverse(P32, array2, array2);
		Decode(array2, 0, z);
	}

	public static void InvVar(int[] x, int[] z)
	{
		int[] array = Create();
		uint[] array2 = new uint[8];
		Copy(x, 0, array, 0);
		Normalize(array);
		Encode(array, array2, 0);
		Mod.ModOddInverseVar(P32, array2, array2);
		Decode(array2, 0, z);
	}

	public static int IsOne(int[] x)
	{
		int num = x[0] ^ 1;
		for (int i = 1; i < 10; i++)
		{
			num |= x[i];
		}
		num |= num >> 16;
		num &= 0xFFFF;
		return num - 1 >> 31;
	}

	public static bool IsOneVar(int[] x)
	{
		return IsOne(x) != 0;
	}

	public static int IsZero(int[] x)
	{
		int num = 0;
		for (int i = 0; i < 10; i++)
		{
			num |= x[i];
		}
		num |= num >> 16;
		num &= 0xFFFF;
		return num - 1 >> 31;
	}

	public static bool IsZeroVar(int[] x)
	{
		return IsZero(x) != 0;
	}

	public static void Mul(int[] x, int y, int[] z)
	{
		int num = x[0];
		int num2 = x[1];
		int num3 = x[2];
		int num4 = x[3];
		int num5 = x[4];
		int num6 = x[5];
		int num7 = x[6];
		int num8 = x[7];
		int num9 = x[8];
		int num10 = x[9];
		long num11 = (long)num3 * (long)y;
		num3 = (int)num11 & 0x1FFFFFF;
		num11 >>= 25;
		long num12 = (long)num5 * (long)y;
		num5 = (int)num12 & 0x1FFFFFF;
		num12 >>= 25;
		long num13 = (long)num8 * (long)y;
		num8 = (int)num13 & 0x1FFFFFF;
		num13 >>= 25;
		long num14 = (long)num10 * (long)y;
		num10 = (int)num14 & 0x1FFFFFF;
		num14 >>= 25;
		num14 *= 38L;
		num14 += (long)num * (long)y;
		z[0] = (int)num14 & 0x3FFFFFF;
		num14 >>= 26;
		num12 += (long)num6 * (long)y;
		z[5] = (int)num12 & 0x3FFFFFF;
		num12 >>= 26;
		num14 += (long)num2 * (long)y;
		z[1] = (int)num14 & 0x3FFFFFF;
		num14 >>= 26;
		num11 += (long)num4 * (long)y;
		z[3] = (int)num11 & 0x3FFFFFF;
		num11 >>= 26;
		num12 += (long)num7 * (long)y;
		z[6] = (int)num12 & 0x3FFFFFF;
		num12 >>= 26;
		num13 += (long)num9 * (long)y;
		z[8] = (int)num13 & 0x3FFFFFF;
		num13 >>= 26;
		z[2] = num3 + (int)num14;
		z[4] = num5 + (int)num11;
		z[7] = num8 + (int)num12;
		z[9] = num10 + (int)num13;
	}

	public static void Mul(int[] x, int[] y, int[] z)
	{
		int num = x[0];
		int num2 = y[0];
		int num3 = x[1];
		int num4 = y[1];
		int num5 = x[2];
		int num6 = y[2];
		int num7 = x[3];
		int num8 = y[3];
		int num9 = x[4];
		int num10 = y[4];
		int num11 = x[5];
		int num12 = y[5];
		int num13 = x[6];
		int num14 = y[6];
		int num15 = x[7];
		int num16 = y[7];
		int num17 = x[8];
		int num18 = y[8];
		int num19 = x[9];
		int num20 = y[9];
		long num21 = (long)num * (long)num2;
		long num22 = (long)num * (long)num4 + (long)num3 * (long)num2;
		long num23 = (long)num * (long)num6 + (long)num3 * (long)num4 + (long)num5 * (long)num2;
		long num24 = (long)num3 * (long)num6 + (long)num5 * (long)num4;
		num24 <<= 1;
		num24 += (long)num * (long)num8 + (long)num7 * (long)num2;
		long num25 = (long)num5 * (long)num6;
		num25 <<= 1;
		num25 += (long)num * (long)num10 + (long)num3 * (long)num8 + (long)num7 * (long)num4 + (long)num9 * (long)num2;
		long num26 = (long)num3 * (long)num10 + (long)num5 * (long)num8 + (long)num7 * (long)num6 + (long)num9 * (long)num4;
		num26 <<= 1;
		long num27 = (long)num5 * (long)num10 + (long)num9 * (long)num6;
		num27 <<= 1;
		num27 += (long)num7 * (long)num8;
		long num28 = (long)num7 * (long)num10 + (long)num9 * (long)num8;
		long num29 = (long)num9 * (long)num10;
		num29 <<= 1;
		long num30 = (long)num11 * (long)num12;
		long num31 = (long)num11 * (long)num14 + (long)num13 * (long)num12;
		long num32 = (long)num11 * (long)num16 + (long)num13 * (long)num14 + (long)num15 * (long)num12;
		long num33 = (long)num13 * (long)num16 + (long)num15 * (long)num14;
		num33 <<= 1;
		num33 += (long)num11 * (long)num18 + (long)num17 * (long)num12;
		long num34 = (long)num15 * (long)num16;
		num34 <<= 1;
		num34 += (long)num11 * (long)num20 + (long)num13 * (long)num18 + (long)num17 * (long)num14 + (long)num19 * (long)num12;
		long num35 = (long)num13 * (long)num20 + (long)num15 * (long)num18 + (long)num17 * (long)num16 + (long)num19 * (long)num14;
		long num36 = (long)num15 * (long)num20 + (long)num19 * (long)num16;
		num36 <<= 1;
		num36 += (long)num17 * (long)num18;
		long num37 = (long)num17 * (long)num20 + (long)num19 * (long)num18;
		long num38 = (long)num19 * (long)num20;
		num21 -= num35 * 76L;
		num22 -= num36 * 38L;
		num23 -= num37 * 38L;
		num24 -= num38 * 76L;
		num26 -= num30;
		num27 -= num31;
		num28 -= num32;
		num29 -= num33;
		num += num11;
		num2 += num12;
		num3 += num13;
		num4 += num14;
		num5 += num15;
		num6 += num16;
		num7 += num17;
		num8 += num18;
		num9 += num19;
		num10 += num20;
		long num39 = (long)num * (long)num2;
		long num40 = (long)num * (long)num4 + (long)num3 * (long)num2;
		long num41 = (long)num * (long)num6 + (long)num3 * (long)num4 + (long)num5 * (long)num2;
		long num42 = (long)num3 * (long)num6 + (long)num5 * (long)num4;
		num42 <<= 1;
		num42 += (long)num * (long)num8 + (long)num7 * (long)num2;
		long num43 = (long)num5 * (long)num6;
		num43 <<= 1;
		num43 += (long)num * (long)num10 + (long)num3 * (long)num8 + (long)num7 * (long)num4 + (long)num9 * (long)num2;
		long num44 = (long)num3 * (long)num10 + (long)num5 * (long)num8 + (long)num7 * (long)num6 + (long)num9 * (long)num4;
		num44 <<= 1;
		long num45 = (long)num5 * (long)num10 + (long)num9 * (long)num6;
		num45 <<= 1;
		num45 += (long)num7 * (long)num8;
		long num46 = (long)num7 * (long)num10 + (long)num9 * (long)num8;
		long num47 = (long)num9 * (long)num10;
		num47 <<= 1;
		long num48 = num29 + (num42 - num24);
		int num49 = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		num48 += num43 - num25 - num34;
		int num50 = (int)num48 & 0x1FFFFFF;
		num48 >>= 25;
		num48 = num21 + (num48 + num44 - num26) * 38L;
		z[0] = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		num48 += num22 + (num45 - num27) * 38L;
		z[1] = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		num48 += num23 + (num46 - num28) * 38L;
		z[2] = (int)num48 & 0x1FFFFFF;
		num48 >>= 25;
		num48 += num24 + (num47 - num29) * 38L;
		z[3] = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		num48 += num25 + num34 * 38L;
		z[4] = (int)num48 & 0x1FFFFFF;
		num48 >>= 25;
		num48 += num26 + (num39 - num21);
		z[5] = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		num48 += num27 + (num40 - num22);
		z[6] = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		num48 += num28 + (num41 - num23);
		z[7] = (int)num48 & 0x1FFFFFF;
		num48 >>= 25;
		num48 += num49;
		z[8] = (int)num48 & 0x3FFFFFF;
		num48 >>= 26;
		z[9] = num50 + (int)num48;
	}

	public static void Negate(int[] x, int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = -x[i];
		}
	}

	public static void Normalize(int[] z)
	{
		int num = (z[9] >> 23) & 1;
		Reduce(z, num);
		Reduce(z, -num);
	}

	public static void One(int[] z)
	{
		z[0] = 1;
		for (int i = 1; i < 10; i++)
		{
			z[i] = 0;
		}
	}

	private static void PowPm5d8(int[] x, int[] rx2, int[] rz)
	{
		Sqr(x, rx2);
		Mul(x, rx2, rx2);
		int[] array = Create();
		Sqr(rx2, array);
		Mul(x, array, array);
		int[] array2 = array;
		Sqr(array, 2, array2);
		Mul(rx2, array2, array2);
		int[] array3 = Create();
		Sqr(array2, 5, array3);
		Mul(array2, array3, array3);
		int[] array4 = Create();
		Sqr(array3, 5, array4);
		Mul(array2, array4, array4);
		int[] array5 = array2;
		Sqr(array4, 10, array5);
		Mul(array3, array5, array5);
		int[] array6 = array3;
		Sqr(array5, 25, array6);
		Mul(array5, array6, array6);
		int[] array7 = array4;
		Sqr(array6, 25, array7);
		Mul(array5, array7, array7);
		int[] array8 = array5;
		Sqr(array7, 50, array8);
		Mul(array6, array8, array8);
		int[] array9 = array6;
		Sqr(array8, 125, array9);
		Mul(array8, array9, array9);
		int[] array10 = array8;
		Sqr(array9, 2, array10);
		Mul(array10, x, rz);
	}

	private static void Reduce(int[] z, int x)
	{
		int num = z[9];
		int num2 = num & 0xFFFFFF;
		long num3 = ((num >> 24) + x) * 19;
		num3 += z[0];
		z[0] = (int)num3 & 0x3FFFFFF;
		num3 >>= 26;
		num3 += z[1];
		z[1] = (int)num3 & 0x3FFFFFF;
		num3 >>= 26;
		num3 += z[2];
		z[2] = (int)num3 & 0x1FFFFFF;
		num3 >>= 25;
		num3 += z[3];
		z[3] = (int)num3 & 0x3FFFFFF;
		num3 >>= 26;
		num3 += z[4];
		z[4] = (int)num3 & 0x1FFFFFF;
		num3 >>= 25;
		num3 += z[5];
		z[5] = (int)num3 & 0x3FFFFFF;
		num3 >>= 26;
		num3 += z[6];
		z[6] = (int)num3 & 0x3FFFFFF;
		num3 >>= 26;
		num3 += z[7];
		z[7] = (int)num3 & 0x1FFFFFF;
		num3 >>= 25;
		num3 += z[8];
		z[8] = (int)num3 & 0x3FFFFFF;
		num3 >>= 26;
		z[9] = num2 + (int)num3;
	}

	public static void Sqr(int[] x, int[] z)
	{
		int num = x[0];
		int num2 = x[1];
		int num3 = x[2];
		int num4 = x[3];
		int num5 = x[4];
		int num6 = x[5];
		int num7 = x[6];
		int num8 = x[7];
		int num9 = x[8];
		int num10 = x[9];
		int num11 = num2 * 2;
		int num12 = num3 * 2;
		int num13 = num4 * 2;
		int num14 = num5 * 2;
		long num15 = (long)num * (long)num;
		long num16 = (long)num * (long)num11;
		long num17 = (long)num * (long)num12 + (long)num2 * (long)num2;
		long num18 = (long)num11 * (long)num12 + (long)num * (long)num13;
		long num19 = (long)num3 * (long)num12 + (long)num * (long)num14 + (long)num2 * (long)num13;
		long num20 = (long)num11 * (long)num14 + (long)num12 * (long)num13;
		long num21 = (long)num12 * (long)num14 + (long)num4 * (long)num4;
		long num22 = (long)num4 * (long)num14;
		long num23 = (long)num5 * (long)num14;
		int num24 = num7 * 2;
		int num25 = num8 * 2;
		int num26 = num9 * 2;
		int num27 = num10 * 2;
		long num28 = (long)num6 * (long)num6;
		long num29 = (long)num6 * (long)num24;
		long num30 = (long)num6 * (long)num25 + (long)num7 * (long)num7;
		long num31 = (long)num24 * (long)num25 + (long)num6 * (long)num26;
		long num32 = (long)num8 * (long)num25 + (long)num6 * (long)num27 + (long)num7 * (long)num26;
		long num33 = (long)num24 * (long)num27 + (long)num25 * (long)num26;
		long num34 = (long)num25 * (long)num27 + (long)num9 * (long)num9;
		long num35 = (long)num9 * (long)num27;
		long num36 = (long)num10 * (long)num27;
		num15 -= num33 * 38L;
		num16 -= num34 * 38L;
		num17 -= num35 * 38L;
		num18 -= num36 * 38L;
		num20 -= num28;
		num21 -= num29;
		num22 -= num30;
		num23 -= num31;
		num += num6;
		num2 += num7;
		int num37 = num3 + num8;
		num4 += num9;
		num5 += num10;
		num11 = num2 * 2;
		num12 = num37 * 2;
		num13 = num4 * 2;
		num14 = num5 * 2;
		long num38 = (long)num * (long)num;
		long num39 = (long)num * (long)num11;
		long num40 = (long)num * (long)num12 + (long)num2 * (long)num2;
		long num41 = (long)num11 * (long)num12 + (long)num * (long)num13;
		long num42 = (long)num37 * (long)num12 + (long)num * (long)num14 + (long)num2 * (long)num13;
		long num43 = (long)num11 * (long)num14 + (long)num12 * (long)num13;
		long num44 = (long)num12 * (long)num14 + (long)num4 * (long)num4;
		long num45 = (long)num4 * (long)num14;
		long num46 = (long)num5 * (long)num14;
		long num47 = num23 + (num41 - num18);
		int num48 = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		num47 += num42 - num19 - num32;
		int num49 = (int)num47 & 0x1FFFFFF;
		num47 >>= 25;
		num47 = num15 + (num47 + num43 - num20) * 38L;
		z[0] = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		num47 += num16 + (num44 - num21) * 38L;
		z[1] = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		num47 += num17 + (num45 - num22) * 38L;
		z[2] = (int)num47 & 0x1FFFFFF;
		num47 >>= 25;
		num47 += num18 + (num46 - num23) * 38L;
		z[3] = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		num47 += num19 + num32 * 38L;
		z[4] = (int)num47 & 0x1FFFFFF;
		num47 >>= 25;
		num47 += num20 + (num38 - num15);
		z[5] = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		num47 += num21 + (num39 - num16);
		z[6] = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		num47 += num22 + (num40 - num17);
		z[7] = (int)num47 & 0x1FFFFFF;
		num47 >>= 25;
		num47 += num48;
		z[8] = (int)num47 & 0x3FFFFFF;
		num47 >>= 26;
		z[9] = num49 + (int)num47;
	}

	public static void Sqr(int[] x, int n, int[] z)
	{
		Sqr(x, z);
		while (--n > 0)
		{
			Sqr(z, z);
		}
	}

	public static bool SqrtRatioVar(int[] u, int[] v, int[] z)
	{
		int[] array = Create();
		int[] array2 = Create();
		Mul(u, v, array);
		Sqr(v, array2);
		Mul(array, array2, array);
		Sqr(array2, array2);
		Mul(array2, array, array2);
		int[] array3 = Create();
		int[] array4 = Create();
		PowPm5d8(array2, array3, array4);
		Mul(array4, array, array4);
		int[] array5 = Create();
		Sqr(array4, array5);
		Mul(array5, v, array5);
		Sub(array5, u, array3);
		Normalize(array3);
		if (IsZeroVar(array3))
		{
			Copy(array4, 0, z, 0);
			return true;
		}
		Add(array5, u, array3);
		Normalize(array3);
		if (IsZeroVar(array3))
		{
			Mul(array4, RootNegOne, z);
			return true;
		}
		return false;
	}

	public static void Sub(int[] x, int[] y, int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = x[i] - y[i];
		}
	}

	public static void SubOne(int[] z)
	{
		z[0]--;
	}

	public static void Zero(int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = 0;
		}
	}
}
