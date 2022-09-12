using System;

namespace X11;

[Flags]
internal enum XIMProperties
{
	XIMPreeditArea = 1,
	XIMPreeditCallbacks = 2,
	XIMPreeditPosition = 4,
	XIMPreeditNothing = 8,
	XIMPreeditNone = 0x10,
	XIMStatusArea = 0x100,
	XIMStatusCallbacks = 0x200,
	XIMStatusNothing = 0x400,
	XIMStatusNone = 0x800
}
