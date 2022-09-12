using System.Runtime.CompilerServices;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

public abstract class X448
{
	private const uint C_A = 156326u;

	private const uint C_A24 = 39082u;

	private static readonly uint[] S_x = new uint[16]
	{
		268435454u, 268435455u, 268435455u, 268435455u, 268435455u, 268435455u, 268435455u, 268435455u, 268435454u, 268435455u,
		268435455u, 268435455u, 268435455u, 268435455u, 268435455u, 268435455u
	};

	private static readonly uint[] PsubS_x = new uint[16]
	{
		161294112u, 185702364u, 163248300u, 54522310u, 189866924u, 105098465u, 66174309u, 139206530u, 156517789u, 136025714u,
		231801628u, 246922668u, 59251455u, 69446896u, 83964484u, 252685170u
	};

	private static uint[] precompBase = null;

	private static uint Decode32(byte[] bs, int off)
	{
		uint num = bs[off];
		num |= (uint)(bs[++off] << 8);
		num |= (uint)(bs[++off] << 16);
		return num | (uint)(bs[++off] << 24);
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		for (int i = 0; i < 14; i++)
		{
			n[i] = Decode32(k, kOff + i * 4);
		}
		uint[] array;
		(array = n)[0] = array[0] & 0xFFFFFFFCu;
		(array = n)[13] = array[13] | 0x80000000u;
	}

	private static void PointDouble(uint[] x, uint[] z)
	{
		uint[] array = X448Field.Create();
		uint[] array2 = X448Field.Create();
		X448Field.Add(x, z, array);
		X448Field.Sub(x, z, array2);
		X448Field.Sqr(array, array);
		X448Field.Sqr(array2, array2);
		X448Field.Mul(array, array2, x);
		X448Field.Sub(array, array2, array);
		X448Field.Mul(array, 39082u, z);
		X448Field.Add(z, array2, z);
		X448Field.Mul(z, array, z);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void Precompute()
	{
		if (precompBase != null)
		{
			return;
		}
		precompBase = new uint[7136];
		uint[] array = precompBase;
		uint[] array2 = new uint[7120];
		uint[] array3 = X448Field.Create();
		array3[0] = 5u;
		uint[] array4 = X448Field.Create();
		array4[0] = 1u;
		uint[] array5 = X448Field.Create();
		uint[] array6 = X448Field.Create();
		X448Field.Add(array3, array4, array5);
		X448Field.Sub(array3, array4, array6);
		uint[] array7 = X448Field.Create();
		X448Field.Copy(array6, 0, array7, 0);
		int num = 0;
		while (true)
		{
			X448Field.Copy(array5, 0, array, num);
			if (num == 7120)
			{
				break;
			}
			PointDouble(array3, array4);
			X448Field.Add(array3, array4, array5);
			X448Field.Sub(array3, array4, array6);
			X448Field.Mul(array5, array7, array5);
			X448Field.Mul(array7, array6, array7);
			X448Field.Copy(array6, 0, array2, num);
			num += 16;
		}
		uint[] array8 = X448Field.Create();
		X448Field.Inv(array7, array8);
		while (true)
		{
			X448Field.Copy(array, num, array3, 0);
			X448Field.Mul(array3, array8, array3);
			X448Field.Copy(array3, 0, precompBase, num);
			if (num != 0)
			{
				num -= 16;
				X448Field.Copy(array2, num, array4, 0);
				X448Field.Mul(array8, array4, array8);
				continue;
			}
			break;
		}
	}

	public static void ScalarMult(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
	{
		uint[] array = new uint[14];
		DecodeScalar(k, kOff, array);
		uint[] array2 = X448Field.Create();
		X448Field.Decode(u, uOff, array2);
		uint[] array3 = X448Field.Create();
		X448Field.Copy(array2, 0, array3, 0);
		uint[] array4 = X448Field.Create();
		array4[0] = 1u;
		uint[] array5 = X448Field.Create();
		array5[0] = 1u;
		uint[] array6 = X448Field.Create();
		uint[] array7 = X448Field.Create();
		uint[] array8 = X448Field.Create();
		int num = 447;
		int num2 = 1;
		do
		{
			X448Field.Add(array5, array6, array7);
			X448Field.Sub(array5, array6, array5);
			X448Field.Add(array3, array4, array6);
			X448Field.Sub(array3, array4, array3);
			X448Field.Mul(array7, array3, array7);
			X448Field.Mul(array5, array6, array5);
			X448Field.Sqr(array6, array6);
			X448Field.Sqr(array3, array3);
			X448Field.Sub(array6, array3, array8);
			X448Field.Mul(array8, 39082u, array4);
			X448Field.Add(array4, array3, array4);
			X448Field.Mul(array4, array8, array4);
			X448Field.Mul(array3, array6, array3);
			X448Field.Sub(array7, array5, array6);
			X448Field.Add(array7, array5, array5);
			X448Field.Sqr(array5, array5);
			X448Field.Sqr(array6, array6);
			X448Field.Mul(array6, array2, array6);
			num--;
			int num3 = num >> 5;
			int num4 = num & 0x1F;
			int num5 = (int)((array[num3] >> num4) & 1);
			num2 ^= num5;
			X448Field.CSwap(num2, array3, array5);
			X448Field.CSwap(num2, array4, array6);
			num2 = num5;
		}
		while (num >= 2);
		for (int i = 0; i < 2; i++)
		{
			PointDouble(array3, array4);
		}
		X448Field.Inv(array4, array4);
		X448Field.Mul(array3, array4, array3);
		X448Field.Normalize(array3);
		X448Field.Encode(array3, r, rOff);
	}

	public static void ScalarMultBase(byte[] k, int kOff, byte[] r, int rOff)
	{
		Precompute();
		uint[] array = new uint[14];
		DecodeScalar(k, kOff, array);
		uint[] array2 = X448Field.Create();
		uint[] array3 = X448Field.Create();
		X448Field.Copy(S_x, 0, array3, 0);
		uint[] array4 = X448Field.Create();
		array4[0] = 1u;
		uint[] array5 = X448Field.Create();
		X448Field.Copy(PsubS_x, 0, array5, 0);
		uint[] array6 = X448Field.Create();
		array6[0] = 1u;
		uint[] array7 = X448Field.Create();
		uint[] array8 = array4;
		uint[] array9 = array2;
		uint[] array10 = array3;
		uint[] array11 = array8;
		int num = 0;
		int num2 = 2;
		int num3 = 1;
		do
		{
			X448Field.Copy(precompBase, num, array2, 0);
			num += 16;
			int num4 = num2 >> 5;
			int num5 = num2 & 0x1F;
			int num6 = (int)((array[num4] >> num5) & 1);
			num3 ^= num6;
			X448Field.CSwap(num3, array3, array5);
			X448Field.CSwap(num3, array4, array6);
			num3 = num6;
			X448Field.Add(array3, array4, array7);
			X448Field.Sub(array3, array4, array8);
			X448Field.Mul(array2, array8, array9);
			X448Field.Carry(array7);
			X448Field.Add(array7, array9, array10);
			X448Field.Sub(array7, array9, array11);
			X448Field.Sqr(array10, array10);
			X448Field.Sqr(array11, array11);
			X448Field.Mul(array6, array10, array3);
			X448Field.Mul(array5, array11, array4);
		}
		while (++num2 < 448);
		for (int i = 0; i < 2; i++)
		{
			PointDouble(array3, array4);
		}
		X448Field.Inv(array4, array4);
		X448Field.Mul(array3, array4, array3);
		X448Field.Normalize(array3);
		X448Field.Encode(array3, r, rOff);
	}
}
