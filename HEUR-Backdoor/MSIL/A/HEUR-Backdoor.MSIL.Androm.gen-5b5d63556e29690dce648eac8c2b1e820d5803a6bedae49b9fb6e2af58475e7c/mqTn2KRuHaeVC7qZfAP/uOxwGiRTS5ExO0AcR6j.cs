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
using NhGuxCR4JrLw4OnYlkG;
using SRo1MyRyNCF0HMnMeRy;

namespace mqTn2KRuHaeVC7qZfAP;

internal class uOxwGiRTS5ExO0AcR6j
{
	private delegate void a48J5ORDojPxNWZyBY6(object o);

	internal class zIo4guRE2uK7VILXxPT : Attribute
	{
		internal class iNapgeR0kBknmLPBsfP<KcRo3URLhwd3DIIoIY4>
		{
			public iNapgeR0kBknmLPBsfP()
			{
				h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
				base._002Ector();
			}

			static iNapgeR0kBknmLPBsfP()
			{
				vIHvRlxcnv();
			}
		}

		[zIo4guRE2uK7VILXxPT(typeof(iNapgeR0kBknmLPBsfP<object>[]))]
		public zIo4guRE2uK7VILXxPT(object object_0)
		{
		}
	}

	internal class rjmWKXRA5RRsiaMsYat
	{
		[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
		internal static string JXsHBqQiUv(string string_0, string string_1)
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
			byte[] iV = TSG9lxaTIL(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = KbP9Qx9qxm();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint nIQWKFR2nIRw6BfX1eg(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr OUcgIDRfFCUyqOCpBLc();

	internal struct ajKsjBR1RLNLaVhjpoA
	{
		internal bool oXtHgVuR2f;

		internal byte[] PnbHmv3qGo;
	}

	internal class gyDdvIR3oOUnJD1CFa5
	{
		private BinaryReader NKJHShSsRT;

		public gyDdvIR3oOUnJD1CFa5(Stream stream_0)
		{
			NKJHShSsRT = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return NKJHShSsRT.BaseStream;
		}

		internal byte[] etZHN6xq1q(int int_0)
		{
			return NKJHShSsRT.ReadBytes(int_0);
		}

		internal int UquH5ya5YE(byte[] byte_0, int int_0, int int_1)
		{
			return NKJHShSsRT.Read(byte_0, int_0, int_1);
		}

		internal int vXQHMwXF7q()
		{
			return NKJHShSsRT.ReadInt32();
		}

		internal void He9HqDgDsF()
		{
			NKJHShSsRT.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr cfjCamRXiZdKE74kAn1(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr E5kLfqRGmReKNiaGQqM(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int iHm3UVR8hUunqANcLXv(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Ib2v6BRPFrgiWqPgttK(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr K03MmRRc6ZiX5WXYS2v(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int WliFNORheTkUq8awgRj(IntPtr ptr);

	[Flags]
	private enum GDj86eRk1EpxOv4UmxW
	{

	}

	private static int qlovs6HIpf;

	internal static nIQWKFR2nIRw6BfX1eg eBXvob89CY;

	internal static nIQWKFR2nIRw6BfX1eg a46vYunkjC;

	private static int RQavzu1ocQ;

	[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
	private static bool JahHRjGinm;

	private static cfjCamRXiZdKE74kAn1 fWAHaqAB3M;

	private static iHm3UVR8hUunqANcLXv w1nHvrmiyo;

	private static Ib2v6BRPFrgiWqPgttK wyIHHy4P79;

	private static bool tEZvk0Mx6G;

	private static byte[] dn6vpwWrZG;

	private static object mGPvw9P8gU;

	private static long gZnvJUO2bM;

	private static K03MmRRc6ZiX5WXYS2v cXaHV8eLsj;

	private static uint[] BUxvhadscL;

	private static int ztSvdrt3Tk;

	internal static Assembly gHcvctBPZN;

	private static bool qwrvi8Ue6V;

	internal static RSACryptoServiceProvider GNCvetpJns;

	private static SortedList x44vbIFBs2;

	private static int[] c6vv6pMs1g;

	private static bool lKIvxINiO8;

	private static object FFDvKvSaqP;

	private static IntPtr gUVvOGmyQB;

	private static bool F1Bvl34esG;

	private static E5kLfqRGmReKNiaGQqM XVZH9SMlXm;

	private static byte[] tiYvy4Mbrh;

	private static IntPtr UtjHUj3XUD;

	private static bool ExwvPjurTI;

	private static long Hc2vQXkaR0;

	private static Dictionary<int, int> M2hv48cBjf;

	private static int fPGvjiTLmn;

	private static bool KfAv78FZyC;

	private static IntPtr UaQvZgU188;

	private static IntPtr pZCHCwNOmf;

	private static WliFNORheTkUq8awgRj UFOHng2yMa;

	private static byte[] g4rvWcC8Eu;

	internal static Hashtable BonHFulavg;

	static uOxwGiRTS5ExO0AcR6j()
	{
		ExwvPjurTI = false;
		gHcvctBPZN = Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554497)).Assembly;
		BUxvhadscL = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		tEZvk0Mx6G = false;
		qwrvi8Ue6V = false;
		tiYvy4Mbrh = new byte[0];
		GNCvetpJns = null;
		M2hv48cBjf = null;
		mGPvw9P8gU = new object();
		g4rvWcC8Eu = new byte[0];
		dn6vpwWrZG = new byte[0];
		gUVvOGmyQB = IntPtr.Zero;
		UaQvZgU188 = IntPtr.Zero;
		FFDvKvSaqP = new string[0];
		c6vv6pMs1g = new int[0];
		qlovs6HIpf = 1;
		KfAv78FZyC = false;
		x44vbIFBs2 = new SortedList();
		fPGvjiTLmn = 0;
		gZnvJUO2bM = 0L;
		eBXvob89CY = null;
		a46vYunkjC = null;
		Hc2vQXkaR0 = 0L;
		ztSvdrt3Tk = 0;
		F1Bvl34esG = false;
		lKIvxINiO8 = false;
		RQavzu1ocQ = 0;
		UtjHUj3XUD = IntPtr.Zero;
		JahHRjGinm = false;
		BonHFulavg = new Hashtable();
		fWAHaqAB3M = null;
		XVZH9SMlXm = null;
		w1nHvrmiyo = null;
		wyIHHy4P79 = null;
		cXaHV8eLsj = null;
		UFOHng2yMa = null;
		pZCHCwNOmf = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void isxIH7hUr3gCe()
	{
	}

	internal static byte[] Hgu9sI9l7n(byte[] byte_0)
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
			zK197DXmg7(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			zK197DXmg7(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			zK197DXmg7(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			zK197DXmg7(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			zK197DXmg7(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			zK197DXmg7(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			zK197DXmg7(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			zK197DXmg7(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			zK197DXmg7(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			zK197DXmg7(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			zK197DXmg7(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			zK197DXmg7(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			zK197DXmg7(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			zK197DXmg7(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			zK197DXmg7(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			zK197DXmg7(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			CAT9bUSdFG(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			CAT9bUSdFG(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			CAT9bUSdFG(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			CAT9bUSdFG(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			CAT9bUSdFG(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			CAT9bUSdFG(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			CAT9bUSdFG(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			CAT9bUSdFG(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			CAT9bUSdFG(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			CAT9bUSdFG(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			CAT9bUSdFG(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			CAT9bUSdFG(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			CAT9bUSdFG(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			CAT9bUSdFG(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			CAT9bUSdFG(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			CAT9bUSdFG(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			hUa9jUqHjg(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			hUa9jUqHjg(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			hUa9jUqHjg(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			hUa9jUqHjg(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			hUa9jUqHjg(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			hUa9jUqHjg(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			hUa9jUqHjg(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			hUa9jUqHjg(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			hUa9jUqHjg(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			hUa9jUqHjg(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			hUa9jUqHjg(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			hUa9jUqHjg(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			hUa9jUqHjg(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			hUa9jUqHjg(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			hUa9jUqHjg(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			hUa9jUqHjg(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			JWJ9JTvCK2(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			JWJ9JTvCK2(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			JWJ9JTvCK2(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			JWJ9JTvCK2(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			JWJ9JTvCK2(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			JWJ9JTvCK2(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			JWJ9JTvCK2(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			JWJ9JTvCK2(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			JWJ9JTvCK2(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			JWJ9JTvCK2(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			JWJ9JTvCK2(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			JWJ9JTvCK2(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			JWJ9JTvCK2(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			JWJ9JTvCK2(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			JWJ9JTvCK2(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			JWJ9JTvCK2(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void zK197DXmg7(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + lRy9oPtI5i(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + BUxvhadscL[uint_5 - 1], ushort_0);
	}

	private static void CAT9bUSdFG(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + lRy9oPtI5i(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + BUxvhadscL[uint_5 - 1], ushort_0);
	}

	private static void hUa9jUqHjg(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + lRy9oPtI5i(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + BUxvhadscL[uint_5 - 1], ushort_0);
	}

	private static void JWJ9JTvCK2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + lRy9oPtI5i(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + BUxvhadscL[uint_5 - 1], ushort_0);
	}

	private static uint lRy9oPtI5i(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool H0X9Ykr7Le()
	{
		if (!tEZvk0Mx6G)
		{
			nlQ9deRdyQ();
			tEZvk0Mx6G = true;
		}
		return qwrvi8Ue6V;
	}

	internal static SymmetricAlgorithm KbP9Qx9qxm()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (H0X9Ykr7Le())
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

	internal static void nlQ9deRdyQ()
	{
		try
		{
			qwrvi8Ue6V = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] TSG9lxaTIL(byte[] byte_0)
	{
		if (!H0X9Ykr7Le())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return Hgu9sI9l7n(byte_0);
	}

	internal static void nkB9xHMgGR(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			nVf9zsoM1w(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void nVf9zsoM1w(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint d8QvULCqrn(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
	internal static void vIHvRlxcnv()
	{
		//IL_241b: Incompatible stack heights: 0 vs 1
		//IL_241b: Incompatible stack heights: 1 vs 0
		int num = 7;
		string object_7 = default(string);
		string text = default(string);
		bool flag = default(bool);
		HashAlgorithm object_6 = default(HashAlgorithm);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] object_5 = default(byte[]);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		byte[] object_4 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num11 = default(int);
		BinaryReader object_8 = default(BinaryReader);
		int num10 = default(int);
		long num14 = default(long);
		byte[] array4 = default(byte[]);
		uint num13 = default(uint);
		long num12 = default(long);
		uint num16 = default(uint);
		long num18 = default(long);
		int num15 = default(int);
		long long_ = default(long);
		byte[] array5 = default(byte[]);
		bool flag2 = default(bool);
		uint num8 = default(uint);
		uint uint_2 = default(uint);
		long num17 = default(long);
		uint num19 = default(uint);
		uint num20 = default(uint);
		uint uint_ = default(uint);
		uint num9 = default(uint);
		int int_ = default(int);
		int num23 = default(int);
		while (GNCvetpJns == null)
		{
			while (true)
			{
				IL_0013:
				x1MAhbgwdmQOfI2hqe();
				int num2 = 5;
				if (TuttsdI5ZB1Vxm841E() != null)
				{
					return;
				}
				while (true)
				{
					switch (num2)
					{
					case 7:
						break;
					case 9:
						goto IL_0013;
					default:
						return;
					case 17:
						try
						{
							object_6 = (HashAlgorithm)OIm9WwigSr5Xspf0aP();
							int num24 = 1;
							if (TuttsdI5ZB1Vxm841E() != null)
							{
								goto IL_00eb;
							}
							while (true)
							{
								switch (num24)
								{
								case 1:
									goto IL_00bb;
								case 2:
									goto end_IL_00d3;
								case 3:
									return;
								}
								goto IL_00eb;
								IL_00bb:
								object_7 = (string)FncCped7ih4uuMGKWX("SHA1");
								num24 = 0;
								if (TuttsdI5ZB1Vxm841E() != null)
								{
									continue;
								}
								goto IL_00eb;
								continue;
								end_IL_00d3:
								break;
							}
							goto end_IL_00a5;
							IL_00eb:
							if (!Yd6TI9D3leNPaNLDdN(text))
							{
								return;
							}
							end_IL_00a5:;
						}
						catch
						{
							if (bDfEwr2yJegPEMS6fl())
							{
								switch (0)
								{
								}
							}
							return;
						}
						goto case 2;
					case 2:
						flag = false;
						num2 = 11;
						if (TuttsdI5ZB1Vxm841E() == null)
						{
							continue;
						}
						goto IL_008a;
					case 15:
						object_7 = null;
						goto case 17;
					case 14:
						GNCvetpJns = new RSACryptoServiceProvider();
						num2 = 8;
						if (TuttsdI5ZB1Vxm841E() == null)
						{
							continue;
						}
						goto IL_008a;
					case 13:
						if (wlYAsU0DNmRqSACLY3(text) == 0)
						{
							num2 = 10;
							if (!bDfEwr2yJegPEMS6fl())
							{
								continue;
							}
							return;
						}
						object_6 = null;
						goto case 15;
					case 11:
						try
						{
							gyDdvIR3oOUnJD1CFa5 object_ = new gyDdvIR3oOUnJD1CFa5((Stream)puUaj28pcuJR4Jd32X(gHcvctBPZN, "e7Gv1EYW6bP2biyfa3.DSBxfvIPjg3rv7XJ77"));
							int num3 = 252;
							if (TuttsdI5ZB1Vxm841E() != null)
							{
								goto IL_01e0;
							}
							goto IL_1e7c;
							IL_1e7c:
							while (true)
							{
								switch (num3)
								{
								case 344:
									array2[5] = 93;
									num6 = 191;
									goto case 191;
								case 191:
									array2[6] = 116;
									goto case 258;
								case 258:
									array2[6] = 90;
									num3 = 21;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 343:
									num4 = 95;
									goto case 302;
								case 302:
									array[9] = (byte)num4;
									num3 = 151;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 342:
									array2[1] = (byte)num5;
									num3 = 145;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 341:
									num5 = 123;
									goto case 172;
								case 172:
									array2[7] = (byte)num5;
									goto case 194;
								case 194:
									array2[8] = 120;
									num3 = 62;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 340:
									array2[9] = (byte)num5;
									goto case 109;
								case 109:
									array2[10] = 88;
									goto case 46;
								case 46:
									num5 = 136;
									goto case 22;
								case 22:
									array2[10] = (byte)num5;
									goto case 313;
								case 313:
									array2[10] = 90;
									num3 = 220;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 265;
								case 265:
									num5 = 118;
									goto case 315;
								case 315:
									array2[10] = (byte)num5;
									goto case 239;
								case 239:
									num5 = 94;
									goto case 106;
								case 106:
									array2[10] = (byte)num5;
									num3 = 287;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 258;
								case 339:
									array[14] = (byte)num4;
									num3 = 210;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 164;
								case 164:
									stream = (Stream)eJbJeoc09DR7MP3Nxn();
									num6 = 189;
									goto case 189;
								case 189:
									object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
									num3 = 76;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 338:
									num4 = 139;
									num3 = 241;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 337:
									array[12] = (byte)num4;
									num3 = 58;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 324;
								case 324:
									num4 = 93;
									goto case 304;
								case 304:
									array[12] = (byte)num4;
									num3 = 15;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 36;
								case 36:
									num4 = 53;
									goto case 182;
								case 182:
									array[12] = (byte)num4;
									goto case 59;
								case 59:
									num4 = 140;
									num3 = 271;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 267;
								case 267:
									array[8] = 84;
									goto case 330;
								case 330:
									array[8] = 160;
									num3 = 229;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 336:
									array2[9] = (byte)num5;
									num3 = 249;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 335:
									array[27] = (byte)num4;
									goto case 71;
								case 71:
									array[27] = 107;
									goto case 301;
								case 301:
									array[27] = 175;
									num3 = 278;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 334:
									array[3] = 157;
									goto case 84;
								case 84:
									array[3] = 121;
									num3 = 312;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 333:
									array[15] = 148;
									goto case 161;
								case 161:
									array[15] = 210;
									num6 = 40;
									goto case 40;
								case 40:
									array[16] = 119;
									num3 = 111;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 317;
								case 317:
									num4 = 158;
									goto case 166;
								case 166:
									array[16] = (byte)num4;
									num6 = 277;
									goto case 277;
								case 277:
									array[16] = 107;
									num3 = 171;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 160;
								case 160:
									array[30] = 147;
									goto case 234;
								case 234:
									num4 = 148;
									num3 = 248;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 332:
									array[20] = 75;
									num3 = 294;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 320;
								case 320:
									array[21] = 108;
									goto case 276;
								case 276:
									num4 = 158;
									goto case 51;
								case 51:
									array[21] = (byte)num4;
									num6 = 130;
									goto case 130;
								case 130:
									num4 = 169;
									goto case 269;
								case 269:
									array[21] = (byte)num4;
									goto case 279;
								case 279:
									num4 = 200;
									num3 = 70;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 66;
								case 66:
									array[12] = 191;
									num3 = 153;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 95;
								case 95:
									array[20] = 178;
									goto case 96;
								case 96:
									array[20] = 183;
									num3 = 264;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 50;
								case 50:
									array[4] = 91;
									goto case 11;
								case 11:
									num4 = 188;
									goto case 44;
								case 44:
									array[4] = (byte)num4;
									goto case 125;
								case 125:
									array[5] = 110;
									goto case 338;
								case 331:
									array[6] = (byte)num4;
									num3 = 192;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 329:
									array2[2] = (byte)num5;
									num6 = 311;
									goto case 311;
								case 311:
									array2[2] = 69;
									goto case 228;
								case 228:
									array2[3] = 80;
									goto case 85;
								case 85:
									num5 = 89;
									num3 = 259;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 328:
									array[17] = 118;
									num3 = 289;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 49;
								case 49:
									array[2] = 178;
									goto case 81;
								case 81:
									array[2] = 49;
									num3 = 273;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 327:
									array2[12] = 209;
									num3 = 215;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 25;
								case 25:
									array[7] = 190;
									goto case 267;
								case 326:
									array2[15] = (byte)num5;
									num3 = 0;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 1;
								case 1:
									num5 = 128;
									num3 = 257;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 325:
									num5 = 167;
									goto case 32;
								case 32:
									array2[14] = (byte)num5;
									num3 = 10;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 323:
									array[11] = (byte)num4;
									num3 = 211;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 322:
									array2[8] = (byte)num5;
									goto case 8;
								case 8:
									num5 = 128;
									goto case 90;
								case 90:
									array2[9] = (byte)num5;
									goto case 135;
								case 135:
									array2[9] = 168;
									num3 = 180;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 321:
									array[29] = 127;
									goto case 79;
								case 79:
									array[29] = 92;
									num3 = 152;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 152;
								case 152:
									num4 = 155;
									goto case 48;
								case 48:
									array[29] = (byte)num4;
									goto case 134;
								case 134:
									array[29] = 110;
									num6 = 78;
									goto case 78;
								case 78:
									num4 = 1;
									goto case 219;
								case 219:
									array[29] = (byte)num4;
									goto case 240;
								case 240:
									array[30] = 215;
									goto case 202;
								case 202:
									array[30] = 195;
									num3 = 79;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 118;
								case 118:
									array[30] = 112;
									goto case 160;
								case 319:
									num4 = 57;
									goto case 123;
								case 123:
									array[4] = (byte)num4;
									goto case 50;
								case 318:
									array2[1] = (byte)num5;
									num6 = 108;
									goto case 108;
								case 108:
									num5 = 77;
									goto case 13;
								case 13:
									array2[2] = (byte)num5;
									num3 = 216;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 157;
								case 157:
									array[26] = 97;
									num3 = 155;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 133;
								case 133:
									object_5 = array;
									num3 = 114;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 12;
								case 12:
									array2[3] = 125;
									num3 = 300;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 316:
									array2[0] = (byte)num5;
									goto case 107;
								case 107:
									array2[0] = 85;
									num3 = 57;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 170;
								case 170:
									num5 = 130;
									goto case 60;
								case 60:
									array2[0] = (byte)num5;
									goto case 305;
								case 305:
									num5 = 130;
									goto case 291;
								case 291:
									array2[1] = (byte)num5;
									goto case 33;
								case 33:
									num5 = 112;
									goto case 342;
								case 314:
									array[25] = (byte)num4;
									num6 = 75;
									goto case 75;
								case 75:
									array[26] = 90;
									num3 = 157;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 154;
								case 154:
									transform = (ICryptoTransform)HGTaCjowiqrKWGFEEy(object_3, object_5, object_4);
									num3 = 164;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 312:
									array[4] = 72;
									goto case 319;
								case 310:
									array[0] = 185;
									goto case 163;
								case 163:
									array[1] = 116;
									goto case 203;
								case 203:
									num4 = 119;
									num3 = 21;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 97;
								case 97:
									array[1] = (byte)num4;
									goto case 156;
								case 156:
									array[1] = 140;
									goto case 136;
								case 136:
									num4 = 20;
									num3 = 162;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 223;
								case 223:
									array[1] = (byte)num4;
									goto case 116;
								case 116:
									num4 = 106;
									num3 = 68;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 29;
								case 29:
									num4 = 168;
									goto case 54;
								case 54:
									array[28] = (byte)num4;
									goto case 218;
								case 218:
									num4 = 164;
									goto case 74;
								case 74:
									array[28] = (byte)num4;
									num3 = 294;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 299;
								case 299:
									num4 = 241;
									num3 = 177;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 309:
									array[26] = (byte)num4;
									goto case 103;
								case 103:
									array[27] = 94;
									num3 = 214;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 308:
									array[17] = 157;
									goto case 72;
								case 72:
									num4 = 160;
									num3 = 41;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 307:
									num4 = 187;
									num3 = 285;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 306:
									array2[9] = 131;
									num3 = 70;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 128;
								case 128:
									num5 = 144;
									num6 = 340;
									goto case 340;
								case 303:
									array[20] = 150;
									goto case 45;
								case 45:
									array[20] = 102;
									goto case 95;
								case 300:
									num5 = 152;
									goto case 266;
								case 266:
									array2[4] = (byte)num5;
									num3 = 2;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 16;
								case 16:
									num5 = 63;
									goto case 17;
								case 17:
									array2[4] = (byte)num5;
									num6 = 31;
									goto case 31;
								case 31:
									array2[4] = 67;
									num3 = 140;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 298:
									num5 = 134;
									goto case 83;
								case 83:
									array2[3] = (byte)num5;
									num3 = 12;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 297:
									num4 = 147;
									goto case 335;
								case 296:
									array[25] = 28;
									num3 = 82;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 295:
									num4 = 121;
									goto case 261;
								case 261:
									array[23] = (byte)num4;
									goto case 251;
								case 251:
									array[23] = 146;
									num3 = 115;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 293:
									array[9] = (byte)num4;
									goto case 220;
								case 220:
									array[9] = 102;
									goto case 250;
								case 250:
									array[9] = 124;
									num3 = 292;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 292:
									num4 = 85;
									num3 = 226;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 290:
									array[11] = 232;
									goto case 126;
								case 126:
									num4 = 59;
									num6 = 337;
									goto case 337;
								case 289:
									array[17] = 125;
									num3 = 272;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 288:
									O7kYuKQDV5unnENG8Q(object_2);
									goto case 225;
								case 225:
									z3Y9yBbGOIRQrb53oo(GNCvetpJns, yQ32YUMVsTAyqHDjqC(dcv1mSSnb1xkRDQJUg(), Nh7UAOC99EbwVYWcyR(stream)));
									goto case 57;
								case 57:
									ItXomI6309uAvuAIq1(stream);
									num3 = 294;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 287:
									array2[10] = 95;
									goto case 53;
								case 53:
									num5 = 118;
									num6 = 236;
									goto case 236;
								case 236:
									array2[11] = (byte)num5;
									goto case 237;
								case 237:
									num5 = 142;
									num6 = 99;
									goto case 99;
								case 99:
									array2[11] = (byte)num5;
									goto case 141;
								case 141:
									array2[11] = 135;
									num3 = 146;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 43;
								case 43:
									num5 = 0;
									goto case 179;
								case 179:
									array2[13] = (byte)num5;
									goto case 325;
								case 286:
									array2[12] = 117;
									num3 = 247;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 285:
									array[31] = (byte)num4;
									num3 = 14;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 133;
								case 284:
									array[22] = 160;
									num3 = 208;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 283:
									array2[15] = (byte)num5;
									goto case 159;
								case 159:
									array2[15] = 157;
									goto case 6;
								case 6:
									object_4 = array2;
									num3 = 20;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 282:
									array[24] = 123;
									goto case 129;
								case 129:
									num4 = 45;
									num3 = 63;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 5;
								case 5:
									array[18] = 132;
									goto case 149;
								case 149:
									num4 = 2;
									goto case 91;
								case 91:
									array[18] = (byte)num4;
									num3 = 184;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 281:
									array2[12] = 150;
									goto case 286;
								case 280:
									array[24] = 118;
									num3 = 100;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 282;
								case 278:
									num4 = 138;
									num3 = 20;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 23;
								case 23:
									array[28] = (byte)num4;
									goto case 29;
								case 275:
									array[25] = 111;
									goto case 296;
								case 274:
									array[8] = (byte)num4;
									goto case 343;
								case 273:
									array[3] = 101;
									num3 = 139;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 272:
									array[17] = 67;
									num3 = 27;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 11;
								case 271:
									array[12] = (byte)num4;
									num3 = 66;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 270:
									array2[5] = 89;
									num3 = 131;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 268:
									array[2] = (byte)num4;
									num3 = 49;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 36;
								case 264:
									array[20] = 204;
									goto case 332;
								case 263:
									array[0] = 101;
									goto case 67;
								case 67:
									num4 = 229;
									goto case 176;
								case 176:
									array[0] = (byte)num4;
									num3 = 149;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 235;
								case 235:
									array[0] = 124;
									goto case 310;
								case 262:
									num4 = 129;
									num3 = 138;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 260:
									array[23] = 103;
									num3 = 117;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 259:
									array2[3] = (byte)num5;
									goto case 298;
								case 257:
									array2[15] = (byte)num5;
									num3 = 101;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 256:
									array[11] = (byte)num4;
									goto case 39;
								case 39:
									array[11] = 60;
									num3 = 290;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 255:
									array[22] = 121;
									num3 = 193;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 253:
									array[19] = (byte)num4;
									num6 = 200;
									goto case 200;
								case 200:
									num4 = 22;
									goto case 9;
								case 9:
									array[19] = (byte)num4;
									num3 = 303;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 252:
									aoDKmotxiwTFZt2Dyn(hsvZpdHZKsi3GH8Qs5(object_), 0L);
									goto case 196;
								case 196:
									array3 = (byte[])bpojGUYtOrEiQ7fi2I(object_, (int)xOYJLtwUOp5JdnYw6l(hsvZpdHZKsi3GH8Qs5(object_)));
									goto case 113;
								case 113:
									array = new byte[32];
									goto case 263;
								case 249:
									array2[9] = 156;
									num3 = 306;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 248:
									array[30] = (byte)num4;
									num3 = 242;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 247:
									array2[12] = 128;
									num6 = 327;
									goto case 327;
								case 246:
									num4 = 185;
									num3 = 87;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 245:
									num5 = 27;
									num3 = 322;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 244:
									array[10] = (byte)num4;
									goto case 233;
								case 233:
									num4 = 112;
									num3 = 34;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 243:
									num4 = 112;
									goto case 65;
								case 65:
									array[6] = (byte)num4;
									goto case 221;
								case 221:
									num4 = 37;
									num3 = 121;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 331;
								case 242:
									num4 = 128;
									num3 = 119;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 241:
									array[5] = (byte)num4;
									num3 = 190;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 185;
								case 185:
									array2[14] = 85;
									goto case 92;
								case 92:
									num5 = 214;
									goto case 104;
								case 104:
									array2[14] = (byte)num5;
									num6 = 183;
									goto case 183;
								case 183:
									num5 = 87;
									goto case 147;
								case 147:
									array2[15] = (byte)num5;
									num3 = 33;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 173;
								case 173:
									num5 = 87;
									goto case 326;
								case 238:
									array2[7] = (byte)num5;
									goto case 38;
								case 38:
									array2[7] = 96;
									goto case 341;
								case 232:
									array[11] = (byte)num4;
									goto case 122;
								case 122:
									num4 = 134;
									num3 = 323;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 231:
									array[31] = (byte)num4;
									num3 = 307;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 230:
									array[11] = (byte)num4;
									goto case 69;
								case 69:
									num4 = 36;
									num3 = 232;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 229:
									array[8] = 93;
									num6 = 162;
									goto case 162;
								case 162:
									num4 = 126;
									num3 = 274;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 194;
								case 227:
									num4 = 129;
									num3 = 268;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 226:
									array[10] = (byte)num4;
									num6 = 143;
									goto case 143;
								case 143:
									array[10] = 98;
									num3 = 37;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 224:
									array[6] = 136;
									num3 = 243;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 107;
								case 222:
									array[17] = (byte)num4;
									num3 = 328;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 328;
								case 217:
									array[12] = (byte)num4;
									goto case 112;
								case 112:
									num4 = 167;
									goto case 110;
								case 110:
									array[13] = (byte)num4;
									goto case 26;
								case 26:
									array[13] = 6;
									num3 = 105;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 216:
									num5 = 126;
									num3 = 329;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 153;
								case 153:
									num4 = 136;
									goto case 217;
								case 215:
									array2[13] = 120;
									num3 = 86;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 85;
								case 214:
									array[27] = 124;
									num3 = 206;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 213:
									array2[0] = 115;
									num3 = 201;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 163;
								case 212:
									GeV2X9qu2PQcoil7GV(object_3, CipherMode.CBC);
									num3 = 151;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 154;
								case 211:
									num4 = 119;
									goto case 256;
								case 210:
									num4 = 19;
									num3 = 81;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 124;
								case 124:
									array[14] = (byte)num4;
									goto case 15;
								case 15:
									array[14] = 169;
									num3 = 178;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 209:
									array2[11] = (byte)num5;
									goto case 281;
								case 208:
									array[22] = 85;
									goto case 132;
								case 132:
									array[22] = 47;
									goto case 260;
								case 207:
									array[25] = (byte)num4;
									goto case 93;
								case 93:
									array[25] = 169;
									num3 = 275;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 206:
									num4 = 124;
									num3 = 2;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto default;
								default:
									array2[5] = (byte)num5;
									goto case 270;
								case 205:
									array[18] = 166;
									num6 = 5;
									goto case 5;
								case 204:
									num5 = 115;
									num3 = 35;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 201:
									num5 = 164;
									goto case 316;
								case 199:
									num4 = 217;
									goto case 231;
								case 198:
									num4 = 134;
									goto case 3;
								case 3:
									array[16] = (byte)num4;
									goto case 111;
								case 111:
									array[16] = 225;
									goto case 308;
								case 195:
									array2[13] = (byte)num5;
									goto case 144;
								case 144:
									array2[13] = 115;
									num3 = 42;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 43;
								case 193:
									array[22] = 177;
									goto case 284;
								case 192:
									num4 = 16;
									goto case 167;
								case 167:
									array[6] = (byte)num4;
									goto case 142;
								case 142:
									num4 = 105;
									goto case 98;
								case 98:
									array[7] = (byte)num4;
									goto case 246;
								case 190:
									array[5] = 169;
									num6 = 18;
									goto case 18;
								case 18:
									num4 = 129;
									num3 = 88;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 188:
									array[23] = (byte)num4;
									num3 = 13;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 19;
								case 19:
									num4 = 135;
									goto case 14;
								case 14:
									array[23] = (byte)num4;
									goto case 295;
								case 187:
									num4 = 108;
									goto case 230;
								case 186:
									num4 = 84;
									goto case 100;
								case 100:
									array[2] = (byte)num4;
									num3 = 133;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 227;
								case 184:
									num4 = 126;
									num3 = 36;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 80;
								case 80:
									array[19] = (byte)num4;
									goto case 102;
								case 102:
									array[19] = 116;
									goto case 56;
								case 56:
									array[19] = 84;
									num3 = 24;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 16;
								case 181:
									array2[8] = (byte)num5;
									goto case 204;
								case 180:
									num5 = 37;
									num6 = 336;
									goto case 336;
								case 178:
									array[14] = 182;
									num3 = 61;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 177:
									array[28] = (byte)num4;
									goto case 321;
								case 175:
									num4 = 196;
									goto case 150;
								case 150:
									array[18] = (byte)num4;
									goto case 205;
								case 174:
									num4 = 15;
									num3 = 86;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 314;
								case 171:
									array[16] = 133;
									num3 = 198;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 169:
									num5 = 117;
									goto case 238;
								case 168:
									num4 = 75;
									num3 = 339;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 165:
									array[10] = 6;
									num3 = 187;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 158:
									array2[7] = (byte)num5;
									num6 = 169;
									goto case 169;
								case 155:
									array[26] = 127;
									num3 = 4;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 151:
									num4 = 168;
									goto case 293;
								case 148:
									array[15] = (byte)num4;
									goto case 262;
								case 146:
									num5 = 108;
									num6 = 28;
									goto case 28;
								case 28:
									array2[11] = (byte)num5;
									num3 = 30;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 145:
									array2[1] = 146;
									goto case 89;
								case 89:
									num5 = 63;
									num3 = 318;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 221;
								case 140:
									num5 = 57;
									num3 = 0;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 139:
									array[3] = 134;
									num3 = 12;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 64;
								case 64:
									array[3] = 148;
									num6 = 334;
									goto case 334;
								case 138:
									array[15] = (byte)num4;
									goto case 333;
								case 137:
									num5 = 15;
									goto case 209;
								case 131:
									array2[5] = 153;
									num3 = 344;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 127:
									num4 = 120;
									goto case 207;
								case 121:
									num4 = 118;
									goto case 244;
								case 120:
									array2[14] = (byte)num5;
									num3 = 73;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 37;
								case 37:
									array[10] = 25;
									num3 = 121;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 119:
									array[31] = (byte)num4;
									goto case 199;
								case 117:
									num4 = 145;
									num3 = 184;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 188;
								case 115:
									array[23] = 179;
									num3 = 280;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 114:
									array2 = new byte[16];
									num3 = 213;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 105:
									array[13] = 181;
									goto case 168;
								case 101:
									num5 = 154;
									num3 = 283;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 180;
								case 94:
									array[21] = 161;
									num3 = 255;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 88:
									array[6] = (byte)num4;
									num3 = 58;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 56;
								case 87:
									array[7] = (byte)num4;
									goto case 25;
								case 86:
									num5 = 112;
									goto case 195;
								case 82:
									array[25] = 113;
									num3 = 174;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 76;
								case 76:
									XrS0721BT959OaOZOl(object_2, array3, 0, array3.Length);
									num6 = 288;
									goto case 288;
								case 77:
									array2[8] = 154;
									num3 = 245;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 73:
									num5 = 88;
									num3 = 52;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 70:
									array[21] = (byte)num4;
									goto case 94;
								case 68:
									array[2] = (byte)num4;
									goto case 186;
								case 63:
									array[24] = (byte)num4;
									num3 = 127;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 62:
									num5 = 145;
									goto case 181;
								case 61:
									num4 = 54;
									num3 = 54;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 148;
								case 58:
									array[6] = 100;
									goto case 224;
								case 55:
									num5 = 132;
									goto case 158;
								case 52:
									array2[14] = (byte)num5;
									num6 = 185;
									goto case 185;
								case 47:
									num4 = 155;
									goto case 253;
								case 42:
									array[19] = (byte)num4;
									num3 = 47;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 41:
									array[17] = (byte)num4;
									goto case 7;
								case 7:
									num4 = 137;
									goto case 222;
								case 35:
									array2[8] = (byte)num5;
									num6 = 77;
									goto case 77;
								case 34:
									array[10] = (byte)num4;
									num3 = 16;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 165;
								case 30:
									array2[11] = 134;
									num6 = 137;
									goto case 137;
								case 27:
									array[18] = 144;
									num3 = 175;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 24:
									num4 = 92;
									num6 = 42;
									goto case 42;
								case 21:
									array2[6] = 94;
									goto case 55;
								case 20:
									object_3 = (SymmetricAlgorithm)k3LPsJO5MJfQWJ1c6n();
									goto case 212;
								case 10:
									num5 = 191;
									num3 = 120;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 4:
									num4 = 19;
									goto case 309;
								case 2:
									array[27] = (byte)num4;
									num3 = 297;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 99;
								case 294:
									ItXomI6309uAvuAIq1(object_2);
									goto case 254;
								case 254:
									lq13Irr6enbVkD3QFA(object_);
									goto end_IL_1e7c;
								case 197:
									goto end_IL_1e7c;
								}
								goto IL_01e0;
								continue;
								end_IL_1e7c:
								break;
							}
							goto end_IL_017b;
							IL_01e0:
							num3 = num6;
							goto IL_1e7c;
							end_IL_017b:;
						}
						catch
						{
							if (!bDfEwr2yJegPEMS6fl())
							{
								goto IL_240e;
							}
							goto IL_241d;
							IL_241d:
							switch (0)
							{
							case 1:
								goto end_IL_23fd;
							}
							goto IL_240e;
							IL_240e:
							do
							{
								flag = true;
								_ = 1;
							}
							while (TuttsdI5ZB1Vxm841E() != null);
							goto IL_241d;
							end_IL_23fd:;
						}
						goto case 10;
					case 3:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num7 = 47;
							if (TuttsdI5ZB1Vxm841E() != null)
							{
								goto IL_24f1;
							}
							goto IL_2947;
							IL_2947:
							while (true)
							{
								int num21;
								switch (num7)
								{
								case 72:
									num11 = LKnp3ZalLK69jRCu5P(object_8);
									num7 = 61;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 15;
								case 15:
								case 52:
									num10++;
									goto case 21;
								case 21:
								case 38:
									if (num10 >= num11)
									{
										num7 = 30;
										if (!bDfEwr2yJegPEMS6fl())
										{
											continue;
										}
										goto case 60;
									}
									goto case 17;
								case 60:
									VuZm1dsv3gHwYyL7F5(object_6, new byte[0], 0, 0);
									goto case 20;
								case 20:
									aoDKmotxiwTFZt2Dyn(fileStream, num14);
									goto case 54;
								case 54:
									array4 = (byte[])LoZEBXhxCbU7exYHZa(object_8, (int)num13);
									num7 = 2;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 17:
									aoDKmotxiwTFZt2Dyn(fileStream, num12 + num10 * 40 + 16L);
									goto case 66;
								case 66:
									num16 = wUXyQcP0sR0PuTZuQZ(object_8);
									num7 = 7;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 71:
									num18 = num14 + num13;
									num15 = 40;
									goto case 40;
								case 40:
									aoDKmotxiwTFZt2Dyn(fileStream, long_);
									num7 = 28;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 70:
									skRDuNXmruXyB3m9aD(object_6, fileStream, 152u, array5);
									num7 = 3;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 4;
								case 4:
									flag2 = LKnp3ZalLK69jRCu5P(object_8) != 523;
									num15 = 53;
									goto case 53;
								case 53:
									if (!flag2)
									{
										goto case 68;
									}
									num21 = 96;
									goto IL_256c;
								case 68:
									num21 = 112;
									goto IL_256c;
								case 3:
									array5[39] = 0;
									num15 = 13;
									goto case 13;
								case 13:
									CObT5XUtgV68YeC35o(object_6, array5, 0, 128);
									num7 = 2;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 67;
								case 67:
									num12 = I3d2FRKJWjm8tncXMg(fileStream);
									num15 = 36;
									goto case 36;
								case 36:
									aoDKmotxiwTFZt2Dyn(fileStream, 134L);
									goto case 72;
								case 69:
									aoDKmotxiwTFZt2Dyn(fileStream, num8);
									num7 = 22;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 65:
									aoDKmotxiwTFZt2Dyn(fileStream, 360L);
									goto case 32;
								case 32:
								case 41:
									uint_2 = wUXyQcP0sR0PuTZuQZ(object_8);
									num7 = 34;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 64:
									if (num17 < num18)
									{
										goto case 24;
									}
									goto case 37;
								case 24:
									num19 = (uint)(num18 - num17);
									goto case 26;
								case 26:
									if (num19 >= num16)
									{
										goto case 15;
									}
									goto case 43;
								case 43:
									num16 -= num19;
									goto case 46;
								case 46:
									aoDKmotxiwTFZt2Dyn(fileStream, I3d2FRKJWjm8tncXMg(fileStream) + num19);
									num7 = 27;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 3;
								case 37:
								case 57:
									if (num17 < num18)
									{
										goto case 12;
									}
									goto case 50;
								case 12:
								case 62:
									num20 = (uint)vcte99WR5r2i9dcQ6c(num14 - num17, num16);
									goto case 58;
								case 58:
									skRDuNXmruXyB3m9aD(object_6, fileStream, num20, array5);
									num15 = 48;
									goto case 48;
								case 48:
									num16 -= num20;
									num7 = 63;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 40;
								case 50:
									skRDuNXmruXyB3m9aD(object_6, fileStream, num16, array5);
									goto case 15;
								case 22:
								case 27:
								case 63:
									if (num16 == 0)
									{
										goto case 15;
									}
									goto case 19;
								case 19:
									num17 = I3d2FRKJWjm8tncXMg(fileStream);
									goto case 11;
								case 11:
									if (num14 <= num17)
									{
										goto case 64;
									}
									num15 = 57;
									goto case 37;
								case 61:
									aoDKmotxiwTFZt2Dyn(fileStream, num12);
									goto case 33;
								case 33:
									skRDuNXmruXyB3m9aD(object_6, fileStream, (uint)(num11 * 40), array5);
									goto case 30;
								case 30:
									long_ = I3d2FRKJWjm8tncXMg(fileStream);
									num7 = 29;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 59:
									array5[35] = 0;
									goto case 16;
								case 16:
									array5[36] = 0;
									num15 = 5;
									goto case 5;
								case 5:
									array5[37] = 0;
									goto case 45;
								case 45:
									array5[38] = 0;
									num7 = 2;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 3;
								case 56:
									k0c0riLXoIodtdq5cj(fileStream, array5, 0, 128);
									goto case 18;
								case 18:
									array5[32] = 0;
									num7 = 0;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto default;
								default:
									array5[33] = 0;
									num7 = 35;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 55:
									num14 = YKqXYZAdSmCwwHZ2A7(uint_, num11, num12, object_8);
									goto case 71;
								case 51:
									array5[65] = 0;
									num7 = 42;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 30;
								case 47:
									object_8 = new BinaryReader(fileStream);
									goto case 25;
								case 25:
									array5 = new byte[65536];
									goto case 70;
								case 42:
									array5[66] = 0;
									goto case 8;
								case 8:
									array5[67] = 0;
									num7 = 10;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 2;
								case 2:
									vRlAVbNpJxm13ikOel(array4);
									num7 = 44;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 39:
									num13 = wUXyQcP0sR0PuTZuQZ(object_8);
									num7 = 55;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 35:
									array5[34] = 0;
									num7 = 59;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 34:
									num9 = YKqXYZAdSmCwwHZ2A7(uint_2, num11, num12, object_8);
									num7 = 23;
									if (bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									break;
								case 31:
									k0c0riLXoIodtdq5cj(fileStream, array5, 0, int_);
									num7 = 9;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 29:
									if (flag2)
									{
										goto case 65;
									}
									goto case 1;
								case 1:
									aoDKmotxiwTFZt2Dyn(fileStream, 376L);
									num7 = 41;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									break;
								case 28:
									num10 = 0;
									goto case 21;
								case 23:
									aoDKmotxiwTFZt2Dyn(fileStream, num9 + 32);
									goto case 14;
								case 14:
									uint_ = wUXyQcP0sR0PuTZuQZ(object_8);
									num7 = 10;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 39;
								case 10:
									CObT5XUtgV68YeC35o(object_6, array5, 0, int_);
									goto case 56;
								case 9:
									array5[64] = 0;
									num7 = 22;
									if (TuttsdI5ZB1Vxm841E() != null)
									{
										continue;
									}
									goto case 51;
								case 7:
									num8 = wUXyQcP0sR0PuTZuQZ(object_8);
									num7 = 67;
									if (!bDfEwr2yJegPEMS6fl())
									{
										continue;
									}
									goto case 69;
								case 6:
									aoDKmotxiwTFZt2Dyn(fileStream, 152L);
									goto case 31;
								case 44:
									flag = !iC9IIcfMcvpsoU6ZqH(GNCvetpJns, GNdL17yf9PuMPXx8Ta(object_6), object_7, array4);
									goto end_IL_2947;
								case 49:
									goto end_IL_2947;
									IL_256c:
									int_ = num21;
									num7 = 6;
									if (TuttsdI5ZB1Vxm841E() == null)
									{
										continue;
									}
									goto case 3;
								}
								goto IL_24f1;
								continue;
								end_IL_2947:
								break;
							}
							goto end_IL_2432;
							IL_24f1:
							num7 = num15;
							goto IL_2947;
							end_IL_2432:;
						}
						catch
						{
							int num22 = 0;
							if (TuttsdI5ZB1Vxm841E() == null)
							{
								goto IL_2aa4;
							}
							goto IL_2ac1;
							IL_2aa4:
							while (true)
							{
								switch (num22)
								{
								case 1:
									goto end_IL_2aa4;
								}
								flag = true;
								num22 = 1;
								if (TuttsdI5ZB1Vxm841E() == null)
								{
									continue;
								}
								goto IL_2ac1;
								continue;
								end_IL_2aa4:
								break;
							}
							goto end_IL_2a94;
							IL_2ac1:
							num22 = num23;
							goto IL_2aa4;
							end_IL_2a94:;
						}
						goto case 18;
					case 8:
						text = (string)A5298IFIy5HYsNDreo(GyM8yAngXhkT5E2BjG(typeof(uOxwGiRTS5ExO0AcR6j).TypeHandle).Assembly);
						num2 = 4;
						if (bDfEwr2yJegPEMS6fl())
						{
							continue;
						}
						goto case 1;
					case 5:
						NfnoO89lB5sNXo8HkO(bool_0: true);
						goto case 14;
					case 4:
						if (text == null)
						{
							num2 = 16;
							if (TuttsdI5ZB1Vxm841E() == null)
							{
								continue;
							}
							goto IL_008a;
						}
						goto case 13;
					case 10:
						if (!flag)
						{
							goto case 3;
						}
						goto case 18;
					case 18:
						if (flag)
						{
							num2 = 1;
							if (TuttsdI5ZB1Vxm841E() == null)
							{
								continue;
							}
							goto IL_008a;
						}
						flag = false;
						num2 = 0;
						if (bDfEwr2yJegPEMS6fl())
						{
							continue;
						}
						return;
					case 1:
						throw new Exception((string?)YVyR5dpWPnBWGrfgGS(rIiPSZGYUrutUMEFCU(b6Qb4Kl9EUI7I60VTo(GyM8yAngXhkT5E2BjG(typeof(uOxwGiRTS5ExO0AcR6j).TypeHandle).Assembly)), " is tampered."));
					case 12:
					case 16:
						return;
					case 0:
					case 6:
						return;
						IL_008a:
						num2 = num;
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	public static void fLXvFWtL5N(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (M2hv48cBjf == null)
			{
				lock (mGPvw9P8gU)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554497)).Assembly.GetManifestResourceStream("Y7IIvONRL6FZIwr9n7.JTdCxsiqV8Wxa3guTY"));
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
							num3 += SN4vvAWweS(num3);
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
						gyDdvIR3oOUnJD1CFa5 gyDdvIR3oOUnJD1CFa = new gyDdvIR3oOUnJD1CFa5(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = gyDdvIR3oOUnJD1CFa.vXQHMwXF7q();
							int value = gyDdvIR3oOUnJD1CFa.vXQHMwXF7q();
							dictionary.Add(key, value);
						}
						gyDdvIR3oOUnJD1CFa.He9HqDgDsF();
					}
					M2hv48cBjf = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = M2hv48cBjf[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554497)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(16777236));
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

	private static uint evMv9XmCBG(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint SN4vvAWweS(uint uint_0)
	{
		return 0u;
	}

	internal static void dlKvH9LxAu()
	{
	}

	[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
	internal static string gUovVvdj4I(int int_0)
	{
		int num = 322;
		byte[] array4 = default(byte[]);
		int num6 = default(int);
		int num5 = default(int);
		int num21 = default(int);
		byte[] array5 = default(byte[]);
		uint num13 = default(uint);
		uint num11 = default(uint);
		uint num20 = default(uint);
		int num22 = default(int);
		int num15 = default(int);
		int num7 = default(int);
		uint num12 = default(uint);
		int num8 = default(int);
		uint num4 = default(uint);
		byte[] array7 = default(byte[]);
		uint num14 = default(uint);
		byte[] array = default(byte[]);
		int num23 = default(int);
		byte[] array2 = default(byte[]);
		SymmetricAlgorithm object_2 = default(SymmetricAlgorithm);
		int num16 = default(int);
		byte[] array6 = default(byte[]);
		int num19 = default(int);
		uint num17 = default(uint);
		int num3 = default(int);
		int num10 = default(int);
		byte[] array3 = default(byte[]);
		int num18 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_3 = default(CryptoStream);
		uint num9 = default(uint);
		ICryptoTransform transform = default(ICryptoTransform);
		string result = default(string);
		int int_ = default(int);
		int num27 = default(int);
		int num29 = default(int);
		while (true)
		{
			if (g4rvWcC8Eu.Length == 0)
			{
				while (true)
				{
					gyDdvIR3oOUnJD1CFa5 object_ = new gyDdvIR3oOUnJD1CFa5((Stream)gYyGG1Yi0lG46hOX6p(gHcvctBPZN, "9LE0SMphdXpbBxHTRc.eTGUN24lk8sTBLmhOf"));
					while (true)
					{
						ptlW1UCTh3C26LkFZs(KbX9KTOA8RtGyG7GAD(object_), 0L);
						int num2 = 341;
						if (uQFEQ5sgpNTXQMeeYl() != null)
						{
							goto IL_0097;
						}
						goto IL_20c5;
						IL_20c5:
						while (true)
						{
							switch (num2)
							{
							case 428:
								array4[4] = 243;
								num2 = 146;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 259;
							case 259:
								array4[5] = 236;
								goto case 331;
							case 331:
								array4[5] = 84;
								goto case 258;
							case 258:
								num6 = 182;
								goto case 75;
							case 75:
								array4[5] = (byte)num6;
								goto case 97;
							case 97:
								num5 = 123;
								num = 228;
								goto case 228;
							case 228:
								array4[5] = (byte)num5;
								goto case 172;
							case 172:
								array4[5] = 0;
								num2 = 119;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 427:
								num5 = 148;
								num2 = 376;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 426:
								array4[12] = (byte)num6;
								goto case 104;
							case 104:
								num5 = 41;
								num2 = 56;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 425:
								array4[23] = 119;
								goto case 152;
							case 152:
								array4[24] = 138;
								goto case 12;
							case 12:
								num5 = 142;
								num = 140;
								goto case 140;
							case 140:
								array4[24] = (byte)num5;
								goto case 307;
							case 307:
								array4[24] = 123;
								goto case 125;
							case 125:
								array4[24] = 248;
								num2 = 86;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 277;
							case 277:
								num5 = 119;
								num2 = 370;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 133;
							case 133:
								array4[12] = 100;
								num2 = 163;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 424:
								num6 = 106;
								goto case 81;
							case 81:
								array4[10] = (byte)num6;
								goto case 192;
							case 192:
								num6 = 127;
								num2 = 7;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 15;
							case 15:
								array4[10] = (byte)num6;
								goto case 283;
							case 283:
								array4[11] = 164;
								goto case 20;
							case 20:
								num6 = 63;
								num2 = 181;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 423:
								num21 = array5.Length / 4;
								num2 = 250;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 5;
							case 5:
								num13 = (uint)((array5[num11 + 3] << 24) | (array5[num11 + 2] << 16) | (array5[num11 + 1] << 8) | array5[num11]);
								goto case 418;
							case 418:
								num20 = 255u;
								goto case 402;
							case 402:
								num22 = 0;
								goto case 375;
							case 375:
								if (num15 == num7 - 1)
								{
									num2 = 367;
									if (HTwXS7htZr43yli2FE())
									{
										continue;
									}
									goto IL_0097;
								}
								goto case 128;
							case 128:
								num12 += num13;
								goto case 324;
							case 324:
								num11 = (uint)num8;
								goto case 384;
							case 384:
								num4 = (uint)((array7[num11 + 3] << 24) | (array7[num11 + 2] << 16) | (array7[num11 + 1] << 8) | array7[num11]);
								num2 = 217;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 46;
							case 46:
							case 223:
								num14 = num12;
								goto case 338;
							case 338:
								num12 = 0u;
								goto case 24;
							case 24:
							{
								uint num24 = num14;
								uint num25 = num14;
								num25 ^= num25 << 16;
								num25 += 3025070325u;
								num25 ^= num25 << 9;
								num25 += 2057092692;
								num25 ^= num25 >> 21;
								num25 += 1971097035;
								num25 = 3396848076u + num25;
								num14 = num24 + (uint)(double)num25;
								num2 = 267;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							}
							case 422:
								array[12] = 119;
								num2 = 10;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 4;
							case 4:
								num23 = 0;
								goto case 344;
							case 344:
							case 372:
								if (num23 >= array2.Length)
								{
									goto case 413;
								}
								goto case 383;
							case 413:
								if (int_0 == -1)
								{
									goto case 391;
								}
								goto case 226;
							case 391:
								object_2 = (SymmetricAlgorithm)VQTF3T8csSNiqkBROy();
								goto case 146;
							case 146:
								cQP4hq5gmrahtaGFgT(object_2, CipherMode.CBC);
								num2 = 124;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 226:
								num16 = array7.Length % 4;
								goto case 203;
							case 203:
								num7 = array7.Length / 4;
								num = 11;
								goto case 11;
							case 11:
								array6 = new byte[array7.Length];
								num2 = 423;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 383:
								array5[num23] = (byte)(array5[num23] ^ array2[num23]);
								goto case 357;
							case 357:
								num23++;
								num2 = 372;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 46;
							case 421:
								num22 += 8;
								goto case 65;
							case 65:
								array6[num8 + num19] = (byte)((num17 & num20) >> num22);
								goto case 270;
							case 270:
								num19++;
								num2 = 378;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 69;
							case 69:
								array[13] = 109;
								num2 = 58;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 420:
								num5 = 132;
								goto case 167;
							case 167:
								array4[23] = (byte)num5;
								goto case 160;
							case 160:
								num6 = 132;
								goto case 221;
							case 221:
								array4[23] = (byte)num6;
								goto case 425;
							case 419:
								array4[11] = 19;
								num2 = 71;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 417:
								array[7] = 104;
								num2 = 227;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 416:
								array4[3] = 116;
								goto case 245;
							case 245:
								array4[3] = 148;
								num2 = 98;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 415:
								array4[7] = (byte)num6;
								goto case 109;
							case 109:
								num6 = 104;
								goto case 121;
							case 121:
								array4[7] = (byte)num6;
								goto case 35;
							case 35:
								array4[7] = 32;
								num2 = 52;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 414:
								num6 = 98;
								goto case 314;
							case 314:
								array4[26] = (byte)num6;
								goto case 44;
							case 44:
								num6 = 136;
								goto case 198;
							case 198:
								array4[26] = (byte)num6;
								goto case 9;
							case 9:
								array4[26] = 68;
								goto case 237;
							case 237:
								num6 = 148;
								goto case 219;
							case 219:
								array4[26] = (byte)num6;
								num = 107;
								goto case 107;
							case 107:
								num6 = 142;
								num2 = 340;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 412:
								array[13] = 121;
								goto case 361;
							case 361:
								array[13] = 130;
								goto case 365;
							case 365:
								array[13] = 147;
								goto case 69;
							case 411:
								array[15] = 73;
								goto case 129;
							case 129:
								array2 = array;
								num2 = 328;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 410:
								array4[27] = (byte)num6;
								num2 = 16;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 409:
								array4[13] = 168;
								goto case 93;
							case 93:
								num5 = 126;
								goto case 369;
							case 369:
								array4[13] = (byte)num5;
								num2 = 175;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 408:
								array[3] = 237;
								goto case 407;
							case 407:
								num3 = 154;
								num2 = 173;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 29;
							case 29:
								num5 = 140;
								goto case 356;
							case 356:
								array4[9] = (byte)num5;
								num2 = 31;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 70;
							case 70:
								num5 = 166;
								goto case 209;
							case 209:
								array4[9] = (byte)num5;
								num2 = 169;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 406:
								num6 = 142;
								goto case 426;
							case 405:
								array[6] = 89;
								num = 251;
								goto case 251;
							case 251:
								num3 = 75;
								goto case 353;
							case 353:
								array[6] = (byte)num3;
								goto case 295;
							case 295:
								array[7] = 86;
								num = 360;
								goto case 360;
							case 360:
								array[7] = 106;
								num = 49;
								goto case 49;
							case 49:
								array[7] = 103;
								num = 417;
								goto case 417;
							case 404:
								num3 = 162;
								goto case 389;
							case 389:
								array[0] = (byte)num3;
								goto case 217;
							case 217:
								array[0] = 22;
								goto case 154;
							case 154:
								num3 = 90;
								num2 = 323;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 403:
								array4[13] = 118;
								goto case 409;
							case 401:
								array[14] = (byte)num3;
								num = 74;
								goto case 74;
							case 74:
								num3 = 99;
								num2 = 127;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 121;
							case 400:
								array[4] = (byte)num3;
								num2 = 42;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 399:
								array4[15] = 141;
								goto case 176;
							case 176:
								array4[15] = 129;
								goto case 363;
							case 363:
								array4[16] = 119;
								num2 = 0;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto default;
							default:
								num5 = 134;
								goto case 279;
							case 279:
								array4[16] = (byte)num5;
								goto case 136;
							case 136:
								array4[16] = 151;
								num2 = 46;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 48;
							case 48:
								num6 = 126;
								goto case 343;
							case 343:
								array4[16] = (byte)num6;
								goto case 83;
							case 83:
								array4[16] = 70;
								goto case 78;
							case 78:
								num6 = 107;
								goto case 179;
							case 179:
								array4[17] = (byte)num6;
								goto case 362;
							case 362:
								num5 = 128;
								goto case 194;
							case 194:
								array4[17] = (byte)num5;
								goto case 106;
							case 106:
								array4[17] = 27;
								goto case 264;
							case 264:
								array4[17] = 215;
								goto case 134;
							case 134:
								array4[18] = 146;
								num2 = 382;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 398:
								array4[28] = 154;
								goto case 118;
							case 118:
								array4[28] = 128;
								goto case 337;
							case 337:
								array4[28] = 173;
								goto case 374;
							case 374:
								array4[28] = 63;
								num = 88;
								goto case 88;
							case 88:
								array4[28] = 223;
								goto case 274;
							case 274:
								array4[29] = 142;
								num2 = 102;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 117;
							case 117:
								array4[29] = 118;
								goto case 385;
							case 385:
								num5 = 134;
								goto case 8;
							case 8:
								array4[29] = (byte)num5;
								goto case 171;
							case 171:
								array4[30] = 64;
								goto case 153;
							case 153:
								num6 = 145;
								num2 = 293;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 397:
								array[14] = 82;
								goto case 377;
							case 377:
								array[14] = 6;
								goto case 111;
							case 111:
								array[15] = 89;
								goto case 110;
							case 110:
								array[15] = 116;
								goto case 100;
							case 100:
								num3 = 85;
								num2 = 350;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 211;
							case 211:
								array[1] = (byte)num3;
								num2 = 149;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 396:
								array[3] = 154;
								goto case 195;
							case 195:
								num3 = 63;
								num = 90;
								goto case 90;
							case 90:
								array[3] = (byte)num3;
								num = 408;
								goto case 408;
							case 395:
								num3 = 133;
								goto case 189;
							case 189:
								array[2] = (byte)num3;
								goto case 216;
							case 216:
								array[2] = 14;
								num = 306;
								goto case 306;
							case 306:
								num3 = 66;
								goto case 50;
							case 50:
								array[2] = (byte)num3;
								goto case 22;
							case 22:
								array[3] = 41;
								num2 = 396;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 394:
								num3 = 65;
								num2 = 220;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 107;
							case 393:
								num5 = 158;
								num = 247;
								goto case 247;
							case 247:
								array4[0] = (byte)num5;
								goto case 310;
							case 310:
								num6 = 89;
								goto case 232;
							case 232:
								array4[0] = (byte)num6;
								num = 37;
								goto case 37;
							case 37:
								num6 = 138;
								num2 = 297;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 392:
								array4[14] = (byte)num6;
								goto case 6;
							case 6:
								array4[14] = 125;
								goto case 86;
							case 86:
								num6 = 61;
								num2 = 37;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 41;
							case 41:
								array4[14] = (byte)num6;
								goto case 57;
							case 57:
								num5 = 161;
								num2 = 35;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 51;
							case 51:
								array4[14] = (byte)num5;
								num2 = 68;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 37;
							case 390:
								num19 = 0;
								num2 = 166;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 113;
							case 113:
								array[11] = 106;
								num = 139;
								goto case 139;
							case 139:
								num3 = 224;
								num2 = 261;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 19;
							case 19:
								array4[21] = 94;
								num2 = 288;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 388:
								num5 = 121;
								num2 = 178;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 387:
								num15 = 0;
								goto case 94;
							case 94:
							case 244:
								if (num15 >= num7)
								{
									num = 355;
									goto case 355;
								}
								goto case 213;
							case 355:
								g4rvWcC8Eu = array6;
								num2 = 242;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 213:
								num10 = num15 % num21;
								goto case 273;
							case 273:
								num8 = num15 * 4;
								num2 = 225;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 386:
								array[2] = 190;
								goto case 202;
							case 202:
								array[2] = 118;
								num2 = 351;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 382:
								array4[18] = 126;
								num2 = 210;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 381:
								array2[5] = array3[2];
								num2 = 91;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 380:
								array[10] = (byte)num3;
								num2 = 113;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 15;
							case 379:
								array[9] = 154;
								num2 = 240;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 191;
							case 191:
								num5 = 112;
								num2 = 305;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 166:
							case 378:
								if (num19 >= num16)
								{
									goto case 141;
								}
								goto case 190;
							case 141:
							case 158:
								num15++;
								num2 = 94;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 190:
								if (num19 <= 0)
								{
									goto case 65;
								}
								goto case 180;
							case 180:
								num20 <<= 8;
								num2 = 421;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 385;
							case 376:
								array4[0] = (byte)num5;
								num = 159;
								goto case 159;
							case 159:
								array4[0] = 141;
								num = 330;
								goto case 330;
							case 330:
								array4[1] = 124;
								num2 = 309;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 131;
							case 131:
								num11 = 0u;
								goto case 387;
							case 373:
								num6 = 138;
								goto case 255;
							case 255:
								array4[20] = (byte)num6;
								goto case 147;
							case 147:
								num5 = 107;
								num = 177;
								goto case 177;
							case 177:
								array4[20] = (byte)num5;
								num2 = 122;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 371:
								num4 |= array7[^(1 + num18)];
								goto case 298;
							case 298:
								num18++;
								num2 = 303;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 370:
								array4[25] = (byte)num5;
								goto case 67;
							case 67:
								array4[25] = 175;
								goto case 34;
							case 34:
								num5 = 106;
								goto case 282;
							case 282:
								array4[25] = (byte)num5;
								num2 = 60;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 50;
							case 368:
								array4[2] = 104;
								goto case 36;
							case 36:
								num6 = 162;
								goto case 231;
							case 231:
								array4[3] = (byte)num6;
								goto case 222;
							case 222:
								num5 = 108;
								goto case 53;
							case 53:
								array4[3] = (byte)num5;
								num2 = 85;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 66;
							case 66:
								num3 = 103;
								num2 = 196;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 367:
								if (num16 > 0)
								{
									num2 = 214;
									if (uQFEQ5sgpNTXQMeeYl() == null)
									{
										continue;
									}
									goto IL_0097;
								}
								goto case 128;
							case 366:
								array[4] = (byte)num3;
								num2 = 34;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 45;
							case 45:
								array[5] = 105;
								num2 = 35;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 64;
							case 64:
								array[5] = 128;
								goto case 62;
							case 62:
								array[5] = 104;
								goto case 316;
							case 316:
								array[5] = 55;
								goto case 32;
							case 32:
								array[6] = 93;
								goto case 252;
							case 252:
								array[6] = 148;
								goto case 339;
							case 339:
								num3 = 168;
								num2 = 13;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 364:
								array2[3] = array3[1];
								goto case 381;
							case 359:
								array4[18] = 136;
								goto case 84;
							case 84:
								num6 = 139;
								goto case 108;
							case 108:
								array4[18] = (byte)num6;
								goto case 230;
							case 230:
								num5 = 146;
								goto case 299;
							case 299:
								array4[19] = (byte)num5;
								num = 28;
								goto case 28;
							case 28:
								array4[19] = 99;
								num2 = 183;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 358:
								array4[21] = (byte)num5;
								num2 = 19;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 354:
								array[1] = (byte)num3;
								goto case 101;
							case 101:
								array[1] = 166;
								goto case 200;
							case 200:
								num3 = 195;
								num2 = 1;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 352:
								g4rvWcC8Eu = (byte[])vlg8Mdm4cMx3vMtV8R(stream);
								num = 332;
								goto case 332;
							case 332:
								jRqx2IuIYnqpNMXEsL(stream);
								goto case 130;
							case 130:
								jRqx2IuIYnqpNMXEsL(object_3);
								goto case 317;
							case 317:
								array7 = g4rvWcC8Eu;
								num2 = 226;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 218;
							case 218:
								array4[6] = (byte)num5;
								goto case 235;
							case 235:
								array4[6] = 243;
								num2 = 112;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 351:
								array[2] = 101;
								num2 = 395;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 350:
								array[15] = (byte)num3;
								num2 = 411;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 349:
								array4[21] = (byte)num5;
								num = 233;
								goto case 233;
							case 233:
								num5 = 63;
								num2 = 358;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 195;
							case 348:
								num3 = 115;
								num2 = 50;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 400;
							case 347:
								array[12] = 90;
								goto case 422;
							case 346:
								array4[21] = (byte)num6;
								num2 = 302;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 345:
								array5 = array4;
								goto case 144;
							case 144:
								array = new byte[16];
								num2 = 315;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 329;
							case 329:
								array[0] = 120;
								goto case 404;
							case 342:
								array4[15] = 159;
								goto case 388;
							case 341:
								array7 = (byte[])Ki6Sa1dZ4g079icB8K(object_, (int)OMy4Mffvv2TrjaOLnp(KbX9KTOA8RtGyG7GAD(object_)));
								num2 = 39;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 30;
							case 30:
								num5 = 80;
								goto case 168;
							case 168:
								array4[19] = (byte)num5;
								num2 = 373;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 64;
							case 340:
								array4[26] = (byte)num6;
								goto case 289;
							case 289:
								array4[27] = 108;
								goto case 204;
							case 204:
								num6 = 190;
								num2 = 410;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 312;
							case 312:
								num3 = 92;
								num2 = 354;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 336:
								array4[4] = (byte)num5;
								goto case 428;
							case 335:
								array[13] = 142;
								num2 = 412;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 334:
								num3 = 11;
								goto case 87;
							case 87:
								array[8] = (byte)num3;
								num = 379;
								goto case 379;
							case 333:
								num5 = 98;
								num2 = 218;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 328:
								mlNLALwO5vu0fPZHWA(array2);
								num = 243;
								goto case 243;
							case 243:
								array3 = (byte[])QnmUVESe86JLclFEXK(j8CKjgbbdWrcia9fh3(gHcvctBPZN));
								num2 = 300;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 327:
								if (num16 > 0)
								{
									num2 = 102;
									if (uQFEQ5sgpNTXQMeeYl() == null)
									{
										continue;
									}
									goto IL_0097;
								}
								goto case 131;
							case 326:
								array[8] = 182;
								num2 = 334;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 325:
								array4[1] = 111;
								num2 = 150;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 323:
								array[1] = (byte)num3;
								num2 = 319;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 91;
							case 91:
								array2[7] = array3[3];
								num2 = 280;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 34;
							case 320:
								array2[11] = array3[5];
								goto case 253;
							case 253:
								array2[13] = array3[6];
								goto case 115;
							case 115:
								array2[15] = array3[7];
								goto case 4;
							case 319:
								num3 = 122;
								goto case 211;
							case 315:
								array4[25] = (byte)num5;
								num2 = 236;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 313:
								array4[31] = (byte)num5;
								num2 = 170;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 309:
								array4[1] = 121;
								goto case 325;
							case 308:
								array4[6] = (byte)num6;
								num2 = 155;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 145;
							case 145:
								array4[11] = 103;
								num2 = 142;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 141;
							case 305:
								array4[31] = (byte)num5;
								goto case 27;
							case 27:
								num5 = 152;
								num2 = 313;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 304:
								array[9] = (byte)num3;
								goto case 285;
							case 285:
								num3 = 114;
								goto case 260;
							case 260:
								array[9] = (byte)num3;
								goto case 126;
							case 126:
								num3 = 187;
								num2 = 61;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 157;
							case 157:
								array[9] = (byte)num3;
								num2 = 18;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 54;
							case 54:
								array[10] = 154;
								goto case 291;
							case 291:
								array[10] = 155;
								goto case 164;
							case 164:
								array[10] = 151;
								num2 = 73;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 229:
							case 303:
								if (num18 >= num16)
								{
									num2 = 46;
									if (HTwXS7htZr43yli2FE())
									{
										continue;
									}
									goto IL_0097;
								}
								goto case 193;
							case 193:
								if (num18 > 0)
								{
									num2 = 7;
									if (uQFEQ5sgpNTXQMeeYl() == null)
									{
										continue;
									}
									goto IL_0097;
								}
								goto case 371;
							case 302:
								array4[22] = 196;
								num2 = 77;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 301:
								num5 = 115;
								num2 = 31;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 300:
								if (array3 == null)
								{
									goto case 4;
								}
								num2 = 23;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 271;
							case 271:
								if (array3.Length > 0)
								{
									num2 = 26;
									if (HTwXS7htZr43yli2FE())
									{
										continue;
									}
									goto IL_0097;
								}
								goto case 4;
							case 297:
								array4[0] = (byte)num6;
								goto case 427;
							case 296:
								num3 = 93;
								num2 = 304;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 294:
								TCRgsZFTLMOdYXYt1M(object_3);
								goto case 352;
							case 293:
								array4[30] = (byte)num6;
								goto case 208;
							case 208:
								array4[30] = 178;
								num2 = 55;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 30;
							case 292:
								num5 = 141;
								goto case 165;
							case 165:
								array4[26] = (byte)num5;
								goto case 414;
							case 290:
								array4[7] = (byte)num5;
								num2 = 212;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 234;
							case 234:
								array4[7] = 150;
								goto case 2;
							case 2:
								num6 = 161;
								goto case 415;
							case 288:
								num6 = 226;
								goto case 346;
							case 286:
								array4[10] = 156;
								goto case 424;
							case 284:
								num6 = 126;
								num = 174;
								goto case 174;
							case 174:
								array4[13] = (byte)num6;
								num2 = 403;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 281:
								array4 = new byte[32];
								goto case 393;
							case 280:
								array2[9] = array3[4];
								goto case 320;
							case 278:
								num12 += num13;
								goto case 265;
							case 265:
								num18 = 0;
								goto case 229;
							case 276:
								array6[num8] = (byte)(num9 & 0xFFu);
								num2 = 35;
								if (!HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 82;
							case 82:
								array6[num8 + 1] = (byte)((num9 & 0xFF00) >> 8);
								num2 = 197;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 275:
								array4[31] = (byte)num6;
								goto case 72;
							case 72:
								array4[31] = 62;
								num2 = 345;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 193;
							case 272:
								array4[27] = 145;
								goto case 186;
							case 186:
								array4[27] = 224;
								num = 138;
								goto case 138;
							case 138:
								array4[28] = 78;
								goto case 398;
							case 269:
								array4[8] = (byte)num6;
								num = 301;
								goto case 301;
							case 268:
								array4[3] = (byte)num6;
								goto case 47;
							case 47:
								array4[3] = 120;
								num = 416;
								goto case 416;
							case 267:
								num12 = num14;
								num = 239;
								goto case 239;
							case 239:
								if (num15 == num7 - 1)
								{
									goto case 205;
								}
								goto case 33;
							case 205:
								if (num16 > 0)
								{
									goto case 23;
								}
								goto case 33;
							case 23:
								num17 = num12 ^ num4;
								num2 = 390;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 212;
							case 212:
								array4[20] = (byte)num5;
								goto case 21;
							case 21:
								num5 = 112;
								num2 = 349;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 264;
							case 33:
								num9 = num12 ^ num4;
								num2 = 276;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 266:
								array[8] = (byte)num3;
								num2 = 326;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 72;
							case 263:
								array4[4] = (byte)num6;
								goto case 18;
							case 18:
								num5 = 98;
								goto case 336;
							case 262:
								array6[num8 + 3] = (byte)((num9 & 0xFF000000u) >> 24);
								goto case 141;
							case 261:
								array[11] = (byte)num3;
								goto case 132;
							case 132:
								array[11] = 177;
								goto case 66;
							case 257:
								num6 = 113;
								goto case 207;
							case 207:
								array4[31] = (byte)num6;
								num2 = 38;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 23;
							case 256:
								array4[6] = 170;
								goto case 249;
							case 249:
								num6 = 155;
								goto case 308;
							case 254:
								array4[2] = 110;
								goto case 120;
							case 120:
								num5 = 100;
								goto case 40;
							case 40:
								array4[2] = (byte)num5;
								goto case 368;
							case 250:
								num12 = 0u;
								goto case 185;
							case 185:
								num13 = 0u;
								goto case 103;
							case 103:
								num4 = 0u;
								goto case 327;
							case 248:
								array4[15] = 214;
								goto case 148;
							case 148:
								array4[15] = 165;
								num2 = 399;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 246:
								array[3] = (byte)num3;
								goto case 348;
							case 241:
								object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
								num = 187;
								goto case 187;
							case 187:
								hv2lmBNouPVsSWPkbC(object_3, array7, 0, array7.Length);
								goto case 294;
							case 240:
								num3 = 104;
								goto case 14;
							case 14:
								array[9] = (byte)num3;
								num2 = 296;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 238:
								num6 = 52;
								goto case 162;
							case 162:
								array4[22] = (byte)num6;
								num2 = 420;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 270;
							case 236:
								array4[25] = 231;
								goto case 292;
							case 227:
								num3 = 106;
								num2 = 266;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 225:
								num11 = (uint)(num10 * 4);
								num = 5;
								goto case 5;
							case 224:
								array4[9] = (byte)num5;
								num2 = 29;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 16;
							case 16:
								num6 = 152;
								num2 = 80;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 22;
							case 220:
								array[4] = (byte)num3;
								num = 99;
								goto case 99;
							case 99:
								num3 = 69;
								goto case 366;
							case 215:
								num6 = 99;
								goto case 269;
							case 214:
								num4 = 0u;
								num2 = 278;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 210:
								num6 = 183;
								goto case 89;
							case 89:
								array4[18] = (byte)num6;
								num2 = 359;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 229;
							case 206:
								num5 = 98;
								goto case 224;
							case 201:
								array[13] = (byte)num3;
								goto case 335;
							case 199:
								array4[22] = (byte)num5;
								goto case 238;
							case 197:
								array6[num8 + 2] = (byte)((num9 & 0xFF0000) >> 16);
								goto case 262;
							case 196:
								array[12] = (byte)num3;
								goto case 347;
							case 188:
								num6 = 49;
								num2 = 263;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 184:
								do
								{
									array4[13] = 184;
									num2 = 284;
								}
								while (!HTwXS7htZr43yli2FE());
								continue;
							case 183:
								array4[19] = 117;
								num2 = 30;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 15;
							case 182:
								num3 = 2;
								goto case 246;
							case 181:
								array4[11] = (byte)num6;
								goto case 61;
							case 61:
								num5 = 138;
								goto case 79;
							case 79:
								array4[11] = (byte)num5;
								goto case 145;
							case 178:
								array4[15] = (byte)num5;
								goto case 248;
							case 175:
								array4[13] = 227;
								goto case 156;
							case 156:
								array4[14] = 90;
								goto case 123;
							case 123:
								num6 = 145;
								goto case 392;
							case 173:
								array[3] = (byte)num3;
								num2 = 182;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 170:
								num5 = 153;
								goto case 114;
							case 114:
								array4[31] = (byte)num5;
								num2 = 257;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 169;
							case 169:
								array4[9] = 121;
								num = 96;
								goto case 96;
							case 96:
								array4[9] = 41;
								num2 = 3;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 25;
							case 25:
								array4[10] = 160;
								goto case 63;
							case 63:
								array4[10] = 88;
								goto case 286;
							case 163:
								array4[12] = 82;
								goto case 43;
							case 43:
								array4[12] = 38;
								goto case 184;
							case 161:
								stream = (Stream)bxOZrM7yjWfrLxJ03L();
								num2 = 241;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 155:
								array4[6] = 154;
								num2 = 333;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 151:
								array4[8] = (byte)num6;
								num2 = 215;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 168;
							case 150:
								num6 = 135;
								goto case 137;
							case 137:
								array4[1] = (byte)num6;
								goto case 143;
							case 143:
								array4[1] = 66;
								goto case 254;
							case 149:
								array[1] = 164;
								num2 = 312;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 135;
							case 135:
								array4[20] = 91;
								num2 = 92;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 142:
								array4[11] = 99;
								num2 = 419;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 127:
								array[14] = (byte)num3;
								num2 = 397;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto case 251;
							case 124:
								transform = (ICryptoTransform)pgmM0pZ9iIS86C2scd(object_2, array5, array2);
								num2 = 15;
								if (uQFEQ5sgpNTXQMeeYl() != null)
								{
									continue;
								}
								goto case 161;
							case 122:
								array4[20] = 104;
								num2 = 135;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 119:
								array4[6] = 196;
								num2 = 256;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 116:
								num5 = 8;
								goto case 212;
							case 112:
								num5 = 67;
								goto case 105;
							case 105:
								array4[7] = (byte)num5;
								num2 = 95;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 102:
								num7++;
								goto case 131;
							case 98:
								array4[4] = 40;
								goto case 188;
							case 95:
								num5 = 141;
								num2 = 290;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 92:
								array4[20] = 115;
								num = 116;
								goto case 116;
							case 85:
								num6 = 141;
								num2 = 268;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto case 203;
							case 80:
								array4[27] = (byte)num6;
								goto case 272;
							case 77:
								num5 = 143;
								goto case 199;
							case 76:
								array4[25] = (byte)num6;
								goto case 3;
							case 3:
								num5 = 149;
								goto case 315;
							case 73:
								num3 = 144;
								num = 380;
								goto case 380;
							case 71:
								array4[12] = 60;
								goto case 406;
							case 68:
								array4[14] = 237;
								goto case 342;
							case 60:
								num6 = 135;
								num2 = 76;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 58:
								num3 = 95;
								goto case 401;
							case 56:
								array4[12] = (byte)num5;
								num2 = 133;
								if (uQFEQ5sgpNTXQMeeYl() == null)
								{
									continue;
								}
								goto IL_0097;
							case 55:
								array4[30] = 124;
								goto case 191;
							case 52:
								num6 = 94;
								num = 151;
								goto case 151;
							case 42:
								array[4] = 108;
								num2 = 394;
								if (HTwXS7htZr43yli2FE())
								{
									continue;
								}
								goto IL_0097;
							case 39:
								g3UF2Q6kbPIJ95Ju1K(object_);
								goto case 281;
							case 38:
								num6 = 126;
								goto case 275;
							case 31:
								array4[8] = (byte)num5;
								goto case 206;
							case 26:
								array2[1] = array3[0];
								goto case 364;
							case 17:
								array[6] = 123;
								goto case 405;
							case 13:
								array[6] = (byte)num3;
								goto case 17;
							case 10:
								num3 = 183;
								goto case 201;
							case 7:
								num4 <<= 8;
								num = 371;
								goto case 371;
							case 1:
								array[1] = (byte)num3;
								goto case 386;
							case 287:
								break;
							case 59:
								goto end_IL_2783;
							case 322:
								goto end_IL_27ad;
							case 242:
							case 321:
								goto IL_27ce;
							case 311:
								goto IL_27db;
							case 318:
								goto end_IL_27c5;
							}
							break;
						}
						continue;
						IL_0097:
						num2 = num;
						goto IL_20c5;
						continue;
						end_IL_2783:
						break;
					}
					continue;
					end_IL_27ad:
					break;
				}
				continue;
			}
			goto IL_27ce;
			IL_27db:
			try
			{
				mZKkge08rIOeO3gUbX();
				int num26 = 0;
				if (uQFEQ5sgpNTXQMeeYl() != null)
				{
					goto IL_2813;
				}
				goto IL_2817;
				IL_2817:
				do
				{
					switch (num26)
					{
					case 1:
						return result;
					}
					result = (string)tVhnnscB8D7nDRk7Q6(sSfGryV9DBD7Pwsqg5(), g4rvWcC8Eu, int_0 + 4, int_);
					num26 = 1;
				}
				while (HTwXS7htZr43yli2FE());
				goto IL_2813;
				IL_2813:
				num26 = num27;
				goto IL_2817;
			}
			catch
			{
				int num28 = 0;
				if (!HTwXS7htZr43yli2FE())
				{
					num28 = num29;
				}
				switch (num28)
				{
				}
			}
			break;
			IL_27ce:
			int_ = JbJuNM9YH0xOZh7XrA(g4rvWcC8Eu, int_0);
			goto IL_27db;
			continue;
			end_IL_27c5:
			break;
		}
		return "";
	}

	[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
	internal static string yDEvntAXx8(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int E8BvC52D4c()
	{
		return 5;
	}

	private static void DRuvB7sPFm()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate WdDvgRWDY0(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(16777310)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(16777250)),
			Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(16777257))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object PN0vmgFP57(object object_0)
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

	private static IntPtr WAEvMu8Tk3(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (fWAHaqAB3M == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			fWAHaqAB3M = (cfjCamRXiZdKE74kAn1)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554506)));
		}
		return fWAHaqAB3M(intptr_0, string_0, uint_0);
	}

	private static IntPtr PhuvqdP6JL(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (XVZH9SMlXm == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			XVZH9SMlXm = (E5kLfqRGmReKNiaGQqM)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554507)));
		}
		return XVZH9SMlXm(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int THlvSaQp0U(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (w1nHvrmiyo == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			w1nHvrmiyo = (iHm3UVR8hUunqANcLXv)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554508)));
		}
		return w1nHvrmiyo(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int WfCvrNhkTA(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (wyIHHy4P79 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			wyIHHy4P79 = (Ib2v6BRPFrgiWqPgttK)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554509)));
		}
		return wyIHHy4P79(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr SRCvtOPekP(uint uint_0, int int_0, uint uint_1)
	{
		if (cXaHV8eLsj == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			cXaHV8eLsj = (K03MmRRc6ZiX5WXYS2v)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554510)));
		}
		return cXaHV8eLsj(uint_0, int_0, uint_1);
	}

	private static int QUovIduGsI(IntPtr intptr_0)
	{
		if (UFOHng2yMa == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			UFOHng2yMa = (WliFNORheTkUq8awgRj)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(RfHjVHRe7jq1PgnsRwN.zl0IH7UDOAV3O(33554511)));
		}
		return UFOHng2yMa(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (pZCHCwNOmf == IntPtr.Zero)
		{
			pZCHCwNOmf = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return pZCHCwNOmf;
	}

	[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
	private static byte[] wjgvTvFN8w(string string_0)
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

	internal static Stream WhTvuY4xjL()
	{
		return new MemoryStream();
	}

	internal static byte[] su5vDQXiEt(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[zIo4guRE2uK7VILXxPT(typeof(zIo4guRE2uK7VILXxPT.iNapgeR0kBknmLPBsfP<object>[]))]
	private static byte[] yZZvENxalM(byte[] byte_0)
	{
		Stream stream = WhTvuY4xjL();
		SymmetricAlgorithm symmetricAlgorithm = KbP9Qx9qxm();
		symmetricAlgorithm.Key = new byte[32]
		{
			99, 172, 59, 210, 35, 244, 222, 16, 126, 228,
			147, 57, 200, 39, 2, 99, 117, 113, 215, 11,
			233, 146, 8, 29, 163, 12, 215, 34, 201, 88,
			219, 21
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			56, 37, 118, 252, 125, 158, 241, 61, 39, 21,
			230, 193, 182, 73, 13, 62
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = su5vDQXiEt(stream);
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		return result;
	}

	private byte[] Dk9v0XZcXj()
	{
		return null;
	}

	private byte[] vg5vLWY9KG()
	{
		return null;
	}

	private byte[] v9EvAAHw6V()
	{
		return null;
	}

	private byte[] Owrv25dCGX()
	{
		return null;
	}

	private byte[] vaDvfwqpmo()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] nnev1AWPUU()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] NBOv33F5KC()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] xJDvXG7Wqa()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] gHYvGQHCEG()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] GcVv8AUCHN()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object gYyGG1Yi0lG46hOX6p(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object KbX9KTOA8RtGyG7GAD(object object_0)
	{
		return ((gyDdvIR3oOUnJD1CFa5)object_0).KDikMXewCI();
	}

	internal static void ptlW1UCTh3C26LkFZs(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long OMy4Mffvv2TrjaOLnp(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object Ki6Sa1dZ4g079icB8K(object object_0, int int_0)
	{
		return ((gyDdvIR3oOUnJD1CFa5)object_0).etZHN6xq1q(int_0);
	}

	internal static void g3UF2Q6kbPIJ95Ju1K(object object_0)
	{
		((gyDdvIR3oOUnJD1CFa5)object_0).He9HqDgDsF();
	}

	internal static void mlNLALwO5vu0fPZHWA(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object j8CKjgbbdWrcia9fh3(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object QnmUVESe86JLclFEXK(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object VQTF3T8csSNiqkBROy()
	{
		return KbP9Qx9qxm();
	}

	internal static void cQP4hq5gmrahtaGFgT(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object pgmM0pZ9iIS86C2scd(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object bxOZrM7yjWfrLxJ03L()
	{
		return WhTvuY4xjL();
	}

	internal static void hv2lmBNouPVsSWPkbC(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void TCRgsZFTLMOdYXYt1M(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object vlg8Mdm4cMx3vMtV8R(object object_0)
	{
		return su5vDQXiEt((Stream)object_0);
	}

	internal static void jRqx2IuIYnqpNMXEsL(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int JbJuNM9YH0xOZh7XrA(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void mZKkge08rIOeO3gUbX()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
	}

	internal static object sSfGryV9DBD7Pwsqg5()
	{
		return Encoding.Unicode;
	}

	internal static object tVhnnscB8D7nDRk7Q6(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool HTwXS7htZr43yli2FE()
	{
		return (object)null == null;
	}

	internal static object uQFEQ5sgpNTXQMeeYl()
	{
		return null;
	}

	internal static void x1MAhbgwdmQOfI2hqe()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
	}

	internal static void NfnoO89lB5sNXo8HkO(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type GyM8yAngXhkT5E2BjG(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object A5298IFIy5HYsNDreo(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int wlYAsU0DNmRqSACLY3(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object OIm9WwigSr5Xspf0aP()
	{
		return SHA1.Create();
	}

	internal static object FncCped7ih4uuMGKWX(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool Yd6TI9D3leNPaNLDdN(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object puUaj28pcuJR4Jd32X(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object hsvZpdHZKsi3GH8Qs5(object object_0)
	{
		return ((gyDdvIR3oOUnJD1CFa5)object_0).KDikMXewCI();
	}

	internal static void aoDKmotxiwTFZt2Dyn(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long xOYJLtwUOp5JdnYw6l(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object bpojGUYtOrEiQ7fi2I(object object_0, int int_0)
	{
		return ((gyDdvIR3oOUnJD1CFa5)object_0).etZHN6xq1q(int_0);
	}

	internal static object k3LPsJO5MJfQWJ1c6n()
	{
		return KbP9Qx9qxm();
	}

	internal static void GeV2X9qu2PQcoil7GV(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object HGTaCjowiqrKWGFEEy(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object eJbJeoc09DR7MP3Nxn()
	{
		return WhTvuY4xjL();
	}

	internal static void XrS0721BT959OaOZOl(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void O7kYuKQDV5unnENG8Q(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object dcv1mSSnb1xkRDQJUg()
	{
		return Encoding.UTF8;
	}

	internal static object Nh7UAOC99EbwVYWcyR(object object_0)
	{
		return su5vDQXiEt((Stream)object_0);
	}

	internal static object yQ32YUMVsTAyqHDjqC(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void z3Y9yBbGOIRQrb53oo(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void ItXomI6309uAvuAIq1(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void lq13Irr6enbVkD3QFA(object object_0)
	{
		((gyDdvIR3oOUnJD1CFa5)object_0).He9HqDgDsF();
	}

	internal static void skRDuNXmruXyB3m9aD(object object_0, object object_1, uint uint_0, object object_2)
	{
		nkB9xHMgGR((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort LKnp3ZalLK69jRCu5P(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int k0c0riLXoIodtdq5cj(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void CObT5XUtgV68YeC35o(object object_0, object object_1, int int_0, int int_1)
	{
		nVf9zsoM1w((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long I3d2FRKJWjm8tncXMg(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint wUXyQcP0sR0PuTZuQZ(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint YKqXYZAdSmCwwHZ2A7(uint uint_0, int int_0, long long_0, object object_0)
	{
		return d8QvULCqrn(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long vcte99WR5r2i9dcQ6c(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object VuZm1dsv3gHwYyL7F5(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object LoZEBXhxCbU7exYHZa(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void vRlAVbNpJxm13ikOel(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object GNdL17yf9PuMPXx8Ta(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool iC9IIcfMcvpsoU6ZqH(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object b6Qb4Kl9EUI7I60VTo(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object rIiPSZGYUrutUMEFCU(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object YVyR5dpWPnBWGrfgGS(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool bDfEwr2yJegPEMS6fl()
	{
		return (object)null == null;
	}

	internal static object TuttsdI5ZB1Vxm841E()
	{
		return null;
	}
}
