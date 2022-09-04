using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.MemoryManagement;
using ns2;
using ns4;

namespace ns0;

internal sealed class Class1
{
	static ICryptoTransform smethod_0(byte[] byte_0, byte[] byte_1, Class7 class7_0, bool bool_0)
	{
		class7_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class7_0.object_0, new object[1] { byte_1 });
		class7_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class7_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class7_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class7_0.object_0, new object[0]);
	}

	static bool smethod_1(Class9.Class11 class11_0)
	{
		return class11_0.int_0 == class11_0.int_1;
	}

	unsafe static void smethod_2(byte[] byte_0, Class9.Class13 class13_0)
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
		class13_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class13_0.short_0[Class1.smethod_14(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class1.smethod_14(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class13_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class13_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class13_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static Class9.Class13 smethod_3(Class9.Class14 class14_0)
	{
		byte[] array = new byte[class14_0.int_3];
		Array.Copy(class14_0.byte_1, 0, array, 0, class14_0.int_3);
		return new Class9.Class13(array);
	}

	static int smethod_4(Class9.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static int smethod_5(byte[] byte_0, int int_0, int int_1, Class9.Class12 class12_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class12_0.int_0;
		if (int_1 > class12_0.int_1)
		{
			int_1 = class12_0.int_1;
		}
		else
		{
			*(int*)ptr = (class12_0.int_0 - class12_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class12_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class12_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class12_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class12_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static int smethod_6(Class9.Class11 class11_0, int int_0)
	{
		if (class11_0.int_2 < int_0)
		{
			if (class11_0.int_0 == class11_0.int_1)
			{
				return -1;
			}
			class11_0.uint_0 |= (uint)(((class11_0.byte_0[class11_0.int_0++] & 0xFF) | ((class11_0.byte_0[class11_0.int_0++] & 0xFF) << 8)) << class11_0.int_2);
			class11_0.int_2 += 16;
		}
		return (int)(class11_0.uint_0 & ((1 << int_0) - 1));
	}

	unsafe static bool smethod_7(Class9.Class14 class14_0, Class9.Class11 class11_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class14_0.int_2)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class9.Class14.int_1[class14_0.int_7];
				int num = Class1.smethod_6(class11_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class1.smethod_37(class11_0, *(int*)((byte*)ptr + 4));
					num += Class9.Class14.int_0[class14_0.int_7];
					while (num-- > 0)
					{
						class14_0.byte_1[class14_0.int_8++] = class14_0.byte_2;
					}
					if (class14_0.int_8 == class14_0.int_6)
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
				while (((num2 = Class1.smethod_29(class14_0.class13_0, class11_0)) & -16) == 0)
				{
					class14_0.byte_1[class14_0.int_8++] = (class14_0.byte_2 = (byte)num2);
					if (class14_0.int_8 == class14_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class14_0.byte_2 = 0;
					}
					class14_0.int_7 = num2 - 16;
					class14_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class14_0.int_8 < class14_0.int_5)
				{
					*(int*)ptr = Class1.smethod_6(class11_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class1.smethod_37(class11_0, 3);
						class14_0.byte_0[Class9.Class14.int_9[class14_0.int_8]] = (byte)(*(uint*)ptr);
						class14_0.int_8++;
						continue;
					}
					return false;
				}
				class14_0.class13_0 = new Class9.Class13(class14_0.byte_0);
				class14_0.byte_0 = null;
				class14_0.int_8 = 0;
				class14_0.int_2 = 4;
				goto case 4;
			case 2:
				class14_0.int_5 = Class1.smethod_6(class11_0, 4);
				if (class14_0.int_5 >= 0)
				{
					class14_0.int_5 += 4;
					Class1.smethod_37(class11_0, 4);
					class14_0.byte_0 = new byte[19];
					class14_0.int_8 = 0;
					class14_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class14_0.int_4 = Class1.smethod_6(class11_0, 5);
				if (class14_0.int_4 >= 0)
				{
					class14_0.int_4++;
					Class1.smethod_37(class11_0, 5);
					class14_0.int_6 = class14_0.int_3 + class14_0.int_4;
					class14_0.byte_1 = new byte[class14_0.int_6];
					class14_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class14_0.int_3 = Class1.smethod_6(class11_0, 5);
				if (class14_0.int_3 >= 0)
				{
					class14_0.int_3 += 257;
					Class1.smethod_37(class11_0, 5);
					class14_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class14_0.int_2 = 4;
		}
	}

	static int smethod_8(Class9.Stream0 stream0_0)
	{
		return Class1.smethod_4(stream0_0) | (Class1.smethod_4(stream0_0) << 16);
	}

	static void smethod_9(Class9.Class12 class12_0, int int_0, int int_1)
	{
		if ((class12_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class12_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class12_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class12_0.byte_0, num, class12_0.byte_0, class12_0.int_0, int_0);
				class12_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class12_0.byte_0[class12_0.int_0++] = class12_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class1.smethod_27(class12_0, num, int_0, int_1);
		}
	}

	static void smethod_10()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class1.smethod_20;
		}
		catch
		{
		}
	}

	static int smethod_11(Class9.Class11 class11_0)
	{
		return class11_0.int_2;
	}

	static void smethod_12(int int_0, byte[] byte_0, Class9.Class11 class11_0, int int_1)
	{
		if (class11_0.int_0 < class11_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class11_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class11_0.int_2);
				class11_0.int_2 += 8;
			}
			class11_0.byte_0 = byte_0;
			class11_0.int_0 = int_0;
			class11_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_13(Class8 class8_0)
	{
		class8_0.type_0.GetMethod("Clear")!.Invoke(class8_0.object_0, new object[0]);
	}

	static short smethod_14(int int_0)
	{
		return (short)((Class9.Class15.byte_0[int_0 & 0xF] << 12) | (Class9.Class15.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class9.Class15.byte_0[(int_0 >> 8) & 0xF] << 4) | Class9.Class15.byte_0[int_0 >> 12]);
	}

	unsafe static byte[] smethod_15(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class1.smethod_21(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class9.Stream0 stream = new Class9.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class1.smethod_8(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class1.smethod_4(stream);
			*(int*)((byte*)ptr + 4) = Class1.smethod_4(stream);
			*(int*)((byte*)ptr + 8) = Class1.smethod_4(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class1.smethod_8(stream);
			Class1.smethod_8(stream);
			Class1.smethod_8(stream);
			*(int*)((byte*)ptr + 12) = Class1.smethod_8(stream);
			*(int*)((byte*)ptr + 16) = Class1.smethod_4(stream);
			*(int*)((byte*)ptr + 20) = Class1.smethod_4(stream);
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
			Class9.Class10 class10_ = new Class9.Class10(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class1.smethod_18(array, 0, array.Length, class10_);
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
				*(int*)((byte*)ptr + 28) = Class1.smethod_8(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class1.smethod_8(stream);
					*(int*)((byte*)ptr + 40) = Class1.smethod_8(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class9.Class10 class10_2 = new Class9.Class10(array3);
					Class1.smethod_18(array, *(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 40), class10_2);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 212, 62, 78, 49, 156, 104, 189, 189 };
				byte[] byte_2 = new byte[8] { 114, 160, 174, 45, 218, 123, 91, 245 };
				using Class8 class8_ = new Class8();
				using ICryptoTransform cryptoTransform = Class1.smethod_24(byte_, byte_2, bool_0: true, class8_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class1.smethod_15(byte_3);
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
				using Class7 class7_ = new Class7();
				using ICryptoTransform cryptoTransform2 = Class1.smethod_0(byte_5, byte_4, class7_, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class1.smethod_15(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static int smethod_16(Class9.Class11 class11_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class11_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class11_0.uint_0;
			class11_0.uint_0 >>= 8;
			class11_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class11_0.int_1 - class11_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class11_0.byte_0, class11_0.int_0, byte_0, int_0, int_1);
		class11_0.int_0 += int_1;
		if (((uint)(class11_0.int_0 - class11_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class11_0.uint_0 = class11_0.byte_0[class11_0.int_0++] & 0xFFu;
			class11_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	unsafe static int smethod_17(Class9.Class12 class12_0, Class9.Class11 class11_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class12_0.int_1), Class1.smethod_35(class11_0));
		*(int*)((byte*)ptr + 4) = 32768 - class12_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class1.smethod_16(class11_0, class12_0.byte_0, class12_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class1.smethod_16(class11_0, class12_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class1.smethod_16(class11_0, class12_0.byte_0, class12_0.int_0, int_0);
		}
		class12_0.int_0 = (class12_0.int_0 + *(int*)ptr) & 0x7FFF;
		class12_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	unsafe static int smethod_18(byte[] byte_0, int int_0, int int_1, Class9.Class10 class10_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class10_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class1.smethod_5(byte_0, int_0, int_1, class10_0.class12_0);
				int_0 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_1 -= *(int*)((byte*)ptr + 4);
				if (int_1 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class1.smethod_19(class10_0) || (class10_0.class12_0.int_1 > 0 && class10_0.int_4 != 11));
		return *(int*)ptr;
	}

	unsafe static bool smethod_19(Class9.Class10 class10_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class10_0.int_4)
		{
		case 2:
			if (class10_0.bool_0)
			{
				class10_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class1.smethod_6(class10_0.class11_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class1.smethod_37(class10_0.class11_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class10_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class1.smethod_33(class10_0.class11_0);
				class10_0.int_4 = 3;
				break;
			case 1:
				class10_0.class13_0 = Class9.Class13.class13_0;
				class10_0.class13_1 = Class9.Class13.class13_1;
				class10_0.int_4 = 7;
				break;
			case 2:
				class10_0.class14_0 = new Class9.Class14();
				class10_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class10_0.int_8 = Class1.smethod_6(class10_0.class11_0, 16)) < 0)
			{
				return false;
			}
			Class1.smethod_37(class10_0.class11_0, 16);
			class10_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class1.smethod_6(class10_0.class11_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class1.smethod_37(class10_0.class11_0, 16);
			class10_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class1.smethod_17(class10_0.class12_0, class10_0.class11_0, class10_0.int_8);
			class10_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class10_0.int_8 == 0)
			{
				class10_0.int_4 = 2;
				return true;
			}
			return !Class1.smethod_1(class10_0.class11_0);
		case 6:
			if (!Class1.smethod_7(class10_0.class14_0, class10_0.class11_0))
			{
				return false;
			}
			class10_0.class13_0 = Class1.smethod_3(class10_0.class14_0);
			class10_0.class13_1 = Class1.smethod_38(class10_0.class14_0);
			class10_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class1.smethod_25(class10_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static Assembly smethod_20(object sender, ResolveEventArgs e)
	{
		void* ptr = stackalloc byte[18];
		Class3.Struct0 @struct = new Class3.Struct0(e.Name);
		string s = @struct.method_0(includeVersion: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezIwY2RiMDQ4LWNiYjItNGFlOC1hN2I3LTdkNzIzOTY1NjNjYX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{6389d697-bc56-47c7-b816-2d5f23d2d149},ezIwY2RiMDQ4LWNiYjItNGFlOC1hN2I3LTdkNzIzOTY1NjNjYX0=,[z]{6389d697-bc56-47c7-b816-2d5f23d2d149}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		((byte*)ptr)[16] = 0;
		((byte*)ptr)[17] = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length - 1)
		{
			if (!(array[*(int*)ptr] == text))
			{
				*(int*)ptr += 2;
				continue;
			}
			text2 = array[*(int*)ptr + 1];
			break;
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array.Length - 1)
			{
				if (!(array[*(int*)((byte*)ptr + 4)] == text))
				{
					*(int*)((byte*)ptr + 4) += 2;
					continue;
				}
				text2 = array[*(int*)((byte*)ptr + 4) + 1];
				break;
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				*(int*)((byte*)ptr + 8) = text2.IndexOf(']');
				string text3 = text2.Substring(1, *(int*)((byte*)ptr + 8) - 1);
				((byte*)ptr)[16] = ((text3.IndexOf('z') >= 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[17] = ((text3.IndexOf('t') >= 0) ? ((byte)1) : ((byte)0));
				text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
			}
			lock (Class3.hashtable_0)
			{
				if (Class3.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class3.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class1.smethod_15(array2);
					}
					Assembly assembly = null;
					if (((byte*)ptr)[17] == 0)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							((byte*)ptr)[17] = 1;
						}
						catch (BadImageFormatException)
						{
							((byte*)ptr)[17] = 1;
						}
					}
					if (((byte*)ptr)[17] != 0)
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
								Class1.MoveFileEx(text5, (string)null, 4);
								Class1.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class3.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static bool smethod_21(Assembly assembly_0, Assembly assembly_1)
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

	static Assembly smethod_22(string string_0)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string_0);
		if (stream != null)
		{
			int count = new BinaryReader(stream).ReadInt32();
			using DeflateStream input = new DeflateStream(stream, CompressionMode.Decompress);
			return Assembly.Load(new BinaryReader(input).ReadBytes(count));
		}
		return null;
	}

	static void smethod_23()
	{
		try
		{
			Class1.smethod_10();
		}
		catch (Exception)
		{
		}
	}

	static ICryptoTransform smethod_24(byte[] byte_0, byte[] byte_1, bool bool_0, Class8 class8_0)
	{
		class8_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class8_0.object_0, new object[1] { byte_0 });
		class8_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class8_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class8_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class8_0.object_0, new object[0]);
	}

	unsafe static bool smethod_25(Class9.Class10 class10_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class1.smethod_32(class10_0.class12_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class10_0.int_4;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class1.smethod_29(class10_0.class13_0, class10_0.class11_0)) & -256) == 0)
				{
					Class1.smethod_26(class10_0.class12_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class10_0.int_6 = Class9.Class10.int_0[num2 - 257];
					class10_0.int_5 = Class9.Class10.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class10_0.class13_1 = null;
				class10_0.class13_0 = null;
				class10_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class10_0.int_5 > 0)
				{
					class10_0.int_4 = 8;
					*(int*)ptr = Class1.smethod_6(class10_0.class11_0, class10_0.int_5);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class1.smethod_37(class10_0.class11_0, class10_0.int_5);
					class10_0.int_6 += *(int*)ptr;
				}
				class10_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class1.smethod_29(class10_0.class13_1, class10_0.class11_0);
				if (num2 >= 0)
				{
					class10_0.int_7 = Class9.Class10.int_2[num2];
					class10_0.int_5 = Class9.Class10.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class10_0.int_5 > 0)
				{
					class10_0.int_4 = 10;
					*(int*)((byte*)ptr + 4) = Class1.smethod_6(class10_0.class11_0, class10_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class1.smethod_37(class10_0.class11_0, class10_0.int_5);
					class10_0.int_7 += *(int*)((byte*)ptr + 4);
				}
				Class1.smethod_9(class10_0.class12_0, class10_0.int_6, class10_0.int_7);
				num -= class10_0.int_6;
				class10_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_26(Class9.Class12 class12_0, int int_0)
	{
		if (class12_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class12_0.byte_0[class12_0.int_0++] = (byte)int_0;
		class12_0.int_0 &= 32767;
	}

	static void smethod_27(Class9.Class12 class12_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class12_0.byte_0[class12_0.int_0++] = class12_0.byte_0[int_0++];
			class12_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

	static Assembly smethod_28(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Class1.smethod_22(Convert.ToBase64String(Encoding.Default.GetBytes(resolveEventArgs_0.Name.ToLowerInvariant())));
	}

	unsafe static int smethod_29(Class9.Class13 class13_0, Class9.Class11 class11_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class1.smethod_6(class11_0, 9)) >= 0)
		{
			if ((num2 = class13_0.short_0[num]) >= 0)
			{
				Class1.smethod_37(class11_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class1.smethod_6(class11_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class13_0.short_0[*(int*)ptr | (num >> 9)];
				Class1.smethod_37(class11_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class11_0.int_2;
			num = Class1.smethod_6(class11_0, *(int*)((byte*)ptr + 8));
			num2 = class13_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class1.smethod_37(class11_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class11_0.int_2;
		num = Class1.smethod_6(class11_0, *(int*)((byte*)ptr + 12));
		num2 = class13_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class1.smethod_37(class11_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_30(Class9.Class12 class12_0)
	{
		return class12_0.int_1;
	}

	static void smethod_31()
	{
		try
		{
			Class6.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_32(Class9.Class12 class12_0)
	{
		return 32768 - class12_0.int_1;
	}

	static void smethod_33(Class9.Class11 class11_0)
	{
		class11_0.uint_0 >>= class11_0.int_2 & 7;
		class11_0.int_2 &= -8;
	}

	static void smethod_34(Class7 class7_0)
	{
		class7_0.type_0.GetMethod("Clear")!.Invoke(class7_0.object_0, new object[0]);
	}

	static int smethod_35(Class9.Class11 class11_0)
	{
		return class11_0.int_1 - class11_0.int_0 + (class11_0.int_2 >> 3);
	}

	static void smethod_36()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static void smethod_37(Class9.Class11 class11_0, int int_0)
	{
		class11_0.uint_0 >>= int_0;
		class11_0.int_2 -= int_0;
	}

	static Class9.Class13 smethod_38(Class9.Class14 class14_0)
	{
		byte[] array = new byte[class14_0.int_4];
		Array.Copy(class14_0.byte_1, class14_0.int_3, array, 0, class14_0.int_4);
		return new Class9.Class13(array);
	}
}
