using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;

namespace MetroFramework.Native;

internal class Taskbar
{
	private const string ClassName = "Shell_TrayWnd";

	private Rectangle bounds = Rectangle.Empty;

	private TaskbarPosition position = TaskbarPosition.Unknown;

	private bool alwaysOnTop;

	private bool autoHide;

	public Rectangle Bounds
	{
		get
		{
			return bounds;
		}
		private set
		{
			bounds = value;
		}
	}

	public TaskbarPosition Position
	{
		get
		{
			return position;
		}
		private set
		{
			position = value;
		}
	}

	public Point Location => Bounds.Location;

	public Size Size => Bounds.Size;

	public bool AlwaysOnTop
	{
		get
		{
			return alwaysOnTop;
		}
		private set
		{
			alwaysOnTop = value;
		}
	}

	public bool AutoHide
	{
		get
		{
			return autoHide;
		}
		private set
		{
			autoHide = value;
		}
	}

	[SecuritySafeCritical]
	public Taskbar()
	{
		IntPtr hWnd = WinApi.FindWindow("Shell_TrayWnd", null);
		WinApi.APPBARDATA pData = new WinApi.APPBARDATA
		{
			cbSize = (uint)Marshal.SizeOf(typeof(WinApi.APPBARDATA)),
			hWnd = hWnd
		};
		IntPtr intPtr = WinApi.SHAppBarMessage(WinApi.ABM.GetTaskbarPos, ref pData);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		Position = (TaskbarPosition)pData.uEdge;
		Bounds = Rectangle.FromLTRB(pData.rc.Left, pData.rc.Top, pData.rc.Right, pData.rc.Bottom);
		pData.cbSize = (uint)Marshal.SizeOf(typeof(WinApi.APPBARDATA));
		int num = WinApi.SHAppBarMessage(WinApi.ABM.GetState, ref pData).ToInt32();
		AlwaysOnTop = (num & 2) == 2;
		AutoHide = (num & 1) == 1;
	}
}
