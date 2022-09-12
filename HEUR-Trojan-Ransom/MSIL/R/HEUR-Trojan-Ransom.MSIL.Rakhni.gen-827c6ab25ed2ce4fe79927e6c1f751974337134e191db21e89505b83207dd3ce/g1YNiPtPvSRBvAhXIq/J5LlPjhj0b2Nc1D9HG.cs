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
using gw3DRdpG9gZIr60hEO;
using qHZoQ70I3GAyXG32d6;

namespace g1YNiPtPvSRBvAhXIq;

internal class J5LlPjhj0b2Nc1D9HG
{
	private delegate void CKd2PfiQxd59kw9xmM(object o);

	internal class rkqg46k5g1HlaIfYQM : Attribute
	{
		internal class ud0s1ngLI53OSOslp1<s8bhSXxsUKKp4WCNWx>
		{
			private static object LI3AbqAnJQvgu4OpNpU;

			public ud0s1ngLI53OSOslp1()
			{
				iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
				base._002Ector();
			}

			static ud0s1ngLI53OSOslp1()
			{
				PKPIlAlcr();
			}

			internal static bool RdX4JeAkhNjkRuxGODl()
			{
				return LI3AbqAnJQvgu4OpNpU == null;
			}

			internal static object xaKhpfAtWIg4F0qYw0u()
			{
				return LI3AbqAnJQvgu4OpNpU;
			}
		}

		[rkqg46k5g1HlaIfYQM(typeof(ud0s1ngLI53OSOslp1<object>[]))]
		public rkqg46k5g1HlaIfYQM(object object_0)
		{
		}
	}

	internal class NHDfjU4ECeAkcmgdQK
	{
		[rkqg46k5g1HlaIfYQM(typeof(rkqg46k5g1HlaIfYQM.ud0s1ngLI53OSOslp1<object>[]))]
		internal static string RgZBYhVmbR(string string_0, string string_1)
		{
			byte[] array = (byte[])lxbf9aARRFskCGyxYae(pZctduAOqZJwAj1ECsQ(), string_0);
			byte[] array2 = array;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = (byte[])h3UZbtAPmcXMTgPImdB(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)Jhk3FvA5vwqbYWH6gBC();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		internal static object pZctduAOqZJwAj1ECsQ()
		{
			return Encoding.Unicode;
		}

		internal static object lxbf9aARRFskCGyxYae(object object_0, object object_1)
		{
			return ((Encoding)object_0).GetBytes((string)object_1);
		}

		internal static object h3UZbtAPmcXMTgPImdB(object object_0)
		{
			return dogc7MqGE((byte[])object_0);
		}

		internal static object Jhk3FvA5vwqbYWH6gBC()
		{
			return WbDDedUUh();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint NP5t3QaQk1NpZqVHfG(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr YdvLu1ZR21yolHOyKb();

	internal struct GedUUhuGY17EgN6Log
	{
		internal bool oWcByBhqAc;

		internal byte[] I5FBJVWaJ7;
	}

	internal class tMqGE2Mfc56saCrQNw
	{
		private BinaryReader DJBBma81Pr;

		public tMqGE2Mfc56saCrQNw(Stream stream_0)
		{
			DJBBma81Pr = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return (Stream)zc4OjnAeJjGC39CnikX(DJBBma81Pr);
		}

		internal byte[] hnmBomP2sX(int int_0)
		{
			return DJBBma81Pr.ReadBytes(int_0);
		}

		internal int UQNBKnqSh8(byte[] byte_0, int int_0, int int_1)
		{
			return DJBBma81Pr.Read(byte_0, int_0, int_1);
		}

		internal int lT0BFtnoJu()
		{
			return IxNsc4A2cVLGN9ne3ZL(DJBBma81Pr);
		}

		internal void lCUBOOInPK()
		{
			DJBBma81Pr.Close();
		}

		internal static object zc4OjnAeJjGC39CnikX(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static int IxNsc4A2cVLGN9ne3ZL(object object_0)
		{
			return ((BinaryReader)object_0).ReadInt32();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr a0QOUb9yiNKGvlKPlA(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr QcrnyH3vmnjHkq4QVR(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int gm92LE74xCqvcsZhEn(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int o5M8rwr32nldxg4ifT(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr A0sLodA3iDFMSNcutm(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int vjFTaY6t5tN3yil1Yp(IntPtr ptr);

	[Flags]
	private enum Q83uXAPQCPZ5Mw21o8
	{

	}

	private static bool R9sB4hsL4b;

	private static bool CZiBMALu3K;

	private static byte[] jPgB9tEpX9;

	internal static RSACryptoServiceProvider DRUB3vo8hI;

	private static object GK4Bp9VDII;

	private static bool g4EBXXhePK;

	internal static NP5t3QaQk1NpZqVHfG YX7BvuM8Gx;

	internal static NP5t3QaQk1NpZqVHfG CsZBQe0X1f;

	private static IntPtr EE2BSCDjJu;

	[rkqg46k5g1HlaIfYQM(typeof(rkqg46k5g1HlaIfYQM.ud0s1ngLI53OSOslp1<object>[]))]
	private static bool uSlB2GssRO;

	private static gm92LE74xCqvcsZhEn qb5BRAXhiJ;

	private static o5M8rwr32nldxg4ifT qnABNCrT3L;

	private static A0sLodA3iDFMSNcutm IqHBl56fRy;

	private static vjFTaY6t5tN3yil1Yp XMuBb9JZRd;

	private static QcrnyH3vmnjHkq4QVR BpQBn8yije;

	private static int[] DEDBTvBYMO;

	private static int KR1BD5Xa6i;

	private static IntPtr JpNB1voPKZ;

	private static a0QOUb9yiNKGvlKPlA jpiBsJQhha;

	private static object Ug8BrOkf50;

	private static Dictionary<int, int> FS0B77NOQT;

	private static byte[] stkBAFrF2l;

	private static int U53B0sDVJ1;

	private static long C47BwoN1na;

	private static SortedList LGeB5um1Ic;

	private static int J9hBWOuGad;

	private static byte[] UytB6FoLjA;

	private static bool QurBcSdGj1;

	private static uint[] xF5BZuqMfU;

	private static bool CkGBeXDkNf;

	internal static Assembly bRtBayPDJN;

	private static bool TxGBu538E2;

	internal static Hashtable RZPBIYbDLJ;

	private static int fcVBfGWPIQ;

	private static long kQyBE7pdBP;

	private static IntPtr y3dBPf7rOx;

	private static IntPtr x1fB81Mu4A;

	static J5LlPjhj0b2Nc1D9HG()
	{
		R9sB4hsL4b = false;
		bRtBayPDJN = Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554447)).Assembly;
		xF5BZuqMfU = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		TxGBu538E2 = false;
		CZiBMALu3K = false;
		jPgB9tEpX9 = new byte[0];
		DRUB3vo8hI = null;
		FS0B77NOQT = null;
		Ug8BrOkf50 = new object();
		stkBAFrF2l = new byte[0];
		UytB6FoLjA = new byte[0];
		y3dBPf7rOx = IntPtr.Zero;
		JpNB1voPKZ = IntPtr.Zero;
		GK4Bp9VDII = new string[0];
		DEDBTvBYMO = new int[0];
		U53B0sDVJ1 = 1;
		g4EBXXhePK = false;
		LGeB5um1Ic = new SortedList();
		J9hBWOuGad = 0;
		kQyBE7pdBP = 0L;
		YX7BvuM8Gx = null;
		CsZBQe0X1f = null;
		C47BwoN1na = 0L;
		KR1BD5Xa6i = 0;
		CkGBeXDkNf = false;
		QurBcSdGj1 = false;
		fcVBfGWPIQ = 0;
		EE2BSCDjJu = IntPtr.Zero;
		uSlB2GssRO = false;
		RZPBIYbDLJ = new Hashtable();
		jpiBsJQhha = null;
		BpQBn8yije = null;
		qb5BRAXhiJ = null;
		qnABNCrT3L = null;
		IqHBl56fRy = null;
		XMuBb9JZRd = null;
		x1fB81Mu4A = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void jw5Lcox5t11Cy()
	{
	}

	internal static byte[] y4WXCNWxn(byte[] byte_0)
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
			gDf5jUECe(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			gDf5jUECe(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			gDf5jUECe(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			gDf5jUECe(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			gDf5jUECe(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			gDf5jUECe(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			gDf5jUECe(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			gDf5jUECe(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			gDf5jUECe(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			gDf5jUECe(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			gDf5jUECe(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			gDf5jUECe(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			gDf5jUECe(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			gDf5jUECe(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			gDf5jUECe(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			gDf5jUECe(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			ukcWmgdQK(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			ukcWmgdQK(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			ukcWmgdQK(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			ukcWmgdQK(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			ukcWmgdQK(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			ukcWmgdQK(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			ukcWmgdQK(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			ukcWmgdQK(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			ukcWmgdQK(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			ukcWmgdQK(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			ukcWmgdQK(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			ukcWmgdQK(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			ukcWmgdQK(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			ukcWmgdQK(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			ukcWmgdQK(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			ukcWmgdQK(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			NP5Et3QQk(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			NP5Et3QQk(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			NP5Et3QQk(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			NP5Et3QQk(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			NP5Et3QQk(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			NP5Et3QQk(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			NP5Et3QQk(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			NP5Et3QQk(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			NP5Et3QQk(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			NP5Et3QQk(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			NP5Et3QQk(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			NP5Et3QQk(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			NP5Et3QQk(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			NP5Et3QQk(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			NP5Et3QQk(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			NP5Et3QQk(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			yNpvZqVHf(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			yNpvZqVHf(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			yNpvZqVHf(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			yNpvZqVHf(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			yNpvZqVHf(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			yNpvZqVHf(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			yNpvZqVHf(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			yNpvZqVHf(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			yNpvZqVHf(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			yNpvZqVHf(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			yNpvZqVHf(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			yNpvZqVHf(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			yNpvZqVHf(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			yNpvZqVHf(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			yNpvZqVHf(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			yNpvZqVHf(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void gDf5jUECe(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + amdQvLu1R(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + xF5BZuqMfU[uint_5 - 1], ushort_0);
	}

	private static void ukcWmgdQK(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + amdQvLu1R(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + xF5BZuqMfU[uint_5 - 1], ushort_0);
	}

	private static void NP5Et3QQk(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + amdQvLu1R(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + xF5BZuqMfU[uint_5 - 1], ushort_0);
	}

	private static void yNpvZqVHf(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + amdQvLu1R(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + xF5BZuqMfU[uint_5 - 1], ushort_0);
	}

	private static uint amdQvLu1R(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool L1ywolHOy()
	{
		if (!TxGBu538E2)
		{
			aY1e7EgN6();
			TxGBu538E2 = true;
		}
		return CZiBMALu3K;
	}

	internal static SymmetricAlgorithm WbDDedUUh()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (L1ywolHOy())
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

	internal static void aY1e7EgN6()
	{
		try
		{
			CZiBMALu3K = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] dogc7MqGE(byte[] byte_0)
	{
		if (!L1ywolHOy())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return y4WXCNWxn(byte_0);
	}

	internal static void Lfcf56saC(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			uQNSwG0QO(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void uQNSwG0QO(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint hby2iNKGv(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	[rkqg46k5g1HlaIfYQM(typeof(rkqg46k5g1HlaIfYQM.ud0s1ngLI53OSOslp1<object>[]))]
	internal static void PKPIlAlcr()
	{
		//IL_223e: Incompatible stack heights: 0 vs 1
		//IL_223e: Incompatible stack heights: 1 vs 0
		//IL_29eb: Incompatible stack heights: 0 vs 1
		//IL_29eb: Incompatible stack heights: 1 vs 0
		int num = 16;
		byte[] array = default(byte[]);
		int num7 = default(int);
		int num8 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		byte[] array3 = default(byte[]);
		byte[] object_4 = default(byte[]);
		byte[] object_5 = default(byte[]);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		string text = default(string);
		string object_6 = default(string);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		int num10 = default(int);
		int num12 = default(int);
		long num16 = default(long);
		int num15 = default(int);
		uint uint_ = default(uint);
		uint num27 = default(uint);
		long num20 = default(long);
		long num26 = default(long);
		uint num23 = default(uint);
		long num21 = default(long);
		uint num19 = default(uint);
		int num22 = default(int);
		uint num24 = default(uint);
		uint uint_2 = default(uint);
		uint num18 = default(uint);
		long long_ = default(long);
		int int_ = default(int);
		uint num17 = default(uint);
		byte[] array5 = default(byte[]);
		bool flag = default(bool);
		while (DRUB3vo8hI == null)
		{
			int num2 = 15;
			if (VBqTHZmO8vsxXveyxu() == null)
			{
				goto IL_0025;
			}
			goto IL_2326;
			IL_0085:
			num2 = num;
			goto IL_0025;
			IL_0025:
			while (true)
			{
				switch (num2)
				{
				case 16:
					break;
				case 15:
					goto IL_0073;
				case 13:
					try
					{
						tMqGE2Mfc56saCrQNw object_ = new tMqGE2Mfc56saCrQNw((Stream)W0bqMu1FUHnvMRHLpu(bRtBayPDJN, "Nt9DvXuiYyeya66VIq.PAAGUnGv2M4xb2uWPF"));
						int num3 = 224;
						if (Nv9gtXal4dC9sI1ZP0())
						{
							goto IL_1379;
						}
						goto IL_1cb5;
						IL_1cb5:
						while (true)
						{
							switch (num3)
							{
							case 342:
								array[9] = (byte)num7;
								num8 = 47;
								goto case 47;
							case 47:
								num5 = 166;
								goto case 210;
							case 210:
								array[9] = (byte)num5;
								num8 = 96;
								goto case 96;
							case 96:
								num5 = 245;
								goto case 114;
							case 114:
								array[9] = (byte)num5;
								num3 = 9;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 2;
							case 2:
								num4 = 122;
								goto case 219;
							case 219:
								array2[7] = (byte)num4;
								num3 = 156;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 341:
								array[17] = 65;
								num3 = 120;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 60;
							case 60:
								array2[14] = (byte)num6;
								goto case 61;
							case 61:
								array2[15] = 84;
								num3 = 260;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 340:
								num5 = 51;
								goto case 290;
							case 290:
								array[1] = (byte)num5;
								num3 = 80;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 105;
							case 105:
								array[1] = 75;
								goto case 299;
							case 299:
								array[1] = 228;
								num8 = 275;
								goto case 275;
							case 275:
								num5 = 172;
								num3 = 84;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 172;
							case 172:
								array[1] = (byte)num5;
								goto case 178;
							case 178:
								array[2] = 79;
								goto case 237;
							case 237:
								array[2] = 137;
								goto case 92;
							case 92:
								array[2] = 156;
								num3 = 258;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 339:
								num6 = 130;
								num8 = 198;
								goto case 198;
							case 198:
								array2[3] = (byte)num6;
								goto case 112;
							case 112:
								array2[3] = 154;
								num3 = 191;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 338:
								array2[10] = 103;
								num3 = 214;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 113;
							case 113:
								array2[11] = (byte)num6;
								num3 = 91;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 337:
								SdtTuXC81r4qnIEr1x(stream);
								num8 = 270;
								goto case 270;
							case 270:
								SdtTuXC81r4qnIEr1x(object_2);
								goto case 55;
							case 55:
								RJHfFjLR0F7TAQEFYb(object_);
								num3 = 211;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 104;
							case 104:
								array[28] = (byte)num5;
								goto case 222;
							case 222:
								array[29] = 191;
								goto case 6;
							case 6:
								array[29] = 108;
								goto case 267;
							case 267:
								array[29] = 42;
								goto case 121;
							case 121:
								array[30] = 82;
								goto case 224;
							case 224:
								array[30] = 220;
								num3 = 35;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 25;
							case 25:
								array2[8] = 157;
								num3 = 66;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 109;
							case 109:
								num6 = 162;
								num3 = 129;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 336:
								array2[9] = 157;
								goto case 81;
							case 81:
								array2[9] = 248;
								goto case 40;
							case 40:
								array2[10] = 180;
								goto case 142;
							case 142:
								num6 = 189;
								num3 = 310;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 335:
								array[16] = 116;
								goto case 319;
							case 319:
								num5 = 86;
								goto case 238;
							case 238:
								array[16] = (byte)num5;
								num3 = 225;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 150;
							case 150:
								array[10] = (byte)num7;
								num3 = 69;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 15;
							case 15:
								num7 = 89;
								goto case 243;
							case 243:
								array[11] = (byte)num7;
								goto case 97;
							case 97:
								array[12] = 131;
								goto case 189;
							case 189:
								num5 = 67;
								num3 = 264;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 334:
								num7 = 22;
								goto case 342;
							case 333:
								array[7] = 133;
								goto case 184;
							case 184:
								array[7] = 167;
								goto case 161;
							case 161:
								array[8] = 12;
								goto case 51;
							case 51:
								num7 = 31;
								goto case 169;
							case 169:
								array[8] = (byte)num7;
								num3 = 98;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 332:
								array[0] = 168;
								goto case 7;
							case 7:
								array[0] = 132;
								num3 = 255;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 331:
								array2[6] = (byte)num6;
								goto case 254;
							case 254:
								num4 = 97;
								num8 = 242;
								goto case 242;
							case 242:
								array2[6] = (byte)num4;
								num3 = 272;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 330:
								array[9] = 162;
								goto case 334;
							case 329:
								array[11] = 73;
								goto case 31;
							case 31:
								num5 = 90;
								goto case 216;
							case 216:
								array[11] = (byte)num5;
								goto case 325;
							case 325:
								array[11] = 85;
								num3 = 15;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 328:
								array[14] = (byte)num5;
								goto case 44;
							case 44:
								array[14] = 158;
								goto case 30;
							case 30:
								array[14] = 156;
								num8 = 170;
								goto case 170;
							case 170:
								num7 = 168;
								goto case 246;
							case 246:
								array[14] = (byte)num7;
								num8 = 176;
								goto case 176;
							case 176:
								num7 = 124;
								goto case 268;
							case 268:
								array[14] = (byte)num7;
								goto case 271;
							case 271:
								array[14] = 137;
								num3 = 262;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 116;
							case 116:
								array[15] = (byte)num5;
								num3 = 9;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 85;
							case 85:
								array[15] = 84;
								goto case 136;
							case 136:
								num7 = 180;
								num8 = 228;
								goto case 228;
							case 228:
								array[15] = (byte)num7;
								goto case 195;
							case 195:
								num5 = 120;
								goto case 134;
							case 134:
								array[15] = (byte)num5;
								goto case 288;
							case 288:
								num5 = 22;
								goto case 315;
							case 315:
								array[15] = (byte)num5;
								goto case 41;
							case 41:
								array[15] = 14;
								goto case 53;
							case 53:
								num5 = 196;
								num3 = 289;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 327:
								num5 = 71;
								num3 = 19;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 326:
								array2[11] = 204;
								goto case 147;
							case 147:
								num6 = 92;
								num3 = 113;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 324:
								array2[1] = 151;
								goto case 192;
							case 192:
								array2[1] = 66;
								goto case 75;
							case 75:
								array2[1] = 88;
								goto case 306;
							case 306:
								num4 = 98;
								goto case 139;
							case 139:
								array2[1] = (byte)num4;
								num3 = 303;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 323:
								array[23] = (byte)num5;
								num3 = 199;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 322:
								array2[3] = (byte)num4;
								num8 = 66;
								goto case 66;
							case 66:
								num6 = 98;
								goto case 256;
							case 256:
								array2[4] = (byte)num6;
								num8 = 305;
								goto case 305;
							case 305:
								array2[4] = 100;
								goto case 220;
							case 220:
								array2[4] = 225;
								num8 = 249;
								goto case 249;
							case 249:
								array2[5] = 167;
								num3 = 308;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 321:
								array[18] = (byte)num5;
								goto case 38;
							case 38:
								num7 = 152;
								goto case 107;
							case 107:
								array[18] = (byte)num7;
								goto case 67;
							case 67:
								num5 = 30;
								num3 = 93;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 320:
								array[20] = (byte)num5;
								num3 = 215;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 318:
								array2[14] = 94;
								goto case 278;
							case 278:
								array2[14] = 122;
								num3 = 135;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 38;
							case 317:
								array2[0] = 144;
								goto case 283;
							case 283:
								array2[0] = 92;
								goto case 12;
							case 12:
								array2[0] = 189;
								num3 = 324;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 316:
								num6 = 122;
								goto case 273;
							case 273:
								array2[10] = (byte)num6;
								num3 = 338;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 314:
								num5 = 123;
								goto case 167;
							case 167:
								array[16] = (byte)num5;
								num3 = 175;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 313:
								array[21] = (byte)num7;
								num3 = 227;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 191;
							case 191:
								num4 = 124;
								goto case 322;
							case 312:
								num5 = 17;
								num8 = 213;
								goto case 213;
							case 213:
								array[30] = (byte)num5;
								num3 = 250;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 311:
								array[26] = 132;
								num3 = 10;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 310:
								array2[10] = (byte)num6;
								goto case 5;
							case 5:
								num4 = 98;
								num3 = 134;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 152;
							case 152:
								array2[10] = (byte)num4;
								num3 = 40;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 316;
							case 309:
								num7 = 101;
								goto case 209;
							case 209:
								array[27] = (byte)num7;
								num3 = 5;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 173;
							case 173:
								array[27] = 13;
								num3 = 19;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 77;
							case 77:
								array[28] = 159;
								goto case 71;
							case 71:
								array[28] = 52;
								num3 = 125;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 308:
								array2[5] = 88;
								goto case 110;
							case 110:
								array2[5] = 82;
								num3 = 37;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 307:
								array[25] = (byte)num5;
								num3 = 42;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 40;
							case 304:
								num6 = 219;
								goto case 266;
							case 266:
								array2[6] = (byte)num6;
								num8 = 263;
								goto case 263;
							case 263:
								num6 = 115;
								num3 = 130;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 303:
								array2[1] = 71;
								goto case 163;
							case 163:
								array2[2] = 117;
								num8 = 32;
								goto case 32;
							case 32:
								num6 = 147;
								goto case 286;
							case 286:
								array2[2] = (byte)num6;
								num8 = 231;
								goto case 231;
							case 231:
								array2[2] = 167;
								goto case 300;
							case 300:
								array2[2] = 73;
								goto case 190;
							case 190:
								array2[2] = 152;
								goto case 103;
							case 103:
								array2[2] = 80;
								num3 = 8;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 302:
								array2[7] = 134;
								goto case 200;
							case 200:
								array2[8] = 98;
								goto case 25;
							case 301:
								array[7] = (byte)num5;
								num3 = 333;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 298:
								num5 = 165;
								num8 = 251;
								goto case 251;
							case 251:
								array[6] = (byte)num5;
								num3 = 186;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 297:
								array2[12] = (byte)num4;
								goto case 155;
							case 155:
								array2[13] = 98;
								num3 = 244;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 296:
								DsXs5VOpWnoRHhDRSe(object_2);
								goto case 102;
							case 102:
								aVNskOfVBfdV50yfQK(DRUB3vo8hI, LyuHIT0qTf3hyooQv5(lAPbqPJtXJCGLSfBGT(), k3SX7rrmeReUqNpGGa(stream)));
								num3 = 337;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 295:
								array2[3] = 59;
								num3 = 339;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 23;
							case 23:
								array[19] = (byte)num7;
								goto case 4;
							case 4:
								array[19] = 173;
								goto case 123;
							case 123:
								num5 = 67;
								goto case 49;
							case 49:
								array[19] = (byte)num5;
								goto case 188;
							case 188:
								array[19] = 6;
								num8 = 122;
								goto case 122;
							case 122:
								num5 = 140;
								goto case 14;
							case 14:
								array[20] = (byte)num5;
								num3 = 16;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 36;
							case 36:
								num5 = 177;
								goto case 320;
							case 294:
								array[9] = 147;
								goto case 330;
							case 293:
								array[22] = (byte)num7;
								num3 = 269;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 292:
								num5 = 90;
								goto case 174;
							case 174:
								array[31] = (byte)num5;
								num3 = 99;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 61;
							case 291:
								array[10] = (byte)num7;
								goto case 162;
							case 162:
								num7 = 169;
								num3 = 150;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 289:
								array[16] = (byte)num5;
								goto case 234;
							case 234:
								num5 = 120;
								goto case 165;
							case 165:
								array[16] = (byte)num5;
								num3 = 314;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 287:
								array[3] = 192;
								goto case 68;
							case 68:
								array[3] = 150;
								num3 = 77;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 194;
							case 194:
								array[3] = 139;
								num3 = 145;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 285:
								array[30] = (byte)num5;
								num3 = 34;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 46;
							case 46:
								num7 = 170;
								goto case 89;
							case 89:
								array[30] = (byte)num7;
								goto case 312;
							case 284:
								array[28] = 188;
								num3 = 206;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 282:
								num6 = 135;
								num3 = 212;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 281:
								array[4] = (byte)num7;
								goto case 88;
							case 88:
								array[5] = 153;
								goto case 56;
							case 56:
								num5 = 100;
								goto case 72;
							case 72:
								array[5] = (byte)num5;
								goto case 239;
							case 239:
								num7 = 42;
								num3 = 161;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 183;
							case 183:
								array[5] = (byte)num7;
								num8 = 201;
								goto case 201;
							case 201:
								array[6] = 104;
								goto case 274;
							case 274:
								num7 = 149;
								num3 = 207;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 280:
								gm42SvM0wlyVRCSlvC(object_2, array3, 0, array3.Length);
								goto case 296;
							case 279:
								array2[7] = 84;
								num8 = 302;
								goto case 302;
							case 277:
								array2[15] = 201;
								num3 = 181;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 276:
								num4 = 102;
								goto case 247;
							case 247:
								array2[3] = (byte)num4;
								num3 = 295;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 272:
								num6 = 209;
								goto case 115;
							case 115:
								array2[6] = (byte)num6;
								num3 = 192;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 304;
							case 269:
								array[22] = 72;
								num3 = 217;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 265:
								array[27] = 127;
								goto case 309;
							case 264:
								array[12] = (byte)num5;
								goto case 106;
							case 106:
								array[12] = 247;
								num3 = 154;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 147;
							case 262:
								num5 = 98;
								num3 = 116;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 261:
								num5 = 166;
								goto case 63;
							case 63:
								array[13] = (byte)num5;
								goto case 144;
							case 144:
								array[13] = 195;
								num3 = 51;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 79;
							case 79:
								num7 = 155;
								goto case 90;
							case 90:
								array[13] = (byte)num7;
								goto case 119;
							case 119:
								array[13] = 127;
								num8 = 20;
								goto case 20;
							case 20:
								num5 = 105;
								goto case 328;
							case 260:
								array2[15] = 166;
								num3 = 277;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 259:
								array[27] = 149;
								num3 = 97;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 265;
							case 258:
								array[2] = 95;
								goto case 82;
							case 82:
								array[2] = 101;
								num3 = 240;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 257:
								array2 = new byte[16];
								goto case 317;
							case 255:
								array[0] = 204;
								goto case 218;
							case 218:
								num7 = 88;
								num8 = 34;
								goto case 34;
							case 34:
								array[1] = (byte)num7;
								num3 = 340;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 325;
							case 253:
								stream = (Stream)pQyqvbpq7RIFQAYenL();
								num3 = 26;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 7;
							case 252:
								array[31] = (byte)num5;
								goto case 86;
							case 86:
								object_4 = array;
								goto case 257;
							case 250:
								num5 = 178;
								num3 = 24;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 248:
								num6 = 142;
								goto case 64;
							case 64:
								array2[12] = (byte)num6;
								num3 = 187;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 165;
							case 245:
								num5 = 91;
								num3 = 78;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 196;
							case 196:
								array[24] = (byte)num5;
								goto case 182;
							case 182:
								num7 = 164;
								goto case 84;
							case 84:
								array[24] = (byte)num7;
								num3 = 16;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 2;
							case 244:
								array2[13] = 105;
								num8 = 193;
								goto case 193;
							case 193:
								array2[13] = 158;
								num3 = 137;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 241:
								array[13] = (byte)num5;
								goto case 261;
							case 240:
								num7 = 40;
								goto case 100;
							case 100:
								array[3] = (byte)num7;
								num3 = 287;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 236:
								array2[9] = (byte)num4;
								goto case 282;
							case 235:
								array[21] = (byte)num5;
								goto case 83;
							case 83:
								num7 = 213;
								num3 = 313;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 233:
								array2[5] = 100;
								goto case 128;
							case 128:
								array2[5] = 91;
								num3 = 0;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto default;
							default:
								num6 = 100;
								goto case 331;
							case 232:
								num6 = 79;
								goto case 80;
							case 80:
								array2[13] = (byte)num6;
								goto case 318;
							case 230:
								num5 = 89;
								goto case 138;
							case 138:
								array[6] = (byte)num5;
								goto case 298;
							case 229:
								array[23] = 128;
								num3 = 27;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 227:
								num5 = 214;
								num3 = 221;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 226:
								break;
							case 164:
								goto IL_138e;
							case 225:
								num7 = 150;
								goto case 160;
							case 160:
								array[17] = (byte)num7;
								num3 = 263;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 341;
							case 223:
								array[26] = (byte)num7;
								num3 = 0;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 1;
							case 1:
								num7 = 103;
								goto case 140;
							case 140:
								array[26] = (byte)num7;
								num3 = 276;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 311;
							case 221:
								array[22] = (byte)num5;
								goto case 202;
							case 202:
								array[22] = 116;
								goto case 22;
							case 22:
								num7 = 131;
								goto case 293;
							case 217:
								array[22] = 80;
								num3 = 109;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 229;
							case 215:
								array[20] = 150;
								num3 = 20;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 58;
							case 58:
								array[21] = 155;
								goto case 11;
							case 11:
								num5 = 116;
								goto case 235;
							case 214:
								array2[10] = 90;
								num3 = 65;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 212:
								array2[9] = (byte)num6;
								goto case 50;
							case 50:
								array2[9] = 140;
								num3 = 74;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 208:
								array2[6] = (byte)num4;
								goto case 76;
							case 76:
								num6 = 106;
								goto case 132;
							case 132:
								array2[7] = (byte)num6;
								num3 = 1;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 2;
							case 207:
								array[6] = (byte)num7;
								goto case 171;
							case 171:
								array[6] = 113;
								num8 = 230;
								goto case 230;
							case 206:
								num5 = 177;
								goto case 104;
							case 205:
								array[0] = 56;
								goto case 332;
							case 204:
								array[4] = 96;
								goto case 148;
							case 148:
								num7 = 38;
								goto case 281;
							case 203:
								array[31] = 142;
								goto case 292;
							case 199:
								array[23] = 102;
								goto case 245;
							case 197:
								array[23] = 158;
								goto case 168;
							case 168:
								array[23] = 208;
								goto case 141;
							case 141:
								num5 = 160;
								num3 = 323;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 187:
								num4 = 60;
								goto case 297;
							case 186:
								array[6] = 95;
								num3 = 21;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 185:
								array2[12] = 146;
								goto case 33;
							case 33:
								num4 = 166;
								goto case 180;
							case 180:
								array2[12] = (byte)num4;
								num3 = 15;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 248;
							case 181:
								array2[15] = 143;
								num8 = 117;
								goto case 117;
							case 117:
								object_5 = array2;
								goto case 158;
							case 158:
								object_3 = (SymmetricAlgorithm)xWB4RCdXl3ZboDDagw();
								num3 = 131;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 179:
								num4 = 187;
								goto case 94;
							case 94:
								array2[12] = (byte)num4;
								num3 = 185;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 117;
							case 177:
								array[0] = 144;
								goto case 205;
							case 175:
								array[16] = 52;
								goto case 335;
							case 166:
								array[26] = (byte)num5;
								num3 = 95;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 159:
								array[4] = 89;
								goto case 204;
							case 157:
								num7 = 94;
								num3 = 223;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 156:
								array2[7] = 89;
								num3 = 279;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 154:
								array[12] = 102;
								goto case 108;
							case 108:
								num5 = 124;
								num3 = 48;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 153:
								num7 = 139;
								num8 = 23;
								goto case 23;
							case 151:
								num5 = 70;
								num8 = 57;
								goto case 57;
							case 57:
								array[17] = (byte)num5;
								goto case 73;
							case 73:
								array[17] = 38;
								goto case 78;
							case 78:
								num5 = 128;
								goto case 321;
							case 149:
								array[11] = 156;
								num3 = 9;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 127;
							case 127:
								array[11] = 146;
								goto case 329;
							case 146:
								transform = (ICryptoTransform)XRct7ZbwCYbjx7hb74(object_3, object_4, object_5);
								goto case 253;
							case 145:
								array[4] = 160;
								num8 = 159;
								goto case 159;
							case 143:
								num5 = 138;
								num3 = 285;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 137:
								num6 = 168;
								num3 = 45;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 135:
								num6 = 44;
								goto case 60;
							case 133:
								array[10] = (byte)num7;
								goto case 149;
							case 131:
								YTRHWBi4wwxcgaiyv7(object_3, CipherMode.CBC);
								num3 = 146;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 130:
								array2[6] = (byte)num6;
								num3 = 70;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 129:
								array2[8] = (byte)num6;
								num3 = 118;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 126:
								array[24] = 44;
								goto case 39;
							case 39:
								array[25] = 127;
								num3 = 111;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 111;
							case 111:
								array[25] = 98;
								goto case 327;
							case 125:
								num7 = 120;
								goto case 59;
							case 59:
								array[28] = (byte)num7;
								num3 = 62;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 124:
								num7 = 109;
								goto case 291;
							case 120:
								array[17] = 170;
								goto case 151;
							case 118:
								num4 = 91;
								num3 = 236;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 101:
								array[24] = 151;
								goto case 126;
							case 99:
								num5 = 142;
								goto case 252;
							case 98:
								array[8] = 78;
								goto case 294;
							case 95:
								array[26] = 5;
								goto case 259;
							case 93:
								array[18] = (byte)num5;
								num8 = 153;
								goto case 153;
							case 91:
								array2[11] = 169;
								num3 = 43;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 87:
								array2[11] = (byte)num4;
								num8 = 54;
								goto case 54;
							case 54:
								array2[12] = 123;
								goto case 179;
							case 74:
								array2[9] = 94;
								goto case 336;
							case 70:
								num4 = 217;
								goto case 208;
							case 69:
								num7 = 250;
								num3 = 133;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 37;
							case 37:
								array2[5] = 88;
								num8 = 233;
								goto case 233;
							case 65:
								array2[11] = 124;
								num3 = 17;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 1;
							case 62:
								array[28] = 70;
								num3 = 284;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 52:
								num5 = 159;
								num3 = 241;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 48:
								array[12] = (byte)num5;
								goto case 13;
							case 13:
								array[12] = 30;
								goto case 52;
							case 45:
								array2[13] = (byte)num6;
								goto case 232;
							case 43:
								num4 = 220;
								num3 = 87;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 42:
								array[25] = 73;
								num3 = 157;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 35:
								array[30] = 157;
								num3 = 143;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 93;
							case 29:
								num5 = 141;
								num3 = 23;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 307;
							case 28:
								array = new byte[32];
								goto case 177;
							case 27:
								array[23] = 102;
								goto case 197;
							case 26:
								object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
								num3 = 280;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto IL_015a;
							case 24:
								array[31] = (byte)num5;
								num3 = 127;
								if (VBqTHZmO8vsxXveyxu() != null)
								{
									continue;
								}
								goto case 203;
							case 21:
								num5 = 110;
								goto case 301;
							case 19:
								array[25] = (byte)num5;
								goto case 29;
							case 18:
								array2[3] = (byte)num4;
								goto case 276;
							case 17:
								array2[11] = 94;
								num3 = 326;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 51;
							case 16:
								array[24] = 67;
								goto case 3;
							case 3:
								array[24] = 80;
								num3 = 101;
								if (VBqTHZmO8vsxXveyxu() == null)
								{
									continue;
								}
								goto case 75;
							case 10:
								num5 = 118;
								num3 = 129;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto case 166;
							case 9:
								array[10] = 94;
								goto case 124;
							case 8:
								num4 = 114;
								num3 = 18;
								if (Nv9gtXal4dC9sI1ZP0())
								{
									continue;
								}
								goto IL_015a;
							case 211:
								goto end_IL_00ad;
							}
							break;
						}
						goto IL_1379;
						IL_1379:
						R30uxAeRn1vuMmqqZF(zu9FoLEiJI7D05uJpc(object_), 0L);
						goto IL_138e;
						IL_015a:
						num3 = num8;
						goto IL_1cb5;
						IL_138e:
						array3 = (byte[])LRf9dEcFqnZPs0c2GE(object_, (int)ntySvijOi8FqbUZ9Nx(zu9FoLEiJI7D05uJpc(object_)));
						num3 = 28;
						if (VBqTHZmO8vsxXveyxu() != null)
						{
							goto IL_015a;
						}
						goto IL_1cb5;
						end_IL_00ad:;
					}
					catch
					{
						if (VBqTHZmO8vsxXveyxu() != null)
						{
							goto IL_2231;
						}
						goto IL_2240;
						IL_2240:
						switch (0)
						{
						case 1:
							goto end_IL_2220;
						}
						goto IL_2231;
						IL_2231:
						do
						{
							flag = true;
							_ = 1;
						}
						while (VBqTHZmO8vsxXveyxu() != null);
						goto IL_2240;
						end_IL_2220:;
					}
					goto case 14;
				case 12:
					if (text != null)
					{
						num2 = 1;
						if (VBqTHZmO8vsxXveyxu() == null)
						{
							continue;
						}
						goto case 1;
					}
					return;
				case 1:
					if (TmUvNF7P5SwiU3GXgS(text) != 0)
					{
						hashAlgorithm = null;
						goto case 9;
					}
					return;
				case 9:
					object_6 = null;
					num = 6;
					goto case 6;
				case 6:
					try
					{
						hashAlgorithm = (HashAlgorithm)rUkd6WQkQuUpVFiiZC();
						int num9 = 2;
						if (VBqTHZmO8vsxXveyxu() != null)
						{
							goto IL_22b6;
						}
						goto IL_22d0;
						IL_22d0:
						while (true)
						{
							switch (num9)
							{
							case 2:
								goto IL_229d;
							case 1:
								return;
							case 3:
								goto end_IL_22d0;
							}
							goto IL_22b6;
							IL_229d:
							object_6 = (string)dMKceju9xh4tn4ky9a("SHA1");
							num9 = 0;
							if (VBqTHZmO8vsxXveyxu() != null)
							{
								continue;
							}
							goto IL_22b6;
							continue;
							end_IL_22d0:
							break;
						}
						goto end_IL_2287;
						IL_22b6:
						if (!Ybh8GZP3SMDtHCB0T1(text))
						{
							num9 = 1;
							if (VBqTHZmO8vsxXveyxu() != null)
							{
								num9 = num10;
							}
							goto IL_22d0;
						}
						end_IL_2287:;
					}
					catch
					{
						int num11 = 0;
						if (!Nv9gtXal4dC9sI1ZP0())
						{
							num11 = num12;
						}
						switch (num11)
						{
						}
						return;
					}
					goto case 2;
				case 2:
					flag = false;
					num2 = 13;
					if (VBqTHZmO8vsxXveyxu() == null)
					{
						continue;
					}
					goto IL_0085;
				case 10:
					goto IL_2326;
				case 5:
					DRUB3vo8hI = new RSACryptoServiceProvider();
					num = 3;
					goto case 3;
				case 3:
					text = (string)qhExAiVJ7lP0th81AU(jYV7bjKPYdvlFQbx82(typeof(J5LlPjhj0b2Nc1D9HG).TypeHandle).Assembly);
					num2 = 12;
					if (Nv9gtXal4dC9sI1ZP0())
					{
						continue;
					}
					goto IL_0085;
				case 4:
					dH2Cfhot4Hyrfytv4B(bool_0: true);
					goto case 5;
				case 14:
					if (!flag)
					{
						goto IL_008b;
					}
					goto IL_2a4b;
				case 7:
					goto IL_2a4b;
				default:
					throw new Exception((string?)vvcH8syOUygJD9K0Fh(N50jX8UXxXeIfTqwZx(icbMJP92gTypE76ZwS(jYV7bjKPYdvlFQbx82(typeof(J5LlPjhj0b2Nc1D9HG).TypeHandle).Assembly)), " is tampered."));
				case 8:
					return;
				case 11:
					return;
				}
				break;
				IL_008b:
				num2 = 10;
				if (Nv9gtXal4dC9sI1ZP0())
				{
					continue;
				}
				goto IL_0085;
				IL_0073:
				Tvx1HZRe3XSlkUiyxZ();
				num2 = 4;
				if (VBqTHZmO8vsxXveyxu() == null)
				{
					continue;
				}
				goto IL_0085;
			}
			continue;
			IL_2326:
			try
			{
				FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
				while (true)
				{
					BinaryReader object_7 = new BinaryReader(fileStream);
					int num13 = 50;
					while (true)
					{
						byte[] array4 = new byte[65536];
						while (true)
						{
							NTWLJP44vfSvUE5xZq(hashAlgorithm, fileStream, 152u, array4);
							while (true)
							{
								bool flag2 = UK2IVLgLYwl0TOHU5M(object_7) != 523;
								int num14 = 74;
								if (!Nv9gtXal4dC9sI1ZP0())
								{
									goto IL_2497;
								}
								goto IL_2816;
								IL_2816:
								while (true)
								{
									int num25;
									switch (num14)
									{
									case 76:
										array4[67] = 0;
										num14 = 27;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto default;
									default:
										num16 = T7IxvbHXCmYwR6rWig(fileStream);
										goto case 55;
									case 55:
										R30uxAeRn1vuMmqqZF(fileStream, 134L);
										num13 = 56;
										goto case 56;
									case 56:
										num15 = UK2IVLgLYwl0TOHU5M(object_7);
										goto case 13;
									case 13:
										R30uxAeRn1vuMmqqZF(fileStream, num16);
										num14 = 30;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto case 6;
									case 6:
									case 35:
										uint_ = uVjoev8cxrHvvywEvc(object_7);
										num14 = 10;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto case 4;
									case 4:
									case 65:
										num27 = (uint)mPYEZfI6SBKNB5IkxA(num20 - num26, num23);
										goto case 3;
									case 3:
										NTWLJP44vfSvUE5xZq(hashAlgorithm, fileStream, num27, array4);
										goto case 24;
									case 24:
										num23 -= num27;
										num13 = 9;
										goto case 9;
									case 9:
									case 28:
									case 43:
										if (num23 != 0)
										{
											goto case 1;
										}
										goto case 22;
									case 1:
									case 14:
										num26 = T7IxvbHXCmYwR6rWig(fileStream);
										goto case 70;
									case 70:
										if (num20 <= num26)
										{
											goto case 48;
										}
										goto case 15;
									case 48:
										if (num26 < num21)
										{
											goto case 52;
										}
										goto case 15;
									case 52:
										num19 = (uint)(num21 - num26);
										goto case 34;
									case 34:
										if (num19 < num23)
										{
											goto case 72;
										}
										goto case 22;
									case 72:
										num23 -= num19;
										num14 = 18;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto IL_2497;
									case 15:
									case 40:
										if (num26 >= num21)
										{
											goto case 11;
										}
										num14 = 65;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto case 22;
									case 11:
										NTWLJP44vfSvUE5xZq(hashAlgorithm, fileStream, num23, array4);
										num14 = 22;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 22:
									case 60:
										num22++;
										num13 = 36;
										goto case 2;
									case 2:
									case 36:
										if (num22 >= num15)
										{
											goto case 73;
										}
										num14 = 49;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 73:
										O5uvO1kmhbP93inoXE(hashAlgorithm, new byte[0], 0, 0);
										num14 = 44;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 75:
										num22 = 0;
										goto case 2;
									case 74:
										if (flag2)
										{
											num14 = 44;
											if (VBqTHZmO8vsxXveyxu() != null)
											{
												continue;
											}
											goto case 54;
										}
										goto case 29;
									case 54:
										num25 = 96;
										goto IL_24bf;
									case 29:
										num25 = 112;
										goto IL_24bf;
									case 23:
										R30uxAeRn1vuMmqqZF(fileStream, 152L);
										num14 = 46;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto IL_2497;
									case 71:
										num24 = uVjoev8cxrHvvywEvc(object_7);
										num13 = 37;
										goto case 37;
									case 37:
										R30uxAeRn1vuMmqqZF(fileStream, num24);
										num14 = 43;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 69:
										array4[38] = 0;
										goto case 39;
									case 39:
										array4[39] = 0;
										num14 = 39;
										if (!Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto case 67;
									case 67:
										HjHfhotinKpbDNwb7M(hashAlgorithm, array4, 0, 128);
										num14 = 0;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto default;
									case 68:
										num23 = uVjoev8cxrHvvywEvc(object_7);
										num14 = 71;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto case 61;
									case 66:
										array4[36] = 0;
										num14 = 25;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto IL_2497;
									case 26:
									case 64:
										R30uxAeRn1vuMmqqZF(fileStream, 376L);
										goto case 6;
									case 63:
										array4[34] = 0;
										num14 = 41;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 49:
									case 62:
										R30uxAeRn1vuMmqqZF(fileStream, num16 + num22 * 40 + 16L);
										goto case 68;
									case 59:
										num20 = CG3NAA3u44aN3lXRE6(uint_2, num15, num16, object_7);
										goto case 12;
									case 12:
										num21 = num20 + num18;
										goto case 8;
									case 8:
										R30uxAeRn1vuMmqqZF(fileStream, long_);
										goto case 75;
									case 58:
										long_ = T7IxvbHXCmYwR6rWig(fileStream);
										num13 = 45;
										goto case 45;
									case 45:
										if (!flag2)
										{
											goto case 26;
										}
										goto case 51;
									case 51:
										R30uxAeRn1vuMmqqZF(fileStream, 360L);
										num14 = 6;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto IL_2497;
									case 57:
										uint_2 = uVjoev8cxrHvvywEvc(object_7);
										goto case 53;
									case 53:
										num18 = uVjoev8cxrHvvywEvc(object_7);
										num14 = 59;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto IL_2497;
									case 47:
										array4[66] = 0;
										goto case 76;
									case 46:
										alEhIFnrOhSUPDfJ6i(fileStream, array4, 0, int_);
										num14 = 2;
										if (VBqTHZmO8vsxXveyxu() != null)
										{
											continue;
										}
										goto case 5;
									case 5:
										do
										{
											array4[64] = 0;
											num14 = 38;
										}
										while (VBqTHZmO8vsxXveyxu() != null);
										continue;
									case 44:
										R30uxAeRn1vuMmqqZF(fileStream, num20);
										num14 = 16;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 42:
										R30uxAeRn1vuMmqqZF(fileStream, num17 + 32);
										num13 = 57;
										goto case 57;
									case 41:
										array4[35] = 0;
										goto case 66;
									case 38:
										array4[65] = 0;
										num14 = 4;
										if (!Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto case 47;
									case 33:
										alEhIFnrOhSUPDfJ6i(fileStream, array4, 0, 128);
										num14 = 7;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto case 3;
									case 31:
										array4[33] = 0;
										num13 = 63;
										goto case 63;
									case 30:
										NTWLJP44vfSvUE5xZq(hashAlgorithm, fileStream, (uint)(num15 * 40), array4);
										goto case 58;
									case 27:
										HjHfhotinKpbDNwb7M(hashAlgorithm, array4, 0, int_);
										num14 = 33;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 25:
										array4[37] = 0;
										num13 = 69;
										goto case 69;
									case 21:
										YV9h8BSL3QZqCc2ISD(array5);
										num14 = 61;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto case 29;
									case 18:
										R30uxAeRn1vuMmqqZF(fileStream, T7IxvbHXCmYwR6rWig(fileStream) + num19);
										goto case 9;
									case 16:
										array5 = (byte[])nmP5Px2YfSEqdSeDLJ(object_7, (int)num18);
										num14 = 21;
										if (Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto IL_2497;
									case 10:
										num17 = CG3NAA3u44aN3lXRE6(uint_, num15, num16, object_7);
										num14 = 35;
										if (!Nv9gtXal4dC9sI1ZP0())
										{
											continue;
										}
										goto case 42;
									case 7:
										array4[32] = 0;
										num14 = 31;
										if (VBqTHZmO8vsxXveyxu() == null)
										{
											continue;
										}
										goto IL_2497;
									case 17:
										break;
									case 32:
										goto end_IL_2954;
									case 50:
										goto end_IL_297c;
									case 19:
										goto end_IL_298e;
									case 61:
										flag = !z4JME3xqlY32mML6ZY(DRUB3vo8hI, zq6DFTv1JK9SkxOr8T(hashAlgorithm), object_6, array5);
										goto end_IL_299c;
									case 20:
										goto end_IL_299c;
										IL_24bf:
										int_ = num25;
										num13 = 23;
										goto case 23;
									}
									break;
								}
								continue;
								IL_2497:
								num14 = num13;
								goto IL_2816;
								continue;
								end_IL_2954:
								break;
							}
							continue;
							end_IL_297c:
							break;
						}
						continue;
						end_IL_298e:
						break;
					}
					continue;
					end_IL_299c:
					break;
				}
			}
			catch
			{
				if (!Nv9gtXal4dC9sI1ZP0())
				{
					goto IL_29de;
				}
				goto IL_29ed;
				IL_29ed:
				switch (0)
				{
				case 1:
					goto end_IL_29cd;
				}
				goto IL_29de;
				IL_29de:
				do
				{
					flag = true;
					_ = 1;
				}
				while (!Nv9gtXal4dC9sI1ZP0());
				goto IL_29ed;
				end_IL_29cd:;
			}
			goto IL_2a4b;
			IL_2a4b:
			if (flag)
			{
				num2 = 0;
				if (Nv9gtXal4dC9sI1ZP0())
				{
					goto IL_0025;
				}
				goto IL_0085;
			}
			flag = false;
			break;
		}
	}

	public static void NyHsvmnjH(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (FS0B77NOQT == null)
			{
				lock (Ug8BrOkf50)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554447)).Assembly.GetManifestResourceStream("kdF997imgo7j4ee6fm.srEqC8pnqAOOC7gveM"));
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
							num3 += EcsNZhEn4(num3);
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
						tMqGE2Mfc56saCrQNw tMqGE2Mfc56saCrQNw = new tMqGE2Mfc56saCrQNw(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = tMqGE2Mfc56saCrQNw.lT0BFtnoJu();
							int value = tMqGE2Mfc56saCrQNw.lT0BFtnoJu();
							dictionary.Add(key, value);
						}
						tMqGE2Mfc56saCrQNw.lCUBOOInPK();
					}
					FS0B77NOQT = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = FS0B77NOQT[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554447)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(16777237));
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

	private static uint kq4nQVRHm(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	private static uint s2LRE4xCq(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint EcsNZhEn4(uint uint_0)
	{
		return 0u;
	}

	internal static void CM8lrw32n()
	{
	}

	[rkqg46k5g1HlaIfYQM(typeof(rkqg46k5g1HlaIfYQM.ud0s1ngLI53OSOslp1<object>[]))]
	internal static string Qdxbg4ifT(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int A0s8Lod3i()
	{
		return 5;
	}

	private static void GFMYSNcut()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate YAjyFTaYt(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(16777316)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(16777274)),
			Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(16777256))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object BtNJ3yil1(object object_0)
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

	private static IntPtr xo8FhVZG9(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (jpiBsJQhha == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			jpiBsJQhha = (a0QOUb9yiNKGvlKPlA)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554456)));
		}
		return jpiBsJQhha(intptr_0, string_0, uint_0);
	}

	private static IntPtr OoqOUZrSi(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (BpQBn8yije == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			BpQBn8yije = (QcrnyH3vmnjHkq4QVR)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554457)));
		}
		return BpQBn8yije(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int LOLmEHw3D(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (qb5BRAXhiJ == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			qb5BRAXhiJ = (gm92LE74xCqvcsZhEn)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554458)));
		}
		return qb5BRAXhiJ(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int OdGz9gZIr(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (qnABNCrT3L == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			qnABNCrT3L = (o5M8rwr32nldxg4ifT)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554459)));
		}
		return qnABNCrT3L(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr w0hBGEOKiB(uint uint_0, int int_0, uint uint_1)
	{
		if (IqHBl56fRy == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			IqHBl56fRy = (A0sLodA3iDFMSNcutm)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554460)));
		}
		return IqHBl56fRy(uint_0, int_0, uint_1);
	}

	private static int FlnBB746vj(IntPtr intptr_0)
	{
		if (XMuBb9JZRd == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			XMuBb9JZRd = (vjFTaY6t5tN3yil1Yp)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(ViBwlnT746vjKBAiJi.bOHLco5kYYJmr(33554461)));
		}
		return XMuBb9JZRd(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (x1fB81Mu4A == IntPtr.Zero)
		{
			x1fB81Mu4A = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return x1fB81Mu4A;
	}

	[rkqg46k5g1HlaIfYQM(typeof(rkqg46k5g1HlaIfYQM.ud0s1ngLI53OSOslp1<object>[]))]
	private static byte[] WBABViJiuH(string string_0)
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

	internal static Stream poQBq7I3GA()
	{
		return new MemoryStream();
	}

	internal static byte[] TXGBL32d6H(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[rkqg46k5g1HlaIfYQM(typeof(rkqg46k5g1HlaIfYQM.ud0s1ngLI53OSOslp1<object>[]))]
	private static byte[] bBDBjBZ6M1(byte[] byte_0)
	{
		Stream stream = poQBq7I3GA();
		SymmetricAlgorithm symmetricAlgorithm = WbDDedUUh();
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
		byte[] result = TXGBL32d6H(stream);
		iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
		return result;
	}

	private byte[] oCdBdtCk0K()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Uy3BHl4C0w()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] cTmBUXVXAY()
	{
		return null;
	}

	private byte[] DUNBCbaqgy()
	{
		return null;
	}

	private byte[] B8WBh2JJO7()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] eKxBtukN0t()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] o9cBiTgbsu()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] kSKBkXIR2x()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] JgIBg2rL3K()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] pH1BxlkPGL()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static void Tvx1HZRe3XSlkUiyxZ()
	{
		iVZG9R1oqUZrSiIOLE.ExbLcoxzRwxZj();
	}

	internal static void dH2Cfhot4Hyrfytv4B(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type jYV7bjKPYdvlFQbx82(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object qhExAiVJ7lP0th81AU(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int TmUvNF7P5SwiU3GXgS(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object rUkd6WQkQuUpVFiiZC()
	{
		return SHA1.Create();
	}

	internal static object dMKceju9xh4tn4ky9a(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool Ybh8GZP3SMDtHCB0T1(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object W0bqMu1FUHnvMRHLpu(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object zu9FoLEiJI7D05uJpc(object object_0)
	{
		return ((tMqGE2Mfc56saCrQNw)object_0).KDikMXewCI();
	}

	internal static void R30uxAeRn1vuMmqqZF(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long ntySvijOi8FqbUZ9Nx(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object LRf9dEcFqnZPs0c2GE(object object_0, int int_0)
	{
		return ((tMqGE2Mfc56saCrQNw)object_0).hnmBomP2sX(int_0);
	}

	internal static object xWB4RCdXl3ZboDDagw()
	{
		return WbDDedUUh();
	}

	internal static void YTRHWBi4wwxcgaiyv7(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object XRct7ZbwCYbjx7hb74(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object pQyqvbpq7RIFQAYenL()
	{
		return poQBq7I3GA();
	}

	internal static void gm42SvM0wlyVRCSlvC(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void DsXs5VOpWnoRHhDRSe(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object lAPbqPJtXJCGLSfBGT()
	{
		return Encoding.UTF8;
	}

	internal static object k3SX7rrmeReUqNpGGa(object object_0)
	{
		return TXGBL32d6H((Stream)object_0);
	}

	internal static object LyuHIT0qTf3hyooQv5(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void aVNskOfVBfdV50yfQK(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void SdtTuXC81r4qnIEr1x(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void RJHfFjLR0F7TAQEFYb(object object_0)
	{
		((tMqGE2Mfc56saCrQNw)object_0).lCUBOOInPK();
	}

	internal static void NTWLJP44vfSvUE5xZq(object object_0, object object_1, uint uint_0, object object_2)
	{
		Lfcf56saC((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort UK2IVLgLYwl0TOHU5M(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int alEhIFnrOhSUPDfJ6i(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void HjHfhotinKpbDNwb7M(object object_0, object object_1, int int_0, int int_1)
	{
		uQNSwG0QO((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long T7IxvbHXCmYwR6rWig(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint uVjoev8cxrHvvywEvc(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint CG3NAA3u44aN3lXRE6(uint uint_0, int int_0, long long_0, object object_0)
	{
		return hby2iNKGv(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long mPYEZfI6SBKNB5IkxA(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object O5uvO1kmhbP93inoXE(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object nmP5Px2YfSEqdSeDLJ(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void YV9h8BSL3QZqCc2ISD(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object zq6DFTv1JK9SkxOr8T(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool z4JME3xqlY32mML6ZY(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object icbMJP92gTypE76ZwS(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object N50jX8UXxXeIfTqwZx(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object vvcH8syOUygJD9K0Fh(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool Nv9gtXal4dC9sI1ZP0()
	{
		return (object)null == null;
	}

	internal static object VBqTHZmO8vsxXveyxu()
	{
		return null;
	}
}
