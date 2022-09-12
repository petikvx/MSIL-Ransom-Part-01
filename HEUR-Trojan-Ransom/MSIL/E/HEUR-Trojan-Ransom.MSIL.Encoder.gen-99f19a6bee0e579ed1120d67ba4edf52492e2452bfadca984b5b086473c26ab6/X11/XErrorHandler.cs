using System;

namespace X11;

internal delegate int XErrorHandler(IntPtr DisplayHandle, ref XErrorEvent error_event);
