using System;
using System.Drawing;

namespace X11;

internal struct GrabStruct
{
	internal bool Confined;

	internal IntPtr Hwnd;

	internal Rectangle Area;
}
