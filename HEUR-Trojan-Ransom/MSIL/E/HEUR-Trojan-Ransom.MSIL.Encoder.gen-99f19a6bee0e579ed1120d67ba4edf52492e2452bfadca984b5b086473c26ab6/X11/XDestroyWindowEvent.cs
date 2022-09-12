using System;

namespace X11;

internal struct XDestroyWindowEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr xevent;

	internal IntPtr window;
}
