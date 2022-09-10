using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using ns0;
using ns2;
using ns3;
using ns5;

public sealed class GClass2
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct1
	{
		internal GClass2 gclass2_0;

		internal Class6 class6_0;

		internal Struct9[] struct9_0;

		internal Struct9[] struct9_1;

		internal Struct9[] struct9_2;

		internal Struct9[] struct9_3;

		internal Struct9[] struct9_4;

		internal Struct9[] struct9_5;

		internal Struct10[] struct10_0;

		internal Struct9[] struct9_6;

		internal Struct10 struct10_1;

		internal uint uint_0;

		internal uint uint_1;

		internal uint uint_2;

		static Struct1()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	internal byte[] byte_0;

	internal uint uint_0;

	internal uint uint_1;

	internal uint uint_2;

	internal Stream stream_0;

	public void method_0(uint uint_3)
	{
		if (uint_1 != uint_3)
		{
			byte[] array = (byte_0 = new byte[uint_3]);
		}
		uint num = (uint_1 = uint_3);
		uint_0 = 0u;
		uint_2 = 0u;
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		method_3();
		Stream stream = (stream_0 = stream_1);
		if (!bool_0)
		{
			uint_2 = 0u;
			uint_0 = 0u;
		}
	}

	public void method_2(Stream stream_1)
	{
		method_1(stream_1, bool_0: false);
	}

	public void method_3()
	{
		method_4();
		Stream stream = (stream_0 = null);
	}

	public void method_4()
	{
		uint num = uint_0 - uint_2;
		if (num != 0)
		{
			Exception0.smethod_3(stream_0, byte_0, (int)uint_2, (int)num, 74, 46);
			if (uint_0 >= uint_1)
			{
				uint_0 = 0u;
			}
			uint num2 = (uint_2 = uint_0);
		}
	}

	public void method_5(uint uint_3, uint uint_4)
	{
		uint num = uint_0 - uint_3 - 1;
		if (num >= uint_1)
		{
			num += uint_1;
		}
		while (uint_4 != 0)
		{
			if (num >= uint_1)
			{
				num = 0u;
			}
			byte[] array = byte_0;
			uint num2;
			uint num3 = (uint_0 = (num2 = uint_0) + 1);
			array[num2] = byte_0[num++];
			if (uint_0 >= uint_1)
			{
				method_4();
			}
			uint_4--;
		}
	}

	public void method_6(byte byte_1)
	{
		byte[] array = byte_0;
		uint num;
		uint num2 = (uint_0 = (num = uint_0) + 1);
		array[num] = byte_1;
		if (uint_0 >= uint_1)
		{
			method_4();
		}
	}

	public byte method_7(uint uint_3)
	{
		uint num = uint_0 - uint_3 - 1;
		if (num >= uint_1)
		{
			num += uint_1;
		}
		return byte_0[num];
	}

	static GClass2()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static int smethod_0(Stream stream_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return Class7.smethod_13(stream_1, 677, 752);
			case 85:
				return Class7.smethod_13(stream_1, 358, 307);
			}
		}
	}

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return Class9.Class10.smethod_4(runtimeTypeHandle_0, 602, 582);
			}
		}
	}

	internal static string smethod_2(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return Class7.Class8.smethod_10(string_0, string_1, 621, 561);
			}
		}
	}

	internal static Process smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				return Class9.smethod_6(731, 758);
			}
		}
	}

	internal static uint smethod_4(uint uint_3, uint uint_4, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return Class7.smethod_14(uint_3, uint_4, 103, 66);
			case 4:
				return Class7.smethod_14(uint_3, uint_4, 18, 52);
			}
		}
	}

	internal static bool smethod_5(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 30:
				return Class7.Class8.smethod_11(object_0, object_1, 254, 253);
			}
		}
	}
}
