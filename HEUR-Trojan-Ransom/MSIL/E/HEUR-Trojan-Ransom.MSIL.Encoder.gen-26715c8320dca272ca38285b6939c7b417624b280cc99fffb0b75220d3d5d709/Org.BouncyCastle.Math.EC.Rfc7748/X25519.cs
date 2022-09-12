using System.Runtime.CompilerServices;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

public abstract class X25519
{
	private const int C_A = 486662;

	private const int C_A24 = 121666;

	private static readonly int[] PsubS_x = new int[10] { 64258704, 46628941, 18905110, 42949224, 8920788, 10663709, 35115447, 21804323, 8973338, 4366948 };

	private static int[] precompBase = null;

	private static uint Decode32(byte[] bs, int off)
	{
		uint num = bs[off];
		num |= (uint)(bs[++off] << 8);
		num |= (uint)(bs[++off] << 16);
		return num | (uint)(bs[++off] << 24);
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		for (int i = 0; i < 8; i++)
		{
			n[i] = Decode32(k, kOff + i * 4);
		}
		uint[] array;
		(array = n)[0] = array[0] & 0xFFFFFFF8u;
		(array = n)[7] = array[7] & 0x7FFFFFFFu;
		(array = n)[7] = array[7] | 0x40000000u;
	}

	private static void PointDouble(int[] x, int[] z)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		X25519Field.Apm(x, z, array, array2);
		X25519Field.Sqr(array, array);
		X25519Field.Sqr(array2, array2);
		X25519Field.Mul(array, array2, x);
		X25519Field.Sub(array, array2, array);
		X25519Field.Mul(array, 121666, z);
		X25519Field.Add(z, array2, z);
		X25519Field.Mul(z, array, z);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void Precompute()
	{
		if (precompBase != null)
		{
			return;
		}
		precompBase = new int[2520];
		int[] array = precompBase;
		int[] array2 = new int[2510];
		int[] array3 = X25519Field.Create();
		array3[0] = 9;
		int[] array4 = X25519Field.Create();
		array4[0] = 1;
		int[] array5 = X25519Field.Create();
		int[] array6 = X25519Field.Create();
		X25519Field.Apm(array3, array4, array5, array6);
		int[] array7 = X25519Field.Create();
		X25519Field.Copy(array6, 0, array7, 0);
		int num = 0;
		while (true)
		{
			X25519Field.Copy(array5, 0, array, num);
			if (num == 2510)
			{
				break;
			}
			PointDouble(array3, array4);
			X25519Field.Apm(array3, array4, array5, array6);
			X25519Field.Mul(array5, array7, array5);
			X25519Field.Mul(array7, array6, array7);
			X25519Field.Copy(array6, 0, array2, num);
			num += 10;
		}
		int[] array8 = X25519Field.Create();
		X25519Field.Inv(array7, array8);
		while (true)
		{
			X25519Field.Copy(array, num, array3, 0);
			X25519Field.Mul(array3, array8, array3);
			X25519Field.Copy(array3, 0, precompBase, num);
			if (num != 0)
			{
				num -= 10;
				X25519Field.Copy(array2, num, array4, 0);
				X25519Field.Mul(array8, array4, array8);
				continue;
			}
			break;
		}
	}

	public static void ScalarMult(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
	{
		uint[] array = new uint[8];
		DecodeScalar(k, kOff, array);
		int[] array2 = X25519Field.Create();
		X25519Field.Decode(u, uOff, array2);
		int[] array3 = X25519Field.Create();
		X25519Field.Copy(array2, 0, array3, 0);
		int[] array4 = X25519Field.Create();
		array4[0] = 1;
		int[] array5 = X25519Field.Create();
		array5[0] = 1;
		int[] array6 = X25519Field.Create();
		int[] array7 = X25519Field.Create();
		int[] array8 = X25519Field.Create();
		int num = 254;
		int num2 = 1;
		do
		{
			X25519Field.Apm(array5, array6, array7, array5);
			X25519Field.Apm(array3, array4, array6, array3);
			X25519Field.Mul(array7, array3, array7);
			X25519Field.Mul(array5, array6, array5);
			X25519Field.Sqr(array6, array6);
			X25519Field.Sqr(array3, array3);
			X25519Field.Sub(array6, array3, array8);
			X25519Field.Mul(array8, 121666, array4);
			X25519Field.Add(array4, array3, array4);
			X25519Field.Mul(array4, array8, array4);
			X25519Field.Mul(array3, array6, array3);
			X25519Field.Apm(array7, array5, array5, array6);
			X25519Field.Sqr(array5, array5);
			X25519Field.Sqr(array6, array6);
			X25519Field.Mul(array6, array2, array6);
			num--;
			int num3 = num >> 5;
			int num4 = num & 0x1F;
			int num5 = (int)((array[num3] >> num4) & 1);
			num2 ^= num5;
			X25519Field.CSwap(num2, array3, array5);
			X25519Field.CSwap(num2, array4, array6);
			num2 = num5;
		}
		while (num >= 3);
		for (int i = 0; i < 3; i++)
		{
			PointDouble(array3, array4);
		}
		X25519Field.Inv(array4, array4);
		X25519Field.Mul(array3, array4, array3);
		X25519Field.Normalize(array3);
		X25519Field.Encode(array3, r, rOff);
	}

	public static void ScalarMultBase(byte[] k, int kOff, byte[] r, int rOff)
	{
		Precompute();
		uint[] array = new uint[8];
		DecodeScalar(k, kOff, array);
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		array3[0] = 1;
		int[] array4 = X25519Field.Create();
		array4[0] = 1;
		int[] array5 = X25519Field.Create();
		X25519Field.Copy(PsubS_x, 0, array5, 0);
		int[] array6 = X25519Field.Create();
		array6[0] = 1;
		int[] array7 = array3;
		int[] array8 = array4;
		int[] array9 = array2;
		int[] array10 = array7;
		int[] array11 = array8;
		int num = 0;
		int num2 = 3;
		int num3 = 1;
		do
		{
			X25519Field.Copy(precompBase, num, array2, 0);
			num += 10;
			int num4 = num2 >> 5;
			int num5 = num2 & 0x1F;
			int num6 = (int)((array[num4] >> num5) & 1);
			num3 ^= num6;
			X25519Field.CSwap(num3, array3, array5);
			X25519Field.CSwap(num3, array4, array6);
			num3 = num6;
			X25519Field.Apm(array3, array4, array7, array8);
			X25519Field.Mul(array2, array8, array9);
			X25519Field.Carry(array7);
			X25519Field.Apm(array7, array9, array10, array11);
			X25519Field.Sqr(array10, array10);
			X25519Field.Sqr(array11, array11);
			X25519Field.Mul(array6, array10, array3);
			X25519Field.Mul(array5, array11, array4);
		}
		while (++num2 < 255);
		for (int i = 0; i < 3; i++)
		{
			PointDouble(array3, array4);
		}
		X25519Field.Inv(array4, array4);
		X25519Field.Mul(array3, array4, array3);
		X25519Field.Normalize(array3);
		X25519Field.Encode(array3, r, rOff);
	}
}
