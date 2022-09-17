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
			internal static object I56yDQdO0ycsbEdrush;

			static iGR41459RDH4FvPdNk()
			{
				prXoP4RuYp();
				iXLoKRSpAw();
			}

			internal static bool jthAendWeNgXcjQl3k1()
			{
				return true;
			}

			internal static object BUfGLKdVsqoAFZK2GaK()
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

		internal static object y9R82td4CfmbnfQO8By()
		{
			return null;
		}

		internal static void zpIuU5dbDblgktSRQoZ(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static object DboPjUdEhZQ8f81vnUN(object object_0)
		{
			return null;
		}

		internal static object ngVLCpdBu1uWh9KSCyp()
		{
			return null;
		}

		internal static void b9bXucdTDGVdCYOy86m(object object_0, object object_1)
		{
		}

		internal static void k94DrydZNKjItfq1Sd4(object object_0, object object_1)
		{
		}

		internal static object MRZnfQdgMW9KcuQT7q2(object object_0)
		{
			return null;
		}

		internal static void FKchSXdFGcGIH7AUmB1(object object_0, object object_1, int int_0, int int_1)
		{
		}

		internal static object O8EdiZdUAICv5vRIryJ(object object_0)
		{
			return null;
		}

		internal static object dU2ECSdmwuueLgJjZSZ(object object_0)
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
			return (Stream)gXn5XUdYNfh1dRoxIpf(KPVkbuTpLj);
		}

		internal byte[] B2XkaLi4dH(int int_0)
		{
			return (byte[])HNxMFsdwiT67OGMRVrO(KPVkbuTpLj, int_0);
		}

		internal int hx5kqNgSj4(byte[] byte_0, int int_0, int int_1)
		{
			return KPVkbuTpLj.Read(byte_0, int_0, int_1);
		}

		internal int TVtkAMaqpL()
		{
			return Qql9Cpd8k1cSoZZFnAA(KPVkbuTpLj);
		}

		internal void VDqkQKyKML()
		{
			ydYfvXd6mtlsr7ejKgw(KPVkbuTpLj);
		}

		internal static object gXn5XUdYNfh1dRoxIpf(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static object HNxMFsdwiT67OGMRVrO(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int Qql9Cpd8k1cSoZZFnAA(object object_0)
		{
			return ((BinaryReader)object_0).ReadInt32();
		}

		internal static void ydYfvXd6mtlsr7ejKgw(object object_0)
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

	private static yy2w1VXOQgx806ubre tTVkFDSO7A;

	private static RI754BJF754hNSApRW tuYkt9D06I;

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static bool firstrundone;

	private static N7UlhA3IRW2ugh7tWg zIOkYypt1M;

	internal static QZEOeHRUkDiNqCWT0p abxkLGOVrU;

	internal static Assembly x4Dk2IHVmX;

	internal static Hashtable lmdkVksVkh;

	private static uint[] O1BkIDx0L0;

	private static bool fMAkKtNIoA;

	private static object emjkxI4Yxp;

	private static bool V9fkgxQPQA;

	private static SortedList VM5kd0GoFG;

	private static MacgPI7JyVeAhNaPvd BV0kmUIPgx;

	private static long eXJkjmTXDX;

	private static long URnkCOceLK;

	private static bool LrEkS2eXQL;

	private static int XtMknffM5M;

	internal static QZEOeHRUkDiNqCWT0p rNZkehfwNu;

	private static int CgSk1JZr60;

	internal static RSACryptoServiceProvider onZkkIlVOi;

	private static IntPtr wcyk8nIyBt;

	private static byte[] s6pkoGoeab;

	private static IntPtr K7PkOHxqAd;

	private static bool MrkkWebIMK;

	private static IntPtr VE2k4S5okQ;

	private static Dictionary<int, int> Tqek0lIh21;

	private static YLCGmBEaUwBbEqLM01 etmkyDG2SG;

	private static object WaKkhokJrA;

	private static byte[] OObkplyC7t;

	private static GL8NaIwq2KOvLQhMFX yBRkv0eFeZ;

	private static int[] zl0ksqgIH1;

	private static byte[] HkLkNdDPtB;

	private static int Qy5kfBXtEh;

	private static bool PRZkZqsNsa;

	private static bool xo4kuDarJK;

	private static IntPtr aatkD4ZSGk;

	private static int wpoklx4RIX;

	static WP6RZJql8gZrNhVA9v()
	{
		PRZkZqsNsa = false;
		x4Dk2IHVmX = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554776)).Assembly;
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

	private void CbwgdfmeXp88v()
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
		int num = 14;
		string object_ = default(string);
		HashAlgorithm object_2 = default(HashAlgorithm);
		int num4 = default(int);
		string text = default(string);
		int num6 = default(int);
		int num9 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		int num11 = default(int);
		byte[] array2 = default(byte[]);
		int num10 = default(int);
		byte[] object_5 = default(byte[]);
		Stream stream = default(Stream);
		CryptoStream object_7 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array3 = default(byte[]);
		SymmetricAlgorithm object_4 = default(SymmetricAlgorithm);
		byte[] object_6 = default(byte[]);
		int num13 = default(int);
		byte[] array5 = default(byte[]);
		BinaryReader object_8 = default(BinaryReader);
		uint num16 = default(uint);
		bool flag2 = default(bool);
		int num19 = default(int);
		byte[] array4 = default(byte[]);
		int int_ = default(int);
		long num22 = default(long);
		int num21 = default(int);
		long long_ = default(long);
		uint num15 = default(uint);
		uint num18 = default(uint);
		int num20 = default(int);
		long num25 = default(long);
		long num23 = default(long);
		long num24 = default(long);
		uint num27 = default(uint);
		uint uint_2 = default(uint);
		uint num26 = default(uint);
		uint uint_ = default(uint);
		uint num17 = default(uint);
		int num30 = default(int);
		bool flag = default(bool);
		while (onZkkIlVOi == null)
		{
			while (true)
			{
				IL_0013:
				gTEwWwgyVna9DC1GFo();
				int num2 = 0;
				if (!aexgU62ambdiJIlvn4())
				{
					goto IL_0027;
				}
				goto IL_2267;
				IL_2267:
				I6DcoCAmf3JWaf4HAb(bool_0: true);
				num2 = 1;
				if (aexgU62ambdiJIlvn4())
				{
					goto IL_0027;
				}
				goto IL_225e;
				IL_0027:
				while (true)
				{
					IL_0027_2:
					switch (num2)
					{
					case 14:
						break;
					case 13:
						goto IL_0013;
					case 17:
						object_ = null;
						goto case 16;
					case 16:
						try
						{
							object_2 = (HashAlgorithm)PfD3qd0IIhCHgsDMUp();
							int num3 = 0;
							if (RukUoNIMjxXTUk6iAu() != null)
							{
								num3 = num4;
							}
							switch (num3)
							{
							default:
								object_ = (string)YtXyMLx6dytrRjqyV7("SHA1");
								break;
							case 3:
								break;
							case 1:
								return;
							case 2:
							case 4:
								goto end_IL_0081;
							}
							if (!tm7r4ZbuCysTgAguSk(text))
							{
								return;
							}
							end_IL_0081:;
						}
						catch
						{
							int num5 = 0;
							if (!aexgU62ambdiJIlvn4())
							{
								num5 = num6;
							}
							switch (num5)
							{
							}
							return;
						}
						goto case 15;
					case 15:
						flag = false;
						goto case 8;
					case 8:
						try
						{
							VtNVUKGulysZw81C3E object_3 = new VtNVUKGulysZw81C3E((Stream)feTP3v9sAhB98qKyRA(x4Dk2IHVmX, "2OgEvbILpvliiSYxmT.CRmRCuZeKo2rjoetKV"));
							while (true)
							{
								prpSDAQ4FfJdSfVpjv(uRajovKb5QsP6MHDHu(object_3), 0L);
								int num7 = 164;
								if (RukUoNIMjxXTUk6iAu() != null)
								{
									goto IL_0150;
								}
								goto IL_1c33;
								IL_1c33:
								while (true)
								{
									switch (num7)
									{
									case 352:
										num9 = 21;
										goto case 266;
									case 266:
										array[12] = (byte)num9;
										num7 = 287;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 183;
									case 183:
										array[11] = 145;
										num7 = 257;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 351:
										num9 = 105;
										goto case 32;
									case 32:
										array[22] = (byte)num9;
										goto case 221;
									case 221:
										num8 = 123;
										goto case 220;
									case 220:
										array[22] = (byte)num8;
										goto case 206;
									case 206:
										num8 = 166;
										num7 = 154;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 350:
										array[29] = 24;
										goto case 128;
									case 128:
										array[30] = 176;
										goto case 191;
									case 191:
										array[30] = 154;
										num11 = 130;
										goto case 130;
									case 130:
										num8 = 73;
										goto case 184;
									case 184:
										array[30] = (byte)num8;
										num7 = 226;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 349:
										array[8] = 130;
										num11 = 170;
										goto case 170;
									case 170:
										num8 = 193;
										goto case 70;
									case 70:
										array[8] = (byte)num8;
										num7 = 0;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto default;
									default:
										array[8] = 100;
										goto case 108;
									case 108:
										array[8] = 129;
										num11 = 78;
										goto case 78;
									case 78:
										num9 = 102;
										num7 = 344;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 332;
									case 332:
										array[9] = 240;
										goto case 304;
									case 304:
										array[9] = 172;
										num7 = 29;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 86;
									case 86:
										num8 = 128;
										goto case 285;
									case 285:
										array[10] = (byte)num8;
										num7 = 223;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 348:
										num8 = 122;
										goto case 278;
									case 278:
										array[10] = (byte)num8;
										goto case 134;
									case 134:
										num8 = 103;
										num7 = 46;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 347:
										array[7] = (byte)num8;
										num7 = 57;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 346:
										array2[11] = (byte)num10;
										num7 = 295;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 345:
										num8 = 90;
										num11 = 185;
										goto case 185;
									case 185:
										array[27] = (byte)num8;
										num7 = 34;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 344:
										array[8] = (byte)num9;
										goto case 264;
									case 264:
										num9 = 138;
										goto case 302;
									case 302:
										array[9] = (byte)num9;
										num7 = 1;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 7;
									case 7:
										array[9] = 138;
										num11 = 76;
										goto case 76;
									case 76:
										num8 = 159;
										goto case 315;
									case 315:
										array[9] = (byte)num8;
										goto case 342;
									case 342:
										num9 = 116;
										goto case 95;
									case 95:
										array[9] = (byte)num9;
										goto case 332;
									case 343:
										num8 = 170;
										num11 = 103;
										goto case 103;
									case 103:
										array[19] = (byte)num8;
										goto case 106;
									case 106:
										array[19] = 131;
										goto case 31;
									case 31:
										num9 = 162;
										goto case 87;
									case 87:
										array[19] = (byte)num9;
										goto case 169;
									case 169:
										num9 = 220;
										num7 = 255;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 341:
										num8 = 149;
										goto case 104;
									case 104:
										array[17] = (byte)num8;
										num7 = 299;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 159;
									case 159:
										array[31] = (byte)num9;
										num7 = 253;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 340:
										num9 = 110;
										goto case 109;
									case 109:
										array[5] = (byte)num9;
										num7 = 17;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 7;
									case 339:
										num8 = 32;
										num7 = 199;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 338:
										array[25] = (byte)num9;
										goto case 22;
									case 22:
										array[25] = 144;
										num7 = 2;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 2;
									case 2:
										array[26] = 193;
										num11 = 139;
										goto case 139;
									case 139:
										num8 = 136;
										goto case 324;
									case 324:
										array[26] = (byte)num8;
										goto case 330;
									case 330:
										num8 = 108;
										goto case 60;
									case 60:
										array[26] = (byte)num8;
										goto case 300;
									case 300:
										num9 = 105;
										goto case 11;
									case 11:
										array[26] = (byte)num9;
										goto case 85;
									case 85:
										num8 = 118;
										goto case 177;
									case 177:
										array[27] = (byte)num8;
										goto case 345;
									case 337:
										array[27] = 169;
										goto case 271;
									case 271:
										num8 = 100;
										goto case 234;
									case 234:
										array[28] = (byte)num8;
										num7 = 258;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 336:
										num8 = 36;
										num7 = 179;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 320;
									case 320:
										array[23] = (byte)num8;
										num7 = 93;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 335:
										array[31] = (byte)num9;
										goto case 222;
									case 222:
										array[31] = 84;
										goto case 75;
									case 75:
										array[31] = 248;
										num11 = 205;
										goto case 205;
									case 205:
										object_5 = array;
										num7 = 334;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 334:
										array2 = new byte[16];
										goto case 256;
									case 256:
										array2[0] = 99;
										goto case 131;
									case 131:
										array2[0] = 189;
										num7 = 272;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 333:
										array[3] = (byte)num8;
										goto case 149;
									case 149:
										array[3] = 101;
										goto case 339;
									case 331:
										stream = (Stream)JSpFWT3apVo7rKWaGB();
										goto case 123;
									case 123:
										object_7 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
										goto case 162;
									case 162:
										cnSaPdpCECbvBNLVAl(object_7, array3, 0, array3.Length);
										num7 = 118;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 81;
									case 81:
										array2[5] = 167;
										num11 = 122;
										goto case 122;
									case 122:
										array2[5] = 102;
										goto case 100;
									case 100:
										array2[5] = 93;
										num7 = 260;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 329:
										array[16] = (byte)num8;
										goto case 321;
									case 321:
										array[16] = 38;
										goto case 286;
									case 286:
										num8 = 162;
										goto case 290;
									case 290:
										array[16] = (byte)num8;
										goto case 323;
									case 323:
										array[17] = 245;
										num11 = 16;
										goto case 16;
									case 16:
										num9 = 145;
										goto case 165;
									case 165:
										array[17] = (byte)num9;
										num7 = 125;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 328:
										array2[13] = 108;
										goto case 132;
									case 132:
										array2[13] = 122;
										goto case 10;
									case 10:
										num10 = 148;
										goto case 98;
									case 98:
										array2[13] = (byte)num10;
										goto case 280;
									case 280:
										num10 = 64;
										goto case 111;
									case 111:
										array2[13] = (byte)num10;
										goto case 161;
									case 161:
										num10 = 160;
										goto case 312;
									case 312:
										array2[14] = (byte)num10;
										goto case 65;
									case 65:
										array2[14] = 108;
										goto case 8;
									case 8:
										array2[14] = 123;
										num7 = 202;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 327:
										num9 = 28;
										num7 = 326;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 215;
									case 215:
										lHQ6Olv5Ri50OXZZBP(object_4, CipherMode.CBC);
										num7 = 55;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 43;
									case 43:
										array2[5] = 79;
										goto case 110;
									case 110:
										num10 = 137;
										num7 = 141;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 137;
									case 137:
										array2[12] = 37;
										num11 = 214;
										goto case 214;
									case 214:
										array2[12] = 147;
										goto case 212;
									case 212:
										num10 = 134;
										goto case 23;
									case 23:
										array2[12] = (byte)num10;
										num11 = 265;
										goto case 265;
									case 265:
										num10 = 101;
										goto case 167;
									case 167:
										array2[12] = (byte)num10;
										num7 = 216;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 326:
										array[12] = (byte)num9;
										num11 = 119;
										goto case 119;
									case 119:
										array[12] = 19;
										goto case 41;
									case 41:
										num9 = 118;
										num7 = 82;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 325:
										num10 = 164;
										goto case 90;
									case 90:
										array2[2] = (byte)num10;
										goto case 166;
									case 166:
										array2[2] = 170;
										goto case 4;
									case 4:
										array2[2] = 95;
										num7 = 20;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 195;
									case 195:
										num10 = 31;
										goto case 107;
									case 107:
										array2[3] = (byte)num10;
										num7 = 240;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 127;
									case 127:
										num8 = 156;
										num7 = 333;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 322:
										array[16] = (byte)num9;
										goto case 289;
									case 289:
										num9 = 112;
										num7 = 13;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 319:
										num9 = 155;
										num7 = 180;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 318:
										array2[7] = 92;
										goto case 69;
									case 69:
										array2[7] = 166;
										goto case 231;
									case 231:
										array2[7] = 248;
										goto case 145;
									case 145:
										array2[8] = 115;
										goto case 288;
									case 288:
										array2[8] = 113;
										goto case 192;
									case 192:
										num10 = 49;
										goto case 276;
									case 276:
										array2[8] = (byte)num10;
										goto case 313;
									case 313:
										array2[9] = 102;
										goto case 270;
									case 270:
										num10 = 105;
										goto case 148;
									case 148:
										array2[9] = (byte)num10;
										num7 = 83;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 317:
										array2[1] = (byte)num10;
										goto case 114;
									case 114:
										num10 = 84;
										num11 = 77;
										goto case 77;
									case 77:
										array2[1] = (byte)num10;
										goto case 72;
									case 72:
										array2[1] = 95;
										num7 = 136;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 316:
										num10 = 48;
										goto case 53;
									case 53:
										array2[2] = (byte)num10;
										num7 = 241;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 314:
										num9 = 167;
										goto case 292;
									case 292:
										array[14] = (byte)num9;
										num7 = 11;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 27;
									case 27:
										array[14] = 238;
										goto case 217;
									case 217:
										array[15] = 104;
										num7 = 198;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 86;
									case 311:
										array2[14] = (byte)num10;
										goto case 274;
									case 274:
										num10 = 93;
										goto case 301;
									case 301:
										array2[15] = (byte)num10;
										goto case 232;
									case 232:
										num10 = 154;
										num7 = 3;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 179;
									case 179:
										array2[15] = (byte)num10;
										goto case 5;
									case 5:
										num10 = 173;
										goto case 36;
									case 36:
										array2[15] = (byte)num10;
										goto case 92;
									case 92:
										object_6 = array2;
										goto case 296;
									case 296:
										object_4 = (SymmetricAlgorithm)LAm3QAUBdEoc2iAjfF();
										num7 = 215;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 310:
										num8 = 125;
										goto case 26;
									case 26:
										array[20] = (byte)num8;
										num7 = 194;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 49;
									case 49:
										num8 = 76;
										num7 = 45;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 8;
									case 309:
										array[14] = (byte)num8;
										goto case 314;
									case 308:
										array[10] = 157;
										num7 = 19;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 306:
										array2[7] = 92;
										num7 = 318;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 305:
										num9 = 129;
										goto case 113;
									case 113:
										array[23] = (byte)num9;
										num7 = 120;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 174;
									case 174:
										num8 = 140;
										goto case 61;
									case 61:
										array[23] = (byte)num8;
										num11 = 138;
										goto case 138;
									case 138:
										num8 = 145;
										num7 = 262;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 303:
										num9 = 115;
										num7 = 68;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 27;
									case 299:
										num8 = 106;
										num11 = 38;
										goto case 38;
									case 38:
										array[18] = (byte)num8;
										num7 = 135;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 298:
										array[6] = (byte)num8;
										goto case 54;
									case 54:
										num9 = 64;
										num7 = 158;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 94;
									case 94:
										array2[3] = (byte)num10;
										num7 = 142;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 297:
										num9 = 143;
										num7 = 237;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 295:
										num10 = 136;
										goto case 52;
									case 52:
										array2[11] = (byte)num10;
										goto case 137;
									case 294:
										num8 = 94;
										num7 = 298;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 227;
									case 227:
										array[4] = 253;
										goto case 14;
									case 14:
										num8 = 123;
										goto case 151;
									case 151:
										array[5] = (byte)num8;
										goto case 340;
									case 293:
										array2[9] = 163;
										goto case 28;
									case 28:
										num10 = 212;
										goto case 211;
									case 211:
										array2[9] = (byte)num10;
										num7 = 101;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 201;
									case 201:
										array2[10] = 75;
										goto case 268;
									case 268:
										num10 = 229;
										goto case 96;
									case 96:
										array2[10] = (byte)num10;
										goto case 242;
									case 242:
										array2[10] = 218;
										num7 = 171;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 64;
									case 64:
										num9 = 52;
										goto case 218;
									case 218:
										array[7] = (byte)num9;
										goto case 349;
									case 291:
										num8 = 139;
										num7 = 67;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 287:
										num9 = 130;
										num7 = 281;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 281;
									case 281:
										array[12] = (byte)num9;
										num7 = 249;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 284:
										num8 = 161;
										goto case 243;
									case 243:
										array[0] = (byte)num8;
										goto case 178;
									case 178:
										array[0] = 146;
										num7 = 251;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 283:
										array[24] = (byte)num8;
										num7 = 189;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 173;
									case 173:
										num8 = 17;
										goto case 39;
									case 39:
										array[25] = (byte)num8;
										num7 = 49;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 282:
										num8 = 193;
										num7 = 309;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 279:
										array[7] = 128;
										num7 = 234;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 247;
									case 247:
										num8 = 186;
										goto case 347;
									case 277:
										array[2] = 82;
										num7 = 24;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 3;
									case 3:
										array[28] = 103;
										goto case 44;
									case 44:
										num8 = 158;
										num7 = 229;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 86;
									case 275:
										array[14] = 135;
										num7 = 282;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 273:
										num9 = 152;
										num11 = 207;
										goto case 207;
									case 207:
										array[27] = (byte)num9;
										goto case 337;
									case 272:
										num10 = 144;
										num7 = 115;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 269:
										array = new byte[32];
										num7 = 21;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 6;
									case 6:
										array[21] = 139;
										goto case 235;
									case 235:
										array[22] = 134;
										goto case 351;
									case 267:
										array[25] = (byte)num8;
										num11 = 173;
										goto case 173;
									case 263:
										array[11] = (byte)num9;
										goto case 352;
									case 262:
										array[23] = (byte)num8;
										num11 = 336;
										goto case 336;
									case 261:
										array[1] = 112;
										num11 = 193;
										goto case 193;
									case 193:
										num8 = 237;
										goto case 187;
									case 187:
										array[1] = (byte)num8;
										goto case 277;
									case 260:
										array2[5] = 125;
										goto case 43;
									case 259:
										num10 = 30;
										goto case 311;
									case 258:
										array[28] = 177;
										goto case 3;
									case 257:
										num8 = 125;
										goto case 157;
									case 157:
										array[11] = (byte)num8;
										goto case 219;
									case 219:
										num9 = 128;
										num7 = 1;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 263;
									case 255:
										array[19] = (byte)num9;
										num7 = 129;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 254:
										num8 = 65;
										num7 = 329;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 152;
									case 152:
										array[14] = (byte)num8;
										num7 = 275;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 48;
									case 48:
										array[7] = 195;
										goto case 64;
									case 253:
										array[31] = 117;
										goto case 297;
									case 252:
										array[0] = 35;
										goto case 284;
									case 251:
										num8 = 87;
										num7 = 28;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 188;
									case 188:
										array[1] = (byte)num8;
										goto case 200;
									case 200:
										num9 = 117;
										goto case 163;
									case 163:
										array[1] = (byte)num9;
										num7 = 29;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 261;
									case 250:
										array[21] = 158;
										goto case 6;
									case 249:
										array[12] = 104;
										goto case 327;
									case 248:
										array[24] = (byte)num8;
										goto case 20;
									case 20:
										array[24] = 103;
										num7 = 1;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto default;
									case 246:
										num9 = 168;
										goto case 335;
									case 245:
										num9 = 86;
										num7 = 140;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 244:
										array[4] = (byte)num9;
										num7 = 227;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 241:
										num10 = 88;
										num7 = 62;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 240:
										array2[3] = 155;
										goto case 105;
									case 105:
										num10 = 70;
										num7 = 94;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 63;
									case 63:
										array[6] = 152;
										num7 = 102;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 239:
										num8 = 13;
										goto case 35;
									case 35:
										array[2] = (byte)num8;
										goto case 127;
									case 238:
										num8 = 104;
										num7 = 15;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 237:
										array[31] = (byte)num9;
										num11 = 246;
										goto case 246;
									case 236:
										num8 = 110;
										goto case 40;
									case 40:
										array[11] = (byte)num8;
										goto case 238;
									case 233:
										array[18] = (byte)num8;
										goto case 56;
									case 56:
										num8 = 121;
										num7 = 228;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 230:
										array2[4] = 88;
										goto case 186;
									case 186:
										num10 = 158;
										num7 = 160;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 229:
										array[28] = (byte)num8;
										goto case 168;
									case 168:
										num9 = 22;
										goto case 176;
									case 176:
										array[28] = (byte)num9;
										goto case 18;
									case 18:
										array[29] = 90;
										goto case 303;
									case 228:
										array[18] = (byte)num8;
										goto case 172;
									case 172:
										array[18] = 106;
										goto case 117;
									case 117:
										num8 = 105;
										goto case 84;
									case 84:
										array[18] = (byte)num8;
										num7 = 124;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 226:
										num9 = 101;
										goto case 159;
									case 225:
										num10 = 118;
										goto case 182;
									case 182:
										array2[13] = (byte)num10;
										goto case 328;
									case 224:
										num10 = 137;
										num7 = 25;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 223:
										array[10] = 98;
										goto case 348;
									case 216:
										array2[12] = 145;
										goto case 143;
									case 143:
										num10 = 214;
										goto case 209;
									case 209:
										array2[12] = (byte)num10;
										goto case 146;
									case 146:
										num10 = 148;
										goto case 156;
									case 156:
										array2[13] = (byte)num10;
										goto case 225;
									case 213:
										array[15] = 198;
										num7 = 175;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 210:
										array2[14] = 225;
										num11 = 259;
										goto case 259;
									case 208:
										M4UNFrTyEhYSxLvYst(object_7);
										num7 = 30;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 27;
									case 204:
										array[20] = (byte)num9;
										num11 = 181;
										goto case 181;
									case 181:
										array[20] = 168;
										goto case 116;
									case 116:
										array[21] = 51;
										goto case 250;
									case 203:
										num9 = 132;
										goto case 244;
									case 202:
										array2[14] = 89;
										goto case 210;
									case 199:
										array[3] = (byte)num8;
										goto case 33;
									case 33:
										array[3] = 73;
										num11 = 91;
										goto case 91;
									case 91:
										array[4] = 122;
										num7 = 120;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 198:
										num9 = 82;
										num7 = 126;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 197:
										num10 = 134;
										goto case 71;
									case 71:
										array2[6] = (byte)num10;
										goto case 47;
									case 47:
										array2[6] = 60;
										goto case 306;
									case 196:
										array[24] = 100;
										goto case 89;
									case 89:
										num8 = 154;
										goto case 248;
									case 194:
										num9 = 161;
										goto case 204;
									case 190:
										array[17] = (byte)num8;
										num7 = 341;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 189:
										num8 = 117;
										num7 = 267;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 180:
										array[2] = (byte)num9;
										goto case 239;
									case 175:
										array[16] = 94;
										num11 = 37;
										goto case 37;
									case 37:
										num9 = 163;
										goto case 322;
									case 171:
										array2[11] = 116;
										num7 = 54;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 59;
									case 59:
										num10 = 116;
										num11 = 346;
										goto case 346;
									case 164:
										array3 = (byte[])WM9su256ury1RM17Lp(object_3, (int)lt5LF0ecEnjueC9Jfl(uRajovKb5QsP6MHDHu(object_3)));
										goto case 269;
									case 160:
										array2[4] = (byte)num10;
										num7 = 42;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 158:
										array[6] = (byte)num9;
										num7 = 15;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 133;
									case 133:
										array[7] = 103;
										goto case 279;
									case 155:
										array[11] = 122;
										goto case 183;
									case 154:
										array[22] = (byte)num8;
										num11 = 305;
										goto case 305;
									case 153:
										num9 = 181;
										goto case 338;
									case 150:
										num8 = 148;
										num11 = 152;
										goto case 152;
									case 147:
										array2[2] = 100;
										num11 = 316;
										goto case 316;
									case 144:
										array[2] = (byte)num9;
										num7 = 73;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 142:
										array2[4] = 113;
										goto case 230;
									case 141:
										array2[6] = (byte)num10;
										num11 = 197;
										goto case 197;
									case 140:
										array[4] = (byte)num9;
										goto case 203;
									case 136:
										array2[1] = 153;
										goto case 224;
									case 135:
										num8 = 116;
										goto case 233;
									case 129:
										array[19] = 111;
										goto case 291;
									case 126:
										array[15] = (byte)num9;
										goto case 213;
									case 125:
										array[17] = 95;
										goto case 66;
									case 66:
										num8 = 150;
										num7 = 165;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 190;
									case 124:
										array[18] = 133;
										goto case 343;
									case 121:
										yyGhjpEy1gOGJOmpjy(onZkkIlVOi, e6EaHdrHYmb7QIX6ok(j449JTOZZyDBd1gMWE(), kho5ZNl5AjvdlYnsWH(stream)));
										num7 = 58;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 120:
										array[4] = 130;
										num7 = 58;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 245;
									case 118:
										YSZZ5lJlmA6tl8Dh9V(object_7);
										goto case 121;
									case 115:
										array2[0] = (byte)num10;
										num7 = 29;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 51;
									case 51:
										num10 = 155;
										num11 = 317;
										goto case 317;
									case 112:
										array[14] = 100;
										goto case 150;
									case 102:
										array[6] = 130;
										num7 = 294;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 99:
										array[0] = (byte)num8;
										goto case 252;
									case 97:
										array[13] = (byte)num8;
										goto case 9;
									case 9:
										array[13] = 94;
										goto case 74;
									case 74:
										array[13] = 22;
										num7 = 112;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 55;
									case 55:
										transform = (ICryptoTransform)sVMAvVPgGZWilJKj6r(object_4, object_5, object_6);
										goto case 331;
									case 93:
										array[24] = 117;
										num7 = 196;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto case 155;
									case 88:
										array[7] = (byte)num9;
										num11 = 48;
										goto case 48;
									case 83:
										array2[9] = 134;
										goto case 293;
									case 82:
										array[13] = (byte)num9;
										goto case 29;
									case 29:
										num8 = 89;
										goto case 97;
									case 80:
										num10 = 148;
										num7 = 79;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 79:
										array2[5] = (byte)num10;
										goto case 81;
									case 73:
										array[2] = 211;
										goto case 319;
									case 68:
										array[29] = (byte)num9;
										goto case 350;
									case 67:
										array[19] = (byte)num8;
										num11 = 310;
										goto case 310;
									case 62:
										array2[2] = (byte)num10;
										goto case 325;
									case 58:
										M4UNFrTyEhYSxLvYst(stream);
										num7 = 208;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 57:
										num9 = 169;
										num11 = 88;
										goto case 88;
									case 50:
										array[27] = 135;
										goto case 273;
									case 46:
										array[10] = (byte)num8;
										num7 = 308;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 45:
										array[25] = (byte)num8;
										num11 = 153;
										goto case 153;
									case 42:
										array2[4] = 84;
										num7 = 65;
										if (!aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto case 80;
									case 34:
										array[27] = 124;
										num7 = 50;
										if (aexgU62ambdiJIlvn4())
										{
											continue;
										}
										goto IL_0150;
									case 30:
										qpQY3hD791Qrnq3uOQ(object_3);
										num7 = 307;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 25:
										array2[1] = (byte)num10;
										goto case 12;
									case 12:
										array2[1] = 195;
										num7 = 147;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										goto IL_0150;
									case 24:
										num9 = 102;
										goto case 144;
									case 21:
										num8 = 142;
										goto case 99;
									case 19:
										array[10] = 96;
										goto case 236;
									case 17:
										array[5] = 173;
										goto case 63;
									case 15:
										array[11] = (byte)num8;
										goto case 155;
									case 13:
										array[16] = (byte)num9;
										goto case 254;
									case 1:
										num8 = 110;
										goto case 283;
									case 101:
										break;
									case 307:
										goto end_IL_21c1;
									}
									break;
								}
								continue;
								IL_0150:
								num7 = num11;
								goto IL_1c33;
								continue;
								end_IL_21c1:
								break;
							}
						}
						catch
						{
							int num12 = 1;
							if (!aexgU62ambdiJIlvn4())
							{
								goto IL_21fe;
							}
							goto IL_2212;
							IL_2212:
							switch (num12)
							{
							case 1:
								break;
							default:
								goto end_IL_21f0;
							}
							goto IL_21fe;
							IL_21fe:
							flag = true;
							num12 = 0;
							if (!aexgU62ambdiJIlvn4())
							{
								num12 = num13;
							}
							goto IL_2212;
							end_IL_21f0:;
						}
						goto case 10;
					case 11:
						goto IL_2238;
					case 4:
						goto IL_2267;
					case 3:
						while (wnRUxWYUnrqZevFYVT(text) == 0)
						{
							num2 = 7;
							if (RukUoNIMjxXTUk6iAu() == null)
							{
								goto IL_0027_2;
							}
						}
						goto IL_2298;
					case 1:
						goto IL_22ad;
					default:
						if (text == null)
						{
							return;
						}
						goto case 3;
					case 10:
						if (!flag)
						{
							num2 = 2;
							if (RukUoNIMjxXTUk6iAu() != null)
							{
								continue;
							}
							goto case 2;
						}
						goto case 6;
					case 2:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num14 = 37;
							if (!aexgU62ambdiJIlvn4())
							{
								goto IL_233d;
							}
							goto IL_2881;
							IL_2881:
							while (true)
							{
								int num28;
								switch (num14)
								{
								case 75:
									array5 = (byte[])pYlbQijy2fHlcrNYno(object_8, (int)num16);
									goto case 70;
								case 70:
									eAlnJAacIRPD59UNWv(array5);
									goto case 46;
								case 46:
									flag = !WM36D5q2vYJ1X9yWT7(onZkkIlVOi, HpisH2XChkBTO8O233(object_2), object_, array5);
									num14 = 9;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 74:
									flag2 = GudScqWoQukoynhuqn(object_8) != 523;
									num19 = 29;
									goto case 29;
								case 29:
									if (flag2)
									{
										num14 = 0;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 27;
									}
									goto case 4;
								case 27:
									num28 = 96;
									goto IL_237c;
								case 4:
									num28 = 112;
									goto IL_237c;
								case 20:
									prpSDAQ4FfJdSfVpjv(fileStream, 152L);
									goto case 39;
								case 39:
									LdHmKAyUxk4Xibda5T(fileStream, array4, 0, int_);
									goto case 69;
								case 69:
									array4[64] = 0;
									goto case 51;
								case 51:
									array4[65] = 0;
									num14 = 0;
									if (RukUoNIMjxXTUk6iAu() != null)
									{
										continue;
									}
									goto case 8;
								case 8:
									array4[66] = 0;
									goto case 28;
								case 28:
									array4[67] = 0;
									num14 = 55;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									goto case 50;
								case 50:
									array4[34] = 0;
									num14 = 62;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 73:
									array4[39] = 0;
									goto case 61;
								case 61:
									SN6vTOdP1wr2jkTCJL(object_2, array4, 0, 128);
									goto case 40;
								case 40:
									num22 = jwj10l4dNVSCZCnU8Y(fileStream);
									goto case 42;
								case 42:
									prpSDAQ4FfJdSfVpjv(fileStream, 134L);
									num14 = 54;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 72:
									array4[32] = 0;
									num14 = 16;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 71:
									yrpAIYkS847MMFqeP2(object_2, fileStream, (uint)(num21 * 40), array4);
									goto case 56;
								case 56:
									long_ = jwj10l4dNVSCZCnU8Y(fileStream);
									num14 = 41;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									goto case 25;
								case 25:
									if (num15 < num18)
									{
										num19 = 32;
										goto case 32;
									}
									goto case 52;
								case 32:
									num18 -= num15;
									num14 = 0;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 52:
								case 65:
									num20++;
									num14 = 24;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 68:
									num25 = num23 + num16;
									num14 = 43;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 25;
								case 67:
									LdHmKAyUxk4Xibda5T(fileStream, array4, 0, 128);
									num14 = 72;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 57:
								case 66:
									if (num24 < num25)
									{
										num19 = 17;
										goto case 17;
									}
									goto case 59;
								case 17:
								case 53:
									num27 = (uint)BHLrDtcK0IxjjG9i1H(num23 - num24, num18);
									num14 = 4;
									if (!aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 5;
								case 5:
									yrpAIYkS847MMFqeP2(object_2, fileStream, num27, array4);
									goto case 10;
								case 10:
									num18 -= num27;
									num14 = 63;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 59:
									yrpAIYkS847MMFqeP2(object_2, fileStream, num18, array4);
									goto case 52;
								case 18:
								case 64:
									uint_2 = hQCf57uURjpRkZfcpL(object_8);
									goto case 35;
								case 35:
									num26 = UKfFsNGmuk8GfxImk2(uint_2, num21, num22, object_8);
									num19 = 6;
									goto case 6;
								case 6:
									prpSDAQ4FfJdSfVpjv(fileStream, num26 + 32);
									num14 = 7;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 3;
								case 3:
									prpSDAQ4FfJdSfVpjv(fileStream, num23);
									goto case 75;
								case 11:
								case 58:
								case 63:
									if (num18 == 0)
									{
										goto case 52;
									}
									goto case 30;
								case 30:
								case 36:
									num24 = jwj10l4dNVSCZCnU8Y(fileStream);
									num19 = 45;
									goto case 45;
								case 45:
									if (num23 > num24)
									{
										goto case 57;
									}
									goto case 38;
								case 38:
									if (num24 >= num25)
									{
										goto case 57;
									}
									num14 = 9;
									if (!aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 22;
								case 22:
									num15 = (uint)(num25 - num24);
									goto case 25;
								case 62:
									array4[35] = 0;
									num14 = 22;
									if (!aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 23;
								case 23:
									array4[36] = 0;
									num14 = 14;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 60:
									prpSDAQ4FfJdSfVpjv(fileStream, num22 + num20 * 40 + 16L);
									num14 = 33;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 55:
									SN6vTOdP1wr2jkTCJL(object_2, array4, 0, int_);
									num14 = 67;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 54:
									num21 = GudScqWoQukoynhuqn(object_8);
									num14 = 1;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									goto case 1;
								case 1:
									prpSDAQ4FfJdSfVpjv(fileStream, num22);
									num14 = 71;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 17;
								case 49:
									num23 = UKfFsNGmuk8GfxImk2(uint_, num21, num22, object_8);
									num14 = 68;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 48:
									num20 = 0;
									goto case 2;
								case 2:
								case 24:
									if (num20 >= num21)
									{
										num14 = 31;
										if (RukUoNIMjxXTUk6iAu() == null)
										{
											continue;
										}
										break;
									}
									goto case 60;
								case 47:
									yrpAIYkS847MMFqeP2(object_2, fileStream, 152u, array4);
									num14 = 74;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 21:
								case 44:
									prpSDAQ4FfJdSfVpjv(fileStream, 376L);
									goto case 18;
								case 43:
									prpSDAQ4FfJdSfVpjv(fileStream, long_);
									num19 = 48;
									goto case 48;
								case 41:
									if (!flag2)
									{
										num14 = 43;
										if (RukUoNIMjxXTUk6iAu() != null)
										{
											continue;
										}
										goto case 21;
									}
									goto case 34;
								case 34:
									prpSDAQ4FfJdSfVpjv(fileStream, 360L);
									num14 = 64;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 37:
									object_8 = new BinaryReader(fileStream);
									num14 = 13;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 33:
									num18 = hQCf57uURjpRkZfcpL(object_8);
									num14 = 19;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 31:
									paesq7ieIVVfh2S9VR(object_2, new byte[0], 0, 0);
									num14 = 3;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 26:
									array4[38] = 0;
									goto case 73;
								case 19:
									num17 = hQCf57uURjpRkZfcpL(object_8);
									goto case 12;
								case 12:
									prpSDAQ4FfJdSfVpjv(fileStream, num17);
									goto case 11;
								case 16:
									array4[33] = 0;
									num14 = 50;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 15:
									num16 = hQCf57uURjpRkZfcpL(object_8);
									goto case 49;
								case 14:
									array4[37] = 0;
									goto case 26;
								case 13:
									array4 = new byte[65536];
									num14 = 47;
									if (RukUoNIMjxXTUk6iAu() == null)
									{
										continue;
									}
									break;
								case 7:
									uint_ = hQCf57uURjpRkZfcpL(object_8);
									goto case 15;
								default:
									prpSDAQ4FfJdSfVpjv(fileStream, jwj10l4dNVSCZCnU8Y(fileStream) + num15);
									goto case 11;
								case 9:
									goto end_IL_2881;
									IL_237c:
									int_ = num28;
									num14 = 20;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									goto case 20;
								}
								goto IL_233d;
								continue;
								end_IL_2881:
								break;
							}
							goto end_IL_22e3;
							IL_233d:
							num14 = num19;
							goto IL_2881;
							end_IL_22e3:;
						}
						catch
						{
							int num29 = 1;
							if (!aexgU62ambdiJIlvn4())
							{
								num29 = num30;
							}
							while (true)
							{
								switch (num29)
								{
								case 1:
									flag = true;
									num29 = 0;
									if (aexgU62ambdiJIlvn4())
									{
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 6;
					case 6:
						if (!flag)
						{
							goto case 9;
						}
						goto case 12;
					case 9:
						flag = false;
						return;
					case 12:
						throw new Exception((string?)eyOHhpHn4ophUD4Tvj(gB58FyLfm3oJ23rF4i(pSbeF3NG0jdXSk2aLk(GUa2FLoXcy8vGsaB6N(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)), " is tampered."));
					case 7:
					case 18:
						return;
					case 5:
						return;
					}
					break;
					IL_22ad:
					onZkkIlVOi = new RSACryptoServiceProvider();
					num2 = 11;
					if (aexgU62ambdiJIlvn4())
					{
						continue;
					}
					goto IL_225e;
					IL_2298:
					object_2 = null;
					num2 = 17;
					if (aexgU62ambdiJIlvn4())
					{
						continue;
					}
					goto IL_225e;
					IL_2238:
					text = (string)YUPc1g8xZQbot3fv7V(GUa2FLoXcy8vGsaB6N(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly);
					num2 = 0;
					if (RukUoNIMjxXTUk6iAu() == null)
					{
						continue;
					}
					goto IL_225e;
				}
				break;
				IL_225e:
				num2 = num;
				goto IL_0027;
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
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554776)).Assembly.GetManifestResourceStream("V4aDRx3IN2aKgG3XCQ.HnqBMqttwKQLNIbf8m"));
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
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554776)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(16777238));
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
		int num = 306;
		VtNVUKGulysZw81C3E object_ = default(VtNVUKGulysZw81C3E);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		byte[] array4 = default(byte[]);
		int int_ = default(int);
		int num26 = default(int);
		int num25 = default(int);
		int num6 = default(int);
		uint num7 = default(uint);
		uint num18 = default(uint);
		byte[] array7 = default(byte[]);
		uint num20 = default(uint);
		int num22 = default(int);
		int num19 = default(int);
		uint num11 = default(uint);
		uint num9 = default(uint);
		int num12 = default(int);
		uint num13 = default(uint);
		byte[] array5 = default(byte[]);
		int num8 = default(int);
		byte[] array2 = default(byte[]);
		int num21 = default(int);
		byte[] array6 = default(byte[]);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		uint num10 = default(uint);
		byte[] array3 = default(byte[]);
		int num17 = default(int);
		uint num16 = default(uint);
		string result = default(string);
		int num4 = default(int);
		while (true)
		{
			IL_26a4:
			int num2;
			if (HkLkNdDPtB.Length != 0)
			{
				num2 = 305;
				if (G8BecZLbcd92c40CuR() != null)
				{
					goto IL_0055;
				}
				goto IL_1fc7;
			}
			goto IL_2677;
			IL_0055:
			num2 = num;
			goto IL_1fc7;
			IL_2677:
			object_ = new VtNVUKGulysZw81C3E((Stream)vPkG6pjVQ8YP21IxMN(x4Dk2IHVmX, "LKTc8cbH37QYBQ0aaS.5u6CVInWaqd1j2h87B"));
			goto IL_264d;
			IL_264d:
			TeQhgZqOWEZRyfYR3h(gZXhgH25T85f2SiTrO(object_), 0L);
			num2 = 103;
			if (!dfgfXZWBpNPNxBJrEf())
			{
				goto IL_0055;
			}
			goto IL_1fc7;
			IL_1fc7:
			while (true)
			{
				switch (num2)
				{
				case 414:
					array[15] = (byte)num5;
					num = 330;
					goto case 330;
				case 330:
					num5 = 143;
					num = 52;
					goto case 52;
				case 52:
					array[15] = (byte)num5;
					num2 = 200;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 77:
				case 413:
					if (num14 >= num15)
					{
						goto case 85;
					}
					goto case 404;
				case 85:
					HkLkNdDPtB = array4;
					goto case 254;
				case 254:
				case 305:
					int_ = J22yGrJuwLLyKmEl30(HkLkNdDPtB, int_0);
					num2 = 387;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 404:
					num26 = num14 % num25;
					goto case 340;
				case 340:
					num6 = num14 * 4;
					goto case 182;
				case 182:
					num7 = (uint)(num26 * 4);
					goto case 74;
				case 74:
					num18 = (uint)((array7[num7 + 3] << 24) | (array7[num7 + 2] << 16) | (array7[num7 + 1] << 8) | array7[num7]);
					goto case 401;
				case 401:
					num20 = 255u;
					goto case 93;
				case 93:
					num22 = 0;
					num = 146;
					goto case 146;
				case 146:
					if (num14 == num15 - 1)
					{
						goto case 71;
					}
					goto case 199;
				case 71:
					if (num19 > 0)
					{
						goto case 271;
					}
					goto case 199;
				case 271:
					num11 = 0u;
					goto case 188;
				case 188:
					num9 += num18;
					goto case 239;
				case 239:
					num12 = 0;
					goto case 138;
				case 138:
				case 326:
					if (num12 >= num19)
					{
						goto case 137;
					}
					goto case 412;
				case 137:
				case 230:
					num13 = num9;
					num2 = 84;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 412:
					if (num12 > 0)
					{
						goto case 399;
					}
					goto case 44;
				case 399:
					num11 <<= 8;
					goto case 44;
				case 44:
					num11 |= array5[^(1 + num12)];
					num2 = 119;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 199:
					num9 += num18;
					num2 = 26;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 411:
					num8 = 34;
					goto case 372;
				case 372:
					array2[13] = (byte)num8;
					goto case 76;
				case 76:
					num8 = 97;
					num2 = 13;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 38;
				case 38:
					array2[13] = (byte)num8;
					num2 = 266;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 410:
					num22 += 8;
					num2 = 177;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 409:
					array[23] = (byte)num5;
					num2 = 14;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 408:
					num5 = 152;
					goto case 218;
				case 218:
					array[29] = (byte)num5;
					num2 = 96;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 148;
				case 148:
					num5 = 86;
					num2 = 354;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 407:
					num5 = 87;
					num2 = 152;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 274;
				case 274:
					array[13] = (byte)num5;
					goto case 192;
				case 192:
					num5 = 121;
					goto case 202;
				case 202:
					array[13] = (byte)num5;
					goto case 363;
				case 363:
					num5 = 145;
					goto case 313;
				case 313:
					array[14] = (byte)num5;
					goto case 153;
				case 153:
					num5 = 91;
					num2 = 144;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 167;
				case 167:
					array[14] = (byte)num5;
					goto case 47;
				case 47:
					num5 = 84;
					num2 = 132;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 406:
					num5 = 94;
					goto case 263;
				case 263:
					array[27] = (byte)num5;
					num2 = 365;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 405:
					num8 = 145;
					num = 197;
					goto case 197;
				case 197:
					array2[13] = (byte)num8;
					num2 = 411;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 272;
				case 272:
					array[31] = (byte)num5;
					goto case 286;
				case 286:
					num5 = 120;
					num2 = 80;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 157;
				case 157:
					array[31] = (byte)num5;
					num2 = 298;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 226:
				case 403:
					num14++;
					num2 = 77;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 402:
					array2[3] = 166;
					goto case 279;
				case 279:
					array2[3] = 166;
					goto case 41;
				case 41:
					array2[3] = 115;
					num2 = 212;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 398:
					num8 = 188;
					goto case 37;
				case 37:
					array2[5] = (byte)num8;
					goto case 356;
				case 356:
					array2[5] = 71;
					goto case 376;
				case 376:
					num8 = 29;
					num2 = 108;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 397:
					array[26] = 149;
					num2 = 219;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 273;
				case 273:
					array[26] = 32;
					num = 353;
					goto case 353;
				case 353:
					num5 = 162;
					num2 = 216;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 396:
					num7 = 0u;
					num2 = 170;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 207:
					array7[num21] = (byte)(array7[num21] ^ array6[num21]);
					num = 34;
					goto case 34;
				case 34:
					num21++;
					num = 395;
					goto case 262;
				case 262:
				case 395:
					if (num21 < array6.Length)
					{
						goto case 207;
					}
					num = 220;
					goto case 220;
				case 220:
					if (int_0 == -1)
					{
						goto case 82;
					}
					goto case 140;
				case 82:
					object_3 = (SymmetricAlgorithm)ovewT5DACiRaqfYEn1();
					num = 83;
					goto case 83;
				case 83:
					g3duGNyphuWUfEPeWv(object_3, CipherMode.CBC);
					goto case 302;
				case 302:
					transform = (ICryptoTransform)Ituu75B8316DFUfPme(object_3, array7, array6);
					goto case 367;
				case 367:
					stream = (Stream)r6wYcnYveJ0B0N3gKH();
					goto case 122;
				case 122:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 384;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 366;
				case 366:
					array[8] = 88;
					goto case 45;
				case 45:
					array[8] = 211;
					goto case 388;
				case 388:
					array[9] = 102;
					num2 = 229;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 140:
					num19 = array5.Length % 4;
					goto case 53;
				case 53:
					num15 = array5.Length / 4;
					goto case 57;
				case 57:
					array4 = new byte[array5.Length];
					goto case 162;
				case 162:
					num25 = array7.Length / 4;
					num2 = 61;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 147;
				case 147:
					num9 = 0u;
					num2 = 206;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 394:
					array2[9] = (byte)num8;
					num2 = 344;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 393:
					array[25] = 142;
					num2 = 309;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 392:
					array[27] = 86;
					num2 = 158;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 62;
				case 62:
					array2[15] = 153;
					goto case 104;
				case 104:
					num8 = 106;
					goto case 257;
				case 257:
					array2[15] = (byte)num8;
					num2 = 0;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 9;
				case 9:
					num8 = 84;
					goto case 31;
				case 31:
					array2[15] = (byte)num8;
					num2 = 183;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 156;
				case 156:
					array2[0] = 148;
					num2 = 355;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 391:
					w3e8mXwI67OUxkRG6Y(object_);
					goto case 69;
				case 69:
					array = new byte[32];
					num2 = 5;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 390:
					array[12] = 180;
					num2 = 22;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 4;
				case 4:
					num8 = 96;
					goto case 151;
				case 151:
					array2[12] = (byte)num8;
					num2 = 244;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 389:
					array[0] = (byte)num5;
					goto case 241;
				case 241:
					array[0] = 24;
					num2 = 20;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 386:
					array[2] = 121;
					goto case 294;
				case 294:
					array[2] = 167;
					num2 = 97;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 385:
					num8 = 93;
					num2 = 277;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 384:
					l9UCNNOJxNNfdkO4lH(object_2, array5, 0, array5.Length);
					num2 = 46;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 383:
					array[28] = 186;
					goto case 408;
				case 382:
					array[0] = (byte)num5;
					goto case 135;
				case 135:
					num5 = 148;
					num = 299;
					goto case 299;
				case 299:
					array[0] = (byte)num5;
					num2 = 129;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 93;
				case 381:
					array[7] = (byte)num5;
					num2 = 280;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 380:
					array2[8] = 154;
					goto case 21;
				case 21:
					array2[8] = 117;
					goto case 324;
				case 324:
					array2[8] = 112;
					num = 110;
					goto case 110;
				case 110:
					array2[8] = 154;
					goto case 300;
				case 300:
					num8 = 161;
					goto case 96;
				case 96:
					array2[8] = (byte)num8;
					num = 246;
					goto case 246;
				case 246:
					num8 = 68;
					num2 = 394;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 379:
					array[26] = (byte)num5;
					num2 = 154;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 148;
				case 378:
					num5 = 66;
					num2 = 144;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 377:
					num5 = 158;
					num2 = 187;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 375:
					array2[12] = 166;
					goto case 4;
				case 374:
					array[29] = (byte)num5;
					num2 = 98;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 155;
				case 155:
					array[29] = 146;
					num2 = 98;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 373:
					array[3] = 86;
					goto case 179;
				case 179:
					num5 = 88;
					num2 = 29;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 371:
					array2[14] = (byte)num8;
					goto case 11;
				case 11:
					array2[14] = 210;
					num2 = 223;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 370:
					array2[0] = (byte)num8;
					goto case 156;
				case 369:
					array2[1] = (byte)num8;
					goto case 317;
				case 317:
					num8 = 152;
					num2 = 191;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 121;
				case 121:
					array[23] = (byte)num5;
					goto case 8;
				case 8:
					num5 = 152;
					goto case 409;
				case 368:
					array4[num6] = (byte)(num10 & 0xFFu);
					num2 = 35;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 365:
					num5 = 189;
					goto case 176;
				case 176:
					array[27] = (byte)num5;
					num2 = 392;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 61;
				case 61:
					array6 = array2;
					goto case 40;
				case 40:
					OsoodUd5sGFQq8OFV2(array6);
					num2 = 86;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 364:
				{
					uint num23 = num13;
					uint num24 = num13;
					num24 ^= num24 << 7;
					num24 += 41672594;
					num24 ^= num24 >> 9;
					num24 += 2854470793u;
					num24 ^= num24 << 5;
					num24 += 3172641384u;
					num24 = 3372378988u - num24;
					num13 = num23 + (uint)(double)num24;
					num2 = 123;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				}
				case 362:
					num5 = 140;
					goto case 168;
				case 168:
					array[19] = (byte)num5;
					num2 = 76;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 336;
				case 336:
					array[19] = 198;
					num = 184;
					goto case 184;
				case 184:
					num5 = 142;
					goto case 161;
				case 161:
					array[20] = (byte)num5;
					num2 = 338;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 361:
					array2[7] = 78;
					goto case 215;
				case 215:
					num8 = 126;
					num2 = 180;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 360:
					array2[6] = 77;
					goto case 385;
				case 359:
					array[20] = 145;
					goto case 240;
				case 240:
					num5 = 134;
					goto case 195;
				case 195:
					array[20] = (byte)num5;
					goto case 285;
				case 285:
					array[21] = 142;
					num2 = 293;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 358:
					array2[4] = (byte)num8;
					goto case 357;
				case 357:
					num8 = 56;
					goto case 235;
				case 235:
					array2[4] = (byte)num8;
					goto case 133;
				case 133:
					array2[4] = 58;
					goto case 39;
				case 39:
					array2[5] = 165;
					num2 = 78;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 398;
				case 355:
					num8 = 89;
					goto case 269;
				case 269:
					array2[0] = (byte)num8;
					goto case 79;
				case 79:
					array2[0] = 168;
					goto case 301;
				case 301:
					num8 = 114;
					num2 = 18;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 25;
				case 25:
					array2[1] = (byte)num8;
					goto case 185;
				case 185:
					num8 = 88;
					goto case 350;
				case 350:
					array2[1] = (byte)num8;
					goto case 55;
				case 55:
					array2[1] = 110;
					goto case 70;
				case 70:
					num8 = 125;
					num2 = 78;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 354:
					array[29] = (byte)num5;
					goto case 322;
				case 322:
					num5 = 118;
					num2 = 374;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 352:
					array[11] = 133;
					num2 = 48;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 351:
					array[13] = (byte)num5;
					goto case 407;
				case 349:
					array[16] = (byte)num5;
					num2 = 303;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 348:
					num5 = 169;
					goto case 287;
				case 287:
					array[3] = (byte)num5;
					goto case 315;
				case 315:
					num5 = 88;
					num = 343;
					goto case 343;
				case 343:
					array[3] = (byte)num5;
					goto case 373;
				case 347:
					num5 = 151;
					num2 = 33;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 15;
				case 15:
					array2[14] = 114;
					goto case 36;
				case 36:
					num8 = 70;
					num = 371;
					goto case 371;
				case 346:
					num5 = 132;
					goto case 381;
				case 345:
					num5 = 192;
					num2 = 225;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 200;
				case 200:
					num5 = 88;
					goto case 114;
				case 114:
					array[15] = (byte)num5;
					goto case 194;
				case 194:
					num5 = 148;
					num2 = 281;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 344:
					array2[9] = 74;
					num2 = 98;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 106;
				case 106:
					array2[9] = 31;
					goto case 111;
				case 111:
					array2[10] = 155;
					goto case 105;
				case 105:
					array2[10] = 148;
					goto case 214;
				case 214:
					array2[10] = 191;
					goto case 221;
				case 221:
					array2[11] = 105;
					goto case 116;
				case 116:
					num8 = 142;
					goto case 209;
				case 209:
					array2[11] = (byte)num8;
					goto case 312;
				case 312:
					array2[11] = 93;
					num2 = 87;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 102;
				case 102:
					num8 = 144;
					goto case 99;
				case 99:
					array2[11] = (byte)num8;
					num2 = 30;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 128;
				case 128:
					array2[12] = 132;
					goto case 320;
				case 320:
					array2[12] = 86;
					num2 = 375;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 185;
				case 342:
					num15++;
					num2 = 396;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 339:
					num11 = (uint)((array5[num7 + 3] << 24) | (array5[num7 + 2] << 16) | (array5[num7 + 1] << 8) | array5[num7]);
					goto case 137;
				case 338:
					array[20] = 144;
					goto case 251;
				case 251:
					array[20] = 96;
					goto case 359;
				case 337:
					array[18] = 98;
					goto case 248;
				case 248:
					num5 = 115;
					goto case 7;
				case 7:
					array[18] = (byte)num5;
					num2 = 1;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto default;
				default:
					array[12] = (byte)num5;
					num2 = 171;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 245;
				case 245:
					array[12] = 29;
					goto case 332;
				case 332:
					num5 = 162;
					goto case 351;
				case 335:
					array[24] = 136;
					num2 = 33;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 316;
				case 316:
					num5 = 131;
					num2 = 50;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 100;
				case 100:
					array[24] = (byte)num5;
					num2 = 175;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 334:
					array2[13] = 114;
					num2 = 405;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 333:
					array[28] = (byte)num5;
					goto case 291;
				case 291:
					num5 = 90;
					num2 = 28;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 331:
					array2[13] = (byte)num8;
					goto case 15;
				case 329:
					num8 = 9;
					num = 125;
					goto case 125;
				case 125:
					array2[12] = (byte)num8;
					num = 334;
					goto case 334;
				case 328:
					array2[15] = (byte)num8;
					goto case 61;
				case 327:
					array2[7] = 138;
					goto case 361;
				case 325:
					array[17] = 127;
					goto case 127;
				case 127:
					array[17] = 116;
					num2 = 205;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 323:
					num5 = 67;
					goto case 379;
				case 321:
					array6[7] = array3[3];
					num2 = 268;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 319:
					HkLkNdDPtB = (byte[])iCSXCShcv4bNZdTAHl(stream);
					goto case 42;
				case 42:
					SMqsktKAMoNH6tu4PK(stream);
					goto case 282;
				case 282:
					SMqsktKAMoNH6tu4PK(object_2);
					num2 = 66;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 163;
				case 163:
					array5 = HkLkNdDPtB;
					goto case 140;
				case 318:
					num5 = 164;
					goto case 43;
				case 43:
					array[7] = (byte)num5;
					goto case 258;
				case 258:
					array[8] = 130;
					goto case 32;
				case 32:
					array[8] = 122;
					num2 = 366;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 314:
					array[31] = 164;
					num2 = 250;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 311:
					num17++;
					goto case 19;
				case 256:
					if (num17 > 0)
					{
						num2 = 253;
						if (dfgfXZWBpNPNxBJrEf())
						{
							continue;
						}
						goto IL_0055;
					}
					goto case 177;
				case 177:
					array4[num6 + num17] = (byte)((num16 & num20) >> num22);
					goto case 311;
				case 19:
				case 66:
					if (num17 < num19)
					{
						goto case 256;
					}
					num2 = 226;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 203;
				case 203:
					num5 = 62;
					goto case 121;
				case 310:
					array[27] = (byte)num5;
					goto case 247;
				case 247:
					array[28] = 120;
					num2 = 68;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 309:
					num5 = 158;
					goto case 118;
				case 118:
					array[25] = (byte)num5;
					goto case 160;
				case 160:
					num5 = 106;
					num2 = 267;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 39;
				case 308:
					num5 = 121;
					goto case 131;
				case 131:
					array[16] = (byte)num5;
					goto case 290;
				case 290:
					num5 = 193;
					goto case 149;
				case 149:
					array[16] = (byte)num5;
					goto case 237;
				case 237:
					array[17] = 134;
					num = 17;
					goto case 17;
				case 17:
					array[17] = 138;
					goto case 325;
				case 307:
					array[6] = 93;
					goto case 304;
				case 304:
					array[6] = 109;
					goto case 236;
				case 236:
					num5 = 114;
					num = 181;
					goto case 181;
				case 181:
					array[7] = (byte)num5;
					num2 = 104;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 152;
				case 152:
					array[7] = 106;
					num2 = 131;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 346;
				case 303:
					num5 = 153;
					num2 = 59;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 298:
					num5 = 146;
					num2 = 178;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 297:
					array[2] = (byte)num5;
					num2 = 386;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 296:
					array2[12] = (byte)num8;
					num2 = 73;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 329;
				case 295:
					array6[5] = array3[2];
					goto case 321;
				case 293:
					array[21] = 98;
					goto case 13;
				case 13:
					num5 = 121;
					goto case 159;
				case 159:
					array[21] = (byte)num5;
					num2 = 65;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 292:
					array[10] = 187;
					goto case 347;
				case 289:
					array2[2] = 160;
					goto case 204;
				case 204:
					array2[2] = 42;
					num2 = 402;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 35;
				case 35:
					array4[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
					num2 = 89;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 288:
					array[11] = (byte)num5;
					num = 238;
					goto case 238;
				case 238:
					num5 = 90;
					goto case 10;
				case 10:
					array[11] = (byte)num5;
					goto case 283;
				case 283:
					array[11] = 120;
					num2 = 234;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 284:
					array[5] = (byte)num5;
					num = 126;
					goto case 126;
				case 126:
					array[5] = 167;
					goto case 345;
				case 281:
					array[15] = (byte)num5;
					goto case 23;
				case 23:
					num5 = 91;
					goto case 113;
				case 113:
					array[15] = (byte)num5;
					goto case 193;
				case 193:
					num5 = 215;
					goto case 349;
				case 280:
					num5 = 154;
					goto case 201;
				case 201:
					array[7] = (byte)num5;
					num2 = 222;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 278:
					num5 = 131;
					goto case 120;
				case 120:
					array[18] = (byte)num5;
					goto case 150;
				case 150:
					array[18] = 122;
					num2 = 174;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 277:
					array2[6] = (byte)num8;
					goto case 54;
				case 54:
					num8 = 157;
					num = 91;
					goto case 91;
				case 91:
					array2[6] = (byte)num8;
					goto case 327;
				case 276:
					array[10] = 55;
					goto case 352;
				case 275:
					num5 = 98;
					goto case 414;
				case 270:
					array[0] = (byte)num5;
					goto case 259;
				case 259:
					num5 = 114;
					goto case 389;
				case 268:
					array6[9] = array3[4];
					goto case 228;
				case 228:
					array6[11] = array3[5];
					goto case 87;
				case 87:
					array6[13] = array3[6];
					goto case 143;
				case 143:
					array6[15] = array3[7];
					num2 = 169;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 267:
					array[25] = (byte)num5;
					goto case 134;
				case 134:
					array[25] = 79;
					num2 = 397;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 266:
					num8 = 190;
					num2 = 331;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 265:
					array[25] = 90;
					goto case 233;
				case 233:
					array[25] = 108;
					num2 = 393;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 169:
				case 264:
					num21 = 0;
					goto case 262;
				case 261:
					num5 = 169;
					goto case 270;
				case 260:
					array[23] = 26;
					goto case 335;
				case 255:
					num8 = 158;
					num2 = 50;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 49;
				case 49:
					array2[3] = (byte)num8;
					goto case 24;
				case 24:
					num8 = 136;
					goto case 358;
				case 253:
					num20 <<= 8;
					goto case 410;
				case 252:
					array2[7] = (byte)num8;
					goto case 255;
				case 250:
					num5 = 178;
					goto case 227;
				case 227:
					array[31] = (byte)num5;
					num = 124;
					goto case 124;
				case 124:
					array7 = array;
					goto case 115;
				case 115:
					array2 = new byte[16];
					num2 = 189;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 249:
					num5 = 134;
					goto case 272;
				case 244:
					num8 = 232;
					num2 = 296;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 243:
					num5 = 130;
					goto case 297;
				case 242:
					array[9] = (byte)num5;
					num = 6;
					goto case 6;
				case 6:
					array[9] = 4;
					goto case 292;
				case 234:
					array[11] = 121;
					goto case 390;
				case 232:
					num11 = 0u;
					num2 = 89;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 92;
				case 92:
					if (num19 <= 0)
					{
						goto case 396;
					}
					goto case 342;
				case 231:
					array[30] = 163;
					goto case 196;
				case 196:
					num5 = 171;
					goto case 2;
				case 2:
					array[30] = (byte)num5;
					num2 = 378;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 190;
				case 190:
					array[1] = 105;
					goto case 141;
				case 141:
					array[1] = 179;
					num = 377;
					goto case 377;
				case 229:
					num5 = 74;
					num = 242;
					goto case 242;
				case 225:
					array[5] = (byte)num5;
					goto case 58;
				case 58:
					num5 = 164;
					goto case 80;
				case 80:
					array[6] = (byte)num5;
					goto case 307;
				case 224:
					if (num19 > 0)
					{
						num2 = 130;
						if (G8BecZLbcd92c40CuR() == null)
						{
							continue;
						}
						goto case 105;
					}
					goto case 18;
				case 18:
					num10 = num9 ^ num11;
					num2 = 368;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 223:
					array2[14] = 126;
					goto case 173;
				case 173:
					array2[15] = 162;
					num2 = 142;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 222:
					array[7] = 31;
					num2 = 318;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 219:
					array[10] = 86;
					goto case 276;
				case 217:
					array[23] = 84;
					num2 = 203;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 216:
					array[26] = (byte)num5;
					goto case 323;
				case 213:
					array[21] = (byte)num5;
					goto case 27;
				case 27:
					array[21] = 158;
					goto case 208;
				case 208:
					array[22] = 43;
					goto case 107;
				case 107:
					array[22] = 81;
					goto case 63;
				case 63:
					array[22] = 158;
					goto case 217;
				case 212:
					num8 = 234;
					num = 49;
					goto case 49;
				case 211:
					num8 = 120;
					num2 = 136;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 210:
					array[16] = 154;
					goto case 308;
				case 206:
					num18 = 0u;
					goto case 232;
				case 205:
					array[17] = 104;
					goto case 278;
				case 198:
					num8 = 192;
					num2 = 252;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 191:
					array2[2] = (byte)num8;
					num2 = 289;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 192;
				case 189:
					num8 = 94;
					num2 = 370;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 187:
					array[1] = (byte)num5;
					goto case 95;
				case 95:
					array[2] = 188;
					num2 = 243;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 186:
					array[27] = 86;
					goto case 406;
				case 183:
					num8 = 114;
					num = 328;
					goto case 328;
				case 180:
					array2[7] = (byte)num8;
					num2 = 198;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 178:
					array[31] = (byte)num5;
					num = 314;
					goto case 314;
				case 175:
					array[24] = 165;
					goto case 265;
				case 174:
					array[18] = 118;
					goto case 101;
				case 101:
					array[18] = 115;
					goto case 337;
				case 172:
					array[19] = (byte)num5;
					num2 = 4;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 362;
				case 171:
					num5 = 140;
					goto case 284;
				case 170:
					num14 = 0;
					num2 = 413;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 273;
				case 166:
					num17 = 0;
					goto case 19;
				case 165:
					array[30] = 118;
					goto case 231;
				case 164:
					array[4] = 172;
					goto case 171;
				case 158:
					num5 = 123;
					num2 = 152;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 310;
				case 154:
					array[27] = 79;
					goto case 186;
				case 145:
					array[1] = (byte)num5;
					num2 = 20;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 30;
				case 30:
					array[1] = 148;
					num2 = 190;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 144:
					array[30] = (byte)num5;
					goto case 60;
				case 60:
					num5 = 156;
					goto case 75;
				case 75:
					array[31] = (byte)num5;
					num2 = 249;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 98;
				case 98:
					num5 = 220;
					num2 = 25;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 94;
				case 94:
					array[29] = (byte)num5;
					goto case 165;
				case 142:
					array2[15] = 93;
					num2 = 62;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 139:
					array2[6] = (byte)num8;
					num2 = 351;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 360;
				case 136:
					array2[1] = (byte)num8;
					goto case 109;
				case 109:
					num8 = 248;
					goto case 369;
				case 132:
					array[14] = (byte)num5;
					goto case 275;
				case 130:
					num16 = num9 ^ num11;
					goto case 166;
				case 129:
					array[0] = 110;
					goto case 261;
				case 123:
					num9 = num13;
					goto case 112;
				case 112:
					if (num14 == num15 - 1)
					{
						goto case 224;
					}
					goto case 18;
				case 119:
					num12++;
					goto case 138;
				case 117:
					if (array3 == null)
					{
						num2 = 264;
						if (G8BecZLbcd92c40CuR() == null)
						{
							continue;
						}
						goto IL_0055;
					}
					goto case 73;
				case 73:
					if (array3.Length <= 0)
					{
						goto case 169;
					}
					num = 3;
					goto case 3;
				case 3:
					array6[1] = array3[0];
					goto case 56;
				case 56:
					array6[3] = array3[1];
					goto case 295;
				case 108:
					array2[6] = (byte)num8;
					goto case 12;
				case 12:
					num8 = 136;
					goto case 139;
				case 103:
					array5 = (byte[])sSlSge15fEoGhMvt62(object_, (int)gp0RFFxyLpTDLyofjL(gZXhgH25T85f2SiTrO(object_)));
					goto case 391;
				case 97:
					array[2] = 227;
					num2 = 348;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 90:
					array4[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
					goto case 226;
				case 89:
					array4[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
					num2 = 63;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 90;
				case 88:
					array[23] = (byte)num5;
					goto case 260;
				case 86:
					array3 = (byte[])ATd4jF59tPaoUjP7GU(S243RHtEoWHgD8Rvbl(x4Dk2IHVmX));
					goto case 117;
				case 84:
					num9 = 0u;
					num2 = 158;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 364;
				case 81:
					array[4] = (byte)num5;
					num2 = 72;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 78:
					array2[1] = (byte)num8;
					goto case 211;
				case 72:
					array[4] = 9;
					num2 = 164;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 68:
					num5 = 98;
					num2 = 217;
					if (G8BecZLbcd92c40CuR() != null)
					{
						continue;
					}
					goto case 333;
				case 67:
					num5 = 142;
					goto case 145;
				case 65:
					num5 = 104;
					num2 = 213;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 64:
					array[3] = 75;
					goto case 51;
				case 51:
					num5 = 120;
					num2 = 81;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 59:
					array[16] = (byte)num5;
					num2 = 210;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 131;
				case 50:
					array2[8] = (byte)num8;
					num2 = 126;
					if (!dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto case 380;
				case 48:
					num5 = 148;
					num2 = 288;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 46:
					j4sBIGkRLQD3CxXBbJ(object_2);
					goto case 319;
				case 33:
					array[10] = (byte)num5;
					num2 = 219;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto case 208;
				case 29:
					array[3] = (byte)num5;
					num = 64;
					goto case 64;
				case 28:
					array[28] = (byte)num5;
					num2 = 383;
					if (dfgfXZWBpNPNxBJrEf())
					{
						continue;
					}
					goto IL_0055;
				case 26:
					num7 = (uint)num6;
					goto case 339;
				case 22:
					num5 = 132;
					num2 = 0;
					if (G8BecZLbcd92c40CuR() == null)
					{
						continue;
					}
					goto IL_0055;
				case 20:
					array[1] = 125;
					goto case 67;
				case 14:
					num5 = 169;
					num = 88;
					goto case 88;
				case 5:
					num5 = 94;
					goto case 382;
				case 1:
					num5 = 70;
					num = 172;
					goto case 172;
				case 16:
					break;
				case 400:
					goto IL_2677;
				case 306:
					goto IL_26a4;
				case 387:
					try
					{
						K37bpuPtPZ5690YfQ2();
						int num3 = 1;
						if (G8BecZLbcd92c40CuR() != null)
						{
							goto IL_26e7;
						}
						goto IL_26eb;
						IL_26eb:
						do
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								return result;
							}
							result = (string)NtsyK0E9qciuEKTbEj(dXxLnUcd9pM8HvlYot(), HkLkNdDPtB, int_0 + 4, int_);
							num3 = 0;
						}
						while (G8BecZLbcd92c40CuR() == null);
						goto IL_26e7;
						IL_26e7:
						num3 = num4;
						goto IL_26eb;
					}
					catch
					{
						if (G8BecZLbcd92c40CuR() == null)
						{
							switch (0)
							{
							}
						}
					}
					goto case 341;
				case 341:
					return "";
				}
				break;
			}
			goto IL_264d;
		}
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
		return (Delegate)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(16777298)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(16777254)),
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(16777271))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal unsafe static void prXoP4RuYp()
	{
		//The blocks IL_1db1, IL_1df1, IL_1e0e, IL_1e12 are reachable both inside and outside the pinned region starting at IL_1dff. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0009, IL_0013, IL_0019, IL_002f, IL_0b2d, IL_0b3c, IL_0b5b, IL_0b64, IL_0b70, IL_0b76, IL_0b7f, IL_0b83, IL_0b9d, IL_0ba4, IL_0baa, IL_0bc0, IL_0c00, IL_0c1c, IL_0c22, IL_0c30, IL_0c3f, IL_0c62, IL_0c6e, IL_0c7c, IL_0c87, IL_0c9b, IL_0ca6, IL_0cc1, IL_0ccc, IL_0ce0, IL_0ceb, IL_0cf9, IL_0d14, IL_0d2a, IL_0d48, IL_0d54, IL_0d63, IL_0d86, IL_0d96, IL_0d9d, IL_0da4, IL_0db2, IL_0dd0, IL_0dd6, IL_0de4, IL_0df9, IL_0e05, IL_0e1e, IL_0e2c, IL_0e4d, IL_0e70, IL_0e94, IL_0e97, IL_0ea1, IL_0ec2, IL_0ee1, IL_0eee, IL_0ef1, IL_0ef6, IL_0f0f, IL_0f29, IL_0f37, IL_0f45, IL_0f4d, IL_0f62, IL_0f65, IL_0f77, IL_0f97, IL_0f9e, IL_115e, IL_128a, IL_12a5, IL_12c0, IL_12e4, IL_1307, IL_13f0, IL_1405, IL_1423, IL_1447, IL_1466, IL_1472, IL_1479, IL_1495, IL_14bc, IL_14d5, IL_14e3, IL_1507, IL_1522, IL_1546, IL_1561, IL_1580, IL_159c, IL_15ba, IL_15dd, IL_15f2, IL_1620, IL_1626, IL_162c, IL_1651, IL_166c, IL_1677, IL_1692, IL_16a6, IL_16c4, IL_16d2, IL_16dd, IL_16e8, IL_16ec, IL_16f5, IL_1715, IL_1730, IL_1739, IL_1747, IL_174d, IL_175b, IL_177c, IL_178a, IL_1790, IL_179e, IL_17b3, IL_17cc, IL_17da, IL_17f3, IL_1816, IL_1825, IL_182e, IL_183c, IL_1848, IL_1866, IL_1876, IL_1884, IL_18b2, IL_18ca, IL_18d9, IL_18e5, IL_18fb, IL_191e, IL_1926, IL_192f, IL_1942, IL_1963, IL_198e, IL_19b0, IL_19bf, IL_19e7, IL_1a00, IL_1a23, IL_1a46, IL_1a61, IL_1a67, IL_1a6d, IL_1a72, IL_1a88, IL_1a8e, IL_1a96, IL_1aab, IL_1ab0, IL_1ab7, IL_1acf, IL_1ad6, IL_1af4, IL_1b11, IL_1e88, IL_1ea7, IL_1eb5, IL_1ed1, IL_1ef7, IL_1f18, IL_1f21, IL_1f2c, IL_1f49, IL_1f58, IL_1f64, IL_1f7d, IL_1f83, IL_1f96, IL_1fb1, IL_1fbf, IL_1fcb, IL_1fd1, IL_1fef, IL_2006, IL_200f, IL_2032, IL_2050, IL_2066, IL_2072, IL_2090, IL_2097, IL_209a, IL_20a0, IL_20c8, IL_20d8, IL_20ef, IL_2103, IL_2111, IL_212d, IL_2139, IL_2148, IL_2157, IL_2170, IL_2187, IL_2193, IL_21a2, IL_21bd, IL_21d9, IL_21e2, IL_21f5, IL_21f8, IL_2204, IL_2215, IL_222a, IL_2231, IL_223a, IL_2258, IL_225c, IL_22d4, IL_22df, IL_22f4, IL_2315, IL_231e, IL_233c, IL_2357, IL_237b, IL_238e, IL_2391, IL_2399, IL_23af, IL_23cd, IL_23f4, IL_23fc, IL_241d, IL_2423, IL_242e, IL_2436, IL_2451, IL_2475, IL_247a, IL_2481, IL_2484, IL_249c, IL_24a9, IL_24b0, IL_24f0, IL_2513, IL_2532, IL_253d, IL_2554, IL_2572, IL_2581, IL_25a4, IL_25aa, IL_25c1, IL_25ca, IL_25d8, IL_25e7, IL_25f3, IL_2614, IL_261d, IL_262b, IL_2640, IL_264f, IL_2673, IL_269c, IL_26a5, IL_26ae, IL_26c3, IL_26c6, IL_26d1, IL_26e1, IL_26e5, IL_26f6, IL_26fe, IL_2709, IL_2711, IL_2714, IL_271c, IL_273b, IL_2755, IL_2769, IL_2787, IL_278f, IL_27ad, IL_27cb, IL_27d7, IL_27e0, IL_27fe, IL_280d, IL_282e, IL_283d, IL_2854, IL_2872, IL_2887, IL_289a, IL_28a6, IL_28b6, IL_28ce, IL_28d4, IL_28e2, IL_28fe, IL_290a, IL_2928, IL_2936, IL_2952, IL_2960, IL_296c, IL_297b, IL_2984, IL_2992, IL_299e, IL_29b4, IL_29bd, IL_29ce, IL_29e9, IL_29f7, IL_2a18, IL_2a2d, IL_2a53, IL_2a76, IL_2a94, IL_2a9d, IL_2ac0, IL_2ac6, IL_2ad4, IL_2ae3, IL_2afa, IL_2b00, IL_2b20, IL_2b41, IL_2b57, IL_2b6c, IL_2b8b, IL_2ba5, IL_2bae, IL_2bd1, IL_2bdf, IL_2be8, IL_2bfb, IL_2c0a, IL_2c23, IL_2c31, IL_2c4f, IL_2c58, IL_2c67, IL_2c82, IL_2c9e, IL_2cbc, IL_2ccd, IL_2cd4, IL_2cde, IL_2ce6, IL_2cee, IL_2cf6, IL_2d13, IL_2d2b, IL_2d47, IL_2d62, IL_2d6e, IL_2d92, IL_2db2, IL_2dc0, IL_2de3, IL_2e0a, IL_2e13, IL_2e31, IL_2e3a, IL_2e48, IL_2e57, IL_2e65, IL_2e88, IL_2e9e, IL_2ec1, IL_2ecc, IL_2ef3, IL_2efa, IL_2f14, IL_2f2f, IL_2f43, IL_2f4e, IL_2f57, IL_2f66, IL_2f89, IL_2fa4, IL_2fbc, IL_2fc5, IL_2fd0, IL_2fd8, IL_2fed, IL_2ffb, IL_3012, IL_301e, IL_302f, IL_3045, IL_3058, IL_3066, IL_3084, IL_308c, IL_3099, IL_30a5, IL_30ac, IL_30b8, IL_30db, IL_30e9, IL_3102, IL_3125, IL_3149, IL_3169, IL_3187, IL_318d, IL_31a4, IL_31c8, IL_31d9, IL_31e4, IL_3204, IL_321f, IL_3231, IL_323f, IL_3263, IL_327d, IL_3286, IL_329b, IL_32b0, IL_32d1, IL_32f4, IL_330d, IL_3319, IL_3334, IL_3347, IL_3353, IL_3359, IL_3370, IL_3376, IL_3399, IL_33b6, IL_33bc, IL_33ef, IL_3402, IL_340b, IL_3437, IL_345b, IL_345e, IL_3482, IL_348e, IL_34a7, IL_34af, IL_34cc, IL_34d8, IL_34e0, IL_34f5, IL_3513, IL_3531, IL_36d4, IL_36d8, IL_36e1, IL_36ec, IL_370c, IL_3721, IL_3730, IL_374b, IL_376c, IL_377a, IL_3780, IL_379c, IL_37c0, IL_37d4, IL_37dd, IL_37f0, IL_37fe, IL_381a, IL_3825, IL_3846, IL_384c, IL_386f, IL_388a, IL_38a5, IL_38c0, IL_38cc, IL_38d2, IL_38f5, IL_3904, IL_3913, IL_3919, IL_391f, IL_392a, IL_3938, IL_3947, IL_3958, IL_3981, IL_3990, IL_39a9, IL_39bf, IL_39ca, IL_39dd, IL_39f1, IL_3a00, IL_3a1c, IL_3a30, IL_3a4b, IL_3a56, IL_3a6e, IL_3a79, IL_3a9d, IL_3abe, IL_3adf, IL_3aeb, IL_3b01, IL_3b11, IL_3b32, IL_3b4e, IL_3b78, IL_3b84, IL_3b8a, IL_3b98, IL_3bb1, IL_3bc4, IL_3bd4, IL_3be7, IL_3bfc, IL_3c02, IL_3c25, IL_3c39, IL_3c44, IL_3c64, IL_3c72, IL_3c8d, IL_3c9b, IL_3ca1, IL_3cbf, IL_3cd6, IL_3cdf, IL_3cf2, IL_3d0e, IL_3d1a, IL_3d29, IL_3d43, IL_3d67, IL_3d75, IL_3d89, IL_3dac, IL_3dc3, IL_3dde, IL_3df7, IL_3e15, IL_3e31, IL_3e51, IL_3e6f, IL_3e92, IL_3ead, IL_3ebb, IL_3ed9, IL_3ee5, IL_3efa, IL_3f1e, IL_3f41, IL_3f4c, IL_3f57, IL_3f6e, IL_3f84, IL_3f8f, IL_3fa2, IL_3fc6, IL_3fdd, IL_3fe3, IL_3ff6, IL_4000, IL_4015, IL_4038, IL_4046, IL_404e, IL_4061, IL_407e, IL_4092, IL_40b5, IL_40c0, IL_40e1, IL_410a, IL_412a, IL_4138, IL_4152, IL_4162, IL_4170, IL_417f, IL_41a2, IL_41c5, IL_41dd, IL_41ec, IL_4206, IL_4222, IL_4240, IL_4253, IL_4276, IL_4287, IL_4298, IL_42a6, IL_42ca, IL_42e8, IL_4304, IL_4328, IL_4338, IL_4359, IL_4377, IL_4393, IL_439e, IL_43b5, IL_43c2, IL_43d8, IL_43eb, IL_43fb, IL_441e, IL_443c, IL_4447, IL_4455, IL_4463, IL_4481, IL_449f, IL_44a5, IL_44b0, IL_44c4, IL_44d3, IL_44f6, IL_4527, IL_453e, IL_4546, IL_4561, IL_457c, IL_4588, IL_459c, IL_45a7, IL_45bd, IL_45d0, IL_45e3, IL_45ee, IL_4603, IL_4614, IL_4634, IL_4642, IL_464b, IL_4669, IL_4677, IL_4688, IL_4699, IL_46a7, IL_46bb, IL_46d8, IL_46e6, IL_46f4, IL_4702, IL_4715, IL_4730, IL_4734, IL_4742, IL_475e, IL_4767, IL_477a, IL_478b, IL_479b, IL_47a9, IL_47b4, IL_47c3, IL_47e7, IL_47f2, IL_4805, IL_4820, IL_483c, IL_484f, IL_4872, IL_4885, IL_48a6, IL_48b9, IL_48d7, IL_48f5, IL_4913, IL_492f, IL_4942, IL_4963, IL_497e, IL_498e, IL_4996, IL_49b5, IL_49ca, IL_49d5, IL_49e8, IL_4a06, IL_4a17, IL_4a1f, IL_4a3a, IL_4a42, IL_4a49 are reachable both inside and outside the pinned region starting at IL_33d4. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 105;
		byte[] array4 = default(byte[]);
		int num22 = default(int);
		int num23 = default(int);
		byte[] array14 = default(byte[]);
		byte[] array13 = default(byte[]);
		int num30 = default(int);
		int num36 = default(int);
		int num35 = default(int);
		int num18 = default(int);
		uint num42 = default(uint);
		uint num39 = default(uint);
		byte[] array17 = default(byte[]);
		int num4 = default(int);
		byte[] array7 = default(byte[]);
		int num15 = default(int);
		byte[] array5 = default(byte[]);
		IntPtr intPtr3 = default(IntPtr);
		int num5 = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		IntPtr intptr_ = default(IntPtr);
		byte[] array2 = default(byte[]);
		IntPtr intptr_4 = default(IntPtr);
		int num33 = default(int);
		int num28 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array11 = default(byte[]);
		long num7 = default(long);
		Process object_12 = default(Process);
		IEnumerator enumerator = default(IEnumerator);
		IntPtr intPtr4 = default(IntPtr);
		ProcessModule object_14 = default(ProcessModule);
		int num65 = default(int);
		int num68 = default(int);
		int num71 = default(int);
		ProcessModule object_16 = default(ProcessModule);
		int num73 = default(int);
		long value = default(long);
		int num6 = default(int);
		int num58 = default(int);
		int num60 = default(int);
		int num16 = default(int);
		VtNVUKGulysZw81C3E object_2 = default(VtNVUKGulysZw81C3E);
		byte[] array9 = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream object_8 = default(CryptoStream);
		uint num19 = default(uint);
		uint num40 = default(uint);
		int num54 = default(int);
		int num21 = default(int);
		int int_2 = default(int);
		int num9 = default(int);
		IntPtr intPtr = default(IntPtr);
		ProcessModuleCollection object_ = default(ProcessModuleCollection);
		long num8 = default(long);
		IntPtr intptr_5 = default(IntPtr);
		int num53 = default(int);
		int num37 = default(int);
		uint num52 = default(uint);
		uint num17 = default(uint);
		int num11 = default(int);
		uint num38 = default(uint);
		MemoryStream object_10 = default(MemoryStream);
		int num49 = default(int);
		uint nativeSizeOfCode = default(uint);
		byte[] array20 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num47 = default(int);
		int num51 = default(int);
		int num10 = default(int);
		int int_3 = default(int);
		byte[] jsbkrdexts = default(byte[]);
		BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
		IntPtr intptr_3 = default(IntPtr);
		long num12 = default(long);
		int num34 = default(int);
		int num32 = default(int);
		IntPtr intptr_2 = default(IntPtr);
		AwgKvrHJUS3TxryUsj uint_ = default(AwgKvrHJUS3TxryUsj);
		int num41 = default(int);
		byte[] array19 = default(byte[]);
		byte[] array10 = default(byte[]);
		byte[] array18 = default(byte[]);
		int num20 = default(int);
		byte[] array12 = default(byte[]);
		bool flag = default(bool);
		IntPtr procAddress = default(IntPtr);
		string string_ = default(string);
		OFfwWh6ZIHjfnqBOWx object_9 = default(OFfwWh6ZIHjfnqBOWx);
		int num29 = default(int);
		bool jDNkifbo3S = default(bool);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		ref byte reference3 = default(ref byte);
		byte[] array8 = default(byte[]);
		int num14 = default(int);
		int num13 = default(int);
		Version object_7 = default(Version);
		Version object_6 = default(Version);
		int num25 = default(int);
		int num27 = default(int);
		int int_ = default(int);
		BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
		IntPtr intPtr2 = default(IntPtr);
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
					int num3 = 102;
					if (PsfwYibARbKayXDITm() == null)
					{
						goto IL_002f;
					}
					goto IL_0b5b;
					IL_0b5b:
					num3 = num;
					goto IL_002f;
					IL_002f:
					while (true)
					{
						byte[] array22;
						int num61;
						int num62;
						long num63;
						long num64;
						int num66;
						int num67;
						int num69;
						int num70;
						int num72;
						int num74;
						int num55;
						int num56;
						int num57;
						int num59;
						int num45;
						byte[] array21;
						ref byte reference2;
						int num46;
						int num48;
						int num50;
						uint num43;
						IntPtr intptr_6;
						nint num31;
						int num24;
						int num26;
						byte[] array16;
						byte[] array15;
						ref BIpvxRBRb2dOGl802m reference;
						switch (num3)
						{
						case 105:
							break;
						case 104:
							goto IL_0013;
						case 447:
							goto IL_0019;
						case 700:
							array4[28] = 218;
							goto case 491;
						case 491:
							array4[29] = 169;
							num3 = 417;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 699:
							num22 = 0;
							num = 300;
							goto case 86;
						case 86:
						case 300:
							if (num22 >= num23)
							{
								num = 485;
								goto case 485;
							}
							goto case 550;
						case 485:
							array14 = array13;
							goto case 561;
						case 561:
							num30 = array14.Length / 8;
							num3 = 355;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 550:
							num36 = num22 % num35;
							goto case 90;
						case 90:
							num18 = num22 * 4;
							goto case 230;
						case 230:
							num42 = (uint)(num36 * 4);
							num3 = 353;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 624;
						case 624:
							num39 = (uint)((array17[num42 + 3] << 24) | (array17[num42 + 2] << 16) | (array17[num42 + 1] << 8) | array17[num42]);
							num3 = 272;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 698:
							array4[16] = 96;
							num3 = 146;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 135;
						case 135:
							num4 = 99;
							goto case 384;
						case 384:
							array4[9] = (byte)num4;
							goto case 327;
						case 327:
							num4 = 112;
							num = 558;
							goto case 558;
						case 558:
							array4[9] = (byte)num4;
							num3 = 130;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 697:
							array4[15] = 101;
							goto case 342;
						case 342:
							array4[15] = 71;
							goto case 698;
						case 696:
							array7[num15 + 1] = array5[1];
							goto case 422;
						case 422:
							array7[num15 + 2] = array5[2];
							num = 283;
							goto case 283;
						case 283:
							array7[num15 + 3] = array5[3];
							goto case 343;
						case 343:
							array7[num15 + 4] = array5[4];
							num3 = 92;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 316;
						case 316:
							array7[num15 + 5] = array5[5];
							goto case 360;
						case 360:
							array7[num15 + 6] = array5[6];
							num = 245;
							goto case 245;
						case 245:
							array7[num15 + 7] = array5[7];
							goto case 97;
						case 97:
						case 193:
							PRvHE6k6bN6cQqTYut(array7, 0, intPtr3, array7.Length);
							goto case 57;
						case 57:
							xo4kuDarJK = false;
							num3 = 190;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 695:
							num5 = 49;
							num3 = 55;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 39;
						case 39:
							array4[27] = (byte)num4;
							num3 = 92;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 265;
						case 265:
							array4[27] = 121;
							goto case 659;
						case 659:
							num4 = 93;
							num = 582;
							goto case 582;
						case 582:
							array4[27] = (byte)num4;
							num3 = 451;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 694:
							array[9] = 100;
							num = 365;
							goto case 365;
						case 365:
							array[10] = 108;
							goto case 195;
						case 195:
							array[11] = 108;
							goto case 413;
						case 413:
							text = (string)Td1ATdvqFhFtIHvr48J(JLXqf5vRx2aaqd89sBE(), array);
							goto case 64;
						case 64:
							intptr_ = LoadLibrary(text);
							num3 = 259;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 693:
							num5 = 81;
							goto case 164;
						case 164:
							array2[12] = (byte)num5;
							goto case 46;
						case 46:
							array2[13] = 88;
							num = 220;
							goto case 220;
						case 220:
							array2[13] = 68;
							goto case 118;
						case 118:
							num5 = 176;
							num3 = 36;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 84;
						case 84:
							array2[13] = (byte)num5;
							goto case 594;
						case 594:
							array2[13] = 60;
							num3 = 338;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 692:
							array4[10] = (byte)num4;
							num3 = 369;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 691:
							intptr_4 = new IntPtr(URnkCOceLK + num33 - num28);
							num3 = 385;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 213;
						case 213:
							array8 = null;
							goto case 610;
						case 610:
							if (T8HYV799DYUL4uCJUx() != 4)
							{
								goto case 645;
							}
							goto case 168;
						case 645:
							array8 = (byte[])uhrG7DvcRwZPmrZdGRP(VE2k4S5okQ.ToInt64());
							num3 = 92;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 87;
						case 87:
							array22 = new byte[30];
							h7hAE7vCXPBh5lF0GOV(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array3 = array22;
							num = 63;
							goto case 63;
						case 498:
							array7 = array3;
							num = 553;
							goto case 553;
						case 553:
							array5 = null;
							goto case 546;
						case 546:
							array11 = null;
							goto case 213;
						case 63:
						case 395:
							intPtr3 = E11Blivl1C9EaDqc0ae(IntPtr.Zero, (uint)array3.Length, 4096u, 64u);
							goto case 498;
						case 168:
							array8 = (byte[])iEk9VAQa23t2IMOZLf(VE2k4S5okQ.ToInt32());
							num = 224;
							goto case 224;
						case 224:
							array5 = (byte[])iEk9VAQa23t2IMOZLf(intPtr2.ToInt32());
							goto case 323;
						case 323:
							array11 = (byte[])iEk9VAQa23t2IMOZLf(HPrO0MvTd8MUVO2iftT(num7));
							goto case 309;
						case 309:
						case 403:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								num3 = 127;
								if (PsfwYibARbKayXDITm() == null)
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 449;
						case 449:
							num15 = 2;
							goto case 345;
						case 345:
							array7[num15] = array8[0];
							num = 508;
							goto case 508;
						case 508:
							array7[num15 + 1] = array8[1];
							num3 = 331;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 50:
						case 690:
							object_12 = (Process)RlEepR6Ul0aEhb1wdK();
							goto case 22;
						case 22:
							try
							{
								ProcessModuleCollection object_13 = (ProcessModuleCollection)aN79LMiWBPpE4sELsP(object_12);
								while (true)
								{
									enumerator = (IEnumerator)tLhWr2gLT94ta57ay6(object_13);
									num61 = 1;
									if (PsfwYibARbKayXDITm() != null)
									{
										switch (num61)
										{
										case 2:
											continue;
										default:
											goto end_IL_0fa8;
										case 1:
											break;
										case 0:
											goto end_IL_0fa8;
										}
									}
									try
									{
										while (true)
										{
											IL_10d4:
											if (!l5DauXK3JZLhJMEyVn(enumerator))
											{
												num62 = 7;
												if (PsfwYibARbKayXDITm() == null)
												{
													goto IL_1031;
												}
												goto IL_105a;
											}
											goto IL_10b2;
											IL_1031:
											while (true)
											{
												switch (num62)
												{
												case 5:
													break;
												case 4:
													goto end_IL_1031;
												default:
													goto IL_105a;
												case 8:
													goto IL_108a;
												case 6:
													goto IL_10a0;
												case 2:
													goto IL_10b2;
												case 3:
													goto IL_10d4;
												case 1:
													return;
												case 7:
													goto end_IL_10d4;
												}
												num63 = num7;
												intPtr4 = P9E3JeMbivWI7BNYgN(object_14);
												if (num63 <= intPtr4.ToInt64() + eSLb8pvGTBwtRbXYXPE(object_14))
												{
													goto IL_10d4;
												}
												num62 = 0;
												if (PsfwYibARbKayXDITm() == null)
												{
													continue;
												}
												goto IL_1017;
												continue;
												end_IL_1031:
												break;
											}
											goto IL_101d;
											IL_10b2:
											object_14 = (ProcessModule)SpecVgcCHhCjLNxNT2(enumerator);
											goto IL_10a0;
											IL_10a0:
											if (!AEnLDv18ZTuoKbb5wM(u8JRrRoicD0sGpHK09(object_14), text))
											{
												continue;
											}
											goto IL_108a;
											IL_108a:
											num64 = num7;
											intPtr4 = P9E3JeMbivWI7BNYgN(object_14);
											if (num64 >= intPtr4.ToInt64())
											{
												num62 = 5;
												if (PsfwYibARbKayXDITm() == null)
												{
													goto IL_1031;
												}
											}
											goto IL_105a;
											IL_101d:
											RKPutnyZ1ld0gp3H7Z();
											num62 = 1;
											if (!cnwib5vMRnDuwHuQHW())
											{
												goto IL_1017;
											}
											goto IL_1031;
											IL_105a:
											if (!fxUQ1dvxhoIVa5wbxGn(foiAigvMM7wCOoJ1Pc8(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
											{
												continue;
											}
											num62 = 3;
											if (cnwib5vMRnDuwHuQHW())
											{
												goto IL_101d;
											}
											goto IL_1031;
											IL_1017:
											num62 = num65;
											goto IL_1031;
											continue;
											end_IL_10d4:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator as IDisposable;
										num66 = 0;
										if (!cnwib5vMRnDuwHuQHW())
										{
											goto IL_1113;
										}
										goto IL_1126;
										IL_1126:
										switch (num66)
										{
										case 2:
											break;
										default:
											goto IL_1113;
										case 1:
										case 3:
											goto end_IL_10e6;
										}
										goto IL_10fe;
										IL_1113:
										if (disposable == null)
										{
											num66 = 3;
											if (PsfwYibARbKayXDITm() == null)
											{
												goto IL_1126;
											}
										}
										goto IL_10fe;
										IL_10fe:
										OcB3D1aSiX4yvSrrNs(disposable);
										num66 = 0;
										if (!cnwib5vMRnDuwHuQHW())
										{
											goto IL_1126;
										}
										end_IL_10e6:;
									}
									break;
									continue;
									end_IL_0fa8:
									break;
								}
							}
							catch (object obj5)
							{
								num67 = 0;
								if (PsfwYibARbKayXDITm() != null)
								{
									num67 = num68;
								}
								switch (num67)
								{
								}
							}
							goto case 8;
						case 8:
							try
							{
								ProcessModuleCollection object_15 = (ProcessModuleCollection)aN79LMiWBPpE4sELsP(object_12);
								num69 = 0;
								if (!cnwib5vMRnDuwHuQHW())
								{
									switch (num69)
									{
									case 2:
										goto IL_1190;
									case 1:
										goto end_IL_115e;
									}
								}
								enumerator = (IEnumerator)tLhWr2gLT94ta57ay6(object_15);
								goto IL_1190;
								IL_1190:
								try
								{
									while (true)
									{
										if (!l5DauXK3JZLhJMEyVn(enumerator))
										{
											num70 = 0;
											if (PsfwYibARbKayXDITm() == null)
											{
												break;
											}
											goto IL_11ba;
										}
										goto IL_11f5;
										IL_1194:
										num28 = 0;
										num70 = 2;
										if (!cnwib5vMRnDuwHuQHW())
										{
											num70 = num71;
										}
										goto IL_11ba;
										IL_11f5:
										object_16 = (ProcessModule)SpecVgcCHhCjLNxNT2(enumerator);
										goto IL_11dd;
										IL_11dd:
										intPtr4 = P9E3JeMbivWI7BNYgN(object_16);
										num70 = 1;
										if (cnwib5vMRnDuwHuQHW())
										{
											goto IL_11aa;
										}
										goto IL_11ba;
										IL_11ba:
										switch (num70)
										{
										case 3:
											break;
										case 1:
											goto IL_11aa;
										default:
											goto end_IL_1213;
										case 5:
											goto IL_11dd;
										case 4:
											goto IL_11f5;
										case 6:
											continue;
										case 0:
										case 2:
											goto end_IL_1213;
										}
										goto IL_1194;
										IL_11aa:
										if (intPtr4.ToInt64() != eXJkjmTXDX)
										{
											continue;
										}
										goto IL_1194;
										continue;
										end_IL_1213:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									num72 = 0;
									if (!cnwib5vMRnDuwHuQHW())
									{
										num72 = num73;
									}
									do
									{
										switch (num72)
										{
										case 2:
											break;
										default:
											if (disposable != null)
											{
												break;
											}
											goto end_IL_1258;
										case 1:
											goto end_IL_1258;
										}
										OcB3D1aSiX4yvSrrNs(disposable);
										num72 = 0;
										continue;
										end_IL_1258:
										break;
									}
									while (PsfwYibARbKayXDITm() != null);
								}
								end_IL_115e:;
							}
							catch (object obj6)
							{
								num74 = 0;
								if (!cnwib5vMRnDuwHuQHW())
								{
									switch (num74)
									{
									}
								}
							}
							goto case 409;
						case 409:
							abxkLGOVrU = null;
							num3 = 686;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 689:
							array[2] = 99;
							num3 = 536;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 688:
							num7 = ge0KN8vkOsWG9SgWvAT(new IntPtr(value));
							num3 = 50;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 687:
							array4[28] = (byte)num6;
							num3 = 699;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 700;
						case 686:
							try
							{
								abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)HTUe0wvNPAcvIaonZBp(new IntPtr(num7), eExcg9vJmltHggheFp3(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
								num55 = 0;
								if (cnwib5vMRnDuwHuQHW())
								{
									switch (num55)
									{
									}
								}
							}
							catch (object obj4)
							{
								num56 = 0;
								if (PsfwYibARbKayXDITm() != null)
								{
									switch (num56)
									{
									default:
										goto end_IL_1345;
									case 1:
										break;
									case 0:
										goto end_IL_1345;
									}
								}
								try
								{
									Delegate object_11 = (Delegate)HTUe0wvNPAcvIaonZBp(new IntPtr(num7), eExcg9vJmltHggheFp3(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
									num57 = 0;
									if (!cnwib5vMRnDuwHuQHW())
									{
										goto IL_13bc;
									}
									goto IL_13c0;
									IL_13c0:
									while (true)
									{
										switch (num57)
										{
										case 1:
											goto end_IL_13c0;
										}
										abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)GP0ZpVvyG9rn9ofeyf7(eExcg9vJmltHggheFp3(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle), Hy9Pmgvf4eXW2dJhKG1(object_11));
										num57 = 1;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										goto IL_13bc;
										continue;
										end_IL_13c0:
										break;
									}
									goto end_IL_1368;
									IL_13bc:
									num57 = num58;
									goto IL_13c0;
									end_IL_1368:;
								}
								catch (object obj3)
								{
									num59 = 0;
									if (!cnwib5vMRnDuwHuQHW())
									{
										num59 = num60;
									}
									switch (num59)
									{
									default:
										goto end_IL_13d1;
									}
									end_IL_13d1:;
								}
								end_IL_1345:;
							}
							goto case 177;
						case 177:
							num3 = 1;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 685:
							num16 = Iuo7Onpe8Wxmkcbqq1(object_2);
							num3 = 219;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 684:
							array4[15] = 154;
							num3 = 32;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 683:
							array4[13] = 157;
							num3 = 581;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 356;
						case 356:
							JAZe0xADYFLLoZwkVd(array9, 0, array9.Length);
							goto case 242;
						case 242:
							CCYWllDJfu0U4ZAtBI(memoryStream);
							goto case 78;
						case 78:
							CCYWllDJfu0U4ZAtBI(object_8);
							num3 = 627;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 682:
							array13[num18 + 1] = (byte)((num19 & 0xFF00) >> 8);
							num3 = 322;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 681:
							num6 = 134;
							num3 = 7;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 334;
						case 334:
							array4[1] = (byte)num6;
							goto case 652;
						case 652:
							array4[1] = 162;
							num3 = 109;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 680:
							num40 <<= 8;
							num3 = 363;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 679:
							array4[11] = 168;
							num3 = 617;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 678:
							array7[num15 + 5] = array8[5];
							num3 = 673;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 585;
						case 585:
							array4[25] = 156;
							num3 = 140;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 326;
						case 326:
							array4[25] = 94;
							num3 = 157;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 147;
						case 147:
							num6 = 158;
							num3 = 60;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 677:
							array4[21] = (byte)num4;
							num3 = 321;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 676:
							num54 = 0;
							num3 = 161;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 162;
						case 415:
							aQbsnKvu6jFlFVsqWqM(new IntPtr(intptr_4.ToInt64() + num54 * 4), Iuo7Onpe8Wxmkcbqq1(object_2));
							num3 = 135;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 296;
						case 296:
							num54++;
							goto case 162;
						case 162:
						case 280:
							if (num54 < num21)
							{
								goto case 415;
							}
							goto case 287;
						case 287:
							YeeoMqaS3J(intptr_4, num21 * 4, int_2, ref int_2);
							num3 = 389;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 675:
							array7[num9 + 1] = array8[1];
							num3 = 203;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 298;
						case 298:
							array7[num9 + 2] = array8[2];
							goto case 308;
						case 308:
							array7[num9 + 3] = array8[3];
							num3 = 42;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 132;
						case 132:
							num9 = 16;
							num3 = 8;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 112;
						case 112:
							array7[num9] = array11[0];
							num3 = 185;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 674:
							array7[num15] = array5[0];
							goto case 696;
						case 673:
							array7[num15 + 6] = array8[6];
							goto case 596;
						case 596:
							array7[num15 + 7] = array8[7];
							goto case 525;
						case 525:
							num15 = 18;
							goto case 25;
						case 25:
							array7[num15] = array11[0];
							goto case 35;
						case 35:
							array7[num15 + 1] = array11[1];
							num3 = 428;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 672:
							num6 = 50;
							num3 = 405;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 671:
							num4 = 191;
							goto case 30;
						case 30:
							array4[8] = (byte)num4;
							goto case 607;
						case 607:
							num4 = 81;
							goto case 20;
						case 20:
							array4[8] = (byte)num4;
							goto case 183;
						case 183:
							array4[9] = 77;
							num3 = 135;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 670:
							array4[6] = (byte)num6;
							goto case 435;
						case 435:
							num4 = 110;
							goto case 269;
						case 269:
							array4[6] = (byte)num4;
							goto case 125;
						case 125:
							array4[6] = 82;
							num = 377;
							goto case 377;
						case 377:
							num6 = 139;
							num3 = 170;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 232;
						case 232:
							array4[6] = (byte)num6;
							goto case 226;
						case 226:
							num4 = 211;
							num3 = 200;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 373;
						case 373:
							array4[6] = (byte)num4;
							num3 = 522;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 669:
							array4[30] = 142;
							goto case 207;
						case 207:
							num6 = 162;
							goto case 623;
						case 623:
							array4[30] = (byte)num6;
							goto case 513;
						case 513:
							array4[31] = 116;
							goto case 483;
						case 483:
							num4 = 132;
							num3 = 134;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 668:
							miJRONPWPUPfHF3idq(object_8);
							num = 222;
							goto case 222;
						case 222:
							array14 = (byte[])KBm26YS06UbN6kI08B(memoryStream);
							goto case 356;
						case 667:
							intPtr = new IntPtr(URnkCOceLK + Iuo7Onpe8Wxmkcbqq1(object_2) - num28);
							num3 = 73;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 666:
							array2[3] = 163;
							num = 208;
							goto case 208;
						case 208:
							array2[4] = 208;
							goto case 618;
						case 618:
							array2[4] = 22;
							goto case 534;
						case 534:
							num5 = 127;
							num3 = 52;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 152;
						case 152:
							array2[4] = (byte)num5;
							num3 = 335;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 665:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								num = 454;
								goto case 454;
							}
							goto case 16;
						case 454:
							if (jprDK4L5TKMDTrvTwV(hiIW3l0lJxxPIgBHXy("System.Reflection.ReflectionContext", bool_0: false), null))
							{
								goto case 517;
							}
							goto case 16;
						case 517:
							object_ = (ProcessModuleCollection)aN79LMiWBPpE4sELsP(RlEepR6Ul0aEhb1wdK());
							num3 = 24;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 16:
						case 656:
							object_2 = new VtNVUKGulysZw81C3E((Stream)dJC3oLVPNiFZJlbpnH(x4Dk2IHVmX, "9NW9oT68xVJCdNlkEg.aylDCiEMpMcRySTSil"));
							num3 = 598;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 231:
						case 664:
							YeeoMqaS3J(intPtr, 4, int_2, ref int_2);
							num3 = 381;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 177;
						case 663:
							gsK9XnRnQvtX7ikaZv(new IntPtr(&num8), 0);
							goto case 151;
						case 151:
							PDnPGLq8flejBjnsh8(new IntPtr(&num8), 0, IntPtr.Zero);
							num3 = 292;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 662:
							num5 = 166;
							num3 = 6;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 37;
						case 37:
							array2[3] = (byte)num5;
							num3 = 666;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 661:
							array4[1] = (byte)num6;
							num3 = 535;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 85:
						case 660:
							ymo9V3JfkrBEwjVuTN(intptr_5, 0);
							num3 = 450;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 9;
						case 406:
							num53++;
							goto case 260;
						case 260:
						case 352:
							if (num53 >= num37)
							{
								num3 = 545;
								if (cnwib5vMRnDuwHuQHW())
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 619;
						case 619:
							if (num53 <= 0)
							{
								goto case 632;
							}
							goto case 423;
						case 632:
							array13[num18 + num53] = (byte)((num52 & num17) >> num11);
							goto case 406;
						case 423:
							num17 <<= 8;
							goto case 9;
						case 9:
							num11 += 8;
							goto case 632;
						case 658:
							if (num37 > 0)
							{
								goto case 458;
							}
							goto case 181;
						case 458:
							num52 = num38 ^ num40;
							goto case 206;
						case 206:
							num53 = 0;
							num3 = 260;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 181:
							num19 = num38 ^ num40;
							goto case 42;
						case 42:
							array13[num18] = (byte)(num19 & 0xFFu);
							num3 = 682;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 317;
						case 317:
							array4[25] = (byte)num6;
							num = 585;
							goto case 585;
						case 638:
						case 657:
							try
							{
								object obj = C3AtdsvgmNIMmgVcrDX(Q177RmviuWhVERK2cMk(KkUYfQvLAQWEPaeEvUt(L8dTWnv0laKtHr0pv7A(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), KkUYfQvLAQWEPaeEvUt(L8dTWnv0laKtHr0pv7A(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)));
								num45 = 13;
								if (PsfwYibARbKayXDITm() != null)
								{
									goto IL_1c1f;
								}
								goto IL_1d51;
								IL_1d51:
								while (true)
								{
									switch (num45)
									{
									case 9:
									case 18:
										DunnU3tP2mNprIipAn(object_10, new byte[T8HYV799DYUL4uCJUx()], 0, T8HYV799DYUL4uCJUx());
										num45 = 11;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										goto end_IL_1d51;
									case 16:
										DunnU3tP2mNprIipAn(object_10, new byte[T8HYV799DYUL4uCJUx()], 0, T8HYV799DYUL4uCJUx());
										goto case 12;
									case 12:
										if (T8HYV799DYUL4uCJUx() == 4)
										{
											num49 = 3;
											goto case 3;
										}
										goto case 4;
									case 3:
										DunnU3tP2mNprIipAn(object_10, iEk9VAQa23t2IMOZLf(VE2k4S5okQ.ToInt32()), 0, 4);
										num45 = 9;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										break;
									case 4:
										DunnU3tP2mNprIipAn(object_10, uhrG7DvcRwZPmrZdGRP(VE2k4S5okQ.ToInt64()), 0, 8);
										num45 = 18;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										break;
									case 2:
									case 15:
										object_10 = new MemoryStream();
										num45 = 12;
										if (PsfwYibARbKayXDITm() != null)
										{
											continue;
										}
										goto case 16;
									case 14:
										VE2k4S5okQ = (IntPtr)obj;
										num45 = 6;
										if (PsfwYibARbKayXDITm() == null)
										{
											continue;
										}
										break;
									case 13:
										if (obj is IntPtr)
										{
											num45 = 14;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										}
										goto case 6;
									case 6:
										if (!AEnLDv18ZTuoKbb5wM(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
										{
											num49 = 15;
											goto case 2;
										}
										goto case 1;
									case 1:
										VE2k4S5okQ = (IntPtr)C3AtdsvgmNIMmgVcrDX(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
										num49 = 2;
										goto case 2;
									case 11:
										DunnU3tP2mNprIipAn(object_10, new byte[T8HYV799DYUL4uCJUx()], 0, T8HYV799DYUL4uCJUx());
										num45 = 0;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										break;
									case 10:
										CCYWllDJfu0U4ZAtBI(object_10);
										goto case 8;
									case 8:
										nativeSizeOfCode = 0u;
										num45 = 17;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										goto case 9;
									case 5:
										array20 = (byte[])KBm26YS06UbN6kI08B(object_10);
										num45 = 10;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										break;
									default:
										IbMqPdBO53HK0us9pI(object_10, 0L);
										num45 = 5;
										if (cnwib5vMRnDuwHuQHW())
										{
											continue;
										}
										goto case 5;
									case 17:
										try
										{
											array21 = (array6 = array20);
											if (array21 != null)
											{
												goto IL_1df1;
											}
											goto IL_1e35;
											IL_1e35:
											while (true)
											{
												IL_1e35_2:
												reference2 = ref *(byte*)null;
												num46 = 5;
												if (PsfwYibARbKayXDITm() != null)
												{
													num46 = num47;
												}
												while (true)
												{
													switch (num46)
													{
													case 1:
													case 5:
														rNZkehfwNu(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
														num46 = 1;
														if (!cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														goto end_IL_1da5;
													case 3:
														break;
													default:
														goto IL_1df7;
													case 4:
														goto IL_1e35_2;
													case 6:
														goto end_IL_1da5;
													}
													break;
												}
												break;
											}
											goto IL_1df1;
											IL_1df7:
											while (true)
											{
												fixed (byte* value2 = &array6[0])
												{
													num46 = 1;
													if (!cnwib5vMRnDuwHuQHW())
													{
														num46 = num47;
													}
													while (true)
													{
														switch (num46)
														{
														case 0:
														case 2:
															break;
														case 1:
														case 5:
															rNZkehfwNu(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
															num46 = 1;
															if (!cnwib5vMRnDuwHuQHW())
															{
																continue;
															}
															goto end_IL_1da5;
														case 3:
															if (array6.Length == 0)
															{
																goto end_IL_1df7;
															}
															break;
														case 4:
															goto end_IL_1df7;
														case 6:
															goto end_IL_1da5;
														}
														break;
													}
												}
												continue;
												end_IL_1df7:
												break;
											}
											goto IL_1e35;
											IL_1df1:
											if (array6.Length != 0)
											{
												goto IL_1df7;
											}
											goto IL_1e35;
											end_IL_1da5:;
										}
										finally
										{
											reference2 = ref *(byte*)null;
											num48 = 0;
											if (cnwib5vMRnDuwHuQHW())
											{
												switch (num48)
												{
												}
											}
										}
										goto end_IL_1d51;
									case 7:
										goto end_IL_1d51;
									}
									goto IL_1c1f;
									continue;
									end_IL_1d51:
									break;
								}
								goto end_IL_1b11;
								IL_1c1f:
								num45 = num49;
								goto IL_1d51;
								end_IL_1b11:;
							}
							catch (object obj2)
							{
								num50 = 0;
								if (PsfwYibARbKayXDITm() != null)
								{
									num50 = num51;
								}
								switch (num50)
								{
								}
							}
							goto case 211;
						case 211:
							CwIXyivo1EmpV0ysNqL(abxkLGOVrU);
							num3 = 396;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 655:
							array4[21] = (byte)num6;
							goto case 495;
						case 495:
							array4[22] = 124;
							num3 = 204;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 114;
						case 114:
							array17[num10] = (byte)(array17[num10] ^ array9[num10]);
							num3 = 198;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 654:
							array4[0] = 62;
							num3 = 267;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 653:
							int_3 = Iuo7Onpe8Wxmkcbqq1(object_2);
							goto case 277;
						case 277:
							jsbkrdexts = (byte[])W0tB3fmF9aixUx94Wn(object_2, int_3);
							goto case 62;
						case 62:
							bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
							num3 = 68;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 651:
							array4[23] = 151;
							goto case 386;
						case 386:
							array4[23] = 102;
							goto case 588;
						case 588:
							num4 = 240;
							num3 = 293;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 215;
						case 215:
							num4 = 95;
							goto case 225;
						case 225:
							array4[1] = (byte)num4;
							goto case 681;
						case 650:
							num5 = 99;
							num3 = 346;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 649:
							array4[14] = (byte)num4;
							goto case 397;
						case 397:
							array4[14] = 114;
							goto case 642;
						case 642:
							num6 = 69;
							goto case 637;
						case 637:
							array4[14] = (byte)num6;
							num3 = 684;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 515;
						case 515:
							array2[15] = (byte)num5;
							num = 83;
							goto case 83;
						case 83:
							num5 = 163;
							goto case 492;
						case 492:
							array2[15] = (byte)num5;
							num3 = 634;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 648:
							num4 = 156;
							num3 = 237;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 282:
							intptr_3 = new IntPtr(num12 + Iuo7Onpe8Wxmkcbqq1(object_2) - num28);
							goto case 156;
						case 156:
							YeeoMqaS3J(intptr_3, 4, 4, ref int_2);
							goto case 367;
						case 367:
							aQbsnKvu6jFlFVsqWqM(intptr_3, Iuo7Onpe8Wxmkcbqq1(object_2));
							num3 = 484;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 219;
						case 219:
							if (num16 != 1)
							{
								num34 = 0;
								goto case 639;
							}
							num3 = 322;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 442;
						case 639:
						case 647:
							if (num34 < num32)
							{
								goto case 282;
							}
							goto case 276;
						case 276:
							lmdkVksVkh = new Hashtable(Iuo7Onpe8Wxmkcbqq1(object_2) + 1);
							num3 = 341;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 442:
							intptr_2 = IntPtr.Zero;
							num3 = 63;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 121;
						case 121:
							uint_ = (AwgKvrHJUS3TxryUsj)56;
							num3 = 332;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 274;
						case 274:
							array2[6] = (byte)num5;
							goto case 455;
						case 455:
							array2[7] = 95;
							num3 = 173;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 339;
						case 339:
							array2[7] = 36;
							goto case 19;
						case 19:
							array2[7] = 133;
							goto case 432;
						case 432:
							array2[7] = 197;
							goto case 391;
						case 391:
							num5 = 158;
							num3 = 30;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 41;
						case 41:
							array2[7] = (byte)num5;
							num = 167;
							goto case 167;
						case 167:
							array2[7] = 100;
							goto case 620;
						case 620:
							array2[8] = 156;
							goto case 129;
						case 129:
							num5 = 12;
							num3 = 578;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 646:
							intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(x4Dk2IHVmX))[0]);
							num = 186;
							goto case 186;
						case 186:
							num12 = intPtr4.ToInt64();
							goto case 502;
						case 502:
							int_2 = 0;
							num3 = 373;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 439;
						case 439:
							num28 = 0;
							goto case 254;
						case 254:
							if (uHAIjKrO4Hf6eUoVMo(x4Dk2IHVmX) != null)
							{
								goto case 509;
							}
							goto case 66;
						case 509:
							if (S88qBA7ZZJdCL7GTIm(uHAIjKrO4Hf6eUoVMo(x4Dk2IHVmX)) != 0)
							{
								num3 = 256;
								if (cnwib5vMRnDuwHuQHW())
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 66;
						case 66:
						case 91:
							num28 = 7680;
							goto case 48;
						case 48:
						case 256:
							num32 = Iuo7Onpe8Wxmkcbqq1(object_2);
							goto case 52;
						case 52:
							num16 = Iuo7Onpe8Wxmkcbqq1(object_2);
							num3 = 266;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 154:
						case 644:
							num38 = num38;
							goto case 218;
						case 218:
						{
							num43 = num38;
							uint num44 = num38;
							num44 ^= num44 << 7;
							num44 += 41672594;
							num44 ^= num44 >> 9;
							num44 += 2854470793u;
							num44 ^= num44 << 5;
							num44 += 3172641384u;
							num44 = 3372378988u - num44;
							num38 = num43 + (uint)(double)num44;
							goto case 203;
						}
						case 203:
							if (num22 != num23 - 1)
							{
								goto case 181;
							}
							num3 = 658;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 317;
						case 643:
							array4[6] = 120;
							num3 = 370;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 641:
							num6 = 144;
							goto case 621;
						case 621:
							array4[4] = (byte)num6;
							num3 = 27;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 103;
						case 103:
							num6 = 91;
							num3 = 79;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 640:
							num6 = 160;
							num3 = 236;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 636:
							array4[5] = (byte)num4;
							goto case 643;
						case 635:
							num40 = 0u;
							goto case 371;
						case 371:
							if (num37 > 0)
							{
								goto case 117;
							}
							goto case 626;
						case 117:
							num23++;
							num3 = 626;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 333;
						case 333:
							object_2 = new VtNVUKGulysZw81C3E(new MemoryStream(array14));
							num3 = 172;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 473;
						case 473:
							IbMqPdBO53HK0us9pI(HuHxx4nJ83h1bSJXOG(object_2), 0L);
							num3 = 646;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 235;
						case 499:
							if (num41 > 0)
							{
								goto case 680;
							}
							goto case 363;
						case 363:
							num40 |= array19[^(1 + num41)];
							num3 = 328;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 441;
						case 441:
							num41++;
							goto case 235;
						case 235:
						case 430:
							if (num41 >= num37)
							{
								goto case 154;
							}
							goto case 499;
						case 626:
							num42 = 0u;
							goto case 699;
						case 634:
							array9 = array2;
							num3 = 554;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 633:
							array4[5] = 139;
							num3 = 0;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 631:
							if (num37 > 0)
							{
								goto case 174;
							}
							goto case 482;
						case 174:
							num38 += num39;
							goto case 382;
						case 382:
							num40 = 0u;
							goto case 264;
						case 264:
							num41 = 0;
							num3 = 430;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 482:
							num42 = (uint)num18;
							num = 140;
							goto case 140;
						case 140:
							num38 += num39;
							goto case 613;
						case 613:
							num40 = (uint)((array19[num42 + 3] << 24) | (array19[num42 + 2] << 16) | (array19[num42 + 1] << 8) | array19[num42]);
							num3 = 644;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 630:
							array4[11] = (byte)num4;
							num3 = 679;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 629:
							array4[28] = 131;
							num3 = 108;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 628;
						case 628:
							num6 = 106;
							goto case 687;
						case 627:
							LG36xEd7ubVfYU1Gt0(object_2);
							num3 = 371;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 457;
						case 457:
							num32 = Iuo7Onpe8Wxmkcbqq1(object_2);
							num3 = 685;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 625:
							num4 = 67;
							num = 72;
							goto case 72;
						case 72:
							array4[26] = (byte)num4;
							num3 = 573;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 277;
						case 622:
							num6 = 100;
							goto case 531;
						case 531:
							array4[18] = (byte)num6;
							num = 542;
							goto case 542;
						case 542:
							num6 = 156;
							goto case 569;
						case 569:
							array4[18] = (byte)num6;
							goto case 414;
						case 414:
							array4[18] = 146;
							goto case 77;
						case 77:
							array4[18] = 85;
							goto case 503;
						case 503:
							array4[19] = 117;
							num3 = 556;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 617:
							num6 = 145;
							goto case 289;
						case 289:
							array4[11] = (byte)num6;
							goto case 387;
						case 387:
							array4[12] = 85;
							num = 278;
							goto case 278;
						case 278:
							array4[12] = 168;
							goto case 559;
						case 559:
							array4[12] = 165;
							num3 = 347;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 616:
							Gr3tuxv1KVbCXrOC5wF(rjRe5svWdF7rKS2QFfP(Hy9Pmgvf4eXW2dJhKG1(rNZkehfwNu)));
							num3 = 38;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 615:
							array9[13] = array10[6];
							goto case 169;
						case 169:
							array9[15] = array10[7];
							goto case 119;
						case 119:
							JAZe0xADYFLLoZwkVd(array10, 0, array10.Length);
							num = 180;
							goto case 101;
						case 101:
						case 180:
							num10 = 0;
							goto case 200;
						case 200:
						case 319:
							if (num10 < array9.Length)
							{
								goto case 114;
							}
							num3 = 264;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 286;
						case 286:
							array19 = array18;
							goto case 575;
						case 575:
							num37 = array19.Length % 4;
							num = 144;
							goto case 144;
						case 144:
							num23 = array19.Length / 4;
							goto case 348;
						case 348:
							array13 = new byte[array19.Length];
							goto case 43;
						case 43:
							num35 = array17.Length / 4;
							goto case 155;
						case 155:
							num38 = 0u;
							goto case 17;
						case 17:
							num39 = 0u;
							goto case 635;
						case 614:
							array2[9] = 168;
							num3 = 283;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 288;
						case 288:
							array2[9] = 57;
							num = 695;
							goto case 695;
						case 612:
							array4[13] = 168;
							goto case 683;
						case 611:
							num6 = 150;
							num3 = 253;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 609:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								goto case 507;
							}
							goto case 527;
						case 507:
							mTfoQqVbOE(intptr_2, intPtr, (byte[])iEk9VAQa23t2IMOZLf(Iuo7Onpe8Wxmkcbqq1(object_2)), 4u, out intptr_6);
							goto case 231;
						case 527:
							mTfoQqVbOE(intptr_2, intPtr, (byte[])iEk9VAQa23t2IMOZLf(Iuo7Onpe8Wxmkcbqq1(object_2)), 4u, out intptr_6);
							goto case 231;
						case 608:
							array2[8] = 117;
							goto case 15;
						case 15:
							num5 = 193;
							goto case 543;
						case 543:
							array2[9] = (byte)num5;
							num3 = 145;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 518;
						case 518:
							array2[9] = 153;
							goto case 592;
						case 592:
							array2[9] = 112;
							num3 = 268;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 606:
							value = ge0KN8vkOsWG9SgWvAT(intptr_5);
							goto case 85;
						case 605:
							array4[25] = (byte)num4;
							num = 284;
							goto case 284;
						case 284:
							num4 = 151;
							num3 = 229;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 604:
							XtMknffM5M = intPtr4.ToInt32();
							num = 571;
							goto case 571;
						case 571:
							intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(x4Dk2IHVmX))[0]);
							goto case 603;
						case 603:
							URnkCOceLK = intPtr4.ToInt64();
							goto case 564;
						case 564:
							intptr_6 = IntPtr.Zero;
							num = 566;
							goto case 566;
						case 566:
							num20 = 0;
							num3 = 14;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 602:
							num5 = 29;
							goto case 216;
						case 216:
							array2[1] = (byte)num5;
							goto case 179;
						case 179:
							array2[1] = 95;
							num3 = 100;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 88;
						case 88:
							array2[14] = 96;
							goto case 244;
						case 244:
							num5 = 137;
							num3 = 378;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 601:
							array4[10] = (byte)num4;
							goto case 314;
						case 314:
							array4[10] = 77;
							num3 = 330;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 221;
						case 221:
							array2[11] = (byte)num5;
							goto case 128;
						case 128:
							array2[11] = 92;
							goto case 110;
						case 110:
							array2[11] = 245;
							goto case 115;
						case 115:
							num5 = 134;
							goto case 526;
						case 526:
							array2[12] = (byte)num5;
							goto case 5;
						case 5:
							array2[12] = 109;
							goto case 275;
						case 275:
							num5 = 111;
							num3 = 27;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 13;
						case 13:
							intptr_ = LoadLibrary(text);
							goto case 76;
						case 76:
						case 486:
							array12 = new byte[6];
							num = 273;
							goto case 273;
						case 273:
							array12[0] = 103;
							num3 = 364;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 599:
							array4[7] = (byte)num4;
							goto case 201;
						case 201:
							array4[8] = 93;
							num3 = 159;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 598:
							IbMqPdBO53HK0us9pI(HuHxx4nJ83h1bSJXOG(object_2), 0L);
							goto case 192;
						case 192:
							array18 = (byte[])W0tB3fmF9aixUx94Wn(object_2, (int)Vd88xJYKwFGj5uKiAe(HuHxx4nJ83h1bSJXOG(object_2)));
							num3 = 113;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 148;
						case 148:
							array4 = new byte[32];
							num3 = 147;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 597:
							num5 = 149;
							num3 = 96;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 274;
						case 595:
							num5 = 150;
							goto case 523;
						case 523:
							array2[6] = (byte)num5;
							num3 = 53;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 593:
							num6 = 113;
							goto case 258;
						case 258:
							array4[10] = (byte)num6;
							goto case 248;
						case 248:
							array4[10] = 202;
							goto case 141;
						case 141:
							num4 = 137;
							num = 692;
							goto case 692;
						case 591:
							num6 = 66;
							goto case 291;
						case 291:
							array4[16] = (byte)num6;
							num3 = 358;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 248;
						case 590:
							if (((Array)mlYILKv95g53nR8ca6J(foiAigvMM7wCOoJ1Pc8(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).Length != 2)
							{
								goto case 638;
							}
							goto case 11;
						case 11:
							if (uHAIjKrO4Hf6eUoVMo(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly) == null)
							{
								num3 = 657;
								if (PsfwYibARbKayXDITm() == null)
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 139;
						case 139:
							if (S88qBA7ZZJdCL7GTIm(uHAIjKrO4Hf6eUoVMo(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)) <= 0)
							{
								goto case 638;
							}
							goto case 251;
						case 251:
							RKPutnyZ1ld0gp3H7Z();
							num3 = 344;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 90;
						case 589:
							num6 = 147;
							goto case 310;
						case 310:
							array4[26] = (byte)num6;
							num3 = 407;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 587:
							num4 = 244;
							goto case 599;
						case 586:
							num6 = 176;
							goto case 549;
						case 549:
							array4[28] = (byte)num6;
							goto case 629;
						case 584:
							array4[0] = 235;
							goto case 408;
						case 408:
							num6 = 129;
							num3 = 163;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 234;
						case 234:
							array4[1] = (byte)num6;
							goto case 131;
						case 131:
							num4 = 175;
							num3 = 445;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 583:
							array = new byte[10];
							goto case 393;
						case 393:
							array[0] = 99;
							num = 539;
							goto case 539;
						case 539:
							array[1] = 108;
							num3 = 468;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 581:
							array4[13] = 106;
							num3 = 125;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 239;
						case 239:
							num4 = 130;
							num3 = 493;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 580:
							array10 = (byte[])JukMcpOJhkrWqd5w1w(UajfJdw2Mgh8VeD29i(x4Dk2IHVmX));
							goto case 479;
						case 479:
							if (array10 == null)
							{
								goto case 101;
							}
							goto case 307;
						case 307:
							if (array10.Length <= 0)
							{
								goto case 101;
							}
							goto case 368;
						case 368:
							array9[1] = array10[0];
							goto case 532;
						case 532:
							array9[3] = array10[1];
							goto case 246;
						case 246:
							array9[5] = array10[2];
							goto case 301;
						case 301:
							array9[7] = array10[3];
							num3 = 170;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 579:
							intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(x4Dk2IHVmX))[0]);
							goto case 604;
						case 578:
							array2[8] = (byte)num5;
							num = 608;
							goto case 608;
						case 577:
							num34++;
							num3 = 647;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 576:
							array2[0] = 59;
							goto case 349;
						case 349:
							array2[1] = 175;
							num3 = 427;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 574:
							array7[num9 + 3] = array5[3];
							num3 = 193;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 573:
							num4 = 130;
							goto case 39;
						case 572:
							array4[24] = (byte)num4;
							num3 = 565;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 389:
						case 570:
							if (JS1MGkzc9J9wAiqxE4(HuHxx4nJ83h1bSJXOG(object_2)) < Vd88xJYKwFGj5uKiAe(HuHxx4nJ83h1bSJXOG(object_2)) - 1L)
							{
								num = 472;
								goto case 472;
							}
							goto case 142;
						case 472:
							num33 = Iuo7Onpe8Wxmkcbqq1(object_2);
							num3 = 691;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 568:
							num5 = 148;
							goto case 529;
						case 529:
							array2[11] = (byte)num5;
							goto case 176;
						case 176:
							array2[11] = 170;
							goto case 106;
						case 106:
							num5 = 145;
							goto case 221;
						case 567:
							array2[2] = (byte)num5;
							num3 = 279;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 565:
							num4 = 121;
							num3 = 19;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 28;
						case 28:
							array4[25] = (byte)num4;
							num3 = 462;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 563:
							num6 = 19;
							goto case 655;
						case 562:
							flag = AyfBTqfiQdaUA6JeXl(RsXJCxxWf3Kl90R6J5(P9E3JeMbivWI7BNYgN(cyAvcLGO1F6V544d5w(RlEepR6Ul0aEhb1wdK())), "__", 10u), IntPtr.Zero);
							goto case 476;
						case 476:
							if (flag)
							{
								goto case 665;
							}
							goto case 466;
						case 466:
							RKPutnyZ1ld0gp3H7Z();
							num3 = 243;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 560:
							array12[4] = 105;
							num3 = 197;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 557:
							array7[num15 + 6] = array11[6];
							num = 71;
							goto case 71;
						case 71:
							array7[num15 + 7] = array11[7];
							goto case 184;
						case 184:
							num15 = 30;
							goto case 674;
						case 556:
							num4 = 106;
							num = 138;
							goto case 138;
						case 138:
							array4[19] = (byte)num4;
							num3 = 318;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 555:
							procAddress = GetProcAddress(intptr_, string_);
							num3 = 8;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 31;
						case 31:
							object_9 = (OFfwWh6ZIHjfnqBOWx)HTUe0wvNPAcvIaonZBp(procAddress, eExcg9vJmltHggheFp3(typeof(OFfwWh6ZIHjfnqBOWx).TypeHandle));
							goto case 412;
						case 412:
							intptr_5 = RsKgNtvXnhiuittWgbI(object_9);
							goto case 33;
						case 33:
							value = 0L;
							goto case 98;
						case 98:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								num3 = 606;
								if (PsfwYibARbKayXDITm() == null)
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 399;
						case 399:
							value = Pnr23EvEYIIPdwulJk0(intptr_5);
							goto case 85;
						case 554:
							IVIY1AhrVOp6WyhexY(array9);
							num3 = 580;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 89;
						case 89:
							if (num29 < 1879048192)
							{
								goto case 653;
							}
							goto case 354;
						case 354:
							jDNkifbo3S = true;
							num = 653;
							goto case 653;
						case 552:
							num5 = 63;
							num3 = 66;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 418;
						case 418:
							array2[5] = (byte)num5;
							goto case 595;
						case 551:
							array4[24] = (byte)num6;
							goto case 434;
						case 434:
							num6 = 130;
							num3 = 143;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 548:
							RbVLmKZVBn7PqKKeeY(object_3, CipherMode.CBC);
							goto case 261;
						case 261:
							transform = (ICryptoTransform)QgFX6u8tARgbBxM4n4(object_3, array17, array9);
							goto case 158;
						case 158:
							JAZe0xADYFLLoZwkVd(array17, 0, array17.Length);
							goto case 82;
						case 82:
							memoryStream = new MemoryStream();
							goto case 175;
						case 175:
							object_8 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
							goto case 250;
						case 250:
							DunnU3tP2mNprIipAn(object_8, array18, 0, array18.Length);
							num3 = 668;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 547:
							array4[29] = (byte)num6;
							goto case 460;
						case 460:
							num4 = 245;
							num3 = 24;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 419;
						case 419:
							array4[29] = (byte)num4;
							num3 = 302;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 65:
						case 545:
							num22++;
							num3 = 86;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 544:
							reference3 = ref *(byte*)null;
							goto case 333;
						case 541:
							num7 = 0L;
							num3 = 49;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 540:
							array2[4] = (byte)num5;
							num3 = 17;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 161;
						case 161:
							num5 = 123;
							goto case 252;
						case 252:
							array2[5] = (byte)num5;
							num = 504;
							goto case 504;
						case 504:
							array2[5] = 144;
							num3 = 381;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 552;
						case 538:
							array4[4] = 100;
							goto case 641;
						case 537:
							array7[num9 + 2] = array11[2];
							goto case 388;
						case 388:
							array7[num9 + 3] = array11[3];
							num3 = 506;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 536:
							array[3] = 111;
							num3 = 480;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 535:
							num4 = 180;
							num = 81;
							goto case 81;
						case 81:
							array4[2] = (byte)num4;
							goto case 304;
						case 304:
							array4[2] = 150;
							num3 = 489;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 533:
							dnTFuIE1c6GhmSar5d();
							num3 = 376;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 14:
						case 530:
							if (num20 >= num32)
							{
								num3 = 570;
								if (cnwib5vMRnDuwHuQHW())
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 667;
						case 528:
							array2[15] = 104;
							num = 410;
							goto case 410;
						case 410:
							array2[15] = 75;
							num3 = 456;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 86;
						case 524:
							array2[15] = (byte)num5;
							num3 = 96;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 522:
							num6 = 132;
							num3 = 477;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 425;
						case 425:
							array4[11] = 87;
							goto case 205;
						case 205:
							num4 = 104;
							num3 = 630;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 521:
							array4[0] = (byte)num4;
							goto case 584;
						case 520:
							array4[31] = 91;
							goto case 67;
						case 67:
							array17 = array4;
							goto case 351;
						case 351:
							array2 = new byte[16];
							num = 461;
							goto case 461;
						case 461:
							num5 = 105;
							goto case 401;
						case 401:
							array2[0] = (byte)num5;
							num3 = 227;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 519:
							YeeoMqaS3J(intptr_4, num21 * 4, 4, ref int_2);
							num = 676;
							goto case 676;
						case 516:
							if (array6.Length != 0)
							{
								num3 = 25;
								if (!cnwib5vMRnDuwHuQHW())
								{
									continue;
								}
								goto case 182;
							}
							goto case 281;
						case 182:
						case 306:
							while (true)
							{
								IL_33cc:
								fixed (byte* ptr = &array6[0])
								{
									num3 = 478;
									if (cnwib5vMRnDuwHuQHW())
									{
										goto IL_002f_3;
									}
									goto IL_0b5b_2;
									IL_0b5b_2:
									num3 = num;
									goto IL_002f_3;
									IL_002f_3:
									while (true)
									{
										switch (num3)
										{
										case 544:
											goto end_IL_002f;
										case 105:
											if (!MrkkWebIMK)
											{
												goto case 104;
											}
											goto case 212;
										case 104:
											MrkkWebIMK = true;
											goto case 447;
										case 447:
											num2 = 4059231220u;
											num3 = 102;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 700:
											array4[28] = 218;
											goto case 491;
										case 491:
											array4[29] = 169;
											num3 = 417;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 699:
											num22 = 0;
											num = 300;
											goto case 86;
										case 86:
										case 300:
											if (num22 >= num23)
											{
												num = 485;
												goto case 485;
											}
											goto case 550;
										case 485:
											array14 = array13;
											goto case 561;
										case 561:
											num30 = array14.Length / 8;
											num3 = 355;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 550:
											num36 = num22 % num35;
											goto case 90;
										case 90:
											num18 = num22 * 4;
											goto case 230;
										case 230:
											num42 = (uint)(num36 * 4);
											num3 = 353;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 624;
										case 624:
											num39 = (uint)((array17[num42 + 3] << 24) | (array17[num42 + 2] << 16) | (array17[num42 + 1] << 8) | array17[num42]);
											num3 = 272;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 698:
											array4[16] = 96;
											num3 = 146;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 135;
										case 135:
											num4 = 99;
											goto case 384;
										case 384:
											array4[9] = (byte)num4;
											goto case 327;
										case 327:
											num4 = 112;
											num = 558;
											goto case 558;
										case 558:
											array4[9] = (byte)num4;
											num3 = 130;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 697:
											array4[15] = 101;
											goto case 342;
										case 342:
											array4[15] = 71;
											goto case 698;
										case 696:
											array7[num15 + 1] = array5[1];
											goto case 422;
										case 422:
											array7[num15 + 2] = array5[2];
											num = 283;
											goto case 283;
										case 283:
											array7[num15 + 3] = array5[3];
											goto case 343;
										case 343:
											array7[num15 + 4] = array5[4];
											num3 = 92;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 316;
										case 316:
											array7[num15 + 5] = array5[5];
											goto case 360;
										case 360:
											array7[num15 + 6] = array5[6];
											num = 245;
											goto case 245;
										case 245:
											array7[num15 + 7] = array5[7];
											goto case 97;
										case 97:
										case 193:
											PRvHE6k6bN6cQqTYut(array7, 0, intPtr3, array7.Length);
											goto case 57;
										case 57:
											xo4kuDarJK = false;
											num3 = 190;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 695:
											num5 = 49;
											num3 = 55;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 39;
										case 39:
											array4[27] = (byte)num4;
											num3 = 92;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 265;
										case 265:
											array4[27] = 121;
											goto case 659;
										case 659:
											num4 = 93;
											num = 582;
											goto case 582;
										case 582:
											array4[27] = (byte)num4;
											num3 = 451;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 694:
											array[9] = 100;
											num = 365;
											goto case 365;
										case 365:
											array[10] = 108;
											goto case 195;
										case 195:
											array[11] = 108;
											goto case 413;
										case 413:
											text = (string)Td1ATdvqFhFtIHvr48J(JLXqf5vRx2aaqd89sBE(), array);
											goto case 64;
										case 64:
											intptr_ = LoadLibrary(text);
											num3 = 259;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 693:
											num5 = 81;
											goto case 164;
										case 164:
											array2[12] = (byte)num5;
											goto case 46;
										case 46:
											array2[13] = 88;
											num = 220;
											goto case 220;
										case 220:
											array2[13] = 68;
											goto case 118;
										case 118:
											num5 = 176;
											num3 = 36;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 84;
										case 84:
											array2[13] = (byte)num5;
											goto case 594;
										case 594:
											array2[13] = 60;
											num3 = 338;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 692:
											array4[10] = (byte)num4;
											num3 = 369;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 691:
											intptr_4 = new IntPtr(URnkCOceLK + num33 - num28);
											num3 = 385;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 213;
										case 213:
											array8 = null;
											goto case 610;
										case 610:
											if (T8HYV799DYUL4uCJUx() != 4)
											{
												goto case 645;
											}
											goto case 168;
										case 645:
											array8 = (byte[])uhrG7DvcRwZPmrZdGRP(VE2k4S5okQ.ToInt64());
											num3 = 92;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 87;
										case 87:
											array22 = new byte[30];
											h7hAE7vCXPBh5lF0GOV(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
											array3 = array22;
											num = 63;
											goto case 63;
										case 498:
											array7 = array3;
											num = 553;
											goto case 553;
										case 553:
											array5 = null;
											goto case 546;
										case 546:
											array11 = null;
											goto case 213;
										case 63:
										case 395:
											intPtr3 = E11Blivl1C9EaDqc0ae(IntPtr.Zero, (uint)array3.Length, 4096u, 64u);
											goto case 498;
										case 168:
											array8 = (byte[])iEk9VAQa23t2IMOZLf(VE2k4S5okQ.ToInt32());
											num = 224;
											goto case 224;
										case 224:
											array5 = (byte[])iEk9VAQa23t2IMOZLf(intPtr2.ToInt32());
											goto case 323;
										case 323:
											array11 = (byte[])iEk9VAQa23t2IMOZLf(HPrO0MvTd8MUVO2iftT(num7));
											goto case 309;
										case 309:
										case 403:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												num3 = 127;
												if (PsfwYibARbKayXDITm() == null)
												{
													continue;
												}
												break;
											}
											goto case 449;
										case 449:
											num15 = 2;
											goto case 345;
										case 345:
											array7[num15] = array8[0];
											num = 508;
											goto case 508;
										case 508:
											array7[num15 + 1] = array8[1];
											num3 = 331;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 50:
										case 690:
											object_12 = (Process)RlEepR6Ul0aEhb1wdK();
											goto case 22;
										case 22:
											try
											{
												ProcessModuleCollection object_13 = (ProcessModuleCollection)aN79LMiWBPpE4sELsP(object_12);
												while (true)
												{
													enumerator = (IEnumerator)tLhWr2gLT94ta57ay6(object_13);
													num61 = 1;
													if (PsfwYibARbKayXDITm() != null)
													{
														switch (num61)
														{
														case 2:
															continue;
														default:
															goto end_IL_0fa8_2;
														case 1:
															break;
														case 0:
															goto end_IL_0fa8_2;
														}
													}
													try
													{
														while (true)
														{
															IL_10d4_2:
															if (!l5DauXK3JZLhJMEyVn(enumerator))
															{
																num62 = 7;
																if (PsfwYibARbKayXDITm() == null)
																{
																	goto IL_1031_3;
																}
																goto IL_105a_2;
															}
															goto IL_10b2_2;
															IL_1031_3:
															while (true)
															{
																switch (num62)
																{
																case 5:
																	break;
																case 4:
																	goto end_IL_1031_2;
																default:
																	goto IL_105a_2;
																case 8:
																	goto IL_108a_2;
																case 6:
																	goto IL_10a0_2;
																case 2:
																	goto IL_10b2_2;
																case 3:
																	goto IL_10d4_2;
																case 1:
																	return;
																case 7:
																	goto end_IL_10d4_2;
																}
																num63 = num7;
																intPtr4 = P9E3JeMbivWI7BNYgN(object_14);
																if (num63 <= intPtr4.ToInt64() + eSLb8pvGTBwtRbXYXPE(object_14))
																{
																	goto IL_10d4_2;
																}
																num62 = 0;
																if (PsfwYibARbKayXDITm() == null)
																{
																	continue;
																}
																goto IL_1017_2;
																continue;
																end_IL_1031_2:
																break;
															}
															goto IL_101d_2;
															IL_10b2_2:
															object_14 = (ProcessModule)SpecVgcCHhCjLNxNT2(enumerator);
															goto IL_10a0_2;
															IL_10a0_2:
															if (!AEnLDv18ZTuoKbb5wM(u8JRrRoicD0sGpHK09(object_14), text))
															{
																continue;
															}
															goto IL_108a_2;
															IL_108a_2:
															num64 = num7;
															intPtr4 = P9E3JeMbivWI7BNYgN(object_14);
															if (num64 >= intPtr4.ToInt64())
															{
																num62 = 5;
																if (PsfwYibARbKayXDITm() == null)
																{
																	goto IL_1031_3;
																}
															}
															goto IL_105a_2;
															IL_101d_2:
															RKPutnyZ1ld0gp3H7Z();
															num62 = 1;
															if (!cnwib5vMRnDuwHuQHW())
															{
																goto IL_1017_2;
															}
															goto IL_1031_3;
															IL_105a_2:
															if (!fxUQ1dvxhoIVa5wbxGn(foiAigvMM7wCOoJ1Pc8(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
															{
																continue;
															}
															num62 = 3;
															if (cnwib5vMRnDuwHuQHW())
															{
																goto IL_101d_2;
															}
															goto IL_1031_3;
															IL_1017_2:
															num62 = num65;
															goto IL_1031_3;
															continue;
															end_IL_10d4_2:
															break;
														}
													}
													finally
													{
														IDisposable disposable = enumerator as IDisposable;
														num66 = 0;
														if (!cnwib5vMRnDuwHuQHW())
														{
															goto IL_1113_2;
														}
														goto IL_1126_2;
														IL_1126_2:
														switch (num66)
														{
														case 2:
															break;
														default:
															goto IL_1113_2;
														case 1:
														case 3:
															goto end_IL_10e6_2;
														}
														goto IL_10fe_2;
														IL_1113_2:
														if (disposable == null)
														{
															num66 = 3;
															if (PsfwYibARbKayXDITm() == null)
															{
																goto IL_1126_2;
															}
														}
														goto IL_10fe_2;
														IL_10fe_2:
														OcB3D1aSiX4yvSrrNs(disposable);
														num66 = 0;
														if (!cnwib5vMRnDuwHuQHW())
														{
															goto IL_1126_2;
														}
														end_IL_10e6_2:;
													}
													break;
													continue;
													end_IL_0fa8_2:
													break;
												}
											}
											catch (object obj5)
											{
												num67 = 0;
												if (PsfwYibARbKayXDITm() != null)
												{
													num67 = num68;
												}
												switch (num67)
												{
												}
											}
											goto case 8;
										case 8:
											try
											{
												ProcessModuleCollection object_15 = (ProcessModuleCollection)aN79LMiWBPpE4sELsP(object_12);
												num69 = 0;
												if (!cnwib5vMRnDuwHuQHW())
												{
													switch (num69)
													{
													case 2:
														goto IL_1190_2;
													case 1:
														goto end_IL_115e_2;
													}
												}
												enumerator = (IEnumerator)tLhWr2gLT94ta57ay6(object_15);
												goto IL_1190_2;
												IL_1190_2:
												try
												{
													while (true)
													{
														if (!l5DauXK3JZLhJMEyVn(enumerator))
														{
															num70 = 0;
															if (PsfwYibARbKayXDITm() == null)
															{
																break;
															}
															goto IL_11ba_2;
														}
														goto IL_11f5_2;
														IL_1194_2:
														num28 = 0;
														num70 = 2;
														if (!cnwib5vMRnDuwHuQHW())
														{
															num70 = num71;
														}
														goto IL_11ba_2;
														IL_11f5_2:
														object_16 = (ProcessModule)SpecVgcCHhCjLNxNT2(enumerator);
														goto IL_11dd_2;
														IL_11dd_2:
														intPtr4 = P9E3JeMbivWI7BNYgN(object_16);
														num70 = 1;
														if (cnwib5vMRnDuwHuQHW())
														{
															goto IL_11aa_2;
														}
														goto IL_11ba_2;
														IL_11ba_2:
														switch (num70)
														{
														case 3:
															break;
														case 1:
															goto IL_11aa_2;
														default:
															goto end_IL_1213_2;
														case 5:
															goto IL_11dd_2;
														case 4:
															goto IL_11f5_2;
														case 6:
															continue;
														case 0:
														case 2:
															goto end_IL_1213_2;
														}
														goto IL_1194_2;
														IL_11aa_2:
														if (intPtr4.ToInt64() != eXJkjmTXDX)
														{
															continue;
														}
														goto IL_1194_2;
														continue;
														end_IL_1213_2:
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator as IDisposable;
													num72 = 0;
													if (!cnwib5vMRnDuwHuQHW())
													{
														num72 = num73;
													}
													do
													{
														switch (num72)
														{
														case 2:
															break;
														default:
															if (disposable != null)
															{
																break;
															}
															goto end_IL_1258_2;
														case 1:
															goto end_IL_1258_2;
														}
														OcB3D1aSiX4yvSrrNs(disposable);
														num72 = 0;
														continue;
														end_IL_1258_2:
														break;
													}
													while (PsfwYibARbKayXDITm() != null);
												}
												end_IL_115e_2:;
											}
											catch (object obj6)
											{
												num74 = 0;
												if (!cnwib5vMRnDuwHuQHW())
												{
													switch (num74)
													{
													}
												}
											}
											goto case 409;
										case 409:
											abxkLGOVrU = null;
											num3 = 686;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 689:
											array[2] = 99;
											num3 = 536;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 688:
											num7 = ge0KN8vkOsWG9SgWvAT(new IntPtr(value));
											num3 = 50;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 687:
											array4[28] = (byte)num6;
											num3 = 699;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 700;
										case 686:
											try
											{
												abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)HTUe0wvNPAcvIaonZBp(new IntPtr(num7), eExcg9vJmltHggheFp3(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
												num55 = 0;
												if (cnwib5vMRnDuwHuQHW())
												{
													switch (num55)
													{
													}
												}
											}
											catch (object obj4)
											{
												num56 = 0;
												if (PsfwYibARbKayXDITm() != null)
												{
													switch (num56)
													{
													default:
														goto end_IL_1345_2;
													case 1:
														break;
													case 0:
														goto end_IL_1345_2;
													}
												}
												try
												{
													Delegate object_11 = (Delegate)HTUe0wvNPAcvIaonZBp(new IntPtr(num7), eExcg9vJmltHggheFp3(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
													num57 = 0;
													if (!cnwib5vMRnDuwHuQHW())
													{
														goto IL_13bc_2;
													}
													goto IL_13c0_3;
													IL_13c0_3:
													while (true)
													{
														switch (num57)
														{
														case 1:
															goto end_IL_13c0_2;
														}
														abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)GP0ZpVvyG9rn9ofeyf7(eExcg9vJmltHggheFp3(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle), Hy9Pmgvf4eXW2dJhKG1(object_11));
														num57 = 1;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														goto IL_13bc_2;
														continue;
														end_IL_13c0_2:
														break;
													}
													goto end_IL_1368_2;
													IL_13bc_2:
													num57 = num58;
													goto IL_13c0_3;
													end_IL_1368_2:;
												}
												catch (object obj3)
												{
													num59 = 0;
													if (!cnwib5vMRnDuwHuQHW())
													{
														num59 = num60;
													}
													switch (num59)
													{
													default:
														goto end_IL_13d1_2;
													}
													end_IL_13d1_2:;
												}
												end_IL_1345_2:;
											}
											goto case 177;
										case 177:
											num3 = 1;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 685:
											num16 = Iuo7Onpe8Wxmkcbqq1(object_2);
											num3 = 219;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 684:
											array4[15] = 154;
											num3 = 32;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 683:
											array4[13] = 157;
											num3 = 581;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 356;
										case 356:
											JAZe0xADYFLLoZwkVd(array9, 0, array9.Length);
											goto case 242;
										case 242:
											CCYWllDJfu0U4ZAtBI(memoryStream);
											goto case 78;
										case 78:
											CCYWllDJfu0U4ZAtBI(object_8);
											num3 = 627;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 682:
											array13[num18 + 1] = (byte)((num19 & 0xFF00) >> 8);
											num3 = 322;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 681:
											num6 = 134;
											num3 = 7;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 334;
										case 334:
											array4[1] = (byte)num6;
											goto case 652;
										case 652:
											array4[1] = 162;
											num3 = 109;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 680:
											num40 <<= 8;
											num3 = 363;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 679:
											array4[11] = 168;
											num3 = 617;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 678:
											array7[num15 + 5] = array8[5];
											num3 = 673;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 585;
										case 585:
											array4[25] = 156;
											num3 = 140;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 326;
										case 326:
											array4[25] = 94;
											num3 = 157;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 147;
										case 147:
											num6 = 158;
											num3 = 60;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 677:
											array4[21] = (byte)num4;
											num3 = 321;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 676:
											num54 = 0;
											num3 = 161;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 162;
										case 415:
											aQbsnKvu6jFlFVsqWqM(new IntPtr(intptr_4.ToInt64() + num54 * 4), Iuo7Onpe8Wxmkcbqq1(object_2));
											num3 = 135;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 296;
										case 296:
											num54++;
											goto case 162;
										case 162:
										case 280:
											if (num54 < num21)
											{
												goto case 415;
											}
											goto case 287;
										case 287:
											YeeoMqaS3J(intptr_4, num21 * 4, int_2, ref int_2);
											num3 = 389;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 675:
											array7[num9 + 1] = array8[1];
											num3 = 203;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 298;
										case 298:
											array7[num9 + 2] = array8[2];
											goto case 308;
										case 308:
											array7[num9 + 3] = array8[3];
											num3 = 42;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 132;
										case 132:
											num9 = 16;
											num3 = 8;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 112;
										case 112:
											array7[num9] = array11[0];
											num3 = 185;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 674:
											array7[num15] = array5[0];
											goto case 696;
										case 673:
											array7[num15 + 6] = array8[6];
											goto case 596;
										case 596:
											array7[num15 + 7] = array8[7];
											goto case 525;
										case 525:
											num15 = 18;
											goto case 25;
										case 25:
											array7[num15] = array11[0];
											goto case 35;
										case 35:
											array7[num15 + 1] = array11[1];
											num3 = 428;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 672:
											num6 = 50;
											num3 = 405;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 671:
											num4 = 191;
											goto case 30;
										case 30:
											array4[8] = (byte)num4;
											goto case 607;
										case 607:
											num4 = 81;
											goto case 20;
										case 20:
											array4[8] = (byte)num4;
											goto case 183;
										case 183:
											array4[9] = 77;
											num3 = 135;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 670:
											array4[6] = (byte)num6;
											goto case 435;
										case 435:
											num4 = 110;
											goto case 269;
										case 269:
											array4[6] = (byte)num4;
											goto case 125;
										case 125:
											array4[6] = 82;
											num = 377;
											goto case 377;
										case 377:
											num6 = 139;
											num3 = 170;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 232;
										case 232:
											array4[6] = (byte)num6;
											goto case 226;
										case 226:
											num4 = 211;
											num3 = 200;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 373;
										case 373:
											array4[6] = (byte)num4;
											num3 = 522;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 669:
											array4[30] = 142;
											goto case 207;
										case 207:
											num6 = 162;
											goto case 623;
										case 623:
											array4[30] = (byte)num6;
											goto case 513;
										case 513:
											array4[31] = 116;
											goto case 483;
										case 483:
											num4 = 132;
											num3 = 134;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 668:
											miJRONPWPUPfHF3idq(object_8);
											num = 222;
											goto case 222;
										case 222:
											array14 = (byte[])KBm26YS06UbN6kI08B(memoryStream);
											goto case 356;
										case 667:
											intPtr = new IntPtr(URnkCOceLK + Iuo7Onpe8Wxmkcbqq1(object_2) - num28);
											num3 = 73;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 666:
											array2[3] = 163;
											num = 208;
											goto case 208;
										case 208:
											array2[4] = 208;
											goto case 618;
										case 618:
											array2[4] = 22;
											goto case 534;
										case 534:
											num5 = 127;
											num3 = 52;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 152;
										case 152:
											array2[4] = (byte)num5;
											num3 = 335;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 665:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												num = 454;
												goto case 454;
											}
											goto case 16;
										case 454:
											if (jprDK4L5TKMDTrvTwV(hiIW3l0lJxxPIgBHXy("System.Reflection.ReflectionContext", bool_0: false), null))
											{
												goto case 517;
											}
											goto case 16;
										case 517:
											object_ = (ProcessModuleCollection)aN79LMiWBPpE4sELsP(RlEepR6Ul0aEhb1wdK());
											num3 = 24;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 16:
										case 656:
											object_2 = new VtNVUKGulysZw81C3E((Stream)dJC3oLVPNiFZJlbpnH(x4Dk2IHVmX, "9NW9oT68xVJCdNlkEg.aylDCiEMpMcRySTSil"));
											num3 = 598;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 231:
										case 664:
											YeeoMqaS3J(intPtr, 4, int_2, ref int_2);
											num3 = 381;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 177;
										case 663:
											gsK9XnRnQvtX7ikaZv(new IntPtr(&num8), 0);
											goto case 151;
										case 151:
											PDnPGLq8flejBjnsh8(new IntPtr(&num8), 0, IntPtr.Zero);
											num3 = 292;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 662:
											num5 = 166;
											num3 = 6;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 37;
										case 37:
											array2[3] = (byte)num5;
											num3 = 666;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 661:
											array4[1] = (byte)num6;
											num3 = 535;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 85:
										case 660:
											ymo9V3JfkrBEwjVuTN(intptr_5, 0);
											num3 = 450;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 9;
										case 406:
											num53++;
											goto case 260;
										case 260:
										case 352:
											if (num53 >= num37)
											{
												num3 = 545;
												if (cnwib5vMRnDuwHuQHW())
												{
													continue;
												}
												break;
											}
											goto case 619;
										case 619:
											if (num53 <= 0)
											{
												goto case 632;
											}
											goto case 423;
										case 632:
											array13[num18 + num53] = (byte)((num52 & num17) >> num11);
											goto case 406;
										case 423:
											num17 <<= 8;
											goto case 9;
										case 9:
											num11 += 8;
											goto case 632;
										case 658:
											if (num37 > 0)
											{
												goto case 458;
											}
											goto case 181;
										case 458:
											num52 = num38 ^ num40;
											goto case 206;
										case 206:
											num53 = 0;
											num3 = 260;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 181:
											num19 = num38 ^ num40;
											goto case 42;
										case 42:
											array13[num18] = (byte)(num19 & 0xFFu);
											num3 = 682;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 317;
										case 317:
											array4[25] = (byte)num6;
											num = 585;
											goto case 585;
										case 638:
										case 657:
											try
											{
												object obj = C3AtdsvgmNIMmgVcrDX(Q177RmviuWhVERK2cMk(KkUYfQvLAQWEPaeEvUt(L8dTWnv0laKtHr0pv7A(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), KkUYfQvLAQWEPaeEvUt(L8dTWnv0laKtHr0pv7A(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)));
												num45 = 13;
												if (PsfwYibARbKayXDITm() != null)
												{
													goto IL_1c1f_2;
												}
												goto IL_1d51_3;
												IL_1d51_3:
												while (true)
												{
													switch (num45)
													{
													case 9:
													case 18:
														DunnU3tP2mNprIipAn(object_10, new byte[T8HYV799DYUL4uCJUx()], 0, T8HYV799DYUL4uCJUx());
														num45 = 11;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														goto end_IL_1d51_2;
													case 16:
														DunnU3tP2mNprIipAn(object_10, new byte[T8HYV799DYUL4uCJUx()], 0, T8HYV799DYUL4uCJUx());
														goto case 12;
													case 12:
														if (T8HYV799DYUL4uCJUx() == 4)
														{
															num49 = 3;
															goto case 3;
														}
														goto case 4;
													case 3:
														DunnU3tP2mNprIipAn(object_10, iEk9VAQa23t2IMOZLf(VE2k4S5okQ.ToInt32()), 0, 4);
														num45 = 9;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														break;
													case 4:
														DunnU3tP2mNprIipAn(object_10, uhrG7DvcRwZPmrZdGRP(VE2k4S5okQ.ToInt64()), 0, 8);
														num45 = 18;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														break;
													case 2:
													case 15:
														object_10 = new MemoryStream();
														num45 = 12;
														if (PsfwYibARbKayXDITm() != null)
														{
															continue;
														}
														goto case 16;
													case 14:
														VE2k4S5okQ = (IntPtr)obj;
														num45 = 6;
														if (PsfwYibARbKayXDITm() == null)
														{
															continue;
														}
														break;
													case 13:
														if (obj is IntPtr)
														{
															num45 = 14;
															if (PsfwYibARbKayXDITm() == null)
															{
																continue;
															}
															break;
														}
														goto case 6;
													case 6:
														if (!AEnLDv18ZTuoKbb5wM(obj.GetType().ToString(), "System.Reflection.RuntimeModule"))
														{
															num49 = 15;
															goto case 2;
														}
														goto case 1;
													case 1:
														VE2k4S5okQ = (IntPtr)C3AtdsvgmNIMmgVcrDX(obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj);
														num49 = 2;
														goto case 2;
													case 11:
														DunnU3tP2mNprIipAn(object_10, new byte[T8HYV799DYUL4uCJUx()], 0, T8HYV799DYUL4uCJUx());
														num45 = 0;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														break;
													case 10:
														CCYWllDJfu0U4ZAtBI(object_10);
														goto case 8;
													case 8:
														nativeSizeOfCode = 0u;
														num45 = 17;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														goto case 9;
													case 5:
														array20 = (byte[])KBm26YS06UbN6kI08B(object_10);
														num45 = 10;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														break;
													default:
														IbMqPdBO53HK0us9pI(object_10, 0L);
														num45 = 5;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														goto case 5;
													case 17:
														try
														{
															array21 = (array6 = array20);
															if (array21 != null)
															{
																goto IL_1df1_2;
															}
															goto IL_1e35_3;
															IL_1e35_3:
															while (true)
															{
																IL_1e35_4:
																reference2 = ref *(byte*)null;
																num46 = 5;
																if (PsfwYibARbKayXDITm() != null)
																{
																	num46 = num47;
																}
																while (true)
																{
																	switch (num46)
																	{
																	case 1:
																	case 5:
																		rNZkehfwNu(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
																		num46 = 1;
																		if (!cnwib5vMRnDuwHuQHW())
																		{
																			continue;
																		}
																		goto end_IL_1da5_2;
																	case 3:
																		break;
																	default:
																		goto IL_1df7_3;
																	case 4:
																		goto IL_1e35_4;
																	case 6:
																		goto end_IL_1da5_2;
																	}
																	break;
																}
																break;
															}
															goto IL_1df1_2;
															IL_1df7_3:
															while (true)
															{
																fixed (byte* value2 = &array6[0])
																{
																	num46 = 1;
																	if (!cnwib5vMRnDuwHuQHW())
																	{
																		num46 = num47;
																	}
																	while (true)
																	{
																		switch (num46)
																		{
																		case 0:
																		case 2:
																			break;
																		case 1:
																		case 5:
																			rNZkehfwNu(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
																			num46 = 1;
																			if (!cnwib5vMRnDuwHuQHW())
																			{
																				continue;
																			}
																			goto end_IL_1da5_2;
																		case 3:
																			if (array6.Length == 0)
																			{
																				goto end_IL_1df7_2;
																			}
																			break;
																		case 4:
																			goto end_IL_1df7_2;
																		case 6:
																			goto end_IL_1da5_2;
																		}
																		break;
																	}
																}
																continue;
																end_IL_1df7_2:
																break;
															}
															goto IL_1e35_3;
															IL_1df1_2:
															if (array6.Length != 0)
															{
																goto IL_1df7_3;
															}
															goto IL_1e35_3;
															end_IL_1da5_2:;
														}
														finally
														{
															reference2 = ref *(byte*)null;
															num48 = 0;
															if (cnwib5vMRnDuwHuQHW())
															{
																switch (num48)
																{
																}
															}
														}
														goto end_IL_1d51_2;
													case 7:
														goto end_IL_1d51_2;
													}
													goto IL_1c1f_2;
													continue;
													end_IL_1d51_2:
													break;
												}
												goto end_IL_1b11_2;
												IL_1c1f_2:
												num45 = num49;
												goto IL_1d51_3;
												end_IL_1b11_2:;
											}
											catch (object obj2)
											{
												num50 = 0;
												if (PsfwYibARbKayXDITm() != null)
												{
													num50 = num51;
												}
												switch (num50)
												{
												}
											}
											goto case 211;
										case 211:
											CwIXyivo1EmpV0ysNqL(abxkLGOVrU);
											num3 = 396;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 655:
											array4[21] = (byte)num6;
											goto case 495;
										case 495:
											array4[22] = 124;
											num3 = 204;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 114;
										case 114:
											array17[num10] = (byte)(array17[num10] ^ array9[num10]);
											num3 = 198;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 654:
											array4[0] = 62;
											num3 = 267;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 653:
											int_3 = Iuo7Onpe8Wxmkcbqq1(object_2);
											goto case 277;
										case 277:
											jsbkrdexts = (byte[])W0tB3fmF9aixUx94Wn(object_2, int_3);
											goto case 62;
										case 62:
											bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
											num3 = 68;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 651:
											array4[23] = 151;
											goto case 386;
										case 386:
											array4[23] = 102;
											goto case 588;
										case 588:
											num4 = 240;
											num3 = 293;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 215;
										case 215:
											num4 = 95;
											goto case 225;
										case 225:
											array4[1] = (byte)num4;
											goto case 681;
										case 650:
											num5 = 99;
											num3 = 346;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 649:
											array4[14] = (byte)num4;
											goto case 397;
										case 397:
											array4[14] = 114;
											goto case 642;
										case 642:
											num6 = 69;
											goto case 637;
										case 637:
											array4[14] = (byte)num6;
											num3 = 684;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 515;
										case 515:
											array2[15] = (byte)num5;
											num = 83;
											goto case 83;
										case 83:
											num5 = 163;
											goto case 492;
										case 492:
											array2[15] = (byte)num5;
											num3 = 634;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 648:
											num4 = 156;
											num3 = 237;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 282:
											intptr_3 = new IntPtr(num12 + Iuo7Onpe8Wxmkcbqq1(object_2) - num28);
											goto case 156;
										case 156:
											YeeoMqaS3J(intptr_3, 4, 4, ref int_2);
											goto case 367;
										case 367:
											aQbsnKvu6jFlFVsqWqM(intptr_3, Iuo7Onpe8Wxmkcbqq1(object_2));
											num3 = 484;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 219;
										case 219:
											if (num16 != 1)
											{
												num34 = 0;
												goto case 639;
											}
											num3 = 322;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 442;
										case 639:
										case 647:
											if (num34 < num32)
											{
												goto case 282;
											}
											goto case 276;
										case 276:
											lmdkVksVkh = new Hashtable(Iuo7Onpe8Wxmkcbqq1(object_2) + 1);
											num3 = 341;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 442:
											intptr_2 = IntPtr.Zero;
											num3 = 63;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 121;
										case 121:
											uint_ = (AwgKvrHJUS3TxryUsj)56;
											num3 = 332;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 274;
										case 274:
											array2[6] = (byte)num5;
											goto case 455;
										case 455:
											array2[7] = 95;
											num3 = 173;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 339;
										case 339:
											array2[7] = 36;
											goto case 19;
										case 19:
											array2[7] = 133;
											goto case 432;
										case 432:
											array2[7] = 197;
											goto case 391;
										case 391:
											num5 = 158;
											num3 = 30;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 41;
										case 41:
											array2[7] = (byte)num5;
											num = 167;
											goto case 167;
										case 167:
											array2[7] = 100;
											goto case 620;
										case 620:
											array2[8] = 156;
											goto case 129;
										case 129:
											num5 = 12;
											num3 = 578;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 646:
											intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(x4Dk2IHVmX))[0]);
											num = 186;
											goto case 186;
										case 186:
											num12 = intPtr4.ToInt64();
											goto case 502;
										case 502:
											int_2 = 0;
											num3 = 373;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 439;
										case 439:
											num28 = 0;
											goto case 254;
										case 254:
											if (uHAIjKrO4Hf6eUoVMo(x4Dk2IHVmX) != null)
											{
												goto case 509;
											}
											goto case 66;
										case 509:
											if (S88qBA7ZZJdCL7GTIm(uHAIjKrO4Hf6eUoVMo(x4Dk2IHVmX)) != 0)
											{
												num3 = 256;
												if (cnwib5vMRnDuwHuQHW())
												{
													continue;
												}
												break;
											}
											goto case 66;
										case 66:
										case 91:
											num28 = 7680;
											goto case 48;
										case 48:
										case 256:
											num32 = Iuo7Onpe8Wxmkcbqq1(object_2);
											goto case 52;
										case 52:
											num16 = Iuo7Onpe8Wxmkcbqq1(object_2);
											num3 = 266;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 154:
										case 644:
											num38 = num38;
											goto case 218;
										case 218:
										{
											num43 = num38;
											uint num44 = num38;
											num44 ^= num44 << 7;
											num44 += 41672594;
											num44 ^= num44 >> 9;
											num44 += 2854470793u;
											num44 ^= num44 << 5;
											num44 += 3172641384u;
											num44 = 3372378988u - num44;
											num38 = num43 + (uint)(double)num44;
											goto case 203;
										}
										case 203:
											if (num22 != num23 - 1)
											{
												goto case 181;
											}
											num3 = 658;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 317;
										case 643:
											array4[6] = 120;
											num3 = 370;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 641:
											num6 = 144;
											goto case 621;
										case 621:
											array4[4] = (byte)num6;
											num3 = 27;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 103;
										case 103:
											num6 = 91;
											num3 = 79;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 640:
											num6 = 160;
											num3 = 236;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 636:
											array4[5] = (byte)num4;
											goto case 643;
										case 635:
											num40 = 0u;
											goto case 371;
										case 371:
											if (num37 > 0)
											{
												goto case 117;
											}
											goto case 626;
										case 117:
											num23++;
											num3 = 626;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 333;
										case 333:
											object_2 = new VtNVUKGulysZw81C3E(new MemoryStream(array14));
											num3 = 172;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 473;
										case 473:
											IbMqPdBO53HK0us9pI(HuHxx4nJ83h1bSJXOG(object_2), 0L);
											num3 = 646;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 235;
										case 499:
											if (num41 > 0)
											{
												goto case 680;
											}
											goto case 363;
										case 363:
											num40 |= array19[^(1 + num41)];
											num3 = 328;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 441;
										case 441:
											num41++;
											goto case 235;
										case 235:
										case 430:
											if (num41 >= num37)
											{
												goto case 154;
											}
											goto case 499;
										case 626:
											num42 = 0u;
											goto case 699;
										case 634:
											array9 = array2;
											num3 = 554;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 633:
											array4[5] = 139;
											num3 = 0;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 631:
											if (num37 > 0)
											{
												goto case 174;
											}
											goto case 482;
										case 174:
											num38 += num39;
											goto case 382;
										case 382:
											num40 = 0u;
											goto case 264;
										case 264:
											num41 = 0;
											num3 = 430;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 482:
											num42 = (uint)num18;
											num = 140;
											goto case 140;
										case 140:
											num38 += num39;
											goto case 613;
										case 613:
											num40 = (uint)((array19[num42 + 3] << 24) | (array19[num42 + 2] << 16) | (array19[num42 + 1] << 8) | array19[num42]);
											num3 = 644;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 630:
											array4[11] = (byte)num4;
											num3 = 679;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 629:
											array4[28] = 131;
											num3 = 108;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 628;
										case 628:
											num6 = 106;
											goto case 687;
										case 627:
											LG36xEd7ubVfYU1Gt0(object_2);
											num3 = 371;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 457;
										case 457:
											num32 = Iuo7Onpe8Wxmkcbqq1(object_2);
											num3 = 685;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 625:
											num4 = 67;
											num = 72;
											goto case 72;
										case 72:
											array4[26] = (byte)num4;
											num3 = 573;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 277;
										case 622:
											num6 = 100;
											goto case 531;
										case 531:
											array4[18] = (byte)num6;
											num = 542;
											goto case 542;
										case 542:
											num6 = 156;
											goto case 569;
										case 569:
											array4[18] = (byte)num6;
											goto case 414;
										case 414:
											array4[18] = 146;
											goto case 77;
										case 77:
											array4[18] = 85;
											goto case 503;
										case 503:
											array4[19] = 117;
											num3 = 556;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 617:
											num6 = 145;
											goto case 289;
										case 289:
											array4[11] = (byte)num6;
											goto case 387;
										case 387:
											array4[12] = 85;
											num = 278;
											goto case 278;
										case 278:
											array4[12] = 168;
											goto case 559;
										case 559:
											array4[12] = 165;
											num3 = 347;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 616:
											Gr3tuxv1KVbCXrOC5wF(rjRe5svWdF7rKS2QFfP(Hy9Pmgvf4eXW2dJhKG1(rNZkehfwNu)));
											num3 = 38;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 615:
											array9[13] = array10[6];
											goto case 169;
										case 169:
											array9[15] = array10[7];
											goto case 119;
										case 119:
											JAZe0xADYFLLoZwkVd(array10, 0, array10.Length);
											num = 180;
											goto case 101;
										case 101:
										case 180:
											num10 = 0;
											goto case 200;
										case 200:
										case 319:
											if (num10 < array9.Length)
											{
												goto case 114;
											}
											num3 = 264;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 286;
										case 286:
											array19 = array18;
											goto case 575;
										case 575:
											num37 = array19.Length % 4;
											num = 144;
											goto case 144;
										case 144:
											num23 = array19.Length / 4;
											goto case 348;
										case 348:
											array13 = new byte[array19.Length];
											goto case 43;
										case 43:
											num35 = array17.Length / 4;
											goto case 155;
										case 155:
											num38 = 0u;
											goto case 17;
										case 17:
											num39 = 0u;
											goto case 635;
										case 614:
											array2[9] = 168;
											num3 = 283;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 288;
										case 288:
											array2[9] = 57;
											num = 695;
											goto case 695;
										case 612:
											array4[13] = 168;
											goto case 683;
										case 611:
											num6 = 150;
											num3 = 253;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 609:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												goto case 507;
											}
											goto case 527;
										case 507:
											mTfoQqVbOE(intptr_2, intPtr, (byte[])iEk9VAQa23t2IMOZLf(Iuo7Onpe8Wxmkcbqq1(object_2)), 4u, out intptr_6);
											goto case 231;
										case 527:
											mTfoQqVbOE(intptr_2, intPtr, (byte[])iEk9VAQa23t2IMOZLf(Iuo7Onpe8Wxmkcbqq1(object_2)), 4u, out intptr_6);
											goto case 231;
										case 608:
											array2[8] = 117;
											goto case 15;
										case 15:
											num5 = 193;
											goto case 543;
										case 543:
											array2[9] = (byte)num5;
											num3 = 145;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 518;
										case 518:
											array2[9] = 153;
											goto case 592;
										case 592:
											array2[9] = 112;
											num3 = 268;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 606:
											value = ge0KN8vkOsWG9SgWvAT(intptr_5);
											goto case 85;
										case 605:
											array4[25] = (byte)num4;
											num = 284;
											goto case 284;
										case 284:
											num4 = 151;
											num3 = 229;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 604:
											XtMknffM5M = intPtr4.ToInt32();
											num = 571;
											goto case 571;
										case 571:
											intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(x4Dk2IHVmX))[0]);
											goto case 603;
										case 603:
											URnkCOceLK = intPtr4.ToInt64();
											goto case 564;
										case 564:
											intptr_6 = IntPtr.Zero;
											num = 566;
											goto case 566;
										case 566:
											num20 = 0;
											num3 = 14;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 602:
											num5 = 29;
											goto case 216;
										case 216:
											array2[1] = (byte)num5;
											goto case 179;
										case 179:
											array2[1] = 95;
											num3 = 100;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 88;
										case 88:
											array2[14] = 96;
											goto case 244;
										case 244:
											num5 = 137;
											num3 = 378;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 601:
											array4[10] = (byte)num4;
											goto case 314;
										case 314:
											array4[10] = 77;
											num3 = 330;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 221;
										case 221:
											array2[11] = (byte)num5;
											goto case 128;
										case 128:
											array2[11] = 92;
											goto case 110;
										case 110:
											array2[11] = 245;
											goto case 115;
										case 115:
											num5 = 134;
											goto case 526;
										case 526:
											array2[12] = (byte)num5;
											goto case 5;
										case 5:
											array2[12] = 109;
											goto case 275;
										case 275:
											num5 = 111;
											num3 = 27;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 13;
										case 13:
											intptr_ = LoadLibrary(text);
											goto case 76;
										case 76:
										case 486:
											array12 = new byte[6];
											num = 273;
											goto case 273;
										case 273:
											array12[0] = 103;
											num3 = 364;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 599:
											array4[7] = (byte)num4;
											goto case 201;
										case 201:
											array4[8] = 93;
											num3 = 159;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 598:
											IbMqPdBO53HK0us9pI(HuHxx4nJ83h1bSJXOG(object_2), 0L);
											goto case 192;
										case 192:
											array18 = (byte[])W0tB3fmF9aixUx94Wn(object_2, (int)Vd88xJYKwFGj5uKiAe(HuHxx4nJ83h1bSJXOG(object_2)));
											num3 = 113;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 148;
										case 148:
											array4 = new byte[32];
											num3 = 147;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 597:
											num5 = 149;
											num3 = 96;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 274;
										case 595:
											num5 = 150;
											goto case 523;
										case 523:
											array2[6] = (byte)num5;
											num3 = 53;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 593:
											num6 = 113;
											goto case 258;
										case 258:
											array4[10] = (byte)num6;
											goto case 248;
										case 248:
											array4[10] = 202;
											goto case 141;
										case 141:
											num4 = 137;
											num = 692;
											goto case 692;
										case 591:
											num6 = 66;
											goto case 291;
										case 291:
											array4[16] = (byte)num6;
											num3 = 358;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 248;
										case 590:
											if (((Array)mlYILKv95g53nR8ca6J(foiAigvMM7wCOoJ1Pc8(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).Length != 2)
											{
												goto case 638;
											}
											goto case 11;
										case 11:
											if (uHAIjKrO4Hf6eUoVMo(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly) == null)
											{
												num3 = 657;
												if (PsfwYibARbKayXDITm() == null)
												{
													continue;
												}
												break;
											}
											goto case 139;
										case 139:
											if (S88qBA7ZZJdCL7GTIm(uHAIjKrO4Hf6eUoVMo(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)) <= 0)
											{
												goto case 638;
											}
											goto case 251;
										case 251:
											RKPutnyZ1ld0gp3H7Z();
											num3 = 344;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 90;
										case 589:
											num6 = 147;
											goto case 310;
										case 310:
											array4[26] = (byte)num6;
											num3 = 407;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 587:
											num4 = 244;
											goto case 599;
										case 586:
											num6 = 176;
											goto case 549;
										case 549:
											array4[28] = (byte)num6;
											goto case 629;
										case 584:
											array4[0] = 235;
											goto case 408;
										case 408:
											num6 = 129;
											num3 = 163;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 234;
										case 234:
											array4[1] = (byte)num6;
											goto case 131;
										case 131:
											num4 = 175;
											num3 = 445;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 583:
											array = new byte[10];
											goto case 393;
										case 393:
											array[0] = 99;
											num = 539;
											goto case 539;
										case 539:
											array[1] = 108;
											num3 = 468;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 581:
											array4[13] = 106;
											num3 = 125;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 239;
										case 239:
											num4 = 130;
											num3 = 493;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 580:
											array10 = (byte[])JukMcpOJhkrWqd5w1w(UajfJdw2Mgh8VeD29i(x4Dk2IHVmX));
											goto case 479;
										case 479:
											if (array10 == null)
											{
												goto case 101;
											}
											goto case 307;
										case 307:
											if (array10.Length <= 0)
											{
												goto case 101;
											}
											goto case 368;
										case 368:
											array9[1] = array10[0];
											goto case 532;
										case 532:
											array9[3] = array10[1];
											goto case 246;
										case 246:
											array9[5] = array10[2];
											goto case 301;
										case 301:
											array9[7] = array10[3];
											num3 = 170;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 579:
											intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(x4Dk2IHVmX))[0]);
											goto case 604;
										case 578:
											array2[8] = (byte)num5;
											num = 608;
											goto case 608;
										case 577:
											num34++;
											num3 = 647;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 576:
											array2[0] = 59;
											goto case 349;
										case 349:
											array2[1] = 175;
											num3 = 427;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 574:
											array7[num9 + 3] = array5[3];
											num3 = 193;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 573:
											num4 = 130;
											goto case 39;
										case 572:
											array4[24] = (byte)num4;
											num3 = 565;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 389:
										case 570:
											if (JS1MGkzc9J9wAiqxE4(HuHxx4nJ83h1bSJXOG(object_2)) < Vd88xJYKwFGj5uKiAe(HuHxx4nJ83h1bSJXOG(object_2)) - 1L)
											{
												num = 472;
												goto case 472;
											}
											goto case 142;
										case 472:
											num33 = Iuo7Onpe8Wxmkcbqq1(object_2);
											num3 = 691;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 568:
											num5 = 148;
											goto case 529;
										case 529:
											array2[11] = (byte)num5;
											goto case 176;
										case 176:
											array2[11] = 170;
											goto case 106;
										case 106:
											num5 = 145;
											goto case 221;
										case 567:
											array2[2] = (byte)num5;
											num3 = 279;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 565:
											num4 = 121;
											num3 = 19;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 28;
										case 28:
											array4[25] = (byte)num4;
											num3 = 462;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 563:
											num6 = 19;
											goto case 655;
										case 562:
											flag = AyfBTqfiQdaUA6JeXl(RsXJCxxWf3Kl90R6J5(P9E3JeMbivWI7BNYgN(cyAvcLGO1F6V544d5w(RlEepR6Ul0aEhb1wdK())), "__", 10u), IntPtr.Zero);
											goto case 476;
										case 476:
											if (flag)
											{
												goto case 665;
											}
											goto case 466;
										case 466:
											RKPutnyZ1ld0gp3H7Z();
											num3 = 243;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 560:
											array12[4] = 105;
											num3 = 197;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 557:
											array7[num15 + 6] = array11[6];
											num = 71;
											goto case 71;
										case 71:
											array7[num15 + 7] = array11[7];
											goto case 184;
										case 184:
											num15 = 30;
											goto case 674;
										case 556:
											num4 = 106;
											num = 138;
											goto case 138;
										case 138:
											array4[19] = (byte)num4;
											num3 = 318;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 555:
											procAddress = GetProcAddress(intptr_, string_);
											num3 = 8;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 31;
										case 31:
											object_9 = (OFfwWh6ZIHjfnqBOWx)HTUe0wvNPAcvIaonZBp(procAddress, eExcg9vJmltHggheFp3(typeof(OFfwWh6ZIHjfnqBOWx).TypeHandle));
											goto case 412;
										case 412:
											intptr_5 = RsKgNtvXnhiuittWgbI(object_9);
											goto case 33;
										case 33:
											value = 0L;
											goto case 98;
										case 98:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												num3 = 606;
												if (PsfwYibARbKayXDITm() == null)
												{
													continue;
												}
												break;
											}
											goto case 399;
										case 399:
											value = Pnr23EvEYIIPdwulJk0(intptr_5);
											goto case 85;
										case 554:
											IVIY1AhrVOp6WyhexY(array9);
											num3 = 580;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 89;
										case 89:
											if (num29 < 1879048192)
											{
												goto case 653;
											}
											goto case 354;
										case 354:
											jDNkifbo3S = true;
											num = 653;
											goto case 653;
										case 552:
											num5 = 63;
											num3 = 66;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 418;
										case 418:
											array2[5] = (byte)num5;
											goto case 595;
										case 551:
											array4[24] = (byte)num6;
											goto case 434;
										case 434:
											num6 = 130;
											num3 = 143;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 548:
											RbVLmKZVBn7PqKKeeY(object_3, CipherMode.CBC);
											goto case 261;
										case 261:
											transform = (ICryptoTransform)QgFX6u8tARgbBxM4n4(object_3, array17, array9);
											goto case 158;
										case 158:
											JAZe0xADYFLLoZwkVd(array17, 0, array17.Length);
											goto case 82;
										case 82:
											memoryStream = new MemoryStream();
											goto case 175;
										case 175:
											object_8 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
											goto case 250;
										case 250:
											DunnU3tP2mNprIipAn(object_8, array18, 0, array18.Length);
											num3 = 668;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 547:
											array4[29] = (byte)num6;
											goto case 460;
										case 460:
											num4 = 245;
											num3 = 24;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 419;
										case 419:
											array4[29] = (byte)num4;
											num3 = 302;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 65:
										case 545:
											num22++;
											num3 = 86;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 541:
											num7 = 0L;
											num3 = 49;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 540:
											array2[4] = (byte)num5;
											num3 = 17;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 161;
										case 161:
											num5 = 123;
											goto case 252;
										case 252:
											array2[5] = (byte)num5;
											num = 504;
											goto case 504;
										case 504:
											array2[5] = 144;
											num3 = 381;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 552;
										case 538:
											array4[4] = 100;
											goto case 641;
										case 537:
											array7[num9 + 2] = array11[2];
											goto case 388;
										case 388:
											array7[num9 + 3] = array11[3];
											num3 = 506;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 536:
											array[3] = 111;
											num3 = 480;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 535:
											num4 = 180;
											num = 81;
											goto case 81;
										case 81:
											array4[2] = (byte)num4;
											goto case 304;
										case 304:
											array4[2] = 150;
											num3 = 489;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 533:
											dnTFuIE1c6GhmSar5d();
											num3 = 376;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 14:
										case 530:
											if (num20 >= num32)
											{
												num3 = 570;
												if (cnwib5vMRnDuwHuQHW())
												{
													continue;
												}
												break;
											}
											goto case 667;
										case 528:
											array2[15] = 104;
											num = 410;
											goto case 410;
										case 410:
											array2[15] = 75;
											num3 = 456;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 86;
										case 524:
											array2[15] = (byte)num5;
											num3 = 96;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 522:
											num6 = 132;
											num3 = 477;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 425;
										case 425:
											array4[11] = 87;
											goto case 205;
										case 205:
											num4 = 104;
											num3 = 630;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 521:
											array4[0] = (byte)num4;
											goto case 584;
										case 520:
											array4[31] = 91;
											goto case 67;
										case 67:
											array17 = array4;
											goto case 351;
										case 351:
											array2 = new byte[16];
											num = 461;
											goto case 461;
										case 461:
											num5 = 105;
											goto case 401;
										case 401:
											array2[0] = (byte)num5;
											num3 = 227;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 519:
											YeeoMqaS3J(intptr_4, num21 * 4, 4, ref int_2);
											num = 676;
											goto case 676;
										case 516:
											if (array6.Length != 0)
											{
												num3 = 25;
												if (!cnwib5vMRnDuwHuQHW())
												{
													continue;
												}
												goto IL_33cc;
											}
											goto end_IL_33cc;
										case 182:
										case 306:
											goto IL_33cc;
										case 281:
										case 470:
											goto end_IL_33cc;
										case 459:
										case 478:
											num14 = 0;
											num3 = 287;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 404;
										case 404:
										case 443:
											if (num14 >= num30)
											{
												goto end_IL_002f;
											}
											goto case 59;
										case 59:
											num31 = (nint)(ptr + (nint)num14 * (nint)8);
											*(long*)num31 ^= 342397456L;
											num3 = 214;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 169;
										case 514:
											array2[2] = 162;
											num3 = 650;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 512:
											jDNkifbo3S = false;
											goto case 263;
										case 263:
										case 359:
											if (JS1MGkzc9J9wAiqxE4(HuHxx4nJ83h1bSJXOG(object_2)) < Vd88xJYKwFGj5uKiAe(HuHxx4nJ83h1bSJXOG(object_2)) - 1L)
											{
												goto case 54;
											}
											goto case 372;
										case 54:
											num13 = Iuo7Onpe8Wxmkcbqq1(object_2) - num28;
											goto case 299;
										case 299:
											num29 = Iuo7Onpe8Wxmkcbqq1(object_2);
											num3 = 5;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 44;
										case 44:
											jDNkifbo3S = false;
											goto case 89;
										case 372:
											intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))[0]);
											goto case 7;
										case 7:
											eXJkjmTXDX = intPtr4.ToInt64();
											goto case 416;
										case 416:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												num3 = 452;
												if (cnwib5vMRnDuwHuQHW())
												{
													continue;
												}
												goto case 215;
											}
											goto case 107;
										case 107:
											array = new byte[12];
											num3 = 23;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 5;
										case 511:
											num5 = 156;
											num3 = 189;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 510:
											try
											{
												while (l5DauXK3JZLhJMEyVn(enumerator))
												{
													while (true)
													{
														IL_3649:
														ProcessModule object_4 = (ProcessModule)SpecVgcCHhCjLNxNT2(enumerator);
														while (AEnLDv18ZTuoKbb5wM(HgGeVvWEULHvj4hhxj(u8JRrRoicD0sGpHK09(object_4)), "clrjit.dll"))
														{
															while (true)
															{
																IL_35e6:
																Version object_5 = new Version(s151lolBNOsNCAgDkP(sn79l9C1LsgMntbBWk(object_4)), RHWxcGjLysgN9cOlVt(sn79l9C1LsgMntbBWk(object_4)), NXCeOH2XnbNTNYRHWX(sn79l9C1LsgMntbBWk(object_4)), z8NIrHFcpe6L7SjKyL(sn79l9C1LsgMntbBWk(object_4)));
																num24 = 0;
																if (PsfwYibARbKayXDITm() != null)
																{
																	goto IL_3589;
																}
																goto IL_35ab;
																IL_35ab:
																while (true)
																{
																	switch (num24)
																	{
																	case 9:
																		object_7 = new Version(4, 0, 30319, 17921);
																		num24 = 8;
																		if (cnwib5vMRnDuwHuQHW())
																		{
																			continue;
																		}
																		goto IL_3558;
																	case 8:
																		if (!VfOsHg58Xg4FqG3wCW(object_5, object_6))
																		{
																			goto end_IL_362f;
																		}
																		goto case 7;
																	case 7:
																		if (!ywwLwIUtLmSfmQ3uqY(object_5, object_7))
																		{
																			num24 = 6;
																			if (cnwib5vMRnDuwHuQHW())
																			{
																				continue;
																			}
																			goto IL_3558;
																		}
																		goto IL_3665;
																	case 12:
																		goto IL_35e6;
																	case 10:
																		goto end_IL_35e6;
																	case 2:
																		goto IL_3649;
																	case 4:
																	case 5:
																	case 6:
																		goto end_IL_362f;
																	case 1:
																		goto IL_3665;
																	case 3:
																	case 11:
																		goto end_IL_3659;
																		IL_3558:
																		num24 = num25;
																		continue;
																	}
																	break;
																}
																goto IL_3589;
																IL_3589:
																object_6 = new Version(4, 0, 30319, 17020);
																num24 = 9;
																if (PsfwYibARbKayXDITm() == null)
																{
																	goto IL_35ab;
																}
																goto IL_3665;
																IL_3665:
																PRZkZqsNsa = true;
																num25 = 11;
																goto end_IL_3659;
																continue;
																end_IL_35e6:
																break;
															}
															continue;
															end_IL_362f:
															break;
														}
														break;
													}
													continue;
													end_IL_3659:
													break;
												}
											}
											finally
											{
												IDisposable disposable = enumerator as IDisposable;
												num26 = 1;
												if (PsfwYibARbKayXDITm() != null)
												{
													goto IL_36a5;
												}
												goto IL_36be;
												IL_36be:
												while (true)
												{
													switch (num26)
													{
													case 3:
														OcB3D1aSiX4yvSrrNs(disposable);
														num26 = 0;
														if (PsfwYibARbKayXDITm() == null)
														{
															continue;
														}
														break;
													case 1:
														if (disposable == null)
														{
															num26 = 2;
															if (PsfwYibARbKayXDITm() == null)
															{
																continue;
															}
															break;
														}
														goto case 3;
													default:
														goto end_IL_36be;
													}
													goto IL_36a5;
													continue;
													end_IL_36be:
													break;
												}
												goto end_IL_3679;
												IL_36a5:
												num26 = num27;
												goto IL_36be;
												end_IL_3679:;
											}
											goto case 16;
										case 506:
											num9 = 23;
											goto case 398;
										case 398:
											array7[num9] = array5[0];
											goto case 471;
										case 471:
											array7[num9 + 1] = array5[1];
											goto case 420;
										case 420:
											array7[num9 + 2] = array5[2];
											num3 = 574;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 505:
											array4[20] = 68;
											num = 133;
											goto case 133;
										case 133:
											array4[21] = 168;
											goto case 379;
										case 379:
											num6 = 94;
											num3 = 400;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 501:
											array2[2] = 124;
											num3 = 488;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 500:
											array4[20] = (byte)num4;
											goto case 312;
										case 312:
											num4 = 95;
											goto case 3;
										case 3:
											array4[20] = (byte)num4;
											num = 505;
											goto case 505;
										case 497:
											array2[12] = 150;
											num3 = 22;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 693;
										case 496:
											array4[31] = 149;
											goto case 520;
										case 494:
											num4 = 142;
											goto case 257;
										case 257:
											array4[23] = (byte)num4;
											goto case 651;
										case 493:
											array4[14] = (byte)num4;
											goto case 437;
										case 437:
											array4[14] = 94;
											num3 = 12;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 136;
										case 136:
											num4 = 75;
											goto case 649;
										case 490:
											intPtr2 = EF8xwDv62j7mMLyuN0p(rNZkehfwNu);
											num3 = 541;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 489:
											num4 = 48;
											goto case 421;
										case 421:
											array4[2] = (byte)num4;
											num3 = 375;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 488:
											num5 = 10;
											num3 = 567;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 487:
											array[4] = 105;
											num3 = 51;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 484:
											YeeoMqaS3J(intptr_3, 4, int_2, ref int_2);
											num = 577;
											goto case 577;
										case 481:
											array4[28] = 104;
											goto case 311;
										case 311:
											num6 = 106;
											goto case 320;
										case 320:
											array4[28] = (byte)num6;
											num3 = 586;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 480:
											array[4] = 114;
											num = 411;
											goto case 411;
										case 411:
											array[5] = 106;
											num = 262;
											goto case 262;
										case 262:
											array[6] = 105;
											goto case 438;
										case 438:
											array[7] = 116;
											goto case 241;
										case 241:
											array[8] = 46;
											goto case 694;
										case 477:
											array4[7] = (byte)num6;
											goto case 340;
										case 340:
											array4[7] = 158;
											goto case 255;
										case 255:
											array4[7] = 83;
											goto case 587;
										case 475:
											array16 = new byte[40];
											h7hAE7vCXPBh5lF0GOV(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
											array3 = array16;
											num3 = 395;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 474:
											CwIXyivo1EmpV0ysNqL(rNZkehfwNu);
											goto case 616;
										case 469:
											array7[num15 + 4] = array8[4];
											num = 678;
											goto case 678;
										case 468:
											array[2] = 114;
											num3 = 130;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 249;
										case 249:
											array[3] = 106;
											goto case 487;
										case 467:
											array2[10] = (byte)num5;
											goto case 568;
										case 465:
											array4[23] = 128;
											goto case 494;
										case 464:
											num4 = 93;
											num = 297;
											goto case 297;
										case 297:
											array4[18] = (byte)num4;
											num = 622;
											goto case 622;
										case 463:
											PRvHE6k6bN6cQqTYut(array6, 0, SeAdswXtVsYUd5oKM9(8), 1);
											goto case 533;
										case 462:
											num6 = 112;
											num3 = 317;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 456:
											num5 = 104;
											goto case 524;
										case 453:
											array2[10] = 161;
											num = 75;
											goto case 75;
										case 75:
											num5 = 36;
											goto case 467;
										case 452:
											wpoklx4RIX = HPrO0MvTd8MUVO2iftT(eXJkjmTXDX);
											num3 = 107;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 63;
										case 451:
											array4[27] = 121;
											num3 = 481;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 162;
										case 450:
											rNZkehfwNu = NvQ34uZt895nxEhi2FIr;
											num3 = 119;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 166;
										case 166:
											intPtr2 = IntPtr.Zero;
											goto case 490;
										case 448:
											array12[2] = 116;
											num3 = 191;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 145;
										case 145:
											if (T8HYV799DYUL4uCJUx() != 4)
											{
												goto case 571;
											}
											goto case 579;
										case 446:
											array4[0] = 113;
											num3 = 319;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 654;
										case 445:
											array4[1] = (byte)num4;
											num = 215;
											goto case 215;
										case 444:
											YeeoMqaS3J(new IntPtr(value), T8HYV799DYUL4uCJUx(), int_, ref int_);
											num3 = 142;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 212;
										case 440:
											array4[4] = 97;
											goto case 178;
										case 178:
											num6 = 119;
											goto case 122;
										case 122:
											array4[4] = (byte)num6;
											goto case 113;
										case 113:
											num6 = 138;
											num3 = 58;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 10;
										case 10:
											array2[0] = (byte)num5;
											goto case 576;
										case 436:
											if (num22 == num23 - 1)
											{
												goto case 631;
											}
											goto case 482;
										case 433:
											array2[1] = (byte)num5;
											goto case 602;
										case 431:
											array4[13] = 93;
											num = 171;
											goto case 171;
										case 171:
											num6 = 123;
											goto case 18;
										case 18:
											array4[13] = (byte)num6;
											num3 = 611;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 429:
											array4[3] = 135;
											goto case 648;
										case 428:
											array7[num15 + 2] = array11[2];
											goto case 238;
										case 238:
											array7[num15 + 3] = array11[3];
											num3 = 390;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 427:
											num5 = 166;
											goto case 433;
										case 426:
											array[8] = 108;
											num3 = 270;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 424:
											array4[22] = (byte)num6;
											goto case 137;
										case 137:
											num4 = 59;
											goto case 116;
										case 116:
											array4[22] = (byte)num4;
											num3 = 325;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 172;
										case 172:
											array2[3] = (byte)num5;
											num = 108;
											goto case 108;
										case 108:
											num5 = 144;
											goto case 228;
										case 228:
											array2[3] = (byte)num5;
											goto case 662;
										case 417:
											array4[29] = 106;
											num3 = 20;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 36;
										case 36:
											array4[29] = 99;
											goto case 240;
										case 240:
											array4[29] = 163;
											goto case 380;
										case 380:
											num6 = 102;
											num3 = 547;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 285;
										case 407:
											array4[26] = 151;
											num3 = 124;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 405:
											array4[11] = (byte)num6;
											goto case 150;
										case 150:
											array4[11] = 148;
											goto case 425;
										case 402:
											string_ = (string)Td1ATdvqFhFtIHvr48J(JLXqf5vRx2aaqd89sBE(), array12);
											num3 = 336;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 555;
										case 400:
											array4[21] = (byte)num6;
											num = 328;
											goto case 328;
										case 328:
											num4 = 74;
											num3 = 677;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 396:
											Gr3tuxv1KVbCXrOC5wF(rjRe5svWdF7rKS2QFfP(Hy9Pmgvf4eXW2dJhKG1(abxkLGOVrU)));
											goto case 474;
										case 394:
											num6 = 231;
											num3 = 111;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 392:
											object_3 = (SymmetricAlgorithm)Ansf3d3FKg6dfEROda();
											num3 = 548;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 390:
											array7[num15 + 4] = array11[4];
											num3 = 247;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 385:
											num21 = Iuo7Onpe8Wxmkcbqq1(object_2);
											num3 = 519;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 457;
										case 383:
											array2[9] = (byte)num5;
											num3 = 540;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 614;
										case 381:
											num20++;
											num3 = 136;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 14;
										case 378:
											array2[14] = (byte)num5;
											goto case 4;
										case 4:
											num5 = 201;
											num3 = 315;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 376:
											if (num2 == 4109628145u)
											{
												num3 = 562;
												if (PsfwYibARbKayXDITm() == null)
												{
													continue;
												}
												break;
											}
											goto case 665;
										case 375:
											array4[2] = 158;
											num3 = 429;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 374:
											array4[9] = (byte)num6;
											num3 = 303;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 370:
											num6 = 53;
											goto case 670;
										case 369:
											num4 = 66;
											goto case 601;
										case 366:
											UcnBqdN8BVuNtVsOBe(new IntPtr(&num8), 0, 0L);
											goto case 362;
										case 362:
											array6 = new byte[1];
											num = 463;
											goto case 463;
										case 364:
											array12[1] = 101;
											goto case 448;
										case 361:
											array4[10] = (byte)num6;
											goto case 672;
										case 358:
											array4[16] = 178;
											num3 = 196;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 357:
											array4[8] = (byte)num6;
											num = 217;
											goto case 217;
										case 217:
											num4 = 91;
											goto case 165;
										case 165:
											array4[8] = (byte)num4;
											goto case 671;
										case 355:
											array15 = (array6 = array14);
											if (array15 == null)
											{
												num3 = 470;
												if (PsfwYibARbKayXDITm() == null)
												{
													continue;
												}
												break;
											}
											goto case 516;
										case 353:
											array4[12] = (byte)num6;
											num3 = 431;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 350:
											num6 = 140;
											goto case 551;
										case 347:
											num6 = 98;
											goto case 353;
										case 346:
											array2[2] = (byte)num5;
											goto case 501;
										case 341:
											bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
											num3 = 126;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 338:
											array2[14] = 136;
											goto case 88;
										case 337:
											text = (string)Td1ATdvqFhFtIHvr48J(JLXqf5vRx2aaqd89sBE(), array);
											num3 = 13;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 336:
											array[1] = 115;
											goto case 689;
										case 335:
											array2[4] = 65;
											num3 = 511;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 28;
										case 332:
											intptr_2 = BSsrVXH9ksT1AeTW3s((uint)uint_, 1, (uint)imi2QVeQVWyZuJX57V(RlEepR6Ul0aEhb1wdK()));
											num3 = 48;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 145;
										case 331:
											array7[num15 + 2] = array8[2];
											num3 = 290;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 330:
											num6 = 191;
											goto case 361;
										case 329:
											array4[4] = 42;
											num = 538;
											goto case 538;
										case 325:
											array4[22] = 0;
											goto case 465;
										case 324:
											array4[16] = (byte)num6;
											goto case 199;
										case 199:
											num6 = 100;
											num = 194;
											goto case 194;
										case 194:
											array4[16] = (byte)num6;
											num3 = 591;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 465;
										case 322:
											array13[num18 + 2] = (byte)((num19 & 0xFF0000) >> 16);
											num3 = 119;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 153;
										case 153:
											array13[num18 + 3] = (byte)((num19 & 0xFF000000u) >> 24);
											goto case 65;
										case 321:
											array4[21] = 174;
											goto case 69;
										case 69:
											array4[21] = 122;
											num = 563;
											goto case 563;
										case 318:
											array4[19] = 96;
											num3 = 10;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 21;
										case 21:
											num4 = 134;
											num3 = 305;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 315:
											array2[14] = (byte)num5;
											goto case 528;
										case 305:
											array4[19] = (byte)num4;
											num3 = 173;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 303:
											array4[9] = 84;
											goto case 593;
										case 302:
											array4[30] = 118;
											goto case 669;
										case 295:
											num5 = 227;
											goto case 540;
										case 294:
											H4ap1qvbt71iA0wPPnS(lmdkVksVkh, 0L, bIpvxRBRb2dOGl802m2);
											goto case 512;
										case 293:
											array4[23] = (byte)num4;
											num3 = 350;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 272;
										case 272:
											num17 = 255u;
											num3 = 202;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 292:
											oSsY2hsoKyveAgZRk3(new IntPtr(&num8), 0, 0);
											num3 = 366;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 290:
											array7[num15 + 3] = array8[3];
											goto case 469;
										case 279:
											array2[3] = 68;
											num3 = 47;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 271:
											bIpvxRBRb2dOGl802m.JDNkifbo3S = jDNkifbo3S;
											num3 = 209;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 270:
											array[9] = 108;
											num3 = 337;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 268:
											num5 = 95;
											goto case 383;
										case 267:
											num4 = 131;
											num = 521;
											goto case 521;
										case 266:
											if (num16 != 4)
											{
												goto case 219;
											}
											goto case 392;
										case 259:
											if (!E987FNvsWuJEWT0KwyI(intptr_, IntPtr.Zero))
											{
												goto case 76;
											}
											goto case 583;
										case 253:
											array4[13] = (byte)num6;
											goto case 612;
										case 247:
											array7[num15 + 5] = array11[5];
											goto case 557;
										case 237:
											array4[3] = (byte)num4;
											num3 = 210;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 236:
											array4[15] = (byte)num6;
											num3 = 697;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 47;
										case 47:
											num5 = 108;
											goto case 172;
										case 233:
											array11 = (byte[])uhrG7DvcRwZPmrZdGRP(num7);
											goto case 309;
										case 229:
											array4[25] = (byte)num4;
											goto case 93;
										case 93:
											num6 = 192;
											num3 = 70;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 50;
										case 227:
											num5 = 144;
											num3 = 10;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 223:
											array[6] = 46;
											goto case 2;
										case 2:
											array[7] = 100;
											goto case 426;
										case 214:
											num14++;
											num = 443;
											goto case 404;
										case 210:
											num6 = 42;
											num = 40;
											goto case 40;
										case 40:
											array4[3] = (byte)num6;
											num3 = 440;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 209:
											H4ap1qvbt71iA0wPPnS(lmdkVksVkh, num12 + num13, bIpvxRBRb2dOGl802m);
											num3 = 110;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 263;
										case 204:
											num6 = 151;
											num = 424;
											goto case 424;
										case 202:
											num11 = 0;
											goto case 436;
										case 198:
											num10++;
											num3 = 319;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 197:
											array12[5] = 116;
											num3 = 402;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 361;
										case 196:
											array4[17] = 126;
											goto case 12;
										case 12:
											array4[17] = 130;
											goto case 394;
										case 191:
											array12[3] = 74;
											goto case 560;
										case 190:
											YeeoMqaS3J(new IntPtr(value), T8HYV799DYUL4uCJUx(), 64, ref int_);
											goto case 74;
										case 74:
											PTG8q9vjrDfaQyKxHGJ(new IntPtr(value), intPtr3);
											goto case 444;
										case 189:
											array2[4] = (byte)num5;
											goto case 295;
										case 188:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												goto case 87;
											}
											num3 = 475;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 199;
										case 187:
											array4[15] = 100;
											goto case 640;
										case 185:
											array7[num9 + 1] = array11[1];
											num3 = 537;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 384;
										case 173:
											num4 = 190;
											goto case 500;
										case 170:
											array9[9] = array10[4];
											goto case 6;
										case 6:
											array9[11] = array10[5];
											num3 = 615;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 163:
											array2[2] = (byte)num5;
											goto case 61;
										case 61:
											array2[2] = 116;
											goto case 514;
										case 160:
											array2[6] = 94;
											goto case 597;
										case 159:
											num6 = 155;
											goto case 357;
										case 157:
											num4 = 105;
											num = 605;
											goto case 605;
										case 149:
											bIpvxRBRb2dOGl802m2.JDNkifbo3S = false;
											num3 = 294;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										case 146:
											num6 = 155;
											goto case 324;
										case 143:
											array4[24] = (byte)num6;
											goto case 95;
										case 95:
											num4 = 205;
											goto case 572;
										case 134:
											array4[31] = (byte)num4;
											goto case 496;
										case 130:
											num6 = 89;
											num3 = 374;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 127:
											num9 = 9;
											goto case 123;
										case 123:
											array7[num9] = array8[0];
											goto case 675;
										case 126:
											reference = ref bIpvxRBRb2dOGl802m2;
											array6 = new byte[1] { 42 };
											reference.jsbkrdexts = array6;
											goto case 149;
										case 124:
											num6 = 162;
											goto case 29;
										case 29:
											array4[26] = (byte)num6;
											goto case 625;
										case 120:
											array4[18] = 32;
											goto case 464;
										case 111:
											array4[17] = (byte)num6;
											goto case 120;
										case 109:
											num6 = 241;
											goto case 661;
										case 102:
											num8 = 0L;
											goto case 56;
										case 56:
											ymo9V3JfkrBEwjVuTN(new IntPtr(&num8), 0);
											goto case 26;
										case 26:
											VfWCIVTwCdogtKA7bJ(new IntPtr(&num8), 0);
											num3 = 663;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 543;
										case 100:
											num5 = 120;
											goto case 163;
										case 99:
											array4[15] = (byte)num6;
											goto case 187;
										case 96:
											num5 = 94;
											num3 = 515;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 259;
										case 94:
											num7 = Pnr23EvEYIIPdwulJk0(new IntPtr(value));
											num = 690;
											goto case 50;
										case 92:
											array5 = (byte[])uhrG7DvcRwZPmrZdGRP(intPtr2.ToInt64());
											goto case 233;
										case 80:
											array4[0] = (byte)num4;
											num3 = 54;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 446;
										case 79:
											array4[5] = (byte)num6;
											goto case 633;
										case 73:
											YeeoMqaS3J(intPtr, 4, 4, ref int_2);
											num3 = 518;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 609;
										case 70:
											array4[26] = (byte)num6;
											goto case 589;
										case 68:
											bIpvxRBRb2dOGl802m.jsbkrdexts = jsbkrdexts;
											num3 = 271;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 81;
										case 60:
											array4[0] = (byte)num6;
											num3 = 7;
											if (!cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											goto case 45;
										case 45:
											num4 = 157;
											num3 = 80;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 58:
											array4[4] = (byte)num6;
											num = 329;
											goto case 329;
										case 55:
											array2[10] = (byte)num5;
											goto case 453;
										case 53:
											array2[6] = 115;
											num3 = 160;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 51:
											array[5] = 116;
											num3 = 223;
											if (cnwib5vMRnDuwHuQHW())
											{
												continue;
											}
											break;
										case 49:
											if (T8HYV799DYUL4uCJUx() == 4)
											{
												goto case 688;
											}
											goto case 94;
										case 38:
											array3 = null;
											goto case 188;
										case 34:
											if (!fxUQ1dvxhoIVa5wbxGn(foiAigvMM7wCOoJ1Pc8(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
											{
												goto case 638;
											}
											num3 = 132;
											if (PsfwYibARbKayXDITm() != null)
											{
												continue;
											}
											goto case 590;
										case 32:
											num6 = 84;
											goto case 99;
										case 27:
											array2[12] = (byte)num5;
											goto case 497;
										case 24:
											enumerator = (IEnumerator)tLhWr2gLT94ta57ay6(object_);
											num3 = 510;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											goto case 122;
										case 23:
											array[0] = 109;
											goto case 336;
										case 1:
											int_ = 0;
											goto case 34;
										default:
											num4 = 142;
											goto case 636;
										case 243:
											return;
										case 142:
											GCRyUTvvvNaOst612Tj(intptr_2);
											goto case 285;
										case 285:
											RKPutnyZ1ld0gp3H7Z();
											return;
										case 600:
											return;
										case 344:
											return;
										case 212:
											RKPutnyZ1ld0gp3H7Z();
											return;
										case 313:
											return;
										}
										goto IL_0b5b_2;
										continue;
										end_IL_002f:
										break;
									}
								}
								goto case 544;
								continue;
								end_IL_33cc:
								break;
							}
							goto case 281;
						case 281:
						case 470:
							reference3 = ref *(byte*)null;
							goto case 459;
						case 459:
						case 478:
							num14 = 0;
							num3 = 287;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 404;
						case 404:
						case 443:
							if (num14 >= num30)
							{
								goto case 544;
							}
							goto case 59;
						case 59:
							num31 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3) + (nint)num14 * (nint)8);
							*(long*)num31 ^= 342397456L;
							num3 = 214;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 169;
						case 514:
							array2[2] = 162;
							num3 = 650;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 512:
							jDNkifbo3S = false;
							goto case 263;
						case 263:
						case 359:
							if (JS1MGkzc9J9wAiqxE4(HuHxx4nJ83h1bSJXOG(object_2)) < Vd88xJYKwFGj5uKiAe(HuHxx4nJ83h1bSJXOG(object_2)) - 1L)
							{
								goto case 54;
							}
							goto case 372;
						case 54:
							num13 = Iuo7Onpe8Wxmkcbqq1(object_2) - num28;
							goto case 299;
						case 299:
							num29 = Iuo7Onpe8Wxmkcbqq1(object_2);
							num3 = 5;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 44;
						case 44:
							jDNkifbo3S = false;
							goto case 89;
						case 372:
							intPtr4 = YK06m34LGZhp3u1ghH(((object[])pYZ0M7IOwD6BCCYb9l(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))[0]);
							goto case 7;
						case 7:
							eXJkjmTXDX = intPtr4.ToInt64();
							goto case 416;
						case 416:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								num3 = 452;
								if (cnwib5vMRnDuwHuQHW())
								{
									continue;
								}
								goto case 215;
							}
							goto case 107;
						case 107:
							array = new byte[12];
							num3 = 23;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 5;
						case 511:
							num5 = 156;
							num3 = 189;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 510:
							try
							{
								while (l5DauXK3JZLhJMEyVn(enumerator))
								{
									while (true)
									{
										IL_3649_2:
										ProcessModule object_4 = (ProcessModule)SpecVgcCHhCjLNxNT2(enumerator);
										while (AEnLDv18ZTuoKbb5wM(HgGeVvWEULHvj4hhxj(u8JRrRoicD0sGpHK09(object_4)), "clrjit.dll"))
										{
											while (true)
											{
												IL_35e6_2:
												Version object_5 = new Version(s151lolBNOsNCAgDkP(sn79l9C1LsgMntbBWk(object_4)), RHWxcGjLysgN9cOlVt(sn79l9C1LsgMntbBWk(object_4)), NXCeOH2XnbNTNYRHWX(sn79l9C1LsgMntbBWk(object_4)), z8NIrHFcpe6L7SjKyL(sn79l9C1LsgMntbBWk(object_4)));
												num24 = 0;
												if (PsfwYibARbKayXDITm() != null)
												{
													goto IL_3589_2;
												}
												goto IL_35ab_3;
												IL_35ab_3:
												while (true)
												{
													switch (num24)
													{
													case 9:
														object_7 = new Version(4, 0, 30319, 17921);
														num24 = 8;
														if (cnwib5vMRnDuwHuQHW())
														{
															continue;
														}
														goto IL_3558_2;
													case 8:
														if (!VfOsHg58Xg4FqG3wCW(object_5, object_6))
														{
															goto end_IL_362f_2;
														}
														goto case 7;
													case 7:
														if (!ywwLwIUtLmSfmQ3uqY(object_5, object_7))
														{
															num24 = 6;
															if (cnwib5vMRnDuwHuQHW())
															{
																continue;
															}
															goto IL_3558_2;
														}
														goto IL_3665_2;
													case 12:
														goto IL_35e6_2;
													case 10:
														goto end_IL_35e6_2;
													case 2:
														goto IL_3649_2;
													case 4:
													case 5:
													case 6:
														goto end_IL_362f_2;
													case 1:
														goto IL_3665_2;
													case 3:
													case 11:
														goto end_IL_3659_2;
														IL_3558_2:
														num24 = num25;
														continue;
													}
													break;
												}
												goto IL_3589_2;
												IL_3589_2:
												object_6 = new Version(4, 0, 30319, 17020);
												num24 = 9;
												if (PsfwYibARbKayXDITm() == null)
												{
													goto IL_35ab_3;
												}
												goto IL_3665_2;
												IL_3665_2:
												PRZkZqsNsa = true;
												num25 = 11;
												goto end_IL_3659_2;
												continue;
												end_IL_35e6_2:
												break;
											}
											continue;
											end_IL_362f_2:
											break;
										}
										break;
									}
									continue;
									end_IL_3659_2:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								num26 = 1;
								if (PsfwYibARbKayXDITm() != null)
								{
									goto IL_36a5_2;
								}
								goto IL_36be_3;
								IL_36be_3:
								while (true)
								{
									switch (num26)
									{
									case 3:
										OcB3D1aSiX4yvSrrNs(disposable);
										num26 = 0;
										if (PsfwYibARbKayXDITm() == null)
										{
											continue;
										}
										break;
									case 1:
										if (disposable == null)
										{
											num26 = 2;
											if (PsfwYibARbKayXDITm() == null)
											{
												continue;
											}
											break;
										}
										goto case 3;
									default:
										goto end_IL_36be_2;
									}
									goto IL_36a5_2;
									continue;
									end_IL_36be_2:
									break;
								}
								goto end_IL_3679_2;
								IL_36a5_2:
								num26 = num27;
								goto IL_36be_3;
								end_IL_3679_2:;
							}
							goto case 16;
						case 506:
							num9 = 23;
							goto case 398;
						case 398:
							array7[num9] = array5[0];
							goto case 471;
						case 471:
							array7[num9 + 1] = array5[1];
							goto case 420;
						case 420:
							array7[num9 + 2] = array5[2];
							num3 = 574;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 505:
							array4[20] = 68;
							num = 133;
							goto case 133;
						case 133:
							array4[21] = 168;
							goto case 379;
						case 379:
							num6 = 94;
							num3 = 400;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 501:
							array2[2] = 124;
							num3 = 488;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 500:
							array4[20] = (byte)num4;
							goto case 312;
						case 312:
							num4 = 95;
							goto case 3;
						case 3:
							array4[20] = (byte)num4;
							num = 505;
							goto case 505;
						case 497:
							array2[12] = 150;
							num3 = 22;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 693;
						case 496:
							array4[31] = 149;
							goto case 520;
						case 494:
							num4 = 142;
							goto case 257;
						case 257:
							array4[23] = (byte)num4;
							goto case 651;
						case 493:
							array4[14] = (byte)num4;
							goto case 437;
						case 437:
							array4[14] = 94;
							num3 = 12;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 136;
						case 136:
							num4 = 75;
							goto case 649;
						case 490:
							intPtr2 = EF8xwDv62j7mMLyuN0p(rNZkehfwNu);
							num3 = 541;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 489:
							num4 = 48;
							goto case 421;
						case 421:
							array4[2] = (byte)num4;
							num3 = 375;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 488:
							num5 = 10;
							num3 = 567;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 487:
							array[4] = 105;
							num3 = 51;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 484:
							YeeoMqaS3J(intptr_3, 4, int_2, ref int_2);
							num = 577;
							goto case 577;
						case 481:
							array4[28] = 104;
							goto case 311;
						case 311:
							num6 = 106;
							goto case 320;
						case 320:
							array4[28] = (byte)num6;
							num3 = 586;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 480:
							array[4] = 114;
							num = 411;
							goto case 411;
						case 411:
							array[5] = 106;
							num = 262;
							goto case 262;
						case 262:
							array[6] = 105;
							goto case 438;
						case 438:
							array[7] = 116;
							goto case 241;
						case 241:
							array[8] = 46;
							goto case 694;
						case 477:
							array4[7] = (byte)num6;
							goto case 340;
						case 340:
							array4[7] = 158;
							goto case 255;
						case 255:
							array4[7] = 83;
							goto case 587;
						case 475:
							array16 = new byte[40];
							h7hAE7vCXPBh5lF0GOV(array16, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
							array3 = array16;
							num3 = 395;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 474:
							CwIXyivo1EmpV0ysNqL(rNZkehfwNu);
							goto case 616;
						case 469:
							array7[num15 + 4] = array8[4];
							num = 678;
							goto case 678;
						case 468:
							array[2] = 114;
							num3 = 130;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 249;
						case 249:
							array[3] = 106;
							goto case 487;
						case 467:
							array2[10] = (byte)num5;
							goto case 568;
						case 465:
							array4[23] = 128;
							goto case 494;
						case 464:
							num4 = 93;
							num = 297;
							goto case 297;
						case 297:
							array4[18] = (byte)num4;
							num = 622;
							goto case 622;
						case 463:
							PRvHE6k6bN6cQqTYut(array6, 0, SeAdswXtVsYUd5oKM9(8), 1);
							goto case 533;
						case 462:
							num6 = 112;
							num3 = 317;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 456:
							num5 = 104;
							goto case 524;
						case 453:
							array2[10] = 161;
							num = 75;
							goto case 75;
						case 75:
							num5 = 36;
							goto case 467;
						case 452:
							wpoklx4RIX = HPrO0MvTd8MUVO2iftT(eXJkjmTXDX);
							num3 = 107;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 63;
						case 451:
							array4[27] = 121;
							num3 = 481;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 162;
						case 450:
							rNZkehfwNu = NvQ34uZt895nxEhi2FIr;
							num3 = 119;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 166;
						case 166:
							intPtr2 = IntPtr.Zero;
							goto case 490;
						case 448:
							array12[2] = 116;
							num3 = 191;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 145;
						case 145:
							if (T8HYV799DYUL4uCJUx() != 4)
							{
								goto case 571;
							}
							goto case 579;
						case 446:
							array4[0] = 113;
							num3 = 319;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 654;
						case 445:
							array4[1] = (byte)num4;
							num = 215;
							goto case 215;
						case 444:
							YeeoMqaS3J(new IntPtr(value), T8HYV799DYUL4uCJUx(), int_, ref int_);
							num3 = 142;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto end_IL_0009;
						case 440:
							array4[4] = 97;
							goto case 178;
						case 178:
							num6 = 119;
							goto case 122;
						case 122:
							array4[4] = (byte)num6;
							goto case 113;
						case 113:
							num6 = 138;
							num3 = 58;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 10;
						case 10:
							array2[0] = (byte)num5;
							goto case 576;
						case 436:
							if (num22 == num23 - 1)
							{
								goto case 631;
							}
							goto case 482;
						case 433:
							array2[1] = (byte)num5;
							goto case 602;
						case 431:
							array4[13] = 93;
							num = 171;
							goto case 171;
						case 171:
							num6 = 123;
							goto case 18;
						case 18:
							array4[13] = (byte)num6;
							num3 = 611;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 429:
							array4[3] = 135;
							goto case 648;
						case 428:
							array7[num15 + 2] = array11[2];
							goto case 238;
						case 238:
							array7[num15 + 3] = array11[3];
							num3 = 390;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 427:
							num5 = 166;
							goto case 433;
						case 426:
							array[8] = 108;
							num3 = 270;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 424:
							array4[22] = (byte)num6;
							goto case 137;
						case 137:
							num4 = 59;
							goto case 116;
						case 116:
							array4[22] = (byte)num4;
							num3 = 325;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 172;
						case 172:
							array2[3] = (byte)num5;
							num = 108;
							goto case 108;
						case 108:
							num5 = 144;
							goto case 228;
						case 228:
							array2[3] = (byte)num5;
							goto case 662;
						case 417:
							array4[29] = 106;
							num3 = 20;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 36;
						case 36:
							array4[29] = 99;
							goto case 240;
						case 240:
							array4[29] = 163;
							goto case 380;
						case 380:
							num6 = 102;
							num3 = 547;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 285;
						case 407:
							array4[26] = 151;
							num3 = 124;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 405:
							array4[11] = (byte)num6;
							goto case 150;
						case 150:
							array4[11] = 148;
							goto case 425;
						case 402:
							string_ = (string)Td1ATdvqFhFtIHvr48J(JLXqf5vRx2aaqd89sBE(), array12);
							num3 = 336;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 555;
						case 400:
							array4[21] = (byte)num6;
							num = 328;
							goto case 328;
						case 328:
							num4 = 74;
							num3 = 677;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 396:
							Gr3tuxv1KVbCXrOC5wF(rjRe5svWdF7rKS2QFfP(Hy9Pmgvf4eXW2dJhKG1(abxkLGOVrU)));
							goto case 474;
						case 394:
							num6 = 231;
							num3 = 111;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 392:
							object_3 = (SymmetricAlgorithm)Ansf3d3FKg6dfEROda();
							num3 = 548;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 390:
							array7[num15 + 4] = array11[4];
							num3 = 247;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 385:
							num21 = Iuo7Onpe8Wxmkcbqq1(object_2);
							num3 = 519;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 457;
						case 383:
							array2[9] = (byte)num5;
							num3 = 540;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 614;
						case 381:
							num20++;
							num3 = 136;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 14;
						case 378:
							array2[14] = (byte)num5;
							goto case 4;
						case 4:
							num5 = 201;
							num3 = 315;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 376:
							if (num2 == 4109628145u)
							{
								num3 = 562;
								if (PsfwYibARbKayXDITm() == null)
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 665;
						case 375:
							array4[2] = 158;
							num3 = 429;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 374:
							array4[9] = (byte)num6;
							num3 = 303;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 370:
							num6 = 53;
							goto case 670;
						case 369:
							num4 = 66;
							goto case 601;
						case 366:
							UcnBqdN8BVuNtVsOBe(new IntPtr(&num8), 0, 0L);
							goto case 362;
						case 362:
							array6 = new byte[1];
							num = 463;
							goto case 463;
						case 364:
							array12[1] = 101;
							goto case 448;
						case 361:
							array4[10] = (byte)num6;
							goto case 672;
						case 358:
							array4[16] = 178;
							num3 = 196;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 357:
							array4[8] = (byte)num6;
							num = 217;
							goto case 217;
						case 217:
							num4 = 91;
							goto case 165;
						case 165:
							array4[8] = (byte)num4;
							goto case 671;
						case 355:
							array15 = (array6 = array14);
							if (array15 == null)
							{
								num3 = 470;
								if (PsfwYibARbKayXDITm() == null)
								{
									continue;
								}
								goto IL_0b5b;
							}
							goto case 516;
						case 353:
							array4[12] = (byte)num6;
							num3 = 431;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 350:
							num6 = 140;
							goto case 551;
						case 347:
							num6 = 98;
							goto case 353;
						case 346:
							array2[2] = (byte)num5;
							goto case 501;
						case 341:
							bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
							num3 = 126;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 338:
							array2[14] = 136;
							goto case 88;
						case 337:
							text = (string)Td1ATdvqFhFtIHvr48J(JLXqf5vRx2aaqd89sBE(), array);
							num3 = 13;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 336:
							array[1] = 115;
							goto case 689;
						case 335:
							array2[4] = 65;
							num3 = 511;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 28;
						case 332:
							intptr_2 = BSsrVXH9ksT1AeTW3s((uint)uint_, 1, (uint)imi2QVeQVWyZuJX57V(RlEepR6Ul0aEhb1wdK()));
							num3 = 48;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 145;
						case 331:
							array7[num15 + 2] = array8[2];
							num3 = 290;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 330:
							num6 = 191;
							goto case 361;
						case 329:
							array4[4] = 42;
							num = 538;
							goto case 538;
						case 325:
							array4[22] = 0;
							goto case 465;
						case 324:
							array4[16] = (byte)num6;
							goto case 199;
						case 199:
							num6 = 100;
							num = 194;
							goto case 194;
						case 194:
							array4[16] = (byte)num6;
							num3 = 591;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 465;
						case 322:
							array13[num18 + 2] = (byte)((num19 & 0xFF0000) >> 16);
							num3 = 119;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 153;
						case 153:
							array13[num18 + 3] = (byte)((num19 & 0xFF000000u) >> 24);
							goto case 65;
						case 321:
							array4[21] = 174;
							goto case 69;
						case 69:
							array4[21] = 122;
							num = 563;
							goto case 563;
						case 318:
							array4[19] = 96;
							num3 = 10;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 21;
						case 21:
							num4 = 134;
							num3 = 305;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 315:
							array2[14] = (byte)num5;
							goto case 528;
						case 305:
							array4[19] = (byte)num4;
							num3 = 173;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 303:
							array4[9] = 84;
							goto case 593;
						case 302:
							array4[30] = 118;
							goto case 669;
						case 295:
							num5 = 227;
							goto case 540;
						case 294:
							H4ap1qvbt71iA0wPPnS(lmdkVksVkh, 0L, bIpvxRBRb2dOGl802m2);
							goto case 512;
						case 293:
							array4[23] = (byte)num4;
							num3 = 350;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 272;
						case 272:
							num17 = 255u;
							num3 = 202;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 292:
							oSsY2hsoKyveAgZRk3(new IntPtr(&num8), 0, 0);
							num3 = 366;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 290:
							array7[num15 + 3] = array8[3];
							goto case 469;
						case 279:
							array2[3] = 68;
							num3 = 47;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 271:
							bIpvxRBRb2dOGl802m.JDNkifbo3S = jDNkifbo3S;
							num3 = 209;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 270:
							array[9] = 108;
							num3 = 337;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 268:
							num5 = 95;
							goto case 383;
						case 267:
							num4 = 131;
							num = 521;
							goto case 521;
						case 266:
							if (num16 != 4)
							{
								goto case 219;
							}
							goto case 392;
						case 259:
							if (!E987FNvsWuJEWT0KwyI(intptr_, IntPtr.Zero))
							{
								goto case 76;
							}
							goto case 583;
						case 253:
							array4[13] = (byte)num6;
							goto case 612;
						case 247:
							array7[num15 + 5] = array11[5];
							goto case 557;
						case 237:
							array4[3] = (byte)num4;
							num3 = 210;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 236:
							array4[15] = (byte)num6;
							num3 = 697;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 47;
						case 47:
							num5 = 108;
							goto case 172;
						case 233:
							array11 = (byte[])uhrG7DvcRwZPmrZdGRP(num7);
							goto case 309;
						case 229:
							array4[25] = (byte)num4;
							goto case 93;
						case 93:
							num6 = 192;
							num3 = 70;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 50;
						case 227:
							num5 = 144;
							num3 = 10;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 223:
							array[6] = 46;
							goto case 2;
						case 2:
							array[7] = 100;
							goto case 426;
						case 214:
							num14++;
							num = 443;
							goto case 404;
						case 210:
							num6 = 42;
							num = 40;
							goto case 40;
						case 40:
							array4[3] = (byte)num6;
							num3 = 440;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 209:
							H4ap1qvbt71iA0wPPnS(lmdkVksVkh, num12 + num13, bIpvxRBRb2dOGl802m);
							num3 = 110;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 263;
						case 204:
							num6 = 151;
							num = 424;
							goto case 424;
						case 202:
							num11 = 0;
							goto case 436;
						case 198:
							num10++;
							num3 = 319;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 197:
							array12[5] = 116;
							num3 = 402;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 361;
						case 196:
							array4[17] = 126;
							goto case 12;
						case 12:
							array4[17] = 130;
							goto case 394;
						case 191:
							array12[3] = 74;
							goto case 560;
						case 190:
							YeeoMqaS3J(new IntPtr(value), T8HYV799DYUL4uCJUx(), 64, ref int_);
							goto case 74;
						case 74:
							PTG8q9vjrDfaQyKxHGJ(new IntPtr(value), intPtr3);
							goto case 444;
						case 189:
							array2[4] = (byte)num5;
							goto case 295;
						case 188:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								goto case 87;
							}
							num3 = 475;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 199;
						case 187:
							array4[15] = 100;
							goto case 640;
						case 185:
							array7[num9 + 1] = array11[1];
							num3 = 537;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 384;
						case 173:
							num4 = 190;
							goto case 500;
						case 170:
							array9[9] = array10[4];
							goto case 6;
						case 6:
							array9[11] = array10[5];
							num3 = 615;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 163:
							array2[2] = (byte)num5;
							goto case 61;
						case 61:
							array2[2] = 116;
							goto case 514;
						case 160:
							array2[6] = 94;
							goto case 597;
						case 159:
							num6 = 155;
							goto case 357;
						case 157:
							num4 = 105;
							num = 605;
							goto case 605;
						case 149:
							bIpvxRBRb2dOGl802m2.JDNkifbo3S = false;
							num3 = 294;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto IL_0b5b;
						case 146:
							num6 = 155;
							goto case 324;
						case 143:
							array4[24] = (byte)num6;
							goto case 95;
						case 95:
							num4 = 205;
							goto case 572;
						case 134:
							array4[31] = (byte)num4;
							goto case 496;
						case 130:
							num6 = 89;
							num3 = 374;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 127:
							num9 = 9;
							goto case 123;
						case 123:
							array7[num9] = array8[0];
							goto case 675;
						case 126:
							reference = ref bIpvxRBRb2dOGl802m2;
							array6 = new byte[1] { 42 };
							reference.jsbkrdexts = array6;
							goto case 149;
						case 124:
							num6 = 162;
							goto case 29;
						case 29:
							array4[26] = (byte)num6;
							goto case 625;
						case 120:
							array4[18] = 32;
							goto case 464;
						case 111:
							array4[17] = (byte)num6;
							goto case 120;
						case 109:
							num6 = 241;
							goto case 661;
						case 102:
							num8 = 0L;
							goto case 56;
						case 56:
							ymo9V3JfkrBEwjVuTN(new IntPtr(&num8), 0);
							goto case 26;
						case 26:
							VfWCIVTwCdogtKA7bJ(new IntPtr(&num8), 0);
							num3 = 663;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 543;
						case 100:
							num5 = 120;
							goto case 163;
						case 99:
							array4[15] = (byte)num6;
							goto case 187;
						case 96:
							num5 = 94;
							num3 = 515;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 259;
						case 94:
							num7 = Pnr23EvEYIIPdwulJk0(new IntPtr(value));
							num = 690;
							goto case 50;
						case 92:
							array5 = (byte[])uhrG7DvcRwZPmrZdGRP(intPtr2.ToInt64());
							goto case 233;
						case 80:
							array4[0] = (byte)num4;
							num3 = 54;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 446;
						case 79:
							array4[5] = (byte)num6;
							goto case 633;
						case 73:
							YeeoMqaS3J(intPtr, 4, 4, ref int_2);
							num3 = 518;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 609;
						case 70:
							array4[26] = (byte)num6;
							goto case 589;
						case 68:
							bIpvxRBRb2dOGl802m.jsbkrdexts = jsbkrdexts;
							num3 = 271;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 81;
						case 60:
							array4[0] = (byte)num6;
							num3 = 7;
							if (!cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto case 45;
						case 45:
							num4 = 157;
							num3 = 80;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 58:
							array4[4] = (byte)num6;
							num = 329;
							goto case 329;
						case 55:
							array2[10] = (byte)num5;
							goto case 453;
						case 53:
							array2[6] = 115;
							num3 = 160;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 51:
							array[5] = 116;
							num3 = 223;
							if (cnwib5vMRnDuwHuQHW())
							{
								continue;
							}
							goto IL_0b5b;
						case 49:
							if (T8HYV799DYUL4uCJUx() == 4)
							{
								goto case 688;
							}
							goto case 94;
						case 38:
							array3 = null;
							goto case 188;
						case 34:
							if (!fxUQ1dvxhoIVa5wbxGn(foiAigvMM7wCOoJ1Pc8(eExcg9vJmltHggheFp3(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
							{
								goto case 638;
							}
							num3 = 132;
							if (PsfwYibARbKayXDITm() != null)
							{
								continue;
							}
							goto case 590;
						case 32:
							num6 = 84;
							goto case 99;
						case 27:
							array2[12] = (byte)num5;
							goto case 497;
						case 24:
							enumerator = (IEnumerator)tLhWr2gLT94ta57ay6(object_);
							num3 = 510;
							if (PsfwYibARbKayXDITm() == null)
							{
								continue;
							}
							goto case 122;
						case 23:
							array[0] = 109;
							goto case 336;
						case 1:
							int_ = 0;
							goto case 34;
						default:
							num4 = 142;
							goto case 636;
						case 243:
							return;
						case 142:
							GCRyUTvvvNaOst612Tj(intptr_2);
							goto case 285;
						case 285:
							RKPutnyZ1ld0gp3H7Z();
							return;
						case 600:
							return;
						case 344:
							return;
						case 212:
							goto end_IL_0009;
						case 313:
							return;
						}
						break;
					}
					break;
				}
				break;
			}
			continue;
			end_IL_0009:
			break;
		}
		RKPutnyZ1ld0gp3H7Z();
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
			BV0kmUIPgx = (MacgPI7JyVeAhNaPvd)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554785)));
		}
		return BV0kmUIPgx(intptr_0, (string)object_0, uint_0);
	}

	private static IntPtr YDsoA9ylfU(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (yBRkv0eFeZ == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			yBRkv0eFeZ = (GL8NaIwq2KOvLQhMFX)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554786)));
		}
		return yBRkv0eFeZ(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int mTfoQqVbOE(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (tTVkFDSO7A == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			tTVkFDSO7A = (yy2w1VXOQgx806ubre)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554787)));
		}
		return tTVkFDSO7A(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int YeeoMqaS3J(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (zIOkYypt1M == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			zIOkYypt1M = (N7UlhA3IRW2ugh7tWg)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554788)));
		}
		return zIOkYypt1M(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr tdOo5aPwrv(uint uint_0, int int_0, uint uint_1)
	{
		if (tuYkt9D06I == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			tuYkt9D06I = (RI754BJF754hNSApRW)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554789)));
		}
		return tuYkt9D06I(uint_0, int_0, uint_1);
	}

	private static int Q2sob65b9D(IntPtr intptr_0)
	{
		if (etmkyDG2SG == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			etmkyDG2SG = (YLCGmBEaUwBbEqLM01)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.Fe0gdfeqAWHRK(33554790)));
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
			96, 158, 2, 85, 172, 101, 107, 117, 62, 22,
			9, 133, 208, 120, 12, 41, 107, 72, 204, 182,
			150, 188, 160, 139, 216, 71, 208, 168, 143, 66,
			81, 104
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			142, 146, 191, 73, 7, 41, 136, 137, 224, 167,
			155, 117, 239, 70, 199, 59
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_0, 0, ((Array)object_0).Length);
		cryptoStream.Close();
		byte[] result = rLIoBbVVpm(stream);
		hHEYokUTtehNq5ji0d.BUZgdfmzxASR9();
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

	internal static object vPkG6pjVQ8YP21IxMN(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object gZXhgH25T85f2SiTrO(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void TeQhgZqOWEZRyfYR3h(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long gp0RFFxyLpTDLyofjL(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object sSlSge15fEoGhMvt62(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void w3e8mXwI67OUxkRG6Y(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void OsoodUd5sGFQq8OFV2(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object S243RHtEoWHgD8Rvbl(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object ATd4jF59tPaoUjP7GU(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object ovewT5DACiRaqfYEn1()
	{
		return PEXoCqmS4w();
	}

	internal static void g3duGNyphuWUfEPeWv(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object Ituu75B8316DFUfPme(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object r6wYcnYveJ0B0N3gKH()
	{
		return Njco6C1nc4();
	}

	internal static void l9UCNNOJxNNfdkO4lH(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void j4sBIGkRLQD3CxXBbJ(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object iCSXCShcv4bNZdTAHl(object object_0)
	{
		return rLIoBbVVpm((Stream)object_0);
	}

	internal static void SMqsktKAMoNH6tu4PK(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int J22yGrJuwLLyKmEl30(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void K37bpuPtPZ5690YfQ2()
	{
		hHEYokUTtehNq5ji0d.BUZgdfmzxASR9();
	}

	internal static object dXxLnUcd9pM8HvlYot()
	{
		return Encoding.Unicode;
	}

	internal static object NtsyK0E9qciuEKTbEj(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool dfgfXZWBpNPNxBJrEf()
	{
		return (object)null == null;
	}

	internal static object G8BecZLbcd92c40CuR()
	{
		return null;
	}

	internal static void gTEwWwgyVna9DC1GFo()
	{
		hHEYokUTtehNq5ji0d.BUZgdfmzxASR9();
	}

	internal static void I6DcoCAmf3JWaf4HAb(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type GUa2FLoXcy8vGsaB6N(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object YUPc1g8xZQbot3fv7V(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int wnRUxWYUnrqZevFYVT(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object PfD3qd0IIhCHgsDMUp()
	{
		return SHA1.Create();
	}

	internal static object YtXyMLx6dytrRjqyV7(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool tm7r4ZbuCysTgAguSk(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object feTP3v9sAhB98qKyRA(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object uRajovKb5QsP6MHDHu(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void prpSDAQ4FfJdSfVpjv(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long lt5LF0ecEnjueC9Jfl(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object WM9su256ury1RM17Lp(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static object LAm3QAUBdEoc2iAjfF()
	{
		return PEXoCqmS4w();
	}

	internal static void lHQ6Olv5Ri50OXZZBP(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object sVMAvVPgGZWilJKj6r(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object JSpFWT3apVo7rKWaGB()
	{
		return Njco6C1nc4();
	}

	internal static void cnSaPdpCECbvBNLVAl(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void YSZZ5lJlmA6tl8Dh9V(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object j449JTOZZyDBd1gMWE()
	{
		return Encoding.UTF8;
	}

	internal static object kho5ZNl5AjvdlYnsWH(object object_0)
	{
		return rLIoBbVVpm((Stream)object_0);
	}

	internal static object e6EaHdrHYmb7QIX6ok(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void yyGhjpEy1gOGJOmpjy(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void M4UNFrTyEhYSxLvYst(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void qpQY3hD791Qrnq3uOQ(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void yrpAIYkS847MMFqeP2(object object_0, object object_1, uint uint_0, object object_2)
	{
		vBuojdip3i((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort GudScqWoQukoynhuqn(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int LdHmKAyUxk4Xibda5T(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void SN6vTOdP1wr2jkTCJL(object object_0, object object_1, int int_0, int int_1)
	{
		NSmolmd79S((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long jwj10l4dNVSCZCnU8Y(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint hQCf57uURjpRkZfcpL(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint UKfFsNGmuk8GfxImk2(uint uint_0, int int_0, long long_0, object object_0)
	{
		return SDQoufkqT0(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long BHLrDtcK0IxjjG9i1H(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object paesq7ieIVVfh2S9VR(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object pYlbQijy2fHlcrNYno(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void eAlnJAacIRPD59UNWv(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object HpisH2XChkBTO8O233(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool WM36D5q2vYJ1X9yWT7(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object pSbeF3NG0jdXSk2aLk(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object gB58FyLfm3oJ23rF4i(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object eyOHhpHn4ophUD4Tvj(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool aexgU62ambdiJIlvn4()
	{
		return (object)null == null;
	}

	internal static object RukUoNIMjxXTUk6iAu()
	{
		return null;
	}

	internal static IntPtr ymo9V3JfkrBEwjVuTN(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static int VfWCIVTwCdogtKA7bJ(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt32(intptr_0, int_0);
	}

	internal static long gsK9XnRnQvtX7ikaZv(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt64(intptr_0, int_0);
	}

	internal static void PDnPGLq8flejBjnsh8(IntPtr intptr_0, int int_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
	}

	internal static void oSsY2hsoKyveAgZRk3(IntPtr intptr_0, int int_0, int int_1)
	{
		Marshal.WriteInt32(intptr_0, int_0, int_1);
	}

	internal static void UcnBqdN8BVuNtVsOBe(IntPtr intptr_0, int int_0, long long_0)
	{
		Marshal.WriteInt64(intptr_0, int_0, long_0);
	}

	internal static IntPtr SeAdswXtVsYUd5oKM9(int int_0)
	{
		return Marshal.AllocCoTaskMem(int_0);
	}

	internal static void PRvHE6k6bN6cQqTYut(object object_0, int int_0, IntPtr intptr_0, int int_1)
	{
		Marshal.Copy((byte[])object_0, int_0, intptr_0, int_1);
	}

	internal static void dnTFuIE1c6GhmSar5d()
	{
		svloy6EVGc();
	}

	internal static object RlEepR6Ul0aEhb1wdK()
	{
		return Process.GetCurrentProcess();
	}

	internal static object cyAvcLGO1F6V544d5w(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static IntPtr P9E3JeMbivWI7BNYgN(object object_0)
	{
		return ((ProcessModule)object_0).BaseAddress;
	}

	internal static IntPtr RsXJCxxWf3Kl90R6J5(IntPtr intptr_0, object object_0, uint uint_0)
	{
		return w3ZoqRBn5p(intptr_0, object_0, uint_0);
	}

	internal static bool AyfBTqfiQdaUA6JeXl(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 != intptr_1;
	}

	internal static void RKPutnyZ1ld0gp3H7Z()
	{
		hHEYokUTtehNq5ji0d.BUZgdfmzxASR9();
	}

	internal static int T8HYV799DYUL4uCJUx()
	{
		return IntPtr.Size;
	}

	internal static Type hiIW3l0lJxxPIgBHXy(object object_0, bool bool_0)
	{
		return Type.GetType((string)object_0, bool_0);
	}

	internal static bool jprDK4L5TKMDTrvTwV(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static object aN79LMiWBPpE4sELsP(object object_0)
	{
		return ((Process)object_0).Modules;
	}

	internal static object tLhWr2gLT94ta57ay6(object object_0)
	{
		return ((ReadOnlyCollectionBase)object_0).GetEnumerator();
	}

	internal static object SpecVgcCHhCjLNxNT2(object object_0)
	{
		return ((IEnumerator)object_0).Current;
	}

	internal static object u8JRrRoicD0sGpHK09(object object_0)
	{
		return ((ProcessModule)object_0).ModuleName;
	}

	internal static object HgGeVvWEULHvj4hhxj(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static bool AEnLDv18ZTuoKbb5wM(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object sn79l9C1LsgMntbBWk(object object_0)
	{
		return ((ProcessModule)object_0).FileVersionInfo;
	}

	internal static int s151lolBNOsNCAgDkP(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMajorPart;
	}

	internal static int RHWxcGjLysgN9cOlVt(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMinorPart;
	}

	internal static int NXCeOH2XnbNTNYRHWX(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductBuildPart;
	}

	internal static int z8NIrHFcpe6L7SjKyL(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductPrivatePart;
	}

	internal static bool VfOsHg58Xg4FqG3wCW(object object_0, object object_1)
	{
		return (Version?)object_0 >= (Version?)object_1;
	}

	internal static bool ywwLwIUtLmSfmQ3uqY(object object_0, object object_1)
	{
		return (Version?)object_0 < (Version?)object_1;
	}

	internal static bool l5DauXK3JZLhJMEyVn(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void OcB3D1aSiX4yvSrrNs(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object dJC3oLVPNiFZJlbpnH(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object HuHxx4nJ83h1bSJXOG(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void IbMqPdBO53HK0us9pI(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long Vd88xJYKwFGj5uKiAe(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object W0tB3fmF9aixUx94Wn(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void IVIY1AhrVOp6WyhexY(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object UajfJdw2Mgh8VeD29i(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object JukMcpOJhkrWqd5w1w(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static void JAZe0xADYFLLoZwkVd(object object_0, int int_0, int int_1)
	{
		Array.Clear((Array)object_0, int_0, int_1);
	}

	internal static object pYZ0M7IOwD6BCCYb9l(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static IntPtr YK06m34LGZhp3u1ghH(object object_0)
	{
		return Marshal.GetHINSTANCE((Module)object_0);
	}

	internal static object uHAIjKrO4Hf6eUoVMo(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int S88qBA7ZZJdCL7GTIm(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int Iuo7Onpe8Wxmkcbqq1(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).TVtkAMaqpL();
	}

	internal static object Ansf3d3FKg6dfEROda()
	{
		return PEXoCqmS4w();
	}

	internal static void RbVLmKZVBn7PqKKeeY(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object QgFX6u8tARgbBxM4n4(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static void DunnU3tP2mNprIipAn(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void miJRONPWPUPfHF3idq(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object KBm26YS06UbN6kI08B(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void CCYWllDJfu0U4ZAtBI(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void LG36xEd7ubVfYU1Gt0(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static int imi2QVeQVWyZuJX57V(object object_0)
	{
		return ((Process)object_0).Id;
	}

	internal static IntPtr BSsrVXH9ksT1AeTW3s(uint uint_0, int int_0, uint uint_1)
	{
		return tdOo5aPwrv(uint_0, int_0, uint_1);
	}

	internal static object iEk9VAQa23t2IMOZLf(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static long JS1MGkzc9J9wAiqxE4(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static void aQbsnKvu6jFlFVsqWqM(IntPtr intptr_0, int int_0)
	{
		Marshal.WriteInt32(intptr_0, int_0);
	}

	internal static int GCRyUTvvvNaOst612Tj(IntPtr intptr_0)
	{
		return Q2sob65b9D(intptr_0);
	}

	internal static void H4ap1qvbt71iA0wPPnS(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static Type eExcg9vJmltHggheFp3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int HPrO0MvTd8MUVO2iftT(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static object JLXqf5vRx2aaqd89sBE()
	{
		return Encoding.UTF8;
	}

	internal static object Td1ATdvqFhFtIHvr48J(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool E987FNvsWuJEWT0KwyI(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 == intptr_1;
	}

	internal static object HTUe0wvNPAcvIaonZBp(IntPtr intptr_0, Type type_0)
	{
		return iaKoOg5GGg(intptr_0, type_0);
	}

	internal static IntPtr RsKgNtvXnhiuittWgbI(object object_0)
	{
		return object_0();
	}

	internal static int ge0KN8vkOsWG9SgWvAT(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static long Pnr23EvEYIIPdwulJk0(IntPtr intptr_0)
	{
		return Marshal.ReadInt64(intptr_0);
	}

	internal static IntPtr EF8xwDv62j7mMLyuN0p(object object_0)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)object_0);
	}

	internal static int eSLb8pvGTBwtRbXYXPE(object object_0)
	{
		return ((ProcessModule)object_0).ModuleMemorySize;
	}

	internal static object foiAigvMM7wCOoJ1Pc8(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool fxUQ1dvxhoIVa5wbxGn(object object_0, object object_1)
	{
		return (MethodInfo?)object_0 != (MethodInfo?)object_1;
	}

	internal static object Hy9Pmgvf4eXW2dJhKG1(object object_0)
	{
		return ((Delegate)object_0).Method;
	}

	internal static object GP0ZpVvyG9rn9ofeyf7(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static object mlYILKv95g53nR8ca6J(object object_0)
	{
		return ((MethodBase)object_0).GetParameters();
	}

	internal static object L8dTWnv0laKtHr0pv7A(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}

	internal static ModuleHandle KkUYfQvLAQWEPaeEvUt(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}

	internal static Type Q177RmviuWhVERK2cMk(object object_0)
	{
		return object_0.GetType();
	}

	internal static object C3AtdsvgmNIMmgVcrDX(object object_0, object object_1)
	{
		return ((FieldInfo)object_0).GetValue(object_1);
	}

	internal static object uhrG7DvcRwZPmrZdGRP(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static void CwIXyivo1EmpV0ysNqL(object object_0)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)object_0);
	}

	internal static RuntimeMethodHandle rjRe5svWdF7rKS2QFfP(object object_0)
	{
		return ((MethodBase)object_0).MethodHandle;
	}

	internal static void Gr3tuxv1KVbCXrOC5wF(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void h7hAE7vCXPBh5lF0GOV(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static IntPtr E11Blivl1C9EaDqc0ae(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		return YDsoA9ylfU(intptr_0, uint_0, uint_1, uint_2);
	}

	internal static void PTG8q9vjrDfaQyKxHGJ(IntPtr intptr_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, intptr_1);
	}

	internal static bool cnwib5vMRnDuwHuQHW()
	{
		return (object)null == null;
	}

	internal static object PsfwYibARbKayXDITm()
	{
		return null;
	}
}
