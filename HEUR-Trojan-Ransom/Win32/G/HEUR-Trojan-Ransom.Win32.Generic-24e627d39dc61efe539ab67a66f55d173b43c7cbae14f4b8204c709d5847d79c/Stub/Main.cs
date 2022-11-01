using System;
using System.Runtime.InteropServices;

namespace Stub;

public class Main
{
	[STAThread]
	public static void Main()
	{
	}

	public static string DownloadStr(string string_0)
	{
		return null;
	}

	public static void RunAntiAnalysis()
	{
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	static Main()
	{
		Class0.smethod_13();
	}
}
