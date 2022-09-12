using System;

namespace X11;

internal struct XClientMessageEvent
{
	internal XEventName type;

	internal IntPtr serial;

	internal bool send_event;

	internal IntPtr display;

	internal IntPtr window;

	internal IntPtr message_type;

	internal int format;

	internal IntPtr ptr1;

	internal IntPtr ptr2;

	internal IntPtr ptr3;

	internal IntPtr ptr4;

	internal IntPtr ptr5;
}
