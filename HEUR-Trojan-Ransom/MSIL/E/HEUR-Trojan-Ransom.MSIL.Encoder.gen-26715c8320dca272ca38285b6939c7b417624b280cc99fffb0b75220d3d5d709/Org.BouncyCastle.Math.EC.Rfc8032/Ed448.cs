using System;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc8032;

public abstract class Ed448
{
	private class PointExt
	{
		internal uint[] x = X448Field.Create();

		internal uint[] y = X448Field.Create();

		internal uint[] z = X448Field.Create();
	}

	private class PointPrecomp
	{
		internal uint[] x = X448Field.Create();

		internal uint[] y = X448Field.Create();
	}

	private const ulong M26UL = 67108863uL;

	private const ulong M28UL = 268435455uL;

	private const int PointBytes = 57;

	private const int ScalarUints = 14;

	private const int ScalarBytes = 57;

	private const int L_0 = 78101261;

	private const int L_1 = 141809365;

	private const int L_2 = 175155932;

	private const int L_3 = 64542499;

	private const int L_4 = 158326419;

	private const int L_5 = 191173276;

	private const int L_6 = 104575268;

	private const int L_7 = 137584065;

	private const int L4_0 = 43969588;

	private const int L4_1 = 30366549;

	private const int L4_2 = 163752818;

	private const int L4_3 = 258169998;

	private const int L4_4 = 96434764;

	private const int L4_5 = 227822194;

	private const int L4_6 = 149865618;

	private const int L4_7 = 550336261;

	private const int C_d = -39081;

	private const int WnafWidthBase = 7;

	private const int PrecompBlocks = 5;

	private const int PrecompTeeth = 5;

	private const int PrecompSpacing = 18;

	private const int PrecompPoints = 16;

	private const int PrecompMask = 15;

	public static readonly int PublicKeySize = 57;

	public static readonly int SecretKeySize = 57;

	public static readonly int SignatureSize = 114;

	private static readonly byte[] Dom4Prefix = Strings.ToByteArray("SigEd448");

	private static readonly uint[] P = new uint[14]
	{
		4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967294u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 4294967295u
	};

	private static readonly uint[] L = new uint[14]
	{
		2874688755u, 595116690u, 2378534741u, 560775794u, 2933274256u, 3293502281u, 2093622249u, 4294967295u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 1073741823u
	};

	private static readonly BigInteger N = Nat.ToBigInteger(L.Length, L);

	private static readonly uint[] B_x = new uint[16]
	{
		118276190u, 40534716u, 9670182u, 135141552u, 85017403u, 259173222u, 68333082u, 171784774u, 174973732u, 15824510u,
		73756743u, 57518561u, 94773951u, 248652241u, 107736333u, 82941708u
	};

	private static readonly uint[] B_y = new uint[16]
	{
		36764180u, 8885695u, 130592152u, 20104429u, 163904957u, 30304195u, 121295871u, 5901357u, 125344798u, 171541512u,
		175338348u, 209069246u, 3626697u, 38307682u, 24032956u, 110359655u
	};

	private static PointExt[] precompBaseTable = null;

	private static uint[] precompBase = null;

	private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
	{
		uint[] array = new uint[28];
		DecodeScalar(r, 0, array);
		uint[] array2 = new uint[14];
		DecodeScalar(k, 0, array2);
		uint[] array3 = new uint[14];
		DecodeScalar(s, 0, array3);
		Nat.MulAddTo(14, array2, array3, array);
		byte[] array4 = new byte[114];
		for (int i = 0; i < array.Length; i++)
		{
			Encode32(array[i], array4, i * 4);
		}
		return ReduceScalar(array4);
	}

	private static bool CheckContextVar(byte[] ctx)
	{
		if (ctx != null)
		{
			return ctx.Length < 256;
		}
		return false;
	}

	private static bool CheckPointVar(byte[] p)
	{
		if ((p[56] & 0x7Fu) != 0)
		{
			return false;
		}
		uint[] array = new uint[14];
		Decode32(p, 0, array, 0, 14);
		return !Nat.Gte(14, array, P);
	}

	private static bool CheckScalarVar(byte[] s)
	{
		if (s[56] != 0)
		{
			return false;
		}
		uint[] array = new uint[14];
		DecodeScalar(s, 0, array);
		return !Nat.Gte(14, array, L);
	}

	private static uint Decode16(byte[] bs, int off)
	{
		uint num = bs[off];
		return num | (uint)(bs[++off] << 8);
	}

	private static uint Decode24(byte[] bs, int off)
	{
		uint num = bs[off];
		num |= (uint)(bs[++off] << 8);
		return num | (uint)(bs[++off] << 16);
	}

	private static uint Decode32(byte[] bs, int off)
	{
		uint num = bs[off];
		num |= (uint)(bs[++off] << 8);
		num |= (uint)(bs[++off] << 16);
		return num | (uint)(bs[++off] << 24);
	}

	private static void Decode32(byte[] bs, int bsOff, uint[] n, int nOff, int nLen)
	{
		for (int i = 0; i < nLen; i++)
		{
			n[nOff + i] = Decode32(bs, bsOff + i * 4);
		}
	}

	private static bool DecodePointVar(byte[] p, int pOff, bool negate, PointExt r)
	{
		byte[] array = Arrays.CopyOfRange(p, pOff, pOff + 57);
		if (!CheckPointVar(array))
		{
			return false;
		}
		int num = (array[56] & 0x80) >> 7;
		byte[] array2;
		(array2 = array)[56] = (byte)(array2[56] & 0x7Fu);
		X448Field.Decode(array, 0, r.y);
		uint[] array3 = X448Field.Create();
		uint[] array4 = X448Field.Create();
		X448Field.Sqr(r.y, array3);
		X448Field.Mul(array3, 39081u, array4);
		X448Field.Negate(array3, array3);
		X448Field.AddOne(array3);
		X448Field.AddOne(array4);
		if (!X448Field.SqrtRatioVar(array3, array4, r.x))
		{
			return false;
		}
		X448Field.Normalize(r.x);
		if (num == 1 && X448Field.IsZeroVar(r.x))
		{
			return false;
		}
		if (negate ^ (num != (r.x[0] & 1)))
		{
			X448Field.Negate(r.x, r.x);
		}
		PointExtendXY(r);
		return true;
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		Decode32(k, kOff, n, 0, 14);
	}

	private static void Dom4(ShakeDigest d, byte x, byte[] y)
	{
		d.BlockUpdate(Dom4Prefix, 0, Dom4Prefix.Length);
		d.Update(x);
		d.Update((byte)y.Length);
		d.BlockUpdate(y, 0, y.Length);
	}

	private static void Encode24(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
	}

	private static void Encode32(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
		bs[++off] = (byte)(n >> 24);
	}

	private static void Encode56(ulong n, byte[] bs, int off)
	{
		Encode32((uint)n, bs, off);
		Encode24((uint)(n >> 32), bs, off + 4);
	}

	private static void EncodePoint(PointExt p, byte[] r, int rOff)
	{
		uint[] array = X448Field.Create();
		uint[] array2 = X448Field.Create();
		X448Field.Inv(p.z, array2);
		X448Field.Mul(p.x, array2, array);
		X448Field.Mul(p.y, array2, array2);
		X448Field.Normalize(array);
		X448Field.Normalize(array2);
		X448Field.Encode(array2, r, rOff);
		r[rOff + 57 - 1] = (byte)((array[0] & 1) << 7);
	}

	public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
	{
		ShakeDigest shakeDigest = new ShakeDigest(256);
		byte[] array = new byte[114];
		shakeDigest.BlockUpdate(sk, skOff, SecretKeySize);
		shakeDigest.DoFinal(array, 0, array.Length);
		byte[] array2 = new byte[57];
		PruneScalar(array, 0, array2);
		ScalarMultBaseEncoded(array2, pk, pkOff);
	}

	private static sbyte[] GetWnaf(uint[] n, int width)
	{
		uint[] array = new uint[28];
		uint num = 0u;
		int num2 = array.Length;
		int num3 = 14;
		while (--num3 >= 0)
		{
			uint num4 = n[num3];
			array[--num2] = (num4 >> 16) | (num << 16);
			num = (array[--num2] = num4);
		}
		sbyte[] array2 = new sbyte[448];
		uint num5 = (uint)(1 << width);
		uint num6 = num5 - 1;
		uint num7 = num5 >> 1;
		uint num8 = 0u;
		int num9 = 0;
		int num10 = 0;
		while (num10 < array.Length)
		{
			uint num11 = array[num10];
			while (num9 < 16)
			{
				uint num12 = num11 >> num9;
				uint num13 = num12 & 1u;
				if (num13 == num8)
				{
					num9++;
					continue;
				}
				uint num14 = (num12 & num6) + num8;
				num8 = num14 & num7;
				num14 -= num8 << 1;
				num8 >>= width - 1;
				array2[(num10 << 4) + num9] = (sbyte)num14;
				num9 += width;
			}
			num10++;
			num9 -= 16;
		}
		return array2;
	}

	private static void ImplSign(ShakeDigest d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		Dom4(d, 0, ctx);
		d.BlockUpdate(h, 57, 57);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0, h.Length);
		byte[] array = ReduceScalar(h);
		byte[] array2 = new byte[57];
		ScalarMultBaseEncoded(array, array2, 0);
		Dom4(d, 0, ctx);
		d.BlockUpdate(array2, 0, 57);
		d.BlockUpdate(pk, pkOff, 57);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0, h.Length);
		byte[] k = ReduceScalar(h);
		byte[] sourceArray = CalculateS(array, k, s);
		Array.Copy(array2, 0, sig, sigOff, 57);
		Array.Copy(sourceArray, 0, sig, sigOff + 57, 57);
	}

	private static void PointAddVar(bool negate, PointExt p, PointExt r)
	{
		uint[] array = X448Field.Create();
		uint[] array2 = X448Field.Create();
		uint[] array3 = X448Field.Create();
		uint[] array4 = X448Field.Create();
		uint[] array5 = X448Field.Create();
		uint[] array6 = X448Field.Create();
		uint[] array7 = X448Field.Create();
		uint[] array8 = X448Field.Create();
		uint[] z;
		uint[] z2;
		uint[] z3;
		uint[] z4;
		if (negate)
		{
			z = array5;
			z2 = array2;
			z3 = array7;
			z4 = array6;
			X448Field.Sub(p.y, p.x, array8);
		}
		else
		{
			z = array2;
			z2 = array5;
			z3 = array6;
			z4 = array7;
			X448Field.Add(p.y, p.x, array8);
		}
		X448Field.Mul(p.z, r.z, array);
		X448Field.Sqr(array, array2);
		X448Field.Mul(p.x, r.x, array3);
		X448Field.Mul(p.y, r.y, array4);
		X448Field.Mul(array3, array4, array5);
		X448Field.Mul(array5, 39081u, array5);
		X448Field.Add(array2, array5, z3);
		X448Field.Sub(array2, array5, z4);
		X448Field.Add(r.x, r.y, array5);
		X448Field.Mul(array8, array5, array8);
		X448Field.Add(array4, array3, z);
		X448Field.Sub(array4, array3, z2);
		X448Field.Carry(z);
		X448Field.Sub(array8, array2, array8);
		X448Field.Mul(array8, array, array8);
		X448Field.Mul(array5, array, array5);
		X448Field.Mul(array6, array8, r.x);
		X448Field.Mul(array5, array7, r.y);
		X448Field.Mul(array6, array7, r.z);
	}

	private static void PointAddPrecomp(PointPrecomp p, PointExt r)
	{
		uint[] array = X448Field.Create();
		uint[] array2 = X448Field.Create();
		uint[] array3 = X448Field.Create();
		uint[] array4 = X448Field.Create();
		uint[] array5 = X448Field.Create();
		uint[] array6 = X448Field.Create();
		uint[] array7 = X448Field.Create();
		X448Field.Sqr(r.z, array);
		X448Field.Mul(p.x, r.x, array2);
		X448Field.Mul(p.y, r.y, array3);
		X448Field.Mul(array2, array3, array4);
		X448Field.Mul(array4, 39081u, array4);
		X448Field.Add(array, array4, array5);
		X448Field.Sub(array, array4, array6);
		X448Field.Add(p.x, p.y, array);
		X448Field.Add(r.x, r.y, array4);
		X448Field.Mul(array, array4, array7);
		X448Field.Add(array3, array2, array);
		X448Field.Sub(array3, array2, array4);
		X448Field.Carry(array);
		X448Field.Sub(array7, array, array7);
		X448Field.Mul(array7, r.z, array7);
		X448Field.Mul(array4, r.z, array4);
		X448Field.Mul(array5, array7, r.x);
		X448Field.Mul(array4, array6, r.y);
		X448Field.Mul(array5, array6, r.z);
	}

	private static PointExt PointCopy(PointExt p)
	{
		PointExt pointExt = new PointExt();
		X448Field.Copy(p.x, 0, pointExt.x, 0);
		X448Field.Copy(p.y, 0, pointExt.y, 0);
		X448Field.Copy(p.z, 0, pointExt.z, 0);
		return pointExt;
	}

	private static void PointDouble(PointExt r)
	{
		uint[] array = X448Field.Create();
		uint[] array2 = X448Field.Create();
		uint[] array3 = X448Field.Create();
		uint[] array4 = X448Field.Create();
		uint[] array5 = X448Field.Create();
		uint[] array6 = X448Field.Create();
		X448Field.Add(r.x, r.y, array);
		X448Field.Sqr(array, array);
		X448Field.Sqr(r.x, array2);
		X448Field.Sqr(r.y, array3);
		X448Field.Add(array2, array3, array4);
		X448Field.Carry(array4);
		X448Field.Sqr(r.z, array5);
		X448Field.Add(array5, array5, array5);
		X448Field.Carry(array5);
		X448Field.Sub(array4, array5, array6);
		X448Field.Sub(array, array4, array);
		X448Field.Sub(array2, array3, array2);
		X448Field.Mul(array, array6, r.x);
		X448Field.Mul(array4, array2, r.y);
		X448Field.Mul(array4, array6, r.z);
	}

	private static void PointExtendXY(PointExt p)
	{
		X448Field.One(p.z);
	}

	private static void PointLookup(int block, int index, PointPrecomp p)
	{
		int num = block * 16 * 2 * 16;
		for (int i = 0; i < 16; i++)
		{
			int mask = (i ^ index) - 1 >> 31;
			Nat.CMov(16, mask, precompBase, num, p.x, 0);
			num += 16;
			Nat.CMov(16, mask, precompBase, num, p.y, 0);
			num += 16;
		}
	}

	private static PointExt[] PointPrecompVar(PointExt p, int count)
	{
		PointExt pointExt = PointCopy(p);
		PointDouble(pointExt);
		PointExt[] array = new PointExt[count];
		array[0] = PointCopy(p);
		for (int i = 1; i < count; i++)
		{
			array[i] = PointCopy(array[i - 1]);
			PointAddVar(negate: false, pointExt, array[i]);
		}
		return array;
	}

	private static void PointSetNeutral(PointExt p)
	{
		X448Field.Zero(p.x);
		X448Field.One(p.y);
		X448Field.One(p.z);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void Precompute()
	{
		if (precompBase != null)
		{
			return;
		}
		PointExt pointExt = new PointExt();
		X448Field.Copy(B_x, 0, pointExt.x, 0);
		X448Field.Copy(B_y, 0, pointExt.y, 0);
		PointExtendXY(pointExt);
		precompBaseTable = PointPrecompVar(pointExt, 32);
		precompBase = new uint[2560];
		int num = 0;
		for (int i = 0; i < 5; i++)
		{
			PointExt[] array = new PointExt[5];
			PointExt pointExt2 = new PointExt();
			PointSetNeutral(pointExt2);
			for (int j = 0; j < 5; j++)
			{
				PointAddVar(negate: true, pointExt, pointExt2);
				PointDouble(pointExt);
				array[j] = PointCopy(pointExt);
				for (int k = 1; k < 18; k++)
				{
					PointDouble(pointExt);
				}
			}
			PointExt[] array2 = new PointExt[16];
			int num2 = 0;
			num2 = 1;
			array2[0] = pointExt2;
			for (int l = 0; l < 4; l++)
			{
				int num3 = 1 << l;
				int num4 = 0;
				while (num4 < num3)
				{
					array2[num2] = PointCopy(array2[num2 - num3]);
					PointAddVar(negate: false, array[l], array2[num2]);
					num4++;
					num2++;
				}
			}
			for (int m = 0; m < 16; m++)
			{
				PointExt pointExt3 = array2[m];
				X448Field.Inv(pointExt3.z, pointExt3.z);
				X448Field.Mul(pointExt3.x, pointExt3.z, pointExt3.x);
				X448Field.Mul(pointExt3.y, pointExt3.z, pointExt3.y);
				X448Field.Copy(pointExt3.x, 0, precompBase, num);
				num += 16;
				X448Field.Copy(pointExt3.y, 0, precompBase, num);
				num += 16;
			}
		}
	}

	private static void PruneScalar(byte[] n, int nOff, byte[] r)
	{
		Array.Copy(n, nOff, r, 0, 57);
		byte[] array;
		(array = r)[0] = (byte)(array[0] & 0xFCu);
		(array = r)[55] = (byte)(array[55] | 0x80u);
		r[56] = 0;
	}

	private static byte[] ReduceScalar(byte[] n)
	{
		ulong num = Decode32(n, 0);
		ulong num2 = Decode24(n, 4) << 4;
		ulong num3 = Decode32(n, 7);
		ulong num4 = Decode24(n, 11) << 4;
		ulong num5 = Decode32(n, 14);
		ulong num6 = Decode24(n, 18) << 4;
		ulong num7 = Decode32(n, 21);
		ulong num8 = Decode24(n, 25) << 4;
		ulong num9 = Decode32(n, 28);
		ulong num10 = Decode24(n, 32) << 4;
		ulong num11 = Decode32(n, 35);
		ulong num12 = Decode24(n, 39) << 4;
		ulong num13 = Decode32(n, 42);
		ulong num14 = Decode24(n, 46) << 4;
		ulong num15 = Decode32(n, 49);
		ulong num16 = Decode24(n, 53) << 4;
		ulong num17 = Decode32(n, 56);
		ulong num18 = Decode24(n, 60) << 4;
		ulong num19 = Decode32(n, 63);
		ulong num20 = Decode24(n, 67) << 4;
		ulong num21 = Decode32(n, 70);
		ulong num22 = Decode24(n, 74) << 4;
		ulong num23 = Decode32(n, 77);
		ulong num24 = Decode24(n, 81) << 4;
		ulong num25 = Decode32(n, 84);
		ulong num26 = Decode24(n, 88) << 4;
		ulong num27 = Decode32(n, 91);
		ulong num28 = Decode24(n, 95) << 4;
		ulong num29 = Decode32(n, 98);
		ulong num30 = Decode24(n, 102) << 4;
		ulong num31 = Decode32(n, 105);
		ulong num32 = Decode24(n, 109) << 4;
		ulong num33 = Decode16(n, 112);
		num17 += num33 * 43969588L;
		num18 += num33 * 30366549L;
		num19 += num33 * 163752818L;
		num20 += num33 * 258169998L;
		num21 += num33 * 96434764L;
		num22 += num33 * 227822194L;
		num23 += num33 * 149865618L;
		num24 += num33 * 550336261L;
		num32 += num31 >> 28;
		num31 &= 0xFFFFFFFuL;
		num16 += num32 * 43969588L;
		num17 += num32 * 30366549L;
		num18 += num32 * 163752818L;
		num19 += num32 * 258169998L;
		num20 += num32 * 96434764L;
		num21 += num32 * 227822194L;
		num22 += num32 * 149865618L;
		num23 += num32 * 550336261L;
		num15 += num31 * 43969588L;
		num16 += num31 * 30366549L;
		num17 += num31 * 163752818L;
		num18 += num31 * 258169998L;
		num19 += num31 * 96434764L;
		num20 += num31 * 227822194L;
		num21 += num31 * 149865618L;
		num22 += num31 * 550336261L;
		num30 += num29 >> 28;
		num29 &= 0xFFFFFFFuL;
		num14 += num30 * 43969588L;
		num15 += num30 * 30366549L;
		num16 += num30 * 163752818L;
		num17 += num30 * 258169998L;
		num18 += num30 * 96434764L;
		num19 += num30 * 227822194L;
		num20 += num30 * 149865618L;
		num21 += num30 * 550336261L;
		num13 += num29 * 43969588L;
		num14 += num29 * 30366549L;
		num15 += num29 * 163752818L;
		num16 += num29 * 258169998L;
		num17 += num29 * 96434764L;
		num18 += num29 * 227822194L;
		num19 += num29 * 149865618L;
		num20 += num29 * 550336261L;
		num28 += num27 >> 28;
		num27 &= 0xFFFFFFFuL;
		num12 += num28 * 43969588L;
		num13 += num28 * 30366549L;
		num14 += num28 * 163752818L;
		num15 += num28 * 258169998L;
		num16 += num28 * 96434764L;
		num17 += num28 * 227822194L;
		num18 += num28 * 149865618L;
		num19 += num28 * 550336261L;
		num11 += num27 * 43969588L;
		num12 += num27 * 30366549L;
		num13 += num27 * 163752818L;
		num14 += num27 * 258169998L;
		num15 += num27 * 96434764L;
		num16 += num27 * 227822194L;
		num17 += num27 * 149865618L;
		num18 += num27 * 550336261L;
		num26 += num25 >> 28;
		num25 &= 0xFFFFFFFuL;
		num10 += num26 * 43969588L;
		num11 += num26 * 30366549L;
		num12 += num26 * 163752818L;
		num13 += num26 * 258169998L;
		num14 += num26 * 96434764L;
		num15 += num26 * 227822194L;
		num16 += num26 * 149865618L;
		num17 += num26 * 550336261L;
		num22 += num21 >> 28;
		num21 &= 0xFFFFFFFuL;
		num23 += num22 >> 28;
		num22 &= 0xFFFFFFFuL;
		num24 += num23 >> 28;
		num23 &= 0xFFFFFFFuL;
		num25 += num24 >> 28;
		num24 &= 0xFFFFFFFuL;
		num9 += num25 * 43969588L;
		num10 += num25 * 30366549L;
		num11 += num25 * 163752818L;
		num12 += num25 * 258169998L;
		num13 += num25 * 96434764L;
		num14 += num25 * 227822194L;
		num15 += num25 * 149865618L;
		num16 += num25 * 550336261L;
		num8 += num24 * 43969588L;
		num9 += num24 * 30366549L;
		num10 += num24 * 163752818L;
		num11 += num24 * 258169998L;
		num12 += num24 * 96434764L;
		num13 += num24 * 227822194L;
		num14 += num24 * 149865618L;
		num15 += num24 * 550336261L;
		num7 += num23 * 43969588L;
		num8 += num23 * 30366549L;
		num9 += num23 * 163752818L;
		num10 += num23 * 258169998L;
		num11 += num23 * 96434764L;
		num12 += num23 * 227822194L;
		num13 += num23 * 149865618L;
		num14 += num23 * 550336261L;
		num19 += num18 >> 28;
		num18 &= 0xFFFFFFFuL;
		num20 += num19 >> 28;
		num19 &= 0xFFFFFFFuL;
		num21 += num20 >> 28;
		num20 &= 0xFFFFFFFuL;
		num22 += num21 >> 28;
		num21 &= 0xFFFFFFFuL;
		num6 += num22 * 43969588L;
		num7 += num22 * 30366549L;
		num8 += num22 * 163752818L;
		num9 += num22 * 258169998L;
		num10 += num22 * 96434764L;
		num11 += num22 * 227822194L;
		num12 += num22 * 149865618L;
		num13 += num22 * 550336261L;
		num5 += num21 * 43969588L;
		num6 += num21 * 30366549L;
		num7 += num21 * 163752818L;
		num8 += num21 * 258169998L;
		num9 += num21 * 96434764L;
		num10 += num21 * 227822194L;
		num11 += num21 * 149865618L;
		num12 += num21 * 550336261L;
		num4 += num20 * 43969588L;
		num5 += num20 * 30366549L;
		num6 += num20 * 163752818L;
		num7 += num20 * 258169998L;
		num8 += num20 * 96434764L;
		num9 += num20 * 227822194L;
		num10 += num20 * 149865618L;
		num11 += num20 * 550336261L;
		num16 += num15 >> 28;
		num15 &= 0xFFFFFFFuL;
		num17 += num16 >> 28;
		num16 &= 0xFFFFFFFuL;
		num18 += num17 >> 28;
		num17 &= 0xFFFFFFFuL;
		num19 += num18 >> 28;
		num18 &= 0xFFFFFFFuL;
		num3 += num19 * 43969588L;
		num4 += num19 * 30366549L;
		num5 += num19 * 163752818L;
		num6 += num19 * 258169998L;
		num7 += num19 * 96434764L;
		num8 += num19 * 227822194L;
		num9 += num19 * 149865618L;
		num10 += num19 * 550336261L;
		num2 += num18 * 43969588L;
		num3 += num18 * 30366549L;
		num4 += num18 * 163752818L;
		num5 += num18 * 258169998L;
		num6 += num18 * 96434764L;
		num7 += num18 * 227822194L;
		num8 += num18 * 149865618L;
		num9 += num18 * 550336261L;
		num17 *= 4L;
		num17 += num16 >> 26;
		num16 &= 0x3FFFFFFuL;
		num17++;
		num += num17 * 78101261L;
		num2 += num17 * 141809365L;
		num3 += num17 * 175155932L;
		num4 += num17 * 64542499L;
		num5 += num17 * 158326419L;
		num6 += num17 * 191173276L;
		num7 += num17 * 104575268L;
		num8 += num17 * 137584065L;
		num2 += num >> 28;
		num &= 0xFFFFFFFuL;
		num3 += num2 >> 28;
		num2 &= 0xFFFFFFFuL;
		num4 += num3 >> 28;
		num3 &= 0xFFFFFFFuL;
		num5 += num4 >> 28;
		num4 &= 0xFFFFFFFuL;
		num6 += num5 >> 28;
		num5 &= 0xFFFFFFFuL;
		num7 += num6 >> 28;
		num6 &= 0xFFFFFFFuL;
		num8 += num7 >> 28;
		num7 &= 0xFFFFFFFuL;
		num9 += num8 >> 28;
		num8 &= 0xFFFFFFFuL;
		num10 += num9 >> 28;
		num9 &= 0xFFFFFFFuL;
		num11 += num10 >> 28;
		num10 &= 0xFFFFFFFuL;
		num12 += num11 >> 28;
		num11 &= 0xFFFFFFFuL;
		num13 += num12 >> 28;
		num12 &= 0xFFFFFFFuL;
		num14 += num13 >> 28;
		num13 &= 0xFFFFFFFuL;
		num15 += num14 >> 28;
		num14 &= 0xFFFFFFFuL;
		num16 += num15 >> 28;
		num15 &= 0xFFFFFFFuL;
		num17 = num16 >> 26;
		num16 &= 0x3FFFFFFuL;
		num17--;
		num -= num17 & 0x4A7BB0DL;
		num2 -= num17 & 0x873D6D5L;
		num3 -= num17 & 0xA70AADCL;
		num4 -= num17 & 0x3D8D723L;
		num5 -= num17 & 0x96FDE93L;
		num6 -= num17 & 0xB65129CL;
		num7 -= num17 & 0x63BB124L;
		num8 -= num17 & 0x8335DC1L;
		num2 += (ulong)((long)num >> 28);
		num &= 0xFFFFFFFuL;
		num3 += (ulong)((long)num2 >> 28);
		num2 &= 0xFFFFFFFuL;
		num4 += (ulong)((long)num3 >> 28);
		num3 &= 0xFFFFFFFuL;
		num5 += (ulong)((long)num4 >> 28);
		num4 &= 0xFFFFFFFuL;
		num6 += (ulong)((long)num5 >> 28);
		num5 &= 0xFFFFFFFuL;
		num7 += (ulong)((long)num6 >> 28);
		num6 &= 0xFFFFFFFuL;
		num8 += (ulong)((long)num7 >> 28);
		num7 &= 0xFFFFFFFuL;
		num9 += (ulong)((long)num8 >> 28);
		num8 &= 0xFFFFFFFuL;
		num10 += (ulong)((long)num9 >> 28);
		num9 &= 0xFFFFFFFuL;
		num11 += (ulong)((long)num10 >> 28);
		num10 &= 0xFFFFFFFuL;
		num12 += (ulong)((long)num11 >> 28);
		num11 &= 0xFFFFFFFuL;
		num13 += (ulong)((long)num12 >> 28);
		num12 &= 0xFFFFFFFuL;
		num14 += (ulong)((long)num13 >> 28);
		num13 &= 0xFFFFFFFuL;
		num15 += (ulong)((long)num14 >> 28);
		num14 &= 0xFFFFFFFuL;
		num16 += (ulong)((long)num15 >> 28);
		num15 &= 0xFFFFFFFuL;
		byte[] array = new byte[57];
		Encode56(num | (num2 << 28), array, 0);
		Encode56(num3 | (num4 << 28), array, 7);
		Encode56(num5 | (num6 << 28), array, 14);
		Encode56(num7 | (num8 << 28), array, 21);
		Encode56(num9 | (num10 << 28), array, 28);
		Encode56(num11 | (num12 << 28), array, 35);
		Encode56(num13 | (num14 << 28), array, 42);
		Encode56(num15 | (num16 << 28), array, 49);
		return array;
	}

	private static void ScalarMultBase(byte[] k, PointExt r)
	{
		Precompute();
		PointSetNeutral(r);
		uint[] array = new uint[15];
		DecodeScalar(k, 0, array);
		array[14] = 4 + Nat.CAdd(14, (int)(~array[0] & 1), array, L, array);
		Nat.ShiftDownBit(array.Length, array, 0u);
		PointPrecomp pointPrecomp = new PointPrecomp();
		int num = 17;
		while (true)
		{
			int num2 = num;
			for (int i = 0; i < 5; i++)
			{
				uint num3 = 0u;
				for (int j = 0; j < 5; j++)
				{
					uint num4 = (array[num2 >> 5] >> num2) & 1u;
					num3 |= num4 << j;
					num2 += 18;
				}
				int num5 = (int)((num3 >> 4) & 1);
				int index = ((int)num3 ^ -num5) & 0xF;
				PointLookup(i, index, pointPrecomp);
				X448Field.CNegate(num5, pointPrecomp.x);
				PointAddPrecomp(pointPrecomp, r);
			}
			if (--num >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
	{
		PointExt pointExt = new PointExt();
		ScalarMultBase(k, pointExt);
		EncodePoint(pointExt, r, rOff);
	}

	private static void ScalarMultStraussVar(uint[] nb, uint[] np, PointExt p, PointExt r)
	{
		Precompute();
		sbyte[] wnaf = GetWnaf(nb, 7);
		sbyte[] wnaf2 = GetWnaf(np, 5);
		PointExt[] array = PointPrecompVar(p, 8);
		PointSetNeutral(r);
		int num = 447;
		while (num > 0 && (wnaf[num] | wnaf2[num]) == 0)
		{
			num--;
		}
		while (true)
		{
			int num2 = wnaf[num];
			if (num2 != 0)
			{
				int num3 = num2 >> 31;
				int num4 = (num2 ^ num3) >> 1;
				PointAddVar(num3 != 0, precompBaseTable[num4], r);
			}
			int num5 = wnaf2[num];
			if (num5 != 0)
			{
				int num6 = num5 >> 31;
				int num7 = (num5 ^ num6) >> 1;
				PointAddVar(num6 != 0, array[num7], r);
			}
			if (--num >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	public static void Sign(byte[] sk, int skOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx))
		{
			throw new ArgumentException("ctx");
		}
		ShakeDigest shakeDigest = new ShakeDigest(256);
		byte[] array = new byte[114];
		shakeDigest.BlockUpdate(sk, skOff, SecretKeySize);
		shakeDigest.DoFinal(array, 0, array.Length);
		byte[] array2 = new byte[57];
		PruneScalar(array, 0, array2);
		byte[] array3 = new byte[57];
		ScalarMultBaseEncoded(array2, array3, 0);
		ImplSign(shakeDigest, array, array2, array3, 0, ctx, m, mOff, mLen, sig, sigOff);
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx))
		{
			throw new ArgumentException("ctx");
		}
		ShakeDigest shakeDigest = new ShakeDigest(256);
		byte[] array = new byte[114];
		shakeDigest.BlockUpdate(sk, skOff, SecretKeySize);
		shakeDigest.DoFinal(array, 0, array.Length);
		byte[] array2 = new byte[57];
		PruneScalar(array, 0, array2);
		ImplSign(shakeDigest, array, array2, pk, pkOff, ctx, m, mOff, mLen, sig, sigOff);
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen)
	{
		if (!CheckContextVar(ctx))
		{
			throw new ArgumentException("ctx");
		}
		byte[] array = Arrays.CopyOfRange(sig, sigOff, sigOff + 57);
		byte[] array2 = Arrays.CopyOfRange(sig, sigOff + 57, sigOff + SignatureSize);
		if (!CheckPointVar(array))
		{
			return false;
		}
		if (!CheckScalarVar(array2))
		{
			return false;
		}
		PointExt pointExt = new PointExt();
		if (!DecodePointVar(pk, pkOff, negate: true, pointExt))
		{
			return false;
		}
		ShakeDigest shakeDigest = new ShakeDigest(256);
		byte[] array3 = new byte[114];
		Dom4(shakeDigest, 0, ctx);
		shakeDigest.BlockUpdate(array, 0, 57);
		shakeDigest.BlockUpdate(pk, pkOff, 57);
		shakeDigest.BlockUpdate(m, mOff, mLen);
		shakeDigest.DoFinal(array3, 0, array3.Length);
		byte[] k = ReduceScalar(array3);
		uint[] array4 = new uint[14];
		DecodeScalar(array2, 0, array4);
		uint[] array5 = new uint[14];
		DecodeScalar(k, 0, array5);
		PointExt pointExt2 = new PointExt();
		ScalarMultStraussVar(array4, array5, pointExt, pointExt2);
		byte[] array6 = new byte[57];
		EncodePoint(pointExt2, array6, 0);
		return Arrays.AreEqual(array6, array);
	}
}
