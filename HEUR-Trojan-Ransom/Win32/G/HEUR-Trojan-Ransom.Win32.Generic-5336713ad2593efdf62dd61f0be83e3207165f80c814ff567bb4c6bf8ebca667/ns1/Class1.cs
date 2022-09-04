using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns2;

namespace ns1;

internal class Class1
{
	static void smethod_0(Class5.Class8 class8_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class8_0.byte_0[class8_0.int_0++] = class8_0.byte_0[int_0++];
			class8_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static byte[] smethod_1(string string_0, byte[] byte_0)
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

	static void smethod_2(Class5.Class7 class7_0, int int_0)
	{
		class7_0.uint_0 >>= int_0;
		class7_0.int_2 -= int_0;
	}

	static bool smethod_3(Class5.Class7 class7_0)
	{
		return class7_0.int_0 == class7_0.int_1;
	}

	static void smethod_4(int int_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (stopwatch.ElapsedMilliseconds < int_0)
		{
			Application.DoEvents();
		}
		stopwatch.Stop();
	}

	static void smethod_5(Class3 class3_0)
	{
		class3_0.type_0.GetMethod("Clear")!.Invoke(class3_0.object_0, new object[0]);
	}

	static void smethod_6(Class4 class4_0)
	{
		class4_0.type_0.GetMethod("Clear")!.Invoke(class4_0.object_0, new object[0]);
	}

	static int smethod_7(Class5.Class8 class8_0, Class5.Class7 class7_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class8_0.int_1), Class1.smethod_11(class7_0));
		int num = 32768 - class8_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class1.smethod_27(class7_0, class8_0.byte_0, class8_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class1.smethod_27(class7_0, class8_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class1.smethod_27(class7_0, class8_0.byte_0, class8_0.int_0, int_0);
		}
		class8_0.int_0 = (class8_0.int_0 + num2) & 0x7FFF;
		class8_0.int_1 += num2;
		return num2;
	}

	static bool smethod_8(Assembly assembly_0, Assembly assembly_1)
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

	static bool smethod_9(Class5.Class6 class6_0)
	{
		int num = Class1.smethod_32(class6_0.class8_0);
		while (num >= 258)
		{
			switch (class6_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class1.smethod_17(class6_0.class9_0, class6_0.class7_0)) & -256) == 0)
				{
					Class1.smethod_30(class6_0.class8_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class6_0.int_6 = Class5.Class6.int_0[num2 - 257];
					class6_0.int_5 = Class5.Class6.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class6_0.class9_1 = null;
				class6_0.class9_0 = null;
				class6_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class6_0.int_5 > 0)
				{
					class6_0.int_4 = 8;
					int num4 = Class1.smethod_12(class6_0.class7_0, class6_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class1.smethod_2(class6_0.class7_0, class6_0.int_5);
					class6_0.int_6 += num4;
				}
				class6_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class1.smethod_17(class6_0.class9_1, class6_0.class7_0);
				if (num2 >= 0)
				{
					class6_0.int_7 = Class5.Class6.int_2[num2];
					class6_0.int_5 = Class5.Class6.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class6_0.int_5 > 0)
				{
					class6_0.int_4 = 10;
					int num3 = Class1.smethod_12(class6_0.class7_0, class6_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class1.smethod_2(class6_0.class7_0, class6_0.int_5);
					class6_0.int_7 += num3;
				}
				Class1.smethod_10(class6_0.class8_0, class6_0.int_6, class6_0.int_7);
				num -= class6_0.int_6;
				class6_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_10(Class5.Class8 class8_0, int int_0, int int_1)
	{
		if ((class8_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class8_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class8_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class8_0.byte_0, num, class8_0.byte_0, class8_0.int_0, int_0);
				class8_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class8_0.byte_0[class8_0.int_0++] = class8_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class1.smethod_0(class8_0, num, int_0, int_1);
		}
	}

	static int smethod_11(Class5.Class7 class7_0)
	{
		return class7_0.int_1 - class7_0.int_0 + (class7_0.int_2 >> 3);
	}

	static int smethod_12(Class5.Class7 class7_0, int int_0)
	{
		if (class7_0.int_2 < int_0)
		{
			if (class7_0.int_0 == class7_0.int_1)
			{
				return -1;
			}
			class7_0.uint_0 |= (uint)(((class7_0.byte_0[class7_0.int_0++] & 0xFF) | ((class7_0.byte_0[class7_0.int_0++] & 0xFF) << 8)) << class7_0.int_2);
			class7_0.int_2 += 16;
		}
		return (int)(class7_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_13(Class5.Class7 class7_0)
	{
		return class7_0.int_2;
	}

	static bool smethod_14(Class5.Class6 class6_0)
	{
		switch (class6_0.int_4)
		{
		case 2:
		{
			if (class6_0.bool_0)
			{
				class6_0.int_4 = 12;
				return false;
			}
			int num = Class1.smethod_12(class6_0.class7_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class1.smethod_2(class6_0.class7_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class6_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class1.smethod_20(class6_0.class7_0);
				class6_0.int_4 = 3;
				break;
			case 1:
				class6_0.class9_0 = Class5.Class9.class9_0;
				class6_0.class9_1 = Class5.Class9.class9_1;
				class6_0.int_4 = 7;
				break;
			case 2:
				class6_0.class10_0 = new Class5.Class10();
				class6_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class6_0.int_8 = Class1.smethod_12(class6_0.class7_0, 16)) < 0)
			{
				return false;
			}
			Class1.smethod_2(class6_0.class7_0, 16);
			class6_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class1.smethod_12(class6_0.class7_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class1.smethod_2(class6_0.class7_0, 16);
			class6_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class1.smethod_7(class6_0.class8_0, class6_0.class7_0, class6_0.int_8);
			class6_0.int_8 -= num3;
			if (class6_0.int_8 == 0)
			{
				class6_0.int_4 = 2;
				return true;
			}
			return !Class1.smethod_3(class6_0.class7_0);
		}
		case 6:
			if (!Class1.smethod_28(class6_0.class10_0, class6_0.class7_0))
			{
				return false;
			}
			class6_0.class9_0 = Class1.smethod_16(class6_0.class10_0);
			class6_0.class9_1 = Class1.smethod_25(class6_0.class10_0);
			class6_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class1.smethod_9(class6_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static byte[] smethod_15(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class1.smethod_8(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class5.Stream0 stream = new Class5.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class1.smethod_19(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class1.smethod_29(stream);
			int num3 = Class1.smethod_29(stream);
			int num4 = Class1.smethod_29(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class1.smethod_19(stream);
			Class1.smethod_19(stream);
			Class1.smethod_19(stream);
			int num5 = Class1.smethod_19(stream);
			int num6 = Class1.smethod_29(stream);
			int num7 = Class1.smethod_29(stream);
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
			Class5.Class6 class6_ = new Class5.Class6(array2);
			array = new byte[num5];
			Class1.smethod_31(array, 0, array.Length, class6_);
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
				int num9 = Class1.smethod_19(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class1.smethod_19(stream);
					num11 = Class1.smethod_19(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class5.Class6 class6_2 = new Class5.Class6(array3);
					Class1.smethod_31(array, i, num11, class6_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 80, 64, 88, 238, 165, 103, 120, 101 };
				byte[] byte_2 = new byte[8] { 203, 173, 155, 239, 154, 2, 5, 105 };
				using Class4 class4_ = new Class4();
				using ICryptoTransform cryptoTransform = Class1.smethod_21(bool_0: true, byte_2, byte_, class4_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class1.smethod_15(byte_3);
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
				using Class3 class3_ = new Class3();
				using ICryptoTransform cryptoTransform2 = Class1.smethod_22(bool_0: true, byte_5, byte_4, class3_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class1.smethod_15(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static Class5.Class9 smethod_16(Class5.Class10 class10_0)
	{
		byte[] array = new byte[class10_0.int_3];
		Array.Copy(class10_0.byte_1, 0, array, 0, class10_0.int_3);
		return new Class5.Class9(array);
	}

	static int smethod_17(Class5.Class9 class9_0, Class5.Class7 class7_0)
	{
		int num;
		int num2;
		if ((num = Class1.smethod_12(class7_0, 9)) >= 0)
		{
			if ((num2 = class9_0.short_0[num]) >= 0)
			{
				Class1.smethod_2(class7_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class1.smethod_12(class7_0, int_)) >= 0)
			{
				num2 = class9_0.short_0[num3 | (num >> 9)];
				Class1.smethod_2(class7_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class7_0.int_2;
			num = Class1.smethod_12(class7_0, int_2);
			num2 = class9_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class1.smethod_2(class7_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class7_0.int_2;
		num = Class1.smethod_12(class7_0, int_3);
		num2 = class9_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class1.smethod_2(class7_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_18(Class5.Class8 class8_0)
	{
		return class8_0.int_1;
	}

	static int smethod_19(Class5.Stream0 stream0_0)
	{
		return Class1.smethod_29(stream0_0) | (Class1.smethod_29(stream0_0) << 16);
	}

	static void smethod_20(Class5.Class7 class7_0)
	{
		class7_0.uint_0 >>= class7_0.int_2 & 7;
		class7_0.int_2 &= -8;
	}

	static ICryptoTransform smethod_21(bool bool_0, byte[] byte_0, byte[] byte_1, Class4 class4_0)
	{
		class4_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class4_0.object_0, new object[1] { byte_1 });
		class4_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class4_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class4_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class4_0.object_0, new object[0]);
	}

	static ICryptoTransform smethod_22(bool bool_0, byte[] byte_0, byte[] byte_1, Class3 class3_0)
	{
		class3_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class3_0.object_0, new object[1] { byte_1 });
		class3_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class3_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class3_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class3_0.object_0, new object[0]);
	}

	static short smethod_23(int int_0)
	{
		return (short)((Class5.Class11.byte_0[int_0 & 0xF] << 12) | (Class5.Class11.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class5.Class11.byte_0[(int_0 >> 8) & 0xF] << 4) | Class5.Class11.byte_0[int_0 >> 12]);
	}

	static void smethod_24(int int_0, int int_1, Class5.Class7 class7_0, byte[] byte_0)
	{
		if (class7_0.int_0 < class7_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class7_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class7_0.int_2);
				class7_0.int_2 += 8;
			}
			class7_0.byte_0 = byte_0;
			class7_0.int_0 = int_1;
			class7_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static Class5.Class9 smethod_25(Class5.Class10 class10_0)
	{
		byte[] array = new byte[class10_0.int_4];
		Array.Copy(class10_0.byte_1, class10_0.int_3, array, 0, class10_0.int_4);
		return new Class5.Class9(array);
	}

	static int smethod_26(int int_0, byte[] byte_0, Class5.Class8 class8_0, int int_1)
	{
		int num = class8_0.int_0;
		if (int_0 > class8_0.int_1)
		{
			int_0 = class8_0.int_1;
		}
		else
		{
			num = (class8_0.int_0 - class8_0.int_1 + int_0) & 0x7FFF;
		}
		int num2 = int_0;
		int num3 = int_0 - num;
		if (num3 > 0)
		{
			Array.Copy(class8_0.byte_0, 32768 - num3, byte_0, int_1, num3);
			int_1 += num3;
			int_0 = num;
		}
		Array.Copy(class8_0.byte_0, num - int_0, byte_0, int_1, int_0);
		class8_0.int_1 -= num2;
		if (class8_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static int smethod_27(Class5.Class7 class7_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class7_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class7_0.uint_0;
			class7_0.uint_0 >>= 8;
			class7_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class7_0.int_1 - class7_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class7_0.byte_0, class7_0.int_0, byte_0, int_0, int_1);
		class7_0.int_0 += int_1;
		if (((uint)(class7_0.int_0 - class7_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class7_0.uint_0 = class7_0.byte_0[class7_0.int_0++] & 0xFFu;
			class7_0.int_2 = 8;
		}
		return num + int_1;
	}

	static bool smethod_28(Class5.Class10 class10_0, Class5.Class7 class7_0)
	{
		while (true)
		{
			switch (class10_0.int_2)
			{
			case 5:
			{
				int int_ = Class5.Class10.int_1[class10_0.int_7];
				int num = Class1.smethod_12(class7_0, int_);
				if (num >= 0)
				{
					Class1.smethod_2(class7_0, int_);
					num += Class5.Class10.int_0[class10_0.int_7];
					while (num-- > 0)
					{
						class10_0.byte_1[class10_0.int_8++] = class10_0.byte_2;
					}
					if (class10_0.int_8 == class10_0.int_6)
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
				while (((num2 = Class1.smethod_17(class10_0.class9_0, class7_0)) & -16) == 0)
				{
					class10_0.byte_1[class10_0.int_8++] = (class10_0.byte_2 = (byte)num2);
					if (class10_0.int_8 == class10_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class10_0.byte_2 = 0;
					}
					class10_0.int_7 = num2 - 16;
					class10_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class10_0.int_8 < class10_0.int_5)
				{
					int num3 = Class1.smethod_12(class7_0, 3);
					if (num3 >= 0)
					{
						Class1.smethod_2(class7_0, 3);
						class10_0.byte_0[Class5.Class10.int_9[class10_0.int_8]] = (byte)num3;
						class10_0.int_8++;
						continue;
					}
					return false;
				}
				class10_0.class9_0 = new Class5.Class9(class10_0.byte_0);
				class10_0.byte_0 = null;
				class10_0.int_8 = 0;
				class10_0.int_2 = 4;
				goto case 4;
			case 2:
				class10_0.int_5 = Class1.smethod_12(class7_0, 4);
				if (class10_0.int_5 >= 0)
				{
					class10_0.int_5 += 4;
					Class1.smethod_2(class7_0, 4);
					class10_0.byte_0 = new byte[19];
					class10_0.int_8 = 0;
					class10_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class10_0.int_4 = Class1.smethod_12(class7_0, 5);
				if (class10_0.int_4 >= 0)
				{
					class10_0.int_4++;
					Class1.smethod_2(class7_0, 5);
					class10_0.int_6 = class10_0.int_3 + class10_0.int_4;
					class10_0.byte_1 = new byte[class10_0.int_6];
					class10_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class10_0.int_3 = Class1.smethod_12(class7_0, 5);
				if (class10_0.int_3 >= 0)
				{
					class10_0.int_3 += 257;
					Class1.smethod_2(class7_0, 5);
					class10_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class10_0.int_2 = 4;
		}
	}

	static int smethod_29(Class5.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_30(Class5.Class8 class8_0, int int_0)
	{
		if (class8_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class8_0.byte_0[class8_0.int_0++] = (byte)int_0;
		class8_0.int_0 &= 32767;
	}

	static int smethod_31(byte[] byte_0, int int_0, int int_1, Class5.Class6 class6_0)
	{
		int num = 0;
		do
		{
			if (class6_0.int_4 != 11)
			{
				int num2 = Class1.smethod_26(int_1, byte_0, class6_0.class8_0, int_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class1.smethod_14(class6_0) || (class6_0.class8_0.int_1 > 0 && class6_0.int_4 != 11));
		return num;
	}

	static int smethod_32(Class5.Class8 class8_0)
	{
		return 32768 - class8_0.int_1;
	}

	static void smethod_33(Class5.Class9 class9_0, byte[] byte_0)
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
		class9_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class9_0.short_0[Class1.smethod_23(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class1.smethod_23(num3);
			if (num11 <= 9)
			{
				do
				{
					class9_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class9_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class9_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}
}
