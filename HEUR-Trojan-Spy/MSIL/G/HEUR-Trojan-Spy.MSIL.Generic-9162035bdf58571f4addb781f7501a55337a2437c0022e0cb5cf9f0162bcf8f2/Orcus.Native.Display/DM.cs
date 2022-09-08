using System;

namespace Orcus.Native.Display;

[Flags]
internal enum DM
{
	Orientation = 1,
	PaperSize = 2,
	PaperLength = 4,
	PaperWidth = 8,
	Scale = 0x10,
	Position = 0x20,
	NUP = 0x40,
	DisplayOrientation = 0x80,
	Copies = 0x100,
	DefaultSource = 0x200,
	PrintQuality = 0x400,
	Color = 0x800,
	Duplex = 0x1000,
	YResolution = 0x2000,
	TTOption = 0x4000,
	Collate = 0x8000,
	FormName = 0x10000,
	LogPixels = 0x20000,
	BitsPerPixel = 0x40000,
	PelsWidth = 0x80000,
	PelsHeight = 0x100000,
	DisplayFlags = 0x200000,
	DisplayFrequency = 0x400000,
	ICMMethod = 0x800000,
	ICMIntent = 0x1000000,
	MediaType = 0x2000000,
	DitherType = 0x4000000,
	PanningWidth = 0x8000000,
	PanningHeight = 0x10000000,
	DisplayFixedOutput = 0x20000000
}
