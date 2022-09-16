using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;

namespace dfb44QxstTvciGRseP;

internal class InRL4fclTJhCYsrjsta
{
	private delegate void xyWJdLc68cHagSe6JCJ(object o);

	internal class fW7EXxcjAXDYi9hDoFF : Attribute
	{
		internal class lYAAwScGtIFp0nIiLdL<JEZToqc4URocr6Bpibf>
		{
			internal static object hBKZQ3ukcExM5VhhfZO;

			public lYAAwScGtIFp0nIiLdL()
			{
				GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
				base._002Ector();
			}

			internal static bool WJ8pwkuGTklAhRaG7OW()
			{
				return hBKZQ3ukcExM5VhhfZO == null;
			}

			internal static object GP241runb4qnw4e6W6K()
			{
				return hBKZQ3ukcExM5VhhfZO;
			}
		}

		[fW7EXxcjAXDYi9hDoFF(typeof(lYAAwScGtIFp0nIiLdL<object>[]))]
		public fW7EXxcjAXDYi9hDoFF(object object_0)
		{
		}
	}

	internal class yvQTK1cQBAXgKG2rfSe
	{
		[fW7EXxcjAXDYi9hDoFF(typeof(fW7EXxcjAXDYi9hDoFF.lYAAwScGtIFp0nIiLdL<object>[]))]
		internal static string o5wRtW57cr(string string_0, string string_1)
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
			byte[] iV = (byte[])WwEq1iuTJy84eplLJkc(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = qPOCXFCfYK();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		internal static object WwEq1iuTJy84eplLJkc(object object_0)
		{
			return IFlCyoEV2v((byte[])object_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint aJMYjdc5Wr3Mb8JUh8q(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr DGFZdrcTiFE7eBYnvJo();

	internal struct stsiRMc3kR8Ag1cw34m
	{
		internal bool wrYRlqMwmr;

		internal byte[] UQ8RJa6kng;
	}

	internal class ibtnH5ca3SUQeLijsOE
	{
		private BinaryReader xqfR2nkCSK;

		public ibtnH5ca3SUQeLijsOE(Stream stream_0)
		{
			xqfR2nkCSK = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return xqfR2nkCSK.BaseStream;
		}

		internal byte[] B0wRAaeO7P(int int_0)
		{
			return xqfR2nkCSK.ReadBytes(int_0);
		}

		internal int stZReqWEqy(byte[] byte_0, int int_0, int int_1)
		{
			return xqfR2nkCSK.Read(byte_0, int_0, int_1);
		}

		internal int H4lRGZxTBi()
		{
			return xqfR2nkCSK.ReadInt32();
		}

		internal void ul0RFvjw7b()
		{
			xqfR2nkCSK.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ntdNPkcCoXyQ9MehkII(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr zoXtkRcAhDF7rfG5xpm(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int L1TkpSce2VmGDRBavPm(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int KJlbBdcInR33Bh8cvx4(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Bj9dT5cZIjCrCA2yp7Z(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int T6IlbYcrJIsGf7RPsGf(IntPtr ptr);

	[Flags]
	private enum v8rFP4cpakciGaPn73j
	{

	}

	private static bool yh9C45NnD7;

	internal static Assembly UmvCvEQi0R;

	private static uint[] jjQC0Ttyq5;

	private static bool W24CjPmj4Z;

	private static bool pvECKGUDFv;

	private static byte[] HvZCYeDlfX;

	internal static RSACryptoServiceProvider i3qCzrAS9N;

	private static Dictionary<int, int> N1ZRwGsev2;

	private static object M8PRsvmU4f;

	private static byte[] HTNRh51uy7;

	private static byte[] MeWRLdAIbc;

	private static IntPtr QgWRpiFT6l;

	private static IntPtr hvCRTQEXkH;

	private static object X1WRSQpwfJ;

	private static int[] hAXRuZ50F5;

	private static int kKLRMw2y5P;

	private static bool xRfRCZ7uIm;

	private static SortedList gJhRR0ii1j;

	private static int F8LREK4AQw;

	private static long b6bRaFn9Fu;

	internal static aJMYjdc5Wr3Mb8JUh8q LDkRIJLuZF;

	internal static aJMYjdc5Wr3Mb8JUh8q ogVRn3qXEN;

	private static long nXnR5s3IuJ;

	private static int p5HRP1BaWc;

	private static bool MJuRXE0Vny;

	private static bool ghQR9IQQm4;

	private static int O2tRyHbpc0;

	private static IntPtr AyBRfhkE3i;

	[fW7EXxcjAXDYi9hDoFF(typeof(fW7EXxcjAXDYi9hDoFF.lYAAwScGtIFp0nIiLdL<object>[]))]
	private static bool FXSRDgxMAA;

	internal static Hashtable I0uRBq3DQt;

	private static ntdNPkcCoXyQ9MehkII WyDRookidv;

	private static zoXtkRcAhDF7rfG5xpm OxMR1DBv2F;

	private static L1TkpSce2VmGDRBavPm REeRZxUZCU;

	private static KJlbBdcInR33Bh8cvx4 pHCRrSNlFC;

	private static Bj9dT5cZIjCrCA2yp7Z XKGRc0D9lX;

	private static T6IlbYcrJIsGf7RPsGf pmoR7Ay07t;

	private static IntPtr ncWRHMDflb;

	static InRL4fclTJhCYsrjsta()
	{
		yh9C45NnD7 = false;
		UmvCvEQi0R = typeof(InRL4fclTJhCYsrjsta).Assembly;
		jjQC0Ttyq5 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		W24CjPmj4Z = false;
		pvECKGUDFv = false;
		HvZCYeDlfX = new byte[0];
		i3qCzrAS9N = null;
		N1ZRwGsev2 = null;
		M8PRsvmU4f = new object();
		HTNRh51uy7 = new byte[0];
		MeWRLdAIbc = new byte[0];
		QgWRpiFT6l = IntPtr.Zero;
		hvCRTQEXkH = IntPtr.Zero;
		X1WRSQpwfJ = new string[0];
		hAXRuZ50F5 = new int[0];
		kKLRMw2y5P = 1;
		xRfRCZ7uIm = false;
		gJhRR0ii1j = new SortedList();
		F8LREK4AQw = 0;
		b6bRaFn9Fu = 0L;
		LDkRIJLuZF = null;
		ogVRn3qXEN = null;
		nXnR5s3IuJ = 0L;
		p5HRP1BaWc = 0;
		MJuRXE0Vny = false;
		ghQR9IQQm4 = false;
		O2tRyHbpc0 = 0;
		AyBRfhkE3i = IntPtr.Zero;
		FXSRDgxMAA = false;
		I0uRBq3DQt = new Hashtable();
		WyDRookidv = null;
		OxMR1DBv2F = null;
		REeRZxUZCU = null;
		pHCRrSNlFC = null;
		XKGRc0D9lX = null;
		pmoR7Ay07t = null;
		ncWRHMDflb = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void juQ4tCZUFJrKt()
	{
	}

	internal static byte[] L4BCRd9BL4(byte[] byte_0)
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
			YbMCETFJdb(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			YbMCETFJdb(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			YbMCETFJdb(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			YbMCETFJdb(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			YbMCETFJdb(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			YbMCETFJdb(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			YbMCETFJdb(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			YbMCETFJdb(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			YbMCETFJdb(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			YbMCETFJdb(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			YbMCETFJdb(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			YbMCETFJdb(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			YbMCETFJdb(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			YbMCETFJdb(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			YbMCETFJdb(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			YbMCETFJdb(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			mvQCaXYsE3(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			mvQCaXYsE3(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			mvQCaXYsE3(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			mvQCaXYsE3(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			mvQCaXYsE3(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			mvQCaXYsE3(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			mvQCaXYsE3(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			mvQCaXYsE3(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			mvQCaXYsE3(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			mvQCaXYsE3(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			mvQCaXYsE3(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			mvQCaXYsE3(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			mvQCaXYsE3(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			mvQCaXYsE3(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			mvQCaXYsE3(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			mvQCaXYsE3(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			YxeCIE3e8a(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			YxeCIE3e8a(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			YxeCIE3e8a(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			YxeCIE3e8a(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			YxeCIE3e8a(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			YxeCIE3e8a(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			YxeCIE3e8a(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			YxeCIE3e8a(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			YxeCIE3e8a(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			YxeCIE3e8a(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			YxeCIE3e8a(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			YxeCIE3e8a(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			YxeCIE3e8a(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			YxeCIE3e8a(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			YxeCIE3e8a(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			YxeCIE3e8a(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			QmECnT4nV3(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			QmECnT4nV3(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			QmECnT4nV3(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			QmECnT4nV3(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			QmECnT4nV3(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			QmECnT4nV3(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			QmECnT4nV3(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			QmECnT4nV3(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			QmECnT4nV3(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			QmECnT4nV3(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			QmECnT4nV3(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			QmECnT4nV3(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			QmECnT4nV3(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			QmECnT4nV3(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			QmECnT4nV3(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			QmECnT4nV3(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy((Array)PeZc6uuAkhyy3Pu1JXS(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void YbMCETFJdb(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEnC5ZKFQN(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + jjQC0Ttyq5[uint_5 - 1], ushort_0);
	}

	private static void mvQCaXYsE3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEnC5ZKFQN(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + jjQC0Ttyq5[uint_5 - 1], ushort_0);
	}

	private static void YxeCIE3e8a(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEnC5ZKFQN(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + jjQC0Ttyq5[uint_5 - 1], ushort_0);
	}

	private static void QmECnT4nV3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + YkRfR3uB82l8ZLC3Mkh(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + jjQC0Ttyq5[uint_5 - 1], ushort_0);
	}

	private static uint BEnC5ZKFQN(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool THfCP6ejpP()
	{
		if (!W24CjPmj4Z)
		{
			JcIC9Ar6ZG();
			W24CjPmj4Z = true;
		}
		return pvECKGUDFv;
	}

	internal static SymmetricAlgorithm qPOCXFCfYK()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (THfCP6ejpP())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)((ObjectHandle)s6aG17ucW62IL2uIM88("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")).Unwrap();
		}
	}

	internal static void JcIC9Ar6ZG()
	{
		try
		{
			pvECKGUDFv = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] IFlCyoEV2v(byte[] byte_0)
	{
		if (!THfCP6ejpP())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return (byte[])nTEj8lu8SB1SMqxoJr1(byte_0);
	}

	internal static void quaCff36N1(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			OmcCDqyn5G(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void OmcCDqyn5G(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint kdnCBTkHLL(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	public static void vRtCogEkgT(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (N1ZRwGsev2 == null)
			{
				lock (M8PRsvmU4f)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(InRL4fclTJhCYsrjsta).Assembly.GetManifestResourceStream("hLn6NqAsmDf0wHnPuk.6V5g3TlEhTK5MvDktC"));
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
							num3 += hD4CrC2b15(num3);
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
						ibtnH5ca3SUQeLijsOE ibtnH5ca3SUQeLijsOE = new ibtnH5ca3SUQeLijsOE(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = vxJU50uvAUKQIt8jJUt(ibtnH5ca3SUQeLijsOE);
							int value = ibtnH5ca3SUQeLijsOE.H4lRGZxTBi();
							dictionary.Add(key, value);
						}
						ibtnH5ca3SUQeLijsOE.ul0RFvjw7b();
					}
					N1ZRwGsev2 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = N1ZRwGsev2[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(InRL4fclTJhCYsrjsta).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					ypcasJu9E8cU7SmqHbw(fieldInfo, null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
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
				ypcasJu9E8cU7SmqHbw(fieldInfo, null, nKy4WNuaMOEwSHm6F1l(dynamicMethod, typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint tERC1yDLan(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	private static uint VTgCZadfkL(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint hD4CrC2b15(uint uint_0)
	{
		return 0u;
	}

	internal static void mlvCcmFhoa()
	{
	}

	[fW7EXxcjAXDYi9hDoFF(typeof(fW7EXxcjAXDYi9hDoFF.lYAAwScGtIFp0nIiLdL<object>[]))]
	internal static string HEAC7GRvgR(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int qqMCHVjTq9()
	{
		return 5;
	}

	private static void aDnCtbi1QY()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate KjeCljw9Fi(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)yWAoyLuKUscHeBK8fc7(typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}), null, new object[2] { intptr_0, type_0 });
	}

	internal static object pU1CJg3or6(object object_0)
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

	private static IntPtr pItCGuyjJk(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (WyDRookidv == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string)Ya42nQultNPoNFGLORr("Find ".Trim(), "ResourceA"));
			WyDRookidv = (ntdNPkcCoXyQ9MehkII)IHk23mubLyx8jAwN5MZ(procAddress, typeof(ntdNPkcCoXyQ9MehkII));
		}
		return WyDRookidv(intptr_0, string_0, uint_0);
	}

	private static IntPtr KNHCFYkDmG(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (OxMR1DBv2F == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			OxMR1DBv2F = (zoXtkRcAhDF7rfG5xpm)IHk23mubLyx8jAwN5MZ(procAddress, typeof(zoXtkRcAhDF7rfG5xpm));
		}
		return ly6TetutrKshL3k8HdD(OxMR1DBv2F, intptr_0, uint_0, uint_1, uint_2);
	}

	private static int YWcC2CErBn(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (REeRZxUZCU == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string)aPLp3VuF9tmUHxV3MXa("Write ".Trim(), "Process ".Trim(), "Memory"));
			REeRZxUZCU = (L1TkpSce2VmGDRBavPm)IHk23mubLyx8jAwN5MZ(procAddress, typeof(L1TkpSce2VmGDRBavPm));
		}
		return REeRZxUZCU(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int QeoCqpKMqG(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (pHCRrSNlFC == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			pHCRrSNlFC = (KJlbBdcInR33Bh8cvx4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(KJlbBdcInR33Bh8cvx4));
		}
		return pHCRrSNlFC(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr KL1C3hwOcc(uint uint_0, int int_0, uint uint_1)
	{
		if (XKGRc0D9lX == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			XKGRc0D9lX = (Bj9dT5cZIjCrCA2yp7Z)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Bj9dT5cZIjCrCA2yp7Z));
		}
		return XKGRc0D9lX(uint_0, int_0, uint_1);
	}

	private static int B66CQ516Tj(IntPtr intptr_0)
	{
		if (pmoR7Ay07t == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string)Ya42nQultNPoNFGLORr("Close ".Trim(), "Handle"));
			pmoR7Ay07t = (T6IlbYcrJIsGf7RPsGf)Marshal.GetDelegateForFunctionPointer(procAddress, mr6PgyuWFEM9Amf7Cx1(typeof(T6IlbYcrJIsGf7RPsGf).TypeHandle));
		}
		return pmoR7Ay07t(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (ncWRHMDflb == IntPtr.Zero)
		{
			ncWRHMDflb = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return ncWRHMDflb;
	}

	[fW7EXxcjAXDYi9hDoFF(typeof(fW7EXxcjAXDYi9hDoFF.lYAAwScGtIFp0nIiLdL<object>[]))]
	private static byte[] w9HCieMHDJ(string string_0)
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

	internal static Stream nOGC6HuUUi()
	{
		return new MemoryStream();
	}

	internal static byte[] U7iCNovbTZ(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[fW7EXxcjAXDYi9hDoFF(typeof(fW7EXxcjAXDYi9hDoFF.lYAAwScGtIFp0nIiLdL<object>[]))]
	private static byte[] qUfCmawQq4(byte[] byte_0)
	{
		Stream stream = nOGC6HuUUi();
		SymmetricAlgorithm symmetricAlgorithm = qPOCXFCfYK();
		symmetricAlgorithm.Key = new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = (byte[])AQVaCSuJpglshYQvSoX(stream);
		Bk3iPqu4SOZapTGgopR();
		return result;
	}

	private byte[] GpuCkTifgu()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] g4MC8tCxIw()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] FjhCgixD7m()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] D6lCVyABeU()
	{
		string object_ = "{11111-22222-20001-00002}";
		if (vDxJ2kuQ1fZLKVkVJq7(object_) > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] SZWCOyJ9C6()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] eNXCdBtlXA()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] mfXCbPWgFH()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] aQECWL5bSy()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] inlCUaRyIh()
	{
		return null;
	}

	internal byte[] dItCxcTKFG()
	{
		return null;
	}

	internal static object PeZc6uuAkhyy3Pu1JXS(uint uint_0)
	{
		return BitConverter.GetBytes(uint_0);
	}

	internal static uint YkRfR3uB82l8ZLC3Mkh(uint uint_0, ushort ushort_0)
	{
		return BEnC5ZKFQN(uint_0, ushort_0);
	}

	internal static object s6aG17ucW62IL2uIM88(object object_0, object object_1)
	{
		return Activator.CreateInstance((string)object_0, (string)object_1);
	}

	internal static object nTEj8lu8SB1SMqxoJr1(object object_0)
	{
		return L4BCRd9BL4((byte[])object_0);
	}

	internal static int vxJU50uvAUKQIt8jJUt(object object_0)
	{
		return ((ibtnH5ca3SUQeLijsOE)object_0).H4lRGZxTBi();
	}

	internal static void ypcasJu9E8cU7SmqHbw(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static object nKy4WNuaMOEwSHm6F1l(object object_0, Type type_0)
	{
		return ((DynamicMethod)object_0).CreateDelegate(type_0);
	}

	internal static object yWAoyLuKUscHeBK8fc7(object object_0, object object_1, object object_2)
	{
		return ((MethodBase)object_0).Invoke(object_1, (object?[]?)object_2);
	}

	internal static object Ya42nQultNPoNFGLORr(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static object IHk23mubLyx8jAwN5MZ(IntPtr intptr_0, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
	}

	internal static IntPtr ly6TetutrKshL3k8HdD(object object_0, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect)
	{
		return object_0(lpAddress, dwSize, flAllocationType, flProtect);
	}

	internal static object aPLp3VuF9tmUHxV3MXa(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static Type mr6PgyuWFEM9Amf7Cx1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object AQVaCSuJpglshYQvSoX(object object_0)
	{
		return U7iCNovbTZ((Stream)object_0);
	}

	internal static void Bk3iPqu4SOZapTGgopR()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
	}

	internal static int vDxJ2kuQ1fZLKVkVJq7(object object_0)
	{
		return ((string)object_0).Length;
	}
}
