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

namespace LqHyLjKQHwjIbZdxED;

internal class pHtTtXRCv6EXeda4Vr
{
	private delegate void FLwJXKJ0BD68stslPe(object o);

	internal class OoiAeatVkMc2Ep745M : Attribute
	{
		internal class z11306uMphC1SsS0wq<DOgG9isKXMOCndEm47>
		{
			internal static object SvSVfhYWEwR0ebo6Fio;

			public z11306uMphC1SsS0wq()
			{
				R8TayKhW8eikpukIpe.piUZpdWzJZMua();
				base._002Ector();
			}

			internal static bool ISVhB4YCkilbgVS2Ff3()
			{
				return SvSVfhYWEwR0ebo6Fio == null;
			}

			internal static object KnD5v3Y9gsp5C5OBL5D()
			{
				return SvSVfhYWEwR0ebo6Fio;
			}
		}

		[OoiAeatVkMc2Ep745M(typeof(z11306uMphC1SsS0wq<object>[]))]
		public OoiAeatVkMc2Ep745M(object object_0)
		{
		}
	}

	internal class Xe5qH6cuuJfXaXtBWW
	{
		[OoiAeatVkMc2Ep745M(typeof(OoiAeatVkMc2Ep745M.z11306uMphC1SsS0wq<object>[]))]
		internal static string ntW2vBNFog(string string_0, string string_1)
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
			byte[] iV = l0jv7inoBU(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = LrQvFB4H8Z();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			x5uVftYNvH1ZcJVUPqM(cryptoStream, array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		internal static void x5uVftYNvH1ZcJVUPqM(object object_0, object object_1, int int_0, int int_1)
		{
			((Stream)object_0).Write((byte[])object_1, int_0, int_1);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint INkLoCDEcOB4Bkv7ib(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr J9VVFITdqAFEggoSl9();

	internal struct iCPjKH52r5blg01Sct
	{
		internal bool SIm29t7cdJ;

		internal byte[] dT622iTjtS;
	}

	internal class mmmhROZdZfJrbe84gQ
	{
		private BinaryReader OOS2mNtolb;

		public mmmhROZdZfJrbe84gQ(Stream stream_0)
		{
			OOS2mNtolb = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return OOS2mNtolb.BaseStream;
		}

		internal byte[] YWx2NH3LvW(int int_0)
		{
			return OOS2mNtolb.ReadBytes(int_0);
		}

		internal int KGK2UDhEwe(byte[] byte_0, int int_0, int int_1)
		{
			return OOS2mNtolb.Read(byte_0, int_0, int_1);
		}

		internal int FQG2icFQpI()
		{
			return OOS2mNtolb.ReadInt32();
		}

		internal void qLx2YPuss7()
		{
			OOS2mNtolb.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr NOx316Q0wR13tENK3M(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr h2tXEL1ECQIp5P1qpf(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int aCadOeo6NN4X820efJ(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int RRVWbdFSGc8UvjGYBy(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr yw1KmrSJukOKiLHWdQ(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Xs4FfO7MqxOv8yxNEP(IntPtr ptr);

	[Flags]
	private enum mrrridGMI3eAwWytE8
	{

	}

	private static bool zni9WUgnpt;

	internal static Assembly M2n9XyHTWD;

	private static uint[] aNy9LgYtGC;

	private static bool m6w9a2QpCX;

	private static bool c4P9Am6OGF;

	private static byte[] biu90lJGca;

	internal static RSACryptoServiceProvider H2K9HdnYcw;

	private static Dictionary<int, int> Rb89dHcwxD;

	private static object DQo9rbGyd4;

	private static byte[] rcZ9PqLk6o;

	private static byte[] X9w935IHvg;

	private static IntPtr oUU9R1wIsX;

	private static IntPtr nri9J3ZwRX;

	private static object HeL9tYwb31;

	private static int[] OGa9upZ5oa;

	private static int PB79sjogvf;

	private static bool Tmc9cwrbwb;

	private static SortedList t9E9DbBw45;

	private static int BdL9T55aNO;

	private static long T9h959r2mH;

	internal static INkLoCDEcOB4Bkv7ib bPs9Zku7b1;

	internal static INkLoCDEcOB4Bkv7ib tRa9QZ9x64;

	private static long pGC91eGS4m;

	private static int Qk59o3cvpQ;

	private static bool cMO9Flh2IU;

	private static bool Jmd9ScdYdy;

	private static int Y0p97tT6xA;

	private static IntPtr IqN9GkK4tg;

	[OoiAeatVkMc2Ep745M(typeof(OoiAeatVkMc2Ep745M.z11306uMphC1SsS0wq<object>[]))]
	private static bool snB9hAId7i;

	internal static Hashtable Tl39lykHxm;

	private static NOx316Q0wR13tENK3M vHo9erHNLw;

	private static h2tXEL1ECQIp5P1qpf NRr9y9V4Zf;

	private static aCadOeo6NN4X820efJ F8s9zH3Kp5;

	private static RRVWbdFSGc8UvjGYBy jWB2M0EbXi;

	private static yw1KmrSJukOKiLHWdQ nwA2KpXkEK;

	private static Xs4FfO7MqxOv8yxNEP WvD24X6xPj;

	private static IntPtr qcE2woyxEY;

	static pHtTtXRCv6EXeda4Vr()
	{
		zni9WUgnpt = false;
		M2n9XyHTWD = typeof(pHtTtXRCv6EXeda4Vr).Assembly;
		aNy9LgYtGC = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		m6w9a2QpCX = false;
		c4P9Am6OGF = false;
		biu90lJGca = new byte[0];
		H2K9HdnYcw = null;
		Rb89dHcwxD = null;
		DQo9rbGyd4 = new object();
		rcZ9PqLk6o = new byte[0];
		X9w935IHvg = new byte[0];
		oUU9R1wIsX = IntPtr.Zero;
		nri9J3ZwRX = IntPtr.Zero;
		HeL9tYwb31 = new string[0];
		OGa9upZ5oa = new int[0];
		PB79sjogvf = 1;
		Tmc9cwrbwb = false;
		t9E9DbBw45 = new SortedList();
		BdL9T55aNO = 0;
		T9h959r2mH = 0L;
		bPs9Zku7b1 = null;
		tRa9QZ9x64 = null;
		pGC91eGS4m = 0L;
		Qk59o3cvpQ = 0;
		cMO9Flh2IU = false;
		Jmd9ScdYdy = false;
		Y0p97tT6xA = 0;
		IqN9GkK4tg = IntPtr.Zero;
		snB9hAId7i = false;
		Tl39lykHxm = new Hashtable();
		vHo9erHNLw = null;
		NRr9y9V4Zf = null;
		F8s9zH3Kp5 = null;
		jWB2M0EbXi = null;
		nwA2KpXkEK = null;
		WvD24X6xPj = null;
		qcE2woyxEY = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void T6CZpdW5ecXq6()
	{
	}

	internal static byte[] GNsvDsGyqE(byte[] byte_0)
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
			vWqvTmp9aD(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			vWqvTmp9aD(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			vWqvTmp9aD(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			vWqvTmp9aD(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			vWqvTmp9aD(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			vWqvTmp9aD(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			vWqvTmp9aD(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			vWqvTmp9aD(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			vWqvTmp9aD(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			vWqvTmp9aD(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			vWqvTmp9aD(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			vWqvTmp9aD(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			vWqvTmp9aD(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			vWqvTmp9aD(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			vWqvTmp9aD(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			vWqvTmp9aD(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			RMZv5rgXML(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			RMZv5rgXML(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			RMZv5rgXML(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			RMZv5rgXML(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			RMZv5rgXML(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			RMZv5rgXML(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			RMZv5rgXML(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			RMZv5rgXML(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			RMZv5rgXML(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			RMZv5rgXML(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			RMZv5rgXML(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			RMZv5rgXML(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			RMZv5rgXML(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			RMZv5rgXML(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			RMZv5rgXML(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			RMZv5rgXML(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			MCgvZ6CiPm(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			MCgvZ6CiPm(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			MCgvZ6CiPm(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			MCgvZ6CiPm(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			MCgvZ6CiPm(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			MCgvZ6CiPm(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			MCgvZ6CiPm(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			MCgvZ6CiPm(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			MCgvZ6CiPm(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			MCgvZ6CiPm(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			MCgvZ6CiPm(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			MCgvZ6CiPm(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			MCgvZ6CiPm(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			MCgvZ6CiPm(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			MCgvZ6CiPm(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			MCgvZ6CiPm(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			rdavQMnS9R(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			rdavQMnS9R(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			rdavQMnS9R(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			rdavQMnS9R(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			rdavQMnS9R(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			rdavQMnS9R(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			rdavQMnS9R(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			rdavQMnS9R(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			rdavQMnS9R(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			rdavQMnS9R(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			rdavQMnS9R(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			rdavQMnS9R(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			rdavQMnS9R(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			rdavQMnS9R(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			rdavQMnS9R(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			rdavQMnS9R(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		F6BlOhYGCgPfvOGNPLp(Aeq4WJYBs7xw3wVZKyq(uint_), 0, array3, 0, 4);
		F6BlOhYGCgPfvOGNPLp(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		F6BlOhYGCgPfvOGNPLp(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void vWqvTmp9aD(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + PPfv1oQB5i(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + aNy9LgYtGC[uint_5 - 1], ushort_0);
	}

	private static void RMZv5rgXML(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + PPfv1oQB5i(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + aNy9LgYtGC[uint_5 - 1], ushort_0);
	}

	private static void MCgvZ6CiPm(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + PPfv1oQB5i(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + aNy9LgYtGC[uint_5 - 1], ushort_0);
	}

	private static void rdavQMnS9R(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + gDYxHbYduEnkhTnvw1d(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + aNy9LgYtGC[uint_5 - 1], ushort_0);
	}

	private static uint PPfv1oQB5i(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool Edwvop9Znj()
	{
		if (!m6w9a2QpCX)
		{
			SrKvSlKKbj();
			m6w9a2QpCX = true;
		}
		return c4P9Am6OGF;
	}

	internal static SymmetricAlgorithm LrQvFB4H8Z()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Edwvop9Znj())
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

	internal static void SrKvSlKKbj()
	{
		try
		{
			c4P9Am6OGF = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] l0jv7inoBU(byte[] byte_0)
	{
		if (!Edwvop9Znj())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return (byte[])sN9vhcYtwWp8oDmDIFT(byte_0);
	}

	internal static void YFJvGmIiXy(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			TlnvhsTq0d(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void TlnvhsTq0d(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		xDycNCYFBFVvf7lOJce(hashAlgorithm_0, byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint xrrvlgEUcq(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_0)
			{
				((Stream)Rp6un8YDCkSna6Qri9P(binaryReader_0)).Position = long_0 + (num * 40 + 8);
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

	public static void dpwveuN6yQ(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Rb89dHcwxD == null)
			{
				lock (DQo9rbGyd4)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(pHtTtXRCv6EXeda4Vr).Assembly.GetManifestResourceStream("2MbRJTBI4GgCc64pMS.T6iCro0yNTvtjZp5eZ"));
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
							num3 += Jp99MpvPRF(num3);
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
						mmmhROZdZfJrbe84gQ mmmhROZdZfJrbe84gQ = new mmmhROZdZfJrbe84gQ(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = PEe5ZOYUX8AlahbGPbZ(mmmhROZdZfJrbe84gQ);
							int value = mmmhROZdZfJrbe84gQ.FQG2icFQpI();
							dictionary.Add(key, value);
						}
						mmmhROZdZfJrbe84gQ.qLx2YPuss7();
					}
					Rb89dHcwxD = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Rb89dHcwxD[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(pHtTtXRCv6EXeda4Vr).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, tuqXnLYLVuH6VyyhKxE(MteHB0Y0T6c3terc71i(fieldInfo), methodInfo));
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
						SLiEXoY5nTqqp5VXQrE(iLGenerator, OpCodes.Ldarg_S, num14);
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

	private static uint DuFvyI563I(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	private static uint xqVvzptdg3(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint Jp99MpvPRF(uint uint_0)
	{
		return 0u;
	}

	internal static void MlT9K0q2HU()
	{
	}

	[OoiAeatVkMc2Ep745M(typeof(OoiAeatVkMc2Ep745M.z11306uMphC1SsS0wq<object>[]))]
	internal static string JHR94U0K90(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return ((Encoding)SesCS6YnCpTIsABchxX()).GetString(array, 0, array.Length);
	}

	private static int Inf9wXxRmp()
	{
		return 5;
	}

	private static void Tl69vtxyMs()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate T1L99pd8it(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			uHiZHbYVnYjUe7OuLbd(typeof(Type).TypeHandle)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object QOW92XaBod(object object_0)
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
			if (File.Exists(WI1KTEYPgHQadPkCa9y(((Assembly)object_0).GetName()).ToString()!.Replace("file:///", "")))
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

	private static IntPtr XcC9ipSQNS(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (vHo9erHNLw == null)
		{
			IntPtr procAddress = GetProcAddress(x7pBxdYedU89cDQSLNE(), "Find ".Trim() + "ResourceA");
			vHo9erHNLw = (NOx316Q0wR13tENK3M)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(NOx316Q0wR13tENK3M));
		}
		return vHo9erHNLw(intptr_0, string_0, uint_0);
	}

	private static IntPtr cy69YDqeX4(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (NRr9y9V4Zf == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			NRr9y9V4Zf = (h2tXEL1ECQIp5P1qpf)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(h2tXEL1ECQIp5P1qpf));
		}
		return NRr9y9V4Zf(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int ELw9mhk6PQ(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (F8s9zH3Kp5 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			F8s9zH3Kp5 = (aCadOeo6NN4X820efJ)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(aCadOeo6NN4X820efJ));
		}
		return F8s9zH3Kp5(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int uNA9npRcnj(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (jWB2M0EbXi == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			jWB2M0EbXi = (RRVWbdFSGc8UvjGYBy)Marshal.GetDelegateForFunctionPointer(procAddress, uHiZHbYVnYjUe7OuLbd(typeof(RRVWbdFSGc8UvjGYBy).TypeHandle));
		}
		return jWB2M0EbXi(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr yVT9pHIHp6(uint uint_0, int int_0, uint uint_1)
	{
		if (nwA2KpXkEK == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			nwA2KpXkEK = (yw1KmrSJukOKiLHWdQ)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(yw1KmrSJukOKiLHWdQ));
		}
		return nwA2KpXkEK(uint_0, int_0, uint_1);
	}

	private static int ILy9f09oD6(IntPtr intptr_0)
	{
		if (WvD24X6xPj == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string)QZ7VNxYOm1e1Q9LIgKF(eGs2FxYJxKrtZV3SB5Y("Close "), "Handle"));
			WvD24X6xPj = (Xs4FfO7MqxOv8yxNEP)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Xs4FfO7MqxOv8yxNEP));
		}
		return WvD24X6xPj(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (qcE2woyxEY == IntPtr.Zero)
		{
			qcE2woyxEY = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return qcE2woyxEY;
	}

	[OoiAeatVkMc2Ep745M(typeof(OoiAeatVkMc2Ep745M.z11306uMphC1SsS0wq<object>[]))]
	private static byte[] Kun9Bq5K2a(string string_0)
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

	internal static Stream oaU9qyTjEa()
	{
		return new MemoryStream();
	}

	internal static byte[] oGW965wCNn(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[OoiAeatVkMc2Ep745M(typeof(OoiAeatVkMc2Ep745M.z11306uMphC1SsS0wq<object>[]))]
	private static byte[] L5y9kIMe3b(byte[] byte_0)
	{
		Stream stream = oaU9qyTjEa();
		SymmetricAlgorithm symmetricAlgorithm = LrQvFB4H8Z();
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
		SYEpILYkcRXdmnIwo61(cryptoStream);
		byte[] result = oGW965wCNn(stream);
		R8TayKhW8eikpukIpe.piUZpdWzJZMua();
		return result;
	}

	private byte[] qgM9jpHhK7()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] vrs9x5KBVw()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] xek9gT2eSn()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] r1n9EfUx6n()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Lax9VOaool()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] SEb9IBejNe()
	{
		string object_ = "{11111-22222-30001-00002}";
		if (z82AJ1YSD1hN5ZAmGlP(object_) > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] W859CISrGW()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] f1Y9Ob1VH7()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] WC29bCP6LO()
	{
		return null;
	}

	internal byte[] bnc98OgFaQ()
	{
		return null;
	}

	internal static object Aeq4WJYBs7xw3wVZKyq(uint uint_0)
	{
		return BitConverter.GetBytes(uint_0);
	}

	internal static void F6BlOhYGCgPfvOGNPLp(object object_0, int int_0, object object_1, int int_1, int int_2)
	{
		Array.Copy((Array)object_0, int_0, (Array)object_1, int_1, int_2);
	}

	internal static uint gDYxHbYduEnkhTnvw1d(uint uint_0, ushort ushort_0)
	{
		return PPfv1oQB5i(uint_0, ushort_0);
	}

	internal static object sN9vhcYtwWp8oDmDIFT(object object_0)
	{
		return GNsvDsGyqE((byte[])object_0);
	}

	internal static int xDycNCYFBFVvf7lOJce(object object_0, object object_1, int int_0, int int_1, object object_2, int int_2)
	{
		return ((HashAlgorithm)object_0).TransformBlock((byte[])object_1, int_0, int_1, (byte[]?)object_2, int_2);
	}

	internal static object Rp6un8YDCkSna6Qri9P(object object_0)
	{
		return ((BinaryReader)object_0).BaseStream;
	}

	internal static int PEe5ZOYUX8AlahbGPbZ(object object_0)
	{
		return ((mmmhROZdZfJrbe84gQ)object_0).FQG2icFQpI();
	}

	internal static Type MteHB0Y0T6c3terc71i(object object_0)
	{
		return ((FieldInfo)object_0).FieldType;
	}

	internal static object tuqXnLYLVuH6VyyhKxE(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static void SLiEXoY5nTqqp5VXQrE(object object_0, OpCode opCode_0, int int_0)
	{
		((ILGenerator)object_0).Emit(opCode_0, int_0);
	}

	internal static object SesCS6YnCpTIsABchxX()
	{
		return Encoding.Unicode;
	}

	internal static Type uHiZHbYVnYjUe7OuLbd(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object WI1KTEYPgHQadPkCa9y(object object_0)
	{
		return ((AssemblyName)object_0).CodeBase;
	}

	internal static IntPtr x7pBxdYedU89cDQSLNE()
	{
		return umLocehuEC();
	}

	internal static object eGs2FxYJxKrtZV3SB5Y(object object_0)
	{
		return ((string)object_0).Trim();
	}

	internal static object QZ7VNxYOm1e1Q9LIgKF(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void SYEpILYkcRXdmnIwo61(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int z82AJ1YSD1hN5ZAmGlP(object object_0)
	{
		return ((string)object_0).Length;
	}
}
