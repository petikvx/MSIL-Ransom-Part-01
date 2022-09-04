using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using ns2;
using ns5;

namespace ns0;

internal sealed class Class6
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct11
	{
		internal uint uint_0;

		internal bool bool_0;

		internal uint uint_1;

		internal uint uint_2;

		internal uint uint_3;

		static Struct11()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	public uint uint_0;

	public uint uint_1;

	public Stream stream_0;

	public void method_0(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_1 = 0u;
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_1 = (uint_1 << 8) | (byte)GClass2.smethod_0(stream_0, 684, 760);
		}
	}

	public void method_1()
	{
		stream_0 = null;
	}

	public uint method_2(int int_0)
	{
		uint num = uint_0;
		uint num2 = uint_1;
		uint num3 = 0u;
		for (int num4 = int_0; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)GClass2.smethod_0(stream_0, 286, 330);
				num <<= 8;
			}
		}
		uint_0 = num;
		uint_1 = num2;
		return num3;
	}

	static Class6()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static object smethod_0(IntPtr intptr_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return Class9.smethod_4(intptr_0, type_0, 814, 838);
			}
		}
	}

	internal static string smethod_1(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				return Class7.smethod_6(resolveEventArgs_0, 323, 349);
			}
		}
	}

	internal static int smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 87:
				return Class7.smethod_7(string_0, 61, 4);
			}
		}
	}

	internal static string smethod_3(Process process_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				return Class9.Class10.smethod_2(process_0, 723, 759);
			case 5:
				return Class7.Class8.smethod_5(process_0, 154, 165);
			}
		}
	}

	internal static string smethod_4(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return Class7.smethod_1(object_0, object_1, 610, 530);
			}
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 47:
				return Class7.Class8.smethod_3(byte_0, byte_1, evidence_0, 975, 1019);
			}
		}
	}
}
