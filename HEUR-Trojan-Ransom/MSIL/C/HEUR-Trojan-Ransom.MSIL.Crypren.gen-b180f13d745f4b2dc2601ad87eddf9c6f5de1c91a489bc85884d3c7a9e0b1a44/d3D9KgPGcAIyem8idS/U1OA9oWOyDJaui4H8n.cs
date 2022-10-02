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
using mDPsduBY6HhSKmPpjxM;
using rRTPGR4IeVc03k9hR35;

namespace d3D9KgPGcAIyem8idS;

internal class U1OA9oWOyDJaui4H8n
{
	private delegate void SICGyx4eT2vNSuDSdhs(object o);

	internal class JxP3Jy4VUAVWGuE8Kmo : Attribute
	{
		internal class TPInFn4fE8pALN8q9lo<DVetXs4jpk6dQfduwgW>
		{
		}

		public JxP3Jy4VUAVWGuE8Kmo(object object_0)
		{
		}
	}

	internal class f6vDEh4xKqUxIfbQf3Y
	{
		internal static string pPQ4gjgpIS(object object_0, object object_1)
		{
			byte[] bytes = ((Encoding)nOvnfWRqMG8WSIVvBYd()).GetBytes((string)object_0);
			byte[] object_2 = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] object_3 = (byte[])xMDXUXREbWjd056YNnv(nYwcq5RNnKrm2YOVOuB(nOvnfWRqMG8WSIVvBYd(), object_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm object_4 = (SymmetricAlgorithm)fFXDpZRCVZRTHqxKUUV();
			LOc6jYRajtvLlqgXEf1(object_4, object_2);
			HIdbi0RiTZB4Mq5PdUp(object_4, object_3);
			CryptoStream object_5 = new CryptoStream(memoryStream, (ICryptoTransform)kObujaRr1Ddd1ueCyBD(object_4), CryptoStreamMode.Write);
			kEKJGYRO27twAKQmZsq(object_5, bytes, 0, bytes.Length);
			cngHIqR8180Y9VSbWpm(object_5);
			return (string)Y68qruRAGrPR0wrdlei(memoryStream.ToArray());
		}

		internal static object nOvnfWRqMG8WSIVvBYd()
		{
			return Encoding.Unicode;
		}

		internal static object nYwcq5RNnKrm2YOVOuB(object object_0, object object_1)
		{
			return ((Encoding)object_0).GetBytes((string)object_1);
		}

		internal static object xMDXUXREbWjd056YNnv(object object_0)
		{
			return tGXJ1dhbU(object_0);
		}

		internal static object fFXDpZRCVZRTHqxKUUV()
		{
			return mfSMjZdye();
		}

		internal static void LOc6jYRajtvLlqgXEf1(object object_0, object object_1)
		{
			((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
		}

		internal static void HIdbi0RiTZB4Mq5PdUp(object object_0, object object_1)
		{
			((SymmetricAlgorithm)object_0).IV = (byte[])object_1;
		}

		internal static object kObujaRr1Ddd1ueCyBD(object object_0)
		{
			return ((SymmetricAlgorithm)object_0).CreateEncryptor();
		}

		internal static void kEKJGYRO27twAKQmZsq(object object_0, object object_1, int int_0, int int_1)
		{
			((Stream)object_0).Write((byte[])object_1, int_0, int_1);
		}

		internal static void cngHIqR8180Y9VSbWpm(object object_0)
		{
			((Stream)object_0).Close();
		}

		internal static object Y68qruRAGrPR0wrdlei(object object_0)
		{
			return Convert.ToBase64String((byte[])object_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint MOtWKl4X4EeclsbNxLf(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr XOBnJa4DBrUyfbgPmKV();

	internal struct Sn8TI74d59ajENmAPb8
	{
		internal bool ohJ41eq6Ov;

		internal byte[] apB4KsopsW;
	}

	internal class YvSqsm4FEMQVAcAhE3h
	{
		private object S1X4C4gPVL;

		public YvSqsm4FEMQVAcAhE3h(Stream stream_0)
		{
			S1X4C4gPVL = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return ((BinaryReader)S1X4C4gPVL).BaseStream;
		}

		internal byte[] Udp45OEuiL(int int_0)
		{
			return (byte[])hQ4uQKRSs4oHM5DEOE6(S1X4C4gPVL, int_0);
		}

		internal int ql64qKcBos(byte[] byte_0, int int_0, int int_1)
		{
			return FnkCbeRlCqyxbLRoiuu(S1X4C4gPVL, byte_0, int_0, int_1);
		}

		internal int eUy4NVDm3e()
		{
			return UqCx4ZRWRIkP7aCX2db(S1X4C4gPVL);
		}

		internal void I4v4EpROv7()
		{
			Me4bR9RPf7p4UaZCBmi(S1X4C4gPVL);
		}

		internal static object hQ4uQKRSs4oHM5DEOE6(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int FnkCbeRlCqyxbLRoiuu(object object_0, object object_1, int int_0, int int_1)
		{
			return ((BinaryReader)object_0).Read((byte[])object_1, int_0, int_1);
		}

		internal static int UqCx4ZRWRIkP7aCX2db(object object_0)
		{
			return ((BinaryReader)object_0).ReadInt32();
		}

		internal static void Me4bR9RPf7p4UaZCBmi(object object_0)
		{
			((BinaryReader)object_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr ITX8fs4auXpL55f4s5k(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr iYEsM14iGav7HO1hOMl(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int W72lvT4r8aCdeLa75rO(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int EJbG554OmqfxZNAkQy5(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GxeuVK48qHkABf4D1vG(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int hxOTCh4AEn5kNCr7ysJ(IntPtr ptr);

	[Flags]
	private enum rR70w74QRXHcHcVxG78
	{

	}

	internal static object XrWmAG1Nye;

	private static bool Q1UmIHLtsj;

	private static Dictionary<int, int> N7mm7GN2SA;

	private static object SrTm2b5nSy;

	private static IntPtr ECVm0Esv8q;

	private static object zPfm9wRXhd;

	private static object wlNmot0BlB;

	private static int WYvm6DJ9vI;

	internal static object TEomygitYJ;

	private static bool Ccd4mE0DAW;

	private static int B7t44oNTjT;

	private static IntPtr ee44B1p5kN;

	internal static object suj4YwdO1q;

	private static object lcp4s6IvoB;

	private static object KoN4pdcqoD;

	private static object vxH4cVD67u;

	private static object DtH4LExoSR;

	private static object yXomHDHU55;

	private static object iaCmTSiKMT;

	private static bool IVx4n5KeXF;

	private static int BsamSgI7mi;

	private static List<string> wQwmWoAGJE;

	[JxP3Jy4VUAVWGuE8Kmo(typeof(JxP3Jy4VUAVWGuE8Kmo.TPInFn4fE8pALN8q9lo<object>[]))]
	private static bool XlT4Z4ENjB;

	private static object xjomltrdTJ;

	private static int ehjmuXoyTp;

	private static object xPs4wtbvL0;

	private static List<int> W3vmPtoBSL;

	private static bool ukRm8quG4Q;

	private static object wG7mQpSO9D;

	private static bool fncmhQMr27;

	private static object yv94U8NZc0;

	private static long S3dmthY6qU;

	private static long e2PmJYnWev;

	private static object snt4kaVWh9;

	private static int RAEmzmuunx;

	internal static object WfBmvHp7nu;

	private static object WRamMb2kUA;

	private static bool XYjm3JxN13;

	private static IntPtr Q4nmGImt6w;

	internal static object g8embWa4rX;

	private static IntPtr fGs4RkXFEN;

	static U1OA9oWOyDJaui4H8n()
	{
		ukRm8quG4Q = false;
		XrWmAG1Nye = typeof(U1OA9oWOyDJaui4H8n).Assembly;
		wG7mQpSO9D = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		fncmhQMr27 = false;
		Q1UmIHLtsj = false;
		g8embWa4rX = null;
		N7mm7GN2SA = null;
		yXomHDHU55 = new object();
		BsamSgI7mi = 0;
		xjomltrdTJ = new object();
		wQwmWoAGJE = null;
		W3vmPtoBSL = null;
		iaCmTSiKMT = new byte[0];
		SrTm2b5nSy = new byte[0];
		ECVm0Esv8q = IntPtr.Zero;
		Q4nmGImt6w = IntPtr.Zero;
		zPfm9wRXhd = new string[0];
		wlNmot0BlB = new int[0];
		WYvm6DJ9vI = 1;
		XYjm3JxN13 = false;
		WRamMb2kUA = new SortedList();
		ehjmuXoyTp = 0;
		e2PmJYnWev = 0L;
		WfBmvHp7nu = null;
		TEomygitYJ = null;
		S3dmthY6qU = 0L;
		RAEmzmuunx = 0;
		IVx4n5KeXF = false;
		Ccd4mE0DAW = false;
		B7t44oNTjT = 0;
		ee44B1p5kN = IntPtr.Zero;
		XlT4Z4ENjB = false;
		suj4YwdO1q = new Hashtable();
		lcp4s6IvoB = null;
		snt4kaVWh9 = null;
		KoN4pdcqoD = null;
		vxH4cVD67u = null;
		xPs4wtbvL0 = null;
		DtH4LExoSR = null;
		fGs4RkXFEN = IntPtr.Zero;
		yv94U8NZc0 = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void U5xD7yd1Gy()
	{
	}

	internal static byte[] QUxTTbQVb(object object_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - ((Array)object_0).Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(((Array)object_0).Length + num / 8u + 8L);
		ulong num3 = (ulong)(((Array)object_0).Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < ((Array)object_0).Length; i++)
		{
			array2[i] = ((byte[])object_0)[i];
		}
		array2[((Array)object_0).Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFFuL);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num6 = 0u; num6 < num5 / 16u; num6++)
		{
			uint num7 = num6 << 6;
			for (uint num8 = 0u; num8 < 61; num8 += 4)
			{
				array[num8 >> 2] = (uint)((array2[num7 + (num8 + 3)] << 24) | (array2[num7 + (num8 + 2)] << 16) | (array2[num7 + (num8 + 1)] << 8) | array2[num7 + num8]);
			}
			uint num9 = uint_;
			uint num10 = uint_2;
			uint num11 = uint_3;
			uint num12 = uint_4;
			GSc2Ukyyb(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			GSc2Ukyyb(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			GSc2Ukyyb(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			GSc2Ukyyb(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			GSc2Ukyyb(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			GSc2Ukyyb(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			GSc2Ukyyb(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			GSc2Ukyyb(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			GSc2Ukyyb(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			GSc2Ukyyb(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			GSc2Ukyyb(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			GSc2Ukyyb(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			GSc2Ukyyb(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			GSc2Ukyyb(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			GSc2Ukyyb(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			GSc2Ukyyb(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			VhW0VI13O(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			VhW0VI13O(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			VhW0VI13O(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			VhW0VI13O(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			VhW0VI13O(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			VhW0VI13O(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			VhW0VI13O(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			VhW0VI13O(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			VhW0VI13O(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			VhW0VI13O(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			VhW0VI13O(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			VhW0VI13O(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			VhW0VI13O(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			VhW0VI13O(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			VhW0VI13O(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			VhW0VI13O(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			XhqGB8yGs(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			XhqGB8yGs(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			XhqGB8yGs(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			XhqGB8yGs(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			XhqGB8yGs(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			XhqGB8yGs(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			XhqGB8yGs(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			XhqGB8yGs(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			XhqGB8yGs(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			XhqGB8yGs(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			XhqGB8yGs(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			XhqGB8yGs(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			XhqGB8yGs(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			XhqGB8yGs(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			XhqGB8yGs(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			XhqGB8yGs(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			BsV9MnBuJ(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			BsV9MnBuJ(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			BsV9MnBuJ(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			BsV9MnBuJ(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			BsV9MnBuJ(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			BsV9MnBuJ(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			BsV9MnBuJ(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			BsV9MnBuJ(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			BsV9MnBuJ(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			BsV9MnBuJ(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			BsV9MnBuJ(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			BsV9MnBuJ(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			BsV9MnBuJ(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			BsV9MnBuJ(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			BsV9MnBuJ(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			BsV9MnBuJ(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num9;
			uint_2 += num10;
			uint_3 += num11;
			uint_4 += num12;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void GSc2Ukyyb(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fgIoVf6Wy(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])wG7mQpSO9D)[uint_5 - 1], ushort_0);
	}

	private static void VhW0VI13O(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fgIoVf6Wy(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])wG7mQpSO9D)[uint_5 - 1], ushort_0);
	}

	private static void XhqGB8yGs(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fgIoVf6Wy(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_0)[uint_4] + ((uint[])wG7mQpSO9D)[uint_5 - 1], ushort_0);
	}

	private static void BsV9MnBuJ(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fgIoVf6Wy(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])wG7mQpSO9D)[uint_5 - 1], ushort_0);
	}

	private static uint fgIoVf6Wy(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool beh6rIdsR()
	{
		if (!fncmhQMr27)
		{
			BQXuxrg3I();
			fncmhQMr27 = true;
		}
		return Q1UmIHLtsj;
	}

	internal U1OA9oWOyDJaui4H8n()
	{
	}

	private void dqV3eptid(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		int num = byte_2.Length % 4;
		int num2 = byte_2.Length / 4;
		byte[] array = new byte[byte_2.Length];
		int num3 = byte_0.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((byte_0[num7 + 3] << 24) | (byte_0[num7 + 2] << 16) | (byte_0[num7 + 1] << 8) | byte_0[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				num4 += num5;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= byte_2[^(1 + j)];
				}
			}
			else
			{
				num4 += num5;
				num7 = (uint)num9;
				num6 = (uint)((byte_2[num7 + 3] << 24) | (byte_2[num7 + 2] << 16) | (byte_2[num7 + 1] << 8) | byte_2[num7]);
			}
			uint num12 = num4;
			num4 = 0u;
			uint num13 = num12;
			num13 ^= num13 << 2;
			num13 += 1245714516;
			num13 ^= num13 << 17;
			num13 += 1078862260;
			num13 ^= num13 >> 15;
			num13 += 497718232;
			num13 = 1821220856 + num13;
			num4 = num12 + (uint)(double)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num14 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num14 & num10) >> num11);
				}
			}
			else
			{
				uint num15 = num4 ^ num6;
				array[num9] = (byte)(num15 & 0xFFu);
				array[num9 + 1] = (byte)((num15 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num15 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
			}
		}
		iaCmTSiKMT = array;
	}

	internal static SymmetricAlgorithm mfSMjZdye()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (beh6rIdsR())
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

	internal static void BQXuxrg3I()
	{
		try
		{
			Q1UmIHLtsj = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] tGXJ1dhbU(object object_0)
	{
		if (!beh6rIdsR())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])object_0);
		}
		return QUxTTbQVb(object_0);
	}

	internal static void CyuvM4J9e(object object_0, object object_1, uint uint_0, object object_2)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)((Array)object_2).Length) ? ((Array)object_2).Length : ((int)uint_0));
			((Stream)object_1).Read((byte[])object_2, 0, num);
			HJLyL5gsn(object_0, object_2, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void HJLyL5gsn(object object_0, object object_1, int int_0, int int_1)
	{
		((HashAlgorithm)object_0).TransformBlock((byte[])object_1, int_0, int_1, (byte[]?)object_1, int_0);
	}

	internal static uint qKhtltk0M(uint uint_0, int int_0, long long_0, object object_0)
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

	public static void rWPzvLdPu(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (N7mm7GN2SA == null)
			{
				lock (yXomHDHU55)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(U1OA9oWOyDJaui4H8n).Assembly.GetManifestResourceStream("sT8XtNLAl3Lxxc2LcB.R1jPuhRb0egXSJ9Kut"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
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
							num3 += OAHm41kl5C(num3);
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
						YvSqsm4FEMQVAcAhE3h yvSqsm4FEMQVAcAhE3h = new YvSqsm4FEMQVAcAhE3h(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = yvSqsm4FEMQVAcAhE3h.eUy4NVDm3e();
							int value = yvSqsm4FEMQVAcAhE3h.eUy4NVDm3e();
							dictionary.Add(key, value);
						}
						yvSqsm4FEMQVAcAhE3h.I4v4EpROv7();
					}
					N7mm7GN2SA = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = N7mm7GN2SA[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)typeof(U1OA9oWOyDJaui4H8n).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint YFbmmJXVBo(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint OAHm41kl5C(uint uint_0)
	{
		return 0u;
	}

	internal static void mhtmB5pHW5()
	{
	}

	private static void rHZmZrZlVr(object object_0, int int_0)
	{
		xVlBUABZIDpOBkbsuAY.BlkBcdC7Jl(0, new object[2] { object_0, int_0 }, null);
	}

	internal static string WnEmYpOu4u(int int_0)
	{
		if (((Array)iaCmTSiKMT).Length == 0)
		{
			wQwmWoAGJE = new List<string>();
			W3vmPtoBSL = new List<int>();
			rHZmZrZlVr(((Assembly)XrWmAG1Nye).GetManifestResourceStream("qyvWdmm8BHdQeu7uxU.NCs4Ln4PGOINsXvdjD"), int_0);
		}
		if (BsamSgI7mi < 75)
		{
			if ((Assembly?)XrWmAG1Nye != new StackFrame(1).GetMethod()!.DeclaringType!.Assembly)
			{
				throw new Exception();
			}
			BsamSgI7mi++;
		}
		lock (xjomltrdTJ)
		{
			int num = BitConverter.ToInt32((byte[])iaCmTSiKMT, int_0);
			if (num < W3vmPtoBSL.Count && W3vmPtoBSL[num] == int_0)
			{
				return wQwmWoAGJE[num];
			}
			try
			{
				KvGQgW4hNlgjy7fkgCE.caI4bpmJ42();
				byte[] array = new byte[num];
				Array.Copy((Array)iaCmTSiKMT, int_0 + 4, array, 0, num);
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				wQwmWoAGJE.Add(@string);
				W3vmPtoBSL.Add(int_0);
				Array.Copy(BitConverter.GetBytes(wQwmWoAGJE.Count - 1), 0, (Array)iaCmTSiKMT, int_0, 4);
				return @string;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string wrJmsxf5rY(object object_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)object_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int DZkmkRletx()
	{
		return 5;
	}

	private static void YwSmp2mRYn()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate uhimcF0RFw(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object N1RmwmEX1c(object object_0)
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

	private static IntPtr v35mU9FdFX(IntPtr intptr_0, object object_0, uint uint_0)
	{
		if (lcp4s6IvoB == null)
		{
			lcp4s6IvoB = (ITX8fs4auXpL55f4s5k)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), typeof(ITX8fs4auXpL55f4s5k));
		}
		return lcp4s6IvoB(intptr_0, (string)object_0, uint_0);
	}

	private static IntPtr lRomeEOjvA(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (snt4kaVWh9 == null)
		{
			snt4kaVWh9 = (iYEsM14iGav7HO1hOMl)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), typeof(iYEsM14iGav7HO1hOMl));
		}
		return snt4kaVWh9(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int KrTmVAtB7F(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (KoN4pdcqoD == null)
		{
			KoN4pdcqoD = (W72lvT4r8aCdeLa75rO)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(W72lvT4r8aCdeLa75rO));
		}
		return KoN4pdcqoD(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int KMhmf3FJBX(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (vxH4cVD67u == null)
		{
			vxH4cVD67u = (EJbG554OmqfxZNAkQy5)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), typeof(EJbG554OmqfxZNAkQy5));
		}
		return vxH4cVD67u(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr q3UmjZyeg8(uint uint_0, int int_0, uint uint_1)
	{
		if (xPs4wtbvL0 == null)
		{
			xPs4wtbvL0 = (GxeuVK48qHkABf4D1vG)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Open ".Trim() + "Process"), typeof(GxeuVK48qHkABf4D1vG));
		}
		return xPs4wtbvL0(uint_0, int_0, uint_1);
	}

	private static int tc1mxxeRyM(IntPtr intptr_0)
	{
		if (DtH4LExoSR == null)
		{
			DtH4LExoSR = (hxOTCh4AEn5kNCr7ysJ)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Close ".Trim() + "Handle"), typeof(hxOTCh4AEn5kNCr7ysJ));
		}
		return DtH4LExoSR(intptr_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (fGs4RkXFEN == IntPtr.Zero)
		{
			fGs4RkXFEN = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return fGs4RkXFEN;
	}

	private static byte[] NSumgWq41J(object object_0)
	{
		using FileStream fileStream = new FileStream((string)object_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static Stream JgRmXJiirZ()
	{
		return new MemoryStream();
	}

	internal static byte[] QlQmD9sLQO(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	private static byte[] TC7md8gd72(object object_0)
	{
		Stream stream = JgRmXJiirZ();
		SymmetricAlgorithm symmetricAlgorithm = mfSMjZdye();
		symmetricAlgorithm.Key = new byte[32]
		{
			240, 206, 163, 203, 238, 26, 138, 30, 235, 111,
			103, 90, 112, 49, 47, 126, 79, 155, 91, 132,
			162, 13, 25, 210, 183, 249, 182, 136, 231, 73,
			79, 133
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			162, 190, 236, 103, 79, 5, 192, 167, 63, 117,
			213, 87, 188, 159, 141, 18
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_0, 0, ((Array)object_0).Length);
		cryptoStream.Close();
		byte[] result = QlQmD9sLQO(stream);
		KvGQgW4hNlgjy7fkgCE.caI4bpmJ42();
		return result;
	}

	private unsafe static int bmLm1lqccI(object object_0)
	{
		fixed (char* ptr = object_0)
		{
			int num = 5381;
			int num2 = 5381;
			char* ptr2 = ptr;
			int num3;
			while ((num3 = *ptr2) != 0)
			{
				num = ((num << 5) + num) ^ num3;
				num3 = ptr2[1];
				if (num3 == 0)
				{
					break;
				}
				num2 = ((num2 << 5) + num2) ^ num3;
				ptr2 += 2;
			}
			return num + num2 * 1566083941;
		}
	}

	internal static bool dcBmKQv9wS(object object_0, object object_1)
	{
		if ((string?)object_0 == (string?)object_1)
		{
			return true;
		}
		if (object_0 != null && object_1 != null)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			if (((string)object_0).StartsWith((string)yv94U8NZc0))
			{
				flag = true;
				num = (int)(((string)object_0)[4] | ((uint)((string)object_0)[5] << 8) | ((uint)((string)object_0)[6] << 16) | ((uint)((string)object_0)[7] << 24));
			}
			if (((string)object_1).StartsWith((string)yv94U8NZc0))
			{
				flag2 = true;
				num2 = (int)(((string)object_1)[4] | ((uint)((string)object_1)[5] << 8) | ((uint)((string)object_1)[6] << 16) | ((uint)((string)object_1)[7] << 24));
			}
			if (!flag && !flag2)
			{
				return false;
			}
			if (!flag)
			{
				num = bmLm1lqccI(object_0);
			}
			if (!flag2)
			{
				num2 = bmLm1lqccI(object_1);
			}
			return num == num2;
		}
		return false;
	}

	private byte[] a8JmF3nFPM()
	{
		return null;
	}

	private byte[] Iy0m5wVXBA()
	{
		return null;
	}

	private byte[] oENmq085p7()
	{
		_ = "{11111-22222-20001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] KUZmNWtVOn()
	{
		_ = "{11111-22222-20001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] nsbmEuju9B()
	{
		_ = "{11111-22222-30001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] bEomCmRwns()
	{
		_ = "{11111-22222-30001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] idhmaHRRdU()
	{
		_ = "{11111-22222-40001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] ya2miTUpPN()
	{
		_ = "{11111-22222-40001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] T4amrC1ylR()
	{
		return null;
	}

	internal byte[] jMbmOiWnK7()
	{
		return null;
	}

	internal static object ztbYjqwHdneVy8P3twP(object object_0)
	{
		return ((YvSqsm4FEMQVAcAhE3h)object_0).m9OIO8Q0EK();
	}

	internal static void QNISgUwSCmj8JEvG385(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long sevPTjwlPGSIB3NjSuv(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object PEvMBEwWBFBcDveNFwu(object object_0, int int_0)
	{
		return ((YvSqsm4FEMQVAcAhE3h)object_0).Udp45OEuiL(int_0);
	}

	internal static void Qt959bwPCDNTMivd33H(object object_0)
	{
		((YvSqsm4FEMQVAcAhE3h)object_0).I4v4EpROv7();
	}

	internal static void mXpQb7wTdunO0WXVFVC(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object AKtmrqw2CEIX5LsTaNG(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object A2isSlw0HVTOcE2f2uM(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object mDY9cVwG8HKocZiOAoj()
	{
		return mfSMjZdye();
	}

	internal static void tLgjpjw9MIB29KiIXQb(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object V3Dk0nwo7sqCaMwcpvQ(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object MeAjhuw66CCciJOre2l()
	{
		return JgRmXJiirZ();
	}

	internal static void eCenE5w3yBTfqUV6mAV(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void XjTcsvwMOSogQVM9CkT(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object COP3uuwuUm0FYNZNSqL(object object_0)
	{
		return QlQmD9sLQO(object_0);
	}

	internal static void dERUo0wJ2R3sB3dFC0w(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static object zISC5LwvKm8ByaqDI9v(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool mN6RLcwyLtx0t6N99bv(object object_0, object object_1)
	{
		return (MethodInfo?)object_0 == (MethodInfo?)object_1;
	}

	internal static bool S5kEGKwblEWiZpp6Fhe()
	{
		return (object)null == null;
	}

	internal static object hbp4iHw76N82VHvqxex()
	{
		return null;
	}
}
