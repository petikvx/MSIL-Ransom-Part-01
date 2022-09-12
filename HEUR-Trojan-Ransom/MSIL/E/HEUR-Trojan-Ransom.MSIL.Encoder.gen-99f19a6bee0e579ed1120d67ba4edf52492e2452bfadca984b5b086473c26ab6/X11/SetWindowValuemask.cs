using System;

namespace X11;

[Flags]
internal enum SetWindowValuemask
{
	Nothing = 0,
	BackPixmap = 1,
	BackPixel = 2,
	BorderPixmap = 4,
	BorderPixel = 8,
	BitGravity = 0x10,
	WinGravity = 0x20,
	BackingStore = 0x40,
	BackingPlanes = 0x80,
	BackingPixel = 0x100,
	OverrideRedirect = 0x200,
	SaveUnder = 0x400,
	EventMask = 0x800,
	DontPropagate = 0x1000,
	ColorMap = 0x2000,
	Cursor = 0x4000
}
