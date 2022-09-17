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
			internal static object hU7AA9b01QmgnyDOX2V;

			static iGR41459RDH4FvPdNk()
			{
				prXoP4RuYp();
				iXLoKRSpAw();
			}

			internal static bool DJIyaBbRuQPcbR3jhIu()
			{
				return true;
			}

			internal static object hR3wfhbZ0KRqn5n4M9r()
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
		internal static string G9skPDgcXb(object object_0, object object_1)
		{
			return null;
		}

		internal static object jqbt1fbCU6qcrkA2Bg7()
		{
			return null;
		}

		internal static object MBeXKrbPl2m3cQ3oc8M(object object_0, object object_1)
		{
			return null;
		}

		internal static void ze5PCjbwl2yPKSM3IAp(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static object Ky5F8XbFAK32QAuTitf(object object_0)
		{
			return null;
		}

		internal static object mEFP2tbI1gIFmuHJRel()
		{
			return null;
		}

		internal static void mGsp10bLhUHtmudHh0A(object object_0, object object_1)
		{
		}

		internal static object JNykIBbk91Q3Y06907Z(object object_0)
		{
			return null;
		}

		internal static void TcYWhvb8HuCdt4CTPeL(object object_0, object object_1, int int_0, int int_1)
		{
		}

		internal static void IZ6qyybvRYvhD01k3Ys(object object_0)
		{
		}

		internal static object n8XkXFbnlpic49SpebN(object object_0)
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
		private object KPVkbuTpLj;

		public VtNVUKGulysZw81C3E(Stream stream_0)
		{
			KPVkbuTpLj = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return ((BinaryReader)KPVkbuTpLj).BaseStream;
		}

		internal byte[] B2XkaLi4dH(int int_0)
		{
			return (byte[])s3K1UTbaLIDxv3X8RVF(KPVkbuTpLj, int_0);
		}

		internal int hx5kqNgSj4(byte[] byte_0, int int_0, int int_1)
		{
			return ((BinaryReader)KPVkbuTpLj).Read(byte_0, int_0, int_1);
		}

		internal int TVtkAMaqpL()
		{
			return lAfHhmbu8XoOiVgl5ou(KPVkbuTpLj);
		}

		internal void VDqkQKyKML()
		{
			cSsWJ6bhjtfKAUKaJLf(KPVkbuTpLj);
		}

		internal static object s3K1UTbaLIDxv3X8RVF(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int lAfHhmbu8XoOiVgl5ou(object object_0)
		{
			return ((BinaryReader)object_0).ReadInt32();
		}

		internal static void cSsWJ6bhjtfKAUKaJLf(object object_0)
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

	internal static object x4Dk2IHVmX;

	private static IntPtr K7PkOHxqAd;

	private static object yBRkv0eFeZ;

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static bool firstrundone;

	internal static object rNZkehfwNu;

	private static object tTVkFDSO7A;

	private static object s6pkoGoeab;

	private static int XtMknffM5M;

	private static object etmkyDG2SG;

	private static bool xo4kuDarJK;

	private static object VM5kd0GoFG;

	private static bool fMAkKtNIoA;

	private static long eXJkjmTXDX;

	private static object OObkplyC7t;

	private static int Qy5kfBXtEh;

	private static int CgSk1JZr60;

	private static object O1BkIDx0L0;

	private static bool V9fkgxQPQA;

	internal static object abxkLGOVrU;

	private static object emjkxI4Yxp;

	private static object tuYkt9D06I;

	private static IntPtr VE2k4S5okQ;

	private static int wpoklx4RIX;

	private static object zl0ksqgIH1;

	private static object zIOkYypt1M;

	private static Dictionary<int, int> Tqek0lIh21;

	private static bool LrEkS2eXQL;

	private static IntPtr wcyk8nIyBt;

	private static object BV0kmUIPgx;

	private static bool MrkkWebIMK;

	internal static object onZkkIlVOi;

	private static IntPtr aatkD4ZSGk;

	internal static object lmdkVksVkh;

	private static object WaKkhokJrA;

	private static bool PRZkZqsNsa;

	private static long URnkCOceLK;

	private static object HkLkNdDPtB;

	static WP6RZJql8gZrNhVA9v()
	{
		PRZkZqsNsa = false;
		x4Dk2IHVmX = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554466)).Assembly;
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

	private void Ro0HMaWf7SXe7()
	{
	}

	internal static byte[] ab9oDe4UH3(object object_0)
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
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])O1BkIDx0L0)[uint_5 - 1], ushort_0);
	}

	private static void zDKosecjaB(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])O1BkIDx0L0)[uint_5 - 1], ushort_0);
	}

	private static void ubAof6RgCm(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_0)[uint_4] + ((uint[])O1BkIDx0L0)[uint_5 - 1], ushort_0);
	}

	private static void YpJoWsPi7X(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + BEVodWAYPB(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])O1BkIDx0L0)[uint_5 - 1], ushort_0);
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

	internal static byte[] XEDoeIU7mj(object object_0)
	{
		if (!gX8onkMSd7())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])object_0);
		}
		return ab9oDe4UH3(object_0);
	}

	internal static void vBuojdip3i(object object_0, object object_1, uint uint_0, object object_2)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)((Array)object_2).Length) ? ((Array)object_2).Length : ((int)uint_0));
			((Stream)object_1).Read((byte[])object_2, 0, num);
			NSmolmd79S(object_0, object_2, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void NSmolmd79S(object object_0, object object_1, int int_0, int int_1)
	{
		((HashAlgorithm)object_0).TransformBlock((byte[])object_1, int_0, int_1, (byte[]?)object_1, int_0);
	}

	internal static uint SDQoufkqT0(uint uint_0, int int_0, long long_0, object object_0)
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

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static void iXLoKRSpAw()
	{
		//IL_299a: Incompatible stack heights: 0 vs 1
		//IL_299a: Incompatible stack heights: 1 vs 0
		int num = 6;
		int num12 = default(int);
		int int_ = default(int);
		int num16 = default(int);
		long long_ = default(long);
		uint uint_2 = default(uint);
		uint num24 = default(uint);
		long num19 = default(long);
		uint uint_ = default(uint);
		uint num23 = default(uint);
		uint num17 = default(uint);
		int num15 = default(int);
		long num22 = default(long);
		long num18 = default(long);
		long num21 = default(long);
		uint num14 = default(uint);
		byte[] array5 = default(byte[]);
		uint num20 = default(uint);
		uint num13 = default(uint);
		bool flag = default(bool);
		string object_ = default(string);
		int num26 = default(int);
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		int num6 = default(int);
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		int num9 = default(int);
		byte[] object_6 = default(byte[]);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] object_4 = default(byte[]);
		Stream stream = default(Stream);
		CryptoStream object_5 = default(CryptoStream);
		int num4 = default(int);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		while (onZkkIlVOi == null)
		{
			while (true)
			{
				IL_0013:
				qk4vFf8cv6WfKLrxG4();
				while (true)
				{
					IL_0018:
					zijw4gLPoKMQ80FkgW(bool_0: true);
					num = 3;
					while (true)
					{
						IL_0027:
						onZkkIlVOi = new RSACryptoServiceProvider();
						while (true)
						{
							IL_0031:
							string text = (string)l5eZx0jbFCUtbnw9lr(dFlohZukXVlLNdO3Wm(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly);
							int num2 = 10;
							if (tMvWB1Ab8QplFjK3Kd() == null)
							{
								goto IL_0056;
							}
							goto IL_00c3;
							IL_00c3:
							num2 = num;
							goto IL_0056;
							IL_0056:
							while (true)
							{
								switch (num2)
								{
								case 6:
									break;
								case 5:
									goto IL_0013;
								case 7:
									goto IL_0018;
								case 3:
									goto IL_0027;
								case 14:
									goto IL_0031;
								default:
									return;
								case 15:
									try
									{
										FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
										while (true)
										{
											BinaryReader object_7 = new BinaryReader(fileStream);
											while (true)
											{
												byte[] array4 = new byte[65536];
												while (true)
												{
													Xg5xLhqQWYmO9wHjQY(hashAlgorithm, fileStream, 152u, array4);
													while (true)
													{
														bool flag2 = CxZr5b1JL8a2AbAV3x(object_7) != 523;
														while (true)
														{
															IL_06e8:
															int num10;
															if (flag2)
															{
																num10 = 96;
																goto IL_06cf;
															}
															int num11 = 58;
															if (!LiBL2dUkUOLlBR01HC())
															{
																goto IL_02a8;
															}
															goto IL_056a;
															IL_0221:
															array4[65] = 0;
															num11 = 60;
															if (tMvWB1Ab8QplFjK3Kd() != null)
															{
																goto IL_0119;
															}
															goto IL_056a;
															IL_0119:
															num11 = num12;
															goto IL_056a;
															IL_06cf:
															int_ = num10;
															goto IL_06bb;
															IL_06bb:
															AfxDFT0JWREM3YgPTu(fileStream, 152L);
															goto IL_0699;
															IL_0699:
															fwhH4UoUJ0ZKgVhLBO(fileStream, array4, 0, int_);
															num11 = 49;
															if (LiBL2dUkUOLlBR01HC())
															{
																goto IL_021b;
															}
															goto IL_056a;
															IL_056a:
															while (true)
															{
																switch (num11)
																{
																case 72:
																	array4[35] = 0;
																	goto case 36;
																case 36:
																	array4[36] = 0;
																	goto case 14;
																case 14:
																	array4[37] = 0;
																	goto case 53;
																case 53:
																	array4[38] = 0;
																	num12 = 63;
																	goto case 63;
																case 63:
																	array4[39] = 0;
																	num11 = 43;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 71:
																	Xg5xLhqQWYmO9wHjQY(hashAlgorithm, fileStream, (uint)(num16 * 40), array4);
																	goto case 61;
																case 61:
																	long_ = QJEuD7n85S86RcD4fZ(fileStream);
																	goto case 67;
																case 67:
																	if (!flag2)
																	{
																		goto case 28;
																	}
																	goto case 66;
																case 28:
																case 45:
																	AfxDFT0JWREM3YgPTu(fileStream, 376L);
																	num11 = 8;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0119;
																case 66:
																	AfxDFT0JWREM3YgPTu(fileStream, 360L);
																	goto case 8;
																case 8:
																case 51:
																	uint_2 = PdQ6cnQOnWN5YXiVGK(object_7);
																	goto case 44;
																case 44:
																	num24 = fT4l9jImv70V2cJ96G(uint_2, num16, num19, object_7);
																	goto case 42;
																case 42:
																	AfxDFT0JWREM3YgPTu(fileStream, num24 + 32);
																	num12 = 13;
																	goto case 13;
																case 13:
																	uint_ = PdQ6cnQOnWN5YXiVGK(object_7);
																	num11 = 17;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 70:
																	if (num23 < num17)
																	{
																		num11 = 24;
																		if (tMvWB1Ab8QplFjK3Kd() != null)
																		{
																			continue;
																		}
																		goto case 34;
																	}
																	goto case 26;
																case 34:
																	num17 -= num23;
																	goto case 64;
																case 64:
																	AfxDFT0JWREM3YgPTu(fileStream, QJEuD7n85S86RcD4fZ(fileStream) + num23);
																	num11 = 54;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 26:
																case 49:
																	num15++;
																	num11 = 21;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 69:
																	break;
																case 4:
																	goto IL_0221;
																case 29:
																case 54:
																case 68:
																	if (num17 == 0)
																	{
																		num11 = 30;
																		if (tMvWB1Ab8QplFjK3Kd() != null)
																		{
																			continue;
																		}
																		goto case 26;
																	}
																	goto case 38;
																case 38:
																	num22 = QJEuD7n85S86RcD4fZ(fileStream);
																	goto case 47;
																case 47:
																	if (num18 <= num22)
																	{
																		goto case 30;
																	}
																	goto case 5;
																case 30:
																	if (num22 < num21)
																	{
																		goto case 56;
																	}
																	num12 = 5;
																	goto case 5;
																case 56:
																	num23 = (uint)(num21 - num22);
																	num11 = 24;
																	if (tMvWB1Ab8QplFjK3Kd() != null)
																	{
																		continue;
																	}
																	goto case 70;
																case 5:
																case 9:
																	if (num22 >= num21)
																	{
																		goto case 33;
																	}
																	goto IL_02a8;
																case 33:
																	Xg5xLhqQWYmO9wHjQY(hashAlgorithm, fileStream, num17, array4);
																	goto case 26;
																case 24:
																	goto IL_02a8;
																case 65:
																	goto IL_02b8;
																case 1:
																	goto IL_02d5;
																case 62:
																	oH1rnNJX2rtCWil4vG(hashAlgorithm, array4, 0, int_);
																	num12 = 16;
																	goto case 16;
																case 16:
																	fwhH4UoUJ0ZKgVhLBO(fileStream, array4, 0, 128);
																	num11 = 1;
																	if (tMvWB1Ab8QplFjK3Kd() != null)
																	{
																		continue;
																	}
																	goto IL_02d5;
																case 60:
																	array4[66] = 0;
																	num11 = 1;
																	if (tMvWB1Ab8QplFjK3Kd() != null)
																	{
																		continue;
																	}
																	goto case 10;
																case 10:
																	array4[67] = 0;
																	num11 = 62;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 59:
																	num21 = num18 + num14;
																	goto case 37;
																case 37:
																	AfxDFT0JWREM3YgPTu(fileStream, long_);
																	num11 = 22;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0119;
																case 57:
																	array5 = (byte[])KReb0denSSXW7W56GP(object_7, (int)num14);
																	num12 = 23;
																	goto case 23;
																case 23:
																	DoaHRjWsue9oM2L4FH(array5);
																	num11 = 6;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto case 2;
																case 2:
																	num17 -= num20;
																	goto case 29;
																case 48:
																	num16 = CxZr5b1JL8a2AbAV3x(object_7);
																	num11 = 46;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0221;
																case 46:
																	AfxDFT0JWREM3YgPTu(fileStream, num19);
																	num11 = 71;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 43:
																	oH1rnNJX2rtCWil4vG(hashAlgorithm, array4, 0, 128);
																	num11 = 39;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0119;
																case 41:
																	AfxDFT0JWREM3YgPTu(fileStream, num19 + num15 * 40 + 16L);
																	num11 = 31;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0119;
																case 40:
																	array4[34] = 0;
																	num11 = 48;
																	if (tMvWB1Ab8QplFjK3Kd() != null)
																	{
																		continue;
																	}
																	goto case 72;
																case 39:
																	num19 = QJEuD7n85S86RcD4fZ(fileStream);
																	goto case 7;
																case 7:
																	AfxDFT0JWREM3YgPTu(fileStream, 134L);
																	goto case 48;
																case 35:
																	num18 = fT4l9jImv70V2cJ96G(uint_, num16, num19, object_7);
																	goto case 59;
																case 32:
																	gool502OPVjowJN0g8(hashAlgorithm, new byte[0], 0, 0);
																	goto case 25;
																case 25:
																	AfxDFT0JWREM3YgPTu(fileStream, num18);
																	goto case 57;
																case 31:
																	num17 = PdQ6cnQOnWN5YXiVGK(object_7);
																	num11 = 0;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0119;
																case 22:
																	num15 = 0;
																	num11 = 18;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0699;
																case 18:
																case 21:
																	if (num15 >= num16)
																	{
																		num11 = 32;
																		if (LiBL2dUkUOLlBR01HC())
																		{
																			continue;
																		}
																		goto IL_0119;
																	}
																	goto case 41;
																case 20:
																	array4[33] = 0;
																	num11 = 40;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto IL_0119;
																case 17:
																	num14 = PdQ6cnQOnWN5YXiVGK(object_7);
																	num11 = 35;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto case 25;
																case 15:
																	AfxDFT0JWREM3YgPTu(fileStream, num13);
																	num11 = 29;
																	if (tMvWB1Ab8QplFjK3Kd() == null)
																	{
																		continue;
																	}
																	goto IL_0119;
																default:
																	num13 = PdQ6cnQOnWN5YXiVGK(object_7);
																	num11 = 15;
																	if (LiBL2dUkUOLlBR01HC())
																	{
																		continue;
																	}
																	goto case 10;
																case 11:
																	goto IL_0699;
																case 3:
																	goto IL_06bb;
																case 58:
																	goto IL_06cd;
																case 52:
																	goto IL_06e8;
																case 27:
																	goto end_IL_06e8;
																case 55:
																	goto end_IL_06f1;
																case 12:
																	goto end_IL_0706;
																case 19:
																	goto end_IL_0718;
																case 6:
																	flag = !gwJBl6MJA7FQWquL4b(onZkkIlVOi, GCDshu9maFDA7HPiOE(hashAlgorithm), object_, array5);
																	goto end_IL_0726;
																case 50:
																	goto end_IL_0726;
																}
																break;
															}
															goto IL_021b;
															IL_06cd:
															num10 = 112;
															goto IL_06cf;
															IL_02a8:
															num20 = (uint)FOKtQbdy8yctjHURwn(num18 - num22, num17);
															goto IL_02b8;
															IL_02b8:
															Xg5xLhqQWYmO9wHjQY(hashAlgorithm, fileStream, num20, array4);
															num11 = 2;
															if (!LiBL2dUkUOLlBR01HC())
															{
																goto IL_02d5;
															}
															goto IL_056a;
															IL_02d5:
															array4[32] = 0;
															num11 = 20;
															if (!LiBL2dUkUOLlBR01HC())
															{
																goto IL_0119;
															}
															goto IL_056a;
															IL_021b:
															array4[64] = 0;
															goto IL_0221;
															continue;
															end_IL_06e8:
															break;
														}
														continue;
														end_IL_06f1:
														break;
													}
													continue;
													end_IL_0706:
													break;
												}
												continue;
												end_IL_0718:
												break;
											}
											continue;
											end_IL_0726:
											break;
										}
									}
									catch
									{
										int num25 = 1;
										if (LiBL2dUkUOLlBR01HC())
										{
											goto IL_0760;
										}
										goto IL_077f;
										IL_0760:
										while (true)
										{
											switch (num25)
											{
											case 1:
												goto IL_076f;
											case 0:
												break;
											}
											break;
											IL_076f:
											flag = true;
											num25 = 0;
											if (tMvWB1Ab8QplFjK3Kd() == null)
											{
												continue;
											}
											goto IL_077f;
										}
										goto end_IL_0750;
										IL_077f:
										num25 = num26;
										goto IL_0760;
										end_IL_0750:;
									}
									goto case 1;
								case 12:
									try
									{
										VtNVUKGulysZw81C3E object_2 = new VtNVUKGulysZw81C3E((Stream)up7CeYhr5Zn9eCBEmP(x4Dk2IHVmX, "tZCCT4FjPxJF2DKHMn.LMyVrClLbM6E7yqLfH"));
										while (true)
										{
											AfxDFT0JWREM3YgPTu(CqFRpw3H4WgipsCUkX(object_2), 0L);
											while (true)
											{
												byte[] array = (byte[])PnBrbGN8O2RiE07OsT(object_2, (int)TlolCcKiBrkkVNNuK4(CqFRpw3H4WgipsCUkX(object_2)));
												int num5 = 335;
												if (tMvWB1Ab8QplFjK3Kd() != null)
												{
													goto IL_09af;
												}
												goto IL_2364;
												IL_2364:
												while (true)
												{
													switch (num5)
													{
													case 349:
														array2[10] = 42;
														goto case 326;
													case 326:
														array2[10] = 81;
														goto case 82;
													case 82:
														num7 = 34;
														num5 = 184;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 110;
													case 110:
														num7 = 160;
														num5 = 143;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 130;
													case 130:
														num7 = 203;
														goto case 8;
													case 8:
														array2[15] = (byte)num7;
														goto case 344;
													case 344:
														array2[15] = 99;
														goto case 323;
													case 323:
														num7 = 40;
														num6 = 175;
														goto case 175;
													case 175:
														array2[15] = (byte)num7;
														goto case 285;
													case 285:
														array2[16] = 230;
														num5 = 72;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 5;
													case 5:
														array2[29] = 130;
														goto case 301;
													case 301:
														num7 = 90;
														goto case 252;
													case 252:
														array2[29] = (byte)num7;
														goto case 161;
													case 161:
														num7 = 228;
														goto case 291;
													case 291:
														array2[29] = (byte)num7;
														goto case 247;
													case 247:
														num7 = 55;
														goto case 236;
													case 236:
														array2[29] = (byte)num7;
														goto case 343;
													case 343:
														array2[29] = 187;
														num5 = 47;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 280;
													case 280:
														num7 = 119;
														goto case 155;
													case 155:
														array2[30] = (byte)num7;
														goto case 93;
													case 93:
														num7 = 118;
														goto case 294;
													case 294:
														array2[30] = (byte)num7;
														goto case 98;
													case 98:
														num7 = 124;
														goto case 162;
													case 162:
														array2[30] = (byte)num7;
														goto case 283;
													case 283:
														array2[30] = 104;
														num5 = 187;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 18;
													case 18:
														array2[20] = 102;
														goto case 337;
													case 337:
														array2[20] = 221;
														goto case 104;
													case 104:
														array2[21] = 184;
														num6 = 142;
														goto case 142;
													case 142:
														array2[21] = 132;
														goto case 199;
													case 199:
														array2[21] = 96;
														num5 = 6;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 1;
													case 1:
														array2[19] = 115;
														num6 = 202;
														goto case 202;
													case 202:
														array2[19] = 111;
														goto case 122;
													case 122:
														array2[20] = 154;
														num5 = 79;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 348:
														array3[12] = (byte)num8;
														goto case 32;
													case 32:
														num9 = 169;
														num6 = 198;
														goto case 198;
													case 198:
														array3[12] = (byte)num9;
														num5 = 99;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 347:
														num7 = 93;
														goto case 129;
													case 129:
														array2[26] = (byte)num7;
														num5 = 156;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 346:
														array2[3] = 150;
														goto case 110;
													case 345:
														array2[3] = (byte)num7;
														goto case 45;
													case 45:
														array2[3] = 103;
														num5 = 213;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 145;
													case 145:
														array3[13] = (byte)num8;
														goto case 29;
													case 29:
														num8 = 86;
														goto case 295;
													case 295:
														array3[13] = (byte)num8;
														goto case 26;
													case 26:
														num8 = 40;
														num5 = 171;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 51;
													case 51:
														array2[27] = (byte)num7;
														num5 = 106;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 174;
													case 174:
														array2[28] = 92;
														goto case 76;
													case 76:
														num7 = 140;
														num5 = 225;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 162;
													case 342:
														array3[3] = (byte)num8;
														num6 = 299;
														goto case 299;
													case 299:
														num9 = 166;
														goto case 85;
													case 85:
														array3[3] = (byte)num9;
														goto case 124;
													case 124:
														array3[3] = 28;
														num5 = 21;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 336;
													case 336:
														array3[4] = 96;
														goto case 148;
													case 148:
														num9 = 106;
														goto case 132;
													case 132:
														array3[4] = (byte)num9;
														goto case 253;
													case 253:
														num9 = 72;
														goto case 139;
													case 139:
														array3[4] = (byte)num9;
														goto case 33;
													case 33:
														num8 = 129;
														num5 = 159;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 341:
														array2[24] = 183;
														num6 = 197;
														goto case 197;
													case 197:
														num7 = 100;
														num6 = 22;
														goto case 22;
													case 22:
														array2[24] = (byte)num7;
														num5 = 15;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 340:
														array3[7] = 179;
														goto case 292;
													case 292:
														num8 = 114;
														num5 = 281;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 339:
														num8 = 114;
														goto case 342;
													case 338:
														num7 = 116;
														num5 = 83;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 335:
														array2 = new byte[32];
														goto case 303;
													case 303:
														array2[0] = 111;
														goto case 284;
													case 284:
														num7 = 137;
														goto case 23;
													case 23:
														array2[0] = (byte)num7;
														goto case 125;
													case 125:
														num7 = 92;
														num6 = 84;
														goto case 84;
													case 84:
														array2[0] = (byte)num7;
														goto case 332;
													case 332:
														array2[0] = 200;
														num5 = 9;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 52;
													case 52:
														num7 = 185;
														goto case 235;
													case 235:
														array2[0] = (byte)num7;
														num5 = 147;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 334:
														num8 = 155;
														num5 = 25;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 333:
														array2[24] = (byte)num7;
														num5 = 169;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 331:
														array2[26] = (byte)num7;
														goto case 80;
													case 80:
														array2[26] = 41;
														goto case 36;
													case 36:
														array2[27] = 61;
														goto case 327;
													case 327:
														num7 = 180;
														num5 = 87;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 314;
													case 314:
														array2[27] = (byte)num7;
														num5 = 190;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 154;
													case 154:
														array3[13] = 145;
														num5 = 31;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 13;
													case 13:
														array3[15] = (byte)num9;
														num5 = 49;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 330:
														array2[20] = 173;
														num5 = 18;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 329:
														array2[7] = 90;
														goto case 310;
													case 310:
														num7 = 107;
														num6 = 106;
														goto case 106;
													case 106:
														array2[7] = (byte)num7;
														num5 = 63;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 328:
														array2[4] = 78;
														goto case 94;
													case 94:
														array2[4] = 168;
														goto case 101;
													case 101:
														num7 = 160;
														goto case 73;
													case 73:
														array2[4] = (byte)num7;
														num5 = 113;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 137;
													case 137:
														array2[4] = 120;
														num5 = 81;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 18;
													case 325:
														object_6 = array3;
														num6 = 50;
														goto case 50;
													case 50:
														object_3 = (SymmetricAlgorithm)mJMpYCgJnSJQEfTsx5();
														num5 = 123;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 15;
													case 15:
														num7 = 130;
														num6 = 128;
														goto case 128;
													case 128:
														array2[24] = (byte)num7;
														num5 = 189;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 115;
													case 115:
														array2[14] = (byte)num7;
														goto case 251;
													case 251:
														array2[14] = 151;
														num5 = 53;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 322:
														array3[11] = (byte)num9;
														goto case 120;
													case 120:
														num8 = 85;
														num5 = 348;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 321:
														array3[7] = 102;
														goto case 340;
													case 320:
														num8 = 115;
														goto case 282;
													case 282:
														array3[7] = (byte)num8;
														goto case 12;
													case 12:
														array3[7] = 169;
														goto case 321;
													case 319:
														array2[31] = (byte)num7;
														goto case 205;
													case 205:
														array2[31] = 139;
														num5 = 311;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 318:
														num7 = 108;
														goto case 153;
													case 153:
														array2[23] = (byte)num7;
														num5 = 167;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 142;
													case 317:
														num7 = 122;
														goto case 170;
													case 170:
														array2[11] = (byte)num7;
														goto case 290;
													case 290:
														array2[11] = 148;
														num5 = 258;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 316:
														array3[10] = 122;
														num5 = 9;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 315:
														array2[17] = 198;
														goto case 3;
													case 3:
														num7 = 89;
														goto case 296;
													case 296:
														array2[18] = (byte)num7;
														num5 = 210;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 13;
													case 313:
														array2[27] = (byte)num7;
														goto case 237;
													case 237:
														num7 = 148;
														num5 = 163;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 312:
														array2[25] = 137;
														goto case 166;
													case 166:
														array2[25] = 203;
														goto case 180;
													case 180:
														array2[25] = 233;
														num5 = 65;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 311:
														array2[31] = 164;
														num5 = 150;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 309:
														num9 = 194;
														num5 = 116;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 308:
														array2[13] = 103;
														num5 = 103;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 307:
														array3[14] = 184;
														num5 = 44;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 18;
													case 306:
														array2[10] = (byte)num7;
														goto case 349;
													case 305:
														array2[1] = (byte)num7;
														goto case 266;
													case 266:
														num7 = 136;
														goto case 10;
													case 10:
														array2[1] = (byte)num7;
														num5 = 287;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 304:
														num7 = 139;
														goto case 78;
													case 78:
														array2[7] = (byte)num7;
														goto case 329;
													case 302:
														array2[9] = 198;
														goto case 230;
													case 230:
														num7 = 94;
														num5 = 306;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 300:
														array3[5] = 133;
														goto case 152;
													case 152:
														num8 = 202;
														goto case 42;
													case 42:
														array3[5] = (byte)num8;
														num5 = 185;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 298:
														num9 = 141;
														goto case 272;
													case 272:
														array3[1] = (byte)num9;
														num5 = 46;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 297:
														array2[22] = 62;
														goto case 318;
													case 293:
														num7 = 146;
														num5 = 126;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 289:
														array3[1] = (byte)num9;
														goto case 240;
													case 240:
														array3[2] = 114;
														num6 = 181;
														goto case 181;
													case 181:
														array3[2] = 164;
														goto case 203;
													case 203:
														num9 = 123;
														num5 = 111;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 12;
													case 288:
														num9 = 149;
														num5 = 241;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 287:
														num7 = 181;
														goto case 223;
													case 223:
														array2[1] = (byte)num7;
														num5 = 28;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 254;
													case 254:
														array2[1] = 167;
														goto case 48;
													case 48:
														array2[1] = 3;
														goto case 267;
													case 267:
														array2[2] = 37;
														num6 = 200;
														goto case 200;
													case 200:
														num7 = 169;
														goto case 194;
													case 194:
														array2[2] = (byte)num7;
														num5 = 62;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 114;
													case 114:
														array2[2] = 155;
														num6 = 67;
														goto case 67;
													case 67:
														array2[2] = 85;
														goto case 107;
													case 107:
														num7 = 3;
														num6 = 262;
														goto case 262;
													case 262:
														array2[2] = (byte)num7;
														goto case 112;
													case 112:
														num7 = 138;
														num5 = 345;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 286:
														num8 = 120;
														goto case 90;
													case 90:
														array3[10] = (byte)num8;
														num5 = 119;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 281:
														array3[7] = (byte)num8;
														num5 = 88;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 13;
													case 279:
														array2[25] = 84;
														goto case 17;
													case 17:
														array2[25] = 162;
														num5 = 312;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 59;
													case 59:
														array2[8] = 179;
														goto case 58;
													case 58:
														array2[8] = 141;
														goto case 195;
													case 195:
														num7 = 251;
														goto case 228;
													case 228:
														array2[8] = (byte)num7;
														num5 = 34;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 238;
													case 238:
														num7 = 130;
														num5 = 121;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 278:
														array3[13] = (byte)num8;
														num5 = 154;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 154;
													case 277:
														array3[8] = 215;
														goto case 182;
													case 182:
														num9 = 46;
														goto case 255;
													case 255:
														array3[9] = (byte)num9;
														num5 = 139;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 186;
													case 186:
														array3[9] = 162;
														num5 = 72;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 77;
													case 77:
														num9 = 10;
														num5 = 136;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 276:
														num7 = 32;
														num5 = 118;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 275:
														array3[0] = (byte)num9;
														goto case 244;
													case 244:
														num9 = 186;
														num5 = 61;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 274:
														num7 = 150;
														num5 = 11;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 273:
														array2[12] = (byte)num7;
														goto case 138;
													case 138:
														array2[12] = 116;
														goto case 338;
													case 271:
														num7 = 126;
														num6 = 305;
														goto case 305;
													case 270:
														array2[23] = (byte)num7;
														goto case 16;
													case 16:
														array2[23] = 171;
														goto case 341;
													case 269:
														array2[13] = (byte)num7;
														num5 = 308;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 268:
														array3[14] = 113;
														num5 = 307;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 125;
													case 265:
														num8 = 135;
														num5 = 22;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 37;
													case 37:
														array3[12] = (byte)num8;
														goto case 206;
													case 206:
														array3[12] = 74;
														num5 = 250;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 264:
														array2[22] = 65;
														num5 = 57;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 263:
														transform = (ICryptoTransform)Kn6BALi52rAKnekOO2(object_3, object_4, object_6);
														num5 = 248;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 261:
														num9 = 199;
														goto case 71;
													case 71:
														array3[2] = (byte)num9;
														goto case 243;
													case 243:
														num8 = 148;
														goto case 227;
													case 227:
														array3[3] = (byte)num8;
														goto case 221;
													case 221:
														array3[3] = 46;
														goto case 339;
													case 260:
														array2[20] = (byte)num7;
														goto case 293;
													case 259:
														array2[11] = 225;
														num5 = 43;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 258:
														array2[11] = 135;
														goto case 259;
													case 257:
														num9 = 93;
														num5 = 322;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 166;
													case 256:
														num7 = 88;
														goto case 319;
													case 250:
														num8 = 107;
														num6 = 278;
														goto case 278;
													case 249:
														array3[12] = (byte)num9;
														goto case 265;
													case 248:
														stream = (Stream)MRexKMZmlYYxkTf7hV();
														goto case 40;
													case 40:
														object_5 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
														num5 = 20;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 75;
													case 246:
														array3[11] = 165;
														num5 = 257;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 245:
														num7 = 188;
														goto case 20;
													case 20:
														array2[5] = (byte)num7;
														goto case 141;
													case 141:
														array2[5] = 190;
														num5 = 179;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 178;
													case 178:
														array2[21] = (byte)num7;
														goto case 239;
													case 239:
														array2[21] = 85;
														goto case 264;
													case 242:
														array2[5] = (byte)num7;
														num5 = 245;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 241:
														array3[1] = (byte)num9;
														num6 = 56;
														goto case 56;
													case 56:
														num9 = 107;
														num5 = 289;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 234:
														array2[12] = 222;
														goto case 149;
													case 149:
														num7 = 85;
														num5 = 269;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 171;
													case 171:
														array3[13] = (byte)num8;
														num5 = 268;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 233:
														num9 = 102;
														goto case 275;
													case 232:
														array3[11] = 127;
														num5 = 41;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 231:
														array3[4] = 156;
														goto case 30;
													case 30:
														array3[4] = 17;
														num5 = 109;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 51;
													case 229:
														array3[14] = 178;
														goto case 108;
													case 108:
														num8 = 221;
														num6 = 222;
														goto case 222;
													case 222:
														array3[14] = (byte)num8;
														goto case 211;
													case 211:
														num9 = 137;
														goto case 13;
													case 226:
														array2[3] = (byte)num7;
														goto case 346;
													case 225:
														array2[28] = (byte)num7;
														num5 = 19;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 224:
														num7 = 117;
														goto case 207;
													case 207:
														array2[7] = (byte)num7;
														goto case 304;
													case 220:
														array3[1] = 120;
														goto case 288;
													case 219:
														array2[17] = 97;
														goto case 315;
													case 218:
														num7 = 124;
														goto case 14;
													case 14:
														array2[9] = (byte)num7;
														num5 = 21;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 134;
													case 134:
														num7 = 170;
														goto case 27;
													case 27:
														array2[9] = (byte)num7;
														goto case 302;
													case 217:
														num7 = 143;
														num5 = 92;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 216:
														num7 = 102;
														num5 = 60;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 115;
													case 214:
														num9 = 173;
														goto case 55;
													case 55:
														array3[15] = (byte)num9;
														num5 = 168;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 213:
														num7 = 146;
														num6 = 226;
														goto case 226;
													case 212:
														num7 = 131;
														goto case 7;
													case 7:
														array2[26] = (byte)num7;
														num6 = 193;
														goto case 193;
													case 193:
														num7 = 157;
														num5 = 331;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 210:
														array2[18] = 122;
														num5 = 14;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 38;
													case 38:
														array2[18] = 163;
														goto case 100;
													case 100:
														num7 = 119;
														goto case 177;
													case 177:
														array2[18] = (byte)num7;
														num5 = 89;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 5;
													case 204:
														array3[1] = (byte)num9;
														num5 = 113;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 201:
														array2[25] = (byte)num7;
														num5 = 279;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 77;
													case 196:
														array2[16] = (byte)num7;
														num5 = 165;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 192:
														array3[10] = (byte)num8;
														num5 = 316;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 191:
														num7 = 126;
														num6 = 64;
														goto case 64;
													case 64:
														array2[19] = (byte)num7;
														num5 = 1;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 1;
													case 190:
														num7 = 138;
														num5 = 313;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 189:
														array2[24] = 154;
														num6 = 96;
														goto case 96;
													case 96:
														num7 = 142;
														goto case 333;
													case 188:
														num9 = 156;
														goto case 249;
													case 187:
														array2[30] = 183;
														goto case 133;
													case 133:
														array2[31] = 116;
														num5 = 256;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto case 59;
													case 185:
														num8 = 150;
														goto case 157;
													case 157:
														array3[6] = (byte)num8;
														goto case 140;
													case 140:
														num9 = 102;
														num5 = 127;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 184:
														array2[11] = (byte)num7;
														num5 = 317;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 183:
														array2[7] = 163;
														num6 = 224;
														goto case 224;
													case 179:
														num7 = 222;
														goto case 39;
													case 39:
														array2[5] = (byte)num7;
														goto case 217;
													case 176:
														array2[17] = 152;
														goto case 219;
													case 173:
														array2[14] = 173;
														goto case 21;
													case 21:
														num7 = 8;
														goto case 54;
													case 54:
														array2[14] = (byte)num7;
														num5 = 47;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 130;
													case 172:
														array3[15] = 168;
														goto case 105;
													case 105:
														array3[15] = 186;
														num6 = 325;
														goto case 325;
													case 169:
														num7 = 24;
														num5 = 201;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 168:
														array3[15] = 100;
														goto case 172;
													case 167:
														array2[23] = 157;
														goto case 2;
													case 2:
														num7 = 172;
														goto case 270;
													case 165:
														array2[16] = 241;
														num5 = 176;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 164:
														array3[6] = (byte)num9;
														num5 = 117;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 112;
													case 163:
														array2[27] = (byte)num7;
														goto case 87;
													case 87:
														num7 = 187;
														goto case 51;
													case 160:
														array3 = new byte[16];
														num6 = 86;
														goto case 86;
													case 86:
														array3[0] = 128;
														num5 = 233;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 159:
														array3[4] = (byte)num8;
														num5 = 54;
														if (!LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 231;
													case 158:
														num7 = 83;
														goto case 102;
													case 102:
														array2[6] = (byte)num7;
														num5 = 135;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 156:
														array2[26] = 123;
														goto case 212;
													case 151:
														array3[12] = (byte)num8;
														num5 = 188;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 150:
														object_4 = array2;
														num6 = 160;
														goto case 160;
													case 147:
														array2[1] = 145;
														num5 = 271;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 146:
														array2[28] = 161;
														goto case 5;
													case 144:
														array2[4] = (byte)num7;
														goto case 328;
													case 143:
														array2[3] = (byte)num7;
														num5 = 0;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto default;
													default:
														array2[4] = 138;
														num5 = 91;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 136:
														array3[9] = (byte)num9;
														num5 = 286;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 135:
														array2[6] = 28;
														goto case 183;
													case 131:
														array3[8] = 162;
														goto case 309;
													case 127:
														array3[6] = (byte)num9;
														goto case 97;
													case 97:
														num9 = 96;
														num5 = 66;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 126:
														array2[20] = (byte)num7;
														num5 = 330;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 123:
														bP8gF1bqUs5cUm6EsF(object_3, CipherMode.CBC);
														goto case 263;
													case 121:
														array2[9] = (byte)num7;
														goto case 218;
													case 119:
														num8 = 140;
														goto case 192;
													case 118:
														array2[13] = (byte)num7;
														goto case 216;
													case 117:
														array3[7] = 175;
														goto case 320;
													case 116:
														array3[8] = (byte)num9;
														goto case 277;
													case 113:
														array3[1] = 128;
														goto case 220;
													case 111:
														array3[2] = (byte)num9;
														goto case 261;
													case 109:
														array3[5] = 149;
														num5 = 300;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 103:
														array2[13] = 139;
														goto case 276;
													case 99:
														num8 = 83;
														goto case 151;
													case 95:
														array2[12] = 134;
														goto case 234;
													case 92:
														array2[6] = (byte)num7;
														goto case 34;
													case 34:
														array2[6] = 98;
														num5 = 274;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 104;
													case 91:
														num7 = 162;
														num5 = 144;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 89:
														array2[19] = 120;
														goto case 191;
													case 88:
														array3[8] = 79;
														goto case 131;
													case 83:
														array2[12] = (byte)num7;
														num5 = 95;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 81:
														num7 = 162;
														num5 = 242;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 3;
													case 79:
														num7 = 81;
														num5 = 260;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 72:
														num7 = 116;
														goto case 196;
													case 70:
														num7 = 64;
														goto case 178;
													case 66:
														array3[6] = (byte)num9;
														goto case 28;
													case 28:
														num9 = 157;
														goto case 164;
													case 65:
														array2[26] = 157;
														goto case 347;
													case 63:
														array2[7] = 103;
														num5 = 59;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 62:
														num9 = 156;
														goto case 4;
													case 4:
														array3[11] = (byte)num9;
														goto case 246;
													case 61:
														array3[0] = (byte)num9;
														goto case 334;
													case 60:
														num7 = 219;
														num5 = 273;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 57:
														array2[22] = 245;
														goto case 297;
													case 53:
														array2[14] = 96;
														goto case 173;
													case 49:
														num8 = 130;
														goto case 35;
													case 35:
														array3[15] = (byte)num8;
														goto case 214;
													case 46:
														num9 = 146;
														num5 = 204;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto case 26;
													case 44:
														array3[14] = 125;
														goto case 229;
													case 43:
														array2[12] = 160;
														goto case 60;
													case 41:
														array3[11] = 168;
														goto case 62;
													case 31:
														num8 = 112;
														goto case 145;
													case 25:
														array3[0] = (byte)num8;
														goto case 24;
													case 24:
														array3[0] = 106;
														num5 = 298;
														if (LiBL2dUkUOLlBR01HC())
														{
															continue;
														}
														goto IL_09af;
													case 19:
														array2[28] = 124;
														num5 = 16;
														if (tMvWB1Ab8QplFjK3Kd() != null)
														{
															continue;
														}
														goto case 146;
													case 11:
														array2[6] = (byte)num7;
														num5 = 158;
														if (tMvWB1Ab8QplFjK3Kd() == null)
														{
															continue;
														}
														goto IL_09af;
													case 9:
														array3[10] = 220;
														num6 = 232;
														goto case 232;
													case 6:
														array2[21] = 189;
														goto case 70;
													case 215:
														break;
													case 208:
														goto end_IL_28e6;
													case 75:
														eRnR2eDYIGH5o8fZqC(object_5, array, 0, array.Length);
														goto case 74;
													case 74:
														YK5PK97K865EZ6MCIV(object_5);
														num6 = 68;
														goto case 68;
													case 68:
														mZyw70X38IqJIsGYS5(onZkkIlVOi, HkrbSIY6wuxq79VQVp(bg9pjbsTgmr4Y2ibm7(), euC1OhBa9JC3mmLYAV(stream)));
														goto case 69;
													case 69:
														BBXoTY69aIvaEMFrUF(stream);
														goto case 47;
													case 47:
														BBXoTY69aIvaEMFrUF(object_5);
														goto case 209;
													case 209:
														CL3Bc4cMAuqGeqC8mA(object_2);
														goto end_IL_2911;
													case 324:
														goto end_IL_2911;
													}
													break;
												}
												continue;
												IL_09af:
												num5 = num6;
												goto IL_2364;
												continue;
												end_IL_28e6:
												break;
											}
											continue;
											end_IL_2911:
											break;
										}
									}
									catch
									{
										if (tMvWB1Ab8QplFjK3Kd() == null)
										{
											goto IL_298d;
										}
										goto IL_299c;
										IL_299c:
										switch (0)
										{
										case 1:
											goto end_IL_297c;
										}
										goto IL_298d;
										IL_298d:
										do
										{
											flag = true;
											_ = 1;
										}
										while (tMvWB1Ab8QplFjK3Kd() != null);
										goto IL_299c;
										end_IL_297c:;
									}
									goto case 16;
								case 11:
									object_ = null;
									goto case 4;
								case 4:
									try
									{
										hashAlgorithm = (HashAlgorithm)tSbCyZyH75nUOoEqUu();
										int num3 = 4;
										if (tMvWB1Ab8QplFjK3Kd() != null)
										{
											goto IL_29e3;
										}
										goto IL_2a01;
										IL_2a01:
										while (true)
										{
											switch (num3)
											{
											case 4:
												object_ = (string)LtIoVDPZRDWqQ3ojY4("SHA1");
												num3 = 1;
												if (tMvWB1Ab8QplFjK3Kd() == null)
												{
													continue;
												}
												break;
											case 1:
												if (FmcJK3fkL444CAkNBc(text))
												{
													num3 = 0;
													if (tMvWB1Ab8QplFjK3Kd() == null)
													{
														continue;
													}
													break;
												}
												return;
											default:
												goto end_IL_2a01;
											case 3:
												return;
											}
											goto IL_29e3;
											continue;
											end_IL_2a01:
											break;
										}
										goto end_IL_29b4;
										IL_29e3:
										num3 = num4;
										goto IL_2a01;
										end_IL_29b4:;
									}
									catch
									{
										if (LiBL2dUkUOLlBR01HC())
										{
											switch (0)
											{
											}
										}
										return;
									}
									goto case 8;
								case 8:
									flag = false;
									num = 12;
									goto case 12;
								case 10:
									if (text == null)
									{
										return;
									}
									goto case 2;
								case 2:
									if (TG3HhVRBBs4wpds9sh(text) != 0)
									{
										hashAlgorithm = null;
										goto case 11;
									}
									return;
								case 16:
									if (!flag)
									{
										goto IL_00a4;
									}
									goto case 1;
								case 1:
									if (!flag)
									{
										goto IL_00b3;
									}
									goto case 9;
								case 13:
									return;
								case 9:
									throw new Exception((string?)zTG54gaKSfOXFblohT(W8jKdpFvs6gP4lHCFR(FF971FpWPqHy7OdZQK(dFlohZukXVlLNdO3Wm(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)), " is tampered."));
								case 0:
									return;
								}
								break;
								IL_00a4:
								num2 = 15;
								if (tMvWB1Ab8QplFjK3Kd() == null)
								{
									continue;
								}
								goto IL_00c3;
								IL_00b3:
								flag = false;
								num2 = 0;
								if (tMvWB1Ab8QplFjK3Kd() == null)
								{
									continue;
								}
								goto IL_00c3;
							}
							break;
						}
						break;
					}
					break;
				}
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
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554466)).Assembly.GetManifestResourceStream("IeHpNZRs97sAos51yn.LlNJ7Ms0NHFxBorOWt"));
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
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554466)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(16777236));
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
		int num = 163;
		VtNVUKGulysZw81C3E object_ = default(VtNVUKGulysZw81C3E);
		byte[] array3 = default(byte[]);
		int num5 = default(int);
		byte[] array4 = default(byte[]);
		uint num17 = default(uint);
		int num8 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		byte[] array6 = default(byte[]);
		byte[] array = default(byte[]);
		uint num23 = default(uint);
		byte[] array5 = default(byte[]);
		int num21 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		byte[] array7 = default(byte[]);
		int int_ = default(int);
		int num28 = default(int);
		int num20 = default(int);
		int num15 = default(int);
		uint num16 = default(uint);
		uint num12 = default(uint);
		uint num27 = default(uint);
		uint num22 = default(uint);
		uint num26 = default(uint);
		int num24 = default(int);
		int num14 = default(int);
		int num13 = default(int);
		byte[] array2 = default(byte[]);
		int num25 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		uint num11 = default(uint);
		string result = default(string);
		int num4 = default(int);
		while (true)
		{
			IL_2967:
			int num2;
			if (((Array)HkLkNdDPtB).Length != 0)
			{
				num2 = 162;
				if (b1p0PaTYErpom6373D() != null)
				{
					goto IL_0048;
				}
				goto IL_225a;
			}
			goto IL_293a;
			IL_0048:
			num2 = num;
			goto IL_225a;
			IL_293a:
			object_ = new VtNVUKGulysZw81C3E((Stream)fkIwNwmVKi5yRqEQdh(x4Dk2IHVmX, "jdY3HSeFsB1Ym8fjXN.Lgxh5sy8jgC4EfUdEq"));
			goto IL_2910;
			IL_2910:
			paZQQfdeFtplXyg7G3(kSkTnLtwTIW7EkyyQR(object_), 0L);
			num2 = 139;
			if (!VNbvZDI489boxOicgD())
			{
				goto IL_0048;
			}
			goto IL_225a;
			IL_225a:
			while (true)
			{
				switch (num2)
				{
				case 426:
					array3[6] = 199;
					goto case 349;
				case 349:
					array3[7] = 132;
					goto case 185;
				case 185:
					array3[7] = 14;
					num2 = 65;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 425:
					num5 = 134;
					num2 = 62;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 424:
					YpD0Fd4TjMFWqFa2kT(object_);
					num2 = 334;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 423:
					array4[1] = (byte)num5;
					num2 = 116;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 218:
				case 422:
					num17 = num11;
					num2 = 81;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 421:
					num8 = 128;
					num2 = 343;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 420:
					array4[0] = 122;
					goto case 220;
				case 220:
					num9 = 156;
					goto case 54;
				case 54:
					array4[0] = (byte)num9;
					goto case 356;
				case 356:
					num5 = 40;
					num2 = 26;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 419:
					num8 = 166;
					goto case 242;
				case 242:
					array3[10] = (byte)num8;
					goto case 288;
				case 288:
					array3[10] = 228;
					num2 = 38;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 418:
					num10 = 94;
					goto case 215;
				case 215:
					array3[27] = (byte)num10;
					num2 = 394;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 417:
					array4[15] = 116;
					num2 = 291;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 416:
					array4[6] = (byte)num5;
					num2 = 370;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 415:
					num10 = 90;
					num2 = 260;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 282;
				case 282:
					array3[30] = (byte)num10;
					num2 = 23;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 299;
				case 299:
					num8 = 245;
					num = 342;
					goto case 342;
				case 342:
					array3[30] = (byte)num8;
					goto case 219;
				case 219:
					num8 = 143;
					num = 404;
					goto case 404;
				case 404:
					array3[31] = (byte)num8;
					num2 = 238;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 414:
					num8 = 97;
					goto case 214;
				case 214:
					array3[14] = (byte)num8;
					num2 = 236;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 413:
					array3[20] = 156;
					num2 = 196;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 203;
				case 203:
					num8 = 50;
					num2 = 258;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 364;
				case 364:
					array3[20] = (byte)num8;
					goto case 69;
				case 69:
					array3[21] = 127;
					goto case 97;
				case 97:
					num10 = 138;
					num2 = 411;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 58;
				case 224:
					transform = (ICryptoTransform)lbMZqQWSUJ8k7hp4dX(object_3, array6, array);
					num2 = 93;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 90;
				case 90:
					num10 = 61;
					goto case 167;
				case 167:
					array3[20] = (byte)num10;
					goto case 157;
				case 157:
					array3[20] = 112;
					num = 413;
					goto case 413;
				case 58:
					EeOHvggonRKXUnIIBJ(object_3, CipherMode.CBC);
					goto case 224;
				case 412:
					num23 |= array5[^(1 + num21)];
					goto case 318;
				case 318:
					num21++;
					num2 = 61;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 411:
					array3[21] = (byte)num10;
					goto case 346;
				case 346:
					array3[21] = 82;
					num2 = 156;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 182;
				case 182:
					num8 = 83;
					num2 = 117;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 410:
					array3[31] = 65;
					num2 = 176;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 409:
					array4[10] = (byte)num5;
					goto case 86;
				case 86:
					array4[11] = 139;
					goto case 230;
				case 230:
					array4[11] = 124;
					num2 = 101;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 77:
				case 408:
					num6++;
					goto case 51;
				case 51:
				case 244:
					if (num6 >= num7)
					{
						num2 = 94;
						if (!VNbvZDI489boxOicgD())
						{
							continue;
						}
						goto case 103;
					}
					goto case 250;
				case 103:
					HkLkNdDPtB = array7;
					goto case 162;
				case 162:
				case 196:
					int_ = XA6xRAkllA3Wf6Dhol(HkLkNdDPtB, int_0);
					num2 = 277;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 250:
					num28 = num6 % num20;
					goto case 154;
				case 154:
					num15 = num6 * 4;
					goto case 52;
				case 52:
					num16 = (uint)(num28 * 4);
					goto case 4;
				case 4:
					num12 = (uint)((array6[num16 + 3] << 24) | (array6[num16 + 2] << 16) | (array6[num16 + 1] << 8) | array6[num16]);
					num2 = 125;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 159;
				case 159:
					num27 = 255u;
					num2 = 115;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 407:
					num8 = 86;
					num = 42;
					goto case 42;
				case 42:
					array3[4] = (byte)num8;
					goto case 276;
				case 276:
					array3[5] = 165;
					goto case 266;
				case 266:
					num8 = 144;
					goto case 210;
				case 210:
					array3[5] = (byte)num8;
					num2 = 396;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 4;
				case 406:
					num10 = 69;
					goto case 119;
				case 119:
					array3[1] = (byte)num10;
					goto case 15;
				case 15:
					num8 = 148;
					goto case 88;
				case 88:
					array3[1] = (byte)num8;
					goto case 304;
				case 304:
					num8 = 111;
					num2 = 66;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 405:
					array4[3] = 158;
					goto case 49;
				case 49:
					num5 = 84;
					goto case 357;
				case 357:
					array4[3] = (byte)num5;
					goto case 2;
				case 2:
					num5 = 102;
					goto case 306;
				case 306:
					array4[3] = (byte)num5;
					goto case 229;
				case 229:
					num5 = 73;
					num2 = 160;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 403:
					array7[num15 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					num2 = 280;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 402:
					array3[19] = 77;
					num2 = 253;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 401:
					array3[20] = 92;
					goto case 90;
				case 400:
					array3[0] = (byte)num8;
					num2 = 386;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 399:
					num5 = 120;
					num2 = 302;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 398:
					array4[5] = 127;
					goto case 252;
				case 252:
					num5 = 59;
					goto case 257;
				case 257:
					array4[5] = (byte)num5;
					num2 = 352;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 397:
					num8 = 90;
					goto case 150;
				case 150:
					array3[26] = (byte)num8;
					num2 = 57;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 396:
					num8 = 94;
					num = 297;
					goto case 297;
				case 297:
					array3[5] = (byte)num8;
					num2 = 225;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 83;
				case 83:
					num5 = 136;
					num = 385;
					goto case 385;
				case 385:
					array4[7] = (byte)num5;
					num2 = 148;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 395:
					array3[18] = (byte)num10;
					goto case 29;
				case 29:
					array3[19] = 101;
					num2 = 31;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 394:
					num10 = 155;
					goto case 278;
				case 278:
					array3[27] = (byte)num10;
					goto case 330;
				case 330:
					array3[27] = 12;
					num = 130;
					goto case 130;
				case 130:
					array3[28] = 61;
					num2 = 421;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 393:
					num10 = 144;
					num = 265;
					goto case 265;
				case 265:
					array3[3] = (byte)num10;
					num2 = 20;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 392:
					num26 = num11 ^ num23;
					num2 = 371;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 198:
					if (num24 <= 0)
					{
						goto case 248;
					}
					goto case 47;
				case 248:
					array7[num15 + num24] = (byte)((num26 & num27) >> num14);
					goto case 25;
				case 25:
					num24++;
					num2 = 188;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 254;
				case 254:
				case 391:
					if (num24 >= num13)
					{
						num2 = 28;
						if (b1p0PaTYErpom6373D() != null)
						{
							continue;
						}
						goto case 77;
					}
					goto case 198;
				case 47:
					num27 <<= 8;
					num2 = 79;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 390:
					array4[14] = 164;
					num2 = 2;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 341;
				case 341:
					array4[14] = 83;
					num2 = 327;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 29;
				case 389:
					array3[25] = (byte)num8;
					goto case 347;
				case 347:
					array3[25] = 92;
					goto case 50;
				case 50:
					array3[25] = 190;
					goto case 18;
				case 18:
					num10 = 144;
					goto case 104;
				case 104:
					array3[26] = (byte)num10;
					goto case 397;
				case 388:
					array3[24] = (byte)num8;
					goto case 5;
				case 5:
					array3[24] = 160;
					goto case 311;
				case 311:
					num8 = 144;
					goto case 377;
				case 377:
					array3[24] = (byte)num8;
					num2 = 122;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 387:
					array4[2] = (byte)num5;
					num2 = 1;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 1;
				case 1:
					num9 = 139;
					goto case 307;
				case 307:
					array4[2] = (byte)num9;
					goto case 153;
				case 153:
					array4[2] = 55;
					num = 271;
					goto case 271;
				case 271:
					array4[3] = 144;
					num2 = 405;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 281;
				case 281:
					array4[0] = 87;
					goto case 420;
				case 386:
					array3[0] = 152;
					goto case 201;
				case 201:
					array3[0] = 164;
					num2 = 179;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 379;
				case 379:
					array3[0] = 192;
					num2 = 46;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 232;
				case 232:
					array3[1] = 104;
					goto case 406;
				case 384:
					num9 = 136;
					goto case 168;
				case 168:
					array4[1] = (byte)num9;
					num2 = 137;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 45;
				case 45:
					array[9] = array2[4];
					goto case 362;
				case 362:
					array[11] = array2[5];
					goto case 202;
				case 202:
					array[13] = array2[6];
					goto case 361;
				case 361:
					array[15] = array2[7];
					goto case 301;
				case 301:
					num25 = 0;
					goto case 173;
				case 173:
				case 326:
					if (num25 >= array.Length)
					{
						num = 287;
						goto case 287;
					}
					goto case 208;
				case 287:
					if (int_0 == -1)
					{
						num2 = 68;
						if (b1p0PaTYErpom6373D() == null)
						{
							continue;
						}
						goto IL_0048;
					}
					goto case 245;
				case 245:
					num13 = array5.Length % 4;
					num2 = 133;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 208:
					array6[num25] = (byte)(array6[num25] ^ array[num25]);
					goto case 351;
				case 351:
					num25++;
					num2 = 173;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 383:
					array3[15] = 93;
					num2 = 60;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 382:
					array3[29] = 134;
					num = 40;
					goto case 40;
				case 40:
					array3[30] = 219;
					goto case 108;
				case 108:
					array3[30] = 127;
					goto case 233;
				case 233:
					array3[30] = 110;
					num2 = 415;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 381:
					num10 = 139;
					num2 = 37;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 46;
				case 46:
					array3[10] = (byte)num10;
					goto case 419;
				case 380:
					array3[28] = 197;
					num2 = 61;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 123;
				case 123:
					array3[28] = 16;
					goto case 59;
				case 59:
					array3[29] = 138;
					num2 = 74;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 205;
				case 205:
					array3[29] = 145;
					goto case 366;
				case 366:
					num10 = 158;
					num2 = 339;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 378:
					array4[4] = 234;
					goto case 321;
				case 321:
					array4[4] = 146;
					num2 = 78;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 376:
					num8 = 113;
					goto case 367;
				case 367:
					array3[18] = (byte)num8;
					num2 = 368;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 295;
				case 295:
					array3[24] = 231;
					goto case 179;
				case 179:
					num8 = 114;
					goto case 184;
				case 184:
					array3[24] = (byte)num8;
					num2 = 64;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 375:
					array3[7] = 124;
					num = 177;
					goto case 177;
				case 177:
					array3[7] = 146;
					num2 = 171;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 374:
					array4[13] = (byte)num9;
					goto case 226;
				case 226:
					num9 = 88;
					num2 = 237;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 256;
				case 256:
					array4[13] = (byte)num9;
					num = 22;
					goto case 22;
				case 22:
					array4[13] = 160;
					goto case 325;
				case 325:
					array4[13] = 196;
					num = 192;
					goto case 192;
				case 192:
					num9 = 158;
					goto case 231;
				case 231:
					array4[14] = (byte)num9;
					goto case 390;
				case 61:
				case 373:
					if (num21 >= num13)
					{
						num2 = 422;
						if (b1p0PaTYErpom6373D() == null)
						{
							continue;
						}
						goto IL_0048;
					}
					goto case 107;
				case 107:
					if (num21 <= 0)
					{
						goto case 412;
					}
					num2 = 172;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 247;
				case 247:
					num23 <<= 8;
					num2 = 412;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 372:
					array3[15] = (byte)num10;
					goto case 335;
				case 335:
					array3[16] = 92;
					goto case 222;
				case 222:
					array3[16] = 124;
					num2 = 55;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 73;
				case 73:
					array3[16] = 89;
					goto case 259;
				case 259:
					num8 = 104;
					num = 344;
					goto case 344;
				case 344:
					array3[17] = (byte)num8;
					goto case 131;
				case 131:
					num8 = 107;
					goto case 332;
				case 332:
					array3[17] = (byte)num8;
					goto case 56;
				case 56:
					num10 = 26;
					num = 166;
					goto case 166;
				case 166:
					array3[17] = (byte)num10;
					goto case 193;
				case 193:
					num8 = 116;
					goto case 328;
				case 328:
					array3[17] = (byte)num8;
					num = 89;
					goto case 89;
				case 89:
					num10 = 104;
					goto case 7;
				case 7:
					array3[18] = (byte)num10;
					goto case 223;
				case 223:
					array3[18] = 140;
					goto case 376;
				case 371:
					num24 = 0;
					num2 = 227;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 254;
				case 370:
					array4[6] = 74;
					goto case 92;
				case 92:
					num5 = 101;
					num2 = 309;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 369:
					num16 = 0u;
					goto case 43;
				case 43:
					num6 = 0;
					num2 = 244;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 219;
				case 368:
					array3[18] = 168;
					goto case 41;
				case 41:
					num10 = 197;
					goto case 395;
				case 365:
					array3[26] = 177;
					num2 = 418;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 363:
					num23 = (uint)((array5[num16 + 3] << 24) | (array5[num16 + 2] << 16) | (array5[num16 + 1] << 8) | array5[num16]);
					num2 = 218;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 360:
					array4[12] = (byte)num9;
					num2 = 246;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 359:
					array = array4;
					goto case 172;
				case 172:
					SAwNvoPLDoGUYZKqjK(array);
					goto case 114;
				case 114:
					array2 = (byte[])Gk2Z0Xx4FKqDKT4nls(pEcLGB62tRpMtpQxQM(x4Dk2IHVmX));
					num2 = 273;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 290;
				case 290:
					if (array2 == null)
					{
						goto case 301;
					}
					goto case 14;
				case 14:
					if (array2.Length <= 0)
					{
						goto case 301;
					}
					goto case 310;
				case 310:
					array[1] = array2[0];
					goto case 109;
				case 109:
					array[3] = array2[1];
					goto case 12;
				case 12:
					array[5] = array2[2];
					num2 = 0;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 358:
					array3[3] = (byte)num8;
					goto case 355;
				case 355:
					array3[3] = 24;
					num2 = 24;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 14;
				case 353:
					num5 = 14;
					goto case 416;
				case 352:
					array4[6] = 85;
					goto case 292;
				case 292:
					num9 = 132;
					goto case 317;
				case 317:
					array4[6] = (byte)num9;
					goto case 353;
				case 350:
					array3[19] = (byte)num8;
					goto case 300;
				case 300:
					array3[19] = 101;
					goto case 402;
				case 348:
					num9 = 114;
					num2 = 144;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 345:
					num5 = 90;
					goto case 423;
				case 343:
					array3[28] = (byte)num8;
					goto case 380;
				case 340:
					array3[29] = (byte)num10;
					goto case 382;
				case 339:
					array3[29] = (byte)num10;
					num2 = 27;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 11;
				case 11:
					array4[10] = (byte)num9;
					goto case 217;
				case 217:
					num5 = 77;
					num2 = 409;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 338:
					array4[11] = (byte)num5;
					goto case 243;
				case 243:
					num9 = 226;
					num = 261;
					goto case 261;
				case 261:
					array4[11] = (byte)num9;
					num2 = 227;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 337:
					array3[23] = (byte)num8;
					goto case 295;
				case 336:
					array5 = (byte[])HkLkNdDPtB;
					goto case 245;
				case 334:
					array3 = new byte[32];
					num = 28;
					goto case 28;
				case 28:
					array3[0] = 136;
					num = 189;
					goto case 189;
				case 189:
					num10 = 95;
					num2 = 106;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 333:
					array4[13] = 134;
					goto case 425;
				case 331:
					num10 = 56;
					goto case 13;
				case 13:
					array3[10] = (byte)num10;
					goto case 381;
				case 329:
					num23 = 0u;
					goto case 197;
				case 197:
					if (num13 <= 0)
					{
						goto case 369;
					}
					num2 = 23;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 140;
				case 140:
					num7++;
					goto case 369;
				case 327:
					num5 = 84;
					num2 = 70;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 324:
					array3[10] = 102;
					num = 268;
					goto case 268;
				case 268:
					array3[10] = 192;
					goto case 331;
				case 323:
					num23 = 0u;
					num2 = 100;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 58;
				case 322:
					if (num6 == num7 - 1)
					{
						goto case 129;
					}
					goto case 21;
				case 129:
					if (num13 > 0)
					{
						goto case 392;
					}
					goto case 21;
				case 21:
					num22 = num11 ^ num23;
					num = 293;
					goto case 293;
				case 293:
					array7[num15] = (byte)(num22 & 0xFFu);
					num2 = 315;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 180;
				case 180:
					array4[0] = 82;
					num2 = 67;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 320:
					array3[22] = 98;
					goto case 80;
				case 80:
					array3[22] = 230;
					goto case 3;
				case 3:
					array3[22] = 47;
					num2 = 145;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 319:
					array3[2] = (byte)num8;
					goto case 135;
				case 135:
					num10 = 117;
					num2 = 19;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 76;
				case 76:
					array3[2] = (byte)num10;
					goto case 183;
				case 183:
					array3[2] = 92;
					num2 = 178;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 316:
					HkLkNdDPtB = GUiGFYD4pnOaSu7bNp(stream);
					goto case 181;
				case 181:
					eYBQyBcgwPyWfE3hcd(stream);
					num2 = 164;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 88;
				case 315:
					array7[num15 + 1] = (byte)((num22 & 0xFF00) >> 8);
					goto case 403;
				case 314:
					array3[5] = (byte)num10;
					goto case 72;
				case 72:
					array3[6] = 163;
					goto case 152;
				case 152:
					num10 = 121;
					num2 = 305;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 24;
				case 24:
					array3[4] = 84;
					num2 = 186;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 313:
					num8 = 148;
					goto case 216;
				case 216:
					array3[12] = (byte)num8;
					num = 255;
					goto case 255;
				case 255:
					array3[12] = 150;
					goto case 147;
				case 147:
					array3[12] = 102;
					goto case 273;
				case 273:
					num10 = 181;
					num2 = 39;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 312:
					array3[29] = (byte)num10;
					num2 = 118;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 309:
					array4[7] = (byte)num5;
					goto case 303;
				case 303:
					array4[7] = 238;
					goto case 83;
				case 308:
					num8 = 74;
					goto case 110;
				case 110:
					array3[9] = (byte)num8;
					num2 = 274;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 71;
				case 71:
					num8 = 165;
					num2 = 132;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 305:
					array3[6] = (byte)num10;
					goto case 36;
				case 36:
					num8 = 137;
					num2 = 94;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 6;
				case 6:
					array3[8] = 92;
					goto case 195;
				case 195:
					num8 = 131;
					goto case 284;
				case 284:
					array3[8] = (byte)num8;
					goto case 211;
				case 211:
					num10 = 122;
					goto case 128;
				case 128:
					array3[9] = (byte)num10;
					goto case 308;
				case 302:
					array4[8] = (byte)num5;
					num2 = 134;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 298:
					array4[1] = (byte)num5;
					num2 = 384;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 296:
					num8 = 127;
					num2 = 194;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 294:
					array3[7] = (byte)num8;
					num2 = 117;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 263;
				case 263:
					num8 = 179;
					num = 9;
					goto case 9;
				case 9:
					array3[8] = (byte)num8;
					goto case 228;
				case 228:
					array3[8] = 120;
					num2 = 6;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 1;
				case 291:
					num9 = 150;
					goto case 99;
				case 99:
					array4[15] = (byte)num9;
					goto case 146;
				case 146:
					array4[15] = 175;
					goto case 170;
				case 170:
					array4[15] = 92;
					goto case 359;
				case 289:
					array4[9] = (byte)num5;
					goto case 85;
				case 85:
					array4[9] = 76;
					goto case 127;
				case 127:
					num5 = 156;
					goto case 258;
				case 258:
					array4[9] = (byte)num5;
					num2 = 87;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 285:
					array4[1] = (byte)num5;
					num = 113;
					goto case 113;
				case 113:
					num5 = 211;
					goto case 298;
				case 283:
					array3[13] = 199;
					goto case 190;
				case 190:
					num10 = 116;
					num2 = 69;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 142;
				case 142:
					array3[14] = (byte)num10;
					goto case 414;
				case 280:
					array7[num15 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
					goto case 77;
				case 279:
					num9 = 158;
					num2 = 126;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 275:
					num21 = 0;
					goto case 61;
				case 274:
					array3[9] = 101;
					goto case 260;
				case 260:
					array3[9] = 29;
					num = 324;
					goto case 324;
				case 272:
					array3[2] = (byte)num8;
					num2 = 71;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 270:
					num5 = 73;
					goto case 125;
				case 125:
					array4[2] = (byte)num5;
					num2 = 348;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 151;
				case 151:
					array3[13] = (byte)num10;
					goto case 283;
				case 269:
					num9 = 15;
					num2 = 206;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 267:
					num8 = 96;
					num2 = 12;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 337;
				case 264:
					array3[14] = (byte)num8;
					goto case 149;
				case 149:
					array3[14] = 146;
					num = 95;
					goto case 95;
				case 95:
					num10 = 21;
					num2 = 174;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 262:
					num9 = 143;
					goto case 156;
				case 156:
					array4[12] = (byte)num9;
					goto case 143;
				case 143:
					num9 = 143;
					goto case 360;
				case 253:
					array3[19] = 153;
					num2 = 296;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 251:
					array4[11] = 204;
					goto case 234;
				case 234:
					num5 = 58;
					num2 = 316;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 338;
				case 249:
					array4[4] = (byte)num5;
					num2 = 279;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 246:
					num9 = 86;
					num2 = 23;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 241:
					array4[1] = (byte)num9;
					num2 = 270;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 204;
				case 204:
					array3[31] = 121;
					goto case 410;
				case 240:
					num10 = 14;
					num2 = 82;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 239:
					array4[9] = (byte)num5;
					goto case 75;
				case 75:
					num5 = 59;
					goto case 289;
				case 238:
					array3[31] = 141;
					goto case 204;
				case 237:
					num8 = 95;
					num2 = 389;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 236:
					num8 = 119;
					goto case 264;
				case 235:
					qjeSwSUdLc99FLWQTj(object_2);
					goto case 316;
				case 227:
					num9 = 136;
					goto case 175;
				case 175:
					array4[12] = (byte)num9;
					num2 = 262;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 79;
				case 79:
					num14 += 8;
					goto case 248;
				case 225:
					num10 = 110;
					goto case 314;
				case 221:
					num8 = 164;
					goto case 120;
				case 120:
					array3[15] = (byte)num8;
					num = 383;
					goto case 383;
				case 213:
					num11 = num17;
					num2 = 322;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 212:
					num11 += num12;
					num2 = 161;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 140;
				case 209:
					array7 = new byte[array5.Length];
					goto case 121;
				case 121:
					num20 = array6.Length / 4;
					num2 = 37;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 207:
				{
					uint num18 = num17;
					uint num19 = num17;
					num19 ^= num19 << 7;
					num19 += 1373919882;
					num19 ^= num19 >> 9;
					num19 += 1223955327;
					num19 ^= num19 << 5;
					num19 += 3092459325u;
					num19 = 3139161922u - num19;
					num17 = num18 + (uint)(double)num19;
					goto case 213;
				}
				case 206:
					array4[3] = (byte)num9;
					num2 = 378;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 200:
					num8 = 211;
					num2 = 169;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 199:
					num9 = 160;
					num2 = 11;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 194:
					array3[19] = (byte)num8;
					num2 = 401;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 191:
					array3[25] = (byte)num8;
					goto case 237;
				case 188:
					array3[12] = 153;
					num2 = 313;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 187:
					num8 = 197;
					num = 102;
					goto case 102;
				case 102:
					array3[1] = (byte)num8;
					goto case 55;
				case 55:
					num8 = 111;
					num2 = 150;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 319;
				case 186:
					array3[4] = 69;
					num2 = 407;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 178:
					num10 = 228;
					num = 10;
					goto case 10;
				case 10:
					array3[2] = (byte)num10;
					num2 = 145;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 158;
				case 158:
					num8 = 238;
					goto case 272;
				case 176:
					array6 = array3;
					num2 = 98;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 174:
					array3[14] = (byte)num10;
					goto case 221;
				case 171:
					num8 = 93;
					num2 = 294;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 169:
					array3[12] = (byte)num8;
					num = 188;
					goto case 188;
				case 165:
					num5 = 144;
					goto case 155;
				case 155:
					array4[9] = (byte)num5;
					goto case 112;
				case 112:
					num5 = 148;
					num2 = 204;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 239;
				case 164:
					eYBQyBcgwPyWfE3hcd(object_2);
					goto case 336;
				case 161:
					num16 = (uint)num15;
					goto case 363;
				case 160:
					array4[3] = (byte)num5;
					goto case 269;
				case 148:
					array4[7] = 178;
					goto case 53;
				case 53:
					array4[7] = 15;
					num2 = 399;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 145:
					array3[23] = 165;
					goto case 96;
				case 96:
					num10 = 113;
					num2 = 33;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 11;
				case 144:
					array4[2] = (byte)num9;
					goto case 44;
				case 44:
					array4[2] = 92;
					num2 = 138;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 141:
					array3[11] = 167;
					num2 = 125;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 240;
				case 139:
					array5 = (byte[])jAHG4aCBtDROmYGPWC(object_, (int)qCrZtwZjZUTJMym7fW(kSkTnLtwTIW7EkyyQR(object_)));
					goto case 424;
				case 138:
					num5 = 228;
					num2 = 387;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 137:
					array4[1] = 92;
					goto case 345;
				case 136:
					num8 = 105;
					num2 = 400;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 134:
					array4[8] = 92;
					num2 = 48;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 14;
				case 133:
					num7 = array5.Length / 4;
					goto case 209;
				case 132:
					array3[3] = (byte)num8;
					num = 393;
					goto case 393;
				case 126:
					array4[5] = (byte)num9;
					goto case 398;
				case 124:
					array4[0] = (byte)num5;
					num2 = 281;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 238;
				case 122:
					num8 = 159;
					goto case 191;
				case 118:
					num10 = 199;
					goto case 340;
				case 117:
					array3[22] = (byte)num8;
					num2 = 17;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 116:
					num9 = 208;
					goto case 241;
				case 115:
					num14 = 0;
					num2 = 16;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 111:
					if (num13 > 0)
					{
						num2 = 323;
						if (b1p0PaTYErpom6373D() == null)
						{
							continue;
						}
						goto IL_0048;
					}
					goto case 212;
				case 106:
					array3[0] = (byte)num10;
					num2 = 118;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 136;
				case 105:
					jVoePfFGJkAAa4kwF7(object_2, array5, 0, array5.Length);
					num2 = 235;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 101:
					num9 = 132;
					num2 = 30;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 14;
				case 100:
					num11 += num12;
					num2 = 275;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 98:
					array4 = new byte[16];
					num2 = 180;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 94:
					array3[6] = (byte)num8;
					goto case 426;
				case 93:
					stream = (Stream)VAFqXXnmbnR73CP6vq();
					num2 = 19;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 1;
				case 91:
					num9 = 42;
					num2 = 218;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 374;
				case 87:
					num5 = 163;
					num2 = 34;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 24;
				case 84:
					array4[8] = (byte)num9;
					goto case 165;
				case 82:
					array3[11] = (byte)num10;
					num2 = 200;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 81:
					num11 = 0u;
					num = 207;
					goto case 207;
				case 78:
					num5 = 240;
					num2 = 249;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 195;
				case 74:
					num10 = 144;
					goto case 151;
				case 70:
					array4[15] = (byte)num5;
					goto case 417;
				case 68:
					object_3 = (SymmetricAlgorithm)FF7A3kGXYU5RK5YOut();
					goto case 58;
				case 67:
					num5 = 164;
					num2 = 124;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 66:
					array3[1] = (byte)num8;
					goto case 63;
				case 63:
					array3[1] = 52;
					goto case 187;
				case 65:
					array3[7] = 65;
					goto case 375;
				case 64:
					num8 = 123;
					num2 = 388;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 62:
					array4[13] = (byte)num5;
					num2 = 91;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 60:
					num10 = 114;
					goto case 372;
				case 57:
					array3[26] = 160;
					num2 = 365;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 48:
					num9 = 153;
					num = 84;
					goto case 84;
				case 39:
					array3[13] = (byte)num10;
					goto case 74;
				case 38:
					array3[11] = 167;
					num2 = 141;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 37:
					num11 = 0u;
					num2 = 18;
					if (b1p0PaTYErpom6373D() != null)
					{
						continue;
					}
					goto case 32;
				case 32:
					num12 = 0u;
					num2 = 329;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 34:
					array4[10] = (byte)num5;
					num2 = 199;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 33:
					array3[23] = (byte)num10;
					num2 = 267;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto IL_0048;
				case 31:
					num8 = 64;
					num2 = 350;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 66;
				case 30:
					array4[11] = (byte)num9;
					num2 = 251;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto case 154;
				case 27:
					num10 = 98;
					num2 = 273;
					if (!VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 312;
				case 26:
					array4[0] = (byte)num5;
					num2 = 8;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 23:
					array4[12] = (byte)num9;
					num2 = 333;
					if (b1p0PaTYErpom6373D() == null)
					{
						continue;
					}
					goto IL_0048;
				case 20:
					num8 = 111;
					num = 358;
					goto case 358;
				case 19:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					goto case 105;
				case 17:
					array3[22] = 213;
					goto case 320;
				case 16:
					if (num6 != num7 - 1)
					{
						goto case 212;
					}
					goto case 111;
				case 8:
					num5 = 46;
					num = 285;
					goto case 285;
				default:
					array[7] = array2[3];
					num2 = 45;
					if (VNbvZDI489boxOicgD())
					{
						continue;
					}
					goto case 31;
				case 286:
					break;
				case 354:
					goto IL_293a;
				case 163:
					goto IL_2967;
				case 277:
					try
					{
						EZvZiTOhRh2Jtot93U();
						int num3 = 1;
						if (VNbvZDI489boxOicgD())
						{
							goto IL_2985;
						}
						goto IL_29ac;
						IL_29ac:
						switch (num3)
						{
						case 1:
							break;
						default:
							return result;
						}
						goto IL_2985;
						IL_2985:
						result = (string)gt060kuKVbSgl0solW(UHv9ryYgar3LCpinDA(), HkLkNdDPtB, int_0 + 4, int_);
						num3 = 0;
						if (b1p0PaTYErpom6373D() != null)
						{
							num3 = num4;
						}
						goto IL_29ac;
					}
					catch
					{
						if (!VNbvZDI489boxOicgD())
						{
							switch (0)
							{
							}
						}
					}
					goto case 35;
				case 35:
					return "";
				}
				break;
			}
			goto IL_2910;
		}
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	internal static string hg2oY5yaSM(object object_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)object_0);
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
		object obj = ((Hashtable)lmdkVksVkh)[(object)num];
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
		return (Delegate)Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(16777395)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(16777264)),
			Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(16777337))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal unsafe static void prXoP4RuYp()
	{
		//The blocks IL_1f71, IL_1f7d, IL_1f9a, IL_1fbd, IL_1fcc are reachable both inside and outside the pinned region starting at IL_1f8c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0009, IL_0013, IL_0019, IL_0020, IL_002b, IL_003a, IL_0052, IL_0070, IL_0b0e, IL_0b25, IL_0b2e, IL_0b3c, IL_0b42, IL_0b50, IL_0b69, IL_0b72, IL_0b87, IL_0b96, IL_0ba5, IL_0bab, IL_0bb9, IL_0bc2, IL_0be2, IL_0beb, IL_0bf4, IL_0bfd, IL_0c1b, IL_0c36, IL_0c59, IL_0c70, IL_0c7c, IL_0c88, IL_0c97, IL_0cba, IL_0cc8, IL_0cde, IL_0ced, IL_0cf3, IL_0d08, IL_0d1e, IL_0d3f, IL_0d57, IL_0d77, IL_0d88, IL_0db0, IL_0db8, IL_0dc8, IL_0dd4, IL_0ddd, IL_0de0, IL_0dec, IL_0df5, IL_0e10, IL_0e18, IL_0e21, IL_0e2a, IL_0e46, IL_0e6f, IL_0e87, IL_0ea4, IL_0ec0, IL_0ec8, IL_0eec, IL_0f05, IL_0f2e, IL_0f3a, IL_0f5e, IL_0f76, IL_0f9a, IL_0fb3, IL_0fd1, IL_0ff5, IL_1002, IL_101b, IL_103d, IL_1060, IL_1069, IL_1074, IL_107f, IL_108a, IL_1095, IL_10b0, IL_10bb, IL_10c6, IL_10da, IL_10e3, IL_1103, IL_110f, IL_1118, IL_1126, IL_1135, IL_113e, IL_114c, IL_1157, IL_1178, IL_1181, IL_119f, IL_11c2, IL_11d5, IL_11db, IL_11e1, IL_11e5, IL_11ed, IL_11f4, IL_1222, IL_1229, IL_122f, IL_1235, IL_1260, IL_127c, IL_1296, IL_129a, IL_12af, IL_12c7, IL_12d6, IL_12e4, IL_12f3, IL_1316, IL_131f, IL_1328, IL_132c, IL_13b9, IL_13be, IL_13d4, IL_13e7, IL_13ec, IL_1403, IL_1409, IL_140f, IL_1424, IL_1435, IL_1450, IL_1453, IL_145e, IL_1463, IL_1473, IL_147b, IL_149a, IL_14ae, IL_14c5, IL_14de, IL_14f2, IL_14f8, IL_150e, IL_1514, IL_151a, IL_1531, IL_1555, IL_1565, IL_1569, IL_157d, IL_1585, IL_1595, IL_15b8, IL_15c4, IL_15d7, IL_15e3, IL_15ea, IL_1602, IL_1620, IL_162f, IL_1635, IL_1658, IL_1660, IL_167d, IL_16a1, IL_16bc, IL_16e0, IL_16fe, IL_171b, IL_1726, IL_1731, IL_173c, IL_1747, IL_1752, IL_176d, IL_177b, IL_178a, IL_17a0, IL_17c3, IL_17d1, IL_17da, IL_17e8, IL_1809, IL_1818, IL_181e, IL_182c, IL_184d, IL_1852, IL_1866, IL_186c, IL_1877, IL_188c, IL_18a4, IL_18b3, IL_18bf, IL_18e0, IL_18ef, IL_18fd, IL_191b, IL_192d, IL_1932, IL_1947, IL_194f, IL_1964, IL_1985, IL_198e, IL_19b5, IL_19b9, IL_19c9, IL_19d2, IL_19e0, IL_19fb, IL_1a03, IL_1a16, IL_1a2b, IL_1a49, IL_1a74, IL_1a7f, IL_1a9f, IL_1aae, IL_1ab9, IL_1ad0, IL_1ad9, IL_1afc, IL_1b1d, IL_1b26, IL_1b34, IL_1b3d, IL_1b60, IL_1b6c, IL_1b73, IL_1b7a, IL_1b91, IL_1bae, IL_1bb7, IL_1bd7, IL_1bf6, IL_1c13, IL_1c21, IL_1c2c, IL_1c3d, IL_1c4e, IL_1c54, IL_1c5c, IL_1c71, IL_1c92, IL_1ca0, IL_1cb9, IL_1cc8, IL_1ce3, IL_1d01, IL_1d20, IL_2040, IL_205d, IL_207c, IL_2098, IL_20a7, IL_20c5, IL_20cb, IL_20d1, IL_20ec, IL_20fb, IL_2119, IL_2135, IL_2159, IL_2172, IL_2183, IL_21a1, IL_21a7, IL_21b5, IL_21d0, IL_21fd, IL_2214, IL_2229, IL_224d, IL_2259, IL_2265, IL_2271, IL_2292, IL_2298, IL_22bb, IL_22ca, IL_22d0, IL_22e7, IL_22f6, IL_2317, IL_2320, IL_232e, IL_234d, IL_2369, IL_238a, IL_2391, IL_239a, IL_23b8, IL_23c6, IL_23e2, IL_2400, IL_2408, IL_2427, IL_2445, IL_245a, IL_2482, IL_2490, IL_24ac, IL_24c0, IL_24c8, IL_24cb, IL_24ce, IL_24d1, IL_24d6, IL_24dc, IL_24f4, IL_2512, IL_2518, IL_2526, IL_2544, IL_2565, IL_2574, IL_2583, IL_259e, IL_25b7, IL_25cc, IL_25df, IL_25fe, IL_2607, IL_262d, IL_263b, IL_2641, IL_264f, IL_266a, IL_2676, IL_2691, IL_26af, IL_26cd, IL_26e3, IL_26f6, IL_2702, IL_2708, IL_2716, IL_271c, IL_273f, IL_2762, IL_2774, IL_2782, IL_2791, IL_2797, IL_27ba, IL_27c5, IL_27d9, IL_27f4, IL_27fc, IL_2801, IL_2808, IL_2820, IL_2827, IL_2845, IL_2860, IL_2873, IL_288b, IL_2897, IL_28bb, IL_28ca, IL_28d6, IL_28e7, IL_28fd, IL_2918, IL_2928, IL_2937, IL_295a, IL_2963, IL_2976, IL_297f, IL_299f, IL_29a8, IL_29cb, IL_29d3, IL_29e2, IL_29ec, IL_29f7, IL_2a17, IL_2a25, IL_2a46, IL_2a54, IL_2a69, IL_2a78, IL_2a84, IL_2a8a, IL_2a9d, IL_2aa6, IL_2ac9, IL_2ad2, IL_2ae5, IL_2af3, IL_2b16, IL_2b22, IL_2b32, IL_2b55, IL_2b75, IL_2b83, IL_2b89, IL_2ba7, IL_2bb2, IL_2bd5, IL_2bdb, IL_2be9, IL_2bf2, IL_2c0e, IL_2c1a, IL_2c32, IL_2c38, IL_2c5b, IL_2c7b, IL_2c81, IL_2c8f, IL_2ca1, IL_2cbf, IL_2cdb, IL_2cf3, IL_2d0c, IL_2d1f, IL_2d2a, IL_2d38, IL_2d41, IL_2d54, IL_2f1a, IL_303d, IL_304e, IL_3059, IL_3073, IL_308e, IL_30b1, IL_30c0, IL_30db, IL_30f7, IL_3105, IL_3121, IL_3133, IL_314a, IL_3153, IL_3161, IL_3170, IL_3176, IL_3199, IL_31bc, IL_31d7, IL_31e2, IL_3202, IL_3211, IL_321d, IL_3226, IL_3249, IL_326d, IL_328b, IL_3299, IL_32b2, IL_32d0, IL_32d8, IL_32e8, IL_32ec, IL_330a, IL_330d, IL_3316, IL_3336, IL_3344, IL_3359, IL_3375, IL_3389, IL_339f, IL_33a5, IL_33b4, IL_33cf, IL_33db, IL_33e7, IL_340b, IL_341c, IL_3431, IL_344c, IL_3455, IL_3478, IL_3489, IL_3494, IL_34b0, IL_34d1, IL_34e2, IL_34f6, IL_34ff, IL_350d, IL_3529, IL_354c, IL_355a, IL_3563, IL_3586, IL_3594, IL_359d, IL_35c0, IL_35d3, IL_35e5, IL_3608, IL_360b, IL_360e, IL_361d, IL_3636, IL_365a, IL_3660, IL_366e, IL_3674, IL_3687, IL_368d, IL_369b, IL_36a9, IL_36af, IL_36b6, IL_36d2, IL_36e5, IL_36fd, IL_371b, IL_3727, IL_373c, IL_3748, IL_376c, IL_3780, IL_379d, IL_37b9, IL_37c2, IL_37d5, IL_37fb, IL_3803, IL_3818, IL_382e, IL_3841, IL_384a, IL_3858, IL_3877, IL_3882, IL_389f, IL_38c2, IL_38d6, IL_38f7, IL_3906, IL_391a, IL_3928, IL_393b, IL_394a, IL_396e, IL_398c, IL_3999, IL_39bf, IL_39ce, IL_39f2, IL_3a01, IL_3a26, IL_3a3d, IL_3a51, IL_3a6c, IL_3a83, IL_3a94, IL_3aa2, IL_3aae, IL_3acc, IL_3ad7, IL_3ae8, IL_3af6, IL_3b04, IL_3b12, IL_3b26, IL_3b50, IL_3b5e, IL_3b7a, IL_3b93, IL_3ba7, IL_3bc3, IL_3bd3, IL_3be7, IL_3c0a, IL_3c20, IL_3c2b, IL_3c4c, IL_3c67, IL_3c7f, IL_3c89, IL_3ca7, IL_3ccb, IL_3cee, IL_3d02, IL_3d15, IL_3d1e, IL_3d41, IL_3d5c, IL_3d71, IL_3d88, IL_3da4, IL_3dc7, IL_3de5, IL_3deb, IL_3e0e, IL_3e2e, IL_3e47, IL_3e77, IL_3e90, IL_3e9b, IL_3eb3, IL_3ec7, IL_3eda, IL_3eee, IL_3f01, IL_3f12, IL_3f1e, IL_3f3c, IL_3f58, IL_3f6c, IL_3f77, IL_3f7b, IL_3f88, IL_3f92, IL_3fa7, IL_3fc2, IL_3fdc, IL_3fef, IL_3ffd, IL_400e, IL_402c, IL_4043, IL_4051, IL_4069, IL_4079, IL_4081, IL_4091, IL_4097, IL_40ba, IL_41a3, IL_41b0, IL_41ce, IL_41e9, IL_41fd, IL_420a, IL_4215, IL_4232, IL_425b, IL_4276, IL_4292, IL_42a8, IL_42b4, IL_42dd, IL_4300, IL_4311, IL_432d, IL_4338, IL_4352, IL_4370, IL_4389, IL_4395, IL_43b9, IL_43dd, IL_43f8, IL_4406, IL_4428, IL_4430, IL_443c, IL_444f, IL_4457, IL_446b, IL_45ef, IL_45fe, IL_460d, IL_4623, IL_462a are reachable both inside and outside the pinned region starting at IL_13e5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 153;
		byte[] array = default(byte[]);
		VtNVUKGulysZw81C3E object_ = default(VtNVUKGulysZw81C3E);
		byte[] array7 = default(byte[]);
		int num13 = default(int);
		int num33 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num28 = default(int);
		byte[] array2 = default(byte[]);
		int num10 = default(int);
		int num14 = default(int);
		IntPtr intptr_6 = default(IntPtr);
		int int_2 = default(int);
		int num67 = default(int);
		int num54 = default(int);
		long num73 = default(long);
		int num16 = default(int);
		BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
		bool jDNkifbo3S = default(bool);
		int num75 = default(int);
		int num76 = default(int);
		int int_3 = default(int);
		byte[] jsbkrdexts = default(byte[]);
		BIpvxRBRb2dOGl802m bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
		IntPtr intPtr2 = default(IntPtr);
		byte[] array6 = default(byte[]);
		IntPtr intPtr3 = default(IntPtr);
		byte[] array10 = default(byte[]);
		int num35 = default(int);
		byte[] array12 = default(byte[]);
		byte[] array11 = default(byte[]);
		int num9 = default(int);
		int num36 = default(int);
		byte[] array13 = default(byte[]);
		byte[] array17 = default(byte[]);
		int num69 = default(int);
		ref byte reference2 = default(ref byte);
		int num74 = default(int);
		int num59 = default(int);
		int num58 = default(int);
		uint num31 = default(uint);
		uint num12 = default(uint);
		byte[] array4 = default(byte[]);
		uint num17 = default(uint);
		int num66 = default(int);
		int num37 = default(int);
		int num30 = default(int);
		uint num11 = default(uint);
		uint num32 = default(uint);
		int num68 = default(int);
		byte[] array15 = default(byte[]);
		int num34 = default(int);
		IntPtr intPtr4 = default(IntPtr);
		AwgKvrHJUS3TxryUsj uint_ = default(AwgKvrHJUS3TxryUsj);
		int num53 = default(int);
		long value = default(long);
		IntPtr intptr_2 = default(IntPtr);
		int num15 = default(int);
		int int_ = default(int);
		int num56 = default(int);
		uint num55 = default(uint);
		int num18 = default(int);
		bool flag = default(bool);
		ProcessModuleCollection object_16 = default(ProcessModuleCollection);
		IEnumerator enumerator = default(IEnumerator);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream object_8 = default(CryptoStream);
		byte[] array16 = default(byte[]);
		int num27 = default(int);
		SymmetricAlgorithm object_6 = default(SymmetricAlgorithm);
		MemoryStream object_15 = default(MemoryStream);
		int num64 = default(int);
		byte[] array18 = default(byte[]);
		uint nativeSizeOfCode = default(uint);
		int num62 = default(int);
		ref byte reference = default(ref byte);
		string string_ = default(string);
		IntPtr procAddress = default(IntPtr);
		IntPtr intptr_3 = default(IntPtr);
		OFfwWh6ZIHjfnqBOWx object_14 = default(OFfwWh6ZIHjfnqBOWx);
		Process object_9 = default(Process);
		uint num57 = default(uint);
		string text = default(string);
		IntPtr intptr_ = default(IntPtr);
		int num29 = default(int);
		IntPtr intPtr = default(IntPtr);
		int num39 = default(int);
		int num43 = default(int);
		int num45 = default(int);
		int num47 = default(int);
		ProcessModule object_13 = default(ProcessModule);
		int num50 = default(int);
		byte[] array14 = default(byte[]);
		ICryptoTransform transform = default(ICryptoTransform);
		int num21 = default(int);
		int num23 = default(int);
		int num25 = default(int);
		int num6 = default(int);
		Version object_3 = default(Version);
		Version object_4 = default(Version);
		Version object_5 = default(Version);
		int num8 = default(int);
		IntPtr intptr_4 = default(IntPtr);
		long num19 = default(long);
		byte[] array9 = default(byte[]);
		byte[] array3 = default(byte[]);
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
					while (true)
					{
						IL_0020:
						long num3 = 0L;
						while (true)
						{
							IL_002b:
							YGO4smCLb05L3pQqWL(new IntPtr(&num3), 0);
							while (true)
							{
								IL_003a:
								knn1A1kptkasxsLBZj(new IntPtr(&num3), 0);
								num = 254;
								while (true)
								{
									IL_0052:
									nrC731YCVEcvGAsRoX(new IntPtr(&num3), 0);
									int num4 = 31;
									if (Y9PRou3gANeThLAUl2() != null)
									{
										goto IL_0070;
									}
									goto IL_3e9b;
									IL_3e9b:
									enLfcYQKgZbAne4yyx(new IntPtr(&num3), 0, IntPtr.Zero);
									goto IL_39f2;
									IL_39f2:
									oGhRhplYdDMGaAZ2Bp(new IntPtr(&num3), 0, 0);
									goto IL_3a01;
									IL_3a01:
									OtIrloWOhTIlSVacEw(new IntPtr(&num3), 0, 0L);
									num = 552;
									goto IL_29cb;
									IL_29cb:
									array = new byte[1];
									goto IL_29d3;
									IL_29d3:
									sSUWWuShXng1BRbVoN(array, 0, oTMvA6c4kGBeCHbTs3(8), 1);
									goto IL_29e2;
									IL_29e2:
									EbLcZfLqERCnRuQ379();
									goto IL_1985;
									IL_1985:
									if (num2 == 4109628145u)
									{
										goto IL_198e;
									}
									goto IL_19fb;
									IL_19fb:
									if (dVI91YrnPkdJxsxIix() == 4)
									{
										goto IL_1a03;
									}
									goto IL_1a49;
									IL_1a49:
									object_ = new VtNVUKGulysZw81C3E((Stream)gw9ikDqUK6y0McRKYR(x4Dk2IHVmX, "SOtGK2hTgbJca1CMiL.2woVpUvSeoTZWsSNnb"));
									num4 = 408;
									if (zsTZIhocVLyHHxkw2B())
									{
										goto IL_0070;
									}
									goto IL_0b69;
									IL_0070:
									while (true)
									{
										ref BIpvxRBRb2dOGl802m reference3;
										IntPtr intptr_5;
										byte[] array22;
										uint num71;
										byte[] array20;
										byte[] array21;
										int num60;
										byte[] array19;
										int num61;
										int num63;
										int num65;
										int num38;
										int num40;
										long num41;
										long num42;
										int num44;
										int num46;
										int num48;
										int num49;
										int num51;
										int num52;
										int num20;
										int num22;
										int num24;
										int num26;
										int num5;
										int num7;
										nint num70;
										switch (num4)
										{
										case 153:
											break;
										case 324:
											goto IL_0013;
										case 399:
											goto IL_0019;
										case 361:
											goto IL_0020;
										case 95:
											goto IL_002b;
										case 30:
											goto IL_003a;
										case 254:
											goto IL_0052;
										case 676:
											array7[6] = (byte)num13;
											num = 96;
											goto case 96;
										case 96:
											num33 = 194;
											goto case 328;
										case 328:
											array7[6] = (byte)num33;
											goto case 631;
										case 631:
											num13 = 86;
											goto case 108;
										case 108:
											array7[6] = (byte)num13;
											goto case 113;
										case 113:
											num13 = 142;
											num4 = 589;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 675:
											array7[9] = 118;
											num = 242;
											goto case 242;
										case 242:
											array7[9] = 184;
											goto case 126;
										case 126:
											array7[9] = 156;
											goto case 347;
										case 347:
											num33 = 75;
											goto case 603;
										case 603:
											array7[9] = (byte)num33;
											goto case 505;
										case 505:
											num33 = 140;
											goto case 596;
										case 596:
											array7[10] = (byte)num33;
											num4 = 667;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 674:
											array5[9] = array8[4];
											goto case 148;
										case 148:
											array5[11] = array8[5];
											goto case 325;
										case 325:
											array5[13] = array8[6];
											goto case 333;
										case 333:
											array5[15] = array8[7];
											num4 = 359;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 673:
											num28++;
											num4 = 165;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 672:
											array2[21] = (byte)num10;
											num4 = 528;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 671:
											array2[28] = (byte)num14;
											num = 57;
											goto case 57;
										case 57:
											array2[29] = 98;
											goto case 163;
										case 163:
											array2[29] = 91;
											goto case 79;
										case 79:
											num14 = 108;
											num = 19;
											goto case 19;
										case 19:
											array2[29] = (byte)num14;
											num4 = 407;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 670:
											AG4AEFonT6onCnjkPYZ(intptr_6, qVpqG99c2WEReaDdAx(object_));
											goto case 604;
										case 604:
											YeeoMqaS3J(intptr_6, 4, int_2, ref int_2);
											num = 53;
											goto case 53;
										case 53:
											num67++;
											num = 616;
											goto case 241;
										case 241:
										case 616:
											if (num67 >= num54)
											{
												num4 = 306;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 6;
										case 6:
											intptr_6 = new IntPtr(num73 + qVpqG99c2WEReaDdAx(object_) - num16);
											goto case 651;
										case 651:
											YeeoMqaS3J(intptr_6, 4, 4, ref int_2);
											num4 = 670;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 669:
											bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
											num4 = 56;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 316;
										case 316:
											reference3 = ref bIpvxRBRb2dOGl802m;
											array = new byte[1] { 42 };
											reference3.jsbkrdexts = array;
											num = 515;
											goto case 515;
										case 515:
											bIpvxRBRb2dOGl802m.JDNkifbo3S = false;
											num = 465;
											goto case 465;
										case 465:
											TL77LIo3jVmAbSU6Pr4(lmdkVksVkh, 0L, bIpvxRBRb2dOGl802m);
											num = 549;
											goto case 549;
										case 549:
											jDNkifbo3S = false;
											goto case 518;
										case 258:
											num75 = qVpqG99c2WEReaDdAx(object_) - num16;
											goto case 16;
										case 16:
											num76 = qVpqG99c2WEReaDdAx(object_);
											goto case 171;
										case 171:
											jDNkifbo3S = false;
											goto case 580;
										case 580:
											if (num76 < 1879048192)
											{
												goto case 189;
											}
											goto case 523;
										case 189:
											int_3 = qVpqG99c2WEReaDdAx(object_);
											goto case 252;
										case 252:
											jsbkrdexts = (byte[])a4X4WBibbNOPOEpG16(object_, int_3);
											num4 = 48;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 208;
										case 208:
											bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
											goto case 142;
										case 142:
											bIpvxRBRb2dOGl802m2.jsbkrdexts = jsbkrdexts;
											goto case 329;
										case 329:
											bIpvxRBRb2dOGl802m2.JDNkifbo3S = jDNkifbo3S;
											goto case 421;
										case 421:
											TL77LIo3jVmAbSU6Pr4(lmdkVksVkh, num73 + num75, bIpvxRBRb2dOGl802m2);
											goto case 518;
										case 518:
										case 534:
											if (a8jp0TzOh1jXxVdK1L(CQLXcXZ398Y8S7aiIZ(object_)) < yo7LynetO8iH3reo9x(CQLXcXZ398Y8S7aiIZ(object_)) - 1L)
											{
												num4 = 119;
												if (Y9PRou3gANeThLAUl2() != null)
												{
													continue;
												}
												goto case 258;
											}
											goto case 24;
										case 523:
											jDNkifbo3S = true;
											num4 = 189;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 24:
											intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))[0]);
											goto case 59;
										case 59:
											eXJkjmTXDX = intPtr2.ToInt64();
											num4 = 125;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 337;
										case 337:
											if (dVI91YrnPkdJxsxIix() == 4)
											{
												goto case 268;
											}
											goto case 52;
										case 268:
											wpoklx4RIX = rhCWlWokCRiOQGFE8fB(eXJkjmTXDX);
											num4 = 52;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 52:
											array6 = new byte[12];
											num4 = 613;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 330;
										case 330:
											mTfoQqVbOE(intptr_4, intPtr3, (byte[])dRL5SfBSlDfHVRbDp6(qVpqG99c2WEReaDdAx(object_)), 4u, out intptr_5);
											num4 = 480;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 388;
										case 388:
											array2[11] = 105;
											goto case 508;
										case 508:
											array2[11] = 147;
											num4 = 383;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 668:
											array2[1] = 165;
											num = 158;
											goto case 158;
										case 158:
											array2[1] = 211;
											num4 = 370;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 667:
											num13 = 154;
											num4 = 1;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 1;
										case 1:
											array7[10] = (byte)num13;
											num4 = 13;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 512;
										case 512:
											array7[10] = 233;
											num4 = 553;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 666:
											if (dVI91YrnPkdJxsxIix() == 4)
											{
												goto case 330;
											}
											goto case 91;
										case 91:
											mTfoQqVbOE(intptr_4, intPtr3, (byte[])dRL5SfBSlDfHVRbDp6(qVpqG99c2WEReaDdAx(object_)), 4u, out intptr_5);
											goto case 247;
										case 247:
										case 480:
											YeeoMqaS3J(intPtr3, 4, int_2, ref int_2);
											num4 = 521;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 665:
											array2[22] = (byte)num10;
											num4 = 539;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 664:
											array10[num35] = array12[0];
											goto case 381;
										case 381:
											array10[num35 + 1] = array12[1];
											goto case 457;
										case 457:
											array10[num35 + 2] = array12[2];
											goto case 187;
										case 187:
											array10[num35 + 3] = array12[3];
											goto case 406;
										case 406:
											array10[num35 + 4] = array12[4];
											goto case 529;
										case 529:
											array10[num35 + 5] = array12[5];
											num4 = 303;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 365;
										case 365:
											array10[num35 + 6] = array12[6];
											goto case 284;
										case 284:
											array10[num35 + 7] = array12[7];
											goto case 570;
										case 570:
											num35 = 30;
											num4 = 5;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 8;
										case 8:
											array10[num35] = array11[0];
											goto case 40;
										case 40:
											array10[num35 + 1] = array11[1];
											num4 = 647;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 663:
											array2[24] = 110;
											goto case 17;
										case 17:
											num14 = 158;
											goto case 50;
										case 50:
											array2[24] = (byte)num14;
											goto case 206;
										case 206:
											array2[24] = 143;
											goto case 402;
										case 402:
											num14 = 150;
											goto case 621;
										case 621:
											array2[24] = (byte)num14;
											goto case 582;
										case 582:
											array2[24] = 2;
											goto case 657;
										case 657:
											array2[25] = 122;
											num4 = 81;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 662:
											num14 = 220;
											goto case 90;
										case 90:
											array2[9] = (byte)num14;
											num4 = 489;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 20;
										case 20:
											array7[2] = (byte)num33;
											num4 = 332;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 661:
											num28 = 0;
											num4 = 101;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 4;
										case 4:
										case 423:
											num9++;
											goto case 135;
										case 135:
										case 636:
											if (num9 >= num36)
											{
												goto case 594;
											}
											goto case 125;
										case 594:
											array13 = array17;
											goto case 598;
										case 598:
											num69 = array13.Length / 8;
											goto case 267;
										case 267:
											array22 = (array = array13);
											if (array22 != null)
											{
												num4 = 60;
												if (zsTZIhocVLyHHxkw2B())
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 319;
										case 319:
											reference2 = ref *(byte*)null;
											num4 = 281;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 125:
											num74 = num9 % num59;
											goto case 243;
										case 243:
											num58 = num9 * 4;
											goto case 419;
										case 419:
											num31 = (uint)(num74 * 4);
											goto case 25;
										case 25:
											num12 = (uint)((array4[num31 + 3] << 24) | (array4[num31 + 2] << 16) | (array4[num31 + 1] << 8) | array4[num31]);
											goto case 339;
										case 339:
											num17 = 255u;
											num4 = 656;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 660:
											array8 = (byte[])Ja2n2A8qoejSRSPbdp(XUD6i2UlMYIHfyd1mT(x4Dk2IHVmX));
											num = 299;
											goto case 299;
										case 299:
											if (array8 != null)
											{
												num4 = 198;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 143;
										case 143:
											num66 = 0;
											num4 = 488;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 659:
											num10 = 112;
											num = 73;
											goto case 73;
										case 73:
											array2[6] = (byte)num10;
											goto case 183;
										case 183:
											num10 = 91;
											num = 296;
											goto case 296;
										case 296:
											array2[6] = (byte)num10;
											num4 = 203;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 234:
										case 658:
											if (num37 >= num30)
											{
												num = 219;
												goto case 169;
											}
											goto case 497;
										case 169:
										case 219:
											num11 = num11;
											goto case 610;
										case 610:
										{
											num71 = num11;
											uint num72 = num11;
											num72 ^= num72 << 7;
											num72 += 1373919882;
											num72 ^= num72 >> 9;
											num72 += 1223955327;
											num72 ^= num72 << 5;
											num72 += 3092459325u;
											num72 = 3139161922u - num72;
											num11 = num71 + (uint)(double)num72;
											num4 = 567;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										}
										case 497:
											if (num37 > 0)
											{
												goto case 173;
											}
											goto case 89;
										case 173:
											num32 <<= 8;
											num4 = 89;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 60;
										case 60:
											if (array.Length == 0)
											{
												goto case 319;
											}
											goto case 260;
										case 260:
											while (true)
											{
												IL_13dd:
												fixed (byte* ptr = &array[0])
												{
													while (true)
													{
														IL_13e7:
														num68 = 0;
														while (true)
														{
															IL_1409:
															if (num68 >= num69)
															{
																num4 = 318;
																if (zsTZIhocVLyHHxkw2B())
																{
																	goto IL_0070_3;
																}
																goto IL_0b69_2;
															}
															goto IL_13ec;
															IL_1403:
															num68++;
															continue;
															IL_0070_3:
															while (true)
															{
																switch (num4)
																{
																case 319:
																	break;
																case 153:
																	if (!MrkkWebIMK)
																	{
																		goto case 324;
																	}
																	goto case 152;
																case 324:
																	MrkkWebIMK = true;
																	goto case 399;
																case 399:
																	num2 = 4059231220u;
																	goto case 361;
																case 361:
																	num3 = 0L;
																	goto case 95;
																case 95:
																	YGO4smCLb05L3pQqWL(new IntPtr(&num3), 0);
																	goto case 30;
																case 30:
																	knn1A1kptkasxsLBZj(new IntPtr(&num3), 0);
																	num = 254;
																	goto case 254;
																case 254:
																	nrC731YCVEcvGAsRoX(new IntPtr(&num3), 0);
																	num4 = 31;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 250;
																case 676:
																	array7[6] = (byte)num13;
																	num = 96;
																	goto case 96;
																case 96:
																	num33 = 194;
																	goto case 328;
																case 328:
																	array7[6] = (byte)num33;
																	goto case 631;
																case 631:
																	num13 = 86;
																	goto case 108;
																case 108:
																	array7[6] = (byte)num13;
																	goto case 113;
																case 113:
																	num13 = 142;
																	num4 = 589;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 675:
																	array7[9] = 118;
																	num = 242;
																	goto case 242;
																case 242:
																	array7[9] = 184;
																	goto case 126;
																case 126:
																	array7[9] = 156;
																	goto case 347;
																case 347:
																	num33 = 75;
																	goto case 603;
																case 603:
																	array7[9] = (byte)num33;
																	goto case 505;
																case 505:
																	num33 = 140;
																	goto case 596;
																case 596:
																	array7[10] = (byte)num33;
																	num4 = 667;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 674:
																	array5[9] = array8[4];
																	goto case 148;
																case 148:
																	array5[11] = array8[5];
																	goto case 325;
																case 325:
																	array5[13] = array8[6];
																	goto case 333;
																case 333:
																	array5[15] = array8[7];
																	num4 = 359;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 673:
																	num28++;
																	num4 = 165;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 672:
																	array2[21] = (byte)num10;
																	num4 = 528;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 671:
																	array2[28] = (byte)num14;
																	num = 57;
																	goto case 57;
																case 57:
																	array2[29] = 98;
																	goto case 163;
																case 163:
																	array2[29] = 91;
																	goto case 79;
																case 79:
																	num14 = 108;
																	num = 19;
																	goto case 19;
																case 19:
																	array2[29] = (byte)num14;
																	num4 = 407;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 670:
																	AG4AEFonT6onCnjkPYZ(intptr_6, qVpqG99c2WEReaDdAx(object_));
																	goto case 604;
																case 604:
																	YeeoMqaS3J(intptr_6, 4, int_2, ref int_2);
																	num = 53;
																	goto case 53;
																case 53:
																	num67++;
																	num = 616;
																	goto case 241;
																case 241:
																case 616:
																	if (num67 >= num54)
																	{
																		num4 = 306;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto IL_0b69_2;
																	}
																	goto case 6;
																case 6:
																	intptr_6 = new IntPtr(num73 + qVpqG99c2WEReaDdAx(object_) - num16);
																	goto case 651;
																case 651:
																	YeeoMqaS3J(intptr_6, 4, 4, ref int_2);
																	num4 = 670;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 669:
																	bIpvxRBRb2dOGl802m = default(BIpvxRBRb2dOGl802m);
																	num4 = 56;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 316;
																case 316:
																	reference3 = ref bIpvxRBRb2dOGl802m;
																	array = new byte[1] { 42 };
																	reference3.jsbkrdexts = array;
																	num = 515;
																	goto case 515;
																case 515:
																	bIpvxRBRb2dOGl802m.JDNkifbo3S = false;
																	num = 465;
																	goto case 465;
																case 465:
																	TL77LIo3jVmAbSU6Pr4(lmdkVksVkh, 0L, bIpvxRBRb2dOGl802m);
																	num = 549;
																	goto case 549;
																case 549:
																	jDNkifbo3S = false;
																	goto case 518;
																case 258:
																	num75 = qVpqG99c2WEReaDdAx(object_) - num16;
																	goto case 16;
																case 16:
																	num76 = qVpqG99c2WEReaDdAx(object_);
																	goto case 171;
																case 171:
																	jDNkifbo3S = false;
																	goto case 580;
																case 580:
																	if (num76 < 1879048192)
																	{
																		goto case 189;
																	}
																	goto case 523;
																case 189:
																	int_3 = qVpqG99c2WEReaDdAx(object_);
																	goto case 252;
																case 252:
																	jsbkrdexts = (byte[])a4X4WBibbNOPOEpG16(object_, int_3);
																	num4 = 48;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 208;
																case 208:
																	bIpvxRBRb2dOGl802m2 = default(BIpvxRBRb2dOGl802m);
																	goto case 142;
																case 142:
																	bIpvxRBRb2dOGl802m2.jsbkrdexts = jsbkrdexts;
																	goto case 329;
																case 329:
																	bIpvxRBRb2dOGl802m2.JDNkifbo3S = jDNkifbo3S;
																	goto case 421;
																case 421:
																	TL77LIo3jVmAbSU6Pr4(lmdkVksVkh, num73 + num75, bIpvxRBRb2dOGl802m2);
																	goto case 518;
																case 518:
																case 534:
																	if (a8jp0TzOh1jXxVdK1L(CQLXcXZ398Y8S7aiIZ(object_)) < yo7LynetO8iH3reo9x(CQLXcXZ398Y8S7aiIZ(object_)) - 1L)
																	{
																		num4 = 119;
																		if (Y9PRou3gANeThLAUl2() != null)
																		{
																			continue;
																		}
																		goto case 258;
																	}
																	goto case 24;
																case 523:
																	jDNkifbo3S = true;
																	num4 = 189;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 24:
																	intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))[0]);
																	goto case 59;
																case 59:
																	eXJkjmTXDX = intPtr2.ToInt64();
																	num4 = 125;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 337;
																case 337:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		goto case 268;
																	}
																	goto case 52;
																case 268:
																	wpoklx4RIX = rhCWlWokCRiOQGFE8fB(eXJkjmTXDX);
																	num4 = 52;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 52:
																	array6 = new byte[12];
																	num4 = 613;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 330;
																case 330:
																	mTfoQqVbOE(intptr_4, intPtr3, (byte[])dRL5SfBSlDfHVRbDp6(qVpqG99c2WEReaDdAx(object_)), 4u, out intptr_5);
																	num4 = 480;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 388;
																case 388:
																	array2[11] = 105;
																	goto case 508;
																case 508:
																	array2[11] = 147;
																	num4 = 383;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 668:
																	array2[1] = 165;
																	num = 158;
																	goto case 158;
																case 158:
																	array2[1] = 211;
																	num4 = 370;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 667:
																	num13 = 154;
																	num4 = 1;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 1;
																case 1:
																	array7[10] = (byte)num13;
																	num4 = 13;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 512;
																case 512:
																	array7[10] = 233;
																	num4 = 553;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 666:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		goto case 330;
																	}
																	goto case 91;
																case 91:
																	mTfoQqVbOE(intptr_4, intPtr3, (byte[])dRL5SfBSlDfHVRbDp6(qVpqG99c2WEReaDdAx(object_)), 4u, out intptr_5);
																	goto case 247;
																case 247:
																case 480:
																	YeeoMqaS3J(intPtr3, 4, int_2, ref int_2);
																	num4 = 521;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 665:
																	array2[22] = (byte)num10;
																	num4 = 539;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 664:
																	array10[num35] = array12[0];
																	goto case 381;
																case 381:
																	array10[num35 + 1] = array12[1];
																	goto case 457;
																case 457:
																	array10[num35 + 2] = array12[2];
																	goto case 187;
																case 187:
																	array10[num35 + 3] = array12[3];
																	goto case 406;
																case 406:
																	array10[num35 + 4] = array12[4];
																	goto case 529;
																case 529:
																	array10[num35 + 5] = array12[5];
																	num4 = 303;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 365;
																case 365:
																	array10[num35 + 6] = array12[6];
																	goto case 284;
																case 284:
																	array10[num35 + 7] = array12[7];
																	goto case 570;
																case 570:
																	num35 = 30;
																	num4 = 5;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 8;
																case 8:
																	array10[num35] = array11[0];
																	goto case 40;
																case 40:
																	array10[num35 + 1] = array11[1];
																	num4 = 647;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 663:
																	array2[24] = 110;
																	goto case 17;
																case 17:
																	num14 = 158;
																	goto case 50;
																case 50:
																	array2[24] = (byte)num14;
																	goto case 206;
																case 206:
																	array2[24] = 143;
																	goto case 402;
																case 402:
																	num14 = 150;
																	goto case 621;
																case 621:
																	array2[24] = (byte)num14;
																	goto case 582;
																case 582:
																	array2[24] = 2;
																	goto case 657;
																case 657:
																	array2[25] = 122;
																	num4 = 81;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 662:
																	num14 = 220;
																	goto case 90;
																case 90:
																	array2[9] = (byte)num14;
																	num4 = 489;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 20;
																case 20:
																	array7[2] = (byte)num33;
																	num4 = 332;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 661:
																	num28 = 0;
																	num4 = 101;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 4;
																case 4:
																case 423:
																	num9++;
																	goto case 135;
																case 135:
																case 636:
																	if (num9 >= num36)
																	{
																		goto case 594;
																	}
																	goto case 125;
																case 594:
																	array13 = array17;
																	goto case 598;
																case 598:
																	num69 = array13.Length / 8;
																	goto case 267;
																case 267:
																	array22 = (array = array13);
																	if (array22 == null)
																	{
																		break;
																	}
																	num4 = 60;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 125:
																	num74 = num9 % num59;
																	goto case 243;
																case 243:
																	num58 = num9 * 4;
																	goto case 419;
																case 419:
																	num31 = (uint)(num74 * 4);
																	goto case 25;
																case 25:
																	num12 = (uint)((array4[num31 + 3] << 24) | (array4[num31 + 2] << 16) | (array4[num31 + 1] << 8) | array4[num31]);
																	goto case 339;
																case 339:
																	num17 = 255u;
																	num4 = 656;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 660:
																	array8 = (byte[])Ja2n2A8qoejSRSPbdp(XUD6i2UlMYIHfyd1mT(x4Dk2IHVmX));
																	num = 299;
																	goto case 299;
																case 299:
																	if (array8 != null)
																	{
																		num4 = 198;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto IL_0b69_2;
																	}
																	goto case 143;
																case 143:
																	num66 = 0;
																	num4 = 488;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 659:
																	num10 = 112;
																	num = 73;
																	goto case 73;
																case 73:
																	array2[6] = (byte)num10;
																	goto case 183;
																case 183:
																	num10 = 91;
																	num = 296;
																	goto case 296;
																case 296:
																	array2[6] = (byte)num10;
																	num4 = 203;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 234:
																case 658:
																	if (num37 >= num30)
																	{
																		num = 219;
																		goto case 169;
																	}
																	goto case 497;
																case 169:
																case 219:
																	num11 = num11;
																	goto case 610;
																case 610:
																{
																	num71 = num11;
																	uint num72 = num11;
																	num72 ^= num72 << 7;
																	num72 += 1373919882;
																	num72 ^= num72 >> 9;
																	num72 += 1223955327;
																	num72 ^= num72 << 5;
																	num72 += 3092459325u;
																	num72 = 3139161922u - num72;
																	num11 = num71 + (uint)(double)num72;
																	num4 = 567;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																}
																case 497:
																	if (num37 > 0)
																	{
																		goto case 173;
																	}
																	goto case 89;
																case 173:
																	num32 <<= 8;
																	num4 = 89;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 60;
																case 60:
																	if (array.Length != 0)
																	{
																		goto IL_13dd;
																	}
																	break;
																case 260:
																	goto IL_13dd;
																case 281:
																case 401:
																	goto IL_13e7;
																case 269:
																	goto IL_13ec;
																case 322:
																	goto IL_1403;
																case 424:
																case 533:
																	goto IL_1409;
																case 89:
																	num32 |= array15[^(1 + num37)];
																	goto case 116;
																case 116:
																	num37++;
																	num4 = 658;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 656:
																	num34 = 0;
																	goto case 545;
																case 545:
																	if (num9 == num36 - 1)
																	{
																		goto case 273;
																	}
																	goto case 459;
																case 273:
																	if (num30 > 0)
																	{
																		num4 = 366;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto case 282;
																	}
																	goto case 459;
																case 282:
																	if (dVI91YrnPkdJxsxIix() != 4)
																	{
																		goto case 156;
																	}
																	goto case 592;
																case 156:
																	array20 = new byte[40];
																	dDLV76o00WPVr6s4qQ2(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
																	array9 = array20;
																	num = 353;
																	goto case 145;
																case 592:
																	array21 = new byte[30];
																	dDLV76o00WPVr6s4qQ2(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
																	array9 = array21;
																	goto case 145;
																case 145:
																case 353:
																	intPtr4 = e0UN5DoO7MCaJQH4UcX(IntPtr.Zero, (uint)array9.Length, 4096u, 64u);
																	goto case 373;
																case 373:
																	array10 = array9;
																	num4 = 641;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 459:
																	num31 = (uint)num58;
																	num4 = 36;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 14;
																case 14:
																	array6[5] = 116;
																	goto case 348;
																case 348:
																	array6[6] = 46;
																	num4 = 196;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 197;
																case 197:
																	array6[7] = 100;
																	goto case 502;
																case 502:
																	array6[8] = 108;
																	goto case 376;
																case 376:
																	array6[9] = 108;
																	num4 = 94;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 32;
																case 32:
																	array2[27] = 134;
																	num4 = 66;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 53;
																case 655:
																	intptr_4 = IntPtr.Zero;
																	num = 313;
																	goto case 313;
																case 313:
																	uint_ = (AwgKvrHJUS3TxryUsj)56;
																	goto case 599;
																case 599:
																	intptr_4 = BnRbcUmtkdq1KkRY80((uint)uint_, 1, (uint)o7okpEHxNgvXvALBJn(a71Z2JEAAImKLaHKg4()));
																	goto case 501;
																case 501:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		num4 = 89;
																		if (!zsTZIhocVLyHHxkw2B())
																		{
																			continue;
																		}
																		goto case 102;
																	}
																	goto case 159;
																case 102:
																	intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(x4Dk2IHVmX))[0]);
																	num4 = 0;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto default;
																default:
																	XtMknffM5M = intPtr2.ToInt32();
																	goto case 159;
																case 159:
																	intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(x4Dk2IHVmX))[0]);
																	goto case 379;
																case 379:
																	URnkCOceLK = intPtr2.ToInt64();
																	goto case 248;
																case 248:
																	intptr_5 = IntPtr.Zero;
																	goto case 170;
																case 170:
																	num53 = 0;
																	num4 = 9;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 654:
																	value = AZnZCaoLe5YenS0v99G(intptr_2);
																	num4 = 283;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_13e7;
																case 653:
																	array7[2] = 154;
																	goto case 262;
																case 262:
																	num33 = 116;
																	goto case 314;
																case 314:
																	array7[2] = (byte)num33;
																	num4 = 633;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 652:
																	array5[3] = array8[1];
																	goto case 565;
																case 565:
																	array5[5] = array8[2];
																	num4 = 128;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 650:
																	array7[1] = 133;
																	num4 = 131;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 649:
																	abxkLGOVrU = null;
																	num4 = 149;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 228:
																case 648:
																	if (a8jp0TzOh1jXxVdK1L(CQLXcXZ398Y8S7aiIZ(object_)) < yo7LynetO8iH3reo9x(CQLXcXZ398Y8S7aiIZ(object_)) - 1L)
																	{
																		goto case 303;
																	}
																	goto case 69;
																case 303:
																	num15 = qVpqG99c2WEReaDdAx(object_);
																	num4 = 119;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 69:
																	gPDWRhooVu9RmYFMYd9(intptr_4);
																	num4 = 21;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 20;
																case 647:
																	array10[num35 + 2] = array11[2];
																	goto case 516;
																case 516:
																	array10[num35 + 3] = array11[3];
																	goto case 62;
																case 62:
																	array10[num35 + 4] = array11[4];
																	goto case 438;
																case 438:
																	array10[num35 + 5] = array11[5];
																	goto case 118;
																case 118:
																	array10[num35 + 6] = array11[6];
																	goto case 298;
																case 298:
																	array10[num35 + 7] = array11[7];
																	num4 = 282;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 272;
																case 272:
																case 367:
																	sSUWWuShXng1BRbVoN(array10, 0, intPtr4, array10.Length);
																	goto case 326;
																case 326:
																	xo4kuDarJK = false;
																	num = 61;
																	goto case 61;
																case 61:
																	YeeoMqaS3J(new IntPtr(value), dVI91YrnPkdJxsxIix(), 64, ref int_);
																	goto case 323;
																case 323:
																	j9oi6QoJr13qBP7f6Dq(new IntPtr(value), intPtr4);
																	num4 = 450;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 267;
																case 646:
																	array2[17] = (byte)num10;
																	goto case 172;
																case 172:
																	num14 = 156;
																	goto case 458;
																case 458:
																	array2[18] = (byte)num14;
																	goto case 231;
																case 231:
																	array2[18] = 121;
																	num4 = 525;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 644:
																	array7[5] = 202;
																	goto case 10;
																case 10:
																	num33 = 72;
																	goto case 48;
																case 48:
																	array7[5] = (byte)num33;
																	goto case 394;
																case 394:
																	array7[5] = 53;
																	num4 = 315;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 114:
																	if (num56 > 0)
																	{
																		num4 = 138;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto case 53;
																	}
																	goto case 535;
																case 535:
																	array17[num58 + num56] = (byte)((num55 & num17) >> num34);
																	goto case 428;
																case 428:
																	num56++;
																	goto case 216;
																case 216:
																case 643:
																	if (num56 >= num30)
																	{
																		goto case 4;
																	}
																	goto case 114;
																case 641:
																	array11 = null;
																	num4 = 164;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 640:
																	array2[12] = 140;
																	goto case 226;
																case 226:
																	array2[12] = 36;
																	goto case 133;
																case 133:
																	array2[13] = 115;
																	num4 = 611;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 639:
																	num33 = 74;
																	num = 340;
																	goto case 340;
																case 340:
																	array7[7] = (byte)num33;
																	goto case 435;
																case 435:
																	num13 = 209;
																	num4 = 451;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 638:
																	num18 = qVpqG99c2WEReaDdAx(object_);
																	num = 581;
																	goto case 581;
																case 581:
																	if (num18 == 1)
																	{
																		num4 = 655;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto IL_0b69_2;
																	}
																	num67 = 0;
																	goto case 241;
																case 637:
																	array7[11] = 73;
																	num = 617;
																	goto case 617;
																case 617:
																	array7[12] = 115;
																	num4 = 520;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 635:
																	if (num2 == 4109628145u)
																	{
																		goto case 468;
																	}
																	goto IL_19fb_2;
																case 468:
																	flag = eteeU8xgtls3IG3UXH(rgHrDFGHQoOhoONrxI(Gm1JSA1pv5vDMUij1U(gXUHWQIcsHp9p0cVfY(a71Z2JEAAImKLaHKg4())), "__", 10u), IntPtr.Zero);
																	goto case 467;
																case 467:
																	if (!flag)
																	{
																		num4 = 80;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto case 66;
																	}
																	goto IL_19fb_2;
																case 66:
																	num14 = 133;
																	goto case 87;
																case 87:
																	array2[27] = (byte)num14;
																	goto case 246;
																case 246:
																	num14 = 93;
																	num4 = 317;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 425:
																	if (VMbOjrVdXLOXxnB30U(zAA4jhFNjEZkwnt2ce("System.Reflection.ReflectionContext", bool_0: false), null))
																	{
																		goto case 628;
																	}
																	goto case 136;
																case 628:
																	object_16 = (ProcessModuleCollection)PXMX0n2kQjCBnmMug4(a71Z2JEAAImKLaHKg4());
																	num = 595;
																	goto case 595;
																case 595:
																	enumerator = (IEnumerator)M38yQbXx7NDg3VeUb0(object_16);
																	num4 = 7;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 136:
																case 190:
																	object_ = new VtNVUKGulysZw81C3E((Stream)gw9ikDqUK6y0McRKYR(x4Dk2IHVmX, "SOtGK2hTgbJca1CMiL.2woVpUvSeoTZWsSNnb"));
																	num4 = 408;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 634:
																	array10[num35 + 5] = array3[5];
																	goto case 287;
																case 287:
																	array10[num35 + 6] = array3[6];
																	num4 = 569;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 633:
																	array7[2] = 147;
																	goto case 23;
																case 23:
																	num33 = 48;
																	goto case 20;
																case 632:
																	array2[11] = (byte)num10;
																	num = 181;
																	goto case 181;
																case 181:
																	num14 = 132;
																	goto case 511;
																case 511:
																	array2[12] = (byte)num14;
																	num4 = 398;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 61;
																case 629:
																	array2[15] = 104;
																	num4 = 2;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 627:
																	num14 = 132;
																	goto case 352;
																case 352:
																	array2[4] = (byte)num14;
																	goto case 460;
																case 460:
																	num10 = 167;
																	goto case 27;
																case 27:
																	array2[4] = (byte)num10;
																	num4 = 475;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 626:
																	XomRM8bIN8UPjHCpJl(array5, 0, array5.Length);
																	goto case 110;
																case 110:
																	Iyxe5cueaYb6cWyOUP(memoryStream);
																	goto case 99;
																case 99:
																	Iyxe5cueaYb6cWyOUP(object_8);
																	goto case 448;
																case 448:
																	cIFsBZwQxdRdEPHV3h(object_);
																	num4 = 537;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 286;
																case 286:
																	array16 = new byte[6];
																	num4 = 320;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 625:
																	array10[num27] = array12[0];
																	goto case 491;
																case 491:
																	array10[num27 + 1] = array12[1];
																	num4 = 522;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 624:
																	array2[28] = 163;
																	num4 = 58;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 33;
																case 33:
																	q9iljNK8ASXQhoMHU2(object_6, CipherMode.CBC);
																	num4 = 45;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 623:
																	array7[0] = (byte)num13;
																	goto case 295;
																case 295:
																	array7[0] = 5;
																	goto case 342;
																case 342:
																	array7[1] = 126;
																	goto case 650;
																case 622:
																	array4[num66] = (byte)(array4[num66] ^ array5[num66]);
																	goto case 180;
																case 180:
																	num66++;
																	goto case 442;
																case 442:
																case 488:
																	if (num66 >= array5.Length)
																	{
																		num4 = 202;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto IL_0b69_2;
																	}
																	goto case 622;
																case 620:
																	array2[1] = 116;
																	num4 = 507;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 460;
																case 619:
																	array7[3] = (byte)num33;
																	goto case 154;
																case 154:
																	num33 = 195;
																	num4 = 358;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 291;
																case 291:
																	array7[14] = 150;
																	goto case 218;
																case 218:
																	num13 = 99;
																	num4 = 46;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 618:
																	num73 = intPtr2.ToInt64();
																	num4 = 445;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 615:
																	if (MT03WghUnhoOR7oMCp(ppEhj6AuCDPDVD168n(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)) <= 0)
																	{
																		goto case 93;
																	}
																	goto case 630;
																case 93:
																case 587:
																	try
																	{
																		object obj5 = NoUrm9oXMVTut20JQyC(XKSpaXo2KP35YlNYYog(b0R6MpoVSSFeeVRDeIw(UF9VgZoFvmVN18c4OvL(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), b0R6MpoVSSFeeVRDeIw(UF9VgZoFvmVN18c4OvL(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)));
																		num60 = 1;
																		if (Y9PRou3gANeThLAUl2() != null)
																		{
																			goto IL_1e51;
																		}
																		goto IL_1f12;
																		IL_1f12:
																		while (true)
																		{
																			switch (num60)
																			{
																			case 17:
																				tlLX0O45pekanPs4Vv(object_15, new byte[dVI91YrnPkdJxsxIix()], 0, dVI91YrnPkdJxsxIix());
																				goto case 4;
																			case 4:
																				if (dVI91YrnPkdJxsxIix() == 4)
																				{
																					goto case 3;
																				}
																				goto case 2;
																			case 3:
																				tlLX0O45pekanPs4Vv(object_15, dRL5SfBSlDfHVRbDp6(VE2k4S5okQ.ToInt32()), 0, 4);
																				num60 = 9;
																				if (Y9PRou3gANeThLAUl2() == null)
																				{
																					continue;
																				}
																				break;
																			case 2:
																				tlLX0O45pekanPs4Vv(object_15, HtYO9goR65ZnZqNeppP(VE2k4S5okQ.ToInt64()), 0, 8);
																				goto case 9;
																			case 9:
																			case 12:
																				tlLX0O45pekanPs4Vv(object_15, new byte[dVI91YrnPkdJxsxIix()], 0, dVI91YrnPkdJxsxIix());
																				num60 = 5;
																				if (Y9PRou3gANeThLAUl2() != null)
																				{
																					continue;
																				}
																				goto case 10;
																			case 10:
																				tlLX0O45pekanPs4Vv(object_15, new byte[dVI91YrnPkdJxsxIix()], 0, dVI91YrnPkdJxsxIix());
																				num64 = 5;
																				goto case 5;
																			case 5:
																				Ljb91xfZyaVHDXcTvW(object_15, 0L);
																				num60 = 11;
																				if (Y9PRou3gANeThLAUl2() == null)
																				{
																					continue;
																				}
																				break;
																			case 14:
																				VE2k4S5okQ = (IntPtr)obj5;
																				goto case 8;
																			case 8:
																				if (LAexqA6X1I2W4ySWwq(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
																				{
																					goto case 13;
																				}
																				goto default;
																			case 13:
																				VE2k4S5okQ = (IntPtr)NoUrm9oXMVTut20JQyC(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
																				num60 = 0;
																				if (!zsTZIhocVLyHHxkw2B())
																				{
																					continue;
																				}
																				goto default;
																			default:
																				object_15 = new MemoryStream();
																				num60 = 17;
																				if (zsTZIhocVLyHHxkw2B())
																				{
																					continue;
																				}
																				break;
																			case 11:
																				array18 = (byte[])E33hZ75FLJf9RhO2jm(object_15);
																				num60 = 6;
																				if (Y9PRou3gANeThLAUl2() != null)
																				{
																					continue;
																				}
																				goto case 6;
																			case 6:
																				Iyxe5cueaYb6cWyOUP(object_15);
																				num60 = 15;
																				if (Y9PRou3gANeThLAUl2() == null)
																				{
																					continue;
																				}
																				break;
																			case 1:
																				if (obj5 is IntPtr)
																				{
																					num60 = 14;
																					if (Y9PRou3gANeThLAUl2() == null)
																					{
																						continue;
																					}
																					break;
																				}
																				goto case 8;
																			case 15:
																				nativeSizeOfCode = 0u;
																				goto case 16;
																			case 16:
																				try
																				{
																					array19 = (array = array18);
																					if (array19 != null)
																					{
																						while (array.Length != 0)
																						{
																							num61 = 1;
																							if (Y9PRou3gANeThLAUl2() != null)
																							{
																								num61 = num62;
																							}
																							switch (num61)
																							{
																							case 1:
																							case 5:
																								while (true)
																								{
																									IL_1f84:
																									fixed (byte* value2 = &array[0])
																									{
																										num61 = 0;
																										if (Y9PRou3gANeThLAUl2() != null)
																										{
																											while (true)
																											{
																												switch (num61)
																												{
																												case 6:
																													goto end_IL_1f9a;
																												case 1:
																												case 5:
																													goto IL_1f84;
																												case 4:
																													if (array.Length != 0)
																													{
																														num61 = 1;
																														if (Y9PRou3gANeThLAUl2() != null)
																														{
																															num61 = num62;
																														}
																														continue;
																													}
																													goto end_IL_1f9a;
																												case 3:
																													goto end_IL_1f84;
																												}
																												goto IL_1fcc;
																												continue;
																												end_IL_1f9a:
																												break;
																											}
																											goto end_IL_1fbd;
																										}
																										goto IL_1fcc;
																										IL_1fcc:
																										rNZkehfwNu(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
																										break;
																									}
																									continue;
																									end_IL_1f84:
																									break;
																								}
																								goto end_IL_1f68;
																							case 4:
																								break;
																							case 6:
																								goto end_IL_1fbd;
																							default:
																								goto IL_1fcc_2;
																							case 3:
																								goto end_IL_1f68;
																							}
																							continue;
																							end_IL_1fbd:
																							break;
																						}
																					}
																					reference = ref *(byte*)null;
																					goto IL_1fcc_2;
																					IL_1fcc_2:
																					rNZkehfwNu(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), ref nativeSizeOfCode);
																					end_IL_1f68:;
																				}
																				finally
																				{
																					reference = ref *(byte*)null;
																					num63 = 0;
																					if (zsTZIhocVLyHHxkw2B())
																					{
																						switch (num63)
																						{
																						}
																					}
																				}
																				goto end_IL_1f12;
																			case 7:
																				goto end_IL_1f12;
																			}
																			goto IL_1e51;
																			continue;
																			end_IL_1f12:
																			break;
																		}
																		goto end_IL_1d20;
																		IL_1e51:
																		num60 = num64;
																		goto IL_1f12;
																		end_IL_1d20:;
																	}
																	catch (object obj6)
																	{
																		num65 = 0;
																		if (!zsTZIhocVLyHHxkw2B())
																		{
																			switch (num65)
																			{
																			}
																		}
																	}
																	goto case 71;
																case 482:
																	QW0CkRo6EUIwsdX7Vo6(JnhiujosIZn7uGuVX80(cgChBZoxLmfaYfCPCnB(abxkLGOVrU)));
																	num = 309;
																	goto case 309;
																case 309:
																	ktV5QQovHKuvUeDP367(rNZkehfwNu);
																	num4 = 76;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 614:
																	array2[26] = 118;
																	num4 = 43;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 556;
																case 556:
																	array2[26] = 190;
																	goto case 327;
																case 327:
																	num10 = 247;
																	num4 = 35;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 613:
																	array6[0] = 109;
																	goto case 107;
																case 107:
																	array6[1] = 115;
																	goto case 151;
																case 151:
																	array6[2] = 99;
																	num4 = 586;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 79;
																case 612:
																	array7[9] = 149;
																	goto case 147;
																case 147:
																	num33 = 128;
																	num4 = 134;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 611:
																	array2[13] = 108;
																	num4 = 278;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 371;
																case 371:
																	array2[13] = 159;
																	num4 = 290;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 609:
																	intPtr3 = new IntPtr(URnkCOceLK + qVpqG99c2WEReaDdAx(object_) - num16);
																	goto case 601;
																case 601:
																	YeeoMqaS3J(intPtr3, 4, 4, ref int_2);
																	goto case 666;
																case 608:
																	array2[21] = (byte)num14;
																	num4 = 204;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 28;
																case 28:
																	array16[5] = 116;
																	goto case 420;
																case 420:
																	string_ = (string)sHN3epoQMZK4PFcuHtL(bBJEAloYpNk4UyJ8sHr(), array16);
																	goto case 137;
																case 137:
																	procAddress = GetProcAddress(intptr_3, string_);
																	num4 = 49;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 55;
																case 55:
																	object_14 = (OFfwWh6ZIHjfnqBOWx)dmG9BboWinYvTUuBkri(procAddress, pGvyaUoCs0e61yToSVX(typeof(OFfwWh6ZIHjfnqBOWx).TypeHandle));
																	num4 = 554;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 607:
																	array2[30] = (byte)num14;
																	num = 112;
																	goto case 112;
																case 112:
																	array2[30] = 121;
																	num = 410;
																	goto case 410;
																case 410:
																	array2[30] = 211;
																	num4 = 11;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 10;
																case 606:
																	array7[7] = 46;
																	goto case 141;
																case 141:
																	array7[7] = 66;
																	goto case 561;
																case 561:
																	array7[7] = 105;
																	goto case 229;
																case 229:
																	array7[7] = 119;
																	num4 = 158;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 639;
																case 605:
																	num14 = 91;
																	goto case 210;
																case 210:
																	array2[15] = (byte)num14;
																	num4 = 444;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 602:
																	array7[14] = 142;
																	goto case 384;
																case 384:
																	num13 = 84;
																	goto case 321;
																case 321:
																	array7[14] = (byte)num13;
																	num = 215;
																	goto case 215;
																case 215:
																	array7[14] = 152;
																	goto case 211;
																case 211:
																	array7[14] = 48;
																	num4 = 77;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 600:
																	num10 = 143;
																	goto case 225;
																case 225:
																	array2[2] = (byte)num10;
																	goto case 393;
																case 393:
																	array2[2] = 203;
																	num4 = 375;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 551;
																case 551:
																	array2[3] = 110;
																	num4 = 19;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 251;
																case 251:
																	array2[3] = 126;
																	num4 = 139;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 597:
																	num16 = 7680;
																	goto case 432;
																case 432:
																case 466:
																	num54 = qVpqG99c2WEReaDdAx(object_);
																	goto case 443;
																case 443:
																	num18 = qVpqG99c2WEReaDdAx(object_);
																	num4 = 144;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 135;
																case 593:
																	array7[6] = (byte)num33;
																	goto case 583;
																case 583:
																	array7[7] = 87;
																	num4 = 606;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 368;
																case 368:
																	array10[num27] = array11[0];
																	num4 = 162;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 48;
																case 591:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		goto case 404;
																	}
																	goto case 121;
																case 404:
																	num19 = tw5WoxoSTRX6DVyYiHj(new IntPtr(value));
																	num4 = 490;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 129;
																case 129:
																	object_ = new VtNVUKGulysZw81C3E(new MemoryStream(array13));
																	num4 = 380;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 418;
																case 418:
																	Ljb91xfZyaVHDXcTvW(CQLXcXZ398Y8S7aiIZ(object_), 0L);
																	goto case 487;
																case 487:
																	intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(x4Dk2IHVmX))[0]);
																	num4 = 300;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 618;
																case 121:
																	num19 = AZnZCaoLe5YenS0v99G(new IntPtr(value));
																	goto case 100;
																case 100:
																case 490:
																	object_9 = (Process)a71Z2JEAAImKLaHKg4();
																	num4 = 509;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 590:
																	array17 = new byte[array15.Length];
																	num = 302;
																	goto case 302;
																case 302:
																	num59 = array4.Length / 4;
																	goto case 377;
																case 377:
																	num11 = 0u;
																	goto case 380;
																case 380:
																	num12 = 0u;
																	goto case 271;
																case 271:
																	num32 = 0u;
																	goto case 422;
																case 422:
																	if (num30 > 0)
																	{
																		goto case 555;
																	}
																	goto case 78;
																case 555:
																	num36++;
																	goto case 78;
																case 78:
																	num31 = 0u;
																	num4 = 22;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 589:
																	array7[6] = (byte)num13;
																	num4 = 279;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 427;
																case 427:
																	num33 = 110;
																	goto case 362;
																case 362:
																	array7[6] = (byte)num33;
																	goto case 471;
																case 471:
																	num33 = 146;
																	num4 = 593;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 588:
																	num14 = 34;
																	num4 = 88;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 586:
																	array6[3] = 111;
																	num = 461;
																	goto case 461;
																case 461:
																	array6[4] = 114;
																	num = 140;
																	goto case 140;
																case 140:
																	array6[5] = 106;
																	num4 = 574;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 585:
																	if (ppEhj6AuCDPDVD168n(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly) == null)
																	{
																		num4 = 587;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto IL_0b69_2;
																	}
																	goto case 615;
																case 224:
																case 584:
																	int_ = 0;
																	num4 = 99;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 200;
																case 200:
																	if (!PwZxQBoGJcRYPUUSxpn(LvTgFno13q17LPWObCi(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
																	{
																		goto case 93;
																	}
																	num = 538;
																	goto case 538;
																case 538:
																	if (((Array)pr3tUVorR8p3TGjMUyr(LvTgFno13q17LPWObCi(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).Length != 2)
																	{
																		goto case 93;
																	}
																	goto case 585;
																case 578:
																	array2[31] = (byte)num10;
																	goto case 568;
																case 568:
																	num10 = 113;
																	goto case 201;
																case 201:
																	array2[31] = (byte)num10;
																	goto case 514;
																case 514:
																	num10 = 102;
																	num4 = 510;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 577:
																	array2[14] = 64;
																	goto case 447;
																case 447:
																	num10 = 90;
																	num4 = 297;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 576:
																	num14 = 198;
																	num4 = 334;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 575:
																	num10 = 205;
																	num4 = 26;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 574:
																	array6[6] = 105;
																	num4 = 357;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 134;
																case 134:
																	array7[9] = (byte)num33;
																	goto case 675;
																case 573:
																	array2[20] = 123;
																	goto case 558;
																case 558:
																	num10 = 94;
																	goto case 544;
																case 544:
																	array2[20] = (byte)num10;
																	goto case 310;
																case 310:
																	num10 = 111;
																	goto case 472;
																case 472:
																	array2[20] = (byte)num10;
																	num4 = 150;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 572:
																	array2[28] = (byte)num14;
																	num4 = 123;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 624;
																case 571:
																	num14 = 221;
																	num = 517;
																	goto case 517;
																case 517:
																	array2[5] = (byte)num14;
																	goto case 72;
																case 72:
																	array2[5] = 130;
																	goto case 469;
																case 469:
																	num14 = 122;
																	goto case 236;
																case 236:
																	array2[5] = (byte)num14;
																	num4 = 117;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 569:
																	array10[num35 + 7] = array3[7];
																	goto case 106;
																case 106:
																	num35 = 18;
																	num4 = 664;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 436;
																case 436:
																	array4 = array2;
																	num4 = 237;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 567:
																	if (num9 == num36 - 1)
																	{
																		goto case 351;
																	}
																	goto case 542;
																case 351:
																	if (num30 > 0)
																	{
																		goto case 82;
																	}
																	goto case 542;
																case 82:
																	num55 = num11 ^ num32;
																	goto case 177;
																case 177:
																	num56 = 0;
																	num4 = 643;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 14;
																case 542:
																	num57 = num11 ^ num32;
																	goto case 356;
																case 356:
																	array17[num58] = (byte)(num57 & 0xFFu);
																	num4 = 190;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 259;
																case 259:
																	array17[num58 + 1] = (byte)((num57 & 0xFF00) >> 8);
																	num = 195;
																	goto case 195;
																case 195:
																	array17[num58 + 2] = (byte)((num57 & 0xFF0000) >> 16);
																	goto case 111;
																case 111:
																	array17[num58 + 3] = (byte)((num57 & 0xFF000000u) >> 24);
																	goto case 4;
																case 566:
																	array2[16] = 74;
																	goto case 548;
																case 548:
																	array2[17] = 136;
																	num4 = 220;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 564:
																	array2[23] = 144;
																	goto case 486;
																case 486:
																	array2[23] = 92;
																	goto case 83;
																case 83:
																	array2[24] = 86;
																	goto case 663;
																case 563:
																	array16[1] = 101;
																	num4 = 220;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 279;
																case 279:
																	array16[2] = 116;
																	num4 = 253;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 562:
																	array10[num27 + 3] = array11[3];
																	goto case 272;
																case 560:
																	num14 = 92;
																	num = 559;
																	goto case 559;
																case 559:
																	array2[2] = (byte)num14;
																	num4 = 600;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 557:
																	num33 = 249;
																	goto case 155;
																case 155:
																	array7[8] = (byte)num33;
																	goto case 612;
																case 554:
																	intptr_2 = xupvcpocKUiHHa9GIJc(object_14);
																	goto case 130;
																case 130:
																	value = 0L;
																	num4 = 160;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 553:
																	num33 = 129;
																	goto case 363;
																case 363:
																	array7[11] = (byte)num33;
																	num4 = 397;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 552:
																	array = new byte[1];
																	goto case 3;
																case 3:
																	sSUWWuShXng1BRbVoN(array, 0, oTMvA6c4kGBeCHbTs3(8), 1);
																	goto case 232;
																case 232:
																	EbLcZfLqERCnRuQ379();
																	goto case 635;
																case 550:
																	array10[num35 + 3] = array3[3];
																	goto case 456;
																case 456:
																	array10[num35 + 4] = array3[4];
																	num4 = 634;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 547:
																	array2[3] = (byte)num14;
																	goto case 344;
																case 344:
																	array2[3] = 34;
																	num4 = 588;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 627;
																case 546:
																	intptr_3 = LoadLibrary(text);
																	goto case 286;
																case 543:
																	YeeoMqaS3J(intptr_, num29 * 4, int_2, ref int_2);
																	goto case 228;
																case 541:
																	array7[1] = 169;
																	goto case 411;
																case 411:
																	array7[2] = 104;
																	goto case 506;
																case 506:
																	num13 = 113;
																	goto case 70;
																case 70:
																	array7[2] = (byte)num13;
																	goto case 653;
																case 540:
																	num14 = 149;
																	goto case 519;
																case 519:
																	array2[16] = (byte)num14;
																	num4 = 566;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 539:
																	num14 = 134;
																	goto case 478;
																case 478:
																	array2[23] = (byte)num14;
																	goto case 564;
																case 537:
																	num54 = qVpqG99c2WEReaDdAx(object_);
																	goto case 638;
																case 536:
																	AG4AEFonT6onCnjkPYZ(new IntPtr(intptr_.ToInt64() + num28 * 4), qVpqG99c2WEReaDdAx(object_));
																	goto case 673;
																case 532:
																	intPtr = WhYKoEoEVDj0BRONceg(rNZkehfwNu);
																	goto case 415;
																case 415:
																	num19 = 0L;
																	goto case 591;
																case 531:
																	array7[3] = (byte)num13;
																	num4 = 56;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 530:
																	array10[num27 + 3] = array12[3];
																	num4 = 270;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 528:
																	num14 = 228;
																	goto case 608;
																case 527:
																	num13 = 85;
																	goto case 235;
																case 235:
																	array7[11] = (byte)num13;
																	num4 = 230;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 223;
																case 223:
																	array16[4] = 105;
																	goto case 28;
																case 526:
																	array2[4] = (byte)num14;
																	num4 = 571;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 525:
																	num10 = 117;
																	goto case 54;
																case 54:
																	array2[18] = (byte)num10;
																	goto case 34;
																case 34:
																	num10 = 181;
																	goto case 349;
																case 349:
																	array2[18] = (byte)num10;
																	num = 576;
																	goto case 576;
																case 524:
																	array2[10] = 107;
																	goto case 92;
																case 92:
																	array2[10] = 139;
																	num = 261;
																	goto case 261;
																case 261:
																	num10 = 11;
																	goto case 346;
																case 346:
																	array2[10] = (byte)num10;
																	num4 = 388;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 522:
																	array10[num27 + 2] = array12[2];
																	num4 = 530;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 521:
																	num53++;
																	goto case 9;
																case 9:
																case 12:
																	if (num53 >= num54)
																	{
																		goto case 228;
																	}
																	goto case 609;
																case 520:
																	num33 = 180;
																	num = 396;
																	goto case 396;
																case 396:
																	array7[12] = (byte)num33;
																	num4 = 36;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 446;
																case 446:
																	array7[12] = 54;
																	num4 = 300;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 97;
																case 97:
																	array2[22] = 160;
																	num = 222;
																	goto case 222;
																case 222:
																	num10 = 141;
																	num4 = 115;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 46;
																case 46:
																	array7[14] = (byte)num13;
																	goto case 602;
																case 513:
																	array6[4] = 105;
																	goto case 14;
																case 510:
																	array2[31] = (byte)num10;
																	goto case 124;
																case 124:
																	num10 = 140;
																	goto case 209;
																case 209:
																	array2[31] = (byte)num10;
																	goto case 588;
																case 509:
																	try
																	{
																		ProcessModuleCollection object_10 = (ProcessModuleCollection)PXMX0n2kQjCBnmMug4(object_9);
																		num38 = 2;
																		if (!zsTZIhocVLyHHxkw2B())
																		{
																			num38 = num39;
																		}
																		while (true)
																		{
																			switch (num38)
																			{
																			case 2:
																				goto IL_2d71;
																			case 1:
																				goto end_IL_2d86;
																			}
																			goto IL_2d9a;
																			IL_2d71:
																			enumerator = (IEnumerator)M38yQbXx7NDg3VeUb0(object_10);
																			num38 = 0;
																			if (!zsTZIhocVLyHHxkw2B())
																			{
																				continue;
																			}
																			goto IL_2d9a;
																			IL_2d9a:
																			try
																			{
																				while (mA0d81jE1xtIkO2NjW(enumerator))
																				{
																					while (true)
																					{
																						ProcessModule object_11 = (ProcessModule)NIfdmWRmdKAueFHZB9(enumerator);
																						num40 = 4;
																						if (Y9PRou3gANeThLAUl2() != null)
																						{
																							goto IL_2e0e;
																						}
																						goto IL_2e36;
																						IL_2e36:
																						while (true)
																						{
																							switch (num40)
																							{
																							case 7:
																								num41 = num19;
																								intPtr2 = Gm1JSA1pv5vDMUij1U(object_11);
																								if (num41 >= intPtr2.ToInt64())
																								{
																									goto case 2;
																								}
																								goto default;
																							case 2:
																								num42 = num19;
																								intPtr2 = Gm1JSA1pv5vDMUij1U(object_11);
																								if (num42 <= intPtr2.ToInt64() + exd8eVoIf4YbeAwGfl2(object_11))
																								{
																									goto end_IL_2e6c;
																								}
																								num40 = 0;
																								if (Y9PRou3gANeThLAUl2() == null)
																								{
																									continue;
																								}
																								goto default;
																							default:
																								if (!PwZxQBoGJcRYPUUSxpn(LvTgFno13q17LPWObCi(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
																								{
																									goto IL_2e01;
																								}
																								goto case 6;
																							case 4:
																								if (LAexqA6X1I2W4ySWwq(AOFJ78vTLsOCHOIh1G(object_11), text))
																								{
																									goto case 7;
																								}
																								goto IL_2e27;
																							case 8:
																								break;
																							case 1:
																							case 3:
																							case 5:
																								goto end_IL_2e6c;
																							case 6:
																								Clrlm6amwrPntrY5km();
																								return;
																							case 9:
																								return;
																							case 10:
																								goto end_IL_2e89;
																							}
																							break;
																							IL_2e27:
																							num40 = 5;
																							if (Y9PRou3gANeThLAUl2() == null)
																							{
																								continue;
																							}
																							goto IL_2e0e;
																							IL_2e01:
																							num40 = 1;
																							if (zsTZIhocVLyHHxkw2B())
																							{
																								continue;
																							}
																							goto IL_2e0e;
																						}
																						continue;
																						IL_2e0e:
																						num40 = num43;
																						goto IL_2e36;
																						continue;
																						end_IL_2e6c:
																						break;
																					}
																					continue;
																					end_IL_2e89:
																					break;
																				}
																			}
																			finally
																			{
																				IDisposable disposable = enumerator as IDisposable;
																				num44 = 1;
																				if (!zsTZIhocVLyHHxkw2B())
																				{
																					goto IL_2ecc;
																				}
																				goto IL_2ee5;
																				IL_2ee5:
																				while (true)
																				{
																					switch (num44)
																					{
																					case 2:
																						PoZNpcNTKX7VUasV1N(disposable);
																						num44 = 3;
																						if (Y9PRou3gANeThLAUl2() == null)
																						{
																							continue;
																						}
																						break;
																					case 1:
																						if (disposable == null)
																						{
																							num44 = 0;
																							if (Y9PRou3gANeThLAUl2() == null)
																							{
																								continue;
																							}
																							break;
																						}
																						goto case 2;
																					default:
																						goto end_IL_2ee5;
																					}
																					goto IL_2ecc;
																					continue;
																					end_IL_2ee5:
																					break;
																				}
																				goto end_IL_2ea0;
																				IL_2ecc:
																				num44 = num45;
																				goto IL_2ee5;
																				end_IL_2ea0:;
																			}
																			break;
																			continue;
																			end_IL_2d86:
																			break;
																		}
																	}
																	catch (object obj3)
																	{
																		num46 = 0;
																		if (Y9PRou3gANeThLAUl2() != null)
																		{
																			num46 = num47;
																		}
																		switch (num46)
																		{
																		}
																	}
																	goto case 335;
																case 335:
																	try
																	{
																		ProcessModuleCollection object_12 = (ProcessModuleCollection)PXMX0n2kQjCBnmMug4(object_9);
																		num48 = 0;
																		if (Y9PRou3gANeThLAUl2() != null)
																		{
																			switch (num48)
																			{
																			case 2:
																				goto IL_2f4c;
																			case 1:
																				goto end_IL_2f1a;
																			}
																		}
																		enumerator = (IEnumerator)M38yQbXx7NDg3VeUb0(object_12);
																		goto IL_2f4c;
																		IL_2f4c:
																		try
																		{
																			while (true)
																			{
																				IL_2fcf:
																				if (!mA0d81jE1xtIkO2NjW(enumerator))
																				{
																					num49 = 5;
																					if (zsTZIhocVLyHHxkw2B())
																					{
																						break;
																					}
																					goto IL_2f73;
																				}
																				goto IL_2fb1;
																				IL_2f73:
																				while (true)
																				{
																					switch (num49)
																					{
																					case 2:
																						break;
																					case 4:
																						goto end_IL_2f73;
																					case 5:
																						goto IL_2fa6;
																					default:
																						goto IL_2fb1;
																					case 1:
																						goto IL_2fcf;
																					case 3:
																					case 6:
																						goto end_IL_2fcf;
																					}
																					num16 = 0;
																					num49 = 3;
																					if (Y9PRou3gANeThLAUl2() == null)
																					{
																						continue;
																					}
																					goto IL_2f6f;
																					continue;
																					end_IL_2f73:
																					break;
																				}
																				goto IL_2f96;
																				IL_2fb1:
																				object_13 = (ProcessModule)NIfdmWRmdKAueFHZB9(enumerator);
																				goto IL_2fa6;
																				IL_2fa6:
																				intPtr2 = Gm1JSA1pv5vDMUij1U(object_13);
																				goto IL_2f96;
																				IL_2f96:
																				if (intPtr2.ToInt64() != eXJkjmTXDX)
																				{
																					continue;
																				}
																				num49 = 2;
																				if (Y9PRou3gANeThLAUl2() != null)
																				{
																					goto IL_2f6f;
																				}
																				goto IL_2f73;
																				IL_2f6f:
																				num49 = num50;
																				goto IL_2f73;
																				continue;
																				end_IL_2fcf:
																				break;
																			}
																		}
																		finally
																		{
																			IDisposable disposable = enumerator as IDisposable;
																			while (disposable != null)
																			{
																				while (true)
																				{
																					PoZNpcNTKX7VUasV1N(disposable);
																					num51 = 0;
																					if (Y9PRou3gANeThLAUl2() == null)
																					{
																						switch (num51)
																						{
																						case 1:
																							continue;
																						default:
																							goto end_IL_2fe8;
																						case 3:
																							break;
																						case 0:
																						case 2:
																							goto end_IL_2fe8;
																						}
																						goto IL_3012;
																					}
																					break;
																					continue;
																					end_IL_2fe8:
																					break;
																				}
																				break;
																				IL_3012:;
																			}
																		}
																		end_IL_2f1a:;
																	}
																	catch (object obj4)
																	{
																		num52 = 0;
																		if (zsTZIhocVLyHHxkw2B())
																		{
																			switch (num52)
																			{
																			}
																		}
																	}
																	goto case 649;
																case 507:
																	array2[1] = 124;
																	goto case 668;
																case 504:
																	num33 = 117;
																	goto case 619;
																case 503:
																	array2[9] = 107;
																	num = 662;
																	goto case 662;
																case 500:
																	num10 = 23;
																	num4 = 341;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 499:
																	array2[6] = (byte)num10;
																	num4 = 463;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 498:
																	array2[19] = 129;
																	goto case 192;
																case 192:
																	num14 = 99;
																	num4 = 207;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 496:
																	object_6 = (SymmetricAlgorithm)VGrrEoDggRjTHsda21();
																	num4 = 33;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 495:
																	array2[25] = (byte)num14;
																	goto case 5;
																case 5:
																	array2[25] = 27;
																	num4 = 16;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 42;
																case 42:
																	num10 = 160;
																	num = 390;
																	goto case 390;
																case 390:
																	array2[25] = (byte)num10;
																	num = 188;
																	goto case 188;
																case 188:
																	num10 = 143;
																	goto case 176;
																case 176:
																	array2[25] = (byte)num10;
																	goto case 239;
																case 239:
																	array2[25] = 175;
																	goto case 213;
																case 213:
																	num10 = 88;
																	goto case 146;
																case 146:
																	array2[26] = (byte)num10;
																	num4 = 462;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 494:
																	array11 = (byte[])dRL5SfBSlDfHVRbDp6(intPtr.ToInt32());
																	num4 = 331;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 493:
																	array10[num27 + 1] = array3[1];
																	num4 = 122;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 311;
																case 311:
																	array10[num27 + 2] = array3[2];
																	goto case 67;
																case 67:
																	array10[num27 + 3] = array3[3];
																	num4 = 255;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 492:
																	array2[27] = 152;
																	goto case 104;
																case 104:
																	array2[27] = 70;
																	goto case 485;
																case 485:
																	num10 = 134;
																	goto case 179;
																case 179:
																	array2[28] = (byte)num10;
																	num4 = 123;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 99;
																case 489:
																	array2[10] = 159;
																	num4 = 524;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 484:
																	num14 = 149;
																	num4 = 55;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 671;
																case 483:
																	text = (string)sHN3epoQMZK4PFcuHtL(bBJEAloYpNk4UyJ8sHr(), array6);
																	goto case 434;
																case 434:
																	intptr_3 = LoadLibrary(text);
																	num4 = 476;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 331;
																case 331:
																	array12 = (byte[])dRL5SfBSlDfHVRbDp6(rhCWlWokCRiOQGFE8fB(num19));
																	num4 = 75;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 98;
																case 98:
																case 233:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		num4 = 4;
																		if (Y9PRou3gANeThLAUl2() != null)
																		{
																			continue;
																		}
																		goto case 374;
																	}
																	goto case 65;
																case 374:
																	num27 = 9;
																	goto case 304;
																case 304:
																	array10[num27] = array3[0];
																	num4 = 493;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 65:
																	num35 = 2;
																	goto case 441;
																case 441:
																	array10[num35] = array3[0];
																	goto case 395;
																case 395:
																	array10[num35 + 1] = array3[1];
																	num4 = 184;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 69;
																case 481:
																	array7[15] = (byte)num13;
																	goto case 392;
																case 392:
																	array7[15] = 99;
																	num = 378;
																	goto case 378;
																case 378:
																	array7[15] = 101;
																	num4 = 109;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 2;
																case 2:
																	array2[15] = 147;
																	goto case 605;
																case 479:
																	array6[0] = 99;
																	num4 = 248;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 249;
																case 249:
																	array6[1] = 108;
																	goto case 430;
																case 430:
																	array6[2] = 114;
																	num = 416;
																	goto case 416;
																case 416:
																	array6[3] = 106;
																	num4 = 513;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 477:
																	array2[7] = 112;
																	goto case 44;
																case 44:
																	array2[7] = 92;
																	goto case 264;
																case 264:
																	array2[8] = 155;
																	num4 = 473;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 476:
																	if (!aiB4GaolTgcn8wKBVnj(intptr_3, IntPtr.Zero))
																	{
																		goto case 286;
																	}
																	num4 = 360;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 195;
																case 475:
																	num14 = 58;
																	num4 = 387;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 474:
																	num33 = 167;
																	goto case 285;
																case 285:
																	array7[8] = (byte)num33;
																	num4 = 557;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 557;
																case 473:
																	array2[8] = 92;
																	goto case 500;
																case 470:
																	num10 = 94;
																	goto case 672;
																case 464:
																	memoryStream = new MemoryStream();
																	num4 = 280;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 463:
																	array2[6] = 102;
																	num4 = 122;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 462:
																	array2[26] = 99;
																	goto case 614;
																case 455:
																	array7[8] = 199;
																	goto case 474;
																case 454:
																	num10 = 134;
																	goto case 345;
																case 345:
																	array2[0] = (byte)num10;
																	goto case 212;
																case 212:
																	array2[0] = 103;
																	num4 = 391;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 35;
																case 35:
																	array2[26] = (byte)num10;
																	num4 = 417;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 183;
																case 453:
																	array7[0] = (byte)num33;
																	goto case 31;
																case 31:
																	num13 = 170;
																	goto case 182;
																case 182:
																	array7[0] = (byte)num13;
																	num4 = 439;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 452:
																	array2[13] = (byte)num14;
																	goto case 214;
																case 214:
																	num10 = 220;
																	goto case 193;
																case 193:
																	array2[13] = (byte)num10;
																	num4 = 74;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 451:
																	array7[8] = (byte)num13;
																	goto case 455;
																case 449:
																	num13 = 150;
																	num = 29;
																	goto case 29;
																case 29:
																	array7[0] = (byte)num13;
																	num4 = 120;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 445:
																	int_2 = 0;
																	goto case 68;
																case 68:
																	num16 = 0;
																	goto case 84;
																case 84:
																	if (ppEhj6AuCDPDVD168n(x4Dk2IHVmX) == null)
																	{
																		goto case 597;
																	}
																	goto case 132;
																case 132:
																	if (MT03WghUnhoOR7oMCp(ppEhj6AuCDPDVD168n(x4Dk2IHVmX)) == 0)
																	{
																		goto case 597;
																	}
																	goto case 432;
																case 444:
																	array2[16] = 135;
																	num4 = 354;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 440:
																	num14 = 119;
																	goto case 199;
																case 199:
																	array2[7] = (byte)num14;
																	goto case 382;
																case 382:
																	num14 = 123;
																	goto case 266;
																case 266:
																	array2[7] = (byte)num14;
																	goto case 477;
																case 439:
																	num33 = 120;
																	goto case 385;
																case 385:
																	array7[0] = (byte)num33;
																	goto case 336;
																case 336:
																	num13 = 168;
																	goto case 623;
																case 437:
																	array6[8] = 46;
																	goto case 355;
																case 355:
																	array6[9] = 100;
																	goto case 157;
																case 157:
																	array6[10] = 108;
																	num4 = 75;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 433:
																	array2[5] = (byte)num14;
																	goto case 659;
																case 431:
																	num37 = 0;
																	num4 = 179;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 234;
																case 429:
																	num14 = 199;
																	num4 = 116;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 526;
																case 426:
																	array7[13] = 123;
																	goto case 372;
																case 372:
																	array7[13] = 37;
																	num = 205;
																	goto case 205;
																case 205:
																	array7[13] = 52;
																	goto case 276;
																case 276:
																	array7[13] = 146;
																	num4 = 49;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 417:
																	array2[27] = 154;
																	goto case 32;
																case 414:
																	num36 = array15.Length / 4;
																	num4 = 150;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 590;
																case 413:
																	array7[12] = 56;
																	num4 = 69;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 85;
																case 85:
																	num13 = 134;
																	goto case 307;
																case 307:
																	array7[13] = (byte)num13;
																	goto case 426;
																case 412:
																	array3 = (byte[])dRL5SfBSlDfHVRbDp6(VE2k4S5okQ.ToInt32());
																	num4 = 241;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 494;
																case 409:
																	num32 = 0u;
																	goto case 431;
																case 408:
																	Ljb91xfZyaVHDXcTvW(CQLXcXZ398Y8S7aiIZ(object_), 0L);
																	goto case 263;
																case 263:
																	array14 = (byte[])a4X4WBibbNOPOEpG16(object_, (int)yo7LynetO8iH3reo9x(CQLXcXZ398Y8S7aiIZ(object_)));
																	goto case 38;
																case 38:
																	array2 = new byte[32];
																	goto case 454;
																case 407:
																	num10 = 160;
																	goto case 51;
																case 51:
																	array2[29] = (byte)num10;
																	goto case 294;
																case 294:
																	array2[29] = 144;
																	num4 = 199;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 277;
																case 277:
																	num14 = 106;
																	goto case 607;
																case 403:
																	array5[1] = array8[0];
																	num4 = 652;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 562;
																case 400:
																	array11 = (byte[])HtYO9goR65ZnZqNeppP(intPtr.ToInt64());
																	num4 = 178;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 398:
																	array2[12] = 169;
																	goto case 640;
																case 397:
																	array7[11] = 114;
																	num4 = 293;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 5;
																case 391:
																	array2[0] = 158;
																	goto case 343;
																case 343:
																	array2[0] = 175;
																	goto case 620;
																case 389:
																	num10 = 190;
																	goto case 665;
																case 387:
																	array2[4] = (byte)num14;
																	goto case 429;
																case 386:
																	array2[30] = 130;
																	goto case 289;
																case 289:
																	array2[30] = 184;
																	num4 = 191;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 383:
																	num10 = 171;
																	num4 = 632;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 375:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		goto case 412;
																	}
																	goto case 301;
																case 301:
																	array3 = (byte[])HtYO9goR65ZnZqNeppP(VE2k4S5okQ.ToInt64());
																	num4 = 400;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 370:
																	array2[2] = 131;
																	goto case 105;
																case 105:
																	array2[2] = 203;
																	num4 = 532;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 560;
																case 369:
																	oGhRhplYdDMGaAZ2Bp(new IntPtr(&num3), 0, 0);
																	goto case 13;
																case 13:
																	OtIrloWOhTIlSVacEw(new IntPtr(&num3), 0, 0L);
																	num = 552;
																	goto case 552;
																case 366:
																	num11 += num12;
																	num4 = 409;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 120;
																case 120:
																	num33 = 105;
																	num = 453;
																	goto case 453;
																case 364:
																	num14 = 92;
																	num4 = 452;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 360:
																	array6 = new byte[10];
																	num = 479;
																	goto case 479;
																case 359:
																	XomRM8bIN8UPjHCpJl(array8, 0, array8.Length);
																	goto case 143;
																case 358:
																	array7[3] = (byte)num33;
																	goto case 127;
																case 127:
																	array7[3] = 123;
																	goto case 167;
																case 167:
																	num13 = 152;
																	num4 = 531;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 51;
																case 357:
																	array6[7] = 116;
																	goto case 437;
																case 354:
																	array2[16] = 54;
																	goto case 540;
																case 350:
																	array2[6] = (byte)num14;
																	goto case 265;
																case 265:
																	num10 = 150;
																	goto case 499;
																case 341:
																	array2[8] = (byte)num10;
																	goto case 39;
																case 39:
																	array2[9] = 170;
																	goto case 503;
																case 338:
																	array2[15] = 143;
																	num4 = 629;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 334:
																	array2[18] = (byte)num14;
																	goto case 238;
																case 238:
																	array2[19] = 108;
																	num4 = 498;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 63;
																case 63:
																	num29 = qVpqG99c2WEReaDdAx(object_);
																	num4 = 47;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 103;
																case 103:
																	YeeoMqaS3J(intptr_, num29 * 4, 4, ref int_2);
																	goto case 661;
																case 332:
																	array7[3] = 29;
																	num4 = 312;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 184;
																case 184:
																	array10[num35 + 2] = array3[2];
																	goto case 550;
																case 320:
																	array16[0] = 103;
																	goto case 563;
																case 318:
																	goto end_IL_13dd;
																case 317:
																	array2[27] = (byte)num14;
																	num4 = 126;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 492;
																case 315:
																	num13 = 115;
																	num4 = 676;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 191;
																case 191:
																	num10 = 104;
																	goto case 578;
																case 312:
																	array7[3] = 126;
																	num4 = 504;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 308:
																	num34 += 8;
																	num4 = 535;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 329;
																case 306:
																	lmdkVksVkh = new Hashtable(qVpqG99c2WEReaDdAx(object_) + 1);
																	goto case 669;
																case 305:
																	value = tw5WoxoSTRX6DVyYiHj(intptr_2);
																	goto case 168;
																case 168:
																case 283:
																	YGO4smCLb05L3pQqWL(intptr_2, 0);
																	num4 = 86;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 19;
																case 300:
																	array7[12] = 157;
																	num4 = 413;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 6;
																case 297:
																	array2[15] = (byte)num10;
																	num4 = 338;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 293:
																	array7[11] = 137;
																	goto case 527;
																case 292:
																	array2[14] = (byte)num10;
																	goto case 577;
																case 290:
																	num10 = 159;
																	goto case 257;
																case 257:
																	array2[13] = (byte)num10;
																	num4 = 364;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 288:
																	num33 = 95;
																	num4 = 275;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 280:
																	object_8 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
																	num = 240;
																	goto case 240;
																case 240:
																	tlLX0O45pekanPs4Vv(object_8, array14, 0, array14.Length);
																	num = 245;
																	goto case 245;
																case 245:
																	HE6aa3MQT40bYe6jbF(object_8);
																	num4 = 166;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 278:
																	array7[4] = (byte)num13;
																	num4 = 78;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 288;
																case 275:
																	array7[4] = (byte)num33;
																	num4 = 89;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 196;
																case 196:
																	num33 = 52;
																	goto case 15;
																case 15:
																	array7[4] = (byte)num33;
																	num4 = 644;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 606;
																case 274:
																	array10[num27 + 2] = array11[2];
																	num4 = 562;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 446;
																case 270:
																	num27 = 23;
																	num4 = 368;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 256:
																	num32 = (uint)((array15[num31 + 3] << 24) | (array15[num31 + 2] << 16) | (array15[num31 + 1] << 8) | array15[num31]);
																	goto case 169;
																case 255:
																	num27 = 16;
																	num4 = 97;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 625;
																case 253:
																	array16[3] = 74;
																	goto case 223;
																case 250:
																	enLfcYQKgZbAne4yyx(new IntPtr(&num3), 0, IntPtr.Zero);
																	goto case 369;
																case 244:
																	array2[19] = 203;
																	goto case 573;
																case 237:
																	array7 = new byte[16];
																	goto case 449;
																case 230:
																	array7[11] = 148;
																	goto case 637;
																case 227:
																	array2[21] = (byte)num10;
																	goto case 470;
																case 221:
																	XomRM8bIN8UPjHCpJl(array4, 0, array4.Length);
																	goto case 464;
																case 220:
																	array2[17] = 96;
																	goto case 18;
																case 18:
																	num10 = 218;
																	num4 = 646;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 207:
																	array2[19] = (byte)num14;
																	num = 244;
																	goto case 244;
																case 204:
																	array2[21] = 172;
																	goto case 97;
																case 203:
																	num14 = 106;
																	goto case 350;
																case 202:
																	array15 = array14;
																	goto case 41;
																case 41:
																	num30 = array15.Length % 4;
																	goto case 414;
																case 198:
																	if (array8.Length > 0)
																	{
																		num4 = 403;
																		if (zsTZIhocVLyHHxkw2B())
																		{
																			continue;
																		}
																		goto IL_0b69_2;
																	}
																	goto case 143;
																case 194:
																	num10 = 87;
																	num4 = 292;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 186:
																	array2[7] = 93;
																	num = 440;
																	goto case 440;
																case 185:
																	array7[13] = (byte)num13;
																	goto case 291;
																case 178:
																	array12 = (byte[])HtYO9goR65ZnZqNeppP(num19);
																	goto case 98;
																case 175:
																	array2[22] = 96;
																	goto case 389;
																case 174:
																	num10 = 151;
																	num4 = 227;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 166:
																	array13 = (byte[])E33hZ75FLJf9RhO2jm(memoryStream);
																	num = 626;
																	goto case 626;
																case 101:
																case 165:
																	if (num28 >= num29)
																	{
																		goto case 543;
																	}
																	goto case 536;
																case 164:
																	array12 = null;
																	num4 = 37;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 162:
																	array10[num27 + 1] = array11[1];
																	goto case 274;
																case 161:
																	array9 = null;
																	goto case 282;
																case 160:
																	if (dVI91YrnPkdJxsxIix() != 4)
																	{
																		goto case 654;
																	}
																	goto case 305;
																case 150:
																	num14 = 81;
																	goto case 43;
																case 43:
																	array2[20] = (byte)num14;
																	num4 = 174;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 149:
																	try
																	{
																		abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)dmG9BboWinYvTUuBkri(new IntPtr(num19), pGvyaUoCs0e61yToSVX(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
																		num20 = 0;
																		if (!zsTZIhocVLyHHxkw2B())
																		{
																			num20 = num21;
																		}
																		switch (num20)
																		{
																		}
																	}
																	catch (object obj2)
																	{
																		num22 = 0;
																		if (!zsTZIhocVLyHHxkw2B())
																		{
																			num22 = num23;
																		}
																		switch (num22)
																		{
																		default:
																			try
																			{
																				Delegate object_7 = (Delegate)dmG9BboWinYvTUuBkri(new IntPtr(num19), pGvyaUoCs0e61yToSVX(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
																				num24 = 0;
																				if (Y9PRou3gANeThLAUl2() != null)
																				{
																					goto IL_416e;
																				}
																				goto IL_4172;
																				IL_4172:
																				while (true)
																				{
																					switch (num24)
																					{
																					case 1:
																						goto end_IL_4172;
																					}
																					abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)Bngn2FoaYTjTpN1TWLn(pGvyaUoCs0e61yToSVX(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle), cgChBZoxLmfaYfCPCnB(object_7));
																					num24 = 1;
																					if (Y9PRou3gANeThLAUl2() == null)
																					{
																						continue;
																					}
																					goto IL_416e;
																					continue;
																					end_IL_4172:
																					break;
																				}
																				goto end_IL_411a;
																				IL_416e:
																				num24 = num25;
																				goto IL_4172;
																				end_IL_411a:;
																			}
																			catch (object obj)
																			{
																				num26 = 0;
																				if (Y9PRou3gANeThLAUl2() != null)
																				{
																					break;
																				}
																				switch (num26)
																				{
																				default:
																					goto end_IL_4183;
																				}
																				end_IL_4183:;
																			}
																			break;
																		case 1:
																			break;
																		}
																	}
																	goto case 224;
																case 144:
																	if (num18 != 4)
																	{
																		goto case 581;
																	}
																	goto case 496;
																case 139:
																	num14 = 150;
																	num4 = 547;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto case 314;
																case 138:
																	num17 <<= 8;
																	num4 = 14;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 308;
																case 131:
																	array7[1] = 156;
																	goto case 541;
																case 128:
																	array5[7] = array8[3];
																	goto case 674;
																case 123:
																	num14 = 91;
																	goto case 572;
																case 122:
																	array2[6] = 209;
																	num = 575;
																	goto case 575;
																case 119:
																	intptr_ = new IntPtr(URnkCOceLK + num15 - num16);
																	num4 = 37;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		continue;
																	}
																	goto case 63;
																case 117:
																	num14 = 67;
																	num4 = 433;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 115:
																	array2[22] = (byte)num10;
																	num = 175;
																	goto case 175;
																case 109:
																	array5 = array7;
																	num4 = 5;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 64;
																case 64:
																	lK6WilpJUsicVTXIVT(array5);
																	goto case 660;
																case 94:
																	text = (string)sHN3epoQMZK4PFcuHtL(bBJEAloYpNk4UyJ8sHr(), array6);
																	num4 = 546;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 88:
																	array2[31] = (byte)num14;
																	num4 = 436;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 86:
																	rNZkehfwNu = new QZEOeHRUkDiNqCWT0p(NvQ34uZt895nxEhi2FIr);
																	goto case 47;
																case 47:
																	intPtr = IntPtr.Zero;
																	num4 = 532;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 81:
																	num14 = 88;
																	goto case 495;
																case 80:
																	Clrlm6amwrPntrY5km();
																	num4 = 645;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 77:
																	num13 = 168;
																	num4 = 481;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 76:
																	QW0CkRo6EUIwsdX7Vo6(JnhiujosIZn7uGuVX80(cgChBZoxLmfaYfCPCnB(rNZkehfwNu)));
																	goto case 161;
																case 75:
																	array6[11] = 108;
																	goto case 483;
																case 74:
																	array2[14] = 137;
																	num4 = 8;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 194;
																case 58:
																	array2[28] = 164;
																	num4 = 484;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 437;
																case 56:
																	num13 = 74;
																	num4 = 278;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_0b69_2;
																case 49:
																	num13 = 225;
																	goto case 185;
																case 45:
																	transform = (ICryptoTransform)DubemGtvZSZMZYmgai(object_6, array4, array5);
																	num4 = 173;
																	if (!zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto case 221;
																case 37:
																	array3 = null;
																	goto case 375;
																case 36:
																	num11 += num12;
																	goto case 256;
																case 26:
																	array2[7] = (byte)num10;
																	goto case 186;
																case 22:
																	num9 = 0;
																	goto case 135;
																case 11:
																	array2[30] = 169;
																	goto case 386;
																case 7:
																	try
																	{
																		while (mA0d81jE1xtIkO2NjW(enumerator))
																		{
																			while (true)
																			{
																				ProcessModule object_2 = (ProcessModule)NIfdmWRmdKAueFHZB9(enumerator);
																				num5 = 1;
																				if (Y9PRou3gANeThLAUl2() == null)
																				{
																					goto IL_4518;
																				}
																				goto IL_453b;
																				IL_453b:
																				switch (num5)
																				{
																				case 11:
																					break;
																				case 8:
																					goto IL_4485;
																				case 10:
																					goto IL_44a2;
																				case 4:
																					goto IL_44b0;
																				case 5:
																					goto IL_44c9;
																				case 3:
																					goto IL_4500;
																				case 2:
																					goto IL_4518;
																				default:
																					goto end_IL_4572;
																				case 9:
																					continue;
																				case 1:
																				case 7:
																					goto IL_458f;
																				case 0:
																				case 6:
																					goto end_IL_4572;
																				}
																				goto IL_4472;
																				IL_4518:
																				if (!LAexqA6X1I2W4ySWwq(kw8X2qsMXNjBZRXLvT(AOFJ78vTLsOCHOIh1G(object_2)), "clrjit.dll"))
																				{
																					goto IL_458f;
																				}
																				num6 = 5;
																				goto IL_44c9;
																				IL_44b0:
																				PRZkZqsNsa = true;
																				num5 = 0;
																				if (!zsTZIhocVLyHHxkw2B())
																				{
																					goto IL_44c3;
																				}
																				goto IL_453b;
																				IL_44c9:
																				object_3 = new Version(j7IMgGOYSE397Ua9ZN(hoGyAW0BBReglqBbda(object_2)), dIXrY3JjVD25LOGIY4(hoGyAW0BBReglqBbda(object_2)), UWglbRdGtRw0qv3B2Q(hoGyAW0BBReglqBbda(object_2)), p5StAqTfUfvhvvhRoK(hoGyAW0BBReglqBbda(object_2)));
																				goto IL_4500;
																				IL_4500:
																				object_4 = new Version(4, 0, 30319, 17020);
																				goto IL_4472;
																				IL_4472:
																				object_5 = new Version(4, 0, 30319, 17921);
																				goto IL_4485;
																				IL_4485:
																				if (z7yjtgPHbZfAZq9vbT(object_3, object_4))
																				{
																					goto IL_44a2;
																				}
																				num5 = 1;
																				if (!zsTZIhocVLyHHxkw2B())
																				{
																					goto IL_44c3;
																				}
																				goto IL_453b;
																				IL_44c3:
																				num5 = num6;
																				goto IL_453b;
																				IL_44a2:
																				if (!f827GqyGVIY5v0FG7e(object_3, object_5))
																				{
																					goto IL_458f;
																				}
																				goto IL_44b0;
																				continue;
																				end_IL_4572:
																				break;
																			}
																			break;
																			IL_458f:;
																		}
																	}
																	finally
																	{
																		IDisposable disposable = enumerator as IDisposable;
																		while (disposable != null)
																		{
																			num7 = 1;
																			if (!zsTZIhocVLyHHxkw2B())
																			{
																				break;
																			}
																			while (true)
																			{
																				switch (num7)
																				{
																				case 1:
																					PoZNpcNTKX7VUasV1N(disposable);
																					num7 = 0;
																					if (Y9PRou3gANeThLAUl2() != null)
																					{
																						num7 = num8;
																					}
																					continue;
																				default:
																					goto end_IL_45ce;
																				case 2:
																					break;
																				case 0:
																					goto end_IL_45ce;
																				}
																				goto IL_45e1;
																				continue;
																				end_IL_45ce:
																				break;
																			}
																			break;
																			IL_45e1:;
																		}
																	}
																	goto case 136;
																case 71:
																	ktV5QQovHKuvUeDP367(abxkLGOVrU);
																	goto case 482;
																case 21:
																	Clrlm6amwrPntrY5km();
																	num = 405;
																	return;
																case 405:
																	return;
																case 450:
																	YeeoMqaS3J(new IntPtr(value), dVI91YrnPkdJxsxIix(), int_, ref int_);
																	goto case 152;
																case 152:
																case 579:
																	Clrlm6amwrPntrY5km();
																	return;
																case 630:
																	Clrlm6amwrPntrY5km();
																	return;
																case 217:
																	return;
																case 642:
																	return;
																case 645:
																	return;
																	IL_19fb_2:
																	if (dVI91YrnPkdJxsxIix() == 4)
																	{
																		goto case 425;
																	}
																	goto case 136;
																}
																break;
															}
															break;
															IL_0b69_2:
															num4 = num;
															goto IL_0070_3;
															IL_13ec:
															num70 = (nint)(ptr + (nint)num68 * (nint)8);
															*(long*)num70 ^= 1983370145L;
															goto IL_1403;
														}
														break;
													}
												}
												goto case 319;
												continue;
												end_IL_13dd:
												break;
											}
											goto case 318;
										case 281:
										case 401:
											num68 = 0;
											goto case 424;
										case 269:
											num70 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + (nint)num68 * (nint)8);
											*(long*)num70 ^= 1983370145L;
											goto case 322;
										case 322:
											num68++;
											goto case 424;
										case 424:
										case 533:
											if (num68 >= num69)
											{
												num4 = 318;
												if (zsTZIhocVLyHHxkw2B())
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 269;
										case 89:
											num32 |= array15[^(1 + num37)];
											goto case 116;
										case 116:
											num37++;
											num4 = 658;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 656:
											num34 = 0;
											goto case 545;
										case 545:
											if (num9 == num36 - 1)
											{
												goto case 273;
											}
											goto case 459;
										case 273:
											if (num30 > 0)
											{
												num4 = 366;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto case 282;
											}
											goto case 459;
										case 282:
											if (dVI91YrnPkdJxsxIix() != 4)
											{
												goto case 156;
											}
											goto case 592;
										case 156:
											array20 = new byte[40];
											dDLV76o00WPVr6s4qQ2(array20, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
											array9 = array20;
											num = 353;
											goto case 145;
										case 592:
											array21 = new byte[30];
											dDLV76o00WPVr6s4qQ2(array21, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
											array9 = array21;
											goto case 145;
										case 145:
										case 353:
											intPtr4 = e0UN5DoO7MCaJQH4UcX(IntPtr.Zero, (uint)array9.Length, 4096u, 64u);
											goto case 373;
										case 373:
											array10 = array9;
											num4 = 641;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 459:
											num31 = (uint)num58;
											num4 = 36;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 14;
										case 14:
											array6[5] = 116;
											goto case 348;
										case 348:
											array6[6] = 46;
											num4 = 196;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 197;
										case 197:
											array6[7] = 100;
											goto case 502;
										case 502:
											array6[8] = 108;
											goto case 376;
										case 376:
											array6[9] = 108;
											num4 = 94;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 32;
										case 32:
											array2[27] = 134;
											num4 = 66;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 53;
										case 655:
											intptr_4 = IntPtr.Zero;
											num = 313;
											goto case 313;
										case 313:
											uint_ = (AwgKvrHJUS3TxryUsj)56;
											goto case 599;
										case 599:
											intptr_4 = BnRbcUmtkdq1KkRY80((uint)uint_, 1, (uint)o7okpEHxNgvXvALBJn(a71Z2JEAAImKLaHKg4()));
											goto case 501;
										case 501:
											if (dVI91YrnPkdJxsxIix() == 4)
											{
												num4 = 89;
												if (!zsTZIhocVLyHHxkw2B())
												{
													continue;
												}
												goto case 102;
											}
											goto case 159;
										case 102:
											intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(x4Dk2IHVmX))[0]);
											num4 = 0;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto default;
										default:
											XtMknffM5M = intPtr2.ToInt32();
											goto case 159;
										case 159:
											intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(x4Dk2IHVmX))[0]);
											goto case 379;
										case 379:
											URnkCOceLK = intPtr2.ToInt64();
											goto case 248;
										case 248:
											intptr_5 = IntPtr.Zero;
											goto case 170;
										case 170:
											num53 = 0;
											num4 = 9;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 654:
											value = AZnZCaoLe5YenS0v99G(intptr_2);
											num4 = 283;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 281;
										case 653:
											array7[2] = 154;
											goto case 262;
										case 262:
											num33 = 116;
											goto case 314;
										case 314:
											array7[2] = (byte)num33;
											num4 = 633;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 652:
											array5[3] = array8[1];
											goto case 565;
										case 565:
											array5[5] = array8[2];
											num4 = 128;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 650:
											array7[1] = 133;
											num4 = 131;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 649:
											abxkLGOVrU = null;
											num4 = 149;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 228:
										case 648:
											if (a8jp0TzOh1jXxVdK1L(CQLXcXZ398Y8S7aiIZ(object_)) < yo7LynetO8iH3reo9x(CQLXcXZ398Y8S7aiIZ(object_)) - 1L)
											{
												goto case 303;
											}
											goto case 69;
										case 303:
											num15 = qVpqG99c2WEReaDdAx(object_);
											num4 = 119;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 69:
											gPDWRhooVu9RmYFMYd9(intptr_4);
											num4 = 21;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 20;
										case 647:
											array10[num35 + 2] = array11[2];
											goto case 516;
										case 516:
											array10[num35 + 3] = array11[3];
											goto case 62;
										case 62:
											array10[num35 + 4] = array11[4];
											goto case 438;
										case 438:
											array10[num35 + 5] = array11[5];
											goto case 118;
										case 118:
											array10[num35 + 6] = array11[6];
											goto case 298;
										case 298:
											array10[num35 + 7] = array11[7];
											num4 = 282;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 272;
										case 272:
										case 367:
											sSUWWuShXng1BRbVoN(array10, 0, intPtr4, array10.Length);
											goto case 326;
										case 326:
											xo4kuDarJK = false;
											num = 61;
											goto case 61;
										case 61:
											YeeoMqaS3J(new IntPtr(value), dVI91YrnPkdJxsxIix(), 64, ref int_);
											goto case 323;
										case 323:
											j9oi6QoJr13qBP7f6Dq(new IntPtr(value), intPtr4);
											num4 = 450;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 267;
										case 646:
											array2[17] = (byte)num10;
											goto case 172;
										case 172:
											num14 = 156;
											goto case 458;
										case 458:
											array2[18] = (byte)num14;
											goto case 231;
										case 231:
											array2[18] = 121;
											num4 = 525;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 644:
											array7[5] = 202;
											goto case 10;
										case 10:
											num33 = 72;
											goto case 48;
										case 48:
											array7[5] = (byte)num33;
											goto case 394;
										case 394:
											array7[5] = 53;
											num4 = 315;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 114:
											if (num56 > 0)
											{
												num4 = 138;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto case 53;
											}
											goto case 535;
										case 535:
											array17[num58 + num56] = (byte)((num55 & num17) >> num34);
											goto case 428;
										case 428:
											num56++;
											goto case 216;
										case 216:
										case 643:
											if (num56 >= num30)
											{
												goto case 4;
											}
											goto case 114;
										case 641:
											array11 = null;
											num4 = 164;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 640:
											array2[12] = 140;
											goto case 226;
										case 226:
											array2[12] = 36;
											goto case 133;
										case 133:
											array2[13] = 115;
											num4 = 611;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 639:
											num33 = 74;
											num = 340;
											goto case 340;
										case 340:
											array7[7] = (byte)num33;
											goto case 435;
										case 435:
											num13 = 209;
											num4 = 451;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 638:
											num18 = qVpqG99c2WEReaDdAx(object_);
											num = 581;
											goto case 581;
										case 581:
											if (num18 == 1)
											{
												num4 = 655;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto IL_0b69;
											}
											num67 = 0;
											goto case 241;
										case 637:
											array7[11] = 73;
											num = 617;
											goto case 617;
										case 617:
											array7[12] = 115;
											num4 = 520;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 635:
											goto IL_1985;
										case 468:
											goto IL_198e;
										case 467:
											goto IL_19b5;
										case 66:
											goto IL_19c9;
										case 87:
											goto IL_19d2;
										case 246:
											goto IL_19e0;
										case 425:
											goto IL_1a03;
										case 628:
											goto IL_1a16;
										case 595:
											goto IL_1a2b;
										case 136:
										case 190:
											goto IL_1a49;
										case 634:
											array10[num35 + 5] = array3[5];
											goto case 287;
										case 287:
											array10[num35 + 6] = array3[6];
											num4 = 569;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 633:
											array7[2] = 147;
											goto case 23;
										case 23:
											num33 = 48;
											goto case 20;
										case 632:
											array2[11] = (byte)num10;
											num = 181;
											goto case 181;
										case 181:
											num14 = 132;
											goto case 511;
										case 511:
											array2[12] = (byte)num14;
											num4 = 398;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 61;
										case 629:
											array2[15] = 104;
											num4 = 2;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 627:
											num14 = 132;
											goto case 352;
										case 352:
											array2[4] = (byte)num14;
											goto case 460;
										case 460:
											num10 = 167;
											goto case 27;
										case 27:
											array2[4] = (byte)num10;
											num4 = 475;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 626:
											XomRM8bIN8UPjHCpJl(array5, 0, array5.Length);
											goto case 110;
										case 110:
											Iyxe5cueaYb6cWyOUP(memoryStream);
											goto case 99;
										case 99:
											Iyxe5cueaYb6cWyOUP(object_8);
											goto case 448;
										case 448:
											cIFsBZwQxdRdEPHV3h(object_);
											num4 = 537;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 286;
										case 286:
											array16 = new byte[6];
											num4 = 320;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 625:
											array10[num27] = array12[0];
											goto case 491;
										case 491:
											array10[num27 + 1] = array12[1];
											num4 = 522;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 624:
											array2[28] = 163;
											num4 = 58;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 33;
										case 33:
											q9iljNK8ASXQhoMHU2(object_6, CipherMode.CBC);
											num4 = 45;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 623:
											array7[0] = (byte)num13;
											goto case 295;
										case 295:
											array7[0] = 5;
											goto case 342;
										case 342:
											array7[1] = 126;
											goto case 650;
										case 622:
											array4[num66] = (byte)(array4[num66] ^ array5[num66]);
											goto case 180;
										case 180:
											num66++;
											goto case 442;
										case 442:
										case 488:
											if (num66 >= array5.Length)
											{
												num4 = 202;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 622;
										case 620:
											array2[1] = 116;
											num4 = 507;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 460;
										case 619:
											array7[3] = (byte)num33;
											goto case 154;
										case 154:
											num33 = 195;
											num4 = 358;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 291;
										case 291:
											array7[14] = 150;
											goto case 218;
										case 218:
											num13 = 99;
											num4 = 46;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 618:
											num73 = intPtr2.ToInt64();
											num4 = 445;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 615:
											if (MT03WghUnhoOR7oMCp(ppEhj6AuCDPDVD168n(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)) <= 0)
											{
												goto case 93;
											}
											goto case 630;
										case 93:
										case 587:
											try
											{
												object obj5 = NoUrm9oXMVTut20JQyC(XKSpaXo2KP35YlNYYog(b0R6MpoVSSFeeVRDeIw(UF9VgZoFvmVN18c4OvL(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), b0R6MpoVSSFeeVRDeIw(UF9VgZoFvmVN18c4OvL(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly)));
												num60 = 1;
												if (Y9PRou3gANeThLAUl2() != null)
												{
													goto IL_1e51_2;
												}
												goto IL_1f12_3;
												IL_1f12_3:
												while (true)
												{
													switch (num60)
													{
													case 17:
														tlLX0O45pekanPs4Vv(object_15, new byte[dVI91YrnPkdJxsxIix()], 0, dVI91YrnPkdJxsxIix());
														goto case 4;
													case 4:
														if (dVI91YrnPkdJxsxIix() == 4)
														{
															goto case 3;
														}
														goto case 2;
													case 3:
														tlLX0O45pekanPs4Vv(object_15, dRL5SfBSlDfHVRbDp6(VE2k4S5okQ.ToInt32()), 0, 4);
														num60 = 9;
														if (Y9PRou3gANeThLAUl2() == null)
														{
															continue;
														}
														break;
													case 2:
														tlLX0O45pekanPs4Vv(object_15, HtYO9goR65ZnZqNeppP(VE2k4S5okQ.ToInt64()), 0, 8);
														goto case 9;
													case 9:
													case 12:
														tlLX0O45pekanPs4Vv(object_15, new byte[dVI91YrnPkdJxsxIix()], 0, dVI91YrnPkdJxsxIix());
														num60 = 5;
														if (Y9PRou3gANeThLAUl2() != null)
														{
															continue;
														}
														goto case 10;
													case 10:
														tlLX0O45pekanPs4Vv(object_15, new byte[dVI91YrnPkdJxsxIix()], 0, dVI91YrnPkdJxsxIix());
														num64 = 5;
														goto case 5;
													case 5:
														Ljb91xfZyaVHDXcTvW(object_15, 0L);
														num60 = 11;
														if (Y9PRou3gANeThLAUl2() == null)
														{
															continue;
														}
														break;
													case 14:
														VE2k4S5okQ = (IntPtr)obj5;
														goto case 8;
													case 8:
														if (LAexqA6X1I2W4ySWwq(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
														{
															goto case 13;
														}
														goto default;
													case 13:
														VE2k4S5okQ = (IntPtr)NoUrm9oXMVTut20JQyC(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
														num60 = 0;
														if (!zsTZIhocVLyHHxkw2B())
														{
															continue;
														}
														goto default;
													default:
														object_15 = new MemoryStream();
														num60 = 17;
														if (zsTZIhocVLyHHxkw2B())
														{
															continue;
														}
														break;
													case 11:
														array18 = (byte[])E33hZ75FLJf9RhO2jm(object_15);
														num60 = 6;
														if (Y9PRou3gANeThLAUl2() != null)
														{
															continue;
														}
														goto case 6;
													case 6:
														Iyxe5cueaYb6cWyOUP(object_15);
														num60 = 15;
														if (Y9PRou3gANeThLAUl2() == null)
														{
															continue;
														}
														break;
													case 1:
														if (obj5 is IntPtr)
														{
															num60 = 14;
															if (Y9PRou3gANeThLAUl2() == null)
															{
																continue;
															}
															break;
														}
														goto case 8;
													case 15:
														nativeSizeOfCode = 0u;
														goto case 16;
													case 16:
														try
														{
															array19 = (array = array18);
															if (array19 != null)
															{
																while (array.Length != 0)
																{
																	num61 = 1;
																	if (Y9PRou3gANeThLAUl2() != null)
																	{
																		num61 = num62;
																	}
																	switch (num61)
																	{
																	case 1:
																	case 5:
																		while (true)
																		{
																			IL_1f84_2:
																			fixed (byte* value2 = &array[0])
																			{
																				num61 = 0;
																				if (Y9PRou3gANeThLAUl2() != null)
																				{
																					while (true)
																					{
																						switch (num61)
																						{
																						case 6:
																							goto end_IL_1f9a_2;
																						case 1:
																						case 5:
																							goto IL_1f84_2;
																						case 4:
																							if (array.Length != 0)
																							{
																								num61 = 1;
																								if (Y9PRou3gANeThLAUl2() != null)
																								{
																									num61 = num62;
																								}
																								continue;
																							}
																							goto end_IL_1f9a_2;
																						case 3:
																							goto end_IL_1f84_2;
																						}
																						goto IL_1fcc_3;
																						continue;
																						end_IL_1f9a_2:
																						break;
																					}
																					goto end_IL_1fbd_2;
																				}
																				goto IL_1fcc_3;
																				IL_1fcc_3:
																				rNZkehfwNu(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
																				break;
																			}
																			continue;
																			end_IL_1f84_2:
																			break;
																		}
																		goto end_IL_1f68_2;
																	case 4:
																		break;
																	case 6:
																		goto end_IL_1fbd_2;
																	default:
																		goto IL_1fcc_4;
																	case 3:
																		goto end_IL_1f68_2;
																	}
																	continue;
																	end_IL_1fbd_2:
																	break;
																}
															}
															reference = ref *(byte*)null;
															goto IL_1fcc_4;
															IL_1fcc_4:
															rNZkehfwNu(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)), ref nativeSizeOfCode);
															end_IL_1f68_2:;
														}
														finally
														{
															reference = ref *(byte*)null;
															num63 = 0;
															if (zsTZIhocVLyHHxkw2B())
															{
																switch (num63)
																{
																}
															}
														}
														goto end_IL_1f12_2;
													case 7:
														goto end_IL_1f12_2;
													}
													goto IL_1e51_2;
													continue;
													end_IL_1f12_2:
													break;
												}
												goto end_IL_1d20_2;
												IL_1e51_2:
												num60 = num64;
												goto IL_1f12_3;
												end_IL_1d20_2:;
											}
											catch (object obj6)
											{
												num65 = 0;
												if (!zsTZIhocVLyHHxkw2B())
												{
													switch (num65)
													{
													}
												}
											}
											goto case 71;
										case 482:
											QW0CkRo6EUIwsdX7Vo6(JnhiujosIZn7uGuVX80(cgChBZoxLmfaYfCPCnB(abxkLGOVrU)));
											num = 309;
											goto case 309;
										case 309:
											ktV5QQovHKuvUeDP367(rNZkehfwNu);
											num4 = 76;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 614:
											array2[26] = 118;
											num4 = 43;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 556;
										case 556:
											array2[26] = 190;
											goto case 327;
										case 327:
											num10 = 247;
											num4 = 35;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 613:
											array6[0] = 109;
											goto case 107;
										case 107:
											array6[1] = 115;
											goto case 151;
										case 151:
											array6[2] = 99;
											num4 = 586;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 79;
										case 612:
											array7[9] = 149;
											goto case 147;
										case 147:
											num33 = 128;
											num4 = 134;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 611:
											array2[13] = 108;
											num4 = 278;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 371;
										case 371:
											array2[13] = 159;
											num4 = 290;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 609:
											intPtr3 = new IntPtr(URnkCOceLK + qVpqG99c2WEReaDdAx(object_) - num16);
											goto case 601;
										case 601:
											YeeoMqaS3J(intPtr3, 4, 4, ref int_2);
											goto case 666;
										case 608:
											array2[21] = (byte)num14;
											num4 = 204;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 28;
										case 28:
											array16[5] = 116;
											goto case 420;
										case 420:
											string_ = (string)sHN3epoQMZK4PFcuHtL(bBJEAloYpNk4UyJ8sHr(), array16);
											goto case 137;
										case 137:
											procAddress = GetProcAddress(intptr_3, string_);
											num4 = 49;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 55;
										case 55:
											object_14 = (OFfwWh6ZIHjfnqBOWx)dmG9BboWinYvTUuBkri(procAddress, pGvyaUoCs0e61yToSVX(typeof(OFfwWh6ZIHjfnqBOWx).TypeHandle));
											num4 = 554;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 607:
											array2[30] = (byte)num14;
											num = 112;
											goto case 112;
										case 112:
											array2[30] = 121;
											num = 410;
											goto case 410;
										case 410:
											array2[30] = 211;
											num4 = 11;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 10;
										case 606:
											array7[7] = 46;
											goto case 141;
										case 141:
											array7[7] = 66;
											goto case 561;
										case 561:
											array7[7] = 105;
											goto case 229;
										case 229:
											array7[7] = 119;
											num4 = 158;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 639;
										case 605:
											num14 = 91;
											goto case 210;
										case 210:
											array2[15] = (byte)num14;
											num4 = 444;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 602:
											array7[14] = 142;
											goto case 384;
										case 384:
											num13 = 84;
											goto case 321;
										case 321:
											array7[14] = (byte)num13;
											num = 215;
											goto case 215;
										case 215:
											array7[14] = 152;
											goto case 211;
										case 211:
											array7[14] = 48;
											num4 = 77;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 600:
											num10 = 143;
											goto case 225;
										case 225:
											array2[2] = (byte)num10;
											goto case 393;
										case 393:
											array2[2] = 203;
											num4 = 375;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 551;
										case 551:
											array2[3] = 110;
											num4 = 19;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 251;
										case 251:
											array2[3] = 126;
											num4 = 139;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 597:
											num16 = 7680;
											goto case 432;
										case 432:
										case 466:
											num54 = qVpqG99c2WEReaDdAx(object_);
											goto case 443;
										case 443:
											num18 = qVpqG99c2WEReaDdAx(object_);
											num4 = 144;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 135;
										case 593:
											array7[6] = (byte)num33;
											goto case 583;
										case 583:
											array7[7] = 87;
											num4 = 606;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 368;
										case 368:
											array10[num27] = array11[0];
											num4 = 162;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 48;
										case 591:
											if (dVI91YrnPkdJxsxIix() == 4)
											{
												goto case 404;
											}
											goto case 121;
										case 404:
											num19 = tw5WoxoSTRX6DVyYiHj(new IntPtr(value));
											num4 = 490;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 129;
										case 129:
											object_ = new VtNVUKGulysZw81C3E(new MemoryStream(array13));
											num4 = 380;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 418;
										case 418:
											Ljb91xfZyaVHDXcTvW(CQLXcXZ398Y8S7aiIZ(object_), 0L);
											goto case 487;
										case 487:
											intPtr2 = qiw0OggH91oSliUlt9(((object[])S62xQE7PDgvJGO3l0r(x4Dk2IHVmX))[0]);
											num4 = 300;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 618;
										case 121:
											num19 = AZnZCaoLe5YenS0v99G(new IntPtr(value));
											goto case 100;
										case 100:
										case 490:
											object_9 = (Process)a71Z2JEAAImKLaHKg4();
											num4 = 509;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 590:
											array17 = new byte[array15.Length];
											num = 302;
											goto case 302;
										case 302:
											num59 = array4.Length / 4;
											goto case 377;
										case 377:
											num11 = 0u;
											goto case 380;
										case 380:
											num12 = 0u;
											goto case 271;
										case 271:
											num32 = 0u;
											goto case 422;
										case 422:
											if (num30 > 0)
											{
												goto case 555;
											}
											goto case 78;
										case 555:
											num36++;
											goto case 78;
										case 78:
											num31 = 0u;
											num4 = 22;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 589:
											array7[6] = (byte)num13;
											num4 = 279;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 427;
										case 427:
											num33 = 110;
											goto case 362;
										case 362:
											array7[6] = (byte)num33;
											goto case 471;
										case 471:
											num33 = 146;
											num4 = 593;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 588:
											num14 = 34;
											num4 = 88;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 586:
											array6[3] = 111;
											num = 461;
											goto case 461;
										case 461:
											array6[4] = 114;
											num = 140;
											goto case 140;
										case 140:
											array6[5] = 106;
											num4 = 574;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 585:
											if (ppEhj6AuCDPDVD168n(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly) == null)
											{
												num4 = 587;
												if (Y9PRou3gANeThLAUl2() == null)
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 615;
										case 224:
										case 584:
											int_ = 0;
											num4 = 99;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 200;
										case 200:
											if (!PwZxQBoGJcRYPUUSxpn(LvTgFno13q17LPWObCi(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
											{
												goto case 93;
											}
											num = 538;
											goto case 538;
										case 538:
											if (((Array)pr3tUVorR8p3TGjMUyr(LvTgFno13q17LPWObCi(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly))).Length != 2)
											{
												goto case 93;
											}
											goto case 585;
										case 578:
											array2[31] = (byte)num10;
											goto case 568;
										case 568:
											num10 = 113;
											goto case 201;
										case 201:
											array2[31] = (byte)num10;
											goto case 514;
										case 514:
											num10 = 102;
											num4 = 510;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 577:
											array2[14] = 64;
											goto case 447;
										case 447:
											num10 = 90;
											num4 = 297;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 576:
											num14 = 198;
											num4 = 334;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 575:
											num10 = 205;
											num4 = 26;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 574:
											array6[6] = 105;
											num4 = 357;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 134;
										case 134:
											array7[9] = (byte)num33;
											goto case 675;
										case 573:
											array2[20] = 123;
											goto case 558;
										case 558:
											num10 = 94;
											goto case 544;
										case 544:
											array2[20] = (byte)num10;
											goto case 310;
										case 310:
											num10 = 111;
											goto case 472;
										case 472:
											array2[20] = (byte)num10;
											num4 = 150;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 572:
											array2[28] = (byte)num14;
											num4 = 123;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 624;
										case 571:
											num14 = 221;
											num = 517;
											goto case 517;
										case 517:
											array2[5] = (byte)num14;
											goto case 72;
										case 72:
											array2[5] = 130;
											goto case 469;
										case 469:
											num14 = 122;
											goto case 236;
										case 236:
											array2[5] = (byte)num14;
											num4 = 117;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 569:
											array10[num35 + 7] = array3[7];
											goto case 106;
										case 106:
											num35 = 18;
											num4 = 664;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 436;
										case 436:
											array4 = array2;
											num4 = 237;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 567:
											if (num9 == num36 - 1)
											{
												goto case 351;
											}
											goto case 542;
										case 351:
											if (num30 > 0)
											{
												goto case 82;
											}
											goto case 542;
										case 82:
											num55 = num11 ^ num32;
											goto case 177;
										case 177:
											num56 = 0;
											num4 = 643;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 14;
										case 542:
											num57 = num11 ^ num32;
											goto case 356;
										case 356:
											array17[num58] = (byte)(num57 & 0xFFu);
											num4 = 190;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 259;
										case 259:
											array17[num58 + 1] = (byte)((num57 & 0xFF00) >> 8);
											num = 195;
											goto case 195;
										case 195:
											array17[num58 + 2] = (byte)((num57 & 0xFF0000) >> 16);
											goto case 111;
										case 111:
											array17[num58 + 3] = (byte)((num57 & 0xFF000000u) >> 24);
											goto case 4;
										case 566:
											array2[16] = 74;
											goto case 548;
										case 548:
											array2[17] = 136;
											num4 = 220;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 564:
											array2[23] = 144;
											goto case 486;
										case 486:
											array2[23] = 92;
											goto case 83;
										case 83:
											array2[24] = 86;
											goto case 663;
										case 563:
											array16[1] = 101;
											num4 = 220;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 279;
										case 279:
											array16[2] = 116;
											num4 = 253;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 562:
											array10[num27 + 3] = array11[3];
											goto case 272;
										case 560:
											num14 = 92;
											num = 559;
											goto case 559;
										case 559:
											array2[2] = (byte)num14;
											num4 = 600;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 557:
											num33 = 249;
											goto case 155;
										case 155:
											array7[8] = (byte)num33;
											goto case 612;
										case 554:
											intptr_2 = xupvcpocKUiHHa9GIJc(object_14);
											goto case 130;
										case 130:
											value = 0L;
											num4 = 160;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 553:
											num33 = 129;
											goto case 363;
										case 363:
											array7[11] = (byte)num33;
											num4 = 397;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 552:
											goto IL_29cb;
										case 3:
											goto IL_29d3;
										case 232:
											goto IL_29e2;
										case 550:
											array10[num35 + 3] = array3[3];
											goto case 456;
										case 456:
											array10[num35 + 4] = array3[4];
											num4 = 634;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 547:
											array2[3] = (byte)num14;
											goto case 344;
										case 344:
											array2[3] = 34;
											num4 = 588;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 627;
										case 546:
											intptr_3 = LoadLibrary(text);
											goto case 286;
										case 543:
											YeeoMqaS3J(intptr_, num29 * 4, int_2, ref int_2);
											goto case 228;
										case 541:
											array7[1] = 169;
											goto case 411;
										case 411:
											array7[2] = 104;
											goto case 506;
										case 506:
											num13 = 113;
											goto case 70;
										case 70:
											array7[2] = (byte)num13;
											goto case 653;
										case 540:
											num14 = 149;
											goto case 519;
										case 519:
											array2[16] = (byte)num14;
											num4 = 566;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 539:
											num14 = 134;
											goto case 478;
										case 478:
											array2[23] = (byte)num14;
											goto case 564;
										case 537:
											num54 = qVpqG99c2WEReaDdAx(object_);
											goto case 638;
										case 536:
											AG4AEFonT6onCnjkPYZ(new IntPtr(intptr_.ToInt64() + num28 * 4), qVpqG99c2WEReaDdAx(object_));
											goto case 673;
										case 532:
											intPtr = WhYKoEoEVDj0BRONceg(rNZkehfwNu);
											goto case 415;
										case 415:
											num19 = 0L;
											goto case 591;
										case 531:
											array7[3] = (byte)num13;
											num4 = 56;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 530:
											array10[num27 + 3] = array12[3];
											num4 = 270;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 528:
											num14 = 228;
											goto case 608;
										case 527:
											num13 = 85;
											goto case 235;
										case 235:
											array7[11] = (byte)num13;
											num4 = 230;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 223;
										case 223:
											array16[4] = 105;
											goto case 28;
										case 526:
											array2[4] = (byte)num14;
											num4 = 571;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 525:
											num10 = 117;
											goto case 54;
										case 54:
											array2[18] = (byte)num10;
											goto case 34;
										case 34:
											num10 = 181;
											goto case 349;
										case 349:
											array2[18] = (byte)num10;
											num = 576;
											goto case 576;
										case 524:
											array2[10] = 107;
											goto case 92;
										case 92:
											array2[10] = 139;
											num = 261;
											goto case 261;
										case 261:
											num10 = 11;
											goto case 346;
										case 346:
											array2[10] = (byte)num10;
											num4 = 388;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 522:
											array10[num27 + 2] = array12[2];
											num4 = 530;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 521:
											num53++;
											goto case 9;
										case 9:
										case 12:
											if (num53 >= num54)
											{
												goto case 228;
											}
											goto case 609;
										case 520:
											num33 = 180;
											num = 396;
											goto case 396;
										case 396:
											array7[12] = (byte)num33;
											num4 = 36;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 446;
										case 446:
											array7[12] = 54;
											num4 = 300;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 97;
										case 97:
											array2[22] = 160;
											num = 222;
											goto case 222;
										case 222:
											num10 = 141;
											num4 = 115;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 46;
										case 46:
											array7[14] = (byte)num13;
											goto case 602;
										case 513:
											array6[4] = 105;
											goto case 14;
										case 510:
											array2[31] = (byte)num10;
											goto case 124;
										case 124:
											num10 = 140;
											goto case 209;
										case 209:
											array2[31] = (byte)num10;
											goto case 588;
										case 509:
											try
											{
												ProcessModuleCollection object_10 = (ProcessModuleCollection)PXMX0n2kQjCBnmMug4(object_9);
												num38 = 2;
												if (!zsTZIhocVLyHHxkw2B())
												{
													num38 = num39;
												}
												while (true)
												{
													switch (num38)
													{
													case 2:
														goto IL_2d71_2;
													case 1:
														goto end_IL_2d86_2;
													}
													goto IL_2d9a_2;
													IL_2d71_2:
													enumerator = (IEnumerator)M38yQbXx7NDg3VeUb0(object_10);
													num38 = 0;
													if (!zsTZIhocVLyHHxkw2B())
													{
														continue;
													}
													goto IL_2d9a_2;
													IL_2d9a_2:
													try
													{
														while (mA0d81jE1xtIkO2NjW(enumerator))
														{
															while (true)
															{
																ProcessModule object_11 = (ProcessModule)NIfdmWRmdKAueFHZB9(enumerator);
																num40 = 4;
																if (Y9PRou3gANeThLAUl2() != null)
																{
																	goto IL_2e0e_2;
																}
																goto IL_2e36_3;
																IL_2e36_3:
																while (true)
																{
																	switch (num40)
																	{
																	case 7:
																		num41 = num19;
																		intPtr2 = Gm1JSA1pv5vDMUij1U(object_11);
																		if (num41 >= intPtr2.ToInt64())
																		{
																			goto case 2;
																		}
																		goto default;
																	case 2:
																		num42 = num19;
																		intPtr2 = Gm1JSA1pv5vDMUij1U(object_11);
																		if (num42 <= intPtr2.ToInt64() + exd8eVoIf4YbeAwGfl2(object_11))
																		{
																			goto end_IL_2e6c_2;
																		}
																		num40 = 0;
																		if (Y9PRou3gANeThLAUl2() == null)
																		{
																			continue;
																		}
																		goto default;
																	default:
																		if (!PwZxQBoGJcRYPUUSxpn(LvTgFno13q17LPWObCi(pGvyaUoCs0e61yToSVX(typeof(WP6RZJql8gZrNhVA9v).TypeHandle).Assembly), null))
																		{
																			goto IL_2e01_2;
																		}
																		goto case 6;
																	case 4:
																		if (LAexqA6X1I2W4ySWwq(AOFJ78vTLsOCHOIh1G(object_11), text))
																		{
																			goto case 7;
																		}
																		goto IL_2e27_2;
																	case 8:
																		break;
																	case 1:
																	case 3:
																	case 5:
																		goto end_IL_2e6c_2;
																	case 6:
																		Clrlm6amwrPntrY5km();
																		return;
																	case 9:
																		return;
																	case 10:
																		goto end_IL_2e89_2;
																	}
																	break;
																	IL_2e27_2:
																	num40 = 5;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	goto IL_2e0e_2;
																	IL_2e01_2:
																	num40 = 1;
																	if (zsTZIhocVLyHHxkw2B())
																	{
																		continue;
																	}
																	goto IL_2e0e_2;
																}
																continue;
																IL_2e0e_2:
																num40 = num43;
																goto IL_2e36_3;
																continue;
																end_IL_2e6c_2:
																break;
															}
															continue;
															end_IL_2e89_2:
															break;
														}
													}
													finally
													{
														IDisposable disposable = enumerator as IDisposable;
														num44 = 1;
														if (!zsTZIhocVLyHHxkw2B())
														{
															goto IL_2ecc_2;
														}
														goto IL_2ee5_3;
														IL_2ee5_3:
														while (true)
														{
															switch (num44)
															{
															case 2:
																PoZNpcNTKX7VUasV1N(disposable);
																num44 = 3;
																if (Y9PRou3gANeThLAUl2() == null)
																{
																	continue;
																}
																break;
															case 1:
																if (disposable == null)
																{
																	num44 = 0;
																	if (Y9PRou3gANeThLAUl2() == null)
																	{
																		continue;
																	}
																	break;
																}
																goto case 2;
															default:
																goto end_IL_2ee5_2;
															}
															goto IL_2ecc_2;
															continue;
															end_IL_2ee5_2:
															break;
														}
														goto end_IL_2ea0_2;
														IL_2ecc_2:
														num44 = num45;
														goto IL_2ee5_3;
														end_IL_2ea0_2:;
													}
													break;
													continue;
													end_IL_2d86_2:
													break;
												}
											}
											catch (object obj3)
											{
												num46 = 0;
												if (Y9PRou3gANeThLAUl2() != null)
												{
													num46 = num47;
												}
												switch (num46)
												{
												}
											}
											goto case 335;
										case 335:
											try
											{
												ProcessModuleCollection object_12 = (ProcessModuleCollection)PXMX0n2kQjCBnmMug4(object_9);
												num48 = 0;
												if (Y9PRou3gANeThLAUl2() != null)
												{
													switch (num48)
													{
													case 2:
														goto IL_2f4c_2;
													case 1:
														goto end_IL_2f1a_2;
													}
												}
												enumerator = (IEnumerator)M38yQbXx7NDg3VeUb0(object_12);
												goto IL_2f4c_2;
												IL_2f4c_2:
												try
												{
													while (true)
													{
														IL_2fcf_2:
														if (!mA0d81jE1xtIkO2NjW(enumerator))
														{
															num49 = 5;
															if (zsTZIhocVLyHHxkw2B())
															{
																break;
															}
															goto IL_2f73_3;
														}
														goto IL_2fb1_2;
														IL_2f73_3:
														while (true)
														{
															switch (num49)
															{
															case 2:
																break;
															case 4:
																goto end_IL_2f73_2;
															case 5:
																goto IL_2fa6_2;
															default:
																goto IL_2fb1_2;
															case 1:
																goto IL_2fcf_2;
															case 3:
															case 6:
																goto end_IL_2fcf_2;
															}
															num16 = 0;
															num49 = 3;
															if (Y9PRou3gANeThLAUl2() == null)
															{
																continue;
															}
															goto IL_2f6f_2;
															continue;
															end_IL_2f73_2:
															break;
														}
														goto IL_2f96_2;
														IL_2fb1_2:
														object_13 = (ProcessModule)NIfdmWRmdKAueFHZB9(enumerator);
														goto IL_2fa6_2;
														IL_2fa6_2:
														intPtr2 = Gm1JSA1pv5vDMUij1U(object_13);
														goto IL_2f96_2;
														IL_2f96_2:
														if (intPtr2.ToInt64() != eXJkjmTXDX)
														{
															continue;
														}
														num49 = 2;
														if (Y9PRou3gANeThLAUl2() != null)
														{
															goto IL_2f6f_2;
														}
														goto IL_2f73_3;
														IL_2f6f_2:
														num49 = num50;
														goto IL_2f73_3;
														continue;
														end_IL_2fcf_2:
														break;
													}
												}
												finally
												{
													IDisposable disposable = enumerator as IDisposable;
													while (disposable != null)
													{
														while (true)
														{
															PoZNpcNTKX7VUasV1N(disposable);
															num51 = 0;
															if (Y9PRou3gANeThLAUl2() == null)
															{
																switch (num51)
																{
																case 1:
																	continue;
																default:
																	goto end_IL_2fe8_2;
																case 3:
																	break;
																case 0:
																case 2:
																	goto end_IL_2fe8_2;
																}
																goto IL_3012_2;
															}
															break;
															continue;
															end_IL_2fe8_2:
															break;
														}
														break;
														IL_3012_2:;
													}
												}
												end_IL_2f1a_2:;
											}
											catch (object obj4)
											{
												num52 = 0;
												if (zsTZIhocVLyHHxkw2B())
												{
													switch (num52)
													{
													}
												}
											}
											goto case 649;
										case 507:
											array2[1] = 124;
											goto case 668;
										case 504:
											num33 = 117;
											goto case 619;
										case 503:
											array2[9] = 107;
											num = 662;
											goto case 662;
										case 500:
											num10 = 23;
											num4 = 341;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 499:
											array2[6] = (byte)num10;
											num4 = 463;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 498:
											array2[19] = 129;
											goto case 192;
										case 192:
											num14 = 99;
											num4 = 207;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 496:
											object_6 = (SymmetricAlgorithm)VGrrEoDggRjTHsda21();
											num4 = 33;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 495:
											array2[25] = (byte)num14;
											goto case 5;
										case 5:
											array2[25] = 27;
											num4 = 16;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 42;
										case 42:
											num10 = 160;
											num = 390;
											goto case 390;
										case 390:
											array2[25] = (byte)num10;
											num = 188;
											goto case 188;
										case 188:
											num10 = 143;
											goto case 176;
										case 176:
											array2[25] = (byte)num10;
											goto case 239;
										case 239:
											array2[25] = 175;
											goto case 213;
										case 213:
											num10 = 88;
											goto case 146;
										case 146:
											array2[26] = (byte)num10;
											num4 = 462;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 494:
											array11 = (byte[])dRL5SfBSlDfHVRbDp6(intPtr.ToInt32());
											num4 = 331;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 493:
											array10[num27 + 1] = array3[1];
											num4 = 122;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 311;
										case 311:
											array10[num27 + 2] = array3[2];
											goto case 67;
										case 67:
											array10[num27 + 3] = array3[3];
											num4 = 255;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 492:
											array2[27] = 152;
											goto case 104;
										case 104:
											array2[27] = 70;
											goto case 485;
										case 485:
											num10 = 134;
											goto case 179;
										case 179:
											array2[28] = (byte)num10;
											num4 = 123;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 99;
										case 489:
											array2[10] = 159;
											num4 = 524;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 484:
											num14 = 149;
											num4 = 55;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 671;
										case 483:
											text = (string)sHN3epoQMZK4PFcuHtL(bBJEAloYpNk4UyJ8sHr(), array6);
											goto case 434;
										case 434:
											intptr_3 = LoadLibrary(text);
											num4 = 476;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 331;
										case 331:
											array12 = (byte[])dRL5SfBSlDfHVRbDp6(rhCWlWokCRiOQGFE8fB(num19));
											num4 = 75;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 98;
										case 98:
										case 233:
											if (dVI91YrnPkdJxsxIix() == 4)
											{
												num4 = 4;
												if (Y9PRou3gANeThLAUl2() != null)
												{
													continue;
												}
												goto case 374;
											}
											goto case 65;
										case 374:
											num27 = 9;
											goto case 304;
										case 304:
											array10[num27] = array3[0];
											num4 = 493;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 65:
											num35 = 2;
											goto case 441;
										case 441:
											array10[num35] = array3[0];
											goto case 395;
										case 395:
											array10[num35 + 1] = array3[1];
											num4 = 184;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 69;
										case 481:
											array7[15] = (byte)num13;
											goto case 392;
										case 392:
											array7[15] = 99;
											num = 378;
											goto case 378;
										case 378:
											array7[15] = 101;
											num4 = 109;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 2;
										case 2:
											array2[15] = 147;
											goto case 605;
										case 479:
											array6[0] = 99;
											num4 = 248;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 249;
										case 249:
											array6[1] = 108;
											goto case 430;
										case 430:
											array6[2] = 114;
											num = 416;
											goto case 416;
										case 416:
											array6[3] = 106;
											num4 = 513;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 477:
											array2[7] = 112;
											goto case 44;
										case 44:
											array2[7] = 92;
											goto case 264;
										case 264:
											array2[8] = 155;
											num4 = 473;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 476:
											if (!aiB4GaolTgcn8wKBVnj(intptr_3, IntPtr.Zero))
											{
												goto case 286;
											}
											num4 = 360;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 195;
										case 475:
											num14 = 58;
											num4 = 387;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 474:
											num33 = 167;
											goto case 285;
										case 285:
											array7[8] = (byte)num33;
											num4 = 557;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 557;
										case 473:
											array2[8] = 92;
											goto case 500;
										case 470:
											num10 = 94;
											goto case 672;
										case 464:
											memoryStream = new MemoryStream();
											num4 = 280;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 463:
											array2[6] = 102;
											num4 = 122;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 462:
											array2[26] = 99;
											goto case 614;
										case 455:
											array7[8] = 199;
											goto case 474;
										case 454:
											num10 = 134;
											goto case 345;
										case 345:
											array2[0] = (byte)num10;
											goto case 212;
										case 212:
											array2[0] = 103;
											num4 = 391;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 35;
										case 35:
											array2[26] = (byte)num10;
											num4 = 417;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 183;
										case 453:
											array7[0] = (byte)num33;
											goto case 31;
										case 31:
											num13 = 170;
											goto case 182;
										case 182:
											array7[0] = (byte)num13;
											num4 = 439;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 452:
											array2[13] = (byte)num14;
											goto case 214;
										case 214:
											num10 = 220;
											goto case 193;
										case 193:
											array2[13] = (byte)num10;
											num4 = 74;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 451:
											array7[8] = (byte)num13;
											goto case 455;
										case 449:
											num13 = 150;
											num = 29;
											goto case 29;
										case 29:
											array7[0] = (byte)num13;
											num4 = 120;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 445:
											int_2 = 0;
											goto case 68;
										case 68:
											num16 = 0;
											goto case 84;
										case 84:
											if (ppEhj6AuCDPDVD168n(x4Dk2IHVmX) == null)
											{
												goto case 597;
											}
											goto case 132;
										case 132:
											if (MT03WghUnhoOR7oMCp(ppEhj6AuCDPDVD168n(x4Dk2IHVmX)) == 0)
											{
												goto case 597;
											}
											goto case 432;
										case 444:
											array2[16] = 135;
											num4 = 354;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 440:
											num14 = 119;
											goto case 199;
										case 199:
											array2[7] = (byte)num14;
											goto case 382;
										case 382:
											num14 = 123;
											goto case 266;
										case 266:
											array2[7] = (byte)num14;
											goto case 477;
										case 439:
											num33 = 120;
											goto case 385;
										case 385:
											array7[0] = (byte)num33;
											goto case 336;
										case 336:
											num13 = 168;
											goto case 623;
										case 437:
											array6[8] = 46;
											goto case 355;
										case 355:
											array6[9] = 100;
											goto case 157;
										case 157:
											array6[10] = 108;
											num4 = 75;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 433:
											array2[5] = (byte)num14;
											goto case 659;
										case 431:
											num37 = 0;
											num4 = 179;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 234;
										case 429:
											num14 = 199;
											num4 = 116;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 526;
										case 426:
											array7[13] = 123;
											goto case 372;
										case 372:
											array7[13] = 37;
											num = 205;
											goto case 205;
										case 205:
											array7[13] = 52;
											goto case 276;
										case 276:
											array7[13] = 146;
											num4 = 49;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 417:
											array2[27] = 154;
											goto case 32;
										case 414:
											num36 = array15.Length / 4;
											num4 = 150;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 590;
										case 413:
											array7[12] = 56;
											num4 = 69;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 85;
										case 85:
											num13 = 134;
											goto case 307;
										case 307:
											array7[13] = (byte)num13;
											goto case 426;
										case 412:
											array3 = (byte[])dRL5SfBSlDfHVRbDp6(VE2k4S5okQ.ToInt32());
											num4 = 241;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 494;
										case 409:
											num32 = 0u;
											goto case 431;
										case 408:
											Ljb91xfZyaVHDXcTvW(CQLXcXZ398Y8S7aiIZ(object_), 0L);
											goto case 263;
										case 263:
											array14 = (byte[])a4X4WBibbNOPOEpG16(object_, (int)yo7LynetO8iH3reo9x(CQLXcXZ398Y8S7aiIZ(object_)));
											goto case 38;
										case 38:
											array2 = new byte[32];
											goto case 454;
										case 407:
											num10 = 160;
											goto case 51;
										case 51:
											array2[29] = (byte)num10;
											goto case 294;
										case 294:
											array2[29] = 144;
											num4 = 199;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 277;
										case 277:
											num14 = 106;
											goto case 607;
										case 403:
											array5[1] = array8[0];
											num4 = 652;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 562;
										case 400:
											array11 = (byte[])HtYO9goR65ZnZqNeppP(intPtr.ToInt64());
											num4 = 178;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 398:
											array2[12] = 169;
											goto case 640;
										case 397:
											array7[11] = 114;
											num4 = 293;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 5;
										case 391:
											array2[0] = 158;
											goto case 343;
										case 343:
											array2[0] = 175;
											goto case 620;
										case 389:
											num10 = 190;
											goto case 665;
										case 387:
											array2[4] = (byte)num14;
											goto case 429;
										case 386:
											array2[30] = 130;
											goto case 289;
										case 289:
											array2[30] = 184;
											num4 = 191;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 383:
											num10 = 171;
											num4 = 632;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 375:
											if (dVI91YrnPkdJxsxIix() == 4)
											{
												goto case 412;
											}
											goto case 301;
										case 301:
											array3 = (byte[])HtYO9goR65ZnZqNeppP(VE2k4S5okQ.ToInt64());
											num4 = 400;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 370:
											array2[2] = 131;
											goto case 105;
										case 105:
											array2[2] = 203;
											num4 = 532;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 560;
										case 369:
											goto IL_39f2;
										case 13:
											goto IL_3a01;
										case 366:
											num11 += num12;
											num4 = 409;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 120;
										case 120:
											num33 = 105;
											num = 453;
											goto case 453;
										case 364:
											num14 = 92;
											num4 = 452;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 360:
											array6 = new byte[10];
											num = 479;
											goto case 479;
										case 359:
											XomRM8bIN8UPjHCpJl(array8, 0, array8.Length);
											goto case 143;
										case 358:
											array7[3] = (byte)num33;
											goto case 127;
										case 127:
											array7[3] = 123;
											goto case 167;
										case 167:
											num13 = 152;
											num4 = 531;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 51;
										case 357:
											array6[7] = 116;
											goto case 437;
										case 354:
											array2[16] = 54;
											goto case 540;
										case 350:
											array2[6] = (byte)num14;
											goto case 265;
										case 265:
											num10 = 150;
											goto case 499;
										case 341:
											array2[8] = (byte)num10;
											goto case 39;
										case 39:
											array2[9] = 170;
											goto case 503;
										case 338:
											array2[15] = 143;
											num4 = 629;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 334:
											array2[18] = (byte)num14;
											goto case 238;
										case 238:
											array2[19] = 108;
											num4 = 498;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 63;
										case 63:
											num29 = qVpqG99c2WEReaDdAx(object_);
											num4 = 47;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 103;
										case 103:
											YeeoMqaS3J(intptr_, num29 * 4, 4, ref int_2);
											goto case 661;
										case 332:
											array7[3] = 29;
											num4 = 312;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 184;
										case 184:
											array10[num35 + 2] = array3[2];
											goto case 550;
										case 320:
											array16[0] = 103;
											goto case 563;
										case 318:
											reference2 = ref *(byte*)null;
											goto case 129;
										case 317:
											array2[27] = (byte)num14;
											num4 = 126;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 492;
										case 315:
											num13 = 115;
											num4 = 676;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 191;
										case 191:
											num10 = 104;
											goto case 578;
										case 312:
											array7[3] = 126;
											num4 = 504;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 308:
											num34 += 8;
											num4 = 535;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 329;
										case 306:
											lmdkVksVkh = new Hashtable(qVpqG99c2WEReaDdAx(object_) + 1);
											goto case 669;
										case 305:
											value = tw5WoxoSTRX6DVyYiHj(intptr_2);
											goto case 168;
										case 168:
										case 283:
											YGO4smCLb05L3pQqWL(intptr_2, 0);
											num4 = 86;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 19;
										case 300:
											array7[12] = 157;
											num4 = 413;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 6;
										case 297:
											array2[15] = (byte)num10;
											num4 = 338;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 293:
											array7[11] = 137;
											goto case 527;
										case 292:
											array2[14] = (byte)num10;
											goto case 577;
										case 290:
											num10 = 159;
											goto case 257;
										case 257:
											array2[13] = (byte)num10;
											num4 = 364;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 288:
											num33 = 95;
											num4 = 275;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 280:
											object_8 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
											num = 240;
											goto case 240;
										case 240:
											tlLX0O45pekanPs4Vv(object_8, array14, 0, array14.Length);
											num = 245;
											goto case 245;
										case 245:
											HE6aa3MQT40bYe6jbF(object_8);
											num4 = 166;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 278:
											array7[4] = (byte)num13;
											num4 = 78;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 288;
										case 275:
											array7[4] = (byte)num33;
											num4 = 89;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 196;
										case 196:
											num33 = 52;
											goto case 15;
										case 15:
											array7[4] = (byte)num33;
											num4 = 644;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 606;
										case 274:
											array10[num27 + 2] = array11[2];
											num4 = 562;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 446;
										case 270:
											num27 = 23;
											num4 = 368;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 256:
											num32 = (uint)((array15[num31 + 3] << 24) | (array15[num31 + 2] << 16) | (array15[num31 + 1] << 8) | array15[num31]);
											goto case 169;
										case 255:
											num27 = 16;
											num4 = 97;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 625;
										case 253:
											array16[3] = 74;
											goto case 223;
										case 250:
											goto IL_3e9b;
										case 244:
											array2[19] = 203;
											goto case 573;
										case 237:
											array7 = new byte[16];
											goto case 449;
										case 230:
											array7[11] = 148;
											goto case 637;
										case 227:
											array2[21] = (byte)num10;
											goto case 470;
										case 221:
											XomRM8bIN8UPjHCpJl(array4, 0, array4.Length);
											goto case 464;
										case 220:
											array2[17] = 96;
											goto case 18;
										case 18:
											num10 = 218;
											num4 = 646;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 207:
											array2[19] = (byte)num14;
											num = 244;
											goto case 244;
										case 204:
											array2[21] = 172;
											goto case 97;
										case 203:
											num14 = 106;
											goto case 350;
										case 202:
											array15 = array14;
											goto case 41;
										case 41:
											num30 = array15.Length % 4;
											goto case 414;
										case 198:
											if (array8.Length > 0)
											{
												num4 = 403;
												if (zsTZIhocVLyHHxkw2B())
												{
													continue;
												}
												goto IL_0b69;
											}
											goto case 143;
										case 194:
											num10 = 87;
											num4 = 292;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 186:
											array2[7] = 93;
											num = 440;
											goto case 440;
										case 185:
											array7[13] = (byte)num13;
											goto case 291;
										case 178:
											array12 = (byte[])HtYO9goR65ZnZqNeppP(num19);
											goto case 98;
										case 175:
											array2[22] = 96;
											goto case 389;
										case 174:
											num10 = 151;
											num4 = 227;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 166:
											array13 = (byte[])E33hZ75FLJf9RhO2jm(memoryStream);
											num = 626;
											goto case 626;
										case 101:
										case 165:
											if (num28 >= num29)
											{
												goto case 543;
											}
											goto case 536;
										case 164:
											array12 = null;
											num4 = 37;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 162:
											array10[num27 + 1] = array11[1];
											goto case 274;
										case 161:
											array9 = null;
											goto case 282;
										case 160:
											if (dVI91YrnPkdJxsxIix() != 4)
											{
												goto case 654;
											}
											goto case 305;
										case 150:
											num14 = 81;
											goto case 43;
										case 43:
											array2[20] = (byte)num14;
											num4 = 174;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 149:
											try
											{
												abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)dmG9BboWinYvTUuBkri(new IntPtr(num19), pGvyaUoCs0e61yToSVX(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
												num20 = 0;
												if (!zsTZIhocVLyHHxkw2B())
												{
													num20 = num21;
												}
												switch (num20)
												{
												}
											}
											catch (object obj2)
											{
												num22 = 0;
												if (!zsTZIhocVLyHHxkw2B())
												{
													num22 = num23;
												}
												switch (num22)
												{
												default:
													try
													{
														Delegate object_7 = (Delegate)dmG9BboWinYvTUuBkri(new IntPtr(num19), pGvyaUoCs0e61yToSVX(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle));
														num24 = 0;
														if (Y9PRou3gANeThLAUl2() != null)
														{
															goto IL_416e_2;
														}
														goto IL_4172_3;
														IL_4172_3:
														while (true)
														{
															switch (num24)
															{
															case 1:
																goto end_IL_4172_2;
															}
															abxkLGOVrU = (QZEOeHRUkDiNqCWT0p)Bngn2FoaYTjTpN1TWLn(pGvyaUoCs0e61yToSVX(typeof(QZEOeHRUkDiNqCWT0p).TypeHandle), cgChBZoxLmfaYfCPCnB(object_7));
															num24 = 1;
															if (Y9PRou3gANeThLAUl2() == null)
															{
																continue;
															}
															goto IL_416e_2;
															continue;
															end_IL_4172_2:
															break;
														}
														goto end_IL_411a_2;
														IL_416e_2:
														num24 = num25;
														goto IL_4172_3;
														end_IL_411a_2:;
													}
													catch (object obj)
													{
														num26 = 0;
														if (Y9PRou3gANeThLAUl2() != null)
														{
															break;
														}
														switch (num26)
														{
														default:
															goto end_IL_4183_2;
														}
														end_IL_4183_2:;
													}
													break;
												case 1:
													break;
												}
											}
											goto case 224;
										case 144:
											if (num18 != 4)
											{
												goto case 581;
											}
											goto case 496;
										case 139:
											num14 = 150;
											num4 = 547;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto case 314;
										case 138:
											num17 <<= 8;
											num4 = 14;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 308;
										case 131:
											array7[1] = 156;
											goto case 541;
										case 128:
											array5[7] = array8[3];
											goto case 674;
										case 123:
											num14 = 91;
											goto case 572;
										case 122:
											array2[6] = 209;
											num = 575;
											goto case 575;
										case 119:
											intptr_ = new IntPtr(URnkCOceLK + num15 - num16);
											num4 = 37;
											if (Y9PRou3gANeThLAUl2() != null)
											{
												continue;
											}
											goto case 63;
										case 117:
											num14 = 67;
											num4 = 433;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 115:
											array2[22] = (byte)num10;
											num = 175;
											goto case 175;
										case 109:
											array5 = array7;
											num4 = 5;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 64;
										case 64:
											lK6WilpJUsicVTXIVT(array5);
											goto case 660;
										case 94:
											text = (string)sHN3epoQMZK4PFcuHtL(bBJEAloYpNk4UyJ8sHr(), array6);
											num4 = 546;
											if (Y9PRou3gANeThLAUl2() == null)
											{
												continue;
											}
											goto IL_0b69;
										case 88:
											array2[31] = (byte)num14;
											num4 = 436;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 86:
											rNZkehfwNu = new QZEOeHRUkDiNqCWT0p(NvQ34uZt895nxEhi2FIr);
											goto case 47;
										case 47:
											intPtr = IntPtr.Zero;
											num4 = 532;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 81:
											num14 = 88;
											goto case 495;
										case 80:
											Clrlm6amwrPntrY5km();
											num4 = 645;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 77:
											num13 = 168;
											num4 = 481;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 76:
											QW0CkRo6EUIwsdX7Vo6(JnhiujosIZn7uGuVX80(cgChBZoxLmfaYfCPCnB(rNZkehfwNu)));
											goto case 161;
										case 75:
											array6[11] = 108;
											goto case 483;
										case 74:
											array2[14] = 137;
											num4 = 8;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 194;
										case 58:
											array2[28] = 164;
											num4 = 484;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 437;
										case 56:
											num13 = 74;
											num4 = 278;
											if (zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto IL_0b69;
										case 49:
											num13 = 225;
											goto case 185;
										case 45:
											transform = (ICryptoTransform)DubemGtvZSZMZYmgai(object_6, array4, array5);
											num4 = 173;
											if (!zsTZIhocVLyHHxkw2B())
											{
												continue;
											}
											goto case 221;
										case 37:
											array3 = null;
											goto case 375;
										case 36:
											num11 += num12;
											goto case 256;
										case 26:
											array2[7] = (byte)num10;
											goto case 186;
										case 22:
											num9 = 0;
											goto case 135;
										case 11:
											array2[30] = 169;
											goto case 386;
										case 7:
											try
											{
												while (mA0d81jE1xtIkO2NjW(enumerator))
												{
													while (true)
													{
														ProcessModule object_2 = (ProcessModule)NIfdmWRmdKAueFHZB9(enumerator);
														num5 = 1;
														if (Y9PRou3gANeThLAUl2() == null)
														{
															goto IL_4518_2;
														}
														goto IL_453b_2;
														IL_453b_2:
														switch (num5)
														{
														case 11:
															break;
														case 8:
															goto IL_4485_2;
														case 10:
															goto IL_44a2_2;
														case 4:
															goto IL_44b0_2;
														case 5:
															goto IL_44c9_2;
														case 3:
															goto IL_4500_2;
														case 2:
															goto IL_4518_2;
														default:
															goto end_IL_4572_2;
														case 9:
															continue;
														case 1:
														case 7:
															goto IL_458f_2;
														case 0:
														case 6:
															goto end_IL_4572_2;
														}
														goto IL_4472_2;
														IL_4518_2:
														if (!LAexqA6X1I2W4ySWwq(kw8X2qsMXNjBZRXLvT(AOFJ78vTLsOCHOIh1G(object_2)), "clrjit.dll"))
														{
															goto IL_458f_2;
														}
														num6 = 5;
														goto IL_44c9_2;
														IL_44b0_2:
														PRZkZqsNsa = true;
														num5 = 0;
														if (!zsTZIhocVLyHHxkw2B())
														{
															goto IL_44c3_2;
														}
														goto IL_453b_2;
														IL_44c9_2:
														object_3 = new Version(j7IMgGOYSE397Ua9ZN(hoGyAW0BBReglqBbda(object_2)), dIXrY3JjVD25LOGIY4(hoGyAW0BBReglqBbda(object_2)), UWglbRdGtRw0qv3B2Q(hoGyAW0BBReglqBbda(object_2)), p5StAqTfUfvhvvhRoK(hoGyAW0BBReglqBbda(object_2)));
														goto IL_4500_2;
														IL_4500_2:
														object_4 = new Version(4, 0, 30319, 17020);
														goto IL_4472_2;
														IL_4472_2:
														object_5 = new Version(4, 0, 30319, 17921);
														goto IL_4485_2;
														IL_4485_2:
														if (z7yjtgPHbZfAZq9vbT(object_3, object_4))
														{
															goto IL_44a2_2;
														}
														num5 = 1;
														if (!zsTZIhocVLyHHxkw2B())
														{
															goto IL_44c3_2;
														}
														goto IL_453b_2;
														IL_44c3_2:
														num5 = num6;
														goto IL_453b_2;
														IL_44a2_2:
														if (!f827GqyGVIY5v0FG7e(object_3, object_5))
														{
															goto IL_458f_2;
														}
														goto IL_44b0_2;
														continue;
														end_IL_4572_2:
														break;
													}
													break;
													IL_458f_2:;
												}
											}
											finally
											{
												IDisposable disposable = enumerator as IDisposable;
												while (disposable != null)
												{
													num7 = 1;
													if (!zsTZIhocVLyHHxkw2B())
													{
														break;
													}
													while (true)
													{
														switch (num7)
														{
														case 1:
															PoZNpcNTKX7VUasV1N(disposable);
															num7 = 0;
															if (Y9PRou3gANeThLAUl2() != null)
															{
																num7 = num8;
															}
															continue;
														default:
															goto end_IL_45ce_2;
														case 2:
															break;
														case 0:
															goto end_IL_45ce_2;
														}
														goto IL_45e1_2;
														continue;
														end_IL_45ce_2:
														break;
													}
													break;
													IL_45e1_2:;
												}
											}
											goto IL_1a49;
										case 71:
											ktV5QQovHKuvUeDP367(abxkLGOVrU);
											goto case 482;
										case 21:
											Clrlm6amwrPntrY5km();
											num = 405;
											return;
										case 405:
											return;
										case 450:
											YeeoMqaS3J(new IntPtr(value), dVI91YrnPkdJxsxIix(), int_, ref int_);
											goto end_IL_0009;
										case 152:
										case 579:
											goto end_IL_0009;
										case 630:
											Clrlm6amwrPntrY5km();
											return;
										case 217:
											return;
										case 642:
											return;
										case 645:
											return;
										}
										break;
									}
									break;
									IL_1a03:
									if (VMbOjrVdXLOXxnB30U(zAA4jhFNjEZkwnt2ce("System.Reflection.ReflectionContext", bool_0: false), null))
									{
										goto IL_1a16;
									}
									goto IL_1a49;
									IL_1a16:
									object_16 = (ProcessModuleCollection)PXMX0n2kQjCBnmMug4(a71Z2JEAAImKLaHKg4());
									num = 595;
									goto IL_1a2b;
									IL_1a2b:
									enumerator = (IEnumerator)M38yQbXx7NDg3VeUb0(object_16);
									num4 = 7;
									if (Y9PRou3gANeThLAUl2() == null)
									{
										goto IL_0070;
									}
									goto IL_0b69;
									IL_198e:
									flag = eteeU8xgtls3IG3UXH(rgHrDFGHQoOhoONrxI(Gm1JSA1pv5vDMUij1U(gXUHWQIcsHp9p0cVfY(a71Z2JEAAImKLaHKg4())), "__", 10u), IntPtr.Zero);
									goto IL_19b5;
									IL_19b5:
									if (!flag)
									{
										num4 = 80;
										if (Y9PRou3gANeThLAUl2() == null)
										{
											goto IL_0070;
										}
										goto IL_19c9;
									}
									goto IL_19fb;
									IL_0b69:
									num4 = num;
									goto IL_0070;
									IL_19c9:
									num14 = 133;
									goto IL_19d2;
									IL_19d2:
									array2[27] = (byte)num14;
									goto IL_19e0;
									IL_19e0:
									num14 = 93;
									num4 = 317;
									if (zsTZIhocVLyHHxkw2B())
									{
										goto IL_0070;
									}
									goto IL_0b69;
								}
								break;
							}
							break;
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
		Clrlm6amwrPntrY5km();
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
			BV0kmUIPgx = (MacgPI7JyVeAhNaPvd)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554475)));
		}
		return BV0kmUIPgx(intptr_0, (string)object_0, uint_0);
	}

	private static IntPtr YDsoA9ylfU(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (yBRkv0eFeZ == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			yBRkv0eFeZ = (GL8NaIwq2KOvLQhMFX)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554476)));
		}
		return yBRkv0eFeZ(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int mTfoQqVbOE(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (tTVkFDSO7A == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			tTVkFDSO7A = (yy2w1VXOQgx806ubre)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554477)));
		}
		return tTVkFDSO7A(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int YeeoMqaS3J(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (zIOkYypt1M == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			zIOkYypt1M = (N7UlhA3IRW2ugh7tWg)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554478)));
		}
		return zIOkYypt1M(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr tdOo5aPwrv(uint uint_0, int int_0, uint uint_1)
	{
		if (tuYkt9D06I == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			tuYkt9D06I = (RI754BJF754hNSApRW)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554479)));
		}
		return tuYkt9D06I(uint_0, int_0, uint_1);
	}

	private static int Q2sob65b9D(IntPtr intptr_0)
	{
		if (etmkyDG2SG == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			etmkyDG2SG = (YLCGmBEaUwBbEqLM01)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.vkJHMafihv8j6(33554480)));
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

	internal static byte[] rLIoBbVVpm(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	[RJDcsuMfOxrTCYImPe(typeof(RJDcsuMfOxrTCYImPe.iGR41459RDH4FvPdNk<object>[]))]
	private static byte[] oN9oGXMAK7(object object_0)
	{
		Stream stream = Njco6C1nc4();
		SymmetricAlgorithm symmetricAlgorithm = PEXoCqmS4w();
		symmetricAlgorithm.Key = new byte[32]
		{
			57, 202, 205, 188, 199, 133, 25, 211, 113, 125,
			12, 119, 241, 13, 110, 173, 61, 113, 68, 188,
			160, 47, 224, 223, 192, 124, 32, 122, 253, 113,
			118, 60
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			237, 242, 160, 42, 62, 72, 176, 234, 55, 43,
			165, 20, 208, 21, 36, 141
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_0, 0, ((Array)object_0).Length);
		cryptoStream.Close();
		byte[] result = rLIoBbVVpm(stream);
		hHEYokUTtehNq5ji0d.ThWHMaWzZ2ba7();
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

	internal static object fkIwNwmVKi5yRqEQdh(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object kSkTnLtwTIW7EkyyQR(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void paZQQfdeFtplXyg7G3(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long qCrZtwZjZUTJMym7fW(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object jAHG4aCBtDROmYGPWC(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void YpD0Fd4TjMFWqFa2kT(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void SAwNvoPLDoGUYZKqjK(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object pEcLGB62tRpMtpQxQM(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object Gk2Z0Xx4FKqDKT4nls(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object FF7A3kGXYU5RK5YOut()
	{
		return PEXoCqmS4w();
	}

	internal static void EeOHvggonRKXUnIIBJ(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object lbMZqQWSUJ8k7hp4dX(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object VAFqXXnmbnR73CP6vq()
	{
		return Njco6C1nc4();
	}

	internal static void jVoePfFGJkAAa4kwF7(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void qjeSwSUdLc99FLWQTj(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object GUiGFYD4pnOaSu7bNp(object object_0)
	{
		return rLIoBbVVpm(object_0);
	}

	internal static void eYBQyBcgwPyWfE3hcd(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int XA6xRAkllA3Wf6Dhol(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void EZvZiTOhRh2Jtot93U()
	{
		hHEYokUTtehNq5ji0d.ThWHMaWzZ2ba7();
	}

	internal static object UHv9ryYgar3LCpinDA()
	{
		return Encoding.Unicode;
	}

	internal static object gt060kuKVbSgl0solW(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool VNbvZDI489boxOicgD()
	{
		return (object)null == null;
	}

	internal static object b1p0PaTYErpom6373D()
	{
		return null;
	}

	internal static void qk4vFf8cv6WfKLrxG4()
	{
		hHEYokUTtehNq5ji0d.ThWHMaWzZ2ba7();
	}

	internal static void zijw4gLPoKMQ80FkgW(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type dFlohZukXVlLNdO3Wm(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object l5eZx0jbFCUtbnw9lr(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int TG3HhVRBBs4wpds9sh(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object tSbCyZyH75nUOoEqUu()
	{
		return SHA1.Create();
	}

	internal static object LtIoVDPZRDWqQ3ojY4(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool FmcJK3fkL444CAkNBc(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object up7CeYhr5Zn9eCBEmP(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object CqFRpw3H4WgipsCUkX(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void AfxDFT0JWREM3YgPTu(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long TlolCcKiBrkkVNNuK4(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object PnBrbGN8O2RiE07OsT(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static object mJMpYCgJnSJQEfTsx5()
	{
		return PEXoCqmS4w();
	}

	internal static void bP8gF1bqUs5cUm6EsF(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object Kn6BALi52rAKnekOO2(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object MRexKMZmlYYxkTf7hV()
	{
		return Njco6C1nc4();
	}

	internal static void eRnR2eDYIGH5o8fZqC(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void YK5PK97K865EZ6MCIV(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object bg9pjbsTgmr4Y2ibm7()
	{
		return Encoding.UTF8;
	}

	internal static object euC1OhBa9JC3mmLYAV(object object_0)
	{
		return rLIoBbVVpm(object_0);
	}

	internal static object HkrbSIY6wuxq79VQVp(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void mZyw70X38IqJIsGYS5(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void BBXoTY69aIvaEMFrUF(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void CL3Bc4cMAuqGeqC8mA(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static void Xg5xLhqQWYmO9wHjQY(object object_0, object object_1, uint uint_0, object object_2)
	{
		vBuojdip3i(object_0, object_1, uint_0, object_2);
	}

	internal static ushort CxZr5b1JL8a2AbAV3x(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int fwhH4UoUJ0ZKgVhLBO(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void oH1rnNJX2rtCWil4vG(object object_0, object object_1, int int_0, int int_1)
	{
		NSmolmd79S(object_0, object_1, int_0, int_1);
	}

	internal static long QJEuD7n85S86RcD4fZ(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint PdQ6cnQOnWN5YXiVGK(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint fT4l9jImv70V2cJ96G(uint uint_0, int int_0, long long_0, object object_0)
	{
		return SDQoufkqT0(uint_0, int_0, long_0, object_0);
	}

	internal static long FOKtQbdy8yctjHURwn(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object gool502OPVjowJN0g8(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object KReb0denSSXW7W56GP(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void DoaHRjWsue9oM2L4FH(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object GCDshu9maFDA7HPiOE(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool gwJBl6MJA7FQWquL4b(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object FF971FpWPqHy7OdZQK(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object W8jKdpFvs6gP4lHCFR(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object zTG54gaKSfOXFblohT(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool LiBL2dUkUOLlBR01HC()
	{
		return (object)null == null;
	}

	internal static object tMvWB1Ab8QplFjK3Kd()
	{
		return null;
	}

	internal static IntPtr YGO4smCLb05L3pQqWL(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static int knn1A1kptkasxsLBZj(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt32(intptr_0, int_0);
	}

	internal static long nrC731YCVEcvGAsRoX(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadInt64(intptr_0, int_0);
	}

	internal static void enLfcYQKgZbAne4yyx(IntPtr intptr_0, int int_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
	}

	internal static void oGhRhplYdDMGaAZ2Bp(IntPtr intptr_0, int int_0, int int_1)
	{
		Marshal.WriteInt32(intptr_0, int_0, int_1);
	}

	internal static void OtIrloWOhTIlSVacEw(IntPtr intptr_0, int int_0, long long_0)
	{
		Marshal.WriteInt64(intptr_0, int_0, long_0);
	}

	internal static IntPtr oTMvA6c4kGBeCHbTs3(int int_0)
	{
		return Marshal.AllocCoTaskMem(int_0);
	}

	internal static void sSUWWuShXng1BRbVoN(object object_0, int int_0, IntPtr intptr_0, int int_1)
	{
		Marshal.Copy((byte[])object_0, int_0, intptr_0, int_1);
	}

	internal static void EbLcZfLqERCnRuQ379()
	{
		svloy6EVGc();
	}

	internal static object a71Z2JEAAImKLaHKg4()
	{
		return Process.GetCurrentProcess();
	}

	internal static object gXUHWQIcsHp9p0cVfY(object object_0)
	{
		return ((Process)object_0).MainModule;
	}

	internal static IntPtr Gm1JSA1pv5vDMUij1U(object object_0)
	{
		return ((ProcessModule)object_0).BaseAddress;
	}

	internal static IntPtr rgHrDFGHQoOhoONrxI(IntPtr intptr_0, object object_0, uint uint_0)
	{
		return w3ZoqRBn5p(intptr_0, object_0, uint_0);
	}

	internal static bool eteeU8xgtls3IG3UXH(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 != intptr_1;
	}

	internal static void Clrlm6amwrPntrY5km()
	{
		hHEYokUTtehNq5ji0d.ThWHMaWzZ2ba7();
	}

	internal static int dVI91YrnPkdJxsxIix()
	{
		return IntPtr.Size;
	}

	internal static Type zAA4jhFNjEZkwnt2ce(object object_0, bool bool_0)
	{
		return Type.GetType((string)object_0, bool_0);
	}

	internal static bool VMbOjrVdXLOXxnB30U(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static object PXMX0n2kQjCBnmMug4(object object_0)
	{
		return ((Process)object_0).Modules;
	}

	internal static object M38yQbXx7NDg3VeUb0(object object_0)
	{
		return ((ReadOnlyCollectionBase)object_0).GetEnumerator();
	}

	internal static object NIfdmWRmdKAueFHZB9(object object_0)
	{
		return ((IEnumerator)object_0).Current;
	}

	internal static object AOFJ78vTLsOCHOIh1G(object object_0)
	{
		return ((ProcessModule)object_0).ModuleName;
	}

	internal static object kw8X2qsMXNjBZRXLvT(object object_0)
	{
		return ((string)object_0).ToLower();
	}

	internal static bool LAexqA6X1I2W4ySWwq(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static object hoGyAW0BBReglqBbda(object object_0)
	{
		return ((ProcessModule)object_0).FileVersionInfo;
	}

	internal static int j7IMgGOYSE397Ua9ZN(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMajorPart;
	}

	internal static int dIXrY3JjVD25LOGIY4(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductMinorPart;
	}

	internal static int UWglbRdGtRw0qv3B2Q(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductBuildPart;
	}

	internal static int p5StAqTfUfvhvvhRoK(object object_0)
	{
		return ((FileVersionInfo)object_0).ProductPrivatePart;
	}

	internal static bool z7yjtgPHbZfAZq9vbT(object object_0, object object_1)
	{
		return (Version?)object_0 >= (Version?)object_1;
	}

	internal static bool f827GqyGVIY5v0FG7e(object object_0, object object_1)
	{
		return (Version?)object_0 < (Version?)object_1;
	}

	internal static bool mA0d81jE1xtIkO2NjW(object object_0)
	{
		return ((IEnumerator)object_0).MoveNext();
	}

	internal static void PoZNpcNTKX7VUasV1N(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static object gw9ikDqUK6y0McRKYR(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object CQLXcXZ398Y8S7aiIZ(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).KDikMXewCI();
	}

	internal static void Ljb91xfZyaVHDXcTvW(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long yo7LynetO8iH3reo9x(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object a4X4WBibbNOPOEpG16(object object_0, int int_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).B2XkaLi4dH(int_0);
	}

	internal static void lK6WilpJUsicVTXIVT(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object XUD6i2UlMYIHfyd1mT(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object Ja2n2A8qoejSRSPbdp(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static void XomRM8bIN8UPjHCpJl(object object_0, int int_0, int int_1)
	{
		Array.Clear((Array)object_0, int_0, int_1);
	}

	internal static object S62xQE7PDgvJGO3l0r(object object_0)
	{
		return ((Assembly)object_0).GetModules();
	}

	internal static IntPtr qiw0OggH91oSliUlt9(object object_0)
	{
		return Marshal.GetHINSTANCE((Module)object_0);
	}

	internal static object ppEhj6AuCDPDVD168n(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int MT03WghUnhoOR7oMCp(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int qVpqG99c2WEReaDdAx(object object_0)
	{
		return ((VtNVUKGulysZw81C3E)object_0).TVtkAMaqpL();
	}

	internal static object VGrrEoDggRjTHsda21()
	{
		return PEXoCqmS4w();
	}

	internal static void q9iljNK8ASXQhoMHU2(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object DubemGtvZSZMZYmgai(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static void tlLX0O45pekanPs4Vv(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void HE6aa3MQT40bYe6jbF(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object E33hZ75FLJf9RhO2jm(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static void Iyxe5cueaYb6cWyOUP(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void cIFsBZwQxdRdEPHV3h(object object_0)
	{
		((VtNVUKGulysZw81C3E)object_0).VDqkQKyKML();
	}

	internal static int o7okpEHxNgvXvALBJn(object object_0)
	{
		return ((Process)object_0).Id;
	}

	internal static IntPtr BnRbcUmtkdq1KkRY80(uint uint_0, int int_0, uint uint_1)
	{
		return tdOo5aPwrv(uint_0, int_0, uint_1);
	}

	internal static object dRL5SfBSlDfHVRbDp6(int int_0)
	{
		return BitConverter.GetBytes(int_0);
	}

	internal static long a8jp0TzOh1jXxVdK1L(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static void AG4AEFonT6onCnjkPYZ(IntPtr intptr_0, int int_0)
	{
		Marshal.WriteInt32(intptr_0, int_0);
	}

	internal static int gPDWRhooVu9RmYFMYd9(IntPtr intptr_0)
	{
		return Q2sob65b9D(intptr_0);
	}

	internal static void TL77LIo3jVmAbSU6Pr4(object object_0, object object_1, object object_2)
	{
		((Hashtable)object_0).Add(object_1, object_2);
	}

	internal static Type pGvyaUoCs0e61yToSVX(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int rhCWlWokCRiOQGFE8fB(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static object bBJEAloYpNk4UyJ8sHr()
	{
		return Encoding.UTF8;
	}

	internal static object sHN3epoQMZK4PFcuHtL(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static bool aiB4GaolTgcn8wKBVnj(IntPtr intptr_0, IntPtr intptr_1)
	{
		return intptr_0 == intptr_1;
	}

	internal static object dmG9BboWinYvTUuBkri(IntPtr intptr_0, Type type_0)
	{
		return iaKoOg5GGg(intptr_0, type_0);
	}

	internal static IntPtr xupvcpocKUiHHa9GIJc(object object_0)
	{
		return object_0();
	}

	internal static int tw5WoxoSTRX6DVyYiHj(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static long AZnZCaoLe5YenS0v99G(IntPtr intptr_0)
	{
		return Marshal.ReadInt64(intptr_0);
	}

	internal static IntPtr WhYKoEoEVDj0BRONceg(object object_0)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)object_0);
	}

	internal static int exd8eVoIf4YbeAwGfl2(object object_0)
	{
		return ((ProcessModule)object_0).ModuleMemorySize;
	}

	internal static object LvTgFno13q17LPWObCi(object object_0)
	{
		return ((Assembly)object_0).EntryPoint;
	}

	internal static bool PwZxQBoGJcRYPUUSxpn(object object_0, object object_1)
	{
		return (MethodInfo?)object_0 != (MethodInfo?)object_1;
	}

	internal static object cgChBZoxLmfaYfCPCnB(object object_0)
	{
		return ((Delegate)object_0).Method;
	}

	internal static object Bngn2FoaYTjTpN1TWLn(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static object pr3tUVorR8p3TGjMUyr(object object_0)
	{
		return ((MethodBase)object_0).GetParameters();
	}

	internal static object UF9VgZoFvmVN18c4OvL(object object_0)
	{
		return ((Assembly)object_0).ManifestModule;
	}

	internal static ModuleHandle b0R6MpoVSSFeeVRDeIw(object object_0)
	{
		return ((Module)object_0).ModuleHandle;
	}

	internal static Type XKSpaXo2KP35YlNYYog(object object_0)
	{
		return object_0.GetType();
	}

	internal static object NoUrm9oXMVTut20JQyC(object object_0, object object_1)
	{
		return ((FieldInfo)object_0).GetValue(object_1);
	}

	internal static object HtYO9goR65ZnZqNeppP(long long_0)
	{
		return BitConverter.GetBytes(long_0);
	}

	internal static void ktV5QQovHKuvUeDP367(object object_0)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)object_0);
	}

	internal static RuntimeMethodHandle JnhiujosIZn7uGuVX80(object object_0)
	{
		return ((MethodBase)object_0).MethodHandle;
	}

	internal static void QW0CkRo6EUIwsdX7Vo6(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void dDLV76o00WPVr6s4qQ2(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static IntPtr e0UN5DoO7MCaJQH4UcX(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		return YDsoA9ylfU(intptr_0, uint_0, uint_1, uint_2);
	}

	internal static void j9oi6QoJr13qBP7f6Dq(IntPtr intptr_0, IntPtr intptr_1)
	{
		Marshal.WriteIntPtr(intptr_0, intptr_1);
	}

	internal static bool zsTZIhocVLyHHxkw2B()
	{
		return (object)null == null;
	}

	internal static object Y9PRou3gANeThLAUl2()
	{
		return null;
	}
}
