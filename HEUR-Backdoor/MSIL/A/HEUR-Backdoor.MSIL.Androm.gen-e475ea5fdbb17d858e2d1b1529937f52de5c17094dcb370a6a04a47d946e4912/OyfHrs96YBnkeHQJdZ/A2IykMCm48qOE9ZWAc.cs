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
using WEVFYJ2WPuik8y16vgG;
using piO3af2M2LrtQb05a7e;

namespace OyfHrs96YBnkeHQJdZ;

internal class A2IykMCm48qOE9ZWAc
{
	private delegate void Le8VORu2bnvmm8jLnK(object o);

	internal class gnI6sxzI8jSqnkUott : Attribute
	{
		internal class LaQsCy2ZuWVBEIlgxs3<k2tEEM22UOXT8IjPkfW>
		{
			internal static object ouGTMlwnUB;

			public LaQsCy2ZuWVBEIlgxs3()
			{
				SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
				qrfVDV24YoTFkucSFup.SUCTSny3c8();
				base._002Ector();
			}

			internal static bool MpHTDWuH1Y()
			{
				return ouGTMlwnUB == null;
			}

			internal static object hpZT4D1BUr()
			{
				return ouGTMlwnUB;
			}

			static LaQsCy2ZuWVBEIlgxs3()
			{
				nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
			}
		}

		[gnI6sxzI8jSqnkUott(typeof(LaQsCy2ZuWVBEIlgxs3<object>[]))]
		public gnI6sxzI8jSqnkUott(object object_0)
		{
			SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
			base._002Ector();
		}

		static gnI6sxzI8jSqnkUott()
		{
			nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		}
	}

	internal class LZr4uv2IG2UtJQtDGCl
	{
		[gnI6sxzI8jSqnkUott(typeof(gnI6sxzI8jSqnkUott.LaQsCy2ZuWVBEIlgxs3<object>[]))]
		internal static string TRiTsfRng5(string string_0, string string_1)
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
			byte[] iV = qKgIHA9nKW((byte[])lGLTPpRCMp(Encoding.Unicode, string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)uZLT52uPSv();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream object_ = new CryptoStream(memoryStream, (ICryptoTransform)UpeTJRP9h2(symmetricAlgorithm), CryptoStreamMode.Write);
			X9aTWnWs4u(object_, array, 0, array.Length);
			mYfTjHgDSC(object_);
			return Convert.ToBase64String((byte[])aFATvpnJT0(memoryStream));
		}

		public LZr4uv2IG2UtJQtDGCl()
		{
			SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
			base._002Ector();
		}

		internal static object lGLTPpRCMp(object object_0, object object_1)
		{
			return ((Encoding)object_0).GetBytes((string)object_1);
		}

		internal static object uZLT52uPSv()
		{
			return Jf2ILLrtQb();
		}

		internal static object UpeTJRP9h2(object object_0)
		{
			return ((SymmetricAlgorithm)object_0).CreateEncryptor();
		}

		internal static void X9aTWnWs4u(object object_0, object object_1, int int_0, int int_1)
		{
			((Stream)object_0).Write((byte[])object_1, int_0, int_1);
		}

		internal static void mYfTjHgDSC(object object_0)
		{
			((Stream)object_0).Close();
		}

		internal static object aFATvpnJT0(object object_0)
		{
			return ((MemoryStream)object_0).ToArray();
		}

		static LZr4uv2IG2UtJQtDGCl()
		{
			nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Sitycg2fsbqa2FSsRQ8(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr QopcOt2TJiMvWBpfyky();

	internal struct FLGJqB2oIEQTRBIFPcN
	{
		internal bool qEATB3nXtj;

		internal byte[] PCNTn061Sc;
	}

	internal class nOF66j2qTbuEGTBokrT
	{
		private BinaryReader vAOTlguNj3;

		public nOF66j2qTbuEGTBokrT(Stream stream_0)
		{
			SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
			base._002Ector();
			vAOTlguNj3 = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return (Stream)yUOTNTjNT8(vAOTlguNj3);
		}

		internal byte[] tBBTyVElZZ(int int_0)
		{
			return (byte[])EL9TOtTNVd(vAOTlguNj3, int_0);
		}

		internal int QwnT3Kn40R(byte[] byte_0, int int_0, int int_1)
		{
			return vAOTlguNj3.Read(byte_0, int_0, int_1);
		}

		internal int FDtTUSdErP()
		{
			return vAOTlguNj3.ReadInt32();
		}

		internal void g5LTKcDWTr()
		{
			vAOTlguNj3.Close();
		}

		internal static object yUOTNTjNT8(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static object EL9TOtTNVd(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		static nOF66j2qTbuEGTBokrT()
		{
			nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr hEPRb32YEWMiE7qYtuq(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr r3tCmk2pD1VKim0bdsk(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int C3ivIx2EtVSoDAJEKKC(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int imaSrN2mEovqwIsZ8N7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr m1y4t528FvVr61oUd4T(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int FuTGGs26m21gKTJbu6P(IntPtr ptr);

	[Flags]
	private enum YHPWAH2Dw7nsVlWdkUR
	{

	}

	private static byte[] ih6fijKmOj;

	private static int R6Vfw3a4aa;

	private static bool HRYf03QeHc;

	private static hEPRb32YEWMiE7qYtuq bINftEPXkV;

	private static object FQofkvDD4Y;

	internal static Hashtable xOpfFHr1Pw;

	private static IntPtr u4qfCagkjC;

	private static long OT9f9DftNR;

	private static long AkFfzSvEmN;

	private static int TLsTZynoW9;

	private static bool CNuT2wwM6q;

	private static object dj8TfHHABt;

	private static imaSrN2mEovqwIsZ8N7 mPFTo8ioow;

	private static bool Kg6TYGlTeG;

	internal static Sitycg2fsbqa2FSsRQ8 CpNT85TGD1;

	private static byte[] Q1RfHyyJ1Q;

	[gnI6sxzI8jSqnkUott(typeof(gnI6sxzI8jSqnkUott.LaQsCy2ZuWVBEIlgxs3<object>[]))]
	private static bool uC6fQ617Ih;

	private static bool lavf7OgUE0;

	private static C3ivIx2EtVSoDAJEKKC J3LfdDl5xA;

	private static int jDefr41sV9;

	private static uint[] vKafAAcEbp;

	private static bool Qw7fcVLbk7;

	private static FuTGGs26m21gKTJbu6P urlTIlSr9P;

	internal static RSACryptoServiceProvider Lp1TEQH4ZU;

	internal static Sitycg2fsbqa2FSsRQ8 enWfu8FxPO;

	private static IntPtr yhtTmG42LX;

	private static Dictionary<int, int> tZATTnpsXF;

	private static IntPtr KHLfbxpZjB;

	private static SortedList YXBT6N1iQZ;

	private static r3tCmk2pD1VKim0bdsk RkGTpuXTvl;

	private static byte[] ecUfaPBirc;

	internal static Assembly am4fLYWQuK;

	private static bool eEefg7T07W;

	private static int[] n0ofGNKj3h;

	private static int V75fXhCIcT;

	private static IntPtr JrLTqncTEY;

	private static m1y4t528FvVr61oUd4T Cl5fRPKeul;

	static A2IykMCm48qOE9ZWAc()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		lavf7OgUE0 = false;
		am4fLYWQuK = Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554468)).Assembly;
		vKafAAcEbp = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		eEefg7T07W = false;
		CNuT2wwM6q = false;
		Q1RfHyyJ1Q = new byte[0];
		Lp1TEQH4ZU = null;
		tZATTnpsXF = null;
		FQofkvDD4Y = new object();
		ecUfaPBirc = new byte[0];
		ih6fijKmOj = new byte[0];
		yhtTmG42LX = IntPtr.Zero;
		u4qfCagkjC = IntPtr.Zero;
		dj8TfHHABt = new string[0];
		n0ofGNKj3h = new int[0];
		V75fXhCIcT = 1;
		Qw7fcVLbk7 = false;
		YXBT6N1iQZ = new SortedList();
		jDefr41sV9 = 0;
		AkFfzSvEmN = 0L;
		CpNT85TGD1 = null;
		enWfu8FxPO = null;
		OT9f9DftNR = 0L;
		R6Vfw3a4aa = 0;
		Kg6TYGlTeG = false;
		HRYf03QeHc = false;
		TLsTZynoW9 = 0;
		JrLTqncTEY = IntPtr.Zero;
		uC6fQ617Ih = false;
		xOpfFHr1Pw = new Hashtable();
		bINftEPXkV = null;
		RkGTpuXTvl = null;
		J3LfdDl5xA = null;
		mPFTo8ioow = null;
		Cl5fRPKeul = null;
		urlTIlSr9P = null;
		KHLfbxpZjB = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void Dr6Il1oUd4()
	{
	}

	internal static byte[] eeuISTGGsm(byte[] byte_0)
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
			a1gI1KTJbu(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			a1gI1KTJbu(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			a1gI1KTJbu(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			a1gI1KTJbu(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			a1gI1KTJbu(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			a1gI1KTJbu(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			a1gI1KTJbu(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			a1gI1KTJbu(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			a1gI1KTJbu(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			a1gI1KTJbu(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			a1gI1KTJbu(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			a1gI1KTJbu(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			a1gI1KTJbu(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			a1gI1KTJbu(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			a1gI1KTJbu(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			a1gI1KTJbu(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			kPuIxHPWAH(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			kPuIxHPWAH(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			kPuIxHPWAH(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			kPuIxHPWAH(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			kPuIxHPWAH(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			kPuIxHPWAH(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			kPuIxHPWAH(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			kPuIxHPWAH(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			kPuIxHPWAH(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			kPuIxHPWAH(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			kPuIxHPWAH(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			kPuIxHPWAH(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			kPuIxHPWAH(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			kPuIxHPWAH(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			kPuIxHPWAH(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			kPuIxHPWAH(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			M7nIVsVlWd(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			M7nIVsVlWd(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			M7nIVsVlWd(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			M7nIVsVlWd(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			M7nIVsVlWd(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			M7nIVsVlWd(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			M7nIVsVlWd(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			M7nIVsVlWd(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			M7nIVsVlWd(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			M7nIVsVlWd(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			M7nIVsVlWd(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			M7nIVsVlWd(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			M7nIVsVlWd(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			M7nIVsVlWd(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			M7nIVsVlWd(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			M7nIVsVlWd(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			SURIhJrfVD(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			SURIhJrfVD(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			SURIhJrfVD(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			SURIhJrfVD(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			SURIhJrfVD(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			SURIhJrfVD(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			SURIhJrfVD(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			SURIhJrfVD(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			SURIhJrfVD(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			SURIhJrfVD(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			SURIhJrfVD(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			SURIhJrfVD(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			SURIhJrfVD(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			SURIhJrfVD(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			SURIhJrfVD(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			SURIhJrfVD(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void a1gI1KTJbu(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + EYoIeTFkuc(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + vKafAAcEbp[uint_5 - 1], ushort_0);
	}

	private static void kPuIxHPWAH(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + EYoIeTFkuc(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + vKafAAcEbp[uint_5 - 1], ushort_0);
	}

	private static void M7nIVsVlWd(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + EYoIeTFkuc(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + vKafAAcEbp[uint_5 - 1], ushort_0);
	}

	private static void SURIhJrfVD(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + EYoIeTFkuc(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + vKafAAcEbp[uint_5 - 1], ushort_0);
	}

	private static uint EYoIeTFkuc(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool BFuI7p5iO3()
	{
		if (!eEefg7T07W)
		{
			N5aIA7ewsk();
			eEefg7T07W = true;
		}
		return CNuT2wwM6q;
	}

	internal static SymmetricAlgorithm Jf2ILLrtQb()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (BFuI7p5iO3())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance(nohvtg2Jq63jo2SldqX.fbxTrwhohj(0), nohvtg2Jq63jo2SldqX.fbxTrwhohj(160))!.Unwrap();
		}
	}

	internal static void N5aIA7ewsk()
	{
		try
		{
			CNuT2wwM6q = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] qKgIHA9nKW(byte[] byte_0)
	{
		if (!BFuI7p5iO3())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return eeuISTGGsm(byte_0);
	}

	internal static void f0QIaMJEuA(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			ESXIiZyM0A(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void ESXIiZyM0A(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint NdVIGK7fsD(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	public static void JjyIcof7vk(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (tZATTnpsXF == null)
			{
				lock (FQofkvDD4Y)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554468)).Assembly.GetManifestResourceStream(nohvtg2Jq63jo2SldqX.fbxTrwhohj(270)));
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
							num3 += nohI0vtgq6(num3);
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
						nOF66j2qTbuEGTBokrT nOF66j2qTbuEGTBokrT = new nOF66j2qTbuEGTBokrT(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = nOF66j2qTbuEGTBokrT.FDtTUSdErP();
							int value = nOF66j2qTbuEGTBokrT.FDtTUSdErP();
							dictionary.Add(key, value);
						}
						nOF66j2qTbuEGTBokrT.g5LTKcDWTr();
					}
					tZATTnpsXF = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = tZATTnpsXF[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554468)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint RxHIwKsksa(uint uint_0)
	{
		return (uint)nohvtg2Jq63jo2SldqX.fbxTrwhohj(348).Length;
	}

	private static uint nohI0vtgq6(uint uint_0)
	{
		return 0u;
	}

	internal static void vjoId2Sldq()
	{
	}

	[gnI6sxzI8jSqnkUott(typeof(gnI6sxzI8jSqnkUott.LaQsCy2ZuWVBEIlgxs3<object>[]))]
	internal static string VCEIRVFYJP(int int_0)
	{
		int num = 330;
		int num4 = default(int);
		string result = default(string);
		int int_ = default(int);
		int num6 = default(int);
		uint num22 = default(uint);
		uint num17 = default(uint);
		uint num12 = default(uint);
		int num7 = default(int);
		byte[] array = default(byte[]);
		int num10 = default(int);
		byte[] array2 = default(byte[]);
		int num9 = default(int);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		Stream stream = default(Stream);
		int num8 = default(int);
		int num21 = default(int);
		byte[] array4 = default(byte[]);
		int num20 = default(int);
		int num23 = default(int);
		uint num11 = default(uint);
		int num30 = default(int);
		int num28 = default(int);
		byte[] array6 = default(byte[]);
		int num13 = default(int);
		uint num27 = default(uint);
		uint num19 = default(uint);
		int num18 = default(int);
		int num16 = default(int);
		int num29 = default(int);
		uint num14 = default(uint);
		byte[] array3 = default(byte[]);
		CryptoStream object_2 = default(CryptoStream);
		uint num24 = default(uint);
		nOF66j2qTbuEGTBokrT object_ = default(nOF66j2qTbuEGTBokrT);
		int num15 = default(int);
		while (true)
		{
			int num2;
			if (ecUfaPBirc.Length == 0)
			{
				num2 = 329;
				if (!REhfhlrgeF())
				{
					goto IL_003a;
				}
				goto IL_2065;
			}
			goto IL_26f8;
			IL_2705:
			try
			{
				rkcf1Sinrt();
				int num3 = 0;
				if (pMDfeuRl8N() != null)
				{
					num3 = num4;
				}
				do
				{
					switch (num3)
					{
					case 1:
						return result;
					}
					result = (string)xYafVC4jrA(Dn0fxy9YaQ(), ecUfaPBirc, int_0 + 4, int_);
					num3 = 1;
				}
				while (pMDfeuRl8N() != null);
				return result;
			}
			catch
			{
				int num5 = 0;
				if (pMDfeuRl8N() != null)
				{
					num5 = num6;
				}
				switch (num5)
				{
				}
			}
			break;
			IL_2065:
			while (true)
			{
				switch (num2)
				{
				case 412:
					num22 = 0u;
					goto case 239;
				case 239:
					num17 += num12;
					num2 = 363;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 411:
					num7 = 80;
					goto case 81;
				case 81:
					array[2] = (byte)num7;
					goto case 23;
				case 23:
					num7 = 229;
					goto case 390;
				case 390:
					array[2] = (byte)num7;
					goto case 107;
				case 107:
					num7 = 92;
					num = 200;
					goto case 200;
				case 200:
					array[3] = (byte)num7;
					goto case 127;
				case 127:
					array[3] = 85;
					goto case 36;
				case 36:
					array[3] = 160;
					num2 = 55;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 410:
					array[13] = 129;
					num = 254;
					goto case 254;
				case 254:
					array[13] = 244;
					goto case 41;
				case 41:
					array[14] = 138;
					goto case 162;
				case 162:
					num10 = 120;
					goto case 323;
				case 323:
					array[14] = (byte)num10;
					goto case 216;
				case 216:
					num7 = 151;
					num = 178;
					goto case 178;
				case 178:
					array[14] = (byte)num7;
					num2 = 240;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 409:
					array2[19] = (byte)num9;
					num2 = 76;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 408:
					array2[19] = (byte)num9;
					num2 = 37;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 98;
				case 98:
					array2[19] = 24;
					num2 = 186;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 407:
					array[7] = 183;
					num2 = 112;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 406:
					array2[22] = 157;
					goto case 399;
				case 399:
					array2[22] = 126;
					goto case 322;
				case 322:
					array2[22] = 221;
					num2 = 5;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 405:
					if (int_0 == -1)
					{
						num2 = 97;
						if (!REhfhlrgeF())
						{
							continue;
						}
						goto case 247;
					}
					goto case 77;
				case 247:
					object_3 = (SymmetricAlgorithm)Sq8fnQq3o8();
					goto case 396;
				case 396:
					msPfybj91r(object_3, CipherMode.CBC);
					num = 11;
					goto case 11;
				case 11:
					transform = (ICryptoTransform)DdKf3BAsuQ(object_3, array5, array7);
					goto case 373;
				case 373:
					stream = (Stream)Ub5fUUDV1d();
					num2 = 204;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 141;
				case 141:
					array2[7] = 92;
					num = 84;
					goto case 84;
				case 84:
					num9 = 150;
					goto case 19;
				case 19:
					array2[7] = (byte)num9;
					num = 95;
					goto case 95;
				case 95:
					num8 = 3;
					goto case 269;
				case 269:
					array2[7] = (byte)num8;
					goto case 31;
				case 31:
					num9 = 153;
					goto case 9;
				case 9:
					array2[8] = (byte)num9;
					goto case 298;
				case 298:
					num8 = 183;
					goto case 257;
				case 257:
					array2[8] = (byte)num8;
					goto case 328;
				case 328:
					num9 = 115;
					num2 = 87;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 77:
					num21 = array4.Length % 4;
					goto case 212;
				case 212:
					num20 = array4.Length / 4;
					num2 = 111;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 404:
					array2[10] = (byte)num8;
					num = 93;
					goto case 93;
				case 93:
					array2[10] = 180;
					num2 = 150;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 403:
					if (num23 > 0)
					{
						goto case 131;
					}
					goto case 58;
				case 131:
					num22 <<= 8;
					num2 = 58;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 58:
					num22 |= array4[^(1 + num23)];
					goto case 147;
				case 147:
					num23++;
					num2 = 177;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 402:
					array2[3] = (byte)num8;
					goto case 100;
				case 100:
					array2[3] = 144;
					num = 297;
					goto case 297;
				case 297:
					num8 = 163;
					num2 = 389;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 295;
				case 295:
					num9 = 142;
					num2 = 173;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 52;
				case 52:
					array[5] = 111;
					goto case 238;
				case 238:
					array[5] = 211;
					num2 = 62;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 119;
				case 119:
					array[6] = 96;
					goto case 110;
				case 110:
					num10 = 27;
					goto case 291;
				case 291:
					array[6] = (byte)num10;
					goto case 388;
				case 388:
					num10 = 102;
					num2 = 155;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 401:
					array2[2] = (byte)num8;
					goto case 317;
				case 317:
					num9 = 249;
					goto case 163;
				case 163:
					array2[2] = (byte)num9;
					num2 = 69;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 400:
					num22 = 0u;
					goto case 92;
				case 92:
					if (num21 > 0)
					{
						goto case 336;
					}
					goto case 357;
				case 336:
					num20++;
					goto case 357;
				case 357:
					num11 = 0u;
					num2 = 237;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 398:
					num11 = (uint)(num30 * 4);
					num2 = 101;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 397:
					num8 = 70;
					goto case 29;
				case 29:
					array2[16] = (byte)num8;
					num2 = 30;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 381;
				case 381:
					array2[16] = 167;
					num2 = 225;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 395:
					num9 = 143;
					goto case 40;
				case 40:
					array2[28] = (byte)num9;
					num = 167;
					goto case 167;
				case 167:
					array2[29] = 172;
					goto case 243;
				case 243:
					array2[29] = 197;
					goto case 219;
				case 219:
					num8 = 206;
					num2 = 366;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 127;
				case 394:
					num28++;
					goto case 54;
				case 331:
					if (num28 <= 0)
					{
						goto case 197;
					}
					goto case 2;
				case 197:
					array6[num13 + num28] = (byte)((num27 & num19) >> num18);
					goto case 394;
				case 54:
				case 339:
					if (num28 < num21)
					{
						goto case 331;
					}
					goto case 139;
				case 139:
				case 231:
					num16++;
					goto case 251;
				case 251:
				case 382:
					if (num16 < num20)
					{
						goto case 3;
					}
					goto case 152;
				case 3:
					num30 = num16 % num29;
					goto case 191;
				case 191:
					num13 = num16 * 4;
					goto case 398;
				case 2:
					num19 <<= 8;
					num2 = 294;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 393:
					array2[13] = (byte)num9;
					num = 280;
					goto case 280;
				case 280:
					array2[13] = 88;
					goto case 248;
				case 248:
					array2[13] = 81;
					goto case 198;
				case 198:
					array2[13] = 153;
					num2 = 314;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 163;
				case 392:
					array2[17] = 81;
					num2 = 140;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 86;
				case 86:
					num8 = 211;
					goto case 402;
				case 391:
					array2[8] = 98;
					num2 = 109;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 389:
					array2[3] = (byte)num8;
					goto case 187;
				case 187:
					num9 = 155;
					goto case 99;
				case 99:
					array2[3] = (byte)num9;
					num2 = 318;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 387:
					num9 = 145;
					num2 = 220;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 59;
				case 59:
					array[1] = (byte)num7;
					num2 = 255;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 386:
					num7 = 204;
					num = 188;
					goto case 188;
				case 188:
					array[12] = (byte)num7;
					goto case 143;
				case 143:
					array[13] = 160;
					goto case 199;
				case 199:
					array[13] = 130;
					goto case 410;
				case 385:
					num12 = 0u;
					goto case 400;
				case 384:
					array6[num13 + 3] = (byte)((num14 & 0xFF000000u) >> 24);
					goto case 139;
				case 383:
					array[4] = 33;
					goto case 319;
				case 319:
					num7 = 218;
					num2 = 157;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 380:
					array2[20] = 148;
					num2 = 106;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 379:
					array2[8] = (byte)num9;
					num2 = 108;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 117;
				case 117:
					num8 = 111;
					num = 359;
					goto case 359;
				case 359:
					array2[8] = (byte)num8;
					num2 = 391;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 193;
				case 193:
					array2[5] = (byte)num9;
					goto case 73;
				case 73:
					num9 = 94;
					goto case 72;
				case 72:
					array2[5] = (byte)num9;
					goto case 207;
				case 207:
					array2[5] = 56;
					num2 = 338;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 325;
				case 325:
					array2[25] = 109;
					goto case 289;
				case 289:
					array2[26] = 169;
					goto case 42;
				case 42:
					array2[26] = 166;
					num2 = 166;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 37;
				case 37:
					num8 = 201;
					goto case 401;
				case 378:
					array2[14] = (byte)num9;
					goto case 221;
				case 221:
					num8 = 125;
					num = 24;
					goto case 24;
				case 24:
					array2[14] = (byte)num8;
					num2 = 267;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 377:
					array2[15] = (byte)num8;
					num = 189;
					goto case 189;
				case 189:
					num9 = 172;
					goto case 283;
				case 283:
					array2[16] = (byte)num9;
					goto case 272;
				case 272:
					num8 = 156;
					goto case 145;
				case 145:
					array2[16] = (byte)num8;
					goto case 149;
				case 149:
					array2[16] = 98;
					goto case 397;
				case 376:
					num8 = 96;
					goto case 179;
				case 179:
					array2[4] = (byte)num8;
					num2 = 263;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 375:
					num29 = array5.Length / 4;
					num2 = 282;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 374:
					array[7] = 154;
					num2 = 39;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 27;
				case 27:
					num8 = 89;
					goto case 275;
				case 275:
					array2[9] = (byte)num8;
					num = 350;
					goto case 350;
				case 350:
					array2[9] = 130;
					goto case 360;
				case 360:
					array2[9] = 116;
					num2 = 210;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 372:
					array[7] = (byte)num10;
					goto case 168;
				case 168:
					num7 = 106;
					num2 = 15;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 371:
					array3 = (byte[])RdkfBRi2wG(kvqfvVwjhQ(am4fLYWQuK));
					num2 = 28;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 370:
					YCWflgH4x3(object_2);
					goto case 250;
				case 250:
					array4 = ecUfaPBirc;
					goto case 77;
				case 369:
					array2[3] = (byte)num9;
					goto case 86;
				case 368:
					array2[20] = (byte)num9;
					goto case 380;
				case 367:
					array2[5] = (byte)num8;
					goto case 30;
				case 30:
					array2[5] = 151;
					goto case 364;
				case 364:
					num9 = 202;
					goto case 103;
				case 103:
					array2[5] = (byte)num9;
					num2 = 1;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 94;
				case 94:
					num9 = 100;
					goto case 245;
				case 245:
					array2[6] = (byte)num9;
					num2 = 33;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 32;
				case 32:
					num9 = 199;
					goto case 281;
				case 281:
					array2[11] = (byte)num9;
					goto case 146;
				case 146:
					array2[12] = 146;
					num2 = 1;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 366:
					array2[29] = (byte)num8;
					goto case 246;
				case 246:
					num9 = 158;
					num2 = 347;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 365:
					array[3] = (byte)num7;
					num2 = 324;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 363:
					num23 = 0;
					num = 226;
					goto case 177;
				case 177:
				case 226:
					if (num23 < num21)
					{
						goto case 403;
					}
					goto case 126;
				case 126:
				case 165:
					num24 = num17;
					num2 = 57;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 215;
				case 215:
					num17 = 0u;
					num2 = 36;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 353;
				case 353:
				{
					uint num25 = num24;
					uint num26 = num24;
					num26 ^= num26 << 16;
					num26 += 1679282545;
					num26 ^= num26 << 9;
					num26 += 529424606;
					num26 ^= num26 >> 21;
					num26 += 607166160;
					num26 = 2719095550u + num26;
					num24 = num25 + (uint)(double)num26;
					goto case 340;
				}
				case 340:
					num17 = num24;
					goto case 352;
				case 352:
					if (num16 == num20 - 1)
					{
						num = 286;
						goto case 286;
					}
					goto case 171;
				case 286:
					if (num21 > 0)
					{
						goto case 358;
					}
					goto case 171;
				case 358:
					num27 = num17 ^ num22;
					goto case 249;
				case 249:
					num28 = 0;
					goto case 54;
				case 171:
					num14 = num17 ^ num22;
					num2 = 153;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 362:
					array2[15] = (byte)num8;
					num = 356;
					goto case 356;
				case 356:
					array2[15] = 89;
					num2 = 66;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 48;
				case 48:
					array[4] = (byte)num10;
					goto case 135;
				case 135:
					array[4] = 128;
					num2 = 148;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 361:
					array2[30] = 27;
					num2 = 261;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 159;
				case 159:
					array[11] = 88;
					goto case 343;
				case 343:
					array[11] = 186;
					goto case 116;
				case 116:
					array[12] = 130;
					goto case 235;
				case 235:
					array[12] = 165;
					num2 = 15;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 386;
				case 355:
					array2[28] = (byte)num9;
					num2 = 223;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 354:
					num8 = 88;
					goto case 170;
				case 170:
					array2[1] = (byte)num8;
					num2 = 56;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 351:
					num8 = 83;
					goto case 228;
				case 228:
					array2[27] = (byte)num8;
					goto case 213;
				case 213:
					array2[27] = 111;
					goto case 344;
				case 344:
					num9 = 100;
					num2 = 142;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 349:
					array[10] = 112;
					goto case 304;
				case 304:
					array[10] = 116;
					num2 = 60;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 348:
					num8 = 110;
					num2 = 99;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 144;
				case 144:
					array2[0] = (byte)num8;
					goto case 203;
				case 203:
					array2[0] = 107;
					num = 16;
					goto case 16;
				case 16:
					array2[0] = 128;
					goto case 4;
				case 4:
					array2[0] = 41;
					goto case 38;
				case 38:
					num8 = 113;
					goto case 51;
				case 51:
					array2[1] = (byte)num8;
					goto case 120;
				case 120:
					num9 = 162;
					num2 = 53;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 347:
					array2[30] = (byte)num9;
					num = 195;
					goto case 195;
				case 195:
					num9 = 96;
					goto case 244;
				case 244:
					array2[30] = (byte)num9;
					num2 = 25;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 24;
				case 346:
					num9 = 148;
					num2 = 55;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 57;
				case 57:
					array2[17] = (byte)num9;
					goto case 264;
				case 264:
					array2[17] = 98;
					num2 = 183;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 292;
				case 292:
					array2[18] = 198;
					goto case 205;
				case 205:
					array2[18] = 37;
					num = 115;
					goto case 115;
				case 115:
					array2[18] = 94;
					goto case 302;
				case 302:
					array2[18] = 125;
					num2 = 6;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 345:
					array2[31] = 128;
					num2 = 34;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 342:
					array2[24] = (byte)num9;
					goto case 65;
				case 65:
					array2[24] = 146;
					num2 = 15;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 18;
				case 18:
					array2[24] = 178;
					num2 = 78;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 341:
					num9 = 111;
					num2 = 128;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 338:
					num8 = 35;
					goto case 367;
				case 337:
					array2[20] = 142;
					goto case 161;
				case 161:
					array2[21] = 84;
					num = 241;
					goto case 241;
				case 241:
					array2[21] = 31;
					num2 = 211;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 335:
					array[11] = (byte)num7;
					goto case 159;
				case 334:
					array2[23] = (byte)num9;
					num = 268;
					goto case 268;
				case 268:
					num8 = 83;
					goto case 222;
				case 222:
					array2[23] = (byte)num8;
					goto case 61;
				case 61:
					num9 = 106;
					goto case 342;
				case 333:
					num18 = 0;
					goto case 218;
				case 218:
					if (num16 == num20 - 1)
					{
						goto case 7;
					}
					goto case 46;
				case 7:
					if (num21 > 0)
					{
						goto case 412;
					}
					goto case 46;
				case 46:
					num17 += num12;
					num2 = 34;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 64;
				case 64:
					num11 = (uint)num13;
					goto case 172;
				case 172:
					num22 = (uint)((array4[num11 + 3] << 24) | (array4[num11 + 2] << 16) | (array4[num11 + 1] << 8) | array4[num11]);
					goto case 126;
				case 332:
					num9 = 160;
					goto case 124;
				case 124:
					array2[2] = (byte)num9;
					num2 = 270;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 329:
					object_ = new nOF66j2qTbuEGTBokrT((Stream)lhdfMHSLRk(am4fLYWQuK, nohvtg2Jq63jo2SldqX.fbxTrwhohj(402)));
					goto case 288;
				case 288:
					yxMfPAOY34(B1Lfsi1Iri(object_), 0L);
					num2 = 47;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 327:
					array[8] = (byte)num7;
					goto case 274;
				case 274:
					array[9] = 142;
					num = 97;
					goto case 97;
				case 97:
					num7 = 131;
					num2 = 12;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 324:
					array[3] = 115;
					num2 = 113;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 61;
				case 321:
					array2[0] = (byte)num8;
					goto case 180;
				case 180:
					num8 = 83;
					num2 = 309;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 310;
				case 310:
					array2[0] = (byte)num8;
					num2 = 11;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 348;
				case 320:
					array7[9] = array3[4];
					goto case 96;
				case 96:
					array7[11] = array3[5];
					num = 175;
					goto case 175;
				case 175:
					array7[13] = array3[6];
					num2 = 136;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 318:
					num9 = 126;
					num2 = 308;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 316:
					U6wfNhNGvk(object_2);
					num2 = 299;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 202;
				case 202:
					num7 = 58;
					num2 = 0;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 315:
					num9 = 162;
					num2 = 158;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 314:
					array2[13] = 179;
					num2 = 13;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 313:
					num10 = 33;
					goto case 285;
				case 285:
					array[5] = (byte)num10;
					num2 = 284;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 312:
					array2[1] = (byte)num8;
					num = 224;
					goto case 224;
				case 224:
					array2[1] = 93;
					num2 = 332;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 311:
					array7[7] = array3[3];
					goto case 320;
				case 309:
					num10 = 153;
					num2 = 300;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 308:
					array2[4] = (byte)num9;
					num2 = 376;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 307:
					num10 = 120;
					num2 = 80;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 306:
					num7 = 55;
					num2 = 88;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 327;
				case 305:
					array[1] = 183;
					goto case 174;
				case 174:
					num10 = 165;
					num = 169;
					goto case 169;
				case 169:
					array[1] = (byte)num10;
					num = 62;
					goto case 62;
				case 62:
					array[2] = 116;
					goto case 49;
				case 49:
					num10 = 100;
					goto case 133;
				case 133:
					array[2] = (byte)num10;
					num2 = 411;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 285;
				case 303:
					array2[21] = (byte)num8;
					num2 = 406;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 301:
					array[0] = 83;
					goto case 70;
				case 70:
					num7 = 110;
					num = 17;
					goto case 17;
				case 17:
					array[0] = (byte)num7;
					goto case 118;
				case 118:
					array[0] = 107;
					goto case 14;
				case 14:
					array[0] = 103;
					goto case 105;
				case 105:
					num7 = 126;
					goto case 59;
				case 300:
					array[7] = (byte)num10;
					num2 = 203;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 407;
				case 299:
					ecUfaPBirc = (byte[])xBhfO1Ccgx(stream);
					num2 = 235;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 271;
				case 271:
					YCWflgH4x3(stream);
					goto case 370;
				case 296:
					num19 = 255u;
					goto case 333;
				case 294:
					num18 += 8;
					goto case 197;
				case 293:
					array2[12] = 82;
					num2 = 279;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 8;
				case 8:
					gH0fjQvhNr(array7);
					num2 = 371;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 290:
					array[1] = (byte)num7;
					goto case 305;
				case 287:
					num9 = 146;
					num2 = 193;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 284:
					num10 = 127;
					goto case 181;
				case 181:
					array[5] = (byte)num10;
					goto case 52;
				case 282:
					num17 = 0u;
					num2 = 38;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 385;
				case 279:
					num9 = 120;
					num2 = 393;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 278:
					array2[25] = 158;
					num2 = 325;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 197;
				case 277:
					array5 = array2;
					num2 = 129;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 276:
					array2[7] = 121;
					num2 = 141;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 273:
					num7 = 150;
					num2 = 335;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 270:
					num9 = 111;
					num2 = 95;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 192;
				case 192:
					array2[2] = (byte)num9;
					goto case 37;
				case 267:
					array2[14] = 206;
					num2 = 209;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 266:
					array2[11] = 88;
					num2 = 185;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 265:
					array[6] = 95;
					num2 = 374;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 263:
					array2[4] = 130;
					goto case 114;
				case 114:
					num9 = 174;
					num2 = 89;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 262:
					num8 = 51;
					goto case 362;
				case 261:
					num8 = 113;
					num = 26;
					goto case 26;
				case 26:
					array2[31] = (byte)num8;
					num2 = 90;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 57;
				case 260:
					num15++;
					num2 = 229;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 162;
				case 259:
					array2[11] = (byte)num8;
					num2 = 201;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 258:
					array2[23] = (byte)num8;
					goto case 21;
				case 21:
					num9 = 86;
					goto case 334;
				case 256:
					num9 = 64;
					goto case 379;
				case 255:
					num7 = 113;
					goto case 290;
				case 253:
					num7 = 108;
					num2 = 83;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 82;
				case 82:
					array[15] = (byte)num10;
					num2 = 104;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 252:
					array2[30] = (byte)num8;
					num2 = 324;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 361;
				case 242:
					array2[11] = (byte)num8;
					goto case 32;
				case 240:
					num10 = 109;
					goto case 74;
				case 74:
					array[15] = (byte)num10;
					num2 = 160;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 237:
					num16 = 0;
					num2 = 251;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 236:
					array[4] = (byte)num10;
					goto case 253;
				case 234:
					array6[num13 + 1] = (byte)((num14 & 0xFF00) >> 8);
					goto case 182;
				case 182:
					array6[num13 + 2] = (byte)((num14 & 0xFF0000) >> 16);
					goto case 384;
				case 233:
					num10 = 117;
					goto case 48;
				case 232:
					array2[20] = (byte)num9;
					goto case 151;
				case 151:
					num9 = 94;
					goto case 368;
				case 230:
					array[10] = 153;
					goto case 273;
				case 156:
				case 229:
					if (num15 >= array7.Length)
					{
						goto case 405;
					}
					goto case 214;
				case 214:
					array5[num15] = (byte)(array5[num15] ^ array7[num15]);
					num2 = 140;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 260;
				case 225:
					array2[17] = 159;
					num2 = 392;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 277;
				case 223:
					array2[28] = 129;
					goto case 75;
				case 75:
					array2[28] = 130;
					num2 = 395;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 220:
					array2[6] = (byte)num9;
					num2 = 276;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 217:
					num7 = 151;
					num = 63;
					goto case 63;
				case 63:
					array[7] = (byte)num7;
					goto case 309;
				case 211:
					num8 = 156;
					num = 303;
					goto case 303;
				case 210:
					array2[9] = 105;
					goto case 122;
				case 122:
					num8 = 149;
					goto case 184;
				case 184:
					array2[10] = (byte)num8;
					goto case 68;
				case 68:
					num8 = 124;
					num2 = 404;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 209:
					array2[14] = 180;
					num2 = 262;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 208:
					B2kfK6LtLg(object_2, array4, 0, array4.Length);
					goto case 316;
				case 206:
					array[15] = (byte)num10;
					num2 = 183;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 204:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					goto case 208;
				case 201:
					num8 = 160;
					goto case 242;
				case 196:
					fAnfW3NvZY(object_);
					goto case 35;
				case 35:
					array2 = new byte[32];
					goto case 91;
				case 91:
					num8 = 133;
					num2 = 321;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 194:
					num8 = 91;
					num = 377;
					goto case 377;
				case 190:
					array2[25] = 102;
					goto case 108;
				case 108:
					array2[25] = 104;
					goto case 278;
				case 186:
					num9 = 221;
					num2 = 154;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 137;
				case 137:
					if (array3.Length > 0)
					{
						goto case 102;
					}
					goto case 164;
				case 102:
					array7[1] = array3[0];
					goto case 45;
				case 45:
					array7[3] = array3[1];
					num2 = 123;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 54;
				case 164:
					num15 = 0;
					goto case 156;
				case 185:
					num8 = 123;
					goto case 259;
				case 183:
					num10 = 93;
					goto case 82;
				case 176:
					array7 = array;
					goto case 8;
				case 173:
					array2[27] = (byte)num9;
					num2 = 351;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 113;
				case 113:
					num7 = 227;
					num2 = 130;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 166:
					array2[26] = 138;
					num2 = 295;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 160:
					num10 = 149;
					goto case 79;
				case 79:
					array[15] = (byte)num10;
					num2 = 202;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 158:
					array2[28] = (byte)num9;
					goto case 10;
				case 10:
					num9 = 105;
					num = 355;
					goto case 355;
				case 157:
					array[4] = (byte)num7;
					goto case 313;
				case 155:
					array[6] = (byte)num10;
					num = 265;
					goto case 265;
				case 154:
					array2[19] = (byte)num9;
					goto case 121;
				case 121:
					num9 = 86;
					goto case 232;
				case 153:
					array6[num13] = (byte)(num14 & 0xFFu);
					goto case 234;
				case 150:
					num9 = 90;
					num2 = 50;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 148:
					num10 = 102;
					num2 = 236;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 142:
					array2[28] = (byte)num9;
					num2 = 57;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 315;
				case 140:
					array2[17] = 120;
					num = 346;
					goto case 346;
				case 138:
					num10 = 96;
					goto case 44;
				case 44:
					array[9] = (byte)num10;
					num = 349;
					goto case 349;
				case 136:
					array7[15] = array3[7];
					num = 164;
					goto case 164;
				case 134:
					array[0] = (byte)num7;
					goto case 301;
				case 132:
					array[10] = 124;
					num = 230;
					goto case 230;
				case 130:
					array[3] = (byte)num7;
					goto case 233;
				case 129:
					array = new byte[16];
					num2 = 43;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 128:
					array2[15] = (byte)num9;
					goto case 194;
				case 123:
					array7[5] = array3[2];
					goto case 311;
				case 112:
					num10 = 253;
					goto case 372;
				case 111:
					array6 = new byte[array4.Length];
					num = 375;
					goto case 375;
				case 109:
					num8 = 126;
					goto case 20;
				case 20:
					array2[9] = (byte)num8;
					num = 27;
					goto case 27;
				case 106:
					array2[20] = 84;
					goto case 85;
				case 85:
					array2[20] = 91;
					goto case 337;
				case 104:
					array[15] = 185;
					num2 = 176;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto case 126;
				case 101:
					num12 = (uint)((array5[num11 + 3] << 24) | (array5[num11 + 2] << 16) | (array5[num11 + 1] << 8) | array5[num11]);
					goto case 296;
				case 90:
					array2[31] = 152;
					goto case 67;
				case 67:
					array2[31] = 181;
					goto case 345;
				case 89:
					array2[4] = (byte)num9;
					num2 = 287;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 88:
					array[7] = (byte)num10;
					goto case 217;
				case 87:
					array2[8] = (byte)num9;
					goto case 256;
				case 83:
					array[4] = (byte)num7;
					goto case 383;
				case 80:
					array[8] = (byte)num10;
					goto case 306;
				case 78:
					array2[25] = 150;
					goto case 190;
				case 76:
					num9 = 25;
					goto case 408;
				case 71:
					array2[31] = 232;
					goto case 277;
				case 69:
					num9 = 130;
					goto case 369;
				case 66:
					array2[15] = 142;
					num2 = 341;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 60:
					array[10] = 164;
					num2 = 132;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 92;
				case 56:
					num8 = 116;
					num2 = 312;
					if (REhfhlrgeF())
					{
						continue;
					}
					goto IL_003a;
				case 55:
					num7 = 190;
					num2 = 117;
					if (!REhfhlrgeF())
					{
						continue;
					}
					goto case 365;
				case 53:
					array2[1] = (byte)num9;
					num2 = 354;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto IL_003a;
				case 50:
					array2[10] = (byte)num9;
					goto case 266;
				case 47:
					array4 = (byte[])Y2BfJKq7SS(object_, (int)IPwf5kjyeo(B1Lfsi1Iri(object_)));
					goto case 196;
				case 43:
					num7 = 133;
					goto case 134;
				case 39:
					num10 = 43;
					num2 = 70;
					if (pMDfeuRl8N() != null)
					{
						continue;
					}
					goto case 88;
				case 34:
					array2[31] = 104;
					goto case 71;
				case 33:
					array2[6] = 88;
					goto case 387;
				case 28:
					if (array3 != null)
					{
						num2 = 137;
						if (pMDfeuRl8N() == null)
						{
							continue;
						}
						goto case 57;
					}
					goto case 164;
				case 25:
					num8 = 126;
					goto case 252;
				case 22:
					num10 = 143;
					num = 206;
					goto case 206;
				case 15:
					array[8] = (byte)num7;
					num2 = 307;
					if (pMDfeuRl8N() == null)
					{
						continue;
					}
					goto case 250;
				case 13:
					num9 = 43;
					goto case 378;
				case 12:
					array[9] = (byte)num7;
					num = 138;
					goto case 138;
				case 6:
					num9 = 128;
					goto case 409;
				case 5:
					num8 = 99;
					num = 258;
					goto case 258;
				case 1:
					array2[12] = 106;
					goto case 293;
				default:
					array[15] = (byte)num7;
					goto case 22;
				case 330:
					break;
				case 152:
					ecUfaPBirc = array6;
					goto IL_26f8;
				case 125:
					goto IL_26f8;
				case 227:
					goto IL_2705;
				case 326:
					goto end_IL_26e3;
				}
				break;
			}
			continue;
			IL_003a:
			num2 = num;
			goto IL_2065;
			IL_26f8:
			int_ = e0SfSdv1Ap(ecUfaPBirc, int_0);
			goto IL_2705;
			continue;
			end_IL_26e3:
			break;
		}
		return "";
	}

	[gnI6sxzI8jSqnkUott(typeof(gnI6sxzI8jSqnkUott.LaQsCy2ZuWVBEIlgxs3<object>[]))]
	internal static string YikIb8y16v(string string_0)
	{
		nohvtg2Jq63jo2SldqX.fbxTrwhohj(480).Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int SGNItoEBjB()
	{
		return 5;
	}

	private static void XUrIgVeBtx()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate dM2IkTfibq(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777308)).GetMethod(nohvtg2Jq63jo2SldqX.fbxTrwhohj(534), new Type[2]
		{
			Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777250)),
			Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(16777240))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object p8FIrF3QcR(object object_0)
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
			if (File.Exists(((Assembly)object_0).GetName().CodeBase!.ToString().Replace(nohvtg2Jq63jo2SldqX.fbxTrwhohj(596), "")))
			{
				return ((Assembly)object_0).GetName().CodeBase!.ToString().Replace(nohvtg2Jq63jo2SldqX.fbxTrwhohj(596), "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_0.GetType().GetProperty(nohvtg2Jq63jo2SldqX.fbxTrwhohj(616))!.GetValue(object_0, new object[0])!.ToString()))
			{
				return object_0.GetType().GetProperty(nohvtg2Jq63jo2SldqX.fbxTrwhohj(616))!.GetValue(object_0, new object[0])!.ToString();
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

	private static IntPtr VOOIQc0Pnn(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (bINftEPXkV == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), nohvtg2Jq63jo2SldqX.fbxTrwhohj(636).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(650));
			bINftEPXkV = (hEPRb32YEWMiE7qYtuq)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554477)));
		}
		return bINftEPXkV(intptr_0, string_0, uint_0);
	}

	private static IntPtr YUWICKXHWR(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (RkGTpuXTvl == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), nohvtg2Jq63jo2SldqX.fbxTrwhohj(672).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(692));
			RkGTpuXTvl = (r3tCmk2pD1VKim0bdsk)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554478)));
		}
		return RkGTpuXTvl(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int rabI9fvltK(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (J3LfdDl5xA == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), nohvtg2Jq63jo2SldqX.fbxTrwhohj(706).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(722).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(742));
			J3LfdDl5xA = (C3ivIx2EtVSoDAJEKKC)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554479)));
		}
		return J3LfdDl5xA(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int OFEIuvGLEP(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (mPFTo8ioow == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), nohvtg2Jq63jo2SldqX.fbxTrwhohj(672).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(758));
			mPFTo8ioow = (imaSrN2mEovqwIsZ8N7)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554480)));
		}
		return mPFTo8ioow(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr xQpIzuEdf4(uint uint_0, int int_0, uint uint_1)
	{
		if (Cl5fRPKeul == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), nohvtg2Jq63jo2SldqX.fbxTrwhohj(776).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(790));
			Cl5fRPKeul = (m1y4t528FvVr61oUd4T)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554481)));
		}
		return Cl5fRPKeul(uint_0, int_0, uint_1);
	}

	private static int YwbfZ7dFpM(IntPtr intptr_0)
	{
		if (urlTIlSr9P == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), nohvtg2Jq63jo2SldqX.fbxTrwhohj(808).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(824));
			urlTIlSr9P = (FuTGGs26m21gKTJbu6P)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(lV1d122Lk6LtLgF6whN.bosk2F09Lv4q3(33554482)));
		}
		return urlTIlSr9P(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (KHLfbxpZjB == IntPtr.Zero)
		{
			KHLfbxpZjB = LoadLibrary(nohvtg2Jq63jo2SldqX.fbxTrwhohj(840).Trim() + nohvtg2Jq63jo2SldqX.fbxTrwhohj(858));
		}
		return KHLfbxpZjB;
	}

	[gnI6sxzI8jSqnkUott(typeof(gnI6sxzI8jSqnkUott.LaQsCy2ZuWVBEIlgxs3<object>[]))]
	private static byte[] LExf29RJU3(string string_0)
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

	internal static Stream AfjfIvqDGU()
	{
		return new MemoryStream();
	}

	internal static byte[] glhffVseRJ(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[gnI6sxzI8jSqnkUott(typeof(gnI6sxzI8jSqnkUott.LaQsCy2ZuWVBEIlgxs3<object>[]))]
	private static byte[] unAfTk2Fxn(byte[] byte_0)
	{
		Stream stream = AfjfIvqDGU();
		SymmetricAlgorithm symmetricAlgorithm = Jf2ILLrtQb();
		symmetricAlgorithm.Key = new byte[32]
		{
			232, 136, 65, 1, 215, 181, 191, 30, 194, 172,
			186, 113, 7, 107, 149, 100, 238, 7, 96, 200,
			219, 208, 103, 48, 82, 253, 2, 154, 225, 69,
			239, 46
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			177, 75, 233, 52, 212, 41, 46, 70, 248, 152,
			57, 153, 75, 116, 14, 29
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = glhffVseRJ(stream);
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		return result;
	}

	private byte[] eqkfokv2dD()
	{
		return null;
	}

	private byte[] CNkfqRceT7()
	{
		return null;
	}

	private byte[] WfxfYwhwlm()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(874);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] p47fp5RiNF()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(928);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] VS3fE3VKU4()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(982);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] YN6fmfmKX7()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(1036);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] JpXf8Zr0QV()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(1090);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] dbbf6y0nZX()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(1144);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] keofDaDNo6()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(1198);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] rxZf4IymeU()
	{
		string text = nohvtg2Jq63jo2SldqX.fbxTrwhohj(1252);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	public A2IykMCm48qOE9ZWAc()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		base._002Ector();
	}

	internal static object lhdfMHSLRk(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object B1Lfsi1Iri(object object_0)
	{
		return ((nOF66j2qTbuEGTBokrT)object_0).KDikMXewCI();
	}

	internal static void yxMfPAOY34(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long IPwf5kjyeo(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object Y2BfJKq7SS(object object_0, int int_0)
	{
		return ((nOF66j2qTbuEGTBokrT)object_0).tBBTyVElZZ(int_0);
	}

	internal static void fAnfW3NvZY(object object_0)
	{
		((nOF66j2qTbuEGTBokrT)object_0).g5LTKcDWTr();
	}

	internal static void gH0fjQvhNr(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object kvqfvVwjhQ(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object RdkfBRi2wG(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object Sq8fnQq3o8()
	{
		return Jf2ILLrtQb();
	}

	internal static void msPfybj91r(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object DdKf3BAsuQ(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object Ub5fUUDV1d()
	{
		return AfjfIvqDGU();
	}

	internal static void B2kfK6LtLg(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void U6wfNhNGvk(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object xBhfO1Ccgx(object object_0)
	{
		return glhffVseRJ((Stream)object_0);
	}

	internal static void YCWflgH4x3(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int e0SfSdv1Ap(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void rkcf1Sinrt()
	{
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
	}

	internal static object Dn0fxy9YaQ()
	{
		return Encoding.Unicode;
	}

	internal static object xYafVC4jrA(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool REhfhlrgeF()
	{
		return (object)null == null;
	}

	internal static object pMDfeuRl8N()
	{
		return null;
	}
}
