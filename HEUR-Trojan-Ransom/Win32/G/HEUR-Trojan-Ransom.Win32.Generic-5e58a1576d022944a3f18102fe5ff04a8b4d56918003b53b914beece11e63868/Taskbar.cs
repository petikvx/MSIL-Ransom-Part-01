using System.Runtime.InteropServices;

internal class Taskbar
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 1;

	protected static int Handle => FindWindow("Shell_TrayWnd", "");

	protected static int HandleOfStartButton => FindWindowEx(GetDesktopWindow(), 0, "button", 0);

	[DllImport("user32.dll")]
	private static extern int FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int command);

	[DllImport("user32.dll")]
	public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

	[DllImport("user32.dll")]
	private static extern int GetDesktopWindow();

	public static void Show()
	{
		ShowWindow(Handle, 1);
		ShowWindow(HandleOfStartButton, 1);
	}

	public static void Hide()
	{
		ShowWindow(Handle, 0);
		ShowWindow(HandleOfStartButton, 0);
	}
}
