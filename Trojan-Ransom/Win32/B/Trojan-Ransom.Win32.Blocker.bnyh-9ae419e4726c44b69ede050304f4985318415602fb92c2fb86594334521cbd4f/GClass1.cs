using System;
using System.IO;
using ns0;

public sealed class GClass1 : GClass0, Interface0, Interface1
{
	private uint uint_14;

	private uint uint_15;

	private uint uint_16;

	private uint[] uint_17;

	private bool bool_2;

	internal uint[] uint_18;

	internal uint uint_19 = 255u;

	internal uint uint_20;

	public GClass1()
	{
		bool_1 = true;
		uint_20 = 1024u;
		uint_9 = 4u;
		uint_10 = 1048576u;
		base._002Ector();
		GClass0.smethod_6();
	}

	public void method_10(int int_0, bool bool_3)
	{
		bool_1 = int_0 > 2;
		bool_2 = bool_3;
		if (bool_1)
		{
			uint_20 = 1024u;
			uint_8 = 0u;
			uint_9 = 4u;
			uint_10 = (bool_2 ? 8388608u : 1048576u);
		}
		else
		{
			uint_8 = 2u;
			uint_9 = 2u;
			uint_10 = 65536u;
		}
	}

	private uint method_11(uint uint_21, out uint uint_22, out uint uint_23)
	{
		uint num = Class6.uint_0[byte_0[uint_21]] ^ byte_0[uint_21 + 1];
		uint_22 = num & (uint_20 - 1);
		num ^= (uint)(byte_0[uint_21 + 2] << 8);
		uint_23 = num & 0x3FFFFu;
		return (num ^ (Class6.uint_0[byte_0[uint_21 + 3]] << 5)) & (uint_10 - 1);
	}

	private uint method_12(uint uint_21)
	{
		return (uint)(byte_0[uint_21] ^ (byte_0[uint_21 + 1] << 8));
	}

	public void imethod_0(Stream stream_1)
	{
		method_3(stream_1);
		for (uint num = 0u; num < uint_10; num++)
		{
			uint_6[num] = 0u;
		}
		if (bool_1)
		{
			for (uint num = 0u; num < uint_20; num++)
			{
				uint_18[num] = 0u;
			}
			for (uint num = 0u; num < 262144; num++)
			{
				uint_7[num] = 0u;
			}
		}
		uint_14 = 0u;
		method_9(-1);
	}

	public void imethod_1()
	{
		method_4();
	}

	public void imethod_2()
	{
		uint_14++;
		if (uint_14 >= uint_15)
		{
			uint_14 = 0u;
		}
		method_5();
		if (rceResolve == int.MaxValue)
		{
			method_14();
		}
	}

	public byte imethod_3(int int_0)
	{
		return method_6(int_0);
	}

	public uint imethod_4(int int_0, uint uint_21, uint uint_22)
	{
		return method_7(int_0, uint_21, uint_22);
	}

	public uint imethod_5()
	{
		return method_8();
	}

	public void imethod_6(uint uint_21, uint uint_22, uint uint_23, uint uint_24)
	{
		uint num = (uint_21 + uint_22 + uint_23 + uint_24) / 2u + 256;
		uint_17 = null;
		uint_6 = null;
		uint[] array = (uint_18 = null);
		uint_7 = null;
		method_2(uint_21 + uint_22, uint_23 + uint_24, num);
		if (uint_1 + 256 > int.MaxValue)
		{
			throw new Exception();
		}
		uint_5 = uint_21;
		uint_16 = uint_23;
		uint_15 = uint_21 + 1;
		uint_17 = new uint[uint_15 * 2];
		uint_6 = new uint[uint_10];
		if (bool_1)
		{
			uint[] array2 = (uint_18 = new uint[uint_20]);
			uint_7 = new uint[262144];
		}
	}

	public uint imethod_7(uint[] uint_21)
	{
		uint num;
		if (rceResolve + uint_16 <= uint_4)
		{
			num = uint_16;
		}
		else
		{
			num = uint_4 - rceResolve;
			if (num < uint_9)
			{
				return 0u;
			}
		}
		uint num2 = ((rceResolve <= uint_5) ? 1u : (rceResolve - uint_5));
		uint num3 = uint_0 + rceResolve;
		uint result = 0u;
		uint uint_22 = 0u;
		uint uint_23 = 0u;
		uint num4 = ((!bool_1) ? method_12(num3) : method_11(num3, out uint_22, out uint_23));
		uint num5 = uint_6[num4];
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		uint num9 = 0u;
		bool flag = false;
		bool flag2 = false;
		if (bool_1)
		{
			num6 = uint_18[uint_22];
			num7 = uint_7[uint_23];
			uint_18[uint_22] = rceResolve;
			if (num6 >= num2 && byte_0[uint_0 + num6] == byte_0[num3])
			{
				num8 = rceResolve - num6 - 1;
				result = 2u;
				flag = true;
			}
			uint_7[uint_23] = rceResolve;
			if (num7 >= num2 && byte_0[uint_0 + num7] == byte_0[num3])
			{
				num9 = rceResolve - num7 - 1;
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
		uint_6[num4] = rceResolve;
		if (num5 < num2)
		{
			uint_17[uint_14 << 1] = 0u;
			uint_17[(uint_14 << 1) + 1] = 0u;
			if (bool_1)
			{
				uint_21[2] = num8;
				uint_21[3] = num9;
			}
			return result;
		}
		uint num10 = (uint_14 << 1) + 1;
		uint num11 = uint_14 << 1;
		uint num13;
		uint num12;
		uint num14 = (num13 = (num12 = uint_8));
		uint_21[num14] = rceResolve - num5 - 1;
		uint num15 = uint_19;
		uint num19;
		while (true)
		{
			if (num15 != 0)
			{
				uint num16 = uint_0 + num5;
				uint num17;
				for (num17 = Math.Min(num13, num12); num17 < num && byte_0[num16 + num17] == byte_0[num3 + num17]; num17++)
				{
				}
				uint num18 = rceResolve - num5;
				while (num17 > num14)
				{
					uint_21[++num14] = num18 - 1;
				}
				num19 = ((num18 <= uint_14) ? (uint_14 - num18) : (uint_14 - num18 + uint_15)) << 1;
				if (num17 != num)
				{
					if (byte_0[num16 + num17] < byte_0[num3 + num17])
					{
						uint_17[num11] = num5;
						num11 = num19 + 1;
						num5 = uint_17[num11];
						if (num17 > num13)
						{
							num13 = num17;
						}
					}
					else
					{
						uint_17[num10] = num5;
						num10 = num19;
						num5 = uint_17[num10];
						if (num17 > num12)
						{
							num12 = num17;
						}
					}
				}
				else
				{
					if (num17 >= uint_16)
					{
						break;
					}
					uint_17[num10] = num5;
					num10 = num19;
					num5 = uint_17[num10];
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
			uint_17[num10] = 0u;
			uint_17[num11] = 0u;
			if (bool_1)
			{
				if (flag)
				{
					if (num14 < 2)
					{
						uint_21[2] = num8;
						num14 = 2u;
					}
					else if (num8 < uint_21[2])
					{
						uint_21[2] = num8;
					}
				}
				if (flag2)
				{
					if (num14 < 3)
					{
						uint_21[3] = num9;
						num14 = 3u;
					}
					else if (num9 < uint_21[3])
					{
						uint_21[3] = num9;
					}
				}
			}
			return num14;
		}
		uint_17[num10] = uint_17[num19 + 1];
		uint_17[num11] = uint_17[num19];
		if (bool_1)
		{
			if (flag && num8 < uint_21[2])
			{
				uint_21[2] = num8;
			}
			if (flag2 && num9 < uint_21[3])
			{
				uint_21[3] = num9;
			}
		}
		return num14;
	}

	public void imethod_8()
	{
		uint num;
		if (rceResolve + uint_16 <= uint_4)
		{
			num = uint_16;
		}
		else
		{
			num = uint_4 - rceResolve;
			if (num < uint_9)
			{
				return;
			}
		}
		uint num2 = ((rceResolve <= uint_5) ? 1u : (rceResolve - uint_5));
		uint num3 = uint_0 + rceResolve;
		uint uint_ = 0u;
		uint uint_2 = 0u;
		uint num4 = ((!bool_1) ? method_12(num3) : method_11(num3, out uint_, out uint_2));
		uint num5 = uint_6[num4];
		if (bool_1)
		{
			uint_18[uint_] = rceResolve;
			uint_7[uint_2] = rceResolve;
		}
		uint_6[num4] = rceResolve;
		if (num5 < num2)
		{
			uint_17[uint_14 << 1] = 0u;
			uint_17[(uint_14 << 1) + 1] = 0u;
			return;
		}
		uint num6 = (uint_14 << 1) + 1;
		uint num7 = uint_14 << 1;
		uint num8;
		uint num9 = (num8 = uint_8);
		uint num10 = uint_19;
		uint num14;
		while (true)
		{
			if (num10 != 0)
			{
				uint num11 = uint_0 + num5;
				uint num12;
				for (num12 = Math.Min(num9, num8); num12 < num && byte_0[num11 + num12] == byte_0[num3 + num12]; num12++)
				{
				}
				uint num13 = rceResolve - num5;
				num14 = ((num13 <= uint_14) ? (uint_14 - num13) : (uint_14 - num13 + uint_15)) << 1;
				if (num12 != num)
				{
					if (byte_0[num11 + num12] < byte_0[num3 + num12])
					{
						uint_17[num7] = num5;
						num7 = num14 + 1;
						num5 = uint_17[num7];
						if (num12 > num9)
						{
							num9 = num12;
						}
					}
					else
					{
						uint_17[num6] = num5;
						num6 = num14;
						num5 = uint_17[num6];
						if (num12 > num8)
						{
							num8 = num12;
						}
					}
				}
				else
				{
					if (num12 >= uint_16)
					{
						break;
					}
					uint_17[num6] = num5;
					num6 = num14;
					num5 = uint_17[num6];
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
			uint_17[num6] = 0u;
			uint_17[num7] = 0u;
			return;
		}
		uint_17[num6] = uint_17[num14 + 1];
		uint_17[num7] = uint_17[num14];
	}

	private void method_13(uint[] uint_21, uint uint_22, uint uint_23)
	{
		for (uint num = 0u; num < uint_22; num++)
		{
			uint num2 = uint_21[num];
			num2 = (uint_21[num] = ((num2 > uint_23) ? (num2 - uint_23) : 0u));
		}
	}

	private void method_14()
	{
		uint num = rceResolve - uint_5;
		uint num2 = num - 1;
		method_13(uint_17, uint_15 * 2, num2);
		method_13(uint_6, uint_10, num2);
		if (bool_1)
		{
			method_13(uint_18, uint_20, num2);
			method_13(uint_7, 262144u, num2);
		}
		method_9((int)num2);
	}

	public void method_15(uint uint_21)
	{
		uint num = (uint_19 = uint_21);
	}

	internal static object smethod_10()
	{
		smethod_10();
		return null;
	}

	internal static int smethod_11()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
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
					Exception1.smethod_0();
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
							Exception0.smethod_3();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								GClass2.smethod_3();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									GClass3.smethod_0();
								}
								num++;
								if (array[num] >= 229)
								{
									if (229 != array[num])
									{
										smethod_10();
									}
									num++;
									return 4;
								}
								return 0;
							}
							return 14;
						}
						return 1;
					}
					return 4;
				}
				return 14;
			}
			return 13;
		}
		return 9;
	}

	internal static object smethod_12()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				GClass0.smethod_1();
			}
			num++;
			if (array[num] >= 208)
			{
				if (208 != array[num])
				{
					smethod_10();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass2.smethod_2();
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

	internal static long smethod_13()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
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
					GClass0.smethod_2();
				}
				num++;
				return 2L;
			}
			return 4L;
		}
		return 7L;
	}

	internal static void smethod_14()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Exception1.smethod_1();
			}
			num++;
		}
	}

	internal static void smethod_15()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("fe8ac553a4f34e4a8e054c1983ee8380");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Exception0.smethod_0();
		}
		num++;
		if (array[num] >= 208)
		{
			if (208 != array[num])
			{
				Exception0.smethod_2();
			}
			num++;
		}
	}

	internal static int smethod_16()
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
					GClass2.smethod_3();
				}
				num++;
				if (array[num] >= 71)
				{
					if (71 != array[num])
					{
						GClass2.smethod_2();
					}
					num++;
					if (array[num] >= 251)
					{
						if (251 != array[num])
						{
							Exception1.smethod_1();
						}
						num++;
						if (array[num] >= 144)
						{
							if (144 != array[num])
							{
								Exception1.smethod_1();
							}
							num++;
							if (array[num] >= 220)
							{
								if (220 != array[num])
								{
									GClass2.smethod_2();
								}
								num++;
								return 14;
							}
							return 6;
						}
						return 0;
					}
					return 5;
				}
				return 8;
			}
			return 4;
		}
		return 15;
	}
}
