using System;
using System.IO;
using ns0;

public class GClass0
{
	public byte[] byte_0;

	private uint uint_0;

	public uint uint_1;

	public uint uint_2;

	public uint uint_3;

	private uint uint_4;

	private uint uint_5;

	public uint uint_6;

	protected uint[] uint_7;

	protected uint[] uint_8;

	protected bool bool_0;

	protected uint uint_9;

	internal Stream stream_0;

	internal bool bool_1;

	internal uint uint_10;

	internal uint uint_11;

	public GClass0()
	{
		Exception0.smethod_5();
	}

	public virtual void vmethod_0()
	{
	}

	public virtual void vmethod_1()
	{
	}

	public void method_0()
	{
		vmethod_0();
		uint num = uint_1 + uint_3 - uint_4;
		uint num2 = uint_1 + uint_6 - num;
		for (uint num3 = 0u; num3 < num2; num3++)
		{
			byte_0[num3] = byte_0[num + num3];
		}
		uint_1 -= num;
		vmethod_1();
	}

	public virtual void vmethod_2()
	{
		if (bool_1)
		{
			return;
		}
		while (true)
		{
			int num = (int)(0 - uint_1 + uint_2 - uint_6);
			if (num != 0)
			{
				int num2 = stream_0.Read(byte_0, (int)(uint_1 + uint_6), num);
				if (num2 == 0)
				{
					break;
				}
				uint_6 += (uint)num2;
				if (uint_6 >= uint_3 + uint_11)
				{
					uint_0 = uint_6 - uint_11;
				}
				continue;
			}
			return;
		}
		uint_0 = uint_6;
		uint num3 = uint_1 + uint_0;
		if (num3 > uint_10)
		{
			uint_0 = uint_10 - uint_1;
		}
		bool_1 = true;
	}

	private void method_1()
	{
		byte_0 = null;
	}

	public void method_2(uint uint_12, uint uint_13, uint uint_14)
	{
		uint_4 = uint_12;
		uint num = (uint_11 = uint_13);
		uint_5 = uint_14;
		uint num2 = uint_12 + uint_13 + uint_14;
		if (byte_0 == null || uint_2 != num2)
		{
			method_1();
			uint_2 = num2;
			byte_0 = new byte[uint_2];
		}
		uint num3 = (uint_10 = uint_2 - uint_13);
	}

	public void method_3(Stream stream_1)
	{
		Stream stream = (stream_0 = stream_1);
		uint_1 = 0u;
		uint_3 = 0u;
		uint_6 = 0u;
		bool_1 = false;
		vmethod_2();
	}

	public void method_4()
	{
		Stream stream = (stream_0 = null);
	}

	public void method_5()
	{
		uint_3++;
		if (uint_3 > uint_0)
		{
			uint num = uint_1 + uint_3;
			if (num > uint_10)
			{
				method_0();
			}
			vmethod_2();
		}
	}

	public byte method_6(int int_0)
	{
		return byte_0[uint_1 + uint_3 + int_0];
	}

	public uint method_7(int int_0, uint uint_12, uint uint_13)
	{
		if (bool_1 && uint_3 + int_0 + uint_13 > uint_6)
		{
			uint_13 = uint_6 - (uint)(int)(uint_3 + int_0);
		}
		uint_12++;
		uint num = uint_1 + uint_3 + (uint)int_0;
		uint num2;
		for (num2 = 0u; num2 < uint_13 && byte_0[num + num2] == byte_0[num + num2 - uint_12]; num2++)
		{
		}
		return num2;
	}

	public uint method_8()
	{
		return uint_6 - uint_3;
	}

	public void method_9(int int_0)
	{
		uint_1 += (uint)int_0;
		uint_0 -= (uint)int_0;
		uint_3 -= (uint)int_0;
		uint_6 -= (uint)int_0;
	}

	internal static long smethod_0()
	{
		smethod_0();
		return 2L;
	}

	internal static object smethod_1()
	{
		AppDomain.CurrentDomain.SetData("17d17f2e15b34ff594bb793bf9620023", null);
		return null;
	}

	internal static string smethod_2()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_3();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception1.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception0.smethod_1();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							Exception0.smethod_2();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								Exception0.smethod_1();
							}
							num++;
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	internal static byte smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_1();
			}
			num++;
			return 31;
		}
		return 0;
	}

	internal static void smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Exception1.smethod_0();
		}
		num++;
		if (array[num] < 208)
		{
			return;
		}
		if (208 != array[num])
		{
			Exception0.smethod_0();
		}
		num++;
		if (array[num] >= 29)
		{
			if (29 != array[num])
			{
				GClass2.smethod_0();
			}
			num++;
		}
	}
}
