using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc8032;

public abstract class Ed25519
{
	public enum Algorithm
	{
		Ed25519,
		Ed25519ctx,
		Ed25519ph
	}

	private class F : X25519Field
	{
	}

	private class PointAccum
	{
		internal int[] x = X25519Field.Create();

		internal int[] y = X25519Field.Create();

		internal int[] z = X25519Field.Create();

		internal int[] u = X25519Field.Create();

		internal int[] v = X25519Field.Create();
	}

	private class PointAffine
	{
		internal int[] x = X25519Field.Create();

		internal int[] y = X25519Field.Create();
	}

	private class PointExt
	{
		internal int[] x = X25519Field.Create();

		internal int[] y = X25519Field.Create();

		internal int[] z = X25519Field.Create();

		internal int[] t = X25519Field.Create();
	}

	private class PointPrecomp
	{
		internal int[] ypx_h = X25519Field.Create();

		internal int[] ymx_h = X25519Field.Create();

		internal int[] xyd = X25519Field.Create();
	}

	private const long M08L = 255L;

	private const long M28L = 268435455L;

	private const long M32L = 4294967295L;

	private const int CoordUints = 8;

	private const int PointBytes = 32;

	private const int ScalarUints = 8;

	private const int ScalarBytes = 32;

	public static readonly int PrehashSize = 64;

	public static readonly int PublicKeySize = 32;

	public static readonly int SecretKeySize = 32;

	public static readonly int SignatureSize = 64;

	private static readonly byte[] Dom2Prefix = new byte[32]
	{
		83, 105, 103, 69, 100, 50, 53, 53, 49, 57,
		32, 110, 111, 32, 69, 100, 50, 53, 53, 49,
		57, 32, 99, 111, 108, 108, 105, 115, 105, 111,
		110, 115
	};

	private static readonly uint[] P = new uint[8] { 4294967277u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 2147483647u };

	private static readonly uint[] L = new uint[8] { 1559614445u, 1477600026u, 2734136534u, 350157278u, 0u, 0u, 0u, 268435456u };

	private const int L0 = -50998291;

	private const int L1 = 19280294;

	private const int L2 = 127719000;

	private const int L3 = -6428113;

	private const int L4 = 5343;

	private static readonly int[] B_x = new int[10] { 52811034, 25909283, 8072341, 50637101, 13785486, 30858332, 20483199, 20966410, 43936626, 4379245 };

	private static readonly int[] B_y = new int[10] { 40265304, 26843545, 6710886, 53687091, 13421772, 40265318, 26843545, 6710886, 53687091, 13421772 };

	private static readonly int[] C_d = new int[10] { 56195235, 47411844, 25868126, 40503822, 57364, 58321048, 30416477, 31930572, 57760639, 10749657 };

	private static readonly int[] C_d2 = new int[10] { 45281625, 27714825, 18181821, 13898781, 114729, 49533232, 60832955, 30306712, 48412415, 4722099 };

	private static readonly int[] C_d4 = new int[10] { 23454386, 55429651, 2809210, 27797563, 229458, 31957600, 54557047, 27058993, 29715967, 9444199 };

	private const int WnafWidthBase = 7;

	private const int PrecompBlocks = 8;

	private const int PrecompTeeth = 4;

	private const int PrecompSpacing = 8;

	private const int PrecompPoints = 8;

	private const int PrecompMask = 7;

	private static readonly object precompLock = new object();

	private static PointExt[] precompBaseTable = null;

	private static int[] precompBase = null;

	private static byte[] CalculateS(byte[] r, byte[] k, byte[] s)
	{
		uint[] array = new uint[16];
		DecodeScalar(r, 0, array);
		uint[] array2 = new uint[8];
		DecodeScalar(k, 0, array2);
		uint[] array3 = new uint[8];
		DecodeScalar(s, 0, array3);
		Nat256.MulAddTo(array2, array3, array);
		byte[] array4 = new byte[64];
		for (int i = 0; i < array.Length; i++)
		{
			Encode32(array[i], array4, i * 4);
		}
		return ReduceScalar(array4);
	}

	private static bool CheckContextVar(byte[] ctx, byte phflag)
	{
		if (ctx == null && phflag == 0)
		{
			return true;
		}
		if (ctx != null)
		{
			return ctx.Length < 256;
		}
		return false;
	}

	private static int CheckPoint(int[] x, int[] y)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		X25519Field.Sqr(x, array2);
		X25519Field.Sqr(y, array3);
		X25519Field.Mul(array2, array3, array);
		X25519Field.Sub(array3, array2, array3);
		X25519Field.Mul(array, C_d, array);
		X25519Field.AddOne(array);
		X25519Field.Sub(array, array3, array);
		X25519Field.Normalize(array);
		return X25519Field.IsZero(array);
	}

	private static int CheckPoint(int[] x, int[] y, int[] z)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] array4 = X25519Field.Create();
		X25519Field.Sqr(x, array2);
		X25519Field.Sqr(y, array3);
		X25519Field.Sqr(z, array4);
		X25519Field.Mul(array2, array3, array);
		X25519Field.Sub(array3, array2, array3);
		X25519Field.Mul(array3, array4, array3);
		X25519Field.Sqr(array4, array4);
		X25519Field.Mul(array, C_d, array);
		X25519Field.Add(array, array4, array);
		X25519Field.Sub(array, array3, array);
		X25519Field.Normalize(array);
		return X25519Field.IsZero(array);
	}

	private static bool CheckPointVar(byte[] p)
	{
		uint[] array = new uint[8];
		Decode32(p, 0, array, 0, 8);
		array[7] &= 2147483647u;
		return !Nat256.Gte(array, P);
	}

	private static bool CheckScalarVar(byte[] s, uint[] n)
	{
		DecodeScalar(s, 0, n);
		return !Nat256.Gte(n, L);
	}

	private static byte[] Copy(byte[] buf, int off, int len)
	{
		byte[] array = new byte[len];
		Array.Copy(buf, off, array, 0, len);
		return array;
	}

	private static IDigest CreateDigest()
	{
		return new Sha512Digest();
	}

	public static IDigest CreatePrehash()
	{
		return CreateDigest();
	}

	private static uint Decode24(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16));
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	private static void Decode32(byte[] bs, int bsOff, uint[] n, int nOff, int nLen)
	{
		for (int i = 0; i < nLen; i++)
		{
			n[nOff + i] = Decode32(bs, bsOff + i * 4);
		}
	}

	private static bool DecodePointVar(byte[] p, int pOff, bool negate, PointAffine r)
	{
		byte[] array = Copy(p, pOff, 32);
		if (!CheckPointVar(array))
		{
			return false;
		}
		int num = (array[31] & 0x80) >> 7;
		array[31] &= 127;
		X25519Field.Decode(array, 0, r.y);
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		X25519Field.Sqr(r.y, array2);
		X25519Field.Mul(C_d, array2, array3);
		X25519Field.SubOne(array2);
		X25519Field.AddOne(array3);
		if (!X25519Field.SqrtRatioVar(array2, array3, r.x))
		{
			return false;
		}
		X25519Field.Normalize(r.x);
		if (num == 1 && X25519Field.IsZeroVar(r.x))
		{
			return false;
		}
		if (negate ^ (num != (r.x[0] & 1)))
		{
			X25519Field.Negate(r.x, r.x);
		}
		return true;
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		Decode32(k, kOff, n, 0, 8);
	}

	private static void Dom2(IDigest d, byte phflag, byte[] ctx)
	{
		if (ctx != null)
		{
			int num = Dom2Prefix.Length;
			byte[] array = new byte[num + 2 + ctx.Length];
			Dom2Prefix.CopyTo(array, 0);
			array[num] = phflag;
			array[num + 1] = (byte)ctx.Length;
			ctx.CopyTo(array, num + 2);
			d.BlockUpdate(array, 0, array.Length);
		}
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

	private static int EncodePoint(PointAccum p, byte[] r, int rOff)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		X25519Field.Inv(p.z, array2);
		X25519Field.Mul(p.x, array2, array);
		X25519Field.Mul(p.y, array2, array2);
		X25519Field.Normalize(array);
		X25519Field.Normalize(array2);
		int result = CheckPoint(array, array2);
		X25519Field.Encode(array2, r, rOff);
		r[rOff + 32 - 1] |= (byte)((array[0] & 1) << 7);
		return result;
	}

	public static void GeneratePrivateKey(SecureRandom random, byte[] k)
	{
		random.NextBytes(k);
	}

	public static void GeneratePublicKey(byte[] sk, int skOff, byte[] pk, int pkOff)
	{
		IDigest digest = CreateDigest();
		byte[] array = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(sk, skOff, SecretKeySize);
		digest.DoFinal(array, 0);
		byte[] array2 = new byte[32];
		PruneScalar(array, 0, array2);
		ScalarMultBaseEncoded(array2, pk, pkOff);
	}

	private static uint GetWindow4(uint[] x, int n)
	{
		int num = (int)((uint)n >> 3);
		int num2 = (n & 7) << 2;
		return (x[num] >> num2) & 0xFu;
	}

	private static sbyte[] GetWnafVar(uint[] n, int width)
	{
		uint[] array = new uint[16];
		uint num = 0u;
		int num2 = array.Length;
		int num3 = 8;
		while (--num3 >= 0)
		{
			uint num4 = n[num3];
			array[--num2] = (num4 >> 16) | (num << 16);
			num = (array[--num2] = num4);
		}
		sbyte[] array2 = new sbyte[253];
		int num5 = 32 - width;
		uint num6 = 0u;
		int num7 = 0;
		int num8 = 0;
		while (num8 < array.Length)
		{
			uint num9 = array[num8];
			while (num7 < 16)
			{
				uint num10 = num9 >> num7;
				if ((num10 & 1) == num6)
				{
					num7++;
					continue;
				}
				uint num11 = (num10 | 1) << num5;
				num6 = num11 >> 31;
				array2[(num8 << 4) + num7] = (sbyte)((int)num11 >> num5);
				num7 += width;
			}
			num8++;
			num7 -= 16;
		}
		return array2;
	}

	private static void ImplSign(IDigest d, byte[] h, byte[] s, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		Dom2(d, phflag, ctx);
		d.BlockUpdate(h, 32, 32);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0);
		byte[] array = ReduceScalar(h);
		byte[] array2 = new byte[32];
		ScalarMultBaseEncoded(array, array2, 0);
		Dom2(d, phflag, ctx);
		d.BlockUpdate(array2, 0, 32);
		d.BlockUpdate(pk, pkOff, 32);
		d.BlockUpdate(m, mOff, mLen);
		d.DoFinal(h, 0);
		byte[] k = ReduceScalar(h);
		byte[] sourceArray = CalculateS(array, k, s);
		Array.Copy(array2, 0, sig, sigOff, 32);
		Array.Copy(sourceArray, 0, sig, sigOff + 32, 32);
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx, phflag))
		{
			throw new ArgumentException("ctx");
		}
		IDigest digest = CreateDigest();
		byte[] array = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(sk, skOff, SecretKeySize);
		digest.DoFinal(array, 0);
		byte[] array2 = new byte[32];
		PruneScalar(array, 0, array2);
		byte[] array3 = new byte[32];
		ScalarMultBaseEncoded(array2, array3, 0);
		ImplSign(digest, array, array2, array3, 0, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	private static void ImplSign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		if (!CheckContextVar(ctx, phflag))
		{
			throw new ArgumentException("ctx");
		}
		IDigest digest = CreateDigest();
		byte[] array = new byte[digest.GetDigestSize()];
		digest.BlockUpdate(sk, skOff, SecretKeySize);
		digest.DoFinal(array, 0);
		byte[] array2 = new byte[32];
		PruneScalar(array, 0, array2);
		ImplSign(digest, array, array2, pk, pkOff, ctx, phflag, m, mOff, mLen, sig, sigOff);
	}

	private static bool ImplVerify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte phflag, byte[] m, int mOff, int mLen)
	{
		if (!CheckContextVar(ctx, phflag))
		{
			throw new ArgumentException("ctx");
		}
		byte[] array = Copy(sig, sigOff, 32);
		byte[] s = Copy(sig, sigOff + 32, 32);
		if (!CheckPointVar(array))
		{
			return false;
		}
		uint[] array2 = new uint[8];
		if (!CheckScalarVar(s, array2))
		{
			return false;
		}
		PointAffine pointAffine = new PointAffine();
		if (!DecodePointVar(pk, pkOff, negate: true, pointAffine))
		{
			return false;
		}
		IDigest digest = CreateDigest();
		byte[] array3 = new byte[digest.GetDigestSize()];
		Dom2(digest, phflag, ctx);
		digest.BlockUpdate(array, 0, 32);
		digest.BlockUpdate(pk, pkOff, 32);
		digest.BlockUpdate(m, mOff, mLen);
		digest.DoFinal(array3, 0);
		byte[] k = ReduceScalar(array3);
		uint[] array4 = new uint[8];
		DecodeScalar(k, 0, array4);
		PointAccum pointAccum = new PointAccum();
		ScalarMultStrausVar(array2, array4, pointAffine, pointAccum);
		byte[] array5 = new byte[32];
		if (EncodePoint(pointAccum, array5, 0) != 0)
		{
			return Arrays.AreEqual(array5, array);
		}
		return false;
	}

	private static bool IsNeutralElementVar(int[] x, int[] y)
	{
		if (X25519Field.IsZeroVar(x))
		{
			return X25519Field.IsOneVar(y);
		}
		return false;
	}

	private static bool IsNeutralElementVar(int[] x, int[] y, int[] z)
	{
		if (X25519Field.IsZeroVar(x))
		{
			return X25519Field.AreEqualVar(y, z);
		}
		return false;
	}

	private static void PointAdd(PointExt p, PointAccum r)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] array4 = X25519Field.Create();
		int[] u = r.u;
		int[] array5 = X25519Field.Create();
		int[] array6 = X25519Field.Create();
		int[] v = r.v;
		X25519Field.Apm(r.y, r.x, array2, array);
		X25519Field.Apm(p.y, p.x, array4, array3);
		X25519Field.Mul(array, array3, array);
		X25519Field.Mul(array2, array4, array2);
		X25519Field.Mul(r.u, r.v, array3);
		X25519Field.Mul(array3, p.t, array3);
		X25519Field.Mul(array3, C_d2, array3);
		X25519Field.Mul(r.z, p.z, array4);
		X25519Field.Add(array4, array4, array4);
		X25519Field.Apm(array2, array, v, u);
		X25519Field.Apm(array4, array3, array6, array5);
		X25519Field.Carry(array6);
		X25519Field.Mul(u, array5, r.x);
		X25519Field.Mul(array6, v, r.y);
		X25519Field.Mul(array5, array6, r.z);
	}

	private static void PointAdd(PointExt p, PointExt r)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] array4 = X25519Field.Create();
		int[] array5 = X25519Field.Create();
		int[] array6 = X25519Field.Create();
		int[] array7 = X25519Field.Create();
		int[] array8 = X25519Field.Create();
		X25519Field.Apm(p.y, p.x, array2, array);
		X25519Field.Apm(r.y, r.x, array4, array3);
		X25519Field.Mul(array, array3, array);
		X25519Field.Mul(array2, array4, array2);
		X25519Field.Mul(p.t, r.t, array3);
		X25519Field.Mul(array3, C_d2, array3);
		X25519Field.Mul(p.z, r.z, array4);
		X25519Field.Add(array4, array4, array4);
		X25519Field.Apm(array2, array, array8, array5);
		X25519Field.Apm(array4, array3, array7, array6);
		X25519Field.Carry(array7);
		X25519Field.Mul(array5, array6, r.x);
		X25519Field.Mul(array7, array8, r.y);
		X25519Field.Mul(array6, array7, r.z);
		X25519Field.Mul(array5, array8, r.t);
	}

	private static void PointAddVar(bool negate, PointExt p, PointAccum r)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] array4 = X25519Field.Create();
		int[] u = r.u;
		int[] array5 = X25519Field.Create();
		int[] array6 = X25519Field.Create();
		int[] v = r.v;
		int[] zm;
		int[] zp;
		int[] zm2;
		int[] array7;
		if (negate)
		{
			zm = array4;
			zp = array3;
			zm2 = array6;
			array7 = array5;
		}
		else
		{
			zm = array3;
			zp = array4;
			zm2 = array5;
			array7 = array6;
		}
		X25519Field.Apm(r.y, r.x, array2, array);
		X25519Field.Apm(p.y, p.x, zp, zm);
		X25519Field.Mul(array, array3, array);
		X25519Field.Mul(array2, array4, array2);
		X25519Field.Mul(r.u, r.v, array3);
		X25519Field.Mul(array3, p.t, array3);
		X25519Field.Mul(array3, C_d2, array3);
		X25519Field.Mul(r.z, p.z, array4);
		X25519Field.Add(array4, array4, array4);
		X25519Field.Apm(array2, array, v, u);
		X25519Field.Apm(array4, array3, array7, zm2);
		X25519Field.Carry(array7);
		X25519Field.Mul(u, array5, r.x);
		X25519Field.Mul(array6, v, r.y);
		X25519Field.Mul(array5, array6, r.z);
	}

	private static void PointAddVar(bool negate, PointExt p, PointExt q, PointExt r)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] array4 = X25519Field.Create();
		int[] array5 = X25519Field.Create();
		int[] array6 = X25519Field.Create();
		int[] array7 = X25519Field.Create();
		int[] array8 = X25519Field.Create();
		int[] zm;
		int[] zp;
		int[] zm2;
		int[] array9;
		if (negate)
		{
			zm = array4;
			zp = array3;
			zm2 = array7;
			array9 = array6;
		}
		else
		{
			zm = array3;
			zp = array4;
			zm2 = array6;
			array9 = array7;
		}
		X25519Field.Apm(p.y, p.x, array2, array);
		X25519Field.Apm(q.y, q.x, zp, zm);
		X25519Field.Mul(array, array3, array);
		X25519Field.Mul(array2, array4, array2);
		X25519Field.Mul(p.t, q.t, array3);
		X25519Field.Mul(array3, C_d2, array3);
		X25519Field.Mul(p.z, q.z, array4);
		X25519Field.Add(array4, array4, array4);
		X25519Field.Apm(array2, array, array8, array5);
		X25519Field.Apm(array4, array3, array9, zm2);
		X25519Field.Carry(array9);
		X25519Field.Mul(array5, array6, r.x);
		X25519Field.Mul(array7, array8, r.y);
		X25519Field.Mul(array6, array7, r.z);
		X25519Field.Mul(array5, array8, r.t);
	}

	private static void PointAddPrecomp(PointPrecomp p, PointAccum r)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] u = r.u;
		int[] array4 = X25519Field.Create();
		int[] array5 = X25519Field.Create();
		int[] v = r.v;
		X25519Field.Apm(r.y, r.x, array2, array);
		X25519Field.Mul(array, p.ymx_h, array);
		X25519Field.Mul(array2, p.ypx_h, array2);
		X25519Field.Mul(r.u, r.v, array3);
		X25519Field.Mul(array3, p.xyd, array3);
		X25519Field.Apm(array2, array, v, u);
		X25519Field.Apm(r.z, array3, array5, array4);
		X25519Field.Carry(array5);
		X25519Field.Mul(u, array4, r.x);
		X25519Field.Mul(array5, v, r.y);
		X25519Field.Mul(array4, array5, r.z);
	}

	private static PointExt PointCopy(PointAccum p)
	{
		PointExt pointExt = new PointExt();
		X25519Field.Copy(p.x, 0, pointExt.x, 0);
		X25519Field.Copy(p.y, 0, pointExt.y, 0);
		X25519Field.Copy(p.z, 0, pointExt.z, 0);
		X25519Field.Mul(p.u, p.v, pointExt.t);
		return pointExt;
	}

	private static PointExt PointCopy(PointAffine p)
	{
		PointExt pointExt = new PointExt();
		X25519Field.Copy(p.x, 0, pointExt.x, 0);
		X25519Field.Copy(p.y, 0, pointExt.y, 0);
		PointExtendXY(pointExt);
		return pointExt;
	}

	private static PointExt PointCopy(PointExt p)
	{
		PointExt pointExt = new PointExt();
		PointCopy(p, pointExt);
		return pointExt;
	}

	private static void PointCopy(PointAffine p, PointAccum r)
	{
		X25519Field.Copy(p.x, 0, r.x, 0);
		X25519Field.Copy(p.y, 0, r.y, 0);
		PointExtendXY(r);
	}

	private static void PointCopy(PointExt p, PointExt r)
	{
		X25519Field.Copy(p.x, 0, r.x, 0);
		X25519Field.Copy(p.y, 0, r.y, 0);
		X25519Field.Copy(p.z, 0, r.z, 0);
		X25519Field.Copy(p.t, 0, r.t, 0);
	}

	private static void PointDouble(PointAccum r)
	{
		int[] array = X25519Field.Create();
		int[] array2 = X25519Field.Create();
		int[] array3 = X25519Field.Create();
		int[] u = r.u;
		int[] array4 = X25519Field.Create();
		int[] array5 = X25519Field.Create();
		int[] v = r.v;
		X25519Field.Sqr(r.x, array);
		X25519Field.Sqr(r.y, array2);
		X25519Field.Sqr(r.z, array3);
		X25519Field.Add(array3, array3, array3);
		X25519Field.Apm(array, array2, v, array5);
		X25519Field.Add(r.x, r.y, u);
		X25519Field.Sqr(u, u);
		X25519Field.Sub(v, u, u);
		X25519Field.Add(array3, array5, array4);
		X25519Field.Carry(array4);
		X25519Field.Mul(u, array4, r.x);
		X25519Field.Mul(array5, v, r.y);
		X25519Field.Mul(array4, array5, r.z);
	}

	private static void PointExtendXY(PointAccum p)
	{
		X25519Field.One(p.z);
		X25519Field.Copy(p.x, 0, p.u, 0);
		X25519Field.Copy(p.y, 0, p.v, 0);
	}

	private static void PointExtendXY(PointExt p)
	{
		X25519Field.One(p.z);
		X25519Field.Mul(p.x, p.y, p.t);
	}

	private static void PointLookup(int block, int index, PointPrecomp p)
	{
		int num = block * 8 * 3 * 10;
		for (int i = 0; i < 8; i++)
		{
			int cond = (i ^ index) - 1 >> 31;
			X25519Field.CMov(cond, precompBase, num, p.ypx_h, 0);
			num += 10;
			X25519Field.CMov(cond, precompBase, num, p.ymx_h, 0);
			num += 10;
			X25519Field.CMov(cond, precompBase, num, p.xyd, 0);
			num += 10;
		}
	}

	private static void PointLookup(uint[] x, int n, int[] table, PointExt r)
	{
		uint window = GetWindow4(x, n);
		int num = (int)((window >> 3) ^ 1);
		int num2 = ((int)window ^ -num) & 7;
		int i = 0;
		int num3 = 0;
		for (; i < 8; i++)
		{
			int cond = (i ^ num2) - 1 >> 31;
			X25519Field.CMov(cond, table, num3, r.x, 0);
			num3 += 10;
			X25519Field.CMov(cond, table, num3, r.y, 0);
			num3 += 10;
			X25519Field.CMov(cond, table, num3, r.z, 0);
			num3 += 10;
			X25519Field.CMov(cond, table, num3, r.t, 0);
			num3 += 10;
		}
		X25519Field.CNegate(num, r.x);
		X25519Field.CNegate(num, r.t);
	}

	private static void PointLookup(int[] table, int index, PointExt r)
	{
		int num = 40 * index;
		X25519Field.Copy(table, num, r.x, 0);
		num += 10;
		X25519Field.Copy(table, num, r.y, 0);
		num += 10;
		X25519Field.Copy(table, num, r.z, 0);
		num += 10;
		X25519Field.Copy(table, num, r.t, 0);
	}

	private static int[] PointPrecompute(PointAffine p, int count)
	{
		PointExt pointExt = PointCopy(p);
		PointExt pointExt2 = PointCopy(pointExt);
		PointAdd(pointExt, pointExt2);
		int[] array = X25519Field.CreateTable(count * 4);
		int num = 0;
		int num2 = 0;
		while (true)
		{
			X25519Field.Copy(pointExt.x, 0, array, num);
			num += 10;
			X25519Field.Copy(pointExt.y, 0, array, num);
			num += 10;
			X25519Field.Copy(pointExt.z, 0, array, num);
			num += 10;
			X25519Field.Copy(pointExt.t, 0, array, num);
			num += 10;
			if (++num2 == count)
			{
				break;
			}
			PointAdd(pointExt2, pointExt);
		}
		return array;
	}

	private static PointExt[] PointPrecomputeVar(PointExt p, int count)
	{
		PointExt pointExt = new PointExt();
		PointAddVar(negate: false, p, p, pointExt);
		PointExt[] array = new PointExt[count];
		array[0] = PointCopy(p);
		for (int i = 1; i < count; i++)
		{
			PointAddVar(negate: false, array[i - 1], pointExt, array[i] = new PointExt());
		}
		return array;
	}

	private static void PointSetNeutral(PointAccum p)
	{
		X25519Field.Zero(p.x);
		X25519Field.One(p.y);
		X25519Field.One(p.z);
		X25519Field.Zero(p.u);
		X25519Field.One(p.v);
	}

	private static void PointSetNeutral(PointExt p)
	{
		X25519Field.Zero(p.x);
		X25519Field.One(p.y);
		X25519Field.One(p.z);
		X25519Field.Zero(p.t);
	}

	public static void Precompute()
	{
		lock (precompLock)
		{
			if (precompBase != null)
			{
				return;
			}
			PointExt pointExt = new PointExt();
			X25519Field.Copy(B_x, 0, pointExt.x, 0);
			X25519Field.Copy(B_y, 0, pointExt.y, 0);
			PointExtendXY(pointExt);
			precompBaseTable = PointPrecomputeVar(pointExt, 32);
			PointAccum pointAccum = new PointAccum();
			X25519Field.Copy(B_x, 0, pointAccum.x, 0);
			X25519Field.Copy(B_y, 0, pointAccum.y, 0);
			PointExtendXY(pointAccum);
			precompBase = X25519Field.CreateTable(192);
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				PointExt[] array = new PointExt[4];
				PointExt pointExt2 = new PointExt();
				PointSetNeutral(pointExt2);
				for (int j = 0; j < 4; j++)
				{
					PointExt q = PointCopy(pointAccum);
					PointAddVar(negate: true, pointExt2, q, pointExt2);
					PointDouble(pointAccum);
					array[j] = PointCopy(pointAccum);
					if (i + j != 10)
					{
						for (int k = 1; k < 8; k++)
						{
							PointDouble(pointAccum);
						}
					}
				}
				PointExt[] array2 = new PointExt[8];
				int num2 = 0;
				num2 = 1;
				array2[0] = pointExt2;
				for (int l = 0; l < 3; l++)
				{
					int num3 = 1 << l;
					int num4 = 0;
					while (num4 < num3)
					{
						PointAddVar(negate: false, array2[num2 - num3], array[l], array2[num2] = new PointExt());
						num4++;
						num2++;
					}
				}
				int[] array3 = X25519Field.CreateTable(8);
				int[] array4 = X25519Field.Create();
				X25519Field.Copy(array2[0].z, 0, array4, 0);
				X25519Field.Copy(array4, 0, array3, 0);
				int num5 = 0;
				while (++num5 < 8)
				{
					X25519Field.Mul(array4, array2[num5].z, array4);
					X25519Field.Copy(array4, 0, array3, num5 * 10);
				}
				X25519Field.Add(array4, array4, array4);
				X25519Field.InvVar(array4, array4);
				num5--;
				int[] array5 = X25519Field.Create();
				while (num5 > 0)
				{
					int num6 = num5--;
					X25519Field.Copy(array3, num5 * 10, array5, 0);
					X25519Field.Mul(array5, array4, array5);
					X25519Field.Copy(array5, 0, array3, num6 * 10);
					X25519Field.Mul(array4, array2[num6].z, array4);
				}
				X25519Field.Copy(array4, 0, array3, 0);
				for (int m = 0; m < 8; m++)
				{
					PointExt obj = array2[m];
					int[] array6 = X25519Field.Create();
					int[] array7 = X25519Field.Create();
					X25519Field.Copy(array3, m * 10, array7, 0);
					X25519Field.Mul(obj.x, array7, array6);
					X25519Field.Mul(obj.y, array7, array7);
					PointPrecomp pointPrecomp = new PointPrecomp();
					X25519Field.Apm(array7, array6, pointPrecomp.ypx_h, pointPrecomp.ymx_h);
					X25519Field.Mul(array6, array7, pointPrecomp.xyd);
					X25519Field.Mul(pointPrecomp.xyd, C_d4, pointPrecomp.xyd);
					X25519Field.Normalize(pointPrecomp.ypx_h);
					X25519Field.Normalize(pointPrecomp.ymx_h);
					X25519Field.Copy(pointPrecomp.ypx_h, 0, precompBase, num);
					num += 10;
					X25519Field.Copy(pointPrecomp.ymx_h, 0, precompBase, num);
					num += 10;
					X25519Field.Copy(pointPrecomp.xyd, 0, precompBase, num);
					num += 10;
				}
			}
		}
	}

	private static void PruneScalar(byte[] n, int nOff, byte[] r)
	{
		Array.Copy(n, nOff, r, 0, 32);
		r[0] &= 248;
		r[31] &= 127;
		r[31] |= 64;
	}

	private static byte[] ReduceScalar(byte[] n)
	{
		long num = (long)Decode32(n, 0) & 0xFFFFFFFFL;
		long num2 = (long)(Decode24(n, 4) << 4) & 0xFFFFFFFFL;
		long num3 = (long)Decode32(n, 7) & 0xFFFFFFFFL;
		long num4 = (long)(Decode24(n, 11) << 4) & 0xFFFFFFFFL;
		long num5 = (long)Decode32(n, 14) & 0xFFFFFFFFL;
		long num6 = (long)(Decode24(n, 18) << 4) & 0xFFFFFFFFL;
		long num7 = (long)Decode32(n, 21) & 0xFFFFFFFFL;
		long num8 = (long)(Decode24(n, 25) << 4) & 0xFFFFFFFFL;
		long num9 = (long)Decode32(n, 28) & 0xFFFFFFFFL;
		long num10 = (long)(Decode24(n, 32) << 4) & 0xFFFFFFFFL;
		long num11 = (long)Decode32(n, 35) & 0xFFFFFFFFL;
		long num12 = (long)(Decode24(n, 39) << 4) & 0xFFFFFFFFL;
		long num13 = (long)Decode32(n, 42) & 0xFFFFFFFFL;
		long num14 = (long)(Decode24(n, 46) << 4) & 0xFFFFFFFFL;
		long num15 = (long)Decode32(n, 49) & 0xFFFFFFFFL;
		long num16 = (long)(Decode24(n, 53) << 4) & 0xFFFFFFFFL;
		long num17 = (long)Decode32(n, 56) & 0xFFFFFFFFL;
		long num18 = (long)(Decode24(n, 60) << 4) & 0xFFFFFFFFL;
		long num19 = n[63] & 0xFFL;
		num10 -= num19 * -50998291L;
		num11 -= num19 * 19280294L;
		num12 -= num19 * 127719000L;
		num13 -= num19 * -6428113L;
		num14 -= num19 * 5343L;
		num18 += num17 >> 28;
		num17 &= 0xFFFFFFFL;
		num9 -= num18 * -50998291L;
		num10 -= num18 * 19280294L;
		num11 -= num18 * 127719000L;
		num12 -= num18 * -6428113L;
		num13 -= num18 * 5343L;
		num8 -= num17 * -50998291L;
		num9 -= num17 * 19280294L;
		num10 -= num17 * 127719000L;
		num11 -= num17 * -6428113L;
		num12 -= num17 * 5343L;
		num16 += num15 >> 28;
		num15 &= 0xFFFFFFFL;
		num7 -= num16 * -50998291L;
		num8 -= num16 * 19280294L;
		num9 -= num16 * 127719000L;
		num10 -= num16 * -6428113L;
		num11 -= num16 * 5343L;
		num6 -= num15 * -50998291L;
		num7 -= num15 * 19280294L;
		num8 -= num15 * 127719000L;
		num9 -= num15 * -6428113L;
		num10 -= num15 * 5343L;
		num14 += num13 >> 28;
		num13 &= 0xFFFFFFFL;
		num5 -= num14 * -50998291L;
		num6 -= num14 * 19280294L;
		num7 -= num14 * 127719000L;
		num8 -= num14 * -6428113L;
		num9 -= num14 * 5343L;
		num13 += num12 >> 28;
		num12 &= 0xFFFFFFFL;
		num4 -= num13 * -50998291L;
		num5 -= num13 * 19280294L;
		num6 -= num13 * 127719000L;
		num7 -= num13 * -6428113L;
		num8 -= num13 * 5343L;
		num12 += num11 >> 28;
		num11 &= 0xFFFFFFFL;
		num3 -= num12 * -50998291L;
		num4 -= num12 * 19280294L;
		num5 -= num12 * 127719000L;
		num6 -= num12 * -6428113L;
		num7 -= num12 * 5343L;
		num11 += num10 >> 28;
		num10 &= 0xFFFFFFFL;
		num2 -= num11 * -50998291L;
		num3 -= num11 * 19280294L;
		num4 -= num11 * 127719000L;
		num5 -= num11 * -6428113L;
		num6 -= num11 * 5343L;
		num9 += num8 >> 28;
		num8 &= 0xFFFFFFFL;
		num10 += num9 >> 28;
		num9 &= 0xFFFFFFFL;
		long num20 = (num9 >> 27) & 1L;
		num10 += num20;
		num -= num10 * -50998291L;
		num2 -= num10 * 19280294L;
		num3 -= num10 * 127719000L;
		num4 -= num10 * -6428113L;
		num5 -= num10 * 5343L;
		num2 += num >> 28;
		num &= 0xFFFFFFFL;
		num3 += num2 >> 28;
		num2 &= 0xFFFFFFFL;
		num4 += num3 >> 28;
		num3 &= 0xFFFFFFFL;
		num5 += num4 >> 28;
		num4 &= 0xFFFFFFFL;
		num6 += num5 >> 28;
		num5 &= 0xFFFFFFFL;
		num7 += num6 >> 28;
		num6 &= 0xFFFFFFFL;
		num8 += num7 >> 28;
		num7 &= 0xFFFFFFFL;
		num9 += num8 >> 28;
		num8 &= 0xFFFFFFFL;
		num10 = num9 >> 28;
		num9 &= 0xFFFFFFFL;
		num10 -= num20;
		num += num10 & -50998291L;
		num2 += num10 & 0x12631A6L;
		num3 += num10 & 0x79CD658L;
		num4 += num10 & -6428113L;
		num5 += num10 & 0x14DFL;
		num2 += num >> 28;
		num &= 0xFFFFFFFL;
		num3 += num2 >> 28;
		num2 &= 0xFFFFFFFL;
		num4 += num3 >> 28;
		num3 &= 0xFFFFFFFL;
		num5 += num4 >> 28;
		num4 &= 0xFFFFFFFL;
		num6 += num5 >> 28;
		num5 &= 0xFFFFFFFL;
		num7 += num6 >> 28;
		num6 &= 0xFFFFFFFL;
		num8 += num7 >> 28;
		num7 &= 0xFFFFFFFL;
		num9 += num8 >> 28;
		num8 &= 0xFFFFFFFL;
		byte[] array = new byte[32];
		Encode56((ulong)(num | (num2 << 28)), array, 0);
		Encode56((ulong)(num3 | (num4 << 28)), array, 7);
		Encode56((ulong)(num5 | (num6 << 28)), array, 14);
		Encode56((ulong)(num7 | (num8 << 28)), array, 21);
		Encode32((uint)num9, array, 28);
		return array;
	}

	private static void ScalarMult(byte[] k, PointAffine p, PointAccum r)
	{
		uint[] array = new uint[8];
		DecodeScalar(k, 0, array);
		Nat.ShiftDownBits(8, array, 3, 1u);
		Nat.CAdd(8, (int)(~array[0] & 1), array, L, array);
		Nat.ShiftDownBit(8, array, 0u);
		int[] table = PointPrecompute(p, 8);
		PointExt pointExt = new PointExt();
		PointCopy(p, r);
		PointLookup(table, 7, pointExt);
		PointAdd(pointExt, r);
		int num = 62;
		while (true)
		{
			PointLookup(array, num, table, pointExt);
			PointAdd(pointExt, r);
			PointDouble(r);
			PointDouble(r);
			PointDouble(r);
			if (--num >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultBase(byte[] k, PointAccum r)
	{
		Precompute();
		uint[] array = new uint[8];
		DecodeScalar(k, 0, array);
		Nat.CAdd(8, (int)(~array[0] & 1), array, L, array);
		Nat.ShiftDownBit(8, array, 1u);
		for (int i = 0; i < 8; i++)
		{
			array[i] = Interleave.Shuffle2(array[i]);
		}
		PointPrecomp pointPrecomp = new PointPrecomp();
		PointSetNeutral(r);
		int num = 28;
		while (true)
		{
			for (int j = 0; j < 8; j++)
			{
				uint num2 = array[j] >> num;
				int num3 = (int)((num2 >> 3) & 1);
				int index = ((int)num2 ^ -num3) & 7;
				PointLookup(j, index, pointPrecomp);
				X25519Field.CSwap(num3, pointPrecomp.ypx_h, pointPrecomp.ymx_h);
				X25519Field.CNegate(num3, pointPrecomp.xyd);
				PointAddPrecomp(pointPrecomp, r);
			}
			if ((num -= 4) >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultBaseEncoded(byte[] k, byte[] r, int rOff)
	{
		PointAccum pointAccum = new PointAccum();
		ScalarMultBase(k, pointAccum);
		if (EncodePoint(pointAccum, r, rOff) == 0)
		{
			throw new InvalidOperationException();
		}
	}

	internal static void ScalarMultBaseYZ(byte[] k, int kOff, int[] y, int[] z)
	{
		byte[] array = new byte[32];
		PruneScalar(k, kOff, array);
		PointAccum pointAccum = new PointAccum();
		ScalarMultBase(array, pointAccum);
		if (CheckPoint(pointAccum.x, pointAccum.y, pointAccum.z) == 0)
		{
			throw new InvalidOperationException();
		}
		X25519Field.Copy(pointAccum.y, 0, y, 0);
		X25519Field.Copy(pointAccum.z, 0, z, 0);
	}

	private static void ScalarMultOrderVar(PointAffine p, PointAccum r)
	{
		sbyte[] wnafVar = GetWnafVar(L, 5);
		PointExt[] array = PointPrecomputeVar(PointCopy(p), 8);
		PointSetNeutral(r);
		int num = 252;
		while (true)
		{
			int num2 = wnafVar[num];
			if (num2 != 0)
			{
				int num3 = num2 >> 31;
				int num4 = (num2 ^ num3) >> 1;
				PointAddVar(num3 != 0, array[num4], r);
			}
			if (--num >= 0)
			{
				PointDouble(r);
				continue;
			}
			break;
		}
	}

	private static void ScalarMultStrausVar(uint[] nb, uint[] np, PointAffine p, PointAccum r)
	{
		Precompute();
		sbyte[] wnafVar = GetWnafVar(nb, 7);
		sbyte[] wnafVar2 = GetWnafVar(np, 5);
		PointExt[] array = PointPrecomputeVar(PointCopy(p), 8);
		PointSetNeutral(r);
		int num = 252;
		while (true)
		{
			int num2 = wnafVar[num];
			if (num2 != 0)
			{
				int num3 = num2 >> 31;
				int num4 = (num2 ^ num3) >> 1;
				PointAddVar(num3 != 0, precompBaseTable[num4], r);
			}
			int num5 = wnafVar2[num];
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

	public static void Sign(byte[] sk, int skOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		byte[] ctx = null;
		ImplSign(sk, skOff, ctx, 0, m, mOff, mLen, sig, sigOff);
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		byte[] ctx = null;
		ImplSign(sk, skOff, pk, pkOff, ctx, 0, m, mOff, mLen, sig, sigOff);
	}

	public static void Sign(byte[] sk, int skOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		ImplSign(sk, skOff, ctx, 0, m, mOff, mLen, sig, sigOff);
	}

	public static void Sign(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen, byte[] sig, int sigOff)
	{
		ImplSign(sk, skOff, pk, pkOff, ctx, 0, m, mOff, mLen, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
	{
		ImplSign(sk, skOff, ctx, 1, ph, phOff, PrehashSize, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff, byte[] sig, int sigOff)
	{
		ImplSign(sk, skOff, pk, pkOff, ctx, 1, ph, phOff, PrehashSize, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] ctx, IDigest ph, byte[] sig, int sigOff)
	{
		byte[] array = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(array, 0))
		{
			throw new ArgumentException("ph");
		}
		ImplSign(sk, skOff, ctx, 1, array, 0, array.Length, sig, sigOff);
	}

	public static void SignPrehash(byte[] sk, int skOff, byte[] pk, int pkOff, byte[] ctx, IDigest ph, byte[] sig, int sigOff)
	{
		byte[] array = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(array, 0))
		{
			throw new ArgumentException("ph");
		}
		ImplSign(sk, skOff, pk, pkOff, ctx, 1, array, 0, array.Length, sig, sigOff);
	}

	public static bool ValidatePublicKeyFull(byte[] pk, int pkOff)
	{
		PointAffine pointAffine = new PointAffine();
		if (!DecodePointVar(pk, pkOff, negate: false, pointAffine))
		{
			return false;
		}
		X25519Field.Normalize(pointAffine.x);
		X25519Field.Normalize(pointAffine.y);
		if (IsNeutralElementVar(pointAffine.x, pointAffine.y))
		{
			return false;
		}
		PointAccum pointAccum = new PointAccum();
		ScalarMultOrderVar(pointAffine, pointAccum);
		X25519Field.Normalize(pointAccum.x);
		X25519Field.Normalize(pointAccum.y);
		X25519Field.Normalize(pointAccum.z);
		return IsNeutralElementVar(pointAccum.x, pointAccum.y, pointAccum.z);
	}

	public static bool ValidatePublicKeyPartial(byte[] pk, int pkOff)
	{
		PointAffine r = new PointAffine();
		return DecodePointVar(pk, pkOff, negate: false, r);
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] m, int mOff, int mLen)
	{
		byte[] ctx = null;
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, 0, m, mOff, mLen);
	}

	public static bool Verify(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] m, int mOff, int mLen)
	{
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, 0, m, mOff, mLen);
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, byte[] ph, int phOff)
	{
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, 1, ph, phOff, PrehashSize);
	}

	public static bool VerifyPrehash(byte[] sig, int sigOff, byte[] pk, int pkOff, byte[] ctx, IDigest ph)
	{
		byte[] array = new byte[PrehashSize];
		if (PrehashSize != ph.DoFinal(array, 0))
		{
			throw new ArgumentException("ph");
		}
		return ImplVerify(sig, sigOff, pk, pkOff, ctx, 1, array, 0, array.Length);
	}
}
