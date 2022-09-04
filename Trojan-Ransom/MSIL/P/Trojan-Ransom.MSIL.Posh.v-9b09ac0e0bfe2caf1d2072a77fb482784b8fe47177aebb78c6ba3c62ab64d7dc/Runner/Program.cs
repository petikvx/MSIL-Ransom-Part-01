using System;
using System.Runtime.InteropServices;

namespace Runner;

internal class Program
{
	internal enum CtrlTypes
	{
		CTRL_C_EVENT = 0,
		CTRL_BREAK_EVENT = 1,
		CTRL_CLOSE_EVENT = 2,
		CTRL_LOGOFF_EVENT = 5,
		CTRL_SHUTDOWN_EVENT = 6
	}

	internal delegate bool HandlerRoutine(CtrlTypes CtrlType);

	private static GCHandle breakHandlerGcHandle;

	[DllImport("kernel32.dll")]
	private static extern int AllocConsole();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool SetConsoleCtrlHandler(HandlerRoutine Handler, bool Add);

	[STAThread]
	private static void Main(string[] args)
	{
		if (GetConsoleWindow() == IntPtr.Zero)
		{
			AllocConsole();
			ShowWindow(GetConsoleWindow(), 0);
		}
		breakHandlerGcHandle = GCHandle.Alloc(new HandlerRoutine(Handler));
		SetConsoleCtrlHandler((HandlerRoutine)breakHandlerGcHandle.Target, Add: true);
		Loader.Exec(args);
	}

	private static bool Handler(CtrlTypes CtrlType)
	{
		return true;
	}
}
