using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

[SuppressIldasm]
internal sealed class Class14
{
	[NonSerialized]
	internal static GDelegate0 gdelegate0_0;

	unsafe static void smethod_0(Class7.Class11 class11_0, byte[] byte_0)
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
				array[*(int*)((byte*)ptr + 4)]++;
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
		class11_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class11_0.short_0[Class14.smethod_18(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class14.smethod_18(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class11_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class11_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class11_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static Class7.Class11 smethod_1(Class7.Class12 class12_0)
	{
		byte[] array = new byte[class12_0.int_3];
		Array.Copy(class12_0.byte_1, 0, array, 0, class12_0.int_3);
		return new Class7.Class11(array);
	}

	unsafe static int smethod_2(Class7.Class9 class9_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class9_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class9_0.uint_0;
			class9_0.uint_0 >>= 8;
			class9_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class9_0.int_1 - class9_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class9_0.byte_0, class9_0.int_0, byte_0, int_0, int_1);
		class9_0.int_0 += int_1;
		if (((uint)(class9_0.int_0 - class9_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class9_0.uint_0 = class9_0.byte_0[class9_0.int_0++] & 0xFFu;
			class9_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static int smethod_3(Class7._0024i _0024i_0)
	{
		return _0024i_0.ReadByte() | (_0024i_0.ReadByte() << 8);
	}

	static void smethod_4(Class7.Class9 class9_0)
	{
		class9_0.uint_0 >>= class9_0.int_2 & 7;
		class9_0.int_2 &= -8;
	}

	static int smethod_5(Class7.Class10 class10_0)
	{
		return class10_0.int_1;
	}

	static void smethod_6()
	{
		try
		{
			Class5.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_7(Class7.Class10 class10_0, int int_0)
	{
		if (class10_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class10_0.byte_0[class10_0.int_0++] = (byte)int_0;
		class10_0.int_0 &= 32767;
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static Class7.Class11 smethod_8(Class7.Class12 class12_0)
	{
		byte[] array = new byte[class12_0.int_4];
		Array.Copy(class12_0.byte_1, class12_0.int_3, array, 0, class12_0.int_4);
		return new Class7.Class11(array);
	}

	static void smethod_9()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class14.smethod_25;
		}
		catch
		{
		}
	}

	static int smethod_10(Class7.Class9 class9_0, int int_0)
	{
		if (class9_0.int_2 < int_0)
		{
			if (class9_0.int_0 == class9_0.int_1)
			{
				return -1;
			}
			class9_0.uint_0 |= (uint)(((class9_0.byte_0[class9_0.int_0++] & 0xFF) | ((class9_0.byte_0[class9_0.int_0++] & 0xFF) << 8)) << class9_0.int_2);
			class9_0.int_2 += 16;
		}
		return (int)(class9_0.uint_0 & ((1 << int_0) - 1));
	}

	static ICryptoTransform smethod_11(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static void smethod_12(Class7.Class10 class10_0, int int_0, int int_1)
	{
		if ((class10_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class10_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class10_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class10_0.byte_0, num, class10_0.byte_0, class10_0.int_0, int_0);
				class10_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class10_0.byte_0[class10_0.int_0++] = class10_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class14.smethod_27(class10_0, num, int_0, int_1);
		}
	}

	unsafe static int smethod_13(int int_0, int int_1, Class7.Class10 class10_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class10_0.int_0;
		if (int_1 > class10_0.int_1)
		{
			int_1 = class10_0.int_1;
		}
		else
		{
			*(int*)ptr = (class10_0.int_0 - class10_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class10_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class10_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class10_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class10_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	unsafe static int smethod_14(Class7.Class11 class11_0, Class7.Class9 class9_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class14.smethod_10(class9_0, 9)) >= 0)
		{
			if ((num2 = class11_0.short_0[num]) >= 0)
			{
				Class14.smethod_17(class9_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class14.smethod_10(class9_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class11_0.short_0[*(int*)ptr | (num >> 9)];
				Class14.smethod_17(class9_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class9_0.int_2;
			num = Class14.smethod_10(class9_0, *(int*)((byte*)ptr + 8));
			num2 = class11_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class14.smethod_17(class9_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class9_0.int_2;
		num = Class14.smethod_10(class9_0, *(int*)((byte*)ptr + 12));
		num2 = class11_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class14.smethod_17(class9_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	unsafe static bool smethod_15(Class7.Class12 class12_0, Class7.Class9 class9_0)
	{
		void* ptr = stackalloc byte[12];
		while (true)
		{
			*(int*)((byte*)ptr + 8) = class12_0.int_2;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class7.Class12.int_1[class12_0._003C];
				int num = Class14.smethod_10(class9_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class14.smethod_17(class9_0, *(int*)((byte*)ptr + 4));
					num += Class7.Class12.int_0[class12_0._003C];
					while (num-- > 0)
					{
						class12_0.byte_1[class12_0.int_7++] = class12_0.byte_2;
					}
					if (class12_0.int_7 == class12_0.int_6)
					{
						return true;
					}
					goto IL_0083;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class14.smethod_14(class12_0.class11_0, class9_0)) & -16) == 0)
				{
					class12_0.byte_1[class12_0.int_7++] = (class12_0.byte_2 = (byte)num2);
					if (class12_0.int_7 == class12_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class12_0.byte_2 = 0;
					}
					class12_0._003C = num2 - 16;
					class12_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class12_0.int_7 < class12_0.int_5)
				{
					*(int*)ptr = Class14.smethod_10(class9_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class14.smethod_17(class9_0, 3);
						class12_0.byte_0[Class7.Class12.int_8[class12_0.int_7]] = (byte)(*(uint*)ptr);
						class12_0.int_7++;
						continue;
					}
					return false;
				}
				class12_0.class11_0 = new Class7.Class11(class12_0.byte_0);
				class12_0.byte_0 = null;
				class12_0.int_7 = 0;
				class12_0.int_2 = 4;
				goto case 4;
			case 2:
				class12_0.int_5 = Class14.smethod_10(class9_0, 4);
				if (class12_0.int_5 >= 0)
				{
					class12_0.int_5 += 4;
					Class14.smethod_17(class9_0, 4);
					class12_0.byte_0 = new byte[19];
					class12_0.int_7 = 0;
					class12_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class12_0.int_4 = Class14.smethod_10(class9_0, 5);
				if (class12_0.int_4 >= 0)
				{
					class12_0.int_4++;
					Class14.smethod_17(class9_0, 5);
					class12_0.int_6 = class12_0.int_3 + class12_0.int_4;
					class12_0.byte_1 = new byte[class12_0.int_6];
					class12_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class12_0.int_3 = Class14.smethod_10(class9_0, 5);
				if (class12_0.int_3 >= 0)
				{
					class12_0.int_3 += 257;
					Class14.smethod_17(class9_0, 5);
					class12_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0083:
			class12_0.int_2 = 4;
		}
	}

	static int smethod_16(Class7._0024i _0024i_0)
	{
		return Class14.smethod_3(_0024i_0) | (Class14.smethod_3(_0024i_0) << 16);
	}

	static void smethod_17(Class7.Class9 class9_0, int int_0)
	{
		class9_0.uint_0 >>= int_0;
		class9_0.int_2 -= int_0;
	}

	static short smethod_18(int int_0)
	{
		return (short)((Class7.Class13.byte_0[int_0 & 0xF] << 12) | (Class7.Class13.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class7.Class13.byte_0[(int_0 >> 8) & 0xF] << 4) | Class7.Class13.byte_0[int_0 >> 12]);
	}

	static byte[] smethod_19(string string_0, byte[] byte_0)
	{
		Rijndael rijndael = Rijndael.Create();
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, new byte[16]
		{
			38, 220, 255, 0, 173, 237, 122, 238, 197, 254,
			7, 175, 77, 8, 34, 60
		});
		rijndael.Key = rfc2898DeriveBytes.GetBytes(32);
		rijndael.IV = rfc2898DeriveBytes.GetBytes(16);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	unsafe static int smethod_20(Class7.Class10 class10_0, Class7.Class9 class9_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class10_0.int_1), Class14.smethod_33(class9_0));
		*(int*)((byte*)ptr + 4) = 32768 - class10_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class14.smethod_2(class9_0, class10_0.byte_0, class10_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class14.smethod_2(class9_0, class10_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class14.smethod_2(class9_0, class10_0.byte_0, class10_0.int_0, int_0);
		}
		class10_0.int_0 = (class10_0.int_0 + *(int*)ptr) & 0x7FFF;
		class10_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static void smethod_21(int int_0, Class7.Class9 class9_0, byte[] byte_0, int int_1)
	{
		if (class9_0.int_0 < class9_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class9_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class9_0.int_2);
				class9_0.int_2 += 8;
			}
			class9_0.byte_0 = byte_0;
			class9_0.int_0 = int_0;
			class9_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static int smethod_22(Class7.Class10 class10_0)
	{
		return 32768 - class10_0.int_1;
	}

	static int smethod_23(Class7.Class9 class9_0)
	{
		return class9_0.int_2;
	}

	static bool smethod_24(Class7.Class9 class9_0)
	{
		return class9_0.int_0 == class9_0.int_1;
	}

	unsafe static Assembly smethod_25(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[18];
		Class2.Struct0 @struct = new Class2.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = Class16.smethod_14().Split(new char[1] { ',' });
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
			lock (Class2.dictionary_0)
			{
				if (Class2.dictionary_0.ContainsKey(text2))
				{
					return Class2.dictionary_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class14.smethod_34(array2);
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
							string text4 = string.Format(Class16.smethod_12(), Path.GetTempPath(), text2);
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + Class16.smethod_13();
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class14.MoveFileEx(text5, (string)null, 4);
								Class14.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class2.dictionary_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static void smethod_26(string string_0, string string_1)
	{
		byte[] byte_ = Convert.FromBase64String(string_1);
		string string_2 = gdelegate0_0(300);
		Class0.byte_0 = Class14.smethod_19(string_2, byte_);
		byte_ = Convert.FromBase64String(string_0);
		string_2 = gdelegate0_0(300);
		Class0.byte_1 = Class14.smethod_19(string_2, byte_);
	}

	static void smethod_27(Class7.Class10 class10_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class10_0.byte_0[class10_0.int_0++] = class10_0.byte_0[int_0++];
			class10_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	unsafe static bool smethod_28(Class7.Class8 class8_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 12) = class8_0.int_4;
		switch (*(int*)((byte*)ptr + 12))
		{
		case 2:
			if (class8_0.bool_0)
			{
				class8_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class14.smethod_10(class8_0.class9_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class14.smethod_17(class8_0.class9_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class8_0.bool_0 = true;
			}
			*(int*)((byte*)ptr + 16) = *(int*)ptr >> 1;
			switch (*(int*)((byte*)ptr + 16))
			{
			case 0:
				Class14.smethod_4(class8_0.class9_0);
				class8_0.int_4 = 3;
				break;
			case 1:
				class8_0.class11_0 = Class7.Class11.class11_0;
				class8_0.class11_1 = Class7.Class11.class11_1;
				class8_0.int_4 = 7;
				break;
			case 2:
				class8_0.class12_0 = new Class7.Class12();
				class8_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class8_0.int_8 = Class14.smethod_10(class8_0.class9_0, 16)) < 0)
			{
				return false;
			}
			Class14.smethod_17(class8_0.class9_0, 16);
			class8_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class14.smethod_10(class8_0.class9_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class14.smethod_17(class8_0.class9_0, 16);
			class8_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class14.smethod_20(class8_0.class10_0, class8_0.class9_0, class8_0.int_8);
			class8_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class8_0.int_8 == 0)
			{
				class8_0.int_4 = 2;
				return true;
			}
			return !Class14.smethod_24(class8_0.class9_0);
		case 6:
			if (!Class14.smethod_15(class8_0.class12_0, class8_0.class9_0))
			{
				return false;
			}
			class8_0.class11_0 = Class14.smethod_1(class8_0.class12_0);
			class8_0.class11_1 = Class14.smethod_8(class8_0.class12_0);
			class8_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class14.smethod_36(class8_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static bool smethod_29(Assembly assembly_0, Assembly assembly_1)
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

	static string smethod_30(string string_0)
	{
		gdelegate0_0(313);
		ResourceManager resourceManager = new ResourceManager(gdelegate0_0(326), Assembly.GetExecutingAssembly());
		string result = (string)resourceManager.GetObject(string_0);
		resourceManager.ReleaseAllResources();
		return result;
	}

	static ICryptoTransform smethod_31(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_32()
	{
		try
		{
			Class14.smethod_9();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_33(Class7.Class9 class9_0)
	{
		return class9_0.int_1 - class9_0.int_0 + (class9_0.int_2 >> 3);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	unsafe static byte[] smethod_34(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class14.smethod_29(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class7._0024i _0024i = new Class7._0024i(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class14.smethod_16(_0024i);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class14.smethod_3(_0024i);
			*(int*)((byte*)ptr + 4) = Class14.smethod_3(_0024i);
			*(int*)((byte*)ptr + 8) = Class14.smethod_3(_0024i);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException(Class16.smethod_16());
			}
			Class14.smethod_16(_0024i);
			Class14.smethod_16(_0024i);
			Class14.smethod_16(_0024i);
			*(int*)((byte*)ptr + 12) = Class14.smethod_16(_0024i);
			*(int*)((byte*)ptr + 16) = Class14.smethod_3(_0024i);
			*(int*)((byte*)ptr + 20) = Class14.smethod_3(_0024i);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				_0024i.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				_0024i.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[_0024i.Length - _0024i.Position];
			_0024i.Read(array2, 0, array2.Length);
			Class7.Class8 class8_ = new Class7.Class8(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class14.smethod_35(array.Length, 0, array, class8_);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException(Class16.smethod_15());
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class14.smethod_16(_0024i);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class14.smethod_16(_0024i);
					*(int*)((byte*)ptr + 40) = Class14.smethod_16(_0024i);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					_0024i.Read(array3, 0, array3.Length);
					Class7.Class8 class8_2 = new Class7.Class8(array3);
					Class14.smethod_35(*(int*)((byte*)ptr + 40), *(int*)((byte*)ptr + 32), array, class8_2);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 205, 83, 57, 52, 15, 106, 96, 19 };
				byte[] byte_2 = new byte[8] { 220, 90, 9, 86, 139, 213, 166, 97 };
				using ICryptoTransform cryptoTransform = Class14.smethod_31(bool_0: true, byte_, byte_2);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class14.smethod_34(byte_3);
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
				using ICryptoTransform cryptoTransform2 = Class14.smethod_11(byte_5, byte_4, bool_0: true);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class14.smethod_34(byte_6);
			}
		}
		_0024i.Close();
		_0024i = null;
		return array;
	}

	unsafe static int smethod_35(int int_0, int int_1, byte[] byte_0, Class7.Class8 class8_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class8_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class14.smethod_13(int_1, int_0, class8_0.class10_0, byte_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class14.smethod_28(class8_0) || (class8_0.class10_0.int_1 > 0 && class8_0.int_4 != 11));
		return *(int*)ptr;
	}

	unsafe static bool smethod_36(Class7.Class8 class8_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class14.smethod_22(class8_0.class10_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class8_0.int_4;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class14.smethod_14(class8_0.class11_0, class8_0.class9_0)) & -256) == 0)
				{
					Class14.smethod_7(class8_0.class10_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class8_0.int_6 = Class7.Class8.int_0[num2 - 257];
					class8_0.int_5 = Class7.Class8.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class8_0.class11_1 = null;
				class8_0.class11_0 = null;
				class8_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class8_0.int_5 > 0)
				{
					class8_0.int_4 = 8;
					*(int*)ptr = Class14.smethod_10(class8_0.class9_0, class8_0.int_5);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class14.smethod_17(class8_0.class9_0, class8_0.int_5);
					class8_0.int_6 += *(int*)ptr;
				}
				class8_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class14.smethod_14(class8_0.class11_1, class8_0.class9_0);
				if (num2 >= 0)
				{
					class8_0.int_7 = Class7.Class8.int_2[num2];
					class8_0.int_5 = Class7.Class8.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class8_0.int_5 > 0)
				{
					class8_0.int_4 = 10;
					*(int*)((byte*)ptr + 4) = Class14.smethod_10(class8_0.class9_0, class8_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class14.smethod_17(class8_0.class9_0, class8_0.int_5);
					class8_0.int_7 += *(int*)((byte*)ptr + 4);
				}
				Class14.smethod_12(class8_0.class10_0, class8_0.int_6, class8_0.int_7);
				num -= class8_0.int_6;
				class8_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static Class14()
	{
		GClass1.smethod_0(typeof(Class14));
	}
}
