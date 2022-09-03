using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace setup;

internal class Runner
{
	private const int WM_COMMAND = 273;

	private const int MIN_ALL = 419;

	public static void SelfRemove()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + location + "\"",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Environment.Exit(0);
	}

	public static void StartTaskMgr()
	{
		try
		{
			Process.Start("taskmgr.exe");
		}
		catch
		{
		}
	}

	public static bool CheckSingle()
	{
		return Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length == 1;
	}

	public static void HideAllWindows()
	{
		SendMessage(FindWindow("Shell_TrayWnd", null), 273, (IntPtr)419, IntPtr.Zero);
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr hObject);

	[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
	private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, int dwFlags, StringBuilder lpszPath);
}
