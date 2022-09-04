using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ns2;

internal class Class15
{
	[DllImport("ntdll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static void smethod_0(int dwActive)
	{
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref dwActive, 4);
	}

	public static void smethod_1(object sender, EventArgs e)
	{
		smethod_0(0);
	}
}
