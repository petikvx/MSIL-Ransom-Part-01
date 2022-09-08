using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Orcus.Native;
using Orcus.Shared.Commands.WindowManager;

namespace Orcus.Commands.WindowManager;

public static class WindowManager
{
	public static List<WindowInformation> GetAllWindows()
	{
		IntPtr desktopWindow = NativeMethods.GetDesktopWindow();
		List<WindowInformation> list = new List<WindowInformation>();
		list.Add(GetWindowInformation(desktopWindow));
		list.AddRange(GetChildWindows(desktopWindow));
		return list;
	}

	private static IEnumerable<WindowInformation> GetChildWindows(IntPtr parent)
	{
		IntPtr childHwnd = NativeMethods.GetWindow(parent, GetWindow_Cmd.GW_CHILD);
		while (childHwnd != IntPtr.Zero)
		{
			WindowInformation windowInformation = GetWindowInformation(childHwnd);
			windowInformation.set_ParentHandle((long)parent);
			yield return windowInformation;
			foreach (WindowInformation childWindow in GetChildWindows(childHwnd))
			{
				yield return childWindow;
			}
			childHwnd = NativeMethods.FindWindowEx(parent, childHwnd, null, null);
		}
	}

	private static WindowInformation GetWindowInformation(IntPtr hWnd)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder(1024);
		StringBuilder stringBuilder2 = new StringBuilder(1024);
		NativeMethods.GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
		NativeMethods.GetClassName(hWnd, stringBuilder2, stringBuilder2.Capacity);
		WindowInformation val = new WindowInformation();
		val.set_Handle((long)hWnd);
		val.set_ClassName(stringBuilder2.ToString());
		val.set_IsVisible(NativeMethods.IsWindowVisible(hWnd));
		WindowInformation val2 = val;
		if (!string.IsNullOrEmpty(stringBuilder.ToString()))
		{
			val2.set_Caption(stringBuilder.ToString());
		}
		else
		{
			stringBuilder = new StringBuilder((int)NativeMethods.SendMessage(hWnd, 14u, IntPtr.Zero, IntPtr.Zero) + 1);
			NativeMethods.SendMessage(hWnd, 13u, (IntPtr)stringBuilder.Capacity, stringBuilder);
			val2.set_Caption(stringBuilder.ToString());
		}
		try
		{
			NativeMethods.GetWindowThreadProcessId(hWnd, out var lpdwProcessId);
			Process processById = Process.GetProcessById((int)lpdwProcessId);
			val2.set_ProcessId(processById.Id);
			val2.set_ProcessName(processById.ProcessName);
			return val2;
		}
		catch (Exception)
		{
			return val2;
		}
	}
}
