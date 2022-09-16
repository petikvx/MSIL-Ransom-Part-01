using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using LvkKBh2A1CcgxuCWgH4;
using Pj91rV27dKBAsuQFb5U;

namespace WEVFYJ2WPuik8y16vgG;

internal class nohvtg2Jq63jo2SldqX
{
	private delegate void yoEBjB2jCUrVeBtxTM2(object o);

	internal class dfibq52v8FF3QcRs81Z : Attribute
	{
		internal class txp9CP2BV6lyklXOOc0<onn9UW2nKXHWRWabfvl>
		{
			public txp9CP2BV6lyklXOOc0()
			{
				SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
				base._002Ector();
			}

			static txp9CP2BV6lyklXOOc0()
			{
				Yg2TdiiKvR();
			}
		}

		[dfibq52v8FF3QcRs81Z(typeof(txp9CP2BV6lyklXOOc0<object>[]))]
		public dfibq52v8FF3QcRs81Z(object object_0)
		{
		}
	}

	internal class RKdFEv2yGLEPUQpuEdf
	{
		[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
		internal static string mKroQvUMdF(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = L82TG36qcE(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Q7PTaaSMQs();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint muwb7d23FpMGEx9RJU3(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr AfjvqD2UGUYlhVseRJn();

	internal struct uAk2Fx2KnTqkkv2dDxN
	{
		internal bool lrCoCNQZrH;

		internal byte[] GIEo90d3gG;
	}

	internal class TRceT72NCfxwhwlm547
	{
		private BinaryReader SDSqI35QPQ;

		public TRceT72NCfxwhwlm547(Stream stream_0)
		{
			SDSqI35QPQ = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return SDSqI35QPQ.BaseStream;
		}

		internal byte[] hLYouDw72t(int int_0)
		{
			return SDSqI35QPQ.ReadBytes(int_0);
		}

		internal int GbnozRyBkT(byte[] byte_0, int int_0, int int_1)
		{
			return SDSqI35QPQ.Read(byte_0, int_0, int_1);
		}

		internal int KxsqZWNgkJ()
		{
			return SDSqI35QPQ.ReadInt32();
		}

		internal void osbq2Qgyt1()
		{
			SDSqI35QPQ.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr pRiNFX2OS33VKU4uN6f(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr iKX7ap2lXZr0QVTbby0(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int uZX6eo2SaDNo6WxZIym(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int EUDhdH21SLRkS1Li1Ir(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr KNxMAO2xY34HPwkjyeo(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Y2BKq72VSSqAn3NvZYp(IntPtr ptr);

	[Flags]
	private enum J0QvhN2hr6vqVwjhQgd
	{

	}

	private static int UgtoVvIWg0;

	private static SortedList iEHoeXCfsb;

	internal static muwb7d23FpMGEx9RJU3 kiuoAQvFyn;

	internal static muwb7d23FpMGEx9RJU3 dcGoHB4qME;

	internal static Hashtable wKeoR0wRgk;

	private static iKX7ap2lXZr0QVTbby0 aaTotG7H9c;

	private static Y2BKq72VSSqAn3NvZYp ADFoFAWXoP;

	private static uint[] i9tovHyEcx;

	private static EUDhdH21SLRkS1Li1Ir epxokEX8Q5;

	private static long pA8oaADjnm;

	private static KNxMAO2xY34HPwkjyeo cXforJfXKU;

	internal static Assembly DTIojLuxNb;

	private static pRiNFX2OS33VKU4uN6f miCobsumv7;

	private static IntPtr KP2olP6BK1;

	private static IntPtr QfsoSohqES;

	private static int[] aaQoxFl9uC;

	private static bool ql0ohaY68i;

	private static bool vywoGy37Q5;

	private static long p75oLjPKdt;

	private static IntPtr vYGoXdXGZT;

	private static bool ruHocsJRIW;

	private static int b9HowHSgWi;

	[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
	private static bool Bkvod85dRo;

	private static object vKjoKQhsk7;

	private static bool DdToBEBD3n;

	private static uZX6eo2SaDNo6WxZIym LYUogrVnqR;

	private static object uSXo1ZoU5k;

	private static byte[] YiuoyNDGHZ;

	private static bool uJjonUoqGv;

	private static int vxfo7AnpT6;

	private static Dictionary<int, int> GlnoUGxbsp;

	internal static RSACryptoServiceProvider NeYo3BNTiO;

	private static bool DI7oWX1cPX;

	private static IntPtr fHNo0BJJda;

	private static byte[] opeoNSUdK0;

	private static byte[] IU1oOu1fQy;

	private static int b6hoijwUtf;

	static nohvtg2Jq63jo2SldqX()
	{
		DI7oWX1cPX = false;
		DTIojLuxNb = Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554496)).Assembly;
		i9tovHyEcx = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		DdToBEBD3n = false;
		uJjonUoqGv = false;
		YiuoyNDGHZ = new byte[0];
		NeYo3BNTiO = null;
		GlnoUGxbsp = null;
		vKjoKQhsk7 = new object();
		opeoNSUdK0 = new byte[0];
		IU1oOu1fQy = new byte[0];
		KP2olP6BK1 = IntPtr.Zero;
		QfsoSohqES = IntPtr.Zero;
		uSXo1ZoU5k = new string[0];
		aaQoxFl9uC = new int[0];
		UgtoVvIWg0 = 1;
		ql0ohaY68i = false;
		iEHoeXCfsb = new SortedList();
		vxfo7AnpT6 = 0;
		p75oLjPKdt = 0L;
		kiuoAQvFyn = null;
		dcGoHB4qME = null;
		pA8oaADjnm = 0L;
		b6hoijwUtf = 0;
		vywoGy37Q5 = false;
		ruHocsJRIW = false;
		b9HowHSgWi = 0;
		fHNo0BJJda = IntPtr.Zero;
		Bkvod85dRo = false;
		wKeoR0wRgk = new Hashtable();
		miCobsumv7 = null;
		aaTotG7H9c = null;
		LYUogrVnqR = null;
		epxokEX8Q5 = null;
		cXforJfXKU = null;
		ADFoFAWXoP = null;
		vYGoXdXGZT = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void uf2k2FY0oFYfM()
	{
	}

	internal static byte[] yytTVIcAlX(byte[] byte_0)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(byte_0.Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(byte_0.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array2[i] = byte_0[i];
		}
		array2[byte_0.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFuL);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16u; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = uint_;
			uint num11 = uint_2;
			uint num12 = uint_3;
			uint num13 = uint_4;
			BTuThijxIL(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			BTuThijxIL(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			BTuThijxIL(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			BTuThijxIL(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			BTuThijxIL(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			BTuThijxIL(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			BTuThijxIL(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			BTuThijxIL(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			BTuThijxIL(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			BTuThijxIL(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			BTuThijxIL(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			BTuThijxIL(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			BTuThijxIL(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			BTuThijxIL(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			BTuThijxIL(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			BTuThijxIL(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			jP0TebA25l(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			jP0TebA25l(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			jP0TebA25l(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			jP0TebA25l(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			jP0TebA25l(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			jP0TebA25l(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			jP0TebA25l(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			jP0TebA25l(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			jP0TebA25l(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			jP0TebA25l(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			jP0TebA25l(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			jP0TebA25l(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			jP0TebA25l(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			jP0TebA25l(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			jP0TebA25l(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			jP0TebA25l(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			uFNT7XRhtr(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			uFNT7XRhtr(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			uFNT7XRhtr(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			uFNT7XRhtr(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			uFNT7XRhtr(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			uFNT7XRhtr(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			uFNT7XRhtr(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			uFNT7XRhtr(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			uFNT7XRhtr(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			uFNT7XRhtr(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			uFNT7XRhtr(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			uFNT7XRhtr(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			uFNT7XRhtr(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			uFNT7XRhtr(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			uFNT7XRhtr(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			uFNT7XRhtr(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			NORTLpBDPE(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			NORTLpBDPE(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			NORTLpBDPE(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			NORTLpBDPE(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			NORTLpBDPE(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			NORTLpBDPE(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			NORTLpBDPE(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			NORTLpBDPE(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			NORTLpBDPE(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			NORTLpBDPE(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			NORTLpBDPE(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			NORTLpBDPE(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			NORTLpBDPE(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			NORTLpBDPE(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			NORTLpBDPE(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			NORTLpBDPE(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void BTuThijxIL(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + cUITAAAfB6(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + i9tovHyEcx[uint_5 - 1], ushort_0);
	}

	private static void jP0TebA25l(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + cUITAAAfB6(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + i9tovHyEcx[uint_5 - 1], ushort_0);
	}

	private static void uFNT7XRhtr(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + cUITAAAfB6(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + i9tovHyEcx[uint_5 - 1], ushort_0);
	}

	private static void NORTLpBDPE(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + cUITAAAfB6(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + i9tovHyEcx[uint_5 - 1], ushort_0);
	}

	private static uint cUITAAAfB6(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool gdlTH5QXpi()
	{
		if (!DdToBEBD3n)
		{
			TnlTixuu15();
			DdToBEBD3n = true;
		}
		return uJjonUoqGv;
	}

	internal static SymmetricAlgorithm Q7PTaaSMQs()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (gdlTH5QXpi())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")!.Unwrap();
		}
	}

	internal static void TnlTixuu15()
	{
		try
		{
			uJjonUoqGv = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] L82TG36qcE(byte[] byte_0)
	{
		if (!gdlTH5QXpi())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return yytTVIcAlX(byte_0);
	}

	internal static void WhOTcRmk1b(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			wEaTwVPYP0(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void wEaTwVPYP0(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint vYET0uEXhS(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_0)
			{
				binaryReader_0.BaseStream.Position = long_0 + (num * 40 + 8);
				uint num2 = binaryReader_0.ReadUInt32();
				num3 = binaryReader_0.ReadUInt32();
				binaryReader_0.ReadUInt32();
				num4 = binaryReader_0.ReadUInt32();
				if (num3 <= uint_0 && uint_0 < num3 + num2)
				{
					break;
				}
				num++;
				continue;
			}
			return 0u;
		}
		return num4 + uint_0 - num3;
	}

	[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
	internal static void Yg2TdiiKvR()
	{
		int num = 11;
		HashAlgorithm object_ = default(HashAlgorithm);
		string text = default(string);
		string object_2 = default(string);
		int num4 = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num10 = default(int);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		int num8 = default(int);
		int num6 = default(int);
		byte[] array3 = default(byte[]);
		byte[] object_6 = default(byte[]);
		Stream stream = default(Stream);
		byte[] object_7 = default(byte[]);
		CryptoStream object_4 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		int num12 = default(int);
		uint num27 = default(uint);
		long num24 = default(long);
		long num14 = default(long);
		uint num22 = default(uint);
		byte[] array4 = default(byte[]);
		long num15 = default(long);
		uint num20 = default(uint);
		long long_ = default(long);
		long num19 = default(long);
		int num17 = default(int);
		int num18 = default(int);
		int num16 = default(int);
		uint num26 = default(uint);
		bool flag2 = default(bool);
		uint uint_2 = default(uint);
		BinaryReader object_8 = default(BinaryReader);
		uint num25 = default(uint);
		uint uint_ = default(uint);
		uint num23 = default(uint);
		int int_ = default(int);
		byte[] array5 = default(byte[]);
		int num29 = default(int);
		while (true)
		{
			if (NeYo3BNTiO == null)
			{
				goto IL_0013;
			}
			int num2 = 10;
			if (!HRMuyG74s1F1LraH2X())
			{
				goto IL_2969;
			}
			goto IL_29fb;
			IL_2969:
			num2 = num;
			goto IL_29fb;
			IL_29fb:
			while (true)
			{
				switch (num2)
				{
				case 11:
					break;
				case 17:
					goto IL_0013;
				case 18:
					try
					{
						object_ = (HashAlgorithm)AV5UY4FE6FyfbVYf5f();
						int num3 = 0;
						if (!HRMuyG74s1F1LraH2X())
						{
							goto IL_0073;
						}
						goto IL_0077;
						IL_0077:
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (!lsV2a0jnl5SoHNULIX(text))
								{
									num3 = 3;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
								}
								goto end_IL_0077;
							default:
								object_2 = (string)pojuUl6sUmKuJq4lnG("SHA1");
								num3 = 2;
								if (HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 1:
								goto end_IL_0077;
							case 3:
								return;
							}
							goto IL_0073;
							continue;
							end_IL_0077:
							break;
						}
						goto end_IL_002d;
						IL_0073:
						num3 = num4;
						goto IL_0077;
						end_IL_002d:;
					}
					catch
					{
						if (dY6S0BqF5MmlTUa3Y1() == null)
						{
							switch (0)
							{
							}
						}
						return;
					}
					goto case 14;
				case 14:
					flag = false;
					num2 = 5;
					if (dY6S0BqF5MmlTUa3Y1() != null)
					{
						continue;
					}
					goto case 7;
				case 7:
					try
					{
						TRceT72NCfxwhwlm547 object_3 = new TRceT72NCfxwhwlm547((Stream)ypHHtEYD6U9UdK42yv(DTIojLuxNb, "SJRpaepXOqoSyK5cI8.EZKv7lDBbsYn4ULXMk"));
						while (true)
						{
							ccBrmu39uLdoewYxmu(pJKp5w048lBFoh7vvR(object_3), 0L);
							int num5 = 277;
							if (dY6S0BqF5MmlTUa3Y1() != null)
							{
								goto IL_011f;
							}
							goto IL_1cc3;
							IL_1cc3:
							while (true)
							{
								switch (num5)
								{
								case 355:
									array[6] = (byte)num9;
									num10 = 224;
									goto case 224;
								case 224:
									array[7] = 95;
									goto case 12;
								case 12:
									num7 = 135;
									num5 = 137;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 354:
									num9 = 71;
									goto case 355;
								case 353:
									num7 = 46;
									goto case 132;
								case 132:
									array[9] = (byte)num7;
									goto case 346;
								case 346:
									num9 = 91;
									num5 = 170;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 352:
									array2[28] = 124;
									num5 = 63;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 104;
								case 104:
									array2[28] = 158;
									num5 = 40;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto default;
								default:
									array2[16] = 230;
									num10 = 285;
									goto case 285;
								case 285:
									num8 = 121;
									goto case 181;
								case 181:
									array2[17] = (byte)num8;
									num10 = 267;
									goto case 267;
								case 267:
									num8 = 132;
									goto case 258;
								case 258:
									array2[17] = (byte)num8;
									num5 = 283;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 224;
								case 351:
									num8 = 96;
									num5 = 15;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 4;
								case 4:
									array[11] = 116;
									num5 = 310;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 350:
									num7 = 69;
									goto case 259;
								case 259:
									array[3] = (byte)num7;
									goto case 22;
								case 22:
									array[3] = 114;
									goto case 171;
								case 171:
									array[3] = 87;
									num5 = 313;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 106;
								case 106:
									array2[18] = 95;
									goto case 18;
								case 18:
									array2[18] = 165;
									goto case 173;
								case 173:
									array2[18] = 252;
									num5 = 87;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 348:
									array2[29] = (byte)num6;
									num5 = 308;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 347:
									array2[11] = 157;
									goto case 185;
								case 185:
									array2[11] = 87;
									goto case 291;
								case 291:
									array2[12] = 127;
									goto case 322;
								case 322:
									array2[12] = 131;
									goto case 179;
								case 179:
									num8 = 126;
									goto case 5;
								case 5:
									array2[12] = (byte)num8;
									num5 = 23;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 49;
								case 49:
									array2[12] = 146;
									num5 = 336;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 345:
									num8 = 118;
									goto case 298;
								case 298:
									array2[30] = (byte)num8;
									goto case 162;
								case 162:
									num6 = 138;
									goto case 93;
								case 93:
									array2[30] = (byte)num6;
									goto case 206;
								case 206:
									array2[30] = 125;
									goto case 107;
								case 107:
									array2[30] = 98;
									num5 = 203;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 177;
								case 177:
									array[13] = 197;
									goto case 66;
								case 66:
									num9 = 115;
									num5 = 219;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 344:
									array2[12] = (byte)num8;
									goto case 76;
								case 76:
									array2[12] = 197;
									goto case 117;
								case 117:
									num6 = 163;
									goto case 327;
								case 327:
									array2[13] = (byte)num6;
									num5 = 2;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 2;
								case 2:
									array2[13] = 103;
									goto case 152;
								case 152:
									num6 = 152;
									goto case 140;
								case 140:
									array2[13] = (byte)num6;
									num5 = 256;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 245;
								case 245:
									array2[11] = (byte)num6;
									num10 = 347;
									goto case 347;
								case 343:
									array[6] = 196;
									num5 = 234;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 275;
								case 275:
									num9 = 126;
									goto case 208;
								case 208:
									array[6] = (byte)num9;
									goto case 270;
								case 270:
									num7 = 96;
									num10 = 332;
									goto case 332;
								case 332:
									array[6] = (byte)num7;
									num10 = 70;
									goto case 70;
								case 70:
									array[6] = 169;
									goto case 354;
								case 342:
									array2[9] = 160;
									num5 = 71;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 341:
									array2[18] = (byte)num8;
									goto case 167;
								case 167:
									array2[18] = 106;
									num5 = 10;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 6;
								case 6:
									array2[9] = 164;
									goto case 271;
								case 271:
									array2[10] = 64;
									goto case 82;
								case 82:
									array2[10] = 85;
									num5 = 142;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 340:
									num7 = 231;
									num5 = 253;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 339:
									array2[17] = (byte)num8;
									goto case 334;
								case 334:
									num8 = 164;
									num5 = 51;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 57;
								case 57:
									array2[17] = (byte)num8;
									goto case 21;
								case 21:
									array2[17] = 241;
									goto case 331;
								case 331:
									num8 = 106;
									goto case 341;
								case 338:
									array2[26] = (byte)num8;
									num5 = 39;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 337:
									array2[14] = (byte)num8;
									goto case 134;
								case 134:
									num8 = 115;
									num5 = 101;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 151;
								case 151:
									array2[15] = (byte)num8;
									num10 = 252;
									goto case 252;
								case 252:
									array2[15] = 159;
									goto case 230;
								case 230:
									num8 = 84;
									goto case 61;
								case 61:
									array2[15] = (byte)num8;
									goto case 193;
								case 193:
									array2[15] = 14;
									goto case 175;
								case 175:
									num6 = 162;
									num5 = 178;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 336:
									num8 = 97;
									num5 = 344;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 250;
								case 250:
									num6 = 142;
									num10 = 85;
									goto case 85;
								case 85:
									array2[5] = (byte)num6;
									goto case 103;
								case 103:
									num8 = 104;
									num5 = 124;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 335:
									array[5] = (byte)num9;
									num5 = 223;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 193;
								case 333:
									num9 = 145;
									goto case 316;
								case 316:
									array[7] = (byte)num9;
									num10 = 20;
									goto case 20;
								case 20:
									num9 = 150;
									num10 = 254;
									goto case 254;
								case 254:
									array[7] = (byte)num9;
									num10 = 218;
									goto case 218;
								case 218:
									num9 = 162;
									goto case 141;
								case 141:
									array[8] = (byte)num9;
									goto case 101;
								case 101:
									num9 = 96;
									num5 = 161;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 96;
								case 96:
									array[5] = 131;
									goto case 35;
								case 35:
									num7 = 94;
									num5 = 319;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 329:
									num6 = 163;
									goto case 92;
								case 92:
									array2[14] = (byte)num6;
									num5 = 78;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 44;
								case 44:
									array2[3] = (byte)num6;
									goto case 174;
								case 174:
									num8 = 165;
									goto case 306;
								case 306:
									array2[4] = (byte)num8;
									num5 = 244;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 328:
									array2[1] = (byte)num6;
									goto case 324;
								case 324:
									array2[1] = 90;
									num10 = 281;
									goto case 281;
								case 281:
									array2[1] = 53;
									num5 = 186;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 167;
								case 326:
									array2[2] = (byte)num8;
									num5 = 190;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 226;
								case 226:
									num8 = 81;
									goto case 73;
								case 73:
									array2[2] = (byte)num8;
									num5 = 299;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 266;
								case 266:
									array2[20] = 138;
									goto case 80;
								case 80:
									num8 = 140;
									num5 = 78;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 91;
								case 91:
									array2[20] = (byte)num8;
									goto case 261;
								case 261:
									array2[20] = 127;
									goto case 102;
								case 102:
									array2[20] = 126;
									num10 = 255;
									goto case 255;
								case 255:
									num6 = 159;
									goto case 65;
								case 65:
									array2[20] = (byte)num6;
									num5 = 304;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 325:
									array[10] = (byte)num9;
									num5 = 323;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 323:
									array[10] = 60;
									goto case 154;
								case 154:
									array[11] = 163;
									goto case 169;
								case 169:
									num7 = 103;
									goto case 278;
								case 278:
									array[11] = (byte)num7;
									goto case 121;
								case 121:
									num7 = 152;
									goto case 130;
								case 130:
									array[11] = (byte)num7;
									num10 = 4;
									goto case 4;
								case 321:
									num6 = 144;
									num5 = 11;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 320:
									array2[6] = 138;
									goto case 232;
								case 232:
									array2[6] = 203;
									num5 = 260;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 319:
									array[5] = (byte)num7;
									goto case 143;
								case 143:
									num7 = 158;
									num10 = 30;
									goto case 30;
								case 30:
									array[5] = (byte)num7;
									num5 = 126;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 318:
									num8 = 121;
									goto case 326;
								case 317:
									array2[13] = 158;
									goto case 42;
								case 42:
									array2[13] = 66;
									num10 = 329;
									goto case 329;
								case 315:
									array[0] = 246;
									goto case 100;
								case 100:
									array[1] = 132;
									goto case 38;
								case 38:
									array[1] = 29;
									goto case 241;
								case 241:
									num7 = 166;
									num5 = 90;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 159;
								case 159:
									array[1] = (byte)num7;
									num5 = 179;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 184;
								case 184:
									num7 = 192;
									num5 = 13;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 10;
								case 10:
									array2[18] = 219;
									num5 = 106;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 314:
									array[12] = (byte)num7;
									num5 = 12;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 52;
								case 52:
									num9 = 113;
									num5 = 247;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 313:
									num9 = 202;
									num5 = 296;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 312:
									num9 = 107;
									goto case 212;
								case 212:
									array[12] = (byte)num9;
									num5 = 129;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 311:
									array2[16] = (byte)num6;
									goto case 300;
								case 300:
									num6 = 90;
									goto case 74;
								case 74:
									array2[16] = (byte)num6;
									num5 = 0;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 310:
									num9 = 126;
									goto case 50;
								case 50:
									array[12] = (byte)num9;
									goto case 88;
								case 88:
									num9 = 148;
									goto case 77;
								case 77:
									array[12] = (byte)num9;
									goto case 51;
								case 51:
									num7 = 163;
									num5 = 314;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 163;
								case 163:
									num6 = 98;
									goto case 53;
								case 53:
									array2[29] = (byte)num6;
									goto case 345;
								case 309:
									array2[28] = (byte)num8;
									goto case 222;
								case 222:
									array2[28] = 150;
									num5 = 54;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 182;
								case 182:
									array2[28] = 94;
									goto case 110;
								case 110:
									array2[29] = 105;
									goto case 264;
								case 264:
									num6 = 87;
									goto case 348;
								case 308:
									num8 = 166;
									num5 = 197;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 307:
									array2[8] = 128;
									goto case 288;
								case 288:
									num8 = 131;
									goto case 47;
								case 47:
									array2[8] = (byte)num8;
									goto case 321;
								case 305:
									array[2] = 31;
									goto case 27;
								case 27:
									array[3] = 154;
									goto case 350;
								case 304:
									array2[21] = 69;
									goto case 72;
								case 72:
									array2[21] = 136;
									goto case 3;
								case 3:
									array2[21] = 102;
									num5 = 99;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 303:
									num7 = 159;
									num5 = 249;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 302:
									num8 = 205;
									num10 = 337;
									goto case 337;
								case 301:
									array2[9] = 91;
									goto case 6;
								case 299:
									array2[2] = 164;
									goto case 289;
								case 289:
									num8 = 204;
									num5 = 73;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 138;
								case 138:
									array2[2] = (byte)num8;
									goto case 229;
								case 229:
									num8 = 135;
									num10 = 122;
									goto case 122;
								case 122:
									array2[3] = (byte)num8;
									goto case 157;
								case 157:
									array2[3] = 192;
									goto case 265;
								case 265:
									num6 = 116;
									num5 = 191;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 297:
									array[15] = 84;
									goto case 94;
								case 94:
									array[15] = 111;
									goto case 55;
								case 55:
									array[15] = 137;
									num5 = 45;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 296:
									array[4] = (byte)num9;
									goto case 205;
								case 205:
									num7 = 159;
									goto case 217;
								case 217:
									array[4] = (byte)num7;
									goto case 340;
								case 295:
									array[2] = 186;
									goto case 14;
								case 14:
									num9 = 135;
									num5 = 243;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 294:
									num8 = 87;
									goto case 32;
								case 32:
									array2[19] = (byte)num8;
									goto case 266;
								case 293:
									array2[27] = (byte)num6;
									num5 = 37;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 215;
								case 215:
									array2[27] = 47;
									goto case 196;
								case 196:
									array2[27] = 158;
									goto case 282;
								case 282:
									array2[27] = 115;
									num10 = 56;
									goto case 56;
								case 56:
									array2[27] = 213;
									goto case 352;
								case 292:
									num6 = 113;
									goto case 43;
								case 43:
									array2[8] = (byte)num6;
									goto case 307;
								case 290:
									num8 = 25;
									goto case 286;
								case 286:
									array2[26] = (byte)num8;
									goto case 279;
								case 279:
									array2[26] = 92;
									num5 = 69;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 287:
									array[14] = (byte)num7;
									goto case 172;
								case 172:
									array[14] = 97;
									num5 = 1;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 284:
									array2[25] = (byte)num8;
									goto case 228;
								case 228:
									array2[26] = 185;
									num5 = 290;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 283:
									num8 = 113;
									goto case 339;
								case 280:
									array[15] = 128;
									num10 = 297;
									goto case 297;
								case 277:
									array3 = (byte[])UP49qSN16POWf50Uld(object_3, (int)EKTUoewNuh24chQ5UM(pJKp5w048lBFoh7vvR(object_3)));
									goto case 194;
								case 194:
									array2 = new byte[32];
									goto case 213;
								case 213:
									array2[0] = 131;
									num5 = 166;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 276:
									array2[8] = (byte)num6;
									num5 = 204;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 46;
								case 46:
									array2[25] = (byte)num6;
									goto case 199;
								case 199:
									array2[25] = 172;
									goto case 23;
								case 23:
									num8 = 61;
									num5 = 153;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 168;
								case 168:
									array2[25] = (byte)num8;
									goto case 242;
								case 242:
									num8 = 54;
									goto case 284;
								case 274:
									object_6 = array2;
									goto case 246;
								case 246:
									array = new byte[16];
									goto case 164;
								case 164:
									array[0] = 131;
									goto case 210;
								case 210:
									array[0] = 104;
									num10 = 214;
									goto case 214;
								case 214:
									num7 = 184;
									num5 = 60;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 273:
									num6 = 121;
									num5 = 90;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 272:
									array2[23] = (byte)num6;
									num5 = 209;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 142;
								case 142:
									array2[10] = 196;
									goto case 28;
								case 28:
									num8 = 118;
									num5 = 158;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 77;
								case 269:
									array2[4] = 253;
									goto case 190;
								case 190:
									num8 = 126;
									goto case 83;
								case 83:
									array2[5] = (byte)num8;
									goto case 257;
								case 257:
									num8 = 130;
									goto case 84;
								case 84:
									array2[5] = (byte)num8;
									goto case 250;
								case 268:
									array2[23] = 69;
									goto case 147;
								case 147:
									array2[24] = 86;
									goto case 34;
								case 34:
									num8 = 85;
									goto case 227;
								case 227:
									array2[24] = (byte)num8;
									num5 = 21;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 33;
								case 33:
									array2[24] = 147;
									num5 = 89;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 68;
								case 68:
									num9 = 117;
									num5 = 58;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 263:
									XbGrh2lZR8EmnAlRTf(stream);
									num5 = 48;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 262:
									array[1] = (byte)num7;
									num5 = 82;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 295;
								case 260:
									array2[7] = 220;
									num5 = 24;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 116;
								case 116:
									array2[7] = 86;
									num5 = 54;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 256:
									num6 = 142;
									goto case 9;
								case 9:
									array2[13] = (byte)num6;
									goto case 317;
								case 253:
									array[4] = (byte)num7;
									goto case 96;
								case 251:
									array2[9] = 162;
									num5 = 301;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 130;
								case 249:
									array[13] = (byte)num7;
									goto case 118;
								case 118:
									num9 = 84;
									num5 = 248;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 248:
									array[13] = (byte)num9;
									goto case 236;
								case 236:
									num9 = 122;
									num5 = 144;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 76;
								case 247:
									array[12] = (byte)num9;
									num5 = 312;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 187;
								case 187:
									object_7 = array;
									num5 = 114;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 244:
									num8 = 144;
									num10 = 200;
									goto case 200;
								case 200:
									array2[4] = (byte)num8;
									num5 = 269;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 243:
									array[2] = (byte)num9;
									goto case 183;
								case 183:
									array[2] = 192;
									num5 = 305;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 240:
									array2[5] = (byte)num6;
									goto case 64;
								case 64:
									array2[5] = 195;
									num5 = 216;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 239:
									num8 = 115;
									num5 = 25;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 238:
									array[15] = (byte)num7;
									goto case 187;
								case 235:
									tOO50pCrVim9HnylGr(object_4, array3, 0, array3.Length);
									goto case 165;
								case 165:
									LuNhjdnupM6C0ndGZx(object_4);
									goto case 8;
								case 8:
									Yv1tIAZ0PncJ9h4IyM(NeYo3BNTiO, iF0oKhigsH2qsay2VR(wL8HBfW31VG6Xhnvcl(), Y7uyFMLqdGuK9Gp43L(stream)));
									goto case 263;
								case 234:
									array2[31] = 99;
									num5 = 274;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 233:
									num9 = 195;
									goto case 335;
								case 231:
									array[9] = 206;
									goto case 109;
								case 109:
									array[10] = 168;
									goto case 160;
								case 160:
									num9 = 115;
									goto case 136;
								case 136:
									array[10] = (byte)num9;
									goto case 7;
								case 7:
									num7 = 164;
									num10 = 17;
									goto case 17;
								case 17:
									array[10] = (byte)num7;
									goto case 128;
								case 128:
									num9 = 97;
									goto case 325;
								case 225:
									num6 = 125;
									num5 = 328;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 322;
								case 223:
									num7 = 119;
									num5 = 198;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 221:
									array[8] = 148;
									goto case 353;
								case 220:
									array2[22] = (byte)num6;
									goto case 148;
								case 148:
									num6 = 142;
									goto case 272;
								case 219:
									array[14] = (byte)num9;
									num5 = 115;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 216:
									array2[6] = 158;
									goto case 320;
								case 211:
									num9 = 174;
									num5 = 188;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 209:
									num8 = 170;
									num5 = 19;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 207:
									array[0] = (byte)num7;
									num5 = 315;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 89;
								case 89:
									num6 = 102;
									goto case 46;
								case 204:
									array2[8] = 199;
									goto case 292;
								case 203:
									num6 = 239;
									goto case 180;
								case 180:
									array2[30] = (byte)num6;
									num10 = 98;
									goto case 98;
								case 98:
									array2[31] = 127;
									num5 = 273;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 202:
									num8 = 148;
									num5 = 81;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 3;
								case 201:
									num9 = 167;
									num5 = 116;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 123;
								case 123:
									array[7] = (byte)num9;
									goto case 333;
								case 198:
									array[6] = (byte)num7;
									goto case 343;
								case 197:
									array2[29] = (byte)num8;
									num5 = 163;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 158;
								case 158:
									array2[11] = (byte)num8;
									num5 = 75;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 63;
								case 63:
									array2[7] = (byte)num8;
									goto case 176;
								case 176:
									array2[8] = 126;
									num5 = 59;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 35;
								case 195:
									num6 = 122;
									goto case 112;
								case 112:
									array2[31] = (byte)num6;
									goto case 31;
								case 31:
									array2[31] = 159;
									num5 = 156;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 234;
								case 192:
									num8 = 193;
									num5 = 309;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 191:
									array2[3] = (byte)num6;
									num5 = 67;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 189:
									num7 = 126;
									num5 = 207;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 188:
									array[13] = (byte)num9;
									goto case 177;
								case 186:
									num6 = 35;
									goto case 24;
								case 24:
									array2[2] = (byte)num6;
									goto case 318;
								case 178:
									array2[16] = (byte)num6;
									goto case 351;
								case 170:
									array[9] = (byte)num9;
									num5 = 131;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 166:
									array2[0] = 79;
									goto case 127;
								case 127:
									array2[0] = 82;
									num5 = 4;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 202;
								case 161:
									array[8] = (byte)num9;
									goto case 68;
								case 156:
									array[9] = (byte)num7;
									num5 = 231;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 155:
									array2[21] = 157;
									goto case 37;
								case 37:
									num6 = 127;
									goto case 86;
								case 86:
									array2[22] = (byte)num6;
									num5 = 97;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 153:
									array[0] = 196;
									num5 = 189;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 150:
									array[5] = (byte)num9;
									num5 = 83;
									if (dY6S0BqF5MmlTUa3Y1() != null)
									{
										continue;
									}
									goto case 233;
								case 149:
									num9 = 178;
									goto case 150;
								case 146:
									stream = (Stream)Y0cE1HKT6KZk7TWN7c();
									num5 = 135;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 145:
									array2[19] = 207;
									num5 = 294;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 144:
									array[13] = (byte)num9;
									num5 = 211;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 139:
									num7 = 127;
									goto case 156;
								case 137:
									array[7] = (byte)num7;
									goto case 105;
								case 105:
									array[7] = 121;
									goto case 201;
								case 135:
									object_4 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
									goto case 235;
								case 133:
									array[9] = 156;
									goto case 139;
								case 131:
									num7 = 143;
									num10 = 79;
									goto case 79;
								case 79:
									array[9] = (byte)num7;
									goto case 133;
								case 129:
									num9 = 115;
									num5 = 36;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 126:
									array[5] = 138;
									goto case 149;
								case 125:
									num6 = 150;
									goto case 311;
								case 124:
									array2[5] = (byte)num8;
									num5 = 119;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 120:
									array[8] = (byte)num9;
									goto case 221;
								case 119:
									num6 = 103;
									goto case 240;
								case 115:
									num7 = 113;
									goto case 287;
								case 114:
									object_5 = (SymmetricAlgorithm)gkYcQbxEJvFG5InQ2F();
									num5 = 113;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 113:
									Q1LoHbfUH5gyyTPTFv(object_5, CipherMode.CBC);
									num5 = 26;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 111:
									num7 = 150;
									goto case 262;
								case 108:
									num6 = 130;
									num5 = 293;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 99:
									array2[21] = 150;
									goto case 155;
								case 97:
									array2[22] = 108;
									num5 = 16;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 95:
									num9 = 64;
									goto case 120;
								case 90:
									array2[31] = (byte)num6;
									goto case 195;
								case 87:
									array2[19] = 101;
									num5 = 145;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 81:
									array2[1] = (byte)num8;
									num5 = 62;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 78:
									array2[14] = 113;
									num10 = 302;
									goto case 302;
								case 75:
									num6 = 120;
									num5 = 245;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto case 200;
								case 71:
									array2[9] = 125;
									num10 = 251;
									goto case 251;
								case 69:
									num8 = 99;
									goto case 338;
								case 67:
									num6 = 29;
									goto case 44;
								case 62:
									array2[1] = 108;
									goto case 225;
								case 60:
									array[0] = (byte)num7;
									goto case 153;
								case 59:
									num6 = 84;
									goto case 276;
								case 58:
									array[8] = (byte)num9;
									goto case 95;
								case 54:
									array2[7] = 120;
									goto case 41;
								case 41:
									num8 = 239;
									num5 = 9;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 63;
								case 45:
									num7 = 135;
									goto case 238;
								case 40:
									array2[28] = 102;
									goto case 192;
								case 39:
									array2[26] = 132;
									num5 = 108;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 36:
									array[13] = (byte)num9;
									goto case 303;
								case 29:
									array[14] = 7;
									goto case 280;
								case 26:
									transform = (ICryptoTransform)N3USZwPkqV5dNNyyur(object_5, object_6, object_7);
									goto case 146;
								case 25:
									array2[16] = (byte)num8;
									goto case 125;
								case 19:
									array2[23] = (byte)num8;
									goto case 268;
								case 16:
									num6 = 0;
									goto case 220;
								case 15:
									array2[16] = (byte)num8;
									num5 = 239;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									goto IL_011f;
								case 13:
									array[1] = (byte)num7;
									goto case 111;
								case 11:
									array2[9] = (byte)num6;
									num5 = 342;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto IL_011f;
								case 1:
									array[14] = 170;
									num5 = 8;
									if (!HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									goto case 29;
								case 330:
									break;
								case 48:
									XbGrh2lZR8EmnAlRTf(object_4);
									goto case 349;
								case 349:
									uZydowV7MLCynR40d9(object_3);
									goto end_IL_225d;
								case 237:
									goto end_IL_225d;
								}
								break;
							}
							continue;
							IL_011f:
							num5 = num10;
							goto IL_1cc3;
							continue;
							end_IL_225d:
							break;
						}
					}
					catch
					{
						int num11 = 1;
						if (dY6S0BqF5MmlTUa3Y1() != null)
						{
							num11 = num12;
						}
						while (true)
						{
							switch (num11)
							{
							case 1:
								flag = true;
								num11 = 0;
								if (!HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 12;
				case 6:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num13 = 0;
						if (dY6S0BqF5MmlTUa3Y1() != null)
						{
							goto IL_2333;
						}
						goto IL_27e6;
						IL_27e6:
						while (true)
						{
							int num21;
							switch (num13)
							{
							case 72:
								num27 = (uint)EOg1fPB9EwGjogva6W(num24 - num14, num22);
								num13 = 38;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								goto case 38;
							case 38:
								YAmmaBGggOGbQC4m1P(object_, fileStream, num27, array4);
								goto case 31;
							case 31:
								num22 -= num27;
								num13 = 56;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 71:
								array4[39] = 0;
								num13 = 1;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 70:
								ccBrmu39uLdoewYxmu(fileStream, num24);
								num13 = 27;
								if (HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 69:
								num15 = num24 + num20;
								goto case 17;
							case 17:
								ccBrmu39uLdoewYxmu(fileStream, long_);
								num13 = 10;
								if (HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 68:
								num19 = fyLpLSbthWOnZeDRgx(fileStream);
								goto case 2;
							case 2:
								ccBrmu39uLdoewYxmu(fileStream, 134L);
								num13 = 21;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 44:
							case 67:
								if (num17 < num18)
								{
									num13 = 29;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									break;
								}
								goto case 25;
							case 25:
								itPrJVQQqjH3q9RBL8(object_, new byte[0], 0, 0);
								num16 = 70;
								goto case 70;
							case 66:
								num26 = (uint)(num15 - num14);
								goto case 18;
							case 18:
								if (num26 < num22)
								{
									goto case 33;
								}
								goto case 26;
							case 33:
								num22 -= num26;
								goto case 16;
							case 16:
								ccBrmu39uLdoewYxmu(fileStream, fyLpLSbthWOnZeDRgx(fileStream) + num26);
								num13 = 45;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								goto case 20;
							case 20:
								if (num24 <= num14)
								{
									num13 = 8;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									break;
								}
								goto case 19;
							case 19:
							case 43:
								if (num14 >= num15)
								{
									num13 = 65;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									break;
								}
								goto case 72;
							case 26:
							case 48:
								num17++;
								goto case 44;
							case 65:
								YAmmaBGggOGbQC4m1P(object_, fileStream, num22, array4);
								goto case 26;
							case 64:
								if (flag2)
								{
									goto case 55;
								}
								goto case 6;
							case 55:
								ccBrmu39uLdoewYxmu(fileStream, 360L);
								goto case 5;
							case 6:
								ccBrmu39uLdoewYxmu(fileStream, 376L);
								num13 = 0;
								if (dY6S0BqF5MmlTUa3Y1() != null)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 36:
								uint_2 = OXi2Ip5cu8b9nStFh1(object_8);
								goto case 30;
							case 30:
								num25 = fLEkJmDvipaNaQ7pI0(uint_2, num18, num19, object_8);
								goto case 13;
							case 13:
								ccBrmu39uLdoewYxmu(fileStream, num25 + 32);
								num13 = 15;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 63:
								num24 = fLEkJmDvipaNaQ7pI0(uint_, num18, num19, object_8);
								goto case 69;
							case 62:
								YAmmaBGggOGbQC4m1P(object_, fileStream, 152u, array4);
								goto case 7;
							case 7:
								flag2 = fYRU0H4vTVDNaewl7R(object_8) != 523;
								goto case 4;
							case 4:
								if (flag2)
								{
									num13 = 34;
									if (HRMuyG74s1F1LraH2X())
									{
										continue;
									}
									break;
								}
								goto case 22;
							case 22:
								num21 = 112;
								goto IL_2545;
							case 61:
								num22 = OXi2Ip5cu8b9nStFh1(object_8);
								goto case 59;
							case 59:
								num23 = OXi2Ip5cu8b9nStFh1(object_8);
								goto case 11;
							case 11:
								ccBrmu39uLdoewYxmu(fileStream, num23);
								goto case 14;
							case 14:
							case 45:
							case 56:
								if (num22 == 0)
								{
									num13 = 48;
									if (dY6S0BqF5MmlTUa3Y1() == null)
									{
										continue;
									}
									break;
								}
								goto case 50;
							case 50:
								num14 = fyLpLSbthWOnZeDRgx(fileStream);
								goto case 20;
							case 60:
								num20 = OXi2Ip5cu8b9nStFh1(object_8);
								goto case 63;
							case 58:
								YAmmaBGggOGbQC4m1P(object_, fileStream, (uint)(num18 * 40), array4);
								num13 = 3;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 57:
								dNBuZQXqRJcvQDOT83(object_, array4, 0, int_);
								num13 = 10;
								if (!HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								goto case 37;
							case 37:
								OixafIpllP1xXpjWsb(fileStream, array4, 0, 128);
								num16 = 23;
								goto case 23;
							case 23:
								array4[32] = 0;
								goto case 24;
							case 24:
								array4[33] = 0;
								goto case 12;
							case 12:
								array4[34] = 0;
								goto case 42;
							case 42:
								array4[35] = 0;
								goto case 47;
							case 47:
								array4[36] = 0;
								num13 = 53;
								if (HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 54:
								flag = !PpbLib2FtY7asqX2is(NeYo3BNTiO, RF32Wo1BBU4FavBfl2(object_), object_2, array5);
								num13 = 62;
								if (!HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								goto end_IL_27e6;
							case 53:
								array4[37] = 0;
								num13 = 39;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 52:
								array4[66] = 0;
								goto case 46;
							case 46:
								array4[67] = 0;
								goto case 57;
							case 51:
								OixafIpllP1xXpjWsb(fileStream, array4, 0, int_);
								goto case 32;
							case 32:
								do
								{
									array4[64] = 0;
									num13 = 40;
								}
								while (!HRMuyG74s1F1LraH2X());
								continue;
							case 49:
								ccBrmu39uLdoewYxmu(fileStream, 152L);
								goto case 51;
							case 41:
								DUc85bHRMfDVwJHyRu(array5);
								num13 = 36;
								if (dY6S0BqF5MmlTUa3Y1() != null)
								{
									continue;
								}
								goto case 54;
							case 40:
								array4[65] = 0;
								num13 = 52;
								if (HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 39:
								array4[38] = 0;
								num13 = 71;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							case 35:
								array4 = new byte[65536];
								goto case 62;
							case 34:
								num21 = 96;
								goto IL_2545;
							case 28:
							case 29:
								ccBrmu39uLdoewYxmu(fileStream, num19 + num17 * 40 + 16L);
								goto case 61;
							case 27:
								array5 = (byte[])IWo0JQIZqKSXUFBNDe(object_8, (int)num20);
								goto case 41;
							case 21:
								num18 = fYRU0H4vTVDNaewl7R(object_8);
								goto case 9;
							case 9:
								ccBrmu39uLdoewYxmu(fileStream, num19);
								goto case 58;
							case 15:
								uint_ = OXi2Ip5cu8b9nStFh1(object_8);
								num13 = 60;
								if (HRMuyG74s1F1LraH2X())
								{
									continue;
								}
								break;
							case 10:
								num17 = 0;
								goto case 44;
							case 8:
								if (num14 < num15)
								{
									goto case 66;
								}
								num16 = 43;
								goto case 19;
							case 3:
								long_ = fyLpLSbthWOnZeDRgx(fileStream);
								goto case 64;
							case 1:
								dNBuZQXqRJcvQDOT83(object_, array4, 0, 128);
								goto case 68;
							default:
								object_8 = new BinaryReader(fileStream);
								goto case 35;
							case 73:
								goto end_IL_27e6;
								IL_2545:
								int_ = num21;
								num13 = 49;
								if (dY6S0BqF5MmlTUa3Y1() == null)
								{
									continue;
								}
								break;
							}
							goto IL_2333;
							continue;
							end_IL_27e6:
							break;
						}
						goto end_IL_22d1;
						IL_2333:
						num13 = num16;
						goto IL_27e6;
						end_IL_22d1:;
					}
					catch
					{
						int num28 = 0;
						if (dY6S0BqF5MmlTUa3Y1() == null)
						{
							goto IL_292e;
						}
						goto IL_294b;
						IL_292e:
						while (true)
						{
							switch (num28)
							{
							case 1:
								goto end_IL_292e;
							}
							flag = true;
							num28 = 1;
							if (dY6S0BqF5MmlTUa3Y1() == null)
							{
								continue;
							}
							goto IL_294b;
							continue;
							end_IL_292e:
							break;
						}
						goto end_IL_291e;
						IL_294b:
						num28 = num29;
						goto IL_292e;
						end_IL_291e:;
					}
					goto case 5;
				case 16:
					if (text == null)
					{
						num2 = 0;
						if (dY6S0BqF5MmlTUa3Y1() == null)
						{
							continue;
						}
						return;
					}
					goto IL_2987;
				case 15:
					goto IL_2987;
				case 13:
					goto IL_29a2;
				case 9:
					goto IL_29b4;
				case 4:
					goto IL_29d9;
				case 3:
					goto IL_29df;
				default:
					return;
				case 12:
					if (!flag)
					{
						goto case 6;
					}
					goto case 5;
				case 5:
					if (!flag)
					{
						goto IL_2956;
					}
					goto case 8;
				case 0:
				case 1:
					return;
				case 8:
					throw new Exception((string?)BrfcLach9THUBR19aH(qriQleuRvI0CMqVBme(z008lYtWYgald98uHG(hVKwFEM0EYAvIvSlCD(typeof(nohvtg2Jq63jo2SldqX).TypeHandle).Assembly)), " is tampered."));
				case 2:
				case 10:
					return;
				}
				break;
				IL_29b4:
				text = (string)MOtW4beUIrQNvMDyF8(hVKwFEM0EYAvIvSlCD(typeof(nohvtg2Jq63jo2SldqX).TypeHandle).Assembly);
				num2 = 16;
				if (dY6S0BqF5MmlTUa3Y1() == null)
				{
					continue;
				}
				goto IL_2969;
				IL_2987:
				if (aTRnEDaDjbs2VOUoKk(text) == 0)
				{
					num2 = 1;
					if (HRMuyG74s1F1LraH2X())
					{
						continue;
					}
					goto IL_2969;
				}
				object_ = null;
				goto IL_29a2;
				IL_29a2:
				object_2 = null;
				num2 = 18;
				if (HRMuyG74s1F1LraH2X())
				{
					continue;
				}
				goto IL_2969;
				IL_2956:
				flag = false;
				num2 = 2;
				if (dY6S0BqF5MmlTUa3Y1() == null)
				{
					continue;
				}
				goto IL_2969;
			}
			continue;
			IL_0013:
			e6xsBGTDc0I9ChPLtO();
			num2 = 3;
			if (dY6S0BqF5MmlTUa3Y1() == null)
			{
				goto IL_29d9;
			}
			goto IL_29fb;
			IL_29d9:
			iTtk7lJq9Z6UqkDyBQ(bool_0: true);
			goto IL_29df;
			IL_29df:
			NeYo3BNTiO = new RSACryptoServiceProvider();
			num2 = 9;
			if (dY6S0BqF5MmlTUa3Y1() != null)
			{
				goto IL_2969;
			}
			goto IL_29fb;
		}
	}

	public static void TnITRwkTCl(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (GlnoUGxbsp == null)
			{
				lock (vKjoKQhsk7)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554496)).Assembly.GetManifestResourceStream("aBo2Gx8jLtuX3PiiJ3.ZE7MReVMTqx3xan7tt"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[^(1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += BK4Tg69GCW(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFFu);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						TRceT72NCfxwhwlm547 tRceT72NCfxwhwlm = new TRceT72NCfxwhwlm547(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = tRceT72NCfxwhwlm.KxsqZWNgkJ();
							int value = tRceT72NCfxwhwlm.KxsqZWNgkJ();
							dictionary.Add(key, value);
						}
						tRceT72NCfxwhwlm.osbq2Qgyt1();
					}
					GlnoUGxbsp = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = GlnoUGxbsp[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554496)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num13 = parameters.Length + 1;
				Type[] array3 = new Type[num13];
				if (methodInfo.DeclaringType!.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType!.MakeByRefType();
				}
				else
				{
					array3[0] = Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777234));
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num14 = 0; num14 < num13; num14++)
				{
					switch (num14)
					{
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num14);
						break;
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint Pc1TtDkJvm(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint BK4Tg69GCW(uint uint_0)
	{
		return 0u;
	}

	internal static void eqUTkwTpob()
	{
	}

	[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
	internal static string fbxTrwhohj(int int_0)
	{
		int num = 153;
		TRceT72NCfxwhwlm547 object_ = default(TRceT72NCfxwhwlm547);
		byte[] array = default(byte[]);
		byte[] array4 = default(byte[]);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		uint num11 = default(uint);
		int num19 = default(int);
		int num26 = default(int);
		byte[] array5 = default(byte[]);
		int num13 = default(int);
		uint num25 = default(uint);
		int num6 = default(int);
		int num18 = default(int);
		int num12 = default(int);
		int num28 = default(int);
		int num27 = default(int);
		uint num10 = default(uint);
		uint num16 = default(uint);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		uint num22 = default(uint);
		uint num20 = default(uint);
		uint num14 = default(uint);
		byte[] array3 = default(byte[]);
		int num21 = default(int);
		int num17 = default(int);
		CryptoStream object_2 = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		uint num15 = default(uint);
		string result = default(string);
		int int_ = default(int);
		int num4 = default(int);
		while (true)
		{
			IL_26da:
			if (opeoNSUdK0.Length != 0)
			{
				goto IL_03ce;
			}
			goto IL_26c2;
			IL_26c2:
			object_ = new TRceT72NCfxwhwlm547((Stream)BKeiH0RGveF45Mbhab(DTIojLuxNb, "sntJmnZ1YN2SkCfqke.jlkY1gOIFpx6esg9Zq"));
			goto IL_26ab;
			IL_26ab:
			Pd8AJEJO5seOrIM1T1(ExwISRQ5Uw0o4EmQq0(object_), 0L);
			goto IL_2680;
			IL_2680:
			array = (byte[])wDvnmP8rGSdYFqLrDx(object_, (int)wa0VchmjgrWeTWs8mF(ExwISRQ5Uw0o4EmQq0(object_)));
			int num2 = 11;
			if (fMDY3GarBCt7ZOafWO())
			{
				goto IL_1907;
			}
			goto IL_1ff2;
			IL_1ff2:
			while (true)
			{
				switch (num2)
				{
				case 416:
					array4[27] = (byte)num5;
					num2 = 28;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 24;
				case 24:
					array2[0] = 174;
					num2 = 192;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 415:
					array4[2] = 160;
					num = 346;
					goto case 346;
				case 346:
					array4[2] = 116;
					num2 = 93;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 414:
					array2[9] = 95;
					goto case 223;
				case 223:
					num7 = 84;
					num2 = 359;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 413:
					num8 = 178;
					goto case 30;
				case 30:
					array4[12] = (byte)num8;
					goto case 321;
				case 321:
					num5 = 65;
					num2 = 100;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 412:
					array4[8] = (byte)num8;
					num2 = 133;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 411:
					array4[25] = (byte)num5;
					num2 = 108;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 92;
				case 92:
					num5 = 54;
					goto case 58;
				case 58:
					array4[13] = (byte)num5;
					num2 = 141;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 394;
				case 394:
					num8 = 136;
					goto case 9;
				case 9:
					array4[14] = (byte)num8;
					goto case 304;
				case 304:
					array4[14] = 195;
					num2 = 148;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 410:
					array2 = new byte[16];
					num2 = 197;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 280;
				case 280:
					array2[0] = 119;
					goto case 398;
				case 398:
					num9 = 52;
					goto case 134;
				case 134:
					array2[0] = (byte)num9;
					goto case 191;
				case 191:
					array2[0] = 96;
					goto case 392;
				case 392:
					num7 = 4;
					num = 94;
					goto case 94;
				case 94:
					array2[0] = (byte)num7;
					num2 = 37;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 262;
				case 262:
					num7 = 94;
					goto case 400;
				case 400:
					array2[0] = (byte)num7;
					goto case 24;
				case 409:
					array4[15] = (byte)num8;
					goto case 50;
				case 50:
					array4[15] = 116;
					goto case 363;
				case 363:
					array4[15] = 76;
					num2 = 184;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 94;
				case 408:
					array4[16] = 98;
					num2 = 183;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 407:
					array4[22] = (byte)num8;
					goto case 226;
				case 226:
					array4[22] = 124;
					num = 219;
					goto case 219;
				case 219:
					array4[22] = 175;
					num2 = 384;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 406:
					num8 = 200;
					goto case 31;
				case 31:
					array4[23] = (byte)num8;
					goto case 33;
				case 33:
					num5 = 164;
					goto case 265;
				case 265:
					array4[23] = (byte)num5;
					goto case 391;
				case 391:
					num8 = 131;
					goto case 210;
				case 210:
					array4[23] = (byte)num8;
					goto case 195;
				case 195:
					num8 = 105;
					goto case 88;
				case 88:
					array4[23] = (byte)num8;
					goto case 251;
				case 251:
					num8 = 142;
					goto case 343;
				case 343:
					array4[24] = (byte)num8;
					num2 = 311;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 405:
					array2[2] = 92;
					goto case 214;
				case 214:
					num9 = 61;
					num2 = 295;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 404:
					num11 <<= 8;
					goto case 287;
				case 287:
					num19 += 8;
					goto case 15;
				case 364:
					num26++;
					goto case 95;
				case 70:
					if (num26 > 0)
					{
						goto case 404;
					}
					goto case 15;
				case 15:
					array5[num13 + num26] = (byte)((num25 & num11) >> num19);
					goto case 364;
				case 95:
				case 174:
					if (num26 < num6)
					{
						goto case 70;
					}
					num = 286;
					goto case 286;
				case 286:
				case 355:
					num18++;
					goto case 369;
				case 369:
				case 401:
					if (num18 >= num12)
					{
						num2 = 46;
						if (s6U3DGlrjBnLpWRFnj() != null)
						{
							continue;
						}
						goto case 115;
					}
					goto case 397;
				case 115:
					opeoNSUdK0 = array5;
					num2 = 15;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					break;
				case 29:
				case 152:
					break;
				case 397:
					num28 = num18 % num27;
					goto case 71;
				case 71:
					num13 = num18 * 4;
					num = 119;
					goto case 119;
				case 119:
					num10 = (uint)(num28 * 4);
					goto case 271;
				case 271:
					num16 = (uint)((array6[num10 + 3] << 24) | (array6[num10 + 2] << 16) | (array6[num10 + 1] << 8) | array6[num10]);
					num2 = 46;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 45;
				case 45:
					num8 = 67;
					goto case 276;
				case 276:
					array4[28] = (byte)num8;
					goto case 19;
				case 19:
					num5 = 150;
					num = 120;
					goto case 120;
				case 120:
					array4[28] = (byte)num5;
					num = 310;
					goto case 310;
				case 310:
					num8 = 140;
					goto case 82;
				case 82:
					array4[28] = (byte)num8;
					goto case 109;
				case 109:
					array4[28] = 162;
					num2 = 215;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 403:
					array7 = (byte[])cVQaSK0p8Yn2KeN6TG(OxZbXiphwYRjiyTIsD(DTIojLuxNb));
					num2 = 374;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 402:
					array4[7] = 116;
					num2 = 340;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 260;
				case 260:
					array4[2] = 111;
					num2 = 415;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 399:
					num8 = 115;
					goto case 362;
				case 362:
					array4[27] = (byte)num8;
					goto case 213;
				case 213:
					num5 = 128;
					num2 = 416;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 396:
					array4[19] = (byte)num5;
					goto case 69;
				case 69:
					array4[19] = 88;
					num2 = 274;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 395:
					num5 = 151;
					goto case 62;
				case 62:
					array4[4] = (byte)num5;
					goto case 233;
				case 233:
					array4[5] = 95;
					goto case 54;
				case 54:
					array4[5] = 142;
					goto case 63;
				case 63:
					num8 = 106;
					num2 = 186;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 127;
				case 127:
					num8 = 140;
					num2 = 212;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 203;
				case 203:
					num12 = array.Length / 4;
					num2 = 182;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 240;
				case 240:
					array5 = new byte[array.Length];
					num2 = 31;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 43;
				case 43:
					num27 = array6.Length / 4;
					num2 = 148;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 235;
				case 235:
					num15 = 0u;
					num2 = 252;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 393:
					array4[20] = (byte)num5;
					num2 = 217;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 390:
					num8 = 17;
					num = 157;
					goto case 157;
				case 157:
					array4[9] = (byte)num8;
					goto case 312;
				case 312:
					array4[9] = 94;
					goto case 55;
				case 55:
					num5 = 129;
					goto case 376;
				case 376:
					array4[9] = (byte)num5;
					num2 = 306;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 389:
					array4[23] = (byte)num5;
					goto case 292;
				case 292:
					array4[23] = 96;
					goto case 406;
				case 388:
					array4[13] = 133;
					num2 = 92;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 387:
					num5 = 130;
					num2 = 385;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 386:
					num9 = 107;
					goto case 126;
				case 126:
					array2[13] = (byte)num9;
					num2 = 308;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 385:
					array4[31] = (byte)num5;
					goto case 72;
				case 72:
					array4[31] = 160;
					num2 = 230;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 384:
					array4[22] = 190;
					num2 = 6;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 383:
					array4[20] = 157;
					num2 = 57;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 382:
					num5 = 118;
					goto case 201;
				case 201:
					array4[21] = (byte)num5;
					num2 = 339;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 8;
				case 8:
					array4[9] = (byte)num8;
					num2 = 52;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 381:
					array4[6] = 89;
					goto case 23;
				case 23:
					array4[6] = 115;
					num2 = 170;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 164;
				case 164:
					array4[13] = (byte)num5;
					num2 = 366;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 380;
				case 380:
					num5 = 104;
					goto case 197;
				case 197:
					array4[13] = (byte)num5;
					num2 = 334;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 388;
				case 379:
					array4[16] = (byte)num8;
					goto case 113;
				case 113:
					num5 = 232;
					goto case 232;
				case 232:
					array4[16] = (byte)num5;
					goto case 228;
				case 228:
					num5 = 77;
					goto case 245;
				case 245:
					array4[17] = (byte)num5;
					goto case 290;
				case 290:
					num8 = 108;
					num = 285;
					goto case 285;
				case 285:
					array4[17] = (byte)num8;
					num2 = 259;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 259;
				case 259:
					array4[17] = 109;
					goto case 208;
				case 208:
					num5 = 161;
					num = 328;
					goto case 328;
				case 328:
					array4[18] = (byte)num5;
					num2 = 118;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 378:
					array2[14] = (byte)num7;
					goto case 173;
				case 173:
					array2[14] = 132;
					goto case 193;
				case 193:
					array2[14] = 91;
					num2 = 173;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 189;
				case 189:
					num9 = 188;
					num2 = 135;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 377:
					array4[9] = (byte)num5;
					num2 = 105;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 130;
				case 130:
					array4[9] = 98;
					goto case 18;
				case 18:
					num8 = 237;
					num2 = 8;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 375:
					num15 = num22;
					num = 84;
					goto case 84;
				case 84:
					if (num18 == num12 - 1)
					{
						goto case 85;
					}
					goto case 334;
				case 85:
					if (num6 > 0)
					{
						goto case 106;
					}
					goto case 334;
				case 106:
					num25 = num15 ^ num20;
					goto case 26;
				case 26:
					num26 = 0;
					num2 = 95;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 334:
					num14 = num15 ^ num20;
					num2 = 101;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 140;
				case 140:
					array5[num13] = (byte)(num14 & 0xFFu);
					num2 = 107;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 20;
				case 20:
					num9 = 120;
					goto case 64;
				case 64:
					array2[8] = (byte)num9;
					goto case 178;
				case 178:
					array2[8] = 143;
					goto case 294;
				case 294:
					num9 = 109;
					goto case 336;
				case 336:
					array2[8] = (byte)num9;
					goto case 122;
				case 122:
					num7 = 120;
					num2 = 213;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 225;
				case 225:
					array2[8] = (byte)num7;
					num2 = 275;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 133;
				case 133:
					num8 = 198;
					num2 = 53;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 180;
				case 180:
					array4[8] = (byte)num8;
					goto case 390;
				case 374:
					if (array7 != null)
					{
						goto case 74;
					}
					goto case 307;
				case 74:
					if (array7.Length > 0)
					{
						goto case 39;
					}
					goto case 307;
				case 39:
					array3[1] = array7[0];
					num2 = 177;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 284;
				case 284:
					array3[3] = array7[1];
					num2 = 370;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 307:
					num21 = 0;
					num2 = 147;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 373:
					array4[21] = (byte)num8;
					goto case 293;
				case 293:
					array4[21] = 121;
					num2 = 372;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 100;
				case 100:
					array4[12] = (byte)num5;
					num = 116;
					goto case 116;
				case 116:
					num5 = 189;
					goto case 329;
				case 329:
					array4[12] = (byte)num5;
					goto case 289;
				case 289:
					num8 = 137;
					num = 165;
					goto case 165;
				case 165:
					array4[12] = (byte)num8;
					goto case 338;
				case 338:
					array4[13] = 101;
					goto case 86;
				case 86:
					num5 = 77;
					num2 = 164;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 372:
					num8 = 111;
					goto case 407;
				case 371:
					array4[18] = (byte)num8;
					num2 = 60;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 370:
					array3[5] = array7[2];
					goto case 248;
				case 248:
					array3[7] = array7[3];
					num2 = 1;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 1;
				case 1:
					array3[9] = array7[4];
					goto case 199;
				case 199:
					array3[11] = array7[5];
					goto case 220;
				case 220:
					array3[13] = array7[6];
					num2 = 4;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 76;
				case 76:
					array3[15] = array7[7];
					goto case 307;
				case 368:
					array4[26] = (byte)num5;
					goto case 399;
				case 367:
					num7 = 162;
					goto case 190;
				case 190:
					array2[5] = (byte)num7;
					goto case 169;
				case 169:
					num9 = 121;
					goto case 231;
				case 231:
					array2[5] = (byte)num9;
					num2 = 224;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 366:
					num8 = 92;
					num2 = 24;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 264;
				case 264:
					array4[16] = (byte)num8;
					goto case 408;
				case 196:
					if (num17 <= 0)
					{
						goto case 16;
					}
					goto case 27;
				case 16:
					num20 |= array[^(1 + num17)];
					goto case 266;
				case 266:
					num17++;
					goto case 277;
				case 277:
				case 365:
					if (num17 < num6)
					{
						goto case 196;
					}
					goto case 114;
				case 114:
				case 297:
					num22 = num15;
					num2 = 257;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 27:
					num20 <<= 8;
					num2 = 16;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 15;
				case 361:
					array2[6] = 96;
					num2 = 269;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 360:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 92;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 121;
				case 121:
					pKcv0Mr3ImYFpSryWD(object_2, array, 0, array.Length);
					num2 = 158;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 359:
					array2[9] = (byte)num7;
					goto case 80;
				case 80:
					num7 = 121;
					goto case 124;
				case 124:
					array2[9] = (byte)num7;
					goto case 239;
				case 239:
					num9 = 166;
					goto case 171;
				case 171:
					array2[10] = (byte)num9;
					goto case 258;
				case 258:
					num7 = 162;
					goto case 150;
				case 150:
					array2[10] = (byte)num7;
					num2 = 12;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 49;
				case 49:
					num7 = 107;
					num2 = 5;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 22;
				case 22:
					array2[10] = (byte)num7;
					goto case 4;
				case 4:
					num7 = 37;
					num2 = 161;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 358:
					array2[2] = (byte)num7;
					goto case 172;
				case 172:
					array2[3] = 147;
					goto case 61;
				case 61:
					array2[3] = 67;
					num2 = 10;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 357:
					array2[4] = (byte)num9;
					goto case 282;
				case 282:
					num7 = 47;
					num2 = 99;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 131;
				case 131:
					array2[4] = (byte)num7;
					num2 = 34;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 356:
					array2[11] = 56;
					goto case 146;
				case 146:
					array2[12] = 114;
					num = 2;
					goto case 2;
				case 2:
					num7 = 69;
					num2 = 187;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 136;
				case 136:
					num8 = 0;
					num2 = 43;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 241;
				case 241:
					array4[1] = (byte)num8;
					num2 = 303;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 354:
					num5 = 100;
					goto case 347;
				case 347:
					array4[27] = (byte)num5;
					goto case 301;
				case 301:
					array4[27] = 147;
					num2 = 0;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 353:
					array4[5] = (byte)num8;
					num2 = 337;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 352:
					array4[15] = (byte)num5;
					goto case 366;
				case 351:
					array4[30] = 100;
					goto case 247;
				case 247:
					array4[30] = 34;
					goto case 253;
				case 253:
					num8 = 82;
					num2 = 117;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 350:
					array2[14] = 141;
					goto case 256;
				case 256:
					num7 = 114;
					goto case 378;
				case 349:
					num8 = 76;
					num2 = 110;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 348:
					array4[30] = (byte)num8;
					goto case 351;
				case 345:
					array4[10] = 163;
					num = 188;
					goto case 188;
				case 188:
					num5 = 133;
					num = 279;
					goto case 279;
				case 279:
					array4[10] = (byte)num5;
					goto case 349;
				case 344:
					array4[18] = (byte)num8;
					goto case 129;
				case 129:
					num8 = 193;
					num2 = 43;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 371;
				case 342:
					array2[1] = 168;
					num2 = 185;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 4;
				case 341:
					array4[29] = (byte)num5;
					goto case 267;
				case 267:
					array4[29] = 126;
					num2 = 51;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 81;
				case 81:
					num8 = 164;
					goto case 65;
				case 65:
					array4[29] = (byte)num8;
					num2 = 155;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 340:
					num8 = 159;
					goto case 244;
				case 244:
					array4[7] = (byte)num8;
					goto case 299;
				case 299:
					array4[7] = 47;
					num2 = 298;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 101;
				case 101:
					num8 = 124;
					goto case 238;
				case 238:
					array4[4] = (byte)num8;
					num2 = 395;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 339:
					num8 = 146;
					goto case 373;
				case 337:
					array4[6] = 174;
					goto case 249;
				case 249:
					num8 = 26;
					num2 = 202;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 335:
					array4[31] = 4;
					goto case 73;
				case 73:
					array6 = array4;
					goto case 410;
				case 333:
					array2[1] = 143;
					num2 = 342;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 332:
				{
					uint num23 = num22;
					uint num24 = num22;
					num24 ^= num24 << 16;
					num24 += 2725631399u;
					num24 ^= num24 << 9;
					num24 += 379213781;
					num24 ^= num24 >> 21;
					num24 += 634426509;
					num24 = 610765834 + num24;
					num22 = num23 + (uint)(double)num24;
					goto case 375;
				}
				case 162:
					array6[num21] = (byte)(array6[num21] ^ array3[num21]);
					goto case 320;
				case 320:
					num21++;
					goto case 147;
				case 147:
				case 331:
					if (num21 < array3.Length)
					{
						goto case 162;
					}
					num = 35;
					goto case 35;
				case 35:
					if (int_0 == -1)
					{
						goto case 318;
					}
					goto case 149;
				case 318:
					object_3 = (SymmetricAlgorithm)lKLb8E3u51rvH5vohv();
					num2 = 7;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 209;
				case 209:
					N0DSjNeByi8JwFUvFX(object_3, CipherMode.CBC);
					goto case 83;
				case 83:
					transform = (ICryptoTransform)P0ZMj5ibQGBeUpSL4U(object_3, array6, array3);
					num2 = 13;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 149:
					num6 = array.Length % 4;
					num2 = 203;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 330:
					num5 = 120;
					num = 154;
					goto case 154;
				case 154:
					array4[1] = (byte)num5;
					goto case 3;
				case 3:
					num8 = 205;
					goto case 67;
				case 67:
					array4[1] = (byte)num8;
					goto case 243;
				case 243:
					array4[2] = 228;
					goto case 79;
				case 79:
					array4[2] = 101;
					goto case 260;
				case 327:
					array2[1] = 142;
					num2 = 97;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 326:
					num7 = 178;
					goto case 21;
				case 21:
					array2[4] = (byte)num7;
					num2 = 102;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 325:
					num7 = 85;
					num2 = 90;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 324:
					num7 = 95;
					num2 = 139;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 323:
					array4[27] = (byte)num8;
					goto case 354;
				case 322:
					num9 = 114;
					goto case 357;
				case 319:
					num8 = 157;
					goto case 412;
				case 317:
					array4[3] = 71;
					goto case 236;
				case 236:
					array4[4] = 145;
					num2 = 101;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 316:
					num9 = 169;
					num2 = 209;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 227;
				case 227:
					array2[6] = (byte)num9;
					goto case 288;
				case 288:
					array2[6] = 96;
					num2 = 195;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 361;
				case 315:
					array4[26] = 132;
					goto case 166;
				case 166:
					num5 = 125;
					goto case 132;
				case 132:
					array4[26] = (byte)num5;
					num2 = 77;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 313:
					array2[13] = (byte)num9;
					num2 = 205;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 197;
				case 311:
					array4[24] = 153;
					goto case 59;
				case 59:
					array4[24] = 123;
					goto case 38;
				case 38:
					array4[24] = 179;
					num2 = 128;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 309:
					array4[11] = 74;
					num2 = 29;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 242;
				case 242:
					num8 = 144;
					goto case 159;
				case 159:
					array4[12] = (byte)num8;
					goto case 413;
				case 308:
					num9 = 81;
					num2 = 313;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 63;
				case 306:
					num5 = 85;
					num = 377;
					goto case 377;
				case 305:
					array2[11] = 138;
					num2 = 29;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 356;
				case 303:
					num5 = 71;
					goto case 37;
				case 37:
					array4[1] = (byte)num5;
					num2 = 111;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 302:
					array2[15] = 134;
					num2 = 27;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 144;
				case 144:
					array2[15] = 99;
					num2 = 141;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 300:
					PxB7Bwne4gbdiokroX(object_2);
					num2 = 123;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 298:
					array4[8] = 124;
					goto case 319;
				case 296:
					num7 = 88;
					num2 = 198;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 295:
					array2[2] = (byte)num9;
					goto case 325;
				case 291:
					array4[25] = (byte)num8;
					goto case 56;
				case 56:
					array4[25] = 13;
					num = 315;
					goto case 315;
				case 283:
					array5[num13 + 3] = (byte)((num14 & 0xFF000000u) >> 24);
					goto case 286;
				case 281:
					num8 = 106;
					num2 = 291;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 76;
				case 278:
					PxB7Bwne4gbdiokroX(stream);
					num2 = 221;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 300;
				case 275:
					array2[9] = 166;
					num2 = 414;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 274:
					array4[19] = 228;
					num = 383;
					goto case 383;
				case 273:
					array4[31] = 209;
					goto case 335;
				case 272:
					num7 = 86;
					goto case 160;
				case 160:
					array2[14] = (byte)num7;
					num = 350;
					goto case 350;
				case 270:
					goto IL_16f9;
				case 269:
					num9 = 9;
					goto case 167;
				case 167:
					array2[7] = (byte)num9;
					num2 = 214;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 296;
				case 268:
					array4[11] = 176;
					goto case 89;
				case 89:
					num8 = 164;
					num = 179;
					goto case 179;
				case 179:
					array4[11] = (byte)num8;
					num2 = 309;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 263:
					num15 += num16;
					num2 = 3;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 11;
				case 11:
					num10 = (uint)num13;
					goto case 168;
				case 168:
					num20 = (uint)((array[num10 + 3] << 24) | (array[num10 + 2] << 16) | (array[num10 + 1] << 8) | array[num10]);
					num2 = 114;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 261:
					array4[6] = 156;
					goto case 17;
				case 17:
					num5 = 107;
					goto case 211;
				case 211:
					array4[7] = (byte)num5;
					goto case 402;
				case 257:
					num15 = 0u;
					num = 332;
					goto case 332;
				case 255:
					array4[0] = 113;
					num2 = 40;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 254:
					array2[11] = 165;
					num2 = 305;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 93;
				case 93:
					array4[2] = 253;
					num2 = 71;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 91;
				case 91:
					array4[3] = 160;
					goto case 163;
				case 163:
					array4[3] = 97;
					num2 = 36;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 252:
					num16 = 0u;
					num = 125;
					goto case 125;
				case 125:
					num20 = 0u;
					num2 = 5;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 250:
					array2[1] = (byte)num9;
					num = 327;
					goto case 327;
				case 246:
					num8 = 86;
					num2 = 348;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 237:
					goto IL_1907;
				case 234:
					array2[4] = (byte)num9;
					goto case 12;
				case 12:
					num7 = 119;
					num2 = 25;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 7;
				case 7:
					array4[15] = 83;
					goto case 47;
				case 47:
					num5 = 224;
					goto case 352;
				case 230:
					array4[31] = 130;
					goto case 273;
				case 229:
					num8 = 49;
					num2 = 409;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 224:
					num7 = 86;
					goto case 143;
				case 143:
					array2[5] = (byte)num7;
					num2 = 51;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 221:
					num19 = 0;
					goto case 207;
				case 207:
					if (num18 != num12 - 1)
					{
						goto case 263;
					}
					goto case 42;
				case 42:
					if (num6 <= 0)
					{
						goto case 263;
					}
					num = 145;
					goto case 145;
				case 145:
					num20 = 0u;
					num2 = 181;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 218:
					num18 = 0;
					goto case 369;
				case 217:
					num5 = 25;
					goto case 41;
				case 41:
					array4[20] = (byte)num5;
					goto case 382;
				case 216:
					array2[15] = 134;
					goto case 302;
				case 215:
					num5 = 164;
					goto case 151;
				case 151:
					array4[29] = (byte)num5;
					goto case 200;
				case 200:
					num5 = 117;
					num2 = 341;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 212:
					array4[0] = (byte)num8;
					num = 255;
					goto case 255;
				case 206:
					array4[1] = (byte)num8;
					num2 = 330;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 205:
					array2[13] = 1;
					goto case 272;
				case 204:
					array4[0] = (byte)num5;
					goto case 136;
				case 202:
					array4[6] = (byte)num8;
					goto case 381;
				case 198:
					array2[7] = (byte)num7;
					num2 = 48;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 192:
					array2[1] = 104;
					num2 = 177;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 187:
					array2[12] = (byte)num7;
					goto case 324;
				case 186:
					array4[5] = (byte)num8;
					goto case 14;
				case 14:
					num8 = 47;
					num2 = 234;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 353;
				case 185:
					array2[2] = 137;
					num2 = 61;
					if (s6U3DGlrjBnLpWRFnj() != null)
					{
						continue;
					}
					goto case 66;
				case 66:
					array2[2] = 136;
					num2 = 360;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 405;
				case 184:
					array4[15] = 101;
					num = 7;
					goto case 7;
				case 183:
					num8 = 191;
					goto case 379;
				case 182:
					array4[28] = (byte)num5;
					num2 = 45;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 181:
					num15 += num16;
					goto case 87;
				case 87:
					num17 = 0;
					goto case 277;
				case 177:
					num9 = 147;
					goto case 250;
				case 176:
					array2[5] = 98;
					goto case 316;
				case 175:
					array4[14] = 43;
					goto case 229;
				case 170:
					array4[6] = 100;
					num2 = 261;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 161:
					array2[11] = (byte)num7;
					goto case 254;
				case 158:
					PPXD4JhtcNJG5Pbo5F(object_2);
					goto case 156;
				case 156:
					opeoNSUdK0 = (byte[])ny4QXLGWIjuQOjCpw0(stream);
					goto case 278;
				case 155:
					array4[29] = 75;
					goto case 246;
				case 148:
					array4[14] = 148;
					goto case 175;
				case 142:
					array2[12] = (byte)num7;
					goto case 386;
				case 141:
					array3 = array2;
					num2 = 32;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 139:
					array2[12] = (byte)num7;
					num = 104;
					goto case 104;
				case 104:
					num7 = 118;
					goto case 142;
				case 138:
					array4[10] = (byte)num8;
					num2 = 96;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 18;
				case 137:
					array2[7] = (byte)num7;
					goto case 20;
				case 135:
					array2[14] = (byte)num9;
					goto case 216;
				case 128:
					num5 = 91;
					goto case 411;
				case 123:
					array = opeoNSUdK0;
					num = 149;
					goto case 149;
				case 118:
					num8 = 118;
					goto case 344;
				case 117:
					array4[30] = (byte)num8;
					goto case 53;
				case 53:
					array4[31] = 94;
					goto case 387;
				case 112:
					num7 = 29;
					num2 = 358;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 111:
					num8 = 83;
					goto case 206;
				case 110:
					array4[10] = (byte)num8;
					goto case 98;
				case 98:
					num8 = 190;
					goto case 138;
				case 108:
					array4[25] = 150;
					goto case 281;
				case 107:
					array5[num13 + 1] = (byte)((num14 & 0xFF00) >> 8);
					goto case 75;
				case 75:
					array5[num13 + 2] = (byte)((num14 & 0xFF0000) >> 16);
					goto case 283;
				case 105:
					num5 = 133;
					goto case 396;
				case 102:
					array2[5] = 151;
					num2 = 147;
					if (!fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto case 367;
				case 99:
					array2[3] = (byte)num7;
					goto case 322;
				case 97:
					array2[1] = 104;
					num2 = 333;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 127;
				case 96:
					array4[10] = 223;
					num2 = 268;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 90:
					array2[2] = (byte)num7;
					num2 = 112;
					if (fMDY3GarBCt7ZOafWO())
					{
						continue;
					}
					goto IL_004b;
				case 78:
					num12++;
					num2 = 44;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 77:
					num5 = 51;
					num2 = 368;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 60:
					array4[19] = 176;
					goto case 105;
				case 57:
					num5 = 107;
					goto case 393;
				case 52:
					array4[10] = 130;
					num = 345;
					goto case 345;
				case 51:
					array2[5] = 142;
					num2 = 176;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto case 95;
				case 48:
					num7 = 62;
					goto case 137;
				case 46:
					num11 = 255u;
					goto case 221;
				case 44:
					num10 = 0u;
					num = 218;
					goto case 218;
				case 40:
					num5 = 196;
					goto case 204;
				case 36:
					array4[3] = 102;
					goto case 317;
				case 34:
					num9 = 36;
					goto case 234;
				case 32:
					zlbC1e2kk12ym7OeMU(array3);
					num = 403;
					goto case 403;
				case 28:
					num8 = 156;
					goto case 323;
				case 25:
					array2[4] = (byte)num7;
					goto case 326;
				case 13:
					stream = (Stream)IyPuDNApqR0SYoo5c7();
					goto case 360;
				case 10:
					num7 = 231;
					goto case 99;
				case 6:
					num5 = 148;
					num2 = 389;
					if (s6U3DGlrjBnLpWRFnj() == null)
					{
						continue;
					}
					goto IL_004b;
				case 5:
					if (num6 > 0)
					{
						goto case 78;
					}
					goto case 44;
				default:
					num5 = 146;
					goto case 182;
				case 222:
					goto IL_2680;
				case 314:
					goto IL_26ab;
				case 103:
					goto IL_26c2;
				case 153:
					goto IL_26da;
				case 68:
					try
					{
						ekpMOs1xgE9gm6JlWp();
						int num3 = 0;
						if (s6U3DGlrjBnLpWRFnj() == null)
						{
							goto IL_26fb;
						}
						goto IL_2722;
						IL_2722:
						switch (num3)
						{
						case 1:
							return result;
						}
						goto IL_26fb;
						IL_26fb:
						result = (string)MmZk49CUbPVMi8M6eK(ajseUEPdpmYqJbneWH(), opeoNSUdK0, int_0 + 4, int_);
						num3 = 1;
						if (s6U3DGlrjBnLpWRFnj() != null)
						{
							num3 = num4;
						}
						goto IL_2722;
					}
					catch
					{
						if (fMDY3GarBCt7ZOafWO())
						{
							switch (0)
							{
							}
						}
					}
					goto case 194;
				case 194:
					return "";
				}
				break;
			}
			goto IL_03ce;
			IL_1907:
			pYFyAwVcahDIXyaRhp(object_);
			goto IL_16f9;
			IL_16f9:
			array4 = new byte[32];
			num2 = 127;
			if (!fMDY3GarBCt7ZOafWO())
			{
				goto IL_004b;
			}
			goto IL_1ff2;
			IL_03ce:
			int_ = T6wIsDwD3HttYRtenu(opeoNSUdK0, int_0);
			num2 = 68;
			if (s6U3DGlrjBnLpWRFnj() != null)
			{
				goto IL_004b;
			}
			goto IL_1ff2;
			IL_004b:
			num2 = num;
			goto IL_1ff2;
		}
	}

	[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
	internal static string H02TFKZ7fp(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Qj4TXnWyDS()
	{
		return 5;
	}

	private static void unTTQ7PNLw()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate r7DTC76Ux5(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777308)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777250)),
			Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777240))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object SE7T9sMp3w(object object_0)
	{
		try
		{
			if (File.Exists(((Assembly)object_0).Location))
			{
				return ((Assembly)object_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_0.GetType().GetProperty("Location")!.GetValue(object_0, new object[0])!.ToString()))
			{
				return object_0.GetType().GetProperty("Location")!.GetValue(object_0, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	private static IntPtr BP7oZvrI52(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (miCobsumv7 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			miCobsumv7 = (pRiNFX2OS33VKU4uN6f)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554505)));
		}
		return miCobsumv7(intptr_0, string_0, uint_0);
	}

	private static IntPtr OmVo2t1rF0(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (aaTotG7H9c == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			aaTotG7H9c = (iKX7ap2lXZr0QVTbby0)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554506)));
		}
		return aaTotG7H9c(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int cxZoIYw72u(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (LYUogrVnqR == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			LYUogrVnqR = (uZX6eo2SaDNo6WxZIym)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554507)));
		}
		return LYUogrVnqR(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int FBUofWE8e3(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (epxokEX8Q5 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			epxokEX8Q5 = (EUDhdH21SLRkS1Li1Ir)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554508)));
		}
		return epxokEX8Q5(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr zmZoTI1SYa(uint uint_0, int int_0, uint uint_1)
	{
		if (cXforJfXKU == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			cXforJfXKU = (KNxMAO2xY34HPwkjyeo)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554509)));
		}
		return cXforJfXKU(uint_0, int_0, uint_1);
	}

	private static int kb2ooHbifS(IntPtr intptr_0)
	{
		if (ADFoFAWXoP == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			ADFoFAWXoP = (Y2BKq72VSSqAn3NvZYp)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554510)));
		}
		return ADFoFAWXoP(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (vYGoXdXGZT == IntPtr.Zero)
		{
			vYGoXdXGZT = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return vYGoXdXGZT;
	}

	[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
	private static byte[] gosoqPeTIN(string string_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	internal static Stream qK3oYlwgve()
	{
		return new MemoryStream();
	}

	internal static byte[] DWkopaS168(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[dfibq52v8FF3QcRs81Z(typeof(dfibq52v8FF3QcRs81Z.txp9CP2BV6lyklXOOc0<object>[]))]
	private static byte[] YSnoE9CbEM(byte[] byte_0)
	{
		Stream stream = qK3oYlwgve();
		SymmetricAlgorithm symmetricAlgorithm = Q7PTaaSMQs();
		symmetricAlgorithm.Key = new byte[32]
		{
			139, 157, 93, 75, 115, 5, 204, 88, 22, 113,
			54, 176, 175, 14, 153, 108, 108, 169, 216, 239,
			232, 142, 244, 164, 68, 68, 232, 61, 151, 201,
			249, 243
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			118, 74, 215, 154, 27, 86, 70, 5, 117, 176,
			85, 230, 84, 170, 76, 217
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = DWkopaS168(stream);
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		return result;
	}

	private byte[] nIdomp7EMS()
	{
		return null;
	}

	private byte[] kFVo8NkrIC()
	{
		return null;
	}

	private byte[] tplo6VlfQZ()
	{
		return null;
	}

	private byte[] W12oDo0qJe()
	{
		return null;
	}

	private byte[] R7so4C2Tqr()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] oiZoMsmG7i()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] zfjosY7lnC()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] HjYoPfwlNA()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] clQo5sOyXJ()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] VAJoJPSenI()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object BKeiH0RGveF45Mbhab(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object ExwISRQ5Uw0o4EmQq0(object object_0)
	{
		return ((TRceT72NCfxwhwlm547)object_0).KDikMXewCI();
	}

	internal static void Pd8AJEJO5seOrIM1T1(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long wa0VchmjgrWeTWs8mF(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object wDvnmP8rGSdYFqLrDx(object object_0, int int_0)
	{
		return ((TRceT72NCfxwhwlm547)object_0).hLYouDw72t(int_0);
	}

	internal static void pYFyAwVcahDIXyaRhp(object object_0)
	{
		((TRceT72NCfxwhwlm547)object_0).osbq2Qgyt1();
	}

	internal static void zlbC1e2kk12ym7OeMU(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object OxZbXiphwYRjiyTIsD(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object cVQaSK0p8Yn2KeN6TG(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object lKLb8E3u51rvH5vohv()
	{
		return Q7PTaaSMQs();
	}

	internal static void N0DSjNeByi8JwFUvFX(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object P0ZMj5ibQGBeUpSL4U(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object IyPuDNApqR0SYoo5c7()
	{
		return qK3oYlwgve();
	}

	internal static void pKcv0Mr3ImYFpSryWD(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void PPXD4JhtcNJG5Pbo5F(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object ny4QXLGWIjuQOjCpw0(object object_0)
	{
		return DWkopaS168((Stream)object_0);
	}

	internal static void PxB7Bwne4gbdiokroX(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int T6wIsDwD3HttYRtenu(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void ekpMOs1xgE9gm6JlWp()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
	}

	internal static object ajseUEPdpmYqJbneWH()
	{
		return Encoding.Unicode;
	}

	internal static object MmZk49CUbPVMi8M6eK(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool fMDY3GarBCt7ZOafWO()
	{
		return (object)null == null;
	}

	internal static object s6U3DGlrjBnLpWRFnj()
	{
		return null;
	}

	internal static void e6xsBGTDc0I9ChPLtO()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
	}

	internal static void iTtk7lJq9Z6UqkDyBQ(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type hVKwFEM0EYAvIvSlCD(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object MOtW4beUIrQNvMDyF8(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int aTRnEDaDjbs2VOUoKk(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object AV5UY4FE6FyfbVYf5f()
	{
		return SHA1.Create();
	}

	internal static object pojuUl6sUmKuJq4lnG(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool lsV2a0jnl5SoHNULIX(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object ypHHtEYD6U9UdK42yv(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object pJKp5w048lBFoh7vvR(object object_0)
	{
		return ((TRceT72NCfxwhwlm547)object_0).KDikMXewCI();
	}

	internal static void ccBrmu39uLdoewYxmu(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long EKTUoewNuh24chQ5UM(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object UP49qSN16POWf50Uld(object object_0, int int_0)
	{
		return ((TRceT72NCfxwhwlm547)object_0).hLYouDw72t(int_0);
	}

	internal static object gkYcQbxEJvFG5InQ2F()
	{
		return Q7PTaaSMQs();
	}

	internal static void Q1LoHbfUH5gyyTPTFv(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object N3USZwPkqV5dNNyyur(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object Y0cE1HKT6KZk7TWN7c()
	{
		return qK3oYlwgve();
	}

	internal static void tOO50pCrVim9HnylGr(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void LuNhjdnupM6C0ndGZx(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object wL8HBfW31VG6Xhnvcl()
	{
		return Encoding.UTF8;
	}

	internal static object Y7uyFMLqdGuK9Gp43L(object object_0)
	{
		return DWkopaS168((Stream)object_0);
	}

	internal static object iF0oKhigsH2qsay2VR(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void Yv1tIAZ0PncJ9h4IyM(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void XbGrh2lZR8EmnAlRTf(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void uZydowV7MLCynR40d9(object object_0)
	{
		((TRceT72NCfxwhwlm547)object_0).osbq2Qgyt1();
	}

	internal static void YAmmaBGggOGbQC4m1P(object object_0, object object_1, uint uint_0, object object_2)
	{
		WhOTcRmk1b((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort fYRU0H4vTVDNaewl7R(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int OixafIpllP1xXpjWsb(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void dNBuZQXqRJcvQDOT83(object object_0, object object_1, int int_0, int int_1)
	{
		wEaTwVPYP0((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long fyLpLSbthWOnZeDRgx(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint OXi2Ip5cu8b9nStFh1(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint fLEkJmDvipaNaQ7pI0(uint uint_0, int int_0, long long_0, object object_0)
	{
		return vYET0uEXhS(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long EOg1fPB9EwGjogva6W(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object itPrJVQQqjH3q9RBL8(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object IWo0JQIZqKSXUFBNDe(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void DUc85bHRMfDVwJHyRu(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object RF32Wo1BBU4FavBfl2(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool PpbLib2FtY7asqX2is(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object z008lYtWYgald98uHG(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object qriQleuRvI0CMqVBme(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object BrfcLach9THUBR19aH(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool HRMuyG74s1F1LraH2X()
	{
		return (object)null == null;
	}

	internal static object dY6S0BqF5MmlTUa3Y1()
	{
		return null;
	}
}
