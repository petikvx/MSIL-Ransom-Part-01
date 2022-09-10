using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Main.Tools;

internal static class Windows
{
	internal enum StartupMethodType
	{
		StartupFolder,
		Registry
	}

	private static readonly IntPtr HWND_TOPMOST;

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	internal static extern void SetStartup(StartupMethodType startupMethod);

	private static void SetStartupFolder()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0015, IL_001c, IL_0021, IL_002c, IL_0035, IL_0036, IL_003b, IL_0040
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private static extern void SetStartupRegistry(string exePath);

	internal static extern void RemoveStartupRegistry(string exePath);

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	internal static extern void MakeTopMost(Form f);
}
