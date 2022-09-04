using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace n;

[StandardModule]
internal sealed class NTSuspendProcess
{
	[DllImport("ntdll.dll")]
	private static extern bool NtSuspendProcess(IntPtr hHandle);

	[DllImport("ntdll.dll")]
	private static extern bool NtResumeProcess(IntPtr hHandle);

	public static bool SuspendProcess(int ID)
	{
		try
		{
			Process processById = Process.GetProcessById(ID);
			return NtSuspendProcess(processById.Handle);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool ResumeProcess(int ID)
	{
		try
		{
			Process processById = Process.GetProcessById(ID);
			return NtResumeProcess(processById.Handle);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
