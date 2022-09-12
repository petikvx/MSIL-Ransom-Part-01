using System;

namespace X11;

internal struct XWindowChanges
{
	internal int x;

	internal int y;

	internal int width;

	internal int height;

	internal int border_width;

	internal IntPtr sibling;

	internal StackMode stack_mode;
}
