using System;

namespace X11;

internal struct XFocusChangeEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr window;

	internal int mode;

	internal NotifyDetail detail;
}
