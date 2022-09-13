using System;
using Ionic.Zlib;

internal sealed class Class9
{
	internal delegate BlockState Delegate0(FlushType flush);

	internal class Class10
	{
		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int int_3;

		internal DeflateFlavor deflateFlavor_0;

		private static readonly Class10[] class10_0;

		private Class10(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
		{
			int_0 = goodLength;
			int_1 = maxLazy;
			int_2 = niceLength;
			int_3 = maxChainLength;
			deflateFlavor_0 = flavor;
		}

		public static Class10 smethod_0(CompressionLevel compressionLevel_0)
		{
			return class10_0[(int)compressionLevel_0];
		}

		static Class10()
		{
			class10_0 = new Class10[10]
			{
				new Class10(0, 0, 0, 0, DeflateFlavor.Store),
				new Class10(4, 4, 8, 4, DeflateFlavor.Fast),
				new Class10(4, 5, 16, 8, DeflateFlavor.Fast),
				new Class10(4, 6, 32, 32, DeflateFlavor.Fast),
				new Class10(4, 4, 16, 16, DeflateFlavor.Slow),
				new Class10(8, 16, 32, 32, DeflateFlavor.Slow),
				new Class10(8, 16, 128, 128, DeflateFlavor.Slow),
				new Class10(8, 32, 128, 256, DeflateFlavor.Slow),
				new Class10(32, 128, 258, 1024, DeflateFlavor.Slow),
				new Class10(32, 258, 258, 4096, DeflateFlavor.Slow)
			};
		}
	}

	private static readonly int int_0 = 9;

	private static readonly int int_1 = 8;

	private Delegate0 delegate0_0;

	private static readonly string[] string_0 = new string[10] { "need dictionary", "stream end", "", "file error", "stream error", "data error", "insufficient memory", "buffer error", "incompatible version", "" };

	private static readonly int int_2 = 32;

	private static readonly int int_3 = 42;

	private static readonly int int_4 = 113;

	private static readonly int int_5 = 666;

	private static readonly int int_6 = 8;

	private static readonly int int_7 = 0;

	private static readonly int int_8 = 1;

	private static readonly int int_9 = 2;

	private static readonly int int_10 = 0;

	private static readonly int int_11 = 1;

	private static readonly int int_12 = 2;

	private static readonly int int_13 = 16;

	private static readonly int int_14 = 3;

	private static readonly int int_15 = 258;

	private static readonly int int_16 = int_15 + int_14 + 1;

	private static readonly int int_17 = 2 * Class19.int_5 + 1;

	private static readonly int int_18 = 256;

	internal GClass5 gclass5_0;

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

	private Class10 class10_0;

	internal int int_33;

	internal int int_34;

	internal int int_35;

	internal int int_36;

	internal int int_37;

	internal int int_38;

	internal int int_39;

	internal CompressionLevel compressionLevel_0;

	internal CompressionStrategy compressionStrategy_0;

	internal short[] short_2;

	internal short[] short_3;

	internal short[] short_4;

	internal Class17 class17_0 = new Class17();

	internal Class17 class17_1 = new Class17();

	internal Class17 class17_2 = new Class17();

	internal short[] short_5 = new short[Class19.int_0 + 1];

	internal int[] int_40 = new int[2 * Class19.int_5 + 1];

	internal int int_41;

	internal int int_42;

	internal sbyte[] sbyte_1 = new sbyte[2 * Class19.int_5 + 1];

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

	private bool bool_0;

	private bool bool_1 = true;

	internal bool Boolean_0
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	internal Class9()
	{
		short_2 = new short[int_17 * 2];
		short_3 = new short[(2 * Class19.int_2 + 1) * 2];
		short_4 = new short[(2 * Class19.int_1 + 1) * 2];
	}

	private void method_0()
	{
		int_26 = 2 * int_23;
		Array.Clear(short_1, 0, int_28);
		class10_0 = Class10.smethod_0(compressionLevel_0);
		method_32();
		int_36 = 0;
		int_32 = 0;
		int_38 = 0;
		int_33 = (int_39 = int_14 - 1);
		int_35 = 0;
		int_27 = 0;
	}

	private void method_1()
	{
		class17_0.short_0 = short_2;
		class17_0.class20_0 = Class20.class20_0;
		class17_1.short_0 = short_3;
		class17_1.class20_0 = Class20.class20_1;
		class17_2.short_0 = short_4;
		class17_2.class20_0 = Class20.class20_2;
		short_6 = 0;
		int_51 = 0;
		int_50 = 8;
		method_2();
	}

	internal void method_2()
	{
		for (int i = 0; i < Class19.int_5; i++)
		{
			short_2[i * 2] = 0;
		}
		for (int j = 0; j < Class19.int_2; j++)
		{
			short_3[j * 2] = 0;
		}
		for (int k = 0; k < Class19.int_1; k++)
		{
			short_4[k * 2] = 0;
		}
		short_2[int_18 * 2] = 1;
		int_48 = 0;
		int_47 = 0;
		int_49 = 0;
		int_45 = 0;
	}

	internal void method_3(short[] short_7, int int_52)
	{
		int num = int_40[int_52];
		for (int num2 = int_52 << 1; num2 <= int_41; num2 <<= 1)
		{
			if (num2 < int_41 && smethod_0(short_7, int_40[num2 + 1], int_40[num2], sbyte_1))
			{
				num2++;
			}
			if (smethod_0(short_7, num, int_40[num2], sbyte_1))
			{
				break;
			}
			int_40[int_52] = int_40[num2];
			int_52 = num2;
		}
		int_40[int_52] = num;
	}

	internal static bool smethod_0(short[] short_7, int int_52, int int_53, sbyte[] sbyte_2)
	{
		short num = short_7[int_52 * 2];
		short num2 = short_7[int_53 * 2];
		if (num >= num2)
		{
			if (num == num2)
			{
				return sbyte_2[int_52] <= sbyte_2[int_53];
			}
			return false;
		}
		return true;
	}

	internal void method_4(short[] short_7, int int_52)
	{
		int num = -1;
		int num2 = short_7[1];
		int num3 = 0;
		int num4 = 7;
		int num5 = 4;
		if (num2 == 0)
		{
			num4 = 138;
			num5 = 3;
		}
		short_7[(int_52 + 1) * 2 + 1] = short.MaxValue;
		for (int i = 0; i <= int_52; i++)
		{
			int num6 = num2;
			num2 = short_7[(i + 1) * 2 + 1];
			if (++num3 < num4 && num6 == num2)
			{
				continue;
			}
			if (num3 < num5)
			{
				short_4[num6 * 2] = (short)(short_4[num6 * 2] + num3);
			}
			else if (num6 != 0)
			{
				if (num6 != num)
				{
					short_4[num6 * 2]++;
				}
				short_4[Class19.int_7 * 2]++;
			}
			else if (num3 <= 10)
			{
				short_4[Class19.int_8 * 2]++;
			}
			else
			{
				short_4[Class19.int_9 * 2]++;
			}
			num3 = 0;
			num = num6;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			else if (num6 == num2)
			{
				num4 = 6;
				num5 = 3;
			}
			else
			{
				num4 = 7;
				num5 = 4;
			}
		}
	}

	internal int method_5()
	{
		method_4(short_2, class17_0.int_7);
		method_4(short_3, class17_1.int_7);
		class17_2.method_1(this);
		int num = Class19.int_1 - 1;
		while (num >= 3 && short_4[Class17.sbyte_0[num] * 2 + 1] == 0)
		{
			num--;
		}
		int_47 += 3 * (num + 1) + 5 + 5 + 4;
		return num;
	}

	internal void method_6(int int_52, int int_53, int int_54)
	{
		method_10(int_52 - 257, 5);
		method_10(int_53 - 1, 5);
		method_10(int_54 - 4, 4);
		for (int i = 0; i < int_54; i++)
		{
			method_10(short_4[Class17.sbyte_0[i] * 2 + 1], 3);
		}
		method_7(short_2, int_52 - 1);
		method_7(short_3, int_53 - 1);
	}

	internal void method_7(short[] short_7, int int_52)
	{
		int num = -1;
		int num2 = short_7[1];
		int num3 = 0;
		int num4 = 7;
		int num5 = 4;
		if (num2 == 0)
		{
			num4 = 138;
			num5 = 3;
		}
		for (int i = 0; i <= int_52; i++)
		{
			int num6 = num2;
			num2 = short_7[(i + 1) * 2 + 1];
			if (++num3 < num4 && num6 == num2)
			{
				continue;
			}
			if (num3 < num5)
			{
				do
				{
					method_9(num6, short_4);
				}
				while (--num3 != 0);
			}
			else if (num6 != 0)
			{
				if (num6 != num)
				{
					method_9(num6, short_4);
					num3--;
				}
				method_9(Class19.int_7, short_4);
				method_10(num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				method_9(Class19.int_8, short_4);
				method_10(num3 - 3, 3);
			}
			else
			{
				method_9(Class19.int_9, short_4);
				method_10(num3 - 11, 7);
			}
			num3 = 0;
			num = num6;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			else if (num6 == num2)
			{
				num4 = 6;
				num5 = 3;
			}
			else
			{
				num4 = 7;
				num5 = 4;
			}
		}
	}

	private void method_8(byte[] byte_2, int int_52, int int_53)
	{
		Array.Copy(byte_2, int_52, byte_0, int_21, int_53);
		int_21 += int_53;
	}

	internal void method_9(int int_52, short[] short_7)
	{
		int num = int_52 * 2;
		method_10(short_7[num] & 0xFFFF, short_7[num + 1] & 0xFFFF);
	}

	internal void method_10(int int_52, int int_53)
	{
		if (int_51 > int_13 - int_53)
		{
			short_6 |= (short)((int_52 << int_51) & 0xFFFF);
			byte_0[int_21++] = (byte)short_6;
			byte_0[int_21++] = (byte)(short_6 >> 8);
			short_6 = (short)((uint)int_52 >> int_13 - int_51);
			int_51 += int_53 - int_13;
		}
		else
		{
			short_6 |= (short)((int_52 << int_51) & 0xFFFF);
			int_51 += int_53;
		}
	}

	internal void method_11()
	{
		method_10(int_8 << 1, 3);
		method_9(int_18, Class20.short_0);
		method_15();
		if (1 + int_50 + 10 - int_51 < 9)
		{
			method_10(int_8 << 1, 3);
			method_9(int_18, Class20.short_0);
			method_15();
		}
		int_50 = 7;
	}

	internal bool method_12(int int_52, int int_53)
	{
		byte_0[int_46 + int_45 * 2] = (byte)((uint)int_52 >> 8);
		byte_0[int_46 + int_45 * 2 + 1] = (byte)int_52;
		byte_0[int_43 + int_45] = (byte)int_53;
		int_45++;
		if (int_52 == 0)
		{
			short_2[int_53 * 2]++;
		}
		else
		{
			int_49++;
			int_52--;
			short_2[(Class17.sbyte_2[int_53] + Class19.int_3 + 1) * 2]++;
			short_3[Class17.smethod_0(int_52) * 2]++;
		}
		if ((int_45 & 0x1FFF) == 0 && compressionLevel_0 > CompressionLevel.Level2)
		{
			int num = int_45 << 3;
			int num2 = int_36 - int_32;
			for (int i = 0; i < Class19.int_2; i++)
			{
				num = (int)(num + short_3[i * 2] * (5L + Class17.int_2[i]));
			}
			num >>= 3;
			if (int_49 < int_45 / 2 && num < num2 / 2)
			{
				return true;
			}
		}
		if (int_45 != int_44 - 1)
		{
			return int_45 == int_44;
		}
		return true;
	}

	internal void method_13(short[] short_7, short[] short_8)
	{
		int num = 0;
		if (int_45 != 0)
		{
			do
			{
				int num2 = int_46 + num * 2;
				int num3 = ((byte_0[num2] << 8) & 0xFF00) | (byte_0[num2 + 1] & 0xFF);
				int num4 = byte_0[int_43 + num] & 0xFF;
				num++;
				if (num3 != 0)
				{
					int num5 = Class17.sbyte_2[num4];
					method_9(num5 + Class19.int_3 + 1, short_7);
					int num6 = Class17.int_1[num5];
					if (num6 != 0)
					{
						num4 -= Class17.int_5[num5];
						method_10(num4, num6);
					}
					num3--;
					num5 = Class17.smethod_0(num3);
					method_9(num5, short_8);
					num6 = Class17.int_2[num5];
					if (num6 != 0)
					{
						num3 -= Class17.int_6[num5];
						method_10(num3, num6);
					}
				}
				else
				{
					method_9(num4, short_7);
				}
			}
			while (num < int_45);
		}
		method_9(int_18, short_7);
		int_50 = short_7[int_18 * 2 + 1];
	}

	internal void method_14()
	{
		int i = 0;
		int num = 0;
		int num2 = 0;
		for (; i < 7; i++)
		{
			num2 += short_2[i * 2];
		}
		for (; i < 128; i++)
		{
			num += short_2[i * 2];
		}
		for (; i < Class19.int_3; i++)
		{
			num2 += short_2[i * 2];
		}
		sbyte_0 = (sbyte)((num2 > num >> 2) ? int_10 : int_11);
	}

	internal void method_15()
	{
		if (int_51 == 16)
		{
			byte_0[int_21++] = (byte)short_6;
			byte_0[int_21++] = (byte)(short_6 >> 8);
			short_6 = 0;
			int_51 = 0;
		}
		else if (int_51 >= 8)
		{
			byte_0[int_21++] = (byte)short_6;
			short_6 >>= 8;
			int_51 -= 8;
		}
	}

	internal void method_16()
	{
		if (int_51 > 8)
		{
			byte_0[int_21++] = (byte)short_6;
			byte_0[int_21++] = (byte)(short_6 >> 8);
		}
		else if (int_51 > 0)
		{
			byte_0[int_21++] = (byte)short_6;
		}
		short_6 = 0;
		int_51 = 0;
	}

	internal void method_17(int int_52, int int_53, bool bool_2)
	{
		method_16();
		int_50 = 8;
		if (bool_2)
		{
			byte_0[int_21++] = (byte)int_53;
			byte_0[int_21++] = (byte)(int_53 >> 8);
			byte_0[int_21++] = (byte)(~int_53);
			byte_0[int_21++] = (byte)(~int_53 >> 8);
		}
		method_8(byte_1, int_52, int_53);
	}

	internal void method_18(bool bool_2)
	{
		method_21((int_32 >= 0) ? int_32 : (-1), int_36 - int_32, bool_2);
		int_32 = int_36;
		gclass5_0.method_18();
	}

	internal BlockState method_19(FlushType flushType_0)
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
				method_22();
				if (int_38 == 0 && flushType_0 == FlushType.None)
				{
					return BlockState.NeedMore;
				}
				if (int_38 == 0)
				{
					method_18(flushType_0 == FlushType.Finish);
					if (gclass5_0.int_3 == 0)
					{
						if (flushType_0 != FlushType.Finish)
						{
							return BlockState.NeedMore;
						}
						return BlockState.FinishStarted;
					}
					if (flushType_0 != FlushType.Finish)
					{
						return BlockState.BlockDone;
					}
					return BlockState.FinishDone;
				}
			}
			int_36 += int_38;
			int_38 = 0;
			int num2 = int_32 + num;
			if (int_36 == 0 || int_36 >= num2)
			{
				int_38 = int_36 - num2;
				int_36 = num2;
				method_18(bool_2: false);
				if (gclass5_0.int_3 == 0)
				{
					return BlockState.NeedMore;
				}
			}
			if (int_36 - int_32 >= int_23 - int_16)
			{
				method_18(bool_2: false);
				if (gclass5_0.int_3 == 0)
				{
					break;
				}
			}
		}
		return BlockState.NeedMore;
	}

	internal void method_20(int int_52, int int_53, bool bool_2)
	{
		method_10((int_7 << 1) + (bool_2 ? 1 : 0), 3);
		method_17(int_52, int_53, bool_2: true);
	}

	internal void method_21(int int_52, int int_53, bool bool_2)
	{
		int num = 0;
		int num2;
		int num3;
		if (compressionLevel_0 > CompressionLevel.None)
		{
			if (sbyte_0 == int_12)
			{
				method_14();
			}
			class17_0.method_1(this);
			class17_1.method_1(this);
			num = method_5();
			num2 = int_47 + 3 + 7 >> 3;
			num3 = int_48 + 3 + 7 >> 3;
			if (num3 <= num2)
			{
				num2 = num3;
			}
		}
		else
		{
			num2 = (num3 = int_53 + 5);
		}
		if (int_53 + 4 <= num2 && int_52 != -1)
		{
			method_20(int_52, int_53, bool_2);
		}
		else if (num3 == num2)
		{
			method_10((int_8 << 1) + (bool_2 ? 1 : 0), 3);
			method_13(Class20.short_0, Class20.short_1);
		}
		else
		{
			method_10((int_9 << 1) + (bool_2 ? 1 : 0), 3);
			method_6(class17_0.int_7 + 1, class17_1.int_7 + 1, num + 1);
			method_13(short_2, short_3);
		}
		method_2();
		if (bool_2)
		{
			method_16();
		}
	}

	private void method_22()
	{
		do
		{
			int num = int_26 - int_38 - int_36;
			if (num != 0 || int_36 != 0 || int_38 != 0)
			{
				if (num == -1)
				{
					num--;
				}
				else if (int_36 >= int_23 + int_23 - int_16)
				{
					Array.Copy(byte_1, int_23, byte_1, 0, int_23);
					int_37 -= int_23;
					int_36 -= int_23;
					int_32 -= int_23;
					int num2 = int_28;
					int num3 = num2;
					do
					{
						int num4 = short_1[--num3] & 0xFFFF;
						short_1[num3] = (short)((num4 >= int_23) ? (num4 - int_23) : 0);
					}
					while (--num2 != 0);
					num2 = int_23;
					num3 = num2;
					do
					{
						int num4 = short_0[--num3] & 0xFFFF;
						short_0[num3] = (short)((num4 >= int_23) ? (num4 - int_23) : 0);
					}
					while (--num2 != 0);
					num += int_23;
				}
			}
			else
			{
				num = int_23;
			}
			if (gclass5_0.int_1 != 0)
			{
				int num2 = gclass5_0.method_19(byte_1, int_36 + int_38, num);
				int_38 += num2;
				if (int_38 >= int_14)
				{
					int_27 = byte_1[int_36] & 0xFF;
					int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + 1] & 0xFF)) & int_30;
				}
				continue;
			}
			break;
		}
		while (int_38 < int_16 && gclass5_0.int_1 != 0);
	}

	internal BlockState method_23(FlushType flushType_0)
	{
		int num = 0;
		while (true)
		{
			if (int_38 < int_16)
			{
				method_22();
				if (int_38 < int_16 && flushType_0 == FlushType.None)
				{
					return BlockState.NeedMore;
				}
				if (int_38 == 0)
				{
					method_18(flushType_0 == FlushType.Finish);
					if (gclass5_0.int_3 == 0)
					{
						if (flushType_0 == FlushType.Finish)
						{
							return BlockState.FinishStarted;
						}
						return BlockState.NeedMore;
					}
					if (flushType_0 != FlushType.Finish)
					{
						return BlockState.BlockDone;
					}
					return BlockState.FinishDone;
				}
			}
			if (int_38 >= int_14)
			{
				int_27 = ((int_27 << int_31) ^ (byte_1[int_36 + (int_14 - 1)] & 0xFF)) & int_30;
				num = short_1[int_27] & 0xFFFF;
				short_0[int_36 & int_25] = short_1[int_27];
				short_1[int_27] = (short)int_36;
			}
			if (num != 0L && ((int_36 - num) & 0xFFFF) <= int_23 - int_16 && compressionStrategy_0 != CompressionStrategy.HuffmanOnly)
			{
				int_33 = method_25(num);
			}
			bool flag;
			if (int_33 >= int_14)
			{
				flag = method_12(int_36 - int_37, int_33 - int_14);
				int_38 -= int_33;
				if (int_33 <= class10_0.int_1 && int_38 >= int_14)
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
				flag = method_12(0, byte_1[int_36] & 0xFF);
				int_38--;
				int_36++;
			}
			if (flag)
			{
				method_18(bool_2: false);
				if (gclass5_0.int_3 == 0)
				{
					break;
				}
			}
		}
		return BlockState.NeedMore;
	}

	internal BlockState method_24(FlushType flushType_0)
	{
		int num = 0;
		while (true)
		{
			if (int_38 < int_16)
			{
				method_22();
				if (int_38 < int_16 && flushType_0 == FlushType.None)
				{
					return BlockState.NeedMore;
				}
				if (int_38 == 0)
				{
					if (int_35 != 0)
					{
						bool flag = method_12(0, byte_1[int_36 - 1] & 0xFF);
						int_35 = 0;
					}
					method_18(flushType_0 == FlushType.Finish);
					if (gclass5_0.int_3 == 0)
					{
						if (flushType_0 == FlushType.Finish)
						{
							return BlockState.FinishStarted;
						}
						return BlockState.NeedMore;
					}
					if (flushType_0 != FlushType.Finish)
					{
						return BlockState.BlockDone;
					}
					return BlockState.FinishDone;
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
			if (num != 0 && int_39 < class10_0.int_1 && ((int_36 - num) & 0xFFFF) <= int_23 - int_16)
			{
				if (compressionStrategy_0 != CompressionStrategy.HuffmanOnly)
				{
					int_33 = method_25(num);
				}
				if (int_33 <= 5 && (compressionStrategy_0 == CompressionStrategy.Filtered || (int_33 == int_14 && int_36 - int_37 > 4096)))
				{
					int_33 = int_14 - 1;
				}
			}
			if (int_39 >= int_14 && int_33 <= int_39)
			{
				int num2 = int_36 + int_38 - int_14;
				bool flag = method_12(int_36 - 1 - int_34, int_39 - int_14);
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
					method_18(bool_2: false);
					if (gclass5_0.int_3 == 0)
					{
						return BlockState.NeedMore;
					}
				}
			}
			else if (int_35 != 0)
			{
				bool flag;
				if (flag = method_12(0, byte_1[int_36 - 1] & 0xFF))
				{
					method_18(bool_2: false);
				}
				int_36++;
				int_38--;
				if (gclass5_0.int_3 == 0)
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
		return BlockState.NeedMore;
	}

	internal int method_25(int int_52)
	{
		int num = class10_0.int_3;
		int num2 = int_36;
		int num3 = int_39;
		int num4 = ((int_36 > int_23 - int_16) ? (int_36 - (int_23 - int_16)) : 0);
		int num5 = class10_0.int_2;
		int num6 = int_25;
		int num7 = int_36 + int_15;
		byte b = byte_1[num2 + num3 - 1];
		byte b2 = byte_1[num2 + num3];
		if (int_39 >= class10_0.int_0)
		{
			num >>= 2;
		}
		if (num5 > int_38)
		{
			num5 = int_38;
		}
		do
		{
			int num8 = int_52;
			if (byte_1[num8 + num3] != b2 || byte_1[num8 + num3 - 1] != b || byte_1[num8] != byte_1[num2] || byte_1[++num8] != byte_1[num2 + 1])
			{
				continue;
			}
			num2 += 2;
			num8++;
			while (byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && byte_1[++num2] == byte_1[++num8] && num2 < num7)
			{
			}
			int num9 = int_15 - (num7 - num2);
			num2 = num7 - int_15;
			if (num9 > num3)
			{
				int_37 = int_52;
				num3 = num9;
				if (num9 >= num5)
				{
					break;
				}
				b = byte_1[num2 + num3 - 1];
				b2 = byte_1[num2 + num3];
			}
		}
		while ((int_52 = short_0[int_52 & num6] & 0xFFFF) > num4 && --num != 0);
		if (num3 <= int_38)
		{
			return num3;
		}
		return int_38;
	}

	internal int method_26(GClass5 gclass5_1, CompressionLevel compressionLevel_1)
	{
		return method_27(gclass5_1, compressionLevel_1, 15);
	}

	internal int method_27(GClass5 gclass5_1, CompressionLevel compressionLevel_1, int int_52)
	{
		return method_29(gclass5_1, compressionLevel_1, int_52, int_1, CompressionStrategy.Default);
	}

	internal int method_28(GClass5 gclass5_1, CompressionLevel compressionLevel_1, int int_52, CompressionStrategy compressionStrategy_1)
	{
		return method_29(gclass5_1, compressionLevel_1, int_52, int_1, compressionStrategy_1);
	}

	internal int method_29(GClass5 gclass5_1, CompressionLevel compressionLevel_1, int int_52, int int_53, CompressionStrategy compressionStrategy_1)
	{
		gclass5_0 = gclass5_1;
		gclass5_0.string_0 = null;
		if (int_52 >= 9 && int_52 <= 15)
		{
			if (int_53 < 1 || int_53 > int_0)
			{
				throw new GException0($"memLevel must be in the range 1.. {int_0}");
			}
			gclass5_0.class9_0 = this;
			int_24 = int_52;
			int_23 = 1 << int_24;
			int_25 = int_23 - 1;
			int_29 = int_53 + 7;
			int_28 = 1 << int_29;
			int_30 = int_28 - 1;
			int_31 = (int_29 + int_14 - 1) / int_14;
			byte_1 = new byte[int_23 * 2];
			short_0 = new short[int_23];
			short_1 = new short[int_28];
			int_44 = 1 << int_53 + 6;
			byte_0 = new byte[int_44 * 4];
			int_46 = int_44;
			int_43 = 3 * int_44;
			compressionLevel_0 = compressionLevel_1;
			compressionStrategy_0 = compressionStrategy_1;
			method_30();
			return 0;
		}
		throw new GException0("windowBits must be in the range 9..15.");
	}

	internal void method_30()
	{
		GClass5 gClass = gclass5_0;
		gclass5_0.long_1 = 0L;
		gClass.long_0 = 0L;
		gclass5_0.string_0 = null;
		int_21 = 0;
		int_20 = 0;
		bool_0 = false;
		int_19 = (Boolean_0 ? int_3 : int_4);
		gclass5_0.uint_0 = GClass4.smethod_0(0u, null, 0, 0);
		int_22 = 0;
		method_1();
		method_0();
	}

	internal int method_31()
	{
		if (int_19 != int_3 && int_19 != int_4 && int_19 != int_5)
		{
			return -2;
		}
		byte_0 = null;
		short_1 = null;
		short_0 = null;
		byte_1 = null;
		if (int_19 != int_4)
		{
			return 0;
		}
		return -3;
	}

	private void method_32()
	{
		switch (class10_0.deflateFlavor_0)
		{
		case DeflateFlavor.Store:
			delegate0_0 = method_19;
			break;
		case DeflateFlavor.Fast:
			delegate0_0 = method_23;
			break;
		case DeflateFlavor.Slow:
			delegate0_0 = method_24;
			break;
		}
	}

	internal int method_33(CompressionLevel compressionLevel_1, CompressionStrategy compressionStrategy_1)
	{
		int result = 0;
		if (compressionLevel_0 != compressionLevel_1)
		{
			Class10 @class = Class10.smethod_0(compressionLevel_1);
			if (@class.deflateFlavor_0 != class10_0.deflateFlavor_0 && gclass5_0.long_0 != 0L)
			{
				result = gclass5_0.method_13(FlushType.Partial);
			}
			compressionLevel_0 = compressionLevel_1;
			class10_0 = @class;
			method_32();
		}
		compressionStrategy_0 = compressionStrategy_1;
		return result;
	}

	internal int method_34(byte[] byte_2)
	{
		int num = byte_2.Length;
		int sourceIndex = 0;
		if (byte_2 != null && int_19 == int_3)
		{
			gclass5_0.uint_0 = GClass4.smethod_0(gclass5_0.uint_0, byte_2, 0, byte_2.Length);
			if (num < int_14)
			{
				return 0;
			}
			if (num > int_23 - int_16)
			{
				num = int_23 - int_16;
				sourceIndex = byte_2.Length - num;
			}
			Array.Copy(byte_2, sourceIndex, byte_1, 0, num);
			int_36 = num;
			int_32 = num;
			int_27 = byte_1[0] & 0xFF;
			int_27 = ((int_27 << int_31) ^ (byte_1[1] & 0xFF)) & int_30;
			for (int i = 0; i <= num - int_14; i++)
			{
				int_27 = ((int_27 << int_31) ^ (byte_1[i + (int_14 - 1)] & 0xFF)) & int_30;
				short_0[i & int_25] = short_1[int_27];
				short_1[int_27] = (short)i;
			}
			return 0;
		}
		throw new GException0("Stream error.");
	}

	internal int method_35(FlushType flushType_0)
	{
		if (gclass5_0.byte_1 != null && (gclass5_0.byte_0 != null || gclass5_0.int_1 == 0) && (int_19 != int_5 || flushType_0 == FlushType.Finish))
		{
			if (gclass5_0.int_3 == 0)
			{
				gclass5_0.string_0 = string_0[7];
				throw new GException0("OutputBuffer is full (AvailableBytesOut == 0)");
			}
			int num = int_22;
			int_22 = (int)flushType_0;
			if (int_19 == int_3)
			{
				int num2 = int_6 + (int_24 - 8 << 4) << 8;
				int num3 = (int)((compressionLevel_0 - 1) & (CompressionLevel)255) >> 1;
				if (num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if (int_36 != 0)
				{
					num2 |= int_2;
				}
				num2 += 31 - num2 % 31;
				int_19 = int_4;
				byte_0[int_21++] = (byte)(num2 >> 8);
				byte_0[int_21++] = (byte)num2;
				if (int_36 != 0)
				{
					byte_0[int_21++] = (byte)((gclass5_0.uint_0 & 0xFF000000u) >> 24);
					byte_0[int_21++] = (byte)((gclass5_0.uint_0 & 0xFF0000) >> 16);
					byte_0[int_21++] = (byte)((gclass5_0.uint_0 & 0xFF00) >> 8);
					byte_0[int_21++] = (byte)(gclass5_0.uint_0 & 0xFFu);
				}
				gclass5_0.uint_0 = GClass4.smethod_0(0u, null, 0, 0);
			}
			if (int_21 != 0)
			{
				gclass5_0.method_18();
				if (gclass5_0.int_3 == 0)
				{
					int_22 = -1;
					return 0;
				}
			}
			else if (gclass5_0.int_1 == 0 && (int)flushType_0 <= num && flushType_0 != FlushType.Finish)
			{
				return 0;
			}
			if (int_19 == int_5 && gclass5_0.int_1 != 0)
			{
				gclass5_0.string_0 = string_0[7];
				throw new GException0("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
			}
			if (gclass5_0.int_1 != 0 || int_38 != 0 || (flushType_0 != 0 && int_19 != int_5))
			{
				BlockState blockState = delegate0_0(flushType_0);
				if (blockState == BlockState.FinishStarted || blockState == BlockState.FinishDone)
				{
					int_19 = int_5;
				}
				if (blockState == BlockState.NeedMore || blockState == BlockState.FinishStarted)
				{
					if (gclass5_0.int_3 == 0)
					{
						int_22 = -1;
					}
					return 0;
				}
				if (blockState == BlockState.BlockDone)
				{
					if (flushType_0 == FlushType.Partial)
					{
						method_11();
					}
					else
					{
						method_20(0, 0, bool_2: false);
						if (flushType_0 == FlushType.Full)
						{
							for (int i = 0; i < int_28; i++)
							{
								short_1[i] = 0;
							}
						}
					}
					gclass5_0.method_18();
					if (gclass5_0.int_3 == 0)
					{
						int_22 = -1;
						return 0;
					}
				}
			}
			if (flushType_0 != FlushType.Finish)
			{
				return 0;
			}
			if (Boolean_0 && !bool_0)
			{
				byte_0[int_21++] = (byte)((gclass5_0.uint_0 & 0xFF000000u) >> 24);
				byte_0[int_21++] = (byte)((gclass5_0.uint_0 & 0xFF0000) >> 16);
				byte_0[int_21++] = (byte)((gclass5_0.uint_0 & 0xFF00) >> 8);
				byte_0[int_21++] = (byte)(gclass5_0.uint_0 & 0xFFu);
				gclass5_0.method_18();
				bool_0 = true;
				if (int_21 == 0)
				{
					return 1;
				}
				return 0;
			}
			return 1;
		}
		gclass5_0.string_0 = string_0[4];
		throw new GException0($"Something is fishy. [{gclass5_0.string_0}]");
	}
}
