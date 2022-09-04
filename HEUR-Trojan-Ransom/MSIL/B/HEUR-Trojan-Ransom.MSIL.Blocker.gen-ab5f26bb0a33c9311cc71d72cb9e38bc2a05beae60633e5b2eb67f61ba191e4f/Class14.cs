using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.MemoryManagement;
using ns0;
using ns3;
using ns5;

internal sealed class Class14
{
	static int smethod_0(Class6.Class10 class10_0, Class6.Class8 class8_0)
	{
		int num;
		int num2;
		if ((num = Class14.smethod_3(class8_0, 9)) >= 0)
		{
			if ((num2 = class10_0.short_0[num]) >= 0)
			{
				Class14.smethod_18(class8_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class14.smethod_3(class8_0, int_)) >= 0)
			{
				num2 = class10_0.short_0[num3 | (num >> 9)];
				Class14.smethod_18(class8_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class8_0.int_2;
			num = Class14.smethod_3(class8_0, int_2);
			num2 = class10_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class14.smethod_18(class8_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class8_0.int_2;
		num = Class14.smethod_3(class8_0, int_3);
		num2 = class10_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class14.smethod_18(class8_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static Assembly smethod_1(string string_0)
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

	static int smethod_2(Class6.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static int smethod_3(Class6.Class8 class8_0, int int_0)
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

	static int smethod_4(Class6.Class9 class9_0)
	{
		return class9_0.int_1;
	}

	static void smethod_5()
	{
		try
		{
			Class3.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_6(Class6.Class9 class9_0)
	{
		return 32768 - class9_0.int_1;
	}

	static void smethod_7(Class6.Class10 class10_0, byte[] byte_0)
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
		class10_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class10_0.short_0[Class14.smethod_19(k)] = (short)((-num7 << 4) | num8);
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
			int num12 = Class14.smethod_19(num3);
			if (num11 <= 9)
			{
				do
				{
					class10_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class10_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class10_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static void smethod_8(Class6.Class9 class9_0, int int_0, int int_1)
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
			Class14.smethod_11(class9_0, num, int_0, int_1);
		}
	}

	static void smethod_9(Class6.Class9 class9_0, int int_0)
	{
		if (class9_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class9_0.byte_0[class9_0.int_0++] = (byte)int_0;
		class9_0.int_0 &= 32767;
	}

	static ICryptoTransform smethod_10(byte[] byte_0, bool bool_0, byte[] byte_1, Class4 class4_0)
	{
		class4_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class4_0.object_0, new object[1] { byte_1 });
		class4_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class4_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class4_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class4_0.object_0, new object[0]);
	}

	static void smethod_11(Class6.Class9 class9_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class9_0.byte_0[class9_0.int_0++] = class9_0.byte_0[int_0++];
			class9_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static int smethod_12(int int_0, byte[] byte_0, Class6.Class7 class7_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class7_0.int_4 != 11)
			{
				int num2 = Class14.smethod_24(int_1, byte_0, int_0, class7_0.class9_0);
				int_1 += num2;
				num += num2;
				int_0 -= num2;
				if (int_0 == 0)
				{
					return num;
				}
			}
		}
		while (Class14.smethod_29(class7_0) || (class7_0.class9_0.int_1 > 0 && class7_0.int_4 != 11));
		return num;
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static Class6.Class10 smethod_13(Class6.Class11 class11_0)
	{
		byte[] array = new byte[class11_0.int_3];
		Array.Copy(class11_0.byte_1, 0, array, 0, class11_0.int_3);
		return new Class6.Class10(array);
	}

	static bool smethod_14(Class6.Class11 class11_0, Class6.Class8 class8_0)
	{
		while (true)
		{
			switch (class11_0.int_2)
			{
			case 5:
			{
				int int_ = Class6.Class11.int_1[class11_0.int_7];
				int num = Class14.smethod_3(class8_0, int_);
				if (num >= 0)
				{
					Class14.smethod_18(class8_0, int_);
					num += Class6.Class11.int_0[class11_0.int_7];
					while (num-- > 0)
					{
						class11_0.byte_1[class11_0.int_8++] = class11_0.byte_2;
					}
					if (class11_0.int_8 == class11_0.int_6)
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
				while (((num2 = Class14.smethod_0(class11_0.class10_0, class8_0)) & -16) == 0)
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
					int num3 = Class14.smethod_3(class8_0, 3);
					if (num3 >= 0)
					{
						Class14.smethod_18(class8_0, 3);
						class11_0.byte_0[Class6.Class11.int_9[class11_0.int_8]] = (byte)num3;
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
				class11_0.int_5 = Class14.smethod_3(class8_0, 4);
				if (class11_0.int_5 >= 0)
				{
					class11_0.int_5 += 4;
					Class14.smethod_18(class8_0, 4);
					class11_0.byte_0 = new byte[19];
					class11_0.int_8 = 0;
					class11_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class11_0.int_4 = Class14.smethod_3(class8_0, 5);
				if (class11_0.int_4 >= 0)
				{
					class11_0.int_4++;
					Class14.smethod_18(class8_0, 5);
					class11_0.int_6 = class11_0.int_3 + class11_0.int_4;
					class11_0.byte_1 = new byte[class11_0.int_6];
					class11_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class11_0.int_3 = Class14.smethod_3(class8_0, 5);
				if (class11_0.int_3 >= 0)
				{
					class11_0.int_3 += 257;
					Class14.smethod_18(class8_0, 5);
					class11_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class11_0.int_2 = 4;
		}
	}

	static Assembly smethod_15(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Class14.smethod_1(Convert.ToBase64String(Encoding.Default.GetBytes(resolveEventArgs_0.Name.ToLowerInvariant())));
	}

	static void smethod_16()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class14.smethod_21;
		}
		catch
		{
		}
	}

	static Class6.Class10 smethod_17(Class6.Class11 class11_0)
	{
		byte[] array = new byte[class11_0.int_4];
		Array.Copy(class11_0.byte_1, class11_0.int_3, array, 0, class11_0.int_4);
		return new Class6.Class10(array);
	}

	static void smethod_18(Class6.Class8 class8_0, int int_0)
	{
		class8_0.uint_0 >>= int_0;
		class8_0.int_2 -= int_0;
	}

	static short smethod_19(int int_0)
	{
		return (short)((Class6.Class12.byte_0[int_0 & 0xF] << 12) | (Class6.Class12.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class6.Class12.byte_0[(int_0 >> 8) & 0xF] << 4) | Class6.Class12.byte_0[int_0 >> 12]);
	}

	static int smethod_20(Class6.Class8 class8_0)
	{
		return class8_0.int_1 - class8_0.int_0 + (class8_0.int_2 >> 3);
	}

	static Assembly smethod_21(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class1.Struct0 @struct = new Class1.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezhmZjdmMjg2LWQ2NWItNDkxYy04N2RmLTRiZjQ3MjA1ZDYxNH0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{6c3b1eb0-674e-43e2-bdb1-a6ecf812993b},ezhmZjdmMjg2LWQ2NWItNDkxYy04N2RmLTRiZjQ3MjA1ZDYxNH0=,[z]{6c3b1eb0-674e-43e2-bdb1-a6ecf812993b}".Split(new char[1] { ',' });
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
			lock (Class1.hashtable_0)
			{
				if (Class1.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class1.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class14.smethod_22(array2);
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
								Class14.MoveFileEx(text5, (string)null, 4);
								Class14.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class1.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static byte[] smethod_22(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class14.smethod_36(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class6.Stream0 stream = new Class6.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class14.smethod_26(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class14.smethod_2(stream);
			int num3 = Class14.smethod_2(stream);
			int num4 = Class14.smethod_2(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class14.smethod_26(stream);
			Class14.smethod_26(stream);
			Class14.smethod_26(stream);
			int num5 = Class14.smethod_26(stream);
			int num6 = Class14.smethod_2(stream);
			int num7 = Class14.smethod_2(stream);
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
			Class6.Class7 class7_ = new Class6.Class7(array2);
			array = new byte[num5];
			Class14.smethod_12(array.Length, array, class7_, 0);
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
				int num9 = Class14.smethod_26(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class14.smethod_26(stream);
					num11 = Class14.smethod_26(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class6.Class7 class7_2 = new Class6.Class7(array3);
					Class14.smethod_12(num11, array, class7_2, i);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 241, 248, 159, 58, 136, 4, 50, 198 };
				byte[] byte_2 = new byte[8] { 239, 66, 208, 249, 81, 221, 219, 62 };
				using Class5 class5_ = new Class5();
				using ICryptoTransform cryptoTransform = Class14.smethod_34(bool_0: true, byte_2, byte_, class5_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class14.smethod_22(byte_3);
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
				using Class4 class4_ = new Class4();
				using ICryptoTransform cryptoTransform2 = Class14.smethod_10(byte_5, bool_0: true, byte_4, class4_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class14.smethod_22(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_23(Class4 class4_0)
	{
		class4_0.type_0.GetMethod("Clear")!.Invoke(class4_0.object_0, new object[0]);
	}

	static int smethod_24(int int_0, byte[] byte_0, int int_1, Class6.Class9 class9_0)
	{
		int num = class9_0.int_0;
		if (int_1 > class9_0.int_1)
		{
			int_1 = class9_0.int_1;
		}
		else
		{
			num = (class9_0.int_0 - class9_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class9_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class9_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class9_0.int_1 -= num2;
		if (class9_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_25()
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

	static int smethod_26(Class6.Stream0 stream0_0)
	{
		return Class14.smethod_2(stream0_0) | (Class14.smethod_2(stream0_0) << 16);
	}

	static int smethod_27(Class6.Class8 class8_0)
	{
		return class8_0.int_2;
	}

	static int smethod_28(Class6.Class8 class8_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class8_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class8_0.uint_0;
			class8_0.uint_0 >>= 8;
			class8_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class8_0.int_1 - class8_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class8_0.byte_0, class8_0.int_0, byte_0, int_0, int_1);
		class8_0.int_0 += int_1;
		if (((uint)(class8_0.int_0 - class8_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class8_0.uint_0 = class8_0.byte_0[class8_0.int_0++] & 0xFFu;
			class8_0.int_2 = 8;
		}
		return num + int_1;
	}

	static bool smethod_29(Class6.Class7 class7_0)
	{
		switch (class7_0.int_4)
		{
		case 2:
		{
			if (class7_0.bool_0)
			{
				class7_0.int_4 = 12;
				return false;
			}
			int num = Class14.smethod_3(class7_0.class8_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class14.smethod_18(class7_0.class8_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class7_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class14.smethod_31(class7_0.class8_0);
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
		}
		case 3:
			if ((class7_0.int_8 = Class14.smethod_3(class7_0.class8_0, 16)) < 0)
			{
				return false;
			}
			Class14.smethod_18(class7_0.class8_0, 16);
			class7_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class14.smethod_3(class7_0.class8_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class14.smethod_18(class7_0.class8_0, 16);
			class7_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class14.smethod_35(class7_0.class9_0, class7_0.class8_0, class7_0.int_8);
			class7_0.int_8 -= num3;
			if (class7_0.int_8 == 0)
			{
				class7_0.int_4 = 2;
				return true;
			}
			return !Class14.smethod_30(class7_0.class8_0);
		}
		case 6:
			if (!Class14.smethod_14(class7_0.class11_0, class7_0.class8_0))
			{
				return false;
			}
			class7_0.class10_0 = Class14.smethod_13(class7_0.class11_0);
			class7_0.class10_1 = Class14.smethod_17(class7_0.class11_0);
			class7_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class14.smethod_38(class7_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static bool smethod_30(Class6.Class8 class8_0)
	{
		return class8_0.int_0 == class8_0.int_1;
	}

	static void smethod_31(Class6.Class8 class8_0)
	{
		class8_0.uint_0 >>= class8_0.int_2 & 7;
		class8_0.int_2 &= -8;
	}

	static void smethod_32()
	{
		try
		{
			Class14.smethod_16();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_33(int int_0, byte[] byte_0, int int_1, Class6.Class8 class8_0)
	{
		if (class8_0.int_0 < class8_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class8_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class8_0.int_2);
				class8_0.int_2 += 8;
			}
			class8_0.byte_0 = byte_0;
			class8_0.int_0 = int_1;
			class8_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static ICryptoTransform smethod_34(bool bool_0, byte[] byte_0, byte[] byte_1, Class5 class5_0)
	{
		class5_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class5_0.object_0, new object[1] { byte_1 });
		class5_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class5_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class5_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class5_0.object_0, new object[0]);
	}

	static int smethod_35(Class6.Class9 class9_0, Class6.Class8 class8_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class9_0.int_1), Class14.smethod_20(class8_0));
		int num = 32768 - class9_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class14.smethod_28(class8_0, class9_0.byte_0, class9_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class14.smethod_28(class8_0, class9_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class14.smethod_28(class8_0, class9_0.byte_0, class9_0.int_0, int_0);
		}
		class9_0.int_0 = (class9_0.int_0 + num2) & 0x7FFF;
		class9_0.int_1 += num2;
		return num2;
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

	static void smethod_37(Class5 class5_0)
	{
		class5_0.type_0.GetMethod("Clear")!.Invoke(class5_0.object_0, new object[0]);
	}

	static bool smethod_38(Class6.Class7 class7_0)
	{
		int num = Class14.smethod_6(class7_0.class9_0);
		while (num >= 258)
		{
			switch (class7_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class14.smethod_0(class7_0.class10_0, class7_0.class8_0)) & -256) == 0)
				{
					Class14.smethod_9(class7_0.class9_0, num2);
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
					int num4 = Class14.smethod_3(class7_0.class8_0, class7_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class14.smethod_18(class7_0.class8_0, class7_0.int_5);
					class7_0.int_6 += num4;
				}
				class7_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class14.smethod_0(class7_0.class10_1, class7_0.class8_0);
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
					int num3 = Class14.smethod_3(class7_0.class8_0, class7_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class14.smethod_18(class7_0.class8_0, class7_0.int_5);
					class7_0.int_7 += num3;
				}
				Class14.smethod_8(class7_0.class9_0, class7_0.int_6, class7_0.int_7);
				num -= class7_0.int_6;
				class7_0.int_4 = 7;
				break;
			}
		}
		return true;
	}
}
