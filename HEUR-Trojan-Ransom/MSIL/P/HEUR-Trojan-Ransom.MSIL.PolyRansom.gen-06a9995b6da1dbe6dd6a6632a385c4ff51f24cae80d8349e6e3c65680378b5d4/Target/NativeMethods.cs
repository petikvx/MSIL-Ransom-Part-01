using System;
using System.Runtime.InteropServices;

namespace Target;

[StructLayout(LayoutKind.Explicit)]
internal static class NativeMethods
{
	[DllImport("wininet.dll", SetLastError = true)]
	internal static extern bool InternetCloseHandle(IntPtr hInternet);

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr InternetOpen(string lpszAgent, int dwAccessType, string lpszProxyName, string lpszProxyBypass, int dwFlags);
}
