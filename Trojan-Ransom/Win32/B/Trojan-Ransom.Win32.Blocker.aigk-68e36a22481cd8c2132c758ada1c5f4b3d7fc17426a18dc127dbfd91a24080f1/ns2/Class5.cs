using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns4;

namespace ns2;

internal class Class5
{
	static bool smethod_0(Class12.Class13 class13_0)
	{
		int num = Class5.smethod_39(class13_0.class15_0);
		while (num >= 258)
		{
			switch (class13_0.int_17)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class5.smethod_70(class13_0.class16_0, class13_0.class14_0)) & -256) == 0)
				{
					Class5.smethod_49(class13_0.class15_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class13_0.int_19 = Class12.Class13.int_13[num2 - 257];
					class13_0.int_18 = Class12.Class13.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class13_0.class16_1 = null;
				class13_0.class16_0 = null;
				class13_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class13_0.int_18 > 0)
				{
					class13_0.int_17 = 8;
					int num4 = Class5.smethod_74(class13_0.class14_0, class13_0.int_18);
					if (num4 < 0)
					{
						return false;
					}
					Class5.smethod_38(class13_0.class14_0, class13_0.int_18);
					class13_0.int_19 += num4;
				}
				class13_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class5.smethod_70(class13_0.class16_1, class13_0.class14_0);
				if (num2 >= 0)
				{
					class13_0.int_20 = Class12.Class13.int_15[num2];
					class13_0.int_18 = Class12.Class13.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class13_0.int_18 > 0)
				{
					class13_0.int_17 = 10;
					int num3 = Class5.smethod_74(class13_0.class14_0, class13_0.int_18);
					if (num3 < 0)
					{
						return false;
					}
					Class5.smethod_38(class13_0.class14_0, class13_0.int_18);
					class13_0.int_20 += num3;
				}
				Class5.smethod_10(class13_0.class15_0, class13_0.int_19, class13_0.int_20);
				num -= class13_0.int_19;
				class13_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_1()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			while (true)
			{
			}
		}
		new decimal(39029145L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			MessageBox.Show("mw@m\u007f1Su}y1jwP‚b\u0090:'6wIOl%WOfry(‘(SZ‘SKAŠ†\u0081^5gY*f$g{t[NtCHggGu€&p2bD‰„.dŒ0C‰}9$_M{a*\u0090FVmq6i\u007fv\u008d4&~[XUŠyp3");
			ProjectData.ClearProjectError();
		}
		Interaction.MsgBox((object)"Db9YJ9sH92H5qKuc", (MsgBoxStyle)0, (object)null);
	}

	static void smethod_2(Class12.Class21 class21_0)
	{
		class21_0.int_10 = (class21_0.byte_0[class21_0.int_14] << 5) ^ class21_0.byte_0[class21_0.int_14 + 1];
	}

	static void smethod_3(int int_0, byte[] byte_0, int int_1, Class12.Class22 class22_0)
	{
		Array.Copy(byte_0, int_1, class22_0.byte_0, class22_0.int_1, int_0);
		class22_0.int_1 += int_0;
	}

	static int smethod_4(byte[] byte_0, Class12.Class18 class18_0)
	{
		int num = 0;
		int num2 = byte_0.Length;
		int num3 = num2;
		while (true)
		{
			int num4 = Class5.smethod_28(class18_0.class22_0, byte_0, num, num2);
			num += num4;
			class18_0.long_0 += num4;
			num2 -= num4;
			if (num2 == 0 || class18_0.int_6 == 30)
			{
				break;
			}
			Class12.Class21 class21_ = class18_0.class21_0;
			bool bool_ = (class18_0.int_6 & 4) != 0;
			if (Class5.smethod_73((class18_0.int_6 & 8) != 0, bool_, class21_))
			{
				continue;
			}
			if (class18_0.int_6 != 16)
			{
				if (class18_0.int_6 == 20)
				{
					for (int num5 = 8 + (-class18_0.class22_0.int_2 & 7); num5 > 0; num5 -= 10)
					{
						Class5.smethod_72(class18_0.class22_0, 2, 10);
					}
					class18_0.int_6 = 16;
				}
				else if (class18_0.int_6 == 28)
				{
					Class5.smethod_26(class18_0.class22_0);
					class18_0.int_6 = 30;
				}
				continue;
			}
			return num3 - num2;
		}
		return num3 - num2;
	}

	static int smethod_5(Class12.Stream0 stream0_0)
	{
		return Class5.smethod_69(stream0_0) | (Class5.smethod_69(stream0_0) << 16);
	}

	static void smethod_6(Class12.Class15 class15_0)
	{
		class15_0.int_2 = 0;
		class15_0.int_3 = 0;
	}

	static void smethod_7(Class12.Class19.Class20 class20_0)
	{
		int[] array = new int[class20_0.int_3];
		int num = 0;
		class20_0.short_1 = new short[class20_0.short_0.Length];
		for (int i = 0; i < class20_0.int_3; i++)
		{
			array[i] = num;
			num += class20_0.int_2[i] << 15 - i;
		}
		for (int j = 0; j < class20_0.int_1; j++)
		{
			int num2 = class20_0.byte_0[j];
			if (num2 > 0)
			{
				class20_0.short_1[j] = Class5.smethod_27(array[num2 - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num3 = num2 - 1;
				nint num4 = num3;
				array3[num3] = array2[num4] + (1 << 16 - num2);
			}
		}
	}

	static void smethod_8(Class10 class10_0)
	{
		class10_0.type_0.GetMethod("Clear")!.Invoke(class10_0.object_0, new object[0]);
	}

	static void smethod_9(Class12.Class21 class21_0)
	{
		if (class21_0.int_14 >= 65274)
		{
			Class5.smethod_13(class21_0);
		}
		while (class21_0.int_15 < 262 && class21_0.int_17 < class21_0.int_18)
		{
			int num = 65536 - class21_0.int_15 - class21_0.int_14;
			if (num > class21_0.int_18 - class21_0.int_17)
			{
				num = class21_0.int_18 - class21_0.int_17;
			}
			Array.Copy(class21_0.byte_1, class21_0.int_17, class21_0.byte_0, class21_0.int_14 + class21_0.int_15, num);
			class21_0.int_17 += num;
			class21_0.int_16 += num;
			class21_0.int_15 += num;
		}
		if (class21_0.int_15 >= 3)
		{
			Class5.smethod_2(class21_0);
		}
	}

	static void smethod_10(Class12.Class15 class15_0, int int_0, int int_1)
	{
		if ((class15_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class15_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class15_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class15_0.byte_0, num, class15_0.byte_0, class15_0.int_2, int_0);
				class15_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class15_0.byte_0[class15_0.int_2++] = class15_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class5.smethod_61(class15_0, num, int_0, int_1);
		}
	}

	static byte[] smethod_11(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class5.smethod_17(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class12.Stream0 stream = new Class12.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class5.smethod_5(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class5.smethod_69(stream);
			int num3 = Class5.smethod_69(stream);
			int num4 = Class5.smethod_69(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class5.smethod_5(stream);
			Class5.smethod_5(stream);
			Class5.smethod_5(stream);
			int num5 = Class5.smethod_5(stream);
			int num6 = Class5.smethod_69(stream);
			int num7 = Class5.smethod_69(stream);
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
			Class12.Class13 class13_ = new Class12.Class13(array2);
			array = new byte[num5];
			Class5.smethod_40(0, array.Length, array, class13_);
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
				int num9 = Class5.smethod_5(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class5.smethod_5(stream);
					num11 = Class5.smethod_5(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class12.Class13 class13_2 = new Class12.Class13(array3);
					Class5.smethod_40(i, num11, array, class13_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 198, 19, 52, 9, 66, 82, 50, 240 };
				byte[] byte_2 = new byte[8] { 186, 168, 125, 61, 161, 254, 155, 252 };
				using Class11 class11_ = new Class11();
				using ICryptoTransform cryptoTransform = Class5.smethod_57(bool_0: true, class11_, byte_2, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class5.smethod_11(byte_3);
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
				using Class10 class10_ = new Class10();
				using ICryptoTransform cryptoTransform2 = Class5.smethod_64(byte_5, byte_4, bool_0: true, class10_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class5.smethod_11(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_12(Class12.Class19 class19_0)
	{
		for (int i = 0; i < class19_0.int_9; i++)
		{
			int num = class19_0.byte_1[i] & 0xFF;
			int num2 = class19_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class5.smethod_46(num, class19_0);
				Class5.smethod_63(class19_0.class20_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class5.smethod_72(class19_0.class22_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class5.smethod_76(class19_0, num2);
				Class5.smethod_63(class19_0.class20_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class5.smethod_72(class19_0.class22_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class5.smethod_63(class19_0.class20_0, num);
			}
		}
		Class5.smethod_63(class19_0.class20_0, 256);
	}

	static void smethod_13(Class12.Class21 class21_0)
	{
		Array.Copy(class21_0.byte_0, 32768, class21_0.byte_0, 0, 32768);
		class21_0.int_11 -= 32768;
		class21_0.int_14 -= 32768;
		class21_0.int_13 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = class21_0.short_0[i] & 0xFFFF;
			class21_0.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = class21_0.short_1[j] & 0xFFFF;
			class21_0.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	static void smethod_14()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		decimal num = new decimal(588629L);
		new decimal(755L);
		num = default(decimal);
		new decimal(62L);
		new decimal(1304L);
		new decimal(3L);
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("M*V?w/VMkKDsO4‚z$ˆIŒ~B%…E]„g|H†P]<dm)wrstZJMvr‰a.ŒN‡9k„*%dŒ9=\u0081dCW‡53b5p?6h8C‹k.fgCXƒŒ’6„JZgX}XU…‰&ˆ‚\\u’‹;/pcS`2MUFe\u008dHtJWpD{'`8Tq3EM„u?)„D_g}");
			num = new decimal(5382L);
			while (true)
			{
				num = new decimal(423L);
				new decimal(54317701L);
				new decimal(150L);
				new decimal(173773408L);
			}
		}
		new decimal(71L);
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			while (true)
			{
			}
		}
		while (true)
		{
		}
	}

	static Class12.Class16 smethod_15(Class12.Class17 class17_0)
	{
		byte[] array = new byte[class17_0.int_10];
		Array.Copy(class17_0.byte_1, class17_0.int_9, array, 0, class17_0.int_10);
		return new Class12.Class16(array);
	}

	static bool smethod_16(Class12.Class21 class21_0, int int_0)
	{
		int num = 128;
		int num2 = 128;
		short[] short_ = class21_0.short_1;
		int int_ = class21_0.int_14;
		int num3 = class21_0.int_14 + class21_0.int_12;
		int num4 = Math.Max(class21_0.int_12, 2);
		int num5 = Math.Max(class21_0.int_14 - 32506, 0);
		int num6 = class21_0.int_14 + 258 - 1;
		byte b = class21_0.byte_0[num3 - 1];
		byte b2 = class21_0.byte_0[num3];
		if (num4 >= 8)
		{
			num >>= 2;
		}
		if (num2 > class21_0.int_15)
		{
			num2 = class21_0.int_15;
		}
		do
		{
			if (class21_0.byte_0[int_0 + num4] != b2 || class21_0.byte_0[int_0 + num4 - 1] != b || class21_0.byte_0[int_0] != class21_0.byte_0[int_] || class21_0.byte_0[int_0 + 1] != class21_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num7 = int_0 + 2;
			int_ += 2;
			while (class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && class21_0.byte_0[++int_] == class21_0.byte_0[++num7] && int_ < num6)
			{
			}
			if (int_ > num3)
			{
				class21_0.int_11 = int_0;
				num3 = int_;
				num4 = int_ - class21_0.int_14;
				if (num4 >= num2)
				{
					break;
				}
				b = class21_0.byte_0[num3 - 1];
				b2 = class21_0.byte_0[num3];
			}
			int_ = class21_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > num5 && --num != 0);
		class21_0.int_12 = Math.Min(num4, class21_0.int_15);
		return class21_0.int_12 >= 3;
	}

	static bool smethod_17(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
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

	static byte[] smethod_18(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class5.smethod_66(byte_2, byte_0, byte_1, 2);
	}

	static int smethod_19(int int_0, Class12.Class15 class15_0, byte[] byte_0, int int_1)
	{
		int num = class15_0.int_2;
		if (int_0 > class15_0.int_3)
		{
			int_0 = class15_0.int_3;
		}
		else
		{
			num = (class15_0.int_2 - class15_0.int_3 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class15_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class15_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class15_0.int_3 -= num2;
		if (class15_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static bool smethod_20(Class12.Class19 class19_0)
	{
		return class19_0.int_9 >= 16384;
	}

	static byte[] smethod_21(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class5.smethod_66(byte_2, byte_0, byte_1, 3);
	}

	static bool smethod_22(Class12.Class13 class13_0)
	{
		switch (class13_0.int_17)
		{
		case 2:
		{
			if (class13_0.bool_0)
			{
				class13_0.int_17 = 12;
				return false;
			}
			int num = Class5.smethod_74(class13_0.class14_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class5.smethod_38(class13_0.class14_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class13_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class5.smethod_67(class13_0.class14_0);
				class13_0.int_17 = 3;
				break;
			case 1:
				class13_0.class16_0 = Class12.Class16.class16_0;
				class13_0.class16_1 = Class12.Class16.class16_1;
				class13_0.int_17 = 7;
				break;
			case 2:
				class13_0.class17_0 = new Class12.Class17();
				class13_0.int_17 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class13_0.int_21 = Class5.smethod_74(class13_0.class14_0, 16)) < 0)
			{
				return false;
			}
			Class5.smethod_38(class13_0.class14_0, 16);
			class13_0.int_17 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class5.smethod_74(class13_0.class14_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class5.smethod_38(class13_0.class14_0, 16);
			class13_0.int_17 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class5.smethod_32(class13_0.class15_0, class13_0.class14_0, class13_0.int_21);
			class13_0.int_21 -= num3;
			if (class13_0.int_21 == 0)
			{
				class13_0.int_17 = 2;
				return true;
			}
			return !class13_0.class14_0.IsNeedingInput;
		}
		case 6:
			if (!Class5.smethod_37(class13_0.class17_0, class13_0.class14_0))
			{
				return false;
			}
			class13_0.class16_0 = Class5.smethod_23(class13_0.class17_0);
			class13_0.class16_1 = Class5.smethod_15(class13_0.class17_0);
			class13_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class5.smethod_0(class13_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static Class12.Class16 smethod_23(Class12.Class17 class17_0)
	{
		byte[] array = new byte[class17_0.int_9];
		Array.Copy(class17_0.byte_1, 0, array, 0, class17_0.int_9);
		return new Class12.Class16(array);
	}

	static void smethod_24(Class12.Class19 class19_0, int int_0)
	{
		Class5.smethod_7(class19_0.class20_2);
		Class5.smethod_7(class19_0.class20_0);
		Class5.smethod_7(class19_0.class20_1);
		Class5.smethod_72(class19_0.class22_0, class19_0.class20_0.int_1 - 257, 5);
		Class5.smethod_72(class19_0.class22_0, class19_0.class20_1.int_1 - 1, 5);
		Class5.smethod_72(class19_0.class22_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class5.smethod_72(class19_0.class22_0, (int)class19_0.class20_2.byte_0[Class12.Class19.int_8[i]], 3);
		}
		Class5.smethod_48(class19_0.class20_0, class19_0.class20_2);
		Class5.smethod_48(class19_0.class20_1, class19_0.class20_2);
	}

	static void smethod_25(Class12.Class18 class18_0)
	{
		class18_0.int_6 |= 12;
	}

	static void smethod_26(Class12.Class22 class22_0)
	{
		if (class22_0.int_2 > 0)
		{
			class22_0.byte_0[class22_0.int_1++] = (byte)class22_0.uint_0;
			if (class22_0.int_2 > 8)
			{
				class22_0.byte_0[class22_0.int_1++] = (byte)(class22_0.uint_0 >> 8);
			}
		}
		class22_0.uint_0 = 0u;
		class22_0.int_2 = 0;
	}

	static short smethod_27(int int_0)
	{
		return (short)((Class12.Class19.byte_0[int_0 & 0xF] << 12) | (Class12.Class19.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class12.Class19.byte_0[(int_0 >> 8) & 0xF] << 4) | Class12.Class19.byte_0[int_0 >> 12]);
	}

	static int smethod_28(Class12.Class22 class22_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class22_0.int_2 >= 8)
		{
			class22_0.byte_0[class22_0.int_1++] = (byte)class22_0.uint_0;
			class22_0.uint_0 >>= 8;
			class22_0.int_2 -= 8;
		}
		if (int_1 > class22_0.int_1 - class22_0.int_0)
		{
			int_1 = class22_0.int_1 - class22_0.int_0;
			Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
			class22_0.int_0 = 0;
			class22_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class22_0.byte_0, class22_0.int_0, byte_0, int_0, int_1);
			class22_0.int_0 += int_1;
		}
		return int_1;
	}

	static int smethod_29(Class12.Class21 class21_0)
	{
		int num = ((class21_0.int_10 << 5) ^ class21_0.byte_0[class21_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class21_0.short_1[class21_0.int_14 & 0x7FFF] = class21_0.short_0[num]);
		class21_0.short_0[num] = (short)class21_0.int_14;
		class21_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_30(int int_0, byte[] byte_0, int int_1, Class12.Class19 class19_0, bool bool_0)
	{
		Class5.smethod_72(class19_0.class22_0, bool_0 ? 1 : 0, 3);
		Class5.smethod_26(class19_0.class22_0);
		Class5.smethod_53(class19_0.class22_0, int_1);
		Class5.smethod_53(class19_0.class22_0, ~int_1);
		Class5.smethod_3(int_1, byte_0, int_0, class19_0.class22_0);
		Class5.smethod_50(class19_0);
	}

	static bool smethod_31(int int_0, int int_1, Class12.Class19 class19_0)
	{
		class19_0.short_0[class19_0.int_9] = (short)int_0;
		class19_0.byte_1[class19_0.int_9++] = (byte)(int_1 - 3);
		int num = Class5.smethod_46(int_1 - 3, class19_0);
		short[] short_;
		short[] array = (short_ = class19_0.class20_0.short_0);
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (num >= 265 && num < 285)
		{
			class19_0.int_10 += (num - 261) / 4;
		}
		int num3 = Class5.smethod_76(class19_0, int_0 - 1);
		short[] array2 = (short_ = class19_0.class20_1.short_0);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (num3 >= 4)
		{
			class19_0.int_10 += num3 / 2 - 1;
		}
		return class19_0.int_9 >= 16384;
	}

	static int smethod_32(Class12.Class15 class15_0, Class12.Class14 class14_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class15_0.int_3), class14_0.AvailableBytes);
		int num = 32768 - class15_0.int_2;
		int num2;
		if (int_0 > num)
		{
			num2 = Class5.smethod_45(class14_0, class15_0.byte_0, class15_0.int_2, num);
			if (num2 == num)
			{
				num2 += Class5.smethod_45(class14_0, class15_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class5.smethod_45(class14_0, class15_0.byte_0, class15_0.int_2, int_0);
		}
		class15_0.int_2 = (class15_0.int_2 + num2) & 0x7FFF;
		class15_0.int_3 += num2;
		return num2;
	}

	static void smethod_33(int int_0, Class12.Stream0 stream0_0)
	{
		Class5.smethod_36(stream0_0, int_0);
		Class5.smethod_36(stream0_0, int_0 >> 16);
	}

	static void smethod_34(short[] short_0, byte[] byte_0, Class12.Class19.Class20 class20_0)
	{
		class20_0.short_1 = short_0;
		class20_0.byte_0 = byte_0;
	}

	static void smethod_35(int int_0, int int_1, byte[] byte_0, Class12.Class14 class14_0)
	{
		if (class14_0.int_0 < class14_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class14_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class14_0.int_2);
				class14_0.int_2 += 8;
			}
			class14_0.byte_0 = byte_0;
			class14_0.int_0 = int_0;
			class14_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_36(Class12.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static bool smethod_37(Class12.Class17 class17_0, Class12.Class14 class14_0)
	{
		while (true)
		{
			switch (class17_0.int_8)
			{
			case 5:
			{
				int int_ = Class12.Class17.int_7[class17_0.int_13];
				int num = Class5.smethod_74(class14_0, int_);
				if (num >= 0)
				{
					Class5.smethod_38(class14_0, int_);
					num += Class12.Class17.int_6[class17_0.int_13];
					while (num-- > 0)
					{
						class17_0.byte_1[class17_0.int_14++] = class17_0.byte_2;
					}
					if (class17_0.int_14 == class17_0.int_12)
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
				while (((num2 = Class5.smethod_70(class17_0.class16_0, class14_0)) & -16) == 0)
				{
					class17_0.byte_1[class17_0.int_14++] = (class17_0.byte_2 = (byte)num2);
					if (class17_0.int_14 == class17_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class17_0.byte_2 = 0;
					}
					class17_0.int_13 = num2 - 16;
					class17_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class17_0.int_14 < class17_0.int_11)
				{
					int num3 = Class5.smethod_74(class14_0, 3);
					if (num3 >= 0)
					{
						Class5.smethod_38(class14_0, 3);
						class17_0.byte_0[Class12.Class17.int_15[class17_0.int_14]] = (byte)num3;
						class17_0.int_14++;
						continue;
					}
					return false;
				}
				class17_0.class16_0 = new Class12.Class16(class17_0.byte_0);
				class17_0.byte_0 = null;
				class17_0.int_14 = 0;
				class17_0.int_8 = 4;
				goto case 4;
			case 2:
				class17_0.int_11 = Class5.smethod_74(class14_0, 4);
				if (class17_0.int_11 >= 0)
				{
					class17_0.int_11 += 4;
					Class5.smethod_38(class14_0, 4);
					class17_0.byte_0 = new byte[19];
					class17_0.int_14 = 0;
					class17_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class17_0.int_10 = Class5.smethod_74(class14_0, 5);
				if (class17_0.int_10 >= 0)
				{
					class17_0.int_10++;
					Class5.smethod_38(class14_0, 5);
					class17_0.int_12 = class17_0.int_9 + class17_0.int_10;
					class17_0.byte_1 = new byte[class17_0.int_12];
					class17_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class17_0.int_9 = Class5.smethod_74(class14_0, 5);
				if (class17_0.int_9 >= 0)
				{
					class17_0.int_9 += 257;
					Class5.smethod_38(class14_0, 5);
					class17_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class17_0.int_8 = 4;
		}
	}

	static void smethod_38(Class12.Class14 class14_0, int int_0)
	{
		class14_0.uint_0 >>= int_0;
		class14_0.int_2 -= int_0;
	}

	static int smethod_39(Class12.Class15 class15_0)
	{
		return 32768 - class15_0.int_3;
	}

	static int smethod_40(int int_0, int int_1, byte[] byte_0, Class12.Class13 class13_0)
	{
		int num = 0;
		do
		{
			if (class13_0.int_17 != 11)
			{
				int num2 = Class5.smethod_19(int_1, class13_0.class15_0, byte_0, int_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class5.smethod_22(class13_0) || (class13_0.class15_0.int_3 > 0 && class13_0.int_17 != 11));
		return num;
	}

	static void smethod_41(Class11 class11_0)
	{
		class11_0.type_0.GetMethod("Clear")!.Invoke(class11_0.object_0, new object[0]);
	}

	static byte[] smethod_42(byte[] byte_0)
	{
		return Class5.smethod_66((byte[])null, (byte[])null, byte_0, 1);
	}

	static void smethod_43(pass pass_0)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			new decimal(-2070746965L);
			ProjectData.ClearProjectError();
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	static int smethod_44(Class12.Class15 class15_0)
	{
		return class15_0.int_3;
	}

	static int smethod_45(Class12.Class14 class14_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class14_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class14_0.uint_0;
			class14_0.uint_0 >>= 8;
			class14_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class14_0.int_1 - class14_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class14_0.byte_0, class14_0.int_0, byte_0, int_0, int_1);
		class14_0.int_0 += int_1;
		if (((uint)(class14_0.int_0 - class14_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class14_0.uint_0 = class14_0.byte_0[class14_0.int_0++] & 0xFFu;
			class14_0.int_2 = 8;
		}
		return num + int_1;
	}

	static int smethod_46(int int_0, Class12.Class19 class19_0)
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

	static bool smethod_47(Class12.Class19 class19_0, int int_0)
	{
		class19_0.short_0[class19_0.int_9] = 0;
		class19_0.byte_1[class19_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class19_0.class20_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return class19_0.int_9 >= 16384;
	}

	static void smethod_48(Class12.Class19.Class20 class20_0, Class12.Class19.Class20 class20_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class20_0.int_1)
		{
			int num3 = 1;
			int num4 = class20_0.byte_0[num2];
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
					Class5.smethod_63(class20_1, num4);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class20_0.int_1 && num == class20_0.byte_0[num2])
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
					Class5.smethod_63(class20_1, num);
				}
			}
			else if (num != 0)
			{
				Class5.smethod_63(class20_1, 16);
				Class5.smethod_72(class20_0.class19_0.class22_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class5.smethod_63(class20_1, 17);
				Class5.smethod_72(class20_0.class19_0.class22_0, num3 - 3, 3);
			}
			else
			{
				Class5.smethod_63(class20_1, 18);
				Class5.smethod_72(class20_0.class19_0.class22_0, num3 - 11, 7);
			}
		}
	}

	static void smethod_49(Class12.Class15 class15_0, int int_0)
	{
		if (class15_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class15_0.byte_0[class15_0.int_2++] = (byte)int_0;
		class15_0.int_2 &= 32767;
	}

	static void smethod_50(Class12.Class19 class19_0)
	{
		class19_0.int_9 = 0;
		class19_0.int_10 = 0;
	}

	static int smethod_51(Class12.Class19.Class20 class20_0)
	{
		int num = 0;
		for (int i = 0; i < class20_0.short_0.Length; i++)
		{
			num += class20_0.short_0[i] * class20_0.byte_0[i];
		}
		return num;
	}

	static void smethod_52(Class12.Class21 class21_0, byte[] byte_0)
	{
		class21_0.byte_1 = byte_0;
		class21_0.int_17 = 0;
		class21_0.int_18 = byte_0.Length;
	}

	static void smethod_53(Class12.Class22 class22_0, int int_0)
	{
		class22_0.byte_0[class22_0.int_1++] = (byte)int_0;
		class22_0.byte_0[class22_0.int_1++] = (byte)(int_0 >> 8);
	}

	static bool smethod_54(bool bool_0, bool bool_1, Class12.Class21 class21_0)
	{
		if (class21_0.int_15 < 262 && !bool_1)
		{
			return false;
		}
		Class12.Class19 class19_2;
		byte[] byte_;
		int int_4;
		do
		{
			if (class21_0.int_15 >= 262 || bool_1)
			{
				if (class21_0.int_15 != 0)
				{
					if (class21_0.int_14 >= 65274)
					{
						Class5.smethod_13(class21_0);
					}
					int int_ = class21_0.int_11;
					int int_2 = class21_0.int_12;
					if (class21_0.int_15 >= 3)
					{
						int num = Class5.smethod_29(class21_0);
						if (num != 0 && class21_0.int_14 - num <= 32506 && Class5.smethod_16(class21_0, num) && class21_0.int_12 <= 5 && class21_0.int_12 == 3 && class21_0.int_14 - class21_0.int_11 > 4096)
						{
							class21_0.int_12 = 2;
						}
					}
					if (int_2 >= 3 && class21_0.int_12 <= int_2)
					{
						Class12.Class19 class19_ = class21_0.class19_0;
						int int_3 = class21_0.int_14 - 1 - int_;
						Class5.smethod_31(int_3, int_2, class19_);
						int_2 -= 2;
						do
						{
							class21_0.int_14++;
							class21_0.int_15--;
							if (class21_0.int_15 >= 3)
							{
								Class5.smethod_29(class21_0);
							}
						}
						while (--int_2 > 0);
						class21_0.int_14++;
						class21_0.int_15--;
						class21_0.bool_0 = false;
						class21_0.int_12 = 2;
					}
					else
					{
						if (class21_0.bool_0)
						{
							Class5.smethod_47(class21_0.class19_0, class21_0.byte_0[class21_0.int_14 - 1] & 0xFF);
						}
						class21_0.bool_0 = true;
						class21_0.int_14++;
						class21_0.int_15--;
					}
					continue;
				}
				if (class21_0.bool_0)
				{
					Class5.smethod_47(class21_0.class19_0, class21_0.byte_0[class21_0.int_14 - 1] & 0xFF);
				}
				class21_0.bool_0 = false;
				class19_2 = class21_0.class19_0;
				byte_ = class21_0.byte_0;
				int_4 = class21_0.int_13;
				int int_5 = class21_0.int_14 - class21_0.int_13;
				Class5.smethod_65(byte_, int_4, int_5, class19_2, bool_0);
				class21_0.int_13 = class21_0.int_14;
				return false;
			}
			return true;
		}
		while (class21_0.class19_0.int_9 < 16384);
		int num2 = class21_0.int_14 - class21_0.int_13;
		if (class21_0.bool_0)
		{
			num2--;
		}
		bool flag = bool_0 && class21_0.int_15 == 0 && !class21_0.bool_0;
		class19_2 = class21_0.class19_0;
		byte_ = class21_0.byte_0;
		int_4 = class21_0.int_13;
		Class5.smethod_65(byte_, int_4, num2, class19_2, flag);
		class21_0.int_13 += num2;
		return !flag;
	}

	static void smethod_55(Class12.Class19.Class20 class20_0)
	{
		int num = class20_0.short_0.Length;
		int[] array = new int[num];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class20_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class20_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
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
		class20_0.int_1 = Math.Max(num3 + 1, class20_0.int_0);
		int num8 = num2;
		int[] array2 = new int[4 * num2 - 2];
		int[] array3 = new int[2 * num2 - 1];
		int num9 = num8;
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class20_0.short_0[num10] << 8;
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
		Class5.smethod_58(array2, class20_0);
	}

	static void smethod_56(byte[] byte_0, Class12.Class15 class15_0, int int_0, int int_1)
	{
		if (class15_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class15_0.byte_0, 0, int_0);
		class15_0.int_2 = int_0 & 0x7FFF;
	}

	static ICryptoTransform smethod_57(bool bool_0, Class11 class11_0, byte[] byte_0, byte[] byte_1)
	{
		class11_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_1 });
		class11_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class11_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class11_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class11_0.object_0, new object[0]);
	}

	static void smethod_58(int[] int_0, Class12.Class19.Class20 class20_0)
	{
		class20_0.byte_0 = new byte[class20_0.short_0.Length];
		int num = int_0.Length / 2;
		int num2 = (num + 1) / 2;
		int num3 = 0;
		for (int i = 0; i < class20_0.int_3; i++)
		{
			class20_0.int_2[i] = 0;
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
				if (num5 > class20_0.int_3)
				{
					num5 = class20_0.int_3;
					num3++;
				}
				array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
			}
			else
			{
				int num6 = array[num4];
				int[] array2 = (int_ = class20_0.int_2);
				int num7 = num6 - 1;
				num8 = num7;
				array2[num7] = int_[num8] + 1;
				class20_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
			}
		}
		if (num3 == 0)
		{
			return;
		}
		int num9 = class20_0.int_3 - 1;
		while (true)
		{
			if (class20_0.int_2[--num9] != 0)
			{
				do
				{
					int[] array3 = (int_ = class20_0.int_2);
					int num10 = num9;
					num8 = num10;
					array3[num10] = int_[num8] - 1;
					int[] array4 = (int_ = class20_0.int_2);
					int num11 = ++num9;
					num8 = num11;
					array4[num11] = int_[num8] + 1;
					num3 -= 1 << class20_0.int_3 - 1 - num9;
				}
				while (num3 > 0 && num9 < class20_0.int_3 - 1);
				if (num3 <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class20_0.int_2);
		int num12 = class20_0.int_3 - 1;
		num8 = num12;
		array5[num12] = int_[num8] + num3;
		int[] array6 = (int_ = class20_0.int_2);
		int num13 = class20_0.int_3 - 2;
		num8 = num13;
		array6[num13] = int_[num8] - num3;
		int num14 = 2 * num2;
		for (int num15 = class20_0.int_3; num15 != 0; num15--)
		{
			int num16 = class20_0.int_2[num15 - 1];
			while (num16 > 0)
			{
				int num17 = 2 * int_0[num14++];
				if (int_0[num17 + 1] == -1)
				{
					class20_0.byte_0[int_0[num17]] = (byte)num15;
					num16--;
				}
			}
		}
	}

	static void smethod_59(Class12.Class16 class16_0, byte[] byte_0)
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
		class16_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class16_0.short_0[Class5.smethod_27(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class5.smethod_27(num3);
			if (num11 <= 9)
			{
				do
				{
					class16_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class16_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class16_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static void smethod_60(pass pass_0)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		for (double num = 0.7090379; !(num > 0.04535276); num += 1.0)
		{
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		new decimal(-1417723252L);
		while (true)
		{
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				new decimal(1966943494L);
				ProjectData.ClearProjectError();
			}
		}
	}

	static void smethod_61(Class12.Class15 class15_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class15_0.byte_0[class15_0.int_2++] = class15_0.byte_0[int_0++];
			class15_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static bool smethod_62(Class12.Class21 class21_0)
	{
		return class21_0.int_18 == class21_0.int_17;
	}

	static void smethod_63(Class12.Class19.Class20 class20_0, int int_0)
	{
		Class5.smethod_72(class20_0.class19_0.class22_0, class20_0.short_1[int_0] & 0xFFFF, (int)class20_0.byte_0[int_0]);
	}

	static ICryptoTransform smethod_64(byte[] byte_0, byte[] byte_1, bool bool_0, Class10 class10_0)
	{
		class10_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class10_0.object_0, new object[1] { byte_1 });
		class10_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class10_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class10_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class10_0.object_0, new object[0]);
	}

	static void smethod_65(byte[] byte_0, int int_0, int int_1, Class12.Class19 class19_0, bool bool_0)
	{
		short[] short_;
		(short_ = class19_0.class20_0.short_0)[256] = (short)(short_[256] + 1);
		Class5.smethod_55(class19_0.class20_0);
		Class5.smethod_55(class19_0.class20_1);
		Class5.smethod_71(class19_0.class20_0, class19_0.class20_2);
		Class5.smethod_71(class19_0.class20_1, class19_0.class20_2);
		Class5.smethod_55(class19_0.class20_2);
		int num = 4;
		for (int num2 = 18; num2 > num; num2--)
		{
			if (class19_0.class20_2.byte_0[Class12.Class19.int_8[num2]] > 0)
			{
				num = num2 + 1;
			}
		}
		int num3 = 14 + num * 3 + Class5.smethod_51(class19_0.class20_2) + Class5.smethod_51(class19_0.class20_0) + Class5.smethod_51(class19_0.class20_1) + class19_0.int_10;
		int num4 = class19_0.int_10;
		for (int i = 0; i < 286; i++)
		{
			num4 += class19_0.class20_0.short_0[i] * Class12.Class19.byte_2[i];
		}
		for (int j = 0; j < 30; j++)
		{
			num4 += class19_0.class20_1.short_0[j] * Class12.Class19.byte_3[j];
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (int_0 >= 0 && int_1 + 4 < num3 >> 3)
		{
			Class5.smethod_30(int_0, byte_0, int_1, class19_0, bool_0);
		}
		else if (num3 == num4)
		{
			Class5.smethod_72(class19_0.class22_0, 2 + (bool_0 ? 1 : 0), 3);
			Class12.Class19.Class20 class20_ = class19_0.class20_0;
			short[] short_2 = Class12.Class19.short_1;
			byte[] byte_ = Class12.Class19.byte_2;
			Class5.smethod_34(short_2, byte_, class20_);
			class20_ = class19_0.class20_1;
			short_2 = Class12.Class19.short_2;
			byte_ = Class12.Class19.byte_3;
			Class5.smethod_34(short_2, byte_, class20_);
			Class5.smethod_12(class19_0);
			Class5.smethod_50(class19_0);
		}
		else
		{
			Class5.smethod_72(class19_0.class22_0, 4 + (bool_0 ? 1 : 0), 3);
			Class5.smethod_24(class19_0, num);
			Class5.smethod_12(class19_0);
			Class5.smethod_50(class19_0);
		}
	}

	static byte[] smethod_66(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		try
		{
			Class12.Stream0 stream = new Class12.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class12.Class18 class2 = new Class12.Class18();
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
				int num7 = byte_2.Length;
				while (--num7 >= 0)
				{
					num5 = array8[(num5 ^ byte_2[num6++]) & 0xFF] ^ (num5 >> 8);
				}
				num5 ^= num4;
				Class5.smethod_33(67324752, stream);
				Class5.smethod_36(stream, 20);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 8);
				Class5.smethod_33((int)num3, stream);
				Class5.smethod_33((int)num5, stream);
				long position3 = stream.Position;
				Class5.smethod_33(0, stream);
				Class5.smethod_33(byte_2.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class5.smethod_36(stream, bytes.Length);
				Class5.smethod_36(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class5.smethod_68(class2, byte_2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					int num8 = Class5.smethod_4(array9, class2);
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
					int num9 = Class5.smethod_4(array10, class2);
					if (num9 <= 0)
					{
						break;
					}
					stream.Write(array10, 0, num9);
				}
				long long_ = class2.long_0;
				Class5.smethod_33(33639248, stream);
				Class5.smethod_36(stream, 20);
				Class5.smethod_36(stream, 20);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 8);
				Class5.smethod_33((int)num3, stream);
				Class5.smethod_33((int)num5, stream);
				Class5.smethod_33((int)long_, stream);
				Class5.smethod_33(byte_2.Length, stream);
				Class5.smethod_36(stream, bytes.Length);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 0);
				Class5.smethod_33(0, stream);
				Class5.smethod_33(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class5.smethod_33(101010256, stream);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 0);
				Class5.smethod_36(stream, 1);
				Class5.smethod_36(stream, 1);
				Class5.smethod_33(46 + bytes.Length, stream);
				Class5.smethod_33((int)(30 + bytes.Length + long_), stream);
				Class5.smethod_36(stream, 0);
				stream.Seek(position3, SeekOrigin.Begin);
				Class5.smethod_33((int)long_, stream);
				break;
			}
			case 1:
			{
				Class5.smethod_33(25000571, stream);
				Class5.smethod_33(byte_2.Length, stream);
				byte[] array5;
				for (int i = 0; i < byte_2.Length; i += array5.Length)
				{
					array5 = new byte[Math.Min(2097151, byte_2.Length - i)];
					Buffer.BlockCopy(byte_2, i, array5, 0, array5.Length);
					long position = stream.Position;
					Class5.smethod_33(0, stream);
					Class5.smethod_33(array5.Length, stream);
					Class12.Class18 @class = new Class12.Class18();
					Class5.smethod_68(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						int num = Class5.smethod_4(array6, @class);
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
						int num2 = Class5.smethod_4(array7, @class);
						if (num2 <= 0)
						{
							break;
						}
						stream.Write(array7, 0, num2);
					}
					long position2 = stream.Position;
					stream.Position = position;
					Class5.smethod_33((int)@class.long_0, stream);
					stream.Position = position2;
				}
				break;
			}
			case 2:
			{
				Class5.smethod_33(41777787, stream);
				byte[] array3 = Class5.smethod_66((byte[])null, (byte[])null, byte_2, 1);
				using (Class11 class11_ = new Class11())
				{
					using ICryptoTransform cryptoTransform2 = Class5.smethod_57(bool_0: false, class11_, byte_0, byte_1);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class5.smethod_33(58555003, stream);
				byte[] array = Class5.smethod_66((byte[])null, (byte[])null, byte_2, 1);
				using (Class10 class10_ = new Class10())
				{
					using ICryptoTransform cryptoTransform = Class5.smethod_64(byte_0, byte_1, bool_0: false, class10_);
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
			Class12.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static void smethod_67(Class12.Class14 class14_0)
	{
		class14_0.uint_0 >>= class14_0.int_2 & 7;
		class14_0.int_2 &= -8;
	}

	static void smethod_68(Class12.Class18 class18_0, byte[] byte_0)
	{
		Class5.smethod_52(class18_0.class21_0, byte_0);
	}

	static int smethod_69(Class12.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static int smethod_70(Class12.Class16 class16_0, Class12.Class14 class14_0)
	{
		int num;
		int num2;
		if ((num = Class5.smethod_74(class14_0, 9)) >= 0)
		{
			if ((num2 = class16_0.short_0[num]) >= 0)
			{
				Class5.smethod_38(class14_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class5.smethod_74(class14_0, int_)) >= 0)
			{
				num2 = class16_0.short_0[num3 | (num >> 9)];
				Class5.smethod_38(class14_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class14_0.int_2;
			num = Class5.smethod_74(class14_0, int_2);
			num2 = class16_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class5.smethod_38(class14_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class14_0.int_2;
		num = Class5.smethod_74(class14_0, int_3);
		num2 = class16_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class5.smethod_38(class14_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_71(Class12.Class19.Class20 class20_0, Class12.Class19.Class20 class20_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class20_0.int_1)
		{
			int num3 = 1;
			int num4 = class20_0.byte_0[num2];
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
					short[] array = (short_ = class20_1.short_0);
					nint num7 = num4;
					array[num4] = (short)(short_[num7] + 1);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class20_0.int_1 && num == class20_0.byte_0[num2])
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
				short[] array2 = (short_ = class20_1.short_0);
				int num8 = num;
				nint num7 = num8;
				array2[num8] = (short)(short_[num7] + (short)num3);
			}
			else if (num != 0)
			{
				short[] short_;
				(short_ = class20_1.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num3 <= 10)
			{
				short[] short_;
				(short_ = class20_1.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class20_1.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static void smethod_72(Class12.Class22 class22_0, int int_0, int int_1)
	{
		class22_0.uint_0 |= (uint)(int_0 << class22_0.int_2);
		class22_0.int_2 += int_1;
		if (class22_0.int_2 >= 16)
		{
			class22_0.byte_0[class22_0.int_1++] = (byte)class22_0.uint_0;
			class22_0.byte_0[class22_0.int_1++] = (byte)(class22_0.uint_0 >> 8);
			class22_0.uint_0 >>= 16;
			class22_0.int_2 -= 16;
		}
	}

	static bool smethod_73(bool bool_0, bool bool_1, Class12.Class21 class21_0)
	{
		bool flag;
		do
		{
			Class5.smethod_9(class21_0);
			bool bool_2 = bool_1 && class21_0.int_17 == class21_0.int_18;
			flag = Class5.smethod_54(bool_0, bool_2, class21_0);
		}
		while (class21_0.class22_0.int_1 == 0 && flag);
		return flag;
	}

	static int smethod_74(Class12.Class14 class14_0, int int_0)
	{
		if (class14_0.int_2 < int_0)
		{
			if (class14_0.int_0 == class14_0.int_1)
			{
				return -1;
			}
			class14_0.uint_0 |= (uint)(((class14_0.byte_0[class14_0.int_0++] & 0xFF) | ((class14_0.byte_0[class14_0.int_0++] & 0xFF) << 8)) << class14_0.int_2);
			class14_0.int_2 += 16;
		}
		return (int)(class14_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_75(Class12.Class14 class14_0)
	{
		class14_0.int_2 = 0;
		class14_0.int_1 = 0;
		class14_0.int_0 = 0;
		class14_0.uint_0 = 0u;
	}

	static int smethod_76(Class12.Class19 class19_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}
}
