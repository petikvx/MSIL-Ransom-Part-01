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
using ns39;
using ns40;

namespace ns38;

internal class Class21
{
	private delegate void Delegate1(object o);

	internal class Attribute0 : Attribute
	{
		internal class Class22<T>
		{
			internal static object object_0;

			static Class22()
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

		[Attribute0(typeof(Class22<object>[]))]
		public Attribute0(object object_0)
		{
		}

		static Attribute0()
		{
			smethod_22();
		}
	}

	internal class Class23
	{
		[Attribute0(typeof(Attribute0.Class22<object>[]))]
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

		internal static object smethod_5()
		{
			return null;
		}

		internal static void smethod_6(object object_0, object object_1)
		{
		}

		internal static void smethod_7(object object_0, object object_1)
		{
		}

		internal static object smethod_8(object object_0)
		{
			return null;
		}

		internal static void smethod_9(object object_0, object object_1, int int_0, int int_1)
		{
		}

		internal static void smethod_10(object object_0)
		{
		}

		internal static object smethod_11(object object_0)
		{
			return null;
		}

		internal static object smethod_12(object object_0)
		{
			return null;
		}

		static Class23()
		{
			smethod_22();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	internal struct Struct15
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	internal class Class24
	{
		private object object_0;

		public Class24(Stream stream_0)
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
			return (byte[])smethod_1(object_0, int_0);
		}

		internal int method_1(byte[] byte_0, int int_0, int int_1)
		{
			return smethod_2(object_0, byte_0, int_0, int_1);
		}

		internal int method_2()
		{
			return smethod_3(object_0);
		}

		internal void method_3()
		{
			smethod_4(object_0);
		}

		internal static object smethod_0(object object_1)
		{
			return ((BinaryReader)object_1).BaseStream;
		}

		internal static object smethod_1(object object_1, int int_0)
		{
			return ((BinaryReader)object_1).ReadBytes(int_0);
		}

		internal static int smethod_2(object object_1, object object_2, int int_0, int int_1)
		{
			return ((BinaryReader)object_1).Read((byte[])object_2, int_0, int_1);
		}

		internal static int smethod_3(object object_1)
		{
			return ((BinaryReader)object_1).ReadInt32();
		}

		internal static void smethod_4(object object_1)
		{
			((BinaryReader)object_1).Close();
		}

		static Class24()
		{
			smethod_22();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	[Flags]
	private enum Enum7
	{

	}

	private static object object_0;

	private static int int_0;

	private static int int_1;

	private static bool bool_0;

	private static object object_1;

	private static IntPtr intptr_0;

	private static object object_2;

	private static int int_2;

	private static bool bool_1;

	private static object object_3;

	private static int int_3;

	internal static object object_4;

	private static long long_0;

	private static bool bool_2;

	private static IntPtr intptr_1;

	internal static object object_5;

	private static object object_6;

	internal static object object_7;

	private static IntPtr intptr_2;

	private static bool bool_3;

	internal static object object_8;

	private static object object_9;

	private static object object_10;

	private static long long_1;

	private static object object_11;

	private static object object_12;

	private static bool bool_4;

	private static object object_13;

	[Attribute0(typeof(Attribute0.Class22<object>[]))]
	private static bool bool_5;

	private static Dictionary<int, int> dictionary_0;

	private static bool bool_6;

	private static object object_14;

	private static IntPtr intptr_3;

	private static object object_15;

	private static object object_16;

	internal static object object_17;

	private static object object_18;

	static Class21()
	{
		bool_6 = false;
		object_5 = Type.GetTypeFromHandle(Class26.smethod_0(33554491)).Assembly;
		object_3 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bool_1 = false;
		bool_2 = false;
		object_15 = new byte[0];
		object_8 = null;
		dictionary_0 = null;
		object_10 = new object();
		object_6 = new byte[0];
		object_18 = new byte[0];
		intptr_1 = IntPtr.Zero;
		intptr_3 = IntPtr.Zero;
		object_16 = new string[0];
		object_0 = new int[0];
		int_2 = 1;
		bool_0 = false;
		object_11 = new SortedList();
		int_3 = 0;
		long_0 = 0L;
		object_17 = null;
		object_7 = null;
		long_1 = 0L;
		int_0 = 0;
		bool_4 = false;
		bool_3 = false;
		int_1 = 0;
		intptr_2 = IntPtr.Zero;
		bool_5 = false;
		object_4 = new Hashtable();
		object_9 = null;
		object_14 = null;
		object_13 = null;
		object_12 = null;
		object_2 = null;
		object_1 = null;
		intptr_0 = IntPtr.Zero;
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
		uint_0 = uint_1 + smethod_5(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_19)[uint_4] + ((uint[])object_3)[uint_5 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_19)[uint_4] + ((uint[])object_3)[uint_5 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_19)[uint_4] + ((uint[])object_3)[uint_5 - 1], ushort_0);
	}

	private static void smethod_4(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_19)
	{
		uint_0 = uint_1 + smethod_5(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_19)[uint_4] + ((uint[])object_3)[uint_5 - 1], ushort_0);
	}

	private static uint smethod_5(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool smethod_6()
	{
		if (!bool_1)
		{
			smethod_8();
			bool_1 = true;
		}
		return bool_2;
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
			bool_2 = CryptoConfig.AllowOnlyFipsAlgorithms;
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

	[Attribute0(typeof(Attribute0.Class22<object>[]))]
	internal static void smethod_13()
	{
		int num = 5;
		string text = default(string);
		long num4 = default(long);
		uint uint_ = default(uint);
		int num13 = default(int);
		long num11 = default(long);
		BinaryReader object_ = default(BinaryReader);
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		byte[] array = default(byte[]);
		long long_ = default(long);
		bool flag = default(bool);
		uint uint_2 = default(uint);
		uint num17 = default(uint);
		uint num8 = default(uint);
		uint num16 = default(uint);
		int num12 = default(int);
		int int_ = default(int);
		long num7 = default(long);
		long num6 = default(long);
		int num14 = default(int);
		uint num15 = default(uint);
		uint num9 = default(uint);
		uint num5 = default(uint);
		byte[] array2 = default(byte[]);
		bool flag2 = default(bool);
		int num19 = default(int);
		string object_2 = default(string);
		int num21 = default(int);
		int num25 = default(int);
		byte[] array4 = default(byte[]);
		byte[] object_7 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num23 = default(int);
		int num24 = default(int);
		Stream stream = default(Stream);
		CryptoStream object_4 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		byte[] array5 = default(byte[]);
		SymmetricAlgorithm object_6 = default(SymmetricAlgorithm);
		byte[] object_5 = default(byte[]);
		int num27 = default(int);
		while (object_8 == null)
		{
			while (true)
			{
				IL_0013:
				smethod_57();
				while (true)
				{
					smethod_58(bool_7: true);
					int num2 = 7;
					if (smethod_98())
					{
						goto IL_002d;
					}
					goto IL_27d9;
					IL_27d9:
					object_8 = new RSACryptoServiceProvider();
					goto IL_21b5;
					IL_21b5:
					text = (string)smethod_60(smethod_59(typeof(Class21).TypeHandle).Assembly);
					goto IL_21cb;
					IL_21cb:
					if (text == null)
					{
						num = 3;
						return;
					}
					goto IL_215c;
					IL_280e:
					throw new Exception((string?)smethod_97(smethod_96(smethod_95(smethod_59(typeof(Class21).TypeHandle).Assembly)), " is tampered."));
					IL_215c:
					if (smethod_61(text) != 0)
					{
						hashAlgorithm = null;
						goto IL_216b;
					}
					return;
					IL_002d:
					switch (num2)
					{
					case 5:
						break;
					case 1:
						goto IL_0013;
					case 9:
						continue;
					case 18:
						goto IL_0083;
					case 14:
						goto IL_0086;
					case 16:
						goto IL_215c;
					case 6:
						goto IL_216b;
					case 2:
						goto IL_216e;
					case 15:
						goto IL_21b5;
					case 10:
						goto IL_21cb;
					case 11:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num3 = 36;
							if (smethod_99() != null)
							{
								goto IL_2213;
							}
							goto IL_261c;
							IL_261c:
							while (true)
							{
								int num10;
								switch (num3)
								{
								case 74:
									num4 = smethod_88(uint_, num13, num11, object_);
									num3 = 16;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 73:
									smethod_82(hashAlgorithm, fileStream, (uint)(num13 * 40), array);
									goto case 49;
								case 49:
									long_ = smethod_86(fileStream);
									goto case 17;
								case 17:
									if (!flag)
									{
										goto case 45;
									}
									goto case 24;
								case 45:
								case 62:
									smethod_67(fileStream, 376L);
									goto case 18;
								case 24:
									smethod_67(fileStream, 360L);
									goto case 18;
								case 18:
								case 43:
									uint_2 = smethod_87(object_);
									num3 = 3;
									if (!smethod_98())
									{
										continue;
									}
									goto case 26;
								case 26:
									num17 = smethod_88(uint_2, num13, num11, object_);
									goto case 20;
								case 20:
									smethod_67(fileStream, num17 + 32);
									goto case 35;
								case 35:
									uint_ = smethod_87(object_);
									num3 = 19;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 72:
									num8 -= num16;
									num12 = 41;
									goto case 41;
								case 41:
									smethod_67(fileStream, smethod_86(fileStream) + num16);
									num3 = 69;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 71:
									smethod_82(hashAlgorithm, fileStream, 152u, array);
									goto case 33;
								case 33:
									flag = smethod_83(object_) != 523;
									num3 = 48;
									if (smethod_98())
									{
										continue;
									}
									goto case 36;
								case 36:
									object_ = new BinaryReader(fileStream);
									num3 = 38;
									if (smethod_98())
									{
										continue;
									}
									goto case 11;
								case 11:
									array[65] = 0;
									num3 = 42;
									if (smethod_98())
									{
										continue;
									}
									break;
								case 70:
									smethod_67(fileStream, 152L);
									goto case 66;
								case 66:
									smethod_84(fileStream, array, 0, int_);
									goto case 27;
								case 27:
									array[64] = 0;
									goto case 11;
								case 59:
								case 65:
								case 69:
									if (num8 != 0)
									{
										goto default;
									}
									goto case 9;
								default:
									num7 = smethod_86(fileStream);
									num3 = 17;
									if (!smethod_98())
									{
										continue;
									}
									goto case 53;
								case 53:
									if (num4 <= num7)
									{
										goto case 44;
									}
									goto case 15;
								case 44:
									if (num7 < num6)
									{
										goto case 54;
									}
									goto case 15;
								case 54:
									num16 = (uint)(num6 - num7);
									goto case 5;
								case 5:
									if (num16 < num8)
									{
										goto case 72;
									}
									goto case 9;
								case 15:
									if (num7 < num6)
									{
										num3 = 40;
										if (smethod_99() == null)
										{
											continue;
										}
										break;
									}
									goto case 1;
								case 1:
									smethod_82(hashAlgorithm, fileStream, num8, array);
									num3 = 7;
									if (!smethod_98())
									{
										continue;
									}
									goto case 9;
								case 9:
								case 22:
									num14++;
									goto case 13;
								case 13:
								case 14:
									if (num14 < num13)
									{
										goto case 6;
									}
									goto case 21;
								case 6:
								case 28:
									smethod_67(fileStream, num11 + num14 * 40 + 16L);
									goto case 60;
								case 60:
									num8 = smethod_87(object_);
									goto case 32;
								case 32:
									num15 = smethod_87(object_);
									num3 = 67;
									if (smethod_98())
									{
										continue;
									}
									break;
								case 68:
									smethod_82(hashAlgorithm, fileStream, num9, array);
									goto case 29;
								case 29:
									num8 -= num9;
									num3 = 65;
									if (smethod_98())
									{
										continue;
									}
									break;
								case 67:
									smethod_67(fileStream, num15);
									num3 = 59;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 64:
									smethod_67(fileStream, num11);
									num3 = 73;
									if (smethod_98())
									{
										continue;
									}
									break;
								case 63:
									smethod_85(hashAlgorithm, array, 0, int_);
									goto case 57;
								case 57:
									smethod_84(fileStream, array, 0, 128);
									goto case 10;
								case 10:
									array[32] = 0;
									goto case 3;
								case 3:
									array[33] = 0;
									num3 = 34;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 61:
									smethod_67(fileStream, long_);
									goto case 37;
								case 37:
									num14 = 0;
									num12 = 14;
									goto case 13;
								case 58:
									array[39] = 0;
									goto case 55;
								case 55:
									smethod_85(hashAlgorithm, array, 0, 128);
									goto case 52;
								case 52:
									num11 = smethod_86(fileStream);
									num12 = 8;
									goto case 8;
								case 8:
									smethod_67(fileStream, 134L);
									num12 = 46;
									goto case 46;
								case 46:
									num13 = smethod_83(object_);
									num3 = 64;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 51:
									array[35] = 0;
									goto case 31;
								case 31:
									array[36] = 0;
									goto case 23;
								case 23:
									array[37] = 0;
									goto case 4;
								case 4:
									array[38] = 0;
									goto case 58;
								case 48:
									if (!flag)
									{
										goto case 47;
									}
									num10 = 96;
									goto IL_2574;
								case 47:
									num10 = 112;
									goto IL_2574;
								case 42:
									array[66] = 0;
									goto case 30;
								case 30:
									array[67] = 0;
									num3 = 63;
									if (smethod_98())
									{
										continue;
									}
									break;
								case 12:
								case 40:
									num9 = (uint)smethod_89(num4 - num7, num8);
									num3 = 68;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 38:
									array = new byte[65536];
									num3 = 71;
									if (smethod_98())
									{
										continue;
									}
									break;
								case 34:
									array[34] = 0;
									goto case 51;
								case 19:
									num5 = smethod_87(object_);
									num3 = 74;
									if (smethod_99() == null)
									{
										continue;
									}
									goto case 72;
								case 16:
									num6 = num4 + num5;
									num3 = 61;
									if (smethod_99() == null)
									{
										continue;
									}
									break;
								case 21:
									smethod_90(hashAlgorithm, new byte[0], 0, 0);
									goto case 7;
								case 7:
									smethod_67(fileStream, num4);
									goto case 2;
								case 2:
									array2 = (byte[])smethod_91(object_, (int)num5);
									goto case 50;
								case 50:
									smethod_92(array2);
									goto case 56;
								case 56:
									flag2 = !smethod_94(object_8, smethod_93(hashAlgorithm), object_2, array2);
									num12 = 39;
									goto end_IL_261c;
								case 39:
									goto end_IL_261c;
									IL_2574:
									int_ = num10;
									goto case 70;
								}
								goto IL_2213;
								continue;
								end_IL_261c:
								break;
							}
							goto end_IL_21d5;
							IL_2213:
							num3 = num12;
							goto IL_261c;
							end_IL_21d5:;
						}
						catch
						{
							int num18 = 1;
							if (smethod_98())
							{
								goto IL_27b2;
							}
							goto IL_27d1;
							IL_27b2:
							while (true)
							{
								switch (num18)
								{
								case 1:
									goto IL_27c1;
								case 0:
									break;
								}
								break;
								IL_27c1:
								flag2 = true;
								num18 = 0;
								if (smethod_99() == null)
								{
									continue;
								}
								goto IL_27d1;
							}
							goto end_IL_27a2;
							IL_27d1:
							num18 = num19;
							goto IL_27b2;
							end_IL_27a2:;
						}
						goto IL_27f2;
					case 7:
						goto IL_27d9;
					case 17:
						goto IL_27eb;
					default:
						goto IL_27f2;
					case 3:
					case 12:
						return;
					case 13:
						goto IL_280e;
					case 4:
					case 8:
						return;
					}
					break;
					IL_216b:
					object_2 = null;
					goto IL_216e;
					IL_216e:
					try
					{
						hashAlgorithm = (HashAlgorithm)smethod_62();
						object_2 = (string)smethod_63("SHA1");
						if (!smethod_64(text))
						{
							return;
						}
					}
					catch
					{
						int num20 = 0;
						if (!smethod_98())
						{
							num20 = num21;
						}
						switch (num20)
						{
						}
						return;
					}
					goto IL_0083;
					IL_0083:
					flag2 = false;
					goto IL_0086;
					IL_0086:
					try
					{
						Class24 object_3 = new Class24((Stream)smethod_65(Class21.object_5, "\u009b00fed\u008bh1\u009a5\u009efj0j\u008fe.8\u0089eq3\u008f\u008c\u0097c4\u0089\u009d\u0093\u009ag6k\u0094"));
						int num22 = 318;
						if (!smethod_98())
						{
							goto IL_00f6;
						}
						goto IL_1b75;
						IL_1b75:
						while (true)
						{
							switch (num22)
							{
							case 331:
								num25 = 158;
								goto case 192;
							case 192:
								array4[2] = (byte)num25;
								goto case 38;
							case 38:
								num25 = 169;
								goto case 121;
							case 121:
								array4[3] = (byte)num25;
								goto case 52;
							case 52:
								num25 = 158;
								num22 = 291;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 330:
								object_7 = array3;
								goto case 23;
							case 23:
								array4 = new byte[16];
								num23 = 82;
								goto case 82;
							case 82:
								num25 = 92;
								goto case 75;
							case 75:
								array4[0] = (byte)num25;
								goto case 151;
							case 151:
								num25 = 110;
								num22 = 226;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 329:
								array3[16] = (byte)num24;
								num23 = 8;
								goto case 8;
							case 8:
								num24 = 98;
								num22 = 15;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 7;
							case 7:
								array4[1] = (byte)num25;
								num22 = 271;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 328:
								num25 = 92;
								goto case 232;
							case 232:
								array4[0] = (byte)num25;
								goto case 256;
							case 256:
								num25 = 130;
								num22 = 7;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 327:
								array3[0] = (byte)num24;
								goto case 255;
							case 255:
								num24 = 189;
								goto case 308;
							case 308:
								array3[0] = (byte)num24;
								goto case 62;
							case 62:
								num24 = 59;
								goto case 154;
							case 154:
								array3[0] = (byte)num24;
								num22 = 17;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 326:
								array3[30] = 0;
								num22 = 290;
								if (smethod_98())
								{
									continue;
								}
								goto case 117;
							case 117:
								array3[15] = (byte)num24;
								num22 = 242;
								if (smethod_98())
								{
									continue;
								}
								goto case 139;
							case 139:
								array4[5] = (byte)num25;
								num22 = 168;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 325:
								num25 = 120;
								num22 = 29;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 324:
								num24 = 176;
								num22 = 104;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 323:
								array4[14] = 216;
								num23 = 180;
								goto case 180;
							case 180:
								num25 = 91;
								goto case 110;
							case 110:
								array4[15] = (byte)num25;
								goto case 65;
							case 65:
								num25 = 102;
								num22 = 123;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 73;
							case 73:
								array3[1] = 206;
								num22 = 12;
								if (!smethod_98())
								{
									continue;
								}
								goto case 22;
							case 22:
								array3[1] = 130;
								num22 = 4;
								if (!smethod_98())
								{
									continue;
								}
								goto case 144;
							case 144:
								array3[1] = 226;
								goto case 284;
							case 284:
								num24 = 150;
								num23 = 296;
								goto case 296;
							case 296:
								array3[2] = (byte)num24;
								goto case 193;
							case 193:
								array3[2] = 220;
								num22 = 199;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 322:
								array4[5] = 146;
								goto case 69;
							case 69:
								num25 = 141;
								goto case 139;
							case 321:
								array3[9] = 118;
								goto case 243;
							case 243:
								num24 = 120;
								num22 = 58;
								if (!smethod_98())
								{
									continue;
								}
								goto case 195;
							case 195:
								array3[9] = (byte)num24;
								num22 = 143;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 320:
								array4[15] = 88;
								goto case 183;
							case 183:
								array4[15] = 155;
								num22 = 211;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 319:
								stream = (Stream)smethod_73();
								goto case 128;
							case 128:
								object_4 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
								num23 = 2;
								goto case 2;
							case 2:
								smethod_74(object_4, array5, 0, array5.Length);
								num22 = 197;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 318:
								smethod_67(smethod_66(object_3), 0L);
								goto case 116;
							case 116:
								array5 = (byte[])smethod_69(object_3, (int)smethod_68(smethod_66(object_3)));
								goto case 74;
							case 74:
								array3 = new byte[32];
								num22 = 77;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 317:
								num25 = 84;
								goto case 93;
							case 93:
								array4[14] = (byte)num25;
								goto case 207;
							case 207:
								num25 = 124;
								num22 = 135;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 316:
								num24 = 108;
								goto case 228;
							case 228:
								array3[19] = (byte)num24;
								num23 = 309;
								goto case 309;
							case 309:
								num24 = 101;
								goto case 94;
							case 94:
								array3[19] = (byte)num24;
								goto case 89;
							case 89:
								num24 = 69;
								goto case 237;
							case 237:
								array3[19] = (byte)num24;
								goto case 109;
							case 109:
								num24 = 70;
								goto case 238;
							case 238:
								array3[20] = (byte)num24;
								num22 = 257;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 315:
								num24 = 95;
								num22 = 153;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 49;
							case 49:
								num24 = 133;
								num22 = 313;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 314:
								array3[5] = 129;
								goto case 260;
							case 260:
								num24 = 71;
								goto case 215;
							case 215:
								array3[5] = (byte)num24;
								goto case 129;
							case 129:
								num24 = 168;
								num22 = 227;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 313:
								array3[25] = (byte)num24;
								goto case 70;
							case 70:
								array3[25] = 193;
								goto case 208;
							case 208:
								num24 = 174;
								goto case 202;
							case 202:
								array3[25] = (byte)num24;
								num22 = 310;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 312:
								array3[14] = (byte)num24;
								num23 = 235;
								goto case 235;
							case 235:
								array3[15] = 177;
								goto case 46;
							case 46:
								array3[15] = 100;
								num22 = 8;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 10;
							case 10:
								num24 = 118;
								goto case 229;
							case 229:
								array3[15] = (byte)num24;
								num22 = 24;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 44;
							case 44:
								num24 = 56;
								num22 = 24;
								if (!smethod_98())
								{
									continue;
								}
								goto case 117;
							case 310:
								array3[25] = 140;
								num22 = 288;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 307:
								num25 = 48;
								goto case 299;
							case 299:
								array4[9] = (byte)num25;
								goto case 99;
							case 99:
								array4[10] = 125;
								num22 = 172;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 306:
								array3[20] = 231;
								goto case 32;
							case 32:
								num24 = 177;
								goto case 11;
							case 11:
								array3[21] = (byte)num24;
								goto case 88;
							case 88:
								num24 = 143;
								num22 = 55;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 305:
								array3[17] = 142;
								goto case 218;
							case 218:
								num24 = 163;
								num22 = 83;
								if (!smethod_98())
								{
									continue;
								}
								goto case 158;
							case 158:
								array3[17] = (byte)num24;
								goto case 3;
							case 3:
								array3[18] = 106;
								goto case 19;
							case 19:
								array3[18] = 73;
								num22 = 264;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 68;
							case 68:
								num24 = 93;
								num22 = 294;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 304:
								array3[24] = (byte)num24;
								num22 = 184;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 301;
							case 301:
								num24 = 45;
								goto case 35;
							case 35:
								array3[24] = (byte)num24;
								goto case 83;
							case 83:
								array3[24] = 163;
								goto case 156;
							case 156:
								num24 = 164;
								goto case 171;
							case 171:
								array3[24] = (byte)num24;
								goto case 49;
							case 303:
								num25 = 127;
								goto case 220;
							case 220:
								array4[11] = (byte)num25;
								goto case 71;
							case 71:
								array4[11] = 112;
								num22 = 138;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 302:
								array4[1] = (byte)num25;
								goto case 254;
							case 254:
								num25 = 103;
								goto case 224;
							case 224:
								array4[1] = (byte)num25;
								goto case 262;
							case 262:
								num25 = 105;
								goto case 59;
							case 59:
								array4[2] = (byte)num25;
								goto case 76;
							case 76:
								array4[2] = 150;
								num22 = 191;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 300:
								num25 = 68;
								num22 = 118;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 55;
							case 55:
								array3[21] = (byte)num24;
								goto case 64;
							case 64:
								array3[21] = 26;
								num22 = 78;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 298:
								array3[3] = 117;
								num22 = 230;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 45;
							case 45:
								array4[4] = (byte)num25;
								goto case 239;
							case 239:
								array4[4] = 98;
								goto case 266;
							case 266:
								array4[5] = 136;
								goto case 130;
							case 130:
								array4[5] = 135;
								goto case 276;
							case 276:
								num25 = 136;
								num23 = 223;
								goto case 223;
							case 223:
								array4[5] = (byte)num25;
								goto case 322;
							case 297:
								array4[9] = (byte)num25;
								goto case 277;
							case 277:
								num25 = 68;
								num22 = 203;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 295:
								array3[30] = 145;
								goto case 175;
							case 175:
								array3[30] = 148;
								goto case 47;
							case 47:
								array3[30] = 124;
								goto case 326;
							case 294:
								array3[11] = (byte)num24;
								num22 = 7;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 18;
							case 18:
								array3[11] = 116;
								goto case 141;
							case 141:
								array3[11] = 2;
								num22 = 95;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 240;
							case 240:
								array3[12] = 144;
								goto case 176;
							case 176:
								num24 = 138;
								goto case 248;
							case 248:
								array3[12] = (byte)num24;
								goto case 166;
							case 166:
								num24 = 160;
								num22 = 177;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 38;
							case 292:
								num24 = 99;
								goto case 101;
							case 101:
								array3[26] = (byte)num24;
								num22 = 214;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 291:
								array4[3] = (byte)num25;
								goto case 63;
							case 63:
								array4[3] = 98;
								num22 = 1;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 1;
							case 1:
								num25 = 22;
								num23 = 115;
								goto case 115;
							case 115:
								array4[3] = (byte)num25;
								num22 = 287;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 290:
								num24 = 98;
								num23 = 236;
								goto case 236;
							case 236:
								array3[31] = (byte)num24;
								num23 = 108;
								goto case 108;
							case 108:
								array3[31] = 90;
								goto case 28;
							case 28:
								array3[31] = 209;
								goto case 160;
							case 160:
								num24 = 94;
								num22 = 102;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 40;
							case 40:
								array4[4] = (byte)num25;
								goto case 244;
							case 244:
								num25 = 143;
								goto case 272;
							case 272:
								array4[4] = (byte)num25;
								num22 = 102;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 155;
							case 155:
								num25 = 138;
								num22 = 45;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 289:
								array3[6] = 103;
								num22 = 149;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 288:
								num24 = 39;
								goto case 26;
							case 26:
								array3[25] = (byte)num24;
								goto case 245;
							case 245:
								num24 = 112;
								goto case 273;
							case 273:
								array3[25] = (byte)num24;
								goto case 190;
							case 190:
								array3[26] = 101;
								num22 = 292;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 287:
								num25 = 122;
								num23 = 40;
								goto case 40;
							case 286:
								num24 = 77;
								num22 = 281;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 285:
								array3[7] = 209;
								goto case 6;
							case 6:
								array3[8] = 92;
								num22 = 150;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 117;
							case 283:
								array3[16] = (byte)num24;
								goto case 81;
							case 81:
								array3[16] = 169;
								num22 = 20;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 282:
								array4[14] = 128;
								goto case 323;
							case 281:
								array3[29] = (byte)num24;
								num22 = 295;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 280:
								array3[6] = (byte)num24;
								num23 = 66;
								goto case 66;
							case 66:
								array3[6] = 225;
								num22 = 13;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 279:
								array4[6] = 153;
								goto case 219;
							case 219:
								num25 = 109;
								num22 = 29;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 113;
							case 113:
								array4[6] = (byte)num25;
								num22 = 2;
								if (!smethod_98())
								{
									continue;
								}
								goto case 30;
							case 30:
								array4[6] = 154;
								num22 = 10;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 103;
							case 103:
								array4[6] = 164;
								num22 = 9;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 278:
								array3[2] = 57;
								goto case 189;
							case 189:
								array3[3] = 69;
								num22 = 188;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 184;
							case 184:
								array3[22] = 155;
								num22 = 0;
								if (smethod_99() != null)
								{
									continue;
								}
								goto default;
							default:
								array3[22] = 200;
								goto case 43;
							case 43:
								array3[23] = 68;
								goto case 114;
							case 114:
								array3[23] = 122;
								num22 = 34;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 275:
								array4[7] = 113;
								goto case 201;
							case 201:
								num25 = 117;
								goto case 205;
							case 205:
								array4[7] = (byte)num25;
								goto case 37;
							case 37:
								num25 = 90;
								goto case 142;
							case 142:
								array4[7] = (byte)num25;
								goto case 57;
							case 57:
								num25 = 113;
								goto case 24;
							case 24:
								array4[7] = (byte)num25;
								num22 = 105;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 274:
								array3[5] = (byte)num24;
								goto case 289;
							case 271:
								array4[1] = 184;
								num22 = 268;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 270:
								array3[14] = (byte)num24;
								goto case 133;
							case 133:
								num24 = 113;
								num22 = 86;
								if (smethod_98())
								{
									continue;
								}
								goto case 6;
							case 269:
								array3[10] = 143;
								goto case 56;
							case 56:
								array3[10] = 60;
								goto case 27;
							case 27:
								num24 = 185;
								goto case 249;
							case 249:
								array3[10] = (byte)num24;
								num22 = 315;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 268:
								num25 = 181;
								num23 = 302;
								goto case 302;
							case 267:
								smethod_71(object_6, CipherMode.CBC);
								num23 = 162;
								goto case 162;
							case 162:
								transform = (ICryptoTransform)smethod_72(object_6, object_7, object_5);
								goto case 319;
							case 265:
								array3[29] = 128;
								goto case 252;
							case 252:
								num24 = 135;
								goto case 210;
							case 210:
								array3[29] = (byte)num24;
								goto case 286;
							case 264:
								array3[18] = 134;
								num22 = 316;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 160;
							case 261:
								num24 = 118;
								goto case 95;
							case 95:
								array3[8] = (byte)num24;
								goto case 58;
							case 58:
								num24 = 55;
								goto case 182;
							case 182:
								array3[8] = (byte)num24;
								goto case 321;
							case 259:
								array3[9] = 94;
								goto case 100;
							case 100:
								array3[9] = 94;
								goto case 324;
							case 258:
								array3[27] = (byte)num24;
								num22 = 4;
								if (smethod_98())
								{
									continue;
								}
								goto case 3;
							case 257:
								array3[20] = 115;
								num23 = 14;
								goto case 14;
							case 14:
								array3[20] = 91;
								goto case 112;
							case 112:
								array3[20] = 93;
								num22 = 179;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 253:
								array3[2] = (byte)num24;
								num23 = 278;
								goto case 278;
							case 251:
								array3[27] = (byte)num24;
								goto case 181;
							case 181:
								array3[27] = 118;
								num23 = 152;
								goto case 152;
							case 152:
								num24 = 89;
								goto case 157;
							case 157:
								array3[28] = (byte)num24;
								goto case 51;
							case 51:
								array3[28] = 114;
								num22 = 79;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 250:
								array3[28] = 169;
								num22 = 213;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 247:
								num24 = 140;
								num22 = 2;
								if (!smethod_98())
								{
									continue;
								}
								goto case 5;
							case 5:
								array3[4] = (byte)num24;
								goto case 185;
							case 185:
								array3[4] = 171;
								goto case 314;
							case 246:
								array3[27] = 191;
								goto case 107;
							case 107:
								array3[27] = 117;
								num22 = 200;
								if (smethod_98())
								{
									continue;
								}
								goto case 8;
							case 242:
								num24 = 114;
								goto case 329;
							case 241:
								array3[1] = 184;
								goto case 73;
							case 234:
								array3[28] = (byte)num24;
								num22 = 265;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 233:
								array4[8] = 153;
								num22 = 146;
								if (smethod_98())
								{
									continue;
								}
								goto case 39;
							case 39:
								array3[28] = (byte)num24;
								num22 = 147;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 231:
								array3[4] = (byte)num24;
								goto case 247;
							case 230:
								array3[3] = 179;
								num22 = 25;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 227:
								array3[5] = (byte)num24;
								num22 = 50;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 226:
								array4[0] = (byte)num25;
								num22 = 211;
								if (!smethod_98())
								{
									continue;
								}
								goto case 328;
							case 225:
								num24 = 50;
								goto case 111;
							case 111:
								array3[17] = (byte)num24;
								num22 = 305;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 222:
								array3[6] = (byte)num24;
								goto case 169;
							case 169:
								num24 = 213;
								num22 = 280;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 221:
								num25 = 136;
								num22 = 53;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 217:
								array3[14] = (byte)num24;
								goto case 174;
							case 174:
								array3[14] = 144;
								goto case 122;
							case 122:
								num24 = 7;
								goto case 312;
							case 216:
								num24 = 154;
								goto case 125;
							case 125:
								array3[13] = (byte)num24;
								goto case 134;
							case 134:
								num24 = 85;
								num22 = 60;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 214:
								array3[26] = 47;
								goto case 33;
							case 33:
								array3[27] = 152;
								num22 = 246;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 213:
								num24 = 103;
								num22 = 39;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 212:
								array3[31] = 0;
								num23 = 330;
								goto case 330;
							case 211:
								num25 = 47;
								num22 = 61;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 209:
								array4[6] = (byte)num25;
								num22 = 217;
								if (!smethod_98())
								{
									continue;
								}
								goto case 275;
							case 206:
								num24 = 135;
								num23 = 231;
								goto case 231;
							case 204:
								array3[13] = 199;
								goto case 178;
							case 178:
								array3[14] = 155;
								num22 = 27;
								if (!smethod_98())
								{
									continue;
								}
								goto case 98;
							case 98:
								num24 = 184;
								num22 = 270;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 203:
								array4[9] = (byte)num25;
								num22 = 300;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 200:
								num24 = 6;
								num22 = 258;
								if (smethod_98())
								{
									continue;
								}
								goto case 153;
							case 153:
								array3[10] = (byte)num24;
								goto case 68;
							case 199:
								num24 = 112;
								goto case 253;
							case 198:
								array3[22] = (byte)num24;
								num22 = 16;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 196:
								array3[13] = (byte)num24;
								goto case 216;
							case 194:
								array3[9] = (byte)num24;
								goto case 259;
							case 191:
								array4[2] = 119;
								num22 = 331;
								if (smethod_98())
								{
									continue;
								}
								goto case 20;
							case 20:
								array3[17] = 178;
								goto case 225;
							case 188:
								array3[3] = 131;
								num22 = 131;
								if (smethod_98())
								{
									continue;
								}
								goto case 91;
							case 91:
								object_5 = array4;
								goto case 126;
							case 126:
								object_6 = (SymmetricAlgorithm)smethod_70();
								goto case 267;
							case 187:
								array3[1] = (byte)num24;
								num22 = 72;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 56;
							case 186:
								array3[12] = 27;
								num23 = 80;
								goto case 80;
							case 80:
								array3[13] = 168;
								num22 = 164;
								if (smethod_98())
								{
									continue;
								}
								goto case 91;
							case 179:
								array3[20] = 131;
								num22 = 291;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 306;
							case 177:
								array3[12] = (byte)num24;
								goto case 92;
							case 92:
								num24 = 86;
								num22 = 85;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 173:
								num24 = 114;
								goto case 198;
							case 172:
								array4[10] = 94;
								num22 = 140;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 14;
							case 170:
								array4[13] = 156;
								goto case 325;
							case 168:
								array4[5] = 58;
								goto case 279;
							case 167:
								array3[7] = (byte)num24;
								goto case 285;
							case 165:
								array3[0] = 155;
								goto case 145;
							case 145:
								num24 = 105;
								num22 = 319;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 327;
							case 164:
								num24 = 123;
								goto case 196;
							case 163:
								array4[13] = 164;
								num22 = 170;
								if (smethod_98())
								{
									continue;
								}
								goto case 145;
							case 159:
								array4[14] = 126;
								num22 = 270;
								if (!smethod_98())
								{
									continue;
								}
								goto case 282;
							case 150:
								array3[8] = 89;
								num22 = 87;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 149:
								num24 = 192;
								num22 = 222;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 148:
								num25 = 10;
								num22 = 120;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 147:
								num24 = 193;
								goto case 234;
							case 146:
								num25 = 166;
								goto case 297;
							case 143:
								num24 = 86;
								goto case 194;
							case 140:
								array4[10] = 143;
								goto case 148;
							case 138:
								array4[11] = 168;
								num22 = 106;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 103;
							case 137:
								array4[12] = 37;
								goto case 163;
							case 136:
								array4[9] = 25;
								num22 = 307;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 124;
							case 124:
								num24 = 94;
								num22 = 67;
								if (smethod_98())
								{
									continue;
								}
								goto case 18;
							case 135:
								array4[14] = (byte)num25;
								goto case 159;
							case 132:
								array3[22] = 150;
								num23 = 184;
								goto case 184;
							case 131:
								array3[3] = 143;
								num22 = 5;
								if (!smethod_98())
								{
									continue;
								}
								goto case 298;
							case 127:
								num24 = 117;
								num23 = 167;
								goto case 167;
							case 123:
								array4[15] = (byte)num25;
								num22 = 320;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 120:
								array4[10] = (byte)num25;
								goto case 303;
							case 119:
								num24 = 118;
								goto case 41;
							case 41:
								array3[12] = (byte)num24;
								goto case 186;
							case 118:
								array4[9] = (byte)num25;
								goto case 221;
							case 106:
								array4[12] = 93;
								num22 = 36;
								if (smethod_98())
								{
									continue;
								}
								break;
							case 105:
								array4[8] = 154;
								goto case 96;
							case 96:
								array4[8] = 142;
								goto case 233;
							case 104:
								array3[9] = (byte)num24;
								num22 = 124;
								if (smethod_98())
								{
									continue;
								}
								goto case 48;
							case 48:
								array3[28] = (byte)num24;
								goto case 250;
							case 102:
								array3[31] = (byte)num24;
								num22 = 212;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 97:
								array4[13] = 174;
								goto case 317;
							case 90:
								num24 = 117;
								num22 = 283;
								if (smethod_98())
								{
									continue;
								}
								goto case 271;
							case 87:
								array3[8] = 113;
								goto case 261;
							case 86:
								array3[14] = (byte)num24;
								goto case 31;
							case 31:
								num24 = 88;
								num22 = 217;
								if (smethod_98())
								{
									continue;
								}
								goto case 22;
							case 85:
								array3[12] = (byte)num24;
								num22 = 119;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 84:
								array3[7] = (byte)num24;
								num22 = 127;
								if (smethod_99() == null)
								{
									continue;
								}
								goto case 71;
							case 79:
								num24 = 127;
								goto case 48;
							case 78:
								array3[22] = 118;
								num23 = 173;
								goto case 173;
							case 77:
								num24 = 92;
								num22 = 54;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 72:
								array3[1] = 100;
								num22 = 115;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 241;
							case 67:
								array3[10] = (byte)num24;
								goto case 269;
							case 61:
								array4[15] = (byte)num25;
								num22 = 91;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 60:
								array3[13] = (byte)num24;
								goto case 204;
							case 54:
								array3[0] = (byte)num24;
								num22 = 165;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 53:
								array4[9] = (byte)num25;
								goto case 136;
							case 50:
								num24 = 112;
								goto case 274;
							case 36:
								array4[12] = 134;
								num22 = 137;
								if (smethod_98())
								{
									continue;
								}
								goto case 100;
							case 34:
								array3[23] = 241;
								num22 = 12;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 29:
								array4[13] = (byte)num25;
								num22 = 55;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 97;
							case 25:
								num24 = 149;
								num23 = 21;
								goto case 21;
							case 21:
								array3[4] = (byte)num24;
								goto case 206;
							case 17:
								num24 = 150;
								goto case 187;
							case 16:
								array3[22] = 169;
								num22 = 77;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 132;
							case 15:
								array3[16] = (byte)num24;
								num22 = 57;
								if (smethod_99() != null)
								{
									continue;
								}
								goto case 90;
							case 13:
								num24 = 111;
								goto case 84;
							case 12:
								num24 = 97;
								num22 = 304;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 9:
								num25 = 175;
								goto case 209;
							case 4:
								num24 = 105;
								num22 = 251;
								if (smethod_99() == null)
								{
									continue;
								}
								break;
							case 197:
								smethod_75(object_4);
								goto case 42;
							case 42:
								smethod_79(object_8, smethod_78(smethod_76(), smethod_77(stream)));
								goto case 263;
							case 263:
								smethod_80(stream);
								num23 = 293;
								goto case 293;
							case 293:
								smethod_80(object_4);
								goto case 161;
							case 161:
								smethod_81(object_3);
								goto end_IL_1b75;
							case 311:
								goto end_IL_1b75;
							}
							goto IL_00f6;
							continue;
							end_IL_1b75:
							break;
						}
						goto end_IL_0087;
						IL_00f6:
						num22 = num23;
						goto IL_1b75;
						end_IL_0087:;
					}
					catch
					{
						int num26 = 0;
						if (smethod_98())
						{
							goto IL_2104;
						}
						goto IL_2121;
						IL_2104:
						while (true)
						{
							switch (num26)
							{
							case 1:
								goto end_IL_2104;
							}
							flag2 = true;
							num26 = 1;
							if (smethod_98())
							{
								continue;
							}
							goto IL_2121;
							continue;
							end_IL_2104:
							break;
						}
						goto end_IL_20f4;
						IL_2121:
						num26 = num27;
						goto IL_2104;
						end_IL_20f4:;
					}
					goto IL_27eb;
					IL_27eb:
					if (!flag2)
					{
						num2 = 11;
						if (smethod_99() != null)
						{
							num2 = num;
						}
						goto IL_002d;
					}
					goto IL_27f2;
					IL_27f2:
					if (!flag2)
					{
						flag2 = false;
						num2 = 5;
						if (smethod_99() == null)
						{
							return;
						}
						goto IL_002d;
					}
					num = 13;
					goto IL_280e;
				}
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
				lock (object_10)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(Class26.smethod_0(33554491)).Assembly.GetManifestResourceStream("2\u009b91t8\u0091\u0087\u009esg\u0092oc\u0091\u0097\u009b1.6n3\u00914f\u0092re\u009f7u\u009f\u0096r2sm"));
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
							num10 += 386210582;
							num10 ^= num10 >> 27;
							num10 += 2785290990u;
							num10 ^= num10 << 27;
							num10 += 3921027779u;
							num10 = 593091361 - num10;
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
						Class24 @class = new Class24(new MemoryStream(array));
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
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(Class26.smethod_0(33554491)).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(Class26.smethod_0(16777238));
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

	[Attribute0(typeof(Attribute0.Class22<object>[]))]
	internal static string smethod_16(int int_4)
	{
		int num = 120;
		uint num6 = default(uint);
		int num15 = default(int);
		int num20 = default(int);
		byte[] array3 = default(byte[]);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num21 = default(int);
		int num16 = default(int);
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num9 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		int num10 = default(int);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		int num13 = default(int);
		byte[] array7 = default(byte[]);
		byte[] array4 = default(byte[]);
		uint num4 = default(uint);
		uint num14 = default(uint);
		uint num22 = default(uint);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		uint num7 = default(uint);
		int num24 = default(int);
		int num12 = default(int);
		uint num23 = default(uint);
		uint num11 = default(uint);
		int num8 = default(int);
		uint num17 = default(uint);
		ICryptoTransform transform = default(ICryptoTransform);
		Class24 object_ = default(Class24);
		int int_5 = default(int);
		int num26 = default(int);
		string result = default(string);
		while (true)
		{
			int num2;
			if (((Array)object_6).Length == 0)
			{
				num2 = 119;
				if (!smethod_55())
				{
					goto IL_00b3;
				}
				goto IL_206a;
			}
			goto IL_26c4;
			IL_00b3:
			num2 = num;
			goto IL_206a;
			IL_206a:
			while (true)
			{
				switch (num2)
				{
				case 400:
					num6 = 0u;
					goto case 106;
				case 106:
					num15 = 0;
					num = 68;
					goto case 68;
				case 68:
				case 137:
					if (num15 >= num20)
					{
						goto case 47;
					}
					goto case 135;
				case 47:
					object_6 = array3;
					num2 = 314;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 57;
				case 57:
					array2[25] = 180;
					num = 157;
					goto case 157;
				case 157:
					num5 = 229;
					goto case 121;
				case 121:
					array2[26] = (byte)num5;
					num2 = 276;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 135:
					num21 = num15 % num16;
					goto case 299;
				case 299:
					num3 = num15 * 4;
					goto case 384;
				case 384:
					num6 = (uint)(num21 * 4);
					num2 = 42;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 399:
					array[13] = 140;
					num2 = 44;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 133;
				case 133:
					array[13] = 135;
					goto case 360;
				case 360:
					num9 = 76;
					goto case 219;
				case 219:
					array[13] = (byte)num9;
					num2 = 1;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 398:
					array5[5] = array6[2];
					num2 = 370;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 397:
					array[12] = (byte)num9;
					num2 = 237;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 212;
				case 212:
					array[6] = (byte)num9;
					goto case 214;
				case 214:
					num9 = 86;
					goto case 73;
				case 73:
					array[6] = (byte)num9;
					num2 = 239;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 165:
				case 396:
					if (num10 >= array5.Length)
					{
						goto case 293;
					}
					goto case 227;
				case 293:
					if (int_4 == -1)
					{
						goto case 155;
					}
					goto case 223;
				case 155:
					object_3 = (SymmetricAlgorithm)smethod_43();
					num2 = 290;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 223:
					num13 = array7.Length % 4;
					goto case 328;
				case 328:
					num20 = array7.Length / 4;
					num = 302;
					goto case 302;
				case 302:
					array3 = new byte[array7.Length];
					num2 = 286;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 227:
					array4[num10] = (byte)(array4[num10] ^ array5[num10]);
					num2 = 74;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 56;
				case 56:
					array2[24] = (byte)num5;
					goto case 365;
				case 365:
					array2[24] = 144;
					goto case 381;
				case 381:
					array2[25] = 169;
					num2 = 183;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 395:
					array2[6] = (byte)num5;
					num2 = 88;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 394:
					array2[31] = (byte)num5;
					goto case 26;
				case 26:
					array2[31] = 138;
					num2 = 148;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 393:
					array[4] = 117;
					goto case 176;
				case 176:
					array[4] = 180;
					num2 = 46;
					if (!smethod_55())
					{
						continue;
					}
					goto case 309;
				case 309:
					num9 = 126;
					goto case 252;
				case 252:
					array[5] = (byte)num9;
					num2 = 199;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 392:
					array2[17] = (byte)num5;
					goto case 61;
				case 61:
					num5 = 94;
					goto case 140;
				case 140:
					array2[17] = (byte)num5;
					num2 = 27;
					if (!smethod_55())
					{
						continue;
					}
					goto case 40;
				case 40:
					num5 = 129;
					goto case 14;
				case 14:
					array2[17] = (byte)num5;
					goto case 246;
				case 246:
					num5 = 155;
					num2 = 144;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 391:
					array2[27] = 69;
					goto case 312;
				case 312:
					num5 = 223;
					num2 = 51;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 390:
					num5 = 128;
					num2 = 297;
					if (smethod_55())
					{
						continue;
					}
					goto case 148;
				case 148:
					array2[31] = 164;
					goto case 351;
				case 351:
					array2[31] = 67;
					num2 = 125;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 389:
					num4 = num14 ^ num22;
					num2 = 21;
					if (smethod_55())
					{
						continue;
					}
					goto case 10;
				case 10:
					array[7] = (byte)num9;
					goto case 96;
				case 96:
					array[8] = 153;
					num2 = 202;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 388:
					array2[19] = (byte)num5;
					goto case 49;
				case 49:
					array2[19] = 125;
					goto case 353;
				case 353:
					num5 = 212;
					goto case 249;
				case 249:
					array2[19] = (byte)num5;
					goto case 32;
				case 32:
					num5 = 158;
					goto case 306;
				case 306:
					array2[19] = (byte)num5;
					goto case 200;
				case 200:
					num5 = 219;
					num = 186;
					goto case 186;
				case 186:
					array2[20] = (byte)num5;
					goto case 2;
				case 2:
					num5 = 72;
					goto case 65;
				case 65:
					array2[20] = (byte)num5;
					num2 = 235;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 387:
					array2[0] = 94;
					goto case 118;
				case 118:
					array2[0] = 117;
					num2 = 138;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 386:
					object_6 = smethod_49(stream);
					goto case 325;
				case 325:
					smethod_50(stream);
					goto case 240;
				case 240:
					smethod_50(object_2);
					goto case 112;
				case 112:
					array7 = (byte[])object_6;
					goto case 223;
				case 385:
					array2[13] = (byte)num5;
					goto case 333;
				case 333:
					array2[14] = 156;
					num2 = 188;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 383:
					if (array6.Length > 0)
					{
						goto case 338;
					}
					goto case 12;
				case 338:
					array5[1] = array6[0];
					num2 = 142;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 12:
					num10 = 0;
					goto case 165;
				case 382:
					array2[4] = 132;
					goto case 317;
				case 317:
					array2[4] = 162;
					goto case 123;
				case 123:
					array2[4] = 81;
					num2 = 18;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 380:
					array2[14] = (byte)num5;
					goto case 274;
				case 274:
					array2[14] = 244;
					num2 = 98;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 379:
					array2[5] = (byte)num5;
					goto case 50;
				case 50:
					num5 = 154;
					goto case 266;
				case 266:
					array2[5] = (byte)num5;
					goto case 13;
				case 13:
					array2[5] = 64;
					goto case 376;
				case 376:
					num5 = 128;
					goto case 395;
				case 378:
					array2[7] = (byte)num5;
					goto case 313;
				case 313:
					array2[7] = 46;
					num2 = 166;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 319;
				case 319:
					num5 = 136;
					num2 = 78;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 258;
				case 258:
					array2[7] = (byte)num5;
					goto case 163;
				case 163:
					num5 = 153;
					goto case 100;
				case 100:
					array2[8] = (byte)num5;
					num2 = 160;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 377:
					array2[15] = 160;
					goto case 194;
				case 194:
					array2[15] = 161;
					goto case 323;
				case 323:
					num5 = 223;
					goto case 352;
				case 352:
					array2[15] = (byte)num5;
					num2 = 331;
					if (!smethod_55())
					{
						continue;
					}
					goto case 359;
				case 359:
					num5 = 214;
					goto case 243;
				case 243:
					array2[15] = (byte)num5;
					num = 166;
					goto case 166;
				case 166:
					array2[15] = 82;
					goto case 8;
				case 8:
					num5 = 94;
					goto case 371;
				case 371:
					array2[16] = (byte)num5;
					num2 = 146;
					if (smethod_55())
					{
						continue;
					}
					goto case 13;
				case 375:
					array[5] = 20;
					goto case 60;
				case 60:
					array[6] = 149;
					num2 = 107;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 374:
					num5 = 150;
					goto case 151;
				case 151:
					array2[0] = (byte)num5;
					goto case 53;
				case 53:
					num5 = 147;
					goto case 114;
				case 114:
					array2[0] = (byte)num5;
					goto case 387;
				case 373:
					array[9] = (byte)num9;
					goto case 303;
				case 303:
					num9 = 121;
					num2 = 320;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 372:
					array2[9] = 72;
					goto case 150;
				case 150:
					array2[10] = 166;
					num2 = 62;
					if (!smethod_55())
					{
						continue;
					}
					goto case 363;
				case 363:
					array2[10] = 102;
					num = 364;
					goto case 364;
				case 364:
					array2[10] = 58;
					goto case 19;
				case 19:
					num5 = 118;
					num2 = 171;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 370:
					array5[7] = array6[3];
					goto case 277;
				case 277:
					array5[9] = array6[4];
					goto case 17;
				case 17:
					array5[11] = array6[5];
					goto case 225;
				case 225:
					array5[13] = array6[6];
					num = 324;
					goto case 324;
				case 324:
					array5[15] = array6[7];
					goto case 12;
				case 369:
					array[14] = (byte)num9;
					num2 = 115;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 368:
					array2[9] = (byte)num5;
					num2 = 143;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 372;
				case 367:
					num14 += num7;
					num2 = 132;
					if (smethod_55())
					{
						continue;
					}
					goto case 97;
				case 97:
					array2[29] = 120;
					goto case 213;
				case 213:
					num5 = 155;
					num2 = 247;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 366:
					num24 += 8;
					goto case 52;
				case 52:
					array3[num3 + num12] = (byte)((num23 & num11) >> num24);
					goto case 221;
				case 221:
					num12++;
					num2 = 3;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 1;
				case 1:
					num9 = 146;
					num2 = 12;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 340;
				case 340:
					array[14] = (byte)num9;
					num2 = 24;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 362:
					array[2] = 38;
					num2 = 0;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 361:
					array[1] = 34;
					num2 = 287;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 358:
					array[3] = 56;
					goto case 89;
				case 89:
					array[3] = 91;
					goto case 229;
				case 229:
					num9 = 104;
					num2 = 101;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 357:
					array2[4] = 242;
					num2 = 256;
					if (!smethod_55())
					{
						continue;
					}
					goto case 339;
				case 339:
					num5 = 163;
					num2 = 379;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 356:
					array2[1] = 199;
					goto case 70;
				case 70:
					num5 = 59;
					goto case 161;
				case 161:
					array2[1] = (byte)num5;
					goto case 264;
				case 264:
					array2[2] = 54;
					num2 = 115;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 145;
				case 145:
					array2[2] = 152;
					num2 = 104;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 127;
				case 127:
					array2[2] = 245;
					num = 164;
					goto case 164;
				case 164:
					array2[3] = 23;
					num = 29;
					goto case 29;
				case 29:
					array2[3] = 160;
					goto case 69;
				case 69:
					num5 = 52;
					goto case 269;
				case 269:
					array2[3] = (byte)num5;
					num = 382;
					goto case 382;
				case 355:
					num5 = 112;
					goto case 272;
				case 272:
					array2[9] = (byte)num5;
					goto case 230;
				case 230:
					num5 = 176;
					num2 = 368;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 354:
					array2[16] = (byte)num5;
					goto case 181;
				case 181:
					num5 = 182;
					goto case 11;
				case 11:
					array2[16] = (byte)num5;
					num2 = 308;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 350:
					array2[28] = 50;
					num = 66;
					goto case 66;
				case 66:
					num5 = 151;
					num = 131;
					goto case 131;
				case 131:
					array2[28] = (byte)num5;
					num2 = 32;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 315;
				case 315:
					array2[28] = 163;
					num2 = 182;
					if (!smethod_55())
					{
						continue;
					}
					goto case 211;
				case 211:
					num5 = 88;
					goto case 311;
				case 311:
					array2[28] = (byte)num5;
					goto case 97;
				case 349:
					num5 = 141;
					goto case 336;
				case 336:
					array2[11] = (byte)num5;
					num2 = 177;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 348:
					num24 = 0;
					goto case 296;
				case 296:
					if (num15 == num20 - 1)
					{
						num2 = 292;
						if (smethod_56() == null)
						{
							continue;
						}
						goto IL_00b3;
					}
					goto case 367;
				case 347:
					array[10] = (byte)num9;
					goto case 78;
				case 78:
					array[11] = 141;
					num2 = 6;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 346:
					num5 = 71;
					num = 380;
					goto case 380;
				case 345:
					num5 = 84;
					num2 = 14;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 90;
				case 90:
					array2[12] = (byte)num5;
					goto case 75;
				case 75:
					num5 = 217;
					goto case 48;
				case 48:
					array2[12] = (byte)num5;
					goto case 342;
				case 342:
					num5 = 85;
					goto case 253;
				case 253:
					array2[13] = (byte)num5;
					num = 245;
					goto case 245;
				case 245:
					array2[13] = 104;
					num = 234;
					goto case 234;
				case 234:
					num5 = 62;
					goto case 385;
				case 344:
					num5 = 191;
					goto case 217;
				case 217:
					array2[23] = (byte)num5;
					num2 = 291;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 343:
					num9 = 154;
					goto case 275;
				case 275:
					array[11] = (byte)num9;
					goto case 322;
				case 322:
					num9 = 141;
					goto case 280;
				case 280:
					array[12] = (byte)num9;
					num = 162;
					goto case 162;
				case 162:
					num9 = 38;
					num2 = 397;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 341:
					num22 <<= 8;
					goto case 59;
				case 59:
					num22 |= array7[^(1 + num8)];
					num2 = 44;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 337:
					num23 = num14 ^ num22;
					num2 = 95;
					if (smethod_55())
					{
						continue;
					}
					goto case 77;
				case 77:
					array2[21] = 124;
					goto case 64;
				case 64:
					array2[21] = 102;
					goto case 260;
				case 260:
					num5 = 241;
					num2 = 27;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 20;
				case 20:
					num22 = 0u;
					goto case 4;
				case 4:
					if (num13 <= 0)
					{
						goto case 400;
					}
					goto case 216;
				case 216:
					num20++;
					num = 400;
					goto case 400;
				case 335:
					num22 = (uint)((array7[num6 + 3] << 24) | (array7[num6 + 2] << 16) | (array7[num6 + 1] << 8) | array7[num6]);
					num2 = 124;
					if (!smethod_55())
					{
						continue;
					}
					goto case 36;
				case 36:
				case 257:
					num17 = num14;
					num2 = 203;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 334:
					array2[14] = (byte)num5;
					goto case 346;
				case 332:
					array2[11] = (byte)num5;
					num2 = 82;
					if (!smethod_55())
					{
						continue;
					}
					goto case 316;
				case 316:
					array2[11] = 198;
					num2 = 331;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 331:
					num5 = 107;
					goto case 63;
				case 63:
					array2[12] = (byte)num5;
					goto case 128;
				case 128:
					array2[12] = 138;
					goto case 345;
				case 330:
					num9 = 140;
					num2 = 271;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 329:
					if (num12 > 0)
					{
						num2 = 152;
						if (smethod_56() == null)
						{
							continue;
						}
						goto IL_00b3;
					}
					goto case 52;
				case 327:
					num5 = 90;
					goto case 388;
				case 326:
					num22 = 0u;
					num2 = 273;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 321:
					num9 = 88;
					goto case 373;
				case 320:
					array[9] = (byte)num9;
					num2 = 122;
					if (smethod_55())
					{
						continue;
					}
					goto case 103;
				case 103:
					array[7] = 146;
					num2 = 103;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 261;
				case 261:
					array[7] = 142;
					num2 = 62;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 318:
					transform = (ICryptoTransform)smethod_45(object_3, array4, array5);
					num2 = 147;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 310:
					array2[20] = 89;
					goto case 35;
				case 35:
					num5 = 123;
					num = 158;
					goto case 158;
				case 158:
					array2[21] = (byte)num5;
					goto case 33;
				case 33:
					array2[21] = 40;
					num2 = 37;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 77;
				case 308:
					num5 = 133;
					goto case 38;
				case 38:
					array2[16] = (byte)num5;
					num2 = 34;
					if (smethod_55())
					{
						continue;
					}
					goto case 9;
				case 9:
					array2[15] = (byte)num5;
					num2 = 377;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 307:
					num7 = 0u;
					goto case 20;
				case 304:
					num9 = 150;
					goto case 197;
				case 197:
					array[0] = (byte)num9;
					goto case 238;
				case 238:
					array[0] = 117;
					goto case 45;
				case 45:
					num9 = 141;
					num2 = 139;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 301:
					array[15] = (byte)num9;
					num2 = 209;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 300:
				{
					uint num18 = num17;
					uint num19 = num17;
					num19 ^= num19 << 1;
					num19 += 386210582;
					num19 ^= num19 >> 27;
					num19 += 2785290990u;
					num19 ^= num19 << 27;
					num19 += 3921027779u;
					num19 = 593091361 - num19;
					num17 = num18 + (uint)(double)num19;
					num2 = 28;
					if (!smethod_55())
					{
						continue;
					}
					goto case 55;
				}
				case 55:
					num14 = num17;
					goto case 180;
				case 180:
					if (num15 == num20 - 1)
					{
						num2 = 222;
						if (smethod_56() == null)
						{
							continue;
						}
						goto IL_00b3;
					}
					goto case 389;
				case 298:
					array[0] = (byte)num9;
					goto case 54;
				case 54:
					array[0] = 135;
					goto case 330;
				case 297:
					array2[27] = (byte)num5;
					num2 = 350;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 295:
					array[12] = 50;
					num2 = 399;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 294:
					array2[30] = 117;
					goto case 149;
				case 149:
					num5 = 100;
					num2 = 394;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 292:
					if (num13 <= 0)
					{
						goto case 367;
					}
					num2 = 250;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 326;
				case 291:
					num5 = 125;
					goto case 206;
				case 206:
					array2[23] = (byte)num5;
					num2 = 22;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 290:
					smethod_44(object_3, CipherMode.CBC);
					num = 318;
					goto case 318;
				case 289:
					array[15] = (byte)num9;
					num2 = 15;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 288:
					array2[23] = 58;
					num2 = 344;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 87;
				case 87:
					array2[1] = (byte)num5;
					num = 175;
					goto case 175;
				case 175:
					array2[1] = 133;
					goto case 208;
				case 208:
					num5 = 99;
					num = 283;
					goto case 283;
				case 283:
					array2[1] = (byte)num5;
					num2 = 356;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 287:
					num9 = 138;
					num = 134;
					goto case 134;
				case 134:
					array[2] = (byte)num9;
					goto case 25;
				case 25:
					array[2] = 139;
					num2 = 362;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 286:
					num16 = array4.Length / 4;
					num2 = 187;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 285:
					num9 = 214;
					goto case 23;
				case 23:
					array[15] = (byte)num9;
					num2 = 179;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 284:
					array2[23] = 162;
					num = 288;
					goto case 288;
				case 282:
					array[12] = (byte)num9;
					goto case 159;
				case 159:
					array[12] = 122;
					num2 = 295;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 281:
					array2[18] = 147;
					num2 = 201;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 279:
					array7 = (byte[])smethod_38(object_, (int)smethod_37(smethod_35(object_)));
					goto case 30;
				case 30:
					smethod_39(object_);
					goto case 99;
				case 99:
					array2 = new byte[32];
					num = 374;
					goto case 374;
				case 278:
					num9 = 161;
					num2 = 289;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 276:
					num5 = 138;
					goto case 124;
				case 124:
					array2[26] = (byte)num5;
					num2 = 170;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 273:
					num14 += num7;
					num2 = 103;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 191;
				case 191:
					num8 = 0;
					goto case 105;
				case 105:
				case 169:
					if (num8 >= num13)
					{
						num = 36;
						goto case 36;
					}
					goto case 116;
				case 116:
					if (num8 > 0)
					{
						num2 = 341;
						if (smethod_55())
						{
							continue;
						}
						goto IL_00b3;
					}
					goto case 59;
				case 271:
					array[1] = (byte)num9;
					goto case 5;
				case 5:
					array[1] = 162;
					num2 = 361;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 270:
					array2[27] = 138;
					num2 = 390;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 268:
					array3[num3 + 3] = (byte)((num4 & 0xFF000000u) >> 24);
					goto case 82;
				case 82:
				case 220:
					num15++;
					goto case 68;
				case 267:
					num9 = 167;
					goto case 198;
				case 198:
					array[3] = (byte)num9;
					goto case 7;
				case 7:
					array[3] = 193;
					goto case 358;
				case 265:
					num9 = 125;
					num2 = 108;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 298;
				case 263:
					array2[20] = (byte)num5;
					num = 310;
					goto case 310;
				case 262:
					num5 = 130;
					num2 = 140;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 334;
				case 259:
					num5 = 84;
					goto case 16;
				case 16:
					array2[27] = (byte)num5;
					num2 = 184;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 256:
					num9 = 167;
					num2 = 212;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 255:
					array2[22] = (byte)num5;
					goto case 192;
				case 192:
					array2[22] = 124;
					goto case 58;
				case 58:
					array2[22] = 84;
					num2 = 117;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 254:
					num9 = 138;
					num2 = 168;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 117;
				case 117:
					array2[23] = 118;
					goto case 284;
				case 251:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num = 196;
					goto case 196;
				case 196:
					smethod_47(object_2, array7, 0, array7.Length);
					goto case 72;
				case 72:
					smethod_48(object_2);
					num2 = 283;
					if (!smethod_55())
					{
						continue;
					}
					goto case 386;
				case 250:
					smethod_40(array5);
					goto case 205;
				case 205:
					array6 = (byte[])smethod_42(smethod_41(object_5));
					goto case 215;
				case 215:
					if (array6 != null)
					{
						goto case 383;
					}
					goto case 12;
				case 248:
					num5 = 146;
					num2 = 255;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 247:
					array2[29] = (byte)num5;
					num2 = 81;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 244:
					array2[8] = 187;
					num2 = 112;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 226;
				case 226:
					num5 = 98;
					num2 = 102;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 242:
					array2[30] = 164;
					goto case 110;
				case 110:
					array2[30] = 153;
					goto case 294;
				case 241:
					num5 = 164;
					goto case 172;
				case 172:
					array2[24] = (byte)num5;
					num2 = 189;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 239:
					array[7] = 160;
					goto case 103;
				case 237:
					array[12] = 116;
					goto case 218;
				case 218:
					num9 = 92;
					goto case 282;
				case 236:
					num5 = 138;
					goto case 31;
				case 31:
					array2[18] = (byte)num5;
					num2 = 281;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 235:
					num5 = 165;
					goto case 263;
				case 233:
					array2[6] = 237;
					num2 = 5;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 67;
				case 67:
					num5 = 162;
					goto case 378;
				case 232:
					num5 = 194;
					num = 129;
					goto case 129;
				case 129:
					array2[18] = (byte)num5;
					goto case 224;
				case 224:
					array2[18] = 157;
					num2 = 236;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 231:
					num9 = 187;
					goto case 369;
				case 228:
					array[14] = 161;
					goto case 254;
				case 222:
					if (num13 <= 0)
					{
						goto case 389;
					}
					goto case 337;
				case 210:
					array = new byte[16];
					goto case 304;
				case 209:
					array[15] = 160;
					num2 = 278;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 207:
					array[14] = 74;
					goto case 231;
				case 204:
					array3[num3 + 2] = (byte)((num4 & 0xFF0000) >> 16);
					goto case 268;
				case 203:
					num14 = 0u;
					goto case 300;
				case 202:
					array[8] = 144;
					num2 = 173;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 201:
					array2[19] = 218;
					num2 = 327;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 199:
					num9 = 130;
					num2 = 143;
					if (smethod_55())
					{
						continue;
					}
					goto default;
				default:
					array[3] = 68;
					num2 = 267;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 195:
					array2[17] = 163;
					goto case 178;
				case 178:
					array2[17] = 166;
					goto case 232;
				case 193:
					array[7] = (byte)num9;
					num2 = 153;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 190:
					smethod_36(smethod_35(object_), 0L);
					goto case 279;
				case 189:
					num5 = 145;
					num2 = 56;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 188:
					num5 = 138;
					goto case 156;
				case 156:
					array2[14] = (byte)num5;
					goto case 262;
				case 187:
					num14 = 0u;
					num2 = 307;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 185:
					num5 = 141;
					goto case 174;
				case 174:
					array2[6] = (byte)num5;
					num = 233;
					goto case 233;
				case 184:
					num5 = 132;
					num2 = 93;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 66;
				case 183:
					num5 = 124;
					num2 = 85;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 182:
					array5 = array;
					num2 = 250;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 179:
					array[15] = 102;
					goto case 182;
				case 177:
					num5 = 99;
					goto case 332;
				case 173:
					array[8] = 154;
					goto case 71;
				case 71:
					array[8] = 124;
					num2 = 104;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 171:
					array2[11] = (byte)num5;
					goto case 79;
				case 79:
					array2[11] = 175;
					num = 349;
					goto case 349;
				case 170:
					num5 = 120;
					goto case 43;
				case 43:
					array2[26] = (byte)num5;
					goto case 113;
				case 113:
					num5 = 150;
					goto case 136;
				case 136:
					array2[26] = (byte)num5;
					goto case 391;
				case 168:
					array[14] = (byte)num9;
					num2 = 186;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 207;
				case 3:
				case 167:
					if (num12 < num13)
					{
						goto case 329;
					}
					num2 = 168;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 82;
				case 160:
					array2[8] = 144;
					num2 = 244;
					if (smethod_55())
					{
						continue;
					}
					goto case 147;
				case 147:
					stream = (Stream)smethod_46();
					num2 = 251;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 154:
					num9 = 166;
					num2 = 92;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 153:
					num9 = 205;
					goto case 10;
				case 152:
					num11 <<= 8;
					num2 = 366;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 146:
					num5 = 85;
					num2 = 178;
					if (!smethod_55())
					{
						continue;
					}
					goto case 354;
				case 144:
					array2[17] = (byte)num5;
					num2 = 33;
					if (!smethod_55())
					{
						continue;
					}
					goto case 195;
				case 143:
					array[5] = (byte)num9;
					num2 = 375;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 142:
					array5[3] = array6[1];
					num2 = 398;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 141:
					array2[25] = 143;
					goto case 57;
				case 139:
					array[0] = (byte)num9;
					goto case 265;
				case 138:
					num5 = 5;
					goto case 76;
				case 76:
					array2[0] = (byte)num5;
					num = 130;
					goto case 130;
				case 130:
					num5 = 125;
					num = 87;
					goto case 87;
				case 132:
					num6 = (uint)num3;
					goto case 335;
				case 126:
					array[10] = 171;
					goto case 154;
				case 125:
					array2[31] = 128;
					num2 = 6;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 111;
				case 111:
					array4 = array2;
					num2 = 210;
					if (smethod_55())
					{
						continue;
					}
					goto case 201;
				case 122:
					array[9] = 122;
					num2 = 126;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 119:
					object_ = new Class24((Stream)smethod_34(object_5, "\u008a\u0089\u009cpuh\u0087\u009d\u008b\u0089o1td\u008a\u00866m.\u008b\u008e\u0091hh\u008b\u0088dt\u008d\u0089\u008a0\u0098yb\u008ce"));
					goto case 190;
				case 115:
					num9 = 40;
					goto case 301;
				case 109:
					num9 = 70;
					goto case 347;
				case 108:
					array2[29] = 200;
					num2 = 242;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 32;
				case 107:
					array[6] = 155;
					num2 = 256;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 104:
					num9 = 98;
					num2 = 31;
					if (!smethod_55())
					{
						continue;
					}
					goto case 41;
				case 41:
					array[9] = (byte)num9;
					num2 = 321;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 102:
					array2[8] = (byte)num5;
					num2 = 63;
					if (smethod_56() != null)
					{
						continue;
					}
					goto case 94;
				case 94:
					array2[8] = 60;
					num2 = 26;
					if (!smethod_55())
					{
						continue;
					}
					goto case 39;
				case 39:
					array2[9] = 167;
					goto case 355;
				case 101:
					array[4] = (byte)num9;
					goto case 84;
				case 84:
					array[4] = 132;
					goto case 37;
				case 37:
					array[4] = 123;
					goto case 393;
				case 98:
					num5 = 96;
					num2 = 8;
					if (!smethod_55())
					{
						continue;
					}
					goto case 9;
				case 95:
					num12 = 0;
					num2 = 167;
					if (smethod_55())
					{
						continue;
					}
					goto IL_00b3;
				case 93:
					array2[27] = (byte)num5;
					goto case 270;
				case 92:
					array[10] = (byte)num9;
					num2 = 109;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 91:
					array3[num3 + 1] = (byte)((num4 & 0xFF00) >> 8);
					goto case 204;
				case 88:
					array2[6] = 135;
					goto case 185;
				case 86:
					array2[16] = (byte)num5;
					goto case 46;
				case 46:
					num5 = 192;
					goto case 392;
				case 85:
					array2[25] = (byte)num5;
					goto case 141;
				case 83:
					num11 = 255u;
					goto case 348;
				case 81:
					array2[29] = 212;
					num2 = 80;
					if (!smethod_55())
					{
						continue;
					}
					goto case 108;
				case 80:
					array2[24] = 100;
					num2 = 241;
					if (smethod_55())
					{
						continue;
					}
					goto case 160;
				case 74:
					num10++;
					goto case 165;
				case 62:
					num9 = 105;
					goto case 193;
				case 51:
					array2[27] = (byte)num5;
					num2 = 259;
					if (smethod_56() == null)
					{
						continue;
					}
					goto case 203;
				case 44:
					num8++;
					goto case 105;
				case 42:
					num7 = (uint)((array4[num6 + 3] << 24) | (array4[num6 + 2] << 16) | (array4[num6 + 1] << 8) | array4[num6]);
					num2 = 83;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 34:
					num5 = 97;
					num = 86;
					goto case 86;
				case 27:
					array2[21] = (byte)num5;
					goto case 248;
				case 24:
					array[14] = 110;
					goto case 228;
				case 22:
					array2[23] = 230;
					num2 = 80;
					if (smethod_56() == null)
					{
						continue;
					}
					goto IL_00b3;
				case 21:
					array3[num3] = (byte)(num4 & 0xFFu);
					goto case 91;
				case 18:
					array2[4] = 125;
					num = 357;
					goto case 357;
				case 15:
					array[15] = 223;
					goto case 285;
				case 6:
					array[11] = 117;
					goto case 343;
				case 120:
					break;
				case 314:
					goto IL_26c4;
				case 28:
					goto IL_26d1;
				case 305:
					goto end_IL_26b8;
				}
				break;
			}
			continue;
			IL_26c4:
			int_5 = smethod_51(object_6, int_4);
			goto IL_26d1;
			IL_26d1:
			try
			{
				smethod_52();
				int num25 = 1;
				if (smethod_56() != null)
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
					result = (string)smethod_54(smethod_53(), object_6, int_4 + 4, int_5);
					num25 = 0;
				}
				while (!smethod_55());
				return result;
			}
			catch
			{
				if (!smethod_55())
				{
					switch (0)
					{
					}
				}
			}
			break;
			continue;
			end_IL_26b8:
			break;
		}
		return "";
	}

	[Attribute0(typeof(Attribute0.Class22<object>[]))]
	internal static string smethod_17(object object_19)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)object_19);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	internal static uint smethod_18(IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, [MarshalAs(UnmanagedType.U4)] uint uint_0, IntPtr intptr_7, ref uint uint_1)
	{
		IntPtr ptr = intptr_6;
		if (bool_6)
		{
			ptr = intptr_5;
		}
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : Marshal.ReadInt32(ptr, IntPtr.Size * 2));
		object obj = ((Hashtable)object_4)[(object)num];
		if (obj != null)
		{
			Struct15 @struct = (Struct15)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
			Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
			if (@struct.bool_0)
			{
				intptr_7 = intPtr;
				uint_1 = (uint)@struct.byte_0.Length;
				smethod_27(intptr_7, @struct.byte_0.Length, 64, ref int_1);
				return 0u;
			}
			Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(ptr, IntPtr.Size * 3, @struct.byte_0.Length);
			uint result = 0u;
			if (uint_0 == 216669565 && !bool_5)
			{
				bool_5 = true;
			}
			else
			{
				result = object_17(intptr_4, intptr_5, intptr_6, uint_0, intptr_7, ref uint_1);
			}
			return result;
		}
		return object_17(intptr_4, intptr_5, intptr_6, uint_0, intptr_7, ref uint_1);
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
		return (Delegate)Type.GetTypeFromHandle(Class26.smethod_0(16777275)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(Class26.smethod_0(16777249)),
			Type.GetTypeFromHandle(Class26.smethod_0(16777312))
		})!.Invoke(null, new object[2] { intptr_4, type_0 });
	}

	internal unsafe static void smethod_22()
	{
		//The blocks IL_2449, IL_2466, IL_2476, IL_24b5 are reachable both inside and outside the pinned region starting at IL_2474. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0009, IL_0013, IL_001c, IL_0031, IL_0aab, IL_0aba, IL_0ad6, IL_0ae5, IL_0af3, IL_0afc, IL_0b1a, IL_0b23, IL_0b2f, IL_0b38, IL_0b46, IL_0b4f, IL_0b5d, IL_0b66, IL_0b86, IL_0b8f, IL_0b9d, IL_0ba9, IL_0bb8, IL_0bd6, IL_0bdf, IL_0bed, IL_0bf6, IL_0c14, IL_0c2d, IL_0c32, IL_0c38, IL_0c53, IL_0c7c, IL_0c98, IL_0ca1, IL_0cb8, IL_0cbe, IL_0ce1, IL_0cf0, IL_0cfc, IL_0d02, IL_0d25, IL_0d43, IL_0d5e, IL_0d76, IL_0d96, IL_0d9c, IL_0dac, IL_0dd9, IL_0de0, IL_0df5, IL_0e13, IL_0e1a, IL_0e55, IL_0e61, IL_0e6a, IL_0e78, IL_0e99, IL_0ebc, IL_0eca, IL_0ee0, IL_0eee, IL_0f09, IL_0f2a, IL_0f32, IL_0f42, IL_0f46, IL_0f64, IL_0f77, IL_0f90, IL_0f9f, IL_0fc0, IL_0fc3, IL_0fc6, IL_0fce, IL_0ff4, IL_1005, IL_1013, IL_1021, IL_103f, IL_1048, IL_105b, IL_107e, IL_108a, IL_1096, IL_10b5, IL_10c3, IL_10c6, IL_10d2, IL_10de, IL_10f0, IL_1101, IL_1118, IL_1136, IL_1154, IL_115f, IL_1163, IL_116c, IL_118c, IL_11b0, IL_11c2, IL_11d0, IL_11ef, IL_120b, IL_1217, IL_123b, IL_1250, IL_1262, IL_1270, IL_128b, IL_1292, IL_129d, IL_12ac, IL_12bb, IL_12dc, IL_12ef, IL_12ff, IL_130b, IL_1329, IL_134f, IL_1364, IL_137a, IL_139d, IL_13a8, IL_13b3, IL_13be, IL_13c9, IL_13d4, IL_13eb, IL_13f1, IL_1407, IL_1415, IL_1440, IL_145f, IL_146b, IL_1484, IL_1492, IL_1498, IL_14a6, IL_14b5, IL_14c4, IL_14ca, IL_14d8, IL_14e4, IL_14f3, IL_1502, IL_1514, IL_1522, IL_152b, IL_154e, IL_1557, IL_157a, IL_1596, IL_159f, IL_15a4, IL_15b4, IL_15cf, IL_15d7, IL_15e7, IL_15fb, IL_1607, IL_1616, IL_1625, IL_1631, IL_1637, IL_163e, IL_1664, IL_1667, IL_166d, IL_1680, IL_1698, IL_16a8, IL_16d3, IL_16db, IL_16f0, IL_16f9, IL_1717, IL_1730, IL_1747, IL_1765, IL_176d, IL_1785, IL_178d, IL_17a2, IL_17bd, IL_17de, IL_1976, IL_1996, IL_19b1, IL_19cb, IL_19e2, IL_19f7, IL_1a0a, IL_1a28, IL_1a54, IL_1a64, IL_1a77, IL_1aa0, IL_1aa9, IL_1ab7, IL_1ad2, IL_1adb, IL_1afe, IL_1b21, IL_1b37, IL_1b77, IL_1b85, IL_1b8b, IL_1b99, IL_1bb2, IL_1bd5, IL_1be4, IL_1bfa, IL_1c1e, IL_1c25, IL_1c30, IL_1c4e, IL_1c64, IL_1c7b, IL_1c8a, IL_1c98, IL_1ca7, IL_1cb3, IL_1cc2, IL_1cde, IL_1ce4, IL_1cf2, IL_1d0e, IL_1d2c, IL_1d3d, IL_1d58, IL_1d7b, IL_1d92, IL_1db6, IL_1dbf, IL_1dcd, IL_1dd3, IL_1df6, IL_1e0f, IL_1e2d, IL_1e3c, IL_1e48, IL_1e6c, IL_1e74, IL_1e81, IL_1ea2, IL_1eb8, IL_1ec6, IL_1ed2, IL_1ef6, IL_1efc, IL_1f13, IL_1f31, IL_1f3f, IL_1f4b, IL_1f67, IL_1f79, IL_1f87, IL_1f8d, IL_1fb0, IL_1fbb, IL_1fcf, IL_1fd9, IL_1fed, IL_1ff0, IL_1ff8, IL_200d, IL_2031, IL_205d, IL_2078, IL_207e, IL_2095, IL_20a4, IL_20b2, IL_20be, IL_20ca, IL_20e6, IL_20f4, IL_210b, IL_2125, IL_2147, IL_2166, IL_2184, IL_219d, IL_21b9, IL_21cd, IL_2510, IL_251e, IL_252d, IL_2550, IL_2559, IL_256e, IL_2579, IL_258e, IL_2595, IL_25a1, IL_25bd, IL_25c5, IL_25c9, IL_25e1, IL_2605, IL_2626, IL_263d, IL_264b, IL_2666, IL_2679, IL_26a1, IL_26aa, IL_26b8, IL_26cc, IL_26e8, IL_26ef, IL_26f8, IL_2716, IL_2729, IL_274b, IL_2762, IL_277f, IL_2785, IL_27a9, IL_27be, IL_27db, IL_27f4, IL_2800, IL_2808, IL_281d, IL_284b, IL_2866, IL_2871, IL_287d, IL_2898, IL_28a5, IL_28c0, IL_28d8, IL_28e1, IL_28f3, IL_28fc, IL_291a, IL_2932, IL_2940, IL_2958, IL_2964, IL_2976, IL_2999, IL_29b4, IL_29ca, IL_29e8, IL_29ef, IL_2a04, IL_2a0f, IL_2a1a, IL_2a29, IL_2a45, IL_2a58, IL_2a76, IL_2a91, IL_2a9c, IL_2aa7, IL_2ab2, IL_2abd, IL_2ac8, IL_2ae8, IL_2af4, IL_2b0c, IL_2b17, IL_2b34, IL_2b40, IL_2b64, IL_2b7e, IL_2b87, IL_2b94, IL_2bb1, IL_2bc0, IL_2be4, IL_2c05, IL_2c08, IL_2c11, IL_2c26, IL_2c2f, IL_2c3a, IL_2c58, IL_2c76, IL_2c7a, IL_2c81, IL_2c9e, IL_2ca6, IL_2cb4, IL_2cd2, IL_2ce1, IL_2cf0, IL_2cf6, IL_2d04, IL_2d10, IL_2d1c, IL_2d30, IL_2d3c, IL_2d4c, IL_2d54, IL_2d6c, IL_2d77, IL_2d97, IL_2d9b, IL_2e1d, IL_2e28, IL_2e3d, IL_2e4e, IL_2e56, IL_2e5b, IL_2e64, IL_2e6c, IL_2e77, IL_2e98, IL_2eb8, IL_2ebe, IL_2ed4, IL_2edc, IL_2efb, IL_2f19, IL_2f36, IL_2f4e, IL_2f5f, IL_303d, IL_3052, IL_3056, IL_305e, IL_3076, IL_3081, IL_30a2, IL_30bb, IL_30c4, IL_30d9, IL_30fa, IL_3115, IL_3133, IL_313e, IL_314b, IL_3154, IL_3174, IL_3183, IL_318c, IL_3192, IL_3198, IL_319e, IL_31b4, IL_31cf, IL_31d7, IL_31e9, IL_31f8, IL_321b, IL_321f, IL_3238, IL_324c, IL_325c, IL_326e, IL_3291, IL_32b4, IL_32c0, IL_32c9, IL_32d7, IL_32f2, IL_3319, IL_3325, IL_3333, IL_3356, IL_3361, IL_337a, IL_337d, IL_3380, IL_3393, IL_3399, IL_339f, IL_33ba, IL_33dd, IL_33f8, IL_3413, IL_3431, IL_3447, IL_3453, IL_346d, IL_347b, IL_348e, IL_34a9, IL_34cd, IL_34ee, IL_34f9, IL_3504, IL_3528, IL_353c, IL_3664, IL_3687, IL_3695, IL_36a9, IL_36ba, IL_36c6, IL_36d1, IL_36e2, IL_36f7, IL_3700, IL_3717, IL_3723, IL_3729, IL_373c, IL_374f, IL_3762, IL_3786, IL_379d, IL_37b9, IL_37c5, IL_37d8, IL_37e9, IL_3806, IL_3812, IL_381b, IL_3826, IL_3843, IL_385c, IL_387c, IL_389f, IL_38a5, IL_38c1, IL_38db, IL_38e9, IL_390a, IL_3925, IL_3938, IL_3946, IL_3954, IL_3962, IL_396d, IL_3993, IL_39b6, IL_39d9, IL_39e1, IL_39f9, IL_3a04, IL_3a20, IL_3a38, IL_3a56, IL_3a6a, IL_3a75, IL_3a8a, IL_3a95, IL_3aa3, IL_3aaf, IL_3acd, IL_3aee, IL_3af7, IL_3b0e, IL_3b17, IL_3b25, IL_3b30, IL_3b4c, IL_3b52, IL_3b6e, IL_3b91, IL_3b9a, IL_3ba8, IL_3bc2, IL_3bd7, IL_3bf5, IL_3c04, IL_3c15, IL_3c26, IL_3c42, IL_3c5e, IL_3c79, IL_3c7f, IL_3c8a, IL_3ca6, IL_3cb8, IL_3cdc, IL_3cf4, IL_3d20, IL_3d31, IL_3d4d, IL_3d61, IL_3d7e, IL_3d8c, IL_3db5, IL_3dd6, IL_3de1, IL_3e04, IL_3e1e, IL_3e38, IL_3e56, IL_3e61, IL_3e6f, IL_3e7b, IL_3e99, IL_3eac, IL_3ebf, IL_3ecd, IL_3ed5, IL_3ee4, IL_3eea, IL_3f0d, IL_3f1b, IL_3f3a, IL_3f52, IL_3f73, IL_3f7e, IL_3f8e, IL_3f9b, IL_3fb8, IL_3fcc, IL_3fd3, IL_3fe4, IL_3fed, IL_3ffb, IL_400c, IL_4017, IL_4023, IL_4044, IL_4054, IL_4078, IL_4099, IL_40bd, IL_40d7, IL_40e0, IL_40fe, IL_4111, IL_411f, IL_4140, IL_4168, IL_418c, IL_41af, IL_41b2, IL_41ba, IL_41d6, IL_41df, IL_41f0, IL_420e, IL_421a, IL_422e, IL_424c, IL_426d, IL_427b, IL_429e, IL_42ac, IL_42bf, IL_42ca, IL_42de, IL_42f2, IL_4316, IL_433a, IL_4358, IL_4384, IL_43a7, IL_43c2, IL_43d5, IL_43de, IL_43f2, IL_440d, IL_4435, IL_4459, IL_461e, IL_4639, IL_4659, IL_466e, IL_467a, IL_4681, IL_4687 are reachable both inside and outside the pinned region starting at IL_2140. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		int num = 644;
		byte[] array4 = default(byte[]);
		int num17 = default(int);
		byte[] array6 = default(byte[]);
		int num20 = default(int);
		int num19 = default(int);
		uint num21 = default(uint);
		int num28 = default(int);
		byte[] array18 = default(byte[]);
		int num57 = default(int);
		uint num52 = default(uint);
		int num26 = default(int);
		IntPtr intptr_ = default(IntPtr);
		Class24 object_4 = default(Class24);
		int num16 = default(int);
		IntPtr intPtr = default(IntPtr);
		bool flag = default(bool);
		uint num29 = default(uint);
		uint num30 = default(uint);
		uint num22 = default(uint);
		byte[] array17 = default(byte[]);
		uint num34 = default(uint);
		int num3 = default(int);
		byte[] array = default(byte[]);
		int num25 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array15 = default(byte[]);
		long value = default(long);
		int int_ = default(int);
		int num38 = default(int);
		int num56 = default(int);
		uint num60 = default(uint);
		long num15 = default(long);
		ProcessModuleCollection object_16 = default(ProcessModuleCollection);
		IEnumerator enumerator = default(IEnumerator);
		byte[] array14 = default(byte[]);
		IntPtr intPtr3 = default(IntPtr);
		int int_3 = default(int);
		byte[] array3 = default(byte[]);
		int num58 = default(int);
		int num55 = default(int);
		IntPtr intptr_4 = default(IntPtr);
		Enum7 uint_ = default(Enum7);
		byte[] array8 = default(byte[]);
		byte[] array11 = default(byte[]);
		Struct15 struct2 = default(Struct15);
		IntPtr intptr_3 = default(IntPtr);
		long num31 = default(long);
		int num33 = default(int);
		int num51 = default(int);
		int num24 = default(int);
		Version object_14 = default(Version);
		Version object_13 = default(Version);
		Version object_15 = default(Version);
		int num73 = default(int);
		int num75 = default(int);
		int num18 = default(int);
		int num53 = default(int);
		ref byte reference3 = default(ref byte);
		byte[] array7 = default(byte[]);
		int num70 = default(int);
		string text = default(string);
		int num71 = default(int);
		byte[] array19 = default(byte[]);
		int num54 = default(int);
		Struct15 @struct = default(Struct15);
		bool flag2 = default(bool);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_5 = default(SymmetricAlgorithm);
		byte[] array13 = default(byte[]);
		byte[] array9 = default(byte[]);
		byte[] array10 = default(byte[]);
		MemoryStream object_11 = default(MemoryStream);
		int num66 = default(int);
		byte[] array20 = default(byte[]);
		uint nativeSizeOfCode = default(uint);
		int num63 = default(int);
		ref byte reference2 = default(ref byte);
		int num65 = default(int);
		int num68 = default(int);
		int num43 = default(int);
		uint num59 = default(uint);
		IntPtr intPtr2 = default(IntPtr);
		int num27 = default(int);
		Process object_ = default(Process);
		IntPtr intptr_6 = default(IntPtr);
		IntPtr procAddress = default(IntPtr);
		string string_ = default(string);
		int num23 = default(int);
		byte[] array5 = default(byte[]);
		IntPtr intptr_2 = default(IntPtr);
		int num45 = default(int);
		int num32 = default(int);
		int num35 = default(int);
		int num39 = default(int);
		int num41 = default(int);
		CryptoStream object_6 = default(CryptoStream);
		int int_2 = default(int);
		byte[] byte_ = default(byte[]);
		Delegate3 object_7 = default(Delegate3);
		MemoryStream memoryStream = default(MemoryStream);
		int num5 = default(int);
		int num7 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		IntPtr zero = default(IntPtr);
		long num8 = default(long);
		while (!bool_0)
		{
			num = 643;
			while (true)
			{
				IL_001c:
				bool_0 = true;
				int num2 = 642;
				if (smethod_190() == null)
				{
					goto IL_0031;
				}
				goto IL_0b1a;
				IL_0b1a:
				num2 = num;
				goto IL_0031;
				IL_0031:
				while (true)
				{
					int num72;
					int num74;
					nint num69;
					byte[] array22;
					int num61;
					byte[] array21;
					int num62;
					int num64;
					int num67;
					IntPtr intptr_5;
					uint num49;
					int num44;
					int num46;
					int num47;
					int num48;
					byte[] array16;
					int num36;
					int num37;
					int num40;
					int num42;
					byte[] array12;
					ref Struct15 reference;
					int num4;
					int num6;
					long num10;
					long num9;
					int num11;
					int num13;
					switch (num2)
					{
					case 644:
						break;
					case 643:
						goto IL_001c;
					case 667:
						array4[2] = 174;
						goto case 335;
					case 335:
						array4[2] = 87;
						num2 = 247;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 153;
					case 153:
						num17 = 125;
						num = 505;
						goto case 505;
					case 505:
						array4[19] = (byte)num17;
						goto case 159;
					case 159:
						num17 = 193;
						goto case 315;
					case 315:
						array4[19] = (byte)num17;
						num2 = 139;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 666:
						array6[3] = 125;
						goto case 330;
					case 330:
						num20 = 131;
						goto case 346;
					case 346:
						array6[3] = (byte)num20;
						goto case 189;
					case 189:
						num20 = 138;
						goto case 617;
					case 617:
						array6[4] = (byte)num20;
						goto case 85;
					case 85:
						num20 = 175;
						goto case 632;
					case 632:
						array6[4] = (byte)num20;
						num2 = 485;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 665:
						num17 = 154;
						goto case 58;
					case 58:
						array4[28] = (byte)num17;
						goto case 411;
					case 411:
						array4[28] = 13;
						goto case 440;
					case 440:
						num17 = 111;
						num = 605;
						goto case 605;
					case 605:
						array4[29] = (byte)num17;
						num2 = 542;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 628;
					case 628:
						num17 = 137;
						goto case 324;
					case 324:
						array4[29] = (byte)num17;
						goto case 598;
					case 598:
						num17 = 224;
						goto case 267;
					case 267:
						array4[29] = (byte)num17;
						num2 = 315;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 358;
					case 358:
						num17 = 151;
						num2 = 570;
						if (smethod_189())
						{
							continue;
						}
						goto case 192;
					case 192:
						if (num19 > 0)
						{
							goto case 631;
						}
						goto case 63;
					case 631:
						num21 <<= 8;
						goto case 35;
					case 35:
						num28 += 8;
						num2 = 63;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 63:
						array18[num57 + num19] = (byte)((num52 & num21) >> num28);
						num2 = 57;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 664:
						array6[9] = 48;
						num2 = 73;
						if (!smethod_189())
						{
							continue;
						}
						goto case 478;
					case 478:
						num20 = 164;
						goto case 211;
					case 211:
						array6[10] = (byte)num20;
						num = 391;
						goto case 391;
					case 391:
						num20 = 96;
						goto case 572;
					case 572:
						array6[10] = (byte)num20;
						num2 = 144;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 663:
						array6[13] = 187;
						goto case 554;
					case 554:
						array6[13] = 91;
						goto case 507;
					case 507:
						num20 = 86;
						goto case 115;
					case 115:
						array6[14] = (byte)num20;
						num2 = 425;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 662:
						array6[7] = (byte)num20;
						num2 = 422;
						if (smethod_189())
						{
							continue;
						}
						goto case 260;
					case 260:
						num17 = 125;
						num2 = 318;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 661:
						num26++;
						num2 = 301;
						if (!smethod_189())
						{
							continue;
						}
						goto case 407;
					case 325:
						smethod_159(new IntPtr(intptr_.ToInt64() + num26 * 4), smethod_146(object_4));
						goto case 661;
					case 407:
					case 543:
						if (num26 < num16)
						{
							goto case 325;
						}
						num2 = 383;
						if (smethod_189())
						{
							continue;
						}
						goto default;
					default:
						intPtr = smethod_143(((object[])smethod_142(smethod_162(typeof(Class21).TypeHandle).Assembly))[0]);
						num2 = 374;
						if (smethod_189())
						{
							continue;
						}
						goto case 25;
					case 25:
						if (flag)
						{
							num2 = 545;
							if (smethod_189())
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 504;
					case 660:
						num20 = 164;
						num2 = 82;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 659:
						num29 += num30;
						goto case 514;
					case 514:
						num22 = (uint)((array17[num34 + 3] << 24) | (array17[num34 + 2] << 16) | (array17[num34 + 1] << 8) | array17[num34]);
						num2 = 357;
						if (smethod_189())
						{
							continue;
						}
						goto case 133;
					case 133:
						array4[4] = 120;
						goto case 203;
					case 203:
						num17 = 168;
						goto case 510;
					case 510:
						array4[4] = (byte)num17;
						goto case 417;
					case 417:
						array4[4] = 116;
						num2 = 54;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 658:
						array4[14] = (byte)num17;
						num2 = 634;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 657:
						array4[16] = (byte)num17;
						goto case 491;
					case 491:
						num17 = 76;
						num2 = 160;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 469;
					case 469:
						array4[17] = (byte)num17;
						goto case 125;
					case 125:
						num17 = 60;
						num2 = 61;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 656:
						array6[11] = 101;
						num2 = 228;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 261:
					case 655:
						if (smethod_115() == 4)
						{
							num2 = 144;
							if (smethod_190() != null)
							{
								continue;
							}
							goto case 301;
						}
						goto case 277;
					case 301:
						num3 = 9;
						goto case 401;
					case 401:
						array[num3] = array10[0];
						num2 = 151;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 277:
						num25 = 2;
						num2 = 85;
						if (!smethod_189())
						{
							continue;
						}
						goto case 292;
					case 292:
						array[num25] = array10[0];
						num2 = 538;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 329;
					case 329:
						array4[25] = 168;
						goto case 141;
					case 141:
						array4[25] = 109;
						num2 = 129;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 654:
						array2 = null;
						goto case 248;
					case 248:
						array10 = null;
						goto case 381;
					case 381:
						if (smethod_115() == 4)
						{
							goto case 142;
						}
						goto case 99;
					case 142:
						array10 = (byte[])smethod_157(Class21.intptr_2.ToInt32());
						num2 = 597;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 99:
						array10 = (byte[])smethod_182(Class21.intptr_2.ToInt64());
						goto case 471;
					case 471:
						array15 = (byte[])smethod_182(zero.ToInt64());
						goto case 306;
					case 306:
						array2 = (byte[])smethod_182(num8);
						goto case 261;
					case 653:
						array4[27] = (byte)num17;
						num2 = 235;
						if (!smethod_189())
						{
							continue;
						}
						goto case 537;
					case 537:
						num17 = 158;
						goto case 432;
					case 432:
						array4[28] = (byte)num17;
						goto case 665;
					case 652:
						num8 = smethod_170(new IntPtr(value));
						num2 = 419;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 651:
						array6[7] = 114;
						goto case 472;
					case 472:
						array6[7] = 113;
						goto case 349;
					case 349:
						array6[7] = 140;
						num2 = 495;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 627;
					case 627:
						num20 = 149;
						goto case 662;
					case 650:
						int_ = 0;
						goto case 365;
					case 365:
						num38 = 0;
						num = 595;
						goto case 595;
					case 595:
						if (smethod_144(Class21.object_5) != null)
						{
							goto case 72;
						}
						num2 = 118;
						if (!smethod_189())
						{
							continue;
						}
						goto case 121;
					case 72:
						if (smethod_145(smethod_144(Class21.object_5)) == 0)
						{
							goto case 121;
						}
						goto case 544;
					case 121:
					case 390:
						num38 = 7680;
						num2 = 488;
						if (!smethod_189())
						{
							continue;
						}
						goto case 544;
					case 544:
						num56 = smethod_146(object_4);
						num2 = 636;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 649:
						num17 = 166;
						num2 = 609;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 648:
						array[num25 + 7] = array10[7];
						goto case 175;
					case 175:
						num25 = 18;
						goto case 274;
					case 274:
						array[num25] = array2[0];
						goto case 578;
					case 578:
						array[num25 + 1] = array2[1];
						num2 = 191;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 647:
						array4[5] = 154;
						num2 = 118;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 646:
						num20 = 226;
						num = 566;
						goto case 566;
					case 566:
						array6[2] = (byte)num20;
						goto case 60;
					case 60:
						array6[2] = 138;
						num2 = 93;
						if (smethod_189())
						{
							continue;
						}
						goto case 88;
					case 88:
						array4[16] = 110;
						num2 = 588;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 557;
					case 557:
						array4[6] = 114;
						goto case 168;
					case 168:
						array4[6] = 156;
						num2 = 230;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 645:
						array4[9] = 120;
						num = 137;
						goto case 137;
					case 137:
						num17 = 165;
						num = 69;
						goto case 69;
					case 69:
						array4[9] = (byte)num17;
						goto case 441;
					case 441:
						num17 = 19;
						num2 = 98;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 642:
						num60 = 4059231220u;
						goto case 132;
					case 132:
						num15 = 0L;
						goto case 231;
					case 231:
						smethod_100(new IntPtr(&num15), 0);
						goto case 368;
					case 368:
						smethod_101(new IntPtr(&num15), 0);
						goto case 11;
					case 11:
						do
						{
							smethod_102(new IntPtr(&num15), 0);
							num2 = 24;
						}
						while (!smethod_189());
						continue;
					case 641:
						if (smethod_117(smethod_116("System.Reflection.ReflectionContext", bool_7: false), null))
						{
							num2 = 262;
							if (smethod_190() != null)
							{
								continue;
							}
							goto case 364;
						}
						goto case 541;
					case 364:
						object_16 = (ProcessModuleCollection)smethod_118(smethod_109());
						goto case 573;
					case 573:
						enumerator = (IEnumerator)smethod_119(object_16);
						num2 = 623;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 541:
						object_4 = new Class24((Stream)smethod_133(Class21.object_5, "75l\u0088\u0098\u0086\u008d0\u0097\u0090\u009dtgf\u008e\u009awa.\u009a0\u009d\u0089\u008b\u0090\u008exnji\u0093j\u009f\u008f\u0097\u009d\u0095"));
						num2 = 547;
						if (smethod_189())
						{
							continue;
						}
						goto case 547;
					case 547:
						smethod_135(smethod_134(object_4), 0L);
						goto case 618;
					case 618:
						array14 = (byte[])smethod_137(object_4, (int)smethod_136(smethod_134(object_4)));
						goto case 10;
					case 10:
						array4 = new byte[32];
						num2 = 649;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 640:
						array[num25 + 3] = array15[3];
						goto case 181;
					case 181:
						array[num25 + 4] = array15[4];
						goto case 188;
					case 188:
						array[num25 + 5] = array15[5];
						goto case 312;
					case 312:
						array[num25 + 6] = array15[6];
						goto case 148;
					case 148:
						array[num25 + 7] = array15[7];
						goto case 244;
					case 244:
					case 278:
						smethod_107(array, 0, intPtr3, array.Length);
						num = 184;
						goto case 184;
					case 184:
						bool_4 = false;
						goto case 534;
					case 534:
						smethod_27(new IntPtr(value), smethod_115(), 64, ref int_3);
						goto case 265;
					case 265:
						smethod_188(new IntPtr(value), intPtr3);
						goto case 436;
					case 436:
						smethod_27(new IntPtr(value), smethod_115(), int_3, ref int_3);
						num2 = 196;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 639:
						array4[10] = 147;
						num2 = 119;
						if (!smethod_189())
						{
							continue;
						}
						goto case 146;
					case 146:
						array4[10] = 116;
						goto case 356;
					case 356:
						num17 = 149;
						num2 = 75;
						if (!smethod_189())
						{
							continue;
						}
						goto case 83;
					case 83:
						array4[10] = (byte)num17;
						goto case 603;
					case 603:
						num17 = 51;
						goto case 34;
					case 34:
						array4[10] = (byte)num17;
						goto case 372;
					case 372:
						array4[11] = 174;
						goto case 345;
					case 345:
						array4[11] = 152;
						goto case 239;
					case 239:
						num17 = 93;
						goto case 307;
					case 307:
						array4[11] = (byte)num17;
						goto case 461;
					case 461:
						array4[11] = 84;
						goto case 477;
					case 477:
						array4[11] = 251;
						goto case 33;
					case 33:
						array4[12] = 134;
						goto case 494;
					case 494:
						num17 = 143;
						num = 283;
						goto case 283;
					case 283:
						array4[12] = (byte)num17;
						goto case 286;
					case 286:
						num17 = 160;
						goto case 593;
					case 593:
						array4[12] = (byte)num17;
						num2 = 68;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 638:
						num17 = 146;
						goto case 86;
					case 86:
						array4[14] = (byte)num17;
						num2 = 47;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 637:
						array3[9] = 108;
						num2 = 416;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 636:
						num58 = smethod_146(object_4);
						goto case 216;
					case 216:
						if (num58 == 4)
						{
							num2 = 163;
							if (smethod_189())
							{
								continue;
							}
							goto case 112;
						}
						goto case 564;
					case 112:
						array3[2] = 114;
						num2 = 40;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 564:
						if (num58 == 1)
						{
							goto case 187;
						}
						num55 = 0;
						goto case 221;
					case 187:
						intptr_4 = IntPtr.Zero;
						num = 109;
						goto case 109;
					case 109:
						uint_ = (Enum7)56;
						num2 = 338;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 240;
					case 240:
						array6[15] = 102;
						goto case 615;
					case 615:
						array6[15] = 156;
						goto case 105;
					case 105:
						array6[15] = 161;
						goto case 328;
					case 328:
						array6[15] = 25;
						goto case 202;
					case 202:
						array8 = array6;
						goto case 190;
					case 190:
						smethod_138(array8);
						goto case 266;
					case 266:
						array11 = (byte[])smethod_140(smethod_139(Class21.object_5));
						num2 = 517;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 221:
					case 604:
						if (num55 >= num56)
						{
							goto case 294;
						}
						goto case 299;
					case 294:
						Class21.object_4 = new Hashtable(smethod_146(object_4) + 1);
						goto case 451;
					case 451:
						struct2 = default(Struct15);
						num2 = 257;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 213;
					case 213:
						array[num3 + 3] = array15[3];
						goto case 244;
					case 299:
						intptr_3 = new IntPtr(num31 + smethod_146(object_4) - num38);
						num2 = 195;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 635:
						if (num33 == num51 - 1)
						{
							num2 = 136;
							if (smethod_190() == null)
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 77;
					case 77:
						num34 = (uint)num57;
						goto case 659;
					case 634:
						num17 = 145;
						num2 = 420;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 633:
						num17 = 237;
						num2 = 180;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 194;
					case 194:
						array4[0] = (byte)num17;
						num = 626;
						goto case 626;
					case 626:
						num17 = 163;
						num2 = 234;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 630:
						array8[3] = array11[1];
						goto case 222;
					case 222:
						array8[5] = array11[2];
						num2 = 553;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 136;
					case 136:
						if (num24 > 0)
						{
							num2 = 288;
							if (smethod_190() == null)
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 77;
					case 625:
						num17 = 23;
						num2 = 575;
						if (smethod_189())
						{
							continue;
						}
						goto case 221;
					case 624:
						array4[9] = 110;
						num2 = 645;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 623:
						try
						{
							while (smethod_131(enumerator))
							{
								while (true)
								{
									ProcessModule object_12 = (ProcessModule)smethod_120(enumerator);
									while (true)
									{
										IL_18e9:
										if (smethod_123(smethod_122(smethod_121(object_12)), "clrjit.dll"))
										{
											goto IL_1887;
										}
										num72 = 0;
										if (smethod_190() == null)
										{
											goto IL_184d;
										}
										goto IL_18cb;
										IL_184d:
										while (true)
										{
											switch (num72)
											{
											case 9:
												if (smethod_130(object_14, object_13))
												{
													num72 = 3;
													if (smethod_189())
													{
														continue;
													}
													goto IL_18e9;
												}
												goto end_IL_1903;
											case 5:
												object_15 = new Version(4, 0, 30319, 17020);
												num72 = 1;
												if (smethod_189())
												{
													continue;
												}
												goto end_IL_1903;
											case 4:
												if (!smethod_129(object_14, object_15))
												{
													goto end_IL_1903;
												}
												goto case 9;
											case 1:
												object_13 = new Version(4, 0, 30319, 17921);
												goto case 4;
											case 11:
												break;
											case 2:
												goto IL_18e9;
											case 10:
												goto end_IL_18e9;
											default:
												goto end_IL_1903;
											case 3:
												bool_6 = true;
												goto end_IL_1914;
											case 6:
											case 8:
												goto end_IL_1914;
											}
											break;
										}
										goto IL_1887;
										IL_1887:
										object_14 = new Version(smethod_125(smethod_124(object_12)), smethod_126(smethod_124(object_12)), smethod_127(smethod_124(object_12)), smethod_128(smethod_124(object_12)));
										num72 = 5;
										if (smethod_189())
										{
											goto IL_184d;
										}
										goto IL_18cb;
										IL_18cb:
										num72 = num73;
										goto IL_184d;
										continue;
										end_IL_18e9:
										break;
									}
									continue;
									end_IL_1903:
									break;
								}
								continue;
								end_IL_1914:
								break;
							}
						}
						finally
						{
							IDisposable disposable = enumerator as IDisposable;
							while (disposable != null)
							{
								num74 = 1;
								if (!smethod_189())
								{
									break;
								}
								while (true)
								{
									switch (num74)
									{
									case 1:
										smethod_132(disposable);
										num74 = 0;
										if (smethod_190() != null)
										{
											num74 = num75;
										}
										continue;
									default:
										goto end_IL_195b;
									case 2:
										break;
									case 0:
										goto end_IL_195b;
									}
									goto IL_196e;
									continue;
									end_IL_195b:
									break;
								}
								break;
								IL_196e:;
							}
						}
						goto case 541;
					case 622:
						array[num25 + 2] = array15[2];
						num2 = 165;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 640;
					case 621:
						num51++;
						num2 = 135;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 415:
					case 620:
						if (num18 >= num53)
						{
							goto case 437;
						}
						goto case 331;
					case 437:
						reference3 = ref *(byte*)null;
						num2 = 74;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 102;
					case 102:
						object_4 = new Class24(new MemoryStream(array7));
						num = 377;
						goto case 377;
					case 377:
						smethod_135(smethod_134(object_4), 0L);
						goto case 131;
					case 131:
						intPtr = smethod_143(((object[])smethod_142(Class21.object_5))[0]);
						goto case 140;
					case 140:
						num31 = intPtr.ToInt64();
						num2 = 378;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 650;
					case 331:
						num69 = (nint)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3) + (nint)num18 * (nint)8);
						*(long*)num69 ^= 1304068455L;
						num2 = 56;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 619:
						array[num25 + 1] = array15[1];
						goto case 622;
					case 616:
						array4[9] = (byte)num17;
						goto case 624;
					case 614:
						intptr_ = new IntPtr(long_0 + num70 - num38);
						num2 = 37;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 613:
						num17 = 237;
						goto case 431;
					case 431:
						array4[29] = (byte)num17;
						goto case 95;
					case 95:
						num17 = 13;
						num2 = 342;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 612:
						num17 = 219;
						goto case 499;
					case 499:
						array4[4] = (byte)num17;
						num2 = 447;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 611:
						text = (string)smethod_165(smethod_164(), array3);
						num2 = 520;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 610:
						num34 = (uint)(num71 * 4);
						num2 = 161;
						if (!smethod_189())
						{
							continue;
						}
						goto case 526;
					case 526:
						num30 = (uint)((array19[num34 + 3] << 24) | (array19[num34 + 2] << 16) | (array19[num34 + 1] << 8) | array19[num34]);
						num2 = 92;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 609:
						array4[0] = (byte)num17;
						goto case 166;
					case 166:
						num17 = 105;
						goto case 465;
					case 465:
						array4[0] = (byte)num17;
						goto case 448;
					case 448:
						num17 = 203;
						num2 = 6;
						if (!smethod_189())
						{
							continue;
						}
						goto case 160;
					case 160:
						array4[0] = (byte)num17;
						num2 = 633;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 608:
						array4[22] = 172;
						goto case 516;
					case 516:
						num17 = 86;
						num2 = 284;
						if (smethod_189())
						{
							continue;
						}
						goto case 47;
					case 47:
						array4[14] = 134;
						num2 = 150;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 607:
						num71 = num33 % num54;
						goto case 599;
					case 599:
						num57 = num33 * 4;
						goto case 610;
					case 606:
						@struct.bool_0 = flag2;
						num2 = 326;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 602:
						array19 = array4;
						num2 = 150;
						if (!smethod_189())
						{
							continue;
						}
						goto case 243;
					case 243:
						array6 = new byte[16];
						num = 50;
						goto case 50;
					case 50:
						num20 = 120;
						num = 569;
						goto case 569;
					case 569:
						array6[0] = (byte)num20;
						goto case 108;
					case 108:
						array6[0] = 158;
						goto case 29;
					case 29:
						array6[0] = 112;
						goto case 65;
					case 65:
						array6[0] = 203;
						goto case 445;
					case 445:
						array6[0] = 52;
						num2 = 162;
						if (!smethod_189())
						{
							continue;
						}
						goto case 302;
					case 302:
						num20 = 100;
						goto case 532;
					case 532:
						array6[1] = (byte)num20;
						goto case 582;
					case 582:
						array6[1] = 103;
						num2 = 121;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 581;
					case 581:
						num20 = 173;
						num2 = 366;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 601:
						array4[24] = 42;
						goto case 329;
					case 600:
						num20 = 115;
						num2 = 579;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 597:
						array15 = (byte[])smethod_157(zero.ToInt32());
						num2 = 219;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 596:
						array6[8] = (byte)num20;
						num = 293;
						goto case 293;
					case 293:
						array6[8] = 158;
						num2 = 313;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 594:
						num20 = 166;
						goto case 396;
					case 396:
						array6[12] = (byte)num20;
						goto case 373;
					case 373:
						num20 = 58;
						goto case 497;
					case 497:
						array6[12] = (byte)num20;
						num2 = 424;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 592:
						num17 = 147;
						num2 = 450;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 490;
					case 490:
						array4[7] = (byte)num17;
						num2 = 1;
						if (!smethod_189())
						{
							continue;
						}
						goto case 1;
					case 1:
						array4[7] = 139;
						goto case 48;
					case 48:
						array4[7] = 66;
						goto case 370;
					case 370:
						array4[8] = 137;
						num2 = 404;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 290:
					case 591:
						num18 = 0;
						goto case 415;
					case 590:
						transform = (ICryptoTransform)smethod_149(object_5, array19, array8);
						goto case 18;
					case 18:
						smethod_141(array19, 0, array19.Length);
						num2 = 176;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 589:
						num17 = 43;
						num2 = 12;
						if (smethod_189())
						{
							continue;
						}
						goto case 6;
					case 6:
						array4[18] = (byte)num17;
						goto case 101;
					case 101:
						array4[18] = 124;
						goto case 193;
					case 193:
						array4[18] = 156;
						num2 = 298;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 588:
						num17 = 97;
						goto case 449;
					case 449:
						array4[16] = (byte)num17;
						num = 426;
						goto case 426;
					case 426:
						num17 = 141;
						num2 = 657;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 587:
						array4[23] = (byte)num17;
						goto case 303;
					case 303:
						array4[23] = 42;
						goto case 341;
					case 341:
						array4[23] = 127;
						num2 = 149;
						if (smethod_189())
						{
							continue;
						}
						goto case 36;
					case 36:
						num17 = 160;
						num = 398;
						goto case 398;
					case 398:
						array4[31] = (byte)num17;
						goto case 367;
					case 367:
						num17 = 18;
						goto case 311;
					case 311:
						array4[31] = (byte)num17;
						num2 = 602;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 586:
						num17 = 54;
						goto case 653;
					case 548:
						smethod_185(smethod_184(smethod_175(object_17)));
						goto case 459;
					case 459:
						smethod_183(Class21.object_7);
						goto case 493;
					case 493:
						smethod_185(smethod_184(smethod_175(Class21.object_7)));
						goto case 64;
					case 64:
						array13 = null;
						goto case 375;
					case 375:
						if (smethod_115() != 4)
						{
							num2 = 384;
							if (smethod_189())
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 106;
					case 106:
						array22 = new byte[30];
						smethod_186(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array13 = array22;
						num2 = 288;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 4;
					case 4:
					case 309:
						intPtr3 = smethod_187(IntPtr.Zero, (uint)array13.Length, 4096u, 64u);
						num2 = 481;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 584:
						array3[5] = 116;
						num2 = 227;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 583:
						num17 = 92;
						goto case 183;
					case 183:
						array4[26] = (byte)num17;
						num = 117;
						goto case 117;
					case 117:
						num17 = 104;
						num = 314;
						goto case 314;
					case 314:
						array4[26] = (byte)num17;
						goto case 528;
					case 528:
						array4[26] = 119;
						goto case 308;
					case 308:
						array4[26] = 85;
						goto case 456;
					case 456:
						array4[26] = 121;
						num2 = 524;
						if (smethod_189())
						{
							continue;
						}
						goto case 232;
					case 232:
						num70 = smethod_146(object_4);
						goto case 614;
					case 580:
						array6[2] = (byte)num20;
						num = 174;
						goto case 174;
					case 174:
						array6[3] = 99;
						num = 666;
						goto case 666;
					case 579:
						array6[7] = (byte)num20;
						goto case 651;
					case 577:
						while (true)
						{
							IL_2138:
							fixed (byte* ptr = &array9[0])
							{
								while (true)
								{
									IL_1e6c:
									num18 = 0;
									while (num18 < num53)
									{
										while (true)
										{
											IL_1a28:
											num69 = (nint)(ptr + (nint)num18 * (nint)8);
											*(long*)num69 ^= 1304068455L;
											num2 = 56;
											if (smethod_190() == null)
											{
												goto IL_0031_3;
											}
											goto IL_0b1a_2;
											IL_0031_3:
											while (true)
											{
												switch (num2)
												{
												case 437:
													break;
												case 644:
													if (!bool_0)
													{
														num = 643;
														goto case 643;
													}
													goto case 196;
												case 643:
													bool_0 = true;
													num2 = 642;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 667:
													array4[2] = 174;
													goto case 335;
												case 335:
													array4[2] = 87;
													num2 = 247;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 153;
												case 153:
													num17 = 125;
													num = 505;
													goto case 505;
												case 505:
													array4[19] = (byte)num17;
													goto case 159;
												case 159:
													num17 = 193;
													goto case 315;
												case 315:
													array4[19] = (byte)num17;
													num2 = 139;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 666:
													array6[3] = 125;
													goto case 330;
												case 330:
													num20 = 131;
													goto case 346;
												case 346:
													array6[3] = (byte)num20;
													goto case 189;
												case 189:
													num20 = 138;
													goto case 617;
												case 617:
													array6[4] = (byte)num20;
													goto case 85;
												case 85:
													num20 = 175;
													goto case 632;
												case 632:
													array6[4] = (byte)num20;
													num2 = 485;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 665:
													num17 = 154;
													goto case 58;
												case 58:
													array4[28] = (byte)num17;
													goto case 411;
												case 411:
													array4[28] = 13;
													goto case 440;
												case 440:
													num17 = 111;
													num = 605;
													goto case 605;
												case 605:
													array4[29] = (byte)num17;
													num2 = 542;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 628;
												case 628:
													num17 = 137;
													goto case 324;
												case 324:
													array4[29] = (byte)num17;
													goto case 598;
												case 598:
													num17 = 224;
													goto case 267;
												case 267:
													array4[29] = (byte)num17;
													num2 = 315;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 358;
												case 358:
													num17 = 151;
													num2 = 570;
													if (smethod_189())
													{
														continue;
													}
													goto case 192;
												case 192:
													if (num19 > 0)
													{
														goto case 631;
													}
													goto case 63;
												case 631:
													num21 <<= 8;
													goto case 35;
												case 35:
													num28 += 8;
													num2 = 63;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 63:
													array18[num57 + num19] = (byte)((num52 & num21) >> num28);
													num2 = 57;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 664:
													array6[9] = 48;
													num2 = 73;
													if (!smethod_189())
													{
														continue;
													}
													goto case 478;
												case 478:
													num20 = 164;
													goto case 211;
												case 211:
													array6[10] = (byte)num20;
													num = 391;
													goto case 391;
												case 391:
													num20 = 96;
													goto case 572;
												case 572:
													array6[10] = (byte)num20;
													num2 = 144;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 663:
													array6[13] = 187;
													goto case 554;
												case 554:
													array6[13] = 91;
													goto case 507;
												case 507:
													num20 = 86;
													goto case 115;
												case 115:
													array6[14] = (byte)num20;
													num2 = 425;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 662:
													array6[7] = (byte)num20;
													num2 = 422;
													if (smethod_189())
													{
														continue;
													}
													goto case 260;
												case 260:
													num17 = 125;
													num2 = 318;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 661:
													num26++;
													num2 = 301;
													if (!smethod_189())
													{
														continue;
													}
													goto case 407;
												case 325:
													smethod_159(new IntPtr(intptr_.ToInt64() + num26 * 4), smethod_146(object_4));
													goto case 661;
												case 407:
												case 543:
													if (num26 < num16)
													{
														goto case 325;
													}
													num2 = 383;
													if (smethod_189())
													{
														continue;
													}
													goto default;
												default:
													intPtr = smethod_143(((object[])smethod_142(smethod_162(typeof(Class21).TypeHandle).Assembly))[0]);
													num2 = 374;
													if (smethod_189())
													{
														continue;
													}
													goto case 25;
												case 25:
													if (flag)
													{
														num2 = 545;
														if (smethod_189())
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 504;
												case 660:
													num20 = 164;
													num2 = 82;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 659:
													num29 += num30;
													goto case 514;
												case 514:
													num22 = (uint)((array17[num34 + 3] << 24) | (array17[num34 + 2] << 16) | (array17[num34 + 1] << 8) | array17[num34]);
													num2 = 357;
													if (smethod_189())
													{
														continue;
													}
													goto case 133;
												case 133:
													array4[4] = 120;
													goto case 203;
												case 203:
													num17 = 168;
													goto case 510;
												case 510:
													array4[4] = (byte)num17;
													goto case 417;
												case 417:
													array4[4] = 116;
													num2 = 54;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 658:
													array4[14] = (byte)num17;
													num2 = 634;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 657:
													array4[16] = (byte)num17;
													goto case 491;
												case 491:
													num17 = 76;
													num2 = 160;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 469;
												case 469:
													array4[17] = (byte)num17;
													goto case 125;
												case 125:
													num17 = 60;
													num2 = 61;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 656:
													array6[11] = 101;
													num2 = 228;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 261:
												case 655:
													if (smethod_115() == 4)
													{
														num2 = 144;
														if (smethod_190() != null)
														{
															continue;
														}
														goto case 301;
													}
													goto case 277;
												case 301:
													num3 = 9;
													goto case 401;
												case 401:
													array[num3] = array10[0];
													num2 = 151;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 277:
													num25 = 2;
													num2 = 85;
													if (!smethod_189())
													{
														continue;
													}
													goto case 292;
												case 292:
													array[num25] = array10[0];
													num2 = 538;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 329;
												case 329:
													array4[25] = 168;
													goto case 141;
												case 141:
													array4[25] = 109;
													num2 = 129;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 654:
													array2 = null;
													goto case 248;
												case 248:
													array10 = null;
													goto case 381;
												case 381:
													if (smethod_115() == 4)
													{
														goto case 142;
													}
													goto case 99;
												case 142:
													array10 = (byte[])smethod_157(Class21.intptr_2.ToInt32());
													num2 = 597;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 99:
													array10 = (byte[])smethod_182(Class21.intptr_2.ToInt64());
													goto case 471;
												case 471:
													array15 = (byte[])smethod_182(zero.ToInt64());
													goto case 306;
												case 306:
													array2 = (byte[])smethod_182(num8);
													goto case 261;
												case 653:
													array4[27] = (byte)num17;
													num2 = 235;
													if (!smethod_189())
													{
														continue;
													}
													goto case 537;
												case 537:
													num17 = 158;
													goto case 432;
												case 432:
													array4[28] = (byte)num17;
													goto case 665;
												case 652:
													num8 = smethod_170(new IntPtr(value));
													num2 = 419;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 651:
													array6[7] = 114;
													goto case 472;
												case 472:
													array6[7] = 113;
													goto case 349;
												case 349:
													array6[7] = 140;
													num2 = 495;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 627;
												case 627:
													num20 = 149;
													goto case 662;
												case 650:
													int_ = 0;
													goto case 365;
												case 365:
													num38 = 0;
													num = 595;
													goto case 595;
												case 595:
													if (smethod_144(Class21.object_5) != null)
													{
														goto case 72;
													}
													num2 = 118;
													if (!smethod_189())
													{
														continue;
													}
													goto case 121;
												case 72:
													if (smethod_145(smethod_144(Class21.object_5)) == 0)
													{
														goto case 121;
													}
													goto case 544;
												case 121:
												case 390:
													num38 = 7680;
													num2 = 488;
													if (!smethod_189())
													{
														continue;
													}
													goto case 544;
												case 544:
													num56 = smethod_146(object_4);
													num2 = 636;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 649:
													num17 = 166;
													num2 = 609;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 648:
													array[num25 + 7] = array10[7];
													goto case 175;
												case 175:
													num25 = 18;
													goto case 274;
												case 274:
													array[num25] = array2[0];
													goto case 578;
												case 578:
													array[num25 + 1] = array2[1];
													num2 = 191;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 647:
													array4[5] = 154;
													num2 = 118;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 646:
													num20 = 226;
													num = 566;
													goto case 566;
												case 566:
													array6[2] = (byte)num20;
													goto case 60;
												case 60:
													array6[2] = 138;
													num2 = 93;
													if (smethod_189())
													{
														continue;
													}
													goto case 88;
												case 88:
													array4[16] = 110;
													num2 = 588;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 557;
												case 557:
													array4[6] = 114;
													goto case 168;
												case 168:
													array4[6] = 156;
													num2 = 230;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 645:
													array4[9] = 120;
													num = 137;
													goto case 137;
												case 137:
													num17 = 165;
													num = 69;
													goto case 69;
												case 69:
													array4[9] = (byte)num17;
													goto case 441;
												case 441:
													num17 = 19;
													num2 = 98;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 642:
													num60 = 4059231220u;
													goto case 132;
												case 132:
													num15 = 0L;
													goto case 231;
												case 231:
													smethod_100(new IntPtr(&num15), 0);
													goto case 368;
												case 368:
													smethod_101(new IntPtr(&num15), 0);
													goto case 11;
												case 11:
													do
													{
														smethod_102(new IntPtr(&num15), 0);
														num2 = 24;
													}
													while (!smethod_189());
													continue;
												case 641:
													if (smethod_117(smethod_116("System.Reflection.ReflectionContext", bool_7: false), null))
													{
														num2 = 262;
														if (smethod_190() != null)
														{
															continue;
														}
														goto case 364;
													}
													goto case 541;
												case 364:
													object_16 = (ProcessModuleCollection)smethod_118(smethod_109());
													goto case 573;
												case 573:
													enumerator = (IEnumerator)smethod_119(object_16);
													num2 = 623;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 541:
													object_4 = new Class24((Stream)smethod_133(Class21.object_5, "75l\u0088\u0098\u0086\u008d0\u0097\u0090\u009dtgf\u008e\u009awa.\u009a0\u009d\u0089\u008b\u0090\u008exnji\u0093j\u009f\u008f\u0097\u009d\u0095"));
													num2 = 547;
													if (smethod_189())
													{
														continue;
													}
													goto case 547;
												case 547:
													smethod_135(smethod_134(object_4), 0L);
													goto case 618;
												case 618:
													array14 = (byte[])smethod_137(object_4, (int)smethod_136(smethod_134(object_4)));
													goto case 10;
												case 10:
													array4 = new byte[32];
													num2 = 649;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 640:
													array[num25 + 3] = array15[3];
													goto case 181;
												case 181:
													array[num25 + 4] = array15[4];
													goto case 188;
												case 188:
													array[num25 + 5] = array15[5];
													goto case 312;
												case 312:
													array[num25 + 6] = array15[6];
													goto case 148;
												case 148:
													array[num25 + 7] = array15[7];
													goto case 244;
												case 244:
												case 278:
													smethod_107(array, 0, intPtr3, array.Length);
													num = 184;
													goto case 184;
												case 184:
													bool_4 = false;
													goto case 534;
												case 534:
													smethod_27(new IntPtr(value), smethod_115(), 64, ref int_3);
													goto case 265;
												case 265:
													smethod_188(new IntPtr(value), intPtr3);
													goto case 436;
												case 436:
													smethod_27(new IntPtr(value), smethod_115(), int_3, ref int_3);
													num2 = 196;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 639:
													array4[10] = 147;
													num2 = 119;
													if (!smethod_189())
													{
														continue;
													}
													goto case 146;
												case 146:
													array4[10] = 116;
													goto case 356;
												case 356:
													num17 = 149;
													num2 = 75;
													if (!smethod_189())
													{
														continue;
													}
													goto case 83;
												case 83:
													array4[10] = (byte)num17;
													goto case 603;
												case 603:
													num17 = 51;
													goto case 34;
												case 34:
													array4[10] = (byte)num17;
													goto case 372;
												case 372:
													array4[11] = 174;
													goto case 345;
												case 345:
													array4[11] = 152;
													goto case 239;
												case 239:
													num17 = 93;
													goto case 307;
												case 307:
													array4[11] = (byte)num17;
													goto case 461;
												case 461:
													array4[11] = 84;
													goto case 477;
												case 477:
													array4[11] = 251;
													goto case 33;
												case 33:
													array4[12] = 134;
													goto case 494;
												case 494:
													num17 = 143;
													num = 283;
													goto case 283;
												case 283:
													array4[12] = (byte)num17;
													goto case 286;
												case 286:
													num17 = 160;
													goto case 593;
												case 593:
													array4[12] = (byte)num17;
													num2 = 68;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 638:
													num17 = 146;
													goto case 86;
												case 86:
													array4[14] = (byte)num17;
													num2 = 47;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 637:
													array3[9] = 108;
													num2 = 416;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 636:
													num58 = smethod_146(object_4);
													goto case 216;
												case 216:
													if (num58 == 4)
													{
														num2 = 163;
														if (smethod_189())
														{
															continue;
														}
														goto case 112;
													}
													goto case 564;
												case 112:
													array3[2] = 114;
													num2 = 40;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 564:
													if (num58 == 1)
													{
														goto case 187;
													}
													num55 = 0;
													goto case 221;
												case 187:
													intptr_4 = IntPtr.Zero;
													num = 109;
													goto case 109;
												case 109:
													uint_ = (Enum7)56;
													num2 = 338;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 240;
												case 240:
													array6[15] = 102;
													goto case 615;
												case 615:
													array6[15] = 156;
													goto case 105;
												case 105:
													array6[15] = 161;
													goto case 328;
												case 328:
													array6[15] = 25;
													goto case 202;
												case 202:
													array8 = array6;
													goto case 190;
												case 190:
													smethod_138(array8);
													goto case 266;
												case 266:
													array11 = (byte[])smethod_140(smethod_139(Class21.object_5));
													num2 = 517;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 221:
												case 604:
													if (num55 >= num56)
													{
														goto case 294;
													}
													goto case 299;
												case 294:
													Class21.object_4 = new Hashtable(smethod_146(object_4) + 1);
													goto case 451;
												case 451:
													struct2 = default(Struct15);
													num2 = 257;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 213;
												case 213:
													array[num3 + 3] = array15[3];
													goto case 244;
												case 299:
													intptr_3 = new IntPtr(num31 + smethod_146(object_4) - num38);
													num2 = 195;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 635:
													if (num33 == num51 - 1)
													{
														num2 = 136;
														if (smethod_190() == null)
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 77;
												case 77:
													num34 = (uint)num57;
													goto case 659;
												case 634:
													num17 = 145;
													num2 = 420;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 633:
													num17 = 237;
													num2 = 180;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 194;
												case 194:
													array4[0] = (byte)num17;
													num = 626;
													goto case 626;
												case 626:
													num17 = 163;
													num2 = 234;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 630:
													array8[3] = array11[1];
													goto case 222;
												case 222:
													array8[5] = array11[2];
													num2 = 553;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 136;
												case 136:
													if (num24 > 0)
													{
														num2 = 288;
														if (smethod_190() == null)
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 77;
												case 625:
													num17 = 23;
													num2 = 575;
													if (smethod_189())
													{
														continue;
													}
													goto case 221;
												case 624:
													array4[9] = 110;
													num2 = 645;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 623:
													try
													{
														while (smethod_131(enumerator))
														{
															while (true)
															{
																ProcessModule object_12 = (ProcessModule)smethod_120(enumerator);
																while (true)
																{
																	IL_18e9_2:
																	if (smethod_123(smethod_122(smethod_121(object_12)), "clrjit.dll"))
																	{
																		goto IL_1887_2;
																	}
																	num72 = 0;
																	if (smethod_190() == null)
																	{
																		goto IL_184d_3;
																	}
																	goto IL_18cb_2;
																	IL_184d_3:
																	while (true)
																	{
																		switch (num72)
																		{
																		case 9:
																			if (smethod_130(object_14, object_13))
																			{
																				num72 = 3;
																				if (smethod_189())
																				{
																					continue;
																				}
																				goto IL_18e9_2;
																			}
																			goto end_IL_1903_2;
																		case 5:
																			object_15 = new Version(4, 0, 30319, 17020);
																			num72 = 1;
																			if (smethod_189())
																			{
																				continue;
																			}
																			goto end_IL_1903_2;
																		case 4:
																			if (!smethod_129(object_14, object_15))
																			{
																				goto end_IL_1903_2;
																			}
																			goto case 9;
																		case 1:
																			object_13 = new Version(4, 0, 30319, 17921);
																			goto case 4;
																		case 11:
																			break;
																		case 2:
																			goto IL_18e9_2;
																		case 10:
																			goto end_IL_18e9_2;
																		default:
																			goto end_IL_1903_2;
																		case 3:
																			bool_6 = true;
																			goto end_IL_1914_2;
																		case 6:
																		case 8:
																			goto end_IL_1914_2;
																		}
																		break;
																	}
																	goto IL_1887_2;
																	IL_1887_2:
																	object_14 = new Version(smethod_125(smethod_124(object_12)), smethod_126(smethod_124(object_12)), smethod_127(smethod_124(object_12)), smethod_128(smethod_124(object_12)));
																	num72 = 5;
																	if (smethod_189())
																	{
																		goto IL_184d_3;
																	}
																	goto IL_18cb_2;
																	IL_18cb_2:
																	num72 = num73;
																	goto IL_184d_3;
																	continue;
																	end_IL_18e9_2:
																	break;
																}
																continue;
																end_IL_1903_2:
																break;
															}
															continue;
															end_IL_1914_2:
															break;
														}
													}
													finally
													{
														IDisposable disposable = enumerator as IDisposable;
														while (disposable != null)
														{
															num74 = 1;
															if (!smethod_189())
															{
																break;
															}
															while (true)
															{
																switch (num74)
																{
																case 1:
																	smethod_132(disposable);
																	num74 = 0;
																	if (smethod_190() != null)
																	{
																		num74 = num75;
																	}
																	continue;
																default:
																	goto end_IL_195b_2;
																case 2:
																	break;
																case 0:
																	goto end_IL_195b_2;
																}
																goto IL_196e_2;
																continue;
																end_IL_195b_2:
																break;
															}
															break;
															IL_196e_2:;
														}
													}
													goto case 541;
												case 622:
													array[num25 + 2] = array15[2];
													num2 = 165;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 640;
												case 621:
													num51++;
													num2 = 135;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 415:
												case 620:
													goto IL_19b1;
												case 102:
													object_4 = new Class24(new MemoryStream(array7));
													num = 377;
													goto case 377;
												case 377:
													smethod_135(smethod_134(object_4), 0L);
													goto case 131;
												case 131:
													intPtr = smethod_143(((object[])smethod_142(Class21.object_5))[0]);
													goto case 140;
												case 140:
													num31 = intPtr.ToInt64();
													num2 = 378;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 650;
												case 331:
													goto IL_1a28;
												case 619:
													array[num25 + 1] = array15[1];
													goto case 622;
												case 616:
													array4[9] = (byte)num17;
													goto case 624;
												case 614:
													intptr_ = new IntPtr(long_0 + num70 - num38);
													num2 = 37;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 613:
													num17 = 237;
													goto case 431;
												case 431:
													array4[29] = (byte)num17;
													goto case 95;
												case 95:
													num17 = 13;
													num2 = 342;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 612:
													num17 = 219;
													goto case 499;
												case 499:
													array4[4] = (byte)num17;
													num2 = 447;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 611:
													text = (string)smethod_165(smethod_164(), array3);
													num2 = 520;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 610:
													num34 = (uint)(num71 * 4);
													num2 = 161;
													if (!smethod_189())
													{
														continue;
													}
													goto case 526;
												case 526:
													num30 = (uint)((array19[num34 + 3] << 24) | (array19[num34 + 2] << 16) | (array19[num34 + 1] << 8) | array19[num34]);
													num2 = 92;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 609:
													array4[0] = (byte)num17;
													goto case 166;
												case 166:
													num17 = 105;
													goto case 465;
												case 465:
													array4[0] = (byte)num17;
													goto case 448;
												case 448:
													num17 = 203;
													num2 = 6;
													if (!smethod_189())
													{
														continue;
													}
													goto case 160;
												case 160:
													array4[0] = (byte)num17;
													num2 = 633;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 608:
													array4[22] = 172;
													goto case 516;
												case 516:
													num17 = 86;
													num2 = 284;
													if (smethod_189())
													{
														continue;
													}
													goto case 47;
												case 47:
													array4[14] = 134;
													num2 = 150;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 607:
													num71 = num33 % num54;
													goto case 599;
												case 599:
													num57 = num33 * 4;
													goto case 610;
												case 606:
													@struct.bool_0 = flag2;
													num2 = 326;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 602:
													array19 = array4;
													num2 = 150;
													if (!smethod_189())
													{
														continue;
													}
													goto case 243;
												case 243:
													array6 = new byte[16];
													num = 50;
													goto case 50;
												case 50:
													num20 = 120;
													num = 569;
													goto case 569;
												case 569:
													array6[0] = (byte)num20;
													goto case 108;
												case 108:
													array6[0] = 158;
													goto case 29;
												case 29:
													array6[0] = 112;
													goto case 65;
												case 65:
													array6[0] = 203;
													goto case 445;
												case 445:
													array6[0] = 52;
													num2 = 162;
													if (!smethod_189())
													{
														continue;
													}
													goto case 302;
												case 302:
													num20 = 100;
													goto case 532;
												case 532:
													array6[1] = (byte)num20;
													goto case 582;
												case 582:
													array6[1] = 103;
													num2 = 121;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 581;
												case 581:
													num20 = 173;
													num2 = 366;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 601:
													array4[24] = 42;
													goto case 329;
												case 600:
													num20 = 115;
													num2 = 579;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 597:
													array15 = (byte[])smethod_157(zero.ToInt32());
													num2 = 219;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 596:
													array6[8] = (byte)num20;
													num = 293;
													goto case 293;
												case 293:
													array6[8] = 158;
													num2 = 313;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 594:
													num20 = 166;
													goto case 396;
												case 396:
													array6[12] = (byte)num20;
													goto case 373;
												case 373:
													num20 = 58;
													goto case 497;
												case 497:
													array6[12] = (byte)num20;
													num2 = 424;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 592:
													num17 = 147;
													num2 = 450;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 490;
												case 490:
													array4[7] = (byte)num17;
													num2 = 1;
													if (!smethod_189())
													{
														continue;
													}
													goto case 1;
												case 1:
													array4[7] = 139;
													goto case 48;
												case 48:
													array4[7] = 66;
													goto case 370;
												case 370:
													array4[8] = 137;
													num2 = 404;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 290:
												case 591:
													goto IL_1e6c;
												case 590:
													transform = (ICryptoTransform)smethod_149(object_5, array19, array8);
													goto case 18;
												case 18:
													smethod_141(array19, 0, array19.Length);
													num2 = 176;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 589:
													num17 = 43;
													num2 = 12;
													if (smethod_189())
													{
														continue;
													}
													goto case 6;
												case 6:
													array4[18] = (byte)num17;
													goto case 101;
												case 101:
													array4[18] = 124;
													goto case 193;
												case 193:
													array4[18] = 156;
													num2 = 298;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 588:
													num17 = 97;
													goto case 449;
												case 449:
													array4[16] = (byte)num17;
													num = 426;
													goto case 426;
												case 426:
													num17 = 141;
													num2 = 657;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 587:
													array4[23] = (byte)num17;
													goto case 303;
												case 303:
													array4[23] = 42;
													goto case 341;
												case 341:
													array4[23] = 127;
													num2 = 149;
													if (smethod_189())
													{
														continue;
													}
													goto case 36;
												case 36:
													num17 = 160;
													num = 398;
													goto case 398;
												case 398:
													array4[31] = (byte)num17;
													goto case 367;
												case 367:
													num17 = 18;
													goto case 311;
												case 311:
													array4[31] = (byte)num17;
													num2 = 602;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 586:
													num17 = 54;
													goto case 653;
												case 548:
													smethod_185(smethod_184(smethod_175(object_17)));
													goto case 459;
												case 459:
													smethod_183(Class21.object_7);
													goto case 493;
												case 493:
													smethod_185(smethod_184(smethod_175(Class21.object_7)));
													goto case 64;
												case 64:
													array13 = null;
													goto case 375;
												case 375:
													if (smethod_115() != 4)
													{
														num2 = 384;
														if (smethod_189())
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 106;
												case 106:
													array22 = new byte[30];
													smethod_186(array22, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
													array13 = array22;
													num2 = 288;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 4;
												case 4:
												case 309:
													intPtr3 = smethod_187(IntPtr.Zero, (uint)array13.Length, 4096u, 64u);
													num2 = 481;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 584:
													array3[5] = 116;
													num2 = 227;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 583:
													num17 = 92;
													goto case 183;
												case 183:
													array4[26] = (byte)num17;
													num = 117;
													goto case 117;
												case 117:
													num17 = 104;
													num = 314;
													goto case 314;
												case 314:
													array4[26] = (byte)num17;
													goto case 528;
												case 528:
													array4[26] = 119;
													goto case 308;
												case 308:
													array4[26] = 85;
													goto case 456;
												case 456:
													array4[26] = 121;
													num2 = 524;
													if (smethod_189())
													{
														continue;
													}
													goto case 232;
												case 232:
													num70 = smethod_146(object_4);
													goto case 614;
												case 580:
													array6[2] = (byte)num20;
													num = 174;
													goto case 174;
												case 174:
													array6[3] = 99;
													num = 666;
													goto case 666;
												case 579:
													array6[7] = (byte)num20;
													goto case 651;
												case 577:
													goto IL_2138;
												case 576:
													if (smethod_174(smethod_173(smethod_162(typeof(Class21).TypeHandle).Assembly), null))
													{
														goto case 204;
													}
													goto case 173;
												case 204:
													if (((Array)smethod_177(smethod_173(smethod_162(typeof(Class21).TypeHandle).Assembly))).Length == 2)
													{
														goto case 198;
													}
													goto case 173;
												case 198:
													if (smethod_144(smethod_162(typeof(Class21).TypeHandle).Assembly) != null)
													{
														goto case 287;
													}
													goto case 173;
												case 287:
													if (smethod_145(smethod_144(smethod_162(typeof(Class21).TypeHandle).Assembly)) <= 0)
													{
														goto case 173;
													}
													num2 = 197;
													if (!smethod_189())
													{
														continue;
													}
													goto case 484;
												case 173:
												case 207:
												case 238:
													try
													{
														object obj5 = smethod_181(smethod_180(smethod_179(smethod_178(smethod_162(typeof(Class21).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), smethod_179(smethod_178(smethod_162(typeof(Class21).TypeHandle).Assembly)));
														num61 = 8;
														if (smethod_190() != null)
														{
															goto IL_224a;
														}
														goto IL_23d8;
														IL_23d8:
														while (true)
														{
															switch (num61)
															{
															case 4:
															case 19:
																object_11 = new MemoryStream();
																num61 = 15;
																if (smethod_189())
																{
																	continue;
																}
																break;
															case 9:
															case 18:
																smethod_150(object_11, new byte[smethod_115()], 0, smethod_115());
																goto case 7;
															case 7:
																smethod_150(object_11, new byte[smethod_115()], 0, smethod_115());
																num61 = 2;
																if (smethod_189())
																{
																	continue;
																}
																break;
															case 17:
																smethod_150(object_11, smethod_182(Class21.intptr_2.ToInt64()), 0, 8);
																goto case 9;
															case 16:
																smethod_150(object_11, smethod_157(Class21.intptr_2.ToInt32()), 0, 4);
																num61 = 18;
																if (smethod_190() == null)
																{
																	continue;
																}
																goto case 7;
															case 15:
																smethod_150(object_11, new byte[smethod_115()], 0, smethod_115());
																goto case 14;
															case 14:
																if (smethod_115() != 4)
																{
																	goto case 17;
																}
																num66 = 16;
																goto case 16;
															case 13:
																smethod_153(object_11);
																num61 = 0;
																if (smethod_190() == null)
																{
																	continue;
																}
																break;
															case 12:
																array20 = (byte[])smethod_152(object_11);
																num61 = 5;
																if (!smethod_189())
																{
																	continue;
																}
																goto case 13;
															case 11:
																Class21.intptr_2 = (IntPtr)smethod_181(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
																goto case 4;
															case 10:
																Class21.intptr_2 = (IntPtr)obj5;
																num61 = 3;
																if (smethod_190() == null)
																{
																	continue;
																}
																break;
															case 8:
																if (obj5 is IntPtr)
																{
																	goto case 10;
																}
																goto case 3;
															case 3:
															case 6:
																if (!smethod_123(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
																{
																	num66 = 4;
																	goto case 4;
																}
																goto case 11;
															case 2:
																smethod_135(object_11, 0L);
																goto case 12;
															default:
																nativeSizeOfCode = 0u;
																num61 = 1;
																if (smethod_190() == null)
																{
																	continue;
																}
																break;
															case 1:
																try
																{
																	array21 = (array9 = array20);
																	if (array21 != null)
																	{
																		num62 = 0;
																		if (smethod_189())
																		{
																			goto IL_2449;
																		}
																		goto IL_24b5;
																	}
																	goto IL_24bb;
																	IL_2449:
																	switch (num62)
																	{
																	default:
																		if (array9.Length != 0)
																		{
																			goto case 1;
																		}
																		goto IL_24bb;
																	case 1:
																		while (true)
																		{
																			fixed (byte* value2 = &array9[0])
																			{
																				while (true)
																				{
																					Class21.object_7(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
																					num62 = 3;
																					if (smethod_190() != null)
																					{
																						num62 = num63;
																					}
																					switch (num62)
																					{
																					case 1:
																						break;
																					default:
																						if (array9.Length == 0)
																						{
																							goto end_IL_246c;
																						}
																						break;
																					case 2:
																					case 4:
																						continue;
																					case 5:
																						goto end_IL_246c;
																					case 3:
																						goto end_IL_2430;
																					}
																					break;
																				}
																			}
																			continue;
																			end_IL_246c:
																			break;
																		}
																		goto IL_24bb;
																	case 2:
																	case 4:
																		break;
																	case 5:
																		goto IL_24bb;
																	case 3:
																		goto end_IL_2430;
																	}
																	goto IL_2476_2;
																	IL_24bb:
																	reference2 = ref *(byte*)null;
																	num63 = 4;
																	goto IL_2476_2;
																	IL_2476_2:
																	Class21.object_7(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
																	num62 = 3;
																	if (smethod_190() == null)
																	{
																		goto IL_2449;
																	}
																	goto IL_24b5;
																	IL_24b5:
																	num62 = num63;
																	goto IL_2449;
																	end_IL_2430:;
																}
																finally
																{
																	reference2 = ref *(byte*)null;
																	num64 = 0;
																	if (smethod_190() != null)
																	{
																		num64 = num65;
																	}
																	switch (num64)
																	{
																	}
																}
																goto end_IL_23d8;
															case 5:
																goto end_IL_23d8;
															}
															goto IL_224a;
															continue;
															end_IL_23d8:
															break;
														}
														goto end_IL_21cd;
														IL_224a:
														num61 = num66;
														goto IL_23d8;
														end_IL_21cd:;
													}
													catch (object obj6)
													{
														num67 = 0;
														if (smethod_190() != null)
														{
															num67 = num68;
														}
														switch (num67)
														{
														}
													}
													goto case 585;
												case 575:
													array4[8] = (byte)num17;
													goto case 43;
												case 43:
													num17 = 60;
													num = 214;
													goto case 214;
												case 214:
													array4[8] = (byte)num17;
													num2 = 49;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 574:
													if (num60 == 4109628145u)
													{
														num2 = 45;
														if (smethod_190() == null)
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 545;
												case 545:
													if (smethod_115() == 4)
													{
														num2 = 641;
														if (smethod_190() == null)
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 541;
												case 571:
													array3[10] = 108;
													goto case 259;
												case 259:
													array3[11] = 108;
													goto case 611;
												case 570:
													array4[29] = (byte)num17;
													num = 613;
													goto case 613;
												case 546:
												case 568:
													if (num43 >= array8.Length)
													{
														goto case 408;
													}
													goto case 268;
												case 408:
													array17 = array14;
													goto case 235;
												case 235:
													num24 = array17.Length % 4;
													num2 = 535;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 319;
												case 319:
													array6[4] = 159;
													num2 = 51;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 268:
													array19[num43] = (byte)(array19[num43] ^ array8[num43]);
													num2 = 479;
													if (smethod_189())
													{
														continue;
													}
													goto case 305;
												case 305:
													num59 = num29 ^ num22;
													num2 = 44;
													if (!smethod_189())
													{
														continue;
													}
													goto case 122;
												case 122:
													array18[num57] = (byte)(num59 & 0xFFu);
													goto case 460;
												case 460:
													array18[num57 + 1] = (byte)((num59 & 0xFF00) >> 8);
													num = 549;
													goto case 549;
												case 549:
													array18[num57 + 2] = (byte)((num59 & 0xFF0000) >> 16);
													goto case 352;
												case 352:
													array18[num57 + 3] = (byte)((num59 & 0xFF000000u) >> 24);
													num2 = 62;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 567:
													num17 = 163;
													goto case 527;
												case 527:
													array4[15] = (byte)num17;
													goto case 70;
												case 70:
													array4[15] = 199;
													goto case 88;
												case 565:
													array6[9] = 104;
													num2 = 242;
													if (smethod_189())
													{
														continue;
													}
													goto case 124;
												case 124:
													smethod_154(object_4);
													goto case 529;
												case 529:
													num56 = smethod_146(object_4);
													goto case 518;
												case 518:
													num58 = smethod_146(object_4);
													num2 = 564;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 563:
													array4[1] = (byte)num17;
													goto case 667;
												case 379:
												case 562:
													smethod_27(intPtr2, 4, int_, ref int_);
													num2 = 236;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 561:
													smethod_105(new IntPtr(&num15), 0, 0L);
													goto case 157;
												case 157:
													array9 = new byte[1];
													num2 = 145;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 186:
												case 560:
													if (num27 >= num56)
													{
														goto case 155;
													}
													goto case 385;
												case 155:
												case 249:
													if (smethod_158(smethod_134(object_4)) < smethod_136(smethod_134(object_4)) - 1L)
													{
														num2 = 232;
														if (smethod_189())
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 353;
												case 353:
													smethod_160(intptr_4);
													num2 = 531;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 385:
													intPtr2 = new IntPtr(long_0 + smethod_146(object_4) - num38);
													goto case 317;
												case 317:
													smethod_27(intPtr2, 4, 4, ref int_);
													goto case 297;
												case 297:
													if (smethod_115() == 4)
													{
														num2 = 220;
														if (smethod_189())
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 123;
												case 123:
													smethod_26(intptr_4, intPtr2, (byte[])smethod_157(smethod_146(object_4)), 4u, out intptr_5);
													num2 = 379;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 559:
													array[num3 + 2] = array10[2];
													num2 = 464;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 256;
												case 256:
													array3[1] = 108;
													goto case 112;
												case 556:
													array6[12] = 109;
													goto case 270;
												case 270:
													num20 = 116;
													num2 = 217;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 555:
													smethod_27(intptr_3, 4, int_, ref int_);
													goto case 100;
												case 100:
													num55++;
													num2 = 221;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 553:
													array8[7] = array11[3];
													num2 = 384;
													if (!smethod_189())
													{
														continue;
													}
													goto case 423;
												case 423:
													array8[9] = array11[4];
													goto case 395;
												case 395:
													array8[11] = array11[5];
													num = 405;
													goto case 405;
												case 405:
													array8[13] = array11[6];
													goto case 262;
												case 262:
													array8[15] = array11[7];
													num2 = 252;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 552:
													flag2 = false;
													num2 = 387;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 551:
													array6[6] = (byte)num20;
													goto case 223;
												case 223:
													array6[6] = 164;
													num = 14;
													goto case 14;
												case 14:
													array6[6] = 94;
													goto case 254;
												case 254:
													num20 = 164;
													num = 508;
													goto case 508;
												case 508:
													array6[6] = (byte)num20;
													num2 = 84;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 550:
													array[num25 + 6] = array2[6];
													num2 = 433;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 40;
												case 40:
													array3[3] = 106;
													num2 = 42;
													if (smethod_189())
													{
														continue;
													}
													goto case 38;
												case 38:
													num20 = 150;
													num2 = 596;
													if (smethod_189())
													{
														continue;
													}
													goto case 346;
												case 542:
													zero = IntPtr.Zero;
													goto case 80;
												case 80:
													zero = smethod_171(Class21.object_7);
													num = 143;
													goto case 143;
												case 143:
													num8 = 0L;
													goto case 336;
												case 336:
													if (smethod_115() != 4)
													{
														goto case 652;
													}
													goto case 380;
												case 380:
													num8 = smethod_169(new IntPtr(value));
													goto case 30;
												case 30:
												case 419:
													object_ = (Process)smethod_109();
													num2 = 9;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 540:
													smethod_159(intptr_3, smethod_146(object_4));
													goto case 555;
												case 539:
													array4[22] = (byte)num17;
													num2 = 10;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 32;
												case 32:
													num17 = 104;
													num2 = 67;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 587;
												case 538:
													array[num25 + 1] = array10[1];
													goto case 22;
												case 22:
													array[num25 + 2] = array10[2];
													goto case 470;
												case 470:
													array[num25 + 3] = array10[3];
													goto case 172;
												case 172:
													array[num25 + 4] = array10[4];
													goto case 410;
												case 410:
													array[num25 + 5] = array10[5];
													goto case 443;
												case 443:
													array[num25 + 6] = array10[6];
													num2 = 648;
													if (smethod_189())
													{
														continue;
													}
													goto IL_1e6c;
												case 536:
													array3[9] = 100;
													goto case 571;
												case 535:
													num51 = array17.Length / 4;
													num2 = 193;
													if (!smethod_189())
													{
														continue;
													}
													goto case 258;
												case 258:
													array18 = new byte[array17.Length];
													goto case 463;
												case 463:
													num54 = array19.Length / 4;
													num2 = 438;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 533:
													array4[24] = 18;
													goto case 119;
												case 119:
													array4[24] = 165;
													num2 = 601;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 531:
													smethod_114();
													num2 = 629;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 486:
												case 525:
													if (num33 < num51)
													{
														goto case 607;
													}
													goto case 273;
												case 273:
													array7 = array18;
													num = 457;
													goto case 457;
												case 457:
													num53 = array7.Length / 8;
													num2 = 473;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 524:
													array4[26] = 143;
													goto case 158;
												case 158:
													array4[27] = 155;
													num2 = 31;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 523:
													array4[15] = 105;
													num2 = 567;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 522:
													num19 = 0;
													goto case 316;
												case 316:
												case 458:
													if (num19 >= num24)
													{
														num2 = 337;
														if (smethod_189())
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 192;
												case 521:
													array3 = new byte[10];
													goto case 205;
												case 205:
													array3[0] = 99;
													goto case 256;
												case 520:
													intptr_6 = LoadLibrary(text);
													num2 = 406;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 519:
													num17 = 157;
													num2 = 469;
													if (!smethod_189())
													{
														continue;
													}
													goto case 658;
												case 517:
													if (array11 != null)
													{
														goto case 87;
													}
													goto case 476;
												case 87:
													if (array11.Length > 0)
													{
														goto case 487;
													}
													goto case 476;
												case 487:
													array8[1] = array11[0];
													num2 = 630;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 405;
												case 476:
													num43 = 0;
													goto case 546;
												case 515:
													num17 = 244;
													goto case 539;
												case 513:
													num17 = 151;
													num2 = 429;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 512:
													array4[2] = 149;
													goto case 434;
												case 434:
													array4[3] = 187;
													goto case 182;
												case 182:
													num17 = 122;
													goto case 488;
												case 488:
													array4[3] = (byte)num17;
													goto case 164;
												case 164:
													array4[3] = 47;
													goto case 2;
												case 2:
													array4[3] = 114;
													goto case 276;
												case 276:
													array4[3] = 187;
													goto case 589;
												case 511:
													num52 = num29 ^ num22;
													goto case 522;
												case 509:
													intptr_5 = IntPtr.Zero;
													num = 339;
													goto case 339;
												case 339:
													num27 = 0;
													goto case 186;
												case 506:
													int_3 = 0;
													num2 = 576;
													if (smethod_189())
													{
														continue;
													}
													goto case 141;
												case 503:
													array3[8] = 46;
													goto case 536;
												case 502:
													procAddress = GetProcAddress(intptr_6, string_);
													num2 = 340;
													if (smethod_189())
													{
														continue;
													}
													goto case 10;
												case 357:
												case 501:
													num29 = num29;
													goto case 371;
												case 371:
												{
													num49 = num29;
													uint num50 = num29;
													num50 ^= num50 << 1;
													num50 += 386210582;
													num50 ^= num50 >> 27;
													num50 += 2785290990u;
													num50 ^= num50 << 27;
													num50 += 3921027779u;
													num50 = 593091361 - num50;
													num29 = num49 + (uint)(double)num50;
													num = 23;
													goto case 23;
												}
												case 23:
													if (num33 == num51 - 1)
													{
														num2 = 180;
														if (smethod_189())
														{
															continue;
														}
														goto IL_0b1a_2;
													}
													goto case 305;
												case 500:
													num22 |= array17[^(1 + num23)];
													goto case 170;
												case 170:
													num23++;
													goto case 322;
												case 67:
													if (num23 <= 0)
													{
														goto case 500;
													}
													num = 16;
													goto case 16;
												case 16:
													num22 <<= 8;
													goto case 500;
												case 322:
												case 482:
													if (num23 >= num24)
													{
														goto case 357;
													}
													goto case 67;
												case 498:
													array4[30] = 115;
													num2 = 201;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 496:
													array[num3 + 3] = array2[3];
													num2 = 453;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 495:
													array5[0] = 103;
													goto case 206;
												case 206:
													array5[1] = 101;
													num2 = 354;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 218;
												case 218:
													if (smethod_115() == 4)
													{
														goto case 378;
													}
													goto case 21;
												case 378:
													value = smethod_169(intptr_2);
													num2 = 138;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 21:
													value = smethod_170(intptr_2);
													num2 = 110;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 229:
												case 492:
													array5 = new byte[6];
													num2 = 495;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 489:
													flag2 = true;
													num2 = 369;
													if (smethod_189())
													{
														continue;
													}
													goto case 6;
												case 485:
													array6[4] = 99;
													goto case 319;
												case 333:
													try
													{
														object_17 = (Delegate2)smethod_167(new IntPtr(num8), smethod_162(typeof(Delegate2).TypeHandle));
														num44 = 0;
														if (smethod_190() != null)
														{
															num44 = num45;
														}
														switch (num44)
														{
														}
													}
													catch (object obj4)
													{
														num46 = 0;
														if (smethod_190() == null)
														{
															switch (num46)
															{
															case 1:
																goto end_IL_2f9f;
															}
														}
														try
														{
															Delegate object_10 = (Delegate)smethod_167(new IntPtr(num8), smethod_162(typeof(Delegate2).TypeHandle));
															num47 = 0;
															if (smethod_190() != null)
															{
																goto IL_2fe2;
															}
															goto IL_300e;
															IL_300e:
															switch (num47)
															{
															case 1:
																goto end_IL_2fbd;
															}
															goto IL_2fe2;
															IL_2fe2:
															object_17 = (Delegate2)smethod_176(smethod_162(typeof(Delegate2).TypeHandle), smethod_175(object_10));
															num47 = 1;
															if (smethod_190() != null)
															{
																goto IL_300e;
															}
															end_IL_2fbd:;
														}
														catch (object obj3)
														{
															num48 = 0;
															if (smethod_190() != null)
															{
																switch (num48)
																{
																default:
																	goto end_IL_3020;
																}
															}
															end_IL_3020:;
														}
														end_IL_2f9f:;
													}
													goto case 127;
												case 127:
													num2 = 506;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 481:
													array = array13;
													goto case 475;
												case 475:
													array15 = null;
													goto case 654;
												case 480:
													num33 = 0;
													num2 = 486;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 479:
													num43++;
													goto case 546;
												case 474:
													array4[13] = 77;
													num2 = 638;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 473:
													array16 = (array9 = array7);
													if (array16 == null)
													{
														goto end_IL_2138;
													}
													goto case 66;
												case 295:
												case 334:
													goto end_IL_2138;
												case 66:
													if (array9.Length != 0)
													{
														goto IL_2138;
													}
													num2 = 334;
													if (smethod_189())
													{
														continue;
													}
													goto case 299;
												case 468:
													array4[13] = 85;
													num2 = 19;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 14;
												case 467:
													num17 = 92;
													num2 = 450;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 466:
													num17 = 186;
													num2 = 250;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 464:
													array[num3 + 3] = array10[3];
													goto case 167;
												case 167:
													num3 = 16;
													num = 81;
													goto case 81;
												case 81:
													array[num3] = array2[0];
													goto case 208;
												case 208:
													array[num3 + 1] = array2[1];
													num2 = 3;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 462:
													int_0 = smethod_163(long_1);
													goto case 275;
												case 275:
													array3 = new byte[12];
													goto case 5;
												case 5:
													array3[0] = 109;
													goto case 264;
												case 264:
													array3[1] = 115;
													goto case 382;
												case 382:
													array3[2] = 99;
													goto case 402;
												case 402:
													array3[3] = 111;
													num2 = 29;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 73;
												case 73:
													array3[4] = 114;
													num2 = 7;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 455:
													if (smethod_115() == 4)
													{
														num2 = 412;
														if (!smethod_189())
														{
															continue;
														}
														goto case 462;
													}
													goto case 275;
												case 454:
													num17 = 104;
													num = 13;
													goto case 13;
												case 13:
													array4[20] = (byte)num17;
													num2 = 271;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 453:
													num3 = 23;
													goto case 403;
												case 403:
													array[num3] = array15[0];
													num2 = 11;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 111;
												case 111:
													array[num3 + 1] = array15[1];
													num = 59;
													goto case 59;
												case 59:
													array[num3 + 2] = array15[2];
													goto case 213;
												case 452:
													num17 = 175;
													num = 15;
													goto case 15;
												case 15:
													array4[18] = (byte)num17;
													num2 = 359;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 450:
													array4[13] = (byte)num17;
													num2 = 474;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 447:
													array4[4] = 126;
													goto case 389;
												case 389:
													num17 = 140;
													goto case 421;
												case 421:
													array4[5] = (byte)num17;
													goto case 442;
												case 442:
													num17 = 39;
													num2 = 44;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 361:
												case 446:
													if (smethod_158(smethod_134(object_4)) >= smethod_136(smethod_134(object_4)) - 1L)
													{
														goto default;
													}
													goto case 8;
												case 8:
													num32 = smethod_146(object_4) - num38;
													goto case 246;
												case 246:
													num35 = smethod_146(object_4);
													goto case 552;
												case 444:
													array4[6] = (byte)num17;
													num2 = 304;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 439:
													array[num25 + 4] = array2[4];
													goto case 355;
												case 355:
													array[num25 + 5] = array2[5];
													num = 550;
													goto case 550;
												case 438:
													num29 = 0u;
													goto case 113;
												case 113:
													num30 = 0u;
													goto case 320;
												case 320:
													num22 = 0u;
													num2 = 344;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 321;
												case 321:
													array5[3] = 74;
													goto case 94;
												case 94:
													array5[4] = 105;
													goto case 251;
												case 251:
													array5[5] = 116;
													num2 = 41;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 435:
													array6[13] = (byte)num20;
													num2 = 296;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 433:
													array[num25 + 7] = array2[7];
													num2 = 272;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 79;
												case 79:
													value = 0L;
													num2 = 218;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 76;
												case 76:
													array6[5] = (byte)num20;
													num2 = 58;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 89;
												case 89:
													num20 = 96;
													num2 = 551;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 20;
												case 20:
													array4[15] = 63;
													goto case 399;
												case 399:
													array4[15] = 122;
													num = 523;
													goto case 523;
												case 430:
													intptr_6 = LoadLibrary(text);
													goto case 229;
												case 429:
													array4[7] = (byte)num17;
													goto case 592;
												case 428:
													array3[7] = 100;
													num2 = 27;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 427:
													smethod_104(new IntPtr(&num15), 0, 0);
													num2 = 561;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 425:
													array6[14] = 126;
													num2 = 237;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 424:
													num20 = 109;
													goto case 435;
												case 422:
													array6[7] = 3;
													goto case 91;
												case 91:
													array6[8] = 162;
													num2 = 38;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 420:
													array4[14] = (byte)num17;
													goto case 20;
												case 418:
													try
													{
														ProcessModuleCollection object_8 = (ProcessModuleCollection)smethod_118(object_);
														while (true)
														{
															enumerator = (IEnumerator)smethod_119(object_8);
															num36 = 0;
															if (smethod_190() != null)
															{
																switch (num36)
																{
																case 2:
																	continue;
																case 1:
																	goto end_IL_3545;
																}
															}
															try
															{
																while (smethod_131(enumerator))
																{
																	while (true)
																	{
																		ProcessModule object_9 = (ProcessModule)smethod_120(enumerator);
																		num37 = 6;
																		if (smethod_190() != null)
																		{
																			goto IL_3596;
																		}
																		goto IL_359a;
																		IL_359a:
																		while (true)
																		{
																			switch (num37)
																			{
																			case 6:
																				intPtr = smethod_111(object_9);
																				goto case 4;
																			case 4:
																				if (intPtr.ToInt64() != long_1)
																				{
																					goto end_IL_35bb;
																				}
																				goto IL_3589;
																			case 1:
																				goto end_IL_35bb;
																			case 2:
																				num38 = 0;
																				goto end_IL_35d8;
																			case 3:
																			case 5:
																				goto end_IL_35d8;
																			}
																			break;
																			IL_3589:
																			num37 = 2;
																			if (smethod_190() == null)
																			{
																				continue;
																			}
																			goto IL_3596;
																		}
																		continue;
																		IL_3596:
																		num37 = num39;
																		goto IL_359a;
																		continue;
																		end_IL_35bb:
																		break;
																	}
																	continue;
																	end_IL_35d8:
																	break;
																}
															}
															finally
															{
																IDisposable disposable = enumerator as IDisposable;
																num40 = 0;
																if (smethod_190() == null)
																{
																	goto IL_361a;
																}
																goto IL_362d;
																IL_362d:
																while (true)
																{
																	switch (num40)
																	{
																	case 2:
																		goto IL_3600;
																	case 1:
																		goto end_IL_362d;
																	}
																	goto IL_361a;
																	IL_3600:
																	smethod_132(disposable);
																	num40 = 1;
																	if (smethod_189())
																	{
																		continue;
																	}
																	goto IL_3614;
																	continue;
																	end_IL_362d:
																	break;
																}
																goto end_IL_35e8;
																IL_3614:
																num40 = num41;
																goto IL_362d;
																IL_361a:
																if (disposable != null)
																{
																	num40 = 2;
																	if (smethod_190() != null)
																	{
																		goto IL_3614;
																	}
																	goto IL_362d;
																}
																end_IL_35e8:;
															}
															break;
															continue;
															end_IL_3545:
															break;
														}
													}
													catch (object obj2)
													{
														num42 = 0;
														if (!smethod_189())
														{
															switch (num42)
															{
															}
														}
													}
													goto case 483;
												case 416:
													text = (string)smethod_165(smethod_164(), array3);
													num2 = 430;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 414:
													array[num25] = array15[0];
													goto case 619;
												case 413:
													array4[13] = 133;
													goto case 468;
												case 412:
													array4[25] = 103;
													goto case 583;
												case 409:
													array4[1] = 84;
													goto case 351;
												case 351:
													num17 = 111;
													goto case 563;
												case 406:
													if (smethod_166(intptr_6, IntPtr.Zero))
													{
														goto case 521;
													}
													num2 = 76;
													if (!smethod_189())
													{
														continue;
													}
													goto case 229;
												case 404:
													num17 = 190;
													goto case 386;
												case 386:
													array4[8] = (byte)num17;
													num = 120;
													goto case 120;
												case 120:
													array4[8] = 55;
													goto case 289;
												case 289:
													num17 = 68;
													goto case 147;
												case 147:
													array4[8] = (byte)num17;
													goto case 625;
												case 400:
													array4[27] = (byte)num17;
													goto case 466;
												case 397:
													array4[21] = (byte)num17;
													goto case 608;
												case 394:
													array4[17] = 221;
													num2 = 452;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 393:
													smethod_150(object_6, array14, 0, array14.Length);
													num = 200;
													goto case 200;
												case 200:
													smethod_151(object_6);
													num2 = 97;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 392:
													Class21.int_3 = intPtr.ToInt32();
													goto case 46;
												case 46:
													intPtr = smethod_143(((object[])smethod_142(Class21.object_5))[0]);
													goto case 332;
												case 332:
													long_0 = intPtr.ToInt64();
													goto case 509;
												case 388:
													struct2.bool_0 = false;
													num2 = 197;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 387:
													if (num35 >= 1879048192)
													{
														goto case 489;
													}
													goto case 369;
												case 369:
													int_2 = smethod_146(object_4);
													goto case 104;
												case 104:
													byte_ = (byte[])smethod_137(object_4, int_2);
													goto case 17;
												case 17:
													@struct = default(Struct15);
													num2 = 78;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 384:
													array12 = new byte[40];
													smethod_186(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
													array13 = array12;
													goto case 4;
												case 383:
													smethod_27(intptr_, num16 * 4, int_, ref int_);
													num2 = 155;
													if (smethod_189())
													{
														continue;
													}
													goto case 75;
												case 75:
													array4[20] = (byte)num17;
													num2 = 454;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 142;
												case 376:
													num20 = 33;
													goto case 285;
												case 285:
													array6[13] = (byte)num20;
													num = 663;
													goto case 663;
												case 374:
													long_1 = intPtr.ToInt64();
													num = 455;
													goto case 455;
												case 366:
													array6[1] = (byte)num20;
													goto case 130;
												case 130:
													array6[2] = 104;
													num2 = 152;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 363:
													num20 = 124;
													num2 = 360;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 362:
													array4[19] = (byte)num17;
													goto case 153;
												case 360:
													array6[5] = (byte)num20;
													goto case 253;
												case 253:
													num20 = 214;
													goto case 76;
												case 359:
													num17 = 150;
													goto case 6;
												case 354:
													array5[2] = 116;
													goto case 321;
												case 350:
													Class21.object_7 = new Delegate2(smethod_18);
													num2 = 542;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 348:
													array4[21] = (byte)num17;
													num2 = 343;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 347:
													array4[31] = (byte)num17;
													num2 = 53;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 344:
													if (num24 > 0)
													{
														goto case 621;
													}
													goto case 135;
												case 135:
													num34 = 0u;
													num2 = 480;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 343:
													num17 = 23;
													goto case 397;
												case 342:
													array4[30] = (byte)num17;
													num = 498;
													goto case 498;
												case 340:
													object_7 = (Delegate3)smethod_167(procAddress, smethod_162(typeof(Delegate3).TypeHandle));
													goto case 96;
												case 96:
													intptr_2 = smethod_168(object_7);
													num2 = 79;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 338:
													intptr_4 = smethod_156((uint)uint_, 1, (uint)smethod_155(smethod_109()));
													goto case 179;
												case 179:
													if (smethod_115() == 4)
													{
														num2 = 128;
														if (smethod_189())
														{
															continue;
														}
														goto case 63;
													}
													goto case 46;
												case 62:
												case 337:
													num33++;
													goto case 486;
												case 327:
													array4[30] = (byte)num17;
													goto case 199;
												case 199:
													array4[30] = 68;
													goto case 269;
												case 269:
													num17 = 147;
													num2 = 9;
													if (!smethod_189())
													{
														continue;
													}
													goto case 347;
												case 326:
													smethod_161(Class21.object_4, num31 + num32, @struct);
													goto case 361;
												case 323:
													num17 = 143;
													goto case 255;
												case 255:
													array4[20] = (byte)num17;
													num = 39;
													goto case 39;
												case 39:
													num17 = 152;
													goto case 185;
												case 185:
													array4[21] = (byte)num17;
													goto case 224;
												case 224:
													num17 = 73;
													goto case 348;
												case 318:
													array4[12] = (byte)num17;
													num = 413;
													goto case 413;
												case 313:
													num20 = 63;
													goto case 212;
												case 212:
													array6[8] = (byte)num20;
													num = 660;
													goto case 660;
												case 310:
													array6[9] = (byte)num20;
													num2 = 359;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 664;
												case 304:
													num17 = 164;
													goto case 300;
												case 300:
													array4[6] = (byte)num17;
													goto case 116;
												case 116:
													array4[6] = 125;
													num = 557;
													goto case 557;
												case 298:
													array4[18] = 106;
													num = 280;
													goto case 280;
												case 280:
													num17 = 207;
													num2 = 241;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 296:
													array6[13] = 148;
													goto case 154;
												case 154:
													array6[13] = 93;
													goto case 376;
												case 291:
													array4[14] = 116;
													goto case 519;
												case 288:
													num29 += num30;
													num2 = 103;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 284:
													array4[22] = (byte)num17;
													num = 515;
													goto case 515;
												case 282:
													num17 = 117;
													num2 = 444;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 281:
													array3[6] = 105;
													goto case 134;
												case 134:
													array3[7] = 116;
													goto case 503;
												case 279:
													smethod_153(object_6);
													num2 = 86;
													if (!smethod_189())
													{
														continue;
													}
													goto case 124;
												case 272:
													num25 = 30;
													num = 414;
													goto case 414;
												case 271:
													array4[20] = 130;
													num2 = 323;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 263:
													num28 = 0;
													num2 = 635;
													if (smethod_189())
													{
														continue;
													}
													goto case 586;
												case 257:
													reference = ref struct2;
													array9 = new byte[1] { 42 };
													reference.byte_0 = array9;
													num2 = 388;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 252:
													smethod_141(array11, 0, array11.Length);
													goto case 476;
												case 250:
													array4[27] = (byte)num17;
													num = 586;
													goto case 586;
												case 247:
													array4[2] = 158;
													goto case 512;
												case 245:
													array6[14] = 162;
													num = 240;
													goto case 240;
												case 242:
													num20 = 155;
													goto case 310;
												case 241:
													array4[18] = (byte)num17;
													num2 = 165;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 237:
													array6[14] = 74;
													num2 = 245;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 168;
												case 236:
													num27++;
													goto case 186;
												case 234:
													array4[1] = (byte)num17;
													num2 = 409;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 342;
												case 233:
													smethod_108();
													num2 = 574;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 230:
													array4[6] = 93;
													num = 513;
													goto case 513;
												case 228:
													num20 = 158;
													num2 = 71;
													if (smethod_189())
													{
														continue;
													}
													goto case 21;
												case 227:
													array3[6] = 46;
													goto case 428;
												case 226:
													num17 = 140;
													goto case 400;
												case 225:
													smethod_153(memoryStream);
													goto case 279;
												case 220:
													smethod_26(intptr_4, intPtr2, (byte[])smethod_157(smethod_146(object_4)), 4u, out intptr_5);
													goto case 379;
												case 219:
													array2 = (byte[])smethod_157(smethod_163(num8));
													goto case 261;
												case 217:
													array6[12] = (byte)num20;
													goto case 594;
												case 215:
													num17 = 168;
													goto case 75;
												case 210:
													num26 = 0;
													goto case 407;
												case 209:
													array6[10] = 227;
													goto case 161;
												case 161:
													num20 = 68;
													goto case 55;
												case 55:
													array6[11] = (byte)num20;
													num2 = 656;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 201:
													num17 = 166;
													goto case 327;
												case 197:
													smethod_161(Class21.object_4, 0L, struct2);
													goto case 162;
												case 162:
													flag2 = false;
													num2 = 446;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 195:
													smethod_27(intptr_3, 4, 4, ref int_);
													num2 = 540;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 190;
												case 191:
													array[num25 + 2] = array2[2];
													goto case 26;
												case 26:
													array[num25 + 3] = array2[3];
													goto case 439;
												case 180:
													if (num24 <= 0)
													{
														goto case 305;
													}
													goto case 511;
												case 178:
													smethod_148(object_5, CipherMode.CBC);
													num2 = 590;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 177:
													array4[24] = 169;
													goto case 533;
												case 176:
													memoryStream = new MemoryStream();
													goto case 171;
												case 171:
													object_6 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
													goto case 393;
												case 169:
													num20 = 233;
													goto case 126;
												case 126:
													array6[4] = (byte)num20;
													goto case 156;
												case 156:
													array6[5] = 114;
													goto case 363;
												case 165:
													num17 = 80;
													goto case 362;
												case 163:
													object_5 = (SymmetricAlgorithm)smethod_147();
													goto case 178;
												case 152:
													array6[2] = 32;
													num2 = 646;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 112;
												case 151:
													array[num3 + 1] = array10[1];
													goto case 559;
												case 150:
													array4[14] = 131;
													num2 = 291;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 149:
													array4[23] = 99;
													num2 = 177;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 111;
												case 145:
													smethod_107(array9, 0, smethod_106(8), 1);
													num2 = 233;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 144:
													array6[10] = 24;
													num = 209;
													goto case 209;
												case 139:
													num17 = 128;
													goto case 52;
												case 52:
													array4[20] = (byte)num17;
													num2 = 215;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 12;
												case 12:
													array4[3] = (byte)num17;
													goto case 133;
												case 110:
												case 138:
													smethod_100(intptr_2, 0);
													goto case 350;
												case 129:
													array4[25] = 126;
													num2 = 412;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 188;
												case 128:
													intPtr = smethod_143(((object[])smethod_142(Class21.object_5))[0]);
													num2 = 392;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 139;
												case 118:
													array4[5] = 144;
													num2 = 282;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 107:
													array4[12] = (byte)num17;
													num2 = 260;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 103:
													num22 = 0u;
													goto case 90;
												case 90:
													num23 = 0;
													goto case 322;
												case 98:
													array4[9] = (byte)num17;
													num = 639;
													goto case 639;
												case 97:
													array7 = (byte[])smethod_152(memoryStream);
													goto case 74;
												case 74:
													smethod_141(array8, 0, array8.Length);
													goto case 225;
												case 93:
													num20 = 251;
													num2 = 483;
													if (!smethod_189())
													{
														continue;
													}
													goto case 580;
												case 92:
													num21 = 255u;
													goto case 263;
												case 84:
													array6[6] = 191;
													goto case 600;
												case 82:
													array6[9] = (byte)num20;
													num2 = 565;
													if (smethod_189())
													{
														continue;
													}
													goto case 31;
												case 31:
													array4[27] = 122;
													num2 = 226;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 78:
													@struct.byte_0 = byte_;
													goto case 606;
												case 71:
													array6[11] = (byte)num20;
													num2 = 556;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 68:
													num17 = 165;
													goto case 107;
												case 61:
													array4[17] = (byte)num17;
													goto case 394;
												case 57:
													num19++;
													goto case 316;
												case 56:
													num18++;
													num = 620;
													goto IL_19b1;
												case 54:
													array4[4] = 136;
													goto case 612;
												case 53:
													array4[31] = 142;
													num2 = 22;
													if (smethod_190() != null)
													{
														continue;
													}
													goto case 36;
												case 51:
													array6[4] = 132;
													num2 = 169;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 49:
													num17 = 148;
													num2 = 616;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 45:
													flag = smethod_113(smethod_112(smethod_111(smethod_110(smethod_109())), "__", 10u), IntPtr.Zero);
													goto case 25;
												case 44:
													array4[5] = (byte)num17;
													num2 = 647;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 135;
												case 42:
													array3[4] = 105;
													num2 = 584;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 41:
													string_ = (string)smethod_165(smethod_164(), array5);
													goto case 502;
												case 37:
													num16 = smethod_146(object_4);
													goto case 28;
												case 28:
													smethod_27(intptr_, num16 * 4, 4, ref int_);
													goto case 210;
												case 27:
													array3[8] = 108;
													num2 = 637;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 24:
													smethod_103(new IntPtr(&num15), 0, IntPtr.Zero);
													num2 = 427;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_0b1a_2;
												case 19:
													array4[13] = 174;
													num2 = 467;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 9:
													try
													{
														ProcessModuleCollection object_2 = (ProcessModuleCollection)smethod_118(object_);
														num4 = 0;
														if (smethod_190() != null)
														{
															num4 = num5;
														}
														while (true)
														{
															switch (num4)
															{
															default:
																goto IL_4476;
															case 1:
																break;
															case 2:
																goto end_IL_448b;
															}
															goto IL_449f;
															IL_4476:
															enumerator = (IEnumerator)smethod_119(object_2);
															num4 = 1;
															if (smethod_189())
															{
																continue;
															}
															goto IL_449f;
															IL_449f:
															try
															{
																while (smethod_131(enumerator))
																{
																	while (true)
																	{
																		IL_4586:
																		ProcessModule object_3 = (ProcessModule)smethod_120(enumerator);
																		while (smethod_123(smethod_121(object_3), text))
																		{
																			num6 = 0;
																			if (!smethod_189())
																			{
																				goto IL_44e5;
																			}
																			goto IL_4542;
																			IL_44e5:
																			num6 = num7;
																			goto IL_4542;
																			IL_4542:
																			while (true)
																			{
																				switch (num6)
																				{
																				case 9:
																					num10 = num8;
																					intPtr = smethod_111(object_3);
																					if (num10 <= intPtr.ToInt64() + smethod_172(object_3))
																					{
																						goto end_IL_4571;
																					}
																					goto IL_44d8;
																				case 6:
																					break;
																				case 1:
																					if (smethod_174(smethod_173(smethod_162(typeof(Class21).TypeHandle).Assembly), null))
																					{
																						break;
																					}
																					num6 = 7;
																					if (!smethod_189())
																					{
																						continue;
																					}
																					goto end_IL_4571;
																				default:
																					num9 = num8;
																					intPtr = smethod_111(object_3);
																					if (num9 >= intPtr.ToInt64())
																					{
																						goto case 9;
																					}
																					goto case 1;
																				case 3:
																					goto end_IL_4542;
																				case 8:
																					goto IL_4586;
																				case 2:
																				case 7:
																					goto end_IL_4571;
																				case 4:
																					return;
																				case 5:
																					goto end_IL_4597;
																				}
																				smethod_114();
																				num6 = 4;
																				if (smethod_190() == null)
																				{
																					continue;
																				}
																				goto IL_44e5;
																				IL_44d8:
																				num6 = 1;
																				if (smethod_189())
																				{
																					continue;
																				}
																				goto IL_44e5;
																				continue;
																				end_IL_4542:
																				break;
																			}
																			continue;
																			end_IL_4571:
																			break;
																		}
																		break;
																	}
																	continue;
																	end_IL_4597:
																	break;
																}
															}
															finally
															{
																IDisposable disposable = enumerator as IDisposable;
																while (true)
																{
																	if (disposable == null)
																	{
																		num11 = 1;
																		if (smethod_190() != null)
																		{
																			goto IL_45b4;
																		}
																		goto IL_45b8;
																	}
																	goto IL_45cd;
																	IL_45b8:
																	switch (num11)
																	{
																	case 3:
																		continue;
																	case 1:
																	case 2:
																		goto end_IL_45f2;
																	}
																	goto IL_45cd;
																	IL_45cd:
																	smethod_132(disposable);
																	num11 = 2;
																	if (smethod_190() != null)
																	{
																		goto IL_45b4;
																	}
																	goto IL_45b8;
																	IL_45b4:
																	num11 = num12;
																	goto IL_45b8;
																	continue;
																	end_IL_45f2:
																	break;
																}
															}
															break;
															continue;
															end_IL_448b:
															break;
														}
													}
													catch (object obj)
													{
														num13 = 0;
														if (!smethod_189())
														{
															num13 = num14;
														}
														switch (num13)
														{
														}
													}
													goto case 418;
												case 7:
													array3[5] = 106;
													num2 = 281;
													if (smethod_190() == null)
													{
														continue;
													}
													goto case 175;
												case 3:
													array[num3 + 2] = array2[2];
													num2 = 496;
													if (smethod_189())
													{
														continue;
													}
													goto IL_0b1a_2;
												case 585:
													smethod_183(object_17);
													goto case 548;
												case 483:
													object_17 = null;
													goto case 333;
												case 484:
													smethod_114();
													return;
												case 114:
													return;
												case 629:
													return;
												case 504:
													smethod_114();
													return;
												case 558:
													return;
												case 196:
													smethod_114();
													num = 530;
													return;
												case 530:
													return;
												}
												break;
											}
											break;
											IL_0b1a_2:
											num2 = num;
											goto IL_0031_3;
										}
										break;
										IL_19b1:;
									}
									break;
								}
							}
							goto case 437;
							continue;
							end_IL_2138:
							break;
						}
						goto case 295;
					case 576:
						if (smethod_174(smethod_173(smethod_162(typeof(Class21).TypeHandle).Assembly), null))
						{
							goto case 204;
						}
						goto case 173;
					case 204:
						if (((Array)smethod_177(smethod_173(smethod_162(typeof(Class21).TypeHandle).Assembly))).Length == 2)
						{
							goto case 198;
						}
						goto case 173;
					case 198:
						if (smethod_144(smethod_162(typeof(Class21).TypeHandle).Assembly) != null)
						{
							goto case 287;
						}
						goto case 173;
					case 287:
						if (smethod_145(smethod_144(smethod_162(typeof(Class21).TypeHandle).Assembly)) <= 0)
						{
							goto case 173;
						}
						num2 = 197;
						if (!smethod_189())
						{
							continue;
						}
						goto case 484;
					case 173:
					case 207:
					case 238:
						try
						{
							object obj5 = smethod_181(smethod_180(smethod_179(smethod_178(smethod_162(typeof(Class21).TypeHandle).Assembly))).GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), smethod_179(smethod_178(smethod_162(typeof(Class21).TypeHandle).Assembly)));
							num61 = 8;
							if (smethod_190() != null)
							{
								goto IL_224a_2;
							}
							goto IL_23d8_3;
							IL_23d8_3:
							while (true)
							{
								switch (num61)
								{
								case 4:
								case 19:
									object_11 = new MemoryStream();
									num61 = 15;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 9:
								case 18:
									smethod_150(object_11, new byte[smethod_115()], 0, smethod_115());
									goto case 7;
								case 7:
									smethod_150(object_11, new byte[smethod_115()], 0, smethod_115());
									num61 = 2;
									if (smethod_189())
									{
										continue;
									}
									break;
								case 17:
									smethod_150(object_11, smethod_182(Class21.intptr_2.ToInt64()), 0, 8);
									goto case 9;
								case 16:
									smethod_150(object_11, smethod_157(Class21.intptr_2.ToInt32()), 0, 4);
									num61 = 18;
									if (smethod_190() == null)
									{
										continue;
									}
									goto case 7;
								case 15:
									smethod_150(object_11, new byte[smethod_115()], 0, smethod_115());
									goto case 14;
								case 14:
									if (smethod_115() != 4)
									{
										goto case 17;
									}
									num66 = 16;
									goto case 16;
								case 13:
									smethod_153(object_11);
									num61 = 0;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 12:
									array20 = (byte[])smethod_152(object_11);
									num61 = 5;
									if (!smethod_189())
									{
										continue;
									}
									goto case 13;
								case 11:
									Class21.intptr_2 = (IntPtr)smethod_181(obj5.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), obj5);
									goto case 4;
								case 10:
									Class21.intptr_2 = (IntPtr)obj5;
									num61 = 3;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 8:
									if (obj5 is IntPtr)
									{
										goto case 10;
									}
									goto case 3;
								case 3:
								case 6:
									if (!smethod_123(obj5.GetType().ToString(), "System.Reflection.RuntimeModule"))
									{
										num66 = 4;
										goto case 4;
									}
									goto case 11;
								case 2:
									smethod_135(object_11, 0L);
									goto case 12;
								default:
									nativeSizeOfCode = 0u;
									num61 = 1;
									if (smethod_190() == null)
									{
										continue;
									}
									break;
								case 1:
									try
									{
										array21 = (array9 = array20);
										if (array21 != null)
										{
											num62 = 0;
											if (smethod_189())
											{
												goto IL_2449_2;
											}
											goto IL_24b5_2;
										}
										goto IL_24bb_2;
										IL_2449_2:
										switch (num62)
										{
										default:
											if (array9.Length != 0)
											{
												goto case 1;
											}
											goto IL_24bb_2;
										case 1:
											while (true)
											{
												fixed (byte* value2 = &array9[0])
												{
													while (true)
													{
														Class21.object_7(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
														num62 = 3;
														if (smethod_190() != null)
														{
															num62 = num63;
														}
														switch (num62)
														{
														case 1:
															break;
														default:
															if (array9.Length == 0)
															{
																goto end_IL_246c_2;
															}
															break;
														case 2:
														case 4:
															continue;
														case 5:
															goto end_IL_246c_2;
														case 3:
															goto end_IL_2430_2;
														}
														break;
													}
												}
												continue;
												end_IL_246c_2:
												break;
											}
											goto IL_24bb_2;
										case 2:
										case 4:
											break;
										case 5:
											goto IL_24bb_2;
										case 3:
											goto end_IL_2430_2;
										}
										goto IL_2476_4;
										IL_24bb_2:
										reference2 = ref *(byte*)null;
										num63 = 4;
										goto IL_2476_4;
										IL_2476_4:
										Class21.object_7(new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), 216669565u, new IntPtr(System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)), ref nativeSizeOfCode);
										num62 = 3;
										if (smethod_190() == null)
										{
											goto IL_2449_2;
										}
										goto IL_24b5_2;
										IL_24b5_2:
										num62 = num63;
										goto IL_2449_2;
										end_IL_2430_2:;
									}
									finally
									{
										reference2 = ref *(byte*)null;
										num64 = 0;
										if (smethod_190() != null)
										{
											num64 = num65;
										}
										switch (num64)
										{
										}
									}
									goto end_IL_23d8_2;
								case 5:
									goto end_IL_23d8_2;
								}
								goto IL_224a_2;
								continue;
								end_IL_23d8_2:
								break;
							}
							goto end_IL_21cd_2;
							IL_224a_2:
							num61 = num66;
							goto IL_23d8_3;
							end_IL_21cd_2:;
						}
						catch (object obj6)
						{
							num67 = 0;
							if (smethod_190() != null)
							{
								num67 = num68;
							}
							switch (num67)
							{
							}
						}
						goto case 585;
					case 575:
						array4[8] = (byte)num17;
						goto case 43;
					case 43:
						num17 = 60;
						num = 214;
						goto case 214;
					case 214:
						array4[8] = (byte)num17;
						num2 = 49;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 574:
						if (num60 == 4109628145u)
						{
							num2 = 45;
							if (smethod_190() == null)
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 545;
					case 545:
						if (smethod_115() == 4)
						{
							num2 = 641;
							if (smethod_190() == null)
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 541;
					case 571:
						array3[10] = 108;
						goto case 259;
					case 259:
						array3[11] = 108;
						goto case 611;
					case 570:
						array4[29] = (byte)num17;
						num = 613;
						goto case 613;
					case 546:
					case 568:
						if (num43 >= array8.Length)
						{
							goto case 408;
						}
						goto case 268;
					case 408:
						array17 = array14;
						goto case 235;
					case 235:
						num24 = array17.Length % 4;
						num2 = 535;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 319;
					case 319:
						array6[4] = 159;
						num2 = 51;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 268:
						array19[num43] = (byte)(array19[num43] ^ array8[num43]);
						num2 = 479;
						if (smethod_189())
						{
							continue;
						}
						goto case 305;
					case 305:
						num59 = num29 ^ num22;
						num2 = 44;
						if (!smethod_189())
						{
							continue;
						}
						goto case 122;
					case 122:
						array18[num57] = (byte)(num59 & 0xFFu);
						goto case 460;
					case 460:
						array18[num57 + 1] = (byte)((num59 & 0xFF00) >> 8);
						num = 549;
						goto case 549;
					case 549:
						array18[num57 + 2] = (byte)((num59 & 0xFF0000) >> 16);
						goto case 352;
					case 352:
						array18[num57 + 3] = (byte)((num59 & 0xFF000000u) >> 24);
						num2 = 62;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 567:
						num17 = 163;
						goto case 527;
					case 527:
						array4[15] = (byte)num17;
						goto case 70;
					case 70:
						array4[15] = 199;
						goto case 88;
					case 565:
						array6[9] = 104;
						num2 = 242;
						if (smethod_189())
						{
							continue;
						}
						goto case 124;
					case 124:
						smethod_154(object_4);
						goto case 529;
					case 529:
						num56 = smethod_146(object_4);
						goto case 518;
					case 518:
						num58 = smethod_146(object_4);
						num2 = 564;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 563:
						array4[1] = (byte)num17;
						goto case 667;
					case 379:
					case 562:
						smethod_27(intPtr2, 4, int_, ref int_);
						num2 = 236;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 561:
						smethod_105(new IntPtr(&num15), 0, 0L);
						goto case 157;
					case 157:
						array9 = new byte[1];
						num2 = 145;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 186:
					case 560:
						if (num27 >= num56)
						{
							goto case 155;
						}
						goto case 385;
					case 155:
					case 249:
						if (smethod_158(smethod_134(object_4)) < smethod_136(smethod_134(object_4)) - 1L)
						{
							num2 = 232;
							if (smethod_189())
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 353;
					case 353:
						smethod_160(intptr_4);
						num2 = 531;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 385:
						intPtr2 = new IntPtr(long_0 + smethod_146(object_4) - num38);
						goto case 317;
					case 317:
						smethod_27(intPtr2, 4, 4, ref int_);
						goto case 297;
					case 297:
						if (smethod_115() == 4)
						{
							num2 = 220;
							if (smethod_189())
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 123;
					case 123:
						smethod_26(intptr_4, intPtr2, (byte[])smethod_157(smethod_146(object_4)), 4u, out intptr_5);
						num2 = 379;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 559:
						array[num3 + 2] = array10[2];
						num2 = 464;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 256;
					case 256:
						array3[1] = 108;
						goto case 112;
					case 556:
						array6[12] = 109;
						goto case 270;
					case 270:
						num20 = 116;
						num2 = 217;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 555:
						smethod_27(intptr_3, 4, int_, ref int_);
						goto case 100;
					case 100:
						num55++;
						num2 = 221;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 553:
						array8[7] = array11[3];
						num2 = 384;
						if (!smethod_189())
						{
							continue;
						}
						goto case 423;
					case 423:
						array8[9] = array11[4];
						goto case 395;
					case 395:
						array8[11] = array11[5];
						num = 405;
						goto case 405;
					case 405:
						array8[13] = array11[6];
						goto case 262;
					case 262:
						array8[15] = array11[7];
						num2 = 252;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 552:
						flag2 = false;
						num2 = 387;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 551:
						array6[6] = (byte)num20;
						goto case 223;
					case 223:
						array6[6] = 164;
						num = 14;
						goto case 14;
					case 14:
						array6[6] = 94;
						goto case 254;
					case 254:
						num20 = 164;
						num = 508;
						goto case 508;
					case 508:
						array6[6] = (byte)num20;
						num2 = 84;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 550:
						array[num25 + 6] = array2[6];
						num2 = 433;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 40;
					case 40:
						array3[3] = 106;
						num2 = 42;
						if (smethod_189())
						{
							continue;
						}
						goto case 38;
					case 38:
						num20 = 150;
						num2 = 596;
						if (smethod_189())
						{
							continue;
						}
						goto case 346;
					case 542:
						zero = IntPtr.Zero;
						goto case 80;
					case 80:
						zero = smethod_171(Class21.object_7);
						num = 143;
						goto case 143;
					case 143:
						num8 = 0L;
						goto case 336;
					case 336:
						if (smethod_115() != 4)
						{
							goto case 652;
						}
						goto case 380;
					case 380:
						num8 = smethod_169(new IntPtr(value));
						goto case 30;
					case 30:
					case 419:
						object_ = (Process)smethod_109();
						num2 = 9;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 540:
						smethod_159(intptr_3, smethod_146(object_4));
						goto case 555;
					case 539:
						array4[22] = (byte)num17;
						num2 = 10;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 32;
					case 32:
						num17 = 104;
						num2 = 67;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 587;
					case 538:
						array[num25 + 1] = array10[1];
						goto case 22;
					case 22:
						array[num25 + 2] = array10[2];
						goto case 470;
					case 470:
						array[num25 + 3] = array10[3];
						goto case 172;
					case 172:
						array[num25 + 4] = array10[4];
						goto case 410;
					case 410:
						array[num25 + 5] = array10[5];
						goto case 443;
					case 443:
						array[num25 + 6] = array10[6];
						num2 = 648;
						if (smethod_189())
						{
							continue;
						}
						goto case 290;
					case 536:
						array3[9] = 100;
						goto case 571;
					case 535:
						num51 = array17.Length / 4;
						num2 = 193;
						if (!smethod_189())
						{
							continue;
						}
						goto case 258;
					case 258:
						array18 = new byte[array17.Length];
						goto case 463;
					case 463:
						num54 = array19.Length / 4;
						num2 = 438;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 533:
						array4[24] = 18;
						goto case 119;
					case 119:
						array4[24] = 165;
						num2 = 601;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 531:
						smethod_114();
						num2 = 629;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 486:
					case 525:
						if (num33 < num51)
						{
							goto case 607;
						}
						goto case 273;
					case 273:
						array7 = array18;
						num = 457;
						goto case 457;
					case 457:
						num53 = array7.Length / 8;
						num2 = 473;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 524:
						array4[26] = 143;
						goto case 158;
					case 158:
						array4[27] = 155;
						num2 = 31;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 523:
						array4[15] = 105;
						num2 = 567;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 522:
						num19 = 0;
						goto case 316;
					case 316:
					case 458:
						if (num19 >= num24)
						{
							num2 = 337;
							if (smethod_189())
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 192;
					case 521:
						array3 = new byte[10];
						goto case 205;
					case 205:
						array3[0] = 99;
						goto case 256;
					case 520:
						intptr_6 = LoadLibrary(text);
						num2 = 406;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 519:
						num17 = 157;
						num2 = 469;
						if (!smethod_189())
						{
							continue;
						}
						goto case 658;
					case 517:
						if (array11 != null)
						{
							goto case 87;
						}
						goto case 476;
					case 87:
						if (array11.Length > 0)
						{
							goto case 487;
						}
						goto case 476;
					case 487:
						array8[1] = array11[0];
						num2 = 630;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 405;
					case 476:
						num43 = 0;
						goto case 546;
					case 515:
						num17 = 244;
						goto case 539;
					case 513:
						num17 = 151;
						num2 = 429;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 512:
						array4[2] = 149;
						goto case 434;
					case 434:
						array4[3] = 187;
						goto case 182;
					case 182:
						num17 = 122;
						goto case 488;
					case 488:
						array4[3] = (byte)num17;
						goto case 164;
					case 164:
						array4[3] = 47;
						goto case 2;
					case 2:
						array4[3] = 114;
						goto case 276;
					case 276:
						array4[3] = 187;
						goto case 589;
					case 511:
						num52 = num29 ^ num22;
						goto case 522;
					case 509:
						intptr_5 = IntPtr.Zero;
						num = 339;
						goto case 339;
					case 339:
						num27 = 0;
						goto case 186;
					case 506:
						int_3 = 0;
						num2 = 576;
						if (smethod_189())
						{
							continue;
						}
						goto case 141;
					case 503:
						array3[8] = 46;
						goto case 536;
					case 502:
						procAddress = GetProcAddress(intptr_6, string_);
						num2 = 340;
						if (smethod_189())
						{
							continue;
						}
						goto case 10;
					case 357:
					case 501:
						num29 = num29;
						goto case 371;
					case 371:
					{
						num49 = num29;
						uint num50 = num29;
						num50 ^= num50 << 1;
						num50 += 386210582;
						num50 ^= num50 >> 27;
						num50 += 2785290990u;
						num50 ^= num50 << 27;
						num50 += 3921027779u;
						num50 = 593091361 - num50;
						num29 = num49 + (uint)(double)num50;
						num = 23;
						goto case 23;
					}
					case 23:
						if (num33 == num51 - 1)
						{
							num2 = 180;
							if (smethod_189())
							{
								continue;
							}
							goto IL_0b1a;
						}
						goto case 305;
					case 500:
						num22 |= array17[^(1 + num23)];
						goto case 170;
					case 170:
						num23++;
						goto case 322;
					case 67:
						if (num23 <= 0)
						{
							goto case 500;
						}
						num = 16;
						goto case 16;
					case 16:
						num22 <<= 8;
						goto case 500;
					case 322:
					case 482:
						if (num23 >= num24)
						{
							goto case 357;
						}
						goto case 67;
					case 498:
						array4[30] = 115;
						num2 = 201;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 496:
						array[num3 + 3] = array2[3];
						num2 = 453;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 495:
						array5[0] = 103;
						goto case 206;
					case 206:
						array5[1] = 101;
						num2 = 354;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 218;
					case 218:
						if (smethod_115() == 4)
						{
							goto case 378;
						}
						goto case 21;
					case 378:
						value = smethod_169(intptr_2);
						num2 = 138;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 21:
						value = smethod_170(intptr_2);
						num2 = 110;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 229:
					case 492:
						array5 = new byte[6];
						num2 = 495;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 489:
						flag2 = true;
						num2 = 369;
						if (smethod_189())
						{
							continue;
						}
						goto case 6;
					case 485:
						array6[4] = 99;
						goto case 319;
					case 333:
						try
						{
							object_17 = (Delegate2)smethod_167(new IntPtr(num8), smethod_162(typeof(Delegate2).TypeHandle));
							num44 = 0;
							if (smethod_190() != null)
							{
								num44 = num45;
							}
							switch (num44)
							{
							}
						}
						catch (object obj4)
						{
							num46 = 0;
							if (smethod_190() == null)
							{
								switch (num46)
								{
								case 1:
									goto end_IL_2f9f_2;
								}
							}
							try
							{
								Delegate object_10 = (Delegate)smethod_167(new IntPtr(num8), smethod_162(typeof(Delegate2).TypeHandle));
								num47 = 0;
								if (smethod_190() != null)
								{
									goto IL_2fe2_2;
								}
								goto IL_300e_2;
								IL_300e_2:
								switch (num47)
								{
								case 1:
									goto end_IL_2fbd_2;
								}
								goto IL_2fe2_2;
								IL_2fe2_2:
								object_17 = (Delegate2)smethod_176(smethod_162(typeof(Delegate2).TypeHandle), smethod_175(object_10));
								num47 = 1;
								if (smethod_190() != null)
								{
									goto IL_300e_2;
								}
								end_IL_2fbd_2:;
							}
							catch (object obj3)
							{
								num48 = 0;
								if (smethod_190() != null)
								{
									switch (num48)
									{
									default:
										goto end_IL_3020_2;
									}
								}
								end_IL_3020_2:;
							}
							end_IL_2f9f_2:;
						}
						goto case 127;
					case 127:
						num2 = 506;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 481:
						array = array13;
						goto case 475;
					case 475:
						array15 = null;
						goto case 654;
					case 480:
						num33 = 0;
						num2 = 486;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 479:
						num43++;
						goto case 546;
					case 474:
						array4[13] = 77;
						num2 = 638;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 473:
						array16 = (array9 = array7);
						if (array16 == null)
						{
							goto case 295;
						}
						goto case 66;
					case 295:
					case 334:
						reference3 = ref *(byte*)null;
						num = 290;
						goto case 290;
					case 66:
						if (array9.Length == 0)
						{
							num2 = 334;
							if (smethod_189())
							{
								continue;
							}
							goto case 299;
						}
						goto case 577;
					case 468:
						array4[13] = 85;
						num2 = 19;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 14;
					case 467:
						num17 = 92;
						num2 = 450;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 466:
						num17 = 186;
						num2 = 250;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 464:
						array[num3 + 3] = array10[3];
						goto case 167;
					case 167:
						num3 = 16;
						num = 81;
						goto case 81;
					case 81:
						array[num3] = array2[0];
						goto case 208;
					case 208:
						array[num3 + 1] = array2[1];
						num2 = 3;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 462:
						int_0 = smethod_163(long_1);
						goto case 275;
					case 275:
						array3 = new byte[12];
						goto case 5;
					case 5:
						array3[0] = 109;
						goto case 264;
					case 264:
						array3[1] = 115;
						goto case 382;
					case 382:
						array3[2] = 99;
						goto case 402;
					case 402:
						array3[3] = 111;
						num2 = 29;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 73;
					case 73:
						array3[4] = 114;
						num2 = 7;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 455:
						if (smethod_115() == 4)
						{
							num2 = 412;
							if (!smethod_189())
							{
								continue;
							}
							goto case 462;
						}
						goto case 275;
					case 454:
						num17 = 104;
						num = 13;
						goto case 13;
					case 13:
						array4[20] = (byte)num17;
						num2 = 271;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 453:
						num3 = 23;
						goto case 403;
					case 403:
						array[num3] = array15[0];
						num2 = 11;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 111;
					case 111:
						array[num3 + 1] = array15[1];
						num = 59;
						goto case 59;
					case 59:
						array[num3 + 2] = array15[2];
						goto case 213;
					case 452:
						num17 = 175;
						num = 15;
						goto case 15;
					case 15:
						array4[18] = (byte)num17;
						num2 = 359;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 450:
						array4[13] = (byte)num17;
						num2 = 474;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 447:
						array4[4] = 126;
						goto case 389;
					case 389:
						num17 = 140;
						goto case 421;
					case 421:
						array4[5] = (byte)num17;
						goto case 442;
					case 442:
						num17 = 39;
						num2 = 44;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 361:
					case 446:
						if (smethod_158(smethod_134(object_4)) >= smethod_136(smethod_134(object_4)) - 1L)
						{
							goto default;
						}
						goto case 8;
					case 8:
						num32 = smethod_146(object_4) - num38;
						goto case 246;
					case 246:
						num35 = smethod_146(object_4);
						goto case 552;
					case 444:
						array4[6] = (byte)num17;
						num2 = 304;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 439:
						array[num25 + 4] = array2[4];
						goto case 355;
					case 355:
						array[num25 + 5] = array2[5];
						num = 550;
						goto case 550;
					case 438:
						num29 = 0u;
						goto case 113;
					case 113:
						num30 = 0u;
						goto case 320;
					case 320:
						num22 = 0u;
						num2 = 344;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 321;
					case 321:
						array5[3] = 74;
						goto case 94;
					case 94:
						array5[4] = 105;
						goto case 251;
					case 251:
						array5[5] = 116;
						num2 = 41;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 435:
						array6[13] = (byte)num20;
						num2 = 296;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 433:
						array[num25 + 7] = array2[7];
						num2 = 272;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 79;
					case 79:
						value = 0L;
						num2 = 218;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 76;
					case 76:
						array6[5] = (byte)num20;
						num2 = 58;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 89;
					case 89:
						num20 = 96;
						num2 = 551;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 20;
					case 20:
						array4[15] = 63;
						goto case 399;
					case 399:
						array4[15] = 122;
						num = 523;
						goto case 523;
					case 430:
						intptr_6 = LoadLibrary(text);
						goto case 229;
					case 429:
						array4[7] = (byte)num17;
						goto case 592;
					case 428:
						array3[7] = 100;
						num2 = 27;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 427:
						smethod_104(new IntPtr(&num15), 0, 0);
						num2 = 561;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 425:
						array6[14] = 126;
						num2 = 237;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 424:
						num20 = 109;
						goto case 435;
					case 422:
						array6[7] = 3;
						goto case 91;
					case 91:
						array6[8] = 162;
						num2 = 38;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 420:
						array4[14] = (byte)num17;
						goto case 20;
					case 418:
						try
						{
							ProcessModuleCollection object_8 = (ProcessModuleCollection)smethod_118(object_);
							while (true)
							{
								enumerator = (IEnumerator)smethod_119(object_8);
								num36 = 0;
								if (smethod_190() != null)
								{
									switch (num36)
									{
									case 2:
										continue;
									case 1:
										goto end_IL_3545_2;
									}
								}
								try
								{
									while (smethod_131(enumerator))
									{
										while (true)
										{
											ProcessModule object_9 = (ProcessModule)smethod_120(enumerator);
											num37 = 6;
											if (smethod_190() != null)
											{
												goto IL_3596_2;
											}
											goto IL_359a_3;
											IL_359a_3:
											while (true)
											{
												switch (num37)
												{
												case 6:
													intPtr = smethod_111(object_9);
													goto case 4;
												case 4:
													if (intPtr.ToInt64() != long_1)
													{
														goto end_IL_35bb_2;
													}
													goto IL_3589_2;
												case 1:
													goto end_IL_35bb_2;
												case 2:
													num38 = 0;
													goto end_IL_35d8_2;
												case 3:
												case 5:
													goto end_IL_35d8_2;
												}
												break;
												IL_3589_2:
												num37 = 2;
												if (smethod_190() == null)
												{
													continue;
												}
												goto IL_3596_2;
											}
											continue;
											IL_3596_2:
											num37 = num39;
											goto IL_359a_3;
											continue;
											end_IL_35bb_2:
											break;
										}
										continue;
										end_IL_35d8_2:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									num40 = 0;
									if (smethod_190() == null)
									{
										goto IL_361a_2;
									}
									goto IL_362d_3;
									IL_362d_3:
									while (true)
									{
										switch (num40)
										{
										case 2:
											goto IL_3600_2;
										case 1:
											goto end_IL_362d_2;
										}
										goto IL_361a_2;
										IL_3600_2:
										smethod_132(disposable);
										num40 = 1;
										if (smethod_189())
										{
											continue;
										}
										goto IL_3614_2;
										continue;
										end_IL_362d_2:
										break;
									}
									goto end_IL_35e8_2;
									IL_3614_2:
									num40 = num41;
									goto IL_362d_3;
									IL_361a_2:
									if (disposable != null)
									{
										num40 = 2;
										if (smethod_190() != null)
										{
											goto IL_3614_2;
										}
										goto IL_362d_3;
									}
									end_IL_35e8_2:;
								}
								break;
								continue;
								end_IL_3545_2:
								break;
							}
						}
						catch (object obj2)
						{
							num42 = 0;
							if (!smethod_189())
							{
								switch (num42)
								{
								}
							}
						}
						goto case 483;
					case 416:
						text = (string)smethod_165(smethod_164(), array3);
						num2 = 430;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 414:
						array[num25] = array15[0];
						goto case 619;
					case 413:
						array4[13] = 133;
						goto case 468;
					case 412:
						array4[25] = 103;
						goto case 583;
					case 409:
						array4[1] = 84;
						goto case 351;
					case 351:
						num17 = 111;
						goto case 563;
					case 406:
						if (smethod_166(intptr_6, IntPtr.Zero))
						{
							goto case 521;
						}
						num2 = 76;
						if (!smethod_189())
						{
							continue;
						}
						goto case 229;
					case 404:
						num17 = 190;
						goto case 386;
					case 386:
						array4[8] = (byte)num17;
						num = 120;
						goto case 120;
					case 120:
						array4[8] = 55;
						goto case 289;
					case 289:
						num17 = 68;
						goto case 147;
					case 147:
						array4[8] = (byte)num17;
						goto case 625;
					case 400:
						array4[27] = (byte)num17;
						goto case 466;
					case 397:
						array4[21] = (byte)num17;
						goto case 608;
					case 394:
						array4[17] = 221;
						num2 = 452;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 393:
						smethod_150(object_6, array14, 0, array14.Length);
						num = 200;
						goto case 200;
					case 200:
						smethod_151(object_6);
						num2 = 97;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 392:
						Class21.int_3 = intPtr.ToInt32();
						goto case 46;
					case 46:
						intPtr = smethod_143(((object[])smethod_142(Class21.object_5))[0]);
						goto case 332;
					case 332:
						long_0 = intPtr.ToInt64();
						goto case 509;
					case 388:
						struct2.bool_0 = false;
						num2 = 197;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 387:
						if (num35 >= 1879048192)
						{
							goto case 489;
						}
						goto case 369;
					case 369:
						int_2 = smethod_146(object_4);
						goto case 104;
					case 104:
						byte_ = (byte[])smethod_137(object_4, int_2);
						goto case 17;
					case 17:
						@struct = default(Struct15);
						num2 = 78;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 384:
						array12 = new byte[40];
						smethod_186(array12, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						array13 = array12;
						goto case 4;
					case 383:
						smethod_27(intptr_, num16 * 4, int_, ref int_);
						num2 = 155;
						if (smethod_189())
						{
							continue;
						}
						goto case 75;
					case 75:
						array4[20] = (byte)num17;
						num2 = 454;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 142;
					case 376:
						num20 = 33;
						goto case 285;
					case 285:
						array6[13] = (byte)num20;
						num = 663;
						goto case 663;
					case 374:
						long_1 = intPtr.ToInt64();
						num = 455;
						goto case 455;
					case 366:
						array6[1] = (byte)num20;
						goto case 130;
					case 130:
						array6[2] = 104;
						num2 = 152;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 363:
						num20 = 124;
						num2 = 360;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 362:
						array4[19] = (byte)num17;
						goto case 153;
					case 360:
						array6[5] = (byte)num20;
						goto case 253;
					case 253:
						num20 = 214;
						goto case 76;
					case 359:
						num17 = 150;
						goto case 6;
					case 354:
						array5[2] = 116;
						goto case 321;
					case 350:
						Class21.object_7 = new Delegate2(smethod_18);
						num2 = 542;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 348:
						array4[21] = (byte)num17;
						num2 = 343;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 347:
						array4[31] = (byte)num17;
						num2 = 53;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 344:
						if (num24 > 0)
						{
							goto case 621;
						}
						goto case 135;
					case 135:
						num34 = 0u;
						num2 = 480;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 343:
						num17 = 23;
						goto case 397;
					case 342:
						array4[30] = (byte)num17;
						num = 498;
						goto case 498;
					case 340:
						object_7 = (Delegate3)smethod_167(procAddress, smethod_162(typeof(Delegate3).TypeHandle));
						goto case 96;
					case 96:
						intptr_2 = smethod_168(object_7);
						num2 = 79;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 338:
						intptr_4 = smethod_156((uint)uint_, 1, (uint)smethod_155(smethod_109()));
						goto case 179;
					case 179:
						if (smethod_115() == 4)
						{
							num2 = 128;
							if (smethod_189())
							{
								continue;
							}
							goto case 63;
						}
						goto case 46;
					case 62:
					case 337:
						num33++;
						goto case 486;
					case 327:
						array4[30] = (byte)num17;
						goto case 199;
					case 199:
						array4[30] = 68;
						goto case 269;
					case 269:
						num17 = 147;
						num2 = 9;
						if (!smethod_189())
						{
							continue;
						}
						goto case 347;
					case 326:
						smethod_161(Class21.object_4, num31 + num32, @struct);
						goto case 361;
					case 323:
						num17 = 143;
						goto case 255;
					case 255:
						array4[20] = (byte)num17;
						num = 39;
						goto case 39;
					case 39:
						num17 = 152;
						goto case 185;
					case 185:
						array4[21] = (byte)num17;
						goto case 224;
					case 224:
						num17 = 73;
						goto case 348;
					case 318:
						array4[12] = (byte)num17;
						num = 413;
						goto case 413;
					case 313:
						num20 = 63;
						goto case 212;
					case 212:
						array6[8] = (byte)num20;
						num = 660;
						goto case 660;
					case 310:
						array6[9] = (byte)num20;
						num2 = 359;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 664;
					case 304:
						num17 = 164;
						goto case 300;
					case 300:
						array4[6] = (byte)num17;
						goto case 116;
					case 116:
						array4[6] = 125;
						num = 557;
						goto case 557;
					case 298:
						array4[18] = 106;
						num = 280;
						goto case 280;
					case 280:
						num17 = 207;
						num2 = 241;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 296:
						array6[13] = 148;
						goto case 154;
					case 154:
						array6[13] = 93;
						goto case 376;
					case 291:
						array4[14] = 116;
						goto case 519;
					case 288:
						num29 += num30;
						num2 = 103;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 284:
						array4[22] = (byte)num17;
						num = 515;
						goto case 515;
					case 282:
						num17 = 117;
						num2 = 444;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 281:
						array3[6] = 105;
						goto case 134;
					case 134:
						array3[7] = 116;
						goto case 503;
					case 279:
						smethod_153(object_6);
						num2 = 86;
						if (!smethod_189())
						{
							continue;
						}
						goto case 124;
					case 272:
						num25 = 30;
						num = 414;
						goto case 414;
					case 271:
						array4[20] = 130;
						num2 = 323;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 263:
						num28 = 0;
						num2 = 635;
						if (smethod_189())
						{
							continue;
						}
						goto case 586;
					case 257:
						reference = ref struct2;
						array9 = new byte[1] { 42 };
						reference.byte_0 = array9;
						num2 = 388;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 252:
						smethod_141(array11, 0, array11.Length);
						goto case 476;
					case 250:
						array4[27] = (byte)num17;
						num = 586;
						goto case 586;
					case 247:
						array4[2] = 158;
						goto case 512;
					case 245:
						array6[14] = 162;
						num = 240;
						goto case 240;
					case 242:
						num20 = 155;
						goto case 310;
					case 241:
						array4[18] = (byte)num17;
						num2 = 165;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 237:
						array6[14] = 74;
						num2 = 245;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 168;
					case 236:
						num27++;
						goto case 186;
					case 234:
						array4[1] = (byte)num17;
						num2 = 409;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 342;
					case 233:
						smethod_108();
						num2 = 574;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 230:
						array4[6] = 93;
						num = 513;
						goto case 513;
					case 228:
						num20 = 158;
						num2 = 71;
						if (smethod_189())
						{
							continue;
						}
						goto case 21;
					case 227:
						array3[6] = 46;
						goto case 428;
					case 226:
						num17 = 140;
						goto case 400;
					case 225:
						smethod_153(memoryStream);
						goto case 279;
					case 220:
						smethod_26(intptr_4, intPtr2, (byte[])smethod_157(smethod_146(object_4)), 4u, out intptr_5);
						goto case 379;
					case 219:
						array2 = (byte[])smethod_157(smethod_163(num8));
						goto case 261;
					case 217:
						array6[12] = (byte)num20;
						goto case 594;
					case 215:
						num17 = 168;
						goto case 75;
					case 210:
						num26 = 0;
						goto case 407;
					case 209:
						array6[10] = 227;
						goto case 161;
					case 161:
						num20 = 68;
						goto case 55;
					case 55:
						array6[11] = (byte)num20;
						num2 = 656;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 201:
						num17 = 166;
						goto case 327;
					case 197:
						smethod_161(Class21.object_4, 0L, struct2);
						goto case 162;
					case 162:
						flag2 = false;
						num2 = 446;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 195:
						smethod_27(intptr_3, 4, 4, ref int_);
						num2 = 540;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 190;
					case 191:
						array[num25 + 2] = array2[2];
						goto case 26;
					case 26:
						array[num25 + 3] = array2[3];
						goto case 439;
					case 180:
						if (num24 <= 0)
						{
							goto case 305;
						}
						goto case 511;
					case 178:
						smethod_148(object_5, CipherMode.CBC);
						num2 = 590;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 177:
						array4[24] = 169;
						goto case 533;
					case 176:
						memoryStream = new MemoryStream();
						goto case 171;
					case 171:
						object_6 = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						goto case 393;
					case 169:
						num20 = 233;
						goto case 126;
					case 126:
						array6[4] = (byte)num20;
						goto case 156;
					case 156:
						array6[5] = 114;
						goto case 363;
					case 165:
						num17 = 80;
						goto case 362;
					case 163:
						object_5 = (SymmetricAlgorithm)smethod_147();
						goto case 178;
					case 152:
						array6[2] = 32;
						num2 = 646;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 112;
					case 151:
						array[num3 + 1] = array10[1];
						goto case 559;
					case 150:
						array4[14] = 131;
						num2 = 291;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 149:
						array4[23] = 99;
						num2 = 177;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 111;
					case 145:
						smethod_107(array9, 0, smethod_106(8), 1);
						num2 = 233;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 144:
						array6[10] = 24;
						num = 209;
						goto case 209;
					case 139:
						num17 = 128;
						goto case 52;
					case 52:
						array4[20] = (byte)num17;
						num2 = 215;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 12;
					case 12:
						array4[3] = (byte)num17;
						goto case 133;
					case 110:
					case 138:
						smethod_100(intptr_2, 0);
						goto case 350;
					case 129:
						array4[25] = 126;
						num2 = 412;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 188;
					case 128:
						intPtr = smethod_143(((object[])smethod_142(Class21.object_5))[0]);
						num2 = 392;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 139;
					case 118:
						array4[5] = 144;
						num2 = 282;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 107:
						array4[12] = (byte)num17;
						num2 = 260;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 103:
						num22 = 0u;
						goto case 90;
					case 90:
						num23 = 0;
						goto case 322;
					case 98:
						array4[9] = (byte)num17;
						num = 639;
						goto case 639;
					case 97:
						array7 = (byte[])smethod_152(memoryStream);
						goto case 74;
					case 74:
						smethod_141(array8, 0, array8.Length);
						goto case 225;
					case 93:
						num20 = 251;
						num2 = 483;
						if (!smethod_189())
						{
							continue;
						}
						goto case 580;
					case 92:
						num21 = 255u;
						goto case 263;
					case 84:
						array6[6] = 191;
						goto case 600;
					case 82:
						array6[9] = (byte)num20;
						num2 = 565;
						if (smethod_189())
						{
							continue;
						}
						goto case 31;
					case 31:
						array4[27] = 122;
						num2 = 226;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 78:
						@struct.byte_0 = byte_;
						goto case 606;
					case 71:
						array6[11] = (byte)num20;
						num2 = 556;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 68:
						num17 = 165;
						goto case 107;
					case 61:
						array4[17] = (byte)num17;
						goto case 394;
					case 57:
						num19++;
						goto case 316;
					case 56:
						num18++;
						num = 620;
						goto case 415;
					case 54:
						array4[4] = 136;
						goto case 612;
					case 53:
						array4[31] = 142;
						num2 = 22;
						if (smethod_190() != null)
						{
							continue;
						}
						goto case 36;
					case 51:
						array6[4] = 132;
						num2 = 169;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 49:
						num17 = 148;
						num2 = 616;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 45:
						flag = smethod_113(smethod_112(smethod_111(smethod_110(smethod_109())), "__", 10u), IntPtr.Zero);
						goto case 25;
					case 44:
						array4[5] = (byte)num17;
						num2 = 647;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 135;
					case 42:
						array3[4] = 105;
						num2 = 584;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 41:
						string_ = (string)smethod_165(smethod_164(), array5);
						goto case 502;
					case 37:
						num16 = smethod_146(object_4);
						goto case 28;
					case 28:
						smethod_27(intptr_, num16 * 4, 4, ref int_);
						goto case 210;
					case 27:
						array3[8] = 108;
						num2 = 637;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 24:
						smethod_103(new IntPtr(&num15), 0, IntPtr.Zero);
						num2 = 427;
						if (smethod_190() == null)
						{
							continue;
						}
						goto IL_0b1a;
					case 19:
						array4[13] = 174;
						num2 = 467;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 9:
						try
						{
							ProcessModuleCollection object_2 = (ProcessModuleCollection)smethod_118(object_);
							num4 = 0;
							if (smethod_190() != null)
							{
								num4 = num5;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									goto IL_4476_2;
								case 1:
									break;
								case 2:
									goto end_IL_448b_2;
								}
								goto IL_449f_2;
								IL_4476_2:
								enumerator = (IEnumerator)smethod_119(object_2);
								num4 = 1;
								if (smethod_189())
								{
									continue;
								}
								goto IL_449f_2;
								IL_449f_2:
								try
								{
									while (smethod_131(enumerator))
									{
										while (true)
										{
											IL_4586_2:
											ProcessModule object_3 = (ProcessModule)smethod_120(enumerator);
											while (smethod_123(smethod_121(object_3), text))
											{
												num6 = 0;
												if (!smethod_189())
												{
													goto IL_44e5_2;
												}
												goto IL_4542_3;
												IL_44e5_2:
												num6 = num7;
												goto IL_4542_3;
												IL_4542_3:
												while (true)
												{
													switch (num6)
													{
													case 9:
														num10 = num8;
														intPtr = smethod_111(object_3);
														if (num10 <= intPtr.ToInt64() + smethod_172(object_3))
														{
															goto end_IL_4571_2;
														}
														goto IL_44d8_2;
													case 6:
														break;
													case 1:
														if (smethod_174(smethod_173(smethod_162(typeof(Class21).TypeHandle).Assembly), null))
														{
															break;
														}
														num6 = 7;
														if (!smethod_189())
														{
															continue;
														}
														goto end_IL_4571_2;
													default:
														num9 = num8;
														intPtr = smethod_111(object_3);
														if (num9 >= intPtr.ToInt64())
														{
															goto case 9;
														}
														goto case 1;
													case 3:
														goto end_IL_4542_2;
													case 8:
														goto IL_4586_2;
													case 2:
													case 7:
														goto end_IL_4571_2;
													case 4:
														return;
													case 5:
														goto end_IL_4597_2;
													}
													smethod_114();
													num6 = 4;
													if (smethod_190() == null)
													{
														continue;
													}
													goto IL_44e5_2;
													IL_44d8_2:
													num6 = 1;
													if (smethod_189())
													{
														continue;
													}
													goto IL_44e5_2;
													continue;
													end_IL_4542_2:
													break;
												}
												continue;
												end_IL_4571_2:
												break;
											}
											break;
										}
										continue;
										end_IL_4597_2:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									while (true)
									{
										if (disposable == null)
										{
											num11 = 1;
											if (smethod_190() != null)
											{
												goto IL_45b4_2;
											}
											goto IL_45b8_2;
										}
										goto IL_45cd_2;
										IL_45b8_2:
										switch (num11)
										{
										case 3:
											continue;
										case 1:
										case 2:
											goto end_IL_45f2_2;
										}
										goto IL_45cd_2;
										IL_45cd_2:
										smethod_132(disposable);
										num11 = 2;
										if (smethod_190() != null)
										{
											goto IL_45b4_2;
										}
										goto IL_45b8_2;
										IL_45b4_2:
										num11 = num12;
										goto IL_45b8_2;
										continue;
										end_IL_45f2_2:
										break;
									}
								}
								break;
								continue;
								end_IL_448b_2:
								break;
							}
						}
						catch (object obj)
						{
							num13 = 0;
							if (!smethod_189())
							{
								num13 = num14;
							}
							switch (num13)
							{
							}
						}
						goto case 418;
					case 7:
						array3[5] = 106;
						num2 = 281;
						if (smethod_190() == null)
						{
							continue;
						}
						goto case 175;
					case 3:
						array[num3 + 2] = array2[2];
						num2 = 496;
						if (smethod_189())
						{
							continue;
						}
						goto IL_0b1a;
					case 585:
						smethod_183(object_17);
						goto case 548;
					case 483:
						object_17 = null;
						goto case 333;
					case 484:
						smethod_114();
						return;
					case 114:
						return;
					case 629:
						return;
					case 504:
						smethod_114();
						return;
					case 558:
						return;
					case 196:
						goto end_IL_0009;
					case 530:
						return;
					}
					break;
				}
				break;
			}
			continue;
			end_IL_0009:
			break;
		}
		smethod_114();
		num = 530;
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
		if (object_9 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			object_9 = (Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class26.smethod_0(33554500)));
		}
		return object_9(intptr_4, (string)object_19, uint_0);
	}

	private static IntPtr smethod_25(IntPtr intptr_4, uint uint_0, uint uint_1, uint uint_2)
	{
		if (object_14 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			object_14 = (Delegate5)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class26.smethod_0(33554501)));
		}
		return object_14(intptr_4, uint_0, uint_1, uint_2);
	}

	private static int smethod_26(IntPtr intptr_4, IntPtr intptr_5, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_6)
	{
		if (object_13 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			object_13 = (Delegate6)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class26.smethod_0(33554502)));
		}
		return object_13(intptr_4, intptr_5, byte_0, uint_0, out intptr_6);
	}

	private static int smethod_27(IntPtr intptr_4, int int_4, int int_5, ref int int_6)
	{
		if (object_12 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			object_12 = (Delegate7)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class26.smethod_0(33554503)));
		}
		return object_12(intptr_4, int_4, int_5, ref int_6);
	}

	private static IntPtr smethod_28(uint uint_0, int int_4, uint uint_1)
	{
		if (object_2 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			object_2 = (Delegate8)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class26.smethod_0(33554504)));
		}
		return object_2(uint_0, int_4, uint_1);
	}

	private static int smethod_29(IntPtr intptr_4)
	{
		if (object_1 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			object_1 = (Delegate9)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(Class26.smethod_0(33554505)));
		}
		return object_1(intptr_4);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			intptr_0 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return intptr_0;
	}

	[Attribute0(typeof(Attribute0.Class22<object>[]))]
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

	[Attribute0(typeof(Attribute0.Class22<object>[]))]
	private static byte[] smethod_33(object object_19)
	{
		Stream stream = smethod_31();
		SymmetricAlgorithm symmetricAlgorithm = smethod_7();
		symmetricAlgorithm.Key = new byte[32]
		{
			39, 120, 185, 105, 2, 234, 137, 111, 145, 231,
			80, 182, 235, 38, 53, 128, 248, 66, 134, 46,
			190, 124, 254, 53, 52, 121, 141, 135, 132, 55,
			200, 174
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			178, 142, 200, 54, 118, 84, 84, 41, 63, 173,
			242, 56, 60, 180, 124, 200
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_19, 0, ((Array)object_19).Length);
		cryptoStream.Close();
		byte[] result = smethod_32(stream);
		Class25.smethod_0();
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
		return ((Class24)object_19).KDikMXewCI();
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
		return ((Class24)object_19).method_0(int_4);
	}

	internal static void smethod_39(object object_19)
	{
		((Class24)object_19).method_3();
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
		Class25.smethod_0();
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
		Class25.smethod_0();
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
		return ((Class24)object_19).KDikMXewCI();
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
		return ((Class24)object_19).method_0(int_4);
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
		((Class24)object_19).method_3();
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
		Class25.smethod_0();
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
		return ((Class24)object_19).KDikMXewCI();
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
		return ((Class24)object_19).method_0(int_4);
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
		return ((Class24)object_19).method_2();
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
		((Class24)object_19).method_3();
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
