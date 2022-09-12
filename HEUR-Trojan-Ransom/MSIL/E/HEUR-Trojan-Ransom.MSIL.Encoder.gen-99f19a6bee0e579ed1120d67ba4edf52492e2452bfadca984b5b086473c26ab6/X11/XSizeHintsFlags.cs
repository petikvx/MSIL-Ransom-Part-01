using System;

namespace X11;

[Flags]
internal enum XSizeHintsFlags
{
	USPosition = 1,
	USSize = 2,
	PPosition = 4,
	PSize = 8,
	PMinSize = 0x10,
	PMaxSize = 0x20,
	PResizeInc = 0x40,
	PAspect = 0x80,
	PAllHints = 0xFC,
	PBaseSize = 0x100,
	PWinGravity = 0x200
}
