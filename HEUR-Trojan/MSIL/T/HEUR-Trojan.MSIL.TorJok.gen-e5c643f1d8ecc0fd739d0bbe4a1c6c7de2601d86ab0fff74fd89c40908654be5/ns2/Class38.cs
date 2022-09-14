using ns1;
using ns10;
using ns11;
using ns12;
using ns15;
using ns3;
using ns5;

namespace ns2;

internal sealed class Class38
{
	internal delegate Enum14 Delegate5(Enum19 enum19_0);

	internal sealed class Class39
	{
		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int int_3;

		internal Enum15 enum15_0;

		internal static readonly Class39[] class39_0;

		private Class39(int int_4, int int_5, int int_6, int int_7, Enum15 enum15_1)
		{
			int_0 = int_4;
			int_1 = int_5;
			int_2 = int_6;
			int_3 = int_7;
			enum15_0 = enum15_1;
		}

		static Class39()
		{
			class39_0 = new Class39[10]
			{
				new Class39(0, 0, 0, 0, Enum15.const_0),
				new Class39(4, 4, 8, 4, Enum15.const_1),
				new Class39(4, 5, 16, 8, Enum15.const_1),
				new Class39(4, 6, 32, 32, Enum15.const_1),
				new Class39(4, 4, 16, 16, Enum15.const_2),
				new Class39(8, 16, 32, 32, Enum15.const_2),
				new Class39(8, 16, 128, 128, Enum15.const_2),
				new Class39(8, 32, 128, 256, Enum15.const_2),
				new Class39(32, 128, 258, 1024, Enum15.const_2),
				new Class39(32, 258, 258, 4096, Enum15.const_2)
			};
		}
	}

	internal static readonly int int_0 = 9;

	internal static readonly int int_1 = 8;

	internal Delegate5 delegate5_0;

	internal static readonly string[] string_0 = new string[10] { "need dictionary", "stream end", "", "file error", "stream error", "data error", "insufficient memory", "buffer error", "incompatible version", "" };

	internal static readonly int int_2 = 32;

	internal static readonly int int_3 = 42;

	internal static readonly int int_4 = 113;

	internal static readonly int int_5 = 666;

	internal static readonly int int_6 = 8;

	internal static readonly int int_7 = 0;

	internal static readonly int int_8 = 1;

	internal static readonly int int_9 = 2;

	internal static readonly int int_10 = 0;

	internal static readonly int int_11 = 1;

	internal static readonly int int_12 = 2;

	internal static readonly int int_13 = 16;

	internal static readonly int int_14 = 3;

	internal static readonly int int_15 = 258;

	internal static readonly int int_16 = int_15 + int_14 + 1;

	private static readonly int int_17 = 2 * Class48.int_5 + 1;

	internal static readonly int int_18 = 256;

	internal GClass2 gclass2_0;

	internal int int_19;

	internal byte[] byte_0;

	internal int int_20;

	internal int int_21;

	internal sbyte sbyte_0;

	internal int int_22;

	internal int int_23;

	internal int int_24;

	internal int int_25;

	internal byte[] byte_1;

	internal int int_26;

	internal short[] short_0;

	internal short[] short_1;

	internal int int_27;

	internal int int_28;

	internal int int_29;

	internal int int_30;

	internal int int_31;

	internal int int_32;

	internal Class39 class39_0;

	internal int int_33;

	internal int int_34;

	internal int int_35;

	internal int int_36;

	internal int int_37;

	internal int int_38;

	internal int int_39;

	internal Enum20 enum20_0;

	internal Enum21 enum21_0;

	internal short[] short_2;

	internal short[] short_3;

	internal short[] short_4;

	internal Class46 class46_0 = new Class46();

	internal Class46 class46_1 = new Class46();

	internal Class46 class46_2 = new Class46();

	internal short[] short_5 = new short[Class48.int_0 + 1];

	internal int[] int_40 = new int[2 * Class48.int_5 + 1];

	internal int int_41;

	internal int int_42;

	internal sbyte[] sbyte_1 = new sbyte[2 * Class48.int_5 + 1];

	internal int int_43;

	internal int int_44;

	internal int int_45;

	internal int int_46;

	internal int int_47;

	internal int int_48;

	internal int int_49;

	internal int int_50;

	internal short short_6;

	internal int int_51;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal Class38()
	{
		short_2 = new short[int_17 * 2];
		short_3 = new short[(2 * Class48.int_2 + 1) * 2];
		short_4 = new short[(2 * Class48.int_1 + 1) * 2];
	}

	internal Enum14 method_0(Enum19 enum19_0)
	{
		int num = 65535;
		if (65535 > byte_0.Length - 5)
		{
			num = byte_0.Length - 5;
		}
		while (true)
		{
			if (int_38 <= 1)
			{
				Class6.smethod_165(this);
				if (int_38 == 0 && enum19_0 == Enum19.const_0)
				{
					return Enum14.const_0;
				}
				if (int_38 == 0)
				{
					Class6.smethod_580(this, enum19_0 == Enum19.const_4);
					if (gclass2_0.int_3 == 0)
					{
						if (enum19_0 != Enum19.const_4)
						{
							return Enum14.const_0;
						}
						return Enum14.const_2;
					}
					if (enum19_0 != Enum19.const_4)
					{
						return Enum14.const_1;
					}
					return Enum14.const_3;
				}
			}
			int_36 += int_38;
			int_38 = 0;
			int num2 = int_32 + num;
			if (int_36 == 0 || int_36 >= num2)
			{
				int_38 = int_36 - num2;
				int_36 = num2;
				Class6.smethod_580(this, bool_0: false);
				if (gclass2_0.int_3 == 0)
				{
					return Enum14.const_0;
				}
			}
			if (int_36 - int_32 >= int_23 - int_16)
			{
				Class6.smethod_580(this, bool_0: false);
				if (gclass2_0.int_3 == 0)
				{
					break;
				}
			}
		}
		return Enum14.const_0;
	}

	internal Enum14 method_1(Enum19 enum19_0)
	{
		int num = 0;
		while (true)
		{
			if (int_38 < int_16)
			{
				Class6.smethod_165(this);
				if (int_38 < int_16 && enum19_0 == Enum19.const_0)
				{
					return Enum14.const_0;
				}
				if (int_38 == 0)
				{
					Class6.smethod_580(this, enum19_0 == Enum19.const_4);
					if (gclass2_0.int_3 == 0)
					{
						if (enum19_0 == Enum19.const_4)
						{
							return Enum14.const_2;
						}
						return Enum14.const_0;
					}
					if (enum19_0 != Enum19.const_4)
					{
						return Enum14.const_1;
					}
					return Enum14.const_3;
				}
			}
			if (int_38 >= int_14)
			{
				int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + (int_14 - 1)] & 0xFF)) & int_30;
				num = short_1[int_27] & 0xFFFF;
				short_0[int_36 & int_25] = short_1[int_27];
				short_1[int_27] = (short)int_36;
			}
			if (num != 0L && ((int_36 - num) & 0xFFFF) <= int_23 - int_16 && enum21_0 != Enum21.const_2)
			{
				int_33 = Class6.smethod_450(this, num);
			}
			bool flag;
			if (int_33 >= int_14)
			{
				flag = Class6.smethod_362(this, int_36 - int_37, int_33 - int_14);
				int_38 -= int_33;
				if (int_33 <= class39_0.int_1 && int_38 >= int_14)
				{
					int_33--;
					do
					{
						int_36++;
						int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + (int_14 - 1)] & 0xFF)) & int_30;
						num = short_1[int_27] & 0xFFFF;
						short_0[int_36 & int_25] = short_1[int_27];
						short_1[int_27] = (short)int_36;
					}
					while (--int_33 != 0);
					int_36++;
				}
				else
				{
					int_36 += int_33;
					int_33 = 0;
					int_27 = byte_1[int_36] & 0xFF;
					int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + 1] & 0xFF)) & int_30;
				}
			}
			else
			{
				flag = Class6.smethod_362(this, 0, byte_1[int_36] & 0xFF);
				int_38--;
				int_36++;
			}
			if (flag)
			{
				Class6.smethod_580(this, bool_0: false);
				if (gclass2_0.int_3 == 0)
				{
					break;
				}
			}
		}
		return Enum14.const_0;
	}

	internal Enum14 method_2(Enum19 enum19_0)
	{
		int num = 0;
		while (true)
		{
			if (int_38 < int_16)
			{
				Class6.smethod_165(this);
				if (int_38 < int_16 && enum19_0 == Enum19.const_0)
				{
					return Enum14.const_0;
				}
				if (int_38 == 0)
				{
					if (int_35 != 0)
					{
						bool flag = Class6.smethod_362(this, 0, byte_1[int_36 - 1] & 0xFF);
						int_35 = 0;
					}
					Class6.smethod_580(this, enum19_0 == Enum19.const_4);
					if (gclass2_0.int_3 == 0)
					{
						if (enum19_0 == Enum19.const_4)
						{
							return Enum14.const_2;
						}
						return Enum14.const_0;
					}
					if (enum19_0 != Enum19.const_4)
					{
						return Enum14.const_1;
					}
					return Enum14.const_3;
				}
			}
			if (int_38 >= int_14)
			{
				int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + (int_14 - 1)] & 0xFF)) & int_30;
				num = short_1[int_27] & 0xFFFF;
				short_0[int_36 & int_25] = short_1[int_27];
				short_1[int_27] = (short)int_36;
			}
			int_39 = int_33;
			int_34 = int_37;
			int_33 = int_14 - 1;
			if (num != 0 && int_39 < class39_0.int_1 && ((int_36 - num) & 0xFFFF) <= int_23 - int_16)
			{
				if (enum21_0 != Enum21.const_2)
				{
					int_33 = Class6.smethod_450(this, num);
				}
				if (int_33 <= 5 && (enum21_0 == Enum21.const_1 || (int_33 == int_14 && int_36 - int_37 > 4096)))
				{
					int_33 = int_14 - 1;
				}
			}
			if (int_39 >= int_14 && int_33 <= int_39)
			{
				int num2 = int_36 + int_38 - int_14;
				bool flag = Class6.smethod_362(this, int_36 - 1 - int_34, int_39 - int_14);
				int_38 -= int_39 - 1;
				int_39 -= 2;
				do
				{
					if (++int_36 <= num2)
					{
						int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + (int_14 - 1)] & 0xFF)) & int_30;
						num = short_1[int_27] & 0xFFFF;
						short_0[int_36 & int_25] = short_1[int_27];
						short_1[int_27] = (short)int_36;
					}
				}
				while (--int_39 != 0);
				int_35 = 0;
				int_33 = int_14 - 1;
				int_36++;
				if (flag)
				{
					Class6.smethod_580(this, bool_0: false);
					if (gclass2_0.int_3 == 0)
					{
						return Enum14.const_0;
					}
				}
			}
			else if (int_35 != 0)
			{
				bool flag;
				if (flag = Class6.smethod_362(this, 0, byte_1[int_36 - 1] & 0xFF))
				{
					Class6.smethod_580(this, bool_0: false);
				}
				int_36++;
				int_38--;
				if (gclass2_0.int_3 == 0)
				{
					break;
				}
			}
			else
			{
				int_35 = 1;
				int_36++;
				int_38--;
			}
		}
		return Enum14.const_0;
	}
}
