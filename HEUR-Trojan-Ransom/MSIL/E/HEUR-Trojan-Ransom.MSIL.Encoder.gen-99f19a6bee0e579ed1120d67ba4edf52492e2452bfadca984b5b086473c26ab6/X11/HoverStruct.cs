using System;
using System.Drawing;
using System.Windows.Forms;

namespace X11;

internal struct HoverStruct
{
	internal Timer Timer;

	internal IntPtr Window;

	internal int X;

	internal int Y;

	internal Size Size;

	internal int Interval;

	internal IntPtr Atom;
}
