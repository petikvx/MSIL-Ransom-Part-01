using Ionic.Zlib;

internal sealed class Class14
{
	private enum Enum2
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
		const_9,
		const_10,
		const_11,
		const_12,
		const_13
	}

	private const int int_0 = 32;

	private const int int_1 = 8;

	private Enum2 enum2_0;

	internal GClass5 gclass5_0;

	internal int int_2;

	internal uint uint_0;

	internal uint uint_1;

	internal int int_3;

	private bool bool_0 = true;

	internal int int_4;

	internal Class11 class11_0;

	private static readonly byte[] byte_0 = new byte[4] { 0, 0, 255, 255 };

	internal bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public Class14()
	{
	}

	public Class14(bool expectRfc1950HeaderBytes)
	{
		bool_0 = expectRfc1950HeaderBytes;
	}

	internal int method_0()
	{
		GClass5 gClass = gclass5_0;
		gclass5_0.long_1 = 0L;
		gClass.long_0 = 0L;
		gclass5_0.string_0 = null;
		enum2_0 = ((!Boolean_0) ? Enum2.const_7 : Enum2.const_0);
		class11_0.method_0();
		return 0;
	}

	internal int method_1()
	{
		if (class11_0 != null)
		{
			class11_0.method_2();
		}
		class11_0 = null;
		return 0;
	}

	internal int method_2(GClass5 gclass5_1, int int_5)
	{
		gclass5_0 = gclass5_1;
		gclass5_0.string_0 = null;
		class11_0 = null;
		if (int_5 >= 8 && int_5 <= 15)
		{
			int_4 = int_5;
			class11_0 = new Class11(gclass5_1, Boolean_0 ? this : null, 1 << int_5);
			method_0();
			return 0;
		}
		method_1();
		throw new GException0("Bad window size.");
	}

	internal int method_3(FlushType flushType_0)
	{
		if (gclass5_0.byte_0 == null)
		{
			throw new GException0("InputBuffer is null. ");
		}
		int num = 0;
		int num2 = -5;
		while (true)
		{
			switch (enum2_0)
			{
			case Enum2.const_11:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 += (uint)(gclass5_0.byte_0[gclass5_0.int_0++] & 0xFF);
					if (uint_0 != uint_1)
					{
						enum2_0 = Enum2.const_13;
						gclass5_0.string_0 = "incorrect data check";
						int_3 = 5;
						break;
					}
					enum2_0 = Enum2.const_12;
					return 1;
				}
				return num2;
			case Enum2.const_10:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 += (uint)((gclass5_0.byte_0[gclass5_0.int_0++] << 8) & 0xFF00);
					enum2_0 = Enum2.const_11;
					break;
				}
				return num2;
			case Enum2.const_9:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 += (uint)((gclass5_0.byte_0[gclass5_0.int_0++] << 16) & 0xFF0000);
					enum2_0 = Enum2.const_10;
					break;
				}
				return num2;
			case Enum2.const_8:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 = (uint)((ulong)(gclass5_0.byte_0[gclass5_0.int_0++] << 24) & 0xFF000000uL);
					enum2_0 = Enum2.const_9;
					break;
				}
				return num2;
			case Enum2.const_7:
				num2 = class11_0.method_1(num2);
				switch (num2)
				{
				case -3:
					enum2_0 = Enum2.const_13;
					int_3 = 0;
					goto end_IL_0607;
				case 0:
					num2 = num;
					break;
				}
				if (num2 == 1)
				{
					num2 = num;
					uint_0 = class11_0.method_0();
					if (Boolean_0)
					{
						enum2_0 = Enum2.const_8;
						break;
					}
					enum2_0 = Enum2.const_12;
					return 1;
				}
				return num2;
			case Enum2.const_4:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 += (uint)((gclass5_0.byte_0[gclass5_0.int_0++] << 8) & 0xFF00);
					enum2_0 = Enum2.const_5;
					break;
				}
				return num2;
			case Enum2.const_3:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 += (uint)((gclass5_0.byte_0[gclass5_0.int_0++] << 16) & 0xFF0000);
					enum2_0 = Enum2.const_4;
					break;
				}
				return num2;
			case Enum2.const_2:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					uint_1 = (uint)((ulong)(gclass5_0.byte_0[gclass5_0.int_0++] << 24) & 0xFF000000uL);
					enum2_0 = Enum2.const_3;
					break;
				}
				return num2;
			case Enum2.const_1:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					int num3 = gclass5_0.byte_0[gclass5_0.int_0++] & 0xFF;
					if (((int_2 << 8) + num3) % 31 != 0)
					{
						enum2_0 = Enum2.const_13;
						gclass5_0.string_0 = "incorrect header check";
						int_3 = 5;
					}
					else
					{
						enum2_0 = (((num3 & 0x20) == 0) ? Enum2.const_7 : Enum2.const_2);
					}
					break;
				}
				return num2;
			case Enum2.const_0:
				if (gclass5_0.int_1 != 0)
				{
					num2 = num;
					gclass5_0.int_1--;
					gclass5_0.long_0++;
					if (((int_2 = gclass5_0.byte_0[gclass5_0.int_0++]) & 0xF) != 8)
					{
						enum2_0 = Enum2.const_13;
						gclass5_0.string_0 = $"unknown compression method (0x{int_2:X2})";
						int_3 = 5;
					}
					else if ((int_2 >> 4) + 8 > int_4)
					{
						enum2_0 = Enum2.const_13;
						gclass5_0.string_0 = $"invalid window size ({(int_2 >> 4) + 8})";
						int_3 = 5;
					}
					else
					{
						enum2_0 = Enum2.const_1;
					}
					break;
				}
				return num2;
			default:
				throw new GException0("Stream error.");
			case Enum2.const_5:
				if (gclass5_0.int_1 == 0)
				{
					return num2;
				}
				num2 = num;
				gclass5_0.int_1--;
				gclass5_0.long_0++;
				uint_1 += (uint)(gclass5_0.byte_0[gclass5_0.int_0++] & 0xFF);
				gclass5_0.uint_0 = uint_1;
				enum2_0 = Enum2.const_6;
				return 2;
			case Enum2.const_6:
				enum2_0 = Enum2.const_13;
				gclass5_0.string_0 = "need dictionary";
				int_3 = 0;
				return -2;
			case Enum2.const_13:
				throw new GException0($"Bad state ({gclass5_0.string_0})");
			case Enum2.const_12:
				{
					return 1;
				}
				end_IL_0607:
				break;
			}
		}
	}

	internal int method_4(byte[] byte_1)
	{
		int int_ = 0;
		int num = byte_1.Length;
		if (enum2_0 != Enum2.const_6)
		{
			throw new GException0("Stream error.");
		}
		if (GClass4.smethod_0(1u, byte_1, 0, byte_1.Length) != gclass5_0.uint_0)
		{
			return -3;
		}
		gclass5_0.uint_0 = GClass4.smethod_0(0u, null, 0, 0);
		if (num >= 1 << int_4)
		{
			num = (1 << int_4) - 1;
			int_ = byte_1.Length - num;
		}
		class11_0.method_3(byte_1, int_, num);
		enum2_0 = Enum2.const_7;
		return 0;
	}

	internal int method_5()
	{
		if (enum2_0 != Enum2.const_13)
		{
			enum2_0 = Enum2.const_13;
			int_3 = 0;
		}
		int num;
		if ((num = gclass5_0.int_1) == 0)
		{
			return -5;
		}
		int num2 = gclass5_0.int_0;
		int num3 = int_3;
		while (num != 0 && num3 < 4)
		{
			num3 = ((gclass5_0.byte_0[num2] != byte_0[num3]) ? ((gclass5_0.byte_0[num2] == 0) ? (4 - num3) : 0) : (num3 + 1));
			num2++;
			num--;
		}
		gclass5_0.long_0 += num2 - gclass5_0.int_0;
		gclass5_0.int_0 = num2;
		gclass5_0.int_1 = num;
		int_3 = num3;
		if (num3 != 4)
		{
			return -3;
		}
		long long_ = gclass5_0.long_0;
		long long_2 = gclass5_0.long_1;
		method_0();
		gclass5_0.long_0 = long_;
		gclass5_0.long_1 = long_2;
		enum2_0 = Enum2.const_7;
		return 0;
	}

	internal int method_6(GClass5 gclass5_1)
	{
		return class11_0.method_4();
	}
}
