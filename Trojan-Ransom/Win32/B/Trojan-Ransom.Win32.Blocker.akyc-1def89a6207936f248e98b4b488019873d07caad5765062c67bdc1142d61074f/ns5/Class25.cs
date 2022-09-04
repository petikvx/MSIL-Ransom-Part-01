using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns3;
using ns4;

namespace ns5;

internal class Class25
{
	static Class13.Class17 smethod_0(Class13.Class18 class18_0)
	{
		byte[] array = new byte[class18_0.int_10];
		Array.Copy(class18_0.byte_1, class18_0.int_9, array, 0, class18_0.int_10);
		return new Class13.Class17(array);
	}

	static void smethod_1(Class13.Class20.Class21 class21_0)
	{
		int[] array = new int[class21_0.int_3];
		int num = 0;
		class21_0.short_1 = new short[class21_0.short_0.Length];
		for (int i = 0; i < class21_0.int_3; i++)
		{
			array[i] = num;
			num += class21_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class21_0.int_1; j++)
		{
			int num2 = class21_0.byte_0[j];
			if (num2 > 0)
			{
				class21_0.short_1[j] = Class25.smethod_75(array[num2 - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num3 = num2 - 1;
				nint num4 = num3;
				array3[num3] = array2[num4] + (1 << 16 - num2);
			}
		}
	}

	static object smethod_2(Class5 class5_0)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return 20756114;
	}

	static int smethod_3(Class13.Class16 class16_0)
	{
		return 32768 - class16_0.int_3;
	}

	static ICryptoTransform smethod_4(bool bool_0, Class12 class12_0, byte[] byte_0, byte[] byte_1)
	{
		class12_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class12_0.object_0, new object[1] { byte_0 });
		class12_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class12_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class12_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class12_0.object_0, new object[0]);
	}

	static void smethod_5(Class13.Stream0 stream0_0, int int_0)
	{
		Class25.smethod_58(stream0_0, int_0);
		Class25.smethod_58(stream0_0, int_0 >> 16);
	}

	static bool smethod_6(Class13.Class18 class18_0, Class13.Class15 class15_0)
	{
		while (true)
		{
			switch (class18_0.int_8)
			{
			case 5:
			{
				int int_ = Class13.Class18.int_7[class18_0.int_13];
				int num = Class25.smethod_47(class15_0, int_);
				if (num >= 0)
				{
					Class25.smethod_40(class15_0, int_);
					num += Class13.Class18.int_6[class18_0.int_13];
					while (num-- > 0)
					{
						class18_0.byte_1[class18_0.int_14++] = class18_0.byte_2;
					}
					if (class18_0.int_14 == class18_0.int_12)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class25.smethod_27(class18_0.class17_0, class15_0)) & -16) == 0)
				{
					class18_0.byte_1[class18_0.int_14++] = (class18_0.byte_2 = (byte)num2);
					if (class18_0.int_14 == class18_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class18_0.byte_2 = 0;
					}
					class18_0.int_13 = num2 - 16;
					class18_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class18_0.int_14 < class18_0.int_11)
				{
					int num3 = Class25.smethod_47(class15_0, 3);
					if (num3 >= 0)
					{
						Class25.smethod_40(class15_0, 3);
						class18_0.byte_0[Class13.Class18.int_15[class18_0.int_14]] = (byte)num3;
						class18_0.int_14++;
						continue;
					}
					return false;
				}
				class18_0.class17_0 = new Class13.Class17(class18_0.byte_0);
				class18_0.byte_0 = null;
				class18_0.int_14 = 0;
				class18_0.int_8 = 4;
				goto case 4;
			case 2:
				class18_0.int_11 = Class25.smethod_47(class15_0, 4);
				if (class18_0.int_11 >= 0)
				{
					class18_0.int_11 += 4;
					Class25.smethod_40(class15_0, 4);
					class18_0.byte_0 = new byte[19];
					class18_0.int_14 = 0;
					class18_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class18_0.int_10 = Class25.smethod_47(class15_0, 5);
				if (class18_0.int_10 >= 0)
				{
					class18_0.int_10++;
					Class25.smethod_40(class15_0, 5);
					class18_0.int_12 = class18_0.int_9 + class18_0.int_10;
					class18_0.byte_1 = new byte[class18_0.int_12];
					class18_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class18_0.int_9 = Class25.smethod_47(class15_0, 5);
				if (class18_0.int_9 >= 0)
				{
					class18_0.int_9 += 257;
					Class25.smethod_40(class15_0, 5);
					class18_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class18_0.int_8 = 4;
		}
	}

	static int smethod_7(Class13.Class20 class20_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static void smethod_8(Class13.Class22 class22_0, byte[] byte_0)
	{
		class22_0.byte_1 = byte_0;
		class22_0.int_17 = 0;
		class22_0.int_18 = byte_0.Length;
	}

	static int smethod_9(Class13.Class19 class19_0, byte[] byte_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num3 = num2;
		while (true)
		{
			int num4 = Class25.smethod_15(class19_0.class23_0, byte_0, num, num2);
			num += num4;
			class19_0.long_0 += num4;
			num2 -= num4;
			if (num2 == 0 || class19_0.int_6 == 30)
			{
				break;
			}
			Class13.Class22 class22_ = class19_0.class22_0;
			bool bool_ = (class19_0.int_6 & 4) != 0;
			bool bool_2 = (class19_0.int_6 & 8) != 0;
			if (Class25.smethod_52(bool_, class22_, bool_2))
			{
				continue;
			}
			if (class19_0.int_6 != 16)
			{
				if (class19_0.int_6 == 20)
				{
					for (int num5 = 8 + (-class19_0.class23_0.int_2 & 7); num5 > 0; num5 -= 10)
					{
						Class25.smethod_25(class19_0.class23_0, 2, 10);
					}
					class19_0.int_6 = 16;
				}
				else if (class19_0.int_6 == 28)
				{
					Class25.smethod_23(class19_0.class23_0);
					class19_0.int_6 = 30;
				}
				continue;
			}
			return num3 - num2;
		}
		return num3 - num2;
	}

	static void smethod_10(Class13.Class16 class16_0, int int_0, int int_1)
	{
		if ((class16_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class16_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class16_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class16_0.byte_0, num, class16_0.byte_0, class16_0.int_2, int_0);
				class16_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class16_0.byte_0[class16_0.int_2++] = class16_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class25.smethod_67(class16_0, num, int_0, int_1);
		}
	}

	static void smethod_11(Class11 class11_0)
	{
		class11_0.type_0.GetMethod("Clear")!.Invoke(class11_0.object_0, new object[0]);
	}

	static bool smethod_12(Class13.Class14 class14_0)
	{
		int num = Class25.smethod_3(class14_0.class16_0);
		while (num >= 258)
		{
			switch (class14_0.int_17)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class25.smethod_27(class14_0.class17_0, class14_0.class15_0)) & -256) == 0)
				{
					Class25.smethod_31(class14_0.class16_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class14_0.int_19 = Class13.Class14.int_13[num2 - 257];
					class14_0.int_18 = Class13.Class14.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class14_0.class17_1 = null;
				class14_0.class17_0 = null;
				class14_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class14_0.int_18 > 0)
				{
					class14_0.int_17 = 8;
					int num4 = Class25.smethod_47(class14_0.class15_0, class14_0.int_18);
					if (num4 < 0)
					{
						return false;
					}
					Class25.smethod_40(class14_0.class15_0, class14_0.int_18);
					class14_0.int_19 += num4;
				}
				class14_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class25.smethod_27(class14_0.class17_1, class14_0.class15_0);
				if (num2 >= 0)
				{
					class14_0.int_20 = Class13.Class14.int_15[num2];
					class14_0.int_18 = Class13.Class14.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class14_0.int_18 > 0)
				{
					class14_0.int_17 = 10;
					int num3 = Class25.smethod_47(class14_0.class15_0, class14_0.int_18);
					if (num3 < 0)
					{
						return false;
					}
					Class25.smethod_40(class14_0.class15_0, class14_0.int_18);
					class14_0.int_20 += num3;
				}
				Class25.smethod_10(class14_0.class16_0, class14_0.int_19, class14_0.int_20);
				num -= class14_0.int_19;
				class14_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_13(byte[] byte_0, Class13.Class17 class17_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
		}
		int num3 = 0;
		int num4 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num3;
			num3 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num5 = array2[j] & 0x1FF80;
				int num6 = num3 & 0x1FF80;
				num4 += num6 - num5 >> 16 - j;
			}
		}
		class17_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class17_0.short_0[Class25.smethod_75(k)] = (short)((-num7 << 4) | num8);
				num7 += 1 << num8 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num11 = byte_0[l];
			if (num11 == 0)
			{
				continue;
			}
			num3 = array2[num11];
			int num12 = Class25.smethod_75(num3);
			if (num11 <= 9)
			{
				do
				{
					class17_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class17_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class17_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static bool smethod_14(Class13.Class14 class14_0)
	{
		switch (class14_0.int_17)
		{
		case 2:
		{
			if (class14_0.bool_0)
			{
				class14_0.int_17 = 12;
				return false;
			}
			int num = Class25.smethod_47(class14_0.class15_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class25.smethod_40(class14_0.class15_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class14_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class25.smethod_48(class14_0.class15_0);
				class14_0.int_17 = 3;
				break;
			case 1:
				class14_0.class17_0 = Class13.Class17.class17_0;
				class14_0.class17_1 = Class13.Class17.class17_1;
				class14_0.int_17 = 7;
				break;
			case 2:
				class14_0.class18_0 = new Class13.Class18();
				class14_0.int_17 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class14_0.int_21 = Class25.smethod_47(class14_0.class15_0, 16)) < 0)
			{
				return false;
			}
			Class25.smethod_40(class14_0.class15_0, 16);
			class14_0.int_17 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class25.smethod_47(class14_0.class15_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class25.smethod_40(class14_0.class15_0, 16);
			class14_0.int_17 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class25.smethod_38(class14_0.class16_0, class14_0.class15_0, class14_0.int_21);
			class14_0.int_21 -= num3;
			if (class14_0.int_21 == 0)
			{
				class14_0.int_17 = 2;
				return true;
			}
			return !class14_0.class15_0.IsNeedingInput;
		}
		case 6:
			if (!Class25.smethod_6(class14_0.class18_0, class14_0.class15_0))
			{
				return false;
			}
			class14_0.class17_0 = Class25.smethod_41(class14_0.class18_0);
			class14_0.class17_1 = Class25.smethod_0(class14_0.class18_0);
			class14_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class25.smethod_12(class14_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static int smethod_15(Class13.Class23 class23_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class23_0.int_2 >= 8)
		{
			class23_0.byte_0[class23_0.int_1++] = (byte)class23_0.uint_0;
			class23_0.uint_0 >>= 8;
			class23_0.int_2 -= 8;
		}
		if (int_1 > class23_0.int_1 - class23_0.int_0)
		{
			int_1 = class23_0.int_1 - class23_0.int_0;
			Array.Copy(class23_0.byte_0, class23_0.int_0, byte_0, int_0, int_1);
			class23_0.int_0 = 0;
			class23_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class23_0.byte_0, class23_0.int_0, byte_0, int_0, int_1);
			class23_0.int_0 += int_1;
		}
		return int_1;
	}

	static void smethod_16(Class13.Class19 class19_0, byte[] byte_0)
	{
		Class25.smethod_8(class19_0.class22_0, byte_0);
	}

	static void smethod_17(int int_0, byte[] byte_0, int int_1, Class13.Class20 class20_0, bool bool_0)
	{
		short[] short_;
		(short_ = class20_0.class21_0.short_0)[256] = (short)(short_[256] + 1);
		Class25.smethod_46(class20_0.class21_0);
		Class25.smethod_46(class20_0.class21_1);
		Class25.smethod_42(class20_0.class21_0, class20_0.class21_2);
		Class25.smethod_42(class20_0.class21_1, class20_0.class21_2);
		Class25.smethod_46(class20_0.class21_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class20_0.class21_2.byte_0[Class13.Class20.int_8[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class25.smethod_72(class20_0.class21_2) + Class25.smethod_72(class20_0.class21_0) + Class25.smethod_72(class20_0.class21_1) + class20_0.int_10;
		int num4 = class20_0.int_10;
		for (int i = 0; i < 286; i++)
		{
			num4 += class20_0.class21_0.short_0[i] * Class13.Class20.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class20_0.class21_1.short_0[j] * Class13.Class20.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
		{
			Class25.smethod_32(int_1, byte_0, int_0, class20_0, bool_0);
		}
		else if (num3 == num4)
		{
			Class25.smethod_25(class20_0.class23_0, 2 + (bool_0 ? 1 : 0), 3);
			Class13.Class20.Class21 class21_ = class20_0.class21_0;
			short[] short_2 = Class13.Class20.short_1;
			byte[] byte_ = Class13.Class20.byte_2;
			Class25.smethod_68(short_2, class21_, byte_);
			class21_ = class20_0.class21_1;
			short_2 = Class13.Class20.short_2;
			byte_ = Class13.Class20.byte_3;
			Class25.smethod_68(short_2, class21_, byte_);
			Class25.smethod_28(class20_0);
			Class25.smethod_26(class20_0);
		}
		else
		{
			Class25.smethod_25(class20_0.class23_0, 4 + (bool_0 ? 1 : 0), 3);
			Class25.smethod_76(num, class20_0);
			Class25.smethod_28(class20_0);
			Class25.smethod_26(class20_0);
		}
	}

	static bool smethod_18(int int_0, Class13.Class20 class20_0, int int_1)
	{
		class20_0.short_0[class20_0.int_9] = (short)int_0;
		class20_0.byte_1[class20_0.int_9++] = (byte)(int_1 - 3);
		int num = Class25.smethod_35(class20_0, int_1 - 3);
		short[] short_;
		short[] array = (short_ = class20_0.class21_0.short_0);
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (num >= 265 && num < 285)
		{
			class20_0.int_10 += (num - 261) / 4;
		}
		int num3 = Class25.smethod_7(class20_0, int_0 - 1);
		short[] array2 = (short_ = class20_0.class21_1.short_0);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (num3 >= 4)
		{
			class20_0.int_10 += num3 / 2 - 1;
		}
		return class20_0.int_9 >= 16384;
	}

	static int smethod_19(byte[] byte_0, int int_0, Class13.Class14 class14_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class14_0.int_17 != 11)
			{
				int num2 = Class25.smethod_33(int_1, int_0, byte_0, class14_0.class16_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class25.smethod_14(class14_0) || (class14_0.class16_0.int_3 > 0 && class14_0.int_17 != 11));
		return num;
	}

	static bool smethod_20(Class13.Class20 class20_0)
	{
		return class20_0.int_9 >= 16384;
	}

	static void smethod_21(int int_0, Class13.Class23 class23_0)
	{
		class23_0.byte_0[class23_0.int_1++] = (byte)int_0;
		class23_0.byte_0[class23_0.int_1++] = (byte)(int_0 >> 8);
	}

	static int smethod_22(Class13.Class16 class16_0)
	{
		return class16_0.int_3;
	}

	static void smethod_23(Class13.Class23 class23_0)
	{
		if (class23_0.int_2 > 0)
		{
			class23_0.byte_0[class23_0.int_1++] = (byte)class23_0.uint_0;
			if (class23_0.int_2 > 8)
			{
				class23_0.byte_0[class23_0.int_1++] = (byte)(class23_0.uint_0 >> 8);
			}
		}
		class23_0.uint_0 = 0u;
		class23_0.int_2 = 0;
	}

	static bool smethod_24(int int_0, Class13.Class22 class22_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class22_0.short_1;
		int int_ = class22_0.int_14;
		int num3 = class22_0.int_14 + class22_0.int_12;
		int num4 = Math.Max(class22_0.int_12, 2);
		int num5 = Math.Max(class22_0.int_14 - 32506, 0);
		int num6 = class22_0.int_14 + 258 - 1;
		byte b = class22_0.byte_0[num3 - 1];
		byte b2 = class22_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class22_0.int_15)
		{
			num2 = class22_0.int_15;
		}
		do
		{
			if (class22_0.byte_0[int_0 + num4] != b2 || class22_0.byte_0[int_0 + num4 - 1] != b || class22_0.byte_0[int_0] != class22_0.byte_0[int_] || class22_0.byte_0[int_0 + 1] != class22_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && class22_0.byte_0[++int_] == class22_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class22_0.int_11 = int_0;
				num3 = int_;
				num4 = int_ - class22_0.int_14;
				if (num4 >= num2)
				{
					break;
				}
				b = class22_0.byte_0[num3 - 1];
				b2 = class22_0.byte_0[num3];
			}
			int_ = class22_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class22_0.int_12 = Math.Min(num4, class22_0.int_15);
		return class22_0.int_12 >= 3;
	}

	static void smethod_25(Class13.Class23 class23_0, int int_0, int int_1)
	{
		class23_0.uint_0 |= (uint)(int_0 << class23_0.int_2);
		class23_0.int_2 += int_1;
		if (class23_0.int_2 >= 16)
		{
			class23_0.byte_0[class23_0.int_1++] = (byte)class23_0.uint_0;
			class23_0.byte_0[class23_0.int_1++] = (byte)(class23_0.uint_0 >> 8);
			class23_0.uint_0 >>= 16;
			class23_0.int_2 -= 16;
		}
	}

	static void smethod_26(Class13.Class20 class20_0)
	{
		class20_0.int_9 = 0;
		class20_0.int_10 = 0;
	}

	static int smethod_27(Class13.Class17 class17_0, Class13.Class15 class15_0)
	{
		int num;
		int num2;
		if ((num = Class25.smethod_47(class15_0, 9)) >= 0)
		{
			if ((num2 = class17_0.short_0[num]) >= 0)
			{
				Class25.smethod_40(class15_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class25.smethod_47(class15_0, int_)) >= 0)
			{
				num2 = class17_0.short_0[num3 | (num >> 9)];
				Class25.smethod_40(class15_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class15_0.int_2;
			num = Class25.smethod_47(class15_0, int_2);
			num2 = class17_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class25.smethod_40(class15_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class15_0.int_2;
		num = Class25.smethod_47(class15_0, int_3);
		num2 = class17_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class25.smethod_40(class15_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_28(Class13.Class20 class20_0)
	{
		for (int i = 0; i < class20_0.int_9; i++)
		{
			int num = class20_0.byte_1[i] & 0xFF;
			int num2 = class20_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class25.smethod_35(class20_0, num);
				Class25.smethod_49(class20_0.class21_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class25.smethod_25(class20_0.class23_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class25.smethod_7(class20_0, num2);
				Class25.smethod_49(class20_0.class21_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class25.smethod_25(class20_0.class23_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class25.smethod_49(class20_0.class21_0, num);
			}
		}
		Class25.smethod_49(class20_0.class21_0, 256);
	}

	static object smethod_29(Class6 class6_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("VB~Ž!QI!_^^H†V:2C");
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (true)
			{
				MessageBox.Show("w\u0081J~;#hD…\u008fƒ&†I~k=!K`/\u0090)v-J07D-‚Œ0:M…‘o^dQUh†0€Yu7\u00815~N&Byxfq„…P’w,‰ˆk\u008fŒl`Uz.lG5f@ƒN UŠ$]*‹f,");
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					new decimal(897L);
					ProjectData.ClearProjectError();
				}
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					new decimal(9316L);
					ProjectData.ClearProjectError();
				}
				new decimal(25954L);
				MessageBox.Show("uv‡hm…+-MeG-1(j+’9P/…V#’…OS-Q…Bƒr6GPU!Rn_HW'=8p>CeOŽGXl>rˆv=R‘oZCVMŽt9i‘ytb\\’Žtlr4|~VF\\:\\(q`=5;`l\u008fwy~u])\u008fQ4eˆ0?v3");
			}
		}
		return 16297698;
	}

	static void smethod_30(Class13.Class22 class22_0)
	{
		class22_0.int_10 = (class22_0.byte_0[class22_0.int_14] << 5) ^ class22_0.byte_0[class22_0.int_14 + 1];
	}

	static void smethod_31(Class13.Class16 class16_0, int int_0)
	{
		if (class16_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class16_0.byte_0[class16_0.int_2++] = (byte)int_0;
		class16_0.int_2 &= 32767;
	}

	static void smethod_32(int int_0, byte[] byte_0, int int_1, Class13.Class20 class20_0, bool bool_0)
	{
		Class25.smethod_25(class20_0.class23_0, bool_0 ? 1 : 0, 3);
		Class25.smethod_23(class20_0.class23_0);
		Class25.smethod_21(int_0, class20_0.class23_0);
		Class25.smethod_21(~int_0, class20_0.class23_0);
		Class25.smethod_56(int_1, int_0, class20_0.class23_0, byte_0);
		Class25.smethod_26(class20_0);
	}

	static int smethod_33(int int_0, int int_1, byte[] byte_0, Class13.Class16 class16_0)
	{
		int num = class16_0.int_2;
		if (int_0 > class16_0.int_3)
		{
			int_0 = class16_0.int_3;
		}
		else
		{
			num = (class16_0.int_2 - class16_0.int_3 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class16_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class16_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class16_0.int_3 -= num2;
		if (class16_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static object smethod_34(Class7 class7_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		new decimal(3L);
		MessageBox.Show("u€M1}i@\u007f6Z>Rf‹‰?Fn…‹!Li\\b&^Z7~.ˆY`]88‹1[7^Xƒ*!_RtO}>yr]H7„av+xhKLHŒ&Np&N]IsV‡xQaY,x{ ‚/y#4 GIMPQ‰-Wt'Y##HOsO‘'SRR");
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return 890;
	}

	static int smethod_35(Class13.Class20 class20_0, int int_0)
	{
		if (int_0 == 255)
		{
			return 285;
		}
		int num = 257;
		while (int_0 >= 8)
		{
			num += 4;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static void smethod_36(Class13.Class16 class16_0)
	{
		class16_0.int_2 = 0;
		class16_0.int_3 = 0;
	}

	static byte[] smethod_37(int int_0, byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			Class13.Stream0 stream = new Class13.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class13.Class19 class2 = new Class13.Class19();
				DateTime now = DateTime.Now;
				long num3 = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				uint num4 = uint.MaxValue;
				uint num5 = uint.MaxValue;
				int num6 = 0;
				int num7 = byte_0.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_0[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				Class25.smethod_5(stream, 67324752);
				Class25.smethod_58(stream, 20);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 8);
				Class25.smethod_5(stream, (int)num3);
				Class25.smethod_5(stream, (int)num5);
				long position3 = stream.Position;
				Class25.smethod_5(stream, 0);
				Class25.smethod_5(stream, byte_0.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class25.smethod_58(stream, bytes.Length);
				Class25.smethod_58(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class25.smethod_16(class2, byte_0);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class25.smethod_9(class2, array9);
					if (num8 <= 0)
					{
						break;
					}
					stream.Write(array9, 0, num8);
				}
				class2.int_6 |= 12;
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					int num9 = Class25.smethod_9(class2, array10);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long long_ = class2.long_0;
				Class25.smethod_5(stream, 33639248);
				Class25.smethod_58(stream, 20);
				Class25.smethod_58(stream, 20);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 8);
				Class25.smethod_5(stream, (int)num3);
				Class25.smethod_5(stream, (int)num5);
				Class25.smethod_5(stream, (int)long_);
				Class25.smethod_5(stream, byte_0.Length);
				Class25.smethod_58(stream, bytes.Length);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 0);
				Class25.smethod_5(stream, 0);
				Class25.smethod_5(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class25.smethod_5(stream, 101010256);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 0);
				Class25.smethod_58(stream, 1);
				Class25.smethod_58(stream, 1);
				Class25.smethod_5(stream, 46 + bytes.Length);
				Class25.smethod_5(stream, (int)(30 + bytes.Length + long_));
				Class25.smethod_58(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class25.smethod_5(stream, (int)long_);
				break;
			}
			case 1:
			{
				Class25.smethod_5(stream, 25000571);
				Class25.smethod_5(stream, byte_0.Length);
				byte[] array5;
				for (int i = 0; i < byte_0.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_0.Length - i)];
					Buffer.BlockCopy(byte_0, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class25.smethod_5(stream, 0);
					Class25.smethod_5(stream, array5.Length);
					Class13.Class19 @class = new Class13.Class19();
					Class25.smethod_16(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class25.smethod_9(@class, array6);
						if (num <= 0)
						{
							break;
						}
						stream.Write(array6, 0, num);
					}
					@class.int_6 |= 12;
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						int num2 = Class25.smethod_9(@class, array7);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class25.smethod_5(stream, (int)@class.long_0);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class25.smethod_5(stream, 41777787);
				byte[] array3 = Class25.smethod_37(1, byte_0, (byte[])null, (byte[])null);
				using (Class12 class12_ = new Class12())
				{
					using ICryptoTransform cryptoTransform2 = Class25.smethod_4(bool_0: false, class12_, byte_1, byte_2);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class25.smethod_5(stream, 58555003);
				byte[] array = Class25.smethod_37(1, byte_0, (byte[])null, (byte[])null);
				using (Class11 class11_ = new Class11())
				{
					using ICryptoTransform cryptoTransform = Class25.smethod_65(byte_2, bool_0: false, byte_1, class11_);
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			Class13.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static int smethod_38(Class13.Class16 class16_0, Class13.Class15 class15_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class16_0.int_3), class15_0.AvailableBytes);
		int num = 32768 - class16_0.int_2;
		int num2;
		if (int_0 > num)
		{
			num2 = Class25.smethod_69(class15_0, class16_0.byte_0, class16_0.int_2, num);
			if (num2 == num)
			{
				num2 += Class25.smethod_69(class15_0, class16_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class25.smethod_69(class15_0, class16_0.byte_0, class16_0.int_2, int_0);
		}
		class16_0.int_2 = (class16_0.int_2 + num2) & 0x7FFF;
		class16_0.int_3 += num2;
		return num2;
	}

	static bool smethod_39(Class13.Class20 class20_0, int int_0)
	{
		class20_0.short_0[class20_0.int_9] = 0;
		class20_0.byte_1[class20_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class20_0.class21_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return class20_0.int_9 >= 16384;
	}

	static void smethod_40(Class13.Class15 class15_0, int int_0)
	{
		class15_0.uint_0 >>= int_0;
		class15_0.int_2 -= int_0;
	}

	static Class13.Class17 smethod_41(Class13.Class18 class18_0)
	{
		byte[] array = new byte[class18_0.int_9];
		Array.Copy(class18_0.byte_1, 0, array, 0, class18_0.int_9);
		return new Class13.Class17(array);
	}

	static void smethod_42(Class13.Class20.Class21 class21_0, Class13.Class20.Class21 class21_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class21_0.int_1)
		{
			int num3 = 1;
			int num4 = class21_0.byte_0[num2];
			int num5;
			int num6;
			if (num4 == 0)
			{
				num5 = 138;
				num6 = 3;
			}
			else
			{
				num5 = 6;
				num6 = 3;
				if (num != num4)
				{
					short[] short_;
					short[] array = (short_ = class21_1.short_0);
					nint num7 = num4;
					array[num4] = (short)(short_[num7] + 1);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class21_0.int_1 && num == class21_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				short[] short_;
				short[] array2 = (short_ = class21_1.short_0);
				int num8 = num;
				nint num7 = num8;
				array2[num8] = (short)(short_[num7] + (short)num3);
			}
			else if (num != 0)
			{
				short[] short_;
				(short_ = class21_1.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num3 <= 10)
			{
				short[] short_;
				(short_ = class21_1.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class21_1.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static bool smethod_43(Class13.Class22 class22_0)
	{
		return class22_0.int_18 == class22_0.int_17;
	}

	static int smethod_44(Class13.Stream0 stream0_0)
	{
		return Class25.smethod_57(stream0_0) | (Class25.smethod_57(stream0_0) << 16);
	}

	static int smethod_45(Class13.Class22 class22_0)
	{
		int num = ((class22_0.int_10 << 5) ^ class22_0.byte_0[class22_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class22_0.short_1[class22_0.int_14 & 0x7FFF] = class22_0.short_0[num]);
		class22_0.short_0[num] = (short)class22_0.int_14;
		class22_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_46(Class13.Class20.Class21 class21_0)
	{
		int num = class21_0.short_0.Length;
		int[] array = new int[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class21_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class21_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
				{
					array[num5] = array[num6];
					num5 = num6;
				}
				array[num5] = i;
				num3 = i;
			}
		}
		while (num2 < 2)
		{
			int num7 = ((num3 < 2) ? (++num3) : 0);
			array[num2++] = num7;
		}
		class21_0.int_1 = Math.Max(num3 + 1, class21_0.int_0);
		int num8 = num2;
		int[] array2 = new int[4 * num2 - 2];
		int[] array3 = new int[2 * num2 - 1];
		int num9 = num8;
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class21_0.short_0[num10] << 8;
			array[j] = j;
		}
		do
		{
			int num11 = array[0];
			int num12 = array[--num2];
			int num13 = 0;
			int num14;
			for (num14 = 1; num14 < num2; num14 = num14 * 2 + 1)
			{
				if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
				{
					num14++;
				}
				array[num13] = array[num14];
				num13 = num14;
			}
			int num15 = array3[num12];
			while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
			{
				array[num14] = array[num13];
			}
			array[num14] = num12;
			int num16 = array[0];
			num12 = num9++;
			array2[2 * num12] = num11;
			array2[2 * num12 + 1] = num16;
			int num17 = Math.Min(array3[num11] & 0xFF, array3[num16] & 0xFF);
			num15 = (array3[num12] = array3[num11] + array3[num16] - num17 + 1);
			num13 = 0;
			for (num14 = 1; num14 < num2; num14 = num13 * 2 + 1)
			{
				if (num14 + 1 < num2 && array3[array[num14]] > array3[array[num14 + 1]])
				{
					num14++;
				}
				array[num13] = array[num14];
				num13 = num14;
			}
			while ((num14 = num13) > 0 && array3[array[num13 = (num14 - 1) / 2]] > num15)
			{
				array[num14] = array[num13];
			}
			array[num14] = num12;
		}
		while (num2 > 1);
		Class25.smethod_77(array2, class21_0);
	}

	static int smethod_47(Class13.Class15 class15_0, int int_0)
	{
		if (class15_0.int_2 < int_0)
		{
			if (class15_0.int_0 == class15_0.int_1)
			{
				return -1;
			}
			class15_0.uint_0 |= (uint)(((class15_0.byte_0[class15_0.int_0++] & 0xFF) | ((class15_0.byte_0[class15_0.int_0++] & 0xFF) << 8)) << class15_0.int_2);
			class15_0.int_2 += 16;
		}
		return (int)(class15_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_48(Class13.Class15 class15_0)
	{
		class15_0.uint_0 >>= class15_0.int_2 & 7;
		class15_0.int_2 &= -8;
	}

	static void smethod_49(Class13.Class20.Class21 class21_0, int int_0)
	{
		Class25.smethod_25(class21_0.class20_0.class23_0, class21_0.short_1[int_0] & 0xFFFF, (int)class21_0.byte_0[int_0]);
	}

	static void smethod_50(Class13.Class19 class19_0)
	{
		class19_0.int_6 |= 12;
	}

	static void smethod_51(Class13.Class20.Class21 class21_0, Class13.Class20.Class21 class21_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class21_0.int_1)
		{
			int num3 = 1;
			int num4 = class21_0.byte_0[num2];
			int num5;
			int num6;
			if (num4 == 0)
			{
				num5 = 138;
				num6 = 3;
			}
			else
			{
				num5 = 6;
				num6 = 3;
				if (num != num4)
				{
					Class25.smethod_49(class21_1, num4);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class21_0.int_1 && num == class21_0.byte_0[num2])
			{
				num2++;
				if (++num3 >= num5)
				{
					break;
				}
			}
			if (num3 < num6)
			{
				while (num3-- > 0)
				{
					Class25.smethod_49(class21_1, num);
				}
			}
			else if (num != 0)
			{
				Class25.smethod_49(class21_1, 16);
				Class25.smethod_25(class21_0.class20_0.class23_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class25.smethod_49(class21_1, 17);
				Class25.smethod_25(class21_0.class20_0.class23_0, num3 - 3, 3);
			}
			else
			{
				Class25.smethod_49(class21_1, 18);
				Class25.smethod_25(class21_0.class20_0.class23_0, num3 - 11, 7);
			}
		}
	}

	static bool smethod_52(bool bool_0, Class13.Class22 class22_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class25.smethod_55(class22_0);
			bool bool_2 = bool_0 && class22_0.int_17 == class22_0.int_18;
			flag = Class25.smethod_71(bool_1, class22_0, bool_2);
		}
		while (class22_0.class23_0.int_1 == 0 && flag);
		return flag;
	}

	static byte[] smethod_53(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class25.smethod_37(2, byte_2, byte_0, byte_1);
	}

	static void smethod_54(Class13.Class22 class22_0)
	{
		Array.Copy(class22_0.byte_0, 32768, class22_0.byte_0, 0, 32768);
		class22_0.int_11 -= 32768;
		class22_0.int_14 -= 32768;
		class22_0.int_13 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = class22_0.short_0[i] & 0xFFFF;
			class22_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = class22_0.short_1[j] & 0xFFFF;
			class22_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	static void smethod_55(Class13.Class22 class22_0)
	{
		if (class22_0.int_14 >= 65274)
		{
			Class25.smethod_54(class22_0);
		}
		while (class22_0.int_15 < 262 && class22_0.int_17 < class22_0.int_18)
		{
			int num = 65536 - class22_0.int_15 - class22_0.int_14;
			if (num > class22_0.int_18 - class22_0.int_17)
			{
				num = class22_0.int_18 - class22_0.int_17;
			}
			Array.Copy(class22_0.byte_1, class22_0.int_17, class22_0.byte_0, class22_0.int_14 + class22_0.int_15, num);
			class22_0.int_17 += num;
			class22_0.int_16 += num;
			class22_0.int_15 += num;
		}
		if (class22_0.int_15 >= 3)
		{
			Class25.smethod_30(class22_0);
		}
	}

	static void smethod_56(int int_0, int int_1, Class13.Class23 class23_0, byte[] byte_0)
	{
		Array.Copy(byte_0, int_0, class23_0.byte_0, class23_0.int_1, int_1);
		class23_0.int_1 += int_1;
	}

	static int smethod_57(Class13.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_58(Class13.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static void smethod_59(int int_0, Class13.Class16 class16_0, byte[] byte_0, int int_1)
	{
		if (class16_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class16_0.byte_0, 0, int_0);
		class16_0.int_2 = int_0 & 0x7FFF;
	}

	static void smethod_60(Class6 class6_0)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
		}
	}

	static void smethod_61(Class5 class5_0)
	{
	}

	static void smethod_62(Class13.Class15 class15_0)
	{
		class15_0.int_2 = 0;
		class15_0.int_1 = 0;
		class15_0.int_0 = 0;
		class15_0.uint_0 = 0u;
	}

	static void smethod_63(int int_0, byte[] byte_0, int int_1, Class13.Class15 class15_0)
	{
		if (class15_0.int_0 < class15_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class15_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class15_0.int_2);
				class15_0.int_2 += 8;
			}
			class15_0.byte_0 = byte_0;
			class15_0.int_0 = int_1;
			class15_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_64(Class7 class7_0)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		new decimal(805275L);
		new decimal(26L);
		new decimal(694607496L);
		new decimal(169887L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(11039L);
			MessageBox.Show("=9\u008d<9/9'nLN`}m\u0081MŠu,%&L");
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			new decimal(658763L);
		}
	}

	static ICryptoTransform smethod_65(byte[] byte_0, bool bool_0, byte[] byte_1, Class11 class11_0)
	{
		class11_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_1 });
		class11_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class11_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class11_0.object_0, new object[0]);
	}

	static bool smethod_66(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_0.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_1.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	static void smethod_67(Class13.Class16 class16_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class16_0.byte_0[class16_0.int_2++] = class16_0.byte_0[int_0++];
			class16_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_68(short[] short_0, Class13.Class20.Class21 class21_0, byte[] byte_0)
	{
		class21_0.short_1 = short_0;
		class21_0.byte_0 = byte_0;
	}

	static int smethod_69(Class13.Class15 class15_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class15_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class15_0.uint_0;
			class15_0.uint_0 >>= 8;
			class15_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class15_0.int_1 - class15_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class15_0.byte_0, class15_0.int_0, byte_0, int_0, int_1);
		class15_0.int_0 += int_1;
		if (((uint)(class15_0.int_0 - class15_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class15_0.uint_0 = class15_0.byte_0[class15_0.int_0++] & 0xFFu;
			class15_0.int_2 = 8;
		}
		return num + int_1;
	}

	static byte[] smethod_70(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class25.smethod_66(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class13.Stream0 stream = new Class13.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class25.smethod_44(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class25.smethod_57(stream);
			int num3 = Class25.smethod_57(stream);
			int num4 = Class25.smethod_57(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class25.smethod_44(stream);
			Class25.smethod_44(stream);
			Class25.smethod_44(stream);
			int num5 = Class25.smethod_44(stream);
			int num6 = Class25.smethod_57(stream);
			int num7 = Class25.smethod_57(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class13.Class14 class14_ = new Class13.Class14(array2);
			array = new byte[num5];
			Class25.smethod_19(array, 0, class14_, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class25.smethod_44(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class25.smethod_44(stream);
					num11 = Class25.smethod_44(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class13.Class14 class14_2 = new Class13.Class14(array3);
					Class25.smethod_19(array, i, class14_2, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 177, 7, 203, 219, 13, 123, 206, 143 };
				byte[] byte_2 = new byte[8] { 236, 14, 253, 127, 244, 134, 128, 107 };
				using Class12 class12_ = new Class12();
				using ICryptoTransform cryptoTransform = Class25.smethod_4(bool_0: true, class12_, byte_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class25.smethod_70(byte_3);
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class11 class11_ = new Class11();
				using ICryptoTransform cryptoTransform2 = Class25.smethod_65(byte_5, bool_0: true, byte_4, class11_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class25.smethod_70(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static bool smethod_71(bool bool_0, Class13.Class22 class22_0, bool bool_1)
	{
		if (class22_0.int_15 < 262 && !bool_1)
		{
			return false;
		}
		Class13.Class20 class20_2;
		byte[] byte_;
		int int_4;
		do
		{
			if (class22_0.int_15 >= 262 || bool_1)
			{
				if (class22_0.int_15 != 0)
				{
					if (class22_0.int_14 >= 65274)
					{
						Class25.smethod_54(class22_0);
					}
					int int_ = class22_0.int_11;
					int int_2 = class22_0.int_12;
					if (class22_0.int_15 >= 3)
					{
						int num = Class25.smethod_45(class22_0);
						if (num != 0 && class22_0.int_14 - num <= 32506 && Class25.smethod_24(num, class22_0) && class22_0.int_12 <= 5 && class22_0.int_12 == 3 && class22_0.int_14 - class22_0.int_11 > 4096)
						{
							class22_0.int_12 = 2;
						}
					}
					if (int_2 >= 3 && class22_0.int_12 <= int_2)
					{
						Class13.Class20 class20_ = class22_0.class20_0;
						int int_3 = class22_0.int_14 - 1 - int_;
						Class25.smethod_18(int_3, class20_, int_2);
						int_2 -= 2;
						do
						{
							class22_0.int_14++;
							class22_0.int_15--;
							if (class22_0.int_15 >= 3)
							{
								Class25.smethod_45(class22_0);
							}
						}
						while (--int_2 > 0);
						class22_0.int_14++;
						class22_0.int_15--;
						class22_0.bool_0 = false;
						class22_0.int_12 = 2;
					}
					else
					{
						if (class22_0.bool_0)
						{
							Class25.smethod_39(class22_0.class20_0, class22_0.byte_0[class22_0.int_14 - 1] & 0xFF);
						}
						class22_0.bool_0 = true;
						class22_0.int_14++;
						class22_0.int_15--;
					}
					continue;
				}
				if (class22_0.bool_0)
				{
					Class25.smethod_39(class22_0.class20_0, class22_0.byte_0[class22_0.int_14 - 1] & 0xFF);
				}
				class22_0.bool_0 = false;
				class20_2 = class22_0.class20_0;
				byte_ = class22_0.byte_0;
				int_4 = class22_0.int_13;
				int int_5 = class22_0.int_14 - class22_0.int_13;
				Class25.smethod_17(int_4, byte_, int_5, class20_2, bool_0);
				class22_0.int_13 = class22_0.int_14;
				return false;
			}
			return true;
		}
		while (class22_0.class20_0.int_9 < 16384);
		int num2 = class22_0.int_14 - class22_0.int_13;
		if (class22_0.bool_0)
		{
			num2--;
		}
		bool flag = bool_0 && class22_0.int_15 == 0 && !class22_0.bool_0;
		class20_2 = class22_0.class20_0;
		byte_ = class22_0.byte_0;
		int_4 = class22_0.int_13;
		Class25.smethod_17(int_4, byte_, num2, class20_2, flag);
		class22_0.int_13 += num2;
		return !flag;
	}

	static int smethod_72(Class13.Class20.Class21 class21_0)
	{
		int num = 0;
		for (int i = 0; i < class21_0.short_0.Length; i++)
		{
			num += class21_0.short_0[i] * class21_0.byte_0[i];
		}
		return num;
	}

	static byte[] smethod_73(byte[] byte_0)
	{
		return Class25.smethod_37(1, byte_0, (byte[])null, (byte[])null);
	}

	static byte[] smethod_74(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class25.smethod_37(3, byte_1, byte_0, byte_2);
	}

	static short smethod_75(int int_0)
	{
		return (short)((Class13.Class20.byte_0[int_0 & 0xF] << 12) | (Class13.Class20.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class13.Class20.byte_0[(int_0 >> 8) & 0xF] << 4) | Class13.Class20.byte_0[int_0 >> 12]);
	}

	static void smethod_76(int int_0, Class13.Class20 class20_0)
	{
		Class25.smethod_1(class20_0.class21_2);
		Class25.smethod_1(class20_0.class21_0);
		Class25.smethod_1(class20_0.class21_1);
		Class25.smethod_25(class20_0.class23_0, class20_0.class21_0.int_1 - 257, 5);
		Class25.smethod_25(class20_0.class23_0, class20_0.class21_1.int_1 - 1, 5);
		Class25.smethod_25(class20_0.class23_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class25.smethod_25(class20_0.class23_0, (int)class20_0.class21_2.byte_0[Class13.Class20.int_8[i]], 3);
		}
		Class25.smethod_51(class20_0.class21_0, class20_0.class21_2);
		Class25.smethod_51(class20_0.class21_1, class20_0.class21_2);
	}

	static void smethod_77(int[] int_0, Class13.Class20.Class21 class21_0)
	{
		class21_0.byte_0 = new byte[class21_0.short_0.Length];
		int num = int_0.Length / 2;
		int num2 = (num + 1) / 2;
		int num3 = 0;
		for (int i = 0; i < class21_0.int_3; i++)
		{
			class21_0.int_2[i] = 0;
		}
		int[] array = new int[num];
		array[num - 1] = 0;
		int[] int_;
		nint num8;
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			if (int_0[2 * num4 + 1] != -1)
			{
				int num5 = array[num4] + 1;
				if (num5 > class21_0.int_3)
				{
					num5 = class21_0.int_3;
					num3++;
				}
				array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
			}
			else
			{
				int num6 = array[num4];
				int[] array2 = (int_ = class21_0.int_2);
				int num7 = num6 - 1;
				num8 = num7;
				array2[num7] = int_[num8] + 1;
				class21_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
			}
		}
		if (num3 == 0)
		{
			return;
		}
		int num9 = class21_0.int_3 - 1;
		while (true)
		{
			if (class21_0.int_2[--num9] != 0)
			{
				do
				{
					int[] array3 = (int_ = class21_0.int_2);
					int num10 = num9;
					num8 = num10;
					array3[num10] = int_[num8] - 1;
					int[] array4 = (int_ = class21_0.int_2);
					int num11 = ++num9;
					num8 = num11;
					array4[num11] = int_[num8] + 1;
					num3 -= 1 << class21_0.int_3 - 1 - num9;
				}
				while (num3 > 0 && num9 < class21_0.int_3 - 1);
				if (num3 <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class21_0.int_2);
		int num12 = class21_0.int_3 - 1;
		num8 = num12;
		array5[num12] = int_[num8] + num3;
		int[] array6 = (int_ = class21_0.int_2);
		int num13 = class21_0.int_3 - 2;
		num8 = num13;
		array6[num13] = int_[num8] - num3;
		int num14 = 2 * num2;
		for (int num15 = class21_0.int_3; num15 != 0; num15--)
		{
			int num16 = class21_0.int_2[num15 - 1];
			while (num16 > 0)
			{
				int num17 = 2 * int_0[num14++];
				if (int_0[num17 + 1] == -1)
				{
					class21_0.byte_0[int_0[num17]] = (byte)num15;
					num16--;
				}
			}
		}
	}

	static void smethod_78(Class12 class12_0)
	{
		class12_0.type_0.GetMethod("Clear")!.Invoke(class12_0.object_0, new object[0]);
	}
}
