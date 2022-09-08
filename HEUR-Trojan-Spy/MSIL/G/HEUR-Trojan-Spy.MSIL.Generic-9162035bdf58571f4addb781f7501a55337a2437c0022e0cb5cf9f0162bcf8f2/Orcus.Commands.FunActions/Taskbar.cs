using System;
using System.Diagnostics;
using System.Text;
using Orcus.Native;

namespace Orcus.Commands.FunActions;

internal static class Taskbar
{
	private const string VistaStartMenuCaption = "Start";

	private static IntPtr vistaStartMenuWnd = IntPtr.Zero;

	public static bool IsVisible
	{
		set
		{
			SetVisibility(value);
		}
	}

	public static void Show()
	{
		SetVisibility(show: true);
	}

	public static void Hide()
	{
		SetVisibility(show: false);
	}

	private static void SetVisibility(bool show)
	{
		IntPtr intPtr = NativeMethods.FindWindow("Shell_TrayWnd", null);
		IntPtr intPtr2 = NativeMethods.FindWindowEx(intPtr, IntPtr.Zero, "Button", "Start");
		if (intPtr2 == IntPtr.Zero)
		{
			intPtr2 = NativeMethods.FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)49175, "Start");
		}
		if (intPtr2 == IntPtr.Zero)
		{
			intPtr2 = NativeMethods.FindWindow("Button", null);
			if (intPtr2 == IntPtr.Zero)
			{
				intPtr2 = GetVistaStartMenuWnd(intPtr);
			}
		}
		NativeMethods.ShowWindow(intPtr, show ? ShowWindowCommands.Show : ShowWindowCommands.Hide);
		NativeMethods.ShowWindow(intPtr2, show ? ShowWindowCommands.Show : ShowWindowCommands.Hide);
	}

	private static IntPtr GetVistaStartMenuWnd(IntPtr taskBarWnd)
	{
		NativeMethods.GetWindowThreadProcessId(taskBarWnd, out var lpdwProcessId);
		foreach (ProcessThread thread in Process.GetProcessById((int)lpdwProcessId).Threads)
		{
			NativeMethods.EnumThreadWindows(thread.Id, MyEnumThreadWindowsProc, IntPtr.Zero);
		}
		return vistaStartMenuWnd;
	}

	private static bool MyEnumThreadWindowsProc(IntPtr hWnd, IntPtr lParam)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (NativeMethods.GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity) > 0 && stringBuilder.ToString() == "Start")
		{
			vistaStartMenuWnd = hWnd;
			return false;
		}
		return true;
	}
}
