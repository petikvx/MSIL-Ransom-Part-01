using System;
using System.IO;
using ns0;

public sealed class GClass2
{
	private byte[] byte_0;

	private uint uint_0;

	internal uint uint_1;

	internal uint uint_2;

	internal Stream stream_0;

	public GClass2()
	{
		GClass3.smethod_2();
	}

	public void method_0(uint uint_3)
	{
		if (uint_2 != uint_3)
		{
			byte_0 = new byte[uint_3];
		}
		uint num = (uint_2 = uint_3);
		uint_1 = 0u;
		uint_0 = 0u;
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		method_3();
		Stream stream = (stream_0 = stream_1);
		if (!bool_0)
		{
			uint_0 = 0u;
			uint_1 = 0u;
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
		uint num = uint_1 - uint_0;
		if (num != 0)
		{
			stream_0.Write(byte_0, (int)uint_0, (int)num);
			if (uint_1 >= uint_2)
			{
				uint_1 = 0u;
			}
			uint_0 = uint_1;
		}
	}

	public void method_5(uint uint_3, uint uint_4)
	{
		uint num = uint_1 - uint_3 - 1;
		if (num >= uint_2)
		{
			num += uint_2;
		}
		while (uint_4 != 0)
		{
			if (num >= uint_2)
			{
				num = 0u;
			}
			byte[] array = byte_0;
			uint num2;
			uint num3 = (uint_1 = (num2 = uint_1) + 1);
			array[num2] = byte_0[num++];
			if (uint_1 >= uint_2)
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
		uint num2 = (uint_1 = (num = uint_1) + 1);
		array[num] = byte_1;
		if (uint_1 >= uint_2)
		{
			method_4();
		}
	}

	public byte method_7(uint uint_3)
	{
		uint num = uint_1 - uint_3 - 1;
		if (num >= uint_2)
		{
			num += uint_2;
		}
		return byte_0[num];
	}

	internal static string smethod_0()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return null;
	}

	internal static long smethod_1()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return 7L;
	}

	internal static long smethod_2()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return 15L;
	}

	internal static object smethod_3()
	{
		AppDomain.CurrentDomain.SetData("fe8ac553a4f34e4a8e054c1983ee8380", null);
		return null;
	}

	internal static Type smethod_4()
	{
		smethod_4();
		return typeof(rceResolve);
	}

	internal static void smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			smethod_2();
		}
		num++;
		if (array[num] < 208)
		{
			return;
		}
		if (208 != array[num])
		{
			GClass3.smethod_0();
		}
		num++;
		if (array[num] < 71)
		{
			return;
		}
		if (71 != array[num])
		{
			GClass0.smethod_1();
		}
		num++;
		if (array[num] >= 251)
		{
			if (251 != array[num])
			{
				GClass0.smethod_1();
			}
			num++;
		}
	}

	internal static int smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass0.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass3.smethod_0();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						smethod_2();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							GClass0.smethod_1();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass0.smethod_1();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									GClass3.smethod_0();
								}
								num++;
								return 0;
							}
							return 13;
						}
						return 8;
					}
					return 1;
				}
				return 5;
			}
			return 2;
		}
		return 2;
	}

	internal static object smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass0.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					GClass0.smethod_0();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						Exception0.smethod_1();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							GClass0.smethod_1();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass3.smethod_0();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									smethod_0();
								}
								num++;
								if (array[num] >= 229)
								{
									if (229 != array[num])
									{
										GClass0.smethod_0();
									}
									num++;
									if (array[num] >= 178)
									{
										if (178 != array[num])
										{
											smethod_1();
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
				return null;
			}
			return null;
		}
		return null;
	}

	internal static long smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_1();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass0.smethod_0();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							smethod_1();
						}
						num++;
						return 12L;
					}
					return 14L;
				}
				return 15L;
			}
			return 13L;
		}
		return 4L;
	}

	internal static void smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Exception1.smethod_1();
		}
		num++;
		if (array[num] < 208)
		{
			return;
		}
		if (208 != array[num])
		{
			Exception1.smethod_1();
		}
		num++;
		if (array[num] >= 71)
		{
			if (71 != array[num])
			{
				Exception1.smethod_0();
			}
			num++;
		}
	}
}
