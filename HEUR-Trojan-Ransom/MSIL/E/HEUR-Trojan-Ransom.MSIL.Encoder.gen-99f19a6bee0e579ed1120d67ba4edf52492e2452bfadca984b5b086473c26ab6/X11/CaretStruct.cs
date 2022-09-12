using System;
using System.Windows.Forms;

namespace X11;

internal struct CaretStruct
{
	internal Timer Timer;

	internal IntPtr Hwnd;

	internal IntPtr Window;

	internal int X;

	internal int Y;

	internal int Width;

	internal int Height;

	internal bool Visible;

	internal bool On;

	internal IntPtr gc;

	internal bool Paused;
}
