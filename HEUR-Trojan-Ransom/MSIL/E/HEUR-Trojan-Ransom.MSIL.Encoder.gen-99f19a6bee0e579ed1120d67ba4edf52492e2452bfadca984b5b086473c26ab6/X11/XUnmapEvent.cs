using System;

namespace X11;

internal struct XUnmapEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr xevent;

	internal IntPtr window;

	internal bool from_configure;
}
