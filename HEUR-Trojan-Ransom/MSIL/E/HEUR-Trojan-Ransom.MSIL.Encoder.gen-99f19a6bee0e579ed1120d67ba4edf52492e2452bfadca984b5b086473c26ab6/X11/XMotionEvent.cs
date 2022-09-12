using System;

namespace X11;

internal struct XMotionEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr window;

	internal IntPtr root;

	internal IntPtr subwindow;

	internal IntPtr time;

	internal int x;

	internal int y;

	internal int x_root;

	internal int y_root;

	internal int state;

	internal byte is_hint;

	internal bool same_screen;
}
