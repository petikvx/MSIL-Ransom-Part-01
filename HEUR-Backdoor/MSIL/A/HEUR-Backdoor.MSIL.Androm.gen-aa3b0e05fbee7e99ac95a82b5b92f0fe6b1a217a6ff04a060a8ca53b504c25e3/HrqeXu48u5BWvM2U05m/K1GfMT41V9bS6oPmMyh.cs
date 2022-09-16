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
using JAhEyh46uvA1xwWjvIk;
using WGDcIt4rthaVX3IEVJJ;

namespace HrqeXu48u5BWvM2U05m;

internal class K1GfMT41V9bS6oPmMyh
{
	private delegate void iAqC0r4kaETNfPgkA8c(object o);

	internal class wdKqG24UlkmHpKqGPSb : Attribute
	{
		internal class LjVB5g4xnAQxNxQsH2R<huUadN4Zn2xZXpHnnoY>
		{
			public LjVB5g4xnAQxNxQsH2R()
			{
				xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
				base._002Ector();
			}

			static LjVB5g4xnAQxNxQsH2R()
			{
				cKXl4vhcQo();
			}
		}

		[wdKqG24UlkmHpKqGPSb(typeof(LjVB5g4xnAQxNxQsH2R<object>[]))]
		public wdKqG24UlkmHpKqGPSb(object object_0)
		{
		}
	}

	internal class qNMKJ54Fccn5uD7xTln
	{
		[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
		internal static string yq1svRsXW6(string string_0, string string_1)
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
			byte[] iV = U330SXNAZb(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Hco0mDt989();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint M1Ca2m4B2rshTs6WfDe(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr PlomMK4OPsNjZOWPnqS();

	internal struct kIDC4V4GALUx0oxXLiD
	{
		internal bool XYasa3WVlH;

		internal byte[] i97s774KnG;
	}

	internal class OSI7Ce4TTt6D5rlJwoS
	{
		private BinaryReader HBXsny9I8x;

		public OSI7Ce4TTt6D5rlJwoS(Stream stream_0)
		{
			HBXsny9I8x = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return HBXsny9I8x.BaseStream;
		}

		internal byte[] PLMsW8yUiH(int int_0)
		{
			return HBXsny9I8x.ReadBytes(int_0);
		}

		internal int EVxspixXUd(byte[] byte_0, int int_0, int int_1)
		{
			return HBXsny9I8x.Read(byte_0, int_0, int_1);
		}

		internal int MQZsdBct32()
		{
			return HBXsny9I8x.ReadInt32();
		}

		internal void jABsiIwHFA()
		{
			HBXsny9I8x.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ReXaIE4MOL2XQ8GfMtd(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Bbt6Io4EciEQWx65IhG(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int V2LEH54bCk3dOyShsoa(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int K5U4t74Aotu7K7mG3k7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr SoRD4O4Q0NOdj1Y87oR(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int kflAmm4gBk19YrBFyfr(IntPtr ptr);

	[Flags]
	private enum Qya2hl4KP74wFPQfTgy
	{

	}

	private static byte[] fIwlNCqhyS;

	private static bool FSZlDWBkHw;

	internal static Hashtable q6RsJbg5JM;

	private static kflAmm4gBk19YrBFyfr ohws2ug2pO;

	private static byte[] nQGlP6Wr3V;

	private static int Hpqlzo0X1o;

	private static byte[] BBOl6fb8CJ;

	internal static M1Ca2m4B2rshTs6WfDe tx6lCtGRRj;

	private static V2LEH54bCk3dOyShsoa Yiksl9kbGh;

	private static bool YRslSpKBnm;

	private static Bbt6Io4EciEQWx65IhG k7ms0Re1bp;

	private static K5U4t74Aotu7K7mG3k7 ONbss7mAMx;

	private static bool HaVlKnYVyo;

	private static object hgxl3cqB8I;

	private static int AjllHo5oIh;

	private static bool XVflAwQOkg;

	private static int BMLlXcwot0;

	internal static RSACryptoServiceProvider BWhl99FF18;

	internal static Assembly q7HlQ5sSbB;

	private static IntPtr gkalhFDQrA;

	internal static M1Ca2m4B2rshTs6WfDe yDGlIIWpZD;

	private static uint[] qpMlgZ8SVW;

	private static IntPtr qAIsYH8PhD;

	private static IntPtr nMusyryMht;

	private static ReXaIE4MOL2XQ8GfMtd jNWse56bLJ;

	private static int[] ojUlLbEg07;

	private static long x75locFYbq;

	private static long t7SlmLRMjp;

	private static IntPtr ovVlcslCMs;

	private static object Dbclts37pG;

	private static bool qI6lfsXbi1;

	[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
	private static bool IYDs40dxnM;

	private static SoRD4O4Q0NOdj1Y87oR efmsVfD2Wc;

	private static bool nHvlRttstE;

	private static Dictionary<int, int> eyVlrNYTxD;

	private static int BXWluLLuwR;

	private static SortedList NuKl5nguNa;

	static K1GfMT41V9bS6oPmMyh()
	{
		XVflAwQOkg = false;
		q7HlQ5sSbB = Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554497)).Assembly;
		qpMlgZ8SVW = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		HaVlKnYVyo = false;
		nHvlRttstE = false;
		BBOl6fb8CJ = new byte[0];
		BWhl99FF18 = null;
		eyVlrNYTxD = null;
		Dbclts37pG = new object();
		fIwlNCqhyS = new byte[0];
		nQGlP6Wr3V = new byte[0];
		gkalhFDQrA = IntPtr.Zero;
		ovVlcslCMs = IntPtr.Zero;
		hgxl3cqB8I = new string[0];
		ojUlLbEg07 = new int[0];
		AjllHo5oIh = 1;
		qI6lfsXbi1 = false;
		NuKl5nguNa = new SortedList();
		BMLlXcwot0 = 0;
		x75locFYbq = 0L;
		yDGlIIWpZD = null;
		tx6lCtGRRj = null;
		t7SlmLRMjp = 0L;
		BXWluLLuwR = 0;
		YRslSpKBnm = false;
		FSZlDWBkHw = false;
		Hpqlzo0X1o = 0;
		qAIsYH8PhD = IntPtr.Zero;
		IYDs40dxnM = false;
		q6RsJbg5JM = new Hashtable();
		jNWse56bLJ = null;
		k7ms0Re1bp = null;
		Yiksl9kbGh = null;
		ONbss7mAMx = null;
		efmsVfD2Wc = null;
		ohws2ug2pO = null;
		nMusyryMht = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void saE2lyPCxSkPD()
	{
	}

	internal static byte[] QCJ0HDku8S(byte[] byte_0)
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
			pxk0fa4qhp(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			pxk0fa4qhp(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			pxk0fa4qhp(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			pxk0fa4qhp(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			pxk0fa4qhp(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			pxk0fa4qhp(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			pxk0fa4qhp(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			pxk0fa4qhp(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			pxk0fa4qhp(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			pxk0fa4qhp(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			pxk0fa4qhp(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			pxk0fa4qhp(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			pxk0fa4qhp(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			pxk0fa4qhp(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			pxk0fa4qhp(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			pxk0fa4qhp(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			ihH05pagqY(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			ihH05pagqY(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			ihH05pagqY(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			ihH05pagqY(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			ihH05pagqY(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			ihH05pagqY(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			ihH05pagqY(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			ihH05pagqY(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			ihH05pagqY(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			ihH05pagqY(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			ihH05pagqY(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			ihH05pagqY(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			ihH05pagqY(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			ihH05pagqY(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			ihH05pagqY(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			ihH05pagqY(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			fZ20XMuQm1(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			fZ20XMuQm1(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			fZ20XMuQm1(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			fZ20XMuQm1(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			fZ20XMuQm1(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			fZ20XMuQm1(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			fZ20XMuQm1(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			fZ20XMuQm1(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			fZ20XMuQm1(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			fZ20XMuQm1(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			fZ20XMuQm1(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			fZ20XMuQm1(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			fZ20XMuQm1(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			fZ20XMuQm1(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			fZ20XMuQm1(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			fZ20XMuQm1(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			kth0odpO6P(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			kth0odpO6P(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			kth0odpO6P(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			kth0odpO6P(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			kth0odpO6P(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			kth0odpO6P(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			kth0odpO6P(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			kth0odpO6P(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			kth0odpO6P(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			kth0odpO6P(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			kth0odpO6P(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			kth0odpO6P(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			kth0odpO6P(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			kth0odpO6P(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			kth0odpO6P(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			kth0odpO6P(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void pxk0fa4qhp(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + p4c0I4YFur(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + qpMlgZ8SVW[uint_5 - 1], ushort_0);
	}

	private static void ihH05pagqY(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + p4c0I4YFur(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + qpMlgZ8SVW[uint_5 - 1], ushort_0);
	}

	private static void fZ20XMuQm1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + p4c0I4YFur(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + qpMlgZ8SVW[uint_5 - 1], ushort_0);
	}

	private static void kth0odpO6P(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + p4c0I4YFur(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + qpMlgZ8SVW[uint_5 - 1], ushort_0);
	}

	private static uint p4c0I4YFur(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool Q2J0C6lIDY()
	{
		if (!HaVlKnYVyo)
		{
			nYo0uEUF2n();
			HaVlKnYVyo = true;
		}
		return nHvlRttstE;
	}

	internal static SymmetricAlgorithm Hco0mDt989()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Q2J0C6lIDY())
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

	internal static void nYo0uEUF2n()
	{
		try
		{
			nHvlRttstE = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] U330SXNAZb(byte[] byte_0)
	{
		if (!Q2J0C6lIDY())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return QCJ0HDku8S(byte_0);
	}

	internal static void ucX0DcaoTi(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			y920zn8v4t(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void y920zn8v4t(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint EcplY6ZW2L(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
	internal static void cKXl4vhcQo()
	{
		int num = 2;
		string text = default(string);
		HashAlgorithm object_ = default(HashAlgorithm);
		string object_2 = default(string);
		int num7 = default(int);
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		byte[] object_6 = default(byte[]);
		byte[] object_7 = default(byte[]);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		CryptoStream object_4 = default(CryptoStream);
		Stream stream = default(Stream);
		int num6 = default(int);
		int num10 = default(int);
		int num21 = default(int);
		int num17 = default(int);
		long num15 = default(long);
		uint num22 = default(uint);
		uint num12 = default(uint);
		uint num24 = default(uint);
		long num25 = default(long);
		long num19 = default(long);
		long num20 = default(long);
		uint num23 = default(uint);
		byte[] array5 = default(byte[]);
		int int_ = default(int);
		uint uint_2 = default(uint);
		uint num16 = default(uint);
		long long_ = default(long);
		bool flag2 = default(bool);
		uint uint_ = default(uint);
		uint num18 = default(uint);
		int num13 = default(int);
		int num27 = default(int);
		bool flag = default(bool);
		while (BWhl99FF18 == null)
		{
			int num2 = 1;
			if (!Ge5NegboUUNgr7ESHr())
			{
				goto IL_0066;
			}
			goto IL_014f;
			IL_0066:
			num2 = num;
			goto IL_014f;
			IL_014f:
			while (true)
			{
				switch (num2)
				{
				case 17:
					fPYpgUyTPiw6ncn0fk(bool_0: true);
					goto case 7;
				case 7:
					BWhl99FF18 = new RSACryptoServiceProvider();
					goto case 12;
				case 12:
					text = (string)pWnlJh1UbKRv66jv7G(avy8MoHTEf8exIGo5X(typeof(K1GfMT41V9bS6oPmMyh).TypeHandle).Assembly);
					num = 5;
					goto case 5;
				case 5:
					if (text == null)
					{
						return;
					}
					goto IL_0056;
				case 16:
					flag = false;
					num2 = 0;
					if (!Ge5NegboUUNgr7ESHr())
					{
						continue;
					}
					goto default;
				case 13:
					break;
				case 11:
					try
					{
						object_ = (HashAlgorithm)ujAYB4TrDcBWalkmpj();
						int num3 = 2;
						while (true)
						{
							IL_00df:
							object_2 = (string)xxNPB3esoamD0OeiwR("SHA1");
							int num4 = 1;
							if (DfyXmlmmejXUeHeXgX() != null)
							{
								goto IL_00c4;
							}
							goto IL_00c8;
							IL_00c8:
							while (true)
							{
								switch (num4)
								{
								case 1:
									if (xt4wUwWcmvM4vx5YuH(text))
									{
										goto end_IL_00c8;
									}
									goto IL_00b7;
								default:
									return;
								case 2:
									break;
								case 0:
									return;
								case 3:
									goto end_IL_00c8;
								}
								goto IL_00df;
								IL_00b7:
								num4 = 0;
								if (DfyXmlmmejXUeHeXgX() == null)
								{
									continue;
								}
								goto IL_00c4;
								continue;
								end_IL_00c8:
								break;
							}
							break;
							IL_00c4:
							num4 = num3;
							goto IL_00c8;
						}
					}
					catch
					{
						if (!Ge5NegboUUNgr7ESHr())
						{
							switch (0)
							{
							}
						}
						return;
					}
					goto case 16;
				case 9:
					object_ = null;
					num2 = 13;
					if (Ge5NegboUUNgr7ESHr())
					{
						continue;
					}
					goto IL_0066;
				case 8:
					if (YI5U7x4omhHh2ZYaBh(text) != 0)
					{
						goto case 9;
					}
					return;
				case 1:
					MPdsv0PKZN23xhVqNq();
					goto case 17;
				case 2:
					goto end_IL_014f;
				default:
					try
					{
						OSI7Ce4TTt6D5rlJwoS object_3 = new OSI7Ce4TTt6D5rlJwoS((Stream)WArdcg3wkTT33VLrj4(q7HlQ5sSbB, "78BUnQUE7mggJl7fOD.JjhEAGDLL0CYbR41s3"));
						while (true)
						{
							HTTcFNdyZH2754fgnY(nNqbubqcE7RZxXSRBg(object_3), 0L);
							while (true)
							{
								byte[] array = (byte[])dFPORSpbGs1pCpdXge(object_3, (int)yWB4wCrQYnKLJqEeOa(nNqbubqcE7RZxXSRBg(object_3)));
								while (true)
								{
									byte[] array2 = new byte[32];
									int num5 = 118;
									if (!Ge5NegboUUNgr7ESHr())
									{
										goto IL_01fa;
									}
									goto IL_1e85;
									IL_1e85:
									while (true)
									{
										switch (num5)
										{
										case 365:
											num7 = 168;
											num6 = 25;
											goto case 25;
										case 25:
											array2[21] = (byte)num7;
											num5 = 319;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 364:
											array2[30] = (byte)num7;
											goto case 179;
										case 179:
											num7 = 60;
											goto case 149;
										case 149:
											array2[30] = (byte)num7;
											goto case 206;
										case 206:
											num7 = 138;
											num5 = 57;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 236;
										case 236:
											array2[30] = (byte)num7;
											goto case 210;
										case 210:
											num7 = 197;
											goto case 77;
										case 77:
											array2[30] = (byte)num7;
											num5 = 13;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 14;
										case 14:
											array2[31] = 158;
											goto case 122;
										case 122:
											num7 = 113;
											goto case 140;
										case 140:
											array2[31] = (byte)num7;
											num5 = 9;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 363:
											array3[7] = 155;
											num5 = 40;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 362:
											array2[3] = 149;
											num5 = 125;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 75;
										case 75:
											array2[23] = 150;
											goto case 52;
										case 52:
											num7 = 167;
											num6 = 42;
											goto case 42;
										case 42:
											array2[23] = (byte)num7;
											goto case 267;
										case 267:
											num7 = 112;
											num5 = 193;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 246;
										case 246:
											array2[23] = (byte)num7;
											num6 = 97;
											goto case 97;
										case 97:
											num7 = 111;
											goto case 245;
										case 245:
											array2[23] = (byte)num7;
											goto case 304;
										case 304:
											num7 = 6;
											num5 = 335;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 361:
											num8 = 101;
											goto case 233;
										case 233:
											array3[6] = (byte)num8;
											num6 = 348;
											goto case 348;
										case 348:
											num8 = 140;
											num6 = 70;
											goto case 70;
										case 70:
											array3[6] = (byte)num8;
											goto case 175;
										case 175:
											num8 = 137;
											goto case 279;
										case 279:
											array3[6] = (byte)num8;
											num5 = 66;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 360:
											array2[6] = (byte)num7;
											num6 = 227;
											goto case 227;
										case 227:
											num7 = 167;
											goto case 163;
										case 163:
											array2[6] = (byte)num7;
											goto case 101;
										case 101:
											array2[6] = 155;
											goto case 239;
										case 239:
											array2[6] = 135;
											num5 = 251;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 359:
											array2[15] = (byte)num7;
											num5 = 26;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 23;
										case 23:
											array3[1] = 13;
											goto case 195;
										case 195:
											array3[1] = 128;
											goto case 314;
										case 314:
											num8 = 131;
											num5 = 85;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 110;
										case 110:
											array3[1] = (byte)num8;
											num5 = 172;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 358:
											array2[16] = (byte)num7;
											goto case 316;
										case 316:
											num7 = 227;
											num5 = 4;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 4;
										case 4:
											array2[16] = (byte)num7;
											goto case 152;
										case 152:
											num7 = 146;
											goto case 154;
										case 154:
											array2[17] = (byte)num7;
											goto case 284;
										case 284:
											array2[17] = 91;
											goto case 68;
										case 68:
											array2[17] = 158;
											goto case 241;
										case 241:
											array2[17] = 38;
											num5 = 321;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 307;
										case 307:
											array3[11] = (byte)num8;
											goto case 114;
										case 114:
											array3[11] = 114;
											num5 = 187;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 36;
										case 36:
											array2[19] = 94;
											goto case 265;
										case 265:
											num7 = 193;
											goto case 296;
										case 296:
											array2[19] = (byte)num7;
											goto case 283;
										case 283:
											num7 = 147;
											goto case 35;
										case 35:
											array2[19] = (byte)num7;
											num5 = 7;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 357:
											num8 = 137;
											num6 = 38;
											goto case 38;
										case 38:
											array3[5] = (byte)num8;
											goto case 256;
										case 256:
											array3[5] = 134;
											num5 = 33;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 356:
											num7 = 83;
											num5 = 126;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 110;
										case 355:
											array2[3] = 62;
											goto case 102;
										case 102:
											num7 = 122;
											goto case 235;
										case 235:
											array2[3] = (byte)num7;
											goto case 11;
										case 11:
											array2[3] = 161;
											goto case 250;
										case 250:
											array2[4] = 120;
											num5 = 49;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 161;
										case 161:
											array2[4] = 90;
											num5 = 13;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 171;
										case 171:
											num7 = 56;
											goto case 2;
										case 2:
											array2[4] = (byte)num7;
											goto case 224;
										case 224:
											num7 = 145;
											num5 = 13;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 354:
											num8 = 144;
											goto case 268;
										case 268:
											array3[8] = (byte)num8;
											goto case 312;
										case 312:
											array3[8] = 104;
											goto case 27;
										case 27:
											array3[8] = 165;
											num6 = 234;
											goto case 234;
										case 234:
											num8 = 67;
											goto case 113;
										case 113:
											array3[9] = (byte)num8;
											num5 = 156;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 353:
											num7 = 116;
											goto case 167;
										case 167:
											array2[11] = (byte)num7;
											goto case 131;
										case 131:
											num7 = 39;
											num6 = 58;
											goto case 58;
										case 58:
											array2[11] = (byte)num7;
											goto case 306;
										case 306:
											num7 = 102;
											num5 = 176;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 346;
										case 346:
											array2[12] = (byte)num7;
											goto case 130;
										case 130:
											array2[12] = 142;
											goto case 61;
										case 61:
											array2[12] = 69;
											num5 = 34;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 244;
										case 244:
											array2[13] = 148;
											goto case 92;
										case 92:
											array2[13] = 141;
											goto case 329;
										case 329:
											array2[13] = 123;
											goto case 238;
										case 238:
											array2[13] = 110;
											num5 = 69;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 26;
										case 26:
											array2[16] = 17;
											num5 = 257;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 352:
											num7 = 165;
											num5 = 39;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 351:
											num8 = 42;
											goto case 332;
										case 332:
											array3[7] = (byte)num8;
											goto case 216;
										case 216:
											array3[7] = 94;
											goto case 363;
										case 350:
											array2[18] = 76;
											goto case 89;
										case 89:
											array2[18] = 98;
											num5 = 65;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 200;
										case 200:
											num7 = 106;
											num5 = 292;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 349:
											array2[10] = 103;
											num5 = 88;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 347:
											array2[10] = (byte)num7;
											goto case 299;
										case 299:
											array2[11] = 100;
											num5 = 353;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 345:
											array3[8] = 161;
											goto case 196;
										case 196:
											array3[8] = 104;
											goto case 354;
										case 344:
											array2[15] = (byte)num7;
											goto case 6;
										case 6:
											array2[15] = 130;
											num5 = 39;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 136;
										case 136:
											num7 = 118;
											goto case 215;
										case 215:
											array2[15] = (byte)num7;
											num5 = 223;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 343:
											array3[3] = (byte)num8;
											goto case 173;
										case 173:
											num8 = 54;
											goto case 112;
										case 112:
											array3[3] = (byte)num8;
											num5 = 71;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 42;
										case 342:
											num7 = 42;
											goto case 83;
										case 83:
											array2[14] = (byte)num7;
											num5 = 325;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 341:
											array2[5] = 104;
											goto case 30;
										case 30:
											array2[5] = 59;
											goto case 28;
										case 28:
											num7 = 146;
											goto case 360;
										case 340:
											array2[2] = 26;
											num5 = 362;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 362;
										case 339:
											array2[27] = (byte)num7;
											goto case 10;
										case 10:
											array2[27] = 104;
											num5 = 98;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 338:
											array2[14] = (byte)num7;
											goto case 170;
										case 170:
											array2[14] = 146;
											goto case 342;
										case 337:
											array2[24] = 155;
											num6 = 333;
											goto case 333;
										case 333:
											array2[24] = 124;
											num5 = 313;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 336:
											array3[0] = (byte)num8;
											goto case 315;
										case 315:
											array3[0] = 135;
											num5 = 134;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 271;
										case 271:
											num8 = 133;
											goto case 3;
										case 3:
											array3[0] = (byte)num8;
											goto case 18;
										case 18:
											array3[0] = 109;
											goto case 23;
										case 335:
											array2[23] = (byte)num7;
											num5 = 302;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 334:
											array2[21] = 88;
											goto case 41;
										case 41:
											num7 = 105;
											goto case 190;
										case 190:
											array2[21] = (byte)num7;
											goto case 111;
										case 111:
											num7 = 148;
											num5 = 169;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 331:
											array2[14] = (byte)num7;
											goto case 280;
										case 280:
											num7 = 155;
											goto case 338;
										case 330:
											array2[29] = 169;
											goto case 352;
										case 328:
											num7 = 143;
											num5 = 105;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 84;
										case 84:
											array2[26] = 63;
											goto case 99;
										case 99:
											array2[26] = 186;
											num5 = 282;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 193;
										case 193:
											num7 = 104;
											goto case 115;
										case 115:
											array2[25] = (byte)num7;
											num5 = 0;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 327:
											array2[31] = (byte)num7;
											num5 = 301;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 326:
											array2[2] = (byte)num7;
											goto case 229;
										case 229:
											num7 = 84;
											goto case 287;
										case 287:
											array2[2] = (byte)num7;
											goto case 189;
										case 189:
											array2[2] = 147;
											goto case 356;
										case 325:
											array2[14] = 207;
											goto case 49;
										case 49:
											num7 = 49;
											num5 = 276;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 324:
											num8 = 132;
											goto case 65;
										case 65:
											array3[8] = (byte)num8;
											goto case 345;
										case 323:
											num8 = 130;
											num5 = 155;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 322:
											num7 = 88;
											goto case 252;
										case 252:
											array2[30] = (byte)num7;
											goto case 60;
										case 60:
											num7 = 136;
											goto case 364;
										case 321:
											array2[17] = 191;
											goto case 182;
										case 182:
											array2[17] = 40;
											goto case 350;
										case 320:
											array2[10] = (byte)num7;
											goto case 349;
										case 319:
											num7 = 168;
											goto case 300;
										case 300:
											array2[21] = (byte)num7;
											num6 = 214;
											goto case 214;
										case 214:
											array2[21] = 85;
											goto case 334;
										case 318:
											array3[14] = (byte)num8;
											goto case 270;
										case 270:
											array3[14] = 118;
											num5 = 20;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 317:
											num7 = 123;
											num5 = 303;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 313:
											num7 = 105;
											goto case 79;
										case 79:
											array2[24] = (byte)num7;
											goto case 107;
										case 107:
											num7 = 78;
											num6 = 81;
											goto case 81;
										case 81:
											array2[24] = (byte)num7;
											goto case 193;
										case 311:
											array3[9] = 242;
											num6 = 242;
											goto case 242;
										case 242:
											array3[10] = 112;
											goto case 73;
										case 73:
											num8 = 151;
											num5 = 202;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 309:
											num7 = 72;
											goto case 327;
										case 308:
											num7 = 32;
											num5 = 288;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 305:
											num7 = 20;
											num5 = 344;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 303:
											array2[29] = (byte)num7;
											num5 = 55;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 302:
											array2[24] = 125;
											num6 = 337;
											goto case 337;
										case 301:
											num7 = 118;
											num5 = 89;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 91;
										case 91:
											array2[31] = (byte)num7;
											goto case 53;
										case 53:
											object_6 = array2;
											goto case 148;
										case 148:
											array3 = new byte[16];
											goto case 178;
										case 178:
											num8 = 86;
											goto case 166;
										case 166:
											array3[0] = (byte)num8;
											goto case 180;
										case 180:
											num8 = 108;
											num5 = 336;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 24;
										case 24:
											num7 = 98;
											goto case 116;
										case 116:
											array2[23] = (byte)num7;
											num5 = 75;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 75;
										case 297:
											array2[9] = 155;
											num5 = 46;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 295:
											array3[6] = (byte)num8;
											num5 = 224;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 237;
										case 237:
											array3[6] = 131;
											num5 = 64;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 103;
										case 103:
											num8 = 25;
											goto case 253;
										case 253:
											array3[6] = (byte)num8;
											goto case 150;
										case 150:
											array3[7] = 95;
											num6 = 222;
											goto case 222;
										case 222:
											num8 = 165;
											num5 = 66;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 191;
										case 191:
											array3[7] = (byte)num8;
											goto case 351;
										case 294:
											num7 = 126;
											num5 = 331;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 293:
											array3[2] = (byte)num8;
											num5 = 74;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 292:
											array2[18] = (byte)num7;
											num5 = 275;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 291:
											array2[28] = 107;
											goto case 145;
										case 145:
											num7 = 112;
											num5 = 141;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 290:
											array3[4] = 166;
											goto case 357;
										case 289:
											array3[9] = (byte)num8;
											num5 = 17;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 288:
											array2[0] = (byte)num7;
											goto case 67;
										case 67:
											num7 = 195;
											goto case 22;
										case 22:
											array2[1] = (byte)num7;
											goto case 176;
										case 176:
											num7 = 126;
											num5 = 104;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 185;
										case 185:
											array2[1] = (byte)num7;
											num5 = 129;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 50;
										case 50:
											num8 = 160;
											goto case 218;
										case 218:
											array3[12] = (byte)num8;
											num6 = 184;
											goto case 184;
										case 184:
											array3[13] = 145;
											goto case 211;
										case 211:
											array3[13] = 97;
											num5 = 323;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 286:
											array3[15] = 91;
											goto case 158;
										case 158:
											array3[15] = 28;
											num5 = 103;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 117;
										case 117:
											object_7 = array3;
											goto case 228;
										case 228:
											object_5 = (SymmetricAlgorithm)t8mi287Nty3QuIwIEf();
											num5 = 146;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 285:
											num8 = 224;
											goto case 266;
										case 266:
											array3[5] = (byte)num8;
											num5 = 139;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 282:
											num7 = 50;
											goto case 142;
										case 142:
											array2[27] = (byte)num7;
											goto case 264;
										case 264:
											num7 = 94;
											goto case 339;
										case 281:
											array3[3] = (byte)num8;
											goto case 134;
										case 134:
											num8 = 120;
											num6 = 343;
											goto case 343;
										case 278:
											array2[28] = (byte)num7;
											goto case 82;
										case 82:
											array2[29] = 66;
											num5 = 330;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 277:
											num7 = 214;
											goto case 62;
										case 62:
											array2[28] = (byte)num7;
											goto case 120;
										case 120:
											array2[28] = 148;
											num5 = 248;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 276:
											array2[14] = (byte)num7;
											num5 = 164;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 275:
											array2[18] = 87;
											goto case 213;
										case 213:
											num7 = 133;
											num6 = 57;
											goto case 57;
										case 57:
											array2[18] = (byte)num7;
											num5 = 3;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 5;
										case 5:
											array2[18] = 142;
											goto case 15;
										case 15:
											num7 = 150;
											goto case 124;
										case 124:
											array2[19] = (byte)num7;
											goto case 96;
										case 96:
											num7 = 157;
											num5 = 262;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 100;
										case 100:
											array2[7] = (byte)num7;
											num5 = 240;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 274:
											array2[15] = (byte)num7;
											goto case 48;
										case 48:
											num7 = 12;
											num5 = 359;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 273:
											array2[9] = (byte)num7;
											num5 = 29;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 272:
											array2[1] = (byte)num7;
											goto case 19;
										case 19:
											num7 = 91;
											goto case 326;
										case 269:
											transform = (ICryptoTransform)MrAYaZf30mhAjtMeYH(object_5, object_6, object_7);
											num5 = 133;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 263:
											num7 = 28;
											goto case 100;
										case 262:
											array2[19] = (byte)num7;
											num6 = 230;
											goto case 230;
										case 230:
											array2[19] = 160;
											num6 = 36;
											goto case 36;
										case 261:
											array2[7] = 93;
											goto case 225;
										case 225:
											num7 = 93;
											num5 = 104;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 174;
										case 174:
											array2[7] = (byte)num7;
											num5 = 263;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 259:
											array3[11] = 154;
											num5 = 205;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 257:
											num7 = 116;
											num5 = 358;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 129;
										case 129:
											num7 = 114;
											goto case 272;
										case 255:
											array3[12] = (byte)num8;
											goto case 51;
										case 51:
											num8 = 169;
											num6 = 128;
											goto case 128;
										case 128:
											array3[12] = (byte)num8;
											num5 = 137;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 254:
											num7 = 163;
											num5 = 151;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 137;
										case 137:
											array3[12] = 177;
											num6 = 50;
											goto case 50;
										case 251:
											array2[6] = 144;
											goto case 177;
										case 177:
											num7 = 60;
											goto case 31;
										case 31:
											array2[6] = (byte)num7;
											goto case 85;
										case 85:
											array2[7] = 148;
											num5 = 8;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 249:
											num8 = 241;
											goto case 232;
										case 232:
											array3[3] = (byte)num8;
											num5 = 160;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 2;
										case 248:
											array2[28] = 113;
											num5 = 291;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 247:
											num8 = 83;
											goto case 281;
										case 243:
											array2[20] = (byte)num7;
											num5 = 138;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 134;
										case 240:
											array2[8] = 115;
											num5 = 186;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 231:
											array3[15] = (byte)num8;
											goto case 226;
										case 226:
											num8 = 142;
											goto case 37;
										case 37:
											array3[15] = (byte)num8;
											num5 = 181;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 57;
										case 223:
											num7 = 127;
											goto case 274;
										case 221:
											array2[0] = 214;
											goto case 308;
										case 220:
											num8 = 116;
											num5 = 231;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 193;
										case 219:
											array2[30] = (byte)num7;
											num5 = 322;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 217:
											num8 = 149;
											num5 = 162;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 212:
											array2[10] = 156;
											goto case 108;
										case 108:
											num7 = 15;
											goto case 347;
										case 208:
											num7 = 157;
											goto case 243;
										case 207:
											array2[8] = 167;
											goto case 297;
										case 205:
											array3[11] = 150;
											num6 = 197;
											goto case 197;
										case 197:
											array3[11] = 80;
											goto case 94;
										case 94:
											num8 = 145;
											goto case 307;
										case 204:
											array3[5] = (byte)num8;
											num5 = 285;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 203:
											num7 = 111;
											num5 = 219;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 202:
											array3[10] = (byte)num8;
											goto case 16;
										case 16:
											num8 = 12;
											num6 = 135;
											goto case 135;
										case 135:
											array3[10] = (byte)num8;
											num5 = 259;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 201:
											num8 = 154;
											goto case 56;
										case 56:
											array3[4] = (byte)num8;
											num5 = 143;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 199:
											num7 = 140;
											num5 = 320;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 198:
											array2[10] = (byte)num7;
											num5 = 212;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 38;
										case 194:
											array2[25] = (byte)num7;
											num5 = 47;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 90;
										case 90:
											array2[26] = 98;
											goto case 84;
										case 192:
											array2[22] = 85;
											goto case 328;
										case 188:
											array3[3] = (byte)num8;
											num6 = 159;
											goto case 159;
										case 159:
											num8 = 94;
											goto case 147;
										case 147:
											array3[3] = (byte)num8;
											num5 = 249;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 187:
											array3[12] = 144;
											num5 = 121;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 119;
										case 119:
											array3[15] = (byte)num8;
											goto case 286;
										case 186:
											array2[8] = 97;
											num5 = 207;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 183:
											f4ZIMkiwgusRvWbVtL(object_4, array, 0, array.Length);
											num5 = 76;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 181:
											num8 = 146;
											num5 = 119;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 98;
										case 98:
											array2[27] = 144;
											goto case 277;
										case 172:
											array3[2] = 47;
											goto case 47;
										case 47:
											num8 = 170;
											num5 = 93;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 293;
										case 169:
											array2[21] = (byte)num7;
											goto case 192;
										case 165:
											array2[29] = 248;
											num5 = 203;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 164:
											num7 = 150;
											goto case 93;
										case 93:
											array2[15] = (byte)num7;
											num5 = 305;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 162:
											array3[13] = (byte)num8;
											num5 = 59;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 160:
											num8 = 70;
											num5 = 3;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 12;
										case 12:
											array3[4] = (byte)num8;
											goto case 201;
										case 157:
											object_4 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
											goto case 183;
										case 156:
											array3[9] = 85;
											goto case 109;
										case 109:
											num8 = 176;
											num6 = 289;
											goto case 289;
										case 155:
											array3[13] = (byte)num8;
											goto case 217;
										case 153:
											array3[9] = 115;
											goto case 311;
										case 151:
											array2[7] = (byte)num7;
											goto case 261;
										case 146:
											zy8eiIougXcJFk1YZq(object_5, CipherMode.CBC);
											goto case 269;
										case 144:
											array2[13] = (byte)num7;
											num5 = 294;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 143:
											array3[4] = 62;
											goto case 21;
										case 21:
											array3[4] = 170;
											num5 = 290;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 169;
										case 141:
											array2[28] = (byte)num7;
											goto case 80;
										case 80:
											num7 = 125;
											num5 = 278;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 139:
											num8 = 153;
											goto case 43;
										case 43:
											array3[5] = (byte)num8;
											num5 = 361;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 138:
											array2[20] = 59;
											num5 = 39;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 44;
										case 44:
											array2[20] = 248;
											goto case 365;
										case 133:
											stream = (Stream)woheGHSqhmDSZ2a8Xc();
											goto case 157;
										case 132:
											num7 = 128;
											num5 = 1;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 127:
											array2[4] = (byte)num7;
											goto case 132;
										case 126:
											array2[2] = (byte)num7;
											goto case 340;
										case 125:
											num7 = 87;
											num5 = 72;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 4;
										case 121:
											num8 = 86;
											num6 = 255;
											goto case 255;
										case 118:
											array2[0] = 72;
											num5 = 221;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 105:
											array2[22] = (byte)num7;
											goto case 86;
										case 86:
											num7 = 7;
											num5 = 104;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 104:
											array2[22] = (byte)num7;
											goto case 24;
										case 95:
											array2[20] = 133;
											goto case 45;
										case 45:
											array2[20] = 96;
											num6 = 208;
											goto case 208;
										case 88:
											num7 = 121;
											goto case 198;
										case 87:
											array3[14] = (byte)num8;
											num5 = 64;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 78:
											array2[25] = 169;
											goto case 63;
										case 63:
											num7 = 99;
											num5 = 89;
											if (!Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 194;
										case 74:
											array3[2] = 104;
											num5 = 247;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 238;
										case 72:
											array2[3] = (byte)num7;
											goto case 355;
										case 71:
											num8 = 113;
											goto case 188;
										case 69:
											num7 = 160;
											goto case 144;
										case 66:
											num8 = 191;
											num5 = 294;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 295;
										case 64:
											array3[14] = 128;
											num5 = 220;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 59:
											num8 = 127;
											num5 = 318;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										case 55:
											array2[29] = 152;
											num5 = 165;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 54:
											num7 = 112;
											goto case 127;
										case 46:
											num7 = 166;
											num5 = 33;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 273;
										case 40:
											array3[7] = 201;
											goto case 324;
										case 39:
											array2[29] = (byte)num7;
											goto case 317;
										case 34:
											array2[7] = (byte)num7;
											num5 = 254;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 33:
											num8 = 159;
											num5 = 204;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto case 105;
										case 32:
											array2[20] = (byte)num7;
											num6 = 95;
											goto case 95;
										case 29:
											array2[9] = 240;
											num5 = 199;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto case 14;
										case 20:
											num8 = 91;
											goto case 87;
										case 17:
											array3[9] = 28;
											num5 = 153;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 13:
											array2[4] = (byte)num7;
											num6 = 54;
											goto case 54;
										case 9:
											array2[31] = 122;
											goto case 309;
										case 8:
											num7 = 132;
											num5 = 34;
											if (Ge5NegboUUNgr7ESHr())
											{
												continue;
											}
											goto IL_01fa;
										case 7:
											num7 = 165;
											goto case 32;
										case 1:
											array2[5] = (byte)num7;
											num5 = 341;
											if (DfyXmlmmejXUeHeXgX() == null)
											{
												continue;
											}
											goto IL_01fa;
										default:
											array2[25] = 116;
											goto case 78;
										case 258:
											break;
										case 106:
											goto end_IL_2447;
										case 260:
											goto end_IL_246a;
										case 76:
											hI7clncIijtHAM0Z1X(object_4);
											num6 = 168;
											goto case 168;
										case 168:
											DWT2WK22rB324vmFfZ(BWhl99FF18, m7ejl0BJPcbLvcX1Cy(Y1Z5IhMviXPCbXa36M(), TDvpKV54lldnIrhntE(stream)));
											goto case 310;
										case 310:
											FmWVkEa5Vtnoa2BefV(stream);
											goto case 298;
										case 298:
											FmWVkEa5Vtnoa2BefV(object_4);
											goto case 209;
										case 209:
											WaFAQ7J3YtmsLv5kxP(object_3);
											goto end_IL_2482;
										case 123:
											goto end_IL_2482;
										}
										break;
									}
									continue;
									IL_01fa:
									num5 = num6;
									goto IL_1e85;
									continue;
									end_IL_2447:
									break;
								}
								continue;
								end_IL_246a:
								break;
							}
							continue;
							end_IL_2482:
							break;
						}
					}
					catch
					{
						int num9 = 0;
						if (Ge5NegboUUNgr7ESHr())
						{
							goto IL_24e9;
						}
						goto IL_24fd;
						IL_24fd:
						switch (num9)
						{
						case 1:
							goto end_IL_24db;
						}
						goto IL_24e9;
						IL_24e9:
						flag = true;
						num9 = 1;
						if (!Ge5NegboUUNgr7ESHr())
						{
							num9 = num10;
						}
						goto IL_24fd;
						end_IL_24db:;
					}
					goto case 4;
				case 4:
					if (!flag)
					{
						goto case 10;
					}
					goto case 15;
				case 10:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						while (true)
						{
							BinaryReader object_8 = new BinaryReader(fileStream);
							while (true)
							{
								byte[] array4 = new byte[65536];
								int num11 = 28;
								if (DfyXmlmmejXUeHeXgX() != null)
								{
									goto IL_256b;
								}
								goto IL_29bf;
								IL_29bf:
								while (true)
								{
									int num14;
									switch (num11)
									{
									case 75:
										array4[32] = 0;
										num11 = 20;
										if (!Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto case 25;
									case 25:
										array4[33] = 0;
										goto case 65;
									case 65:
										array4[34] = 0;
										goto case 13;
									case 13:
										array4[35] = 0;
										goto case 18;
									case 18:
										array4[36] = 0;
										goto case 4;
									case 4:
										array4[37] = 0;
										num11 = 6;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto IL_256b;
									case 74:
										array4[64] = 0;
										num11 = 0;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto IL_256b;
									case 36:
									case 73:
										num21++;
										num11 = 9;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto case 9;
									case 9:
									case 20:
										if (num21 < num17)
										{
											goto case 35;
										}
										goto case 60;
									case 35:
										HTTcFNdyZH2754fgnY(fileStream, num15 + num21 * 40 + 16L);
										goto case 56;
									case 56:
										num22 = tpuKd6jyVZXQb2SSPZ(object_8);
										goto case 45;
									case 45:
										num12 = tpuKd6jyVZXQb2SSPZ(object_8);
										num11 = 34;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto case 33;
									case 33:
										HTTcFNdyZH2754fgnY(fileStream, PAQcfUDfw4PEnk995c(fileStream) + num24);
										goto case 21;
									case 63:
										num25 = PAQcfUDfw4PEnk995c(fileStream);
										goto case 27;
									case 27:
										if (num19 <= num25)
										{
											goto case 30;
										}
										goto case 8;
									case 30:
										if (num25 < num20)
										{
											goto case 17;
										}
										goto case 8;
									case 17:
										num24 = (uint)(num20 - num25);
										goto case 26;
									case 26:
										if (num24 >= num22)
										{
											goto case 36;
										}
										goto case 43;
									case 21:
									case 66:
									case 72:
										if (num22 == 0)
										{
											goto case 36;
										}
										goto case 63;
									case 60:
										MDvfx8ZiRIEwYFE4yp(object_, new byte[0], 0, 0);
										goto case 12;
									case 12:
										HTTcFNdyZH2754fgnY(fileStream, num19);
										num11 = 57;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto IL_256b;
									case 8:
									case 46:
									case 50:
										if (num25 < num20)
										{
											num11 = 2;
											if (DfyXmlmmejXUeHeXgX() != null)
											{
												continue;
											}
											goto case 10;
										}
										goto case 32;
									case 10:
									case 11:
										num23 = (uint)lUK67eVbi7C3aTwhEo(num19 - num25, num22);
										num11 = 70;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto IL_256b;
									case 32:
										J4iqcbvQvbFtarBLEE(object_, fileStream, num22, array4);
										num11 = 36;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto IL_256b;
									case 43:
										num22 -= num24;
										num11 = 33;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto case 29;
									case 29:
										wEY9jmlAJpQOWU44Tm(array5);
										num11 = 51;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto IL_256b;
									case 71:
										array4[39] = 0;
										num11 = 1;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto IL_256b;
									case 70:
										J4iqcbvQvbFtarBLEE(object_, fileStream, num23, array4);
										num11 = 67;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto IL_256b;
									case 69:
										PjidbWnElC6KTttYpx(object_, array4, 0, int_);
										goto case 47;
									case 47:
										oojHpNsWGwUKVWMTIx(fileStream, array4, 0, 128);
										goto case 75;
									case 68:
										HTTcFNdyZH2754fgnY(fileStream, num15);
										num11 = 58;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto IL_256b;
									case 67:
										num22 -= num23;
										goto case 21;
									case 64:
										array4[66] = 0;
										num11 = 41;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto IL_256b;
									case 62:
										uint_2 = tpuKd6jyVZXQb2SSPZ(object_8);
										num11 = 49;
										if (DfyXmlmmejXUeHeXgX() != null)
										{
											continue;
										}
										goto case 52;
									case 52:
										num16 = tpuKd6jyVZXQb2SSPZ(object_8);
										goto case 49;
									case 49:
										num19 = wUdA3RGX31EO7vajhC(uint_2, num17, num15, object_8);
										goto case 2;
									case 2:
										num20 = num19 + num16;
										num11 = 7;
										if (!Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto case 7;
									case 7:
										HTTcFNdyZH2754fgnY(fileStream, long_);
										goto case 61;
									case 61:
										num21 = 0;
										goto case 9;
									case 59:
										num17 = fxC6Y0t2PYMTnaq9Sh(object_8);
										goto case 68;
									case 58:
										J4iqcbvQvbFtarBLEE(object_, fileStream, (uint)(num17 * 40), array4);
										goto case 40;
									case 40:
										long_ = PAQcfUDfw4PEnk995c(fileStream);
										goto case 48;
									case 48:
										if (!flag2)
										{
											goto case 5;
										}
										goto case 19;
									case 5:
									case 23:
										HTTcFNdyZH2754fgnY(fileStream, 376L);
										num11 = 7;
										if (DfyXmlmmejXUeHeXgX() != null)
										{
											continue;
										}
										goto case 14;
									case 19:
										HTTcFNdyZH2754fgnY(fileStream, 360L);
										goto case 14;
									case 14:
									case 42:
										uint_ = tpuKd6jyVZXQb2SSPZ(object_8);
										num11 = 9;
										if (DfyXmlmmejXUeHeXgX() != null)
										{
											continue;
										}
										goto case 22;
									case 22:
										num18 = wUdA3RGX31EO7vajhC(uint_, num17, num15, object_8);
										goto case 3;
									case 3:
										HTTcFNdyZH2754fgnY(fileStream, num18 + 32);
										num13 = 62;
										goto case 62;
									case 57:
										array5 = (byte[])hBmBkJu8oX4Zhey1eM(object_8, (int)num16);
										goto case 29;
									case 55:
										HTTcFNdyZH2754fgnY(fileStream, 152L);
										goto case 31;
									case 31:
										oojHpNsWGwUKVWMTIx(fileStream, array4, 0, int_);
										num11 = 74;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto IL_256b;
									case 54:
										num14 = 112;
										goto IL_28cf;
									case 53:
										num15 = PAQcfUDfw4PEnk995c(fileStream);
										goto case 38;
									case 38:
										HTTcFNdyZH2754fgnY(fileStream, 134L);
										goto case 59;
									case 51:
										flag = !Ws8B6bYw4huRZClvvi(BWhl99FF18, K98Ek8Ketco48XMuus(object_), object_2, array5);
										num11 = 15;
										if (Ge5NegboUUNgr7ESHr())
										{
											continue;
										}
										goto case 4;
									case 44:
										if (!flag2)
										{
											goto case 54;
										}
										goto case 37;
									case 37:
										num14 = 96;
										goto IL_28cf;
									case 41:
										array4[67] = 0;
										goto case 69;
									case 39:
										flag2 = fxC6Y0t2PYMTnaq9Sh(object_8) != 523;
										num13 = 44;
										goto case 44;
									case 34:
										HTTcFNdyZH2754fgnY(fileStream, num12);
										goto case 21;
									case 28:
										J4iqcbvQvbFtarBLEE(object_, fileStream, 152u, array4);
										num11 = 39;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto case 9;
									case 6:
										array4[38] = 0;
										goto case 71;
									case 1:
										PjidbWnElC6KTttYpx(object_, array4, 0, 128);
										goto case 53;
									default:
										array4[65] = 0;
										goto case 64;
									case 24:
										break;
									case 16:
										goto end_IL_2af9;
									case 15:
										goto end_IL_2b1a;
										IL_28cf:
										int_ = num14;
										num11 = 55;
										if (DfyXmlmmejXUeHeXgX() == null)
										{
											continue;
										}
										goto case 49;
									}
									break;
								}
								continue;
								IL_256b:
								num11 = num13;
								goto IL_29bf;
								continue;
								end_IL_2af9:
								break;
							}
							continue;
							end_IL_2b1a:
							break;
						}
					}
					catch
					{
						int num26 = 0;
						if (Ge5NegboUUNgr7ESHr())
						{
							goto IL_2b37;
						}
						goto IL_2b54;
						IL_2b37:
						while (true)
						{
							switch (num26)
							{
							case 1:
								goto end_IL_2b37;
							}
							flag = true;
							num26 = 1;
							if (Ge5NegboUUNgr7ESHr())
							{
								continue;
							}
							goto IL_2b54;
							continue;
							end_IL_2b37:
							break;
						}
						goto end_IL_2b27;
						IL_2b54:
						num26 = num27;
						goto IL_2b37;
						end_IL_2b27:;
					}
					goto case 15;
				case 15:
					if (flag)
					{
						num = 14;
						goto case 14;
					}
					flag = false;
					return;
				case 14:
					throw new Exception((string?)JEhdp3LWhCVoJ6wCIv(afm5hQX4osAN7hIQka(L2xKeo9hwItlxbhFQI(avy8MoHTEf8exIGo5X(typeof(K1GfMT41V9bS6oPmMyh).TypeHandle).Assembly)), " is tampered."));
				case 3:
					return;
				case 6:
					return;
				}
				object_2 = null;
				num2 = 11;
				if (DfyXmlmmejXUeHeXgX() == null)
				{
					continue;
				}
				goto IL_0066;
				IL_0056:
				num2 = 8;
				if (Ge5NegboUUNgr7ESHr())
				{
					continue;
				}
				goto IL_0066;
				continue;
				end_IL_014f:
				break;
			}
		}
	}

	public static void ub5lJbYbH7(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (eyVlrNYTxD == null)
			{
				lock (Dbclts37pG)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554497)).Assembly.GetManifestResourceStream("NwASntE33b8Wk8EAv1.E0wMl6ocXXqkP1UqaD"));
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
							num3 += GGclldPNO9(num3);
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
						OSI7Ce4TTt6D5rlJwoS oSI7Ce4TTt6D5rlJwoS = new OSI7Ce4TTt6D5rlJwoS(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = oSI7Ce4TTt6D5rlJwoS.MQZsdBct32();
							int value = oSI7Ce4TTt6D5rlJwoS.MQZsdBct32();
							dictionary.Add(key, value);
						}
						oSI7Ce4TTt6D5rlJwoS.jABsiIwHFA();
					}
					eyVlrNYTxD = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = eyVlrNYTxD[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554497)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777236));
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

	private static uint mFOl0k4vVQ(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint GGclldPNO9(uint uint_0)
	{
		return 0u;
	}

	internal static void OaJlsgEwPD()
	{
	}

	[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
	internal static string yx7lVsGYGq(int int_0)
	{
		int num = 46;
		string result = default(string);
		int int_ = default(int);
		int num4 = default(int);
		int num7 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num15 = default(int);
		uint num26 = default(uint);
		int num19 = default(int);
		int num14 = default(int);
		uint num10 = default(uint);
		uint num11 = default(uint);
		byte[] array3 = default(byte[]);
		int num5 = default(int);
		byte[] array7 = default(byte[]);
		byte[] array = default(byte[]);
		int num25 = default(int);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array5 = default(byte[]);
		Stream stream = default(Stream);
		byte[] array4 = default(byte[]);
		OSI7Ce4TTt6D5rlJwoS object_2 = default(OSI7Ce4TTt6D5rlJwoS);
		int num20 = default(int);
		uint num17 = default(uint);
		uint num6 = default(uint);
		int num8 = default(int);
		int num9 = default(int);
		int num21 = default(int);
		uint num22 = default(uint);
		uint num18 = default(uint);
		int num16 = default(int);
		int num13 = default(int);
		uint num12 = default(uint);
		CryptoStream object_ = default(CryptoStream);
		while (true)
		{
			int num2;
			if (fIwlNCqhyS.Length == 0)
			{
				num2 = 45;
				if (!yYfIC3GDdjTSLHW4w6())
				{
					goto IL_008a;
				}
				goto IL_1f69;
			}
			goto IL_2611;
			IL_261e:
			try
			{
				tfTb7SCrYOlJhgxt3w();
				int num3 = 0;
				if (BfhfCrTXSUEnUuCxNx() != null)
				{
					goto IL_2656;
				}
				goto IL_265a;
				IL_265a:
				do
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = (string)AOyndHNO3P0cjmeEfv(ST7Kn58HcDiTmwZX9I(), fIwlNCqhyS, int_0 + 4, int_);
					num3 = 1;
				}
				while (BfhfCrTXSUEnUuCxNx() == null);
				goto IL_2656;
				IL_2656:
				num3 = num4;
				goto IL_265a;
			}
			catch
			{
				if (BfhfCrTXSUEnUuCxNx() != null)
				{
					switch (0)
					{
					}
				}
			}
			break;
			IL_1f69:
			while (true)
			{
				switch (num2)
				{
				case 415:
					num7 = 90;
					num2 = 395;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 88;
				case 88:
					array2[15] = (byte)num7;
					goto case 409;
				case 409:
					array2[15] = 168;
					goto case 178;
				case 178:
					array2[15] = 153;
					goto case 149;
				case 149:
					array2[16] = 52;
					goto case 378;
				case 378:
					array2[16] = 86;
					num2 = 60;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 414:
					num7 = 86;
					num = 116;
					goto case 116;
				case 116:
					array2[23] = (byte)num7;
					goto case 232;
				case 232:
					array2[23] = 136;
					num = 323;
					goto case 323;
				case 323:
					num7 = 197;
					num2 = 95;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 413:
					array6[num15 + 3] = (byte)((num26 & 0xFF000000u) >> 24);
					goto case 271;
				case 271:
				case 350:
					num19++;
					num2 = 359;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 412:
					array2[3] = (byte)num7;
					goto case 198;
				case 198:
					array2[3] = 157;
					goto case 103;
				case 103:
					num7 = 87;
					goto case 19;
				case 19:
					array2[3] = (byte)num7;
					num2 = 202;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 411:
					if (num14 > 0)
					{
						num2 = 279;
						if (yYfIC3GDdjTSLHW4w6())
						{
							continue;
						}
						goto IL_008a;
					}
					goto case 61;
				case 61:
					num26 = num10 ^ num11;
					num2 = 240;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 309;
				case 309:
					array6[num15] = (byte)(num26 & 0xFFu);
					num = 138;
					goto case 138;
				case 138:
					array6[num15 + 1] = (byte)((num26 & 0xFF00) >> 8);
					goto case 17;
				case 17:
					array6[num15 + 2] = (byte)((num26 & 0xFF0000) >> 16);
					goto case 413;
				case 410:
					array2[14] = (byte)num7;
					num = 74;
					goto case 74;
				case 74:
					num7 = 226;
					num2 = 324;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 408:
					array2[8] = 51;
					goto case 161;
				case 161:
					array2[8] = 54;
					num2 = 208;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 41;
				case 41:
					num7 = 76;
					num = 398;
					goto case 398;
				case 398:
					array2[26] = (byte)num7;
					num2 = 188;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 407:
					array3[15] = (byte)num5;
					num2 = 190;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 204;
				case 204:
					array7 = array3;
					goto case 166;
				case 166:
					gZSsqQ3JdilYT7YY3b(array7);
					num = 35;
					goto case 35;
				case 35:
					array = (byte[])csSchJylibVUl0x8O6(ugNbdI6hqJtsTVnOfO(q7HlQ5sSbB));
					num2 = 11;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 406:
					num7 = 232;
					goto case 113;
				case 113:
					array2[18] = (byte)num7;
					num = 345;
					goto case 345;
				case 345:
					num7 = 164;
					goto case 86;
				case 86:
					array2[19] = (byte)num7;
					goto case 210;
				case 210:
					array2[19] = 150;
					goto case 339;
				case 339:
					num7 = 196;
					num = 312;
					goto case 312;
				case 312:
					array2[19] = (byte)num7;
					num2 = 296;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 138;
				case 405:
					array2[24] = 184;
					num2 = 277;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 74;
				case 404:
					array2[12] = (byte)num7;
					goto case 214;
				case 214:
					num7 = 165;
					num2 = 203;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 403:
					array2[29] = (byte)num7;
					num2 = 184;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 131;
				case 131:
					num5 = 205;
					goto case 366;
				case 366:
					array3[11] = (byte)num5;
					goto case 318;
				case 318:
					num5 = 108;
					num = 212;
					goto case 212;
				case 212:
					array3[12] = (byte)num5;
					goto case 304;
				case 304:
					array3[12] = 86;
					num2 = 254;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 119;
				case 119:
					array7[1] = array[0];
					goto case 219;
				case 219:
					array7[3] = array[1];
					goto case 364;
				case 364:
					array7[5] = array[2];
					goto case 54;
				case 54:
					array7[7] = array[3];
					goto case 247;
				case 247:
					array7[9] = array[4];
					goto case 71;
				case 71:
					array7[11] = array[5];
					goto case 143;
				case 143:
					array7[13] = array[6];
					num2 = 227;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 258;
				case 258:
					array7[15] = array[7];
					goto case 300;
				case 300:
					num25 = 0;
					goto case 234;
				case 234:
				case 251:
					if (num25 >= array7.Length)
					{
						goto case 197;
					}
					goto case 31;
				case 197:
					if (int_0 == -1)
					{
						goto case 295;
					}
					goto case 58;
				case 295:
					object_3 = (SymmetricAlgorithm)EsowGyVuOBL1NvOCgZ();
					goto case 87;
				case 87:
					Kbfo8j2lyFgb3UJRkq(object_3, CipherMode.CBC);
					num = 256;
					goto case 256;
				case 256:
					transform = (ICryptoTransform)rPaBETOloFyr8TpLNo(object_3, array5, array7);
					goto case 246;
				case 246:
					stream = (Stream)yXvvqWYpmDNmkdUped();
					num2 = 0;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 58:
					num14 = array4.Length % 4;
					num2 = 270;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 31:
					array5[num25] = (byte)(array5[num25] ^ array7[num25]);
					num2 = 388;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 402:
					array2[20] = 229;
					goto case 396;
				case 396:
					array2[21] = 85;
					num2 = 326;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 401:
					array2[15] = 156;
					num2 = 205;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 400:
					array2[20] = 73;
					goto case 146;
				case 146:
					num7 = 168;
					goto case 106;
				case 106:
					array2[20] = (byte)num7;
					goto case 301;
				case 301:
					array2[20] = 112;
					num2 = 402;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 399:
					num7 = 156;
					num2 = 410;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 397:
					num5 = 32;
					num2 = 292;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 325;
				case 325:
					array3[0] = (byte)num5;
					goto case 65;
				case 65:
					array3[1] = 99;
					goto case 63;
				case 63:
					num5 = 163;
					num2 = 162;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 74;
				case 395:
					array2[24] = (byte)num7;
					num2 = 284;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 394:
					array2[22] = (byte)num7;
					num2 = 34;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 30;
				case 30:
					array2[12] = 168;
					goto case 147;
				case 147:
					num7 = 171;
					num2 = 125;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 404;
				case 393:
					IAKKNmdgxvp0R9ePBI(G6L0WSIsXjnYUXl0kp(object_2), 0L);
					num2 = 3;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 221;
				case 221:
					array4 = (byte[])xo6DvVADnLdQT7xFti(object_2, (int)o538DM9TkPpfKBPEYC(G6L0WSIsXjnYUXl0kp(object_2)));
					num2 = 11;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 25;
				case 25:
					AkdNsUwWdm34MshksE(object_2);
					num = 302;
					goto case 302;
				case 302:
					array2 = new byte[32];
					goto case 353;
				case 353:
					num7 = 103;
					goto case 55;
				case 55:
					array2[0] = (byte)num7;
					goto case 336;
				case 336:
					array2[0] = 116;
					num2 = 57;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 392:
					array2[28] = 201;
					goto case 322;
				case 322:
					array2[29] = 146;
					num2 = 351;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 391:
					array3[6] = (byte)num5;
					num = 199;
					goto case 199;
				case 199:
					array3[6] = 88;
					num = 124;
					goto case 124;
				case 124:
					num5 = 200;
					goto case 8;
				case 8:
					array3[6] = (byte)num5;
					goto case 38;
				case 38:
					array3[7] = 130;
					goto case 151;
				case 151:
					num5 = 128;
					num = 135;
					goto case 135;
				case 135:
					array3[7] = (byte)num5;
					goto case 167;
				case 167:
					array3[7] = 249;
					num2 = 360;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 390:
					num7 = 99;
					num2 = 92;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 241;
				case 241:
					array2[1] = (byte)num7;
					goto case 273;
				case 273:
					array2[1] = 163;
					num2 = 281;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 84;
				case 84:
					array3[12] = (byte)num5;
					goto case 122;
				case 122:
					num5 = 104;
					num2 = 125;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 389:
					array2[7] = 65;
					goto case 367;
				case 367:
					num7 = 103;
					goto case 10;
				case 10:
					array2[8] = (byte)num7;
					goto case 408;
				case 388:
					num25++;
					goto case 234;
				case 387:
					array3[9] = (byte)num5;
					goto case 183;
				case 183:
					num5 = 120;
					goto case 130;
				case 130:
					array3[9] = (byte)num5;
					goto case 223;
				case 223:
					array3[9] = 213;
					goto case 231;
				case 231:
					num5 = 129;
					num = 327;
					goto case 327;
				case 327:
					array3[10] = (byte)num5;
					goto case 244;
				case 244:
					array3[10] = 78;
					goto case 237;
				case 237:
					array3[10] = 184;
					num = 90;
					goto case 90;
				case 90:
					num5 = 129;
					goto case 280;
				case 280:
					array3[11] = (byte)num5;
					goto case 315;
				case 315:
					array3[11] = 49;
					goto case 239;
				case 239:
					num5 = 55;
					num2 = 168;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 386:
					array3[12] = (byte)num5;
					num2 = 180;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 81;
				case 81:
					num7 = 122;
					goto case 349;
				case 349:
					array2[2] = (byte)num7;
					num2 = 305;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 148;
				case 148:
					array3[3] = 160;
					num2 = 307;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 385:
					num18 = (uint)(num20 * 4);
					goto case 289;
				case 289:
					num17 = (uint)((array5[num18 + 3] << 24) | (array5[num18 + 2] << 16) | (array5[num18 + 1] << 8) | array5[num18]);
					goto case 91;
				case 91:
					num6 = 255u;
					goto case 56;
				case 56:
					num8 = 0;
					num = 285;
					goto case 285;
				case 285:
					if (num19 == num9 - 1)
					{
						num2 = 57;
						if (!yYfIC3GDdjTSLHW4w6())
						{
							continue;
						}
						goto case 92;
					}
					goto case 187;
				case 92:
					if (num14 > 0)
					{
						goto case 269;
					}
					goto case 187;
				case 269:
					num11 = 0u;
					goto case 355;
				case 355:
					num10 += num17;
					goto case 70;
				case 70:
					num21 = 0;
					goto case 245;
				case 156:
					if (num21 <= 0)
					{
						goto case 175;
					}
					goto case 261;
				case 175:
					num11 |= array4[^(1 + num21)];
					num2 = 46;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 100;
				case 100:
					num21++;
					goto case 245;
				case 245:
				case 272:
					if (num21 < num14)
					{
						goto case 156;
					}
					goto case 249;
				case 261:
					num11 <<= 8;
					num2 = 175;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 187:
					num10 += num17;
					goto case 375;
				case 375:
					num18 = (uint)num15;
					num = 344;
					goto case 344;
				case 344:
					num11 = (uint)((array4[num18 + 3] << 24) | (array4[num18 + 2] << 16) | (array4[num18 + 1] << 8) | array4[num18]);
					goto case 249;
				case 249:
				case 282:
					num22 = num10;
					goto case 263;
				case 263:
					num10 = 0u;
					goto case 47;
				case 47:
				{
					uint num23 = num22;
					uint num24 = num22;
					num24 ^= num24 << 16;
					num24 += 3025070325u;
					num24 ^= num24 << 9;
					num24 += 2057092692;
					num24 ^= num24 >> 21;
					num24 += 1971097035;
					num24 = 3396848076u + num24;
					num22 = num23 + (uint)(double)num24;
					num2 = 105;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 169;
				}
				case 169:
					num10 = num22;
					goto case 236;
				case 236:
					if (num19 == num9 - 1)
					{
						goto case 411;
					}
					goto case 61;
				case 384:
					array2[13] = (byte)num7;
					num2 = 328;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 383:
					num18 = 0u;
					goto case 37;
				case 37:
					num19 = 0;
					goto case 359;
				case 359:
				case 382:
					if (num19 < num9)
					{
						goto case 152;
					}
					num = 132;
					goto case 132;
				case 152:
					num20 = num19 % num16;
					goto case 40;
				case 40:
					num15 = num19 * 4;
					goto case 385;
				case 381:
					array2[20] = (byte)num7;
					num2 = 382;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 400;
				case 380:
					num5 = 7;
					num = 338;
					goto case 338;
				case 338:
					array3[4] = (byte)num5;
					goto case 275;
				case 275:
					num5 = 102;
					goto case 362;
				case 362:
					array3[5] = (byte)num5;
					num2 = 165;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 379:
					array3 = new byte[16];
					goto case 2;
				case 2:
					num5 = 103;
					goto case 209;
				case 209:
					array3[0] = (byte)num5;
					num2 = 50;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 347;
				case 347:
					array3[0] = 116;
					goto case 337;
				case 337:
					num5 = 172;
					goto case 299;
				case 299:
					array3[0] = (byte)num5;
					num2 = 397;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 377:
					array2[2] = 100;
					num2 = 10;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 102;
				case 102:
					num7 = 154;
					goto case 412;
				case 376:
					array2[25] = 110;
					goto case 369;
				case 369:
					num7 = 119;
					num = 283;
					goto case 283;
				case 283:
					array2[25] = (byte)num7;
					goto case 144;
				case 144:
					array2[25] = 185;
					num2 = 15;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 41;
				case 374:
					array2[28] = 128;
					goto case 136;
				case 136:
					array2[28] = 88;
					num2 = 290;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 36;
				case 36:
					array2[18] = 49;
					goto case 201;
				case 201:
					array2[18] = 51;
					goto case 406;
				case 373:
					array3[1] = (byte)num5;
					num = 16;
					goto case 16;
				case 16:
					num5 = 92;
					num2 = 233;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 218;
				case 218:
					array2[21] = 203;
					num = 96;
					goto case 96;
				case 96:
					num7 = 112;
					goto case 286;
				case 286:
					array2[22] = (byte)num7;
					num = 352;
					goto case 352;
				case 352:
					num7 = 92;
					num2 = 394;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 372:
					array2[26] = (byte)num7;
					num2 = 153;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 371:
					num5 = 159;
					num = 62;
					goto case 62;
				case 62:
					array3[14] = (byte)num5;
					goto case 357;
				case 357:
					array3[14] = 147;
					num2 = 370;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 370:
					array3[14] = 98;
					num = 195;
					goto case 195;
				case 195:
					array3[14] = 132;
					num2 = 3;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 368:
					num5 = 113;
					goto case 358;
				case 358:
					array3[2] = (byte)num5;
					goto case 15;
				case 15:
					array3[2] = 83;
					goto case 68;
				case 68:
					array3[3] = 154;
					goto case 185;
				case 185:
					array3[3] = 168;
					goto case 148;
				case 365:
					array2[0] = (byte)num7;
					num2 = 390;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 332;
				case 332:
					array2[20] = 108;
					goto case 213;
				case 213:
					num7 = 98;
					goto case 381;
				case 363:
					array3[13] = (byte)num5;
					num = 83;
					goto case 83;
				case 83:
					num5 = 156;
					num2 = 93;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 361:
					array3[4] = 141;
					goto case 186;
				case 186:
					array3[4] = 144;
					num2 = 380;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 360:
					array3[8] = 54;
					num2 = 1;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 1;
				case 1:
					array3[8] = 140;
					goto case 155;
				case 155:
					num5 = 116;
					num2 = 257;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 356:
					array3[13] = 15;
					goto case 371;
				case 354:
					array2[1] = 92;
					goto case 101;
				case 101:
					array2[1] = 126;
					goto case 227;
				case 227:
					num7 = 108;
					goto case 189;
				case 189:
					array2[2] = (byte)num7;
					num2 = 81;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 351:
					num7 = 113;
					num2 = 403;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 348:
					array2[18] = (byte)num7;
					goto case 36;
				case 346:
					num7 = 124;
					goto case 88;
				case 343:
					num16 = array5.Length / 4;
					goto case 28;
				case 28:
					num10 = 0u;
					goto case 216;
				case 216:
					num17 = 0u;
					goto case 240;
				case 240:
					num11 = 0u;
					goto case 75;
				case 75:
					if (num14 <= 0)
					{
						goto case 383;
					}
					num = 171;
					goto case 171;
				case 171:
					num9++;
					num2 = 171;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 383;
				case 342:
					array2[27] = 93;
					goto case 111;
				case 111:
					array2[27] = 174;
					goto case 306;
				case 306:
					num7 = 130;
					goto case 27;
				case 27:
					array2[27] = (byte)num7;
					num2 = 88;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 94;
				case 94:
					array2[27] = 231;
					goto case 374;
				case 341:
					array2[10] = 90;
					num2 = 13;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 340:
					num7 = 134;
					goto case 287;
				case 287:
					array2[9] = (byte)num7;
					num2 = 66;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 331;
				case 331:
					array2[9] = 82;
					goto case 193;
				case 193:
					array2[9] = 179;
					goto case 230;
				case 230:
					array2[9] = 176;
					num2 = 341;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 335:
					array3[13] = 226;
					num2 = 356;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 334:
					num7 = 119;
					goto case 348;
				case 333:
					num7 = 129;
					goto case 365;
				case 330:
					num5 = 82;
					goto case 196;
				case 196:
					array3[1] = (byte)num5;
					goto case 80;
				case 80:
					array3[2] = 67;
					goto case 6;
				case 6:
					array3[2] = 180;
					goto case 368;
				case 329:
					num5 = 129;
					num2 = 391;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 328:
					array2[13] = 31;
					num2 = 399;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 326:
					num7 = 101;
					num2 = 252;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 324:
					array2[14] = (byte)num7;
					goto case 129;
				case 129:
					array2[14] = 149;
					goto case 43;
				case 43:
					array2[14] = 57;
					goto case 401;
				case 321:
					array2[5] = 41;
					goto case 79;
				case 79:
					array2[6] = 98;
					goto case 250;
				case 250:
					num7 = 159;
					goto case 211;
				case 211:
					array2[6] = (byte)num7;
					goto case 200;
				case 200:
					num7 = 103;
					num2 = 23;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 320:
					array2[25] = 163;
					num2 = 376;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 97;
				case 97:
					num5 = 159;
					goto case 42;
				case 42:
					array3[5] = (byte)num5;
					num2 = 49;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 319:
					num7 = 138;
					goto case 9;
				case 9:
					array2[17] = (byte)num7;
					goto case 72;
				case 72:
					array2[17] = 86;
					goto case 12;
				case 12:
					num7 = 98;
					goto case 99;
				case 99:
					array2[17] = (byte)num7;
					goto case 163;
				case 163:
					array2[17] = 126;
					goto case 104;
				case 104:
					array2[17] = 160;
					num2 = 137;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 115;
				case 115:
					num7 = 138;
					num2 = 137;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 225;
				case 225:
					array2[26] = (byte)num7;
					goto case 235;
				case 235:
					array2[26] = 77;
					num2 = 91;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 217;
				case 217:
					array2[27] = 89;
					num2 = 313;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 316:
					num13++;
					num = 14;
					goto case 14;
				case 145:
					if (num13 > 0)
					{
						num2 = 4;
						if (yYfIC3GDdjTSLHW4w6())
						{
							continue;
						}
						goto IL_008a;
					}
					goto case 76;
				case 76:
					array6[num15 + num13] = (byte)((num12 & num6) >> num8);
					goto case 316;
				case 14:
				case 176:
					if (num13 >= num14)
					{
						num2 = 271;
						if (BfhfCrTXSUEnUuCxNx() == null)
						{
							continue;
						}
						goto case 221;
					}
					goto case 145;
				case 314:
					array3[9] = 13;
					goto case 107;
				case 107:
					num5 = 154;
					num2 = 387;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 313:
					num7 = 129;
					goto case 260;
				case 260:
					array2[27] = (byte)num7;
					goto case 342;
				case 311:
					array2[12] = 116;
					goto case 310;
				case 310:
					array2[12] = 231;
					num2 = 30;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 308:
					array2[19] = (byte)num7;
					goto case 332;
				case 307:
					num5 = 87;
					num2 = 297;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 305:
					num7 = 92;
					goto case 85;
				case 85:
					array2[2] = (byte)num7;
					goto case 7;
				case 7:
					num7 = 180;
					goto case 121;
				case 121:
					array2[2] = (byte)num7;
					goto case 377;
				case 303:
					array2[4] = (byte)num7;
					goto case 117;
				case 117:
					array2[4] = 91;
					goto case 39;
				case 39:
					num7 = 87;
					goto case 220;
				case 220:
					array2[4] = (byte)num7;
					num2 = 291;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 298:
					array2[11] = 149;
					goto case 134;
				case 134:
					num7 = 108;
					goto case 18;
				case 18:
					array2[11] = (byte)num7;
					goto case 160;
				case 160:
					num7 = 129;
					num2 = 164;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 297:
					array3[3] = (byte)num5;
					num2 = 69;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 296:
					array2[19] = 180;
					goto case 259;
				case 259:
					num7 = 170;
					num2 = 308;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 294:
					array2[7] = 81;
					goto case 182;
				case 182:
					array2[7] = 138;
					num2 = 89;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 293:
					array2[23] = 166;
					goto case 66;
				case 66:
					array2[23] = 33;
					goto case 414;
				case 292:
					num7 = 128;
					goto case 207;
				case 207:
					array2[7] = (byte)num7;
					num2 = 294;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 291:
					array2[4] = 161;
					num2 = 159;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 290:
					num7 = 33;
					goto case 24;
				case 24:
					array2[28] = (byte)num7;
					num2 = 228;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 288:
					num7 = 118;
					num2 = 50;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 284:
					array2[25] = 39;
					goto case 140;
				case 140:
					num7 = 78;
					num2 = 224;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 281:
					array2[1] = 148;
					goto case 354;
				case 279:
					num12 = num10 ^ num11;
					goto case 5;
				case 5:
					num13 = 0;
					goto case 14;
				case 278:
					array2[6] = 206;
					goto case 292;
				case 277:
					array2[24] = 91;
					num2 = 415;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 276:
					num7 = 172;
					num2 = 274;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 246;
				case 274:
					array2[24] = (byte)num7;
					num2 = 21;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 270:
					num9 = array4.Length / 4;
					num = 267;
					goto case 267;
				case 267:
					array6 = new byte[array4.Length];
					num2 = 24;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 343;
				case 268:
					array5 = array2;
					num2 = 367;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 379;
				case 266:
					qU1HjnDPXIyitu4SHK(object_, array4, 0, array4.Length);
					num2 = 142;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 17;
				case 265:
					array2[31] = (byte)num7;
					goto case 51;
				case 51:
					num7 = 77;
					num2 = 192;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 264:
					array4 = fIwlNCqhyS;
					num = 58;
					goto case 58;
				case 262:
					array3[1] = 61;
					num2 = 16;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 330;
				case 257:
					array3[8] = (byte)num5;
					goto case 133;
				case 133:
					num5 = 114;
					num2 = 109;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 255:
					num7 = 166;
					num2 = 150;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 254:
					num5 = 157;
					goto case 32;
				case 32:
					array3[12] = (byte)num5;
					goto case 248;
				case 248:
					num5 = 125;
					goto case 386;
				case 253:
					num5 = 148;
					goto case 373;
				case 252:
					array2[21] = (byte)num7;
					goto case 48;
				case 48:
					num7 = 43;
					goto case 229;
				case 229:
					array2[21] = (byte)num7;
					goto case 218;
				case 243:
					Gb4gCnoX1B502Xby52(stream);
					num2 = 69;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 114;
				case 114:
					Gb4gCnoX1B502Xby52(object_);
					goto case 264;
				case 238:
					num7 = 116;
					goto case 384;
				case 233:
					array3[1] = (byte)num5;
					goto case 262;
				case 228:
					num7 = 120;
					goto case 120;
				case 120:
					array2[28] = (byte)num7;
					goto case 392;
				case 226:
					array3[14] = (byte)num5;
					goto case 105;
				case 105:
					num5 = 96;
					goto case 206;
				case 206:
					array3[15] = (byte)num5;
					num = 215;
					goto case 215;
				case 215:
					array3[15] = 90;
					num2 = 16;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 98;
				case 98:
					num5 = 217;
					goto case 407;
				case 224:
					array2[25] = (byte)num7;
					num2 = 110;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 320;
				case 222:
					array3[6] = 150;
					num2 = 329;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 329;
				case 208:
					array2[8] = 140;
					num2 = 45;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 108;
				case 108:
					num7 = 54;
					num = 190;
					goto case 190;
				case 190:
					array2[8] = (byte)num7;
					num2 = 288;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 205:
					array2[15] = 101;
					goto case 346;
				case 203:
					array2[13] = (byte)num7;
					goto case 238;
				case 202:
					num7 = 201;
					num2 = 303;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 74;
				case 194:
					fIwlNCqhyS = (byte[])gcUW51uAXsPJKa9UfV(stream);
					goto case 243;
				case 192:
					array2[31] = (byte)num7;
					num2 = 154;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 191:
					array2[29] = (byte)num7;
					goto case 73;
				case 73:
					num7 = 179;
					goto case 177;
				case 177:
					array2[30] = (byte)num7;
					goto case 20;
				case 20:
					array2[30] = 202;
					num2 = 255;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 188:
					num7 = 117;
					goto case 372;
				case 184:
					num7 = 36;
					goto case 191;
				case 181:
					num5 = 128;
					num = 123;
					goto case 123;
				case 123:
					array3[13] = (byte)num5;
					goto case 179;
				case 179:
					num5 = 150;
					num2 = 250;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 363;
				case 180:
					num5 = 195;
					num = 84;
					goto case 84;
				case 174:
					array2[22] = 244;
					goto case 293;
				case 173:
					array3[5] = 103;
					num2 = 128;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 66;
				case 172:
					array2[31] = (byte)num7;
					goto case 268;
				case 170:
					array2[10] = 23;
					goto case 298;
				case 168:
					array3[11] = (byte)num5;
					num = 131;
					goto case 131;
				case 165:
					array3[5] = 152;
					goto case 173;
				case 164:
					array2[11] = (byte)num7;
					goto case 311;
				case 162:
					array3[1] = (byte)num5;
					goto case 253;
				case 159:
					num7 = 146;
					goto case 139;
				case 139:
					array2[4] = (byte)num7;
					num2 = 110;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 158:
					array3[8] = 248;
					num2 = 67;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 314;
				case 157:
					array3[3] = (byte)num5;
					num2 = 64;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 154:
					num7 = 89;
					goto case 78;
				case 78:
					array2[31] = (byte)num7;
					num2 = 26;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 153:
					array2[26] = 160;
					goto case 115;
				case 150:
					array2[30] = (byte)num7;
					num2 = 52;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 142:
					aDZDZybm7wqn2TOKjQ(object_);
					goto case 194;
				case 141:
					array2[9] = 127;
					num = 340;
					goto case 340;
				case 137:
					array2[17] = 192;
					goto case 334;
				case 128:
					array3[5] = 128;
					goto case 97;
				case 127:
					if (array.Length > 0)
					{
						goto case 119;
					}
					goto case 300;
				case 126:
					array2[9] = 90;
					goto case 141;
				case 125:
					array3[12] = (byte)num5;
					goto case 181;
				case 118:
					array2[5] = 155;
					num2 = 139;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 321;
				case 110:
					array2[5] = 84;
					num2 = 3;
					if (BfhfCrTXSUEnUuCxNx() != null)
					{
						continue;
					}
					goto case 118;
				case 109:
					array3[8] = (byte)num5;
					num2 = 158;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 95:
					array2[23] = (byte)num7;
					goto case 29;
				case 29:
					num7 = 85;
					num = 59;
					goto case 59;
				case 59:
					array2[24] = (byte)num7;
					goto case 276;
				case 93:
					array3[13] = (byte)num5;
					goto case 335;
				case 89:
					array2[7] = 111;
					num2 = 33;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 5;
				case 82:
					num7 = 102;
					goto case 22;
				case 22:
					array2[10] = (byte)num7;
					goto case 170;
				case 77:
					num8 += 8;
					num2 = 76;
					if (yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto IL_008a;
				case 69:
					array3[3] = 130;
					goto case 67;
				case 67:
					num5 = 207;
					num = 157;
					goto case 157;
				case 64:
					num5 = 102;
					goto case 44;
				case 44:
					array3[4] = (byte)num5;
					goto case 361;
				case 60:
					array2[16] = 109;
					num = 319;
					goto case 319;
				case 57:
					num7 = 172;
					goto case 53;
				case 53:
					array2[0] = (byte)num7;
					num2 = 19;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 333;
				case 52:
					num7 = 146;
					goto case 265;
				case 50:
					array2[8] = (byte)num7;
					goto case 126;
				case 49:
					array3[5] = 85;
					num2 = 222;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				case 45:
					object_2 = new OSI7Ce4TTt6D5rlJwoS((Stream)AAcjOtkP0wFnp7PdMi(q7HlQ5sSbB, "pRNrCet7LDwCx6Ia93.E5olyEijxn3uyctmfa"));
					num2 = 266;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 393;
				case 34:
					array2[22] = 86;
					goto case 174;
				case 33:
					array2[7] = 122;
					goto case 389;
				case 26:
					num7 = 253;
					goto case 172;
				case 23:
					array2[6] = (byte)num7;
					num2 = 41;
					if (!yYfIC3GDdjTSLHW4w6())
					{
						continue;
					}
					goto case 278;
				case 21:
					array2[24] = 158;
					goto case 405;
				case 13:
					array2[10] = 86;
					num = 82;
					goto case 82;
				case 11:
					if (array != null)
					{
						num2 = 127;
						if (BfhfCrTXSUEnUuCxNx() == null)
						{
							continue;
						}
						goto IL_008a;
					}
					goto case 300;
				case 4:
					num6 <<= 8;
					num = 77;
					goto case 77;
				case 3:
					num5 = 192;
					num2 = 226;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto IL_008a;
				default:
					object_ = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 266;
					if (BfhfCrTXSUEnUuCxNx() == null)
					{
						continue;
					}
					goto case 136;
				case 46:
					break;
				case 132:
					fIwlNCqhyS = array6;
					goto IL_2611;
				case 317:
					goto IL_2611;
				case 112:
					goto IL_261e;
				case 242:
					goto end_IL_25f3;
				}
				break;
			}
			continue;
			IL_008a:
			num2 = num;
			goto IL_1f69;
			IL_2611:
			int_ = fH2ux8sR0wUrb0fQsh(fIwlNCqhyS, int_0);
			goto IL_261e;
			continue;
			end_IL_25f3:
			break;
		}
		return "";
	}

	[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
	internal static string xLyl29aUxI(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Pd1lylkgUo()
	{
		return 5;
	}

	private static void gaUlvHQoxI()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate xXPlakBeEx(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777310)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777250)),
			Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777257))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object Usvl7Eta12(object object_0)
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

	private static IntPtr tnmldNFekj(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (jNWse56bLJ == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			jNWse56bLJ = (ReXaIE4MOL2XQ8GfMtd)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554506)));
		}
		return jNWse56bLJ(intptr_0, string_0, uint_0);
	}

	private static IntPtr oJVlirfASU(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (k7ms0Re1bp == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			k7ms0Re1bp = (Bbt6Io4EciEQWx65IhG)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554507)));
		}
		return k7ms0Re1bp(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int ws1lnhBat3(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (Yiksl9kbGh == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			Yiksl9kbGh = (V2LEH54bCk3dOyShsoa)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554508)));
		}
		return Yiksl9kbGh(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int dfulq8A8jQ(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (ONbss7mAMx == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			ONbss7mAMx = (K5U4t74Aotu7K7mG3k7)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554509)));
		}
		return ONbss7mAMx(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr mNsljvhAtZ(uint uint_0, int int_0, uint uint_1)
	{
		if (efmsVfD2Wc == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			efmsVfD2Wc = (SoRD4O4Q0NOdj1Y87oR)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554510)));
		}
		return efmsVfD2Wc(uint_0, int_0, uint_1);
	}

	private static int humlwPo4pM(IntPtr intptr_0)
	{
		if (ohws2ug2pO == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			ohws2ug2pO = (kflAmm4gBk19YrBFyfr)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554511)));
		}
		return ohws2ug2pO(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (nMusyryMht == IntPtr.Zero)
		{
			nMusyryMht = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return nMusyryMht;
	}

	[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
	private static byte[] iG7l169r6K(string string_0)
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

	internal static Stream Sytl8jF66E()
	{
		return new MemoryStream();
	}

	internal static byte[] vGglkmJJcp(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[wdKqG24UlkmHpKqGPSb(typeof(wdKqG24UlkmHpKqGPSb.LjVB5g4xnAQxNxQsH2R<object>[]))]
	private static byte[] IILlU4ITBE(byte[] byte_0)
	{
		Stream stream = Sytl8jF66E();
		SymmetricAlgorithm symmetricAlgorithm = Hco0mDt989();
		symmetricAlgorithm.Key = new byte[32]
		{
			210, 175, 65, 30, 142, 19, 113, 16, 248, 153,
			70, 66, 178, 116, 241, 165, 2, 35, 192, 42,
			37, 94, 64, 49, 42, 65, 136, 65, 60, 50,
			18, 82
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			249, 173, 138, 116, 197, 165, 183, 130, 238, 90,
			111, 90, 119, 78, 244, 163
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = vGglkmJJcp(stream);
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		return result;
	}

	private byte[] GCilxF8uNY()
	{
		return null;
	}

	private byte[] hc9lZNOFfL()
	{
		return null;
	}

	private byte[] VWIlFqlZmJ()
	{
		return null;
	}

	private byte[] MD0lBOJ8jp()
	{
		return null;
	}

	private byte[] Br2lOwMAWp()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] dOalGk29GN()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] f4ilTSNuGx()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] b4alMQofrX()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] IKFlEletxB()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] hX0lbbR909()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object AAcjOtkP0wFnp7PdMi(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object G6L0WSIsXjnYUXl0kp(object object_0)
	{
		return ((OSI7Ce4TTt6D5rlJwoS)object_0).KDikMXewCI();
	}

	internal static void IAKKNmdgxvp0R9ePBI(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long o538DM9TkPpfKBPEYC(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object xo6DvVADnLdQT7xFti(object object_0, int int_0)
	{
		return ((OSI7Ce4TTt6D5rlJwoS)object_0).PLMsW8yUiH(int_0);
	}

	internal static void AkdNsUwWdm34MshksE(object object_0)
	{
		((OSI7Ce4TTt6D5rlJwoS)object_0).jABsiIwHFA();
	}

	internal static void gZSsqQ3JdilYT7YY3b(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object ugNbdI6hqJtsTVnOfO(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object csSchJylibVUl0x8O6(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object EsowGyVuOBL1NvOCgZ()
	{
		return Hco0mDt989();
	}

	internal static void Kbfo8j2lyFgb3UJRkq(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object rPaBETOloFyr8TpLNo(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object yXvvqWYpmDNmkdUped()
	{
		return Sytl8jF66E();
	}

	internal static void qU1HjnDPXIyitu4SHK(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void aDZDZybm7wqn2TOKjQ(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object gcUW51uAXsPJKa9UfV(object object_0)
	{
		return vGglkmJJcp((Stream)object_0);
	}

	internal static void Gb4gCnoX1B502Xby52(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int fH2ux8sR0wUrb0fQsh(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void tfTb7SCrYOlJhgxt3w()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
	}

	internal static object ST7Kn58HcDiTmwZX9I()
	{
		return Encoding.Unicode;
	}

	internal static object AOyndHNO3P0cjmeEfv(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool yYfIC3GDdjTSLHW4w6()
	{
		return (object)null == null;
	}

	internal static object BfhfCrTXSUEnUuCxNx()
	{
		return null;
	}

	internal static void MPdsv0PKZN23xhVqNq()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
	}

	internal static void fPYpgUyTPiw6ncn0fk(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type avy8MoHTEf8exIGo5X(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object pWnlJh1UbKRv66jv7G(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int YI5U7x4omhHh2ZYaBh(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object ujAYB4TrDcBWalkmpj()
	{
		return SHA1.Create();
	}

	internal static object xxNPB3esoamD0OeiwR(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool xt4wUwWcmvM4vx5YuH(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object WArdcg3wkTT33VLrj4(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object nNqbubqcE7RZxXSRBg(object object_0)
	{
		return ((OSI7Ce4TTt6D5rlJwoS)object_0).KDikMXewCI();
	}

	internal static void HTTcFNdyZH2754fgnY(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long yWB4wCrQYnKLJqEeOa(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object dFPORSpbGs1pCpdXge(object object_0, int int_0)
	{
		return ((OSI7Ce4TTt6D5rlJwoS)object_0).PLMsW8yUiH(int_0);
	}

	internal static object t8mi287Nty3QuIwIEf()
	{
		return Hco0mDt989();
	}

	internal static void zy8eiIougXcJFk1YZq(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object MrAYaZf30mhAjtMeYH(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object woheGHSqhmDSZ2a8Xc()
	{
		return Sytl8jF66E();
	}

	internal static void f4ZIMkiwgusRvWbVtL(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void hI7clncIijtHAM0Z1X(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object Y1Z5IhMviXPCbXa36M()
	{
		return Encoding.UTF8;
	}

	internal static object TDvpKV54lldnIrhntE(object object_0)
	{
		return vGglkmJJcp((Stream)object_0);
	}

	internal static object m7ejl0BJPcbLvcX1Cy(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void DWT2WK22rB324vmFfZ(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void FmWVkEa5Vtnoa2BefV(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void WaFAQ7J3YtmsLv5kxP(object object_0)
	{
		((OSI7Ce4TTt6D5rlJwoS)object_0).jABsiIwHFA();
	}

	internal static void J4iqcbvQvbFtarBLEE(object object_0, object object_1, uint uint_0, object object_2)
	{
		ucX0DcaoTi((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort fxC6Y0t2PYMTnaq9Sh(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int oojHpNsWGwUKVWMTIx(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void PjidbWnElC6KTttYpx(object object_0, object object_1, int int_0, int int_1)
	{
		y920zn8v4t((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long PAQcfUDfw4PEnk995c(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint tpuKd6jyVZXQb2SSPZ(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint wUdA3RGX31EO7vajhC(uint uint_0, int int_0, long long_0, object object_0)
	{
		return EcplY6ZW2L(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long lUK67eVbi7C3aTwhEo(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object MDvfx8ZiRIEwYFE4yp(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object hBmBkJu8oX4Zhey1eM(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void wEY9jmlAJpQOWU44Tm(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object K98Ek8Ketco48XMuus(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool Ws8B6bYw4huRZClvvi(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object L2xKeo9hwItlxbhFQI(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object afm5hQX4osAN7hIQka(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object JEhdp3LWhCVoJ6wCIv(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool Ge5NegboUUNgr7ESHr()
	{
		return (object)null == null;
	}

	internal static object DfyXmlmmejXUeHeXgX()
	{
		return null;
	}
}
