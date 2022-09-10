using System.Runtime.InteropServices;

namespace Api;

public class api
{
	public const int SW_HIDE = 0;

	public const int ConsoleWindowClass = 1;

	public const string amir = "hi i'm devil worm";

	public const int EWX_LOGOFF = 0;

	public const int EWX_SHUTDOWN = 1;

	public const int EWX_REBOOT = 2;

	public const int EWX_FORCE = 4;

	public const int EWX_POWEROFF = 8;

	[DllImport("winmm.dll")]
	public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

	[DllImport("user32")]
	public static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("user32")]
	public static extern int MessageBeep(int wType);

	[DllImport("kernel32")]
	public static extern int Sleep(int dwMilliseconds);

	[DllImport("user32")]
	public static extern int FindWindowA(string lpClassName, string lpWindowName);

	[DllImport("shell32", EntryPoint = "#59")]
	public static extern int shell32_59(int hOwner, string sExtraPrompt, int uFlags);
}
