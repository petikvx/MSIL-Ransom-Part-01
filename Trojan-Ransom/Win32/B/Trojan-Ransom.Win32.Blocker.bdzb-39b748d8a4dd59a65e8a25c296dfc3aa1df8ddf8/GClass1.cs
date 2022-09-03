using System;
using System.IO;
using ns0;

public sealed class GClass1 : GClass0, Interface0, Interface1
{
	private uint uint_12;

	private uint uint_13;

	private uint uint_14;

	private uint uint_15;

	private uint[] uint_16;

	private uint[] uint_17;

	private bool bool_2;

	private uint uint_18;

	private static bool bool_3;

	internal uint uint_19 = 255u;

	internal uint uint_20;

	internal uint uint_21;

	public GClass1()
	{
		bool_0 = true;
		uint_20 = 1024u;
		uint_18 = 4u;
		uint_9 = 1048576u;
		base._002Ector();
		Class5.smethod_11();
	}

	public void method_10(int int_0, bool bool_4)
	{
		bool_0 = int_0 > 2;
		bool_2 = bool_4;
		if (bool_0)
		{
			uint_20 = 1024u;
			uint_21 = 0u;
			uint_18 = 4u;
			uint_9 = (bool_2 ? 8388608u : 1048576u);
		}
		else
		{
			uint_21 = 2u;
			uint_18 = 2u;
			uint_9 = 65536u;
		}
	}

	private uint method_11(uint uint_22, out uint uint_23, out uint uint_24)
	{
		uint num = Class6.uint_0[byte_0[uint_22]] ^ byte_0[uint_22 + 1];
		uint_23 = num & (uint_20 - 1);
		num ^= (uint)(byte_0[uint_22 + 2] << 8);
		uint_24 = num & 0x3FFFFu;
		return (num ^ (Class6.uint_0[byte_0[uint_22 + 3]] << 5)) & (uint_9 - 1);
	}

	private uint method_12(uint uint_22)
	{
		return (uint)(byte_0[uint_22] ^ (byte_0[uint_22 + 1] << 8));
	}

	public void imethod_0(Stream stream_1)
	{
		method_3(stream_1);
		for (uint num = 0u; num < uint_9; num++)
		{
			uint_17[num] = 0u;
		}
		if (bool_0)
		{
			for (uint num = 0u; num < uint_20; num++)
			{
				uint_7[num] = 0u;
			}
			for (uint num = 0u; num < 262144; num++)
			{
				uint_8[num] = 0u;
			}
		}
		uint_12 = 0u;
		method_9(-1);
	}

	public void imethod_1()
	{
		method_4();
	}

	public void imethod_2()
	{
		uint_12++;
		if (uint_12 >= uint_13)
		{
			uint_12 = 0u;
		}
		method_5();
		if (uint_3 == int.MaxValue)
		{
			method_14();
		}
	}

	public byte imethod_3(int int_0)
	{
		return method_6(int_0);
	}

	public uint imethod_4(int int_0, uint uint_22, uint uint_23)
	{
		return method_7(int_0, uint_22, uint_23);
	}

	public uint imethod_5()
	{
		return method_8();
	}

	public void imethod_6(uint uint_22, uint uint_23, uint uint_24, uint uint_25)
	{
		uint num = (uint_22 + uint_23 + uint_24 + uint_25) / 2u + 256;
		uint_16 = null;
		uint_17 = null;
		uint_7 = null;
		uint_8 = null;
		method_2(uint_22 + uint_23, uint_24 + uint_25, num);
		if (uint_2 + 256 > int.MaxValue)
		{
			throw new Exception();
		}
		uint_14 = uint_22;
		uint_15 = uint_24;
		uint_13 = uint_22 + 1;
		uint_16 = new uint[uint_13 * 2];
		uint_17 = new uint[uint_9];
		if (bool_0)
		{
			uint_7 = new uint[uint_20];
			uint_8 = new uint[262144];
		}
	}

	public uint imethod_7(uint[] uint_22)
	{
		uint num;
		if (uint_3 + uint_15 <= uint_6)
		{
			num = uint_15;
		}
		else
		{
			num = uint_6 - uint_3;
			if (num < uint_18)
			{
				return 0u;
			}
		}
		uint num2 = ((uint_3 <= uint_14) ? 1u : (uint_3 - uint_14));
		uint num3 = uint_1 + uint_3;
		uint result = 0u;
		uint uint_23 = 0u;
		uint uint_24 = 0u;
		uint num4 = ((!bool_0) ? method_12(num3) : method_11(num3, out uint_23, out uint_24));
		uint num5 = uint_17[num4];
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		uint num9 = 0u;
		bool flag = false;
		bool flag2 = false;
		if (bool_0)
		{
			num6 = uint_7[uint_23];
			num7 = uint_8[uint_24];
			uint_7[uint_23] = uint_3;
			if (num6 >= num2 && byte_0[uint_1 + num6] == byte_0[num3])
			{
				num8 = uint_3 - num6 - 1;
				result = 2u;
				flag = true;
			}
			uint_8[uint_24] = uint_3;
			if (num7 >= num2 && byte_0[uint_1 + num7] == byte_0[num3])
			{
				num9 = uint_3 - num7 - 1;
				result = 3u;
				flag2 = true;
				if (flag)
				{
					if (num9 < num8)
					{
						num8 = num9;
					}
				}
				else
				{
					num8 = num9;
					flag = true;
				}
			}
		}
		uint_17[num4] = uint_3;
		if (num5 < num2)
		{
			uint_16[uint_12 << 1] = 0u;
			uint_16[(uint_12 << 1) + 1] = 0u;
			if (bool_0)
			{
				uint_22[2] = num8;
				uint_22[3] = num9;
			}
			return result;
		}
		uint num10 = (uint_12 << 1) + 1;
		uint num11 = uint_12 << 1;
		uint num13;
		uint num12;
		uint num14 = (num13 = (num12 = uint_21));
		uint_22[num14] = uint_3 - num5 - 1;
		uint num15 = uint_19;
		uint num19;
		while (true)
		{
			if (num15 != 0)
			{
				uint num16 = uint_1 + num5;
				uint num17;
				for (num17 = Math.Min(num13, num12); num17 < num && byte_0[num16 + num17] == byte_0[num3 + num17]; num17++)
				{
				}
				uint num18 = uint_3 - num5;
				while (num17 > num14)
				{
					uint_22[++num14] = num18 - 1;
				}
				num19 = ((num18 <= uint_12) ? (uint_12 - num18) : (uint_12 - num18 + uint_13)) << 1;
				if (num17 != num)
				{
					if (byte_0[num16 + num17] < byte_0[num3 + num17])
					{
						uint_16[num11] = num5;
						num11 = num19 + 1;
						num5 = uint_16[num11];
						if (num17 > num13)
						{
							num13 = num17;
						}
					}
					else
					{
						uint_16[num10] = num5;
						num10 = num19;
						num5 = uint_16[num10];
						if (num17 > num12)
						{
							num12 = num17;
						}
					}
				}
				else
				{
					if (num17 >= uint_15)
					{
						break;
					}
					uint_16[num10] = num5;
					num10 = num19;
					num5 = uint_16[num10];
					if (num17 > num12)
					{
						num12 = num17;
					}
				}
				if (num5 >= num2)
				{
					num15--;
					continue;
				}
			}
			uint_16[num10] = 0u;
			uint_16[num11] = 0u;
			if (bool_0)
			{
				if (flag)
				{
					if (num14 < 2)
					{
						uint_22[2] = num8;
						num14 = 2u;
					}
					else if (num8 < uint_22[2])
					{
						uint_22[2] = num8;
					}
				}
				if (flag2)
				{
					if (num14 < 3)
					{
						uint_22[3] = num9;
						num14 = 3u;
					}
					else if (num9 < uint_22[3])
					{
						uint_22[3] = num9;
					}
				}
			}
			return num14;
		}
		uint_16[num10] = uint_16[num19 + 1];
		uint_16[num11] = uint_16[num19];
		if (bool_0)
		{
			if (flag && num8 < uint_22[2])
			{
				uint_22[2] = num8;
			}
			if (flag2 && num9 < uint_22[3])
			{
				uint_22[3] = num9;
			}
		}
		return num14;
	}

	public void imethod_8()
	{
		uint num;
		if (uint_3 + uint_15 <= uint_6)
		{
			num = uint_15;
		}
		else
		{
			num = uint_6 - uint_3;
			if (num < uint_18)
			{
				return;
			}
		}
		uint num2 = ((uint_3 <= uint_14) ? 1u : (uint_3 - uint_14));
		uint num3 = uint_1 + uint_3;
		uint uint_ = 0u;
		uint uint_2 = 0u;
		uint num4 = ((!bool_0) ? method_12(num3) : method_11(num3, out uint_, out uint_2));
		uint num5 = uint_17[num4];
		if (bool_0)
		{
			uint_7[uint_] = uint_3;
			uint_8[uint_2] = uint_3;
		}
		uint_17[num4] = uint_3;
		if (num5 < num2)
		{
			uint_16[uint_12 << 1] = 0u;
			uint_16[(uint_12 << 1) + 1] = 0u;
			return;
		}
		uint num6 = (uint_12 << 1) + 1;
		uint num7 = uint_12 << 1;
		uint num8;
		uint num9 = (num8 = uint_21);
		uint num10 = uint_19;
		uint num14;
		while (true)
		{
			if (num10 != 0)
			{
				uint num11 = uint_1 + num5;
				uint num12;
				for (num12 = Math.Min(num9, num8); num12 < num && byte_0[num11 + num12] == byte_0[num3 + num12]; num12++)
				{
				}
				uint num13 = uint_3 - num5;
				num14 = ((num13 <= uint_12) ? (uint_12 - num13) : (uint_12 - num13 + uint_13)) << 1;
				if (num12 != num)
				{
					if (byte_0[num11 + num12] < byte_0[num3 + num12])
					{
						uint_16[num7] = num5;
						num7 = num14 + 1;
						num5 = uint_16[num7];
						if (num12 > num9)
						{
							num9 = num12;
						}
					}
					else
					{
						uint_16[num6] = num5;
						num6 = num14;
						num5 = uint_16[num6];
						if (num12 > num8)
						{
							num8 = num12;
						}
					}
				}
				else
				{
					if (num12 >= uint_15)
					{
						break;
					}
					uint_16[num6] = num5;
					num6 = num14;
					num5 = uint_16[num6];
					if (num12 > num8)
					{
						num8 = num12;
					}
				}
				if (num5 >= num2)
				{
					num10--;
					continue;
				}
			}
			uint_16[num6] = 0u;
			uint_16[num7] = 0u;
			return;
		}
		uint_16[num6] = uint_16[num14 + 1];
		uint_16[num7] = uint_16[num14];
	}

	private void method_13(uint[] uint_22, uint uint_23, uint uint_24)
	{
		for (uint num = 0u; num < uint_23; num++)
		{
			uint num2 = uint_22[num];
			num2 = (uint_22[num] = ((num2 > uint_24) ? (num2 - uint_24) : 0u));
		}
	}

	private void method_14()
	{
		uint num = uint_3 - uint_14;
		uint num2 = num - 1;
		method_13(uint_16, uint_13 * 2, num2);
		method_13(uint_17, uint_9, num2);
		if (bool_0)
		{
			method_13(uint_7, uint_20, num2);
			method_13(uint_8, 262144u, num2);
		}
		method_9((int)num2);
	}

	public void method_15(uint uint_22)
	{
		uint num = (uint_19 = uint_22);
	}

	internal static long smethod_5()
	{
		AppDomain.CurrentDomain.SetData("17d17f2e15b34ff594bb793bf9620023", null);
		return 10L;
	}

	internal static void smethod_6()
	{
		smethod_6();
	}

	internal static byte smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("17d17f2e15b34ff594bb793bf9620023");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				smethod_5();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					Exception1.smethod_0();
				}
				num++;
				return 22;
			}
			return 10;
		}
		return 20;
	}

	internal static long smethod_8()
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
					smethod_5();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						Class5.smethod_0();
					}
					num++;
					if (array[num] >= 248)
					{
						if (248 != array[num])
						{
							GClass2.smethod_0();
						}
						num++;
						if (array[num] >= 218)
						{
							if (218 != array[num])
							{
								smethod_5();
							}
							num++;
							return 0L;
						}
						return 0L;
					}
					return 8L;
				}
				return 3L;
			}
			return 2L;
		}
		return 4L;
	}

	internal static int smethod_9()
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
					GClass2.smethod_0();
				}
				num++;
				if (array[num] >= 29)
				{
					if (29 != array[num])
					{
						GClass2.smethod_0();
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
								Exception1.smethod_0();
							}
							num++;
							if (array[num] >= 33)
							{
								if (33 != array[num])
								{
									Exception0.smethod_0();
								}
								num++;
								if (array[num] >= 232)
								{
									if (232 != array[num])
									{
										Exception0.smethod_0();
									}
									num++;
									if (array[num] >= 106)
									{
										if (106 != array[num])
										{
											Exception0.smethod_0();
										}
										num++;
										return 11;
									}
									return 14;
								}
								return 8;
							}
							return 7;
						}
						return 0;
					}
					return 3;
				}
				return 14;
			}
			return 4;
		}
		return 13;
	}

	internal static object smethod_10()
	{
		byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
		AppDomain.CurrentDomain.SetData("17d17f2e15b34ff594bb793bf9620023", bytes);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)bytes);
		}
		return null;
	}
}
