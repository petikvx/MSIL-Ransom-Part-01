using System;

internal sealed class Class11
{
	private enum Enum1
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9
	}

	private const int int_0 = 1440;

	internal static readonly int[] int_1 = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	private Enum1 enum1_0;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal int[] int_5;

	internal int[] int_6 = new int[1];

	internal int[] int_7 = new int[1];

	internal Class13 class13_0 = new Class13();

	internal int int_8;

	internal GClass5 gclass5_0;

	internal int int_9;

	internal int int_10;

	internal int[] int_11;

	internal byte[] byte_0;

	internal int int_12;

	internal int int_13;

	internal int int_14;

	internal object object_0;

	internal uint uint_0;

	internal Class15 class15_0 = new Class15();

	internal Class11(GClass5 codec, object checkfn, int w)
	{
		gclass5_0 = codec;
		int_11 = new int[4320];
		byte_0 = new byte[w];
		int_12 = w;
		object_0 = checkfn;
		enum1_0 = Enum1.const_0;
		method_0();
	}

	internal uint method_0()
	{
		uint result = uint_0;
		enum1_0 = Enum1.const_0;
		int_9 = 0;
		int_10 = 0;
		int_14 = 0;
		int_13 = 0;
		if (object_0 != null)
		{
			gclass5_0.uint_0 = (uint_0 = GClass4.smethod_0(0u, null, 0, 0));
		}
		return result;
	}

	internal int method_1(int int_15)
	{
		int num = gclass5_0.int_0;
		int num2 = gclass5_0.int_1;
		int num3 = int_10;
		int i = int_9;
		int num4 = int_14;
		int num5 = ((num4 < int_13) ? (int_13 - num4 - 1) : (int_12 - num4));
		while (true)
		{
			switch (enum1_0)
			{
			case Enum1.const_6:
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				int_15 = class13_0.method_1(this, int_15);
				if (int_15 == 1)
				{
					int_15 = 0;
					num = gclass5_0.int_0;
					num2 = gclass5_0.int_1;
					num3 = int_10;
					i = int_9;
					num4 = int_14;
					num5 = ((num4 < int_13) ? (int_13 - num4 - 1) : (int_12 - num4));
					if (int_8 == 0)
					{
						enum1_0 = Enum1.const_0;
						break;
					}
					enum1_0 = Enum1.const_7;
					goto case Enum1.const_7;
				}
				return method_5(int_15);
			case Enum1.const_5:
			{
				int num6;
				while (true)
				{
					num6 = int_3;
					if (int_4 >= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F))
					{
						break;
					}
					for (num6 = int_6[0]; i < num6; i += 8)
					{
						if (num2 != 0)
						{
							int_15 = 0;
							num2--;
							num3 |= (gclass5_0.byte_0[num++] & 0xFF) << i;
							continue;
						}
						int_10 = num3;
						int_9 = i;
						gclass5_0.int_1 = num2;
						gclass5_0.long_0 += num - gclass5_0.int_0;
						gclass5_0.int_0 = num;
						int_14 = num4;
						return method_5(int_15);
					}
					num6 = int_11[(int_7[0] + (num3 & Class12.int_0[num6])) * 3 + 1];
					int num7 = int_11[(int_7[0] + (num3 & Class12.int_0[num6])) * 3 + 2];
					if (num7 < 16)
					{
						num3 >>= num6;
						i -= num6;
						int_5[int_4++] = num7;
						continue;
					}
					int num8 = ((num7 == 18) ? 7 : (num7 - 14));
					int num9 = ((num7 == 18) ? 11 : 3);
					for (; i < num6 + num8; i += 8)
					{
						if (num2 != 0)
						{
							int_15 = 0;
							num2--;
							num3 |= (gclass5_0.byte_0[num++] & 0xFF) << i;
							continue;
						}
						int_10 = num3;
						int_9 = i;
						gclass5_0.int_1 = num2;
						gclass5_0.long_0 += num - gclass5_0.int_0;
						gclass5_0.int_0 = num;
						int_14 = num4;
						return method_5(int_15);
					}
					num3 >>= num6;
					i -= num6;
					num9 += num3 & Class12.int_0[num8];
					num3 >>= num8;
					i -= num8;
					num8 = int_4;
					num6 = int_3;
					if (num8 + num9 <= 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F) && (num7 != 16 || num8 >= 1))
					{
						num7 = ((num7 == 16) ? int_5[num8 - 1] : 0);
						do
						{
							int_5[num8++] = num7;
						}
						while (--num9 != 0);
						int_4 = num8;
						continue;
					}
					int_5 = null;
					enum1_0 = Enum1.const_9;
					gclass5_0.string_0 = "invalid bit length repeat";
					int_15 = -3;
					int_10 = num3;
					int_9 = i;
					gclass5_0.int_1 = num2;
					gclass5_0.long_0 += num - gclass5_0.int_0;
					gclass5_0.int_0 = num;
					int_14 = num4;
					return method_5(-3);
				}
				int_7[0] = -1;
				int[] array5 = new int[1] { 9 };
				int[] array6 = new int[1] { 6 };
				int[] array7 = new int[1];
				int[] array8 = new int[1];
				num6 = int_3;
				num6 = class15_0.method_2(257 + (num6 & 0x1F), 1 + ((num6 >> 5) & 0x1F), int_5, array5, array6, array7, array8, int_11, gclass5_0);
				if (num6 == 0)
				{
					class13_0.method_0(array5[0], array6[0], int_11, array7[0], int_11, array8[0]);
					enum1_0 = Enum1.const_6;
					goto case Enum1.const_6;
				}
				if (num6 == -3)
				{
					int_5 = null;
					enum1_0 = Enum1.const_9;
				}
				int_15 = num6;
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(int_15);
			}
			case Enum1.const_4:
			{
				while (int_4 < 4 + (int_3 >> 10))
				{
					for (; i < 3; i += 8)
					{
						if (num2 != 0)
						{
							int_15 = 0;
							num2--;
							num3 |= (gclass5_0.byte_0[num++] & 0xFF) << i;
							continue;
						}
						int_10 = num3;
						int_9 = i;
						gclass5_0.int_1 = num2;
						gclass5_0.long_0 += num - gclass5_0.int_0;
						gclass5_0.int_0 = num;
						int_14 = num4;
						return method_5(int_15);
					}
					int_5[int_1[int_4++]] = num3 & 7;
					num3 >>= 3;
					i -= 3;
				}
				while (int_4 < 19)
				{
					int_5[int_1[int_4++]] = 0;
				}
				int_6[0] = 7;
				int num6 = class15_0.method_1(int_5, int_6, int_7, int_11, gclass5_0);
				if (num6 == 0)
				{
					int_4 = 0;
					enum1_0 = Enum1.const_5;
					goto case Enum1.const_5;
				}
				int_15 = num6;
				if (int_15 == -3)
				{
					int_5 = null;
					enum1_0 = Enum1.const_9;
				}
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(int_15);
			}
			case Enum1.const_3:
			{
				for (; i < 14; i += 8)
				{
					if (num2 != 0)
					{
						int_15 = 0;
						num2--;
						num3 |= (gclass5_0.byte_0[num++] & 0xFF) << i;
						continue;
					}
					int_10 = num3;
					int_9 = i;
					gclass5_0.int_1 = num2;
					gclass5_0.long_0 += num - gclass5_0.int_0;
					gclass5_0.int_0 = num;
					int_14 = num4;
					return method_5(int_15);
				}
				int num6 = (int_3 = num3 & 0x3FFF);
				if ((num6 & 0x1F) <= 29 && ((num6 >> 5) & 0x1F) <= 29)
				{
					num6 = 258 + (num6 & 0x1F) + ((num6 >> 5) & 0x1F);
					if (int_5 != null && int_5.Length >= num6)
					{
						Array.Clear(int_5, 0, num6);
					}
					else
					{
						int_5 = new int[num6];
					}
					num3 >>= 14;
					i -= 14;
					int_4 = 0;
					enum1_0 = Enum1.const_4;
					goto case Enum1.const_4;
				}
				enum1_0 = Enum1.const_9;
				gclass5_0.string_0 = "too many length or distance symbols";
				int_15 = -3;
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(-3);
			}
			case Enum1.const_2:
				if (num2 != 0)
				{
					if (num5 == 0)
					{
						if (num4 == int_12 && int_13 != 0)
						{
							num4 = 0;
							num5 = ((0 < int_13) ? (int_13 - num4 - 1) : (int_12 - num4));
						}
						if (num5 == 0)
						{
							int_14 = num4;
							int_15 = method_5(int_15);
							num4 = int_14;
							num5 = ((num4 < int_13) ? (int_13 - num4 - 1) : (int_12 - num4));
							if (num4 == int_12 && int_13 != 0)
							{
								num4 = 0;
								num5 = ((0 < int_13) ? (int_13 - num4 - 1) : (int_12 - num4));
							}
							if (num5 == 0)
							{
								int_10 = num3;
								int_9 = i;
								gclass5_0.int_1 = num2;
								gclass5_0.long_0 += num - gclass5_0.int_0;
								gclass5_0.int_0 = num;
								int_14 = num4;
								return method_5(int_15);
							}
						}
					}
					int_15 = 0;
					int num6 = int_2;
					if (num6 > num2)
					{
						num6 = num2;
					}
					if (num6 > num5)
					{
						num6 = num5;
					}
					Array.Copy(gclass5_0.byte_0, num, byte_0, num4, num6);
					num += num6;
					num2 -= num6;
					num4 += num6;
					num5 -= num6;
					if ((int_2 -= num6) == 0)
					{
						enum1_0 = ((int_8 != 0) ? Enum1.const_7 : Enum1.const_0);
					}
					break;
				}
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(int_15);
			case Enum1.const_1:
				for (; i < 32; i += 8)
				{
					if (num2 != 0)
					{
						int_15 = 0;
						num2--;
						num3 |= (gclass5_0.byte_0[num++] & 0xFF) << i;
						continue;
					}
					int_10 = num3;
					int_9 = i;
					gclass5_0.int_1 = num2;
					gclass5_0.long_0 += num - gclass5_0.int_0;
					gclass5_0.int_0 = num;
					int_14 = num4;
					return method_5(int_15);
				}
				if (((~num3 >> 16) & 0xFFFF) == (num3 & 0xFFFF))
				{
					int_2 = num3 & 0xFFFF;
					i = 0;
					num3 = 0;
					enum1_0 = ((int_2 != 0) ? Enum1.const_2 : ((int_8 != 0) ? Enum1.const_7 : Enum1.const_0));
					break;
				}
				enum1_0 = Enum1.const_9;
				gclass5_0.string_0 = "invalid stored block lengths";
				int_15 = -3;
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(-3);
			case Enum1.const_0:
			{
				for (; i < 3; i += 8)
				{
					if (num2 != 0)
					{
						int_15 = 0;
						num2--;
						num3 |= (gclass5_0.byte_0[num++] & 0xFF) << i;
						continue;
					}
					int_10 = num3;
					int_9 = i;
					gclass5_0.int_1 = num2;
					gclass5_0.long_0 += num - gclass5_0.int_0;
					gclass5_0.int_0 = num;
					int_14 = num4;
					return method_5(int_15);
				}
				int num6 = num3 & 7;
				int_8 = num6 & 1;
				switch ((uint)num6 >> 1)
				{
				case 0u:
					num3 >>= 3;
					i -= 3;
					num6 = i & 7;
					num3 >>= num6;
					i -= num6;
					enum1_0 = Enum1.const_1;
					break;
				case 1u:
				{
					int[] array = new int[1];
					int[] array2 = new int[1];
					int[][] array3 = new int[1][];
					int[][] array4 = new int[1][];
					Class15.smethod_0(array, array2, array3, array4, gclass5_0);
					class13_0.method_0(array[0], array2[0], array3[0], 0, array4[0], 0);
					num3 >>= 3;
					i -= 3;
					enum1_0 = Enum1.const_6;
					break;
				}
				case 2u:
					num3 >>= 3;
					i -= 3;
					enum1_0 = Enum1.const_3;
					break;
				case 3u:
					num3 >>= 3;
					i -= 3;
					enum1_0 = Enum1.const_9;
					gclass5_0.string_0 = "invalid block type";
					int_15 = -3;
					int_10 = num3;
					int_9 = i;
					gclass5_0.int_1 = num2;
					gclass5_0.long_0 += num - gclass5_0.int_0;
					gclass5_0.int_0 = num;
					int_14 = num4;
					return method_5(-3);
				}
				break;
			}
			default:
				int_15 = -2;
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(-2);
			case Enum1.const_7:
				int_14 = num4;
				int_15 = method_5(int_15);
				num4 = int_14;
				num5 = ((num4 < int_13) ? (int_13 - num4 - 1) : (int_12 - num4));
				if (int_13 != int_14)
				{
					int_10 = num3;
					int_9 = i;
					gclass5_0.int_1 = num2;
					gclass5_0.long_0 += num - gclass5_0.int_0;
					gclass5_0.int_0 = num;
					int_14 = num4;
					return method_5(int_15);
				}
				enum1_0 = Enum1.const_8;
				goto case Enum1.const_8;
			case Enum1.const_8:
				int_15 = 1;
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(1);
			case Enum1.const_9:
				int_15 = -3;
				int_10 = num3;
				int_9 = i;
				gclass5_0.int_1 = num2;
				gclass5_0.long_0 += num - gclass5_0.int_0;
				gclass5_0.int_0 = num;
				int_14 = num4;
				return method_5(-3);
			}
		}
	}

	internal void method_2()
	{
		method_0();
		byte_0 = null;
		int_11 = null;
	}

	internal void method_3(byte[] byte_1, int int_15, int int_16)
	{
		Array.Copy(byte_1, int_15, byte_0, 0, int_16);
		int_13 = (int_14 = int_16);
	}

	internal int method_4()
	{
		if (enum1_0 != Enum1.const_1)
		{
			return 0;
		}
		return 1;
	}

	internal int method_5(int int_15)
	{
		int num = 0;
		while (true)
		{
			if (num >= 2)
			{
				return int_15;
			}
			int num2 = ((num != 0) ? (int_14 - int_13) : (((int_13 <= int_14) ? int_14 : int_12) - int_13));
			if (num2 == 0)
			{
				break;
			}
			if (num2 > gclass5_0.int_3)
			{
				num2 = gclass5_0.int_3;
			}
			if (num2 != 0 && int_15 == -5)
			{
				int_15 = 0;
			}
			gclass5_0.int_3 -= num2;
			gclass5_0.long_1 += num2;
			if (object_0 != null)
			{
				gclass5_0.uint_0 = (uint_0 = GClass4.smethod_0(uint_0, byte_0, int_13, num2));
			}
			Array.Copy(byte_0, int_13, gclass5_0.byte_1, gclass5_0.int_2, num2);
			gclass5_0.int_2 += num2;
			int_13 += num2;
			if (int_13 == int_12 && num == 0)
			{
				int_13 = 0;
				if (int_14 == int_12)
				{
					int_14 = 0;
				}
			}
			else
			{
				num++;
			}
			num++;
		}
		if (int_15 == -5)
		{
			int_15 = 0;
		}
		return int_15;
	}
}
