using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ns0;
using ns1;
using ns14;
using ns16;
using ns2;
using ns3;
using ns6;

internal class Class33
{
	static byte[] smethod_0(string string_0)
	{
		FileStream fileStream = null;
		byte[] array = null;
		try
		{
			fileStream = File.OpenRead(string_0);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Flush();
			return array;
		}
		finally
		{
			fileStream?.Close();
			fileStream = null;
		}
	}

	static void smethod_1(Class24 class24_0)
	{
		class24_0.type_0.GetMethod("Clear")!.Invoke(class24_0.object_0, new object[0]);
	}

	static void smethod_2(Class10 class10_0)
	{
		class10_0.int_2 = 0;
		class10_0.int_1 = 0;
		class10_0.int_0 = 0;
	}

	static Class26.Class30 smethod_3(Class26.Class31 class31_0)
	{
		byte[] array = new byte[class31_0.int_3];
		Array.Copy(class31_0.byte_1, 0, array, 0, class31_0.int_3);
		return new Class26.Class30(array);
	}

	static bool smethod_4(Class26.Class27 class27_0)
	{
		int num = Class33.smethod_68(class27_0.class29_0);
		while (num >= 258)
		{
			switch (class27_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class33.smethod_48(class27_0.class30_0, class27_0.class28_0)) & -256) == 0)
				{
					Class33.smethod_30(class27_0.class29_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class27_0.int_6 = Class26.Class27.int_0[num2 - 257];
					class27_0.int_5 = Class26.Class27.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class27_0.class30_1 = null;
				class27_0.class30_0 = null;
				class27_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class27_0.int_5 > 0)
				{
					class27_0.int_4 = 8;
					int num4 = Class33.smethod_67(class27_0.class28_0, class27_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class33.smethod_99(class27_0.class28_0, class27_0.int_5);
					class27_0.int_6 += num4;
				}
				class27_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class33.smethod_48(class27_0.class30_1, class27_0.class28_0);
				if (num2 >= 0)
				{
					class27_0.int_7 = Class26.Class27.int_2[num2];
					class27_0.int_5 = Class26.Class27.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class27_0.int_5 > 0)
				{
					class27_0.int_4 = 10;
					int num3 = Class33.smethod_67(class27_0.class28_0, class27_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class33.smethod_99(class27_0.class28_0, class27_0.int_5);
					class27_0.int_7 += num3;
				}
				Class33.smethod_15(class27_0.class29_0, class27_0.int_6, class27_0.int_7);
				num -= class27_0.int_6;
				class27_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_5(Class3 class3_0, int int_0)
	{
		if (class3_0.int_3++ == Class3.int_0)
		{
			throw new InvalidOperationException("Window full");
		}
		class3_0.byte_0[class3_0.int_2++] = (byte)int_0;
		class3_0.int_2 &= Class3.int_1;
	}

	static int smethod_6(Class3 class3_0)
	{
		return class3_0.int_3;
	}

	static void smethod_7(Class3 class3_0, int int_0, int int_1)
	{
		if ((class3_0.int_3 += int_0) > Class3.int_0)
		{
			throw new InvalidOperationException("Window full");
		}
		int num = (class3_0.int_2 - int_1) & Class3.int_1;
		int num2 = Class3.int_0 - int_0;
		if (num <= num2 && class3_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class3_0.byte_0, num, class3_0.byte_0, class3_0.int_2, int_0);
				class3_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class3_0.byte_0[class3_0.int_2++] = class3_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class33.smethod_24(class3_0, num, int_0, int_1);
		}
	}

	static void smethod_8(Class8 class8_0)
	{
		class8_0.int_9 = 0;
		class8_0.int_10 = 0;
		Class33.smethod_81(class8_0.class9_0);
		Class33.smethod_81(class8_0.class9_1);
		Class33.smethod_81(class8_0.class9_2);
	}

	static void smethod_9(Class8.Class9 class9_0, Class8.Class9 class9_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class9_0.int_2)
		{
			int num3 = 1;
			int num4 = class9_0.byte_0[num2];
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
					Class33.smethod_73(class9_1, num4);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class9_0.int_2 && num == class9_0.byte_0[num2])
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
					Class33.smethod_73(class9_1, num);
				}
			}
			else if (num != 0)
			{
				Class33.smethod_73(class9_1, Class8.int_4);
				Class33.smethod_44((Class10)class9_0.class8_0.class11_0, num3 - 3, 2);
			}
			else if (num3 <= 10)
			{
				Class33.smethod_73(class9_1, Class8.int_5);
				Class33.smethod_44((Class10)class9_0.class8_0.class11_0, num3 - 3, 3);
			}
			else
			{
				Class33.smethod_73(class9_1, Class8.int_6);
				Class33.smethod_44((Class10)class9_0.class8_0.class11_0, num3 - 11, 7);
			}
		}
	}

	static void smethod_10(Class25 class25_0)
	{
		class25_0.type_0.GetMethod("Clear")!.Invoke(class25_0.object_0, new object[0]);
	}

	static void smethod_11(int int_0, Class7 class7_0)
	{
		class7_0.int_15 = Class6.int_1[int_0];
		class7_0.int_13 = Class6.int_2[int_0];
		class7_0.int_14 = Class6.int_3[int_0];
		class7_0.int_12 = Class6.int_4[int_0];
		if (Class6.int_5[int_0] == class7_0.int_16)
		{
			return;
		}
		switch (class7_0.int_16)
		{
		case 0:
			if (class7_0.int_10 > class7_0.int_9)
			{
				Class8 class8_3 = class7_0.class8_0;
				byte[] byte_2 = class7_0.byte_0;
				int int_4 = class7_0.int_9;
				int int_5 = class7_0.int_10 - class7_0.int_9;
				Class33.smethod_38(byte_2, int_5, class8_3, bool_0: false, int_4);
				class7_0.int_9 = class7_0.int_10;
			}
			Class33.smethod_70(class7_0);
			break;
		case 1:
			if (class7_0.int_10 > class7_0.int_9)
			{
				Class8 class8_2 = class7_0.class8_0;
				byte[] byte_ = class7_0.byte_0;
				int int_2 = class7_0.int_9;
				int int_3 = class7_0.int_10 - class7_0.int_9;
				Class33.smethod_114(int_2, byte_, class8_2, bool_0: false, int_3);
				class7_0.int_9 = class7_0.int_10;
			}
			break;
		case 2:
			if (class7_0.bool_0)
			{
				Class8 class8_ = class7_0.class8_0;
				int int_ = class7_0.byte_0[class7_0.int_10 - 1] & 0xFF;
				Class33.smethod_89(int_, class8_);
			}
			if (class7_0.int_10 > class7_0.int_9)
			{
				Class8 class8_2 = class7_0.class8_0;
				byte[] byte_ = class7_0.byte_0;
				int int_2 = class7_0.int_9;
				int int_3 = class7_0.int_10 - class7_0.int_9;
				Class33.smethod_114(int_2, byte_, class8_2, bool_0: false, int_3);
				class7_0.int_9 = class7_0.int_10;
			}
			class7_0.bool_0 = false;
			class7_0.int_8 = 2;
			break;
		}
		class7_0.int_16 = Class6.int_5[int_0];
	}

	static void smethod_12(short[] short_0, Class8.Class9 class9_0, byte[] byte_0)
	{
		class9_0.short_1 = short_0;
		class9_0.byte_0 = byte_0;
	}

	static void smethod_13(string string_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show((IWin32Window)null, string_0, "Error");
	}

	static void smethod_14(byte[] byte_0, int int_0, Class10 class10_0, int int_1)
	{
		Array.Copy(byte_0, int_1, class10_0.byte_0, class10_0.int_1, int_0);
		class10_0.int_1 += int_0;
	}

	static void smethod_15(Class26.Class29 class29_0, int int_0, int int_1)
	{
		if ((class29_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class29_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class29_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class29_0.byte_0, num, class29_0.byte_0, class29_0.int_0, int_0);
				class29_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class29_0.byte_0[class29_0.int_0++] = class29_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class33.smethod_31(class29_0, num, int_0, int_1);
		}
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static bool smethod_16(Class8 class8_0)
	{
		return class8_0.int_9 + 16 >= Class8.int_0;
	}

	static Class26.Class30 smethod_17(Class26.Class31 class31_0)
	{
		byte[] array = new byte[class31_0.int_4];
		Array.Copy(class31_0.byte_1, class31_0.int_3, array, 0, class31_0.int_4);
		return new Class26.Class30(array);
	}

	static bool smethod_18(Class26.Class28 class28_0)
	{
		return class28_0.int_0 == class28_0.int_1;
	}

	static short smethod_19(int int_0)
	{
		return (short)((Class8.byte_0[int_0 & 0xF] << 12) | (Class8.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class8.byte_0[(int_0 >> 8) & 0xF] << 4) | Class8.byte_0[int_0 >> 12]);
	}

	static void smethod_20(Class8.Class9 class9_0, int[] int_0)
	{
		class9_0.byte_0 = new byte[checked((uint)class9_0.short_0.Length)];
		int num = int_0.Length / 2;
		int num2 = (num + 1) / 2;
		int num3 = 0;
		for (int i = 0; i < class9_0.int_3; i++)
		{
			class9_0.int_0[i] = 0;
		}
		int[] array = new int[checked((uint)num)];
		array[num - 1] = 0;
		int[] int_;
		nint num8;
		for (int num4 = num - 1; num4 >= 0; num4--)
		{
			if (int_0[2 * num4 + 1] != -1)
			{
				int num5 = array[num4] + 1;
				if (num5 > class9_0.int_3)
				{
					num5 = class9_0.int_3;
					num3++;
				}
				array[int_0[2 * num4]] = (array[int_0[2 * num4 + 1]] = num5);
			}
			else
			{
				int num6 = array[num4];
				int[] array2 = (int_ = class9_0.int_0);
				int num7 = num6 - 1;
				num8 = num7;
				array2[num7] = int_[num8] + 1;
				class9_0.byte_0[int_0[2 * num4]] = (byte)array[num4];
			}
		}
		if (num3 == 0)
		{
			return;
		}
		int num9 = class9_0.int_3 - 1;
		while (true)
		{
			if (class9_0.int_0[--num9] != 0)
			{
				do
				{
					int[] array3 = (int_ = class9_0.int_0);
					int num10 = num9;
					num8 = num10;
					array3[num10] = int_[num8] - 1;
					int[] array4 = (int_ = class9_0.int_0);
					int num11 = ++num9;
					num8 = num11;
					array4[num11] = int_[num8] + 1;
					num3 -= 1 << class9_0.int_3 - 1 - num9;
				}
				while (num3 > 0 && num9 < class9_0.int_3 - 1);
				if (num3 <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class9_0.int_0);
		int num12 = class9_0.int_3 - 1;
		num8 = num12;
		array5[num12] = int_[num8] + num3;
		int[] array6 = (int_ = class9_0.int_0);
		int num13 = class9_0.int_3 - 2;
		num8 = num13;
		array6[num13] = int_[num8] - num3;
		int num14 = 2 * num2;
		for (int num15 = class9_0.int_3; num15 != 0; num15--)
		{
			int num16 = class9_0.int_0[num15 - 1];
			while (num16 > 0)
			{
				int num17 = 2 * int_0[num14++];
				if (int_0[num17 + 1] == -1)
				{
					class9_0.byte_0[int_0[num17]] = (byte)num15;
					num16--;
				}
			}
		}
	}

	static bool smethod_21(Class13 class13_0, Class4 class4_0)
	{
		while (true)
		{
			switch (class13_0.int_2)
			{
			case 0:
				class13_0.int_3 = Class33.smethod_102(class4_0, 5);
				if (class13_0.int_3 >= 0)
				{
					class13_0.int_3 += 257;
					Class33.smethod_57(class4_0, 5);
					class13_0.int_2 = 1;
					goto case 1;
				}
				return false;
			case 1:
				class13_0.int_4 = Class33.smethod_102(class4_0, 5);
				if (class13_0.int_4 >= 0)
				{
					class13_0.int_4++;
					Class33.smethod_57(class4_0, 5);
					class13_0.int_6 = class13_0.int_3 + class13_0.int_4;
					class13_0.byte_1 = new byte[checked((uint)class13_0.int_6)];
					class13_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 2:
				class13_0.int_5 = Class33.smethod_102(class4_0, 4);
				if (class13_0.int_5 >= 0)
				{
					class13_0.int_5 += 4;
					Class33.smethod_57(class4_0, 4);
					class13_0.byte_0 = new byte[19];
					class13_0.int_8 = 0;
					class13_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 3:
				while (class13_0.int_8 < class13_0.int_5)
				{
					int num = Class33.smethod_102(class4_0, 3);
					if (num >= 0)
					{
						Class33.smethod_57(class4_0, 3);
						class13_0.byte_0[Class13.int_9[class13_0.int_8]] = (byte)num;
						class13_0.int_8++;
						continue;
					}
					return false;
				}
				class13_0.class14_0 = new Class14(class13_0.byte_0);
				class13_0.byte_0 = null;
				class13_0.int_8 = 0;
				class13_0.int_2 = 4;
				goto case 4;
			case 4:
			{
				int num2;
				while (((num2 = Class33.smethod_56(class13_0.class14_0, class4_0)) & -16) == 0)
				{
					class13_0.byte_1[class13_0.int_8++] = (class13_0.byte_2 = (byte)num2);
					if (class13_0.int_8 == class13_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class13_0.byte_2 = 0;
					}
					else if (class13_0.int_8 == 0)
					{
						throw new Exception();
					}
					class13_0.int_7 = num2 - 16;
					class13_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 5:
			{
				int int_ = Class13.int_1[class13_0.int_7];
				int num3 = Class33.smethod_102(class4_0, int_);
				if (num3 >= 0)
				{
					Class33.smethod_57(class4_0, int_);
					num3 += Class13.int_0[class13_0.int_7];
					if (class13_0.int_8 + num3 <= class13_0.int_6)
					{
						while (num3-- > 0)
						{
							class13_0.byte_1[class13_0.int_8++] = class13_0.byte_2;
						}
						if (class13_0.int_8 == class13_0.int_6)
						{
							return true;
						}
						goto IL_0278;
					}
					throw new Exception();
				}
				return false;
			}
			}
			continue;
			IL_0278:
			class13_0.int_2 = 4;
		}
	}

	static int smethod_22(Class26.Class28 class28_0)
	{
		return class28_0.int_2;
	}

	static int smethod_23(Class26.Class29 class29_0, Class26.Class28 class28_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class29_0.int_1), Class33.smethod_64(class28_0));
		int num = 32768 - class29_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class33.smethod_27(class28_0, class29_0.byte_0, class29_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class33.smethod_27(class28_0, class29_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class33.smethod_27(class28_0, class29_0.byte_0, class29_0.int_0, int_0);
		}
		class29_0.int_0 = (class29_0.int_0 + num2) & 0x7FFF;
		class29_0.int_1 += num2;
		return num2;
	}

	static void smethod_24(Class3 class3_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class3_0.byte_0[class3_0.int_2++] = class3_0.byte_0[int_0++];
			class3_0.int_2 &= Class3.int_1;
			int_0 &= Class3.int_1;
		}
	}

	static Class14 smethod_25(Class13 class13_0)
	{
		byte[] array = new byte[checked((uint)class13_0.int_3)];
		Array.Copy(class13_0.byte_1, 0, array, 0, class13_0.int_3);
		return new Class14(array);
	}

	static int smethod_26(Class3 class3_0)
	{
		return Class3.int_0 - class3_0.int_3;
	}

	static int smethod_27(Class26.Class28 class28_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class28_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class28_0.uint_0;
			class28_0.uint_0 >>= 8;
			class28_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class28_0.int_1 - class28_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class28_0.byte_0, class28_0.int_0, byte_0, int_0, int_1);
		class28_0.int_0 += int_1;
		if (((uint)(class28_0.int_0 - class28_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class28_0.uint_0 = class28_0.byte_0[class28_0.int_0++] & 0xFFu;
			class28_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_28(Class4 class4_0)
	{
		class4_0.uint_0 >>= class4_0.int_2 & 7;
		class4_0.int_2 &= -8;
	}

	static byte[] smethod_29(StringDictionary stringDictionary_0)
	{
		string text = null;
		byte[] array = null;
		string text2 = stringDictionary_0[Class0.string_1];
		string text3 = stringDictionary_0[Class0.string_0];
		bool flag = text2?.ToLower().Equals("neutral") ?? true;
		AppDomain currentDomain = AppDomain.CurrentDomain;
		StringCollection stringCollection = new StringCollection();
		text = currentDomain.SetupInformation.ApplicationBase;
		if (!flag)
		{
			text = Path.Combine(text, text2);
		}
		stringCollection.Add(text);
		stringCollection.Add(Path.Combine(text, text3));
		array = Class33.smethod_71(stringCollection, text3);
		if (array != null)
		{
			return array;
		}
		stringCollection = new StringCollection();
		text = currentDomain.SetupInformation.get_PrivateBinPath();
		if (text != null && text.Trim().Length > 0)
		{
			string[] array2 = text.Split(new char[1] { Path.PathSeparator });
			for (int i = 0; i < array2.Length; i++)
			{
				text = array2[i].Trim(' ', '\t', Path.PathSeparator);
				if (!Path.IsPathRooted(text))
				{
					text = Path.Combine(currentDomain.SetupInformation.ApplicationBase, text);
				}
				if (!flag)
				{
					text = Path.Combine(text, text2);
				}
				stringCollection.Add(text);
				stringCollection.Add(Path.Combine(text, text3));
			}
			return Class33.smethod_71(stringCollection, text3);
		}
		return null;
	}

	static void smethod_30(Class26.Class29 class29_0, int int_0)
	{
		if (class29_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class29_0.byte_0[class29_0.int_0++] = (byte)int_0;
		class29_0.int_0 &= 32767;
	}

	static void smethod_31(Class26.Class29 class29_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class29_0.byte_0[class29_0.int_0++] = class29_0.byte_0[int_0++];
			class29_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static int smethod_32(string[] string_0)
	{
		byte[] array = Class33.smethod_83("A6C24BF5-3690-4982-887E-11E1B159B249");
		if (array == null)
		{
			throw new Exception("application data cannot be found");
		}
		Assembly assembly_ = Class33.smethod_60(array);
		int result = Class33.smethod_76(assembly_, string_0);
		array = null;
		return result;
	}

	static bool smethod_33(Class26.Class27 class27_0)
	{
		switch (class27_0.int_4)
		{
		case 2:
		{
			if (class27_0.bool_0)
			{
				class27_0.int_4 = 12;
				return false;
			}
			int num = Class33.smethod_67(class27_0.class28_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class33.smethod_99(class27_0.class28_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class27_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class33.smethod_61(class27_0.class28_0);
				class27_0.int_4 = 3;
				break;
			case 1:
				class27_0.class30_0 = Class26.Class30.class30_0;
				class27_0.class30_1 = Class26.Class30.class30_1;
				class27_0.int_4 = 7;
				break;
			case 2:
				class27_0.class31_0 = new Class26.Class31();
				class27_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class27_0.int_8 = Class33.smethod_67(class27_0.class28_0, 16)) < 0)
			{
				return false;
			}
			Class33.smethod_99(class27_0.class28_0, 16);
			class27_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class33.smethod_67(class27_0.class28_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class33.smethod_99(class27_0.class28_0, 16);
			class27_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class33.smethod_23(class27_0.class29_0, class27_0.class28_0, class27_0.int_8);
			class27_0.int_8 -= num3;
			if (class27_0.int_8 == 0)
			{
				class27_0.int_4 = 2;
				return true;
			}
			return !Class33.smethod_18(class27_0.class28_0);
		}
		case 6:
			if (!Class33.smethod_45(class27_0.class31_0, class27_0.class28_0))
			{
				return false;
			}
			class27_0.class30_0 = Class33.smethod_3(class27_0.class31_0);
			class27_0.class30_1 = Class33.smethod_17(class27_0.class31_0);
			class27_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class33.smethod_4(class27_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_34(Class12 class12_0, byte[] byte_0, int int_0, int int_1)
	{
		Class33.smethod_94(int_1, class12_0.class4_0, byte_0, int_0);
		class12_0.int_11 += int_1;
	}

	static bool smethod_35(Assembly assembly_0, Assembly assembly_1)
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

	static void smethod_36(Class8 class8_0)
	{
		for (int i = 0; i < class8_0.int_9; i++)
		{
			int num = class8_0.byte_1[i] & 0xFF;
			int num2 = class8_0.short_0[i];
			if (num2-- != 0)
			{
				int num3 = Class33.smethod_52(class8_0, num);
				Class33.smethod_73(class8_0.class9_0, num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					Class33.smethod_44((Class10)class8_0.class11_0, num & ((1 << num4) - 1), num4);
				}
				int num5 = Class33.smethod_59(class8_0, num2);
				Class33.smethod_73(class8_0.class9_1, num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					Class33.smethod_44((Class10)class8_0.class11_0, num2 & ((1 << num4) - 1), num4);
				}
			}
			else
			{
				Class33.smethod_73(class8_0.class9_0, num);
			}
		}
		Class33.smethod_73(class8_0.class9_0, Class8.int_7);
	}

	static Assembly smethod_37(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Class0.bool_0)
		{
			return null;
		}
		return Class33.smethod_82(resolveEventArgs_0.Name);
	}

	static void smethod_38(byte[] byte_0, int int_0, Class8 class8_0, bool bool_0, int int_1)
	{
		Class33.smethod_44((Class10)class8_0.class11_0, bool_0 ? 1 : 0, 3);
		Class33.smethod_55((Class10)class8_0.class11_0);
		Class33.smethod_103(int_0, (Class10)class8_0.class11_0);
		Class33.smethod_103(~int_0, (Class10)class8_0.class11_0);
		Class33.smethod_14(byte_0, int_0, (Class10)class8_0.class11_0, int_1);
		Class33.smethod_8(class8_0);
	}

	static ICryptoTransform smethod_39(byte[] byte_0, bool bool_0, Class24 class24_0, byte[] byte_1)
	{
		class24_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class24_0.object_0, new object[1] { byte_1 });
		class24_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class24_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class24_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class24_0.object_0, new object[0]);
	}

	static StringDictionary smethod_40(string string_0)
	{
		StringDictionary stringDictionary = new StringDictionary();
		string[] array = string_0.Split(new char[1] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Trim(' ', ',').Split(new char[1] { '=' });
			if (array2.Length < 2)
			{
				stringDictionary.Add(Class0.string_0, array2[0]);
				continue;
			}
			stringDictionary.Add(array2[0].Trim(' ', '='), array2[1].Trim(' ', '='));
		}
		return stringDictionary;
	}

	static void smethod_41(byte[] byte_0, Class26.Class30 class30_0)
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
		class30_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class30_0.short_0[Class33.smethod_96(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class33.smethod_96(num3);
			if (num11 <= 9)
			{
				do
				{
					class30_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class30_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class30_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static int smethod_42(Class4 class4_0)
	{
		return class4_0.int_2;
	}

	static void smethod_43()
	{
		try
		{
			string text = "file:\\";
			string text2 = "-netz.resources";
			string text3 = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
			if (text3.StartsWith(text))
			{
				text3 = text3.Substring(text.Length, text3.Length - text.Length);
			}
			string[] files = Directory.GetFiles(text3, "*" + text2);
			if (files == null || files.Length <= 0)
			{
				return;
			}
			Class0.arrayList_0 = new ArrayList();
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = Path.GetFileName(files[i]);
				fileName = fileName.Substring(0, fileName.Length - text2.Length);
				ResourceManager resourceManager = ResourceManager.CreateFileBasedResourceManager(fileName + "-netz", text3, null);
				if (resourceManager != null)
				{
					Class0.arrayList_0.Add(resourceManager);
				}
			}
		}
		catch
		{
		}
	}

	static void smethod_44(Class10 class10_0, int int_0, int int_1)
	{
		class10_0.uint_0 |= (uint)(int_0 << class10_0.int_2);
		class10_0.int_2 += int_1;
		if (class10_0.int_2 >= 16)
		{
			class10_0.byte_0[class10_0.int_1++] = (byte)class10_0.uint_0;
			class10_0.byte_0[class10_0.int_1++] = (byte)(class10_0.uint_0 >> 8);
			class10_0.uint_0 >>= 16;
			class10_0.int_2 -= 16;
		}
	}

	static bool smethod_45(Class26.Class31 class31_0, Class26.Class28 class28_0)
	{
		while (true)
		{
			switch (class31_0.int_2)
			{
			case 5:
			{
				int int_ = Class26.Class31.int_1[class31_0.int_7];
				int num = Class33.smethod_67(class28_0, int_);
				if (num >= 0)
				{
					Class33.smethod_99(class28_0, int_);
					num += Class26.Class31.int_0[class31_0.int_7];
					while (num-- > 0)
					{
						class31_0.byte_1[class31_0.int_8++] = class31_0.byte_2;
					}
					if (class31_0.int_8 == class31_0.int_6)
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
				while (((num2 = Class33.smethod_48(class31_0.class30_0, class28_0)) & -16) == 0)
				{
					class31_0.byte_1[class31_0.int_8++] = (class31_0.byte_2 = (byte)num2);
					if (class31_0.int_8 == class31_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class31_0.byte_2 = 0;
					}
					class31_0.int_7 = num2 - 16;
					class31_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class31_0.int_8 < class31_0.int_5)
				{
					int num3 = Class33.smethod_67(class28_0, 3);
					if (num3 >= 0)
					{
						Class33.smethod_99(class28_0, 3);
						class31_0.byte_0[Class26.Class31.int_9[class31_0.int_8]] = (byte)num3;
						class31_0.int_8++;
						continue;
					}
					return false;
				}
				class31_0.class30_0 = new Class26.Class30(class31_0.byte_0);
				class31_0.byte_0 = null;
				class31_0.int_8 = 0;
				class31_0.int_2 = 4;
				goto case 4;
			case 2:
				class31_0.int_5 = Class33.smethod_67(class28_0, 4);
				if (class31_0.int_5 >= 0)
				{
					class31_0.int_5 += 4;
					Class33.smethod_99(class28_0, 4);
					class31_0.byte_0 = new byte[19];
					class31_0.int_8 = 0;
					class31_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class31_0.int_4 = Class33.smethod_67(class28_0, 5);
				if (class31_0.int_4 >= 0)
				{
					class31_0.int_4++;
					Class33.smethod_99(class28_0, 5);
					class31_0.int_6 = class31_0.int_3 + class31_0.int_4;
					class31_0.byte_1 = new byte[class31_0.int_6];
					class31_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class31_0.int_3 = Class33.smethod_67(class28_0, 5);
				if (class31_0.int_3 >= 0)
				{
					class31_0.int_3 += 257;
					Class33.smethod_99(class28_0, 5);
					class31_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class31_0.int_2 = 4;
		}
	}

	static string smethod_46(string string_0)
	{
		string text = string_0;
		text = text.Replace(" ", "!1");
		text = text.Replace(",", "!2");
		text = text.Replace(".Resources", "!3");
		text = text.Replace(".resources", "!3");
		return text.Replace("Culture", "!4");
	}

	static void smethod_47(Stream0 stream0_0, byte byte_0)
	{
		stream0_0.uint_0[0] = Class33.smethod_109(stream0_0.uint_0[0], byte_0, stream0_0);
		stream0_0.uint_0[1] = stream0_0.uint_0[1] + (byte)stream0_0.uint_0[0];
		stream0_0.uint_0[1] = stream0_0.uint_0[1] * 134775813 + 1;
		uint[] uint_ = stream0_0.uint_0;
		uint uint_2 = stream0_0.uint_0[2];
		byte byte_ = (byte)(stream0_0.uint_0[1] >> 24);
		uint_[2] = Class33.smethod_109(uint_2, byte_, stream0_0);
	}

	static int smethod_48(Class26.Class30 class30_0, Class26.Class28 class28_0)
	{
		int num;
		int num2;
		if ((num = Class33.smethod_67(class28_0, 9)) >= 0)
		{
			if ((num2 = class30_0.short_0[num]) >= 0)
			{
				Class33.smethod_99(class28_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class33.smethod_67(class28_0, int_)) >= 0)
			{
				num2 = class30_0.short_0[num3 | (num >> 9)];
				Class33.smethod_99(class28_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class28_0.int_2;
			num = Class33.smethod_67(class28_0, int_2);
			num2 = class30_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class33.smethod_99(class28_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class28_0.int_2;
		num = Class33.smethod_67(class28_0, int_3);
		num2 = class30_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class33.smethod_99(class28_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_49(Class5 class5_0, Enum0 enum0_0)
	{
		class5_0.class7_0.enum0_0 = enum0_0;
	}

	static MemoryStream smethod_50(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return null;
		}
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		Stream0 stream = null;
		try
		{
			memoryStream = new MemoryStream(byte_0);
			memoryStream2 = new MemoryStream();
			stream = new Stream0(memoryStream);
			byte[] array = new byte[byte_0.Length];
			while (true)
			{
				int num = stream.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				memoryStream2.Write(array, 0, num);
			}
			memoryStream2.Flush();
			memoryStream2.Seek(0L, SeekOrigin.Begin);
			return memoryStream2;
		}
		finally
		{
			memoryStream?.Close();
			stream?.Close();
			memoryStream = null;
			stream = null;
		}
	}

	static void smethod_51()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class33.smethod_104;
		}
		catch
		{
		}
	}

	static int smethod_52(Class8 class8_0, int int_0)
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

	static void smethod_53(Class7 class7_0)
	{
		Class33.smethod_8(class7_0.class8_0);
		class7_0.class1_0.vmethod_1();
		class7_0.int_10 = 1;
		class7_0.int_9 = 1;
		class7_0.int_11 = 0;
		class7_0.int_17 = 0;
		class7_0.bool_0 = false;
		class7_0.int_8 = 2;
		for (int i = 0; i < 32768; i++)
		{
			class7_0.short_0[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			class7_0.short_1[j] = 0;
		}
	}

	static int smethod_54(Class26.Stream1 stream1_0)
	{
		return Class33.smethod_80(stream1_0) | (Class33.smethod_80(stream1_0) << 16);
	}

	static void smethod_55(Class10 class10_0)
	{
		if (class10_0.int_2 > 0)
		{
			class10_0.byte_0[class10_0.int_1++] = (byte)class10_0.uint_0;
			if (class10_0.int_2 > 8)
			{
				class10_0.byte_0[class10_0.int_1++] = (byte)(class10_0.uint_0 >> 8);
			}
		}
		class10_0.uint_0 = 0u;
		class10_0.int_2 = 0;
	}

	static int smethod_56(Class14 class14_0, Class4 class4_0)
	{
		int num;
		int num2;
		if ((num = Class33.smethod_102(class4_0, 9)) >= 0)
		{
			if ((num2 = class14_0.short_0[num]) >= 0)
			{
				Class33.smethod_57(class4_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class33.smethod_102(class4_0, int_)) >= 0)
			{
				num2 = class14_0.short_0[num3 | (num >> 9)];
				Class33.smethod_57(class4_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num4 = Class33.smethod_42(class4_0);
			num = Class33.smethod_102(class4_0, num4);
			num2 = class14_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= num4)
			{
				Class33.smethod_57(class4_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int num5 = Class33.smethod_42(class4_0);
		num = Class33.smethod_102(class4_0, num5);
		num2 = class14_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= num5)
		{
			Class33.smethod_57(class4_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_57(Class4 class4_0, int int_0)
	{
		class4_0.uint_0 >>= int_0;
		class4_0.int_2 -= int_0;
	}

	static ICryptoTransform smethod_58(byte[] byte_0, byte[] byte_1, bool bool_0, Class25 class25_0)
	{
		class25_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class25_0.object_0, new object[1] { byte_0 });
		class25_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class25_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class25_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class25_0.object_0, new object[0]);
	}

	static int smethod_59(Class8 class8_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static Assembly smethod_60(byte[] byte_0)
	{
		MemoryStream memoryStream = null;
		Assembly assembly = null;
		try
		{
			memoryStream = Class33.smethod_50(byte_0);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return Assembly.Load(memoryStream.ToArray());
		}
		finally
		{
			memoryStream?.Close();
			memoryStream = null;
		}
	}

	static void smethod_61(Class26.Class28 class28_0)
	{
		class28_0.uint_0 >>= class28_0.int_2 & 7;
		class28_0.int_2 &= -8;
	}

	static byte[] smethod_62(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class33.smethod_35(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class26.Stream1 stream = new Class26.Stream1(byte_0);
		byte[] array = new byte[0];
		int num = Class33.smethod_54(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class33.smethod_80(stream);
			int num3 = Class33.smethod_80(stream);
			int num4 = Class33.smethod_80(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class33.smethod_54(stream);
			Class33.smethod_54(stream);
			Class33.smethod_54(stream);
			int num5 = Class33.smethod_54(stream);
			int num6 = Class33.smethod_80(stream);
			int num7 = Class33.smethod_80(stream);
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
			Class26.Class27 class27_ = new Class26.Class27(array2);
			array = new byte[num5];
			Class33.smethod_79(array.Length, 0, class27_, array);
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
				int num9 = Class33.smethod_54(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class33.smethod_54(stream);
					num11 = Class33.smethod_54(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class26.Class27 class27_2 = new Class26.Class27(array3);
					Class33.smethod_79(num11, i, class27_2, array);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 18, 13, 197, 41, 156, 193, 60, 68 };
				byte[] byte_2 = new byte[8] { 223, 244, 49, 127, 175, 81, 237, 228 };
				using Class25 class25_ = new Class25();
				using ICryptoTransform cryptoTransform = Class33.smethod_58(byte_, byte_2, bool_0: true, class25_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class33.smethod_62(byte_3);
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
				using Class24 class24_ = new Class24();
				using ICryptoTransform cryptoTransform2 = Class33.smethod_39(byte_5, bool_0: true, class24_, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class33.smethod_62(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static bool smethod_63(Class12 class12_0)
	{
		while (true)
		{
			if (class12_0.int_6 > 0)
			{
				int num = Class33.smethod_102(class12_0.class4_0, 8);
				if (num < 0)
				{
					break;
				}
				Class33.smethod_57(class12_0.class4_0, 8);
				class12_0.int_5 = (class12_0.int_5 << 8) | num;
				class12_0.int_6 -= 8;
				continue;
			}
			if ((int)class12_0.class1_0.vmethod_0() != class12_0.int_5)
			{
				throw new FormatException("Adler chksum doesn't match: " + (int)class12_0.class1_0.vmethod_0() + " vs. " + class12_0.int_5);
			}
			class12_0.int_4 = 12;
			return false;
		}
		return false;
	}

	static int smethod_64(Class26.Class28 class28_0)
	{
		return class28_0.int_1 - class28_0.int_0 + (class28_0.int_2 >> 3);
	}

	static void smethod_65(Class5 class5_0, int int_0)
	{
		if (int_0 == Class5.int_2)
		{
			int_0 = 6;
		}
		else if (int_0 < Class5.int_3 || int_0 > Class5.int_0)
		{
			throw new ArgumentOutOfRangeException("lvl");
		}
		if (class5_0.int_15 != int_0)
		{
			class5_0.int_15 = int_0;
			Class33.smethod_11(int_0, class5_0.class7_0);
		}
	}

	static bool smethod_66(Class12 class12_0)
	{
		int num = Class33.smethod_26(class12_0.class3_0);
		while (num >= 258)
		{
			switch (class12_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class33.smethod_56(class12_0.class14_0, class12_0.class4_0)) & -256) == 0)
				{
					Class33.smethod_5(class12_0.class3_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					try
					{
						class12_0.int_7 = Class12.int_0[num2 - 257];
						class12_0.int_6 = Class12.int_1[num2 - 257];
					}
					catch (Exception)
					{
						throw new FormatException("Illegal rep length code");
					}
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class12_0.class14_1 = null;
				class12_0.class14_0 = null;
				class12_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class12_0.int_6 > 0)
				{
					class12_0.int_4 = 8;
					int num4 = Class33.smethod_102(class12_0.class4_0, class12_0.int_6);
					if (num4 < 0)
					{
						return false;
					}
					Class33.smethod_57(class12_0.class4_0, class12_0.int_6);
					class12_0.int_7 += num4;
				}
				class12_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class33.smethod_56(class12_0.class14_1, class12_0.class4_0);
				if (num2 >= 0)
				{
					try
					{
						class12_0.int_8 = Class12.int_2[num2];
						class12_0.int_6 = Class12.int_3[num2];
					}
					catch (Exception)
					{
						throw new FormatException("Illegal rep dist code");
					}
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class12_0.int_6 > 0)
				{
					class12_0.int_4 = 10;
					int num3 = Class33.smethod_102(class12_0.class4_0, class12_0.int_6);
					if (num3 < 0)
					{
						return false;
					}
					Class33.smethod_57(class12_0.class4_0, class12_0.int_6);
					class12_0.int_8 += num3;
				}
				break;
			default:
				throw new FormatException();
			}
			Class33.smethod_7(class12_0.class3_0, class12_0.int_7, class12_0.int_8);
			num -= class12_0.int_7;
			class12_0.int_4 = 7;
		}
		return true;
	}

	static int smethod_67(Class26.Class28 class28_0, int int_0)
	{
		if (class28_0.int_2 < int_0)
		{
			if (class28_0.int_0 == class28_0.int_1)
			{
				return -1;
			}
			class28_0.uint_0 |= (uint)(((class28_0.byte_0[class28_0.int_0++] & 0xFF) | ((class28_0.byte_0[class28_0.int_0++] & 0xFF) << 8)) << class28_0.int_2);
			class28_0.int_2 += 16;
		}
		return (int)(class28_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_68(Class26.Class29 class29_0)
	{
		return 32768 - class29_0.int_1;
	}

	static void smethod_69()
	{
		try
		{
			Class33.smethod_51();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_70(Class7 class7_0)
	{
		class7_0.int_7 = (class7_0.byte_0[class7_0.int_10] << 5) ^ class7_0.byte_0[class7_0.int_10 + 1];
	}

	static byte[] smethod_71(StringCollection stringCollection_0, string string_0)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < stringCollection_0.Count)
			{
				text = Path.Combine(stringCollection_0[num], string_0 + Class0.string_2);
				if (File.Exists(text))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return Class33.smethod_0(text);
	}

	static void smethod_72(Enum0 enum0_0, Class7 class7_0)
	{
		class7_0.enum0_0 = enum0_0;
	}

	static void smethod_73(Class8.Class9 class9_0, int int_0)
	{
		Class33.smethod_44((Class10)class9_0.class8_0.class11_0, class9_0.short_1[int_0] & 0xFFFF, (int)class9_0.byte_0[int_0]);
	}

	static int smethod_74(int int_0, int int_1, Class3 class3_0, byte[] byte_0)
	{
		int num = class3_0.int_2;
		if (int_0 > class3_0.int_3)
		{
			int_0 = class3_0.int_3;
		}
		else
		{
			num = (class3_0.int_2 - class3_0.int_3 + int_0) & Class3.int_1;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class3_0.byte_0, Class3.int_0 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class3_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class3_0.int_3 -= num2;
		if (class3_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static bool smethod_75(Class12 class12_0)
	{
		int num = Class33.smethod_102(class12_0.class4_0, 16);
		if (num < 0)
		{
			return false;
		}
		Class33.smethod_57(class12_0.class4_0, 16);
		num = ((num << 8) | (num >> 8)) & 0xFFFF;
		if (num % 31 != 0)
		{
			throw new FormatException("Header checksum illegal");
		}
		if ((num & 0xF00) != Class5.int_4 << 8)
		{
			throw new FormatException("Compression Method unknown");
		}
		if ((num & 0x20) == 0)
		{
			class12_0.int_4 = 2;
		}
		else
		{
			class12_0.int_4 = 1;
			class12_0.int_6 = 32;
		}
		return true;
	}

	static int smethod_76(Assembly assembly_0, string[] string_0)
	{
		MethodInfo entryPoint = assembly_0.EntryPoint;
		ParameterInfo[] parameters = entryPoint.GetParameters();
		object[] parameters2 = null;
		if (parameters != null && parameters.Length > 0)
		{
			parameters2 = new object[1] { string_0 };
		}
		object obj = entryPoint.Invoke(null, parameters2);
		if (obj == null)
		{
			return 0;
		}
		if (obj is int)
		{
			return (int)obj;
		}
		return 0;
	}

	static bool smethod_77(Class12 class12_0)
	{
		switch (class12_0.int_4)
		{
		default:
			throw new FormatException();
		case 0:
			return Class33.smethod_75(class12_0);
		case 1:
			return Class33.smethod_110(class12_0);
		case 2:
		{
			if (class12_0.bool_0)
			{
				if (class12_0.bool_1)
				{
					class12_0.int_4 = 12;
					return false;
				}
				Class33.smethod_28(class12_0.class4_0);
				class12_0.int_6 = 32;
				class12_0.int_4 = 11;
				return true;
			}
			int num = Class33.smethod_102(class12_0.class4_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class33.smethod_57(class12_0.class4_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class12_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			default:
				throw new FormatException("Unknown block type " + num);
			case 0:
				Class33.smethod_28(class12_0.class4_0);
				class12_0.int_4 = 3;
				break;
			case 1:
				class12_0.class14_0 = Class14.class14_0;
				class12_0.class14_1 = Class14.class14_1;
				class12_0.int_4 = 7;
				break;
			case 2:
				class12_0.class13_0 = new Class13();
				class12_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class12_0.int_9 = Class33.smethod_102(class12_0.class4_0, 16)) < 0)
			{
				return false;
			}
			Class33.smethod_57(class12_0.class4_0, 16);
			class12_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num3 = Class33.smethod_102(class12_0.class4_0, 16);
			if (num3 < 0)
			{
				return false;
			}
			Class33.smethod_57(class12_0.class4_0, 16);
			if (num3 != (class12_0.int_9 ^ 0xFFFF))
			{
				throw new FormatException("broken uncompressed block");
			}
			class12_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num2 = Class33.smethod_92(class12_0.class3_0, class12_0.class4_0, class12_0.int_9);
			class12_0.int_9 -= num2;
			if (class12_0.int_9 == 0)
			{
				class12_0.int_4 = 2;
				return true;
			}
			return !Class33.smethod_88(class12_0.class4_0);
		}
		case 6:
			if (!Class33.smethod_21(class12_0.class13_0, class12_0.class4_0))
			{
				return false;
			}
			class12_0.class14_0 = Class33.smethod_25(class12_0.class13_0);
			class12_0.class14_1 = Class33.smethod_97(class12_0.class13_0);
			class12_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class33.smethod_66(class12_0);
		case 11:
			return Class33.smethod_63(class12_0);
		case 12:
			return false;
		}
	}

	static void smethod_78(int int_0, byte[] byte_0, Class26.Class28 class28_0, int int_1)
	{
		if (class28_0.int_0 < class28_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class28_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class28_0.int_2);
				class28_0.int_2 += 8;
			}
			class28_0.byte_0 = byte_0;
			class28_0.int_0 = int_1;
			class28_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static int smethod_79(int int_0, int int_1, Class26.Class27 class27_0, byte[] byte_0)
	{
		int num = 0;
		do
		{
			if (class27_0.int_4 != 11)
			{
				int num2 = Class33.smethod_106(int_1, int_0, byte_0, class27_0.class29_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class33.smethod_33(class27_0) || (class27_0.class29_0.int_1 > 0 && class27_0.int_4 != 11));
		return num;
	}

	static int smethod_80(Class26.Stream1 stream1_0)
	{
		return stream1_0.ReadByte() | (stream1_0.ReadByte() << 8);
	}

	static void smethod_81(Class8.Class9 class9_0)
	{
		for (int i = 0; i < class9_0.short_0.Length; i++)
		{
			class9_0.short_0[i] = 0;
		}
		class9_0.short_1 = null;
		class9_0.byte_0 = null;
	}

	static Assembly smethod_82(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (Class0.hybridDictionary_0 == null)
		{
			Class0.hybridDictionary_0 = new HybridDictionary();
		}
		string_0 = string_0.Trim();
		string key = string_0.ToLower();
		if (Class0.hybridDictionary_0[key] != null)
		{
			return (Assembly)Class0.hybridDictionary_0[key];
		}
		StringDictionary stringDictionary = Class33.smethod_40(string_0);
		string text = stringDictionary[Class0.string_0];
		if (text == null)
		{
			return null;
		}
		byte[] array = null;
		array = Class33.smethod_83(string_0);
		if (array == null)
		{
			array = Class33.smethod_83(string_0.ToLower());
		}
		if (array == null)
		{
			array = Class33.smethod_83(text);
		}
		if (array == null)
		{
			array = Class33.smethod_83(text.ToLower());
		}
		if (array == null)
		{
			array = Class33.smethod_83(Path.GetFileNameWithoutExtension(text)!.ToLower());
		}
		if (array == null)
		{
			try
			{
				array = Class33.smethod_29(stringDictionary);
			}
			catch
			{
				array = null;
			}
		}
		if (array == null)
		{
			return null;
		}
		Assembly assembly = Class33.smethod_60(array);
		array = null;
		Class0.hybridDictionary_0[key] = assembly;
		return assembly;
	}

	static byte[] smethod_83(string string_0)
	{
		byte[] array = null;
		if (Class0.resourceManager_0 == null)
		{
			Class0.resourceManager_0 = new ResourceManager("app", Assembly.GetExecutingAssembly());
		}
		try
		{
			Class0.bool_0 = true;
			string name = Class33.smethod_46(string_0);
			if (array == null && Class0.arrayList_0 != null)
			{
				for (int i = 0; i < Class0.arrayList_0.Count; i++)
				{
					try
					{
						ResourceManager resourceManager = (ResourceManager)Class0.arrayList_0[i];
						if (resourceManager != null)
						{
							array = (byte[])resourceManager.GetObject(name);
						}
					}
					catch
					{
					}
					if (array != null)
					{
						break;
					}
				}
			}
			if (array == null)
			{
				return (byte[])Class0.resourceManager_0.GetObject(name);
			}
			return array;
		}
		finally
		{
			Class0.bool_0 = false;
		}
	}

	static byte smethod_84(Stream0 stream0_0)
	{
		uint num = (stream0_0.uint_0[2] & 0xFFFFu) | 2u;
		return (byte)(num * (num ^ 1) >> 8);
	}

	static int smethod_85(Class4 class4_0, byte[] byte_0, int int_0, int int_1)
	{
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException("length negative");
		}
		if (((uint)class4_0.int_2 & 7u) != 0)
		{
			throw new InvalidOperationException("Bit buffer is not aligned!");
		}
		int num = 0;
		while (class4_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class4_0.uint_0;
			class4_0.uint_0 >>= 8;
			class4_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class4_0.int_1 - class4_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class4_0.byte_0, class4_0.int_0, byte_0, int_0, int_1);
		class4_0.int_0 += int_1;
		if (((uint)(class4_0.int_0 - class4_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class4_0.uint_0 = class4_0.byte_0[class4_0.int_0++] & 0xFFu;
			class4_0.int_2 = 8;
		}
		return num + int_1;
	}

	static int smethod_86(Class4 class4_0)
	{
		return class4_0.int_1 - class4_0.int_0 + (class4_0.int_2 >> 3);
	}

	static void smethod_87(Class8.Class9 class9_0, Class8.Class9 class9_1)
	{
		int num = -1;
		int num2 = 0;
		while (num2 < class9_1.int_2)
		{
			int num3 = 1;
			int num4 = class9_1.byte_0[num2];
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
					short[] array = (short_ = class9_0.short_0);
					nint num7 = num4;
					array[num4] = (short)(short_[num7] + 1);
					num3 = 0;
				}
			}
			num = num4;
			num2++;
			while (num2 < class9_1.int_2 && num == class9_1.byte_0[num2])
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
				short[] array2 = (short_ = class9_0.short_0);
				int num8 = num;
				nint num7 = num8;
				array2[num8] = (short)(short_[num7] + (short)num3);
			}
			else if (num != 0)
			{
				short[] short_;
				short[] array3 = (short_ = class9_0.short_0);
				int int_ = Class8.int_4;
				nint num7 = int_;
				array3[int_] = (short)(short_[num7] + 1);
			}
			else if (num3 <= 10)
			{
				short[] short_;
				short[] array4 = (short_ = class9_0.short_0);
				int int_2 = Class8.int_5;
				nint num7 = int_2;
				array4[int_2] = (short)(short_[num7] + 1);
			}
			else
			{
				short[] short_;
				short[] array5 = (short_ = class9_0.short_0);
				int int_3 = Class8.int_6;
				nint num7 = int_3;
				array5[int_3] = (short)(short_[num7] + 1);
			}
		}
	}

	static bool smethod_88(Class4 class4_0)
	{
		return class4_0.int_0 == class4_0.int_1;
	}

	static bool smethod_89(int int_0, Class8 class8_0)
	{
		class8_0.short_0[class8_0.int_9] = 0;
		class8_0.byte_1[class8_0.int_9++] = (byte)int_0;
		short[] short_;
		short[] array = (short_ = class8_0.class9_0.short_0);
		nint num = int_0;
		array[int_0] = (short)(short_[num] + 1);
		return Class33.smethod_16(class8_0);
	}

	static void smethod_90(int int_0, Stream0 stream0_0, byte[] byte_0, int int_1)
	{
		for (int i = int_1; i < int_1 + int_0; i++)
		{
			byte[] array;
			byte[] array2 = (array = byte_0);
			int num = i;
			nint num2 = num;
			array2[num] = (byte)(array[num2] ^ Class33.smethod_84(stream0_0));
			Class33.smethod_47(stream0_0, byte_0[i]);
		}
	}

	static int smethod_91(Class26.Class29 class29_0)
	{
		return class29_0.int_1;
	}

	static int smethod_92(Class3 class3_0, Class4 class4_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, Class3.int_0 - class3_0.int_3), Class33.smethod_86(class4_0));
		int num = Class3.int_0 - class3_0.int_2;
		int num2;
		if (int_0 > num)
		{
			num2 = Class33.smethod_85(class4_0, class3_0.byte_0, class3_0.int_2, num);
			if (num2 == num)
			{
				num2 += Class33.smethod_85(class4_0, class3_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class33.smethod_85(class4_0, class3_0.byte_0, class3_0.int_2, int_0);
		}
		class3_0.int_2 = (class3_0.int_2 + num2) & Class3.int_1;
		class3_0.int_3 += num2;
		return num2;
	}

	static bool smethod_93(Class12 class12_0)
	{
		return class12_0.int_4 == 12 && Class33.smethod_6(class12_0.class3_0) == 0;
	}

	static void smethod_94(int int_0, Class4 class4_0, byte[] byte_0, int int_1)
	{
		if (class4_0.int_0 < class4_0.int_1)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class4_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class4_0.int_2);
				class4_0.int_2 += 8;
			}
			class4_0.byte_0 = byte_0;
			class4_0.int_0 = int_1;
			class4_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_95(Class12 class12_0)
	{
		return Class33.smethod_88(class12_0.class4_0);
	}

	static short smethod_96(int int_0)
	{
		return (short)((Class26.Class32.byte_0[int_0 & 0xF] << 12) | (Class26.Class32.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class26.Class32.byte_0[(int_0 >> 8) & 0xF] << 4) | Class26.Class32.byte_0[int_0 >> 12]);
	}

	static Class14 smethod_97(Class13 class13_0)
	{
		byte[] array = new byte[checked((uint)class13_0.int_4)];
		Array.Copy(class13_0.byte_1, class13_0.int_3, array, 0, class13_0.int_4);
		return new Class14(array);
	}

	static int smethod_98(Class8.Class9 class9_0)
	{
		int num = 0;
		for (int i = 0; i < class9_0.short_0.Length; i++)
		{
			num += class9_0.short_0[i] * class9_0.byte_0[i];
		}
		return num;
	}

	static void smethod_99(Class26.Class28 class28_0, int int_0)
	{
		class28_0.uint_0 >>= int_0;
		class28_0.int_2 -= int_0;
	}

	static void smethod_100(Class8.Class9 class9_0)
	{
		int num = class9_0.short_0.Length;
		int[] array = new int[checked((uint)num)];
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			int num4 = class9_0.short_0[i];
			if (num4 != 0)
			{
				int num5 = num2++;
				int num6;
				while (num5 > 0 && class9_0.short_0[array[num6 = (num5 - 1) / 2]] > num4)
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
		class9_0.int_2 = Math.Max(num3 + 1, class9_0.int_1);
		int num8 = num2;
		int[] array2;
		int[] array3;
		int num9;
		checked
		{
			array2 = new int[(uint)unchecked(4 * num2 - 2)];
			array3 = new int[(uint)unchecked(2 * num2 - 1)];
			num9 = num8;
		}
		for (int j = 0; j < num2; j++)
		{
			int num10 = (array2[2 * j] = array[j]);
			array2[2 * j + 1] = -1;
			array3[j] = class9_0.short_0[num10] << 8;
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
		if (array[0] != array2.Length / 2 - 1)
		{
			throw new Exception("Weird!");
		}
		Class33.smethod_20(class9_0, array2);
	}

	static void smethod_101(Class8.Class9 class9_0)
	{
		int[] array;
		int num;
		checked
		{
			array = new int[(uint)class9_0.int_3];
			num = 0;
			class9_0.short_1 = new short[(uint)class9_0.short_0.Length];
		}
		for (int i = 0; i < class9_0.int_3; i++)
		{
			array[i] = num;
			num += class9_0.int_0[i] << 15 - i;
		}
		for (int j = 0; j < class9_0.int_2; j++)
		{
			int num2 = class9_0.byte_0[j];
			if (num2 > 0)
			{
				class9_0.short_1[j] = Class33.smethod_19(array[num2 - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num3 = num2 - 1;
				nint num4 = num3;
				array3[num3] = array2[num4] + (1 << 16 - num2);
			}
		}
	}

	static int smethod_102(Class4 class4_0, int int_0)
	{
		if (class4_0.int_2 < int_0)
		{
			if (class4_0.int_0 == class4_0.int_1)
			{
				return -1;
			}
			class4_0.uint_0 |= (uint)(((class4_0.byte_0[class4_0.int_0++] & 0xFF) | ((class4_0.byte_0[class4_0.int_0++] & 0xFF) << 8)) << class4_0.int_2);
			class4_0.int_2 += 16;
		}
		return (int)(class4_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_103(int int_0, Class10 class10_0)
	{
		class10_0.byte_0[class10_0.int_1++] = (byte)int_0;
		class10_0.byte_0[class10_0.int_1++] = (byte)(int_0 >> 8);
	}

	static Assembly smethod_104(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class17.Struct15 @struct = new Class17.Struct15(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezg0YWViZTliLWU2NGYtNGNlYi05OTdiLTZjZTI0NDE3YzA2M30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{506693f9-8983-41cb-a803-a8092c3b2966},ezg0YWViZTliLWU2NGYtNGNlYi05OTdiLTZjZTI0NDE3YzA2M30=,[z]{506693f9-8983-41cb-a803-a8092c3b2966}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (Class17.hashtable_0)
			{
				if (Class17.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class17.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class33.smethod_62(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class33.MoveFileEx(text5, (string)null, 4);
								Class33.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class17.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static void smethod_105(Class5 class5_0)
	{
		class5_0.int_16 = (class5_0.bool_0 ? Class5.int_10 : Class5.int_8);
		class5_0.int_17 = 0;
		Class33.smethod_2((Class10)class5_0.class11_0);
		Class33.smethod_53(class5_0.class7_0);
	}

	static int smethod_106(int int_0, int int_1, byte[] byte_0, Class26.Class29 class29_0)
	{
		int num = class29_0.int_0;
		if (int_1 > class29_0.int_1)
		{
			int_1 = class29_0.int_1;
		}
		else
		{
			num = (class29_0.int_0 - class29_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class29_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class29_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class29_0.int_1 -= num2;
		if (class29_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_107(Stream0 stream0_0)
	{
		stream0_0.int_0 = stream0_0.stream_0.Read(stream0_0.byte_0, 0, stream0_0.byte_0.Length);
		if (stream0_0.byte_2 != null)
		{
			byte[] byte_ = stream0_0.byte_0;
			int int_ = stream0_0.byte_0.Length;
			Class33.smethod_90(int_, stream0_0, byte_, 0);
		}
		if (stream0_0.int_0 <= 0)
		{
			throw new ApplicationException("Deflated stream ends early.");
		}
		Class33.smethod_34(stream0_0.class12_0, stream0_0.byte_0, 0, stream0_0.int_0);
	}

	static int smethod_108(Class12 class12_0, byte[] byte_0, int int_0, int int_1)
	{
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException("len < 0");
		}
		if (int_1 == 0)
		{
			return 0;
		}
		int num = 0;
		do
		{
			if (class12_0.int_4 != 11)
			{
				int num2 = Class33.smethod_74(int_1, int_0, class12_0.class3_0, byte_0);
				class12_0.class1_0.vmethod_2(byte_0, int_0, num2);
				int_0 += num2;
				num += num2;
				class12_0.int_10 += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class33.smethod_77(class12_0) || (Class33.smethod_6(class12_0.class3_0) > 0 && class12_0.int_4 != 11));
		return num;
	}

	static uint smethod_109(uint uint_0, byte byte_0, Stream0 stream0_0)
	{
		return Class2.uint_1[(uint_0 ^ byte_0) & 0xFF] ^ (uint_0 >> 8);
	}

	static bool smethod_110(Class12 class12_0)
	{
		while (true)
		{
			if (class12_0.int_6 > 0)
			{
				int num = Class33.smethod_102(class12_0.class4_0, 8);
				if (num < 0)
				{
					break;
				}
				Class33.smethod_57(class12_0.class4_0, 8);
				class12_0.int_5 = (class12_0.int_5 << 8) | num;
				class12_0.int_6 -= 8;
				continue;
			}
			return false;
		}
		return false;
	}

	static bool smethod_111(Class12 class12_0)
	{
		return class12_0.int_4 == 1 && class12_0.int_6 == 0;
	}

	static void smethod_112(Class14 class14_0, byte[] byte_0)
	{
		int[] array;
		int[] array2;
		checked
		{
			array = new int[(uint)unchecked(Class14.int_0 + 1)];
			array2 = new int[(uint)unchecked(Class14.int_0 + 1)];
		}
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
		for (int j = 1; j <= Class14.int_0; j++)
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
		if (num3 != 65536)
		{
			throw new Exception("Code lengths don't add up properly.");
		}
		class14_0.short_0 = new short[checked((uint)num4)];
		int num7 = 512;
		for (int num8 = Class14.int_0; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class14_0.short_0[Class33.smethod_19(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class33.smethod_19(num3);
			if (num11 <= 9)
			{
				do
				{
					class14_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class14_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class14_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static void smethod_113()
	{
		try
		{
			Class22.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_114(int int_0, byte[] byte_0, Class8 class8_0, bool bool_0, int int_1)
	{
		short[] short_;
		short[] array = (short_ = class8_0.class9_0.short_0);
		int int_2 = Class8.int_7;
		nint num = int_2;
		array[int_2] = (short)(short_[num] + 1);
		Class33.smethod_100(class8_0.class9_0);
		Class33.smethod_100(class8_0.class9_1);
		Class8.Class9 class9_ = class8_0.class9_0;
		Class8.Class9 class9_2 = class8_0.class9_2;
		Class33.smethod_87(class9_2, class9_);
		class9_ = class8_0.class9_1;
		class9_2 = class8_0.class9_2;
		Class33.smethod_87(class9_2, class9_);
		Class33.smethod_100(class8_0.class9_2);
		int num2 = 4;
		for (int num3 = 18; num3 > num2; num3--)
		{
			if (class8_0.class9_2.byte_0[Class8.int_8[num3]] > 0)
			{
				num2 = num3 + 1;
			}
		}
		int num4 = 14 + num2 * 3 + Class33.smethod_98(class8_0.class9_2) + Class33.smethod_98(class8_0.class9_0) + Class33.smethod_98(class8_0.class9_1) + class8_0.int_10;
		int num5 = class8_0.int_10;
		for (int i = 0; i < Class8.int_1; i++)
		{
			num5 += class8_0.class9_0.short_0[i] * Class8.byte_2[i];
		}
		for (int j = 0; j < Class8.int_2; j++)
		{
			num5 += class8_0.class9_1.short_0[j] * Class8.byte_3[j];
		}
		if (num4 >= num5)
		{
			num4 = num5;
		}
		if (int_0 >= 0 && int_1 + 4 < num4 >> 3)
		{
			Class33.smethod_38(byte_0, int_1, class8_0, bool_0, int_0);
		}
		else if (num4 == num5)
		{
			Class33.smethod_44((Class10)class8_0.class11_0, 2 + (bool_0 ? 1 : 0), 3);
			Class8.Class9 class9_3 = class8_0.class9_0;
			short[] short_2 = Class8.short_1;
			byte[] byte_ = Class8.byte_2;
			Class33.smethod_12(short_2, class9_3, byte_);
			class9_3 = class8_0.class9_1;
			short_2 = Class8.short_2;
			byte_ = Class8.byte_3;
			Class33.smethod_12(short_2, class9_3, byte_);
			Class33.smethod_36(class8_0);
			Class33.smethod_8(class8_0);
		}
		else
		{
			Class33.smethod_44((Class10)class8_0.class11_0, 4 + (bool_0 ? 1 : 0), 3);
			Class33.smethod_115(class8_0, num2);
			Class33.smethod_36(class8_0);
			Class33.smethod_8(class8_0);
		}
	}

	static void smethod_115(Class8 class8_0, int int_0)
	{
		Class33.smethod_101(class8_0.class9_2);
		Class33.smethod_101(class8_0.class9_0);
		Class33.smethod_101(class8_0.class9_1);
		Class33.smethod_44((Class10)class8_0.class11_0, class8_0.class9_0.int_2 - 257, 5);
		Class33.smethod_44((Class10)class8_0.class11_0, class8_0.class9_1.int_2 - 1, 5);
		Class33.smethod_44((Class10)class8_0.class11_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class33.smethod_44((Class10)class8_0.class11_0, (int)class8_0.class9_2.byte_0[Class8.int_8[i]], 3);
		}
		Class33.smethod_9(class8_0.class9_0, class8_0.class9_2);
		Class33.smethod_9(class8_0.class9_1, class8_0.class9_2);
	}
}
