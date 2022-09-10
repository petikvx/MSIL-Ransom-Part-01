using System;
using System.IO;
using ns0;

public sealed class GClass1 : GClass0, Interface0, Interface1
{
	internal uint uint_9;

	internal uint uint_10;

	internal uint uint_11;

	internal uint uint_12;

	internal uint[] uint_13;

	internal uint[] uint_14;

	internal uint[] uint_15;

	internal uint[] uint_16;

	internal uint uint_17 = 255u;

	internal bool bool_1 = true;

	internal bool bool_2;

	internal uint uint_18 = 1024u;

	internal uint uint_19;

	internal uint uint_20 = 4u;

	internal uint uint_21 = 1048576u;

	public void method_10(int int_0, bool bool_3)
	{
		bool flag = (bool_1 = int_0 > 2);
		bool flag2 = (bool_2 = bool_3);
		if (bool_1)
		{
			uint_18 = 1024u;
			uint_19 = 0u;
			uint_20 = 4u;
			uint num = (uint_21 = (bool_2 ? 8388608u : 1048576u));
		}
		else
		{
			uint_19 = 2u;
			uint_20 = 2u;
			uint_21 = 65536u;
		}
	}

	private uint method_11(uint uint_22, out uint uint_23, out uint uint_24)
	{
		uint num = Class6.uint_0[byte_0[uint_22]] ^ byte_0[uint_22 + 1];
		uint_23 = num & (uint_18 - 1);
		num ^= (uint)(byte_0[uint_22 + 2] << 8);
		uint_24 = num & 0x3FFFFu;
		return (num ^ (Class6.uint_0[byte_0[uint_22 + 3]] << 5)) & (uint_21 - 1);
	}

	private uint method_12(uint uint_22)
	{
		return (uint)(byte_0[uint_22] ^ (byte_0[uint_22 + 1] << 8));
	}

	public void imethod_0(Stream stream_1)
	{
		method_3(stream_1);
		for (uint num = 0u; num < uint_21; num++)
		{
			uint_14[num] = 0u;
		}
		if (bool_1)
		{
			for (uint num = 0u; num < uint_18; num++)
			{
				uint_15[num] = 0u;
			}
			for (uint num = 0u; num < 262144; num++)
			{
				uint_16[num] = 0u;
			}
		}
		uint_9 = 0u;
		method_9(-1);
	}

	public void imethod_1()
	{
		method_4();
	}

	public void imethod_2()
	{
		uint_9++;
		if (uint_9 >= uint_10)
		{
			uint_9 = 0u;
		}
		method_5();
		if (uint_2 == int.MaxValue)
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
		uint[] array = (uint_13 = null);
		uint[] array2 = (uint_14 = null);
		uint[] array3 = (uint_15 = null);
		uint[] array4 = (uint_16 = null);
		method_2(uint_22 + uint_23, uint_24 + uint_25, num);
		if (uint_1 + 256 > int.MaxValue)
		{
			throw new Exception();
		}
		uint num2 = (uint_11 = uint_22);
		uint num3 = (uint_12 = uint_24);
		uint num4 = (uint_10 = uint_22 + 1);
		uint[] array5 = (uint_13 = new uint[uint_10 * 2]);
		uint[] array6 = (uint_14 = new uint[uint_21]);
		if (bool_1)
		{
			uint[] array7 = (uint_15 = new uint[uint_18]);
			uint[] array8 = (uint_16 = new uint[262144]);
		}
	}

	public uint imethod_7(uint[] uint_22)
	{
		uint num;
		if (uint_2 + uint_12 <= uint_3)
		{
			num = uint_12;
		}
		else
		{
			num = uint_3 - uint_2;
			if (num < uint_20)
			{
				return 0u;
			}
		}
		uint num2 = ((uint_2 <= uint_11) ? 1u : (uint_2 - uint_11));
		uint num3 = uint_0 + uint_2;
		uint result = 0u;
		uint uint_23 = 0u;
		uint uint_24 = 0u;
		uint num4 = ((!bool_1) ? method_12(num3) : method_11(num3, out uint_23, out uint_24));
		uint num5 = uint_14[num4];
		uint num6 = 0u;
		uint num7 = 0u;
		uint num8 = 0u;
		uint num9 = 0u;
		bool flag = false;
		bool flag2 = false;
		if (bool_1)
		{
			num6 = uint_15[uint_23];
			num7 = uint_16[uint_24];
			uint_15[uint_23] = uint_2;
			if (num6 >= num2 && byte_0[uint_0 + num6] == byte_0[num3])
			{
				num8 = uint_2 - num6 - 1;
				result = 2u;
				flag = true;
			}
			uint_16[uint_24] = uint_2;
			if (num7 >= num2 && byte_0[uint_0 + num7] == byte_0[num3])
			{
				num9 = uint_2 - num7 - 1;
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
		uint_14[num4] = uint_2;
		if (num5 < num2)
		{
			uint_13[uint_9 << 1] = 0u;
			uint_13[(uint_9 << 1) + 1] = 0u;
			if (bool_1)
			{
				uint_22[2] = num8;
				uint_22[3] = num9;
			}
			return result;
		}
		uint num10 = (uint_9 << 1) + 1;
		uint num11 = uint_9 << 1;
		uint num13;
		uint num12;
		uint num14 = (num13 = (num12 = uint_19));
		uint_22[num14] = uint_2 - num5 - 1;
		uint num15 = uint_17;
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
				uint num18 = uint_2 - num5;
				while (num17 > num14)
				{
					uint_22[++num14] = num18 - 1;
				}
				num19 = ((num18 <= uint_9) ? (uint_9 - num18) : (uint_9 - num18 + uint_10)) << 1;
				if (num17 != num)
				{
					if (byte_0[num16 + num17] < byte_0[num3 + num17])
					{
						uint_13[num11] = num5;
						num11 = num19 + 1;
						num5 = uint_13[num11];
						if (num17 > num13)
						{
							num13 = num17;
						}
					}
					else
					{
						uint_13[num10] = num5;
						num10 = num19;
						num5 = uint_13[num10];
						if (num17 > num12)
						{
							num12 = num17;
						}
					}
				}
				else
				{
					if (num17 >= uint_12)
					{
						break;
					}
					uint_13[num10] = num5;
					num10 = num19;
					num5 = uint_13[num10];
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
			uint_13[num10] = 0u;
			uint_13[num11] = 0u;
			if (bool_1)
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
		uint_13[num10] = uint_13[num19 + 1];
		uint_13[num11] = uint_13[num19];
		if (bool_1)
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
		if (base.uint_2 + uint_12 <= uint_3)
		{
			num = uint_12;
		}
		else
		{
			num = uint_3 - base.uint_2;
			if (num < uint_20)
			{
				return;
			}
		}
		uint num2 = ((base.uint_2 <= uint_11) ? 1u : (base.uint_2 - uint_11));
		uint num3 = uint_0 + base.uint_2;
		uint uint_ = 0u;
		uint uint_2 = 0u;
		uint num4 = ((!bool_1) ? method_12(num3) : method_11(num3, out uint_, out uint_2));
		uint num5 = uint_14[num4];
		if (bool_1)
		{
			uint_15[uint_] = base.uint_2;
			uint_16[uint_2] = base.uint_2;
		}
		uint_14[num4] = base.uint_2;
		if (num5 < num2)
		{
			uint_13[uint_9 << 1] = 0u;
			uint_13[(uint_9 << 1) + 1] = 0u;
			return;
		}
		uint num6 = (uint_9 << 1) + 1;
		uint num7 = uint_9 << 1;
		uint num8;
		uint num9 = (num8 = uint_19);
		uint num10 = uint_17;
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
				uint num13 = base.uint_2 - num5;
				num14 = ((num13 <= uint_9) ? (uint_9 - num13) : (uint_9 - num13 + uint_10)) << 1;
				if (num12 != num)
				{
					if (byte_0[num11 + num12] < byte_0[num3 + num12])
					{
						uint_13[num7] = num5;
						num7 = num14 + 1;
						num5 = uint_13[num7];
						if (num12 > num9)
						{
							num9 = num12;
						}
					}
					else
					{
						uint_13[num6] = num5;
						num6 = num14;
						num5 = uint_13[num6];
						if (num12 > num8)
						{
							num8 = num12;
						}
					}
				}
				else
				{
					if (num12 >= uint_12)
					{
						break;
					}
					uint_13[num6] = num5;
					num6 = num14;
					num5 = uint_13[num6];
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
			uint_13[num6] = 0u;
			uint_13[num7] = 0u;
			return;
		}
		uint_13[num6] = uint_13[num14 + 1];
		uint_13[num7] = uint_13[num14];
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
		uint num = uint_2 - uint_11;
		uint num2 = num - 1;
		method_13(uint_13, uint_10 * 2, num2);
		method_13(uint_14, uint_21, num2);
		if (bool_1)
		{
			method_13(uint_15, uint_18, num2);
			method_13(uint_16, 262144u, num2);
		}
		method_9((int)num2);
	}

	public void method_15(uint uint_22)
	{
		uint num = (uint_17 = uint_22);
	}
}
