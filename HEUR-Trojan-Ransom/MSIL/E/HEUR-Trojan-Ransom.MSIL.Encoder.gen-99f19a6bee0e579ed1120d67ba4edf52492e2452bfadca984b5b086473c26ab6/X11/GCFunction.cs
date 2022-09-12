using System;

namespace X11;

[Flags]
internal enum GCFunction
{
	GCFunction = 1,
	GCPlaneMask = 2,
	GCForeground = 4,
	GCBackground = 8,
	GCLineWidth = 0x10,
	GCLineStyle = 0x20,
	GCCapStyle = 0x40,
	GCJoinStyle = 0x80,
	GCFillStyle = 0x100,
	GCFillRule = 0x200,
	GCTile = 0x400,
	GCStipple = 0x800,
	GCTileStipXOrigin = 0x1000,
	GCTileStipYOrigin = 0x2000,
	GCFont = 0x4000,
	GCSubwindowMode = 0x8000,
	GCGraphicsExposures = 0x10000,
	GCClipXOrigin = 0x20000,
	GCClipYOrigin = 0x40000,
	GCClipMask = 0x80000,
	GCDashOffset = 0x100000,
	GCDashList = 0x200000,
	GCArcMode = 0x400000
}
