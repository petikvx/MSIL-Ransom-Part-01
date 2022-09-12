using System;

namespace X11;

internal struct XColormapEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr window;

	internal IntPtr colormap;

	internal bool c_new;

	internal int state;
}
