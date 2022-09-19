using System.Runtime.InteropServices;

namespace Preevaaihmcbc;

internal static class Native
{
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(int hWnd, int nCmdShow);
}
