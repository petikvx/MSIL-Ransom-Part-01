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
using ns50;
using ns51;

namespace ns49;

internal class Class25
{
	private delegate void Delegate2(object o);

	internal class Attribute0 : Attribute
	{
		internal class Class26<T>
		{
			internal static object object_0;

			static Class26()
			{
				smethod_22();
				smethod_13();
			}

			internal static bool smethod_0()
			{
				return true;
			}

			internal static object smethod_1()
			{
				return null;
			}
		}

		[Attribute0(typeof(Class26<object>[]))]
		public Attribute0(object object_0)
		{
		}

		static Attribute0()
		{
			smethod_22();
		}
	}

	internal class Class27
	{
		[Attribute0(typeof(Attribute0.Class26<object>[]))]
		internal static string smethod_0(object object_0, object object_1)
		{
			return null;
		}

		internal static object smethod_1()
		{
			return null;
		}

		internal static object smethod_2(object object_0, object object_1)
		{
			return null;
		}

		internal static void smethod_3(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
		}

		internal static object smethod_4(object object_0)
		{
			return null;
		}

		internal static void smethod_5(object object_0, object object_1)
		{
		}

		internal static void smethod_6(object object_0, object object_1)
		{
		}

		internal static void smethod_7(object object_0, object object_1, int int_0, int int_1)
		{
		}

		internal static object smethod_8(object object_0)
		{
			return null;
		}

		internal static object smethod_9(object object_0)
		{
			return null;
		}

		static Class27()
		{
			smethod_22();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate3(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate4();

	internal struct Struct19
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	internal class Class28
	{
		private object object_0;

		public Class28(Stream stream_0)
		{
			object_0 = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return (Stream)smethod_0(object_0);
		}

		internal byte[] method_0(int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal int method_1(byte[] byte_0, int int_0, int int_1)
		{
			return smethod_1(object_0, byte_0, int_0, int_1);
		}

		internal int method_2()
		{
			return smethod_2(object_0);
		}

		internal void method_3()
		{
			smethod_3(object_0);
		}

		internal static object smethod_0(object object_1)
		{
			return ((BinaryReader)object_1).BaseStream;
		}

		internal static int smethod_1(object object_1, object object_2, int int_0, int int_1)
		{
			return ((BinaryReader)object_1).Read((byte[])object_2, int_0, int_1);
		}

		internal static int smethod_2(object object_1)
		{
			return ((BinaryReader)object_1).ReadInt32();
		}

		internal static void smethod_3(object object_1)
		{
			((BinaryReader)object_1).Close();
		}

		static Class28()
		{
			smethod_22();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate5(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate6(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate8(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate9(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate10(IntPtr ptr);

	[Flags]
	private enum Enum9
	{

	}

	private static object object_0;

	private static int int_0;

	private static bool bool_0;

	private static object object_1;

	private static object object_2;

	private static object object_3;

	private static object object_4;

	private static object object_5;

	private static IntPtr intptr_0;

	internal static object object_6;

	private static object object_7;

	internal static object object_8;

	private static bool bool_1;

	private static Dictionary<int, int> dictionary_0;

	internal static object object_9;

	internal static object object_10;

	private static bool bool_2;

	private static long long_0;

	private static int int_1;

	private static object object_11;

	private static object object_12;

	private static bool bool_3;

	private static object object_13;

	private static IntPtr intptr_1;

	private static long long_1;

	private static int int_2;

	private static object object_14;

	private static IntPtr intptr_2;

	private static object object_15;

	private static IntPtr intptr_3;

	private static int int_3;

	[Attribute0(typeof(Attribute0.Class26<object>[]))]
	private static bool bool_4;

	private static object object_16;

	internal static object object_17;

	private static bool bool_5;

	private static object object_18;

	private static bool bool_6;

	static Class25()
	{
		bool_1 = false;
		object_9 = Type.GetTypeFromHandle(Class30.smethod_0(33554505)).Assembly;
		object_0 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bool_3 = false;
		bool_6 = false;
		object_7 = new byte[0];
		object_10 = null;
		dictionary_0 = null;
		object_12 = new object();
		object_16 = new byte[0];
		object_1 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_1 = IntPtr.Zero;
		object_13 = new string[0];
		object_5 = new int[0];
		int_1 = 1;
		bool_2 = false;
		object_11 = new SortedList();
		int_0 = 0;
		long_0 = 0L;
		object_6 = null;
		object_17 = null;
		long_1 = 0L;
		int_2 = 0;
		bool_0 = false;
		bool_5 = false;
		int_3 = 0;
		intptr_2 = IntPtr.Zero;
		bool_4 = false;
		object_8 = new Hashtable();
		object_2 = null;
		object_4 = null;
		object_14 = null;
		object_18 = null;
		object_3 = null;
		object_15 = null;
		intptr_3 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void method_0()
	{
	}

	internal static byte[] smethod_0(object object_19)
	{
		uint[] array = new uint[16];
		int num = 448 - ((Array)object_19).Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(((Array)object_19).Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(((Array)object_19).Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < ((Array)object_19).Length; i++)
		{
			array2[i] = ((byte[])object_19)[i];
		}
		array2[((Array)object_19).Length] |= 128;
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
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void smethod_1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_19)[uint_4] + ((uint[])object_0)[uint_5 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_19)[uint_4] + ((uint[])object_0)[uint_5 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_19)[uint_4] + ((uint[])object_0)[uint_5 - 1], ushort_0);
	}

	private static void smethod_4(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_19)[uint_4] + ((uint[])object_0)[uint_5 - 1], ushort_0);
	}

	private static uint smethod_5(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool smethod_6()
	{
		if (!bool_3)
		{
			smethod_8();
			bool_3 = true;
		}
		return bool_6;
	}

	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_6())
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

	internal static void smethod_8()
	{
		try
		{
			bool_6 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] smethod_9(object object_19)
	{
		if (!smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])object_19);
		}
		return smethod_0(object_19);
	}

	internal static void smethod_10(object object_19, object object_20, uint uint_0, object object_21)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)((Array)object_21).Length) ? ((Array)object_21).Length : ((int)uint_0));
			((Stream)object_20).Read((byte[])object_21, 0, num);
			smethod_11(object_19, object_21, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void smethod_11(object object_19, object object_20, int int_4, int int_5)
	{
		((HashAlgorithm)object_19).TransformBlock((byte[])object_20, int_4, int_5, (byte[]?)object_20, int_4);
	}

	internal static uint smethod_12(uint uint_0, int int_4, long long_2, object object_19)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_4)
			{
				((BinaryReader)object_19).BaseStream.Position = long_2 + (num * 40 + 8);
				uint num2 = ((BinaryReader)object_19).ReadUInt32();
				num3 = ((BinaryReader)object_19).ReadUInt32();
				((BinaryReader)object_19).ReadUInt32();
				num4 = ((BinaryReader)object_19).ReadUInt32();
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

	[Attribute0(typeof(Attribute0.Class26<object>[]))]
	internal static void smethod_13()
	{
		int num = 12;
		string object_3 = default(string);
		string text = default(string);
		HashAlgorithm object_ = default(HashAlgorithm);
		int num20 = default(int);
		int num22 = default(int);
		byte[] array4 = default(byte[]);
		int num27 = default(int);
		int num26 = default(int);
		byte[] array3 = default(byte[]);
		int num25 = default(int);
		int num28 = default(int);
		CryptoStream object_5 = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array5 = default(byte[]);
		byte[] object_7 = default(byte[]);
		SymmetricAlgorithm object_8 = default(SymmetricAlgorithm);
		byte[] object_6 = default(byte[]);
		int num24 = default(int);
		int num30 = default(int);
		int num13 = default(int);
		int num17 = default(int);
		long num14 = default(long);
		int int_ = default(int);
		long long_ = default(long);
		uint uint_2 = default(uint);
		uint num11 = default(uint);
		uint num5 = default(uint);
		uint num7 = default(uint);
		uint num16 = default(uint);
		long num10 = default(long);
		long num8 = default(long);
		uint uint_ = default(uint);
		uint num9 = default(uint);
		long num12 = default(long);
		uint num6 = default(uint);
		byte[] array2 = default(byte[]);
		bool flag2 = default(bool);
		while (object_10 == null)
		{
			while (true)
			{
				smethod_57();
				num = 15;
				while (true)
				{
					smethod_58(bool_7: true);
					int num2 = 10;
					if (smethod_99() != null)
					{
						return;
					}
					while (true)
					{
						switch (num2)
						{
						case 17:
							object_3 = null;
							num2 = 4;
							if (smethod_99() != null)
							{
								continue;
							}
							goto case 4;
						case 16:
							if (text != null)
							{
								num2 = 0;
								if (smethod_99() == null)
								{
									continue;
								}
								goto IL_0036;
							}
							return;
						case 10:
							object_10 = new RSACryptoServiceProvider();
							num2 = 6;
							if (smethod_99() != null)
							{
								continue;
							}
							goto case 6;
						case 6:
							text = (string)smethod_60(smethod_59(typeof(Class25).TypeHandle).Assembly);
							goto case 16;
						default:
							if (smethod_61(text) == 0)
							{
								num2 = 5;
								if (smethod_99() == null)
								{
									continue;
								}
							}
							else
							{
								object_ = null;
								num2 = 17;
								if (smethod_98())
								{
									continue;
								}
							}
							goto IL_0036;
						case 15:
							break;
						case 2:
							goto end_IL_00e4;
						case 12:
							goto end_IL_00f8;
						case 5:
							return;
						case 4:
							try
							{
								object_ = (HashAlgorithm)smethod_62();
								int num19 = 2;
								if (smethod_99() != null)
								{
									num19 = num20;
								}
								switch (num19)
								{
								default:
									goto end_IL_0118;
								case 2:
									object_3 = (string)smethod_63("SHA1");
									num20 = 4;
									break;
								case 4:
									break;
								case 0:
								case 3:
									goto end_IL_0118;
								case 1:
									return;
								}
								if (!smethod_64(text))
								{
									return;
								}
								end_IL_0118:;
							}
							catch
							{
								int num21 = 0;
								if (!smethod_98())
								{
									num21 = num22;
								}
								switch (num21)
								{
								}
								return;
							}
							goto case 14;
						case 14:
							flag2 = false;
							num = 7;
							goto case 7;
						case 7:
							try
							{
								Class28 object_4 = new Class28((Stream)smethod_65(object_9, "o\u0089gwkd\u008bi\u008c13mr\u00989\u0092\u0092\u009f.g0a\u0092h\u0095\u008c\u0087\u0089iu\u0089uoqxlw"));
								int num23 = 205;
								if (!smethod_98())
								{
									goto IL_0227;
								}
								goto IL_1f64;
								IL_1f64:
								while (true)
								{
									switch (num23)
									{
									case 356:
										array4[9] = 156;
										goto case 80;
									case 80:
										array4[9] = 210;
										goto case 11;
									case 11:
										num27 = 142;
										goto case 32;
									case 32:
										array4[10] = (byte)num27;
										goto case 330;
									case 330:
										num27 = 90;
										num24 = 193;
										goto case 193;
									case 193:
										array4[10] = (byte)num27;
										num23 = 130;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 355:
										num26 = 24;
										num23 = 302;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 354:
										num27 = 179;
										goto case 122;
									case 122:
										array4[27] = (byte)num27;
										num23 = 234;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 353:
										num26 = 125;
										num23 = 147;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 352:
										array3[4] = (byte)num25;
										num24 = 158;
										goto case 158;
									case 158:
										array3[4] = 161;
										goto case 34;
									case 34:
										num28 = 130;
										num23 = 210;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 351:
										num25 = 161;
										num23 = 57;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 350:
										array3[11] = (byte)num25;
										num24 = 340;
										goto case 340;
									case 340:
										num25 = 138;
										num23 = 322;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 349:
										array4[13] = (byte)num27;
										goto case 3;
									case 3:
										num26 = 1;
										goto case 60;
									case 60:
										array4[13] = (byte)num26;
										num23 = 55;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 348:
										array4[16] = (byte)num27;
										goto case 33;
									case 33:
										num26 = 193;
										num23 = 200;
										if (!smethod_98())
										{
											continue;
										}
										goto case 244;
									case 244:
										array4[16] = (byte)num26;
										num23 = 144;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 347:
										num27 = 108;
										num23 = 208;
										if (smethod_98())
										{
											continue;
										}
										goto case 16;
									case 16:
										array4[12] = 66;
										goto case 25;
									case 25:
										array4[12] = 44;
										goto case 14;
									case 14:
										array4[12] = 159;
										num23 = 329;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 346:
										array4[25] = (byte)num26;
										num23 = 131;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 345:
										num26 = 154;
										goto case 343;
									case 343:
										array4[4] = (byte)num26;
										goto case 255;
									case 255:
										array4[4] = 96;
										goto case 157;
									case 157:
										num27 = 29;
										num23 = 100;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 77;
									case 77:
										num26 = 134;
										goto case 271;
									case 271:
										array4[5] = (byte)num26;
										goto case 44;
									case 44:
										num27 = 93;
										goto case 30;
									case 30:
										array4[5] = (byte)num27;
										num23 = 27;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 344:
										num26 = 74;
										goto case 74;
									case 74:
										array4[24] = (byte)num26;
										num23 = 141;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 342:
										num28 = 154;
										goto case 248;
									case 248:
										array3[10] = (byte)num28;
										num23 = 291;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 341:
										num26 = 123;
										goto case 92;
									case 92:
										array4[17] = (byte)num26;
										num23 = 298;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 339:
										array4[23] = (byte)num26;
										num24 = 62;
										goto case 62;
									case 62:
										array4[23] = 122;
										num23 = 74;
										if (!smethod_98())
										{
											continue;
										}
										goto case 286;
									case 286:
										array4[23] = 227;
										num23 = 344;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 338:
										array3[14] = 110;
										goto case 86;
									case 86:
										num28 = 156;
										num23 = 300;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 337:
										array4[25] = (byte)num27;
										num23 = 26;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 114;
									case 114:
										num26 = 171;
										num24 = 75;
										goto case 75;
									case 75:
										array4[25] = (byte)num26;
										num24 = 178;
										goto case 178;
									case 178:
										array4[25] = 143;
										goto case 20;
									case 20:
										num26 = 147;
										goto case 346;
									case 336:
										object_5 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
										num24 = 273;
										goto case 273;
									case 273:
										smethod_74(object_5, array5, 0, array5.Length);
										goto case 133;
									case 133:
										smethod_75(object_5);
										num23 = 282;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 335:
										array4[30] = (byte)num27;
										num23 = 160;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 334:
										array4[3] = 136;
										num23 = 15;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 333:
										array4[31] = (byte)num26;
										num24 = 301;
										goto case 301;
									case 301:
										num26 = 140;
										num24 = 280;
										goto case 280;
									case 280:
										array4[31] = (byte)num26;
										num23 = 186;
										if (smethod_98())
										{
											continue;
										}
										goto case 21;
									case 21:
										array4[13] = 138;
										goto case 284;
									case 284:
										num27 = 114;
										num24 = 349;
										goto case 349;
									case 332:
										array3[1] = 124;
										num23 = 223;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 331:
										array3[5] = 170;
										goto case 312;
									case 312:
										array3[5] = 96;
										num23 = 135;
										if (smethod_98())
										{
											continue;
										}
										goto case 71;
									case 71:
										array4[22] = (byte)num26;
										num23 = 115;
										if (smethod_98())
										{
											continue;
										}
										goto case 67;
									case 67:
										array4[16] = (byte)num26;
										goto case 341;
									case 329:
										num26 = 160;
										num23 = 23;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 328:
										array3[13] = (byte)num25;
										num23 = 110;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 327:
										array3[15] = 108;
										goto case 150;
									case 150:
										num25 = 120;
										goto case 241;
									case 241:
										array3[15] = (byte)num25;
										goto case 227;
									case 227:
										num28 = 232;
										goto case 261;
									case 261:
										array3[15] = (byte)num28;
										num24 = 176;
										goto case 176;
									case 176:
										object_7 = array3;
										goto case 103;
									case 103:
										object_8 = (SymmetricAlgorithm)smethod_70();
										goto case 89;
									case 89:
										smethod_71(object_8, CipherMode.CBC);
										goto case 236;
									case 236:
										transform = (ICryptoTransform)smethod_72(object_8, object_6, object_7);
										num24 = 257;
										goto case 257;
									case 257:
										stream = (Stream)smethod_73();
										goto case 336;
									case 326:
										array4[21] = (byte)num26;
										goto case 214;
									case 214:
										array4[21] = 227;
										goto case 99;
									case 99:
										array4[22] = 154;
										goto case 190;
									case 190:
										array4[22] = 164;
										goto case 313;
									case 313:
										num26 = 168;
										goto case 71;
									case 325:
										array4[30] = (byte)num26;
										goto case 13;
									case 13:
										num26 = 86;
										goto case 333;
									case 324:
										array3[9] = 166;
										goto case 212;
									case 212:
										array3[9] = 152;
										num23 = 249;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 292;
									case 292:
										array3[9] = 181;
										num23 = 43;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 323:
										array3[0] = (byte)num25;
										num23 = 237;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 322:
										array3[11] = (byte)num25;
										num23 = 127;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 321:
										array3[7] = 84;
										goto case 64;
									case 64:
										num25 = 144;
										num23 = 219;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 320:
										array4[17] = 194;
										goto case 9;
									case 9:
										array4[18] = 92;
										goto case 26;
									case 26:
										array4[18] = 157;
										num23 = 120;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 319:
										array4[13] = 96;
										goto case 21;
									case 318:
										array4[31] = 200;
										num23 = 59;
										if (smethod_98())
										{
											continue;
										}
										goto case 52;
									case 52:
										array4[19] = (byte)num27;
										num23 = 185;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 317:
										array3[10] = 169;
										goto case 68;
									case 68:
										num25 = 107;
										goto case 350;
									case 316:
										array4[1] = 157;
										goto case 101;
									case 101:
										array4[2] = 119;
										num23 = 22;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 315:
										num27 = 122;
										num23 = 217;
										if (!smethod_98())
										{
											continue;
										}
										goto case 337;
									case 314:
										array4[6] = 116;
										num24 = 228;
										goto case 228;
									case 228:
										array4[6] = 174;
										goto case 294;
									case 294:
										array4[6] = 157;
										num24 = 347;
										goto case 347;
									case 311:
										array3[15] = (byte)num25;
										goto case 259;
									case 259:
										array3[15] = 105;
										num24 = 113;
										goto case 113;
									case 113:
										array3[15] = 146;
										goto case 327;
									case 310:
										num26 = 139;
										num23 = 339;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 309:
										num26 = 130;
										num23 = 180;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 308:
										array4[18] = (byte)num27;
										num23 = 82;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 307:
										array4[2] = 110;
										num23 = 65;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 306:
										num27 = 57;
										goto case 230;
									case 230:
										array4[20] = (byte)num27;
										num23 = 224;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 305:
										num26 = 94;
										goto case 155;
									case 155:
										array4[26] = (byte)num26;
										goto case 94;
									case 94:
										array4[26] = 155;
										num23 = 191;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 57;
									case 57:
										array3[1] = (byte)num25;
										goto case 36;
									case 36:
										array3[1] = 119;
										num23 = 92;
										if (!smethod_98())
										{
											continue;
										}
										goto case 332;
									case 304:
										num27 = 16;
										goto case 90;
									case 90:
										array4[7] = (byte)num27;
										goto case 142;
									case 142:
										array4[7] = 116;
										num23 = 353;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 303:
										array3[5] = 141;
										goto case 331;
									case 302:
										array4[5] = (byte)num26;
										goto case 196;
									case 196:
										array4[6] = 93;
										goto case 174;
									case 174:
										num27 = 110;
										num23 = 268;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 300:
										array3[14] = (byte)num28;
										goto case 129;
									case 129:
										array3[14] = 50;
										num23 = 29;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 13;
									case 299:
										num28 = 218;
										goto case 206;
									case 206:
										array3[6] = (byte)num28;
										goto case 321;
									case 298:
										array4[17] = 144;
										goto case 320;
									case 297:
										num26 = 154;
										num23 = 12;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 296:
										num28 = 110;
										num24 = 137;
										goto case 137;
									case 137:
										array3[12] = (byte)num28;
										goto case 211;
									case 211:
										array3[12] = 17;
										num23 = 174;
										if (!smethod_98())
										{
											continue;
										}
										goto case 207;
									case 207:
										num25 = 132;
										num23 = 132;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 295:
										array3[14] = 69;
										goto case 338;
									case 293:
										array4[24] = (byte)num27;
										goto case 245;
									case 245:
										array4[24] = 38;
										num23 = 315;
										if (smethod_98())
										{
											continue;
										}
										goto case 187;
									case 187:
										num26 = 166;
										goto case 239;
									case 239:
										array4[31] = (byte)num26;
										num23 = 145;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 291:
										num25 = 130;
										num23 = 289;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 290;
									case 290:
										array3[10] = (byte)num25;
										goto case 317;
									case 289:
										num27 = 66;
										num24 = 41;
										goto case 41;
									case 41:
										array4[12] = (byte)num27;
										num24 = 233;
										goto case 233;
									case 233:
										array4[13] = 104;
										num23 = 319;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 288:
										num27 = 122;
										goto case 335;
									case 287:
										num26 = 103;
										goto case 37;
									case 37:
										array4[28] = (byte)num26;
										goto case 128;
									case 128:
										num27 = 81;
										goto case 182;
									case 182:
										array4[28] = (byte)num27;
										goto case 161;
									case 161:
										array4[28] = 123;
										goto case 278;
									case 278:
										num27 = 165;
										num24 = 238;
										goto case 238;
									case 238:
										array4[28] = (byte)num27;
										num23 = 21;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 109;
									case 109:
										num26 = 29;
										num23 = 197;
										if (smethod_98())
										{
											continue;
										}
										goto case 130;
									case 130:
										num27 = 114;
										goto case 243;
									case 243:
										array4[10] = (byte)num27;
										goto case 153;
									case 153:
										array4[10] = 131;
										goto case 203;
									case 203:
										array4[10] = 46;
										goto case 216;
									case 216:
										array4[11] = 183;
										num23 = 105;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 285:
										array4[5] = (byte)num27;
										num24 = 355;
										goto case 355;
									case 283:
										num25 = 180;
										num23 = 9;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 35;
									case 35:
										array3[8] = (byte)num25;
										num23 = 277;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 281:
										array4[30] = (byte)num26;
										goto case 56;
									case 56:
										num26 = 174;
										goto case 325;
									case 279:
										num28 = 115;
										num23 = 47;
										if (!smethod_98())
										{
											continue;
										}
										goto case 126;
									case 126:
										array3[6] = (byte)num28;
										goto case 254;
									case 254:
										array3[6] = 94;
										num23 = 104;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 277:
										num25 = 124;
										num24 = 220;
										goto case 220;
									case 220:
										array3[8] = (byte)num25;
										goto case 166;
									case 166:
										array3[8] = 217;
										num23 = 152;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 275:
										array3[12] = 207;
										num23 = 296;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 4;
									case 4:
										num27 = 157;
										goto case 52;
									case 274:
										array3[5] = (byte)num28;
										goto case 84;
									case 84:
										num25 = 195;
										num23 = 175;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 272:
										array3[6] = (byte)num28;
										num23 = 279;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 270:
										array4[15] = 109;
										num23 = 181;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 269:
										array4[4] = (byte)num26;
										num23 = 126;
										if (!smethod_98())
										{
											continue;
										}
										goto case 140;
									case 140:
										array4[4] = 130;
										goto case 345;
									case 268:
										array4[6] = (byte)num27;
										goto case 314;
									case 267:
										array4[0] = 176;
										num23 = 61;
										if (smethod_98())
										{
											continue;
										}
										goto case 29;
									case 29:
										num25 = 155;
										num23 = 311;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 266:
										array3[0] = (byte)num28;
										goto case 40;
									case 40:
										num25 = 93;
										goto case 151;
									case 151:
										array3[0] = (byte)num25;
										goto case 164;
									case 164:
										num25 = 144;
										goto case 162;
									case 162:
										array3[0] = (byte)num25;
										num23 = 156;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 265:
										num27 = 180;
										goto case 235;
									case 235:
										array4[0] = (byte)num27;
										num23 = 6;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 264:
										array4[29] = (byte)num26;
										goto case 204;
									case 204:
										array4[30] = 94;
										goto case 288;
									case 263:
										num26 = 51;
										num23 = 225;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 262:
										array4[29] = 94;
										goto case 96;
									case 96:
										num27 = 88;
										goto case 169;
									case 169:
										array4[29] = (byte)num27;
										num23 = 81;
										if (smethod_98())
										{
											continue;
										}
										goto case 24;
									case 24:
										num28 = 170;
										num23 = 266;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 260:
										array3[2] = (byte)num25;
										num23 = 154;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 258:
										array3 = new byte[16];
										goto case 24;
									case 256:
										num25 = 86;
										goto case 106;
									case 106:
										array3[9] = (byte)num25;
										goto case 28;
									case 28:
										array3[9] = 107;
										goto case 324;
									case 253:
										num27 = 38;
										goto case 222;
									case 222:
										array4[16] = (byte)num27;
										goto case 46;
									case 46:
										num27 = 86;
										num23 = 348;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 252:
										num27 = 110;
										goto case 251;
									case 251:
										array4[14] = (byte)num27;
										goto case 51;
									case 51:
										array4[14] = 23;
										goto case 143;
									case 143:
										array4[14] = 230;
										num23 = 231;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 250:
										num26 = 144;
										num23 = 192;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 79;
									case 79:
										array3[7] = (byte)num28;
										num23 = 0;
										if (smethod_99() == null)
										{
											continue;
										}
										goto default;
									default:
										num28 = 218;
										num23 = 31;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 249:
										array4[26] = 100;
										num23 = 305;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 246:
										array4[7] = 224;
										goto case 54;
									case 54:
										array4[8] = 108;
										num23 = 124;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 171;
									case 171:
										array4[8] = 194;
										goto case 184;
									case 184:
										array4[8] = 142;
										goto case 49;
									case 49:
										num26 = 139;
										num23 = 221;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 242:
										array4[21] = (byte)num26;
										num24 = 45;
										goto case 45;
									case 45:
										num26 = 84;
										num23 = 326;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 240:
										array4[23] = 134;
										goto case 139;
									case 139:
										array4[23] = 158;
										goto case 310;
									case 237:
										num25 = 108;
										goto case 39;
									case 39:
										array3[0] = (byte)num25;
										num23 = 351;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 335;
									case 234:
										num26 = 136;
										num23 = 102;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 232:
										array4[11] = 91;
										goto case 16;
									case 231:
										array4[15] = 124;
										num24 = 215;
										goto case 215;
									case 215:
										array4[15] = 125;
										num23 = 270;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 229:
										num27 = 136;
										num24 = 293;
										goto case 293;
									case 226:
										array3[7] = 152;
										goto case 136;
									case 136:
										array3[7] = 150;
										num23 = 95;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 12;
									case 12:
										array4[11] = (byte)num26;
										num24 = 250;
										goto case 250;
									case 225:
										array4[19] = (byte)num26;
										num23 = 98;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 224:
										num26 = 134;
										num23 = 242;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 223:
										num25 = 243;
										num23 = 91;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 221:
										array4[8] = (byte)num26;
										goto case 42;
									case 42:
										num26 = 186;
										goto case 183;
									case 183:
										array4[9] = (byte)num26;
										goto case 356;
									case 219:
										array3[7] = (byte)num25;
										num23 = 63;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 218:
										num27 = 149;
										num23 = 37;
										if (!smethod_98())
										{
											continue;
										}
										goto case 38;
									case 38:
										array4[29] = (byte)num27;
										num23 = 262;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 219;
									case 217:
										array4[31] = (byte)num27;
										num23 = 187;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 213:
										array4 = new byte[32];
										goto case 265;
									case 210:
										array3[4] = (byte)num28;
										num23 = 201;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 209:
										array3[6] = (byte)num28;
										num23 = 299;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 208:
										array4[7] = (byte)num27;
										num23 = 71;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 304;
									case 205:
										smethod_67(smethod_66(object_4), 0L);
										goto case 200;
									case 200:
										array5 = (byte[])smethod_69(object_4, (int)smethod_68(smethod_66(object_4)));
										num23 = 213;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 202:
										num25 = 143;
										num23 = 47;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 323;
									case 201:
										array3[4] = 77;
										goto case 125;
									case 125:
										num25 = 160;
										goto case 18;
									case 18:
										array3[5] = (byte)num25;
										goto case 303;
									case 199:
										array4[25] = 109;
										num23 = 5;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 48;
									case 48:
										num27 = 163;
										goto case 2;
									case 2:
										array4[26] = (byte)num27;
										goto case 249;
									case 198:
										array4[18] = (byte)num26;
										goto case 117;
									case 117:
										num26 = 210;
										goto case 118;
									case 118:
										array4[18] = (byte)num26;
										goto case 146;
									case 146:
										num27 = 114;
										num23 = 107;
										if (!smethod_98())
										{
											continue;
										}
										goto case 134;
									case 134:
										array4[18] = (byte)num27;
										num23 = 120;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 159;
									case 159:
										num27 = 96;
										num23 = 308;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 197:
										array4[28] = (byte)num26;
										goto case 218;
									case 195:
										array4[26] = 27;
										num23 = 309;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 89;
									case 194:
										array3[11] = 94;
										goto case 121;
									case 121:
										array3[11] = 164;
										goto case 275;
									case 192:
										array4[11] = (byte)num26;
										num23 = 179;
										if (smethod_98())
										{
											continue;
										}
										goto case 86;
									case 191:
										array4[26] = 113;
										num24 = 195;
										goto case 195;
									case 189:
										array4[3] = 77;
										num23 = 50;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 188:
										array4[20] = 119;
										num23 = 167;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 186:
										num27 = 102;
										goto case 217;
									case 185:
										array4[19] = 183;
										goto case 53;
									case 53:
										array4[19] = 138;
										goto case 263;
									case 181:
										num26 = 107;
										goto case 148;
									case 148:
										array4[15] = (byte)num26;
										goto case 72;
									case 72:
										num26 = 47;
										num23 = 116;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 180:
										array4[27] = (byte)num26;
										goto case 354;
									case 179:
										array4[11] = 127;
										goto case 232;
									case 177:
										array3[10] = (byte)num28;
										num23 = 342;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 175:
										array3[5] = (byte)num25;
										num23 = 47;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 173:
										array4[23] = (byte)num26;
										goto case 240;
									case 172:
										array4[20] = (byte)num26;
										num24 = 188;
										goto case 188;
									case 170:
										num28 = 151;
										num23 = 87;
										if (!smethod_98())
										{
											continue;
										}
										goto case 177;
									case 168:
										array3[3] = (byte)num25;
										goto case 58;
									case 58:
										array3[3] = 130;
										num24 = 108;
										goto case 108;
									case 108:
										num25 = 147;
										goto case 352;
									case 167:
										array4[20] = 137;
										num23 = 306;
										if (smethod_99() == null)
										{
											continue;
										}
										goto case 11;
									case 165:
										num25 = 156;
										num23 = 328;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 160:
										num26 = 117;
										goto case 281;
									case 156:
										array3[0] = 123;
										goto case 202;
									case 154:
										num25 = 154;
										goto case 97;
									case 97:
										array3[3] = (byte)num25;
										goto case 69;
									case 69:
										num25 = 128;
										goto case 112;
									case 112:
										array3[3] = (byte)num25;
										num23 = 149;
										if (smethod_98())
										{
											continue;
										}
										goto case 113;
									case 152:
										array3[9] = 161;
										num23 = 256;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 149:
										array3[3] = 191;
										goto case 17;
									case 17:
										num25 = 134;
										num23 = 168;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 147:
										array4[7] = (byte)num26;
										goto case 246;
									case 145:
										array4[31] = 136;
										goto case 318;
									case 144:
										num26 = 145;
										goto case 67;
									case 141:
										array4[24] = 124;
										goto case 229;
									case 138:
										array4[22] = (byte)num27;
										num23 = 83;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 135:
										num28 = 139;
										num24 = 274;
										goto case 274;
									case 132:
										array3[13] = (byte)num25;
										goto case 70;
									case 70:
										array3[13] = 76;
										num23 = 165;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 131:
										array4[25] = 198;
										num23 = 199;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 127:
										array3[11] = 151;
										goto case 194;
									case 124:
										array4[19] = 79;
										goto case 4;
									case 123:
										array3[2] = (byte)num25;
										num23 = 7;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 120:
										num26 = 71;
										num24 = 198;
										goto case 198;
									case 119:
										array3[2] = (byte)num25;
										num24 = 111;
										goto case 111;
									case 111:
										array3[2] = 83;
										num23 = 1;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 116:
										array4[15] = (byte)num26;
										goto case 253;
									case 115:
										num27 = 24;
										goto case 138;
									case 110:
										array3[13] = 240;
										goto case 295;
									case 107:
										num26 = 161;
										num23 = 172;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 105:
										array4[11] = 88;
										goto case 297;
									case 104:
										num28 = 150;
										num23 = 116;
										if (!smethod_98())
										{
											continue;
										}
										goto case 209;
									case 102:
										array4[27] = (byte)num26;
										num24 = 287;
										goto case 287;
									case 100:
										array4[4] = (byte)num27;
										goto case 77;
									case 98:
										num27 = 94;
										goto case 19;
									case 19:
										array4[20] = (byte)num27;
										num23 = 107;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 95:
										array3[8] = 215;
										num23 = 283;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 93:
										array4[1] = (byte)num27;
										num23 = 5;
										if (smethod_98())
										{
											continue;
										}
										goto case 5;
									case 5:
										array4[1] = 60;
										num23 = 87;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 91:
										array3[1] = (byte)num25;
										goto case 76;
									case 76:
										array3[2] = 157;
										num24 = 66;
										goto case 66;
									case 66:
										num25 = 123;
										num24 = 119;
										goto case 119;
									case 88:
										num25 = 156;
										goto case 123;
									case 87:
										array4[1] = 52;
										goto case 78;
									case 78:
										array4[1] = 168;
										goto case 316;
									case 83:
										num26 = 220;
										goto case 173;
									case 82:
										array4[19] = 220;
										goto case 124;
									case 81:
										num26 = 179;
										goto case 264;
									case 73:
										array4[3] = (byte)num26;
										num23 = 334;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 65:
										array4[2] = 148;
										goto case 8;
									case 8:
										num26 = 179;
										num23 = 73;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									case 63:
										num28 = 125;
										goto case 79;
									case 61:
										num27 = 162;
										goto case 93;
									case 59:
										object_6 = array4;
										goto case 258;
									case 55:
										array4[14] = 207;
										num24 = 252;
										goto case 252;
									case 50:
										num26 = 156;
										goto case 269;
									case 47:
										num28 = 121;
										num23 = 272;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 43:
										array3[10] = 115;
										goto case 10;
									case 10:
										array3[10] = 44;
										num23 = 144;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 170;
									case 31:
										array3[7] = (byte)num28;
										goto case 226;
									case 27:
										num27 = 228;
										num23 = 264;
										if (!smethod_98())
										{
											continue;
										}
										goto case 285;
									case 23:
										array4[12] = (byte)num26;
										goto case 289;
									case 22:
										array4[2] = 84;
										num23 = 307;
										if (smethod_98())
										{
											continue;
										}
										break;
									case 15:
										array4[3] = 130;
										num23 = 51;
										if (smethod_99() != null)
										{
											continue;
										}
										goto case 189;
									case 7:
										num25 = 204;
										num24 = 260;
										goto case 260;
									case 6:
										array4[0] = 91;
										goto case 267;
									case 1:
										array3[2] = 123;
										num24 = 88;
										goto case 88;
									case 282:
										smethod_79(object_10, smethod_78(smethod_76(), smethod_77(stream)));
										goto case 276;
									case 276:
										smethod_80(stream);
										goto case 247;
									case 247:
										smethod_80(object_5);
										goto case 163;
									case 163:
										smethod_81(object_4);
										goto end_IL_1f64;
									case 85:
										goto end_IL_1f64;
									}
									goto IL_0227;
									continue;
									end_IL_1f64:
									break;
								}
								goto end_IL_019d;
								IL_0227:
								num23 = num24;
								goto IL_1f64;
								end_IL_019d:;
							}
							catch
							{
								int num29 = 1;
								if (!smethod_98())
								{
									num29 = num30;
								}
								while (true)
								{
									switch (num29)
									{
									case 1:
										flag2 = true;
										num29 = 0;
										if (smethod_99() != null)
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
							goto case 1;
						case 1:
							if (!flag2)
							{
								goto case 13;
							}
							goto case 9;
						case 13:
							try
							{
								FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
								while (true)
								{
									BinaryReader object_2 = new BinaryReader(fileStream);
									while (true)
									{
										byte[] array = new byte[65536];
										while (true)
										{
											smethod_82(object_, fileStream, 152u, array);
											int num3 = 52;
											while (true)
											{
												IL_2afe:
												bool flag = smethod_83(object_2) != 523;
												int num4 = 57;
												if (!smethod_98())
												{
													goto IL_283c;
												}
												goto IL_29cc;
												IL_29cc:
												while (true)
												{
													int num15;
													switch (num4)
													{
													case 14:
													case 73:
														if (num13 >= num17)
														{
															num4 = 32;
															if (smethod_99() == null)
															{
																continue;
															}
															goto case 32;
														}
														goto case 20;
													case 32:
														smethod_90(object_, new byte[0], 0, 0);
														num4 = 40;
														if (smethod_98())
														{
															continue;
														}
														goto IL_25e2;
													case 20:
														smethod_67(fileStream, num14 + num13 * 40 + 16L);
														num4 = 68;
														if (smethod_98())
														{
															continue;
														}
														goto IL_25e2;
													case 21:
													case 72:
														smethod_67(fileStream, 376L);
														num4 = 47;
														if (smethod_99() == null)
														{
															continue;
														}
														goto case 24;
													case 24:
														smethod_85(object_, array, 0, int_);
														num4 = 42;
														if (!smethod_98())
														{
															continue;
														}
														goto case 59;
													case 59:
														smethod_84(fileStream, array, 0, 128);
														goto case 44;
													case 44:
														array[32] = 0;
														num4 = 8;
														if (smethod_99() == null)
														{
															continue;
														}
														goto IL_25e2;
													case 71:
														smethod_85(object_, array, 0, 128);
														goto case 5;
													case 5:
														num14 = smethod_86(fileStream);
														goto case 43;
													case 43:
														smethod_67(fileStream, 134L);
														goto case 38;
													case 38:
														num17 = smethod_83(object_2);
														goto case 34;
													case 34:
														smethod_67(fileStream, num14);
														goto case 27;
													case 27:
														smethod_82(object_, fileStream, (uint)(num17 * 40), array);
														goto case 63;
													case 63:
														long_ = smethod_86(fileStream);
														goto case 35;
													case 35:
														if (!flag)
														{
															num4 = 72;
															if (smethod_98())
															{
																continue;
															}
															goto IL_25e2;
														}
														goto case 15;
													case 15:
														smethod_67(fileStream, 360L);
														goto case 47;
													case 47:
													case 65:
														uint_2 = smethod_87(object_2);
														goto case 70;
													case 70:
														num11 = smethod_88(uint_2, num17, num14, object_2);
														num4 = 51;
														if (smethod_99() == null)
														{
															continue;
														}
														goto IL_25e2;
													case 68:
														num5 = smethod_87(object_2);
														goto case 61;
													case 61:
														num7 = smethod_87(object_2);
														num4 = 37;
														if (smethod_98())
														{
															continue;
														}
														goto IL_25e2;
													case 67:
														smethod_82(object_, fileStream, num16, array);
														goto case 48;
													case 48:
														num5 -= num16;
														goto case 11;
													case 16:
													case 29:
														num10 = smethod_86(fileStream);
														num4 = 46;
														if (smethod_98())
														{
															continue;
														}
														goto case 11;
													case 11:
													case 26:
													case 42:
														if (num5 != 0)
														{
															goto case 16;
														}
														goto case 6;
													case 6:
													case 49:
														num13++;
														num3 = 73;
														goto case 14;
													case 66:
														num8 = smethod_88(uint_, num17, num14, object_2);
														num4 = 53;
														if (smethod_99() == null)
														{
															continue;
														}
														goto IL_25e2;
													case 64:
														num9 = smethod_87(object_2);
														goto case 66;
													case 62:
														smethod_82(object_, fileStream, num5, array);
														goto case 6;
													case 60:
														if (num10 < num12)
														{
															goto case 28;
														}
														goto case 41;
													case 28:
														num6 = (uint)(num12 - num10);
														num4 = 56;
														if (smethod_98())
														{
															continue;
														}
														goto IL_25e2;
													case 41:
														if (num10 >= num12)
														{
															goto case 62;
														}
														goto case 22;
													case 22:
														num16 = (uint)smethod_89(num8 - num10, num5);
														num3 = 67;
														goto case 67;
													case 58:
														num15 = 96;
														goto IL_27ef;
													case 57:
														if (flag)
														{
															goto case 58;
														}
														goto case 9;
													case 9:
														num15 = 112;
														goto IL_27ef;
													case 56:
														if (num6 < num5)
														{
															num4 = 1;
															if (smethod_99() == null)
															{
																continue;
															}
															goto IL_25e2;
														}
														goto case 6;
													case 55:
														smethod_67(fileStream, 152L);
														break;
													case 36:
														break;
													case 33:
														goto IL_2849;
													case 7:
														goto IL_2858;
													case 2:
														goto IL_285e;
													case 54:
														flag2 = !smethod_94(object_10, smethod_93(object_), object_3, array2);
														num4 = 1;
														if (!smethod_98())
														{
															continue;
														}
														goto end_IL_2b4f;
													case 53:
														num12 = num8 + num9;
														goto case 23;
													case 23:
														smethod_67(fileStream, long_);
														goto case 3;
													case 3:
														num13 = 0;
														num3 = 14;
														goto case 14;
													case 51:
														smethod_67(fileStream, num11 + 32);
														goto case 10;
													case 10:
														uint_ = smethod_87(object_2);
														goto case 64;
													case 50:
														smethod_67(fileStream, smethod_86(fileStream) + num6);
														goto case 11;
													case 46:
														if (num8 <= num10)
														{
															goto case 60;
														}
														goto case 41;
													case 40:
														smethod_67(fileStream, num8);
														goto case 17;
													case 17:
														array2 = (byte[])smethod_91(object_2, (int)num9);
														goto case 19;
													case 19:
														smethod_92(array2);
														num4 = 54;
														if (smethod_99() == null)
														{
															continue;
														}
														goto IL_25e2;
													case 39:
														array[37] = 0;
														goto case 30;
													case 30:
														array[38] = 0;
														goto case 4;
													case 4:
														array[39] = 0;
														num4 = 71;
														if (smethod_98())
														{
															continue;
														}
														goto IL_25e2;
													case 37:
														smethod_67(fileStream, num7);
														num3 = 42;
														goto case 11;
													case 31:
														array[36] = 0;
														num3 = 39;
														goto case 39;
													case 25:
														array[34] = 0;
														goto case 12;
													case 12:
														array[35] = 0;
														goto case 31;
													case 8:
														array[33] = 0;
														goto case 25;
													case 1:
														num5 -= num6;
														num4 = 34;
														if (smethod_99() != null)
														{
															continue;
														}
														goto case 50;
													default:
														array[67] = 0;
														num4 = 24;
														if (smethod_98())
														{
															continue;
														}
														goto case 19;
													case 52:
														goto IL_2afe;
													case 13:
														goto end_IL_2afe;
													case 45:
														goto end_IL_2b26;
													case 69:
														goto end_IL_2b41;
													case 18:
														goto end_IL_2b4f;
														IL_27ef:
														int_ = num15;
														num4 = 55;
														if (smethod_99() == null)
														{
															continue;
														}
														goto IL_25e2;
													}
													break;
												}
												goto IL_283c;
												IL_283c:
												smethod_84(fileStream, array, 0, int_);
												goto IL_2849;
												IL_2849:
												array[64] = 0;
												num3 = 7;
												goto IL_2858;
												IL_2858:
												array[65] = 0;
												goto IL_285e;
												IL_285e:
												array[66] = 0;
												num4 = 0;
												if (!smethod_98())
												{
													goto IL_25e2;
												}
												goto IL_29cc;
												IL_25e2:
												num4 = num3;
												goto IL_29cc;
												continue;
												end_IL_2afe:
												break;
											}
											continue;
											end_IL_2b26:
											break;
										}
										continue;
										end_IL_2b41:
										break;
									}
									continue;
									end_IL_2b4f:
									break;
								}
							}
							catch
							{
								int num18 = 1;
								if (smethod_98())
								{
									while (true)
									{
										switch (num18)
										{
										case 1:
											flag2 = true;
											num18 = 0;
											if (smethod_98())
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
							}
							goto case 9;
						case 9:
							if (!flag2)
							{
								flag2 = false;
								return;
							}
							goto case 8;
						case 8:
							throw new Exception((string?)smethod_97(smethod_96(smethod_95(smethod_59(typeof(Class25).TypeHandle).Assembly)), " is tampered."));
						case 3:
						case 11:
							return;
							IL_0036:
							num2 = num;
							continue;
						}
						break;
					}
					continue;
					end_IL_00e4:
					break;
				}
				continue;
				end_IL_00f8:
				break;
			}
		}
	}

	public static void smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (dictionary_0 == null)
			{
				lock (object_12)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(Class30.smethod_0(33554505)).Assembly.GetManifestResourceStream("lv\u0088df\u0099\u0091\u0092\u0091\u0086tcpio90n.\u009ag\u008c\u008bc\u008f\u0092q\u008a\u009d\u0095\u0086\u0097\u0097\u00953n\u0093"));
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
							num10 ^= num10 << 1;
							num10 += 4052235136u;
							num10 ^= num10 >> 27;
							num10 += 2298058292u;
							num10 ^= num10 << 27;
							num10 += 2374016581u;
							num10 = 3124738051u - num10;
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
						Class28 @class = new Class28(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = @class.method_2();
							int value = @class.method_2();
							dictionary.Add(key, value);
						}
						@class.method_3();
					}
					dictionary_0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num14 = dictionary_0[metadataToken];
				bool flag = (num14 & 0x40000000) > 0;
				num14 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(Class30.smethod_0(33554505)).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(Class30.smethod_0(16777238));
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

	internal static void smethod_15()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[Attribute0(typeof(Attribute0.Class26<object>[]))]
	internal static string smethod_16(int int_4)
	{
		int num = 345;
		string result = default(string);
		int int_5 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num9 = default(int);
		uint num11 = default(uint);
		int num12 = default(int);
		int num7 = default(int);
		uint num13 = default(uint);
		uint num14 = default(uint);
		int num23 = default(int);
		byte[] array3 = default(byte[]);
		int num24 = default(int);
		byte[] array7 = default(byte[]);
		uint num21 = default(uint);
		uint num16 = default(uint);
		int num17 = default(int);
		int num18 = default(int);
		int num8 = default(int);
		int num28 = default(int);
		int num19 = default(int);
		byte[] array4 = default(byte[]);
		int num27 = default(int);
		byte[] array5 = default(byte[]);
		CryptoStream object_3 = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array6 = default(byte[]);
		int num20 = default(int);
		uint num15 = default(uint);
		uint num10 = default(uint);
		Class28 object_2 = default(Class28);
		uint num22 = default(uint);
		SymmetricAlgorithm object_ = default(SymmetricAlgorithm);
		while (true)
		{
			int num2;
			if (((Array)object_16).Length == 0)
			{
				num2 = 344;
				if (smethod_56() != null)
				{
					goto IL_0050;
				}
				goto IL_2345;
			}
			goto IL_2a2c;
			IL_2a39:
			try
			{
				smethod_52();
				int num3 = 1;
				if (smethod_56() == null)
				{
					goto IL_2a4c;
				}
				goto IL_2a6e;
				IL_2a6e:
				switch (num3)
				{
				case 1:
					break;
				default:
					return result;
				case 0:
					return result;
				}
				goto IL_2a4c;
				IL_2a4c:
				result = (string)smethod_54(smethod_53(), object_16, int_4 + 4, int_5);
				num3 = 0;
				if (!smethod_55())
				{
					return result;
				}
				goto IL_2a6e;
			}
			catch
			{
				int num4 = 0;
				if (!smethod_55())
				{
					num4 = num5;
				}
				switch (num4)
				{
				}
			}
			break;
			IL_2345:
			while (true)
			{
				switch (num2)
				{
				case 433:
					num6 = 104;
					goto case 100;
				case 100:
					array2[1] = (byte)num6;
					goto case 57;
				case 57:
					array2[1] = 122;
					num2 = 363;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 432:
					array[23] = 170;
					num2 = 45;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 431:
					array2[3] = 68;
					goto case 30;
				case 30:
					array2[3] = 236;
					goto case 11;
				case 11:
					array2[4] = 104;
					num2 = 320;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 430:
					if (num9 > 0)
					{
						goto case 174;
					}
					goto case 206;
				case 174:
					num11 = 0u;
					num2 = 111;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 8;
				case 8:
					array[15] = (byte)num12;
					goto case 377;
				case 377:
					num12 = 194;
					num2 = 139;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 205;
				case 205:
					array[15] = (byte)num12;
					goto case 342;
				case 342:
					num7 = 152;
					goto case 97;
				case 97:
					array[16] = (byte)num7;
					goto case 336;
				case 336:
					array[16] = 143;
					goto case 6;
				case 6:
					array[16] = 116;
					goto case 186;
				case 186:
					num7 = 149;
					goto case 118;
				case 118:
					array[16] = (byte)num7;
					num2 = 295;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 206:
					num13 += num14;
					goto case 343;
				case 343:
					num10 = (uint)num23;
					num2 = 21;
					if (!smethod_55())
					{
						continue;
					}
					goto case 115;
				case 115:
					num11 = (uint)((array3[num10 + 3] << 24) | (array3[num10 + 2] << 16) | (array3[num10 + 1] << 8) | array3[num10]);
					num2 = 21;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 429:
					array[3] = (byte)num7;
					num2 = 292;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 245:
					if (num24 > 0)
					{
						num2 = 211;
						if (smethod_56() == null)
						{
							continue;
						}
						goto IL_0050;
					}
					goto case 33;
				case 33:
					array7[num23 + num24] = (byte)((num21 & num16) >> num17);
					goto case 152;
				case 152:
					num24++;
					goto case 321;
				case 321:
				case 428:
					if (num24 < num9)
					{
						goto case 245;
					}
					num = 71;
					goto case 71;
				case 71:
				case 331:
					num18++;
					goto case 83;
				case 83:
				case 407:
					if (num18 < num8)
					{
						goto case 287;
					}
					goto case 294;
				case 287:
					num28 = num18 % num19;
					goto case 127;
				case 127:
					num23 = num18 * 4;
					goto case 72;
				case 72:
					num10 = (uint)(num28 * 4);
					num2 = 243;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 427:
					array[2] = (byte)num7;
					goto case 352;
				case 352:
					num7 = 112;
					goto case 429;
				case 426:
					array[11] = (byte)num12;
					num = 10;
					goto case 10;
				case 10:
					array[11] = 142;
					num2 = 170;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 425:
					array[7] = (byte)num7;
					num2 = 412;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 424:
					num7 = 114;
					num2 = 15;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 423:
					num7 = 72;
					goto case 239;
				case 239:
					array[14] = (byte)num7;
					num2 = 80;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 240;
				case 240:
					array[15] = 208;
					num2 = 87;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 225:
					array4[num27] = (byte)(array4[num27] ^ array5[num27]);
					goto case 235;
				case 235:
					num27++;
					num2 = 47;
					if (!smethod_55())
					{
						continue;
					}
					goto case 68;
				case 68:
				case 422:
					if (num27 < array5.Length)
					{
						goto case 225;
					}
					num2 = 374;
					if (smethod_55())
					{
						continue;
					}
					goto case 128;
				case 128:
					array[18] = (byte)num7;
					goto case 153;
				case 153:
					array[19] = 7;
					goto case 212;
				case 212:
					num7 = 111;
					goto case 75;
				case 75:
					array[19] = (byte)num7;
					num2 = 290;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 421:
					array[26] = (byte)num12;
					num2 = 204;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 420:
					object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 182;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 419:
					num6 = 223;
					goto case 121;
				case 121:
					array2[13] = (byte)num6;
					goto case 315;
				case 315:
					num6 = 86;
					num2 = 403;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 418:
					num6 = 170;
					goto case 42;
				case 42:
					array2[5] = (byte)num6;
					num2 = 249;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 417:
					array[12] = (byte)num12;
					goto case 7;
				case 7:
					num7 = 221;
					goto case 16;
				case 16:
					array[12] = (byte)num7;
					goto case 410;
				case 410:
					array[12] = 106;
					goto case 314;
				case 314:
					array[12] = 150;
					goto case 109;
				case 109:
					array[12] = 168;
					num2 = 341;
					if (smethod_55())
					{
						continue;
					}
					goto case 49;
				case 49:
					array[17] = 166;
					num = 130;
					goto case 130;
				case 130:
					array[17] = 149;
					num2 = 118;
					if (!smethod_55())
					{
						continue;
					}
					goto case 399;
				case 399:
					array[18] = 117;
					goto case 356;
				case 356:
					num12 = 150;
					num2 = 355;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 416:
					array[5] = (byte)num12;
					num2 = 192;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 415:
					num12 = 14;
					num2 = 78;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 414:
					array[30] = (byte)num7;
					num2 = 263;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 213;
				case 213:
					num7 = 159;
					goto case 128;
				case 413:
					num6 = 211;
					num = 365;
					goto case 365;
				case 365:
					array2[4] = (byte)num6;
					goto case 61;
				case 61:
					num6 = 33;
					num2 = 308;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 412:
					array[8] = 115;
					num2 = 132;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 411:
					num12 = 138;
					goto case 46;
				case 46:
					array[3] = (byte)num12;
					num2 = 379;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 409:
					array5[11] = array6[5];
					goto case 405;
				case 405:
					array5[13] = array6[6];
					goto case 307;
				case 307:
					array5[15] = array6[7];
					goto case 4;
				case 4:
				case 256:
					num27 = 0;
					num2 = 422;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 322:
					if (num20 > 0)
					{
						goto case 277;
					}
					goto case 201;
				case 277:
					num11 <<= 8;
					num2 = 91;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 201;
				case 201:
					num11 |= array3[^(1 + num20)];
					goto case 162;
				case 162:
					num20++;
					goto case 194;
				case 194:
				case 408:
					if (num20 < num9)
					{
						goto case 322;
					}
					num2 = 123;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 69;
				case 69:
					array2[12] = (byte)num6;
					goto case 145;
				case 145:
					num6 = 148;
					goto case 113;
				case 113:
					array2[12] = (byte)num6;
					goto case 23;
				case 23:
					array2[12] = 93;
					num2 = 0;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 406:
					array[14] = (byte)num7;
					goto case 193;
				case 193:
					num7 = 170;
					num2 = 18;
					if (!smethod_55())
					{
						continue;
					}
					goto case 28;
				case 28:
					array[14] = (byte)num7;
					num2 = 423;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 11;
				case 404:
					num7 = 119;
					num = 327;
					goto case 327;
				case 327:
					array[11] = (byte)num7;
					goto case 227;
				case 227:
					array[11] = 200;
					num2 = 129;
					if (smethod_55())
					{
						continue;
					}
					goto case 11;
				case 403:
					array2[13] = (byte)num6;
					num2 = 138;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 21;
				case 21:
				case 123:
					num15 = num13;
					goto case 261;
				case 261:
					num13 = 0u;
					goto case 269;
				case 269:
				{
					uint num25 = num15;
					uint num26 = num15;
					num26 ^= num26 << 1;
					num26 += 4052235136u;
					num26 ^= num26 >> 27;
					num26 += 2298058292u;
					num26 ^= num26 << 27;
					num26 += 2374016581u;
					num26 = 3124738051u - num26;
					num15 = num25 + (uint)(double)num26;
					num2 = 185;
					if (smethod_55())
					{
						continue;
					}
					goto case 66;
				}
				case 66:
					num12 = 128;
					num2 = 134;
					if (!smethod_55())
					{
						continue;
					}
					goto case 181;
				case 181:
					array[1] = (byte)num12;
					goto case 56;
				case 56:
					num7 = 132;
					goto case 79;
				case 79:
					array[1] = (byte)num7;
					num2 = 350;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 402:
					array[7] = 131;
					goto case 37;
				case 37:
					num7 = 132;
					goto case 252;
				case 252:
					array[7] = (byte)num7;
					num2 = 251;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 401:
					num6 = 70;
					goto case 187;
				case 187:
					array2[8] = (byte)num6;
					num2 = 131;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 400:
					array[28] = 88;
					num = 253;
					goto case 253;
				case 253:
					num7 = 63;
					goto case 298;
				case 298:
					array[28] = (byte)num7;
					num2 = 303;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 397:
					num7 = 87;
					num = 390;
					goto case 390;
				case 390:
					array[14] = (byte)num7;
					num2 = 19;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 202;
				case 202:
					num7 = 104;
					num2 = 406;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 396:
					num8++;
					goto case 214;
				case 214:
					num10 = 0u;
					goto case 2;
				case 2:
					num18 = 0;
					goto case 83;
				case 395:
					array[29] = 195;
					num2 = 285;
					if (smethod_55())
					{
						continue;
					}
					goto case 97;
				case 394:
					array2[3] = (byte)num6;
					num2 = 431;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 365;
				case 393:
					array = new byte[32];
					num2 = 161;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 392:
					array2[2] = (byte)num6;
					goto case 223;
				case 223:
					array2[3] = 106;
					num2 = 90;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 31;
				case 31:
					num6 = 112;
					num2 = 88;
					if (!smethod_55())
					{
						continue;
					}
					goto case 149;
				case 149:
					array2[4] = (byte)num6;
					num2 = 413;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 391:
					array[4] = (byte)num12;
					num = 266;
					goto case 266;
				case 266:
					num7 = 213;
					num = 208;
					goto case 208;
				case 208:
					array[4] = (byte)num7;
					num2 = 50;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 389:
					array[22] = 153;
					goto case 273;
				case 273:
					array[22] = 142;
					goto case 155;
				case 155:
					num7 = 201;
					num2 = 104;
					if (!smethod_55())
					{
						continue;
					}
					goto case 150;
				case 150:
					array[22] = (byte)num7;
					num = 254;
					goto case 254;
				case 254:
					num7 = 252;
					goto case 94;
				case 94:
					array[22] = (byte)num7;
					num2 = 332;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 388:
					array[27] = (byte)num7;
					goto case 400;
				case 387:
					array[23] = (byte)num7;
					goto case 432;
				case 386:
					array[20] = 107;
					num2 = 58;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 385:
					array[13] = (byte)num12;
					num2 = 41;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 384:
					num12 = 134;
					goto case 166;
				case 166:
					array[2] = (byte)num12;
					goto case 348;
				case 348:
					array[2] = 106;
					num2 = 151;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 68;
				case 383:
					array[0] = 21;
					goto case 140;
				case 140:
					array[0] = 137;
					goto case 85;
				case 85:
					num12 = 220;
					goto case 301;
				case 301:
					array[0] = (byte)num12;
					goto case 66;
				case 382:
					object_16 = smethod_49(stream);
					goto case 229;
				case 229:
					smethod_50(stream);
					goto case 293;
				case 293:
					smethod_50(object_3);
					num2 = 230;
					if (smethod_55())
					{
						continue;
					}
					goto case 147;
				case 147:
					array[30] = 130;
					goto case 311;
				case 311:
					num7 = 114;
					goto case 414;
				case 381:
					array[20] = (byte)num7;
					goto case 74;
				case 74:
					num7 = 105;
					goto case 18;
				case 18:
					array[20] = (byte)num7;
					goto case 386;
				case 380:
					num6 = 144;
					num2 = 278;
					if (smethod_55())
					{
						continue;
					}
					goto case 55;
				case 55:
					array[20] = (byte)num12;
					goto case 126;
				case 126:
					num7 = 7;
					num2 = 381;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 379:
					array[3] = 129;
					num2 = 73;
					if (smethod_55())
					{
						continue;
					}
					goto case 58;
				case 58:
					num7 = 81;
					goto case 274;
				case 274:
					array[20] = (byte)num7;
					num2 = 49;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 340;
				case 340:
					array[21] = 98;
					num2 = 20;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 378:
					array2[13] = 61;
					goto case 286;
				case 286:
					num6 = 132;
					goto case 370;
				case 370:
					array2[14] = (byte)num6;
					num2 = 163;
					if (smethod_55())
					{
						continue;
					}
					goto case 139;
				case 139:
					array2[0] = (byte)num6;
					num2 = 280;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 376:
					num17 = 0;
					num2 = 142;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 180;
				case 180:
					if (num18 == num8 - 1)
					{
						num2 = 430;
						if (smethod_55())
						{
							continue;
						}
						goto IL_0050;
					}
					goto case 206;
				case 375:
					array[8] = 1;
					num2 = 281;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 374:
					if (int_4 == -1)
					{
						num2 = 24;
						if (smethod_55())
						{
							continue;
						}
						goto case 12;
					}
					goto case 233;
				case 12:
					array2[15] = 94;
					goto case 368;
				case 368:
					num6 = 150;
					num2 = 346;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 233:
					num9 = array3.Length % 4;
					num2 = 35;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 373:
					array2 = new byte[16];
					num2 = 311;
					if (!smethod_55())
					{
						continue;
					}
					goto case 347;
				case 347:
					num6 = 84;
					goto case 139;
				case 372:
					num6 = 29;
					goto case 67;
				case 67:
					array2[15] = (byte)num6;
					goto case 160;
				case 160:
					array5 = array2;
					num2 = 236;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 369:
					array2[9] = 175;
					num2 = 250;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 246;
				case 246:
					num6 = 108;
					num2 = 91;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 367:
					array2[11] = (byte)num6;
					num2 = 305;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 366:
					array[9] = (byte)num12;
					goto case 14;
				case 14:
					num12 = 47;
					goto case 354;
				case 354:
					array[9] = (byte)num12;
					num2 = 300;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 364:
					array[24] = (byte)num12;
					goto case 424;
				case 363:
					num6 = 116;
					num2 = 279;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 361;
				case 361:
					array2[1] = (byte)num6;
					num2 = 237;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 362:
					array4 = array;
					goto case 373;
				case 360:
					array6 = (byte[])smethod_42(smethod_41(object_9));
					num2 = 297;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 359:
					num12 = 151;
					num2 = 55;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 358:
					array2[2] = 227;
					num2 = 380;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 44;
				case 44:
					array[13] = 114;
					num2 = 148;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 357:
					array2[14] = (byte)num6;
					num2 = 252;
					if (!smethod_55())
					{
						continue;
					}
					goto case 349;
				case 349:
					num6 = 240;
					num2 = 144;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 355:
					array[18] = (byte)num12;
					num2 = 120;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 353:
					num6 = 88;
					num2 = 69;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 351:
					num6 = 165;
					goto case 110;
				case 110:
					array2[13] = (byte)num6;
					num2 = 419;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 27;
				case 27:
					array[31] = (byte)num7;
					num2 = 362;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 10;
				case 350:
					array[1] = 90;
					num2 = 259;
					if (!smethod_55())
					{
						continue;
					}
					goto case 384;
				case 346:
					array2[15] = (byte)num6;
					num = 372;
					goto case 372;
				case 344:
					object_2 = new Class28((Stream)smethod_34(object_9, "hex1s\u008a\u0087\u009fgwc4\u0098\u0091\u008b1\u009a\u0098.\u008a\u009cs\u009acn\u0088\u009bq3\u008d\u009c\u009c\u0096i\u008cbc"));
					goto case 167;
				case 167:
					smethod_36(smethod_35(object_2), 0L);
					num2 = 104;
					if (smethod_55())
					{
						continue;
					}
					goto case 16;
				case 341:
					array[12] = 196;
					num = 329;
					goto case 329;
				case 329:
					array[13] = 111;
					goto case 141;
				case 141:
					num7 = 119;
					num2 = 265;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 339:
					array[3] = (byte)num12;
					goto case 411;
				case 338:
					array2[9] = (byte)num6;
					goto case 135;
				case 135:
					num6 = 162;
					num2 = 199;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 106;
				case 106:
					array2[8] = 149;
					goto case 328;
				case 328:
					array2[8] = 232;
					goto case 154;
				case 154:
					array2[8] = 88;
					goto case 29;
				case 29:
					num6 = 164;
					num2 = 272;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 337:
					array[24] = (byte)num7;
					goto case 17;
				case 17:
					num12 = 97;
					num2 = 262;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 335:
					num7 = 68;
					goto case 107;
				case 107:
					array[11] = (byte)num7;
					num2 = 1;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 334:
					num6 = 88;
					goto case 306;
				case 306:
					array2[6] = (byte)num6;
					goto case 209;
				case 209:
					array2[6] = 48;
					goto case 176;
				case 176:
					array2[7] = 130;
					num2 = 184;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 333:
					num24 = 0;
					num2 = 428;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 40;
				case 40:
					array2[0] = (byte)num6;
					goto case 296;
				case 296:
					array2[0] = 173;
					num2 = 271;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 215;
				case 215:
					array2[9] = (byte)num6;
					num2 = 171;
					if (smethod_55())
					{
						continue;
					}
					goto case 89;
				case 89:
					num12 = 76;
					goto case 242;
				case 242:
					array[29] = (byte)num12;
					goto case 34;
				case 34:
					array[29] = 166;
					goto case 395;
				case 332:
					num12 = 84;
					num2 = 124;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 330:
					num6 = 204;
					num2 = 80;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 326:
					array[27] = 51;
					num2 = 93;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 325:
					num6 = 130;
					num2 = 77;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 324:
					num6 = 154;
					goto case 215;
				case 323:
					array[2] = 159;
					num2 = 179;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 320:
					array2[4] = 177;
					num2 = 9;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 319:
					array2[7] = 90;
					goto case 178;
				case 178:
					array2[7] = 52;
					goto case 158;
				case 158:
					num6 = 118;
					num2 = 60;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 241;
				case 241:
					array2[8] = (byte)num6;
					goto case 106;
				case 318:
					array7[num23] = (byte)(num22 & 0xFFu);
					goto case 133;
				case 133:
					array7[num23 + 1] = (byte)((num22 & 0xFF00) >> 8);
					num = 268;
					goto case 268;
				case 268:
					array7[num23 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					num2 = 20;
					if (!smethod_55())
					{
						continue;
					}
					goto case 63;
				case 63:
					array7[num23 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
					goto case 71;
				case 317:
					num22 = num13 ^ num11;
					num2 = 318;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 316:
					array2[5] = (byte)num6;
					goto case 246;
				case 313:
					array[6] = 114;
					goto case 415;
				case 312:
					array5[5] = array6[2];
					goto case 267;
				case 267:
					array5[7] = array6[3];
					goto case 289;
				case 289:
					array5[9] = array6[4];
					num2 = 409;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 310:
					array7 = new byte[array3.Length];
					num2 = 270;
					if (smethod_55())
					{
						continue;
					}
					goto case 267;
				case 309:
					array[26] = (byte)num12;
					num2 = 91;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 136;
				case 136:
					array[27] = 148;
					goto case 25;
				case 25:
					num12 = 147;
					goto case 105;
				case 105:
					array[27] = (byte)num12;
					goto case 188;
				case 188:
					array[27] = 98;
					num = 302;
					goto case 302;
				case 302:
					num7 = 201;
					num2 = 114;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 308:
					array2[5] = (byte)num6;
					num2 = 221;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 305:
					array2[11] = 29;
					goto case 228;
				case 228:
					array2[11] = 128;
					goto case 282;
				case 282:
					array2[11] = 139;
					goto case 353;
				case 304:
					num21 = num13 ^ num11;
					goto case 333;
				case 303:
					num7 = 90;
					goto case 60;
				case 60:
					array[28] = (byte)num7;
					num2 = 222;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 300:
					array[9] = 145;
					num = 283;
					goto case 283;
				case 283:
					num7 = 169;
					num = 231;
					goto case 231;
				case 231:
					array[10] = (byte)num7;
					num2 = 279;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 299:
					num7 = 242;
					goto case 27;
				case 297:
					if (array6 == null)
					{
						goto case 4;
					}
					goto case 197;
				case 197:
					if (array6.Length <= 0)
					{
						goto case 4;
					}
					goto case 183;
				case 183:
					array5[1] = array6[0];
					num2 = 226;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 29;
				case 295:
					num12 = 116;
					num2 = 212;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 218;
				case 218:
					array[16] = (byte)num12;
					num2 = 101;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 31;
				case 292:
					num12 = 213;
					goto case 339;
				case 291:
					num12 = 160;
					num2 = 129;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 309;
				case 290:
					num12 = 150;
					goto case 165;
				case 165:
					array[19] = (byte)num12;
					num2 = 200;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 288:
					array[15] = (byte)num7;
					goto case 260;
				case 260:
					num12 = 92;
					goto case 8;
				case 285:
					array[30] = 178;
					num2 = 147;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 284:
					num20 = 0;
					goto case 194;
				case 281:
					array[9] = 124;
					goto case 257;
				case 257:
					num12 = 91;
					num = 366;
					goto case 366;
				case 280:
					array2[0] = 163;
					goto case 142;
				case 142:
					num6 = 84;
					goto case 40;
				case 279:
					num12 = 139;
					num2 = 169;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 278:
					array2[2] = (byte)num6;
					goto case 98;
				case 98:
					num6 = 181;
					goto case 392;
				case 276:
					array[8] = 217;
					goto case 375;
				case 275:
					smethod_44(object_, CipherMode.CBC);
					num2 = 88;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 272:
					array2[8] = (byte)num6;
					goto case 401;
				case 271:
					num6 = 121;
					goto case 5;
				case 5:
					array2[1] = (byte)num6;
					num2 = 433;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 270:
					num19 = array4.Length / 4;
					num2 = 64;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 265:
					array[13] = (byte)num7;
					goto case 44;
				case 264:
					num7 = 150;
					goto case 427;
				case 263:
					num12 = 49;
					goto case 172;
				case 172:
					array[30] = (byte)num12;
					num2 = 122;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 262:
					array[24] = (byte)num12;
					goto case 22;
				case 22:
					array[24] = 226;
					num2 = 13;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 259:
					array[17] = 148;
					goto case 49;
				case 258:
					array[13] = (byte)num7;
					num2 = 397;
					if (smethod_55())
					{
						continue;
					}
					goto case 2;
				case 255:
					num7 = 169;
					goto case 175;
				case 175:
					array[29] = (byte)num7;
					goto case 89;
				case 251:
					num7 = 235;
					goto case 425;
				case 250:
					num6 = 142;
					num2 = 244;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 249:
					array2[5] = 184;
					goto case 112;
				case 112:
					num6 = 188;
					goto case 316;
				case 248:
					num7 = 162;
					goto case 19;
				case 19:
					array[18] = (byte)num7;
					goto case 168;
				case 168:
					array[18] = 167;
					goto case 213;
				case 247:
					num7 = 142;
					num2 = 337;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 244:
					array2[10] = (byte)num6;
					num2 = 325;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 243:
					num14 = (uint)((array4[num10 + 3] << 24) | (array4[num10 + 2] << 16) | (array4[num10 + 1] << 8) | array4[num10]);
					goto case 38;
				case 38:
					num16 = 255u;
					num2 = 376;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 238:
					smethod_48(object_3);
					num2 = 382;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 237:
					num6 = 139;
					goto case 102;
				case 102:
					array2[1] = (byte)num6;
					goto case 203;
				case 203:
					num6 = 40;
					num2 = 156;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 236:
					smethod_40(array5);
					goto case 360;
				case 234:
					if (num18 != num8 - 1)
					{
						goto case 317;
					}
					goto case 86;
				case 86:
					if (num9 <= 0)
					{
						goto case 317;
					}
					num2 = 62;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 304;
				case 232:
					stream = (Stream)smethod_46();
					num2 = 420;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 230:
					array3 = (byte[])object_16;
					num2 = 233;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 226:
					array5[3] = array6[1];
					goto case 312;
				case 224:
					num12 = 141;
					goto case 54;
				case 54:
					array[31] = (byte)num12;
					goto case 70;
				case 70:
					array[31] = 117;
					num2 = 299;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 222:
					num12 = 101;
					num2 = 99;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 221:
					array2[5] = 107;
					goto case 418;
				case 220:
					array[25] = (byte)num12;
					goto case 219;
				case 219:
					array[25] = 35;
					num2 = 13;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 36;
				case 36:
					num7 = 108;
					num = 173;
					goto case 173;
				case 173:
					array[26] = (byte)num7;
					goto case 143;
				case 143:
					array[26] = 127;
					num2 = 134;
					if (smethod_55())
					{
						continue;
					}
					goto case 86;
				case 217:
					num17 += 8;
					num2 = 31;
					if (!smethod_55())
					{
						continue;
					}
					goto case 33;
				case 216:
					array[6] = 146;
					num2 = 71;
					if (!smethod_55())
					{
						continue;
					}
					goto case 146;
				case 146:
					array[6] = 106;
					num2 = 189;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 211:
					num16 <<= 8;
					num2 = 217;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 210:
					array[10] = 74;
					goto case 404;
				case 207:
					smethod_39(object_2);
					goto case 393;
				case 204:
					array[26] = 130;
					goto case 291;
				case 200:
					num7 = 232;
					num2 = 3;
					if (smethod_55())
					{
						continue;
					}
					goto case 1;
				case 1:
					num12 = 168;
					goto case 417;
				case 199:
					array2[9] = (byte)num6;
					goto case 324;
				case 198:
					array[21] = 137;
					goto case 389;
				case 196:
					num12 = 162;
					goto case 177;
				case 177:
					array[4] = (byte)num12;
					num = 52;
					goto case 52;
				case 52:
					num12 = 62;
					num2 = 391;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 195:
					num7 = 90;
					goto case 387;
				case 192:
					array[5] = 90;
					num2 = 108;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 191:
					num12 = 52;
					goto case 164;
				case 164:
					array[5] = (byte)num12;
					goto case 216;
				case 190:
					array[18] = (byte)num12;
					goto case 248;
				case 189:
					array[6] = 110;
					num2 = 313;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 108;
				case 108:
					array[5] = 84;
					goto case 191;
				case 185:
					num13 = num15;
					num2 = 64;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 234;
				case 184:
					array2[7] = 126;
					goto case 319;
				case 182:
					smethod_47(object_3, array3, 0, array3.Length);
					num2 = 238;
					if (smethod_55())
					{
						continue;
					}
					goto case 220;
				case 179:
					array[2] = 163;
					goto case 264;
				case 171:
					array2[9] = 98;
					num = 369;
					goto case 369;
				case 170:
					num12 = 162;
					goto case 137;
				case 137:
					array[11] = (byte)num12;
					num2 = 335;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 169:
					array[10] = (byte)num12;
					goto case 159;
				case 159:
					array[10] = 63;
					num2 = 195;
					if (!smethod_55())
					{
						continue;
					}
					goto case 210;
				case 163:
					num6 = 221;
					num2 = 357;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 161:
					array[0] = 118;
					goto case 157;
				case 157:
					num12 = 67;
					goto case 59;
				case 59:
					array[0] = (byte)num12;
					goto case 53;
				case 53:
					array[0] = 163;
					num2 = 383;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 156:
					array2[1] = (byte)num6;
					goto case 358;
				case 151:
					array[2] = 98;
					num = 323;
					goto case 323;
				case 148:
					num12 = 76;
					goto case 385;
				case 144:
					array2[14] = (byte)num6;
					num = 12;
					goto case 12;
				case 138:
					num6 = 161;
					num2 = 95;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 134:
					num12 = 109;
					num2 = 403;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 421;
				case 132:
					num12 = 91;
					num2 = 103;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 131:
					num6 = 115;
					goto case 338;
				case 129:
					num12 = 122;
					num2 = 426;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 125:
					num11 = 0u;
					num2 = 48;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 124:
					array[23] = (byte)num12;
					num2 = 47;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 40;
				case 122:
					array[30] = 185;
					goto case 224;
				case 120:
					num12 = 105;
					num = 190;
					goto case 190;
				case 119:
					array[7] = 110;
					goto case 402;
				case 117:
					num14 = 0u;
					goto case 125;
				case 116:
					num7 = 109;
					goto case 26;
				case 26:
					array[7] = (byte)num7;
					goto case 119;
				case 114:
					array[27] = (byte)num7;
					num2 = 326;
					if (smethod_55())
					{
						continue;
					}
					goto case 243;
				case 111:
					num13 += num14;
					goto case 284;
				case 104:
					array3 = (byte[])smethod_38(object_2, (int)smethod_37(smethod_35(object_2)));
					num2 = 207;
					if (smethod_55())
					{
						continue;
					}
					goto case 180;
				case 103:
					array[8] = (byte)num12;
					num2 = 276;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 173;
				case 101:
					array[16] = 7;
					num2 = 82;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 99:
					array[28] = (byte)num12;
					goto case 81;
				case 81:
					array[28] = 121;
					num2 = 163;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 255;
				case 96:
					num6 = 111;
					goto case 367;
				case 95:
					array2[13] = (byte)num6;
					goto case 378;
				case 93:
					num7 = 27;
					goto case 388;
				case 92:
					num12 = 86;
					num2 = 76;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 91:
					array2[6] = (byte)num6;
					num = 334;
					goto case 334;
				case 90:
					num6 = 92;
					goto case 394;
				case 88:
					transform = (ICryptoTransform)smethod_45(object_, array4, array5);
					goto case 232;
				case 87:
					array[15] = 132;
					num2 = 74;
					if (!smethod_55())
					{
						continue;
					}
					goto case 84;
				case 84:
					num7 = 166;
					num2 = 288;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 74;
				case 82:
					array[17] = 19;
					goto case 259;
				case 80:
					array2[10] = (byte)num6;
					goto case 96;
				case 78:
					array[6] = (byte)num12;
					num2 = 116;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 69;
				case 77:
					array2[10] = (byte)num6;
					goto case 32;
				case 32:
					array2[10] = 123;
					num = 330;
					goto case 330;
				case 76:
					array[25] = (byte)num12;
					goto case 43;
				case 43:
					num12 = 122;
					goto case 220;
				case 73:
					array[3] = 171;
					goto case 196;
				case 64:
					num13 = 0u;
					goto case 117;
				case 62:
					array2[12] = (byte)num6;
					goto case 351;
				case 51:
					num12 = 155;
					goto case 364;
				case 50:
					num12 = 123;
					num = 416;
					goto case 416;
				case 48:
					if (num9 > 0)
					{
						num2 = 396;
						if (smethod_56() == null)
						{
							continue;
						}
						goto IL_0050;
					}
					goto case 214;
				case 47:
					array[23] = 168;
					goto case 195;
				case 45:
					array[23] = 104;
					num2 = 51;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 41:
					num7 = 89;
					num2 = 258;
					if (smethod_55())
					{
						continue;
					}
					goto IL_0050;
				case 39:
					array[21] = (byte)num7;
					goto case 198;
				case 35:
					num8 = array3.Length / 4;
					goto case 310;
				case 24:
					object_ = (SymmetricAlgorithm)smethod_43();
					goto case 275;
				case 20:
					num7 = 149;
					num2 = 39;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 15:
					array[24] = (byte)num7;
					num = 247;
					goto case 247;
				case 13:
					array[24] = 225;
					goto case 92;
				case 9:
					array2[4] = 109;
					num2 = 31;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_0050;
				case 3:
					array[19] = (byte)num7;
					num2 = 65;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 359;
				default:
					num6 = 207;
					goto case 62;
				case 345:
					break;
				case 294:
					object_16 = array7;
					goto IL_2a2c;
				case 65:
					goto IL_2a2c;
				case 371:
					goto IL_2a39;
				case 398:
					goto end_IL_2a17;
				}
				break;
			}
			continue;
			IL_0050:
			num2 = num;
			goto IL_2345;
			IL_2a2c:
			int_5 = smethod_51(object_16, int_4);
			goto IL_2a39;
			continue;
			end_IL_2a17:
			break;
		}
		return "";
	}

	[Attribute0(typeof(Attribute0.Class26<object>[]))]
	internal static string smethod_17(object object_19)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)object_19);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint smethod_18(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_7, ref uint uint_1)
	{
		IntPtr ptr = intptr_6;
		if (bool_1)
		{
			ptr = intptr_5;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = ((Hashtable)object_8)[(object)num];
		if (obj != null)
		{
			Struct19 @struct = (Struct19)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
			Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
			if (@struct.bool_0)
			{
				intptr_7 = intPtr;
				uint_1 = (uint)@struct.byte_0.Length;
				smethod_27(intptr_7, @struct.byte_0.Length, 64, ref int_3);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, @struct.byte_0.Length);
			uint result = 0u;
			if (uint_0 == 216669565 && !bool_4)
			{
				bool_4 = true;
			}
			else
			{
				result = object_6(intptr_4, intptr_5, intptr_6, uint_0, intptr_7, ref uint_1);
			}
			return result;
		}
		return object_6(intptr_4, intptr_5, intptr_6, uint_0, intptr_7, ref uint_1);
	}

	private static int smethod_19()
	{
		return 5;
	}

	private static void smethod_20()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate smethod_21(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(Class30.smethod_0(16777281)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(Class30.smethod_0(16777251)),
			Type.GetTypeFromHandle(Class30.smethod_0(16777342))
		})!.Invoke(null, new object[2] { intptr_4, type_0 });
	}

	internal unsafe static void smethod_22()
	{
		//The blocks IL_0863, IL_0869, IL_086f, IL_087e, IL_08bf are reachable both inside and outside the pinned region starting at IL_0854. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0009, IL_0013, IL_0019, IL_0020, IL_003f, IL_0043, IL_004c, IL_0067, IL_0070, IL_0079, IL_0090, IL_009c, IL_00a8, IL_00b1, IL_00bf, IL_00e0, IL_00fe, IL_0107, IL_0115, IL_0124, IL_012a, IL_0138, IL_013e, IL_014c, IL_0155, IL_0173, IL_017d, IL_0186, IL_01a7, IL_01c3, IL_01e6, IL_01f4, IL_0203, IL_0219, IL_0222, IL_0230, IL_024b, IL_0262, IL_027d, IL_0299, IL_02b7, IL_02c3, IL_02e7, IL_0302, IL_0309, IL_0314, IL_0352, IL_035e, IL_0381, IL_03a4, IL_03bf, IL_03ce, IL_03e3, IL_0401, IL_041f, IL_042b, IL_043a, IL_0452, IL_0473, IL_0494, IL_04b0, IL_04bf, IL_04c8, IL_04d6, IL_04f1, IL_0500, IL_0518, IL_0524, IL_053a, IL_0548, IL_055a, IL_0568, IL_0584, IL_059f, IL_05be, IL_0938, IL_0957, IL_096d, IL_0973, IL_0979, IL_0994, IL_09ad, IL_09c0, IL_09d3, IL_09f4, IL_0a12, IL_0a18, IL_0a26, IL_0a2c, IL_0a43, IL_0a4f, IL_0a6d, IL_0a8c, IL_0a96, IL_0ac1, IL_0ad7, IL_0add, IL_0af6, IL_0b04, IL_0b13, IL_0b28, IL_0b38, IL_0b5c, IL_0b6c, IL_0b7a, IL_0b9e, IL_0bba, IL_0bc3, IL_0bc8, IL_0bd8, IL_0bdb, IL_0bfa, IL_0c1b, IL_0c30, IL_0c43, IL_0c61, IL_0c84, IL_0ca2, IL_0ca8, IL_0cd3, IL_0cda, IL_0cdd, IL_0ce5, IL_0cf5, IL_0cfa, IL_0d0f, IL_0d13, IL_0d2f, IL_0d5a, IL_0d66, IL_0d6f, IL_0d7d, IL_0d9b, IL_0dba, IL_0dc3, IL_0de1, IL_0e05, IL_0e0e, IL_0e1c, IL_0e2b, IL_0e31, IL_0e48, IL_0e4e, IL_0e61, IL_0e67, IL_0e6d, IL_0e86, IL_0e8d, IL_0ea8, IL_0ecc, IL_0ed5, IL_0ee6, IL_0efb, IL_0f09, IL_0f1d, IL_0f22, IL_0f32, IL_0f48, IL_0f5e, IL_0f82, IL_0f88, IL_0f8e, IL_0fa3, IL_0fac, IL_0fb0, IL_1039, IL_1047, IL_1062, IL_1067, IL_1082, IL_10a8, IL_10c3, IL_10d1, IL_10da, IL_10f1, IL_10fa, IL_1108, IL_111a, IL_1128, IL_112e, IL_1151, IL_115f, IL_1173, IL_1181, IL_118d, IL_119c, IL_11a8, IL_11b4, IL_11d0, IL_11dc, IL_11fd, IL_1205, IL_1213, IL_1234, IL_1254, IL_1277, IL_1293, IL_1299, IL_129f, IL_12a5, IL_12c0, IL_12ce, IL_12ef, IL_130e, IL_131a, IL_133e, IL_134e, IL_1353, IL_1366, IL_1383, IL_138f, IL_1397, IL_13a0, IL_13b8, IL_13c6, IL_13db, IL_13e4, IL_13fb, IL_1407, IL_1413, IL_142e, IL_144f, IL_1455, IL_145b, IL_146a, IL_1485, IL_14a3, IL_14be, IL_14d9, IL_14e8, IL_1506, IL_1524, IL_152d, IL_153b, IL_154a, IL_1559, IL_1571, IL_157a, IL_1598, IL_15a4, IL_15ad, IL_15bb, IL_15d9, IL_15e7, IL_1602, IL_1610, IL_1626, IL_1634, IL_1655, IL_1676, IL_1689, IL_16b1, IL_16bd, IL_16d3, IL_16e1, IL_16f0, IL_16fb, IL_1706, IL_1713, IL_172c, IL_1738, IL_1747, IL_1753, IL_175f, IL_176d, IL_1773, IL_1788, IL_17a3, IL_17ac, IL_17ba, IL_17d6, IL_17f2, IL_17f8, IL_1806, IL_180c, IL_182a, IL_1836, IL_184b, IL_1869, IL_187c, IL_1884, IL_18b0, IL_18ce, IL_18e5, IL_1901, IL_1919, IL_1922, IL_192b, IL_1933, IL_1948, IL_1951, IL_1974, IL_197d, IL_1996, IL_19b4, IL_19c0, IL_19c6, IL_19cd, IL_19de, IL_19e2, IL_19e9, IL_1a06, IL_1a09, IL_1a11, IL_1a26, IL_1a4c, IL_1a6a, IL_1a79, IL_1a9d, IL_1ab0, IL_1ad4, IL_1adf, IL_1af4, IL_1b12, IL_1b21, IL_1b27, IL_1b3a, IL_1b4f, IL_1b60, IL_1b69, IL_1b6c, IL_1b8a, IL_1ba4, IL_1bb0, IL_1bbc, IL_1bc8, IL_1bdb, IL_1bde, IL_1be3, IL_1bfe, IL_1c16, IL_1c21, IL_1c2c, IL_1c40, IL_1c60, IL_1c7c, IL_1c9d, IL_1caf, IL_1ccf, IL_1ce8, IL_1cfd, IL_1d09, IL_1d12, IL_1d30, IL_1d36, IL_1d3c, IL_1d43, IL_1d66, IL_1d6c, IL_1d77, IL_1d7f, IL_1d9f, IL_1db5, IL_1dca, IL_1df0, IL_1e03, IL_1e24, IL_1e42, IL_1e55, IL_1e73, IL_1e92, IL_1e9d, IL_1eac, IL_1ec8, IL_1ee6, IL_1eff, IL_1f1a, IL_1f38, IL_1f3e, IL_1f44, IL_1f69, IL_1f6f, IL_1f75, IL_1f80, IL_1f97, IL_1f9b, IL_1fae, IL_1fba, IL_1fbd, IL_1fc5, IL_1feb, IL_1ffc, IL_2013, IL_2025, IL_202d, IL_2036, IL_2039, IL_2042, IL_2062, IL_207b, IL_209e, IL_20c1, IL_20cf, IL_20e7, IL_20f5, IL_21d8, IL_21ed, IL_2207, IL_221f, IL_222f, IL_2241, IL_2258, IL_226c, IL_228a, IL_2299, IL_22b9, IL_22c1, IL_22e5, IL_22fd, IL_2311, IL_232c, IL_2340, IL_234b, IL_235b, IL_2366, IL_2373, IL_237a, IL_2382, IL_2394, IL_23b7, IL_23d3, IL_23df, IL_23fd, IL_2420, IL_243c, IL_2449, IL_2464, IL_246c, IL_2479, IL_2485, IL_24a6, IL_24ac, IL_24cf, IL_24dd, IL_24eb, IL_250c, IL_251a, IL_253d, IL_255d, IL_2566, IL_2574, IL_2598, IL_25a9, IL_25bc, IL_25c5, IL_25d9, IL_25e4, IL_25f4, IL_25fa, IL_260d, IL_2619, IL_2627, IL_262f, IL_2653, IL_265f, IL_266e, IL_2691, IL_269a, IL_26af, IL_26ba, IL_26d0, IL_26e1, IL_26f5, IL_270a, IL_2723, IL_2738, IL_2744, IL_2755, IL_2769, IL_2787, IL_27b7, IL_27d5, IL_27f5, IL_2803, IL_2821, IL_282c, IL_283a, IL_2849, IL_2868, IL_2892, IL_2899, IL_28a1, IL_28ae, IL_28ba, IL_28d6, IL_28f9, IL_2914, IL_2923, IL_2931, IL_2942, IL_2946, IL_295a, IL_2967, IL_297f, IL_299b, IL_29bf, IL_2afb, IL_2b1e, IL_2b27, IL_2b34, IL_2b4d, IL_2b5b, IL_2b75, IL_2b96, IL_2bb9, IL_2bdc, IL_2be2, IL_2be8, IL_2bfc, IL_2c1a, IL_2c3d, IL_2c61, IL_2c78, IL_2c93, IL_2ca7, IL_2cb5, IL_2cc3, IL_2cd6, IL_2ce3, IL_2cf6, IL_2d14, IL_2d2b, IL_2d3f, IL_2d53, IL_2d68, IL_2d79, IL_2f24, IL_2f37, IL_2f43, IL_2f52, IL_2f61, IL_2f79, IL_2f87, IL_2fa2, IL_2fcf, IL_2fe0, IL_2fee, IL_2fff, IL_300d, IL_3016, IL_3032, IL_303e, IL_3059, IL_306a, IL_3085, IL_3093, IL_309b, IL_30ae, IL_30cb, IL_30d9, IL_30de, IL_30f3, IL_30fa, IL_3118, IL_312f, IL_3147, IL_315f, IL_3176, IL_318a, IL_319e, IL_31a3, IL_31c6, IL_31d9, IL_31e4, IL_3204, IL_320c, IL_3225, IL_324c, IL_3258, IL_3278, IL_328b, IL_329e, IL_32ac, IL_32c7, IL_32e1, IL_32f2, IL_3302, IL_330d, IL_3316, IL_3337, IL_335a, IL_3365, IL_336e, IL_337c, IL_3382, IL_3390, IL_339b, IL_33a5, IL_33c3, IL_3540, IL_354f, IL_356a, IL_3588, IL_35ab, IL_35c9, IL_35d7, IL_35e2, IL_35ed, IL_360d, IL_362e, IL_3639, IL_364e, IL_3662, IL_366c, IL_3695, IL_369c, IL_36b4, IL_36d1, IL_36ec, IL_36ff, IL_371f, IL_3732, IL_3740, IL_374b, IL_376b, IL_3776, IL_377f, IL_37a3, IL_37b1, IL_37c2, IL_37d5, IL_37e1, IL_37f8, IL_3815, IL_383d, IL_3859, IL_3875, IL_3891, IL_38af, IL_38d0, IL_38dd, IL_38fb, IL_391e, IL_3936, IL_3946, IL_394f, IL_397b, IL_398c, IL_399f, IL_39b2, IL_39d2, IL_39e0, IL_3a03, IL_3a17, IL_3a3a, IL_3a5e, IL_3a7f, IL_3a96, IL_3ab8, IL_3ac5, IL_3ad6, IL_3af1, IL_3afc, IL_3b0c, IL_3b2f, IL_3b48, IL_3b5c, IL_3b6d, IL_3b81, IL_3b95, IL_3ba6, IL_3bae, IL_3bc3, IL_3bce, IL_3be6, IL_3bf9, IL_3c15, IL_3c36, IL_3c41, IL_3c5e, IL_4712, IL_471d, IL_4732, IL_473a, IL_4759, IL_4763 are reachable both inside and outside the pinned region starting at IL_0322. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 396;
		int num8 = default(int);
		byte[] array9 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		int num4 = default(int);
		IntPtr intptr_6 = default(IntPtr);
		IntPtr intPtr = default(IntPtr);
		long num13 = default(long);
		byte[] array = default(byte[]);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] array19 = default(byte[]);
		byte[] array8 = default(byte[]);
		uint num49 = default(uint);
		long num7 = default(long);
		IntPtr intptr_ = default(IntPtr);
		int int_3 = default(int);
		Class28 object_ = default(Class28);
		byte[] array7 = default(byte[]);
		IntPtr intptr_2 = default(IntPtr);
		MemoryStream object_16 = default(MemoryStream);
		int num73 = default(int);
		byte[] array20 = default(byte[]);
		uint nativeSizeOfCode = default(uint);
		int num70 = default(int);
		ref byte reference3 = default(ref byte);
		int num72 = default(int);
		int num75 = default(int);
		IntPtr intPtr4 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		int num62 = default(int);
		int num60 = default(int);
		int num42 = default(int);
		int num61 = default(int);
		int num24 = default(int);
		int int_ = default(int);
		uint num48 = default(uint);
		int num67 = default(int);
		uint num17 = default(uint);
		byte[] array17 = default(byte[]);
		uint num65 = default(uint);
		int num66 = default(int);
		int num19 = default(int);
		int num20 = default(int);
		int num25 = default(int);
		int num27 = default(int);
		uint num16 = default(uint);
		byte[] array15 = default(byte[]);
		int num52 = default(int);
		IntPtr intptr_4 = default(IntPtr);
		int num38 = default(int);
		IntPtr intptr_5 = default(IntPtr);
		string text = default(string);
		IntPtr intPtr2 = default(IntPtr);
		int num54 = default(int);
		uint num53 = default(uint);
		int num50 = default(int);
		uint num18 = default(uint);
		byte[] array16 = default(byte[]);
		int num15 = default(int);
		byte[] array10 = default(byte[]);
		Struct19 struct2 = default(Struct19);
		bool flag2 = default(bool);
		byte[] array13 = default(byte[]);
		uint num26 = default(uint);
		long num11 = default(long);
		Struct19 @struct = default(Struct19);
		byte[] byte_ = default(byte[]);
		IEnumerator enumerator = default(IEnumerator);
		ProcessModuleCollection object_14 = default(ProcessModuleCollection);
		byte[] array3 = default(byte[]);
		byte[] array11 = default(byte[]);
		int num47 = default(int);
		int num51 = default(int);
		int int_2 = default(int);
		byte[] array18 = default(byte[]);
		int num14 = default(int);
		int num10 = default(int);
		byte[] array5 = default(byte[]);
		CryptoStream object_6 = default(CryptoStream);
		int num59 = default(int);
		int num12 = default(int);
		IntPtr procAddress = default(IntPtr);
		string string_ = default(string);
		Delegate4 object_7 = default(Delegate4);
		SymmetricAlgorithm object_13 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		Enum9 uint_ = default(Enum9);
		Process object_8 = default(Process);
		ProcessModule object_12 = default(ProcessModule);
		int num41 = default(int);
		int num44 = default(int);
		int num45 = default(int);
		int num29 = default(int);
		int num33 = default(int);
		int num35 = default(int);
		int num37 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		Version object_2 = default(Version);
		Version object_3 = default(Version);
		ProcessModule object_4 = default(ProcessModule);
		Version object_5 = default(Version);
		int num23 = default(int);
		int num6 = default(int);
		ref byte reference = default(ref byte);
		long value = default(long);
		byte[] array12 = default(byte[]);
		while (true)
		{
			if (!bool_2)
			{
				goto IL_0013;
			}
			int num2 = 395;
			if (smethod_190() != null)
			{
				goto IL_0067;
			}
			goto IL_3c5e;
			IL_0067:
			num2 = num;
			goto IL_3c5e;
			IL_3c5e:
			while (true)
			{
				byte[] array22;
				int num68;
				byte[] array21;
				int num69;
				int num71;
				int num74;
				IntPtr intptr_3;
				uint num63;
				ref Struct19 reference2;
				int num55;
				int num56;
				int num57;
				int num58;
				int num39;
				int num40;
				int num43;
				int num46;
				int num28;
				int num30;
				long num31;
				long num32;
				int num34;
				int num36;
				byte[] array14;
				int num21;
				int num22;
				nint num9;
				byte[] array4;
				switch (num2)
				{
				case 396:
					break;
				default:
					goto IL_0013;
				case 36:
					goto IL_0019;
				case 15:
					goto IL_0020;
				case 680:
					num8 = 30;
					goto case 320;
				case 320:
					array9[num8] = array6[0];
					goto case 348;
				case 348:
					array9[num8 + 1] = array6[1];
					num2 = 126;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 679:
					num3 = 168;
					goto case 13;
				case 13:
					array2[24] = (byte)num3;
					num = 612;
					goto case 612;
				case 612:
					array2[24] = 127;
					goto case 493;
				case 493:
					array2[24] = 29;
					goto case 190;
				case 190:
					num3 = 207;
					goto case 28;
				case 28:
					array2[25] = (byte)num3;
					goto case 618;
				case 618:
					array2[25] = 171;
					num2 = 98;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 678:
					num4 = 244;
					num2 = 375;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 677:
					num3 = 154;
					goto case 226;
				case 226:
					array2[30] = (byte)num3;
					goto case 504;
				case 504:
					array2[30] = 169;
					goto case 170;
				case 170:
					num3 = 90;
					goto case 99;
				case 99:
					array2[30] = (byte)num3;
					goto case 154;
				case 154:
					num3 = 107;
					goto case 502;
				case 502:
					array2[31] = (byte)num3;
					goto case 58;
				case 58:
					num3 = 141;
					goto case 453;
				case 453:
					array2[31] = (byte)num3;
					num2 = 150;
					if (smethod_189())
					{
						continue;
					}
					goto case 100;
				case 100:
					value = smethod_169(intptr_6);
					goto case 292;
				case 292:
				case 350:
					smethod_100(intptr_6, 0);
					goto case 639;
				case 639:
					object_17 = new Delegate3(smethod_18);
					num2 = 142;
					if (!smethod_189())
					{
						continue;
					}
					goto case 511;
				case 511:
					intPtr = IntPtr.Zero;
					num2 = 260;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 676:
					num13 = smethod_170(new IntPtr(value));
					num2 = 435;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 675:
					array2[25] = (byte)num3;
					goto case 428;
				case 428:
					array2[25] = 224;
					goto case 67;
				case 67:
					num3 = 84;
					num2 = 145;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 2;
				case 2:
					num3 = 160;
					goto case 216;
				case 216:
					array2[26] = (byte)num3;
					goto case 327;
				case 327:
					num3 = 28;
					num2 = 191;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 674:
					array[14] = (byte)num4;
					num = 35;
					goto case 35;
				case 35:
					num4 = 85;
					num2 = 107;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 673:
					smethod_153(memoryStream);
					num2 = 467;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 672:
					array2[6] = (byte)num3;
					num2 = 68;
					if (!smethod_189())
					{
						continue;
					}
					goto case 148;
				case 148:
					array2[6] = 123;
					goto case 176;
				case 176:
					array2[6] = 131;
					num2 = 37;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 671:
					num4 = 113;
					num2 = 201;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 670:
					array22 = (array19 = array8);
					if (array22 != null)
					{
						goto case 534;
					}
					num = 275;
					goto case 275;
				case 534:
					if (array19.Length != 0)
					{
						goto case 271;
					}
					goto case 275;
				case 271:
				case 329:
					while (true)
					{
						fixed (byte* ptr = &array19[0])
						{
							num2 = 315;
							if (!smethod_189())
							{
								goto IL_0067_2;
							}
							goto IL_3c5e_3;
							IL_0067_2:
							num2 = num;
							goto IL_3c5e_3;
							IL_3c5e_3:
							while (true)
							{
								switch (num2)
								{
								case 271:
								case 329:
									goto end_IL_3c5e;
								case 396:
									if (bool_2)
									{
										num2 = 395;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto default;
								default:
									bool_2 = true;
									goto case 36;
								case 36:
									num49 = 4059231220u;
									goto case 15;
								case 15:
									num7 = 0L;
									num2 = 83;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 73;
								case 680:
									num8 = 30;
									goto case 320;
								case 320:
									array9[num8] = array6[0];
									goto case 348;
								case 348:
									array9[num8 + 1] = array6[1];
									num2 = 126;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 679:
									num3 = 168;
									goto case 13;
								case 13:
									array2[24] = (byte)num3;
									num = 612;
									goto case 612;
								case 612:
									array2[24] = 127;
									goto case 493;
								case 493:
									array2[24] = 29;
									goto case 190;
								case 190:
									num3 = 207;
									goto case 28;
								case 28:
									array2[25] = (byte)num3;
									goto case 618;
								case 618:
									array2[25] = 171;
									num2 = 98;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 678:
									num4 = 244;
									num2 = 375;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 677:
									num3 = 154;
									goto case 226;
								case 226:
									array2[30] = (byte)num3;
									goto case 504;
								case 504:
									array2[30] = 169;
									goto case 170;
								case 170:
									num3 = 90;
									goto case 99;
								case 99:
									array2[30] = (byte)num3;
									goto case 154;
								case 154:
									num3 = 107;
									goto case 502;
								case 502:
									array2[31] = (byte)num3;
									goto case 58;
								case 58:
									num3 = 141;
									goto case 453;
								case 453:
									array2[31] = (byte)num3;
									num2 = 150;
									if (smethod_189())
									{
										continue;
									}
									goto case 100;
								case 100:
									value = smethod_169(intptr_6);
									goto case 292;
								case 292:
								case 350:
									smethod_100(intptr_6, 0);
									goto case 639;
								case 639:
									object_17 = new Delegate3(smethod_18);
									num2 = 142;
									if (!smethod_189())
									{
										continue;
									}
									goto case 511;
								case 511:
									intPtr = IntPtr.Zero;
									num2 = 260;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 676:
									num13 = smethod_170(new IntPtr(value));
									num2 = 435;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 675:
									array2[25] = (byte)num3;
									goto case 428;
								case 428:
									array2[25] = 224;
									goto case 67;
								case 67:
									num3 = 84;
									num2 = 145;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 2;
								case 2:
									num3 = 160;
									goto case 216;
								case 216:
									array2[26] = (byte)num3;
									goto case 327;
								case 327:
									num3 = 28;
									num2 = 191;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 674:
									array[14] = (byte)num4;
									num = 35;
									goto case 35;
								case 35:
									num4 = 85;
									num2 = 107;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 673:
									smethod_153(memoryStream);
									num2 = 467;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 672:
									array2[6] = (byte)num3;
									num2 = 68;
									if (!smethod_189())
									{
										continue;
									}
									goto case 148;
								case 148:
									array2[6] = 123;
									goto case 176;
								case 176:
									array2[6] = 131;
									num2 = 37;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 671:
									num4 = 113;
									num2 = 201;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 670:
									array22 = (array19 = array8);
									if (array22 == null)
									{
										num = 275;
										goto end_IL_031a;
									}
									goto case 534;
								case 534:
									if (array19.Length == 0)
									{
										goto end_IL_031a;
									}
									goto end_IL_3c5e;
								case 275:
								case 423:
									goto end_IL_031a;
								case 669:
									smethod_27(intptr_, 4, 4, ref int_3);
									goto case 140;
								case 140:
									smethod_159(intptr_, smethod_146(object_));
									num2 = 78;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 668:
									array2[19] = (byte)num3;
									num2 = 46;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 667:
									num3 = 14;
									num2 = 624;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 666:
									array[2] = 133;
									goto case 347;
								case 347:
									array[2] = 119;
									num = 263;
									goto case 263;
								case 263:
									num4 = 159;
									num2 = 195;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 665:
									array7 = new byte[10];
									num2 = 62;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 664:
									array[7] = 91;
									goto case 471;
								case 471:
									array[7] = 143;
									goto case 479;
								case 479:
									array[7] = 222;
									num = 592;
									goto case 592;
								case 592:
									array[8] = 93;
									num2 = 200;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 663:
									array2[12] = 31;
									num2 = 583;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 662:
									intptr_2 = IntPtr.Zero;
									num2 = 440;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 661:
									array[1] = 150;
									goto case 295;
								case 295:
									num4 = 164;
									goto case 122;
								case 122:
									array[1] = (byte)num4;
									goto case 204;
								case 204:
									num4 = 114;
									num2 = 400;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 660:
									array2[3] = 158;
									goto case 408;
								case 408:
									array2[4] = 131;
									num = 141;
									goto case 141;
								case 141:
									array2[4] = 116;
									goto case 21;
								case 21:
									num3 = 114;
									num2 = 58;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 87;
								case 87:
									array2[4] = (byte)num3;
									goto case 139;
								case 139:
									num3 = 155;
									num = 434;
									goto case 434;
								case 434:
									array2[4] = (byte)num3;
									goto case 658;
								case 658:
									array2[5] = 41;
									num2 = 25;
									if (!smethod_189())
									{
										continue;
									}
									goto case 96;
								case 96:
									num3 = 108;
									num2 = 278;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 659:
									num3 = 153;
									num2 = 19;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 657:
									try
									{
										object obj5 = smethod_181(smethod_180(smethod_179(smethod_178(smethod_162(typeof(Class25).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), smethod_179(smethod_178(smethod_162(typeof(Class25).TypeHandle).Assembly)));
										num68 = 1;
										if (!smethod_189())
										{
											goto IL_0776;
										}
										goto IL_07dd;
										IL_07dd:
										while (true)
										{
											switch (num68)
											{
											case 16:
											case 19:
												if (!smethod_123(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
												{
													num68 = 10;
													if (smethod_189())
													{
														continue;
													}
													goto case 8;
												}
												goto case 17;
											case 8:
												smethod_150(object_16, new byte[smethod_115()], 0, smethod_115());
												num73 = 15;
												goto case 15;
											case 15:
												smethod_135(object_16, 0L);
												num68 = 4;
												if (!smethod_189())
												{
													continue;
												}
												goto case 7;
											case 7:
												array20 = (byte[])smethod_152(object_16);
												num68 = 0;
												if (smethod_190() == null)
												{
													continue;
												}
												break;
											case 17:
												Class25.intptr_2 = (IntPtr)smethod_181(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
												goto case 2;
											case 2:
											case 10:
												object_16 = new MemoryStream();
												num73 = 6;
												goto case 6;
											case 6:
												smethod_150(object_16, new byte[smethod_115()], 0, smethod_115());
												goto case 3;
											case 3:
												if (smethod_115() == 4)
												{
													goto case 4;
												}
												goto case 12;
											case 4:
												smethod_150(object_16, smethod_157(Class25.intptr_2.ToInt32()), 0, 4);
												num68 = 5;
												if (smethod_190() != null)
												{
													continue;
												}
												goto case 5;
											case 5:
											case 11:
												smethod_150(object_16, new byte[smethod_115()], 0, smethod_115());
												num68 = 8;
												if (smethod_190() == null)
												{
													continue;
												}
												break;
											case 12:
												smethod_150(object_16, smethod_182(Class25.intptr_2.ToInt64()), 0, 8);
												num68 = 11;
												if (smethod_190() == null)
												{
													continue;
												}
												break;
											case 18:
												nativeSizeOfCode = 0u;
												num68 = 9;
												if (smethod_189())
												{
													continue;
												}
												break;
											case 14:
												Class25.intptr_2 = (IntPtr)obj5;
												num68 = 13;
												if (smethod_190() != null)
												{
													continue;
												}
												goto case 16;
											case 1:
												if (!(obj5 is IntPtr))
												{
													num68 = 16;
													if (smethod_189())
													{
														continue;
													}
													break;
												}
												goto case 14;
											default:
												smethod_153(object_16);
												num68 = 18;
												if (smethod_190() == null)
												{
													continue;
												}
												goto case 2;
											case 9:
												try
												{
													array21 = (array19 = array20);
													if (array21 != null)
													{
														num69 = 3;
														if (!smethod_189())
														{
															goto IL_084c;
														}
														goto IL_08bf;
													}
													goto IL_08e2;
													IL_084c:
													while (true)
													{
														fixed (byte* value2 = &array19[0])
														{
															num69 = 1;
															if (!smethod_189())
															{
																goto IL_0863;
															}
															goto IL_08bf_2;
															IL_08bf_2:
															while (true)
															{
																switch (num69)
																{
																case 2:
																case 4:
																	goto end_IL_08bf;
																case 3:
																	if (array19.Length == 0)
																	{
																		goto end_IL_084c;
																	}
																	num69 = 1;
																	if (!smethod_189())
																	{
																		continue;
																	}
																	goto end_IL_08bf;
																default:
																	object_17(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
																	num69 = 6;
																	if (smethod_190() == null)
																	{
																		continue;
																	}
																	break;
																case 5:
																	goto end_IL_084c;
																case 6:
																	goto end_IL_0835;
																}
																goto IL_0863;
																continue;
																end_IL_08bf:
																break;
															}
															goto end_IL_0856;
															IL_0863:
															num69 = num70;
															goto IL_08bf_2;
															end_IL_0856:;
														}
														continue;
														end_IL_084c:
														break;
													}
													goto IL_08e2;
													IL_08e2:
													reference3 = ref *(byte*)null;
													num69 = 0;
													if (!smethod_189())
													{
														goto IL_0863_2;
													}
													goto IL_08bf;
													IL_08bf:
													while (true)
													{
														switch (num69)
														{
														case 2:
														case 4:
															break;
														case 3:
															if (array19.Length != 0)
															{
																num69 = 1;
																if (!smethod_189())
																{
																	continue;
																}
																break;
															}
															goto IL_08e2;
														default:
															goto IL_087e;
														case 5:
															goto IL_08e2;
														case 6:
															goto end_IL_0835;
														}
														break;
														IL_087e:
														object_17(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), ref nativeSizeOfCode);
														num69 = 6;
														if (smethod_190() == null)
														{
															continue;
														}
														goto IL_0863_2;
													}
													goto IL_084c;
													IL_0863_2:
													num69 = num70;
													goto IL_08bf;
													end_IL_0835:;
												}
												finally
												{
													reference3 = ref *(byte*)null;
													num71 = 0;
													if (smethod_190() != null)
													{
														num71 = num72;
													}
													switch (num71)
													{
													}
												}
												goto end_IL_07dd;
											case 13:
												goto end_IL_07dd;
											}
											goto IL_0776;
											continue;
											end_IL_07dd:
											break;
										}
										goto end_IL_05be;
										IL_0776:
										num68 = num73;
										goto IL_07dd;
										end_IL_05be:;
									}
									catch (object obj6)
									{
										num74 = 0;
										if (!smethod_189())
										{
											num74 = num75;
										}
										switch (num74)
										{
										}
									}
									goto case 151;
								case 151:
									smethod_183(Class25.object_6);
									num2 = 229;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 656:
									array7[0] = 109;
									num2 = 456;
									if (!smethod_189())
									{
										continue;
									}
									goto case 555;
								case 555:
									array7[1] = 115;
									goto case 91;
								case 91:
									array7[2] = 99;
									goto case 289;
								case 289:
									array7[3] = 111;
									num2 = 469;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 655:
									num3 = 182;
									num2 = 193;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 184;
								case 184:
									array2[13] = (byte)num3;
									goto case 667;
								case 654:
									intPtr4 = smethod_143(((object[])smethod_142(Class25.object_9))[0]);
									goto case 172;
								case 172:
									int_0 = intPtr4.ToInt32();
									num2 = 174;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 653:
									num3 = 162;
									num2 = 446;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 652:
									num4 = 107;
									goto case 503;
								case 503:
									array[5] = (byte)num4;
									goto case 539;
								case 539:
									num4 = 58;
									goto case 29;
								case 29:
									array[5] = (byte)num4;
									num = 377;
									goto case 377;
								case 377:
									array[5] = 109;
									goto case 543;
								case 543:
									num4 = 224;
									num2 = 629;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 651:
									array2[15] = 142;
									num2 = 519;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 49;
								case 49:
									if (smethod_115() == 4)
									{
										num2 = 179;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 27;
								case 27:
									smethod_26(intptr_2, intPtr3, (byte[])smethod_157(smethod_146(object_)), 4u, out intptr_3);
									num2 = 268;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 462;
								case 413:
									num62++;
									num2 = 350;
									if (!smethod_189())
									{
										continue;
									}
									goto case 365;
								case 365:
								case 391:
									if (num62 < num60)
									{
										goto case 101;
									}
									num2 = 67;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 133;
								case 101:
									intPtr3 = new IntPtr(long_0 + smethod_146(object_) - num42);
									goto case 507;
								case 507:
									smethod_27(intPtr3, 4, 4, ref int_3);
									goto case 49;
								case 462:
								case 572:
									smethod_27(intPtr3, 4, int_3, ref int_3);
									goto case 413;
								case 133:
								case 590:
									if (smethod_158(smethod_134(object_)) < smethod_136(smethod_134(object_)) - 1L)
									{
										num2 = 384;
										if (smethod_190() == null)
										{
											continue;
										}
										goto case 107;
									}
									goto case 609;
								case 107:
									array[15] = (byte)num4;
									goto case 268;
								case 268:
									array[15] = 144;
									num2 = 589;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 609:
									smethod_160(intptr_2);
									num2 = 187;
									if (!smethod_189())
									{
										continue;
									}
									goto case 402;
								case 650:
									num61 = smethod_146(object_);
									goto case 291;
								case 291:
									if (num61 == 1)
									{
										num2 = 662;
										if (smethod_190() == null)
										{
											continue;
										}
										goto case 559;
									}
									num24 = 0;
									num2 = 574;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 214;
								case 559:
									int_ = 0;
									goto case 340;
								case 340:
									if (!smethod_174(smethod_173(smethod_162(typeof(Class25).TypeHandle).Assembly), null))
									{
										goto case 657;
									}
									goto case 450;
								case 450:
									if (((Array)smethod_177(smethod_173(smethod_162(typeof(Class25).TypeHandle).Assembly))).Length == 2)
									{
										num2 = 566;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 657;
								case 214:
									num4 = 145;
									num2 = 490;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 649:
									array2[2] = (byte)num3;
									num2 = 24;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 648:
									num3 = 160;
									num2 = 183;
									if (smethod_189())
									{
										continue;
									}
									goto case 101;
								case 647:
									num48 = (uint)(num67 * 4);
									goto case 76;
								case 76:
									num17 = (uint)((array17[num48 + 3] << 24) | (array17[num48 + 2] << 16) | (array17[num48 + 1] << 8) | array17[num48]);
									goto case 614;
								case 614:
									num65 = 255u;
									goto case 238;
								case 238:
									num66 = 0;
									goto case 16;
								case 16:
									if (num19 == num20 - 1)
									{
										num2 = 7;
										if (smethod_190() != null)
										{
											continue;
										}
										goto case 125;
									}
									goto case 213;
								case 125:
									if (num25 > 0)
									{
										num2 = 224;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 213;
								case 213:
									num48 = (uint)num27;
									goto case 644;
								case 644:
									num16 += num17;
									num2 = 457;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 646:
									smethod_27(new IntPtr(value), smethod_115(), 64, ref int_);
									num2 = 115;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 645:
									array2[21] = 56;
									goto case 420;
								case 420:
									num3 = 134;
									goto case 203;
								case 203:
									array2[21] = (byte)num3;
									goto case 454;
								case 454:
									num3 = 149;
									num2 = 187;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 643:
									array2[23] = 166;
									num2 = 283;
									if (!smethod_189())
									{
										continue;
									}
									goto case 483;
								case 483:
									num3 = 162;
									goto case 581;
								case 581:
									array2[23] = (byte)num3;
									num2 = 285;
									if (!smethod_189())
									{
										continue;
									}
									goto case 401;
								case 401:
									array2[23] = 197;
									num2 = 239;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 642:
									num3 = 129;
									goto case 3;
								case 3:
									array2[29] = (byte)num3;
									goto case 270;
								case 270:
									array2[29] = 207;
									goto case 173;
								case 173:
									num3 = 89;
									goto case 512;
								case 512:
									array2[30] = (byte)num3;
									num = 458;
									goto case 458;
								case 458:
									num3 = 91;
									goto case 632;
								case 632:
									array2[30] = (byte)num3;
									goto case 677;
								case 346:
								case 641:
									num19++;
									goto case 105;
								case 105:
								case 616:
									if (num19 >= num20)
									{
										goto case 486;
									}
									goto case 227;
								case 486:
									array8 = array15;
									num2 = 77;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 227:
									num67 = num19 % num52;
									goto case 558;
								case 558:
									num27 = num19 * 4;
									num2 = 647;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 640:
									intptr_4 = new IntPtr(long_0 + num38 - num42);
									num2 = 549;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 324;
								case 324:
									intptr_5 = LoadLibrary(text);
									goto case 149;
								case 149:
									if (smethod_166(intptr_5, IntPtr.Zero))
									{
										goto case 665;
									}
									num2 = 303;
									if (smethod_189())
									{
										continue;
									}
									goto case 3;
								case 602:
								case 638:
									smethod_107(array9, 0, intPtr2, array9.Length);
									goto case 286;
								case 286:
									bool_0 = false;
									num = 646;
									goto case 646;
								case 109:
									if (num54 > 0)
									{
										num2 = 101;
										if (smethod_190() != null)
										{
											continue;
										}
										goto case 369;
									}
									goto case 617;
								case 369:
									num65 <<= 8;
									num2 = 70;
									if (!smethod_189())
									{
										continue;
									}
									goto case 146;
								case 146:
									num66 += 8;
									num2 = 247;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 617;
								case 617:
									array15[num27 + num54] = (byte)((num53 & num65) >> num66);
									num2 = 522;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 523;
								case 523:
									num54++;
									goto case 18;
								case 18:
								case 637:
									if (num54 >= num25)
									{
										num2 = 508;
										if (smethod_190() != null)
										{
											continue;
										}
										goto case 346;
									}
									goto case 109;
								case 304:
								case 636:
									if (num50 >= num25)
									{
										goto case 117;
									}
									goto case 130;
								case 117:
								case 341:
									num16 = num16;
									goto case 625;
								case 625:
								{
									num63 = num16;
									uint num64 = num16;
									num64 ^= num64 << 1;
									num64 += 4052235136u;
									num64 ^= num64 >> 27;
									num64 += 2298058292u;
									num64 ^= num64 << 27;
									num64 += 2374016581u;
									num64 = 3124738051u - num64;
									num16 = num63 + (uint)(double)num64;
									num2 = 230;
									if (smethod_189())
									{
										continue;
									}
									goto case 1;
								}
								case 1:
									array2[10] = (byte)num3;
									goto case 392;
								case 392:
									num3 = 106;
									num2 = 357;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 130:
									if (num50 > 0)
									{
										goto case 202;
									}
									goto case 66;
								case 202:
									num18 <<= 8;
									num2 = 66;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 66:
									num18 |= array16[^(1 + num50)];
									num2 = 73;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 635:
									array9[num8 + 3] = array6[3];
									num2 = 522;
									if (smethod_189())
									{
										continue;
									}
									goto case 217;
								case 217:
									num60 = smethod_146(object_);
									goto case 650;
								case 634:
									num3 = 150;
									goto case 481;
								case 481:
									array2[21] = (byte)num3;
									num = 79;
									goto case 79;
								case 79:
									num3 = 159;
									goto case 272;
								case 272:
									array2[22] = (byte)num3;
									goto case 610;
								case 610:
									num3 = 150;
									num = 556;
									goto case 556;
								case 556:
									array2[22] = (byte)num3;
									goto case 61;
								case 61:
									num3 = 102;
									goto case 54;
								case 54:
									array2[22] = (byte)num3;
									num2 = 72;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 633:
									array2[17] = (byte)num3;
									goto case 209;
								case 209:
									array2[17] = 144;
									goto case 653;
								case 631:
									array2[7] = (byte)num3;
									goto case 102;
								case 102:
									array2[7] = 102;
									goto case 255;
								case 255:
									array2[7] = 208;
									goto case 110;
								case 110:
									array2[8] = 115;
									goto case 546;
								case 546:
									array2[8] = 105;
									goto case 431;
								case 431:
									array2[8] = 107;
									num2 = 385;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 300;
								case 300:
									array[6] = 77;
									goto case 8;
								case 8:
									array[6] = 112;
									num2 = 671;
									if (smethod_189())
									{
										continue;
									}
									goto case 2;
								case 630:
									num62 = 0;
									goto case 365;
								case 629:
									array[5] = (byte)num4;
									goto case 433;
								case 433:
									array[6] = 112;
									num2 = 300;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 628:
									array9[num15 + 1] = array10[1];
									num2 = 205;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 627:
									array2[10] = (byte)num3;
									num2 = 550;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 626:
									array[3] = 116;
									num2 = 212;
									if (smethod_189())
									{
										continue;
									}
									goto case 137;
								case 137:
									array7[5] = 106;
									goto case 294;
								case 294:
									array7[6] = 105;
									goto case 131;
								case 131:
									array7[7] = 116;
									goto case 288;
								case 288:
									array7[8] = 46;
									num2 = 500;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 624:
									array2[13] = (byte)num3;
									goto case 31;
								case 31:
									array2[14] = 94;
									num2 = 248;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 2;
								case 623:
									smethod_161(Class25.object_8, 0L, struct2);
									goto case 114;
								case 114:
									flag2 = false;
									num = 48;
									goto case 48;
								case 48:
								case 152:
									if (smethod_158(smethod_134(object_)) < smethod_136(smethod_134(object_)) - 1L)
									{
										num2 = 480;
										if (smethod_189())
										{
											continue;
										}
										goto case 143;
									}
									goto case 284;
								case 143:
									num3 = 0;
									goto case 598;
								case 598:
									array2[14] = (byte)num3;
									goto case 651;
								case 284:
									intPtr4 = smethod_143(((object[])smethod_142(smethod_162(typeof(Class25).TypeHandle).Assembly))[0]);
									goto case 65;
								case 65:
									long_1 = intPtr4.ToInt64();
									goto case 34;
								case 34:
									if (smethod_115() == 4)
									{
										num = 63;
										goto case 63;
									}
									goto case 138;
								case 63:
									Class25.int_2 = smethod_163(long_1);
									num = 138;
									goto case 138;
								case 138:
									array7 = new byte[12];
									goto case 656;
								case 622:
									array[0] = 96;
									num = 336;
									goto case 336;
								case 336:
									num4 = 144;
									goto case 577;
								case 577:
									array[0] = (byte)num4;
									num = 492;
									goto case 492;
								case 492:
									array[0] = 83;
									goto case 208;
								case 208:
									array[0] = 68;
									goto case 12;
								case 12:
									num4 = 31;
									num2 = 619;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 621:
									array2[11] = 92;
									num2 = 655;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 620:
									array13[2] = 116;
									goto case 199;
								case 199:
									array13[3] = 74;
									goto case 514;
								case 514:
									array13[4] = 105;
									num = 436;
									goto case 436;
								case 436:
									array13[5] = 116;
									num2 = 276;
									if (smethod_189())
									{
										continue;
									}
									goto case 3;
								case 619:
									array[0] = (byte)num4;
									num2 = 18;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 120;
								case 120:
									num4 = 84;
									num2 = 366;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 615:
									num3 = 102;
									num2 = 206;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 613:
									array2[13] = 168;
									goto case 163;
								case 163:
									num3 = 158;
									num2 = 378;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 611:
									array2[16] = (byte)num3;
									num2 = 116;
									if (smethod_189())
									{
										continue;
									}
									goto case 20;
								case 20:
									num4 = 145;
									goto case 494;
								case 494:
									array[12] = (byte)num4;
									goto case 95;
								case 95:
									array[12] = 135;
									goto case 112;
								case 112:
									array[12] = 168;
									goto case 317;
								case 317:
									array[12] = 188;
									num = 118;
									goto case 118;
								case 118:
									num4 = 162;
									goto case 390;
								case 390:
									array[13] = (byte)num4;
									num2 = 142;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 282;
								case 282:
									array[13] = 114;
									goto case 43;
								case 43:
									num4 = 150;
									goto case 306;
								case 306:
									array[13] = (byte)num4;
									goto case 373;
								case 373:
									num4 = 152;
									num2 = 553;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 608:
									array2[8] = (byte)num3;
									goto case 411;
								case 411:
									num3 = 114;
									num2 = 241;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 607:
									array2[27] = (byte)num3;
									goto case 312;
								case 312:
									num3 = 102;
									num2 = 105;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 591;
								case 591:
									array2[28] = (byte)num3;
									goto case 159;
								case 159:
									array2[28] = 125;
									num2 = 516;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 606:
									array[5] = 118;
									num2 = 652;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 605:
									array15[num27 + 2] = (byte)((num26 & 0xFF0000) >> 16);
									goto case 416;
								case 416:
									array15[num27 + 3] = (byte)((num26 & 0xFF000000u) >> 24);
									num2 = 346;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 604:
									array[14] = 66;
									goto case 180;
								case 180:
									num4 = 85;
									num2 = 87;
									if (!smethod_189())
									{
										continue;
									}
									goto case 532;
								case 532:
									array[14] = (byte)num4;
									goto case 219;
								case 219:
									array[14] = 141;
									goto case 144;
								case 144:
									num4 = 79;
									goto case 674;
								case 603:
									value = 0L;
									goto case 361;
								case 361:
									if (smethod_115() == 4)
									{
										goto case 100;
									}
									goto case 60;
								case 60:
									value = smethod_170(intptr_6);
									num2 = 350;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 40;
								case 40:
									array2[19] = 91;
									goto case 225;
								case 225:
									array2[19] = 170;
									goto case 464;
								case 464:
									array2[19] = 108;
									goto case 568;
								case 568:
									array2[19] = 124;
									goto case 42;
								case 42:
									num3 = 246;
									goto case 668;
								case 574:
								case 601:
									if (num24 >= num60)
									{
										num2 = 599;
										if (smethod_189())
										{
											continue;
										}
										break;
									}
									goto case 426;
								case 426:
									intptr_ = new IntPtr(num11 + smethod_146(object_) - num42);
									goto case 669;
								case 600:
									num4 = 142;
									goto case 235;
								case 235:
									array[9] = (byte)num4;
									goto case 418;
								case 418:
									array[9] = 40;
									num2 = 32;
									if (smethod_189())
									{
										continue;
									}
									goto case 23;
								case 23:
									array2[8] = 87;
									num2 = 201;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 540;
								case 540:
									num3 = 120;
									goto case 465;
								case 465:
									array2[9] = (byte)num3;
									goto case 438;
								case 438:
									num3 = 95;
									goto case 147;
								case 147:
									array2[9] = (byte)num3;
									num2 = 18;
									if (!smethod_189())
									{
										continue;
									}
									goto case 103;
								case 103:
									array2[9] = 96;
									goto case 579;
								case 579:
									array2[9] = 73;
									num = 545;
									goto case 545;
								case 545:
									num3 = 148;
									num2 = 1;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 599:
									Class25.object_8 = new Hashtable(smethod_146(object_) + 1);
									goto case 7;
								case 7:
									struct2 = default(Struct19);
									goto case 185;
								case 185:
									reference2 = ref struct2;
									array19 = new byte[1] { 42 };
									reference2.byte_0 = array19;
									num2 = 222;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 597:
									num4 = 207;
									num2 = 11;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 596:
									num42 = 7680;
									num2 = 595;
									if (smethod_189())
									{
										continue;
									}
									goto case 563;
								case 563:
									array[6] = 75;
									num2 = 497;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 129;
								case 129:
									num42 = 0;
									num2 = 370;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 517:
								case 595:
									num60 = smethod_146(object_);
									goto case 437;
								case 437:
									num61 = smethod_146(object_);
									goto case 113;
								case 113:
									if (num61 == 4)
									{
										num2 = 445;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 291;
								case 594:
									num3 = 225;
									goto case 499;
								case 499:
									array2[15] = (byte)num3;
									num2 = 565;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 593:
									@struct.byte_0 = byte_;
									goto case 56;
								case 56:
									@struct.bool_0 = flag2;
									num2 = 177;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 17;
								case 17:
									enumerator = (IEnumerator)smethod_119(object_14);
									num2 = 247;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 589:
									array[15] = 124;
									goto case 573;
								case 573:
									array3 = array;
									goto case 472;
								case 472:
									smethod_138(array3);
									goto case 323;
								case 323:
									array11 = (byte[])smethod_140(smethod_139(Class25.object_9));
									goto case 104;
								case 104:
									if (array11 != null)
									{
										goto case 367;
									}
									goto case 310;
								case 367:
									if (array11.Length > 0)
									{
										goto case 552;
									}
									goto case 310;
								case 552:
									array3[1] = array11[0];
									num2 = 169;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 310:
									num47 = 0;
									goto case 135;
								case 135:
								case 218:
									if (num47 >= array3.Length)
									{
										num2 = 463;
										if (smethod_189())
										{
											continue;
										}
										break;
									}
									goto case 455;
								case 455:
									array17[num47] = (byte)(array17[num47] ^ array3[num47]);
									num2 = 447;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 588:
									array2[0] = (byte)num3;
									num2 = 319;
									if (!smethod_189())
									{
										continue;
									}
									goto case 356;
								case 356:
									array2[1] = 156;
									goto case 250;
								case 250:
									array2[1] = 133;
									num2 = 5;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 587:
									array[4] = (byte)num4;
									goto case 606;
								case 586:
									array2[16] = 142;
									num2 = 525;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 585:
									if (smethod_115() == 4)
									{
										num2 = 106;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 676;
								case 584:
									array2[31] = (byte)num3;
									num2 = 16;
									if (!smethod_189())
									{
										continue;
									}
									goto case 123;
								case 123:
									array2[31] = 213;
									goto case 405;
								case 405:
									array17 = array2;
									goto case 387;
								case 387:
									array = new byte[16];
									goto case 622;
								case 583:
									array2[13] = 59;
									num = 501;
									goto case 501;
								case 501:
									array2[13] = 86;
									goto case 613;
								case 582:
									if (num51 >= 1879048192)
									{
										goto case 343;
									}
									goto case 509;
								case 343:
									flag2 = true;
									goto case 509;
								case 509:
									int_2 = smethod_146(object_);
									num2 = 53;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 578:
									smethod_114();
									num2 = 382;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 576:
									long_0 = intPtr4.ToInt64();
									goto case 211;
								case 211:
									intptr_3 = IntPtr.Zero;
									goto case 630;
								case 575:
									num16 = 0u;
									num = 406;
									goto case 406;
								case 406:
									num17 = 0u;
									num2 = 317;
									if (!smethod_189())
									{
										continue;
									}
									goto case 533;
								case 533:
									num18 = 0u;
									goto case 372;
								case 372:
									if (num25 > 0)
									{
										goto case 560;
									}
									goto case 33;
								case 560:
									num20++;
									num2 = 33;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 33:
									num48 = 0u;
									num2 = 330;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 571:
									array9[num8 + 4] = array10[4];
									goto case 459;
								case 459:
									array9[num8 + 5] = array10[5];
									goto case 432;
								case 432:
									array9[num8 + 6] = array10[6];
									num = 297;
									goto case 297;
								case 297:
									array9[num8 + 7] = array10[7];
									num2 = 680;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 570:
									array2[24] = (byte)num3;
									num = 679;
									goto case 679;
								case 569:
									array[7] = 96;
									num2 = 664;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 567:
									array9[num15] = array12[0];
									num = 351;
									goto case 351;
								case 351:
									array9[num15 + 1] = array12[1];
									num2 = 198;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 566:
									if (smethod_144(smethod_162(typeof(Class25).TypeHandle).Assembly) != null)
									{
										num2 = 477;
										if (smethod_189())
										{
											continue;
										}
										break;
									}
									goto case 657;
								case 565:
									array2[16] = 117;
									goto case 64;
								case 64:
									num3 = 160;
									goto case 544;
								case 544:
									array2[16] = (byte)num3;
									num2 = 256;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 243;
								case 243:
									array7[7] = 100;
									goto case 439;
								case 439:
									array7[8] = 108;
									goto case 424;
								case 424:
									array7[9] = 108;
									goto case 379;
								case 379:
									text = (string)smethod_165(smethod_164(), array7);
									num2 = 417;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 564:
									array13[0] = 103;
									goto case 228;
								case 228:
									array13[1] = 101;
									goto case 620;
								case 562:
									num20 = array16.Length / 4;
									goto case 240;
								case 240:
									array15 = new byte[array16.Length];
									num2 = 510;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 234:
								case 561:
									object_ = new Class28((Stream)smethod_133(Class25.object_9, "t3\u009du\u009e6\u008dp\u009c\u0099yn3b\u0091d\u008d\u0096.7\u0093\u008c\u0094ua\u008e\u009f\u008e\u009b\u008dlnp\u009e\u008a8d"));
									goto case 50;
								case 50:
									smethod_135(smethod_134(object_), 0L);
									goto case 57;
								case 57:
									array18 = (byte[])smethod_137(object_, (int)smethod_136(smethod_134(object_)));
									num2 = 210;
									if (!smethod_189())
									{
										continue;
									}
									goto case 359;
								case 359:
									array2 = new byte[32];
									goto case 615;
								case 557:
									smethod_141(array11, 0, array11.Length);
									num2 = 310;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 554:
									array9[num8] = array10[0];
									num2 = 161;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 553:
									array[13] = (byte)num4;
									goto case 604;
								case 551:
									array2[14] = (byte)num3;
									num2 = 143;
									if (smethod_189())
									{
										continue;
									}
									goto case 106;
								case 106:
									num13 = smethod_169(new IntPtr(value));
									num2 = 407;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 385;
								case 385:
									num3 = 114;
									goto case 608;
								case 550:
									array2[10] = 143;
									goto case 302;
								case 302:
									array2[10] = 94;
									num2 = 339;
									if (smethod_189())
									{
										continue;
									}
									goto case 55;
								case 55:
									num3 = 151;
									num2 = 425;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 549:
									num14 = smethod_146(object_);
									num2 = 196;
									if (smethod_189())
									{
										continue;
									}
									goto case 73;
								case 73:
									num50++;
									num2 = 636;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 178:
									smethod_159(new IntPtr(intptr_4.ToInt64() + num10 * 4), smethod_146(object_));
									goto case 314;
								case 314:
									num10++;
									goto case 253;
								case 253:
								case 548:
									if (num10 < num14)
									{
										goto case 178;
									}
									goto case 342;
								case 342:
									smethod_27(intptr_4, num14 * 4, int_3, ref int_3);
									num2 = 590;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 586;
								case 547:
									array7[4] = 105;
									goto case 316;
								case 316:
									array7[5] = 116;
									goto case 158;
								case 158:
									array7[6] = 46;
									goto case 243;
								case 249:
								case 542:
									intPtr2 = smethod_187(IntPtr.Zero, (uint)array5.Length, 4096u, 64u);
									goto case 364;
								case 364:
									array9 = array5;
									goto case 277;
								case 277:
									array6 = null;
									num2 = 123;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 354;
								case 354:
									array10 = null;
									num = 333;
									goto case 333;
								case 333:
									array12 = null;
									goto case 85;
								case 85:
									if (smethod_115() == 4)
									{
										goto case 506;
									}
									goto case 38;
								case 506:
									array12 = (byte[])smethod_157(Class25.intptr_2.ToInt32());
									num2 = 52;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 38:
									array12 = (byte[])smethod_182(Class25.intptr_2.ToInt64());
									goto case 128;
								case 128:
									array6 = (byte[])smethod_182(intPtr.ToInt64());
									num = 298;
									goto case 298;
								case 298:
									array10 = (byte[])smethod_182(num13);
									num = 299;
									goto case 299;
								case 299:
								case 468:
									if (smethod_115() == 4)
									{
										goto case 10;
									}
									goto case 236;
								case 10:
									num15 = 9;
									goto case 567;
								case 236:
									num8 = 2;
									goto case 319;
								case 319:
									array9[num8] = array12[0];
									goto case 409;
								case 409:
									array9[num8 + 1] = array12[1];
									num2 = 290;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 541:
									array3[13] = array11[6];
									num2 = 491;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 425;
								case 425:
									array2[12] = (byte)num3;
									num2 = 388;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 538:
									smethod_150(object_6, array18, 0, array18.Length);
									num2 = 360;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 537:
									array2[0] = (byte)num3;
									goto case 186;
								case 186:
									array2[0] = 156;
									num = 301;
									goto case 301;
								case 301:
									num3 = 244;
									goto case 588;
								case 536:
									try
									{
										Class25.object_6 = (Delegate3)smethod_167(new IntPtr(num13), smethod_162(typeof(Delegate3).TypeHandle));
										num55 = 0;
										if (smethod_190() == null)
										{
											switch (num55)
											{
											}
										}
									}
									catch (object obj4)
									{
										num56 = 1;
										if (smethod_190() == null)
										{
											switch (num56)
											{
											default:
												goto end_IL_2133;
											case 1:
												break;
											case 0:
												goto end_IL_2133;
											}
										}
										try
										{
											Delegate object_15 = (Delegate)smethod_167(new IntPtr(num13), smethod_162(typeof(Delegate3).TypeHandle));
											num57 = 0;
											if (smethod_190() != null)
											{
												goto IL_217b;
											}
											goto IL_21a7;
											IL_21a7:
											switch (num57)
											{
											case 1:
												goto end_IL_2156;
											}
											goto IL_217b;
											IL_217b:
											Class25.object_6 = (Delegate3)smethod_176(smethod_162(typeof(Delegate3).TypeHandle), smethod_175(object_15));
											num57 = 0;
											if (!smethod_189())
											{
												goto IL_21a7;
											}
											end_IL_2156:;
										}
										catch (object obj3)
										{
											num58 = 0;
											if (smethod_190() != null)
											{
												num58 = num59;
											}
											switch (num58)
											{
											default:
												goto end_IL_21b9;
											}
											end_IL_21b9:;
										}
										end_IL_2133:;
									}
									goto case 398;
								case 398:
									num2 = 559;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 535:
									array[1] = 48;
									num = 666;
									goto case 666;
								case 531:
									flag2 = false;
									num2 = 582;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 530:
									num13 = 0L;
									goto case 585;
								case 529:
									array3[9] = array11[4];
									num = 476;
									goto case 476;
								case 476:
									array3[11] = array11[5];
									num = 541;
									goto case 541;
								case 528:
									array[9] = 148;
									goto case 600;
								case 527:
									array2[27] = (byte)num3;
									num2 = 487;
									if (smethod_189())
									{
										continue;
									}
									goto case 442;
								case 442:
									smethod_104(new IntPtr(&num7), 0, 0);
									goto case 393;
								case 393:
									smethod_105(new IntPtr(&num7), 0, 0L);
									num = 353;
									goto case 353;
								case 353:
									array19 = new byte[1];
									goto case 215;
								case 215:
									smethod_107(array19, 0, smethod_106(8), 1);
									num2 = 251;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 526:
									array2[5] = 144;
									num = 261;
									goto case 261;
								case 261:
									array2[5] = 6;
									num = 124;
									goto case 124;
								case 124:
									num3 = 75;
									num2 = 237;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 525:
									num3 = 112;
									num = 611;
									goto case 611;
								case 524:
									array9[num8 + 6] = array6[6];
									goto case 338;
								case 338:
									array9[num8 + 7] = array6[7];
									goto case 602;
								case 522:
									array9[num8 + 4] = array6[4];
									goto case 383;
								case 383:
									array9[num8 + 5] = array6[5];
									goto case 524;
								case 520:
									num53 = num16 ^ num18;
									goto case 44;
								case 44:
									num54 = 0;
									goto case 18;
								case 519:
									num3 = 168;
									num = 473;
									goto case 473;
								case 473:
									array2[15] = (byte)num3;
									num2 = 80;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 518:
									array7[10] = 108;
									num2 = 192;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 48;
								case 516:
									array2[28] = 90;
									goto case 322;
								case 322:
									num3 = 131;
									num2 = 274;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 515:
									array[4] = (byte)num4;
									num2 = 4;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 513:
									smethod_154(object_);
									num2 = 217;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 510:
									num52 = array17.Length / 4;
									goto case 575;
								case 508:
									num3 = 88;
									num2 = 633;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 505:
									array3[5] = array11[2];
									goto case 175;
								case 175:
									array3[7] = array11[3];
									goto case 529;
								case 500:
									array7[9] = 100;
									goto case 518;
								case 498:
									array2[27] = 9;
									num2 = 22;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 497:
									num4 = 120;
									goto case 399;
								case 399:
									array[7] = (byte)num4;
									num2 = 30;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 496:
									num3 = 192;
									goto case 607;
								case 495:
									array2[2] = (byte)num3;
									goto case 259;
								case 259:
									array2[2] = 91;
									num2 = 441;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 491:
									array3[15] = array11[7];
									goto case 557;
								case 490:
									array[10] = (byte)num4;
									num2 = 9;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 489:
									array9[num8 + 5] = array12[5];
									num2 = 279;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 488:
									num3 = 132;
									goto case 456;
								case 456:
									array2[22] = (byte)num3;
									goto case 221;
								case 221:
									array2[22] = 156;
									num2 = 455;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 643;
								case 487:
									array2[27] = 101;
									goto case 496;
								case 485:
									array2[12] = (byte)num3;
									goto case 663;
								case 484:
									array9[num15] = array6[0];
									goto case 273;
								case 273:
									array9[num15 + 1] = array6[1];
									num = 422;
									goto case 422;
								case 422:
									array9[num15 + 2] = array6[2];
									goto case 81;
								case 81:
									array9[num15 + 3] = array6[3];
									goto case 602;
								case 482:
									num4 = 116;
									goto case 153;
								case 153:
									array[12] = (byte)num4;
									goto case 20;
								case 480:
									num12 = smethod_146(object_) - num42;
									goto case 374;
								case 374:
									num51 = smethod_146(object_);
									goto case 531;
								case 478:
									num50 = 0;
									goto case 304;
								case 477:
									if (smethod_145(smethod_144(smethod_162(typeof(Class25).TypeHandle).Assembly)) <= 0)
									{
										goto case 657;
									}
									goto case 578;
								case 475:
									array2[0] = 93;
									goto case 419;
								case 419:
									num3 = 98;
									goto case 537;
								case 474:
									goto IL_266a;
								case 332:
									object_ = new Class28(new MemoryStream(array8));
									num2 = 71;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 470:
									if (num49 == 4109628145u)
									{
										num2 = 280;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 296;
								case 296:
									if (smethod_115() != 4)
									{
										goto case 234;
									}
									goto case 69;
								case 69:
									if (!smethod_117(smethod_116("System.Reflection.ReflectionContext", bool_7: false), null))
									{
										goto case 234;
									}
									goto case 363;
								case 363:
									object_14 = (ProcessModuleCollection)smethod_118(smethod_109());
									goto case 17;
								case 469:
									array7[4] = 114;
									num = 137;
									goto case 137;
								case 467:
									smethod_153(object_6);
									num = 513;
									goto case 513;
								case 463:
									array16 = array18;
									num2 = 326;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 461:
									array[3] = 115;
									num = 362;
									goto case 362;
								case 362:
									array[3] = 13;
									goto case 386;
								case 386:
									array[3] = 104;
									goto case 626;
								case 460:
									num15 = 16;
									num2 = 156;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 267;
								case 267:
									array9[num15] = array10[0];
									num2 = 628;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 508;
								case 457:
									num18 = (uint)((array16[num48 + 3] << 24) | (array16[num48 + 2] << 16) | (array16[num48 + 1] << 8) | array16[num48]);
									goto case 117;
								case 452:
									num3 = 162;
									num2 = 184;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 451:
									procAddress = GetProcAddress(intptr_5, string_);
									num2 = 355;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 449:
									intptr_6 = smethod_168(object_7);
									goto case 603;
								case 448:
									array8 = (byte[])smethod_152(memoryStream);
									num2 = 41;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 447:
									num47++;
									goto case 135;
								case 446:
									array2[17] = (byte)num3;
									goto case 6;
								case 6:
									array2[18] = 169;
									goto case 430;
								case 430:
									array2[18] = 147;
									num2 = 245;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 71;
								case 71:
									smethod_135(smethod_134(object_), 0L);
									num2 = 188;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 445:
									object_13 = (SymmetricAlgorithm)smethod_147();
									goto case 223;
								case 223:
									smethod_148(object_13, CipherMode.CBC);
									goto case 283;
								case 283:
									transform = (ICryptoTransform)smethod_149(object_13, array17, array3);
									goto case 75;
								case 75:
									smethod_141(array17, 0, array17.Length);
									goto case 232;
								case 232:
									memoryStream = new MemoryStream();
									num2 = 335;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 444:
									array[11] = (byte)num4;
									num2 = 597;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 159;
								case 443:
									num4 = 41;
									num2 = 488;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 515;
								case 441:
									num3 = 99;
									num = 68;
									goto case 68;
								case 68:
									array2[3] = (byte)num3;
									goto case 269;
								case 269:
									array2[3] = 108;
									goto case 660;
								case 440:
									uint_ = (Enum9)56;
									goto case 207;
								case 207:
									intptr_2 = smethod_156((uint)uint_, 1, (uint)smethod_155(smethod_109()));
									goto case 166;
								case 166:
									if (smethod_115() == 4)
									{
										goto case 654;
									}
									goto case 174;
								case 174:
									intPtr4 = smethod_143(((object[])smethod_142(Class25.object_9))[0]);
									goto case 576;
								case 407:
								case 435:
									object_8 = (Process)smethod_109();
									num2 = 368;
									if (smethod_189())
									{
										continue;
									}
									goto case 186;
								case 429:
									text = (string)smethod_165(smethod_164(), array7);
									num2 = 324;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 427:
									try
									{
										ProcessModuleCollection object_11 = (ProcessModuleCollection)smethod_118(object_8);
										num39 = 0;
										if (smethod_189())
										{
											goto IL_29d5;
										}
										goto IL_29ef;
										IL_29ef:
										switch (num39)
										{
										case 1:
											break;
										default:
											goto end_IL_29bf;
										case 2:
											try
											{
												while (true)
												{
													if (!smethod_131(enumerator))
													{
														num40 = 1;
														if (!smethod_189())
														{
															goto IL_2a09;
														}
														goto IL_2a0d;
													}
													goto IL_2a2e;
													IL_2a0d:
													switch (num40)
													{
													case 3:
														intPtr4 = smethod_111(object_12);
														num41 = 2;
														goto case 2;
													case 2:
														if (intPtr4.ToInt64() != long_1)
														{
															continue;
														}
														goto case 6;
													case 4:
														continue;
													case 6:
														num42 = 0;
														goto end_IL_2a7c;
													case 1:
													case 5:
														goto end_IL_2a7c;
													}
													goto IL_2a2e;
													IL_2a2e:
													object_12 = (ProcessModule)smethod_120(enumerator);
													num40 = 3;
													if (smethod_190() != null)
													{
														goto IL_2a09;
													}
													goto IL_2a0d;
													IL_2a09:
													num40 = num41;
													goto IL_2a0d;
													continue;
													end_IL_2a7c:
													break;
												}
											}
											finally
											{
												IDisposable disposable = enumerator as IDisposable;
												num43 = 0;
												if (smethod_190() != null)
												{
													goto IL_2abe;
												}
												goto IL_2ac4;
												IL_2ac4:
												switch (num43)
												{
												case 2:
													break;
												default:
													goto IL_2abe;
												case 1:
													goto end_IL_2a8c;
												}
												goto IL_2aa4;
												IL_2abe:
												if (disposable != null)
												{
													goto IL_2aa4;
												}
												goto end_IL_2a8c;
												IL_2aa4:
												smethod_132(disposable);
												num43 = 1;
												if (!smethod_189())
												{
													num43 = num44;
												}
												goto IL_2ac4;
												end_IL_2a8c:;
											}
											goto end_IL_29bf;
										case 0:
											goto end_IL_29bf;
										}
										goto IL_29d5;
										IL_29d5:
										enumerator = (IEnumerator)smethod_119(object_11);
										num39 = 2;
										if (!smethod_189())
										{
											num39 = num45;
										}
										goto IL_29ef;
										end_IL_29bf:;
									}
									catch (object obj2)
									{
										num46 = 0;
										if (smethod_190() != null)
										{
											switch (num46)
											{
											}
										}
									}
									goto case 14;
								case 421:
									array[11] = (byte)num4;
									num2 = 307;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 417:
									intptr_5 = LoadLibrary(text);
									goto case 39;
								case 39:
								case 303:
									array13 = new byte[6];
									goto case 564;
								case 415:
									num4 = 143;
									num2 = 15;
									if (!smethod_189())
									{
										continue;
									}
									goto case 51;
								case 51:
									array[8] = (byte)num4;
									goto case 287;
								case 287:
									array[9] = 121;
									num = 528;
									goto case 528;
								case 414:
									array2[29] = 104;
									num2 = 642;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 412:
									array2[31] = (byte)num3;
									num2 = 403;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 314;
								case 410:
									array[3] = (byte)num4;
									num2 = 165;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 404:
									array7[1] = 108;
									goto case 321;
								case 321:
									array7[2] = 114;
									goto case 313;
								case 313:
									array7[3] = 106;
									num = 547;
									goto case 547;
								case 403:
									num3 = 132;
									num2 = 584;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 400:
									array[1] = (byte)num4;
									num2 = 535;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 397:
									array[1] = 134;
									num2 = 661;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 394:
									array2[15] = (byte)num3;
									num = 220;
									goto case 220;
								case 220:
									num3 = 114;
									num2 = 164;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 389:
									array[2] = 171;
									goto case 461;
								case 388:
									num3 = 199;
									goto case 485;
								case 384:
									num38 = smethod_146(object_);
									goto case 640;
								case 381:
									array2[16] = (byte)num3;
									goto case 586;
								case 380:
									@struct = default(Struct19);
									goto case 593;
								case 378:
									array2[13] = (byte)num3;
									goto case 452;
								case 376:
									num4 = 224;
									num2 = 587;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 375:
									array[11] = (byte)num4;
									num = 134;
									goto case 134;
								case 134:
									array[12] = 154;
									goto case 482;
								case 371:
									if (smethod_145(smethod_144(Class25.object_9)) != 0)
									{
										num2 = 517;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 596;
								case 370:
									if (smethod_144(Class25.object_9) == null)
									{
										goto case 596;
									}
									goto case 371;
								case 368:
									try
									{
										ProcessModuleCollection object_9 = (ProcessModuleCollection)smethod_118(object_8);
										num28 = 1;
										if (smethod_190() != null)
										{
											num28 = num29;
										}
										switch (num28)
										{
										default:
											goto end_IL_2d7a;
										case 1:
											enumerator = (IEnumerator)smethod_119(object_9);
											num29 = 2;
											break;
										case 2:
											break;
										case 0:
											goto end_IL_2d7a;
										}
										try
										{
											while (smethod_131(enumerator))
											{
												while (true)
												{
													IL_2e85:
													ProcessModule object_10 = (ProcessModule)smethod_120(enumerator);
													num30 = 0;
													if (smethod_190() == null)
													{
														goto IL_2e34;
													}
													goto IL_2e5a;
													IL_2e5a:
													while (true)
													{
														switch (num30)
														{
														case 8:
															break;
														case 7:
															goto IL_2df5;
														case 4:
															goto IL_2e09;
														case 1:
															goto IL_2e34;
														default:
															smethod_114();
															num30 = 2;
															if (smethod_190() == null)
															{
																continue;
															}
															goto IL_2e34;
														case 6:
															goto IL_2e85;
														case 5:
															goto end_IL_2e85;
														case 2:
															return;
														case 3:
															goto end_IL_2ea2;
														}
														break;
													}
													goto IL_2dc3;
													IL_2e34:
													if (!smethod_123(smethod_121(object_10), text))
													{
														break;
													}
													goto IL_2df5;
													IL_2df5:
													num31 = num13;
													intPtr4 = smethod_111(object_10);
													if (num31 < intPtr4.ToInt64())
													{
														goto IL_2dc3;
													}
													goto IL_2e09;
													IL_2e09:
													num32 = num13;
													intPtr4 = smethod_111(object_10);
													if (num32 <= intPtr4.ToInt64() + smethod_172(object_10))
													{
														break;
													}
													num30 = 8;
													if (!smethod_189())
													{
														goto end_IL_2ea2;
													}
													goto IL_2e5a;
													IL_2dc3:
													if (!smethod_174(smethod_173(smethod_162(typeof(Class25).TypeHandle).Assembly), null))
													{
														break;
													}
													num30 = 0;
													if (smethod_190() != null)
													{
														num30 = num33;
													}
													goto IL_2e5a;
													continue;
													end_IL_2e85:
													break;
												}
												continue;
												end_IL_2ea2:
												break;
											}
										}
										finally
										{
											IDisposable disposable = enumerator as IDisposable;
											while (disposable != null)
											{
												num34 = 1;
												if (!smethod_189())
												{
													goto IL_2ee3;
												}
												goto IL_2ee7;
												IL_2ee3:
												num34 = num35;
												goto IL_2ee7;
												IL_2ee7:
												while (true)
												{
													switch (num34)
													{
													case 1:
														goto IL_2ecf;
													default:
														goto end_IL_2ee7;
													case 2:
														break;
													case 0:
														goto end_IL_2ee7;
													}
													goto IL_2efa;
													IL_2ecf:
													smethod_132(disposable);
													num34 = 0;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_2ee3;
													continue;
													end_IL_2ee7:
													break;
												}
												break;
												IL_2efa:;
											}
										}
										end_IL_2d7a:;
									}
									catch (object obj)
									{
										num36 = 0;
										if (smethod_190() != null)
										{
											num36 = num37;
										}
										switch (num36)
										{
										}
									}
									goto case 427;
								case 366:
									array[1] = (byte)num4;
									goto case 397;
								case 360:
									smethod_151(object_6);
									goto case 448;
								case 358:
									smethod_101(new IntPtr(&num7), 0);
									goto case 108;
								case 108:
									smethod_102(new IntPtr(&num7), 0);
									goto case 132;
								case 132:
									smethod_103(new IntPtr(&num7), 0, IntPtr.Zero);
									goto case 442;
								case 357:
									array2[10] = (byte)num3;
									goto case 345;
								case 345:
									num3 = 124;
									num2 = 627;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 355:
									object_7 = (Delegate4)smethod_167(procAddress, smethod_162(typeof(Delegate4).TypeHandle));
									num2 = 449;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 352:
									array2[26] = 88;
									goto case 648;
								case 349:
									array2[20] = (byte)num3;
									goto case 258;
								case 258:
									array2[21] = 89;
									goto case 645;
								case 344:
									num3 = 136;
									goto case 649;
								case 339:
									num3 = 172;
									goto case 168;
								case 168:
									array2[11] = (byte)num3;
									num = 621;
									goto case 621;
								case 337:
									array[10] = 46;
									goto case 210;
								case 210:
									num4 = 105;
									num2 = 421;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 335:
									object_6 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
									goto case 538;
								case 334:
									num3 = 119;
									num2 = 675;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 331:
									num4 = 168;
									goto case 444;
								case 330:
									num19 = 0;
									goto case 105;
								case 328:
									array[8] = (byte)num4;
									goto case 415;
								case 326:
									num25 = array16.Length % 4;
									num2 = 562;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 325:
									num3 = 131;
									goto case 412;
								case 318:
									if (num25 > 0)
									{
										num2 = 520;
										if (smethod_190() == null)
										{
											continue;
										}
										break;
									}
									goto case 254;
								case 254:
									num26 = num16 ^ num18;
									goto case 189;
								case 189:
									array15[num27] = (byte)(num26 & 0xFFu);
									num2 = 1;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 111;
								case 111:
									array15[num27 + 1] = (byte)((num26 & 0xFF00) >> 8);
									goto case 605;
								case 305:
								case 315:
									num5 = 0;
									num2 = 93;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 311:
									array5 = null;
									num2 = 25;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 309:
									array2[29] = (byte)num3;
									num = 157;
									goto case 157;
								case 157:
									array2[29] = 129;
									goto case 414;
								case 308:
									num24++;
									num = 601;
									goto case 574;
								case 307:
									num4 = 5;
									goto case 171;
								case 171:
									array[11] = (byte)num4;
									num2 = 331;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 293:
									array2[16] = (byte)num3;
									goto case 508;
								case 290:
									array9[num8 + 2] = array12[2];
									goto case 86;
								case 86:
									array9[num8 + 3] = array12[3];
									num2 = 264;
									if (smethod_189())
									{
										continue;
									}
									goto case 102;
								case 285:
									int_3 = 0;
									goto case 129;
								case 281:
									array14 = new byte[40];
									smethod_186(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
									array5 = array14;
									goto case 249;
								case 280:
									flag = smethod_113(smethod_112(smethod_111(smethod_110(smethod_109())), "__", 10u), IntPtr.Zero);
									goto case 182;
								case 182:
									if (flag)
									{
										goto case 296;
									}
									goto case 156;
								case 279:
									array9[num8 + 6] = array12[6];
									num2 = 197;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 278:
									array2[5] = (byte)num3;
									goto case 526;
								case 276:
									string_ = (string)smethod_165(smethod_164(), array13);
									goto case 451;
								case 274:
									array2[28] = (byte)num3;
									goto case 246;
								case 246:
									num3 = 112;
									num2 = 147;
									if (!smethod_189())
									{
										continue;
									}
									goto case 309;
								case 266:
									array2[2] = 115;
									num = 344;
									goto case 344;
								case 265:
									array[4] = 107;
									goto case 376;
								case 264:
									array9[num8 + 4] = array12[4];
									goto case 489;
								case 262:
									array9[num15 + 3] = array10[3];
									goto case 167;
								case 167:
									num15 = 23;
									goto case 484;
								case 260:
									intPtr = smethod_171(object_17);
									num2 = 530;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 257:
									array[3] = (byte)num4;
									num2 = 443;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 256:
									num3 = 96;
									goto case 381;
								case 252:
									num3 = 155;
									goto case 194;
								case 194:
									array2[20] = (byte)num3;
									goto case 26;
								case 26:
									num3 = 85;
									goto case 74;
								case 74:
									array2[20] = (byte)num3;
									goto case 242;
								case 242:
									num3 = 68;
									goto case 349;
								case 251:
									smethod_108();
									goto case 470;
								case 248:
									num3 = 144;
									num2 = 551;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 330;
								case 247:
									try
									{
										while (true)
										{
											if (!smethod_131(enumerator))
											{
												num21 = 1;
												if (smethod_189())
												{
													goto IL_33f5;
												}
												goto IL_3466;
											}
											goto IL_34b9;
											IL_33d8:
											if (!smethod_130(object_2, object_3))
											{
												continue;
											}
											num21 = 11;
											if (smethod_190() != null)
											{
												break;
											}
											goto IL_33f5;
											IL_34b9:
											object_4 = (ProcessModule)smethod_120(enumerator);
											goto IL_349f;
											IL_349f:
											if (!smethod_123(smethod_122(smethod_121(object_4)), "clrjit.dll"))
											{
												continue;
											}
											goto IL_3466;
											IL_3466:
											object_2 = new Version(smethod_125(smethod_124(object_4)), smethod_126(smethod_124(object_4)), smethod_127(smethod_124(object_4)), smethod_128(smethod_124(object_4)));
											goto IL_3451;
											IL_3451:
											object_5 = new Version(4, 0, 30319, 17020);
											goto IL_342c;
											IL_342c:
											object_3 = new Version(4, 0, 30319, 17921);
											num21 = 4;
											if (smethod_190() == null)
											{
												goto IL_33ca;
											}
											goto IL_33f5;
											IL_33f5:
											switch (num21)
											{
											case 8:
												break;
											case 6:
												goto IL_33d8;
											case 9:
												goto IL_342c;
											case 3:
												goto IL_3451;
											default:
												goto IL_3466;
											case 7:
												goto IL_349f;
											case 10:
												goto IL_34b9;
											case 4:
											case 5:
												continue;
											case 11:
												bool_1 = true;
												goto end_IL_34db;
											case 1:
											case 2:
												goto end_IL_34db;
											}
											goto IL_33ca;
											IL_33ca:
											if (!smethod_129(object_2, object_5))
											{
												continue;
											}
											goto IL_33d8;
											continue;
											end_IL_34db:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator as IDisposable;
										num22 = 1;
										if (smethod_190() != null)
										{
											num22 = num23;
										}
										do
										{
											switch (num22)
											{
											case 1:
												if (disposable == null)
												{
													goto end_IL_3527;
												}
												break;
											case 2:
											case 3:
												goto end_IL_3527;
											}
											smethod_132(disposable);
											num22 = 2;
											continue;
											end_IL_3527:
											break;
										}
										while (smethod_190() != null);
									}
									goto case 234;
								case 245:
									array2[18] = 191;
									goto case 84;
								case 84:
									num3 = 115;
									num2 = 136;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 244:
									num11 = intPtr4.ToInt64();
									num2 = 285;
									if (smethod_189())
									{
										continue;
									}
									goto case 51;
								case 241:
									array2[8] = (byte)num3;
									num2 = 23;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 239:
									num3 = 144;
									num2 = 570;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 237:
									array2[5] = (byte)num3;
									goto case 94;
								case 94:
									num3 = 120;
									goto case 672;
								case 233:
									array9[num8 + 2] = array10[2];
									goto case 59;
								case 59:
									array9[num8 + 3] = array10[3];
									num2 = 571;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 231:
									array[6] = 123;
									num2 = 563;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 230:
									if (num19 == num20 - 1)
									{
										num2 = 318;
										if (smethod_190() == null)
										{
											continue;
										}
										goto case 173;
									}
									goto case 254;
								case 229:
									smethod_185(smethod_184(smethod_175(Class25.object_6)));
									goto case 88;
								case 88:
									smethod_183(object_17);
									goto case 89;
								case 89:
									smethod_185(smethod_184(smethod_175(object_17)));
									num2 = 166;
									if (smethod_190() != null)
									{
										continue;
									}
									goto case 311;
								case 224:
									num16 += num17;
									goto case 127;
								case 127:
									num18 = 0u;
									num2 = 478;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 222:
									struct2.bool_0 = false;
									num2 = 623;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 212:
									num4 = 114;
									num2 = 410;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 206:
									array2[0] = (byte)num3;
									goto case 659;
								case 205:
									array9[num15 + 2] = array10[2];
									num2 = 262;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 201:
									array[6] = (byte)num4;
									goto case 231;
								case 200:
									num4 = 164;
									goto case 328;
								case 198:
									array9[num15 + 2] = array12[2];
									goto case 142;
								case 142:
									array9[num15 + 3] = array12[3];
									num2 = 460;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 197:
									array9[num8 + 7] = array12[7];
									goto case 121;
								case 121:
									num8 = 18;
									goto case 554;
								case 196:
									smethod_27(intptr_4, num14 * 4, 4, ref int_3);
									num2 = 162;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 195:
									array[2] = (byte)num4;
									goto case 155;
								case 155:
									array[2] = 86;
									goto case 389;
								case 193:
									array2[11] = (byte)num3;
									goto case 55;
								case 192:
									array7[11] = 108;
									goto case 429;
								case 191:
									array2[26] = (byte)num3;
									num = 97;
									goto case 97;
								case 97:
									array2[27] = 165;
									num = 498;
									goto case 498;
								case 188:
									intPtr4 = smethod_143(((object[])smethod_142(Class25.object_9))[0]);
									num2 = 244;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 187:
									array2[21] = (byte)num3;
									num = 634;
									goto case 634;
								case 183:
									array2[26] = (byte)num3;
									num = 2;
									goto case 2;
								case 181:
									array10 = (byte[])smethod_157(smethod_163(num13));
									num = 468;
									goto case 299;
								case 179:
									smethod_26(intptr_2, intPtr3, (byte[])smethod_157(smethod_146(object_)), 4u, out intptr_3);
									goto case 462;
								case 177:
									smethod_161(Class25.object_8, num11 + num12, @struct);
									goto case 48;
								case 169:
									array3[3] = array11[1];
									goto case 505;
								case 165:
									num4 = 226;
									num2 = 257;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 164:
									array2[15] = (byte)num3;
									num2 = 594;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 162:
									num10 = 0;
									num2 = 253;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 161:
									array9[num8 + 1] = array10[1];
									goto case 233;
								case 93:
								case 160:
									if (num5 >= num6)
									{
										goto IL_266a;
									}
									goto case 119;
								case 119:
									num9 = (nint)(ptr + (nint)num5 * (nint)8);
									*(long*)num9 ^= 242329859L;
									num2 = 70;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 150:
									array2[31] = 94;
									goto case 325;
								case 145:
									array2[26] = (byte)num3;
									goto case 352;
								case 136:
									array2[19] = (byte)num3;
									goto case 40;
								case 126:
									array9[num8 + 2] = array6[2];
									num2 = 635;
									if (smethod_189())
									{
										continue;
									}
									goto case 301;
								case 116:
									num3 = 145;
									goto case 293;
								case 115:
									smethod_188(new IntPtr(value), intPtr2);
									num2 = 466;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 98:
									array2[25] = 138;
									goto case 334;
								case 92:
									array2[1] = (byte)num3;
									num2 = 82;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 79;
								case 83:
									smethod_100(new IntPtr(&num7), 0);
									num2 = 358;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 82:
									array2[2] = 114;
									num2 = 266;
									if (smethod_189())
									{
										continue;
									}
									goto case 241;
								case 80:
									num3 = 163;
									num = 394;
									goto case 394;
								case 78:
									smethod_27(intptr_, 4, int_3, ref int_3);
									num2 = 308;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 77:
									num6 = array8.Length / 8;
									goto case 670;
								case 72:
									array2[22] = 84;
									goto case 488;
								case 70:
									num5++;
									num2 = 160;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 62:
									array7[0] = 99;
									goto case 404;
								case 53:
									byte_ = (byte[])smethod_137(object_, int_2);
									goto case 380;
								case 52:
									array6 = (byte[])smethod_157(intPtr.ToInt32());
									num2 = 181;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 47:
									array4 = new byte[30];
									smethod_186(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
									array5 = array4;
									goto case 249;
								case 46:
									array2[20] = 146;
									goto case 252;
								case 41:
									smethod_141(array3, 0, array3.Length);
									goto case 673;
								case 37:
									num3 = 100;
									num = 631;
									goto case 631;
								case 32:
									array[9] = 203;
									goto case 214;
								case 30:
									array[7] = 95;
									goto case 569;
								case 25:
									if (smethod_115() != 4)
									{
										num2 = 281;
										if (smethod_189())
										{
											continue;
										}
										break;
									}
									goto case 47;
								case 24:
									num3 = 126;
									goto case 495;
								case 22:
									num3 = 108;
									num2 = 527;
									if (smethod_189())
									{
										continue;
									}
									goto case 63;
								case 19:
									array2[0] = (byte)num3;
									goto case 475;
								case 11:
									array[11] = (byte)num4;
									num = 678;
									goto case 678;
								case 9:
									array[10] = 165;
									num2 = 300;
									if (!smethod_189())
									{
										continue;
									}
									goto case 337;
								case 5:
									num3 = 80;
									goto case 92;
								case 4:
									array[4] = 134;
									num = 265;
									goto case 265;
								case 14:
									Class25.object_6 = null;
									goto case 536;
								case 156:
									smethod_114();
									return;
								case 382:
									return;
								case 466:
									smethod_27(new IntPtr(value), smethod_115(), int_, ref int_);
									num = 45;
									goto case 45;
								case 45:
								case 395:
									smethod_114();
									return;
								case 521:
									return;
								case 580:
									return;
								case 402:
									smethod_114();
									return;
								case 90:
									return;
								}
								goto IL_0067_2;
								continue;
								end_IL_3c5e:
								break;
							}
						}
						continue;
						end_IL_031a:
						break;
					}
					goto case 275;
				case 275:
				case 423:
					reference = ref *(byte*)null;
					num2 = 305;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 669:
					smethod_27(intptr_, 4, 4, ref int_3);
					goto case 140;
				case 140:
					smethod_159(intptr_, smethod_146(object_));
					num2 = 78;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 668:
					array2[19] = (byte)num3;
					num2 = 46;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 667:
					num3 = 14;
					num2 = 624;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 666:
					array[2] = 133;
					goto case 347;
				case 347:
					array[2] = 119;
					num = 263;
					goto case 263;
				case 263:
					num4 = 159;
					num2 = 195;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 665:
					array7 = new byte[10];
					num2 = 62;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 664:
					array[7] = 91;
					goto case 471;
				case 471:
					array[7] = 143;
					goto case 479;
				case 479:
					array[7] = 222;
					num = 592;
					goto case 592;
				case 592:
					array[8] = 93;
					num2 = 200;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 663:
					array2[12] = 31;
					num2 = 583;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 662:
					intptr_2 = IntPtr.Zero;
					num2 = 440;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 661:
					array[1] = 150;
					goto case 295;
				case 295:
					num4 = 164;
					goto case 122;
				case 122:
					array[1] = (byte)num4;
					goto case 204;
				case 204:
					num4 = 114;
					num2 = 400;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 660:
					array2[3] = 158;
					goto case 408;
				case 408:
					array2[4] = 131;
					num = 141;
					goto case 141;
				case 141:
					array2[4] = 116;
					goto case 21;
				case 21:
					num3 = 114;
					num2 = 58;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 87;
				case 87:
					array2[4] = (byte)num3;
					goto case 139;
				case 139:
					num3 = 155;
					num = 434;
					goto case 434;
				case 434:
					array2[4] = (byte)num3;
					goto case 658;
				case 658:
					array2[5] = 41;
					num2 = 25;
					if (!smethod_189())
					{
						continue;
					}
					goto case 96;
				case 96:
					num3 = 108;
					num2 = 278;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 659:
					num3 = 153;
					num2 = 19;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 657:
					try
					{
						object obj5 = smethod_181(smethod_180(smethod_179(smethod_178(smethod_162(typeof(Class25).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), smethod_179(smethod_178(smethod_162(typeof(Class25).TypeHandle).Assembly)));
						num68 = 1;
						if (!smethod_189())
						{
							goto IL_0776_2;
						}
						goto IL_07dd_3;
						IL_07dd_3:
						while (true)
						{
							switch (num68)
							{
							case 16:
							case 19:
								if (!smethod_123(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
								{
									num68 = 10;
									if (smethod_189())
									{
										continue;
									}
									goto case 8;
								}
								goto case 17;
							case 8:
								smethod_150(object_16, new byte[smethod_115()], 0, smethod_115());
								num73 = 15;
								goto case 15;
							case 15:
								smethod_135(object_16, 0L);
								num68 = 4;
								if (!smethod_189())
								{
									continue;
								}
								goto case 7;
							case 7:
								array20 = (byte[])smethod_152(object_16);
								num68 = 0;
								if (smethod_190() == null)
								{
									continue;
								}
								break;
							case 17:
								Class25.intptr_2 = (IntPtr)smethod_181(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
								goto case 2;
							case 2:
							case 10:
								object_16 = new MemoryStream();
								num73 = 6;
								goto case 6;
							case 6:
								smethod_150(object_16, new byte[smethod_115()], 0, smethod_115());
								goto case 3;
							case 3:
								if (smethod_115() == 4)
								{
									goto case 4;
								}
								goto case 12;
							case 4:
								smethod_150(object_16, smethod_157(Class25.intptr_2.ToInt32()), 0, 4);
								num68 = 5;
								if (smethod_190() != null)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 11:
								smethod_150(object_16, new byte[smethod_115()], 0, smethod_115());
								num68 = 8;
								if (smethod_190() == null)
								{
									continue;
								}
								break;
							case 12:
								smethod_150(object_16, smethod_182(Class25.intptr_2.ToInt64()), 0, 8);
								num68 = 11;
								if (smethod_190() == null)
								{
									continue;
								}
								break;
							case 18:
								nativeSizeOfCode = 0u;
								num68 = 9;
								if (smethod_189())
								{
									continue;
								}
								break;
							case 14:
								Class25.intptr_2 = (IntPtr)obj5;
								num68 = 13;
								if (smethod_190() != null)
								{
									continue;
								}
								goto case 16;
							case 1:
								if (!(obj5 is IntPtr))
								{
									num68 = 16;
									if (smethod_189())
									{
										continue;
									}
									break;
								}
								goto case 14;
							default:
								smethod_153(object_16);
								num68 = 18;
								if (smethod_190() == null)
								{
									continue;
								}
								goto case 2;
							case 9:
								try
								{
									array21 = (array19 = array20);
									if (array21 != null)
									{
										num69 = 3;
										if (!smethod_189())
										{
											goto IL_084c_3;
										}
										goto IL_08bf_5;
									}
									goto IL_08e2_2;
									IL_084c_3:
									while (true)
									{
										fixed (byte* value2 = &array19[0])
										{
											num69 = 1;
											if (!smethod_189())
											{
												goto IL_0863_3;
											}
											goto IL_08bf_6;
											IL_08bf_6:
											while (true)
											{
												switch (num69)
												{
												case 2:
												case 4:
													goto end_IL_08bf_2;
												case 3:
													if (array19.Length == 0)
													{
														goto end_IL_084c_2;
													}
													num69 = 1;
													if (!smethod_189())
													{
														continue;
													}
													goto end_IL_08bf_2;
												default:
													object_17(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
													num69 = 6;
													if (smethod_190() == null)
													{
														continue;
													}
													break;
												case 5:
													goto end_IL_084c_2;
												case 6:
													goto end_IL_0835_2;
												}
												goto IL_0863_3;
												continue;
												end_IL_08bf_2:
												break;
											}
											goto end_IL_0856_2;
											IL_0863_3:
											num69 = num70;
											goto IL_08bf_6;
											end_IL_0856_2:;
										}
										continue;
										end_IL_084c_2:
										break;
									}
									goto IL_08e2_2;
									IL_08e2_2:
									reference3 = ref *(byte*)null;
									num69 = 0;
									if (!smethod_189())
									{
										goto IL_0863_4;
									}
									goto IL_08bf_5;
									IL_08bf_5:
									while (true)
									{
										switch (num69)
										{
										case 2:
										case 4:
											break;
										case 3:
											if (array19.Length != 0)
											{
												num69 = 1;
												if (!smethod_189())
												{
													continue;
												}
												break;
											}
											goto IL_08e2_2;
										default:
											goto IL_087e_2;
										case 5:
											goto IL_08e2_2;
										case 6:
											goto end_IL_0835_2;
										}
										break;
										IL_087e_2:
										object_17(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3)), ref nativeSizeOfCode);
										num69 = 6;
										if (smethod_190() == null)
										{
											continue;
										}
										goto IL_0863_4;
									}
									goto IL_084c_3;
									IL_0863_4:
									num69 = num70;
									goto IL_08bf_5;
									end_IL_0835_2:;
								}
								finally
								{
									reference3 = ref *(byte*)null;
									num71 = 0;
									if (smethod_190() != null)
									{
										num71 = num72;
									}
									switch (num71)
									{
									}
								}
								goto end_IL_07dd_2;
							case 13:
								goto end_IL_07dd_2;
							}
							goto IL_0776_2;
							continue;
							end_IL_07dd_2:
							break;
						}
						goto end_IL_05be_2;
						IL_0776_2:
						num68 = num73;
						goto IL_07dd_3;
						end_IL_05be_2:;
					}
					catch (object obj6)
					{
						num74 = 0;
						if (!smethod_189())
						{
							num74 = num75;
						}
						switch (num74)
						{
						}
					}
					goto case 151;
				case 151:
					smethod_183(Class25.object_6);
					num2 = 229;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 656:
					array7[0] = 109;
					num2 = 456;
					if (!smethod_189())
					{
						continue;
					}
					goto case 555;
				case 555:
					array7[1] = 115;
					goto case 91;
				case 91:
					array7[2] = 99;
					goto case 289;
				case 289:
					array7[3] = 111;
					num2 = 469;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 655:
					num3 = 182;
					num2 = 193;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 184;
				case 184:
					array2[13] = (byte)num3;
					goto case 667;
				case 654:
					intPtr4 = smethod_143(((object[])smethod_142(Class25.object_9))[0]);
					goto case 172;
				case 172:
					int_0 = intPtr4.ToInt32();
					num2 = 174;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 653:
					num3 = 162;
					num2 = 446;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 652:
					num4 = 107;
					goto case 503;
				case 503:
					array[5] = (byte)num4;
					goto case 539;
				case 539:
					num4 = 58;
					goto case 29;
				case 29:
					array[5] = (byte)num4;
					num = 377;
					goto case 377;
				case 377:
					array[5] = 109;
					goto case 543;
				case 543:
					num4 = 224;
					num2 = 629;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 651:
					array2[15] = 142;
					num2 = 519;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 49;
				case 49:
					if (smethod_115() == 4)
					{
						num2 = 179;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 27;
				case 27:
					smethod_26(intptr_2, intPtr3, (byte[])smethod_157(smethod_146(object_)), 4u, out intptr_3);
					num2 = 268;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 462;
				case 413:
					num62++;
					num2 = 350;
					if (!smethod_189())
					{
						continue;
					}
					goto case 365;
				case 365:
				case 391:
					if (num62 < num60)
					{
						goto case 101;
					}
					num2 = 67;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 133;
				case 101:
					intPtr3 = new IntPtr(long_0 + smethod_146(object_) - num42);
					goto case 507;
				case 507:
					smethod_27(intPtr3, 4, 4, ref int_3);
					goto case 49;
				case 462:
				case 572:
					smethod_27(intPtr3, 4, int_3, ref int_3);
					goto case 413;
				case 133:
				case 590:
					if (smethod_158(smethod_134(object_)) < smethod_136(smethod_134(object_)) - 1L)
					{
						num2 = 384;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 107;
					}
					goto case 609;
				case 107:
					array[15] = (byte)num4;
					goto case 268;
				case 268:
					array[15] = 144;
					num2 = 589;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 609:
					smethod_160(intptr_2);
					num2 = 187;
					if (!smethod_189())
					{
						continue;
					}
					goto case 402;
				case 650:
					num61 = smethod_146(object_);
					goto case 291;
				case 291:
					if (num61 == 1)
					{
						num2 = 662;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 559;
					}
					num24 = 0;
					num2 = 574;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 214;
				case 559:
					int_ = 0;
					goto case 340;
				case 340:
					if (!smethod_174(smethod_173(smethod_162(typeof(Class25).TypeHandle).Assembly), null))
					{
						goto case 657;
					}
					goto case 450;
				case 450:
					if (((Array)smethod_177(smethod_173(smethod_162(typeof(Class25).TypeHandle).Assembly))).Length == 2)
					{
						num2 = 566;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 657;
				case 214:
					num4 = 145;
					num2 = 490;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 649:
					array2[2] = (byte)num3;
					num2 = 24;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 648:
					num3 = 160;
					num2 = 183;
					if (smethod_189())
					{
						continue;
					}
					goto case 101;
				case 647:
					num48 = (uint)(num67 * 4);
					goto case 76;
				case 76:
					num17 = (uint)((array17[num48 + 3] << 24) | (array17[num48 + 2] << 16) | (array17[num48 + 1] << 8) | array17[num48]);
					goto case 614;
				case 614:
					num65 = 255u;
					goto case 238;
				case 238:
					num66 = 0;
					goto case 16;
				case 16:
					if (num19 == num20 - 1)
					{
						num2 = 7;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 125;
					}
					goto case 213;
				case 125:
					if (num25 > 0)
					{
						num2 = 224;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 213;
				case 213:
					num48 = (uint)num27;
					goto case 644;
				case 644:
					num16 += num17;
					num2 = 457;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 646:
					smethod_27(new IntPtr(value), smethod_115(), 64, ref int_);
					num2 = 115;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 645:
					array2[21] = 56;
					goto case 420;
				case 420:
					num3 = 134;
					goto case 203;
				case 203:
					array2[21] = (byte)num3;
					goto case 454;
				case 454:
					num3 = 149;
					num2 = 187;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 643:
					array2[23] = 166;
					num2 = 283;
					if (!smethod_189())
					{
						continue;
					}
					goto case 483;
				case 483:
					num3 = 162;
					goto case 581;
				case 581:
					array2[23] = (byte)num3;
					num2 = 285;
					if (!smethod_189())
					{
						continue;
					}
					goto case 401;
				case 401:
					array2[23] = 197;
					num2 = 239;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 642:
					num3 = 129;
					goto case 3;
				case 3:
					array2[29] = (byte)num3;
					goto case 270;
				case 270:
					array2[29] = 207;
					goto case 173;
				case 173:
					num3 = 89;
					goto case 512;
				case 512:
					array2[30] = (byte)num3;
					num = 458;
					goto case 458;
				case 458:
					num3 = 91;
					goto case 632;
				case 632:
					array2[30] = (byte)num3;
					goto case 677;
				case 346:
				case 641:
					num19++;
					goto case 105;
				case 105:
				case 616:
					if (num19 >= num20)
					{
						goto case 486;
					}
					goto case 227;
				case 486:
					array8 = array15;
					num2 = 77;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 227:
					num67 = num19 % num52;
					goto case 558;
				case 558:
					num27 = num19 * 4;
					num2 = 647;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 640:
					intptr_4 = new IntPtr(long_0 + num38 - num42);
					num2 = 549;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 324;
				case 324:
					intptr_5 = LoadLibrary(text);
					goto case 149;
				case 149:
					if (smethod_166(intptr_5, IntPtr.Zero))
					{
						goto case 665;
					}
					num2 = 303;
					if (smethod_189())
					{
						continue;
					}
					goto case 3;
				case 602:
				case 638:
					smethod_107(array9, 0, intPtr2, array9.Length);
					goto case 286;
				case 286:
					bool_0 = false;
					num = 646;
					goto case 646;
				case 109:
					if (num54 > 0)
					{
						num2 = 101;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 369;
					}
					goto case 617;
				case 369:
					num65 <<= 8;
					num2 = 70;
					if (!smethod_189())
					{
						continue;
					}
					goto case 146;
				case 146:
					num66 += 8;
					num2 = 247;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 617;
				case 617:
					array15[num27 + num54] = (byte)((num53 & num65) >> num66);
					num2 = 522;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 523;
				case 523:
					num54++;
					goto case 18;
				case 18:
				case 637:
					if (num54 >= num25)
					{
						num2 = 508;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 346;
					}
					goto case 109;
				case 304:
				case 636:
					if (num50 >= num25)
					{
						goto case 117;
					}
					goto case 130;
				case 117:
				case 341:
					num16 = num16;
					goto case 625;
				case 625:
				{
					num63 = num16;
					uint num64 = num16;
					num64 ^= num64 << 1;
					num64 += 4052235136u;
					num64 ^= num64 >> 27;
					num64 += 2298058292u;
					num64 ^= num64 << 27;
					num64 += 2374016581u;
					num64 = 3124738051u - num64;
					num16 = num63 + (uint)(double)num64;
					num2 = 230;
					if (smethod_189())
					{
						continue;
					}
					goto case 1;
				}
				case 1:
					array2[10] = (byte)num3;
					goto case 392;
				case 392:
					num3 = 106;
					num2 = 357;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 130:
					if (num50 > 0)
					{
						goto case 202;
					}
					goto case 66;
				case 202:
					num18 <<= 8;
					num2 = 66;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 66:
					num18 |= array16[^(1 + num50)];
					num2 = 73;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 635:
					array9[num8 + 3] = array6[3];
					num2 = 522;
					if (smethod_189())
					{
						continue;
					}
					goto case 217;
				case 217:
					num60 = smethod_146(object_);
					goto case 650;
				case 634:
					num3 = 150;
					goto case 481;
				case 481:
					array2[21] = (byte)num3;
					num = 79;
					goto case 79;
				case 79:
					num3 = 159;
					goto case 272;
				case 272:
					array2[22] = (byte)num3;
					goto case 610;
				case 610:
					num3 = 150;
					num = 556;
					goto case 556;
				case 556:
					array2[22] = (byte)num3;
					goto case 61;
				case 61:
					num3 = 102;
					goto case 54;
				case 54:
					array2[22] = (byte)num3;
					num2 = 72;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 633:
					array2[17] = (byte)num3;
					goto case 209;
				case 209:
					array2[17] = 144;
					goto case 653;
				case 631:
					array2[7] = (byte)num3;
					goto case 102;
				case 102:
					array2[7] = 102;
					goto case 255;
				case 255:
					array2[7] = 208;
					goto case 110;
				case 110:
					array2[8] = 115;
					goto case 546;
				case 546:
					array2[8] = 105;
					goto case 431;
				case 431:
					array2[8] = 107;
					num2 = 385;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 300;
				case 300:
					array[6] = 77;
					goto case 8;
				case 8:
					array[6] = 112;
					num2 = 671;
					if (smethod_189())
					{
						continue;
					}
					goto case 2;
				case 630:
					num62 = 0;
					goto case 365;
				case 629:
					array[5] = (byte)num4;
					goto case 433;
				case 433:
					array[6] = 112;
					num2 = 300;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 628:
					array9[num15 + 1] = array10[1];
					num2 = 205;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 627:
					array2[10] = (byte)num3;
					num2 = 550;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 626:
					array[3] = 116;
					num2 = 212;
					if (smethod_189())
					{
						continue;
					}
					goto case 137;
				case 137:
					array7[5] = 106;
					goto case 294;
				case 294:
					array7[6] = 105;
					goto case 131;
				case 131:
					array7[7] = 116;
					goto case 288;
				case 288:
					array7[8] = 46;
					num2 = 500;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 624:
					array2[13] = (byte)num3;
					goto case 31;
				case 31:
					array2[14] = 94;
					num2 = 248;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 2;
				case 623:
					smethod_161(Class25.object_8, 0L, struct2);
					goto case 114;
				case 114:
					flag2 = false;
					num = 48;
					goto case 48;
				case 48:
				case 152:
					if (smethod_158(smethod_134(object_)) < smethod_136(smethod_134(object_)) - 1L)
					{
						num2 = 480;
						if (smethod_189())
						{
							continue;
						}
						goto case 143;
					}
					goto case 284;
				case 143:
					num3 = 0;
					goto case 598;
				case 598:
					array2[14] = (byte)num3;
					goto case 651;
				case 284:
					intPtr4 = smethod_143(((object[])smethod_142(smethod_162(typeof(Class25).TypeHandle).Assembly))[0]);
					goto case 65;
				case 65:
					long_1 = intPtr4.ToInt64();
					goto case 34;
				case 34:
					if (smethod_115() == 4)
					{
						num = 63;
						goto case 63;
					}
					goto case 138;
				case 63:
					Class25.int_2 = smethod_163(long_1);
					num = 138;
					goto case 138;
				case 138:
					array7 = new byte[12];
					goto case 656;
				case 622:
					array[0] = 96;
					num = 336;
					goto case 336;
				case 336:
					num4 = 144;
					goto case 577;
				case 577:
					array[0] = (byte)num4;
					num = 492;
					goto case 492;
				case 492:
					array[0] = 83;
					goto case 208;
				case 208:
					array[0] = 68;
					goto case 12;
				case 12:
					num4 = 31;
					num2 = 619;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 621:
					array2[11] = 92;
					num2 = 655;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 620:
					array13[2] = 116;
					goto case 199;
				case 199:
					array13[3] = 74;
					goto case 514;
				case 514:
					array13[4] = 105;
					num = 436;
					goto case 436;
				case 436:
					array13[5] = 116;
					num2 = 276;
					if (smethod_189())
					{
						continue;
					}
					goto case 3;
				case 619:
					array[0] = (byte)num4;
					num2 = 18;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 120;
				case 120:
					num4 = 84;
					num2 = 366;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 615:
					num3 = 102;
					num2 = 206;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 613:
					array2[13] = 168;
					goto case 163;
				case 163:
					num3 = 158;
					num2 = 378;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 611:
					array2[16] = (byte)num3;
					num2 = 116;
					if (smethod_189())
					{
						continue;
					}
					goto case 20;
				case 20:
					num4 = 145;
					goto case 494;
				case 494:
					array[12] = (byte)num4;
					goto case 95;
				case 95:
					array[12] = 135;
					goto case 112;
				case 112:
					array[12] = 168;
					goto case 317;
				case 317:
					array[12] = 188;
					num = 118;
					goto case 118;
				case 118:
					num4 = 162;
					goto case 390;
				case 390:
					array[13] = (byte)num4;
					num2 = 142;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 282;
				case 282:
					array[13] = 114;
					goto case 43;
				case 43:
					num4 = 150;
					goto case 306;
				case 306:
					array[13] = (byte)num4;
					goto case 373;
				case 373:
					num4 = 152;
					num2 = 553;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 608:
					array2[8] = (byte)num3;
					goto case 411;
				case 411:
					num3 = 114;
					num2 = 241;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 607:
					array2[27] = (byte)num3;
					goto case 312;
				case 312:
					num3 = 102;
					num2 = 105;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 591;
				case 591:
					array2[28] = (byte)num3;
					goto case 159;
				case 159:
					array2[28] = 125;
					num2 = 516;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 606:
					array[5] = 118;
					num2 = 652;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 605:
					array15[num27 + 2] = (byte)((num26 & 0xFF0000) >> 16);
					goto case 416;
				case 416:
					array15[num27 + 3] = (byte)((num26 & 0xFF000000u) >> 24);
					num2 = 346;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 604:
					array[14] = 66;
					goto case 180;
				case 180:
					num4 = 85;
					num2 = 87;
					if (!smethod_189())
					{
						continue;
					}
					goto case 532;
				case 532:
					array[14] = (byte)num4;
					goto case 219;
				case 219:
					array[14] = 141;
					goto case 144;
				case 144:
					num4 = 79;
					goto case 674;
				case 603:
					value = 0L;
					goto case 361;
				case 361:
					if (smethod_115() == 4)
					{
						goto case 100;
					}
					goto case 60;
				case 60:
					value = smethod_170(intptr_6);
					num2 = 350;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 40;
				case 40:
					array2[19] = 91;
					goto case 225;
				case 225:
					array2[19] = 170;
					goto case 464;
				case 464:
					array2[19] = 108;
					goto case 568;
				case 568:
					array2[19] = 124;
					goto case 42;
				case 42:
					num3 = 246;
					goto case 668;
				case 574:
				case 601:
					if (num24 >= num60)
					{
						num2 = 599;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 426;
				case 426:
					intptr_ = new IntPtr(num11 + smethod_146(object_) - num42);
					goto case 669;
				case 600:
					num4 = 142;
					goto case 235;
				case 235:
					array[9] = (byte)num4;
					goto case 418;
				case 418:
					array[9] = 40;
					num2 = 32;
					if (smethod_189())
					{
						continue;
					}
					goto case 23;
				case 23:
					array2[8] = 87;
					num2 = 201;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 540;
				case 540:
					num3 = 120;
					goto case 465;
				case 465:
					array2[9] = (byte)num3;
					goto case 438;
				case 438:
					num3 = 95;
					goto case 147;
				case 147:
					array2[9] = (byte)num3;
					num2 = 18;
					if (!smethod_189())
					{
						continue;
					}
					goto case 103;
				case 103:
					array2[9] = 96;
					goto case 579;
				case 579:
					array2[9] = 73;
					num = 545;
					goto case 545;
				case 545:
					num3 = 148;
					num2 = 1;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 599:
					Class25.object_8 = new Hashtable(smethod_146(object_) + 1);
					goto case 7;
				case 7:
					struct2 = default(Struct19);
					goto case 185;
				case 185:
					reference2 = ref struct2;
					array19 = new byte[1] { 42 };
					reference2.byte_0 = array19;
					num2 = 222;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 597:
					num4 = 207;
					num2 = 11;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 596:
					num42 = 7680;
					num2 = 595;
					if (smethod_189())
					{
						continue;
					}
					goto case 563;
				case 563:
					array[6] = 75;
					num2 = 497;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 129;
				case 129:
					num42 = 0;
					num2 = 370;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 517:
				case 595:
					num60 = smethod_146(object_);
					goto case 437;
				case 437:
					num61 = smethod_146(object_);
					goto case 113;
				case 113:
					if (num61 == 4)
					{
						num2 = 445;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 291;
				case 594:
					num3 = 225;
					goto case 499;
				case 499:
					array2[15] = (byte)num3;
					num2 = 565;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 593:
					@struct.byte_0 = byte_;
					goto case 56;
				case 56:
					@struct.bool_0 = flag2;
					num2 = 177;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 17;
				case 17:
					enumerator = (IEnumerator)smethod_119(object_14);
					num2 = 247;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 589:
					array[15] = 124;
					goto case 573;
				case 573:
					array3 = array;
					goto case 472;
				case 472:
					smethod_138(array3);
					goto case 323;
				case 323:
					array11 = (byte[])smethod_140(smethod_139(Class25.object_9));
					goto case 104;
				case 104:
					if (array11 != null)
					{
						goto case 367;
					}
					goto case 310;
				case 367:
					if (array11.Length > 0)
					{
						goto case 552;
					}
					goto case 310;
				case 552:
					array3[1] = array11[0];
					num2 = 169;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 310:
					num47 = 0;
					goto case 135;
				case 135:
				case 218:
					if (num47 >= array3.Length)
					{
						num2 = 463;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 455;
				case 455:
					array17[num47] = (byte)(array17[num47] ^ array3[num47]);
					num2 = 447;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 588:
					array2[0] = (byte)num3;
					num2 = 319;
					if (!smethod_189())
					{
						continue;
					}
					goto case 356;
				case 356:
					array2[1] = 156;
					goto case 250;
				case 250:
					array2[1] = 133;
					num2 = 5;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 587:
					array[4] = (byte)num4;
					goto case 606;
				case 586:
					array2[16] = 142;
					num2 = 525;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 585:
					if (smethod_115() == 4)
					{
						num2 = 106;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 676;
				case 584:
					array2[31] = (byte)num3;
					num2 = 16;
					if (!smethod_189())
					{
						continue;
					}
					goto case 123;
				case 123:
					array2[31] = 213;
					goto case 405;
				case 405:
					array17 = array2;
					goto case 387;
				case 387:
					array = new byte[16];
					goto case 622;
				case 583:
					array2[13] = 59;
					num = 501;
					goto case 501;
				case 501:
					array2[13] = 86;
					goto case 613;
				case 582:
					if (num51 >= 1879048192)
					{
						goto case 343;
					}
					goto case 509;
				case 343:
					flag2 = true;
					goto case 509;
				case 509:
					int_2 = smethod_146(object_);
					num2 = 53;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 578:
					smethod_114();
					num2 = 382;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 576:
					long_0 = intPtr4.ToInt64();
					goto case 211;
				case 211:
					intptr_3 = IntPtr.Zero;
					goto case 630;
				case 575:
					num16 = 0u;
					num = 406;
					goto case 406;
				case 406:
					num17 = 0u;
					num2 = 317;
					if (!smethod_189())
					{
						continue;
					}
					goto case 533;
				case 533:
					num18 = 0u;
					goto case 372;
				case 372:
					if (num25 > 0)
					{
						goto case 560;
					}
					goto case 33;
				case 560:
					num20++;
					num2 = 33;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 33:
					num48 = 0u;
					num2 = 330;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 571:
					array9[num8 + 4] = array10[4];
					goto case 459;
				case 459:
					array9[num8 + 5] = array10[5];
					goto case 432;
				case 432:
					array9[num8 + 6] = array10[6];
					num = 297;
					goto case 297;
				case 297:
					array9[num8 + 7] = array10[7];
					num2 = 680;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 570:
					array2[24] = (byte)num3;
					num = 679;
					goto case 679;
				case 569:
					array[7] = 96;
					num2 = 664;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 567:
					array9[num15] = array12[0];
					num = 351;
					goto case 351;
				case 351:
					array9[num15 + 1] = array12[1];
					num2 = 198;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 566:
					if (smethod_144(smethod_162(typeof(Class25).TypeHandle).Assembly) != null)
					{
						num2 = 477;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 657;
				case 565:
					array2[16] = 117;
					goto case 64;
				case 64:
					num3 = 160;
					goto case 544;
				case 544:
					array2[16] = (byte)num3;
					num2 = 256;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 243;
				case 243:
					array7[7] = 100;
					goto case 439;
				case 439:
					array7[8] = 108;
					goto case 424;
				case 424:
					array7[9] = 108;
					goto case 379;
				case 379:
					text = (string)smethod_165(smethod_164(), array7);
					num2 = 417;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 564:
					array13[0] = 103;
					goto case 228;
				case 228:
					array13[1] = 101;
					goto case 620;
				case 562:
					num20 = array16.Length / 4;
					goto case 240;
				case 240:
					array15 = new byte[array16.Length];
					num2 = 510;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 234:
				case 561:
					object_ = new Class28((Stream)smethod_133(Class25.object_9, "t3\u009du\u009e6\u008dp\u009c\u0099yn3b\u0091d\u008d\u0096.7\u0093\u008c\u0094ua\u008e\u009f\u008e\u009b\u008dlnp\u009e\u008a8d"));
					goto case 50;
				case 50:
					smethod_135(smethod_134(object_), 0L);
					goto case 57;
				case 57:
					array18 = (byte[])smethod_137(object_, (int)smethod_136(smethod_134(object_)));
					num2 = 210;
					if (!smethod_189())
					{
						continue;
					}
					goto case 359;
				case 359:
					array2 = new byte[32];
					goto case 615;
				case 557:
					smethod_141(array11, 0, array11.Length);
					num2 = 310;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 554:
					array9[num8] = array10[0];
					num2 = 161;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 553:
					array[13] = (byte)num4;
					goto case 604;
				case 551:
					array2[14] = (byte)num3;
					num2 = 143;
					if (smethod_189())
					{
						continue;
					}
					goto case 106;
				case 106:
					num13 = smethod_169(new IntPtr(value));
					num2 = 407;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 385;
				case 385:
					num3 = 114;
					goto case 608;
				case 550:
					array2[10] = 143;
					goto case 302;
				case 302:
					array2[10] = 94;
					num2 = 339;
					if (smethod_189())
					{
						continue;
					}
					goto case 55;
				case 55:
					num3 = 151;
					num2 = 425;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 549:
					num14 = smethod_146(object_);
					num2 = 196;
					if (smethod_189())
					{
						continue;
					}
					goto IL_1eff;
				case 73:
					goto IL_1eff;
				case 178:
					smethod_159(new IntPtr(intptr_4.ToInt64() + num10 * 4), smethod_146(object_));
					goto case 314;
				case 314:
					num10++;
					goto case 253;
				case 253:
				case 548:
					if (num10 < num14)
					{
						goto case 178;
					}
					goto case 342;
				case 342:
					smethod_27(intptr_4, num14 * 4, int_3, ref int_3);
					num2 = 590;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 586;
				case 547:
					array7[4] = 105;
					goto case 316;
				case 316:
					array7[5] = 116;
					goto case 158;
				case 158:
					array7[6] = 46;
					goto case 243;
				case 249:
				case 542:
					intPtr2 = smethod_187(IntPtr.Zero, (uint)array5.Length, 4096u, 64u);
					goto case 364;
				case 364:
					array9 = array5;
					goto case 277;
				case 277:
					array6 = null;
					num2 = 123;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 354;
				case 354:
					array10 = null;
					num = 333;
					goto case 333;
				case 333:
					array12 = null;
					goto case 85;
				case 85:
					if (smethod_115() == 4)
					{
						goto case 506;
					}
					goto case 38;
				case 506:
					array12 = (byte[])smethod_157(Class25.intptr_2.ToInt32());
					num2 = 52;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 38:
					array12 = (byte[])smethod_182(Class25.intptr_2.ToInt64());
					goto case 128;
				case 128:
					array6 = (byte[])smethod_182(intPtr.ToInt64());
					num = 298;
					goto case 298;
				case 298:
					array10 = (byte[])smethod_182(num13);
					num = 299;
					goto case 299;
				case 299:
				case 468:
					if (smethod_115() == 4)
					{
						goto case 10;
					}
					goto case 236;
				case 10:
					num15 = 9;
					goto case 567;
				case 236:
					num8 = 2;
					goto case 319;
				case 319:
					array9[num8] = array12[0];
					goto case 409;
				case 409:
					array9[num8 + 1] = array12[1];
					num2 = 290;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 541:
					array3[13] = array11[6];
					num2 = 491;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 425;
				case 425:
					array2[12] = (byte)num3;
					num2 = 388;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 538:
					smethod_150(object_6, array18, 0, array18.Length);
					num2 = 360;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 537:
					array2[0] = (byte)num3;
					goto case 186;
				case 186:
					array2[0] = 156;
					num = 301;
					goto case 301;
				case 301:
					num3 = 244;
					goto case 588;
				case 536:
					try
					{
						Class25.object_6 = (Delegate3)smethod_167(new IntPtr(num13), smethod_162(typeof(Delegate3).TypeHandle));
						num55 = 0;
						if (smethod_190() == null)
						{
							switch (num55)
							{
							}
						}
					}
					catch (object obj4)
					{
						num56 = 1;
						if (smethod_190() == null)
						{
							switch (num56)
							{
							default:
								goto end_IL_2133_2;
							case 1:
								break;
							case 0:
								goto end_IL_2133_2;
							}
						}
						try
						{
							Delegate object_15 = (Delegate)smethod_167(new IntPtr(num13), smethod_162(typeof(Delegate3).TypeHandle));
							num57 = 0;
							if (smethod_190() != null)
							{
								goto IL_217b_2;
							}
							goto IL_21a7_2;
							IL_21a7_2:
							switch (num57)
							{
							case 1:
								goto end_IL_2156_2;
							}
							goto IL_217b_2;
							IL_217b_2:
							Class25.object_6 = (Delegate3)smethod_176(smethod_162(typeof(Delegate3).TypeHandle), smethod_175(object_15));
							num57 = 0;
							if (!smethod_189())
							{
								goto IL_21a7_2;
							}
							end_IL_2156_2:;
						}
						catch (object obj3)
						{
							num58 = 0;
							if (smethod_190() != null)
							{
								num58 = num59;
							}
							switch (num58)
							{
							default:
								goto end_IL_21b9_2;
							}
							end_IL_21b9_2:;
						}
						end_IL_2133_2:;
					}
					goto case 398;
				case 398:
					num2 = 559;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 535:
					array[1] = 48;
					num = 666;
					goto case 666;
				case 531:
					flag2 = false;
					num2 = 582;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 530:
					num13 = 0L;
					goto case 585;
				case 529:
					array3[9] = array11[4];
					num = 476;
					goto case 476;
				case 476:
					array3[11] = array11[5];
					num = 541;
					goto case 541;
				case 528:
					array[9] = 148;
					goto case 600;
				case 527:
					array2[27] = (byte)num3;
					num2 = 487;
					if (smethod_189())
					{
						continue;
					}
					goto case 442;
				case 442:
					smethod_104(new IntPtr(&num7), 0, 0);
					goto case 393;
				case 393:
					smethod_105(new IntPtr(&num7), 0, 0L);
					num = 353;
					goto case 353;
				case 353:
					array19 = new byte[1];
					goto case 215;
				case 215:
					smethod_107(array19, 0, smethod_106(8), 1);
					num2 = 251;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 526:
					array2[5] = 144;
					num = 261;
					goto case 261;
				case 261:
					array2[5] = 6;
					num = 124;
					goto case 124;
				case 124:
					num3 = 75;
					num2 = 237;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 525:
					num3 = 112;
					num = 611;
					goto case 611;
				case 524:
					array9[num8 + 6] = array6[6];
					goto case 338;
				case 338:
					array9[num8 + 7] = array6[7];
					goto case 602;
				case 522:
					array9[num8 + 4] = array6[4];
					goto case 383;
				case 383:
					array9[num8 + 5] = array6[5];
					goto case 524;
				case 520:
					num53 = num16 ^ num18;
					goto case 44;
				case 44:
					num54 = 0;
					goto case 18;
				case 519:
					num3 = 168;
					num = 473;
					goto case 473;
				case 473:
					array2[15] = (byte)num3;
					num2 = 80;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 518:
					array7[10] = 108;
					num2 = 192;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 48;
				case 516:
					array2[28] = 90;
					goto case 322;
				case 322:
					num3 = 131;
					num2 = 274;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 515:
					array[4] = (byte)num4;
					num2 = 4;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 513:
					smethod_154(object_);
					num2 = 217;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 510:
					num52 = array17.Length / 4;
					goto case 575;
				case 508:
					num3 = 88;
					num2 = 633;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 505:
					array3[5] = array11[2];
					goto case 175;
				case 175:
					array3[7] = array11[3];
					goto case 529;
				case 500:
					array7[9] = 100;
					goto case 518;
				case 498:
					array2[27] = 9;
					num2 = 22;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 497:
					num4 = 120;
					goto case 399;
				case 399:
					array[7] = (byte)num4;
					num2 = 30;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 496:
					num3 = 192;
					goto case 607;
				case 495:
					array2[2] = (byte)num3;
					goto case 259;
				case 259:
					array2[2] = 91;
					num2 = 441;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 491:
					array3[15] = array11[7];
					goto case 557;
				case 490:
					array[10] = (byte)num4;
					num2 = 9;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 489:
					array9[num8 + 5] = array12[5];
					num2 = 279;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 488:
					num3 = 132;
					goto case 456;
				case 456:
					array2[22] = (byte)num3;
					goto case 221;
				case 221:
					array2[22] = 156;
					num2 = 455;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 643;
				case 487:
					array2[27] = 101;
					goto case 496;
				case 485:
					array2[12] = (byte)num3;
					goto case 663;
				case 484:
					array9[num15] = array6[0];
					goto case 273;
				case 273:
					array9[num15 + 1] = array6[1];
					num = 422;
					goto case 422;
				case 422:
					array9[num15 + 2] = array6[2];
					goto case 81;
				case 81:
					array9[num15 + 3] = array6[3];
					goto case 602;
				case 482:
					num4 = 116;
					goto case 153;
				case 153:
					array[12] = (byte)num4;
					goto case 20;
				case 480:
					num12 = smethod_146(object_) - num42;
					goto case 374;
				case 374:
					num51 = smethod_146(object_);
					goto case 531;
				case 478:
					num50 = 0;
					goto case 304;
				case 477:
					if (smethod_145(smethod_144(smethod_162(typeof(Class25).TypeHandle).Assembly)) <= 0)
					{
						goto case 657;
					}
					goto case 578;
				case 475:
					array2[0] = 93;
					goto case 419;
				case 419:
					num3 = 98;
					goto case 537;
				case 474:
					goto IL_266a;
				case 332:
					object_ = new Class28(new MemoryStream(array8));
					num2 = 71;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 470:
					if (num49 == 4109628145u)
					{
						num2 = 280;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 296;
				case 296:
					if (smethod_115() != 4)
					{
						goto case 234;
					}
					goto case 69;
				case 69:
					if (!smethod_117(smethod_116("System.Reflection.ReflectionContext", bool_7: false), null))
					{
						goto case 234;
					}
					goto case 363;
				case 363:
					object_14 = (ProcessModuleCollection)smethod_118(smethod_109());
					goto case 17;
				case 469:
					array7[4] = 114;
					num = 137;
					goto case 137;
				case 467:
					smethod_153(object_6);
					num = 513;
					goto case 513;
				case 463:
					array16 = array18;
					num2 = 326;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 461:
					array[3] = 115;
					num = 362;
					goto case 362;
				case 362:
					array[3] = 13;
					goto case 386;
				case 386:
					array[3] = 104;
					goto case 626;
				case 460:
					num15 = 16;
					num2 = 156;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 267;
				case 267:
					array9[num15] = array10[0];
					num2 = 628;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 508;
				case 457:
					num18 = (uint)((array16[num48 + 3] << 24) | (array16[num48 + 2] << 16) | (array16[num48 + 1] << 8) | array16[num48]);
					goto case 117;
				case 452:
					num3 = 162;
					num2 = 184;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 451:
					procAddress = GetProcAddress(intptr_5, string_);
					num2 = 355;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 449:
					intptr_6 = smethod_168(object_7);
					goto case 603;
				case 448:
					array8 = (byte[])smethod_152(memoryStream);
					num2 = 41;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 447:
					num47++;
					goto case 135;
				case 446:
					array2[17] = (byte)num3;
					goto case 6;
				case 6:
					array2[18] = 169;
					goto case 430;
				case 430:
					array2[18] = 147;
					num2 = 245;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 71;
				case 71:
					smethod_135(smethod_134(object_), 0L);
					num2 = 188;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 445:
					object_13 = (SymmetricAlgorithm)smethod_147();
					goto case 223;
				case 223:
					smethod_148(object_13, CipherMode.CBC);
					goto case 283;
				case 283:
					transform = (ICryptoTransform)smethod_149(object_13, array17, array3);
					goto case 75;
				case 75:
					smethod_141(array17, 0, array17.Length);
					goto case 232;
				case 232:
					memoryStream = new MemoryStream();
					num2 = 335;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 444:
					array[11] = (byte)num4;
					num2 = 597;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 159;
				case 443:
					num4 = 41;
					num2 = 488;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 515;
				case 441:
					num3 = 99;
					num = 68;
					goto case 68;
				case 68:
					array2[3] = (byte)num3;
					goto case 269;
				case 269:
					array2[3] = 108;
					goto case 660;
				case 440:
					uint_ = (Enum9)56;
					goto case 207;
				case 207:
					intptr_2 = smethod_156((uint)uint_, 1, (uint)smethod_155(smethod_109()));
					goto case 166;
				case 166:
					if (smethod_115() == 4)
					{
						goto case 654;
					}
					goto case 174;
				case 174:
					intPtr4 = smethod_143(((object[])smethod_142(Class25.object_9))[0]);
					goto case 576;
				case 407:
				case 435:
					object_8 = (Process)smethod_109();
					num2 = 368;
					if (smethod_189())
					{
						continue;
					}
					goto case 186;
				case 429:
					text = (string)smethod_165(smethod_164(), array7);
					num2 = 324;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 427:
					try
					{
						ProcessModuleCollection object_11 = (ProcessModuleCollection)smethod_118(object_8);
						num39 = 0;
						if (smethod_189())
						{
							goto IL_29d5_2;
						}
						goto IL_29ef_2;
						IL_29ef_2:
						switch (num39)
						{
						case 1:
							break;
						default:
							goto end_IL_29bf_2;
						case 2:
							try
							{
								while (true)
								{
									if (!smethod_131(enumerator))
									{
										num40 = 1;
										if (!smethod_189())
										{
											goto IL_2a09_2;
										}
										goto IL_2a0d_2;
									}
									goto IL_2a2e_2;
									IL_2a0d_2:
									switch (num40)
									{
									case 3:
										intPtr4 = smethod_111(object_12);
										num41 = 2;
										goto case 2;
									case 2:
										if (intPtr4.ToInt64() != long_1)
										{
											continue;
										}
										goto case 6;
									case 4:
										continue;
									case 6:
										num42 = 0;
										goto end_IL_2a7c_2;
									case 1:
									case 5:
										goto end_IL_2a7c_2;
									}
									goto IL_2a2e_2;
									IL_2a2e_2:
									object_12 = (ProcessModule)smethod_120(enumerator);
									num40 = 3;
									if (smethod_190() != null)
									{
										goto IL_2a09_2;
									}
									goto IL_2a0d_2;
									IL_2a09_2:
									num40 = num41;
									goto IL_2a0d_2;
									continue;
									end_IL_2a7c_2:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								num43 = 0;
								if (smethod_190() != null)
								{
									goto IL_2abe_2;
								}
								goto IL_2ac4_2;
								IL_2ac4_2:
								switch (num43)
								{
								case 2:
									break;
								default:
									goto IL_2abe_2;
								case 1:
									goto end_IL_2a8c_2;
								}
								goto IL_2aa4_2;
								IL_2abe_2:
								if (disposable != null)
								{
									goto IL_2aa4_2;
								}
								goto end_IL_2a8c_2;
								IL_2aa4_2:
								smethod_132(disposable);
								num43 = 1;
								if (!smethod_189())
								{
									num43 = num44;
								}
								goto IL_2ac4_2;
								end_IL_2a8c_2:;
							}
							goto end_IL_29bf_2;
						case 0:
							goto end_IL_29bf_2;
						}
						goto IL_29d5_2;
						IL_29d5_2:
						enumerator = (IEnumerator)smethod_119(object_11);
						num39 = 2;
						if (!smethod_189())
						{
							num39 = num45;
						}
						goto IL_29ef_2;
						end_IL_29bf_2:;
					}
					catch (object obj2)
					{
						num46 = 0;
						if (smethod_190() != null)
						{
							switch (num46)
							{
							}
						}
					}
					goto case 14;
				case 421:
					array[11] = (byte)num4;
					num2 = 307;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 417:
					intptr_5 = LoadLibrary(text);
					goto case 39;
				case 39:
				case 303:
					array13 = new byte[6];
					goto case 564;
				case 415:
					num4 = 143;
					num2 = 15;
					if (!smethod_189())
					{
						continue;
					}
					goto case 51;
				case 51:
					array[8] = (byte)num4;
					goto case 287;
				case 287:
					array[9] = 121;
					num = 528;
					goto case 528;
				case 414:
					array2[29] = 104;
					num2 = 642;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 412:
					array2[31] = (byte)num3;
					num2 = 403;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 314;
				case 410:
					array[3] = (byte)num4;
					num2 = 165;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 404:
					array7[1] = 108;
					goto case 321;
				case 321:
					array7[2] = 114;
					goto case 313;
				case 313:
					array7[3] = 106;
					num = 547;
					goto case 547;
				case 403:
					num3 = 132;
					num2 = 584;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 400:
					array[1] = (byte)num4;
					num2 = 535;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 397:
					array[1] = 134;
					num2 = 661;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 394:
					array2[15] = (byte)num3;
					num = 220;
					goto case 220;
				case 220:
					num3 = 114;
					num2 = 164;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 389:
					array[2] = 171;
					goto case 461;
				case 388:
					num3 = 199;
					goto case 485;
				case 384:
					num38 = smethod_146(object_);
					goto case 640;
				case 381:
					array2[16] = (byte)num3;
					goto case 586;
				case 380:
					@struct = default(Struct19);
					goto case 593;
				case 378:
					array2[13] = (byte)num3;
					goto case 452;
				case 376:
					num4 = 224;
					num2 = 587;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 375:
					array[11] = (byte)num4;
					num = 134;
					goto case 134;
				case 134:
					array[12] = 154;
					goto case 482;
				case 371:
					if (smethod_145(smethod_144(Class25.object_9)) != 0)
					{
						num2 = 517;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 596;
				case 370:
					if (smethod_144(Class25.object_9) == null)
					{
						goto case 596;
					}
					goto case 371;
				case 368:
					try
					{
						ProcessModuleCollection object_9 = (ProcessModuleCollection)smethod_118(object_8);
						num28 = 1;
						if (smethod_190() != null)
						{
							num28 = num29;
						}
						switch (num28)
						{
						default:
							goto end_IL_2d7a_2;
						case 1:
							enumerator = (IEnumerator)smethod_119(object_9);
							num29 = 2;
							break;
						case 2:
							break;
						case 0:
							goto end_IL_2d7a_2;
						}
						try
						{
							while (smethod_131(enumerator))
							{
								while (true)
								{
									IL_2e85_2:
									ProcessModule object_10 = (ProcessModule)smethod_120(enumerator);
									num30 = 0;
									if (smethod_190() == null)
									{
										goto IL_2e34_2;
									}
									goto IL_2e5a_3;
									IL_2e5a_3:
									while (true)
									{
										switch (num30)
										{
										case 8:
											break;
										case 7:
											goto IL_2df5_2;
										case 4:
											goto IL_2e09_2;
										case 1:
											goto IL_2e34_2;
										default:
											smethod_114();
											num30 = 2;
											if (smethod_190() == null)
											{
												continue;
											}
											goto IL_2e34_2;
										case 6:
											goto IL_2e85_2;
										case 5:
											goto end_IL_2e85_2;
										case 2:
											return;
										case 3:
											goto end_IL_2ea2_2;
										}
										break;
									}
									goto IL_2dc3_2;
									IL_2e34_2:
									if (!smethod_123(smethod_121(object_10), text))
									{
										break;
									}
									goto IL_2df5_2;
									IL_2df5_2:
									num31 = num13;
									intPtr4 = smethod_111(object_10);
									if (num31 < intPtr4.ToInt64())
									{
										goto IL_2dc3_2;
									}
									goto IL_2e09_2;
									IL_2e09_2:
									num32 = num13;
									intPtr4 = smethod_111(object_10);
									if (num32 <= intPtr4.ToInt64() + smethod_172(object_10))
									{
										break;
									}
									num30 = 8;
									if (!smethod_189())
									{
										goto end_IL_2ea2_2;
									}
									goto IL_2e5a_3;
									IL_2dc3_2:
									if (!smethod_174(smethod_173(smethod_162(typeof(Class25).TypeHandle).Assembly), null))
									{
										break;
									}
									num30 = 0;
									if (smethod_190() != null)
									{
										num30 = num33;
									}
									goto IL_2e5a_3;
									continue;
									end_IL_2e85_2:
									break;
								}
								continue;
								end_IL_2ea2_2:
								break;
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							while (disposable != null)
							{
								num34 = 1;
								if (!smethod_189())
								{
									goto IL_2ee3_2;
								}
								goto IL_2ee7_3;
								IL_2ee3_2:
								num34 = num35;
								goto IL_2ee7_3;
								IL_2ee7_3:
								while (true)
								{
									switch (num34)
									{
									case 1:
										goto IL_2ecf_2;
									default:
										goto end_IL_2ee7_2;
									case 2:
										break;
									case 0:
										goto end_IL_2ee7_2;
									}
									goto IL_2efa_2;
									IL_2ecf_2:
									smethod_132(disposable);
									num34 = 0;
									if (smethod_190() == null)
									{
										continue;
									}
									goto IL_2ee3_2;
									continue;
									end_IL_2ee7_2:
									break;
								}
								break;
								IL_2efa_2:;
							}
						}
						end_IL_2d7a_2:;
					}
					catch (object obj)
					{
						num36 = 0;
						if (smethod_190() != null)
						{
							num36 = num37;
						}
						switch (num36)
						{
						}
					}
					goto case 427;
				case 366:
					array[1] = (byte)num4;
					goto case 397;
				case 360:
					smethod_151(object_6);
					goto case 448;
				case 358:
					smethod_101(new IntPtr(&num7), 0);
					goto case 108;
				case 108:
					smethod_102(new IntPtr(&num7), 0);
					goto case 132;
				case 132:
					smethod_103(new IntPtr(&num7), 0, IntPtr.Zero);
					goto case 442;
				case 357:
					array2[10] = (byte)num3;
					goto case 345;
				case 345:
					num3 = 124;
					num2 = 627;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 355:
					object_7 = (Delegate4)smethod_167(procAddress, smethod_162(typeof(Delegate4).TypeHandle));
					num2 = 449;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 352:
					array2[26] = 88;
					goto case 648;
				case 349:
					array2[20] = (byte)num3;
					goto case 258;
				case 258:
					array2[21] = 89;
					goto case 645;
				case 344:
					num3 = 136;
					goto case 649;
				case 339:
					num3 = 172;
					goto case 168;
				case 168:
					array2[11] = (byte)num3;
					num = 621;
					goto case 621;
				case 337:
					array[10] = 46;
					goto case 210;
				case 210:
					num4 = 105;
					num2 = 421;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 335:
					object_6 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					goto case 538;
				case 334:
					num3 = 119;
					num2 = 675;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 331:
					num4 = 168;
					goto case 444;
				case 330:
					num19 = 0;
					goto case 105;
				case 328:
					array[8] = (byte)num4;
					goto case 415;
				case 326:
					num25 = array16.Length % 4;
					num2 = 562;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 325:
					num3 = 131;
					goto case 412;
				case 318:
					if (num25 > 0)
					{
						num2 = 520;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 254;
				case 254:
					num26 = num16 ^ num18;
					goto case 189;
				case 189:
					array15[num27] = (byte)(num26 & 0xFFu);
					num2 = 1;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 111;
				case 111:
					array15[num27 + 1] = (byte)((num26 & 0xFF00) >> 8);
					goto case 605;
				case 305:
				case 315:
					num5 = 0;
					num2 = 93;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 311:
					array5 = null;
					num2 = 25;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 309:
					array2[29] = (byte)num3;
					num = 157;
					goto case 157;
				case 157:
					array2[29] = 129;
					goto case 414;
				case 308:
					num24++;
					num = 601;
					goto case 574;
				case 307:
					num4 = 5;
					goto case 171;
				case 171:
					array[11] = (byte)num4;
					num2 = 331;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 293:
					array2[16] = (byte)num3;
					goto case 508;
				case 290:
					array9[num8 + 2] = array12[2];
					goto case 86;
				case 86:
					array9[num8 + 3] = array12[3];
					num2 = 264;
					if (smethod_189())
					{
						continue;
					}
					goto case 102;
				case 285:
					int_3 = 0;
					goto case 129;
				case 281:
					array14 = new byte[40];
					smethod_186(array14, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					array5 = array14;
					goto case 249;
				case 280:
					flag = smethod_113(smethod_112(smethod_111(smethod_110(smethod_109())), "__", 10u), IntPtr.Zero);
					goto case 182;
				case 182:
					if (flag)
					{
						goto case 296;
					}
					goto case 156;
				case 279:
					array9[num8 + 6] = array12[6];
					num2 = 197;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 278:
					array2[5] = (byte)num3;
					goto case 526;
				case 276:
					string_ = (string)smethod_165(smethod_164(), array13);
					goto case 451;
				case 274:
					array2[28] = (byte)num3;
					goto case 246;
				case 246:
					num3 = 112;
					num2 = 147;
					if (!smethod_189())
					{
						continue;
					}
					goto case 309;
				case 266:
					array2[2] = 115;
					num = 344;
					goto case 344;
				case 265:
					array[4] = 107;
					goto case 376;
				case 264:
					array9[num8 + 4] = array12[4];
					goto case 489;
				case 262:
					array9[num15 + 3] = array10[3];
					goto case 167;
				case 167:
					num15 = 23;
					goto case 484;
				case 260:
					intPtr = smethod_171(object_17);
					num2 = 530;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 257:
					array[3] = (byte)num4;
					num2 = 443;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 256:
					num3 = 96;
					goto case 381;
				case 252:
					num3 = 155;
					goto case 194;
				case 194:
					array2[20] = (byte)num3;
					goto case 26;
				case 26:
					num3 = 85;
					goto case 74;
				case 74:
					array2[20] = (byte)num3;
					goto case 242;
				case 242:
					num3 = 68;
					goto case 349;
				case 251:
					smethod_108();
					goto case 470;
				case 248:
					num3 = 144;
					num2 = 551;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 330;
				case 247:
					try
					{
						while (true)
						{
							if (!smethod_131(enumerator))
							{
								num21 = 1;
								if (smethod_189())
								{
									goto IL_33f5_2;
								}
								goto IL_3466_2;
							}
							goto IL_34b9_2;
							IL_33d8_2:
							if (!smethod_130(object_2, object_3))
							{
								continue;
							}
							num21 = 11;
							if (smethod_190() != null)
							{
								break;
							}
							goto IL_33f5_2;
							IL_34b9_2:
							object_4 = (ProcessModule)smethod_120(enumerator);
							goto IL_349f_2;
							IL_349f_2:
							if (!smethod_123(smethod_122(smethod_121(object_4)), "clrjit.dll"))
							{
								continue;
							}
							goto IL_3466_2;
							IL_3466_2:
							object_2 = new Version(smethod_125(smethod_124(object_4)), smethod_126(smethod_124(object_4)), smethod_127(smethod_124(object_4)), smethod_128(smethod_124(object_4)));
							goto IL_3451_2;
							IL_3451_2:
							object_5 = new Version(4, 0, 30319, 17020);
							goto IL_342c_2;
							IL_342c_2:
							object_3 = new Version(4, 0, 30319, 17921);
							num21 = 4;
							if (smethod_190() == null)
							{
								goto IL_33ca_2;
							}
							goto IL_33f5_2;
							IL_33f5_2:
							switch (num21)
							{
							case 8:
								break;
							case 6:
								goto IL_33d8_2;
							case 9:
								goto IL_342c_2;
							case 3:
								goto IL_3451_2;
							default:
								goto IL_3466_2;
							case 7:
								goto IL_349f_2;
							case 10:
								goto IL_34b9_2;
							case 4:
							case 5:
								continue;
							case 11:
								bool_1 = true;
								goto end_IL_34db_2;
							case 1:
							case 2:
								goto end_IL_34db_2;
							}
							goto IL_33ca_2;
							IL_33ca_2:
							if (!smethod_129(object_2, object_5))
							{
								continue;
							}
							goto IL_33d8_2;
							continue;
							end_IL_34db_2:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						num22 = 1;
						if (smethod_190() != null)
						{
							num22 = num23;
						}
						do
						{
							switch (num22)
							{
							case 1:
								if (disposable == null)
								{
									goto end_IL_3527_2;
								}
								break;
							case 2:
							case 3:
								goto end_IL_3527_2;
							}
							smethod_132(disposable);
							num22 = 2;
							continue;
							end_IL_3527_2:
							break;
						}
						while (smethod_190() != null);
					}
					goto case 234;
				case 245:
					array2[18] = 191;
					goto case 84;
				case 84:
					num3 = 115;
					num2 = 136;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 244:
					num11 = intPtr4.ToInt64();
					num2 = 285;
					if (smethod_189())
					{
						continue;
					}
					goto case 51;
				case 241:
					array2[8] = (byte)num3;
					num2 = 23;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 239:
					num3 = 144;
					num2 = 570;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 237:
					array2[5] = (byte)num3;
					goto case 94;
				case 94:
					num3 = 120;
					goto case 672;
				case 233:
					array9[num8 + 2] = array10[2];
					goto case 59;
				case 59:
					array9[num8 + 3] = array10[3];
					num2 = 571;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 231:
					array[6] = 123;
					num2 = 563;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 230:
					if (num19 == num20 - 1)
					{
						num2 = 318;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 173;
					}
					goto case 254;
				case 229:
					smethod_185(smethod_184(smethod_175(Class25.object_6)));
					goto case 88;
				case 88:
					smethod_183(object_17);
					goto case 89;
				case 89:
					smethod_185(smethod_184(smethod_175(object_17)));
					num2 = 166;
					if (smethod_190() != null)
					{
						continue;
					}
					goto case 311;
				case 224:
					num16 += num17;
					goto case 127;
				case 127:
					num18 = 0u;
					num2 = 478;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 222:
					struct2.bool_0 = false;
					num2 = 623;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 212:
					num4 = 114;
					num2 = 410;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 206:
					array2[0] = (byte)num3;
					goto case 659;
				case 205:
					array9[num15 + 2] = array10[2];
					num2 = 262;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 201:
					array[6] = (byte)num4;
					goto case 231;
				case 200:
					num4 = 164;
					goto case 328;
				case 198:
					array9[num15 + 2] = array12[2];
					goto case 142;
				case 142:
					array9[num15 + 3] = array12[3];
					num2 = 460;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 197:
					array9[num8 + 7] = array12[7];
					goto case 121;
				case 121:
					num8 = 18;
					goto case 554;
				case 196:
					smethod_27(intptr_4, num14 * 4, 4, ref int_3);
					num2 = 162;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 195:
					array[2] = (byte)num4;
					goto case 155;
				case 155:
					array[2] = 86;
					goto case 389;
				case 193:
					array2[11] = (byte)num3;
					goto case 55;
				case 192:
					array7[11] = 108;
					goto case 429;
				case 191:
					array2[26] = (byte)num3;
					num = 97;
					goto case 97;
				case 97:
					array2[27] = 165;
					num = 498;
					goto case 498;
				case 188:
					intPtr4 = smethod_143(((object[])smethod_142(Class25.object_9))[0]);
					num2 = 244;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 187:
					array2[21] = (byte)num3;
					num = 634;
					goto case 634;
				case 183:
					array2[26] = (byte)num3;
					num = 2;
					goto case 2;
				case 181:
					array10 = (byte[])smethod_157(smethod_163(num13));
					num = 468;
					goto case 299;
				case 179:
					smethod_26(intptr_2, intPtr3, (byte[])smethod_157(smethod_146(object_)), 4u, out intptr_3);
					goto case 462;
				case 177:
					smethod_161(Class25.object_8, num11 + num12, @struct);
					goto case 48;
				case 169:
					array3[3] = array11[1];
					goto case 505;
				case 165:
					num4 = 226;
					num2 = 257;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 164:
					array2[15] = (byte)num3;
					num2 = 594;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 162:
					num10 = 0;
					num2 = 253;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 161:
					array9[num8 + 1] = array10[1];
					goto case 233;
				case 93:
				case 160:
					if (num5 >= num6)
					{
						goto IL_266a;
					}
					goto case 119;
				case 119:
					num9 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + (nint)num5 * (nint)8);
					*(long*)num9 ^= 242329859L;
					num2 = 70;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 150:
					array2[31] = 94;
					goto case 325;
				case 145:
					array2[26] = (byte)num3;
					goto case 352;
				case 136:
					array2[19] = (byte)num3;
					goto case 40;
				case 126:
					array9[num8 + 2] = array6[2];
					num2 = 635;
					if (smethod_189())
					{
						continue;
					}
					goto case 301;
				case 116:
					num3 = 145;
					goto case 293;
				case 115:
					smethod_188(new IntPtr(value), intPtr2);
					num2 = 466;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 98:
					array2[25] = 138;
					goto case 334;
				case 92:
					array2[1] = (byte)num3;
					num2 = 82;
					if (smethod_190() == null)
					{
						continue;
					}
					goto case 79;
				case 83:
					smethod_100(new IntPtr(&num7), 0);
					num2 = 358;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 82:
					array2[2] = 114;
					num2 = 266;
					if (smethod_189())
					{
						continue;
					}
					goto case 241;
				case 80:
					num3 = 163;
					num = 394;
					goto case 394;
				case 78:
					smethod_27(intptr_, 4, int_3, ref int_3);
					num2 = 308;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 77:
					num6 = array8.Length / 8;
					goto case 670;
				case 72:
					array2[22] = 84;
					goto case 488;
				case 70:
					num5++;
					num2 = 160;
					if (smethod_189())
					{
						continue;
					}
					goto IL_0067;
				case 62:
					array7[0] = 99;
					goto case 404;
				case 53:
					byte_ = (byte[])smethod_137(object_, int_2);
					goto case 380;
				case 52:
					array6 = (byte[])smethod_157(intPtr.ToInt32());
					num2 = 181;
					if (smethod_190() == null)
					{
						continue;
					}
					goto IL_0067;
				case 47:
					array4 = new byte[30];
					smethod_186(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					array5 = array4;
					goto case 249;
				case 46:
					array2[20] = 146;
					goto case 252;
				case 41:
					smethod_141(array3, 0, array3.Length);
					goto case 673;
				case 37:
					num3 = 100;
					num = 631;
					goto case 631;
				case 32:
					array[9] = 203;
					goto case 214;
				case 30:
					array[7] = 95;
					goto case 569;
				case 25:
					if (smethod_115() != 4)
					{
						num2 = 281;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0067;
					}
					goto case 47;
				case 24:
					num3 = 126;
					goto case 495;
				case 22:
					num3 = 108;
					num2 = 527;
					if (smethod_189())
					{
						continue;
					}
					goto case 63;
				case 19:
					array2[0] = (byte)num3;
					goto case 475;
				case 11:
					array[11] = (byte)num4;
					num = 678;
					goto case 678;
				case 9:
					array[10] = 165;
					num2 = 300;
					if (!smethod_189())
					{
						continue;
					}
					goto case 337;
				case 5:
					num3 = 80;
					goto case 92;
				case 4:
					array[4] = 134;
					num = 265;
					goto case 265;
				case 14:
					Class25.object_6 = null;
					goto case 536;
				case 156:
					smethod_114();
					return;
				case 382:
					return;
				case 466:
					smethod_27(new IntPtr(value), smethod_115(), int_, ref int_);
					num = 45;
					goto case 45;
				case 45:
				case 395:
					smethod_114();
					return;
				case 521:
					return;
				case 580:
					return;
				case 402:
					smethod_114();
					return;
				case 90:
					return;
					IL_266a:
					reference = ref *(byte*)null;
					goto case 332;
				}
				break;
			}
			continue;
			IL_0013:
			bool_2 = true;
			goto IL_0019;
			IL_0019:
			num49 = 4059231220u;
			goto IL_0020;
			IL_0020:
			num7 = 0L;
			num2 = 83;
			if (smethod_190() != null)
			{
				goto IL_1eff;
			}
			goto IL_3c5e;
			IL_1eff:
			num50++;
			num2 = 636;
			if (smethod_190() != null)
			{
				goto IL_0067;
			}
			goto IL_3c5e;
		}
	}

	internal static object smethod_23(object object_19)
	{
		try
		{
			if (File.Exists(((Assembly)object_19).Location))
			{
				return ((Assembly)object_19).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_19).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((Assembly)object_19).GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_19.GetType().GetProperty("Location")!.GetValue(object_19, new object[0])!.ToString()))
			{
				return object_19.GetType().GetProperty("Location")!.GetValue(object_19, new object[0])!.ToString();
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
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_0);

	private static IntPtr smethod_24(IntPtr intptr_4, object object_19, uint uint_0)
	{
		if (object_2 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			object_2 = (Delegate5)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class30.smethod_0(33554514)));
		}
		return object_2(intptr_4, (string)object_19, uint_0);
	}

	private static IntPtr smethod_25(IntPtr intptr_4, uint uint_0, uint uint_1, uint uint_2)
	{
		if (object_4 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			object_4 = (Delegate6)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class30.smethod_0(33554515)));
		}
		return object_4(intptr_4, uint_0, uint_1, uint_2);
	}

	private static int smethod_26(IntPtr intptr_4, IntPtr intptr_5, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_6)
	{
		if (object_14 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			object_14 = (Delegate7)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class30.smethod_0(33554516)));
		}
		return object_14(intptr_4, intptr_5, byte_0, uint_0, out intptr_6);
	}

	private static int smethod_27(IntPtr intptr_4, int int_4, int int_5, ref int int_6)
	{
		if (object_18 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			object_18 = (Delegate8)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class30.smethod_0(33554517)));
		}
		return object_18(intptr_4, int_4, int_5, ref int_6);
	}

	private static IntPtr smethod_28(uint uint_0, int int_4, uint uint_1)
	{
		if (object_3 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			object_3 = (Delegate9)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class30.smethod_0(33554518)));
		}
		return object_3(uint_0, int_4, uint_1);
	}

	private static int smethod_29(IntPtr intptr_4)
	{
		if (object_15 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			object_15 = (Delegate10)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class30.smethod_0(33554519)));
		}
		return object_15(intptr_4);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (intptr_3 == IntPtr.Zero)
		{
			intptr_3 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return intptr_3;
	}

	[Attribute0(typeof(Attribute0.Class26<object>[]))]
	private static byte[] smethod_30(object object_19)
	{
		using FileStream fileStream = new FileStream((string)object_19, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	internal static Stream smethod_31()
	{
		return new MemoryStream();
	}

	internal static byte[] smethod_32(object object_19)
	{
		return ((MemoryStream)object_19).ToArray();
	}

	[Attribute0(typeof(Attribute0.Class26<object>[]))]
	private static byte[] smethod_33(object object_19)
	{
		Stream stream = smethod_31();
		SymmetricAlgorithm symmetricAlgorithm = smethod_7();
		symmetricAlgorithm.Key = new byte[32]
		{
			180, 151, 92, 107, 226, 246, 157, 162, 93, 198,
			97, 194, 96, 77, 239, 141, 174, 76, 108, 167,
			212, 118, 62, 213, 93, 42, 168, 227, 104, 23,
			231, 197
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			90, 71, 21, 158, 197, 252, 73, 95, 156, 99,
			92, 159, 223, 249, 116, 156
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_19, 0, ((Array)object_19).Length);
		cryptoStream.Close();
		byte[] result = smethod_32(stream);
		Class29.smethod_0();
		return result;
	}

	private byte[] method_1()
	{
		return null;
	}

	private byte[] method_2()
	{
		return null;
	}

	private byte[] method_3()
	{
		return null;
	}

	private byte[] method_4()
	{
		return null;
	}

	private byte[] method_5()
	{
		return null;
	}

	private byte[] method_6()
	{
		return null;
	}

	internal byte[] method_7()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_8()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_9()
	{
		return null;
	}

	internal byte[] method_10()
	{
		return null;
	}

	internal static object smethod_34(object object_19, object object_20)
	{
		return ((Assembly)object_19).GetManifestResourceStream((string)object_20);
	}

	internal static object smethod_35(object object_19)
	{
		return ((Class28)object_19).KDikMXewCI();
	}

	internal static void smethod_36(object object_19, long long_2)
	{
		((Stream)object_19).Position = long_2;
	}

	internal static long smethod_37(object object_19)
	{
		return ((Stream)object_19).Length;
	}

	internal static object smethod_38(object object_19, int int_4)
	{
		return ((Class28)object_19).method_0(int_4);
	}

	internal static void smethod_39(object object_19)
	{
		((Class28)object_19).method_3();
	}

	internal static void smethod_40(object object_19)
	{
		Array.Reverse((Array)object_19);
	}

	internal static object smethod_41(object object_19)
	{
		return ((Assembly)object_19).GetName();
	}

	internal static object smethod_42(object object_19)
	{
		return ((AssemblyName)object_19).GetPublicKeyToken();
	}

	internal static object smethod_43()
	{
		return smethod_7();
	}

	internal static void smethod_44(object object_19, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_19).Mode = cipherMode_0;
	}

	internal static object smethod_45(object object_19, object object_20, object object_21)
	{
		return ((SymmetricAlgorithm)object_19).CreateDecryptor((byte[])object_20, (byte[]?)object_21);
	}

	internal static object smethod_46()
	{
		return smethod_31();
	}

	internal static void smethod_47(object object_19, object object_20, int int_4, int int_5)
	{
		((Stream)object_19).Write((byte[])object_20, int_4, int_5);
	}

	internal static void smethod_48(object object_19)
	{
		((CryptoStream)object_19).FlushFinalBlock();
	}

	internal static object smethod_49(object object_19)
	{
		return smethod_32(object_19);
	}

	internal static void smethod_50(object object_19)
	{
		((Stream)object_19).Close();
	}

	internal static int smethod_51(object object_19, int int_4)
	{
		return BitConverter.ToInt32((byte[])object_19, int_4);
	}

	internal static void smethod_52()
	{
		Class29.smethod_0();
	}

	internal static object smethod_53()
	{
		return Encoding.Unicode;
	}

	internal static object smethod_54(object object_19, object object_20, int int_4, int int_5)
	{
		return ((Encoding)object_19).GetString((byte[])object_20, int_4, int_5);
	}

	internal static bool smethod_55()
	{
		return (object)null == null;
	}

	internal static object smethod_56()
	{
		return null;
	}

	internal static void smethod_57()
	{
		Class29.smethod_0();
	}

	internal static void smethod_58(bool bool_7)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_7;
	}

	internal static Type smethod_59(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_60(object object_19)
	{
		return ((Assembly)object_19).Location;
	}

	internal static int smethod_61(object object_19)
	{
		return ((string)object_19).Length;
	}

	internal static object smethod_62()
	{
		return SHA1.Create();
	}

	internal static object smethod_63(object object_19)
	{
		return CryptoConfig.MapNameToOID((string)object_19);
	}

	internal static bool smethod_64(object object_19)
	{
		return File.Exists((string?)object_19);
	}

	internal static object smethod_65(object object_19, object object_20)
	{
		return ((Assembly)object_19).GetManifestResourceStream((string)object_20);
	}

	internal static object smethod_66(object object_19)
	{
		return ((Class28)object_19).KDikMXewCI();
	}

	internal static void smethod_67(object object_19, long long_2)
	{
		((Stream)object_19).Position = long_2;
	}

	internal static long smethod_68(object object_19)
	{
		return ((Stream)object_19).Length;
	}

	internal static object smethod_69(object object_19, int int_4)
	{
		return ((Class28)object_19).method_0(int_4);
	}

	internal static object smethod_70()
	{
		return smethod_7();
	}

	internal static void smethod_71(object object_19, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_19).Mode = cipherMode_0;
	}

	internal static object smethod_72(object object_19, object object_20, object object_21)
	{
		return ((SymmetricAlgorithm)object_19).CreateDecryptor((byte[])object_20, (byte[]?)object_21);
	}

	internal static object smethod_73()
	{
		return smethod_31();
	}

	internal static void smethod_74(object object_19, object object_20, int int_4, int int_5)
	{
		((Stream)object_19).Write((byte[])object_20, int_4, int_5);
	}

	internal static void smethod_75(object object_19)
	{
		((CryptoStream)object_19).FlushFinalBlock();
	}

	internal static object smethod_76()
	{
		return Encoding.UTF8;
	}

	internal static object smethod_77(object object_19)
	{
		return smethod_32(object_19);
	}

	internal static object smethod_78(object object_19, object object_20)
	{
		return ((Encoding)object_19).GetString((byte[])object_20);
	}

	internal static void smethod_79(object object_19, object object_20)
	{
		((AsymmetricAlgorithm)object_19).FromXmlString((string)object_20);
	}

	internal static void smethod_80(object object_19)
	{
		((Stream)object_19).Close();
	}

	internal static void smethod_81(object object_19)
	{
		((Class28)object_19).method_3();
	}

	internal static void smethod_82(object object_19, object object_20, uint uint_0, object object_21)
	{
		smethod_10(object_19, object_20, uint_0, object_21);
	}

	internal static ushort smethod_83(object object_19)
	{
		return ((BinaryReader)object_19).ReadUInt16();
	}

	internal static int smethod_84(object object_19, object object_20, int int_4, int int_5)
	{
		return ((Stream)object_19).Read((byte[])object_20, int_4, int_5);
	}

	internal static void smethod_85(object object_19, object object_20, int int_4, int int_5)
	{
		smethod_11(object_19, object_20, int_4, int_5);
	}

	internal static long smethod_86(object object_19)
	{
		return ((Stream)object_19).Position;
	}

	internal static uint smethod_87(object object_19)
	{
		return ((BinaryReader)object_19).ReadUInt32();
	}

	internal static uint smethod_88(uint uint_0, int int_4, long long_2, object object_19)
	{
		return smethod_12(uint_0, int_4, long_2, object_19);
	}

	internal static long smethod_89(long long_2, long long_3)
	{
		return Math.Min(long_2, long_3);
	}

	internal static object smethod_90(object object_19, object object_20, int int_4, int int_5)
	{
		return ((HashAlgorithm)object_19).TransformFinalBlock((byte[])object_20, int_4, int_5);
	}

	internal static object smethod_91(object object_19, int int_4)
	{
		return ((BinaryReader)object_19).ReadBytes(int_4);
	}

	internal static void smethod_92(object object_19)
	{
		Array.Reverse((Array)object_19);
	}

	internal static object smethod_93(object object_19)
	{
		return ((HashAlgorithm)object_19).Hash;
	}

	internal static bool smethod_94(object object_19, object object_20, object object_21, object object_22)
	{
		return ((RSACryptoServiceProvider)object_19).VerifyHash((byte[])object_20, (string)object_21, (byte[])object_22);
	}

	internal static object smethod_95(object object_19)
	{
		return ((Assembly)object_19).GetName();
	}

	internal static object smethod_96(object object_19)
	{
		return ((AssemblyName)object_19).Name;
	}

	internal static object smethod_97(object object_19, object object_20)
	{
		return (string?)object_19 + (string?)object_20;
	}

	internal static bool smethod_98()
	{
		return (object)null == null;
	}

	internal static object smethod_99()
	{
		return null;
	}

	internal static IntPtr smethod_100(IntPtr intptr_4, int int_4)
	{
		return Marshal.ReadIntPtr(intptr_4, int_4);
	}

	internal static int smethod_101(IntPtr intptr_4, int int_4)
	{
		return Marshal.ReadInt32(intptr_4, int_4);
	}

	internal static long smethod_102(IntPtr intptr_4, int int_4)
	{
		return Marshal.ReadInt64(intptr_4, int_4);
	}

	internal static void smethod_103(IntPtr intptr_4, int int_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, int_4, intptr_5);
	}

	internal static void smethod_104(IntPtr intptr_4, int int_4, int int_5)
	{
		Marshal.WriteInt32(intptr_4, int_4, int_5);
	}

	internal static void smethod_105(IntPtr intptr_4, int int_4, long long_2)
	{
		Marshal.WriteInt64(intptr_4, int_4, long_2);
	}

	internal static IntPtr smethod_106(int int_4)
	{
		return Marshal.AllocCoTaskMem(int_4);
	}

	internal static void smethod_107(object object_19, int int_4, IntPtr intptr_4, int int_5)
	{
		Marshal.Copy((byte[])object_19, int_4, intptr_4, int_5);
	}

	internal static void smethod_108()
	{
		smethod_20();
	}

	internal static object smethod_109()
	{
		return Process.GetCurrentProcess();
	}

	internal static object smethod_110(object object_19)
	{
		return ((Process)object_19).MainModule;
	}

	internal static IntPtr smethod_111(object object_19)
	{
		return ((ProcessModule)object_19).BaseAddress;
	}

	internal static IntPtr smethod_112(IntPtr intptr_4, object object_19, uint uint_0)
	{
		return smethod_24(intptr_4, object_19, uint_0);
	}

	internal static bool smethod_113(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 != intptr_5;
	}

	internal static void smethod_114()
	{
		Class29.smethod_0();
	}

	internal static int smethod_115()
	{
		return IntPtr.Size;
	}

	internal static Type smethod_116(object object_19, bool bool_7)
	{
		return Type.GetType((string)object_19, bool_7);
	}

	internal static bool smethod_117(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static object smethod_118(object object_19)
	{
		return ((Process)object_19).Modules;
	}

	internal static object smethod_119(object object_19)
	{
		return ((ReadOnlyCollectionBase)object_19).GetEnumerator();
	}

	internal static object smethod_120(object object_19)
	{
		return ((IEnumerator)object_19).Current;
	}

	internal static object smethod_121(object object_19)
	{
		return ((ProcessModule)object_19).ModuleName;
	}

	internal static object smethod_122(object object_19)
	{
		return ((string)object_19).ToLower();
	}

	internal static bool smethod_123(object object_19, object object_20)
	{
		return (string?)object_19 == (string?)object_20;
	}

	internal static object smethod_124(object object_19)
	{
		return ((ProcessModule)object_19).FileVersionInfo;
	}

	internal static int smethod_125(object object_19)
	{
		return ((FileVersionInfo)object_19).ProductMajorPart;
	}

	internal static int smethod_126(object object_19)
	{
		return ((FileVersionInfo)object_19).ProductMinorPart;
	}

	internal static int smethod_127(object object_19)
	{
		return ((FileVersionInfo)object_19).ProductBuildPart;
	}

	internal static int smethod_128(object object_19)
	{
		return ((FileVersionInfo)object_19).ProductPrivatePart;
	}

	internal static bool smethod_129(object object_19, object object_20)
	{
		return (Version?)object_19 >= (Version?)object_20;
	}

	internal static bool smethod_130(object object_19, object object_20)
	{
		return (Version?)object_19 < (Version?)object_20;
	}

	internal static bool smethod_131(object object_19)
	{
		return ((IEnumerator)object_19).MoveNext();
	}

	internal static void smethod_132(object object_19)
	{
		((IDisposable)object_19).Dispose();
	}

	internal static object smethod_133(object object_19, object object_20)
	{
		return ((Assembly)object_19).GetManifestResourceStream((string)object_20);
	}

	internal static object smethod_134(object object_19)
	{
		return ((Class28)object_19).KDikMXewCI();
	}

	internal static void smethod_135(object object_19, long long_2)
	{
		((Stream)object_19).Position = long_2;
	}

	internal static long smethod_136(object object_19)
	{
		return ((Stream)object_19).Length;
	}

	internal static object smethod_137(object object_19, int int_4)
	{
		return ((Class28)object_19).method_0(int_4);
	}

	internal static void smethod_138(object object_19)
	{
		Array.Reverse((Array)object_19);
	}

	internal static object smethod_139(object object_19)
	{
		return ((Assembly)object_19).GetName();
	}

	internal static object smethod_140(object object_19)
	{
		return ((AssemblyName)object_19).GetPublicKeyToken();
	}

	internal static void smethod_141(object object_19, int int_4, int int_5)
	{
		Array.Clear((Array)object_19, int_4, int_5);
	}

	internal static object smethod_142(object object_19)
	{
		return ((Assembly)object_19).GetModules();
	}

	internal static IntPtr smethod_143(object object_19)
	{
		return Marshal.GetHINSTANCE((Module)object_19);
	}

	internal static object smethod_144(object object_19)
	{
		return ((Assembly)object_19).Location;
	}

	internal static int smethod_145(object object_19)
	{
		return ((string)object_19).Length;
	}

	internal static int smethod_146(object object_19)
	{
		return ((Class28)object_19).method_2();
	}

	internal static object smethod_147()
	{
		return smethod_7();
	}

	internal static void smethod_148(object object_19, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_19).Mode = cipherMode_0;
	}

	internal static object smethod_149(object object_19, object object_20, object object_21)
	{
		return ((SymmetricAlgorithm)object_19).CreateDecryptor((byte[])object_20, (byte[]?)object_21);
	}

	internal static void smethod_150(object object_19, object object_20, int int_4, int int_5)
	{
		((Stream)object_19).Write((byte[])object_20, int_4, int_5);
	}

	internal static void smethod_151(object object_19)
	{
		((CryptoStream)object_19).FlushFinalBlock();
	}

	internal static object smethod_152(object object_19)
	{
		return ((MemoryStream)object_19).ToArray();
	}

	internal static void smethod_153(object object_19)
	{
		((Stream)object_19).Close();
	}

	internal static void smethod_154(object object_19)
	{
		((Class28)object_19).method_3();
	}

	internal static int smethod_155(object object_19)
	{
		return ((Process)object_19).Id;
	}

	internal static IntPtr smethod_156(uint uint_0, int int_4, uint uint_1)
	{
		return smethod_28(uint_0, int_4, uint_1);
	}

	internal static object smethod_157(int int_4)
	{
		return BitConverter.GetBytes(int_4);
	}

	internal static long smethod_158(object object_19)
	{
		return ((Stream)object_19).Position;
	}

	internal static void smethod_159(IntPtr intptr_4, int int_4)
	{
		Marshal.WriteInt32(intptr_4, int_4);
	}

	internal static int smethod_160(IntPtr intptr_4)
	{
		return smethod_29(intptr_4);
	}

	internal static void smethod_161(object object_19, object object_20, object object_21)
	{
		((Hashtable)object_19).Add(object_20, object_21);
	}

	internal static Type smethod_162(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_163(long long_2)
	{
		return Convert.ToInt32(long_2);
	}

	internal static object smethod_164()
	{
		return Encoding.UTF8;
	}

	internal static object smethod_165(object object_19, object object_20)
	{
		return ((Encoding)object_19).GetString((byte[])object_20);
	}

	internal static bool smethod_166(IntPtr intptr_4, IntPtr intptr_5)
	{
		return intptr_4 == intptr_5;
	}

	internal static object smethod_167(IntPtr intptr_4, Type type_0)
	{
		return smethod_21(intptr_4, type_0);
	}

	internal static IntPtr smethod_168(object object_19)
	{
		return object_19();
	}

	internal static int smethod_169(IntPtr intptr_4)
	{
		return Marshal.ReadInt32(intptr_4);
	}

	internal static long smethod_170(IntPtr intptr_4)
	{
		return Marshal.ReadInt64(intptr_4);
	}

	internal static IntPtr smethod_171(object object_19)
	{
		return Marshal.GetFunctionPointerForDelegate((Delegate)object_19);
	}

	internal static int smethod_172(object object_19)
	{
		return ((ProcessModule)object_19).ModuleMemorySize;
	}

	internal static object smethod_173(object object_19)
	{
		return ((Assembly)object_19).EntryPoint;
	}

	internal static bool smethod_174(object object_19, object object_20)
	{
		return (MethodInfo?)object_19 != (MethodInfo?)object_20;
	}

	internal static object smethod_175(object object_19)
	{
		return ((Delegate)object_19).Method;
	}

	internal static object smethod_176(Type type_0, object object_19)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_19);
	}

	internal static object smethod_177(object object_19)
	{
		return ((MethodBase)object_19).GetParameters();
	}

	internal static object smethod_178(object object_19)
	{
		return ((Assembly)object_19).ManifestModule;
	}

	internal static ModuleHandle smethod_179(object object_19)
	{
		return ((Module)object_19).ModuleHandle;
	}

	internal static Type smethod_180(object object_19)
	{
		return object_19.GetType();
	}

	internal static object smethod_181(object object_19, object object_20)
	{
		return ((FieldInfo)object_19).GetValue(object_20);
	}

	internal static object smethod_182(long long_2)
	{
		return BitConverter.GetBytes(long_2);
	}

	internal static void smethod_183(object object_19)
	{
		RuntimeHelpers.PrepareDelegate((Delegate)object_19);
	}

	internal static RuntimeMethodHandle smethod_184(object object_19)
	{
		return ((MethodBase)object_19).MethodHandle;
	}

	internal static void smethod_185(RuntimeMethodHandle runtimeMethodHandle_0)
	{
		RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
	}

	internal static void smethod_186(object object_19, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_19, runtimeFieldHandle_0);
	}

	internal static IntPtr smethod_187(IntPtr intptr_4, uint uint_0, uint uint_1, uint uint_2)
	{
		return smethod_25(intptr_4, uint_0, uint_1, uint_2);
	}

	internal static void smethod_188(IntPtr intptr_4, IntPtr intptr_5)
	{
		Marshal.WriteIntPtr(intptr_4, intptr_5);
	}

	internal static bool smethod_189()
	{
		return (object)null == null;
	}

	internal static object smethod_190()
	{
		return null;
	}
}
