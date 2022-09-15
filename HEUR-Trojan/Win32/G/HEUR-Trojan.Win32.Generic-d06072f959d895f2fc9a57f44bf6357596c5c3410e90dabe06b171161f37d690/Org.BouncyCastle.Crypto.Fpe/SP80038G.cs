using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe;

internal class SP80038G
{
	internal static readonly string FPE_DISABLED = "Org.BouncyCastle.Fpe.Disable";

	internal static readonly string FF1_DISABLED = "Org.BouncyCastle.Fpe.Disable_Ff1";

	protected static readonly int BLOCK_SIZE = 16;

	protected static readonly double LOG2 = System.Math.Log(2.0);

	protected static readonly double TWO_TO_96 = System.Math.Pow(2.0, 96.0);

	public static byte[] DecryptFF1(IBlockCipher cipher, int radix, byte[] tweak, byte[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: true, radix, buf, off, len);
		int num = len / 2;
		int num2 = len - num;
		ushort[] a = toShort(buf, off, num);
		ushort[] b = toShort(buf, off + num, num2);
		return toByte(decFF1(cipher, radix, tweak, len, num, num2, a, b));
	}

	public static ushort[] DecryptFF1w(IBlockCipher cipher, int radix, byte[] tweak, ushort[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: true, radix, buf, off, len);
		int num = len / 2;
		int num2 = len - num;
		ushort[] array = new ushort[num];
		ushort[] array2 = new ushort[num2];
		Array.Copy(buf, off, array, 0, num);
		Array.Copy(buf, off + num, array2, 0, num2);
		return decFF1(cipher, radix, tweak, len, num, num2, array, array2);
	}

	private static ushort[] decFF1(IBlockCipher cipher, int radix, byte[] T, int n, int u, int v, ushort[] A, ushort[] B)
	{
		int t = T.Length;
		int num = (Ceil(System.Math.Log(radix) * (double)v / LOG2) + 7) / 8;
		int d = (num + 3) / 4 * 4 + 4;
		byte[] p = calculateP_FF1(radix, (byte)u, n, t);
		BigInteger bigInteger = BigInteger.ValueOf(radix);
		BigInteger[] array = calculateModUV(bigInteger, u, v);
		int num2 = u;
		for (int num3 = 9; num3 >= 0; num3--)
		{
			BigInteger n2 = calculateY_FF1(cipher, bigInteger, T, num, d, num3, p, A);
			num2 = n - num2;
			BigInteger m = array[num3 & 1];
			BigInteger x = SP80038G.num(bigInteger, B).Subtract(n2).Mod(m);
			ushort[] array2 = B;
			B = A;
			A = array2;
			str(bigInteger, x, num2, array2, 0);
		}
		return Arrays.Concatenate(A, B);
	}

	public static byte[] DecryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak64.Length != 8)
		{
			throw new ArgumentException();
		}
		return implDecryptFF3(cipher, radix, tweak64, buf, off, len);
	}

	public static byte[] DecryptFF3_1(IBlockCipher cipher, int radix, byte[] tweak56, byte[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak56.Length != 7)
		{
			throw new ArgumentException("tweak should be 56 bits");
		}
		byte[] tweak57 = calculateTweak64_FF3_1(tweak56);
		return implDecryptFF3(cipher, radix, tweak57, buf, off, len);
	}

	public static ushort[] DecryptFF3_1w(IBlockCipher cipher, int radix, byte[] tweak56, ushort[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak56.Length != 7)
		{
			throw new ArgumentException("tweak should be 56 bits");
		}
		byte[] tweak57 = calculateTweak64_FF3_1(tweak56);
		return implDecryptFF3w(cipher, radix, tweak57, buf, off, len);
	}

	public static byte[] EncryptFF1(IBlockCipher cipher, int radix, byte[] tweak, byte[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: true, radix, buf, off, len);
		int num = len / 2;
		int num2 = len - num;
		ushort[] a = toShort(buf, off, num);
		ushort[] b = toShort(buf, off + num, num2);
		return toByte(encFF1(cipher, radix, tweak, len, num, num2, a, b));
	}

	public static ushort[] EncryptFF1w(IBlockCipher cipher, int radix, byte[] tweak, ushort[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: true, radix, buf, off, len);
		int num = len / 2;
		int num2 = len - num;
		ushort[] array = new ushort[num];
		ushort[] array2 = new ushort[num2];
		Array.Copy(buf, off, array, 0, num);
		Array.Copy(buf, off + num, array2, 0, num2);
		return encFF1(cipher, radix, tweak, len, num, num2, array, array2);
	}

	private static ushort[] encFF1(IBlockCipher cipher, int radix, byte[] T, int n, int u, int v, ushort[] A, ushort[] B)
	{
		int t = T.Length;
		int num = (Ceil(System.Math.Log(radix) * (double)v / LOG2) + 7) / 8;
		int d = (num + 3) / 4 * 4 + 4;
		byte[] p = calculateP_FF1(radix, (byte)u, n, t);
		BigInteger bigInteger = BigInteger.ValueOf(radix);
		BigInteger[] array = calculateModUV(bigInteger, u, v);
		int num2 = v;
		for (int i = 0; i < 10; i++)
		{
			BigInteger value = calculateY_FF1(cipher, bigInteger, T, num, d, i, p, B);
			num2 = n - num2;
			BigInteger m = array[i & 1];
			BigInteger x = SP80038G.num(bigInteger, A).Add(value).Mod(m);
			ushort[] array2 = A;
			A = B;
			B = array2;
			str(bigInteger, x, num2, array2, 0);
		}
		return Arrays.Concatenate(A, B);
	}

	public static byte[] EncryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak64.Length != 8)
		{
			throw new ArgumentException();
		}
		return implEncryptFF3(cipher, radix, tweak64, buf, off, len);
	}

	public static ushort[] EncryptFF3w(IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak64.Length != 8)
		{
			throw new ArgumentException();
		}
		return implEncryptFF3w(cipher, radix, tweak64, buf, off, len);
	}

	public static ushort[] EncryptFF3_1w(IBlockCipher cipher, int radix, byte[] tweak56, ushort[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak56.Length != 7)
		{
			throw new ArgumentException("tweak should be 56 bits");
		}
		byte[] tweak57 = calculateTweak64_FF3_1(tweak56);
		return EncryptFF3w(cipher, radix, tweak57, buf, off, len);
	}

	public static byte[] EncryptFF3_1(IBlockCipher cipher, int radix, byte[] tweak56, byte[] buf, int off, int len)
	{
		checkArgs(cipher, isFF1: false, radix, buf, off, len);
		if (tweak56.Length != 7)
		{
			throw new ArgumentException("tweak should be 56 bits");
		}
		byte[] tweak57 = calculateTweak64_FF3_1(tweak56);
		return EncryptFF3(cipher, radix, tweak57, buf, off, len);
	}

	protected static BigInteger[] calculateModUV(BigInteger bigRadix, int u, int v)
	{
		BigInteger[] array = new BigInteger[2];
		array[0] = bigRadix.Pow(u);
		array[1] = array[0];
		if (v != u)
		{
			array[1] = array[1].Multiply(bigRadix);
		}
		return array;
	}

	protected static byte[] calculateP_FF1(int radix, byte uLow, int n, int t)
	{
		byte[] array = new byte[BLOCK_SIZE];
		array[0] = 1;
		array[1] = 2;
		array[2] = 1;
		array[3] = 0;
		array[4] = (byte)(radix >> 8);
		array[5] = (byte)radix;
		array[6] = 10;
		array[7] = uLow;
		Pack.UInt32_To_BE((uint)n, array, 8);
		Pack.UInt32_To_BE((uint)t, array, 12);
		return array;
	}

	protected static byte[] calculateTweak64_FF3_1(byte[] tweak56)
	{
		return new byte[8]
		{
			tweak56[0],
			tweak56[1],
			tweak56[2],
			(byte)(tweak56[3] & 0xF0u),
			tweak56[4],
			tweak56[5],
			tweak56[6],
			(byte)(tweak56[3] << 4)
		};
	}

	protected static BigInteger calculateY_FF1(IBlockCipher cipher, BigInteger bigRadix, byte[] T, int b, int d, int round, byte[] P, ushort[] AB)
	{
		int num = T.Length;
		byte[] array = BigIntegers.AsUnsignedByteArray(SP80038G.num(bigRadix, AB));
		int num2 = -(num + b + 1) & 0xF;
		byte[] array2 = new byte[num + num2 + 1 + b];
		Array.Copy(T, 0, array2, 0, num);
		array2[num + num2] = (byte)round;
		Array.Copy(array, 0, array2, array2.Length - array.Length, array.Length);
		byte[] array3 = prf(cipher, Arrays.Concatenate(P, array2));
		byte[] array4 = array3;
		if (d > BLOCK_SIZE)
		{
			int num3 = (d + BLOCK_SIZE - 1) / BLOCK_SIZE;
			array4 = new byte[num3 * BLOCK_SIZE];
			Array.Copy(array3, 0, array4, 0, BLOCK_SIZE);
			byte[] array5 = new byte[4];
			for (uint num4 = 1u; num4 < num3; num4++)
			{
				int num5 = (int)(num4 * BLOCK_SIZE);
				Array.Copy(array3, 0, array4, num5, BLOCK_SIZE);
				Pack.UInt32_To_BE(num4, array5, 0);
				xor(array5, 0, array4, num5 + BLOCK_SIZE - 4, 4);
				cipher.ProcessBlock(array4, num5, array4, num5);
			}
		}
		return SP80038G.num(array4, 0, d);
	}

	protected static BigInteger calculateY_FF3(IBlockCipher cipher, BigInteger bigRadix, byte[] T, int wOff, uint round, ushort[] AB)
	{
		byte[] array = new byte[BLOCK_SIZE];
		Pack.UInt32_To_BE(round, array, 0);
		xor(T, wOff, array, 0, 4);
		byte[] array2 = BigIntegers.AsUnsignedByteArray(num(bigRadix, AB));
		if (array.Length - array2.Length < 4)
		{
			throw new InvalidOperationException("input out of range");
		}
		Array.Copy(array2, 0, array, array.Length - array2.Length, array2.Length);
		rev(array);
		cipher.ProcessBlock(array, 0, array, 0);
		rev(array);
		byte[] array3 = array;
		return num(array3, 0, array3.Length);
	}

	protected static void checkArgs(IBlockCipher cipher, bool isFF1, int radix, ushort[] buf, int off, int len)
	{
		checkCipher(cipher);
		if (radix < 2 || radix > 65536)
		{
			throw new ArgumentException();
		}
		checkData(isFF1, radix, buf, off, len);
	}

	protected static void checkArgs(IBlockCipher cipher, bool isFF1, int radix, byte[] buf, int off, int len)
	{
		checkCipher(cipher);
		if (radix < 2 || radix > 256)
		{
			throw new ArgumentException();
		}
		checkData(isFF1, radix, buf, off, len);
	}

	protected static void checkCipher(IBlockCipher cipher)
	{
		if (BLOCK_SIZE != cipher.GetBlockSize())
		{
			throw new ArgumentException();
		}
	}

	protected static void checkData(bool isFF1, int radix, ushort[] buf, int off, int len)
	{
		checkLength(isFF1, radix, len);
		int num = 0;
		while (true)
		{
			if (num < len)
			{
				if ((buf[off + num] & 0xFFFF) >= radix)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw new ArgumentException("input data outside of radix");
	}

	protected static void checkData(bool isFF1, int radix, byte[] buf, int off, int len)
	{
		checkLength(isFF1, radix, len);
		int num = 0;
		while (true)
		{
			if (num < len)
			{
				if ((buf[off + num] & 0xFF) >= radix)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw new ArgumentException("input data outside of radix");
	}

	private static void checkLength(bool isFF1, int radix, int len)
	{
		if (len >= 2 && System.Math.Pow(radix, len) >= 1000000.0)
		{
			if (!isFF1)
			{
				int num = 2 * (int)System.Math.Floor(System.Math.Log(TWO_TO_96) / System.Math.Log(radix));
				if (len > num)
				{
					throw new ArgumentException("maximum input length is " + num);
				}
			}
			return;
		}
		throw new ArgumentException("input too short");
	}

	protected static byte[] implDecryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		int num = len / 2;
		int num2 = len - num;
		ushort[] a = toShort(buf, off, num2);
		ushort[] b = toShort(buf, off + num2, num);
		return toByte(decFF3_1(cipher, radix, tweak64, len, num, num2, a, b));
	}

	protected static ushort[] implDecryptFF3w(IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
	{
		int num = len / 2;
		int num2 = len - num;
		ushort[] array = new ushort[num2];
		ushort[] array2 = new ushort[num];
		Array.Copy(buf, off, array, 0, num2);
		Array.Copy(buf, off + num2, array2, 0, num);
		return decFF3_1(cipher, radix, tweak64, len, num, num2, array, array2);
	}

	private static ushort[] decFF3_1(IBlockCipher cipher, int radix, byte[] T, int n, int v, int u, ushort[] A, ushort[] B)
	{
		BigInteger bigInteger = BigInteger.ValueOf(radix);
		BigInteger[] array = calculateModUV(bigInteger, v, u);
		int num = u;
		rev(A);
		rev(B);
		for (int num2 = 7; num2 >= 0; num2--)
		{
			num = n - num;
			BigInteger m = array[1 - (num2 & 1)];
			int wOff = 4 - (num2 & 1) * 4;
			BigInteger n2 = calculateY_FF3(cipher, bigInteger, T, wOff, (uint)num2, A);
			BigInteger x = SP80038G.num(bigInteger, B).Subtract(n2).Mod(m);
			ushort[] array2 = B;
			B = A;
			A = array2;
			str(bigInteger, x, num, array2, 0);
		}
		rev(A);
		rev(B);
		return Arrays.Concatenate(A, B);
	}

	protected static byte[] implEncryptFF3(IBlockCipher cipher, int radix, byte[] tweak64, byte[] buf, int off, int len)
	{
		int num = len / 2;
		int num2 = len - num;
		ushort[] a = toShort(buf, off, num2);
		ushort[] b = toShort(buf, off + num2, num);
		return toByte(encFF3_1(cipher, radix, tweak64, len, num, num2, a, b));
	}

	protected static ushort[] implEncryptFF3w(IBlockCipher cipher, int radix, byte[] tweak64, ushort[] buf, int off, int len)
	{
		int num = len / 2;
		int num2 = len - num;
		ushort[] array = new ushort[num2];
		ushort[] array2 = new ushort[num];
		Array.Copy(buf, off, array, 0, num2);
		Array.Copy(buf, off + num2, array2, 0, num);
		return encFF3_1(cipher, radix, tweak64, len, num, num2, array, array2);
	}

	private static ushort[] encFF3_1(IBlockCipher cipher, int radix, byte[] t, int n, int v, int u, ushort[] a, ushort[] b)
	{
		BigInteger bigInteger = BigInteger.ValueOf(radix);
		BigInteger[] array = calculateModUV(bigInteger, v, u);
		int num = v;
		rev(a);
		rev(b);
		for (uint num2 = 0u; num2 < 8; num2++)
		{
			num = n - num;
			BigInteger m = array[1 - (num2 & 1)];
			int wOff = (int)(4 - (num2 & 1) * 4);
			BigInteger value = calculateY_FF3(cipher, bigInteger, t, wOff, num2, b);
			BigInteger x = SP80038G.num(bigInteger, a).Add(value).Mod(m);
			ushort[] array2 = a;
			a = b;
			b = array2;
			str(bigInteger, x, num, array2, 0);
		}
		rev(a);
		rev(b);
		return Arrays.Concatenate(a, b);
	}

	protected static BigInteger num(byte[] buf, int off, int len)
	{
		return new BigInteger(1, Arrays.CopyOfRange(buf, off, off + len));
	}

	protected static BigInteger num(BigInteger R, ushort[] x)
	{
		BigInteger bigInteger = BigInteger.Zero;
		for (int i = 0; i < x.Length; i++)
		{
			bigInteger = bigInteger.Multiply(R).Add(BigInteger.ValueOf(x[i] & 0xFFFF));
		}
		return bigInteger;
	}

	protected static byte[] prf(IBlockCipher c, byte[] x)
	{
		if (x.Length % BLOCK_SIZE != 0)
		{
			throw new ArgumentException();
		}
		int num = x.Length / BLOCK_SIZE;
		byte[] array = new byte[BLOCK_SIZE];
		for (int i = 0; i < num; i++)
		{
			xor(x, i * BLOCK_SIZE, array, 0, BLOCK_SIZE);
			c.ProcessBlock(array, 0, array, 0);
		}
		return array;
	}

	protected static void rev(byte[] x)
	{
		int num = x.Length / 2;
		int num2 = x.Length - 1;
		for (int i = 0; i < num; i++)
		{
			byte b = x[i];
			x[i] = x[num2 - i];
			x[num2 - i] = b;
		}
	}

	protected static void rev(ushort[] x)
	{
		int num = x.Length / 2;
		int num2 = x.Length - 1;
		for (int i = 0; i < num; i++)
		{
			ushort num3 = x[i];
			x[i] = x[num2 - i];
			x[num2 - i] = num3;
		}
	}

	protected static void str(BigInteger R, BigInteger x, int m, ushort[] output, int off)
	{
		if (x.SignValue < 0)
		{
			throw new ArgumentException();
		}
		for (int i = 1; i <= m; i++)
		{
			BigInteger[] array = x.DivideAndRemainder(R);
			output[off + m - i] = (ushort)array[1].IntValue;
			x = array[0];
		}
		if (x.SignValue != 0)
		{
			throw new ArgumentException();
		}
	}

	protected static void xor(byte[] x, int xOff, byte[] y, int yOff, int len)
	{
		for (int i = 0; i < len; i++)
		{
			y[yOff + i] ^= x[xOff + i];
		}
	}

	private static byte[] toByte(ushort[] buf)
	{
		byte[] array = new byte[buf.Length];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = (byte)buf[i];
		}
		return array;
	}

	private static ushort[] toShort(byte[] buf, int off, int len)
	{
		ushort[] array = new ushort[len];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = (ushort)(buf[off + i] & 0xFFu);
		}
		return array;
	}

	private static int Ceil(double v)
	{
		int num = (int)v;
		if ((double)num < v)
		{
			return num + 1;
		}
		return num;
	}
}
