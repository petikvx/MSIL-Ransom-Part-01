using System;
using System.Runtime.InteropServices;

namespace Insrvhtuhrjlfylhnx.Shared;

public static class Helper
{
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr v, int maxtoken);
}
