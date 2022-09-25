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
using rE4lpnT863QnijKQK5;
using zlqCXdcKao7YZQAGFe;

namespace dg3ypDAonQcOidMs0w;

internal class WP6RZJql8gZrNhVA9v
{
	private delegate void vXgxlLQcVHhY7dY50X(object o);

	internal class RJDcsuMfOxrTCYImPe : Attribute
	{
		internal class iGR41459RDH4FvPdNk<T>
		{
			public iGR41459RDH4FvPdNk()
			{
				hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
				base._002Ector();
			}

			static iGR41459RDH4FvPdNk()
			{
				iXLoKRSpAw();
			}
		}

		[RJDcsuMfOxrTCYImPe(typeof(iGR41459RDH4FvPdNk<object>[]))]
		public RJDcsuMfOxrTCYImPe(object object_0)
		{
		}
	}

	internal class qcBC7nbplYPB6DW0yw
	{
		[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
		internal static string G9skPDgcXb(string string_0, string string_1)
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
			byte[] iV = XEDoeIU7mj(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint QZEOeHRUkDiNqCWT0p(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr OFfwWh6ZIHjfnqBOWx();

	internal struct BIpvxRBRb2dOGl802m
	{
		internal bool JDNkifbo3S;

		internal byte[] jsbkrdexts;
	}

	internal class VtNVUKGulysZw81C3E
	{
		private BinaryReader KPVkbuTpLj;

		public VtNVUKGulysZw81C3E(Stream stream_0)
		{
			KPVkbuTpLj = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return KPVkbuTpLj.BaseStream;
		}

		internal byte[] B2XkaLi4dH(int int_0)
		{
			return KPVkbuTpLj.ReadBytes(int_0);
		}

		internal int hx5kqNgSj4(byte[] byte_0, int int_0, int int_1)
		{
			return KPVkbuTpLj.Read(byte_0, int_0, int_1);
		}

		internal int TVtkAMaqpL()
		{
			return KPVkbuTpLj.ReadInt32();
		}

		internal void VDqkQKyKML()
		{
			KPVkbuTpLj.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr MacgPI7JyVeAhNaPvd(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr GL8NaIwq2KOvLQhMFX(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int yy2w1VXOQgx806ubre(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int N7UlhA3IRW2ugh7tWg(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr RI754BJF754hNSApRW(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int YLCGmBEaUwBbEqLM01(IntPtr ptr);

	[Flags]
	private enum AwgKvrHJUS3TxryUsj
	{

	}

	internal static Assembly x4Dk2IHVmX;

	private static Dictionary<int, int> Tqek0lIh21;

	private static byte[] OObkplyC7t;

	private static IntPtr aatkD4ZSGk;

	private static int Qy5kfBXtEh;

	internal static QZEOeHRUkDiNqCWT0p rNZkehfwNu;

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static bool firstrundone;

	private static N7UlhA3IRW2ugh7tWg zIOkYypt1M;

	private static MacgPI7JyVeAhNaPvd BV0kmUIPgx;

	private static YLCGmBEaUwBbEqLM01 etmkyDG2SG;

	private static bool fMAkKtNIoA;

	private static bool LrEkS2eXQL;

	private static uint[] O1BkIDx0L0;

	private static int CgSk1JZr60;

	private static bool xo4kuDarJK;

	private static int[] zl0ksqgIH1;

	private static long URnkCOceLK;

	private static bool PRZkZqsNsa;

	private static long eXJkjmTXDX;

	private static object WaKkhokJrA;

	private static byte[] s6pkoGoeab;

	private static SortedList VM5kd0GoFG;

	private static bool MrkkWebIMK;

	private static RI754BJF754hNSApRW tuYkt9D06I;

	private static object emjkxI4Yxp;

	private static IntPtr K7PkOHxqAd;

	private static IntPtr wcyk8nIyBt;

	private static yy2w1VXOQgx806ubre tTVkFDSO7A;

	internal static Hashtable lmdkVksVkh;

	private static IntPtr VE2k4S5okQ;

	private static int wpoklx4RIX;

	internal static RSACryptoServiceProvider onZkkIlVOi;

	internal static QZEOeHRUkDiNqCWT0p abxkLGOVrU;

	private static GL8NaIwq2KOvLQhMFX yBRkv0eFeZ;

	private static byte[] HkLkNdDPtB;

	private static bool V9fkgxQPQA;

	private static int XtMknffM5M;

	static WP6RZJql8gZrNhVA9v()
	{
		PRZkZqsNsa = false;
		x4Dk2IHVmX = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554449)).Assembly;
		O1BkIDx0L0 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		V9fkgxQPQA = false;
		LrEkS2eXQL = false;
		s6pkoGoeab = new byte[0];
		onZkkIlVOi = null;
		Tqek0lIh21 = null;
		emjkxI4Yxp = new object();
		HkLkNdDPtB = new byte[0];
		OObkplyC7t = new byte[0];
		wcyk8nIyBt = IntPtr.Zero;
		aatkD4ZSGk = IntPtr.Zero;
		WaKkhokJrA = new string[0];
		zl0ksqgIH1 = new int[0];
		Qy5kfBXtEh = 1;
		MrkkWebIMK = false;
		VM5kd0GoFG = new SortedList();
		XtMknffM5M = 0;
		URnkCOceLK = 0L;
		abxkLGOVrU = null;
		rNZkehfwNu = null;
		eXJkjmTXDX = 0L;
		wpoklx4RIX = 0;
		xo4kuDarJK = false;
		fMAkKtNIoA = false;
		CgSk1JZr60 = 0;
		VE2k4S5okQ = IntPtr.Zero;
		firstrundone = false;
		lmdkVksVkh = new Hashtable();
		BV0kmUIPgx = null;
		yBRkv0eFeZ = null;
		tTVkFDSO7A = null;
		zIOkYypt1M = null;
		tuYkt9D06I = null;
		etmkyDG2SG = null;
		K7PkOHxqAd = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void V4WF529oAq2Aq()
	{
	}

	internal static byte[] ab9oDe4UH3(byte[] byte_0)
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
			TAOohhiP7R(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			TAOohhiP7R(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			TAOohhiP7R(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			TAOohhiP7R(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			TAOohhiP7R(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			TAOohhiP7R(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			TAOohhiP7R(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			TAOohhiP7R(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			TAOohhiP7R(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			TAOohhiP7R(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			TAOohhiP7R(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			TAOohhiP7R(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			TAOohhiP7R(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			TAOohhiP7R(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			TAOohhiP7R(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			TAOohhiP7R(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			zDKosecjaB(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			zDKosecjaB(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			zDKosecjaB(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			zDKosecjaB(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			zDKosecjaB(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			zDKosecjaB(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			zDKosecjaB(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			zDKosecjaB(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			zDKosecjaB(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			zDKosecjaB(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			zDKosecjaB(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			zDKosecjaB(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			zDKosecjaB(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			zDKosecjaB(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			zDKosecjaB(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			zDKosecjaB(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			ubAof6RgCm(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			ubAof6RgCm(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			ubAof6RgCm(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			ubAof6RgCm(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			ubAof6RgCm(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			ubAof6RgCm(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			ubAof6RgCm(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			ubAof6RgCm(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			ubAof6RgCm(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			ubAof6RgCm(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			ubAof6RgCm(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			ubAof6RgCm(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			ubAof6RgCm(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			ubAof6RgCm(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			ubAof6RgCm(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			ubAof6RgCm(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			YpJoWsPi7X(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			YpJoWsPi7X(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			YpJoWsPi7X(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			YpJoWsPi7X(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			YpJoWsPi7X(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			YpJoWsPi7X(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			YpJoWsPi7X(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			YpJoWsPi7X(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			YpJoWsPi7X(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			YpJoWsPi7X(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			YpJoWsPi7X(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			YpJoWsPi7X(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			YpJoWsPi7X(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			YpJoWsPi7X(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			YpJoWsPi7X(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			YpJoWsPi7X(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void TAOohhiP7R(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static void zDKosecjaB(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static void ubAof6RgCm(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static void YpJoWsPi7X(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static uint BEVodWAYPB(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool gX8onkMSd7()
	{
		if (!V9fkgxQPQA)
		{
			XS8oLZGMXn();
			V9fkgxQPQA = true;
		}
		return LrEkS2eXQL;
	}

	internal static SymmetricAlgorithm PEXoCqmS4w()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (gX8onkMSd7())
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

	internal static void XS8oLZGMXn()
	{
		try
		{
			LrEkS2eXQL = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] XEDoeIU7mj(byte[] byte_0)
	{
		if (!gX8onkMSd7())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return ab9oDe4UH3(byte_0);
	}

	internal static void vBuojdip3i(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			NSmolmd79S(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void NSmolmd79S(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint SDQoufkqT0(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static void iXLoKRSpAw()
	{
		int num = 13;
		string text = default(string);
		HashAlgorithm object_2 = default(HashAlgorithm);
		string object_3 = default(string);
		int num29 = default(int);
		byte[] array4 = default(byte[]);
		int num22 = default(int);
		byte[] object_7 = default(byte[]);
		int num21 = default(int);
		byte[] array5 = default(byte[]);
		int num25 = default(int);
		int num24 = default(int);
		int num23 = default(int);
		Stream stream = default(Stream);
		SymmetricAlgorithm object_6 = default(SymmetricAlgorithm);
		byte[] object_8 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		CryptoStream object_5 = default(CryptoStream);
		byte[] array3 = default(byte[]);
		int num27 = default(int);
		long num10 = default(long);
		int num9 = default(int);
		uint num7 = default(uint);
		uint num16 = default(uint);
		long num5 = default(long);
		int int_ = default(int);
		long num4 = default(long);
		long num8 = default(long);
		byte[] array2 = default(byte[]);
		int num11 = default(int);
		long long_ = default(long);
		uint num14 = default(uint);
		uint uint_ = default(uint);
		uint uint_2 = default(uint);
		uint num12 = default(uint);
		int num15 = default(int);
		uint num6 = default(uint);
		uint num13 = default(uint);
		bool flag = default(bool);
		int num19 = default(int);
		bool flag2 = default(bool);
		while (onZkkIlVOi == null)
		{
			int num2 = 12;
			if (Q8X6PuAZ66pEnQWCMg() == null)
			{
				goto IL_0025;
			}
			goto IL_018a;
			IL_009e:
			num2 = num;
			goto IL_0025;
			IL_0025:
			while (true)
			{
				switch (num2)
				{
				case 13:
					break;
				case 18:
					if (text == null)
					{
						return;
					}
					goto case 14;
				case 14:
					if (S7AvrlRnL3oEbvTxnV(text) == 0)
					{
						return;
					}
					goto case 11;
				case 11:
					object_2 = null;
					num2 = 10;
					if (Q8X6PuAZ66pEnQWCMg() == null)
					{
						continue;
					}
					goto IL_009e;
				case 16:
					flag2 = false;
					num2 = 1;
					if (Q8X6PuAZ66pEnQWCMg() == null)
					{
						continue;
					}
					goto IL_009e;
				case 15:
					try
					{
						object_2 = (HashAlgorithm)otroNqYfktPuUxqtPs();
						int num28 = 1;
						if (Q8X6PuAZ66pEnQWCMg() != null)
						{
							goto IL_00e6;
						}
						goto IL_0107;
						IL_0107:
						while (true)
						{
							switch (num28)
							{
							case 2:
								if (M9asCGJsxO6UEWZN5N(text))
								{
									num28 = 0;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									break;
								}
								return;
							case 1:
								object_3 = (string)b9i2hP1yFCFA0mkXRU("SHA1");
								num28 = 2;
								if (Q8X6PuAZ66pEnQWCMg() == null)
								{
									continue;
								}
								break;
							default:
								goto end_IL_0107;
							case 3:
								return;
							case 0:
							case 4:
								goto end_IL_0107;
							}
							goto IL_00e6;
							continue;
							end_IL_0107:
							break;
						}
						goto end_IL_00ba;
						IL_00e6:
						num28 = num29;
						goto IL_0107;
						end_IL_00ba:;
					}
					catch
					{
						if (Q8X6PuAZ66pEnQWCMg() == null)
						{
							switch (0)
							{
							}
						}
						return;
					}
					goto case 16;
				case 12:
					II4mbg8DI7HcBFm1bf();
					goto case 2;
				case 2:
					sZNERSiV2XFxGCIxuo(bool_0: true);
					goto case 9;
				case 9:
					onZkkIlVOi = new RSACryptoServiceProvider();
					goto case 6;
				case 6:
					text = (string)c2UTnFNIs0BonkjSDm(JtnmN8tYQJeNqfcVqt(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly);
					num2 = 18;
					if (Q8X6PuAZ66pEnQWCMg() == null)
					{
						continue;
					}
					goto IL_009e;
				case 10:
					goto IL_018a;
				case 1:
					try
					{
						VtNVUKGulysZw81C3E object_4 = new VtNVUKGulysZw81C3E((Stream)PwucW8jrQnqwO9nksv(x4Dk2IHVmX, "Zolk9kCyJtZSWZwA3H.C5fn7SnRigF4bi1Hkk"));
						while (true)
						{
							IL_22e6:
							VymkpwXddOWY529qU7(WXOeb5wHIamrsOQSBc(object_4), 0L);
							int num20 = 2;
							if (Q8X6PuAZ66pEnQWCMg() == null)
							{
								goto IL_0b9d;
							}
							goto IL_1d58;
							IL_1d58:
							while (true)
							{
								switch (num20)
								{
								case 352:
									array4[21] = 115;
									goto case 69;
								case 69:
									array4[21] = 91;
									goto case 32;
								case 32:
									num22 = 87;
									num20 = 186;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 351:
									array4[31] = (byte)num22;
									goto case 55;
								case 55:
									object_7 = array4;
									num21 = 27;
									goto case 27;
								case 27:
									array5 = new byte[16];
									goto case 140;
								case 140:
									array5[0] = 148;
									num20 = 345;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 218;
								case 218:
									array5[1] = 78;
									goto case 139;
								case 139:
									num25 = 142;
									goto case 245;
								case 245:
									array5[2] = (byte)num25;
									num20 = 63;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 350:
									array4[22] = 31;
									goto case 85;
								case 85:
									array4[23] = 93;
									goto case 187;
								case 187:
									num22 = 98;
									num20 = 171;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 349:
									array4[1] = (byte)num24;
									num20 = 4;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 8;
								case 8:
									array4[1] = 111;
									goto case 134;
								case 134:
									array4[1] = 130;
									num20 = 24;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 9;
								case 9:
									array5[13] = (byte)num23;
									goto case 260;
								case 260:
									num23 = 154;
									num20 = 306;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 348:
									num24 = 156;
									goto case 253;
								case 253:
									array4[31] = (byte)num24;
									goto case 316;
								case 316:
									num24 = 155;
									goto case 29;
								case 29:
									array4[31] = (byte)num24;
									goto case 243;
								case 243:
									array4[31] = 106;
									num20 = 224;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 347:
									num24 = 161;
									num20 = 31;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 239;
								case 239:
									array4[17] = (byte)num24;
									goto case 221;
								case 221:
									array4[17] = 156;
									goto case 164;
								case 164:
									array4[17] = 133;
									num20 = 334;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 346:
									num23 = 84;
									num20 = 118;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 345:
									array5[0] = 124;
									goto case 202;
								case 202:
									num23 = 168;
									num20 = 295;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 14;
								case 14:
									array5[0] = 198;
									num20 = 250;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 197;
								case 197:
									array4[22] = 98;
									num21 = 350;
									goto case 350;
								case 344:
									array4[4] = 165;
									num21 = 146;
									goto case 146;
								case 146:
									num22 = 50;
									goto case 249;
								case 249:
									array4[4] = (byte)num22;
									num20 = 14;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 37;
								case 37:
									num24 = 108;
									goto case 18;
								case 18:
									array4[4] = (byte)num24;
									goto case 297;
								case 297:
									num22 = 94;
									num21 = 211;
									goto case 211;
								case 211:
									array4[4] = (byte)num22;
									goto case 104;
								case 104:
									array4[4] = 61;
									goto case 199;
								case 199:
									num24 = 155;
									goto case 339;
								case 339:
									array4[5] = (byte)num24;
									goto case 52;
								case 52:
									array4[5] = 107;
									goto case 50;
								case 50:
									array4[5] = 243;
									num20 = 259;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 94;
								case 94:
									array4[16] = 196;
									num21 = 229;
									goto case 229;
								case 229:
									array4[16] = 92;
									num20 = 343;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 343:
									num24 = 186;
									goto case 143;
								case 143:
									array4[17] = (byte)num24;
									goto case 347;
								case 342:
									array4[6] = (byte)num24;
									num20 = 112;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 341:
									num24 = 82;
									goto case 322;
								case 322:
									array4[19] = (byte)num24;
									goto case 225;
								case 225:
									num22 = 94;
									num20 = 340;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 340:
									array4[19] = (byte)num22;
									num20 = 43;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 117;
								case 117:
									array4[19] = 157;
									num20 = 241;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 338:
									array5[6] = 98;
									goto case 12;
								case 12:
									array5[6] = 115;
									num20 = 219;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 337:
									array4[14] = 152;
									num20 = 210;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 226;
								case 226:
									num22 = 176;
									goto case 173;
								case 173:
									array4[15] = (byte)num22;
									num20 = 60;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 336:
									num23 = 152;
									goto case 182;
								case 182:
									array5[13] = (byte)num23;
									goto case 246;
								case 246:
									num23 = 170;
									num21 = 62;
									goto case 62;
								case 62:
									array5[13] = (byte)num23;
									goto case 204;
								case 204:
									num23 = 108;
									goto case 124;
								case 124:
									array5[13] = (byte)num23;
									goto case 234;
								case 234:
									num23 = 90;
									goto case 9;
								case 335:
									array5[1] = 106;
									goto case 218;
								case 334:
									array4[17] = 108;
									num21 = 175;
									goto case 175;
								case 175:
									array4[17] = 243;
									goto case 236;
								case 236:
									array4[18] = 96;
									num20 = 206;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 333:
									array4[24] = 151;
									goto case 28;
								case 28:
									array4[24] = 75;
									goto case 109;
								case 109:
									num24 = 193;
									goto case 40;
								case 40:
									array4[24] = (byte)num24;
									goto case 92;
								case 92:
									array4[24] = 151;
									num20 = 39;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 311;
								case 311:
									num22 = 162;
									goto case 76;
								case 76:
									array4[24] = (byte)num22;
									num20 = 308;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 332:
									array5[6] = (byte)num23;
									goto case 162;
								case 162:
									num25 = 83;
									num20 = 279;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 166;
								case 166:
									array5[3] = (byte)num23;
									num20 = 38;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 209;
								case 209:
									array5[3] = 86;
									goto case 237;
								case 237:
									num25 = 21;
									goto case 74;
								case 74:
									array5[3] = (byte)num25;
									num20 = 15;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 14;
								case 331:
									num22 = 125;
									goto case 119;
								case 119:
									array4[22] = (byte)num22;
									goto case 197;
								case 330:
									array5[5] = (byte)num25;
									goto case 163;
								case 163:
									num23 = 46;
									goto case 142;
								case 142:
									array5[5] = (byte)num23;
									num20 = 338;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 176;
								case 329:
									array4[14] = 215;
									goto case 325;
								case 325:
									num24 = 148;
									goto case 72;
								case 72:
									array4[14] = (byte)num24;
									num20 = 337;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 328:
									num22 = 33;
									goto case 220;
								case 220:
									array4[0] = (byte)num22;
									num20 = 38;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 269;
								case 269:
									num24 = 110;
									num20 = 349;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 327:
									array4[6] = (byte)num24;
									goto case 95;
								case 95:
									array4[6] = 101;
									num20 = 324;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 326:
									num24 = 72;
									num20 = 287;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 324:
									num24 = 176;
									goto case 100;
								case 100:
									array4[6] = (byte)num24;
									num20 = 160;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 323:
									array4[2] = (byte)num22;
									num20 = 47;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 321:
									array5[8] = 105;
									num21 = 167;
									goto case 167;
								case 167:
									num25 = 163;
									num21 = 189;
									goto case 189;
								case 189:
									array5[8] = (byte)num25;
									goto case 153;
								case 153:
									num25 = 5;
									num20 = 66;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 320:
									array5[0] = (byte)num23;
									num20 = 14;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 14;
								case 319:
									array4[28] = (byte)num22;
									num21 = 284;
									goto case 284;
								case 284:
									array4[28] = 91;
									goto case 256;
								case 256:
									array4[28] = 168;
									goto case 185;
								case 185:
									num24 = 219;
									goto case 262;
								case 262:
									array4[28] = (byte)num24;
									num20 = 212;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 318:
									num22 = 60;
									goto case 179;
								case 179:
									array4[10] = (byte)num22;
									goto case 31;
								case 31:
									array4[10] = 83;
									goto case 174;
								case 174:
									num22 = 148;
									goto case 101;
								case 101:
									array4[11] = (byte)num22;
									goto case 288;
								case 288:
									array4[11] = 156;
									goto case 91;
								case 91:
									num22 = 44;
									num20 = 82;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 317:
									array4[2] = (byte)num22;
									num20 = 303;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 315:
									array5[11] = (byte)num25;
									num20 = 73;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 39;
								case 39:
									num24 = 33;
									goto case 223;
								case 223:
									array4[7] = (byte)num24;
									num21 = 77;
									goto case 77;
								case 77:
									num24 = 147;
									goto case 114;
								case 114:
									array4[8] = (byte)num24;
									num20 = 107;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 18;
								case 314:
									array4[21] = 157;
									goto case 331;
								case 313:
									array4[27] = (byte)num22;
									goto case 122;
								case 122:
									array4[27] = 138;
									num20 = 184;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 129;
								case 129:
									array5[9] = 54;
									goto case 13;
								case 13:
									array5[10] = 79;
									goto case 133;
								case 133:
									array5[10] = 149;
									goto case 54;
								case 54:
									num23 = 116;
									num20 = 242;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 312:
									break;
								case 198:
									goto IL_0bb3;
								case 111:
									goto IL_0bc1;
								case 296:
									goto IL_0bd0;
								case 310:
									num24 = 163;
									num20 = 309;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 309:
									array4[0] = (byte)num24;
									goto case 278;
								case 278:
									array4[0] = 94;
									num20 = 235;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 308:
									array4[24] = 195;
									num21 = 213;
									goto case 213;
								case 213:
									array4[25] = 136;
									goto case 123;
								case 123:
									array4[25] = 63;
									goto case 289;
								case 289:
									array4[25] = 151;
									num21 = 283;
									goto case 283;
								case 283:
									array4[25] = 71;
									goto case 17;
								case 17:
									array4[25] = 9;
									goto case 201;
								case 201:
									array4[26] = 206;
									num20 = 233;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 307:
									array4[1] = 105;
									goto case 217;
								case 217:
									array4[1] = 143;
									num20 = 106;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 300;
								case 300:
									num22 = 168;
									goto case 88;
								case 88:
									array4[2] = (byte)num22;
									goto case 19;
								case 19:
									num24 = 158;
									goto case 106;
								case 106:
									array4[2] = (byte)num24;
									goto case 232;
								case 232:
									num22 = 126;
									num20 = 128;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 57;
								case 57:
									num23 = 235;
									num20 = 240;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 306:
									array5[13] = (byte)num23;
									goto case 168;
								case 168:
									num23 = 126;
									num20 = 42;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 305:
									array4[16] = (byte)num22;
									goto case 94;
								case 304:
									array4[14] = 144;
									goto case 80;
								case 80:
									num22 = 86;
									goto case 200;
								case 200:
									array4[14] = (byte)num22;
									num20 = 329;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 303:
									num22 = 159;
									num20 = 323;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 302:
									array5[14] = 133;
									goto case 25;
								case 25:
									num25 = 122;
									num21 = 216;
									goto case 216;
								case 216:
									array5[14] = (byte)num25;
									goto case 194;
								case 194:
									num25 = 70;
									num20 = 281;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 301:
									array4[7] = 99;
									goto case 275;
								case 275:
									array4[7] = 210;
									goto case 39;
								case 299:
									array4[13] = (byte)num22;
									num20 = 4;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 298:
									array5[4] = (byte)num23;
									num20 = 113;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 295:
									array5[0] = (byte)num23;
									goto case 271;
								case 271:
									array5[0] = 145;
									num20 = 34;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 5;
								case 5:
									array4[20] = (byte)num22;
									num20 = 88;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 157;
								case 157:
									array4[20] = 91;
									num20 = 71;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 81;
								case 81:
									num22 = 161;
									goto case 115;
								case 115:
									array4[20] = (byte)num22;
									num20 = 277;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 60;
								case 60:
									array4[15] = 94;
									num20 = 286;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 294:
									num25 = 148;
									goto case 93;
								case 93:
									array5[12] = (byte)num25;
									goto case 20;
								case 20:
									num25 = 133;
									num20 = 1;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 293:
									num24 = 175;
									goto case 231;
								case 231:
									array4[26] = (byte)num24;
									goto case 116;
								case 116:
									array4[26] = 166;
									goto case 10;
								case 10:
									array4[27] = 99;
									num21 = 254;
									goto case 254;
								case 254:
									array4[27] = 152;
									num20 = 105;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 292:
									array4[12] = (byte)num24;
									num20 = 33;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 56;
								case 56:
									array4[13] = 151;
									num20 = 72;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 145;
								case 145:
									array4[13] = 122;
									num20 = 22;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 291:
									array4[30] = (byte)num22;
									goto case 169;
								case 169:
									array4[30] = 106;
									num20 = 144;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 290:
									num22 = 39;
									num20 = 58;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 287:
									array4[30] = (byte)num24;
									num20 = 70;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 52;
								case 286:
									array4[15] = 67;
									goto case 181;
								case 181:
									num24 = 25;
									goto case 68;
								case 68:
									array4[15] = (byte)num24;
									goto case 59;
								case 59:
									num22 = 171;
									num20 = 2;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 126;
								case 126:
									array4[15] = (byte)num22;
									goto case 103;
								case 103:
									array4[16] = 120;
									num20 = 280;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 129;
								case 285:
									array4[19] = 75;
									num20 = 183;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 96;
								case 96:
									stream = (Stream)HFrmJl2Alwc9Te6y4t();
									num20 = 87;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 282:
									array5[4] = 154;
									goto case 154;
								case 154:
									array5[4] = 151;
									goto case 71;
								case 71:
									num23 = 108;
									num20 = 298;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 88;
								case 281:
									array5[14] = (byte)num25;
									num20 = 65;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 280:
									num22 = 132;
									goto case 305;
								case 279:
									array5[7] = (byte)num25;
									num21 = 272;
									goto case 272;
								case 272:
									array5[7] = 168;
									num20 = 35;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 277:
									array4[20] = 198;
									goto case 2;
								case 2:
									array4[20] = 31;
									num20 = 352;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 276:
									num24 = 209;
									goto case 41;
								case 41:
									array4[9] = (byte)num24;
									num20 = 8;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 214;
								case 214:
									num24 = 81;
									goto case 90;
								case 90:
									array4[10] = (byte)num24;
									goto case 78;
								case 78:
									array4[10] = 153;
									goto case 268;
								case 268:
									num24 = 116;
									num20 = 31;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 36;
								case 36:
									array4[10] = (byte)num24;
									goto case 148;
								case 148:
									num24 = 115;
									goto case 188;
								case 188:
									array4[10] = (byte)num24;
									num20 = 318;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 274:
									num23 = 48;
									goto case 102;
								case 102:
									array5[3] = (byte)num23;
									goto case 180;
								case 180:
									num23 = 179;
									num20 = 28;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 166;
								case 273:
									array5[11] = 157;
									num20 = 294;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 266:
									array4[0] = (byte)num22;
									num20 = 177;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 138;
								case 138:
									array4[21] = (byte)num24;
									num20 = 314;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 290;
								case 265:
									array5[2] = 222;
									goto case 49;
								case 49:
									array5[2] = 158;
									goto case 131;
								case 131:
									array5[2] = 126;
									goto case 3;
								case 3:
									num25 = 160;
									num20 = 228;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 264:
									num24 = 57;
									goto case 67;
								case 67:
									array4[29] = (byte)num24;
									goto case 165;
								case 165:
									array4[29] = 91;
									num20 = 255;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 263:
									num24 = 162;
									num20 = 64;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 261:
									WBS940x28268jF0EVq(object_6, CipherMode.CBC);
									num20 = 7;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto default;
								default:
									array4[1] = (byte)num22;
									goto case 307;
								case 259:
									num24 = 103;
									num20 = 124;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 327;
								case 258:
									array5[7] = (byte)num23;
									num20 = 321;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 257:
									array5[13] = 102;
									goto case 336;
								case 255:
									num22 = 84;
									goto case 125;
								case 125:
									array4[29] = (byte)num22;
									num20 = 141;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 251:
									array4[9] = 131;
									num20 = 72;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										continue;
									}
									goto case 196;
								case 196:
									num24 = 104;
									goto case 11;
								case 11:
									array4[9] = (byte)num24;
									num20 = 32;
									if (!MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 203;
								case 203:
									array4[9] = 79;
									goto case 276;
								case 250:
									array5[1] = 72;
									num20 = 26;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 248:
									num25 = 21;
									goto case 195;
								case 195:
									array5[12] = (byte)num25;
									num20 = 257;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 247:
									array5[9] = 127;
									num21 = 155;
									goto case 155;
								case 155:
									array5[9] = 135;
									goto case 83;
								case 83:
									array5[9] = 118;
									num20 = 129;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 244:
									num22 = 130;
									goto case 208;
								case 208:
									array4[18] = (byte)num22;
									num20 = 108;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 22;
								case 22:
									num22 = 146;
									num20 = 299;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 188;
								case 242:
									array5[10] = (byte)num23;
									goto case 149;
								case 149:
									array5[10] = 106;
									num20 = 210;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 241:
									array4[19] = 81;
									goto case 120;
								case 120:
									num22 = 129;
									goto case 5;
								case 240:
									array5[4] = (byte)num23;
									goto case 151;
								case 151:
									array5[4] = 102;
									goto case 282;
								case 235:
									num22 = 60;
									goto case 266;
								case 233:
									num22 = 185;
									num21 = 48;
									goto case 48;
								case 48:
									array4[26] = (byte)num22;
									goto case 293;
								case 230:
									object_6 = (SymmetricAlgorithm)kw9XV0snA9GhG2xASw();
									goto case 261;
								case 228:
									array5[2] = (byte)num25;
									num20 = 150;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 30;
								case 30:
									num22 = 21;
									goto case 84;
								case 84:
									array4[3] = (byte)num22;
									num21 = 136;
									goto case 136;
								case 136:
									array4[3] = 32;
									goto case 344;
								case 227:
									num22 = 113;
									goto case 317;
								case 224:
									num22 = 131;
									goto case 351;
								case 222:
									array4[18] = (byte)num24;
									goto case 110;
								case 110:
									array4[18] = 68;
									num20 = 244;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 219:
									num23 = 45;
									goto case 332;
								case 215:
									array5[15] = 134;
									goto case 207;
								case 207:
									num25 = 112;
									num20 = 137;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 212:
									num22 = 135;
									num20 = 135;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 210:
									array5[10] = 227;
									goto case 127;
								case 127:
									num25 = 81;
									goto case 315;
								case 206:
									num24 = 215;
									num20 = 222;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 205:
									array4[21] = (byte)num22;
									num20 = 51;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 192:
									num22 = 24;
									goto case 291;
								case 191:
									array4[23] = 103;
									num20 = 132;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 190:
									num22 = 160;
									num20 = 205;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 186:
									array4[21] = (byte)num22;
									num20 = 190;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 143;
								case 184:
									num22 = 164;
									num21 = 319;
									goto case 319;
								case 183:
									num22 = 136;
									goto case 130;
								case 130:
									array4[19] = (byte)num22;
									goto case 341;
								case 178:
									array5[8] = 168;
									num21 = 45;
									goto case 45;
								case 45:
									array5[9] = 108;
									num20 = 247;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 177:
									array4[0] = 117;
									num20 = 328;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 183;
								case 172:
									array4[3] = (byte)num24;
									goto case 121;
								case 121:
									num22 = 104;
									goto case 147;
								case 147:
									array4[3] = (byte)num22;
									num20 = 30;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 171:
									array4[23] = (byte)num22;
									num20 = 191;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 70;
								case 70:
									array4[30] = 167;
									goto case 192;
								case 170:
									array4[14] = 81;
									goto case 304;
								case 161:
									array4[29] = 4;
									num20 = 99;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto case 1;
								case 1:
									array5[12] = (byte)num25;
									goto case 248;
								case 160:
									num24 = 47;
									num21 = 342;
									goto case 342;
								case 159:
									num24 = 152;
									num20 = 172;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 140;
								case 158:
									array4[12] = (byte)num22;
									goto case 43;
								case 43:
									num24 = 78;
									num20 = 292;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 156:
									array4[12] = (byte)num24;
									num21 = 21;
									goto case 21;
								case 21:
									array4[12] = 106;
									num21 = 290;
									goto case 290;
								case 152:
									array4[12] = (byte)num24;
									num20 = 23;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 150:
									array5[3] = 94;
									goto case 274;
								case 144:
									array4[31] = 132;
									goto case 348;
								case 141:
									array4[29] = 134;
									num20 = 161;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 137:
									array5[15] = (byte)num25;
									goto case 75;
								case 75:
									num25 = 248;
									num21 = 44;
									goto case 44;
								case 44:
									array5[15] = (byte)num25;
									goto case 79;
								case 79:
									object_8 = array5;
									num20 = 230;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 135:
									array4[29] = (byte)num22;
									goto case 264;
								case 132:
									array4[23] = 164;
									goto case 46;
								case 46:
									array4[23] = 27;
									num21 = 333;
									goto case 333;
								case 128:
									array4[2] = (byte)num22;
									goto case 227;
								case 118:
									array5[11] = (byte)num23;
									goto case 273;
								case 113:
									array5[5] = 147;
									num20 = 98;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto case 75;
								case 112:
									array4[7] = 95;
									goto case 97;
								case 97:
									array4[7] = 111;
									goto case 301;
								case 108:
									array4[18] = 70;
									goto case 285;
								case 107:
									array4[8] = 91;
									goto case 6;
								case 6:
									array4[8] = 186;
									num20 = 263;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 105:
									num22 = 95;
									goto case 313;
								case 99:
									array4[30] = 160;
									goto case 326;
								case 98:
									num25 = 99;
									goto case 330;
								case 89:
									num24 = 96;
									num20 = 152;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 82:
									array4[11] = (byte)num22;
									goto case 16;
								case 16:
									num24 = 124;
									goto case 156;
								case 73:
									num23 = 108;
									goto case 33;
								case 33:
									array5[11] = (byte)num23;
									goto case 346;
								case 66:
									array5[8] = (byte)num25;
									num20 = 178;
									if (Q8X6PuAZ66pEnQWCMg() == null)
									{
										continue;
									}
									goto IL_01ec;
								case 65:
									array5[15] = 130;
									goto case 215;
								case 64:
									array4[9] = (byte)num24;
									num21 = 251;
									goto case 251;
								case 63:
									array5[2] = 120;
									goto case 265;
								case 61:
									num23 = 122;
									goto case 38;
								case 38:
									array5[1] = (byte)num23;
									num21 = 335;
									goto case 335;
								case 58:
									array4[12] = (byte)num22;
									num21 = 89;
									goto case 89;
								case 51:
									num24 = 134;
									goto case 138;
								case 47:
									array4[3] = 48;
									num20 = 159;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 42:
									array5[14] = (byte)num23;
									goto case 302;
								case 35:
									num23 = 87;
									goto case 258;
								case 34:
									num23 = 164;
									goto case 320;
								case 26:
									array5[1] = 168;
									num21 = 61;
									goto case 61;
								case 24:
									num22 = 136;
									num20 = 0;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto default;
								case 23:
									num22 = 113;
									goto case 158;
								case 15:
									array5[3] = 205;
									goto case 57;
								case 7:
									transform = (ICryptoTransform)kjuQwEe5PVurcPZKMQ(object_6, object_7, object_8);
									num21 = 96;
									goto case 96;
								case 4:
									array4[13] = 30;
									num20 = 170;
									if (MjUpQTUAyyOAp6C2gO())
									{
										continue;
									}
									goto IL_01ec;
								case 238:
									goto IL_22e6;
								case 87:
									object_5 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
									num21 = 267;
									goto case 267;
								case 267:
									aBGsYJukCtknOBPdhe(object_5, array3, 0, array3.Length);
									goto case 86;
								case 86:
									Ehl5ahyGm25yJdTcn9(object_5);
									goto case 176;
								case 176:
									Gy5MrBqpDgNC07UXTq(onZkkIlVOi, cwgZ22rDsSHcxkecNY(bC8IdekKvqYj6IlgON(), E323IrFBAerYfQ7ORP(stream)));
									num21 = 53;
									goto case 53;
								case 53:
									cOXRIv0aQQDp1vG7i5(stream);
									goto case 270;
								case 270:
									cOXRIv0aQQDp1vG7i5(object_5);
									num21 = 193;
									goto case 193;
								case 193:
									AV0fJeBwnY4WbR45iL(object_4);
									goto end_IL_22e6;
								case 252:
									goto end_IL_22e6;
								}
								break;
							}
							goto IL_0b9d;
							IL_0b9d:
							array3 = (byte[])zsgogFH9IX0aLEDDm9(object_4, (int)KZTrtCf53NZXL4PTtk(WXOeb5wHIamrsOQSBc(object_4)));
							goto IL_0bb3;
							IL_0bb3:
							array4 = new byte[32];
							goto IL_0bc1;
							IL_0bc1:
							num22 = 118;
							num21 = 296;
							goto IL_0bd0;
							IL_0bd0:
							array4[0] = (byte)num22;
							num20 = 310;
							if (!MjUpQTUAyyOAp6C2gO())
							{
								goto IL_01ec;
							}
							goto IL_1d58;
							IL_01ec:
							num20 = num21;
							goto IL_1d58;
							continue;
							end_IL_22e6:
							break;
						}
					}
					catch
					{
						int num26 = 0;
						if (!MjUpQTUAyyOAp6C2gO())
						{
							num26 = num27;
						}
						while (true)
						{
							switch (num26)
							{
							default:
								flag2 = true;
								num26 = 1;
								if (Q8X6PuAZ66pEnQWCMg() != null)
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
					goto default;
				default:
					if (!flag2)
					{
						num2 = 17;
						if (MjUpQTUAyyOAp6C2gO())
						{
							continue;
						}
						return;
					}
					goto case 8;
				case 17:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						while (true)
						{
							IL_2a15:
							BinaryReader object_ = new BinaryReader(fileStream);
							while (true)
							{
								IL_29f4:
								byte[] array = new byte[65536];
								int num3 = 44;
								if (!MjUpQTUAyyOAp6C2gO())
								{
									goto IL_288e;
								}
								goto IL_28c5;
								IL_28c5:
								while (true)
								{
									switch (num3)
									{
									case 73:
										array[39] = 0;
										goto case 21;
									case 21:
										lTpnE0bAsXkTddG4aT(object_2, array, 0, 128);
										num3 = 1;
										if (Q8X6PuAZ66pEnQWCMg() != null)
										{
											continue;
										}
										goto case 7;
									case 7:
										num10 = AXOUZwIZuxUBMWZHh0(fileStream);
										num3 = 63;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto IL_2422;
									case 72:
										array[66] = 0;
										num9 = 58;
										goto case 58;
									case 58:
										array[67] = 0;
										num3 = 68;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto IL_2422;
									case 16:
									case 71:
										break;
									case 29:
										goto IL_246c;
									case 5:
										goto IL_247e;
									case 70:
										array[38] = 0;
										goto case 73;
									case 69:
										num7 -= num16;
										goto case 8;
									case 8:
									case 14:
									case 49:
										if (num7 == 0)
										{
											goto IL_24b0;
										}
										goto case 51;
									case 17:
									case 47:
										goto IL_24b0;
									case 28:
									case 62:
										goto IL_24b6;
									case 53:
										goto IL_24ce;
									case 51:
										num5 = AXOUZwIZuxUBMWZHh0(fileStream);
										num3 = 35;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto IL_2422;
									case 68:
										lTpnE0bAsXkTddG4aT(object_2, array, 0, int_);
										num3 = 66;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto IL_2422;
									case 67:
										if (num5 < num4)
										{
											goto case 3;
										}
										goto IL_256a;
									case 3:
									case 39:
										num16 = (uint)F9hfLPEXa6TTj6vidY(num8 - num5, num7);
										goto case 37;
									case 37:
										g3L1ud53dmLm0QRsAZ(object_2, fileStream, num16, array);
										num3 = 69;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto IL_2422;
									case 11:
										goto IL_256a;
									case 66:
										PejaI79GYOY8UhfnPZ(fileStream, array, 0, 128);
										num3 = 27;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto IL_2422;
									case 65:
										flag2 = !bj15SVKnAylKJmoLma(onZkkIlVOi, GYvrQMS8pKiMfMlh1c(object_2), object_3, array2);
										num3 = 0;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto end_IL_29f4;
									case 63:
										VymkpwXddOWY529qU7(fileStream, 134L);
										goto case 13;
									case 23:
										VymkpwXddOWY529qU7(fileStream, num10);
										num3 = 42;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto case 13;
									case 13:
										num11 = iN4Rm6COI9q7SRLyMl(object_);
										goto case 23;
									case 61:
										long_ = AXOUZwIZuxUBMWZHh0(fileStream);
										num3 = 45;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto IL_2627;
									case 33:
										goto IL_2627;
									case 60:
										x7GgNxdQoFBb9qdlHj(array2);
										goto case 65;
									case 57:
										VymkpwXddOWY529qU7(fileStream, 152L);
										goto case 34;
									case 34:
										PejaI79GYOY8UhfnPZ(fileStream, array, 0, int_);
										goto case 32;
									case 32:
										array[64] = 0;
										goto case 10;
									case 10:
										array[65] = 0;
										num3 = 72;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto IL_2422;
									case 56:
										num14 = YvMOwapfr8H4AmrJhD(uint_, num11, num10, object_);
										goto case 46;
									case 46:
										VymkpwXddOWY529qU7(fileStream, num14 + 32);
										goto case 18;
									case 18:
										uint_2 = JXE4C9cJpC9DrLXLf5(object_);
										goto case 12;
									case 12:
										num12 = JXE4C9cJpC9DrLXLf5(object_);
										goto case 54;
									case 54:
										num8 = YvMOwapfr8H4AmrJhD(uint_2, num11, num10, object_);
										num3 = 1;
										if (Q8X6PuAZ66pEnQWCMg() != null)
										{
											continue;
										}
										goto case 15;
									case 15:
										num4 = num8 + num12;
										num3 = 11;
										if (!MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto case 36;
									case 36:
										VymkpwXddOWY529qU7(fileStream, long_);
										goto case 24;
									case 24:
										num15 = 0;
										goto IL_24b6;
									case 55:
										VymkpwXddOWY529qU7(fileStream, AXOUZwIZuxUBMWZHh0(fileStream) + num6);
										num9 = 49;
										goto case 8;
									case 52:
										VymkpwXddOWY529qU7(fileStream, num13);
										goto case 8;
									case 50:
										array[36] = 0;
										num3 = 1;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto end_IL_29f4;
									case 48:
										array[35] = 0;
										goto case 50;
									case 45:
										if (!flag)
										{
											goto case 25;
										}
										goto case 26;
									case 25:
									case 40:
										VymkpwXddOWY529qU7(fileStream, 376L);
										goto case 4;
									case 26:
										VymkpwXddOWY529qU7(fileStream, 360L);
										goto case 4;
									case 4:
									case 19:
										uint_ = JXE4C9cJpC9DrLXLf5(object_);
										goto case 56;
									case 44:
										g3L1ud53dmLm0QRsAZ(object_2, fileStream, 152u, array);
										num3 = 22;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto case 8;
									case 43:
										array2 = (byte[])AlAGlwWX8fLEnOikJT(object_, (int)num12);
										goto case 60;
									case 42:
										g3L1ud53dmLm0QRsAZ(object_2, fileStream, (uint)(num11 * 40), array);
										num3 = 61;
										if (MjUpQTUAyyOAp6C2gO())
										{
											continue;
										}
										goto IL_2422;
									case 41:
										if (num5 < num4)
										{
											num3 = 30;
											if (MjUpQTUAyyOAp6C2gO())
											{
												continue;
											}
											goto IL_2422;
										}
										goto case 67;
									case 38:
										array[34] = 0;
										num9 = 48;
										goto case 48;
									case 35:
										if (num8 <= num5)
										{
											num3 = 41;
											if (Q8X6PuAZ66pEnQWCMg() == null)
											{
												continue;
											}
											goto IL_2422;
										}
										goto case 67;
									case 31:
										VymkpwXddOWY529qU7(fileStream, num8);
										goto case 43;
									case 30:
										num6 = (uint)(num4 - num5);
										num3 = 2;
										if (Q8X6PuAZ66pEnQWCMg() != null)
										{
											continue;
										}
										goto case 2;
									case 2:
										if (num6 >= num7)
										{
											goto IL_24b0;
										}
										goto case 9;
									case 9:
										num7 -= num6;
										goto case 55;
									case 27:
										array[32] = 0;
										goto case 20;
									case 20:
										array[33] = 0;
										goto case 38;
									case 22:
										goto IL_288e;
									case 6:
										goto IL_28a6;
									case 1:
										array[37] = 0;
										num3 = 70;
										if (Q8X6PuAZ66pEnQWCMg() == null)
										{
											continue;
										}
										goto IL_2422;
									default:
										goto end_IL_29f4;
									case 59:
										goto IL_29f4;
									case 64:
										goto IL_2a15;
									case 0:
										goto end_IL_29f4;
									}
									break;
								}
								goto IL_2452;
								IL_28a6:
								int num17 = 112;
								goto IL_2642;
								IL_288e:
								flag = iN4Rm6COI9q7SRLyMl(object_) != 523;
								goto IL_2627;
								IL_2627:
								if (!flag)
								{
									num3 = 6;
									if (Q8X6PuAZ66pEnQWCMg() != null)
									{
										goto IL_2422;
									}
									goto IL_28c5;
								}
								num17 = 96;
								goto IL_2642;
								IL_246c:
								num7 = JXE4C9cJpC9DrLXLf5(object_);
								num9 = 5;
								goto IL_247e;
								IL_247e:
								num13 = JXE4C9cJpC9DrLXLf5(object_);
								num3 = 52;
								if (Q8X6PuAZ66pEnQWCMg() != null)
								{
									goto IL_2422;
								}
								goto IL_28c5;
								IL_2642:
								int_ = num17;
								num3 = 57;
								if (!MjUpQTUAyyOAp6C2gO())
								{
									goto IL_256a;
								}
								goto IL_28c5;
								IL_256a:
								g3L1ud53dmLm0QRsAZ(object_2, fileStream, num7, array);
								num9 = 17;
								goto IL_24b0;
								IL_24b0:
								num15++;
								goto IL_24b6;
								IL_24b6:
								if (num15 >= num11)
								{
									goto IL_24ce;
								}
								num3 = 58;
								if (Q8X6PuAZ66pEnQWCMg() == null)
								{
									goto IL_2452;
								}
								goto IL_28c5;
								IL_2422:
								num3 = num9;
								goto IL_28c5;
								IL_24ce:
								kZ8j1kOIjc9JP5JyjS(object_2, new byte[0], 0, 0);
								num3 = 31;
								if (Q8X6PuAZ66pEnQWCMg() != null)
								{
									goto IL_2422;
								}
								goto IL_28c5;
								IL_2452:
								VymkpwXddOWY529qU7(fileStream, num10 + num15 * 40 + 16L);
								goto IL_246c;
								continue;
								end_IL_29f4:
								break;
							}
							break;
						}
					}
					catch
					{
						int num18 = 0;
						if (Q8X6PuAZ66pEnQWCMg() != null)
						{
							num18 = num19;
						}
						while (true)
						{
							switch (num18)
							{
							default:
								flag2 = true;
								num18 = 1;
								if (!MjUpQTUAyyOAp6C2gO())
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
					goto case 8;
				case 8:
					if (!flag2)
					{
						goto case 4;
					}
					goto case 3;
				case 4:
					flag2 = false;
					return;
				case 3:
					throw new Exception((string?)npZFOvQXD5kPgI2P4g(nW1uWt45ylgAA4v2Tb(xyEln2lHnNyCvSd1Of(JtnmN8tYQJeNqfcVqt(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)), " is tampered."));
				case 7:
					return;
				case 5:
					return;
				}
				break;
			}
			continue;
			IL_018a:
			object_3 = null;
			num2 = 15;
			if (Q8X6PuAZ66pEnQWCMg() == null)
			{
				goto IL_0025;
			}
			goto IL_009e;
		}
	}

	public static void TAJo1U8fio(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Tqek0lIh21 == null)
			{
				lock (emjkxI4Yxp)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554449)).Assembly.GetManifestResourceStream("8YcRZQR7giU19AYvkS.C2FZI3AnQYVdyvPtb4"));
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
							num3 += EObomOjAWk(num3);
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
						VtNVUKGulysZw81C3E vtNVUKGulysZw81C3E = new VtNVUKGulysZw81C3E(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = vtNVUKGulysZw81C3E.TVtkAMaqpL();
							int value = vtNVUKGulysZw81C3E.TVtkAMaqpL();
							dictionary.Add(key, value);
						}
						vtNVUKGulysZw81C3E.VDqkQKyKML();
					}
					Tqek0lIh21 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Tqek0lIh21[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554449)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777237));
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

	private static uint vC5oV1W6FK(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint EObomOjAWk(uint uint_0)
	{
		return 0u;
	}

	internal static void w65ov7siki()
	{
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string L3hoFlcqP6(int int_0)
	{
		int num = 212;
		int num4 = default(int);
		string result = default(string);
		int int_ = default(int);
		byte[] array = default(byte[]);
		int num6 = default(int);
		int num8 = default(int);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		int num16 = default(int);
		byte[] array6 = default(byte[]);
		int num21 = default(int);
		byte[] array7 = default(byte[]);
		int num26 = default(int);
		byte[] array5 = default(byte[]);
		uint num12 = default(uint);
		uint num9 = default(uint);
		int num20 = default(int);
		int num27 = default(int);
		int num14 = default(int);
		uint num23 = default(uint);
		uint num24 = default(uint);
		int num25 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		byte[] array3 = default(byte[]);
		int num7 = default(int);
		uint num22 = default(uint);
		uint num15 = default(uint);
		int num13 = default(int);
		uint num17 = default(uint);
		uint num11 = default(uint);
		int num10 = default(int);
		byte[] array4 = default(byte[]);
		VtNVUKGulysZw81C3E object_ = default(VtNVUKGulysZw81C3E);
		while (true)
		{
			int num2;
			if (HkLkNdDPtB.Length == 0)
			{
				num2 = 211;
				if (OmBkQ93oSxysisBy5y() != null)
				{
					goto IL_010c;
				}
				goto IL_2157;
			}
			goto IL_2842;
			IL_284f:
			try
			{
				kbTkCZQ96RjLhmXcRR();
				int num3 = 1;
				if (OmBkQ93oSxysisBy5y() != null)
				{
					num3 = num4;
				}
				do
				{
					switch (num3)
					{
					case 1:
						break;
					default:
						return result;
					case 0:
						return result;
					}
					result = (string)lqAje1r4lislC4DxXs(QlUoev1pGNFQC4k2mV(), HkLkNdDPtB, int_0 + 4, int_);
					num3 = 0;
				}
				while (!VSkvy6KOqcX7hy4yoF());
				return result;
			}
			catch
			{
				if (OmBkQ93oSxysisBy5y() != null)
				{
					switch (0)
					{
					}
				}
			}
			break;
			IL_2157:
			while (true)
			{
				switch (num2)
				{
				case 434:
					array[29] = (byte)num6;
					num2 = 180;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 221;
				case 221:
					array[30] = 155;
					goto case 131;
				case 131:
					array[30] = 92;
					goto case 74;
				case 74:
					array[30] = 110;
					goto case 351;
				case 351:
					num8 = 94;
					num2 = 4;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 7;
				case 7:
					array[30] = (byte)num8;
					num = 4;
					goto case 4;
				case 4:
					num6 = 198;
					num = 362;
					goto case 362;
				case 362:
					array[30] = (byte)num6;
					goto case 388;
				case 388:
					num8 = 45;
					num2 = 114;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 311;
				case 311:
					array[30] = (byte)num8;
					goto case 218;
				case 218:
					array[31] = 198;
					goto case 374;
				case 374:
					num8 = 109;
					goto case 52;
				case 52:
					array[31] = (byte)num8;
					num2 = 408;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 433:
					array[20] = 230;
					goto case 275;
				case 275:
					array[20] = 235;
					num = 85;
					goto case 85;
				case 85:
					array[20] = 167;
					goto case 213;
				case 213:
					array[21] = 102;
					goto case 215;
				case 215:
					num8 = 215;
					goto case 325;
				case 325:
					array[21] = (byte)num8;
					goto case 296;
				case 296:
					array[21] = 138;
					num2 = 111;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 432:
					array[17] = 65;
					goto case 138;
				case 138:
					num8 = 207;
					goto case 197;
				case 197:
					array[17] = (byte)num8;
					num2 = 18;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 209;
				case 209:
					num8 = 77;
					num = 192;
					goto case 192;
				case 192:
					array[17] = (byte)num8;
					num2 = 140;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 431:
					array[2] = 149;
					goto case 425;
				case 425:
					num6 = 92;
					num2 = 411;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 302;
				case 302:
					array2[4] = (byte)num5;
					goto case 191;
				case 191:
					array2[4] = 144;
					goto case 239;
				case 239:
					array2[4] = 95;
					goto case 259;
				case 259:
					num5 = 202;
					goto case 284;
				case 284:
					array2[4] = (byte)num5;
					num2 = 156;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 430:
					array[14] = (byte)num8;
					goto case 318;
				case 318:
					num8 = 168;
					goto case 55;
				case 55:
					array[14] = (byte)num8;
					num2 = 251;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 429:
					num5 = 126;
					goto case 6;
				case 6:
					array2[6] = (byte)num5;
					goto case 121;
				case 121:
					array2[6] = 137;
					goto case 126;
				case 126:
					array2[6] = 90;
					num2 = 199;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 428:
					array[17] = (byte)num6;
					goto case 432;
				case 427:
					HkLkNdDPtB = (byte[])R3CkYYmL0RGTEaInQB(stream);
					num = 405;
					goto case 405;
				case 405:
					LhfE587EYIDF6pDy2C(stream);
					goto case 350;
				case 350:
					LhfE587EYIDF6pDy2C(object_2);
					num2 = 183;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 426:
					num16 = array6.Length % 4;
					goto case 348;
				case 348:
					num21 = array6.Length / 4;
					goto case 390;
				case 390:
					array7 = new byte[array6.Length];
					goto case 184;
				case 184:
					num26 = array5.Length / 4;
					goto case 367;
				case 367:
					num11 = 0u;
					goto case 255;
				case 255:
					num12 = 0u;
					goto case 297;
				case 297:
					num9 = 0u;
					goto case 3;
				case 3:
					if (num16 > 0)
					{
						num2 = 158;
						if (OmBkQ93oSxysisBy5y() != null)
						{
							continue;
						}
						goto case 237;
					}
					goto case 114;
				case 237:
					num21++;
					goto case 114;
				case 114:
					num23 = 0u;
					goto case 67;
				case 67:
					num20 = 0;
					goto case 292;
				case 292:
				case 303:
					if (num20 < num21)
					{
						goto case 168;
					}
					goto case 360;
				case 168:
					num27 = num20 % num26;
					goto case 261;
				case 261:
					num14 = num20 * 4;
					goto case 342;
				case 342:
					num23 = (uint)(num27 * 4);
					goto case 395;
				case 395:
					num12 = (uint)((array5[num23 + 3] << 24) | (array5[num23 + 2] << 16) | (array5[num23 + 1] << 8) | array5[num23]);
					goto case 47;
				case 47:
					num24 = 255u;
					num = 160;
					goto case 160;
				case 160:
					num25 = 0;
					goto case 151;
				case 151:
					if (num20 == num21 - 1)
					{
						num2 = 363;
						if (OmBkQ93oSxysisBy5y() == null)
						{
							continue;
						}
						goto IL_010c;
					}
					goto case 120;
				case 120:
					num11 += num12;
					num2 = 53;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 69;
				case 69:
					num23 = (uint)num14;
					num2 = 409;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 424:
					array[18] = 128;
					num = 233;
					goto case 233;
				case 233:
					array[18] = 160;
					num2 = 117;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 423:
					array[0] = (byte)num6;
					goto case 224;
				case 224:
					num8 = 102;
					goto case 356;
				case 356:
					array[1] = (byte)num8;
					goto case 144;
				case 144:
					array[1] = 160;
					goto case 107;
				case 107:
					num6 = 188;
					goto case 338;
				case 338:
					array[1] = (byte)num6;
					goto case 256;
				case 256:
					array[2] = 138;
					num2 = 431;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 422:
					array[26] = 169;
					goto case 42;
				case 42:
					num6 = 27;
					goto case 286;
				case 286:
					array[26] = (byte)num6;
					num2 = 76;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 421:
					transform = (ICryptoTransform)PGWIiHb9ViHkZ8Asvw(object_3, array5, array3);
					goto case 285;
				case 285:
					stream = (Stream)WYCHWd6rXG4ADJKpNx();
					goto case 171;
				case 171:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 222;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 420:
					num25 += 8;
					goto case 169;
				case 169:
					array7[num14 + num7] = (byte)((num22 & num24) >> num25);
					num2 = 39;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 419:
					num6 = 163;
					num2 = 163;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 418:
					array[22] = (byte)num8;
					num2 = 234;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 173;
				case 173:
				case 375:
					num20++;
					goto case 292;
				case 417:
					array[0] = 80;
					num = 352;
					goto case 352;
				case 352:
					num6 = 144;
					goto case 265;
				case 265:
					array[0] = (byte)num6;
					num2 = 333;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 49;
				case 49:
					array[19] = 161;
					goto case 203;
				case 203:
					num8 = 180;
					num2 = 326;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 416:
					array7[num14 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
					num2 = 82;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 173;
				case 415:
					num6 = 213;
					goto case 382;
				case 382:
					array[24] = (byte)num6;
					num2 = 196;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 414:
					array[22] = (byte)num6;
					num2 = 14;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 98;
				case 98:
					num6 = 36;
					goto case 228;
				case 228:
					array[22] = (byte)num6;
					goto case 269;
				case 269:
					array[22] = 122;
					num2 = 372;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 385;
				case 385:
					num8 = 10;
					num2 = 418;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 413:
					array2[12] = (byte)num5;
					num = 91;
					goto case 91;
				case 91:
					array2[12] = 85;
					goto case 15;
				case 15:
					array2[12] = 159;
					goto case 241;
				case 241:
					num5 = 119;
					num2 = 76;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 148;
				case 148:
					array2[12] = (byte)num5;
					goto case 372;
				case 372:
					array2[13] = 26;
					num2 = 173;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 267;
				case 267:
					num5 = 133;
					num = 381;
					goto case 381;
				case 381:
					array2[13] = (byte)num5;
					goto case 280;
				case 280:
					array2[13] = 111;
					num2 = 146;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 412:
					num24 <<= 8;
					num2 = 420;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 20;
				case 20:
					num15 = num11 ^ num9;
					goto case 134;
				case 134:
					array7[num14] = (byte)(num15 & 0xFFu);
					num2 = 26;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 411:
					array[2] = (byte)num6;
					num2 = 113;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 410:
					num8 = 56;
					num2 = 20;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 268;
				case 268:
					array[11] = (byte)num8;
					num2 = 370;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 277;
				case 277:
					array2[8] = (byte)num5;
					num2 = 264;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 409:
					num9 = (uint)((array6[num23 + 3] << 24) | (array6[num23 + 2] << 16) | (array6[num23 + 1] << 8) | array6[num23]);
					num2 = 92;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 408:
					num8 = 96;
					num2 = 371;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 406:
					num5 = 107;
					num2 = 175;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 378;
				case 378:
					array2[5] = (byte)num5;
					goto case 28;
				case 28:
					num5 = 95;
					goto case 278;
				case 278:
					array2[5] = (byte)num5;
					num2 = 162;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 89;
				case 89:
					if (num13 <= 0)
					{
						goto case 346;
					}
					num2 = 101;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 27;
				case 346:
					num9 |= array6[^(1 + num13)];
					goto case 276;
				case 276:
					num13++;
					num = 30;
					goto case 30;
				case 30:
				case 355:
					if (num13 < num16)
					{
						goto case 89;
					}
					num2 = 247;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 92;
				case 92:
				case 384:
					num17 = num11;
					goto case 187;
				case 187:
					num11 = 0u;
					goto case 365;
				case 365:
				{
					uint num18 = num17;
					uint num19 = num17;
					num19 ^= num19 >> 16;
					num19 += 1851693862;
					num19 ^= num19 << 5;
					num19 += 1402132862;
					num19 ^= num19 >> 1;
					num19 += 437819953;
					num19 = 1742340096 - num19;
					num17 = num18 + (uint)(double)num19;
					goto case 95;
				}
				case 95:
					num11 = num17;
					goto case 190;
				case 190:
					if (num20 != num21 - 1)
					{
						goto case 20;
					}
					goto case 290;
				case 290:
					if (num16 <= 0)
					{
						goto case 20;
					}
					num = 27;
					goto case 27;
				case 27:
					num22 = num11 ^ num9;
					goto case 392;
				case 392:
					num7 = 0;
					goto case 99;
				case 99:
				case 380:
					if (num7 >= num16)
					{
						goto case 173;
					}
					goto case 279;
				case 279:
					if (num7 > 0)
					{
						num2 = 412;
						if (OmBkQ93oSxysisBy5y() == null)
						{
							continue;
						}
						goto IL_010c;
					}
					goto case 169;
				case 404:
					array[27] = (byte)num6;
					goto case 147;
				case 147:
					num6 = 151;
					goto case 248;
				case 248:
					array[28] = (byte)num6;
					goto case 216;
				case 216:
					array[28] = 133;
					num = 253;
					goto case 253;
				case 253:
					num8 = 151;
					num2 = 177;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 403:
					array[6] = 122;
					num = 379;
					goto case 379;
				case 379:
					array[6] = 87;
					num2 = 189;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 402:
					num8 = 154;
					goto case 51;
				case 51:
					array[19] = (byte)num8;
					num2 = 49;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 401:
					num5 = 238;
					num2 = 167;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 400:
					array[3] = (byte)num6;
					goto case 5;
				case 5:
					num6 = 104;
					goto case 316;
				case 316:
					array[3] = (byte)num6;
					num2 = 391;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 399:
					array[16] = 171;
					num2 = 289;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 398:
					array[25] = 252;
					goto case 322;
				case 322:
					array[26] = 119;
					num = 152;
					goto case 152;
				case 152:
					array[26] = 124;
					num2 = 337;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 397:
					array2[3] = (byte)num5;
					num2 = 305;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 396:
					array7[num14 + 2] = (byte)((num15 & 0xFF0000) >> 16);
					num2 = 416;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 229;
				case 229:
					array[13] = 149;
					goto case 393;
				case 393:
					num6 = 90;
					goto case 44;
				case 44:
					array[13] = (byte)num6;
					num2 = 22;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 17;
				case 17:
					array2[5] = (byte)num5;
					num2 = 406;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 394:
					array[29] = (byte)num6;
					num = 64;
					goto case 64;
				case 64:
					array[29] = 118;
					num2 = 45;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 341;
				case 341:
					num6 = 47;
					goto case 434;
				case 391:
					array[3] = 147;
					num2 = 14;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 389:
					array[27] = (byte)num8;
					num2 = 357;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 387:
					num5 = 157;
					goto case 245;
				case 245:
					array2[11] = (byte)num5;
					goto case 9;
				case 9:
					array2[11] = 105;
					goto case 401;
				case 386:
					array[8] = (byte)num6;
					num2 = 0;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto default;
				default:
					array[8] = 125;
					goto case 214;
				case 214:
					array[8] = 130;
					num2 = 24;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 383:
					array[27] = (byte)num8;
					goto case 339;
				case 339:
					num6 = 70;
					goto case 404;
				case 377:
					array[18] = (byte)num8;
					num2 = 193;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 376:
					array[5] = 194;
					num2 = 0;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 41;
				case 41:
					array[5] = 166;
					num2 = 335;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 373:
					array2[10] = 60;
					goto case 10;
				case 10:
					num5 = 164;
					num2 = 128;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 371:
					array[31] = (byte)num8;
					num2 = 71;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 142;
				case 142:
					array5 = array;
					goto case 54;
				case 54:
					array2 = new byte[16];
					num2 = 35;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 225;
				case 225:
					array2[0] = 114;
					num = 353;
					goto case 353;
				case 353:
					num5 = 130;
					goto case 12;
				case 12:
					array2[0] = (byte)num5;
					num2 = 53;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 370:
					num8 = 34;
					goto case 324;
				case 324:
					array[11] = (byte)num8;
					goto case 19;
				case 19:
					num8 = 85;
					goto case 153;
				case 153:
					array[11] = (byte)num8;
					goto case 34;
				case 34:
					array[12] = 111;
					goto case 204;
				case 204:
					num8 = 170;
					goto case 281;
				case 281:
					array[12] = (byte)num8;
					goto case 143;
				case 143:
					num6 = 108;
					num2 = 244;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 369:
					num8 = 105;
					goto case 100;
				case 100:
					array[4] = (byte)num8;
					num2 = 32;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 368:
					num10++;
					num2 = 88;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 366:
					array2[3] = 162;
					num2 = 71;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto default;
				case 364:
					num5 = 89;
					num2 = 293;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 363:
					if (num16 <= 0)
					{
						goto case 120;
					}
					num2 = 327;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 147;
				case 361:
					num6 = 125;
					goto case 386;
				case 359:
					array3[7] = array4[3];
					num2 = 112;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 332;
				case 332:
					array3[9] = array4[4];
					num2 = 73;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 358:
					array[19] = 109;
					num2 = 96;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 141;
				case 141:
					num8 = 79;
					num2 = 39;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 70;
				case 70:
					array[19] = (byte)num8;
					num = 344;
					goto case 344;
				case 344:
					num8 = 49;
					goto case 108;
				case 108:
					array[19] = (byte)num8;
					goto case 166;
				case 166:
					array[19] = 155;
					goto case 402;
				case 357:
					num8 = 86;
					num2 = 383;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 354:
					if (int_0 != -1)
					{
						goto case 426;
					}
					goto case 217;
				case 217:
					object_3 = (SymmetricAlgorithm)cLJaiHhCdXwXtRjq23();
					goto case 78;
				case 78:
					i4j142q6uBmtdQ5mLA(object_3, CipherMode.CBC);
					goto case 421;
				case 349:
					num6 = 108;
					num2 = 428;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 245;
				case 347:
					array[10] = 126;
					num2 = 236;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 345:
					array2[10] = 138;
					goto case 373;
				case 343:
					array2[2] = (byte)num5;
					goto case 129;
				case 129:
					array2[2] = 171;
					goto case 56;
				case 56:
					num5 = 109;
					num2 = 314;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 340:
					num5 = 141;
					goto case 164;
				case 164:
					array2[14] = (byte)num5;
					num2 = 174;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 337:
					array[26] = 151;
					goto case 422;
				case 336:
					array[24] = 165;
					goto case 317;
				case 317:
					array[24] = 86;
					num2 = 96;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 232;
				case 232:
					array[24] = 78;
					goto case 45;
				case 45:
					array[25] = 86;
					num2 = 43;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 35;
				case 35:
					array[4] = (byte)num8;
					goto case 84;
				case 84:
					array[4] = 184;
					goto case 194;
				case 194:
					num6 = 139;
					goto case 48;
				case 48:
					array[4] = (byte)num6;
					goto case 145;
				case 145:
					num6 = 168;
					num2 = 90;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 179;
				case 179:
					array[4] = (byte)num6;
					goto case 369;
				case 335:
					array[5] = 79;
					num2 = 301;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 26;
				case 26:
					array7[num14 + 1] = (byte)((num15 & 0xFF00) >> 8);
					num2 = 396;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 334:
					array[2] = (byte)num6;
					num2 = 291;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 333:
					num8 = 141;
					goto case 165;
				case 165:
					array[0] = (byte)num8;
					goto case 240;
				case 240:
					array[0] = 110;
					goto case 75;
				case 75:
					num6 = 125;
					goto case 423;
				case 331:
					array2[7] = 114;
					goto case 38;
				case 38:
					array2[7] = 92;
					goto case 135;
				case 135:
					num5 = 42;
					goto case 115;
				case 115:
					array2[7] = (byte)num5;
					goto case 364;
				case 330:
					array2[12] = 27;
					goto case 110;
				case 110:
					num5 = 92;
					goto case 413;
				case 329:
					num5 = 111;
					goto case 66;
				case 66:
					array2[8] = (byte)num5;
					goto case 202;
				case 202:
					array2[8] = 39;
					num2 = 139;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 328:
					array[0] = (byte)num8;
					goto case 417;
				case 327:
					num9 = 0u;
					goto case 231;
				case 231:
					num11 += num12;
					goto case 82;
				case 82:
					num13 = 0;
					goto case 30;
				case 326:
					array[20] = (byte)num8;
					goto case 433;
				case 323:
					array2[9] = (byte)num5;
					goto case 16;
				case 16:
					num5 = 128;
					goto case 11;
				case 11:
					array2[9] = (byte)num5;
					goto case 313;
				case 313:
					array2[9] = 207;
					goto case 94;
				case 94:
					array2[10] = 120;
					goto case 345;
				case 321:
					num5 = 92;
					goto case 18;
				case 18:
					array2[1] = (byte)num5;
					goto case 181;
				case 181:
					array2[1] = 89;
					goto case 116;
				case 116:
					array2[1] = 125;
					num2 = 1;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto default;
				case 320:
					num8 = 77;
					num2 = 430;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 319:
					array[18] = (byte)num8;
					goto case 424;
				case 315:
					num6 = 140;
					goto case 118;
				case 118:
					array[9] = (byte)num6;
					num2 = 77;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 314:
					array2[3] = (byte)num5;
					num2 = 2;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 312:
					array2[13] = 186;
					goto case 105;
				case 105:
					num5 = 143;
					goto case 112;
				case 112:
					array2[14] = (byte)num5;
					goto case 295;
				case 295:
					num5 = 114;
					num2 = 308;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 310:
					num6 = 217;
					num = 258;
					goto case 258;
				case 258:
					array[13] = (byte)num6;
					num2 = 103;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 309:
					array2[4] = (byte)num5;
					goto case 243;
				case 243:
					num5 = 188;
					num2 = 235;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 308:
					array2[14] = (byte)num5;
					goto case 340;
				case 307:
					num5 = 114;
					num2 = 176;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 309;
				case 306:
					array2[15] = (byte)num5;
					num = 180;
					goto case 180;
				case 180:
					array2[15] = 253;
					num2 = 193;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 246;
				case 246:
					array3 = array2;
					goto case 97;
				case 97:
					bNWpfSBNtBwd5N73E5(array3);
					num2 = 208;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 32;
				case 32:
					num8 = 94;
					num = 270;
					goto case 270;
				case 270:
					array[5] = (byte)num8;
					goto case 376;
				case 305:
					array2[3] = 144;
					goto case 366;
				case 304:
					array[9] = 149;
					goto case 283;
				case 283:
					num6 = 107;
					num2 = 154;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 301:
					array[5] = 120;
					goto case 87;
				case 87:
					array[5] = 14;
					goto case 403;
				case 300:
					array[6] = (byte)num6;
					goto case 80;
				case 80:
					num6 = 150;
					goto case 188;
				case 188:
					array[7] = (byte)num6;
					num = 175;
					goto case 175;
				case 175:
					array[7] = 104;
					goto case 37;
				case 37:
					array[7] = 118;
					goto case 287;
				case 287:
					array[7] = 115;
					goto case 361;
				case 299:
					array[22] = 143;
					goto case 176;
				case 176:
					num6 = 145;
					num2 = 414;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 298:
					BbVQwB9IAR87wq1gAX(v9NRpbYclbs1msheIb(object_), 0L);
					goto case 125;
				case 125:
					array6 = (byte[])KwXsXILnYT41U9plHC(object_, (int)S0nk5gtOZauJTDr7nW(v9NRpbYclbs1msheIb(object_)));
					goto case 226;
				case 226:
					Ep8t8qW3IZakIkoq7L(object_);
					num2 = 201;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 294:
					array[23] = (byte)num6;
					num2 = 25;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 36;
				case 36:
					array[24] = 221;
					num = 415;
					goto case 415;
				case 293:
					array2[8] = (byte)num5;
					goto case 122;
				case 122:
					num5 = 191;
					goto case 277;
				case 291:
					array[3] = 123;
					num2 = 252;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 289:
					num6 = 176;
					goto case 227;
				case 227:
					array[16] = (byte)num6;
					goto case 262;
				case 262:
					array[17] = 154;
					goto case 349;
				case 288:
					array2[1] = (byte)num5;
					goto case 61;
				case 61:
					array2[1] = 42;
					goto case 182;
				case 182:
					array2[2] = 131;
					num2 = 185;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 282:
					array[15] = (byte)num8;
					num2 = 50;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 50;
				case 50:
					array[15] = 94;
					goto case 223;
				case 223:
					num6 = 112;
					goto case 104;
				case 104:
					array[15] = (byte)num6;
					goto case 200;
				case 200:
					array[15] = 106;
					goto case 161;
				case 161:
					array[16] = 157;
					num2 = 292;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 399;
				case 274:
					array[22] = 160;
					num = 299;
					goto case 299;
				case 273:
					num8 = 168;
					goto case 328;
				case 272:
					num6 = 150;
					num2 = 25;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto default;
				case 271:
					num5 = 70;
					num2 = 17;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 266:
					array[9] = 119;
					goto case 304;
				case 264:
					array2[8] = 110;
					num2 = 329;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 263:
					array[14] = (byte)num6;
					num2 = 79;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 59;
				case 59:
					num5 = 163;
					goto case 306;
				case 260:
					num6 = 124;
					goto case 263;
				case 257:
					num8 = 140;
					num2 = 389;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 254:
					array[18] = (byte)num8;
					num2 = 358;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 252:
					num8 = 142;
					goto case 81;
				case 81:
					array[3] = (byte)num8;
					goto case 136;
				case 136:
					num6 = 87;
					goto case 400;
				case 251:
					array[14] = 120;
					num = 31;
					goto case 31;
				case 31:
					num6 = 147;
					goto case 40;
				case 40:
					array[14] = (byte)num6;
					num2 = 72;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 260;
				case 250:
					num5 = 98;
					num2 = 323;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 249:
					array[27] = 159;
					num2 = 257;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 247:
					array2[13] = 87;
					num2 = 312;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 244:
					array[12] = (byte)num6;
					num2 = 109;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 242:
					num6 = 79;
					num = 294;
					goto case 294;
				case 238:
					array3[3] = array4[1];
					goto case 72;
				case 72:
					array3[5] = array4[2];
					num2 = 359;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 236:
					num8 = 194;
					num2 = 13;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 219;
				case 219:
					array[10] = (byte)num8;
					goto case 410;
				case 235:
					array2[5] = (byte)num5;
					goto case 46;
				case 46:
					num5 = 102;
					num2 = 132;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 47;
				case 234:
					array[23] = 126;
					num = 58;
					goto case 58;
				case 58:
					array[23] = 127;
					num2 = 242;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto case 76;
				case 76:
					num8 = 154;
					num = 137;
					goto case 137;
				case 137:
					array[27] = (byte)num8;
					goto case 249;
				case 230:
					num8 = 157;
					num2 = 121;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 210;
				case 210:
					array[10] = (byte)num8;
					num = 347;
					goto case 347;
				case 222:
					dnMS7LsLiubl6a13ds(object_2, array6, 0, array6.Length);
					goto case 158;
				case 158:
					TrFk4tJ85gYnrRfefj(object_2);
					goto case 427;
				case 220:
					array[14] = 207;
					goto case 320;
				case 211:
					object_ = new VtNVUKGulysZw81C3E((Stream)lXkgVSwILylAsW3Oyh(x4Dk2IHVmX, "TobEC4hIgCxF0TwsAh.Xg5oMBsggOsrj5CWF8"));
					num2 = 298;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 153;
				case 208:
					array4 = (byte[])u7DAk3lDVkm2JCp36C(m6r2LGxi9aJfd9Wrbl(x4Dk2IHVmX));
					num2 = 127;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 207:
					num6 = 166;
					goto case 300;
				case 206:
					array[29] = (byte)num8;
					num2 = 86;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 4;
				case 205:
					num5 = 134;
					goto case 155;
				case 155:
					array2[11] = (byte)num5;
					goto case 387;
				case 201:
					array = new byte[32];
					goto case 273;
				case 199:
					num5 = 237;
					goto case 119;
				case 119:
					array2[6] = (byte)num5;
					num2 = 90;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 198:
					array[3] = (byte)num6;
					num2 = 2;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 13;
				case 13:
					num8 = 163;
					goto case 35;
				case 196:
					array[24] = 102;
					num = 336;
					goto case 336;
				case 195:
					array2[4] = (byte)num5;
					goto case 307;
				case 193:
					num8 = 110;
					goto case 254;
				case 189:
					array[6] = 148;
					num2 = 207;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 186:
					array2[15] = 96;
					num2 = 33;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 185:
					num5 = 88;
					goto case 343;
				case 183:
					array6 = HkLkNdDPtB;
					num2 = 426;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 178:
					array[25] = (byte)num8;
					num2 = 398;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 177:
					array[28] = (byte)num8;
					goto case 29;
				case 29:
					num8 = 55;
					num2 = 47;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 63;
				case 63:
					array[28] = (byte)num8;
					num = 124;
					goto case 124;
				case 124:
					array[29] = 159;
					num = 419;
					goto case 419;
				case 174:
					array2[15] = 163;
					num2 = 186;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 172:
					num8 = 120;
					goto case 319;
				case 170:
					array3[1] = array4[0];
					num2 = 238;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 167:
					array2[11] = (byte)num5;
					goto case 330;
				case 163:
					array[29] = (byte)num6;
					goto case 106;
				case 106:
					num8 = 131;
					num2 = 206;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 162:
					array2[5] = 221;
					goto case 429;
				case 149:
				case 159:
					num10 = 0;
					goto case 23;
				case 23:
				case 88:
					if (num10 >= array3.Length)
					{
						num = 354;
						goto case 354;
					}
					goto case 65;
				case 65:
					array5[num10] = (byte)(array5[num10] ^ array3[num10]);
					goto case 368;
				case 157:
					array[13] = (byte)num8;
					goto case 60;
				case 60:
					array[13] = 244;
					num2 = 220;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 156:
					num5 = 115;
					num = 195;
					goto case 195;
				case 154:
					array[9] = (byte)num6;
					num2 = 315;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 150:
					array3[15] = array4[7];
					goto case 149;
				case 146:
					array2[13] = 84;
					num2 = 127;
					if (OmBkQ93oSxysisBy5y() != null)
					{
						continue;
					}
					goto case 247;
				case 140:
					num8 = 89;
					goto case 130;
				case 130:
					array[18] = (byte)num8;
					num2 = 172;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 139:
					array2[9] = 48;
					goto case 102;
				case 102:
					array2[9] = 98;
					goto case 250;
				case 132:
					array2[5] = (byte)num5;
					num2 = 271;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 128:
					array2[10] = (byte)num5;
					goto case 205;
				case 127:
					if (array4 == null)
					{
						num = 159;
						goto case 149;
					}
					goto case 93;
				case 93:
					if (array4.Length > 0)
					{
						goto case 170;
					}
					goto case 149;
				case 123:
					array[2] = (byte)num6;
					num2 = 56;
					if (!VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 62;
				case 62:
					num6 = 83;
					num = 334;
					goto case 334;
				case 117:
					num8 = 185;
					goto case 377;
				case 113:
					num6 = 99;
					num2 = 123;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 111:
					num8 = 106;
					num2 = 83;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 109:
					array[12] = 180;
					goto case 229;
				case 103:
					num8 = 74;
					goto case 157;
				case 101:
					num9 <<= 8;
					num = 346;
					goto case 346;
				case 96:
					array2[6] = (byte)num5;
					goto case 331;
				case 90:
					num5 = 156;
					num = 96;
					goto case 96;
				case 86:
					num6 = 154;
					goto case 394;
				case 83:
					array[21] = (byte)num8;
					num2 = 274;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 79:
					num8 = 86;
					num = 282;
					goto case 282;
				case 77:
					num8 = 189;
					goto case 21;
				case 21:
					array[9] = (byte)num8;
					num2 = 230;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto case 161;
				case 73:
					array3[11] = array4[5];
					goto case 8;
				case 8:
					array3[13] = array4[6];
					goto case 150;
				case 71:
					num5 = 120;
					goto case 302;
				case 57:
					num8 = 155;
					goto case 178;
				case 53:
					array2[0] = 18;
					goto case 321;
				case 43:
					array[25] = 154;
					goto case 272;
				case 39:
					num7++;
					goto case 99;
				case 33:
					array2[15] = 162;
					num = 59;
					goto case 59;
				case 25:
					array[25] = (byte)num6;
					num2 = 57;
					if (VSkvy6KOqcX7hy4yoF())
					{
						continue;
					}
					goto IL_010c;
				case 24:
					array[8] = 45;
					goto case 266;
				case 22:
					array[13] = 62;
					goto case 310;
				case 14:
					num6 = 69;
					num2 = 198;
					if (OmBkQ93oSxysisBy5y() == null)
					{
						continue;
					}
					goto IL_010c;
				case 2:
					num5 = 163;
					goto case 397;
				case 1:
					num5 = 119;
					num = 288;
					goto case 288;
				case 212:
					break;
				case 360:
					HkLkNdDPtB = array7;
					goto IL_2842;
				case 68:
					goto IL_2842;
				case 407:
					goto IL_284f;
				case 133:
					goto end_IL_282d;
				}
				break;
			}
			continue;
			IL_010c:
			num2 = num;
			goto IL_2157;
			IL_2842:
			int_ = VmgHenNQrjHDtkBqhR(HkLkNdDPtB, int_0);
			goto IL_284f;
			continue;
			end_IL_282d:
			break;
		}
		return "";
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string hg2oY5yaSM(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int FPvotekByE()
	{
		return 5;
	}

	private static void svloy6EVGc()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate iaKoOg5GGg(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777394)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777275)),
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(16777293))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object PvroikJllY(object object_0)
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

	private static IntPtr w3ZoqRBn5p(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (BV0kmUIPgx == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			BV0kmUIPgx = (MacgPI7JyVeAhNaPvd)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554458)));
		}
		return BV0kmUIPgx(intptr_0, string_0, uint_0);
	}

	private static IntPtr YDsoA9ylfU(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (yBRkv0eFeZ == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			yBRkv0eFeZ = (GL8NaIwq2KOvLQhMFX)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554459)));
		}
		return yBRkv0eFeZ(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int mTfoQqVbOE(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (tTVkFDSO7A == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			tTVkFDSO7A = (yy2w1VXOQgx806ubre)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554460)));
		}
		return tTVkFDSO7A(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int YeeoMqaS3J(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (zIOkYypt1M == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			zIOkYypt1M = (N7UlhA3IRW2ugh7tWg)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554461)));
		}
		return zIOkYypt1M(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr tdOo5aPwrv(uint uint_0, int int_0, uint uint_1)
	{
		if (tuYkt9D06I == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			tuYkt9D06I = (RI754BJF754hNSApRW)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554462)));
		}
		return tuYkt9D06I(uint_0, int_0, uint_1);
	}

	private static int Q2sob65b9D(IntPtr intptr_0)
	{
		if (etmkyDG2SG == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			etmkyDG2SG = (YLCGmBEaUwBbEqLM01)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554463)));
		}
		return etmkyDG2SG(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (K7PkOHxqAd == IntPtr.Zero)
		{
			K7PkOHxqAd = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return K7PkOHxqAd;
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] VZpoRI2LOR(string string_0)
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

	internal static Stream Njco6C1nc4()
	{
		return new MemoryStream();
	}

	internal static byte[] rLIoBbVVpm(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] oN9oGXMAK7(byte[] byte_0)
	{
		Stream stream = Njco6C1nc4();
		SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
		symmetricAlgorithm.Key = new byte[32]
		{
			118, 67, 31, 135, 7, 184, 91, 162, 189, 179,
			41, 245, 43, 213, 171, 79, 56, 19, 190, 197,
			15, 25, 135, 191, 120, 89, 131, 221, 55, 148,
			46, 86
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			48, 45, 126, 244, 43, 150, 163, 53, 137, 166,
			176, 201, 110, 66, 226, 141
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = rLIoBbVVpm(stream);
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		return result;
	}

	private byte[] JBbo7fndGL()
	{
		return null;
	}

	private byte[] tM1owh06yH()
	{
		return null;
	}

	private byte[] HpuoXD9KwB()
	{
		return null;
	}

	private byte[] vLyo3J8m2E()
	{
		return null;
	}

	private byte[] fnqoJe2xAG()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] IHuoEWDKCc()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] J6JoHkltLH()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] FtroUJNIfo()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] KIxoTLeGZr()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] S0yo9WrR0W()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object lXkgVSwILylAsW3Oyh(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object v9NRpbYclbs1msheIb(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void BbVQwB9IAR87wq1gAX(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long S0nk5gtOZauJTDr7nW(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object KwXsXILnYT41U9plHC(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void Ep8t8qW3IZakIkoq7L(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void bNWpfSBNtBwd5N73E5(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object m6r2LGxi9aJfd9Wrbl(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object u7DAk3lDVkm2JCp36C(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object cLJaiHhCdXwXtRjq23()
	{
		return PEXoCqmS4w();
	}

	internal static void i4j142q6uBmtdQ5mLA(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object PGWIiHb9ViHkZ8Asvw(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object WYCHWd6rXG4ADJKpNx()
	{
		return Njco6C1nc4();
	}

	internal static void dnMS7LsLiubl6a13ds(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void TrFk4tJ85gYnrRfefj(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object R3CkYYmL0RGTEaInQB(object object_0)
	{
		return rLIoBbVVpm((Stream)object_0);
	}

	internal static void LhfE587EYIDF6pDy2C(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int VmgHenNQrjHDtkBqhR(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void kbTkCZQ96RjLhmXcRR()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
	}

	internal static object QlUoev1pGNFQC4k2mV()
	{
		return Encoding.Unicode;
	}

	internal static object lqAje1r4lislC4DxXs(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool VSkvy6KOqcX7hy4yoF()
	{
		return (object)null == null;
	}

	internal static object OmBkQ93oSxysisBy5y()
	{
		return null;
	}

	internal static void II4mbg8DI7HcBFm1bf()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
	}

	internal static void sZNERSiV2XFxGCIxuo(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type JtnmN8tYQJeNqfcVqt(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object c2UTnFNIs0BonkjSDm(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int S7AvrlRnL3oEbvTxnV(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object otroNqYfktPuUxqtPs()
	{
		return SHA1.Create();
	}

	internal static object b9i2hP1yFCFA0mkXRU(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool M9asCGJsxO6UEWZN5N(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object PwucW8jrQnqwO9nksv(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object WXOeb5wHIamrsOQSBc(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void VymkpwXddOWY529qU7(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long KZTrtCf53NZXL4PTtk(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object zsgogFH9IX0aLEDDm9(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static object kw9XV0snA9GhG2xASw()
	{
		return PEXoCqmS4w();
	}

	internal static void WBS940x28268jF0EVq(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object kjuQwEe5PVurcPZKMQ(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object HFrmJl2Alwc9Te6y4t()
	{
		return Njco6C1nc4();
	}

	internal static void aBGsYJukCtknOBPdhe(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void Ehl5ahyGm25yJdTcn9(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object bC8IdekKvqYj6IlgON()
	{
		return Encoding.UTF8;
	}

	internal static object E323IrFBAerYfQ7ORP(object object_0)
	{
		return rLIoBbVVpm((Stream)object_0);
	}

	internal static object cwgZ22rDsSHcxkecNY(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void Gy5MrBqpDgNC07UXTq(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void cOXRIv0aQQDp1vG7i5(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void AV0fJeBwnY4WbR45iL(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void g3L1ud53dmLm0QRsAZ(object object_0, object object_1, uint uint_0, object object_2)
	{
		vBuojdip3i((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort iN4Rm6COI9q7SRLyMl(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int PejaI79GYOY8UhfnPZ(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void lTpnE0bAsXkTddG4aT(object object_0, object object_1, int int_0, int int_1)
	{
		NSmolmd79S((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long AXOUZwIZuxUBMWZHh0(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint JXE4C9cJpC9DrLXLf5(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint YvMOwapfr8H4AmrJhD(uint uint_0, int int_0, long long_0, object object_0)
	{
		return SDQoufkqT0(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long F9hfLPEXa6TTj6vidY(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object kZ8j1kOIjc9JP5JyjS(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object AlAGlwWX8fLEnOikJT(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void x7GgNxdQoFBb9qdlHj(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object GYvrQMS8pKiMfMlh1c(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool bj15SVKnAylKJmoLma(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object xyEln2lHnNyCvSd1Of(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object nW1uWt45ylgAA4v2Tb(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object npZFOvQXD5kPgI2P4g(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool MjUpQTUAyyOAp6C2gO()
	{
		return (object)null == null;
	}

	internal static object Q8X6PuAZ66pEnQWCMg()
	{
		return null;
	}
}
