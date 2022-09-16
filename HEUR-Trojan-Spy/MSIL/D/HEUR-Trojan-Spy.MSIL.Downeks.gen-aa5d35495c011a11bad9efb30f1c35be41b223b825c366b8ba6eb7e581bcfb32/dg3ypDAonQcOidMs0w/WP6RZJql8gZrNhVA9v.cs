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
			internal static object oZ64y03hESau1AbE3nT;

			static iGR41459RDH4FvPdNk()
			{
				prXoP4RuYp();
				iXLoKRSpAw();
			}

			internal static bool HPTowE3M2mIkJ0Hv7Kp()
			{
				return true;
			}

			internal static object xhxguF3CtxnNYNGsPDe()
			{
				return null;
			}
		}

		[RJDcsuMfOxrTCYImPe(typeof(iGR41459RDH4FvPdNk<object>[]))]
		public RJDcsuMfOxrTCYImPe(object object_0)
		{
		}

		static RJDcsuMfOxrTCYImPe()
		{
			prXoP4RuYp();
		}
	}

	internal class qcBC7nbplYPB6DW0yw
	{
		[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
		internal static string G9skPDgcXb(string string_0, string string_1)
		{
			return null;
		}

		internal static object sEtxRm3D3i3QyQlCDZW()
		{
			return null;
		}

		internal static void kDtmxY38w4oqBNXXdBL(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static object fhJrnV395NWoYpJjlZV()
		{
			return null;
		}

		internal static void r3y3fq3XmjBo1gXVOIm(object object_0, object object_1)
		{
		}

		internal static void wsf5LU3zIRSchONpSIs(object object_0, object object_1)
		{
		}

		internal static object Xawy3Ortr6vNWKiKy7W(object object_0)
		{
			return null;
		}

		static qcBC7nbplYPB6DW0yw()
		{
			prXoP4RuYp();
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
			return (byte[])lIZnyFrpKCinoCrkccf(KPVkbuTpLj, int_0);
		}

		internal int hx5kqNgSj4(byte[] byte_0, int int_0, int int_1)
		{
			return ioVpJSrViTxk0u7l08Q(KPVkbuTpLj, byte_0, int_0, int_1);
		}

		internal int TVtkAMaqpL()
		{
			return KPVkbuTpLj.ReadInt32();
		}

		internal void VDqkQKyKML()
		{
			n8BknarkYqp3ZXCfxqo(KPVkbuTpLj);
		}

		internal static object lIZnyFrpKCinoCrkccf(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int ioVpJSrViTxk0u7l08Q(object object_0, object object_1, int int_0, int int_1)
		{
			return ((BinaryReader)object_0).Read((byte[])object_1, int_0, int_1);
		}

		internal static void n8BknarkYqp3ZXCfxqo(object object_0)
		{
			((BinaryReader)object_0).Close();
		}

		static VtNVUKGulysZw81C3E()
		{
			prXoP4RuYp();
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

	private static IntPtr VE2k4S5okQ;

	private static MacgPI7JyVeAhNaPvd BV0kmUIPgx;

	private static byte[] OObkplyC7t;

	private static bool V9fkgxQPQA;

	internal static QZEOeHRUkDiNqCWT0p abxkLGOVrU;

	private static SortedList VM5kd0GoFG;

	private static YLCGmBEaUwBbEqLM01 etmkyDG2SG;

	private static Dictionary<int, int> Tqek0lIh21;

	internal static RSACryptoServiceProvider onZkkIlVOi;

	private static bool xo4kuDarJK;

	private static IntPtr aatkD4ZSGk;

	internal static Assembly x4Dk2IHVmX;

	private static IntPtr wcyk8nIyBt;

	private static int wpoklx4RIX;

	private static bool MrkkWebIMK;

	private static object emjkxI4Yxp;

	private static IntPtr K7PkOHxqAd;

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static bool firstrundone;

	private static bool LrEkS2eXQL;

	private static int XtMknffM5M;

	private static bool fMAkKtNIoA;

	private static yy2w1VXOQgx806ubre tTVkFDSO7A;

	private static long eXJkjmTXDX;

	private static N7UlhA3IRW2ugh7tWg zIOkYypt1M;

	private static RI754BJF754hNSApRW tuYkt9D06I;

	private static object WaKkhokJrA;

	internal static QZEOeHRUkDiNqCWT0p rNZkehfwNu;

	private static GL8NaIwq2KOvLQhMFX yBRkv0eFeZ;

	private static int Qy5kfBXtEh;

	private static bool PRZkZqsNsa;

	private static byte[] HkLkNdDPtB;

	private static byte[] s6pkoGoeab;

	private static uint[] O1BkIDx0L0;

	private static int CgSk1JZr60;

	private static long URnkCOceLK;

	internal static Hashtable lmdkVksVkh;

	private static int[] zl0ksqgIH1;

	static WP6RZJql8gZrNhVA9v()
	{
		PRZkZqsNsa = false;
		x4Dk2IHVmX = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554776)).Assembly;
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

	private void GGmrIWXA6QCSl()
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

	private static void TAOohhiP7R(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_0)[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static void zDKosecjaB(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_0)[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static void ubAof6RgCm(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_0)[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
	}

	private static void YpJoWsPi7X(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_0)[uint_4] + O1BkIDx0L0[uint_5 - 1], ushort_0);
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
		int num = 17;
		string text = default(string);
		HashAlgorithm object_ = default(HashAlgorithm);
		string object_2 = default(string);
		int num4 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		byte[] array = default(byte[]);
		int num10 = default(int);
		byte[] array2 = default(byte[]);
		byte[] object_7 = default(byte[]);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		CryptoStream object_4 = default(CryptoStream);
		byte[] array3 = default(byte[]);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] object_6 = default(byte[]);
		int num8 = default(int);
		int num12 = default(int);
		byte[] array5 = default(byte[]);
		uint num15 = default(uint);
		BinaryReader object_8 = default(BinaryReader);
		int num14 = default(int);
		uint num25 = default(uint);
		long num26 = default(long);
		long num19 = default(long);
		long num20 = default(long);
		uint num27 = default(uint);
		uint num16 = default(uint);
		int num22 = default(int);
		int num21 = default(int);
		long long_ = default(long);
		long num17 = default(long);
		bool flag2 = default(bool);
		int int_ = default(int);
		uint uint_ = default(uint);
		uint num24 = default(uint);
		uint uint_2 = default(uint);
		uint num18 = default(uint);
		byte[] array4 = default(byte[]);
		int num29 = default(int);
		bool flag = default(bool);
		while (onZkkIlVOi == null)
		{
			while (true)
			{
				U3R0AScN5p14agq05q();
				int num2 = 3;
				if (ByYnFlE65NobiPVPQJ() != null)
				{
					goto IL_0039;
				}
				goto IL_007e;
				IL_007e:
				while (true)
				{
					switch (num2)
					{
					case 11:
						if (LVGNNHXgnlAJYvJs8u(text) == 0)
						{
							num2 = 10;
							if (kobHEIPiIZXVigBAMG())
							{
								continue;
							}
							goto IL_0039;
						}
						object_ = null;
						goto case 5;
					case 5:
						object_2 = null;
						num2 = 14;
						if (kobHEIPiIZXVigBAMG())
						{
							continue;
						}
						goto IL_0039;
					case 9:
						text = (string)VyujoIlvB5tDGHO0tM(zjfn7ExcaaydOuS7YL(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly);
						goto case 6;
					case 6:
						if (text == null)
						{
							num2 = 7;
							if (ByYnFlE65NobiPVPQJ() != null)
							{
								continue;
							}
							return;
						}
						goto case 11;
					case 4:
						onZkkIlVOi = new RSACryptoServiceProvider();
						goto case 9;
					case 3:
						xXDsxFS9SM0YVnGtRM(bool_0: true);
						goto case 4;
					case 1:
						break;
					case 17:
						goto end_IL_00d4;
					case 8:
					case 10:
						return;
					case 14:
						try
						{
							object_ = (HashAlgorithm)C5fBEinsF6sLcOfL43();
							while (true)
							{
								object_2 = (string)HDyJ579oNjfMWZ0kRA("SHA1");
								int num3 = 1;
								if (ByYnFlE65NobiPVPQJ() != null)
								{
									num3 = num4;
								}
								switch (num3)
								{
								case 2:
									break;
								default:
									goto end_IL_0101;
								case 1:
									if (!c9qdalpsjkpJd5savH(text))
									{
										num4 = 3;
										return;
									}
									goto end_IL_0101;
								case 0:
									goto end_IL_0101;
								case 3:
									return;
								}
								continue;
								end_IL_0101:
								break;
							}
						}
						catch
						{
							int num5 = 0;
							if (ByYnFlE65NobiPVPQJ() != null)
							{
								num5 = num6;
							}
							switch (num5)
							{
							}
							return;
						}
						goto default;
					default:
						flag = false;
						num = 13;
						goto case 13;
					case 13:
						try
						{
							VtNVUKGulysZw81C3E object_3 = new VtNVUKGulysZw81C3E((Stream)gJKWaldlUOcgg8Hx0N(x4Dk2IHVmX, "mOSgiOWQle13siEtij.84I6oYCCuHp318tcAv"));
							int num7 = 78;
							if (!kobHEIPiIZXVigBAMG())
							{
								goto IL_01d4;
							}
							goto IL_1ec6;
							IL_1ec6:
							while (true)
							{
								switch (num7)
								{
								case 351:
									num9 = 146;
									goto case 173;
								case 173:
									array[19] = (byte)num9;
									goto case 102;
								case 102:
									num9 = 106;
									num7 = 118;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 350:
									num9 = 135;
									num7 = 109;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 26;
								case 26:
									array[3] = (byte)num9;
									goto case 217;
								case 217:
									num9 = 176;
									goto case 20;
								case 20:
									array[4] = (byte)num9;
									goto case 94;
								case 94:
									array[4] = 214;
									goto case 203;
								case 203:
									num9 = 114;
									num7 = 267;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 349:
									array[7] = (byte)num9;
									num7 = 31;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 348:
									num9 = 217;
									goto case 26;
								case 347:
									array[12] = (byte)num9;
									num8 = 125;
									goto case 125;
								case 125:
									array[12] = 124;
									goto case 335;
								case 335:
									num9 = 126;
									goto case 228;
								case 228:
									array[13] = (byte)num9;
									num8 = 318;
									goto case 318;
								case 318:
									array[13] = 168;
									goto case 322;
								case 322:
									num9 = 189;
									goto case 253;
								case 253:
									array[13] = (byte)num9;
									goto case 127;
								case 127:
									array[13] = 168;
									num7 = 163;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 346:
									array[9] = (byte)num9;
									goto case 316;
								case 316:
									array[9] = 136;
									goto case 270;
								case 270:
									array[10] = 128;
									num7 = 88;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 119;
								case 119:
									array[10] = 90;
									num7 = 218;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 345:
									num10 = 67;
									goto case 248;
								case 248:
									array2[9] = (byte)num10;
									num7 = 19;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 21;
								case 21:
									array2[9] = 131;
									goto case 80;
								case 80:
									num10 = 196;
									num7 = 280;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 344:
									num10 = 161;
									num7 = 303;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 41;
								case 41:
									array[20] = (byte)num9;
									goto case 55;
								case 55:
									num9 = 127;
									goto case 333;
								case 333:
									array[20] = (byte)num9;
									num7 = 341;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 343:
									num9 = 32;
									goto case 247;
								case 247:
									array[8] = (byte)num9;
									num7 = 64;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 64;
								case 64:
									array[9] = 59;
									num7 = 106;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 342:
									array[11] = 139;
									num7 = 134;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 76;
								case 76:
									array[14] = (byte)num9;
									goto case 60;
								case 60:
									array[14] = 146;
									goto case 292;
								case 292:
									array[14] = 142;
									num7 = 313;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 341:
									array[20] = 69;
									num7 = 27;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 339:
									num10 = 250;
									num7 = 323;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 338:
									array[22] = 181;
									goto case 205;
								case 205:
									num9 = 128;
									goto case 196;
								case 196:
									array[23] = (byte)num9;
									num7 = 166;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 337:
									num9 = 144;
									goto case 136;
								case 136:
									array[11] = (byte)num9;
									num7 = 243;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 243;
								case 243:
									num9 = 32;
									num7 = 226;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 336:
									array2 = new byte[16];
									num7 = 235;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 334:
									array[0] = (byte)num9;
									goto case 37;
								case 37:
									array[1] = 100;
									goto case 164;
								case 164:
									num9 = 201;
									num7 = 65;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 75;
								case 75:
									array[1] = (byte)num9;
									num7 = 117;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 332:
									array2[11] = 126;
									num7 = 264;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 331:
									array[28] = 17;
									goto case 272;
								case 272:
									array[28] = 20;
									num8 = 128;
									goto case 128;
								case 128:
									array[29] = 52;
									num8 = 319;
									goto case 319;
								case 319:
									num9 = 124;
									num8 = 307;
									goto case 307;
								case 307:
									array[29] = (byte)num9;
									num7 = 72;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 330:
									array2[6] = (byte)num10;
									num7 = 230;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 329:
									array2[0] = 250;
									goto case 183;
								case 183:
									num10 = 50;
									num7 = 43;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 66;
								case 66:
									array2[1] = (byte)num10;
									goto case 326;
								case 326:
									num10 = 144;
									goto case 73;
								case 73:
									array2[1] = (byte)num10;
									num7 = 129;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 328:
									num10 = 90;
									goto case 17;
								case 17:
									array2[1] = (byte)num10;
									num7 = 184;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 120;
								case 120:
									array[3] = 140;
									goto case 114;
								case 114:
									num9 = 110;
									num7 = 186;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 327:
									array[6] = 94;
									num7 = 53;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 325:
									array[0] = 156;
									num7 = 289;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 324:
									num9 = 33;
									goto case 277;
								case 277:
									array[27] = (byte)num9;
									goto case 161;
								case 161:
									num9 = 183;
									goto case 309;
								case 309:
									array[28] = (byte)num9;
									goto case 240;
								case 240:
									array[28] = 103;
									goto case 9;
								case 9:
									array[28] = 124;
									num8 = 99;
									goto case 99;
								case 99:
									array[28] = 198;
									num8 = 331;
									goto case 331;
								case 323:
									array2[8] = (byte)num10;
									num7 = 62;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 321:
									num9 = 78;
									num7 = 24;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 198;
								case 198:
									array[12] = (byte)num9;
									num7 = 9;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 82;
								case 82:
									num9 = 121;
									goto case 96;
								case 96:
									array[12] = (byte)num9;
									goto case 273;
								case 273:
									num9 = 147;
									num8 = 79;
									goto case 79;
								case 79:
									array[12] = (byte)num9;
									num7 = 137;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 18;
								case 18:
									array[8] = (byte)num9;
									num7 = 343;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 338;
								case 320:
									array2[2] = 164;
									num7 = 1;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 1;
								case 1:
									array2[2] = 79;
									num7 = 221;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 317:
									array2[15] = 201;
									goto case 63;
								case 63:
									object_7 = array2;
									goto case 266;
								case 266:
									object_5 = (SymmetricAlgorithm)nPdWyOwmbxeSHRQitl();
									num7 = 84;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 315:
									array[21] = 59;
									goto case 40;
								case 40:
									array[22] = 153;
									num7 = 172;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 314:
									num9 = 55;
									num8 = 239;
									goto case 239;
								case 239:
									array[21] = (byte)num9;
									num8 = 315;
									goto case 315;
								case 313:
									num9 = 138;
									num8 = 42;
									goto case 42;
								case 42:
									array[14] = (byte)num9;
									goto case 275;
								case 275:
									array[14] = 39;
									num8 = 209;
									goto case 209;
								case 209:
									num9 = 96;
									goto case 170;
								case 170:
									array[15] = (byte)num9;
									goto case 312;
								case 312:
									num9 = 174;
									num7 = 215;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 311:
									array[31] = (byte)num9;
									num7 = 32;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 46;
								case 46:
									array[31] = 85;
									num7 = 131;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 310:
									num9 = 22;
									goto case 105;
								case 105:
									array[30] = (byte)num9;
									goto case 90;
								case 90:
									array[30] = 102;
									num8 = 241;
									goto case 241;
								case 241:
									num9 = 43;
									goto case 192;
								case 192:
									array[30] = (byte)num9;
									num7 = 274;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 43;
								case 43:
									array2[14] = (byte)num10;
									num8 = 286;
									goto case 286;
								case 286:
									array2[14] = 88;
									num7 = 155;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 308:
									array[27] = (byte)num9;
									goto case 324;
								case 306:
									num9 = 147;
									goto case 122;
								case 122:
									array[17] = (byte)num9;
									goto case 50;
								case 50:
									array[17] = 168;
									num8 = 124;
									goto case 124;
								case 124:
									num9 = 146;
									goto case 219;
								case 219:
									array[18] = (byte)num9;
									goto case 111;
								case 111:
									array[18] = 160;
									goto case 107;
								case 107:
									array[18] = 34;
									num8 = 158;
									goto case 158;
								case 158:
									num9 = 166;
									num7 = 258;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 305:
									array[4] = (byte)num9;
									num7 = 244;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 104;
								case 104:
									array[25] = (byte)num9;
									num7 = 232;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 304:
									array[13] = (byte)num9;
									num7 = 108;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 303:
									array2[7] = (byte)num10;
									goto case 200;
								case 200:
									array2[7] = 218;
									goto case 227;
								case 227:
									num10 = 49;
									num7 = 71;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 71;
								case 71:
									array2[8] = (byte)num10;
									num7 = 87;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 302:
									array2[0] = (byte)num10;
									goto case 259;
								case 259:
									num10 = 86;
									num7 = 116;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 54;
								case 54:
									array[8] = 86;
									goto case 143;
								case 143:
									array[8] = 110;
									goto case 154;
								case 154:
									num9 = 205;
									goto case 126;
								case 126:
									array[8] = (byte)num9;
									goto case 271;
								case 271:
									num9 = 112;
									num8 = 18;
									goto case 18;
								case 301:
									array[6] = (byte)num9;
									num7 = 5;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 300:
									array = new byte[32];
									num7 = 197;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 299:
									array2[4] = (byte)num10;
									num8 = 252;
									goto case 252;
								case 252:
									array2[5] = 167;
									num7 = 9;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 13;
								case 13:
									array2[5] = 139;
									num8 = 257;
									goto case 257;
								case 257:
									array2[5] = 159;
									goto case 208;
								case 208:
									num10 = 95;
									num7 = 207;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 298:
									array[26] = (byte)num9;
									goto case 92;
								case 92:
									num9 = 116;
									goto case 98;
								case 98:
									array[27] = (byte)num9;
									goto case 23;
								case 23:
									num9 = 94;
									num7 = 206;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 167;
								case 167:
									num10 = 98;
									num7 = 22;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 297:
									array2[7] = (byte)num10;
									goto case 344;
								case 296:
									num9 = 151;
									num7 = 148;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 295:
									array2[10] = 254;
									num7 = 130;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 294:
									array[0] = (byte)num9;
									num7 = 262;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 325;
								case 293:
									array[21] = 157;
									goto case 121;
								case 121:
									num9 = 116;
									num7 = 97;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 5;
								case 5:
									array[6] = 142;
									goto case 290;
								case 290:
									array[6] = 228;
									goto case 152;
								case 152:
									num9 = 93;
									num7 = 222;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 349;
								case 291:
									array[20] = (byte)num9;
									goto case 174;
								case 174:
									num9 = 130;
									num7 = 249;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 289:
									num9 = 114;
									goto case 238;
								case 238:
									array[0] = (byte)num9;
									num8 = 350;
									goto case 350;
								case 288:
									num9 = 173;
									goto case 123;
								case 123:
									array[26] = (byte)num9;
									goto case 162;
								case 162:
									num9 = 138;
									num7 = 298;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 287:
									num9 = 160;
									num7 = 191;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 23;
								case 285:
									array[24] = (byte)num9;
									goto case 93;
								case 93:
									array[24] = 246;
									num8 = 45;
									goto case 45;
								case 45:
									num9 = 116;
									num7 = 104;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 284:
									array[22] = 186;
									goto case 229;
								case 229:
									num9 = 125;
									goto case 180;
								case 180:
									array[22] = (byte)num9;
									num7 = 338;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 283:
									array2[10] = 172;
									goto case 295;
								case 282:
									num10 = 207;
									num7 = 149;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 106;
								case 106:
									array[9] = 214;
									num8 = 16;
									goto case 16;
								case 16:
									array[9] = 113;
									goto case 234;
								case 234:
									array[9] = 117;
									goto case 212;
								case 212:
									num9 = 94;
									num8 = 346;
									goto case 346;
								case 281:
									num10 = 131;
									goto case 103;
								case 103:
									array2[12] = (byte)num10;
									num7 = 261;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 280:
									array2[10] = (byte)num10;
									num7 = 175;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 74;
								case 74:
									array2[13] = 156;
									goto case 153;
								case 153:
									array2[13] = 7;
									goto case 68;
								case 68:
									num10 = 167;
									goto case 43;
								case 279:
									array[1] = 118;
									num8 = 251;
									goto case 251;
								case 251:
									array[1] = 168;
									num7 = 7;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 278:
									num9 = 47;
									goto case 268;
								case 268:
									array[5] = (byte)num9;
									goto case 67;
								case 67:
									array[5] = 150;
									goto case 269;
								case 269:
									num9 = 65;
									goto case 187;
								case 187:
									array[5] = (byte)num9;
									num8 = 11;
									goto case 11;
								case 11:
									num9 = 123;
									goto case 81;
								case 81:
									array[5] = (byte)num9;
									goto case 19;
								case 19:
									array[5] = 211;
									goto case 88;
								case 88:
									num9 = 191;
									goto case 245;
								case 245:
									array[6] = (byte)num9;
									goto case 327;
								case 276:
									num10 = 107;
									goto case 145;
								case 145:
									array2[3] = (byte)num10;
									num8 = 132;
									goto case 132;
								case 132:
									array2[3] = 156;
									goto case 2;
								case 2:
									array2[3] = 249;
									num7 = 263;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 274:
									num9 = 67;
									goto case 10;
								case 10:
									array[30] = (byte)num9;
									goto case 39;
								case 39:
									array[30] = 33;
									num7 = 220;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 212;
								case 267:
									array[4] = (byte)num9;
									num7 = 256;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 98;
								case 265:
									array[26] = (byte)num9;
									num8 = 288;
									goto case 288;
								case 264:
									num10 = 77;
									num7 = 159;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 18;
								case 263:
									array2[4] = 137;
									goto case 167;
								case 262:
									num10 = 193;
									num8 = 112;
									goto case 112;
								case 112:
									array2[15] = (byte)num10;
									goto case 29;
								case 29:
									num10 = 144;
									num7 = 44;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 26;
								case 261:
									array2[13] = 14;
									num7 = 74;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 260:
									num9 = 206;
									goto case 304;
								case 258:
									array[19] = (byte)num9;
									goto case 351;
								case 256:
									num9 = 128;
									num7 = 305;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 277;
								case 255:
									array[17] = 151;
									num7 = 146;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 254:
									num10 = 178;
									goto case 302;
								case 250:
									array2[4] = (byte)num10;
									goto case 176;
								case 176:
									num10 = 95;
									goto case 299;
								case 249:
									array[20] = (byte)num9;
									goto case 52;
								case 52:
									num9 = 143;
									goto case 41;
								case 246:
									num10 = 140;
									goto case 14;
								case 14:
									array2[12] = (byte)num10;
									num7 = 65;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 244:
									num9 = 65;
									goto case 177;
								case 177:
									array[4] = (byte)num9;
									goto case 278;
								case 242:
									array2[8] = 127;
									goto case 213;
								case 213:
									num10 = 128;
									goto case 142;
								case 142:
									array2[8] = (byte)num10;
									goto case 339;
								case 237:
									num9 = 158;
									goto case 265;
								case 236:
									array2[6] = 117;
									goto case 282;
								case 235:
									num10 = 106;
									goto case 216;
								case 216:
									array2[0] = (byte)num10;
									num7 = 254;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 233:
									eZb7tk0sAdYNxFjfXJ(object_4, array3, 0, array3.Length);
									num7 = 231;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 232:
									array[25] = 126;
									num7 = 223;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 231:
									TS8A3JUf3fgXeX5rpj(object_4);
									num8 = 178;
									goto case 178;
								case 178:
									rd3kHxL4vMRVvM36Q1(onZkkIlVOi, uUrcRJ2qi0KKFx1OIg(a0vpHrsy62XKwPpZP6(), xgh6ieqxAFiRN4oYQt(stream)));
									num7 = 85;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 6;
								case 6:
									array[19] = (byte)num9;
									goto case 139;
								case 139:
									num9 = 88;
									num8 = 35;
									goto case 35;
								case 35:
									array[20] = (byte)num9;
									num8 = 195;
									goto case 195;
								case 195:
									num9 = 117;
									num8 = 291;
									goto case 291;
								case 230:
									num10 = 186;
									goto case 28;
								case 28:
									array2[7] = (byte)num10;
									num8 = 12;
									goto case 12;
								case 12:
									array2[7] = 84;
									num7 = 86;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 226:
									array[11] = (byte)num9;
									num8 = 321;
									goto case 321;
								case 225:
									num10 = 126;
									num7 = 34;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 16;
								case 224:
									array2[12] = (byte)num10;
									num7 = 60;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 246;
								case 223:
									array[25] = 156;
									num7 = 237;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 49;
								case 49:
									array2[11] = 208;
									num7 = 147;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 222:
									array2[2] = (byte)num10;
									goto case 276;
								case 221:
									num10 = 232;
									goto case 222;
								case 220:
									num9 = 153;
									goto case 169;
								case 169:
									array[31] = (byte)num9;
									num7 = 33;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 218:
									array[10] = 173;
									num7 = 342;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 215:
									array[15] = (byte)num9;
									num7 = 81;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 138;
								case 138:
									num9 = 89;
									num8 = 189;
									goto case 189;
								case 189:
									array[15] = (byte)num9;
									goto case 168;
								case 168:
									array[16] = 82;
									num7 = 185;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 214:
									array[16] = (byte)num9;
									goto case 157;
								case 157:
									array[16] = 170;
									goto case 8;
								case 8:
									num9 = 18;
									num8 = 179;
									goto case 179;
								case 179:
									array[16] = (byte)num9;
									goto case 156;
								case 156:
									array[17] = 114;
									num7 = 255;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 254;
								case 211:
									array2[15] = (byte)num10;
									num7 = 225;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 210:
									array[7] = 96;
									num7 = 54;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 40;
								case 207:
									array2[5] = (byte)num10;
									num7 = 202;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 206:
									array[27] = (byte)num9;
									goto case 193;
								case 193:
									num9 = 88;
									num8 = 308;
									goto case 308;
								case 204:
									array[2] = 117;
									num7 = 181;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 152;
								case 202:
									array2[5] = 247;
									goto case 100;
								case 100:
									array2[6] = 175;
									goto case 182;
								case 182:
									array2[6] = 90;
									goto case 236;
								case 201:
									num9 = 121;
									num7 = 76;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 199:
									array[24] = 165;
									goto case 165;
								case 165:
									array[24] = 59;
									goto case 194;
								case 194:
									array[24] = 162;
									goto case 25;
								case 25:
									num9 = 145;
									num7 = 285;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 284;
								case 197:
									num9 = 89;
									goto case 294;
								case 191:
									array[7] = (byte)num9;
									num8 = 70;
									goto case 70;
								case 70:
									array[7] = 111;
									num7 = 210;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 114;
								case 190:
									array2[10] = (byte)num10;
									goto case 51;
								case 51:
									array2[10] = 138;
									goto case 283;
								case 188:
									num10 = 104;
									goto case 144;
								case 144:
									array2[6] = (byte)num10;
									num7 = 59;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 186:
									array[3] = (byte)num9;
									goto case 77;
								case 77:
									num9 = 69;
									goto case 115;
								case 115:
									array[3] = (byte)num9;
									num7 = 348;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 185:
									num9 = 132;
									num8 = 214;
									goto case 214;
								case 184:
									array2[1] = 181;
									goto case 101;
								case 101:
									num10 = 29;
									num7 = 83;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 181:
									array[2] = 179;
									num7 = 74;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 120;
								case 175:
									num10 = 166;
									goto case 38;
								case 38:
									array2[10] = (byte)num10;
									num8 = 15;
									goto case 15;
								case 15:
									num10 = 150;
									num8 = 190;
									goto case 190;
								case 172:
									array[22] = 108;
									goto case 151;
								case 151:
									array[22] = 91;
									num7 = 284;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 171:
									num9 = 67;
									num7 = 0;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto default;
								default:
									array[23] = (byte)num9;
									num7 = 140;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 166:
									num9 = 26;
									num7 = 32;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 163:
									num9 = 162;
									num7 = 141;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 160:
									num10 = 91;
									goto case 211;
								case 159:
									array2[11] = (byte)num10;
									goto case 49;
								case 155:
									array2[14] = 36;
									goto case 160;
								case 150:
									array2[8] = (byte)num10;
									goto case 242;
								case 149:
									array2[6] = (byte)num10;
									num7 = 188;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 148:
									array[21] = (byte)num9;
									num7 = 45;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 293;
								case 147:
									num10 = 94;
									goto case 224;
								case 146:
									array[17] = 58;
									num7 = 56;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 141:
									array[13] = (byte)num9;
									goto case 260;
								case 140:
									num9 = 170;
									num8 = 110;
									goto case 110;
								case 110:
									array[24] = (byte)num9;
									num8 = 199;
									goto case 199;
								case 137:
									num9 = 101;
									goto case 347;
								case 135:
									transform = (ICryptoTransform)DyQMVb1g4ktxlqiAO8(object_5, object_6, object_7);
									goto case 30;
								case 30:
									stream = (Stream)txBmn8o7qyLHi9UYCa();
									goto case 91;
								case 91:
									object_4 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
									goto case 233;
								case 134:
									array[11] = 166;
									num7 = 337;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 133:
									num10 = 135;
									num7 = 50;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 250;
								case 131:
									object_6 = array;
									goto case 336;
								case 130:
									num10 = 160;
									goto case 95;
								case 95:
									array2[11] = (byte)num10;
									num7 = 332;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 129:
									array2[1] = 168;
									num7 = 328;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 118:
									array[19] = (byte)num9;
									num7 = 3;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 117:
									num9 = 161;
									num7 = 89;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 116:
									array2[0] = (byte)num10;
									goto case 113;
								case 113:
									array2[0] = 132;
									num7 = 329;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 154;
								case 109:
									array[0] = (byte)num9;
									goto case 47;
								case 47:
									num9 = 20;
									num7 = 334;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 108:
									array[14] = 143;
									goto case 201;
								case 97:
									array[21] = (byte)num9;
									goto case 314;
								case 89:
									array[1] = (byte)num9;
									goto case 279;
								case 87:
									num10 = 86;
									goto case 150;
								case 86:
									array2[7] = 106;
									num7 = 36;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 48;
								case 48:
									num10 = 168;
									goto case 297;
								case 85:
									ESa1uOCqPxPSpDfp0Q(stream);
									num7 = 24;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 84:
									mBY8UD8DupWi4KMPFW(object_5, CipherMode.CBC);
									goto case 135;
								case 83:
									array2[1] = (byte)num10;
									goto case 36;
								case 36:
									array2[2] = 166;
									goto case 320;
								case 78:
									WvECgBKvUhfaqQRX4Y(S4tsBsO38TPdIonf3q(object_3), 0L);
									goto case 58;
								case 58:
									array3 = (byte[])XGm7HYb4aExEg8WLFH(object_3, (int)R6ILBgmiqhltZcRG0D(S4tsBsO38TPdIonf3q(object_3)));
									num7 = 300;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 72:
									array[29] = 82;
									goto case 310;
								case 65:
									array2[12] = 198;
									goto case 281;
								case 62:
									array2[9] = 160;
									num7 = 345;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 61:
									num9 = 133;
									num7 = 301;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 59:
									num10 = 105;
									num7 = 330;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 247;
								case 57:
									array[2] = 86;
									num7 = 204;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 56:
									array[17] = 174;
									num7 = 144;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 306;
								case 53:
									array[6] = 172;
									num7 = 61;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 44:
									array2[15] = (byte)num10;
									goto case 317;
								case 34:
									array2[15] = (byte)num10;
									goto case 262;
								case 33:
									num9 = 104;
									num7 = 178;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 311;
								case 32:
									array[23] = (byte)num9;
									goto case 171;
								case 31:
									array[7] = 92;
									goto case 287;
								case 27:
									array[21] = 115;
									num7 = 296;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 22:
									array2[4] = (byte)num10;
									goto case 133;
								case 7:
									array[1] = 23;
									num7 = 4;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 4:
									array[2] = 160;
									num7 = 57;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 3:
									num9 = 166;
									num7 = 6;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 24:
									ESa1uOCqPxPSpDfp0Q(object_4);
									goto case 69;
								case 69:
									iJwSKbr5JMmNE62FbS(object_3);
									num8 = 340;
									goto end_IL_1ec6;
								case 340:
									goto end_IL_1ec6;
								}
								goto IL_01d4;
								continue;
								end_IL_1ec6:
								break;
							}
							goto end_IL_017f;
							IL_01d4:
							num7 = num8;
							goto IL_1ec6;
							end_IL_017f:;
						}
						catch
						{
							int num11 = 0;
							if (kobHEIPiIZXVigBAMG())
							{
								goto IL_2479;
							}
							goto IL_2496;
							IL_2479:
							while (true)
							{
								switch (num11)
								{
								case 1:
									goto end_IL_2479;
								}
								flag = true;
								num11 = 1;
								if (kobHEIPiIZXVigBAMG())
								{
									continue;
								}
								goto IL_2496;
								continue;
								end_IL_2479:
								break;
							}
							goto end_IL_2469;
							IL_2496:
							num11 = num12;
							goto IL_2479;
							end_IL_2469:;
						}
						goto case 18;
					case 18:
						if (!flag)
						{
							goto case 15;
						}
						goto case 2;
					case 15:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num13 = 37;
							if (!kobHEIPiIZXVigBAMG())
							{
								goto IL_24e6;
							}
							goto IL_2a0c;
							IL_2a0c:
							while (true)
							{
								int num23;
								switch (num13)
								{
								case 74:
									array5[64] = 0;
									goto case 8;
								case 8:
									array5[65] = 0;
									goto case 66;
								case 66:
									array5[66] = 0;
									num13 = 54;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 73:
									num15 = hKYjxNTg9j17hS7gvj(object_8);
									num14 = 33;
									goto case 33;
								case 33:
									num25 = hKYjxNTg9j17hS7gvj(object_8);
									goto case 4;
								case 4:
									WvECgBKvUhfaqQRX4Y(fileStream, num25);
									goto case 16;
								case 29:
									num26 = PkRTq7VP8HLuIIkruO(fileStream);
									goto case 26;
								case 26:
									if (num19 <= num26)
									{
										goto case 21;
									}
									goto case 11;
								case 21:
									if (num26 >= num20)
									{
										num13 = 11;
										if (kobHEIPiIZXVigBAMG())
										{
											continue;
										}
										break;
									}
									goto case 6;
								case 6:
									num27 = (uint)(num20 - num26);
									num14 = 5;
									goto case 5;
								case 5:
									if (num27 < num15)
									{
										goto case 62;
									}
									num13 = 33;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 39;
								case 62:
									num15 -= num27;
									goto case 46;
								case 46:
									WvECgBKvUhfaqQRX4Y(fileStream, PkRTq7VP8HLuIIkruO(fileStream) + num27);
									goto case 16;
								case 16:
								case 60:
								case 65:
									if (num15 == 0)
									{
										num13 = 48;
										if (kobHEIPiIZXVigBAMG())
										{
											continue;
										}
										break;
									}
									goto case 29;
								case 11:
								case 40:
								case 72:
									if (num26 >= num20)
									{
										num14 = 59;
										goto case 59;
									}
									goto case 3;
								case 59:
									tYC2pcHsxDW9JtLJrP(object_, fileStream, num15, array5);
									num13 = 39;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 3:
									num16 = (uint)gdo1I2iXrHmXptB0Ji(num19 - num26, num15);
									num13 = 53;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 39:
								case 44:
								case 48:
									num22++;
									num13 = 38;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 20;
								case 20:
									tYC2pcHsxDW9JtLJrP(object_, fileStream, (uint)(num21 * 40), array5);
									goto case 47;
								case 47:
									long_ = PkRTq7VP8HLuIIkruO(fileStream);
									num13 = 51;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 71:
									array5[33] = 0;
									num14 = 2;
									goto case 2;
								case 2:
									array5[34] = 0;
									goto case 67;
								case 67:
									array5[35] = 0;
									goto case 7;
								case 7:
									array5[36] = 0;
									goto case 28;
								case 28:
									array5[37] = 0;
									num13 = 13;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 38:
								case 70:
									if (num22 >= num21)
									{
										goto case 17;
									}
									goto case 61;
								case 17:
									GArV0cYTX2sNxyqwpg(object_, new byte[0], 0, 0);
									num14 = 64;
									goto case 64;
								case 64:
									WvECgBKvUhfaqQRX4Y(fileStream, num19);
									num13 = 18;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 61:
									WvECgBKvUhfaqQRX4Y(fileStream, num17 + num22 * 40 + 16L);
									goto case 73;
								case 69:
									num17 = PkRTq7VP8HLuIIkruO(fileStream);
									num13 = 0;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 68:
									array5 = new byte[65536];
									num13 = 37;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 45;
								case 45:
									tYC2pcHsxDW9JtLJrP(object_, fileStream, 152u, array5);
									goto case 10;
								case 10:
									flag2 = qlSGsk7olr4S02ncMM(object_8) != 523;
									num13 = 20;
									if (ByYnFlE65NobiPVPQJ() != null)
									{
										continue;
									}
									goto case 27;
								case 27:
									if (flag2)
									{
										goto case 42;
									}
									goto case 35;
								case 42:
									num23 = 96;
									goto IL_2748;
								case 35:
									num23 = 112;
									goto IL_2748;
								case 41:
									WvECgBKvUhfaqQRX4Y(fileStream, 152L);
									goto case 15;
								case 15:
									J6WtLPDbkdD7EauqDu(fileStream, array5, 0, int_);
									num13 = 74;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 14;
								case 14:
								case 43:
									uint_ = hKYjxNTg9j17hS7gvj(object_8);
									goto case 30;
								case 30:
									num24 = Jo3jC8AUZJBXe4OFgF(uint_, num21, num17, object_8);
									goto case 50;
								case 50:
									WvECgBKvUhfaqQRX4Y(fileStream, num24 + 32);
									goto case 23;
								case 23:
									uint_2 = hKYjxNTg9j17hS7gvj(object_8);
									goto case 58;
								case 58:
									num18 = hKYjxNTg9j17hS7gvj(object_8);
									num13 = 55;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 56;
								case 56:
									num19 = Jo3jC8AUZJBXe4OFgF(uint_2, num21, num17, object_8);
									num13 = 19;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 63:
									WvECgBKvUhfaqQRX4Y(fileStream, long_);
									goto case 55;
								case 55:
									num22 = 0;
									goto case 38;
								case 57:
									Hx4XFpNvFOARpYmpjT(array4);
									num14 = 32;
									goto case 32;
								case 32:
									flag = !lrDB2i48UZpu2iiXXd(onZkkIlVOi, Cw6SR2tKBW2kngbNER(object_), object_2, array4);
									num13 = 36;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									goto case 22;
								case 22:
									J6WtLPDbkdD7EauqDu(fileStream, array5, 0, 128);
									num13 = 1;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 24;
								case 24:
									array5[32] = 0;
									num13 = 71;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 32;
								case 54:
									array5[67] = 0;
									num13 = 25;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 53:
									tYC2pcHsxDW9JtLJrP(object_, fileStream, num16, array5);
									num13 = 1;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 52:
									num21 = qlSGsk7olr4S02ncMM(object_8);
									num13 = 9;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 51:
									if (flag2)
									{
										num13 = 34;
										if (ByYnFlE65NobiPVPQJ() == null)
										{
											continue;
										}
										goto case 13;
									}
									goto case 31;
								case 13:
									array5[38] = 0;
									goto case 12;
								case 12:
									array5[39] = 0;
									num13 = 49;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 31:
									WvECgBKvUhfaqQRX4Y(fileStream, 376L);
									num13 = 43;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 49:
									xOJt5eZEiViNc1g6Wf(object_, array5, 0, 128);
									goto case 69;
								case 37:
									object_8 = new BinaryReader(fileStream);
									goto case 68;
								case 34:
									WvECgBKvUhfaqQRX4Y(fileStream, 360L);
									num13 = 14;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								case 25:
									xOJt5eZEiViNc1g6Wf(object_, array5, 0, int_);
									goto case 22;
								case 19:
									num20 = num19 + num18;
									num13 = 63;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 61;
								case 18:
									array4 = (byte[])H8DN1dkCgBpAUbMoSK(object_8, (int)num18);
									num13 = 57;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 4;
								case 9:
									WvECgBKvUhfaqQRX4Y(fileStream, num17);
									num13 = 20;
									if (kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									break;
								case 1:
									num15 -= num16;
									num13 = 16;
									if (ByYnFlE65NobiPVPQJ() == null)
									{
										continue;
									}
									break;
								default:
									WvECgBKvUhfaqQRX4Y(fileStream, 134L);
									num14 = 52;
									goto case 52;
								case 36:
									goto end_IL_2a0c;
									IL_2748:
									int_ = num23;
									num13 = 4;
									if (!kobHEIPiIZXVigBAMG())
									{
										continue;
									}
									goto case 41;
								}
								goto IL_24e6;
								continue;
								end_IL_2a0c:
								break;
							}
							goto end_IL_24a6;
							IL_24e6:
							num13 = num14;
							goto IL_2a0c;
							end_IL_24a6:;
						}
						catch
						{
							int num28 = 0;
							if (ByYnFlE65NobiPVPQJ() == null)
							{
								goto IL_2b54;
							}
							goto IL_2b71;
							IL_2b54:
							while (true)
							{
								switch (num28)
								{
								case 1:
									goto end_IL_2b54;
								}
								flag = true;
								num28 = 1;
								if (kobHEIPiIZXVigBAMG())
								{
									continue;
								}
								goto IL_2b71;
								continue;
								end_IL_2b54:
								break;
							}
							goto end_IL_2b44;
							IL_2b71:
							num28 = num29;
							goto IL_2b54;
							end_IL_2b44:;
						}
						goto case 2;
					case 2:
						if (!flag)
						{
							flag = false;
							return;
						}
						goto case 12;
					case 12:
						throw new Exception((string?)sGL8ciMIgj2DnbVYSA(LFEtXXjKDqLtVqHXpA(FvOBjtGCBFpMpCvLr4(zjfn7ExcaaydOuS7YL(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)), " is tampered."));
					case 7:
					case 16:
						return;
					}
					break;
				}
				continue;
				IL_0039:
				num2 = num;
				goto IL_007e;
				continue;
				end_IL_00d4:
				break;
			}
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
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554776)).Assembly.GetManifestResourceStream("WcxonFOkHZtiBiQL1C.eTkRLWub8HEyYPvAGU"));
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
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554776)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(16777238));
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

	private static uint EObomOjAWk(uint uint_0)
	{
		return 0u;
	}

	internal static void w65ov7siki()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string L3hoFlcqP6(int int_0)
	{
		int num = 107;
		int num3 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		int num24 = default(int);
		byte[] array3 = default(byte[]);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		int num7 = default(int);
		int num6 = default(int);
		int num4 = default(int);
		byte[] array5 = default(byte[]);
		int num10 = default(int);
		uint num11 = default(uint);
		int num5 = default(int);
		uint num12 = default(uint);
		byte[] array4 = default(byte[]);
		int num17 = default(int);
		int num19 = default(int);
		uint num18 = default(uint);
		uint num16 = default(uint);
		int num23 = default(int);
		uint num13 = default(uint);
		uint num9 = default(uint);
		CryptoStream object_2 = default(CryptoStream);
		Stream stream = default(Stream);
		uint num20 = default(uint);
		uint num8 = default(uint);
		int num15 = default(int);
		int num14 = default(int);
		int int_ = default(int);
		int num26 = default(int);
		string result = default(string);
		while (true)
		{
			if (HkLkNdDPtB.Length == 0)
			{
				while (true)
				{
					VtNVUKGulysZw81C3E object_ = new VtNVUKGulysZw81C3E((Stream)MDXWIeGBOXN1PNYiCV(x4Dk2IHVmX, "l9ZuEVrMfO5lMWTM34.llv3296vqd8j17pRMk"));
					while (true)
					{
						jPg4YX28MwH6uoGxy0(zVGoRW7dNkI7sCIFru(object_), 0L);
						while (true)
						{
							byte[] array = (byte[])ny7BmZrVtO1glaTqk8(object_, (int)sNv9HKHvu5PGur7Kls(zVGoRW7dNkI7sCIFru(object_)));
							while (true)
							{
								eTWX3683DENf0TaFGL(object_);
								while (true)
								{
									byte[] array2 = new byte[32];
									int num2 = 101;
									if (!w63tP7kVx6Tq9hnOgo())
									{
										goto IL_0047;
									}
									goto IL_20c6;
									IL_20c6:
									while (true)
									{
										switch (num2)
										{
										case 418:
											array2[15] = 91;
											goto case 393;
										case 393:
											num3 = 95;
											num = 76;
											goto case 76;
										case 76:
											array2[15] = (byte)num3;
											num2 = 0;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 417:
											array6[8] = 129;
											num2 = 210;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 388:
											array7[num24] = (byte)(array7[num24] ^ array3[num24]);
											goto case 201;
										case 201:
											num24++;
											goto case 45;
										case 45:
										case 416:
											if (num24 < array3.Length)
											{
												goto case 388;
											}
											goto case 109;
										case 109:
											if (int_0 == -1)
											{
												goto case 386;
											}
											goto case 395;
										case 386:
											object_3 = (SymmetricAlgorithm)AjqJaP5CRHWZLiyGSi();
											num2 = 158;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 183;
										case 183:
											Cqsprnu5XRYKurdkY8(object_3, CipherMode.CBC);
											goto case 225;
										case 225:
											transform = (ICryptoTransform)uMjeoRyRwgRR1XPOnl(object_3, array7, array3);
											num2 = 157;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 395:
											num7 = array.Length % 4;
											goto case 185;
										case 185:
											num6 = array.Length / 4;
											num2 = 46;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 415:
											array2[8] = (byte)num3;
											goto case 371;
										case 371:
											array2[9] = 160;
											num2 = 167;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 414:
											array2[20] = (byte)num3;
											goto case 42;
										case 42:
											array2[20] = 114;
											num2 = 230;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 118;
										case 118:
											num4 = 9;
											goto case 64;
										case 64:
											array6[12] = (byte)num4;
											goto case 355;
										case 355:
											num4 = 164;
											num2 = 173;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 413:
											array5[num10 + 3] = (byte)((num11 & 0xFF000000u) >> 24);
											goto case 233;
										case 233:
										case 406:
											num5++;
											num2 = 236;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 151;
										case 151:
											array6[2] = (byte)num4;
											num2 = 398;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 412:
											array6[3] = (byte)num4;
											num2 = 372;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 411:
											array6[6] = (byte)num4;
											goto case 195;
										case 195:
											num4 = 228;
											goto case 78;
										case 78:
											array6[6] = (byte)num4;
											goto case 307;
										case 307:
											array6[7] = 90;
											num2 = 6;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 349;
										case 349:
											array6[7] = 112;
											goto case 292;
										case 292:
											num4 = 117;
											goto case 320;
										case 320:
											array6[7] = (byte)num4;
											num2 = 108;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 410:
											num4 = 95;
											goto case 212;
										case 212:
											array6[1] = (byte)num4;
											goto case 120;
										case 120:
											num4 = 77;
											goto case 43;
										case 43:
											array6[1] = (byte)num4;
											num = 141;
											goto case 141;
										case 141:
											num4 = 149;
											num2 = 153;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 409:
											array2[26] = 51;
											num2 = 366;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 408:
											num3 = 162;
											num = 342;
											goto case 342;
										case 342:
											array2[18] = (byte)num3;
											num = 284;
											goto case 284;
										case 284:
											array2[18] = 88;
											goto case 134;
										case 134:
											num3 = 30;
											goto case 381;
										case 381:
											array2[18] = (byte)num3;
											goto case 99;
										case 99:
											num3 = 124;
											num2 = 250;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 407:
											array5[num10 + 2] = (byte)((num11 & 0xFF0000) >> 16);
											goto case 413;
										case 405:
											num12 = (uint)num10;
											num2 = 200;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 105;
										case 105:
											num5 = 0;
											num2 = 258;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 404:
											array4 = (byte[])fpXrv3J6cgXdrWlebT(OiORVCChbIN0u3JNBD(x4Dk2IHVmX));
											num2 = 203;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 403:
											array2[2] = 162;
											num2 = 264;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 402:
											array2[9] = (byte)num3;
											goto case 89;
										case 89:
											array2[10] = 107;
											num2 = 305;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 401:
											array2[30] = (byte)num3;
											num2 = 146;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 251;
										case 251:
											num3 = 73;
											goto case 324;
										case 324:
											array2[30] = (byte)num3;
											goto case 273;
										case 273:
											array2[31] = 90;
											goto case 288;
										case 288:
											array2[31] = 75;
											num = 47;
											goto case 47;
										case 47:
											num3 = 155;
											goto case 135;
										case 135:
											array2[31] = (byte)num3;
											goto case 196;
										case 196:
											array2[31] = 84;
											num2 = 98;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 374;
										case 374:
											array2[31] = 122;
											num2 = 70;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 400:
											array2[1] = (byte)num3;
											num = 327;
											goto case 327;
										case 327:
											num3 = 100;
											goto case 81;
										case 81:
											array2[1] = (byte)num3;
											num2 = 144;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 399:
											array6[8] = (byte)num4;
											goto case 10;
										case 10:
											array6[8] = 99;
											num2 = 417;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 188;
										case 188:
											num3 = 122;
											num2 = 215;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 402;
										case 398:
											num4 = 74;
											goto case 6;
										case 6:
											array6[2] = (byte)num4;
											goto case 113;
										case 113:
											array6[2] = 3;
											goto case 396;
										case 396:
											array6[3] = 160;
											goto case 137;
										case 137:
											array6[3] = 199;
											num2 = 266;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 397:
											array6[4] = (byte)num4;
											goto case 184;
										case 184:
											num4 = 92;
											goto case 100;
										case 100:
											array6[4] = (byte)num4;
											num2 = 96;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 394:
											array6[13] = (byte)num4;
											goto case 293;
										case 293:
											num4 = 126;
											num2 = 333;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 392:
											array2[23] = (byte)num3;
											num2 = 159;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 391:
											array3[7] = array4[3];
											num2 = 191;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 390:
											num4 = 144;
											num2 = 397;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 131;
										case 131:
											array3[5] = array4[2];
											num2 = 391;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 389:
											array2[12] = 110;
											goto case 187;
										case 187:
											array2[12] = 173;
											goto case 156;
										case 156:
											num3 = 124;
											goto case 208;
										case 208:
											array2[13] = (byte)num3;
											num2 = 53;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 387:
											num4 = 126;
											num = 21;
											goto case 21;
										case 21:
											array6[5] = (byte)num4;
											goto case 186;
										case 186:
											num4 = 158;
											goto case 277;
										case 277:
											array6[5] = (byte)num4;
											goto case 311;
										case 311:
											num4 = 180;
											num2 = 180;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 385:
											array6[12] = 90;
											num2 = 312;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 384:
											array2[0] = 162;
											goto case 121;
										case 121:
											num3 = 118;
											goto case 354;
										case 354:
											array2[0] = (byte)num3;
											num2 = 306;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 383:
											array6[13] = 59;
											goto case 328;
										case 328:
											num4 = 186;
											num2 = 394;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 382:
											num24 = 0;
											num2 = 416;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 380:
											array2[15] = 115;
											num2 = 340;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 379:
											num3 = 138;
											goto case 318;
										case 318:
											array2[22] = (byte)num3;
											goto case 352;
										case 352:
											array2[23] = 138;
											num2 = 116;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 227;
										case 227:
											num3 = 92;
											num2 = 392;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 378:
											array2[6] = (byte)num3;
											goto case 357;
										case 357:
											array2[6] = 132;
											goto case 245;
										case 245:
											array2[6] = 137;
											num2 = 171;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 377:
											array2[2] = (byte)num3;
											num2 = 403;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 376:
											array6[0] = 112;
											num = 9;
											goto case 9;
										case 9:
											num4 = 162;
											num2 = 48;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 45;
										case 375:
											array6[10] = 117;
											goto case 98;
										case 98:
											array6[11] = 161;
											goto case 259;
										case 259:
											array6[11] = 108;
											num2 = 75;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 56;
										case 56:
											num17 += 8;
											goto case 198;
										case 198:
											array5[num10 + num19] = (byte)((num18 & num16) >> num17);
											goto case 335;
										case 335:
											num19++;
											num2 = 270;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 373:
											array6[15] = 114;
											num2 = 32;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 372:
											array6[3] = 42;
											num = 119;
											goto case 119;
										case 119:
											array6[4] = 68;
											num2 = 254;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 33;
										case 33:
											array2[5] = 129;
											goto case 283;
										case 283:
											array2[5] = 152;
											num2 = 314;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 370:
											array3[1] = array4[0];
											goto case 297;
										case 297:
											array3[3] = array4[1];
											goto case 131;
										case 369:
											array2[9] = 151;
											num2 = 188;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 368:
											array2[27] = (byte)num3;
											num2 = 4;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 367:
											num3 = 137;
											num = 193;
											goto case 193;
										case 193:
											array2[2] = (byte)num3;
											num2 = 350;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 366:
											num3 = 157;
											goto case 368;
										case 365:
											array3 = array6;
											goto case 353;
										case 353:
											R2Dr8Ic4jBx2v37bKI(array3);
											num2 = 404;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 364:
											array2[5] = 168;
											num = 222;
											goto case 222;
										case 222:
											num3 = 100;
											num2 = 276;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 152;
										case 152:
											array2[17] = (byte)num3;
											goto case 243;
										case 243:
											num3 = 125;
											goto case 88;
										case 88:
											array2[17] = (byte)num3;
											goto case 308;
										case 308:
											array2[18] = 54;
											num2 = 41;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 363:
											num3 = 177;
											goto case 197;
										case 197:
											array2[7] = (byte)num3;
											goto case 59;
										case 59:
											num3 = 84;
											goto case 92;
										case 92:
											array2[7] = (byte)num3;
											goto case 24;
										case 24:
											array2[7] = 34;
											goto case 15;
										case 15:
											array2[8] = 116;
											num = 309;
											goto case 309;
										case 309:
											array2[8] = 93;
											goto case 7;
										case 7:
											array2[8] = 120;
											num2 = 219;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 362:
											array6 = new byte[16];
											num2 = 376;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 360:
											array2[26] = 132;
											num2 = 409;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 114;
										case 114:
											array2[19] = (byte)num3;
											num2 = 351;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 359:
											array2[4] = 68;
											goto case 18;
										case 18:
											array2[4] = 140;
											num2 = 122;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 358:
											num6++;
											goto case 116;
										case 116:
											num12 = 0u;
											num2 = 105;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 356:
											array2[5] = 158;
											goto case 364;
										case 351:
											num3 = 75;
											num2 = 414;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 350:
											array2[3] = 117;
											num2 = 315;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 348:
											num4 = 75;
											goto case 132;
										case 132:
											array6[9] = (byte)num4;
											goto case 179;
										case 179:
											num4 = 56;
											num2 = 58;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 17;
										case 17:
											num4 = 182;
											num2 = 326;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 347:
											array2[30] = 127;
											goto case 68;
										case 68:
											num3 = 140;
											num2 = 80;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 346:
											array2[14] = (byte)num3;
											num2 = 52;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 103;
										case 103:
											num3 = 74;
											num2 = 263;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 166;
										case 166:
										case 321:
											if (num23 >= num7)
											{
												num2 = 61;
												if (LfNok891yCdE9lbpIV() == null)
												{
													continue;
												}
												goto IL_0047;
											}
											goto case 115;
										case 115:
											if (num23 > 0)
											{
												goto case 317;
											}
											goto case 148;
										case 317:
											num13 <<= 8;
											num2 = 148;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 148:
											num13 |= array[^(1 + num23)];
											goto case 168;
										case 168:
											num23++;
											num2 = 166;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 345:
											array6[15] = (byte)num4;
											num2 = 365;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 344:
											array6[10] = 186;
											goto case 375;
										case 343:
											array6[3] = (byte)num4;
											num2 = 172;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 341:
											num3 = 145;
											num2 = 260;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 340:
											array2[16] = 117;
											num2 = 174;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 115;
										case 339:
											num13 = 0u;
											goto case 123;
										case 123:
											num8 += num9;
											goto case 310;
										case 310:
											num23 = 0;
											num2 = 321;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 338:
											object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
											goto case 3;
										case 3:
											MNlgdWEals6kHOFEHa(object_2, array, 0, array.Length);
											num2 = 72;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 337:
											num3 = 45;
											num2 = 63;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 43;
										case 334:
											num4 = 122;
											goto case 149;
										case 149:
											array6[1] = (byte)num4;
											num2 = 153;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 252;
										case 252:
											array6[1] = 114;
											goto case 138;
										case 138:
											array6[1] = 111;
											num2 = 410;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 333:
											array6[14] = (byte)num4;
											goto case 294;
										case 294:
											array6[14] = 91;
											goto case 71;
										case 71:
											array6[14] = 95;
											num = 140;
											goto case 140;
										case 140:
											num4 = 125;
											num2 = 127;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 139;
										case 139:
											array6[14] = (byte)num4;
											goto case 147;
										case 147:
											array6[14] = 176;
											goto case 77;
										case 77:
											array6[15] = 117;
											goto case 373;
										case 332:
											num3 = 59;
											num = 271;
											goto case 271;
										case 271:
											array2[24] = (byte)num3;
											num = 74;
											goto case 74;
										case 74:
											num3 = 127;
											goto case 44;
										case 44:
											array2[24] = (byte)num3;
											goto case 224;
										case 224:
											num3 = 47;
											num2 = 302;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 61:
										case 331:
											num20 = num8;
											goto case 244;
										case 244:
											num8 = 0u;
											goto case 205;
										case 205:
										{
											uint num21 = num20;
											uint num22 = num20;
											num22 ^= num22 << 7;
											num22 += 205125544;
											num22 ^= num22 >> 9;
											num22 += 1218856144;
											num22 ^= num22 << 5;
											num22 += 3206220699u;
											num22 = 1657819281 - num22;
											num20 = num21 + (uint)(double)num22;
											goto case 249;
										}
										case 249:
											num8 = num20;
											goto case 130;
										case 130:
											if (num5 == num6 - 1)
											{
												goto case 150;
											}
											goto case 262;
										case 150:
											if (num7 > 0)
											{
												num2 = 304;
												if (w63tP7kVx6Tq9hnOgo())
												{
													continue;
												}
												goto IL_0047;
											}
											goto case 262;
										case 262:
											num11 = num8 ^ num13;
											num2 = 154;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 330:
											array2[4] = 170;
											goto case 359;
										case 329:
											array6[10] = (byte)num4;
											goto case 344;
										case 326:
											array6[9] = (byte)num4;
											num2 = 54;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 125;
										case 125:
											num4 = 73;
											goto case 66;
										case 66:
											array6[9] = (byte)num4;
											goto case 348;
										case 325:
											array2[13] = (byte)num3;
											num2 = 14;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 301;
										case 301:
											num3 = 20;
											num2 = 161;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 151;
										case 323:
											array2[28] = (byte)num3;
											goto case 313;
										case 313:
											num3 = 138;
											goto case 221;
										case 221:
											array2[29] = (byte)num3;
											num2 = 57;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 34;
										case 34:
											array6[13] = 119;
											goto case 383;
										case 322:
											array6[12] = (byte)num4;
											goto case 118;
										case 319:
											array2[22] = 108;
											num2 = 379;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 315:
											array2[3] = 173;
											goto case 248;
										case 248:
											num3 = 165;
											goto case 206;
										case 206:
											array2[3] = (byte)num3;
											num2 = 278;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 314:
											num3 = 155;
											num2 = 176;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 312:
											array6[12] = 92;
											goto case 12;
										case 12:
											num4 = 123;
											goto case 322;
										case 306:
											num3 = 149;
											goto case 207;
										case 207:
											array2[0] = (byte)num3;
											num2 = 110;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 305:
											num3 = 89;
											num2 = 97;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 265;
										case 265:
											array2[10] = (byte)num3;
											goto case 211;
										case 211:
											num3 = 141;
											num = 199;
											goto case 199;
										case 199:
											array2[10] = (byte)num3;
											num2 = 23;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 9;
										case 304:
											num18 = num8 ^ num13;
											goto case 238;
										case 238:
											num19 = 0;
											goto case 270;
										case 270:
										case 291:
											if (num19 >= num7)
											{
												goto case 233;
											}
											goto case 295;
										case 295:
											if (num19 <= 0)
											{
												goto case 198;
											}
											goto case 181;
										case 181:
											num16 <<= 8;
											goto case 56;
										case 303:
											array6[1] = (byte)num4;
											num2 = 334;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 293;
										case 302:
											array2[24] = (byte)num3;
											num2 = 164;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 141;
										case 300:
											array2[24] = (byte)num3;
											goto case 332;
										case 299:
											num3 = 131;
											num = 133;
											goto case 133;
										case 133:
											array2[21] = (byte)num3;
											num = 275;
											goto case 275;
										case 275:
											num3 = 104;
											num = 38;
											goto case 38;
										case 38:
											array2[22] = (byte)num3;
											goto case 319;
										case 298:
											array2[26] = 207;
											goto case 360;
										case 296:
											num3 = 145;
											goto case 216;
										case 216:
											array2[25] = (byte)num3;
											goto case 269;
										case 269:
											num3 = 136;
											goto case 214;
										case 214:
											array2[25] = (byte)num3;
											goto case 290;
										case 290:
											num3 = 154;
											num2 = 35;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 289:
											array2[1] = (byte)num3;
											num2 = 274;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 287:
											num9 = 0u;
											goto case 209;
										case 209:
											num13 = 0u;
											num2 = 237;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 286:
											array6[7] = (byte)num4;
											num2 = 241;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 285:
											num4 = 130;
											goto case 411;
										case 282:
											array2[3] = (byte)num3;
											goto case 29;
										case 29:
											num3 = 91;
											num2 = 36;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 281:
											pKQnjBZFKP88LDoK4X(stream);
											num2 = 175;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 280:
											num4 = 109;
											goto case 303;
										case 279:
											array6[15] = (byte)num4;
											goto case 240;
										case 240:
											num4 = 116;
											num2 = 211;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 345;
										case 278:
											array2[3] = 102;
											goto case 177;
										case 177:
											num3 = 139;
											goto case 282;
										case 276:
											array2[6] = (byte)num3;
											num = 128;
											goto case 128;
										case 128:
											num3 = 115;
											goto case 378;
										case 274:
											num3 = 201;
											num2 = 73;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 25;
										case 25:
											array2[14] = 142;
											num = 418;
											goto case 418;
										case 272:
											array2[17] = (byte)num3;
											goto case 242;
										case 242:
											num3 = 174;
											num2 = 152;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 54;
										case 54:
											if (array4.Length <= 0)
											{
												goto case 382;
											}
											goto case 370;
										case 268:
											array6[8] = (byte)num4;
											num = 69;
											goto case 69;
										case 69:
											array6[8] = 160;
											num2 = 102;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 267:
											num12 = (uint)(num15 * 4);
											num2 = 60;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 247;
										case 247:
											num9 = (uint)((array7[num12 + 3] << 24) | (array7[num12 + 2] << 16) | (array7[num12 + 1] << 8) | array7[num12]);
											num2 = 49;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 79;
										case 79:
											num16 = 255u;
											goto case 163;
										case 163:
											num17 = 0;
											num2 = 112;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 266:
											array6[3] = 116;
											goto case 155;
										case 155:
											num4 = 146;
											goto case 343;
										case 264:
											array2[2] = 134;
											goto case 367;
										case 263:
											array2[14] = (byte)num3;
											num2 = 231;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 261:
											num4 = 126;
											goto case 136;
										case 136:
											array6[6] = (byte)num4;
											num2 = 0;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 1;
										case 1:
											array6[6] = 68;
											num2 = 190;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 17;
										case 260:
											array2[18] = (byte)num3;
											goto case 408;
										case 236:
										case 258:
											if (num5 >= num6)
											{
												num2 = 256;
												if (w63tP7kVx6Tq9hnOgo())
												{
													continue;
												}
												goto IL_0047;
											}
											goto case 232;
										case 232:
											num15 = num5 % num14;
											goto case 213;
										case 213:
											num10 = num5 * 4;
											num2 = 267;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 257:
											num3 = 157;
											goto case 289;
										case 256:
											HkLkNdDPtB = array5;
											num2 = 162;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 255:
											array2[7] = (byte)num3;
											num2 = 87;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 254:
											array6[4] = 176;
											num2 = 390;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 253:
											num14 = array7.Length / 4;
											goto case 178;
										case 178:
											num8 = 0u;
											goto case 287;
										case 250:
											array2[19] = (byte)num3;
											goto case 13;
										case 13:
											num3 = 133;
											goto case 182;
										case 182:
											array2[19] = (byte)num3;
											num2 = 124;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 102;
										case 102:
											num4 = 247;
											goto case 204;
										case 204:
											array6[8] = (byte)num4;
											goto case 189;
										case 189:
											array6[9] = 59;
											goto case 17;
										case 246:
											array2[11] = 73;
											goto case 95;
										case 95:
											array2[12] = 94;
											goto case 39;
										case 39:
											array2[12] = 117;
											goto case 218;
										case 218:
											array2[12] = 110;
											goto case 389;
										case 241:
											array6[7] = 37;
											goto case 27;
										case 27:
											num4 = 93;
											num = 399;
											goto case 399;
										case 239:
											num3 = 149;
											num = 272;
											goto case 272;
										case 237:
											if (num7 > 0)
											{
												goto case 358;
											}
											goto case 116;
										case 235:
											array6[0] = 142;
											goto case 280;
										case 234:
											array3[15] = array4[7];
											goto case 382;
										case 231:
											array2[14] = 148;
											goto case 25;
										case 230:
											num3 = 42;
											num2 = 158;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 229:
											array5[num10 + 1] = (byte)((num11 & 0xFF00) >> 8);
											goto case 407;
										case 228:
											array2[4] = (byte)num3;
											num2 = 20;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 33;
										case 226:
											array2[19] = 104;
											goto case 83;
										case 83:
											num3 = 4;
											num2 = 112;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 114;
										case 223:
											array6[2] = (byte)num4;
											goto case 220;
										case 220:
											array6[2] = 162;
											goto case 52;
										case 52:
											num4 = 134;
											goto case 151;
										case 219:
											num3 = 102;
											goto case 165;
										case 165:
											array2[8] = (byte)num3;
											goto case 60;
										case 60:
											num3 = 83;
											num = 415;
											goto case 415;
										case 217:
											num3 = 222;
											goto case 300;
										case 210:
											num4 = 168;
											num2 = 268;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 203:
											if (array4 == null)
											{
												goto case 382;
											}
											goto case 54;
										case 202:
											array2[11] = (byte)num3;
											goto case 40;
										case 40:
											num3 = 140;
											goto case 50;
										case 50:
											array2[11] = (byte)num3;
											num2 = 246;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 200:
											num13 = (uint)((array[num12 + 3] << 24) | (array[num12 + 2] << 16) | (array[num12 + 1] << 8) | array[num12]);
											goto case 61;
										case 194:
											num4 = 181;
											num2 = 329;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 277;
										case 192:
											array2[4] = (byte)num3;
											num2 = 160;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 191:
											array3[9] = array4[4];
											goto case 129;
										case 129:
											array3[11] = array4[5];
											num2 = 5;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto default;
										default:
											array2[15] = 125;
											goto case 380;
										case 190:
											array6[6] = 152;
											goto case 285;
										case 180:
											array6[5] = (byte)num4;
											goto case 261;
										case 176:
											array2[5] = (byte)num3;
											num2 = 356;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 175:
											pKQnjBZFKP88LDoK4X(object_2);
											num2 = 146;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 174:
											num3 = 114;
											num2 = 84;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 54;
										case 173:
											array6[13] = (byte)num4;
											num = 34;
											goto case 34;
										case 172:
											num4 = 172;
											goto case 412;
										case 171:
											array2[6] = 66;
											num2 = 62;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 170:
											num3 = 107;
											goto case 22;
										case 22:
											array2[19] = (byte)num3;
											num2 = 226;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 169:
											array2[19] = (byte)num3;
											num2 = 170;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 167:
											array2[9] = 202;
											goto case 30;
										case 30:
											array2[9] = 97;
											goto case 369;
										case 164:
											array2[25] = 96;
											goto case 296;
										case 161:
											array2[13] = (byte)num3;
											num2 = 82;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 160:
											num3 = 82;
											num2 = 150;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 228;
										case 159:
											num3 = 92;
											num2 = 55;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 158:
											array2[20] = (byte)num3;
											goto case 127;
										case 127:
											num3 = 116;
											goto case 67;
										case 67:
											array2[21] = (byte)num3;
											num2 = 11;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 2;
										case 2:
											array2[27] = 16;
											num2 = 51;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 157:
											stream = (Stream)DxDItvlLl7457KOKgV();
											num2 = 338;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 154:
											array5[num10] = (byte)(num11 & 0xFFu);
											goto case 229;
										case 153:
											array6[2] = (byte)num4;
											num2 = 28;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 146:
											array = HkLkNdDPtB;
											goto case 395;
										case 145:
											array7 = array2;
											num2 = 81;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 362;
										case 144:
											array2[1] = 93;
											num = 257;
											goto case 257;
										case 143:
											num3 = 197;
											num2 = 125;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 323;
										case 142:
											array6[15] = (byte)num4;
											num2 = 91;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 124:
											num3 = 127;
											num2 = 169;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 122:
											num3 = 132;
											goto case 192;
										case 117:
											array2[28] = 189;
											goto case 111;
										case 111:
											array2[28] = 158;
											goto case 143;
										case 112:
											if (num5 == num6 - 1)
											{
												goto case 94;
											}
											goto case 49;
										case 94:
											if (num7 > 0)
											{
												num2 = 339;
												if (LfNok891yCdE9lbpIV() == null)
												{
													continue;
												}
												goto IL_0047;
											}
											goto case 49;
										case 49:
											num8 += num9;
											num2 = 405;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 110:
											num3 = 203;
											num2 = 92;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 97;
										case 97:
											array2[0] = (byte)num3;
											goto case 104;
										case 104:
											num3 = 114;
											goto case 400;
										case 108:
											num4 = 100;
											num2 = 150;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 286;
										case 101:
											array2[0] = 112;
											goto case 384;
										case 96:
											array6[5] = 170;
											goto case 387;
										case 93:
											num3 = 168;
											num = 401;
											goto case 401;
										case 91:
											num4 = 124;
											goto case 279;
										case 90:
											array2[14] = (byte)num3;
											num2 = 9;
											if (!w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 31;
										case 31:
											num3 = 59;
											num2 = 346;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 87:
											array2[7] = 80;
											goto case 86;
										case 86:
											num3 = 131;
											goto case 16;
										case 16:
											array2[7] = (byte)num3;
											goto case 363;
										case 85:
											num3 = 75;
											goto case 377;
										case 84:
											array2[16] = (byte)num3;
											num2 = 337;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 82:
											num3 = 164;
											goto case 90;
										case 80:
											array2[30] = (byte)num3;
											num2 = 93;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 75:
											array6[11] = 154;
											num2 = 385;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 73:
											array2[1] = (byte)num3;
											num2 = 85;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 72:
											OJ2J06ByOlPDdFUkbW(object_2);
											goto case 20;
										case 20:
											HkLkNdDPtB = (byte[])PxT7mOnNGbeDhSxAAq(stream);
											goto case 281;
										case 70:
											array2[31] = 121;
											goto case 145;
										case 65:
											array2[29] = 108;
											goto case 347;
										case 63:
											array2[16] = (byte)num3;
											num2 = 239;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 62:
											num3 = 146;
											num2 = 255;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto IL_0047;
										case 58:
											array6[9] = (byte)num4;
											goto case 194;
										case 57:
											num3 = 120;
											goto case 14;
										case 14:
											array2[29] = (byte)num3;
											goto case 65;
										case 55:
											array2[23] = (byte)num3;
											goto case 8;
										case 8:
											array2[23] = 108;
											num2 = 217;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 53:
											num3 = 139;
											num2 = 236;
											if (LfNok891yCdE9lbpIV() != null)
											{
												continue;
											}
											goto case 325;
										case 51:
											array2[28] = 100;
											goto case 37;
										case 37:
											array2[28] = 96;
											goto case 117;
										case 48:
											array6[0] = (byte)num4;
											goto case 235;
										case 46:
											array5 = new byte[array.Length];
											num2 = 253;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto case 31;
										case 41:
											array2[18] = 49;
											goto case 341;
										case 36:
											array2[3] = (byte)num3;
											goto case 330;
										case 35:
											array2[26] = (byte)num3;
											num2 = 298;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 32:
											num4 = 91;
											goto case 142;
										case 28:
											num4 = 75;
											goto case 223;
										case 23:
											num3 = 181;
											num2 = 202;
											if (w63tP7kVx6Tq9hnOgo())
											{
												continue;
											}
											goto case 130;
										case 11:
											array2[21] = 134;
											num2 = 299;
											if (LfNok891yCdE9lbpIV() == null)
											{
												continue;
											}
											goto IL_0047;
										case 5:
											array3[13] = array4[6];
											num = 234;
											goto case 234;
										case 4:
											array2[27] = 123;
											goto case 2;
										case 215:
											break;
										case 316:
											goto end_IL_275c;
										case 26:
											goto end_IL_277f;
										case 126:
											goto end_IL_2788;
										case 19:
											goto end_IL_27a0;
										case 107:
											goto end_IL_27b7;
										case 106:
										case 162:
											goto IL_27e1;
										case 336:
											goto IL_27ee;
										case 361:
											goto end_IL_27cf;
										}
										break;
									}
									continue;
									IL_0047:
									num2 = num;
									goto IL_20c6;
									continue;
									end_IL_275c:
									break;
								}
								continue;
								end_IL_277f:
								break;
							}
							continue;
							end_IL_2788:
							break;
						}
						continue;
						end_IL_27a0:
						break;
					}
					continue;
					end_IL_27b7:
					break;
				}
				continue;
			}
			num = 106;
			goto IL_27e1;
			IL_27e1:
			int_ = yigBbg1wPeGZ1ISTXI(HkLkNdDPtB, int_0);
			goto IL_27ee;
			IL_27ee:
			try
			{
				ia9WIdAxNQiRePWLhV();
				int num25 = 1;
				if (!w63tP7kVx6Tq9hnOgo())
				{
					num25 = num26;
				}
				do
				{
					switch (num25)
					{
					case 1:
						break;
					default:
						return result;
					case 0:
						return result;
					}
					result = (string)fRqnVobsq34mcxOkNZ(oegkoMWAuUMGobpT5g(), HkLkNdDPtB, int_0 + 4, int_);
					num25 = 0;
				}
				while (!w63tP7kVx6Tq9hnOgo());
				return result;
			}
			catch
			{
				if (LfNok891yCdE9lbpIV() == null)
				{
					switch (0)
					{
					}
				}
			}
			break;
			continue;
			end_IL_27cf:
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

	internal static uint NvQ34uZt895nxEhi2FIr(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_3, ref uint uint_1)
	{
		IntPtr ptr = intptr_2;
		if (PRZkZqsNsa)
		{
			ptr = intptr_1;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = lmdkVksVkh[num];
		if (obj != null)
		{
			BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m = (BIpvxRBRb2dOGl802m)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(bIpvxRBRb2dOGl802m.jsbkrdexts.Length);
			Marshal.Copy(bIpvxRBRb2dOGl802m.jsbkrdexts, 0, intPtr, bIpvxRBRb2dOGl802m.jsbkrdexts.Length);
			if (bIpvxRBRb2dOGl802m.JDNkifbo3S)
			{
				intptr_3 = intPtr;
				uint_1 = (uint)bIpvxRBRb2dOGl802m.jsbkrdexts.Length;
				YeeoMqaS3J(intptr_3, bIpvxRBRb2dOGl802m.jsbkrdexts.Length, 64, ref CgSk1JZr60);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, bIpvxRBRb2dOGl802m.jsbkrdexts.Length);
			uint result = 0u;
			if (uint_0 == 216669565 && !firstrundone)
			{
				firstrundone = true;
			}
			else
			{
				result = abxkLGOVrU(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
			}
			return result;
		}
		return abxkLGOVrU(intptr_0, intptr_1, intptr_2, uint_0, intptr_3, ref uint_1);
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
		return (Delegate)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(16777298)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(16777255)),
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(16777271))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal unsafe static void prXoP4RuYp()
	{
		//The blocks IL_2462, IL_2468, IL_248c, IL_2490, IL_24c6 are reachable both inside and outside the pinned region starting at IL_247d. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0009, IL_0013, IL_0019, IL_002f, IL_0ac5, IL_0acb, IL_0adc, IL_0ae4, IL_0aeb, IL_0af1, IL_0b01, IL_0b0a, IL_0b26, IL_0b45, IL_0b66, IL_0b7b, IL_0b91, IL_0b9f, IL_0ba5, IL_0bc8, IL_0bfd, IL_0c10, IL_0c19, IL_0c22, IL_0c43, IL_0c57, IL_0c5c, IL_0c72, IL_0c7e, IL_0c84, IL_0c9b, IL_0ca7, IL_0cc2, IL_0cda, IL_0cf8, IL_0d01, IL_0d18, IL_0d24, IL_0d30, IL_0d3f, IL_0d4e, IL_0d60, IL_0d6e, IL_0d7d, IL_0d89, IL_0d9e, IL_0dbf, IL_0dc8, IL_0dd6, IL_0de6, IL_0df2, IL_0e16, IL_0e1f, IL_0e3a, IL_0e50, IL_0e5e, IL_0e64, IL_0e72, IL_0e78, IL_0e86, IL_0e95, IL_0ea1, IL_0ead, IL_0ebc, IL_0ec2, IL_0ed0, IL_0edc, IL_0f00, IL_0f1b, IL_0f32, IL_0f40, IL_0f4b, IL_0f5f, IL_0f76, IL_0f8f, IL_0f9a, IL_0fb4, IL_0fcc, IL_0fcf, IL_0fd8, IL_0fe3, IL_1003, IL_101c, IL_1034, IL_1039, IL_104e, IL_1052, IL_106e, IL_1087, IL_10aa, IL_10b3, IL_10be, IL_10c9, IL_10d4, IL_10df, IL_10ea, IL_1109, IL_110f, IL_1132, IL_1140, IL_1156, IL_1175, IL_1193, IL_11b4, IL_11ef, IL_120a, IL_1229, IL_1248, IL_1254, IL_1272, IL_127b, IL_1289, IL_12a4, IL_12ab, IL_12b7, IL_12d5, IL_12f0, IL_12ff, IL_130e, IL_1329, IL_1347, IL_1357, IL_1520, IL_165f, IL_1744, IL_1759, IL_1770, IL_1791, IL_17ac, IL_17d0, IL_17d6, IL_17e4, IL_17f8, IL_180f, IL_181d, IL_1832, IL_1845, IL_184e, IL_1856, IL_1876, IL_187e, IL_188d, IL_1892, IL_189b, IL_18cb, IL_18d2, IL_18da, IL_18ed, IL_1909, IL_1915, IL_1939, IL_1964, IL_196a, IL_1978, IL_197e, IL_198c, IL_19a1, IL_19b0, IL_19c4, IL_19ca, IL_19d0, IL_19d6, IL_19dc, IL_19e2, IL_19ee, IL_1a11, IL_1a1d, IL_1a45, IL_1a62, IL_1a71, IL_1a80, IL_1a9b, IL_1aa1, IL_1ac4, IL_1aeb, IL_1b07, IL_1b10, IL_1b13, IL_1b1c, IL_1b34, IL_1b46, IL_1b61, IL_1b84, IL_1ba1, IL_1bc2, IL_1bde, IL_1bfd, IL_1c06, IL_1c29, IL_1c30, IL_1c39, IL_1c42, IL_1c47, IL_1c57, IL_1c70, IL_1c7c, IL_1c85, IL_1c8e, IL_1cb1, IL_1cb9, IL_1ce0, IL_1cf1, IL_1d25, IL_1d44, IL_1d60, IL_1d83, IL_1d97, IL_1daa, IL_1db3, IL_1dbc, IL_1dcc, IL_1df3, IL_1dfc, IL_1e10, IL_1e19, IL_1e3d, IL_1e6b, IL_1e77, IL_1e83, IL_1e92, IL_1eb6, IL_1ec1, IL_1ed9, IL_1ef4, IL_1f03, IL_1f0f, IL_1f15, IL_1f28, IL_1f46, IL_1f61, IL_1f6c, IL_1f85, IL_1f8b, IL_1f99, IL_1f9f, IL_1fc2, IL_1fd4, IL_1fdd, IL_1fe5, IL_1fec, IL_2004, IL_2013, IL_201c, IL_203f, IL_204b, IL_205a, IL_207e, IL_2097, IL_20a2, IL_20c5, IL_20e8, IL_20f1, IL_2108, IL_2123, IL_212f, IL_2138, IL_215b, IL_2169, IL_216f, IL_217d, IL_219e, IL_21bc, IL_21c9, IL_21e1, IL_21e7, IL_2203, IL_2222, IL_253c, IL_2565, IL_258e, IL_2594, IL_259a, IL_25b3, IL_25ba, IL_25c9, IL_25cf, IL_2603, IL_261a, IL_262d, IL_263d, IL_2661, IL_266c, IL_2687, IL_26a2, IL_26b9, IL_26c4, IL_26ec, IL_26ff, IL_270b, IL_271b, IL_2720, IL_2726, IL_2741, IL_276a, IL_277e, IL_278a, IL_2796, IL_27a2, IL_27ae, IL_27b7, IL_27c5, IL_27df, IL_2803, IL_2812, IL_2825, IL_2841, IL_2865, IL_2868, IL_286b, IL_2873, IL_2899, IL_28ba, IL_28c5, IL_28ce, IL_28dc, IL_28e8, IL_290c, IL_292c, IL_293b, IL_2947, IL_2965, IL_297b, IL_2981, IL_298c, IL_29af, IL_29cd, IL_29d3, IL_29ea, IL_29f3, IL_2a06, IL_2a0f, IL_2a30, IL_2a4f, IL_2a6a, IL_2a75, IL_2a86, IL_2a8b, IL_2a9c, IL_2aa2, IL_2aaa, IL_2aba, IL_2ad3, IL_2adc, IL_2aff, IL_2b08, IL_2b11, IL_2b1c, IL_2b27, IL_2b32, IL_2b36, IL_2b3f, IL_2b4f, IL_2b5b, IL_2b82, IL_2ba5, IL_2bab, IL_2bb9, IL_2bd7, IL_2be0, IL_2bee, IL_2c09, IL_2c17, IL_2c1e, IL_2c36, IL_2c3c, IL_2c42, IL_2c57, IL_2c70, IL_2c7c, IL_2c84, IL_2c99, IL_2cc7, IL_2cd5, IL_2ce4, IL_2d00, IL_2d06, IL_2d0f, IL_2d24, IL_2d42, IL_2d58, IL_2d7b, IL_2d8d, IL_2d9e, IL_2db2, IL_2dbd, IL_2de0, IL_2df7, IL_2e06, IL_2e0c, IL_2e1f, IL_2e2d, IL_2e4b, IL_2e4f, IL_2ec7, IL_2ecf, IL_2ed4, IL_2ee4, IL_2ef0, IL_2ef6, IL_2f09, IL_2f10, IL_2f33, IL_2f52, IL_2f73, IL_2f7c, IL_2f9a, IL_2fb6, IL_2fd8, IL_2feb, IL_2ff4, IL_2ffd, IL_300b, IL_302e, IL_304e, IL_3071, IL_3086, IL_30aa, IL_30b8, IL_30c4, IL_30d2, IL_30fe, IL_3111, IL_311d, IL_3123, IL_3131, IL_3140, IL_314c, IL_3166, IL_317c, IL_319f, IL_31c2, IL_31d6, IL_31e5, IL_31f0, IL_31fb, IL_3217, IL_3224, IL_322d, IL_33e3, IL_33f4, IL_3408, IL_3412, IL_3427, IL_3432, IL_343d, IL_3448, IL_3466, IL_3475, IL_3488, IL_3496, IL_34a5, IL_34bb, IL_34ce, IL_34d6, IL_3502, IL_3508, IL_3516, IL_3537, IL_3548, IL_3554, IL_3562, IL_3569, IL_358a, IL_35a2, IL_35ab, IL_35b1, IL_35cc, IL_35d8, IL_35ed, IL_3611, IL_3631, IL_3655, IL_3660, IL_3666, IL_3689, IL_36ac, IL_36c4, IL_36d0, IL_36eb, IL_36f4, IL_3704, IL_3710, IL_371c, IL_3728, IL_374c, IL_3770, IL_3773, IL_3780, IL_37a9, IL_37b0, IL_37b8, IL_37d9, IL_37e4, IL_37f5, IL_3815, IL_3829, IL_3835, IL_3846, IL_386a, IL_3882, IL_3895, IL_38ab, IL_38b3, IL_38c2, IL_38c8, IL_38e4, IL_38ee, IL_3909, IL_3918, IL_392b, IL_393f, IL_3950, IL_3974, IL_3982, IL_3999, IL_39b4, IL_39ba, IL_39c8, IL_39e6, IL_3a0a, IL_3a21, IL_3a30, IL_3a39, IL_3a47, IL_3a4d, IL_3a70, IL_3a76, IL_3a84, IL_3a8f, IL_3aad, IL_3ab8, IL_3ac7, IL_3ae2, IL_3af5, IL_3aff, IL_3b07, IL_3b14, IL_3b27, IL_3b4b, IL_3b69, IL_3b8d, IL_3ba0, IL_3bab, IL_3bb6, IL_3bd6, IL_3bf8, IL_3c0a, IL_3c18, IL_3c33, IL_3c4c, IL_3c5e, IL_3c72, IL_3c7a, IL_3c95, IL_3cb0, IL_3cd3, IL_3cde, IL_3ced, IL_3d11, IL_3d1c, IL_3d2c, IL_3d44, IL_3d5f, IL_3d72, IL_3d7d, IL_3d8d, IL_3daa, IL_3db6, IL_3dc1, IL_3dd4, IL_3de0, IL_3df8, IL_3e11, IL_3e17, IL_3e25, IL_3e33, IL_3e3f, IL_3e5d, IL_3e7a, IL_3e8d, IL_3ea1, IL_3eb5, IL_3ed5, IL_3ede, IL_3eec, IL_3f08, IL_3f29, IL_3f39, IL_3f5d, IL_3f6b, IL_3f7e, IL_3f86, IL_3fa7, IL_3fcb, IL_3fd9, IL_3ff4, IL_4012, IL_4025, IL_403d, IL_4049, IL_4057, IL_4063, IL_4087, IL_40ab, IL_40b6, IL_40d9, IL_40e5, IL_40f9, IL_4116, IL_4132, IL_414c, IL_415f, IL_4180, IL_41a3, IL_41ae, IL_41b7, IL_41da, IL_41eb, IL_41f7, IL_420a, IL_421d, IL_422a, IL_423a, IL_424b, IL_425f, IL_4272, IL_428d, IL_4298, IL_42a4, IL_42b8, IL_42cb, IL_42e4, IL_42fa, IL_4315, IL_4329, IL_4334, IL_434c, IL_4366, IL_4384, IL_4397, IL_43a8, IL_43b9, IL_43cc, IL_43dd, IL_43ee, IL_4406, IL_4414, IL_441d, IL_4424, IL_442c, IL_4432, IL_443b, IL_444f, IL_4463, IL_4479, IL_4481, IL_448c, IL_449a, IL_44a0, IL_44b6, IL_44c4, IL_44e3 are reachable both inside and outside the pinned region starting at IL_0beb. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 429;
		uint num14 = default(uint);
		byte[] array6 = default(byte[]);
		int num20 = default(int);
		int num21 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num5 = default(int);
		byte[] array18 = default(byte[]);
		int num16 = default(int);
		IntPtr intptr_3 = default(IntPtr);
		int num8 = default(int);
		uint num43 = default(uint);
		IntPtr intptr_6 = default(IntPtr);
		string text = default(string);
		byte[] array3 = default(byte[]);
		int num11 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array16 = default(byte[]);
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num28 = default(int);
		int num12 = default(int);
		uint num17 = default(uint);
		uint num18 = default(uint);
		byte[] array15 = default(byte[]);
		byte[] array9 = default(byte[]);
		Process object_11 = default(Process);
		IEnumerator enumerator = default(IEnumerator);
		IntPtr intPtr = default(IntPtr);
		int num58 = default(int);
		int num61 = default(int);
		int num63 = default(int);
		int num67 = default(int);
		int num68 = default(int);
		int num73 = default(int);
		IntPtr procAddress = default(IntPtr);
		string string_ = default(string);
		VtNVUKGulysZw81C3E object_ = default(VtNVUKGulysZw81C3E);
		byte[] array8 = default(byte[]);
		long num38 = default(long);
		int int_ = default(int);
		long num19 = default(long);
		bool flag = default(bool);
		ProcessModuleCollection object_5 = default(ProcessModuleCollection);
		byte[] array10 = default(byte[]);
		int num39 = default(int);
		int num54 = default(int);
		bool jDNkifbo3S = default(bool);
		int int_3 = default(int);
		byte[] jsbkrdexts = default(byte[]);
		int num36 = default(int);
		int num51 = default(int);
		int num7 = default(int);
		IntPtr intptr_ = default(IntPtr);
		AwgKvrHJUS3TxryUsj uint_ = default(AwgKvrHJUS3TxryUsj);
		BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
		IntPtr intptr_4 = default(IntPtr);
		int num6 = default(int);
		int num52 = default(int);
		IntPtr intptr_5 = default(IntPtr);
		int num53 = default(int);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
		MemoryStream object_10 = default(MemoryStream);
		byte[] array21 = default(byte[]);
		int num45 = default(int);
		uint nativeSizeOfCode = default(uint);
		ref byte reference2 = default(ref byte);
		int num47 = default(int);
		int num49 = default(int);
		int num25 = default(int);
		byte[] array13 = default(byte[]);
		int num42 = default(int);
		int num15 = default(int);
		byte[] array14 = default(byte[]);
		uint num40 = default(uint);
		int num41 = default(int);
		int num23 = default(int);
		uint num22 = default(uint);
		int num37 = default(int);
		byte[] array12 = default(byte[]);
		CryptoStream object_2 = default(CryptoStream);
		uint num13 = default(uint);
		int num35 = default(int);
		IntPtr intPtr4 = default(IntPtr);
		OFfwWh6ZIHjfnqBOWx object_4 = default(OFfwWh6ZIHjfnqBOWx);
		int num30 = default(int);
		ProcessModule object_6 = default(ProcessModule);
		Version object_7 = default(Version);
		Version object_8 = default(Version);
		Version object_9 = default(Version);
		int num32 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		ICryptoTransform transform = default(ICryptoTransform);
		int int_2 = default(int);
		int num10 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		ref byte reference = default(ref byte);
		byte[] array7 = default(byte[]);
		long num27 = default(long);
		IntPtr intPtr3 = default(IntPtr);
		long num24 = default(long);
		byte[] array11 = default(byte[]);
		while (!MrkkWebIMK)
		{
			while (true)
			{
				IL_0013:
				MrkkWebIMK = true;
				while (true)
				{
					IL_0019:
					uint num2 = 4059231220u;
					int num3 = 294;
					if (IranHmBduY2M1rn0mF())
					{
						goto IL_002f;
					}
					goto IL_0b01;
					IL_0b01:
					num3 = num;
					goto IL_002f;
					IL_002f:
					while (true)
					{
						int num55;
						int num56;
						long num57;
						long num59;
						int num60;
						int num62;
						int num64;
						int num65;
						int num66;
						int num69;
						int num70;
						int num71;
						int num72;
						int num74;
						ref BIpvxRBRb2dOGl802m reference3;
						int num44;
						byte[] array22;
						int num46;
						int num48;
						int num50;
						byte[] array20;
						IntPtr intptr_2;
						uint num33;
						int num29;
						int num31;
						byte[] array19;
						nint num26;
						byte[] array17;
						switch (num3)
						{
						case 429:
							break;
						case 592:
							goto IL_0013;
						case 273:
							goto IL_0019;
						case 674:
							num14 <<= 8;
							goto case 109;
						case 109:
							num14 |= array6[^(1 + num20)];
							goto case 316;
						case 316:
							num20++;
							goto case 5;
						case 601:
							if (num20 > 0)
							{
								goto case 674;
							}
							goto case 109;
						case 5:
						case 137:
							if (num20 < num21)
							{
								goto case 601;
							}
							goto IL_0af1;
						case 673:
							array5[23] = 120;
							num3 = 317;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 660;
						case 660:
							array5[23] = 240;
							num3 = 365;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 282;
						case 282:
							array4[14] = 140;
							num3 = 472;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 672:
							array5[19] = 110;
							num = 244;
							goto case 244;
						case 244:
							num5 = 36;
							num3 = 153;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 13;
						case 13:
							array5[7] = (byte)num5;
							goto case 73;
						case 73:
							num5 = 101;
							goto case 653;
						case 653:
							array5[7] = (byte)num5;
							num3 = 415;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 671:
							num5 = 112;
							num3 = 133;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 618:
						case 669:
							while (true)
							{
								fixed (byte* ptr = &array18[0])
								{
									num3 = 150;
									if (!IranHmBduY2M1rn0mF())
									{
										goto IL_002f_3;
									}
									goto IL_0bfd;
									IL_0bfd:
									num16 = 0;
									num3 = 178;
									if (HVnMjPVy0dTk6K1mRH() == null)
									{
										goto IL_002f_3;
									}
									goto IL_0c10;
									IL_0bc8:
									num5 = 112;
									num3 = 133;
									if (IranHmBduY2M1rn0mF())
									{
										goto IL_002f_3;
									}
									goto IL_0b01_2;
									IL_0c10:
									num24 = sEy60yBpTjAqfsuVmDE(intptr_3);
									goto IL_0c19;
									IL_0b01_2:
									num3 = num;
									goto IL_002f_3;
									IL_002f_3:
									while (true)
									{
										switch (num3)
										{
										case 618:
										case 669:
											break;
										case 429:
											if (!MrkkWebIMK)
											{
												goto case 592;
											}
											goto case 428;
										case 592:
											MrkkWebIMK = true;
											goto case 273;
										case 273:
											num2 = 4059231220u;
											num3 = 294;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 674:
											num14 <<= 8;
											goto case 109;
										case 109:
											num14 |= array6[^(1 + num20)];
											goto case 316;
										case 316:
											num20++;
											goto case 5;
										case 601:
											if (num20 > 0)
											{
												goto case 674;
											}
											goto case 109;
										case 5:
										case 137:
											if (num20 < num21)
											{
												goto case 601;
											}
											num3 = 375;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 673:
											array5[23] = 120;
											num3 = 317;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 660;
										case 660:
											array5[23] = 240;
											num3 = 365;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 282;
										case 282:
											array4[14] = 140;
											num3 = 472;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 672:
											array5[19] = 110;
											num = 244;
											goto case 244;
										case 244:
											num5 = 36;
											num3 = 153;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 13;
										case 13:
											array5[7] = (byte)num5;
											goto case 73;
										case 73:
											num5 = 101;
											goto case 653;
										case 653:
											array5[7] = (byte)num5;
											num3 = 415;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 671:
											goto IL_0bc8;
										case 65:
										case 427:
											goto IL_0bfd;
										case 117:
											goto IL_0c10;
										case 353:
										case 401:
											goto IL_0c19;
										case 378:
											goto IL_0c22;
										case 99:
											goto IL_0c43;
										case 668:
											if (num21 > 0)
											{
												goto case 552;
											}
											goto case 665;
										case 552:
											num8++;
											num3 = 665;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 494;
										case 494:
											array5[27] = 68;
											goto case 418;
										case 418:
											num5 = 118;
											goto case 112;
										case 112:
											array5[28] = (byte)num5;
											num = 293;
											goto case 293;
										case 293:
											array5[28] = 90;
											goto case 625;
										case 625:
											num5 = 86;
											num3 = 319;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 665:
											num43 = 0u;
											num3 = 434;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 667:
											array5[10] = (byte)num5;
											num3 = 117;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 142;
										case 142:
											num5 = 159;
											goto case 630;
										case 630:
											array5[10] = (byte)num5;
											num = 162;
											goto case 162;
										case 162:
											array5[11] = 92;
											goto case 157;
										case 157:
											array5[11] = 118;
											goto case 470;
										case 470:
											array5[11] = 175;
											goto case 20;
										case 20:
											array5[11] = 218;
											goto case 15;
										case 15:
											num5 = 128;
											num = 498;
											goto case 498;
										case 498:
											array5[12] = (byte)num5;
											goto case 572;
										case 572:
											array5[12] = 147;
											goto case 191;
										case 191:
											array5[12] = 106;
											goto case 322;
										case 322:
											array5[12] = 100;
											num = 504;
											goto case 504;
										case 504:
											array5[12] = 76;
											num3 = 468;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 666:
											intptr_6 = LoadLibrary(text);
											goto case 644;
										case 644:
											if (!fUZvZnBIo0QGMdkuqwx(intptr_6, IntPtr.Zero))
											{
												num3 = 623;
												if (HVnMjPVy0dTk6K1mRH() == null)
												{
													continue;
												}
												goto case 101;
											}
											goto case 95;
										case 101:
											array5[17] = 115;
											goto case 246;
										case 246:
											array5[17] = 167;
											num3 = 188;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 95:
											array3 = new byte[10];
											goto case 360;
										case 360:
											array3[0] = 99;
											num3 = 86;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 664:
											num11 = 86;
											num3 = 332;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 648;
										case 648:
											array4[9] = (byte)num11;
											goto case 183;
										case 183:
											num11 = 79;
											goto case 527;
										case 527:
											array4[10] = (byte)num11;
											goto case 431;
										case 431:
											num11 = 124;
											goto case 189;
										case 189:
											array4[10] = (byte)num11;
											goto case 247;
										case 247:
											array4[10] = 132;
											goto case 307;
										case 307:
											array4[10] = 124;
											goto case 266;
										case 266:
											array4[11] = 93;
											goto case 519;
										case 519:
											array4[11] = 139;
											goto case 564;
										case 564:
											num11 = 92;
											goto case 10;
										case 10:
											array4[11] = (byte)num11;
											goto case 58;
										case 58:
											array4[11] = 118;
											goto case 518;
										case 518:
											array4[11] = 194;
											num3 = 658;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 663:
											num5 = 84;
											num3 = 295;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 662:
											array2 = (byte[])gsLPImwN0YqwQaIieQ(intPtr3.ToInt32());
											num = 223;
											goto case 223;
										case 223:
											array16 = (byte[])gsLPImwN0YqwQaIieQ(MgcOqsBZRp8lpkejivL(num27));
											goto case 398;
										case 398:
										case 547:
											if (cJ9peUUbuVQT5wKaIB() == 4)
											{
												goto case 278;
											}
											goto case 423;
										case 278:
											num4 = 9;
											num3 = 544;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 81;
										case 81:
											array3[11] = 108;
											num3 = 80;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 60;
										case 60:
											array[num9] = array16[0];
											num3 = 577;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 279;
										case 279:
											if (cJ9peUUbuVQT5wKaIB() != 4)
											{
												goto IL_0c10;
											}
											goto case 311;
										case 311:
											num24 = mrFXA2ByUMsWbgwLCS2(intptr_3);
											num3 = 353;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 243;
										case 243:
											num28 = 0;
											num3 = 574;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 423:
											num9 = 2;
											goto case 485;
										case 485:
											array[num9] = array7[0];
											goto case 649;
										case 649:
											array[num9 + 1] = array7[1];
											goto case 414;
										case 414:
											array[num9 + 2] = array7[2];
											num3 = 291;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 661:
											intptr_6 = LoadLibrary(text);
											num3 = 118;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 26;
										case 26:
											num14 = 0u;
											num3 = 368;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 659:
											if (num21 > 0)
											{
												num3 = 404;
												if (HVnMjPVy0dTk6K1mRH() == null)
												{
													continue;
												}
												goto IL_0b01_2;
											}
											goto case 21;
										case 21:
											num43 = (uint)num12;
											goto case 68;
										case 68:
											num17 += num18;
											num3 = 654;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 658:
											num11 = 130;
											num3 = 74;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 108;
										case 108:
											array4[12] = (byte)num11;
											num3 = 421;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 657:
											array[num9] = array2[0];
											goto case 344;
										case 344:
											array[num9 + 1] = array2[1];
											goto case 143;
										case 143:
											array[num9 + 2] = array2[2];
											goto case 487;
										case 487:
											array[num9 + 3] = array2[3];
											goto case 534;
										case 534:
											array[num9 + 4] = array2[4];
											goto case 72;
										case 72:
											array[num9 + 5] = array2[5];
											goto case 584;
										case 584:
											array[num9 + 6] = array2[6];
											num3 = 83;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 228;
										case 656:
											num11 = 105;
											goto case 462;
										case 462:
											array4[13] = (byte)num11;
											num3 = 4;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 655:
											array4[4] = (byte)num11;
											goto case 166;
										case 166:
											num11 = 121;
											num3 = 594;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 241;
										case 241:
											array5[27] = 166;
											num3 = 437;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 165;
										case 165:
											array4[3] = (byte)num11;
											num3 = 171;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 249;
										case 249:
											array4[3] = 62;
											num3 = 436;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 654:
											num14 = (uint)((array6[num43 + 3] << 24) | (array6[num43 + 2] << 16) | (array6[num43 + 1] << 8) | array6[num43]);
											num3 = 507;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 424;
										case 424:
											num5 = 110;
											num3 = 44;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 652:
											fyt6ByBojUirf8waGTH(rNZkehfwNu);
											num3 = 389;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 651:
											array5[21] = 223;
											num3 = 196;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 624;
										case 624:
											array5[22] = 95;
											goto case 646;
										case 646:
											num5 = 137;
											num3 = 130;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 650:
											num5 = 132;
											goto case 480;
										case 480:
											array5[10] = (byte)num5;
											goto case 641;
										case 641:
											num5 = 85;
											num3 = 667;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 647:
											array3[9] = 100;
											goto case 66;
										case 66:
											array3[10] = 108;
											goto case 81;
										case 645:
											array15[9] = array9[4];
											num3 = 500;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 643:
											num5 = 109;
											num3 = 332;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 642:
											array4[15] = 136;
											goto case 596;
										case 596:
											array4[15] = 167;
											goto case 632;
										case 632:
											num11 = 18;
											num3 = 275;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 640:
											num27 = sEy60yBpTjAqfsuVmDE(new IntPtr(num24));
											num3 = 43;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 305;
										case 305:
										case 622:
											object_11 = (Process)cxyU4ysr5cXjtnBlE3();
											num = 253;
											goto case 253;
										case 253:
											try
											{
												ProcessModuleCollection object_12 = (ProcessModuleCollection)ttvIdokYconnO4LVWq(object_11);
												while (true)
												{
													enumerator = (IEnumerator)B518JUQdx9vQy586iX(object_12);
													num55 = 0;
													if (HVnMjPVy0dTk6K1mRH() != null)
													{
														switch (num55)
														{
														case 2:
															continue;
														default:
															goto end_IL_1361;
														case 1:
															break;
														case 0:
															goto end_IL_1361;
														}
													}
													try
													{
														while (true)
														{
															if (bJbPGvOBTb99N6Yugw(enumerator))
															{
																while (true)
																{
																	IL_1481:
																	ProcessModule object_13 = (ProcessModule)FFCROHqCsHxOmTok68(enumerator);
																	num56 = 7;
																	if (!IranHmBduY2M1rn0mF())
																	{
																		goto IL_1401;
																	}
																	goto IL_1452;
																	IL_1452:
																	while (true)
																	{
																		switch (num56)
																		{
																		case 9:
																			if (mi0ZPSB5hpsekQ9TG9R(iS7hDVB6I71dk8Dg2Yx(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
																			{
																				break;
																			}
																			num56 = 6;
																			if (HVnMjPVy0dTk6K1mRH() == null)
																			{
																				continue;
																			}
																			goto IL_13c0;
																		case 4:
																			break;
																		case 7:
																			if (!hcLgON2KrqkjPg4VtH(i9AiaSoPiJRHVKwOc9(object_13), text))
																			{
																				goto end_IL_1481;
																			}
																			num56 = 0;
																			if (HVnMjPVy0dTk6K1mRH() == null)
																			{
																				continue;
																			}
																			goto IL_13c0;
																		case 3:
																			goto IL_1401;
																		default:
																			num57 = num27;
																			intPtr = Lr1j2P6qwxWXaUmjO1(object_13);
																			if (num57 < intPtr.ToInt64())
																			{
																				goto case 9;
																			}
																			num58 = 3;
																			goto IL_1401;
																		case 5:
																			goto IL_1481;
																		case 2:
																		case 6:
																			goto end_IL_1481;
																		case 8:
																			goto end_IL_14a1;
																		case 1:
																			return;
																			IL_13c0:
																			num56 = num58;
																			continue;
																		}
																		break;
																	}
																	goto IL_13c9;
																	IL_1401:
																	num59 = num27;
																	intPtr = Lr1j2P6qwxWXaUmjO1(object_13);
																	if (num59 <= intPtr.ToInt64() + eBcGpaBaISUEEGPx55c(object_13))
																	{
																		break;
																	}
																	num56 = 9;
																	if (HVnMjPVy0dTk6K1mRH() != null)
																	{
																		goto IL_13c9;
																	}
																	goto IL_1452;
																	IL_13c9:
																	Fxa684CVyKutPq73Q5();
																	num56 = 1;
																	if (IranHmBduY2M1rn0mF())
																	{
																		return;
																	}
																	goto IL_1452;
																	continue;
																	end_IL_1481:
																	break;
																}
																continue;
															}
															num58 = 8;
															break;
															continue;
															end_IL_14a1:
															break;
														}
													}
													finally
													{
														IDisposable disposable = enumerator as IDisposable;
														num60 = 1;
														if (!IranHmBduY2M1rn0mF())
														{
															num60 = num61;
														}
														switch (num60)
														{
														case 1:
															if (disposable != null)
															{
																break;
															}
															goto end_IL_14bb;
														case 2:
														case 3:
															goto end_IL_14bb;
														}
														NpVWiuAKGUyYqmKsx6(disposable);
														num61 = 3;
														end_IL_14bb:;
													}
													break;
													continue;
													end_IL_1361:
													break;
												}
											}
											catch (object obj3)
											{
												num62 = 0;
												if (!IranHmBduY2M1rn0mF())
												{
													num62 = num63;
												}
												switch (num62)
												{
												}
											}
											goto case 356;
										case 356:
											try
											{
												ProcessModuleCollection object_14 = (ProcessModuleCollection)ttvIdokYconnO4LVWq(object_11);
												num64 = 0;
												if (HVnMjPVy0dTk6K1mRH() != null)
												{
													goto IL_154e;
												}
												goto IL_1552;
												IL_1552:
												while (true)
												{
													switch (num64)
													{
													case 1:
														try
														{
															while (bJbPGvOBTb99N6Yugw(enumerator))
															{
																while (true)
																{
																	ProcessModule object_15 = (ProcessModule)FFCROHqCsHxOmTok68(enumerator);
																	while (true)
																	{
																		intPtr = Lr1j2P6qwxWXaUmjO1(object_15);
																		num65 = 0;
																		if (!IranHmBduY2M1rn0mF())
																		{
																			goto IL_157a;
																		}
																		goto IL_158a;
																		IL_158a:
																		switch (num65)
																		{
																		case 3:
																			break;
																		default:
																			goto IL_157a;
																		case 4:
																			continue;
																		case 6:
																			goto end_IL_15ad;
																		case 2:
																			goto end_IL_15c5;
																		case 1:
																		case 5:
																			goto end_IL_15d5;
																		}
																		goto IL_1569;
																		IL_157a:
																		if (intPtr.ToInt64() != eXJkjmTXDX)
																		{
																			goto end_IL_15c5;
																		}
																		goto IL_1569;
																		IL_1569:
																		num28 = 0;
																		num65 = 1;
																		if (HVnMjPVy0dTk6K1mRH() == null)
																		{
																			goto end_IL_15d5;
																		}
																		goto IL_158a;
																		continue;
																		end_IL_15ad:
																		break;
																	}
																	continue;
																	end_IL_15c5:
																	break;
																}
																continue;
																end_IL_15d5:
																break;
															}
														}
														finally
														{
															IDisposable disposable = enumerator as IDisposable;
															num66 = 0;
															if (HVnMjPVy0dTk6K1mRH() != null)
															{
																goto IL_1615;
															}
															goto IL_1628;
															IL_1628:
															while (true)
															{
																switch (num66)
																{
																case 2:
																	goto IL_15fb;
																case 1:
																	goto end_IL_1628;
																}
																goto IL_1615;
																IL_15fb:
																NpVWiuAKGUyYqmKsx6(disposable);
																num66 = 1;
																if (IranHmBduY2M1rn0mF())
																{
																	continue;
																}
																goto IL_160f;
																continue;
																end_IL_1628:
																break;
															}
															goto end_IL_15e3;
															IL_160f:
															num66 = num67;
															goto IL_1628;
															IL_1615:
															if (disposable != null)
															{
																num66 = 2;
																if (HVnMjPVy0dTk6K1mRH() != null)
																{
																	goto IL_160f;
																}
																goto IL_1628;
															}
															end_IL_15e3:;
														}
														goto end_IL_1552;
													case 2:
														goto end_IL_1552;
													}
													enumerator = (IEnumerator)B518JUQdx9vQy586iX(object_14);
													num64 = 1;
													if (IranHmBduY2M1rn0mF())
													{
														continue;
													}
													goto IL_154e;
													continue;
													end_IL_1552:
													break;
												}
												goto end_IL_1520;
												IL_154e:
												num64 = num68;
												goto IL_1552;
												end_IL_1520:;
											}
											catch (object obj4)
											{
												num69 = 0;
												if (HVnMjPVy0dTk6K1mRH() == null)
												{
													switch (num69)
													{
													}
												}
											}
											goto case 218;
										case 352:
											try
											{
												abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)RapOAnBSklV8JMw1wES(new IntPtr(num27), VW2d8fBr2cnP3KQh480(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
												num70 = 0;
												if (IranHmBduY2M1rn0mF())
												{
													switch (num70)
													{
													}
												}
											}
											catch (object obj6)
											{
												num71 = 1;
												if (!IranHmBduY2M1rn0mF())
												{
													switch (num71)
													{
													default:
														goto end_IL_169d;
													case 1:
														break;
													case 0:
														goto end_IL_169d;
													}
												}
												try
												{
													Delegate object_16 = (Delegate)RapOAnBSklV8JMw1wES(new IntPtr(num27), VW2d8fBr2cnP3KQh480(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
													num72 = 0;
													if (HVnMjPVy0dTk6K1mRH() == null)
													{
														goto IL_16e5;
													}
													goto IL_1716;
													IL_1716:
													switch (num72)
													{
													case 1:
														goto end_IL_16c0;
													}
													goto IL_16e5;
													IL_16e5:
													abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)AD8IHcBCAaY9dSgQ0ZU(VW2d8fBr2cnP3KQh480(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle), QCdt93B1dmFDakGUb1m(object_16));
													num72 = 1;
													if (HVnMjPVy0dTk6K1mRH() != null)
													{
														num72 = num73;
													}
													goto IL_1716;
													end_IL_16c0:;
												}
												catch (object obj5)
												{
													num74 = 0;
													if (HVnMjPVy0dTk6K1mRH() != null)
													{
														switch (num74)
														{
														default:
															goto end_IL_1727;
														}
													}
													end_IL_1727:;
												}
												end_IL_169d:;
											}
											goto case 445;
										case 445:
											num3 = 289;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 639:
											array5[13] = (byte)num5;
											num = 221;
											goto case 221;
										case 221:
											array5[13] = 126;
											num3 = 308;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 638:
											procAddress = GetProcAddress(intptr_6, string_);
											num3 = 484;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 286;
										case 286:
											array5[3] = 164;
											num3 = 94;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 637:
											num5 = 112;
											goto case 184;
										case 184:
											array5[21] = (byte)num5;
											goto case 16;
										case 16:
											array5[21] = 144;
											goto case 651;
										case 636:
											text = (string)JUTQe8Btg3H97VDyQBF(RVtYEkBjq51FQBTROnZ(), array3);
											goto case 661;
										case 635:
											goto end_IL_0be3;
										case 287:
											object_ = new VtNVUKGulysZw81C3E(new MemoryStream(array8));
											goto case 37;
										case 37:
											MhUL1X3vdKIRoiAZ2h(jdn14iPZJbNEoRhq7K(object_), 0L);
											goto case 103;
										case 103:
											intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(x4Dk2IHVmX))[0]);
											goto case 627;
										case 627:
											num38 = intPtr.ToInt64();
											goto case 510;
										case 510:
											int_ = 0;
											goto case 243;
										case 634:
											QkvmIESAUb9sUU9VCC(new IntPtr(&num19), 0, 0L);
											num = 509;
											goto case 509;
										case 509:
											array18 = new byte[1];
											goto case 626;
										case 626:
											v56v3vyckQQddrak5e(array18, 0, FPU4nCWw4KJ9qdkx0G(8), 1);
											goto case 219;
										case 219:
											WtHracpsmgqsF8ATcR();
											goto case 425;
										case 425:
											if (num2 == 4109628145u)
											{
												goto case 570;
											}
											goto IL_18d2;
										case 570:
											flag = AAcXkN1Fay6mj1qY2b(kBgS1l5QwoacVPMLeo(Lr1j2P6qwxWXaUmjO1(LLWROkacydNSnOqVyt(cxyU4ysr5cXjtnBlE3())), "__", 10u), IntPtr.Zero);
											num = 51;
											goto case 51;
										case 51:
											if (flag)
											{
												goto IL_18d2;
											}
											goto case 222;
										case 83:
											if (is2epJ9ZPSV6MHPvX5(xCCDxhhDGNiYw9Z67H("System.Reflection.ReflectionContext", bool_0: false), null))
											{
												goto case 479;
											}
											goto case 379;
										case 479:
											object_5 = (ProcessModuleCollection)ttvIdokYconnO4LVWq(cxyU4ysr5cXjtnBlE3());
											num3 = 459;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 115;
										case 115:
											array5[0] = 120;
											goto case 136;
										case 136:
											array5[0] = 134;
											num3 = 599;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 379:
											object_ = new VtNVUKGulysZw81C3E((Stream)WZvgFyRvmx5f8718jT(x4Dk2IHVmX, "MmpydemxQXtr071PFr.3wVOUuoo8EuDgyy0xT"));
											num3 = 45;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 633:
											num5 = 82;
											goto case 511;
										case 511:
											array5[2] = (byte)num5;
											goto case 313;
										case 313:
											num5 = 51;
											goto case 314;
										case 314:
											array5[2] = (byte)num5;
											goto case 410;
										case 410:
											array5[3] = 30;
											num = 397;
											goto case 397;
										case 397:
											array5[3] = 132;
											goto case 617;
										case 617:
											array5[3] = 199;
											goto case 286;
										case 631:
											array3[4] = 105;
											goto case 608;
										case 608:
											array3[5] = 116;
											goto case 430;
										case 430:
											array3[6] = 46;
											goto case 251;
										case 251:
											array3[7] = 100;
											goto case 440;
										case 440:
											array3[8] = 108;
											goto case 169;
										case 169:
											array3[9] = 108;
											goto case 636;
										case 629:
											array4[15] = (byte)num11;
											num3 = 155;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 628:
											XtMknffM5M = intPtr.ToInt32();
											goto case 29;
										case 29:
											intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(x4Dk2IHVmX))[0]);
											num3 = 39;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 118:
										case 623:
											array10 = new byte[6];
											num3 = 147;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 620:
											array5[5] = 170;
											goto case 11;
										case 11:
											array5[5] = 155;
											goto case 496;
										case 496:
											num5 = 97;
											num3 = 33;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 619:
											num11 = 87;
											goto case 281;
										case 281:
											array4[2] = (byte)num11;
											num3 = 561;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 302:
										case 616:
											if (g5t6XmzTB7McRy9hy4(jdn14iPZJbNEoRhq7K(object_)) < hnqKsEMJyigELtAMsm(jdn14iPZJbNEoRhq7K(object_)) - 1L)
											{
												goto case 488;
											}
											goto case 237;
										case 488:
											num39 = dfS4ULclYXZYwSkxBX(object_) - num28;
											num3 = 287;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 581;
										case 581:
											num54 = dfS4ULclYXZYwSkxBX(object_);
											goto case 104;
										case 104:
											jDNkifbo3S = false;
											goto case 469;
										case 469:
											if (num54 >= 1879048192)
											{
												goto case 392;
											}
											goto case 348;
										case 392:
											jDNkifbo3S = true;
											num3 = 348;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 348:
											int_3 = dfS4ULclYXZYwSkxBX(object_);
											num = 381;
											goto case 381;
										case 381:
											jsbkrdexts = (byte[])AEygtYdaRrAdRQSUdC(object_, int_3);
											num3 = 461;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 458;
										case 458:
											array4[3] = (byte)num11;
											num3 = 358;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 237:
											intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))[0]);
											goto case 27;
										case 27:
											eXJkjmTXDX = intPtr.ToInt64();
											num3 = 280;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 614:
											array5[16] = 86;
											num3 = 395;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 452;
										case 452:
											array5[16] = 144;
											num3 = 51;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 62;
										case 62:
											num5 = 211;
											goto case 185;
										case 185:
											array5[16] = (byte)num5;
											num3 = 173;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 613:
											BJCwZN4chYfp322mb0(object_);
											goto case 492;
										case 492:
											num36 = dfS4ULclYXZYwSkxBX(object_);
											goto case 7;
										case 7:
											num51 = dfS4ULclYXZYwSkxBX(object_);
											goto case 349;
										case 349:
											if (num51 == 1)
											{
												goto case 84;
											}
											num7 = 0;
											num = 351;
											goto case 351;
										case 84:
											intptr_ = IntPtr.Zero;
											num = 18;
											goto case 18;
										case 18:
											uint_ = (AwgKvrHJUS3TxryUsj)56;
											num3 = 76;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 351:
										case 363:
											if (num7 >= num36)
											{
												num = 482;
												goto case 482;
											}
											goto case 300;
										case 482:
											lmdkVksVkh = new Hashtable(dfS4ULclYXZYwSkxBX(object_) + 1);
											num3 = 10;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 31;
										case 31:
											bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
											goto case 355;
										case 355:
											reference3 = ref bIpvxRBRb2dOGl802m2;
											array18 = new byte[1] { 42 };
											reference3.jsbkrdexts = array18;
											num3 = 56;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 290;
										case 290:
											bIpvxRBRb2dOGl802m2.JDNkifbo3S = false;
											num = 586;
											goto case 586;
										case 586:
											Q0ZYP9BVNnFw8WUuZEb(lmdkVksVkh, 0L, bIpvxRBRb2dOGl802m2);
											num3 = 303;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 300:
											intptr_4 = new IntPtr(num38 + dfS4ULclYXZYwSkxBX(object_) - num28);
											num = 384;
											goto case 384;
										case 384:
											YeeoMqaS3J(intptr_4, 4, 4, ref int_);
											num3 = 37;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 123;
										case 123:
											zgruAFBGT2tfklaxaKW(intptr_4, dfS4ULclYXZYwSkxBX(object_));
											num3 = 207;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 612:
											array5[17] = 131;
											goto case 101;
										case 611:
											array5[4] = (byte)num5;
											goto case 663;
										case 254:
										case 610:
											if (num6 >= num52)
											{
												num = 503;
												goto case 503;
											}
											goto case 473;
										case 503:
											YeeoMqaS3J(intptr_5, num52 * 4, int_, ref int_);
											goto case 229;
										case 229:
										case 402:
											if (g5t6XmzTB7McRy9hy4(jdn14iPZJbNEoRhq7K(object_)) < hnqKsEMJyigELtAMsm(jdn14iPZJbNEoRhq7K(object_)) - 1L)
											{
												goto case 234;
											}
											goto case 127;
										case 234:
											num53 = dfS4ULclYXZYwSkxBX(object_);
											goto case 442;
										case 442:
											intptr_5 = new IntPtr(URnkCOceLK + num53 - num28);
											goto case 208;
										case 208:
											num52 = dfS4ULclYXZYwSkxBX(object_);
											goto case 105;
										case 105:
											YeeoMqaS3J(intptr_5, num52 * 4, 4, ref int_);
											num3 = 46;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 473:
											zgruAFBGT2tfklaxaKW(new IntPtr(intptr_5.ToInt64() + num6 * 4), dfS4ULclYXZYwSkxBX(object_));
											num3 = 170;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 132;
										case 132:
											array5[14] = 51;
											goto case 390;
										case 390:
											array5[15] = 54;
											goto case 568;
										case 568:
											array5[15] = 131;
											goto case 240;
										case 240:
											array5[15] = 167;
											num3 = 406;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 609:
											if (cJ9peUUbuVQT5wKaIB() != 4)
											{
												goto case 29;
											}
											goto case 17;
										case 17:
											intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(x4Dk2IHVmX))[0]);
											goto case 628;
										case 607:
											array3[6] = 105;
											num3 = 1;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 606:
											array5[5] = 222;
											goto case 41;
										case 41:
											array5[6] = 67;
											goto case 175;
										case 175:
											num5 = 125;
											goto case 100;
										case 100:
											array5[6] = (byte)num5;
											goto case 643;
										case 605:
											num5 = 165;
											num3 = 213;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 81;
										case 604:
											array10[1] = 101;
											num3 = 329;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 603:
											array[num4 + 3] = array16[3];
											goto case 28;
										case 28:
											num4 = 23;
											num3 = 621;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 602:
											num5 = 127;
											goto case 579;
										case 579:
											array5[8] = (byte)num5;
											goto case 597;
										case 597:
											num5 = 63;
											goto case 505;
										case 505:
											array5[8] = (byte)num5;
											num3 = 141;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 26;
										case 107:
										case 600:
											num36 = dfS4ULclYXZYwSkxBX(object_);
											num = 345;
											goto case 345;
										case 345:
											num51 = dfS4ULclYXZYwSkxBX(object_);
											goto case 156;
										case 156:
											if (num51 != 4)
											{
												goto case 349;
											}
											goto case 466;
										case 466:
											object_3 = (SymmetricAlgorithm)OH9dmTJ6dfnBpK10Ki();
											goto case 444;
										case 444:
											gWRZV4lbAMTB7Bs9Aa(object_3, CipherMode.CBC);
											num3 = 312;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 106;
										case 106:
											array5[20] = 164;
											goto case 6;
										case 6:
											num5 = 171;
											goto case 317;
										case 317:
											array5[20] = (byte)num5;
											num3 = 230;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 599:
											array5[0] = 126;
											goto case 555;
										case 555:
											array5[0] = 132;
											goto case 337;
										case 337:
											array5[1] = 157;
											num3 = 98;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 598:
											bIpvxRBRb2dOGl802m.jsbkrdexts = jsbkrdexts;
											num3 = 556;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 338;
										case 338:
											num11 = 126;
											goto case 629;
										case 595:
											array5[15] = (byte)num5;
											num3 = 61;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 594:
											array4[4] = (byte)num11;
											num3 = 180;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 593:
											num11 = 184;
											goto case 315;
										case 315:
											array4[0] = (byte)num11;
											num = 508;
											goto case 508;
										case 508:
											num11 = 114;
											num3 = 499;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 591:
											array5[16] = 87;
											goto case 179;
										case 179:
											num5 = 154;
											goto case 373;
										case 373:
											array5[16] = (byte)num5;
											num3 = 614;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 590:
											array5[30] = (byte)num5;
											goto case 140;
										case 140:
											num5 = 100;
											goto case 87;
										case 87:
											array5[30] = (byte)num5;
											goto case 176;
										case 176:
											array5[30] = 88;
											num3 = 216;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 589:
											array16 = (byte[])xUqmogBqDnQuhXU4Zbm(num27);
											num3 = 547;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 588:
											array = array11;
											num = 25;
											goto case 25;
										case 25:
											array2 = null;
											num3 = 565;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 587:
											num11 = 50;
											goto case 486;
										case 486:
											array4[12] = (byte)num11;
											num = 656;
											goto case 656;
										case 583:
											if (yYJwNnYQK62IqBhoI5(vuIHYUg5wQ3lqEF7X0(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)) <= 0)
											{
												goto case 40;
											}
											num = 197;
											goto case 197;
										case 40:
										case 67:
											try
											{
												object obj = fch4apBQQIvMnirycsV(s7T5DeBkUjK8MYBSMb9(SnyMILB9tCXrctSPI5G(aoXeKXBhgKWbmf3kMP6(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), SnyMILB9tCXrctSPI5G(aoXeKXBhgKWbmf3kMP6(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)));
												while (true)
												{
													IL_2433:
													if (obj is IntPtr)
													{
														goto IL_240a;
													}
													goto IL_2416;
													IL_2416:
													while (true)
													{
														IL_2416_2:
														if (!hcLgON2KrqkjPg4VtH(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
														{
															goto IL_22d5;
														}
														goto IL_23d1;
														IL_23d1:
														VE2k4S5okQ = (IntPtr)fch4apBQQIvMnirycsV(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
														num44 = 1;
														if (HVnMjPVy0dTk6K1mRH() == null)
														{
															goto IL_227f;
														}
														goto IL_22d5;
														IL_227f:
														while (true)
														{
															switch (num44)
															{
															case 1:
															case 18:
																break;
															case 17:
																MhUL1X3vdKIRoiAZ2h(object_10, 0L);
																num44 = 12;
																if (IranHmBduY2M1rn0mF())
																{
																	continue;
																}
																goto IL_227b;
															case 16:
																if (cJ9peUUbuVQT5wKaIB() == 4)
																{
																	num44 = 0;
																	if (HVnMjPVy0dTk6K1mRH() == null)
																	{
																		continue;
																	}
																	goto IL_227b;
																}
																goto case 6;
															case 6:
																BYbNk6uQOTrlRVlp4l(object_10, xUqmogBqDnQuhXU4Zbm(VE2k4S5okQ.ToInt64()), 0, 8);
																goto case 5;
															case 5:
															case 10:
																BYbNk6uQOTrlRVlp4l(object_10, new byte[cJ9peUUbuVQT5wKaIB()], 0, cJ9peUUbuVQT5wKaIB());
																num44 = 9;
																if (HVnMjPVy0dTk6K1mRH() != null)
																{
																	continue;
																}
																goto case 9;
															case 9:
																BYbNk6uQOTrlRVlp4l(object_10, new byte[cJ9peUUbuVQT5wKaIB()], 0, cJ9peUUbuVQT5wKaIB());
																goto case 17;
															case 7:
																BYbNk6uQOTrlRVlp4l(object_10, new byte[cJ9peUUbuVQT5wKaIB()], 0, cJ9peUUbuVQT5wKaIB());
																num44 = 16;
																if (HVnMjPVy0dTk6K1mRH() == null)
																{
																	continue;
																}
																goto IL_227b;
															default:
																BYbNk6uQOTrlRVlp4l(object_10, gsLPImwN0YqwQaIieQ(VE2k4S5okQ.ToInt32()), 0, 4);
																goto case 5;
															case 3:
																goto IL_23d1;
															case 11:
																goto end_IL_2416;
															case 4:
																goto IL_2416_2;
															case 8:
																goto IL_2433;
															case 12:
																array21 = (byte[])MRB1Ggb30AbIYOUXA1(object_10);
																num45 = 14;
																goto case 14;
															case 14:
																Qgb8YhvMWbR2oRpvia(object_10);
																goto case 2;
															case 2:
																nativeSizeOfCode = 0u;
																goto case 15;
															case 15:
																try
																{
																	array22 = (array18 = array21);
																	if (array22 != null)
																	{
																		goto IL_2462;
																	}
																	goto IL_24b3;
																	IL_24b3:
																	reference2 = ref *(byte*)null;
																	num46 = 1;
																	if (HVnMjPVy0dTk6K1mRH() != null)
																	{
																		num46 = num47;
																	}
																	goto IL_2490;
																	IL_2490:
																	switch (num46)
																	{
																	case 6:
																		break;
																	default:
																		goto IL_2475;
																	case 2:
																		goto IL_24b3;
																	case 1:
																	case 3:
																		rNZkehfwNu(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
																		goto end_IL_245b;
																	case 4:
																		goto end_IL_245b;
																	}
																	goto IL_2462;
																	IL_2462:
																	if (array18.Length != 0)
																	{
																		num46 = 5;
																		if (HVnMjPVy0dTk6K1mRH() != null)
																		{
																			goto IL_2475;
																		}
																		goto IL_2490;
																	}
																	goto IL_24b3;
																	IL_2475:
																	while (true)
																	{
																		fixed (byte* value = &array18[0])
																		{
																			num46 = 3;
																			if (!IranHmBduY2M1rn0mF())
																			{
																				num46 = num47;
																			}
																			while (true)
																			{
																				switch (num46)
																				{
																				case 0:
																				case 5:
																					break;
																				case 6:
																					if (array18.Length == 0)
																					{
																						goto end_IL_2475;
																					}
																					num46 = 5;
																					if (HVnMjPVy0dTk6K1mRH() == null)
																					{
																						continue;
																					}
																					break;
																				case 2:
																					goto end_IL_2475;
																				case 1:
																				case 3:
																					rNZkehfwNu(new IntPtr(value), new IntPtr(value), new IntPtr(value), 216669565u, new IntPtr(value), ref nativeSizeOfCode);
																					goto end_IL_245b;
																				case 4:
																					goto end_IL_245b;
																				}
																				break;
																			}
																		}
																		continue;
																		end_IL_2475:
																		break;
																	}
																	goto IL_24b3;
																	end_IL_245b:;
																}
																finally
																{
																	reference2 = ref *(byte*)null;
																	num48 = 0;
																	if (!IranHmBduY2M1rn0mF())
																	{
																		num48 = num49;
																	}
																	switch (num48)
																	{
																	}
																}
																goto end_IL_2433;
															case 13:
																goto end_IL_2433;
															}
															break;
														}
														goto IL_22d5;
														IL_22d5:
														object_10 = new MemoryStream();
														num44 = 7;
														if (!IranHmBduY2M1rn0mF())
														{
															goto IL_227b;
														}
														goto IL_227f;
														IL_227b:
														num44 = num45;
														goto IL_227f;
														continue;
														end_IL_2416:
														break;
													}
													goto IL_240a;
													IL_240a:
													VE2k4S5okQ = (IntPtr)obj;
													goto IL_2416;
													continue;
													end_IL_2433:
													break;
												}
											}
											catch (object obj2)
											{
												num50 = 0;
												if (!IranHmBduY2M1rn0mF())
												{
													switch (num50)
													{
													}
												}
											}
											goto case 38;
										case 63:
											FKefxyB2v6B3QccOFdC(Upxg6OBf9Dp7KTmmDnx(QCdt93B1dmFDakGUb1m(abxkLGOVrU)));
											num3 = 652;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 582:
											array20 = new byte[40];
											j94yovBHZC6iNptekrd(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
											array11 = array20;
											num3 = 79;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 43:
										case 580:
											num25++;
											goto case 265;
										case 265:
										case 553:
											if (num25 >= num8)
											{
												goto case 417;
											}
											goto case 292;
										case 417:
											array8 = array13;
											num3 = 125;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 292:
											num42 = num25 % num15;
											goto case 541;
										case 541:
											num12 = num25 * 4;
											num = 259;
											goto case 259;
										case 259:
											num43 = (uint)(num42 * 4);
											goto case 102;
										case 102:
											num18 = (uint)((array14[num43 + 3] << 24) | (array14[num43 + 2] << 16) | (array14[num43 + 1] << 8) | array14[num43]);
											num = 236;
											goto case 236;
										case 236:
											num40 = 255u;
											num3 = 43;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 75;
										case 75:
											num41 = 0;
											num3 = 98;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 403;
										case 403:
											if (num25 == num8 - 1)
											{
												goto case 659;
											}
											goto case 21;
										case 578:
											XkFtbdIp1Loq3EMk1X(new IntPtr(&num19), 0, 0);
											num3 = 634;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 577:
											array[num9 + 1] = array16[1];
											goto case 151;
										case 151:
											array[num9 + 2] = array16[2];
											num3 = 172;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 426;
										case 426:
											array[num9 + 3] = array16[3];
											num3 = 420;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 203;
										case 203:
											array5[30] = (byte)num5;
											num = 474;
											goto case 474;
										case 474:
											num5 = 79;
											goto case 590;
										case 576:
											JyADcotn09ZmOcH756(new IntPtr(&num19), 0, IntPtr.Zero);
											num3 = 578;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 575:
											array5[15] = (byte)num5;
											goto case 591;
										case 574:
											if (vuIHYUg5wQ3lqEF7X0(x4Dk2IHVmX) == null)
											{
												num3 = 523;
												if (IranHmBduY2M1rn0mF())
												{
													continue;
												}
												goto case 454;
											}
											goto case 343;
										case 454:
											if (num23 > 0)
											{
												goto case 69;
											}
											goto default;
										case 69:
											num40 <<= 8;
											goto case 441;
										case 441:
											num41 += 8;
											num3 = 0;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										default:
											array13[num12 + num23] = (byte)((num22 & num40) >> num41);
											num3 = 528;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 343:
											if (yYJwNnYQK62IqBhoI5(vuIHYUg5wQ3lqEF7X0(x4Dk2IHVmX)) != 0)
											{
												goto case 107;
											}
											goto case 47;
										case 47:
										case 523:
											num28 = 7680;
											goto case 107;
										case 573:
											array4[8] = 88;
											goto case 91;
										case 91:
											array4[8] = 101;
											goto case 110;
										case 110:
											array4[8] = 82;
											goto case 262;
										case 262:
											num11 = 136;
											goto case 177;
										case 177:
											array4[8] = (byte)num11;
											goto case 549;
										case 549:
											num11 = 0;
											num3 = 357;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 176;
										case 569:
											array5[25] = 145;
											num3 = 200;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 567:
											num5 = 120;
											num = 336;
											goto case 336;
										case 336:
											array5[10] = (byte)num5;
											goto IL_0c43;
										case 566:
											array4[5] = 114;
											num3 = 157;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 520;
										case 520:
											array4[5] = 170;
											num3 = 359;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 565:
											array16 = null;
											goto case 271;
										case 271:
											array7 = null;
											goto case 201;
										case 201:
											if (cJ9peUUbuVQT5wKaIB() == 4)
											{
												goto case 264;
											}
											goto case 323;
										case 264:
											array7 = (byte[])gsLPImwN0YqwQaIieQ(VE2k4S5okQ.ToInt32());
											num3 = 534;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 662;
										case 323:
											array7 = (byte[])xUqmogBqDnQuhXU4Zbm(VE2k4S5okQ.ToInt64());
											num3 = 255;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 94;
										case 94:
											num5 = 62;
											goto case 611;
										case 563:
											num5 = 139;
											goto case 310;
										case 310:
											array5[1] = (byte)num5;
											goto case 96;
										case 96:
											array5[1] = 120;
											goto case 171;
										case 171:
											array5[1] = 209;
											num3 = 114;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 562:
											array[num4 + 2] = array16[2];
											num3 = 603;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 561:
											array4[2] = 167;
											goto case 340;
										case 340:
											array4[2] = 122;
											goto case 70;
										case 70:
											num11 = 132;
											num3 = 284;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 560:
											array3[3] = 111;
											num3 = 123;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 129;
										case 129:
											array3[4] = 114;
											goto case 543;
										case 543:
											array3[5] = 106;
											goto case 607;
										case 559:
											array5[25] = (byte)num5;
											num3 = 333;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 558:
											array4[13] = (byte)num11;
											num3 = 26;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 152;
										case 152:
											num11 = 70;
											goto case 120;
										case 120:
											array4[14] = (byte)num11;
											num = 517;
											goto case 517;
										case 517:
											num11 = 148;
											goto case 145;
										case 145:
											array4[14] = (byte)num11;
											goto case 282;
										case 556:
											bIpvxRBRb2dOGl802m.JDNkifbo3S = jDNkifbo3S;
											goto case 388;
										case 388:
											Q0ZYP9BVNnFw8WUuZEb(lmdkVksVkh, num38 + num39, bIpvxRBRb2dOGl802m);
											goto case 302;
										case 554:
											array5[29] = 161;
											num3 = 99;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 202;
										case 202:
											num5 = 94;
											num3 = 203;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 551:
											num11 = 92;
											goto case 458;
										case 550:
											array5[29] = 138;
											goto case 554;
										case 548:
											num37 = 0;
											goto case 267;
										case 35:
											array14[num37] = (byte)(array14[num37] ^ array15[num37]);
											goto case 464;
										case 464:
											num37++;
											goto case 267;
										case 267:
										case 422:
											if (num37 < array15.Length)
											{
												goto case 35;
											}
											num3 = 34;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 535;
										case 535:
											array6 = array12;
											num3 = 370;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 546:
											num5 = 164;
											goto case 119;
										case 119:
											array5[7] = (byte)num5;
											num3 = 536;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 545:
											num9 = 18;
											goto case 60;
										case 544:
											array[num4] = array7[0];
											goto case 121;
										case 121:
											array[num4 + 1] = array7[1];
											goto case 533;
										case 533:
											array[num4 + 2] = array7[2];
											goto case 376;
										case 376:
											array[num4 + 3] = array7[3];
											goto case 199;
										case 199:
											num4 = 16;
											goto case 530;
										case 530:
											array[num4] = array16[0];
											goto case 224;
										case 224:
											array[num4 + 1] = array16[1];
											goto case 562;
										case 542:
											Qgb8YhvMWbR2oRpvia(object_2);
											goto case 613;
										case 540:
											array13[num12 + 1] = (byte)((num13 & 0xFF00) >> 8);
											num3 = 181;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 539:
											array5[18] = (byte)num5;
											num3 = 215;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 538:
											num5 = 114;
											goto case 193;
										case 193:
											array5[5] = (byte)num5;
											goto case 146;
										case 146:
											num5 = 150;
											num3 = 475;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 537:
											num5 = 170;
											goto case 325;
										case 325:
											array5[18] = (byte)num5;
											goto case 524;
										case 524:
											num5 = 9;
											num3 = 23;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 536:
											num5 = 154;
											goto case 13;
										case 532:
											intptr_2 = IntPtr.Zero;
											goto case 457;
										case 457:
											num35 = 0;
											num3 = 248;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 531:
											num35++;
											goto case 248;
										case 248:
										case 477:
											if (num35 >= num36)
											{
												num3 = 229;
												if (IranHmBduY2M1rn0mF())
												{
													continue;
												}
												goto IL_0c43;
											}
											goto case 209;
										case 209:
											intPtr4 = new IntPtr(URnkCOceLK + dfS4ULclYXZYwSkxBX(object_) - num28);
											goto case 36;
										case 36:
											YeeoMqaS3J(intPtr4, 4, 4, ref int_);
											goto case 85;
										case 85:
											if (cJ9peUUbuVQT5wKaIB() == 4)
											{
												num3 = 306;
												if (HVnMjPVy0dTk6K1mRH() == null)
												{
													continue;
												}
												goto IL_0b01_2;
											}
											goto case 489;
										case 489:
											mTfoQqVbOE(intptr_, intPtr4, (byte[])gsLPImwN0YqwQaIieQ(dfS4ULclYXZYwSkxBX(object_)), 4u, out intptr_2);
											num3 = 298;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 529:
											array4[0] = (byte)num11;
											goto case 399;
										case 399:
											array4[0] = 129;
											goto case 493;
										case 493:
											num11 = 96;
											num3 = 514;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 40;
										case 528:
											num23++;
											goto case 19;
										case 19:
										case 270:
											if (num23 >= num21)
											{
												num3 = 39;
												if (!IranHmBduY2M1rn0mF())
												{
													continue;
												}
												goto case 43;
											}
											goto case 454;
										case 526:
											num5 = 130;
											num3 = 220;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 525:
											num11 = 124;
											num3 = 112;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 405;
										case 405:
											array4[9] = (byte)num11;
											num3 = 374;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 522:
											if (array18.Length != 0)
											{
												break;
											}
											goto IL_2d84;
										case 460:
										case 463:
											goto IL_2d84;
										case 521:
											Tafe6kn7GkmfX3wkZs(array9, 0, array9.Length);
											goto case 548;
										case 516:
											array4[8] = 148;
											goto case 573;
										case 515:
											array3[8] = 46;
											goto case 647;
										case 514:
											array4[0] = (byte)num11;
											num3 = 304;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 513:
											array5[26] = (byte)num5;
											num = 481;
											goto case 481;
										case 481:
											array5[26] = 204;
											goto case 419;
										case 419:
											num5 = 114;
											goto case 55;
										case 55:
											array5[26] = (byte)num5;
											goto case 605;
										case 512:
											array4[4] = (byte)num11;
											goto case 407;
										case 407:
											num11 = 147;
											num3 = 375;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 655;
										case 375:
										case 507:
											num17 = num17;
											goto case 88;
										case 88:
										{
											num33 = num17;
											uint num34 = num17;
											num34 ^= num34 << 7;
											num34 += 205125544;
											num34 ^= num34 >> 9;
											num34 += 1218856144;
											num34 ^= num34 << 5;
											num34 += 3206220699u;
											num34 = 1657819281 - num34;
											num17 = num33 + (uint)(double)num34;
											goto case 301;
										}
										case 301:
											if (num25 == num8 - 1)
											{
												goto case 393;
											}
											goto case 77;
										case 393:
											if (num21 > 0)
											{
												num3 = 387;
												if (HVnMjPVy0dTk6K1mRH() == null)
												{
													continue;
												}
												goto case 205;
											}
											goto case 77;
										case 205:
											array4[12] = 82;
											goto case 455;
										case 455:
											num11 = 118;
											goto case 396;
										case 396:
											array4[12] = (byte)num11;
											goto case 587;
										case 77:
											num13 = num17 ^ num14;
											goto case 161;
										case 161:
											array13[num12] = (byte)(num13 & 0xFFu);
											num3 = 540;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 506:
											if (!mi0ZPSB5hpsekQ9TG9R(iS7hDVB6I71dk8Dg2Yx(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
											{
												goto case 40;
											}
											goto case 416;
										case 416:
											if (((Array)quXFyABUAMLkRq78FPR(iS7hDVB6I71dk8Dg2Yx(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).Length != 2)
											{
												goto case 40;
											}
											num = 131;
											goto case 131;
										case 131:
											if (vuIHYUg5wQ3lqEF7X0(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly) != null)
											{
												goto case 583;
											}
											goto case 40;
										case 502:
											intPtr3 = rb84cNBsnI11TUIN2nG(rNZkehfwNu);
											num3 = 450;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 207;
										case 207:
											YeeoMqaS3J(intptr_4, 4, int_, ref int_);
											num3 = 54;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 501:
											array5[9] = (byte)num5;
											goto case 567;
										case 500:
											array15[11] = array9[5];
											goto case 471;
										case 471:
											array15[13] = array9[6];
											goto case 149;
										case 149:
											array15[15] = array9[7];
											goto case 521;
										case 499:
											array4[1] = (byte)num11;
											num3 = 160;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 497:
											array13 = new byte[array6.Length];
											num3 = 257;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 221;
										case 495:
											array4[5] = (byte)num11;
											num3 = 438;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 491:
											array5[22] = 35;
											num = 172;
											goto case 172;
										case 172:
											array5[23] = 214;
											num3 = 372;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 490:
											array5[9] = (byte)num5;
											goto case 206;
										case 206:
											array5[9] = 69;
											goto case 34;
										case 34:
											num5 = 169;
											goto case 501;
										case 484:
											object_4 = (OFfwWh6ZIHjfnqBOWx)RapOAnBSklV8JMw1wES(procAddress, VW2d8fBr2cnP3KQh480(typeof(OFfwWh6ZIHjfnqBOWx).TypeHandle));
											num3 = 395;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											return;
										case 483:
											array5[18] = (byte)num5;
											goto case 537;
										case 478:
											array5[28] = 85;
											goto case 122;
										case 122:
											num5 = 103;
											goto case 449;
										case 449:
											array5[28] = (byte)num5;
											goto case 212;
										case 212:
											array5[28] = 239;
											goto case 97;
										case 97:
											array5[29] = 104;
											goto case 288;
										case 288:
											array5[29] = 99;
											num = 550;
											goto case 550;
										case 476:
											num5 = 88;
											num3 = 148;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 50;
										case 50:
											array4[5] = (byte)num11;
											num3 = 566;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 475:
											array5[5] = (byte)num5;
											num3 = 606;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 472:
											array4[14] = 177;
											goto case 642;
										case 468:
											array5[12] = 180;
											goto case 413;
										case 413:
											num5 = 33;
											goto case 639;
										case 467:
											num11 = 83;
											goto case 558;
										case 465:
											DX7bt5ihQE8BP57y7n(object_2);
											num3 = 448;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 110;
										case 461:
											bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
											goto case 598;
										case 459:
											enumerator = (IEnumerator)B518JUQdx9vQy586iX(object_5);
											goto case 116;
										case 116:
											try
											{
												while (true)
												{
													IL_3381:
													if (!bJbPGvOBTb99N6Yugw(enumerator))
													{
														num29 = 6;
														if (!IranHmBduY2M1rn0mF())
														{
															continue;
														}
														goto IL_331a;
													}
													goto IL_3354;
													IL_3260:
													num29 = num30;
													goto IL_331a;
													IL_3354:
													object_6 = (ProcessModule)FFCROHqCsHxOmTok68(enumerator);
													num29 = 1;
													if (HVnMjPVy0dTk6K1mRH() != null)
													{
														goto IL_3260;
													}
													goto IL_331a;
													IL_331a:
													while (true)
													{
														switch (num29)
														{
														case 10:
															if (!l2QNJyDsc2WV5N9cgV(object_7, object_8))
															{
																goto IL_3381;
															}
															goto case 8;
														case 8:
															if (!F3Y4bl76b1o3UesaHM(object_7, object_9))
															{
																goto IL_3381;
															}
															goto IL_3250;
														case 7:
															break;
														case 5:
															object_7 = new Version(Thu9Sl0Bnf4g19EAxF(lqbmL6HpXROaBHGomn(object_6)), BTTUKBKp46RQNbn4qN(lqbmL6HpXROaBHGomn(object_6)), uwvrRlXXRUYrDCVBqP(lqbmL6HpXROaBHGomn(object_6)), rbJibsFmfPvjNieSQy(lqbmL6HpXROaBHGomn(object_6)));
															num29 = 0;
															if (HVnMjPVy0dTk6K1mRH() == null)
															{
																continue;
															}
															goto default;
														default:
															object_8 = new Version(4, 0, 30319, 17020);
															num29 = 2;
															if (HVnMjPVy0dTk6K1mRH() == null)
															{
																continue;
															}
															goto case 2;
														case 2:
															object_9 = new Version(4, 0, 30319, 17921);
															goto case 10;
														case 1:
															if (!hcLgON2KrqkjPg4VtH(bpxvxHfNvEl2t0p4bW(i9AiaSoPiJRHVKwOc9(object_6)), "clrjit.dll"))
															{
																goto IL_3381;
															}
															goto case 5;
														case 9:
															goto end_IL_331a;
														case 4:
														case 11:
															goto IL_3381;
														case 3:
														case 6:
															goto end_IL_3381;
														}
														PRZkZqsNsa = true;
														num29 = 3;
														if (HVnMjPVy0dTk6K1mRH() == null)
														{
															continue;
														}
														goto IL_3260;
														IL_3250:
														num29 = 7;
														if (IranHmBduY2M1rn0mF())
														{
															continue;
														}
														goto IL_3260;
														continue;
														end_IL_331a:
														break;
													}
													goto IL_3354;
													continue;
													end_IL_3381:
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
														goto IL_339c;
													}
													num31 = 0;
													if (HVnMjPVy0dTk6K1mRH() == null)
													{
														break;
													}
													goto IL_33af;
													IL_33af:
													switch (num31)
													{
													case 2:
														break;
													default:
														goto end_IL_33db;
													case 3:
														continue;
													case 0:
													case 1:
														goto end_IL_33db;
													}
													goto IL_339c;
													IL_339c:
													NpVWiuAKGUyYqmKsx6(disposable);
													num31 = 1;
													if (!IranHmBduY2M1rn0mF())
													{
														num31 = num32;
													}
													goto IL_33af;
													continue;
													end_IL_33db:
													break;
												}
											}
											goto case 379;
										case 456:
											array5[19] = 122;
											goto case 672;
										case 453:
											num27 = mrFXA2ByUMsWbgwLCS2(new IntPtr(num24));
											goto case 305;
										case 451:
											array19 = (array18 = array8);
											if (array19 == null)
											{
												num3 = 460;
												if (IranHmBduY2M1rn0mF())
												{
													continue;
												}
												goto IL_0b01_2;
											}
											goto case 522;
										case 450:
											num27 = 0L;
											goto case 342;
										case 342:
											if (cJ9peUUbuVQT5wKaIB() != 4)
											{
												goto case 640;
											}
											num = 453;
											goto case 453;
										case 448:
											array8 = (byte[])MRB1Ggb30AbIYOUXA1(memoryStream);
											num3 = 394;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 447:
											array10[5] = 116;
											num = 411;
											goto case 411;
										case 411:
											string_ = (string)JUTQe8Btg3H97VDyQBF(RVtYEkBjq51FQBTROnZ(), array10);
											goto case 638;
										case 446:
											array5[6] = (byte)num5;
											goto case 380;
										case 380:
											array5[7] = 138;
											goto case 126;
										case 126:
											num5 = 102;
											num3 = 126;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 346;
										case 346:
											array5[7] = (byte)num5;
											goto case 546;
										case 443:
											array10[4] = 105;
											goto case 447;
										case 439:
											num26 = (nint)(ptr + (nint)num16 * (nint)8);
											*(long*)num26 ^= 940681987L;
											num3 = 261;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 247;
										case 438:
											num11 = 58;
											goto case 283;
										case 283:
											array4[6] = (byte)num11;
											goto case 2;
										case 2:
											array4[6] = 109;
											num3 = 174;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 437:
											array5[27] = 97;
											goto case 494;
										case 436:
											array4[3] = 40;
											goto case 256;
										case 256:
											num11 = 128;
											goto case 512;
										case 435:
											memoryStream = new MemoryStream();
											goto case 299;
										case 299:
											object_2 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
											num3 = 167;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 434:
											num25 = 0;
											num3 = 553;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 433:
											array3 = new byte[12];
											goto case 49;
										case 49:
											array3[0] = 109;
											goto case 217;
										case 217:
											array3[1] = 115;
											num3 = 412;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 432:
											intPtr3 = IntPtr.Zero;
											goto case 502;
										case 421:
											array4[12] = 67;
											num = 128;
											goto case 128;
										case 128:
											array4[12] = 134;
											num3 = 16;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 205;
										case 420:
											array[num9 + 4] = array16[4];
											num3 = 318;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 415:
											array5[8] = 202;
											num3 = 391;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 253;
										case 412:
											array3[2] = 99;
											goto case 560;
										case 409:
											num5 = 51;
											goto case 14;
										case 14:
											array5[25] = (byte)num5;
											num3 = 202;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 569;
										case 408:
											array5[14] = (byte)num5;
											num3 = 132;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 62;
										case 406:
											num5 = 89;
											num3 = 595;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 409;
										case 404:
											num17 += num18;
											goto case 26;
										case 400:
											num11 = 70;
											num3 = 495;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 395:
											intptr_3 = BYk3UMBWdOnNk3h1bnN(object_4);
											goto case 330;
										case 330:
											num24 = 0L;
											goto case 279;
										case 394:
											Tafe6kn7GkmfX3wkZs(array15, 0, array15.Length);
											goto case 138;
										case 138:
											Qgb8YhvMWbR2oRpvia(memoryStream);
											goto case 542;
										case 391:
											array5[8] = 108;
											goto case 182;
										case 182:
											array5[8] = 240;
											num3 = 476;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 389:
											FKefxyB2v6B3QccOFdC(Upxg6OBf9Dp7KTmmDnx(QCdt93B1dmFDakGUb1m(rNZkehfwNu)));
											num3 = 107;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 377;
										case 377:
											array11 = null;
											goto case 335;
										case 335:
											if (cJ9peUUbuVQT5wKaIB() != 4)
											{
												goto case 582;
											}
											goto case 242;
										case 242:
											array17 = new byte[30];
											j94yovBHZC6iNptekrd(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
											array11 = array17;
											num3 = 158;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 387:
											num22 = num17 ^ num14;
											goto case 226;
										case 226:
											num23 = 0;
											goto case 19;
										case 386:
											array4[1] = 108;
											num3 = 362;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 385:
											num5 = 113;
											goto case 559;
										case 383:
											Tafe6kn7GkmfX3wkZs(array14, 0, array14.Length);
											goto case 435;
										case 382:
											array[num9 + 5] = array7[5];
											num3 = 232;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 374:
											array4[9] = 136;
											goto case 664;
										case 372:
											array5[23] = 99;
											goto case 154;
										case 154:
											array5[23] = 47;
											goto case 673;
										case 371:
											bpCbcJjFZWh84qpEv4(new IntPtr(&num19), 0);
											num3 = 576;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 370:
											num21 = array6.Length % 4;
											num3 = 71;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 30;
										case 30:
											array5 = new byte[32];
											goto case 115;
										case 369:
											array15[7] = array9[3];
											num = 645;
											goto case 645;
										case 368:
											num20 = 0;
											goto case 5;
										case 367:
											array4[15] = 216;
											goto case 93;
										case 93:
											array15 = array4;
											goto case 8;
										case 8:
											R43t328wLnqxNjLpAY(array15);
											num3 = 139;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 366:
											array15[5] = array9[2];
											goto case 369;
										case 365:
											num5 = 118;
											num3 = 227;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 362:
											num11 = 50;
											num = 334;
											goto case 334;
										case 334:
											array4[1] = (byte)num11;
											goto case 619;
										case 361:
											array4[2] = 222;
											goto case 551;
										case 359:
											array4[5] = 67;
											goto case 400;
										case 358:
											array4[3] = 155;
											num3 = 321;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 357:
											array4[8] = (byte)num11;
											goto case 134;
										case 134:
											array4[9] = 87;
											goto case 525;
										case 350:
											num11 = 123;
											num3 = 328;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 347:
											array14 = array5;
											goto case 195;
										case 195:
											array4 = new byte[16];
											goto case 59;
										case 59:
											num11 = 165;
											num3 = 529;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 244;
										case 341:
											array4[7] = 167;
											num3 = 320;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 288;
										case 339:
											array5[20] = (byte)num5;
											num = 53;
											goto case 53;
										case 53:
											array5[20] = 169;
											goto case 258;
										case 258:
											num5 = 154;
											goto case 89;
										case 89:
											array5[21] = (byte)num5;
											goto case 309;
										case 309:
											num5 = 90;
											goto case 238;
										case 238:
											array5[21] = (byte)num5;
											num3 = 441;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 637;
										case 333:
											num5 = 32;
											goto case 272;
										case 272:
											array5[26] = (byte)num5;
											goto case 252;
										case 252:
											num5 = 70;
											goto case 513;
										case 332:
											array5[6] = (byte)num5;
											num3 = 75;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 214;
										case 214:
											num5 = 65;
											goto case 446;
										case 329:
											array10[2] = 116;
											num = 52;
											goto case 52;
										case 52:
											array10[3] = 74;
											num3 = 346;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 443;
										case 328:
											array4[7] = (byte)num11;
											goto case 341;
										case 327:
											if (array9.Length <= 0)
											{
												goto case 548;
											}
											goto case 90;
										case 90:
											array15[1] = array9[0];
											goto case 159;
										case 159:
											array15[3] = array9[1];
											goto case 366;
										case 326:
											array5[19] = (byte)num5;
											goto case 424;
										case 324:
											array5[25] = 162;
											num3 = 385;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 321:
											num11 = 187;
											num3 = 59;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 165;
										case 320:
											array4[7] = 147;
											num3 = 275;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 516;
										case 319:
											array5[28] = (byte)num5;
											goto case 478;
										case 318:
											array[num9 + 5] = array16[5];
											goto case 164;
										case 164:
											array[num9 + 6] = array16[6];
											goto case 274;
										case 274:
											array[num9 + 7] = array16[7];
											num3 = 231;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 312:
											transform = (ICryptoTransform)xJBO9UxqXvUp7hcPMc(object_3, array14, array15);
											num3 = 56;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												continue;
											}
											goto case 383;
										case 308:
											num5 = 130;
											num = 22;
											goto case 22;
										case 22:
											array5[13] = (byte)num5;
											goto case 168;
										case 168:
											num5 = 19;
											num3 = 260;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 306:
											mTfoQqVbOE(intptr_, intPtr4, (byte[])gsLPImwN0YqwQaIieQ(dfS4ULclYXZYwSkxBX(object_)), 4u, out intptr_2);
											goto case 268;
										case 268:
										case 298:
											YeeoMqaS3J(intPtr4, 4, int_, ref int_);
											goto case 531;
										case 304:
											array4[0] = 155;
											goto case 593;
										case 303:
											jDNkifbo3S = false;
											goto case 302;
										case 297:
											array12 = (byte[])AEygtYdaRrAdRQSUdC(object_, (int)hnqKsEMJyigELtAMsm(jdn14iPZJbNEoRhq7K(object_)));
											goto case 30;
										case 296:
											array3[2] = 114;
											num3 = 42;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 295:
											array5[4] = (byte)num5;
											num3 = 56;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 8;
										case 294:
											num19 = 0L;
											goto case 196;
										case 196:
											YmOgPart3dfqVhfdMZ(new IntPtr(&num19), 0);
											goto case 245;
										case 245:
											ncWBLwZGol46cEuaFy(new IntPtr(&num19), 0);
											num3 = 371;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 291:
											array[num9 + 3] = array7[3];
											goto case 92;
										case 92:
											array[num9 + 4] = array7[4];
											goto case 382;
										case 289:
											int_2 = 0;
											num3 = 506;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 285:
											num5 = 73;
											num3 = 326;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 284:
											array4[2] = (byte)num11;
											goto case 361;
										case 280:
											if (cJ9peUUbuVQT5wKaIB() != 4)
											{
												goto case 433;
											}
											num3 = 0;
											if (!IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 3;
										case 3:
											wpoklx4RIX = MgcOqsBZRp8lpkejivL(eXJkjmTXDX);
											num = 433;
											goto case 433;
										case 276:
											array5[9] = 116;
											goto case 233;
										case 233:
											num5 = 92;
											goto case 490;
										case 275:
											array4[15] = (byte)num11;
											goto case 338;
										case 269:
											num17 = 0u;
											num = 192;
											goto case 192;
										case 192:
											num18 = 0u;
											num3 = 204;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 263:
											array5[31] = 0;
											num = 347;
											goto case 347;
										case 261:
											num16++;
											goto case 178;
										case 178:
										case 187:
											if (num16 >= num10)
											{
												goto end_IL_0be3;
											}
											goto case 439;
										case 260:
											array5[13] = (byte)num5;
											goto case 78;
										case 78:
											array5[14] = 115;
											goto case 211;
										case 211:
											num5 = 148;
											num3 = 408;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 257:
											num15 = array14.Length / 4;
											num3 = 269;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 75;
										case 255:
											array2 = (byte[])xUqmogBqDnQuhXU4Zbm(intPtr3.ToInt64());
											goto case 589;
										case 239:
											array4[13] = 180;
											goto case 467;
										case 235:
											array5[19] = 160;
											goto case 106;
										case 232:
											array[num9 + 6] = array7[6];
											num3 = 124;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 231:
											num9 = 30;
											goto case 657;
										case 230:
											num5 = 130;
											goto case 339;
										case 227:
											array5[24] = (byte)num5;
											num = 526;
											goto case 526;
										case 225:
											array5[24] = 54;
											num3 = 409;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 220:
											array5[24] = (byte)num5;
											goto case 225;
										case 216:
											array5[30] = 148;
											num3 = 163;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 10;
										case 215:
											num5 = 160;
											goto case 483;
										case 213:
											array5[26] = (byte)num5;
											goto case 241;
										case 204:
											num14 = 0u;
											goto case 668;
										case 200:
											array5[25] = 126;
											num3 = 113;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 89;
										case 198:
											array4[7] = 165;
											num3 = 350;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 194:
											array4[5] = (byte)num11;
											goto case 64;
										case 64:
											num11 = 97;
											num3 = 50;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 188:
											num5 = 160;
											num3 = 539;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 16;
										case 181:
											array13[num12 + 2] = (byte)((num13 & 0xFF0000) >> 16);
											goto case 135;
										case 135:
											array13[num12 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
											goto case 43;
										case 180:
											array4[4] = 96;
											goto case 12;
										case 12:
											num11 = 155;
											goto case 194;
										case 174:
											array4[6] = 112;
											goto case 74;
										case 74:
											array4[6] = 209;
											num3 = 82;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 173:
											array5[17] = 188;
											num3 = 612;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 170:
											num6++;
											goto case 254;
										case 167:
											BYbNk6uQOTrlRVlp4l(object_2, array12, 0, array12.Length);
											num3 = 465;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 163:
											array5[31] = 112;
											goto case 48;
										case 48:
											array5[31] = 149;
											goto case 263;
										case 160:
											array4[1] = 205;
											num = 386;
											goto case 386;
										case 79:
										case 158:
											intPtr2 = ECNpoZB0MZh1a20aSda(IntPtr.Zero, (uint)array11.Length, 4096u, 64u);
											goto case 588;
										case 155:
											array4[15] = 89;
											num = 367;
											goto case 367;
										case 153:
											array5[19] = (byte)num5;
											goto case 285;
										case 150:
											array5[4] = 120;
											num3 = 620;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 148:
											array5[8] = (byte)num5;
											num3 = 602;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto case 484;
										case 147:
											array10[0] = 103;
											goto case 604;
										case 141:
											num5 = 154;
											goto case 24;
										case 24:
											array5[9] = (byte)num5;
											num3 = 276;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 139:
											array9 = (byte[])pkfoilel9V8ZGdoB14(bZdhSXLCcaLc1ssp6f(x4Dk2IHVmX));
											goto case 32;
										case 32:
											if (array9 == null)
											{
												goto case 548;
											}
											goto case 327;
										case 133:
											array5[10] = (byte)num5;
											goto case 650;
										case 130:
											array5[22] = (byte)num5;
											goto case 491;
										case 125:
											num10 = array8.Length / 8;
											goto case 451;
										case 124:
											array[num9 + 7] = array7[7];
											goto case 545;
										case 114:
											array5[2] = 82;
											goto case 633;
										case 113:
											array5[25] = 140;
											goto case 324;
										case 111:
											array5[1] = (byte)num5;
											goto case 563;
										case 98:
											num5 = 59;
											num3 = 111;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 86:
											array3[1] = 108;
											goto case 296;
										case 82:
											array4[6] = 75;
											goto case 57;
										case 57:
											array4[7] = 153;
											goto case 198;
										case 80:
											text = (string)JUTQe8Btg3H97VDyQBF(RVtYEkBjq51FQBTROnZ(), array3);
											goto case 666;
										case 76:
											intptr_ = ry5y1qELZwKGh4kc2G((uint)uint_, 1, (uint)pQVRLkmZcRKuneKJ9V(cxyU4ysr5cXjtnBlE3()));
											goto case 609;
										case 71:
											num8 = array6.Length / 4;
											num = 497;
											goto case 497;
										case 61:
											num5 = 119;
											num3 = 575;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto IL_0b01_2;
										case 56:
											array5[4] = 179;
											goto case 150;
										case 54:
											num7++;
											goto case 351;
										case 46:
											num6 = 0;
											num3 = 254;
											if (IranHmBduY2M1rn0mF())
											{
												continue;
											}
											goto IL_0b01_2;
										case 45:
											MhUL1X3vdKIRoiAZ2h(jdn14iPZJbNEoRhq7K(object_), 0L);
											goto case 297;
										case 44:
											array5[19] = (byte)num5;
											num3 = 235;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 33;
										case 33:
											array5[5] = (byte)num5;
											goto case 538;
										case 42:
											array3[3] = 106;
											goto case 631;
										case 39:
											URnkCOceLK = intPtr.ToInt64();
											goto case 532;
										case 23:
											array5[18] = (byte)num5;
											goto case 456;
										case 4:
											array4[13] = 87;
											goto case 239;
										case 1:
											array3[7] = 116;
											goto case 515;
										case 38:
											fyt6ByBojUirf8waGTH(abxkLGOVrU);
											num = 63;
											goto case 63;
										case 218:
											abxkLGOVrU = null;
											goto case 352;
										case 197:
											Fxa684CVyKutPq73Q5();
											return;
										case 127:
											KZYVnCBB92eTU8T5RpR(intptr_);
											goto case 210;
										case 210:
											Fxa684CVyKutPq73Q5();
											return;
										case 186:
											return;
										case 621:
											array[num4] = array2[0];
											goto case 331;
										case 331:
											array[num4 + 1] = array2[1];
											num = 354;
											goto case 354;
										case 354:
											array[num4 + 2] = array2[2];
											num = 557;
											goto case 557;
										case 557:
											array[num4 + 3] = array2[3];
											num = 670;
											goto case 277;
										case 222:
											Fxa684CVyKutPq73Q5();
											return;
										case 364:
											return;
										case 585:
											return;
										case 228:
											array[num9 + 7] = array2[7];
											goto case 277;
										case 277:
										case 670:
											v56v3vyckQQddrak5e(array, 0, intPtr2, array.Length);
											goto case 9;
										case 9:
											xo4kuDarJK = false;
											goto case 144;
										case 144:
											YeeoMqaS3J(new IntPtr(num24), cJ9peUUbuVQT5wKaIB(), 64, ref int_2);
											goto case 250;
										case 250:
											ScVT1hBKJMZIABp9D7p(new IntPtr(num24), intPtr2);
											goto case 571;
										case 571:
											YeeoMqaS3J(new IntPtr(num24), cJ9peUUbuVQT5wKaIB(), int_2, ref int_2);
											num = 615;
											goto case 428;
										case 428:
										case 615:
											Fxa684CVyKutPq73Q5();
											return;
										case 190:
											return;
											IL_18d2:
											if (cJ9peUUbuVQT5wKaIB() == 4)
											{
												goto case 83;
											}
											goto case 379;
										}
										break;
									}
									goto end_IL_0bed;
									IL_0c19:
									YmOgPart3dfqVhfdMZ(intptr_3, 0);
									goto IL_0c22;
									IL_0c22:
									rNZkehfwNu = NvQ34uZt895nxEhi2FIr;
									num3 = 432;
									if (HVnMjPVy0dTk6K1mRH() == null)
									{
										goto IL_002f_3;
									}
									goto IL_0c43;
									IL_0c43:
									array5[10] = 130;
									goto IL_0bc8;
									end_IL_0bed:;
								}
								continue;
								end_IL_0be3:
								break;
							}
							goto case 635;
						case 65:
						case 427:
							num16 = 0;
							num3 = 178;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 117;
						case 117:
							num24 = sEy60yBpTjAqfsuVmDE(intptr_3);
							goto case 353;
						case 353:
						case 401:
							YmOgPart3dfqVhfdMZ(intptr_3, 0);
							goto case 378;
						case 378:
							rNZkehfwNu = NvQ34uZt895nxEhi2FIr;
							num3 = 432;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 99;
						case 99:
							array5[10] = 130;
							goto case 671;
						case 668:
							if (num21 > 0)
							{
								goto case 552;
							}
							goto case 665;
						case 552:
							num8++;
							num3 = 665;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 494;
						case 494:
							array5[27] = 68;
							goto case 418;
						case 418:
							num5 = 118;
							goto case 112;
						case 112:
							array5[28] = (byte)num5;
							num = 293;
							goto case 293;
						case 293:
							array5[28] = 90;
							goto case 625;
						case 625:
							num5 = 86;
							num3 = 319;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 665:
							num43 = 0u;
							num3 = 434;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 667:
							array5[10] = (byte)num5;
							num3 = 117;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 142;
						case 142:
							num5 = 159;
							goto case 630;
						case 630:
							array5[10] = (byte)num5;
							num = 162;
							goto case 162;
						case 162:
							array5[11] = 92;
							goto case 157;
						case 157:
							array5[11] = 118;
							goto case 470;
						case 470:
							array5[11] = 175;
							goto case 20;
						case 20:
							array5[11] = 218;
							goto case 15;
						case 15:
							num5 = 128;
							num = 498;
							goto case 498;
						case 498:
							array5[12] = (byte)num5;
							goto case 572;
						case 572:
							array5[12] = 147;
							goto case 191;
						case 191:
							array5[12] = 106;
							goto case 322;
						case 322:
							array5[12] = 100;
							num = 504;
							goto case 504;
						case 504:
							array5[12] = 76;
							num3 = 468;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 666:
							intptr_6 = LoadLibrary(text);
							goto case 644;
						case 644:
							if (!fUZvZnBIo0QGMdkuqwx(intptr_6, IntPtr.Zero))
							{
								num3 = 623;
								if (HVnMjPVy0dTk6K1mRH() == null)
								{
									continue;
								}
								goto case 101;
							}
							goto case 95;
						case 101:
							array5[17] = 115;
							goto case 246;
						case 246:
							array5[17] = 167;
							num3 = 188;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 95:
							array3 = new byte[10];
							goto case 360;
						case 360:
							array3[0] = 99;
							num3 = 86;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 664:
							num11 = 86;
							num3 = 332;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 648;
						case 648:
							array4[9] = (byte)num11;
							goto case 183;
						case 183:
							num11 = 79;
							goto case 527;
						case 527:
							array4[10] = (byte)num11;
							goto case 431;
						case 431:
							num11 = 124;
							goto case 189;
						case 189:
							array4[10] = (byte)num11;
							goto case 247;
						case 247:
							array4[10] = 132;
							goto case 307;
						case 307:
							array4[10] = 124;
							goto case 266;
						case 266:
							array4[11] = 93;
							goto case 519;
						case 519:
							array4[11] = 139;
							goto case 564;
						case 564:
							num11 = 92;
							goto case 10;
						case 10:
							array4[11] = (byte)num11;
							goto case 58;
						case 58:
							array4[11] = 118;
							goto case 518;
						case 518:
							array4[11] = 194;
							num3 = 658;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 663:
							num5 = 84;
							num3 = 295;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 662:
							array2 = (byte[])gsLPImwN0YqwQaIieQ(intPtr3.ToInt32());
							num = 223;
							goto case 223;
						case 223:
							array16 = (byte[])gsLPImwN0YqwQaIieQ(MgcOqsBZRp8lpkejivL(num27));
							goto case 398;
						case 398:
						case 547:
							if (cJ9peUUbuVQT5wKaIB() == 4)
							{
								goto case 278;
							}
							goto case 423;
						case 278:
							num4 = 9;
							num3 = 544;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 81;
						case 81:
							array3[11] = 108;
							num3 = 80;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 60;
						case 60:
							array[num9] = array16[0];
							num3 = 577;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 279;
						case 279:
							if (cJ9peUUbuVQT5wKaIB() != 4)
							{
								goto case 117;
							}
							goto case 311;
						case 311:
							num24 = mrFXA2ByUMsWbgwLCS2(intptr_3);
							num3 = 353;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 243;
						case 243:
							num28 = 0;
							num3 = 574;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 423:
							num9 = 2;
							goto case 485;
						case 485:
							array[num9] = array7[0];
							goto case 649;
						case 649:
							array[num9 + 1] = array7[1];
							goto case 414;
						case 414:
							array[num9 + 2] = array7[2];
							num3 = 291;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 661:
							intptr_6 = LoadLibrary(text);
							num3 = 118;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 26;
						case 26:
							num14 = 0u;
							num3 = 368;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 659:
							if (num21 > 0)
							{
								num3 = 404;
								if (HVnMjPVy0dTk6K1mRH() == null)
								{
									continue;
								}
								goto IL_0b01;
							}
							goto case 21;
						case 21:
							num43 = (uint)num12;
							goto case 68;
						case 68:
							num17 += num18;
							num3 = 654;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 658:
							num11 = 130;
							num3 = 74;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 108;
						case 108:
							array4[12] = (byte)num11;
							num3 = 421;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 657:
							array[num9] = array2[0];
							goto case 344;
						case 344:
							array[num9 + 1] = array2[1];
							goto case 143;
						case 143:
							array[num9 + 2] = array2[2];
							goto case 487;
						case 487:
							array[num9 + 3] = array2[3];
							goto case 534;
						case 534:
							array[num9 + 4] = array2[4];
							goto case 72;
						case 72:
							array[num9 + 5] = array2[5];
							goto case 584;
						case 584:
							array[num9 + 6] = array2[6];
							num3 = 83;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 228;
						case 656:
							num11 = 105;
							goto case 462;
						case 462:
							array4[13] = (byte)num11;
							num3 = 4;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 655:
							array4[4] = (byte)num11;
							goto case 166;
						case 166:
							num11 = 121;
							num3 = 594;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 241;
						case 241:
							array5[27] = 166;
							num3 = 437;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 165;
						case 165:
							array4[3] = (byte)num11;
							num3 = 171;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 249;
						case 249:
							array4[3] = 62;
							num3 = 436;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 654:
							num14 = (uint)((array6[num43 + 3] << 24) | (array6[num43 + 2] << 16) | (array6[num43 + 1] << 8) | array6[num43]);
							num3 = 507;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 424;
						case 424:
							num5 = 110;
							num3 = 44;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 652:
							fyt6ByBojUirf8waGTH(rNZkehfwNu);
							num3 = 389;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 651:
							array5[21] = 223;
							num3 = 196;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 624;
						case 624:
							array5[22] = 95;
							goto case 646;
						case 646:
							num5 = 137;
							num3 = 130;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 650:
							num5 = 132;
							goto case 480;
						case 480:
							array5[10] = (byte)num5;
							goto case 641;
						case 641:
							num5 = 85;
							num3 = 667;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 647:
							array3[9] = 100;
							goto case 66;
						case 66:
							array3[10] = 108;
							goto case 81;
						case 645:
							array15[9] = array9[4];
							num3 = 500;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 643:
							num5 = 109;
							num3 = 332;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 642:
							array4[15] = 136;
							goto case 596;
						case 596:
							array4[15] = 167;
							goto case 632;
						case 632:
							num11 = 18;
							num3 = 275;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 640:
							num27 = sEy60yBpTjAqfsuVmDE(new IntPtr(num24));
							num3 = 43;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 305;
						case 305:
						case 622:
							object_11 = (Process)cxyU4ysr5cXjtnBlE3();
							num = 253;
							goto case 253;
						case 253:
							try
							{
								ProcessModuleCollection object_12 = (ProcessModuleCollection)ttvIdokYconnO4LVWq(object_11);
								while (true)
								{
									enumerator = (IEnumerator)B518JUQdx9vQy586iX(object_12);
									num55 = 0;
									if (HVnMjPVy0dTk6K1mRH() != null)
									{
										switch (num55)
										{
										case 2:
											continue;
										default:
											goto end_IL_1361_2;
										case 1:
											break;
										case 0:
											goto end_IL_1361_2;
										}
									}
									try
									{
										while (true)
										{
											if (bJbPGvOBTb99N6Yugw(enumerator))
											{
												while (true)
												{
													IL_1481_2:
													ProcessModule object_13 = (ProcessModule)FFCROHqCsHxOmTok68(enumerator);
													num56 = 7;
													if (!IranHmBduY2M1rn0mF())
													{
														goto IL_1401_2;
													}
													goto IL_1452_3;
													IL_1452_3:
													while (true)
													{
														switch (num56)
														{
														case 9:
															if (mi0ZPSB5hpsekQ9TG9R(iS7hDVB6I71dk8Dg2Yx(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
															{
																break;
															}
															num56 = 6;
															if (HVnMjPVy0dTk6K1mRH() == null)
															{
																continue;
															}
															goto IL_13c0_2;
														case 4:
															break;
														case 7:
															if (!hcLgON2KrqkjPg4VtH(i9AiaSoPiJRHVKwOc9(object_13), text))
															{
																goto end_IL_1481_2;
															}
															num56 = 0;
															if (HVnMjPVy0dTk6K1mRH() == null)
															{
																continue;
															}
															goto IL_13c0_2;
														case 3:
															goto IL_1401_2;
														default:
															num57 = num27;
															intPtr = Lr1j2P6qwxWXaUmjO1(object_13);
															if (num57 < intPtr.ToInt64())
															{
																goto case 9;
															}
															num58 = 3;
															goto IL_1401_2;
														case 5:
															goto IL_1481_2;
														case 2:
														case 6:
															goto end_IL_1481_2;
														case 8:
															goto end_IL_14a1_2;
														case 1:
															return;
															IL_13c0_2:
															num56 = num58;
															continue;
														}
														break;
													}
													goto IL_13c9_2;
													IL_1401_2:
													num59 = num27;
													intPtr = Lr1j2P6qwxWXaUmjO1(object_13);
													if (num59 <= intPtr.ToInt64() + eBcGpaBaISUEEGPx55c(object_13))
													{
														break;
													}
													num56 = 9;
													if (HVnMjPVy0dTk6K1mRH() != null)
													{
														goto IL_13c9_2;
													}
													goto IL_1452_3;
													IL_13c9_2:
													Fxa684CVyKutPq73Q5();
													num56 = 1;
													if (IranHmBduY2M1rn0mF())
													{
														return;
													}
													goto IL_1452_3;
													continue;
													end_IL_1481_2:
													break;
												}
												continue;
											}
											num58 = 8;
											break;
											continue;
											end_IL_14a1_2:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator as IDisposable;
										num60 = 1;
										if (!IranHmBduY2M1rn0mF())
										{
											num60 = num61;
										}
										switch (num60)
										{
										case 1:
											if (disposable != null)
											{
												break;
											}
											goto end_IL_14bb_2;
										case 2:
										case 3:
											goto end_IL_14bb_2;
										}
										NpVWiuAKGUyYqmKsx6(disposable);
										num61 = 3;
										end_IL_14bb_2:;
									}
									break;
									continue;
									end_IL_1361_2:
									break;
								}
							}
							catch (object obj3)
							{
								num62 = 0;
								if (!IranHmBduY2M1rn0mF())
								{
									num62 = num63;
								}
								switch (num62)
								{
								}
							}
							goto case 356;
						case 356:
							try
							{
								ProcessModuleCollection object_14 = (ProcessModuleCollection)ttvIdokYconnO4LVWq(object_11);
								num64 = 0;
								if (HVnMjPVy0dTk6K1mRH() != null)
								{
									goto IL_154e_2;
								}
								goto IL_1552_3;
								IL_1552_3:
								while (true)
								{
									switch (num64)
									{
									case 1:
										try
										{
											while (bJbPGvOBTb99N6Yugw(enumerator))
											{
												while (true)
												{
													ProcessModule object_15 = (ProcessModule)FFCROHqCsHxOmTok68(enumerator);
													while (true)
													{
														intPtr = Lr1j2P6qwxWXaUmjO1(object_15);
														num65 = 0;
														if (!IranHmBduY2M1rn0mF())
														{
															goto IL_157a_2;
														}
														goto IL_158a_2;
														IL_158a_2:
														switch (num65)
														{
														case 3:
															break;
														default:
															goto IL_157a_2;
														case 4:
															continue;
														case 6:
															goto end_IL_15ad_2;
														case 2:
															goto end_IL_15c5_2;
														case 1:
														case 5:
															goto end_IL_15d5_2;
														}
														goto IL_1569_2;
														IL_157a_2:
														if (intPtr.ToInt64() != eXJkjmTXDX)
														{
															goto end_IL_15c5_2;
														}
														goto IL_1569_2;
														IL_1569_2:
														num28 = 0;
														num65 = 1;
														if (HVnMjPVy0dTk6K1mRH() == null)
														{
															goto end_IL_15d5_2;
														}
														goto IL_158a_2;
														continue;
														end_IL_15ad_2:
														break;
													}
													continue;
													end_IL_15c5_2:
													break;
												}
												continue;
												end_IL_15d5_2:
												break;
											}
										}
										finally
										{
											IDisposable disposable = enumerator as IDisposable;
											num66 = 0;
											if (HVnMjPVy0dTk6K1mRH() != null)
											{
												goto IL_1615_2;
											}
											goto IL_1628_3;
											IL_1628_3:
											while (true)
											{
												switch (num66)
												{
												case 2:
													goto IL_15fb_2;
												case 1:
													goto end_IL_1628_2;
												}
												goto IL_1615_2;
												IL_15fb_2:
												NpVWiuAKGUyYqmKsx6(disposable);
												num66 = 1;
												if (IranHmBduY2M1rn0mF())
												{
													continue;
												}
												goto IL_160f_2;
												continue;
												end_IL_1628_2:
												break;
											}
											goto end_IL_15e3_2;
											IL_160f_2:
											num66 = num67;
											goto IL_1628_3;
											IL_1615_2:
											if (disposable != null)
											{
												num66 = 2;
												if (HVnMjPVy0dTk6K1mRH() != null)
												{
													goto IL_160f_2;
												}
												goto IL_1628_3;
											}
											end_IL_15e3_2:;
										}
										goto end_IL_1552_2;
									case 2:
										goto end_IL_1552_2;
									}
									enumerator = (IEnumerator)B518JUQdx9vQy586iX(object_14);
									num64 = 1;
									if (IranHmBduY2M1rn0mF())
									{
										continue;
									}
									goto IL_154e_2;
									continue;
									end_IL_1552_2:
									break;
								}
								goto end_IL_1520_2;
								IL_154e_2:
								num64 = num68;
								goto IL_1552_3;
								end_IL_1520_2:;
							}
							catch (object obj4)
							{
								num69 = 0;
								if (HVnMjPVy0dTk6K1mRH() == null)
								{
									switch (num69)
									{
									}
								}
							}
							goto case 218;
						case 352:
							try
							{
								abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)RapOAnBSklV8JMw1wES(new IntPtr(num27), VW2d8fBr2cnP3KQh480(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
								num70 = 0;
								if (IranHmBduY2M1rn0mF())
								{
									switch (num70)
									{
									}
								}
							}
							catch (object obj6)
							{
								num71 = 1;
								if (!IranHmBduY2M1rn0mF())
								{
									switch (num71)
									{
									default:
										goto end_IL_169d_2;
									case 1:
										break;
									case 0:
										goto end_IL_169d_2;
									}
								}
								try
								{
									Delegate object_16 = (Delegate)RapOAnBSklV8JMw1wES(new IntPtr(num27), VW2d8fBr2cnP3KQh480(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
									num72 = 0;
									if (HVnMjPVy0dTk6K1mRH() == null)
									{
										goto IL_16e5_2;
									}
									goto IL_1716_2;
									IL_1716_2:
									switch (num72)
									{
									case 1:
										goto end_IL_16c0_2;
									}
									goto IL_16e5_2;
									IL_16e5_2:
									abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)AD8IHcBCAaY9dSgQ0ZU(VW2d8fBr2cnP3KQh480(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle), QCdt93B1dmFDakGUb1m(object_16));
									num72 = 1;
									if (HVnMjPVy0dTk6K1mRH() != null)
									{
										num72 = num73;
									}
									goto IL_1716_2;
									end_IL_16c0_2:;
								}
								catch (object obj5)
								{
									num74 = 0;
									if (HVnMjPVy0dTk6K1mRH() != null)
									{
										switch (num74)
										{
										default:
											goto end_IL_1727_2;
										}
									}
									end_IL_1727_2:;
								}
								end_IL_169d_2:;
							}
							goto case 445;
						case 445:
							num3 = 289;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 639:
							array5[13] = (byte)num5;
							num = 221;
							goto case 221;
						case 221:
							array5[13] = 126;
							num3 = 308;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 638:
							procAddress = GetProcAddress(intptr_6, string_);
							num3 = 484;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 286;
						case 286:
							array5[3] = 164;
							num3 = 94;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 637:
							num5 = 112;
							goto case 184;
						case 184:
							array5[21] = (byte)num5;
							goto case 16;
						case 16:
							array5[21] = 144;
							goto case 651;
						case 636:
							text = (string)JUTQe8Btg3H97VDyQBF(RVtYEkBjq51FQBTROnZ(), array3);
							goto case 661;
						case 635:
							reference = ref *(byte*)null;
							goto case 287;
						case 287:
							object_ = new VtNVUKGulysZw81C3E(new MemoryStream(array8));
							goto case 37;
						case 37:
							MhUL1X3vdKIRoiAZ2h(jdn14iPZJbNEoRhq7K(object_), 0L);
							goto case 103;
						case 103:
							intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(x4Dk2IHVmX))[0]);
							goto case 627;
						case 627:
							num38 = intPtr.ToInt64();
							goto case 510;
						case 510:
							int_ = 0;
							goto case 243;
						case 634:
							QkvmIESAUb9sUU9VCC(new IntPtr(&num19), 0, 0L);
							num = 509;
							goto case 509;
						case 509:
							array18 = new byte[1];
							goto case 626;
						case 626:
							v56v3vyckQQddrak5e(array18, 0, FPU4nCWw4KJ9qdkx0G(8), 1);
							goto case 219;
						case 219:
							WtHracpsmgqsF8ATcR();
							goto case 425;
						case 425:
							if (num2 == 4109628145u)
							{
								goto case 570;
							}
							goto IL_18d2_2;
						case 570:
							flag = AAcXkN1Fay6mj1qY2b(kBgS1l5QwoacVPMLeo(Lr1j2P6qwxWXaUmjO1(LLWROkacydNSnOqVyt(cxyU4ysr5cXjtnBlE3())), "__", 10u), IntPtr.Zero);
							num = 51;
							goto case 51;
						case 51:
							if (flag)
							{
								goto IL_18d2_2;
							}
							goto case 222;
						case 83:
							if (is2epJ9ZPSV6MHPvX5(xCCDxhhDGNiYw9Z67H("System.Reflection.ReflectionContext", bool_0: false), null))
							{
								goto case 479;
							}
							goto case 379;
						case 479:
							object_5 = (ProcessModuleCollection)ttvIdokYconnO4LVWq(cxyU4ysr5cXjtnBlE3());
							num3 = 459;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 115;
						case 115:
							array5[0] = 120;
							goto case 136;
						case 136:
							array5[0] = 134;
							num3 = 599;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 379:
							object_ = new VtNVUKGulysZw81C3E((Stream)WZvgFyRvmx5f8718jT(x4Dk2IHVmX, "MmpydemxQXtr071PFr.3wVOUuoo8EuDgyy0xT"));
							num3 = 45;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 633:
							num5 = 82;
							goto case 511;
						case 511:
							array5[2] = (byte)num5;
							goto case 313;
						case 313:
							num5 = 51;
							goto case 314;
						case 314:
							array5[2] = (byte)num5;
							goto case 410;
						case 410:
							array5[3] = 30;
							num = 397;
							goto case 397;
						case 397:
							array5[3] = 132;
							goto case 617;
						case 617:
							array5[3] = 199;
							goto case 286;
						case 631:
							array3[4] = 105;
							goto case 608;
						case 608:
							array3[5] = 116;
							goto case 430;
						case 430:
							array3[6] = 46;
							goto case 251;
						case 251:
							array3[7] = 100;
							goto case 440;
						case 440:
							array3[8] = 108;
							goto case 169;
						case 169:
							array3[9] = 108;
							goto case 636;
						case 629:
							array4[15] = (byte)num11;
							num3 = 155;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 628:
							XtMknffM5M = intPtr.ToInt32();
							goto case 29;
						case 29:
							intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(x4Dk2IHVmX))[0]);
							num3 = 39;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 118:
						case 623:
							array10 = new byte[6];
							num3 = 147;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 620:
							array5[5] = 170;
							goto case 11;
						case 11:
							array5[5] = 155;
							goto case 496;
						case 496:
							num5 = 97;
							num3 = 33;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 619:
							num11 = 87;
							goto case 281;
						case 281:
							array4[2] = (byte)num11;
							num3 = 561;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 302:
						case 616:
							if (g5t6XmzTB7McRy9hy4(jdn14iPZJbNEoRhq7K(object_)) < hnqKsEMJyigELtAMsm(jdn14iPZJbNEoRhq7K(object_)) - 1L)
							{
								goto case 488;
							}
							goto case 237;
						case 488:
							num39 = dfS4ULclYXZYwSkxBX(object_) - num28;
							num3 = 287;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 581;
						case 581:
							num54 = dfS4ULclYXZYwSkxBX(object_);
							goto case 104;
						case 104:
							jDNkifbo3S = false;
							goto case 469;
						case 469:
							if (num54 >= 1879048192)
							{
								goto case 392;
							}
							goto case 348;
						case 392:
							jDNkifbo3S = true;
							num3 = 348;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 348:
							int_3 = dfS4ULclYXZYwSkxBX(object_);
							num = 381;
							goto case 381;
						case 381:
							jsbkrdexts = (byte[])AEygtYdaRrAdRQSUdC(object_, int_3);
							num3 = 461;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 458;
						case 458:
							array4[3] = (byte)num11;
							num3 = 358;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 237:
							intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))[0]);
							goto case 27;
						case 27:
							eXJkjmTXDX = intPtr.ToInt64();
							num3 = 280;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 614:
							array5[16] = 86;
							num3 = 395;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 452;
						case 452:
							array5[16] = 144;
							num3 = 51;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 62;
						case 62:
							num5 = 211;
							goto case 185;
						case 185:
							array5[16] = (byte)num5;
							num3 = 173;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 613:
							BJCwZN4chYfp322mb0(object_);
							goto case 492;
						case 492:
							num36 = dfS4ULclYXZYwSkxBX(object_);
							goto case 7;
						case 7:
							num51 = dfS4ULclYXZYwSkxBX(object_);
							goto case 349;
						case 349:
							if (num51 == 1)
							{
								goto case 84;
							}
							num7 = 0;
							num = 351;
							goto case 351;
						case 84:
							intptr_ = IntPtr.Zero;
							num = 18;
							goto case 18;
						case 18:
							uint_ = (AwgKvrHJUS3TxryUsj)56;
							num3 = 76;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 351:
						case 363:
							if (num7 >= num36)
							{
								num = 482;
								goto case 482;
							}
							goto case 300;
						case 482:
							lmdkVksVkh = new Hashtable(dfS4ULclYXZYwSkxBX(object_) + 1);
							num3 = 10;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 31;
						case 31:
							bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
							goto case 355;
						case 355:
							reference3 = ref bIpvxRBRb2dOGl802m2;
							array18 = new byte[1] { 42 };
							reference3.jsbkrdexts = array18;
							num3 = 56;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 290;
						case 290:
							bIpvxRBRb2dOGl802m2.JDNkifbo3S = false;
							num = 586;
							goto case 586;
						case 586:
							Q0ZYP9BVNnFw8WUuZEb(lmdkVksVkh, 0L, bIpvxRBRb2dOGl802m2);
							num3 = 303;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 300:
							intptr_4 = new IntPtr(num38 + dfS4ULclYXZYwSkxBX(object_) - num28);
							num = 384;
							goto case 384;
						case 384:
							YeeoMqaS3J(intptr_4, 4, 4, ref int_);
							num3 = 37;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 123;
						case 123:
							zgruAFBGT2tfklaxaKW(intptr_4, dfS4ULclYXZYwSkxBX(object_));
							num3 = 207;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 612:
							array5[17] = 131;
							goto case 101;
						case 611:
							array5[4] = (byte)num5;
							goto case 663;
						case 254:
						case 610:
							if (num6 >= num52)
							{
								num = 503;
								goto case 503;
							}
							goto case 473;
						case 503:
							YeeoMqaS3J(intptr_5, num52 * 4, int_, ref int_);
							goto case 229;
						case 229:
						case 402:
							if (g5t6XmzTB7McRy9hy4(jdn14iPZJbNEoRhq7K(object_)) < hnqKsEMJyigELtAMsm(jdn14iPZJbNEoRhq7K(object_)) - 1L)
							{
								goto case 234;
							}
							goto case 127;
						case 234:
							num53 = dfS4ULclYXZYwSkxBX(object_);
							goto case 442;
						case 442:
							intptr_5 = new IntPtr(URnkCOceLK + num53 - num28);
							goto case 208;
						case 208:
							num52 = dfS4ULclYXZYwSkxBX(object_);
							goto case 105;
						case 105:
							YeeoMqaS3J(intptr_5, num52 * 4, 4, ref int_);
							num3 = 46;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 473:
							zgruAFBGT2tfklaxaKW(new IntPtr(intptr_5.ToInt64() + num6 * 4), dfS4ULclYXZYwSkxBX(object_));
							num3 = 170;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 132;
						case 132:
							array5[14] = 51;
							goto case 390;
						case 390:
							array5[15] = 54;
							goto case 568;
						case 568:
							array5[15] = 131;
							goto case 240;
						case 240:
							array5[15] = 167;
							num3 = 406;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 609:
							if (cJ9peUUbuVQT5wKaIB() != 4)
							{
								goto case 29;
							}
							goto case 17;
						case 17:
							intPtr = sbZuR3N2X2utrligmV(((object[])DeY4nBThciTPIV9fV7(x4Dk2IHVmX))[0]);
							goto case 628;
						case 607:
							array3[6] = 105;
							num3 = 1;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 606:
							array5[5] = 222;
							goto case 41;
						case 41:
							array5[6] = 67;
							goto case 175;
						case 175:
							num5 = 125;
							goto case 100;
						case 100:
							array5[6] = (byte)num5;
							goto case 643;
						case 605:
							num5 = 165;
							num3 = 213;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 81;
						case 604:
							array10[1] = 101;
							num3 = 329;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 603:
							array[num4 + 3] = array16[3];
							goto case 28;
						case 28:
							num4 = 23;
							num3 = 621;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 602:
							num5 = 127;
							goto case 579;
						case 579:
							array5[8] = (byte)num5;
							goto case 597;
						case 597:
							num5 = 63;
							goto case 505;
						case 505:
							array5[8] = (byte)num5;
							num3 = 141;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 26;
						case 107:
						case 600:
							num36 = dfS4ULclYXZYwSkxBX(object_);
							num = 345;
							goto case 345;
						case 345:
							num51 = dfS4ULclYXZYwSkxBX(object_);
							goto case 156;
						case 156:
							if (num51 != 4)
							{
								goto case 349;
							}
							goto case 466;
						case 466:
							object_3 = (SymmetricAlgorithm)OH9dmTJ6dfnBpK10Ki();
							goto case 444;
						case 444:
							gWRZV4lbAMTB7Bs9Aa(object_3, CipherMode.CBC);
							num3 = 312;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 106;
						case 106:
							array5[20] = 164;
							goto case 6;
						case 6:
							num5 = 171;
							goto case 317;
						case 317:
							array5[20] = (byte)num5;
							num3 = 230;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 599:
							array5[0] = 126;
							goto case 555;
						case 555:
							array5[0] = 132;
							goto case 337;
						case 337:
							array5[1] = 157;
							num3 = 98;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 598:
							bIpvxRBRb2dOGl802m.jsbkrdexts = jsbkrdexts;
							num3 = 556;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 338;
						case 338:
							num11 = 126;
							goto case 629;
						case 595:
							array5[15] = (byte)num5;
							num3 = 61;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 594:
							array4[4] = (byte)num11;
							num3 = 180;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 593:
							num11 = 184;
							goto case 315;
						case 315:
							array4[0] = (byte)num11;
							num = 508;
							goto case 508;
						case 508:
							num11 = 114;
							num3 = 499;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 591:
							array5[16] = 87;
							goto case 179;
						case 179:
							num5 = 154;
							goto case 373;
						case 373:
							array5[16] = (byte)num5;
							num3 = 614;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 590:
							array5[30] = (byte)num5;
							goto case 140;
						case 140:
							num5 = 100;
							goto case 87;
						case 87:
							array5[30] = (byte)num5;
							goto case 176;
						case 176:
							array5[30] = 88;
							num3 = 216;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 589:
							array16 = (byte[])xUqmogBqDnQuhXU4Zbm(num27);
							num3 = 547;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 588:
							array = array11;
							num = 25;
							goto case 25;
						case 25:
							array2 = null;
							num3 = 565;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 587:
							num11 = 50;
							goto case 486;
						case 486:
							array4[12] = (byte)num11;
							num = 656;
							goto case 656;
						case 583:
							if (yYJwNnYQK62IqBhoI5(vuIHYUg5wQ3lqEF7X0(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)) <= 0)
							{
								goto case 40;
							}
							num = 197;
							goto case 197;
						case 40:
						case 67:
							try
							{
								object obj = fch4apBQQIvMnirycsV(s7T5DeBkUjK8MYBSMb9(SnyMILB9tCXrctSPI5G(aoXeKXBhgKWbmf3kMP6(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), SnyMILB9tCXrctSPI5G(aoXeKXBhgKWbmf3kMP6(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)));
								while (true)
								{
									IL_2433_2:
									if (obj is IntPtr)
									{
										goto IL_240a_2;
									}
									goto IL_2416_3;
									IL_2416_3:
									while (true)
									{
										IL_2416_4:
										if (!hcLgON2KrqkjPg4VtH(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
										{
											goto IL_22d5_2;
										}
										goto IL_23d1_2;
										IL_23d1_2:
										VE2k4S5okQ = (IntPtr)fch4apBQQIvMnirycsV(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
										num44 = 1;
										if (HVnMjPVy0dTk6K1mRH() == null)
										{
											goto IL_227f_3;
										}
										goto IL_22d5_2;
										IL_227f_3:
										while (true)
										{
											switch (num44)
											{
											case 1:
											case 18:
												break;
											case 17:
												MhUL1X3vdKIRoiAZ2h(object_10, 0L);
												num44 = 12;
												if (IranHmBduY2M1rn0mF())
												{
													continue;
												}
												goto IL_227b_2;
											case 16:
												if (cJ9peUUbuVQT5wKaIB() == 4)
												{
													num44 = 0;
													if (HVnMjPVy0dTk6K1mRH() == null)
													{
														continue;
													}
													goto IL_227b_2;
												}
												goto case 6;
											case 6:
												BYbNk6uQOTrlRVlp4l(object_10, xUqmogBqDnQuhXU4Zbm(VE2k4S5okQ.ToInt64()), 0, 8);
												goto case 5;
											case 5:
											case 10:
												BYbNk6uQOTrlRVlp4l(object_10, new byte[cJ9peUUbuVQT5wKaIB()], 0, cJ9peUUbuVQT5wKaIB());
												num44 = 9;
												if (HVnMjPVy0dTk6K1mRH() != null)
												{
													continue;
												}
												goto case 9;
											case 9:
												BYbNk6uQOTrlRVlp4l(object_10, new byte[cJ9peUUbuVQT5wKaIB()], 0, cJ9peUUbuVQT5wKaIB());
												goto case 17;
											case 7:
												BYbNk6uQOTrlRVlp4l(object_10, new byte[cJ9peUUbuVQT5wKaIB()], 0, cJ9peUUbuVQT5wKaIB());
												num44 = 16;
												if (HVnMjPVy0dTk6K1mRH() == null)
												{
													continue;
												}
												goto IL_227b_2;
											default:
												BYbNk6uQOTrlRVlp4l(object_10, gsLPImwN0YqwQaIieQ(VE2k4S5okQ.ToInt32()), 0, 4);
												goto case 5;
											case 3:
												goto IL_23d1_2;
											case 11:
												goto end_IL_2416_2;
											case 4:
												goto IL_2416_4;
											case 8:
												goto IL_2433_2;
											case 12:
												array21 = (byte[])MRB1Ggb30AbIYOUXA1(object_10);
												num45 = 14;
												goto case 14;
											case 14:
												Qgb8YhvMWbR2oRpvia(object_10);
												goto case 2;
											case 2:
												nativeSizeOfCode = 0u;
												goto case 15;
											case 15:
												try
												{
													array22 = (array18 = array21);
													if (array22 != null)
													{
														goto IL_2462_2;
													}
													goto IL_24b3_2;
													IL_24b3_2:
													reference2 = ref *(byte*)null;
													num46 = 1;
													if (HVnMjPVy0dTk6K1mRH() != null)
													{
														num46 = num47;
													}
													goto IL_2490_3;
													IL_2490_3:
													switch (num46)
													{
													case 6:
														break;
													default:
														goto IL_2475_3;
													case 2:
														goto IL_24b3_2;
													case 1:
													case 3:
														rNZkehfwNu(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
														goto end_IL_245b_2;
													case 4:
														goto end_IL_245b_2;
													}
													goto IL_2462_2;
													IL_2462_2:
													if (array18.Length != 0)
													{
														num46 = 5;
														if (HVnMjPVy0dTk6K1mRH() != null)
														{
															goto IL_2475_3;
														}
														goto IL_2490_3;
													}
													goto IL_24b3_2;
													IL_2475_3:
													while (true)
													{
														fixed (byte* value = &array18[0])
														{
															num46 = 3;
															if (!IranHmBduY2M1rn0mF())
															{
																num46 = num47;
															}
															while (true)
															{
																switch (num46)
																{
																case 0:
																case 5:
																	break;
																case 6:
																	if (array18.Length == 0)
																	{
																		goto end_IL_2475_2;
																	}
																	num46 = 5;
																	if (HVnMjPVy0dTk6K1mRH() == null)
																	{
																		continue;
																	}
																	break;
																case 2:
																	goto end_IL_2475_2;
																case 1:
																case 3:
																	rNZkehfwNu(new IntPtr(value), new IntPtr(value), new IntPtr(value), 216669565u, new IntPtr(value), ref nativeSizeOfCode);
																	goto end_IL_245b_2;
																case 4:
																	goto end_IL_245b_2;
																}
																break;
															}
														}
														continue;
														end_IL_2475_2:
														break;
													}
													goto IL_24b3_2;
													end_IL_245b_2:;
												}
												finally
												{
													reference2 = ref *(byte*)null;
													num48 = 0;
													if (!IranHmBduY2M1rn0mF())
													{
														num48 = num49;
													}
													switch (num48)
													{
													}
												}
												goto end_IL_2433_2;
											case 13:
												goto end_IL_2433_2;
											}
											break;
										}
										goto IL_22d5_2;
										IL_22d5_2:
										object_10 = new MemoryStream();
										num44 = 7;
										if (!IranHmBduY2M1rn0mF())
										{
											goto IL_227b_2;
										}
										goto IL_227f_3;
										IL_227b_2:
										num44 = num45;
										goto IL_227f_3;
										continue;
										end_IL_2416_2:
										break;
									}
									goto IL_240a_2;
									IL_240a_2:
									VE2k4S5okQ = (IntPtr)obj;
									goto IL_2416_3;
									continue;
									end_IL_2433_2:
									break;
								}
							}
							catch (object obj2)
							{
								num50 = 0;
								if (!IranHmBduY2M1rn0mF())
								{
									switch (num50)
									{
									}
								}
							}
							goto case 38;
						case 63:
							FKefxyB2v6B3QccOFdC(Upxg6OBf9Dp7KTmmDnx(QCdt93B1dmFDakGUb1m(abxkLGOVrU)));
							num3 = 652;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 582:
							array20 = new byte[40];
							j94yovBHZC6iNptekrd(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array11 = array20;
							num3 = 79;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 43:
						case 580:
							num25++;
							goto case 265;
						case 265:
						case 553:
							if (num25 >= num8)
							{
								goto case 417;
							}
							goto case 292;
						case 417:
							array8 = array13;
							num3 = 125;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 292:
							num42 = num25 % num15;
							goto case 541;
						case 541:
							num12 = num25 * 4;
							num = 259;
							goto case 259;
						case 259:
							num43 = (uint)(num42 * 4);
							goto case 102;
						case 102:
							num18 = (uint)((array14[num43 + 3] << 24) | (array14[num43 + 2] << 16) | (array14[num43 + 1] << 8) | array14[num43]);
							num = 236;
							goto case 236;
						case 236:
							num40 = 255u;
							num3 = 43;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 75;
						case 75:
							num41 = 0;
							num3 = 98;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 403;
						case 403:
							if (num25 == num8 - 1)
							{
								goto case 659;
							}
							goto case 21;
						case 578:
							XkFtbdIp1Loq3EMk1X(new IntPtr(&num19), 0, 0);
							num3 = 634;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 577:
							array[num9 + 1] = array16[1];
							goto case 151;
						case 151:
							array[num9 + 2] = array16[2];
							num3 = 172;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 426;
						case 426:
							array[num9 + 3] = array16[3];
							num3 = 420;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 203;
						case 203:
							array5[30] = (byte)num5;
							num = 474;
							goto case 474;
						case 474:
							num5 = 79;
							goto case 590;
						case 576:
							JyADcotn09ZmOcH756(new IntPtr(&num19), 0, IntPtr.Zero);
							num3 = 578;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 575:
							array5[15] = (byte)num5;
							goto case 591;
						case 574:
							if (vuIHYUg5wQ3lqEF7X0(x4Dk2IHVmX) == null)
							{
								num3 = 523;
								if (IranHmBduY2M1rn0mF())
								{
									continue;
								}
								goto case 454;
							}
							goto case 343;
						case 454:
							if (num23 > 0)
							{
								goto case 69;
							}
							goto default;
						case 69:
							num40 <<= 8;
							goto case 441;
						case 441:
							num41 += 8;
							num3 = 0;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						default:
							array13[num12 + num23] = (byte)((num22 & num40) >> num41);
							num3 = 528;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 343:
							if (yYJwNnYQK62IqBhoI5(vuIHYUg5wQ3lqEF7X0(x4Dk2IHVmX)) != 0)
							{
								goto case 107;
							}
							goto case 47;
						case 47:
						case 523:
							num28 = 7680;
							goto case 107;
						case 573:
							array4[8] = 88;
							goto case 91;
						case 91:
							array4[8] = 101;
							goto case 110;
						case 110:
							array4[8] = 82;
							goto case 262;
						case 262:
							num11 = 136;
							goto case 177;
						case 177:
							array4[8] = (byte)num11;
							goto case 549;
						case 549:
							num11 = 0;
							num3 = 357;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 176;
						case 569:
							array5[25] = 145;
							num3 = 200;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 567:
							num5 = 120;
							num = 336;
							goto case 336;
						case 336:
							array5[10] = (byte)num5;
							goto case 99;
						case 566:
							array4[5] = 114;
							num3 = 157;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 520;
						case 520:
							array4[5] = 170;
							num3 = 359;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 565:
							array16 = null;
							goto case 271;
						case 271:
							array7 = null;
							goto case 201;
						case 201:
							if (cJ9peUUbuVQT5wKaIB() == 4)
							{
								goto case 264;
							}
							goto case 323;
						case 264:
							array7 = (byte[])gsLPImwN0YqwQaIieQ(VE2k4S5okQ.ToInt32());
							num3 = 534;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 662;
						case 323:
							array7 = (byte[])xUqmogBqDnQuhXU4Zbm(VE2k4S5okQ.ToInt64());
							num3 = 255;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 94;
						case 94:
							num5 = 62;
							goto case 611;
						case 563:
							num5 = 139;
							goto case 310;
						case 310:
							array5[1] = (byte)num5;
							goto case 96;
						case 96:
							array5[1] = 120;
							goto case 171;
						case 171:
							array5[1] = 209;
							num3 = 114;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 562:
							array[num4 + 2] = array16[2];
							num3 = 603;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 561:
							array4[2] = 167;
							goto case 340;
						case 340:
							array4[2] = 122;
							goto case 70;
						case 70:
							num11 = 132;
							num3 = 284;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 560:
							array3[3] = 111;
							num3 = 123;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 129;
						case 129:
							array3[4] = 114;
							goto case 543;
						case 543:
							array3[5] = 106;
							goto case 607;
						case 559:
							array5[25] = (byte)num5;
							num3 = 333;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 558:
							array4[13] = (byte)num11;
							num3 = 26;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 152;
						case 152:
							num11 = 70;
							goto case 120;
						case 120:
							array4[14] = (byte)num11;
							num = 517;
							goto case 517;
						case 517:
							num11 = 148;
							goto case 145;
						case 145:
							array4[14] = (byte)num11;
							goto case 282;
						case 556:
							bIpvxRBRb2dOGl802m.JDNkifbo3S = jDNkifbo3S;
							goto case 388;
						case 388:
							Q0ZYP9BVNnFw8WUuZEb(lmdkVksVkh, num38 + num39, bIpvxRBRb2dOGl802m);
							goto case 302;
						case 554:
							array5[29] = 161;
							num3 = 99;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 202;
						case 202:
							num5 = 94;
							num3 = 203;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 551:
							num11 = 92;
							goto case 458;
						case 550:
							array5[29] = 138;
							goto case 554;
						case 548:
							num37 = 0;
							goto case 267;
						case 35:
							array14[num37] = (byte)(array14[num37] ^ array15[num37]);
							goto case 464;
						case 464:
							num37++;
							goto case 267;
						case 267:
						case 422:
							if (num37 < array15.Length)
							{
								goto case 35;
							}
							num3 = 34;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 535;
						case 535:
							array6 = array12;
							num3 = 370;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 546:
							num5 = 164;
							goto case 119;
						case 119:
							array5[7] = (byte)num5;
							num3 = 536;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 545:
							num9 = 18;
							goto case 60;
						case 544:
							array[num4] = array7[0];
							goto case 121;
						case 121:
							array[num4 + 1] = array7[1];
							goto case 533;
						case 533:
							array[num4 + 2] = array7[2];
							goto case 376;
						case 376:
							array[num4 + 3] = array7[3];
							goto case 199;
						case 199:
							num4 = 16;
							goto case 530;
						case 530:
							array[num4] = array16[0];
							goto case 224;
						case 224:
							array[num4 + 1] = array16[1];
							goto case 562;
						case 542:
							Qgb8YhvMWbR2oRpvia(object_2);
							goto case 613;
						case 540:
							array13[num12 + 1] = (byte)((num13 & 0xFF00) >> 8);
							num3 = 181;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 539:
							array5[18] = (byte)num5;
							num3 = 215;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 538:
							num5 = 114;
							goto case 193;
						case 193:
							array5[5] = (byte)num5;
							goto case 146;
						case 146:
							num5 = 150;
							num3 = 475;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 537:
							num5 = 170;
							goto case 325;
						case 325:
							array5[18] = (byte)num5;
							goto case 524;
						case 524:
							num5 = 9;
							num3 = 23;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 536:
							num5 = 154;
							goto case 13;
						case 532:
							intptr_2 = IntPtr.Zero;
							goto case 457;
						case 457:
							num35 = 0;
							num3 = 248;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 531:
							num35++;
							goto case 248;
						case 248:
						case 477:
							if (num35 >= num36)
							{
								num3 = 229;
								if (IranHmBduY2M1rn0mF())
								{
									continue;
								}
								goto case 99;
							}
							goto case 209;
						case 209:
							intPtr4 = new IntPtr(URnkCOceLK + dfS4ULclYXZYwSkxBX(object_) - num28);
							goto case 36;
						case 36:
							YeeoMqaS3J(intPtr4, 4, 4, ref int_);
							goto case 85;
						case 85:
							if (cJ9peUUbuVQT5wKaIB() == 4)
							{
								num3 = 306;
								if (HVnMjPVy0dTk6K1mRH() == null)
								{
									continue;
								}
								goto IL_0b01;
							}
							goto case 489;
						case 489:
							mTfoQqVbOE(intptr_, intPtr4, (byte[])gsLPImwN0YqwQaIieQ(dfS4ULclYXZYwSkxBX(object_)), 4u, out intptr_2);
							num3 = 298;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 529:
							array4[0] = (byte)num11;
							goto case 399;
						case 399:
							array4[0] = 129;
							goto case 493;
						case 493:
							num11 = 96;
							num3 = 514;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 40;
						case 528:
							num23++;
							goto case 19;
						case 19:
						case 270:
							if (num23 >= num21)
							{
								num3 = 39;
								if (!IranHmBduY2M1rn0mF())
								{
									continue;
								}
								goto case 43;
							}
							goto case 454;
						case 526:
							num5 = 130;
							num3 = 220;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 525:
							num11 = 124;
							num3 = 112;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 405;
						case 405:
							array4[9] = (byte)num11;
							num3 = 374;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 522:
							if (array18.Length != 0)
							{
								goto case 618;
							}
							goto IL_2d84;
						case 460:
						case 463:
							goto IL_2d84;
						case 521:
							Tafe6kn7GkmfX3wkZs(array9, 0, array9.Length);
							goto case 548;
						case 516:
							array4[8] = 148;
							goto case 573;
						case 515:
							array3[8] = 46;
							goto case 647;
						case 514:
							array4[0] = (byte)num11;
							num3 = 304;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 513:
							array5[26] = (byte)num5;
							num = 481;
							goto case 481;
						case 481:
							array5[26] = 204;
							goto case 419;
						case 419:
							num5 = 114;
							goto case 55;
						case 55:
							array5[26] = (byte)num5;
							goto case 605;
						case 512:
							array4[4] = (byte)num11;
							goto case 407;
						case 407:
							num11 = 147;
							num3 = 375;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 655;
						case 375:
						case 507:
							num17 = num17;
							goto case 88;
						case 88:
						{
							num33 = num17;
							uint num34 = num17;
							num34 ^= num34 << 7;
							num34 += 205125544;
							num34 ^= num34 >> 9;
							num34 += 1218856144;
							num34 ^= num34 << 5;
							num34 += 3206220699u;
							num34 = 1657819281 - num34;
							num17 = num33 + (uint)(double)num34;
							goto case 301;
						}
						case 301:
							if (num25 == num8 - 1)
							{
								goto case 393;
							}
							goto case 77;
						case 393:
							if (num21 > 0)
							{
								num3 = 387;
								if (HVnMjPVy0dTk6K1mRH() == null)
								{
									continue;
								}
								goto case 205;
							}
							goto case 77;
						case 205:
							array4[12] = 82;
							goto case 455;
						case 455:
							num11 = 118;
							goto case 396;
						case 396:
							array4[12] = (byte)num11;
							goto case 587;
						case 77:
							num13 = num17 ^ num14;
							goto case 161;
						case 161:
							array13[num12] = (byte)(num13 & 0xFFu);
							num3 = 540;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 506:
							if (!mi0ZPSB5hpsekQ9TG9R(iS7hDVB6I71dk8Dg2Yx(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
							{
								goto case 40;
							}
							goto case 416;
						case 416:
							if (((Array)quXFyABUAMLkRq78FPR(iS7hDVB6I71dk8Dg2Yx(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).Length != 2)
							{
								goto case 40;
							}
							num = 131;
							goto case 131;
						case 131:
							if (vuIHYUg5wQ3lqEF7X0(VW2d8fBr2cnP3KQh480(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly) != null)
							{
								goto case 583;
							}
							goto case 40;
						case 502:
							intPtr3 = rb84cNBsnI11TUIN2nG(rNZkehfwNu);
							num3 = 450;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 207;
						case 207:
							YeeoMqaS3J(intptr_4, 4, int_, ref int_);
							num3 = 54;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 501:
							array5[9] = (byte)num5;
							goto case 567;
						case 500:
							array15[11] = array9[5];
							goto case 471;
						case 471:
							array15[13] = array9[6];
							goto case 149;
						case 149:
							array15[15] = array9[7];
							goto case 521;
						case 499:
							array4[1] = (byte)num11;
							num3 = 160;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 497:
							array13 = new byte[array6.Length];
							num3 = 257;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 221;
						case 495:
							array4[5] = (byte)num11;
							num3 = 438;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 491:
							array5[22] = 35;
							num = 172;
							goto case 172;
						case 172:
							array5[23] = 214;
							num3 = 372;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 490:
							array5[9] = (byte)num5;
							goto case 206;
						case 206:
							array5[9] = 69;
							goto case 34;
						case 34:
							num5 = 169;
							goto case 501;
						case 484:
							object_4 = (OFfwWh6ZIHjfnqBOWx)RapOAnBSklV8JMw1wES(procAddress, VW2d8fBr2cnP3KQh480(typeof(OFfwWh6ZIHjfnqBOWx).TypeHandle));
							num3 = 395;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							return;
						case 483:
							array5[18] = (byte)num5;
							goto case 537;
						case 478:
							array5[28] = 85;
							goto case 122;
						case 122:
							num5 = 103;
							goto case 449;
						case 449:
							array5[28] = (byte)num5;
							goto case 212;
						case 212:
							array5[28] = 239;
							goto case 97;
						case 97:
							array5[29] = 104;
							goto case 288;
						case 288:
							array5[29] = 99;
							num = 550;
							goto case 550;
						case 476:
							num5 = 88;
							num3 = 148;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 50;
						case 50:
							array4[5] = (byte)num11;
							num3 = 566;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 475:
							array5[5] = (byte)num5;
							num3 = 606;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 472:
							array4[14] = 177;
							goto case 642;
						case 468:
							array5[12] = 180;
							goto case 413;
						case 413:
							num5 = 33;
							goto case 639;
						case 467:
							num11 = 83;
							goto case 558;
						case 465:
							DX7bt5ihQE8BP57y7n(object_2);
							num3 = 448;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 110;
						case 461:
							bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
							goto case 598;
						case 459:
							enumerator = (IEnumerator)B518JUQdx9vQy586iX(object_5);
							goto case 116;
						case 116:
							try
							{
								while (true)
								{
									IL_3381_2:
									if (!bJbPGvOBTb99N6Yugw(enumerator))
									{
										num29 = 6;
										if (!IranHmBduY2M1rn0mF())
										{
											continue;
										}
										goto IL_331a_3;
									}
									goto IL_3354_2;
									IL_3260_2:
									num29 = num30;
									goto IL_331a_3;
									IL_3354_2:
									object_6 = (ProcessModule)FFCROHqCsHxOmTok68(enumerator);
									num29 = 1;
									if (HVnMjPVy0dTk6K1mRH() != null)
									{
										goto IL_3260_2;
									}
									goto IL_331a_3;
									IL_331a_3:
									while (true)
									{
										switch (num29)
										{
										case 10:
											if (!l2QNJyDsc2WV5N9cgV(object_7, object_8))
											{
												goto IL_3381_2;
											}
											goto case 8;
										case 8:
											if (!F3Y4bl76b1o3UesaHM(object_7, object_9))
											{
												goto IL_3381_2;
											}
											goto IL_3250_2;
										case 7:
											break;
										case 5:
											object_7 = new Version(Thu9Sl0Bnf4g19EAxF(lqbmL6HpXROaBHGomn(object_6)), BTTUKBKp46RQNbn4qN(lqbmL6HpXROaBHGomn(object_6)), uwvrRlXXRUYrDCVBqP(lqbmL6HpXROaBHGomn(object_6)), rbJibsFmfPvjNieSQy(lqbmL6HpXROaBHGomn(object_6)));
											num29 = 0;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto default;
										default:
											object_8 = new Version(4, 0, 30319, 17020);
											num29 = 2;
											if (HVnMjPVy0dTk6K1mRH() == null)
											{
												continue;
											}
											goto case 2;
										case 2:
											object_9 = new Version(4, 0, 30319, 17921);
											goto case 10;
										case 1:
											if (!hcLgON2KrqkjPg4VtH(bpxvxHfNvEl2t0p4bW(i9AiaSoPiJRHVKwOc9(object_6)), "clrjit.dll"))
											{
												goto IL_3381_2;
											}
											goto case 5;
										case 9:
											goto end_IL_331a_2;
										case 4:
										case 11:
											goto IL_3381_2;
										case 3:
										case 6:
											goto end_IL_3381_2;
										}
										PRZkZqsNsa = true;
										num29 = 3;
										if (HVnMjPVy0dTk6K1mRH() == null)
										{
											continue;
										}
										goto IL_3260_2;
										IL_3250_2:
										num29 = 7;
										if (IranHmBduY2M1rn0mF())
										{
											continue;
										}
										goto IL_3260_2;
										continue;
										end_IL_331a_2:
										break;
									}
									goto IL_3354_2;
									continue;
									end_IL_3381_2:
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
										goto IL_339c_2;
									}
									num31 = 0;
									if (HVnMjPVy0dTk6K1mRH() == null)
									{
										break;
									}
									goto IL_33af_2;
									IL_33af_2:
									switch (num31)
									{
									case 2:
										break;
									default:
										goto end_IL_33db_2;
									case 3:
										continue;
									case 0:
									case 1:
										goto end_IL_33db_2;
									}
									goto IL_339c_2;
									IL_339c_2:
									NpVWiuAKGUyYqmKsx6(disposable);
									num31 = 1;
									if (!IranHmBduY2M1rn0mF())
									{
										num31 = num32;
									}
									goto IL_33af_2;
									continue;
									end_IL_33db_2:
									break;
								}
							}
							goto case 379;
						case 456:
							array5[19] = 122;
							goto case 672;
						case 453:
							num27 = mrFXA2ByUMsWbgwLCS2(new IntPtr(num24));
							goto case 305;
						case 451:
							array19 = (array18 = array8);
							if (array19 == null)
							{
								num3 = 460;
								if (IranHmBduY2M1rn0mF())
								{
									continue;
								}
								goto IL_0b01;
							}
							goto case 522;
						case 450:
							num27 = 0L;
							goto case 342;
						case 342:
							if (cJ9peUUbuVQT5wKaIB() != 4)
							{
								goto case 640;
							}
							num = 453;
							goto case 453;
						case 448:
							array8 = (byte[])MRB1Ggb30AbIYOUXA1(memoryStream);
							num3 = 394;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 447:
							array10[5] = 116;
							num = 411;
							goto case 411;
						case 411:
							string_ = (string)JUTQe8Btg3H97VDyQBF(RVtYEkBjq51FQBTROnZ(), array10);
							goto case 638;
						case 446:
							array5[6] = (byte)num5;
							goto case 380;
						case 380:
							array5[7] = 138;
							goto case 126;
						case 126:
							num5 = 102;
							num3 = 126;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 346;
						case 346:
							array5[7] = (byte)num5;
							goto case 546;
						case 443:
							array10[4] = 105;
							goto case 447;
						case 439:
							num26 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + (nint)num16 * (nint)8);
							*(long*)num26 ^= 940681987L;
							num3 = 261;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 247;
						case 438:
							num11 = 58;
							goto case 283;
						case 283:
							array4[6] = (byte)num11;
							goto case 2;
						case 2:
							array4[6] = 109;
							num3 = 174;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 437:
							array5[27] = 97;
							goto case 494;
						case 436:
							array4[3] = 40;
							goto case 256;
						case 256:
							num11 = 128;
							goto case 512;
						case 435:
							memoryStream = new MemoryStream();
							goto case 299;
						case 299:
							object_2 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
							num3 = 167;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 434:
							num25 = 0;
							num3 = 553;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 433:
							array3 = new byte[12];
							goto case 49;
						case 49:
							array3[0] = 109;
							goto case 217;
						case 217:
							array3[1] = 115;
							num3 = 412;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 432:
							intPtr3 = IntPtr.Zero;
							goto case 502;
						case 421:
							array4[12] = 67;
							num = 128;
							goto case 128;
						case 128:
							array4[12] = 134;
							num3 = 16;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 205;
						case 420:
							array[num9 + 4] = array16[4];
							num3 = 318;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 415:
							array5[8] = 202;
							num3 = 391;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 253;
						case 412:
							array3[2] = 99;
							goto case 560;
						case 409:
							num5 = 51;
							goto case 14;
						case 14:
							array5[25] = (byte)num5;
							num3 = 202;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 569;
						case 408:
							array5[14] = (byte)num5;
							num3 = 132;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 62;
						case 406:
							num5 = 89;
							num3 = 595;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 409;
						case 404:
							num17 += num18;
							goto case 26;
						case 400:
							num11 = 70;
							num3 = 495;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 395:
							intptr_3 = BYk3UMBWdOnNk3h1bnN(object_4);
							goto case 330;
						case 330:
							num24 = 0L;
							goto case 279;
						case 394:
							Tafe6kn7GkmfX3wkZs(array15, 0, array15.Length);
							goto case 138;
						case 138:
							Qgb8YhvMWbR2oRpvia(memoryStream);
							goto case 542;
						case 391:
							array5[8] = 108;
							goto case 182;
						case 182:
							array5[8] = 240;
							num3 = 476;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 389:
							FKefxyB2v6B3QccOFdC(Upxg6OBf9Dp7KTmmDnx(QCdt93B1dmFDakGUb1m(rNZkehfwNu)));
							num3 = 107;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 377;
						case 377:
							array11 = null;
							goto case 335;
						case 335:
							if (cJ9peUUbuVQT5wKaIB() != 4)
							{
								goto case 582;
							}
							goto case 242;
						case 242:
							array17 = new byte[30];
							j94yovBHZC6iNptekrd(array17, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array11 = array17;
							num3 = 158;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 387:
							num22 = num17 ^ num14;
							goto case 226;
						case 226:
							num23 = 0;
							goto case 19;
						case 386:
							array4[1] = 108;
							num3 = 362;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 385:
							num5 = 113;
							goto case 559;
						case 383:
							Tafe6kn7GkmfX3wkZs(array14, 0, array14.Length);
							goto case 435;
						case 382:
							array[num9 + 5] = array7[5];
							num3 = 232;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 374:
							array4[9] = 136;
							goto case 664;
						case 372:
							array5[23] = 99;
							goto case 154;
						case 154:
							array5[23] = 47;
							goto case 673;
						case 371:
							bpCbcJjFZWh84qpEv4(new IntPtr(&num19), 0);
							num3 = 576;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 370:
							num21 = array6.Length % 4;
							num3 = 71;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 30;
						case 30:
							array5 = new byte[32];
							goto case 115;
						case 369:
							array15[7] = array9[3];
							num = 645;
							goto case 645;
						case 368:
							num20 = 0;
							goto case 5;
						case 367:
							array4[15] = 216;
							goto case 93;
						case 93:
							array15 = array4;
							goto case 8;
						case 8:
							R43t328wLnqxNjLpAY(array15);
							num3 = 139;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 366:
							array15[5] = array9[2];
							goto case 369;
						case 365:
							num5 = 118;
							num3 = 227;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 362:
							num11 = 50;
							num = 334;
							goto case 334;
						case 334:
							array4[1] = (byte)num11;
							goto case 619;
						case 361:
							array4[2] = 222;
							goto case 551;
						case 359:
							array4[5] = 67;
							goto case 400;
						case 358:
							array4[3] = 155;
							num3 = 321;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 357:
							array4[8] = (byte)num11;
							goto case 134;
						case 134:
							array4[9] = 87;
							goto case 525;
						case 350:
							num11 = 123;
							num3 = 328;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 347:
							array14 = array5;
							goto case 195;
						case 195:
							array4 = new byte[16];
							goto case 59;
						case 59:
							num11 = 165;
							num3 = 529;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 244;
						case 341:
							array4[7] = 167;
							num3 = 320;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 288;
						case 339:
							array5[20] = (byte)num5;
							num = 53;
							goto case 53;
						case 53:
							array5[20] = 169;
							goto case 258;
						case 258:
							num5 = 154;
							goto case 89;
						case 89:
							array5[21] = (byte)num5;
							goto case 309;
						case 309:
							num5 = 90;
							goto case 238;
						case 238:
							array5[21] = (byte)num5;
							num3 = 441;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 637;
						case 333:
							num5 = 32;
							goto case 272;
						case 272:
							array5[26] = (byte)num5;
							goto case 252;
						case 252:
							num5 = 70;
							goto case 513;
						case 332:
							array5[6] = (byte)num5;
							num3 = 75;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 214;
						case 214:
							num5 = 65;
							goto case 446;
						case 329:
							array10[2] = 116;
							num = 52;
							goto case 52;
						case 52:
							array10[3] = 74;
							num3 = 346;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 443;
						case 328:
							array4[7] = (byte)num11;
							goto case 341;
						case 327:
							if (array9.Length <= 0)
							{
								goto case 548;
							}
							goto case 90;
						case 90:
							array15[1] = array9[0];
							goto case 159;
						case 159:
							array15[3] = array9[1];
							goto case 366;
						case 326:
							array5[19] = (byte)num5;
							goto case 424;
						case 324:
							array5[25] = 162;
							num3 = 385;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 321:
							num11 = 187;
							num3 = 59;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 165;
						case 320:
							array4[7] = 147;
							num3 = 275;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 516;
						case 319:
							array5[28] = (byte)num5;
							goto case 478;
						case 318:
							array[num9 + 5] = array16[5];
							goto case 164;
						case 164:
							array[num9 + 6] = array16[6];
							goto case 274;
						case 274:
							array[num9 + 7] = array16[7];
							num3 = 231;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 312:
							transform = (ICryptoTransform)xJBO9UxqXvUp7hcPMc(object_3, array14, array15);
							num3 = 56;
							if (HVnMjPVy0dTk6K1mRH() != null)
							{
								continue;
							}
							goto case 383;
						case 308:
							num5 = 130;
							num = 22;
							goto case 22;
						case 22:
							array5[13] = (byte)num5;
							goto case 168;
						case 168:
							num5 = 19;
							num3 = 260;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 306:
							mTfoQqVbOE(intptr_, intPtr4, (byte[])gsLPImwN0YqwQaIieQ(dfS4ULclYXZYwSkxBX(object_)), 4u, out intptr_2);
							goto case 268;
						case 268:
						case 298:
							YeeoMqaS3J(intPtr4, 4, int_, ref int_);
							goto case 531;
						case 304:
							array4[0] = 155;
							goto case 593;
						case 303:
							jDNkifbo3S = false;
							goto case 302;
						case 297:
							array12 = (byte[])AEygtYdaRrAdRQSUdC(object_, (int)hnqKsEMJyigELtAMsm(jdn14iPZJbNEoRhq7K(object_)));
							goto case 30;
						case 296:
							array3[2] = 114;
							num3 = 42;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 295:
							array5[4] = (byte)num5;
							num3 = 56;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 8;
						case 294:
							num19 = 0L;
							goto case 196;
						case 196:
							YmOgPart3dfqVhfdMZ(new IntPtr(&num19), 0);
							goto case 245;
						case 245:
							ncWBLwZGol46cEuaFy(new IntPtr(&num19), 0);
							num3 = 371;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 291:
							array[num9 + 3] = array7[3];
							goto case 92;
						case 92:
							array[num9 + 4] = array7[4];
							goto case 382;
						case 289:
							int_2 = 0;
							num3 = 506;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 285:
							num5 = 73;
							num3 = 326;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 284:
							array4[2] = (byte)num11;
							goto case 361;
						case 280:
							if (cJ9peUUbuVQT5wKaIB() != 4)
							{
								goto case 433;
							}
							num3 = 0;
							if (!IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 3;
						case 3:
							wpoklx4RIX = MgcOqsBZRp8lpkejivL(eXJkjmTXDX);
							num = 433;
							goto case 433;
						case 276:
							array5[9] = 116;
							goto case 233;
						case 233:
							num5 = 92;
							goto case 490;
						case 275:
							array4[15] = (byte)num11;
							goto case 338;
						case 269:
							num17 = 0u;
							num = 192;
							goto case 192;
						case 192:
							num18 = 0u;
							num3 = 204;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 263:
							array5[31] = 0;
							num = 347;
							goto case 347;
						case 261:
							num16++;
							goto case 178;
						case 178:
						case 187:
							if (num16 >= num10)
							{
								goto case 635;
							}
							goto case 439;
						case 260:
							array5[13] = (byte)num5;
							goto case 78;
						case 78:
							array5[14] = 115;
							goto case 211;
						case 211:
							num5 = 148;
							num3 = 408;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 257:
							num15 = array14.Length / 4;
							num3 = 269;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 75;
						case 255:
							array2 = (byte[])xUqmogBqDnQuhXU4Zbm(intPtr3.ToInt64());
							goto case 589;
						case 239:
							array4[13] = 180;
							goto case 467;
						case 235:
							array5[19] = 160;
							goto case 106;
						case 232:
							array[num9 + 6] = array7[6];
							num3 = 124;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 231:
							num9 = 30;
							goto case 657;
						case 230:
							num5 = 130;
							goto case 339;
						case 227:
							array5[24] = (byte)num5;
							num = 526;
							goto case 526;
						case 225:
							array5[24] = 54;
							num3 = 409;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 220:
							array5[24] = (byte)num5;
							goto case 225;
						case 216:
							array5[30] = 148;
							num3 = 163;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 10;
						case 215:
							num5 = 160;
							goto case 483;
						case 213:
							array5[26] = (byte)num5;
							goto case 241;
						case 204:
							num14 = 0u;
							goto case 668;
						case 200:
							array5[25] = 126;
							num3 = 113;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 89;
						case 198:
							array4[7] = 165;
							num3 = 350;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 194:
							array4[5] = (byte)num11;
							goto case 64;
						case 64:
							num11 = 97;
							num3 = 50;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 188:
							num5 = 160;
							num3 = 539;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 16;
						case 181:
							array13[num12 + 2] = (byte)((num13 & 0xFF0000) >> 16);
							goto case 135;
						case 135:
							array13[num12 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
							goto case 43;
						case 180:
							array4[4] = 96;
							goto case 12;
						case 12:
							num11 = 155;
							goto case 194;
						case 174:
							array4[6] = 112;
							goto case 74;
						case 74:
							array4[6] = 209;
							num3 = 82;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 173:
							array5[17] = 188;
							num3 = 612;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 170:
							num6++;
							goto case 254;
						case 167:
							BYbNk6uQOTrlRVlp4l(object_2, array12, 0, array12.Length);
							num3 = 465;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 163:
							array5[31] = 112;
							goto case 48;
						case 48:
							array5[31] = 149;
							goto case 263;
						case 160:
							array4[1] = 205;
							num = 386;
							goto case 386;
						case 79:
						case 158:
							intPtr2 = ECNpoZB0MZh1a20aSda(IntPtr.Zero, (uint)array11.Length, 4096u, 64u);
							goto case 588;
						case 155:
							array4[15] = 89;
							num = 367;
							goto case 367;
						case 153:
							array5[19] = (byte)num5;
							goto case 285;
						case 150:
							array5[4] = 120;
							num3 = 620;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 148:
							array5[8] = (byte)num5;
							num3 = 602;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto case 484;
						case 147:
							array10[0] = 103;
							goto case 604;
						case 141:
							num5 = 154;
							goto case 24;
						case 24:
							array5[9] = (byte)num5;
							num3 = 276;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 139:
							array9 = (byte[])pkfoilel9V8ZGdoB14(bZdhSXLCcaLc1ssp6f(x4Dk2IHVmX));
							goto case 32;
						case 32:
							if (array9 == null)
							{
								goto case 548;
							}
							goto case 327;
						case 133:
							array5[10] = (byte)num5;
							goto case 650;
						case 130:
							array5[22] = (byte)num5;
							goto case 491;
						case 125:
							num10 = array8.Length / 8;
							goto case 451;
						case 124:
							array[num9 + 7] = array7[7];
							goto case 545;
						case 114:
							array5[2] = 82;
							goto case 633;
						case 113:
							array5[25] = 140;
							goto case 324;
						case 111:
							array5[1] = (byte)num5;
							goto case 563;
						case 98:
							num5 = 59;
							num3 = 111;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 86:
							array3[1] = 108;
							goto case 296;
						case 82:
							array4[6] = 75;
							goto case 57;
						case 57:
							array4[7] = 153;
							goto case 198;
						case 80:
							text = (string)JUTQe8Btg3H97VDyQBF(RVtYEkBjq51FQBTROnZ(), array3);
							goto case 666;
						case 76:
							intptr_ = ry5y1qELZwKGh4kc2G((uint)uint_, 1, (uint)pQVRLkmZcRKuneKJ9V(cxyU4ysr5cXjtnBlE3()));
							goto case 609;
						case 71:
							num8 = array6.Length / 4;
							num = 497;
							goto case 497;
						case 61:
							num5 = 119;
							num3 = 575;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto IL_0b01;
						case 56:
							array5[4] = 179;
							goto case 150;
						case 54:
							num7++;
							goto case 351;
						case 46:
							num6 = 0;
							num3 = 254;
							if (IranHmBduY2M1rn0mF())
							{
								continue;
							}
							goto IL_0b01;
						case 45:
							MhUL1X3vdKIRoiAZ2h(jdn14iPZJbNEoRhq7K(object_), 0L);
							goto case 297;
						case 44:
							array5[19] = (byte)num5;
							num3 = 235;
							if (HVnMjPVy0dTk6K1mRH() == null)
							{
								continue;
							}
							goto case 33;
						case 33:
							array5[5] = (byte)num5;
							goto case 538;
						case 42:
							array3[3] = 106;
							goto case 631;
						case 39:
							URnkCOceLK = intPtr.ToInt64();
							goto case 532;
						case 23:
							array5[18] = (byte)num5;
							goto case 456;
						case 4:
							array4[13] = 87;
							goto case 239;
						case 1:
							array3[7] = 116;
							goto case 515;
						case 38:
							fyt6ByBojUirf8waGTH(abxkLGOVrU);
							num = 63;
							goto case 63;
						case 218:
							abxkLGOVrU = null;
							goto case 352;
						case 197:
							Fxa684CVyKutPq73Q5();
							return;
						case 127:
							KZYVnCBB92eTU8T5RpR(intptr_);
							goto case 210;
						case 210:
							Fxa684CVyKutPq73Q5();
							return;
						case 186:
							return;
						case 621:
							array[num4] = array2[0];
							goto case 331;
						case 331:
							array[num4 + 1] = array2[1];
							num = 354;
							goto case 354;
						case 354:
							array[num4 + 2] = array2[2];
							num = 557;
							goto case 557;
						case 557:
							array[num4 + 3] = array2[3];
							num = 670;
							goto case 277;
						case 222:
							Fxa684CVyKutPq73Q5();
							return;
						case 364:
							return;
						case 585:
							return;
						case 228:
							array[num9 + 7] = array2[7];
							goto case 277;
						case 277:
						case 670:
							v56v3vyckQQddrak5e(array, 0, intPtr2, array.Length);
							goto case 9;
						case 9:
							xo4kuDarJK = false;
							goto case 144;
						case 144:
							YeeoMqaS3J(new IntPtr(num24), cJ9peUUbuVQT5wKaIB(), 64, ref int_2);
							goto case 250;
						case 250:
							ScVT1hBKJMZIABp9D7p(new IntPtr(num24), intPtr2);
							goto case 571;
						case 571:
							YeeoMqaS3J(new IntPtr(num24), cJ9peUUbuVQT5wKaIB(), int_2, ref int_2);
							num = 615;
							goto end_IL_0009;
						case 428:
						case 615:
							goto end_IL_0009;
						case 190:
							return;
							IL_18d2_2:
							if (cJ9peUUbuVQT5wKaIB() == 4)
							{
								goto case 83;
							}
							goto case 379;
							IL_2d84:
							reference = ref *(byte*)null;
							goto case 65;
						}
						break;
						IL_0af1:
						num3 = 375;
						if (IranHmBduY2M1rn0mF())
						{
							continue;
						}
						goto IL_0b01;
					}
					break;
				}
				break;
			}
			continue;
			end_IL_0009:
			break;
		}
		Fxa684CVyKutPq73Q5();
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

	private static IntPtr w3ZoqRBn5p(IntPtr intptr_0, object object_0, uint uint_0)
	{
		if (BV0kmUIPgx == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			BV0kmUIPgx = (MacgPI7JyVeAhNaPvd)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554785)));
		}
		return BV0kmUIPgx(intptr_0, (string)object_0, uint_0);
	}

	private static IntPtr YDsoA9ylfU(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (yBRkv0eFeZ == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			yBRkv0eFeZ = (GL8NaIwq2KOvLQhMFX)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554786)));
		}
		return yBRkv0eFeZ(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int mTfoQqVbOE(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (tTVkFDSO7A == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			tTVkFDSO7A = (yy2w1VXOQgx806ubre)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554787)));
		}
		return tTVkFDSO7A(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int YeeoMqaS3J(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (zIOkYypt1M == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			zIOkYypt1M = (N7UlhA3IRW2ugh7tWg)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554788)));
		}
		return zIOkYypt1M(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr tdOo5aPwrv(uint uint_0, int int_0, uint uint_1)
	{
		if (tuYkt9D06I == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			tuYkt9D06I = (RI754BJF754hNSApRW)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554789)));
		}
		return tuYkt9D06I(uint_0, int_0, uint_1);
	}

	private static int Q2sob65b9D(IntPtr intptr_0)
	{
		if (etmkyDG2SG == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			etmkyDG2SG = (YLCGmBEaUwBbEqLM01)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.kYMrIWA6yci2W(33554790)));
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
	private static byte[] VZpoRI2LOR(object object_0)
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

	internal static Stream Njco6C1nc4()
	{
		return new MemoryStream();
	}

	internal static byte[] rLIoBbVVpm(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] oN9oGXMAK7(object object_0)
	{
		Stream stream = Njco6C1nc4();
		SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
		symmetricAlgorithm.Key = new byte[32]
		{
			155, 50, 194, 41, 98, 7, 108, 127, 234, 138,
			194, 25, 108, 203, 170, 52, 71, 103, 154, 246,
			177, 172, 73, 186, 24, 111, 114, 133, 95, 109,
			1, 153
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			11, 22, 68, 206, 168, 172, 39, 14, 230, 174,
			50, 240, 46, 80, 122, 173
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_0, 0, ((Array)object_0).Length);
		cryptoStream.Close();
		byte[] result = rLIoBbVVpm(stream);
		hHEYokUTtehNq5ji0d.VK2rIWXzS3sMN();
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
		return null;
	}

	private byte[] IHuoEWDKCc()
	{
		return null;
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
		return null;
	}

	internal byte[] S0yo9WrR0W()
	{
		return null;
	}

	internal static object MDXWIeGBOXN1PNYiCV(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object zVGoRW7dNkI7sCIFru(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void jPg4YX28MwH6uoGxy0(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long sNv9HKHvu5PGur7Kls(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object ny7BmZrVtO1glaTqk8(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void eTWX3683DENf0TaFGL(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void R2Dr8Ic4jBx2v37bKI(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object OiORVCChbIN0u3JNBD(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object fpXrv3J6cgXdrWlebT(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object AjqJaP5CRHWZLiyGSi()
	{
		return PEXoCqmS4w();
	}

	internal static void Cqsprnu5XRYKurdkY8(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object uMjeoRyRwgRR1XPOnl(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object DxDItvlLl7457KOKgV()
	{
		return Njco6C1nc4();
	}

	internal static void MNlgdWEals6kHOFEHa(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void OJ2J06ByOlPDdFUkbW(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object PxT7mOnNGbeDhSxAAq(object object_0)
	{
		return rLIoBbVVpm((Stream)object_0);
	}

	internal static void pKQnjBZFKP88LDoK4X(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int yigBbg1wPeGZ1ISTXI(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void ia9WIdAxNQiRePWLhV()
	{
		hHEYokUTtehNq5ji0d.VK2rIWXzS3sMN();
	}

	internal static object oegkoMWAuUMGobpT5g()
	{
		return Encoding.Unicode;
	}

	internal static object fRqnVobsq34mcxOkNZ(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool w63tP7kVx6Tq9hnOgo()
	{
		return (object)null == null;
	}

	internal static object LfNok891yCdE9lbpIV()
	{
		return null;
	}

	internal static void U3R0AScN5p14agq05q()
	{
		hHEYokUTtehNq5ji0d.VK2rIWXzS3sMN();
	}

	internal static void xXDsxFS9SM0YVnGtRM(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type zjfn7ExcaaydOuS7YL(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object VyujoIlvB5tDGHO0tM(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int LVGNNHXgnlAJYvJs8u(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object C5fBEinsF6sLcOfL43()
	{
		return SHA1.Create();
	}

	internal static object HDyJ579oNjfMWZ0kRA(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool c9qdalpsjkpJd5savH(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object gJKWaldlUOcgg8Hx0N(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object S4tsBsO38TPdIonf3q(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void WvECgBKvUhfaqQRX4Y(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long R6ILBgmiqhltZcRG0D(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object XGm7HYb4aExEg8WLFH(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static object nPdWyOwmbxeSHRQitl()
	{
		return PEXoCqmS4w();
	}

	internal static void mBY8UD8DupWi4KMPFW(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object DyQMVb1g4ktxlqiAO8(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object txBmn8o7qyLHi9UYCa()
	{
		return Njco6C1nc4();
	}

	internal static void eZb7tk0sAdYNxFjfXJ(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void TS8A3JUf3fgXeX5rpj(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object a0vpHrsy62XKwPpZP6()
	{
		return Encoding.UTF8;
	}

	internal static object xgh6ieqxAFiRN4oYQt(object object_0)
	{
		return rLIoBbVVpm((Stream)object_0);
	}

	internal static object uUrcRJ2qi0KKFx1OIg(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void rd3kHxL4vMRVvM36Q1(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void ESa1uOCqPxPSpDfp0Q(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void iJwSKbr5JMmNE62FbS(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void tYC2pcHsxDW9JtLJrP(object object_0, object object_1, uint uint_0, object object_2)
	{
		vBuojdip3i((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort qlSGsk7olr4S02ncMM(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int J6WtLPDbkdD7EauqDu(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void xOJt5eZEiViNc1g6Wf(object object_0, object object_1, int int_0, int int_1)
	{
		NSmolmd79S((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long PkRTq7VP8HLuIIkruO(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint hKYjxNTg9j17hS7gvj(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint Jo3jC8AUZJBXe4OFgF(uint uint_0, int int_0, long long_0, object object_0)
	{
		return SDQoufkqT0(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long gdo1I2iXrHmXptB0Ji(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object GArV0cYTX2sNxyqwpg(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object H8DN1dkCgBpAUbMoSK(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void Hx4XFpNvFOARpYmpjT(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object Cw6SR2tKBW2kngbNER(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool lrDB2i48UZpu2iiXXd(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object FvOBjtGCBFpMpCvLr4(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object LFEtXXjKDqLtVqHXpA(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object sGL8ciMIgj2DnbVYSA(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool kobHEIPiIZXVigBAMG()
	{
		return (object)null == null;
	}

	internal static object ByYnFlE65NobiPVPQJ()
	{
		return null;
	}

	internal static IntPtr YmOgPart3dfqVhfdMZ(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static int ncWBLwZGol46cEuaFy(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt32(intptr_0, int_0);
	}

	internal static long bpCbcJjFZWh84qpEv4(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt64(intptr_0, int_0);
	}

	internal static void JyADcotn09ZmOcH756(IntPtr intptr_0, int int_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
	}

	internal static void XkFtbdIp1Loq3EMk1X(IntPtr intptr_0, int int_0, int int_1)
	{
		Marshal.WriteInt32(intptr_0, int_0, int_1);
	}

	internal static void QkvmIESAUb9sUU9VCC(IntPtr intptr_0, int int_0, long long_0)
	{
		Marshal.WriteInt64(intptr_0, int_0, long_0);
	}

	internal static IntPtr FPU4nCWw4KJ9qdkx0G(int int_0)
	{
		return Marshal.AllocCoTaskMem(int_0);
	}

	internal static void v56v3vyckQQddrak5e(object object_0, int int_0, IntPtr intptr_0, int int_1)
	{
		Marshal.Copy((byte[])object_0, int_0, intptr_0, int_1);
	}

	internal static void WtHracpsmgqsF8ATcR()
	{
		svloy6EVGc();
	}

	internal static object cxyU4ysr5cXjtnBlE3()
	{
		return Process.GetCurrentProcess();
	}

	internal static object LLWROkacydNSnOqVyt(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static IntPtr Lr1j2P6qwxWXaUmjO1(object object_0)
	{
		return ((ProcessModule)object_0).BaseAddress;
	}

	internal static IntPtr kBgS1l5QwoacVPMLeo(IntPtr intptr_0, object object_0, uint uint_0)
	{
		return w3ZoqRBn5p(intptr_0, object_0, uint_0);
	}

	internal static bool AAcXkN1Fay6mj1qY2b(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 != intptr_1;
	}

	internal static void Fxa684CVyKutPq73Q5()
	{
		hHEYokUTtehNq5ji0d.VK2rIWXzS3sMN();
	}

	internal static int cJ9peUUbuVQT5wKaIB()
	{
		return IntPtr.Size;
	}

	internal static Type xCCDxhhDGNiYw9Z67H(object object_0, bool bool_0)
	{
		return Type.GetType((string)object_0, bool_0);
	}

	internal static bool is2epJ9ZPSV6MHPvX5(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static object ttvIdokYconnO4LVWq(object object_0)
	{
		return ((Process)object_0).Modules;
	}

	internal static object B518JUQdx9vQy586iX(object object_0)
	{
		return ((ReadOnlyCollectionBase)object_0).GetEnumerator();
	}

	internal static object FFCROHqCsHxOmTok68(object object_0)
	{
		return ((IEnumerator)object_0).Current;
	}

	internal static object i9AiaSoPiJRHVKwOc9(object object_0)
	{
		return ((ProcessModule)object_0).ModuleName;
	}

	internal static object bpxvxHfNvEl2t0p4bW(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static bool hcLgON2KrqkjPg4VtH(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object lqbmL6HpXROaBHGomn(object object_0)
	{
		return ((ProcessModule)object_0).FileVersionInfo;
	}

	internal static int Thu9Sl0Bnf4g19EAxF(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMajorPart;
	}

	internal static int BTTUKBKp46RQNbn4qN(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMinorPart;
	}

	internal static int uwvrRlXXRUYrDCVBqP(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductBuildPart;
	}

	internal static int rbJibsFmfPvjNieSQy(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductPrivatePart;
	}

	internal static bool l2QNJyDsc2WV5N9cgV(object object_0, object object_1)
	{
		return (Version?)object_0 >= (Version?)object_1;
	}

	internal static bool F3Y4bl76b1o3UesaHM(object object_0, object object_1)
	{
		return (Version?)object_0 < (Version?)object_1;
	}

	internal static bool bJbPGvOBTb99N6Yugw(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void NpVWiuAKGUyYqmKsx6(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object WZvgFyRvmx5f8718jT(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object jdn14iPZJbNEoRhq7K(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void MhUL1X3vdKIRoiAZ2h(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long hnqKsEMJyigELtAMsm(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object AEygtYdaRrAdRQSUdC(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void R43t328wLnqxNjLpAY(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object bZdhSXLCcaLc1ssp6f(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object pkfoilel9V8ZGdoB14(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static void Tafe6kn7GkmfX3wkZs(object object_0, int int_0, int int_1)
	{
		Array.Clear((Array)object_0, int_0, int_1);
	}

	internal static object DeY4nBThciTPIV9fV7(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static IntPtr sbZuR3N2X2utrligmV(object object_0)
	{
		return Marshal.GetHINSTANCE((Module)object_0);
	}

	internal static object vuIHYUg5wQ3lqEF7X0(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int yYJwNnYQK62IqBhoI5(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int dfS4ULclYXZYwSkxBX(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).TVtkAMaqpL();
	}

	internal static object OH9dmTJ6dfnBpK10Ki()
	{
		return PEXoCqmS4w();
	}

	internal static void gWRZV4lbAMTB7Bs9Aa(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object xJBO9UxqXvUp7hcPMc(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static void BYbNk6uQOTrlRVlp4l(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void DX7bt5ihQE8BP57y7n(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object MRB1Ggb30AbIYOUXA1(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void Qgb8YhvMWbR2oRpvia(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void BJCwZN4chYfp322mb0(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static int pQVRLkmZcRKuneKJ9V(object object_0)
	{
		return ((Process)object_0).Id;
	}

	internal static IntPtr ry5y1qELZwKGh4kc2G(uint uint_0, int int_0, uint uint_1)
	{
		return tdOo5aPwrv(uint_0, int_0, uint_1);
	}

	internal static object gsLPImwN0YqwQaIieQ(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static long g5t6XmzTB7McRy9hy4(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static void zgruAFBGT2tfklaxaKW(IntPtr intptr_0, int int_0)
	{
		Marshal.WriteInt32(intptr_0, int_0);
	}

	internal static int KZYVnCBB92eTU8T5RpR(IntPtr intptr_0)
	{
		return Q2sob65b9D(intptr_0);
	}

	internal static void Q0ZYP9BVNnFw8WUuZEb(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static Type VW2d8fBr2cnP3KQh480(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int MgcOqsBZRp8lpkejivL(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static object RVtYEkBjq51FQBTROnZ()
	{
		return Encoding.UTF8;
	}

	internal static object JUTQe8Btg3H97VDyQBF(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool fUZvZnBIo0QGMdkuqwx(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 == intptr_1;
	}

	internal static object RapOAnBSklV8JMw1wES(IntPtr intptr_0, Type type_0)
	{
		return iaKoOg5GGg(intptr_0, type_0);
	}

	internal static IntPtr BYk3UMBWdOnNk3h1bnN(object object_0)
	{
		return object_0();
	}

	internal static int mrFXA2ByUMsWbgwLCS2(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static long sEy60yBpTjAqfsuVmDE(IntPtr intptr_0)
	{
		return Marshal.ReadInt64(intptr_0);
	}

	internal static IntPtr rb84cNBsnI11TUIN2nG(object object_0)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)object_0);
	}

	internal static int eBcGpaBaISUEEGPx55c(object object_0)
	{
		return ((ProcessModule)object_0).ModuleMemorySize;
	}

	internal static object iS7hDVB6I71dk8Dg2Yx(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool mi0ZPSB5hpsekQ9TG9R(object object_0, object object_1)
	{
		return (MethodInfo?)object_0 != (MethodInfo?)object_1;
	}

	internal static object QCdt93B1dmFDakGUb1m(object object_0)
	{
		return ((Delegate)object_0).Method;
	}

	internal static object AD8IHcBCAaY9dSgQ0ZU(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static object quXFyABUAMLkRq78FPR(object object_0)
	{
		return ((MethodBase)object_0).GetParameters();
	}

	internal static object aoXeKXBhgKWbmf3kMP6(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}

	internal static ModuleHandle SnyMILB9tCXrctSPI5G(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}

	internal static Type s7T5DeBkUjK8MYBSMb9(object object_0)
	{
		return object_0.GetType();
	}

	internal static object fch4apBQQIvMnirycsV(object object_0, object object_1)
	{
		return ((FieldInfo)object_0).GetValue(object_1);
	}

	internal static object xUqmogBqDnQuhXU4Zbm(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static void fyt6ByBojUirf8waGTH(object object_0)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)object_0);
	}

	internal static RuntimeMethodHandle Upxg6OBf9Dp7KTmmDnx(object object_0)
	{
		return ((MethodBase)object_0).MethodHandle;
	}

	internal static void FKefxyB2v6B3QccOFdC(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void j94yovBHZC6iNptekrd(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static IntPtr ECNpoZB0MZh1a20aSda(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		return YDsoA9ylfU(intptr_0, uint_0, uint_1, uint_2);
	}

	internal static void ScVT1hBKJMZIABp9D7p(IntPtr intptr_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, intptr_1);
	}

	internal static bool IranHmBduY2M1rn0mF()
	{
		return (object)null == null;
	}

	internal static object HVnMjPVy0dTk6K1mRH()
	{
		return null;
	}
}
