using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns5;

namespace ns1;

internal class Class1
{
	static int smethod_0(Class6.Class9 class9_0)
	{
		return 32768 - class9_0.int_1;
	}

	static int smethod_1(Class6.Class8 class8_0, int int_0)
	{
		if (class8_0.int_2 < int_0)
		{
			if (class8_0.int_0 == class8_0.int_1)
			{
				return -1;
			}
			class8_0.uint_0 |= (uint)(((class8_0.byte_0[class8_0.int_0++] & 0xFF) | ((class8_0.byte_0[class8_0.int_0++] & 0xFF) << 8)) << class8_0.int_2);
			class8_0.int_2 += 16;
		}
		return (int)(class8_0.uint_0 & ((1 << int_0) - 1));
	}

	unsafe static int smethod_2(Class6.Class9 class9_0, Class6.Class8 class8_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class9_0.int_1), Class1.smethod_29(class8_0));
		*(int*)((byte*)ptr + 4) = 32768 - class9_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class1.smethod_4(class8_0, class9_0.byte_0, class9_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class1.smethod_4(class8_0, class9_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class1.smethod_4(class8_0, class9_0.byte_0, class9_0.int_0, int_0);
		}
		class9_0.int_0 = (class9_0.int_0 + *(int*)ptr) & 0x7FFF;
		class9_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static int smethod_3(Class6.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static int smethod_4(Class6.Class8 class8_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class8_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class8_0.uint_0;
			class8_0.uint_0 >>= 8;
			class8_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class8_0.int_1 - class8_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class8_0.byte_0, class8_0.int_0, byte_0, int_0, int_1);
		class8_0.int_0 += int_1;
		if (((uint)(class8_0.int_0 - class8_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class8_0.uint_0 = class8_0.byte_0[class8_0.int_0++] & 0xFFu;
			class8_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_5(int int_0, Class6.Class8 class8_0, int int_1, byte[] byte_0)
	{
		if (class8_0.int_0 < class8_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class8_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class8_0.int_2);
				class8_0.int_2 += 8;
			}
			class8_0.byte_0 = byte_0;
			class8_0.int_0 = int_0;
			class8_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	unsafe static byte[] smethod_6(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class1.smethod_12(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class6.Stream0 stream = new Class6.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class1.smethod_20(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class1.smethod_3(stream);
			*(int*)((byte*)ptr + 4) = Class1.smethod_3(stream);
			*(int*)((byte*)ptr + 8) = Class1.smethod_3(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class1.smethod_20(stream);
			Class1.smethod_20(stream);
			Class1.smethod_20(stream);
			*(int*)((byte*)ptr + 12) = Class1.smethod_20(stream);
			*(int*)((byte*)ptr + 16) = Class1.smethod_3(stream);
			*(int*)((byte*)ptr + 20) = Class1.smethod_3(stream);
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
			Class6.Class7 class7_ = new Class6.Class7(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class1.smethod_28(0, class7_, array.Length, array);
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
				*(int*)((byte*)ptr + 28) = Class1.smethod_20(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class1.smethod_20(stream);
					*(int*)((byte*)ptr + 40) = Class1.smethod_20(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class6.Class7 class7_2 = new Class6.Class7(array3);
					Class1.smethod_28(*(int*)((byte*)ptr + 32), class7_2, *(int*)((byte*)ptr + 40), array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 11, 147, 232, 162, 52, 86, 116, 152 };
				byte[] byte_2 = new byte[8] { 33, 171, 166, 147, 136, 194, 9, 152 };
				using Class5 class5_ = new Class5();
				using ICryptoTransform cryptoTransform = Class1.smethod_16(byte_, byte_2, bool_0: true, class5_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class1.smethod_6(byte_3);
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
				using Class4 class4_ = new Class4();
				using ICryptoTransform cryptoTransform2 = Class1.smethod_31(byte_4, bool_0: true, byte_5, class4_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class1.smethod_6(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static bool smethod_7(Class6.Class11 class11_0, Class6.Class8 class8_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class11_0.int_2)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class6.Class11.int_1[class11_0.int_7];
				int num = Class1.smethod_1(class8_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class1.smethod_8(class8_0, *(int*)((byte*)ptr + 4));
					num += Class6.Class11.int_0[class11_0.int_7];
					while (num-- > 0)
					{
						class11_0.byte_1[class11_0.int_8++] = class11_0.byte_2;
					}
					if (class11_0.int_8 == class11_0.int_6)
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
				while (((num2 = Class1.smethod_32(class11_0.class10_0, class8_0)) & -16) == 0)
				{
					class11_0.byte_1[class11_0.int_8++] = (class11_0.byte_2 = (byte)num2);
					if (class11_0.int_8 == class11_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class11_0.byte_2 = 0;
					}
					class11_0.int_7 = num2 - 16;
					class11_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class11_0.int_8 < class11_0.int_5)
				{
					*(int*)ptr = Class1.smethod_1(class8_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class1.smethod_8(class8_0, 3);
						class11_0.byte_0[Class6.Class11.int_9[class11_0.int_8]] = (byte)(*(uint*)ptr);
						class11_0.int_8++;
						continue;
					}
					return false;
				}
				class11_0.class10_0 = new Class6.Class10(class11_0.byte_0);
				class11_0.byte_0 = null;
				class11_0.int_8 = 0;
				class11_0.int_2 = 4;
				goto case 4;
			case 2:
				class11_0.int_5 = Class1.smethod_1(class8_0, 4);
				if (class11_0.int_5 >= 0)
				{
					class11_0.int_5 += 4;
					Class1.smethod_8(class8_0, 4);
					class11_0.byte_0 = new byte[19];
					class11_0.int_8 = 0;
					class11_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class11_0.int_4 = Class1.smethod_1(class8_0, 5);
				if (class11_0.int_4 >= 0)
				{
					class11_0.int_4++;
					Class1.smethod_8(class8_0, 5);
					class11_0.int_6 = class11_0.int_3 + class11_0.int_4;
					class11_0.byte_1 = new byte[class11_0.int_6];
					class11_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class11_0.int_3 = Class1.smethod_1(class8_0, 5);
				if (class11_0.int_3 >= 0)
				{
					class11_0.int_3 += 257;
					Class1.smethod_8(class8_0, 5);
					class11_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class11_0.int_2 = 4;
		}
	}

	static void smethod_8(Class6.Class8 class8_0, int int_0)
	{
		class8_0.uint_0 >>= int_0;
		class8_0.int_2 -= int_0;
	}

	static void smethod_9(Class4 class4_0)
	{
		class4_0.type_0.GetMethod("Clear")!.Invoke(class4_0.object_0, new object[0]);
	}

	static Class6.Class10 smethod_10(Class6.Class11 class11_0)
	{
		byte[] array = new byte[class11_0.int_3];
		Array.Copy(class11_0.byte_1, 0, array, 0, class11_0.int_3);
		return new Class6.Class10(array);
	}

	static void smethod_11(Class6.Class9 class9_0, int int_0)
	{
		if (class9_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class9_0.byte_0[class9_0.int_0++] = (byte)int_0;
		class9_0.int_0 &= 32767;
	}

	static bool smethod_12(Assembly assembly_0, Assembly assembly_1)
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

	static bool smethod_13(Class6.Class8 class8_0)
	{
		return class8_0.int_0 == class8_0.int_1;
	}

	static Class6.Class10 smethod_14(Class6.Class11 class11_0)
	{
		byte[] array = new byte[class11_0.int_4];
		Array.Copy(class11_0.byte_1, class11_0.int_3, array, 0, class11_0.int_4);
		return new Class6.Class10(array);
	}

	static void smethod_15(Class6.Class9 class9_0, int int_0, int int_1)
	{
		if ((class9_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class9_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class9_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class9_0.byte_0, num, class9_0.byte_0, class9_0.int_0, int_0);
				class9_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class9_0.byte_0[class9_0.int_0++] = class9_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class1.smethod_24(class9_0, num, int_0, int_1);
		}
	}

	static ICryptoTransform smethod_16(byte[] byte_0, byte[] byte_1, bool bool_0, Class5 class5_0)
	{
		class5_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class5_0.object_0, new object[1] { byte_0 });
		class5_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class5_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class5_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class5_0.object_0, new object[0]);
	}

	unsafe static byte[] smethod_17(string string_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[16];
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		*(int*)ptr = byte_0[checked(byte_0.Length - 1)] ^ 0x70;
		byte[] array = new byte[checked(byte_0.Length + 1)];
		byte* num = (byte*)ptr + 8;
		*(int*)((byte*)ptr + 12) = checked(byte_0.Length - 1);
		*(int*)num = 0;
		checked
		{
			while (unchecked(*(int*)((byte*)ptr + 8) <= *(int*)((byte*)ptr + 12)))
			{
				array[*unchecked((int*)((byte*)ptr + 8))] = (byte)unchecked(byte_0[*(int*)((byte*)ptr + 8)] ^ *(int*)ptr ^ bytes[*(int*)((byte*)ptr + 4)]);
				if (*unchecked((int*)((byte*)ptr + 4)) == string_0.Length - 1)
				{
					*unchecked((int*)((byte*)ptr + 4)) = 0;
				}
				else
				{
					(*unchecked((int*)((byte*)ptr + 4)))++;
				}
				(*unchecked((int*)((byte*)ptr + 8)))++;
			}
			return (byte[])Utils.CopyArray((Array)array, (Array)new byte[byte_0.Length - 2 + 1]);
		}
	}

	unsafe static int smethod_18(int int_0, byte[] byte_0, Class6.Class9 class9_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class9_0.int_0;
		if (int_0 > class9_0.int_1)
		{
			int_0 = class9_0.int_1;
		}
		else
		{
			*(int*)ptr = (class9_0.int_0 - class9_0.int_1 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class9_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class9_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class9_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class9_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_19(int int_0)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		while (stopwatch.ElapsedMilliseconds < int_0)
		{
			Application.DoEvents();
		}
		stopwatch.Stop();
	}

	static int smethod_20(Class6.Stream0 stream0_0)
	{
		return Class1.smethod_3(stream0_0) | (Class1.smethod_3(stream0_0) << 16);
	}

	unsafe static void smethod_21(Class6.Class10 class10_0, byte[] byte_0)
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
		class10_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class10_0.short_0[Class1.smethod_25(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class1.smethod_25(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class10_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class10_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class10_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	unsafe static bool smethod_22(Class6.Class7 class7_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class7_0.int_4)
		{
		case 2:
			if (class7_0.bool_0)
			{
				class7_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class1.smethod_1(class7_0.class8_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class1.smethod_8(class7_0.class8_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class7_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class1.smethod_23(class7_0.class8_0);
				class7_0.int_4 = 3;
				break;
			case 1:
				class7_0.class10_0 = Class6.Class10.class10_0;
				class7_0.class10_1 = Class6.Class10.class10_1;
				class7_0.int_4 = 7;
				break;
			case 2:
				class7_0.class11_0 = new Class6.Class11();
				class7_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class7_0.int_8 = Class1.smethod_1(class7_0.class8_0, 16)) < 0)
			{
				return false;
			}
			Class1.smethod_8(class7_0.class8_0, 16);
			class7_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class1.smethod_1(class7_0.class8_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class1.smethod_8(class7_0.class8_0, 16);
			class7_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class1.smethod_2(class7_0.class9_0, class7_0.class8_0, class7_0.int_8);
			class7_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class7_0.int_8 == 0)
			{
				class7_0.int_4 = 2;
				return true;
			}
			return !Class1.smethod_13(class7_0.class8_0);
		case 6:
			if (!Class1.smethod_7(class7_0.class11_0, class7_0.class8_0))
			{
				return false;
			}
			class7_0.class10_0 = Class1.smethod_10(class7_0.class11_0);
			class7_0.class10_1 = Class1.smethod_14(class7_0.class11_0);
			class7_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class1.smethod_27(class7_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_23(Class6.Class8 class8_0)
	{
		class8_0.uint_0 >>= class8_0.int_2 & 7;
		class8_0.int_2 &= -8;
	}

	static void smethod_24(Class6.Class9 class9_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class9_0.byte_0[class9_0.int_0++] = class9_0.byte_0[int_0++];
			class9_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static short smethod_25(int int_0)
	{
		return (short)((Class6.Class12.byte_0[int_0 & 0xF] << 12) | (Class6.Class12.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class6.Class12.byte_0[(int_0 >> 8) & 0xF] << 4) | Class6.Class12.byte_0[int_0 >> 12]);
	}

	static void smethod_26(Class5 class5_0)
	{
		class5_0.type_0.GetMethod("Clear")!.Invoke(class5_0.object_0, new object[0]);
	}

	unsafe static bool smethod_27(Class6.Class7 class7_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class1.smethod_0(class7_0.class9_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class7_0.int_4;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class1.smethod_32(class7_0.class10_0, class7_0.class8_0)) & -256) == 0)
				{
					Class1.smethod_11(class7_0.class9_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class7_0.int_6 = Class6.Class7.int_0[num2 - 257];
					class7_0.int_5 = Class6.Class7.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class7_0.class10_1 = null;
				class7_0.class10_0 = null;
				class7_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class7_0.int_5 > 0)
				{
					class7_0.int_4 = 8;
					*(int*)ptr = Class1.smethod_1(class7_0.class8_0, class7_0.int_5);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class1.smethod_8(class7_0.class8_0, class7_0.int_5);
					class7_0.int_6 += *(int*)ptr;
				}
				class7_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class1.smethod_32(class7_0.class10_1, class7_0.class8_0);
				if (num2 >= 0)
				{
					class7_0.int_7 = Class6.Class7.int_2[num2];
					class7_0.int_5 = Class6.Class7.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class7_0.int_5 > 0)
				{
					class7_0.int_4 = 10;
					*(int*)((byte*)ptr + 4) = Class1.smethod_1(class7_0.class8_0, class7_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class1.smethod_8(class7_0.class8_0, class7_0.int_5);
					class7_0.int_7 += *(int*)((byte*)ptr + 4);
				}
				Class1.smethod_15(class7_0.class9_0, class7_0.int_6, class7_0.int_7);
				num -= class7_0.int_6;
				class7_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	unsafe static int smethod_28(int int_0, Class6.Class7 class7_0, int int_1, byte[] byte_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class7_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class1.smethod_18(int_1, byte_0, class7_0.class9_0, int_0);
				int_0 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_1 -= *(int*)((byte*)ptr + 4);
				if (int_1 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class1.smethod_22(class7_0) || (class7_0.class9_0.int_1 > 0 && class7_0.int_4 != 11));
		return *(int*)ptr;
	}

	static int smethod_29(Class6.Class8 class8_0)
	{
		return class8_0.int_1 - class8_0.int_0 + (class8_0.int_2 >> 3);
	}

	static int smethod_30(Class6.Class8 class8_0)
	{
		return class8_0.int_2;
	}

	static ICryptoTransform smethod_31(byte[] byte_0, bool bool_0, byte[] byte_1, Class4 class4_0)
	{
		class4_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class4_0.object_0, new object[1] { byte_0 });
		class4_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class4_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class4_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class4_0.object_0, new object[0]);
	}

	unsafe static int smethod_32(Class6.Class10 class10_0, Class6.Class8 class8_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class1.smethod_1(class8_0, 9)) >= 0)
		{
			if ((num2 = class10_0.short_0[num]) >= 0)
			{
				Class1.smethod_8(class8_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class1.smethod_1(class8_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class10_0.short_0[*(int*)ptr | (num >> 9)];
				Class1.smethod_8(class8_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class8_0.int_2;
			num = Class1.smethod_1(class8_0, *(int*)((byte*)ptr + 8));
			num2 = class10_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class1.smethod_8(class8_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class8_0.int_2;
		num = Class1.smethod_1(class8_0, *(int*)((byte*)ptr + 12));
		num2 = class10_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class1.smethod_8(class8_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_33(Class6.Class9 class9_0)
	{
		return class9_0.int_1;
	}
}
