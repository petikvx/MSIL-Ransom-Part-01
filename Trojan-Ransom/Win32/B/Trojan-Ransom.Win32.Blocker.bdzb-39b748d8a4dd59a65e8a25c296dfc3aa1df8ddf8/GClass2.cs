using System;
using System.IO;
using System.Runtime.InteropServices;
using ns0;

public sealed class GClass2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 648)]
	private struct Struct0
	{
	}

	private uint uint_0;

	private uint uint_1;

	private Stream stream_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[324];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal byte[] byte_1;

	internal uint uint_2;

	public GClass2()
	{
		GClass3.smethod_3();
	}

	public void method_0(uint uint_3)
	{
		if (uint_0 != uint_3)
		{
			byte[] array = (byte_1 = new byte[uint_3]);
		}
		uint_0 = uint_3;
		uint_2 = 0u;
		uint_1 = 0u;
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		method_3();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_1 = 0u;
			uint_2 = 0u;
		}
	}

	public void method_2(Stream stream_1)
	{
		method_1(stream_1, bool_0: false);
	}

	public void method_3()
	{
		method_4();
		stream_0 = null;
	}

	public void method_4()
	{
		uint num = uint_2 - uint_1;
		if (num != 0)
		{
			stream_0.Write(byte_1, (int)uint_1, (int)num);
			if (uint_2 >= uint_0)
			{
				uint_2 = 0u;
			}
			uint_1 = uint_2;
		}
	}

	public void method_5(uint uint_3, uint uint_4)
	{
		uint num = uint_2 - uint_3 - 1;
		if (num >= uint_0)
		{
			num += uint_0;
		}
		while (uint_4 != 0)
		{
			if (num >= uint_0)
			{
				num = 0u;
			}
			byte[] array = byte_1;
			uint num2;
			uint num3 = (uint_2 = (num2 = uint_2) + 1);
			array[num2] = byte_1[num++];
			if (uint_2 >= uint_0)
			{
				method_4();
			}
			uint_4--;
		}
	}

	public void method_6(byte byte_2)
	{
		byte[] array = byte_1;
		uint num;
		uint num2 = (uint_2 = (num = uint_2) + 1);
		array[num] = byte_2;
		if (uint_2 >= uint_0)
		{
			method_4();
		}
	}

	public byte method_7(uint uint_3)
	{
		uint num = uint_2 - uint_3 - 1;
		if (num >= uint_0)
		{
			num += uint_0;
		}
		return byte_1[num];
	}

	static GClass2()
	{
		char[] array = new char[8];
		array[1] = '\u192d';
		array[2] = '㚠';
		array[0] = 'ⵯ';
		array[5] = '↞';
		array[7] = '㖠';
		array[4] = '\u1074';
		array[6] = '⠴';
		array[3] = 'ⶹ';
		object_2 = new string[12];
		object_0 = array;
	}

	internal static long smethod_0()
	{
		AppDomain.CurrentDomain.SetData("17d17f2e15b34ff594bb793bf9620023", null);
		return 12L;
	}

	internal static object smethod_1()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_0();
			}
			num++;
			return null;
		}
		return null;
	}

	internal static long smethod_2()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_0();
				}
				num++;
				return 0L;
			}
			return 14L;
		}
		return 0L;
	}

	internal static string smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass1.smethod_6();
			}
			num++;
			return null;
		}
		return null;
	}

	internal static byte smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass1.smethod_5();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Class5.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						GClass3.smethod_0();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							Exception0.smethod_1();
						}
						num++;
						return 4;
					}
					return 7;
				}
				return 16;
			}
			return 26;
		}
		return 8;
	}
}
