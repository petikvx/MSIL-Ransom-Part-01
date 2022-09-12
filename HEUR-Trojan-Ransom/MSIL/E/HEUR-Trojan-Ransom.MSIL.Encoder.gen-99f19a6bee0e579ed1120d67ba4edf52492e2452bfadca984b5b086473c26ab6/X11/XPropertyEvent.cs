using System;

namespace X11;

internal struct XPropertyEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr window;

	internal IntPtr atom;

	internal IntPtr time;

	internal int state;
}
