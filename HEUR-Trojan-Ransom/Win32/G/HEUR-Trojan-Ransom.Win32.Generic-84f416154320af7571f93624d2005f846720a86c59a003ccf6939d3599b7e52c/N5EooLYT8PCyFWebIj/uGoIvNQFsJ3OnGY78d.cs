using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using IMq10UgvcxZ8IijO78;
using Iladlw9EdfUBDpkdfI;

namespace N5EooLYT8PCyFWebIj;

internal class uGoIvNQFsJ3OnGY78d
{
	private delegate void KpKlMULmPG9pnFPADk(object o);

	internal class DPWfmrMX97fkqfs0SW : Attribute
	{
		internal class VHaqdoW6xuLxtHGOSL<PGdPRDbqFAU91BWE5L>
		{
			private static object YaCrnH6G18YiGyT079f;

			static VHaqdoW6xuLxtHGOSL()
			{
				nIq4V2sach();
				PLK4lkeQh3();
			}

			internal static bool SoC0J563dvaZHGaloMo()
			{
				return true;
			}

			internal static object RwdLCv6TenBuAI84a6T()
			{
				return null;
			}
		}

		[DPWfmrMX97fkqfs0SW(typeof(VHaqdoW6xuLxtHGOSL<object>[]))]
		public DPWfmrMX97fkqfs0SW(object object_0)
		{
		}

		static DPWfmrMX97fkqfs0SW()
		{
			nIq4V2sach();
		}
	}

	internal class B16oocF4adbniNscMS
	{
		[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
		internal static string hbaKj4cwZY(object object_0, object object_1)
		{
			return null;
		}

		internal static object n6YOUR6kvVElCbhvHf5(object object_0, object object_1)
		{
			return null;
		}

		internal static void loD3WX6BNQLMrRvg7Qe(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static object bmTIWK6a5dVum4qr8oa()
		{
			return null;
		}

		internal static object ivcIDG6zCFDeFRsrnXi(object object_0)
		{
			return null;
		}

		internal static void UGkyeqq9o0q4Kl3qRYm(object object_0, object object_1)
		{
		}

		internal static object w4Y7KWq6CG1TfSYk6Ot(object object_0)
		{
			return null;
		}

		internal static void kZfP9Vqq5ry3DVKSMaX(object object_0)
		{
		}

		internal static object ysxX00qS0Ln3em30SeJ(object object_0)
		{
			return null;
		}

		static B16oocF4adbniNscMS()
		{
			nIq4V2sach();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint lCvkUik0j3csWuLBtF(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr WIZ8WE02qlCAiCa8dc();

	internal struct bZYeaHi8qu2JN9K2Ig
	{
		internal bool gmsKVnQ4m9;

		internal byte[] I6SKfYay1R;
	}

	internal class WpWSp8jcj2DZFKf0eg
	{
		private object JgwK7uCsSv;

		public WpWSp8jcj2DZFKf0eg(Stream stream_0)
		{
			JgwK7uCsSv = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return (Stream)dAxArEqg7B5RAySOmDH(JgwK7uCsSv);
		}

		internal byte[] IQoKuYktS8(int int_0)
		{
			return (byte[])TeUGZLqZBKBXOB9GeRA(JgwK7uCsSv, int_0);
		}

		internal int UTsKCsX8sc(byte[] byte_0, int int_0, int int_1)
		{
			return ((BinaryReader)JgwK7uCsSv).Read(byte_0, int_0, int_1);
		}

		internal int FZdKZeItnh()
		{
			return ((BinaryReader)JgwK7uCsSv).ReadInt32();
		}

		internal void H5KKpC0KrM()
		{
			A3DeAOqoXrNLFmwFybj(JgwK7uCsSv);
		}

		internal static object dAxArEqg7B5RAySOmDH(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static object TeUGZLqZBKBXOB9GeRA(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static void A3DeAOqoXrNLFmwFybj(object object_0)
		{
			((BinaryReader)object_0).Close();
		}

		static WpWSp8jcj2DZFKf0eg()
		{
			nIq4V2sach();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr icC6nIVGBFhB69Ylsp(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr XCwgpifE3xFlBfM6Wv(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int zBtj2uuYZIqVTYWK55(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int vde6YmCaEBtR0qByJH(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr agn9EIZBDAmx3RK2RA(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int YHaUP8p8a3eZjxkM9I(IntPtr ptr);

	[Flags]
	private enum K8R1q578nEBETPsLFo
	{

	}

	private static object lnR43ylFmM;

	private static object XUPKMwXeG0;

	private static bool U2rKeSFOox;

	internal static object uMu4z0CoEH;

	private static IntPtr zlDKij8xjM;

	private static bool jCy4trv8re;

	private static bool zL34aF4R7Q;

	private static object z6mKFTgMRW;

	private static long Gct4PJtVDZ;

	internal static object mN74oSlkhV;

	internal static object JYvKLCsA8k;

	private static bool aEM4TbtNAl;

	private static int rd3Kl3CSNZ;

	private static object LAb4BiMjSn;

	private static object y0H4DQhsE1;

	internal static object TNYKXullJB;

	private static object fDYK0hjZI7;

	private static object sP5KkW1hLy;

	private static IntPtr QbE48aRxqV;

	private static bool coy4sKCp1Q;

	private static IntPtr P7U424DnLT;

	private static object H6Y41I2yjW;

	private static object FH6KbuqAuI;

	private static object u5k4HP3rox;

	private static int NJC4nAkHQv;

	private static object P9W4x1MrTD;

	private static bool l5EKmBSvxH;

	private static object VJ44Jgj2MN;

	private static object S8tKWJwl9Q;

	private static int JIVKKia87p;

	private static IntPtr w9iKQtMBCF;

	private static long KaGK4PkRSg;

	[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
	private static bool NR5KYwdw7d;

	private static Dictionary<int, int> gYj4rDRrrQ;

	internal static object N1f45syP8S;

	private static object vU24Etuy5G;

	private static int GPj4GGybN5;

	static uGoIvNQFsJ3OnGY78d()
	{
		zL34aF4R7Q = false;
		mN74oSlkhV = Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554453)).Assembly;
		lnR43ylFmM = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		coy4sKCp1Q = false;
		jCy4trv8re = false;
		H6Y41I2yjW = new byte[0];
		N1f45syP8S = null;
		gYj4rDRrrQ = null;
		y0H4DQhsE1 = new object();
		vU24Etuy5G = new byte[0];
		VJ44Jgj2MN = new byte[0];
		P7U424DnLT = IntPtr.Zero;
		QbE48aRxqV = IntPtr.Zero;
		u5k4HP3rox = new string[0];
		P9W4x1MrTD = new int[0];
		NJC4nAkHQv = 1;
		aEM4TbtNAl = false;
		LAb4BiMjSn = new SortedList();
		GPj4GGybN5 = 0;
		Gct4PJtVDZ = 0L;
		uMu4z0CoEH = null;
		TNYKXullJB = null;
		KaGK4PkRSg = 0L;
		JIVKKia87p = 0;
		U2rKeSFOox = false;
		l5EKmBSvxH = false;
		rd3Kl3CSNZ = 0;
		w9iKQtMBCF = IntPtr.Zero;
		NR5KYwdw7d = false;
		JYvKLCsA8k = new Hashtable();
		XUPKMwXeG0 = null;
		S8tKWJwl9Q = null;
		FH6KbuqAuI = null;
		z6mKFTgMRW = null;
		sP5KkW1hLy = null;
		fDYK0hjZI7 = null;
		zlDKij8xjM = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void eVaghuZAXgvU8()
	{
	}

	internal static byte[] S7VHl5Cul(object object_0)
	{
		uint[] array = new uint[16];
		int num = 448 - ((Array)object_0).Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(((Array)object_0).Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(((Array)object_0).Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < ((Array)object_0).Length; i++)
		{
			array2[i] = ((byte[])object_0)[i];
		}
		array2[((Array)object_0).Length] |= 128;
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
			WVAxqOuAS(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			WVAxqOuAS(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			WVAxqOuAS(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			WVAxqOuAS(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			WVAxqOuAS(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			WVAxqOuAS(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			WVAxqOuAS(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			WVAxqOuAS(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			WVAxqOuAS(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			WVAxqOuAS(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			WVAxqOuAS(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			WVAxqOuAS(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			WVAxqOuAS(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			WVAxqOuAS(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			WVAxqOuAS(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			WVAxqOuAS(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			eYInladlw(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			eYInladlw(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			eYInladlw(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			eYInladlw(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			eYInladlw(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			eYInladlw(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			eYInladlw(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			eYInladlw(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			eYInladlw(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			eYInladlw(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			eYInladlw(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			eYInladlw(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			eYInladlw(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			eYInladlw(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			eYInladlw(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			eYInladlw(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			PdfTUBDpk(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			PdfTUBDpk(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			PdfTUBDpk(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			PdfTUBDpk(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			PdfTUBDpk(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			PdfTUBDpk(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			PdfTUBDpk(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			PdfTUBDpk(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			PdfTUBDpk(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			PdfTUBDpk(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			PdfTUBDpk(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			PdfTUBDpk(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			PdfTUBDpk(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			PdfTUBDpk(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			PdfTUBDpk(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			PdfTUBDpk(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			CfIBEJ0W5(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			CfIBEJ0W5(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			CfIBEJ0W5(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			CfIBEJ0W5(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			CfIBEJ0W5(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			CfIBEJ0W5(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			CfIBEJ0W5(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			CfIBEJ0W5(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			CfIBEJ0W5(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			CfIBEJ0W5(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			CfIBEJ0W5(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			CfIBEJ0W5(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			CfIBEJ0W5(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			CfIBEJ0W5(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			CfIBEJ0W5(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			CfIBEJ0W5(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void WVAxqOuAS(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Pa2GmZBEI(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])lnR43ylFmM)[uint_5 - 1], ushort_0);
	}

	private static void eYInladlw(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Pa2GmZBEI(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])lnR43ylFmM)[uint_5 - 1], ushort_0);
	}

	private static void PdfTUBDpk(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Pa2GmZBEI(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_0)[uint_4] + ((uint[])lnR43ylFmM)[uint_5 - 1], ushort_0);
	}

	private static void CfIBEJ0W5(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + Pa2GmZBEI(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])lnR43ylFmM)[uint_5 - 1], ushort_0);
	}

	private static uint Pa2GmZBEI(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool DYYPWEwgH()
	{
		if (!coy4sKCp1Q)
		{
			lnQ4XC57pf();
			coy4sKCp1Q = true;
		}
		return jCy4trv8re;
	}

	internal static SymmetricAlgorithm YpYzudYx0()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (DYYPWEwgH())
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

	internal static void lnQ4XC57pf()
	{
		try
		{
			jCy4trv8re = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] QYa44QWthv(object object_0)
	{
		if (!DYYPWEwgH())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])object_0);
		}
		return S7VHl5Cul(object_0);
	}

	internal static void UBX4KyPds4(object object_0, object object_1, uint uint_0, object object_2)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)((Array)object_2).Length) ? ((Array)object_2).Length : ((int)uint_0));
			((Stream)object_1).Read((byte[])object_2, 0, num);
			zU44e3t6es(object_0, object_2, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void zU44e3t6es(object object_0, object object_1, int int_0, int int_1)
	{
		((HashAlgorithm)object_0).TransformBlock((byte[])object_1, int_0, int_1, (byte[]?)object_1, int_0);
	}

	internal static uint qLO4mHhGMj(uint uint_0, int int_0, long long_0, object object_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_0)
			{
				((BinaryReader)object_0).BaseStream.Position = long_0 + (num * 40 + 8);
				uint num2 = ((BinaryReader)object_0).ReadUInt32();
				num3 = ((BinaryReader)object_0).ReadUInt32();
				((BinaryReader)object_0).ReadUInt32();
				num4 = ((BinaryReader)object_0).ReadUInt32();
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

	[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
	internal static void PLK4lkeQh3()
	{
		int num = 7;
		bool flag = default(bool);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num25 = default(int);
		int num24 = default(int);
		int num23 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_8 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		byte[] array5 = default(byte[]);
		byte[] object_7 = default(byte[]);
		byte[] object_6 = default(byte[]);
		int num27 = default(int);
		string text = default(string);
		HashAlgorithm object_ = default(HashAlgorithm);
		string object_2 = default(string);
		int num21 = default(int);
		byte[] array = default(byte[]);
		BinaryReader object_3 = default(BinaryReader);
		uint num14 = default(uint);
		uint num15 = default(uint);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		long num13 = default(long);
		int num7 = default(int);
		long long_ = default(long);
		int num6 = default(int);
		bool flag2 = default(bool);
		uint uint_2 = default(uint);
		uint num8 = default(uint);
		uint num17 = default(uint);
		uint num12 = default(uint);
		long num10 = default(long);
		uint num16 = default(uint);
		long num9 = default(long);
		int int_ = default(int);
		uint uint_ = default(uint);
		long num11 = default(long);
		int num19 = default(int);
		while (N1f45syP8S == null)
		{
			while (true)
			{
				IL_0013:
				eHfK5fjaEWQPjveOfT();
				int num2 = 15;
				if (YwX0VgXTbwtAy8AMIL())
				{
					goto IL_0027;
				}
				goto IL_1fe0;
				IL_1fe0:
				num2 = num;
				goto IL_0027;
				IL_0027:
				while (true)
				{
					switch (num2)
					{
					case 7:
						break;
					case 3:
						goto IL_0013;
					default:
						return;
					case 19:
						flag = false;
						goto case 10;
					case 10:
						try
						{
							WpWSp8jcj2DZFKf0eg object_4 = new WpWSp8jcj2DZFKf0eg((Stream)L6m7ZU6DchSjQbaUeo(mN74oSlkhV, "6kTd3fEqR0OCdXVGeY.9hU5gUuLTpj9HhAgaS"));
							int num22 = 69;
							if (Ss9Yv7LL5i9FMGOAui() != null)
							{
								goto IL_00c9;
							}
							goto IL_1a50;
							IL_1a50:
							while (true)
							{
								switch (num22)
								{
								case 327:
									array3[11] = 76;
									num22 = 261;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 326:
									array4[9] = 115;
									goto case 279;
								case 279:
									array4[9] = 148;
									num25 = 305;
									goto case 305;
								case 305:
									num24 = 111;
									num22 = 247;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 287;
								case 287:
									array4[9] = (byte)num24;
									num22 = 81;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 325:
									array3[10] = 52;
									goto case 161;
								case 161:
									num23 = 160;
									goto case 160;
								case 160:
									array3[10] = (byte)num23;
									goto case 278;
								case 278:
									num23 = 161;
									goto case 9;
								case 9:
									array3[10] = (byte)num23;
									goto case 281;
								case 281:
									array3[10] = 69;
									num22 = 243;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 324:
									num23 = 95;
									goto case 70;
								case 70:
									array3[16] = (byte)num23;
									goto case 123;
								case 123:
									array3[17] = 136;
									goto case 83;
								case 83:
									num23 = 218;
									goto case 197;
								case 197:
									array3[17] = (byte)num23;
									num22 = 150;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 10;
								case 10:
									array3[10] = (byte)num23;
									num22 = 327;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 211;
								case 211:
									array3[2] = 42;
									num22 = 93;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 264;
								case 264:
									array3[2] = 104;
									goto case 68;
								case 68:
									array3[2] = 156;
									num25 = 209;
									goto case 209;
								case 209:
									array3[2] = 102;
									goto case 238;
								case 238:
									array3[2] = 129;
									num25 = 176;
									goto case 176;
								case 176:
									array3[3] = 86;
									goto case 44;
								case 44:
									array3[3] = 126;
									goto case 99;
								case 99:
									array3[3] = 142;
									goto case 105;
								case 105:
									array3[3] = 142;
									num22 = 126;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 274;
								case 274:
									array3[3] = 37;
									goto case 301;
								case 301:
									array3[4] = 72;
									goto case 216;
								case 216:
									num23 = 162;
									num22 = 323;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 323:
									array3[4] = (byte)num23;
									goto case 306;
								case 306:
									num23 = 118;
									goto case 22;
								case 22:
									array3[4] = (byte)num23;
									num22 = 101;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 87;
								case 87:
									array3[19] = (byte)num23;
									goto case 58;
								case 58:
									array3[20] = 89;
									goto case 11;
								case 11:
									num23 = 136;
									num25 = 140;
									goto case 140;
								case 140:
									array3[20] = (byte)num23;
									num22 = 312;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 322:
									array3[16] = (byte)num23;
									goto case 324;
								case 321:
									array3[18] = (byte)num23;
									num22 = 260;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 320:
									array3[28] = (byte)num23;
									goto case 241;
								case 241:
									array3[28] = 130;
									num22 = 272;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 253;
								case 253:
									num23 = 74;
									num22 = 248;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 319:
									stream = (Stream)GIwd9kwCw1vleL4Tty();
									goto case 293;
								case 293:
									object_8 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
									num22 = 315;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 318:
									num23 = 128;
									goto case 113;
								case 113:
									array3[1] = (byte)num23;
									goto case 211;
								case 317:
									object_5 = (SymmetricAlgorithm)l4YRtG5ndNQqnG0UFU();
									num22 = 194;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 316:
									num23 = 91;
									goto case 121;
								case 121:
									array3[5] = (byte)num23;
									num22 = 186;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 315:
									b2oxm2dyQ7FU2nyEkN(object_8, array5, 0, array5.Length);
									num22 = 134;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 17;
								case 17:
									array4[10] = (byte)num24;
									num22 = 289;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 314:
									array4[0] = (byte)num24;
									goto case 147;
								case 147:
									array4[0] = 145;
									num22 = 309;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 104;
								case 104:
									num23 = 158;
									goto case 257;
								case 257:
									array3[14] = (byte)num23;
									num22 = 267;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 313:
									num23 = 182;
									goto case 288;
								case 288:
									array3[23] = (byte)num23;
									goto case 15;
								case 15:
									num23 = 191;
									goto case 130;
								case 130:
									array3[23] = (byte)num23;
									goto case 233;
								case 233:
									array3[24] = 84;
									goto case 169;
								case 169:
									num23 = 137;
									num22 = 184;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 312:
									num23 = 146;
									num22 = 65;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 311:
									array3[30] = 132;
									num25 = 247;
									goto case 247;
								case 247:
									array3[30] = 195;
									goto case 270;
								case 270:
									array3[30] = 19;
									num22 = 12;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 5;
								case 5:
									array4[8] = 239;
									goto case 326;
								case 310:
									num24 = 163;
									num22 = 314;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 309:
									num24 = 111;
									goto case 118;
								case 118:
									array4[0] = (byte)num24;
									num22 = 145;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 1;
								case 1:
									array3[22] = (byte)num23;
									num22 = 45;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 78;
								case 78:
									array3[23] = 89;
									num22 = 313;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 308:
									array3[0] = (byte)num23;
									num22 = 295;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 307:
									array3[17] = (byte)num23;
									goto case 50;
								case 50:
									num23 = 110;
									goto case 173;
								case 173:
									array3[17] = (byte)num23;
									goto case 179;
								case 179:
									array3[17] = 86;
									goto case 225;
								case 225:
									array3[18] = 108;
									goto case 138;
								case 138:
									array3[18] = 152;
									goto case 136;
								case 136:
									array3[18] = 134;
									goto case 116;
								case 116:
									num23 = 164;
									goto case 321;
								case 304:
									num24 = 112;
									num22 = 214;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 209;
								case 303:
									num23 = 149;
									num22 = 50;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 59;
								case 59:
									array3[9] = (byte)num23;
									goto case 88;
								case 88:
									array3[9] = 166;
									goto case 172;
								case 172:
									array3[9] = 64;
									num22 = 231;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 7;
								case 7:
									array4[13] = 154;
									num22 = 164;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 302:
									num23 = 88;
									goto case 263;
								case 263:
									array3[19] = (byte)num23;
									num22 = 60;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 300:
									array3[0] = 77;
									goto case 210;
								case 210:
									num23 = 122;
									goto case 250;
								case 250:
									array3[1] = (byte)num23;
									num22 = 46;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 139;
								case 139:
									num23 = 153;
									num25 = 135;
									goto case 135;
								case 135:
									array3[1] = (byte)num23;
									goto case 30;
								case 30:
									num23 = 140;
									num22 = 189;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 39;
								case 39:
									num23 = 65;
									goto case 246;
								case 246:
									array3[21] = (byte)num23;
									goto case 165;
								case 165:
									num23 = 6;
									goto case 282;
								case 282:
									array3[21] = (byte)num23;
									goto case 162;
								case 162:
									array3[22] = 121;
									num25 = 149;
									goto case 149;
								case 149:
									array3[22] = 144;
									goto case 143;
								case 143:
									array3[22] = 93;
									goto case 41;
								case 41:
									num23 = 117;
									num22 = 1;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 299:
									num23 = 114;
									goto case 205;
								case 205:
									array3[16] = (byte)num23;
									goto case 54;
								case 54:
									array3[16] = 159;
									num22 = 158;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 298:
									num23 = 166;
									goto case 72;
								case 72:
									array3[29] = (byte)num23;
									goto case 126;
								case 126:
									array3[29] = 106;
									goto case 2;
								case 2:
									num23 = 39;
									goto case 255;
								case 255:
									array3[29] = (byte)num23;
									num22 = 269;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 160;
								case 297:
									array3[15] = 97;
									goto case 125;
								case 125:
									array3[15] = 152;
									num22 = 182;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 296:
									num24 = 190;
									goto case 66;
								case 66:
									array4[2] = (byte)num24;
									goto case 42;
								case 42:
									array4[2] = 216;
									num22 = 291;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 295:
									num23 = 156;
									goto case 56;
								case 56:
									array3[0] = (byte)num23;
									goto case 300;
								case 294:
									array3[24] = 62;
									goto case 115;
								case 115:
									array3[25] = 162;
									num22 = 155;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 271;
								case 271:
									num23 = 211;
									num25 = 25;
									goto case 25;
								case 25:
									array3[25] = (byte)num23;
									num25 = 40;
									goto case 40;
								case 40:
									num23 = 104;
									num22 = 142;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 180;
								case 180:
									array3[25] = (byte)num23;
									num22 = 41;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 76;
								case 76:
									num23 = 124;
									goto case 37;
								case 37:
									array3[25] = (byte)num23;
									num22 = 217;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 292:
									num23 = 194;
									num25 = 208;
									goto case 208;
								case 208:
									array3[8] = (byte)num23;
									goto case 262;
								case 262:
									num23 = 134;
									num22 = 57;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 224;
								case 224:
									array3[9] = (byte)num23;
									goto case 111;
								case 111:
									num23 = 168;
									goto case 201;
								case 201:
									array3[9] = (byte)num23;
									goto case 8;
								case 8:
									array3[9] = 146;
									goto case 303;
								case 291:
									array4[3] = 136;
									num22 = 124;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 34;
								case 34:
									array3[13] = 197;
									goto case 21;
								case 21:
									array3[14] = 180;
									num22 = 104;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 84;
								case 84:
									array4[15] = 133;
									num25 = 276;
									goto case 276;
								case 276:
									num24 = 132;
									goto case 222;
								case 222:
									array4[15] = (byte)num24;
									goto case 234;
								case 234:
									num24 = 33;
									goto case 64;
								case 64:
									array4[15] = (byte)num24;
									goto case 183;
								case 183:
									object_7 = array4;
									goto case 317;
								case 290:
									array3[5] = 152;
									goto case 129;
								case 129:
									num23 = 142;
									goto case 137;
								case 137:
									array3[5] = (byte)num23;
									num22 = 255;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 316;
								case 289:
									array4[10] = 168;
									num22 = 180;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 251;
								case 251:
									num24 = 7;
									goto case 280;
								case 280:
									array4[10] = (byte)num24;
									goto case 112;
								case 112:
									num24 = 92;
									goto case 31;
								case 31:
									array4[11] = (byte)num24;
									num22 = 85;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 286:
									array3[14] = 98;
									goto case 29;
								case 29:
									num23 = 74;
									num22 = 191;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 285:
									array4[6] = (byte)num24;
									goto case 119;
								case 119:
									array4[6] = 202;
									num22 = 265;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 284:
									array3[12] = 108;
									num22 = 6;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 283:
									array4[8] = (byte)num24;
									num25 = 35;
									goto case 35;
								case 35:
									array4[8] = 78;
									num22 = 1;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 5;
								case 277:
									array4[1] = (byte)num24;
									goto case 141;
								case 141:
									array4[1] = 227;
									num25 = 94;
									goto case 94;
								case 94:
									array4[2] = 135;
									goto case 223;
								case 223:
									array4[2] = 160;
									num22 = 108;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 275:
									num24 = 136;
									goto case 28;
								case 28:
									array4[5] = (byte)num24;
									num22 = 304;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 260;
								case 260:
									num23 = 157;
									goto case 61;
								case 61:
									array3[19] = (byte)num23;
									num22 = 229;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 273:
									num24 = 95;
									num22 = 277;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 272:
									num23 = 38;
									num22 = 254;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 269:
									array3[29] = 45;
									goto case 107;
								case 107:
									num23 = 88;
									goto case 195;
								case 195:
									array3[30] = (byte)num23;
									goto case 177;
								case 177:
									num23 = 199;
									num25 = 190;
									goto case 190;
								case 190:
									array3[30] = (byte)num23;
									goto case 311;
								case 268:
									array3 = new byte[32];
									num22 = 144;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 267:
									array3[14] = 138;
									num25 = 286;
									goto case 286;
								case 266:
									array3[5] = 103;
									goto case 290;
								case 265:
									array4[7] = 86;
									num25 = 236;
									goto case 236;
								case 236:
									num24 = 168;
									goto case 114;
								case 114:
									array4[7] = (byte)num24;
									num22 = 75;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 261:
									num23 = 167;
									goto case 239;
								case 239:
									array3[11] = (byte)num23;
									goto case 196;
								case 196:
									array3[11] = 76;
									goto case 96;
								case 96:
									array3[11] = 100;
									num22 = 156;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 259:
									array3[31] = (byte)num23;
									goto case 57;
								case 57:
									object_6 = array3;
									num25 = 185;
									goto case 185;
								case 185:
									array4 = new byte[16];
									goto case 62;
								case 62:
									array4[0] = 117;
									goto case 220;
								case 220:
									array4[0] = 156;
									goto case 235;
								case 235:
									num24 = 154;
									num22 = 206;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 258:
									array3[30] = (byte)num23;
									goto case 89;
								case 89:
									array3[31] = 103;
									num25 = 110;
									goto case 110;
								case 110:
									array3[31] = 159;
									num22 = 151;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 256:
									num24 = 111;
									goto case 49;
								case 49:
									array4[14] = (byte)num24;
									goto case 91;
								case 91:
									array4[15] = 187;
									goto case 84;
								case 254:
									array3[28] = (byte)num23;
									num22 = 70;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 298;
								case 252:
									array4[14] = 122;
									goto case 256;
								case 249:
									array3[13] = (byte)num23;
									goto case 46;
								case 46:
									num23 = 154;
									num22 = 106;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 248:
									array3[26] = (byte)num23;
									num22 = 18;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 245:
									array3[27] = 110;
									goto case 103;
								case 103:
									array3[27] = 148;
									goto case 192;
								case 192:
									array3[27] = 54;
									goto case 200;
								case 200:
									num23 = 129;
									goto case 320;
								case 244:
									array3[19] = (byte)num23;
									num22 = 267;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 302;
								case 243:
									num23 = 77;
									goto case 10;
								case 242:
									array3[12] = 126;
									num22 = 4;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 131;
								case 131:
									num23 = 152;
									num22 = 249;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 240:
									array4[4] = 179;
									num25 = 52;
									goto case 52;
								case 52:
									num24 = 94;
									goto case 175;
								case 175:
									array4[4] = (byte)num24;
									goto case 117;
								case 117:
									array4[4] = 180;
									goto case 128;
								case 128:
									num24 = 77;
									goto case 97;
								case 97:
									array4[5] = (byte)num24;
									goto case 188;
								case 188:
									array4[5] = 99;
									num22 = 6;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 77;
								case 77:
									num24 = 88;
									goto case 163;
								case 163:
									array4[5] = (byte)num24;
									goto case 275;
								case 237:
									array4[14] = (byte)num24;
									num22 = 252;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 187;
								case 187:
									array3[21] = 120;
									num22 = 39;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 232:
									array3[15] = (byte)num23;
									goto case 297;
								case 231:
									num23 = 88;
									goto case 193;
								case 193:
									array3[10] = (byte)num23;
									num22 = 325;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 230:
									num23 = 148;
									goto case 259;
								case 229:
									num23 = 175;
									num22 = 166;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 244;
								case 228:
									array4[3] = 91;
									num22 = 218;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 227:
									array4[7] = 148;
									goto case 152;
								case 152:
									num24 = 109;
									num22 = 24;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 11;
								case 226:
									array3[7] = (byte)num23;
									goto case 154;
								case 154:
									num23 = 230;
									num22 = 80;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 221:
									array3[24] = 143;
									num22 = 4;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 219:
									num23 = 122;
									goto case 322;
								case 218:
									array4[4] = 165;
									num22 = 211;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 240;
								case 217:
									num23 = 207;
									goto case 86;
								case 86:
									array3[25] = (byte)num23;
									goto case 133;
								case 133:
									array3[26] = 124;
									goto case 170;
								case 170:
									array3[26] = 118;
									num22 = 253;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 171;
								case 171:
									num24 = 89;
									goto case 237;
								case 215:
									array3[27] = (byte)num23;
									goto case 245;
								case 214:
									array4[6] = (byte)num24;
									num22 = 178;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 213:
									num23 = 168;
									goto case 27;
								case 27:
									array3[8] = (byte)num23;
									num22 = 92;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 292;
								case 212:
									array4[1] = 99;
									num22 = 71;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 207:
									num23 = 127;
									goto case 26;
								case 26:
									array3[8] = (byte)num23;
									goto case 73;
								case 73:
									array3[8] = 139;
									num25 = 213;
									goto case 213;
								case 206:
									array4[0] = (byte)num24;
									goto case 310;
								case 204:
									array3[7] = (byte)num23;
									goto case 155;
								case 155:
									num23 = 130;
									goto case 226;
								case 203:
									array3[6] = 134;
									goto case 120;
								case 120:
									num23 = 43;
									num22 = 23;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 202:
									array5 = (byte[])tTjHVV0t9CRyRL2qYE(object_4, (int)LtDHjbIM9ngfvy5SLC(aKTn63eVaWLosCcKbI(object_4)));
									goto case 268;
								case 199:
									num23 = 128;
									num22 = 232;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 198:
									array3[12] = 140;
									num22 = 284;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 194:
									cV5POdCpf6EmwhCnhe(object_5, CipherMode.CBC);
									num22 = 92;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 191:
									array3[14] = (byte)num23;
									num22 = 51;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 189:
									array3[1] = (byte)num23;
									num22 = 0;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 186:
									array3[5] = 47;
									num22 = 181;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 184:
									array3[24] = (byte)num23;
									num22 = 221;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 182:
									array3[16] = 97;
									num22 = 274;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 299;
								case 181:
									array3[6] = 42;
									goto case 153;
								case 153:
									array3[6] = 152;
									goto case 203;
								case 178:
									num24 = 86;
									goto case 285;
								case 174:
									num24 = 145;
									goto case 36;
								case 36:
									array4[11] = (byte)num24;
									goto case 157;
								case 157:
									num24 = 105;
									goto case 98;
								case 98:
									array4[12] = (byte)num24;
									goto case 53;
								case 53:
									array4[12] = 82;
									goto case 146;
								case 146:
									num24 = 105;
									num22 = 60;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 109;
								case 109:
									array4[12] = (byte)num24;
									num25 = 167;
									goto case 167;
								case 167:
									array4[12] = 22;
									goto case 82;
								case 82:
									array4[13] = 120;
									goto case 90;
								case 90:
									num24 = 158;
									goto case 16;
								case 16:
									array4[13] = (byte)num24;
									goto case 7;
								case 168:
									array4[1] = (byte)num24;
									num22 = 55;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 166:
									array4[8] = 183;
									goto case 100;
								case 100:
									num24 = 102;
									num22 = 283;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 164:
									num24 = 77;
									num25 = 33;
									goto case 33;
								case 33:
									array4[13] = (byte)num24;
									num25 = 32;
									goto case 32;
								case 32:
									array4[14] = 196;
									num22 = 18;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 171;
								case 159:
									array4[7] = (byte)num24;
									goto case 95;
								case 95:
									array4[7] = 84;
									num25 = 227;
									goto case 227;
								case 158:
									array3[16] = 156;
									num25 = 219;
									goto case 219;
								case 156:
									array3[12] = 156;
									goto case 198;
								case 151:
									num23 = 110;
									num22 = 48;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 45;
								case 45:
									num23 = 179;
									goto case 127;
								case 127:
									array3[8] = (byte)num23;
									num25 = 207;
									goto case 207;
								case 150:
									num23 = 119;
									goto case 307;
								case 148:
									BGp11Qu4FwS261bQq0(stream);
									goto case 102;
								case 102:
									BGp11Qu4FwS261bQq0(object_8);
									num22 = 3;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 3;
								case 145:
									array4[1] = 162;
									goto case 212;
								case 144:
									num23 = 114;
									goto case 308;
								case 142:
									array4[2] = (byte)num24;
									num25 = 296;
									goto case 296;
								case 134:
									pVLLoOlr7quoKeuefk(object_8);
									num22 = 43;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 29;
								case 132:
									array3[1] = (byte)num23;
									goto case 14;
								case 14:
									array3[1] = 114;
									num22 = 318;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 66;
								case 124:
									num24 = 122;
									goto case 13;
								case 13:
									array4[3] = (byte)num24;
									goto case 228;
								case 122:
									array3[8] = 159;
									num22 = 45;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 44;
								case 108:
									num24 = 21;
									goto case 142;
								case 106:
									array3[13] = (byte)num23;
									goto case 34;
								case 101:
									num23 = 127;
									goto case 20;
								case 20:
									array3[5] = (byte)num23;
									goto case 266;
								case 92:
									transform = (ICryptoTransform)vIJ0MLtW7AnJ1nDOev(object_5, object_6, object_7);
									goto case 319;
								case 85:
									array4[11] = 177;
									goto case 67;
								case 67:
									array4[11] = 203;
									num22 = 174;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 81:
									num24 = 148;
									num25 = 17;
									goto case 17;
								case 80:
									array3[7] = (byte)num23;
									num22 = 122;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 78;
								case 79:
									num23 = 159;
									num22 = 204;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 75:
									num24 = 177;
									goto case 159;
								case 74:
									array3[15] = (byte)num23;
									goto case 199;
								case 71:
									num24 = 86;
									goto case 168;
								case 69:
									IliwvIOGtPFAmXMktw(aKTn63eVaWLosCcKbI(object_4), 0L);
									goto case 202;
								case 65:
									array3[20] = (byte)num23;
									goto case 38;
								case 38:
									array3[20] = 253;
									num22 = 187;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 63:
									num23 = 81;
									goto case 87;
								case 60:
									array3[19] = 190;
									num22 = 63;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 55:
									array4[1] = 135;
									goto case 273;
								case 51:
									num23 = 53;
									goto case 74;
								case 48:
									array3[31] = (byte)num23;
									goto case 19;
								case 19:
									array3[31] = 106;
									goto case 230;
								case 47:
									array3[24] = (byte)num23;
									num22 = 294;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 43:
									agpOs9NhIMR33SwJJN(N1f45syP8S, H28eTLPO9eIbPbJJpN(a8tmo8QOBPBhisQoAR(), A2P01xB81tgCMGWUZZ(stream)));
									goto case 148;
								case 24:
									array4[8] = (byte)num24;
									num22 = 166;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 23:
									array3[6] = (byte)num23;
									num22 = 79;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 18:
									num23 = 63;
									goto case 215;
								case 12:
									num23 = 81;
									num22 = 258;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 6:
									array3[12] = 168;
									num22 = 168;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 242;
								case 4:
									num23 = 212;
									goto case 47;
								default:
									num23 = 74;
									num22 = 91;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 132;
								case 3:
									ef1G1roFwdI0cgdy7q(object_4);
									goto end_IL_1a50;
								case 93:
									goto end_IL_1a50;
								}
								goto IL_00c9;
								continue;
								end_IL_1a50:
								break;
							}
							goto end_IL_0085;
							IL_00c9:
							num22 = num25;
							goto IL_1a50;
							end_IL_0085:;
						}
						catch
						{
							int num26 = 0;
							if (Ss9Yv7LL5i9FMGOAui() != null)
							{
								num26 = num27;
							}
							while (true)
							{
								switch (num26)
								{
								default:
									flag = true;
									num26 = 0;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									break;
								case 1:
									break;
								}
								break;
							}
						}
						goto case 12;
					case 13:
						goto IL_1fcd;
					case 18:
						N1f45syP8S = new RSACryptoServiceProvider();
						goto case 4;
					case 4:
						text = (string)CeFZwVpumtSHwpEnXy(brhDxCqtHGQV0CvqGs(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly);
						goto case 14;
					case 14:
						if (text == null)
						{
							return;
						}
						goto case 8;
					case 8:
						if (bufEkV22dYqr7oF4Oh(text) == 0)
						{
							return;
						}
						goto IL_201c;
					case 15:
						KNshnLU8T8POZveCdw(bool_0: true);
						num2 = 18;
						if (Ss9Yv7LL5i9FMGOAui() == null)
						{
							continue;
						}
						return;
					case 11:
						object_2 = null;
						goto case 9;
					case 9:
						try
						{
							object_ = (HashAlgorithm)IKrngw1ZiI7m5ncCTh();
							while (true)
							{
								IL_2086:
								object_2 = (string)jHKl8HEuq6AQaaAUb3("SHA1");
								int num20 = 0;
								if (Ss9Yv7LL5i9FMGOAui() != null)
								{
									goto IL_206b;
								}
								goto IL_206f;
								IL_206f:
								while (true)
								{
									switch (num20)
									{
									default:
										if (aeC8mxmXH4vxJXJnnI(text))
										{
											goto end_IL_206f;
										}
										goto IL_205e;
									case 3:
										break;
									case 1:
										return;
									case 2:
										goto end_IL_206f;
									}
									goto IL_2086;
									IL_205e:
									num20 = 1;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto IL_206b;
									continue;
									end_IL_206f:
									break;
								}
								break;
								IL_206b:
								num20 = num21;
								goto IL_206f;
							}
						}
						catch
						{
							if (Ss9Yv7LL5i9FMGOAui() == null)
							{
								switch (0)
								{
								}
							}
							return;
						}
						goto case 19;
					case 5:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num3 = 47;
							if (Ss9Yv7LL5i9FMGOAui() != null)
							{
								goto IL_2103;
							}
							goto IL_25c4;
							IL_25c4:
							while (true)
							{
								int num5;
								switch (num3)
								{
								case 73:
									array = (byte[])mcb3Mif8r7Wv5cbQO4(object_3, (int)num14);
									num3 = 60;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 72:
									iacc3pGa7ARqESRKj5(object_, fileStream, num15, array2);
									goto case 39;
								case 39:
								case 49:
								case 56:
									num4++;
									num3 = 19;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 71:
									array2[66] = 0;
									goto case 35;
								case 35:
									array2[67] = 0;
									num3 = 45;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 70:
									IliwvIOGtPFAmXMktw(fileStream, num13);
									goto case 55;
								case 55:
									iacc3pGa7ARqESRKj5(object_, fileStream, (uint)(num7 * 40), array2);
									goto case 42;
								case 42:
									long_ = X82LECA0n2nFZa1brh(fileStream);
									num6 = 21;
									goto case 21;
								case 21:
									if (flag2)
									{
										goto case 26;
									}
									goto case 69;
								case 26:
									IliwvIOGtPFAmXMktw(fileStream, 360L);
									goto case 22;
								case 69:
									IliwvIOGtPFAmXMktw(fileStream, 376L);
									goto case 22;
								case 22:
								case 48:
									uint_2 = RtfBrpZRReTDuHkdRH(object_3);
									goto case 33;
								case 33:
									num8 = XLAt4k9kc1mlbfKEK7(uint_2, num7, num13, object_3);
									goto case 43;
								case 43:
									IliwvIOGtPFAmXMktw(fileStream, num8 + 32);
									num3 = 50;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 68:
									array2[37] = 0;
									num3 = 16;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 67:
									num7 = eX9ttXM4xQaHsab4uI(object_3);
									goto case 70;
								case 10:
									num17 = RtfBrpZRReTDuHkdRH(object_3);
									goto case 51;
								case 51:
									IliwvIOGtPFAmXMktw(fileStream, num17);
									num3 = 61;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 52;
								case 52:
									if (num12 >= num15)
									{
										goto case 39;
									}
									goto case 36;
								case 36:
									num15 -= num12;
									num6 = 6;
									goto case 6;
								case 6:
									IliwvIOGtPFAmXMktw(fileStream, X82LECA0n2nFZa1brh(fileStream) + num12);
									num6 = 66;
									goto case 4;
								case 4:
								case 61:
								case 66:
									if (num15 == 0)
									{
										num3 = 56;
										if (Ss9Yv7LL5i9FMGOAui() == null)
										{
											continue;
										}
										goto case 10;
									}
									goto case 58;
								case 58:
									num10 = X82LECA0n2nFZa1brh(fileStream);
									num3 = 27;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 65:
									y8xk8EnT4E1LjRc1TX(object_, array2, 0, 128);
									num3 = 63;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 25;
								case 25:
									array2[36] = 0;
									goto case 68;
								case 64:
									num16 = (uint)IOsGqvTMJNNevocqdA(num9 - num10, num15);
									goto case 44;
								case 44:
									iacc3pGa7ARqESRKj5(object_, fileStream, num16, array2);
									num6 = 23;
									goto case 23;
								case 23:
									num15 -= num16;
									num3 = 4;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 63:
									num13 = X82LECA0n2nFZa1brh(fileStream);
									num3 = 0;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 59:
									flag2 = eX9ttXM4xQaHsab4uI(object_3) != 523;
									goto case 46;
								case 46:
									if (flag2)
									{
										num3 = 5;
										if (Ss9Yv7LL5i9FMGOAui() == null)
										{
											continue;
										}
										goto case 1;
									}
									goto case 11;
								case 1:
									num15 = RtfBrpZRReTDuHkdRH(object_3);
									goto case 10;
								case 11:
									num5 = 112;
									goto IL_234d;
								case 57:
									ip59h2JYw8Lwyk8YsK(fileStream, array2, 0, int_);
									goto case 38;
								case 38:
									array2[64] = 0;
									num3 = 7;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 54:
									num14 = RtfBrpZRReTDuHkdRH(object_3);
									num3 = 37;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 16;
								case 16:
									array2[38] = 0;
									goto case 53;
								case 53:
									array2[39] = 0;
									num3 = 25;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 65;
								case 50:
									uint_ = RtfBrpZRReTDuHkdRH(object_3);
									num3 = 34;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 54;
								case 47:
									object_3 = new BinaryReader(fileStream);
									num3 = 31;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 45:
									y8xk8EnT4E1LjRc1TX(object_, array2, 0, int_);
									goto case 32;
								case 32:
									ip59h2JYw8Lwyk8YsK(fileStream, array2, 0, 128);
									goto case 30;
								case 30:
									array2[32] = 0;
									goto case 18;
								case 18:
									array2[33] = 0;
									goto case 12;
								case 12:
									array2[34] = 0;
									goto case 41;
								case 41:
									array2[35] = 0;
									num6 = 25;
									goto case 25;
								case 40:
									if (num10 < num11)
									{
										goto case 64;
									}
									num3 = 72;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									goto case 14;
								case 14:
								case 29:
									IliwvIOGtPFAmXMktw(fileStream, num13 + num4 * 40 + 16L);
									num3 = 1;
									if (Ss9Yv7LL5i9FMGOAui() == null)
									{
										continue;
									}
									break;
								case 37:
									num9 = XLAt4k9kc1mlbfKEK7(uint_, num7, num13, object_3);
									goto case 9;
								case 9:
									num11 = num9 + num14;
									goto case 28;
								case 28:
									IliwvIOGtPFAmXMktw(fileStream, long_);
									num3 = 3;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 31:
									array2 = new byte[65536];
									num6 = 15;
									goto case 15;
								case 15:
									iacc3pGa7ARqESRKj5(object_, fileStream, 152u, array2);
									goto case 59;
								case 27:
									if (num9 > num10)
									{
										goto case 40;
									}
									num6 = 8;
									goto case 8;
								case 8:
									if (num10 >= num11)
									{
										goto case 40;
									}
									num3 = 9;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 17;
								case 17:
									num12 = (uint)(num11 - num10);
									goto case 52;
								case 24:
									CFNWnkh2oMcBni2ImA(object_, new byte[0], 0, 0);
									goto case 2;
								case 2:
									IliwvIOGtPFAmXMktw(fileStream, num9);
									num3 = 64;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 73;
								case 20:
									IliwvIOGtPFAmXMktw(fileStream, 152L);
									goto case 57;
								case 13:
								case 19:
									if (num4 < num7)
									{
										num6 = 29;
										goto case 14;
									}
									goto case 24;
								case 7:
									array2[65] = 0;
									num6 = 71;
									goto case 71;
								case 5:
									num5 = 96;
									goto IL_234d;
								case 3:
									num4 = 0;
									num3 = 0;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									goto case 13;
								default:
									IliwvIOGtPFAmXMktw(fileStream, 134L);
									num3 = 36;
									if (Ss9Yv7LL5i9FMGOAui() != null)
									{
										continue;
									}
									goto case 67;
								case 60:
									Q34L4WguXFwwx0UZPi(array);
									goto case 34;
								case 34:
									flag = !Y2qgf5DnanR8W6bou5(N1f45syP8S, rIQ1VKiBqiZL9yGP7W(object_), object_2, array);
									goto end_IL_25c4;
								case 62:
									goto end_IL_25c4;
									IL_234d:
									int_ = num5;
									num3 = 20;
									if (YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								}
								goto IL_2103;
								continue;
								end_IL_25c4:
								break;
							}
							goto end_IL_20ca;
							IL_2103:
							num3 = num6;
							goto IL_25c4;
							end_IL_20ca:;
						}
						catch
						{
							int num18 = 0;
							if (!YwX0VgXTbwtAy8AMIL())
							{
								num18 = num19;
							}
							while (true)
							{
								switch (num18)
								{
								default:
									flag = true;
									num18 = 0;
									if (!YwX0VgXTbwtAy8AMIL())
									{
										continue;
									}
									break;
								case 1:
									break;
								}
								break;
							}
						}
						goto case 17;
					case 2:
						goto IL_274a;
					case 17:
						if (!flag)
						{
							goto IL_1fcd;
						}
						goto case 16;
					case 12:
						if (!flag)
						{
							goto IL_1fbb;
						}
						goto case 17;
					case 0:
					case 6:
						return;
					case 16:
						throw new Exception((string?)WS7S9ZbOSDVHwOo18y(tEyaMj3sLUm6kdymbl(IiCJr9SpoMmrnhRZEW(brhDxCqtHGQV0CvqGs(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly)), " is tampered."));
					case 1:
						return;
					}
					break;
					IL_274a:
					object_ = null;
					num2 = 11;
					if (Ss9Yv7LL5i9FMGOAui() == null)
					{
						continue;
					}
					goto IL_1fe0;
					IL_201c:
					num2 = 2;
					if (Ss9Yv7LL5i9FMGOAui() == null)
					{
						continue;
					}
					goto IL_1fe0;
					IL_1fbb:
					num2 = 5;
					if (Ss9Yv7LL5i9FMGOAui() == null)
					{
						continue;
					}
					goto IL_1fe0;
					IL_1fcd:
					flag = false;
					num2 = 0;
					if (YwX0VgXTbwtAy8AMIL())
					{
						continue;
					}
					goto IL_1fe0;
				}
				break;
			}
		}
	}

	public static void YC64QejZxx(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (gYj4rDRrrQ == null)
			{
				lock (y0H4DQhsE1)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554453)).Assembly.GetManifestResourceStream("GMgN0gRvPCDlbkfNlg.GCG5pLQIX83OZN1niT"));
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
							uint num9 = num3;
							uint num10 = num3;
							num10 ^= num10 >> 6;
							num10 += 2747050913u;
							num10 ^= num10 >> 7;
							num10 += 96649441;
							num10 ^= num10 << 21;
							num10 += 2442726594u;
							num10 = 607677248 + num10;
							num3 = num9 + (uint)(double)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num11 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num11 & num7) >> num8);
								}
							}
							else
							{
								uint num12 = num3 ^ num4;
								array2[num6] = (byte)(num12 & 0xFFu);
								array2[num6 + 1] = (byte)((num12 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num12 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num12 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num13 = array.Length / 8;
						WpWSp8jcj2DZFKf0eg wpWSp8jcj2DZFKf0eg = new WpWSp8jcj2DZFKf0eg(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = wpWSp8jcj2DZFKf0eg.FZdKZeItnh();
							int value = wpWSp8jcj2DZFKf0eg.FZdKZeItnh();
							dictionary.Add(key, value);
						}
						wpWSp8jcj2DZFKf0eg.H5KKpC0KrM();
					}
					gYj4rDRrrQ = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num14 = gYj4rDRrrQ[metadataToken];
				bool flag = (num14 & 0x40000000) > 0;
				num14 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554453)).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num15 = parameters.Length + 1;
				Type[] array3 = new Type[num15];
				if (methodInfo.DeclaringType!.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType!.MakeByRefType();
				}
				else
				{
					array3[0] = Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(16777238));
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num16 = 0; num16 < num15; num16++)
				{
					switch (num16)
					{
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num16);
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

	internal static void cCk4WOwwKo()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
	internal static string NpG4bhJo8E(int int_0)
	{
		int num = 205;
		byte[] array3 = default(byte[]);
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		int num18 = default(int);
		uint num6 = default(uint);
		int num8 = default(int);
		uint num22 = default(uint);
		uint num16 = default(uint);
		int num7 = default(int);
		int num5 = default(int);
		uint num21 = default(uint);
		uint num10 = default(uint);
		uint num17 = default(uint);
		uint num20 = default(uint);
		int num15 = default(int);
		byte[] array6 = default(byte[]);
		int num9 = default(int);
		int num13 = default(int);
		uint num19 = default(uint);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num14 = default(int);
		byte[] array7 = default(byte[]);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		Stream stream = default(Stream);
		int num12 = default(int);
		CryptoStream object_2 = default(CryptoStream);
		int num11 = default(int);
		string result = default(string);
		int int_ = default(int);
		while (true)
		{
			if (((Array)vU24Etuy5G).Length == 0)
			{
				while (true)
				{
					WpWSp8jcj2DZFKf0eg object_ = new WpWSp8jcj2DZFKf0eg((Stream)kibPEqEVaQVqgMlhZJ(mN74oSlkhV, "snMopYdtcyZoYpnKeZ.fCBULDyORZBxiMycfB"));
					while (true)
					{
						d4pdDf0fJDGLrYQTZH(rjhyfpKvhw41TPx5XF(object_), 0L);
						while (true)
						{
							byte[] array = (byte[])YSrq9uoC5fiW9QMvp6(object_, (int)ro7d6ddjrHW6SxtxGe(rjhyfpKvhw41TPx5XF(object_)));
							int num2 = 346;
							if (!iETnkMlVYP1W6fMlh3())
							{
								goto IL_002d;
							}
							goto IL_1fba;
							IL_1fba:
							while (true)
							{
								switch (num2)
								{
								case 410:
									array3[10] = 154;
									num2 = 245;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 409:
									num3 = 165;
									goto case 44;
								case 44:
									array2[28] = (byte)num3;
									num = 311;
									goto case 311;
								case 311:
									array2[29] = 161;
									goto case 3;
								case 3:
									array2[29] = 25;
									goto case 201;
								case 201:
									num3 = 130;
									num2 = 310;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 408:
									num3 = 130;
									goto case 121;
								case 121:
									array2[18] = (byte)num3;
									goto case 66;
								case 66:
									array2[18] = 163;
									goto case 129;
								case 129:
									num3 = 88;
									goto case 343;
								case 343:
									array2[18] = (byte)num3;
									goto case 262;
								case 262:
									array2[19] = 127;
									num2 = 48;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 131;
								case 131:
									num3 = 150;
									goto case 305;
								case 305:
									array2[19] = (byte)num3;
									num2 = 271;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 407:
									array3[8] = (byte)num4;
									num2 = 264;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 406:
									array2[15] = 218;
									goto case 293;
								case 293:
									num3 = 121;
									num2 = 172;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 405:
									array3[2] = 173;
									goto case 247;
								case 247:
									array3[2] = 31;
									num2 = 96;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 167:
									if (num18 > 0)
									{
										goto case 63;
									}
									goto case 7;
								case 63:
									num6 <<= 8;
									goto case 7;
								case 7:
									num6 |= array[^(1 + num18)];
									goto case 342;
								case 342:
									num18++;
									num = 59;
									goto case 59;
								case 59:
								case 404:
									if (num18 < num8)
									{
										goto case 167;
									}
									num2 = 74;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 261;
								case 261:
								case 363:
									num22 = num16;
									goto case 292;
								case 292:
									num16 = 0u;
									goto case 58;
								case 58:
								{
									uint num23 = num22;
									uint num24 = num22;
									num24 ^= num24 >> 6;
									num24 += 2747050913u;
									num24 ^= num24 >> 7;
									num24 += 96649441;
									num24 ^= num24 << 21;
									num24 += 2442726594u;
									num24 = 607677248 + num24;
									num22 = num23 + (uint)(double)num24;
									goto case 166;
								}
								case 166:
									num16 = num22;
									goto case 71;
								case 71:
									if (num7 == num5 - 1)
									{
										goto case 136;
									}
									goto case 32;
								case 136:
									if (num8 > 0)
									{
										num = 239;
										goto case 239;
									}
									goto case 32;
								case 239:
									num21 = num16 ^ num6;
									num2 = 192;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 32:
									num10 = num16 ^ num6;
									num2 = 395;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 403:
									array3[3] = (byte)num4;
									goto case 332;
								case 332:
									array3[3] = 85;
									goto case 61;
								case 61:
									num4 = 92;
									goto case 23;
								case 23:
									array3[3] = (byte)num4;
									num2 = 131;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 321;
								case 321:
									num4 = 88;
									num2 = 171;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 191;
								case 191:
									array3[3] = (byte)num4;
									num2 = 200;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 402:
									array3[14] = (byte)num4;
									num2 = 194;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 249;
								case 249:
									array3[14] = 69;
									goto case 254;
								case 254:
									array3[15] = 90;
									goto case 173;
								case 173:
									array3[15] = 125;
									goto case 372;
								case 372:
									array3[15] = 150;
									goto case 60;
								case 60:
									num4 = 99;
									num2 = 53;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 401:
									num3 = 100;
									num2 = 147;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 400:
									num3 = 161;
									goto case 93;
								case 93:
									array2[5] = (byte)num3;
									num = 297;
									goto case 297;
								case 297:
									num3 = 108;
									num2 = 156;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 234;
								case 234:
									array2[5] = (byte)num3;
									num = 140;
									goto case 140;
								case 140:
									num3 = 21;
									goto case 331;
								case 331:
									array2[5] = (byte)num3;
									num2 = 43;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 399:
									num17 = 0u;
									num2 = 42;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 398:
									num20 = 255u;
									num2 = 278;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 397:
									array2[18] = (byte)num3;
									num2 = 408;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 396:
									num20 <<= 8;
									goto case 370;
								case 370:
									num15 += 8;
									num = 330;
									goto case 330;
								case 330:
									array6[num9 + num13] = (byte)((num21 & num20) >> num15);
									num2 = 392;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto end_IL_2630;
								case 395:
									array6[num9] = (byte)(num10 & 0xFFu);
									num2 = 366;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 149;
								case 149:
									array2[15] = 136;
									goto case 199;
								case 199:
									array2[15] = 130;
									goto case 406;
								case 394:
									array2[14] = 205;
									goto case 149;
								case 393:
									array2[27] = 101;
									num = 274;
									goto case 274;
								case 274:
									array2[27] = 139;
									num2 = 391;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 392:
									num13++;
									goto case 222;
								case 222:
								case 360:
									if (num13 >= num8)
									{
										num2 = 308;
										if (iETnkMlVYP1W6fMlh3())
										{
											continue;
										}
										goto IL_002d;
									}
									goto case 218;
								case 218:
									if (num13 > 0)
									{
										num = 396;
										goto case 396;
									}
									goto case 330;
								case 391:
									num3 = 62;
									num2 = 22;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 49;
								case 49:
									array2[27] = (byte)num3;
									num2 = 384;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 291;
								case 291:
									array2 = new byte[32];
									num2 = 77;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 160;
								case 160:
									array2[0] = 150;
									num2 = 225;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 283;
								case 283:
									num3 = 121;
									goto case 178;
								case 178:
									array2[0] = (byte)num3;
									goto case 334;
								case 334:
									num3 = 96;
									num2 = 306;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 390:
									num8 = array.Length % 4;
									num2 = 39;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 389:
									num3 = 113;
									goto case 177;
								case 177:
									array2[3] = (byte)num3;
									goto case 48;
								case 48:
									array2[4] = 94;
									goto case 225;
								case 225:
									num3 = 178;
									goto case 208;
								case 208:
									array2[4] = (byte)num3;
									goto case 289;
								case 289:
									num3 = 86;
									goto case 276;
								case 276:
									array2[4] = (byte)num3;
									goto case 337;
								case 337:
									array2[4] = 109;
									goto case 386;
								case 386:
									array2[4] = 31;
									goto case 38;
								case 38:
									array2[5] = 185;
									num2 = 272;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 197;
								case 197:
									num16 += num17;
									num2 = 14;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 123;
								case 123:
									num19 = (uint)num9;
									goto case 368;
								case 368:
									num6 = (uint)((array[num19 + 3] << 24) | (array[num19 + 2] << 16) | (array[num19 + 1] << 8) | array[num19]);
									goto case 261;
								case 388:
									array2[19] = (byte)num3;
									goto case 252;
								case 252:
									num3 = 132;
									goto case 81;
								case 81:
									array2[20] = (byte)num3;
									goto case 164;
								case 164:
									array2[20] = 235;
									goto case 86;
								case 86:
									num3 = 88;
									goto case 365;
								case 365:
									array2[20] = (byte)num3;
									num = 83;
									goto case 83;
								case 83:
									num3 = 139;
									num = 12;
									goto case 12;
								case 12:
									array2[20] = (byte)num3;
									num2 = 179;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 387:
									num3 = 98;
									num2 = 10;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 385:
									array3[11] = 163;
									goto case 67;
								case 67:
									array3[11] = 105;
									num2 = 116;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 384:
									array2[28] = 117;
									goto case 232;
								case 232:
									num3 = 103;
									goto case 69;
								case 69:
									array2[28] = (byte)num3;
									goto case 143;
								case 143:
									num3 = 166;
									goto case 169;
								case 169:
									array2[28] = (byte)num3;
									num2 = 409;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 383:
									num3 = 165;
									goto case 84;
								case 84:
									array2[22] = (byte)num3;
									goto case 161;
								case 161:
									num3 = 193;
									goto case 132;
								case 132:
									array2[23] = (byte)num3;
									goto case 401;
								case 382:
									array2[6] = 145;
									goto case 263;
								case 263:
									array2[6] = 104;
									goto case 307;
								case 307:
									array2[6] = 207;
									goto case 156;
								case 156:
									array2[7] = 100;
									num = 176;
									goto case 176;
								case 176:
									num3 = 146;
									num2 = 82;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 381:
									array2[1] = 61;
									goto case 328;
								case 328:
									num3 = 128;
									num2 = 34;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 18;
								case 18:
									array3[2] = 114;
									num2 = 405;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 380:
									array3[5] = 37;
									num2 = 273;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 379:
									array3[8] = (byte)num4;
									goto case 64;
								case 64:
									array3[8] = 144;
									num2 = 114;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 378:
									array3[0] = 56;
									num2 = 353;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 73;
								case 73:
									num16 = 0u;
									goto case 399;
								case 377:
									num3 = 77;
									num2 = 3;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 5;
								case 5:
									array2[17] = (byte)num3;
									num2 = 29;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 85;
								case 85:
									num3 = 108;
									goto case 153;
								case 153:
									array2[18] = (byte)num3;
									goto case 316;
								case 316:
									num3 = 116;
									num2 = 184;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 397;
								case 376:
									array4[1] = array5[0];
									num2 = 189;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 375:
									array2[16] = (byte)num3;
									goto case 371;
								case 371:
									num3 = 102;
									num2 = 290;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 374:
									array3[1] = 175;
									num2 = 18;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 373:
									array2[31] = 221;
									num2 = 231;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 129;
								case 369:
									array2[26] = (byte)num3;
									num2 = 367;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 367:
									array2[26] = 106;
									goto case 339;
								case 339:
									num3 = 152;
									goto case 148;
								case 148:
									array2[26] = (byte)num3;
									goto case 393;
								case 366:
									array6[num9 + 1] = (byte)((num10 & 0xFF00) >> 8);
									num2 = 100;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 364:
									array2[21] = 54;
									goto case 194;
								case 194:
									array2[21] = 242;
									num = 359;
									goto case 359;
								case 359:
									num3 = 136;
									num2 = 256;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 144;
								case 144:
									array2[2] = 45;
									num2 = 348;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 362:
									num4 = 56;
									goto case 309;
								case 309:
									array3[5] = (byte)num4;
									num2 = 25;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 380;
								case 361:
									array3[4] = 94;
									num2 = 141;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 358:
									array2[24] = 111;
									goto case 77;
								case 77:
									num3 = 142;
									goto case 241;
								case 241:
									array2[24] = (byte)num3;
									goto case 211;
								case 211:
									num3 = 178;
									goto case 124;
								case 124:
									array2[24] = (byte)num3;
									num = 99;
									goto case 99;
								case 99:
									array2[24] = 57;
									goto case 209;
								case 209:
									num3 = 191;
									goto case 352;
								case 352:
									array2[24] = (byte)num3;
									num2 = 49;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 237;
								case 237:
									array2[25] = 119;
									goto case 227;
								case 227:
									array2[25] = 108;
									goto case 46;
								case 46:
									num3 = 87;
									goto case 117;
								case 117:
									array2[25] = (byte)num3;
									goto case 341;
								case 341:
									num3 = 113;
									goto case 369;
								case 357:
									num3 = 8;
									num2 = 239;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 299;
								case 299:
									array2[1] = (byte)num3;
									num = 324;
									goto case 324;
								case 324:
									array2[2] = 178;
									num2 = 387;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 356:
									num3 = 147;
									num = 285;
									goto case 285;
								case 285:
									array2[17] = (byte)num3;
									goto case 377;
								case 355:
									num9 = num7 * 4;
									goto case 19;
								case 19:
									num19 = (uint)(num14 * 4);
									num = 154;
									goto case 154;
								case 154:
									num17 = (uint)((array7[num19 + 3] << 24) | (array7[num19 + 2] << 16) | (array7[num19 + 1] << 8) | array7[num19]);
									goto case 398;
								case 354:
									array2[2] = 223;
									goto case 244;
								case 244:
									num3 = 192;
									goto case 279;
								case 279:
									array2[3] = (byte)num3;
									num2 = 193;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 353:
									num4 = 32;
									num2 = 139;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 351:
									T6jruZDGp3YMuyFnHb(object_3, CipherMode.CBC);
									goto case 89;
								case 89:
									transform = (ICryptoTransform)G9NA2KeaWpIGInAGQ3(object_3, array7, array4);
									goto case 113;
								case 113:
									stream = (Stream)TgNNwFLmXfx2jeNm5p();
									num2 = 54;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 3;
								case 350:
									num12++;
									num2 = 280;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 349:
									array2[29] = 137;
									num2 = 155;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 170;
								case 170:
									num3 = 135;
									goto case 41;
								case 41:
									array2[30] = (byte)num3;
									goto case 21;
								case 21:
									num3 = 187;
									goto case 11;
								case 11:
									array2[30] = (byte)num3;
									num = 246;
									goto case 246;
								case 246:
									array2[30] = 107;
									num2 = 210;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 74;
								case 74:
									array3[7] = (byte)num4;
									goto case 30;
								case 30:
									array3[7] = 110;
									goto case 195;
								case 195:
									num4 = 102;
									goto case 320;
								case 320:
									array3[7] = (byte)num4;
									goto case 37;
								case 37:
									num4 = 84;
									goto case 111;
								case 111:
									array3[7] = (byte)num4;
									num2 = 62;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 348:
									array2[2] = 88;
									num2 = 354;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 351;
								case 347:
									array2[31] = 156;
									goto case 373;
								case 346:
									o3vZmISIUtd5HGU0fP(object_);
									goto case 291;
								case 345:
									array2[11] = (byte)num3;
									num2 = 248;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 280:
								case 344:
									if (num12 >= array4.Length)
									{
										goto case 168;
									}
									goto case 326;
								case 168:
									if (int_0 != -1)
									{
										goto case 390;
									}
									num = 103;
									goto case 103;
								case 103:
									object_3 = (SymmetricAlgorithm)LVkojjNGaHxUCcC0y8();
									num = 351;
									goto case 351;
								case 326:
									array7[num12] = (byte)(array7[num12] ^ array4[num12]);
									num2 = 350;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 340:
									num4 = 145;
									num2 = 74;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 13;
								case 13:
									array2[31] = (byte)num3;
									num = 347;
									goto case 347;
								case 338:
									num4 = 205;
									num = 219;
									goto case 219;
								case 219:
									array3[12] = (byte)num4;
									num2 = 110;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 336:
									array3 = new byte[16];
									goto case 107;
								case 107:
									array3[0] = 113;
									goto case 118;
								case 118:
									num4 = 144;
									goto case 137;
								case 137:
									array3[0] = (byte)num4;
									goto case 378;
								case 335:
									num3 = 164;
									goto case 127;
								case 127:
									array2[9] = (byte)num3;
									goto case 267;
								case 267:
									num3 = 156;
									num2 = 47;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 65;
								case 65:
									array2[9] = (byte)num3;
									num2 = 158;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 133;
								case 133:
									array2[5] = (byte)num3;
									num2 = 137;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 243;
								case 243:
									array2[5] = 125;
									goto case 400;
								case 333:
									num5++;
									goto case 157;
								case 157:
									num19 = 0u;
									num2 = 56;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 329:
									num3 = 51;
									goto case 2;
								case 2:
									array2[11] = (byte)num3;
									goto case 242;
								case 242:
									num3 = 161;
									goto case 98;
								case 98:
									array2[12] = (byte)num3;
									goto case 224;
								case 224:
									num3 = 142;
									num = 15;
									goto case 15;
								case 15:
									array2[12] = (byte)num3;
									goto case 151;
								case 151:
									array2[12] = 104;
									goto case 31;
								case 31:
									num3 = 92;
									num2 = 214;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 327:
									array3[14] = 57;
									num2 = 137;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 183;
								case 183:
									num4 = 106;
									goto case 402;
								case 325:
									array3[13] = 92;
									num2 = 182;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 82;
								case 82:
									array2[7] = (byte)num3;
									goto case 40;
								case 40:
									array2[7] = 222;
									goto case 105;
								case 105:
									array2[8] = 162;
									num2 = 251;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 323:
									num4 = 119;
									num2 = 49;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 175;
								case 175:
									array3[4] = (byte)num4;
									goto case 361;
								case 322:
									array3[15] = 164;
									goto case 28;
								case 28:
									array3[15] = 141;
									num2 = 68;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 65;
								case 319:
									array2[23] = 41;
									goto case 230;
								case 230:
									num3 = 116;
									goto case 275;
								case 275:
									array2[24] = (byte)num3;
									goto case 358;
								case 318:
									num3 = 133;
									num2 = 125;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 317:
									array3[9] = (byte)num4;
									num2 = 120;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 315:
									array2[16] = (byte)num3;
									goto case 213;
								case 213:
									num3 = 168;
									num = 163;
									goto case 163;
								case 163:
									array2[16] = (byte)num3;
									goto case 128;
								case 128:
									array2[16] = 164;
									num2 = 4;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 138;
								case 138:
									num3 = 137;
									goto case 375;
								case 314:
									num3 = 144;
									goto case 109;
								case 109:
									array2[15] = (byte)num3;
									goto case 298;
								case 298:
									array2[15] = 32;
									num2 = 144;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 155;
								case 155:
									num3 = 128;
									num2 = 4;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 315;
								case 313:
									array3[1] = 99;
									num2 = 108;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 150;
								case 150:
									array3[1] = 152;
									goto case 221;
								case 221:
									array3[1] = 128;
									goto case 374;
								case 312:
									vU24Etuy5G = array6;
									num2 = 184;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 310:
									array2[29] = (byte)num3;
									num2 = 9;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 301:
								case 308:
									num7++;
									num2 = 203;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 306:
									array2[0] = (byte)num3;
									num2 = 16;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 304:
									num6 = 0u;
									goto case 90;
								case 90:
									num16 += num17;
									goto case 233;
								case 233:
									num18 = 0;
									goto case 59;
								case 303:
									num3 = 91;
									num2 = 268;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 302:
									array2[13] = (byte)num3;
									num2 = 296;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 128;
								case 300:
									array2[8] = (byte)num3;
									num2 = 284;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 296:
									num3 = 110;
									goto case 87;
								case 87:
									array2[13] = (byte)num3;
									num2 = 185;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 295:
									array2[30] = (byte)num3;
									num2 = 25;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 270;
								case 270:
									num3 = 106;
									goto case 259;
								case 259:
									array2[31] = (byte)num3;
									num2 = 229;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 294:
									array3[4] = 145;
									goto case 135;
								case 135:
									array3[5] = 86;
									goto case 216;
								case 216:
									num4 = 110;
									num2 = 253;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 290:
									array2[17] = (byte)num3;
									num2 = 356;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 174;
								case 174:
									array2[10] = (byte)num3;
									goto case 202;
								case 202:
									num3 = 85;
									num2 = 26;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 288:
									array2[10] = 148;
									goto case 223;
								case 223:
									num3 = 133;
									goto case 174;
								case 287:
									array2[13] = 118;
									num = 286;
									goto case 286;
								case 286:
									array2[13] = 24;
									num2 = 72;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 284:
									array2[8] = 121;
									goto case 75;
								case 75:
									array2[8] = 127;
									num2 = 308;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 335;
								case 282:
									array2[11] = 119;
									goto case 52;
								case 52:
									array2[11] = 173;
									num = 329;
									goto case 329;
								case 281:
									num4 = 161;
									num2 = 51;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto end_IL_265c;
								case 278:
									num15 = 0;
									num = 265;
									goto case 265;
								case 265:
									if (num7 == num5 - 1)
									{
										num2 = 79;
										if (UiwVHw9TivhOxjtS2q() == null)
										{
											continue;
										}
										goto IL_002d;
									}
									goto case 197;
								case 277:
									array3[12] = 120;
									num2 = 181;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 12;
								case 273:
									num4 = 132;
									num2 = 102;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 272:
									num3 = 56;
									goto case 133;
								case 271:
									num3 = 54;
									goto case 14;
								case 14:
									array2[19] = (byte)num3;
									num2 = 228;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 236;
								case 236:
									num3 = 228;
									num2 = 101;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 269:
									num3 = 44;
									goto case 36;
								case 36:
									array2[0] = (byte)num3;
									goto case 381;
								case 268:
									array2[22] = (byte)num3;
									num = 383;
									goto case 383;
								case 266:
									num4 = 216;
									num2 = 16;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 24;
								case 24:
									array3[10] = (byte)num4;
									num2 = 385;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 264:
									array3[9] = 100;
									goto case 142;
								case 142:
									num4 = 102;
									num2 = 317;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 260:
									array3[10] = 129;
									goto case 266;
								case 258:
									array4[9] = array5[4];
									num2 = 57;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 257:
									array2[21] = 1;
									num2 = 364;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 256:
									array2[22] = (byte)num3;
									goto case 303;
								case 255:
									array3[9] = (byte)num4;
									num2 = 198;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 253:
									array3[5] = (byte)num4;
									goto case 362;
								case 251:
									num3 = 102;
									num2 = 300;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 248:
									array2[11] = 138;
									goto case 318;
								case 245:
									num4 = 127;
									num2 = 217;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 240:
									num3 = 150;
									num2 = 345;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 238:
									num3 = 100;
									goto case 35;
								case 35:
									array2[6] = (byte)num3;
									num2 = 70;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 235:
									num3 = 241;
									goto case 47;
								case 47:
									array2[9] = (byte)num3;
									num2 = 288;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 75;
								case 231:
									array7 = array2;
									num2 = 336;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 229:
									array2[31] = 113;
									num2 = 152;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 228:
									PQ5Yq94YDsxA9GtmYQ(object_2);
									num2 = 92;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 220:
									LUwXjWk1Z9X2wxPjiF(stream);
									goto case 76;
								case 76:
									LUwXjWk1Z9X2wxPjiF(object_2);
									num2 = 119;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 217:
									array3[10] = (byte)num4;
									goto case 260;
								case 215:
									array3[13] = 152;
									goto case 159;
								case 159:
									num4 = 250;
									num = 190;
									goto case 190;
								case 190:
									array3[13] = (byte)num4;
									num = 187;
									goto case 187;
								case 187:
									num4 = 84;
									goto case 165;
								case 165:
									array3[14] = (byte)num4;
									goto case 27;
								case 27:
									num4 = 154;
									goto case 134;
								case 134:
									array3[14] = (byte)num4;
									goto case 327;
								case 214:
									array2[12] = (byte)num3;
									num2 = 287;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 212:
									array4[15] = array5[7];
									num2 = 97;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 210:
									num3 = 81;
									goto case 295;
								case 207:
									array3[11] = (byte)num4;
									goto case 206;
								case 206:
									num4 = 115;
									goto case 95;
								case 95:
									array3[11] = (byte)num4;
									num2 = 281;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 55:
								case 203:
									if (num7 >= num5)
									{
										num2 = 312;
										if (UiwVHw9TivhOxjtS2q() == null)
										{
											continue;
										}
										goto IL_002d;
									}
									goto case 17;
								case 17:
									num14 = num7 % num11;
									goto case 355;
								case 200:
									array3[3] = 227;
									goto case 188;
								case 188:
									num4 = 155;
									num2 = 91;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 198:
									num4 = 138;
									num2 = 29;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 196:
									array5 = (byte[])imxFZNJKmB7CDr3gx4(UsWNaPhLWWo2Nlh9IX(mN74oSlkhV));
									num2 = 171;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 193:
									array2[3] = 148;
									goto case 389;
								case 192:
									num13 = 0;
									goto case 222;
								case 189:
									array4[3] = array5[1];
									goto case 20;
								case 20:
									array4[5] = array5[2];
									goto case 45;
								case 45:
									array4[7] = array5[3];
									goto case 258;
								case 186:
									if (array5.Length > 0)
									{
										num2 = 376;
										if (UiwVHw9TivhOxjtS2q() == null)
										{
											continue;
										}
										goto IL_002d;
									}
									goto case 97;
								case 97:
									num12 = 0;
									goto case 280;
								case 185:
									num3 = 179;
									num2 = 25;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 182:
									array3[13] = 132;
									num2 = 215;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 181:
									array3[12] = 206;
									goto case 325;
								case 180:
									array3[12] = (byte)num4;
									num2 = 277;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto default;
								default:
									num3 = 111;
									num2 = 6;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 179:
									array2[20] = 46;
									goto case 257;
								case 172:
									array2[15] = (byte)num3;
									goto case 314;
								case 171:
									if (array5 != null)
									{
										goto case 186;
									}
									goto case 97;
								case 162:
									num11 = array7.Length / 4;
									goto case 73;
								case 158:
									num3 = 121;
									goto case 126;
								case 126:
									array2[9] = (byte)num3;
									goto case 235;
								case 152:
									num3 = 90;
									num2 = 13;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 147:
									array2[23] = (byte)num3;
									num2 = 319;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 140;
								case 145:
									array6[num9 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
									goto case 301;
								case 141:
									array3[4] = 166;
									num2 = 294;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 139:
									array3[1] = (byte)num4;
									num2 = 313;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 303;
								case 130:
									array2[29] = (byte)num3;
									num2 = 172;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 349;
								case 125:
									array2[11] = (byte)num3;
									goto case 282;
								case 122:
									if (num8 > 0)
									{
										goto case 333;
									}
									goto case 157;
								case 120:
									num4 = 166;
									goto case 255;
								case 119:
									array = (byte[])vU24Etuy5G;
									goto case 390;
								case 116:
									num4 = 109;
									goto case 207;
								case 115:
									array4[13] = array5[6];
									goto case 212;
								case 114:
									array3[8] = 48;
									goto case 106;
								case 106:
									num4 = 19;
									goto case 407;
								case 112:
									array2[6] = (byte)num3;
									goto case 382;
								case 110:
									num4 = 90;
									goto case 180;
								case 108:
									array6 = new byte[array.Length];
									goto case 162;
								case 104:
									t1t8fZFpqUeod5Yohb(object_2, array, 0, array.Length);
									goto case 228;
								case 102:
									array3[6] = (byte)num4;
									num2 = 8;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 101:
									array2[19] = (byte)num3;
									num2 = 1;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto case 1;
								case 1:
									num3 = 75;
									goto case 80;
								case 80:
									array2[19] = (byte)num3;
									goto case 33;
								case 33:
									num3 = 108;
									num2 = 388;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 362;
								case 100:
									array6[num9 + 2] = (byte)((num10 & 0xFF0000) >> 16);
									num2 = 132;
									if (!iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 145;
								case 96:
									num4 = 164;
									goto case 403;
								case 94:
									X9XC5qgACL9ngRH1xE(array4);
									goto case 196;
								case 92:
									vU24Etuy5G = HMq7xGvl27lSuZa5va(stream);
									goto case 220;
								case 91:
									array3[4] = (byte)num4;
									num = 22;
									goto case 22;
								case 22:
									array3[4] = 132;
									goto case 323;
								case 88:
									num4 = 24;
									num2 = 78;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 79:
									if (num8 <= 0)
									{
										goto case 197;
									}
									goto case 304;
								case 78:
									array3[6] = (byte)num4;
									goto case 340;
								case 72:
									num3 = 130;
									goto case 302;
								case 70:
									num3 = 170;
									goto case 112;
								case 68:
									array4 = array3;
									num2 = 94;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 62:
									num4 = 142;
									num2 = 379;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 57:
									array4[11] = array5[5];
									goto case 115;
								case 56:
									num7 = 0;
									num2 = 55;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 54:
									object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
									goto case 104;
								case 53:
									array3[15] = (byte)num4;
									num2 = 322;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 289;
								case 51:
									array3[12] = (byte)num4;
									goto case 338;
								case 43:
									array2[6] = 102;
									goto case 238;
								case 42:
									num6 = 0u;
									num2 = 93;
									if (UiwVHw9TivhOxjtS2q() != null)
									{
										continue;
									}
									goto case 122;
								case 39:
									num5 = array.Length / 4;
									goto case 108;
								case 34:
									array2[1] = (byte)num3;
									goto case 357;
								case 29:
									array3[10] = (byte)num4;
									goto case 410;
								case 26:
									array2[10] = (byte)num3;
									goto case 240;
								case 25:
									array2[14] = (byte)num3;
									num2 = 0;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto IL_002d;
								case 16:
									array2[0] = 132;
									num2 = 269;
									if (UiwVHw9TivhOxjtS2q() == null)
									{
										continue;
									}
									goto IL_002d;
								case 10:
									array2[2] = (byte)num3;
									num2 = 144;
									if (iETnkMlVYP1W6fMlh3())
									{
										continue;
									}
									goto case 84;
								case 9:
									num3 = 127;
									goto case 130;
								case 8:
									array3[6] = 127;
									goto case 88;
								case 6:
									array2[14] = (byte)num3;
									goto case 394;
								case 226:
									break;
								case 250:
									goto end_IL_2630;
								case 50:
									goto end_IL_265c;
								case 205:
									goto end_IL_2674;
								case 184:
								case 204:
									goto IL_2695;
								case 4:
									goto IL_26a2;
								case 146:
									goto end_IL_268c;
								}
								break;
							}
							continue;
							IL_002d:
							num2 = num;
							goto IL_1fba;
							continue;
							end_IL_2630:
							break;
						}
						continue;
						end_IL_265c:
						break;
					}
					continue;
					end_IL_2674:
					break;
				}
				continue;
			}
			goto IL_2695;
			IL_26a2:
			try
			{
				kmHUkHstoSNRNpZXyX();
				int num25 = 0;
				if (!iETnkMlVYP1W6fMlh3())
				{
					goto IL_26b5;
				}
				goto IL_26d7;
				IL_26d7:
				switch (num25)
				{
				case 1:
					return result;
				}
				goto IL_26b5;
				IL_26b5:
				result = (string)XwpIHyZT64JnRvQfXs(jRoFrbaBvheMWDwxJk(), vU24Etuy5G, int_0 + 4, int_);
				num25 = 1;
				if (!iETnkMlVYP1W6fMlh3())
				{
					return result;
				}
				goto IL_26d7;
			}
			catch
			{
				if (UiwVHw9TivhOxjtS2q() != null)
				{
					switch (0)
					{
					}
				}
			}
			break;
			IL_2695:
			int_ = UqmiP1w6an3mNlvJSH(vU24Etuy5G, int_0);
			goto IL_26a2;
			continue;
			end_IL_268c:
			break;
		}
		return "";
	}

	[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
	internal static string hRV4FUQdnY(object object_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)object_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint rob4kGNJXO(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_3, ref uint uint_1)
	{
		IntPtr ptr = intptr_2;
		if (zL34aF4R7Q)
		{
			ptr = intptr_1;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = ((Hashtable)JYvKLCsA8k)[(object)num];
		if (obj != null)
		{
			bZYeaHi8qu2JN9K2Ig bZYeaHi8qu2JN9K2Ig = (bZYeaHi8qu2JN9K2Ig)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(bZYeaHi8qu2JN9K2Ig.I6SKfYay1R.Length);
			Marshal.Copy(bZYeaHi8qu2JN9K2Ig.I6SKfYay1R, 0, intPtr, bZYeaHi8qu2JN9K2Ig.I6SKfYay1R.Length);
			if (bZYeaHi8qu2JN9K2Ig.gmsKVnQ4m9)
			{
				intptr_3 = intPtr;
				uint_1 = (uint)bZYeaHi8qu2JN9K2Ig.I6SKfYay1R.Length;
				bGY4RO1lga(intptr_3, bZYeaHi8qu2JN9K2Ig.I6SKfYay1R.Length, 64, ref rd3Kl3CSNZ);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, bZYeaHi8qu2JN9K2Ig.I6SKfYay1R.Length);
			uint result = 0u;
			if (uint_0 == 216669565 && !NR5KYwdw7d)
			{
				NR5KYwdw7d = true;
			}
			else
			{
				result = uMu4z0CoEH(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
			}
			return result;
		}
		return uMu4z0CoEH(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
	}

	private static int g9640XsIiw()
	{
		return 5;
	}

	private static void opY4iUsGtN()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate YMF4jY8QdC(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(16777352)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(16777258)),
			Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(16777311))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal unsafe static void nIq4V2sach()
	{
		//The blocks IL_2742, IL_2782, IL_2788, IL_2794 are reachable both inside and outside the pinned region starting at IL_2740. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0009, IL_0013, IL_0025, IL_0b0f, IL_0b22, IL_0b40, IL_0b49, IL_0b57, IL_0b72, IL_0b80, IL_0b86, IL_0ba6, IL_0bac, IL_0bba, IL_0bc0, IL_0bce, IL_0be3, IL_0bef, IL_0c04, IL_0c25, IL_0c2d, IL_0c3d, IL_0c42, IL_0c57, IL_0c5b, IL_0c62, IL_0c8d, IL_0ca1, IL_0d29, IL_0d31, IL_0d36, IL_0d4b, IL_0d52, IL_0d60, IL_0d72, IL_0d85, IL_0d98, IL_0da7, IL_0dad, IL_0db1, IL_0dce, IL_0dd5, IL_0df0, IL_0fb3, IL_0fc9, IL_0ff3, IL_0ffc, IL_100a, IL_1029, IL_1047, IL_1051, IL_1073, IL_1080, IL_1088, IL_10a1, IL_10bf, IL_10c7, IL_10f5, IL_1105, IL_1129, IL_113e, IL_115b, IL_1171, IL_1177, IL_1185, IL_118a, IL_119f, IL_11c5, IL_11d1, IL_11dd, IL_11f5, IL_1204, IL_120d, IL_1224, IL_123d, IL_1258, IL_1266, IL_1275, IL_127b, IL_1289, IL_128f, IL_12b2, IL_12c7, IL_12eb, IL_12fa, IL_1315, IL_1321, IL_132a, IL_132d, IL_134b, IL_1363, IL_1372, IL_1378, IL_138f, IL_1395, IL_13b8, IL_13d7, IL_13dd, IL_13eb, IL_13f7, IL_1403, IL_140c, IL_141a, IL_142f, IL_1441, IL_1458, IL_146e, IL_147d, IL_1486, IL_1494, IL_14b8, IL_14cd, IL_14d9, IL_14e8, IL_14fe, IL_150c, IL_1518, IL_153c, IL_1550, IL_156f, IL_168a, IL_16a0, IL_16ae, IL_16bd, IL_16d8, IL_16f6, IL_1701, IL_1711, IL_171a, IL_171f, IL_1734, IL_175d, IL_1769, IL_1781, IL_179d, IL_17ab, IL_17c9, IL_17f5, IL_1810, IL_181c, IL_182b, IL_184c, IL_1858, IL_1870, IL_188b, IL_1897, IL_18a3, IL_18ac, IL_18cf, IL_18d7, IL_18f3, IL_1916, IL_1931, IL_193d, IL_1943, IL_1961, IL_196a, IL_1978, IL_1990, IL_19ab, IL_19ae, IL_19bb, IL_19c9, IL_19e7, IL_1a03, IL_1a0c, IL_1a0f, IL_1a1b, IL_1a27, IL_1a30, IL_1a41, IL_1a56, IL_1a74, IL_1a8c, IL_1a95, IL_1aa0, IL_1aa8, IL_1ab1, IL_1abd, IL_1ad6, IL_1adf, IL_1b05, IL_1b26, IL_1b34, IL_1b4f, IL_1b58, IL_1b71, IL_1b92, IL_1ba0, IL_1bac, IL_1bd0, IL_1bdf, IL_1be5, IL_1c03, IL_1c1f, IL_1c2e, IL_1c40, IL_1c57, IL_1c75, IL_1c87, IL_1c95, IL_1ca1, IL_1cbf, IL_1ccb, IL_1ce0, IL_1ce6, IL_1cf4, IL_1d00, IL_1d24, IL_1d32, IL_1e1d, IL_1e32, IL_1e45, IL_1e4c, IL_1e68, IL_1e70, IL_1e7e, IL_1e83, IL_1ea6, IL_1ebd, IL_1ed8, IL_1ef3, IL_1f13, IL_1f31, IL_1f37, IL_1f3d, IL_1f4d, IL_1f5b, IL_1f61, IL_1f9d, IL_1fb8, IL_1fbe, IL_1fcc, IL_1fea, IL_2003, IL_2027, IL_202e, IL_21da, IL_21df, IL_21e5, IL_21ed, IL_21fc, IL_221f, IL_2236, IL_2242, IL_225f, IL_2268, IL_226e, IL_2289, IL_228f, IL_22ad, IL_22b4, IL_22c5, IL_22d2, IL_22e3, IL_22f2, IL_22fe, IL_230d, IL_2313, IL_2321, IL_2330, IL_2349, IL_2357, IL_2370, IL_237c, IL_238b, IL_23ac, IL_23c0, IL_23e7, IL_23f0, IL_23fd, IL_2400, IL_2409, IL_2414, IL_2434, IL_2440, IL_2457, IL_2473, IL_248f, IL_249f, IL_24bd, IL_24d6, IL_24f5, IL_280a, IL_2814, IL_2828, IL_2847, IL_2869, IL_2875, IL_2893, IL_28a0, IL_28a8, IL_28c9, IL_28cf, IL_28e2, IL_28f3, IL_290a, IL_2922, IL_2956, IL_2974, IL_297a, IL_2988, IL_2993, IL_29b3, IL_29b9, IL_29d4, IL_29dd, IL_2a00, IL_2a24, IL_2a32, IL_2a3e, IL_2a4d, IL_2a6c, IL_2a7f, IL_2a8e, IL_2aa5, IL_2aad, IL_2abc, IL_2ad6, IL_2aea, IL_2afc, IL_2b13, IL_2b1c, IL_2b2f, IL_2b37, IL_2b5a, IL_2b75, IL_2b81, IL_2ba5, IL_2bc8, IL_2bce, IL_2bf1, IL_2bf9, IL_2c07, IL_2c19, IL_2c2b, IL_2c5c, IL_2c6b, IL_2c87, IL_2ca0, IL_2cc3, IL_2cde, IL_2cea, IL_2d06, IL_2d0d, IL_2d1a, IL_2d43, IL_2d57, IL_2d5d, IL_2d80, IL_2d97, IL_2dab, IL_2dc7, IL_2dcd, IL_2de9, IL_2df7, IL_2e11, IL_2e37, IL_2e54, IL_2e63, IL_2e6f, IL_2e89, IL_2e97, IL_2eba, IL_2ec8, IL_2ee3, IL_2f01, IL_2f14, IL_2f20, IL_2f26, IL_2f34, IL_2f4a, IL_2f60, IL_2f6c, IL_2f8a, IL_2faa, IL_2fce, IL_2ff1, IL_2ffa, IL_3008, IL_3013, IL_3019, IL_3027, IL_3042, IL_3054, IL_305d, IL_3067, IL_3078, IL_3090, IL_30a8, IL_30b6, IL_30c7, IL_30d5, IL_30f6, IL_3104, IL_3128, IL_3130, IL_314a, IL_316d, IL_3178, IL_3198, IL_31bb, IL_31db, IL_31e9, IL_3212, IL_321d, IL_322e, IL_3245, IL_324e, IL_325c, IL_3262, IL_3275, IL_329c, IL_32a3, IL_32b8, IL_32c4, IL_32d3, IL_32e1, IL_32f9, IL_3314, IL_3327, IL_3333, IL_334b, IL_3365, IL_3386, IL_339d, IL_33ae, IL_33b2, IL_33bd, IL_33c4, IL_33e1, IL_33f9, IL_3417, IL_3425, IL_3431, IL_344c, IL_3462, IL_3485, IL_34a4, IL_34b0, IL_34c1, IL_34e1, IL_34e9, IL_350c, IL_351f, IL_3528, IL_3536, IL_3545, IL_3559, IL_357a, IL_358b, IL_3596, IL_35a1, IL_35b1, IL_35bc, IL_35d9, IL_35fc, IL_3608, IL_3611, IL_3634, IL_3642, IL_3651, IL_3674, IL_367f, IL_3698, IL_36a3, IL_36b3, IL_36b7, IL_36ce, IL_36d4, IL_36e2, IL_36e8, IL_370b, IL_3729, IL_3742, IL_3765, IL_3772, IL_3790, IL_37a4, IL_37bf, IL_37c5, IL_37d3, IL_37ee, IL_380f, IL_382a, IL_3845, IL_386c, IL_3889, IL_38aa, IL_38b2, IL_38bd, IL_38da, IL_38f5, IL_3903, IL_3912, IL_3921, IL_3940, IL_394e, IL_3959, IL_3968, IL_398c, IL_399d, IL_39b0, IL_39ce, IL_39d4, IL_39ef, IL_3a03, IL_3a06, IL_3a11, IL_3a26, IL_3a31, IL_3a3a, IL_3a4d, IL_3a5e, IL_3a6d, IL_3a89, IL_3a9c, IL_3aa8, IL_3ab9, IL_3ac4, IL_3ad4, IL_3adc, IL_3aea, IL_3b10, IL_3b1f, IL_3b30, IL_3b47, IL_3b56, IL_3b79, IL_3b9d, IL_3bba, IL_3bde, IL_3bf8, IL_3c08, IL_3c24, IL_3c48, IL_3c55, IL_3c60, IL_3c71, IL_3c77, IL_3c7f, IL_3c83, IL_3c90, IL_3c9b, IL_3cb1, IL_3cbf, IL_3ccd, IL_3cdb, IL_3cf9, IL_3d0c, IL_3d27, IL_3d3a, IL_3d48, IL_3d63, IL_3d6c, IL_3d7a, IL_3d80, IL_3d93, IL_3da1, IL_3da7, IL_3dba, IL_3dc5, IL_3dd8, IL_3df2, IL_3e00, IL_3e14, IL_3e1f, IL_3e3c, IL_3e58, IL_3e64, IL_3e72, IL_3e85, IL_3e90, IL_3e93, IL_3e9b, IL_3eae, IL_3ec9, IL_3ee9, IL_3efd, IL_3f10, IL_3f1c, IL_3f3d, IL_3f60, IL_3f80, IL_3f89, IL_3f98, IL_3fa0, IL_3fa6, IL_3fca, IL_3fd8, IL_3fe8, IL_3ff9, IL_4014, IL_4034, IL_4044, IL_4059, IL_4077, IL_4092, IL_4098, IL_40bb, IL_40d9, IL_40f4, IL_4102, IL_4110, IL_4131, IL_4151, IL_4161, IL_416f, IL_4188, IL_41a9, IL_41cd, IL_4208, IL_4214, IL_422f, IL_4244, IL_424a, IL_425d, IL_4270, IL_4276, IL_428c, IL_42a4, IL_42bf, IL_42da, IL_42e9, IL_42fa, IL_4311, IL_4321, IL_4334, IL_4357, IL_437a, IL_43a5, IL_43ae, IL_43ba, IL_43c8, IL_43e3, IL_43f4, IL_4409, IL_442c, IL_443d, IL_4444, IL_4452, IL_445d, IL_4480, IL_449a, IL_44ad, IL_44bb, IL_44de, IL_44ec, IL_44f4, IL_4517, IL_4532, IL_4540, IL_455d, IL_4578, IL_4586, IL_45a2, IL_45b7, IL_45d8, IL_45f3, IL_4604, IL_4617, IL_4622, IL_4631, IL_4639, IL_464e, IL_4659, IL_467d, IL_468d, IL_46ad, IL_46cb, IL_46d6, IL_46f1, IL_4702, IL_471d, IL_4731, IL_474c, IL_4767, IL_4772, IL_477d, IL_4790, IL_479c, IL_47ad, IL_47bd, IL_47de, IL_4802, IL_4808, IL_480e, IL_481c, IL_4832 are reachable both inside and outside the pinned region starting at IL_3fc3. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 566;
		byte[] array13 = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array = default(byte[]);
		int num3 = default(int);
		int num5 = default(int);
		int num14 = default(int);
		int num12 = default(int);
		int num15 = default(int);
		int num32 = default(int);
		uint num18 = default(uint);
		int num33 = default(int);
		uint num29 = default(uint);
		uint num19 = default(uint);
		uint num7 = default(uint);
		byte[] array17 = default(byte[]);
		uint num79 = default(uint);
		byte[] array16 = default(byte[]);
		byte[] array7 = default(byte[]);
		int num24 = default(int);
		int num27 = default(int);
		int num26 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		ProcessModule object_13 = default(ProcessModule);
		Version object_14 = default(Version);
		Version object_15 = default(Version);
		Version object_16 = default(Version);
		int num74 = default(int);
		int num76 = default(int);
		WpWSp8jcj2DZFKf0eg object_ = default(WpWSp8jcj2DZFKf0eg);
		IntPtr intPtr3 = default(IntPtr);
		int int_2 = default(int);
		int num58 = default(int);
		int num36 = default(int);
		int num37 = default(int);
		int num13 = default(int);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		int num6 = default(int);
		byte[] array5 = default(byte[]);
		bool gmsKVnQ4m = default(bool);
		int num22 = default(int);
		int int_3 = default(int);
		int num16 = default(int);
		Process object_6 = default(Process);
		IntPtr intPtr2 = default(IntPtr);
		int num69 = default(int);
		int num70 = default(int);
		int num72 = default(int);
		int num17 = default(int);
		uint num30 = default(uint);
		uint num20 = default(uint);
		int num35 = default(int);
		ref byte reference3 = default(ref byte);
		int num21 = default(int);
		long num39 = default(long);
		WIZ8WE02qlCAiCa8dc object_10 = default(WIZ8WE02qlCAiCa8dc);
		IntPtr procAddress = default(IntPtr);
		IntPtr intptr_5 = default(IntPtr);
		byte[] array14 = default(byte[]);
		byte[] array15 = default(byte[]);
		int num40 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num61 = default(int);
		int num63 = default(int);
		int num65 = default(int);
		CryptoStream object_2 = default(CryptoStream);
		IntPtr intptr_3 = default(IntPtr);
		int num28 = default(int);
		int num23 = default(int);
		int num49 = default(int);
		int num51 = default(int);
		string text = default(string);
		int num55 = default(int);
		int num57 = default(int);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array12 = default(byte[]);
		byte[] array18 = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		uint nativeSizeOfCode = default(uint);
		MemoryStream object_4 = default(MemoryStream);
		int num46 = default(int);
		byte[] array20 = default(byte[]);
		byte[] array8 = default(byte[]);
		ref byte reference2 = default(ref byte);
		int num43 = default(int);
		int num45 = default(int);
		IntPtr intptr_4 = default(IntPtr);
		int num38 = default(int);
		bZYeaHi8qu2JN9K2Ig bZYeaHi8qu2JN9K2Ig2 = default(bZYeaHi8qu2JN9K2Ig);
		byte[] array11 = default(byte[]);
		byte[] array10 = default(byte[]);
		long num10 = default(long);
		bZYeaHi8qu2JN9K2Ig bZYeaHi8qu2JN9K2Ig = default(bZYeaHi8qu2JN9K2Ig);
		byte[] i6SKfYay1R = default(byte[]);
		K8R1q578nEBETPsLFo uint_ = default(K8R1q578nEBETPsLFo);
		uint num8 = default(uint);
		int int_ = default(int);
		int num11 = default(int);
		ProcessModuleCollection object_3 = default(ProcessModuleCollection);
		IntPtr intptr_ = default(IntPtr);
		string string_ = default(string);
		int num9 = default(int);
		bool flag = default(bool);
		int num31 = default(int);
		long value = default(long);
		IntPtr zero2 = default(IntPtr);
		long num34 = default(long);
		IntPtr zero = default(IntPtr);
		while (!aEM4TbtNAl)
		{
			int num2 = 565;
			if (tQ4VPAqlcsXEPAd5sK() == null)
			{
				goto IL_0025;
			}
			goto IL_0b40;
			IL_0b40:
			num2 = num;
			goto IL_0025;
			IL_0025:
			while (true)
			{
				uint num77;
				int num73;
				int num75;
				IntPtr intptr_2;
				int num66;
				int num67;
				int num68;
				int num71;
				nint num25;
				int num59;
				int num60;
				int num62;
				int num64;
				int num48;
				int num50;
				long num53;
				long num52;
				int num54;
				int num56;
				byte[] array22;
				int num41;
				byte[] array21;
				int num42;
				int num44;
				int num47;
				byte[] array19;
				ref bZYeaHi8qu2JN9K2Ig reference;
				byte[] array9;
				switch (num2)
				{
				case 566:
					break;
				case 695:
					array13 = null;
					num2 = 405;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 281;
				case 281:
					array2 = new byte[16];
					num2 = 101;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 694:
					array6 = (byte[])efYF6H5kRI5O9Bw9vhk(zero.ToInt64());
					goto case 118;
				case 118:
					array4 = (byte[])efYF6H5kRI5O9Bw9vhk(num34);
					num2 = 296;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 693:
					array[14] = (byte)num3;
					goto case 498;
				case 498:
					num3 = 94;
					goto case 534;
				case 534:
					array[14] = (byte)num3;
					num2 = 478;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 692:
					num5 = 100;
					goto case 301;
				case 301:
					array2[3] = (byte)num5;
					goto case 673;
				case 673:
					num14 = 103;
					goto case 458;
				case 458:
					array2[3] = (byte)num14;
					goto case 567;
				case 567:
					array2[4] = 92;
					num = 680;
					goto case 680;
				case 680:
					array2[4] = 104;
					goto case 83;
				case 83:
					array2[4] = 116;
					num = 364;
					goto case 364;
				case 364:
					array2[4] = 56;
					num2 = 27;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 691:
					if (num12 == num15 - 1)
					{
						num2 = 299;
						if (tQ4VPAqlcsXEPAd5sK() != null)
						{
							continue;
						}
						goto case 501;
					}
					goto case 688;
				case 501:
					if (num32 > 0)
					{
						num2 = 401;
						if (w9diKK5g7kam6LVG9j())
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 688;
				case 688:
					num18 = (uint)num33;
					goto case 99;
				case 99:
					num29 += num19;
					goto case 657;
				case 657:
					num7 = (uint)((array17[num18 + 3] << 24) | (array17[num18 + 2] << 16) | (array17[num18 + 1] << 8) | array17[num18]);
					goto case 267;
				case 267:
				case 544:
					num29 = num29;
					num2 = 298;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 475;
				case 475:
				{
					num77 = num29;
					uint num78 = num29;
					num78 ^= num78 >> 6;
					num78 += 2747050913u;
					num78 ^= num78 >> 7;
					num78 += 96649441;
					num78 ^= num78 << 21;
					num78 += 2442726594u;
					num78 = 607677248 + num78;
					num29 = num77 + (uint)(double)num78;
					num2 = 137;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 407;
				}
				case 407:
					if (num12 == num15 - 1)
					{
						goto case 130;
					}
					goto case 73;
				case 130:
					if (num32 > 0)
					{
						num2 = 319;
						if (w9diKK5g7kam6LVG9j())
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 73;
				case 73:
					num79 = num29 ^ num7;
					goto case 253;
				case 253:
					array16[num33] = (byte)(num79 & 0xFFu);
					goto case 675;
				case 675:
					array16[num33 + 1] = (byte)((num79 & 0xFF00) >> 8);
					goto case 276;
				case 276:
					array16[num33 + 2] = (byte)((num79 & 0xFF0000) >> 16);
					goto case 519;
				case 519:
					array16[num33 + 3] = (byte)((num79 & 0xFF000000u) >> 24);
					goto case 293;
				case 293:
				case 644:
					num12++;
					num = 334;
					goto case 219;
				case 219:
				case 334:
					if (num12 >= num15)
					{
						goto case 645;
					}
					goto case 625;
				case 645:
					array7 = array16;
					goto case 532;
				case 532:
					num24 = array7.Length / 8;
					num2 = 56;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 625:
					num27 = num12 % num26;
					goto case 440;
				case 440:
					num33 = num12 * 4;
					num2 = 686;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 690:
					try
					{
						while (true)
						{
							IL_0f4e:
							if (!lCVgh3QmHr2UmvwLvF(enumerator))
							{
								num73 = 3;
								if (w9diKK5g7kam6LVG9j())
								{
									break;
								}
								goto IL_0ee5;
							}
							goto IL_0f20;
							IL_0e7c:
							if (DI4Y59M24OPH6Zbqh8(GUoZ2FFfJ8HI0ILO7c(MXSmQSm4mGd9evCkID(object_13)), "clrjit.dll"))
							{
								goto IL_0e16;
							}
							num73 = 1;
							if (!w9diKK5g7kam6LVG9j())
							{
								goto IL_0e0d;
							}
							goto IL_0ee5;
							IL_0f20:
							object_13 = (ProcessModule)qquo3skueBPJxbdXIW(enumerator);
							num73 = 4;
							if (w9diKK5g7kam6LVG9j())
							{
								goto IL_0e7c;
							}
							goto IL_0ee5;
							IL_0ee5:
							while (true)
							{
								switch (num73)
								{
								case 12:
									break;
								case 10:
									goto end_IL_0ee5;
								case 4:
									goto IL_0e4d;
								case 5:
									goto IL_0e7c;
								case 3:
									goto IL_0e96;
								case 8:
									object_14 = new Version(4, 0, 30319, 17921);
									num73 = 0;
									if (tQ4VPAqlcsXEPAd5sK() == null)
									{
										continue;
									}
									goto default;
								default:
									if (!KqCt95s7vcOvvgaonL(object_15, object_16))
									{
										goto IL_0f4e;
									}
									goto IL_0e96;
								case 9:
									goto IL_0f20;
								case 1:
								case 7:
								case 11:
									goto IL_0f4e;
								case 2:
								case 6:
									goto end_IL_0f4e;
								}
								zL34aF4R7Q = true;
								num73 = 2;
								if (tQ4VPAqlcsXEPAd5sK() == null)
								{
									continue;
								}
								goto IL_0e0d;
								continue;
								end_IL_0ee5:
								break;
							}
							goto IL_0e16;
							IL_0e16:
							object_15 = new Version(bFHmVZ1if45JHyHbYG(avKtoyEsrEw21eUVpi(object_13)), AoN4UQOwwpys6j9mT3(avKtoyEsrEw21eUVpi(object_13)), RRNh6xrFZTYy0WnPf7(avKtoyEsrEw21eUVpi(object_13)), MOZKV0CNtoeHsTSWSN(avKtoyEsrEw21eUVpi(object_13)));
							goto IL_0e4d;
							IL_0e4d:
							object_16 = new Version(4, 0, 30319, 17020);
							num73 = 8;
							if (!w9diKK5g7kam6LVG9j())
							{
								goto IL_0e96;
							}
							goto IL_0ee5;
							IL_0e96:
							if (!TrZCFCJqiLuu5UEeoY(object_15, object_14))
							{
								continue;
							}
							num73 = 12;
							if (!w9diKK5g7kam6LVG9j())
							{
								goto IL_0e7c;
							}
							goto IL_0ee5;
							IL_0e0d:
							num73 = num74;
							goto IL_0ee5;
							continue;
							end_IL_0f4e:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						num75 = 2;
						if (!w9diKK5g7kam6LVG9j())
						{
							goto IL_0f85;
						}
						goto IL_0f9e;
						IL_0f9e:
						while (true)
						{
							switch (num75)
							{
							case 2:
								if (disposable != null)
								{
									num75 = 1;
									if (tQ4VPAqlcsXEPAd5sK() == null)
									{
										continue;
									}
									break;
								}
								goto end_IL_0f9e;
							case 1:
								YoPIe6GE7tAY6ya3RM(disposable);
								num75 = 0;
								if (!w9diKK5g7kam6LVG9j())
								{
									continue;
								}
								goto end_IL_0f9e;
							default:
								goto end_IL_0f9e;
							case 0:
								goto end_IL_0f9e;
							}
							goto IL_0f85;
							continue;
							end_IL_0f9e:
							break;
						}
						goto end_IL_0f5c;
						IL_0f85:
						num75 = num76;
						goto IL_0f9e;
						end_IL_0f5c:;
					}
					goto case 71;
				case 71:
				case 321:
					object_ = new WpWSp8jcj2DZFKf0eg((Stream)u0fUSm61LREN8CWoMQ(mN74oSlkhV, "mQt7DRf8hGD4FIE4dr.6lwmQoIuH1QK8IIKQJ"));
					goto case 154;
				case 154:
					Ft6eRFAB9TGlPxu5CN(dr4pDGttyGLTDiPG8x(object_), 0L);
					num2 = 169;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 689:
					num3 = 149;
					goto case 615;
				case 615:
					array[30] = (byte)num3;
					goto case 81;
				case 81:
					array[30] = 134;
					num2 = 94;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 480;
				case 480:
					num3 = 144;
					num2 = 112;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 687:
					if (CLythVXuCVyvcwvoIf() != 4)
					{
						goto case 145;
					}
					goto case 218;
				case 145:
					aNB47Ca6Ue(zero2, intPtr3, (byte[])tHGsZI7flKsjPMwDHx(rB6TZEb8JtjnFD4eoI(object_)), 4u, out intptr_2);
					num = 362;
					goto case 62;
				case 62:
				case 362:
					bGY4RO1lga(intPtr3, 4, int_2, ref int_2);
					goto case 211;
				case 211:
					num58++;
					goto case 104;
				case 239:
					intPtr3 = new IntPtr(Gct4PJtVDZ + rB6TZEb8JtjnFD4eoI(object_) - num36);
					goto case 286;
				case 286:
					bGY4RO1lga(intPtr3, 4, 4, ref int_2);
					num2 = 212;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 687;
				case 104:
				case 426:
					if (num58 < num37)
					{
						goto case 239;
					}
					num2 = 165;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 24;
				case 218:
					aNB47Ca6Ue(zero2, intPtr3, (byte[])tHGsZI7flKsjPMwDHx(rB6TZEb8JtjnFD4eoI(object_)), 4u, out intptr_2);
					num2 = 62;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 24:
				case 654:
					if (YgBrXGz2eG7nxmLopR(dr4pDGttyGLTDiPG8x(object_)) < PhhLSiUFhVHNR8p4an(dr4pDGttyGLTDiPG8x(object_)) - 1L)
					{
						num2 = 39;
						if (tQ4VPAqlcsXEPAd5sK() == null)
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 616;
				case 616:
					USQxQy55Nx0SOj84KiJ(zero2);
					num2 = 530;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 686:
					num18 = (uint)(num27 * 4);
					num2 = 217;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 199;
				case 199:
				case 638:
					if (num13 >= num32)
					{
						num = 267;
						goto case 267;
					}
					goto case 262;
				case 262:
					if (num13 > 0)
					{
						num2 = 31;
						if (tQ4VPAqlcsXEPAd5sK() == null)
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 8;
				case 8:
					num7 |= array17[^(1 + num13)];
					num2 = 67;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 685:
					array2[0] = 75;
					goto case 237;
				case 237:
					array2[1] = 49;
					goto case 368;
				case 368:
					array2[1] = 136;
					num = 20;
					goto case 20;
				case 20:
					array2[1] = 132;
					goto case 672;
				case 672:
					num5 = 138;
					goto case 577;
				case 577:
					array2[1] = (byte)num5;
					num = 537;
					goto case 537;
				case 537:
					num14 = 249;
					num2 = 287;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 133;
				case 133:
					array3[num4 + 3] = array4[3];
					num2 = 179;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 50;
				case 50:
					array[27] = (byte)num3;
					goto case 288;
				case 288:
					array[27] = 128;
					goto case 264;
				case 264:
					num3 = 106;
					goto case 666;
				case 666:
					array[27] = (byte)num3;
					goto case 190;
				case 190:
					num6 = 70;
					goto case 17;
				case 17:
					array[27] = (byte)num6;
					num2 = 95;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 684:
					array[4] = 92;
					num = 216;
					goto case 216;
				case 216:
					array[4] = 180;
					num2 = 37;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 683:
					array5[5] = 116;
					num = 634;
					goto case 634;
				case 634:
					array5[6] = 46;
					num2 = 38;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 682:
					gmsKVnQ4m = false;
					num = 233;
					goto case 233;
				case 233:
					if (num22 >= 1879048192)
					{
						goto case 86;
					}
					goto case 551;
				case 86:
					gmsKVnQ4m = true;
					goto case 551;
				case 551:
					int_3 = rB6TZEb8JtjnFD4eoI(object_);
					num2 = 468;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 681:
					array[23] = 128;
					num = 177;
					goto case 177;
				case 177:
					array[23] = 169;
					goto case 106;
				case 106:
					num3 = 106;
					goto case 182;
				case 182:
					array[23] = (byte)num3;
					num = 242;
					goto case 242;
				case 242:
					num6 = 20;
					goto case 175;
				case 175:
					array[23] = (byte)num6;
					num2 = 509;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 679:
					array[20] = 210;
					num2 = 518;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 500;
				case 500:
					num5 = 25;
					goto case 377;
				case 377:
					array2[13] = (byte)num5;
					goto case 292;
				case 292:
					array2[14] = 122;
					goto case 435;
				case 435:
					array2[14] = 123;
					goto case 653;
				case 653:
					num5 = 133;
					goto case 349;
				case 349:
					array2[14] = (byte)num5;
					goto case 231;
				case 231:
					array2[14] = 110;
					num = 517;
					goto case 517;
				case 517:
					num14 = 241;
					num = 323;
					goto case 323;
				case 323:
					array2[14] = (byte)num14;
					num = 400;
					goto case 400;
				case 400:
					num14 = 93;
					num2 = 173;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 98;
				case 98:
					array[9] = 227;
					goto case 540;
				case 540:
					num6 = 134;
					goto case 153;
				case 153:
					array[10] = (byte)num6;
					goto case 318;
				case 318:
					array[10] = 135;
					num2 = 550;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 678:
					array[1] = 93;
					num = 383;
					goto case 383;
				case 383:
					array[1] = 84;
					goto case 660;
				case 660:
					array[1] = 152;
					goto case 134;
				case 134:
					num6 = 98;
					num2 = 255;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 322;
				case 322:
					array[2] = (byte)num6;
					goto case 609;
				case 609:
					array[2] = 124;
					goto case 353;
				case 353:
					array[2] = 129;
					num2 = 623;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 677:
					num16 = 9;
					num2 = 45;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 404;
				case 404:
					array3[num16] = array13[0];
					num2 = 489;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 676:
					try
					{
						ProcessModuleCollection object_11 = (ProcessModuleCollection)iEXT8Gp3Y3HIllX7SI(object_6);
						num66 = 1;
						if (tQ4VPAqlcsXEPAd5sK() != null)
						{
							goto IL_159d;
						}
						goto IL_15a1;
						IL_15a1:
						while (true)
						{
							switch (num66)
							{
							case 1:
								break;
							default:
								try
								{
									while (lCVgh3QmHr2UmvwLvF(enumerator))
									{
										while (true)
										{
											IL_1600:
											ProcessModule object_12 = (ProcessModule)qquo3skueBPJxbdXIW(enumerator);
											while (true)
											{
												IL_15f5:
												intPtr2 = NxQs2Ziwq4ui1TgYFd(object_12);
												while (intPtr2.ToInt64() == KaGK4PkRSg)
												{
													num67 = 1;
													if (tQ4VPAqlcsXEPAd5sK() == null)
													{
														switch (num67)
														{
														case 6:
															break;
														case 3:
															goto IL_15f5;
														case 2:
															goto IL_1600;
														default:
															goto end_IL_15e5;
														case 1:
															goto IL_161c;
														case 4:
														case 5:
															goto end_IL_1610;
														}
														continue;
													}
													goto IL_161c;
													IL_161c:
													num36 = 0;
													goto end_IL_1610;
													continue;
													end_IL_15e5:
													break;
												}
												break;
											}
											break;
										}
										continue;
										end_IL_1610:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									while (disposable != null)
									{
										num68 = 1;
										if (!w9diKK5g7kam6LVG9j())
										{
											goto IL_164f;
										}
										goto IL_1653;
										IL_164f:
										num68 = num69;
										goto IL_1653;
										IL_1653:
										while (true)
										{
											switch (num68)
											{
											case 1:
												goto IL_163b;
											default:
												goto end_IL_1653;
											case 2:
												break;
											case 0:
												goto end_IL_1653;
											}
											goto IL_1666;
											IL_163b:
											YoPIe6GE7tAY6ya3RM(disposable);
											num68 = 0;
											if (tQ4VPAqlcsXEPAd5sK() == null)
											{
												continue;
											}
											goto IL_164f;
											continue;
											end_IL_1653:
											break;
										}
										break;
										IL_1666:;
									}
								}
								goto end_IL_15a1;
							case 2:
								goto end_IL_15a1;
							}
							enumerator = (IEnumerator)uSF7tk4PoUdsFmDJNX(object_11);
							num66 = 0;
							if (w9diKK5g7kam6LVG9j())
							{
								continue;
							}
							goto IL_159d;
							continue;
							end_IL_15a1:
							break;
						}
						goto end_IL_156f;
						IL_159d:
						num66 = num70;
						goto IL_15a1;
						end_IL_156f:;
					}
					catch (object obj6)
					{
						num71 = 0;
						if (!w9diKK5g7kam6LVG9j())
						{
							num71 = num72;
						}
						switch (num71)
						{
						}
					}
					goto case 378;
				case 378:
					uMu4z0CoEH = null;
					num2 = 637;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 277;
				case 277:
					array[13] = (byte)num3;
					goto case 129;
				case 129:
					array[14] = 181;
					goto case 291;
				case 291:
					num3 = 55;
					num2 = 536;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 674:
					num3 = 128;
					num2 = 526;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 671:
					array3[num4 + 1] = array4[1];
					goto case 335;
				case 335:
					array3[num4 + 2] = array4[2];
					goto case 133;
				case 631:
				case 670:
					if (num17 >= num32)
					{
						goto case 293;
					}
					goto case 243;
				case 243:
					if (num17 > 0)
					{
						num2 = 374;
						if (w9diKK5g7kam6LVG9j())
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 4;
				case 4:
					array16[num33 + num17] = (byte)((num30 & num20) >> num35);
					num2 = 191;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 669:
					array6 = null;
					num = 68;
					goto case 68;
				case 68:
					array4 = null;
					num2 = 695;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 668:
					array2[0] = 106;
					num2 = 685;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 108;
				case 108:
					array[15] = (byte)num6;
					goto case 121;
				case 121:
					num3 = 150;
					num2 = 587;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 667:
					num25 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3) + (nint)num21 * (nint)8);
					*(long*)num25 ^= 163080304L;
					num2 = 249;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 665:
					array3[num16 + 1] = array4[1];
					num2 = 523;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 447;
				case 447:
					array[21] = 117;
					goto case 467;
				case 467:
					array[21] = 138;
					goto case 143;
				case 143:
					array[21] = 76;
					num2 = 77;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 664:
					array[3] = 84;
					goto case 649;
				case 649:
					array[3] = 157;
					num = 117;
					goto case 117;
				case 117:
					num3 = 54;
					num2 = 315;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 663:
					array[29] = 120;
					goto case 373;
				case 373:
					array[29] = 123;
					goto case 419;
				case 419:
					num6 = 155;
					goto case 463;
				case 463:
					array[29] = (byte)num6;
					num2 = 434;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 662:
					num12 = 0;
					goto case 219;
				case 661:
					array[9] = 125;
					num2 = 317;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 127;
				case 127:
					array2[10] = (byte)num5;
					num2 = 22;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 659:
					num5 = 114;
					num2 = 92;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 658:
					array[12] = 73;
					goto case 196;
				case 196:
					num6 = 40;
					goto case 168;
				case 168:
					array[13] = (byte)num6;
					num2 = 277;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 329;
				case 329:
					num6 = 134;
					goto case 445;
				case 445:
					array[13] = (byte)num6;
					goto case 25;
				case 25:
					array[13] = 128;
					num = 202;
					goto case 202;
				case 202:
					num3 = 21;
					num2 = 277;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 260:
				case 656:
					num21 = 0;
					goto case 344;
				case 344:
				case 466:
					if (num21 < num24)
					{
						goto case 667;
					}
					goto case 474;
				case 474:
					reference3 = ref *(byte*)null;
					goto case 333;
				case 333:
					object_ = new WpWSp8jcj2DZFKf0eg(new MemoryStream(array7));
					goto case 244;
				case 244:
					Ft6eRFAB9TGlPxu5CN(dr4pDGttyGLTDiPG8x(object_), 0L);
					num = 351;
					goto case 351;
				case 351:
					intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(mN74oSlkhV))[0]);
					num = 312;
					goto case 312;
				case 312:
					num39 = intPtr2.ToInt64();
					goto case 188;
				case 188:
					int_2 = 0;
					goto case 503;
				case 503:
					num36 = 0;
					num = 589;
					goto case 589;
				case 589:
					if (VCJ6SLfCTMIknVulEp(mN74oSlkhV) == null)
					{
						goto case 91;
					}
					goto case 164;
				case 91:
				case 367:
					num36 = 7680;
					goto case 16;
				case 164:
					if (YGjPhdabah83SpyRCl(VCJ6SLfCTMIknVulEp(mN74oSlkhV)) == 0)
					{
						num2 = 91;
						if (w9diKK5g7kam6LVG9j())
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 16;
				case 16:
					num37 = rB6TZEb8JtjnFD4eoI(object_);
					num2 = 557;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 655:
					object_10 = (WIZ8WE02qlCAiCa8dc)OX7VDP5j28MEqxsyl4j(procAddress, FOHnOE5SnEatDcLXNlx(typeof(WIZ8WE02qlCAiCa8dc).TypeHandle));
					goto case 428;
				case 428:
					intptr_5 = gvNNRW5vK33LLMxfH0O(object_10);
					goto case 78;
				case 78:
					value = 0L;
					goto case 524;
				case 524:
					if (CLythVXuCVyvcwvoIf() == 4)
					{
						num = 241;
						goto case 241;
					}
					goto case 42;
				case 241:
					value = Gqe6GG5Pe46WyVApDX7(intptr_5);
					goto case 486;
				case 42:
					value = vwBCrx5ZU5AJtCFp2kB(intptr_5);
					num2 = 4;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 486;
				case 486:
				case 514:
					npQnGPS2svNOvmFlOU(intptr_5, 0);
					goto case 330;
				case 330:
					TNYKXullJB = new lCvkUik0j3csWuLBtF(rob4kGNJXO);
					num2 = 87;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 652:
					Gct4PJtVDZ = intPtr2.ToInt64();
					num2 = 163;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 651:
					array2[6] = (byte)num5;
					goto case 376;
				case 376:
					num14 = 77;
					num2 = 482;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 650:
					array14[11] = array15[5];
					goto case 320;
				case 320:
					array14[13] = array15[6];
					num2 = 279;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 131;
				case 131:
					num40 = rB6TZEb8JtjnFD4eoI(object_) - num36;
					num2 = 254;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 648:
					array[18] = (byte)num6;
					goto case 34;
				case 34:
					array[18] = 38;
					goto case 57;
				case 57:
					array[18] = 203;
					num2 = 23;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 646:
					array[15] = 155;
					goto case 398;
				case 398:
					num6 = 92;
					goto case 228;
				case 228:
					array[15] = (byte)num6;
					num2 = 450;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 392;
				case 392:
					memoryStream = new MemoryStream();
					num2 = 227;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 68;
				case 643:
					array[6] = 133;
					goto case 155;
				case 155:
					num6 = 189;
					num = 7;
					goto case 7;
				case 7:
					array[6] = (byte)num6;
					num = 215;
					goto case 215;
				case 215:
					num6 = 162;
					num2 = 365;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 642:
					num6 = 147;
					num = 158;
					goto case 158;
				case 158:
					array[18] = (byte)num6;
					goto case 64;
				case 64:
					array[18] = 108;
					goto case 535;
				case 535:
					num6 = 128;
					num2 = 648;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 640:
					array[25] = 42;
					goto case 363;
				case 363:
					array[25] = 96;
					num = 12;
					goto case 12;
				case 12:
					num3 = 70;
					goto case 170;
				case 170:
					array[26] = (byte)num3;
					goto case 385;
				case 385:
					array[26] = 127;
					goto case 397;
				case 397:
					array[26] = 155;
					num2 = 115;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 639:
					array3[num4] = array4[0];
					goto case 671;
				case 637:
					try
					{
						uMu4z0CoEH = (lCvkUik0j3csWuLBtF)OX7VDP5j28MEqxsyl4j(new IntPtr(num34), FOHnOE5SnEatDcLXNlx(typeof(lCvkUik0j3csWuLBtF).TypeHandle));
						num59 = 0;
						if (!w9diKK5g7kam6LVG9j())
						{
							switch (num59)
							{
							}
						}
					}
					catch (object obj5)
					{
						num60 = 1;
						if (!w9diKK5g7kam6LVG9j())
						{
							num60 = num61;
						}
						switch (num60)
						{
						case 1:
							try
							{
								Delegate object_9 = (Delegate)OX7VDP5j28MEqxsyl4j(new IntPtr(num34), FOHnOE5SnEatDcLXNlx(typeof(lCvkUik0j3csWuLBtF).TypeHandle));
								num62 = 0;
								if (tQ4VPAqlcsXEPAd5sK() != null)
								{
									goto IL_1de9;
								}
								goto IL_1ded;
								IL_1ded:
								while (true)
								{
									switch (num62)
									{
									case 1:
										goto end_IL_1ded;
									}
									uMu4z0CoEH = (lCvkUik0j3csWuLBtF)flxcrP5lVfXvv0lfwG8(FOHnOE5SnEatDcLXNlx(typeof(lCvkUik0j3csWuLBtF).TypeHandle), BTxDti5Wti80t4gi9wU(object_9));
									num62 = 1;
									if (w9diKK5g7kam6LVG9j())
									{
										continue;
									}
									goto IL_1de9;
									continue;
									end_IL_1ded:
									break;
								}
								goto end_IL_1d95;
								IL_1de9:
								num62 = num63;
								goto IL_1ded;
								end_IL_1d95:;
							}
							catch (object obj4)
							{
								num64 = 0;
								if (tQ4VPAqlcsXEPAd5sK() != null)
								{
									num64 = num65;
								}
								switch (num64)
								{
								default:
									goto end_IL_1dfe;
								}
								end_IL_1dfe:;
							}
							break;
						case 0:
							break;
						}
					}
					goto case 212;
				case 212:
					num2 = 543;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 636:
					array[1] = (byte)num6;
					goto case 678;
				case 635:
					IoAGuMgKWO3tKKbFRf(object_2);
					goto case 604;
				case 604:
					cGeZFQ0u3NNh3Bxmgc(object_);
					num2 = 546;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 633:
					num58 = 0;
					goto case 104;
				case 632:
					array[19] = (byte)num3;
					goto case 266;
				case 266:
					num3 = 1;
					goto case 147;
				case 147:
					array[19] = (byte)num3;
					num2 = 512;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 630:
					array[19] = (byte)num3;
					num = 574;
					goto case 574;
				case 574:
					num3 = 124;
					num2 = 632;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 629:
					num14 = 112;
					num2 = 492;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 628:
					array3[num4 + 6] = array6[6];
					num2 = 43;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 627:
					G6mMDw59E9QervP9nC1(new IntPtr(intptr_3.ToInt64() + num28 * 4), rB6TZEb8JtjnFD4eoI(object_));
					goto case 395;
				case 395:
					num28++;
					goto case 245;
				case 245:
				case 585:
					if (num28 < num23)
					{
						goto case 627;
					}
					num2 = 265;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 176;
				case 176:
					array[24] = (byte)num6;
					goto case 528;
				case 528:
					num3 = 115;
					goto case 564;
				case 564:
					array[24] = (byte)num3;
					num2 = 18;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 7;
				case 626:
					reference3 = ref *(byte*)null;
					num2 = 656;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 624:
					num6 = 103;
					num2 = 347;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 623:
					num3 = 101;
					goto case 128;
				case 128:
					array[2] = (byte)num3;
					goto case 15;
				case 15:
					num6 = 188;
					num2 = 171;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 622:
					num3 = 139;
					num2 = 355;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 114;
				case 114:
					array[26] = 136;
					num2 = 185;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 470:
				case 621:
					object_6 = (Process)yPcscORqInLIO1Lmn8();
					goto case 552;
				case 552:
					try
					{
						ProcessModuleCollection object_7 = (ProcessModuleCollection)iEXT8Gp3Y3HIllX7SI(object_6);
						num48 = 2;
						if (tQ4VPAqlcsXEPAd5sK() != null)
						{
							num48 = num49;
						}
						while (true)
						{
							switch (num48)
							{
							case 2:
								goto IL_204b;
							default:
								goto end_IL_2060;
							case 1:
								break;
							case 0:
								goto end_IL_2060;
							}
							goto IL_2077;
							IL_204b:
							enumerator = (IEnumerator)uSF7tk4PoUdsFmDJNX(object_7);
							num48 = 1;
							if (tQ4VPAqlcsXEPAd5sK() == null)
							{
								continue;
							}
							goto IL_2077;
							IL_2077:
							try
							{
								while (lCVgh3QmHr2UmvwLvF(enumerator))
								{
									while (true)
									{
										ProcessModule object_8 = (ProcessModule)qquo3skueBPJxbdXIW(enumerator);
										num50 = 0;
										if (tQ4VPAqlcsXEPAd5sK() != null)
										{
											num50 = num51;
										}
										while (true)
										{
											switch (num50)
											{
											case 8:
												num53 = num34;
												intPtr2 = NxQs2Ziwq4ui1TgYFd(object_8);
												if (num53 <= intPtr2.ToInt64() + kwVo6g5eCiKcnQiuiPm(object_8))
												{
													goto end_IL_2133;
												}
												goto case 3;
											case 3:
												if (!pGdYqW53Glk7uDdyY3i(OeqDXT5i5g8O6rrXhdw(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly), null))
												{
													goto end_IL_2133;
												}
												goto case 6;
											case 6:
												xGKrYIlYDeuaXoT8kx();
												num50 = 1;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												return;
											case 1:
												num52 = num34;
												intPtr2 = NxQs2Ziwq4ui1TgYFd(object_8);
												if (num52 >= intPtr2.ToInt64())
												{
													goto case 8;
												}
												goto case 3;
											default:
												if (!DI4Y59M24OPH6Zbqh8(MXSmQSm4mGd9evCkID(object_8), text))
												{
													goto end_IL_2133;
												}
												num50 = 1;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 1;
											case 4:
												break;
											case 2:
												goto end_IL_2133;
											case 7:
												goto end_IL_2154;
											case 5:
												return;
											}
											break;
										}
										continue;
										end_IL_2133:
										break;
									}
									continue;
									end_IL_2154:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								while (true)
								{
									if (disposable != null)
									{
										goto IL_2170;
									}
									num54 = 0;
									if (!w9diKK5g7kam6LVG9j())
									{
										num54 = num55;
									}
									goto IL_2183;
									IL_2170:
									YoPIe6GE7tAY6ya3RM(disposable);
									num54 = 0;
									if (tQ4VPAqlcsXEPAd5sK() == null)
									{
										break;
									}
									goto IL_2183;
									IL_2183:
									switch (num54)
									{
									case 3:
										break;
									default:
										goto end_IL_21ad;
									case 2:
										continue;
									case 0:
									case 1:
										goto end_IL_21ad;
									}
									goto IL_2170;
									continue;
									end_IL_21ad:
									break;
								}
							}
							break;
							continue;
							end_IL_2060:
							break;
						}
					}
					catch (object obj3)
					{
						num56 = 0;
						if (!w9diKK5g7kam6LVG9j())
						{
							num56 = num57;
						}
						switch (num56)
						{
						}
					}
					goto case 676;
				case 620:
					if (num32 > 0)
					{
						goto case 581;
					}
					goto case 539;
				case 581:
					num15++;
					goto case 539;
				case 539:
					num18 = 0u;
					goto case 662;
				case 619:
					num3 = 95;
					num = 48;
					goto case 48;
				case 48:
					array[7] = (byte)num3;
					num2 = 258;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 618:
					array[20] = (byte)num3;
					num = 268;
					goto case 268;
				case 268:
					array[21] = 123;
					goto case 350;
				case 350:
					array[21] = 128;
					num = 447;
					goto case 447;
				case 617:
					array5 = new byte[10];
					goto case 166;
				case 166:
					array5[0] = 99;
					goto case 282;
				case 282:
					array5[1] = 108;
					num2 = 342;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 614:
					num3 = 90;
					goto case 84;
				case 84:
					array[3] = (byte)num3;
					num2 = 274;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 236;
				case 236:
					object_5 = (SymmetricAlgorithm)YpJDdU2rahwaaJMFTW();
					goto case 598;
				case 598:
					EvFgX4N5cctbNxeBcv(object_5, CipherMode.CBC);
					num = 60;
					goto case 60;
				case 60:
					transform = (ICryptoTransform)a7ybunhOLsC0sMnidC(object_5, array12, array14);
					goto case 573;
				case 573:
					RCsMwvDuucQMnoycto(array12, 0, array12.Length);
					goto case 392;
				case 613:
					array2[12] = 144;
					goto case 490;
				case 490:
					array2[12] = 87;
					goto case 103;
				case 103:
					array2[12] = 159;
					goto case 197;
				case 197:
					num5 = 97;
					goto case 580;
				case 580:
					array2[12] = (byte)num5;
					goto case 285;
				case 285:
					array2[12] = 159;
					goto case 206;
				case 206:
					num14 = 203;
					num2 = 395;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 556;
				case 556:
					array2[12] = (byte)num14;
					goto case 240;
				case 240:
					num14 = 159;
					num2 = 462;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 97;
				case 97:
					array2[0] = 94;
					goto case 472;
				case 472:
					array2[0] = 148;
					goto case 70;
				case 70:
					array2[0] = 126;
					num2 = 244;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 668;
				case 612:
					array22 = new byte[40];
					dvmjCf5Ewwp4k6wEH3A(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					array18 = array22;
					goto case 412;
				case 412:
				case 424:
					intPtr = r3cMyC51YhZBD3hmxXG(IntPtr.Zero, (uint)array18.Length, 4096u, 64u);
					num2 = 168;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 224;
				case 224:
					array3 = array18;
					goto case 669;
				case 296:
				case 611:
					if (CLythVXuCVyvcwvoIf() == 4)
					{
						goto case 677;
					}
					goto case 504;
				case 504:
					num4 = 2;
					goto case 289;
				case 289:
					array3[num4] = array13[0];
					goto case 525;
				case 525:
					array3[num4 + 1] = array13[1];
					goto case 558;
				case 558:
					array3[num4 + 2] = array13[2];
					num2 = 469;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 610:
					array2[6] = 107;
					goto case 414;
				case 414:
					num5 = 170;
					num = 651;
					goto case 651;
				case 608:
					array5[9] = 100;
					num2 = 11;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 607:
					if (pGdYqW53Glk7uDdyY3i(OeqDXT5i5g8O6rrXhdw(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly), null))
					{
						num2 = 48;
						if (tQ4VPAqlcsXEPAd5sK() != null)
						{
							continue;
						}
						goto case 578;
					}
					goto case 61;
				case 578:
					if (((Array)IieZUX5XCJBll5vBpVv(OeqDXT5i5g8O6rrXhdw(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly))).Length == 2)
					{
						goto case 437;
					}
					goto case 61;
				case 437:
					if (VCJ6SLfCTMIknVulEp(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly) != null)
					{
						goto case 340;
					}
					goto case 61;
				case 340:
					if (YGjPhdabah83SpyRCl(VCJ6SLfCTMIknVulEp(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly)) <= 0)
					{
						goto case 61;
					}
					goto case 140;
				case 61:
				case 366:
					try
					{
						object obj = vHyr6t54Xj0WcFO9EpV(WpRwjt5p72lVMVHEEi9(CgngFc5KpOehZOe1uPS(W5VyKM5xHBGOLyIVURB(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), CgngFc5KpOehZOe1uPS(W5VyKM5xHBGOLyIVURB(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly)));
						num41 = 1;
						if (tQ4VPAqlcsXEPAd5sK() != null)
						{
							goto IL_256e;
						}
						goto IL_26e1;
						IL_26e1:
						while (true)
						{
							switch (num41)
							{
							case 16:
								nativeSizeOfCode = 0u;
								num41 = 0;
								if (tQ4VPAqlcsXEPAd5sK() == null)
								{
									continue;
								}
								break;
							case 15:
								IoAGuMgKWO3tKKbFRf(object_4);
								goto case 16;
							case 14:
								w9iKQtMBCF = (IntPtr)vHyr6t54Xj0WcFO9EpV(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
								goto case 7;
							case 7:
								object_4 = new MemoryStream();
								num41 = 3;
								if (tQ4VPAqlcsXEPAd5sK() == null)
								{
									continue;
								}
								goto case 3;
							case 3:
								pfyBOaoei6ELVKY9G8(object_4, new byte[CLythVXuCVyvcwvoIf()], 0, CLythVXuCVyvcwvoIf());
								num41 = 2;
								if (tQ4VPAqlcsXEPAd5sK() != null)
								{
									continue;
								}
								goto case 9;
							case 9:
								if (CLythVXuCVyvcwvoIf() == 4)
								{
									goto case 12;
								}
								goto case 4;
							case 12:
								pfyBOaoei6ELVKY9G8(object_4, tHGsZI7flKsjPMwDHx(w9iKQtMBCF.ToInt32()), 0, 4);
								goto case 8;
							case 4:
								pfyBOaoei6ELVKY9G8(object_4, efYF6H5kRI5O9Bw9vhk(w9iKQtMBCF.ToInt64()), 0, 8);
								goto case 8;
							case 8:
							case 13:
								pfyBOaoei6ELVKY9G8(object_4, new byte[CLythVXuCVyvcwvoIf()], 0, CLythVXuCVyvcwvoIf());
								goto case 2;
							case 2:
								pfyBOaoei6ELVKY9G8(object_4, new byte[CLythVXuCVyvcwvoIf()], 0, CLythVXuCVyvcwvoIf());
								num41 = 6;
								if (w9diKK5g7kam6LVG9j())
								{
									continue;
								}
								break;
							case 11:
								if (DI4Y59M24OPH6Zbqh8(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
								{
									num46 = 14;
									goto case 14;
								}
								goto case 7;
							case 10:
								array20 = (byte[])bdrgWJwirStTW6kwl8(object_4);
								goto case 15;
							case 6:
								Ft6eRFAB9TGlPxu5CN(object_4, 0L);
								goto case 10;
							case 5:
								w9iKQtMBCF = (IntPtr)obj;
								num41 = 11;
								if (tQ4VPAqlcsXEPAd5sK() == null)
								{
									continue;
								}
								break;
							case 1:
								if (obj is IntPtr)
								{
									num41 = 5;
									if (w9diKK5g7kam6LVG9j())
									{
										continue;
									}
									break;
								}
								goto case 11;
							default:
								try
								{
									array21 = (array8 = array20);
									if (array21 != null)
									{
										goto IL_2782;
									}
									goto IL_27b4;
									IL_27b4:
									reference2 = ref *(byte*)null;
									num42 = 0;
									if (tQ4VPAqlcsXEPAd5sK() != null)
									{
										num42 = num43;
									}
									goto IL_2794;
									IL_2738:
									while (true)
									{
										IL_2738_2:
										fixed (byte* value2 = &array8[0])
										{
											while (true)
											{
												IL_2742:
												TNYKXullJB(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
												num42 = 0;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													break;
												}
												while (true)
												{
													switch (num42)
													{
													case 5:
														goto end_IL_2794;
													case 3:
														if (array8.Length != 0)
														{
															goto end_IL_2794;
														}
														goto IL_2788;
													case 2:
														goto end_IL_2738;
													case 1:
														goto end_IL_2742;
													}
													goto IL_2742;
													IL_2788:
													num42 = 0;
													if (w9diKK5g7kam6LVG9j())
													{
														goto end_IL_2738;
													}
													continue;
													end_IL_2794:
													break;
												}
												goto IL_2738_2;
												continue;
												end_IL_2742:
												break;
											}
										}
										goto end_IL_272f;
										continue;
										end_IL_2738:
										break;
									}
									goto IL_27b4;
									IL_2794:
									while (true)
									{
										switch (num42)
										{
										case 5:
											break;
										default:
											TNYKXullJB(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
											num42 = 0;
											if (tQ4VPAqlcsXEPAd5sK() != null)
											{
												continue;
											}
											goto end_IL_272f;
										case 3:
											goto IL_2782;
										case 2:
											goto IL_27b4;
										case 1:
											goto end_IL_272f;
										}
										break;
									}
									goto IL_2738;
									IL_2782:
									if (array8.Length != 0)
									{
										goto IL_2738;
									}
									num42 = 0;
									if (!w9diKK5g7kam6LVG9j())
									{
										goto IL_2794;
									}
									goto IL_27b4;
									end_IL_272f:;
								}
								finally
								{
									reference2 = ref *(byte*)null;
									num44 = 0;
									if (!w9diKK5g7kam6LVG9j())
									{
										num44 = num45;
									}
									switch (num44)
									{
									}
								}
								goto end_IL_26e1;
							case 17:
								goto end_IL_26e1;
							}
							goto IL_256e;
							continue;
							end_IL_26e1:
							break;
						}
						goto end_IL_24f5;
						IL_256e:
						num41 = num46;
						goto IL_26e1;
						end_IL_24f5:;
					}
					catch (object obj2)
					{
						num47 = 0;
						if (!w9diKK5g7kam6LVG9j())
						{
							switch (num47)
							{
							}
						}
					}
					goto case 174;
				case 174:
					yfkAgH5mbrQs5MnqkoA(uMu4z0CoEH);
					goto case 538;
				case 538:
					W4GMrI5Mr7iqNE7VQld(R3VW0p5FhD2Kp6vTh4M(BTxDti5Wti80t4gi9wU(uMu4z0CoEH)));
					goto case 420;
				case 420:
					yfkAgH5mbrQs5MnqkoA(TNYKXullJB);
					num2 = 425;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 606:
					array19 = new byte[30];
					dvmjCf5Ewwp4k6wEH3A(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					array18 = array19;
					num = 424;
					goto case 412;
				case 605:
					bGY4RO1lga(intptr_4, 4, 4, ref int_2);
					goto case 476;
				case 476:
					G6mMDw59E9QervP9nC1(intptr_4, rB6TZEb8JtjnFD4eoI(object_));
					num2 = 28;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 515;
				case 515:
					bGY4RO1lga(intptr_4, 4, int_2, ref int_2);
					goto case 484;
				case 484:
					num38++;
					goto case 150;
				case 72:
					intptr_4 = new IntPtr(num39 + rB6TZEb8JtjnFD4eoI(object_) - num36);
					num = 605;
					goto case 605;
				case 150:
				case 214:
					if (num38 < num37)
					{
						goto case 72;
					}
					goto case 481;
				case 481:
					JYvKLCsA8k = new Hashtable(rB6TZEb8JtjnFD4eoI(object_) + 1);
					goto case 316;
				case 316:
					bZYeaHi8qu2JN9K2Ig2 = default(bZYeaHi8qu2JN9K2Ig);
					num = 19;
					goto case 19;
				case 19:
					reference = ref bZYeaHi8qu2JN9K2Ig2;
					array8 = new byte[1] { 42 };
					reference.I6SKfYay1R = array8;
					goto case 105;
				case 105:
					bZYeaHi8qu2JN9K2Ig2.gmsKVnQ4m9 = false;
					num2 = 48;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 193;
				case 193:
					omQ0sO5qpL1i6TbPW3B(JYvKLCsA8k, 0L, bZYeaHi8qu2JN9K2Ig2);
					num2 = 180;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 603:
					array7 = (byte[])bdrgWJwirStTW6kwl8(memoryStream);
					num2 = 575;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 602:
					num14 = 56;
					goto case 452;
				case 452:
					array2[9] = (byte)num14;
					goto case 336;
				case 336:
					num5 = 20;
					goto case 127;
				case 601:
					array3[num16 + 3] = array13[3];
					num2 = 0;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 600:
					array11[3] = 74;
					goto case 162;
				case 162:
					array11[4] = 105;
					num2 = 257;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 60;
				case 599:
					num5 = 128;
					goto case 250;
				case 250:
					array2[5] = (byte)num5;
					num2 = 403;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 597:
					JIVKKia87p = rVWXyA5nqemDX5Dj2ge(KaGK4PkRSg);
					num2 = 29;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 596:
					pfyBOaoei6ELVKY9G8(object_2, array10, 0, array10.Length);
					goto case 483;
				case 483:
					qmK6ssyVv2RtSC2moB(object_2);
					goto case 603;
				case 595:
					tFudfYnbyHHnulHgAP(new IntPtr(&num10), 0);
					goto case 308;
				case 308:
					Olcn0lLZfqJQ3ckOre(new IntPtr(&num10), 0);
					num2 = 53;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 495;
				case 495:
					EK2KKsV2QueGKgfHEj(new IntPtr(&num10), 0, IntPtr.Zero);
					goto case 151;
				case 151:
					IWJMh085cGT4JTi28O(new IntPtr(&num10), 0, 0);
					goto case 513;
				case 513:
					HOurykjS5Rw0mXWySR(new IntPtr(&num10), 0, 0L);
					goto case 394;
				case 394:
					array8 = new byte[1];
					goto case 380;
				case 380:
					pG2CksPoHx3JrBNyNs(array8, 0, SSUk9AvAPLg9XQGXSZ(8), 1);
					goto case 69;
				case 69:
					KEW15jZMvpDJUcDHjh();
					num2 = 35;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 594:
					num34 = Gqe6GG5Pe46WyVApDX7(new IntPtr(value));
					goto case 470;
				case 593:
					num6 = 157;
					num = 389;
					goto case 389;
				case 389:
					array[20] = (byte)num6;
					num = 541;
					goto case 541;
				case 541:
					num6 = 207;
					goto case 406;
				case 406:
					array[20] = (byte)num6;
					goto case 679;
				case 592:
					num35 = 0;
					goto case 691;
				case 591:
					array[24] = (byte)num6;
					num2 = 138;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 590:
					num6 = 69;
					num2 = 139;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 588:
					array[12] = 106;
					goto case 457;
				case 457:
					array[12] = 158;
					num2 = 273;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 587:
					array[15] = (byte)num3;
					num2 = 75;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 586:
					num6 = 114;
					goto case 59;
				case 59:
					array[1] = (byte)num6;
					num2 = 235;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 584:
					array14[7] = array15[3];
					goto case 94;
				case 94:
					array14[9] = array15[4];
					goto case 650;
				case 583:
					bZYeaHi8qu2JN9K2Ig.I6SKfYay1R = i6SKfYay1R;
					num = 113;
					goto case 113;
				case 113:
					bZYeaHi8qu2JN9K2Ig.gmsKVnQ4m9 = gmsKVnQ4m;
					num = 303;
					goto case 303;
				case 303:
					omQ0sO5qpL1i6TbPW3B(JYvKLCsA8k, num39 + num40, bZYeaHi8qu2JN9K2Ig);
					num2 = 442;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 70;
				case 582:
					num3 = 84;
					num = 396;
					goto case 396;
				case 396:
					array[18] = (byte)num3;
					num = 642;
					goto case 642;
				case 579:
					num3 = 216;
					num2 = 32;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 111;
				case 111:
					array[10] = (byte)num3;
					num2 = 311;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 576:
					array5[4] = 105;
					num2 = 75;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 683;
				case 575:
					RCsMwvDuucQMnoycto(array14, 0, array14.Length);
					goto case 26;
				case 26:
					IoAGuMgKWO3tKKbFRf(memoryStream);
					num2 = 635;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 572:
					zero2 = IntPtr.Zero;
					goto case 341;
				case 341:
					uint_ = (K8R1q578nEBETPsLFo)56;
					num = 352;
					goto case 352;
				case 352:
					zero2 = reinHNYeyu6nKm2drq((uint)uint_, 1, (uint)xUfLwTH5W4vy9l5V5x(yPcscORqInLIO1Lmn8()));
					num2 = 384;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 571:
					array5[3] = 106;
					num = 576;
					goto case 576;
				case 570:
					num3 = 98;
					goto case 446;
				case 446:
					array[4] = (byte)num3;
					num2 = 382;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 569:
					array[27] = (byte)num3;
					num = 298;
					goto case 298;
				case 298:
					num3 = 96;
					num = 50;
					goto case 50;
				case 568:
					array2[5] = (byte)num5;
					num = 599;
					goto case 599;
				case 565:
					aEM4TbtNAl = true;
					goto case 477;
				case 477:
					num8 = 4059231220u;
					num2 = 46;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 563:
					array[17] = (byte)num3;
					goto case 502;
				case 502:
					array[17] = 43;
					num = 582;
					goto case 582;
				case 562:
					bGY4RO1lga(new IntPtr(value), CLythVXuCVyvcwvoIf(), 64, ref int_);
					num2 = 641;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 431;
				case 431:
					array[22] = 166;
					num = 681;
					goto case 681;
				case 561:
					array[0] = 140;
					goto case 455;
				case 455:
					array[0] = 101;
					goto case 21;
				case 21:
					array[1] = 110;
					num = 586;
					goto case 586;
				case 560:
					array6 = (byte[])tHGsZI7flKsjPMwDHx(zero.ToInt32());
					goto case 63;
				case 63:
					array4 = (byte[])tHGsZI7flKsjPMwDHx(rVWXyA5nqemDX5Dj2ge(num34));
					num2 = 611;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 559:
					array2[9] = (byte)num14;
					goto case 393;
				case 393:
					num5 = 99;
					num2 = 14;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 557:
					num11 = rB6TZEb8JtjnFD4eoI(object_);
					num2 = 54;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 555:
					array[11] = (byte)num3;
					goto case 588;
				case 554:
					array2[11] = 100;
					goto case 93;
				case 93:
					num5 = 40;
					goto case 28;
				case 28:
					array2[11] = (byte)num5;
					goto case 413;
				case 413:
					num5 = 96;
					num2 = 74;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 3;
				case 3:
					if (!hYk438KXIo8IVV5oJU(QEKXwaxjNKv9wrBywY("System.Reflection.ReflectionContext", bool_0: false), null))
					{
						goto case 71;
					}
					goto case 251;
				case 251:
					object_3 = (ProcessModuleCollection)iEXT8Gp3Y3HIllX7SI(yPcscORqInLIO1Lmn8());
					goto case 516;
				case 516:
					enumerator = (IEnumerator)uSF7tk4PoUdsFmDJNX(object_3);
					num2 = 690;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 553:
					procAddress = GetProcAddress(intptr_, string_);
					num2 = 655;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 550:
					array[10] = 161;
					num2 = 624;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 549:
					num34 = vwBCrx5ZU5AJtCFp2kB(new IntPtr(value));
					num2 = 621;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 548:
					num3 = 132;
					goto case 386;
				case 386:
					array[17] = (byte)num3;
					goto case 256;
				case 256:
					num3 = 97;
					goto case 563;
				case 547:
					num6 = 57;
					goto case 232;
				case 232:
					array[11] = (byte)num6;
					goto case 204;
				case 204:
					num3 = 101;
					num2 = 268;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 555;
				case 546:
					num37 = rB6TZEb8JtjnFD4eoI(object_);
					num = 441;
					goto case 441;
				case 441:
					num11 = rB6TZEb8JtjnFD4eoI(object_);
					goto case 100;
				case 100:
					if (num11 == 1)
					{
						goto case 572;
					}
					num38 = 0;
					num = 214;
					goto case 150;
				case 545:
					num7 = 0u;
					num2 = 508;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 543:
					int_ = 0;
					num2 = 607;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 542:
					array[9] = (byte)num6;
					goto case 85;
				case 85:
					array[9] = 125;
					goto case 98;
				case 536:
					array[14] = (byte)num3;
					goto case 272;
				case 272:
					array[14] = 114;
					num2 = 326;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 533:
					array2[7] = (byte)num14;
					goto case 152;
				case 152:
					array2[7] = 160;
					num2 = 421;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 531:
					num14 = 120;
					goto case 533;
				case 530:
					xGKrYIlYDeuaXoT8kx();
					num2 = 415;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 529:
					array[16] = (byte)num6;
					num2 = 187;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 527:
					array3[num4 + 6] = array13[6];
					goto case 520;
				case 520:
					array3[num4 + 7] = array13[7];
					num2 = 229;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 526:
					array[26] = (byte)num3;
					num2 = 114;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 523:
					array3[num16 + 2] = array4[2];
					num2 = 246;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 522:
					num14 = 217;
					goto case 559;
				case 521:
					intptr_3 = new IntPtr(Gct4PJtVDZ + num9 - num36);
					num2 = 283;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 282;
				case 518:
					num3 = 45;
					goto case 618;
				case 512:
					array[20] = 102;
					goto case 593;
				case 511:
					array[8] = (byte)num3;
					num = 488;
					goto case 488;
				case 488:
					num3 = 142;
					goto case 52;
				case 52:
					array[8] = (byte)num3;
					goto case 144;
				case 144:
					num3 = 94;
					goto case 159;
				case 159:
					array[8] = (byte)num3;
					goto case 661;
				case 510:
					flag = Ef43VRWJhqrbixH4B5(zWh6VK3ZGslTgW3h1t(NxQs2Ziwq4ui1TgYFd(qgbvhje4AFv3fZX9Sq(yPcscORqInLIO1Lmn8())), "__", 10u), IntPtr.Zero);
					goto case 356;
				case 356:
					if (flag)
					{
						num2 = 460;
						if (tQ4VPAqlcsXEPAd5sK() == null)
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 337;
				case 509:
					array[24] = 125;
					goto case 183;
				case 183:
					array[24] = 187;
					goto case 192;
				case 192:
					num6 = 181;
					goto case 176;
				case 508:
					num13 = 0;
					num2 = 638;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 527;
				case 507:
					array5[1] = 115;
					num2 = 189;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 506:
					intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(mN74oSlkhV))[0]);
					goto case 89;
				case 89:
					GPj4GGybN5 = intPtr2.ToInt32();
					goto case 300;
				case 300:
					intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(mN74oSlkhV))[0]);
					goto case 652;
				case 505:
					array2[9] = 108;
					num = 602;
					goto case 602;
				case 499:
					array2[8] = 106;
					num2 = 491;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 497:
					dAnLMSTENbDtTIuBc2(array14);
					num2 = 105;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 120;
				case 120:
					array15 = (byte[])w1aJonIdBddf8Z1bSs(Ee7jsadQGQKLKaXayU(mN74oSlkhV));
					goto case 195;
				case 195:
					if (array15 != null)
					{
						goto case 88;
					}
					num = 142;
					goto case 65;
				case 88:
					if (array15.Length > 0)
					{
						goto case 302;
					}
					goto case 65;
				case 302:
					array14[1] = array15[0];
					num2 = 390;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 65:
				case 142:
					num31 = 0;
					num2 = 354;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 496:
					array[9] = (byte)num3;
					num2 = 45;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 198;
				case 198:
					num6 = 168;
					goto case 542;
				case 494:
					array[5] = 126;
					goto case 90;
				case 90:
					num6 = 104;
					num2 = 203;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 196;
				case 493:
					array13 = (byte[])tHGsZI7flKsjPMwDHx(w9iKQtMBCF.ToInt32());
					goto case 560;
				case 492:
					array2[13] = (byte)num14;
					num2 = 431;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 500;
				case 491:
					array2[8] = 132;
					num2 = 123;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 328;
				case 328:
					array2[8] = 99;
					goto case 123;
				case 123:
					array2[9] = 113;
					goto case 522;
				case 489:
					array3[num16 + 1] = array13[1];
					num2 = 238;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 487:
					num17 = 0;
					goto case 631;
				case 485:
					array = new byte[32];
					num2 = 345;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 482:
					array2[7] = (byte)num14;
					goto case 531;
				case 479:
					num14 = 131;
					goto case 5;
				case 5:
					array2[2] = (byte)num14;
					goto case 471;
				case 471:
					array2[2] = 216;
					goto case 259;
				case 259:
					array2[3] = 144;
					goto case 692;
				case 478:
					array[14] = 119;
					num2 = 357;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 473:
					RCsMwvDuucQMnoycto(array15, 0, array15.Length);
					goto case 65;
				case 469:
					array3[num4 + 3] = array13[3];
					goto case 411;
				case 411:
					array3[num4 + 4] = array13[4];
					goto case 360;
				case 360:
					array3[num4 + 5] = array13[5];
					goto case 527;
				case 468:
					i6SKfYay1R = (byte[])VfdItgc5swn1llGhOe(object_, int_3);
					goto case 222;
				case 222:
					bZYeaHi8qu2JN9K2Ig = default(bZYeaHi8qu2JN9K2Ig);
					num2 = 583;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 548;
				case 465:
					text = (string)gqt83k5V0ywMxaWpTRi(uMCLWl5L0R5bIeYbTFc(), array5);
					num2 = 263;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 464:
					array[0] = 113;
					goto case 433;
				case 433:
					num3 = 155;
					goto case 47;
				case 47:
					array[0] = (byte)num3;
					num2 = 561;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 462:
					array2[13] = (byte)num14;
					goto case 427;
				case 427:
					num5 = 122;
					num = 346;
					goto case 346;
				case 346:
					array2[13] = (byte)num5;
					num2 = 432;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 57;
				case 461:
					array3[num4 + 7] = array4[7];
					goto case 314;
				case 314:
					num4 = 30;
					num2 = 161;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 460:
					if (CLythVXuCVyvcwvoIf() != 4)
					{
						goto case 71;
					}
					num2 = 3;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto default;
				default:
					num16 = 16;
					goto case 181;
				case 181:
					array3[num16] = array4[0];
					num = 665;
					goto case 665;
				case 459:
					num6 = 93;
					goto case 304;
				case 304:
					array[22] = (byte)num6;
					goto case 230;
				case 230:
					num6 = 93;
					goto case 126;
				case 126:
					array[22] = (byte)num6;
					num2 = 431;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 456:
					array3[num16] = array6[0];
					num2 = 269;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 454:
					num5 = 141;
					num2 = 189;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 399;
				case 399:
					array2[7] = (byte)num5;
					num2 = 220;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 453:
					if (CLythVXuCVyvcwvoIf() == 4)
					{
						goto case 597;
					}
					goto case 29;
				case 29:
					array5 = new byte[12];
					num2 = 160;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 451:
					array[7] = 138;
					goto case 619;
				case 450:
					num3 = 123;
					num2 = 1;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 449:
					num5 = 47;
					goto case 379;
				case 379:
					array2[15] = (byte)num5;
					goto case 290;
				case 290:
					array14 = array2;
					num2 = 497;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 448:
					array2[15] = 155;
					num2 = 430;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 449;
				case 444:
					array5[8] = 46;
					num2 = 608;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 491;
				case 443:
					array5[6] = 105;
					num2 = 96;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 13:
				case 442:
					if (YgBrXGz2eG7nxmLopR(dr4pDGttyGLTDiPG8x(object_)) < PhhLSiUFhVHNR8p4an(dr4pDGttyGLTDiPG8x(object_)) - 1L)
					{
						goto case 131;
					}
					goto case 234;
				case 234:
					intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly))[0]);
					goto case 370;
				case 370:
					KaGK4PkRSg = intPtr2.ToInt64();
					num2 = 453;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 439:
					num15 = array17.Length / 4;
					goto case 299;
				case 299:
					array16 = new byte[array17.Length];
					goto case 186;
				case 186:
					num26 = array12.Length / 4;
					num2 = 297;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 438:
					num35 += 8;
					num2 = 2;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 4;
				case 436:
					array2[10] = (byte)num5;
					goto case 332;
				case 332:
					array2[10] = 155;
					goto case 348;
				case 348:
					array2[10] = 196;
					goto case 422;
				case 422:
					array2[11] = 155;
					num2 = 102;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 49;
				case 49:
				case 79:
					pG2CksPoHx3JrBNyNs(array3, 0, intPtr, array3.Length);
					goto case 221;
				case 221:
					U2rKeSFOox = false;
					goto case 562;
				case 434:
					array[30] = 132;
					goto case 416;
				case 416:
					array[30] = 145;
					num2 = 689;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 432:
					array2[13] = 120;
					goto case 629;
				case 430:
					array[6] = (byte)num3;
					goto case 451;
				case 429:
					array[8] = (byte)num3;
					num2 = 248;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 80;
				case 80:
					array5[4] = 114;
					goto case 82;
				case 82:
					array5[5] = 106;
					num2 = 443;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 425:
					W4GMrI5Mr7iqNE7VQld(R3VW0p5FhD2Kp6vTh4M(BTxDti5Wti80t4gi9wU(TNYKXullJB)));
					goto case 295;
				case 295:
					array18 = null;
					goto case 223;
				case 223:
					if (CLythVXuCVyvcwvoIf() != 4)
					{
						num2 = 612;
						if (w9diKK5g7kam6LVG9j())
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 606;
				case 423:
					array12 = array;
					goto case 281;
				case 421:
					num5 = 175;
					goto case 313;
				case 313:
					array2[7] = (byte)num5;
					goto case 454;
				case 418:
					array[25] = 127;
					goto case 640;
				case 417:
					array5[8] = 108;
					num = 125;
					goto case 125;
				case 125:
					array5[9] = 108;
					num2 = 465;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 410:
					array2[11] = (byte)num14;
					goto case 554;
				case 409:
					array2[6] = 118;
					goto case 402;
				case 402:
					array2[6] = 110;
					goto case 610;
				case 408:
					num34 = 0L;
					goto case 252;
				case 252:
					if (CLythVXuCVyvcwvoIf() == 4)
					{
						goto case 594;
					}
					goto case 549;
				case 405:
					if (CLythVXuCVyvcwvoIf() == 4)
					{
						num = 493;
						goto case 493;
					}
					goto case 226;
				case 226:
					array13 = (byte[])efYF6H5kRI5O9Bw9vhk(w9iKQtMBCF.ToInt64());
					num2 = 694;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 403:
					array2[5] = 155;
					goto case 327;
				case 327:
					array2[5] = 50;
					goto case 409;
				case 401:
					num29 += num19;
					num2 = 545;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 261;
				case 261:
					num6 = 93;
					num = 32;
					goto case 32;
				case 32:
					array[31] = (byte)num6;
					num2 = 338;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 391:
					array[5] = 151;
					num2 = 132;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 390:
					array14[3] = array15[1];
					num2 = 375;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 388:
					array2[9] = 136;
					num2 = 27;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 505;
				case 387:
					num3 = 6;
					num2 = 178;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 384:
					if (CLythVXuCVyvcwvoIf() == 4)
					{
						goto case 506;
					}
					goto case 300;
				case 382:
					array[5] = 42;
					num2 = 14;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 207;
				case 207:
					array[5] = 228;
					num2 = 494;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 182;
				case 375:
					array14[5] = array15[2];
					goto case 584;
				case 374:
					num20 <<= 8;
					goto case 438;
				case 372:
					array12[num31] = (byte)(array12[num31] ^ array14[num31]);
					goto case 310;
				case 310:
					num31++;
					goto case 107;
				case 107:
				case 354:
					if (num31 < array14.Length)
					{
						goto case 372;
					}
					goto case 9;
				case 9:
					array17 = array10;
					goto case 294;
				case 294:
					num32 = array17.Length % 4;
					goto case 439;
				case 371:
					array3[num16 + 2] = array6[2];
					goto case 66;
				case 66:
					array3[num16 + 3] = array6[3];
					goto case 49;
				case 365:
					array[6] = (byte)num6;
					goto case 135;
				case 135:
					num3 = 195;
					goto case 430;
				case 361:
					array[7] = (byte)num3;
					goto case 359;
				case 359:
					num3 = 164;
					num2 = 429;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 358:
					array[10] = (byte)num3;
					goto case 579;
				case 357:
					num6 = 110;
					num2 = 84;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 108;
				case 355:
					array[15] = (byte)num3;
					goto case 646;
				case 347:
					array[10] = (byte)num6;
					goto case 275;
				case 275:
					num3 = 108;
					num2 = 358;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 345:
					num3 = 180;
					goto case 165;
				case 165:
					array[0] = (byte)num3;
					goto case 124;
				case 124:
					num6 = 108;
					goto case 270;
				case 270:
					array[0] = (byte)num6;
					goto case 464;
				case 343:
					array[22] = (byte)num3;
					goto case 172;
				case 172:
					num6 = 52;
					goto case 208;
				case 208:
					array[22] = (byte)num6;
					goto case 459;
				case 342:
					array5[2] = 114;
					goto case 571;
				case 339:
					array[11] = (byte)num6;
					goto case 547;
				case 338:
					array[31] = 43;
					num = 387;
					goto case 387;
				case 331:
					array[5] = (byte)num3;
					goto case 255;
				case 255:
					array[6] = 167;
					goto case 643;
				case 326:
					num3 = 107;
					goto case 693;
				case 201:
				case 324:
					array11 = new byte[6];
					num2 = 200;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 319:
					num30 = num29 ^ num7;
					num2 = 487;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 317:
					array[9] = 102;
					goto case 53;
				case 53:
					num3 = 197;
					goto case 496;
				case 315:
					array[3] = (byte)num3;
					goto case 684;
				case 311:
					num6 = 96;
					goto case 339;
				case 309:
					num19 = 0u;
					goto case 44;
				case 44:
					num7 = 0u;
					goto case 620;
				case 307:
					array[4] = (byte)num3;
					goto case 570;
				case 306:
					array3[num4 + 2] = array6[2];
					num2 = 26;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 55;
				case 55:
					array3[num4 + 3] = array6[3];
					num2 = 271;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 305:
					array2[2] = 183;
					goto case 479;
				case 297:
					num29 = 0u;
					num2 = 309;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 51;
				case 51:
					array[31] = 106;
					goto case 40;
				case 40:
					array[31] = 99;
					num2 = 497;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 590;
				case 287:
					array2[1] = (byte)num14;
					num2 = 2;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto default;
				case 284:
					array3[num4 + 5] = array4[5];
					num2 = 6;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 283:
					num23 = rB6TZEb8JtjnFD4eoI(object_);
					goto case 194;
				case 194:
					bGY4RO1lga(intptr_3, num23 * 4, 4, ref int_2);
					goto case 146;
				case 146:
					num28 = 0;
					goto case 245;
				case 280:
					if (array8.Length == 0)
					{
						num2 = 626;
						if (w9diKK5g7kam6LVG9j())
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 225;
				case 225:
					while (true)
					{
						IL_3fbb:
						fixed (byte* ptr = &array8[0])
						{
							while (true)
							{
								IL_19ab:
								num21 = 0;
								while (num21 < num24)
								{
									while (true)
									{
										IL_17c9:
										num25 = (nint)(ptr + (nint)num21 * (nint)8);
										*(long*)num25 ^= 163080304L;
										num2 = 249;
										if (tQ4VPAqlcsXEPAd5sK() == null)
										{
											goto IL_0025_3;
										}
										goto IL_0b40_2;
										IL_0025_3:
										while (true)
										{
											switch (num2)
											{
											case 474:
												break;
											case 566:
												if (!aEM4TbtNAl)
												{
													goto IL_0013;
												}
												goto case 369;
											case 695:
												array13 = null;
												num2 = 405;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 281;
											case 281:
												array2 = new byte[16];
												num2 = 101;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 694:
												array6 = (byte[])efYF6H5kRI5O9Bw9vhk(zero.ToInt64());
												goto case 118;
											case 118:
												array4 = (byte[])efYF6H5kRI5O9Bw9vhk(num34);
												num2 = 296;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 693:
												array[14] = (byte)num3;
												goto case 498;
											case 498:
												num3 = 94;
												goto case 534;
											case 534:
												array[14] = (byte)num3;
												num2 = 478;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 692:
												num5 = 100;
												goto case 301;
											case 301:
												array2[3] = (byte)num5;
												goto case 673;
											case 673:
												num14 = 103;
												goto case 458;
											case 458:
												array2[3] = (byte)num14;
												goto case 567;
											case 567:
												array2[4] = 92;
												num = 680;
												goto case 680;
											case 680:
												array2[4] = 104;
												goto case 83;
											case 83:
												array2[4] = 116;
												num = 364;
												goto case 364;
											case 364:
												array2[4] = 56;
												num2 = 27;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 691:
												if (num12 == num15 - 1)
												{
													num2 = 299;
													if (tQ4VPAqlcsXEPAd5sK() != null)
													{
														continue;
													}
													goto case 501;
												}
												goto case 688;
											case 501:
												if (num32 > 0)
												{
													num2 = 401;
													if (w9diKK5g7kam6LVG9j())
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 688;
											case 688:
												num18 = (uint)num33;
												goto case 99;
											case 99:
												num29 += num19;
												goto case 657;
											case 657:
												num7 = (uint)((array17[num18 + 3] << 24) | (array17[num18 + 2] << 16) | (array17[num18 + 1] << 8) | array17[num18]);
												goto case 267;
											case 267:
											case 544:
												num29 = num29;
												num2 = 298;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 475;
											case 475:
											{
												num77 = num29;
												uint num78 = num29;
												num78 ^= num78 >> 6;
												num78 += 2747050913u;
												num78 ^= num78 >> 7;
												num78 += 96649441;
												num78 ^= num78 << 21;
												num78 += 2442726594u;
												num78 = 607677248 + num78;
												num29 = num77 + (uint)(double)num78;
												num2 = 137;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 407;
											}
											case 407:
												if (num12 == num15 - 1)
												{
													goto case 130;
												}
												goto case 73;
											case 130:
												if (num32 > 0)
												{
													num2 = 319;
													if (w9diKK5g7kam6LVG9j())
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 73;
											case 73:
												num79 = num29 ^ num7;
												goto case 253;
											case 253:
												array16[num33] = (byte)(num79 & 0xFFu);
												goto case 675;
											case 675:
												array16[num33 + 1] = (byte)((num79 & 0xFF00) >> 8);
												goto case 276;
											case 276:
												array16[num33 + 2] = (byte)((num79 & 0xFF0000) >> 16);
												goto case 519;
											case 519:
												array16[num33 + 3] = (byte)((num79 & 0xFF000000u) >> 24);
												goto case 293;
											case 293:
											case 644:
												num12++;
												num = 334;
												goto case 219;
											case 219:
											case 334:
												if (num12 >= num15)
												{
													goto case 645;
												}
												goto case 625;
											case 645:
												array7 = array16;
												goto case 532;
											case 532:
												num24 = array7.Length / 8;
												num2 = 56;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 625:
												num27 = num12 % num26;
												goto case 440;
											case 440:
												num33 = num12 * 4;
												num2 = 686;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 690:
												try
												{
													while (true)
													{
														IL_0f4e_2:
														if (!lCVgh3QmHr2UmvwLvF(enumerator))
														{
															num73 = 3;
															if (w9diKK5g7kam6LVG9j())
															{
																break;
															}
															goto IL_0ee5_3;
														}
														goto IL_0f20_2;
														IL_0e7c_2:
														if (DI4Y59M24OPH6Zbqh8(GUoZ2FFfJ8HI0ILO7c(MXSmQSm4mGd9evCkID(object_13)), "clrjit.dll"))
														{
															goto IL_0e16_2;
														}
														num73 = 1;
														if (!w9diKK5g7kam6LVG9j())
														{
															goto IL_0e0d_2;
														}
														goto IL_0ee5_3;
														IL_0f20_2:
														object_13 = (ProcessModule)qquo3skueBPJxbdXIW(enumerator);
														num73 = 4;
														if (w9diKK5g7kam6LVG9j())
														{
															goto IL_0e7c_2;
														}
														goto IL_0ee5_3;
														IL_0ee5_3:
														while (true)
														{
															switch (num73)
															{
															case 12:
																break;
															case 10:
																goto end_IL_0ee5_2;
															case 4:
																goto IL_0e4d_2;
															case 5:
																goto IL_0e7c_2;
															case 3:
																goto IL_0e96_2;
															case 8:
																object_14 = new Version(4, 0, 30319, 17921);
																num73 = 0;
																if (tQ4VPAqlcsXEPAd5sK() == null)
																{
																	continue;
																}
																goto default;
															default:
																if (!KqCt95s7vcOvvgaonL(object_15, object_16))
																{
																	goto IL_0f4e_2;
																}
																goto IL_0e96_2;
															case 9:
																goto IL_0f20_2;
															case 1:
															case 7:
															case 11:
																goto IL_0f4e_2;
															case 2:
															case 6:
																goto end_IL_0f4e_2;
															}
															zL34aF4R7Q = true;
															num73 = 2;
															if (tQ4VPAqlcsXEPAd5sK() == null)
															{
																continue;
															}
															goto IL_0e0d_2;
															continue;
															end_IL_0ee5_2:
															break;
														}
														goto IL_0e16_2;
														IL_0e16_2:
														object_15 = new Version(bFHmVZ1if45JHyHbYG(avKtoyEsrEw21eUVpi(object_13)), AoN4UQOwwpys6j9mT3(avKtoyEsrEw21eUVpi(object_13)), RRNh6xrFZTYy0WnPf7(avKtoyEsrEw21eUVpi(object_13)), MOZKV0CNtoeHsTSWSN(avKtoyEsrEw21eUVpi(object_13)));
														goto IL_0e4d_2;
														IL_0e4d_2:
														object_16 = new Version(4, 0, 30319, 17020);
														num73 = 8;
														if (!w9diKK5g7kam6LVG9j())
														{
															goto IL_0e96_2;
														}
														goto IL_0ee5_3;
														IL_0e96_2:
														if (!TrZCFCJqiLuu5UEeoY(object_15, object_14))
														{
															continue;
														}
														num73 = 12;
														if (!w9diKK5g7kam6LVG9j())
														{
															goto IL_0e7c_2;
														}
														goto IL_0ee5_3;
														IL_0e0d_2:
														num73 = num74;
														goto IL_0ee5_3;
														continue;
														end_IL_0f4e_2:
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator as IDisposable;
													num75 = 2;
													if (!w9diKK5g7kam6LVG9j())
													{
														goto IL_0f85_2;
													}
													goto IL_0f9e_3;
													IL_0f9e_3:
													while (true)
													{
														switch (num75)
														{
														case 2:
															if (disposable != null)
															{
																num75 = 1;
																if (tQ4VPAqlcsXEPAd5sK() == null)
																{
																	continue;
																}
																break;
															}
															goto end_IL_0f9e_2;
														case 1:
															YoPIe6GE7tAY6ya3RM(disposable);
															num75 = 0;
															if (!w9diKK5g7kam6LVG9j())
															{
																continue;
															}
															goto end_IL_0f9e_2;
														default:
															goto end_IL_0f9e_2;
														case 0:
															goto end_IL_0f9e_2;
														}
														goto IL_0f85_2;
														continue;
														end_IL_0f9e_2:
														break;
													}
													goto end_IL_0f5c_2;
													IL_0f85_2:
													num75 = num76;
													goto IL_0f9e_3;
													end_IL_0f5c_2:;
												}
												goto case 71;
											case 71:
											case 321:
												object_ = new WpWSp8jcj2DZFKf0eg((Stream)u0fUSm61LREN8CWoMQ(mN74oSlkhV, "mQt7DRf8hGD4FIE4dr.6lwmQoIuH1QK8IIKQJ"));
												goto case 154;
											case 154:
												Ft6eRFAB9TGlPxu5CN(dr4pDGttyGLTDiPG8x(object_), 0L);
												num2 = 169;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 689:
												num3 = 149;
												goto case 615;
											case 615:
												array[30] = (byte)num3;
												goto case 81;
											case 81:
												array[30] = 134;
												num2 = 94;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 480;
											case 480:
												num3 = 144;
												num2 = 112;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 687:
												if (CLythVXuCVyvcwvoIf() != 4)
												{
													goto case 145;
												}
												goto case 218;
											case 145:
												aNB47Ca6Ue(zero2, intPtr3, (byte[])tHGsZI7flKsjPMwDHx(rB6TZEb8JtjnFD4eoI(object_)), 4u, out intptr_2);
												num = 362;
												goto case 62;
											case 62:
											case 362:
												bGY4RO1lga(intPtr3, 4, int_2, ref int_2);
												goto case 211;
											case 211:
												num58++;
												goto case 104;
											case 239:
												intPtr3 = new IntPtr(Gct4PJtVDZ + rB6TZEb8JtjnFD4eoI(object_) - num36);
												goto case 286;
											case 286:
												bGY4RO1lga(intPtr3, 4, 4, ref int_2);
												num2 = 212;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 687;
											case 104:
											case 426:
												if (num58 < num37)
												{
													goto case 239;
												}
												num2 = 165;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 24;
											case 218:
												aNB47Ca6Ue(zero2, intPtr3, (byte[])tHGsZI7flKsjPMwDHx(rB6TZEb8JtjnFD4eoI(object_)), 4u, out intptr_2);
												num2 = 62;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 24:
											case 654:
												if (YgBrXGz2eG7nxmLopR(dr4pDGttyGLTDiPG8x(object_)) < PhhLSiUFhVHNR8p4an(dr4pDGttyGLTDiPG8x(object_)) - 1L)
												{
													num2 = 39;
													if (tQ4VPAqlcsXEPAd5sK() == null)
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 616;
											case 616:
												USQxQy55Nx0SOj84KiJ(zero2);
												num2 = 530;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 686:
												num18 = (uint)(num27 * 4);
												num2 = 217;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 199;
											case 199:
											case 638:
												if (num13 >= num32)
												{
													num = 267;
													goto case 267;
												}
												goto case 262;
											case 262:
												if (num13 > 0)
												{
													num2 = 31;
													if (tQ4VPAqlcsXEPAd5sK() == null)
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 8;
											case 8:
												num7 |= array17[^(1 + num13)];
												num2 = 67;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 685:
												array2[0] = 75;
												goto case 237;
											case 237:
												array2[1] = 49;
												goto case 368;
											case 368:
												array2[1] = 136;
												num = 20;
												goto case 20;
											case 20:
												array2[1] = 132;
												goto case 672;
											case 672:
												num5 = 138;
												goto case 577;
											case 577:
												array2[1] = (byte)num5;
												num = 537;
												goto case 537;
											case 537:
												num14 = 249;
												num2 = 287;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 133;
											case 133:
												array3[num4 + 3] = array4[3];
												num2 = 179;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 50;
											case 50:
												array[27] = (byte)num3;
												goto case 288;
											case 288:
												array[27] = 128;
												goto case 264;
											case 264:
												num3 = 106;
												goto case 666;
											case 666:
												array[27] = (byte)num3;
												goto case 190;
											case 190:
												num6 = 70;
												goto case 17;
											case 17:
												array[27] = (byte)num6;
												num2 = 95;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 684:
												array[4] = 92;
												num = 216;
												goto case 216;
											case 216:
												array[4] = 180;
												num2 = 37;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 683:
												array5[5] = 116;
												num = 634;
												goto case 634;
											case 634:
												array5[6] = 46;
												num2 = 38;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 682:
												gmsKVnQ4m = false;
												num = 233;
												goto case 233;
											case 233:
												if (num22 >= 1879048192)
												{
													goto case 86;
												}
												goto case 551;
											case 86:
												gmsKVnQ4m = true;
												goto case 551;
											case 551:
												int_3 = rB6TZEb8JtjnFD4eoI(object_);
												num2 = 468;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 681:
												array[23] = 128;
												num = 177;
												goto case 177;
											case 177:
												array[23] = 169;
												goto case 106;
											case 106:
												num3 = 106;
												goto case 182;
											case 182:
												array[23] = (byte)num3;
												num = 242;
												goto case 242;
											case 242:
												num6 = 20;
												goto case 175;
											case 175:
												array[23] = (byte)num6;
												num2 = 509;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 679:
												array[20] = 210;
												num2 = 518;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 500;
											case 500:
												num5 = 25;
												goto case 377;
											case 377:
												array2[13] = (byte)num5;
												goto case 292;
											case 292:
												array2[14] = 122;
												goto case 435;
											case 435:
												array2[14] = 123;
												goto case 653;
											case 653:
												num5 = 133;
												goto case 349;
											case 349:
												array2[14] = (byte)num5;
												goto case 231;
											case 231:
												array2[14] = 110;
												num = 517;
												goto case 517;
											case 517:
												num14 = 241;
												num = 323;
												goto case 323;
											case 323:
												array2[14] = (byte)num14;
												num = 400;
												goto case 400;
											case 400:
												num14 = 93;
												num2 = 173;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 98;
											case 98:
												array[9] = 227;
												goto case 540;
											case 540:
												num6 = 134;
												goto case 153;
											case 153:
												array[10] = (byte)num6;
												goto case 318;
											case 318:
												array[10] = 135;
												num2 = 550;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 678:
												array[1] = 93;
												num = 383;
												goto case 383;
											case 383:
												array[1] = 84;
												goto case 660;
											case 660:
												array[1] = 152;
												goto case 134;
											case 134:
												num6 = 98;
												num2 = 255;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 322;
											case 322:
												array[2] = (byte)num6;
												goto case 609;
											case 609:
												array[2] = 124;
												goto case 353;
											case 353:
												array[2] = 129;
												num2 = 623;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 677:
												num16 = 9;
												num2 = 45;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 404;
											case 404:
												array3[num16] = array13[0];
												num2 = 489;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 676:
												try
												{
													ProcessModuleCollection object_11 = (ProcessModuleCollection)iEXT8Gp3Y3HIllX7SI(object_6);
													num66 = 1;
													if (tQ4VPAqlcsXEPAd5sK() != null)
													{
														goto IL_159d_2;
													}
													goto IL_15a1_3;
													IL_15a1_3:
													while (true)
													{
														switch (num66)
														{
														case 1:
															break;
														default:
															try
															{
																while (lCVgh3QmHr2UmvwLvF(enumerator))
																{
																	while (true)
																	{
																		IL_1600_2:
																		ProcessModule object_12 = (ProcessModule)qquo3skueBPJxbdXIW(enumerator);
																		while (true)
																		{
																			IL_15f5_2:
																			intPtr2 = NxQs2Ziwq4ui1TgYFd(object_12);
																			while (intPtr2.ToInt64() == KaGK4PkRSg)
																			{
																				num67 = 1;
																				if (tQ4VPAqlcsXEPAd5sK() == null)
																				{
																					switch (num67)
																					{
																					case 6:
																						break;
																					case 3:
																						goto IL_15f5_2;
																					case 2:
																						goto IL_1600_2;
																					default:
																						goto end_IL_15e5_2;
																					case 1:
																						goto IL_161c_2;
																					case 4:
																					case 5:
																						goto end_IL_1610_2;
																					}
																					continue;
																				}
																				goto IL_161c_2;
																				IL_161c_2:
																				num36 = 0;
																				goto end_IL_1610_2;
																				continue;
																				end_IL_15e5_2:
																				break;
																			}
																			break;
																		}
																		break;
																	}
																	continue;
																	end_IL_1610_2:
																	break;
																}
															}
															finally
															{
																IDisposable disposable = enumerator as IDisposable;
																while (disposable != null)
																{
																	num68 = 1;
																	if (!w9diKK5g7kam6LVG9j())
																	{
																		goto IL_164f_2;
																	}
																	goto IL_1653_3;
																	IL_164f_2:
																	num68 = num69;
																	goto IL_1653_3;
																	IL_1653_3:
																	while (true)
																	{
																		switch (num68)
																		{
																		case 1:
																			goto IL_163b_2;
																		default:
																			goto end_IL_1653_2;
																		case 2:
																			break;
																		case 0:
																			goto end_IL_1653_2;
																		}
																		goto IL_1666_2;
																		IL_163b_2:
																		YoPIe6GE7tAY6ya3RM(disposable);
																		num68 = 0;
																		if (tQ4VPAqlcsXEPAd5sK() == null)
																		{
																			continue;
																		}
																		goto IL_164f_2;
																		continue;
																		end_IL_1653_2:
																		break;
																	}
																	break;
																	IL_1666_2:;
																}
															}
															goto end_IL_15a1_2;
														case 2:
															goto end_IL_15a1_2;
														}
														enumerator = (IEnumerator)uSF7tk4PoUdsFmDJNX(object_11);
														num66 = 0;
														if (w9diKK5g7kam6LVG9j())
														{
															continue;
														}
														goto IL_159d_2;
														continue;
														end_IL_15a1_2:
														break;
													}
													goto end_IL_156f_2;
													IL_159d_2:
													num66 = num70;
													goto IL_15a1_3;
													end_IL_156f_2:;
												}
												catch (object obj6)
												{
													num71 = 0;
													if (!w9diKK5g7kam6LVG9j())
													{
														num71 = num72;
													}
													switch (num71)
													{
													}
												}
												goto case 378;
											case 378:
												uMu4z0CoEH = null;
												num2 = 637;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 277;
											case 277:
												array[13] = (byte)num3;
												goto case 129;
											case 129:
												array[14] = 181;
												goto case 291;
											case 291:
												num3 = 55;
												num2 = 536;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 674:
												num3 = 128;
												num2 = 526;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 671:
												array3[num4 + 1] = array4[1];
												goto case 335;
											case 335:
												array3[num4 + 2] = array4[2];
												goto case 133;
											case 631:
											case 670:
												if (num17 >= num32)
												{
													goto case 293;
												}
												goto case 243;
											case 243:
												if (num17 > 0)
												{
													num2 = 374;
													if (w9diKK5g7kam6LVG9j())
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 4;
											case 4:
												array16[num33 + num17] = (byte)((num30 & num20) >> num35);
												num2 = 191;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 669:
												array6 = null;
												num = 68;
												goto case 68;
											case 68:
												array4 = null;
												num2 = 695;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 668:
												array2[0] = 106;
												num2 = 685;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 108;
											case 108:
												array[15] = (byte)num6;
												goto case 121;
											case 121:
												num3 = 150;
												num2 = 587;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 667:
												goto IL_17c9;
											case 665:
												array3[num16 + 1] = array4[1];
												num2 = 523;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 447;
											case 447:
												array[21] = 117;
												goto case 467;
											case 467:
												array[21] = 138;
												goto case 143;
											case 143:
												array[21] = 76;
												num2 = 77;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 664:
												array[3] = 84;
												goto case 649;
											case 649:
												array[3] = 157;
												num = 117;
												goto case 117;
											case 117:
												num3 = 54;
												num2 = 315;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 663:
												array[29] = 120;
												goto case 373;
											case 373:
												array[29] = 123;
												goto case 419;
											case 419:
												num6 = 155;
												goto case 463;
											case 463:
												array[29] = (byte)num6;
												num2 = 434;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 662:
												num12 = 0;
												goto case 219;
											case 661:
												array[9] = 125;
												num2 = 317;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 127;
											case 127:
												array2[10] = (byte)num5;
												num2 = 22;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 659:
												num5 = 114;
												num2 = 92;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 658:
												array[12] = 73;
												goto case 196;
											case 196:
												num6 = 40;
												goto case 168;
											case 168:
												array[13] = (byte)num6;
												num2 = 277;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 329;
											case 329:
												num6 = 134;
												goto case 445;
											case 445:
												array[13] = (byte)num6;
												goto case 25;
											case 25:
												array[13] = 128;
												num = 202;
												goto case 202;
											case 202:
												num3 = 21;
												num2 = 277;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 260:
											case 656:
												goto IL_19ab;
											case 344:
											case 466:
												goto IL_19ae;
											case 333:
												object_ = new WpWSp8jcj2DZFKf0eg(new MemoryStream(array7));
												goto case 244;
											case 244:
												Ft6eRFAB9TGlPxu5CN(dr4pDGttyGLTDiPG8x(object_), 0L);
												num = 351;
												goto case 351;
											case 351:
												intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(mN74oSlkhV))[0]);
												num = 312;
												goto case 312;
											case 312:
												num39 = intPtr2.ToInt64();
												goto case 188;
											case 188:
												int_2 = 0;
												goto case 503;
											case 503:
												num36 = 0;
												num = 589;
												goto case 589;
											case 589:
												if (VCJ6SLfCTMIknVulEp(mN74oSlkhV) == null)
												{
													goto case 91;
												}
												goto case 164;
											case 91:
											case 367:
												num36 = 7680;
												goto case 16;
											case 164:
												if (YGjPhdabah83SpyRCl(VCJ6SLfCTMIknVulEp(mN74oSlkhV)) == 0)
												{
													num2 = 91;
													if (w9diKK5g7kam6LVG9j())
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 16;
											case 16:
												num37 = rB6TZEb8JtjnFD4eoI(object_);
												num2 = 557;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 655:
												object_10 = (WIZ8WE02qlCAiCa8dc)OX7VDP5j28MEqxsyl4j(procAddress, FOHnOE5SnEatDcLXNlx(typeof(WIZ8WE02qlCAiCa8dc).TypeHandle));
												goto case 428;
											case 428:
												intptr_5 = gvNNRW5vK33LLMxfH0O(object_10);
												goto case 78;
											case 78:
												value = 0L;
												goto case 524;
											case 524:
												if (CLythVXuCVyvcwvoIf() == 4)
												{
													num = 241;
													goto case 241;
												}
												goto case 42;
											case 241:
												value = Gqe6GG5Pe46WyVApDX7(intptr_5);
												goto case 486;
											case 42:
												value = vwBCrx5ZU5AJtCFp2kB(intptr_5);
												num2 = 4;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 486;
											case 486:
											case 514:
												npQnGPS2svNOvmFlOU(intptr_5, 0);
												goto case 330;
											case 330:
												TNYKXullJB = new lCvkUik0j3csWuLBtF(rob4kGNJXO);
												num2 = 87;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 652:
												Gct4PJtVDZ = intPtr2.ToInt64();
												num2 = 163;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 651:
												array2[6] = (byte)num5;
												goto case 376;
											case 376:
												num14 = 77;
												num2 = 482;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 650:
												array14[11] = array15[5];
												goto case 320;
											case 320:
												array14[13] = array15[6];
												num2 = 279;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 131;
											case 131:
												num40 = rB6TZEb8JtjnFD4eoI(object_) - num36;
												num2 = 254;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 648:
												array[18] = (byte)num6;
												goto case 34;
											case 34:
												array[18] = 38;
												goto case 57;
											case 57:
												array[18] = 203;
												num2 = 23;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 646:
												array[15] = 155;
												goto case 398;
											case 398:
												num6 = 92;
												goto case 228;
											case 228:
												array[15] = (byte)num6;
												num2 = 450;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 392;
											case 392:
												memoryStream = new MemoryStream();
												num2 = 227;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 68;
											case 643:
												array[6] = 133;
												goto case 155;
											case 155:
												num6 = 189;
												num = 7;
												goto case 7;
											case 7:
												array[6] = (byte)num6;
												num = 215;
												goto case 215;
											case 215:
												num6 = 162;
												num2 = 365;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 642:
												num6 = 147;
												num = 158;
												goto case 158;
											case 158:
												array[18] = (byte)num6;
												goto case 64;
											case 64:
												array[18] = 108;
												goto case 535;
											case 535:
												num6 = 128;
												num2 = 648;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 640:
												array[25] = 42;
												goto case 363;
											case 363:
												array[25] = 96;
												num = 12;
												goto case 12;
											case 12:
												num3 = 70;
												goto case 170;
											case 170:
												array[26] = (byte)num3;
												goto case 385;
											case 385:
												array[26] = 127;
												goto case 397;
											case 397:
												array[26] = 155;
												num2 = 115;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 639:
												array3[num4] = array4[0];
												goto case 671;
											case 637:
												try
												{
													uMu4z0CoEH = (lCvkUik0j3csWuLBtF)OX7VDP5j28MEqxsyl4j(new IntPtr(num34), FOHnOE5SnEatDcLXNlx(typeof(lCvkUik0j3csWuLBtF).TypeHandle));
													num59 = 0;
													if (!w9diKK5g7kam6LVG9j())
													{
														switch (num59)
														{
														}
													}
												}
												catch (object obj5)
												{
													num60 = 1;
													if (!w9diKK5g7kam6LVG9j())
													{
														num60 = num61;
													}
													switch (num60)
													{
													case 1:
														try
														{
															Delegate object_9 = (Delegate)OX7VDP5j28MEqxsyl4j(new IntPtr(num34), FOHnOE5SnEatDcLXNlx(typeof(lCvkUik0j3csWuLBtF).TypeHandle));
															num62 = 0;
															if (tQ4VPAqlcsXEPAd5sK() != null)
															{
																goto IL_1de9_2;
															}
															goto IL_1ded_3;
															IL_1ded_3:
															while (true)
															{
																switch (num62)
																{
																case 1:
																	goto end_IL_1ded_2;
																}
																uMu4z0CoEH = (lCvkUik0j3csWuLBtF)flxcrP5lVfXvv0lfwG8(FOHnOE5SnEatDcLXNlx(typeof(lCvkUik0j3csWuLBtF).TypeHandle), BTxDti5Wti80t4gi9wU(object_9));
																num62 = 1;
																if (w9diKK5g7kam6LVG9j())
																{
																	continue;
																}
																goto IL_1de9_2;
																continue;
																end_IL_1ded_2:
																break;
															}
															goto end_IL_1d95_2;
															IL_1de9_2:
															num62 = num63;
															goto IL_1ded_3;
															end_IL_1d95_2:;
														}
														catch (object obj4)
														{
															num64 = 0;
															if (tQ4VPAqlcsXEPAd5sK() != null)
															{
																num64 = num65;
															}
															switch (num64)
															{
															default:
																goto end_IL_1dfe_2;
															}
															end_IL_1dfe_2:;
														}
														break;
													case 0:
														break;
													}
												}
												goto case 212;
											case 212:
												num2 = 543;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 636:
												array[1] = (byte)num6;
												goto case 678;
											case 635:
												IoAGuMgKWO3tKKbFRf(object_2);
												goto case 604;
											case 604:
												cGeZFQ0u3NNh3Bxmgc(object_);
												num2 = 546;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 633:
												num58 = 0;
												goto case 104;
											case 632:
												array[19] = (byte)num3;
												goto case 266;
											case 266:
												num3 = 1;
												goto case 147;
											case 147:
												array[19] = (byte)num3;
												num2 = 512;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 630:
												array[19] = (byte)num3;
												num = 574;
												goto case 574;
											case 574:
												num3 = 124;
												num2 = 632;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 629:
												num14 = 112;
												num2 = 492;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 628:
												array3[num4 + 6] = array6[6];
												num2 = 43;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 627:
												G6mMDw59E9QervP9nC1(new IntPtr(intptr_3.ToInt64() + num28 * 4), rB6TZEb8JtjnFD4eoI(object_));
												goto case 395;
											case 395:
												num28++;
												goto case 245;
											case 245:
											case 585:
												if (num28 < num23)
												{
													goto case 627;
												}
												num2 = 265;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 176;
											case 176:
												array[24] = (byte)num6;
												goto case 528;
											case 528:
												num3 = 115;
												goto case 564;
											case 564:
												array[24] = (byte)num3;
												num2 = 18;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 7;
											case 626:
												goto end_IL_3fbb;
											case 624:
												num6 = 103;
												num2 = 347;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 623:
												num3 = 101;
												goto case 128;
											case 128:
												array[2] = (byte)num3;
												goto case 15;
											case 15:
												num6 = 188;
												num2 = 171;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 622:
												num3 = 139;
												num2 = 355;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 114;
											case 114:
												array[26] = 136;
												num2 = 185;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 470:
											case 621:
												object_6 = (Process)yPcscORqInLIO1Lmn8();
												goto case 552;
											case 552:
												try
												{
													ProcessModuleCollection object_7 = (ProcessModuleCollection)iEXT8Gp3Y3HIllX7SI(object_6);
													num48 = 2;
													if (tQ4VPAqlcsXEPAd5sK() != null)
													{
														num48 = num49;
													}
													while (true)
													{
														switch (num48)
														{
														case 2:
															goto IL_204b_2;
														default:
															goto end_IL_2060_2;
														case 1:
															break;
														case 0:
															goto end_IL_2060_2;
														}
														goto IL_2077_2;
														IL_204b_2:
														enumerator = (IEnumerator)uSF7tk4PoUdsFmDJNX(object_7);
														num48 = 1;
														if (tQ4VPAqlcsXEPAd5sK() == null)
														{
															continue;
														}
														goto IL_2077_2;
														IL_2077_2:
														try
														{
															while (lCVgh3QmHr2UmvwLvF(enumerator))
															{
																while (true)
																{
																	ProcessModule object_8 = (ProcessModule)qquo3skueBPJxbdXIW(enumerator);
																	num50 = 0;
																	if (tQ4VPAqlcsXEPAd5sK() != null)
																	{
																		num50 = num51;
																	}
																	while (true)
																	{
																		switch (num50)
																		{
																		case 8:
																			num53 = num34;
																			intPtr2 = NxQs2Ziwq4ui1TgYFd(object_8);
																			if (num53 <= intPtr2.ToInt64() + kwVo6g5eCiKcnQiuiPm(object_8))
																			{
																				goto end_IL_2133_2;
																			}
																			goto case 3;
																		case 3:
																			if (!pGdYqW53Glk7uDdyY3i(OeqDXT5i5g8O6rrXhdw(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly), null))
																			{
																				goto end_IL_2133_2;
																			}
																			goto case 6;
																		case 6:
																			xGKrYIlYDeuaXoT8kx();
																			num50 = 1;
																			if (!w9diKK5g7kam6LVG9j())
																			{
																				continue;
																			}
																			return;
																		case 1:
																			num52 = num34;
																			intPtr2 = NxQs2Ziwq4ui1TgYFd(object_8);
																			if (num52 >= intPtr2.ToInt64())
																			{
																				goto case 8;
																			}
																			goto case 3;
																		default:
																			if (!DI4Y59M24OPH6Zbqh8(MXSmQSm4mGd9evCkID(object_8), text))
																			{
																				goto end_IL_2133_2;
																			}
																			num50 = 1;
																			if (tQ4VPAqlcsXEPAd5sK() != null)
																			{
																				continue;
																			}
																			goto case 1;
																		case 4:
																			break;
																		case 2:
																			goto end_IL_2133_2;
																		case 7:
																			goto end_IL_2154_2;
																		case 5:
																			return;
																		}
																		break;
																	}
																	continue;
																	end_IL_2133_2:
																	break;
																}
																continue;
																end_IL_2154_2:
																break;
															}
														}
														finally
														{
															IDisposable disposable = enumerator as IDisposable;
															while (true)
															{
																if (disposable != null)
																{
																	goto IL_2170_2;
																}
																num54 = 0;
																if (!w9diKK5g7kam6LVG9j())
																{
																	num54 = num55;
																}
																goto IL_2183_2;
																IL_2170_2:
																YoPIe6GE7tAY6ya3RM(disposable);
																num54 = 0;
																if (tQ4VPAqlcsXEPAd5sK() == null)
																{
																	break;
																}
																goto IL_2183_2;
																IL_2183_2:
																switch (num54)
																{
																case 3:
																	break;
																default:
																	goto end_IL_21ad_2;
																case 2:
																	continue;
																case 0:
																case 1:
																	goto end_IL_21ad_2;
																}
																goto IL_2170_2;
																continue;
																end_IL_21ad_2:
																break;
															}
														}
														break;
														continue;
														end_IL_2060_2:
														break;
													}
												}
												catch (object obj3)
												{
													num56 = 0;
													if (!w9diKK5g7kam6LVG9j())
													{
														num56 = num57;
													}
													switch (num56)
													{
													}
												}
												goto case 676;
											case 620:
												if (num32 > 0)
												{
													goto case 581;
												}
												goto case 539;
											case 581:
												num15++;
												goto case 539;
											case 539:
												num18 = 0u;
												goto case 662;
											case 619:
												num3 = 95;
												num = 48;
												goto case 48;
											case 48:
												array[7] = (byte)num3;
												num2 = 258;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 618:
												array[20] = (byte)num3;
												num = 268;
												goto case 268;
											case 268:
												array[21] = 123;
												goto case 350;
											case 350:
												array[21] = 128;
												num = 447;
												goto case 447;
											case 617:
												array5 = new byte[10];
												goto case 166;
											case 166:
												array5[0] = 99;
												goto case 282;
											case 282:
												array5[1] = 108;
												num2 = 342;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 614:
												num3 = 90;
												goto case 84;
											case 84:
												array[3] = (byte)num3;
												num2 = 274;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 236;
											case 236:
												object_5 = (SymmetricAlgorithm)YpJDdU2rahwaaJMFTW();
												goto case 598;
											case 598:
												EvFgX4N5cctbNxeBcv(object_5, CipherMode.CBC);
												num = 60;
												goto case 60;
											case 60:
												transform = (ICryptoTransform)a7ybunhOLsC0sMnidC(object_5, array12, array14);
												goto case 573;
											case 573:
												RCsMwvDuucQMnoycto(array12, 0, array12.Length);
												goto case 392;
											case 613:
												array2[12] = 144;
												goto case 490;
											case 490:
												array2[12] = 87;
												goto case 103;
											case 103:
												array2[12] = 159;
												goto case 197;
											case 197:
												num5 = 97;
												goto case 580;
											case 580:
												array2[12] = (byte)num5;
												goto case 285;
											case 285:
												array2[12] = 159;
												goto case 206;
											case 206:
												num14 = 203;
												num2 = 395;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 556;
											case 556:
												array2[12] = (byte)num14;
												goto case 240;
											case 240:
												num14 = 159;
												num2 = 462;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 97;
											case 97:
												array2[0] = 94;
												goto case 472;
											case 472:
												array2[0] = 148;
												goto case 70;
											case 70:
												array2[0] = 126;
												num2 = 244;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 668;
											case 612:
												array22 = new byte[40];
												dvmjCf5Ewwp4k6wEH3A(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
												array18 = array22;
												goto case 412;
											case 412:
											case 424:
												intPtr = r3cMyC51YhZBD3hmxXG(IntPtr.Zero, (uint)array18.Length, 4096u, 64u);
												num2 = 168;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 224;
											case 224:
												array3 = array18;
												goto case 669;
											case 296:
											case 611:
												if (CLythVXuCVyvcwvoIf() == 4)
												{
													goto case 677;
												}
												goto case 504;
											case 504:
												num4 = 2;
												goto case 289;
											case 289:
												array3[num4] = array13[0];
												goto case 525;
											case 525:
												array3[num4 + 1] = array13[1];
												goto case 558;
											case 558:
												array3[num4 + 2] = array13[2];
												num2 = 469;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 610:
												array2[6] = 107;
												goto case 414;
											case 414:
												num5 = 170;
												num = 651;
												goto case 651;
											case 608:
												array5[9] = 100;
												num2 = 11;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 607:
												if (pGdYqW53Glk7uDdyY3i(OeqDXT5i5g8O6rrXhdw(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly), null))
												{
													num2 = 48;
													if (tQ4VPAqlcsXEPAd5sK() != null)
													{
														continue;
													}
													goto case 578;
												}
												goto case 61;
											case 578:
												if (((Array)IieZUX5XCJBll5vBpVv(OeqDXT5i5g8O6rrXhdw(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly))).Length == 2)
												{
													goto case 437;
												}
												goto case 61;
											case 437:
												if (VCJ6SLfCTMIknVulEp(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly) != null)
												{
													goto case 340;
												}
												goto case 61;
											case 340:
												if (YGjPhdabah83SpyRCl(VCJ6SLfCTMIknVulEp(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly)) <= 0)
												{
													goto case 61;
												}
												goto case 140;
											case 61:
											case 366:
												try
												{
													object obj = vHyr6t54Xj0WcFO9EpV(WpRwjt5p72lVMVHEEi9(CgngFc5KpOehZOe1uPS(W5VyKM5xHBGOLyIVURB(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), CgngFc5KpOehZOe1uPS(W5VyKM5xHBGOLyIVURB(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly)));
													num41 = 1;
													if (tQ4VPAqlcsXEPAd5sK() != null)
													{
														goto IL_256e_2;
													}
													goto IL_26e1_3;
													IL_26e1_3:
													while (true)
													{
														switch (num41)
														{
														case 16:
															nativeSizeOfCode = 0u;
															num41 = 0;
															if (tQ4VPAqlcsXEPAd5sK() == null)
															{
																continue;
															}
															break;
														case 15:
															IoAGuMgKWO3tKKbFRf(object_4);
															goto case 16;
														case 14:
															w9iKQtMBCF = (IntPtr)vHyr6t54Xj0WcFO9EpV(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
															goto case 7;
														case 7:
															object_4 = new MemoryStream();
															num41 = 3;
															if (tQ4VPAqlcsXEPAd5sK() == null)
															{
																continue;
															}
															goto case 3;
														case 3:
															pfyBOaoei6ELVKY9G8(object_4, new byte[CLythVXuCVyvcwvoIf()], 0, CLythVXuCVyvcwvoIf());
															num41 = 2;
															if (tQ4VPAqlcsXEPAd5sK() != null)
															{
																continue;
															}
															goto case 9;
														case 9:
															if (CLythVXuCVyvcwvoIf() == 4)
															{
																goto case 12;
															}
															goto case 4;
														case 12:
															pfyBOaoei6ELVKY9G8(object_4, tHGsZI7flKsjPMwDHx(w9iKQtMBCF.ToInt32()), 0, 4);
															goto case 8;
														case 4:
															pfyBOaoei6ELVKY9G8(object_4, efYF6H5kRI5O9Bw9vhk(w9iKQtMBCF.ToInt64()), 0, 8);
															goto case 8;
														case 8:
														case 13:
															pfyBOaoei6ELVKY9G8(object_4, new byte[CLythVXuCVyvcwvoIf()], 0, CLythVXuCVyvcwvoIf());
															goto case 2;
														case 2:
															pfyBOaoei6ELVKY9G8(object_4, new byte[CLythVXuCVyvcwvoIf()], 0, CLythVXuCVyvcwvoIf());
															num41 = 6;
															if (w9diKK5g7kam6LVG9j())
															{
																continue;
															}
															break;
														case 11:
															if (DI4Y59M24OPH6Zbqh8(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
															{
																num46 = 14;
																goto case 14;
															}
															goto case 7;
														case 10:
															array20 = (byte[])bdrgWJwirStTW6kwl8(object_4);
															goto case 15;
														case 6:
															Ft6eRFAB9TGlPxu5CN(object_4, 0L);
															goto case 10;
														case 5:
															w9iKQtMBCF = (IntPtr)obj;
															num41 = 11;
															if (tQ4VPAqlcsXEPAd5sK() == null)
															{
																continue;
															}
															break;
														case 1:
															if (obj is IntPtr)
															{
																num41 = 5;
																if (w9diKK5g7kam6LVG9j())
																{
																	continue;
																}
																break;
															}
															goto case 11;
														default:
															try
															{
																array21 = (array8 = array20);
																if (array21 != null)
																{
																	goto IL_2782_2;
																}
																goto IL_27b4_2;
																IL_27b4_2:
																reference2 = ref *(byte*)null;
																num42 = 0;
																if (tQ4VPAqlcsXEPAd5sK() != null)
																{
																	num42 = num43;
																}
																goto IL_2794_4;
																IL_2738_3:
																while (true)
																{
																	IL_2738_4:
																	fixed (byte* value2 = &array8[0])
																	{
																		while (true)
																		{
																			IL_2742_2:
																			TNYKXullJB(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
																			num42 = 0;
																			if (tQ4VPAqlcsXEPAd5sK() == null)
																			{
																				break;
																			}
																			while (true)
																			{
																				switch (num42)
																				{
																				case 5:
																					goto end_IL_2794_2;
																				case 3:
																					if (array8.Length != 0)
																					{
																						goto end_IL_2794_2;
																					}
																					goto IL_2788_2;
																				case 2:
																					goto end_IL_2738_2;
																				case 1:
																					goto end_IL_2742_2;
																				}
																				goto IL_2742_2;
																				IL_2788_2:
																				num42 = 0;
																				if (w9diKK5g7kam6LVG9j())
																				{
																					goto end_IL_2738_2;
																				}
																				continue;
																				end_IL_2794_2:
																				break;
																			}
																			goto IL_2738_4;
																			continue;
																			end_IL_2742_2:
																			break;
																		}
																	}
																	goto end_IL_272f_2;
																	continue;
																	end_IL_2738_2:
																	break;
																}
																goto IL_27b4_2;
																IL_2794_4:
																while (true)
																{
																	switch (num42)
																	{
																	case 5:
																		break;
																	default:
																		TNYKXullJB(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
																		num42 = 0;
																		if (tQ4VPAqlcsXEPAd5sK() != null)
																		{
																			continue;
																		}
																		goto end_IL_272f_2;
																	case 3:
																		goto IL_2782_2;
																	case 2:
																		goto IL_27b4_2;
																	case 1:
																		goto end_IL_272f_2;
																	}
																	break;
																}
																goto IL_2738_3;
																IL_2782_2:
																if (array8.Length != 0)
																{
																	goto IL_2738_3;
																}
																num42 = 0;
																if (!w9diKK5g7kam6LVG9j())
																{
																	goto IL_2794_4;
																}
																goto IL_27b4_2;
																end_IL_272f_2:;
															}
															finally
															{
																reference2 = ref *(byte*)null;
																num44 = 0;
																if (!w9diKK5g7kam6LVG9j())
																{
																	num44 = num45;
																}
																switch (num44)
																{
																}
															}
															goto end_IL_26e1_2;
														case 17:
															goto end_IL_26e1_2;
														}
														goto IL_256e_2;
														continue;
														end_IL_26e1_2:
														break;
													}
													goto end_IL_24f5_2;
													IL_256e_2:
													num41 = num46;
													goto IL_26e1_3;
													end_IL_24f5_2:;
												}
												catch (object obj2)
												{
													num47 = 0;
													if (!w9diKK5g7kam6LVG9j())
													{
														switch (num47)
														{
														}
													}
												}
												goto case 174;
											case 174:
												yfkAgH5mbrQs5MnqkoA(uMu4z0CoEH);
												goto case 538;
											case 538:
												W4GMrI5Mr7iqNE7VQld(R3VW0p5FhD2Kp6vTh4M(BTxDti5Wti80t4gi9wU(uMu4z0CoEH)));
												goto case 420;
											case 420:
												yfkAgH5mbrQs5MnqkoA(TNYKXullJB);
												num2 = 425;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 606:
												array19 = new byte[30];
												dvmjCf5Ewwp4k6wEH3A(array19, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
												array18 = array19;
												num = 424;
												goto case 412;
											case 605:
												bGY4RO1lga(intptr_4, 4, 4, ref int_2);
												goto case 476;
											case 476:
												G6mMDw59E9QervP9nC1(intptr_4, rB6TZEb8JtjnFD4eoI(object_));
												num2 = 28;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 515;
											case 515:
												bGY4RO1lga(intptr_4, 4, int_2, ref int_2);
												goto case 484;
											case 484:
												num38++;
												goto case 150;
											case 72:
												intptr_4 = new IntPtr(num39 + rB6TZEb8JtjnFD4eoI(object_) - num36);
												num = 605;
												goto case 605;
											case 150:
											case 214:
												if (num38 < num37)
												{
													goto case 72;
												}
												goto case 481;
											case 481:
												JYvKLCsA8k = new Hashtable(rB6TZEb8JtjnFD4eoI(object_) + 1);
												goto case 316;
											case 316:
												bZYeaHi8qu2JN9K2Ig2 = default(bZYeaHi8qu2JN9K2Ig);
												num = 19;
												goto case 19;
											case 19:
												reference = ref bZYeaHi8qu2JN9K2Ig2;
												array8 = new byte[1] { 42 };
												reference.I6SKfYay1R = array8;
												goto case 105;
											case 105:
												bZYeaHi8qu2JN9K2Ig2.gmsKVnQ4m9 = false;
												num2 = 48;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 193;
											case 193:
												omQ0sO5qpL1i6TbPW3B(JYvKLCsA8k, 0L, bZYeaHi8qu2JN9K2Ig2);
												num2 = 180;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 603:
												array7 = (byte[])bdrgWJwirStTW6kwl8(memoryStream);
												num2 = 575;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 602:
												num14 = 56;
												goto case 452;
											case 452:
												array2[9] = (byte)num14;
												goto case 336;
											case 336:
												num5 = 20;
												goto case 127;
											case 601:
												array3[num16 + 3] = array13[3];
												num2 = 0;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 600:
												array11[3] = 74;
												goto case 162;
											case 162:
												array11[4] = 105;
												num2 = 257;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 60;
											case 599:
												num5 = 128;
												goto case 250;
											case 250:
												array2[5] = (byte)num5;
												num2 = 403;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 597:
												JIVKKia87p = rVWXyA5nqemDX5Dj2ge(KaGK4PkRSg);
												num2 = 29;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 596:
												pfyBOaoei6ELVKY9G8(object_2, array10, 0, array10.Length);
												goto case 483;
											case 483:
												qmK6ssyVv2RtSC2moB(object_2);
												goto case 603;
											case 595:
												tFudfYnbyHHnulHgAP(new IntPtr(&num10), 0);
												goto case 308;
											case 308:
												Olcn0lLZfqJQ3ckOre(new IntPtr(&num10), 0);
												num2 = 53;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 495;
											case 495:
												EK2KKsV2QueGKgfHEj(new IntPtr(&num10), 0, IntPtr.Zero);
												goto case 151;
											case 151:
												IWJMh085cGT4JTi28O(new IntPtr(&num10), 0, 0);
												goto case 513;
											case 513:
												HOurykjS5Rw0mXWySR(new IntPtr(&num10), 0, 0L);
												goto case 394;
											case 394:
												array8 = new byte[1];
												goto case 380;
											case 380:
												pG2CksPoHx3JrBNyNs(array8, 0, SSUk9AvAPLg9XQGXSZ(8), 1);
												goto case 69;
											case 69:
												KEW15jZMvpDJUcDHjh();
												num2 = 35;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 594:
												num34 = Gqe6GG5Pe46WyVApDX7(new IntPtr(value));
												goto case 470;
											case 593:
												num6 = 157;
												num = 389;
												goto case 389;
											case 389:
												array[20] = (byte)num6;
												num = 541;
												goto case 541;
											case 541:
												num6 = 207;
												goto case 406;
											case 406:
												array[20] = (byte)num6;
												goto case 679;
											case 592:
												num35 = 0;
												goto case 691;
											case 591:
												array[24] = (byte)num6;
												num2 = 138;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 590:
												num6 = 69;
												num2 = 139;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 588:
												array[12] = 106;
												goto case 457;
											case 457:
												array[12] = 158;
												num2 = 273;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 587:
												array[15] = (byte)num3;
												num2 = 75;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 586:
												num6 = 114;
												goto case 59;
											case 59:
												array[1] = (byte)num6;
												num2 = 235;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 584:
												array14[7] = array15[3];
												goto case 94;
											case 94:
												array14[9] = array15[4];
												goto case 650;
											case 583:
												bZYeaHi8qu2JN9K2Ig.I6SKfYay1R = i6SKfYay1R;
												num = 113;
												goto case 113;
											case 113:
												bZYeaHi8qu2JN9K2Ig.gmsKVnQ4m9 = gmsKVnQ4m;
												num = 303;
												goto case 303;
											case 303:
												omQ0sO5qpL1i6TbPW3B(JYvKLCsA8k, num39 + num40, bZYeaHi8qu2JN9K2Ig);
												num2 = 442;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 70;
											case 582:
												num3 = 84;
												num = 396;
												goto case 396;
											case 396:
												array[18] = (byte)num3;
												num = 642;
												goto case 642;
											case 579:
												num3 = 216;
												num2 = 32;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 111;
											case 111:
												array[10] = (byte)num3;
												num2 = 311;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 576:
												array5[4] = 105;
												num2 = 75;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 683;
											case 575:
												RCsMwvDuucQMnoycto(array14, 0, array14.Length);
												goto case 26;
											case 26:
												IoAGuMgKWO3tKKbFRf(memoryStream);
												num2 = 635;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 572:
												zero2 = IntPtr.Zero;
												goto case 341;
											case 341:
												uint_ = (K8R1q578nEBETPsLFo)56;
												num = 352;
												goto case 352;
											case 352:
												zero2 = reinHNYeyu6nKm2drq((uint)uint_, 1, (uint)xUfLwTH5W4vy9l5V5x(yPcscORqInLIO1Lmn8()));
												num2 = 384;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 571:
												array5[3] = 106;
												num = 576;
												goto case 576;
											case 570:
												num3 = 98;
												goto case 446;
											case 446:
												array[4] = (byte)num3;
												num2 = 382;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 569:
												array[27] = (byte)num3;
												num = 298;
												goto case 298;
											case 298:
												num3 = 96;
												num = 50;
												goto case 50;
											case 568:
												array2[5] = (byte)num5;
												num = 599;
												goto case 599;
											case 565:
												aEM4TbtNAl = true;
												goto case 477;
											case 477:
												num8 = 4059231220u;
												num2 = 46;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 563:
												array[17] = (byte)num3;
												goto case 502;
											case 502:
												array[17] = 43;
												num = 582;
												goto case 582;
											case 562:
												bGY4RO1lga(new IntPtr(value), CLythVXuCVyvcwvoIf(), 64, ref int_);
												num2 = 641;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 431;
											case 431:
												array[22] = 166;
												num = 681;
												goto case 681;
											case 561:
												array[0] = 140;
												goto case 455;
											case 455:
												array[0] = 101;
												goto case 21;
											case 21:
												array[1] = 110;
												num = 586;
												goto case 586;
											case 560:
												array6 = (byte[])tHGsZI7flKsjPMwDHx(zero.ToInt32());
												goto case 63;
											case 63:
												array4 = (byte[])tHGsZI7flKsjPMwDHx(rVWXyA5nqemDX5Dj2ge(num34));
												num2 = 611;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 559:
												array2[9] = (byte)num14;
												goto case 393;
											case 393:
												num5 = 99;
												num2 = 14;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 557:
												num11 = rB6TZEb8JtjnFD4eoI(object_);
												num2 = 54;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 555:
												array[11] = (byte)num3;
												goto case 588;
											case 554:
												array2[11] = 100;
												goto case 93;
											case 93:
												num5 = 40;
												goto case 28;
											case 28:
												array2[11] = (byte)num5;
												goto case 413;
											case 413:
												num5 = 96;
												num2 = 74;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 3;
											case 3:
												if (!hYk438KXIo8IVV5oJU(QEKXwaxjNKv9wrBywY("System.Reflection.ReflectionContext", bool_0: false), null))
												{
													goto case 71;
												}
												goto case 251;
											case 251:
												object_3 = (ProcessModuleCollection)iEXT8Gp3Y3HIllX7SI(yPcscORqInLIO1Lmn8());
												goto case 516;
											case 516:
												enumerator = (IEnumerator)uSF7tk4PoUdsFmDJNX(object_3);
												num2 = 690;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 553:
												procAddress = GetProcAddress(intptr_, string_);
												num2 = 655;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 550:
												array[10] = 161;
												num2 = 624;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 549:
												num34 = vwBCrx5ZU5AJtCFp2kB(new IntPtr(value));
												num2 = 621;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 548:
												num3 = 132;
												goto case 386;
											case 386:
												array[17] = (byte)num3;
												goto case 256;
											case 256:
												num3 = 97;
												goto case 563;
											case 547:
												num6 = 57;
												goto case 232;
											case 232:
												array[11] = (byte)num6;
												goto case 204;
											case 204:
												num3 = 101;
												num2 = 268;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 555;
											case 546:
												num37 = rB6TZEb8JtjnFD4eoI(object_);
												num = 441;
												goto case 441;
											case 441:
												num11 = rB6TZEb8JtjnFD4eoI(object_);
												goto case 100;
											case 100:
												if (num11 == 1)
												{
													goto case 572;
												}
												num38 = 0;
												num = 214;
												goto case 150;
											case 545:
												num7 = 0u;
												num2 = 508;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 543:
												int_ = 0;
												num2 = 607;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 542:
												array[9] = (byte)num6;
												goto case 85;
											case 85:
												array[9] = 125;
												goto case 98;
											case 536:
												array[14] = (byte)num3;
												goto case 272;
											case 272:
												array[14] = 114;
												num2 = 326;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 533:
												array2[7] = (byte)num14;
												goto case 152;
											case 152:
												array2[7] = 160;
												num2 = 421;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 531:
												num14 = 120;
												goto case 533;
											case 530:
												xGKrYIlYDeuaXoT8kx();
												num2 = 415;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 529:
												array[16] = (byte)num6;
												num2 = 187;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 527:
												array3[num4 + 6] = array13[6];
												goto case 520;
											case 520:
												array3[num4 + 7] = array13[7];
												num2 = 229;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 526:
												array[26] = (byte)num3;
												num2 = 114;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 523:
												array3[num16 + 2] = array4[2];
												num2 = 246;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 522:
												num14 = 217;
												goto case 559;
											case 521:
												intptr_3 = new IntPtr(Gct4PJtVDZ + num9 - num36);
												num2 = 283;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 282;
											case 518:
												num3 = 45;
												goto case 618;
											case 512:
												array[20] = 102;
												goto case 593;
											case 511:
												array[8] = (byte)num3;
												num = 488;
												goto case 488;
											case 488:
												num3 = 142;
												goto case 52;
											case 52:
												array[8] = (byte)num3;
												goto case 144;
											case 144:
												num3 = 94;
												goto case 159;
											case 159:
												array[8] = (byte)num3;
												goto case 661;
											case 510:
												flag = Ef43VRWJhqrbixH4B5(zWh6VK3ZGslTgW3h1t(NxQs2Ziwq4ui1TgYFd(qgbvhje4AFv3fZX9Sq(yPcscORqInLIO1Lmn8())), "__", 10u), IntPtr.Zero);
												goto case 356;
											case 356:
												if (flag)
												{
													num2 = 460;
													if (tQ4VPAqlcsXEPAd5sK() == null)
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 337;
											case 509:
												array[24] = 125;
												goto case 183;
											case 183:
												array[24] = 187;
												goto case 192;
											case 192:
												num6 = 181;
												goto case 176;
											case 508:
												num13 = 0;
												num2 = 638;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 527;
											case 507:
												array5[1] = 115;
												num2 = 189;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 506:
												intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(mN74oSlkhV))[0]);
												goto case 89;
											case 89:
												GPj4GGybN5 = intPtr2.ToInt32();
												goto case 300;
											case 300:
												intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(mN74oSlkhV))[0]);
												goto case 652;
											case 505:
												array2[9] = 108;
												num = 602;
												goto case 602;
											case 499:
												array2[8] = 106;
												num2 = 491;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 497:
												dAnLMSTENbDtTIuBc2(array14);
												num2 = 105;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 120;
											case 120:
												array15 = (byte[])w1aJonIdBddf8Z1bSs(Ee7jsadQGQKLKaXayU(mN74oSlkhV));
												goto case 195;
											case 195:
												if (array15 != null)
												{
													goto case 88;
												}
												num = 142;
												goto case 65;
											case 88:
												if (array15.Length > 0)
												{
													goto case 302;
												}
												goto case 65;
											case 302:
												array14[1] = array15[0];
												num2 = 390;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 65:
											case 142:
												num31 = 0;
												num2 = 354;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 496:
												array[9] = (byte)num3;
												num2 = 45;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 198;
											case 198:
												num6 = 168;
												goto case 542;
											case 494:
												array[5] = 126;
												goto case 90;
											case 90:
												num6 = 104;
												num2 = 203;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 196;
											case 493:
												array13 = (byte[])tHGsZI7flKsjPMwDHx(w9iKQtMBCF.ToInt32());
												goto case 560;
											case 492:
												array2[13] = (byte)num14;
												num2 = 431;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 500;
											case 491:
												array2[8] = 132;
												num2 = 123;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 328;
											case 328:
												array2[8] = 99;
												goto case 123;
											case 123:
												array2[9] = 113;
												goto case 522;
											case 489:
												array3[num16 + 1] = array13[1];
												num2 = 238;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 487:
												num17 = 0;
												goto case 631;
											case 485:
												array = new byte[32];
												num2 = 345;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 482:
												array2[7] = (byte)num14;
												goto case 531;
											case 479:
												num14 = 131;
												goto case 5;
											case 5:
												array2[2] = (byte)num14;
												goto case 471;
											case 471:
												array2[2] = 216;
												goto case 259;
											case 259:
												array2[3] = 144;
												goto case 692;
											case 478:
												array[14] = 119;
												num2 = 357;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 473:
												RCsMwvDuucQMnoycto(array15, 0, array15.Length);
												goto case 65;
											case 469:
												array3[num4 + 3] = array13[3];
												goto case 411;
											case 411:
												array3[num4 + 4] = array13[4];
												goto case 360;
											case 360:
												array3[num4 + 5] = array13[5];
												goto case 527;
											case 468:
												i6SKfYay1R = (byte[])VfdItgc5swn1llGhOe(object_, int_3);
												goto case 222;
											case 222:
												bZYeaHi8qu2JN9K2Ig = default(bZYeaHi8qu2JN9K2Ig);
												num2 = 583;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 548;
											case 465:
												text = (string)gqt83k5V0ywMxaWpTRi(uMCLWl5L0R5bIeYbTFc(), array5);
												num2 = 263;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 464:
												array[0] = 113;
												goto case 433;
											case 433:
												num3 = 155;
												goto case 47;
											case 47:
												array[0] = (byte)num3;
												num2 = 561;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 462:
												array2[13] = (byte)num14;
												goto case 427;
											case 427:
												num5 = 122;
												num = 346;
												goto case 346;
											case 346:
												array2[13] = (byte)num5;
												num2 = 432;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 57;
											case 461:
												array3[num4 + 7] = array4[7];
												goto case 314;
											case 314:
												num4 = 30;
												num2 = 161;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 460:
												if (CLythVXuCVyvcwvoIf() != 4)
												{
													goto case 71;
												}
												num2 = 3;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto default;
											default:
												num16 = 16;
												goto case 181;
											case 181:
												array3[num16] = array4[0];
												num = 665;
												goto case 665;
											case 459:
												num6 = 93;
												goto case 304;
											case 304:
												array[22] = (byte)num6;
												goto case 230;
											case 230:
												num6 = 93;
												goto case 126;
											case 126:
												array[22] = (byte)num6;
												num2 = 431;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 456:
												array3[num16] = array6[0];
												num2 = 269;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 454:
												num5 = 141;
												num2 = 189;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 399;
											case 399:
												array2[7] = (byte)num5;
												num2 = 220;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 453:
												if (CLythVXuCVyvcwvoIf() == 4)
												{
													goto case 597;
												}
												goto case 29;
											case 29:
												array5 = new byte[12];
												num2 = 160;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 451:
												array[7] = 138;
												goto case 619;
											case 450:
												num3 = 123;
												num2 = 1;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 449:
												num5 = 47;
												goto case 379;
											case 379:
												array2[15] = (byte)num5;
												goto case 290;
											case 290:
												array14 = array2;
												num2 = 497;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 448:
												array2[15] = 155;
												num2 = 430;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 449;
											case 444:
												array5[8] = 46;
												num2 = 608;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 491;
											case 443:
												array5[6] = 105;
												num2 = 96;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 13:
											case 442:
												if (YgBrXGz2eG7nxmLopR(dr4pDGttyGLTDiPG8x(object_)) < PhhLSiUFhVHNR8p4an(dr4pDGttyGLTDiPG8x(object_)) - 1L)
												{
													goto case 131;
												}
												goto case 234;
											case 234:
												intPtr2 = y0fdisuEk31FMxPpsI(((object[])Fq97IiBdPdAuDI5TQM(FOHnOE5SnEatDcLXNlx(typeof(uGoIvNQFsJ3OnGY78d).TypeHandle).Assembly))[0]);
												goto case 370;
											case 370:
												KaGK4PkRSg = intPtr2.ToInt64();
												num2 = 453;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 439:
												num15 = array17.Length / 4;
												goto case 299;
											case 299:
												array16 = new byte[array17.Length];
												goto case 186;
											case 186:
												num26 = array12.Length / 4;
												num2 = 297;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 438:
												num35 += 8;
												num2 = 2;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 4;
											case 436:
												array2[10] = (byte)num5;
												goto case 332;
											case 332:
												array2[10] = 155;
												goto case 348;
											case 348:
												array2[10] = 196;
												goto case 422;
											case 422:
												array2[11] = 155;
												num2 = 102;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 49;
											case 49:
											case 79:
												pG2CksPoHx3JrBNyNs(array3, 0, intPtr, array3.Length);
												goto case 221;
											case 221:
												U2rKeSFOox = false;
												goto case 562;
											case 434:
												array[30] = 132;
												goto case 416;
											case 416:
												array[30] = 145;
												num2 = 689;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 432:
												array2[13] = 120;
												goto case 629;
											case 430:
												array[6] = (byte)num3;
												goto case 451;
											case 429:
												array[8] = (byte)num3;
												num2 = 248;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 80;
											case 80:
												array5[4] = 114;
												goto case 82;
											case 82:
												array5[5] = 106;
												num2 = 443;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 425:
												W4GMrI5Mr7iqNE7VQld(R3VW0p5FhD2Kp6vTh4M(BTxDti5Wti80t4gi9wU(TNYKXullJB)));
												goto case 295;
											case 295:
												array18 = null;
												goto case 223;
											case 223:
												if (CLythVXuCVyvcwvoIf() != 4)
												{
													num2 = 612;
													if (w9diKK5g7kam6LVG9j())
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 606;
											case 423:
												array12 = array;
												goto case 281;
											case 421:
												num5 = 175;
												goto case 313;
											case 313:
												array2[7] = (byte)num5;
												goto case 454;
											case 418:
												array[25] = 127;
												goto case 640;
											case 417:
												array5[8] = 108;
												num = 125;
												goto case 125;
											case 125:
												array5[9] = 108;
												num2 = 465;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 410:
												array2[11] = (byte)num14;
												goto case 554;
											case 409:
												array2[6] = 118;
												goto case 402;
											case 402:
												array2[6] = 110;
												goto case 610;
											case 408:
												num34 = 0L;
												goto case 252;
											case 252:
												if (CLythVXuCVyvcwvoIf() == 4)
												{
													goto case 594;
												}
												goto case 549;
											case 405:
												if (CLythVXuCVyvcwvoIf() == 4)
												{
													num = 493;
													goto case 493;
												}
												goto case 226;
											case 226:
												array13 = (byte[])efYF6H5kRI5O9Bw9vhk(w9iKQtMBCF.ToInt64());
												num2 = 694;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 403:
												array2[5] = 155;
												goto case 327;
											case 327:
												array2[5] = 50;
												goto case 409;
											case 401:
												num29 += num19;
												num2 = 545;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 261;
											case 261:
												num6 = 93;
												num = 32;
												goto case 32;
											case 32:
												array[31] = (byte)num6;
												num2 = 338;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 391:
												array[5] = 151;
												num2 = 132;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 390:
												array14[3] = array15[1];
												num2 = 375;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 388:
												array2[9] = 136;
												num2 = 27;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 505;
											case 387:
												num3 = 6;
												num2 = 178;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 384:
												if (CLythVXuCVyvcwvoIf() == 4)
												{
													goto case 506;
												}
												goto case 300;
											case 382:
												array[5] = 42;
												num2 = 14;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 207;
											case 207:
												array[5] = 228;
												num2 = 494;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 182;
											case 375:
												array14[5] = array15[2];
												goto case 584;
											case 374:
												num20 <<= 8;
												goto case 438;
											case 372:
												array12[num31] = (byte)(array12[num31] ^ array14[num31]);
												goto case 310;
											case 310:
												num31++;
												goto case 107;
											case 107:
											case 354:
												if (num31 < array14.Length)
												{
													goto case 372;
												}
												goto case 9;
											case 9:
												array17 = array10;
												goto case 294;
											case 294:
												num32 = array17.Length % 4;
												goto case 439;
											case 371:
												array3[num16 + 2] = array6[2];
												goto case 66;
											case 66:
												array3[num16 + 3] = array6[3];
												goto case 49;
											case 365:
												array[6] = (byte)num6;
												goto case 135;
											case 135:
												num3 = 195;
												goto case 430;
											case 361:
												array[7] = (byte)num3;
												goto case 359;
											case 359:
												num3 = 164;
												num2 = 429;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 358:
												array[10] = (byte)num3;
												goto case 579;
											case 357:
												num6 = 110;
												num2 = 84;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 108;
											case 355:
												array[15] = (byte)num3;
												goto case 646;
											case 347:
												array[10] = (byte)num6;
												goto case 275;
											case 275:
												num3 = 108;
												num2 = 358;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 345:
												num3 = 180;
												goto case 165;
											case 165:
												array[0] = (byte)num3;
												goto case 124;
											case 124:
												num6 = 108;
												goto case 270;
											case 270:
												array[0] = (byte)num6;
												goto case 464;
											case 343:
												array[22] = (byte)num3;
												goto case 172;
											case 172:
												num6 = 52;
												goto case 208;
											case 208:
												array[22] = (byte)num6;
												goto case 459;
											case 342:
												array5[2] = 114;
												goto case 571;
											case 339:
												array[11] = (byte)num6;
												goto case 547;
											case 338:
												array[31] = 43;
												num = 387;
												goto case 387;
											case 331:
												array[5] = (byte)num3;
												goto case 255;
											case 255:
												array[6] = 167;
												goto case 643;
											case 326:
												num3 = 107;
												goto case 693;
											case 201:
											case 324:
												array11 = new byte[6];
												num2 = 200;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 319:
												num30 = num29 ^ num7;
												num2 = 487;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 317:
												array[9] = 102;
												goto case 53;
											case 53:
												num3 = 197;
												goto case 496;
											case 315:
												array[3] = (byte)num3;
												goto case 684;
											case 311:
												num6 = 96;
												goto case 339;
											case 309:
												num19 = 0u;
												goto case 44;
											case 44:
												num7 = 0u;
												goto case 620;
											case 307:
												array[4] = (byte)num3;
												goto case 570;
											case 306:
												array3[num4 + 2] = array6[2];
												num2 = 26;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 55;
											case 55:
												array3[num4 + 3] = array6[3];
												num2 = 271;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 305:
												array2[2] = 183;
												goto case 479;
											case 297:
												num29 = 0u;
												num2 = 309;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 51;
											case 51:
												array[31] = 106;
												goto case 40;
											case 40:
												array[31] = 99;
												num2 = 497;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 590;
											case 287:
												array2[1] = (byte)num14;
												num2 = 2;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto default;
											case 284:
												array3[num4 + 5] = array4[5];
												num2 = 6;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 283:
												num23 = rB6TZEb8JtjnFD4eoI(object_);
												goto case 194;
											case 194:
												bGY4RO1lga(intptr_3, num23 * 4, 4, ref int_2);
												goto case 146;
											case 146:
												num28 = 0;
												goto case 245;
											case 280:
												if (array8.Length != 0)
												{
													goto IL_3fbb;
												}
												num2 = 626;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 225:
												goto IL_3fbb;
											case 279:
												array14[15] = array15[7];
												goto case 473;
											case 278:
												array3[num4 + 1] = array6[1];
												goto case 306;
											case 274:
												array[3] = 84;
												goto case 664;
											case 273:
												num3 = 95;
												num2 = 122;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 271:
												array3[num4 + 4] = array6[4];
												num2 = 41;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 24;
											case 269:
												array3[num16 + 1] = array6[1];
												goto case 371;
											case 265:
												bGY4RO1lga(intptr_3, num23 * 4, int_2, ref int_2);
												goto case 24;
											case 263:
												intptr_ = LoadLibrary(text);
												num2 = 324;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 258:
												num3 = 105;
												num2 = 361;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 257:
												array11[5] = 116;
												goto case 184;
											case 184:
												string_ = (string)gqt83k5V0ywMxaWpTRi(uMCLWl5L0R5bIeYbTFc(), array11);
												num2 = 553;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 207;
											case 254:
												num22 = rB6TZEb8JtjnFD4eoI(object_);
												num2 = 34;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 682;
											case 249:
												num21++;
												num2 = 40;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto IL_19ae;
											case 248:
												num3 = 128;
												goto case 511;
											case 247:
												array[28] = (byte)num3;
												goto case 209;
											case 209:
												array[28] = 111;
												num2 = 205;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 246:
												array3[num16 + 3] = array4[3];
												num2 = 167;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 238:
												array3[num16 + 2] = array13[2];
												goto case 601;
											case 235:
												num6 = 170;
												goto case 636;
											case 229:
												num4 = 18;
												num2 = 639;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 410;
											case 227:
												object_2 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
												num2 = 596;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 220:
												array2[8] = 151;
												num2 = 57;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 499;
											case 217:
												num19 = (uint)((array12[num18 + 3] << 24) | (array12[num18 + 2] << 16) | (array12[num18 + 1] << 8) | array12[num18]);
												num2 = 40;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 156;
											case 156:
												num20 = 255u;
												goto case 592;
											case 210:
												array11[2] = 116;
												num2 = 578;
												if (tQ4VPAqlcsXEPAd5sK() != null)
												{
													continue;
												}
												goto case 600;
											case 205:
												array[28] = 113;
												num = 36;
												goto case 36;
											case 36:
												num6 = 85;
												goto case 109;
											case 109:
												array[29] = (byte)num6;
												goto case 663;
											case 203:
												array[5] = (byte)num6;
												goto case 391;
											case 200:
												array11[0] = 103;
												goto case 33;
											case 33:
												array11[1] = 101;
												num2 = 210;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 180;
											case 180:
												gmsKVnQ4m = false;
												num2 = 13;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 13;
											case 191:
												num17++;
												num2 = 670;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 189:
												array5[2] = 99;
												num2 = 76;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 187:
												array[16] = 208;
												goto case 58;
											case 58:
												array[16] = 90;
												goto case 548;
											case 185:
												num3 = 134;
												num = 569;
												goto case 569;
											case 179:
												array3[num4 + 4] = array4[4];
												goto case 284;
											case 178:
												array[31] = (byte)num3;
												goto case 423;
											case 173:
												array2[15] = (byte)num14;
												num2 = 114;
												if (!w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto case 448;
											case 171:
												array[3] = (byte)num6;
												num2 = 614;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 169:
												array10 = (byte[])VfdItgc5swn1llGhOe(object_, (int)PhhLSiUFhVHNR8p4an(dr4pDGttyGLTDiPG8x(object_)));
												num2 = 485;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 167:
												num16 = 23;
												goto case 456;
											case 163:
												intptr_2 = IntPtr.Zero;
												goto case 633;
											case 161:
												array3[num4] = array6[0];
												goto case 278;
											case 160:
												array5[0] = 109;
												num2 = 507;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 157:
												if (!t83lAh58HndV6DmbQcw(intptr_, IntPtr.Zero))
												{
													num2 = 201;
													if (tQ4VPAqlcsXEPAd5sK() == null)
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 617;
											case 149:
												array[12] = (byte)num3;
												num2 = 658;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 148:
												zero = xx2Vf65RdYDRyKj5C5x(TNYKXullJB);
												goto case 408;
											case 141:
												array5[11] = 108;
												goto case 136;
											case 136:
												text = (string)gqt83k5V0ywMxaWpTRi(uMCLWl5L0R5bIeYbTFc(), array5);
												goto case 116;
											case 116:
												intptr_ = LoadLibrary(text);
												goto case 157;
											case 139:
												array[31] = (byte)num6;
												num2 = 261;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 138:
												array[24] = 35;
												num = 418;
												goto case 418;
											case 137:
												array[26] = (byte)num3;
												goto case 674;
											case 132:
												num3 = 203;
												goto case 331;
											case 122:
												array[12] = (byte)num3;
												num2 = 110;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 119:
												num3 = 141;
												goto case 343;
											case 115:
												num3 = 9;
												goto case 137;
											case 112:
												array[30] = (byte)num3;
												num2 = 51;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 110:
												num3 = 116;
												num2 = 149;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 65;
											case 102:
												num14 = 198;
												goto case 410;
											case 101:
												array2[0] = 182;
												num = 97;
												goto case 97;
											case 96:
												array5[7] = 116;
												num2 = 444;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 95:
												num3 = 153;
												goto case 247;
											case 92:
												array2[11] = (byte)num5;
												num = 613;
												goto case 613;
											case 87:
												zero = IntPtr.Zero;
												num = 148;
												goto case 148;
											case 77:
												array[22] = 100;
												num2 = 119;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 76:
												array5[3] = 111;
												num2 = 80;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 75:
												array[15] = 119;
												goto case 622;
											case 74:
												array2[11] = (byte)num5;
												goto case 659;
											case 67:
												num13++;
												goto case 199;
											case 56:
												array9 = (array8 = array7);
												if (array9 == null)
												{
													goto end_IL_3fbb;
												}
												goto case 280;
											case 54:
												if (num11 == 4)
												{
													num2 = 236;
													if (tQ4VPAqlcsXEPAd5sK() == null)
													{
														continue;
													}
													goto IL_0b40_2;
												}
												goto case 100;
											case 46:
												num10 = 0L;
												goto case 45;
											case 45:
												npQnGPS2svNOvmFlOU(new IntPtr(&num10), 0);
												num2 = 595;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 43:
												array3[num4 + 7] = array6[7];
												goto case 49;
											case 41:
												array3[num4 + 5] = array6[5];
												num2 = 628;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 39:
												num9 = rB6TZEb8JtjnFD4eoI(object_);
												num2 = 521;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 38:
												array5[7] = 100;
												goto case 417;
											case 37:
												num3 = 118;
												num2 = 307;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 35:
												if (num8 == 4109628145u)
												{
													goto case 510;
												}
												goto case 460;
											case 31:
												num7 <<= 8;
												num2 = 8;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 30:
												num6 = 111;
												num = 529;
												goto case 529;
											case 27:
												num5 = 66;
												num2 = 568;
												if (w9diKK5g7kam6LVG9j())
												{
													continue;
												}
												goto IL_0b40_2;
											case 23:
												num3 = 123;
												num2 = 630;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 22:
												num5 = 101;
												goto case 436;
											case 18:
												num6 = 115;
												goto case 591;
											case 14:
												array2[9] = (byte)num5;
												goto case 388;
											case 11:
												array5[10] = 108;
												goto case 141;
											case 10:
												array[16] = 69;
												goto case 30;
											case 6:
												array3[num4 + 6] = array4[6];
												goto case 461;
											case 2:
												array2[2] = 232;
												num2 = 305;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto case 14;
											case 1:
												array[16] = (byte)num3;
												num2 = 10;
												if (tQ4VPAqlcsXEPAd5sK() == null)
												{
													continue;
												}
												goto IL_0b40_2;
											case 415:
												return;
											case 337:
												xGKrYIlYDeuaXoT8kx();
												return;
											case 325:
												return;
											case 140:
												xGKrYIlYDeuaXoT8kx();
												return;
											case 213:
												return;
											case 641:
												CCWKxI5OU8Ve7YneVM9(new IntPtr(value), intPtr);
												goto case 647;
											case 647:
												bGY4RO1lga(new IntPtr(value), CLythVXuCVyvcwvoIf(), int_, ref int_);
												goto case 369;
											case 369:
												xGKrYIlYDeuaXoT8kx();
												return;
											case 381:
												return;
											}
											break;
											IL_0013:
											num2 = 565;
											if (tQ4VPAqlcsXEPAd5sK() == null)
											{
												continue;
											}
											goto IL_0b40_2;
										}
										break;
										IL_0b40_2:
										num2 = num;
										goto IL_0025_3;
									}
									break;
									IL_19ae:;
								}
								break;
							}
						}
						goto case 474;
						continue;
						end_IL_3fbb:
						break;
					}
					goto case 626;
				case 279:
					array14[15] = array15[7];
					goto case 473;
				case 278:
					array3[num4 + 1] = array6[1];
					goto case 306;
				case 274:
					array[3] = 84;
					goto case 664;
				case 273:
					num3 = 95;
					num2 = 122;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 271:
					array3[num4 + 4] = array6[4];
					num2 = 41;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 24;
				case 269:
					array3[num16 + 1] = array6[1];
					goto case 371;
				case 265:
					bGY4RO1lga(intptr_3, num23 * 4, int_2, ref int_2);
					goto case 24;
				case 263:
					intptr_ = LoadLibrary(text);
					num2 = 324;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 258:
					num3 = 105;
					num2 = 361;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 257:
					array11[5] = 116;
					goto case 184;
				case 184:
					string_ = (string)gqt83k5V0ywMxaWpTRi(uMCLWl5L0R5bIeYbTFc(), array11);
					num2 = 553;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 207;
				case 254:
					num22 = rB6TZEb8JtjnFD4eoI(object_);
					num2 = 34;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 682;
				case 249:
					num21++;
					num2 = 40;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 344;
				case 248:
					num3 = 128;
					goto case 511;
				case 247:
					array[28] = (byte)num3;
					goto case 209;
				case 209:
					array[28] = 111;
					num2 = 205;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 246:
					array3[num16 + 3] = array4[3];
					num2 = 167;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 238:
					array3[num16 + 2] = array13[2];
					goto case 601;
				case 235:
					num6 = 170;
					goto case 636;
				case 229:
					num4 = 18;
					num2 = 639;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 410;
				case 227:
					object_2 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					num2 = 596;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 220:
					array2[8] = 151;
					num2 = 57;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 499;
				case 217:
					num19 = (uint)((array12[num18 + 3] << 24) | (array12[num18 + 2] << 16) | (array12[num18 + 1] << 8) | array12[num18]);
					num2 = 40;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 156;
				case 156:
					num20 = 255u;
					goto case 592;
				case 210:
					array11[2] = 116;
					num2 = 578;
					if (tQ4VPAqlcsXEPAd5sK() != null)
					{
						continue;
					}
					goto case 600;
				case 205:
					array[28] = 113;
					num = 36;
					goto case 36;
				case 36:
					num6 = 85;
					goto case 109;
				case 109:
					array[29] = (byte)num6;
					goto case 663;
				case 203:
					array[5] = (byte)num6;
					goto case 391;
				case 200:
					array11[0] = 103;
					goto case 33;
				case 33:
					array11[1] = 101;
					num2 = 210;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 180;
				case 180:
					gmsKVnQ4m = false;
					num2 = 13;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 13;
				case 191:
					num17++;
					num2 = 670;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 189:
					array5[2] = 99;
					num2 = 76;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 187:
					array[16] = 208;
					goto case 58;
				case 58:
					array[16] = 90;
					goto case 548;
				case 185:
					num3 = 134;
					num = 569;
					goto case 569;
				case 179:
					array3[num4 + 4] = array4[4];
					goto case 284;
				case 178:
					array[31] = (byte)num3;
					goto case 423;
				case 173:
					array2[15] = (byte)num14;
					num2 = 114;
					if (!w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto case 448;
				case 171:
					array[3] = (byte)num6;
					num2 = 614;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 169:
					array10 = (byte[])VfdItgc5swn1llGhOe(object_, (int)PhhLSiUFhVHNR8p4an(dr4pDGttyGLTDiPG8x(object_)));
					num2 = 485;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 167:
					num16 = 23;
					goto case 456;
				case 163:
					intptr_2 = IntPtr.Zero;
					goto case 633;
				case 161:
					array3[num4] = array6[0];
					goto case 278;
				case 160:
					array5[0] = 109;
					num2 = 507;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 157:
					if (!t83lAh58HndV6DmbQcw(intptr_, IntPtr.Zero))
					{
						num2 = 201;
						if (tQ4VPAqlcsXEPAd5sK() == null)
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 617;
				case 149:
					array[12] = (byte)num3;
					num2 = 658;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 148:
					zero = xx2Vf65RdYDRyKj5C5x(TNYKXullJB);
					goto case 408;
				case 141:
					array5[11] = 108;
					goto case 136;
				case 136:
					text = (string)gqt83k5V0ywMxaWpTRi(uMCLWl5L0R5bIeYbTFc(), array5);
					goto case 116;
				case 116:
					intptr_ = LoadLibrary(text);
					goto case 157;
				case 139:
					array[31] = (byte)num6;
					num2 = 261;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 138:
					array[24] = 35;
					num = 418;
					goto case 418;
				case 137:
					array[26] = (byte)num3;
					goto case 674;
				case 132:
					num3 = 203;
					goto case 331;
				case 122:
					array[12] = (byte)num3;
					num2 = 110;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 119:
					num3 = 141;
					goto case 343;
				case 115:
					num3 = 9;
					goto case 137;
				case 112:
					array[30] = (byte)num3;
					num2 = 51;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 110:
					num3 = 116;
					num2 = 149;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 65;
				case 102:
					num14 = 198;
					goto case 410;
				case 101:
					array2[0] = 182;
					num = 97;
					goto case 97;
				case 96:
					array5[7] = 116;
					num2 = 444;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 95:
					num3 = 153;
					goto case 247;
				case 92:
					array2[11] = (byte)num5;
					num = 613;
					goto case 613;
				case 87:
					zero = IntPtr.Zero;
					num = 148;
					goto case 148;
				case 77:
					array[22] = 100;
					num2 = 119;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 76:
					array5[3] = 111;
					num2 = 80;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 75:
					array[15] = 119;
					goto case 622;
				case 74:
					array2[11] = (byte)num5;
					goto case 659;
				case 67:
					num13++;
					goto case 199;
				case 56:
					array9 = (array8 = array7);
					if (array9 == null)
					{
						goto case 626;
					}
					goto case 280;
				case 54:
					if (num11 == 4)
					{
						num2 = 236;
						if (tQ4VPAqlcsXEPAd5sK() == null)
						{
							continue;
						}
						goto IL_0b40;
					}
					goto case 100;
				case 46:
					num10 = 0L;
					goto case 45;
				case 45:
					npQnGPS2svNOvmFlOU(new IntPtr(&num10), 0);
					num2 = 595;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 43:
					array3[num4 + 7] = array6[7];
					goto case 49;
				case 41:
					array3[num4 + 5] = array6[5];
					num2 = 628;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 39:
					num9 = rB6TZEb8JtjnFD4eoI(object_);
					num2 = 521;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 38:
					array5[7] = 100;
					goto case 417;
				case 37:
					num3 = 118;
					num2 = 307;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 35:
					if (num8 == 4109628145u)
					{
						goto case 510;
					}
					goto case 460;
				case 31:
					num7 <<= 8;
					num2 = 8;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 30:
					num6 = 111;
					num = 529;
					goto case 529;
				case 27:
					num5 = 66;
					num2 = 568;
					if (w9diKK5g7kam6LVG9j())
					{
						continue;
					}
					goto IL_0b40;
				case 23:
					num3 = 123;
					num2 = 630;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 22:
					num5 = 101;
					goto case 436;
				case 18:
					num6 = 115;
					goto case 591;
				case 14:
					array2[9] = (byte)num5;
					goto case 388;
				case 11:
					array5[10] = 108;
					goto case 141;
				case 10:
					array[16] = 69;
					goto case 30;
				case 6:
					array3[num4 + 6] = array4[6];
					goto case 461;
				case 2:
					array2[2] = 232;
					num2 = 305;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto case 14;
				case 1:
					array[16] = (byte)num3;
					num2 = 10;
					if (tQ4VPAqlcsXEPAd5sK() == null)
					{
						continue;
					}
					goto IL_0b40;
				case 415:
					return;
				case 337:
					xGKrYIlYDeuaXoT8kx();
					return;
				case 325:
					return;
				case 140:
					xGKrYIlYDeuaXoT8kx();
					return;
				case 213:
					return;
				case 641:
					CCWKxI5OU8Ve7YneVM9(new IntPtr(value), intPtr);
					goto case 647;
				case 647:
					bGY4RO1lga(new IntPtr(value), CLythVXuCVyvcwvoIf(), int_, ref int_);
					goto end_IL_0009;
				case 369:
					goto end_IL_0009;
				case 381:
					return;
				}
				break;
			}
			continue;
			end_IL_0009:
			break;
		}
		xGKrYIlYDeuaXoT8kx();
	}

	internal static object GHw4fLAwAy(object object_0)
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

	private static IntPtr BQm4ZfbBA2(IntPtr intptr_0, object object_0, uint uint_0)
	{
		if (XUPKMwXeG0 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			XUPKMwXeG0 = (icC6nIVGBFhB69Ylsp)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554462)));
		}
		return XUPKMwXeG0(intptr_0, (string)object_0, uint_0);
	}

	private static IntPtr vN74pNTwYT(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (S8tKWJwl9Q == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			S8tKWJwl9Q = (XCwgpifE3xFlBfM6Wv)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554463)));
		}
		return S8tKWJwl9Q(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int aNB47Ca6Ue(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (FH6KbuqAuI == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			FH6KbuqAuI = (zBtj2uuYZIqVTYWK55)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554464)));
		}
		return FH6KbuqAuI(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int bGY4RO1lga(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (z6mKFTgMRW == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			z6mKFTgMRW = (vde6YmCaEBtR0qByJH)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554465)));
		}
		return z6mKFTgMRW(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr roM4g0Jq65(uint uint_0, int int_0, uint uint_1)
	{
		if (sP5KkW1hLy == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			sP5KkW1hLy = (agn9EIZBDAmx3RK2RA)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554466)));
		}
		return sP5KkW1hLy(uint_0, int_0, uint_1);
	}

	private static int Hie4hsNb5R(IntPtr intptr_0)
	{
		if (fDYK0hjZI7 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			fDYK0hjZI7 = (YHaUP8p8a3eZjxkM9I)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(tVl5CuhlTVAqOuASlY.O36ghuAiBsfRN(33554467)));
		}
		return fDYK0hjZI7(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (zlDKij8xjM == IntPtr.Zero)
		{
			zlDKij8xjM = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return zlDKij8xjM;
	}

	[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
	private static byte[] rHe49JRZSK(object object_0)
	{
		using FileStream fileStream = new FileStream((string)object_0, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	internal static Stream itV4AyKvR7()
	{
		return new MemoryStream();
	}

	internal static byte[] rgV4UOBiLr(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	[DPWfmrMX97fkqfs0SW(typeof(DPWfmrMX97fkqfs0SW.VHaqdoW6xuLxtHGOSL<object>[]))]
	private static byte[] y6R4SeSAlk(object object_0)
	{
		Stream stream = itV4AyKvR7();
		SymmetricAlgorithm symmetricAlgorithm = YpYzudYx0();
		symmetricAlgorithm.Key = new byte[32]
		{
			22, 62, 118, 13, 164, 106, 31, 253, 10, 141,
			85, 199, 208, 30, 9, 138, 151, 16, 190, 120,
			7, 105, 123, 232, 178, 170, 78, 214, 4, 92,
			81, 243
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			183, 164, 246, 125, 112, 31, 253, 188, 115, 199,
			234, 66, 223, 218, 74, 239
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_0, 0, ((Array)object_0).Length);
		cryptoStream.Close();
		byte[] result = rgV4UOBiLr(stream);
		xd5fWoR2w11ki1Nkun.EhaghuZz9OIuH();
		return result;
	}

	private byte[] B1B4y67uJ2()
	{
		return null;
	}

	private byte[] T6l4O5HQLa()
	{
		return null;
	}

	private byte[] aOM4vK7aVM()
	{
		return null;
	}

	private byte[] Wct4dekkd2()
	{
		return null;
	}

	private byte[] UyY4NixyLE()
	{
		return null;
	}

	private byte[] kB646kgUlw()
	{
		return null;
	}

	internal byte[] lZw4cyUNRA()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] MGd4qJq6dY()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] lGn4wA5JuO()
	{
		return null;
	}

	internal byte[] mas4ICbOg1()
	{
		return null;
	}

	internal static object kibPEqEVaQVqgMlhZJ(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object rjhyfpKvhw41TPx5XF(object object_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).KDikMXewCI();
	}

	internal static void d4pdDf0fJDGLrYQTZH(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long ro7d6ddjrHW6SxtxGe(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object YSrq9uoC5fiW9QMvp6(object object_0, int int_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).IQoKuYktS8(int_0);
	}

	internal static void o3vZmISIUtd5HGU0fP(object object_0)
	{
		((WpWSp8jcj2DZFKf0eg)object_0).H5KKpC0KrM();
	}

	internal static void X9XC5qgACL9ngRH1xE(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object UsWNaPhLWWo2Nlh9IX(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object imxFZNJKmB7CDr3gx4(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object LVkojjNGaHxUCcC0y8()
	{
		return YpYzudYx0();
	}

	internal static void T6jruZDGp3YMuyFnHb(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object G9NA2KeaWpIGInAGQ3(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object TgNNwFLmXfx2jeNm5p()
	{
		return itV4AyKvR7();
	}

	internal static void t1t8fZFpqUeod5Yohb(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void PQ5Yq94YDsxA9GtmYQ(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object HMq7xGvl27lSuZa5va(object object_0)
	{
		return rgV4UOBiLr(object_0);
	}

	internal static void LUwXjWk1Z9X2wxPjiF(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int UqmiP1w6an3mNlvJSH(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void kmHUkHstoSNRNpZXyX()
	{
		xd5fWoR2w11ki1Nkun.EhaghuZz9OIuH();
	}

	internal static object jRoFrbaBvheMWDwxJk()
	{
		return Encoding.Unicode;
	}

	internal static object XwpIHyZT64JnRvQfXs(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool iETnkMlVYP1W6fMlh3()
	{
		return (object)null == null;
	}

	internal static object UiwVHw9TivhOxjtS2q()
	{
		return null;
	}

	internal static void eHfK5fjaEWQPjveOfT()
	{
		xd5fWoR2w11ki1Nkun.EhaghuZz9OIuH();
	}

	internal static void KNshnLU8T8POZveCdw(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type brhDxCqtHGQV0CvqGs(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object CeFZwVpumtSHwpEnXy(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int bufEkV22dYqr7oF4Oh(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object IKrngw1ZiI7m5ncCTh()
	{
		return SHA1.Create();
	}

	internal static object jHKl8HEuq6AQaaAUb3(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool aeC8mxmXH4vxJXJnnI(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object L6m7ZU6DchSjQbaUeo(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object aKTn63eVaWLosCcKbI(object object_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).KDikMXewCI();
	}

	internal static void IliwvIOGtPFAmXMktw(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long LtDHjbIM9ngfvy5SLC(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object tTjHVV0t9CRyRL2qYE(object object_0, int int_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).IQoKuYktS8(int_0);
	}

	internal static object l4YRtG5ndNQqnG0UFU()
	{
		return YpYzudYx0();
	}

	internal static void cV5POdCpf6EmwhCnhe(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object vIJ0MLtW7AnJ1nDOev(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object GIwd9kwCw1vleL4Tty()
	{
		return itV4AyKvR7();
	}

	internal static void b2oxm2dyQ7FU2nyEkN(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void pVLLoOlr7quoKeuefk(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object a8tmo8QOBPBhisQoAR()
	{
		return Encoding.UTF8;
	}

	internal static object A2P01xB81tgCMGWUZZ(object object_0)
	{
		return rgV4UOBiLr(object_0);
	}

	internal static object H28eTLPO9eIbPbJJpN(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void agpOs9NhIMR33SwJJN(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void BGp11Qu4FwS261bQq0(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void ef1G1roFwdI0cgdy7q(object object_0)
	{
		((WpWSp8jcj2DZFKf0eg)object_0).H5KKpC0KrM();
	}

	internal static void iacc3pGa7ARqESRKj5(object object_0, object object_1, uint uint_0, object object_2)
	{
		UBX4KyPds4(object_0, object_1, uint_0, object_2);
	}

	internal static ushort eX9ttXM4xQaHsab4uI(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int ip59h2JYw8Lwyk8YsK(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void y8xk8EnT4E1LjRc1TX(object object_0, object object_1, int int_0, int int_1)
	{
		zU44e3t6es(object_0, object_1, int_0, int_1);
	}

	internal static long X82LECA0n2nFZa1brh(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint RtfBrpZRReTDuHkdRH(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint XLAt4k9kc1mlbfKEK7(uint uint_0, int int_0, long long_0, object object_0)
	{
		return qLO4mHhGMj(uint_0, int_0, long_0, object_0);
	}

	internal static long IOsGqvTMJNNevocqdA(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object CFNWnkh2oMcBni2ImA(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object mcb3Mif8r7Wv5cbQO4(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void Q34L4WguXFwwx0UZPi(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object rIQ1VKiBqiZL9yGP7W(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool Y2qgf5DnanR8W6bou5(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object IiCJr9SpoMmrnhRZEW(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object tEyaMj3sLUm6kdymbl(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object WS7S9ZbOSDVHwOo18y(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool YwX0VgXTbwtAy8AMIL()
	{
		return (object)null == null;
	}

	internal static object Ss9Yv7LL5i9FMGOAui()
	{
		return null;
	}

	internal static IntPtr npQnGPS2svNOvmFlOU(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static int tFudfYnbyHHnulHgAP(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt32(intptr_0, int_0);
	}

	internal static long Olcn0lLZfqJQ3ckOre(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt64(intptr_0, int_0);
	}

	internal static void EK2KKsV2QueGKgfHEj(IntPtr intptr_0, int int_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
	}

	internal static void IWJMh085cGT4JTi28O(IntPtr intptr_0, int int_0, int int_1)
	{
		Marshal.WriteInt32(intptr_0, int_0, int_1);
	}

	internal static void HOurykjS5Rw0mXWySR(IntPtr intptr_0, int int_0, long long_0)
	{
		Marshal.WriteInt64(intptr_0, int_0, long_0);
	}

	internal static IntPtr SSUk9AvAPLg9XQGXSZ(int int_0)
	{
		return Marshal.AllocCoTaskMem(int_0);
	}

	internal static void pG2CksPoHx3JrBNyNs(object object_0, int int_0, IntPtr intptr_0, int int_1)
	{
		Marshal.Copy((byte[])object_0, int_0, intptr_0, int_1);
	}

	internal static void KEW15jZMvpDJUcDHjh()
	{
		opY4iUsGtN();
	}

	internal static object yPcscORqInLIO1Lmn8()
	{
		return Process.GetCurrentProcess();
	}

	internal static object qgbvhje4AFv3fZX9Sq(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static IntPtr NxQs2Ziwq4ui1TgYFd(object object_0)
	{
		return ((ProcessModule)object_0).BaseAddress;
	}

	internal static IntPtr zWh6VK3ZGslTgW3h1t(IntPtr intptr_0, object object_0, uint uint_0)
	{
		return BQm4ZfbBA2(intptr_0, object_0, uint_0);
	}

	internal static bool Ef43VRWJhqrbixH4B5(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 != intptr_1;
	}

	internal static void xGKrYIlYDeuaXoT8kx()
	{
		xd5fWoR2w11ki1Nkun.EhaghuZz9OIuH();
	}

	internal static int CLythVXuCVyvcwvoIf()
	{
		return IntPtr.Size;
	}

	internal static Type QEKXwaxjNKv9wrBywY(object object_0, bool bool_0)
	{
		return Type.GetType((string)object_0, bool_0);
	}

	internal static bool hYk438KXIo8IVV5oJU(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static object iEXT8Gp3Y3HIllX7SI(object object_0)
	{
		return ((Process)object_0).Modules;
	}

	internal static object uSF7tk4PoUdsFmDJNX(object object_0)
	{
		return ((ReadOnlyCollectionBase)object_0).GetEnumerator();
	}

	internal static object qquo3skueBPJxbdXIW(object object_0)
	{
		return ((IEnumerator)object_0).Current;
	}

	internal static object MXSmQSm4mGd9evCkID(object object_0)
	{
		return ((ProcessModule)object_0).ModuleName;
	}

	internal static object GUoZ2FFfJ8HI0ILO7c(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static bool DI4Y59M24OPH6Zbqh8(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object avKtoyEsrEw21eUVpi(object object_0)
	{
		return ((ProcessModule)object_0).FileVersionInfo;
	}

	internal static int bFHmVZ1if45JHyHbYG(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMajorPart;
	}

	internal static int AoN4UQOwwpys6j9mT3(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMinorPart;
	}

	internal static int RRNh6xrFZTYy0WnPf7(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductBuildPart;
	}

	internal static int MOZKV0CNtoeHsTSWSN(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductPrivatePart;
	}

	internal static bool KqCt95s7vcOvvgaonL(object object_0, object object_1)
	{
		return (Version?)object_0 >= (Version?)object_1;
	}

	internal static bool TrZCFCJqiLuu5UEeoY(object object_0, object object_1)
	{
		return (Version?)object_0 < (Version?)object_1;
	}

	internal static bool lCVgh3QmHr2UmvwLvF(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void YoPIe6GE7tAY6ya3RM(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object u0fUSm61LREN8CWoMQ(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object dr4pDGttyGLTDiPG8x(object object_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).KDikMXewCI();
	}

	internal static void Ft6eRFAB9TGlPxu5CN(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long PhhLSiUFhVHNR8p4an(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object VfdItgc5swn1llGhOe(object object_0, int int_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).IQoKuYktS8(int_0);
	}

	internal static void dAnLMSTENbDtTIuBc2(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object Ee7jsadQGQKLKaXayU(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object w1aJonIdBddf8Z1bSs(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static void RCsMwvDuucQMnoycto(object object_0, int int_0, int int_1)
	{
		Array.Clear((Array)object_0, int_0, int_1);
	}

	internal static object Fq97IiBdPdAuDI5TQM(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static IntPtr y0fdisuEk31FMxPpsI(object object_0)
	{
		return Marshal.GetHINSTANCE((Module)object_0);
	}

	internal static object VCJ6SLfCTMIknVulEp(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int YGjPhdabah83SpyRCl(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int rB6TZEb8JtjnFD4eoI(object object_0)
	{
		return ((WpWSp8jcj2DZFKf0eg)object_0).FZdKZeItnh();
	}

	internal static object YpJDdU2rahwaaJMFTW()
	{
		return YpYzudYx0();
	}

	internal static void EvFgX4N5cctbNxeBcv(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object a7ybunhOLsC0sMnidC(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static void pfyBOaoei6ELVKY9G8(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void qmK6ssyVv2RtSC2moB(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object bdrgWJwirStTW6kwl8(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void IoAGuMgKWO3tKKbFRf(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void cGeZFQ0u3NNh3Bxmgc(object object_0)
	{
		((WpWSp8jcj2DZFKf0eg)object_0).H5KKpC0KrM();
	}

	internal static int xUfLwTH5W4vy9l5V5x(object object_0)
	{
		return ((Process)object_0).Id;
	}

	internal static IntPtr reinHNYeyu6nKm2drq(uint uint_0, int int_0, uint uint_1)
	{
		return roM4g0Jq65(uint_0, int_0, uint_1);
	}

	internal static object tHGsZI7flKsjPMwDHx(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static long YgBrXGz2eG7nxmLopR(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static void G6mMDw59E9QervP9nC1(IntPtr intptr_0, int int_0)
	{
		Marshal.WriteInt32(intptr_0, int_0);
	}

	internal static int USQxQy55Nx0SOj84KiJ(IntPtr intptr_0)
	{
		return Hie4hsNb5R(intptr_0);
	}

	internal static void omQ0sO5qpL1i6TbPW3B(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static Type FOHnOE5SnEatDcLXNlx(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int rVWXyA5nqemDX5Dj2ge(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static object uMCLWl5L0R5bIeYbTFc()
	{
		return Encoding.UTF8;
	}

	internal static object gqt83k5V0ywMxaWpTRi(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool t83lAh58HndV6DmbQcw(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 == intptr_1;
	}

	internal static object OX7VDP5j28MEqxsyl4j(IntPtr intptr_0, Type type_0)
	{
		return YMF4jY8QdC(intptr_0, type_0);
	}

	internal static IntPtr gvNNRW5vK33LLMxfH0O(object object_0)
	{
		return object_0();
	}

	internal static int Gqe6GG5Pe46WyVApDX7(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static long vwBCrx5ZU5AJtCFp2kB(IntPtr intptr_0)
	{
		return Marshal.ReadInt64(intptr_0);
	}

	internal static IntPtr xx2Vf65RdYDRyKj5C5x(object object_0)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)object_0);
	}

	internal static int kwVo6g5eCiKcnQiuiPm(object object_0)
	{
		return ((ProcessModule)object_0).ModuleMemorySize;
	}

	internal static object OeqDXT5i5g8O6rrXhdw(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool pGdYqW53Glk7uDdyY3i(object object_0, object object_1)
	{
		return (MethodInfo?)object_0 != (MethodInfo?)object_1;
	}

	internal static object BTxDti5Wti80t4gi9wU(object object_0)
	{
		return ((Delegate)object_0).Method;
	}

	internal static object flxcrP5lVfXvv0lfwG8(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static object IieZUX5XCJBll5vBpVv(object object_0)
	{
		return ((MethodBase)object_0).GetParameters();
	}

	internal static object W5VyKM5xHBGOLyIVURB(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}

	internal static ModuleHandle CgngFc5KpOehZOe1uPS(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}

	internal static Type WpRwjt5p72lVMVHEEi9(object object_0)
	{
		return object_0.GetType();
	}

	internal static object vHyr6t54Xj0WcFO9EpV(object object_0, object object_1)
	{
		return ((FieldInfo)object_0).GetValue(object_1);
	}

	internal static object efYF6H5kRI5O9Bw9vhk(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static void yfkAgH5mbrQs5MnqkoA(object object_0)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)object_0);
	}

	internal static RuntimeMethodHandle R3VW0p5FhD2Kp6vTh4M(object object_0)
	{
		return ((MethodBase)object_0).MethodHandle;
	}

	internal static void W4GMrI5Mr7iqNE7VQld(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void dvmjCf5Ewwp4k6wEH3A(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static IntPtr r3cMyC51YhZBD3hmxXG(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		return vN74pNTwYT(intptr_0, uint_0, uint_1, uint_2);
	}

	internal static void CCWKxI5OU8Ve7YneVM9(IntPtr intptr_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, intptr_1);
	}

	internal static bool w9diKK5g7kam6LVG9j()
	{
		return (object)null == null;
	}

	internal static object tQ4VPAqlcsXEPAd5sK()
	{
		return null;
	}
}
