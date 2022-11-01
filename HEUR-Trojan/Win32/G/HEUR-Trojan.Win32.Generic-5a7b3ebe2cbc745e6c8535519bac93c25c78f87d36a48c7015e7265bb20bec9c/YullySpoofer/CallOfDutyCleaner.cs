using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace YullySpoofer;

internal class CallOfDutyCleaner
{
	public static string CodDirectory;

	public static void CleanProcess()
	{
		string directoryRoot = Directory.GetDirectoryRoot(Assembly.GetExecutingAssembly().Location);
		string[] array = new string[14]
		{
			CodDirectory + "main\\recipes\\cmr_hist",
			CodDirectory + "main\\data0.dcache",
			CodDirectory + "main\\data1.dcache",
			CodDirectory + "main\\toc0.dcache",
			CodDirectory + "main\\toc1.dcache",
			CodDirectory + "Data\\data\\shmem",
			directoryRoot + "Users\\" + Environment.UserName + "\\AppData\\Local\\Battle.net\\Cache",
			directoryRoot + "Users\\" + Environment.UserName + "\\AppData\\Local\\Battle.net\\Logs",
			directoryRoot + "Users\\" + Environment.UserName + "\\AppData\\Local\\Battle.net\\CachedData.db",
			directoryRoot + "Users\\" + Environment.UserName + "\\AppData\\Local\\Blizzard Entertainment",
			Environment.GetEnvironmentVariable("localappdata") + "\\Battle.net",
			Environment.GetEnvironmentVariable("localappdata") + "\\Blizzard Entertainment",
			Environment.GetEnvironmentVariable("appdata") + "\\Battle.net",
			Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\Call of Duty Modern Warfare"
		};
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			string name = "\\Software\\WOW6432Node\\Blizzard Entertainment";
			string name2 = "\\Software\\WOW6432Node\\Blizzard Entertainment";
			localMachine.DeleteValue(name);
			localMachine.DeleteValue(name2);
			localMachine.Close();
			for (int i = 0; i < array.Length; i++)
			{
				DeleteFile(array[i]);
				DeleteFolder(array[i]);
			}
		}
		catch
		{
		}
	}

	public static void DeleteFile(string path)
	{
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	public static void DeleteFolder(string path)
	{
		try
		{
			Directory.Delete(path, recursive: true);
		}
		catch
		{
		}
	}
}
