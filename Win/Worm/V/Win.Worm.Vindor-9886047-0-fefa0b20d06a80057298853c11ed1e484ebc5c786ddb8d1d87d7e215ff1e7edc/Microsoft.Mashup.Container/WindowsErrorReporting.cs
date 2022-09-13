using System;
using System.Runtime.InteropServices;

namespace Microsoft.Mashup.Container;

internal static class WindowsErrorReporting
{
	[Flags]
	private enum WindowsErrorReportingFlags : uint
	{
		None = 0u,
		NoHead = 1u,
		Queue = 2u,
		DisableThreadSuspension = 4u,
		QueueUpload = 8u,
		AlwaysShowUi = 0x10u,
		ReportingNoUi = 0x20u
	}

	private static class NativeMethods
	{
		[DllImport("kernel32.dll", PreserveSig = false)]
		public static extern void WerSetFlags(uint dwFlags);
	}

	public static void DisableCrashDialog()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		WindowsErrorReportingFlags dwFlags = ((oSVersion.Version.Major >= 6 || (oSVersion.Version.Major == 6 && oSVersion.Version.Minor >= 2)) ? WindowsErrorReportingFlags.ReportingNoUi : WindowsErrorReportingFlags.Queue);
		NativeMethods.WerSetFlags((uint)dwFlags);
	}
}
