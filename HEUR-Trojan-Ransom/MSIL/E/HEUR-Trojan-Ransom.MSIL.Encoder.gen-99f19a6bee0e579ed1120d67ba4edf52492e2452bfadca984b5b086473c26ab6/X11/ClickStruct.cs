using System;

namespace X11;

internal struct ClickStruct
{
	internal IntPtr Hwnd;

	internal object Message;

	internal IntPtr wParam;

	internal IntPtr lParam;

	internal long Time;

	internal bool Pending;
}
