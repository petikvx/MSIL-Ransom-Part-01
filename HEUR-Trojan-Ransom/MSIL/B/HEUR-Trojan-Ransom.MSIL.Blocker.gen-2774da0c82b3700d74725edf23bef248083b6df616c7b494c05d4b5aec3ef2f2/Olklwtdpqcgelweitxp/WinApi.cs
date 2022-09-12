using System.Runtime.InteropServices;

namespace Olklwtdpqcgelweitxp;

internal static class WinApi
{
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(int hWnd, int nCmdShow);
}
