using System;

namespace X11;

internal struct XSelectionRequestEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr owner;

	internal IntPtr requestor;

	internal IntPtr selection;

	internal IntPtr target;

	internal IntPtr property;

	internal IntPtr time;
}
