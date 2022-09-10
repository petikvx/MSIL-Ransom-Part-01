using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns4;
using ns5;

namespace ns3;

internal class Class8
{
	unsafe static string smethod_0(int int_0, int int_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = int_0 ^ 0x4F3DFBAD ^ int_1;
		char[] char_ = Class6.char_1;
		*(int*)((byte*)ptr + 4) = char_[*(int*)ptr];
		string result;
		if ((result = Class6.string_0[*(int*)((byte*)ptr + 4)]) != null)
		{
			return result;
		}
		*(int*)((byte*)ptr + 8) = char_[*(int*)ptr + 1];
		*(int*)((byte*)ptr + 8) = (int)((uint)char_[*(int*)ptr + 2] << 16) + *(int*)((byte*)ptr + 8);
		char[] array = new char[*(int*)((byte*)ptr + 8)];
		char[] char_2 = Class6.char_0;
		*(int*)((byte*)ptr + 12) = char_2.Length;
		*(int*)ptr += 3;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < *(int*)((byte*)ptr + 8))
		{
			array[*(int*)((byte*)ptr + 16)] = (char)(char_[*(int*)ptr + *(int*)((byte*)ptr + 16)] ^ char_2[(*(int*)((byte*)ptr + 16) + *(int*)((byte*)ptr + 4)) % *(int*)((byte*)ptr + 12)]);
			*(int*)((byte*)ptr + 16) = 1 + *(int*)((byte*)ptr + 16);
		}
		result = new string(array);
		Class6.string_0[*(int*)((byte*)ptr + 4)] = result;
		return result;
	}

	static int smethod_1(Class14.Class16 class16_0, int int_0)
	{
		if (class16_0.int_2 < int_0)
		{
			if (class16_0.int_0 == class16_0.int_1)
			{
				return -1;
			}
			class16_0.uint_0 |= (uint)(((class16_0.byte_0[class16_0.int_0++] & 0xFF) | ((class16_0.byte_0[class16_0.int_0++] & 0xFF) << 8)) << class16_0.int_2);
			class16_0.int_2 += 16;
		}
		return (int)(class16_0.uint_0 & ((1 << int_0) - 1));
	}

	static Class14.Class18 smethod_2(Class14.Class19 class19_0)
	{
		byte[] array = new byte[class19_0.int_4];
		Array.Copy(class19_0.byte_1, class19_0.int_3, array, 0, class19_0.int_4);
		return new Class14.Class18(array);
	}

	static void smethod_3(Class12 class12_0)
	{
		class12_0.type_0.GetMethod("Clear")!.Invoke(class12_0.object_0, new object[0]);
	}

	static int smethod_4(Class14.Class17 class17_0)
	{
		return 32768 - class17_0.int_1;
	}

	unsafe static bool smethod_5(Class14.Class19 class19_0, Class14.Class16 class16_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class19_0.int_2)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class14.Class19.int_1[class19_0.int_7];
				int num = Class8.smethod_1(class16_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class8.smethod_40(class16_0, *(int*)((byte*)ptr + 4));
					num += Class14.Class19.int_0[class19_0.int_7];
					while (num-- > 0)
					{
						class19_0.byte_1[class19_0.int_8++] = class19_0.byte_2;
					}
					if (class19_0.int_8 == class19_0.int_6)
					{
						return true;
					}
					goto IL_0080;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class8.smethod_35(class19_0.class18_0, class16_0)) & -16) == 0)
				{
					class19_0.byte_1[class19_0.int_8++] = (class19_0.byte_2 = (byte)num2);
					if (class19_0.int_8 == class19_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class19_0.byte_2 = 0;
					}
					class19_0.int_7 = num2 - 16;
					class19_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class19_0.int_8 < class19_0.int_5)
				{
					*(int*)ptr = Class8.smethod_1(class16_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class8.smethod_40(class16_0, 3);
						class19_0.byte_0[Class14.Class19.int_9[class19_0.int_8]] = (byte)(*(uint*)ptr);
						class19_0.int_8++;
						continue;
					}
					return false;
				}
				class19_0.class18_0 = new Class14.Class18(class19_0.byte_0);
				class19_0.byte_0 = null;
				class19_0.int_8 = 0;
				class19_0.int_2 = 4;
				goto case 4;
			case 2:
				class19_0.int_5 = Class8.smethod_1(class16_0, 4);
				if (class19_0.int_5 >= 0)
				{
					class19_0.int_5 += 4;
					Class8.smethod_40(class16_0, 4);
					class19_0.byte_0 = new byte[19];
					class19_0.int_8 = 0;
					class19_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class19_0.int_4 = Class8.smethod_1(class16_0, 5);
				if (class19_0.int_4 >= 0)
				{
					class19_0.int_4++;
					Class8.smethod_40(class16_0, 5);
					class19_0.int_6 = class19_0.int_3 + class19_0.int_4;
					class19_0.byte_1 = new byte[class19_0.int_6];
					class19_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class19_0.int_3 = Class8.smethod_1(class16_0, 5);
				if (class19_0.int_3 >= 0)
				{
					class19_0.int_3 += 257;
					Class8.smethod_40(class16_0, 5);
					class19_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class19_0.int_2 = 4;
		}
	}

	unsafe static byte[] smethod_6(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class8.smethod_47(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class14.Stream0 stream = new Class14.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class8.smethod_12(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class8.smethod_37(stream);
			*(int*)((byte*)ptr + 4) = Class8.smethod_37(stream);
			*(int*)((byte*)ptr + 8) = Class8.smethod_37(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class8.smethod_12(stream);
			Class8.smethod_12(stream);
			Class8.smethod_12(stream);
			*(int*)((byte*)ptr + 12) = Class8.smethod_12(stream);
			*(int*)((byte*)ptr + 16) = Class8.smethod_37(stream);
			*(int*)((byte*)ptr + 20) = Class8.smethod_37(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class14.Class15 class15_ = new Class14.Class15(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class8.smethod_36(array, class15_, array.Length, 0);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class8.smethod_12(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class8.smethod_12(stream);
					*(int*)((byte*)ptr + 40) = Class8.smethod_12(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class14.Class15 class15_2 = new Class14.Class15(array3);
					Class8.smethod_36(array, class15_2, *(int*)((byte*)ptr + 40), *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 122, 151, 96, 159, 223, 45, 255, 108 };
				byte[] byte_2 = new byte[8] { 153, 220, 201, 72, 128, 184, 48, 163 };
				using Class13 class13_ = new Class13();
				using ICryptoTransform cryptoTransform = Class8.smethod_24(byte_, bool_0: true, class13_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class8.smethod_6(byte_3);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
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
				using Class12 class12_ = new Class12();
				using ICryptoTransform cryptoTransform2 = Class8.smethod_30(byte_5, class12_, byte_4, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class8.smethod_6(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static int smethod_7(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 81:
				return string_0.Length;
			}
		}
	}

	static int smethod_8(string string_0, char char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 55:
				return string_0.IndexOf(char_0);
			}
		}
	}

	unsafe static bool smethod_9(Class14.Class15 class15_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class15_0.int_4)
		{
		case 2:
			if (class15_0.bool_0)
			{
				class15_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class8.smethod_1(class15_0.class16_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class8.smethod_40(class15_0.class16_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class15_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class8.smethod_45(class15_0.class16_0);
				class15_0.int_4 = 3;
				break;
			case 1:
				class15_0.class18_0 = Class14.Class18.class18_0;
				class15_0.class18_1 = Class14.Class18.class18_1;
				class15_0.int_4 = 7;
				break;
			case 2:
				class15_0.class19_0 = new Class14.Class19();
				class15_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class15_0.int_8 = Class8.smethod_1(class15_0.class16_0, 16)) < 0)
			{
				return false;
			}
			Class8.smethod_40(class15_0.class16_0, 16);
			class15_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class8.smethod_1(class15_0.class16_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class8.smethod_40(class15_0.class16_0, 16);
			class15_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class8.smethod_41(class15_0.class17_0, class15_0.class16_0, class15_0.int_8);
			class15_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class15_0.int_8 == 0)
			{
				class15_0.int_4 = 2;
				return true;
			}
			return !Class8.smethod_38(class15_0.class16_0);
		case 6:
			if (!Class8.smethod_5(class15_0.class19_0, class15_0.class16_0))
			{
				return false;
			}
			class15_0.class18_0 = Class8.smethod_19(class15_0.class19_0);
			class15_0.class18_1 = Class8.smethod_2(class15_0.class19_0);
			class15_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class8.smethod_18(class15_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static void smethod_10(Class14.Class18 class18_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			*(int*)((byte*)ptr + 4) = byte_0[*(int*)ptr];
			if (*(int*)((byte*)ptr + 4) > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				int num = *(int*)((byte*)ptr + 4);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 512;
		*(int*)((byte*)ptr + 16) = 1;
		while (*(int*)((byte*)ptr + 16) <= 15)
		{
			array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
			*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
			if (*(int*)((byte*)ptr + 16) >= 10)
			{
				*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
				*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
			}
			(*(int*)((byte*)ptr + 16))++;
		}
		class18_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
		*(int*)((byte*)ptr + 28) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
			while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
			{
				class18_0.short_0[Class8.smethod_34(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 52) = byte_0[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class8.smethod_34(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class18_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class18_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class18_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static int smethod_11(Class14.Class16 class16_0)
	{
		return class16_0.int_2;
	}

	static int smethod_12(Class14.Stream0 stream0_0)
	{
		return Class8.smethod_37(stream0_0) | (Class8.smethod_37(stream0_0) << 16);
	}

	static object smethod_13(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	static char smethod_14(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 81:
				return string_0[int_0];
			}
		}
	}

	unsafe static int smethod_15(Class14.Class16 class16_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class16_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class16_0.uint_0;
			class16_0.uint_0 >>= 8;
			class16_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class16_0.int_1 - class16_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class16_0.byte_0, class16_0.int_0, byte_0, int_0, int_1);
		class16_0.int_0 += int_1;
		if (((uint)(class16_0.int_0 - class16_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class16_0.uint_0 = class16_0.byte_0[class16_0.int_0++] & 0xFFu;
			class16_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_16(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 11:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}

	static int smethod_17(string string_0, char char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 6:
				return Class8.smethod_8(string_0, char_0, 93, 106);
			}
		}
	}

	unsafe static bool smethod_18(Class14.Class15 class15_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class8.smethod_4(class15_0.class17_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class15_0.int_4;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class8.smethod_35(class15_0.class18_0, class15_0.class16_0)) & -256) == 0)
				{
					Class8.smethod_44(class15_0.class17_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class15_0.int_6 = Class14.Class15.int_0[num2 - 257];
					class15_0.int_5 = Class14.Class15.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class15_0.class18_1 = null;
				class15_0.class18_0 = null;
				class15_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class15_0.int_5 > 0)
				{
					class15_0.int_4 = 8;
					*(int*)ptr = Class8.smethod_1(class15_0.class16_0, class15_0.int_5);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class8.smethod_40(class15_0.class16_0, class15_0.int_5);
					class15_0.int_6 += *(int*)ptr;
				}
				class15_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class8.smethod_35(class15_0.class18_1, class15_0.class16_0);
				if (num2 >= 0)
				{
					class15_0.int_7 = Class14.Class15.int_2[num2];
					class15_0.int_5 = Class14.Class15.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class15_0.int_5 > 0)
				{
					class15_0.int_4 = 10;
					*(int*)((byte*)ptr + 4) = Class8.smethod_1(class15_0.class16_0, class15_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class8.smethod_40(class15_0.class16_0, class15_0.int_5);
					class15_0.int_7 += *(int*)((byte*)ptr + 4);
				}
				Class8.smethod_39(class15_0.class17_0, class15_0.int_6, class15_0.int_7);
				num -= class15_0.int_6;
				class15_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static Class14.Class18 smethod_19(Class14.Class19 class19_0)
	{
		byte[] array = new byte[class19_0.int_3];
		Array.Copy(class19_0.byte_1, 0, array, 0, class19_0.int_3);
		return new Class14.Class18(array);
	}

	static void smethod_20(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				ProjectData.EndApp();
				return;
			}
		}
	}

	static void smethod_21(Class13 class13_0)
	{
		class13_0.type_0.GetMethod("Clear")!.Invoke(class13_0.object_0, new object[0]);
	}

	unsafe static byte[] smethod_22(string string_0)
	{
		void* ptr = stackalloc byte[16];
		byte[] array = new byte[checked((Class8.smethod_27(string_0, 867, 816) >> 0) + 1)];
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 12) = checked(Class8.smethod_27(string_0, 234, 185) - 1);
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 12))
		{
			*(int*)ptr = Class8.smethod_17(Class8.smethod_0(1329378276, 3), Class8.smethod_42(Class8.smethod_28(string_0, *(int*)((byte*)ptr + 4), 950, 964), 526, 590), 402, 404);
			checked
			{
				*unchecked((int*)((byte*)ptr + 8)) = Class8.smethod_17(Class8.smethod_0(1329378287, 8), Class8.smethod_42(Class8.smethod_28(string_0, *unchecked((int*)((byte*)ptr + 4)) + 1, 143, 253), 700, 764), 951, 945);
				if (unchecked(*(int*)ptr != -1 && *(int*)((byte*)ptr + 8) != -1))
				{
					array[*unchecked((int*)((byte*)ptr + 4)) >> 1] = (byte)unchecked((*(int*)ptr << 4) | *(int*)((byte*)ptr + 8));
					*unchecked((int*)((byte*)ptr + 4)) += 2;
					continue;
				}
				throw new ArgumentException(Class8.smethod_0(1329378294, 6), Class8.smethod_0(1329378090, 2));
			}
		}
		return array;
	}

	static int smethod_23(Class14.Class17 class17_0)
	{
		return class17_0.int_1;
	}

	static ICryptoTransform smethod_24(byte[] byte_0, bool bool_0, Class13 class13_0, byte[] byte_1)
	{
		class13_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_0 });
		class13_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class13_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class13_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class13_0.object_0, new object[0]);
	}

	static void smethod_25(Class14.Class17 class17_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class17_0.byte_0[class17_0.int_0++] = class17_0.byte_0[int_0++];
			class17_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	unsafe static int smethod_26(byte[] byte_0, Class14.Class17 class17_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class17_0.int_0;
		if (int_1 > class17_0.int_1)
		{
			int_1 = class17_0.int_1;
		}
		else
		{
			*(int*)ptr = (class17_0.int_0 - class17_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class17_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class17_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class17_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class17_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static int smethod_27(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 83:
				return Class8.smethod_7(string_0, 422, 503);
			}
		}
	}

	static char smethod_28(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 114:
				return Class8.smethod_14(string_0, int_0, 607, 526);
			}
		}
	}

	static int smethod_29(Class14.Class16 class16_0)
	{
		return class16_0.int_1 - class16_0.int_0 + (class16_0.int_2 >> 3);
	}

	static ICryptoTransform smethod_30(byte[] byte_0, Class12 class12_0, byte[] byte_1, bool bool_0)
	{
		class12_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class12_0.object_0, new object[1] { byte_1 });
		class12_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class12_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class12_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class12_0.object_0, new object[0]);
	}

	static MethodInfo smethod_31(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 111:
				return Class8.smethod_43(assembly_0, 5, 116);
			}
		}
	}

	static char smethod_32(char char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return char.ToUpperInvariant(char_0);
			}
		}
	}

	static object smethod_33(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return Class8.smethod_13(methodBase_0, object_0, object_1, 220, 173);
			}
		}
	}

	static short smethod_34(int int_0)
	{
		return (short)((Class14.Class20.byte_0[int_0 & 0xF] << 12) | (Class14.Class20.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class14.Class20.byte_0[(int_0 >> 8) & 0xF] << 4) | Class14.Class20.byte_0[int_0 >> 12]);
	}

	unsafe static int smethod_35(Class14.Class18 class18_0, Class14.Class16 class16_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class8.smethod_1(class16_0, 9)) >= 0)
		{
			if ((num2 = class18_0.short_0[num]) >= 0)
			{
				Class8.smethod_40(class16_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class8.smethod_1(class16_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class18_0.short_0[*(int*)ptr | (num >> 9)];
				Class8.smethod_40(class16_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class16_0.int_2;
			num = Class8.smethod_1(class16_0, *(int*)((byte*)ptr + 8));
			num2 = class18_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class8.smethod_40(class16_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class16_0.int_2;
		num = Class8.smethod_1(class16_0, *(int*)((byte*)ptr + 12));
		num2 = class18_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class8.smethod_40(class16_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	unsafe static int smethod_36(byte[] byte_0, Class14.Class15 class15_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class15_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class8.smethod_26(byte_0, class15_0.class17_0, int_1, int_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class8.smethod_9(class15_0) || (class15_0.class17_0.int_1 > 0 && class15_0.int_4 != 11));
		return *(int*)ptr;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern void Sleep(long long_0);

	static int smethod_37(Class14.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static bool smethod_38(Class14.Class16 class16_0)
	{
		return class16_0.int_0 == class16_0.int_1;
	}

	static void smethod_39(Class14.Class17 class17_0, int int_0, int int_1)
	{
		if ((class17_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class17_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class17_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class17_0.byte_0, num, class17_0.byte_0, class17_0.int_0, int_0);
				class17_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class17_0.byte_0[class17_0.int_0++] = class17_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class8.smethod_25(class17_0, num, int_0, int_1);
		}
	}

	static void smethod_40(Class14.Class16 class16_0, int int_0)
	{
		class16_0.uint_0 >>= int_0;
		class16_0.int_2 -= int_0;
	}

	unsafe static int smethod_41(Class14.Class17 class17_0, Class14.Class16 class16_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class17_0.int_1), Class8.smethod_29(class16_0));
		*(int*)((byte*)ptr + 4) = 32768 - class17_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class8.smethod_15(class16_0, class17_0.byte_0, class17_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class8.smethod_15(class16_0, class17_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class8.smethod_15(class16_0, class17_0.byte_0, class17_0.int_0, int_0);
		}
		class17_0.int_0 = (class17_0.int_0 + *(int*)ptr) & 0x7FFF;
		class17_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static char smethod_42(char char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return Class8.smethod_32(char_0, 691, 743);
			}
		}
	}

	static MethodInfo smethod_43(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 113:
				return assembly_0.EntryPoint;
			}
		}
	}

	static void smethod_44(Class14.Class17 class17_0, int int_0)
	{
		if (class17_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class17_0.byte_0[class17_0.int_0++] = (byte)int_0;
		class17_0.int_0 &= 32767;
	}

	static void smethod_45(Class14.Class16 class16_0)
	{
		class16_0.uint_0 >>= class16_0.int_2 & 7;
		class16_0.int_2 &= -8;
	}

	static void smethod_46(int int_0, Class14.Class16 class16_0, int int_1, byte[] byte_0)
	{
		if (class16_0.int_0 < class16_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class16_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class16_0.int_2);
				class16_0.int_2 += 8;
			}
			class16_0.byte_0 = byte_0;
			class16_0.int_0 = int_1;
			class16_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_47(Assembly assembly_0, Assembly assembly_1)
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

	static Assembly smethod_48(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				return Assembly.Load(byte_0);
			}
		}
	}

	static Assembly smethod_49(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				return Class8.smethod_48(byte_0, 919, 976);
			}
		}
	}
}
