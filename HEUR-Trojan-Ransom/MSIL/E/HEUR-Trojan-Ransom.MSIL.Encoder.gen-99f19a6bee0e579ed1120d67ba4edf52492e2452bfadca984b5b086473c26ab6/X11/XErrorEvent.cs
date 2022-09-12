using System;

namespace X11;

internal struct XErrorEvent
{
	internal XEventName type;

	internal IntPtr display;

	internal IntPtr resourceid;

	internal IntPtr serial;

	internal byte error_code;

	internal XRequest request_code;

	internal byte minor_code;
}
