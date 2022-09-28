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
using bmAsj3sI67ggi0IGQJ;
using npnBExdejgsuYlB17M;

namespace CwyHwYHvkMTIn485GM;

internal class GfA0u5bVAwirLe9Dlp
{
	private delegate void iS34OtSlS361MRPM1k(object o);

	internal class U2FaXvCw9Ryi7pa7Zh : Attribute
	{
		internal class i9QiXDrwubnvL5ZMUh<PQQjfRpMItA2akXfnV>
		{
			private static object V467MtWVJXfx3PPwaTs;

			static i9QiXDrwubnvL5ZMUh()
			{
				uicMh577UH();
				fsjMu3I67g();
			}

			internal static bool SGUpfpWTgNtrvv75EkC()
			{
				return true;
			}

			internal static object VPBIRoWFwqtcktBXG1s()
			{
				return null;
			}
		}

		[U2FaXvCw9Ryi7pa7Zh(typeof(i9QiXDrwubnvL5ZMUh<object>[]))]
		public U2FaXvCw9Ryi7pa7Zh(object object_0)
		{
		}

		static U2FaXvCw9Ryi7pa7Zh()
		{
			uicMh577UH();
		}
	}

	internal class V5AygKXCdGTewWUS4L
	{
		[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
		internal static string A0mYsuEBtC(string string_0, string string_1)
		{
			return null;
		}

		internal static object tNEX3rWA56Mg1jLWDmW()
		{
			return null;
		}

		internal static object gQlWqfWfpOWWqKZRykF(object object_0, object object_1)
		{
			return null;
		}

		internal static object cQv4dLWRtix1GRZ6rLi(object object_0)
		{
			return null;
		}

		internal static object xL3BHZWnvm8Fw8Pmtrm()
		{
			return null;
		}

		internal static void hOW7aLWtHp7GsW7tNSn(object object_0, object object_1)
		{
		}

		internal static object nBmGWIW0S18Q12uiq7w(object object_0)
		{
			return null;
		}

		internal static void IYqJosW9IkC9KmGl1Y4(object object_0, object object_1, int int_0, int int_1)
		{
		}

		internal static void zkn72GWqNQb1Q0uIs9X(object object_0)
		{
		}

		internal static object AHr6N4WH7iCay3xSj3W(object object_0)
		{
			return null;
		}

		static V5AygKXCdGTewWUS4L()
		{
			uicMh577UH();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint vmKHaGkKsKi26WI13R(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr NdHeKnVyPx2xIs8tph();

	internal struct I1ho1vIqNbrKZGrIVQ
	{
		internal bool wwIYomrkGK;

		internal byte[] L52YhhxU7K;
	}

	internal class nZUxMxUiCboTvB3E9l
	{
		private BinaryReader N7YYyQsfPV;

		public nZUxMxUiCboTvB3E9l(Stream stream_0)
		{
			N7YYyQsfPV = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream RgtTUJcyZL()
		{
			return (Stream)FsBqabWEYFS3cnkKoMd(N7YYyQsfPV);
		}

		internal byte[] xIHYG426sb(int int_0)
		{
			return (byte[])Vc6BqEWeXYfLCJVWqnx(N7YYyQsfPV, int_0);
		}

		internal int oYKYLZ1cgM(byte[] byte_0, int int_0, int int_1)
		{
			return bIpTVIWiygvPvs4PkbY(N7YYyQsfPV, byte_0, int_0, int_1);
		}

		internal int oHBY6DGaSW()
		{
			return N7YYyQsfPV.ReadInt32();
		}

		internal void XtFYDP1fCf()
		{
			N7YYyQsfPV.Close();
		}

		internal static object FsBqabWEYFS3cnkKoMd(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static object Vc6BqEWeXYfLCJVWqnx(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int bIpTVIWiygvPvs4PkbY(object object_0, object object_1, int int_0, int int_1)
		{
			return ((BinaryReader)object_0).Read((byte[])object_1, int_0, int_1);
		}

		static nZUxMxUiCboTvB3E9l()
		{
			uicMh577UH();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr hs4JAHu9FR30uA3uoe(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Cn3Pf9ec9q46FxAHpm(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int zTwDkwB4XBOmmHvUP8(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int OjAZ7qm500SwFlJkP1(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr KmhgQRa8DyGaVGpZge(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int pm3efwlShFJJ9WWwbI(IntPtr ptr);

	[Flags]
	private enum KXBbiwxDs2avydFehE
	{

	}

	private static byte[] KOIYNdOnLj;

	internal static Assembly XoHYqExpAL;

	private static zTwDkwB4XBOmmHvUP8 pZPYl49Mqy;

	private static byte[] UMFYwf9Lap;

	internal static vmKHaGkKsKi26WI13R pBcYpLH95a;

	internal static Hashtable PUxYBYejG6;

	private static object oSjY1HtHuy;

	internal static vmKHaGkKsKi26WI13R IfPYrJAk5d;

	private static Cn3Pf9ec9q46FxAHpm vwuYaWhEjM;

	private static IntPtr SPdYuoOxch;

	private static IntPtr fphYP3b1SV;

	private static pm3efwlShFJJ9WWwbI Ec5YdRF0LP;

	private static bool NnAYbCxHWY;

	[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
	private static bool ETxYetnFfH;

	private static bool VNlYIMDSlk;

	private static long gObYCaGyKM;

	private static long fjdYX34t0i;

	private static uint[] teNYQPJOdl;

	private static int rPNYU3VHGa;

	private static Dictionary<int, int> BR9Y8yPcRi;

	private static KmhgQRa8DyGaVGpZge GKGY5ADOS9;

	private static bool ieHY2wkZRC;

	private static IntPtr kFTYvFSNcw;

	private static int A9lYk7UHNm;

	internal static RSACryptoServiceProvider EfxYjc5MAS;

	private static byte[] mtmYgL58JF;

	private static OjAZ7qm500SwFlJkP1 vdmYxpvcIY;

	private static int[] TrVYRl07Jr;

	private static int W3bYW8GkXg;

	private static object FrSYcKGui2;

	private static IntPtr De2YfOy648;

	private static bool INDYV00IM8;

	private static int ufQYSvBrsQ;

	private static SortedList AqMYHADoFK;

	private static hs4JAHu9FR30uA3uoe CTdYmt381X;

	private static bool H9CYZB3m03;

	static GfA0u5bVAwirLe9Dlp()
	{
		XoHYqExpAL = Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554451)).Assembly;
		teNYQPJOdl = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		ieHY2wkZRC = false;
		H9CYZB3m03 = false;
		mtmYgL58JF = new byte[0];
		EfxYjc5MAS = null;
		BR9Y8yPcRi = null;
		oSjY1HtHuy = new object();
		KOIYNdOnLj = new byte[0];
		UMFYwf9Lap = new byte[0];
		fphYP3b1SV = IntPtr.Zero;
		De2YfOy648 = IntPtr.Zero;
		FrSYcKGui2 = new string[0];
		TrVYRl07Jr = new int[0];
		W3bYW8GkXg = 1;
		NnAYbCxHWY = false;
		AqMYHADoFK = new SortedList();
		ufQYSvBrsQ = 0;
		gObYCaGyKM = 0L;
		IfPYrJAk5d = null;
		pBcYpLH95a = null;
		fjdYX34t0i = 0L;
		A9lYk7UHNm = 0;
		INDYV00IM8 = false;
		VNlYIMDSlk = false;
		rPNYU3VHGa = 0;
		SPdYuoOxch = IntPtr.Zero;
		ETxYetnFfH = false;
		PUxYBYejG6 = new Hashtable();
		CTdYmt381X = null;
		vwuYaWhEjM = null;
		pZPYl49Mqy = null;
		vdmYxpvcIY = null;
		GKGY5ADOS9 = null;
		Ec5YdRF0LP = null;
		kFTYvFSNcw = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void jiMkTnOe13dTw()
	{
	}

	internal static byte[] KmhMRgQR8D(byte[] byte_0)
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
			TGaMWVGpZg(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			TGaMWVGpZg(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			TGaMWVGpZg(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			TGaMWVGpZg(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			TGaMWVGpZg(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			TGaMWVGpZg(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			TGaMWVGpZg(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			TGaMWVGpZg(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			TGaMWVGpZg(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			TGaMWVGpZg(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			TGaMWVGpZg(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			TGaMWVGpZg(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			TGaMWVGpZg(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			TGaMWVGpZg(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			TGaMWVGpZg(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			TGaMWVGpZg(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			G1mMb3efwS(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			G1mMb3efwS(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			G1mMb3efwS(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			G1mMb3efwS(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			G1mMb3efwS(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			G1mMb3efwS(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			G1mMb3efwS(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			G1mMb3efwS(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			G1mMb3efwS(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			G1mMb3efwS(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			G1mMb3efwS(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			G1mMb3efwS(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			G1mMb3efwS(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			G1mMb3efwS(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			G1mMb3efwS(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			G1mMb3efwS(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			PFJMHJ9WWw(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			PFJMHJ9WWw(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			PFJMHJ9WWw(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			PFJMHJ9WWw(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			PFJMHJ9WWw(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			PFJMHJ9WWw(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			PFJMHJ9WWw(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			PFJMHJ9WWw(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			PFJMHJ9WWw(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			PFJMHJ9WWw(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			PFJMHJ9WWw(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			PFJMHJ9WWw(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			PFJMHJ9WWw(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			PFJMHJ9WWw(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			PFJMHJ9WWw(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			PFJMHJ9WWw(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			wIxMSXBbiw(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			wIxMSXBbiw(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			wIxMSXBbiw(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			wIxMSXBbiw(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			wIxMSXBbiw(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			wIxMSXBbiw(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			wIxMSXBbiw(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			wIxMSXBbiw(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			wIxMSXBbiw(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			wIxMSXBbiw(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			wIxMSXBbiw(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			wIxMSXBbiw(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			wIxMSXBbiw(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			wIxMSXBbiw(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			wIxMSXBbiw(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			wIxMSXBbiw(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void TGaMWVGpZg(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + Ss2MCavydF(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + teNYQPJOdl[uint_5 - 1], ushort_0);
	}

	private static void G1mMb3efwS(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + Ss2MCavydF(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + teNYQPJOdl[uint_5 - 1], ushort_0);
	}

	private static void PFJMHJ9WWw(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + Ss2MCavydF(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + teNYQPJOdl[uint_5 - 1], ushort_0);
	}

	private static void wIxMSXBbiw(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + Ss2MCavydF(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + teNYQPJOdl[uint_5 - 1], ushort_0);
	}

	private static uint Ss2MCavydF(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool GhEMr9V4xv()
	{
		if (!ieHY2wkZRC)
		{
			jTIMXJjpnB();
			ieHY2wkZRC = true;
		}
		return H9CYZB3m03;
	}

	internal static SymmetricAlgorithm TLWMpNI0ZT()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (GhEMr9V4xv())
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

	internal static void jTIMXJjpnB()
	{
		try
		{
			new RijndaelManaged();
			H9CYZB3m03 = false;
		}
		catch
		{
			H9CYZB3m03 = true;
		}
	}

	internal static byte[] UxeMkjgsuY(byte[] byte_0)
	{
		if (!GhEMr9V4xv())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return KmhMRgQR8D(byte_0);
	}

	internal static void JB1MV7MZek(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			ThlMIjteo7(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void ThlMIjteo7(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint SFGMU64bYm(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
	internal static void fsjMu3I67g()
	{
		//IL_2118: Incompatible stack heights: 0 vs 1
		//IL_2118: Incompatible stack heights: 1 vs 0
		int num = 13;
		string text = default(string);
		HashAlgorithm object_ = default(HashAlgorithm);
		string object_2 = default(string);
		int num4 = default(int);
		int num6 = default(int);
		bool flag = default(bool);
		int num9 = default(int);
		int num10 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num8 = default(int);
		byte[] object_7 = default(byte[]);
		byte[] array3 = default(byte[]);
		Stream stream = default(Stream);
		CryptoStream object_4 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		byte[] object_6 = default(byte[]);
		int num12 = default(int);
		long num19 = default(long);
		long num26 = default(long);
		long num24 = default(long);
		int num21 = default(int);
		uint num16 = default(uint);
		uint num15 = default(uint);
		uint num27 = default(uint);
		int num22 = default(int);
		int num17 = default(int);
		long num18 = default(long);
		uint num25 = default(uint);
		int int_ = default(int);
		uint uint_2 = default(uint);
		uint num14 = default(uint);
		long long_ = default(long);
		uint num23 = default(uint);
		bool flag2 = default(bool);
		uint uint_ = default(uint);
		byte[] array5 = default(byte[]);
		int num29 = default(int);
		while (true)
		{
			if (EfxYjc5MAS == null)
			{
				goto IL_0013;
			}
			int num2 = 12;
			if (cUAvJgt0Sy1Ns6S4E4() != null)
			{
				goto IL_2711;
			}
			goto IL_2745;
			IL_2711:
			num2 = num;
			goto IL_2745;
			IL_2745:
			switch (num2)
			{
			case 13:
				break;
			case 8:
				goto IL_0013;
			case 14:
				goto IL_0018;
			case 19:
				goto IL_0032;
			case 16:
				goto IL_0039;
			case 2:
				goto IL_0045;
			case 18:
				goto IL_0058;
			case 15:
				goto IL_005b;
			case 4:
				goto IL_00e7;
			case 1:
				goto IL_00fa;
			case 10:
				goto IL_212e;
			case 17:
				goto IL_2717;
			case 3:
				goto IL_2721;
			case 9:
				goto IL_27a6;
			case 5:
				goto IL_27c1;
			case 6:
				flag = false;
				return;
			default:
				goto IL_27cf;
			case 11:
			case 12:
				return;
			case 7:
			case 20:
				return;
			}
			continue;
			IL_0013:
			urnFwAY3YvXWNpqjND();
			goto IL_0018;
			IL_0018:
			CDxujwugInB5843HwL(bool_0: true);
			num2 = 0;
			if (cUAvJgt0Sy1Ns6S4E4() == null)
			{
				goto IL_2717;
			}
			goto IL_2745;
			IL_2717:
			EfxYjc5MAS = new RSACryptoServiceProvider();
			goto IL_2721;
			IL_2721:
			text = (string)udyydcWBhOfM6SeuyU(gnFfywD3dI1MF09KRB(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly);
			num = 19;
			goto IL_0032;
			IL_0032:
			if (text == null)
			{
				break;
			}
			goto IL_0039;
			IL_0039:
			if (NLg7OadMLXSRFo0dIT(text) == 0)
			{
				break;
			}
			goto IL_0045;
			IL_0045:
			object_ = null;
			num2 = 3;
			if (Ne7c5ZhqA7vvcxOEpn())
			{
				goto IL_0058;
			}
			goto IL_2745;
			IL_0058:
			object_2 = null;
			goto IL_005b;
			IL_005b:
			try
			{
				object_ = (HashAlgorithm)zf1ZwQSUxLe7FOywKS();
				int num3 = 1;
				if (cUAvJgt0Sy1Ns6S4E4() != null)
				{
					num3 = num4;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						if (!RGMG5x140k779Cd7bf(text))
						{
							num3 = 0;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							return;
						}
						break;
					case 1:
						object_2 = (string)bO8oYSsiUkCRNkSmSp("SHA1");
						num3 = 2;
						if (Ne7c5ZhqA7vvcxOEpn())
						{
							continue;
						}
						return;
					default:
						return;
					case 0:
						return;
					case 3:
						break;
					}
					break;
				}
			}
			catch
			{
				int num5 = 0;
				if (!Ne7c5ZhqA7vvcxOEpn())
				{
					num5 = num6;
				}
				switch (num5)
				{
				}
				break;
			}
			goto IL_00e7;
			IL_00e7:
			flag = false;
			num2 = 0;
			if (Ne7c5ZhqA7vvcxOEpn())
			{
				goto IL_00fa;
			}
			goto IL_2745;
			IL_00fa:
			try
			{
				nZUxMxUiCboTvB3E9l object_3 = new nZUxMxUiCboTvB3E9l((Stream)jsBFdHRQWBjNZ9sQXT(XoHYqExpAL, "LPh4KVKnuIHetaKGAB.jt3QpMC9tbk4Jpp5FJ"));
				while (true)
				{
					UqfTNuTfwLIYIqZDne(O7GK8lxjZLhsheIbLw(object_3), 0L);
					int num7 = 295;
					if (!Ne7c5ZhqA7vvcxOEpn())
					{
						goto IL_01a0;
					}
					goto IL_1b3a;
					IL_1b3a:
					while (true)
					{
						switch (num7)
						{
						case 338:
							num9 = 109;
							num10 = 22;
							goto case 22;
						case 22:
							array2[4] = (byte)num9;
							num10 = 246;
							goto case 246;
						case 246:
							num9 = 92;
							goto case 300;
						case 300:
							array2[4] = (byte)num9;
							goto case 200;
						case 200:
							num9 = 207;
							goto case 134;
						case 134:
							array2[4] = (byte)num9;
							num10 = 53;
							goto case 53;
						case 53:
							num9 = 158;
							num10 = 183;
							goto case 183;
						case 183:
							array2[4] = (byte)num9;
							num7 = 140;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 337:
							array[6] = 149;
							num10 = 227;
							goto case 227;
						case 227:
							num8 = 129;
							num10 = 260;
							goto case 260;
						case 260:
							array[6] = (byte)num8;
							goto case 283;
						case 283:
							num8 = 48;
							num10 = 175;
							goto case 175;
						case 175:
							array[6] = (byte)num8;
							num10 = 309;
							goto case 309;
						case 309:
							array[7] = 130;
							goto case 235;
						case 235:
							num8 = 139;
							goto case 319;
						case 319:
							array[7] = (byte)num8;
							goto case 213;
						case 213:
							array[7] = 191;
							num10 = 34;
							goto case 34;
						case 34:
							array[7] = 149;
							num7 = 218;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 336:
							array[17] = (byte)num8;
							goto case 63;
						case 63:
							num8 = 87;
							num10 = 43;
							goto case 43;
						case 43:
							array[17] = (byte)num8;
							goto case 324;
						case 324:
							array[17] = 98;
							num7 = 296;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 335:
							array[12] = 163;
							num7 = 248;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 334:
							array[8] = (byte)num8;
							num7 = 24;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 333:
							num8 = 15;
							num7 = 332;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 332:
							array[23] = (byte)num8;
							num7 = 72;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 331:
							array2[1] = 118;
							num7 = 123;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 49;
						case 49:
							array[10] = 83;
							num10 = 320;
							goto case 320;
						case 320:
							num8 = 56;
							num7 = 89;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 42;
						case 42:
							array2[14] = (byte)num9;
							num7 = 37;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 249;
						case 249:
							num9 = 127;
							num7 = 111;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 57;
						case 57:
							array2[11] = (byte)num9;
							num7 = 265;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 330:
							array[23] = (byte)num8;
							goto case 333;
						case 329:
							num8 = 136;
							num7 = 206;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 328:
							array[24] = (byte)num8;
							goto case 171;
						case 171:
							num8 = 167;
							goto case 95;
						case 95:
							array[25] = (byte)num8;
							num10 = 64;
							goto case 64;
						case 64:
							num8 = 110;
							goto case 46;
						case 46:
							array[25] = (byte)num8;
							goto case 306;
						case 306:
							array[25] = 144;
							num7 = 287;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 327:
							array[18] = 163;
							goto case 199;
						case 199:
							array[18] = 96;
							goto case 85;
						case 85:
							num8 = 148;
							goto case 307;
						case 307:
							array[18] = (byte)num8;
							goto case 219;
						case 219:
							array[18] = 108;
							goto case 251;
						case 251:
							num8 = 131;
							goto case 47;
						case 47:
							array[19] = (byte)num8;
							num7 = 239;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 326:
							array[10] = 88;
							num7 = 255;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 173;
						case 173:
							array2[2] = 72;
							num7 = 144;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 325:
							array2[6] = 17;
							goto case 208;
						case 208:
							num9 = 179;
							goto case 270;
						case 270:
							array2[7] = (byte)num9;
							num7 = 158;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 323:
							array[21] = (byte)num8;
							goto case 19;
						case 19:
							num8 = 217;
							goto case 302;
						case 302:
							array[22] = (byte)num8;
							num7 = 172;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 186;
						case 186:
							array[22] = 114;
							num7 = 233;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 322:
							array[29] = (byte)num8;
							goto case 92;
						case 92:
							num8 = 60;
							goto case 82;
						case 82:
							array[29] = (byte)num8;
							goto case 151;
						case 151:
							array[29] = 182;
							num7 = 229;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 173;
						case 321:
							array[3] = 113;
							num10 = 109;
							goto case 109;
						case 109:
							array[4] = 124;
							goto case 308;
						case 308:
							num8 = 165;
							goto case 13;
						case 13:
							array[4] = (byte)num8;
							num7 = 163;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 318:
							array2[14] = 159;
							goto case 210;
						case 210:
							num9 = 112;
							goto case 238;
						case 238:
							array2[14] = (byte)num9;
							num7 = 212;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 157;
						case 157:
							object_7 = array;
							num7 = 117;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 189;
						case 189:
							array2 = new byte[16];
							goto case 231;
						case 231:
							array2[0] = 176;
							goto case 240;
						case 240:
							array2[0] = 132;
							goto case 125;
						case 125:
							array2[0] = 55;
							num7 = 18;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 3;
						case 3:
							array[14] = 158;
							num7 = 84;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 317:
							num8 = 100;
							num10 = 174;
							goto case 174;
						case 174:
							array[1] = (byte)num8;
							num7 = 178;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 316:
							num8 = 121;
							goto case 126;
						case 126:
							array[7] = (byte)num8;
							num7 = 275;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 315:
							num9 = 144;
							num7 = 168;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 293;
						case 293:
							array2[6] = (byte)num9;
							goto case 146;
						case 146:
							array2[6] = 116;
							goto case 325;
						case 314:
							array2[10] = 150;
							goto case 102;
						case 102:
							array2[10] = 114;
							goto case 165;
						case 165:
							array2[10] = 166;
							goto case 312;
						case 312:
							num9 = 86;
							goto case 310;
						case 310:
							array2[10] = (byte)num9;
							goto case 294;
						case 294:
							num9 = 38;
							goto case 223;
						case 223:
							array2[10] = (byte)num9;
							num7 = 284;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 313:
							num8 = 128;
							goto case 271;
						case 271:
							array[0] = (byte)num8;
							goto case 280;
						case 280:
							array[0] = 87;
							num7 = 285;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 311:
							array2[8] = 134;
							goto case 194;
						case 194:
							num9 = 120;
							num7 = 268;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 305:
							num9 = 60;
							num7 = 57;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 304:
							array[13] = (byte)num8;
							goto case 191;
						case 191:
							num8 = 51;
							num7 = 281;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 255;
						case 255:
							array[10] = 90;
							num7 = 49;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 303:
							num8 = 53;
							goto case 301;
						case 301:
							array[27] = (byte)num8;
							num7 = 205;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 299:
							array2[13] = (byte)num9;
							num7 = 166;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 298:
							array[9] = (byte)num8;
							goto case 66;
						case 66:
							array[9] = 167;
							goto case 29;
						case 29:
							num8 = 94;
							goto case 87;
						case 87:
							array[9] = (byte)num8;
							goto case 115;
						case 115:
							array[10] = 118;
							num7 = 326;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 297:
							num8 = 64;
							num7 = 65;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 296:
							num8 = 52;
							num7 = 39;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 295:
							array3 = (byte[])a8kvtWPpe1LNDV190k(object_3, (int)bAxVGu0DgUGFY4foN6(O7GK8lxjZLhsheIbLw(object_3)));
							num7 = 7;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 138;
						case 138:
							array = new byte[32];
							goto case 117;
						case 117:
							num8 = 124;
							goto case 55;
						case 55:
							array[0] = (byte)num8;
							goto case 313;
						case 292:
							array2[5] = (byte)num9;
							num7 = 120;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 291:
							array[1] = (byte)num8;
							num7 = 180;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 28;
						case 28:
							array[12] = 110;
							num7 = 35;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 29;
						case 290:
							num8 = 133;
							num7 = 201;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 289:
							array[30] = (byte)num8;
							goto case 77;
						case 77:
							array[31] = 86;
							goto case 114;
						case 114:
							array[31] = 228;
							goto case 149;
						case 149:
							array[31] = 126;
							goto case 197;
						case 197:
							num8 = 252;
							goto case 127;
						case 127:
							array[31] = (byte)num8;
							goto case 157;
						case 288:
							array[21] = (byte)num8;
							goto case 16;
						case 16:
							num8 = 101;
							goto case 195;
						case 195:
							array[21] = (byte)num8;
							goto case 67;
						case 67:
							num8 = 164;
							num7 = 139;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 287:
							array[25] = 89;
							goto case 69;
						case 69:
							num8 = 180;
							goto case 159;
						case 159:
							array[25] = (byte)num8;
							num10 = 131;
							goto case 131;
						case 131:
							array[25] = 211;
							goto case 61;
						case 61:
							num8 = 194;
							num7 = 105;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 190;
						case 190:
							array[26] = (byte)num8;
							num7 = 162;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 113;
						case 113:
							num8 = 71;
							goto case 23;
						case 23:
							array[21] = (byte)num8;
							num10 = 133;
							goto case 133;
						case 133:
							num8 = 168;
							goto case 323;
						case 286:
							array2[0] = (byte)num9;
							goto case 230;
						case 230:
							array2[0] = 186;
							goto case 331;
						case 285:
							array[0] = 161;
							goto case 232;
						case 232:
							num8 = 170;
							goto case 184;
						case 184:
							array[1] = (byte)num8;
							num7 = 83;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 284:
							array2[11] = 124;
							goto case 71;
						case 71:
							num9 = 78;
							goto case 8;
						case 8:
							array2[11] = (byte)num9;
							goto case 81;
						case 81:
							array2[11] = 107;
							goto case 305;
						case 282:
							num9 = 131;
							num7 = 292;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 281:
							array[13] = (byte)num8;
							num10 = 2;
							goto case 2;
						case 2:
							num8 = 163;
							goto case 222;
						case 222:
							array[14] = (byte)num8;
							goto case 26;
						case 26:
							num8 = 117;
							num7 = 15;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 279:
							array[15] = (byte)num8;
							goto case 25;
						case 132:
							array[16] = (byte)num8;
							num10 = 253;
							goto case 253;
						case 253:
							array[16] = 66;
							goto case 247;
						case 247:
							num8 = 146;
							num7 = 23;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 202;
						case 202:
							array[16] = (byte)num8;
							num7 = 94;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 25;
						case 25:
							num8 = 107;
							goto case 132;
						case 278:
							stream = (Stream)JCMA1I4sYV8qMfm6CM();
							num10 = 79;
							goto case 79;
						case 79:
							object_4 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
							goto case 106;
						case 106:
							irF2m68rxt8DXE9awk(object_4, array3, 0, array3.Length);
							num7 = 122;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 70;
						case 70:
							array[12] = (byte)num8;
							num7 = 28;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 277:
							num9 = 162;
							num7 = 84;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 264;
						case 264:
							array2[3] = (byte)num9;
							goto case 135;
						case 135:
							num9 = 135;
							goto case 214;
						case 214:
							array2[4] = (byte)num9;
							goto case 338;
						case 276:
							num9 = 189;
							num7 = 0;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 5;
						case 5:
							array2[5] = (byte)num9;
							goto case 243;
						case 243:
							array2[5] = 203;
							goto case 141;
						case 141:
							array2[5] = 128;
							goto case 76;
						case 76:
							array2[6] = 149;
							num7 = 56;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 90;
						case 90:
							array2[6] = 103;
							goto case 315;
						case 275:
							num8 = 86;
							goto case 334;
						case 274:
							array[19] = (byte)num8;
							num7 = 244;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 273:
							array[15] = 114;
							goto case 50;
						case 50:
							num8 = 184;
							num10 = 88;
							goto case 88;
						case 88:
							array[15] = (byte)num8;
							num10 = 196;
							goto case 196;
						case 196:
							num8 = 162;
							goto case 108;
						case 108:
							array[15] = (byte)num8;
							goto case 179;
						case 179:
							array[15] = 129;
							num7 = 225;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 272:
							num8 = 171;
							goto case 86;
						case 86:
							array[3] = (byte)num8;
							num7 = 329;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 269:
							array2[13] = 162;
							num7 = 182;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 65;
						case 65:
							array[28] = (byte)num8;
							goto case 137;
						case 137:
							array[28] = 239;
							num7 = 172;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 76;
						case 268:
							array2[8] = (byte)num9;
							goto case 156;
						case 156:
							array2[8] = 74;
							goto case 38;
						case 38:
							num9 = 49;
							num7 = 80;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 23;
						case 267:
							array[5] = (byte)num8;
							num7 = 99;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 266:
							transform = (ICryptoTransform)MmIXOGg2QUlqpkaiUr(object_5, object_7, object_6);
							goto case 278;
						case 265:
							array2[12] = 110;
							goto case 263;
						case 263:
							num9 = 163;
							goto case 198;
						case 198:
							array2[12] = (byte)num9;
							goto case 150;
						case 150:
							num9 = 119;
							num7 = 203;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 262:
							num8 = 135;
							goto case 148;
						case 148:
							array[5] = (byte)num8;
							num7 = 91;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 261:
							array[24] = (byte)num8;
							goto case 259;
						case 259:
							array[24] = 152;
							num7 = 117;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 215;
						case 215:
							num8 = 105;
							goto case 328;
						case 258:
							array[27] = 182;
							num7 = 303;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 257:
							array[14] = (byte)num8;
							num7 = 273;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 256:
							array[19] = (byte)num8;
							goto case 170;
						case 170:
							num8 = 56;
							num7 = 274;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 254:
							object_6 = array2;
							goto case 207;
						case 207:
							object_5 = (SymmetricAlgorithm)o3UG9Oc40BQabbml9A();
							num7 = 107;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 252:
							array2[2] = 99;
							num7 = 48;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 250:
							num8 = 165;
							goto case 70;
						case 248:
							num8 = 119;
							goto case 237;
						case 237:
							array[12] = (byte)num8;
							goto case 250;
						case 245:
							array[4] = (byte)num8;
							goto case 262;
						case 244:
							array[20] = 118;
							num7 = 101;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 239:
							array[19] = 37;
							goto case 58;
						case 58:
							array[19] = 151;
							goto case 209;
						case 209:
							array[19] = 111;
							num10 = 41;
							goto case 41;
						case 41:
							num8 = 146;
							goto case 256;
						case 236:
							array2[1] = 118;
							num10 = 7;
							goto case 7;
						case 7:
							array2[1] = 91;
							num7 = 121;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 234:
							array[20] = 16;
							goto case 96;
						case 96:
							num8 = 144;
							num7 = 131;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 288;
						case 233:
							array[22] = 102;
							num7 = 32;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 229:
							num8 = 172;
							goto case 142;
						case 142:
							array[29] = (byte)num8;
							goto case 168;
						case 168:
							array[30] = 158;
							num7 = 64;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 216;
						case 216:
							num8 = 154;
							num10 = 155;
							goto case 155;
						case 155:
							array[30] = (byte)num8;
							num7 = 20;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 228:
							array[23] = (byte)num8;
							num7 = 188;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 226:
							num8 = 88;
							num7 = 68;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 225:
							num8 = 184;
							goto case 279;
						case 224:
							num9 = 162;
							goto case 153;
						case 153:
							array2[13] = (byte)num9;
							goto case 54;
						case 54:
							array2[13] = 142;
							num7 = 17;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 44;
						case 44:
							num9 = 173;
							num7 = 299;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 267;
						case 221:
							array[26] = 130;
							num7 = 35;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 129;
						case 129:
							array[27] = 106;
							num7 = 51;
							if (cUAvJgt0Sy1Ns6S4E4() != null)
							{
								continue;
							}
							goto case 258;
						case 220:
							num8 = 56;
							goto case 45;
						case 45:
							array[5] = (byte)num8;
							goto case 337;
						case 218:
							num8 = 102;
							num7 = 1;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 217:
							array[13] = (byte)num8;
							goto case 78;
						case 78:
							num8 = 180;
							num7 = 304;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 212:
							array2[14] = 146;
							num7 = 60;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 211:
							num9 = 154;
							num7 = 30;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 10;
						case 10:
							num8 = 181;
							goto case 298;
						case 206:
							array[3] = (byte)num8;
							num7 = 116;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 205:
							array[28] = 138;
							goto case 297;
						case 203:
							array2[12] = (byte)num9;
							goto case 177;
						case 177:
							array2[12] = 152;
							goto case 12;
						case 12:
							array2[12] = 48;
							goto case 224;
						case 201:
							array[2] = (byte)num8;
							num7 = 272;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 170;
						case 193:
							num8 = 139;
							goto case 181;
						case 181:
							array[11] = (byte)num8;
							num7 = 0;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 192:
							array2[13] = (byte)num9;
							goto case 269;
						case 188:
							num8 = 182;
							goto case 330;
						case 187:
							array2[9] = 56;
							goto case 11;
						case 11:
							num9 = 92;
							goto case 73;
						case 73:
							array2[9] = (byte)num9;
							goto case 59;
						case 59:
							num9 = 128;
							goto case 136;
						case 136:
							array2[10] = (byte)num9;
							goto case 314;
						case 185:
							num8 = 168;
							num10 = 128;
							goto case 128;
						case 128:
							array[9] = (byte)num8;
							goto case 10;
						case 182:
							array2[13] = 227;
							goto case 105;
						case 105:
							array2[14] = 160;
							goto case 318;
						case 180:
							num8 = 118;
							goto case 36;
						case 36:
							array[2] = (byte)num8;
							num7 = 143;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 178:
							num8 = 104;
							num10 = 291;
							goto case 291;
						case 176:
							array[11] = 112;
							goto case 193;
						case 172:
							num8 = 115;
							num7 = 145;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 108;
						case 169:
							array2[5] = 186;
							goto case 282;
						case 167:
							num8 = 180;
							goto case 27;
						case 27:
							array[8] = (byte)num8;
							num7 = 77;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 185;
						case 166:
							num9 = 140;
							goto case 192;
						case 164:
							array[20] = 187;
							goto case 234;
						case 163:
							num8 = 155;
							num7 = 130;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 162:
							num8 = 88;
							num7 = 62;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 51;
						case 51:
							array2[7] = 168;
							num7 = 211;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 15;
						case 15:
							array[14] = (byte)num8;
							goto case 3;
						case 160:
							array2[3] = 114;
							num7 = 93;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 69;
						case 158:
							num9 = 65;
							num7 = 75;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto case 68;
						case 68:
							array[11] = (byte)num8;
							goto case 335;
						case 154:
							array2[15] = 75;
							num10 = 254;
							goto case 254;
						case 152:
							array[24] = (byte)num8;
							goto case 98;
						case 98:
							array[24] = 154;
							goto case 112;
						case 112:
							num8 = 134;
							num10 = 261;
							goto case 261;
						case 147:
							array[16] = (byte)num8;
							goto case 17;
						case 17:
							num8 = 186;
							goto case 336;
						case 145:
							array[29] = (byte)num8;
							num7 = 14;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 12;
						case 144:
							array2[2] = 160;
							num7 = 252;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 143:
							array[2] = 91;
							goto case 290;
						case 140:
							num9 = 211;
							goto case 97;
						case 97:
							array2[4] = (byte)num9;
							goto case 169;
						case 139:
							array[21] = (byte)num8;
							num7 = 14;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 113;
						case 130:
							array[4] = (byte)num8;
							goto case 118;
						case 118:
							num8 = 68;
							goto case 245;
						case 124:
							num8 = 36;
							goto case 110;
						case 110:
							array[17] = (byte)num8;
							goto case 327;
						case 123:
							array2[1] = 147;
							num10 = 236;
							goto case 236;
						case 121:
							array2[1] = 121;
							goto case 173;
						case 120:
							array2[5] = 198;
							goto case 276;
						case 119:
							array[5] = 121;
							num10 = 220;
							goto case 220;
						case 116:
							array[3] = 119;
							goto case 321;
						case 111:
							array2[15] = (byte)num9;
							num7 = 52;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 107:
							V7HT1bB3jjXtstOUjS(object_5, CipherMode.CBC);
							num7 = 266;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 104:
							array[11] = (byte)num8;
							goto case 226;
						case 103:
							array2[3] = 123;
							goto case 277;
						case 101:
							array[20] = 129;
							goto case 164;
						case 99:
							array[5] = 150;
							goto case 119;
						case 94:
							num8 = 218;
							num7 = 147;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 93:
							array2[3] = 88;
							goto case 103;
						case 91:
							array[5] = 109;
							goto case 6;
						case 6:
							num8 = 12;
							goto case 267;
						case 89:
							array[11] = (byte)num8;
							goto case 176;
						case 84:
							num8 = 205;
							num10 = 257;
							goto case 257;
						case 83:
							array[1] = 142;
							goto case 317;
						case 80:
							array2[8] = (byte)num9;
							num7 = 1;
							if (!Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 9;
						case 9:
							array2[9] = 87;
							goto case 187;
						case 75:
							array2[7] = (byte)num9;
							num7 = 51;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 74:
							array2[3] = (byte)num9;
							goto case 160;
						case 72:
							num8 = 86;
							goto case 152;
						case 62:
							array[26] = (byte)num8;
							goto case 221;
						case 60:
							num9 = 137;
							num7 = 42;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 28;
						case 56:
							num9 = 140;
							goto case 74;
						case 52:
							array2[15] = 86;
							num7 = 154;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_01a0;
						case 48:
							array2[3] = 119;
							num7 = 56;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto case 21;
						case 21:
							array[8] = (byte)num8;
							goto case 4;
						case 4:
							array[8] = 181;
							goto case 167;
						case 40:
							num8 = 98;
							goto case 217;
						case 39:
							array[17] = (byte)num8;
							goto case 124;
						case 35:
							array[12] = 92;
							goto case 40;
						case 33:
							array2[7] = 54;
							goto case 311;
						case 32:
							array[22] = 210;
							goto case 31;
						case 31:
							num8 = 137;
							num7 = 228;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 30:
							array2[7] = (byte)num9;
							num7 = 33;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_01a0;
						case 24:
							num8 = 151;
							goto case 21;
						case 20:
							num8 = 14;
							goto case 289;
						case 18:
							num9 = 94;
							goto case 286;
						case 14:
							num8 = 89;
							goto case 322;
						case 1:
							array[7] = (byte)num8;
							goto case 316;
						default:
							num8 = 101;
							goto case 104;
						case 161:
							break;
						case 122:
							uRCyEONhllPGINqsoQ(object_4);
							goto case 100;
						case 100:
							njafpPqs0DBPpe7oPw(EfxYjc5MAS, C26qlqbcJ4aEtoouvQ(cfIfa29EDBld1IMnxI(), rqA0OhAFqpwDp3i7yZ(stream)));
							goto case 204;
						case 204:
							vOARyU37s2iKuB1gG0(stream);
							goto case 241;
						case 241:
							vOARyU37s2iKuB1gG0(object_4);
							goto case 37;
						case 37:
							sqkFhdQxVRUOrOxJa5(object_3);
							goto end_IL_2090;
						case 242:
							goto end_IL_2090;
						}
						break;
					}
					continue;
					IL_01a0:
					num7 = num10;
					goto IL_1b3a;
					continue;
					end_IL_2090:
					break;
				}
			}
			catch
			{
				int num11 = 0;
				if (!Ne7c5ZhqA7vvcxOEpn())
				{
					num11 = num12;
				}
				while (true)
				{
					switch (num11)
					{
					case 1:
						goto end_IL_211a;
					}
					do
					{
						flag = true;
						_ = 1;
					}
					while (cUAvJgt0Sy1Ns6S4E4() != null);
					continue;
					end_IL_211a:
					break;
				}
			}
			goto IL_27c1;
			IL_27c1:
			if (!flag)
			{
				goto IL_212e;
			}
			goto IL_27a6;
			IL_212e:
			try
			{
				FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
				while (true)
				{
					BinaryReader object_8 = new BinaryReader(fileStream);
					while (true)
					{
						IL_264a:
						byte[] array4 = new byte[65536];
						int num13 = 64;
						if (cUAvJgt0Sy1Ns6S4E4() != null)
						{
							goto IL_24df;
						}
						goto IL_2520;
						IL_2520:
						while (true)
						{
							int num20;
							switch (num13)
							{
							case 71:
								if (num19 <= num26)
								{
									goto case 11;
								}
								goto case 39;
							case 11:
								if (num26 < num24)
								{
									num21 = 13;
									goto case 13;
								}
								goto case 39;
							case 13:
								num16 = (uint)(num24 - num26);
								goto case 14;
							case 14:
								if (num16 < num15)
								{
									goto IL_2163;
								}
								goto case 36;
							case 39:
								if (num26 >= num24)
								{
									goto case 59;
								}
								goto case 22;
							case 59:
								iVRgKtFXeAdKQEKLH0(object_, fileStream, num15, array4);
								goto case 36;
							case 22:
								num27 = (uint)hLERYBoYiqSScNsdrf(num19 - num26, num15);
								goto case 5;
							case 5:
								iVRgKtFXeAdKQEKLH0(object_, fileStream, num27, array4);
								goto case 52;
							case 52:
								num15 -= num27;
								goto case 17;
							case 26:
								num26 = O132diLg0c9JjomOWK(fileStream);
								num13 = 71;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto case 17;
							case 17:
							case 34:
							case 50:
								if (num15 != 0)
								{
									goto case 26;
								}
								num21 = 36;
								goto case 36;
							case 36:
							case 56:
								num22++;
								goto case 57;
							case 57:
							case 61:
								if (num22 < num17)
								{
									goto IL_21e9;
								}
								goto case 8;
							case 70:
								array4[38] = 0;
								goto case 44;
							case 44:
								array4[39] = 0;
								num21 = 60;
								goto case 60;
							case 60:
								wBQA6RaonFESRSr5iU(object_, array4, 0, 128);
								goto case 53;
							case 53:
								num18 = O132diLg0c9JjomOWK(fileStream);
								goto case 58;
							case 58:
								UqfTNuTfwLIYIqZDne(fileStream, 134L);
								goto case 23;
							case 23:
								num17 = npveF5CiFWLQGJdndV(object_8);
								goto case 49;
							case 49:
								UqfTNuTfwLIYIqZDne(fileStream, num18);
								num13 = 47;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto IL_21f9;
							case 69:
								UqfTNuTfwLIYIqZDne(fileStream, O132diLg0c9JjomOWK(fileStream) + num16);
								goto case 17;
							case 68:
								UqfTNuTfwLIYIqZDne(fileStream, num25 + 32);
								num13 = 16;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto IL_21f9;
							case 66:
								wBQA6RaonFESRSr5iU(object_, array4, 0, int_);
								goto case 19;
							case 19:
								qhPPAvkplVckC1O6rB(fileStream, array4, 0, 128);
								goto case 42;
							case 42:
								array4[32] = 0;
								num21 = 24;
								goto case 24;
							case 24:
								array4[33] = 0;
								num13 = 62;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto case 21;
							case 27:
							case 65:
								uint_2 = BoGoPLZHCRDNG7Ik3P(object_8);
								num13 = 15;
								if (!Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto case 30;
							case 30:
								num25 = JIU2Bb6Rv4lMPL1WbE(uint_2, num17, num18, object_8);
								goto case 68;
							case 64:
								iVRgKtFXeAdKQEKLH0(object_, fileStream, 152u, array4);
								num13 = 1;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto IL_21f9;
							case 63:
								num24 = num19 + num14;
								num21 = 48;
								goto case 48;
							case 48:
								UqfTNuTfwLIYIqZDne(fileStream, long_);
								goto case 54;
							case 54:
								num22 = 0;
								goto case 57;
							case 62:
								array4[34] = 0;
								goto case 41;
							case 41:
								array4[35] = 0;
								num13 = 33;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto IL_21f9;
							case 38:
							case 55:
								UqfTNuTfwLIYIqZDne(fileStream, num18 + num22 * 40 + 16L);
								num13 = 0;
								if (!Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto case 12;
							case 12:
								num15 = BoGoPLZHCRDNG7Ik3P(object_8);
								goto case 2;
							case 2:
								num23 = BoGoPLZHCRDNG7Ik3P(object_8);
								goto case 43;
							case 43:
								UqfTNuTfwLIYIqZDne(fileStream, num23);
								num21 = 17;
								goto case 17;
							case 51:
								qhPPAvkplVckC1O6rB(fileStream, array4, 0, int_);
								num13 = 0;
								if (cUAvJgt0Sy1Ns6S4E4() == null)
								{
									continue;
								}
								goto IL_21f9;
							case 47:
								iVRgKtFXeAdKQEKLH0(object_, fileStream, (uint)(num17 * 40), array4);
								goto case 46;
							case 46:
								long_ = O132diLg0c9JjomOWK(fileStream);
								goto case 29;
							case 29:
								if (flag2)
								{
									num21 = 3;
									goto case 3;
								}
								goto case 40;
							case 3:
								UqfTNuTfwLIYIqZDne(fileStream, 360L);
								goto case 27;
							case 40:
								UqfTNuTfwLIYIqZDne(fileStream, 376L);
								goto case 27;
							case 45:
								if (!flag2)
								{
									goto case 28;
								}
								num20 = 96;
								goto IL_2445;
							case 28:
								num20 = 112;
								goto IL_2445;
							case 20:
								UqfTNuTfwLIYIqZDne(fileStream, 152L);
								num13 = 51;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto IL_21f9;
							case 35:
								num19 = JIU2Bb6Rv4lMPL1WbE(uint_, num17, num18, object_8);
								goto case 63;
							case 33:
								array4[36] = 0;
								goto case 4;
							case 4:
								array4[37] = 0;
								goto case 70;
							case 32:
								break;
							case 31:
								num15 -= num16;
								num13 = 55;
								if (!Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto case 69;
							case 18:
								goto IL_24c3;
							case 16:
								uint_ = BoGoPLZHCRDNG7Ik3P(object_8);
								goto case 9;
							case 9:
								num14 = BoGoPLZHCRDNG7Ik3P(object_8);
								goto case 35;
							case 15:
								goto IL_24df;
							case 1:
								flag2 = npveF5CiFWLQGJdndV(object_8) != 523;
								goto case 45;
							default:
								array4[64] = 0;
								num13 = 15;
								if (Ne7c5ZhqA7vvcxOEpn())
								{
									continue;
								}
								goto IL_21f9;
							case 6:
								goto IL_264a;
							case 37:
								goto end_IL_264a;
							case 8:
								xPbJtkyui38VPR7Kgo(object_, new byte[0], 0, 0);
								goto case 7;
							case 7:
								UqfTNuTfwLIYIqZDne(fileStream, num19);
								goto case 21;
							case 21:
								array5 = (byte[])R4HJ1LlX4XH5fdoM7k(object_8, (int)num14);
								goto case 67;
							case 67:
								AiPgOTnjEnEPZWSU48(array5);
								goto case 25;
							case 25:
								flag = !aQ9flDX2qVXFF6flNU(EfxYjc5MAS, xigHnuGiXsXuWltsHC(object_), object_2, array5);
								num21 = 10;
								goto end_IL_266b;
							case 10:
								goto end_IL_266b;
								IL_2445:
								int_ = num20;
								goto case 20;
							}
							break;
							IL_2163:
							num13 = 31;
							if (cUAvJgt0Sy1Ns6S4E4() == null)
							{
								continue;
							}
							goto IL_21f9;
							IL_21e9:
							num13 = 55;
							if (Ne7c5ZhqA7vvcxOEpn())
							{
								continue;
							}
							goto IL_21f9;
						}
						goto IL_2492;
						IL_24df:
						array4[65] = 0;
						num21 = 18;
						goto IL_24c3;
						IL_24c3:
						array4[66] = 0;
						goto IL_2492;
						IL_2492:
						array4[67] = 0;
						num13 = 66;
						if (cUAvJgt0Sy1Ns6S4E4() != null)
						{
							goto IL_21f9;
						}
						goto IL_2520;
						IL_21f9:
						num13 = num21;
						goto IL_2520;
						continue;
						end_IL_264a:
						break;
					}
					continue;
					end_IL_266b:
					break;
				}
			}
			catch
			{
				int num28 = 0;
				if (Ne7c5ZhqA7vvcxOEpn())
				{
					goto IL_26dc;
				}
				goto IL_26f9;
				IL_26dc:
				while (true)
				{
					switch (num28)
					{
					case 1:
						goto end_IL_26dc;
					}
					flag = true;
					num28 = 1;
					if (cUAvJgt0Sy1Ns6S4E4() == null)
					{
						continue;
					}
					goto IL_26f9;
					continue;
					end_IL_26dc:
					break;
				}
				goto end_IL_26cc;
				IL_26f9:
				num28 = num29;
				goto IL_26dc;
				end_IL_26cc:;
			}
			goto IL_27a6;
			IL_27a6:
			if (!flag)
			{
				num2 = 6;
				if (!Ne7c5ZhqA7vvcxOEpn())
				{
					goto IL_2711;
				}
				goto IL_2745;
			}
			goto IL_27cf;
			IL_27cf:
			throw new Exception((string?)ahH0HPEHBrh82q4fEl(NmiutCHw8eLdAVgnnW(KD1gI9Mb06isKw1VWk(gnFfywD3dI1MF09KRB(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly)), " is tampered."));
		}
	}

	public static void ni0MeIGQJw(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (BR9Y8yPcRi == null)
			{
				lock (oSjY1HtHuy)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554451)).Assembly.GetManifestResourceStream("5TxNC21JpOT24XsVxn.JNsxxdO065TZHvKXOj"));
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
							num10 ^= num10 >> 10;
							num10 += 2394925979u;
							num10 ^= num10 >> 21;
							num10 += 2049592720;
							num10 ^= num10 << 9;
							num10 += 1876088657;
							num10 = 2973374955u + num10;
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
						nZUxMxUiCboTvB3E9l nZUxMxUiCboTvB3E9l = new nZUxMxUiCboTvB3E9l(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = nZUxMxUiCboTvB3E9l.oHBY6DGaSW();
							int value = nZUxMxUiCboTvB3E9l.oHBY6DGaSW();
							dictionary.Add(key, value);
						}
						nZUxMxUiCboTvB3E9l.XtFYDP1fCf();
					}
					BR9Y8yPcRi = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num14 = BR9Y8yPcRi[metadataToken];
				bool flag = (num14 & 0x40000000) > 0;
				num14 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554451)).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(16777237));
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

	internal static void Ly0MlSYgd4()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
	internal static string NGLMxcGBhT(int int_0)
	{
		int num = 46;
		int int_ = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num16 = default(int);
		int num7 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num8 = default(int);
		byte[] array3 = default(byte[]);
		int num11 = default(int);
		int num12 = default(int);
		int num4 = default(int);
		byte[] array7 = default(byte[]);
		int num27 = default(int);
		int num26 = default(int);
		int num14 = default(int);
		uint num9 = default(uint);
		uint num6 = default(uint);
		int num24 = default(int);
		uint num25 = default(uint);
		Stream stream = default(Stream);
		uint num20 = default(uint);
		uint num10 = default(uint);
		uint num15 = default(uint);
		uint num13 = default(uint);
		int num23 = default(int);
		byte[] array5 = default(byte[]);
		uint num5 = default(uint);
		CryptoStream object_2 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_ = default(SymmetricAlgorithm);
		string result = default(string);
		int num19 = default(int);
		nZUxMxUiCboTvB3E9l object_3 = default(nZUxMxUiCboTvB3E9l);
		while (true)
		{
			IL_2875:
			if (KOIYNdOnLj.Length == 0)
			{
				goto IL_20a2;
			}
			goto IL_2853;
			IL_2853:
			int_ = O120J6anEFQTayEIQY(KOIYNdOnLj, int_0);
			int num2 = 43;
			if (cQy4wqgjDiydvCA7Nj() != null)
			{
				goto IL_0069;
			}
			goto IL_2191;
			IL_2191:
			while (true)
			{
				switch (num2)
				{
				case 429:
					num3 = 108;
					goto case 103;
				case 103:
					array[20] = (byte)num3;
					goto case 70;
				case 70:
					num3 = 160;
					goto case 343;
				case 343:
					array[20] = (byte)num3;
					goto case 61;
				case 61:
					num3 = 160;
					num = 104;
					goto case 104;
				case 104:
					array[21] = (byte)num3;
					num2 = 128;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 428:
					array2[2] = 167;
					num2 = 354;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 427:
					num3 = 138;
					goto case 66;
				case 66:
					array[11] = (byte)num3;
					goto case 287;
				case 287:
					num3 = 34;
					goto case 147;
				case 147:
					array[11] = (byte)num3;
					num2 = 184;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 426:
					num16++;
					num2 = 14;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 9;
				case 9:
					array2[4] = (byte)num7;
					goto case 90;
				case 90:
					array2[4] = 54;
					goto case 127;
				case 127:
					num7 = 154;
					num = 138;
					goto case 138;
				case 138:
					array2[4] = (byte)num7;
					goto case 179;
				case 179:
					array2[5] = 156;
					goto case 84;
				case 84:
					num7 = 85;
					goto case 187;
				case 187:
					array2[5] = (byte)num7;
					goto case 191;
				case 191:
					num7 = 171;
					goto case 372;
				case 372:
					array2[5] = (byte)num7;
					goto case 204;
				case 204:
					num7 = 84;
					goto case 316;
				case 316:
					array2[5] = (byte)num7;
					goto case 122;
				case 122:
					num7 = 40;
					num2 = 119;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 76;
				case 76:
					num3 = 155;
					num = 183;
					goto case 183;
				case 183:
					array[2] = (byte)num3;
					num2 = 137;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 216;
				case 216:
					num3 = 49;
					num2 = 263;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 425:
					array2[13] = (byte)num7;
					goto case 409;
				case 409:
					array2[14] = 168;
					goto case 71;
				case 71:
					num7 = 85;
					num2 = 279;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 424:
					array2[0] = 85;
					num = 55;
					goto case 55;
				case 55:
					num7 = 102;
					goto case 224;
				case 224:
					array2[0] = (byte)num7;
					goto case 421;
				case 421:
					array2[0] = 27;
					goto case 150;
				case 150:
					num7 = 166;
					num2 = 49;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 423:
					array[16] = 98;
					goto case 93;
				case 93:
					array[16] = 124;
					goto case 417;
				case 417:
					array[16] = 221;
					goto case 68;
				case 68:
					num3 = 164;
					goto case 7;
				case 7:
					array[17] = (byte)num3;
					goto case 400;
				case 400:
					array[17] = 105;
					goto case 382;
				case 382:
					num3 = 122;
					goto case 17;
				case 17:
					array[17] = (byte)num3;
					goto case 392;
				case 392:
					num3 = 140;
					goto case 136;
				case 136:
					array[17] = (byte)num3;
					goto case 180;
				case 180:
					num3 = 117;
					num2 = 10;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 422:
					array[4] = (byte)num3;
					goto case 317;
				case 317:
					array[4] = 118;
					num2 = 105;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 420:
					array2[15] = (byte)num7;
					goto case 277;
				case 277:
					array4 = array2;
					num = 159;
					goto case 159;
				case 159:
					o9vJsGngA7cKjKckum(array4);
					goto case 212;
				case 212:
					array6 = (byte[])SMhweIAR93lXaSIq6J(jZhje3DnrA9Yrgvylm(XoHYqExpAL));
					goto case 3;
				case 3:
					if (array6 == null)
					{
						num2 = 0;
						if (BhiMCgrQjONjW7khyr())
						{
							continue;
						}
						goto IL_0069;
					}
					goto case 87;
				case 87:
					if (array6.Length > 0)
					{
						goto case 380;
					}
					goto default;
				case 380:
					array4[1] = array6[0];
					goto case 312;
				case 312:
					array4[3] = array6[1];
					num = 244;
					goto case 244;
				case 244:
					array4[5] = array6[2];
					goto case 57;
				case 57:
					array4[7] = array6[3];
					goto case 175;
				case 175:
					array4[9] = array6[4];
					num = 146;
					goto case 146;
				case 146:
					array4[11] = array6[5];
					goto case 395;
				case 395:
					array4[13] = array6[6];
					num2 = 125;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 42;
				case 42:
					array2[7] = (byte)num7;
					goto case 64;
				case 64:
					array2[7] = 140;
					goto case 325;
				case 325:
					array2[7] = 98;
					num2 = 304;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				default:
					num8 = 0;
					num2 = 416;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 419:
					num7 = 215;
					goto case 78;
				case 78:
					array2[14] = (byte)num7;
					goto case 56;
				case 56:
					array2[15] = 107;
					num2 = 31;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 418:
					array[23] = (byte)num3;
					num2 = 361;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 113:
				case 416:
					if (num8 >= array4.Length)
					{
						break;
					}
					goto case 209;
				case 276:
					break;
				case 89:
					goto IL_048b;
				case 292:
					goto IL_04a7;
				case 323:
					goto IL_04b8;
				case 267:
					goto IL_04c0;
				case 415:
					goto IL_04cb;
				case 209:
					array3[num8] = (byte)(array3[num8] ^ array4[num8]);
					num2 = 77;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 414:
					array2[1] = 136;
					num2 = 329;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 413:
					array[23] = 120;
					goto case 205;
				case 205:
					num3 = 123;
					goto case 418;
				case 412:
					array[27] = (byte)num3;
					num2 = 188;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 411:
					num3 = 132;
					num2 = 51;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 41;
				case 41:
					array[25] = 152;
					goto case 271;
				case 271:
					array[26] = 154;
					num2 = 210;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 410:
					array[15] = 158;
					goto case 26;
				case 26:
					num3 = 138;
					num2 = 39;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 340;
				case 340:
					array[16] = (byte)num3;
					goto case 116;
				case 116:
					array[16] = 32;
					num = 423;
					goto case 423;
				case 408:
					num3 = 142;
					goto case 97;
				case 97:
					array[1] = (byte)num3;
					goto case 229;
				case 229:
					num3 = 100;
					num2 = 255;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 407:
					array[1] = (byte)num3;
					goto case 253;
				case 253:
					array[1] = 120;
					goto case 408;
				case 406:
					num3 = 92;
					num2 = 399;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 405:
					array3 = array;
					goto case 92;
				case 92:
					array2 = new byte[16];
					num2 = 374;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 374;
				case 374:
					num7 = 84;
					goto case 29;
				case 29:
					array2[0] = (byte)num7;
					goto case 424;
				case 14:
				case 404:
					if (num16 >= num11)
					{
						goto case 37;
					}
					goto case 218;
				case 37:
				case 397:
					num12++;
					goto case 330;
				case 330:
				case 332:
					if (num12 >= num4)
					{
						goto case 141;
					}
					goto case 261;
				case 141:
					KOIYNdOnLj = array7;
					num2 = 306;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 261:
					num27 = num12 % num26;
					goto case 75;
				case 75:
					num14 = num12 * 4;
					goto case 296;
				case 296:
					num9 = (uint)(num27 * 4);
					num2 = 274;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 218:
					if (num16 > 0)
					{
						goto case 270;
					}
					goto case 20;
				case 270:
					num6 <<= 8;
					goto case 196;
				case 196:
					num24 += 8;
					goto case 20;
				case 20:
					array7[num14 + num16] = (byte)((num25 & num6) >> num24);
					num2 = 353;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 426;
				case 403:
					array[13] = 108;
					goto case 95;
				case 95:
					num3 = 136;
					goto case 272;
				case 272:
					array[13] = (byte)num3;
					num = 203;
					goto case 203;
				case 203:
					array[14] = 160;
					num2 = 132;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 402:
					num3 = 90;
					num = 121;
					goto case 121;
				case 121:
					array[24] = (byte)num3;
					goto case 318;
				case 318:
					array[24] = 99;
					goto case 291;
				case 291:
					num3 = 186;
					goto case 376;
				case 376:
					array[24] = (byte)num3;
					num2 = 226;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 401:
					KOIYNdOnLj = (byte[])FqEw3SWnn9SF0BStjm(stream);
					num2 = 238;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 399:
					array[3] = (byte)num3;
					num2 = 308;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 398:
					array[22] = 124;
					goto case 351;
				case 351:
					array[22] = 43;
					goto case 102;
				case 102:
					num3 = 112;
					goto case 264;
				case 264:
					array[23] = (byte)num3;
					goto case 413;
				case 396:
					array[6] = 182;
					goto case 338;
				case 338:
					array[7] = 84;
					goto case 411;
				case 394:
					num3 = 84;
					num2 = 284;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 270;
				case 393:
					num5 = num20;
					goto case 19;
				case 19:
					if (num12 == num4 - 1)
					{
						goto case 115;
					}
					goto case 368;
				case 115:
					if (num11 > 0)
					{
						num = 201;
						goto case 201;
					}
					goto case 368;
				case 201:
					num25 = num5 ^ num10;
					num2 = 311;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 368:
					num15 = num5 ^ num10;
					goto case 98;
				case 98:
					array7[num14] = (byte)(num15 & 0xFFu);
					goto case 88;
				case 88:
					array7[num14 + 1] = (byte)((num15 & 0xFF00) >> 8);
					num2 = 290;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 391:
					array2[5] = 52;
					num2 = 111;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 68;
				case 389:
					num7 = 163;
					goto case 69;
				case 69:
					array2[12] = (byte)num7;
					num2 = 53;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 388:
					array[31] = (byte)num3;
					num = 80;
					goto case 80;
				case 80:
					array[31] = 143;
					goto case 342;
				case 342:
					num3 = 232;
					num = 23;
					goto case 23;
				case 23:
					array[31] = (byte)num3;
					num2 = 275;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 27;
				case 27:
					array[10] = (byte)num3;
					num2 = 427;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 387:
					num3 = 90;
					num2 = 366;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 386:
					num7 = 199;
					goto case 9;
				case 385:
					array[10] = (byte)num3;
					goto case 130;
				case 130:
					array[10] = 105;
					goto case 239;
				case 239:
					array[10] = 66;
					num2 = 242;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 384:
					array[26] = (byte)num3;
					goto case 217;
				case 217:
					array[26] = 47;
					num2 = 100;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 346;
				case 346:
					num3 = 185;
					goto case 33;
				case 33:
					array[27] = (byte)num3;
					num2 = 147;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 367;
				case 367:
					array[27] = 222;
					num2 = 250;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 383:
					if (num12 == num4 - 1)
					{
						goto case 134;
					}
					goto case 44;
				case 134:
					if (num11 > 0)
					{
						goto case 344;
					}
					goto case 44;
				case 344:
					num10 = 0u;
					goto case 251;
				case 251:
					num5 += num13;
					num2 = 369;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 124;
				case 124:
					num3 = 234;
					goto case 160;
				case 160:
					array[13] = (byte)num3;
					num = 403;
					goto case 403;
				case 44:
					num5 += num13;
					num2 = 107;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 240;
				case 240:
					num9 = (uint)num14;
					num2 = 96;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 381:
					num7 = 37;
					num2 = 222;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 379:
					num3 = 108;
					goto case 363;
				case 363:
					array[20] = (byte)num3;
					goto case 223;
				case 223:
					array[20] = 89;
					num2 = 429;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 378:
					num3 = 210;
					num2 = 211;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 377:
					array[8] = 184;
					num2 = 67;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 375:
					array[28] = (byte)num3;
					goto case 320;
				case 320:
					array[29] = 124;
					goto case 353;
				case 353:
					array[29] = 136;
					num2 = 154;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 157;
				case 157:
					array[29] = 80;
					num2 = 128;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 197;
				case 197:
					num3 = 42;
					goto case 258;
				case 258:
					array[30] = (byte)num3;
					goto case 309;
				case 309:
					num3 = 114;
					goto case 252;
				case 252:
					array[30] = (byte)num3;
					num2 = 1;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 8;
				case 8:
					array[30] = 92;
					num2 = 177;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 373:
					num24 = 0;
					num2 = 133;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 383;
				case 371:
					num3 = 28;
					goto case 375;
				case 370:
					array[7] = 134;
					num2 = 145;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 153;
				case 153:
					array[7] = 84;
					goto case 182;
				case 182:
					num3 = 152;
					goto case 265;
				case 265:
					array[7] = (byte)num3;
					goto case 143;
				case 143:
					array[8] = 130;
					num = 155;
					goto case 155;
				case 155:
					array[8] = 176;
					goto case 236;
				case 236:
					array[8] = 133;
					goto case 377;
				case 369:
					num23 = 0;
					num2 = 319;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 366:
					array[2] = (byte)num3;
					goto case 58;
				case 58:
					num3 = 245;
					goto case 11;
				case 11:
					array[2] = (byte)num3;
					goto case 406;
				case 365:
					num3 = 165;
					num2 = 385;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 364:
					array2[12] = 54;
					num2 = 47;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 362:
					num7 = 170;
					goto case 213;
				case 213:
					array2[2] = (byte)num7;
					goto case 428;
				case 361:
					num3 = 60;
					num2 = 79;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 349:
					num23++;
					goto case 319;
				case 319:
				case 331:
					if (num23 >= num11)
					{
						num2 = 348;
						if (BhiMCgrQjONjW7khyr())
						{
							continue;
						}
						goto IL_0069;
					}
					goto case 293;
				case 293:
					if (num23 > 0)
					{
						num2 = 298;
						if (cQy4wqgjDiydvCA7Nj() == null)
						{
							continue;
						}
						goto IL_0069;
					}
					goto case 360;
				case 360:
					num10 |= array5[^(1 + num23)];
					goto case 349;
				case 359:
					array[26] = (byte)num3;
					goto case 356;
				case 356:
					num3 = 99;
					goto case 384;
				case 358:
					array2[2] = (byte)num7;
					goto case 137;
				case 137:
					num7 = 73;
					num2 = 202;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 357:
					array[25] = (byte)num3;
					goto case 256;
				case 256:
					array[25] = 155;
					num2 = 173;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 355:
					num7 = 84;
					goto case 208;
				case 208:
					array2[11] = (byte)num7;
					num2 = 282;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 112;
				case 112:
					num3 = 174;
					goto case 131;
				case 131:
					array[0] = (byte)num3;
					num2 = 50;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 354:
					array2[3] = 148;
					num2 = 156;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 352:
					array[19] = (byte)num3;
					goto case 234;
				case 234:
					num3 = 132;
					goto case 247;
				case 247:
					array[19] = (byte)num3;
					num2 = 16;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 350:
					num7 = 144;
					goto case 118;
				case 118:
					array2[14] = (byte)num7;
					num2 = 419;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 339:
				case 348:
					num20 = num5;
					num = 246;
					goto case 246;
				case 246:
					num5 = 0u;
					num = 120;
					goto case 120;
				case 120:
				{
					uint num21 = num20;
					uint num22 = num20;
					num22 ^= num22 >> 10;
					num22 += 2394925979u;
					num22 ^= num22 >> 21;
					num22 += 2049592720;
					num22 ^= num22 << 9;
					num22 += 1876088657;
					num22 = 2973374955u + num22;
					num20 = num21 + (uint)(double)num22;
					goto case 393;
				}
				case 347:
					num13 = 0u;
					num = 135;
					goto case 135;
				case 135:
					num10 = 0u;
					num2 = 145;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 345:
					array[5] = (byte)num3;
					goto case 305;
				case 305:
					array[5] = 70;
					goto case 283;
				case 283:
					num3 = 8;
					goto case 214;
				case 214:
					array[5] = (byte)num3;
					goto case 221;
				case 221:
					array[6] = 104;
					num2 = 378;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 341:
					array[3] = (byte)num3;
					goto case 35;
				case 35:
					num3 = 119;
					num2 = 4;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 337:
					num3 = 158;
					goto case 422;
				case 336:
					array[22] = 114;
					goto case 167;
				case 167:
					num3 = 129;
					goto case 194;
				case 194:
					array[22] = (byte)num3;
					num = 398;
					goto case 398;
				case 335:
					array2[12] = (byte)num7;
					goto case 100;
				case 100:
					array2[12] = 164;
					num = 389;
					goto case 389;
				case 334:
					array[12] = 123;
					goto case 63;
				case 63:
					array[12] = 206;
					num2 = 241;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 333:
					array[7] = (byte)num3;
					num2 = 370;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 329:
					num7 = 180;
					num2 = 269;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 328:
					array[19] = 130;
					goto case 215;
				case 215:
					num3 = 78;
					goto case 190;
				case 190:
					array[19] = (byte)num3;
					num2 = 174;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 43;
				case 327:
					goto IL_1199;
				case 326:
					num3 = 99;
					num2 = 199;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 324:
					array2[1] = (byte)num7;
					num2 = 381;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 322:
					array[0] = 95;
					goto case 12;
				case 12:
					num3 = 244;
					goto case 189;
				case 189:
					array[0] = (byte)num3;
					num2 = 72;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 321:
					array2[10] = (byte)num7;
					num2 = 233;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 315:
					array[0] = 100;
					num = 301;
					goto case 301;
				case 301:
					num3 = 114;
					goto case 294;
				case 294:
					array[0] = (byte)num3;
					goto case 112;
				case 314:
					array5 = KOIYNdOnLj;
					num2 = 292;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 313:
					num3 = 104;
					num2 = 333;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 311:
					num16 = 0;
					goto case 14;
				case 310:
					array2[2] = 166;
					goto case 297;
				case 297:
					num7 = 161;
					goto case 358;
				case 308:
					num3 = 162;
					goto case 260;
				case 260:
					array[3] = (byte)num3;
					goto case 65;
				case 65:
					num3 = 92;
					goto case 341;
				case 307:
					array[5] = 92;
					num2 = 225;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 10;
				case 10:
					array[17] = (byte)num3;
					goto case 257;
				case 257:
					num3 = 133;
					goto case 148;
				case 148:
					array[18] = (byte)num3;
					num2 = 85;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 304:
					array2[7] = 153;
					num2 = 171;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 303:
					num7 = 166;
					num2 = 227;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 302:
					array2[8] = 124;
					num2 = 299;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 300:
					array[12] = (byte)num3;
					goto case 18;
				case 18:
					num3 = 247;
					num2 = 38;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 286;
				case 286:
					array[12] = (byte)num3;
					goto case 124;
				case 299:
					array2[8] = 60;
					goto case 52;
				case 52:
					array2[8] = 230;
					goto case 38;
				case 38:
					array2[9] = 94;
					goto case 273;
				case 273:
					array2[9] = 143;
					goto case 109;
				case 109:
					num7 = 117;
					num2 = 34;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 298:
					num10 <<= 8;
					goto case 360;
				case 295:
					array2[10] = 106;
					goto case 54;
				case 54:
					num7 = 148;
					goto case 321;
				case 290:
					array7[num14 + 2] = (byte)((num15 & 0xFF0000) >> 16);
					goto case 28;
				case 28:
					array7[num14 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
					num2 = 30;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 37;
				case 289:
					num3 = 153;
					num2 = 388;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 288:
					array[15] = 59;
					goto case 394;
				case 285:
					array[14] = 122;
					num2 = 5;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 284:
					array[15] = (byte)num3;
					num2 = 410;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 108;
				case 108:
					num7 = 189;
					num2 = 67;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 151;
				case 151:
					array2[10] = (byte)num7;
					goto case 206;
				case 206:
					array2[10] = 100;
					goto case 268;
				case 268:
					array2[10] = 114;
					num2 = 168;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 282:
					array2[11] = 180;
					num = 166;
					goto case 166;
				case 166:
					array2[11] = 70;
					goto case 364;
				case 281:
					array[21] = 156;
					goto case 106;
				case 106:
					num3 = 130;
					goto case 170;
				case 170:
					array[21] = (byte)num3;
					goto case 48;
				case 48:
					array[21] = 203;
					goto case 336;
				case 279:
					array2[14] = (byte)num7;
					num2 = 74;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 278:
					num7 = 23;
					num2 = 324;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 74;
				case 74:
					num7 = 103;
					num = 83;
					goto case 83;
				case 83:
					array2[14] = (byte)num7;
					num = 243;
					goto case 243;
				case 243:
					array2[14] = 125;
					num2 = 350;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 275:
					array[31] = 203;
					num2 = 195;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 8;
				case 274:
					num13 = (uint)((array3[num9 + 3] << 24) | (array3[num9 + 2] << 16) | (array3[num9 + 1] << 8) | array3[num9]);
					num2 = 30;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 7;
				case 269:
					array2[1] = (byte)num7;
					goto case 278;
				case 266:
					num7 = 110;
					goto case 149;
				case 149:
					array2[2] = (byte)num7;
					goto case 362;
				case 263:
					array[2] = (byte)num3;
					num2 = 387;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 285;
				case 262:
					array[2] = 164;
					num2 = 76;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 259:
					array[4] = 129;
					goto case 337;
				case 255:
					array[1] = (byte)num3;
					num2 = 262;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 254:
					num3 = 133;
					num2 = 129;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 250:
					num3 = 226;
					num2 = 412;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 249:
					array[31] = (byte)num3;
					num2 = 289;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 248:
					num3 = 163;
					num2 = 1;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 245:
					Mg4BptsM9yswh3iIf0(object_2, array5, 0, array5.Length);
					goto case 117;
				case 117:
					Tr34pTEcfol2J4NgSr(object_2);
					goto case 401;
				case 242:
					array[10] = 89;
					num2 = 6;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 4;
				case 4:
					array[4] = (byte)num3;
					num2 = 259;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 63;
				case 241:
					num3 = 214;
					num2 = 300;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 238:
					UO5rHlJ0wVWNBgsWn2(stream);
					goto case 172;
				case 172:
					UO5rHlJ0wVWNBgsWn2(object_2);
					goto case 314;
				case 237:
					array2[9] = 53;
					num = 295;
					goto case 295;
				case 235:
					array[18] = 252;
					goto case 165;
				case 165:
					num3 = 159;
					goto case 352;
				case 233:
					num7 = 197;
					num2 = 60;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 232:
					num7 = 236;
					num2 = 152;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 23;
				case 231:
					array[28] = (byte)num3;
					goto case 371;
				case 230:
					goto IL_18e5;
				case 228:
					array[30] = (byte)num3;
					num = 193;
					goto case 193;
				case 193:
					num3 = 101;
					num2 = 249;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 227:
					array2[11] = (byte)num7;
					goto case 355;
				case 226:
					num3 = 113;
					goto case 357;
				case 225:
					num3 = 18;
					goto case 345;
				case 222:
					array2[1] = (byte)num7;
					goto case 310;
				case 220:
					num3 = 123;
					goto case 158;
				case 158:
					array[9] = (byte)num3;
					goto case 219;
				case 219:
					array[9] = 132;
					num2 = 254;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 211:
					array[6] = (byte)num3;
					num2 = 396;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 220;
				case 210:
					num3 = 70;
					num2 = 359;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 207:
					num7 = 150;
					num2 = 82;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 202:
					array2[2] = (byte)num7;
					goto case 266;
				case 200:
					array[9] = (byte)num3;
					goto case 126;
				case 126:
					array[9] = 156;
					goto case 220;
				case 199:
					array[10] = (byte)num3;
					num = 365;
					goto case 365;
				case 198:
					num3 = 254;
					goto case 228;
				case 195:
					array[31] = 140;
					num2 = 405;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 50;
				case 50:
					array[0] = 130;
					num = 322;
					goto case 322;
				case 192:
					array2[6] = 137;
					goto case 21;
				case 21:
					num7 = 223;
					goto case 110;
				case 110:
					array2[6] = (byte)num7;
					num2 = 99;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 188:
					array[28] = 117;
					num2 = 3;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 62;
				case 62:
					num3 = 115;
					num2 = 231;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 39;
				case 39:
					array[15] = 108;
					goto case 73;
				case 73:
					array[15] = 106;
					num2 = 288;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 10;
				case 186:
					array[14] = 157;
					goto case 285;
				case 185:
					num3 = 148;
					num2 = 407;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 390;
				case 184:
					num3 = 14;
					num2 = 101;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 181:
					array[24] = 132;
					num2 = 402;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 178:
					num7 = 174;
					num = 425;
					goto case 425;
				case 177:
					array[30] = 120;
					goto case 15;
				case 15:
					array[30] = 113;
					goto case 198;
				case 176:
					num3 = 112;
					goto case 36;
				case 36:
					array[19] = (byte)num3;
					num2 = 328;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 163;
				case 163:
					num3 = 98;
					goto case 200;
				case 174:
					array[20] = 98;
					num2 = 379;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 173:
					array[25] = 97;
					goto case 41;
				case 171:
					array2[7] = 2;
					goto case 123;
				case 123:
					array2[8] = 133;
					num2 = 207;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 169:
					array[4] = 225;
					num = 307;
					goto case 307;
				case 168:
					array2[11] = 126;
					goto case 303;
				case 164:
					array2[13] = 169;
					goto case 178;
				case 162:
					array2[1] = (byte)num7;
					goto case 414;
				case 161:
					num12 = 0;
					num2 = 330;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 156:
					array2[3] = 150;
					num2 = 232;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 154:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					goto case 245;
				case 152:
					array2[3] = (byte)num7;
					goto case 24;
				case 24:
					array2[4] = 89;
					goto case 13;
				case 13:
					array2[4] = 109;
					goto case 386;
				case 145:
					if (num11 > 0)
					{
						num2 = 2;
						if (BhiMCgrQjONjW7khyr())
						{
							continue;
						}
						goto IL_0069;
					}
					goto case 81;
				case 81:
					num9 = 0u;
					num = 161;
					goto case 161;
				case 144:
					goto IL_1d51;
				case 140:
					goto IL_1d66;
				case 142:
					array[21] = 166;
					goto case 281;
				case 139:
					stream = (Stream)LxeCGj3DvtOfkn664F();
					goto case 154;
				case 133:
					array2[13] = 102;
					num2 = 164;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 132:
					array[14] = 134;
					num = 186;
					goto case 186;
				case 129:
					array[9] = (byte)num3;
					num2 = 326;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 128:
					array[21] = 167;
					num2 = 142;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 125:
					array4[15] = array6[7];
					num = 280;
					goto default;
				case 119:
					array2[5] = (byte)num7;
					goto case 391;
				case 114:
					array[4] = (byte)num3;
					goto case 169;
				case 111:
					array2[6] = 182;
					num = 59;
					goto case 59;
				case 59:
					array2[6] = 57;
					num2 = 79;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 192;
				case 107:
					array[18] = (byte)num3;
					goto case 235;
				case 105:
					num3 = 112;
					goto case 114;
				case 101:
					array[11] = (byte)num3;
					num = 248;
					goto case 248;
				case 99:
					array2[7] = 160;
					num2 = 40;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 96:
					num10 = (uint)((array5[num9 + 3] << 24) | (array5[num9 + 2] << 16) | (array5[num9 + 1] << 8) | array5[num9]);
					goto case 339;
				case 94:
					IAMsGpuuW8MSA3vwUD(object_, CipherMode.CBC);
					goto case 32;
				case 32:
					transform = (ICryptoTransform)psR8ju965miDmnhMTD(object_, array3, array4);
					num2 = 139;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 91:
					num7 = 140;
					num2 = 420;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 86:
					array[1] = 35;
					goto case 185;
				case 85:
					num3 = 124;
					goto case 107;
				case 82:
					array2[8] = (byte)num7;
					goto case 302;
				case 79:
					array[24] = (byte)num3;
					goto case 181;
				case 77:
					num8++;
					goto case 113;
				case 72:
					array[1] = 108;
					num2 = 33;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 86;
				case 67:
					array[9] = 127;
					num2 = 163;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 60:
					array2[10] = (byte)num7;
					num2 = 108;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 53:
					array2[12] = 150;
					num2 = 105;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 133;
				case 51:
					array[7] = (byte)num3;
					goto case 313;
				case 49:
					array2[1] = (byte)num7;
					num = 22;
					goto case 22;
				case 22:
					num7 = 92;
					num2 = 89;
					if (!BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto case 162;
				case 47:
					num7 = 84;
					num2 = 335;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 45:
					goto IL_20a2;
				case 40:
					num7 = 89;
					goto case 42;
				case 34:
					array2[9] = (byte)num7;
					num2 = 237;
					if (BhiMCgrQjONjW7khyr())
					{
						continue;
					}
					goto IL_0069;
				case 31:
					array2[15] = 144;
					goto case 91;
				case 30:
					num6 = 255u;
					num2 = 373;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto case 337;
				case 25:
					num5 = 0u;
					num = 347;
					goto case 347;
				case 16:
					array[19] = 148;
					goto case 176;
				case 6:
					num3 = 101;
					goto case 27;
				case 5:
					array[15] = 123;
					num2 = 39;
					if (cQy4wqgjDiydvCA7Nj() == null)
					{
						continue;
					}
					goto IL_0069;
				case 2:
					num4++;
					num2 = 32;
					if (cQy4wqgjDiydvCA7Nj() != null)
					{
						continue;
					}
					goto case 81;
				case 1:
					array[12] = (byte)num3;
					goto case 334;
				case 306:
					goto IL_2853;
				case 46:
					goto IL_2875;
				case 43:
					try
					{
						tI1DslY6Mjj4kS0esv();
						int num17 = 0;
						if (BhiMCgrQjONjW7khyr())
						{
							goto IL_289a;
						}
						goto IL_28bc;
						IL_28bc:
						switch (num17)
						{
						case 1:
							return result;
						}
						goto IL_289a;
						IL_289a:
						result = (string)Rd4P2X7FsBinT00Xja(CgnsGSmjQ16RMTbQQ1(), KOIYNdOnLj, int_0 + 4, int_);
						num17 = 1;
						if (cQy4wqgjDiydvCA7Nj() != null)
						{
							return result;
						}
						goto IL_28bc;
					}
					catch
					{
						int num18 = 0;
						if (!BhiMCgrQjONjW7khyr())
						{
							num18 = num19;
						}
						switch (num18)
						{
						}
					}
					goto case 390;
				case 390:
					return "";
				}
				break;
			}
			goto IL_0487;
			IL_20a2:
			object_3 = new nZUxMxUiCboTvB3E9l((Stream)l4D5f3NKt9J1coj3fQ(XoHYqExpAL, "rppC9Qa6yX357kBxuH.x9nwc6l86oej4AA2XD"));
			goto IL_1d51;
			IL_1d51:
			ltrhVYVnR9yKDs8OQo(dh420I8skvXOSLhoQN(object_3), 0L);
			goto IL_1d66;
			IL_1d66:
			array5 = (byte[])nuuoQKyR7Ojir5MWAw(object_3, (int)DrPuhIFpSxcf9OPBU4(dh420I8skvXOSLhoQN(object_3)));
			goto IL_18e5;
			IL_18e5:
			BKx2eVjjvxZ1tbjiBJ(object_3);
			goto IL_1199;
			IL_1199:
			array = new byte[32];
			num2 = 315;
			if (!BhiMCgrQjONjW7khyr())
			{
				goto IL_0487;
			}
			goto IL_2191;
			IL_0487:
			if (int_0 == -1)
			{
				goto IL_048b;
			}
			goto IL_04a7;
			IL_048b:
			object_ = (SymmetricAlgorithm)Q6RUSJ42qyAWPEiOaG();
			num2 = 94;
			if (!BhiMCgrQjONjW7khyr())
			{
				goto IL_0069;
			}
			goto IL_2191;
			IL_04a7:
			num11 = array5.Length % 4;
			num = 323;
			goto IL_04b8;
			IL_04b8:
			num4 = array5.Length / 4;
			goto IL_04c0;
			IL_04c0:
			array7 = new byte[array5.Length];
			goto IL_04cb;
			IL_04cb:
			num26 = array3.Length / 4;
			num2 = 25;
			if (cQy4wqgjDiydvCA7Nj() != null)
			{
				goto IL_0069;
			}
			goto IL_2191;
			IL_0069:
			num2 = num;
			goto IL_2191;
		}
	}

	[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
	internal static string SuiM5gQvpJ(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint zPyMdOLMvK(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_3, ref uint uint_1)
	{
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(intptr_2, IntPtr.Size * 2) : Marshal.ReadInt32(intptr_2, IntPtr.Size * 2));
		object obj = PUxYBYejG6[num];
		if (obj != null)
		{
			I1ho1vIqNbrKZGrIVQ i1ho1vIqNbrKZGrIVQ = (I1ho1vIqNbrKZGrIVQ)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(i1ho1vIqNbrKZGrIVQ.L52YhhxU7K.Length);
			Marshal.Copy(i1ho1vIqNbrKZGrIVQ.L52YhhxU7K, 0, intPtr, i1ho1vIqNbrKZGrIVQ.L52YhhxU7K.Length);
			if (i1ho1vIqNbrKZGrIVQ.wwIYomrkGK)
			{
				intptr_3 = intPtr;
				uint_1 = (uint)i1ho1vIqNbrKZGrIVQ.L52YhhxU7K.Length;
				KxYMTOkkct(intptr_3, i1ho1vIqNbrKZGrIVQ.L52YhhxU7K.Length, 64, ref rPNYU3VHGa);
				return 0u;
			}
			Marshal.WriteIntPtr(intptr_2, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(intptr_2, IntPtr.Size * 3, i1ho1vIqNbrKZGrIVQ.L52YhhxU7K.Length);
			uint result = 0u;
			if (uint_0 == 216669565 && !ETxYetnFfH)
			{
				ETxYetnFfH = true;
			}
			else
			{
				result = IfPYrJAk5d(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
			}
			return result;
		}
		return IfPYrJAk5d(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
	}

	private static int hIoMviEI2v()
	{
		return 5;
	}

	private static void BfqMsrIsAn()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate XDlMoaDLtI(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(16777339)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(16777255)),
			Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(16777252))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal unsafe static void uicMh577UH()
	{
		//The blocks IL_1909, IL_1915, IL_1932, IL_1955, IL_1964 are reachable both inside and outside the pinned region starting at IL_1924. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_1cda, IL_1cdf, IL_1cf6, IL_1cfc are reachable both inside and outside the pinned region starting at IL_1cd8. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 194;
		IntPtr intptr_ = default(IntPtr);
		KXBbiwxDs2avydFehE uint_ = default(KXBbiwxDs2avydFehE);
		Process object_5 = default(Process);
		IEnumerator enumerator = default(IEnumerator);
		int num33 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num38 = default(int);
		int num42 = default(int);
		int num17 = default(int);
		int num19 = default(int);
		uint num14 = default(uint);
		int num35 = default(int);
		int num15 = default(int);
		uint num22 = default(uint);
		uint num6 = default(uint);
		int num30 = default(int);
		byte[] array12 = default(byte[]);
		int num34 = default(int);
		uint num18 = default(uint);
		int num20 = default(int);
		uint num43 = default(uint);
		byte[] array11 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num4 = default(int);
		byte[] array = default(byte[]);
		long num23 = default(long);
		long value = default(long);
		uint num52 = default(uint);
		byte[] array7 = default(byte[]);
		int num62 = default(int);
		int num31 = default(int);
		uint num5 = default(uint);
		byte[] array13 = default(byte[]);
		int num3 = default(int);
		int num9 = default(int);
		int num7 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array6 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		byte[] array8 = default(byte[]);
		byte[] array2 = default(byte[]);
		int num61 = default(int);
		int num53 = default(int);
		IntPtr intptr_6 = default(IntPtr);
		nZUxMxUiCboTvB3E9l object_2 = default(nZUxMxUiCboTvB3E9l);
		int num13 = default(int);
		int num32 = default(int);
		IntPtr intPtr3 = default(IntPtr);
		int int_2 = default(int);
		int num60 = default(int);
		byte[] array5 = default(byte[]);
		int num16 = default(int);
		byte[] array10 = default(byte[]);
		MemoryStream object_11 = default(MemoryStream);
		uint nativeSizeOfCode = default(uint);
		byte[] array20 = default(byte[]);
		byte[] array18 = default(byte[]);
		ref byte reference2 = default(ref byte);
		int num59 = default(int);
		long num11 = default(long);
		int num44 = default(int);
		int num29 = default(int);
		byte[] array9 = default(byte[]);
		byte[] array19 = default(byte[]);
		string string_ = default(string);
		IntPtr procAddress = default(IntPtr);
		IntPtr intptr_5 = default(IntPtr);
		int num54 = default(int);
		int i = default(int);
		ref byte reference = default(ref byte);
		I1ho1vIqNbrKZGrIVQ i1ho1vIqNbrKZGrIVQ2 = default(I1ho1vIqNbrKZGrIVQ);
		bool wwIYomrkGK = default(bool);
		int num28 = default(int);
		IntPtr intptr_4 = default(IntPtr);
		int num51 = default(int);
		CryptoStream object_ = default(CryptoStream);
		byte[] array14 = default(byte[]);
		I1ho1vIqNbrKZGrIVQ i1ho1vIqNbrKZGrIVQ = default(I1ho1vIqNbrKZGrIVQ);
		bool flag = default(bool);
		byte[] array15 = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		int int_3 = default(int);
		byte[] l52YhhxU7K = default(byte[]);
		string text = default(string);
		ProcessModule object_10 = default(ProcessModule);
		int num47 = default(int);
		int num50 = default(int);
		NdHeKnVyPx2xIs8tph object_8 = default(NdHeKnVyPx2xIs8tph);
		IntPtr intptr_3 = default(IntPtr);
		long num12 = default(long);
		IntPtr zero = default(IntPtr);
		uint num10 = default(uint);
		int num21 = default(int);
		int num25 = default(int);
		int num27 = default(int);
		int int_ = default(int);
		while (!NnAYbCxHWY)
		{
			while (true)
			{
				IL_0013:
				NnAYbCxHWY = true;
				int num2 = 109;
				if (QrGGExopBAaXWlAk1S())
				{
					goto IL_0028;
				}
				goto IL_4411;
				IL_4411:
				intptr_ = oTJg2CAr9hM6MqcF4R((uint)uint_, 1, (uint)OaUc2pNg4VTum8rtpq(sEoauv27rI8Ehw7ag0()));
				num2 = 296;
				if (z6PBY14qmJKo3Ei6Z1() == null)
				{
					goto IL_0028;
				}
				goto IL_0c40;
				IL_0028:
				while (true)
				{
					IntPtr intptr_2;
					nint num55;
					switch (num2)
					{
					case 194:
						break;
					case 193:
						goto IL_0013;
					case 678:
						try
						{
							ProcessModuleCollection object_6 = (ProcessModuleCollection)J3VNyuHh2ow36fMh3L(object_5);
							int num36 = 1;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								while (true)
								{
									switch (num36)
									{
									case 1:
										do
										{
											enumerator = (IEnumerator)wuyQq1KZPJFkZxUuch(object_6);
											num36 = 2;
										}
										while (!QrGGExopBAaXWlAk1S());
										continue;
									case 2:
										try
										{
											while (icsfsAoCMx7klPpaLW3(enumerator))
											{
												while (true)
												{
													IL_0b8d:
													ProcessModule object_7 = (ProcessModule)YhW3Pe5Kb1m1V8sd8s(enumerator);
													int num37 = 4;
													if (QrGGExopBAaXWlAk1S())
													{
														goto IL_0b1f;
													}
													goto IL_0b6a;
													IL_0b6a:
													while (true)
													{
														switch (num37)
														{
														case 6:
															break;
														case 3:
															num33 = 0;
															num37 = 1;
															if (QrGGExopBAaXWlAk1S())
															{
																continue;
															}
															goto IL_0b35;
														case 2:
															if (intPtr2.ToInt64() != fjdYX34t0i)
															{
																goto end_IL_0b8d;
															}
															num37 = 3;
															if (!QrGGExopBAaXWlAk1S())
															{
																continue;
															}
															goto case 3;
														case 4:
															goto IL_0b8d;
														default:
															goto end_IL_0b8d;
														case 1:
														case 5:
															goto end_IL_0bad;
														}
														break;
													}
													goto IL_0b1f;
													IL_0b1f:
													intPtr2 = o0cfYPvZpW9nFd7K5g(object_7);
													num37 = 2;
													if (!QrGGExopBAaXWlAk1S())
													{
														goto IL_0b35;
													}
													goto IL_0b6a;
													IL_0b35:
													num37 = num38;
													goto IL_0b6a;
													continue;
													end_IL_0b8d:
													break;
												}
												continue;
												end_IL_0bad:
												break;
											}
										}
										finally
										{
											IDisposable disposable = enumerator as IDisposable;
											int num39 = 2;
											while (disposable != null)
											{
												int num40 = 1;
												if (z6PBY14qmJKo3Ei6Z1() != null)
												{
													goto IL_0bef;
												}
												goto IL_0bf3;
												IL_0bef:
												num40 = num39;
												goto IL_0bf3;
												IL_0bf3:
												while (true)
												{
													switch (num40)
													{
													case 1:
														goto IL_0bdb;
													default:
														goto end_IL_0bf3;
													case 2:
														break;
													case 0:
														goto end_IL_0bf3;
													}
													goto IL_0c06;
													IL_0bdb:
													XhmN57oZTrC71ps7hZT(disposable);
													num40 = 0;
													if (QrGGExopBAaXWlAk1S())
													{
														continue;
													}
													goto IL_0bef;
													continue;
													end_IL_0bf3:
													break;
												}
												break;
												IL_0c06:;
											}
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
						}
						catch
						{
							int num41 = 0;
							if (!QrGGExopBAaXWlAk1S())
							{
								num41 = num42;
							}
							switch (num41)
							{
							}
						}
						goto case 603;
					case 603:
						IfPYrJAk5d = null;
						num2 = 377;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 27:
					case 677:
						if (num17 >= num19)
						{
							goto case 148;
						}
						goto case 516;
					case 148:
					case 511:
						num14 = num14;
						goto case 79;
					case 79:
					{
						uint num63 = num14;
						uint num64 = num14;
						num64 ^= num64 >> 10;
						num64 += 2394925979u;
						num64 ^= num64 >> 21;
						num64 += 2049592720;
						num64 ^= num64 << 9;
						num64 += 1876088657;
						num64 = 2973374955u + num64;
						num14 = num63 + (uint)(double)num64;
						goto case 360;
					}
					case 360:
						if (num35 == num15 - 1)
						{
							goto case 304;
						}
						goto case 418;
					case 304:
						if (num19 > 0)
						{
							goto case 588;
						}
						goto case 418;
					case 588:
						num22 = num14 ^ num6;
						goto case 11;
					case 11:
						num30 = 0;
						goto case 125;
					case 71:
						if (num30 > 0)
						{
							num2 = 119;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 629;
					case 629:
						array12[num34 + num30] = (byte)((num22 & num18) >> num20);
						goto case 613;
					case 613:
						num30++;
						goto case 125;
					case 125:
					case 281:
						if (num30 < num19)
						{
							goto case 71;
						}
						goto case 142;
					case 418:
						num43 = num14 ^ num6;
						goto case 347;
					case 347:
						array12[num34] = (byte)(num43 & 0xFFu);
						goto case 258;
					case 516:
						if (num17 > 0)
						{
							num2 = 468;
							if (QrGGExopBAaXWlAk1S())
							{
								continue;
							}
							goto case 258;
						}
						goto case 448;
					case 258:
						array12[num34 + 1] = (byte)((num43 & 0xFF00) >> 8);
						num = 19;
						goto case 19;
					case 19:
						array12[num34 + 2] = (byte)((num43 & 0xFF0000) >> 16);
						goto case 225;
					case 225:
						array12[num34 + 3] = (byte)((num43 & 0xFF000000u) >> 24);
						goto case 142;
					case 142:
					case 672:
						num35++;
						num2 = 158;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 448:
						num6 |= array11[^(1 + num17)];
						num2 = 263;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 676:
						array3[3] = (byte)num8;
						num2 = 43;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 675:
						memoryStream = new MemoryStream();
						num2 = 609;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 674:
						num4 = 24;
						num2 = 5;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 77;
					case 77:
						array[17] = (byte)num4;
						goto case 404;
					case 404:
						num4 = 145;
						num2 = 36;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 327;
					case 327:
						array[18] = (byte)num4;
						goto case 645;
					case 645:
						array[18] = 130;
						num2 = 262;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 402;
					case 402:
						array[18] = 195;
						num2 = 594;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 451;
					case 451:
						num23 = gKO3yULyZKQERwlVhw(new IntPtr(value));
						num2 = 96;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 673:
						num8 = 125;
						goto case 213;
					case 213:
						array3[11] = (byte)num8;
						goto case 70;
					case 70:
						array3[11] = 178;
						num2 = 15;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 671:
						num52 = 0u;
						goto case 224;
					case 224:
						num35 = 0;
						goto case 158;
					case 158:
					case 528:
						if (num35 >= num15)
						{
							goto case 139;
						}
						goto case 284;
					case 139:
						array7 = array12;
						num2 = 627;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 284:
						num62 = num35 % num31;
						num = 137;
						goto case 137;
					case 137:
						num34 = num35 * 4;
						goto case 230;
					case 230:
						num52 = (uint)(num62 * 4);
						num2 = 238;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 379;
					case 379:
						num5 = (uint)((array13[num52 + 3] << 24) | (array13[num52 + 2] << 16) | (array13[num52 + 1] << 8) | array13[num52]);
						goto case 665;
					case 665:
						num18 = 255u;
						num2 = 318;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 670:
						array[21] = 160;
						num2 = 553;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 669:
						num4 = 134;
						num2 = 413;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 668:
						array[21] = (byte)num3;
						goto case 232;
					case 232:
						array[21] = 150;
						num = 223;
						goto case 223;
					case 223:
						num3 = 58;
						num2 = 31;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 22;
					case 22:
					case 606:
						if (VxoxETRrmKwUVUrKrZ() == 4)
						{
							goto case 530;
						}
						goto case 602;
					case 530:
						num9 = 9;
						num2 = 56;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 602:
						num7 = 2;
						goto case 395;
					case 395:
						array4[num7] = array6[0];
						goto case 2;
					case 2:
						array4[num7 + 1] = array6[1];
						num2 = 189;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 280;
					case 280:
						array4[num7 + 2] = array6[2];
						goto case 355;
					case 355:
						array4[num7 + 3] = array6[3];
						num = 210;
						goto case 210;
					case 210:
						array4[num7 + 4] = array6[4];
						goto case 325;
					case 325:
						array4[num7 + 5] = array6[5];
						num2 = 192;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 166;
					case 166:
						transform = (ICryptoTransform)j35dZhnw7bd7O4uF7e(object_3, array13, array8);
						goto case 394;
					case 394:
						ITD92Hy3VZf2kOmowx(array13, 0, array13.Length);
						num = 675;
						goto case 675;
					case 667:
						array[0] = (byte)num4;
						goto case 133;
					case 133:
						array[1] = 142;
						goto case 614;
					case 614:
						num4 = 87;
						num2 = 16;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 13;
					case 13:
						array2[0] = 99;
						goto case 455;
					case 455:
						array2[1] = 108;
						num2 = 651;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 334:
					case 666:
						if (num61 >= num53)
						{
							num2 = 593;
							if (QrGGExopBAaXWlAk1S())
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 196;
					case 196:
						G3AQTBTQajK1KiJJTJ(new IntPtr(intptr_6.ToInt64() + num61 * 4), eXl5gl8YW6lcumY7yk(object_2));
						goto case 587;
					case 587:
						num61++;
						num2 = 334;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 664:
						array[4] = (byte)num4;
						num2 = 365;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 663:
						array[24] = 127;
						num2 = 522;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 662:
						array3[5] = 139;
						goto case 310;
					case 310:
						array3[5] = 117;
						goto case 138;
					case 138:
						array3[6] = 131;
						num2 = 646;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 661:
						array3[4] = 92;
						goto case 542;
					case 542:
						array3[4] = 69;
						num2 = 423;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 289;
					case 55:
						num13++;
						goto case 35;
					case 35:
					case 298:
						if (num13 < num32)
						{
							goto case 370;
						}
						goto case 299;
					case 370:
						intPtr3 = new IntPtr(gObYCaGyKM + eXl5gl8YW6lcumY7yk(object_2) - num33);
						num2 = 40;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 110;
					case 110:
						KxYMTOkkct(intPtr3, 4, 4, ref int_2);
						goto case 354;
					case 354:
						if (VxoxETRrmKwUVUrKrZ() == 4)
						{
							num2 = 189;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 375;
					case 375:
						Qc4MEJi5ID(intptr_, intPtr3, (byte[])ESkPqL6uMauugWxCaw(eXl5gl8YW6lcumY7yk(object_2)), 4u, out intptr_2);
						goto case 289;
					case 289:
					case 314:
						KxYMTOkkct(intPtr3, 4, int_2, ref int_2);
						goto case 55;
					case 299:
					case 604:
						if (QRyP3wWnRsnfwZ6GPK(FvL7otDI18OTh72V4c(object_2)) < v3oRr9poqKkfGMS6Bh(FvL7otDI18OTh72V4c(object_2)) - 1L)
						{
							goto case 576;
						}
						goto case 252;
					case 576:
						num60 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 176;
					case 176:
						intptr_6 = new IntPtr(gObYCaGyKM + num60 - num33);
						goto case 18;
					case 18:
						num53 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 207;
					case 207:
						KxYMTOkkct(intptr_6, num53 * 4, 4, ref int_2);
						num = 143;
						goto case 143;
					case 143:
						num61 = 0;
						num2 = 666;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 660:
						array[3] = (byte)num4;
						goto case 25;
					case 25:
						num3 = 87;
						num2 = 29;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 373;
					case 373:
						array[3] = (byte)num3;
						goto case 211;
					case 211:
						num4 = 138;
						num2 = 340;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 600;
					case 600:
						array[3] = (byte)num4;
						num2 = 466;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 659:
						array3[15] = (byte)num8;
						num2 = 94;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 658:
						num3 = 93;
						num2 = 378;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 657:
						array3[1] = 128;
						goto case 573;
					case 573:
						num8 = 88;
						num = 6;
						goto case 6;
					case 6:
						array3[1] = (byte)num8;
						goto case 150;
					case 150:
						num8 = 70;
						num2 = 53;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 656:
						array[11] = 214;
						goto case 350;
					case 350:
						array[11] = 190;
						num2 = 242;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 655:
						array[2] = (byte)num4;
						num2 = 521;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 654:
						array5 = null;
						goto case 157;
					case 157:
						array6 = null;
						num2 = 496;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 653:
						array2[3] = 111;
						goto case 227;
					case 227:
						array2[4] = 114;
						num2 = 69;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 652:
						num16 = 121;
						goto case 291;
					case 291:
						array3[9] = (byte)num16;
						num2 = 255;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 651:
						array2[2] = 114;
						goto case 106;
					case 106:
						array2[3] = 106;
						num2 = 14;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 650:
						num4 = 147;
						num2 = 351;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 6;
					case 649:
						array[1] = 114;
						goto case 63;
					case 63:
						array[1] = 251;
						num = 478;
						goto case 478;
					case 478:
						num4 = 136;
						num2 = 415;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 280;
					case 648:
						array4[num9 + 1] = array5[1];
						goto case 635;
					case 635:
						array4[num9 + 2] = array5[2];
						goto case 344;
					case 344:
						array4[num9 + 3] = array5[3];
						num2 = 618;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 647:
						num3 = 160;
						goto case 229;
					case 229:
						array[11] = (byte)num3;
						num2 = 422;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 400;
					case 400:
						num4 = 145;
						goto case 577;
					case 577:
						array[0] = (byte)num4;
						num = 650;
						goto case 650;
					case 646:
						array3[6] = 121;
						num2 = 244;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 644:
						num16 = 93;
						goto case 50;
					case 50:
						array3[8] = (byte)num16;
						num = 633;
						goto case 633;
					case 633:
						num8 = 8;
						goto case 174;
					case 174:
						array3[8] = (byte)num8;
						goto case 100;
					case 100:
						array3[9] = 58;
						num2 = 53;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 167;
					case 167:
						num16 = 167;
						goto case 482;
					case 482:
						array3[9] = (byte)num16;
						goto case 652;
					case 643:
						array10 = null;
						goto case 654;
					case 642:
						array[19] = (byte)num3;
						goto case 30;
					case 30:
						array[19] = 130;
						goto case 396;
					case 396:
						array[19] = 87;
						goto case 476;
					case 476:
						num4 = 110;
						goto case 52;
					case 52:
						array[19] = (byte)num4;
						num2 = 33;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 641:
						if (tjy0eRt7yfGYL8FYAT(IsPxE1OR7sYyLXooOB(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly)) <= 0)
						{
							goto case 123;
						}
						num = 88;
						goto case 88;
					case 123:
					case 311:
						try
						{
							object obj5 = Q5Lq3FoMVhHXLyZA6ag(p9uqKmowWMElE41f555(Pcm19XoEcqLHmwacabx(mDKcAZoPYPbQwaKbwIk(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), Pcm19XoEcqLHmwacabx(mDKcAZoPYPbQwaKbwIk(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly)));
							int num56 = 15;
							if (!QrGGExopBAaXWlAk1S())
							{
								goto IL_1808;
							}
							goto IL_18a4;
							IL_18a4:
							while (true)
							{
								switch (num56)
								{
								case 17:
									if (tZW0VYoligZZ4oXSer0(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
									{
										goto case 13;
									}
									goto case 10;
								case 13:
									SPdYuoOxch = (IntPtr)Q5Lq3FoMVhHXLyZA6ag(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
									goto case 10;
								case 10:
									object_11 = new MemoryStream();
									goto case 4;
								case 4:
									xsRaNRiO1oIWCW1ZTP(object_11, new byte[VxoxETRrmKwUVUrKrZ()], 0, VxoxETRrmKwUVUrKrZ());
									goto case 2;
								case 2:
									if (VxoxETRrmKwUVUrKrZ() == 4)
									{
										goto case 12;
									}
									goto case 5;
								case 12:
									xsRaNRiO1oIWCW1ZTP(object_11, ESkPqL6uMauugWxCaw(SPdYuoOxch.ToInt32()), 0, 4);
									num56 = 0;
									if (z6PBY14qmJKo3Ei6Z1() == null)
									{
										continue;
									}
									break;
								case 5:
									xsRaNRiO1oIWCW1ZTP(object_11, KRCP7Qo2y2mLN6I7ViD(SPdYuoOxch.ToInt64()), 0, 8);
									goto default;
								default:
									xsRaNRiO1oIWCW1ZTP(object_11, new byte[VxoxETRrmKwUVUrKrZ()], 0, VxoxETRrmKwUVUrKrZ());
									num56 = 7;
									if (z6PBY14qmJKo3Ei6Z1() == null)
									{
										continue;
									}
									break;
								case 15:
									if (!(obj5 is IntPtr))
									{
										goto case 17;
									}
									goto case 14;
								case 14:
									SPdYuoOxch = (IntPtr)obj5;
									num56 = 17;
									if (z6PBY14qmJKo3Ei6Z1() == null)
									{
										continue;
									}
									break;
								case 9:
									d6i7Q9u4OVJTel9Uqj(object_11);
									num56 = 8;
									if (QrGGExopBAaXWlAk1S())
									{
										continue;
									}
									break;
								case 8:
									nativeSizeOfCode = 0u;
									num56 = 3;
									if (QrGGExopBAaXWlAk1S())
									{
										continue;
									}
									break;
								case 7:
									xsRaNRiO1oIWCW1ZTP(object_11, new byte[VxoxETRrmKwUVUrKrZ()], 0, VxoxETRrmKwUVUrKrZ());
									goto case 6;
								case 6:
									gLeS6lBmEf2CRfnOtS(object_11, 0L);
									num56 = 1;
									if (z6PBY14qmJKo3Ei6Z1() == null)
									{
										continue;
									}
									break;
								case 1:
									array20 = (byte[])dLqfAbbOp0KDFxs0uS(object_11);
									goto case 9;
								case 3:
									try
									{
										if ((array18 = array20) != null)
										{
											int num57 = 4;
											while (array18.Length != 0)
											{
												int num58 = 0;
												if (!QrGGExopBAaXWlAk1S())
												{
													num58 = num57;
												}
												switch (num58)
												{
												case 4:
													continue;
												case 3:
													goto end_IL_1955;
												case 2:
												case 5:
													goto IL_1964;
												case 6:
													goto end_IL_18f7;
												}
												while (true)
												{
													IL_191c:
													fixed (byte* value2 = &array18[0])
													{
														num58 = 2;
														if (z6PBY14qmJKo3Ei6Z1() == null)
														{
															while (true)
															{
																switch (num58)
																{
																case 3:
																	goto end_IL_1932;
																default:
																	goto IL_191c;
																case 4:
																	if (array18.Length != 0)
																	{
																		num58 = 0;
																		if (!QrGGExopBAaXWlAk1S())
																		{
																			num58 = num57;
																		}
																		continue;
																	}
																	goto end_IL_1932;
																case 2:
																case 5:
																	break;
																case 6:
																	goto end_IL_191c;
																}
																goto IL_1964_2;
																continue;
																end_IL_1932:
																break;
															}
															goto end_IL_1955;
														}
														goto IL_1964_2;
														IL_1964_2:
														pBcYpLH95a(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
														break;
													}
													continue;
													end_IL_191c:
													break;
												}
												goto end_IL_18f7;
												continue;
												end_IL_1955:
												break;
											}
										}
										reference2 = ref *(byte*)null;
										goto IL_1964;
										IL_1964:
										pBcYpLH95a(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
										end_IL_18f7:;
									}
									finally
									{
										reference2 = ref *(byte*)null;
										if (z6PBY14qmJKo3Ei6Z1() != null)
										{
											switch (0)
											{
											}
										}
									}
									goto end_IL_18a4;
								case 11:
									goto end_IL_18a4;
								}
								goto IL_1808;
								continue;
								end_IL_18a4:
								break;
							}
							goto end_IL_16d4;
							IL_1808:
							num56 = num59;
							goto IL_18a4;
							end_IL_16d4:;
						}
						catch
						{
							if (z6PBY14qmJKo3Ei6Z1() != null)
							{
								switch (0)
								{
								}
							}
						}
						goto case 163;
					case 322:
						vbg6eDoJSU1OnnWVZCp(k48Li4ovJOmpTkrw7Zy(NKd7Bro0gc5aGEssE0r(IfPYrJAk5d)));
						num2 = 580;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 640:
						vOLhsKmEIYeOSls48s(new IntPtr(&num11), 0, 0);
						num = 145;
						goto case 145;
					case 145:
						qPA0HjPZYgMA7LfPSO(new IntPtr(&num11), 0, 0L);
						num2 = 501;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 549;
					case 549:
						array18 = new byte[1];
						goto case 208;
					case 208:
						Y2La01wE2Cc5YLj8h7(array18, 0, LtwEVnE7sVdU9vmycY(8), 1);
						num2 = 321;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 638:
						M7j665qV0aDZjGyJmd(object_2);
						num = 361;
						goto case 361;
					case 361:
						num32 = eXl5gl8YW6lcumY7yk(object_2);
						num = 89;
						goto case 89;
					case 89:
						num44 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 113;
					case 113:
						if (num44 != 1)
						{
							num29 = 0;
							num2 = 349;
							if (QrGGExopBAaXWlAk1S())
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 447;
					case 447:
						intptr_ = IntPtr.Zero;
						num2 = 33;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 57;
					case 57:
						uint_ = (KXBbiwxDs2avydFehE)56;
						num2 = 45;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 4;
					case 4:
						array3[7] = 41;
						num2 = 513;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 637:
						vbg6eDoJSU1OnnWVZCp(k48Li4ovJOmpTkrw7Zy(NKd7Bro0gc5aGEssE0r(pBcYpLH95a)));
						num2 = 559;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 636:
						object_2 = new nZUxMxUiCboTvB3E9l(new MemoryStream(array7));
						num2 = 130;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 634:
						array[0] = 140;
						goto case 264;
					case 264:
						array[0] = 144;
						num2 = 157;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 400;
					case 632:
						array8[1] = array9[0];
						goto case 266;
					case 266:
						array8[3] = array9[1];
						goto case 352;
					case 352:
						array8[5] = array9[2];
						num2 = 40;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 140;
					case 140:
						array8[7] = array9[3];
						goto case 409;
					case 409:
						array8[9] = array9[4];
						goto case 526;
					case 526:
						array8[11] = array9[5];
						num2 = 186;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 631:
						array19 = new byte[6];
						goto case 149;
					case 149:
						array19[0] = 103;
						goto case 297;
					case 297:
						array19[1] = 101;
						goto case 146;
					case 146:
						array19[2] = 116;
						goto case 234;
					case 234:
						array19[3] = 74;
						num2 = 2;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 129;
					case 129:
						array19[4] = 105;
						num2 = 254;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 257;
					case 257:
						array19[5] = 116;
						num = 37;
						goto case 37;
					case 37:
						string_ = (string)vNNQwbXXZJIdO5Sx7L(geBlulh7xsyuUqmhFR(), array19);
						goto case 75;
					case 75:
						procAddress = GetProcAddress(intptr_5, string_);
						num2 = 518;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 630:
						array3[13] = (byte)num16;
						goto case 596;
					case 596:
						num8 = 154;
						goto case 456;
					case 456:
						array3[13] = (byte)num8;
						goto case 184;
					case 184:
						num8 = 61;
						num2 = 243;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 628:
						array3[15] = (byte)num16;
						goto case 539;
					case 539:
						num8 = 106;
						goto case 659;
					case 627:
						num54 = array7.Length / 8;
						num = 172;
						goto case 172;
					case 172:
						if ((array18 = array7) != null)
						{
							goto case 179;
						}
						goto case 216;
					case 179:
						if (array18.Length != 0)
						{
							goto case 58;
						}
						goto case 216;
					case 58:
					case 557:
						fixed (byte* ptr = &array18[0])
						{
							for (i = 0; i < num54; i++)
							{
								num55 = (nint)(ptr + (nint)i * (nint)8);
								*(long*)num55 ^= 1371585866L;
							}
						}
						goto case 502;
					case 454:
					case 487:
						i = 0;
						goto case 290;
					case 198:
						num55 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + (nint)i * (nint)8);
						*(long*)num55 ^= 1371585866L;
						goto case 66;
					case 66:
						i++;
						goto case 290;
					case 290:
					case 458:
						if (i < num54)
						{
							goto case 198;
						}
						goto case 502;
					case 502:
						reference = ref *(byte*)null;
						num2 = 636;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 216:
					case 231:
						reference = ref *(byte*)null;
						num2 = 487;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 626:
						num4 = 59;
						goto case 655;
					case 625:
						num3 = 93;
						num2 = 433;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 624:
						array3[0] = (byte)num8;
						num2 = 213;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 529;
					case 529:
						array3[0] = 53;
						num2 = 175;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 623:
						array3[5] = 92;
						num2 = 111;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 15;
					case 15:
						array3[12] = 88;
						goto case 98;
					case 98:
						num8 = 200;
						num2 = 488;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 622:
						array6 = (byte[])ESkPqL6uMauugWxCaw(SPdYuoOxch.ToInt32());
						goto case 120;
					case 120:
						array10 = (byte[])ESkPqL6uMauugWxCaw(zero.ToInt32());
						goto case 386;
					case 386:
						array5 = (byte[])ESkPqL6uMauugWxCaw(B7crCxVRDPTlCbNPvV(num23));
						num2 = 606;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 621:
						num4 = 101;
						num2 = 104;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 620:
						array4[num9 + 2] = array10[2];
						num2 = 477;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 619:
						array4[num7] = array5[0];
						num2 = 44;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 618:
						num9 = 23;
						goto case 134;
					case 134:
						array4[num9] = array10[0];
						num2 = 3;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 3;
					case 3:
						array4[num9 + 1] = array10[1];
						num2 = 620;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 617:
						array3[13] = 205;
						num = 65;
						goto case 65;
					case 65:
						array3[13] = 50;
						num2 = 432;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 616:
						array18 = new byte[1] { 42 };
						i1ho1vIqNbrKZGrIVQ2.L52YhhxU7K = array18;
						goto case 517;
					case 517:
						i1ho1vIqNbrKZGrIVQ2.wwIYomrkGK = false;
						goto case 509;
					case 509:
						SHeRiLdKH8Al7563Vp(PUxYBYejG6, 0L, i1ho1vIqNbrKZGrIVQ2);
						goto case 333;
					case 333:
						wwIYomrkGK = false;
						goto case 185;
					case 185:
					case 338:
						if (QRyP3wWnRsnfwZ6GPK(FvL7otDI18OTh72V4c(object_2)) < v3oRr9poqKkfGMS6Bh(FvL7otDI18OTh72V4c(object_2)) - 1L)
						{
							goto case 282;
						}
						goto case 275;
					case 282:
						num28 = eXl5gl8YW6lcumY7yk(object_2) - num33;
						num2 = 345;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 275:
						intPtr2 = UlqbbNataZCPy14R7W(((object[])Dr6djVUO1pZVN7OGQG(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly))[0]);
						goto case 390;
					case 390:
						fjdYX34t0i = intPtr2.ToInt64();
						num = 560;
						goto case 560;
					case 560:
						if (VxoxETRrmKwUVUrKrZ() == 4)
						{
							goto case 403;
						}
						goto case 152;
					case 403:
						A9lYk7UHNm = B7crCxVRDPTlCbNPvV(fjdYX34t0i);
						num2 = 152;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 152:
						array2 = new byte[12];
						goto case 548;
					case 548:
						array2[0] = 109;
						goto case 343;
					case 343:
						array2[1] = 115;
						goto case 73;
					case 73:
						array2[2] = 99;
						goto case 653;
					case 615:
						array3[10] = (byte)num16;
						num2 = 4;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 332;
					case 332:
						num8 = 100;
						num2 = 543;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 612:
						array[13] = (byte)num4;
						num2 = 42;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 12;
					case 12:
					case 305:
						piRwsMCL4F6L9lDrCx(intptr_4, 0);
						num2 = 54;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 611:
						cOhdBxYcRpeNiYxxPJ(array8);
						num2 = 143;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 170;
					case 170:
						array9 = (byte[])bKQl1S1sv7YD9X6BYJ(JA8yjwx4KCA8dHaNSX(XoHYqExpAL));
						num = 475;
						goto case 475;
					case 475:
						if (array9 != null)
						{
							goto case 95;
						}
						goto case 500;
					case 95:
						if (array9.Length > 0)
						{
							goto case 632;
						}
						goto case 500;
					case 500:
						num51 = 0;
						num2 = 60;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 3;
					case 610:
						num3 = 161;
						goto case 251;
					case 251:
						array[12] = (byte)num3;
						goto case 46;
					case 46:
						num4 = 44;
						num2 = 154;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 609:
						object_ = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						goto case 295;
					case 295:
						xsRaNRiO1oIWCW1ZTP(object_, array14, 0, array14.Length);
						goto case 416;
					case 416:
						gOaUXyGCKOO9T4tZDG(object_);
						num2 = 90;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 54;
					case 54:
						pBcYpLH95a = zPyMdOLMvK;
						num2 = 461;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 608:
						array[11] = (byte)num4;
						goto case 117;
					case 117:
						array[11] = 32;
						num2 = 329;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 2;
					case 607:
						array[15] = (byte)num4;
						goto case 159;
					case 159:
						num3 = 139;
						goto case 155;
					case 155:
						array[15] = (byte)num3;
						goto case 469;
					case 469:
						num4 = 103;
						goto case 495;
					case 495:
						array[15] = (byte)num4;
						num2 = 173;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 285;
					case 285:
						num4 = 35;
						goto case 29;
					case 29:
						array[15] = (byte)num4;
						num = 669;
						goto case 669;
					case 605:
						array[25] = (byte)num3;
						num2 = 151;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 601:
						mpA4TC06dWrTWw89jw(new IntPtr(&num11), 0);
						goto case 383;
					case 383:
						pbEOwasKpNbp9jjCku(new IntPtr(&num11), 0, IntPtr.Zero);
						goto case 640;
					case 599:
						array[9] = (byte)num4;
						num2 = 348;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 598:
						array2[9] = 100;
						num2 = 259;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 294;
					case 294:
						array2[10] = 108;
						num2 = 554;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 597:
						num16 = 108;
						goto case 615;
					case 595:
						array[30] = 166;
						goto case 247;
					case 247:
						array[30] = 139;
						num2 = 569;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 594:
						num3 = 248;
						goto case 5;
					case 5:
						array[18] = (byte)num3;
						goto case 505;
					case 505:
						num4 = 157;
						goto case 240;
					case 240:
						array[19] = (byte)num4;
						goto case 292;
					case 292:
						num3 = 101;
						goto case 642;
					case 593:
						KxYMTOkkct(intptr_6, num53 * 4, int_2, ref int_2);
						num2 = 604;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 592:
						if (((Array)prAaS0omDqJ1wsNOwGB(OyPrJto4LMFdd89WQfj(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly))).Length == 2)
						{
							num2 = 122;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 123;
					case 591:
						if (VxoxETRrmKwUVUrKrZ() == 4)
						{
							num2 = 426;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 453;
					case 453:
						value = FrV4tZrEn7274ReeYg(intptr_4);
						goto case 12;
					case 590:
						num7 = 30;
						goto case 479;
					case 479:
						array4[num7] = array10[0];
						goto case 494;
					case 494:
						array4[num7 + 1] = array10[1];
						goto case 87;
					case 87:
						array4[num7 + 2] = array10[2];
						goto case 141;
					case 141:
						array4[num7 + 3] = array10[3];
						num2 = 226;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 499;
					case 499:
						array4[num7 + 4] = array10[4];
						num2 = 201;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 589:
						array[23] = (byte)num4;
						num = 249;
						goto case 249;
					case 249:
						num3 = 172;
						num2 = 520;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 95;
					case 586:
						i1ho1vIqNbrKZGrIVQ = default(I1ho1vIqNbrKZGrIVQ);
						num2 = 39;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 585:
						array10 = (byte[])KRCP7Qo2y2mLN6I7ViD(zero.ToInt64());
						num2 = 0;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto default;
					default:
						array5 = (byte[])KRCP7Qo2y2mLN6I7ViD(num23);
						num = 22;
						goto case 22;
					case 584:
						array[29] = (byte)num4;
						num2 = 410;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 583:
						piRwsMCL4F6L9lDrCx(new IntPtr(&num11), 0);
						num2 = 383;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 575;
					case 575:
						nMjXJjZQVIWriFDWek(new IntPtr(&num11), 0);
						goto case 601;
					case 582:
						if (!flag)
						{
							goto case 449;
						}
						goto IL_24d8;
					case 449:
						mBA9M2g0TLIMkMgQs4();
						num2 = 122;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						return;
					case 337:
						gLeS6lBmEf2CRfnOtS(FvL7otDI18OTh72V4c(object_2), 0L);
						num2 = 427;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 581:
						num8 = 146;
						goto case 362;
					case 362:
						array3[8] = (byte)num8;
						goto case 126;
					case 126:
						array3[8] = 94;
						num2 = 558;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 346;
					case 346:
						num4 = 108;
						goto case 660;
					case 580:
						fyk92voev0ndT2p6OKm(pBcYpLH95a);
						num2 = 637;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 579:
						num52 = (uint)num34;
						goto case 566;
					case 566:
						num14 += num5;
						num = 527;
						goto case 527;
					case 527:
						num6 = (uint)((array11[num52 + 3] << 24) | (array11[num52 + 2] << 16) | (array11[num52 + 1] << 8) | array11[num52]);
						num2 = 148;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 578:
						array3[12] = 63;
						goto case 246;
					case 246:
						num8 = 97;
						goto case 76;
					case 76:
						array3[12] = (byte)num8;
						goto case 391;
					case 391:
						num16 = 183;
						goto case 630;
					case 574:
						array8[15] = array9[7];
						goto case 328;
					case 328:
						ITD92Hy3VZf2kOmowx(array9, 0, array9.Length);
						num2 = 194;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 500;
					case 572:
						num8 = 163;
						num2 = 676;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 587;
					case 571:
						array[23] = (byte)num4;
						num2 = 271;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 570:
						num4 = 55;
						goto case 107;
					case 107:
						array[22] = (byte)num4;
						goto case 262;
					case 262:
						num3 = 127;
						goto case 384;
					case 384:
						array[23] = (byte)num3;
						goto case 261;
					case 261:
						num3 = 150;
						goto case 221;
					case 221:
						array[23] = (byte)num3;
						num2 = 64;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 569:
						array[30] = 117;
						goto case 388;
					case 388:
						num3 = 93;
						num2 = 121;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 568:
						array[28] = 139;
						num2 = 183;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 567:
						array3[10] = 92;
						num2 = 429;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 191;
					case 191:
						array[13] = 67;
						num = 452;
						goto case 452;
					case 452:
						array[13] = 157;
						goto case 621;
					case 565:
						array4[num7 + 3] = array5[3];
						goto case 195;
					case 195:
						array4[num7 + 4] = array5[4];
						num = 32;
						goto case 32;
					case 32:
						array4[num7 + 5] = array5[5];
						goto case 434;
					case 434:
						array4[num7 + 6] = array5[6];
						goto case 562;
					case 562:
						array4[num7 + 7] = array5[7];
						goto case 590;
					case 564:
						array3[0] = 83;
						num2 = 219;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 563:
						num4 = 114;
						goto case 164;
					case 164:
						array[31] = (byte)num4;
						num = 153;
						goto case 153;
					case 153:
						array13 = array;
						goto case 524;
					case 524:
						array3 = new byte[16];
						goto case 564;
					case 561:
						num3 = 94;
						goto case 536;
					case 536:
						array[8] = (byte)num3;
						goto case 268;
					case 268:
						array[9] = 95;
						goto case 353;
					case 353:
						num4 = 203;
						goto case 599;
					case 559:
						array15 = null;
						goto case 250;
					case 250:
						if (VxoxETRrmKwUVUrKrZ() != 4)
						{
							num = 267;
							goto case 267;
						}
						goto case 301;
					case 267:
					{
						byte[] array16 = new byte[40];
						RO2UiloIMWPvmlGwZqG(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array15 = array16;
						goto case 68;
					}
					case 301:
					{
						byte[] array17 = new byte[30];
						RO2UiloIMWPvmlGwZqG(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array15 = array17;
						goto case 68;
					}
					case 68:
					case 545:
						intPtr = o060pjogCPPKRo63ByL(IntPtr.Zero, (uint)array15.Length, 4096u, 64u);
						num = 61;
						goto case 61;
					case 61:
						array4 = array15;
						num2 = 643;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 112;
					case 112:
						array[22] = (byte)num3;
						goto case 550;
					case 550:
						num3 = 140;
						goto case 99;
					case 99:
						array[22] = (byte)num3;
						num2 = 570;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 262;
					case 558:
						num8 = 120;
						num2 = 312;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 556:
						ITD92Hy3VZf2kOmowx(array8, 0, array8.Length);
						goto case 358;
					case 358:
						d6i7Q9u4OVJTel9Uqj(memoryStream);
						num2 = 102;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 555:
						int_3 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 160;
					case 160:
						l52YhhxU7K = (byte[])Yabteiciv7GibKQhQv(object_2, int_3);
						goto case 586;
					case 554:
						array2[11] = 108;
						goto case 24;
					case 24:
						text = (string)vNNQwbXXZJIdO5Sx7L(geBlulh7xsyuUqmhFR(), array2);
						goto case 464;
					case 464:
						intptr_5 = LoadLibrary(text);
						goto case 162;
					case 162:
						if (!vRIWUBfTAI5ydXBqLe(intptr_5, IntPtr.Zero))
						{
							goto case 631;
						}
						goto case 91;
					case 91:
						array2 = new byte[10];
						num2 = 13;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 8;
					case 8:
						num51++;
						num2 = 233;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 60;
					case 303:
						array13[num51] = (byte)(array13[num51] ^ array8[num51]);
						goto case 8;
					case 60:
					case 446:
						if (num51 >= array8.Length)
						{
							num2 = 534;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 303;
					case 553:
						array[21] = 174;
						num2 = 438;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 552:
						array3[9] = 63;
						num2 = 544;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 551:
						try
						{
							ProcessModuleCollection object_9 = (ProcessModuleCollection)J3VNyuHh2ow36fMh3L(object_5);
							if (!QrGGExopBAaXWlAk1S())
							{
								switch (0)
								{
								case 2:
									goto IL_2a2d;
								case 1:
									goto end_IL_29fb;
								}
							}
							enumerator = (IEnumerator)wuyQq1KZPJFkZxUuch(object_9);
							goto IL_2a2d;
							IL_2a2d:
							try
							{
								while (true)
								{
									IL_2b19:
									int num45;
									if (!icsfsAoCMx7klPpaLW3(enumerator))
									{
										num45 = 6;
										if (z6PBY14qmJKo3Ei6Z1() != null)
										{
											goto IL_2a55;
										}
										goto IL_2a59;
									}
									goto IL_2aeb;
									IL_2a8b:
									long num46 = num23;
									intPtr2 = o0cfYPvZpW9nFd7K5g(object_10);
									if (num46 <= intPtr2.ToInt64() + bluUrOoo2Lh2iKuLru0(object_10))
									{
										continue;
									}
									goto IL_2aa8;
									IL_2aeb:
									object_10 = (ProcessModule)YhW3Pe5Kb1m1V8sd8s(enumerator);
									num47 = 7;
									goto IL_2ad9;
									IL_2ad9:
									if (!tZW0VYoligZZ4oXSer0(VPmpC3zHCCHjbbYH93(object_10), text))
									{
										continue;
									}
									goto IL_2ac3;
									IL_2ac3:
									long num48 = num23;
									intPtr2 = o0cfYPvZpW9nFd7K5g(object_10);
									if (num48 >= intPtr2.ToInt64())
									{
										goto IL_2a8b;
									}
									goto IL_2aa8;
									IL_2aa8:
									if (OyPrJto4LMFdd89WQfj(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly) == null)
									{
										continue;
									}
									num45 = 1;
									if (!QrGGExopBAaXWlAk1S())
									{
										goto IL_2a55;
									}
									goto IL_2a59;
									IL_2a55:
									num45 = num47;
									goto IL_2a59;
									IL_2a59:
									while (true)
									{
										switch (num45)
										{
										case 1:
											break;
										default:
											return;
										case 4:
											goto end_IL_2a59;
										case 2:
											goto IL_2aa8;
										case 5:
											goto IL_2ac3;
										case 7:
											goto IL_2ad9;
										case 8:
											goto IL_2aeb;
										case 3:
										case 9:
											goto IL_2b19;
										case 0:
											return;
										case 6:
											goto end_IL_2b19;
										}
										mBA9M2g0TLIMkMgQs4();
										num45 = 0;
										if (z6PBY14qmJKo3Ei6Z1() == null)
										{
											continue;
										}
										goto IL_2a55;
										continue;
										end_IL_2a59:
										break;
									}
									goto IL_2a8b;
									continue;
									end_IL_2b19:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								int num49 = 2;
								if (z6PBY14qmJKo3Ei6Z1() != null)
								{
									num49 = num50;
								}
								do
								{
									IL_2b6b:
									switch (num49)
									{
									case 2:
										if (disposable != null)
										{
											num49 = 0;
											if (!QrGGExopBAaXWlAk1S())
											{
												goto IL_2b6b;
											}
											break;
										}
										goto end_IL_2b6b;
									case 1:
										break;
									default:
										goto end_IL_2b6b;
									case 0:
										goto end_IL_2b6b;
									}
									XhmN57oZTrC71ps7hZT(disposable);
									num49 = 0;
									continue;
									end_IL_2b6b:
									break;
								}
								while (!QrGGExopBAaXWlAk1S());
							}
							end_IL_29fb:;
						}
						catch
						{
							if (QrGGExopBAaXWlAk1S())
							{
								switch (0)
								{
								}
							}
						}
						goto case 678;
					case 547:
						array[3] = (byte)num3;
						goto case 307;
					case 307:
						num3 = 131;
						goto case 300;
					case 300:
						array[3] = (byte)num3;
						num2 = 72;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 52;
					case 546:
						int_2 = 0;
						num2 = 168;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 214;
					case 214:
						num33 = 0;
						goto case 484;
					case 484:
						if (IsPxE1OR7sYyLXooOB(XoHYqExpAL) != null)
						{
							goto case 382;
						}
						goto case 21;
					case 382:
						if (tjy0eRt7yfGYL8FYAT(IsPxE1OR7sYyLXooOB(XoHYqExpAL)) == 0)
						{
							num2 = 21;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 276;
					case 276:
						num32 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 36;
					case 36:
						num44 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 463;
					case 463:
						if (num44 != 4)
						{
							goto case 113;
						}
						goto case 316;
					case 316:
						object_3 = (SymmetricAlgorithm)FB4YtM9F07HpIiK4Bp();
						num2 = 181;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 21:
						num33 = 7680;
						num2 = 276;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 544:
						array3[10] = 91;
						goto case 597;
					case 543:
						array3[10] = (byte)num8;
						num2 = 567;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 541:
						array[27] = (byte)num3;
						goto case 420;
					case 420:
						array[27] = 89;
						goto case 209;
					case 209:
						array[27] = 164;
						num2 = 492;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 540:
						text = (string)vNNQwbXXZJIdO5Sx7L(geBlulh7xsyuUqmhFR(), array2);
						num2 = 532;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 538:
						num4 = 100;
						num2 = 441;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 537:
						num4 = 109;
						goto case 182;
					case 182:
						array[7] = (byte)num4;
						goto case 625;
					case 535:
						array[27] = (byte)num3;
						num2 = 293;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 534:
						array11 = array14;
						num2 = 364;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 533:
						array[24] = (byte)num4;
						goto case 371;
					case 371:
						num4 = 103;
						goto case 147;
					case 147:
						array[24] = (byte)num4;
						goto case 424;
					case 424:
						array[24] = 120;
						num2 = 480;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 532:
						intptr_5 = LoadLibrary(text);
						goto case 631;
					case 531:
						num16 = 204;
						goto case 628;
					case 525:
						array8 = array3;
						goto case 611;
					case 523:
						array3[6] = (byte)num8;
						num = 481;
						goto case 481;
					case 481:
						num16 = 142;
						num2 = 241;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 522:
						array[25] = 132;
						num2 = 20;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 202;
					case 202:
						array[25] = 78;
						goto case 168;
					case 168:
						array[25] = 110;
						goto case 80;
					case 80:
						num3 = 43;
						num2 = 16;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 605;
					case 521:
						num3 = 135;
						num2 = 1;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 520:
						array[23] = (byte)num3;
						goto case 115;
					case 115:
						num4 = 91;
						num2 = 533;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 519:
						array[7] = 151;
						num2 = 537;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 518:
						object_8 = (NdHeKnVyPx2xIs8tph)y0vB36SPXePEbxWurq(procAddress, NF98MhQBSFrd0aeKFh(typeof(NdHeKnVyPx2xIs8tph).TypeHandle));
						goto case 445;
					case 445:
						intptr_4 = MMFAnlj2XS0t7ABDXw(object_8);
						num = 220;
						goto case 220;
					case 220:
						value = 0L;
						goto case 591;
					case 515:
						num4 = 63;
						goto case 236;
					case 236:
						array[5] = (byte)num4;
						num2 = 116;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 514:
						num4 = 23;
						goto case 20;
					case 20:
						array[9] = (byte)num4;
						goto case 217;
					case 217:
						num3 = 164;
						num2 = 342;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 513:
						num16 = 203;
						num2 = 385;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 512:
						array[26] = 84;
						goto case 339;
					case 339:
						array[26] = 137;
						num2 = 428;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 368;
					case 368:
						array2[8] = 108;
						num = 256;
						goto case 256;
					case 256:
						array2[9] = 108;
						goto case 540;
					case 510:
						array3[11] = 167;
						goto case 673;
					case 508:
						array4[num9 + 1] = array6[1];
						num2 = 270;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 507:
						array3[5] = (byte)num16;
						goto case 462;
					case 462:
						array3[5] = 169;
						goto case 662;
					case 506:
						if (num35 != num15 - 1)
						{
							goto case 579;
						}
						num2 = 486;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 260;
					case 260:
						num4 = 70;
						goto case 664;
					case 504:
						num4 = 200;
						num = 612;
						goto case 612;
					case 503:
						num4 = 236;
						goto case 237;
					case 237:
						array[20] = (byte)num4;
						goto case 670;
					case 501:
						num3 = 136;
						num2 = 541;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 498:
						num17 = 0;
						goto case 27;
					case 497:
						array[20] = 93;
						goto case 387;
					case 387:
						array[20] = 64;
						num = 239;
						goto case 239;
					case 239:
						array[20] = 158;
						goto case 389;
					case 389:
						num3 = 233;
						goto case 93;
					case 93:
						array[20] = (byte)num3;
						goto case 503;
					case 496:
						if (VxoxETRrmKwUVUrKrZ() == 4)
						{
							num2 = 622;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 437;
					case 437:
						array6 = (byte[])KRCP7Qo2y2mLN6I7ViD(SPdYuoOxch.ToInt64());
						goto case 585;
					case 493:
						intPtr2 = UlqbbNataZCPy14R7W(((object[])Dr6djVUO1pZVN7OGQG(XoHYqExpAL))[0]);
						num2 = 132;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 492:
						num3 = 143;
						num2 = 535;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 491:
						array[8] = 140;
						goto case 444;
					case 444:
						num4 = 73;
						num2 = 238;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 490:
						ufQYSvBrsQ = intPtr2.ToInt32();
						goto case 493;
					case 489:
						array[13] = 104;
						goto case 118;
					case 118:
						num3 = 156;
						num2 = 485;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 60;
					case 488:
						array3[12] = (byte)num8;
						goto case 578;
					case 486:
						if (num19 > 0)
						{
							num2 = 83;
							if (QrGGExopBAaXWlAk1S())
							{
								continue;
							}
							goto IL_0c40;
						}
						goto case 579;
					case 485:
						array[13] = (byte)num3;
						goto case 504;
					case 483:
						array3[6] = (byte)num8;
						num2 = 472;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 480:
						array[24] = 121;
						goto case 663;
					case 477:
						array4[num9 + 3] = array10[3];
						goto case 23;
					case 23:
					case 440:
						Y2La01wE2Cc5YLj8h7(array4, 0, intPtr, array4.Length);
						num2 = 135;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 474:
						array[9] = 116;
						num2 = 199;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 473:
						num4 = 121;
						goto case 169;
					case 169:
						array[4] = (byte)num4;
						goto case 260;
					case 472:
						num8 = 187;
						goto case 523;
					case 349:
					case 471:
						if (num29 >= num32)
						{
							num2 = 431;
							if (QrGGExopBAaXWlAk1S())
							{
								continue;
							}
							goto case 47;
						}
						goto case 34;
					case 47:
						array[29] = (byte)num3;
						num2 = 421;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 34:
						intptr_3 = new IntPtr(num12 + eXl5gl8YW6lcumY7yk(object_2) - num33);
						goto case 309;
					case 309:
						KxYMTOkkct(intptr_3, 4, 4, ref int_2);
						num2 = 190;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 470:
						zero = BQxZHK7sLi1B4E7CZB(pBcYpLH95a);
						goto case 372;
					case 372:
						num23 = 0L;
						num2 = 174;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 265;
					case 265:
						if (VxoxETRrmKwUVUrKrZ() == 4)
						{
							num2 = 270;
							if (!QrGGExopBAaXWlAk1S())
							{
								continue;
							}
							goto case 451;
						}
						goto case 49;
					case 49:
						num23 = FrV4tZrEn7274ReeYg(new IntPtr(value));
						num2 = 123;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 96;
					case 96:
					case 366:
						object_5 = (Process)sEoauv27rI8Ehw7ag0();
						num2 = 551;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 476;
					case 468:
						num6 <<= 8;
						goto case 448;
					case 467:
						num4 = 59;
						goto case 435;
					case 435:
						array[12] = (byte)num4;
						goto case 191;
					case 466:
						num3 = 214;
						goto case 547;
					case 465:
						num9 = 16;
						num2 = 203;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 48;
					case 48:
						num4 = 3;
						goto case 667;
					case 461:
						zero = IntPtr.Zero;
						goto case 470;
					case 460:
						array3[2] = (byte)num16;
						num2 = 85;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 459:
						array[10] = 98;
						goto case 406;
					case 406:
						array[10] = 14;
						goto case 656;
					case 457:
						array[5] = (byte)num3;
						num2 = 515;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 450:
						array[16] = 165;
						goto case 59;
					case 59:
						array[16] = 130;
						num = 417;
						goto case 417;
					case 417:
						array[16] = 82;
						goto case 359;
					case 359:
						array[17] = 138;
						num2 = 320;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 443:
						if (num10 != 4109628145u)
						{
							goto IL_24d8;
						}
						goto case 380;
					case 380:
						flag = EonyY1IMUeyIP2kCmP(qUj2I0JP6oYJGSgpF0(o0cfYPvZpW9nFd7K5g(zHuXBoe2ToKhGhsKgX(sEoauv27rI8Ehw7ag0())), "__", 10u), IntPtr.Zero);
						goto case 582;
					case 442:
						array[14] = 113;
						goto case 114;
					case 114:
						array[14] = 116;
						goto case 425;
					case 425:
						num4 = 158;
						goto case 607;
					case 441:
						array[17] = (byte)num4;
						goto case 335;
					case 335:
						array[17] = 123;
						num2 = 674;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 439:
						array3[3] = 150;
						goto case 317;
					case 317:
						array3[3] = 130;
						num2 = 572;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 115;
					case 438:
						array[21] = 94;
						goto case 103;
					case 103:
						num3 = 207;
						num2 = 668;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 436:
						array3[14] = (byte)num8;
						num = 259;
						goto case 259;
					case 259:
						num8 = 138;
						goto case 330;
					case 330:
						array3[14] = (byte)num8;
						num2 = 218;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 433:
						array[8] = (byte)num3;
						goto case 491;
					case 432:
						array3[14] = 168;
						num2 = 156;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 64;
					case 64:
						array[23] = 145;
						num2 = 76;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 392;
					case 392:
						num4 = 91;
						num2 = 571;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 504;
					case 431:
						PUxYBYejG6 = new Hashtable(eXl5gl8YW6lcumY7yk(object_2) + 1);
						num = 171;
						goto case 171;
					case 171:
						i1ho1vIqNbrKZGrIVQ2 = default(I1ho1vIqNbrKZGrIVQ);
						goto case 616;
					case 430:
						array[10] = (byte)num4;
						goto case 459;
					case 429:
						array3[11] = 148;
						goto case 510;
					case 428:
						array[26] = 200;
						goto case 501;
					case 427:
						array14 = (byte[])Yabteiciv7GibKQhQv(object_2, (int)v3oRr9poqKkfGMS6Bh(FvL7otDI18OTh72V4c(object_2)));
						goto case 124;
					case 124:
						array = new byte[32];
						goto case 634;
					case 426:
						value = gKO3yULyZKQERwlVhw(intptr_4);
						goto case 12;
					case 423:
						num8 = 100;
						goto case 204;
					case 204:
						array3[4] = (byte)num8;
						num2 = 623;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 422:
						num4 = 150;
						goto case 608;
					case 421:
						array[29] = 158;
						goto case 658;
					case 419:
						array3[2] = 175;
						goto case 84;
					case 84:
						num16 = 202;
						goto case 460;
					case 415:
						array[2] = (byte)num4;
						goto case 626;
					case 414:
						array12 = new byte[array11.Length];
						goto case 412;
					case 412:
						num31 = array13.Length / 4;
						goto case 136;
					case 136:
						num14 = 0u;
						num2 = 41;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 413:
						array[15] = (byte)num4;
						goto case 331;
					case 331:
						num3 = 61;
						num = 9;
						goto case 9;
					case 9:
						array[15] = (byte)num3;
						goto case 450;
					case 411:
						array[4] = 118;
						goto case 473;
					case 410:
						array[29] = 111;
						num2 = 26;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 408:
						if (num21 >= 1879048192)
						{
							num2 = 51;
							if (z6PBY14qmJKo3Ei6Z1() == null)
							{
								continue;
							}
							goto case 50;
						}
						goto case 555;
					case 407:
						array3[2] = (byte)num8;
						num2 = 97;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 128;
					case 128:
						array3[2] = 83;
						goto case 439;
					case 405:
						array3[7] = 42;
						goto case 4;
					case 399:
						array2[6] = 46;
						goto case 248;
					case 248:
						array2[7] = 100;
						goto case 368;
					case 398:
						array4[num7 + 7] = array6[7];
						num2 = 306;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 397:
						KxYMTOkkct(intptr_3, 4, int_2, ref int_2);
						goto case 78;
					case 78:
						num29++;
						num2 = 471;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 18;
					case 393:
						array3[1] = 196;
						num2 = 657;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 385:
						array3[7] = (byte)num16;
						num2 = 128;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 269;
					case 269:
						array3[8] = 128;
						goto case 581;
					case 381:
						array[31] = 87;
						num2 = 376;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 39;
					case 39:
						i1ho1vIqNbrKZGrIVQ.L52YhhxU7K = l52YhhxU7K;
						goto case 188;
					case 188:
						i1ho1vIqNbrKZGrIVQ.wwIYomrkGK = wwIYomrkGK;
						goto case 105;
					case 105:
						SHeRiLdKH8Al7563Vp(PUxYBYejG6, num12 + num28, i1ho1vIqNbrKZGrIVQ);
						goto case 185;
					case 378:
						array[30] = (byte)num3;
						num2 = 70;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 144;
					case 144:
						array[30] = 138;
						num2 = 595;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 377:
						try
						{
							IfPYrJAk5d = (vmKHaGkKsKi26WI13R)y0vB36SPXePEbxWurq(new IntPtr(num23), NF98MhQBSFrd0aeKFh(typeof(vmKHaGkKsKi26WI13R).TypeHandle));
							if (!QrGGExopBAaXWlAk1S())
							{
								switch (0)
								{
								}
							}
						}
						catch
						{
							int num24 = 0;
							if (!QrGGExopBAaXWlAk1S())
							{
								num24 = num25;
							}
							switch (num24)
							{
							default:
								try
								{
									Delegate object_4 = (Delegate)y0vB36SPXePEbxWurq(new IntPtr(num23), NF98MhQBSFrd0aeKFh(typeof(vmKHaGkKsKi26WI13R).TypeHandle));
									int num26 = 0;
									if (QrGGExopBAaXWlAk1S())
									{
										goto IL_3a1f;
									}
									goto IL_3a50;
									IL_3a50:
									switch (num26)
									{
									case 1:
										goto end_IL_39fa;
									}
									goto IL_3a1f;
									IL_3a1f:
									IfPYrJAk5d = (vmKHaGkKsKi26WI13R)ponqghosh0W3IthfEwH(NF98MhQBSFrd0aeKFh(typeof(vmKHaGkKsKi26WI13R).TypeHandle), NKd7Bro0gc5aGEssE0r(object_4));
									num26 = 1;
									if (z6PBY14qmJKo3Ei6Z1() != null)
									{
										num26 = num27;
									}
									goto IL_3a50;
									end_IL_39fa:;
								}
								catch
								{
									if (!QrGGExopBAaXWlAk1S())
									{
										break;
									}
									switch (0)
									{
									default:
										goto end_IL_3a61;
									}
									end_IL_3a61:;
								}
								break;
							case 1:
								break;
							}
						}
						goto case 233;
					case 131:
						if (OyPrJto4LMFdd89WQfj(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly) == null)
						{
							goto case 123;
						}
						goto case 592;
					case 376:
						num4 = 133;
						goto case 235;
					case 235:
						array[31] = (byte)num4;
						goto case 563;
					case 374:
						num20 += 8;
						num2 = 629;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 367:
						num4 = 156;
						goto case 584;
					case 365:
						array[5] = 133;
						num2 = 222;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 245;
					case 245:
						array[5] = 145;
						num2 = 17;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 364:
						num19 = array11.Length % 4;
						num = 313;
						goto case 313;
					case 313:
						num15 = array11.Length / 4;
						num2 = 81;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 414;
					case 363:
						if (num19 <= 0)
						{
							goto case 671;
						}
						num2 = 200;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 199;
					case 199:
						num3 = 140;
						goto case 82;
					case 82:
						array[9] = (byte)num3;
						goto case 514;
					case 357:
						array4[num7 + 6] = array10[6];
						goto case 38;
					case 38:
						array4[num7 + 7] = array10[7];
						num2 = 203;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 23;
					case 351:
						array[0] = (byte)num4;
						goto case 323;
					case 323:
						num4 = 90;
						goto case 253;
					case 253:
						array[0] = (byte)num4;
						num2 = 40;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 48;
					case 348:
						array[9] = 112;
						num = 474;
						goto case 474;
					case 345:
						num21 = eXl5gl8YW6lcumY7yk(object_2);
						goto case 222;
					case 222:
						wwIYomrkGK = false;
						goto case 408;
					case 342:
						array[10] = (byte)num3;
						goto case 277;
					case 277:
						num4 = 169;
						goto case 10;
					case 10:
						array[10] = (byte)num4;
						goto case 86;
					case 86:
						num4 = 187;
						goto case 430;
					case 341:
						array[4] = 238;
						num2 = 228;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 168;
					case 340:
						array2[5] = 116;
						num2 = 370;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 399;
					case 329:
						num4 = 97;
						num2 = 127;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 326:
						num3 = 109;
						num2 = 112;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 324:
						num8 = 166;
						num2 = 456;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 624;
					case 321:
						vZEFYkM6y3kQBp4Mpa();
						num2 = 86;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 443;
					case 320:
						array[17] = 127;
						goto case 538;
					case 319:
						array3[15] = (byte)num8;
						num2 = 525;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 318:
						num20 = 0;
						goto case 506;
					case 315:
						array[6] = (byte)num3;
						goto case 273;
					case 273:
						num4 = 185;
						goto case 81;
					case 81:
						array[7] = (byte)num4;
						goto case 519;
					case 312:
						array3[8] = (byte)num8;
						goto case 644;
					case 306:
						num7 = 18;
						num2 = 619;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 302:
						array[5] = (byte)num4;
						num = 187;
						goto case 187;
					case 187:
						num3 = 134;
						goto case 457;
					case 296:
						if (VxoxETRrmKwUVUrKrZ() != 4)
						{
							goto case 493;
						}
						num = 272;
						goto case 272;
					case 272:
						intPtr2 = UlqbbNataZCPy14R7W(((object[])Dr6djVUO1pZVN7OGQG(XoHYqExpAL))[0]);
						num = 490;
						goto case 490;
					case 293:
						array[27] = 70;
						num2 = 56;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 92;
					case 92:
						array[28] = 129;
						goto case 568;
					case 288:
						array[6] = (byte)num4;
						goto case 40;
					case 40:
						num3 = 96;
						goto case 315;
					case 287:
						array2[7] = 116;
						goto case 165;
					case 165:
						array2[8] = 46;
						goto case 598;
					case 286:
						array3[2] = (byte)num8;
						num2 = 205;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 279:
						array[31] = 152;
						num2 = 381;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 278:
						intptr_2 = IntPtr.Zero;
						num2 = 178;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 119;
					case 119:
						num18 <<= 8;
						num2 = 50;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 374;
					case 274:
						array[3] = 182;
						goto case 346;
					case 271:
						num4 = 140;
						num2 = 589;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 554;
					case 270:
						array4[num9 + 2] = array6[2];
						num2 = 61;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 108;
					case 108:
						array4[num9 + 3] = array6[3];
						num2 = 465;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 263:
						num17++;
						goto case 27;
					case 255:
						array3[9] = 88;
						goto case 552;
					case 254:
						num6 = 0u;
						num2 = 498;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 244:
						num8 = 105;
						goto case 483;
					case 243:
						array3[13] = (byte)num8;
						num = 617;
						goto case 617;
					case 242:
						array[11] = 94;
						num2 = 634;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 647;
					case 241:
						array3[6] = (byte)num16;
						goto case 405;
					case 238:
						array[8] = (byte)num4;
						num2 = 561;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 228:
						array[4] = 97;
						goto case 411;
					case 226:
						num4 = 12;
						num = 288;
						goto case 288;
					case 219:
						array3[0] = 122;
						goto case 212;
					case 212:
						array3[0] = 155;
						goto case 324;
					case 218:
						array3[15] = 193;
						num2 = 42;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 180;
					case 180:
						num8 = 148;
						num2 = 62;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 206:
						num16 = 135;
						num2 = 507;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 205:
						num8 = 200;
						num2 = 407;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 203:
						array4[num9] = array5[0];
						goto case 648;
					case 201:
						array4[num7 + 5] = array10[5];
						goto case 357;
					case 200:
						num15++;
						num2 = 671;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 197:
						array[14] = (byte)num3;
						num2 = 442;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 83;
					case 83:
						num14 += num5;
						num2 = 254;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 192:
						array4[num7 + 6] = array6[6];
						num = 398;
						goto case 398;
					case 190:
						G3AQTBTQajK1KiJJTJ(intptr_3, eXl5gl8YW6lcumY7yk(object_2));
						goto case 397;
					case 189:
						Qc4MEJi5ID(intptr_, intPtr3, (byte[])ESkPqL6uMauugWxCaw(eXl5gl8YW6lcumY7yk(object_2)), 4u, out intptr_2);
						num2 = 314;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 186:
						array8[13] = array9[6];
						num2 = 574;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 562;
					case 183:
						num4 = 189;
						goto case 173;
					case 173:
						array[28] = (byte)num4;
						goto case 367;
					case 181:
						fUonaBkQdnIfougp7e(object_3, CipherMode.CBC);
						goto case 166;
					case 178:
						num13 = 0;
						num2 = 298;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 177:
						intPtr2 = UlqbbNataZCPy14R7W(((object[])Dr6djVUO1pZVN7OGQG(XoHYqExpAL))[0]);
						goto case 74;
					case 74:
						num12 = intPtr2.ToInt64();
						goto case 546;
					case 175:
						array3[1] = 132;
						goto case 393;
					case 161:
						num11 = 0L;
						num2 = 583;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 156:
						num8 = 103;
						goto case 436;
					case 154:
						array[12] = (byte)num4;
						goto case 467;
					case 151:
						array[26] = 112;
						num2 = 512;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 132:
						gObYCaGyKM = intPtr2.ToInt64();
						goto case 278;
					case 130:
						gLeS6lBmEf2CRfnOtS(FvL7otDI18OTh72V4c(object_2), 0L);
						goto case 177;
					case 127:
						array[12] = (byte)num4;
						goto case 610;
					case 122:
						if (IsPxE1OR7sYyLXooOB(NF98MhQBSFrd0aeKFh(typeof(GfA0u5bVAwirLe9Dlp).TypeHandle).Assembly) != null)
						{
							goto case 641;
						}
						goto case 123;
					case 121:
						array[31] = (byte)num3;
						num2 = 279;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 116:
						array[6] = 95;
						num2 = 226;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 111:
						array3[5] = 71;
						goto case 206;
					case 109:
						num10 = 4059231220u;
						num2 = 161;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 104:
						array[13] = (byte)num4;
						goto case 489;
					case 102:
						d6i7Q9u4OVJTel9Uqj(object_);
						goto case 638;
					case 101:
						array4[num7 + 2] = array5[2];
						goto case 565;
					case 94:
						num8 = 171;
						num2 = 130;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 319;
					case 90:
						array7 = (byte[])dLqfAbbOp0KDFxs0uS(memoryStream);
						goto case 556;
					case 85:
						num8 = 110;
						goto case 286;
					case 72:
						array[4] = 127;
						goto case 341;
					case 69:
						array2[5] = 106;
						num2 = 67;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto IL_0c40;
					case 67:
						array2[6] = 105;
						goto case 287;
					case 62:
						array3[15] = (byte)num8;
						num2 = 294;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 531;
					case 56:
						array4[num9] = array6[0];
						goto case 508;
					case 53:
						array3[1] = (byte)num8;
						goto case 419;
					case 51:
						wwIYomrkGK = true;
						goto case 555;
					case 45:
						goto IL_4411;
					case 44:
						array4[num7 + 1] = array5[1];
						goto case 101;
					case 43:
						array3[4] = 108;
						goto case 661;
					case 42:
						num3 = 154;
						num2 = 197;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 155;
					case 41:
						num5 = 0u;
						goto case 7;
					case 7:
						num6 = 0u;
						goto case 363;
					case 33:
						array[19] = 188;
						num2 = 497;
						if (z6PBY14qmJKo3Ei6Z1() == null)
						{
							continue;
						}
						goto case 6;
					case 31:
						array[21] = (byte)num3;
						num2 = 316;
						if (z6PBY14qmJKo3Ei6Z1() != null)
						{
							continue;
						}
						goto case 326;
					case 26:
						num3 = 40;
						num2 = 47;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 7;
					case 17:
						num4 = 143;
						num2 = 302;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 15;
					case 16:
						array[1] = (byte)num4;
						goto case 649;
					case 14:
						array2[4] = 105;
						goto case 340;
					case 1:
						array[2] = (byte)num3;
						num2 = 274;
						if (QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto IL_0c40;
					case 163:
						fyk92voev0ndT2p6OKm(IfPYrJAk5d);
						goto case 322;
					case 233:
					case 308:
						int_ = 0;
						num = 131;
						goto case 131;
					case 135:
						INDYV00IM8 = false;
						num = 283;
						goto case 283;
					case 283:
						KxYMTOkkct(new IntPtr(value), VxoxETRrmKwUVUrKrZ(), 64, ref int_);
						goto case 356;
					case 356:
						MHbnCho37kJutEgJaO6(new IntPtr(value), intPtr);
						goto case 401;
					case 401:
						KxYMTOkkct(new IntPtr(value), VxoxETRrmKwUVUrKrZ(), int_, ref int_);
						goto end_IL_0009;
					case 369:
						return;
					case 88:
						mBA9M2g0TLIMkMgQs4();
						num = 336;
						return;
					case 336:
						return;
					case 252:
						tkfoeRFikDXWpp9Lr8(intptr_);
						goto case 639;
					case 639:
						mBA9M2g0TLIMkMgQs4();
						return;
					case 97:
						return;
					case 215:
						goto end_IL_0009;
					case 28:
						return;
						IL_24d8:
						object_2 = new nZUxMxUiCboTvB3E9l((Stream)JyHtKo3uADQRHwKAfX(XoHYqExpAL, "jXxOOp86RvI8EnUMlt.wx62K3w30IlvDrjBZD"));
						num2 = 143;
						if (!QrGGExopBAaXWlAk1S())
						{
							continue;
						}
						goto case 337;
					}
					break;
				}
				break;
				IL_0c40:
				num2 = num;
				goto IL_0028;
			}
			continue;
			end_IL_0009:
			break;
		}
		mBA9M2g0TLIMkMgQs4();
		num = 28;
	}

	internal static object mNyMGw5oA5(object object_0)
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

	private static IntPtr wCpMDnr0gY(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (CTdYmt381X == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Find ".Trim() + "ResourceA");
			CTdYmt381X = (hs4JAHu9FR30uA3uoe)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554460)));
		}
		return CTdYmt381X(intptr_0, string_0, uint_0);
	}

	private static IntPtr fveMy8OyWI(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (vwuYaWhEjM == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Virtual ".Trim() + "Alloc");
			vwuYaWhEjM = (Cn3Pf9ec9q46FxAHpm)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554461)));
		}
		return vwuYaWhEjM(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int Qc4MEJi5ID(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (pZPYl49Mqy == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Write ".Trim() + "Process ".Trim() + "Memory");
			pZPYl49Mqy = (zTwDkwB4XBOmmHvUP8)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554462)));
		}
		return pZPYl49Mqy(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int KxYMTOkkct(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (vdmYxpvcIY == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Virtual ".Trim() + "Protect");
			vdmYxpvcIY = (OjAZ7qm500SwFlJkP1)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554463)));
		}
		return vdmYxpvcIY(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr KQgM3EgL2h(uint uint_0, int int_0, uint uint_1)
	{
		if (GKGY5ADOS9 == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Open ".Trim() + "Process");
			GKGY5ADOS9 = (KmhgQRa8DyGaVGpZge)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554464)));
		}
		return GKGY5ADOS9(uint_0, int_0, uint_1);
	}

	private static int ge8M49qld9(IntPtr intptr_0)
	{
		if (Ec5YdRF0LP == null)
		{
			IntPtr procAddress = GetProcAddress(kyPRoS01PH(), "Close ".Trim() + "Handle");
			Ec5YdRF0LP = (pm3efwlShFJJ9WWwbI)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(mekyhlvjteo7DFG64b.cEBkTnetWewfR(33554465)));
		}
		return Ec5YdRF0LP(intptr_0);
	}

	[SpecialName]
	private static IntPtr kyPRoS01PH()
	{
		if (kFTYvFSNcw == IntPtr.Zero)
		{
			kFTYvFSNcw = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return kFTYvFSNcw;
	}

	[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
	private static byte[] F74MOyEedM(string string_0)
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

	internal static Stream GtyM0KEctJ()
	{
		return new MemoryStream();
	}

	internal static byte[] BGKMz0p80c(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[U2FaXvCw9Ryi7pa7Zh(typeof(U2FaXvCw9Ryi7pa7Zh.i9QiXDrwubnvL5ZMUh<object>[]))]
	private static byte[] kR7YKW1e7X(byte[] byte_0)
	{
		Stream stream = GtyM0KEctJ();
		SymmetricAlgorithm symmetricAlgorithm = TLWMpNI0ZT();
		symmetricAlgorithm.Key = new byte[32]
		{
			53, 246, 53, 159, 155, 230, 60, 181, 78, 20,
			183, 82, 165, 56, 1, 118, 68, 96, 32, 138,
			252, 24, 119, 143, 240, 227, 67, 208, 86, 242,
			127, 140
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			154, 134, 213, 95, 60, 60, 177, 159, 155, 85,
			166, 95, 8, 109, 38, 250
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = BGKMz0p80c(stream);
		dV4xvy5LWNI0ZTFTIJ.NMBkTnOzBiYka();
		return result;
	}

	private byte[] vlIYMxYK9n()
	{
		return null;
	}

	private byte[] f28YYP74q6()
	{
		return null;
	}

	private byte[] PyOYt8qTf8()
	{
		return null;
	}

	private byte[] A9gY9rdW1c()
	{
		return null;
	}

	private byte[] ctjY7Fb6hy()
	{
		return null;
	}

	private byte[] J2NYAFYPCu()
	{
		return null;
	}

	internal byte[] zWAYJtQVfd()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] JMBYngS4li()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] B0lYi6FqVq()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] w4cYFIQmmg()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object l4D5f3NKt9J1coj3fQ(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object dh420I8skvXOSLhoQN(object object_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).RgtTUJcyZL();
	}

	internal static void ltrhVYVnR9yKDs8OQo(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long DrPuhIFpSxcf9OPBU4(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object nuuoQKyR7Ojir5MWAw(object object_0, int int_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).xIHYG426sb(int_0);
	}

	internal static void BKx2eVjjvxZ1tbjiBJ(object object_0)
	{
		((nZUxMxUiCboTvB3E9l)object_0).XtFYDP1fCf();
	}

	internal static void o9vJsGngA7cKjKckum(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object jZhje3DnrA9Yrgvylm(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object SMhweIAR93lXaSIq6J(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object Q6RUSJ42qyAWPEiOaG()
	{
		return TLWMpNI0ZT();
	}

	internal static void IAMsGpuuW8MSA3vwUD(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object psR8ju965miDmnhMTD(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object LxeCGj3DvtOfkn664F()
	{
		return GtyM0KEctJ();
	}

	internal static void Mg4BptsM9yswh3iIf0(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void Tr34pTEcfol2J4NgSr(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object FqEw3SWnn9SF0BStjm(object object_0)
	{
		return BGKMz0p80c((Stream)object_0);
	}

	internal static void UO5rHlJ0wVWNBgsWn2(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int O120J6anEFQTayEIQY(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void tI1DslY6Mjj4kS0esv()
	{
		dV4xvy5LWNI0ZTFTIJ.NMBkTnOzBiYka();
	}

	internal static object CgnsGSmjQ16RMTbQQ1()
	{
		return Encoding.Unicode;
	}

	internal static object Rd4P2X7FsBinT00Xja(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool BhiMCgrQjONjW7khyr()
	{
		return (object)null == null;
	}

	internal static object cQy4wqgjDiydvCA7Nj()
	{
		return null;
	}

	internal static void urnFwAY3YvXWNpqjND()
	{
		dV4xvy5LWNI0ZTFTIJ.NMBkTnOzBiYka();
	}

	internal static void CDxujwugInB5843HwL(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type gnFfywD3dI1MF09KRB(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object udyydcWBhOfM6SeuyU(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int NLg7OadMLXSRFo0dIT(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object zf1ZwQSUxLe7FOywKS()
	{
		return SHA1.Create();
	}

	internal static object bO8oYSsiUkCRNkSmSp(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool RGMG5x140k779Cd7bf(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object jsBFdHRQWBjNZ9sQXT(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object O7GK8lxjZLhsheIbLw(object object_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).RgtTUJcyZL();
	}

	internal static void UqfTNuTfwLIYIqZDne(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long bAxVGu0DgUGFY4foN6(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object a8kvtWPpe1LNDV190k(object object_0, int int_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).xIHYG426sb(int_0);
	}

	internal static object o3UG9Oc40BQabbml9A()
	{
		return TLWMpNI0ZT();
	}

	internal static void V7HT1bB3jjXtstOUjS(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object MmIXOGg2QUlqpkaiUr(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object JCMA1I4sYV8qMfm6CM()
	{
		return GtyM0KEctJ();
	}

	internal static void irF2m68rxt8DXE9awk(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void uRCyEONhllPGINqsoQ(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object cfIfa29EDBld1IMnxI()
	{
		return Encoding.UTF8;
	}

	internal static object rqA0OhAFqpwDp3i7yZ(object object_0)
	{
		return BGKMz0p80c((Stream)object_0);
	}

	internal static object C26qlqbcJ4aEtoouvQ(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void njafpPqs0DBPpe7oPw(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void vOARyU37s2iKuB1gG0(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void sqkFhdQxVRUOrOxJa5(object object_0)
	{
		((nZUxMxUiCboTvB3E9l)object_0).XtFYDP1fCf();
	}

	internal static void iVRgKtFXeAdKQEKLH0(object object_0, object object_1, uint uint_0, object object_2)
	{
		JB1MV7MZek((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort npveF5CiFWLQGJdndV(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int qhPPAvkplVckC1O6rB(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void wBQA6RaonFESRSr5iU(object object_0, object object_1, int int_0, int int_1)
	{
		ThlMIjteo7((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long O132diLg0c9JjomOWK(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint BoGoPLZHCRDNG7Ik3P(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint JIU2Bb6Rv4lMPL1WbE(uint uint_0, int int_0, long long_0, object object_0)
	{
		return SFGMU64bYm(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long hLERYBoYiqSScNsdrf(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object xPbJtkyui38VPR7Kgo(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object R4HJ1LlX4XH5fdoM7k(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void AiPgOTnjEnEPZWSU48(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object xigHnuGiXsXuWltsHC(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool aQ9flDX2qVXFF6flNU(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object KD1gI9Mb06isKw1VWk(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object NmiutCHw8eLdAVgnnW(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object ahH0HPEHBrh82q4fEl(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool Ne7c5ZhqA7vvcxOEpn()
	{
		return (object)null == null;
	}

	internal static object cUAvJgt0Sy1Ns6S4E4()
	{
		return null;
	}

	internal static IntPtr piRwsMCL4F6L9lDrCx(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static int nMjXJjZQVIWriFDWek(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt32(intptr_0, int_0);
	}

	internal static long mpA4TC06dWrTWw89jw(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt64(intptr_0, int_0);
	}

	internal static void pbEOwasKpNbp9jjCku(IntPtr intptr_0, int int_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
	}

	internal static void vOLhsKmEIYeOSls48s(IntPtr intptr_0, int int_0, int int_1)
	{
		Marshal.WriteInt32(intptr_0, int_0, int_1);
	}

	internal static void qPA0HjPZYgMA7LfPSO(IntPtr intptr_0, int int_0, long long_0)
	{
		Marshal.WriteInt64(intptr_0, int_0, long_0);
	}

	internal static IntPtr LtwEVnE7sVdU9vmycY(int int_0)
	{
		return Marshal.AllocCoTaskMem(int_0);
	}

	internal static void Y2La01wE2Cc5YLj8h7(object object_0, int int_0, IntPtr intptr_0, int int_1)
	{
		Marshal.Copy((byte[])object_0, int_0, intptr_0, int_1);
	}

	internal static void vZEFYkM6y3kQBp4Mpa()
	{
		BfqMsrIsAn();
	}

	internal static object sEoauv27rI8Ehw7ag0()
	{
		return Process.GetCurrentProcess();
	}

	internal static object zHuXBoe2ToKhGhsKgX(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static IntPtr o0cfYPvZpW9nFd7K5g(object object_0)
	{
		return ((ProcessModule)object_0).BaseAddress;
	}

	internal static IntPtr qUj2I0JP6oYJGSgpF0(IntPtr intptr_0, object object_0, uint uint_0)
	{
		return wCpMDnr0gY(intptr_0, (string)object_0, uint_0);
	}

	internal static bool EonyY1IMUeyIP2kCmP(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 != intptr_1;
	}

	internal static void mBA9M2g0TLIMkMgQs4()
	{
		dV4xvy5LWNI0ZTFTIJ.NMBkTnOzBiYka();
	}

	internal static object JyHtKo3uADQRHwKAfX(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object FvL7otDI18OTh72V4c(object object_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).RgtTUJcyZL();
	}

	internal static void gLeS6lBmEf2CRfnOtS(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long v3oRr9poqKkfGMS6Bh(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object Yabteiciv7GibKQhQv(object object_0, int int_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).xIHYG426sb(int_0);
	}

	internal static void cOhdBxYcRpeNiYxxPJ(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object JA8yjwx4KCA8dHaNSX(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object bKQl1S1sv7YD9X6BYJ(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static void ITD92Hy3VZf2kOmowx(object object_0, int int_0, int int_1)
	{
		Array.Clear((Array)object_0, int_0, int_1);
	}

	internal static object Dr6djVUO1pZVN7OGQG(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static IntPtr UlqbbNataZCPy14R7W(object object_0)
	{
		return Marshal.GetHINSTANCE((Module)object_0);
	}

	internal static object IsPxE1OR7sYyLXooOB(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int tjy0eRt7yfGYL8FYAT(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int eXl5gl8YW6lcumY7yk(object object_0)
	{
		return ((nZUxMxUiCboTvB3E9l)object_0).oHBY6DGaSW();
	}

	internal static object FB4YtM9F07HpIiK4Bp()
	{
		return TLWMpNI0ZT();
	}

	internal static void fUonaBkQdnIfougp7e(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object j35dZhnw7bd7O4uF7e(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static void xsRaNRiO1oIWCW1ZTP(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void gOaUXyGCKOO9T4tZDG(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object dLqfAbbOp0KDFxs0uS(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void d6i7Q9u4OVJTel9Uqj(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void M7j665qV0aDZjGyJmd(object object_0)
	{
		((nZUxMxUiCboTvB3E9l)object_0).XtFYDP1fCf();
	}

	internal static int OaUc2pNg4VTum8rtpq(object object_0)
	{
		return ((Process)object_0).Id;
	}

	internal static IntPtr oTJg2CAr9hM6MqcF4R(uint uint_0, int int_0, uint uint_1)
	{
		return KQgM3EgL2h(uint_0, int_0, uint_1);
	}

	internal static int VxoxETRrmKwUVUrKrZ()
	{
		return IntPtr.Size;
	}

	internal static object ESkPqL6uMauugWxCaw(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static long QRyP3wWnRsnfwZ6GPK(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static void G3AQTBTQajK1KiJJTJ(IntPtr intptr_0, int int_0)
	{
		Marshal.WriteInt32(intptr_0, int_0);
	}

	internal static int tkfoeRFikDXWpp9Lr8(IntPtr intptr_0)
	{
		return ge8M49qld9(intptr_0);
	}

	internal static void SHeRiLdKH8Al7563Vp(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static Type NF98MhQBSFrd0aeKFh(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int B7crCxVRDPTlCbNPvV(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static object geBlulh7xsyuUqmhFR()
	{
		return Encoding.UTF8;
	}

	internal static object vNNQwbXXZJIdO5Sx7L(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool vRIWUBfTAI5ydXBqLe(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 == intptr_1;
	}

	internal static object y0vB36SPXePEbxWurq(IntPtr intptr_0, Type type_0)
	{
		return XDlMoaDLtI(intptr_0, type_0);
	}

	internal static IntPtr MMFAnlj2XS0t7ABDXw(object object_0)
	{
		return object_0();
	}

	internal static int gKO3yULyZKQERwlVhw(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static long FrV4tZrEn7274ReeYg(IntPtr intptr_0)
	{
		return Marshal.ReadInt64(intptr_0);
	}

	internal static IntPtr BQxZHK7sLi1B4E7CZB(object object_0)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)object_0);
	}

	internal static object J3VNyuHh2ow36fMh3L(object object_0)
	{
		return ((Process)object_0).Modules;
	}

	internal static object wuyQq1KZPJFkZxUuch(object object_0)
	{
		return ((ReadOnlyCollectionBase)object_0).GetEnumerator();
	}

	internal static object YhW3Pe5Kb1m1V8sd8s(object object_0)
	{
		return ((IEnumerator)object_0).Current;
	}

	internal static object VPmpC3zHCCHjbbYH93(object object_0)
	{
		return ((ProcessModule)object_0).ModuleName;
	}

	internal static bool tZW0VYoligZZ4oXSer0(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static int bluUrOoo2Lh2iKuLru0(object object_0)
	{
		return ((ProcessModule)object_0).ModuleMemorySize;
	}

	internal static object OyPrJto4LMFdd89WQfj(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool icsfsAoCMx7klPpaLW3(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void XhmN57oZTrC71ps7hZT(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object NKd7Bro0gc5aGEssE0r(object object_0)
	{
		return ((Delegate)object_0).Method;
	}

	internal static object ponqghosh0W3IthfEwH(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static object prAaS0omDqJ1wsNOwGB(object object_0)
	{
		return ((MethodBase)object_0).GetParameters();
	}

	internal static object mDKcAZoPYPbQwaKbwIk(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}

	internal static ModuleHandle Pcm19XoEcqLHmwacabx(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}

	internal static Type p9uqKmowWMElE41f555(object object_0)
	{
		return object_0.GetType();
	}

	internal static object Q5Lq3FoMVhHXLyZA6ag(object object_0, object object_1)
	{
		return ((FieldInfo)object_0).GetValue(object_1);
	}

	internal static object KRCP7Qo2y2mLN6I7ViD(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static void fyk92voev0ndT2p6OKm(object object_0)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)object_0);
	}

	internal static RuntimeMethodHandle k48Li4ovJOmpTkrw7Zy(object object_0)
	{
		return ((MethodBase)object_0).MethodHandle;
	}

	internal static void vbg6eDoJSU1OnnWVZCp(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void RO2UiloIMWPvmlGwZqG(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static IntPtr o060pjogCPPKRo63ByL(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		return fveMy8OyWI(intptr_0, uint_0, uint_1, uint_2);
	}

	internal static void MHbnCho37kJutEgJaO6(IntPtr intptr_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, intptr_1);
	}

	internal static bool QrGGExopBAaXWlAk1S()
	{
		return (object)null == null;
	}

	internal static object z6PBY14qmJKo3Ei6Z1()
	{
		return null;
	}
}
