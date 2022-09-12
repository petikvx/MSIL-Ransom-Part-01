using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using WKtExBGrT2f6h026To;

namespace A6yJVNZuoAn9NC1LAS;

internal class S7EI44sMaZQ92MiG6X
{
	internal class W0RoQO4S5caY6IZoJn : Attribute
	{
		internal class Uf0jIZCbNHXuKymW1u<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Uf0jIZCbNHXuKymW1u()
			{
			}//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1


			internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return true;
			}

			internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[W0RoQO4S5caY6IZoJn(typeof(S7EI44sMaZQ92MiG6X_002FW0RoQO4S5caY6IZoJn_002FUf0jIZCbNHXuKymW1u<object>[]))]
		public W0RoQO4S5caY6IZoJn(object _0020)
		{
		}//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1

	}

	[Flags]
	private enum LC4Fb3DwS8CZ3A2N5i
	{

	}

	private static uint[] MukVDY7fp;

	private static bool mKrn7FRRF;

	private static bool jJDQ1LIXi;

	private static byte[] sptJkRDeR;

	private static byte[] aG4AVoW1T;

	private static byte[] VlvvMf0S2;

	private static byte[] IjdXlXDmQ;

	private static IntPtr tHL1DWx2g;

	private static IntPtr IMpthAR4r;

	private static object dqNSmdvLj;

	private static int[] xl2WARyP6;

	private static int l7iaiNUGL;

	private static long Fob8H2mQF;

	private static int T63mSHBDS;

	private static bool k5akVWAoi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static S7EI44sMaZQ92MiG6X()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		MukVDY7fp = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		mKrn7FRRF = false;
		jJDQ1LIXi = false;
		sptJkRDeR = new byte[0];
		aG4AVoW1T = new byte[0];
		VlvvMf0S2 = new byte[0];
		IjdXlXDmQ = new byte[0];
		tHL1DWx2g = IntPtr.Zero;
		IMpthAR4r = IntPtr.Zero;
		dqNSmdvLj = new string[0];
		xl2WARyP6 = new int[0];
		l7iaiNUGL = 1;
		Fob8H2mQF = 0L;
		T63mSHBDS = 0;
		k5akVWAoi = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void leHifFIJCLsZtKEFfM1i()
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] gxVhu8Xqp(byte[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		uint[] array = new uint[16];
		int num = 448 - _0020.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(_0020.Length + num2 / 8u + 8);
		ulong num4 = (ulong)_0020.Length * 8uL;
		byte[] array2 = new byte[num3];
		for (int i = 0; i < _0020.Length; i++)
		{
			array2[i] = _0020[i];
		}
		array2[_0020.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint num7 = 1732584193u;
		uint num8 = 4023233417u;
		uint num9 = 2562383102u;
		uint num10 = 271733878u;
		for (uint num11 = 0u; num11 < num6 / 16u; num11++)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0u; num13 < 61; num13 += 4)
			{
				array[num13 >> 2] = (uint)((array2[num12 + (num13 + 3)] << 24) | (array2[num12 + (num13 + 2)] << 16) | (array2[num12 + (num13 + 1)] << 8) | array2[num12 + num13]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			V86s6N6ww(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			V86s6N6ww(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			V86s6N6ww(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			V86s6N6ww(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			V86s6N6ww(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			V86s6N6ww(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			V86s6N6ww(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			V86s6N6ww(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			V86s6N6ww(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			V86s6N6ww(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			V86s6N6ww(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			V86s6N6ww(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			V86s6N6ww(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			V86s6N6ww(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			V86s6N6ww(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			V86s6N6ww(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			SU7ZEI44M(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			SU7ZEI44M(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			SU7ZEI44M(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			SU7ZEI44M(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			SU7ZEI44M(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			SU7ZEI44M(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			SU7ZEI44M(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			SU7ZEI44M(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			SU7ZEI44M(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			SU7ZEI44M(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			SU7ZEI44M(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			SU7ZEI44M(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			SU7ZEI44M(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			SU7ZEI44M(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			SU7ZEI44M(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			SU7ZEI44M(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			OZQ492MiG(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			OZQ492MiG(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			OZQ492MiG(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			OZQ492MiG(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			OZQ492MiG(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			OZQ492MiG(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			OZQ492MiG(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			OZQ492MiG(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			OZQ492MiG(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			OZQ492MiG(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			OZQ492MiG(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			OZQ492MiG(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			OZQ492MiG(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			OZQ492MiG(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			OZQ492MiG(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			OZQ492MiG(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			sX9C6yJVN(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			sX9C6yJVN(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			sX9C6yJVN(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			sX9C6yJVN(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			sX9C6yJVN(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			sX9C6yJVN(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			sX9C6yJVN(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			sX9C6yJVN(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			sX9C6yJVN(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			sX9C6yJVN(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			sX9C6yJVN(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			sX9C6yJVN(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			sX9C6yJVN(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			sX9C6yJVN(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			sX9C6yJVN(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			sX9C6yJVN(ref num8, num9, num10, num7, 9u, 21, 64u, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array3, 12, 4);
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void V86s6N6ww(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += voADn9NC1(_0020 + ((_0020 & _0020) | (~_0020 & _0020)) + _0020[_0020] + MukVDY7fp[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SU7ZEI44M(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += voADn9NC1(_0020 + ((_0020 & _0020) | (_0020 & ~_0020)) + _0020[_0020] + MukVDY7fp[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OZQ492MiG(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += voADn9NC1(_0020 + (_0020 ^ _0020 ^ _0020) + _0020[_0020] + MukVDY7fp[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void sX9C6yJVN(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += voADn9NC1(_0020 + (_0020 ^ (_0020 | ~_0020)) + _0020[_0020] + MukVDY7fp[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint voADn9NC1(uint _0020, ushort _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return (_0020 >> 32 - _0020) | (_0020 << (int)_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qASfo0RoQ()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!mKrn7FRRF)
		{
			hS5OcaY6I();
			mKrn7FRRF = true;
		}
		return jJDQ1LIXi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hS5OcaY6I()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			jJDQ1LIXi = (bool)Type.GetTypeFromHandle(cdDYJXxtRNHGdUNTh2.e53w34m968awCm9P85taUZe(16777407)).Assembly.GetType("System.Security.Cryptography.CryptoConfig", throwOnError: false)!.GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[0]);
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm coJxnYf0j()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (qASfo0RoQ())
		{
			try
			{
				return new AesCryptoServiceProvider();
			}
			catch
			{
				return new RijndaelManaged();
			}
		}
		return new RijndaelManaged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] RZbGNHXuK(byte[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!qASfo0RoQ())
		{
			return new MD5CryptoServiceProvider().ComputeHash(_0020);
		}
		return gxVhu8Xqp(_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static bool EmWT1u1C4(int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_29ce, IL_3156, IL_325d, IL_328f, IL_35dd
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_3207: Incompatible stack heights: 0 vs 1
		//IL_3211: Incompatible stack heights: 0 vs 1
		//IL_321b: Incompatible stack heights: 0 vs 1
		//IL_3299: Incompatible stack heights: 0 vs 2
		//IL_32b8: Incompatible stack heights: 0 vs 1
		//IL_32c2: Incompatible stack heights: 0 vs 1
		//IL_32cc: Incompatible stack heights: 0 vs 1
		//IL_32e0: Incompatible stack heights: 0 vs 1
		//IL_32ea: Incompatible stack heights: 0 vs 1
		//IL_32f4: Incompatible stack heights: 0 vs 1
		//IL_32fe: Incompatible stack heights: 0 vs 1
		//IL_3308: Incompatible stack heights: 0 vs 1
		//IL_3312: Incompatible stack heights: 0 vs 1
		//IL_331c: Incompatible stack heights: 0 vs 1
		//IL_3326: Incompatible stack heights: 0 vs 1
		//IL_3330: Incompatible stack heights: 0 vs 1
		//IL_333a: Incompatible stack heights: 0 vs 1
		//IL_3344: Incompatible stack heights: 0 vs 1
		//IL_3358: Incompatible stack heights: 0 vs 1
		//IL_3362: Incompatible stack heights: 0 vs 1
		//IL_336c: Incompatible stack heights: 0 vs 1
		//IL_3376: Incompatible stack heights: 0 vs 1
		//IL_3380: Incompatible stack heights: 0 vs 1
		//IL_338a: Incompatible stack heights: 0 vs 1
		//IL_3394: Incompatible stack heights: 0 vs 1
		//IL_339e: Incompatible stack heights: 0 vs 1
		//IL_33a8: Incompatible stack heights: 0 vs 1
		//IL_33b2: Incompatible stack heights: 0 vs 2
		//IL_33bc: Incompatible stack heights: 0 vs 1
		//IL_33c6: Incompatible stack heights: 0 vs 1
		//IL_33d0: Incompatible stack heights: 0 vs 1
		//IL_33da: Incompatible stack heights: 0 vs 1
		//IL_33e4: Incompatible stack heights: 0 vs 1
		//IL_33ee: Incompatible stack heights: 0 vs 1
		//IL_33f8: Incompatible stack heights: 0 vs 1
		//IL_3402: Incompatible stack heights: 0 vs 1
		//IL_3416: Incompatible stack heights: 0 vs 1
		//IL_3420: Incompatible stack heights: 0 vs 1
		//IL_342a: Incompatible stack heights: 0 vs 1
		//IL_3434: Incompatible stack heights: 0 vs 1
		//IL_343e: Incompatible stack heights: 0 vs 1
		//IL_3448: Incompatible stack heights: 0 vs 1
		//IL_3452: Incompatible stack heights: 0 vs 1
		//IL_345c: Incompatible stack heights: 0 vs 1
		//IL_3466: Incompatible stack heights: 0 vs 1
		//IL_3470: Incompatible stack heights: 0 vs 1
		//IL_347a: Incompatible stack heights: 0 vs 1
		//IL_3484: Incompatible stack heights: 0 vs 1
		//IL_3498: Incompatible stack heights: 0 vs 1
		//IL_34a2: Incompatible stack heights: 0 vs 1
		//IL_34ac: Incompatible stack heights: 0 vs 1
		//IL_34b6: Incompatible stack heights: 0 vs 1
		//IL_34c0: Incompatible stack heights: 0 vs 1
		//IL_34ca: Incompatible stack heights: 0 vs 1
		//IL_34d4: Incompatible stack heights: 0 vs 1
		//IL_34de: Incompatible stack heights: 0 vs 1
		//IL_34e8: Incompatible stack heights: 0 vs 1
		//IL_34f2: Incompatible stack heights: 0 vs 1
		//IL_34fc: Incompatible stack heights: 0 vs 1
		//IL_3506: Incompatible stack heights: 0 vs 1
		//IL_3510: Incompatible stack heights: 0 vs 1
		//IL_351a: Incompatible stack heights: 0 vs 1
		//IL_3524: Incompatible stack heights: 0 vs 1
		//IL_352e: Incompatible stack heights: 0 vs 1
		//IL_3538: Incompatible stack heights: 0 vs 1
		//IL_3542: Incompatible stack heights: 0 vs 1
		//IL_354c: Incompatible stack heights: 0 vs 1
		//IL_3556: Incompatible stack heights: 0 vs 1
		//IL_3560: Incompatible stack heights: 0 vs 1
		//IL_356a: Incompatible stack heights: 0 vs 1
		//IL_357e: Incompatible stack heights: 0 vs 1
		//IL_3588: Incompatible stack heights: 0 vs 1
		//IL_3592: Incompatible stack heights: 0 vs 1
		//IL_359c: Incompatible stack heights: 0 vs 1
		//IL_35a6: Incompatible stack heights: 0 vs 1
		//IL_35b0: Incompatible stack heights: 0 vs 1
		//IL_35ba: Incompatible stack heights: 0 vs 1
		//IL_35d8: Incompatible stack heights: 0 vs 1
		int num = 56;
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		byte[] array2 = default(byte[]);
		int num9 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array5 = default(byte[]);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] rgbKey = default(byte[]);
		byte[] array4 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array6 = default(byte[]);
		CryptoStream cryptoStream = default(CryptoStream);
		int num4 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num2;
			int num7;
			switch (num)
			{
			case 85:
				array3[3] = (byte)num8;
				num2 = 186;
				goto IL_29d7;
			case 36:
				array3[12] = (byte)num8;
				num = 216;
				break;
			case 18:
				num8 = 132 - 44;
				num2 = 202;
				if (1 == 0)
				{
					goto case 314;
				}
				goto IL_29d7;
			case 314:
				array2[0] = (byte)num9;
				num = 176;
				break;
			case 194:
				array2[8] = 146;
				num = 206;
				break;
			case 75:
				array2[4] = 132;
				num = 139;
				break;
			case 356:
				array2[1] = 140;
				num7 = 22;
				goto IL_29d3;
			case 107:
				num9 = 211 - 70;
				num7 = 151;
				goto IL_29d3;
			case 323:
				array3[23] = (byte)num8;
				num2 = 322;
				if (false)
				{
					goto case 58;
				}
				goto IL_29d7;
			case 58:
				array3[19] = 147;
				num7 = 171;
				goto IL_29d3;
			case 291:
				num8 = 25 + 35;
				num = 36;
				break;
			case 137:
				array3[27] = (byte)num8;
				num2 = 244;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0167: Stack underflow*/ == 0)
				{
					goto case 348;
				}
				goto IL_29d7;
			case 212:
				num8 = 50 + 7;
				num2 = 301;
				if (1 == 0)
				{
					goto case 115;
				}
				goto IL_29d7;
			case 115:
				num8 = 182 - 60;
				num2 = 243;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_01ac: Stack underflow*/ != 0)
				{
					goto case 110;
				}
				goto IL_29d7;
			case 110:
				array3[18] = 182;
				num2 = 303;
				goto IL_29d7;
			case 159:
				array3[9] = (byte)num8;
				num = 328;
				break;
			case 265:
				array2[6] = 46;
				num7 = 308;
				goto IL_29d3;
			case 216:
				array3[12] = 152;
				num2 = 79;
				if (false)
				{
					goto case 278;
				}
				goto IL_29d7;
			case 278:
				array3[17] = 157;
				num2 = 6;
				if (false)
				{
					goto case 346;
				}
				goto IL_29d7;
			case 346:
				array3[8] = (byte)num8;
				num2 = 16;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_026f: Stack underflow*/ != 0)
				{
					goto case 344;
				}
				goto IL_29d7;
			case 344:
				array3[25] = (byte)num8;
				num = 101;
				break;
			case 186:
				array3[3] = 24;
				num2 = 288;
				goto IL_29d7;
			case 312:
				num8 = 36 + 30;
				num7 = 137;
				goto IL_29d3;
			case 184:
				array2[9] = (byte)num9;
				num7 = 294;
				goto IL_29d3;
			case 375:
				array3[27] = (byte)num8;
				num7 = 99;
				goto IL_29d3;
			case 362:
				array3[30] = 248;
				num2 = 98;
				if (false)
				{
					goto case 215;
				}
				goto IL_29d7;
			case 215:
				array3[2] = 159;
				num = 149;
				break;
			case 373:
				num8 = 224 + 13;
				num2 = 88;
				if (1 == 0)
				{
					goto case 95;
				}
				goto IL_29d7;
			case 95:
				memoryStream.Close();
				num2 = 44;
				goto IL_29d7;
			case 348:
				array3[21] = (byte)num8;
				num = 237;
				break;
			case 276:
				array3[4] = (byte)num8;
				num = 124;
				break;
			case 143:
				array3[3] = 170;
				num2 = 185;
				if (1 == 0)
				{
					goto case 262;
				}
				goto IL_29d7;
			case 262:
				array2[5] = 122;
				num = 309;
				break;
			case 201:
				array2[15] = 122;
				num2 = 232;
				if (false)
				{
					goto case 239;
				}
				goto IL_29d7;
			case 239:
				array2[6] = (byte)num9;
				num7 = 280;
				goto IL_29d3;
			case 8:
				array3[23] = 20;
				num7 = 199;
				goto IL_29d3;
			case 320:
				array3[7] = 205;
				num = 198;
				break;
			case 134:
				array3[25] = (byte)num8;
				num2 = 89;
				goto IL_29d7;
			case 303:
				array3[18] = 238;
				num7 = 41;
				goto IL_29d3;
			case 68:
				array3[10] = (byte)num8;
				num7 = 252;
				goto IL_29d3;
			case 28:
				array3[14] = 54;
				num7 = 229;
				goto IL_29d3;
			case 158:
				array3[29] = (byte)num8;
				num = 192;
				break;
			case 14:
				if (array5.Length > 0)
				{
					num = 162;
					break;
				}
				goto case 266;
			case 180:
				num8 = 67 - 27;
				num = 68;
				break;
			case 363:
				num8 = 131 - 43;
				goto case 94;
			case 334:
				symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
				transform = (ICryptoTransform)/*Error near IL_0537: Stack underflow*/;
				num2 = 297;
				goto IL_29d7;
			case 227:
				array2[14] = (byte)num9;
				num = 156;
				break;
			case 55:
				array2[2] = 126;
				num2 = 251;
				goto IL_29d7;
			case 275:
				array3[19] = (byte)num8;
				num = 178;
				break;
			case 230:
				memoryStream.ToArray();
				aG4AVoW1T = (byte[])/*Error near IL_05a4: Stack underflow*/;
				num2 = 95;
				goto IL_29d7;
			case 122:
				_ = typeof(S7EI44sMaZQ92MiG6X);
				_ = ((Type)/*Error near IL_32fe: Stack underflow*/).Assembly;
				((Assembly)/*Error near IL_3308: Stack underflow*/).GetName();
				((AssemblyName)/*Error near IL_3312: Stack underflow*/).GetPublicKeyToken();
				array5 = (byte[])/*Error near IL_05cd: Stack underflow*/;
				num7 = 310;
				goto IL_29d3;
			case 277:
				array3[21] = 17;
				num7 = 131;
				goto IL_29d3;
			case 324:
				num8 = 56 + 82;
				num2 = 361;
				if (1 == 0)
				{
					goto case 74;
				}
				goto IL_29d7;
			case 74:
				num8 = 15 + 76;
				num = 205;
				break;
			case 284:
				array3[31] = (byte)num8;
				num2 = 72;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_064e: Stack underflow*/ != 0)
				{
					goto case 51;
				}
				goto IL_29d7;
			case 93:
				num9 = 18 + 8;
				num2 = 92;
				goto IL_29d7;
			case 157:
				array2[14] = (byte)num9;
				num7 = 382;
				goto IL_29d3;
			case 170:
				array3[10] = (byte)num8;
				num = 315;
				break;
			case 279:
				num8 = 172 - 57;
				num2 = 85;
				if (1 == 0)
				{
					goto case 21;
				}
				goto IL_29d7;
			case 21:
				array2[14] = (byte)num9;
				num7 = 45;
				goto IL_29d3;
			case 69:
				array3[15] = 92;
				num2 = 373;
				goto IL_29d7;
			case 287:
				array3[1] = (byte)num8;
				num2 = 368;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_071a: Stack underflow*/ == 0)
				{
					goto case 56;
				}
				goto IL_29d7;
			case 56:
				if (aG4AVoW1T.Length == 0)
				{
					num = 273;
					break;
				}
				goto case 304;
			case 340:
				num8 = 170 - 56;
				num = 351;
				break;
			case 336:
				num8 = 120 + 105;
				num2 = 332;
				goto IL_29d7;
			case 250:
				array2[12] = 108;
				num7 = 177;
				goto IL_29d3;
			case 26:
				array2[10] = (byte)num9;
				num2 = 51;
				if (1 == 0)
				{
					goto case 294;
				}
				goto IL_29d7;
			case 294:
				num9 = 213 - 71;
				num2 = 248;
				if (1 == 0)
				{
					goto case 345;
				}
				goto IL_29d7;
			case 345:
				num8 = 79 + 2;
				num2 = 29;
				goto IL_29d7;
			case 167:
				array3[30] = (byte)num8;
				num = 18;
				break;
			case 70:
				array2[10] = (byte)num9;
				num = 90;
				break;
			case 3:
				num9 = 232 - 77;
				num = 369;
				break;
			case 128:
				array3[0] = 49;
				num2 = 74;
				goto IL_29d7;
			case 271:
				array3[0] = 102;
				num2 = 257;
				if (1 == 0)
				{
					goto case 163;
				}
				goto IL_29d7;
			case 163:
				array3[20] = 216;
				num7 = 214;
				goto IL_29d3;
			case 34:
				array3[3] = (byte)num8;
				num = 143;
				break;
			case 141:
				_ = binaryReader.BaseStream;
				((Stream)/*Error near IL_334e: Stack underflow*/).Position = 0L;
				num7 = 352;
				goto IL_29d3;
			case 20:
				array3[6] = 157;
				num = 87;
				break;
			case 256:
				array4[13] = array5[6];
				num = 130;
				break;
			case 121:
				num8 = 214 - 71;
				num2 = 268;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0928: Stack underflow*/ != 0)
				{
					goto case 67;
				}
				goto IL_29d7;
			case 309:
				num9 = 186 + 2;
				num2 = 231;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_094f: Stack underflow*/ == 0)
				{
					goto case 2;
				}
				goto IL_29d7;
			case 217:
				array3[6] = 168;
				num = 23;
				break;
			case 169:
				num8 = 195 - 65;
				num7 = 318;
				goto IL_29d3;
			case 181:
				num8 = 47 + 87;
				num7 = 31;
				goto IL_29d3;
			case 35:
				array2[0] = (byte)num9;
				num7 = 113;
				goto IL_29d3;
			case 78:
				array3[13] = (byte)num8;
				num2 = 96;
				goto IL_29d7;
			case 243:
				array3[2] = (byte)num8;
				num = 249;
				break;
			case 211:
				num8 = 25 + 114;
				num7 = 357;
				goto IL_29d3;
			case 16:
				num8 = 172 - 57;
				num2 = 100;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0a2c: Stack underflow*/ == 0)
				{
					goto case 200;
				}
				goto IL_29d7;
			case 200:
				array3[23] = 20;
				num = 144;
				break;
			case 339:
				num8 = 144 - 48;
				num7 = 179;
				goto IL_29d3;
			case 182:
				num9 = 249 - 83;
				num = 333;
				break;
			case 282:
				array2[15] = 253;
				num = 259;
				break;
			case 208:
				array3[25] = (byte)num8;
				num7 = 220;
				goto IL_29d3;
			case 315:
				num8 = 26 + 54;
				num2 = 175;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0ad6: Stack underflow*/ != 0)
				{
					goto case 261;
				}
				goto IL_29d7;
			case 261:
				array3[27] = 173;
				num2 = 33;
				if (false)
				{
					goto case 313;
				}
				goto IL_29d7;
			case 313:
				num8 = 188 - 62;
				num2 = 158;
				goto IL_29d7;
			case 335:
				array2[7] = (byte)num9;
				num = 245;
				break;
			case 354:
				array3[8] = (byte)num8;
				num2 = 228;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0b50: Stack underflow*/ != 0)
				{
					goto case 347;
				}
				goto IL_29d7;
			case 347:
				array3[6] = 237;
				num7 = 324;
				goto IL_29d3;
			case 300:
				array2[11] = 188;
				num7 = 146;
				goto IL_29d3;
			case 37:
				num8 = 216 - 72;
				num7 = 0;
				goto IL_29d3;
			case 197:
				array4[5] = array5[2];
				num2 = 349;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0bc1: Stack underflow*/ != 0)
				{
					goto case 164;
				}
				goto IL_29d7;
			case 164:
				array2 = new byte[16];
				num = 379;
				break;
			case 233:
				array3[14] = 60;
				num7 = 236;
				goto IL_29d3;
			case 238:
				array3[1] = 162;
				num = 53;
				break;
			case 2:
				array2[11] = (byte)num9;
				num2 = 93;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0c38: Stack underflow*/ != 0)
				{
					goto case 306;
				}
				goto IL_29d7;
			case 111:
				array2[9] = 109;
				num7 = 378;
				goto IL_29d3;
			case 350:
				num9 = 181 - 60;
				num2 = 2;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0c7e: Stack underflow*/ != 0)
				{
					goto case 264;
				}
				goto IL_29d7;
			case 264:
				num8 = 119 + 36;
				num7 = 286;
				goto IL_29d3;
			case 267:
				num8 = 135 - 45;
				num = 317;
				break;
			case 41:
				array3[19] = 117;
				num2 = 58;
				if (1 == 0)
				{
					goto case 106;
				}
				goto IL_29d7;
			case 106:
				array3[16] = (byte)num8;
				num = 46;
				break;
			case 281:
				array3[2] = (byte)num8;
				num = 38;
				break;
			case 126:
				array2[8] = (byte)num9;
				num7 = 194;
				goto IL_29d3;
			case 129:
				array3[31] = 74;
				num7 = 329;
				goto IL_29d3;
			case 13:
				array2[13] = (byte)num9;
				num2 = 182;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0d5c: Stack underflow*/ != 0)
				{
					goto case 321;
				}
				goto IL_29d7;
			case 311:
				array2[6] = 101;
				num7 = 223;
				goto IL_29d3;
			case 206:
				array2[8] = 202;
				num = 358;
				break;
			case 187:
				array3[26] = 50;
				num2 = 307;
				if (1 == 0)
				{
					goto case 4;
				}
				goto IL_29d7;
			case 4:
				array2[3] = (byte)num9;
				num2 = 365;
				if (1 == 0)
				{
					goto case 161;
				}
				goto IL_29d7;
			case 161:
				num9 = 103 + 11;
				num7 = 316;
				goto IL_29d3;
			case 125:
				array3[27] = (byte)num8;
				num = 261;
				break;
			case 32:
				num8 = 213 - 71;
				num2 = 159;
				if (1 == 0)
				{
					goto case 156;
				}
				goto IL_29d7;
			case 156:
				num9 = 58 + 54;
				num7 = 157;
				goto IL_29d3;
			case 245:
				num9 = 16 + 8;
				num = 165;
				break;
			case 352:
			{
				_ = binaryReader.BaseStream;
				_ = ((Stream)/*Error near IL_33bc: Stack underflow*/).Length;
				int count = (int)/*Error near IL_0e6e: Stack underflow*/;
				((BinaryReader)/*Error near IL_33c6: Stack underflow*/).ReadBytes(count);
				array6 = (byte[])/*Error near IL_0e74: Stack underflow*/;
				num2 = 330;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0e87: Stack underflow*/ == 0)
				{
					goto case 175;
				}
				goto IL_29d7;
			}
			case 175:
				array3[10] = (byte)num8;
				num2 = 339;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0ea8: Stack underflow*/ != 0)
				{
					goto case 349;
				}
				goto IL_29d7;
			case 349:
				array4[7] = array5[3];
				num2 = 174;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0ec2: Stack underflow*/ == 0)
				{
					goto case 37;
				}
				goto IL_29d7;
			case 166:
				num8 = 193 - 64;
				num7 = 208;
				goto IL_29d3;
			case 124:
				num8 = 91 - 20;
				num2 = 104;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0f02: Stack underflow*/ == 0)
				{
					goto case 383;
				}
				goto IL_29d7;
			case 116:
				array3[20] = 176;
				num2 = 60;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0f2f: Stack underflow*/ != 0)
				{
					goto case 5;
				}
				goto IL_29d7;
			case 251:
				num9 = 182 - 60;
				num7 = 173;
				goto IL_29d3;
			case 140:
				array3[26] = 168;
				num2 = 203;
				if (false)
				{
					goto case 72;
				}
				goto IL_29d7;
			case 72:
				num8 = 213 + 15;
				num7 = 353;
				goto IL_29d3;
			case 213:
				array3[23] = (byte)num8;
				num2 = 76;
				if (false)
				{
					goto case 7;
				}
				goto IL_29d7;
			case 7:
				array3[5] = (byte)num8;
				num2 = 59;
				goto IL_29d7;
			case 204:
				num8 = 114 + 92;
				num2 = 371;
				goto IL_29d7;
			case 91:
				array3[14] = 116;
				num = 61;
				break;
			case 376:
				array3[28] = 45;
				num7 = 209;
				goto IL_29d3;
			case 0:
				array3[26] = (byte)num8;
				num7 = 187;
				goto IL_29d3;
			case 123:
				array2[2] = (byte)num9;
				num7 = 190;
				goto IL_29d3;
			case 369:
				array2[11] = (byte)num9;
				num2 = 300;
				goto IL_29d7;
			case 76:
				array3[24] = 105;
				num7 = 121;
				goto IL_29d3;
			case 6:
				array3[17] = 168;
				num2 = 336;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_10b1: Stack underflow*/ == 0)
				{
					goto IL_29d7;
				}
				goto case 266;
			case 263:
				symmetricAlgorithm.Mode = CipherMode.CBC;
				num2 = 334;
				goto IL_29d7;
			case 139:
				array2[4] = 189;
				num = 183;
				break;
			case 355:
				array2[4] = (byte)num9;
				num2 = 75;
				goto IL_29d7;
			case 274:
				num8 = 191 - 63;
				num2 = 226;
				if (false)
				{
					goto case 210;
				}
				goto IL_29d7;
			case 210:
				num9 = 100 + 26;
				num7 = 242;
				goto IL_29d3;
			case 328:
				array3[9] = 61;
				num2 = 119;
				goto IL_29d7;
			case 109:
				array2[8] = 116;
				num7 = 293;
				goto IL_29d3;
			case 280:
				num9 = 175 - 92;
				num2 = 82;
				goto IL_29d7;
			case 341:
				array3[13] = (byte)num8;
				num = 306;
				break;
			case 103:
				num8 = 146 - 48;
				num = 153;
				break;
			case 225:
				num8 = 147 - 49;
				num = 167;
				break;
			case 135:
				num9 = 105 + 3;
				num2 = 292;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1209: Stack underflow*/ == 0)
				{
					goto case 249;
				}
				goto IL_29d7;
			case 229:
				num8 = 239 - 79;
				num = 246;
				break;
			case 130:
				array4[15] = array5[7];
				num2 = 266;
				goto IL_29d7;
			case 86:
				array2[1] = (byte)num9;
				num = 255;
				break;
			case 108:
				num9 = 207 - 69;
				num2 = 224;
				goto IL_29d7;
			case 49:
				array2[1] = 86;
				num2 = 108;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_129a: Stack underflow*/ == 0)
				{
					goto case 256;
				}
				goto IL_29d7;
			case 99:
				num8 = 10 + 63;
				num2 = 5;
				goto IL_29d7;
			case 378:
				num9 = 118 - 57;
				num2 = 184;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_12de: Stack underflow*/ == 0)
				{
					goto IL_29d7;
				}
				goto case 266;
			case 147:
				array4[11] = array5[5];
				num7 = 256;
				goto IL_29d3;
			case 367:
				num9 = 9 + 96;
				num7 = 260;
				goto IL_29d3;
			case 228:
				num8 = 90 + 67;
				num = 346;
				break;
			case 360:
				num8 = 172 - 57;
				num2 = 276;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1355: Stack underflow*/ == 0)
				{
					goto case 260;
				}
				goto IL_29d7;
			case 46:
				num8 = 153 - 58;
				num = 240;
				break;
			case 196:
				array3[11] = (byte)num8;
				num7 = 204;
				goto IL_29d3;
			case 145:
				num8 = 27 + 111;
				num2 = 120;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_13ad: Stack underflow*/ == 0)
				{
					goto case 67;
				}
				goto IL_29d7;
			case 67:
				num9 = 126 + 59;
				num = 86;
				break;
			case 383:
				array2[10] = 174;
				num7 = 350;
				goto IL_29d3;
			case 168:
				array3[25] = (byte)num8;
				num = 363;
				break;
			case 242:
				array2[11] = (byte)num9;
				num2 = 250;
				goto IL_29d7;
			case 358:
				num9 = 45 + 60;
				num7 = 81;
				goto IL_29d3;
			case 273:
				_ = typeof(S7EI44sMaZQ92MiG6X);
				_ = ((Type)/*Error near IL_345c: Stack underflow*/).Assembly;
				((Assembly)/*Error near IL_3466: Stack underflow*/).GetManifestResourceStream("dae0dd73-a7aa-4c56-bf93-6667b45133af");
				new BinaryReader((Stream)/*Error near IL_3470: Stack underflow*/);
				binaryReader = (BinaryReader)/*Error near IL_1451: Stack underflow*/;
				num7 = 141;
				goto IL_29d3;
			case 9:
				array3[25] = (byte)num8;
				num2 = 241;
				if (false)
				{
					goto case 173;
				}
				goto IL_29d7;
			case 173:
				array2[2] = (byte)num9;
				num7 = 52;
				goto IL_29d3;
			case 330:
				array3 = new byte[32];
				num7 = 271;
				goto IL_29d3;
			case 64:
				array3[5] = (byte)num8;
				num = 267;
				break;
			case 154:
				num9 = 47 + 87;
				num2 = 13;
				if (false)
				{
					goto case 241;
				}
				goto IL_29d7;
			case 241:
				num8 = 193 - 64;
				num2 = 168;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1500: Stack underflow*/ != 0)
				{
					goto case 127;
				}
				goto IL_29d7;
			case 127:
				array3[17] = 146;
				num2 = 326;
				goto IL_29d7;
			case 17:
				array3[5] = (byte)num8;
				num2 = 211;
				if (1 == 0)
				{
					goto case 202;
				}
				goto IL_29d7;
			case 202:
				array3[30] = (byte)num8;
				num = 362;
				break;
			case 337:
				rgbKey = array3;
				num7 = 164;
				goto IL_29d3;
			case 249:
				num8 = 169 - 56;
				num2 = 222;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1589: Stack underflow*/ == 0)
				{
					goto case 29;
				}
				goto IL_29d7;
			case 29:
				array3[1] = (byte)num8;
				num7 = 380;
				goto IL_29d3;
			case 176:
				array2[0] = 147;
				num2 = 15;
				if (false)
				{
					goto case 332;
				}
				goto IL_29d7;
			case 332:
				array3[17] = (byte)num8;
				num2 = 12;
				if (1 == 0)
				{
					goto case 368;
				}
				goto IL_29d7;
			case 368:
				array3[1] = 72;
				num = 97;
				break;
			case 192:
				array3[29] = 110;
				num7 = 152;
				goto IL_29d3;
			case 321:
				cryptoStream.Write(array6, 0, array6.Length);
				num = 62;
				break;
			case 307:
				array3[27] = 111;
				num7 = 312;
				goto IL_29d3;
			case 272:
				array2[1] = 123;
				num2 = 67;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_167d: Stack underflow*/ == 0)
				{
					goto case 118;
				}
				goto IL_29d7;
			case 118:
				array4[3] = array5[1];
				num7 = 197;
				goto IL_29d3;
			case 269:
				array3[7] = (byte)num8;
				num2 = 320;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_16af: Stack underflow*/ != 0)
				{
					goto case 267;
				}
				goto IL_29d7;
			case 290:
				array3[14] = (byte)num8;
				num2 = 28;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_16d5: Stack underflow*/ != 0)
				{
					goto case 242;
				}
				goto IL_29d7;
			case 165:
				array2[8] = (byte)num9;
				num = 73;
				break;
			case 232:
				array2[15] = 118;
				num = 161;
				break;
			case 60:
				num8 = 27 + 30;
				num7 = 370;
				goto IL_29d3;
			case 257:
				array3[0] = 151;
				num7 = 128;
				goto IL_29d3;
			case 318:
				array3[22] = (byte)num8;
				num2 = 47;
				goto IL_29d7;
			case 54:
				num8 = 133 + 112;
				num2 = 344;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1787: Stack underflow*/ == 0)
				{
					goto case 83;
				}
				goto IL_29d7;
			case 270:
				array3[13] = (byte)num8;
				num2 = 219;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_17ad: Stack underflow*/ == 0)
				{
					goto case 360;
				}
				goto IL_29d7;
			case 288:
				array3[4] = 124;
				num2 = 42;
				goto IL_29d7;
			case 240:
				array3[16] = (byte)num8;
				num7 = 278;
				goto IL_29d3;
			case 79:
				num8 = 149 - 74;
				num7 = 343;
				goto IL_29d3;
			case 327:
				array3[26] = (byte)num8;
				num2 = 37;
				if (1 == 0)
				{
					goto case 247;
				}
				goto IL_29d7;
			case 247:
				num8 = 136 - 45;
				num2 = 7;
				goto IL_29d7;
			case 374:
				array3[26] = (byte)num8;
				num = 140;
				break;
			case 80:
				array3[0] = 232;
				num7 = 345;
				goto IL_29d3;
			case 89:
				num8 = 116 + 124;
				num7 = 9;
				goto IL_29d3;
			case 136:
			case 138:
				array3[17] = (byte)num8;
				num2 = 127;
				goto IL_29d7;
			case 114:
				num9 = 89 + 121;
				num7 = 70;
				goto IL_29d3;
			case 207:
				array3[10] = 235;
				num2 = 366;
				goto IL_29d7;
			case 222:
				array3[2] = (byte)num8;
				num7 = 215;
				goto IL_29d3;
			case 40:
				num8 = 84 + 15;
				num2 = 299;
				if (1 == 0)
				{
					goto case 45;
				}
				goto IL_29d7;
			case 45:
				array2[14] = 189;
				num2 = 201;
				if (1 == 0)
				{
					goto case 61;
				}
				goto IL_29d7;
			case 61:
				num8 = 191 - 63;
				num = 290;
				break;
			case 214:
				array3[21] = 167;
				num7 = 277;
				goto IL_29d3;
			case 209:
				num8 = 111 + 5;
				num = 132;
				break;
			case 25:
				array3[24] = 100;
				num = 285;
				break;
			case 15:
				num9 = 26 + 48;
				num = 35;
				break;
			case 81:
				array2[9] = (byte)num9;
				num2 = 111;
				goto IL_29d7;
			case 66:
				array2[13] = 217;
				num2 = 218;
				if (false)
				{
					goto case 71;
				}
				goto IL_29d7;
			case 71:
				num8 = 166 - 55;
				num2 = 269;
				goto IL_29d7;
			case 160:
				array2[7] = (byte)num9;
				num2 = 135;
				if (false)
				{
					goto case 48;
				}
				goto IL_29d7;
			case 48:
				_ = typeof(S7EI44sMaZQ92MiG6X);
				_ = ((Type)/*Error near IL_34d4: Stack underflow*/).Assembly;
				QtPdCl3GL((object)/*Error near IL_34de: Stack underflow*/);
				((object)/*Error near IL_34e8: Stack underflow*/).ToString();
				jo86RDUMn((string)/*Error near IL_34f2: Stack underflow*/);
				sptJkRDeR = (byte[])/*Error near IL_1a68: Stack underflow*/;
				num2 = 283;
				if (1 == 0)
				{
					goto case 113;
				}
				goto IL_29d7;
			case 113:
				num9 = 153 + 54;
				num = 319;
				break;
			case 224:
				array2[1] = (byte)num9;
				num = 356;
				break;
			case 10:
				array3[9] = 123;
				num2 = 32;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1ad0: Stack underflow*/ == 0)
				{
					goto case 352;
				}
				goto IL_29d7;
			case 178:
				array3[19] = 102;
				num7 = 116;
				goto IL_29d3;
			case 52:
				num9 = 124 - 42;
				num2 = 123;
				if (1 == 0)
				{
					goto case 306;
				}
				goto IL_29d7;
			case 306:
				num8 = 78 + 103;
				num2 = 57;
				if (false)
				{
					goto case 98;
				}
				goto IL_29d7;
			case 98:
				array3[31] = 178;
				num2 = 274;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1b58: Stack underflow*/ == 0)
				{
					goto case 331;
				}
				goto IL_29d7;
			case 171:
				num8 = 139 - 46;
				num2 = 112;
				if (1 == 0)
				{
					goto case 105;
				}
				goto IL_29d7;
			case 105:
				array3[1] = (byte)num8;
				num2 = 115;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1b9c: Stack underflow*/ != 0)
				{
					goto case 23;
				}
				goto IL_29d7;
			case 23:
				array3[6] = 92;
				num = 347;
				break;
			case 333:
				array2[13] = (byte)num9;
				num2 = 66;
				goto IL_29d7;
			case 119:
				num8 = 121 + 59;
				num7 = 27;
				goto IL_29d3;
			case 301:
				array3[8] = (byte)num8;
				num = 142;
				break;
			case 246:
				array3[15] = (byte)num8;
				num2 = 102;
				goto IL_29d7;
			case 142:
				array3[8] = 84;
				num2 = 10;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1c4c: Stack underflow*/ != 0)
				{
					goto case 39;
				}
				goto IL_29d7;
			case 39:
				num9 = 13 + 75;
				num2 = 160;
				goto IL_29d7;
			case 133:
				array2[12] = 47;
				num2 = 154;
				if (1 == 0)
				{
					goto case 381;
				}
				goto IL_29d7;
			case 381:
				array3[29] = (byte)num8;
				num2 = 40;
				goto IL_29d7;
			case 185:
				num8 = 169 - 56;
				num7 = 30;
				goto IL_29d3;
			case 144:
				num8 = 217 + 14;
				num7 = 213;
				goto IL_29d3;
			case 308:
				array2[6] = 53;
				num = 311;
				break;
			case 255:
				array2[2] = 98;
				num = 55;
				break;
			case 77:
				array3[15] = 91;
				num2 = 69;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1d41: Stack underflow*/ != 0)
				{
					goto case 280;
				}
				goto IL_29d7;
			case 298:
				array3[4] = 150;
				num = 65;
				break;
			case 244:
				num8 = 15 + 38;
				num7 = 375;
				goto IL_29d3;
			case 87:
				array3[6] = 150;
				num7 = 217;
				goto IL_29d3;
			case 364:
				array2[14] = 121;
				num2 = 359;
				goto IL_29d7;
			case 372:
				array2[1] = (byte)num9;
				num2 = 272;
				if (1 == 0)
				{
					goto case 92;
				}
				goto IL_29d7;
			case 92:
				array2[11] = (byte)num9;
				num7 = 3;
				goto IL_29d3;
			case 260:
				array2[5] = (byte)num9;
				num = 262;
				break;
			case 379:
				num9 = 148 - 49;
				num2 = 314;
				if (false)
				{
					goto case 377;
				}
				goto IL_29d7;
			case 377:
				num9 = 206 - 68;
				num = 227;
				break;
			case 50:
				array2[7] = 96;
				num7 = 24;
				goto IL_29d3;
			case 353:
				array3[31] = (byte)num8;
				num2 = 337;
				if (false)
				{
					goto case 97;
				}
				goto IL_29d7;
			case 97:
				num8 = 173 - 62;
				num2 = 105;
				goto IL_29d7;
			case 283:
				num4 = 0;
				num7 = 384;
				goto IL_29d3;
			case 82:
				array2[6] = (byte)num9;
				num2 = 258;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1ecb: Stack underflow*/ != 0)
				{
					goto case 317;
				}
				goto IL_29d7;
			case 317:
				array3[5] = (byte)num8;
				num2 = 342;
				if (false)
				{
					goto case 351;
				}
				goto IL_29d7;
			case 351:
				array3[23] = (byte)num8;
				num = 8;
				break;
			case 179:
				array3[10] = (byte)num8;
				num2 = 180;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1f21: Stack underflow*/ == 0)
				{
					goto case 196;
				}
				goto IL_29d7;
			case 220:
				num8 = 0 + 29;
				num2 = 134;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1f48: Stack underflow*/ == 0)
				{
					goto case 12;
				}
				goto IL_29d7;
			case 12:
				num8 = 105 + 80;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1f66: Stack underflow*/ != 0)
				{
					num = 94;
					break;
				}
				num2 = 136;
				goto IL_29d7;
			case 42:
				num8 = 164 - 54;
				num7 = 83;
				goto IL_29d3;
			case 302:
				array3[4] = (byte)num8;
				num2 = 360;
				goto IL_29d7;
			case 101:
				num8 = 157 - 52;
				num = 374;
				break;
			case 24:
				num9 = 159 - 120;
				num2 = 335;
				goto IL_29d7;
			case 51:
				array2[10] = 103;
				num7 = 383;
				goto IL_29d3;
			case 304:
				if (sptJkRDeR.Length == 0)
				{
					num = 48;
					break;
				}
				goto case 283;
			case 316:
				array2[15] = (byte)num9;
				num7 = 282;
				goto IL_29d3;
			case 223:
				num9 = 64 + 10;
				num = 239;
				break;
			case 295:
				num9 = 85 + 95;
				num = 355;
				break;
			case 198:
				num8 = 137 - 45;
				num = 354;
				break;
			case 268:
				array3[24] = (byte)num8;
				num7 = 155;
				goto IL_29d3;
			case 343:
				array3[12] = (byte)num8;
				num7 = 181;
				goto IL_29d3;
			case 132:
				array3[29] = (byte)num8;
				num2 = 221;
				if (1 == 0)
				{
					goto case 226;
				}
				goto IL_29d7;
			case 226:
				array3[31] = (byte)num8;
				num2 = 129;
				if (1 == 0)
				{
					goto case 102;
				}
				goto IL_29d7;
			case 102:
				array3[15] = 150;
				num7 = 77;
				goto IL_29d3;
			case 254:
				num9 = 164 - 54;
				num = 11;
				break;
			case 88:
				array3[15] = (byte)num8;
				num2 = 145;
				if (1 == 0)
				{
					goto case 117;
				}
				goto IL_29d7;
			case 117:
				num8 = 208 - 69;
				num7 = 188;
				goto IL_29d3;
			case 57:
				array3[14] = (byte)num8;
				num7 = 233;
				goto IL_29d3;
			case 205:
				array3[0] = (byte)num8;
				num7 = 80;
				goto IL_29d3;
			case 366:
				num8 = 128 - 42;
				num2 = 170;
				if (1 == 0)
				{
					goto case 231;
				}
				goto IL_29d7;
			case 231:
				array2[5] = (byte)num9;
				num2 = 265;
				if (1 == 0)
				{
					goto case 248;
				}
				goto IL_29d7;
			case 248:
				array2[10] = (byte)num9;
				num2 = 114;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_21dc: Stack underflow*/ == 0)
				{
					goto case 203;
				}
				goto IL_29d7;
			case 203:
				num8 = 58 + 61;
				num2 = 327;
				goto IL_29d7;
			case 59:
				num8 = 92 + 60;
				num7 = 64;
				goto IL_29d3;
			case 199:
				num8 = 14 + 64;
				num = 323;
				break;
			case 221:
				num8 = 222 - 74;
				num2 = 289;
				goto IL_29d7;
			case 11:
				array2[4] = (byte)num9;
				num = 295;
				break;
			case 292:
				array2[7] = (byte)num9;
				num2 = 50;
				goto IL_29d7;
			case 326:
				array3[18] = 154;
				num = 110;
				break;
			case 22:
				num9 = 248 - 82;
				num7 = 372;
				goto IL_29d3;
			case 305:
				array3[3] = 99;
				num2 = 279;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_22dc: Stack underflow*/ == 0)
				{
					goto case 184;
				}
				goto IL_29d7;
			case 63:
				array3[11] = 82;
				num2 = 291;
				if (false)
				{
					goto case 27;
				}
				goto IL_29d7;
			case 27:
				array3[10] = (byte)num8;
				num7 = 207;
				goto IL_29d3;
			case 62:
				cryptoStream.FlushFinalBlock();
				num7 = 230;
				goto IL_29d3;
			case 329:
				num8 = 150 - 50;
				num2 = 193;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2350: Stack underflow*/ != 0)
				{
					goto case 153;
				}
				goto IL_29d7;
			case 153:
				array3[29] = (byte)num8;
				num7 = 313;
				goto IL_29d3;
			case 357:
				array3[5] = (byte)num8;
				num7 = 247;
				goto IL_29d3;
			case 189:
				num8 = 40 + 13;
				num2 = 17;
				if (false)
				{
					goto case 252;
				}
				goto IL_29d7;
			case 252:
				array3[11] = 166;
				num = 172;
				break;
			case 193:
				array3[31] = (byte)num8;
				num2 = 148;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_23de: Stack underflow*/ == 0)
				{
					goto case 84;
				}
				goto IL_29d7;
			case 84:
				array2[5] = 98;
				num7 = 367;
				goto IL_29d3;
			case 1:
				num9 = 27 + 1;
				num2 = 4;
				if (1 == 0)
				{
					goto case 188;
				}
				goto IL_29d7;
			case 188:
				array3[22] = (byte)num8;
				num2 = 43;
				goto IL_29d7;
			case 152:
				num8 = 14 + 124;
				num = 381;
				break;
			case 325:
				num8 = 99 + 60;
				num2 = 125;
				goto IL_29d7;
			case 151:
				array2[4] = (byte)num9;
				num = 254;
				break;
			case 285:
				array3[24] = 8;
				num7 = 166;
				goto IL_29d3;
			case 96:
				num8 = 174 + 32;
				num2 = 341;
				if (1 == 0)
				{
					goto case 237;
				}
				goto IL_29d7;
			case 237:
				array3[21] = 224;
				num = 117;
				break;
			case 236:
				array3[14] = 118;
				num2 = 91;
				if (1 == 0)
				{
					goto case 174;
				}
				goto IL_29d7;
			case 174:
				array4[9] = array5[4];
				num = 147;
				break;
			case 33:
				array3[28] = 110;
				num7 = 195;
				goto IL_29d3;
			case 219:
				num8 = 224 - 74;
				num = 78;
				break;
			case 146:
				array2[11] = 206;
				num2 = 210;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2577: Stack underflow*/ == 0)
				{
					goto case 235;
				}
				goto IL_29d7;
			case 235:
				array2[8] = (byte)num9;
				num = 109;
				break;
			case 338:
				array3[22] = (byte)num8;
				num = 169;
				break;
			case 371:
				array3[11] = (byte)num8;
				num = 63;
				break;
			case 148:
				num8 = 155 - 51;
				num2 = 284;
				goto IL_29d7;
			case 322:
				array3[23] = 209;
				num2 = 200;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2604: Stack underflow*/ == 0)
				{
					goto case 104;
				}
				goto IL_29d7;
			case 104:
				array3[4] = (byte)num8;
				num = 189;
				break;
			case 5:
				array3[27] = (byte)num8;
				num = 325;
				break;
			case 155:
				array3[24] = 174;
				num2 = 25;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_265c: Stack underflow*/ != 0)
				{
					goto case 243;
				}
				goto IL_29d7;
			case 120:
				array3[16] = (byte)num8;
				num = 264;
				break;
			case 296:
				num8 = 179 - 59;
				num = 106;
				break;
			case 310:
				if (array5 == null)
				{
					goto case 266;
				}
				num = 14;
				break;
			case 253:
				new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream = (CryptoStream)/*Error near IL_26af: Stack underflow*/;
				num = 321;
				break;
			case 149:
				num8 = 88 - 27;
				num2 = 281;
				if (1 == 0)
				{
					goto case 365;
				}
				goto IL_29d7;
			case 365:
				array2[3] = 204;
				num7 = 107;
				goto IL_29d3;
			case 100:
				array3[8] = (byte)num8;
				num2 = 212;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2717: Stack underflow*/ != 0)
				{
					goto case 158;
				}
				goto IL_29d7;
			case 73:
				num9 = 211 - 70;
				num = 235;
				break;
			case 289:
				array3[29] = (byte)num8;
				num2 = 103;
				goto IL_29d7;
			case 172:
				num8 = 251 - 83;
				num = 196;
				break;
			case 44:
				cryptoStream.Close();
				num7 = 19;
				goto IL_29d3;
			case 331:
				num8 = 249 - 83;
				num = 270;
				break;
			case 293:
				num9 = 137 - 45;
				num7 = 126;
				goto IL_29d3;
			case 195:
				array3[28] = 88;
				num2 = 376;
				if (1 == 0)
				{
					goto case 83;
				}
				goto IL_29d7;
			case 83:
				array3[4] = (byte)num8;
				num7 = 298;
				goto IL_29d3;
			case 150:
				array3[22] = (byte)num8;
				num2 = 340;
				goto IL_29d7;
			case 112:
				array3[19] = (byte)num8;
				num = 234;
				break;
			case 19:
				binaryReader.Close();
				num = 304;
				break;
			case 299:
				array3[30] = (byte)num8;
				num7 = 225;
				goto IL_29d3;
			case 234:
				num8 = 140 - 46;
				num = 275;
				break;
			case 286:
				array3[16] = (byte)num8;
				num7 = 296;
				goto IL_29d3;
			case 183:
				array2[5] = 124;
				num2 = 84;
				goto IL_29d7;
			case 131:
				num8 = 73 + 8;
				num7 = 348;
				goto IL_29d3;
			case 218:
				array2[13] = 123;
				num7 = 377;
				goto IL_29d3;
			case 258:
				array2[7] = 120;
				num2 = 39;
				goto IL_29d7;
			case 342:
				array3[5] = 223;
				num2 = 20;
				if (1 == 0)
				{
					goto case 65;
				}
				goto IL_29d7;
			case 65:
				num8 = 55 + 60;
				num7 = 302;
				goto IL_29d3;
			case 31:
				array3[13] = (byte)num8;
				num2 = 331;
				goto IL_29d7;
			case 90:
				num9 = 5 + 120;
				num2 = 26;
				goto IL_29d7;
			case 47:
				num8 = 140 - 42;
				num7 = 150;
				goto IL_29d3;
			case 177:
				array2[12] = 191;
				num = 133;
				break;
			case 359:
				num9 = 47 + 77;
				num7 = 21;
				goto IL_29d3;
			case 94:
			case 191:
				array3[25] = (byte)num8;
				goto case 54;
			default:
				num7 = 54;
				goto IL_29d3;
			case 190:
				array2[3] = 159;
				num = 1;
				break;
			case 361:
				array3[7] = (byte)num8;
				num = 71;
				break;
			case 38:
				num8 = 70 + 3;
				num7 = 34;
				goto IL_29d3;
			case 53:
				num8 = 179 - 59;
				num7 = 287;
				goto IL_29d3;
			case 319:
				array2[0] = (byte)num9;
				num2 = 49;
				if (0 == 0)
				{
					goto IL_29d7;
				}
				goto case 43;
			case 43:
				num8 = 113 + 52;
				num = 338;
				break;
			case 162:
				array4[1] = array5[0];
				num7 = 118;
				goto IL_29d3;
			case 380:
				array3[1] = 128;
				num = 238;
				break;
			case 382:
				array2[14] = 96;
				num2 = 364;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_30e5: Stack underflow*/ != 0)
				{
					goto case 149;
				}
				goto IL_29d7;
			case 259:
				array4 = array2;
				num2 = 122;
				goto IL_29d7;
			case 30:
				array3[3] = (byte)num8;
				num7 = 305;
				goto IL_29d3;
			case 370:
				array3[20] = (byte)num8;
				num = 163;
				break;
			case 384:
				try
				{
					byte[] array = new byte[4];
					int num3 = 1;
					if (1 == 0)
					{
						goto IL_3144;
					}
					goto IL_315f;
					IL_315f:
					while (true)
					{
						switch (num3)
						{
						case 0:
							break;
						case 3:
						case 5:
							goto IL_31a3;
						case 2:
						case 4:
							array[2] = aG4AVoW1T[_0020 + 2];
							goto IL_31a3;
						case 1:
							array[0] = aG4AVoW1T[_0020];
							num3 = 0;
							if (0 == 0)
							{
								continue;
							}
							goto case 6;
						case 6:
							BitConverter.ToInt32(array, 0);
							num4 = (int)/*Error near IL_3222: Stack underflow*/;
							goto end_IL_312d;
						default:
							goto IL_3202;
						}
						break;
					}
					goto IL_3144;
					IL_3144:
					array[1] = aG4AVoW1T[_0020 + 1];
					goto IL_3202;
					IL_3202:
					S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_3193: Stack underflow*/ != 0)
					{
						num3 = 4;
						if (1 == 0)
						{
							goto IL_31a3;
						}
					}
					else
					{
						num3 = 5;
					}
					goto IL_315f;
					IL_31a3:
					array[3] = aG4AVoW1T[_0020 + 3];
					num3 = 6;
					goto IL_315f;
					end_IL_312d:;
				}
				catch
				{
				}
				try
				{
					if (sptJkRDeR[num4] == 128)
					{
						_ = 0;
						S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						int num5;
						if ((int)/*Error near IL_324a: Stack underflow*/ != 0)
						{
							num5 = 2;
						}
						else
						{
							int num6 = 3;
							num5 = num6;
						}
						switch (num5)
						{
						case 0:
						case 2:
							return true;
						default:
							return result;
						case 3:
							return result;
						}
					}
				}
				catch
				{
				}
				return false;
			case 297:
				new MemoryStream();
				memoryStream = (MemoryStream)/*Error near IL_076d: Stack underflow*/;
				num2 = 253;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0780: Stack underflow*/ == 0)
				{
					goto case 250;
				}
				goto IL_29d7;
			case 266:
				{
					coJxnYf0j();
					symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_12e5: Stack underflow*/;
					num7 = 263;
					goto IL_29d3;
				}
				IL_29d3:
				num2 = num7;
				goto IL_29d7;
				IL_29d7:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static string Bb3jwS8CZ(int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_1897, IL_2f4c, IL_331a
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_2f99: Incompatible stack heights: 0 vs 2
		//IL_2fad: Incompatible stack heights: 0 vs 1
		//IL_2fb7: Incompatible stack heights: 0 vs 1
		//IL_2fd7: Incompatible stack heights: 0 vs 1
		//IL_2fe1: Incompatible stack heights: 0 vs 1
		//IL_2ff5: Incompatible stack heights: 0 vs 1
		//IL_3009: Incompatible stack heights: 0 vs 1
		//IL_3013: Incompatible stack heights: 0 vs 1
		//IL_301d: Incompatible stack heights: 0 vs 1
		//IL_3027: Incompatible stack heights: 0 vs 1
		//IL_3031: Incompatible stack heights: 0 vs 2
		//IL_303b: Incompatible stack heights: 0 vs 1
		//IL_304f: Incompatible stack heights: 0 vs 1
		//IL_3059: Incompatible stack heights: 0 vs 1
		//IL_3063: Incompatible stack heights: 0 vs 1
		//IL_306d: Incompatible stack heights: 0 vs 1
		//IL_3077: Incompatible stack heights: 0 vs 1
		//IL_3081: Incompatible stack heights: 0 vs 1
		//IL_308b: Incompatible stack heights: 0 vs 1
		//IL_3095: Incompatible stack heights: 0 vs 1
		//IL_309f: Incompatible stack heights: 0 vs 1
		//IL_30a9: Incompatible stack heights: 0 vs 1
		//IL_30b3: Incompatible stack heights: 0 vs 1
		//IL_30bd: Incompatible stack heights: 0 vs 1
		//IL_30c7: Incompatible stack heights: 0 vs 1
		//IL_30d1: Incompatible stack heights: 0 vs 1
		//IL_30db: Incompatible stack heights: 0 vs 1
		//IL_30e5: Incompatible stack heights: 0 vs 1
		//IL_30ef: Incompatible stack heights: 0 vs 1
		//IL_30f9: Incompatible stack heights: 0 vs 1
		//IL_3103: Incompatible stack heights: 0 vs 1
		//IL_310d: Incompatible stack heights: 0 vs 1
		//IL_3117: Incompatible stack heights: 0 vs 1
		//IL_3121: Incompatible stack heights: 0 vs 1
		//IL_312b: Incompatible stack heights: 0 vs 1
		//IL_3135: Incompatible stack heights: 0 vs 1
		//IL_313f: Incompatible stack heights: 0 vs 1
		//IL_3149: Incompatible stack heights: 0 vs 2
		//IL_3153: Incompatible stack heights: 0 vs 1
		//IL_315d: Incompatible stack heights: 0 vs 1
		//IL_3167: Incompatible stack heights: 0 vs 1
		//IL_3171: Incompatible stack heights: 0 vs 1
		//IL_317b: Incompatible stack heights: 0 vs 1
		//IL_3185: Incompatible stack heights: 0 vs 1
		//IL_318f: Incompatible stack heights: 0 vs 1
		//IL_31a3: Incompatible stack heights: 0 vs 1
		//IL_31ad: Incompatible stack heights: 0 vs 1
		//IL_31b7: Incompatible stack heights: 0 vs 1
		//IL_31c1: Incompatible stack heights: 0 vs 1
		//IL_31d5: Incompatible stack heights: 0 vs 1
		//IL_31df: Incompatible stack heights: 0 vs 1
		//IL_31e9: Incompatible stack heights: 0 vs 1
		//IL_31f3: Incompatible stack heights: 0 vs 1
		//IL_31fd: Incompatible stack heights: 0 vs 1
		//IL_3207: Incompatible stack heights: 0 vs 1
		//IL_3211: Incompatible stack heights: 0 vs 1
		//IL_321b: Incompatible stack heights: 0 vs 1
		//IL_3225: Incompatible stack heights: 0 vs 1
		//IL_322f: Incompatible stack heights: 0 vs 1
		//IL_3239: Incompatible stack heights: 0 vs 1
		//IL_3243: Incompatible stack heights: 0 vs 1
		//IL_324d: Incompatible stack heights: 0 vs 1
		//IL_3257: Incompatible stack heights: 0 vs 1
		//IL_3261: Incompatible stack heights: 0 vs 1
		//IL_326b: Incompatible stack heights: 0 vs 1
		//IL_3275: Incompatible stack heights: 0 vs 1
		//IL_327f: Incompatible stack heights: 0 vs 1
		//IL_3289: Incompatible stack heights: 0 vs 1
		//IL_329d: Incompatible stack heights: 0 vs 1
		//IL_32a7: Incompatible stack heights: 0 vs 1
		//IL_32b1: Incompatible stack heights: 0 vs 1
		//IL_32bb: Incompatible stack heights: 0 vs 1
		//IL_32c5: Incompatible stack heights: 0 vs 1
		//IL_32cf: Incompatible stack heights: 0 vs 1
		//IL_32d9: Incompatible stack heights: 0 vs 1
		//IL_32e3: Incompatible stack heights: 0 vs 1
		//IL_32f7: Incompatible stack heights: 0 vs 1
		//IL_3301: Incompatible stack heights: 0 vs 1
		//IL_330b: Incompatible stack heights: 0 vs 1
		//IL_3315: Incompatible stack heights: 0 vs 1
		int num = 5;
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		int num8 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array5 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array4 = default(byte[]);
		BinaryReader binaryReader = default(BinaryReader);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array6 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] rgbKey = default(byte[]);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num7;
				switch (num2)
				{
				case 7:
					array2[14] = 81;
					num7 = 71;
					goto IL_189c;
				case 250:
					array2[21] = (byte)num6;
					num = 235;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_0055: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 270;
				case 270:
					num8 = 163 - 54;
					num = 133;
					break;
				case 340:
					array3[0] = 24;
					num2 = 343;
					continue;
				case 5:
					if (VlvvMf0S2.Length == 0)
					{
						num2 = 47;
						continue;
					}
					goto case 301;
				case 29:
					array2[24] = (byte)num6;
					num2 = 17;
					continue;
				case 140:
					array3[7] = 213;
					num = 342;
					if (true)
					{
						break;
					}
					goto case 254;
				case 254:
					num8 = 60 + 117;
					num7 = 12;
					goto IL_189c;
				case 318:
					array2[19] = 100;
					num7 = 109;
					goto IL_189c;
				case 134:
					array2[13] = 149;
					num2 = 93;
					continue;
				case 177:
					num6 = 202 - 109;
					num7 = 163;
					goto IL_189c;
				case 14:
					array3[2] = 228;
					num7 = 255;
					goto IL_189c;
				case 159:
					array2[10] = 50;
					num7 = 2;
					goto IL_189c;
				case 164:
					array2[3] = 102;
					num7 = 153;
					goto IL_189c;
				case 299:
					array2[5] = 134;
					num7 = 310;
					goto IL_189c;
				case 251:
					num6 = 109 + 124;
					num = 294;
					break;
				case 60:
					array3[15] = 122;
					num = 332;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0214: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 181;
				case 181:
					num6 = 106 - 64;
					num2 = 252;
					continue;
				case 97:
					array3[6] = 199;
					num2 = 149;
					continue;
				case 21:
					num8 = 108 + 22;
					num = 132;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					num6 = 131 - 43;
					num7 = 124;
					goto IL_189c;
				case 244:
					num6 = 125 - 41;
					num7 = 29;
					goto IL_189c;
				case 141:
					num6 = 111 + 59;
					num2 = 293;
					continue;
				case 248:
					array3[11] = (byte)num8;
					num7 = 272;
					goto IL_189c;
				case 176:
					num6 = 239 - 79;
					num = 28;
					if (0 == 0)
					{
						break;
					}
					goto case 218;
				case 218:
					if (array5.Length > 0)
					{
						num = 234;
						break;
					}
					goto case 353;
				case 61:
					array2[8] = (byte)num6;
					num7 = 96;
					goto IL_189c;
				case 232:
					array2[7] = (byte)num6;
					num7 = 173;
					goto IL_189c;
				case 193:
					memoryStream.Close();
					num = 86;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_034d: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 337;
				case 227:
					num6 = 88 + 0;
					num2 = 34;
					continue;
				case 94:
					array2[12] = 147;
					num2 = 280;
					continue;
				case 305:
					array4 = array3;
					num2 = 118;
					continue;
				case 324:
					binaryReader.Close();
					num2 = 301;
					continue;
				case 191:
					array3[13] = 136;
					num2 = 27;
					continue;
				case 182:
					array2[25] = 160;
					num7 = 167;
					goto IL_189c;
				case 54:
					array3[2] = 134;
					num2 = 4;
					continue;
				case 285:
					array3[8] = (byte)num8;
					num7 = 51;
					goto IL_189c;
				case 264:
					array3[12] = 18;
					num = 22;
					if (0 == 0)
					{
						break;
					}
					goto case 34;
				case 34:
					array2[5] = (byte)num6;
					num = 141;
					break;
				case 350:
					array4[5] = array5[2];
					num2 = 70;
					continue;
				case 33:
					num6 = 51 + 107;
					num = 357;
					if (0 == 0)
					{
						break;
					}
					goto case 314;
				case 314:
					array2[16] = (byte)num6;
					num2 = 241;
					continue;
				case 306:
					num6 = 99 + 24;
					num7 = 289;
					goto IL_189c;
				case 129:
					array2[0] = (byte)num6;
					num = 102;
					if (0 == 0)
					{
						break;
					}
					goto case 185;
				case 185:
					num8 = 24 + 30;
					num = 239;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_04fd: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 139;
				case 108:
					num8 = 157 - 52;
					num7 = 281;
					goto IL_189c;
				case 356:
					array2[22] = 235;
					num = 10;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0543: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 342;
				case 6:
					array2[29] = 74;
					num7 = 216;
					goto IL_189c;
				case 38:
					num6 = 205 - 68;
					num = 314;
					if (true)
					{
						break;
					}
					goto case 280;
				case 280:
					array2[12] = 202;
					num7 = 33;
					goto IL_189c;
				case 357:
					array2[12] = (byte)num6;
					num7 = 240;
					goto IL_189c;
				case 147:
					num8 = 97 + 67;
					num2 = 316;
					continue;
				case 132:
					array3[4] = (byte)num8;
					num = 59;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_05f6: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 17;
				case 267:
					array2[21] = (byte)num6;
					num = 104;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_061c: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 272;
				case 272:
					array3[12] = 109;
					num7 = 275;
					goto IL_189c;
				case 338:
					array2[23] = (byte)num6;
					num2 = 172;
					continue;
				case 292:
					num8 = 85 + 102;
					num2 = 237;
					continue;
				case 326:
					if (array5 != null)
					{
						num2 = 218;
						continue;
					}
					goto case 353;
				case 241:
					num6 = 97 + 62;
					num2 = 81;
					continue;
				case 179:
					array3[14] = (byte)num8;
					num2 = 116;
					continue;
				case 120:
					array3[3] = (byte)num8;
					num7 = 203;
					goto IL_189c;
				case 290:
					array2[28] = 131;
					num7 = 174;
					goto IL_189c;
				case 143:
					array2[1] = 29;
					_ = 0;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_0705: Stack underflow*/ != 0)
					{
						num = 175;
						break;
					}
					num2 = 157;
					continue;
				case 238:
					num6 = 65 + 36;
					num = 211;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0736: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 239;
				case 239:
					array3[11] = (byte)num8;
					num7 = 186;
					goto IL_189c;
				case 253:
					array2[26] = 116;
					num7 = 238;
					goto IL_189c;
				case 249:
					array2[11] = (byte)num6;
					num7 = 58;
					goto IL_189c;
				case 279:
					array2[2] = 98;
					num2 = 259;
					continue;
				case 46:
					array2[21] = (byte)num6;
					num2 = 36;
					continue;
				case 115:
					cryptoStream.Write(array6, 0, array6.Length);
					num2 = 360;
					continue;
				case 276:
					array3 = new byte[16];
					num = 254;
					break;
				case 183:
					array2[24] = (byte)num6;
					num = 224;
					break;
				case 258:
					array2[14] = 144;
					num = 7;
					if (true)
					{
						break;
					}
					goto case 263;
				case 263:
					array2[3] = 234;
					num2 = 358;
					continue;
				case 212:
					array2[8] = 147;
					num2 = 337;
					continue;
				case 165:
					array2[17] = 147;
					num2 = 271;
					continue;
				case 149:
					num8 = 24 + 120;
					num = 188;
					if (true)
					{
						break;
					}
					goto case 173;
				case 173:
					num6 = 7 + 23;
					num7 = 321;
					goto IL_189c;
				case 114:
					num8 = 115 + 112;
					num2 = 248;
					continue;
				case 323:
					num6 = 177 - 85;
					num7 = 325;
					goto IL_189c;
				case 362:
					array3[9] = 104;
					num2 = 84;
					continue;
				case 30:
					array2[0] = (byte)num6;
					num2 = 230;
					continue;
				case 345:
					array3[12] = (byte)num8;
					num2 = 113;
					continue;
				case 126:
					num8 = 199 - 66;
					num2 = 57;
					continue;
				case 321:
					array2[7] = (byte)num6;
					num2 = 225;
					continue;
				case 172:
					num6 = 50 + 17;
					num2 = 44;
					continue;
				case 247:
					array2[13] = 248;
					num = 277;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_09b5: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 271;
				case 116:
					array3[14] = 157;
					num7 = 85;
					goto IL_189c;
				case 342:
					array3[8] = 59;
					num = 20;
					break;
				case 158:
					array3[7] = 128;
					num2 = 346;
					continue;
				case 79:
					array3[5] = 19;
					num = 286;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_0a43: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 231;
				case 231:
					num6 = 199 - 66;
					num2 = 268;
					continue;
				case 334:
					array3[5] = 168;
					num = 184;
					break;
				case 277:
					array2[14] = 80;
					num7 = 258;
					goto IL_189c;
				case 207:
					array2[18] = (byte)num6;
					num2 = 117;
					continue;
				case 93:
					array2[13] = 98;
					num7 = 312;
					goto IL_189c;
				case 73:
					num6 = 163 - 54;
					num = 100;
					break;
				case 101:
					array2[21] = (byte)num6;
					num = 356;
					if (0 == 0)
					{
						break;
					}
					goto case 142;
				case 142:
					num6 = 199 - 66;
					num2 = 30;
					continue;
				case 35:
					num6 = 125 - 41;
					num7 = 139;
					goto IL_189c;
				case 104:
					num6 = 223 - 74;
					num7 = 46;
					goto IL_189c;
				case 315:
					array2[30] = 132;
					num = 144;
					if (0 == 0)
					{
						break;
					}
					goto case 361;
				case 361:
					array3[6] = (byte)num8;
					num7 = 311;
					goto IL_189c;
				case 312:
					array2[13] = 159;
					num7 = 222;
					goto IL_189c;
				case 269:
					array2[28] = (byte)num6;
					num2 = 45;
					continue;
				case 67:
					array3[14] = (byte)num8;
					num7 = 307;
					goto IL_189c;
				case 184:
					num8 = 8 + 57;
					num = 335;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0c18: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 25;
				case 160:
					array3[1] = (byte)num8;
					num2 = 202;
					continue;
				case 166:
					num6 = 202 - 67;
					num = 304;
					break;
				case 297:
					num6 = 170 - 56;
					num = 207;
					if (true)
					{
						break;
					}
					goto case 118;
				case 118:
					_ = typeof(S7EI44sMaZQ92MiG6X);
					_ = ((Type)/*Error near IL_3081: Stack underflow*/).Assembly;
					((Assembly)/*Error near IL_308b: Stack underflow*/).GetName();
					((AssemblyName)/*Error near IL_3095: Stack underflow*/).GetPublicKeyToken();
					array5 = (byte[])/*Error near IL_0c8b: Stack underflow*/;
					num = 326;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0c9e: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 116;
				case 208:
					array4[13] = array5[6];
					num2 = 205;
					continue;
				case 128:
					num8 = 82 + 1;
					num2 = 201;
					continue;
				case 197:
					num8 = 185 - 61;
					num = 361;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_0cf0: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 11;
				case 49:
					array2[29] = 204;
					num2 = 251;
					continue;
				case 152:
					array3[1] = (byte)num8;
					num = 0;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0d35: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 348;
				case 348:
					num8 = 30 + 112;
					num = 3;
					break;
				case 64:
					num6 = 40 + 114;
					num2 = 262;
					continue;
				case 295:
					array2[25] = (byte)num6;
					num = 76;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_0d8c: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 204;
				case 204:
					array2[27] = 96;
					num2 = 24;
					continue;
				case 337:
					num6 = 98 + 68;
					num7 = 61;
					goto IL_189c;
				case 27:
					array3[13] = 60;
					num7 = 121;
					goto IL_189c;
				case 1:
					array2[7] = (byte)num6;
					num = 212;
					break;
				case 39:
					array3[1] = 52;
					num = 110;
					break;
				case 284:
					array2[27] = 110;
					num = 204;
					break;
				case 294:
					array2[29] = (byte)num6;
					num = 95;
					break;
				case 225:
					num6 = 106 + 27;
					num = 1;
					if (true)
					{
						break;
					}
					goto case 200;
				case 200:
					array3[0] = (byte)num8;
					num = 340;
					break;
				case 228:
					array2[17] = 115;
					num7 = 306;
					goto IL_189c;
				case 32:
					array2[10] = 91;
					num7 = 159;
					goto IL_189c;
				case 110:
					num8 = 140 - 46;
					num7 = 152;
					goto IL_189c;
				case 347:
					new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream = (CryptoStream)/*Error near IL_0efe: Stack underflow*/;
					num = 115;
					if (true)
					{
						break;
					}
					goto case 178;
				case 178:
					num6 = 104 - 3;
					num7 = 103;
					goto IL_189c;
				case 58:
					array2[11] = 176;
					num = 169;
					if (0 == 0)
					{
						break;
					}
					goto case 268;
				case 268:
					array2[28] = (byte)num6;
					num = 290;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_0f6b: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 153;
				case 153:
					num6 = 104 + 28;
					num = 55;
					if (true)
					{
						break;
					}
					goto case 307;
				case 307:
					array3[14] = 157;
					num = 60;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0fb1: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					array3[9] = (byte)num8;
					num = 362;
					break;
				case 243:
					array3[13] = (byte)num8;
					num = 191;
					if (0 == 0)
					{
						break;
					}
					goto case 26;
				case 26:
					array3[2] = 104;
					num = 14;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_1012: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 50;
				case 50:
					num6 = 105 + 64;
					num2 = 250;
					continue;
				case 196:
					array3[11] = 68;
					num2 = 185;
					continue;
				case 43:
					array2[6] = (byte)num6;
					num = 151;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_106b: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 230;
				case 230:
					num6 = 79 - 77;
					num7 = 155;
					goto IL_189c;
				case 111:
					num8 = 29 + 95;
					num = 179;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_10a6: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 185;
				case 219:
					num6 = 204 - 68;
					num = 288;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_10cd: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 273;
				case 273:
					num8 = 83 + 68;
					num = 120;
					break;
				case 57:
					array3[10] = (byte)num8;
					num2 = 48;
					continue;
				case 82:
					array2[2] = 86;
					num = 13;
					break;
				case 217:
					num8 = 7 + 105;
					num = 65;
					if (0 == 0)
					{
						break;
					}
					goto case 22;
				case 22:
					array3[13] = 98;
					num2 = 330;
					continue;
				case 155:
					array2[0] = (byte)num6;
					num = 143;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_1183: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 274;
				case 76:
					array2[25] = 96;
					num7 = 221;
					goto IL_189c;
				case 11:
					array2[24] = (byte)num6;
					num = 244;
					if (0 == 0)
					{
						break;
					}
					goto case 24;
				case 24:
					num6 = 84 + 99;
					num = 282;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_11e6: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 269;
				case 145:
					array2[30] = (byte)num6;
					num7 = 106;
					goto IL_189c;
				case 341:
					array3[11] = 182;
					num2 = 196;
					continue;
				case 89:
					num6 = 187 - 62;
					num = 146;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_1244: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 325;
				case 71:
					array2[15] = 138;
					num = 266;
					break;
				case 298:
					array2[15] = 148;
					num = 53;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_1294: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 136;
				case 136:
					num6 = 116 + 47;
					num = 327;
					if (true)
					{
						break;
					}
					goto case 70;
				case 70:
					array4[7] = array5[3];
					num2 = 213;
					continue;
				case 148:
					array3[11] = (byte)num8;
					num = 114;
					if (true)
					{
						break;
					}
					goto case 117;
				case 117:
					array2[18] = 106;
					num2 = 105;
					continue;
				case 180:
					array3[8] = (byte)num8;
					num = 322;
					if (true)
					{
						break;
					}
					goto case 271;
				case 271:
					array2[17] = 110;
					num2 = 228;
					continue;
				case 358:
					num6 = 199 - 66;
					num2 = 317;
					continue;
				case 125:
					array2[31] = (byte)num6;
					num = 178;
					if (true)
					{
						break;
					}
					goto case 260;
				case 260:
					array2[29] = (byte)num6;
					num7 = 6;
					goto IL_189c;
				case 246:
					array2[20] = (byte)num6;
					num7 = 63;
					goto IL_189c;
				case 192:
					array2[31] = 117;
					num = 351;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_13c9: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 353;
				case 309:
				{
					_ = binaryReader.BaseStream;
					_ = ((Stream)/*Error near IL_3153: Stack underflow*/).Length;
					int count = (int)/*Error near IL_13e7: Stack underflow*/;
					((BinaryReader)/*Error near IL_315d: Stack underflow*/).ReadBytes(count);
					array6 = (byte[])/*Error near IL_13ed: Stack underflow*/;
					num2 = 15;
					continue;
				}
				case 187:
					array2[9] = 149;
					num2 = 89;
					continue;
				case 90:
					array3[10] = 27;
					num = 341;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_143e: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 48;
				case 48:
					array3[10] = 85;
					num = 349;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_1466: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 326;
				case 98:
					array2[7] = 22;
					num7 = 123;
					goto IL_189c;
				case 363:
					array2[29] = (byte)num6;
					num = 49;
					break;
				case 355:
					array2[22] = (byte)num6;
					num7 = 319;
					goto IL_189c;
				case 195:
					array2[0] = (byte)num6;
					num = 176;
					break;
				case 119:
					array3[6] = 159;
					num = 128;
					break;
				case 135:
					num6 = 88 + 63;
					num2 = 43;
					continue;
				case 214:
					rgbKey = array2;
					num2 = 276;
					continue;
				case 68:
					array2[6] = 156;
					num = 135;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_154d: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 259;
				case 259:
					num6 = 131 - 43;
					num2 = 150;
					continue;
				case 130:
					num6 = 135 + 47;
					num2 = 189;
					continue;
				case 319:
					num6 = 24 - 7;
					num = 194;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_15a1: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 230;
				case 286:
					num8 = 154 - 51;
					num2 = 16;
					continue;
				case 66:
					array3[10] = 106;
					num = 108;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_15e7: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 273;
				case 360:
					cryptoStream.FlushFinalBlock();
					num = 233;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_1606: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 328;
				case 150:
					array2[2] = (byte)num6;
					num2 = 131;
					continue;
				case 234:
					array4[1] = array5[0];
					num2 = 62;
					continue;
				case 202:
					num8 = 215 - 71;
					num2 = 242;
					continue;
				case 359:
					array2[9] = 177;
					num = 177;
					break;
				case 310:
					array2[5] = 159;
					num2 = 227;
					continue;
				case 278:
					num8 = 84 + 88;
					num = 160;
					break;
				case 245:
					array2[26] = (byte)num6;
					num7 = 220;
					goto IL_189c;
				case 18:
				case 175:
					array2[1] = 145;
					num2 = 265;
					continue;
				case 296:
					array3[1] = (byte)num8;
					num = 278;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_1704: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 268;
				case 83:
					array3[1] = (byte)num8;
					num = 217;
					if (0 == 0)
					{
						break;
					}
					goto case 236;
				case 236:
					array3[15] = (byte)num8;
					num = 147;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_1747: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 105;
				case 88:
					array2[24] = (byte)num6;
					num2 = 291;
					continue;
				case 167:
					num6 = 14 + 91;
					num = 295;
					break;
				case 80:
					array2[2] = (byte)num6;
					num = 82;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_17a2: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 186;
				case 186:
					num8 = 89 + 63;
					num2 = 148;
					continue;
				case 300:
					array2[21] = (byte)num6;
					num7 = 328;
					goto IL_189c;
				case 37:
					num6 = 169 - 56;
					num7 = 75;
					goto IL_189c;
				case 303:
					num6 = 167 - 55;
					num7 = 183;
					goto IL_189c;
				case 188:
					array3[7] = (byte)num8;
					num7 = 329;
					goto IL_189c;
				case 255:
					array3[3] = 158;
					num7 = 352;
					goto IL_189c;
				case 107:
					num8 = 36 - 0;
					num2 = 180;
					continue;
				case 52:
					num8 = 99 - 10;
					num2 = 308;
					continue;
				case 86:
					cryptoStream.Close();
					num = 324;
					break;
				case 283:
					num6 = 140 - 103;
					goto case 245;
				default:
					num = 245;
					break;
				case 137:
					array2[20] = 154;
					num = 31;
					if (0 == 0)
					{
						break;
					}
					goto case 220;
				case 220:
					num6 = 199 - 66;
					num7 = 344;
					goto IL_189c;
				case 12:
					array3[0] = (byte)num8;
					num7 = 274;
					goto IL_189c;
				case 211:
					array2[26] = (byte)num6;
					num = 229;
					break;
				case 223:
					num8 = 224 - 74;
					num = 345;
					break;
				case 112:
					array2[15] = (byte)num6;
					num = 298;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_1f1a: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 103;
				case 103:
					array2[31] = (byte)num6;
					num = 214;
					break;
				case 282:
					array2[27] = (byte)num6;
					num = 231;
					if (0 == 0)
					{
						break;
					}
					goto case 317;
				case 317:
					array2[4] = (byte)num6;
					num2 = 92;
					continue;
				case 322:
					num8 = 174 - 58;
					num2 = 170;
					continue;
				case 144:
					num6 = 163 - 54;
					num = 145;
					break;
				case 42:
					array3[8] = 123;
					num7 = 78;
					goto IL_189c;
				case 20:
					num8 = 193 - 64;
					num = 285;
					break;
				case 275:
					num8 = 182 - 60;
					num2 = 313;
					continue;
				case 95:
					num6 = 72 + 53;
					num = 260;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2018: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 161;
				case 78:
					num8 = 125 - 41;
					num = 171;
					if (true)
					{
						break;
					}
					goto case 106;
				case 106:
					array2[30] = 193;
					num2 = 181;
					continue;
				case 198:
					num6 = 4 + 64;
					num2 = 195;
					continue;
				case 85:
					num8 = 52 + 120;
					num = 67;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2095: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 113;
				case 105:
					array2[18] = 67;
					num2 = 25;
					continue;
				case 346:
					array3[7] = 120;
					num = 140;
					if (0 == 0)
					{
						break;
					}
					goto case 154;
				case 154:
					array2[0] = (byte)num6;
					num2 = 142;
					continue;
				case 133:
					array3[7] = (byte)num8;
					num2 = 158;
					continue;
				case 17:
					num6 = 99 + 79;
					num7 = 87;
					goto IL_189c;
				case 84:
					array3[9] = 204;
					num = 126;
					if (true)
					{
						break;
					}
					goto case 349;
				case 349:
					num8 = 41 + 1;
					num = 127;
					break;
				case 226:
					num6 = 32 + 120;
					num = 129;
					break;
				case 53:
					num6 = 57 - 32;
					num7 = 9;
					goto IL_189c;
				case 69:
					array2[1] = (byte)num6;
					num7 = 190;
					goto IL_189c;
				case 170:
					array3[9] = (byte)num8;
					num7 = 292;
					goto IL_189c;
				case 206:
					num8 = 189 - 63;
					num7 = 200;
					goto IL_189c;
				case 332:
					num8 = 138 - 46;
					num2 = 236;
					continue;
				case 302:
					array2[5] = 119;
					num = 299;
					break;
				case 87:
					array2[24] = (byte)num6;
					num7 = 182;
					goto IL_189c;
				case 331:
					symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
					transform = (ICryptoTransform)/*Error near IL_2245: Stack underflow*/;
					num = 168;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2258: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 8;
				case 335:
					array3[5] = (byte)num8;
					num = 79;
					if (0 == 0)
					{
						break;
					}
					goto case 240;
				case 240:
					array2[12] = 214;
					num = 134;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_22a2: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 174;
				case 174:
					num6 = 20 + 74;
					num = 269;
					if (true)
					{
						break;
					}
					goto case 265;
				case 265:
					num6 = 226 + 12;
					num2 = 69;
					continue;
				case 274:
					array3[0] = 123;
					num = 23;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2301: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 28;
				case 28:
					array2[0] = (byte)num6;
					num7 = 226;
					goto IL_189c;
				case 157:
				case 215:
					array2[31] = (byte)num6;
					num = 192;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_233a: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 63;
				case 63:
					num6 = 156 + 54;
					num = 41;
					break;
				case 221:
					array2[25] = 65;
					num7 = 253;
					goto IL_189c;
				case 96:
					num6 = 128 - 64;
					num2 = 19;
					continue;
				case 121:
					array3[14] = 75;
					num7 = 111;
					goto IL_189c;
				case 100:
					array2[29] = (byte)num6;
					num2 = 354;
					continue;
				case 163:
					array2[9] = (byte)num6;
					num = 210;
					if (true)
					{
						break;
					}
					goto case 261;
				case 261:
					array2[3] = 78;
					num2 = 164;
					continue;
				case 288:
					array2[3] = (byte)num6;
					num = 261;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2423: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 232;
				case 224:
					num6 = 52 + 100;
					num2 = 88;
					continue;
				case 55:
					array2[3] = (byte)num6;
					num = 263;
					break;
				case 156:
					array2[23] = 169;
					num = 303;
					break;
				case 56:
					array2[6] = (byte)num6;
					num7 = 323;
					goto IL_189c;
				case 74:
					array2[19] = (byte)num6;
					num7 = 318;
					goto IL_189c;
				case 139:
					array2[13] = (byte)num6;
					num2 = 247;
					continue;
				case 19:
					array2[8] = (byte)num6;
					num7 = 187;
					goto IL_189c;
				case 23:
					num8 = 209 - 69;
					num = 138;
					if (true)
					{
						break;
					}
					goto case 252;
				case 252:
					array2[30] = (byte)num6;
					num = 287;
					if (true)
					{
						break;
					}
					goto case 31;
				case 31:
					num6 = 222 - 74;
					num = 246;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_253d: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 266;
				case 266:
					num6 = 36 + 110;
					num7 = 112;
					goto IL_189c;
				case 256:
					num6 = 90 + 34;
					num = 11;
					break;
				case 194:
					array2[22] = (byte)num6;
					num2 = 166;
					continue;
				case 47:
					_ = typeof(S7EI44sMaZQ92MiG6X);
					_ = ((Type)/*Error near IL_3243: Stack underflow*/).Assembly;
					((Assembly)/*Error near IL_324d: Stack underflow*/).GetManifestResourceStream("41c50755-5d2e-4d5b-8673-3f7674a849be");
					new BinaryReader((Stream)/*Error near IL_3257: Stack underflow*/);
					binaryReader = (BinaryReader)/*Error near IL_25aa: Stack underflow*/;
					num = 8;
					break;
				case 257:
					array2[4] = (byte)num6;
					num = 130;
					break;
				case 40:
					array2[11] = 25;
					num7 = 91;
					goto IL_189c;
				case 123:
					num6 = 236 - 78;
					num = 232;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2615: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 320;
				case 320:
					array2[16] = (byte)num6;
					num2 = 99;
					continue;
				case 262:
					array2[28] = (byte)num6;
					num2 = 73;
					continue;
				case 201:
					array3[6] = (byte)num8;
					num = 97;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2666: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 358;
				case 99:
					array2[16] = 24;
					num2 = 165;
					continue;
				case 281:
					array3[10] = (byte)num8;
					num2 = 90;
					continue;
				case 36:
					num6 = 124 - 35;
					num = 101;
					if (true)
					{
						break;
					}
					goto case 199;
				case 199:
					num6 = 221 - 73;
					num = 338;
					break;
				case 92:
					num6 = 27 + 94;
					num = 257;
					if (true)
					{
						break;
					}
					goto case 10;
				case 10:
					num6 = 131 - 43;
					num7 = 355;
					goto IL_189c;
				case 189:
					array2[4] = (byte)num6;
					num7 = 302;
					goto IL_189c;
				case 16:
					array3[6] = (byte)num8;
					num7 = 197;
					goto IL_189c;
				case 41:
					array2[20] = (byte)num6;
					num7 = 333;
					goto IL_189c;
				case 0:
					num8 = 198 + 19;
					num = 83;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_277e: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 268;
				case 313:
					array3[12] = (byte)num8;
					num2 = 223;
					continue;
				case 45:
					array2[28] = 91;
					num7 = 64;
					goto IL_189c;
				case 242:
					array3[1] = (byte)num8;
					num7 = 39;
					goto IL_189c;
				case 291:
					array2[24] = 96;
					num = 256;
					break;
				case 102:
					num6 = 221 - 73;
					num = 154;
					break;
				case 216:
					array2[30] = 168;
					num7 = 315;
					goto IL_189c;
				case 146:
					array2[9] = (byte)num6;
					num = 359;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2852: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 51;
				case 51:
					array3[8] = 104;
					num = 42;
					if (0 == 0)
					{
						break;
					}
					goto case 9;
				case 9:
					array2[15] = (byte)num6;
					num = 37;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2897: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 234;
				case 169:
					num6 = 17 + 105;
					num7 = 122;
					goto IL_189c;
				case 162:
					array2[2] = (byte)num6;
					num2 = 219;
					continue;
				case 65:
					array3[2] = (byte)num8;
					num = 54;
					break;
				case 330:
					num8 = 186 - 62;
					num = 243;
					if (0 == 0)
					{
						break;
					}
					goto case 287;
				case 287:
					num6 = 121 + 29;
					goto case 157;
				case 131:
					num6 = 6 + 21;
					num7 = 80;
					goto IL_189c;
				case 72:
					symmetricAlgorithm.Mode = CipherMode.CBC;
					num7 = 331;
					goto IL_189c;
				case 124:
					array2[11] = (byte)num6;
					num = 40;
					if (true)
					{
						break;
					}
					goto case 75;
				case 75:
					array2[16] = (byte)num6;
					num = 38;
					break;
				case 44:
					array2[23] = (byte)num6;
					num = 156;
					break;
				case 354:
					num6 = 17 + 119;
					num2 = 363;
					continue;
				case 190:
					num6 = 217 - 72;
					num2 = 209;
					continue;
				case 229:
					array2[26] = 105;
					num = 283;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2a00: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 114;
				case 327:
					array2[10] = (byte)num6;
					num = 32;
					break;
				case 122:
					array2[12] = (byte)num6;
					num7 = 94;
					goto IL_189c;
				case 210:
					array2[10] = 105;
					num2 = 136;
					continue;
				case 235:
					num6 = 93 + 46;
					num2 = 300;
					continue;
				case 109:
					array2[19] = 254;
					num = 137;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2a99: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 218;
				case 77:
					num6 = 127 - 42;
					num = 320;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2ac0: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 81;
				case 81:
					array2[16] = (byte)num6;
					num7 = 77;
					goto IL_189c;
				case 91:
					num6 = 218 - 72;
					num = 249;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2afa: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 329;
				case 329:
					array3[7] = 174;
					num7 = 270;
					goto IL_189c;
				case 161:
					array3[4] = 122;
					num = 52;
					if (0 == 0)
					{
						break;
					}
					goto case 325;
				case 325:
					array2[6] = (byte)num6;
					num = 98;
					break;
				case 127:
					array3[10] = (byte)num8;
					num7 = 66;
					goto IL_189c;
				case 343:
					num8 = 123 + 41;
					num2 = 296;
					continue;
				case 213:
					array4[9] = array5[4];
					num = 336;
					if (true)
					{
						break;
					}
					goto case 304;
				case 304:
					array2[23] = (byte)num6;
					num = 199;
					break;
				case 138:
					array3[0] = (byte)num8;
					num2 = 206;
					continue;
				case 289:
					array2[18] = (byte)num6;
					num7 = 297;
					goto IL_189c;
				case 15:
					array2 = new byte[32];
					num2 = 198;
					continue;
				case 301:
					BitConverter.ToInt32(VlvvMf0S2, _0020);
					num3 = (int)/*Error near IL_2c12: Stack underflow*/;
					num = 364;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_2c25: Stack underflow*/ == 0)
					{
						break;
					}
					goto case 19;
				case 209:
					array2[2] = (byte)num6;
					num = 279;
					if (true)
					{
						break;
					}
					goto case 344;
				case 344:
					array2[27] = (byte)num6;
					num7 = 284;
					goto IL_189c;
				case 233:
					memoryStream.ToArray();
					VlvvMf0S2 = (byte[])/*Error near IL_2c6b: Stack underflow*/;
					num2 = 193;
					continue;
				case 171:
					array3[8] = (byte)num8;
					num2 = 107;
					continue;
				case 293:
					array2[5] = (byte)num6;
					num2 = 68;
					continue;
				case 222:
					num6 = 215 - 71;
					num7 = 339;
					goto IL_189c;
				case 311:
					array3[6] = 108;
					num = 119;
					break;
				case 328:
					num6 = 125 - 41;
					num2 = 267;
					continue;
				case 237:
					array3[9] = (byte)num8;
					num2 = 348;
					continue;
				case 62:
					array4[3] = array5[1];
					num = 350;
					break;
				case 336:
					array4[11] = array5[5];
					num = 208;
					break;
				case 151:
					num6 = 35 + 123;
					num2 = 56;
					continue;
				case 308:
					array3[4] = (byte)num8;
					num = 334;
					if (0 == 0)
					{
						break;
					}
					goto case 8;
				case 8:
					_ = binaryReader.BaseStream;
					((Stream)/*Error near IL_32ed: Stack underflow*/).Position = 0L;
					num = 309;
					if (true)
					{
						break;
					}
					goto case 205;
				case 205:
					array4[15] = array5[7];
					num7 = 353;
					goto IL_189c;
				case 25:
					num6 = 119 + 90;
					num = 74;
					if (true)
					{
						break;
					}
					goto case 13;
				case 13:
					num6 = 49 + 86;
					num = 162;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2de1: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 184;
				case 316:
					array3[15] = (byte)num8;
					num7 = 305;
					goto IL_189c;
				case 339:
					array2[13] = (byte)num6;
					num = 35;
					break;
				case 352:
					array3[3] = 114;
					num = 273;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2e42: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 333;
				case 333:
					array2[21] = 90;
					num = 50;
					break;
				case 351:
					num6 = 1 + 3;
					num = 125;
					if (0 == 0)
					{
						break;
					}
					goto case 113;
				case 113:
					array3[12] = 101;
					num = 264;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2eab: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 59;
				case 59:
					array3[4] = 91;
					num2 = 161;
					continue;
				case 4:
					array3[2] = 115;
					num2 = 26;
					continue;
				case 203:
					array3[3] = 158;
					num = 21;
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_2f11: Stack underflow*/ != 0)
					{
						break;
					}
					goto case 266;
				case 364:
					try
					{
						byte[] array = new byte[num3];
						_ = 0;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						int num5;
						if ((int)/*Error near IL_2f2a: Stack underflow*/ != 0)
						{
							int num4 = 2;
							num5 = num4;
						}
						else
						{
							num5 = 3;
						}
						switch (num5)
						{
						case 0:
						case 2:
							Array.Copy(VlvvMf0S2, _0020 + 4, array, 0, num3);
							break;
						}
						_ = Encoding.Unicode;
						IntPtr intPtr = (nint)array.LongLength;
						((Encoding)/*Error near IL_2fb7: Stack underflow*/).GetString(array, 0, (int)(nint)intPtr);
						return (string)/*Error near IL_2fbc: Stack underflow*/;
					}
					catch
					{
					}
					return "";
				case 168:
					new MemoryStream();
					memoryStream = (MemoryStream)/*Error near IL_0abd: Stack underflow*/;
					num2 = 347;
					continue;
				case 353:
					{
						coJxnYf0j();
						symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_13d0: Stack underflow*/;
						num2 = 72;
						continue;
					}
					IL_189c:
					num = num7;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static string pA2PN5iOW(int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_2222, IL_3692
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_1a66: Invalid comparison between Unknown and I4
		//IL_3107: Invalid comparison between Unknown and I4
		//IL_325c: Invalid comparison between Unknown and I4
		//IL_3273: Incompatible stack heights: 0 vs 2
		//IL_327d: Incompatible stack heights: 0 vs 2
		//IL_3287: Incompatible stack heights: 0 vs 2
		//IL_3291: Incompatible stack heights: 0 vs 1
		//IL_329b: Incompatible stack heights: 0 vs 1
		//IL_32a5: Incompatible stack heights: 0 vs 1
		//IL_32af: Incompatible stack heights: 0 vs 1
		//IL_32b9: Incompatible stack heights: 0 vs 1
		//IL_32c3: Incompatible stack heights: 0 vs 1
		//IL_32cd: Incompatible stack heights: 0 vs 1
		//IL_32d7: Incompatible stack heights: 0 vs 1
		//IL_32e1: Incompatible stack heights: 0 vs 1
		//IL_32eb: Incompatible stack heights: 0 vs 1
		//IL_32f5: Incompatible stack heights: 0 vs 1
		//IL_32ff: Incompatible stack heights: 0 vs 3
		//IL_3309: Incompatible stack heights: 0 vs 1
		//IL_3313: Incompatible stack heights: 0 vs 1
		//IL_331d: Incompatible stack heights: 0 vs 1
		//IL_3327: Incompatible stack heights: 0 vs 1
		//IL_3331: Incompatible stack heights: 0 vs 1
		//IL_333b: Incompatible stack heights: 0 vs 1
		//IL_3345: Incompatible stack heights: 0 vs 1
		//IL_334f: Incompatible stack heights: 0 vs 1
		//IL_3359: Incompatible stack heights: 0 vs 1
		//IL_3363: Incompatible stack heights: 0 vs 1
		//IL_336d: Incompatible stack heights: 0 vs 1
		//IL_3377: Incompatible stack heights: 0 vs 1
		//IL_3381: Incompatible stack heights: 0 vs 1
		//IL_338b: Incompatible stack heights: 0 vs 1
		//IL_3395: Incompatible stack heights: 0 vs 1
		//IL_339f: Incompatible stack heights: 0 vs 1
		//IL_33a9: Incompatible stack heights: 0 vs 1
		//IL_33b3: Incompatible stack heights: 0 vs 1
		//IL_33bd: Incompatible stack heights: 0 vs 1
		//IL_33c7: Incompatible stack heights: 0 vs 1
		//IL_33d1: Incompatible stack heights: 0 vs 1
		//IL_33db: Incompatible stack heights: 0 vs 1
		//IL_33e5: Incompatible stack heights: 0 vs 1
		//IL_33ef: Incompatible stack heights: 0 vs 1
		//IL_33f9: Incompatible stack heights: 0 vs 1
		//IL_3403: Incompatible stack heights: 0 vs 1
		//IL_3417: Incompatible stack heights: 0 vs 1
		//IL_3421: Incompatible stack heights: 0 vs 1
		//IL_342b: Incompatible stack heights: 0 vs 1
		//IL_3435: Incompatible stack heights: 0 vs 1
		//IL_343f: Incompatible stack heights: 0 vs 1
		//IL_3449: Incompatible stack heights: 0 vs 1
		//IL_3453: Incompatible stack heights: 0 vs 1
		//IL_345d: Incompatible stack heights: 0 vs 2
		//IL_3467: Incompatible stack heights: 0 vs 1
		//IL_3471: Incompatible stack heights: 0 vs 1
		//IL_347b: Incompatible stack heights: 0 vs 1
		//IL_3485: Incompatible stack heights: 0 vs 1
		//IL_348f: Incompatible stack heights: 0 vs 1
		//IL_3499: Incompatible stack heights: 0 vs 1
		//IL_34a3: Incompatible stack heights: 0 vs 1
		//IL_34ad: Incompatible stack heights: 0 vs 1
		//IL_34b7: Incompatible stack heights: 0 vs 1
		//IL_34d5: Incompatible stack heights: 0 vs 1
		//IL_34df: Incompatible stack heights: 0 vs 1
		//IL_34e9: Incompatible stack heights: 0 vs 2
		//IL_34f3: Incompatible stack heights: 0 vs 1
		//IL_34fd: Incompatible stack heights: 0 vs 1
		//IL_3507: Incompatible stack heights: 0 vs 2
		//IL_3511: Incompatible stack heights: 0 vs 2
		//IL_351b: Incompatible stack heights: 0 vs 1
		//IL_3525: Incompatible stack heights: 0 vs 1
		//IL_352f: Incompatible stack heights: 0 vs 1
		//IL_3539: Incompatible stack heights: 0 vs 1
		//IL_3543: Incompatible stack heights: 0 vs 1
		//IL_354d: Incompatible stack heights: 0 vs 1
		//IL_3557: Incompatible stack heights: 0 vs 1
		//IL_3561: Incompatible stack heights: 0 vs 1
		//IL_356b: Incompatible stack heights: 0 vs 1
		//IL_3575: Incompatible stack heights: 0 vs 2
		//IL_357f: Incompatible stack heights: 0 vs 1
		//IL_359d: Incompatible stack heights: 0 vs 1
		//IL_35a7: Incompatible stack heights: 0 vs 1
		//IL_35b1: Incompatible stack heights: 0 vs 1
		//IL_35bb: Incompatible stack heights: 0 vs 1
		//IL_35c5: Incompatible stack heights: 0 vs 1
		//IL_35cf: Incompatible stack heights: 0 vs 1
		//IL_35d9: Incompatible stack heights: 0 vs 1
		//IL_35e3: Incompatible stack heights: 0 vs 1
		//IL_35ed: Incompatible stack heights: 0 vs 1
		//IL_35f7: Incompatible stack heights: 0 vs 1
		//IL_360b: Incompatible stack heights: 0 vs 1
		//IL_3615: Incompatible stack heights: 0 vs 1
		//IL_361f: Incompatible stack heights: 0 vs 1
		//IL_3629: Incompatible stack heights: 0 vs 1
		//IL_3633: Incompatible stack heights: 0 vs 1
		//IL_363d: Incompatible stack heights: 0 vs 1
		//IL_3647: Incompatible stack heights: 0 vs 1
		//IL_3651: Incompatible stack heights: 0 vs 1
		//IL_365b: Incompatible stack heights: 0 vs 1
		//IL_3665: Incompatible stack heights: 0 vs 1
		//IL_366f: Incompatible stack heights: 0 vs 1
		//IL_3679: Incompatible stack heights: 0 vs 1
		//IL_368d: Incompatible stack heights: 0 vs 1
		_ = 0;
		S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if ((int)/*Error near IL_0012: Stack underflow*/ != 0)
		{
			num = 344;
			goto IL_222f;
		}
		int num2 = 315;
		if (1 == 0)
		{
			goto IL_093f;
		}
		goto IL_222b;
		IL_222f:
		int num6 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		IntPtr intPtr = default(IntPtr);
		byte[] array4 = default(byte[]);
		byte[] array3 = default(byte[]);
		string text = default(string);
		int num8 = default(int);
		byte[] array5 = default(byte[]);
		IntPtr intPtr2 = default(IntPtr);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array7 = default(byte[]);
		BinaryReader binaryReader = default(BinaryReader);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array6 = default(byte[]);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] rgbKey = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num5;
			switch (num)
			{
			case 292:
				break;
			case 14:
				num6 = 202 - 67;
				num2 = 224;
				if (false)
				{
					goto case 382;
				}
				goto IL_222b;
			case 382:
				_ = tHL1DWx2g;
				new IntPtr(T63mSHBDS + num3 + 4);
				Convert.ToUInt32(num4);
				mHGLdUNTh((IntPtr)/*Error near IL_3291: Stack underflow*/, (IntPtr)/*Error near IL_3291: Stack underflow*/, (byte[])/*Error near IL_3291: Stack underflow*/, (uint)/*Error near IL_3291: Stack underflow*/, out IMpthAR4r);
				num2 = 15;
				if (false)
				{
					goto case 320;
				}
				goto IL_222b;
			case 320:
				array[5] = (byte)num6;
				num5 = 8;
				goto IL_2227;
			case 167:
				array[30] = 132;
				num = 171;
				continue;
			case 34:
				array2[6] = 199;
				num2 = 311;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_00f4: Stack underflow*/ != 0)
				{
					goto case 249;
				}
				goto IL_222b;
			case 249:
				array2[10] = 85;
				num = 135;
				continue;
			case 111:
				array[2] = 98;
				num2 = 61;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_013b: Stack underflow*/ != 0)
				{
					goto case 353;
				}
				goto IL_222b;
			case 353:
				num6 = 202 - 109;
				num5 = 385;
				goto IL_2227;
			case 389:
				array[16] = (byte)num6;
				num5 = 314;
				goto IL_2227;
			case 391:
				array[7] = (byte)num6;
				num2 = 253;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_018d: Stack underflow*/ == 0)
				{
					goto case 91;
				}
				goto IL_222b;
			case 113:
				array2[9] = 204;
				num = 375;
				continue;
			case 363:
				array[3] = 78;
				num2 = 89;
				if (1 == 0)
				{
					goto case 55;
				}
				goto IL_222b;
			case 55:
				array[17] = 147;
				num5 = 123;
				goto IL_2227;
			case 80:
				num7 = 125 - 41;
				num5 = 289;
				goto IL_2227;
			case 5:
				array[22] = 235;
				num = 331;
				continue;
			case 12:
				array2[15] = (byte)num7;
				num2 = 218;
				if (false)
				{
					goto case 220;
				}
				goto IL_222b;
			case 220:
				array[30] = 193;
				num5 = 110;
				goto IL_2227;
			case 222:
				array2[8] = 59;
				num = 142;
				continue;
			case 179:
				array[19] = 100;
				num2 = 172;
				goto IL_222b;
			case 205:
				array[2] = (byte)num6;
				num2 = 292;
				if (false)
				{
					goto case 168;
				}
				goto IL_222b;
			case 168:
				intPtr.ToInt64();
				Fob8H2mQF = (long)/*Error near IL_02d3: Stack underflow*/;
				num5 = 259;
				goto IL_2227;
			case 271:
				array[18] = 106;
				num5 = 39;
				goto IL_2227;
			case 181:
				array4[15] = array3[7];
				num5 = 154;
				goto IL_2227;
			case 342:
				array[13] = (byte)num6;
				num2 = 346;
				if (false)
				{
					goto case 0;
				}
				goto IL_222b;
			case 0:
			case 344:
				if (IjdXlXDmQ.Length == 0)
				{
					num = 115;
					continue;
				}
				goto case 259;
			case 150:
				array[4] = (byte)num6;
				num2 = 93;
				goto IL_222b;
			case 67:
				num6 = 4 + 64;
				num2 = 236;
				goto IL_222b;
			case 251:
				array[10] = 105;
				num2 = 35;
				goto IL_222b;
			case 4:
				array4[3] = array3[1];
				num2 = 163;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_03b7: Stack underflow*/ != 0)
				{
					goto case 378;
				}
				goto IL_222b;
			case 39:
				array[18] = 67;
				num2 = 270;
				goto IL_222b;
			case 261:
				array[12] = 202;
				num2 = 252;
				goto IL_222b;
			case 238:
				array2[6] = (byte)num7;
				num = 284;
				continue;
			case 69:
				array[19] = (byte)num6;
				num5 = 179;
				goto IL_2227;
			case 188:
				num6 = 93 + 46;
				num5 = 112;
				goto IL_2227;
			case 208:
				array[24] = (byte)num6;
				num2 = 52;
				if (1 == 0)
				{
					goto case 61;
				}
				goto IL_222b;
			case 61:
				num6 = 131 - 43;
				num5 = 317;
				goto IL_2227;
			case 300:
				dqNSmdvLj = new string[IjdXlXDmQ.Length / 4 + 1];
				num = 94;
				continue;
			case 194:
				array2[3] = (byte)num7;
				num2 = 268;
				if (false)
				{
					goto case 385;
				}
				goto IL_222b;
			case 385:
				array[9] = (byte)num6;
				num2 = 251;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_04de: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 198;
			case 100:
				array[21] = (byte)num6;
				num = 5;
				continue;
			case 25:
				array2[10] = 106;
				num = 73;
				continue;
			case 233:
				array[28] = (byte)num6;
				num5 = 276;
				goto IL_2227;
			case 297:
				array2[7] = (byte)num7;
				num2 = 294;
				goto IL_222b;
			case 144:
				array[15] = 138;
				num = 223;
				continue;
			case 247:
				array2[11] = 182;
				num2 = 210;
				if (1 == 0)
				{
					goto case 368;
				}
				goto IL_222b;
			case 368:
				array2[12] = (byte)num7;
				num5 = 170;
				goto IL_2227;
			case 299:
				array2[4] = (byte)num7;
				num2 = 75;
				goto IL_222b;
			case 2:
				array[12] = (byte)num6;
				num2 = 198;
				goto IL_222b;
			case 371:
				num7 = 24 + 30;
				num5 = 250;
				goto IL_2227;
			case 367:
				((string[])dqNSmdvLj)[l7iaiNUGL] = text;
				num = 365;
				continue;
			case 211:
				array[1] = 29;
				num2 = 37;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_063e: Stack underflow*/ != 0)
				{
					goto case 101;
				}
				goto IL_222b;
			case 101:
				array2[4] = 91;
				num2 = 43;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0666: Stack underflow*/ == 0)
				{
					goto case 106;
				}
				goto IL_222b;
			case 186:
				num7 = 83 + 68;
				num = 194;
				continue;
			case 65:
				array2[14] = (byte)num7;
				num2 = 215;
				goto IL_222b;
			case 216:
				num6 = 205 - 68;
				num5 = 59;
				goto IL_2227;
			case 200:
				num6 = 156 + 54;
				num2 = 381;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_06db: Stack underflow*/ == 0)
				{
					goto case 37;
				}
				goto IL_222b;
			case 37:
				array[1] = 145;
				num2 = 237;
				if (false)
				{
					goto case 153;
				}
				goto IL_222b;
			case 153:
				array[7] = (byte)num6;
				num = 196;
				continue;
			case 1:
				array[6] = (byte)num6;
				num2 = 358;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0738: Stack underflow*/ != 0)
				{
					goto case 379;
				}
				goto IL_222b;
			case 379:
				array[29] = (byte)num6;
				num5 = 366;
				goto IL_2227;
			case 138:
				num6 = 52 + 100;
				num = 3;
				continue;
			case 77:
				array[7] = (byte)num6;
				num2 = 44;
				if (false)
				{
					goto case 17;
				}
				goto IL_222b;
			case 17:
				_ = 1;
				Process.GetCurrentProcess();
				_ = ((Process)/*Error near IL_3309: Stack underflow*/).Id;
				tbK7tExBr((uint)/*Error near IL_3313: Stack underflow*/, (int)/*Error near IL_3313: Stack underflow*/, (uint)/*Error near IL_3313: Stack underflow*/);
				tHL1DWx2g = (IntPtr)/*Error near IL_079d: Stack underflow*/;
				num2 = 377;
				goto IL_222b;
			case 305:
				xl2WARyP6[num8] = l7iaiNUGL;
				num = 367;
				continue;
			case 365:
				l7iaiNUGL++;
				num2 = 392;
				goto IL_222b;
			case 52:
				num6 = 125 - 41;
				num2 = 260;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_07fe: Stack underflow*/ != 0)
				{
					goto case 254;
				}
				goto IL_222b;
			case 105:
				num7 = 215 - 71;
				num2 = 235;
				if (1 == 0)
				{
					goto case 340;
				}
				goto IL_222b;
			case 340:
				num6 = 187 - 62;
				num = 60;
				continue;
			case 182:
				num6 = 199 - 66;
				num5 = 98;
				goto IL_2227;
			case 83:
				num7 = 99 - 10;
				num2 = 299;
				if (false)
				{
					goto case 283;
				}
				goto IL_222b;
			case 283:
				array2[2] = (byte)num7;
				num2 = 152;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0892: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 199;
			case 44:
				num6 = 7 + 23;
				num5 = 391;
				goto IL_2227;
			case 169:
				num6 = 79 - 77;
				num5 = 285;
				goto IL_2227;
			case 388:
				array[16] = (byte)num6;
				num = 216;
				continue;
			case 132:
				array[27] = (byte)num6;
				num2 = 182;
				goto IL_222b;
			case 18:
				array2[1] = (byte)num7;
				num5 = 105;
				goto IL_2227;
			case 294:
				array2[7] = 128;
				goto case 278;
			case 383:
				goto end_IL_222f;
			case 9:
				num6 = 32 + 120;
				num = 86;
				continue;
			case 312:
				array2[2] = 115;
				num5 = 68;
				goto IL_2227;
			case 210:
				array2[11] = 68;
				num2 = 371;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_09bb: Stack underflow*/ == 0)
				{
					goto case 123;
				}
				goto IL_222b;
			case 123:
				array[17] = 110;
				num2 = 121;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_09e3: Stack underflow*/ == 0)
				{
					goto case 324;
				}
				goto IL_222b;
			case 324:
				array4[7] = array3[3];
				num2 = 359;
				if (1 == 0)
				{
					goto case 374;
				}
				goto IL_222b;
			case 374:
				array[5] = 159;
				num2 = 38;
				if (1 == 0)
				{
					goto case 152;
				}
				goto IL_222b;
			case 152:
				array2[2] = 134;
				num5 = 312;
				goto IL_2227;
			case 254:
				array2[9] = (byte)num7;
				num5 = 95;
				goto IL_2227;
			case 22:
				array2[13] = 98;
				num5 = 304;
				goto IL_2227;
			case 346:
				num6 = 125 - 41;
				num2 = 333;
				goto IL_222b;
			case 114:
				num6 = 131 - 43;
				num = 45;
				continue;
			case 81:
				array[18] = (byte)num6;
				num2 = 271;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0aca: Stack underflow*/ == 0)
				{
					goto case 318;
				}
				goto IL_222b;
			case 236:
				array[0] = (byte)num6;
				num2 = 99;
				goto IL_222b;
			case 189:
				array2[1] = (byte)num7;
				num2 = 309;
				if (false)
				{
					goto case 245;
				}
				goto IL_222b;
			case 245:
				array[29] = (byte)num6;
				num5 = 313;
				goto IL_2227;
			case 126:
				num7 = 108 + 22;
				num5 = 273;
				goto IL_2227;
			case 151:
				array[6] = (byte)num6;
				num2 = 338;
				if (false)
				{
					goto case 268;
				}
				goto IL_222b;
			case 268:
				array2[3] = 158;
				num = 126;
				continue;
			case 171:
				num6 = 163 - 54;
				num5 = 355;
				goto IL_2227;
			case 366:
				array[29] = 74;
				num2 = 166;
				goto IL_222b;
			case 40:
				num6 = 1 + 3;
				num2 = 33;
				goto IL_222b;
			case 293:
				if (array3 != null)
				{
					num5 = 147;
					goto IL_2227;
				}
				goto case 154;
			case 125:
				num7 = 36 - 0;
				num = 160;
				continue;
			case 54:
				array2[14] = (byte)num7;
				num2 = 134;
				goto IL_222b;
			case 217:
				num7 = 29 + 95;
				num5 = 54;
				goto IL_2227;
			case 129:
				array2[1] = 52;
				num5 = 229;
				goto IL_2227;
			case 309:
				num7 = 7 + 105;
				num2 = 283;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0c6e: Stack underflow*/ == 0)
				{
					goto case 32;
				}
				goto IL_222b;
			case 32:
				array[22] = (byte)num6;
				num = 120;
				continue;
			case 269:
				num7 = 89 + 63;
				num2 = 16;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0ca8: Stack underflow*/ == 0)
				{
					goto case 270;
				}
				goto IL_222b;
			case 270:
				num6 = 119 + 90;
				num2 = 69;
				if (1 == 0)
				{
					goto case 304;
				}
				goto IL_222b;
			case 304:
				num7 = 186 - 62;
				num2 = 10;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0ce8: Stack underflow*/ != 0)
				{
					goto case 5;
				}
				goto IL_222b;
			case 272:
				num7 = 182 - 60;
				num = 368;
				continue;
			case 326:
				array2[10] = (byte)num7;
				num2 = 249;
				goto IL_222b;
			case 218:
				array4 = array2;
				num2 = 279;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0d3a: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 71;
			case 256:
				array[0] = (byte)num6;
				num = 156;
				continue;
			case 30:
				num7 = 97 + 67;
				num2 = 12;
				if (false)
				{
					goto case 163;
				}
				goto IL_222b;
			case 163:
				array4[5] = array3[2];
				num2 = 324;
				if (1 == 0)
				{
					goto case 213;
				}
				goto IL_222b;
			case 213:
				array[29] = (byte)num6;
				num5 = 6;
				goto IL_2227;
			case 276:
				array[28] = 91;
				num2 = 318;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0dcb: Stack underflow*/ == 0)
				{
					goto case 259;
				}
				goto IL_222b;
			case 259:
				num8 = _0020 / 4;
				num5 = 46;
				goto IL_2227;
			case 96:
				array2[9] = (byte)num7;
				num5 = 155;
				goto IL_2227;
			case 377:
				array5 = new byte[4];
				num5 = 286;
				goto IL_2227;
			case 43:
				array2[4] = 122;
				num5 = 83;
				goto IL_2227;
			case 51:
				array[3] = 234;
				num = 282;
				continue;
			case 75:
				array2[5] = 168;
				num2 = 330;
				goto IL_222b;
			case 230:
				num7 = 123 + 41;
				num5 = 329;
				goto IL_2227;
			case 334:
				array2[6] = (byte)num7;
				num5 = 34;
				goto IL_2227;
			case 328:
				array[10] = 91;
				num2 = 384;
				goto IL_222b;
			case 160:
				array2[8] = (byte)num7;
				num5 = 310;
				goto IL_2227;
			case 164:
				num6 = 50 + 17;
				num2 = 141;
				goto IL_222b;
			case 16:
				array2[11] = (byte)num7;
				num2 = 133;
				goto IL_222b;
			case 157:
				array2[9] = 104;
				num2 = 113;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0f32: Stack underflow*/ == 0)
				{
					goto IL_222b;
				}
				goto case 13;
			case 390:
				array[5] = 134;
				num5 = 374;
				goto IL_2227;
			case 243:
				array[4] = (byte)num6;
				num = 336;
				continue;
			case 106:
				array[25] = 160;
				num5 = 241;
				goto IL_2227;
			case 348:
				array2[0] = 123;
				num = 212;
				continue;
			case 74:
				array2[12] = 109;
				num5 = 272;
				goto IL_2227;
			case 49:
				array[2] = (byte)num6;
				num = 111;
				continue;
			case 95:
				num7 = 30 + 112;
				num5 = 246;
				goto IL_2227;
			case 214:
				array[13] = 149;
				num = 184;
				continue;
			case 102:
				array[18] = (byte)num6;
				num = 107;
				continue;
			case 124:
				array2[15] = 122;
				num5 = 360;
				goto IL_2227;
			case 183:
				array2[8] = (byte)num7;
				num = 117;
				continue;
			case 72:
				array[10] = (byte)num6;
				num5 = 328;
				goto IL_2227;
			case 56:
				intPtr2.ToInt32();
				T63mSHBDS = (int)/*Error near IL_108e: Stack underflow*/;
				num2 = 341;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_10a1: Stack underflow*/ == 0)
				{
					goto case 96;
				}
				goto IL_222b;
			case 280:
				array[21] = (byte)num6;
				num5 = 188;
				goto IL_2227;
			case 295:
				array2[12] = 101;
				num5 = 264;
				goto IL_2227;
			case 331:
				num6 = 131 - 43;
				num5 = 32;
				goto IL_2227;
			case 97:
				array[14] = 81;
				num2 = 144;
				goto IL_222b;
			case 29:
				array2[6] = 159;
				num2 = 376;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1141: Stack underflow*/ == 0)
				{
					goto case 179;
				}
				goto IL_222b;
			case 322:
				array2[7] = 213;
				num = 222;
				continue;
			case 355:
				array[30] = (byte)num6;
				num5 = 220;
				goto IL_2227;
			case 378:
				num6 = 97 + 62;
				num2 = 206;
				goto IL_222b;
			case 78:
				num6 = 223 - 74;
				num5 = 139;
				goto IL_2227;
			case 36:
				array2[11] = (byte)num7;
				num = 74;
				continue;
			case 28:
				num7 = 185 - 61;
				num = 238;
				continue;
			case 137:
				num6 = 140 - 103;
				num2 = 257;
				if (true)
				{
					goto IL_222b;
				}
				goto case 143;
			case 274:
				array[15] = 148;
				num5 = 361;
				goto IL_2227;
			case 339:
				array2[3] = 114;
				num = 186;
				continue;
			case 351:
				array[8] = (byte)num6;
				num5 = 50;
				goto IL_2227;
			case 329:
				array2[1] = (byte)num7;
				num = 228;
				continue;
			case 82:
			{
				LC4Fb3DwS8CZ3A2N5i lC4Fb3DwS8CZ3A2N5i = (LC4Fb3DwS8CZ3A2N5i)16;
				num5 = 17;
				goto IL_2227;
			}
			case 8:
				num6 = 111 + 59;
				num5 = 369;
				goto IL_2227;
			case 57:
				array[24] = 96;
				num2 = 308;
				if (1 == 0)
				{
					goto case 116;
				}
				goto IL_222b;
			case 116:
				num6 = 27 + 94;
				num2 = 150;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_12fe: Stack underflow*/ == 0)
				{
					goto case 65;
				}
				goto IL_222b;
			case 173:
				num6 = 35 + 123;
				num5 = 1;
				goto IL_2227;
			case 228:
				num7 = 84 + 88;
				num5 = 18;
				goto IL_2227;
			case 141:
				array[23] = (byte)num6;
				num2 = 201;
				if (1 == 0)
				{
					goto case 278;
				}
				goto IL_222b;
			case 278:
			case 315:
				array2[7] = 120;
				num2 = 322;
				goto IL_222b;
			case 263:
				num6 = 124 - 35;
				num2 = 100;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_13ad: Stack underflow*/ == 0)
				{
					goto case 233;
				}
				goto IL_222b;
			case 302:
				num7 = 60 + 117;
				num2 = 234;
				goto IL_222b;
			case 162:
				array[29] = (byte)num6;
				num2 = 70;
				if (false)
				{
					goto case 175;
				}
				goto IL_222b;
			case 175:
				array2[15] = (byte)num7;
				num2 = 30;
				goto IL_222b;
			case 73:
				num7 = 157 - 52;
				num5 = 337;
				goto IL_2227;
			case 185:
				num7 = 189 - 63;
				num2 = 383;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1443: Stack underflow*/ == 0)
				{
					goto case 4;
				}
				goto IL_222b;
			case 135:
				num7 = 41 + 1;
				num = 128;
				continue;
			case 306:
				array[6] = (byte)num6;
				num2 = 173;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1482: Stack underflow*/ == 0)
				{
					goto case 262;
				}
				goto IL_222b;
			case 262:
				array[3] = (byte)num6;
				num = 51;
				continue;
			case 87:
				array[30] = (byte)num6;
				num2 = 321;
				if (true)
				{
					goto IL_222b;
				}
				goto case 209;
			case 191:
				array[27] = (byte)num6;
				num5 = 178;
				goto IL_2227;
			case 136:
				num6 = 222 - 74;
				num = 225;
				continue;
			case 3:
				array[24] = (byte)num6;
				num5 = 57;
				goto IL_2227;
			case 284:
				array2[6] = 108;
				num = 29;
				continue;
			case 68:
				array2[2] = 104;
				num2 = 187;
				goto IL_222b;
			case 133:
				num7 = 115 + 112;
				num2 = 36;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1575: Stack underflow*/ != 0)
				{
					goto case 381;
				}
				goto IL_222b;
			case 381:
				array[20] = (byte)num6;
				num2 = 242;
				goto IL_222b;
			case 93:
				num6 = 135 + 47;
				num = 243;
				continue;
			case 250:
				array2[11] = (byte)num7;
				num2 = 269;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_15cb: Stack underflow*/ == 0)
				{
					goto case 282;
				}
				goto IL_222b;
			case 204:
				cryptoStream.Write(array7, 0, array7.Length);
				num2 = 288;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_15ef: Stack underflow*/ == 0)
				{
					goto case 101;
				}
				goto IL_222b;
			case 221:
				num6 = 167 - 55;
				num5 = 362;
				goto IL_2227;
			case 24:
				array4[1] = array3[0];
				num2 = 4;
				goto IL_222b;
			case 19:
				num6 = 217 - 72;
				num = 49;
				continue;
			case 282:
				num6 = 199 - 66;
				num2 = 119;
				if (false)
				{
					goto case 177;
				}
				goto IL_222b;
			case 177:
				array[31] = (byte)num6;
				num = 287;
				continue;
			case 197:
				array[26] = (byte)num6;
				num2 = 92;
				if (1 == 0)
				{
					goto case 281;
				}
				goto IL_222b;
			case 281:
				array2[7] = (byte)num7;
				num5 = 165;
				goto IL_2227;
			case 109:
				array[28] = 131;
				num5 = 345;
				goto IL_2227;
			case 359:
				array4[9] = array3[4];
				num2 = 58;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_16e0: Stack underflow*/ != 0)
				{
					goto case 377;
				}
				goto IL_222b;
			case 356:
				num7 = 154 - 51;
				num = 370;
				continue;
			case 229:
				num7 = 140 - 46;
				num5 = 275;
				goto IL_2227;
			case 321:
				num6 = 121 + 29;
				num = 177;
				continue;
			case 165:
				array2[7] = 174;
				num2 = 79;
				goto IL_222b;
			case 92:
				array[26] = 105;
				num5 = 137;
				goto IL_2227;
			case 98:
				array[28] = (byte)num6;
				num = 109;
				continue;
			case 369:
				array[5] = (byte)num6;
				num = 277;
				continue;
			case 42:
				num6 = 169 - 56;
				num = 388;
				continue;
			case 203:
				num6 = 88 + 63;
				num = 306;
				continue;
			case 115:
				_ = typeof(S7EI44sMaZQ92MiG6X);
				_ = ((Type)/*Error near IL_3435: Stack underflow*/).Assembly;
				((Assembly)/*Error near IL_343f: Stack underflow*/).GetManifestResourceStream("41c50755-5d2e-4d5b-8673-3f7674a849be");
				new BinaryReader((Stream)/*Error near IL_3449: Stack underflow*/);
				binaryReader = (BinaryReader)/*Error near IL_17f3: Stack underflow*/;
				num5 = 108;
				goto IL_2227;
			case 85:
				num6 = 109 + 124;
				num2 = 162;
				goto IL_222b;
			case 310:
				num7 = 174 - 58;
				num2 = 96;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_183c: Stack underflow*/ != 0)
				{
					goto case 223;
				}
				goto IL_222b;
			case 223:
				num6 = 36 + 110;
				num5 = 227;
				goto IL_2227;
			case 156:
				num6 = 199 - 66;
				num5 = 265;
				goto IL_2227;
			case 296:
			{
				_ = binaryReader.BaseStream;
				_ = ((Stream)/*Error near IL_3467: Stack underflow*/).Length;
				int count = (int)/*Error near IL_187b: Stack underflow*/;
				((BinaryReader)/*Error near IL_3471: Stack underflow*/).ReadBytes(count);
				array7 = (byte[])/*Error near IL_1881: Stack underflow*/;
				num2 = 176;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1894: Stack underflow*/ != 0)
				{
					goto case 99;
				}
				goto IL_222b;
			}
			case 99:
				num6 = 239 - 79;
				num = 192;
				continue;
			case 241:
				num6 = 14 + 91;
				num2 = 303;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_18cf: Stack underflow*/ != 0)
				{
					goto case 51;
				}
				goto IL_222b;
			case 6:
				array[29] = 204;
				num2 = 85;
				if (false)
				{
					goto case 64;
				}
				goto IL_222b;
			case 64:
				array2[12] = (byte)num7;
				num = 295;
				continue;
			case 380:
				array[25] = 96;
				num = 349;
				continue;
			case 170:
				num7 = 224 - 74;
				num2 = 64;
				goto IL_222b;
			case 70:
				num6 = 72 + 53;
				num = 379;
				continue;
			case 35:
				num6 = 116 + 47;
				num2 = 72;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1987: Stack underflow*/ != 0)
				{
					goto case 161;
				}
				goto IL_222b;
			case 161:
				num6 = 104 + 28;
				num5 = 262;
				goto IL_2227;
			case 253:
				num6 = 106 + 27;
				num5 = 153;
				goto IL_2227;
			case 119:
				array[4] = (byte)num6;
				num5 = 116;
				goto IL_2227;
			case 257:
				array[26] = (byte)num6;
				num5 = 352;
				goto IL_2227;
			case 66:
				array[28] = (byte)num6;
				num5 = 159;
				goto IL_2227;
			case 237:
				num6 = 226 + 12;
				num5 = 239;
				goto IL_2227;
			case 335:
				memoryStream.ToArray();
				IjdXlXDmQ = (byte[])/*Error near IL_1a26: Stack underflow*/;
				num5 = 325;
				goto IL_2227;
			case 239:
				array[1] = (byte)num6;
				num5 = 19;
				goto IL_2227;
			case 59:
				array[16] = (byte)num6;
				num = 378;
				continue;
			case 350:
				num7 = 198 + 19;
				num2 = 189;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1a97: Stack underflow*/ != 0)
				{
					goto case 387;
				}
				goto IL_222b;
			case 387:
				num6 = 49 + 86;
				num5 = 118;
				goto IL_2227;
			case 226:
				num6 = 105 + 64;
				num5 = 280;
				goto IL_2227;
			case 330:
				num7 = 8 + 57;
				num = 174;
				continue;
			case 117:
				array2[8] = 104;
				num5 = 76;
				goto IL_2227;
			case 231:
				num6 = 125 - 41;
				num5 = 53;
				goto IL_2227;
			case 155:
				num7 = 85 + 102;
				num = 254;
				continue;
			case 201:
				array[23] = 169;
				num = 221;
				continue;
			case 31:
				array[27] = 96;
				num2 = 26;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1b7a: Stack underflow*/ != 0)
				{
					goto case 276;
				}
				goto IL_222b;
			case 349:
				array[25] = 65;
				num5 = 267;
				goto IL_2227;
			case 91:
				memoryStream.Close();
				num = 202;
				continue;
			case 202:
				cryptoStream.Close();
				num2 = 7;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1bc9: Stack underflow*/ == 0)
				{
					goto case 343;
				}
				goto IL_222b;
			case 343:
				array[8] = (byte)num6;
				num5 = 41;
				goto IL_2227;
			case 94:
				xl2WARyP6 = new int[IjdXlXDmQ.Length / 4 + 1];
				num2 = 91;
				if (false)
				{
					goto case 38;
				}
				goto IL_222b;
			case 38:
				num6 = 88 + 0;
				num5 = 320;
				goto IL_2227;
			case 319:
				num6 = 236 - 78;
				num = 77;
				continue;
			case 121:
				array[17] = 115;
				num5 = 158;
				goto IL_2227;
			case 107:
				num6 = 170 - 56;
				num5 = 81;
				goto IL_2227;
			case 90:
				array[20] = 154;
				num5 = 136;
				goto IL_2227;
			case 358:
				num6 = 177 - 85;
				num5 = 151;
				goto IL_2227;
			case 277:
				array[6] = 156;
				num5 = 203;
				goto IL_2227;
			case 110:
				num6 = 106 - 64;
				num = 87;
				continue;
			case 242:
				array[21] = 90;
				num2 = 226;
				if (1 == 0)
				{
					goto case 314;
				}
				goto IL_222b;
			case 314:
				array[16] = 24;
				num2 = 55;
				goto IL_222b;
			case 41:
				num6 = 128 - 64;
				num2 = 351;
				goto IL_222b;
			case 46:
				if (xl2WARyP6[num8] > 0)
				{
					num5 = 354;
					goto IL_2227;
				}
				BitConverter.ToInt32(IjdXlXDmQ, _0020);
				num3 = (int)/*Error near IL_1ffa: Stack underflow*/;
				num2 = 63;
				goto IL_222b;
			case 248:
				array[12] = (byte)num6;
				num2 = 145;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1d7c: Stack underflow*/ != 0)
				{
					goto case 256;
				}
				goto IL_222b;
			case 15:
			case 27:
				yoD2eAjki(array5);
				array6 = (byte[])/*Error near IL_1dba: Stack underflow*/;
				num = 143;
				continue;
			case 291:
				array[13] = 248;
				num5 = 21;
				goto IL_2227;
			case 140:
				array[11] = 25;
				num2 = 71;
				if (1 == 0)
				{
					goto case 166;
				}
				goto IL_222b;
			case 166:
				array[30] = 168;
				num5 = 167;
				goto IL_2227;
			case 227:
				array[15] = (byte)num6;
				num = 274;
				continue;
			case 60:
				array[9] = (byte)num6;
				num = 307;
				continue;
			case 149:
				num6 = 104 - 3;
				num = 122;
				continue;
			case 79:
				num7 = 163 - 54;
				num = 297;
				continue;
			case 127:
				num6 = 99 + 79;
				num2 = 195;
				if (false)
				{
					goto case 362;
				}
				goto IL_222b;
			case 362:
				array[24] = (byte)num6;
				num5 = 138;
				goto IL_2227;
			case 112:
				array[21] = (byte)num6;
				num5 = 231;
				goto IL_2227;
			case 84:
				array[23] = (byte)num6;
				num = 164;
				continue;
			case 53:
				array[21] = (byte)num6;
				num2 = 78;
				if (false)
				{
					goto case 130;
				}
				goto IL_222b;
			case 130:
				num6 = 6 + 21;
				num5 = 205;
				goto IL_2227;
			case 63:
				_ = tHL1DWx2g == IntPtr.Zero;
				if ((int)/*Error near IL_1f71: Stack underflow*/ != 0)
				{
					num = 82;
					continue;
				}
				goto case 377;
			case 347:
				array2[10] = 27;
				num2 = 247;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1fa3: Stack underflow*/ == 0)
				{
					goto case 246;
				}
				goto IL_222b;
			case 246:
				array2[9] = (byte)num7;
				num = 157;
				continue;
			case 252:
				num6 = 51 + 107;
				num2 = 248;
				if (1 == 0)
				{
					goto case 354;
				}
				goto IL_222b;
			case 354:
				return ((string[])dqNSmdvLj)[xl2WARyP6[num8]];
			case 240:
				array2[0] = 24;
				num2 = 230;
				if (1 == 0)
				{
					goto case 327;
				}
				goto IL_222b;
			case 327:
				array[3] = (byte)num6;
				num5 = 363;
				goto IL_2227;
			case 48:
				array[11] = (byte)num6;
				num2 = 298;
				if (1 == 0)
				{
					goto case 375;
				}
				goto IL_222b;
			case 375:
				num7 = 199 - 66;
				num2 = 326;
				goto IL_222b;
			case 215:
				array2[14] = 157;
				num = 124;
				continue;
			case 313:
				num6 = 17 + 119;
				num5 = 213;
				goto IL_2227;
			case 195:
				array[24] = (byte)num6;
				num2 = 106;
				goto IL_222b;
			case 333:
				array[13] = (byte)num6;
				num = 291;
				continue;
			case 357:
				num6 = 221 - 73;
				num2 = 256;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_210c: Stack underflow*/ == 0)
				{
					goto case 376;
				}
				goto IL_222b;
			case 376:
				num7 = 82 + 1;
				num2 = 334;
				goto IL_222b;
			case 192:
				array[0] = (byte)num6;
				num2 = 9;
				goto IL_222b;
			case 86:
				array[0] = (byte)num6;
				num2 = 357;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2166: Stack underflow*/ != 0)
				{
					goto case 308;
				}
				goto IL_222b;
			case 308:
				num6 = 90 + 34;
				num2 = 208;
				if (1 == 0)
				{
					goto case 258;
				}
				goto IL_222b;
			case 258:
				num6 = 17 + 105;
				num5 = 2;
				goto IL_2227;
			case 118:
				array[2] = (byte)num6;
				num = 146;
				continue;
			case 23:
				num6 = 221 - 73;
				num5 = 84;
				goto IL_2227;
			case 298:
				array[11] = 176;
				num2 = 258;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_21f6: Stack underflow*/ != 0)
				{
					goto case 303;
				}
				goto IL_222b;
			case 303:
				array[25] = (byte)num6;
				num = 380;
				continue;
			case 318:
				num6 = 40 + 114;
				goto case 66;
			default:
				num = 66;
				continue;
			case 338:
				array[7] = 22;
				num2 = 319;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 373;
			case 373:
				num6 = 215 - 71;
				num2 = 342;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 10;
			case 10:
				array2[13] = (byte)num7;
				num = 332;
				continue;
			case 45:
				array[11] = (byte)num6;
				num2 = 140;
				goto IL_222b;
			case 76:
				array2[8] = 123;
				num2 = 80;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 224;
			case 224:
				array[23] = (byte)num6;
				num = 23;
				continue;
			case 139:
				array[21] = (byte)num6;
				num2 = 263;
				goto IL_222b;
			case 71:
				num6 = 218 - 72;
				num = 48;
				continue;
			case 212:
				num7 = 209 - 69;
				num5 = 199;
				goto IL_2227;
			case 275:
				array2[1] = (byte)num7;
				num2 = 350;
				goto IL_222b;
			case 58:
				array4[11] = array3[5];
				num2 = 219;
				goto IL_222b;
			case 361:
				num6 = 57 - 32;
				num2 = 207;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 307;
			case 307:
				array[9] = 177;
				num2 = 353;
				goto IL_222b;
			case 232:
				array5 = new byte[num4];
				num5 = 11;
				goto IL_2227;
			case 62:
			case 372:
				BitConverter.ToInt32(array5, 0);
				num4 = (int)/*Error near IL_29f2: Stack underflow*/;
				num5 = 232;
				goto IL_2227;
			case 235:
				array2[1] = (byte)num7;
				num5 = 129;
				goto IL_2227;
			case 33:
				array[31] = (byte)num6;
				num = 149;
				continue;
			case 21:
				array[14] = 80;
				num = 290;
				continue;
			case 332:
				array2[13] = 136;
				num5 = 104;
				goto IL_2227;
			case 180:
				symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
				transform = (ICryptoTransform)/*Error near IL_2a75: Stack underflow*/;
				num2 = 209;
				goto IL_222b;
			case 285:
				array[0] = (byte)num6;
				num2 = 211;
				goto IL_222b;
			case 120:
				num6 = 24 - 7;
				num2 = 301;
				goto IL_222b;
			case 266:
				array2[14] = 75;
				num = 217;
				continue;
			case 172:
				array[19] = 254;
				num5 = 90;
				goto IL_2227;
			case 337:
				array2[10] = (byte)num7;
				num5 = 347;
				goto IL_2227;
			case 364:
				_ = tHL1DWx2g;
				new IntPtr(T63mSHBDS + num3);
				mHGLdUNTh((IntPtr)/*Error near IL_357f: Stack underflow*/, (IntPtr)/*Error near IL_357f: Stack underflow*/, array5, 4u, out IMpthAR4r);
				num5 = 62;
				goto IL_2227;
			case 196:
				array[8] = 147;
				num5 = 193;
				goto IL_2227;
			case 288:
				cryptoStream.FlushFinalBlock();
				num = 335;
				continue;
			case 187:
				array2[2] = 228;
				num5 = 88;
				goto IL_2227;
			case 193:
				num6 = 98 + 68;
				num = 343;
				continue;
			case 7:
				binaryReader.Close();
				num2 = 244;
				goto IL_222b;
			case 184:
				array[13] = 98;
				num5 = 20;
				goto IL_2227;
			case 325:
				if (IjdXlXDmQ.Length > 0)
				{
					num = 300;
					continue;
				}
				goto case 91;
			case 352:
				num6 = 199 - 66;
				num = 191;
				continue;
			case 122:
				array[31] = (byte)num6;
				num = 190;
				continue;
			case 234:
				array2[0] = (byte)num7;
				num5 = 348;
				goto IL_2227;
			case 148:
				num7 = 52 + 120;
				num2 = 65;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2c59: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 207;
			case 207:
				array[15] = (byte)num6;
				num2 = 42;
				goto IL_222b;
			case 317:
				array[2] = (byte)num6;
				num2 = 130;
				if (true)
				{
					goto IL_222b;
				}
				goto case 176;
			case 176:
				array = new byte[32];
				num2 = 67;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 301;
			case 301:
				array[22] = (byte)num6;
				num2 = 14;
				goto IL_222b;
			case 219:
				array4[13] = array3[6];
				num2 = 181;
				goto IL_222b;
			case 47:
				array2[5] = 19;
				num5 = 356;
				goto IL_2227;
			case 336:
				array[5] = 119;
				num2 = 390;
				if (true)
				{
					goto IL_222b;
				}
				goto case 273;
			case 273:
				array2[4] = (byte)num7;
				num2 = 101;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2d45: Stack underflow*/ != 0)
				{
					goto case 90;
				}
				goto IL_222b;
			case 260:
				array[24] = (byte)num6;
				num = 127;
				continue;
			case 323:
				num6 = 127 - 42;
				num2 = 389;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2d84: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 142;
			case 142:
				num7 = 193 - 64;
				num = 183;
				continue;
			case 255:
				array2 = new byte[16];
				num = 302;
				continue;
			case 50:
				array[9] = 149;
				num5 = 340;
				goto IL_2227;
			case 199:
				array2[0] = (byte)num7;
				num2 = 185;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2df5: Stack underflow*/ == 0)
				{
					goto IL_222b;
				}
				goto case 134;
			case 134:
				array2[14] = 157;
				num2 = 148;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2e1d: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 290;
			case 290:
				array[14] = 144;
				num2 = 97;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 147;
			case 147:
				if (array3.Length <= 0)
				{
					goto case 154;
				}
				num = 24;
				continue;
			case 206:
				array[16] = (byte)num6;
				num2 = 323;
				if (true)
				{
					goto IL_222b;
				}
				goto case 89;
			case 89:
				array[3] = 102;
				num2 = 161;
				goto IL_222b;
			case 88:
				array2[3] = 158;
				num = 339;
				continue;
			case 386:
				num6 = 65 + 36;
				num5 = 197;
				goto IL_2227;
			case 198:
				array[12] = 147;
				num = 261;
				continue;
			case 265:
				array[0] = (byte)num6;
				num5 = 169;
				goto IL_2227;
			case 159:
				num6 = 163 - 54;
				num5 = 245;
				goto IL_2227;
			case 370:
				array2[6] = (byte)num7;
				num2 = 28;
				if (true)
				{
					goto IL_222b;
				}
				goto case 311;
			case 311:
				num7 = 24 + 120;
				num2 = 281;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2f5c: Stack underflow*/ != 0)
				{
					goto case 28;
				}
				goto IL_222b;
			case 128:
				array2[10] = (byte)num7;
				num5 = 25;
				goto IL_2227;
			case 264:
				array2[12] = 18;
				num = 22;
				continue;
			case 20:
				array[13] = 159;
				num5 = 373;
				goto IL_2227;
			case 289:
				array2[8] = (byte)num7;
				num2 = 125;
				S7EI44sMaZQ92MiG6X._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2fd8: Stack underflow*/ == 0)
				{
					goto IL_222b;
				}
				goto case 103;
			case 103:
				new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream = (CryptoStream)/*Error near IL_2fe4: Stack underflow*/;
				num2 = 204;
				if (true)
				{
					goto IL_222b;
				}
				goto case 26;
			case 26:
				num6 = 84 + 99;
				num5 = 132;
				goto IL_2227;
			case 244:
				_ = typeof(S7EI44sMaZQ92MiG6X);
				_ = ((Type)/*Error near IL_35f7: Stack underflow*/).Assembly;
				assembly = (Assembly)/*Error near IL_301d: Stack underflow*/;
				num5 = 131;
				goto IL_2227;
			case 13:
				symmetricAlgorithm.Mode = CipherMode.CBC;
				num5 = 180;
				goto IL_2227;
			case 316:
				assembly.GetModules();
				Marshal.GetHINSTANCE((Module)((object[])/*Error near IL_3042: Stack underflow*/)[0]);
				intPtr2 = (IntPtr)/*Error near IL_3049: Stack underflow*/;
				num5 = 56;
				goto IL_2227;
			case 225:
				array[20] = (byte)num6;
				num5 = 200;
				goto IL_2227;
			case 279:
				_ = typeof(S7EI44sMaZQ92MiG6X);
				_ = ((Type)/*Error near IL_3629: Stack underflow*/).Assembly;
				((Assembly)/*Error near IL_3633: Stack underflow*/).GetName();
				((AssemblyName)/*Error near IL_363d: Stack underflow*/).GetPublicKeyToken();
				array3 = (byte[])/*Error near IL_3086: Stack underflow*/;
				num2 = 293;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_3099: Stack underflow*/ == 0)
				{
					goto case 53;
				}
				goto IL_222b;
			case 345:
				num6 = 20 + 74;
				num2 = 233;
				S7EI44sMaZQ92MiG6X._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_30c0: Stack underflow*/ != 0)
				{
					goto IL_222b;
				}
				goto case 158;
			case 158:
				num6 = 99 + 24;
				num2 = 102;
				goto IL_222b;
			case 104:
				array2[13] = 60;
				num2 = 266;
				if (true)
				{
					goto IL_222b;
				}
				goto case 131;
			case 174:
				array2[5] = (byte)num7;
				num2 = 47;
				if (true)
				{
					goto IL_222b;
				}
				goto case 146;
			case 146:
				num6 = 204 - 68;
				num = 327;
				continue;
			case 360:
				num7 = 138 - 46;
				num = 175;
				continue;
			case 145:
				array[12] = 214;
				num = 214;
				continue;
			case 190:
				rgbKey = array;
				num2 = 255;
				if (0 == 0)
				{
					goto IL_222b;
				}
				goto case 341;
			case 341:
				assembly.GetModules();
				Marshal.GetHINSTANCE((Module)((object[])/*Error near IL_31a6: Stack underflow*/)[0]);
				intPtr = (IntPtr)/*Error near IL_31ad: Stack underflow*/;
				num = 168;
				continue;
			case 384:
				array[10] = 50;
				num2 = 114;
				goto IL_222b;
			case 287:
				array[31] = 117;
				num2 = 40;
				goto IL_222b;
			case 178:
				array[27] = 110;
				num5 = 31;
				goto IL_2227;
			case 267:
				array[26] = 116;
				num = 386;
				continue;
			case 108:
				_ = binaryReader.BaseStream;
				((Stream)/*Error near IL_3683: Stack underflow*/).Position = 0L;
				num2 = 296;
				goto IL_222b;
			case 392:
				return text;
			case 143:
			{
				_ = Encoding.Unicode;
				byte[] bytes = array6;
				IntPtr intPtr3 = (nint)array6.LongLength;
				((Encoding)/*Error near IL_33b3: Stack underflow*/).GetString(bytes, 0, (int)(nint)intPtr3);
				text = (string)/*Error near IL_1215: Stack underflow*/;
				num2 = 305;
				goto IL_222b;
			}
			case 154:
				coJxnYf0j();
				symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_130a: Stack underflow*/;
				num2 = 13;
				if (1 == 0)
				{
					goto case 173;
				}
				goto IL_222b;
			case 209:
				new MemoryStream();
				memoryStream = (MemoryStream)/*Error near IL_14be: Stack underflow*/;
				num = 103;
				continue;
			case 11:
				_ = IntPtr.Size;
				if ((int)/*Error near IL_1a6b: Stack underflow*/ == 4)
				{
					num = 382;
					continue;
				}
				_ = tHL1DWx2g;
				new IntPtr(Fob8H2mQF + num3 + 4);
				Convert.ToUInt32(num4);
				mHGLdUNTh((IntPtr)/*Error near IL_351b: Stack underflow*/, (IntPtr)/*Error near IL_351b: Stack underflow*/, (byte[])/*Error near IL_351b: Stack underflow*/, (uint)/*Error near IL_351b: Stack underflow*/, out IMpthAR4r);
				num5 = 27;
				goto IL_2227;
			case 131:
				_ = IntPtr.Size;
				if ((int)/*Error near IL_310c: Stack underflow*/ == 4)
				{
					num2 = 316;
					if (true)
					{
						goto IL_222b;
					}
					goto case 174;
				}
				goto case 341;
			case 286:
				goto IL_3688;
				IL_2227:
				num2 = num5;
				goto IL_222b;
			}
			array[2] = 86;
			num2 = 387;
			goto IL_222b;
			IL_3688:
			_ = IntPtr.Size;
			if ((int)/*Error near IL_3261: Stack underflow*/ != 4)
			{
				_ = tHL1DWx2g;
				new IntPtr(Fob8H2mQF + num3);
				mHGLdUNTh((IntPtr)/*Error near IL_34f3: Stack underflow*/, (IntPtr)/*Error near IL_34f3: Stack underflow*/, array5, 4u, out IMpthAR4r);
				num = 372;
			}
			else
			{
				num = 364;
			}
			continue;
			end_IL_222f:
			break;
		}
		goto IL_093f;
		IL_093f:
		array2[0] = (byte)num7;
		num2 = 240;
		goto IL_222b;
		IL_222b:
		num = num2;
		goto IL_222f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string qWH0PNh5J(string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(_0020);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	private static extern int PBnNYQgtA(IntPtr _0020, int _0020, int _0020, ref int _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QtPdCl3GL(object _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			if (File.Exists(((Assembly)_0020).Location))
			{
				return ((Assembly)_0020).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)_0020).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((Assembly)_0020).GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(_0020.GetType().GetProperty("Location")!.GetValue(_0020, new object[0])!.ToString()))
			{
				return _0020.GetType().GetProperty("Location")!.GetValue(_0020, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
	private static extern int cdD3YJXtR(IntPtr _0020, IntPtr _0020, [In][Out] byte[] _0020, uint _0020, out IntPtr _0020);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
	private static extern int mHGLdUNTh(IntPtr _0020, IntPtr _0020, [In][Out] byte[] _0020, uint _0020, out IntPtr _0020);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	private static extern IntPtr tbK7tExBr(uint _0020, int _0020, uint _0020);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
	private static extern int j2fK6h026(IntPtr _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] jo86RDUMn(string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		using FileStream fileStream = new FileStream(_0020, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] yoD2eAjki(byte[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = coJxnYf0j();
		symmetricAlgorithm.Key = new byte[32]
		{
			123, 197, 197, 188, 120, 51, 114, 25, 4, 70,
			137, 233, 101, 126, 129, 110, 49, 158, 185, 17,
			239, 27, 67, 188, 96, 92, 176, 64, 231, 169,
			203, 152
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			124, 74, 173, 197, 32, 218, 239, 82, 90, 191,
			72, 96, 14, 248, 49, 91
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(_0020, 0, _0020.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] FBww4fAcf()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] HITg3jvH7()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] FRsuWXqv4()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] EvbMCpIZv()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] SdMrmY9lG()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] Rp5lUdHDs()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] D8iBi3tMl()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] iXI9GF9Vd()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] vvNF0V2Jr()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] riZpDw1jO()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] C81chLflP()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-60001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] I3uiQyQeq()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		string text = "{11111-22222-60001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string aiCyYVZDy(string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		byte[] bytes = Encoding.Unicode.GetBytes(_0020);
		byte[] array = bytes;
		byte[] key = new byte[32]
		{
			82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
			51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
			34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
			1, 88
		};
		byte[] iV = RZbGNHXuK(Encoding.Unicode.GetBytes(_0020));
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = coJxnYf0j();
		symmetricAlgorithm.Key = key;
		symmetricAlgorithm.IV = iV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public S7EI44sMaZQ92MiG6X()
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
