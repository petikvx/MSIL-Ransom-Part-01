using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns0;

internal class Class12
{
	static int smethod_0(Class4.Class8 class8_0, Class4.Class6 class6_0)
	{
		int num;
		int num2;
		if ((num = Class12.smethod_21(class6_0, 9)) >= 0)
		{
			if ((num2 = class8_0.short_0[num]) >= 0)
			{
				Class12.smethod_4(class6_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class12.smethod_21(class6_0, int_)) >= 0)
			{
				num2 = class8_0.short_0[num3 | (num >> 9)];
				Class12.smethod_4(class6_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class6_0.int_2;
			num = Class12.smethod_21(class6_0, int_2);
			num2 = class8_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class12.smethod_4(class6_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class6_0.int_2;
		num = Class12.smethod_21(class6_0, int_3);
		num2 = class8_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class12.smethod_4(class6_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_1(int int_0, Class4.Class5 class5_0, byte[] byte_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class5_0.int_4 != 11)
			{
				int num2 = Class12.smethod_29(int_0, class5_0.class7_0, int_1, byte_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class12.smethod_14(class5_0) || (class5_0.class7_0.int_1 > 0 && class5_0.int_4 != 11));
		return num;
	}

	static int smethod_2(Class4.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static bool smethod_3(Class4.Class5 class5_0)
	{
		int num = Class12.smethod_20(class5_0.class7_0);
		while (num >= 258)
		{
			switch (class5_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class12.smethod_0(class5_0.class8_0, class5_0.class6_0)) & -256) == 0)
				{
					Class12.smethod_7(class5_0.class7_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class5_0.int_6 = Class4.Class5.int_0[num2 - 257];
					class5_0.int_5 = Class4.Class5.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class5_0.class8_1 = null;
				class5_0.class8_0 = null;
				class5_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class5_0.int_5 > 0)
				{
					class5_0.int_4 = 8;
					int num4 = Class12.smethod_21(class5_0.class6_0, class5_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class12.smethod_4(class5_0.class6_0, class5_0.int_5);
					class5_0.int_6 += num4;
				}
				class5_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class12.smethod_0(class5_0.class8_1, class5_0.class6_0);
				if (num2 >= 0)
				{
					class5_0.int_7 = Class4.Class5.int_2[num2];
					class5_0.int_5 = Class4.Class5.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class5_0.int_5 > 0)
				{
					class5_0.int_4 = 10;
					int num3 = Class12.smethod_21(class5_0.class6_0, class5_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class12.smethod_4(class5_0.class6_0, class5_0.int_5);
					class5_0.int_7 += num3;
				}
				Class12.smethod_32(class5_0.class7_0, class5_0.int_6, class5_0.int_7);
				num -= class5_0.int_6;
				class5_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_4(Class4.Class6 class6_0, int int_0)
	{
		class6_0.uint_0 >>= int_0;
		class6_0.int_2 -= int_0;
	}

	static bool smethod_5(Class4.Class6 class6_0)
	{
		return class6_0.int_0 == class6_0.int_1;
	}

	static ICryptoTransform smethod_6(bool bool_0, byte[] byte_0, Class2 class2_0, byte[] byte_1)
	{
		class2_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class2_0.object_0, new object[1] { byte_0 });
		class2_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class2_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class2_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class2_0.object_0, new object[0]);
	}

	static void smethod_7(Class4.Class7 class7_0, int int_0)
	{
		if (class7_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class7_0.byte_0[class7_0.int_0++] = (byte)int_0;
		class7_0.int_0 &= 32767;
	}

	static int smethod_8(Class4.Class6 class6_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class6_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class6_0.uint_0;
			class6_0.uint_0 >>= 8;
			class6_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class6_0.int_1 - class6_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class6_0.byte_0, class6_0.int_0, byte_0, int_0, int_1);
		class6_0.int_0 += int_1;
		if (((uint)(class6_0.int_0 - class6_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class6_0.uint_0 = class6_0.byte_0[class6_0.int_0++] & 0xFFu;
			class6_0.int_2 = 8;
		}
		return num + int_1;
	}

	static byte[] smethod_9(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class12.smethod_18(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class4.Stream0 stream = new Class4.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class12.smethod_22(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class12.smethod_2(stream);
			int num3 = Class12.smethod_2(stream);
			int num4 = Class12.smethod_2(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class12.smethod_22(stream);
			Class12.smethod_22(stream);
			Class12.smethod_22(stream);
			int num5 = Class12.smethod_22(stream);
			int num6 = Class12.smethod_2(stream);
			int num7 = Class12.smethod_2(stream);
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
			Class4.Class5 class5_ = new Class4.Class5(array2);
			array = new byte[num5];
			Class12.smethod_1(array.Length, class5_, array, 0);
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
				int num9 = Class12.smethod_22(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class12.smethod_22(stream);
					num11 = Class12.smethod_22(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class4.Class5 class5_2 = new Class4.Class5(array3);
					Class12.smethod_1(num11, class5_2, array, i);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 119, 127, 137, 84, 104, 17, 212, 84 };
				byte[] byte_2 = new byte[8] { 42, 47, 120, 157, 249, 217, 17, 118 };
				using Class3 class3_ = new Class3();
				using ICryptoTransform cryptoTransform = Class12.smethod_12(bool_0: true, byte_, byte_2, class3_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class12.smethod_9(byte_3);
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
				using Class2 class2_ = new Class2();
				using ICryptoTransform cryptoTransform2 = Class12.smethod_6(bool_0: true, byte_4, class2_, byte_5);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class12.smethod_9(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_10(int int_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (stopwatch.ElapsedMilliseconds < int_0)
		{
			Application.DoEvents();
		}
		stopwatch.Stop();
	}

	static Class4.Class8 smethod_11(Class4.Class9 class9_0)
	{
		byte[] array = new byte[class9_0.int_4];
		Array.Copy(class9_0.byte_1, class9_0.int_3, array, 0, class9_0.int_4);
		return new Class4.Class8(array);
	}

	static ICryptoTransform smethod_12(bool bool_0, byte[] byte_0, byte[] byte_1, Class3 class3_0)
	{
		class3_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class3_0.object_0, new object[1] { byte_0 });
		class3_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class3_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class3_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class3_0.object_0, new object[0]);
	}

	static Class4.Class8 smethod_13(Class4.Class9 class9_0)
	{
		byte[] array = new byte[class9_0.int_3];
		Array.Copy(class9_0.byte_1, 0, array, 0, class9_0.int_3);
		return new Class4.Class8(array);
	}

	static bool smethod_14(Class4.Class5 class5_0)
	{
		switch (class5_0.int_4)
		{
		case 2:
		{
			if (class5_0.bool_0)
			{
				class5_0.int_4 = 12;
				return false;
			}
			int num = Class12.smethod_21(class5_0.class6_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class12.smethod_4(class5_0.class6_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class5_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class12.smethod_30(class5_0.class6_0);
				class5_0.int_4 = 3;
				break;
			case 1:
				class5_0.class8_0 = Class4.Class8.class8_0;
				class5_0.class8_1 = Class4.Class8.class8_1;
				class5_0.int_4 = 7;
				break;
			case 2:
				class5_0.class9_0 = new Class4.Class9();
				class5_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class5_0.int_8 = Class12.smethod_21(class5_0.class6_0, 16)) < 0)
			{
				return false;
			}
			Class12.smethod_4(class5_0.class6_0, 16);
			class5_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class12.smethod_21(class5_0.class6_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class12.smethod_4(class5_0.class6_0, 16);
			class5_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class12.smethod_23(class5_0.class7_0, class5_0.class6_0, class5_0.int_8);
			class5_0.int_8 -= num3;
			if (class5_0.int_8 == 0)
			{
				class5_0.int_4 = 2;
				return true;
			}
			return !Class12.smethod_5(class5_0.class6_0);
		}
		case 6:
			if (!Class12.smethod_15(class5_0.class9_0, class5_0.class6_0))
			{
				return false;
			}
			class5_0.class8_0 = Class12.smethod_13(class5_0.class9_0);
			class5_0.class8_1 = Class12.smethod_11(class5_0.class9_0);
			class5_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class12.smethod_3(class5_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static bool smethod_15(Class4.Class9 class9_0, Class4.Class6 class6_0)
	{
		while (true)
		{
			switch (class9_0.int_2)
			{
			case 5:
			{
				int int_ = Class4.Class9.int_1[class9_0.int_7];
				int num = Class12.smethod_21(class6_0, int_);
				if (num >= 0)
				{
					Class12.smethod_4(class6_0, int_);
					num += Class4.Class9.int_0[class9_0.int_7];
					while (num-- > 0)
					{
						class9_0.byte_1[class9_0.int_8++] = class9_0.byte_2;
					}
					if (class9_0.int_8 == class9_0.int_6)
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
				while (((num2 = Class12.smethod_0(class9_0.class8_0, class6_0)) & -16) == 0)
				{
					class9_0.byte_1[class9_0.int_8++] = (class9_0.byte_2 = (byte)num2);
					if (class9_0.int_8 == class9_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class9_0.byte_2 = 0;
					}
					class9_0.int_7 = num2 - 16;
					class9_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class9_0.int_8 < class9_0.int_5)
				{
					int num3 = Class12.smethod_21(class6_0, 3);
					if (num3 >= 0)
					{
						Class12.smethod_4(class6_0, 3);
						class9_0.byte_0[Class4.Class9.int_9[class9_0.int_8]] = (byte)num3;
						class9_0.int_8++;
						continue;
					}
					return false;
				}
				class9_0.class8_0 = new Class4.Class8(class9_0.byte_0);
				class9_0.byte_0 = null;
				class9_0.int_8 = 0;
				class9_0.int_2 = 4;
				goto case 4;
			case 2:
				class9_0.int_5 = Class12.smethod_21(class6_0, 4);
				if (class9_0.int_5 >= 0)
				{
					class9_0.int_5 += 4;
					Class12.smethod_4(class6_0, 4);
					class9_0.byte_0 = new byte[19];
					class9_0.int_8 = 0;
					class9_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class9_0.int_4 = Class12.smethod_21(class6_0, 5);
				if (class9_0.int_4 >= 0)
				{
					class9_0.int_4++;
					Class12.smethod_4(class6_0, 5);
					class9_0.int_6 = class9_0.int_3 + class9_0.int_4;
					class9_0.byte_1 = new byte[class9_0.int_6];
					class9_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class9_0.int_3 = Class12.smethod_21(class6_0, 5);
				if (class9_0.int_3 >= 0)
				{
					class9_0.int_3 += 257;
					Class12.smethod_4(class6_0, 5);
					class9_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class9_0.int_2 = 4;
		}
	}

	static byte[] smethod_16(byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		checked
		{
			int num = byte_0[byte_0.Length - 1] ^ 0x70;
			byte[] array = new byte[byte_0.Length + 1];
			int num2 = byte_0.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (byte)(byte_0[i] ^ num ^ bytes[num3]);
				num3 = ((num3 != string_0.Length - 1) ? (num3 + 1) : 0);
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
		}
	}

	static int smethod_17(Class4.Class7 class7_0)
	{
		return class7_0.int_1;
	}

	static bool smethod_18(Assembly assembly_0, Assembly assembly_1)
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

	static short smethod_19(int int_0)
	{
		return (short)((Class4.Class10.byte_0[int_0 & 0xF] << 12) | (Class4.Class10.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class4.Class10.byte_0[(int_0 >> 8) & 0xF] << 4) | Class4.Class10.byte_0[int_0 >> 12]);
	}

	static int smethod_20(Class4.Class7 class7_0)
	{
		return 32768 - class7_0.int_1;
	}

	static int smethod_21(Class4.Class6 class6_0, int int_0)
	{
		if (class6_0.int_2 < int_0)
		{
			if (class6_0.int_0 == class6_0.int_1)
			{
				return -1;
			}
			class6_0.uint_0 |= (uint)(((class6_0.byte_0[class6_0.int_0++] & 0xFF) | ((class6_0.byte_0[class6_0.int_0++] & 0xFF) << 8)) << class6_0.int_2);
			class6_0.int_2 += 16;
		}
		return (int)(class6_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_22(Class4.Stream0 stream0_0)
	{
		return Class12.smethod_2(stream0_0) | (Class12.smethod_2(stream0_0) << 16);
	}

	static int smethod_23(Class4.Class7 class7_0, Class4.Class6 class6_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class7_0.int_1), Class12.smethod_28(class6_0));
		int num = 32768 - class7_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class12.smethod_8(class6_0, class7_0.byte_0, class7_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class12.smethod_8(class6_0, class7_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class12.smethod_8(class6_0, class7_0.byte_0, class7_0.int_0, int_0);
		}
		class7_0.int_0 = (class7_0.int_0 + num2) & 0x7FFF;
		class7_0.int_1 += num2;
		return num2;
	}

	static void smethod_24(Class3 class3_0)
	{
		class3_0.type_0.GetMethod("Clear")!.Invoke(class3_0.object_0, new object[0]);
	}

	static void smethod_25(Class2 class2_0)
	{
		class2_0.type_0.GetMethod("Clear")!.Invoke(class2_0.object_0, new object[0]);
	}

	static void smethod_26(byte[] byte_0, Class4.Class8 class8_0)
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
		class8_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class8_0.short_0[Class12.smethod_19(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class12.smethod_19(num3);
			if (num11 <= 9)
			{
				do
				{
					class8_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class8_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class8_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static int smethod_27(Class4.Class6 class6_0)
	{
		return class6_0.int_2;
	}

	static int smethod_28(Class4.Class6 class6_0)
	{
		return class6_0.int_1 - class6_0.int_0 + (class6_0.int_2 >> 3);
	}

	static int smethod_29(int int_0, Class4.Class7 class7_0, int int_1, byte[] byte_0)
	{
		int num = class7_0.int_0;
		if (int_0 > class7_0.int_1)
		{
			int_0 = class7_0.int_1;
		}
		else
		{
			num = (class7_0.int_0 - class7_0.int_1 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class7_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class7_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class7_0.int_1 -= num2;
		if (class7_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_30(Class4.Class6 class6_0)
	{
		class6_0.uint_0 >>= class6_0.int_2 & 7;
		class6_0.int_2 &= -8;
	}

	static void smethod_31(Class4.Class7 class7_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class7_0.byte_0[class7_0.int_0++] = class7_0.byte_0[int_0++];
			class7_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_32(Class4.Class7 class7_0, int int_0, int int_1)
	{
		if ((class7_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class7_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class7_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class7_0.byte_0, num, class7_0.byte_0, class7_0.int_0, int_0);
				class7_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class7_0.byte_0[class7_0.int_0++] = class7_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class12.smethod_31(class7_0, num, int_0, int_1);
		}
	}

	static void smethod_33(byte[] byte_0, Class4.Class6 class6_0, int int_0, int int_1)
	{
		if (class6_0.int_0 < class6_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class6_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class6_0.int_2);
				class6_0.int_2 += 8;
			}
			class6_0.byte_0 = byte_0;
			class6_0.int_0 = int_1;
			class6_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}
}
