using System;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace YullySpoofer;

internal class RegistryCleaner
{
	public static bool Clean()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EpicGamesLauncher/Saved/Windows/", "GameUserSettings.ini");
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == "[RememberMe]")
				{
					if (i + 2 >= array.Length)
					{
						break;
					}
					string text = array[i + 2];
					if (!text.StartsWith("Data=") || text.Length < 100)
					{
						break;
					}
					return true;
				}
			}
		}
		return false;
	}

	public static void Clean1()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EpicGamesLauncher/Saved/Windows/", "GameUserSettings.ini");
		if (!File.Exists(path))
		{
			return;
		}
		string[] array = File.ReadAllLines(path);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == "[RememberMe]")
			{
				if (i + 2 >= array.Length)
				{
					break;
				}
				string text = array[i + 1];
				string text2 = array[i + 2];
				if (!text.StartsWith("Enable=") || !text2.StartsWith("Data="))
				{
					break;
				}
				array[i + 1] = "Enable=False";
				array[i + 2] = "Data=";
				try
				{
					File.WriteAllLines(path, array);
				}
				catch (Exception)
				{
					break;
				}
			}
		}
	}

	public static void Clean10()
	{
		Random random = new Random();
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack\\SettingsRequests\\", writable: true))
			{
				if (registryKey != null)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					foreach (string text in subKeyNames)
					{
						if (!text.StartsWith("WINDOWS"))
						{
							registryKey.DeleteSubKeyTree(text, throwOnMissingSubKey: false);
						}
					}
				}
			}
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack\\SevilleEventlogManager\\", writable: true);
			if (registryKey2 != null && registryKey2.GetValueNames().Contains("LastEventlogWrittenTime"))
			{
				long num = (long)registryKey2.GetValue("LastEventlogWrittenTime") + random.Next(-5000, 5000);
				registryKey2.SetValue("LastEventlogWrittenTime", num, RegistryValueKind.QWord);
			}
		}
		catch (Exception)
		{
		}
	}

	public static bool Clean11()
	{
		try
		{
			if (!string.IsNullOrEmpty((string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\")!.GetValue("SusClientId", null)))
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void Clean12()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\", writable: true);
		if (!string.IsNullOrEmpty((string)registryKey.GetValue("SusClientId", null)))
		{
			registryKey.SetValue("SusClientId", Guid.NewGuid().ToString("D"), RegistryValueKind.String);
		}
	}

	public static bool Clean2()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam\\");
			if (registryKey != null)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void Clean3()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam\\", writable: true);
		if (registryKey == null)
		{
			return;
		}
		if (registryKey.GetValueNames().Contains("AutoLoginUser"))
		{
			registryKey.DeleteValue("AutoLoginUser");
		}
		if (!registryKey.GetSubKeyNames().Contains("Users"))
		{
			return;
		}
		using RegistryKey registryKey2 = registryKey.OpenSubKey("Users", writable: true);
		if (registryKey2 != null)
		{
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				registryKey2.DeleteSubKeyTree(subKeyNames[i], throwOnMissingSubKey: false);
			}
		}
	}

	public static void Clean4()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store\\", writable: true);
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Length; i++)
			{
				registryKey.DeleteValue(valueNames[i], throwOnMissingValue: false);
			}
		}
		catch (Exception)
		{
		}
	}

	public static bool Clean5()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\");
			if (registryKey != null)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void Clean6()
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\");
		if (registryKey == null)
		{
			return;
		}
		using (RegistryKey registryKey2 = registryKey.OpenSubKey("Profiles", writable: true))
		{
			if (registryKey2 != null)
			{
				string[] subKeyNames = registryKey2.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					registryKey2.DeleteSubKeyTree(subKeyNames[i], throwOnMissingSubKey: false);
				}
			}
		}
		using (RegistryKey registryKey3 = registryKey.OpenSubKey("Nla\\Wireless", writable: true))
		{
			if (registryKey3 != null)
			{
				string[] subKeyNames = registryKey3.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					registryKey3.DeleteSubKeyTree(subKeyNames[i], throwOnMissingSubKey: false);
				}
			}
		}
		using (RegistryKey registryKey4 = registryKey.OpenSubKey("Nla\\Cache\\"))
		{
			if (registryKey4 != null)
			{
				string[] subKeyNames = registryKey4.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					using RegistryKey registryKey5 = registryKey4.OpenSubKey(subKeyNames[i], writable: true);
					if (registryKey5 != null)
					{
						string[] valueNames = registryKey5.GetValueNames();
						for (int j = 0; j < valueNames.Length; j++)
						{
							registryKey5.DeleteValue(valueNames[j], throwOnMissingValue: false);
						}
					}
				}
			}
		}
		using RegistryKey registryKey6 = registryKey.OpenSubKey("Signatures\\");
		if (registryKey6 == null)
		{
			return;
		}
		string[] subKeyNames = registryKey6.GetSubKeyNames();
		for (int i = 0; i < subKeyNames.Length; i++)
		{
			using RegistryKey registryKey7 = registryKey6.OpenSubKey(subKeyNames[i], writable: true);
			if (registryKey7 != null)
			{
				string[] valueNames = registryKey7.GetSubKeyNames();
				for (int j = 0; j < valueNames.Length; j++)
				{
					registryKey7.DeleteSubKeyTree(valueNames[j], throwOnMissingSubKey: false);
				}
			}
		}
	}

	public static void Clean7()
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\", writable: true);
		if (registryKey != null)
		{
			if (!registryKey.GetSubKeyNames().Contains("DNSClient"))
			{
				registryKey.CreateSubKey("DNSClient")?.Dispose();
			}
			using RegistryKey registryKey2 = registryKey.OpenSubKey("DNSClient", writable: true);
			registryKey2?.SetValue("EnableMulticast", 0, RegistryValueKind.DWord);
			return;
		}
	}

	public static void Clean8()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\UserAssist\\", writable: true);
		if (registryKey != null)
		{
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				registryKey.DeleteSubKeyTree(subKeyNames[i], throwOnMissingSubKey: false);
			}
		}
	}

	public static void Clean9()
	{
		string value = Guid.NewGuid().ToString("B").ToUpper();
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\SQMClient\\", writable: true);
			if (registryKey != null && registryKey.GetValueNames().Contains("MachineId"))
			{
				registryKey.SetValue("MachineId", value);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\OneSettings\\WSD\\");
			if (registryKey2 == null)
			{
				return;
			}
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				using RegistryKey registryKey3 = registryKey2.OpenSubKey(subKeyNames[i]);
				if (registryKey3 == null)
				{
					continue;
				}
				using RegistryKey registryKey4 = registryKey3.OpenSubKey("QueryParameters", writable: true);
				if (registryKey4 != null)
				{
					string[] valueNames = registryKey4.GetValueNames();
					if (valueNames.Contains("deviceId"))
					{
						registryKey4.SetValue("deviceId", value, RegistryValueKind.String);
					}
					if (valueNames.Contains("deviceid"))
					{
						registryKey4.SetValue("deviceid", value, RegistryValueKind.String);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void Spoof1337()
	{
		try
		{
			Clean();
		}
		catch
		{
		}
		try
		{
			Clean1();
		}
		catch
		{
		}
		try
		{
			Clean2();
		}
		catch
		{
		}
		try
		{
			Clean3();
		}
		catch
		{
		}
		try
		{
			Clean4();
		}
		catch
		{
		}
		try
		{
			Clean5();
		}
		catch
		{
		}
		try
		{
			Clean6();
		}
		catch
		{
		}
		try
		{
			Clean7();
		}
		catch
		{
		}
		try
		{
			Clean8();
		}
		catch
		{
		}
		try
		{
			Clean9();
		}
		catch
		{
		}
		try
		{
			Clean10();
		}
		catch
		{
		}
		try
		{
			Clean11();
		}
		catch
		{
		}
		try
		{
			Clean12();
		}
		catch
		{
		}
	}
}
