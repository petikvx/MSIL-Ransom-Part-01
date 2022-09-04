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
using Mm1VUwLfnFwQpWyMTtM;
using VYiJxbju5iXC3iOOEKV;

namespace R2ujhcKxVgITXpqg9X;

internal class sMk8wArgfJX2hbRXDA
{
	private delegate void jSETXwLdvNhGim1HVT8(object o);

	internal class mnFe4yLOTq0HLoWT0SI : Attribute
	{
		internal class tssvHILmiH3K2KJ3YLZ<k2dcoVLhPFOTJKkSDWW>
		{
		}

		public mnFe4yLOTq0HLoWT0SI(object object_0)
		{
		}
	}

	internal class eh8LqMLRA13aXbth3Qg
	{
		internal static string VZiLZyLjwa(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = jZHcAMR0w(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = F30vPXJLc();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint nbVXYEL5dJamCYYMiM0(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr kNbmtLLgvhxJtrlG3a8();

	internal struct CsPJF0L9fjAO30VKl7U
	{
		internal bool HspLDEnEPt;

		internal byte[] J8BL3glTD2;
	}

	internal class vm4PJULCoMilxHZamU9
	{
		private BinaryReader vFsLeRwc02;

		public vm4PJULCoMilxHZamU9(Stream stream_0)
		{
			vFsLeRwc02 = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream m9OIO8Q0EK()
		{
			return vFsLeRwc02.BaseStream;
		}

		internal byte[] C9WLTUhMOM(int int_0)
		{
			return vFsLeRwc02.ReadBytes(int_0);
		}

		internal int jtsLJYaU7Q(byte[] byte_0, int int_0, int int_1)
		{
			return vFsLeRwc02.Read(byte_0, int_0, int_1);
		}

		internal int VyOLi7gcJl()
		{
			return vFsLeRwc02.ReadInt32();
		}

		internal void OdpLFVIwTX()
		{
			vFsLeRwc02.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr HeF0lVLSQmsr69pHxgO(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr qWnb51LABfiB1rEQKU5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int TrbTpuLIiS6qUHEn74A(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int RUngd6Ls8dt6somPopQ(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr deKqkcLwnjioS7Yb98W(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int do7lrjLa9L0CECp38oH(IntPtr ptr);

	[Flags]
	private enum H7S0hyLVl33u3oiFuP6
	{

	}

	private static bool dqCXwBmjTj;

	internal static Assembly oEXXasARI1;

	private static uint[] XgxXVMFk31;

	private static Dictionary<int, int> KkFXnULU0I;

	private static List<string> IeGXrf7axG;

	private static long FJ4Xcix2qX;

	private static long gdVXzLpmFn;

	private static int pFbL4GFCxN;

	private static IntPtr kmMLYtJYQA;

	[mnFe4yLOTq0HLoWT0SI(typeof(mnFe4yLOTq0HLoWT0SI.tssvHILmiH3K2KJ3YLZ<object>[]))]
	private static bool BHrLqlqpnf;

	private static deKqkcLwnjioS7Yb98W SR5L6ri5ZL;

	private static do7lrjLa9L0CECp38oH IlNLU47OFO;

	private static SortedList zOUXvgNsB4;

	private static byte[] YnDXxYmvUG;

	private static object uxtXWsKyWu;

	private static object F5KXt60g5f;

	private static int xxTLjqsIyc;

	private static List<int> aiCXKGYM99;

	private static object zTkXoxK0j6;

	private static byte[] pk6X8hrgCJ;

	internal static nbVXYEL5dJamCYYMiM0 nAGX7xmRla;

	private static int LrtX0DA8hB;

	private static bool uHwXfZiUdx;

	private static bool rTYX1UJLUy;

	private static int HOZXbVJ8FL;

	private static HeF0lVLSQmsr69pHxgO EmjL2EIOHO;

	private static bool UMfLLMhjsW;

	private static bool JuXLXoylr9;

	private static int[] AoZXHY6p5l;

	private static qWnb51LABfiB1rEQKU5 WetLEh0vjZ;

	private static string M9ALkPuH0E;

	private static TrbTpuLIiS6qUHEn74A EH2LQm6EoG;

	internal static RSACryptoServiceProvider dxMXPpTALL;

	private static IntPtr bG5Ll1XcFV;

	internal static Hashtable EqCLuRx6Uh;

	private static int voUXBdC5DG;

	private static IntPtr npBXNwUucL;

	private static IntPtr QoJXMeR0FR;

	internal static nbVXYEL5dJamCYYMiM0 H7OXGD3u4o;

	private static RUngd6Ls8dt6somPopQ iV9LySA4ws;

	private static bool ukmXpsAq6i;

	static sMk8wArgfJX2hbRXDA()
	{
		dqCXwBmjTj = false;
		oEXXasARI1 = typeof(sMk8wArgfJX2hbRXDA).Assembly;
		XgxXVMFk31 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		ukmXpsAq6i = false;
		uHwXfZiUdx = false;
		dxMXPpTALL = null;
		KkFXnULU0I = null;
		F5KXt60g5f = new object();
		voUXBdC5DG = 0;
		uxtXWsKyWu = new object();
		IeGXrf7axG = null;
		aiCXKGYM99 = null;
		pk6X8hrgCJ = new byte[0];
		YnDXxYmvUG = new byte[0];
		QoJXMeR0FR = IntPtr.Zero;
		npBXNwUucL = IntPtr.Zero;
		zTkXoxK0j6 = new string[0];
		AoZXHY6p5l = new int[0];
		HOZXbVJ8FL = 1;
		rTYX1UJLUy = false;
		zOUXvgNsB4 = new SortedList();
		LrtX0DA8hB = 0;
		FJ4Xcix2qX = 0L;
		nAGX7xmRla = null;
		H7OXGD3u4o = null;
		gdVXzLpmFn = 0L;
		pFbL4GFCxN = 0;
		JuXLXoylr9 = false;
		UMfLLMhjsW = false;
		xxTLjqsIyc = 0;
		kmMLYtJYQA = IntPtr.Zero;
		BHrLqlqpnf = false;
		EqCLuRx6Uh = new Hashtable();
		EmjL2EIOHO = null;
		WetLEh0vjZ = null;
		EH2LQm6EoG = null;
		iV9LySA4ws = null;
		SR5L6ri5ZL = null;
		IlNLU47OFO = null;
		bG5Ll1XcFV = IntPtr.Zero;
		M9ALkPuH0E = Encoding.Unicode.GetString(new byte[8] { 134, 123, 241, 8, 24, 98, 77, 199 });
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void do764OGQr3()
	{
	}

	internal static byte[] AiX8cbwgv(byte[] byte_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_0.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(byte_0.Length + num / 8u + 8L);
		ulong num3 = (ulong)(byte_0.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array2[i] = byte_0[i];
		}
		array2[byte_0.Length] |= 128;
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
			u6vxgaAx1(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			u6vxgaAx1(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			u6vxgaAx1(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			u6vxgaAx1(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			u6vxgaAx1(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			u6vxgaAx1(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			u6vxgaAx1(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			u6vxgaAx1(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			u6vxgaAx1(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			u6vxgaAx1(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			u6vxgaAx1(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			u6vxgaAx1(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			u6vxgaAx1(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			u6vxgaAx1(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			u6vxgaAx1(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			u6vxgaAx1(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			ItWMnvnvC(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			ItWMnvnvC(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			ItWMnvnvC(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			ItWMnvnvC(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			ItWMnvnvC(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			ItWMnvnvC(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			ItWMnvnvC(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			ItWMnvnvC(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			ItWMnvnvC(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			ItWMnvnvC(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			ItWMnvnvC(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			ItWMnvnvC(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			ItWMnvnvC(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			ItWMnvnvC(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			ItWMnvnvC(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			ItWMnvnvC(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			Xk3NrHWAR(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			Xk3NrHWAR(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			Xk3NrHWAR(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			Xk3NrHWAR(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			Xk3NrHWAR(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			Xk3NrHWAR(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			Xk3NrHWAR(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			Xk3NrHWAR(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			Xk3NrHWAR(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			Xk3NrHWAR(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			Xk3NrHWAR(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			Xk3NrHWAR(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			Xk3NrHWAR(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			Xk3NrHWAR(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			Xk3NrHWAR(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			Xk3NrHWAR(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			XAZoZnm0q(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			XAZoZnm0q(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			XAZoZnm0q(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			XAZoZnm0q(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			XAZoZnm0q(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			XAZoZnm0q(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			XAZoZnm0q(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			XAZoZnm0q(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			XAZoZnm0q(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			XAZoZnm0q(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			XAZoZnm0q(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			XAZoZnm0q(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			XAZoZnm0q(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			XAZoZnm0q(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			XAZoZnm0q(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			XAZoZnm0q(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void u6vxgaAx1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + CBsHWnusb(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + XgxXVMFk31[uint_5 - 1], ushort_0);
	}

	private static void ItWMnvnvC(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + CBsHWnusb(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + XgxXVMFk31[uint_5 - 1], ushort_0);
	}

	private static void Xk3NrHWAR(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + CBsHWnusb(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + XgxXVMFk31[uint_5 - 1], ushort_0);
	}

	private static void XAZoZnm0q(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + CBsHWnusb(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + XgxXVMFk31[uint_5 - 1], ushort_0);
	}

	private static uint CBsHWnusb(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool meibuY3Eo()
	{
		if (!ukmXpsAq6i)
		{
			DhS0qJdeu();
			ukmXpsAq6i = true;
		}
		return uHwXfZiUdx;
	}

	internal sMk8wArgfJX2hbRXDA()
	{
	}

	private void M1K1O167t(byte[] byte_0, byte[] byte_1, byte[] byte_2)
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
			num13 += 782534032;
			num13 ^= num13 << 17;
			num13 += 1181948218;
			num13 ^= num13 >> 15;
			num13 += 459487897;
			num13 = 1149358048 + num13;
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
		pk6X8hrgCJ = array;
	}

	internal static SymmetricAlgorithm F30vPXJLc()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (meibuY3Eo())
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

	internal static void DhS0qJdeu()
	{
		try
		{
			uHwXfZiUdx = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] jZHcAMR0w(byte[] byte_0)
	{
		if (!meibuY3Eo())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return AiX8cbwgv(byte_0);
	}

	internal static void uN57UJGEU(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			srJGB0VZA(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void srJGB0VZA(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint uf6zVSFXJ(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	public static void s09X4sFkPg(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (KkFXnULU0I == null)
			{
				lock (F5KXt60g5f)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(sMk8wArgfJX2hbRXDA).Assembly.GetManifestResourceStream("PJSe9t6X4ruKVOFVnX.Xsn0olUhRHrPmTbnso"));
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
							num3 += n8GXjNERRq(num3);
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
						vm4PJULCoMilxHZamU9 vm4PJULCoMilxHZamU = new vm4PJULCoMilxHZamU9(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = vm4PJULCoMilxHZamU.VyOLi7gcJl();
							int value = vm4PJULCoMilxHZamU.VyOLi7gcJl();
							dictionary.Add(key, value);
						}
						vm4PJULCoMilxHZamU.OdpLFVIwTX();
					}
					KkFXnULU0I = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = KkFXnULU0I[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)typeof(sMk8wArgfJX2hbRXDA).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint iZ1XLTGHL7(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint n8GXjNERRq(uint uint_0)
	{
		return 0u;
	}

	internal static void s7xXYO9ZwT()
	{
	}

	private static void gDMXq2pBUs(Stream stream_0, int int_0)
	{
		YaR6B3jqiDjRqAqog9K.xTcjyDGW5Q(0, new object[2] { stream_0, int_0 }, null);
	}

	internal static string N5lXuuIcUm(int int_0)
	{
		if (pk6X8hrgCJ.Length == 0)
		{
			IeGXrf7axG = new List<string>();
			aiCXKGYM99 = new List<int>();
			gDMXq2pBUs(oEXXasARI1.GetManifestResourceStream("bu3MIOXnxsSVhwJ98I.gyDyBGLPKD26xGX6So"), int_0);
		}
		if (voUXBdC5DG < 75)
		{
			if (oEXXasARI1 != new StackFrame(1).GetMethod()!.DeclaringType!.Assembly)
			{
				throw new Exception();
			}
			voUXBdC5DG++;
		}
		lock (uxtXWsKyWu)
		{
			int num = BitConverter.ToInt32(pk6X8hrgCJ, int_0);
			if (num < aiCXKGYM99.Count && aiCXKGYM99[num] == int_0)
			{
				return IeGXrf7axG[num];
			}
			try
			{
				G52OZvLpTmMvK1xL9qs.SPbLP0A2fp();
				byte[] array = new byte[num];
				Array.Copy(pk6X8hrgCJ, int_0 + 4, array, 0, num);
				string @string = Encoding.Unicode.GetString(array, 0, array.Length);
				IeGXrf7axG.Add(@string);
				aiCXKGYM99.Add(int_0);
				Array.Copy(BitConverter.GetBytes(IeGXrf7axG.Count - 1), 0, pk6X8hrgCJ, int_0, 4);
				return @string;
			}
			catch
			{
			}
		}
		return "";
	}

	internal static string zWPX2o4NRj(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int uNIXE1t1y3()
	{
		return 5;
	}

	private static void TvgXQZTfD0()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate u4TXytaujx(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object QQ9X6QOBTE(object object_0)
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

	private static IntPtr f8kXkUQK8e(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (EmjL2EIOHO == null)
		{
			EmjL2EIOHO = (HeF0lVLSQmsr69pHxgO)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Find ".Trim() + "ResourceA"), typeof(HeF0lVLSQmsr69pHxgO));
		}
		return EmjL2EIOHO(intptr_0, string_0, uint_0);
	}

	private static IntPtr ajeXdmt9h0(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (WetLEh0vjZ == null)
		{
			WetLEh0vjZ = (qWnb51LABfiB1rEQKU5)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Virtual ".Trim() + "Alloc"), typeof(qWnb51LABfiB1rEQKU5));
		}
		return WetLEh0vjZ(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int KsnXOJOdjH(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (EH2LQm6EoG == null)
		{
			EH2LQm6EoG = (TrbTpuLIiS6qUHEn74A)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(TrbTpuLIiS6qUHEn74A));
		}
		return EH2LQm6EoG(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int lbLXm0LdsM(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (iV9LySA4ws == null)
		{
			iV9LySA4ws = (RUngd6Ls8dt6somPopQ)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Virtual ".Trim() + "Protect"), typeof(RUngd6Ls8dt6somPopQ));
		}
		return iV9LySA4ws(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr RpfXh4gDKB(uint uint_0, int int_0, uint uint_1)
	{
		if (SR5L6ri5ZL == null)
		{
			SR5L6ri5ZL = (deKqkcLwnjioS7Yb98W)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Open ".Trim() + "Process"), typeof(deKqkcLwnjioS7Yb98W));
		}
		return SR5L6ri5ZL(uint_0, int_0, uint_1);
	}

	private static int rTsXR6ZN20(IntPtr intptr_0)
	{
		if (IlNLU47OFO == null)
		{
			IlNLU47OFO = (do7lrjLa9L0CECp38oH)Marshal.GetDelegateForFunctionPointer(GetProcAddress(pZbnhv6YB(), "Close ".Trim() + "Handle"), typeof(do7lrjLa9L0CECp38oH));
		}
		return IlNLU47OFO(intptr_0);
	}

	[SpecialName]
	private static IntPtr pZbnhv6YB()
	{
		if (bG5Ll1XcFV == IntPtr.Zero)
		{
			bG5Ll1XcFV = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return bG5Ll1XcFV;
	}

	private static byte[] U9NXZOLSdW(string string_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	internal static Stream E3YX50JDcl()
	{
		return new MemoryStream();
	}

	internal static byte[] iPgXgbB5Xs(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	private static byte[] F6CX96c1Hx(byte[] byte_0)
	{
		Stream stream = E3YX50JDcl();
		SymmetricAlgorithm symmetricAlgorithm = F30vPXJLc();
		symmetricAlgorithm.Key = new byte[32]
		{
			42, 155, 17, 88, 223, 253, 137, 103, 166, 134,
			160, 166, 185, 90, 234, 217, 20, 19, 133, 225,
			62, 2, 145, 101, 164, 223, 140, 130, 83, 56,
			176, 77
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			172, 176, 227, 105, 224, 11, 110, 169, 161, 55,
			123, 85, 141, 166, 86, 105
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = iPgXgbB5Xs(stream);
		G52OZvLpTmMvK1xL9qs.SPbLP0A2fp();
		return result;
	}

	private unsafe static int VlmXDVhSRj(string string_0)
	{
		fixed (char* ptr = string_0)
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

	internal static bool eikX3dFjtE(string string_0, string string_1)
	{
		if (string_0 == string_1)
		{
			return true;
		}
		if (string_0 != null && string_1 != null)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			if (string_0.StartsWith(M9ALkPuH0E))
			{
				flag = true;
				num = (int)(string_0[4] | ((uint)string_0[5] << 8) | ((uint)string_0[6] << 16) | ((uint)string_0[7] << 24));
			}
			if (string_1.StartsWith(M9ALkPuH0E))
			{
				flag2 = true;
				num2 = (int)(string_1[4] | ((uint)string_1[5] << 8) | ((uint)string_1[6] << 16) | ((uint)string_1[7] << 24));
			}
			if (!flag && !flag2)
			{
				return false;
			}
			if (!flag)
			{
				num = VlmXDVhSRj(string_0);
			}
			if (!flag2)
			{
				num2 = VlmXDVhSRj(string_1);
			}
			return num == num2;
		}
		return false;
	}

	private byte[] mXbXCLIaUb()
	{
		return null;
	}

	private byte[] UDKXTF7g7v()
	{
		return null;
	}

	private byte[] vEYXJvw9Ww()
	{
		_ = "{11111-22222-20001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] zM4XiQ4AHC()
	{
		_ = "{11111-22222-20001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] VWHXFDMtFb()
	{
		_ = "{11111-22222-30001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	private byte[] lw8Xehj2tP()
	{
		_ = "{11111-22222-30001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] v9tXSJR88J()
	{
		_ = "{11111-22222-40001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] WWnXAinsnd()
	{
		_ = "{11111-22222-40001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] wMXXIGKYM3()
	{
		return null;
	}

	internal byte[] s2ZXsR2Caj()
	{
		return null;
	}

	internal static object spkqq3ythjP1ZDBUw3Y(object object_0)
	{
		return ((vm4PJULCoMilxHZamU9)object_0).m9OIO8Q0EK();
	}

	internal static void heo476yBKwicywE6U1I(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long LUMyUYyWRi0cabN0FD7(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object SIMbIlyrajq4ZJvfbib(object object_0, int int_0)
	{
		return ((vm4PJULCoMilxHZamU9)object_0).C9WLTUhMOM(int_0);
	}

	internal static void Xl87bcyK4F2mK32VLby(object object_0)
	{
		((vm4PJULCoMilxHZamU9)object_0).OdpLFVIwTX();
	}

	internal static void eiNx6gy8ZitROprYUHf(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object D6SU2MyxvaGw4B1dUCO(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object v6H3f6yMWNLfXf80Zld(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object cIYlceyNwwSgsaF684X()
	{
		return F30vPXJLc();
	}

	internal static void Jy58kLyoLClvD2U668p(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object TIGWWJyHOyCmN2UmlJX(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object qXUFh6yb5DZyKNDJ3Jg()
	{
		return E3YX50JDcl();
	}

	internal static void r3uDGDy1e84mFM0jHX3(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void NHqOabyv7U5q28idS9o(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object VNQIwny0cfYBjDSkLZw(object object_0)
	{
		return iPgXgbB5Xs((Stream)object_0);
	}

	internal static void I39XckyciLG6jmZuhIL(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static object kauUN5y71oNxsU3KV6k(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool SoNbrPyGW22agEqNN5H(object object_0, object object_1)
	{
		return (MethodInfo?)object_0 == (MethodInfo?)object_1;
	}

	internal static bool PCAgaHyPT2JaQhDVGNA()
	{
		return (object)null == null;
	}

	internal static object Y0fvupyn5MGeYDLOHQI()
	{
		return null;
	}
}
