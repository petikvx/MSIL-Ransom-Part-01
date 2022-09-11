using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace HRemout.EnumWindow;

internal class EnumDesktopWindow
{
	private delegate bool EnumDelegate(IntPtr hWnd, int lParam);

	private static List<IntPtr> WindowHandles;

	private static List<string> WindowTitles;

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

	public static void GetDesktopWindowHandlesAndTitles(out List<IntPtr> handles, out List<string> titles)
	{
		WindowHandles = new List<IntPtr>();
		WindowTitles = new List<string>();
		if (!EnumDesktopWindows(IntPtr.Zero, FilterCallback, IntPtr.Zero))
		{
			handles = null;
			titles = null;
		}
		else
		{
			handles = WindowHandles;
			titles = WindowTitles;
		}
	}

	private static bool FilterCallback(IntPtr hWnd, int lParam)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
		string text = stringBuilder.ToString();
		if (IsWindowVisible(hWnd) && !string.IsNullOrEmpty(text))
		{
			WindowHandles.Add(hWnd);
			WindowTitles.Add(text);
		}
		return true;
	}
}
