using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ns3;

internal class Class16
{
	[DllImport("ntdll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public static void smethod_0(int int_0)
	{
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_0, 4);
	}

	public static void smethod_1(object sender, EventArgs e)
	{
		smethod_0(0);
	}
}
