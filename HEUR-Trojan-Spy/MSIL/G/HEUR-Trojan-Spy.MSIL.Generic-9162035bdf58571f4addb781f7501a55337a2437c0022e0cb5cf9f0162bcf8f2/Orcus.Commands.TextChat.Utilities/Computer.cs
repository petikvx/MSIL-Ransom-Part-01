using System;
using Orcus.Native;

namespace Orcus.Commands.TextChat.Utilities;

public static class Computer
{
	private const int WM_COMMAND = 273;

	private const int MIN_ALL = 419;

	public static void MinimizeAllScreens()
	{
		NativeMethods.SendMessage(NativeMethods.FindWindow("Shell_TrayWnd", null), 273u, (IntPtr)419, IntPtr.Zero);
	}
}
