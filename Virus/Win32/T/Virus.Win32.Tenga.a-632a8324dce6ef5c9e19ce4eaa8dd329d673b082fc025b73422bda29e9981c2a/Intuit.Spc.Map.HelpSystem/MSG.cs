using System;
using System.Runtime.InteropServices;

namespace Intuit.Spc.Map.HelpSystem;

[ComVisible(false)]
public struct MSG
{
	public IntPtr hwnd;

	public uint message;

	public IntPtr wParam;

	public IntPtr lParam;

	public uint time;

	public POINT pt;
}
