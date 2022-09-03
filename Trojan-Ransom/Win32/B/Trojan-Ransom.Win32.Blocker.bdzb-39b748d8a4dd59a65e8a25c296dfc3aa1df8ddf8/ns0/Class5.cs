using System;
using System.IO;
using Evaluation;

namespace ns0;

internal sealed class Class5
{
	public uint uint_0;

	public uint uint_1;

	public Stream stream_0;

	public Class5()
	{
		smethod_7();
	}

	public void method_0(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_1 = 0u;
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_1 = (uint_1 << 8) | (byte)stream_0.ReadByte();
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
				num2 = (num2 << 8) | (byte)stream_0.ReadByte();
				num <<= 8;
			}
		}
		uint_0 = num;
		uint_1 = num2;
		return num3;
	}

	internal static string smethod_0()
	{
		AppDomain.CurrentDomain.SetData("17d17f2e15b34ff594bb793bf9620023", null);
		return null;
	}

	internal static Type smethod_1()
	{
		smethod_1();
		return typeof(Class0.Struct1);
	}

	internal static object smethod_2()
	{
		smethod_2();
		return null;
	}

	internal static long smethod_3()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception0.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception0.smethod_1();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception1.smethod_2();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							GClass1.smethod_6();
						}
						num++;
						return 0L;
					}
					return 6L;
				}
				return 1L;
			}
			return 7L;
		}
		return 7L;
	}

	internal static long smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
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
					Exception0.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception1.smethod_3();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							GClass0.smethod_1();
						}
						num++;
						return 10L;
					}
					return 10L;
				}
				return 12L;
			}
			return 11L;
		}
		return 14L;
	}

	internal static long smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_2();
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
						GClass0.smethod_1();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							GClass0.smethod_1();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								smethod_1();
							}
							num++;
							return 1L;
						}
						return 15L;
					}
					return 13L;
				}
				return 14L;
			}
			return 5L;
		}
		return 0L;
	}

	internal static byte smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
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
					Exception1.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception1.smethod_3();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							Exception0.smethod_2();
						}
						num++;
						return 23;
					}
					return 30;
				}
				return 16;
			}
			return 27;
		}
		return 10;
	}

	internal static Type smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass2.smethod_0();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception0.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception1.smethod_1();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							Exception1.smethod_3();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								smethod_1();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									GClass0.smethod_0();
								}
								num++;
								if (array[num] >= 232)
								{
									if (232 != array[num])
									{
										Exception1.smethod_0();
									}
									num++;
									return typeof(Class4.Struct5);
								}
								return typeof(Struct7);
							}
							return typeof(GInterface3);
						}
						return typeof(Class4);
					}
					return typeof(GClass0);
				}
				return typeof(GClass3.Class3.Struct2);
			}
			return typeof(GInterface4);
		}
		return typeof(DeepSeaObfuscator);
	}

	internal static byte smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
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
					GClass1.smethod_5();
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
							GClass3.smethod_0();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								Exception1.smethod_0();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									smethod_0();
								}
								num++;
								if (array[num] >= 232)
								{
									if (232 != array[num])
									{
										GClass0.smethod_0();
									}
									num++;
									if (array[num] >= 106)
									{
										if (106 != array[num])
										{
											Exception1.smethod_3();
										}
										num++;
										return 23;
									}
									return 2;
								}
								return 12;
							}
							return 26;
						}
						return 31;
					}
					return 1;
				}
				return 22;
			}
			return 6;
		}
		return 28;
	}

	internal static int smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
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
					Exception0.smethod_2();
				}
				num++;
				return 1;
			}
			return 3;
		}
		return 3;
	}

	internal static Type smethod_10()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception0.smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception0.smethod_2();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						GClass1.smethod_6();
					}
					num++;
					return typeof(Class4.Struct5);
				}
				return typeof(GClass3.Class3);
			}
			return typeof(Exception1);
		}
		return typeof(GClass3.Class3);
	}

	internal static long smethod_11()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception0.smethod_2();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Exception0.smethod_2();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							smethod_1();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								Exception1.smethod_0();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									GClass1.smethod_6();
								}
								num++;
								return 13L;
							}
							return 14L;
						}
						return 9L;
					}
					return 4L;
				}
				return 5L;
			}
			return 5L;
		}
		return 5L;
	}
}
