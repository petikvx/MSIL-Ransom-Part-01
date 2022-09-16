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
using CIsnTIXy9sPh8UU7vK;

namespace ROQqnk2t712HZZ9CK6;

internal class KWvNjAdNupjAV7UgSV
{
	private delegate void Xt2NLoIZA8wlKTcSef(object o);

	internal class iW5nWspQE6hJ9osJaM : Attribute
	{
		internal class Q5T4bllOm2CTdC9wdn<A6giBnveYULBfNrP4i>
		{
			public Q5T4bllOm2CTdC9wdn()
			{
				FwnbpF40QRXGKbD08B.TpLjPRfzSfIkW();
				base._002Ector();
			}
		}

		[iW5nWspQE6hJ9osJaM(typeof(Q5T4bllOm2CTdC9wdn<object>[]))]
		public iW5nWspQE6hJ9osJaM(object object_0)
		{
		}
	}

	internal class EC0mMILm1qhqU5pSgF
	{
		[iW5nWspQE6hJ9osJaM(typeof(iW5nWspQE6hJ9osJaM.Q5T4bllOm2CTdC9wdn<object>[]))]
		internal static string U4ejZDpamq(string string_0, string string_1)
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
			byte[] iV = QnWHsQE6h(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = sLoCZA8wl();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint lvbGLIJLsWhhPg5W8y(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr hSIrLiCy05yjOoCUT6();

	internal struct x1PMU51x79ytu3O4Wg
	{
		internal bool jlUj0Z8caM;

		internal byte[] xwYjxn846d;
	}

	internal class vXcJ9MHSbdRQQJds4v
	{
		private BinaryReader WNQjGHxRdM;

		public vXcJ9MHSbdRQQJds4v(Stream stream_0)
		{
			WNQjGHxRdM = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream RgtTUJcyZL()
		{
			return WNQjGHxRdM.BaseStream;
		}

		internal byte[] aNQjS1U8FA(int int_0)
		{
			return WNQjGHxRdM.ReadBytes(int_0);
		}

		internal int HG8j6laabx(byte[] byte_0, int int_0, int int_1)
		{
			return WNQjGHxRdM.Read(byte_0, int_0, int_1);
		}

		internal int SEwjmfN8CR()
		{
			return WNQjGHxRdM.ReadInt32();
		}

		internal void A1xjbF2aAi()
		{
			WNQjGHxRdM.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr exZt3WEPjnC99BG2vk(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr gNZeIgkcOXv3CNcf3F(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int NdiDomKBHIsZnig6Fj(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int eI2gKcDSQvNjnYnsqm(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr eLpGAMTKBvp6aXtDkA(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int fh0n8qMUM6f5o2ZG9h(IntPtr ptr);

	[Flags]
	private enum dsiAdlNoNppQ4fadGn
	{

	}

	private static uint[] vPLe7Uk9D;

	private static bool EgkfUT8l8;

	private static Dictionary<int, int> VnNVv8Lx4;

	private static byte[] kXBOL8Rkf;

	private static IntPtr yDIzei2mW;

	private static int[] Rsqj75C5Cs;

	private static int KSUjIwBK7G;

	internal static lvbGLIJLsWhhPg5W8y PpijleIIAy;

	private static long OHOjL8IUrG;

	private static bool UuijCg4NHq;

	internal static Hashtable k5cjKD7IaN;

	private static NdiDomKBHIsZnig6Fj zG1jMhCyAv;

	private static fh0n8qMUM6f5o2ZG9h QlYjXM4ZZL;

	private static int oQUjFpEmDK;

	private static SortedList hFHj216Y4p;

	private static eLpGAMTKBvp6aXtDkA seoj4SXgii;

	private static eI2gKcDSQvNjnYnsqm nYojNaFYqT;

	private static long QocjpbihcR;

	private static object V9TjjxpWtM;

	private static byte[] sZVtjfYHu;

	private static IntPtr TfkjEJGC0L;

	private static int H61jHeJaoy;

	private static bool D7TiUG7Y1;

	private static int YRfjJbH5ur;

	internal static lvbGLIJLsWhhPg5W8y yYLjvXksy8;

	private static bool sQ4j1YDrmt;

	internal static RSACryptoServiceProvider lVWhjDo0Y;

	[iW5nWspQE6hJ9osJaM(typeof(iW5nWspQE6hJ9osJaM.Q5T4bllOm2CTdC9wdn<object>[]))]
	private static bool XNcjk30CWO;

	private static gNZeIgkcOXv3CNcf3F akvjT5QV1v;

	private static byte[] LrSre3VVh;

	internal static Assembly o72RJO5QG;

	private static IntPtr iWmjqxtSQ0;

	private static exZt3WEPjnC99BG2vk fYbjDZvkT5;

	private static IntPtr a53jyq3wBU;

	private static bool CbSjd6sALb;

	private static object hrSPSJWD9;

	static KWvNjAdNupjAV7UgSV()
	{
		o72RJO5QG = typeof(KWvNjAdNupjAV7UgSV).Assembly;
		vPLe7Uk9D = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		EgkfUT8l8 = false;
		D7TiUG7Y1 = false;
		LrSre3VVh = new byte[0];
		lVWhjDo0Y = null;
		VnNVv8Lx4 = null;
		hrSPSJWD9 = new object();
		kXBOL8Rkf = new byte[0];
		sZVtjfYHu = new byte[0];
		yDIzei2mW = IntPtr.Zero;
		iWmjqxtSQ0 = IntPtr.Zero;
		V9TjjxpWtM = new string[0];
		Rsqj75C5Cs = new int[0];
		oQUjFpEmDK = 1;
		CbSjd6sALb = false;
		hFHj216Y4p = new SortedList();
		KSUjIwBK7G = 0;
		QocjpbihcR = 0L;
		PpijleIIAy = null;
		yYLjvXksy8 = null;
		OHOjL8IUrG = 0L;
		YRfjJbH5ur = 0;
		UuijCg4NHq = false;
		sQ4j1YDrmt = false;
		H61jHeJaoy = 0;
		TfkjEJGC0L = IntPtr.Zero;
		XNcjk30CWO = false;
		k5cjKD7IaN = new Hashtable();
		fYbjDZvkT5 = null;
		akvjT5QV1v = null;
		zG1jMhCyAv = null;
		nYojNaFYqT = null;
		seoj4SXgii = null;
		QlYjXM4ZZL = null;
		a53jyq3wBU = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void FbPjPRf9lrrSD()
	{
	}

	internal static byte[] cx02R3OLB(byte[] byte_0)
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
			vesIelfpl(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			vesIelfpl(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			vesIelfpl(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			vesIelfpl(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			vesIelfpl(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			vesIelfpl(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			vesIelfpl(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			vesIelfpl(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			vesIelfpl(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			vesIelfpl(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			vesIelfpl(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			vesIelfpl(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			vesIelfpl(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			vesIelfpl(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			vesIelfpl(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			vesIelfpl(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			h1QpoWvNj(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			h1QpoWvNj(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			h1QpoWvNj(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			h1QpoWvNj(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			h1QpoWvNj(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			h1QpoWvNj(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			h1QpoWvNj(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			h1QpoWvNj(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			h1QpoWvNj(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			h1QpoWvNj(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			h1QpoWvNj(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			h1QpoWvNj(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			h1QpoWvNj(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			h1QpoWvNj(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			h1QpoWvNj(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			h1QpoWvNj(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			ONulpjAV7(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			ONulpjAV7(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			ONulpjAV7(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			ONulpjAV7(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			ONulpjAV7(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			ONulpjAV7(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			ONulpjAV7(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			ONulpjAV7(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			ONulpjAV7(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			ONulpjAV7(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			ONulpjAV7(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			ONulpjAV7(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			ONulpjAV7(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			ONulpjAV7(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			ONulpjAV7(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			ONulpjAV7(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			IgSvVROQq(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			IgSvVROQq(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			IgSvVROQq(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			IgSvVROQq(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			IgSvVROQq(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			IgSvVROQq(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			IgSvVROQq(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			IgSvVROQq(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			IgSvVROQq(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			IgSvVROQq(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			IgSvVROQq(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			IgSvVROQq(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			IgSvVROQq(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			IgSvVROQq(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			IgSvVROQq(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			IgSvVROQq(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void vesIelfpl(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + HktL712HZ(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + vPLe7Uk9D[uint_5 - 1], ushort_0);
	}

	private static void h1QpoWvNj(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + HktL712HZ(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + vPLe7Uk9D[uint_5 - 1], ushort_0);
	}

	private static void ONulpjAV7(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + HktL712HZ(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + vPLe7Uk9D[uint_5 - 1], ushort_0);
	}

	private static void IgSvVROQq(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + HktL712HZ(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + vPLe7Uk9D[uint_5 - 1], ushort_0);
	}

	private static uint HktL712HZ(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool v9CJK6Ot2()
	{
		if (!EgkfUT8l8)
		{
			oTc1SefLW();
			EgkfUT8l8 = true;
		}
		return D7TiUG7Y1;
	}

	internal static SymmetricAlgorithm sLoCZA8wl()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (v9CJK6Ot2())
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")!.Unwrap();
			}
			catch
			{
				return new RijndaelManaged();
			}
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

	internal static void oTc1SefLW()
	{
		try
		{
			new RijndaelManaged();
			D7TiUG7Y1 = false;
		}
		catch
		{
			D7TiUG7Y1 = true;
		}
	}

	internal static byte[] QnWHsQE6h(byte[] byte_0)
	{
		if (!v9CJK6Ot2())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return cx02R3OLB(byte_0);
	}

	internal static void j9oEsJaMR(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			QT4kblOm2(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void QT4kblOm2(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint kTdKC9wdn(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	public static void A6gDiBneY(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (VnNVv8Lx4 == null)
			{
				lock (hrSPSJWD9)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(KWvNjAdNupjAV7UgSV).Assembly.GetManifestResourceStream("he74mu29SfYb2C1IZF.GaHocXhwwqCVEHK1ku"));
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
							num3 += lqhNqU5pS(num3);
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
						vXcJ9MHSbdRQQJds4v vXcJ9MHSbdRQQJds4v = new vXcJ9MHSbdRQQJds4v(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = vXcJ9MHSbdRQQJds4v.SEwjmfN8CR();
							int value = vXcJ9MHSbdRQQJds4v.SEwjmfN8CR();
							dictionary.Add(key, value);
						}
						vXcJ9MHSbdRQQJds4v.A1xjbF2aAi();
					}
					VnNVv8Lx4 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = VnNVv8Lx4[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(KWvNjAdNupjAV7UgSV).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = typeof(object);
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

	private static uint TaCM0mMIm(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint lqhNqU5pS(uint uint_0)
	{
		return 0u;
	}

	internal static void GFH4vbGLI()
	{
	}

	[iW5nWspQE6hJ9osJaM(typeof(iW5nWspQE6hJ9osJaM.Q5T4bllOm2CTdC9wdn<object>[]))]
	internal static string isWXhhPg5(int int_0)
	{
		int num = 376;
		vXcJ9MHSbdRQQJds4v object_ = default(vXcJ9MHSbdRQQJds4v);
		uint num24 = default(uint);
		byte[] array = default(byte[]);
		int num15 = default(int);
		int num20 = default(int);
		int num14 = default(int);
		uint num6 = default(uint);
		uint num18 = default(uint);
		uint num16 = default(uint);
		int num11 = default(int);
		int num5 = default(int);
		byte[] array7 = default(byte[]);
		int num21 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num22 = default(int);
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		int num23 = default(int);
		uint num8 = default(uint);
		byte[] array3 = default(byte[]);
		int num13 = default(int);
		byte[] array5 = default(byte[]);
		int num17 = default(int);
		uint num9 = default(uint);
		uint num19 = default(uint);
		int num10 = default(int);
		uint num12 = default(uint);
		CryptoStream object_3 = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_2 = default(SymmetricAlgorithm);
		string result = default(string);
		int int_ = default(int);
		int num4 = default(int);
		while (true)
		{
			IL_28aa:
			if (kXBOL8Rkf.Length != 0)
			{
				goto IL_071a;
			}
			goto IL_287f;
			IL_287f:
			object_ = new vXcJ9MHSbdRQQJds4v((Stream)g5Z005QLVVsdDSE98Y(o72RJO5QG, "S6Spcmbsyi9Zy5rP0O.TdSsGlmMAWb1UwCa7w"));
			int num2 = 268;
			if (!FbKAVPcYhQlScsBVES())
			{
				goto IL_0022;
			}
			goto IL_21c8;
			IL_21c8:
			while (true)
			{
				switch (num2)
				{
				case 426:
					num8 = num24;
					num2 = 262;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 425:
					array[27] = 88;
					num2 = 237;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 424:
					if (num15 == num20 - 1)
					{
						goto case 350;
					}
					goto case 110;
				case 350:
					if (num14 > 0)
					{
						goto case 327;
					}
					goto case 110;
				case 327:
					num6 = 0u;
					num2 = 415;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 217;
				case 217:
					array[13] = 92;
					goto case 265;
				case 265:
					array[13] = 90;
					goto case 25;
				case 25:
					array[13] = 207;
					num2 = 401;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 110:
					num8 += num18;
					goto case 66;
				case 66:
					num16 = (uint)num11;
					num2 = 304;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 126;
				case 126:
					array[19] = (byte)num5;
					num2 = 223;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 423:
					num5 = 182;
					goto case 379;
				case 379:
					array[13] = (byte)num5;
					goto case 402;
				case 402:
					array[13] = 124;
					goto case 217;
				case 32:
					array7[num21] = (byte)(array7[num21] ^ array6[num21]);
					goto case 307;
				case 307:
					num21++;
					goto case 228;
				case 228:
				case 422:
					if (num21 < array6.Length)
					{
						goto case 32;
					}
					goto case 355;
				case 355:
					if (int_0 == -1)
					{
						num2 = 1;
						if (FbKAVPcYhQlScsBVES())
						{
							continue;
						}
						goto IL_0022;
					}
					goto case 359;
				case 359:
					num14 = array4.Length % 4;
					goto case 81;
				case 81:
					num20 = array4.Length / 4;
					num2 = 71;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 421:
					num22 = array7.Length / 4;
					goto case 331;
				case 331:
					num8 = 0u;
					num = 88;
					goto case 88;
				case 88:
					num18 = 0u;
					num2 = 9;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 6;
				case 6:
					num5 = 113;
					num = 243;
					goto case 243;
				case 243:
					array[30] = (byte)num5;
					goto case 100;
				case 100:
					num5 = 110;
					goto case 239;
				case 239:
					array[30] = (byte)num5;
					goto case 80;
				case 80:
					num5 = 164;
					num = 206;
					goto case 206;
				case 206:
					array[30] = (byte)num5;
					num = 285;
					goto case 285;
				case 285:
					array[31] = 207;
					goto case 187;
				case 187:
					array[31] = 95;
					num2 = 418;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 420:
					array[15] = 110;
					goto case 73;
				case 73:
					array[15] = 228;
					num2 = 216;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 163;
				case 163:
					array[3] = 160;
					goto case 273;
				case 273:
					array[4] = 143;
					num = 341;
					goto case 341;
				case 341:
					array[4] = 157;
					goto case 198;
				case 198:
					num5 = 124;
					num2 = 79;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 419:
					array2[15] = (byte)num7;
					num2 = 138;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 418:
					array[31] = 40;
					num2 = 148;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 35;
				case 35:
					array4 = (byte[])S1BcrX62TNYMC0tZ9A(object_, (int)SLl48rrkqZOQwyTQMf(jLhBESTw2FQF41obd0(object_)));
					num2 = 209;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 417:
					num7 = 100;
					num = 202;
					goto case 202;
				case 202:
					array2[9] = (byte)num7;
					goto case 295;
				case 295:
					array2[9] = 200;
					num2 = 197;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 408;
				case 408:
					num7 = 46;
					goto case 336;
				case 336:
					array2[9] = (byte)num7;
					goto case 399;
				case 399:
					array2[9] = 86;
					num2 = 139;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_287f;
				case 416:
					num5 = 88;
					num2 = 246;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 415:
					num8 += num18;
					goto case 50;
				case 50:
					num23 = 0;
					num = 272;
					goto case 272;
				case 145:
					if (num23 > 0)
					{
						num = 72;
						goto case 72;
					}
					goto case 240;
				case 72:
					num6 <<= 8;
					num = 240;
					goto case 240;
				case 240:
					num6 |= array4[^(1 + num23)];
					goto case 326;
				case 326:
					num23++;
					goto case 272;
				case 272:
				case 339:
					if (num23 < num14)
					{
						goto case 145;
					}
					num = 303;
					goto case 192;
				case 192:
				case 303:
					num24 = num8;
					goto case 19;
				case 19:
					num8 = 0u;
					num = 201;
					goto case 201;
				case 201:
				{
					uint num25 = num24;
					uint num26 = num24;
					num26 ^= num26 << 7;
					num26 += 1663089362;
					num26 ^= num26 >> 9;
					num26 += 280649241;
					num26 ^= num26 << 5;
					num26 += 3294850905u;
					num26 = 2058170982 - num26;
					num24 = num25 + (uint)(double)num26;
					num = 426;
					goto case 426;
				}
				case 414:
					num7 = 130;
					goto case 394;
				case 394:
					array2[12] = (byte)num7;
					num2 = 231;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 413:
					array[1] = (byte)num5;
					goto case 147;
				case 147:
					array[1] = 152;
					goto case 290;
				case 290:
					array[1] = 89;
					goto case 162;
				case 162:
					array[1] = 130;
					goto case 28;
				case 28:
					array[1] = 210;
					goto case 85;
				case 85:
					num5 = 109;
					num2 = 320;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 319;
				case 319:
					num5 = 129;
					num = 367;
					goto case 367;
				case 367:
					array[28] = (byte)num5;
					num = 281;
					goto case 281;
				case 281:
					num5 = 150;
					num2 = 92;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 16;
				case 16:
					array6[1] = array3[0];
					goto case 33;
				case 33:
					array6[3] = array3[1];
					goto case 21;
				case 21:
					array6[5] = array3[2];
					num = 176;
					goto case 176;
				case 176:
					array6[7] = array3[3];
					num2 = 123;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 412:
					num5 = 158;
					goto case 390;
				case 390:
					array[25] = (byte)num5;
					num = 251;
					goto case 251;
				case 251:
					array[25] = 159;
					goto case 23;
				case 23:
					num5 = 50;
					goto case 189;
				case 189:
					array[25] = (byte)num5;
					num2 = 12;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 15;
				case 15:
					array[26] = 109;
					num = 120;
					goto case 120;
				case 120:
					num5 = 14;
					num2 = 308;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 411:
					array[13] = (byte)num5;
					goto case 423;
				case 410:
					array[11] = (byte)num5;
					goto case 62;
				case 62:
					array[12] = 164;
					goto case 34;
				case 34:
					array[12] = 56;
					num2 = 31;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 409:
					array[17] = (byte)num5;
					num = 125;
					goto case 125;
				case 125:
					array[18] = 103;
					goto case 156;
				case 156:
					array[18] = 156;
					num = 236;
					goto case 236;
				case 236:
					num5 = 98;
					goto case 52;
				case 52:
					array[18] = (byte)num5;
					num2 = 161;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 407:
					array2[7] = 113;
					goto case 63;
				case 63:
					array2[7] = 240;
					goto case 184;
				case 184:
					array2[7] = 149;
					num2 = 43;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 180:
				case 406:
					if (num13 >= num14)
					{
						goto case 105;
					}
					goto case 144;
				case 105:
				case 318:
					num15++;
					num = 207;
					goto case 207;
				case 207:
				case 343:
					if (num15 >= num20)
					{
						goto case 271;
					}
					goto case 107;
				case 271:
					kXBOL8Rkf = array5;
					break;
				case 109:
				case 375:
					break;
				case 107:
					num17 = num15 % num22;
					num2 = 249;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 258:
					array5[num11 + num13] = (byte)((num9 & num19) >> num10);
					goto case 250;
				case 250:
					num13++;
					num2 = 180;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 144;
				case 144:
					if (num13 <= 0)
					{
						goto case 258;
					}
					goto case 128;
				case 128:
					num19 <<= 8;
					num2 = 97;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 405:
					array2[8] = (byte)num7;
					num2 = 60;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 404:
					num10 = 0;
					num2 = 424;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 202;
				case 403:
					num5 = 124;
					goto case 348;
				case 348:
					array[9] = (byte)num5;
					goto case 164;
				case 164:
					array[9] = 131;
					num2 = 387;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 401:
					array[14] = 118;
					goto case 146;
				case 146:
					num5 = 175;
					goto case 174;
				case 174:
					array[14] = (byte)num5;
					num2 = 396;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 262;
				case 262:
					if (num15 == num20 - 1)
					{
						num = 244;
						goto case 244;
					}
					goto case 222;
				case 244:
					if (num14 > 0)
					{
						num2 = 70;
						if (SAOHoSnp8APcx2jDAg() == null)
						{
							continue;
						}
						goto IL_0022;
					}
					goto case 222;
				case 222:
					num12 = num8 ^ num6;
					goto case 112;
				case 112:
					array5[num11] = (byte)(num12 & 0xFFu);
					goto case 321;
				case 321:
					array5[num11 + 1] = (byte)((num12 & 0xFF00) >> 8);
					goto case 205;
				case 205:
					array5[num11 + 2] = (byte)((num12 & 0xFF0000) >> 16);
					num2 = 115;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 400:
					num7 = 134;
					num2 = 260;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 288;
				case 288:
					array2[4] = (byte)num7;
					num2 = 78;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 398:
					num15 = 0;
					goto case 207;
				case 397:
					num7 = 72;
					num = 299;
					goto case 299;
				case 299:
					array2[11] = (byte)num7;
					num2 = 338;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 396:
					num5 = 106;
					goto case 218;
				case 218:
					array[14] = (byte)num5;
					goto case 103;
				case 103:
					array[14] = 154;
					goto case 221;
				case 221:
					num5 = 88;
					goto case 238;
				case 238:
					array[14] = (byte)num5;
					num2 = 61;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 395:
					array[9] = 84;
					num2 = 100;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 377;
				case 377:
					num5 = 142;
					num2 = 270;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 393:
					num5 = 93;
					goto case 257;
				case 257:
					array[8] = (byte)num5;
					num2 = 4;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 392:
					array2[6] = 93;
					num2 = 275;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 72;
				case 391:
					array[5] = 162;
					goto case 335;
				case 335:
					num5 = 229;
					goto case 200;
				case 200:
					array[5] = (byte)num5;
					num2 = 87;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 389:
					if (array3 != null)
					{
						num2 = 56;
						if (SAOHoSnp8APcx2jDAg() == null)
						{
							continue;
						}
						goto IL_0022;
					}
					goto case 247;
				case 247:
					num21 = 0;
					num2 = 153;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 228;
				case 388:
					array2[13] = (byte)num7;
					goto case 381;
				case 381:
					num7 = 146;
					num2 = 229;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 11;
				case 11:
					AUh8H3RThiq3Ug9FVf(object_3);
					num = 278;
					goto case 278;
				case 278:
					array4 = kXBOL8Rkf;
					num2 = 359;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 188;
				case 188:
					array[17] = (byte)num5;
					goto case 325;
				case 325:
					num5 = 47;
					num2 = 409;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 387:
					array[10] = 125;
					num2 = 289;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 386:
					num20++;
					num2 = 25;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 132;
				case 132:
					num16 = 0u;
					goto case 398;
				case 385:
					array2[8] = (byte)num7;
					goto case 190;
				case 190:
					array2[8] = 82;
					goto case 227;
				case 227:
					array2[9] = 118;
					num2 = 417;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 384:
					array6 = array2;
					num2 = 277;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 225;
				case 225:
					num7 = 120;
					goto case 111;
				case 111:
					array2[12] = (byte)num7;
					goto case 353;
				case 353:
					num7 = 140;
					num = 220;
					goto case 220;
				case 220:
					array2[12] = (byte)num7;
					num2 = 361;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 383:
					num5 = 136;
					num2 = 413;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 382:
					array2[5] = (byte)num7;
					goto case 153;
				case 153:
					array2[6] = 144;
					num2 = 332;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 380:
					array3 = (byte[])kky1fy02WZbP15F61T(FpNmxNlcl5xs49p91E(o72RJO5QG));
					num2 = 389;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 378:
					array[6] = (byte)num5;
					goto case 53;
				case 53:
					array[6] = 38;
					num2 = 261;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 374:
					num5 = 135;
					goto case 89;
				case 89:
					array[20] = (byte)num5;
					num2 = 168;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 373:
					array[22] = 117;
					goto case 263;
				case 263:
					array[22] = 140;
					num2 = 155;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 248;
				case 248:
					num5 = 132;
					goto case 2;
				case 2:
					array[23] = (byte)num5;
					goto case 130;
				case 130:
					array[23] = 114;
					num2 = 68;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 340;
				case 340:
					num5 = 141;
					goto case 137;
				case 137:
					array[23] = (byte)num5;
					goto case 121;
				case 121:
					num5 = 172;
					num2 = 74;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 136;
				case 136:
					array[23] = (byte)num5;
					num2 = 175;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 372:
					array[16] = 142;
					goto case 140;
				case 140:
					num5 = 168;
					goto case 27;
				case 27:
					array[16] = (byte)num5;
					goto case 342;
				case 342:
					array[17] = 89;
					num2 = 368;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 371:
					num16 = (uint)(num17 * 4);
					goto case 177;
				case 177:
					num18 = (uint)((array7[num16 + 3] << 24) | (array7[num16 + 2] << 16) | (array7[num16 + 1] << 8) | array7[num16]);
					num2 = 161;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 167;
				case 167:
					num19 = 255u;
					goto case 404;
				case 370:
					num7 = 161;
					num2 = 113;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 80;
				case 369:
					num5 = 150;
					goto case 264;
				case 264:
					array[0] = (byte)num5;
					num2 = 154;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 48;
				case 48:
					array[29] = 104;
					goto case 284;
				case 284:
					num5 = 170;
					num2 = 226;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 368:
					array[17] = 121;
					goto case 196;
				case 196:
					num5 = 130;
					num = 188;
					goto case 188;
				case 366:
					array[10] = (byte)num5;
					num2 = 316;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 68;
				case 68:
					array2[13] = 96;
					goto case 143;
				case 143:
					array2[13] = 158;
					num = 287;
					goto case 287;
				case 287:
					array2[14] = 93;
					num2 = 36;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 49;
				case 49:
					num7 = 167;
					num2 = 160;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 365:
					array[28] = (byte)num5;
					goto case 117;
				case 117:
					array[28] = 17;
					goto case 319;
				case 364:
					num5 = 90;
					goto case 410;
				case 363:
					num5 = 115;
					num2 = 253;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 362:
					array6[11] = array3[5];
					num2 = 34;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 36;
				case 36:
					array6[13] = array3[6];
					goto case 58;
				case 58:
					array6[15] = array3[7];
					goto case 247;
				case 361:
					num7 = 25;
					goto case 256;
				case 256:
					array2[12] = (byte)num7;
					goto case 127;
				case 127:
					array2[13] = 89;
					goto case 124;
				case 124:
					num7 = 124;
					goto case 388;
				case 360:
					array[26] = 82;
					num2 = 116;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 358:
					array[5] = (byte)num5;
					goto case 119;
				case 119:
					num5 = 90;
					goto case 182;
				case 182:
					array[6] = (byte)num5;
					goto case 104;
				case 104:
					num5 = 95;
					goto case 378;
				case 357:
					array[29] = (byte)num5;
					num2 = 266;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 259;
				case 259:
					array2[15] = (byte)num7;
					num2 = 324;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 356:
					array2[1] = 172;
					goto case 214;
				case 214:
					num7 = 94;
					num2 = 86;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 354:
					array[3] = 91;
					goto case 346;
				case 346:
					num5 = 164;
					num2 = 315;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 256;
				case 352:
					array2[4] = (byte)num7;
					goto case 400;
				case 351:
					array2[2] = 220;
					goto case 82;
				case 82:
					array2[3] = 128;
					num2 = 213;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 349:
					array[16] = (byte)num5;
					num2 = 372;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 347:
					array[16] = (byte)num5;
					num2 = 309;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 228;
				case 345:
					num5 = 134;
					goto case 77;
				case 77:
					array[7] = (byte)num5;
					num2 = 279;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 79;
				case 79:
					array[4] = (byte)num5;
					num = 47;
					goto case 47;
				case 47:
					num5 = 159;
					goto case 171;
				case 171:
					array[4] = (byte)num5;
					num2 = 280;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 105;
				case 344:
					array2[10] = (byte)num7;
					goto case 12;
				case 12:
					num7 = 153;
					num2 = 329;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 338:
					num7 = 52;
					goto case 108;
				case 108:
					array2[11] = (byte)num7;
					num = 314;
					goto case 314;
				case 314:
					num7 = 124;
					num2 = 24;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 5;
				case 5:
					array2[2] = 83;
					num2 = 58;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 159;
				case 159:
					num7 = 68;
					goto case 152;
				case 152:
					array2[2] = (byte)num7;
					num2 = 241;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 337:
					array[24] = (byte)num5;
					goto case 412;
				case 334:
					array[24] = (byte)num5;
					num = 297;
					goto case 297;
				case 297:
					array[24] = 121;
					goto case 310;
				case 310:
					num5 = 156;
					goto case 235;
				case 235:
					array[24] = (byte)num5;
					goto case 199;
				case 199:
					num5 = 243;
					num2 = 94;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 337;
				case 333:
					array[2] = 110;
					num = 215;
					goto case 215;
				case 215:
					array[2] = 140;
					goto case 57;
				case 57:
					array[2] = 125;
					goto case 173;
				case 173:
					array[2] = 199;
					goto case 44;
				case 44:
					array[3] = 89;
					num = 354;
					goto case 354;
				case 332:
					array2[6] = 96;
					goto case 392;
				case 330:
					array2[10] = (byte)num7;
					num2 = 46;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 16;
				case 329:
					array2[10] = (byte)num7;
					num2 = 231;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 234;
				case 234:
					num7 = 22;
					num2 = 330;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 328:
					num7 = 208;
					goto case 165;
				case 165:
					array2[7] = (byte)num7;
					goto case 407;
				case 324:
					array2[15] = 87;
					num2 = 142;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 323:
					num5 = 167;
					num2 = 170;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 322:
					array2[0] = 119;
					num2 = 370;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 356;
				case 320:
					array[2] = (byte)num5;
					goto case 333;
				case 317:
					array[18] = (byte)num5;
					num2 = 7;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 7;
				case 7:
					array[19] = 110;
					goto case 203;
				case 203:
					num5 = 139;
					goto case 126;
				case 316:
					num5 = 185;
					goto case 193;
				case 193:
					array[10] = (byte)num5;
					goto case 286;
				case 286:
					array[10] = 88;
					num2 = 164;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 294;
				case 294:
					num5 = 79;
					goto case 179;
				case 179:
					array[10] = (byte)num5;
					num2 = 178;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 315:
					array[3] = (byte)num5;
					num2 = 20;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 313:
					array2[1] = (byte)num7;
					goto case 96;
				case 96:
					array2[2] = 140;
					goto case 5;
				case 312:
					stream = (Stream)F6yeNLo5jw9ao2QTJF();
					goto case 26;
				case 26:
					object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 183;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 311:
					array2[4] = 195;
					goto case 166;
				case 166:
					num7 = 116;
					goto case 352;
				case 309:
					array[16] = 100;
					num = 69;
					goto case 69;
				case 69:
					num5 = 147;
					goto case 349;
				case 308:
					array[26] = (byte)num5;
					num2 = 360;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 294;
				case 306:
					num5 = 141;
					num = 204;
					goto case 204;
				case 204:
					array[27] = (byte)num5;
					goto case 283;
				case 283:
					array[27] = 132;
					num2 = 133;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 305:
					num5 = 135;
					num2 = 191;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 304:
					num6 = (uint)((array4[num16 + 3] << 24) | (array4[num16 + 2] << 16) | (array4[num16 + 1] << 8) | array4[num16]);
					num2 = 192;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 302:
					array2[9] = (byte)num7;
					goto case 59;
				case 59:
					num7 = 40;
					num2 = 344;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 301:
					num7 = 99;
					num2 = 252;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 300:
					array[1] = (byte)num5;
					num = 383;
					goto case 383;
				case 298:
					num5 = 154;
					goto case 365;
				case 296:
					array2[3] = (byte)num7;
					goto case 131;
				case 131:
					array2[3] = 181;
					goto case 17;
				case 17:
					num7 = 97;
					goto case 67;
				case 67:
					array2[4] = (byte)num7;
					num2 = 99;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 293:
					array2[0] = (byte)num7;
					num = 242;
					goto case 242;
				case 242:
					array2[1] = 182;
					num2 = 114;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 292:
					num7 = 150;
					goto case 405;
				case 291:
					num5 = 57;
					goto case 118;
				case 118:
					array[20] = (byte)num5;
					goto case 22;
				case 22:
					array[20] = 146;
					goto case 374;
				case 289:
					num5 = 121;
					goto case 366;
				case 282:
					array2[14] = (byte)num7;
					num2 = 29;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 17;
				case 280:
					array[4] = 194;
					goto case 391;
				case 279:
					num5 = 152;
					num2 = 0;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 277:
					C3hfAixFrHXoc6BXVF(array6);
					goto case 380;
				case 276:
					array2[8] = (byte)num7;
					num2 = 200;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 292;
				case 275:
					array2[6] = 159;
					num2 = 55;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 38;
				case 38:
					array[18] = (byte)num5;
					num2 = 51;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 274:
					num7 = 147;
					goto case 293;
				case 270:
					array[9] = (byte)num5;
					goto case 403;
				case 269:
					num7 = 130;
					goto case 259;
				case 268:
					HYiqj9HNmgx5Sd3Q5U(jLhBESTw2FQF41obd0(object_), 0L);
					goto case 35;
				case 267:
					kXBOL8Rkf = (byte[])bhi3NG1iHVct9buOeH(stream);
					goto case 65;
				case 65:
					AUh8H3RThiq3Ug9FVf(stream);
					goto case 11;
				case 266:
					array[29] = 20;
					num2 = 48;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 261:
					num5 = 94;
					goto case 186;
				case 186:
					array[7] = (byte)num5;
					num2 = 363;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 187;
				case 260:
					num7 = 65;
					num = 276;
					goto case 276;
				case 255:
					array2[5] = 130;
					goto case 230;
				case 230:
					array2[5] = 130;
					num2 = 30;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 254:
					array[20] = 142;
					num2 = 229;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 291;
				case 253:
					array[7] = (byte)num5;
					num2 = 224;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 252:
					array2[0] = (byte)num7;
					goto case 322;
				case 249:
					num11 = num15 * 4;
					num2 = 371;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 246:
					array[0] = (byte)num5;
					goto case 369;
				case 241:
					array2[2] = 127;
					num2 = 2;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 37;
				case 37:
					num7 = 84;
					num2 = 93;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 33;
				case 237:
					array[27] = 132;
					num = 157;
					goto case 157;
				case 157:
					array[27] = 192;
					goto case 151;
				case 151:
					num5 = 104;
					goto case 155;
				case 155:
					array[28] = (byte)num5;
					goto case 298;
				case 233:
					if (num14 > 0)
					{
						num2 = 386;
						if (SAOHoSnp8APcx2jDAg() == null)
						{
							continue;
						}
						goto IL_0022;
					}
					goto case 132;
				case 232:
					array[20] = (byte)num5;
					goto case 254;
				case 231:
					array2[12] = 126;
					goto case 225;
				case 229:
					array2[13] = (byte)num7;
					goto case 10;
				case 10:
					array2[13] = 165;
					num2 = 58;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 68;
				case 226:
					array[29] = (byte)num5;
					goto case 74;
				case 74:
					array[30] = 78;
					goto case 6;
				case 224:
					num5 = 132;
					num2 = 122;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 223:
					num5 = 125;
					goto case 18;
				case 18:
					array[19] = (byte)num5;
					goto case 101;
				case 101:
					num5 = 120;
					num = 232;
					goto case 232;
				case 219:
					array[27] = (byte)num5;
					goto case 425;
				case 216:
					num5 = 98;
					goto case 347;
				case 213:
					num7 = 140;
					goto case 296;
				case 212:
					array[3] = 93;
					goto case 163;
				case 211:
					V9QnrsvZVA1iLNQiK7(object_2, CipherMode.CBC);
					goto case 208;
				case 208:
					transform = (ICryptoTransform)KmaLbiZdMO0DDf15xq(object_2, array7, array6);
					goto case 312;
				case 210:
					num13 = 0;
					num = 406;
					goto case 180;
				case 209:
					ileaXn7RAA2rFlcapp(object_);
					goto case 40;
				case 40:
					array = new byte[32];
					goto case 39;
				case 39:
					array[0] = 150;
					num2 = 323;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 197:
					num7 = 126;
					num2 = 419;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 105;
				case 195:
					array[8] = 196;
					goto case 181;
				case 181:
					array[9] = 101;
					goto case 395;
				case 194:
					array2[1] = (byte)num7;
					goto case 356;
				case 191:
					array[8] = (byte)num5;
					goto case 393;
				case 185:
					array[8] = 99;
					goto case 305;
				case 183:
					Rdfe0MJPHKvCac47wq(object_3, array4, 0, array4.Length);
					num = 91;
					goto case 91;
				case 91:
					TLXPyre8KqcAZ9Kk5o(object_3);
					goto case 267;
				case 178:
					num5 = 175;
					goto case 141;
				case 141:
					array[11] = (byte)num5;
					num2 = 25;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 76;
				case 76:
					array[11] = 91;
					num2 = 364;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 175:
					num5 = 121;
					goto case 334;
				case 172:
					array2[14] = 198;
					num = 269;
					goto case 269;
				case 170:
					array[0] = (byte)num5;
					goto case 416;
				case 169:
					array2[4] = (byte)num7;
					goto case 311;
				case 168:
					num5 = 122;
					num = 41;
					goto case 41;
				case 41:
					array[21] = (byte)num5;
					num = 134;
					goto case 134;
				case 134:
					num5 = 107;
					num2 = 149;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 161:
					num5 = 151;
					goto case 38;
				case 160:
					array2[14] = (byte)num7;
					goto case 75;
				case 75:
					num7 = 148;
					num2 = 80;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 282;
				case 158:
					array[22] = 111;
					goto case 373;
				case 154:
					num5 = 110;
					num2 = 42;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 300;
				case 150:
					array2 = new byte[16];
					num2 = 301;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 149:
					array[21] = (byte)num5;
					goto case 14;
				case 14:
					array[21] = 164;
					num2 = 103;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 135;
				case 135:
					array[21] = 17;
					goto case 158;
				case 148:
					num5 = 204;
					num2 = 6;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 102;
				case 102:
					array[31] = (byte)num5;
					goto case 8;
				case 8:
					array7 = array;
					num2 = 150;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 142:
					array2[15] = 100;
					num2 = 197;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 139:
					num7 = 0;
					num2 = 302;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 138:
					array2[15] = 18;
					goto case 384;
				case 133:
					num5 = 60;
					num2 = 219;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 129:
					array2[7] = 157;
					goto case 328;
				case 123:
					array6[9] = array3[4];
					num = 362;
					goto case 362;
				case 122:
					array[7] = (byte)num5;
					goto case 345;
				case 116:
					array[26] = 54;
					num2 = 306;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 115:
					array5[num11 + 3] = (byte)((num12 & 0xFF000000u) >> 24);
					goto case 105;
				case 114:
					num7 = 162;
					goto case 194;
				case 113:
					array2[0] = (byte)num7;
					goto case 274;
				case 106:
					array2[1] = 50;
					goto case 95;
				case 95:
					num7 = 140;
					num2 = 251;
					if (SAOHoSnp8APcx2jDAg() != null)
					{
						continue;
					}
					goto case 313;
				case 99:
					num7 = 163;
					num2 = 169;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto case 116;
				case 98:
					array[28] = 74;
					goto case 90;
				case 90:
					num5 = 164;
					goto case 357;
				case 97:
					num10 += 8;
					num2 = 258;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 93:
					array2[2] = (byte)num7;
					goto case 351;
				case 92:
					array[28] = (byte)num5;
					goto case 98;
				case 87:
					num5 = 146;
					num2 = 358;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 86:
					array2[1] = (byte)num7;
					num2 = 106;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 84:
					array2[6] = 110;
					num2 = 129;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 71;
				case 71:
					array5 = new byte[array4.Length];
					goto case 421;
				case 83:
					num5 = 133;
					goto case 411;
				case 78:
					num7 = 189;
					num2 = 0;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 3;
				case 3:
					array2[4] = (byte)num7;
					num = 255;
					goto case 255;
				case 70:
					num9 = num8 ^ num6;
					goto case 210;
				case 64:
					array2[14] = 42;
					num2 = 172;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 61:
					num5 = 145;
					num2 = 54;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 60:
					num7 = 168;
					num2 = 385;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 162;
				case 56:
					if (array3.Length > 0)
					{
						num2 = 16;
						if (SAOHoSnp8APcx2jDAg() == null)
						{
							continue;
						}
						goto IL_0022;
					}
					goto case 247;
				case 55:
					array2[6] = 142;
					goto case 84;
				case 54:
					array[14] = (byte)num5;
					goto case 42;
				case 42:
					array[15] = 123;
					num2 = 420;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 51:
					num5 = 0;
					num = 317;
					goto case 317;
				case 46:
					array2[11] = 42;
					num2 = 397;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 43:
					array2[8] = 131;
					goto case 260;
				case 31:
					array[12] = 75;
					goto case 83;
				case 30:
					num7 = 98;
					goto case 382;
				case 29:
					num7 = 177;
					num2 = 13;
					if (SAOHoSnp8APcx2jDAg() == null)
					{
						continue;
					}
					goto IL_0022;
				case 24:
					array2[12] = (byte)num7;
					goto case 414;
				case 20:
					array[3] = 60;
					num = 212;
					goto case 212;
				case 13:
					array2[14] = (byte)num7;
					goto case 64;
				case 9:
					num6 = 0u;
					num2 = 233;
					if (FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto IL_0022;
				case 4:
					array[8] = 110;
					num2 = 194;
					if (!FbKAVPcYhQlScsBVES())
					{
						continue;
					}
					goto case 195;
				case 1:
					object_2 = (SymmetricAlgorithm)M92mIsyivBuAh1w33P();
					goto case 211;
				default:
					array[8] = (byte)num5;
					goto case 185;
				case 94:
					goto IL_287f;
				case 376:
					goto IL_28aa;
				case 45:
					try
					{
						T7vAdHdel0HZ3oO7eS();
						int num3 = 0;
						if (!FbKAVPcYhQlScsBVES())
						{
							goto IL_28f0;
						}
						goto IL_28f4;
						IL_28f4:
						do
						{
							switch (num3)
							{
							case 1:
								return result;
							}
							result = (string)ldhvium4gTuljYxBBL(HqnHcwX4FvEi2F36en(), kXBOL8Rkf, int_0 + 4, int_);
							num3 = 1;
						}
						while (FbKAVPcYhQlScsBVES());
						goto IL_28f0;
						IL_28f0:
						num3 = num4;
						goto IL_28f4;
					}
					catch
					{
						if (SAOHoSnp8APcx2jDAg() == null)
						{
							switch (0)
							{
							}
						}
					}
					goto case 245;
				case 245:
					return "";
				}
				break;
			}
			goto IL_071a;
			IL_071a:
			int_ = JdfuqnYfp36LiwUdh8(kXBOL8Rkf, int_0);
			num2 = 45;
			if (SAOHoSnp8APcx2jDAg() != null)
			{
				goto IL_0022;
			}
			goto IL_21c8;
			IL_0022:
			num2 = num;
			goto IL_21c8;
		}
	}

	[iW5nWspQE6hJ9osJaM(typeof(iW5nWspQE6hJ9osJaM.Q5T4bllOm2CTdC9wdn<object>[]))]
	internal static string N8yyvSIrL(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Ty0Z5yjOo()
	{
		return 5;
	}

	private static void kUT06x1PM()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate I5xx79ytu(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object JO4SWgZXc(object object_0)
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

	private static IntPtr vt3bWPjnC(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (fYbjDZvkT5 == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Find ".Trim() + "ResourceA");
			fYbjDZvkT5 = (exZt3WEPjnC99BG2vk)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(exZt3WEPjnC99BG2vk));
		}
		return fYbjDZvkT5(intptr_0, string_0, uint_0);
	}

	private static IntPtr P9BGG2vkl(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (akvjT5QV1v == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Virtual ".Trim() + "Alloc");
			akvjT5QV1v = (gNZeIgkcOXv3CNcf3F)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(gNZeIgkcOXv3CNcf3F));
		}
		return akvjT5QV1v(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int rZe8IgcOX(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (zG1jMhCyAv == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Write ".Trim() + "Process ".Trim() + "Memory");
			zG1jMhCyAv = (NdiDomKBHIsZnig6Fj)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(NdiDomKBHIsZnig6Fj));
		}
		return zG1jMhCyAv(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int h3CsNcf3F(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (nYojNaFYqT == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Virtual ".Trim() + "Protect");
			nYojNaFYqT = (eI2gKcDSQvNjnYnsqm)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(eI2gKcDSQvNjnYnsqm));
		}
		return nYojNaFYqT(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr NdiwDomBH(uint uint_0, int int_0, uint uint_1)
	{
		if (seoj4SXgii == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Open ".Trim() + "Process");
			seoj4SXgii = (eLpGAMTKBvp6aXtDkA)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(eLpGAMTKBvp6aXtDkA));
		}
		return seoj4SXgii(uint_0, int_0, uint_1);
	}

	private static int fsZanig6F(IntPtr intptr_0)
	{
		if (QlYjXM4ZZL == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Close ".Trim() + "Handle");
			QlYjXM4ZZL = (fh0n8qMUM6f5o2ZG9h)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(fh0n8qMUM6f5o2ZG9h));
		}
		return QlYjXM4ZZL(intptr_0);
	}

	[SpecialName]
	private static IntPtr kyPRoS01PH()
	{
		if (a53jyq3wBU == IntPtr.Zero)
		{
			a53jyq3wBU = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return a53jyq3wBU;
	}

	[iW5nWspQE6hJ9osJaM(typeof(iW5nWspQE6hJ9osJaM.Q5T4bllOm2CTdC9wdn<object>[]))]
	private static byte[] b2IB2gKcS(string string_0)
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

	internal static Stream MvNgjnYns()
	{
		return new MemoryStream();
	}

	internal static byte[] amdnLpGAM(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[iW5nWspQE6hJ9osJaM(typeof(iW5nWspQE6hJ9osJaM.Q5T4bllOm2CTdC9wdn<object>[]))]
	private static byte[] oBvcp6aXt(byte[] byte_0)
	{
		Stream stream = MvNgjnYns();
		SymmetricAlgorithm symmetricAlgorithm = sLoCZA8wl();
		symmetricAlgorithm.Key = new byte[32]
		{
			110, 253, 171, 124, 230, 146, 203, 113, 21, 72,
			4, 34, 105, 176, 113, 75, 29, 39, 144, 227,
			120, 59, 240, 63, 6, 158, 99, 125, 174, 111,
			206, 185
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			33, 59, 110, 227, 114, 134, 251, 36, 108, 134,
			232, 218, 41, 159, 120, 93
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = amdnLpGAM(stream);
		FwnbpF40QRXGKbD08B.TpLjPRfzSfIkW();
		return result;
	}

	private byte[] pkAUIh0n8()
	{
		return null;
	}

	private byte[] aUM36f5o2()
	{
		return null;
	}

	private byte[] vG9ohFsiA()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] dlouNppQ4()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] SadYGnBwn()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] ApFQ0QRXG()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] obDW08BsI()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] CnTAIy9sP()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] V8U9U7vKZ()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] MnX5AT4th()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object g5Z005QLVVsdDSE98Y(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object jLhBESTw2FQF41obd0(object object_0)
	{
		return ((vXcJ9MHSbdRQQJds4v)object_0).RgtTUJcyZL();
	}

	internal static void HYiqj9HNmgx5Sd3Q5U(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long SLl48rrkqZOQwyTQMf(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object S1BcrX62TNYMC0tZ9A(object object_0, int int_0)
	{
		return ((vXcJ9MHSbdRQQJds4v)object_0).aNQjS1U8FA(int_0);
	}

	internal static void ileaXn7RAA2rFlcapp(object object_0)
	{
		((vXcJ9MHSbdRQQJds4v)object_0).A1xjbF2aAi();
	}

	internal static void C3hfAixFrHXoc6BXVF(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object FpNmxNlcl5xs49p91E(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object kky1fy02WZbP15F61T(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object M92mIsyivBuAh1w33P()
	{
		return sLoCZA8wl();
	}

	internal static void V9QnrsvZVA1iLNQiK7(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object KmaLbiZdMO0DDf15xq(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object F6yeNLo5jw9ao2QTJF()
	{
		return MvNgjnYns();
	}

	internal static void Rdfe0MJPHKvCac47wq(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void TLXPyre8KqcAZ9Kk5o(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object bhi3NG1iHVct9buOeH(object object_0)
	{
		return amdnLpGAM((Stream)object_0);
	}

	internal static void AUh8H3RThiq3Ug9FVf(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int JdfuqnYfp36LiwUdh8(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void T7vAdHdel0HZ3oO7eS()
	{
		FwnbpF40QRXGKbD08B.TpLjPRfzSfIkW();
	}

	internal static object HqnHcwX4FvEi2F36en()
	{
		return Encoding.Unicode;
	}

	internal static object ldhvium4gTuljYxBBL(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool FbKAVPcYhQlScsBVES()
	{
		return (object)null == null;
	}

	internal static object SAOHoSnp8APcx2jDAg()
	{
		return null;
	}
}
