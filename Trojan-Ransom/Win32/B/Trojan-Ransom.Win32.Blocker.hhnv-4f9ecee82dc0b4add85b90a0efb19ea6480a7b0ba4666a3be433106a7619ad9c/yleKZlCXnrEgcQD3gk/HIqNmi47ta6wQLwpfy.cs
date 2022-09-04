using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using tSpU5jqaYuU8S9xNcS;

namespace yleKZlCXnrEgcQD3gk;

internal class HIqNmi47ta6wQLwpfy
{
	internal class nTiUWRPw4mCFqxfA7R : Attribute
	{
		internal class dbYnXxZRxVvAxO5NqK<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public dbYnXxZRxVvAxO5NqK()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
			{
				return true;
			}

			static dbYnXxZRxVvAxO5NqK()
			{
				HIqNmi47ta6wQLwpfy.Rb22303oj();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[nTiUWRPw4mCFqxfA7R(typeof(HIqNmi47ta6wQLwpfy_002FnTiUWRPw4mCFqxfA7R_002FdbYnXxZRxVvAxO5NqK<object>[]))]
		public nTiUWRPw4mCFqxfA7R(object _0020)
		{
		}

		static nTiUWRPw4mCFqxfA7R()
		{
			HIqNmi47ta6wQLwpfy.Rb22303oj();
		}
	}

	[Flags]
	private enum YZf0tMn4q0DHWm43r6
	{

	}

	private static uint[] dbqFdh7j4;

	private static byte[] aeC03Eb7s;

	private static byte[] MT8Leg6Ro;

	private static IntPtr tFDCLZFvx;

	private static long CDIZqyEvo;

	private static int BLDWEDXP2;

	private static int[] VlaTGryG3;

	private static bool Jq4Yrpl2e;

	private static int ThNKReJoW;

	private static bool zv0STI5Ve;

	private static IntPtr afKiyxWuM;

	private static byte[] o83QQP95G;

	private static byte[] QM3sts0yC;

	private static bool rCRXZVLjZ;

	private static object IkNnwayHq;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HIqNmi47ta6wQLwpfy()
	{
		dbqFdh7j4 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		Jq4Yrpl2e = false;
		zv0STI5Ve = false;
		o83QQP95G = new byte[0];
		aeC03Eb7s = new byte[0];
		QM3sts0yC = new byte[0];
		MT8Leg6Ro = new byte[0];
		tFDCLZFvx = IntPtr.Zero;
		afKiyxWuM = IntPtr.Zero;
		IkNnwayHq = new string[0];
		VlaTGryG3 = new int[0];
		ThNKReJoW = 1;
		CDIZqyEvo = 0L;
		BLDWEDXP2 = 0;
		rCRXZVLjZ = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void leHifFIJCLsZtKEFfM1i()
	{
	}//Discarded unreachable code: IL_0005
	//IL_0006: Incompatible stack heights: 0 vs 1


	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] appB82xQc(byte[] _0020)
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
			XnUVLknbS(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			XnUVLknbS(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			XnUVLknbS(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			XnUVLknbS(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			XnUVLknbS(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			XnUVLknbS(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			XnUVLknbS(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			XnUVLknbS(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			XnUVLknbS(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			XnUVLknbS(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			XnUVLknbS(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			XnUVLknbS(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			XnUVLknbS(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			XnUVLknbS(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			XnUVLknbS(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			XnUVLknbS(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			xaQrAT9aB(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			xaQrAT9aB(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			xaQrAT9aB(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			xaQrAT9aB(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			xaQrAT9aB(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			xaQrAT9aB(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			xaQrAT9aB(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			xaQrAT9aB(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			xaQrAT9aB(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			xaQrAT9aB(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			xaQrAT9aB(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			xaQrAT9aB(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			xaQrAT9aB(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			xaQrAT9aB(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			xaQrAT9aB(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			xaQrAT9aB(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			AID1x1YtW(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			AID1x1YtW(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			AID1x1YtW(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			AID1x1YtW(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			AID1x1YtW(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			AID1x1YtW(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			AID1x1YtW(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			AID1x1YtW(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			AID1x1YtW(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			AID1x1YtW(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			AID1x1YtW(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			AID1x1YtW(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			AID1x1YtW(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			AID1x1YtW(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			AID1x1YtW(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			AID1x1YtW(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			vwsjhNaQT(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			vwsjhNaQT(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			vwsjhNaQT(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			vwsjhNaQT(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			vwsjhNaQT(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			vwsjhNaQT(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			vwsjhNaQT(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			vwsjhNaQT(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			vwsjhNaQT(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			vwsjhNaQT(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			vwsjhNaQT(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			vwsjhNaQT(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			vwsjhNaQT(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			vwsjhNaQT(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			vwsjhNaQT(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			vwsjhNaQT(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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
	private static void XnUVLknbS(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += MBstO7bDm(_0020 + ((_0020 & _0020) | (~_0020 & _0020)) + _0020[_0020] + dbqFdh7j4[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void xaQrAT9aB(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += MBstO7bDm(_0020 + ((_0020 & _0020) | (_0020 & ~_0020)) + _0020[_0020] + dbqFdh7j4[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AID1x1YtW(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += MBstO7bDm(_0020 + (_0020 ^ _0020 ^ _0020) + _0020[_0020] + dbqFdh7j4[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void vwsjhNaQT(ref uint _0020, uint _0020, uint _0020, uint _0020, uint _0020, ushort _0020, uint _0020, uint[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0020 += MBstO7bDm(_0020 + (_0020 ^ (_0020 | ~_0020)) + _0020[_0020] + dbqFdh7j4[_0020 - 1], _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint MBstO7bDm(uint _0020, ushort _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return (_0020 >> 32 - _0020) | (_0020 << (int)_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WjhI8PFMM()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!Jq4Yrpl2e)
		{
			XXkxEwhRB();
			Jq4Yrpl2e = true;
		}
		return zv0STI5Ve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XXkxEwhRB()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			zv0STI5Ve = (bool)Type.GetTypeFromHandle(gX6byysyFa8Nv80gC9.e53w34m968awCm9P85taUZe(16777290)).Assembly.GetType("System.Security.Cryptography.CryptoConfig", throwOnError: false)!.GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[0]);
		}
		catch
		{
			try
			{
				int num = (int)Type.GetTypeFromHandle(gX6byysyFa8Nv80gC9.e53w34m968awCm9P85taUZe(16777290)).Assembly.GetType("System.Security.Cryptography.Utils", throwOnError: false)!.GetMethod("get_FipsAlgorithmPolicy", BindingFlags.Static | BindingFlags.NonPublic)!.Invoke(null, new object[0]);
				if (num == 1)
				{
					zv0STI5Ve = true;
				}
			}
			catch
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm udTunHYcv()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (WjhI8PFMM())
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance(Assembly.Load("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089").GetType("System.Security.Cryptography.AesCryptoServiceProvider"));
			}
			catch
			{
				return new RijndaelManaged();
			}
		}
		return new RijndaelManaged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] j36vuGIob(byte[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		if (!WjhI8PFMM())
		{
			return new MD5CryptoServiceProvider().ComputeHash(_0020);
		}
		return appB82xQc(_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static bool v9koUX6Y0(int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0a6b, IL_2f24, IL_301b, IL_305b, IL_33ef
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_2fb3: Incompatible stack heights: 0 vs 1
		//IL_2fbd: Incompatible stack heights: 0 vs 1
		//IL_2fc7: Incompatible stack heights: 0 vs 1
		//IL_2fd1: Incompatible stack heights: 0 vs 1
		//IL_3065: Incompatible stack heights: 0 vs 1
		//IL_306f: Incompatible stack heights: 0 vs 1
		//IL_3079: Incompatible stack heights: 0 vs 1
		//IL_3098: Incompatible stack heights: 0 vs 1
		//IL_30a2: Incompatible stack heights: 0 vs 1
		//IL_30ac: Incompatible stack heights: 0 vs 1
		//IL_30b6: Incompatible stack heights: 0 vs 1
		//IL_30c0: Incompatible stack heights: 0 vs 1
		//IL_30d4: Incompatible stack heights: 0 vs 1
		//IL_30de: Incompatible stack heights: 0 vs 1
		//IL_30f2: Incompatible stack heights: 0 vs 2
		//IL_30fc: Incompatible stack heights: 0 vs 1
		//IL_3110: Incompatible stack heights: 0 vs 1
		//IL_311a: Incompatible stack heights: 0 vs 1
		//IL_3124: Incompatible stack heights: 0 vs 1
		//IL_312e: Incompatible stack heights: 0 vs 1
		//IL_3138: Incompatible stack heights: 0 vs 1
		//IL_3142: Incompatible stack heights: 0 vs 1
		//IL_314c: Incompatible stack heights: 0 vs 1
		//IL_3156: Incompatible stack heights: 0 vs 1
		//IL_3160: Incompatible stack heights: 0 vs 1
		//IL_316a: Incompatible stack heights: 0 vs 1
		//IL_3174: Incompatible stack heights: 0 vs 1
		//IL_317e: Incompatible stack heights: 0 vs 1
		//IL_3188: Incompatible stack heights: 0 vs 1
		//IL_3192: Incompatible stack heights: 0 vs 1
		//IL_319c: Incompatible stack heights: 0 vs 1
		//IL_31a6: Incompatible stack heights: 0 vs 1
		//IL_31b0: Incompatible stack heights: 0 vs 1
		//IL_31ba: Incompatible stack heights: 0 vs 1
		//IL_31c4: Incompatible stack heights: 0 vs 1
		//IL_31d8: Incompatible stack heights: 0 vs 1
		//IL_31e2: Incompatible stack heights: 0 vs 1
		//IL_31ec: Incompatible stack heights: 0 vs 1
		//IL_31f6: Incompatible stack heights: 0 vs 1
		//IL_3200: Incompatible stack heights: 0 vs 1
		//IL_320a: Incompatible stack heights: 0 vs 1
		//IL_3214: Incompatible stack heights: 0 vs 1
		//IL_321e: Incompatible stack heights: 0 vs 1
		//IL_3228: Incompatible stack heights: 0 vs 1
		//IL_3232: Incompatible stack heights: 0 vs 1
		//IL_323c: Incompatible stack heights: 0 vs 1
		//IL_3246: Incompatible stack heights: 0 vs 1
		//IL_3250: Incompatible stack heights: 0 vs 1
		//IL_3264: Incompatible stack heights: 0 vs 1
		//IL_3278: Incompatible stack heights: 0 vs 1
		//IL_3282: Incompatible stack heights: 0 vs 1
		//IL_328c: Incompatible stack heights: 0 vs 1
		//IL_3296: Incompatible stack heights: 0 vs 1
		//IL_32a0: Incompatible stack heights: 0 vs 1
		//IL_32aa: Incompatible stack heights: 0 vs 1
		//IL_32b4: Incompatible stack heights: 0 vs 1
		//IL_32be: Incompatible stack heights: 0 vs 1
		//IL_32c8: Incompatible stack heights: 0 vs 1
		//IL_32d2: Incompatible stack heights: 0 vs 1
		//IL_32dc: Incompatible stack heights: 0 vs 1
		//IL_32e6: Incompatible stack heights: 0 vs 1
		//IL_32f0: Incompatible stack heights: 0 vs 1
		//IL_32fa: Incompatible stack heights: 0 vs 1
		//IL_3304: Incompatible stack heights: 0 vs 1
		//IL_330e: Incompatible stack heights: 0 vs 1
		//IL_3318: Incompatible stack heights: 0 vs 1
		//IL_3322: Incompatible stack heights: 0 vs 1
		//IL_332c: Incompatible stack heights: 0 vs 1
		//IL_3336: Incompatible stack heights: 0 vs 1
		//IL_3340: Incompatible stack heights: 0 vs 1
		//IL_334a: Incompatible stack heights: 0 vs 1
		//IL_3354: Incompatible stack heights: 0 vs 1
		//IL_335e: Incompatible stack heights: 0 vs 1
		//IL_3368: Incompatible stack heights: 0 vs 1
		//IL_3372: Incompatible stack heights: 0 vs 1
		//IL_337c: Incompatible stack heights: 0 vs 1
		//IL_3390: Incompatible stack heights: 0 vs 1
		//IL_339a: Incompatible stack heights: 0 vs 1
		//IL_33a4: Incompatible stack heights: 0 vs 1
		//IL_33ae: Incompatible stack heights: 0 vs 1
		//IL_33b8: Incompatible stack heights: 0 vs 1
		//IL_33c2: Incompatible stack heights: 0 vs 1
		//IL_33cc: Incompatible stack heights: 0 vs 1
		//IL_33d6: Incompatible stack heights: 0 vs 2
		//IL_33e0: Incompatible stack heights: 0 vs 1
		//IL_33ea: Incompatible stack heights: 0 vs 1
		int num = 244;
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		BinaryReader binaryReader = default(BinaryReader);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array4 = default(byte[]);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] rgbKey = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			int num7;
			int num9;
			switch (num)
			{
			case 289:
				array2[29] = 203;
				num = 353;
				break;
			case 299:
				num6 = 77 + 73;
				num7 = 123;
				goto IL_0a74;
			case 191:
				array3[8] = 169;
				num7 = 119;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0075: Stack underflow*/ == 0)
				{
					goto case 335;
				}
				goto IL_0a74;
			case 335:
				array3[13] = 65;
				num7 = 205;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_009d: Stack underflow*/ == 0)
				{
					goto case 262;
				}
				goto IL_0a74;
			case 262:
				array3[14] = (byte)num8;
				num9 = 136;
				goto IL_0a70;
			case 356:
				array2[6] = (byte)num6;
				num7 = 340;
				goto IL_0a74;
			case 303:
				array2[14] = 135;
				num9 = 33;
				goto IL_0a70;
			case 126:
				array3[10] = 148;
				num = 241;
				break;
			case 53:
				array3[9] = (byte)num8;
				num9 = 131;
				goto IL_0a70;
			case 312:
				array3[0] = 60;
				num7 = 274;
				if (1 == 0)
				{
					goto case 288;
				}
				goto IL_0a74;
			case 288:
				array5[13] = array6[6];
				num7 = 75;
				if (false)
				{
					goto case 147;
				}
				goto IL_0a74;
			case 147:
				array2[28] = 112;
				num7 = 161;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_018a: Stack underflow*/ == 0)
				{
					goto case 91;
				}
				goto IL_0a74;
			case 313:
				array2[13] = (byte)num6;
				num = 303;
				break;
			case 137:
				array2[10] = (byte)num6;
				num7 = 257;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_01c8: Stack underflow*/ == 0)
				{
					goto case 19;
				}
				goto IL_0a74;
			case 19:
				array2[24] = (byte)num6;
				num7 = 238;
				goto IL_0a74;
			case 250:
				num6 = 186 - 62;
				num9 = 22;
				goto IL_0a70;
			case 30:
				array2[3] = (byte)num6;
				num9 = 310;
				goto IL_0a70;
			case 211:
				num6 = 45 + 106;
				num = 14;
				break;
			case 172:
				array2[12] = (byte)num6;
				num9 = 20;
				goto IL_0a70;
			case 164:
				array2[19] = (byte)num6;
				num9 = 52;
				goto IL_0a70;
			case 264:
				array2[25] = (byte)num6;
				num7 = 298;
				if (false)
				{
					goto case 154;
				}
				goto IL_0a74;
			case 154:
				num8 = 166 - 55;
				num = 156;
				break;
			case 102:
				num8 = 70 + 60;
				num7 = 226;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_02b6: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 314;
			case 141:
				memoryStream.Close();
				num = 337;
				break;
			case 222:
				array2[13] = (byte)num6;
				num7 = 1;
				if (1 == 0)
				{
					goto case 318;
				}
				goto IL_0a74;
			case 318:
				num6 = 197 - 65;
				num7 = 266;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_030b: Stack underflow*/ == 0)
				{
					goto case 245;
				}
				goto IL_0a74;
			case 245:
				array2[30] = 122;
				num9 = 294;
				goto IL_0a70;
			case 327:
				_ = binaryReader.BaseStream;
				((Stream)/*Error near IL_30e8: Stack underflow*/).Position = 0L;
				_ = 1;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0342: Stack underflow*/ == 0)
				{
					num9 = 224;
					goto IL_0a70;
				}
				num = 17;
				break;
			case 350:
				array2[19] = 19;
				num7 = 42;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_0375: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 291;
			case 204:
				array3[11] = 110;
				num7 = 361;
				goto IL_0a74;
			case 240:
				array2[24] = (byte)num6;
				num7 = 92;
				if (1 == 0)
				{
					goto case 33;
				}
				goto IL_0a74;
			case 33:
				array2[14] = 118;
				num = 280;
				break;
			case 306:
				array3[1] = (byte)num8;
				num = 133;
				break;
			case 347:
				array3[2] = (byte)num8;
				num = 68;
				break;
			case 105:
				cryptoStream.Write(array4, 0, array4.Length);
				num7 = 311;
				goto IL_0a74;
			case 328:
				array3[10] = (byte)num8;
				num7 = 204;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0444: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 301;
			case 97:
				array3[4] = (byte)num8;
				num7 = 154;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_046a: Stack underflow*/ != 0)
				{
					goto case 109;
				}
				goto IL_0a74;
			case 109:
				array2[4] = (byte)num6;
				num9 = 163;
				goto IL_0a70;
			case 150:
				array3[0] = 94;
				num7 = 102;
				if (false)
				{
					goto case 292;
				}
				goto IL_0a74;
			case 292:
				array3[15] = 139;
				num9 = 336;
				goto IL_0a70;
			case 232:
				num8 = 110 + 75;
				num7 = 305;
				if (1 == 0)
				{
					goto case 236;
				}
				goto IL_0a74;
			case 236:
				array2[30] = (byte)num6;
				num7 = 259;
				goto IL_0a74;
			case 308:
				array2[3] = 143;
				num = 128;
				break;
			case 183:
				num6 = 4 + 17;
				num7 = 304;
				if (false)
				{
					goto case 58;
				}
				goto IL_0a74;
			case 58:
				num8 = 137 - 45;
				num9 = 216;
				goto IL_0a70;
			case 49:
				num6 = 62 + 70;
				num7 = 106;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_0577: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 355;
			case 107:
				num8 = 145 - 48;
				num9 = 234;
				goto IL_0a70;
			case 247:
				array2[3] = 140;
				num7 = 308;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_05bd: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 69;
			case 91:
				num6 = 127 - 42;
				num7 = 355;
				if (false)
				{
					goto case 81;
				}
				goto IL_0a74;
			case 81:
				array2[15] = (byte)num6;
				num = 5;
				break;
			case 20:
				num6 = 213 - 71;
				num7 = 358;
				goto IL_0a74;
			case 35:
				num8 = 40 - 6;
				num7 = 325;
				goto IL_0a74;
			case 160:
				array2[13] = 146;
				num7 = 138;
				if (false)
				{
					goto case 226;
				}
				goto IL_0a74;
			case 226:
				array3[0] = (byte)num8;
				num = 312;
				break;
			case 349:
				num6 = 98 - 67;
				num9 = 69;
				goto IL_0a70;
			case 317:
				array2[5] = 103;
				num7 = 55;
				goto IL_0a74;
			case 34:
				num6 = 61 + 59;
				num7 = 152;
				goto IL_0a74;
			case 0:
				array2[5] = (byte)num6;
				num = 84;
				break;
			case 198:
				array2[0] = (byte)num6;
				num7 = 110;
				goto IL_0a74;
			case 119:
				num8 = 9 - 8;
				num9 = 220;
				goto IL_0a70;
			case 14:
				array2[9] = (byte)num6;
				num7 = 65;
				goto IL_0a74;
			case 151:
				array3[3] = 158;
				num9 = 35;
				goto IL_0a70;
			case 184:
				array3[7] = (byte)num8;
				num7 = 263;
				goto IL_0a74;
			case 201:
				num6 = 213 - 71;
				num7 = 112;
				if (false)
				{
					goto case 8;
				}
				goto IL_0a74;
			case 8:
				if (o83QQP95G.Length == 0)
				{
					num7 = 122;
					if (1 == 0)
					{
						goto case 23;
					}
					goto IL_0a74;
				}
				goto case 66;
			case 23:
				array2[6] = 190;
				num7 = 218;
				if (1 == 0)
				{
					goto case 321;
				}
				goto IL_0a74;
			case 321:
				num6 = 206 - 68;
				num7 = 11;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_07ea: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 305;
			case 103:
				array2[23] = (byte)num6;
				num9 = 34;
				goto IL_0a70;
			case 207:
				_ = typeof(HIqNmi47ta6wQLwpfy);
				_ = ((Type)/*Error near IL_314c: Stack underflow*/).Assembly;
				((Assembly)/*Error near IL_3156: Stack underflow*/).GetName();
				((AssemblyName)/*Error near IL_3160: Stack underflow*/).GetPublicKeyToken();
				array6 = (byte[])/*Error near IL_0822: Stack underflow*/;
				num = 32;
				break;
			case 309:
				array3[6] = (byte)num8;
				num9 = 94;
				goto IL_0a70;
			case 134:
				num6 = 162 - 54;
				num9 = 330;
				goto IL_0a70;
			case 83:
				num8 = 221 - 73;
				num9 = 309;
				goto IL_0a70;
			case 256:
				array3[13] = 148;
				num7 = 335;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_089e: Stack underflow*/ != 0)
				{
					goto case 56;
				}
				goto IL_0a74;
			case 56:
				array2[9] = 92;
				num9 = 178;
				goto IL_0a70;
			case 136:
				array3[14] = 150;
				num7 = 181;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_08e5: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 6;
			case 71:
				array2[11] = 157;
				num7 = 167;
				if (false)
				{
					goto case 173;
				}
				goto IL_0a74;
			case 173:
				num8 = 28 + 95;
				num = 239;
				break;
			case 26:
				num6 = 239 - 79;
				num7 = 54;
				goto IL_0a74;
			case 196:
				array2[2] = (byte)num6;
				num7 = 208;
				if (false)
				{
					goto case 360;
				}
				goto IL_0a74;
			case 360:
				num6 = 114 + 106;
				num7 = 10;
				goto IL_0a74;
			case 344:
				num6 = 98 + 59;
				num7 = 132;
				goto IL_0a74;
			case 158:
				array2[26] = 117;
				num7 = 329;
				if (1 == 0)
				{
					goto case 251;
				}
				goto IL_0a74;
			case 251:
				array3[1] = (byte)num8;
				num7 = 79;
				goto IL_0a74;
			case 199:
				if (array6.Length > 0)
				{
					num = 21;
					break;
				}
				goto case 200;
			case 175:
				num6 = 108 + 66;
				num = 284;
				break;
			case 345:
				array2[16] = (byte)num6;
				num9 = 24;
				goto IL_0a70;
			case 76:
				array3[3] = 114;
				num9 = 232;
				goto IL_0a70;
			case 159:
				array3[15] = (byte)num8;
				num = 290;
				break;
			case 179:
				num6 = 90 - 6;
				goto case 157;
			default:
				num7 = 157;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 60;
			case 60:
				num6 = 125 + 104;
				num7 = 356;
				goto IL_0a74;
			case 283:
				array3[8] = (byte)num8;
				num7 = 191;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1076: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 316;
			case 230:
				array2[19] = (byte)num6;
				num9 = 350;
				goto IL_0a70;
			case 12:
				num6 = 8 + 119;
				num7 = 19;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_10b5: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 24;
			case 24:
				num6 = 71 + 118;
				num = 316;
				break;
			case 279:
				num6 = 39 + 103;
				num7 = 180;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 186;
			case 186:
				array3[3] = 124;
				num9 = 76;
				goto IL_0a70;
			case 2:
				array2[16] = 152;
				num = 212;
				break;
			case 305:
				array3[3] = (byte)num8;
				num9 = 151;
				goto IL_0a70;
			case 74:
				array2[5] = 123;
				num7 = 23;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_116a: Stack underflow*/ != 0)
				{
					goto case 53;
				}
				goto IL_0a74;
			case 287:
				array3[11] = 152;
				num9 = 57;
				goto IL_0a70;
			case 215:
				array2[29] = 46;
				num = 291;
				break;
			case 192:
				num6 = 159 - 53;
				num = 217;
				break;
			case 354:
				num6 = 58 + 49;
				num = 0;
				break;
			case 41:
				array3[1] = (byte)num8;
				num7 = 173;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 219;
			case 219:
				num8 = 202 - 67;
				num9 = 293;
				goto IL_0a70;
			case 316:
				array2[17] = (byte)num6;
				num9 = 271;
				goto IL_0a70;
			case 282:
				num6 = 58 + 98;
				num9 = 89;
				goto IL_0a70;
			case 110:
				array2[0] = 128;
				num9 = 249;
				goto IL_0a70;
			case 1:
				array2[13] = 148;
				num7 = 188;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_128d: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 210;
			case 210:
				num8 = 182 - 60;
				num7 = 270;
				goto IL_0a74;
			case 346:
				num6 = 232 - 77;
				num7 = 230;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_12cc: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 273;
			case 112:
				array2[1] = (byte)num6;
				num7 = 88;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_12f2: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 124;
			case 124:
				array2[8] = 134;
				num = 268;
				break;
			case 169:
				array3[9] = (byte)num8;
				num = 77;
				break;
			case 69:
				array2[31] = (byte)num6;
				num9 = 197;
				goto IL_0a70;
			case 52:
				array2[20] = 80;
				num9 = 72;
				goto IL_0a70;
			case 174:
				num6 = 202 - 67;
				num7 = 28;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 307;
			case 307:
				array2[17] = (byte)num6;
				num9 = 342;
				goto IL_0a70;
			case 106:
				array2[26] = (byte)num6;
				num7 = 158;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 51;
			case 51:
				array2[21] = (byte)num6;
				num7 = 175;
				goto IL_0a74;
			case 329:
				array2[27] = 85;
				num7 = 26;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 25;
			case 25:
				num8 = 58 + 98;
				num7 = 41;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 243;
			case 243:
				array2[3] = 138;
				num7 = 247;
				goto IL_0a74;
			case 65:
				num6 = 105 + 50;
				num9 = 113;
				goto IL_0a70;
			case 121:
				array5[5] = array6[2];
				num7 = 6;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1467: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 295;
			case 242:
				array2[10] = (byte)num6;
				num7 = 318;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 231;
			case 231:
				num8 = 1 + 65;
				num7 = 159;
				goto IL_0a74;
			case 189:
				array3[10] = 77;
				num7 = 4;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 298;
			case 298:
				array2[25] = 142;
				num = 332;
				break;
			case 280:
				num6 = 27 + 17;
				num7 = 111;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_150b: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 259;
			case 259:
				array2[30] = 82;
				num = 267;
				break;
			case 113:
				array2[9] = (byte)num6;
				num9 = 56;
				goto IL_0a70;
			case 17:
			case 202:
				array2[29] = (byte)num6;
				num = 289;
				break;
			case 337:
				cryptoStream.Close();
				num = 70;
				break;
			case 128:
				num6 = 119 + 6;
				num7 = 30;
				goto IL_0a74;
			case 42:
				num6 = 114 + 75;
				num9 = 164;
				goto IL_0a70;
			case 269:
				array5[9] = array6[4];
				num7 = 223;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_15bc: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 283;
			case 153:
				num6 = 238 - 123;
				num7 = 139;
				goto IL_0a74;
			case 221:
				array3[4] = (byte)num8;
				num9 = 357;
				goto IL_0a70;
			case 90:
				array3[9] = (byte)num8;
				num7 = 275;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 213;
			case 213:
				array2[28] = (byte)num6;
				num9 = 147;
				goto IL_0a70;
			case 27:
				array3[7] = 237;
				num7 = 326;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 261;
			case 261:
				num6 = 124 + 12;
				num = 213;
				break;
			case 203:
				array3[10] = 92;
				num = 210;
				break;
			case 355:
				array2[14] = (byte)num6;
				num7 = 193;
				goto IL_0a74;
			case 263:
				array3[7] = 116;
				num7 = 27;
				goto IL_0a74;
			case 55:
				array2[5] = 106;
				num7 = 74;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 246;
			case 246:
				array2[1] = 152;
				num9 = 282;
				goto IL_0a70;
			case 237:
				num6 = 154 - 51;
				num9 = 253;
				goto IL_0a70;
			case 140:
				array2[1] = (byte)num6;
				num7 = 201;
				goto IL_0a74;
			case 229:
				array2[0] = 118;
				num = 273;
				break;
			case 206:
				num6 = 171 - 57;
				num = 196;
				break;
			case 227:
				array2[31] = (byte)num6;
				num7 = 349;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1797: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 334;
			case 133:
				array3[2] = 154;
				num9 = 13;
				goto IL_0a70;
			case 75:
				array5[15] = array6[7];
				num7 = 200;
				goto IL_0a74;
			case 125:
				array3[14] = (byte)num8;
				num7 = 219;
				goto IL_0a74;
			case 57:
				array3[11] = 58;
				num7 = 142;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1815: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 94;
			case 352:
				num8 = 198 - 66;
				num9 = 90;
				goto IL_0a70;
			case 286:
				array2[15] = 66;
				num = 36;
				break;
			case 304:
				array2[22] = (byte)num6;
				num7 = 324;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 138;
			case 138:
				num6 = 135 + 81;
				num = 313;
				break;
			case 46:
				array3[1] = (byte)num8;
				num7 = 99;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_18a9: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 230;
			case 67:
				array2[17] = (byte)num6;
				num9 = 237;
				goto IL_0a70;
			case 255:
				num6 = 150 - 50;
				num9 = 29;
				goto IL_0a70;
			case 275:
				num8 = 199 - 66;
				num9 = 169;
				goto IL_0a70;
			case 131:
				array3[9] = 92;
				num7 = 203;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1920: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 334;
			case 32:
				if (array6 != null)
				{
					num7 = 199;
					HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_193f: Stack underflow*/ == 0)
					{
						goto IL_0a74;
					}
					goto case 314;
				}
				goto case 200;
			case 314:
				array3[14] = (byte)num8;
				num9 = 43;
				goto IL_0a70;
			case 214:
				num6 = 130 - 43;
				num7 = 222;
				goto IL_0a74;
			case 145:
				num8 = 164 - 96;
				num7 = 125;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 252;
			case 252:
				array2[27] = (byte)num6;
				num = 187;
				break;
			case 78:
				array2[7] = 159;
				num9 = 59;
				goto IL_0a70;
			case 13:
				num8 = 234 - 78;
				num9 = 347;
				goto IL_0a70;
			case 268:
				num6 = 200 - 66;
				num7 = 278;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 187;
			case 187:
				array2[27] = 197;
				num = 185;
				break;
			case 353:
				array2[29] = 111;
				num7 = 245;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1a47: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 205;
			case 205:
				num8 = 93 + 90;
				num = 262;
				break;
			case 37:
				array3[9] = (byte)num8;
				num = 248;
				break;
			case 122:
				_ = typeof(HIqNmi47ta6wQLwpfy);
				_ = ((Type)/*Error near IL_3228: Stack underflow*/).Assembly;
				m1q7I8dyO((object)/*Error near IL_3232: Stack underflow*/);
				((object)/*Error near IL_323c: Stack underflow*/).ToString();
				NrTwpMKvx((string)/*Error near IL_3246: Stack underflow*/);
				o83QQP95G = (byte[])/*Error near IL_1a9b: Stack underflow*/;
				num7 = 66;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 291;
			case 291:
				num6 = 65 + 105;
				goto case 17;
			case 72:
				array2[20] = 145;
				num9 = 127;
				goto IL_0a70;
			case 326:
				array3[8] = 90;
				num = 258;
				break;
			case 296:
				array3[12] = (byte)num8;
				num7 = 130;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1b28: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 129;
			case 311:
				cryptoStream.FlushFinalBlock();
				num7 = 129;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1b47: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 180;
			case 180:
				array2[24] = (byte)num6;
				num = 12;
				break;
			case 253:
				array2[18] = (byte)num6;
				num = 281;
				break;
			case 80:
				num8 = 16 + 87;
				num9 = 148;
				goto IL_0a70;
			case 132:
				array2[16] = (byte)num6;
				num9 = 2;
				goto IL_0a70;
			case 332:
				array2[25] = 90;
				num9 = 31;
				goto IL_0a70;
			case 193:
				num6 = 9 + 79;
				num = 47;
				break;
			case 319:
				array2[11] = 55;
				num9 = 71;
				goto IL_0a70;
			case 36:
				num6 = 131 - 43;
				num7 = 302;
				goto IL_0a74;
			case 6:
				array5[7] = array6[3];
				num = 269;
				break;
			case 116:
				num6 = 191 - 63;
				num = 198;
				break;
			case 70:
				binaryReader.Close();
				num9 = 8;
				goto IL_0a70;
			case 343:
				array3[10] = (byte)num8;
				num9 = 189;
				goto IL_0a70;
			case 270:
				array3[10] = (byte)num8;
				num7 = 126;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1c8f: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 135;
			case 135:
				num6 = 8 + 8;
				num7 = 95;
				goto IL_0a74;
			case 101:
				array3[12] = (byte)num8;
				num = 348;
				break;
			case 339:
				num8 = 88 + 53;
				num9 = 184;
				goto IL_0a70;
			case 208:
				num6 = 73 + 95;
				num7 = 359;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1cff: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 31;
			case 31:
				array2[25] = 156;
				num7 = 179;
				goto IL_0a74;
			case 340:
				array2[7] = 104;
				num7 = 155;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1d4a: Stack underflow*/ == 0)
				{
					goto case 289;
				}
				goto IL_0a74;
			case 359:
				array2[2] = (byte)num6;
				num = 243;
				break;
			case 325:
				array3[3] = (byte)num8;
				num9 = 38;
				goto IL_0a70;
			case 127:
				array2[20] = 31;
				num9 = 299;
				goto IL_0a70;
			case 239:
				array3[1] = (byte)num8;
				num = 18;
				break;
			case 285:
				array2[0] = (byte)num6;
				num9 = 116;
				goto IL_0a70;
			case 120:
				num6 = 37 + 34;
				num9 = 252;
				goto IL_0a70;
			case 146:
				num6 = 15 + 41;
				num7 = 172;
				goto IL_0a74;
			case 277:
				array5 = array3;
				num7 = 207;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1e1c: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 244;
			case 244:
				if (aeC03Eb7s.Length != 0)
				{
					goto case 8;
				}
				num9 = 45;
				goto IL_0a70;
			case 92:
				num6 = 151 - 50;
				num7 = 39;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1e54: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 104;
			case 129:
				memoryStream.ToArray();
				aeC03Eb7s = (byte[])/*Error near IL_1e65: Stack underflow*/;
				num = 141;
				break;
			case 216:
				array3[5] = (byte)num8;
				num9 = 107;
				goto IL_0a70;
			case 176:
				array3[5] = 95;
				num7 = 7;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 85;
			case 85:
				array2[11] = (byte)num6;
				num7 = 146;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 238;
			case 238:
				num6 = 145 - 48;
				num7 = 264;
				goto IL_0a74;
			case 123:
				array2[21] = (byte)num6;
				num7 = 15;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 195;
			case 195:
				num8 = 158 - 52;
				num7 = 338;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1f24: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 86;
			case 86:
				array2[7] = (byte)num6;
				num9 = 78;
				goto IL_0a70;
			case 108:
				array2 = new byte[32];
				num9 = 229;
				goto IL_0a70;
			case 185:
				array2[28] = 216;
				num7 = 261;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_1f7c: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 336;
			case 336:
				array3[15] = 166;
				num7 = 16;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 310;
			case 310:
				num6 = 44 + 23;
				num7 = 109;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_1fc2: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 266;
			case 266:
				array2[10] = (byte)num6;
				num9 = 225;
				goto IL_0a70;
			case 163:
				array2[4] = 164;
				num9 = 209;
				goto IL_0a70;
			case 324:
				num6 = 98 - 80;
				num7 = 44;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_201b: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 322;
			case 322:
				array3[1] = (byte)num8;
				num9 = 25;
				goto IL_0a70;
			case 157:
				array2[25] = (byte)num6;
				num9 = 250;
				goto IL_0a70;
			case 330:
				array2[2] = (byte)num6;
				num9 = 301;
				goto IL_0a70;
			case 143:
				array2[7] = 139;
				num7 = 61;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_208b: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 320;
			case 320:
				num6 = 159 - 53;
				num9 = 242;
				goto IL_0a70;
			case 212:
				num6 = 47 + 114;
				num7 = 345;
				goto IL_0a74;
			case 50:
				array2[31] = (byte)num6;
				num7 = 64;
				goto IL_0a74;
			case 294:
				num6 = 37 + 19;
				num = 236;
				break;
			case 5:
				array2[15] = 183;
				num9 = 344;
				goto IL_0a70;
			case 342:
				num6 = 147 + 9;
				num7 = 67;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2137: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 84;
			case 84:
				num6 = 211 - 70;
				num9 = 254;
				goto IL_0a70;
			case 293:
				array3[15] = (byte)num8;
				num9 = 292;
				goto IL_0a70;
			case 228:
				num6 = 42 + 100;
				num9 = 240;
				goto IL_0a70;
			case 98:
				array2[18] = 53;
				num7 = 331;
				goto IL_0a74;
			case 338:
				array3[6] = (byte)num8;
				num9 = 80;
				goto IL_0a70;
			case 234:
				array3[5] = (byte)num8;
				num7 = 170;
				goto IL_0a74;
			case 11:
				array2[22] = (byte)num6;
				num7 = 183;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 111;
			case 111:
				array2[14] = (byte)num6;
				num = 91;
				break;
			case 323:
				array2[23] = 124;
				num = 82;
				break;
			case 38:
				num8 = 171 - 57;
				num7 = 97;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 235;
			case 235:
				array3[11] = (byte)num8;
				num7 = 287;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 161;
			case 161:
				array2[28] = 70;
				num = 215;
				break;
			case 93:
				array2[10] = 134;
				num7 = 319;
				goto IL_0a74;
			case 168:
				symmetricAlgorithm.CreateDecryptor(rgbKey, array5);
				transform = (ICryptoTransform)/*Error near IL_22b4: Stack underflow*/;
				num7 = 104;
				goto IL_0a74;
			case 265:
				array3[0] = (byte)num8;
				num = 150;
				break;
			case 197:
				rgbKey = array2;
				num9 = 182;
				goto IL_0a70;
			case 171:
				array5[3] = array6[1];
				num = 121;
				break;
			case 267:
				num6 = 156 - 52;
				num7 = 50;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_231c: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 96;
			case 302:
				array2[15] = (byte)num6;
				num9 = 117;
				goto IL_0a70;
			case 278:
				array2[8] = (byte)num6;
				num7 = 135;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_235a: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 50;
			case 290:
				array3[15] = 8;
				num7 = 277;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 79;
			case 79:
				num8 = 227 - 75;
				num = 322;
				break;
			case 4:
				num8 = 89 + 103;
				num = 328;
				break;
			case 188:
				num6 = 197 - 65;
				num9 = 333;
				goto IL_0a70;
			case 361:
				num8 = 100 + 21;
				num7 = 235;
				goto IL_0a74;
			case 144:
				num8 = 41 + 119;
				num7 = 101;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2434: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 135;
			case 149:
				array2[2] = 94;
				num = 134;
				break;
			case 117:
				num6 = 85 + 51;
				num7 = 81;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 99;
			case 99:
				num8 = 182 + 59;
				num7 = 306;
				goto IL_0a74;
			case 47:
				array2[14] = (byte)num6;
				num7 = 100;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 351;
			case 351:
				array3[6] = (byte)num8;
				num9 = 83;
				goto IL_0a70;
			case 95:
				array2[8] = (byte)num6;
				num7 = 255;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 89;
			case 89:
				array2[1] = (byte)num6;
				num9 = 276;
				goto IL_0a70;
			case 165:
				new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream = (CryptoStream)/*Error near IL_2509: Stack underflow*/;
				num = 105;
				break;
			case 62:
				array2[2] = 102;
				num7 = 206;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 274;
			case 274:
				num8 = 65 + 64;
				num9 = 251;
				goto IL_0a70;
			case 114:
				array3[6] = 34;
				num7 = 177;
				goto IL_0a74;
			case 94:
				array3[6] = 96;
				num = 114;
				break;
			case 44:
				array2[22] = (byte)num6;
				num = 323;
				break;
			case 40:
				array3[3] = 159;
				num7 = 186;
				goto IL_0a74;
			case 139:
				array2[12] = (byte)num6;
				num7 = 214;
				goto IL_0a74;
			case 142:
				num8 = 81 + 91;
				num = 315;
				break;
			case 63:
				num8 = 201 - 67;
				num7 = 221;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2624: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 229;
			case 254:
				array2[5] = (byte)num6;
				num9 = 260;
				goto IL_0a70;
			case 248:
				num8 = 104 + 105;
				num7 = 53;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2663: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 331;
			case 225:
				num6 = 29 + 103;
				num7 = 137;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_268a: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 358;
			case 358:
				array2[12] = (byte)num6;
				num = 153;
				break;
			case 15:
				num6 = 36 + 90;
				num7 = 51;
				goto IL_0a74;
			case 257:
				array2[10] = 128;
				num7 = 93;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 223;
			case 223:
				array5[11] = array6[5];
				num9 = 288;
				goto IL_0a70;
			case 300:
				array2[2] = (byte)num6;
				num = 62;
				break;
			case 170:
				array3[5] = 128;
				num9 = 195;
				goto IL_0a70;
			case 7:
				array3[5] = 86;
				num9 = 58;
				goto IL_0a70;
			case 96:
				num8 = 19 + 7;
				num7 = 351;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 331;
			case 331:
				array2[19] = 116;
				num = 295;
				break;
			case 220:
				array3[8] = (byte)num8;
				num9 = 352;
				goto IL_0a70;
			case 271:
				array2[17] = 109;
				num7 = 162;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 68;
			case 68:
				num8 = 133 - 56;
				num = 272;
				break;
			case 334:
				array3[7] = 213;
				num7 = 339;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2805: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 315;
			case 315:
				array3[12] = (byte)num8;
				num9 = 144;
				goto IL_0a70;
			case 217:
				array2[27] = (byte)num6;
				num9 = 120;
				goto IL_0a70;
			case 333:
				array2[13] = (byte)num6;
				num9 = 160;
				goto IL_0a70;
			case 45:
				_ = typeof(HIqNmi47ta6wQLwpfy);
				_ = ((Type)/*Error near IL_3368: Stack underflow*/).Assembly;
				((Assembly)/*Error near IL_3372: Stack underflow*/).GetManifestResourceStream("31fd8574-aeab-4c37-a0c8-2c7145993d8b");
				new BinaryReader((Stream)/*Error near IL_337c: Stack underflow*/);
				binaryReader = (BinaryReader)/*Error near IL_286c: Stack underflow*/;
				num7 = 327;
				goto IL_0a74;
			case 341:
				symmetricAlgorithm.Mode = CipherMode.CBC;
				num = 168;
				break;
			case 181:
				num8 = 61 + 47;
				num = 314;
				break;
			case 273:
				num6 = 108 + 70;
				num = 285;
				break;
			case 209:
				array2[4] = 97;
				num9 = 354;
				goto IL_0a70;
			case 87:
				array2[23] = 40;
				num7 = 228;
				goto IL_0a74;
			case 61:
				array2[8] = 79;
				num = 124;
				break;
			case 348:
				num8 = 110 + 19;
				num7 = 296;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 21;
			case 21:
				array5[1] = array6[0];
				num9 = 171;
				goto IL_0a70;
			case 16:
				array3[15] = 160;
				num = 231;
				break;
			case 28:
				array2[15] = (byte)num6;
				num = 118;
				break;
			case 260:
				num6 = 116 + 11;
				num = 73;
				break;
			case 182:
				array3 = new byte[16];
				num7 = 297;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 281;
			case 281:
				array2[18] = 142;
				num7 = 98;
				goto IL_0a74;
			case 64:
				num6 = 79 + 11;
				num7 = 227;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 284;
			case 284:
				array2[21] = (byte)num6;
				num7 = 321;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 54;
			case 54:
				array2[27] = (byte)num6;
				num9 = 192;
				goto IL_0a70;
			case 118:
				num6 = 240 - 80;
				num = 233;
				break;
			case 82:
				num6 = 111 + 64;
				num = 103;
				break;
			case 148:
				array3[6] = (byte)num8;
				num7 = 96;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2a84: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 162;
			case 162:
				num6 = 184 - 61;
				num7 = 307;
				goto IL_0a74;
			case 77:
				num8 = 172 - 57;
				num7 = 37;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 48;
			case 48:
				array3[14] = (byte)num8;
				num7 = 145;
				goto IL_0a74;
			case 241:
				num8 = 107 + 33;
				num7 = 343;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2afd: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 85;
			case 152:
				array2[23] = (byte)num6;
				num7 = 87;
				goto IL_0a74;
			case 178:
				num6 = 54 + 42;
				num7 = 194;
				if (0 == 0)
				{
					goto IL_0a74;
				}
				goto case 258;
			case 258:
				num8 = 125 - 41;
				num = 283;
				break;
			case 276:
				num6 = 155 - 51;
				num = 140;
				break;
			case 156:
				array3[4] = (byte)num8;
				num7 = 63;
				goto IL_0a74;
			case 9:
				array2[8] = 9;
				num = 211;
				break;
			case 295:
				array2[19] = 146;
				num9 = 346;
				goto IL_0a70;
			case 301:
				num6 = 193 - 64;
				num7 = 300;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2bea: Stack underflow*/ == 0)
				{
					goto IL_0a74;
				}
				goto case 157;
			case 22:
				array2[26] = (byte)num6;
				num = 49;
				break;
			case 249:
				array2[0] = 156;
				num7 = 246;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 29;
			case 29:
				array2[8] = (byte)num6;
				num7 = 9;
				goto IL_0a74;
			case 194:
				array2[9] = (byte)num6;
				num7 = 360;
				goto IL_0a74;
			case 272:
				array3[2] = (byte)num8;
				num9 = 40;
				goto IL_0a70;
			case 73:
				array2[5] = (byte)num6;
				num = 317;
				break;
			case 43:
				num8 = 118 + 27;
				num9 = 48;
				goto IL_0a70;
			case 100:
				array2[14] = 37;
				num = 174;
				break;
			case 18:
				num8 = 7 + 37;
				num7 = 46;
				goto IL_0a74;
			case 357:
				array3[4] = 47;
				num7 = 176;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2d10: Stack underflow*/ != 0)
				{
					goto case 58;
				}
				goto IL_0a74;
			case 218:
				array2[6] = 70;
				num9 = 115;
				goto IL_0a70;
			case 177:
				num8 = 155 - 51;
				num7 = 190;
				HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if ((int)/*Error near IL_2d56: Stack underflow*/ != 0)
				{
					goto case 172;
				}
				goto IL_0a74;
			case 155:
				num6 = 221 - 73;
				num = 86;
				break;
			case 130:
				array3[13] = 118;
				num = 256;
				break;
			case 59:
				num6 = 97 + 47;
				num = 166;
				break;
			case 166:
				array2[7] = (byte)num6;
				num7 = 143;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2dcd: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 233;
			case 233:
				array2[15] = (byte)num6;
				num7 = 286;
				HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if ((int)/*Error near IL_2dee: Stack underflow*/ != 0)
				{
					goto IL_0a74;
				}
				goto case 167;
			case 167:
				num6 = 153 + 81;
				num9 = 85;
				goto IL_0a70;
			case 3:
			case 224:
			{
				_ = binaryReader.BaseStream;
				_ = ((Stream)/*Error near IL_33e0: Stack underflow*/).Length;
				int count = (int)/*Error near IL_2e14: Stack underflow*/;
				((BinaryReader)/*Error near IL_33ea: Stack underflow*/).ReadBytes(count);
				array4 = (byte[])/*Error near IL_2e1a: Stack underflow*/;
				num7 = 108;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 39;
			}
			case 39:
				array2[24] = (byte)num6;
				num7 = 279;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 88;
			case 88:
				array2[1] = 75;
				num7 = 149;
				if (true)
				{
					goto IL_0a74;
				}
				goto case 190;
			case 190:
				array3[7] = (byte)num8;
				num9 = 334;
				goto IL_0a70;
			case 115:
				array2[6] = 131;
				num = 60;
				break;
			case 10:
				array2[9] = (byte)num6;
				num = 320;
				break;
			case 297:
				num8 = 152 - 50;
				num = 265;
				break;
			case 66:
				num3 = 0;
				num9 = 362;
				goto IL_0a70;
			case 362:
				try
				{
					byte[] array = new byte[4];
					int num2 = 2;
					while (true)
					{
						int num4;
						switch (num2)
						{
						case 4:
							array[2] = aeC03Eb7s[_0020 + 2];
							goto case 3;
						case 0:
						case 1:
							array[1] = aeC03Eb7s[_0020 + 1];
							goto case 4;
						default:
							num4 = 4;
							HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							if ((int)/*Error near IL_2f65: Stack underflow*/ != 0)
							{
								goto IL_2f2d;
							}
							goto case 2;
						case 2:
							array[0] = aeC03Eb7s[_0020];
							HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
							HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							num4 = (((int)/*Error near IL_2f7f: Stack underflow*/ == 0) ? 5 : 0);
							goto IL_2f2d;
						case 3:
						case 5:
							array[3] = aeC03Eb7s[_0020 + 3];
							num2 = 6;
							continue;
						case 6:
							{
								BitConverter.ToInt32(array, 0);
								num3 = (int)/*Error near IL_2fd8: Stack underflow*/;
								break;
							}
							IL_2f2d:
							num2 = num4;
							continue;
						}
						break;
					}
				}
				catch
				{
				}
				try
				{
					if (o83QQP95G[num3] == 128)
					{
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						int num5;
						if ((int)/*Error near IL_3004: Stack underflow*/ != 0)
						{
							num5 = 2;
						}
						else
						{
							num5 = 3;
							HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							if ((int)/*Error near IL_3056: Stack underflow*/ == 0)
							{
								return result;
							}
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
			case 200:
				udTunHYcv();
				symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_2366: Stack underflow*/;
				num9 = 341;
				goto IL_0a70;
			case 104:
				{
					new MemoryStream();
					memoryStream = (MemoryStream)/*Error near IL_2403: Stack underflow*/;
					num7 = 165;
					if (true)
					{
						goto IL_0a74;
					}
					goto case 144;
				}
				IL_0a70:
				num7 = num9;
				goto IL_0a74;
				IL_0a74:
				num = num7;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static string wq74ZmDnL(int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00f2, IL_2e46, IL_3223
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_2e98: Incompatible stack heights: 0 vs 2
		//IL_2eac: Incompatible stack heights: 0 vs 1
		//IL_2eb6: Incompatible stack heights: 0 vs 1
		//IL_2ed6: Incompatible stack heights: 0 vs 1
		//IL_2ee0: Incompatible stack heights: 0 vs 1
		//IL_2eea: Incompatible stack heights: 0 vs 1
		//IL_2ef4: Incompatible stack heights: 0 vs 1
		//IL_2efe: Incompatible stack heights: 0 vs 1
		//IL_2f08: Incompatible stack heights: 0 vs 1
		//IL_2f12: Incompatible stack heights: 0 vs 1
		//IL_2f1c: Incompatible stack heights: 0 vs 1
		//IL_2f26: Incompatible stack heights: 0 vs 1
		//IL_2f30: Incompatible stack heights: 0 vs 1
		//IL_2f3a: Incompatible stack heights: 0 vs 1
		//IL_2f44: Incompatible stack heights: 0 vs 1
		//IL_2f4e: Incompatible stack heights: 0 vs 1
		//IL_2f62: Incompatible stack heights: 0 vs 1
		//IL_2f6c: Incompatible stack heights: 0 vs 1
		//IL_2f76: Incompatible stack heights: 0 vs 1
		//IL_2f8a: Incompatible stack heights: 0 vs 1
		//IL_2f94: Incompatible stack heights: 0 vs 1
		//IL_2f9e: Incompatible stack heights: 0 vs 1
		//IL_2fa8: Incompatible stack heights: 0 vs 1
		//IL_2fb2: Incompatible stack heights: 0 vs 1
		//IL_2fbc: Incompatible stack heights: 0 vs 1
		//IL_2fc6: Incompatible stack heights: 0 vs 1
		//IL_2fd0: Incompatible stack heights: 0 vs 1
		//IL_2fda: Incompatible stack heights: 0 vs 1
		//IL_2fe4: Incompatible stack heights: 0 vs 1
		//IL_2fee: Incompatible stack heights: 0 vs 2
		//IL_2ff8: Incompatible stack heights: 0 vs 1
		//IL_3002: Incompatible stack heights: 0 vs 1
		//IL_300c: Incompatible stack heights: 0 vs 1
		//IL_3020: Incompatible stack heights: 0 vs 1
		//IL_302a: Incompatible stack heights: 0 vs 1
		//IL_3034: Incompatible stack heights: 0 vs 1
		//IL_303e: Incompatible stack heights: 0 vs 1
		//IL_3048: Incompatible stack heights: 0 vs 1
		//IL_3052: Incompatible stack heights: 0 vs 1
		//IL_305c: Incompatible stack heights: 0 vs 1
		//IL_3066: Incompatible stack heights: 0 vs 1
		//IL_3070: Incompatible stack heights: 0 vs 1
		//IL_307a: Incompatible stack heights: 0 vs 1
		//IL_3084: Incompatible stack heights: 0 vs 1
		//IL_308e: Incompatible stack heights: 0 vs 1
		//IL_3098: Incompatible stack heights: 0 vs 1
		//IL_30a2: Incompatible stack heights: 0 vs 1
		//IL_30ac: Incompatible stack heights: 0 vs 1
		//IL_30b6: Incompatible stack heights: 0 vs 1
		//IL_30c0: Incompatible stack heights: 0 vs 1
		//IL_30ca: Incompatible stack heights: 0 vs 1
		//IL_30d4: Incompatible stack heights: 0 vs 1
		//IL_30de: Incompatible stack heights: 0 vs 1
		//IL_30e8: Incompatible stack heights: 0 vs 1
		//IL_30f2: Incompatible stack heights: 0 vs 1
		//IL_3106: Incompatible stack heights: 0 vs 1
		//IL_3110: Incompatible stack heights: 0 vs 1
		//IL_311a: Incompatible stack heights: 0 vs 1
		//IL_3124: Incompatible stack heights: 0 vs 1
		//IL_312e: Incompatible stack heights: 0 vs 1
		//IL_3138: Incompatible stack heights: 0 vs 1
		//IL_314c: Incompatible stack heights: 0 vs 1
		//IL_3156: Incompatible stack heights: 0 vs 1
		//IL_3160: Incompatible stack heights: 0 vs 1
		//IL_316a: Incompatible stack heights: 0 vs 1
		//IL_3174: Incompatible stack heights: 0 vs 1
		//IL_317e: Incompatible stack heights: 0 vs 1
		//IL_3188: Incompatible stack heights: 0 vs 1
		//IL_3192: Incompatible stack heights: 0 vs 1
		//IL_319c: Incompatible stack heights: 0 vs 1
		//IL_31a6: Incompatible stack heights: 0 vs 1
		//IL_31b0: Incompatible stack heights: 0 vs 1
		//IL_31ce: Incompatible stack heights: 0 vs 1
		//IL_31d8: Incompatible stack heights: 0 vs 1
		//IL_31e2: Incompatible stack heights: 0 vs 1
		//IL_31ec: Incompatible stack heights: 0 vs 1
		//IL_31f6: Incompatible stack heights: 0 vs 1
		//IL_3200: Incompatible stack heights: 0 vs 1
		//IL_320a: Incompatible stack heights: 0 vs 1
		//IL_3214: Incompatible stack heights: 0 vs 1
		//IL_321e: Incompatible stack heights: 0 vs 1
		int num = 330;
		byte[] array4 = default(byte[]);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] rgbKey = default(byte[]);
		byte[] array2 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		int num9 = default(int);
		byte[] array5 = default(byte[]);
		int num7 = default(int);
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		int num6 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num4 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array6 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 7:
						break;
					case 181:
						array4[24] = 69;
						num3 = 37;
						continue;
					case 342:
						symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
						transform = (ICryptoTransform)/*Error near IL_005e: Stack underflow*/;
						num3 = 134;
						continue;
					case 248:
						num9 = 28 + 24;
						num2 = 290;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 6;
					case 6:
						array5[1] = (byte)num7;
						num2 = 256;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_00a7: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 218;
					case 218:
						array4[4] = 135;
						num = 110;
						goto end_IL_00fb;
					case 12:
						array2[13] = array3[6];
						num = 172;
						goto end_IL_00fb;
					case 61:
						array4[27] = 150;
						goto case 178;
					default:
						num3 = 178;
						continue;
					case 100:
						array4[18] = (byte)num8;
						num2 = 160;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_06c3: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 335;
					case 209:
						array5[15] = 166;
						num3 = 309;
						continue;
					case 131:
						array4[18] = 161;
						num3 = 207;
						continue;
					case 261:
						array4 = new byte[32];
						num3 = 161;
						continue;
					case 35:
						array5[11] = 148;
						num = 159;
						goto end_IL_00fb;
					case 104:
						array5[0] = 111;
						num2 = 146;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 63;
					case 63:
						array4[16] = (byte)num8;
						num3 = 322;
						continue;
					case 171:
					case 306:
						num7 = 164 - 54;
						num3 = 335;
						continue;
					case 347:
						num7 = 11 + 8;
						num3 = 14;
						continue;
					case 24:
						array5[13] = 95;
						num = 220;
						goto end_IL_00fb;
					case 111:
						array4[13] = (byte)num9;
						num3 = 4;
						continue;
					case 200:
						array4[2] = 85;
						num = 258;
						goto end_IL_00fb;
					case 79:
						array5[5] = (byte)num7;
						num2 = 82;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0822: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 318;
					case 318:
						array4[25] = 191;
						num3 = 263;
						continue;
					case 101:
						array4[13] = (byte)num9;
						num3 = 22;
						continue;
					case 349:
						num9 = 226 - 75;
						num3 = 323;
						continue;
					case 280:
						array5[2] = 49;
						num2 = 138;
						goto end_IL_00ff;
					case 49:
						array5[10] = 120;
						num2 = 179;
						goto end_IL_00ff;
					case 336:
						num7 = 112 - 93;
						num2 = 115;
						goto end_IL_00ff;
					case 172:
						array2[15] = array3[7];
						num3 = 249;
						continue;
					case 213:
						num6 = 83 + 111;
						num2 = 43;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_091a: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 66;
					case 66:
						num7 = 89 + 37;
						num2 = 315;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 247;
					case 247:
						array4[21] = 98;
						num3 = 350;
						continue;
					case 284:
						array4[3] = (byte)num9;
						num2 = 55;
						goto end_IL_00ff;
					case 161:
						num8 = 93 + 25;
						num = 45;
						goto end_IL_00fb;
					case 206:
						num8 = 191 - 63;
						num = 292;
						goto end_IL_00fb;
					case 246:
						array4[6] = (byte)num9;
						num3 = 144;
						continue;
					case 210:
						num7 = 99 - 5;
						num = 175;
						goto end_IL_00fb;
					case 112:
						array5[14] = (byte)num7;
						num2 = 80;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_09f7: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 303;
					case 194:
						num7 = 123 - 31;
						num3 = 334;
						continue;
					case 106:
						memoryStream.ToArray();
						QM3sts0yC = (byte[])/*Error near IL_0a21: Stack underflow*/;
						num = 5;
						goto end_IL_00fb;
					case 95:
						array4[1] = (byte)num8;
						num2 = 200;
						goto end_IL_00ff;
					case 89:
						BitConverter.ToInt32(QM3sts0yC, _0020);
						num4 = (int)/*Error near IL_0a54: Stack underflow*/;
						num2 = 356;
						goto end_IL_00ff;
					case 277:
						array4[26] = (byte)num8;
						num = 282;
						goto end_IL_00fb;
					case 199:
						num8 = 27 - 13;
						num = 59;
						goto end_IL_00fb;
					case 4:
						num8 = 107 + 62;
						num3 = 211;
						continue;
					case 80:
						array5[14] = 110;
						num2 = 316;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0ad4: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 243;
					case 243:
						array4[17] = (byte)num8;
						num2 = 272;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0af5: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 213;
					case 203:
						num8 = 126 - 42;
						num = 277;
						goto end_IL_00fb;
					case 311:
						array4[22] = (byte)num8;
						num3 = 165;
						continue;
					case 282:
						array4[26] = 211;
						num2 = 65;
						goto end_IL_00ff;
					case 266:
						num8 = 117 + 8;
						num = 60;
						goto end_IL_00fb;
					case 215:
						array4[21] = 98;
						num2 = 247;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 72;
					case 72:
						array5[11] = (byte)num7;
						num3 = 35;
						continue;
					case 34:
						array4[10] = (byte)num8;
						num2 = 240;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0bc4: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 117;
					case 117:
						array4[26] = 169;
						num2 = 203;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0bec: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 164;
					case 164:
						array5[1] = (byte)num6;
						num = 241;
						goto end_IL_00fb;
					case 150:
						array4[30] = 67;
						num = 158;
						goto end_IL_00fb;
					case 296:
						binaryReader.Close();
						num3 = 89;
						continue;
					case 263:
						num9 = 22 + 4;
						num = 227;
						goto end_IL_00fb;
					case 262:
						array2[11] = array3[5];
						num2 = 12;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 201;
					case 201:
						array4[11] = (byte)num8;
						num2 = 76;
						goto end_IL_00ff;
					case 291:
						num9 = 45 + 82;
						num3 = 284;
						continue;
					case 132:
						array5[3] = 113;
						num2 = 8;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 179;
					case 179:
						array5[10] = 66;
						num3 = 97;
						continue;
					case 307:
						array5[15] = 118;
						num3 = 39;
						continue;
					case 109:
						array4[8] = 168;
						num2 = 103;
						goto end_IL_00ff;
					case 91:
						array4[15] = 201;
						num = 343;
						goto end_IL_00fb;
					case 27:
						array5[15] = (byte)num6;
						num = 307;
						goto end_IL_00fb;
					case 335:
						array5[12] = (byte)num7;
						num = 237;
						goto end_IL_00fb;
					case 238:
						num9 = 99 + 116;
						num = 21;
						goto end_IL_00fb;
					case 103:
						array4[8] = 164;
						num2 = 127;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0dad: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 242;
					case 251:
						array5[11] = 252;
						num3 = 265;
						continue;
					case 147:
						array4[14] = 77;
						num = 239;
						goto end_IL_00fb;
					case 239:
						array4[14] = 142;
						num2 = 31;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0e18: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 3;
					case 3:
						array4[3] = 140;
						num2 = 139;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 107;
					case 107:
						array4[6] = 229;
						num = 87;
						goto end_IL_00fb;
					case 204:
						array4[23] = 170;
						num2 = 304;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 167;
					case 167:
						_ = binaryReader.BaseStream;
						((Stream)/*Error near IL_2f80: Stack underflow*/).Position = 0L;
						num3 = 278;
						continue;
					case 159:
						num7 = 51 + 90;
						num3 = 228;
						continue;
					case 225:
						num7 = 130 + 115;
						num3 = 6;
						continue;
					case 272:
						array4[17] = 107;
						num2 = 125;
						goto end_IL_00ff;
					case 53:
						array4[30] = 166;
						num = 173;
						goto end_IL_00fb;
					case 177:
						array4[9] = 174;
						num3 = 338;
						continue;
					case 323:
						array4[20] = (byte)num9;
						num = 206;
						goto end_IL_00fb;
					case 50:
						array5[8] = (byte)num6;
						num = 180;
						goto end_IL_00fb;
					case 18:
						array5[5] = (byte)num6;
						num2 = 308;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 67;
					case 67:
						num8 = 100 + 26;
						num3 = 136;
						continue;
					case 48:
						array4[21] = 40;
						num = 275;
						goto end_IL_00fb;
					case 190:
						array5[13] = (byte)num7;
						num2 = 130;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0fcf: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 204;
					case 70:
						array4[12] = 54;
						num2 = 300;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 98;
					case 98:
						num9 = 42 + 86;
						num2 = 235;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_101a: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 155;
					case 155:
						array4[7] = 107;
						num3 = 109;
						continue;
					case 57:
						num8 = 118 - 66;
						num2 = 44;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 234;
					case 234:
						array4[17] = 91;
						num2 = 166;
						goto end_IL_00ff;
					case 59:
						array4[4] = (byte)num8;
						num2 = 19;
						goto end_IL_00ff;
					case 58:
						num9 = 249 - 83;
						num3 = 246;
						continue;
					case 287:
						array5[1] = 84;
						num2 = 13;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 271;
					case 271:
						num9 = 126 - 42;
						num2 = 354;
						goto end_IL_00ff;
					case 293:
						array5[0] = 70;
						num2 = 114;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1118: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 329;
					case 329:
						num6 = 236 - 78;
						num = 164;
						goto end_IL_00fb;
					case 231:
						num7 = 206 - 68;
						num3 = 297;
						continue;
					case 129:
						array4[19] = 192;
						num2 = 333;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1172: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 348;
					case 325:
						new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						cryptoStream = (CryptoStream)/*Error near IL_1183: Stack underflow*/;
						num = 162;
						goto end_IL_00fb;
					case 309:
						array5[15] = 166;
						num2 = 299;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 9;
					case 9:
						array4[4] = (byte)num8;
						num = 169;
						goto end_IL_00fb;
					case 97:
						num7 = 84 + 107;
						num2 = 314;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_11eb: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 124;
					case 124:
						array5[1] = (byte)num6;
						num2 = 0;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 13;
					case 13:
						num6 = 87 + 46;
						num3 = 23;
						continue;
					case 96:
						num8 = 66 + 63;
						num = 348;
						goto end_IL_00fb;
					case 308:
						num7 = 182 - 60;
						num2 = 79;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_125c: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 151;
					case 151:
						num9 = 38 + 12;
						num = 233;
						goto end_IL_00fb;
					case 255:
						array4[7] = 110;
						num2 = 155;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 260;
					case 260:
						array4[20] = 124;
						num = 154;
						goto end_IL_00fb;
					case 195:
						array4[29] = 26;
						num2 = 298;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 326;
					case 326:
						array4[6] = (byte)num9;
						num = 58;
						goto end_IL_00fb;
					case 69:
						array4[7] = (byte)num8;
						num2 = 255;
						goto end_IL_00ff;
					case 37:
						array4[24] = 217;
						num3 = 318;
						continue;
					case 36:
						num9 = 132 + 71;
						num3 = 119;
						continue;
					case 20:
						num9 = 250 - 83;
						num2 = 25;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 333;
					case 333:
						array4[19] = 163;
						num3 = 102;
						continue;
					case 273:
						array4[16] = (byte)num8;
						num = 234;
						goto end_IL_00fb;
					case 221:
						array5[1] = (byte)num7;
						num2 = 287;
						goto end_IL_00ff;
					case 187:
						array5[13] = 106;
						num2 = 24;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_13e1: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 186;
					case 186:
						num6 = 198 - 66;
						num2 = 230;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1403: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 24;
					case 160:
						num8 = 223 - 74;
						num2 = 202;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_142a: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 294;
					case 294:
						array2[1] = array3[0];
						num3 = 254;
						continue;
					case 224:
						array4[12] = (byte)num9;
						num = 341;
						goto end_IL_00fb;
					case 78:
						num8 = 136 + 37;
						num3 = 100;
						continue;
					case 87:
						num9 = 221 - 73;
						num3 = 313;
						continue;
					case 154:
						array4[20] = 170;
						num = 215;
						goto end_IL_00fb;
					case 278:
					{
						_ = binaryReader.BaseStream;
						_ = ((Stream)/*Error near IL_2ff8: Stack underflow*/).Length;
						int count = (int)/*Error near IL_14b1: Stack underflow*/;
						((BinaryReader)/*Error near IL_3002: Stack underflow*/).ReadBytes(count);
						array6 = (byte[])/*Error near IL_14b7: Stack underflow*/;
						num = 261;
						goto end_IL_00fb;
					}
					case 74:
						array4[19] = 3;
						num2 = 266;
						goto end_IL_00ff;
					case 343:
						array4[15] = 66;
						num2 = 248;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 313;
					case 313:
						array4[7] = (byte)num9;
						num2 = 176;
						goto end_IL_00ff;
					case 165:
						num9 = 76 + 52;
						num2 = 191;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 338;
					case 338:
						num8 = 67 + 101;
						num3 = 34;
						continue;
					case 228:
						array5[11] = (byte)num7;
						num = 92;
						goto end_IL_00fb;
					case 149:
						array4[29] = (byte)num9;
						num3 = 123;
						continue;
					case 220:
						num7 = 129 + 94;
						num = 190;
						goto end_IL_00fb;
					case 300:
						array4[12] = 145;
						num3 = 108;
						continue;
					case 332:
						array2[5] = array3[2];
						num2 = 122;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_15dd: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 294;
					case 55:
						array4[3] = 124;
						num2 = 84;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 127;
					case 127:
						array4[8] = 253;
						num3 = 93;
						continue;
					case 121:
						array4[9] = 229;
						num2 = 177;
						goto end_IL_00ff;
					case 8:
						num7 = 36 + 77;
						num3 = 126;
						continue;
					case 16:
						cryptoStream.FlushFinalBlock();
						num3 = 106;
						continue;
					case 21:
						array4[28] = (byte)num9;
						num2 = 57;
						goto end_IL_00ff;
					case 81:
						array4[6] = (byte)num8;
						num = 107;
						goto end_IL_00fb;
					case 135:
						num6 = 195 - 75;
						num2 = 353;
						goto end_IL_00ff;
					case 259:
						array4[25] = (byte)num9;
						num = 117;
						goto end_IL_00fb;
					case 88:
						array4[29] = 60;
						num3 = 195;
						continue;
					case 252:
						array4[31] = 109;
						num = 193;
						goto end_IL_00fb;
					case 290:
						array4[15] = (byte)num9;
						num2 = 156;
						goto end_IL_00ff;
					case 169:
						num9 = 247 - 82;
						num2 = 56;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 29;
					case 29:
						array5[7] = (byte)num6;
						num = 328;
						goto end_IL_00fb;
					case 339:
						array4[5] = 154;
						num2 = 105;
						goto end_IL_00ff;
					case 2:
						array5[2] = (byte)num7;
						num3 = 189;
						continue;
					case 233:
						array4[28] = (byte)num9;
						num2 = 238;
						goto end_IL_00ff;
					case 152:
						num9 = 205 - 68;
						num2 = 192;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_17e4: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 143;
					case 143:
						array5[13] = (byte)num6;
						num3 = 187;
						continue;
					case 130:
						num7 = 115 + 69;
						num2 = 112;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 321;
					case 321:
						num7 = 113 + 97;
						num3 = 94;
						continue;
					case 94:
						array5[6] = (byte)num7;
						num2 = 337;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1854: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 47;
					case 47:
						array4[0] = (byte)num8;
						num2 = 271;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1875: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 176;
					case 52:
						num6 = 221 - 73;
						num = 10;
						goto end_IL_00fb;
					case 84:
						num8 = 88 - 81;
						num3 = 90;
						continue;
					case 346:
						num8 = 139 - 46;
						num2 = 81;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 304;
					case 304:
						num8 = 86 - 14;
						num = 285;
						goto end_IL_00fb;
					case 253:
						num8 = 7 + 23;
						num2 = 69;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1905: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 148;
					case 148:
						array4[10] = (byte)num9;
						num2 = 274;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1926: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 120;
					case 60:
						array4[20] = (byte)num8;
						num2 = 349;
						goto end_IL_00ff;
					case 139:
						num9 = 206 - 68;
						num2 = 324;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 250;
					case 250:
						array5[2] = 79;
						num3 = 257;
						continue;
					case 240:
						num9 = 149 - 49;
						num2 = 148;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 237;
					case 237:
						array5[12] = 112;
						num2 = 347;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_19ca: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 14;
					case 242:
						array5[8] = (byte)num7;
						num2 = 264;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_19f0: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 245;
					case 245:
						array4[14] = (byte)num8;
						num = 276;
						goto end_IL_00fb;
					case 198:
						array4[13] = 197;
						num2 = 137;
						goto end_IL_00ff;
					case 31:
						num8 = 52 + 84;
						num = 142;
						goto end_IL_00fb;
					case 191:
						array4[22] = (byte)num9;
						num2 = 279;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1a65: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 99;
					case 99:
						array4[13] = (byte)num9;
						num = 198;
						goto end_IL_00fb;
					case 241:
						num6 = 6 + 118;
						num3 = 124;
						continue;
					case 341:
						num9 = 192 - 64;
						num = 101;
						goto end_IL_00fb;
					case 38:
						array4[31] = (byte)num9;
						num2 = 320;
						goto end_IL_00ff;
					case 324:
						array4[3] = (byte)num9;
						num2 = 291;
						goto end_IL_00ff;
					case 316:
						num7 = 134 - 97;
						num2 = 345;
						goto end_IL_00ff;
					case 350:
						num9 = 151 - 50;
						num = 352;
						goto end_IL_00fb;
					case 302:
						array4[14] = (byte)num8;
						num2 = 147;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1b3e: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 149;
					case 216:
						array5[4] = 108;
						num2 = 336;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 85;
					case 85:
						array4[27] = (byte)num8;
						num3 = 61;
						continue;
					case 25:
						array4[7] = (byte)num9;
						num3 = 253;
						continue;
					case 217:
						num7 = 237 - 79;
						num3 = 242;
						continue;
					case 133:
						_ = typeof(HIqNmi47ta6wQLwpfy);
						_ = ((Type)/*Error near IL_3084: Stack underflow*/).Assembly;
						((Assembly)/*Error near IL_308e: Stack underflow*/).GetManifestResourceStream("aee3009f-1045-4408-b1af-5f618829266c");
						new BinaryReader((Stream)/*Error near IL_3098: Stack underflow*/);
						binaryReader = (BinaryReader)/*Error near IL_1bcf: Stack underflow*/;
						num = 167;
						goto end_IL_00fb;
					case 264:
						num6 = 180 + 24;
						num2 = 50;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1bfb: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 133;
					case 227:
						array4[25] = (byte)num9;
						num2 = 283;
						goto end_IL_00ff;
					case 348:
						array4[11] = (byte)num8;
						num2 = 70;
						goto end_IL_00ff;
					case 208:
						array4[30] = 119;
						num3 = 150;
						continue;
					case 141:
						num9 = 34 + 31;
						num2 = 326;
						goto end_IL_00ff;
					case 110:
						num8 = 57 + 117;
						num = 9;
						goto end_IL_00fb;
					case 125:
						num9 = 167 - 55;
						num3 = 184;
						continue;
					case 166:
						num8 = 169 - 56;
						num3 = 243;
						continue;
					case 56:
						array4[4] = (byte)num9;
						num3 = 199;
						continue;
					case 258:
						num8 = 141 - 47;
						num2 = 73;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1cf9: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 204;
					case 119:
						array4[15] = (byte)num9;
						num2 = 71;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1d1f: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 97;
					case 295:
						num6 = 199 - 66;
						num2 = 32;
						goto end_IL_00ff;
					case 292:
						array4[20] = (byte)num8;
						num3 = 260;
						continue;
					case 30:
						array4[1] = 58;
						num2 = 170;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 128;
					case 128:
						num6 = 222 - 74;
						num3 = 244;
						continue;
					case 257:
						num7 = 95 + 87;
						num2 = 269;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 22;
					case 22:
						num9 = 128 - 42;
						num2 = 99;
						goto end_IL_00ff;
					case 297:
						array5[6] = (byte)num7;
						num = 210;
						goto end_IL_00fb;
					case 354:
						array4[1] = (byte)num9;
						num2 = 152;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 14;
					case 14:
						array5[12] = (byte)num7;
						num2 = 157;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1e38: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 47;
					case 183:
						array5[2] = 142;
						num2 = 280;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 26;
					case 26:
						num8 = 17 + 41;
						num3 = 201;
						continue;
					case 146:
						array5[0] = 59;
						num2 = 52;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1ea2: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 71;
					case 232:
						array5 = new byte[16];
						num = 293;
						goto end_IL_00fb;
					case 182:
						array4[2] = 186;
						num2 = 3;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1ee7: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 261;
					case 345:
						array5[14] = (byte)num7;
						num3 = 209;
						continue;
					case 355:
						array4[12] = (byte)num9;
						num = 270;
						goto end_IL_00fb;
					case 83:
						array5[11] = (byte)num7;
						num2 = 251;
						goto end_IL_00ff;
					case 230:
						array5[5] = (byte)num6;
						num2 = 62;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 286;
					case 286:
						array4[31] = (byte)num9;
						num = 86;
						goto end_IL_00fb;
					case 32:
						array5[4] = (byte)num6;
						num3 = 118;
						continue;
					case 113:
						num6 = 153 + 68;
						num = 145;
						goto end_IL_00fb;
					case 322:
						num8 = 58 - 53;
						num3 = 273;
						continue;
					case 276:
						num8 = 202 - 67;
						num2 = 302;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 138;
					case 138:
						array5[2] = 142;
						num2 = 250;
						goto end_IL_00ff;
					case 33:
						array4[19] = 166;
						num2 = 74;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2020: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 215;
					case 15:
						num6 = 173 - 57;
						num2 = 143;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 180;
					case 180:
						num7 = 176 - 58;
						num2 = 41;
						goto end_IL_00ff;
					case 268:
						array4[16] = (byte)num8;
						num3 = 222;
						continue;
					case 320:
						num9 = 231 - 77;
						num2 = 286;
						goto end_IL_00ff;
					case 236:
						array4[29] = 132;
						num = 88;
						goto end_IL_00fb;
					case 303:
						array4[24] = (byte)num8;
						num3 = 181;
						continue;
					case 142:
						array4[15] = (byte)num8;
						num2 = 91;
						goto end_IL_00ff;
					case 73:
						array4[2] = (byte)num8;
						num2 = 182;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 145;
					case 145:
						array5[0] = (byte)num6;
						num2 = 329;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2126: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 157;
					case 157:
						num6 = 113 + 69;
						num3 = 331;
						continue;
					case 162:
						cryptoStream.Write(array6, 0, array6.Length);
						num3 = 16;
						continue;
					case 244:
						array5[12] = (byte)num6;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2172: Stack underflow*/ != 0)
						{
							num2 = 171;
							_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							if ((int)/*Error near IL_2186: Stack underflow*/ != 0)
							{
								goto end_IL_00ff;
							}
							goto case 55;
						}
						num3 = 140;
						continue;
					case 115:
						array5[4] = (byte)num7;
						num2 = 229;
						goto end_IL_00ff;
					case 185:
						num6 = 41 + 47;
						num2 = 116;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 114;
					case 114:
						num6 = 53 + 45;
						num = 40;
						goto end_IL_00fb;
					case 19:
						array4[5] = 167;
						num3 = 339;
						continue;
					case 90:
						array4[3] = (byte)num8;
						num2 = 218;
						goto end_IL_00ff;
					case 330:
						if (QM3sts0yC.Length == 0)
						{
							num = 133;
							goto end_IL_00fb;
						}
						goto case 89;
					case 0:
						num7 = 212 - 70;
						num = 221;
						goto end_IL_00fb;
					case 118:
						array5[4] = 158;
						num3 = 216;
						continue;
					case 270:
						num9 = 74 + 83;
						num3 = 224;
						continue;
					case 274:
						array4[10] = 122;
						num2 = 42;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_22a8: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 353;
					case 353:
						array5[7] = (byte)num6;
						num3 = 185;
						continue;
					case 235:
						array4[0] = (byte)num9;
						num2 = 67;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 301;
					case 301:
						num8 = 197 - 65;
						num2 = 196;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 315;
					case 315:
						array5[3] = (byte)num7;
						num3 = 132;
						continue;
					case 86:
						array4[31] = 138;
						num3 = 252;
						continue;
					case 226:
						array4[5] = (byte)num9;
						num3 = 141;
						continue;
					case 285:
						array4[23] = (byte)num8;
						num = 317;
						goto end_IL_00fb;
					case 189:
						num7 = 68 + 53;
						num = 188;
						goto end_IL_00fb;
					case 23:
						array5[1] = (byte)num6;
						num2 = 225;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_239c: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 11;
					case 11:
						array4[19] = (byte)num8;
						num = 33;
						goto end_IL_00fb;
					case 192:
						array4[1] = (byte)num9;
						num3 = 30;
						continue;
					case 197:
						num8 = 137 - 45;
						num2 = 327;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 212;
					case 212:
						num9 = 219 + 33;
						num = 226;
						goto end_IL_00fb;
					case 352:
						array4[21] = (byte)num9;
						num3 = 48;
						continue;
					case 327:
						array4[28] = (byte)num8;
						num2 = 151;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 223;
					case 223:
						array5[6] = 97;
						num = 231;
						goto end_IL_00fb;
					case 102:
						num8 = 190 - 63;
						num2 = 11;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2479: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 334;
					case 173:
						array4[30] = 109;
						num2 = 208;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 256;
					case 256:
						num7 = 116 + 15;
						num = 2;
						goto end_IL_00fb;
					case 140:
					case 351:
						cryptoStream.Close();
						num = 296;
						goto end_IL_00fb;
					case 344:
						num8 = 29 + 32;
						num2 = 63;
						goto end_IL_00ff;
					case 265:
						array5[12] = 17;
						num3 = 128;
						continue;
					case 340:
						num9 = 45 + 20;
						num3 = 38;
						continue;
					case 120:
						array2 = array5;
						num = 174;
						goto end_IL_00fb;
					case 105:
						num9 = 103 + 59;
						num3 = 205;
						continue;
					case 214:
						array4[11] = (byte)num8;
						num2 = 96;
						goto end_IL_00ff;
					case 283:
						num9 = 206 - 117;
						num2 = 259;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 188;
					case 188:
						array5[2] = (byte)num7;
						num2 = 183;
						goto end_IL_00ff;
					case 123:
						array4[30] = 123;
						num = 53;
						goto end_IL_00fb;
					case 76:
						num8 = 16 + 113;
						num = 214;
						goto end_IL_00fb;
					case 254:
						array2[3] = array3[1];
						num2 = 332;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_25f1: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 337;
					case 202:
						array4[19] = (byte)num8;
						num2 = 129;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2617: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 328;
					case 54:
						num8 = 43 + 25;
						num2 = 303;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_263e: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 158;
					case 158:
						array4[31] = 43;
						num3 = 340;
						continue;
					case 122:
						array2[7] = array3[3];
						num3 = 17;
						continue;
					case 42:
						array4[10] = 35;
						num2 = 26;
						goto end_IL_00ff;
					case 319:
						if (array3 == null)
						{
							goto case 249;
						}
						num3 = 168;
						continue;
					case 334:
						array5[9] = (byte)num7;
						num = 49;
						goto end_IL_00fb;
					case 68:
						num6 = 88 + 39;
						num2 = 51;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 178;
					case 178:
						num9 = 134 - 18;
						num = 28;
						goto end_IL_00fb;
					case 1:
						array5[9] = (byte)num7;
						num = 194;
						goto end_IL_00fb;
					case 298:
						num9 = 188 + 59;
						num = 149;
						goto end_IL_00fb;
					case 126:
						array5[4] = (byte)num7;
						num2 = 295;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 144;
					case 144:
						num8 = 197 - 65;
						num = 219;
						goto end_IL_00fb;
					case 10:
						array5[0] = (byte)num6;
						num = 113;
						goto end_IL_00fb;
					case 156:
						array4[15] = 8;
						num = 36;
						goto end_IL_00fb;
					case 92:
						num7 = 105 + 10;
						num = 83;
						goto end_IL_00fb;
					case 46:
						array5[10] = (byte)num6;
						num2 = 267;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_27c9: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 82;
					case 82:
						array5[5] = 127;
						num = 68;
						goto end_IL_00fb;
					case 337:
						array5[6] = 90;
						num3 = 223;
						continue;
					case 64:
						array4[29] = 125;
						num2 = 236;
						goto end_IL_00ff;
					case 314:
						array5[10] = (byte)num7;
						num2 = 7;
						goto end_IL_00ff;
					case 77:
						array4[14] = 112;
						num2 = 288;
						goto end_IL_00ff;
					case 40:
						array5[0] = (byte)num6;
						num3 = 104;
						continue;
					case 267:
						num7 = 168 - 56;
						num2 = 72;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 222;
					case 222:
						array4[16] = 124;
						num = 344;
						goto end_IL_00fb;
					case 62:
						num6 = 107 + 97;
						num2 = 18;
						if (true)
						{
							goto end_IL_00ff;
						}
						goto case 168;
					case 168:
						if (array3.Length <= 0)
						{
							goto case 249;
						}
						num = 294;
						goto end_IL_00fb;
					case 136:
						array4[0] = (byte)num8;
						num2 = 163;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 17;
					case 17:
						array2[9] = array3[4];
						num = 262;
						goto end_IL_00fb;
					case 299:
						num6 = 72 + 121;
						num2 = 27;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2941: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 153;
					case 153:
						array4[18] = 172;
						num2 = 131;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2969: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 219;
					case 219:
						array4[6] = (byte)num8;
						num = 346;
						goto end_IL_00fb;
					case 45:
						array4[0] = (byte)num8;
						num3 = 98;
						continue;
					case 176:
						array4[7] = 130;
						num2 = 20;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_29c1: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 137;
					case 137:
						num9 = 90 + 50;
						num3 = 111;
						continue;
					case 288:
						num8 = 180 - 60;
						num2 = 245;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 51;
					case 51:
						array5[5] = (byte)num6;
						num2 = 321;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2a19: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 34;
					case 317:
						array4[24] = 106;
						num2 = 54;
						goto end_IL_00ff;
					case 205:
						array4[5] = (byte)num9;
						num2 = 305;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2a62: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 289;
					case 289:
						num7 = 66 + 112;
						num3 = 1;
						continue;
					case 193:
						rgbKey = array4;
						num = 232;
						goto end_IL_00fb;
					case 184:
						array4[18] = (byte)num9;
						num2 = 153;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2aab: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 229;
					case 229:
						array5[5] = 166;
						num2 = 186;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2ad3: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 305;
					case 108:
						num9 = 59 + 90;
						num3 = 355;
						continue;
					case 281:
						symmetricAlgorithm.Mode = CipherMode.CBC;
						num2 = 342;
						goto end_IL_00ff;
					case 41:
						array5[9] = (byte)num7;
						num2 = 213;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 207;
					case 207:
						array4[18] = 163;
						num3 = 78;
						continue;
					case 211:
						array4[14] = (byte)num8;
						num3 = 77;
						continue;
					case 44:
						array4[28] = (byte)num8;
						num2 = 301;
						goto end_IL_00ff;
					case 43:
						array5[9] = (byte)num6;
						num2 = 289;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 75;
					case 75:
						array4[23] = 130;
						num2 = 204;
						goto end_IL_00ff;
					case 305:
						array4[5] = 92;
						num3 = 212;
						continue;
					case 71:
						num8 = 217 - 72;
						num3 = 268;
						continue;
					case 312:
						num6 = 185 + 51;
						num3 = 46;
						continue;
					case 5:
						memoryStream.Close();
						goto case 140;
					case 65:
						num8 = 196 - 65;
						num2 = 85;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2c41: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 275;
					case 275:
						num8 = 164 - 54;
						num = 311;
						goto end_IL_00fb;
					case 116:
						array5[8] = (byte)num6;
						num2 = 217;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2c7b: Stack underflow*/ == 0)
						{
							goto end_IL_00ff;
						}
						goto case 192;
					case 331:
						array5[12] = (byte)num6;
						num2 = 15;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2ca1: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 93;
					case 93:
						array4[9] = 201;
						num2 = 121;
						goto end_IL_00ff;
					case 175:
						array5[6] = (byte)num7;
						num3 = 310;
						continue;
					case 174:
						_ = typeof(HIqNmi47ta6wQLwpfy);
						_ = ((Type)/*Error near IL_31f6: Stack underflow*/).Assembly;
						((Assembly)/*Error near IL_3200: Stack underflow*/).GetName();
						((AssemblyName)/*Error near IL_320a: Stack underflow*/).GetPublicKeyToken();
						array3 = (byte[])/*Error near IL_2cf7: Stack underflow*/;
						num2 = 319;
						goto end_IL_00ff;
					case 170:
						num8 = 161 - 38;
						num2 = 95;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2d27: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 39;
					case 39:
						array5[15] = 152;
						num = 120;
						goto end_IL_00fb;
					case 328:
						array5[7] = 120;
						num = 135;
						goto end_IL_00fb;
					case 28:
						array4[27] = (byte)num9;
						num = 197;
						goto end_IL_00fb;
					case 196:
						array4[29] = (byte)num8;
						num2 = 64;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2d9e: Stack underflow*/ != 0)
						{
							goto end_IL_00ff;
						}
						goto case 163;
					case 163:
						num8 = 207 + 5;
						num = 47;
						goto end_IL_00fb;
					case 279:
						array4[22] = 146;
						num2 = 75;
						if (0 == 0)
						{
							goto end_IL_00ff;
						}
						goto case 269;
					case 269:
						array5[3] = (byte)num7;
						num = 66;
						goto end_IL_00fb;
					case 310:
						num6 = 142 - 47;
						num2 = 29;
						goto end_IL_00ff;
					case 356:
						try
						{
							byte[] array = new byte[num4];
							_ = 0;
							_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							int num5;
							if ((int)/*Error near IL_2e24: Stack underflow*/ != 0)
							{
								num5 = 2;
							}
							else
							{
								num5 = 3;
								if (1 == 0)
								{
									goto IL_2ea7;
								}
							}
							switch (num5)
							{
							case 0:
							case 2:
								Array.Copy(QM3sts0yC, _0020 + 4, array, 0, num4);
								break;
							}
							goto IL_2ea7;
							IL_2ea7:
							_ = Encoding.Unicode;
							IntPtr intPtr = (nint)array.LongLength;
							((Encoding)/*Error near IL_2eb6: Stack underflow*/).GetString(array, 0, (int)(nint)intPtr);
							return (string)/*Error near IL_2ebb: Stack underflow*/;
						}
						catch
						{
						}
						return "";
					case 134:
						new MemoryStream();
						memoryStream = (MemoryStream)/*Error near IL_0860: Stack underflow*/;
						num3 = 325;
						continue;
					case 249:
						udTunHYcv();
						symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_1d48: Stack underflow*/;
						num3 = 281;
						continue;
					}
					array5[10] = 145;
					num2 = 312;
					break;
					continue;
					end_IL_00ff:
					break;
				}
				continue;
				end_IL_00fb:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static string uv2Aqh0Fu(int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_274a, IL_3513
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_10b9: Invalid comparison between Unknown and I4
		//IL_155a: Invalid comparison between Unknown and I4
		//IL_2285: Invalid comparison between Unknown and I4
		//IL_3126: Incompatible stack heights: 0 vs 1
		//IL_3130: Incompatible stack heights: 0 vs 1
		//IL_313a: Incompatible stack heights: 0 vs 1
		//IL_3144: Incompatible stack heights: 0 vs 1
		//IL_314e: Incompatible stack heights: 0 vs 1
		//IL_3158: Incompatible stack heights: 0 vs 1
		//IL_3162: Incompatible stack heights: 0 vs 1
		//IL_316c: Incompatible stack heights: 0 vs 1
		//IL_3176: Incompatible stack heights: 0 vs 1
		//IL_3180: Incompatible stack heights: 0 vs 1
		//IL_318a: Incompatible stack heights: 0 vs 1
		//IL_3194: Incompatible stack heights: 0 vs 1
		//IL_319e: Incompatible stack heights: 0 vs 1
		//IL_31a8: Incompatible stack heights: 0 vs 1
		//IL_31b2: Incompatible stack heights: 0 vs 1
		//IL_31bc: Incompatible stack heights: 0 vs 2
		//IL_31c6: Incompatible stack heights: 0 vs 2
		//IL_31d0: Incompatible stack heights: 0 vs 1
		//IL_31da: Incompatible stack heights: 0 vs 2
		//IL_31e4: Incompatible stack heights: 0 vs 1
		//IL_31ee: Incompatible stack heights: 0 vs 1
		//IL_31f8: Incompatible stack heights: 0 vs 1
		//IL_3202: Incompatible stack heights: 0 vs 1
		//IL_320c: Incompatible stack heights: 0 vs 1
		//IL_3216: Incompatible stack heights: 0 vs 1
		//IL_3220: Incompatible stack heights: 0 vs 1
		//IL_322a: Incompatible stack heights: 0 vs 1
		//IL_3234: Incompatible stack heights: 0 vs 2
		//IL_323e: Incompatible stack heights: 0 vs 2
		//IL_3248: Incompatible stack heights: 0 vs 1
		//IL_325c: Incompatible stack heights: 0 vs 1
		//IL_3266: Incompatible stack heights: 0 vs 1
		//IL_3270: Incompatible stack heights: 0 vs 1
		//IL_327a: Incompatible stack heights: 0 vs 1
		//IL_3284: Incompatible stack heights: 0 vs 1
		//IL_328e: Incompatible stack heights: 0 vs 1
		//IL_3298: Incompatible stack heights: 0 vs 1
		//IL_32a2: Incompatible stack heights: 0 vs 1
		//IL_32ac: Incompatible stack heights: 0 vs 1
		//IL_32b6: Incompatible stack heights: 0 vs 1
		//IL_32c0: Incompatible stack heights: 0 vs 1
		//IL_32ca: Incompatible stack heights: 0 vs 1
		//IL_32d4: Incompatible stack heights: 0 vs 1
		//IL_32de: Incompatible stack heights: 0 vs 1
		//IL_32e8: Incompatible stack heights: 0 vs 1
		//IL_32f2: Incompatible stack heights: 0 vs 1
		//IL_3310: Incompatible stack heights: 0 vs 1
		//IL_331a: Incompatible stack heights: 0 vs 1
		//IL_3324: Incompatible stack heights: 0 vs 1
		//IL_332e: Incompatible stack heights: 0 vs 1
		//IL_3338: Incompatible stack heights: 0 vs 1
		//IL_3342: Incompatible stack heights: 0 vs 1
		//IL_334c: Incompatible stack heights: 0 vs 1
		//IL_3356: Incompatible stack heights: 0 vs 1
		//IL_3360: Incompatible stack heights: 0 vs 1
		//IL_3374: Incompatible stack heights: 0 vs 1
		//IL_337e: Incompatible stack heights: 0 vs 1
		//IL_3388: Incompatible stack heights: 0 vs 1
		//IL_3392: Incompatible stack heights: 0 vs 1
		//IL_33a6: Incompatible stack heights: 0 vs 1
		//IL_33b0: Incompatible stack heights: 0 vs 1
		//IL_33ba: Incompatible stack heights: 0 vs 1
		//IL_33c4: Incompatible stack heights: 0 vs 1
		//IL_33ce: Incompatible stack heights: 0 vs 2
		//IL_33d8: Incompatible stack heights: 0 vs 1
		//IL_33e2: Incompatible stack heights: 0 vs 1
		//IL_33ec: Incompatible stack heights: 0 vs 1
		//IL_33f6: Incompatible stack heights: 0 vs 1
		//IL_3400: Incompatible stack heights: 0 vs 1
		//IL_3414: Incompatible stack heights: 0 vs 1
		//IL_341e: Incompatible stack heights: 0 vs 1
		//IL_3428: Incompatible stack heights: 0 vs 1
		//IL_3432: Incompatible stack heights: 0 vs 1
		//IL_343c: Incompatible stack heights: 0 vs 1
		//IL_3446: Incompatible stack heights: 0 vs 1
		//IL_345a: Incompatible stack heights: 0 vs 1
		//IL_3464: Incompatible stack heights: 0 vs 2
		//IL_346e: Incompatible stack heights: 0 vs 1
		//IL_3478: Incompatible stack heights: 0 vs 1
		//IL_3482: Incompatible stack heights: 0 vs 3
		//IL_348c: Incompatible stack heights: 0 vs 1
		//IL_3496: Incompatible stack heights: 0 vs 1
		//IL_34a0: Incompatible stack heights: 0 vs 1
		//IL_34aa: Incompatible stack heights: 0 vs 1
		//IL_34b4: Incompatible stack heights: 0 vs 1
		//IL_34be: Incompatible stack heights: 0 vs 1
		//IL_34c8: Incompatible stack heights: 0 vs 1
		//IL_34d2: Incompatible stack heights: 0 vs 1
		//IL_34dc: Incompatible stack heights: 0 vs 1
		//IL_34e6: Incompatible stack heights: 0 vs 1
		//IL_34f0: Incompatible stack heights: 0 vs 1
		//IL_34fa: Incompatible stack heights: 0 vs 1
		//IL_3504: Incompatible stack heights: 0 vs 1
		//IL_350e: Incompatible stack heights: 0 vs 1
		int num = 361;
		int num6 = default(int);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		BinaryReader binaryReader = default(BinaryReader);
		Assembly assembly = default(Assembly);
		IntPtr intPtr3 = default(IntPtr);
		int num8 = default(int);
		int num10 = default(int);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] rgbKey = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array4 = default(byte[]);
		int num9 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		string text = default(string);
		byte[] array7 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_2753:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 189:
						break;
					case 17:
						num6 = 87 + 46;
						num2 = 51;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_004b: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 167;
					case 179:
						num7 = 86 - 14;
						num3 = 125;
						continue;
					case 253:
						array2[18] = (byte)num5;
						num2 = 345;
						goto IL_2753;
					case 261:
						array2[1] = (byte)num5;
						num2 = 277;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 105;
					case 105:
						array5[13] = array6[6];
						num = 115;
						goto end_IL_2753;
					case 154:
						array3[4] = (byte)num4;
						num2 = 308;
						if (true)
						{
							goto IL_2753;
						}
						goto case 249;
					case 249:
						array2[3] = 124;
						num2 = 182;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_00f9: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 171;
					case 296:
						num5 = 22 + 4;
						num = 244;
						goto end_IL_2753;
					case 280:
						num6 = 113 + 69;
						num = 250;
						goto end_IL_2753;
					case 12:
						if (array6.Length > 0)
						{
							num = 22;
							goto end_IL_2753;
						}
						goto case 13;
					case 331:
						num7 = 161 - 38;
						num2 = 54;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 45;
					case 45:
						memoryStream.ToArray();
						MT8Leg6Ro = (byte[])/*Error near IL_016e: Stack underflow*/;
						num2 = 238;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0181: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 27;
					case 27:
						_ = typeof(HIqNmi47ta6wQLwpfy);
						_ = ((Type)/*Error near IL_3158: Stack underflow*/).Assembly;
						((Assembly)/*Error near IL_3162: Stack underflow*/).GetManifestResourceStream("aee3009f-1045-4408-b1af-5f618829266c");
						new BinaryReader((Stream)/*Error near IL_316c: Stack underflow*/);
						binaryReader = (BinaryReader)/*Error near IL_01a0: Stack underflow*/;
						num3 = 108;
						continue;
					case 160:
						array3[1] = (byte)num6;
						num2 = 81;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 359;
					case 359:
						array3[5] = (byte)num6;
						num = 85;
						goto end_IL_2753;
					case 71:
						num5 = 188 + 59;
						num = 117;
						goto end_IL_2753;
					case 97:
						array2[11] = (byte)num7;
						num2 = 4;
						if (true)
						{
							goto IL_2753;
						}
						goto case 81;
					case 81:
						num4 = 212 - 70;
						num2 = 240;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0237: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 166;
					case 166:
						array2[31] = (byte)num5;
						num = 176;
						goto end_IL_2753;
					case 247:
						num7 = 136 + 37;
						num3 = 279;
						continue;
					case 78:
						array2[19] = 192;
						num3 = 32;
						continue;
					case 91:
						num6 = 180 + 24;
						num3 = 365;
						continue;
					case 207:
						array2[15] = 8;
						num3 = 213;
						continue;
					case 226:
						array3[10] = (byte)num4;
						num = 101;
						goto end_IL_2753;
					case 168:
						array3[8] = (byte)num4;
						num3 = 91;
						continue;
					case 24:
						array3[10] = 120;
						num2 = 26;
						goto IL_2753;
					case 64:
						num5 = 34 + 31;
						num = 74;
						goto end_IL_2753;
					case 340:
						array2[24] = 217;
						num3 = 34;
						continue;
					case 128:
						num7 = 202 - 67;
						num3 = 252;
						continue;
					case 222:
						if (array6 != null)
						{
							num3 = 12;
							continue;
						}
						goto case 13;
					case 273:
						array3[4] = (byte)num6;
						num2 = 256;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0395: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 123;
					case 123:
						num5 = 99 + 116;
						num = 201;
						goto end_IL_2753;
					case 258:
						num6 = 173 - 57;
						num2 = 103;
						if (true)
						{
							goto IL_2753;
						}
						goto case 235;
					case 235:
						array2[9] = 201;
						num2 = 232;
						if (true)
						{
							goto IL_2753;
						}
						goto case 54;
					case 54:
						array2[1] = (byte)num7;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_040d: Stack underflow*/ == 0)
						{
							num3 = 28;
							continue;
						}
						num2 = 192;
						goto IL_2753;
					case 8:
						num5 = 151 - 50;
						num2 = 23;
						goto IL_2753;
					case 202:
						IkNnwayHq = new string[MT8Leg6Ro.Length / 4 + 1];
						num3 = 376;
						continue;
					case 310:
						array2[8] = 168;
						num3 = 325;
						continue;
					case 289:
						assembly.GetModules();
						Marshal.GetHINSTANCE((Module)((object[])/*Error near IL_047c: Stack underflow*/)[0]);
						intPtr3 = (IntPtr)/*Error near IL_0483: Stack underflow*/;
						num3 = 216;
						continue;
					case 172:
						array2[26] = (byte)num7;
						num3 = 342;
						continue;
					case 37:
						num7 = 137 - 45;
						num2 = 299;
						if (true)
						{
							goto IL_2753;
						}
						goto case 53;
					case 53:
						num4 = 89 + 37;
						num3 = 360;
						continue;
					case 87:
						num6 = 41 + 47;
						num = 237;
						goto end_IL_2753;
					case 47:
						array2[3] = 140;
						num3 = 314;
						continue;
					case 325:
						array2[8] = 164;
						num3 = 100;
						continue;
					case 25:
						num7 = 197 - 65;
						num2 = 89;
						goto IL_2753;
					case 159:
						array2[6] = (byte)num5;
						num = 292;
						goto end_IL_2753;
					case 29:
						array2[5] = 154;
						num = 177;
						goto end_IL_2753;
					case 103:
						array3[13] = (byte)num6;
						num2 = 58;
						if (true)
						{
							goto IL_2753;
						}
						goto case 72;
					case 72:
						array2[10] = (byte)num5;
						num3 = 43;
						continue;
					case 252:
						array2[14] = (byte)num7;
						num2 = 208;
						goto IL_2753;
					case 290:
						array2[9] = 174;
						num2 = 234;
						goto IL_2753;
					case 77:
						array2[21] = 40;
						num3 = 334;
						continue;
					case 254:
						array2[17] = 91;
						num2 = 107;
						if (true)
						{
							goto IL_2753;
						}
						goto case 373;
					case 373:
						array3[0] = (byte)num6;
						num3 = 170;
						continue;
					case 294:
						array2[14] = (byte)num7;
						num = 212;
						goto end_IL_2753;
					case 147:
						array2[1] = (byte)num5;
						num3 = 302;
						continue;
					case 213:
						num5 = 132 + 71;
						num = 233;
						goto end_IL_2753;
					case 96:
						array2[23] = 130;
						num2 = 165;
						goto IL_2753;
					case 39:
						num7 = 100 + 26;
						num = 309;
						goto end_IL_2753;
					case 362:
						array3[0] = (byte)num6;
						num2 = 62;
						goto IL_2753;
					case 120:
						array3[1] = 84;
						num2 = 17;
						goto IL_2753;
					case 339:
						num5 = 221 - 73;
						num = 114;
						goto end_IL_2753;
					case 301:
						array2[7] = 107;
						num3 = 310;
						continue;
					case 321:
						num4 = 105 + 10;
						num = 371;
						goto end_IL_2753;
					case 351:
						array2[7] = 110;
						num = 301;
						goto end_IL_2753;
					case 299:
						array2[28] = (byte)num7;
						num2 = 270;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 192;
					case 192:
					case 215:
						num6 = 221 - 73;
						num2 = 362;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_07c9: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 219;
					case 219:
						array3[9] = (byte)num4;
						num = 73;
						goto end_IL_2753;
					case 118:
						array3[11] = 252;
						num3 = 134;
						continue;
					case 164:
						_ = tFDCLZFvx;
						new IntPtr(BLDWEDXP2 + num8 + 4);
						Convert.ToUInt32(num10);
						sv0k4vbiU((IntPtr)/*Error near IL_31d0: Stack underflow*/, (IntPtr)/*Error near IL_31d0: Stack underflow*/, (byte[])/*Error near IL_31d0: Stack underflow*/, (uint)/*Error near IL_31d0: Stack underflow*/, out afKiyxWuM);
						num3 = 209;
						continue;
					case 317:
						num4 = 164 - 54;
						num3 = 15;
						continue;
					case 1:
						num4 = 113 + 97;
						num2 = 129;
						goto IL_2753;
					case 312:
						num4 = 123 - 31;
						num = 241;
						goto end_IL_2753;
					case 143:
						goto end_IL_2757;
					case 82:
						array3[5] = (byte)num6;
						num3 = 10;
						continue;
					case 246:
						array3[6] = (byte)num4;
						num = 93;
						goto end_IL_2753;
					case 102:
						array3[2] = 49;
						num3 = 230;
						continue;
					case 48:
						array2[10] = (byte)num7;
						num3 = 288;
						continue;
					case 250:
						array3[12] = (byte)num6;
						num = 258;
						goto end_IL_2753;
					case 323:
						array3[6] = 90;
						num2 = 370;
						if (true)
						{
							goto IL_2753;
						}
						goto case 218;
					case 218:
						array2[19] = 3;
						num3 = 30;
						continue;
					case 109:
						num7 = 223 - 74;
						num3 = 132;
						continue;
					case 355:
						num7 = 93 + 25;
						num2 = 275;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_09ce: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 217;
					case 217:
						array2[16] = (byte)num7;
						num = 322;
						goto end_IL_2753;
					case 206:
					{
						YZf0tMn4q0DHWm43r6 yZf0tMn4q0DHWm43r = (YZf0tMn4q0DHWm43r6)16;
						num2 = 112;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_09fd: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 160;
					}
					case 256:
						array3[4] = 158;
						num2 = 126;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 330;
					case 330:
						array3[2] = (byte)num4;
						num2 = 320;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0a47: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 216;
					case 216:
						intPtr3.ToInt32();
						BLDWEDXP2 = (int)/*Error near IL_0a53: Stack underflow*/;
						num3 = 350;
						continue;
					case 155:
						array2[27] = (byte)num5;
						num = 37;
						goto end_IL_2753;
					case 336:
						num4 = 115 + 69;
						num = 257;
						goto end_IL_2753;
					case 74:
						array2[6] = (byte)num5;
						num2 = 113;
						goto IL_2753;
					case 332:
						array2[28] = (byte)num7;
						num2 = 25;
						goto IL_2753;
					case 151:
						array2[30] = 123;
						num2 = 158;
						if (true)
						{
							goto IL_2753;
						}
						goto case 22;
					case 22:
						array5[1] = array6[0];
						num2 = 338;
						goto IL_2753;
					case 364:
						array2[24] = 106;
						num3 = 283;
						continue;
					case 75:
						num4 = 66 + 112;
						num2 = 148;
						goto IL_2753;
					case 133:
						symmetricAlgorithm.CreateDecryptor(rgbKey, array5);
						transform = (ICryptoTransform)/*Error near IL_0b46: Stack underflow*/;
						num3 = 259;
						continue;
					case 5:
						array2[4] = 135;
						num2 = 369;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0b78: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 144;
					case 144:
						num6 = 195 - 75;
						num2 = 7;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0b9a: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 36;
					case 122:
						cryptoStream.Close();
						num2 = 92;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0bf7: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 60;
					case 354:
						array4 = new byte[4];
						num2 = 197;
						if (true)
						{
							goto IL_2753;
						}
						goto case 15;
					case 15:
						array3[12] = (byte)num4;
						num3 = 245;
						continue;
					case 210:
						array3[14] = 110;
						num = 348;
						goto end_IL_2753;
					case 291:
						num5 = 90 + 50;
						num2 = 63;
						goto IL_2753;
					case 276:
						array3[7] = 120;
						num3 = 144;
						continue;
					case 14:
						num5 = 59 + 90;
						num2 = 146;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 145;
					case 145:
						num5 = 247 - 82;
						num2 = 19;
						goto IL_2753;
					case 370:
						array3[6] = 97;
						num3 = 374;
						continue;
					case 190:
						num6 = 88 + 39;
						num2 = 119;
						goto IL_2753;
					case 232:
						array2[9] = 229;
						num2 = 290;
						goto IL_2753;
					case 239:
						array2[30] = 109;
						num = 286;
						goto end_IL_2753;
					case 187:
						VlaTGryG3[num9] = ThNKReJoW;
						num2 = 183;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0d5f: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 88;
					case 88:
						num4 = 68 + 53;
						num2 = 330;
						if (true)
						{
							goto IL_2753;
						}
						goto case 140;
					case 140:
						num4 = 129 + 94;
						num3 = 16;
						continue;
					case 137:
						array5[9] = array6[4];
						num2 = 281;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0db1: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 10;
					case 10:
						num4 = 182 - 60;
						num2 = 225;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0dd3: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 265;
					case 265:
						array3[2] = 79;
						num2 = 214;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 245;
					case 245:
						array3[12] = 112;
						num2 = 56;
						goto IL_2753;
					case 38:
						array2[30] = 67;
						num3 = 353;
						continue;
					case 85:
						num6 = 107 + 97;
						num3 = 82;
						continue;
					case 50:
						num7 = 107 + 62;
						num = 294;
						goto end_IL_2753;
					case 67:
						array2[16] = (byte)num7;
						num2 = 254;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0e8c: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 240;
					case 287:
						num5 = 28 + 24;
						num3 = 156;
						continue;
					case 30:
						num7 = 117 + 8;
						num3 = 375;
						continue;
					case 152:
						array2[11] = (byte)num7;
						num3 = 169;
						continue;
					case 383:
						array2[19] = 166;
						num = 218;
						goto end_IL_2753;
					case 274:
						num5 = 206 - 117;
						num = 349;
						goto end_IL_2753;
					case 175:
						num7 = 7 + 23;
						num = 195;
						goto end_IL_2753;
					case 153:
						array2[19] = (byte)num7;
						num3 = 383;
						continue;
					case 165:
						array2[23] = 170;
						num2 = 179;
						goto IL_2753;
					case 182:
						num7 = 88 - 81;
						num3 = 327;
						continue;
					case 31:
						num5 = 128 - 42;
						num3 = 150;
						continue;
					case 322:
						num7 = 58 - 53;
						num2 = 67;
						if (true)
						{
							goto IL_2753;
						}
						goto case 184;
					case 184:
						array3[1] = (byte)num4;
						num2 = 347;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0fd8: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 95;
					case 4:
						array2[12] = 54;
						num2 = 131;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1005: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 79;
					case 79:
						array2[24] = 69;
						num = 340;
						goto end_IL_2753;
					case 201:
						array2[28] = (byte)num5;
						num3 = 311;
						continue;
					case 304:
						num6 = 199 - 66;
						num2 = 273;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_105e: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 69;
					case 69:
						array2[5] = (byte)num5;
						num3 = 64;
						continue;
					case 350:
						assembly.GetModules();
						Marshal.GetHINSTANCE((Module)((object[])/*Error near IL_107f: Stack underflow*/)[0]);
						intPtr2 = (IntPtr)/*Error near IL_1086: Stack underflow*/;
						num2 = 106;
						goto IL_2753;
					case 231:
						array2[22] = 146;
						num3 = 96;
						continue;
					case 361:
						if (MT8Leg6Ro.Length == 0)
						{
							num3 = 27;
							continue;
						}
						goto case 186;
					case 268:
						array2[16] = 124;
						num3 = 44;
						continue;
					case 329:
						array3[11] = (byte)num4;
						num = 321;
						goto end_IL_2753;
					case 214:
						num4 = 95 + 87;
						num2 = 260;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1137: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 337;
					case 303:
						num7 = 139 - 46;
						num2 = 316;
						goto IL_2753;
					case 23:
						array2[21] = (byte)num5;
						num3 = 77;
						continue;
					case 349:
						array2[25] = (byte)num5;
						num3 = 368;
						continue;
					case 191:
					case 363:
						BitConverter.ToInt32(array4, 0);
						num10 = (int)/*Error near IL_1193: Stack underflow*/;
						num2 = 95;
						goto IL_2753;
					case 374:
						num4 = 206 - 68;
						num2 = 0;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_11c3: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 233;
					case 233:
						array2[15] = (byte)num5;
						num = 242;
						goto end_IL_2753;
					case 200:
						array5 = array3;
						num = 293;
						goto end_IL_2753;
					case 237:
						array3[8] = (byte)num6;
						num = 6;
						goto end_IL_2753;
					case 33:
						new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						cryptoStream = (CryptoStream)/*Error near IL_120e: Stack underflow*/;
						num2 = 178;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1221: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 243;
					case 89:
						array2[29] = (byte)num7;
						num2 = 196;
						if (true)
						{
							goto IL_2753;
						}
						goto case 212;
					case 212:
						array2[14] = 112;
						num2 = 194;
						goto IL_2753;
					case 84:
						num6 = 53 + 45;
						num2 = 373;
						if (true)
						{
							goto IL_2753;
						}
						goto case 262;
					case 262:
						num5 = 45 + 20;
						num3 = 166;
						continue;
					case 162:
						ThNKReJoW++;
						num2 = 384;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 368;
					case 368:
						array2[26] = 169;
						num = 326;
						goto end_IL_2753;
					case 333:
						array3[13] = 95;
						num = 140;
						goto end_IL_2753;
					case 7:
						array3[7] = (byte)num6;
						num = 87;
						goto end_IL_2753;
					case 204:
						array2[20] = (byte)num5;
						num2 = 315;
						if (true)
						{
							goto IL_2753;
						}
						goto case 18;
					case 18:
						num7 = 196 - 65;
						num2 = 3;
						if (true)
						{
							goto IL_2753;
						}
						goto case 141;
					case 141:
						num6 = 198 - 66;
						num3 = 359;
						continue;
					case 298:
						array3[2] = (byte)num4;
						num = 88;
						goto end_IL_2753;
					case 382:
						array3[10] = (byte)num6;
						num = 366;
						goto end_IL_2753;
					case 297:
						num4 = 112 - 93;
						num2 = 154;
						if (true)
						{
							goto IL_2753;
						}
						goto case 283;
					case 283:
						num7 = 43 + 25;
						num2 = 99;
						if (true)
						{
							goto IL_2753;
						}
						goto case 111;
					case 111:
						num7 = 52 + 84;
						num2 = 180;
						if (true)
						{
							goto IL_2753;
						}
						goto case 306;
					case 306:
						memoryStream.Close();
						num2 = 122;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 381;
					case 381:
						symmetricAlgorithm.Mode = CipherMode.CBC;
						num3 = 133;
						continue;
					case 205:
						array5[5] = array6[2];
						num2 = 229;
						if (true)
						{
							goto IL_2753;
						}
						goto case 65;
					case 65:
						array3[4] = (byte)num4;
						num2 = 304;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 132;
					case 132:
						array2[19] = (byte)num7;
						num = 78;
						goto end_IL_2753;
					case 194:
						num7 = 180 - 60;
						num2 = 193;
						if (true)
						{
							goto IL_2753;
						}
						goto case 342;
					case 342:
						array2[26] = 211;
						num3 = 18;
						continue;
					case 83:
						num4 = 51 + 90;
						num3 = 329;
						continue;
					case 326:
						num7 = 126 - 42;
						num3 = 172;
						continue;
					case 311:
						num7 = 118 - 66;
						num3 = 332;
						continue;
					case 379:
						array2[10] = 35;
						num = 127;
						goto end_IL_2753;
					case 366:
						num4 = 168 - 56;
						num = 346;
						goto end_IL_2753;
					case 146:
						array2[12] = (byte)num5;
						num3 = 198;
						continue;
					case 242:
						num7 = 217 - 72;
						num2 = 380;
						goto IL_2753;
					case 136:
						array2[20] = (byte)num7;
						num2 = 352;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_158e: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 334;
					case 334:
						num7 = 164 - 54;
						num = 269;
						goto end_IL_2753;
					case 16:
						array3[13] = (byte)num4;
						num2 = 336;
						goto IL_2753;
					case 95:
						array4 = new byte[num10];
						num2 = 130;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_15df: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 161;
					case 161:
						array2[18] = 163;
						num3 = 247;
						continue;
					case 288:
						num5 = 149 - 49;
						num = 72;
						goto end_IL_2753;
					case 188:
						_ = tFDCLZFvx == IntPtr.Zero;
						if ((int)/*Error near IL_162b: Stack underflow*/ != 0)
						{
							num = 206;
							goto end_IL_2753;
						}
						goto case 354;
					case 193:
						array2[14] = (byte)num7;
						num2 = 128;
						goto IL_2753;
					case 293:
						_ = typeof(HIqNmi47ta6wQLwpfy);
						_ = ((Type)/*Error near IL_3342: Stack underflow*/).Assembly;
						((Assembly)/*Error near IL_334c: Stack underflow*/).GetName();
						((AssemblyName)/*Error near IL_3356: Stack underflow*/).GetPublicKeyToken();
						array6 = (byte[])/*Error near IL_166c: Stack underflow*/;
						num3 = 222;
						continue;
					case 108:
						_ = binaryReader.BaseStream;
						((Stream)/*Error near IL_336a: Stack underflow*/).Position = 0L;
						num2 = 227;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1696: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 49;
					case 49:
						num5 = 226 - 75;
						num = 204;
						goto end_IL_2753;
					case 195:
						array2[7] = (byte)num7;
						num = 351;
						goto end_IL_2753;
					case 282:
						array2[28] = (byte)num5;
						num3 = 123;
						continue;
					case 183:
						((string[])IkNnwayHq)[ThNKReJoW] = text;
						num3 = 162;
						continue;
					case 229:
						array5[7] = array6[3];
						num = 137;
						goto end_IL_2753;
					case 328:
						array2[15] = 201;
						num3 = 11;
						continue;
					case 116:
						num4 = 99 - 5;
						num3 = 246;
						continue;
					case 335:
						array3[11] = 148;
						num2 = 83;
						goto IL_2753;
					case 375:
						array2[20] = (byte)num7;
						num3 = 49;
						continue;
					case 319:
						num5 = 76 + 52;
						num3 = 57;
						continue;
					case 327:
						array2[3] = (byte)num7;
						num2 = 5;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_17d3: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 96;
					case 275:
						array2[0] = (byte)num7;
						num3 = 41;
						continue;
					case 41:
						num5 = 42 + 86;
						num3 = 90;
						continue;
					case 46:
						array2[7] = (byte)num5;
						num = 175;
						goto end_IL_2753;
					case 70:
						num7 = 141 - 47;
						num2 = 377;
						goto IL_2753;
					case 86:
						array3[15] = 118;
						num2 = 367;
						goto IL_2753;
					case 196:
						array2[29] = 125;
						num3 = 61;
						continue;
					case 347:
						num4 = 116 + 15;
						num = 298;
						goto end_IL_2753;
					case 178:
						cryptoStream.Write(array7, 0, array7.Length);
						num2 = 255;
						goto IL_2753;
					case 66:
						_ = typeof(HIqNmi47ta6wQLwpfy);
						_ = ((Type)/*Error near IL_33b0: Stack underflow*/).Assembly;
						assembly = (Assembly)/*Error near IL_18c4: Stack underflow*/;
						num2 = 211;
						goto IL_2753;
					case 185:
						num6 = 6 + 118;
						num3 = 160;
						continue;
					case 60:
						num5 = 45 + 82;
						num = 224;
						goto end_IL_2753;
					case 43:
						array2[10] = 122;
						num2 = 379;
						if (true)
						{
							goto IL_2753;
						}
						goto case 124;
					case 124:
						array2[31] = 109;
						num2 = 110;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 267;
					case 267:
						array2[13] = (byte)num5;
						num = 31;
						goto end_IL_2753;
					case 243:
						num7 = 190 - 63;
						num = 153;
						goto end_IL_2753;
					case 277:
						num5 = 205 - 68;
						num = 147;
						goto end_IL_2753;
					case 2:
					case 209:
						CCD3qYiN4(array4);
						array = (byte[])/*Error near IL_199f: Stack underflow*/;
						num = 139;
						goto end_IL_2753;
					case 115:
						array5[15] = array6[7];
						num3 = 13;
						continue;
					case 338:
						array5[3] = array6[1];
						num3 = 205;
						continue;
					case 56:
						num4 = 11 + 8;
						num2 = 104;
						if (true)
						{
							goto IL_2753;
						}
						goto case 234;
					case 234:
						num7 = 67 + 101;
						num3 = 48;
						continue;
					case 269:
						array2[22] = (byte)num7;
						num2 = 319;
						if (true)
						{
							goto IL_2753;
						}
						goto case 208;
					case 208:
						array2[14] = 77;
						num2 = 356;
						goto IL_2753;
					case 3:
						array2[27] = (byte)num7;
						num3 = 98;
						continue;
					case 117:
						array2[29] = (byte)num5;
						num2 = 151;
						if (true)
						{
							goto IL_2753;
						}
						goto case 257;
					case 257:
						array3[14] = (byte)num4;
						num = 210;
						goto end_IL_2753;
					case 101:
						array3[10] = 145;
						num3 = 9;
						continue;
					case 110:
						rgbKey = array2;
						num = 157;
						goto end_IL_2753;
					case 313:
						array2[2] = 186;
						num2 = 47;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 131;
					case 131:
						array2[12] = 145;
						num = 14;
						goto end_IL_2753;
					case 286:
						array2[30] = 119;
						num = 38;
						goto end_IL_2753;
					case 80:
						num6 = 222 - 74;
						num = 221;
						goto end_IL_2753;
					case 367:
						array3[15] = 152;
						num = 200;
						goto end_IL_2753;
					case 302:
						array2[1] = 58;
						num3 = 331;
						continue;
					case 224:
						array2[3] = (byte)num5;
						num3 = 249;
						continue;
					case 309:
						array2[0] = (byte)num7;
						num3 = 272;
						continue;
					case 378:
						array3[0] = 70;
						num2 = 84;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 129;
					case 129:
						array3[6] = (byte)num4;
						num3 = 323;
						continue;
					case 94:
						array3[3] = 113;
						num2 = 35;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1c0b: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 171;
					case 171:
						array2[5] = 92;
						num3 = 251;
						continue;
					case 320:
						array3[2] = 142;
						num2 = 102;
						goto IL_2753;
					case 223:
						array2[0] = (byte)num7;
						num2 = 263;
						goto IL_2753;
					case 227:
					{
						_ = binaryReader.BaseStream;
						_ = ((Stream)/*Error near IL_33d8: Stack underflow*/).Length;
						int count = (int)/*Error near IL_1c76: Stack underflow*/;
						((BinaryReader)/*Error near IL_33e2: Stack underflow*/).ReadBytes(count);
						array7 = (byte[])/*Error near IL_1c7c: Stack underflow*/;
						num3 = 135;
						continue;
					}
					case 337:
						num6 = 236 - 78;
						num3 = 357;
						continue;
					case 134:
						array3[12] = 17;
						num = 80;
						goto end_IL_2753;
					case 135:
						array2 = new byte[32];
						num3 = 355;
						continue;
					case 365:
						array3[8] = (byte)num6;
						num2 = 199;
						if (true)
						{
							goto IL_2753;
						}
						goto case 76;
					case 76:
						array2[21] = 98;
						num = 324;
						goto end_IL_2753;
					case 174:
						array3[9] = (byte)num6;
						num3 = 75;
						continue;
					case 228:
						array2[20] = 170;
						num3 = 76;
						continue;
					case 9:
						num6 = 185 + 51;
						num3 = 382;
						continue;
					case 99:
						array2[24] = (byte)num7;
						num3 = 79;
						continue;
					case 173:
						num5 = 167 - 55;
						num2 = 253;
						if (true)
						{
							goto IL_2753;
						}
						goto case 42;
					case 42:
						array2[13] = 197;
						num = 291;
						goto end_IL_2753;
					case 68:
						array2[11] = (byte)num7;
						num2 = 163;
						if (true)
						{
							goto IL_2753;
						}
						goto case 26;
					case 26:
						array3[10] = 66;
						num2 = 149;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 36;
					case 36:
						num7 = 27 - 13;
						num2 = 59;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1e1a: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 11;
					case 11:
						array2[15] = 66;
						num3 = 287;
						continue;
					case 52:
						num5 = 134 - 18;
						num3 = 155;
						continue;
					case 107:
						num7 = 169 - 56;
						num = 189;
						goto end_IL_2753;
					case 241:
						array3[9] = (byte)num4;
						num = 24;
						goto end_IL_2753;
					case 353:
						array2[31] = 43;
						num2 = 262;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1eab: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 162;
					case 21:
						array2[7] = 130;
						num3 = 300;
						continue;
					case 119:
						array3[5] = (byte)num6;
						num = 1;
						goto end_IL_2753;
					case 199:
						num4 = 176 - 58;
						num2 = 219;
						goto IL_2753;
					case 377:
						array2[2] = (byte)num7;
						num3 = 313;
						continue;
					case 236:
						array2[31] = 138;
						num2 = 124;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1f44: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 149;
					case 149:
						num4 = 84 + 107;
						num = 226;
						goto end_IL_2753;
					case 255:
						cryptoStream.FlushFinalBlock();
						num2 = 45;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 170;
					case 170:
						array3[0] = 111;
						num2 = 167;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1f9b: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 163;
					case 163:
						num7 = 66 + 63;
						num = 97;
						goto end_IL_2753;
					case 281:
						array5[11] = array6[5];
						num3 = 105;
						continue;
					case 376:
						VlaTGryG3 = new int[MT8Leg6Ro.Length / 4 + 1];
						num2 = 306;
						goto IL_2753;
					case 180:
						array2[15] = (byte)num7;
						num = 328;
						goto end_IL_2753;
					case 348:
						num4 = 134 - 97;
						num = 343;
						goto end_IL_2753;
					case 198:
						num5 = 74 + 83;
						num2 = 372;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2062: Stack underflow*/ == 0)
						{
							goto case 130;
						}
						goto IL_2753;
					case 248:
						array2[17] = 107;
						num3 = 173;
						continue;
					case 203:
						array3[5] = 127;
						num2 = 190;
						goto IL_2753;
					case 220:
						return ((string[])IkNnwayHq)[VlaTGryG3[num9]];
					case 278:
						num6 = 72 + 121;
						num = 266;
						goto end_IL_2753;
					case 148:
						array3[9] = (byte)num4;
						num = 312;
						goto end_IL_2753;
					case 295:
						array3[15] = 166;
						num2 = 285;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 126;
					case 126:
						array3[4] = 108;
						num = 297;
						goto end_IL_2753;
					case 186:
						num9 = _0020 / 4;
						num = 143;
						goto end_IL_2753;
					case 92:
						binaryReader.Close();
						num2 = 66;
						goto IL_2753;
					case 315:
						num7 = 191 - 63;
						num2 = 136;
						goto IL_2753;
					case 279:
						array2[18] = (byte)num7;
						num3 = 109;
						continue;
					case 318:
						array3[7] = (byte)num6;
						num2 = 276;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_21c1: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 59;
					case 59:
						array2[4] = (byte)num7;
						num3 = 40;
						continue;
					case 352:
						array2[20] = 124;
						num = 228;
						goto end_IL_2753;
					case 307:
						_ = tFDCLZFvx;
						new IntPtr(BLDWEDXP2 + num8);
						sv0k4vbiU((IntPtr)/*Error near IL_346e: Stack underflow*/, (IntPtr)/*Error near IL_346e: Stack underflow*/, array4, 4u, out afKiyxWuM);
						num2 = 191;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 158;
					case 158:
						array2[30] = 166;
						num3 = 239;
						continue;
					case 380:
						array2[16] = (byte)num7;
						num2 = 268;
						goto IL_2753;
					case 19:
						array2[4] = (byte)num5;
						num2 = 36;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 211;
					case 125:
						array2[23] = (byte)num7;
						num = 364;
						goto end_IL_2753;
					case 112:
						_ = 1;
						Process.GetCurrentProcess();
						_ = ((Process)/*Error near IL_348c: Stack underflow*/).Id;
						SHHPxcicR((uint)/*Error near IL_3496: Stack underflow*/, (int)/*Error near IL_3496: Stack underflow*/, (uint)/*Error near IL_3496: Stack underflow*/);
						tFDCLZFvx = (IntPtr)/*Error near IL_22c3: Stack underflow*/;
						num2 = 354;
						if (true)
						{
							goto IL_2753;
						}
						goto case 0;
					case 0:
						array3[6] = (byte)num4;
						num3 = 116;
						continue;
					case 369:
						num7 = 57 + 117;
						num = 271;
						goto end_IL_2753;
					case 308:
						array3[5] = 166;
						num = 141;
						goto end_IL_2753;
					case 263:
						num5 = 126 - 42;
						num3 = 261;
						continue;
					case 73:
						num6 = 83 + 111;
						num2 = 174;
						goto IL_2753;
					case 300:
						num5 = 250 - 83;
						num2 = 46;
						goto IL_2753;
					case 240:
						array3[1] = (byte)num4;
						num3 = 120;
						continue;
					case 285:
						array3[15] = 166;
						num3 = 278;
						continue;
					case 157:
						array3 = new byte[16];
						num2 = 378;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 169;
					case 169:
						num7 = 16 + 113;
						num3 = 68;
						continue;
					case 90:
						array2[0] = (byte)num5;
						num3 = 39;
						continue;
					case 221:
						array3[12] = (byte)num6;
						num2 = 317;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_241b: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 127;
					case 127:
						num7 = 17 + 41;
						num2 = 152;
						goto IL_2753;
					case 121:
						array2[3] = (byte)num5;
						num3 = 60;
						continue;
					case 156:
						array2[15] = (byte)num5;
						num3 = 207;
						continue;
					case 324:
						array2[21] = 98;
						num = 8;
						goto end_IL_2753;
					case 305:
						array2[29] = 60;
						num3 = 138;
						continue;
					case 142:
						num5 = 192 - 64;
						num3 = 267;
						continue;
					case 138:
						array2[29] = 26;
						num2 = 71;
						goto IL_2753;
					case 357:
						array3[1] = (byte)num6;
						num2 = 185;
						goto IL_2753;
					case 62:
						num6 = 153 + 68;
						num = 264;
						goto end_IL_2753;
					case 260:
						array3[3] = (byte)num4;
						num = 53;
						goto end_IL_2753;
					case 264:
						array3[0] = (byte)num6;
						num = 337;
						goto end_IL_2753;
					case 181:
						array2[6] = (byte)num7;
						num = 303;
						goto end_IL_2753;
					case 372:
						array2[12] = (byte)num5;
						num = 142;
						goto end_IL_2753;
					case 225:
						array3[5] = (byte)num4;
						num2 = 203;
						goto IL_2753;
					case 106:
						intPtr2.ToInt64();
						CDIZqyEvo = (long)/*Error near IL_259f: Stack underflow*/;
						num2 = 186;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_25b2: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 80;
					case 51:
						array3[1] = (byte)num6;
						num3 = 55;
						continue;
					case 251:
						num5 = 219 + 33;
						num2 = 69;
						goto IL_2753;
					case 244:
						array2[25] = (byte)num5;
						num = 274;
						goto end_IL_2753;
					case 93:
						num6 = 142 - 47;
						num3 = 318;
						continue;
					case 238:
						if (MT8Leg6Ro.Length > 0)
						{
							num = 202;
							goto end_IL_2753;
						}
						goto case 306;
					case 100:
						array2[8] = 253;
						num2 = 235;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 344;
					case 344:
						array2[31] = (byte)num5;
						num3 = 236;
						continue;
					case 104:
						array3[12] = (byte)num4;
						num3 = 280;
						continue;
					case 345:
						array2[18] = 172;
						num3 = 284;
						continue;
					case 20:
					case 28:
						array2[2] = 85;
						num3 = 70;
						continue;
					case 34:
						array2[25] = 191;
						num2 = 296;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 358;
					case 358:
						array2[6] = 229;
						num2 = 339;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2712: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 376;
					case 176:
						num5 = 231 - 77;
						num = 344;
						goto end_IL_2753;
					case 61:
						array2[29] = 132;
						goto case 305;
					default:
						num2 = 305;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2d73: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 32;
					case 32:
						array2[19] = 163;
						num2 = 243;
						goto IL_2753;
					case 360:
						array3[3] = (byte)num4;
						num2 = 94;
						goto IL_2753;
					case 230:
						array3[2] = 142;
						num2 = 265;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2dda: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 343;
					case 343:
						array3[14] = (byte)num4;
						num2 = 295;
						if (true)
						{
							goto IL_2753;
						}
						goto case 270;
					case 270:
						num5 = 38 + 12;
						num2 = 282;
						goto IL_2753;
					case 346:
						array3[11] = (byte)num4;
						num2 = 335;
						goto IL_2753;
					case 58:
						array3[13] = 106;
						num = 333;
						goto end_IL_2753;
					case 316:
						array2[6] = (byte)num7;
						num3 = 358;
						continue;
					case 356:
						array2[14] = 142;
						num2 = 111;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2ea0: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 355;
					case 371:
						array3[11] = (byte)num4;
						num2 = 118;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 271;
					case 271:
						array2[4] = (byte)num7;
						num2 = 145;
						goto IL_2753;
					case 284:
						array2[18] = 161;
						num2 = 161;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2f06: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 85;
					case 167:
						array3[0] = 59;
						goto case 192;
					case 177:
						num5 = 103 + 59;
						num2 = 341;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 44;
					case 44:
						num7 = 29 + 32;
						num2 = 217;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2f74: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 341;
					case 341:
						array2[5] = (byte)num5;
						num = 171;
						goto end_IL_2753;
					case 113:
						num5 = 249 - 83;
						num2 = 159;
						goto IL_2753;
					case 35:
						num4 = 36 + 77;
						num = 65;
						goto end_IL_2753;
					case 57:
						array2[22] = (byte)num5;
						num2 = 231;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2fe3: Stack underflow*/ != 0)
						{
							goto IL_2753;
						}
						goto case 63;
					case 63:
						array2[13] = (byte)num5;
						num2 = 50;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_3004: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 272;
					case 272:
						num7 = 207 + 5;
						num2 = 223;
						goto IL_2753;
					case 40:
						array2[5] = 167;
						num3 = 29;
						continue;
					case 6:
						num4 = 237 - 79;
						num2 = 168;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 98;
					case 98:
						array2[27] = 150;
						num = 52;
						goto end_IL_2753;
					case 292:
						num7 = 197 - 65;
						num3 = 181;
						continue;
					case 114:
						array2[7] = (byte)num5;
						num3 = 21;
						continue;
					case 314:
						num5 = 206 - 68;
						num2 = 121;
						if (true)
						{
							goto IL_2753;
						}
						goto case 150;
					case 150:
						array2[13] = (byte)num5;
						num2 = 42;
						if (0 == 0)
						{
							goto IL_2753;
						}
						goto case 266;
					case 266:
						array3[15] = (byte)num6;
						num2 = 86;
						goto IL_2753;
					case 55:
						num4 = 130 + 115;
						num = 184;
						goto end_IL_2753;
					case 384:
						return text;
					case 197:
						goto IL_32bb;
					case 130:
						_ = IntPtr.Size;
						if ((int)/*Error near IL_155f: Stack underflow*/ != 4)
						{
							_ = tFDCLZFvx;
							new IntPtr(CDIZqyEvo + num8 + 4);
							Convert.ToUInt32(num10);
							sv0k4vbiU((IntPtr)/*Error near IL_3248: Stack underflow*/, (IntPtr)/*Error near IL_3248: Stack underflow*/, (byte[])/*Error near IL_3248: Stack underflow*/, (uint)/*Error near IL_3248: Stack underflow*/, out afKiyxWuM);
							num2 = 2;
							if (true)
							{
								goto IL_2753;
							}
							goto case 122;
						}
						num2 = 164;
						goto IL_2753;
					case 13:
						udTunHYcv();
						symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_1702: Stack underflow*/;
						num2 = 381;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1715: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 229;
					case 139:
					{
						_ = Encoding.Unicode;
						byte[] bytes = array;
						IntPtr intPtr = (nint)array.LongLength;
						((Encoding)/*Error near IL_3428: Stack underflow*/).GetString(bytes, 0, (int)(nint)intPtr);
						text = (string)/*Error near IL_202d: Stack underflow*/;
						num2 = 187;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2040: Stack underflow*/ == 0)
						{
							goto IL_2753;
						}
						goto case 198;
					}
					case 211:
						_ = IntPtr.Size;
						if ((int)/*Error near IL_228a: Stack underflow*/ == 4)
						{
							num3 = 289;
							continue;
						}
						goto case 350;
					case 259:
						new MemoryStream();
						memoryStream = (MemoryStream)/*Error near IL_2e56: Stack underflow*/;
						num = 33;
						goto end_IL_2753;
					}
					array2[17] = (byte)num7;
					num = 248;
					goto end_IL_2753;
					IL_32bb:
					_ = IntPtr.Size;
					if ((int)/*Error near IL_10be: Stack underflow*/ != 4)
					{
						_ = tFDCLZFvx;
						new IntPtr(CDIZqyEvo + num8);
						sv0k4vbiU((IntPtr)/*Error near IL_31e4: Stack underflow*/, (IntPtr)/*Error near IL_31e4: Stack underflow*/, array4, 4u, out afKiyxWuM);
						num2 = 363;
						goto IL_2753;
					}
					num3 = 307;
					continue;
					end_IL_2757:
					break;
				}
				if (VlaTGryG3[num9] > 0)
				{
					num2 = 220;
					continue;
				}
				BitConverter.ToInt32(MT8Leg6Ro, _0020);
				num8 = (int)/*Error near IL_20ca: Stack underflow*/;
				num = 188;
				break;
				continue;
				end_IL_2753:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string vJEcqxAEl(string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(_0020);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	private static extern int HTadVgrdU(IntPtr _0020, int _0020, int _0020, ref int _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[nTiUWRPw4mCFqxfA7R(typeof(HIqNmi47ta6wQLwpfy_002FnTiUWRPw4mCFqxfA7R_002FdbYnXxZRxVvAxO5NqK<object>[]))]
	static unsafe void Rb22303oj()
	{
		//Discarded unreachable code: IL_265e, IL_3b57
		//IL_01f0: Invalid comparison between Unknown and I4
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3684: Incompatible stack heights: 0 vs 1
		//IL_368e: Incompatible stack heights: 0 vs 1
		//IL_3698: Incompatible stack heights: 0 vs 1
		//IL_36a2: Incompatible stack heights: 0 vs 1
		//IL_36ac: Incompatible stack heights: 0 vs 1
		//IL_36b6: Incompatible stack heights: 0 vs 1
		//IL_36c0: Incompatible stack heights: 0 vs 1
		//IL_36ca: Incompatible stack heights: 0 vs 1
		//IL_36d4: Incompatible stack heights: 0 vs 1
		//IL_36de: Incompatible stack heights: 0 vs 1
		//IL_36e8: Incompatible stack heights: 0 vs 3
		//IL_36f2: Incompatible stack heights: 0 vs 1
		//IL_36fc: Incompatible stack heights: 0 vs 1
		//IL_3706: Incompatible stack heights: 0 vs 1
		//IL_3710: Incompatible stack heights: 0 vs 1
		//IL_3724: Incompatible stack heights: 0 vs 1
		//IL_372e: Incompatible stack heights: 0 vs 1
		//IL_3738: Incompatible stack heights: 0 vs 1
		//IL_3742: Incompatible stack heights: 0 vs 1
		//IL_374c: Incompatible stack heights: 0 vs 1
		//IL_3756: Incompatible stack heights: 0 vs 1
		//IL_376a: Incompatible stack heights: 0 vs 1
		//IL_3774: Incompatible stack heights: 0 vs 1
		//IL_377e: Incompatible stack heights: 0 vs 1
		//IL_3788: Incompatible stack heights: 0 vs 1
		//IL_3792: Incompatible stack heights: 0 vs 1
		//IL_379c: Incompatible stack heights: 0 vs 1
		//IL_37a6: Incompatible stack heights: 0 vs 3
		//IL_37b0: Incompatible stack heights: 0 vs 1
		//IL_37ba: Incompatible stack heights: 0 vs 1
		//IL_37c4: Incompatible stack heights: 0 vs 1
		//IL_37ce: Incompatible stack heights: 0 vs 1
		//IL_37d8: Incompatible stack heights: 0 vs 1
		//IL_37ec: Incompatible stack heights: 0 vs 1
		//IL_37f6: Incompatible stack heights: 0 vs 1
		//IL_3800: Incompatible stack heights: 0 vs 1
		//IL_380a: Incompatible stack heights: 0 vs 1
		//IL_3814: Incompatible stack heights: 0 vs 1
		//IL_381e: Incompatible stack heights: 0 vs 1
		//IL_3828: Incompatible stack heights: 0 vs 1
		//IL_3832: Incompatible stack heights: 0 vs 1
		//IL_383c: Incompatible stack heights: 0 vs 1
		//IL_3850: Incompatible stack heights: 0 vs 1
		//IL_3864: Incompatible stack heights: 0 vs 1
		//IL_386e: Incompatible stack heights: 0 vs 1
		//IL_3878: Incompatible stack heights: 0 vs 1
		//IL_3882: Incompatible stack heights: 0 vs 1
		//IL_388c: Incompatible stack heights: 0 vs 1
		//IL_3896: Incompatible stack heights: 0 vs 1
		//IL_38a0: Incompatible stack heights: 0 vs 1
		//IL_38aa: Incompatible stack heights: 0 vs 1
		//IL_38b4: Incompatible stack heights: 0 vs 1
		//IL_38be: Incompatible stack heights: 0 vs 1
		//IL_38c8: Incompatible stack heights: 0 vs 3
		//IL_38d2: Incompatible stack heights: 0 vs 1
		//IL_38dc: Incompatible stack heights: 0 vs 1
		//IL_38e6: Incompatible stack heights: 0 vs 1
		//IL_38f0: Incompatible stack heights: 0 vs 1
		//IL_38fa: Incompatible stack heights: 0 vs 1
		//IL_3904: Incompatible stack heights: 0 vs 3
		//IL_390e: Expected I8, but got Unknown
		//IL_3918: Incompatible stack heights: 0 vs 1
		//IL_3922: Incompatible stack heights: 0 vs 1
		//IL_392c: Incompatible stack heights: 0 vs 1
		//IL_3936: Expected I8, but got Unknown
		//IL_3936: Incompatible stack heights: 0 vs 1
		//IL_3940: Incompatible stack heights: 0 vs 1
		//IL_395e: Incompatible stack heights: 0 vs 1
		//IL_3968: Incompatible stack heights: 0 vs 1
		//IL_3972: Incompatible stack heights: 0 vs 1
		//IL_397c: Incompatible stack heights: 0 vs 1
		//IL_3986: Incompatible stack heights: 0 vs 1
		//IL_3990: Incompatible stack heights: 0 vs 2
		//IL_399a: Incompatible stack heights: 0 vs 1
		//IL_39a4: Incompatible stack heights: 0 vs 1
		//IL_39ae: Incompatible stack heights: 0 vs 1
		//IL_39b8: Incompatible stack heights: 0 vs 1
		//IL_39cc: Incompatible stack heights: 0 vs 1
		//IL_39e0: Incompatible stack heights: 0 vs 1
		//IL_39ea: Incompatible stack heights: 0 vs 1
		//IL_39f4: Incompatible stack heights: 0 vs 1
		//IL_39fe: Incompatible stack heights: 0 vs 1
		//IL_3a08: Incompatible stack heights: 0 vs 1
		//IL_3a12: Incompatible stack heights: 0 vs 1
		//IL_3a1c: Incompatible stack heights: 0 vs 1
		//IL_3a26: Incompatible stack heights: 0 vs 1
		//IL_3a30: Incompatible stack heights: 0 vs 1
		//IL_3a44: Incompatible stack heights: 0 vs 1
		//IL_3a4e: Incompatible stack heights: 0 vs 1
		//IL_3a58: Incompatible stack heights: 0 vs 1
		//IL_3a62: Incompatible stack heights: 0 vs 1
		//IL_3a6c: Incompatible stack heights: 0 vs 1
		//IL_3a76: Incompatible stack heights: 0 vs 1
		//IL_3a80: Incompatible stack heights: 0 vs 1
		//IL_3a94: Incompatible stack heights: 0 vs 1
		//IL_3a9e: Incompatible stack heights: 0 vs 1
		//IL_3ab2: Incompatible stack heights: 0 vs 1
		//IL_3abc: Incompatible stack heights: 0 vs 1
		//IL_3ac6: Incompatible stack heights: 0 vs 1
		//IL_3ad0: Incompatible stack heights: 0 vs 1
		//IL_3ada: Incompatible stack heights: 0 vs 1
		//IL_3ae4: Incompatible stack heights: 0 vs 1
		//IL_3aee: Incompatible stack heights: 0 vs 1
		//IL_3af8: Incompatible stack heights: 0 vs 1
		//IL_3b02: Incompatible stack heights: 0 vs 1
		//IL_3b0c: Incompatible stack heights: 0 vs 1
		//IL_3b16: Incompatible stack heights: 0 vs 1
		//IL_3b20: Incompatible stack heights: 0 vs 1
		//IL_3b2a: Incompatible stack heights: 0 vs 1
		//IL_3b34: Incompatible stack heights: 0 vs 1
		//IL_3b3e: Incompatible stack heights: 0 vs 1
		//IL_3b48: Incompatible stack heights: 0 vs 1
		int num = 304;
		byte[] array = default(byte[]);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		IntPtr intPtr = default(IntPtr);
		int num8 = default(int);
		int num9 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num5 = default(int);
		int num4 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		BinaryReader binaryReader = default(BinaryReader);
		IntPtr intPtr3 = default(IntPtr);
		SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
		byte[] buffer = default(byte[]);
		byte[] rgbKey = default(byte[]);
		int num13 = default(int);
		IntPtr intPtr4 = default(IntPtr);
		MemoryStream memoryStream = default(MemoryStream);
		int num10 = default(int);
		int num12 = default(int);
		CryptoStream cryptoStream = default(CryptoStream);
		Assembly assembly = default(Assembly);
		byte[] array3 = default(byte[]);
		int num11 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					IntPtr zero;
					switch (num3)
					{
					case 96:
						break;
					case 16:
						goto IL_0032;
					case 244:
						goto IL_004a;
					case 328:
						goto IL_0062;
					case 293:
						goto IL_0086;
					case 261:
						goto IL_009f;
					case 297:
						goto IL_00c1;
					case 137:
						array[22] = (byte)num7;
						num = 297;
						goto end_IL_2667;
					case 371:
						array[5] = (byte)num7;
						num = 91;
						goto end_IL_2667;
					case 156:
						array[0] = 88;
						num = 59;
						goto end_IL_2667;
					case 360:
						array[28] = 46;
						num3 = 49;
						continue;
					case 202:
						array2[10] = (byte)num6;
						num = 195;
						goto end_IL_2667;
					case 280:
						array[24] = 109;
						num2 = 396;
						goto end_IL_266b;
					case 153:
						HTadVgrdU(intPtr, num8 * 4, num9, ref num9);
						num2 = 268;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 126;
					case 126:
						array[16] = 28;
						num3 = 191;
						continue;
					case 22:
						array2[14] = (byte)num6;
						num3 = 386;
						continue;
					case 339:
						array[26] = (byte)num7;
						num2 = 395;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 270;
					case 256:
						array[16] = (byte)num7;
						num3 = 12;
						continue;
					case 172:
						num7 = 96 + 94;
						num3 = 339;
						continue;
					case 79:
						HTadVgrdU(intPtr2, 4, 4, ref num9);
						num2 = 270;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 122;
					case 122:
						num6 = 184 - 61;
						num3 = 30;
						continue;
					case 183:
						array[18] = 109;
						num2 = 71;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 303;
					case 303:
						array[8] = 39;
						num = 424;
						goto end_IL_2667;
					case 127:
						num5 = 177 - 59;
						num3 = 307;
						continue;
					case 184:
						array[15] = (byte)num7;
						num = 315;
						goto end_IL_2667;
					case 341:
						array[21] = 122;
						num = 173;
						goto end_IL_2667;
					case 25:
						array2[11] = 134;
						num2 = 67;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0324: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 89;
					case 262:
						num7 = 237 - 79;
						num2 = 340;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_034b: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 31;
					case 31:
						num4 = 8 + 7;
						num = 350;
						goto end_IL_2667;
					case 242:
						array[20] = 84;
						num3 = 398;
						continue;
					case 162:
						array[29] = 35;
						num3 = 384;
						continue;
					case 350:
						array[2] = (byte)num4;
						num2 = 383;
						goto end_IL_266b;
					case 203:
						num7 = 143 - 47;
						num2 = 371;
						goto end_IL_266b;
					case 393:
						num5 = 230 - 76;
						num3 = 336;
						continue;
					case 225:
						array[6] = (byte)num7;
						num = 45;
						goto end_IL_2667;
					case 304:
						if (!rCRXZVLjZ)
						{
							num2 = 227;
							if (true)
							{
								goto end_IL_266b;
							}
							goto case 51;
						}
						return;
					case 51:
						num4 = 163 + 88;
						num2 = 408;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_045b: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 145;
					case 275:
						num7 = 51 + 17;
						num3 = 102;
						continue;
					case 223:
						array2[4] = (byte)num6;
						num = 120;
						goto end_IL_2667;
					case 343:
						num4 = 156 - 52;
						num2 = 417;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_04e9: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 240;
					case 240:
						array[24] = (byte)num4;
						num3 = 247;
						continue;
					case 425:
						num7 = 50 + 60;
						num = 225;
						goto end_IL_2667;
					case 165:
						array[7] = 198;
						num = 207;
						goto end_IL_2667;
					case 267:
						num7 = 192 - 64;
						num2 = 93;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 283;
					case 283:
						array[2] = 129;
						num = 204;
						goto end_IL_2667;
					case 97:
						num5 = 83 + 112;
						num2 = 420;
						goto end_IL_266b;
					case 174:
						num4 = 57 + 74;
						num3 = 266;
						continue;
					case 83:
						array[5] = (byte)num4;
						num2 = 80;
						goto end_IL_266b;
					case 229:
						num6 = 92 + 37;
						num2 = 202;
						goto end_IL_266b;
					case 370:
						array4[5] = array5[2];
						num2 = 216;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 313;
					case 313:
						array[25] = (byte)num4;
						num2 = 174;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 420;
					case 420:
						array2[6] = (byte)num5;
						num2 = 306;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 273;
					case 273:
						num4 = 157 - 52;
						num = 56;
						goto end_IL_2667;
					case 287:
						num4 = 100 + 9;
						num2 = 288;
						goto end_IL_266b;
					case 254:
						array2[15] = (byte)num6;
						num = 361;
						goto end_IL_2667;
					case 285:
						array[0] = (byte)num7;
						num = 400;
						goto end_IL_2667;
					case 372:
						array[3] = (byte)num7;
						num = 197;
						goto end_IL_2667;
					case 300:
						array2[2] = (byte)num5;
						num2 = 69;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 108;
					case 108:
						array[19] = 140;
						num3 = 194;
						continue;
					case 248:
						binaryReader.Close();
						num = 4;
						goto end_IL_2667;
					case 77:
						num5 = 34 - 18;
						num3 = 296;
						continue;
					case 397:
						array2[10] = 95;
						num3 = 229;
						continue;
					case 182:
						num4 = 112 + 47;
						num2 = 6;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 349;
					case 349:
						num4 = 185 - 61;
						num2 = 413;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0773: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 91;
					case 237:
						array2[7] = (byte)num6;
						num2 = 335;
						goto end_IL_266b;
					case 106:
					case 268:
					{
						_ = binaryReader.BaseStream;
						_ = ((Stream)/*Error near IL_3738: Stack underflow*/).Position;
						_ = binaryReader.BaseStream;
						_ = ((Stream)/*Error near IL_374c: Stack underflow*/).Length;
						_003F val2 = /*Error near IL_07af: Stack underflow*/- 1;
						if (/*Error near IL_07b4: Stack underflow*/ < val2)
						{
							num3 = 356;
							continue;
						}
						pCaHOWZ4f(intPtr3);
						num = 426;
						goto end_IL_2667;
					}
					case 271:
						array[11] = 123;
						num = 139;
						goto end_IL_2667;
					case 46:
						array2[3] = (byte)num6;
						num2 = 129;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_07fe: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 249;
					case 18:
						symmetricAlgorithm.Mode = CipherMode.CBC;
						num3 = 392;
						continue;
					case 185:
						array[25] = 104;
						num = 411;
						goto end_IL_2667;
					case 3:
						num7 = 176 - 58;
						num2 = 133;
						goto end_IL_266b;
					case 10:
						array[25] = 199;
						num2 = 385;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0873: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 298;
					case 298:
						array[12] = (byte)num4;
						num3 = 265;
						continue;
					case 74:
						num5 = 82 + 65;
						num2 = 325;
						goto end_IL_266b;
					case 414:
						array[29] = 103;
						num = 292;
						goto end_IL_2667;
					case 101:
						array[17] = (byte)num7;
						num = 64;
						goto end_IL_2667;
					case 405:
						array[30] = 120;
						num3 = 246;
						continue;
					case 263:
						num7 = 132 - 104;
						num2 = 256;
						goto end_IL_266b;
					case 312:
						array[11] = (byte)num7;
						num2 = 118;
						goto end_IL_266b;
					case 419:
						array[28] = 130;
						num2 = 208;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_095f: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 379;
					case 327:
						num4 = 191 - 63;
						num2 = 244;
						goto end_IL_266b;
					case 249:
						array2[0] = 166;
						num2 = 122;
						goto end_IL_266b;
					case 27:
						array2[15] = 135;
						num = 176;
						goto end_IL_2667;
					case 88:
						num4 = 44 - 3;
						num = 389;
						goto end_IL_2667;
					case 104:
						num7 = 234 - 118;
						num2 = 85;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_09fe: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 4;
					case 4:
						new MemoryStream(buffer);
						new BinaryReader((Stream)/*Error near IL_3792: Stack underflow*/);
						binaryReader = (BinaryReader)/*Error near IL_0a0c: Stack underflow*/;
						num3 = 7;
						continue;
					case 217:
						rgbKey = array;
						num2 = 258;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 131;
					case 131:
						array[1] = 77;
						num2 = 327;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 5;
					case 5:
						array[15] = (byte)num4;
						num2 = 121;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 178;
					case 178:
						array[5] = 139;
						num3 = 409;
						continue;
					case 56:
						array[26] = (byte)num4;
						num2 = 375;
						goto end_IL_266b;
					case 179:
						array[6] = (byte)num7;
						num3 = 425;
						continue;
					case 143:
						array[16] = (byte)num7;
						num2 = 263;
						goto end_IL_266b;
					case 133:
						array[9] = (byte)num7;
						num3 = 14;
						continue;
					case 12:
						array[17] = 110;
						num2 = 399;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0b09: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 236;
					case 236:
						array[8] = (byte)num7;
						num = 58;
						goto end_IL_2667;
					case 235:
						num7 = 146 - 29;
						num = 407;
						goto end_IL_2667;
					case 282:
						array[29] = (byte)num4;
						num2 = 162;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 200;
					case 200:
						array2[2] = 142;
						num3 = 291;
						continue;
					case 139:
						num7 = 133 - 44;
						num = 312;
						goto end_IL_2667;
					case 216:
						array4[7] = array5[3];
						num = 357;
						goto end_IL_2667;
					case 212:
						_ = 1;
						Process.GetCurrentProcess();
						_ = ((Process)/*Error near IL_37b0: Stack underflow*/).Id;
						SHHPxcicR((uint)/*Error near IL_37ba: Stack underflow*/, (int)/*Error near IL_37ba: Stack underflow*/, (uint)/*Error near IL_37ba: Stack underflow*/);
						intPtr3 = (IntPtr)/*Error near IL_0bb5: Stack underflow*/;
						num2 = 233;
						goto end_IL_266b;
					case 67:
						num5 = 104 + 74;
						num3 = 151;
						continue;
					case 361:
						array4 = array2;
						num2 = 39;
						goto end_IL_266b;
					case 68:
						array[12] = (byte)num7;
						num2 = 81;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 386;
					case 386:
						num5 = 55 + 25;
						num2 = 189;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 402;
					case 402:
						array[2] = (byte)num7;
						num2 = 148;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 94;
					case 170:
						array2[4] = (byte)num5;
						num3 = 412;
						continue;
					case 157:
						array2[7] = 121;
						num2 = 105;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 315;
					case 315:
						array[15] = 90;
						num2 = 53;
						goto end_IL_266b;
					case 375:
						array[26] = 109;
						num3 = 119;
						continue;
					case 70:
						array2[4] = 89;
						num2 = 334;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 309;
					case 309:
						array[0] = 170;
						num2 = 261;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 207;
					case 207:
						num4 = 90 + 53;
						num = 132;
						goto end_IL_2667;
					case 121:
						array[15] = 153;
						num2 = 19;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0d5a: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 100;
					case 100:
						array2[9] = 95;
						num3 = 127;
						continue;
					case 73:
						array[19] = 116;
						num2 = 349;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 224;
					case 224:
						array[13] = (byte)num4;
						num3 = 241;
						continue;
					case 78:
						_ = binaryReader.BaseStream;
						((Stream)/*Error near IL_37e2: Stack underflow*/).Position = 0L;
						num2 = 333;
						goto end_IL_266b;
					case 134:
						array[28] = (byte)num4;
						num2 = 287;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0dec: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 281;
					case 407:
						array[23] = (byte)num7;
						num2 = 280;
						goto end_IL_266b;
					case 373:
						array[24] = (byte)num7;
						num = 10;
						goto end_IL_2667;
					case 208:
						num4 = 109 + 113;
						num3 = 134;
						continue;
					case 113:
					{
						YZf0tMn4q0DHWm43r6 yZf0tMn4q0DHWm43r = (YZf0tMn4q0DHWm43r6)56;
						num3 = 212;
						continue;
					}
					case 252:
						num7 = 86 + 82;
						num3 = 403;
						continue;
					case 120:
						array2[5] = 82;
						num = 109;
						goto end_IL_2667;
					case 320:
						array2[7] = (byte)num5;
						num = 37;
						goto end_IL_2667;
					case 239:
						array[31] = 67;
						num2 = 267;
						goto end_IL_266b;
					case 132:
						array[7] = (byte)num4;
						num = 51;
						goto end_IL_2667;
					case 337:
						num7 = 108 + 60;
						num3 = 284;
						continue;
					case 48:
						array2[0] = 141;
						num = 167;
						goto end_IL_2667;
					case 288:
						array[28] = (byte)num4;
						num2 = 360;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0f30: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 90;
					case 90:
						array[16] = 64;
						num = 222;
						goto end_IL_2667;
					case 128:
						array[22] = 99;
						num2 = 158;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0f71: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 346;
					case 346:
						array[6] = 14;
						num = 160;
						goto end_IL_2667;
					case 382:
						array[30] = 105;
						num2 = 140;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 335;
					case 335:
						array2[7] = 133;
						num2 = 36;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_0fd6: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 394;
					case 394:
						binaryReader.ReadInt32();
						num13 = (int)/*Error near IL_0fdf: Stack underflow*/;
						num2 = 61;
						goto end_IL_266b;
					case 204:
						array[2] = 125;
						num2 = 302;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 148;
					case 148:
						num7 = 129 - 43;
						num = 198;
						goto end_IL_2667;
					case 61:
						binaryReader.ReadInt32();
						num = 367;
						goto end_IL_2667;
					case 227:
						rCRXZVLjZ = true;
						num2 = 187;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1055: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 306;
					case 306:
						num5 = 131 + 68;
						num2 = 40;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1077: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 243;
					case 243:
						intPtr4.ToInt64();
						CDIZqyEvo = (long)/*Error near IL_1083: Stack underflow*/;
						num2 = 295;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 0;
					case 0:
						memoryStream.Close();
						num2 = 318;
						goto end_IL_266b;
					case 123:
						array2[0] = 156;
						num = 249;
						goto end_IL_2667;
					case 145:
						num6 = 183 + 71;
						num3 = 289;
						continue;
					case 164:
						array[19] = (byte)num4;
						num2 = 262;
						goto end_IL_266b;
					case 161:
						num7 = 175 + 24;
						num3 = 114;
						continue;
					case 95:
						array[20] = (byte)num4;
						num = 117;
						goto end_IL_2667;
					case 226:
						array[11] = 199;
						num3 = 271;
						continue;
					case 41:
						num10++;
						num = 277;
						goto end_IL_2667;
					case 289:
						array2[5] = (byte)num6;
						num3 = 299;
						continue;
					case 291:
						array2[2] = 164;
						num2 = 159;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 377;
					case 377:
						array[11] = 199;
						num2 = 329;
						goto end_IL_266b;
					case 255:
						num7 = 107 + 17;
						num2 = 321;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 76;
					case 76:
						num7 = 111 + 60;
						num2 = 68;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 324;
					case 324:
						array[28] = (byte)num7;
						num = 419;
						goto end_IL_2667;
					case 8:
						array[9] = (byte)num4;
						num2 = 348;
						goto end_IL_266b;
					case 417:
						array[3] = (byte)num4;
						num2 = 110;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 7;
					case 7:
						_ = binaryReader.BaseStream;
						((Stream)/*Error near IL_385a: Stack underflow*/).Position = 0L;
						num = 24;
						goto end_IL_2667;
					case 36:
						array2[7] = 175;
						num = 157;
						goto end_IL_2667;
					case 72:
						array[12] = 88;
						num2 = 293;
						goto end_IL_266b;
					case 274:
						array[1] = 77;
						num = 283;
						goto end_IL_2667;
					case 191:
						array[16] = 108;
						num = 90;
						goto end_IL_2667;
					case 55:
						array[27] = 164;
						num2 = 294;
						goto end_IL_266b;
					case 352:
						array4[1] = array5[0];
						num2 = 281;
						goto end_IL_266b;
					case 195:
						array2[10] = 12;
						num3 = 54;
						continue;
					case 258:
						array2 = new byte[16];
						num = 48;
						goto end_IL_2667;
					case 279:
						array2[14] = (byte)num5;
						num = 96;
						goto end_IL_2667;
					case 412:
						num6 = 76 - 4;
						num2 = 223;
						goto end_IL_266b;
					case 142:
						array[4] = (byte)num7;
						num2 = 178;
						goto end_IL_266b;
					case 99:
						array[31] = 64;
						num = 239;
						goto end_IL_2667;
					case 64:
						array[17] = 144;
						num = 209;
						goto end_IL_2667;
					case 409:
						array[5] = 158;
						num3 = 32;
						continue;
					case 158:
						array[22] = 152;
						num3 = 177;
						continue;
					case 129:
						num5 = 151 - 50;
						num2 = 147;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1432: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 34;
					case 163:
						array2[1] = 57;
						num2 = 364;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_145f: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 62;
					case 62:
						array2[8] = 164;
						num3 = 328;
						continue;
					case 355:
						array2[13] = 83;
						num = 50;
						goto end_IL_2667;
					case 59:
						num4 = 191 - 63;
						num2 = 141;
						goto end_IL_266b;
					case 28:
						num6 = 11 + 121;
						num2 = 57;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 206;
					case 206:
						array[12] = 100;
						num2 = 76;
						goto end_IL_266b;
					case 65:
						array[15] = 39;
						num2 = 252;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_151d: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 326;
					case 34:
						num4 = 124 - 40;
						num2 = 95;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1544: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 341;
					case 91:
						num4 = 125 + 14;
						num2 = 168;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 151;
					case 151:
						array2[11] = (byte)num5;
						num = 188;
						goto end_IL_2667;
					case 159:
						num5 = 172 + 75;
						num2 = 300;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_15a1: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 334;
					case 110:
						num7 = 95 + 115;
						num3 = 372;
						continue;
					case 98:
						num7 = 16 + 36;
						num = 324;
						goto end_IL_2667;
					case 209:
						num7 = 222 - 112;
						num = 125;
						goto end_IL_2667;
					case 348:
						array[10] = 71;
						num = 368;
						goto end_IL_2667;
					case 35:
						array[9] = 173;
						num2 = 3;
						goto end_IL_266b;
					case 302:
						num7 = 43 + 43;
						num2 = 402;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1649: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 233;
					case 421:
						num7 = 2 + 64;
						num2 = 184;
						goto end_IL_266b;
					case 250:
						num4 = 37 + 98;
						num2 = 313;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 40;
					case 40:
						array2[6] = (byte)num5;
						num3 = 234;
						continue;
					case 194:
						num4 = 39 + 9;
						num3 = 164;
						continue;
					case 334:
						num6 = 78 + 111;
						num = 75;
						goto end_IL_2667;
					case 6:
						array[19] = (byte)num4;
						num = 104;
						goto end_IL_2667;
					case 266:
						array[25] = (byte)num4;
						num3 = 161;
						continue;
					case 246:
						num4 = 83 + 29;
						num = 16;
						goto end_IL_2667;
					case 71:
						array[18] = 138;
						num = 401;
						goto end_IL_2667;
					case 147:
						array2[3] = (byte)num5;
						num2 = 77;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_175c: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 265;
					case 265:
						array[13] = 191;
						num2 = 146;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 276;
					case 276:
						num6 = 195 - 65;
						num3 = 46;
						continue;
					case 362:
						array[21] = 100;
						num2 = 128;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 106;
					case 75:
						array2[4] = (byte)num6;
						num3 = 192;
						continue;
					case 381:
						array[25] = (byte)num7;
						num3 = 250;
						continue;
					case 308:
						array[15] = (byte)num7;
						num2 = 126;
						goto end_IL_266b;
					case 247:
						num7 = 218 - 109;
						num3 = 373;
						continue;
					case 332:
						num4 = 74 + 20;
						num2 = 240;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 325;
					case 325:
						array2[9] = (byte)num5;
						num = 100;
						goto end_IL_2667;
					case 385:
						array[25] = 122;
						num = 185;
						goto end_IL_2667;
					case 317:
						array2[12] = 125;
						num2 = 103;
						goto end_IL_266b;
					case 167:
						array2[0] = 164;
						num3 = 123;
						continue;
					case 269:
						array2[6] = (byte)num6;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_18e7: Stack underflow*/ == 0)
						{
							num2 = 272;
							if (true)
							{
								goto end_IL_266b;
							}
							goto case 54;
						}
						num = 232;
						goto end_IL_2667;
					case 54:
						array2[11] = 138;
						num2 = 230;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 89;
					case 89:
						array[4] = 113;
						num2 = 255;
						goto end_IL_266b;
					case 364:
						array2[1] = 151;
						num2 = 33;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 80;
					case 80:
						array[5] = 126;
						num2 = 203;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 395;
					case 395:
						array[27] = 157;
						num = 205;
						goto end_IL_2667;
					case 295:
						zero = IntPtr.Zero;
						num2 = 175;
						goto end_IL_266b;
					case 1:
						binaryReader.ReadInt32();
						BitConverter.GetBytes((int)/*Error near IL_38d2: Stack underflow*/);
						cJLRdxCVV((IntPtr)/*Error near IL_38dc: Stack underflow*/, (IntPtr)/*Error near IL_38dc: Stack underflow*/, (byte[])/*Error near IL_38dc: Stack underflow*/, 4u, out zero);
						num = 286;
						goto end_IL_2667;
					case 103:
						array2[12] = 126;
						num2 = 42;
						goto end_IL_266b;
					case 138:
						array[26] = (byte)num4;
						num2 = 135;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1a1b: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 356;
					case 356:
						binaryReader.ReadInt32();
						num12 = (int)/*Error near IL_1a24: Stack underflow*/;
						num2 = 111;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1a37: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 87;
					case 87:
						num7 = 79 + 90;
						num3 = 15;
						continue;
					case 384:
						array[30] = 168;
						num2 = 382;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 368;
					case 368:
						num7 = 185 - 61;
						num2 = 52;
						goto end_IL_266b;
					case 231:
						num4 = 195 + 17;
						num = 298;
						goto end_IL_2667;
					case 176:
						num6 = 16 - 6;
						num = 254;
						goto end_IL_2667;
					case 234:
						num5 = 45 + 50;
						num3 = 320;
						continue;
					case 221:
						array2[12] = (byte)num6;
						num2 = 201;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 146;
					case 146:
						num7 = 11 + 73;
						num2 = 322;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1b39: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 251;
					case 251:
						num4 = 224 - 74;
						num = 86;
						goto end_IL_2667;
					case 160:
						num7 = 172 - 57;
						num2 = 179;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 130;
					case 130:
						array[31] = 64;
						num2 = 217;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1b98: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 137;
					case 284:
						array[30] = (byte)num7;
						num2 = 99;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 318;
					case 318:
						cryptoStream.Close();
						num = 248;
						goto end_IL_2667;
					case 424:
						num7 = 68 + 4;
						num2 = 236;
						goto end_IL_266b;
					case 401:
						array[18] = 164;
						num2 = 87;
						goto end_IL_266b;
					case 26:
						array[8] = 42;
						num2 = 303;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1c5f: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 233;
					case 233:
						assembly.GetModules();
						Marshal.GetHINSTANCE((Module)((object[])/*Error near IL_1c68: Stack underflow*/)[0]);
						intPtr4 = (IntPtr)/*Error near IL_1c6f: Stack underflow*/;
						num = 243;
						goto end_IL_2667;
					case 408:
						array[7] = (byte)num4;
						num = 26;
						goto end_IL_2667;
					case 181:
						array2[10] = (byte)num6;
						num3 = 369;
						continue;
					case 380:
						array[4] = 170;
						num2 = 89;
						goto end_IL_266b;
					case 354:
						array[2] = (byte)num7;
						num2 = 257;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 299;
					case 299:
						array2[6] = 151;
						num2 = 63;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1d11: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 214;
					case 214:
						array4[15] = array5[7];
						num2 = 391;
						goto end_IL_266b;
					case 196:
						num6 = 27 + 32;
						num3 = 181;
						continue;
					case 201:
						array2[12] = 101;
						num2 = 29;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1d69: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 197;
					case 197:
						array[3] = 125;
						num3 = 21;
						continue;
					case 333:
					{
						_ = binaryReader.BaseStream;
						_ = ((Stream)/*Error near IL_399a: Stack underflow*/).Length;
						int count = (int)/*Error near IL_1d97: Stack underflow*/;
						((BinaryReader)/*Error near IL_39a4: Stack underflow*/).ReadBytes(count);
						array3 = (byte[])/*Error near IL_1d9e: Stack underflow*/;
						num2 = 326;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 149;
					}
					case 149:
						array[27] = 58;
						num2 = 344;
						goto end_IL_266b;
					case 358:
						array[14] = 117;
						num2 = 213;
						goto end_IL_266b;
					case 365:
						array[6] = 14;
						num3 = 422;
						continue;
					case 245:
						array[10] = 110;
						num3 = 13;
						continue;
					case 150:
					case 418:
						if (num11 < num13)
						{
							_ = ref intPtr2;
							_ = CDIZqyEvo;
							binaryReader.ReadInt32();
							long num14 = (long)/*Error near IL_1a9f: Stack underflow*/;
							_003F val = /*Error near IL_1aa0: Stack underflow*/+ num14;
							*(IntPtr*)/*Error near IL_390e: Stack underflow*/ = new IntPtr((long)val);
							num3 = 79;
							continue;
						}
						num = 106;
						goto end_IL_2667;
					case 219:
						num6 = 157 - 122;
						num3 = 22;
						continue;
					case 66:
						num4 = 235 - 78;
						num = 138;
						goto end_IL_2667;
					case 115:
						array[23] = 166;
						num2 = 228;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 323;
					case 323:
						array2[2] = 20;
						num3 = 200;
						continue;
					case 107:
						array2[8] = (byte)num5;
						num = 62;
						goto end_IL_2667;
					case 192:
						num5 = 61 + 43;
						num = 170;
						goto end_IL_2667;
					case 359:
						num11++;
						num = 150;
						goto end_IL_2667;
					case 292:
						num4 = 214 - 71;
						num = 282;
						goto end_IL_2667;
					case 85:
						array[19] = (byte)num7;
						num = 242;
						goto end_IL_2667;
					case 92:
						array2[1] = 100;
						num2 = 163;
						goto end_IL_266b;
					case 112:
						array2[5] = (byte)num5;
						num2 = 152;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 19;
					case 19:
						num7 = 69 - 30;
						num = 308;
						goto end_IL_2667;
					case 383:
						num7 = 72 + 57;
						num2 = 354;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_1fa0: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 6;
					case 388:
						num7 = 127 - 42;
						num = 406;
						goto end_IL_2667;
					case 9:
						array2[15] = (byte)num6;
						num2 = 27;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_1fdf: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 188;
					case 188:
						array2[11] = 19;
						num = 317;
						goto end_IL_2667;
					case 111:
						intPtr = new IntPtr(CDIZqyEvo + num12);
						goto case 232;
					case 403:
						array[15] = (byte)num7;
						num3 = 421;
						continue;
					case 422:
						array[7] = 251;
						num3 = 165;
						continue;
					case 260:
						array[21] = 144;
						num = 144;
						goto end_IL_2667;
					case 69:
						array2[3] = 130;
						num3 = 276;
						continue;
					case 205:
						num7 = 21 + 85;
						num2 = 84;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 124;
					case 124:
						array[9] = (byte)num4;
						num3 = 169;
						continue;
					case 43:
						array2[13] = (byte)num6;
						num3 = 314;
						continue;
					case 259:
						if (array5.Length <= 0)
						{
							goto case 310;
						}
						num = 352;
						goto end_IL_2667;
					case 118:
						num7 = 126 - 42;
						num = 379;
						goto end_IL_2667;
					case 30:
						array2[1] = (byte)num6;
						num3 = 171;
						continue;
					case 253:
						array[28] = 46;
						num2 = 98;
						goto end_IL_266b;
					case 180:
						array[23] = (byte)num4;
						num3 = 376;
						continue;
					case 369:
						array2[10] = 69;
						num3 = 397;
						continue;
					case 357:
						array4[9] = array5[4];
						num3 = 415;
						continue;
					case 53:
						num4 = 1 + 109;
						num3 = 5;
						continue;
					case 367:
						num11 = 0;
						num2 = 418;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_21b6: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 105;
					case 105:
						array2[8] = 137;
						num2 = 136;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 24;
					case 24:
						intPtr3 = IntPtr.Zero;
						num3 = 60;
						continue;
					case 135:
						array[26] = 144;
						num3 = 172;
						continue;
					case 58:
						array[8] = 108;
						num3 = 199;
						continue;
					case 353:
						array[27] = (byte)num4;
						num3 = 149;
						continue;
					case 86:
						array[1] = (byte)num4;
						num = 274;
						goto end_IL_2667;
					case 257:
						array[3] = 125;
						num2 = 343;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 347;
					case 347:
						array[26] = 190;
						num2 = 273;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 17;
					case 17:
						array2[11] = (byte)num6;
						num2 = 25;
						goto end_IL_266b;
					case 413:
						array[19] = (byte)num4;
						num3 = 108;
						continue;
					case 391:
						Array.Clear(array5, 0, array5.Length);
						num = 310;
						goto end_IL_2667;
					case 342:
						array2[2] = (byte)num6;
						num2 = 323;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2300: Stack underflow*/ != 0)
						{
							goto case 150;
						}
						goto end_IL_266b;
					case 119:
						num7 = 205 - 68;
						num2 = 387;
						goto end_IL_266b;
					case 399:
						num4 = 107 + 111;
						num = 44;
						goto end_IL_2667;
					case 238:
						array[14] = 221;
						num2 = 215;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 47;
					case 47:
						array2[13] = (byte)num6;
						num2 = 355;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2380: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 277;
					case 277:
					case 404:
						if (num10 >= num8)
						{
							num3 = 153;
							continue;
						}
						intPtr.ToInt64();
						new IntPtr((long)(/*Error near IL_1baf: Stack underflow*/ + num10 * 4));
						binaryReader.ReadInt32();
						Marshal.WriteInt32((IntPtr)/*Error near IL_394a: Stack underflow*/, (int)/*Error near IL_394a: Stack underflow*/);
						num2 = 41;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 284;
					case 331:
						array[13] = 191;
						num = 358;
						goto end_IL_2667;
					case 13:
						array[10] = 71;
						num2 = 226;
						goto end_IL_266b;
					case 20:
						num5 = 168 - 56;
						num3 = 112;
						continue;
					case 241:
						array[13] = 76;
						num2 = 193;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 109;
					case 109:
						num6 = 197 - 65;
						num2 = 311;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 14;
					case 14:
						num4 = 118 + 30;
						num = 124;
						goto end_IL_2667;
					case 82:
						memoryStream.ToArray();
						buffer = (byte[])/*Error near IL_2452: Stack underflow*/;
						num2 = 154;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2465: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 117;
					case 117:
						array[21] = 100;
						num2 = 341;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2487: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 67;
					case 60:
						gX6byysyFa8Nv80gC9.e53w34m968awCm9P85taUZe(33554469);
						Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_3a1c: Stack underflow*/);
						_ = ((Type)/*Error near IL_3a26: Stack underflow*/).Assembly;
						assembly = (Assembly)/*Error near IL_24a2: Stack underflow*/;
						num2 = 113;
						goto end_IL_266b;
					case 140:
						array[30] = 150;
						num2 = 405;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 44;
					case 44:
						array[17] = (byte)num4;
						num2 = 278;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 21;
					case 21:
						array[4] = 225;
						num = 380;
						goto end_IL_2667;
					case 210:
						array[27] = (byte)num4;
						num2 = 253;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_252b: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 39;
					case 39:
						Array.Reverse((Array)array4);
						num2 = 351;
						goto end_IL_266b;
					case 11:
						array[2] = 35;
						num3 = 31;
						continue;
					case 187:
						gX6byysyFa8Nv80gC9.e53w34m968awCm9P85taUZe(33554469);
						Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_3a4e: Stack underflow*/);
						_ = ((Type)/*Error near IL_3a58: Stack underflow*/).Assembly;
						((Assembly)/*Error near IL_3a62: Stack underflow*/).GetManifestResourceStream("578a6d6d-530f-42be-b820-48030296704e");
						new BinaryReader((Stream)/*Error near IL_3a6c: Stack underflow*/);
						binaryReader = (BinaryReader)/*Error near IL_2584: Stack underflow*/;
						num3 = 78;
						continue;
					case 379:
						array[11] = (byte)num7;
						num = 377;
						goto end_IL_2667;
					case 177:
						array[22] = 38;
						num = 363;
						goto end_IL_2667;
					case 338:
						num5 = 137 - 45;
						num = 279;
						goto end_IL_2667;
					case 193:
						array[13] = 106;
						num = 331;
						goto end_IL_2667;
					case 301:
						num4 = 150 - 50;
						num2 = 224;
						goto end_IL_266b;
					case 190:
						array[12] = (byte)num7;
						num3 = 231;
						continue;
					case 411:
						num7 = 222 - 74;
						num3 = 381;
						continue;
					case 387:
						array[26] = (byte)num7;
						goto case 66;
					default:
						num2 = 66;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2d2f: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 17;
					case 168:
						array[5] = (byte)num4;
						num2 = 346;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 81;
					case 81:
						num4 = 166 - 55;
						num = 264;
						goto end_IL_2667;
					case 232:
					case 416:
						binaryReader.ReadInt32();
						num8 = (int)/*Error near IL_2d73: Stack underflow*/;
						num3 = 410;
						continue;
					case 396:
						array[24] = 134;
						num = 332;
						goto end_IL_2667;
					case 29:
						num6 = 115 + 24;
						num3 = 47;
						continue;
					case 230:
						num6 = 53 + 76;
						num = 17;
						goto end_IL_2667;
					case 173:
						array[21] = 107;
						num = 260;
						goto end_IL_2667;
					case 345:
						array[0] = (byte)num7;
						num = 156;
						goto end_IL_2667;
					case 93:
						array[31] = (byte)num7;
						num3 = 211;
						continue;
					case 125:
						array[17] = (byte)num7;
						num2 = 423;
						goto end_IL_266b;
					case 199:
						array[8] = 42;
						num2 = 35;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 57;
					case 57:
						array2[15] = (byte)num6;
						num2 = 155;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 63;
					case 63:
						num6 = 54 + 23;
						num2 = 269;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 398;
					case 398:
						array[20] = 135;
						num2 = 116;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 45;
					case 45:
						array[6] = 137;
						num2 = 365;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 378;
					case 378:
						if (array5 == null)
						{
							goto case 310;
						}
						num = 259;
						goto end_IL_2667;
					case 376:
						array[23] = 131;
						num3 = 275;
						continue;
					case 154:
						Array.Clear(array4, 0, array4.Length);
						num2 = 0;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_2f2f: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 322;
					case 322:
						array[13] = (byte)num7;
						num = 390;
						goto end_IL_2667;
					case 102:
						array[23] = (byte)num7;
						num3 = 235;
						continue;
					case 330:
						array4[13] = array5[6];
						num2 = 214;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 38;
					case 38:
						num10 = 0;
						num = 404;
						goto end_IL_2667;
					case 52:
						array[10] = (byte)num7;
						num2 = 316;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_2fa5: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 93;
					case 319:
						cryptoStream.FlushFinalBlock();
						num2 = 82;
						goto end_IL_266b;
					case 307:
						array2[10] = (byte)num5;
						num2 = 196;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 278;
					case 278:
						num7 = 181 - 60;
						num2 = 101;
						goto end_IL_266b;
					case 406:
						array[29] = (byte)num7;
						num2 = 414;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 213;
					case 213:
						array[14] = 166;
						num3 = 238;
						continue;
					case 155:
						num6 = 104 + 88;
						num = 9;
						goto end_IL_2667;
					case 272:
					case 305:
						array2[6] = 150;
						num = 97;
						goto end_IL_2667;
					case 290:
						num7 = 224 + 1;
						num2 = 142;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 15;
					case 15:
						array[18] = (byte)num7;
						num3 = 88;
						continue;
					case 171:
						array2[1] = 120;
						num3 = 92;
						continue;
					case 33:
						array2[1] = 112;
						num2 = 2;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 415;
					case 415:
						array4[11] = array5[5];
						num2 = 330;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 321;
					case 321:
						array[4] = (byte)num7;
						num2 = 290;
						goto end_IL_266b;
					case 114:
						array[25] = (byte)num7;
						num2 = 347;
						goto end_IL_266b;
					case 220:
						new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						cryptoStream = (CryptoStream)/*Error near IL_3142: Stack underflow*/;
						num2 = 366;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 169;
					case 169:
						num4 = 142 + 31;
						num2 = 8;
						goto end_IL_266b;
					case 2:
						num6 = 13 + 42;
						num2 = 342;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 141;
					case 141:
						array[0] = (byte)num4;
						num3 = 186;
						continue;
					case 294:
						num4 = 144 - 48;
						num = 353;
						goto end_IL_2667;
					case 23:
						array[14] = (byte)num4;
						num = 65;
						goto end_IL_2667;
					case 37:
						num6 = 49 + 44;
						num = 237;
						goto end_IL_2667;
					case 329:
						array[12] = 212;
						num2 = 206;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 49;
					case 49:
						array[29] = 35;
						num2 = 388;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_322e: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 326;
					case 326:
						array = new byte[32];
						num2 = 309;
						goto end_IL_266b;
					case 136:
						num5 = 23 + 61;
						num2 = 107;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_326c: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 340;
					case 340:
						array[19] = (byte)num7;
						num2 = 182;
						goto end_IL_266b;
					case 311:
						array2[5] = (byte)num6;
						num3 = 393;
						continue;
					case 390:
						array[13] = 100;
						num = 301;
						goto end_IL_2667;
					case 296:
						array2[3] = (byte)num5;
						num = 70;
						goto end_IL_2667;
					case 351:
						gX6byysyFa8Nv80gC9.e53w34m968awCm9P85taUZe(33554469);
						Type.GetTypeFromHandle((RuntimeTypeHandle)/*Error near IL_3ada: Stack underflow*/);
						_ = ((Type)/*Error near IL_3ae4: Stack underflow*/).Assembly;
						((Assembly)/*Error near IL_3aee: Stack underflow*/).GetName();
						((AssemblyName)/*Error near IL_3af8: Stack underflow*/).GetPublicKeyToken();
						array5 = (byte[])/*Error near IL_32f7: Stack underflow*/;
						num2 = 378;
						goto end_IL_266b;
					case 222:
						num7 = 96 + 47;
						num = 143;
						goto end_IL_2667;
					case 423:
						array[18] = 41;
						num = 183;
						goto end_IL_2667;
					case 211:
						array[31] = 184;
						num3 = 130;
						continue;
					case 215:
						num4 = 184 - 67;
						num2 = 23;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 344;
					case 344:
						num4 = 46 + 111;
						num = 210;
						goto end_IL_2667;
					case 316:
						array[10] = 75;
						num3 = 245;
						continue;
					case 286:
					case 374:
						HTadVgrdU(intPtr2, 4, num9, ref num9);
						num2 = 359;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_33cc: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 164;
					case 32:
						num4 = 238 - 79;
						num2 = 83;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 175;
					case 175:
						num9 = 0;
						num2 = 394;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_3405: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 360;
					case 410:
						HTadVgrdU(intPtr, num8 * 4, 4, ref num9);
						num = 38;
						goto end_IL_2667;
					case 198:
						array[2] = (byte)num7;
						num3 = 11;
						continue;
					case 336:
						array2[5] = (byte)num5;
						num3 = 20;
						continue;
					case 389:
						array[18] = (byte)num4;
						num2 = 73;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_3474: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 157;
					case 84:
						array[27] = (byte)num7;
						num2 = 55;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 400;
					case 400:
						array[0] = 86;
						num2 = 218;
						HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if ((int)/*Error near IL_34be: Stack underflow*/ == 0)
						{
							goto end_IL_266b;
						}
						goto case 144;
					case 144:
						array[21] = 98;
						num2 = 362;
						goto end_IL_266b;
					case 228:
						num4 = 42 + 37;
						num3 = 180;
						continue;
					case 363:
						num7 = 177 - 78;
						num = 137;
						goto end_IL_2667;
					case 314:
						array2[14] = 162;
						num2 = 338;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 186;
					case 186:
						num7 = 10 + 98;
						num2 = 285;
						if (true)
						{
							goto end_IL_266b;
						}
						goto case 50;
					case 50:
						num6 = 222 + 5;
						num2 = 43;
						goto end_IL_266b;
					case 218:
						array[0] = 170;
						num = 131;
						goto end_IL_2667;
					case 152:
						num5 = 57 + 73;
						num = 166;
						goto end_IL_2667;
					case 281:
						array4[3] = array5[1];
						num = 370;
						goto end_IL_2667;
					case 116:
						array[20] = 94;
						num = 34;
						goto end_IL_2667;
					case 42:
						num6 = 98 + 14;
						num = 221;
						goto end_IL_2667;
					case 392:
						symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
						transform = (ICryptoTransform)/*Error near IL_3601: Stack underflow*/;
						num = 94;
						goto end_IL_2667;
					case 166:
						array2[5] = (byte)num5;
						num3 = 145;
						continue;
					case 264:
						array[12] = (byte)num4;
						num2 = 72;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_3644: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 189;
					case 189:
						array2[15] = (byte)num5;
						num2 = 28;
						if (0 == 0)
						{
							goto end_IL_266b;
						}
						goto case 366;
					case 366:
						cryptoStream.Write(array3, 0, array3.Length);
						num2 = 319;
						if (1 == 0)
						{
							return;
						}
						goto end_IL_266b;
					case 426:
						return;
					case 270:
						_ = IntPtr.Size;
						if ((int)/*Error near IL_01f5: Stack underflow*/ == 4)
						{
							num2 = 1;
							if (true)
							{
								goto end_IL_266b;
							}
							goto case 256;
						}
						binaryReader.ReadInt32();
						BitConverter.GetBytes((int)/*Error near IL_36f2: Stack underflow*/);
						cJLRdxCVV((IntPtr)/*Error near IL_36fc: Stack underflow*/, (IntPtr)/*Error near IL_36fc: Stack underflow*/, (byte[])/*Error near IL_36fc: Stack underflow*/, 4u, out zero);
						num2 = 374;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_04c2: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 253;
					case 310:
						udTunHYcv();
						symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_03f5: Stack underflow*/;
						num2 = 18;
						HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if ((int)/*Error near IL_0408: Stack underflow*/ != 0)
						{
							goto end_IL_266b;
						}
						goto case 225;
					case 94:
						new MemoryStream();
						memoryStream = (MemoryStream)/*Error near IL_0c4f: Stack underflow*/;
						num3 = 220;
						continue;
					}
					array2[14] = 198;
					num2 = 219;
					HIqNmi47ta6wQLwpfy._008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if ((int)/*Error near IL_0032: Stack underflow*/ == 0)
					{
						break;
					}
					goto IL_0032;
					IL_009f:
					num7 = 220 - 73;
					num2 = 345;
					HIqNmi47ta6wQLwpfy._0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					if ((int)/*Error near IL_00c1: Stack underflow*/ != 0)
					{
						break;
					}
					goto IL_00c1;
					IL_00c1:
					array[23] = 117;
					num = 115;
					goto end_IL_2667;
					IL_0062:
					array2[9] = 111;
					num2 = 74;
					if (0 == 0)
					{
						break;
					}
					goto IL_0086;
					IL_0086:
					num7 = 53 + 60;
					num = 190;
					goto end_IL_2667;
					IL_004a:
					array[1] = (byte)num4;
					num = 251;
					goto end_IL_2667;
					IL_0032:
					array[30] = (byte)num4;
					num = 337;
					goto end_IL_2667;
					continue;
					end_IL_266b:
					break;
				}
				continue;
				end_IL_2667:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m1q7I8dyO(object _0020)
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
	private static extern int cJLRdxCVV(IntPtr _0020, IntPtr _0020, [In][Out] byte[] _0020, uint _0020, out IntPtr _0020);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
	private static extern int sv0k4vbiU(IntPtr _0020, IntPtr _0020, [In][Out] byte[] _0020, uint _0020, out IntPtr _0020);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	private static extern IntPtr SHHPxcicR(uint _0020, int _0020, uint _0020);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
	private static extern int pCaHOWZ4f(IntPtr _0020);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] NrTwpMKvx(string _0020)
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
	private static byte[] CCD3qYiN4(byte[] _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = udTunHYcv();
		symmetricAlgorithm.Key = new byte[32]
		{
			159, 71, 149, 63, 106, 229, 177, 135, 238, 44,
			95, 39, 118, 53, 20, 26, 133, 36, 43, 129,
			214, 48, 6, 111, 244, 33, 148, 147, 54, 209,
			96, 240
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			244, 231, 186, 48, 214, 81, 88, 240, 189, 130,
			77, 14, 70, 185, 197, 147
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(_0020, 0, _0020.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] Vl09BlPud()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] TBsfFWAFe()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] N4ZgMEXmY()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] Mj6etX78F()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] OAMMPbEjD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] ooC5SxdPK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] mFlyKkafw()
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
	internal byte[] NADhDrYrC()
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
	internal byte[] sUS8fdPQp()
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
	internal byte[] ghdbeO3tX()
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
	internal byte[] iKXmHHyvt()
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
	internal byte[] ViKarvWGw()
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
	internal static string cnyp1OpAu(string _0020, string _0020)
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
		byte[] iV = j36vuGIob(Encoding.Unicode.GetBytes(_0020));
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = udTunHYcv();
		symmetricAlgorithm.Key = key;
		symmetricAlgorithm.IV = iV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HIqNmi47ta6wQLwpfy()
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

	static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		return true;
	}

	static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		return false;
	}
}
