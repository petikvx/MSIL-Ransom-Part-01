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
using XojDhSNsCJNUQnB1Mi;
using r3fa6YwLARGyaKnXUV;

namespace eRO8rC7xBFSIpkK1fP;

internal class awYSQNJbxdPDQ9b5BH
{
	private delegate void vdGQQSL3XTOYRutKLV(object o);

	internal class WAG8Lb0oci51KAcM9Q : Attribute
	{
		internal class TpmTfLZb0JkAt6R9MH<BFvM6ruGr7GFBfhhbu>
		{
			internal static object VPjtfvx2qOqkeSDDfMA;

			public TpmTfLZb0JkAt6R9MH()
			{
				j9QW3pmTf();
				ogBUnd2ju1Vg8teO7c.E2gWFx4z4NEdd();
				base._002Ector();
			}

			static TpmTfLZb0JkAt6R9MH()
			{
				pSIvpkK1f();
			}

			internal static bool AAeJN5xPZ4NGfuKp4LO()
			{
				return VPjtfvx2qOqkeSDDfMA == null;
			}

			internal static object tjghYExvsKXM7QfDnC2()
			{
				return VPjtfvx2qOqkeSDDfMA;
			}
		}

		[WAG8Lb0oci51KAcM9Q(typeof(TpmTfLZb0JkAt6R9MH<object>[]))]
		public WAG8Lb0oci51KAcM9Q(object object_0)
		{
		}
	}

	internal class i3HluHmF0rLSxZiBN5
	{
		[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
		internal static string iSS6kfc26y(string string_0, string string_1)
		{
			byte[] array = (byte[])CpDbynxG4TPgNyt7Ijq(RSShK0xrJTnw3iUwRal(), string_0);
			byte[] array2 = array;
			byte[] array3 = new byte[32];
			V8SuemxyBajFAnAjm6V(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] object_ = array3;
			byte[] iV = (byte[])cJ5HFdxc04Yfq3RuLPg(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)BsRO5VxMSwacEiLh7aZ();
			HfLRqvxilO7ZaLiPhrY(symmetricAlgorithm, object_);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)gk0IumxOBbIlGImcrVf(symmetricAlgorithm), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			qgYdABx5N8JJsdBhfZy(cryptoStream);
			return Convert.ToBase64String((byte[])CYLSu0xD5B454xIqikS(memoryStream));
		}

		internal static object RSShK0xrJTnw3iUwRal()
		{
			return Encoding.Unicode;
		}

		internal static object CpDbynxG4TPgNyt7Ijq(object object_0, object object_1)
		{
			return ((Encoding)object_0).GetBytes((string)object_1);
		}

		internal static void V8SuemxyBajFAnAjm6V(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static object cJ5HFdxc04Yfq3RuLPg(object object_0)
		{
			return dpvDDD0Bk((byte[])object_0);
		}

		internal static object BsRO5VxMSwacEiLh7aZ()
		{
			return DieQgNWrf();
		}

		internal static void HfLRqvxilO7ZaLiPhrY(object object_0, object object_1)
		{
			((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
		}

		internal static object gk0IumxOBbIlGImcrVf(object object_0)
		{
			return ((SymmetricAlgorithm)object_0).CreateEncryptor();
		}

		internal static void qgYdABx5N8JJsdBhfZy(object object_0)
		{
			((Stream)object_0).Close();
		}

		internal static object CYLSu0xD5B454xIqikS(object object_0)
		{
			return ((MemoryStream)object_0).ToArray();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint IrrV4PnqvwTO99MxWA(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr o6PfXCOMlvwnm4tgY7();

	internal struct plSkGExoVrRoKK0pcC
	{
		internal bool L9p6ra9Wgc;

		internal byte[] qA7660uh42;
	}

	internal class Mc8pUl5GpB1LDt3xfk
	{
		private BinaryReader oRs6lubfmX;

		public Mc8pUl5GpB1LDt3xfk(Stream stream_0)
		{
			oRs6lubfmX = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return (Stream)akVPGxxw98t7rEoEF2v(oRs6lubfmX);
		}

		internal byte[] kJE6B3tUyy(int int_0)
		{
			return oRs6lubfmX.ReadBytes(int_0);
		}

		internal int Gcm6SlK1T8(byte[] byte_0, int int_0, int int_1)
		{
			return oRs6lubfmX.Read(byte_0, int_0, int_1);
		}

		internal int YBi6YXmhbE()
		{
			return oRs6lubfmX.ReadInt32();
		}

		internal void B8M6joGr6C()
		{
			bkL27sxJR1c8GI5TADC(oRs6lubfmX);
		}

		internal static object akVPGxxw98t7rEoEF2v(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static void bkL27sxJR1c8GI5TADC(object object_0)
		{
			((BinaryReader)object_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr FedICOErV6g9Wj3eXj(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Vi1xkKXhyrm614lS8f(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int FdkQnFcG7WxkaNbkvI(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int j6wiuYRa1mNvBHDi0C(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr q8auF9ChrMlZycgrom(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int wgyCs8fDdljP476WNk(IntPtr ptr);

	[Flags]
	private enum UT6AaKThXbHft3jbqX
	{

	}

	private static byte[] RnXr5UVZkE;

	private static int SyKrf1HfHe;

	private static bool sfXrTan0ZO;

	internal static IrrV4PnqvwTO99MxWA LrxrwdLrnE;

	private static long jskrQufruF;

	private static SortedList PCvr21Jxdh;

	internal static IrrV4PnqvwTO99MxWA TqxrbZCGxs;

	internal static Hashtable x3ur3XfIGK;

	private static Vi1xkKXhyrm614lS8f rXJrUit6pd;

	private static q8auF9ChrMlZycgrom CEurhCFsGi;

	private static wgyCs8fDdljP476WNk o1FriD7RBV;

	private static object cYLrxARGya;

	private static bool KahrDvRcie;

	private static IntPtr F9crcXdOZ0;

	internal static Assembly EFgrLBUndj;

	private static Dictionary<int, int> TbDrOu93fa;

	private static int NGMryJf97r;

	private static bool vchrZojDhS;

	private static int[] VjarCykiX9;

	private static j6wiuYRa1mNvBHDi0C UVPrWCNw97;

	private static IntPtr bZJrzD9VBO;

	private static FedICOErV6g9Wj3eXj t3jrae7Xo9;

	private static int PdprNmQQLW;

	private static bool VCJruNUQnB;

	private static IntPtr fA6rXOmt6o;

	[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
	private static bool E7orvEB5Ex;

	private static bool B6lrGkKyn4;

	private static uint[] z1Vr0g8teO;

	private static bool NHfr7t3jbq;

	private static byte[] eLErEIMtkF;

	private static FdkQnFcG7WxkaNbkvI b8ars1t0jB;

	private static byte[] tMirmn3iFU;

	private static IntPtr hBFrKDpmkG;

	private static long HXHrdFx1K1;

	private static int ly2rVw8cvN;

	private static object N2ZrR8LxB9;

	internal static RSACryptoServiceProvider gKqrnR86yQ;

	static awYSQNJbxdPDQ9b5BH()
	{
		NHfr7t3jbq = false;
		EFgrLBUndj = Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554450)).Assembly;
		z1Vr0g8teO = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		vchrZojDhS = false;
		VCJruNUQnB = false;
		tMirmn3iFU = new byte[0];
		gKqrnR86yQ = null;
		TbDrOu93fa = null;
		cYLrxARGya = new object();
		RnXr5UVZkE = new byte[0];
		eLErEIMtkF = new byte[0];
		fA6rXOmt6o = IntPtr.Zero;
		F9crcXdOZ0 = IntPtr.Zero;
		N2ZrR8LxB9 = new string[0];
		VjarCykiX9 = new int[0];
		SyKrf1HfHe = 1;
		sfXrTan0ZO = false;
		PCvr21Jxdh = new SortedList();
		PdprNmQQLW = 0;
		HXHrdFx1K1 = 0L;
		LrxrwdLrnE = null;
		TqxrbZCGxs = null;
		jskrQufruF = 0L;
		ly2rVw8cvN = 0;
		KahrDvRcie = false;
		B6lrGkKyn4 = false;
		NGMryJf97r = 0;
		hBFrKDpmkG = IntPtr.Zero;
		E7orvEB5Ex = false;
		x3ur3XfIGK = new Hashtable();
		t3jrae7Xo9 = null;
		rXJrUit6pd = null;
		b8ars1t0jB = null;
		UVPrWCNw97 = null;
		CEurhCFsGi = null;
		o1FriD7RBV = null;
		bZJrzD9VBO = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void d5uWFx4s1vKUp()
	{
	}

	internal static byte[] XgufCXaBN(byte[] byte_0)
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
			zdxT6UJci(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			zdxT6UJci(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			zdxT6UJci(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			zdxT6UJci(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			zdxT6UJci(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			zdxT6UJci(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			zdxT6UJci(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			zdxT6UJci(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			zdxT6UJci(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			zdxT6UJci(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			zdxT6UJci(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			zdxT6UJci(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			zdxT6UJci(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			zdxT6UJci(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			zdxT6UJci(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			zdxT6UJci(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			rad2h00ni(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			rad2h00ni(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			rad2h00ni(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			rad2h00ni(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			rad2h00ni(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			rad2h00ni(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			rad2h00ni(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			rad2h00ni(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			rad2h00ni(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			rad2h00ni(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			rad2h00ni(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			rad2h00ni(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			rad2h00ni(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			rad2h00ni(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			rad2h00ni(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			rad2h00ni(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			UMONBba4N(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			UMONBba4N(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			UMONBba4N(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			UMONBba4N(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			UMONBba4N(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			UMONBba4N(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			UMONBba4N(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			UMONBba4N(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			UMONBba4N(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			UMONBba4N(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			UMONBba4N(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			UMONBba4N(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			UMONBba4N(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			UMONBba4N(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			UMONBba4N(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			UMONBba4N(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			yH6da7YuV(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			yH6da7YuV(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			yH6da7YuV(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			yH6da7YuV(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			yH6da7YuV(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			yH6da7YuV(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			yH6da7YuV(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			yH6da7YuV(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			yH6da7YuV(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			yH6da7YuV(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			yH6da7YuV(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			yH6da7YuV(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			yH6da7YuV(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			yH6da7YuV(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			yH6da7YuV(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			yH6da7YuV(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void zdxT6UJci(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + MoAwmZGkO(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + z1Vr0g8teO[uint_5 - 1], ushort_0);
	}

	private static void rad2h00ni(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + MoAwmZGkO(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + z1Vr0g8teO[uint_5 - 1], ushort_0);
	}

	private static void UMONBba4N(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + MoAwmZGkO(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + z1Vr0g8teO[uint_5 - 1], ushort_0);
	}

	private static void yH6da7YuV(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + MoAwmZGkO(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + z1Vr0g8teO[uint_5 - 1], ushort_0);
	}

	private static uint MoAwmZGkO(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool cvEbcMfxS()
	{
		if (!vchrZojDhS)
		{
			ohTVlm9Zn();
			vchrZojDhS = true;
		}
		return VCJruNUQnB;
	}

	internal static SymmetricAlgorithm DieQgNWrf()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (cvEbcMfxS())
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

	internal static void ohTVlm9Zn()
	{
		try
		{
			VCJruNUQnB = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] dpvDDD0Bk(byte[] byte_0)
	{
		if (!cvEbcMfxS())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return XgufCXaBN(byte_0);
	}

	internal static void MYSGQNbxd(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			nDQy9b5BH(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void nDQy9b5BH(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint eROK8rCxB(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
	internal static void pSIvpkK1f()
	{
		int num = 13;
		string object_ = default(string);
		string text = default(string);
		int num4 = default(int);
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		int num9 = default(int);
		int num12 = default(int);
		byte[] object_5 = default(byte[]);
		SymmetricAlgorithm object_6 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] object_4 = default(byte[]);
		int num11 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		int num10 = default(int);
		CryptoStream object_3 = default(CryptoStream);
		Stream stream = default(Stream);
		byte[] array3 = default(byte[]);
		int num14 = default(int);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		long long_ = default(long);
		int num27 = default(int);
		long num22 = default(long);
		int num23 = default(int);
		long num24 = default(long);
		byte[] array5 = default(byte[]);
		uint num20 = default(uint);
		byte[] array4 = default(byte[]);
		uint uint_2 = default(uint);
		uint num28 = default(uint);
		long num26 = default(long);
		uint num18 = default(uint);
		long num25 = default(long);
		uint num21 = default(uint);
		bool flag2 = default(bool);
		uint num19 = default(uint);
		uint uint_ = default(uint);
		int int_ = default(int);
		uint num17 = default(uint);
		int num31 = default(int);
		bool flag = default(bool);
		while (true)
		{
			if (gKqrnR86yQ == null)
			{
				goto IL_0013;
			}
			int num2 = 5;
			if (MeHVP1hy3wBGUVgAKF() == null)
			{
				break;
			}
			goto IL_235e;
			IL_232b:
			num2 = num;
			goto IL_235e;
			IL_235e:
			while (true)
			{
				switch (num2)
				{
				case 13:
					break;
				case 11:
					goto IL_0013;
				case 8:
					goto IL_0018;
				case 16:
					goto IL_001e;
				case 19:
					object_ = null;
					goto case 2;
				case 2:
					try
					{
						hashAlgorithm = (HashAlgorithm)GwOQndiagZ3hWOk1cZ();
						int num3 = 1;
						if (MeHVP1hy3wBGUVgAKF() == null)
						{
							goto IL_0054;
						}
						goto IL_0087;
						IL_0087:
						switch (num3)
						{
						case 4:
							break;
						default:
							goto IL_006d;
						case 2:
						case 3:
							goto end_IL_0040;
						case 1:
							return;
						}
						goto IL_0054;
						IL_0054:
						object_ = (string)Fe2TUWVVKYGQZlFxoK("SHA1");
						num3 = 0;
						if (!QZt3VysUXxYH0TNuqQ())
						{
							goto IL_006d;
						}
						goto IL_0087;
						IL_006d:
						if (Iu19Tt8H6FFbRviwX1(text))
						{
							num3 = 2;
							if (!QZt3VysUXxYH0TNuqQ())
							{
								num3 = num4;
							}
							goto IL_0087;
						}
						return;
						end_IL_0040:;
					}
					catch
					{
						int num5 = 0;
						if (MeHVP1hy3wBGUVgAKF() != null)
						{
							num5 = num6;
						}
						switch (num5)
						{
						}
						return;
					}
					goto case 17;
				case 17:
					flag = false;
					goto case 18;
				case 18:
					try
					{
						Mc8pUl5GpB1LDt3xfk object_2 = new Mc8pUl5GpB1LDt3xfk((Stream)Up3hMTDIdWODvE2Cav(EFgrLBUndj, "q1byEuoBORIFtgIbh6.Ghf18de5lc8NkIQh2j"));
						int num7 = 19;
						if (MeHVP1hy3wBGUVgAKF() != null)
						{
							goto IL_0153;
						}
						goto IL_1d3f;
						IL_1d3f:
						while (true)
						{
							switch (num7)
							{
							case 343:
								array2[15] = 140;
								num9 = 304;
								goto case 304;
							case 304:
								num12 = 49;
								goto case 78;
							case 78:
								array2[15] = (byte)num12;
								goto case 181;
							case 181:
								object_5 = array2;
								goto case 191;
							case 191:
								object_6 = (SymmetricAlgorithm)ivcFhRnwmMAAIf1uev();
								goto case 36;
							case 36:
								gSE4Jc932umBBUl3DN(object_6, CipherMode.CBC);
								goto case 26;
							case 26:
								transform = (ICryptoTransform)nADINUQ1cC6B2UDpOX(object_6, object_4, object_5);
								num7 = 15;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 342:
								num12 = 132;
								goto case 188;
							case 188:
								array2[11] = (byte)num12;
								goto case 254;
							case 254:
								num12 = 94;
								num7 = 174;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 341:
								array2[6] = 130;
								num7 = 232;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 158;
							case 158:
								num11 = 144;
								num7 = 22;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 340:
								array[29] = 133;
								goto case 294;
							case 294:
								array[29] = 134;
								num9 = 246;
								goto case 246;
							case 246:
								array[29] = 177;
								num7 = 73;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 339:
								num8 = 110;
								goto case 281;
							case 281:
								array[17] = (byte)num8;
								num7 = 94;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 32;
							case 32:
								array[3] = 115;
								num9 = 128;
								goto case 128;
							case 128:
								array[3] = 165;
								goto case 119;
							case 119:
								array[3] = 166;
								num7 = 162;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 17;
							case 17:
								array2[14] = 170;
								goto case 209;
							case 209:
								array2[15] = 115;
								goto case 186;
							case 186:
								array2[15] = 139;
								num7 = 343;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 338:
								num12 = 88;
								goto case 335;
							case 335:
								array2[13] = (byte)num12;
								goto case 288;
							case 288:
								array2[13] = 147;
								goto case 189;
							case 189:
								array2[13] = 144;
								goto case 325;
							case 325:
								num12 = 47;
								num7 = 291;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 337:
								num8 = 229;
								goto case 244;
							case 244:
								array[5] = (byte)num8;
								goto case 102;
							case 102:
								num10 = 156;
								num7 = 101;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 250;
							case 250:
								array[5] = (byte)num10;
								goto case 164;
							case 164:
								num8 = 183;
								num7 = 57;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 112;
							case 112:
								array[5] = (byte)num8;
								goto case 202;
							case 202:
								num8 = 130;
								num7 = 20;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 278;
							case 278:
								array[6] = (byte)num8;
								num7 = 90;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 316;
							case 316:
								array[6] = 115;
								goto case 302;
							case 302:
								array[6] = 145;
								num7 = 255;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 336:
								array[28] = 4;
								goto case 340;
							case 334:
								array[20] = 136;
								num7 = 74;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 333:
								array2[4] = (byte)num12;
								goto case 64;
							case 64:
								array2[4] = 215;
								num7 = 258;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 332:
								num8 = 88;
								num7 = 37;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 24;
							case 24:
								num8 = 108;
								num7 = 110;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 331:
								array[30] = (byte)num8;
								num7 = 41;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 330:
								array[12] = 46;
								num9 = 59;
								goto case 59;
							case 59:
								num10 = 86;
								num7 = 167;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 226;
							case 226:
								array[12] = (byte)num10;
								goto case 86;
							case 86:
								array[12] = 107;
								num9 = 132;
								goto case 132;
							case 132:
								num10 = 117;
								num7 = 87;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 329:
								num10 = 125;
								num9 = 267;
								goto case 267;
							case 267:
								array[25] = (byte)num10;
								goto case 8;
							case 8:
								array[25] = 90;
								num7 = 74;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 101;
							case 101:
								array[25] = 200;
								num7 = 305;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 328:
								num8 = 111;
								goto case 156;
							case 156:
								array[0] = (byte)num8;
								num7 = 196;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 47;
							case 47:
								num12 = 127;
								goto case 293;
							case 293:
								array2[7] = (byte)num12;
								num7 = 198;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 327:
								num10 = 74;
								num7 = 3;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 326:
								num8 = 118;
								goto case 324;
							case 324:
								array[15] = (byte)num8;
								num7 = 200;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 323:
								num8 = 85;
								num9 = 77;
								goto case 77;
							case 77:
								array[14] = (byte)num8;
								goto case 106;
							case 106:
								num8 = 24;
								goto case 109;
							case 109:
								array[14] = (byte)num8;
								num9 = 326;
								goto case 326;
							case 322:
								array[15] = (byte)num10;
								num7 = 256;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 321:
								array2[3] = (byte)num11;
								num9 = 99;
								goto case 99;
							case 99:
								array2[4] = 230;
								goto case 146;
							case 146:
								num12 = 164;
								goto case 333;
							case 320:
								array[24] = 166;
								goto case 21;
							case 21:
								array[24] = 146;
								goto case 177;
							case 177:
								num10 = 42;
								goto case 31;
							case 31:
								array[24] = (byte)num10;
								num7 = 329;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 319:
								array2[6] = 148;
								num7 = 167;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 318:
								array[13] = (byte)num8;
								num9 = 332;
								goto case 332;
							case 317:
								num10 = 155;
								num9 = 65;
								goto case 65;
							case 65:
								array[12] = (byte)num10;
								goto case 230;
							case 230:
								num8 = 132;
								num7 = 318;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 315:
								array2[12] = (byte)num12;
								goto case 290;
							case 290:
								num12 = 85;
								goto case 160;
							case 160:
								array2[12] = (byte)num12;
								num7 = 4;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto default;
							default:
								num11 = 80;
								num9 = 153;
								goto case 153;
							case 153:
								array2[5] = (byte)num11;
								num7 = 205;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 314:
								array[7] = (byte)num8;
								num7 = 187;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 34;
							case 34:
								array[11] = (byte)num10;
								goto case 282;
							case 282:
								array[11] = 12;
								goto case 228;
							case 228:
								num10 = 119;
								num7 = 64;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 185;
							case 185:
								array[12] = (byte)num10;
								goto case 330;
							case 313:
								array[19] = 168;
								goto case 55;
							case 55:
								array[19] = 162;
								num9 = 283;
								goto case 283;
							case 283:
								num10 = 23;
								num7 = 60;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 159;
							case 159:
								array[19] = (byte)num10;
								num7 = 150;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 312:
								num10 = 148;
								goto case 5;
							case 5:
								array[7] = (byte)num10;
								goto case 274;
							case 274:
								num8 = 130;
								num7 = 16;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 311:
								array[30] = (byte)num10;
								goto case 253;
							case 253:
								num8 = 147;
								goto case 331;
							case 310:
								array2[1] = (byte)num12;
								goto case 236;
							case 236:
								array2[1] = 118;
								num7 = 113;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 309:
								array[20] = 111;
								num7 = 334;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 33;
							case 33:
								array2[7] = (byte)num11;
								goto case 307;
							case 307:
								array2[7] = 94;
								num7 = 183;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 245;
							case 245:
								array2[7] = 161;
								num7 = 270;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 308:
								array2[1] = (byte)num11;
								num9 = 241;
								goto case 241;
							case 241:
								array2[2] = 5;
								goto case 104;
							case 104:
								array2[2] = 46;
								goto case 147;
							case 147:
								num12 = 175;
								goto case 54;
							case 54:
								array2[2] = (byte)num12;
								goto case 116;
							case 116:
								array2[3] = 169;
								num7 = 219;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 28;
							case 28:
								array2[9] = 35;
								num7 = 13;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 306:
								num8 = 25;
								goto case 225;
							case 225:
								array[1] = (byte)num8;
								num7 = 154;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 305:
								array[26] = 26;
								goto case 248;
							case 248:
								num10 = 160;
								num9 = 51;
								goto case 51;
							case 51:
								array[26] = (byte)num10;
								num7 = 206;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 268;
							case 268:
								num8 = 85;
								num7 = 124;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 50;
							case 50:
								array2[6] = (byte)num12;
								goto case 201;
							case 201:
								num11 = 96;
								goto case 33;
							case 303:
								array[8] = (byte)num8;
								num9 = 286;
								goto case 286;
							case 286:
								array[8] = 163;
								num7 = 115;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 301:
								num8 = 2;
								goto case 175;
							case 175:
								array[20] = (byte)num8;
								num7 = 11;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 300:
								num10 = 9;
								num7 = 129;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 298:
								array[29] = (byte)num8;
								num7 = 63;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 297:
								array[16] = 90;
								num7 = 80;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 53;
							case 53:
								array[21] = 244;
								num9 = 247;
								goto case 247;
							case 247:
								array[22] = 145;
								goto case 56;
							case 56:
								array[22] = 115;
								num7 = 300;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 296:
								array[26] = (byte)num10;
								goto case 204;
							case 204:
								array[26] = 49;
								goto case 76;
							case 76:
								num8 = 88;
								goto case 10;
							case 10:
								array[27] = (byte)num8;
								num7 = 32;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 35;
							case 35:
								array[27] = 99;
								num7 = 52;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 4;
							case 4:
								num12 = 110;
								num7 = 184;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 24;
							case 295:
								array2[5] = (byte)num11;
								goto case 195;
							case 195:
								num11 = 106;
								goto case 133;
							case 133:
								array2[5] = (byte)num11;
								goto case 221;
							case 221:
								num11 = 186;
								num7 = 135;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 292:
								array[13] = 11;
								num7 = 45;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 291:
								array2[13] = (byte)num12;
								num7 = 40;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 17;
							case 289:
								num12 = 46;
								goto case 61;
							case 61:
								array2[10] = (byte)num12;
								num7 = 62;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 287:
								num11 = 122;
								num7 = 295;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 285:
								num12 = 130;
								num7 = 144;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 284:
								num12 = 113;
								num7 = 233;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 280:
								array[20] = 137;
								goto case 309;
							case 279:
								num10 = 114;
								goto case 155;
							case 155:
								array[0] = (byte)num10;
								goto case 328;
							case 277:
								num10 = 108;
								goto case 275;
							case 275:
								array[28] = (byte)num10;
								num7 = 172;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 272;
							case 272:
								array[28] = 135;
								num7 = 49;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 276:
								object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
								goto case 89;
							case 89:
								D0OgMjmcmfR1jBE9MQ(object_3, array3, 0, array3.Length);
								goto case 111;
							case 111:
								SOHqkuEtdCeYc5P3GL(object_3);
								num7 = 68;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 273:
								array[14] = (byte)num8;
								goto case 323;
							case 271:
								array[8] = 120;
								goto case 216;
							case 216:
								num10 = 96;
								num7 = 107;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 142;
							case 142:
								array[8] = (byte)num10;
								num7 = 20;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 67;
							case 67:
								num8 = 122;
								goto case 303;
							case 270:
								num12 = 193;
								goto case 130;
							case 130:
								array2[7] = (byte)num12;
								num9 = 47;
								goto case 47;
							case 269:
								array2 = new byte[16];
								num9 = 139;
								goto case 139;
							case 139:
								array2[0] = 114;
								goto case 213;
							case 213:
								array2[0] = 105;
								goto case 58;
							case 58:
								num11 = 148;
								num7 = 109;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 123;
							case 123:
								array2[0] = (byte)num11;
								goto case 39;
							case 39:
								num12 = 140;
								num7 = 141;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 266:
								array2[12] = 118;
								goto case 90;
							case 90:
								num11 = 86;
								goto case 9;
							case 9:
								array2[12] = (byte)num11;
								goto case 214;
							case 214:
								num12 = 161;
								goto case 210;
							case 210:
								array2[13] = (byte)num12;
								num7 = 338;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 265:
								num11 = 223;
								goto case 308;
							case 264:
								array[17] = (byte)num8;
								num7 = 176;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 52;
							case 52:
								num10 = 98;
								goto case 152;
							case 152:
								array[27] = (byte)num10;
								goto case 157;
							case 157:
								array[27] = 151;
								num7 = 178;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 183;
							case 183:
								array[27] = 123;
								goto case 211;
							case 211:
								num10 = 90;
								goto case 163;
							case 163:
								array[28] = (byte)num10;
								num7 = 277;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 263:
								array2[8] = (byte)num12;
								goto case 131;
							case 131:
								array2[8] = 137;
								goto case 242;
							case 242:
								num12 = 48;
								goto case 75;
							case 75:
								array2[8] = (byte)num12;
								goto case 206;
							case 206:
								array2[8] = 82;
								num7 = 102;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 158;
							case 262:
								array2[11] = 76;
								goto case 173;
							case 173:
								num11 = 142;
								num7 = 56;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 166;
							case 166:
								array2[12] = (byte)num11;
								goto case 212;
							case 212:
								num12 = 162;
								num7 = 213;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 315;
							case 261:
								array[31] = (byte)num10;
								num7 = 27;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 260:
								array[23] = (byte)num8;
								num7 = 48;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 259:
								num8 = 107;
								num7 = 222;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 173;
							case 258:
								array2[4] = 153;
								goto case 57;
							case 57:
								array2[4] = 209;
								goto case 93;
							case 93:
								array2[5] = 115;
								goto case 218;
							case 218:
								array2[5] = 145;
								goto case 287;
							case 257:
								num10 = 135;
								num7 = 24;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 34;
							case 256:
								array[15] = 94;
								goto case 7;
							case 7:
								num10 = 112;
								num7 = 45;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 98;
							case 98:
								array[16] = (byte)num10;
								num7 = 182;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 255:
								num10 = 122;
								goto case 88;
							case 88:
								array[6] = (byte)num10;
								goto case 136;
							case 136:
								array[6] = 106;
								num9 = 169;
								goto case 169;
							case 169:
								num10 = 34;
								num7 = 238;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 252:
								array2[11] = 148;
								goto case 262;
							case 251:
								num8 = 148;
								goto case 127;
							case 127:
								array[7] = (byte)num8;
								goto case 312;
							case 249:
								array[10] = (byte)num8;
								goto case 43;
							case 43:
								array[10] = 136;
								goto case 38;
							case 38:
								array[10] = 82;
								goto case 70;
							case 70:
								array[10] = 212;
								num7 = 171;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 21;
							case 243:
								num11 = 128;
								num7 = 25;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 18;
							case 18:
								array[23] = (byte)num10;
								goto case 320;
							case 240:
								array2[3] = 105;
								goto case 85;
							case 85:
								num11 = 115;
								num7 = 321;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 239:
								array[3] = (byte)num8;
								goto case 32;
							case 238:
								array[6] = (byte)num10;
								num7 = 138;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 217;
							case 217:
								num10 = 132;
								num7 = 9;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 23;
							case 23:
								array[7] = (byte)num10;
								num7 = 103;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 61;
							case 237:
								array[2] = (byte)num8;
								num7 = 2;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto default;
							case 235:
								array2[6] = (byte)num11;
								goto case 341;
							case 234:
								array2[9] = (byte)num11;
								num7 = 14;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 28;
							case 233:
								array2[1] = (byte)num12;
								goto case 265;
							case 232:
								num12 = 217;
								num9 = 231;
								goto case 231;
							case 231:
								array2[6] = (byte)num12;
								num7 = 48;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 100;
							case 100:
								num12 = 105;
								goto case 50;
							case 229:
								num8 = 114;
								num7 = 239;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 227:
								array[20] = (byte)num10;
								goto case 301;
							case 224:
								num10 = 161;
								num9 = 220;
								goto case 220;
							case 220:
								array[9] = (byte)num10;
								goto case 6;
							case 6:
								array[9] = 45;
								num7 = 6;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 92;
							case 92:
								num8 = 106;
								num7 = 221;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 249;
							case 223:
								num8 = 156;
								goto case 190;
							case 190:
								array[18] = (byte)num8;
								goto case 259;
							case 222:
								array[18] = (byte)num8;
								goto case 114;
							case 114:
								array[18] = 161;
								goto case 71;
							case 71:
								array[19] = 167;
								num9 = 203;
								goto case 203;
							case 203:
								array[19] = 86;
								num9 = 313;
								goto case 313;
							case 219:
								array2[3] = 152;
								goto case 192;
							case 192:
								array2[3] = 165;
								goto case 151;
							case 151:
								array2[3] = 136;
								goto case 240;
							case 215:
								num10 = 49;
								goto case 261;
							case 208:
								array2[1] = (byte)num11;
								goto case 284;
							case 207:
								num8 = 100;
								goto case 95;
							case 95:
								array[2] = (byte)num8;
								goto case 30;
							case 30:
								num10 = 147;
								num7 = 138;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 205:
								num12 = 95;
								num7 = 194;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 200:
								num10 = 126;
								goto case 322;
							case 199:
								num12 = 100;
								num7 = 60;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 198:
								array2[8] = 191;
								goto case 125;
							case 125:
								array2[8] = 106;
								goto case 168;
							case 168:
								num12 = 93;
								num7 = 255;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 263;
							case 197:
								array[0] = (byte)num10;
								num7 = 148;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 196:
								num10 = 209;
								num7 = 197;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 194:
								array2[6] = (byte)num12;
								goto case 319;
							case 193:
								num8 = 144;
								goto case 81;
							case 81:
								array[4] = (byte)num8;
								goto case 121;
							case 121:
								num10 = 76;
								num7 = 178;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 176;
							case 176:
								array[17] = 101;
								num9 = 118;
								goto case 118;
							case 118:
								array[17] = 160;
								goto case 145;
							case 145:
								array[17] = 76;
								goto case 223;
							case 187:
								num8 = 140;
								goto case 96;
							case 96:
								array[7] = (byte)num8;
								goto case 251;
							case 184:
								array2[12] = (byte)num12;
								goto case 266;
							case 182:
								array[16] = 166;
								num7 = 297;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 180:
								array[1] = 176;
								goto case 105;
							case 105:
								array[1] = 118;
								goto case 120;
							case 120:
								num10 = 135;
								goto case 79;
							case 79:
								array[1] = (byte)num10;
								num7 = 149;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 179:
								num11 = 135;
								goto case 234;
							case 178:
								array[4] = (byte)num10;
								num7 = 81;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 97;
							case 97:
								array[5] = 230;
								goto case 337;
							case 174:
								array2[11] = (byte)num12;
								num7 = 252;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 127;
							case 172:
								num12 = 176;
								goto case 310;
							case 171:
								array[11] = 152;
								num7 = 327;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 94;
							case 94:
								num8 = 165;
								num9 = 264;
								goto case 264;
							case 170:
								num10 = 117;
								num7 = 161;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 167:
								num11 = 164;
								goto case 235;
							case 165:
								num10 = 120;
								num7 = 140;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 46;
							case 46:
								array[30] = (byte)num10;
								num7 = 170;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 162:
								array[4] = 128;
								goto case 193;
							case 161:
								array[31] = (byte)num10;
								goto case 215;
							case 154:
								num8 = 98;
								goto case 237;
							case 150:
								num10 = 140;
								goto case 134;
							case 134:
								array[20] = (byte)num10;
								num7 = 280;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 149:
								num8 = 131;
								num7 = 15;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 84;
							case 84:
								array[1] = (byte)num8;
								num9 = 306;
								goto case 306;
							case 148:
								num8 = 218;
								num7 = 126;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 144:
								array2[10] = (byte)num12;
								num7 = 83;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 143:
								num10 = 121;
								num7 = 296;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 141:
								array2[0] = (byte)num12;
								num7 = 172;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 140:
								array[17] = (byte)num10;
								goto case 339;
							case 138:
								array[3] = (byte)num10;
								goto case 229;
							case 137:
								object_4 = array;
								num7 = 269;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 135:
								array2[5] = (byte)num11;
								num7 = 0;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 129:
								array[22] = (byte)num10;
								num7 = 72;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 126:
								array[0] = (byte)num8;
								goto case 180;
							case 124:
								array[26] = (byte)num8;
								goto case 143;
							case 122:
								array[21] = 63;
								num7 = 53;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 117:
								array[2] = (byte)num8;
								goto case 207;
							case 115:
								array[9] = 161;
								num9 = 20;
								goto case 20;
							case 20:
								array[9] = 193;
								num7 = 24;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 113:
								num11 = 113;
								goto case 208;
							case 110:
								array[9] = (byte)num8;
								goto case 224;
							case 108:
								array = new byte[32];
								num7 = 279;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 125;
							case 107:
								num8 = 160;
								num7 = 260;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 103:
								num8 = 126;
								goto case 314;
							case 87:
								array[12] = (byte)num10;
								goto case 317;
							case 83:
								array2[11] = 130;
								num7 = 47;
								if (!QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 243;
							case 82:
								array2[10] = (byte)num11;
								goto case 285;
							case 80:
								array[16] = 48;
								num7 = 165;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 74:
								num10 = 138;
								goto case 227;
							case 73:
								num8 = 52;
								goto case 298;
							case 72:
								array[23] = 17;
								goto case 107;
							case 69:
								array[21] = (byte)num8;
								num7 = 122;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 68:
								iV7MymBoKMvkt6l4Tt(gKqrnR86yQ, KufEFcgLK91AKDOxOM(LCHr5Mr3kMUbSBJYUJ(), AFXmXD12Tvgx2Kc8q8(stream)));
								num7 = 29;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 66:
								array3 = (byte[])tqoDfNXrFkLn86k40S(object_2, (int)bK6662tmCAmNtKIJZR(eiOdEwo3UrLXLmDpy8(object_2)));
								goto case 108;
							case 63:
								array[30] = 112;
								num7 = 1;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 1;
							case 1:
								num10 = 104;
								num7 = 311;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 62:
								num11 = 120;
								num7 = 82;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 60:
								array2[9] = (byte)num12;
								num7 = 179;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 49:
								array[28] = 135;
								num7 = 336;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								goto case 35;
							case 48:
								num10 = 172;
								goto case 18;
							case 45:
								array[14] = 145;
								num7 = 12;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 42:
								array2[14] = 157;
								goto case 17;
							case 41:
								num10 = 180;
								num7 = 46;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 40:
								array2[14] = 120;
								goto case 42;
							case 37:
								array[13] = (byte)num8;
								num7 = 292;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								break;
							case 27:
								array[31] = 253;
								num7 = 137;
								if (MeHVP1hy3wBGUVgAKF() == null)
								{
									continue;
								}
								goto case 32;
							case 25:
								array2[11] = (byte)num11;
								goto case 342;
							case 22:
								array2[9] = (byte)num11;
								goto case 199;
							case 19:
								IOrKPC7Inv9GJpnrMu(eiOdEwo3UrLXLmDpy8(object_2), 0L);
								num7 = 66;
								if (QZt3VysUXxYH0TNuqQ())
								{
									continue;
								}
								break;
							case 16:
								array[8] = (byte)num8;
								num9 = 14;
								goto case 14;
							case 14:
								array[8] = 217;
								goto case 271;
							case 15:
								stream = (Stream)Uin1YtKuHsgbZN7dCY();
								goto case 276;
							case 13:
								array2[10] = 119;
								goto case 289;
							case 12:
								num8 = 128;
								goto case 273;
							case 11:
								num8 = 111;
								num7 = 50;
								if (MeHVP1hy3wBGUVgAKF() != null)
								{
									continue;
								}
								goto case 69;
							case 3:
								array[11] = (byte)num10;
								goto case 257;
							case 2:
								num8 = 75;
								num9 = 117;
								goto case 117;
							case 29:
								icKLIqAYqJdf74M538(stream);
								goto case 299;
							case 299:
								icKLIqAYqJdf74M538(object_3);
								goto case 91;
							case 91:
								IQyBqLaU1Vnw2fGnAX(object_2);
								goto end_IL_1d3f;
							case 44:
								goto end_IL_1d3f;
							}
							goto IL_0153;
							continue;
							end_IL_1d3f:
							break;
						}
						goto end_IL_00cd;
						IL_0153:
						num7 = num9;
						goto IL_1d3f;
						end_IL_00cd:;
					}
					catch
					{
						int num13 = 1;
						if (!QZt3VysUXxYH0TNuqQ())
						{
							num13 = num14;
						}
						while (true)
						{
							switch (num13)
							{
							case 1:
								flag = true;
								num13 = 0;
								if (MeHVP1hy3wBGUVgAKF() == null)
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
					goto case 4;
				case 10:
					hashAlgorithm = null;
					goto case 19;
				case 7:
					if (WICUxBumQWWOavwIrH(text) == 0)
					{
						return;
					}
					goto IL_231e;
				case 5:
					if (text == null)
					{
						num2 = 0;
						if (!QZt3VysUXxYH0TNuqQ())
						{
							continue;
						}
						return;
					}
					goto case 7;
				case 3:
					text = (string)HWu3ws5sQEg6qrFymL(vnNnIKTlJhr0nupeKk(typeof(awYSQNJbxdPDQ9b5BH).TypeHandle).Assembly);
					goto case 5;
				default:
					return;
				case 4:
					if (!flag)
					{
						num2 = 0;
						if (MeHVP1hy3wBGUVgAKF() != null)
						{
							continue;
						}
						goto case 1;
					}
					goto case 15;
				case 0:
				case 14:
					return;
				case 1:
					try
					{
						FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
						int num15 = 58;
						while (true)
						{
							IL_29ec:
							BinaryReader object_7 = new BinaryReader(fileStream);
							int num16 = 34;
							if (MeHVP1hy3wBGUVgAKF() == null)
							{
								goto IL_26d4;
							}
							goto IL_28b9;
							IL_28b9:
							while (true)
							{
								switch (num16)
								{
								case 74:
									IOrKPC7Inv9GJpnrMu(fileStream, long_);
									goto case 45;
								case 45:
									num27 = 0;
									goto case 17;
								case 10:
								case 55:
									IOrKPC7Inv9GJpnrMu(fileStream, num22 + num27 * 40 + 16L);
									num16 = 68;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto case 17;
								case 17:
								case 18:
									if (num27 < num23)
									{
										num15 = 10;
										goto case 10;
									}
									goto case 19;
								case 19:
									lkevfrpGtYpRFWywLI(hashAlgorithm, new byte[0], 0, 0);
									goto case 13;
								case 13:
									IOrKPC7Inv9GJpnrMu(fileStream, num24);
									num15 = 72;
									goto case 72;
								case 72:
									array5 = (byte[])FMnZWKU2ONm3HAYs2m(object_7, (int)num20);
									num16 = 28;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto IL_2481;
								case 73:
									break;
								case 15:
									goto IL_2490;
								case 12:
									goto IL_2496;
								case 71:
									array4[38] = 0;
									goto case 64;
								case 64:
									array4[39] = 0;
									goto case 30;
								case 30:
									BJAYRSkH7LbKhYAR79(hashAlgorithm, array4, 0, 128);
									num16 = 40;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto IL_2481;
								case 6:
								case 70:
									uint_2 = xd71Hux1NmEpoI4QsV(object_7);
									num16 = 41;
									if (MeHVP1hy3wBGUVgAKF() != null)
									{
										continue;
									}
									goto case 50;
								case 50:
									num28 = LTtydB0uEMpfVN6GgF(uint_2, num23, num22, object_7);
									goto case 9;
								case 9:
									IOrKPC7Inv9GJpnrMu(fileStream, num28 + 32);
									num16 = 33;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto IL_2481;
								case 69:
									if (num24 <= num26)
									{
										goto case 32;
									}
									goto case 48;
								case 63:
									ARQGtOF07n89sWtoI6(hashAlgorithm, fileStream, num18, array4);
									num16 = 62;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto case 42;
								case 42:
									num26 = kU1pHqPtTEUvRKC4RU(fileStream);
									goto case 69;
								case 32:
									if (num26 >= num25)
									{
										goto case 48;
									}
									goto case 51;
								case 48:
								case 52:
									if (num26 >= num25)
									{
										goto case 63;
									}
									num16 = 65;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto case 42;
								case 51:
									num21 = (uint)(num25 - num26);
									num16 = 35;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto case 7;
								case 7:
									IOrKPC7Inv9GJpnrMu(fileStream, 134L);
									goto case 54;
								case 54:
									num23 = bgfeZEWNnR5Hom43XY(object_7);
									num15 = 25;
									goto case 25;
								case 25:
									IOrKPC7Inv9GJpnrMu(fileStream, num22);
									num15 = 53;
									goto case 53;
								case 53:
									ARQGtOF07n89sWtoI6(hashAlgorithm, fileStream, (uint)(num23 * 40), array4);
									goto case 66;
								case 66:
									long_ = kU1pHqPtTEUvRKC4RU(fileStream);
									goto case 47;
								case 47:
									if (!flag2)
									{
										num16 = 5;
										if (MeHVP1hy3wBGUVgAKF() == null)
										{
											continue;
										}
										goto IL_2481;
									}
									goto case 37;
								case 37:
									IOrKPC7Inv9GJpnrMu(fileStream, 360L);
									num16 = 6;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto IL_2481;
								case 68:
									num18 = xd71Hux1NmEpoI4QsV(object_7);
									num16 = 1;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto end_IL_29ec;
								case 67:
									goto IL_2635;
								case 23:
								case 65:
									num19 = (uint)HxaXhGYqr0HAB1Q8dt(num24 - num26, num18);
									goto case 4;
								case 4:
									ARQGtOF07n89sWtoI6(hashAlgorithm, fileStream, num19, array4);
									num16 = 26;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto case 2;
								case 2:
								case 36:
								case 38:
									if (num18 != 0)
									{
										goto case 42;
									}
									goto case 60;
								case 60:
								case 62:
									num27++;
									goto case 17;
								case 61:
									goto IL_2687;
								case 46:
									goto IL_2697;
								case 31:
									goto IL_26aa;
								case 24:
									goto IL_26ae;
								case 39:
									goto IL_26bf;
								case 59:
									goto IL_26d4;
								case 57:
									flag = !B2Afab2BDKqaYpDQee(gKqrnR86yQ, djA5dsq9fdqaY2VKp3(hashAlgorithm), object_, array5);
									num16 = 0;
									if (MeHVP1hy3wBGUVgAKF() != null)
									{
										continue;
									}
									goto end_IL_29ec;
								case 56:
									array4[35] = 0;
									num16 = 34;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto IL_2481;
								case 49:
									array4[32] = 0;
									num16 = 14;
									if (MeHVP1hy3wBGUVgAKF() != null)
									{
										continue;
									}
									goto case 21;
								case 21:
									array4[33] = 0;
									goto case 11;
								case 11:
									array4[34] = 0;
									num16 = 56;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto IL_26ae;
								case 5:
								case 44:
									IOrKPC7Inv9GJpnrMu(fileStream, 376L);
									goto case 6;
								case 43:
									num24 = LTtydB0uEMpfVN6GgF(uint_, num23, num22, object_7);
									goto case 22;
								case 22:
									num25 = num24 + num20;
									goto case 74;
								case 41:
									IOrKPC7Inv9GJpnrMu(fileStream, kU1pHqPtTEUvRKC4RU(fileStream) + num21);
									goto case 2;
								case 40:
									num22 = kU1pHqPtTEUvRKC4RU(fileStream);
									goto case 7;
								case 35:
									if (num21 >= num18)
									{
										goto case 60;
									}
									goto case 3;
								case 3:
									num18 -= num21;
									num16 = 0;
									if (MeHVP1hy3wBGUVgAKF() != null)
									{
										continue;
									}
									goto case 41;
								case 34:
									array4[36] = 0;
									num15 = 8;
									goto case 8;
								case 8:
									array4[37] = 0;
									num16 = 71;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto IL_2481;
								case 33:
									uint_ = xd71Hux1NmEpoI4QsV(object_7);
									goto case 16;
								case 16:
									num20 = xd71Hux1NmEpoI4QsV(object_7);
									num16 = 43;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto IL_2481;
								case 29:
									BJAYRSkH7LbKhYAR79(hashAlgorithm, array4, 0, int_);
									goto case 20;
								case 20:
									w6gGrPNFZTtKc5eXAu(fileStream, array4, 0, 128);
									goto case 49;
								case 28:
									dyiMmylEJyiWUibn7P(array5);
									num16 = 57;
									if (QZt3VysUXxYH0TNuqQ())
									{
										continue;
									}
									goto case 9;
								case 27:
									IOrKPC7Inv9GJpnrMu(fileStream, num17);
									goto case 2;
								case 26:
									num18 -= num19;
									num16 = 2;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto IL_2481;
								case 14:
									array4[67] = 0;
									num15 = 29;
									goto case 29;
								case 1:
									num17 = xd71Hux1NmEpoI4QsV(object_7);
									num16 = 27;
									if (MeHVP1hy3wBGUVgAKF() == null)
									{
										continue;
									}
									goto IL_2481;
								default:
									goto end_IL_29ec;
								case 58:
									goto IL_29ec;
								case 0:
									goto end_IL_29ec;
								}
								break;
							}
							goto IL_248a;
							IL_26d4:
							array4 = new byte[65536];
							goto IL_2687;
							IL_2687:
							ARQGtOF07n89sWtoI6(hashAlgorithm, fileStream, 152u, array4);
							goto IL_2697;
							IL_2697:
							flag2 = bgfeZEWNnR5Hom43XY(object_7) != 523;
							goto IL_26aa;
							IL_26aa:
							if (!flag2)
							{
								goto IL_26ae;
							}
							int num29 = 96;
							goto IL_26b4;
							IL_26ae:
							num29 = 112;
							goto IL_26b4;
							IL_2481:
							num16 = num15;
							goto IL_28b9;
							IL_26b4:
							int_ = num29;
							num15 = 39;
							goto IL_26bf;
							IL_26bf:
							IOrKPC7Inv9GJpnrMu(fileStream, 152L);
							goto IL_2635;
							IL_2635:
							w6gGrPNFZTtKc5eXAu(fileStream, array4, 0, int_);
							goto IL_248a;
							IL_248a:
							array4[64] = 0;
							goto IL_2490;
							IL_2490:
							array4[65] = 0;
							goto IL_2496;
							IL_2496:
							array4[66] = 0;
							num16 = 14;
							if (!QZt3VysUXxYH0TNuqQ())
							{
								goto IL_2481;
							}
							goto IL_28b9;
							continue;
							end_IL_29ec:
							break;
						}
					}
					catch
					{
						int num30 = 0;
						if (QZt3VysUXxYH0TNuqQ())
						{
							goto IL_2a1e;
						}
						goto IL_2a32;
						IL_2a32:
						switch (num30)
						{
						case 1:
							break;
						default:
							goto end_IL_2a10;
						}
						goto IL_2a1e;
						IL_2a1e:
						flag = true;
						num30 = 0;
						if (!QZt3VysUXxYH0TNuqQ())
						{
							num30 = num31;
						}
						goto IL_2a32;
						end_IL_2a10:;
					}
					goto case 15;
				case 15:
					if (!flag)
					{
						goto case 6;
					}
					goto case 9;
				case 6:
					flag = false;
					return;
				case 9:
					throw new Exception((string?)mSIPts4yL5OrBX8VlG(oDvb4CbbsbEoEb7M4x(AELutXSLnspxs0Wc53(vnNnIKTlJhr0nupeKk(typeof(awYSQNJbxdPDQ9b5BH).TypeHandle).Assembly)), " is tampered."));
				case 12:
				case 20:
					return;
				}
				break;
				IL_231e:
				num2 = 10;
				if (QZt3VysUXxYH0TNuqQ())
				{
					continue;
				}
				goto IL_232b;
			}
			continue;
			IL_0013:
			TQMpg9LJcq1X85JbgX();
			goto IL_0018;
			IL_0018:
			n5WebgCoMpDyZwKitR(bool_0: true);
			goto IL_001e;
			IL_001e:
			gKqrnR86yQ = new RSACryptoServiceProvider();
			num2 = 3;
			if (MeHVP1hy3wBGUVgAKF() != null)
			{
				goto IL_232b;
			}
			goto IL_235e;
		}
	}

	public static void nLd3GQQS3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (TbDrOu93fa == null)
			{
				lock (cYLrxARGya)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554450)).Assembly.GetManifestResourceStream("SKoE418YeKOa7u6QEn.BU0b6XT79Ji7Dhkmem"));
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
							num10 ^= num10 << 7;
							num10 += 252757333;
							num10 ^= num10 << 25;
							num10 += 775711184;
							num10 ^= num10 >> 1;
							num10 += 2615063369u;
							num10 = 678931976 + num10;
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
						Mc8pUl5GpB1LDt3xfk mc8pUl5GpB1LDt3xfk = new Mc8pUl5GpB1LDt3xfk(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = mc8pUl5GpB1LDt3xfk.YBi6YXmhbE();
							int value = mc8pUl5GpB1LDt3xfk.YBi6YXmhbE();
							dictionary.Add(key, value);
						}
						mc8pUl5GpB1LDt3xfk.B8M6joGr6C();
					}
					TbDrOu93fa = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num14 = TbDrOu93fa[metadataToken];
				bool flag = (num14 & 0x40000000) > 0;
				num14 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554450)).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(16777232));
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

	private static uint wVsUAG8Lb(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	internal static void j9QW3pmTf()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
	internal static string vb0hJkAt6(int int_0)
	{
		int num = 30;
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array = default(byte[]);
		int num6 = default(int);
		byte[] array4 = default(byte[]);
		int num5 = default(int);
		int num4 = default(int);
		uint num10 = default(uint);
		byte[] array5 = default(byte[]);
		int num22 = default(int);
		int num21 = default(int);
		byte[] array7 = default(byte[]);
		int num3 = default(int);
		int num12 = default(int);
		SymmetricAlgorithm object_2 = default(SymmetricAlgorithm);
		int num9 = default(int);
		uint num24 = default(uint);
		int num20 = default(int);
		int num7 = default(int);
		int num17 = default(int);
		byte[] array6 = default(byte[]);
		uint num19 = default(uint);
		uint num18 = default(uint);
		int num11 = default(int);
		uint num13 = default(uint);
		int num14 = default(int);
		uint num23 = default(uint);
		uint num16 = default(uint);
		uint num8 = default(uint);
		CryptoStream object_3 = default(CryptoStream);
		int num15 = default(int);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		int int_ = default(int);
		int num28 = default(int);
		string result = default(string);
		int num30 = default(int);
		while (true)
		{
			if (RnXr5UVZkE.Length == 0)
			{
				while (true)
				{
					Mc8pUl5GpB1LDt3xfk object_ = new Mc8pUl5GpB1LDt3xfk((Stream)qMAdlm61gqsKhj9erT(EFgrLBUndj, "dOPgVEZ3mqa0u9OHIC.SkVfdZNIZ1fDTRl3PL"));
					while (true)
					{
						zZdkKOrYGVhO9Ff14k(zaCNcDwIlIUmROVIOY(object_), 0L);
						int num2 = 17;
						if (!nhvvFkW9mGSbYIAbJ6())
						{
							goto IL_0024;
						}
						goto IL_2453;
						IL_2453:
						while (true)
						{
							switch (num2)
							{
							case 449:
								break;
							case 448:
								array2[13] = array3[6];
								goto case 328;
							case 328:
								array2[15] = array3[7];
								num2 = 191;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 447:
								array[23] = (byte)num6;
								goto case 210;
							case 210:
								array[23] = 144;
								num2 = 137;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 446:
								array[16] = 176;
								goto case 41;
							case 41:
								num6 = 80;
								goto case 193;
							case 193:
								array[17] = (byte)num6;
								num = 319;
								goto case 319;
							case 319:
								array[17] = 182;
								num2 = 189;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 445:
								array[15] = 19;
								num2 = 40;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 7;
							case 7:
								array[12] = 102;
								num2 = 357;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 444:
								array4[1] = (byte)num5;
								num2 = 165;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 286;
							case 286:
								num5 = 187;
								num2 = 173;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 352;
							case 352:
								array4[1] = (byte)num5;
								num2 = 0;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto default;
							default:
								array4[1] = 150;
								goto case 194;
							case 194:
								array4[1] = 163;
								goto case 243;
							case 243:
								num5 = 131;
								num2 = 262;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 443:
								array[11] = 142;
								num = 5;
								goto case 5;
							case 5:
								num4 = 249;
								num = 121;
								goto case 121;
							case 121:
								array[11] = (byte)num4;
								num2 = 7;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto default;
							case 442:
								num10 <<= 8;
								num2 = 166;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 129;
							case 129:
								num4 = 57;
								num2 = 165;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 58;
							case 58:
								array4[9] = 57;
								num2 = 19;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 104;
							case 104:
								array4[10] = 127;
								num2 = 108;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 35;
							case 35:
								array[12] = 134;
								num = 289;
								goto case 289;
							case 289:
								array[12] = 127;
								goto case 284;
							case 284:
								num4 = 145;
								goto case 186;
							case 186:
								array[12] = (byte)num4;
								goto case 244;
							case 244:
								array[13] = 210;
								num2 = 407;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 441:
								array[30] = 228;
								goto case 89;
							case 89:
								num4 = 52;
								goto case 207;
							case 207:
								array[30] = (byte)num4;
								num2 = 242;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 389;
							case 389:
								num6 = 117;
								goto case 208;
							case 208:
								array[31] = (byte)num6;
								goto case 424;
							case 424:
								num4 = 153;
								goto case 343;
							case 343:
								array[31] = (byte)num4;
								goto case 176;
							case 176:
								array[31] = 127;
								num2 = 24;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 48;
							case 48:
								array[31] = 106;
								num = 440;
								goto case 440;
							case 440:
								array[31] = 160;
								num2 = 304;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 439:
								array[15] = 119;
								num2 = 445;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 369;
							case 369:
								array[6] = (byte)num4;
								num = 293;
								goto case 293;
							case 293:
								array[6] = 107;
								goto case 278;
							case 278:
								array[7] = 85;
								goto case 100;
							case 100:
								num4 = 141;
								num2 = 60;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 438:
								num6 = 148;
								num = 340;
								goto case 340;
							case 340:
								array[20] = (byte)num6;
								num2 = 386;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 310;
							case 310:
								array5 = RnXr5UVZkE;
								num2 = 125;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 142;
							case 142:
								num22 = array5.Length % 4;
								goto case 268;
							case 268:
								num21 = array5.Length / 4;
								goto case 22;
							case 22:
								array7 = new byte[array5.Length];
								num2 = 298;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 437:
								if (array3.Length > 0)
								{
									num2 = 23;
									if (EZJuicCKvDEtHrVggB() == null)
									{
										continue;
									}
									goto case 20;
								}
								goto case 191;
							case 20:
								num3 = 141;
								goto case 152;
							case 152:
								array4[5] = (byte)num3;
								num = 119;
								goto case 119;
							case 119:
								array4[5] = 106;
								goto case 365;
							case 365:
								num5 = 138;
								num2 = 356;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 115;
							case 115:
								num5 = 166;
								num2 = 149;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 191:
							case 223:
								num12 = 0;
								goto case 73;
							case 73:
							case 232:
								if (num12 >= array2.Length)
								{
									goto case 367;
								}
								goto case 337;
							case 367:
								if (int_0 != -1)
								{
									goto case 142;
								}
								num = 394;
								goto case 394;
							case 394:
								object_2 = (SymmetricAlgorithm)b9qJIMBlIEPIomBOrv();
								num2 = 14;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 3;
							case 3:
								array7[num9 + 2] = (byte)((num24 & 0xFF0000) >> 16);
								goto case 326;
							case 326:
								array7[num9 + 3] = (byte)((num24 & 0xFF000000u) >> 24);
								goto case 145;
							case 145:
							case 273:
								num20++;
								goto case 248;
							case 248:
							case 318:
								if (num20 < num21)
								{
									goto case 390;
								}
								goto case 72;
							case 390:
								num7 = num20 % num17;
								goto case 313;
							case 313:
								num9 = num20 * 4;
								num2 = 85;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 56;
							case 56:
								array4[9] = (byte)num3;
								num2 = 58;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 337:
								array6[num12] = (byte)(array6[num12] ^ array2[num12]);
								num2 = 127;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 109;
							case 109:
								num3 = 124;
								goto case 132;
							case 132:
								array4[3] = (byte)num3;
								goto case 434;
							case 434:
								array4[3] = 132;
								num2 = 102;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 430;
							case 430:
								num5 = 134;
								num2 = 297;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 436:
								num4 = 34;
								num2 = 108;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 369;
							case 373:
							case 435:
								num19 = num18;
								num2 = 9;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 6;
							case 6:
								array[20] = 124;
								goto case 236;
							case 236:
								num4 = 131;
								goto case 364;
							case 364:
								array[20] = (byte)num4;
								goto case 107;
							case 107:
								array[20] = 39;
								goto case 188;
							case 188:
								num4 = 152;
								num2 = 160;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 433:
								array[6] = (byte)num4;
								num2 = 237;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 432:
								num6 = 136;
								goto case 425;
							case 425:
								array[19] = (byte)num6;
								goto case 198;
							case 198:
								array[19] = 134;
								num2 = 301;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 372;
							case 372:
								num6 = 75;
								num2 = 22;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 54;
							case 54:
								array[19] = (byte)num6;
								goto case 323;
							case 323:
								num6 = 195;
								goto case 303;
							case 303:
								array[19] = (byte)num6;
								goto case 438;
							case 431:
								num6 = 230;
								goto case 227;
							case 227:
								array[7] = (byte)num6;
								goto case 68;
							case 68:
								array[8] = 83;
								num = 138;
								goto case 138;
							case 138:
								num4 = 90;
								num2 = 419;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 124;
							case 124:
								array4 = new byte[16];
								num = 410;
								goto case 410;
							case 410:
								num3 = 180;
								goto case 168;
							case 168:
								array4[0] = (byte)num3;
								num = 353;
								goto case 353;
							case 353:
								array4[0] = 126;
								num2 = 311;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 327;
							case 327:
								num3 = 128;
								num2 = 117;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 429:
								num3 = 56;
								goto case 392;
							case 392:
								array4[14] = (byte)num3;
								num2 = 342;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 428:
							{
								uint num25 = num19;
								uint num26 = num19;
								num26 ^= num26 << 7;
								num26 += 252757333;
								num26 ^= num26 << 25;
								num26 += 775711184;
								num26 ^= num26 >> 1;
								num26 += 2615063369u;
								num26 = 678931976 + num26;
								num19 = num25 + (uint)(double)num26;
								num2 = 302;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							}
							case 427:
								array3 = (byte[])Ugs4JEiiAP4ef9jF3f(tc3PBMZQNCofeSeDDt(EFgrLBUndj));
								num2 = 103;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 112;
							case 112:
								if (array3 == null)
								{
									num2 = 223;
									if (nhvvFkW9mGSbYIAbJ6())
									{
										continue;
									}
									goto IL_0024;
								}
								goto case 437;
							case 426:
								num4 = 9;
								num2 = 146;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 423:
								array4[12] = (byte)num5;
								goto case 75;
							case 75:
								array4[12] = 93;
								num2 = 397;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 422:
								array[0] = 126;
								goto case 426;
							case 421:
								num5 = 92;
								num2 = 178;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 420:
								array4[11] = (byte)num5;
								goto case 301;
							case 301:
								num5 = 72;
								goto case 370;
							case 370:
								array4[11] = (byte)num5;
								num2 = 306;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 419:
								array[8] = (byte)num4;
								goto case 376;
							case 376:
								array[8] = 86;
								num2 = 228;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 418:
								num3 = 156;
								goto case 335;
							case 335:
								array4[4] = (byte)num3;
								goto case 260;
							case 260:
								num3 = 116;
								goto case 261;
							case 261:
								array4[4] = (byte)num3;
								num = 217;
								goto case 217;
							case 217:
								num3 = 140;
								num2 = 253;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 417:
								array[13] = (byte)num6;
								num2 = 0;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 26;
							case 26:
								num6 = 84;
								num = 87;
								goto case 87;
							case 87:
								array[13] = (byte)num6;
								num2 = 80;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 416:
								array[23] = (byte)num6;
								num2 = 241;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 415:
								num3 = 157;
								goto case 368;
							case 368:
								array4[11] = (byte)num3;
								goto case 154;
							case 154:
								num5 = 63;
								goto case 358;
							case 358:
								array4[11] = (byte)num5;
								num2 = 71;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 414:
								array4[4] = (byte)num5;
								num = 421;
								goto case 421;
							case 330:
								if (num11 > 0)
								{
									goto case 102;
								}
								goto case 238;
							case 102:
								num13 <<= 8;
								goto case 211;
							case 211:
								num14 += 8;
								goto case 238;
							case 238:
								array7[num9 + num11] = (byte)((num23 & num13) >> num14);
								goto case 225;
							case 225:
								num11++;
								goto case 196;
							case 196:
							case 413:
								if (num11 >= num22)
								{
									goto case 145;
								}
								goto case 330;
							case 412:
								array4[7] = 90;
								num2 = 354;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 411:
								array[8] = (byte)num6;
								num2 = 92;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 51;
							case 51:
								num16 = 0u;
								goto case 215;
							case 215:
								num10 = 0u;
								goto case 153;
							case 153:
								if (num22 > 0)
								{
									num2 = 449;
									if (EZJuicCKvDEtHrVggB() == null)
									{
										continue;
									}
									goto IL_0024;
								}
								goto case 97;
							case 97:
								num8 = 0u;
								num2 = 375;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 352;
							case 408:
								num6 = 168;
								goto case 38;
							case 38:
								array[3] = (byte)num6;
								num2 = 250;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 215;
							case 407:
								array[13] = 138;
								num2 = 402;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 406:
								array[15] = (byte)num4;
								num2 = 174;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 439;
							case 405:
								num6 = 88;
								num2 = 31;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 404:
								num3 = 169;
								num2 = 331;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 403:
								array[11] = 132;
								goto case 443;
							case 402:
								num6 = 116;
								num2 = 22;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 86;
							case 86:
								array[13] = (byte)num6;
								goto case 338;
							case 338:
								num6 = 230;
								goto case 417;
							case 401:
								array[28] = (byte)num4;
								num2 = 147;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 400:
								array2[7] = array3[3];
								num2 = 116;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 399:
								array[5] = 67;
								num2 = 122;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 161;
							case 161:
								array[5] = 85;
								goto case 341;
							case 341:
								num6 = 97;
								num2 = 47;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 28;
							case 28:
								num5 = 242;
								goto case 414;
							case 398:
								array2 = array4;
								goto case 312;
							case 312:
								JfP1DOxMNgDG18LiJs(array2);
								num2 = 427;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 397:
								num3 = 116;
								goto case 192;
							case 192:
								array4[12] = (byte)num3;
								num2 = 253;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 279;
							case 279:
								array4[12] = 230;
								num2 = 255;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 396:
								array[14] = 72;
								goto case 99;
							case 99:
								num4 = 9;
								num = 406;
								goto case 406;
							case 395:
								array[10] = 74;
								num2 = 403;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 393:
								num6 = 138;
								num2 = 184;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 391:
								array[18] = (byte)num6;
								goto case 393;
							case 388:
								AwIMyRlsPW7ghScHhY(object_3);
								num2 = 114;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 110;
							case 110:
								num4 = 152;
								num2 = 148;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 387:
								num18 += num16;
								goto case 380;
							case 380:
								num15 = 0;
								goto case 27;
							case 27:
							case 70:
								if (num15 >= num22)
								{
									goto case 373;
								}
								goto case 362;
							case 362:
								if (num15 > 0)
								{
									num = 442;
									goto case 442;
								}
								goto case 166;
							case 166:
								num10 |= array5[^(1 + num15)];
								num2 = 256;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 386:
								num6 = 160;
								num2 = 56;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 66;
							case 66:
								array[20] = (byte)num6;
								goto case 6;
							case 385:
								array[4] = 115;
								num2 = 288;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 384:
								array[19] = 223;
								num2 = 78;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 383:
								array[4] = 57;
								goto case 167;
							case 167:
								array[4] = 75;
								goto case 399;
							case 382:
								if (num22 > 0)
								{
									goto case 320;
								}
								goto case 123;
							case 320:
								num10 = 0u;
								goto case 387;
							case 123:
								num18 += num16;
								num2 = 12;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 381:
								array4[15] = (byte)num5;
								goto case 398;
							case 379:
								array[3] = (byte)num4;
								num2 = 180;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 378:
								array[1] = (byte)num6;
								goto case 129;
							case 377:
								array4[2] = (byte)num5;
								goto case 305;
							case 305:
								array4[2] = 132;
								goto case 109;
							case 375:
								num20 = 0;
								num2 = 23;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 248;
							case 374:
								num4 = 167;
								num2 = 379;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 371:
								array[24] = 97;
								goto case 10;
							case 10:
								array[24] = 113;
								goto case 258;
							case 258:
								num6 = 119;
								goto case 291;
							case 291:
								array[24] = (byte)num6;
								goto case 33;
							case 33:
								array[24] = 97;
								goto case 126;
							case 126:
								array[24] = 51;
								num2 = 164;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 42;
							case 42:
								array[26] = 144;
								num2 = 181;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 363:
								num4 = 69;
								goto case 348;
							case 348:
								array[27] = (byte)num4;
								goto case 251;
							case 251:
								num6 = 33;
								num2 = 216;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 332;
							case 332:
								array[27] = (byte)num6;
								num = 334;
								goto case 334;
							case 334:
								num4 = 106;
								num2 = 401;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 361:
								array2[3] = array3[1];
								goto case 156;
							case 156:
								array2[5] = array3[2];
								goto case 400;
							case 360:
								if (num20 == num21 - 1)
								{
									num2 = 382;
									if (EZJuicCKvDEtHrVggB() == null)
									{
										continue;
									}
									goto IL_0024;
								}
								goto case 123;
							case 359:
								num6 = 163;
								num = 265;
								goto case 265;
							case 265:
								array[2] = (byte)num6;
								num2 = 76;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 357:
								array[12] = 167;
								num2 = 12;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 35;
							case 356:
								array4[5] = (byte)num5;
								num2 = 82;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 355:
								array4[5] = (byte)num5;
								goto case 57;
							case 57:
								num5 = 86;
								num2 = 214;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 354:
								num5 = 63;
								num2 = 61;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 351:
								array4[7] = 196;
								num2 = 412;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 125;
							case 125:
								array[25] = (byte)num6;
								num2 = 38;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 42;
							case 350:
								array[29] = (byte)num4;
								num2 = 1;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 4;
							case 4:
								num4 = 8;
								num2 = 106;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 349:
								num3 = 22;
								goto case 63;
							case 63:
								array4[13] = (byte)num3;
								goto case 36;
							case 36:
								num5 = 105;
								goto case 322;
							case 322:
								array4[14] = (byte)num5;
								goto case 185;
							case 185:
								num5 = 215;
								num2 = 267;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 230;
							case 230:
								num6 = 154;
								goto case 62;
							case 62:
								array[21] = (byte)num6;
								goto case 170;
							case 170:
								array[21] = 213;
								num2 = 5;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 110;
							case 347:
								array[14] = (byte)num4;
								goto case 299;
							case 299:
								num6 = 99;
								goto case 140;
							case 140:
								array[14] = (byte)num6;
								num2 = 39;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 9;
							case 9:
								num18 = 0u;
								num2 = 428;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 346:
								num24 = num18 ^ num10;
								num = 249;
								goto case 249;
							case 249:
								array7[num9] = (byte)(num24 & 0xFFu);
								goto case 157;
							case 157:
								array7[num9 + 1] = (byte)((num24 & 0xFF00) >> 8);
								goto case 3;
							case 345:
								num4 = 135;
								goto case 43;
							case 43:
								array[27] = (byte)num4;
								num2 = 83;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 344:
								array[14] = (byte)num6;
								goto case 396;
							case 342:
								num3 = 121;
								goto case 276;
							case 276:
								array4[15] = (byte)num3;
								goto case 219;
							case 219:
								num5 = 132;
								goto case 135;
							case 135:
								array4[15] = (byte)num5;
								goto case 34;
							case 34:
								num5 = 133;
								goto case 259;
							case 259:
								array4[15] = (byte)num5;
								num = 151;
								goto case 151;
							case 151:
								array4[15] = 166;
								goto case 183;
							case 183:
								array4[15] = 139;
								num2 = 282;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 339:
								array4[2] = (byte)num5;
								num2 = 4;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 59;
							case 59:
								array4[2] = 127;
								num2 = 88;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 336:
								array[29] = 166;
								goto case 187;
							case 187:
								num4 = 140;
								num2 = 350;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 333:
								num6 = 251;
								num2 = 18;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 331:
								array4[8] = (byte)num3;
								num2 = 263;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 274;
							case 274:
								array4[8] = 128;
								num2 = 309;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 329:
								num23 = num18 ^ num10;
								num2 = 120;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 325:
								array[14] = (byte)num4;
								goto case 222;
							case 222:
								num6 = 120;
								num2 = 344;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 324:
								array[18] = 132;
								goto case 384;
							case 321:
								num3 = 106;
								goto case 96;
							case 96:
								array4[6] = (byte)num3;
								num2 = 315;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 317:
								array[26] = (byte)num6;
								goto case 252;
							case 252:
								array[26] = 33;
								goto case 333;
							case 316:
								array[2] = (byte)num4;
								num2 = 359;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 315:
								array4[6] = 91;
								goto case 79;
							case 79:
								array4[7] = 131;
								num2 = 177;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 314:
								array4[6] = 110;
								num2 = 141;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 257;
							case 257:
								num3 = 96;
								goto case 150;
							case 150:
								array4[6] = (byte)num3;
								goto case 321;
							case 311:
								array[28] = (byte)num6;
								goto case 133;
							case 133:
								array[28] = 133;
								goto case 64;
							case 64:
								array[28] = 12;
								goto case 336;
							case 309:
								array4[8] = 146;
								num2 = 93;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 42;
							case 308:
								array[17] = 85;
								num2 = 77;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 307:
								JHwIJKNXU6tA0r50K8(object_3);
								num2 = 310;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 282;
							case 282:
								num5 = 165;
								num2 = 381;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 306:
								num5 = 104;
								num2 = 423;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 304:
								array[31] = 25;
								num = 235;
								goto case 235;
							case 235:
								array6 = array;
								num2 = 124;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 302:
								num18 = num19;
								goto case 53;
							case 53:
								if (num20 != num21 - 1)
								{
									goto case 346;
								}
								num2 = 6;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 44;
							case 44:
								if (num22 > 0)
								{
									num2 = 329;
									if (nhvvFkW9mGSbYIAbJ6())
									{
										continue;
									}
									goto IL_0024;
								}
								goto case 346;
							case 298:
								num17 = array6.Length / 4;
								num = 275;
								goto case 275;
							case 275:
								num18 = 0u;
								num = 51;
								goto case 51;
							case 297:
								array4[3] = (byte)num5;
								goto case 81;
							case 81:
								array4[3] = 92;
								num2 = 60;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 226;
							case 226:
								num3 = 85;
								goto case 199;
							case 199:
								array4[3] = (byte)num3;
								num2 = 95;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 73;
							case 296:
								array[9] = 88;
								num2 = 150;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 173;
							case 173:
								num6 = 83;
								goto case 25;
							case 25:
								array[9] = (byte)num6;
								goto case 122;
							case 122:
								array[9] = 250;
								num2 = 254;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 64;
							case 295:
								array[9] = (byte)num6;
								num2 = 296;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 294:
								array[4] = 91;
								goto case 385;
							case 292:
								array[8] = 232;
								goto case 281;
							case 281:
								array[9] = 163;
								goto case 32;
							case 32:
								num6 = 131;
								num2 = 56;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 295;
							case 290:
								array[10] = (byte)num6;
								goto case 395;
							case 288:
								num4 = 62;
								num2 = 11;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 287:
								array[22] = (byte)num4;
								num2 = 118;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 285:
								num16 = (uint)((array6[num8 + 3] << 24) | (array6[num8 + 2] << 16) | (array6[num8 + 1] << 8) | array6[num8]);
								num2 = 240;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 283:
								array4[4] = 200;
								goto case 418;
							case 280:
								array[3] = (byte)num4;
								goto case 408;
							case 277:
								array[6] = (byte)num4;
								num = 436;
								goto case 436;
							case 272:
								object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
								num2 = 1;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 2;
							case 2:
								lXZ8jXjB1hHmxP67IH(object_3, array5, 0, array5.Length);
								goto case 388;
							case 271:
								array[18] = 122;
								num2 = 163;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 270:
								G3XK1JqISrotoVADpw(object_);
								goto case 141;
							case 141:
								array = new byte[32];
								num = 269;
								goto case 269;
							case 269:
								num4 = 180;
								num = 195;
								goto case 195;
							case 195:
								array[0] = (byte)num4;
								goto case 422;
							case 267:
								array4[14] = (byte)num5;
								num2 = 429;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 264:
								num5 = 188;
								num2 = 444;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 263:
								array[30] = 91;
								num2 = 441;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 262:
								array4[1] = (byte)num5;
								num2 = 221;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 256:
								num15++;
								goto case 27;
							case 255:
								array4[13] = 88;
								goto case 247;
							case 247:
								num5 = 119;
								goto case 46;
							case 46:
								array4[13] = (byte)num5;
								goto case 349;
							case 254:
								array[10] = 136;
								goto case 84;
							case 84:
								num6 = 74;
								goto case 74;
							case 74:
								array[10] = (byte)num6;
								goto case 200;
							case 200:
								num6 = 111;
								num2 = 113;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 44;
							case 253:
								array4[4] = (byte)num3;
								num2 = 16;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 28;
							case 250:
								array[3] = 91;
								num2 = 294;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 287;
							case 246:
								num6 = 211;
								goto case 139;
							case 139:
								array[17] = (byte)num6;
								goto case 308;
							case 245:
								num6 = 138;
								num2 = 317;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 242:
								array[6] = (byte)num4;
								num = 209;
								goto case 209;
							case 209:
								num4 = 119;
								goto case 433;
							case 241:
								array[23] = 100;
								goto case 174;
							case 174:
								num4 = 86;
								goto case 190;
							case 190:
								array[24] = (byte)num4;
								num2 = 371;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 240:
								num13 = 255u;
								goto case 224;
							case 224:
								num14 = 0;
								goto case 360;
							case 239:
								array[19] = (byte)num4;
								num2 = 432;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 193;
							case 237:
								array[6] = 109;
								goto case 105;
							case 105:
								num4 = 91;
								goto case 277;
							case 233:
								array[22] = 195;
								num2 = 50;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 231:
								array4[7] = 123;
								goto case 351;
							case 229:
								array4[8] = 89;
								goto case 404;
							case 228:
								num6 = 146;
								goto case 411;
							case 221:
								num3 = 17;
								goto case 171;
							case 171:
								array4[1] = (byte)num3;
								goto case 213;
							case 213:
								array4[2] = 134;
								goto case 134;
							case 134:
								num5 = 123;
								num2 = 339;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 220:
								array4[10] = 146;
								goto case 101;
							case 101:
								array4[10] = 160;
								goto case 52;
							case 52:
								num5 = 179;
								goto case 158;
							case 158:
								array4[10] = (byte)num5;
								num2 = 1;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 1;
							case 1:
								array4[11] = 118;
								num = 415;
								goto case 415;
							case 218:
								num6 = 75;
								goto case 21;
							case 21:
								array[18] = (byte)num6;
								goto case 204;
							case 204:
								num6 = 222;
								num2 = 276;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 391;
							case 216:
								array4[5] = (byte)num3;
								goto case 20;
							case 214:
								array4[6] = (byte)num5;
								num2 = 292;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 314;
							case 212:
								stream = (Stream)E2kuvDDZsIoSnekTZB();
								goto case 272;
							case 206:
								array4[0] = 226;
								num2 = 264;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 214;
							case 205:
								array2[11] = array3[5];
								goto case 448;
							case 203:
								array4[9] = (byte)num5;
								num2 = 8;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 202:
								num6 = 166;
								num2 = 94;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 201:
								num6 = 103;
								num2 = 125;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 53;
							case 197:
								JHwIJKNXU6tA0r50K8(stream);
								goto case 307;
							case 189:
								array[17] = 139;
								num = 246;
								goto case 246;
							case 184:
								array[18] = (byte)num6;
								goto case 324;
							case 182:
								transform = (ICryptoTransform)YCNASFkccMs8Ioit6M(object_2, array6, array2);
								goto case 212;
							case 181:
								num4 = 162;
								num2 = 24;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 17;
							case 17:
								array5 = (byte[])vEmaIXORrFYkGQfCDP(object_, (int)C8eZDk3Xbdu0qSi4dp(zaCNcDwIlIUmROVIOY(object_)));
								goto case 270;
							case 180:
								num4 = 126;
								goto case 280;
							case 179:
								array[25] = 176;
								num2 = 201;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 110;
							case 178:
								array4[5] = (byte)num5;
								num2 = 128;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 177:
								num3 = 88;
								num2 = 144;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 175:
								num4 = 221;
								num = 155;
								goto case 155;
							case 155:
								array[15] = (byte)num4;
								goto case 143;
							case 143:
								array[16] = 134;
								goto case 37;
							case 37:
								num6 = 94;
								num2 = 32;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 130;
							case 130:
								array[16] = (byte)num6;
								num2 = 48;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 446;
							case 172:
								num4 = 160;
								num2 = 242;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 230;
							case 169:
								num6 = 118;
								goto case 378;
							case 165:
								array[1] = (byte)num4;
								goto case 103;
							case 103:
								num6 = 166;
								num2 = 49;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 164:
								num4 = 196;
								goto case 131;
							case 131:
								array[25] = (byte)num4;
								num = 162;
								goto case 162;
							case 162:
								num6 = 45;
								goto case 90;
							case 90:
								array[25] = (byte)num6;
								num2 = 179;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 99;
							case 163:
								num4 = 156;
								num2 = 42;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 55;
							case 55:
								array[18] = (byte)num4;
								num2 = 98;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 218;
							case 160:
								array[21] = (byte)num4;
								num2 = 230;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 159:
								array[2] = (byte)num6;
								num2 = 121;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 374;
							case 149:
								array4[0] = (byte)num5;
								goto case 206;
							case 148:
								array[22] = (byte)num4;
								num2 = 233;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 147:
								num6 = 115;
								num2 = 311;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 146:
								array[0] = (byte)num4;
								goto case 202;
							case 144:
								array4[7] = (byte)num3;
								goto case 231;
							case 137:
								num6 = 122;
								num2 = 416;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 136:
								num4 = 126;
								num2 = 316;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 74;
							case 128:
								num3 = 74;
								num2 = 216;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 127:
								num12++;
								num = 232;
								goto case 73;
							case 120:
								num11 = 0;
								num2 = 196;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 118:
								array[22] = 163;
								num2 = 16;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 12;
							case 12:
								num8 = (uint)num9;
								goto case 98;
							case 98:
								num10 = (uint)((array5[num8 + 3] << 24) | (array5[num8 + 2] << 16) | (array5[num8 + 1] << 8) | array5[num8]);
								goto case 373;
							case 117:
								array4[0] = (byte)num3;
								goto case 115;
							case 116:
								array2[9] = array3[4];
								num2 = 205;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 114:
								RnXr5UVZkE = (byte[])VOIqovvYYEqRoImEdK(stream);
								goto case 197;
							case 113:
								array[10] = (byte)num6;
								num2 = 19;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 111:
								array[22] = (byte)num4;
								goto case 69;
							case 69:
								array[22] = 232;
								goto case 15;
							case 15:
								num6 = 160;
								goto case 447;
							case 108:
								array4[10] = 83;
								num2 = 220;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto case 75;
							case 106:
								array[29] = (byte)num4;
								goto case 91;
							case 91:
								num6 = 159;
								goto case 45;
							case 45:
								array[30] = (byte)num6;
								goto case 263;
							case 95:
								array4[3] = 198;
								goto case 283;
							case 94:
								array[1] = (byte)num6;
								num2 = 169;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 93:
								array4[9] = 174;
								num2 = 13;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 92:
								array[8] = 129;
								goto case 292;
							case 88:
								num5 = 68;
								goto case 377;
							case 85:
								num8 = (uint)(num7 * 4);
								goto case 285;
							case 83:
								array[27] = 128;
								num2 = 210;
								if (EZJuicCKvDEtHrVggB() != null)
								{
									continue;
								}
								goto case 363;
							case 82:
								num5 = 169;
								goto case 355;
							case 80:
								array[13] = 2;
								goto case 405;
							case 78:
								num4 = 125;
								goto case 239;
							case 77:
								array[17] = 42;
								goto case 271;
							case 76:
								num6 = 72;
								num2 = 15;
								if (!nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto case 159;
							case 71:
								num5 = 129;
								goto case 420;
							case 67:
								num4 = 93;
								goto case 347;
							case 65:
								array[26] = 104;
								goto case 245;
							case 61:
								array4[7] = (byte)num5;
								num2 = 229;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 60:
								array[7] = (byte)num4;
								num = 431;
								goto case 431;
							case 50:
								num4 = 8;
								goto case 287;
							case 49:
								array[2] = (byte)num6;
								goto case 136;
							case 47:
								array[5] = (byte)num6;
								goto case 172;
							case 40:
								array[15] = 32;
								goto case 175;
							case 39:
								num4 = 102;
								goto case 325;
							case 31:
								array[14] = (byte)num6;
								goto case 67;
							case 24:
								array[26] = (byte)num4;
								goto case 65;
							case 23:
								array2[1] = array3[0];
								num2 = 361;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 19:
								num6 = 162;
								goto case 290;
							case 18:
								array[26] = (byte)num6;
								num2 = 345;
								if (EZJuicCKvDEtHrVggB() == null)
								{
									continue;
								}
								goto IL_0024;
							case 16:
								num4 = 150;
								num2 = 111;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 14:
								klkorLt6I118XgdwaS(object_2, CipherMode.CBC);
								num2 = 182;
								if (nhvvFkW9mGSbYIAbJ6())
								{
									continue;
								}
								goto IL_0024;
							case 13:
								num5 = 190;
								num = 203;
								goto case 203;
							case 11:
								array[4] = (byte)num4;
								num = 383;
								goto case 383;
							case 8:
								num3 = 102;
								goto case 56;
							case 409:
								goto end_IL_2453;
							case 366:
								goto end_IL_2b65;
							case 30:
								goto end_IL_2b8f;
							case 72:
								RnXr5UVZkE = array7;
								goto IL_2bc2;
							case 29:
							case 234:
								goto IL_2bc2;
							case 300:
								goto IL_2bcf;
							case 266:
								goto end_IL_2ba7;
							}
							num21++;
							num2 = 97;
							if (nhvvFkW9mGSbYIAbJ6())
							{
								continue;
							}
							goto IL_0024;
							continue;
							end_IL_2453:
							break;
						}
						continue;
						IL_0024:
						num2 = num;
						goto IL_2453;
						continue;
						end_IL_2b65:
						break;
					}
					continue;
					end_IL_2b8f:
					break;
				}
				continue;
			}
			num = 29;
			goto IL_2bc2;
			IL_2bc2:
			int_ = mWSo2vScck2Fb5J75G(RnXr5UVZkE, int_0);
			goto IL_2bcf;
			IL_2bcf:
			try
			{
				LSJr9gbDS2Za5jV6qv();
				int num27 = 0;
				if (!nhvvFkW9mGSbYIAbJ6())
				{
					num27 = num28;
				}
				do
				{
					switch (num27)
					{
					case 1:
						return result;
					}
					result = (string)pxo7YlKpr6kMXVZ9U9(oGEiK9pULisKT6K5WC(), RnXr5UVZkE, int_0 + 4, int_);
					num27 = 0;
				}
				while (EZJuicCKvDEtHrVggB() != null);
				return result;
			}
			catch
			{
				int num29 = 0;
				if (!nhvvFkW9mGSbYIAbJ6())
				{
					num29 = num30;
				}
				switch (num29)
				{
				}
			}
			break;
			continue;
			end_IL_2ba7:
			break;
		}
		return "";
	}

	[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
	internal static string G9MiHOFvM(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int crGzr7GFB()
	{
		return 5;
	}

	private static void Ihhrkbug3H()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate guHrrF0rLS(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(16777307)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(16777244)),
			Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(16777239))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object BZir6BN5Tr(object object_0)
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

	private static IntPtr cPfrYXCMlv(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (t3jrae7Xo9 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			t3jrae7Xo9 = (FedICOErV6g9Wj3eXj)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554459)));
		}
		return t3jrae7Xo9(intptr_0, string_0, uint_0);
	}

	private static IntPtr Mnmrj4tgY7(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (rXJrUit6pd == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			rXJrUit6pd = (Vi1xkKXhyrm614lS8f)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554460)));
		}
		return rXJrUit6pd(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int plSrlkGEoV(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (b8ars1t0jB == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			b8ars1t0jB = (FdkQnFcG7WxkaNbkvI)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554461)));
		}
		return b8ars1t0jB(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int bRor8KK0pc(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (UVPrWCNw97 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			UVPrWCNw97 = (j6wiuYRa1mNvBHDi0C)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554462)));
		}
		return UVPrWCNw97(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr Gbcrg8pUlG(uint uint_0, int int_0, uint uint_1)
	{
		if (CEurhCFsGi == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			CEurhCFsGi = (q8auF9ChrMlZycgrom)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554463)));
		}
		return CEurhCFsGi(uint_0, int_0, uint_1);
	}

	private static int iB1rpLDt3x(IntPtr intptr_0)
	{
		if (o1FriD7RBV == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			o1FriD7RBV = (wgyCs8fDdljP476WNk)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(A3iFUldKqR86yQ3bDu.Ja4WFxs2ESgBf(33554464)));
		}
		return o1FriD7RBV(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (bZJrzD9VBO == IntPtr.Zero)
		{
			bZJrzD9VBO = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return bZJrzD9VBO;
	}

	[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
	private static byte[] IkcrMedICO(string string_0)
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

	internal static Stream bV6rog9Wj3()
	{
		return new MemoryStream();
	}

	internal static byte[] rXjrAUi1xk(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[WAG8Lb0oci51KAcM9Q(typeof(WAG8Lb0oci51KAcM9Q.TpmTfLZb0JkAt6R9MH<object>[]))]
	private static byte[] Rhyrqrm614(byte[] byte_0)
	{
		Stream stream = bV6rog9Wj3();
		SymmetricAlgorithm symmetricAlgorithm = DieQgNWrf();
		symmetricAlgorithm.Key = new byte[32]
		{
			152, 130, 87, 229, 204, 55, 189, 29, 130, 71,
			138, 64, 164, 189, 114, 46, 225, 196, 212, 126,
			219, 17, 119, 135, 234, 91, 232, 50, 251, 158,
			246, 21
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			214, 201, 151, 17, 33, 113, 174, 209, 188, 71,
			186, 45, 77, 132, 205, 64
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = rXjrAUi1xk(stream);
		ogBUnd2ju1Vg8teO7c.E2gWFx4z4NEdd();
		return result;
	}

	private byte[] gS8rHfRdkQ()
	{
		return null;
	}

	private byte[] AFGrP7Wxka()
	{
		return null;
	}

	private byte[] JbkrFvIM6w()
	{
		return null;
	}

	private byte[] YuYrIa1mNv()
	{
		return null;
	}

	private byte[] cHDr4i0C48()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] UuFr99hrMl()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] xycregromL()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] iyCrts8Ddl()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] fP4r176WNk()
	{
		return null;
	}

	internal byte[] UT6rJAaKhX()
	{
		return null;
	}

	internal static object qMAdlm61gqsKhj9erT(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object zaCNcDwIlIUmROVIOY(object object_0)
	{
		return ((Mc8pUl5GpB1LDt3xfk)object_0).KDikMXewCI();
	}

	internal static void zZdkKOrYGVhO9Ff14k(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long C8eZDk3Xbdu0qSi4dp(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object vEmaIXORrFYkGQfCDP(object object_0, int int_0)
	{
		return ((Mc8pUl5GpB1LDt3xfk)object_0).kJE6B3tUyy(int_0);
	}

	internal static void G3XK1JqISrotoVADpw(object object_0)
	{
		((Mc8pUl5GpB1LDt3xfk)object_0).B8M6joGr6C();
	}

	internal static void JfP1DOxMNgDG18LiJs(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object tc3PBMZQNCofeSeDDt(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object Ugs4JEiiAP4ef9jF3f(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object b9qJIMBlIEPIomBOrv()
	{
		return DieQgNWrf();
	}

	internal static void klkorLt6I118XgdwaS(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object YCNASFkccMs8Ioit6M(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object E2kuvDDZsIoSnekTZB()
	{
		return bV6rog9Wj3();
	}

	internal static void lXZ8jXjB1hHmxP67IH(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void AwIMyRlsPW7ghScHhY(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object VOIqovvYYEqRoImEdK(object object_0)
	{
		return rXjrAUi1xk((Stream)object_0);
	}

	internal static void JHwIJKNXU6tA0r50K8(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int mWSo2vScck2Fb5J75G(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void LSJr9gbDS2Za5jV6qv()
	{
		ogBUnd2ju1Vg8teO7c.E2gWFx4z4NEdd();
	}

	internal static object oGEiK9pULisKT6K5WC()
	{
		return Encoding.Unicode;
	}

	internal static object pxo7YlKpr6kMXVZ9U9(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool nhvvFkW9mGSbYIAbJ6()
	{
		return (object)null == null;
	}

	internal static object EZJuicCKvDEtHrVggB()
	{
		return null;
	}

	internal static void TQMpg9LJcq1X85JbgX()
	{
		ogBUnd2ju1Vg8teO7c.E2gWFx4z4NEdd();
	}

	internal static void n5WebgCoMpDyZwKitR(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static Type vnNnIKTlJhr0nupeKk(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object HWu3ws5sQEg6qrFymL(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static int WICUxBumQWWOavwIrH(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static object GwOQndiagZ3hWOk1cZ()
	{
		return SHA1.Create();
	}

	internal static object Fe2TUWVVKYGQZlFxoK(object object_0)
	{
		return CryptoConfig.MapNameToOID((string)object_0);
	}

	internal static bool Iu19Tt8H6FFbRviwX1(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object Up3hMTDIdWODvE2Cav(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object eiOdEwo3UrLXLmDpy8(object object_0)
	{
		return ((Mc8pUl5GpB1LDt3xfk)object_0).KDikMXewCI();
	}

	internal static void IOrKPC7Inv9GJpnrMu(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long bK6662tmCAmNtKIJZR(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object tqoDfNXrFkLn86k40S(object object_0, int int_0)
	{
		return ((Mc8pUl5GpB1LDt3xfk)object_0).kJE6B3tUyy(int_0);
	}

	internal static object ivcFhRnwmMAAIf1uev()
	{
		return DieQgNWrf();
	}

	internal static void gSE4Jc932umBBUl3DN(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object nADINUQ1cC6B2UDpOX(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object Uin1YtKuHsgbZN7dCY()
	{
		return bV6rog9Wj3();
	}

	internal static void D0OgMjmcmfR1jBE9MQ(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void SOHqkuEtdCeYc5P3GL(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object LCHr5Mr3kMUbSBJYUJ()
	{
		return Encoding.UTF8;
	}

	internal static object AFXmXD12Tvgx2Kc8q8(object object_0)
	{
		return rXjrAUi1xk((Stream)object_0);
	}

	internal static object KufEFcgLK91AKDOxOM(object object_0, object object_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1);
	}

	internal static void iV7MymBoKMvkt6l4Tt(object object_0, object object_1)
	{
		((AsymmetricAlgorithm)object_0).FromXmlString((string)object_1);
	}

	internal static void icKLIqAYqJdf74M538(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static void IQyBqLaU1Vnw2fGnAX(object object_0)
	{
		((Mc8pUl5GpB1LDt3xfk)object_0).B8M6joGr6C();
	}

	internal static void ARQGtOF07n89sWtoI6(object object_0, object object_1, uint uint_0, object object_2)
	{
		MYSGQNbxd((HashAlgorithm)object_0, (Stream)object_1, uint_0, (byte[])object_2);
	}

	internal static ushort bgfeZEWNnR5Hom43XY(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt16();
	}

	internal static int w6gGrPNFZTtKc5eXAu(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void BJAYRSkH7LbKhYAR79(object object_0, object object_1, int int_0, int int_1)
	{
		nDQy9b5BH((HashAlgorithm)object_0, (byte[])object_1, int_0, int_1);
	}

	internal static long kU1pHqPtTEUvRKC4RU(object object_0)
	{
		return ((Stream)object_0).Position;
	}

	internal static uint xd71Hux1NmEpoI4QsV(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static uint LTtydB0uEMpfVN6GgF(uint uint_0, int int_0, long long_0, object object_0)
	{
		return eROK8rCxB(uint_0, int_0, long_0, (BinaryReader)object_0);
	}

	internal static long HxaXhGYqr0HAB1Q8dt(long long_0, long long_1)
	{
		return Math.Min(long_0, long_1);
	}

	internal static object lkevfrpGtYpRFWywLI(object object_0, object object_1, int int_0, int int_1)
	{
		return ((HashAlgorithm)object_0).TransformFinalBlock((byte[])object_1, int_0, int_1);
	}

	internal static object FMnZWKU2ONm3HAYs2m(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void dyiMmylEJyiWUibn7P(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object djA5dsq9fdqaY2VKp3(object object_0)
	{
		return ((HashAlgorithm)object_0).Hash;
	}

	internal static bool B2Afab2BDKqaYpDQee(object object_0, object object_1, object object_2, object object_3)
	{
		return ((RSACryptoServiceProvider)object_0).VerifyHash((byte[])object_1, (string)object_2, (byte[])object_3);
	}

	internal static object AELutXSLnspxs0Wc53(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object oDvb4CbbsbEoEb7M4x(object object_0)
	{
		return ((AssemblyName)object_0).Name;
	}

	internal static object mSIPts4yL5OrBX8VlG(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static bool QZt3VysUXxYH0TNuqQ()
	{
		return (object)null == null;
	}

	internal static object MeHVP1hy3wBGUVgAKF()
	{
		return null;
	}
}
