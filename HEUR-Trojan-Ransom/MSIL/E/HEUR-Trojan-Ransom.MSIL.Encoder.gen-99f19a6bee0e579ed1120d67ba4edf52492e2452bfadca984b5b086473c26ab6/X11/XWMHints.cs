using System;

namespace X11;

internal struct XWMHints
{
	internal IntPtr flags;

	internal bool input;

	internal XInitialState initial_state;

	internal IntPtr icon_pixmap;

	internal IntPtr icon_window;

	internal int icon_x;

	internal int icon_y;

	internal IntPtr icon_mask;

	internal IntPtr window_group;
}
